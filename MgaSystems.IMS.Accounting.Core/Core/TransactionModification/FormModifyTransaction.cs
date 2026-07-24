// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Core.TransactionModification.FormModifyTransaction
// Assembly: MgaSystems.IMS.Accounting.Core, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 923053EF-B70A-44B5-B8DA-B227263F4FD2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Core.dll

using Infragistics.Shared;
using Infragistics.Win;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using Infragistics.Win.UltraWinToolbars;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.IMS.Forms;
using MGASystems.Tools;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Core.TransactionModification;

[TestForm]
public class FormModifyTransaction : FormBase
{
  private int _transactionNumber;
  private IContainer components;
  private UltraToolbarsManager ultraToolbarsManager1;
  private UltraToolbarsDockArea _FormModifyTransaction_Toolbars_Dock_Area_Left;
  private UltraToolbarsDockArea _FormModifyTransaction_Toolbars_Dock_Area_Right;
  private UltraToolbarsDockArea _FormModifyTransaction_Toolbars_Dock_Area_Top;
  private UltraToolbarsDockArea _FormModifyTransaction_Toolbars_Dock_Area_Bottom;
  private dsModifyTransaction dsModifyTransaction1;
  private Panel pnlMain;
  private UltraGrid gridTransctionInvoices;
  private MGATextBox textTransactionNumber;
  private MGATextBox textInvoiceNumber;

  public FormModifyTransaction() => this.InitializeComponent();

  public FormModifyTransaction(int transctionNumber)
  {
    this.InitializeComponent();
    this._transactionNumber = transctionNumber;
    ((Control) this.textTransactionNumber).Text = transctionNumber.ToString();
    this.LoadTransaction(this._transactionNumber);
  }

  private void LoadTransaction(int transactionNumber)
  {
    DefaultDatabase.LoadDataSet((DataSet) this.dsModifyTransaction1, new string[1]
    {
      "TransactionInvoices"
    }, "spFin_ModifyTransaction_Invoices", new object[2]
    {
      (object) "@transactNum",
      (object) transactionNumber
    });
    DefaultDatabase.LoadDataSet((DataSet) this.dsModifyTransaction1, new string[1]
    {
      "TransactionHeader"
    }, "spFin_ModifyTransaction_Header", new object[2]
    {
      (object) "@transactNum",
      (object) transactionNumber
    });
  }

