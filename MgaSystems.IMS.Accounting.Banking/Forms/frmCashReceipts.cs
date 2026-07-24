// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Banking.Forms.frmCashReceipts
// Assembly: MgaSystems.IMS.Accounting.Banking, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: ED5B99DC-3DD2-44AB-BA36-49A11A94937D
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Banking.dll

using Infragistics.Win;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinToolbars;
using MGASystems.IMS.Accounting.AccountingDatasets;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Banking.Forms;

public class frmCashReceipts : Form
{
  private IContainer components;

  public frmCashReceipts() => this.InitializeComponent();

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  [field: AccessedThroughProperty("utmRemittanceMenu")]
  internal virtual UltraToolbarsManager utmRemittanceMenu { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("_frmRemittance_Toolbars_Dock_Area_Top")]
  internal virtual UltraToolbarsDockArea _frmRemittance_Toolbars_Dock_Area_Top { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("_frmRemittance_Toolbars_Dock_Area_Bottom")]
  internal virtual UltraToolbarsDockArea _frmRemittance_Toolbars_Dock_Area_Bottom { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("_frmRemittance_Toolbars_Dock_Area_Left")]
  internal virtual UltraToolbarsDockArea _frmRemittance_Toolbars_Dock_Area_Left { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("_frmRemittance_Toolbars_Dock_Area_Right")]
  internal virtual UltraToolbarsDockArea _frmRemittance_Toolbars_Dock_Area_Right { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblManualDBal")]
  internal virtual Label lblManualDBal { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("btnManualDebit")]
  internal virtual Button btnManualDebit { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtMemo")]
  internal virtual TextBox txtMemo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label2")]
  internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblBalance")]
  internal virtual Label lblBalance { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label1")]
  internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("dtpDeposit")]
  internal virtual DateTimePicker dtpDeposit { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("dtpReceived")]
  internal virtual DateTimePicker dtpReceived { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label13")]
  internal virtual Label Label13 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label12")]
  internal virtual Label Label12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtAmount")]
  internal virtual TextBox txtAmount { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label11")]
  internal virtual Label Label11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtCheckNum")]
  internal virtual TextBox txtCheckNum { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label10")]
  internal virtual Label Label10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtRemitter")]
  internal virtual TextBox txtRemitter { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label3")]
  internal virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("GroupBox1")]
  internal virtual GroupBox GroupBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("dsRemittanceData")]
  internal virtual dsRemittanceData dsRemittanceData { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ugWorksheet")]
  internal virtual UltraGrid ugWorksheet { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("GroupBox2")]
  internal virtual GroupBox GroupBox2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    UltraToolbar ultraToolbar = new UltraToolbar("Main");
    ButtonTool buttonTool1 = new ButtonTool("New");
    ButtonTool buttonTool2 = new ButtonTool("View");
    ButtonTool buttonTool3 = new ButtonTool("Post");
    ButtonTool buttonTool4 = new ButtonTool("Void");
    ButtonTool buttonTool5 = new ButtonTool("Clear");
    ButtonTool buttonTool6 = new ButtonTool("Pay");
    ButtonTool buttonTool7 = new ButtonTool("Refund");
    ButtonTool buttonTool8 = new ButtonTool("Find");
    ButtonTool buttonTool9 = new ButtonTool("DirectBillRec");
    ButtonTool buttonTool10 = new ButtonTool("UnAcctCashReceipt");
    ButtonTool buttonTool11 = new ButtonTool("New");
    ButtonTool buttonTool12 = new ButtonTool("View");
    ButtonTool buttonTool13 = new ButtonTool("Post");
    ButtonTool buttonTool14 = new ButtonTool("Void");
    ButtonTool buttonTool15 = new ButtonTool("Clear");
    ButtonTool buttonTool16 = new ButtonTool("Pay");
    ButtonTool buttonTool17 = new ButtonTool("Refund");
    ButtonTool buttonTool18 = new ButtonTool("Find");
    ButtonTool buttonTool19 = new ButtonTool("DirectBillRec");
    ButtonTool buttonTool20 = new ButtonTool("UnAcctCashReceipt");
    Appearance appearance1 = new Appearance();
    UltraGridBand ultraGridBand1 = new UltraGridBand("OutstandingPolicies", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("QuoteControlNum");
    Appearance appearance2 = new Appearance();
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("RemitterGUID");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("RemitterName");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("Address");
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("PolicyNumber", -1, (object) null, 0, (SortIndicator) 2, false);
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("EffectiveDate");
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("ExpirationDate");
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("InsuredName");
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("BalanceDue");
    Appearance appearance11 = new Appearance();
    Appearance appearance12 = new Appearance();
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("OverPaidBal");
    Appearance appearance13 = new Appearance();
    Appearance appearance14 = new Appearance();
    UltraGridColumn ultraGridColumn11 = new UltraGridColumn("OutstandingPoliciesOutstandingPolicyInvoices");
    UltraGridBand ultraGridBand2 = new UltraGridBand("OutstandingPoliciesOutstandingPolicyInvoices", 0);
    UltraGridColumn ultraGridColumn12 = new UltraGridColumn("InvoiceNum");
    Appearance appearance15 = new Appearance();
    Appearance appearance16 = new Appearance();
    UltraGridColumn ultraGridColumn13 = new UltraGridColumn("RemitterGUID");
    UltraGridColumn ultraGridColumn14 = new UltraGridColumn("QuoteControlNum");
    UltraGridColumn ultraGridColumn15 = new UltraGridColumn("OfficeInvoiceNum");
    Appearance appearance17 = new Appearance();
    Appearance appearance18 = new Appearance();
    UltraGridColumn ultraGridColumn16 = new UltraGridColumn("GLOfficeId");
    UltraGridColumn ultraGridColumn17 = new UltraGridColumn("GLOfficeLocation");
    Appearance appearance19 = new Appearance();
    Appearance appearance20 = new Appearance();
    UltraGridColumn ultraGridColumn18 = new UltraGridColumn("InvoiceDate");
    Appearance appearance21 = new Appearance();
    Appearance appearance22 = new Appearance();
    UltraGridColumn ultraGridColumn19 = new UltraGridColumn("DueDate");
    Appearance appearance23 = new Appearance();
    Appearance appearance24 = new Appearance();
    UltraGridColumn ultraGridColumn20 = new UltraGridColumn("GrossPremium");
    UltraGridColumn ultraGridColumn21 = new UltraGridColumn("Fees");
    UltraGridColumn ultraGridColumn22 = new UltraGridColumn("RemitterDeduction");
    Appearance appearance25 = new Appearance();
    Appearance appearance26 = new Appearance();
    UltraGridColumn ultraGridColumn23 = new UltraGridColumn("NetBilled");
    Appearance appearance27 = new Appearance();
    Appearance appearance28 = new Appearance();
    UltraGridColumn ultraGridColumn24 = new UltraGridColumn("AmtPTD");
    Appearance appearance29 = new Appearance();
    UltraGridColumn ultraGridColumn25 = new UltraGridColumn("OverPaidBal");
    UltraGridColumn ultraGridColumn26 = new UltraGridColumn("OutstandingPolicyInvoicesOutstandingInvoiceDetails");
    UltraGridColumn ultraGridColumn27 = new UltraGridColumn("AmtTBP", 0);
    UltraGridColumn ultraGridColumn28 = new UltraGridColumn("NetDue", 1);
    Appearance appearance30 = new Appearance();
    Appearance appearance31 = new Appearance();
    UltraGridColumn ultraGridColumn29 = new UltraGridColumn("TotalTBA", 2);
    Appearance appearance32 = new Appearance();
    Appearance appearance33 = new Appearance();
    UltraGridColumn ultraGridColumn30 = new UltraGridColumn("RemittanceBalance", 3);
    Appearance appearance34 = new Appearance();
    Appearance appearance35 = new Appearance();
    Appearance appearance36 = new Appearance();
    Appearance appearance37 = new Appearance();
    UltraGridBand ultraGridBand3 = new UltraGridBand("OutstandingPolicyInvoicesOutstandingInvoiceDetails", 1);
    UltraGridColumn ultraGridColumn31 = new UltraGridColumn("InvoiceNum");
    UltraGridColumn ultraGridColumn32 = new UltraGridColumn("CompanyLineGUID");
    UltraGridColumn ultraGridColumn33 = new UltraGridColumn("ChargeCode");
    UltraGridColumn ultraGridColumn34 = new UltraGridColumn("ChargeName");
    Appearance appearance38 = new Appearance();
    Appearance appearance39 = new Appearance();
    UltraGridColumn ultraGridColumn35 = new UltraGridColumn("NetBilled");
    Appearance appearance40 = new Appearance();
    Appearance appearance41 = new Appearance();
    UltraGridColumn ultraGridColumn36 = new UltraGridColumn("AmtPTD");
    UltraGridColumn ultraGridColumn37 = new UltraGridColumn("NetDue");
    UltraGridColumn ultraGridColumn38 = new UltraGridColumn("SurplusBal");
    UltraGridColumn ultraGridColumn39 = new UltraGridColumn("ExchangeBal");
    UltraGridColumn ultraGridColumn40 = new UltraGridColumn("AmtPTC", -1, (object) null, 0, (SortIndicator) 2, false);
    UltraGridColumn ultraGridColumn41 = new UltraGridColumn("AmtApplied", 0);
    Appearance appearance42 = new Appearance();
    UltraGridColumn ultraGridColumn42 = new UltraGridColumn("Comments", 1);
    Appearance appearance43 = new Appearance();
    Appearance appearance44 = new Appearance();
    UltraGridColumn ultraGridColumn43 = new UltraGridColumn("Surplus", 2);
    Appearance appearance45 = new Appearance();
    UltraGridColumn ultraGridColumn44 = new UltraGridColumn("Exchange", 3);
    Appearance appearance46 = new Appearance();
    UltraGridColumn ultraGridColumn45 = new UltraGridColumn("RowTotalTBA", 4);
    Appearance appearance47 = new Appearance();
    Appearance appearance48 = new Appearance();
    this.utmRemittanceMenu = new UltraToolbarsManager(this.components);
    this._frmRemittance_Toolbars_Dock_Area_Top = new UltraToolbarsDockArea();
    this._frmRemittance_Toolbars_Dock_Area_Bottom = new UltraToolbarsDockArea();
    this._frmRemittance_Toolbars_Dock_Area_Left = new UltraToolbarsDockArea();
    this._frmRemittance_Toolbars_Dock_Area_Right = new UltraToolbarsDockArea();
    this.lblManualDBal = new Label();
    this.btnManualDebit = new Button();
    this.txtMemo = new TextBox();
    this.Label2 = new Label();
    this.lblBalance = new Label();
    this.Label1 = new Label();
    this.dtpDeposit = new DateTimePicker();
    this.dtpReceived = new DateTimePicker();
    this.Label13 = new Label();
    this.Label12 = new Label();
    this.txtAmount = new TextBox();
    this.Label11 = new Label();
    this.txtCheckNum = new TextBox();
    this.Label10 = new Label();
    this.txtRemitter = new TextBox();
    this.Label3 = new Label();
    this.GroupBox1 = new GroupBox();
    this.dsRemittanceData = new dsRemittanceData();
    this.ugWorksheet = new UltraGrid();
    this.GroupBox2 = new GroupBox();
    ((ISupportInitialize) this.utmRemittanceMenu).BeginInit();
    this.GroupBox1.SuspendLayout();
    this.dsRemittanceData.BeginInit();
    ((ISupportInitialize) this.ugWorksheet).BeginInit();
    this.SuspendLayout();
    this.utmRemittanceMenu.DockWithinContainer = (Control) this;
    this.utmRemittanceMenu.MdiMergeable = false;
    this.utmRemittanceMenu.ShowFullMenusDelay = 500;
    ultraToolbar.DockedColumn = 0;
    ultraToolbar.DockedRow = 0;
    ultraToolbar.Settings.AllowCustomize = (DefaultableBoolean) 2;
    ultraToolbar.Settings.AllowHiding = (DefaultableBoolean) 2;
    ultraToolbar.ShowInToolbarList = false;
    ultraToolbar.Text = "Standard";
    ((ToolBase) buttonTool9).InstanceProps.IsFirstInGroup = true;
    ((ToolsCollectionBase) ((UltraToolbarBase) ultraToolbar).Tools).AddRange(new ToolBase[10]
    {
      (ToolBase) buttonTool1,
      (ToolBase) buttonTool2,
      (ToolBase) buttonTool3,
      (ToolBase) buttonTool4,
      (ToolBase) buttonTool5,
      (ToolBase) buttonTool6,
      (ToolBase) buttonTool7,
      (ToolBase) buttonTool8,
      (ToolBase) buttonTool9,
      (ToolBase) buttonTool10
    });
    this.utmRemittanceMenu.Toolbars.AddRange(new UltraToolbar[1]
    {
      ultraToolbar
    });
    ((ToolPropsBase) ((ToolBase) buttonTool11).SharedProps).Caption = "New Remittance";
    ((ToolPropsBase) ((ToolBase) buttonTool11).SharedProps).DisplayStyle = (ToolDisplayStyle) 4;
    ((ToolBase) buttonTool11).SharedProps.ToolTipText = "New Remittance";
    ((ToolBase) buttonTool11).SharedProps.Visible = false;
    ((ToolPropsBase) ((ToolBase) buttonTool12).SharedProps).Caption = "View Posting";
    ((ToolPropsBase) ((ToolBase) buttonTool12).SharedProps).DisplayStyle = (ToolDisplayStyle) 4;
    ((ToolBase) buttonTool12).SharedProps.ToolTipText = "View Posted Remittance";
    ((ToolBase) buttonTool12).SharedProps.Visible = false;
    ((ToolPropsBase) ((ToolBase) buttonTool13).SharedProps).Caption = "Post";
    ((ToolPropsBase) ((ToolBase) buttonTool13).SharedProps).DisplayStyle = (ToolDisplayStyle) 4;
    ((ToolBase) buttonTool13).SharedProps.ToolTipText = "Post";
    ((ToolPropsBase) ((ToolBase) buttonTool14).SharedProps).Caption = "Void Posting";
    ((ToolPropsBase) ((ToolBase) buttonTool14).SharedProps).DisplayStyle = (ToolDisplayStyle) 4;
    ((ToolBase) buttonTool14).SharedProps.ToolTipText = "Void";
    ((ToolBase) buttonTool14).SharedProps.Visible = false;
    ((ToolPropsBase) ((ToolBase) buttonTool15).SharedProps).Caption = "Clear All";
    ((ToolPropsBase) ((ToolBase) buttonTool15).SharedProps).DisplayStyle = (ToolDisplayStyle) 4;
    ((ToolBase) buttonTool15).SharedProps.ToolTipText = "Clear All";
    ((ToolPropsBase) ((ToolBase) buttonTool16).SharedProps).Caption = "Pay Items";
    ((ToolPropsBase) ((ToolBase) buttonTool16).SharedProps).DisplayStyle = (ToolDisplayStyle) 4;
    ((ToolBase) buttonTool16).SharedProps.ToolTipText = "Pay In Full";
    ((ToolBase) buttonTool16).SharedProps.Visible = false;
    ((ToolPropsBase) ((ToolBase) buttonTool17).SharedProps).Caption = "Refund..";
    ((ToolPropsBase) ((ToolBase) buttonTool17).SharedProps).DisplayStyle = (ToolDisplayStyle) 4;
    ((ToolBase) buttonTool17).SharedProps.ToolTipText = "Refund";
    ((ToolBase) buttonTool17).SharedProps.Visible = false;
    ((ToolPropsBase) ((ToolBase) buttonTool18).SharedProps).Caption = "Find..";
    ((ToolPropsBase) ((ToolBase) buttonTool18).SharedProps).DisplayStyle = (ToolDisplayStyle) 4;
    ((ToolBase) buttonTool18).SharedProps.Visible = false;
    ((ToolPropsBase) ((ToolBase) buttonTool19).SharedProps).Caption = "Direct Bill Reconciliation";
    ((ToolPropsBase) ((ToolBase) buttonTool19).SharedProps).DisplayStyle = (ToolDisplayStyle) 4;
    ((ToolPropsBase) ((ToolBase) buttonTool20).SharedProps).Caption = "Un-Accounted Cash Receipt";
    ((ToolPropsBase) ((ToolBase) buttonTool20).SharedProps).DisplayStyle = (ToolDisplayStyle) 4;
    this.utmRemittanceMenu.Tools.AddRange(new ToolBase[10]
    {
      (ToolBase) buttonTool11,
      (ToolBase) buttonTool12,
      (ToolBase) buttonTool13,
      (ToolBase) buttonTool14,
      (ToolBase) buttonTool15,
      (ToolBase) buttonTool16,
      (ToolBase) buttonTool17,
      (ToolBase) buttonTool18,
      (ToolBase) buttonTool19,
      (ToolBase) buttonTool20
    });
    ((Control) this._frmRemittance_Toolbars_Dock_Area_Top).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._frmRemittance_Toolbars_Dock_Area_Top).BackColor = SystemColors.Control;
    this._frmRemittance_Toolbars_Dock_Area_Top.DockedPosition = (DockedPosition) 0;
    ((Control) this._frmRemittance_Toolbars_Dock_Area_Top).ForeColor = SystemColors.ControlText;
    ((Control) this._frmRemittance_Toolbars_Dock_Area_Top).Location = new Point(0, 0);
    ((Control) this._frmRemittance_Toolbars_Dock_Area_Top).Name = "_frmRemittance_Toolbars_Dock_Area_Top";
    ((Control) this._frmRemittance_Toolbars_Dock_Area_Top).Size = new Size(1002, 24);
    this._frmRemittance_Toolbars_Dock_Area_Top.ToolbarsManager = this.utmRemittanceMenu;
    ((Control) this._frmRemittance_Toolbars_Dock_Area_Bottom).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._frmRemittance_Toolbars_Dock_Area_Bottom).BackColor = SystemColors.Control;
    this._frmRemittance_Toolbars_Dock_Area_Bottom.DockedPosition = (DockedPosition) 1;
    ((Control) this._frmRemittance_Toolbars_Dock_Area_Bottom).ForeColor = SystemColors.ControlText;
    ((Control) this._frmRemittance_Toolbars_Dock_Area_Bottom).Location = new Point(0, 710);
    ((Control) this._frmRemittance_Toolbars_Dock_Area_Bottom).Name = "_frmRemittance_Toolbars_Dock_Area_Bottom";
    ((Control) this._frmRemittance_Toolbars_Dock_Area_Bottom).Size = new Size(1002, 0);
    this._frmRemittance_Toolbars_Dock_Area_Bottom.ToolbarsManager = this.utmRemittanceMenu;
    ((Control) this._frmRemittance_Toolbars_Dock_Area_Left).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._frmRemittance_Toolbars_Dock_Area_Left).BackColor = SystemColors.Control;
    this._frmRemittance_Toolbars_Dock_Area_Left.DockedPosition = (DockedPosition) 2;
    ((Control) this._frmRemittance_Toolbars_Dock_Area_Left).ForeColor = SystemColors.ControlText;
    ((Control) this._frmRemittance_Toolbars_Dock_Area_Left).Location = new Point(0, 46);
    ((Control) this._frmRemittance_Toolbars_Dock_Area_Left).Name = "_frmRemittance_Toolbars_Dock_Area_Left";
    ((Control) this._frmRemittance_Toolbars_Dock_Area_Left).Size = new Size(0, 664);
    this._frmRemittance_Toolbars_Dock_Area_Left.ToolbarsManager = this.utmRemittanceMenu;
    ((Control) this._frmRemittance_Toolbars_Dock_Area_Right).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._frmRemittance_Toolbars_Dock_Area_Right).BackColor = SystemColors.Control;
    this._frmRemittance_Toolbars_Dock_Area_Right.DockedPosition = (DockedPosition) 3;
    ((Control) this._frmRemittance_Toolbars_Dock_Area_Right).ForeColor = SystemColors.ControlText;
    ((Control) this._frmRemittance_Toolbars_Dock_Area_Right).Location = new Point(1002, 46);
    ((Control) this._frmRemittance_Toolbars_Dock_Area_Right).Name = "_frmRemittance_Toolbars_Dock_Area_Right";
    ((Control) this._frmRemittance_Toolbars_Dock_Area_Right).Size = new Size(0, 664);
    this._frmRemittance_Toolbars_Dock_Area_Right.ToolbarsManager = this.utmRemittanceMenu;
    this.lblManualDBal.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.lblManualDBal.Location = new Point(248, 136);
    this.lblManualDBal.Name = "lblManualDBal";
    this.lblManualDBal.Size = new Size(96 /*0x60*/, 20);
    this.lblManualDBal.TabIndex = 49;
    this.lblManualDBal.TextAlign = ContentAlignment.MiddleLeft;
    this.btnManualDebit.Cursor = Cursors.Hand;
    this.btnManualDebit.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.btnManualDebit.ImageIndex = 0;
    this.btnManualDebit.Location = new Point(216, 136);
    this.btnManualDebit.Name = "btnManualDebit";
    this.btnManualDebit.Size = new Size(22, 22);
    this.btnManualDebit.TabIndex = 48 /*0x30*/;
    this.btnManualDebit.Text = "Click here to add a manual credit.";
    this.txtMemo.AcceptsReturn = true;
    this.txtMemo.BorderStyle = BorderStyle.FixedSingle;
    this.txtMemo.Location = new Point(792, 24);
    this.txtMemo.Multiline = true;
    this.txtMemo.Name = "txtMemo";
    this.txtMemo.Size = new Size(208 /*0xD0*/, 64 /*0x40*/);
    this.txtMemo.TabIndex = 43;
    this.txtMemo.Text = "";
    this.Label2.AutoSize = true;
    this.Label2.Location = new Point(712, 24);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(80 /*0x50*/, 16 /*0x10*/);
    this.Label2.TabIndex = 42;
    this.Label2.Text = "Posting Memo:";
    this.Label2.TextAlign = ContentAlignment.MiddleRight;
    this.lblBalance.BorderStyle = BorderStyle.Fixed3D;
    this.lblBalance.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.lblBalance.Location = new Point(96 /*0x60*/, 136);
    this.lblBalance.Name = "lblBalance";
    this.lblBalance.Size = new Size(112 /*0x70*/, 20);
    this.lblBalance.TabIndex = 41;
    this.lblBalance.Text = "$0.00";
    this.lblBalance.TextAlign = ContentAlignment.MiddleRight;
    this.Label1.AutoSize = true;
    this.Label1.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label1.Location = new Point(8, 136);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(48 /*0x30*/, 16 /*0x10*/);
    this.Label1.TabIndex = 40;
    this.Label1.Text = "Balance:";
    this.Label1.TextAlign = ContentAlignment.MiddleRight;
    this.dtpDeposit.CustomFormat = "MM/dd/yyyy";
    this.dtpDeposit.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.dtpDeposit.Format = DateTimePickerFormat.Custom;
    this.dtpDeposit.Location = new Point(96 /*0x60*/, 112 /*0x70*/);
    this.dtpDeposit.Name = "dtpDeposit";
    this.dtpDeposit.Size = new Size(116, 20);
    this.dtpDeposit.TabIndex = 39;
    this.dtpReceived.CustomFormat = "MM/dd/yyyy";
    this.dtpReceived.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.dtpReceived.Format = DateTimePickerFormat.Custom;
    this.dtpReceived.Location = new Point(96 /*0x60*/, 88);
    this.dtpReceived.Name = "dtpReceived";
    this.dtpReceived.Size = new Size(116, 20);
    this.dtpReceived.TabIndex = 37;
    this.Label13.AutoSize = true;
    this.Label13.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label13.Location = new Point(8, 112 /*0x70*/);
    this.Label13.Name = "Label13";
    this.Label13.Size = new Size(73, 16 /*0x10*/);
    this.Label13.TabIndex = 38;
    this.Label13.Text = "Deposit Date:";
    this.Label13.TextAlign = ContentAlignment.MiddleRight;
    this.Label12.AutoSize = true;
    this.Label12.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label12.Location = new Point(8, 88);
    this.Label12.Name = "Label12";
    this.Label12.Size = new Size(82, 16 /*0x10*/);
    this.Label12.TabIndex = 36;
    this.Label12.Text = "Date Received:";
    this.Label12.TextAlign = ContentAlignment.MiddleRight;
    this.txtAmount.BorderStyle = BorderStyle.FixedSingle;
    this.txtAmount.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.txtAmount.Location = new Point(96 /*0x60*/, 40);
    this.txtAmount.Name = "txtAmount";
    this.txtAmount.Size = new Size(96 /*0x60*/, 20);
    this.txtAmount.TabIndex = 33;
    this.txtAmount.Text = "";
    this.txtAmount.TextAlign = HorizontalAlignment.Right;
    this.Label11.AutoSize = true;
    this.Label11.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label11.Location = new Point(8, 40);
    this.Label11.Name = "Label11";
    this.Label11.Size = new Size(46, 16 /*0x10*/);
    this.Label11.TabIndex = 32 /*0x20*/;
    this.Label11.Text = "Amount:";
    this.Label11.TextAlign = ContentAlignment.MiddleRight;
    this.txtCheckNum.BorderStyle = BorderStyle.FixedSingle;
    this.txtCheckNum.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.txtCheckNum.Location = new Point(96 /*0x60*/, 64 /*0x40*/);
    this.txtCheckNum.MaxLength = 8;
    this.txtCheckNum.Name = "txtCheckNum";
    this.txtCheckNum.Size = new Size(96 /*0x60*/, 20);
    this.txtCheckNum.TabIndex = 35;
    this.txtCheckNum.Text = "";
    this.Label10.AutoSize = true;
    this.Label10.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label10.Location = new Point(8, 64 /*0x40*/);
    this.Label10.Name = "Label10";
    this.Label10.Size = new Size(49, 16 /*0x10*/);
    this.Label10.TabIndex = 34;
    this.Label10.Text = "Check #:";
    this.Label10.TextAlign = ContentAlignment.MiddleRight;
    this.txtRemitter.BackColor = Color.White;
    this.txtRemitter.BorderStyle = BorderStyle.FixedSingle;
    this.txtRemitter.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.txtRemitter.Location = new Point(96 /*0x60*/, 16 /*0x10*/);
    this.txtRemitter.Name = "txtRemitter";
    this.txtRemitter.ReadOnly = true;
    this.txtRemitter.Size = new Size(248, 20);
    this.txtRemitter.TabIndex = 31 /*0x1F*/;
    this.txtRemitter.TabStop = false;
    this.txtRemitter.Text = "";
    this.txtRemitter.WordWrap = false;
    this.Label3.AutoSize = true;
    this.Label3.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label3.Location = new Point(8, 16 /*0x10*/);
    this.Label3.Name = "Label3";
    this.Label3.Size = new Size(50, 16 /*0x10*/);
    this.Label3.TabIndex = 30;
    this.Label3.Text = "Remitter:";
    this.Label3.TextAlign = ContentAlignment.MiddleRight;
    this.GroupBox1.Controls.Add((Control) this.txtRemitter);
    this.GroupBox1.Controls.Add((Control) this.Label3);
    this.GroupBox1.Controls.Add((Control) this.Label11);
    this.GroupBox1.Controls.Add((Control) this.txtAmount);
    this.GroupBox1.Controls.Add((Control) this.txtCheckNum);
    this.GroupBox1.Controls.Add((Control) this.dtpReceived);
    this.GroupBox1.Controls.Add((Control) this.dtpDeposit);
    this.GroupBox1.Controls.Add((Control) this.Label10);
    this.GroupBox1.Controls.Add((Control) this.Label12);
    this.GroupBox1.Controls.Add((Control) this.Label13);
    this.GroupBox1.Controls.Add((Control) this.lblBalance);
    this.GroupBox1.Controls.Add((Control) this.Label1);
    this.GroupBox1.Controls.Add((Control) this.btnManualDebit);
    this.GroupBox1.Controls.Add((Control) this.lblManualDBal);
    this.GroupBox1.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.GroupBox1.Location = new Point(8, 24);
    this.GroupBox1.Name = "GroupBox1";
    this.GroupBox1.Size = new Size(352, 168);
    this.GroupBox1.TabIndex = 51;
    this.GroupBox1.TabStop = false;
    this.GroupBox1.Text = "Remitter/Check Information";
    this.dsRemittanceData.DataSetName = "dsRemittanceData";
    this.dsRemittanceData.Locale = new CultureInfo("en-US");
    ((Control) this.ugWorksheet).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraControlBase) this.ugWorksheet).Cursor = Cursors.Default;
    ((UltraGridBase) this.ugWorksheet).DataSource = (object) this.dsRemittanceData.OutstandingPolicies;
    appearance1.BackColor = SystemColors.Window;
    ((UltraGridBase) this.ugWorksheet).DisplayLayout.Appearance = (AppearanceBase) appearance1;
    ((UltraGridBase) this.ugWorksheet).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    appearance2.TextHAlign = (HAlign) 1;
    ((HeaderBase) ultraGridColumn1.Header).Appearance = (AppearanceBase) appearance2;
    ((HeaderBase) ultraGridColumn1.Header).Caption = "Control #";
    ultraGridColumn1.Header.VisiblePosition = 2;
    ultraGridColumn1.Width = 69;
    ultraGridColumn2.Hidden = true;
    ultraGridColumn3.Header.VisiblePosition = 3;
    ultraGridColumn3.Hidden = true;
    ultraGridColumn4.Header.VisiblePosition = 4;
    ultraGridColumn4.Hidden = true;
    appearance3.TextHAlign = (HAlign) 1;
    ultraGridColumn5.CellAppearance = (AppearanceBase) appearance3;
    appearance4.TextHAlign = (HAlign) 1;
    ((HeaderBase) ultraGridColumn5.Header).Appearance = (AppearanceBase) appearance4;
    ((HeaderBase) ultraGridColumn5.Header).Caption = "Policy #";
    ultraGridColumn5.Header.VisiblePosition = 5;
    ultraGridColumn5.Width = 150;
    appearance5.TextHAlign = (HAlign) 1;
    ultraGridColumn6.CellAppearance = (AppearanceBase) appearance5;
    appearance6.TextHAlign = (HAlign) 1;
    ((HeaderBase) ultraGridColumn6.Header).Appearance = (AppearanceBase) appearance6;
    ((HeaderBase) ultraGridColumn6.Header).Caption = "Effective Date";
    ultraGridColumn6.Header.VisiblePosition = 7;
    ultraGridColumn6.Width = 95;
    appearance7.TextHAlign = (HAlign) 1;
    ultraGridColumn7.CellAppearance = (AppearanceBase) appearance7;
    appearance8.TextHAlign = (HAlign) 1;
    ((HeaderBase) ultraGridColumn7.Header).Appearance = (AppearanceBase) appearance8;
    ((HeaderBase) ultraGridColumn7.Header).Caption = "Expiration Date";
    ultraGridColumn7.Header.VisiblePosition = 8;
    ultraGridColumn7.Width = 96 /*0x60*/;
    appearance9.TextHAlign = (HAlign) 1;
    ultraGridColumn8.CellAppearance = (AppearanceBase) appearance9;
    appearance10.TextHAlign = (HAlign) 1;
    ((HeaderBase) ultraGridColumn8.Header).Appearance = (AppearanceBase) appearance10;
    ((HeaderBase) ultraGridColumn8.Header).Caption = "Insured";
    ultraGridColumn8.Header.VisiblePosition = 6;
    ultraGridColumn8.Width = 384;
    appearance11.TextHAlign = (HAlign) 3;
    ultraGridColumn9.CellAppearance = (AppearanceBase) appearance11;
    ultraGridColumn9.Format = "#,##0.00;(#,##0.00)";
    appearance12.TextHAlign = (HAlign) 3;
    ((HeaderBase) ultraGridColumn9.Header).Appearance = (AppearanceBase) appearance12;
    ((HeaderBase) ultraGridColumn9.Header).Caption = "Balance Due";
    ultraGridColumn9.Header.VisiblePosition = 10;
    ultraGridColumn9.Width = 88;
    appearance13.TextHAlign = (HAlign) 3;
    ultraGridColumn10.CellAppearance = (AppearanceBase) appearance13;
    ultraGridColumn10.Format = "#,##0.00;(#,##0.00)";
    appearance14.TextHAlign = (HAlign) 3;
    ((HeaderBase) ultraGridColumn10.Header).Appearance = (AppearanceBase) appearance14;
    ((HeaderBase) ultraGridColumn10.Header).Caption = "Over Paid";
    ultraGridColumn10.Width = 83;
    ultraGridColumn11.Header.VisiblePosition = 0;
    ultraGridBand1.Columns.Add((object) ultraGridColumn1);
    ultraGridBand1.Columns.Add((object) ultraGridColumn2);
    ultraGridBand1.Columns.Add((object) ultraGridColumn3);
    ultraGridBand1.Columns.Add((object) ultraGridColumn4);
    ultraGridBand1.Columns.Add((object) ultraGridColumn5);
    ultraGridBand1.Columns.Add((object) ultraGridColumn6);
    ultraGridBand1.Columns.Add((object) ultraGridColumn7);
    ultraGridBand1.Columns.Add((object) ultraGridColumn8);
    ultraGridBand1.Columns.Add((object) ultraGridColumn9);
    ultraGridBand1.Columns.Add((object) ultraGridColumn10);
    ultraGridBand1.Columns.Add((object) ultraGridColumn11);
    ((HeaderBase) ultraGridBand1.Header).Caption = "Outstanding Policies";
    ultraGridBand1.Override.AllowAddNew = (AllowAddNew) 2;
    ultraGridBand1.Override.AllowDelete = (DefaultableBoolean) 2;
    ultraGridBand1.Override.AllowUpdate = (DefaultableBoolean) 2;
    ultraGridBand1.Override.HeaderClickAction = (HeaderClickAction) 2;
    ultraGridBand1.Override.RowSelectors = (DefaultableBoolean) 2;
    ultraGridColumn12.CellActivation = (Activation) 1;
    appearance15.TextHAlign = (HAlign) 1;
    ultraGridColumn12.CellAppearance = (AppearanceBase) appearance15;
    appearance16.TextHAlign = (HAlign) 1;
    ((HeaderBase) ultraGridColumn12.Header).Appearance = (AppearanceBase) appearance16;
    ((HeaderBase) ultraGridColumn12.Header).Caption = "Global Invoice #";
    ultraGridColumn12.Header.VisiblePosition = 2;
    ultraGridColumn12.Hidden = true;
    ultraGridColumn12.Width = 93;
    ultraGridColumn13.Hidden = true;
    ultraGridColumn14.Header.VisiblePosition = 4;
    ultraGridColumn14.Hidden = true;
    ultraGridColumn15.AutoCompleteMode = (AutoCompleteMode) 1;
    ultraGridColumn15.CellActivation = (Activation) 1;
    appearance17.TextHAlign = (HAlign) 1;
    ultraGridColumn15.CellAppearance = (AppearanceBase) appearance17;
    appearance18.TextHAlign = (HAlign) 1;
    ((HeaderBase) ultraGridColumn15.Header).Appearance = (AppearanceBase) appearance18;
    ((HeaderBase) ultraGridColumn15.Header).Caption = "Invoice #";
    ultraGridColumn15.Width = 72;
    ultraGridColumn16.Header.VisiblePosition = 5;
    ultraGridColumn16.Hidden = true;
    ultraGridColumn17.AutoCompleteMode = (AutoCompleteMode) 1;
    ultraGridColumn17.CellActivation = (Activation) 1;
    appearance19.TextHAlign = (HAlign) 1;
    ultraGridColumn17.CellAppearance = (AppearanceBase) appearance19;
    appearance20.TextHAlign = (HAlign) 1;
    ((HeaderBase) ultraGridColumn17.Header).Appearance = (AppearanceBase) appearance20;
    ((HeaderBase) ultraGridColumn17.Header).Caption = "Office";
    ultraGridColumn17.Header.VisiblePosition = 6;
    ultraGridColumn17.Width = 224 /*0xE0*/;
    ultraGridColumn18.AutoCompleteMode = (AutoCompleteMode) 1;
    ultraGridColumn18.CellActivation = (Activation) 1;
    appearance21.TextHAlign = (HAlign) 1;
    ultraGridColumn18.CellAppearance = (AppearanceBase) appearance21;
    appearance22.TextHAlign = (HAlign) 1;
    ((HeaderBase) ultraGridColumn18.Header).Appearance = (AppearanceBase) appearance22;
    ((HeaderBase) ultraGridColumn18.Header).Caption = "Date Billed";
    ultraGridColumn18.Header.VisiblePosition = 7;
    ultraGridColumn18.Width = 73;
    ultraGridColumn19.CellActivation = (Activation) 1;
    appearance23.TextHAlign = (HAlign) 1;
    ultraGridColumn19.CellAppearance = (AppearanceBase) appearance23;
    appearance24.TextHAlign = (HAlign) 1;
    ((HeaderBase) ultraGridColumn19.Header).Appearance = (AppearanceBase) appearance24;
    ((HeaderBase) ultraGridColumn19.Header).Caption = "Due Date";
    ultraGridColumn19.Header.VisiblePosition = 8;
    ultraGridColumn19.Width = 70;
    ultraGridColumn20.CellActivation = (Activation) 1;
    ultraGridColumn20.Format = "#,##0.00";
    ((HeaderBase) ultraGridColumn20.Header).Caption = "Gross Premium";
    ultraGridColumn20.Header.VisiblePosition = 9;
    ultraGridColumn20.Hidden = true;
    ultraGridColumn20.Width = 109;
    ultraGridColumn21.CellActivation = (Activation) 1;
    ultraGridColumn21.Format = "#,##0.00";
    ultraGridColumn21.Header.VisiblePosition = 10;
    ultraGridColumn21.Hidden = true;
    ultraGridColumn21.Width = 90;
    ultraGridColumn22.AutoCompleteMode = (AutoCompleteMode) 1;
    ultraGridColumn22.CellActivation = (Activation) 1;
    appearance25.TextHAlign = (HAlign) 3;
    ultraGridColumn22.CellAppearance = (AppearanceBase) appearance25;
    ultraGridColumn22.Format = "#,##0.00";
    appearance26.TextHAlign = (HAlign) 3;
    ((HeaderBase) ultraGridColumn22.Header).Appearance = (AppearanceBase) appearance26;
    ((HeaderBase) ultraGridColumn22.Header).Caption = "Deduction";
    ultraGridColumn22.Header.VisiblePosition = 11;
    ultraGridColumn22.Hidden = true;
    ultraGridColumn23.CellActivation = (Activation) 1;
    appearance27.TextHAlign = (HAlign) 3;
    ultraGridColumn23.CellAppearance = (AppearanceBase) appearance27;
    ultraGridColumn23.Format = "#,##0.00;(#,##0.00)";
    appearance28.TextHAlign = (HAlign) 3;
    ((HeaderBase) ultraGridColumn23.Header).Appearance = (AppearanceBase) appearance28;
    ((HeaderBase) ultraGridColumn23.Header).Caption = "Net Billed";
    ultraGridColumn23.Header.VisiblePosition = 12;
    ultraGridColumn23.Width = 78;
    ultraGridColumn24.CellActivation = (Activation) 1;
    appearance29.TextHAlign = (HAlign) 3;
    ultraGridColumn24.CellAppearance = (AppearanceBase) appearance29;
    ultraGridColumn24.Format = "#,##0.00;(#,##0.00)";
    ((HeaderBase) ultraGridColumn24.Header).Caption = "Amt. PTD";
    ultraGridColumn24.Header.VisiblePosition = 13;
    ultraGridColumn24.Width = 78;
    ultraGridColumn25.AutoCompleteMode = (AutoCompleteMode) 1;
    ultraGridColumn25.CellActivation = (Activation) 1;
    ultraGridColumn25.Format = "#,##0.00;(#,##0.00)";
    ((HeaderBase) ultraGridColumn25.Header).Caption = "Over Paid";
    ultraGridColumn25.Header.VisiblePosition = 14;
    ultraGridColumn25.Width = 80 /*0x50*/;
    ultraGridColumn26.Header.VisiblePosition = 0;
    ultraGridColumn27.CellActivation = (Activation) 1;
    ultraGridColumn27.Format = "#,##0.00;(#,##0.00)";
    ((HeaderBase) ultraGridColumn27.Header).Caption = "Amt. TBP";
    ultraGridColumn27.Header.VisiblePosition = 16 /*0x10*/;
    ultraGridColumn27.NullText = "0.00";
    ultraGridColumn27.Width = 91;
    ultraGridColumn28.CellActivation = (Activation) 1;
    appearance30.BackColor = Color.White;
    appearance30.TextHAlign = (HAlign) 3;
    ultraGridColumn28.CellAppearance = (AppearanceBase) appearance30;
    ultraGridColumn28.Format = "#,##0.00;(#,##0.00)";
    appearance31.TextHAlign = (HAlign) 3;
    ((HeaderBase) ultraGridColumn28.Header).Appearance = (AppearanceBase) appearance31;
    ((HeaderBase) ultraGridColumn28.Header).Caption = "Net Due";
    ultraGridColumn28.Header.VisiblePosition = 15;
    ultraGridColumn28.NullText = "0.00";
    ultraGridColumn28.Width = 80 /*0x50*/;
    ultraGridColumn29.CellActivation = (Activation) 1;
    appearance32.TextHAlign = (HAlign) 3;
    ultraGridColumn29.CellAppearance = (AppearanceBase) appearance32;
    ultraGridColumn29.Format = "#,##0.00;(#,##0.00)";
    appearance33.TextHAlign = (HAlign) 3;
    ((HeaderBase) ultraGridColumn29.Header).Appearance = (AppearanceBase) appearance33;
    ((HeaderBase) ultraGridColumn29.Header).Caption = "Total Funds TBA";
    ultraGridColumn29.NullText = "0.00";
    ultraGridColumn29.Width = 100;
    ultraGridColumn30.CellActivation = (Activation) 1;
    appearance34.TextHAlign = (HAlign) 3;
    ultraGridColumn30.CellAppearance = (AppearanceBase) appearance34;
    ultraGridColumn30.Format = "#,##0.00;(#,##0.00)";
    appearance35.TextHAlign = (HAlign) 3;
    ((HeaderBase) ultraGridColumn30.Header).Appearance = (AppearanceBase) appearance35;
    ((HeaderBase) ultraGridColumn30.Header).Caption = "Remittance Balance";
    ultraGridColumn30.Hidden = true;
    ultraGridColumn30.NullText = "0.00";
    ultraGridBand2.Columns.Add((object) ultraGridColumn12);
    ultraGridBand2.Columns.Add((object) ultraGridColumn13);
    ultraGridBand2.Columns.Add((object) ultraGridColumn14);
    ultraGridBand2.Columns.Add((object) ultraGridColumn15);
    ultraGridBand2.Columns.Add((object) ultraGridColumn16);
    ultraGridBand2.Columns.Add((object) ultraGridColumn17);
    ultraGridBand2.Columns.Add((object) ultraGridColumn18);
    ultraGridBand2.Columns.Add((object) ultraGridColumn19);
    ultraGridBand2.Columns.Add((object) ultraGridColumn20);
    ultraGridBand2.Columns.Add((object) ultraGridColumn21);
    ultraGridBand2.Columns.Add((object) ultraGridColumn22);
    ultraGridBand2.Columns.Add((object) ultraGridColumn23);
    ultraGridBand2.Columns.Add((object) ultraGridColumn24);
    ultraGridBand2.Columns.Add((object) ultraGridColumn25);
    ultraGridBand2.Columns.Add((object) ultraGridColumn26);
    ultraGridBand2.Columns.Add((object) ultraGridColumn27);
    ultraGridBand2.Columns.Add((object) ultraGridColumn28);
    ultraGridBand2.Columns.Add((object) ultraGridColumn29);
    ultraGridBand2.Columns.Add((object) ultraGridColumn30);
    ((HeaderBase) ultraGridBand2.Header).Caption = "Outstanding Invoices";
    ultraGridBand2.Override.AllowAddNew = (AllowAddNew) 2;
    ultraGridBand2.Override.AllowDelete = (DefaultableBoolean) 2;
    ultraGridBand2.Override.AllowUpdate = (DefaultableBoolean) 1;
    appearance36.TextHAlign = (HAlign) 3;
    ultraGridBand2.Override.CellAppearance = (AppearanceBase) appearance36;
    appearance37.TextHAlign = (HAlign) 3;
    ultraGridBand2.Override.HeaderAppearance = (AppearanceBase) appearance37;
    ultraGridBand2.Override.HeaderClickAction = (HeaderClickAction) 2;
    ultraGridBand2.Override.RowSelectors = (DefaultableBoolean) 2;
    ultraGridColumn31.Hidden = true;
    ultraGridColumn32.Hidden = true;
    ultraGridColumn33.AutoCompleteMode = (AutoCompleteMode) 1;
    ultraGridColumn33.CellActivation = (Activation) 1;
    ((HeaderBase) ultraGridColumn33.Header).Caption = "Charge Code";
    ultraGridColumn33.Hidden = true;
    ultraGridColumn34.AutoCompleteMode = (AutoCompleteMode) 1;
    ultraGridColumn34.CellActivation = (Activation) 1;
    appearance38.TextHAlign = (HAlign) 1;
    ultraGridColumn34.CellAppearance = (AppearanceBase) appearance38;
    appearance39.TextHAlign = (HAlign) 1;
    ((HeaderBase) ultraGridColumn34.Header).Appearance = (AppearanceBase) appearance39;
    ((HeaderBase) ultraGridColumn34.Header).Caption = "Description";
    ultraGridColumn34.Width = 184;
    ultraGridColumn35.AutoCompleteMode = (AutoCompleteMode) 1;
    ultraGridColumn35.CellActivation = (Activation) 1;
    appearance40.TextHAlign = (HAlign) 3;
    ultraGridColumn35.CellAppearance = (AppearanceBase) appearance40;
    ultraGridColumn35.Format = "#,##0.00;(#,##0.00)";
    appearance41.TextHAlign = (HAlign) 3;
    ((HeaderBase) ultraGridColumn35.Header).Appearance = (AppearanceBase) appearance41;
    ((HeaderBase) ultraGridColumn35.Header).Caption = "Net Billed";
    ultraGridColumn35.Width = 83;
    ultraGridColumn36.AutoCompleteMode = (AutoCompleteMode) 1;
    ultraGridColumn36.CellActivation = (Activation) 1;
    ultraGridColumn36.Format = "#,##0.00;(#,##0.00)";
    ((HeaderBase) ultraGridColumn36.Header).Caption = "Amt. PTD";
    ultraGridColumn36.Width = 84;
    ultraGridColumn37.AutoCompleteMode = (AutoCompleteMode) 1;
    ultraGridColumn37.CellActivation = (Activation) 1;
    ultraGridColumn37.Format = "#,##0.00;(#,##0.00)";
    ((HeaderBase) ultraGridColumn37.Header).Caption = "Net. Due";
    ultraGridColumn37.Header.VisiblePosition = 7;
    ultraGridColumn37.Width = 77;
    ultraGridColumn38.AutoCompleteMode = (AutoCompleteMode) 1;
    ultraGridColumn38.CellActivation = (Activation) 1;
    ultraGridColumn38.Format = "#,##0.00;(#,##0.00)";
    ((HeaderBase) ultraGridColumn38.Header).Caption = "Unacct. Bal.";
    ultraGridColumn38.Header.VisiblePosition = 9;
    ultraGridColumn38.Width = 78;
    ultraGridColumn39.AutoCompleteMode = (AutoCompleteMode) 1;
    ultraGridColumn39.CellActivation = (Activation) 1;
    ultraGridColumn39.Format = "#,##0.00;(#,##0.00)";
    ((HeaderBase) ultraGridColumn39.Header).Caption = "Exch. Bal.";
    ultraGridColumn39.Header.VisiblePosition = 11;
    ultraGridColumn39.Width = 72;
    ultraGridColumn40.CellActivation = (Activation) 3;
    ultraGridColumn40.Format = "#,##0.00;(#,##0.00)";
    ((HeaderBase) ultraGridColumn40.Header).Caption = "Amt. PTC";
    ultraGridColumn40.Header.VisiblePosition = 6;
    ultraGridColumn40.Width = 84;
    ultraGridColumn41.AutoCompleteMode = (AutoCompleteMode) 1;
    appearance42.BackColor = Color.LightSteelBlue;
    appearance42.TextHAlign = (HAlign) 3;
    ultraGridColumn41.CellAppearance = (AppearanceBase) appearance42;
    ultraGridColumn41.Format = "#,##0.00;(#,##0.00)";
    ((HeaderBase) ultraGridColumn41.Header).Caption = "Amt. Applied";
    ultraGridColumn41.Header.VisiblePosition = 8;
    ultraGridColumn41.Nullable = (Nullable) 1;
    ultraGridColumn41.Width = 77;
    ultraGridColumn42.AutoCompleteMode = (AutoCompleteMode) 1;
    appearance43.BackColor = SystemColors.Info;
    appearance43.TextHAlign = (HAlign) 1;
    ultraGridColumn42.CellAppearance = (AppearanceBase) appearance43;
    ultraGridColumn42.CellMultiLine = (DefaultableBoolean) 1;
    appearance44.TextHAlign = (HAlign) 1;
    ((HeaderBase) ultraGridColumn42.Header).Appearance = (AppearanceBase) appearance44;
    ultraGridColumn42.Header.VisiblePosition = 14;
    ultraGridColumn42.Hidden = true;
    ultraGridColumn42.Width = 184;
    ultraGridColumn43.AutoCompleteMode = (AutoCompleteMode) 1;
    appearance45.BackColor = Color.LightSteelBlue;
    appearance45.TextHAlign = (HAlign) 3;
    ultraGridColumn43.CellAppearance = (AppearanceBase) appearance45;
    ultraGridColumn43.Format = "#,##0.00;(#,##0.00)";
    ((HeaderBase) ultraGridColumn43.Header).Caption = "Unacct. Applied";
    ultraGridColumn43.Header.VisiblePosition = 10;
    ultraGridColumn43.Nullable = (Nullable) 1;
    ultraGridColumn43.Width = 92;
    ultraGridColumn44.AutoCompleteMode = (AutoCompleteMode) 1;
    appearance46.BackColor = Color.LightSteelBlue;
    appearance46.TextHAlign = (HAlign) 3;
    ultraGridColumn44.CellAppearance = (AppearanceBase) appearance46;
    ultraGridColumn44.Format = "#,##0.00;(#,##0.00)";
    ((HeaderBase) ultraGridColumn44.Header).Caption = "Exch. Applied";
    ultraGridColumn44.Header.VisiblePosition = 12;
    ultraGridColumn44.Nullable = (Nullable) 1;
    ultraGridColumn44.Width = 96 /*0x60*/;
    ultraGridColumn45.AutoCompleteMode = (AutoCompleteMode) 1;
    ultraGridColumn45.CellActivation = (Activation) 1;
    ultraGridColumn45.Format = "#,##0.00;(#,##0.00)";
    ((HeaderBase) ultraGridColumn45.Header).Caption = "Total TBA";
    ultraGridColumn45.Header.VisiblePosition = 13;
    ultraGridColumn45.Hidden = true;
    ultraGridBand3.Columns.Add((object) ultraGridColumn31);
    ultraGridBand3.Columns.Add((object) ultraGridColumn32);
    ultraGridBand3.Columns.Add((object) ultraGridColumn33);
    ultraGridBand3.Columns.Add((object) ultraGridColumn34);
    ultraGridBand3.Columns.Add((object) ultraGridColumn35);
    ultraGridBand3.Columns.Add((object) ultraGridColumn36);
    ultraGridBand3.Columns.Add((object) ultraGridColumn37);
    ultraGridBand3.Columns.Add((object) ultraGridColumn38);
    ultraGridBand3.Columns.Add((object) ultraGridColumn39);
    ultraGridBand3.Columns.Add((object) ultraGridColumn40);
    ultraGridBand3.Columns.Add((object) ultraGridColumn41);
    ultraGridBand3.Columns.Add((object) ultraGridColumn42);
    ultraGridBand3.Columns.Add((object) ultraGridColumn43);
    ultraGridBand3.Columns.Add((object) ultraGridColumn44);
    ultraGridBand3.Columns.Add((object) ultraGridColumn45);
    ((HeaderBase) ultraGridBand3.Header).Caption = "Outstanding Invoice Details";
    ultraGridBand3.Override.AllowAddNew = (AllowAddNew) 2;
    ultraGridBand3.Override.AllowDelete = (DefaultableBoolean) 2;
    ultraGridBand3.Override.AllowUpdate = (DefaultableBoolean) 1;
    appearance47.TextHAlign = (HAlign) 3;
    ultraGridBand3.Override.CellAppearance = (AppearanceBase) appearance47;
    appearance48.TextHAlign = (HAlign) 3;
    ultraGridBand3.Override.HeaderAppearance = (AppearanceBase) appearance48;
    ultraGridBand3.Override.HeaderClickAction = (HeaderClickAction) 2;
    ultraGridBand3.Override.RowSelectors = (DefaultableBoolean) 2;
    ((UltraGridBase) this.ugWorksheet).DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    ((UltraGridBase) this.ugWorksheet).DisplayLayout.BandsSerializer.Add((object) ultraGridBand2);
    ((UltraGridBase) this.ugWorksheet).DisplayLayout.BandsSerializer.Add((object) ultraGridBand3);
    ((UltraGridBase) this.ugWorksheet).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.ugWorksheet).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.ugWorksheet).DisplayLayout.Override.CellClickAction = (CellClickAction) 3;
    ((UltraGridBase) this.ugWorksheet).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 1;
    ((UltraGridBase) this.ugWorksheet).DisplayLayout.Override.SelectTypeRow = (SelectType) 3;
    ((Control) this.ugWorksheet).Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.ugWorksheet).ImeMode = ImeMode.On;
    ((Control) this.ugWorksheet).Location = new Point(8, 200);
    ((Control) this.ugWorksheet).Name = "ugWorksheet";
    this.ugWorksheet.RowUpdateCancelAction = (RowUpdateCancelAction) 1;
    ((Control) this.ugWorksheet).Size = new Size(986, 504);
    ((UltraControlBase) this.ugWorksheet).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.ugWorksheet).TabIndex = 56;
    this.ugWorksheet.UpdateMode = (UpdateMode) 2;
    this.GroupBox2.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.GroupBox2.Location = new Point(368, 24);
    this.GroupBox2.Name = "GroupBox2";
    this.GroupBox2.Size = new Size(344, 168);
    this.GroupBox2.TabIndex = 57;
    this.GroupBox2.TabStop = false;
    this.GroupBox2.Text = "Remitter Account Information";
    this.AutoScaleBaseSize = new Size(5, 13);
    this.ClientSize = new Size(1002, 710);
    this.Controls.Add((Control) this.GroupBox2);
    this.Controls.Add((Control) this.txtMemo);
    this.Controls.Add((Control) this.Label2);
    this.Controls.Add((Control) this.GroupBox1);
    this.Controls.Add((Control) this.ugWorksheet);
    this.Controls.Add((Control) this._frmRemittance_Toolbars_Dock_Area_Right);
    this.Controls.Add((Control) this._frmRemittance_Toolbars_Dock_Area_Left);
    this.Controls.Add((Control) this._frmRemittance_Toolbars_Dock_Area_Top);
    this.Controls.Add((Control) this._frmRemittance_Toolbars_Dock_Area_Bottom);
    this.Name = nameof (frmCashReceipts);
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Cash Receipts";
    this.Controls.SetChildIndex((Control) this._frmRemittance_Toolbars_Dock_Area_Bottom, 0);
    this.Controls.SetChildIndex((Control) this._frmRemittance_Toolbars_Dock_Area_Top, 0);
    this.Controls.SetChildIndex((Control) this._frmRemittance_Toolbars_Dock_Area_Left, 0);
    this.Controls.SetChildIndex((Control) this._frmRemittance_Toolbars_Dock_Area_Right, 0);
    this.Controls.SetChildIndex((Control) this.ugWorksheet, 0);
    this.Controls.SetChildIndex((Control) this.GroupBox1, 0);
    this.Controls.SetChildIndex((Control) this.Label2, 0);
    this.Controls.SetChildIndex((Control) this.txtMemo, 0);
    this.Controls.SetChildIndex((Control) this.GroupBox2, 0);
    ((ISupportInitialize) this.utmRemittanceMenu).EndInit();
    this.GroupBox1.ResumeLayout(false);
    this.dsRemittanceData.EndInit();
    ((ISupportInitialize) this.ugWorksheet).EndInit();
    this.ResumeLayout(false);
  }
}
