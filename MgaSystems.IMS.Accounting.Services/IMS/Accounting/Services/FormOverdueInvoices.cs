// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Services.FormOverdueInvoices
// Assembly: MgaSystems.IMS.Accounting.Services, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EEF87E2E-9738-4C33-AE03-5712A958CE99
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Services.dll

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
using MGASystems.IMS.Accounting.Services.Overdue_Invoice_Services;
using MGASystems.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Services;

public class FormOverdueInvoices : FormBase
{
  protected OverdueInvoiceServices _overdueInvoiceServices;
  private const int INVOICECOLUMNS = 5;
  private IContainer components;
  private UltraToolbarsManager ultraToolbarsManager1;
  private UltraToolbarsDockArea _FormOverdueInvoices_Toolbars_Dock_Area_Left;
  private UltraToolbarsDockArea _FormOverdueInvoices_Toolbars_Dock_Area_Right;
  private UltraToolbarsDockArea _FormOverdueInvoices_Toolbars_Dock_Area_Top;
  private UltraToolbarsDockArea _FormOverdueInvoices_Toolbars_Dock_Area_Bottom;
  private UltraLabel ultraLabel3;
  private UltraLabel ultraLabel2;
  private UltraLabel ultraLabel1;
  private MGATextBox textEmailHeader;
  private MGATextBox textEmailSubject;
  private UltraLabel ultraLabel5;
  private UltraLabel ultraLabel4;
  protected OverdueInvoiceDateRange overdueInvoiceDateRange1;
  public dsOverdueInvoices dsOverdueInvoices1;
  public UltraGrid gridOverdueInvoices;
  public UltraCheckEditor ultraCheckEditor1;
  protected MGATextBox textEmailFooter;

  public FormOverdueInvoices() => this.InitializeComponent();

  protected virtual void LoadInvoices(DateTime fromDate, DateTime toDate)
  {
    this._overdueInvoiceServices = (OverdueInvoiceServices) ObjectFactory.Instance.CreateObject(typeof (OverdueInvoiceServices), new object[2]
    {
      (object) fromDate,
      (object) toDate
    });
    ((UltraGridBase) this.gridOverdueInvoices).DataSource = (object) this._overdueInvoiceServices.OverdueInvoices;
    this.OnInvoicesLoaded();
  }

  public event EventHandler InvoicesLoaded;

  protected virtual void OnInvoicesLoaded()
  {
    if (this.InvoicesLoaded == null)
      return;
    this.InvoicesLoaded((object) this, (EventArgs) null);
  }

