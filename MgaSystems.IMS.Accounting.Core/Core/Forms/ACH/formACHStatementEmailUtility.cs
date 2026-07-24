// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Core.Forms.ACH.formACHStatementEmailUtility
// Assembly: MgaSystems.IMS.Accounting.Core, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 923053EF-B70A-44B5-B8DA-B227263F4FD2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Core.dll

using Infragistics.Shared;
using Infragistics.Win;
using Infragistics.Win.Layout;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using Infragistics.Win.UltraWinToolbars;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.IMS.Accounting.Core.Properties;
using MGASystems.IMS.Security;
using MGASystems.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Core.Forms.ACH;

public class formACHStatementEmailUtility : FormBase
{
  public string sprocName = "spFin_GetACHPaymentStatements";
  public ACHStatementReportOption reportOption;
  protected dsACHStatements _achStatementData = new dsACHStatements();
  protected ACHStatementServices _achEmailServices = new ACHStatementServices();
  private string _savedReportOption;
  private IContainer components;
  protected UltraToolbarsManager UltraToolbarsManager1;
  internal Panel panelACHEmailUtility;
  internal UltraToolbarsDockArea _panelACHEmailUtility_Toolbars_Dock_Area_Left;
  internal UltraToolbarsDockArea _panelACHEmailUtility_Toolbars_Dock_Area_Right;
  internal UltraToolbarsDockArea _panelACHEmailUtility_Toolbars_Dock_Area_Bottom;
  internal UltraToolbarsDockArea _panelACHEmailUtility_Toolbars_Dock_Area_Top;
  internal Panel FormACHStatementEmailUtility_Fill_Panel;
  public UltraGrid gridACHStatements;
  private MGATextBox textEmailSubject;
  private UltraLabel ultraLabel5;
  protected MGATextBox textEmailFooter;
  private UltraLabel ultraLabel4;
  private MGATextBox textEmailHeader;
  private UltraLabel ultraLabel1;
  private UltraLabel ultraLabel3;
  private dsACHStatements dsACHStatements1;
  private MGASimpleComboBox comboACHReportOptions;

  public formACHStatementEmailUtility() => this.InitializeComponent();

  private void LoadACHStatements()
  {
    this.Cursor = MgaCursors.WaitCursor;
    ((UltraControlBase) this.gridACHStatements).BeginUpdate();
    this.dsACHStatements1.Clear();
    this.dsACHStatements1.EnforceConstraints = false;
    DefaultDatabase.LoadDataSet((DataSet) this.dsACHStatements1, new string[3]
    {
      "Producers",
      "Invoices",
      "ACHTransactions"
    }, this.sprocName);
    ((UltraControlBase) this.gridACHStatements).EndUpdate();
    this.Cursor = MgaCursors.Default;
  }

  private void ToggleCheckAll(bool value)
  {
    this.Cursor = MgaCursors.WaitCursor;
    try
    {
      foreach (UltraGridRow row1 in ((UltraGridBase) this.gridACHStatements).Rows)
      {
        row1.Cells["SELECTED"].Value = (object) value;
        row1.Update();
        foreach (UltraGridRow row2 in row1.ChildBands[0].Rows)
        {
          row2.Cells["SELECTED"].Value = (object) value;
          row2.Update();
        }
      }
    }
    finally
    {
      this.Cursor = MgaCursors.Default;
    }
  }

  private void gridACHStatements_AfterCellUpdate(object sender, CellEventArgs e)
  {
    if (((KeyedSubObjectBase) e.Cell.Column).Key.ToUpper() != "SELECTED")
      return;
    this.gridACHStatements.EventManager.SetEnabled((EventGroups) 0, false);
    if (((GridItemBase) e.Cell.Row).Band.Index == 0)
    {
      foreach (UltraGridRow row in e.Cell.Row.ChildBands[0].Rows)
      {
        row.Cells["SELECTED"].Value = e.Cell.Value;
        row.Update();
      }
    }
    else if ((bool) e.Cell.Value)
    {
      e.Cell.Row.ParentRow.Cells["SELECTED"].Value = (object) true;
      e.Cell.Row.ParentRow.Update();
    }
    else
    {
      bool flag = false;
      foreach (UltraGridRow row in e.Cell.Row.ParentRow.ChildBands[0].Rows)
      {
        if ((bool) row.Cells["SELECTED"].Value)
        {
          flag = true;
          break;
        }
      }
      e.Cell.Row.ParentRow.Cells["SELECTED"].Value = (object) flag;
      e.Cell.Row.ParentRow.Update();
    }
    this.gridACHStatements.EventManager.SetEnabled((EventGroups) 0, true);
  }

  private void UltraToolbarsManager1_ToolClick(object sender, ToolClickEventArgs e)
  {
    switch (((KeyedSubObjectBase) ((ToolEventArgs) e).Tool).Key)
    {
      case "ProcessEmails":
        this.ProcessACHEmails(((Control) this.textEmailSubject).Text, ((Control) this.textEmailHeader).Text, ((Control) this.textEmailFooter).Text, this.comboACHReportOptions.Value.ToString());
        break;
      case "SaveSettings":
        this.SaveSettings();
        break;
      case "CheckAll":
        this.ToggleCheckAll(true);
        break;
      case "UnCheckAll":
        this.ToggleCheckAll(false);
        break;
      case "Refresh":
        this.LoadACHStatements();
        break;
    }
  }

  private void SaveSettings()
  {
    DefaultDatabase.ExecuteNonQuery("spfin_InsertACHPaymentStatementsVerbiage", new object[8]
    {
      (object) "@emailSubject",
      (object) ((Control) this.textEmailSubject).Text,
      (object) "@emailHeader",
      (object) ((Control) this.textEmailHeader).Text,
      (object) "@emailFooter",
      (object) ((Control) this.textEmailFooter).Text,
      (object) "@reportOption",
      (object) this.comboACHReportOptions.Value.ToString()
    });
    int num = (int) MessageBox.Show("ACH Statement Email Verbiage Saved", "Save Email Verbiage");
  }

