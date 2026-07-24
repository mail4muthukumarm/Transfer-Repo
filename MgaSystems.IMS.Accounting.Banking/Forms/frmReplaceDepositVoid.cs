// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Banking.Forms.frmReplaceDepositVoid
// Assembly: MgaSystems.IMS.Accounting.Banking, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: ED5B99DC-3DD2-44AB-BA36-49A11A94937D
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Banking.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinGrid;
using MGASystems.Common;
using MGASystems.IMS.Accounting.AccountingDatasets;
using MGASystems.Tools;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Banking.Forms;

public class frmReplaceDepositVoid : Form
{
  private IContainer components;
  private int _depositId;
  private int _bankGlAccountId;
  private int _glCompanyId;

  public frmReplaceDepositVoid()
  {
    this.Load += new EventHandler(this.frmReplaceDepositVoid_Load);
    this.InitializeComponent();
  }

  public frmReplaceDepositVoid(int DepositId, int BankGLAccountID, int GLCompanyID)
  {
    this.Load += new EventHandler(this.frmReplaceDepositVoid_Load);
    this.InitializeComponent();
    this._depositId = DepositId;
    this._bankGlAccountId = BankGLAccountID;
    this._glCompanyId = GLCompanyID;
    this.FormDataConnection.ConnectionString = CurrentUser.Instance.ConnectionString;
    this.daGetVoidedCashReceipts.SelectCommand.Parameters["@depositId"].Value = (object) this._depositId;
    this.daGetVoidedCashReceipts.Fill((DataTable) this.DsBankDepositVoids1.CashReceipts);
    this.daGetOpenCashReceipts.SelectCommand.Parameters["@bankglacctid"].Value = (object) this._bankGlAccountId;
    this.daGetOpenCashReceipts.Fill((DataTable) this.DsAssignedCashReceipts1.AssignedCashReceipts);
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  [field: AccessedThroughProperty("EllipsePanel1")]
  internal virtual EllipsePanel EllipsePanel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label1")]
  internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("EllipsePanel2")]
  internal virtual EllipsePanel EllipsePanel2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label2")]
  internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual UltraButton btnCancel
  {
    get => this._btnCancel;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnCancel_Click);
      UltraButton btnCancel1 = this._btnCancel;
      if (btnCancel1 != null)
        ((Control) btnCancel1).Click -= eventHandler;
      this._btnCancel = value;
      UltraButton btnCancel2 = this._btnCancel;
      if (btnCancel2 == null)
        return;
      ((Control) btnCancel2).Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("gridVoidedDeposits")]
  internal virtual UltraGrid gridVoidedDeposits { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("daGetVoidedCashReceipts")]
  internal virtual SqlDataAdapter daGetVoidedCashReceipts { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlSelectCommand1")]
  internal virtual SqlCommand SqlSelectCommand1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("FormDataConnection")]
  internal virtual SqlConnection FormDataConnection { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("DsBankDepositVoids1")]
  internal virtual dsBankDepositVoids DsBankDepositVoids1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("DsAssignedCashReceipts1")]
  internal virtual dsAssignedCashReceipts DsAssignedCashReceipts1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("daGetOpenCashReceipts")]
  internal virtual SqlDataAdapter daGetOpenCashReceipts { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlSelectCommand3")]
  internal virtual SqlCommand SqlSelectCommand3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual UltraButton btnSave
  {
    get => this._btnSave;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnSave_Click);
      UltraButton btnSave1 = this._btnSave;
      if (btnSave1 != null)
        ((Control) btnSave1).Click -= eventHandler;
      this._btnSave = value;
      UltraButton btnSave2 = this._btnSave;
      if (btnSave2 == null)
        return;
      ((Control) btnSave2).Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("gridOpenDeposits")]
  internal virtual UltraGrid gridOpenDeposits { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    Appearance appearance1 = new Appearance();
    UltraGridBand ultraGridBand1 = new UltraGridBand("CashReceipts", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("transactnum");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("postDate");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("Remitter");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("CheckNumber");
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("Amount");
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    UltraGridBand ultraGridBand2 = new UltraGridBand("AssignedCashReceipts", -1);
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("transactNum");
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("postDate");
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("remitterGuid");
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("Remitter");
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("CheckNumber");
    Appearance appearance7 = new Appearance();
    UltraGridColumn ultraGridColumn11 = new UltraGridColumn("Amount");
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    UltraGridColumn ultraGridColumn12 = new UltraGridColumn("Select", 0);
    Appearance appearance10 = new Appearance();
    Appearance appearance11 = new Appearance();
    Appearance appearance12 = new Appearance();
    ResourceManager resourceManager = new ResourceManager(typeof (frmReplaceDepositVoid));
    Appearance appearance13 = new Appearance();
    this.EllipsePanel1 = new EllipsePanel();
    this.gridVoidedDeposits = new UltraGrid();
    this.DsBankDepositVoids1 = new dsBankDepositVoids();
    this.Label1 = new Label();
    this.EllipsePanel2 = new EllipsePanel();
    this.gridOpenDeposits = new UltraGrid();
    this.DsAssignedCashReceipts1 = new dsAssignedCashReceipts();
    this.Label2 = new Label();
    this.btnSave = new UltraButton();
    this.btnCancel = new UltraButton();
    this.daGetVoidedCashReceipts = new SqlDataAdapter();
    this.SqlSelectCommand1 = new SqlCommand();
    this.FormDataConnection = new SqlConnection();
    this.daGetOpenCashReceipts = new SqlDataAdapter();
    this.SqlSelectCommand3 = new SqlCommand();
    this.EllipsePanel1.SuspendLayout();
    ((ISupportInitialize) this.gridVoidedDeposits).BeginInit();
    this.DsBankDepositVoids1.BeginInit();
    this.EllipsePanel2.SuspendLayout();
    ((ISupportInitialize) this.gridOpenDeposits).BeginInit();
    this.DsAssignedCashReceipts1.BeginInit();
    this.SuspendLayout();
    this.EllipsePanel1.Controls.Add((Control) this.gridVoidedDeposits);
    this.EllipsePanel1.Controls.Add((Control) this.Label1);
    this.EllipsePanel1.Location = new Point(8, 8);
    this.EllipsePanel1.Name = "EllipsePanel1";
    this.EllipsePanel1.Size = new Size(576, 176 /*0xB0*/);
    this.EllipsePanel1.TabIndex = 0;
    ((UltraGridBase) this.gridVoidedDeposits).DataMember = "CashReceipts";
    ((UltraGridBase) this.gridVoidedDeposits).DataSource = (object) this.DsBankDepositVoids1;
    appearance1.BackColor = Color.White;
    appearance1.BorderColor = Color.DarkGray;
    ((UltraGridBase) this.gridVoidedDeposits).DisplayLayout.Appearance = (AppearanceBase) appearance1;
    ((UltraGridBase) this.gridVoidedDeposits).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ((HeaderBase) ultraGridColumn2.Header).Caption = "Post Date";
    ultraGridColumn2.Header.VisiblePosition = 1;
    ultraGridColumn2.Width = 83;
    ultraGridColumn3.Header.VisiblePosition = 2;
    ultraGridColumn3.Width = 212;
    ((HeaderBase) ultraGridColumn4.Header).Caption = "Check #";
    ultraGridColumn4.Header.VisiblePosition = 3;
    ultraGridColumn4.Width = 85;
    appearance2.TextHAlign = (HAlign) 3;
    ultraGridColumn5.CellAppearance = (AppearanceBase) appearance2;
    ultraGridColumn5.Format = "c";
    appearance3.TextHAlign = (HAlign) 3;
    ((HeaderBase) ultraGridColumn5.Header).Appearance = (AppearanceBase) appearance3;
    ultraGridColumn5.Header.VisiblePosition = 4;
    ultraGridColumn5.Width = 178;
    ultraGridBand1.Columns.AddRange(new object[5]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3,
      (object) ultraGridColumn4,
      (object) ultraGridColumn5
    });
    ((UltraGridBase) this.gridVoidedDeposits).DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    ((UltraGridBase) this.gridVoidedDeposits).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.gridVoidedDeposits).DisplayLayout.Override.AllowAddNew = (AllowAddNew) 2;
    ((UltraGridBase) this.gridVoidedDeposits).DisplayLayout.Override.AllowColMoving = (AllowColMoving) 1;
    ((UltraGridBase) this.gridVoidedDeposits).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 1;
    ((UltraGridBase) this.gridVoidedDeposits).DisplayLayout.Override.AllowColSwapping = (AllowColSwapping) 1;
    ((UltraGridBase) this.gridVoidedDeposits).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridVoidedDeposits).DisplayLayout.Override.AllowGroupBy = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridVoidedDeposits).DisplayLayout.Override.AllowGroupMoving = (AllowGroupMoving) 1;
    ((UltraGridBase) this.gridVoidedDeposits).DisplayLayout.Override.AllowGroupSwapping = (AllowGroupSwapping) 1;
    ((UltraGridBase) this.gridVoidedDeposits).DisplayLayout.Override.AllowRowFiltering = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridVoidedDeposits).DisplayLayout.Override.AllowRowLayoutCellSizing = (RowLayoutSizing) 1;
    ((UltraGridBase) this.gridVoidedDeposits).DisplayLayout.Override.AllowRowLayoutLabelSizing = (RowLayoutSizing) 1;
    ((UltraGridBase) this.gridVoidedDeposits).DisplayLayout.Override.AllowRowSummaries = (AllowRowSummaries) 2;
    ((UltraGridBase) this.gridVoidedDeposits).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridVoidedDeposits).DisplayLayout.Override.BorderStyleCardArea = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.gridVoidedDeposits).DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.gridVoidedDeposits).DisplayLayout.Override.BorderStyleHeader = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.gridVoidedDeposits).DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.gridVoidedDeposits).DisplayLayout.Override.BorderStyleRowSelector = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.gridVoidedDeposits).DisplayLayout.Override.BorderStyleSummaryFooter = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.gridVoidedDeposits).DisplayLayout.Override.BorderStyleSummaryFooterCaption = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.gridVoidedDeposits).DisplayLayout.Override.BorderStyleSummaryValue = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.gridVoidedDeposits).DisplayLayout.Override.BorderStyleTemplateAddRow = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.gridVoidedDeposits).DisplayLayout.Override.CellClickAction = (CellClickAction) 2;
    appearance4.BackColor = Color.White;
    appearance4.FontData.BoldAsString = "True";
    appearance4.TextHAlign = (HAlign) 1;
    ((UltraGridBase) this.gridVoidedDeposits).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance4;
    ((UltraGridBase) this.gridVoidedDeposits).DisplayLayout.Override.MaxSelectedRows = 1;
    ((UltraGridBase) this.gridVoidedDeposits).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance5.BackColor = Color.White;
    appearance5.BackColor2 = Color.LightSteelBlue;
    appearance5.BackGradientStyle = (GradientStyle) 2;
    appearance5.ForeColor = Color.Black;
    ((UltraGridBase) this.gridVoidedDeposits).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance5;
    ((Control) this.gridVoidedDeposits).Location = new Point(8, 24);
    ((Control) this.gridVoidedDeposits).Name = "gridVoidedDeposits";
    ((Control) this.gridVoidedDeposits).Size = new Size(560, 144 /*0x90*/);
    ((UltraControlBase) this.gridVoidedDeposits).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.gridVoidedDeposits).TabIndex = 3;
    this.DsBankDepositVoids1.DataSetName = "dsBankDepositVoids";
    this.DsBankDepositVoids1.Locale = new CultureInfo("en-US");
    this.Label1.AutoSize = true;
    this.Label1.Font = new Font("Tahoma", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label1.Location = new Point(8, 8);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(144 /*0x90*/, 20);
    this.Label1.TabIndex = 1;
    this.Label1.Text = "Voided Transactions";
    this.EllipsePanel2.Controls.Add((Control) this.gridOpenDeposits);
    this.EllipsePanel2.Controls.Add((Control) this.Label2);
    this.EllipsePanel2.Location = new Point(8, 192 /*0xC0*/);
    this.EllipsePanel2.Name = "EllipsePanel2";
    this.EllipsePanel2.Size = new Size(576, 192 /*0xC0*/);
    this.EllipsePanel2.TabIndex = 1;
    ((UltraGridBase) this.gridOpenDeposits).DataMember = "AssignedCashReceipts";
    ((UltraGridBase) this.gridOpenDeposits).DataSource = (object) this.DsAssignedCashReceipts1;
    appearance6.BackColor = Color.White;
    appearance6.BorderColor = Color.DimGray;
    ((UltraGridBase) this.gridOpenDeposits).DisplayLayout.Appearance = (AppearanceBase) appearance6;
    ((UltraGridBase) this.gridOpenDeposits).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn6.Header.VisiblePosition = 1;
    ultraGridColumn6.Hidden = true;
    ((HeaderBase) ultraGridColumn7.Header).Caption = "Post Date";
    ultraGridColumn7.Header.VisiblePosition = 2;
    ultraGridColumn7.Width = 84;
    ultraGridColumn8.Header.VisiblePosition = 3;
    ultraGridColumn8.Hidden = true;
    ultraGridColumn9.Header.VisiblePosition = 4;
    ultraGridColumn9.Width = 207;
    appearance7.TextHAlign = (HAlign) 1;
    ultraGridColumn10.CellAppearance = (AppearanceBase) appearance7;
    ((HeaderBase) ultraGridColumn10.Header).Caption = "Check #";
    ultraGridColumn10.Header.VisiblePosition = 5;
    ultraGridColumn10.Width = 138;
    appearance8.TextHAlign = (HAlign) 3;
    ultraGridColumn11.CellAppearance = (AppearanceBase) appearance8;
    ultraGridColumn11.Format = "c";
    appearance9.TextHAlign = (HAlign) 3;
    ((HeaderBase) ultraGridColumn11.Header).Appearance = (AppearanceBase) appearance9;
    ultraGridColumn11.Header.VisiblePosition = 6;
    ultraGridColumn11.Width = 112 /*0x70*/;
    ultraGridColumn12.DataType = typeof (bool);
    ((HeaderBase) ultraGridColumn12.Header).Caption = "";
    ultraGridColumn12.Header.VisiblePosition = 0;
    ultraGridColumn12.LockedWidth = true;
    ultraGridColumn12.Width = 17;
    ultraGridBand2.Columns.AddRange(new object[7]
    {
      (object) ultraGridColumn6,
      (object) ultraGridColumn7,
      (object) ultraGridColumn8,
      (object) ultraGridColumn9,
      (object) ultraGridColumn10,
      (object) ultraGridColumn11,
      (object) ultraGridColumn12
    });
    ((UltraGridBase) this.gridOpenDeposits).DisplayLayout.BandsSerializer.Add((object) ultraGridBand2);
    ((UltraGridBase) this.gridOpenDeposits).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.gridOpenDeposits).DisplayLayout.Override.AllowAddNew = (AllowAddNew) 2;
    ((UltraGridBase) this.gridOpenDeposits).DisplayLayout.Override.AllowColMoving = (AllowColMoving) 1;
    ((UltraGridBase) this.gridOpenDeposits).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 1;
    ((UltraGridBase) this.gridOpenDeposits).DisplayLayout.Override.AllowColSwapping = (AllowColSwapping) 1;
    ((UltraGridBase) this.gridOpenDeposits).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridOpenDeposits).DisplayLayout.Override.AllowGroupBy = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridOpenDeposits).DisplayLayout.Override.AllowGroupMoving = (AllowGroupMoving) 1;
    ((UltraGridBase) this.gridOpenDeposits).DisplayLayout.Override.AllowGroupSwapping = (AllowGroupSwapping) 1;
    ((UltraGridBase) this.gridOpenDeposits).DisplayLayout.Override.AllowRowFiltering = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridOpenDeposits).DisplayLayout.Override.AllowRowLayoutCellSizing = (RowLayoutSizing) 1;
    ((UltraGridBase) this.gridOpenDeposits).DisplayLayout.Override.AllowRowLayoutLabelSizing = (RowLayoutSizing) 1;
    ((UltraGridBase) this.gridOpenDeposits).DisplayLayout.Override.AllowRowSummaries = (AllowRowSummaries) 2;
    ((UltraGridBase) this.gridOpenDeposits).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 1;
    ((UltraGridBase) this.gridOpenDeposits).DisplayLayout.Override.BorderStyleCardArea = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.gridOpenDeposits).DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.gridOpenDeposits).DisplayLayout.Override.BorderStyleHeader = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.gridOpenDeposits).DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.gridOpenDeposits).DisplayLayout.Override.BorderStyleRowSelector = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.gridOpenDeposits).DisplayLayout.Override.BorderStyleSummaryFooter = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.gridOpenDeposits).DisplayLayout.Override.BorderStyleSummaryFooterCaption = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.gridOpenDeposits).DisplayLayout.Override.BorderStyleSummaryValue = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.gridOpenDeposits).DisplayLayout.Override.BorderStyleTemplateAddRow = (UIElementBorderStyle) 1;
    appearance10.BackColor = Color.White;
    appearance10.FontData.BoldAsString = "True";
    appearance10.TextHAlign = (HAlign) 1;
    ((UltraGridBase) this.gridOpenDeposits).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance10;
    ((UltraGridBase) this.gridOpenDeposits).DisplayLayout.Override.MaxSelectedRows = 1;
    ((UltraGridBase) this.gridOpenDeposits).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance11.BackColor = Color.White;
    appearance11.BackColor2 = Color.LightSteelBlue;
    appearance11.BackGradientStyle = (GradientStyle) 2;
    appearance11.ForeColor = Color.Black;
    ((UltraGridBase) this.gridOpenDeposits).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance11;
    ((UltraControlBase) this.gridOpenDeposits).UseFlatMode = (DefaultableBoolean) 1;
    ((Control) this.gridOpenDeposits).Location = new Point(8, 32 /*0x20*/);
    ((Control) this.gridOpenDeposits).Name = "gridOpenDeposits";
    ((Control) this.gridOpenDeposits).Size = new Size(560, 144 /*0x90*/);
    ((UltraControlBase) this.gridOpenDeposits).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.gridOpenDeposits).TabIndex = 2;
    this.DsAssignedCashReceipts1.DataSetName = "dsAssignedCashReceipts";
    this.DsAssignedCashReceipts1.Locale = new CultureInfo("en-US");
    this.Label2.AutoSize = true;
    this.Label2.Font = new Font("Tahoma", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label2.Location = new Point(8, 8);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(200, 20);
    this.Label2.TabIndex = 1;
    this.Label2.Text = "Un-Deposited Cash Receipts";
    appearance12.Image = RuntimeHelpers.GetObjectValue(resourceManager.GetObject("Appearance12.Image"));
    ((ControlBase) this.btnSave).Appearance = (AppearanceBase) appearance12;
    ((Control) this.btnSave).Location = new Point(344, 392);
    ((Control) this.btnSave).Name = "btnSave";
    ((Control) this.btnSave).Size = new Size(144 /*0x90*/, 23);
    ((Control) this.btnSave).TabIndex = 2;
    ((ControlBase) this.btnSave).Text = "Save Replacement";
    appearance13.Image = RuntimeHelpers.GetObjectValue(resourceManager.GetObject("Appearance13.Image"));
    ((ControlBase) this.btnCancel).Appearance = (AppearanceBase) appearance13;
    ((Control) this.btnCancel).Location = new Point(496, 392);
    ((Control) this.btnCancel).Name = "btnCancel";
    ((Control) this.btnCancel).Size = new Size(88, 23);
    ((Control) this.btnCancel).TabIndex = 3;
    ((ControlBase) this.btnCancel).Text = "Cancel";
    this.daGetVoidedCashReceipts.SelectCommand = this.SqlSelectCommand1;
    this.daGetVoidedCashReceipts.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "spFin_GetDepositVoidedCashReceipts", new DataColumnMapping[3]
      {
        new DataColumnMapping("transactnum", "transactnum"),
        new DataColumnMapping("Remitter", "Remitter"),
        new DataColumnMapping("amount", "amount")
      })
    });
    this.SqlSelectCommand1.CommandText = "[spFin_GetDepositVoidedCashReceipts]";
    this.SqlSelectCommand1.CommandType = CommandType.StoredProcedure;
    this.SqlSelectCommand1.Connection = this.FormDataConnection;
    this.SqlSelectCommand1.Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, false, (byte) 0, (byte) 0, "", DataRowVersion.Current, (object) null));
    this.SqlSelectCommand1.Parameters.Add(new SqlParameter("@depositId", SqlDbType.Int, 4));
    this.FormDataConnection.ConnectionString = "workstation id=WREYES;packet size=4096;user id=mgasystems;data source=MGASYSTEMS;persist security info=False;initial catalog=IMS";
    this.daGetOpenCashReceipts.SelectCommand = this.SqlSelectCommand3;
    this.daGetOpenCashReceipts.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "spFin_GetOpenCashReceipts", new DataColumnMapping[6]
      {
        new DataColumnMapping("transactNum", "transactNum"),
        new DataColumnMapping("postDate", "postDate"),
        new DataColumnMapping("remitterGuid", "remitterGuid"),
        new DataColumnMapping("Remitter", "Remitter"),
        new DataColumnMapping("checkNumber", "checkNumber"),
        new DataColumnMapping("Amount", "Amount")
      })
    });
    this.SqlSelectCommand3.CommandText = "[spFin_GetOpenCashReceipts]";
    this.SqlSelectCommand3.CommandType = CommandType.StoredProcedure;
    this.SqlSelectCommand3.Connection = this.FormDataConnection;
    this.SqlSelectCommand3.Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, false, (byte) 0, (byte) 0, "", DataRowVersion.Current, (object) null));
    this.SqlSelectCommand3.Parameters.Add(new SqlParameter("@bankglacctid", SqlDbType.Int, 4));
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.WhiteSmoke;
    this.ClientSize = new Size(592, 419);
    this.ControlBox = false;
    this.Controls.Add((Control) this.btnCancel);
    this.Controls.Add((Control) this.btnSave);
    this.Controls.Add((Control) this.EllipsePanel2);
    this.Controls.Add((Control) this.EllipsePanel1);
    this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.FormBorderStyle = FormBorderStyle.FixedDialog;
    this.Name = nameof (frmReplaceDepositVoid);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Deposit Void Replacement";
    this.EllipsePanel1.ResumeLayout(false);
    ((ISupportInitialize) this.gridVoidedDeposits).EndInit();
    this.DsBankDepositVoids1.EndInit();
    this.EllipsePanel2.ResumeLayout(false);
    ((ISupportInitialize) this.gridOpenDeposits).EndInit();
    this.DsAssignedCashReceipts1.EndInit();
    this.ResumeLayout(false);
  }

  private void btnCancel_Click(object sender, EventArgs e) => this.Close();

  private void frmReplaceDepositVoid_Load(object sender, EventArgs e)
  {
    if (((UltraGridBase) this.gridVoidedDeposits).Rows.Count == 0)
      return;
    ((UltraGridBase) this.gridVoidedDeposits).Rows[0].Selected = true;
    ((UltraGridBase) this.gridVoidedDeposits).ActiveRow = ((UltraGridBase) this.gridVoidedDeposits).Rows[0];
  }

  private void SaveReplacement(
    SqlCommand cmd,
    int OldTransactionNumber,
    int NewTransactionNumber,
    Decimal NewAmount)
  {
    SqlCommand sqlCommand = cmd;
    sqlCommand.Parameters.Clear();
    sqlCommand.Parameters.AddWithValue("@depositId", (object) this._depositId);
    sqlCommand.Parameters.AddWithValue("@old", (object) OldTransactionNumber);
    sqlCommand.Parameters.AddWithValue("@new", (object) NewTransactionNumber);
    sqlCommand.Parameters.AddWithValue("@amount", (object) NewAmount);
    sqlCommand.ExecuteNonQuery();
  }

  private bool ValidateForm()
  {
    bool flag1 = false;
    bool flag2 = false;
    UltraGridRow ultraGridRow = (UltraGridRow) null;
    int num1 = 0;
    try
    {
      RowEnumerator enumerator = ((UltraGridBase) this.gridOpenDeposits).Rows.GetEnumerator();
      Decimal num2;
      while (enumerator.MoveNext())
      {
        UltraGridRow current = enumerator.Current;
        if (Conversions.ToBoolean(current.Cells["select"].Value))
        {
          ++num1;
          num2 = Decimal.Add(num2, Conversions.ToDecimal(current.Cells["amount"].Value));
        }
      }
      if (num1 == 0)
      {
        int num3 = (int) MessageBox.Show("You must select a replacement transaction to continue.", "Replacement Transaction Required!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return false;
      }
      foreach (UltraGridRow row in ((UltraGridBase) this.gridVoidedDeposits).Rows)
      {
        if (row.Selected)
        {
          ultraGridRow = row;
          flag1 = true;
          break;
        }
      }
      foreach (UltraGridRow row in ((UltraGridBase) this.gridOpenDeposits).Rows)
      {
        if (Conversions.ToBoolean(row.Cells["select"].Value))
        {
          flag2 = true;
          break;
        }
      }
      return (Decimal.Compare(Conversions.ToDecimal(ultraGridRow.Cells["amount"].Value), num2) == 0 || MessageBox.Show("The voided cash receipt and the replacement cash receipt have different amounts. This will change the amount of the original deposit. Do you wish to continue?", "Change Original Receipt?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.No) && flag2 && flag1;
    }
    finally
    {
    }
  }

  private void btnSave_Click(object sender, EventArgs e)
  {
    // ISSUE: unable to decompile the method.
  }
}
