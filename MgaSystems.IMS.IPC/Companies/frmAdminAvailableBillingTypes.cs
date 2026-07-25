// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.Companies.frmAdminAvailableBillingTypes
// Assembly: MgaSystems.IMS.IPC, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: F22CEF02-8C0F-420D-8344-A8A010CA7834
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.IPC.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using MGASystems.Common;
using MGASystems.Common.BroadcastMessaging;
using MGASystems.Common.ErrorHandling;
using MGASystems.Data;
using MGASystems.Tools;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.InsuredsProducersCompanies.Companies;

[SecureResource("{45331795-F7B4-4E5D-A835-A634CCB23C7E}", "Available Billing Types", "Controls the ability to assign billing types to a specific company/line setup.", "Company")]
public sealed class frmAdminAvailableBillingTypes : Form
{
  private IContainer components;
  private Label Label2;
  private dsAvailableBillingTypes ds;
  private DbConnection cnSQL;
  private DbDataAdapter daCompanyBilling;
  private DbCommand DbSelectCommand2;
  private DataView dvNonDownpay;
  private Guid _companyLineGuid;
  private bool _hasChanges;
  private Dictionary<int, string> _billingDictionary;
  public const string ViewAvailableBillingTypesForm = "{45331795-F7B4-4E5D-A835-A634CCB23C7E}";

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  [field: AccessedThroughProperty("Label1")]
  private virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual MGAButton btnSave
  {
    get => this._btnSave;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnSave_Click);
      MGAButton btnSave1 = this._btnSave;
      if (btnSave1 != null)
        ((Control) btnSave1).Click -= eventHandler;
      this._btnSave = value;
      MGAButton btnSave2 = this._btnSave;
      if (btnSave2 == null)
        return;
      ((Control) btnSave2).Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("TableLayoutPanel1")]
  internal virtual TableLayoutPanel TableLayoutPanel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual UltraGrid ugDownpay
  {
    get => this._ugDownpay;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      CellEventHandler cellEventHandler = new CellEventHandler(this.UltraGridCellChange);
      UltraGrid ugDownpay1 = this._ugDownpay;
      if (ugDownpay1 != null)
        ugDownpay1.CellChange -= cellEventHandler;
      this._ugDownpay = value;
      UltraGrid ugDownpay2 = this._ugDownpay;
      if (ugDownpay2 == null)
        return;
      ugDownpay2.CellChange += cellEventHandler;
    }
  }

  [field: AccessedThroughProperty("dvDownpay")]
  private virtual DataView dvDownpay { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual UltraGrid ugNonDownpay
  {
    get => this._ugNonDownpay;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      CellEventHandler cellEventHandler = new CellEventHandler(this.UltraGridCellChange);
      UltraGrid ugNonDownpay1 = this._ugNonDownpay;
      if (ugNonDownpay1 != null)
        ugNonDownpay1.CellChange -= cellEventHandler;
      this._ugNonDownpay = value;
      UltraGrid ugNonDownpay2 = this._ugNonDownpay;
      if (ugNonDownpay2 == null)
        return;
      ugNonDownpay2.CellChange += cellEventHandler;
    }
  }

  [field: AccessedThroughProperty("DbCommand1")]
  internal virtual DbCommand DbCommand1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlUpdateCommand")]
  internal virtual DbCommand SqlUpdateCommand { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    UltraGridBand ultraGridBand1 = new UltraGridBand("tblCompanyBillingTypes", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("ID");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("BillingTypeID");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("CompanyLineGuid");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("Downpayment");
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("Selected");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("CheckedInUse");
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("BillingType");
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    ScrollBarLook scrollBarLook1 = new ScrollBarLook();
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    Appearance appearance11 = new Appearance();
    UltraGridBand ultraGridBand2 = new UltraGridBand("tblCompanyBillingTypes", -1);
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("ID");
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("BillingTypeID");
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("CompanyLineGuid");
    UltraGridColumn ultraGridColumn11 = new UltraGridColumn("Downpayment");
    UltraGridColumn ultraGridColumn12 = new UltraGridColumn("Selected");
    UltraGridColumn ultraGridColumn13 = new UltraGridColumn("CheckedInUse");
    UltraGridColumn ultraGridColumn14 = new UltraGridColumn("BillingType");
    Appearance appearance12 = new Appearance();
    Appearance appearance13 = new Appearance();
    Appearance appearance14 = new Appearance();
    Appearance appearance15 = new Appearance();
    Appearance appearance16 = new Appearance();
    Appearance appearance17 = new Appearance();
    ScrollBarLook scrollBarLook2 = new ScrollBarLook();
    Appearance appearance18 = new Appearance();
    Appearance appearance19 = new Appearance();
    this.ds = new dsAvailableBillingTypes();
    this.Label1 = new Label();
    this.Label2 = new Label();
    this.btnSave = new MGAButton();
    this.cnSQL = DefaultDatabase.CreateDbConnection();
    this.daCompanyBilling = DefaultDatabase.CreateDataAdapter();
    this.DbCommand1 = DefaultDatabase.CreateCommand();
    this.DbSelectCommand2 = DefaultDatabase.CreateCommand();
    this.SqlUpdateCommand = DefaultDatabase.CreateCommand();
    this.dvNonDownpay = new DataView();
    this.TableLayoutPanel1 = new TableLayoutPanel();
    this.ugNonDownpay = new UltraGrid();
    this.ugDownpay = new UltraGrid();
    this.dvDownpay = new DataView();
    this.ds.BeginInit();
    ((ISupportInitialize) this.btnSave).BeginInit();
    this.dvNonDownpay.BeginInit();
    this.TableLayoutPanel1.SuspendLayout();
    ((ISupportInitialize) this.ugNonDownpay).BeginInit();
    ((ISupportInitialize) this.ugDownpay).BeginInit();
    this.dvDownpay.BeginInit();
    this.SuspendLayout();
    this.ds.DataSetName = "dsAvailableBillingTypes";
    this.ds.Locale = new CultureInfo("en-US");
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.Label1.AutoSize = true;
    this.Label1.Location = new Point(3, 0);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(176 /*0xB0*/, 13);
    this.Label1.TabIndex = 0;
    this.Label1.Text = "Billing types available on the policy:";
    this.Label2.Location = new Point(3, 138);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(254, 28);
    this.Label2.TabIndex = 1;
    this.Label2.Text = "Please select the billing types available on the downpayment invoice:";
    appearance1.ImageHAlign = (HAlign) 2;
    ((ControlBase) this.btnSave).Appearance = (AppearanceBase) appearance1;
    ((UltraButtonBase) this.btnSave).DialogResult = DialogResult.Cancel;
    ((ControlBase) this.btnSave).ImageSize = new Size(24, 24);
    ((ControlBase) this.btnSave).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnSave).Location = new Point(224 /*0xE0*/, 301);
    ((Control) this.btnSave).Name = "btnSave";
    ((Control) this.btnSave).Size = new Size(40, 40);
    ((Control) this.btnSave).TabIndex = 4;
    this.btnSave.UseOSThemes = (DefaultableBoolean) 2;
    this.daCompanyBilling.DeleteCommand = this.DbCommand1;
    this.daCompanyBilling.SelectCommand = this.DbSelectCommand2;
    this.daCompanyBilling.TableMappings.AddRange(new DataTableMapping[2]
    {
      new DataTableMapping("Table", "spAvailableBillingTypes", new DataColumnMapping[5]
      {
        new DataColumnMapping("ID", "ID"),
        new DataColumnMapping("CompanyLineGuid", "CompanyLineGuid"),
        new DataColumnMapping("BillingTypeID", "BillingTypeID"),
        new DataColumnMapping("Downpayment", "Downpayment"),
        new DataColumnMapping("Selected", "Selected")
      }),
      new DataTableMapping("Table1", "Table1", new DataColumnMapping[3]
      {
        new DataColumnMapping("BillingTypeID", "BillingTypeID"),
        new DataColumnMapping("BillingType", "BillingType"),
        new DataColumnMapping("DownpaymentOnly", "DownpaymentOnly")
      })
    });
    this.daCompanyBilling.UpdateCommand = this.SqlUpdateCommand;
    this.DbCommand1.CommandText = "dbo.RemoveCompanyBillingType";
    this.DbCommand1.CommandType = CommandType.StoredProcedure;
    this.DbCommand1.Connection = this.cnSQL;
    this.DbCommand1.Parameters.AddRange((Array) new DbParameter[2]
    {
      DefaultDatabase.CreateParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, false, (byte) 0, (byte) 0, "", DataRowVersion.Current, (object) null),
      DefaultDatabase.CreateParameter("@companyBillingTypeID", SqlDbType.Int, 4, "ID")
    });
    this.DbSelectCommand2.CommandText = "dbo.spAvailableBillingTypes";
    this.DbSelectCommand2.CommandType = CommandType.StoredProcedure;
    this.DbSelectCommand2.Connection = this.cnSQL;
    this.DbSelectCommand2.Parameters.AddRange((Array) new DbParameter[2]
    {
      DefaultDatabase.CreateParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, false, (byte) 0, (byte) 0, "", DataRowVersion.Current, (object) null),
      DefaultDatabase.CreateParameter("@companyLineGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/)
    });
    this.SqlUpdateCommand.CommandText = "dbo.InsertCompanyBillingType";
    this.SqlUpdateCommand.CommandType = CommandType.StoredProcedure;
    this.SqlUpdateCommand.Connection = this.cnSQL;
    this.SqlUpdateCommand.Parameters.AddRange((Array) new DbParameter[4]
    {
      DefaultDatabase.CreateParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, false, (byte) 0, (byte) 0, "", DataRowVersion.Current, (object) null),
      DefaultDatabase.CreateParameter("@CompanyLineGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "CompanyLineGuid"),
      DefaultDatabase.CreateParameter("@BillingTypeID", SqlDbType.Int, 4, "BillingTypeID"),
      DefaultDatabase.CreateParameter("@Downpayment", SqlDbType.Bit, 1, "Downpayment")
    });
    this.dvNonDownpay.RowFilter = "Downpayment = 0";
    this.dvNonDownpay.Sort = "BillingType";
    this.dvNonDownpay.Table = (DataTable) this.ds.tblCompanyBillingTypes;
    this.TableLayoutPanel1.ColumnCount = 1;
    this.TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
    this.TableLayoutPanel1.Controls.Add((Control) this.ugNonDownpay, 0, 1);
    this.TableLayoutPanel1.Controls.Add((Control) this.ugDownpay, 0, 3);
    this.TableLayoutPanel1.Controls.Add((Control) this.Label1, 0, 0);
    this.TableLayoutPanel1.Controls.Add((Control) this.Label2, 0, 2);
    this.TableLayoutPanel1.Location = new Point(6, 6);
    this.TableLayoutPanel1.Name = "TableLayoutPanel1";
    this.TableLayoutPanel1.RowCount = 4;
    this.TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 16f));
    this.TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50f));
    this.TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 32f));
    this.TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50f));
    this.TableLayoutPanel1.Size = new Size(260, 292);
    this.TableLayoutPanel1.TabIndex = 5;
    ((Control) this.ugNonDownpay).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraGridBase) this.ugNonDownpay).DataSource = (object) this.dvNonDownpay;
    appearance2.BackColor = Color.White;
    appearance2.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.ugNonDownpay).DisplayLayout.Appearance = (AppearanceBase) appearance2;
    ((UltraGridBase) this.ugNonDownpay).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridBand1.ColHeadersVisible = false;
    ultraGridColumn1.Header.VisiblePosition = 2;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn1.Width = 24;
    ultraGridColumn2.CellActivation = (Activation) 1;
    ultraGridColumn2.Header.VisiblePosition = 1;
    ultraGridColumn2.Hidden = true;
    ultraGridColumn2.Style = (ColumnStyle) 39;
    ultraGridColumn2.Width = 148;
    ultraGridColumn3.Header.VisiblePosition = 3;
    ultraGridColumn3.Hidden = true;
    ultraGridColumn3.Width = 100;
    ultraGridColumn4.Header.VisiblePosition = 4;
    ultraGridColumn4.Hidden = true;
    ultraGridColumn4.Width = 36;
    ultraGridColumn5.Header.VisiblePosition = 0;
    ultraGridColumn5.Width = 21;
    ultraGridColumn6.Header.VisiblePosition = 5;
    ultraGridColumn6.Hidden = true;
    ultraGridColumn6.Width = 37;
    ultraGridColumn7.Header.VisiblePosition = 6;
    ultraGridColumn7.Width = 231;
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
    ((UltraGridBase) this.ugNonDownpay).DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    ((UltraGridBase) this.ugNonDownpay).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance3.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance3.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance3.ForeColor = Color.Black;
    ((UltraGridBase) this.ugNonDownpay).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance3;
    ((UltraGridBase) this.ugNonDownpay).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.ugNonDownpay).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.ugNonDownpay).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 1;
    appearance4.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugNonDownpay).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance4;
    appearance5.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.ugNonDownpay).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance5;
    ((UltraGridBase) this.ugNonDownpay).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance6.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.ugNonDownpay).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance6;
    appearance7.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugNonDownpay).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance7;
    ((UltraGridBase) this.ugNonDownpay).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance8.BackColor = Color.Transparent;
    appearance8.ForeColor = Color.Black;
    ((UltraGridBase) this.ugNonDownpay).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance8;
    appearance9.BackColor = Color.WhiteSmoke;
    appearance9.BorderColor = Color.Silver;
    scrollBarLook1.ButtonAppearance = (AppearanceBase) appearance9;
    appearance10.BackColor = Color.White;
    scrollBarLook1.TrackAppearance = (AppearanceBase) appearance10;
    ((UltraGridBase) this.ugNonDownpay).DisplayLayout.ScrollBarLook = scrollBarLook1;
    ((UltraGridBase) this.ugNonDownpay).DisplayLayout.ScrollBounds = (ScrollBounds) 0;
    ((Control) this.ugNonDownpay).Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.ugNonDownpay).Location = new Point(3, 19);
    ((Control) this.ugNonDownpay).Name = "ugNonDownpay";
    ((Control) this.ugNonDownpay).Size = new Size(254, 116);
    ((Control) this.ugNonDownpay).TabIndex = 9;
    ((UltraControlBase) this.ugNonDownpay).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.ugNonDownpay).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.ugDownpay).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraGridBase) this.ugDownpay).DataSource = (object) this.dvDownpay;
    appearance11.BackColor = Color.White;
    appearance11.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.ugDownpay).DisplayLayout.Appearance = (AppearanceBase) appearance11;
    ((UltraGridBase) this.ugDownpay).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridBand2.ColHeadersVisible = false;
    ultraGridColumn8.Header.VisiblePosition = 2;
    ultraGridColumn8.Hidden = true;
    ultraGridColumn8.Width = 24;
    ultraGridColumn9.CellActivation = (Activation) 1;
    ultraGridColumn9.Header.VisiblePosition = 1;
    ultraGridColumn9.Hidden = true;
    ultraGridColumn9.Style = (ColumnStyle) 39;
    ultraGridColumn9.Width = 148;
    ultraGridColumn10.Header.VisiblePosition = 3;
    ultraGridColumn10.Hidden = true;
    ultraGridColumn10.Width = 100;
    ultraGridColumn11.Header.VisiblePosition = 4;
    ultraGridColumn11.Hidden = true;
    ultraGridColumn11.Width = 36;
    ultraGridColumn12.Header.VisiblePosition = 0;
    ultraGridColumn12.Width = 21;
    ultraGridColumn13.Header.VisiblePosition = 5;
    ultraGridColumn13.Hidden = true;
    ultraGridColumn13.Width = 37;
    ultraGridColumn14.Header.VisiblePosition = 6;
    ultraGridColumn14.Width = 231;
    ultraGridBand2.Columns.AddRange(new object[7]
    {
      (object) ultraGridColumn8,
      (object) ultraGridColumn9,
      (object) ultraGridColumn10,
      (object) ultraGridColumn11,
      (object) ultraGridColumn12,
      (object) ultraGridColumn13,
      (object) ultraGridColumn14
    });
    ultraGridBand2.Override.AllowUpdate = (DefaultableBoolean) 1;
    ((UltraGridBase) this.ugDownpay).DisplayLayout.BandsSerializer.Add((object) ultraGridBand2);
    ((UltraGridBase) this.ugDownpay).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance12.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance12.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance12.ForeColor = Color.Black;
    ((UltraGridBase) this.ugDownpay).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance12;
    ((UltraGridBase) this.ugDownpay).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.ugDownpay).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.ugDownpay).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 1;
    appearance13.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugDownpay).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance13;
    appearance14.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.ugDownpay).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance14;
    ((UltraGridBase) this.ugDownpay).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance15.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.ugDownpay).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance15;
    appearance16.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugDownpay).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance16;
    ((UltraGridBase) this.ugDownpay).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance17.BackColor = Color.Transparent;
    appearance17.ForeColor = Color.Black;
    ((UltraGridBase) this.ugDownpay).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance17;
    appearance18.BackColor = Color.WhiteSmoke;
    appearance18.BorderColor = Color.Silver;
    scrollBarLook2.ButtonAppearance = (AppearanceBase) appearance18;
    appearance19.BackColor = Color.White;
    scrollBarLook2.TrackAppearance = (AppearanceBase) appearance19;
    ((UltraGridBase) this.ugDownpay).DisplayLayout.ScrollBarLook = scrollBarLook2;
    ((UltraGridBase) this.ugDownpay).DisplayLayout.ScrollBounds = (ScrollBounds) 0;
    ((Control) this.ugDownpay).Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.ugDownpay).Location = new Point(3, 173);
    ((Control) this.ugDownpay).Name = "ugDownpay";
    ((Control) this.ugDownpay).Size = new Size(254, 116);
    ((Control) this.ugDownpay).TabIndex = 8;
    ((UltraControlBase) this.ugDownpay).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.ugDownpay).UseOsThemes = (DefaultableBoolean) 2;
    this.dvDownpay.RowFilter = "Downpayment = 1";
    this.dvDownpay.Sort = "BillingType";
    this.dvDownpay.Table = (DataTable) this.ds.tblCompanyBillingTypes;
    this.AcceptButton = (IButtonControl) this.btnSave;
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.FromArgb(250, 250, 250);
    this.CancelButton = (IButtonControl) this.btnSave;
    this.ClientSize = new Size(272, 344);
    this.Controls.Add((Control) this.TableLayoutPanel1);
    this.Controls.Add((Control) this.btnSave);
    this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.ForeColor = Color.Black;
    this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
    this.Name = nameof (frmAdminAvailableBillingTypes);
    this.Text = "Available Billing Types";
    this.ds.EndInit();
    ((ISupportInitialize) this.btnSave).EndInit();
    this.dvNonDownpay.EndInit();
    this.TableLayoutPanel1.ResumeLayout(false);
    this.TableLayoutPanel1.PerformLayout();
    ((ISupportInitialize) this.ugNonDownpay).EndInit();
    ((ISupportInitialize) this.ugDownpay).EndInit();
    this.dvDownpay.EndInit();
    this.ResumeLayout(false);
  }

  public frmAdminAvailableBillingTypes(Guid companyLineGuid)
  {
    this.Load += new EventHandler(this.frmAdminAvailableBillingTypes_Load);
    this._hasChanges = false;
    this._billingDictionary = new Dictionary<int, string>();
    this.InitializeComponent();
    this._companyLineGuid = companyLineGuid;
  }

  private void frmAdminAvailableBillingTypes_Load(object sender, EventArgs e)
  {
    ((ControlBase) this.btnSave).Appearance.Image = (object) ImageCache.Instance.Save;
    this.daCompanyBilling.SelectCommand.Parameters["@companyLineGuid"].Value = (object) this._companyLineGuid;
    this.daCompanyBilling.TableMappings["Table"].DataSetTable = this.ds.lstBillingTypes.TableName;
    this.daCompanyBilling.TableMappings["Table1"].DataSetTable = this.ds.tblCompanyBillingTypes.TableName;
    try
    {
      DefaultDatabase.DataAdapterFill(this.daCompanyBilling, (DataSet) this.ds);
    }
    catch (ConstraintException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      ErrorHandler.ShowDataSetErrors((DataSet) this.ds, ex);
      ProjectData.ClearProjectError();
    }
    DataTable dataTable = DefaultDatabase.ExecuteDataTable("[dbo].[spGetBillingTypesList]");
    try
    {
      foreach (DataRow row in dataTable.Rows)
        this._billingDictionary.Add(Conversions.ToInteger(row["BillingTypeId"]), row["BillingCode"].ToString());
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private void btnSave_Click(object sender, EventArgs e)
  {
    try
    {
      foreach (dsAvailableBillingTypes.tblCompanyBillingTypesRow companyBillingType in (TypedTableBase<dsAvailableBillingTypes.tblCompanyBillingTypesRow>) this.ds.tblCompanyBillingTypes)
      {
        if (companyBillingType.IsIDNull() && !companyBillingType.Selected || !companyBillingType.IsIDNull() && companyBillingType.Selected)
          companyBillingType.RejectChanges();
        else if (!companyBillingType.IsIDNull() && !companyBillingType.Selected)
          companyBillingType.Delete();
        else if (DefaultDatabase.ExecuteFunction<bool>("[dbo].[IsPartOfMultiCarrierLine]", new object[2]
        {
          (object) "@CompanyLineGuid",
          (object) this._companyLineGuid
        }))
        {
          int integer = Conversions.ToInteger(companyBillingType["BillingTypeID"]);
          string empty = string.Empty;
          if (this._billingDictionary.TryGetValue(integer, out empty) && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(empty, "DBCOM", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(empty, "DPCOM", false) == 0)
          {
            companyBillingType.RejectChanges();
            string str = companyBillingType["BillingType"].ToString();
            int num = (int) MessageBox.Show($"{$"{str} is not supported for multi-carrier lines"}\n\n{$"Selection of {str} was not saved"}", "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
          }
        }
      }
    }
    finally
    {
      IEnumerator<dsAvailableBillingTypes.tblCompanyBillingTypesRow> enumerator;
      enumerator?.Dispose();
    }
    try
    {
      DefaultDatabase.DataAdapterUpdate(this.daCompanyBilling, (DataTable) this.ds.tblCompanyBillingTypes);
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      if (MessageBox.Show("There was an error saving billing types!\nDo you want to try again?", "Save Error", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.Yes)
      {
        ProjectData.ClearProjectError();
        return;
      }
      ProjectData.ClearProjectError();
    }
    this.Close();
  }

  private void RefreshQuoteEditForm()
  {
    Messaging.SendBroadcastMessage(BroadcastMessages.CompanyBillingTypesUpdated, (object) this._companyLineGuid);
  }

  private void UltraGridCellChange(object sender, CellEventArgs e)
  {
    if (!(e.Cell.Column.DataType == typeof (bool)))
      return;
    ((UltraGrid) sender).PerformAction((UltraGridAction) 44);
    if (!(e.Cell.Row.ListObject is DataRowView listObject) || !(listObject.Row is dsAvailableBillingTypes.tblCompanyBillingTypesRow row) || row.CheckedInUse)
      return;
    if (DefaultDatabase.ExecuteScalar<bool>("spBillingTypeInUse", new object[2]
    {
      (object) "@companyBillingTypeID",
      (object) row.ID
    }) && MessageBox.Show("This billing type is currently being used for installment billing automation for this company.\n\nIf you remove this billing type, all automation settings will also be removed.\n\nWould you like to continue?", "Billing Type In Use", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.Yes)
      return;
    row.CheckedInUse = true;
  }
}