  protected virtual void LoadSettings()
  {
    DataTable dataTable = DefaultDatabase.ExecuteDataTable("spfin_GetACHStatementNotificationSettings");
    if (dataTable.Rows.Count == 0)
    {
      int num = (int) MessageBox.Show("Please fill in ACH Statement Email Verbiage and save.", "Setup Email Verbiage");
    }
    else
    {
      ((Control) this.textEmailSubject).Text = dataTable.Rows[0].Field<string>("EmailSubject");
      ((Control) this.textEmailHeader).Text = dataTable.Rows[0].Field<string>("EmailHeader");
      ((Control) this.textEmailFooter).Text = dataTable.Rows[0].Field<string>("EmailFooter");
      this.comboACHReportOptions.Value = (object) dataTable.Rows[0].Field<string>("ReportOption");
      this._savedReportOption = dataTable.Rows[0].Field<string>("ReportOption");
    }
  }

  protected virtual dsACHStatements GenerateACHEmailDataSet(dsACHStatements data)
  {
    dsACHStatements dsAchStatements = new dsACHStatements();
    dsAchStatements.EnforceConstraints = false;
    dsACHStatements achEmailDataSet = dsAchStatements;
    foreach (dsACHStatements.ProducersRow producer in (TypedTableBase<dsACHStatements.ProducersRow>) data.Producers)
    {
      if (producer.Selected)
      {
        achEmailDataSet.Producers.AddProducersRow(producer.ProducerGuid, producer.ProducerName, producer.ContactName, producer.ContactEmail, producer.ACHSentAmount, producer.Selected);
        foreach (dsACHStatements.InvoicesRow childRow in producer.GetChildRows(data.Relations[0]) as dsACHStatements.InvoicesRow[])
        {
          if (childRow.Selected)
          {
            achEmailDataSet.Invoices.AddInvoicesRow(childRow.TransActNum, childRow.InvoiceNum, childRow.OfficeInvoiceNum, childRow.ProducerGuid, childRow.PolicyNumber, childRow.InsuredPolicyName, childRow.Selected, childRow.ContactName);
            foreach (dsACHStatements.ACHTransactionsRow row in (InternalDataCollectionBase) data.ACHTransactions.Rows)
            {
              if (row.Selected && achEmailDataSet.ACHTransactions.Select("ACHPaymentSentID = " + row.ACHPaymentSentID.ToString()).Length == 0)
                achEmailDataSet.ACHTransactions.AddACHTransactionsRow(int.Parse(row["ACHPaymentSentID"].ToString()), (Guid) row["payeeguid"], int.Parse(row["transactnum"].ToString()), (bool) row["Selected"]);
            }
          }
        }
      }
    }
    return achEmailDataSet;
  }

  protected virtual void LoadReportOptions()
  {
    List<string> stringList = new List<string>();
    ((UltraGridBase) this.comboACHReportOptions).DataSource = (object) DefaultDatabase.ExecuteDataSet("spFin_GetACHReportOptions");
    ((UltraDropDownBase) this.comboACHReportOptions).DisplayMember = "ACHReportDescription";
    ((UltraDropDownBase) this.comboACHReportOptions).ValueMember = "ACHReportName";
  }

  private void formACHStatementEmailUtility_Load(object sender, EventArgs e)
  {
    if (this.DesignMode)
      return;
    this.LoadReportOptions();
    this.LoadSettings();
    this.LoadACHStatements();
    ((Control) this.comboACHReportOptions).Enabled = SecurityManager.Instance.AssertPermission("{F77001F8-786D-48D8-9C32-2EFA7CAD4FEA}");
  }

  private List<string> BuildStatementFieldList()
  {
    return new List<string>()
    {
      "Invoice #",
      "Policy #",
      "Insured"
    };
  }

  private void gridACHStatements_CellChange(object sender, CellEventArgs e) => e.Cell.Row.Update();

  private void gridACHStatements_ClickCellButton(object sender, CellEventArgs e)
  {
    e.Cell.Row.Update();
  }

  protected virtual void ProcessACHEmails(
    string emailSubject,
    string emailHeader,
    string emailFooter,
    string userReportOption)
  {
    if (userReportOption != this._savedReportOption)
    {
      switch (MessageBox.Show("Do want to continue to send the ACH Payment Report using the new selected report?", "ACH Statement Report has changed", MessageBoxButtons.YesNo))
      {
        case DialogResult.Yes:
          this.reportOption = (ACHStatementReportOption) Enum.Parse(typeof (ACHStatementReportOption), userReportOption);
          this._achEmailServices.ProcessEmail(emailSubject, emailHeader, this.BuildStatementFieldList(), this.GenerateACHEmailDataSet(this.dsACHStatements1), emailFooter, this.reportOption);
          break;
        case DialogResult.No:
          return;
      }
    }
    else
    {
      this.reportOption = (ACHStatementReportOption) Enum.Parse(typeof (ACHStatementReportOption), userReportOption);
      this._achEmailServices.ProcessEmail(emailSubject, emailHeader, this.BuildStatementFieldList(), this.GenerateACHEmailDataSet(this.dsACHStatements1), emailFooter, this.reportOption);
    }
    this.Close();
  }

