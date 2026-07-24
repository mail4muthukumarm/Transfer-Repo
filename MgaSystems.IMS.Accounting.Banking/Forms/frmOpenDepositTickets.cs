// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Banking.Forms.frmOpenDepositTickets
// Assembly: MgaSystems.IMS.Accounting.Banking, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: ED5B99DC-3DD2-44AB-BA36-49A11A94937D
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Banking.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinGrid;
using MGASystems.Common;
using MGASystems.IMS.Accounting.AccountingDatasets;
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

public sealed class frmOpenDepositTickets : Form
{
  private IContainer components;
  private int _glacctid;
  private int _depositID;
  private Decimal _depositAmount;
  private DateTime _depositDate;

  public frmOpenDepositTickets() => this.InitializeComponent();

  public frmOpenDepositTickets(int BankGLAccountID)
  {
    this.InitializeComponent();
    this._glacctid = BankGLAccountID;
    this.FormDataConnection.ConnectionString = CurrentUser.Instance.ConnectionString;
    this.daGetOpenDepositTickets.SelectCommand.Parameters["@bankAcctGL"].Value = (object) this._glacctid;
    this.daGetOpenDepositTickets.Fill((DataTable) this.DsOpenDepositTickets1.DepositTickets);
    if (((UltraGridBase) this.gridOpenDepositTickets).Rows.Count <= 0)
      return;
    ((UltraGridBase) this.gridOpenDepositTickets).Rows[0].Selected = true;
    ((UltraGridBase) this.gridOpenDepositTickets).ActiveRow = ((UltraGridBase) this.gridOpenDepositTickets).Rows[0];
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

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

  [field: AccessedThroughProperty("gridOpenDepositTickets")]
  internal virtual UltraGrid gridOpenDepositTickets { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("DsOpenDepositTickets1")]
  internal virtual dsOpenDepositTickets DsOpenDepositTickets1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("daGetOpenDepositTickets")]
  internal virtual SqlDataAdapter daGetOpenDepositTickets { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlSelectCommand1")]
  internal virtual SqlCommand SqlSelectCommand1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("FormDataConnection")]
  internal virtual SqlConnection FormDataConnection { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    Appearance appearance1 = new Appearance();
    ResourceManager resourceManager = new ResourceManager(typeof (frmOpenDepositTickets));
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    UltraGridBand ultraGridBand = new UltraGridBand("DepositTickets", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("DepositId");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("DepositDate");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("UserGuid");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("UserName");
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("DepositReference");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("CurrentAmount");
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("BankGL");
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    this.btnSave = new UltraButton();
    this.btnCancel = new UltraButton();
    this.gridOpenDepositTickets = new UltraGrid();
    this.DsOpenDepositTickets1 = new dsOpenDepositTickets();
    this.daGetOpenDepositTickets = new SqlDataAdapter();
    this.SqlSelectCommand1 = new SqlCommand();
    this.FormDataConnection = new SqlConnection();
    ((ISupportInitialize) this.gridOpenDepositTickets).BeginInit();
    this.DsOpenDepositTickets1.BeginInit();
    this.SuspendLayout();
    appearance1.BackColor = Color.Gainsboro;
    appearance1.BackColor2 = Color.White;
    appearance1.BackGradientStyle = (GradientStyle) 2;
    appearance1.Image = RuntimeHelpers.GetObjectValue(resourceManager.GetObject("Appearance1.Image"));
    ((ControlBase) this.btnSave).Appearance = (AppearanceBase) appearance1;
    ((UltraControlBase) this.btnSave).UseFlatMode = (DefaultableBoolean) 1;
    ((Control) this.btnSave).Location = new Point(400, 240 /*0xF0*/);
    ((Control) this.btnSave).Name = "btnSave";
    ((Control) this.btnSave).Size = new Size(100, 24);
    ((Control) this.btnSave).TabIndex = 0;
    ((ControlBase) this.btnSave).Text = "Select";
    appearance2.BackColor = Color.Gainsboro;
    appearance2.BackColor2 = Color.White;
    appearance2.BackGradientStyle = (GradientStyle) 2;
    appearance2.Image = RuntimeHelpers.GetObjectValue(resourceManager.GetObject("Appearance2.Image"));
    ((ControlBase) this.btnCancel).Appearance = (AppearanceBase) appearance2;
    ((UltraButtonBase) this.btnCancel).DialogResult = DialogResult.Cancel;
    ((UltraControlBase) this.btnCancel).UseFlatMode = (DefaultableBoolean) 1;
    ((Control) this.btnCancel).Location = new Point(504, 240 /*0xF0*/);
    ((Control) this.btnCancel).Name = "btnCancel";
    ((Control) this.btnCancel).Size = new Size(100, 24);
    ((Control) this.btnCancel).TabIndex = 1;
    ((ControlBase) this.btnCancel).Text = "Cancel";
    ((UltraGridBase) this.gridOpenDepositTickets).DataMember = "DepositTickets";
    ((UltraGridBase) this.gridOpenDepositTickets).DataSource = (object) this.DsOpenDepositTickets1;
    appearance3.BackColor = Color.White;
    ((UltraGridBase) this.gridOpenDepositTickets).DisplayLayout.Appearance = (AppearanceBase) appearance3;
    ((UltraGridBase) this.gridOpenDepositTickets).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ((HeaderBase) ultraGridColumn2.Header).Caption = "Deposit Date";
    ultraGridColumn2.Header.VisiblePosition = 1;
    ultraGridColumn2.Width = 96 /*0x60*/;
    ultraGridColumn3.Header.VisiblePosition = 2;
    ultraGridColumn3.Hidden = true;
    ((HeaderBase) ultraGridColumn4.Header).Caption = "User Name";
    ultraGridColumn4.Header.VisiblePosition = 3;
    ultraGridColumn4.Width = 204;
    ((HeaderBase) ultraGridColumn5.Header).Caption = "Deposit Reference";
    ultraGridColumn5.Header.VisiblePosition = 4;
    ultraGridColumn5.Width = 164;
    appearance4.TextHAlign = (HAlign) 3;
    ultraGridColumn6.CellAppearance = (AppearanceBase) appearance4;
    ultraGridColumn6.Format = "c";
    appearance5.TextHAlign = (HAlign) 3;
    ((HeaderBase) ultraGridColumn6.Header).Appearance = (AppearanceBase) appearance5;
    ((HeaderBase) ultraGridColumn6.Header).Caption = "Current Amount";
    ultraGridColumn6.Header.VisiblePosition = 5;
    ultraGridColumn6.Width = 144 /*0x90*/;
    appearance6.TextHAlign = (HAlign) 3;
    ultraGridColumn7.CellAppearance = (AppearanceBase) appearance6;
    ultraGridColumn7.Formula = "c";
    appearance7.TextHAlign = (HAlign) 3;
    ((HeaderBase) ultraGridColumn7.Header).Appearance = (AppearanceBase) appearance7;
    ultraGridColumn7.Header.VisiblePosition = 6;
    ultraGridColumn7.Hidden = true;
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
    ((UltraGridBase) this.gridOpenDepositTickets).DisplayLayout.BandsSerializer.Add((object) ultraGridBand);
    ((UltraGridBase) this.gridOpenDepositTickets).DisplayLayout.BorderStyle = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.gridOpenDepositTickets).DisplayLayout.Override.AllowAddNew = (AllowAddNew) 2;
    ((UltraGridBase) this.gridOpenDepositTickets).DisplayLayout.Override.AllowColMoving = (AllowColMoving) 1;
    ((UltraGridBase) this.gridOpenDepositTickets).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 1;
    ((UltraGridBase) this.gridOpenDepositTickets).DisplayLayout.Override.AllowColSwapping = (AllowColSwapping) 1;
    ((UltraGridBase) this.gridOpenDepositTickets).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridOpenDepositTickets).DisplayLayout.Override.AllowGroupBy = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridOpenDepositTickets).DisplayLayout.Override.AllowGroupMoving = (AllowGroupMoving) 1;
    ((UltraGridBase) this.gridOpenDepositTickets).DisplayLayout.Override.AllowGroupSwapping = (AllowGroupSwapping) 1;
    ((UltraGridBase) this.gridOpenDepositTickets).DisplayLayout.Override.AllowRowFiltering = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridOpenDepositTickets).DisplayLayout.Override.AllowRowLayoutCellSizing = (RowLayoutSizing) 1;
    ((UltraGridBase) this.gridOpenDepositTickets).DisplayLayout.Override.AllowRowLayoutLabelSizing = (RowLayoutSizing) 1;
    ((UltraGridBase) this.gridOpenDepositTickets).DisplayLayout.Override.AllowRowSummaries = (AllowRowSummaries) 2;
    ((UltraGridBase) this.gridOpenDepositTickets).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridOpenDepositTickets).DisplayLayout.Override.BorderStyleCardArea = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.gridOpenDepositTickets).DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.gridOpenDepositTickets).DisplayLayout.Override.BorderStyleHeader = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.gridOpenDepositTickets).DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.gridOpenDepositTickets).DisplayLayout.Override.BorderStyleRowSelector = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.gridOpenDepositTickets).DisplayLayout.Override.BorderStyleSummaryFooter = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.gridOpenDepositTickets).DisplayLayout.Override.BorderStyleSummaryFooterCaption = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.gridOpenDepositTickets).DisplayLayout.Override.BorderStyleSummaryValue = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.gridOpenDepositTickets).DisplayLayout.Override.BorderStyleTemplateAddRow = (UIElementBorderStyle) 1;
    appearance8.TextHAlign = (HAlign) 1;
    appearance8.TextVAlign = (VAlign) 2;
    ((UltraGridBase) this.gridOpenDepositTickets).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance8;
    ((UltraGridBase) this.gridOpenDepositTickets).DisplayLayout.Override.CellClickAction = (CellClickAction) 2;
    appearance9.BackColor = Color.White;
    appearance9.FontData.BoldAsString = "True";
    appearance9.ForeColor = Color.DimGray;
    appearance9.TextHAlign = (HAlign) 1;
    appearance9.TextVAlign = (VAlign) 2;
    ((UltraGridBase) this.gridOpenDepositTickets).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance9;
    ((UltraGridBase) this.gridOpenDepositTickets).DisplayLayout.Override.MaxSelectedRows = 1;
    ((UltraGridBase) this.gridOpenDepositTickets).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance10.BackColor = Color.White;
    appearance10.BackColor2 = Color.LightSteelBlue;
    appearance10.BackGradientStyle = (GradientStyle) 2;
    appearance10.ForeColor = Color.Black;
    ((UltraGridBase) this.gridOpenDepositTickets).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance10;
    ((Control) this.gridOpenDepositTickets).Dock = DockStyle.Top;
    ((Control) this.gridOpenDepositTickets).Location = new Point(0, 0);
    ((Control) this.gridOpenDepositTickets).Name = "gridOpenDepositTickets";
    ((Control) this.gridOpenDepositTickets).Size = new Size(608, 232);
    ((UltraControlBase) this.gridOpenDepositTickets).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.gridOpenDepositTickets).TabIndex = 2;
    this.DsOpenDepositTickets1.DataSetName = "dsOpenDepositTickets";
    this.DsOpenDepositTickets1.Locale = new CultureInfo("en-US");
    this.daGetOpenDepositTickets.SelectCommand = this.SqlSelectCommand1;
    this.daGetOpenDepositTickets.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "spFin_GetOpenDepositTickets", new DataColumnMapping[7]
      {
        new DataColumnMapping("depositId", "depositId"),
        new DataColumnMapping("depositDate", "depositDate"),
        new DataColumnMapping("userGuid", "userGuid"),
        new DataColumnMapping("UserName", "UserName"),
        new DataColumnMapping("DepositReference", "DepositReference"),
        new DataColumnMapping("CurrentAmount", "CurrentAmount"),
        new DataColumnMapping("bankGL", "bankGL")
      })
    });
    this.SqlSelectCommand1.CommandText = "[spFin_GetOpenDepositTickets]";
    this.SqlSelectCommand1.CommandType = CommandType.StoredProcedure;
    this.SqlSelectCommand1.Connection = this.FormDataConnection;
    this.SqlSelectCommand1.Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, false, (byte) 0, (byte) 0, "", DataRowVersion.Current, (object) null));
    this.SqlSelectCommand1.Parameters.Add(new SqlParameter("@bankAcctGL", SqlDbType.Int, 4));
    this.FormDataConnection.ConnectionString = "workstation id=WREYES;packet size=4096;user id=mgasystems;data source=MGASYSTEMS;persist security info=False;initial catalog=IMS";
    this.AcceptButton = (IButtonControl) this.btnSave;
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.White;
    this.CancelButton = (IButtonControl) this.btnCancel;
    this.ClientSize = new Size(608, 269);
    this.ControlBox = false;
    this.Controls.Add((Control) this.gridOpenDepositTickets);
    this.Controls.Add((Control) this.btnCancel);
    this.Controls.Add((Control) this.btnSave);
    this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.ForeColor = Color.Black;
    this.FormBorderStyle = FormBorderStyle.FixedDialog;
    this.Name = nameof (frmOpenDepositTickets);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Open Deposit Tickets";
    ((ISupportInitialize) this.gridOpenDepositTickets).EndInit();
    this.DsOpenDepositTickets1.EndInit();
    this.ResumeLayout(false);
  }

  internal int DepositID => this._depositID;

  internal Decimal DepositAmount => this._depositAmount;

  internal DateTime DepositDate => this._depositDate;

  private void btnCancel_Click(object sender, EventArgs e)
  {
    this.DialogResult = DialogResult.Cancel;
    this.Close();
  }

  private void btnSave_Click(object sender, EventArgs e)
  {
    foreach (UltraGridRow row in ((UltraGridBase) this.gridOpenDepositTickets).Rows)
    {
      if (row.Selected)
      {
        this._depositAmount = Conversions.ToDecimal(row.Cells["currentamount"].Value);
        this._depositID = Conversions.ToInteger(row.Cells["depositid"].Value);
        this._depositDate = Conversions.ToDate(row.Cells["depositdate"].Value);
        this.DialogResult = DialogResult.OK;
        this.Close();
        break;
      }
    }
  }
}