  private void ToggleCheckAll(bool value)
  {
    this.Cursor = MgaCursors.WaitCursor;
    try
    {
      foreach (UltraGridRow row1 in ((UltraGridBase) this.gridOverdueInvoices).Rows)
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

  private void gridOverdueInvoices_AfterCellUpdate(object sender, CellEventArgs e)
  {
    if (((KeyedSubObjectBase) e.Cell.Column).Key.ToUpper() != "SELECTED")
      return;
    this.gridOverdueInvoices.EventManager.SetEnabled((EventGroups) 0, false);
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
    this.gridOverdueInvoices.EventManager.SetEnabled((EventGroups) 0, true);
  }

  protected virtual void ultraToolbarsManager1_ToolClick(object sender, ToolClickEventArgs e)
  {
    switch (((KeyedSubObjectBase) ((ToolEventArgs) e).Tool).Key)
    {
      case "Process Selected Emails":
        this.ProcessEmails(((Control) this.textEmailSubject).Text, ((Control) this.textEmailHeader).Text, ((Control) this.textEmailFooter).Text, this.BuildInvoiceFieldList());
        break;
      case "CHECKALL":
        this.ToggleCheckAll(true);
        break;
      case "UNCHECKALL":
        this.ToggleCheckAll(false);
        break;
      case "SAVE":
        this.SaveSettings();
        break;
      case "Refresh":
        this.LoadInvoices(this.overdueInvoiceDateRange1.DateFrom, this.overdueInvoiceDateRange1.DateTo);
        break;
    }
  }

  private void SaveSettings()
  {
    DefaultDatabase.ExecuteNonQuery("spFin_InsertOverdueInvoiceVerbiage", new object[6]
    {
      (object) "@emailSubject",
      (object) ((Control) this.textEmailSubject).Text,
      (object) "@emailHeader",
      (object) ((Control) this.textEmailHeader).Text,
      (object) "@emailFooter",
      (object) ((Control) this.textEmailFooter).Text
    });
  }

  protected void LoadSettings()
  {
    DataTable dataTable = DefaultDatabase.ExecuteDataTable("spFin_GetOverdueInvoiceNotificationSettings");
    if (dataTable.Rows.Count == 0)
      return;
    ((Control) this.textEmailSubject).Text = dataTable.Rows[0]["EmailSubject"].ToString();
    ((Control) this.textEmailHeader).Text = dataTable.Rows[0]["EmailHeader"].ToString();
    ((Control) this.textEmailFooter).Text = dataTable.Rows[0]["EmailFooter"].ToString();
  }

  private void gridOverdueInvoices_ClickCellButton(object sender, CellEventArgs e)
  {
    e.Cell.Row.Update();
  }

  private void gridOverdueInvoices_CellChange(object sender, CellEventArgs e)
  {
    e.Cell.Row.Update();
  }

  protected virtual void ProcessEmails(
    string emailSubject,
    string emailHeader,
    string emailFooter,
    List<string> invoiceFieldListing)
  {
    this._overdueInvoiceServices.ProcessEmail(emailSubject, emailHeader, this.GenerateEmailDataset(this._overdueInvoiceServices.OverdueInvoices), emailFooter, invoiceFieldListing);
  }

  protected virtual dsOverdueInvoices GenerateEmailDataset(dsOverdueInvoices data)
  {
    dsOverdueInvoices emailDataset = new dsOverdueInvoices();
    foreach (dsOverdueInvoices.RemittersRow remitter in (TypedTableBase<dsOverdueInvoices.RemittersRow>) data.Remitters)
    {
      if (remitter.Selected)
      {
        if (remitter.IsUnderwriterEmailNull())
          emailDataset.Remitters.AddRemittersRow(remitter.RemitterGuid, remitter.RemitterName, remitter.ContactName, remitter.ContactEmail, string.Empty, remitter.Selected);
        else
          emailDataset.Remitters.AddRemittersRow(remitter.RemitterGuid, remitter.RemitterName, remitter.ContactName, remitter.ContactEmail, remitter.UnderwriterEmail, remitter.Selected);
        foreach (dsOverdueInvoices.InvoicesRow childRow in remitter.GetChildRows(data.Relations[0]) as dsOverdueInvoices.InvoicesRow[])
        {
          if (childRow.Selected)
            emailDataset.Invoices.AddInvoicesRow(childRow.InvoiceNum, childRow.OfficeInvoiceNum, childRow.RemitterGuid, childRow.RemitterType, childRow.PolicyNumber, childRow.InsuredPolicyName, childRow.DueDate, childRow.Amount, childRow.Selected, childRow.ContactName);
        }
      }
    }
    return emailDataset;
  }

  protected virtual void overdueInvoiceDateRange1_DateRangeChanged(object sender, EventArgs e)
  {
    this.LoadInvoices(this.overdueInvoiceDateRange1.DateFrom, this.overdueInvoiceDateRange1.DateTo);
  }

  protected virtual List<string> BuildInvoiceFieldList()
  {
    List<string> stringList1 = new List<string>();
    List<string> stringList2 = new List<string>();
    bool flag = MessageBox.Show("Do you want to show the amount in the email?", "Show Invoice Amount?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
    int num = 0;
    while (num != (flag ? 5 : 4))
    {
      foreach (UltraGridColumn column in ((UltraGridBase) this.gridOverdueInvoices).DisplayLayout.Bands[1].Columns)
      {
        if (!column.Hidden && ((KeyedSubObjectBase) column).Key != "Selected" && !stringList2.Contains(((KeyedSubObjectBase) column).Key))
        {
          if (num == 1 && ((HeaderBase) column.Header).VisiblePosition == num + 1)
          {
            switch (((KeyedSubObjectBase) column).Key.ToUpper())
            {
              case "OFFICEINVOICENUM":
                stringList1.Add("Invoice #");
                break;
              case "POLICYNUMBER":
                stringList1.Add("Policy #");
                break;
              case "INSUREDPOLICYNAME":
                stringList1.Add("Insured");
                break;
              case "AMOUNT":
                if (flag)
                {
                  stringList1.Add("Amount");
                  break;
                }
                break;
              case "DUEDATE":
                stringList1.Add("Due Date");
                break;
            }
            stringList2.Add(((KeyedSubObjectBase) column).Key);
            ++num;
            break;
          }
          if (((HeaderBase) column.Header).VisiblePosition == num + 1)
          {
            switch (((KeyedSubObjectBase) column).Key.ToUpper())
            {
              case "OFFICEINVOICENUM":
                stringList1.Add("Invoice #");
                break;
              case "POLICYNUMBER":
                stringList1.Add("Policy #");
                break;
              case "INSUREDPOLICYNAME":
                stringList1.Add("Insured");
                break;
              case "AMOUNT":
                if (flag)
                {
                  stringList1.Add("Amount");
                  break;
                }
                break;
              case "DUEDATE":
                stringList1.Add("Due Date");
                break;
            }
            stringList2.Add(((KeyedSubObjectBase) column).Key);
            ++num;
            break;
          }
        }
      }
    }
    return stringList1;
  }

  protected virtual void FormOverdueInvoices_Load(object sender, EventArgs e)
  {
    if (this.DesignMode)
      return;
    this.overdueInvoiceDateRange1.SetDates(new DateTime(DateTime.Now.Year, 1, 1), DateTime.Now);
    this.LoadInvoices(this.overdueInvoiceDateRange1.DateFrom, this.overdueInvoiceDateRange1.DateTo);
    this.LoadSettings();
  }

  private void gridOverdueInvoices_InitializeRow(object sender, InitializeRowEventArgs e)
  {
    if (!((KeyedSubObjectsCollectionBase) e.Row.Cells).Exists("UnderwriterEmail") || ((GridItemBase) e.Row).Band.Columns["underwriterEmail"].Hidden)
      return;
    if (e.Row.Cells["UnderwriterEmail"].EditorComponent == null)
      ((GridItemBase) e.Row).Band.Columns["underwriterEmail"].Hidden = true;
    else
      ((Control) e.Row.Cells["UnderwriterEmail"].EditorComponent).Text = e.Row.Cells["UnderwriterEmail"].Text;
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
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    UltraToolbar ultraToolbar = new UltraToolbar("MainToolbar");
    ButtonTool buttonTool1 = new ButtonTool("Process Selected Emails");
    ButtonTool buttonTool2 = new ButtonTool("SAVE");
    ButtonTool buttonTool3 = new ButtonTool("CHECKALL");
    ButtonTool buttonTool4 = new ButtonTool("UNCHECKALL");
    ButtonTool buttonTool5 = new ButtonTool("Refresh");
    ControlContainerTool controlContainerTool1 = new ControlContainerTool("ControlContainerTool1");
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    ButtonTool buttonTool6 = new ButtonTool("Process Selected Emails");
    Appearance appearance11 = new Appearance();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (FormOverdueInvoices));
    Appearance appearance12 = new Appearance();
    ButtonTool buttonTool7 = new ButtonTool("CHECKALL");
    Appearance appearance13 = new Appearance();
    ButtonTool buttonTool8 = new ButtonTool("UNCHECKALL");
    Appearance appearance14 = new Appearance();
    ButtonTool buttonTool9 = new ButtonTool("Refresh");
    Appearance appearance15 = new Appearance();
    ControlContainerTool controlContainerTool2 = new ControlContainerTool("ControlContainerTool1");
    Appearance appearance16 = new Appearance();
    ButtonTool buttonTool10 = new ButtonTool("SAVE");
    Appearance appearance17 = new Appearance();
    Appearance appearance18 = new Appearance();
    UltraGridBand ultraGridBand1 = new UltraGridBand("Remitters", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("RemitterGuid");
    Appearance appearance19 = new Appearance();
    Appearance appearance20 = new Appearance();
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("RemitterName");
    Appearance appearance21 = new Appearance();
    Appearance appearance22 = new Appearance();
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("ContactName");
    Appearance appearance23 = new Appearance();
    Appearance appearance24 = new Appearance();
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("ContactEmail");
    Appearance appearance25 = new Appearance();
    Appearance appearance26 = new Appearance();
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("UnderwriterEmail", -1, (object) null, 0, (SortIndicator) 1, false);
    Appearance appearance27 = new Appearance();
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("Selected");
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("FK_Remitters_Invoices");
    UltraGridBand ultraGridBand2 = new UltraGridBand("FK_Remitters_Invoices", 0);
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("InvoiceNum");
    Appearance appearance28 = new Appearance();
    Appearance appearance29 = new Appearance();
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("OfficeInvoiceNum");
    Appearance appearance30 = new Appearance();
    Appearance appearance31 = new Appearance();
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("RemitterGuid");
    Appearance appearance32 = new Appearance();
    Appearance appearance33 = new Appearance();
    UltraGridColumn ultraGridColumn11 = new UltraGridColumn("RemitterType");
    Appearance appearance34 = new Appearance();
    Appearance appearance35 = new Appearance();
    UltraGridColumn ultraGridColumn12 = new UltraGridColumn("PolicyNumber");
    Appearance appearance36 = new Appearance();
    Appearance appearance37 = new Appearance();
    UltraGridColumn ultraGridColumn13 = new UltraGridColumn("InsuredPolicyName");
    Appearance appearance38 = new Appearance();
    Appearance appearance39 = new Appearance();
    UltraGridColumn ultraGridColumn14 = new UltraGridColumn("DueDate");
    Appearance appearance40 = new Appearance();
    Appearance appearance41 = new Appearance();
    UltraGridColumn ultraGridColumn15 = new UltraGridColumn("Amount");
    Appearance appearance42 = new Appearance();
    Appearance appearance43 = new Appearance();
    UltraGridColumn ultraGridColumn16 = new UltraGridColumn("Selected");
    UltraGridColumn ultraGridColumn17 = new UltraGridColumn("ContactName", -1, (object) null, 0, (SortIndicator) 1, false);
    Appearance appearance44 = new Appearance();
    Appearance appearance45 = new Appearance();
    Appearance appearance46 = new Appearance();
    Appearance appearance47 = new Appearance();
    Appearance appearance48 = new Appearance();
    Appearance appearance49 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    Appearance appearance50 = new Appearance();
    Appearance appearance51 = new Appearance();
    this.ultraCheckEditor1 = new UltraCheckEditor();
    this.ultraLabel1 = new UltraLabel();
    this.ultraLabel2 = new UltraLabel();
    this.ultraLabel3 = new UltraLabel();
    this.textEmailHeader = new MGATextBox();
    this.ultraLabel4 = new UltraLabel();
    this.textEmailFooter = new MGATextBox();
    this.textEmailSubject = new MGATextBox();
    this.ultraLabel5 = new UltraLabel();
    this._FormOverdueInvoices_Toolbars_Dock_Area_Left = new UltraToolbarsDockArea();
    this.ultraToolbarsManager1 = new UltraToolbarsManager(this.components);
    this._FormOverdueInvoices_Toolbars_Dock_Area_Right = new UltraToolbarsDockArea();
    this._FormOverdueInvoices_Toolbars_Dock_Area_Top = new UltraToolbarsDockArea();
    this._FormOverdueInvoices_Toolbars_Dock_Area_Bottom = new UltraToolbarsDockArea();
    this.gridOverdueInvoices = new UltraGrid();
    this.dsOverdueInvoices1 = new dsOverdueInvoices();
    this.overdueInvoiceDateRange1 = new OverdueInvoiceDateRange();
    ((ISupportInitialize) this.ultraCheckEditor1).BeginInit();
    ((ISupportInitialize) this.textEmailHeader).BeginInit();
    ((ISupportInitialize) this.textEmailFooter).BeginInit();
    ((ISupportInitialize) this.textEmailSubject).BeginInit();
    ((ISupportInitialize) this.ultraToolbarsManager1).BeginInit();
    ((ISupportInitialize) this.gridOverdueInvoices).BeginInit();
    this.dsOverdueInvoices1.BeginInit();
    this.SuspendLayout();
    ((Control) this.ultraCheckEditor1).Location = new Point(48 /*0x30*/, 205);
    ((Control) this.ultraCheckEditor1).Name = "ultraCheckEditor1";
    ((Control) this.ultraCheckEditor1).Size = new Size(120, 20);
    ((Control) this.ultraCheckEditor1).TabIndex = 18;
    ((Control) this.ultraCheckEditor1).Text = "ultraCheckEditor1";
    ((Control) this.ultraCheckEditor1).Visible = false;
    ((AppearanceBase) appearance1).BackColor = Color.Transparent;
    ((ControlBase) this.ultraLabel1).Appearance = (AppearanceBase) appearance1;
    ((Control) this.ultraLabel1).AutoSize = true;
    ((Control) this.ultraLabel1).Location = new Point(12, 96 /*0x60*/);
    ((Control) this.ultraLabel1).Name = "ultraLabel1";
    ((Control) this.ultraLabel1).Size = new Size(75, 15);
    ((Control) this.ultraLabel1).TabIndex = 2;
    ((Control) this.ultraLabel1).Text = "Email Header:";
    ((AppearanceBase) appearance2).BackColor = Color.Transparent;
    ((ControlBase) this.ultraLabel2).Appearance = (AppearanceBase) appearance2;
    ((Control) this.ultraLabel2).AutoSize = true;
    ((Control) this.ultraLabel2).Location = new Point(12, 231);
    ((Control) this.ultraLabel2).Name = "ultraLabel2";
    ((Control) this.ultraLabel2).Size = new Size(156, 15);
    ((Control) this.ultraLabel2).TabIndex = 4;
    ((Control) this.ultraLabel2).Text = "Include the following invoices: ";
    ((AppearanceBase) appearance3).BackColor = Color.Transparent;
    ((AppearanceBase) appearance3).ForeColor = Color.Red;
    ((AppearanceBase) appearance3).TextHAlignAsString = "Center";
    ((ControlBase) this.ultraLabel3).Appearance = (AppearanceBase) appearance3;
    ((Control) this.ultraLabel3).Font = new Font("Tahoma", 9f, FontStyle.Bold);
    ((Control) this.ultraLabel3).Location = new Point(12, 190);
    ((Control) this.ultraLabel3).Name = "ultraLabel3";
    ((Control) this.ultraLabel3).Size = new Size(807, 35);
    ((Control) this.ultraLabel3).TabIndex = 5;
    ((Control) this.ultraLabel3).Text = "Agents and insureds without an email address have been excluded from this list. If you can not find the agent or insured you are looking for, please verify their email address and refresh this form.";
    ((AppearanceBase) appearance4).BackColor = Color.White;
    ((AppearanceBase) appearance4).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance4).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textEmailHeader).Appearance = (AppearanceBase) appearance4;
    ((Control) this.textEmailHeader).BackColor = Color.White;
    ((Control) this.textEmailHeader).Location = new Point(12, 116);
    ((TextEditorControlBase) this.textEmailHeader).MaxLength = 1000;
    this.textEmailHeader.MGAStyle = MGAStyles.Blue;
    this.textEmailHeader.Multiline = true;
    ((Control) this.textEmailHeader).Name = "textEmailHeader";
    this.textEmailHeader.Scrollbars = ScrollBars.Vertical;
    ((Control) this.textEmailHeader).Size = new Size(807, 57);
    ((Control) this.textEmailHeader).TabIndex = 3;
    ((UltraControlBase) this.textEmailHeader).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textEmailHeader).UseOsThemes = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance5).BackColor = Color.Transparent;
    ((ControlBase) this.ultraLabel4).Appearance = (AppearanceBase) appearance5;
    ((Control) this.ultraLabel4).AutoSize = true;
    ((Control) this.ultraLabel4).Location = new Point(12, 604);
    ((Control) this.ultraLabel4).Name = "ultraLabel4";
    ((Control) this.ultraLabel4).Size = new Size(71, 15);
    ((Control) this.ultraLabel4).TabIndex = 7;
    ((Control) this.ultraLabel4).Text = "Email Footer:";
    ((Control) this.textEmailFooter).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
    ((AppearanceBase) appearance6).BackColor = Color.White;
    ((AppearanceBase) appearance6).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance6).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textEmailFooter).Appearance = (AppearanceBase) appearance6;
    ((Control) this.textEmailFooter).BackColor = Color.White;
    ((Control) this.textEmailFooter).Location = new Point(12, 623);
    ((TextEditorControlBase) this.textEmailFooter).MaxLength = 2000;
    this.textEmailFooter.MGAStyle = MGAStyles.Blue;
    this.textEmailFooter.Multiline = true;
    ((Control) this.textEmailFooter).Name = "textEmailFooter";
    ((Control) this.textEmailFooter).Size = new Size(807, 190);
    ((Control) this.textEmailFooter).TabIndex = 8;
    ((UltraControlBase) this.textEmailFooter).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textEmailFooter).UseOsThemes = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance7).BackColor = Color.White;
    ((AppearanceBase) appearance7).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance7).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textEmailSubject).Appearance = (AppearanceBase) appearance7;
    ((Control) this.textEmailSubject).BackColor = Color.White;
    ((Control) this.textEmailSubject).Location = new Point(12, 67);
    ((TextEditorControlBase) this.textEmailSubject).MaxLength = 250;
    this.textEmailSubject.MGAStyle = MGAStyles.Blue;
    ((Control) this.textEmailSubject).Name = "textEmailSubject";
    ((Control) this.textEmailSubject).Size = new Size(807, 20);
    ((Control) this.textEmailSubject).TabIndex = 1;
    ((UltraControlBase) this.textEmailSubject).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textEmailSubject).UseOsThemes = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance8).BackColor = Color.Transparent;
    ((ControlBase) this.ultraLabel5).Appearance = (AppearanceBase) appearance8;
    ((Control) this.ultraLabel5).AutoSize = true;
    ((Control) this.ultraLabel5).Location = new Point(12, 49);
    ((Control) this.ultraLabel5).Name = "ultraLabel5";
    ((Control) this.ultraLabel5).Size = new Size(76, 15);
    ((Control) this.ultraLabel5).TabIndex = 0;
    ((Control) this.ultraLabel5).Text = "Email Subject:";
    ((Control) this._FormOverdueInvoices_Toolbars_Dock_Area_Left).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._FormOverdueInvoices_Toolbars_Dock_Area_Left).BackColor = Color.White;
    this._FormOverdueInvoices_Toolbars_Dock_Area_Left.DockedPosition = (DockedPosition) 2;
    ((Control) this._FormOverdueInvoices_Toolbars_Dock_Area_Left).ForeColor = Color.Black;
    ((Control) this._FormOverdueInvoices_Toolbars_Dock_Area_Left).Location = new Point(0, 46);
    ((Control) this._FormOverdueInvoices_Toolbars_Dock_Area_Left).Name = "_FormOverdueInvoices_Toolbars_Dock_Area_Left";
    ((Control) this._FormOverdueInvoices_Toolbars_Dock_Area_Left).Size = new Size(0, 773);
    this._FormOverdueInvoices_Toolbars_Dock_Area_Left.ToolbarsManager = this.ultraToolbarsManager1;
    this.ultraToolbarsManager1.DesignerFlags = 1;
    this.ultraToolbarsManager1.DockWithinContainer = (Control) this;
    this.ultraToolbarsManager1.DockWithinContainerBaseType = typeof (Form);
    this.ultraToolbarsManager1.MdiMergeable = false;
    this.ultraToolbarsManager1.ShowFullMenusDelay = 500;
    ultraToolbar.DockedColumn = 0;
    ultraToolbar.DockedRow = 0;
    ultraToolbar.IsMainMenuBar = true;
    ((ToolBase) buttonTool2).InstanceProps.IsFirstInGroup = true;
    ((ToolBase) buttonTool3).InstanceProps.IsFirstInGroup = true;
    ((ToolBase) buttonTool5).InstanceProps.IsFirstInGroup = true;
    controlContainerTool1.CanSetWidth = true;
    controlContainerTool1.ControlName = "overdueInvoiceDateRange1";
    ((ToolBase) controlContainerTool1).InstanceProps.IsFirstInGroup = true;
    ((ToolPropsBase) ((ToolBase) controlContainerTool1).InstanceProps).Width = 254;
    ((UltraToolbarBase) ultraToolbar).NonInheritedTools.AddRange(new ToolBase[6]
    {
      (ToolBase) buttonTool1,
      (ToolBase) buttonTool2,
      (ToolBase) buttonTool3,
      (ToolBase) buttonTool4,
      (ToolBase) buttonTool5,
      (ToolBase) controlContainerTool1
    });
    ultraToolbar.Settings.AllowCustomize = (DefaultableBoolean) 2;
    ultraToolbar.Settings.AllowDockBottom = (DefaultableBoolean) 2;
    ultraToolbar.Settings.AllowDockLeft = (DefaultableBoolean) 2;
    ultraToolbar.Settings.AllowDockRight = (DefaultableBoolean) 2;
    ultraToolbar.Settings.AllowDockTop = (DefaultableBoolean) 2;
    ultraToolbar.Settings.AllowFloating = (DefaultableBoolean) 2;
    ultraToolbar.Settings.AllowHiding = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance9).BackGradientStyle = (GradientStyle) 2;
    ((SettingsBase) ultraToolbar.Settings).Appearance = (AppearanceBase) appearance9;
    ultraToolbar.Settings.CaptionPlacement = (TextPlacement) 2;
    ultraToolbar.Settings.GrabHandleStyle = (GrabHandleStyle) 1;
    ((SettingsBase) ultraToolbar.Settings).ToolDisplayStyle = (ToolDisplayStyle) 4;
    ((SettingsBase) ultraToolbar.Settings).UseLargeImages = (DefaultableBoolean) 2;
    ultraToolbar.Text = "MainToolbar";
    this.ultraToolbarsManager1.Toolbars.AddRange(new UltraToolbar[1]
    {
      ultraToolbar
    });
    ((AppearanceBase) appearance10).BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    ((AppearanceBase) appearance10).BackColor2 = Color.White;
    ((AppearanceBase) appearance10).BackGradientAlignment = (GradientAlignment) 1;
    ((AppearanceBase) appearance10).BackGradientStyle = (GradientStyle) 14;
    ((SettingsBase) this.ultraToolbarsManager1.ToolbarSettings).Appearance = (AppearanceBase) appearance10;
    ((AppearanceBase) appearance11).Image = componentResourceManager.GetObject("appearance45.Image");
    ((ToolPropsBase) ((ToolBase) buttonTool6).SharedPropsInternal).AppearancesLarge.Appearance = (AppearanceBase) appearance11;
    ((AppearanceBase) appearance12).Image = componentResourceManager.GetObject("appearance46.Image");
    ((ToolPropsBase) ((ToolBase) buttonTool6).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance12;
    ((ToolPropsBase) ((ToolBase) buttonTool6).SharedPropsInternal).Caption = "Process Emails";
    ((ToolPropsBase) ((ToolBase) buttonTool6).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((AppearanceBase) appearance13).Image = componentResourceManager.GetObject("appearance47.Image");
    ((ToolPropsBase) ((ToolBase) buttonTool7).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance13;
    ((ToolPropsBase) ((ToolBase) buttonTool7).SharedPropsInternal).Caption = "Check All";
    ((ToolPropsBase) ((ToolBase) buttonTool7).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((AppearanceBase) appearance14).Image = componentResourceManager.GetObject("appearance48.Image");
    ((ToolPropsBase) ((ToolBase) buttonTool8).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance14;
    ((ToolPropsBase) ((ToolBase) buttonTool8).SharedPropsInternal).Caption = "Un-Check All";
    ((ToolPropsBase) ((ToolBase) buttonTool8).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((AppearanceBase) appearance15).Image = componentResourceManager.GetObject("appearance49.Image");
    ((ToolPropsBase) ((ToolBase) buttonTool9).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance15;
    ((ToolPropsBase) ((ToolBase) buttonTool9).SharedPropsInternal).Caption = "Refresh";
    controlContainerTool2.CanSetWidth = true;
    controlContainerTool2.ControlName = "overdueInvoiceDateRange1";
    ((AppearanceBase) appearance16).TextVAlignAsString = "Bottom";
    ((ToolPropsBase) ((ToolBase) controlContainerTool2).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance16;
    ((ToolPropsBase) ((ToolBase) controlContainerTool2).SharedPropsInternal).Width = 254;
    ((AppearanceBase) appearance17).Image = componentResourceManager.GetObject("appearance51.Image");
    ((ToolPropsBase) ((ToolBase) buttonTool10).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance17;
    ((ToolPropsBase) ((ToolBase) buttonTool10).SharedPropsInternal).Caption = "Save Settings";
    ((ToolsCollectionBase) this.ultraToolbarsManager1.Tools).AddRange(new ToolBase[6]
    {
      (ToolBase) buttonTool6,
      (ToolBase) buttonTool7,
      (ToolBase) buttonTool8,
      (ToolBase) buttonTool9,
      (ToolBase) controlContainerTool2,
      (ToolBase) buttonTool10
    });
    this.ultraToolbarsManager1.ToolClick += new ToolClickEventHandler(this.ultraToolbarsManager1_ToolClick);
    ((Control) this._FormOverdueInvoices_Toolbars_Dock_Area_Right).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._FormOverdueInvoices_Toolbars_Dock_Area_Right).BackColor = Color.White;
    this._FormOverdueInvoices_Toolbars_Dock_Area_Right.DockedPosition = (DockedPosition) 3;
    ((Control) this._FormOverdueInvoices_Toolbars_Dock_Area_Right).ForeColor = Color.Black;
    ((Control) this._FormOverdueInvoices_Toolbars_Dock_Area_Right).Location = new Point(831, 46);
    ((Control) this._FormOverdueInvoices_Toolbars_Dock_Area_Right).Name = "_FormOverdueInvoices_Toolbars_Dock_Area_Right";
    ((Control) this._FormOverdueInvoices_Toolbars_Dock_Area_Right).Size = new Size(0, 773);
    this._FormOverdueInvoices_Toolbars_Dock_Area_Right.ToolbarsManager = this.ultraToolbarsManager1;
    ((Control) this._FormOverdueInvoices_Toolbars_Dock_Area_Top).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._FormOverdueInvoices_Toolbars_Dock_Area_Top).BackColor = Color.White;
    this._FormOverdueInvoices_Toolbars_Dock_Area_Top.DockedPosition = (DockedPosition) 0;
    ((Control) this._FormOverdueInvoices_Toolbars_Dock_Area_Top).ForeColor = Color.Black;
    ((Control) this._FormOverdueInvoices_Toolbars_Dock_Area_Top).Location = new Point(0, 0);
    ((Control) this._FormOverdueInvoices_Toolbars_Dock_Area_Top).Name = "_FormOverdueInvoices_Toolbars_Dock_Area_Top";
    ((Control) this._FormOverdueInvoices_Toolbars_Dock_Area_Top).Size = new Size(831, 46);
    this._FormOverdueInvoices_Toolbars_Dock_Area_Top.ToolbarsManager = this.ultraToolbarsManager1;
    ((Control) this._FormOverdueInvoices_Toolbars_Dock_Area_Bottom).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._FormOverdueInvoices_Toolbars_Dock_Area_Bottom).BackColor = Color.White;
    this._FormOverdueInvoices_Toolbars_Dock_Area_Bottom.DockedPosition = (DockedPosition) 1;
    ((Control) this._FormOverdueInvoices_Toolbars_Dock_Area_Bottom).ForeColor = Color.Black;
    ((Control) this._FormOverdueInvoices_Toolbars_Dock_Area_Bottom).Location = new Point(0, 819);
    ((Control) this._FormOverdueInvoices_Toolbars_Dock_Area_Bottom).Name = "_FormOverdueInvoices_Toolbars_Dock_Area_Bottom";
    ((Control) this._FormOverdueInvoices_Toolbars_Dock_Area_Bottom).Size = new Size(831, 0);
    this._FormOverdueInvoices_Toolbars_Dock_Area_Bottom.ToolbarsManager = this.ultraToolbarsManager1;
    ((UltraGridBase) this.gridOverdueInvoices).DataSource = (object) this.dsOverdueInvoices1;
    ((AppearanceBase) appearance18).BackColor = Color.White;
    ((AppearanceBase) appearance18).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.gridOverdueInvoices).DisplayLayout.Appearance = (AppearanceBase) appearance18;
    ((UltraGridBase) this.gridOverdueInvoices).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn1.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance19).TextHAlignAsString = "Left";
    ultraGridColumn1.CellAppearance = (AppearanceBase) appearance19;
    ((AppearanceBase) appearance20).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn1.Header).Appearance = (AppearanceBase) appearance20;
    ((HeaderBase) ultraGridColumn1.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn1.Header).VisiblePosition = 1;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn1.Width = 341;
    ultraGridColumn2.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance21).TextHAlignAsString = "Left";
    ultraGridColumn2.CellAppearance = (AppearanceBase) appearance21;
    ((AppearanceBase) appearance22).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn2.Header).Appearance = (AppearanceBase) appearance22;
    ((HeaderBase) ultraGridColumn2.Header).Caption = "Remitter";
    ((HeaderBase) ultraGridColumn2.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn2.Header).VisiblePosition = 2;
    ultraGridColumn2.Width = 178;
    ultraGridColumn3.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance23).TextHAlignAsString = "Left";
    ultraGridColumn3.CellAppearance = (AppearanceBase) appearance23;
    ((AppearanceBase) appearance24).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn3.Header).Appearance = (AppearanceBase) appearance24;
    ((HeaderBase) ultraGridColumn3.Header).Caption = "Contact Name";
    ((HeaderBase) ultraGridColumn3.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn3.Header).VisiblePosition = 3;
    ultraGridColumn3.Width = 171;
    ultraGridColumn4.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance25).TextHAlignAsString = "Left";
    ultraGridColumn4.CellAppearance = (AppearanceBase) appearance25;
    ((AppearanceBase) appearance26).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn4.Header).Appearance = (AppearanceBase) appearance26;
    ((HeaderBase) ultraGridColumn4.Header).Caption = "Contact Email";
    ((HeaderBase) ultraGridColumn4.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn4.Header).VisiblePosition = 4;
    ultraGridColumn4.Width = 200;
    ultraGridColumn5.EditorComponent = (Component) this.ultraCheckEditor1;
    ((AppearanceBase) appearance27).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn5.Header).Appearance = (AppearanceBase) appearance27;
    ((HeaderBase) ultraGridColumn5.Header).Caption = "UW Email";
    ((HeaderBase) ultraGridColumn5.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn5.Header).VisiblePosition = 5;
    ultraGridColumn5.Width = 185;
    ((HeaderBase) ultraGridColumn6.Header).Caption = "";
    ((HeaderBase) ultraGridColumn6.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn6.Header).VisiblePosition = 0;
    ultraGridColumn6.Width = 52;
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
    ultraGridBand1.Override.AllowUpdate = (DefaultableBoolean) 1;
    ultraGridBand1.Override.HeaderClickAction = (HeaderClickAction) 2;
    ultraGridColumn8.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance28).TextHAlignAsString = "Left";
    ultraGridColumn8.CellAppearance = (AppearanceBase) appearance28;
    ((AppearanceBase) appearance29).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn8.Header).Appearance = (AppearanceBase) appearance29;
    ((HeaderBase) ultraGridColumn8.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn8.Header).VisiblePosition = 6;
    ultraGridColumn8.Hidden = true;
    ultraGridColumn8.Width = 67;
    ultraGridColumn9.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance30).TextHAlignAsString = "Left";
    ultraGridColumn9.CellAppearance = (AppearanceBase) appearance30;
    ((AppearanceBase) appearance31).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn9.Header).Appearance = (AppearanceBase) appearance31;
    ((HeaderBase) ultraGridColumn9.Header).Caption = "Invoice #";
    ((HeaderBase) ultraGridColumn9.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn9.Header).VisiblePosition = 1;
    ultraGridColumn9.Width = 170;
    ultraGridColumn10.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance32).TextHAlignAsString = "Left";
    ultraGridColumn10.CellAppearance = (AppearanceBase) appearance32;
    ((AppearanceBase) appearance33).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn10.Header).Appearance = (AppearanceBase) appearance33;
    ((HeaderBase) ultraGridColumn10.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn10.Header).VisiblePosition = 7;
    ultraGridColumn10.Hidden = true;
    ultraGridColumn10.Width = 240 /*0xF0*/;
    ultraGridColumn11.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance34).TextHAlignAsString = "Left";
    ultraGridColumn11.CellAppearance = (AppearanceBase) appearance34;
    ((AppearanceBase) appearance35).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn11.Header).Appearance = (AppearanceBase) appearance35;
    ((HeaderBase) ultraGridColumn11.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn11.Header).VisiblePosition = 8;
    ultraGridColumn11.Hidden = true;
    ultraGridColumn11.Width = 150;
    ultraGridColumn12.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance36).TextHAlignAsString = "Left";
    ultraGridColumn12.CellAppearance = (AppearanceBase) appearance36;
    ((AppearanceBase) appearance37).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn12.Header).Appearance = (AppearanceBase) appearance37;
    ((HeaderBase) ultraGridColumn12.Header).Caption = "Policy #";
    ((HeaderBase) ultraGridColumn12.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn12.Header).VisiblePosition = 2;
    ultraGridColumn12.Width = 163;
    ultraGridColumn13.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance38).TextHAlignAsString = "Left";
    ultraGridColumn13.CellAppearance = (AppearanceBase) appearance38;
    ((AppearanceBase) appearance39).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn13.Header).Appearance = (AppearanceBase) appearance39;
    ((HeaderBase) ultraGridColumn13.Header).Caption = "Insured Name";
    ((HeaderBase) ultraGridColumn13.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn13.Header).VisiblePosition = 3;
    ultraGridColumn13.Width = 184;
    ultraGridColumn14.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance40).TextHAlignAsString = "Left";
    ultraGridColumn14.CellAppearance = (AppearanceBase) appearance40;
    ((AppearanceBase) appearance41).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn14.Header).Appearance = (AppearanceBase) appearance41;
    ((HeaderBase) ultraGridColumn14.Header).Caption = "Due Date";
    ((HeaderBase) ultraGridColumn14.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn14.Header).VisiblePosition = 4;
    ultraGridColumn14.Width = 100;
    ultraGridColumn15.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance42).TextHAlignAsString = "Right";
    ultraGridColumn15.CellAppearance = (AppearanceBase) appearance42;
    ultraGridColumn15.Format = "c";
    ((AppearanceBase) appearance43).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn15.Header).Appearance = (AppearanceBase) appearance43;
    ((HeaderBase) ultraGridColumn15.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn15.Header).VisiblePosition = 5;
    ultraGridColumn15.Width = 129;
    ((HeaderBase) ultraGridColumn16.Header).Caption = "";
    ((HeaderBase) ultraGridColumn16.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn16.Header).VisiblePosition = 0;
    ultraGridColumn16.Width = 21;
    ((HeaderBase) ultraGridColumn17.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn17.Header).VisiblePosition = 9;
    ultraGridColumn17.Hidden = true;
    ultraGridColumn17.Width = 88;
    ultraGridBand2.Columns.AddRange(new object[10]
    {
      (object) ultraGridColumn8,
      (object) ultraGridColumn9,
      (object) ultraGridColumn10,
      (object) ultraGridColumn11,
      (object) ultraGridColumn12,
      (object) ultraGridColumn13,
      (object) ultraGridColumn14,
      (object) ultraGridColumn15,
      (object) ultraGridColumn16,
      (object) ultraGridColumn17
    });
    ultraGridBand2.Override.AllowColMoving = (AllowColMoving) 3;
    ultraGridBand2.Override.AllowUpdate = (DefaultableBoolean) 1;
    ultraGridBand2.Override.HeaderClickAction = (HeaderClickAction) 2;
    ((UltraGridBase) this.gridOverdueInvoices).DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    ((UltraGridBase) this.gridOverdueInvoices).DisplayLayout.BandsSerializer.Add((object) ultraGridBand2);
    ((UltraGridBase) this.gridOverdueInvoices).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((AppearanceBase) appearance44).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance44).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance44).ForeColor = Color.Black;
    ((UltraGridBase) this.gridOverdueInvoices).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance44;
    ((UltraGridBase) this.gridOverdueInvoices).DisplayLayout.Override.AllowAddNew = (AllowAddNew) 2;
    ((UltraGridBase) this.gridOverdueInvoices).DisplayLayout.Override.AllowColMoving = (AllowColMoving) 1;
    ((UltraGridBase) this.gridOverdueInvoices).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.gridOverdueInvoices).DisplayLayout.Override.AllowColSwapping = (AllowColSwapping) 1;
    ((UltraGridBase) this.gridOverdueInvoices).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridOverdueInvoices).DisplayLayout.Override.AllowGroupBy = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridOverdueInvoices).DisplayLayout.Override.AllowGroupMoving = (AllowGroupMoving) 1;
    ((UltraGridBase) this.gridOverdueInvoices).DisplayLayout.Override.AllowGroupSwapping = (AllowGroupSwapping) 1;
    ((UltraGridBase) this.gridOverdueInvoices).DisplayLayout.Override.AllowMultiCellOperations = (AllowMultiCellOperation) 0;
    ((UltraGridBase) this.gridOverdueInvoices).DisplayLayout.Override.AllowRowFiltering = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridOverdueInvoices).DisplayLayout.Override.AllowRowLayoutCellSizing = (RowLayoutSizing) 1;
    ((UltraGridBase) this.gridOverdueInvoices).DisplayLayout.Override.AllowRowLayoutCellSpanSizing = (GridBagLayoutAllowSpanSizing) 1;
    ((UltraGridBase) this.gridOverdueInvoices).DisplayLayout.Override.AllowRowLayoutColMoving = (GridBagLayoutAllowMoving) 1;
    ((UltraGridBase) this.gridOverdueInvoices).DisplayLayout.Override.AllowRowLayoutLabelSizing = (RowLayoutSizing) 1;
    ((UltraGridBase) this.gridOverdueInvoices).DisplayLayout.Override.AllowRowLayoutLabelSpanSizing = (GridBagLayoutAllowSpanSizing) 1;
    ((UltraGridBase) this.gridOverdueInvoices).DisplayLayout.Override.AllowRowSummaries = (AllowRowSummaries) 2;
    ((UltraGridBase) this.gridOverdueInvoices).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 1;
    ((AppearanceBase) appearance45).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridOverdueInvoices).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance45;
    ((AppearanceBase) appearance46).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.gridOverdueInvoices).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance46;
    ((UltraGridBase) this.gridOverdueInvoices).DisplayLayout.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance47).BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.gridOverdueInvoices).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance47;
    ((AppearanceBase) appearance48).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridOverdueInvoices).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance48;
    ((UltraGridBase) this.gridOverdueInvoices).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance49).BackColor = Color.Transparent;
    ((AppearanceBase) appearance49).ForeColor = Color.Black;
    ((UltraGridBase) this.gridOverdueInvoices).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance49;
    ((AppearanceBase) appearance50).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance50).BorderColor = Color.Silver;
    scrollBarLook.ButtonAppearance = (AppearanceBase) appearance50;
    ((AppearanceBase) appearance51).BackColor = Color.White;
    scrollBarLook.TrackAppearance = (AppearanceBase) appearance51;
    ((UltraGridBase) this.gridOverdueInvoices).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((Control) this.gridOverdueInvoices).Location = new Point(12, 252);
    ((Control) this.gridOverdueInvoices).Name = "gridOverdueInvoices";
    ((Control) this.gridOverdueInvoices).Size = new Size(807, 341);
    ((Control) this.gridOverdueInvoices).TabIndex = 6;
    ((UltraControlBase) this.gridOverdueInvoices).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.gridOverdueInvoices).UseOsThemes = (DefaultableBoolean) 2;
    this.gridOverdueInvoices.AfterCellUpdate += new CellEventHandler(this.gridOverdueInvoices_AfterCellUpdate);
    this.gridOverdueInvoices.InitializeRow += new InitializeRowEventHandler(this.gridOverdueInvoices_InitializeRow);
    this.gridOverdueInvoices.CellChange += new CellEventHandler(this.gridOverdueInvoices_CellChange);
    this.gridOverdueInvoices.ClickCellButton += new CellEventHandler(this.gridOverdueInvoices_ClickCellButton);
    this.dsOverdueInvoices1.DataSetName = "dsOverdueInvoices";
    this.dsOverdueInvoices1.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.overdueInvoiceDateRange1.BackColor = Color.Transparent;
    this.overdueInvoiceDateRange1.Font = new Font("Tahoma", 8.25f);
    this.overdueInvoiceDateRange1.ForeColor = Color.Black;
    this.overdueInvoiceDateRange1.Location = new Point(384, 125);
    this.overdueInvoiceDateRange1.MaximumSize = new Size((int) byte.MaxValue, 26);
    this.overdueInvoiceDateRange1.MinimumSize = new Size((int) byte.MaxValue, 26);
    this.overdueInvoiceDateRange1.Name = "overdueInvoiceDateRange1";
    this.overdueInvoiceDateRange1.Size = new Size((int) byte.MaxValue, 26);
    this.overdueInvoiceDateRange1.TabIndex = 13;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    this.ClientSize = new Size(831, 819);
    this.Controls.Add((Control) this.ultraCheckEditor1);
    this.Controls.Add((Control) this.overdueInvoiceDateRange1);
    this.Controls.Add((Control) this.textEmailSubject);
    this.Controls.Add((Control) this.ultraLabel5);
    this.Controls.Add((Control) this.textEmailFooter);
    this.Controls.Add((Control) this.ultraLabel4);
    this.Controls.Add((Control) this.textEmailHeader);
    this.Controls.Add((Control) this.ultraLabel2);
    this.Controls.Add((Control) this.ultraLabel1);
    this.Controls.Add((Control) this.gridOverdueInvoices);
    this.Controls.Add((Control) this.ultraLabel3);
    this.Controls.Add((Control) this._FormOverdueInvoices_Toolbars_Dock_Area_Left);
    this.Controls.Add((Control) this._FormOverdueInvoices_Toolbars_Dock_Area_Right);
    this.Controls.Add((Control) this._FormOverdueInvoices_Toolbars_Dock_Area_Bottom);
    this.Controls.Add((Control) this._FormOverdueInvoices_Toolbars_Dock_Area_Top);
    this.Font = new Font("Tahoma", 8.25f);
    this.ForeColor = Color.Black;
    this.Name = nameof (FormOverdueInvoices);
    this.Text = "Overdue Invoice Utility";
    this.Load += new EventHandler(this.FormOverdueInvoices_Load);
    ((ISupportInitialize) this.ultraCheckEditor1).EndInit();
    ((ISupportInitialize) this.textEmailHeader).EndInit();
    ((ISupportInitialize) this.textEmailFooter).EndInit();
    ((ISupportInitialize) this.textEmailSubject).EndInit();
    ((ISupportInitialize) this.ultraToolbarsManager1).EndInit();
    ((ISupportInitialize) this.gridOverdueInvoices).EndInit();
    this.dsOverdueInvoices1.EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }
}