  private void gridACHStatements_ClickCell(object sender, ClickCellEventArgs e)
  {
    if (!(((ControlUIElementBase) ((UltraGridBase) (sender as UltraGrid)).DisplayLayout.UIElement).LastElementEntered.GetContext(typeof (UltraGridCell)) is UltraGridCell) || ((KeyedSubObjectBase) e.Cell.Column).Key.ToUpper() != "SELECTED")
      return;
    this.gridACHStatements.EventManager.SetEnabled((EventGroups) 0, false);
    if (((GridItemBase) e.Cell.Row).Band.Index == 0)
    {
      foreach (UltraGridRow row in e.Cell.Row.ChildBands[0].Rows)
      {
        row.Cells["SELECTED"].Value = e.Cell.Value;
        row.Update();
      }
    }
    else if (!(bool) e.Cell.Value)
    {
      e.Cell.Row.ParentRow.Cells["SELECTED"].Value = (object) true;
      e.Cell.Row.ParentRow.Update();
    }
    else
    {
      bool flag = false;
      foreach (UltraGridRow row in e.Cell.Row.ChildBands[0].Rows)
      {
        if ((bool) row.Cells["SELECTED"].Value)
        {
          flag = true;
          break;
        }
      }
      e.Cell.Row.ParentRow.Cells["SELECTED"].Value = (object) flag;
      e.Cell.Row.ParentRow.Update();
    }
    this.gridACHStatements.EventManager.SetEnabled((EventGroups) 0, true);
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    UltraToolbar ultraToolbar = new UltraToolbar("ACHEmailStatement");
    ButtonTool buttonTool1 = new ButtonTool("ProcessEmails");
    ButtonTool buttonTool2 = new ButtonTool("SaveSettings");
    ButtonTool buttonTool3 = new ButtonTool("CheckAll");
    ButtonTool buttonTool4 = new ButtonTool("UnCheckAll");
    ButtonTool buttonTool5 = new ButtonTool("Refresh");
    ControlContainerTool controlContainerTool1 = new ControlContainerTool("ControlContainerTool1");
    ButtonTool buttonTool6 = new ButtonTool("ProcessEmails");
    Appearance appearance1 = new Appearance();
    ButtonTool buttonTool7 = new ButtonTool("SaveSettings");
    Appearance appearance2 = new Appearance();
    ButtonTool buttonTool8 = new ButtonTool("CheckAll");
    Appearance appearance3 = new Appearance();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (formACHStatementEmailUtility));
    ButtonTool buttonTool9 = new ButtonTool("UnCheckAll");
    Appearance appearance4 = new Appearance();
    ButtonTool buttonTool10 = new ButtonTool("Refresh");
    Appearance appearance5 = new Appearance();
    ControlContainerTool controlContainerTool2 = new ControlContainerTool("datetimeToControlContainer");
    ControlContainerTool controlContainerTool3 = new ControlContainerTool("datetimeFromControlContainer");
    ControlContainerTool controlContainerTool4 = new ControlContainerTool("ControlContainerTool1");
    Appearance appearance6 = new Appearance();
    UltraGridBand ultraGridBand1 = new UltraGridBand("Producers", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("ProducerGuid");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("ProducerName");
    Appearance appearance7 = new Appearance();
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("ContactName");
    Appearance appearance8 = new Appearance();
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("ContactEmail");
    Appearance appearance9 = new Appearance();
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("ACHSentAmount");
    Appearance appearance10 = new Appearance();
    Appearance appearance11 = new Appearance();
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("Selected");
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("Producers_Invoices");
    UltraGridBand ultraGridBand2 = new UltraGridBand("Producers_Invoices", 0);
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("TransActNum");
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("InvoiceNum");
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("OfficeInvoiceNum");
    Appearance appearance12 = new Appearance();
    UltraGridColumn ultraGridColumn11 = new UltraGridColumn("ProducerGuid");
    UltraGridColumn ultraGridColumn12 = new UltraGridColumn("PolicyNumber");
    Appearance appearance13 = new Appearance();
    UltraGridColumn ultraGridColumn13 = new UltraGridColumn("InsuredPolicyName");
    Appearance appearance14 = new Appearance();
    UltraGridColumn ultraGridColumn14 = new UltraGridColumn("Selected");
    UltraGridColumn ultraGridColumn15 = new UltraGridColumn("ContactName");
    UltraGridColumn ultraGridColumn16 = new UltraGridColumn("Invoices_ACHTransactions");
    UltraGridBand ultraGridBand3 = new UltraGridBand("Invoices_ACHTransactions", 1);
    UltraGridColumn ultraGridColumn17 = new UltraGridColumn("ACHPaymentSentID");
    UltraGridColumn ultraGridColumn18 = new UltraGridColumn("payeeguid");
    UltraGridColumn ultraGridColumn19 = new UltraGridColumn("transactnum");
    UltraGridColumn ultraGridColumn20 = new UltraGridColumn("Selected");
    Appearance appearance15 = new Appearance();
    Appearance appearance16 = new Appearance();
    Appearance appearance17 = new Appearance();
    Appearance appearance18 = new Appearance();
    Appearance appearance19 = new Appearance();
    Appearance appearance20 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    Appearance appearance21 = new Appearance();
    Appearance appearance22 = new Appearance();
    Appearance appearance23 = new Appearance();
    Appearance appearance24 = new Appearance();
    Appearance appearance25 = new Appearance();
    Appearance appearance26 = new Appearance();
    Appearance appearance27 = new Appearance();
    Appearance appearance28 = new Appearance();
    Appearance appearance29 = new Appearance();
    this.UltraToolbarsManager1 = new UltraToolbarsManager(this.components);
    this.panelACHEmailUtility = new Panel();
    this._panelACHEmailUtility_Toolbars_Dock_Area_Left = new UltraToolbarsDockArea();
    this._panelACHEmailUtility_Toolbars_Dock_Area_Right = new UltraToolbarsDockArea();
    this._panelACHEmailUtility_Toolbars_Dock_Area_Bottom = new UltraToolbarsDockArea();
    this._panelACHEmailUtility_Toolbars_Dock_Area_Top = new UltraToolbarsDockArea();
    this.FormACHStatementEmailUtility_Fill_Panel = new Panel();
    this.comboACHReportOptions = new MGASimpleComboBox();
    this.gridACHStatements = new UltraGrid();
    this.dsACHStatements1 = new dsACHStatements();
    this.textEmailSubject = new MGATextBox();
    this.ultraLabel5 = new UltraLabel();
    this.textEmailFooter = new MGATextBox();
    this.ultraLabel4 = new UltraLabel();
    this.textEmailHeader = new MGATextBox();
    this.ultraLabel1 = new UltraLabel();
    this.ultraLabel3 = new UltraLabel();
    ((ISupportInitialize) this.UltraToolbarsManager1).BeginInit();
    this.panelACHEmailUtility.SuspendLayout();
    this.FormACHStatementEmailUtility_Fill_Panel.SuspendLayout();
    ((ISupportInitialize) this.comboACHReportOptions).BeginInit();
    ((ISupportInitialize) this.gridACHStatements).BeginInit();
    this.dsACHStatements1.BeginInit();
    ((ISupportInitialize) this.textEmailSubject).BeginInit();
    ((ISupportInitialize) this.textEmailFooter).BeginInit();
    ((ISupportInitialize) this.textEmailHeader).BeginInit();
    this.SuspendLayout();
    this.UltraToolbarsManager1.DesignerFlags = 1;
    this.UltraToolbarsManager1.DockWithinContainer = (Control) this.panelACHEmailUtility;
    this.UltraToolbarsManager1.ShowFullMenusDelay = 500;
    this.UltraToolbarsManager1.Style = (ToolbarStyle) 5;
    ultraToolbar.DockedColumn = 0;
    ultraToolbar.DockedRow = 0;
    ultraToolbar.IsMainMenuBar = true;
    ((ToolBase) buttonTool2).InstanceProps.IsFirstInGroup = true;
    ((ToolBase) buttonTool3).InstanceProps.IsFirstInGroup = true;
    ((ToolBase) buttonTool5).InstanceProps.IsFirstInGroup = true;
    controlContainerTool1.ControlName = "comboACHReportOptions";
    ((ToolBase) controlContainerTool1).InstanceProps.IsFirstInGroup = true;
    ((UltraToolbarBase) ultraToolbar).NonInheritedTools.AddRange(new ToolBase[6]
    {
      (ToolBase) buttonTool1,
      (ToolBase) buttonTool2,
      (ToolBase) buttonTool3,
      (ToolBase) buttonTool4,
      (ToolBase) buttonTool5,
      (ToolBase) controlContainerTool1
    });
    ultraToolbar.Settings.AllowDockTop = (DefaultableBoolean) 1;
    ultraToolbar.Settings.CaptionPlacement = (TextPlacement) 2;
    ultraToolbar.Settings.FillEntireRow = (DefaultableBoolean) 1;
    ultraToolbar.Settings.GrabHandleStyle = (GrabHandleStyle) 1;
    ((SettingsBase) ultraToolbar.Settings).ToolDisplayStyle = (ToolDisplayStyle) 4;
    ultraToolbar.ShowInToolbarList = false;
    ultraToolbar.Text = "ACHEmailStatement";
    this.UltraToolbarsManager1.Toolbars.AddRange(new UltraToolbar[1]
    {
      ultraToolbar
    });
    ((AppearanceBase) appearance1).Image = (object) Resources.email_open_image;
    ((ToolPropsBase) ((ToolBase) buttonTool6).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance1;
    ((ToolPropsBase) ((ToolBase) buttonTool6).SharedPropsInternal).Caption = "Process Emails";
    ((ToolPropsBase) ((ToolBase) buttonTool6).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((AppearanceBase) appearance2).Image = (object) Resources.disk;
    ((ToolPropsBase) ((ToolBase) buttonTool7).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance2;
    ((ToolPropsBase) ((ToolBase) buttonTool7).SharedPropsInternal).Caption = "Save Settings";
    ((ToolPropsBase) ((ToolBase) buttonTool7).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((AppearanceBase) appearance3).Image = componentResourceManager.GetObject("appearance3.Image");
    ((ToolPropsBase) ((ToolBase) buttonTool8).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance3;
    ((ToolPropsBase) ((ToolBase) buttonTool8).SharedPropsInternal).Caption = "Check All";
    ((ToolPropsBase) ((ToolBase) buttonTool8).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((AppearanceBase) appearance4).Image = (object) Resources.delete;
    ((ToolPropsBase) ((ToolBase) buttonTool9).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance4;
    ((ToolPropsBase) ((ToolBase) buttonTool9).SharedPropsInternal).Caption = "Un-Check All";
    ((ToolPropsBase) ((ToolBase) buttonTool9).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((AppearanceBase) appearance5).Image = componentResourceManager.GetObject("appearance5.Image");
    ((ToolPropsBase) ((ToolBase) buttonTool10).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance5;
    ((ToolPropsBase) ((ToolBase) buttonTool10).SharedPropsInternal).Caption = "Refresh";
    ((ToolPropsBase) ((ToolBase) buttonTool10).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((ToolPropsBase) ((ToolBase) controlContainerTool2).SharedPropsInternal).Caption = "To:";
    ((ToolPropsBase) ((ToolBase) controlContainerTool2).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 2;
    ((ToolPropsBase) ((ToolBase) controlContainerTool3).SharedPropsInternal).Caption = "From:";
    ((ToolPropsBase) ((ToolBase) controlContainerTool3).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 2;
    controlContainerTool4.ControlName = "comboACHReportOptions";
    ((ToolPropsBase) ((ToolBase) controlContainerTool4).SharedPropsInternal).Caption = "Report Options";
    ((ToolsCollectionBase) this.UltraToolbarsManager1.Tools).AddRange(new ToolBase[8]
    {
      (ToolBase) buttonTool6,
      (ToolBase) buttonTool7,
      (ToolBase) buttonTool8,
      (ToolBase) buttonTool9,
      (ToolBase) buttonTool10,
      (ToolBase) controlContainerTool2,
      (ToolBase) controlContainerTool3,
      (ToolBase) controlContainerTool4
    });
    ((UltraComponentControlManagerBase) this.UltraToolbarsManager1).UseFlatMode = (DefaultableBoolean) 2;
    ((UltraComponentControlManagerBase) this.UltraToolbarsManager1).UseOsThemes = (DefaultableBoolean) 2;
    this.UltraToolbarsManager1.ToolClick += new ToolClickEventHandler(this.UltraToolbarsManager1_ToolClick);
    this.panelACHEmailUtility.Controls.Add((Control) this._panelACHEmailUtility_Toolbars_Dock_Area_Left);
    this.panelACHEmailUtility.Controls.Add((Control) this._panelACHEmailUtility_Toolbars_Dock_Area_Right);
    this.panelACHEmailUtility.Controls.Add((Control) this._panelACHEmailUtility_Toolbars_Dock_Area_Bottom);
    this.panelACHEmailUtility.Controls.Add((Control) this._panelACHEmailUtility_Toolbars_Dock_Area_Top);
    this.panelACHEmailUtility.Location = new Point(1, 2);
    this.panelACHEmailUtility.Name = "panelACHEmailUtility";
    this.panelACHEmailUtility.Size = new Size(827, 49);
    this.panelACHEmailUtility.TabIndex = 0;
    ((Control) this._panelACHEmailUtility_Toolbars_Dock_Area_Left).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._panelACHEmailUtility_Toolbars_Dock_Area_Left).BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this._panelACHEmailUtility_Toolbars_Dock_Area_Left.DockedPosition = (DockedPosition) 2;
    ((Control) this._panelACHEmailUtility_Toolbars_Dock_Area_Left).ForeColor = SystemColors.ControlText;
    ((Control) this._panelACHEmailUtility_Toolbars_Dock_Area_Left).Location = new Point(0, 45);
    ((Control) this._panelACHEmailUtility_Toolbars_Dock_Area_Left).Name = "_panelACHEmailUtility_Toolbars_Dock_Area_Left";
    ((Control) this._panelACHEmailUtility_Toolbars_Dock_Area_Left).Size = new Size(0, 4);
    this._panelACHEmailUtility_Toolbars_Dock_Area_Left.ToolbarsManager = this.UltraToolbarsManager1;
    ((Control) this._panelACHEmailUtility_Toolbars_Dock_Area_Right).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._panelACHEmailUtility_Toolbars_Dock_Area_Right).BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this._panelACHEmailUtility_Toolbars_Dock_Area_Right.DockedPosition = (DockedPosition) 3;
    ((Control) this._panelACHEmailUtility_Toolbars_Dock_Area_Right).ForeColor = SystemColors.ControlText;
    ((Control) this._panelACHEmailUtility_Toolbars_Dock_Area_Right).Location = new Point(827, 45);
    ((Control) this._panelACHEmailUtility_Toolbars_Dock_Area_Right).Name = "_panelACHEmailUtility_Toolbars_Dock_Area_Right";
    ((Control) this._panelACHEmailUtility_Toolbars_Dock_Area_Right).Size = new Size(0, 4);
    this._panelACHEmailUtility_Toolbars_Dock_Area_Right.ToolbarsManager = this.UltraToolbarsManager1;
    ((Control) this._panelACHEmailUtility_Toolbars_Dock_Area_Bottom).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._panelACHEmailUtility_Toolbars_Dock_Area_Bottom).BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this._panelACHEmailUtility_Toolbars_Dock_Area_Bottom.DockedPosition = (DockedPosition) 1;
    ((Control) this._panelACHEmailUtility_Toolbars_Dock_Area_Bottom).ForeColor = SystemColors.ControlText;
    ((Control) this._panelACHEmailUtility_Toolbars_Dock_Area_Bottom).Location = new Point(0, 49);
    ((Control) this._panelACHEmailUtility_Toolbars_Dock_Area_Bottom).Name = "_panelACHEmailUtility_Toolbars_Dock_Area_Bottom";
    ((Control) this._panelACHEmailUtility_Toolbars_Dock_Area_Bottom).Size = new Size(827, 0);
    this._panelACHEmailUtility_Toolbars_Dock_Area_Bottom.ToolbarsManager = this.UltraToolbarsManager1;
    ((Control) this._panelACHEmailUtility_Toolbars_Dock_Area_Top).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._panelACHEmailUtility_Toolbars_Dock_Area_Top).BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this._panelACHEmailUtility_Toolbars_Dock_Area_Top.DockedPosition = (DockedPosition) 0;
    ((Control) this._panelACHEmailUtility_Toolbars_Dock_Area_Top).ForeColor = SystemColors.ControlText;
    ((Control) this._panelACHEmailUtility_Toolbars_Dock_Area_Top).Location = new Point(0, 0);
    ((Control) this._panelACHEmailUtility_Toolbars_Dock_Area_Top).Name = "_panelACHEmailUtility_Toolbars_Dock_Area_Top";
    ((Control) this._panelACHEmailUtility_Toolbars_Dock_Area_Top).Size = new Size(827, 45);
    this._panelACHEmailUtility_Toolbars_Dock_Area_Top.ToolbarsManager = this.UltraToolbarsManager1;
    this.FormACHStatementEmailUtility_Fill_Panel.BackColor = Color.White;
    this.FormACHStatementEmailUtility_Fill_Panel.Controls.Add((Control) this.comboACHReportOptions);
    this.FormACHStatementEmailUtility_Fill_Panel.Controls.Add((Control) this.gridACHStatements);
    this.FormACHStatementEmailUtility_Fill_Panel.Controls.Add((Control) this.textEmailSubject);
    this.FormACHStatementEmailUtility_Fill_Panel.Controls.Add((Control) this.ultraLabel5);
    this.FormACHStatementEmailUtility_Fill_Panel.Controls.Add((Control) this.textEmailFooter);
    this.FormACHStatementEmailUtility_Fill_Panel.Controls.Add((Control) this.ultraLabel4);
    this.FormACHStatementEmailUtility_Fill_Panel.Controls.Add((Control) this.textEmailHeader);
    this.FormACHStatementEmailUtility_Fill_Panel.Controls.Add((Control) this.ultraLabel1);
    this.FormACHStatementEmailUtility_Fill_Panel.Controls.Add((Control) this.ultraLabel3);
    this.FormACHStatementEmailUtility_Fill_Panel.Controls.Add((Control) this.panelACHEmailUtility);
    this.FormACHStatementEmailUtility_Fill_Panel.Cursor = Cursors.Default;
    this.FormACHStatementEmailUtility_Fill_Panel.Dock = DockStyle.Fill;
    this.FormACHStatementEmailUtility_Fill_Panel.Location = new Point(0, 0);
    this.FormACHStatementEmailUtility_Fill_Panel.Name = "FormACHStatementEmailUtility_Fill_Panel";
    this.FormACHStatementEmailUtility_Fill_Panel.Size = new Size(831, 819);
    this.FormACHStatementEmailUtility_Fill_Panel.TabIndex = 2;
    this.comboACHReportOptions.BorderStyle = (UIElementBorderStyle) 4;
    this.comboACHReportOptions.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboACHReportOptions).Location = new Point(525, 141);
    this.comboACHReportOptions.MGAStyle = MGAStyles.Blue;
    ((Control) this.comboACHReportOptions).Name = "comboACHReportOptions";
    ((Control) this.comboACHReportOptions).Size = new Size(218, 20);
    ((Control) this.comboACHReportOptions).TabIndex = 18;
    ((UltraControlBase) this.comboACHReportOptions).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboACHReportOptions).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridACHStatements).DataSource = (object) this.dsACHStatements1;
    ((AppearanceBase) appearance6).BackColor = Color.White;
    ((AppearanceBase) appearance6).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.gridACHStatements).DisplayLayout.Appearance = (AppearanceBase) appearance6;
    ((UltraGridBase) this.gridACHStatements).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ((HeaderBase) ultraGridColumn1.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn1.Header).VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn1.Width = 8;
    ((AppearanceBase) appearance7).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn2.Header).Appearance = (AppearanceBase) appearance7;
    ((HeaderBase) ultraGridColumn2.Header).Caption = "Producer";
    ((HeaderBase) ultraGridColumn2.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn2.Header).VisiblePosition = 2;
    ultraGridColumn2.Width = 203;
    ((AppearanceBase) appearance8).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn3.Header).Appearance = (AppearanceBase) appearance8;
    ((HeaderBase) ultraGridColumn3.Header).Caption = "Contact Name";
    ((HeaderBase) ultraGridColumn3.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn3.Header).VisiblePosition = 3;
    ultraGridColumn3.Width = 197;
    ((AppearanceBase) appearance9).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn4.Header).Appearance = (AppearanceBase) appearance9;
    ((HeaderBase) ultraGridColumn4.Header).Caption = "Contact Email";
    ((HeaderBase) ultraGridColumn4.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn4.Header).VisiblePosition = 4;
    ultraGridColumn4.Width = 209;
    ((AppearanceBase) appearance10).TextHAlignAsString = "Right";
    ultraGridColumn5.CellAppearance = (AppearanceBase) appearance10;
    ultraGridColumn5.Format = "c";
    ((AppearanceBase) appearance11).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn5.Header).Appearance = (AppearanceBase) appearance11;
    ((HeaderBase) ultraGridColumn5.Header).Caption = "Amount";
    ((HeaderBase) ultraGridColumn5.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn5.Header).VisiblePosition = 5;
    ultraGridColumn5.Width = 124;
    ((HeaderBase) ultraGridColumn6.Header).Caption = "";
    ((HeaderBase) ultraGridColumn6.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn6.Header).VisiblePosition = 1;
    ultraGridColumn6.Width = 53;
    ((HeaderBase) ultraGridColumn7.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn7.Header).VisiblePosition = 6;
    ultraGridBand1.Columns.AddRange(new object[7]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3,
      (object) ultraGridColumn4,
      (object) ultraGridColumn5,
      (object) ultraGridColumn6,
      (object) ultraGridColumn7
    });
    ((HeaderBase) ultraGridColumn8.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn8.Header).VisiblePosition = 4;
    ultraGridColumn8.Hidden = true;
    ultraGridColumn8.Width = 8;
    ((HeaderBase) ultraGridColumn9.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn9.Header).VisiblePosition = 5;
    ultraGridColumn9.Hidden = true;
    ultraGridColumn9.Width = 8;
    ((AppearanceBase) appearance12).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn10.Header).Appearance = (AppearanceBase) appearance12;
    ((HeaderBase) ultraGridColumn10.Header).Caption = "Invoice #";
    ((HeaderBase) ultraGridColumn10.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn10.Header).VisiblePosition = 1;
    ultraGridColumn10.Width = 149;
    ((HeaderBase) ultraGridColumn11.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn11.Header).VisiblePosition = 6;
    ultraGridColumn11.Hidden = true;
    ultraGridColumn11.Width = 8;
    ((AppearanceBase) appearance13).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn12.Header).Appearance = (AppearanceBase) appearance13;
    ((HeaderBase) ultraGridColumn12.Header).Caption = "Policy Number";
    ((HeaderBase) ultraGridColumn12.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn12.Header).VisiblePosition = 2;
    ultraGridColumn12.Width = 226;
    ((AppearanceBase) appearance14).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn13.Header).Appearance = (AppearanceBase) appearance14;
    ((HeaderBase) ultraGridColumn13.Header).Caption = "Insured";
    ((HeaderBase) ultraGridColumn13.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn13.Header).VisiblePosition = 3;
    ultraGridColumn13.Width = 311;
    ((HeaderBase) ultraGridColumn14.Header).Caption = "";
    ((HeaderBase) ultraGridColumn14.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn14.Header).VisiblePosition = 0;
    ultraGridColumn14.Width = 81;
    ((HeaderBase) ultraGridColumn15.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn15.Header).VisiblePosition = 7;
    ultraGridColumn15.Hidden = true;
    ultraGridColumn15.Width = 8;
    ((HeaderBase) ultraGridColumn16.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn16.Header).VisiblePosition = 8;
    ultraGridBand2.Columns.AddRange(new object[9]
    {
      (object) ultraGridColumn8,
      (object) ultraGridColumn9,
      (object) ultraGridColumn10,
      (object) ultraGridColumn11,
      (object) ultraGridColumn12,
      (object) ultraGridColumn13,
      (object) ultraGridColumn14,
      (object) ultraGridColumn15,
      (object) ultraGridColumn16
    });
    ((HeaderBase) ultraGridColumn17.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn17.Header).VisiblePosition = 0;
    ultraGridColumn17.Width = 178;
    ((HeaderBase) ultraGridColumn18.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn18.Header).VisiblePosition = 1;
    ultraGridColumn18.Width = 365;
    ((HeaderBase) ultraGridColumn19.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn19.Header).VisiblePosition = 2;
    ultraGridColumn19.Width = 117;
    ((HeaderBase) ultraGridColumn20.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn20.Header).VisiblePosition = 3;
    ultraGridColumn20.Width = 88;
    ultraGridBand3.Columns.AddRange(new object[4]
    {
      (object) ultraGridColumn17,
      (object) ultraGridColumn18,
      (object) ultraGridColumn19,
      (object) ultraGridColumn20
    });
    ultraGridBand3.Hidden = true;
    ((UltraGridBase) this.gridACHStatements).DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    ((UltraGridBase) this.gridACHStatements).DisplayLayout.BandsSerializer.Add((object) ultraGridBand2);
    ((UltraGridBase) this.gridACHStatements).DisplayLayout.BandsSerializer.Add((object) ultraGridBand3);
    ((UltraGridBase) this.gridACHStatements).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((AppearanceBase) appearance15).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance15).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance15).ForeColor = Color.Black;
    ((UltraGridBase) this.gridACHStatements).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance15;
    ((UltraGridBase) this.gridACHStatements).DisplayLayout.Override.AllowAddNew = (AllowAddNew) 2;
    ((UltraGridBase) this.gridACHStatements).DisplayLayout.Override.AllowColMoving = (AllowColMoving) 1;
    ((UltraGridBase) this.gridACHStatements).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.gridACHStatements).DisplayLayout.Override.AllowColSwapping = (AllowColSwapping) 1;
    ((UltraGridBase) this.gridACHStatements).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridACHStatements).DisplayLayout.Override.AllowGroupBy = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridACHStatements).DisplayLayout.Override.AllowGroupMoving = (AllowGroupMoving) 1;
    ((UltraGridBase) this.gridACHStatements).DisplayLayout.Override.AllowGroupSwapping = (AllowGroupSwapping) 1;
    ((UltraGridBase) this.gridACHStatements).DisplayLayout.Override.AllowMultiCellOperations = (AllowMultiCellOperation) 0;
    ((UltraGridBase) this.gridACHStatements).DisplayLayout.Override.AllowRowFiltering = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridACHStatements).DisplayLayout.Override.AllowRowLayoutCellSizing = (RowLayoutSizing) 1;
    ((UltraGridBase) this.gridACHStatements).DisplayLayout.Override.AllowRowLayoutCellSpanSizing = (GridBagLayoutAllowSpanSizing) 1;
    ((UltraGridBase) this.gridACHStatements).DisplayLayout.Override.AllowRowLayoutColMoving = (GridBagLayoutAllowMoving) 1;
    ((UltraGridBase) this.gridACHStatements).DisplayLayout.Override.AllowRowLayoutLabelSizing = (RowLayoutSizing) 1;
    ((UltraGridBase) this.gridACHStatements).DisplayLayout.Override.AllowRowLayoutLabelSpanSizing = (GridBagLayoutAllowSpanSizing) 1;
    ((UltraGridBase) this.gridACHStatements).DisplayLayout.Override.AllowRowSummaries = (AllowRowSummaries) 2;
    ((UltraGridBase) this.gridACHStatements).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 1;
    ((AppearanceBase) appearance16).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridACHStatements).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance16;
    ((AppearanceBase) appearance17).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.gridACHStatements).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance17;
    ((UltraGridBase) this.gridACHStatements).DisplayLayout.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance18).BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.gridACHStatements).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance18;
    ((AppearanceBase) appearance19).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridACHStatements).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance19;
    ((UltraGridBase) this.gridACHStatements).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance20).BackColor = Color.Transparent;
    ((AppearanceBase) appearance20).ForeColor = Color.Black;
    ((UltraGridBase) this.gridACHStatements).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance20;
    ((AppearanceBase) appearance21).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance21).BorderColor = Color.Silver;
    scrollBarLook.ButtonAppearance = (AppearanceBase) appearance21;
    ((AppearanceBase) appearance22).BackColor = Color.White;
    scrollBarLook.TrackAppearance = (AppearanceBase) appearance22;
    ((UltraGridBase) this.gridACHStatements).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((Control) this.gridACHStatements).Location = new Point(11, 246);
    ((Control) this.gridACHStatements).Name = "gridACHStatements";
    ((Control) this.gridACHStatements).Size = new Size(807, 341);
    ((Control) this.gridACHStatements).TabIndex = 17;
    ((UltraControlBase) this.gridACHStatements).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.gridACHStatements).UseOsThemes = (DefaultableBoolean) 2;
    this.gridACHStatements.AfterCellUpdate += new CellEventHandler(this.gridACHStatements_AfterCellUpdate);
    this.gridACHStatements.CellChange += new CellEventHandler(this.gridACHStatements_CellChange);
    this.gridACHStatements.ClickCellButton += new CellEventHandler(this.gridACHStatements_ClickCellButton);
    this.gridACHStatements.ClickCell += new ClickCellEventHandler(this.gridACHStatements_ClickCell);
    this.dsACHStatements1.DataSetName = "dsACHStatements";
    this.dsACHStatements1.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    ((AppearanceBase) appearance23).BackColor = Color.White;
    ((AppearanceBase) appearance23).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance23).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textEmailSubject).Appearance = (AppearanceBase) appearance23;
    ((Control) this.textEmailSubject).BackColor = Color.White;
    ((Control) this.textEmailSubject).Location = new Point(10, 77);
    ((TextEditorControlBase) this.textEmailSubject).MaxLength = 250;
    this.textEmailSubject.MGAStyle = MGAStyles.Blue;
    ((Control) this.textEmailSubject).Name = "textEmailSubject";
    ((Control) this.textEmailSubject).Size = new Size(807, 19);
    ((Control) this.textEmailSubject).TabIndex = 10;
    ((UltraControlBase) this.textEmailSubject).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textEmailSubject).UseOsThemes = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance24).BackColor = Color.Transparent;
    ((ControlBase) this.ultraLabel5).Appearance = (AppearanceBase) appearance24;
    ((Control) this.ultraLabel5).AutoSize = true;
    ((Control) this.ultraLabel5).Location = new Point(10, 59);
    ((Control) this.ultraLabel5).Name = "ultraLabel5";
    ((Control) this.ultraLabel5).Size = new Size(77, 14);
    ((Control) this.ultraLabel5).TabIndex = 9;
    ((Control) this.ultraLabel5).Text = "Email Subject:";
    ((Control) this.textEmailFooter).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
    ((AppearanceBase) appearance25).BackColor = Color.White;
    ((AppearanceBase) appearance25).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance25).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textEmailFooter).Appearance = (AppearanceBase) appearance25;
    ((Control) this.textEmailFooter).BackColor = Color.White;
    ((Control) this.textEmailFooter).Location = new Point(10, 633);
    ((TextEditorControlBase) this.textEmailFooter).MaxLength = 2000;
    this.textEmailFooter.MGAStyle = MGAStyles.Blue;
    this.textEmailFooter.Multiline = true;
    ((Control) this.textEmailFooter).Name = "textEmailFooter";
    ((Control) this.textEmailFooter).Size = new Size(807, 174);
    ((Control) this.textEmailFooter).TabIndex = 16 /*0x10*/;
    ((UltraControlBase) this.textEmailFooter).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textEmailFooter).UseOsThemes = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance26).BackColor = Color.Transparent;
    ((ControlBase) this.ultraLabel4).Appearance = (AppearanceBase) appearance26;
    ((Control) this.ultraLabel4).AutoSize = true;
    ((Control) this.ultraLabel4).Location = new Point(10, 614);
    ((Control) this.ultraLabel4).Name = "ultraLabel4";
    ((Control) this.ultraLabel4).Size = new Size(72, 14);
    ((Control) this.ultraLabel4).TabIndex = 15;
    ((Control) this.ultraLabel4).Text = "Email Footer:";
    ((AppearanceBase) appearance27).BackColor = Color.White;
    ((AppearanceBase) appearance27).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance27).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textEmailHeader).Appearance = (AppearanceBase) appearance27;
    ((Control) this.textEmailHeader).BackColor = Color.White;
    ((Control) this.textEmailHeader).Location = new Point(10, 126);
    ((TextEditorControlBase) this.textEmailHeader).MaxLength = 1000;
    this.textEmailHeader.MGAStyle = MGAStyles.Blue;
    this.textEmailHeader.Multiline = true;
    ((Control) this.textEmailHeader).Name = "textEmailHeader";
    ((Control) this.textEmailHeader).Size = new Size(807, 57);
    ((Control) this.textEmailHeader).TabIndex = 12;
    ((UltraControlBase) this.textEmailHeader).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textEmailHeader).UseOsThemes = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance28).BackColor = Color.Transparent;
    ((ControlBase) this.ultraLabel1).Appearance = (AppearanceBase) appearance28;
    ((Control) this.ultraLabel1).AutoSize = true;
    ((Control) this.ultraLabel1).Location = new Point(10, 106);
    ((Control) this.ultraLabel1).Name = "ultraLabel1";
    ((Control) this.ultraLabel1).Size = new Size(76, 14);
    ((Control) this.ultraLabel1).TabIndex = 11;
    ((Control) this.ultraLabel1).Text = "Email Header:";
    ((AppearanceBase) appearance29).BackColor = Color.Transparent;
    ((AppearanceBase) appearance29).ForeColor = Color.Red;
    ((AppearanceBase) appearance29).TextHAlignAsString = "Center";
    ((ControlBase) this.ultraLabel3).Appearance = (AppearanceBase) appearance29;
    ((Control) this.ultraLabel3).Font = new Font("Tahoma", 9f, FontStyle.Bold);
    ((Control) this.ultraLabel3).Location = new Point(10, 200);
    ((Control) this.ultraLabel3).Name = "ultraLabel3";
    ((Control) this.ultraLabel3).Size = new Size(807, 35);
    ((Control) this.ultraLabel3).TabIndex = 13;
    ((Control) this.ultraLabel3).Text = "ACH recipients without an email address have been excluded from this list. If you cannot find the ACH recipient you are looking for, please verify their email address and refresh this form.";
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(831, 819);
    this.Controls.Add((Control) this.FormACHStatementEmailUtility_Fill_Panel);
    this.Name = nameof (formACHStatementEmailUtility);
    this.Text = "ACH Statement Email Utility";
    this.Load += new EventHandler(this.formACHStatementEmailUtility_Load);
    ((ISupportInitialize) this.UltraToolbarsManager1).EndInit();
    this.panelACHEmailUtility.ResumeLayout(false);
    this.FormACHStatementEmailUtility_Fill_Panel.ResumeLayout(false);
    this.FormACHStatementEmailUtility_Fill_Panel.PerformLayout();
    ((ISupportInitialize) this.comboACHReportOptions).EndInit();
    ((ISupportInitialize) this.gridACHStatements).EndInit();
    this.dsACHStatements1.EndInit();
    ((ISupportInitialize) this.textEmailSubject).EndInit();
    ((ISupportInitialize) this.textEmailFooter).EndInit();
    ((ISupportInitialize) this.textEmailHeader).EndInit();
    this.ResumeLayout(false);
  }
}