  private void ultraToolbarsManager1_ToolClick(object sender, ToolClickEventArgs e)
  {
    switch (((KeyedSubObjectBase) ((ToolEventArgs) e).Tool).Key)
    {
      case "SEARCH":
        if (!int.TryParse(((Control) this.textTransactionNumber).Text, out this._transactionNumber))
        {
          int num = (int) MessageBox.Show("Transaction number must be numeric!", "Invalid Entry!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          break;
        }
        this.LoadTransaction(this._transactionNumber);
        break;
      case "INVOICE":
        if (string.IsNullOrEmpty(((Control) this.textInvoiceNumber).Text))
        {
          int num = (int) MessageBox.Show("You must specify an invoice number to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          break;
        }
        if (((UltraGridBase) this.gridTransctionInvoices).ActiveRow == null)
        {
          int num = (int) MessageBox.Show("You must select an invoice to replace.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          break;
        }
        this.LoadModifyInvoice(int.Parse(((UltraGridBase) this.gridTransctionInvoices).ActiveRow.Cells["InvoiceNum"].Value.ToString()), this.dsModifyTransaction1.TransactionHeader[0].GLCompanyId, int.Parse(((Control) this.textInvoiceNumber).Text), this._transactionNumber);
        break;
      case "CANCEL":
        this.DialogResult = DialogResult.Cancel;
        break;
    }
  }

  private void LoadModifyInvoice(
    int invoiceNumber,
    int glCompanyid,
    int replacementInvoiceNumber,
    int transactionNumber)
  {
    dsModifyInvoice ds = new dsModifyInvoice();
    DefaultDatabase.LoadDataSet((DataSet) ds, new string[2]
    {
      "InvoiceToEdit",
      "ReplacementInvoice"
    }, "spFin_ModifyTransaction_ModifyInvoice", new object[8]
    {
      (object) "@TransactionNumber",
      (object) transactionNumber,
      (object) "@InvoiceToEdit",
      (object) invoiceNumber,
      (object) "@ReplacementInvoice",
      (object) replacementInvoiceNumber,
      (object) "@GLCompanyId",
      (object) glCompanyid
    });
    using (FormModifyInvoice formModifyInvoice = new FormModifyInvoice(ds))
    {
      if (formModifyInvoice.ShowDialog() != DialogResult.OK)
        return;
      this.Close();
    }
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
    UltraToolbar ultraToolbar = new UltraToolbar("UltraToolbar1");
    ButtonTool buttonTool1 = new ButtonTool("SEARCH");
    ControlContainerTool controlContainerTool1 = new ControlContainerTool("trxNum");
    ButtonTool buttonTool2 = new ButtonTool("INVOICE");
    ControlContainerTool controlContainerTool2 = new ControlContainerTool("ControlContainerTool1");
    ButtonTool buttonTool3 = new ButtonTool("CANCEL");
    ButtonTool buttonTool4 = new ButtonTool("SEARCH");
    Appearance appearance1 = new Appearance();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (FormModifyTransaction));
    ButtonTool buttonTool5 = new ButtonTool("INVOICE");
    Appearance appearance2 = new Appearance();
    ButtonTool buttonTool6 = new ButtonTool("CANCEL");
    Appearance appearance3 = new Appearance();
    ControlContainerTool controlContainerTool3 = new ControlContainerTool("trxNum");
    ControlContainerTool controlContainerTool4 = new ControlContainerTool("ControlContainerTool1");
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    UltraGridBand ultraGridBand = new UltraGridBand("TransactionInvoices", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("InvoiceNum");
    Appearance appearance7 = new Appearance();
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("Policy Number");
    Appearance appearance8 = new Appearance();
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("Invoice Number");
    Appearance appearance9 = new Appearance();
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("Company");
    Appearance appearance10 = new Appearance();
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("Producer");
    Appearance appearance11 = new Appearance();
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("Insured");
    Appearance appearance12 = new Appearance();
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("Amount");
    Appearance appearance13 = new Appearance();
    Appearance appearance14 = new Appearance();
    Appearance appearance15 = new Appearance();
    Appearance appearance16 = new Appearance();
    Appearance appearance17 = new Appearance();
    Appearance appearance18 = new Appearance();
    Appearance appearance19 = new Appearance();
    Appearance appearance20 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    Appearance appearance21 = new Appearance();
    Appearance appearance22 = new Appearance();
    this._FormModifyTransaction_Toolbars_Dock_Area_Left = new UltraToolbarsDockArea();
    this.ultraToolbarsManager1 = new UltraToolbarsManager(this.components);
    this._FormModifyTransaction_Toolbars_Dock_Area_Right = new UltraToolbarsDockArea();
    this._FormModifyTransaction_Toolbars_Dock_Area_Top = new UltraToolbarsDockArea();
    this._FormModifyTransaction_Toolbars_Dock_Area_Bottom = new UltraToolbarsDockArea();
    this.pnlMain = new Panel();
    this.textInvoiceNumber = new MGATextBox();
    this.textTransactionNumber = new MGATextBox();
    this.gridTransctionInvoices = new UltraGrid();
    this.dsModifyTransaction1 = new dsModifyTransaction();
    ((ISupportInitialize) this.ultraToolbarsManager1).BeginInit();
    this.pnlMain.SuspendLayout();
    ((ISupportInitialize) this.textInvoiceNumber).BeginInit();
    ((ISupportInitialize) this.textTransactionNumber).BeginInit();
    ((ISupportInitialize) this.gridTransctionInvoices).BeginInit();
    this.dsModifyTransaction1.BeginInit();
    this.SuspendLayout();
    ((Control) this._FormModifyTransaction_Toolbars_Dock_Area_Left).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._FormModifyTransaction_Toolbars_Dock_Area_Left).BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this._FormModifyTransaction_Toolbars_Dock_Area_Left.DockedPosition = (DockedPosition) 2;
    ((Control) this._FormModifyTransaction_Toolbars_Dock_Area_Left).ForeColor = SystemColors.ControlText;
    ((Control) this._FormModifyTransaction_Toolbars_Dock_Area_Left).Location = new Point(0, 26);
    ((Control) this._FormModifyTransaction_Toolbars_Dock_Area_Left).Name = "_FormModifyTransaction_Toolbars_Dock_Area_Left";
    ((Control) this._FormModifyTransaction_Toolbars_Dock_Area_Left).Size = new Size(0, 486);
    this._FormModifyTransaction_Toolbars_Dock_Area_Left.ToolbarsManager = this.ultraToolbarsManager1;
    this.ultraToolbarsManager1.DesignerFlags = 1;
    this.ultraToolbarsManager1.DockWithinContainer = (Control) this;
    this.ultraToolbarsManager1.DockWithinContainerBaseType = typeof (FormBase);
    this.ultraToolbarsManager1.MdiMergeable = false;
    this.ultraToolbarsManager1.ShowFullMenusDelay = 500;
    this.ultraToolbarsManager1.Style = (ToolbarStyle) 5;
    ultraToolbar.DockedColumn = 0;
    ultraToolbar.DockedRow = 0;
    ultraToolbar.IsMainMenuBar = true;
    controlContainerTool1.ControlName = "textTransactionNumber";
    ((ToolPropsBase) ((ToolBase) controlContainerTool1).InstanceProps).Width = 90;
    ((ToolBase) buttonTool2).InstanceProps.IsFirstInGroup = true;
    controlContainerTool2.ControlName = "textInvoiceNumber";
    ((ToolPropsBase) ((ToolBase) controlContainerTool2).InstanceProps).Width = 90;
    ((ToolBase) buttonTool3).InstanceProps.IsFirstInGroup = true;
    ((UltraToolbarBase) ultraToolbar).NonInheritedTools.AddRange(new ToolBase[5]
    {
      (ToolBase) buttonTool1,
      (ToolBase) controlContainerTool1,
      (ToolBase) buttonTool2,
      (ToolBase) controlContainerTool2,
      (ToolBase) buttonTool3
    });
    ultraToolbar.Settings.AllowCustomize = (DefaultableBoolean) 2;
    ultraToolbar.Settings.AllowDockBottom = (DefaultableBoolean) 2;
    ultraToolbar.Settings.AllowDockLeft = (DefaultableBoolean) 2;
    ultraToolbar.Settings.AllowDockRight = (DefaultableBoolean) 2;
    ultraToolbar.Settings.AllowDockTop = (DefaultableBoolean) 2;
    ultraToolbar.Settings.AllowFloating = (DefaultableBoolean) 2;
    ultraToolbar.Settings.AllowHiding = (DefaultableBoolean) 2;
    ultraToolbar.Settings.FillEntireRow = (DefaultableBoolean) 1;
    ultraToolbar.Settings.GrabHandleStyle = (GrabHandleStyle) 1;
    ultraToolbar.Text = "UltraToolbar1";
    this.ultraToolbarsManager1.Toolbars.AddRange(new UltraToolbar[1]
    {
      ultraToolbar
    });
    ((AppearanceBase) appearance1).Image = componentResourceManager.GetObject("appearance11.Image");
    ((ToolPropsBase) ((ToolBase) buttonTool4).SharedProps).AppearancesSmall.Appearance = (AppearanceBase) appearance1;
    ((ToolPropsBase) ((ToolBase) buttonTool4).SharedProps).Caption = "Search Transaction";
    ((ToolPropsBase) ((ToolBase) buttonTool4).SharedProps).DisplayStyle = (ToolDisplayStyle) 4;
    ((AppearanceBase) appearance2).Image = componentResourceManager.GetObject("appearance12.Image");
    ((ToolPropsBase) ((ToolBase) buttonTool5).SharedProps).AppearancesSmall.Appearance = (AppearanceBase) appearance2;
    ((ToolPropsBase) ((ToolBase) buttonTool5).SharedProps).Caption = "Find Invoice";
    ((ToolPropsBase) ((ToolBase) buttonTool5).SharedProps).DisplayStyle = (ToolDisplayStyle) 4;
    ((AppearanceBase) appearance3).Image = componentResourceManager.GetObject("appearance13.Image");
    ((ToolPropsBase) ((ToolBase) buttonTool6).SharedProps).AppearancesSmall.Appearance = (AppearanceBase) appearance3;
    ((ToolPropsBase) ((ToolBase) buttonTool6).SharedProps).Caption = "Cancel";
    ((ToolPropsBase) ((ToolBase) buttonTool6).SharedProps).DisplayStyle = (ToolDisplayStyle) 4;
    controlContainerTool3.ControlName = "textTransactionNumber";
    ((ToolPropsBase) ((ToolBase) controlContainerTool3).SharedProps).Caption = "trxNum";
    ((ToolPropsBase) ((ToolBase) controlContainerTool3).SharedProps).Width = 90;
    controlContainerTool4.ControlName = "textInvoiceNumber";
    ((ToolPropsBase) ((ToolBase) controlContainerTool4).SharedProps).Caption = "ControlContainerTool1";
    ((ToolPropsBase) ((ToolBase) controlContainerTool4).SharedProps).Width = 90;
    ((ToolsCollectionBase) this.ultraToolbarsManager1.Tools).AddRange(new ToolBase[5]
    {
      (ToolBase) buttonTool4,
      (ToolBase) buttonTool5,
      (ToolBase) buttonTool6,
      (ToolBase) controlContainerTool3,
      (ToolBase) controlContainerTool4
    });
    this.ultraToolbarsManager1.ToolClick += new ToolClickEventHandler(this.ultraToolbarsManager1_ToolClick);
    ((Control) this._FormModifyTransaction_Toolbars_Dock_Area_Right).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._FormModifyTransaction_Toolbars_Dock_Area_Right).BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this._FormModifyTransaction_Toolbars_Dock_Area_Right.DockedPosition = (DockedPosition) 3;
    ((Control) this._FormModifyTransaction_Toolbars_Dock_Area_Right).ForeColor = SystemColors.ControlText;
    ((Control) this._FormModifyTransaction_Toolbars_Dock_Area_Right).Location = new Point(982, 26);
    ((Control) this._FormModifyTransaction_Toolbars_Dock_Area_Right).Name = "_FormModifyTransaction_Toolbars_Dock_Area_Right";
    ((Control) this._FormModifyTransaction_Toolbars_Dock_Area_Right).Size = new Size(0, 486);
    this._FormModifyTransaction_Toolbars_Dock_Area_Right.ToolbarsManager = this.ultraToolbarsManager1;
    ((Control) this._FormModifyTransaction_Toolbars_Dock_Area_Top).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._FormModifyTransaction_Toolbars_Dock_Area_Top).BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this._FormModifyTransaction_Toolbars_Dock_Area_Top.DockedPosition = (DockedPosition) 0;
    ((Control) this._FormModifyTransaction_Toolbars_Dock_Area_Top).ForeColor = SystemColors.ControlText;
    ((Control) this._FormModifyTransaction_Toolbars_Dock_Area_Top).Location = new Point(0, 0);
    ((Control) this._FormModifyTransaction_Toolbars_Dock_Area_Top).Name = "_FormModifyTransaction_Toolbars_Dock_Area_Top";
    ((Control) this._FormModifyTransaction_Toolbars_Dock_Area_Top).Size = new Size(982, 26);
    this._FormModifyTransaction_Toolbars_Dock_Area_Top.ToolbarsManager = this.ultraToolbarsManager1;
    ((Control) this._FormModifyTransaction_Toolbars_Dock_Area_Bottom).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._FormModifyTransaction_Toolbars_Dock_Area_Bottom).BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this._FormModifyTransaction_Toolbars_Dock_Area_Bottom.DockedPosition = (DockedPosition) 1;
    ((Control) this._FormModifyTransaction_Toolbars_Dock_Area_Bottom).ForeColor = SystemColors.ControlText;
    ((Control) this._FormModifyTransaction_Toolbars_Dock_Area_Bottom).Location = new Point(0, 512 /*0x0200*/);
    ((Control) this._FormModifyTransaction_Toolbars_Dock_Area_Bottom).Name = "_FormModifyTransaction_Toolbars_Dock_Area_Bottom";
    ((Control) this._FormModifyTransaction_Toolbars_Dock_Area_Bottom).Size = new Size(982, 0);
    this._FormModifyTransaction_Toolbars_Dock_Area_Bottom.ToolbarsManager = this.ultraToolbarsManager1;
    this.pnlMain.BackColor = Color.Transparent;
    this.pnlMain.Controls.Add((Control) this.textInvoiceNumber);
    this.pnlMain.Controls.Add((Control) this.textTransactionNumber);
    this.pnlMain.Controls.Add((Control) this.gridTransctionInvoices);
    this.pnlMain.Dock = DockStyle.Fill;
    this.pnlMain.Location = new Point(0, 26);
    this.pnlMain.Name = "pnlMain";
    this.pnlMain.Size = new Size(982, 486);
    this.pnlMain.TabIndex = 4;
    ((AppearanceBase) appearance4).BackColor = Color.White;
    ((AppearanceBase) appearance4).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance4).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textInvoiceNumber).Appearance = (AppearanceBase) appearance4;
    ((Control) this.textInvoiceNumber).BackColor = Color.White;
    ((Control) this.textInvoiceNumber).Location = new Point(233, 225);
    this.textInvoiceNumber.MGAStyle = MGAStyles.Blue;
    ((Control) this.textInvoiceNumber).Name = "textInvoiceNumber";
    ((Control) this.textInvoiceNumber).Size = new Size(90, 20);
    ((Control) this.textInvoiceNumber).TabIndex = 9;
    ((UltraControlBase) this.textInvoiceNumber).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textInvoiceNumber).UseOsThemes = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance5).BackColor = Color.White;
    ((AppearanceBase) appearance5).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance5).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textTransactionNumber).Appearance = (AppearanceBase) appearance5;
    ((Control) this.textTransactionNumber).BackColor = Color.White;
    ((Control) this.textTransactionNumber).Location = new Point(233, 199);
    this.textTransactionNumber.MGAStyle = MGAStyles.Blue;
    ((Control) this.textTransactionNumber).Name = "textTransactionNumber";
    ((Control) this.textTransactionNumber).Size = new Size(90, 20);
    ((Control) this.textTransactionNumber).TabIndex = 8;
    ((UltraControlBase) this.textTransactionNumber).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textTransactionNumber).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridTransctionInvoices).DataSource = (object) this.dsModifyTransaction1;
    ((AppearanceBase) appearance6).BackColor = Color.White;
    ((AppearanceBase) appearance6).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.gridTransctionInvoices).DisplayLayout.Appearance = (AppearanceBase) appearance6;
    ((UltraGridBase) this.gridTransctionInvoices).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn1.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance7).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn1.Header).Appearance = (AppearanceBase) appearance7;
    ((HeaderBase) ultraGridColumn1.Header).VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn1.Width = 86;
    ultraGridColumn2.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance8).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn2.Header).Appearance = (AppearanceBase) appearance8;
    ((HeaderBase) ultraGridColumn2.Header).VisiblePosition = 1;
    ultraGridColumn2.Width = 177;
    ultraGridColumn3.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance9).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn3.Header).Appearance = (AppearanceBase) appearance9;
    ((HeaderBase) ultraGridColumn3.Header).VisiblePosition = 2;
    ultraGridColumn3.Width = 162;
    ultraGridColumn4.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance10).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn4.Header).Appearance = (AppearanceBase) appearance10;
    ((HeaderBase) ultraGridColumn4.Header).VisiblePosition = 3;
    ultraGridColumn4.Width = 172;
    ultraGridColumn5.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance11).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn5.Header).Appearance = (AppearanceBase) appearance11;
    ((HeaderBase) ultraGridColumn5.Header).VisiblePosition = 4;
    ultraGridColumn5.Width = 168;
    ultraGridColumn6.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance12).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn6.Header).Appearance = (AppearanceBase) appearance12;
    ((HeaderBase) ultraGridColumn6.Header).VisiblePosition = 5;
    ultraGridColumn6.Width = 167;
    ultraGridColumn7.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance13).TextHAlignAsString = "Right";
    ultraGridColumn7.CellAppearance = (AppearanceBase) appearance13;
    ultraGridColumn7.Format = "c";
    ((AppearanceBase) appearance14).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn7.Header).Appearance = (AppearanceBase) appearance14;
    ((HeaderBase) ultraGridColumn7.Header).VisiblePosition = 6;
    ultraGridColumn7.Width = 134;
    ultraGridBand.Columns.AddRange(new object[7]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3,
      (object) ultraGridColumn4,
      (object) ultraGridColumn5,
      (object) ultraGridColumn6,
      (object) ultraGridColumn7
    });
    ((UltraGridBase) this.gridTransctionInvoices).DisplayLayout.BandsSerializer.Add((object) ultraGridBand);
    ((UltraGridBase) this.gridTransctionInvoices).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((AppearanceBase) appearance15).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance15).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance15).ForeColor = Color.Black;
    ((UltraGridBase) this.gridTransctionInvoices).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance15;
    ((UltraGridBase) this.gridTransctionInvoices).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.gridTransctionInvoices).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridTransctionInvoices).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance16).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridTransctionInvoices).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance16;
    ((UltraGridBase) this.gridTransctionInvoices).DisplayLayout.Override.CellClickAction = (CellClickAction) 2;
    ((AppearanceBase) appearance17).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.gridTransctionInvoices).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance17;
    ((UltraGridBase) this.gridTransctionInvoices).DisplayLayout.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance18).BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.gridTransctionInvoices).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance18;
    ((AppearanceBase) appearance19).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridTransctionInvoices).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance19;
    ((UltraGridBase) this.gridTransctionInvoices).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance20).BackColor = Color.Transparent;
    ((AppearanceBase) appearance20).ForeColor = Color.Black;
    ((UltraGridBase) this.gridTransctionInvoices).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance20;
    ((AppearanceBase) appearance21).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance21).BorderColor = Color.Silver;
    scrollBarLook.ButtonAppearance = (AppearanceBase) appearance21;
    ((AppearanceBase) appearance22).BackColor = Color.White;
    scrollBarLook.TrackAppearance = (AppearanceBase) appearance22;
    ((UltraGridBase) this.gridTransctionInvoices).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((Control) this.gridTransctionInvoices).Dock = DockStyle.Fill;
    ((Control) this.gridTransctionInvoices).Location = new Point(0, 0);
    ((Control) this.gridTransctionInvoices).Name = "gridTransctionInvoices";
    ((Control) this.gridTransctionInvoices).Size = new Size(982, 486);
    ((Control) this.gridTransctionInvoices).TabIndex = 7;
    ((UltraControlBase) this.gridTransctionInvoices).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.gridTransctionInvoices).UseOsThemes = (DefaultableBoolean) 2;
    this.dsModifyTransaction1.DataSetName = "dsModifyTransaction";
    this.dsModifyTransaction1.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(982, 512 /*0x0200*/);
    this.Controls.Add((Control) this.pnlMain);
    this.Controls.Add((Control) this._FormModifyTransaction_Toolbars_Dock_Area_Left);
    this.Controls.Add((Control) this._FormModifyTransaction_Toolbars_Dock_Area_Right);
    this.Controls.Add((Control) this._FormModifyTransaction_Toolbars_Dock_Area_Top);
    this.Controls.Add((Control) this._FormModifyTransaction_Toolbars_Dock_Area_Bottom);
    this.Font = new Font("Tahoma", 8.25f);
    this.Name = nameof (FormModifyTransaction);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Modify Transaction Utility";
    ((ISupportInitialize) this.ultraToolbarsManager1).EndInit();
    this.pnlMain.ResumeLayout(false);
    this.pnlMain.PerformLayout();
    ((ISupportInitialize) this.textInvoiceNumber).EndInit();
    ((ISupportInitialize) this.textTransactionNumber).EndInit();
    ((ISupportInitialize) this.gridTransctionInvoices).EndInit();
    this.dsModifyTransaction1.EndInit();
    this.ResumeLayout(false);
  }
}
