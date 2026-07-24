// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Forms.frmClientLocAltNum
// Assembly: MgaSystems.IMS.Forms, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FB3F392E-40B6-486F-8F0B-A4A494A546D4
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Forms.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinMaskedEdit;
using Infragistics.Win.UltraWinScrollBar;
using MGASystems.Common.Functions;
using MGASystems.Data;
using MGASystems.Tools;
using MGASystems.Tools.DBSaveUI;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Forms;

public class frmClientLocAltNum : Form
{
  private IContainer components;
  private readonly Guid _officeGuid;

  public frmClientLocAltNum()
  {
    this.Load += new EventHandler(this.frmClientLocAltNum_Load);
    this.InitializeComponent();
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  [field: AccessedThroughProperty("SqlDeleteCommand1")]
  internal virtual SqlCommand SqlDeleteCommand1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlInsertCommand1")]
  internal virtual SqlCommand SqlInsertCommand1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlSelectCommand1")]
  internal virtual SqlCommand SqlSelectCommand1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlUpdateCommand1")]
  internal virtual SqlCommand SqlUpdateCommand1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("da")]
  internal virtual SqlDataAdapter da { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual UltraGrid ugAltNum
  {
    get => this._ugAltNum;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ugAltNum_AfterRowActivate);
      UltraGrid ugAltNum1 = this._ugAltNum;
      if (ugAltNum1 != null)
        ugAltNum1.AfterRowActivate -= eventHandler;
      this._ugAltNum = value;
      UltraGrid ugAltNum2 = this._ugAltNum;
      if (ugAltNum2 == null)
        return;
      ugAltNum2.AfterRowActivate += eventHandler;
    }
  }

  [field: AccessedThroughProperty("MgaGroupBox1")]
  internal virtual MGAGroupBox MgaGroupBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtPhone")]
  private virtual MGAMaskedEdit txtPhone { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label3")]
  internal virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label1")]
  internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ds")]
  internal virtual dsClientLocAltNum ds { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("err")]
  internal virtual ErrorProvider err { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtAltFax")]
  internal virtual MGAMaskedEdit txtAltFax { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual MGASystems.Tools.DBSaveUI.DBSaveUI dbSave
  {
    get => this._dbSave;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      CancelEventHandler cancelEventHandler1 = new CancelEventHandler(this.dbSave_ClickingNew);
      CancelEventHandler cancelEventHandler2 = new CancelEventHandler(this.dbSave_ClickingSave);
      CancelEventHandler cancelEventHandler3 = new CancelEventHandler(this.dbSave_ClickingCancel);
      CancelEventHandler cancelEventHandler4 = new CancelEventHandler(this.dbSave_ClickingDelete);
      EventHandler eventHandler = new EventHandler(this.dbSave_UIStateChanged);
      MGASystems.Tools.DBSaveUI.DBSaveUI dbSave1 = this._dbSave;
      if (dbSave1 != null)
      {
        dbSave1.ClickingNew -= cancelEventHandler1;
        dbSave1.ClickingSave -= cancelEventHandler2;
        dbSave1.ClickingCancel -= cancelEventHandler3;
        dbSave1.ClickingDelete -= cancelEventHandler4;
        dbSave1.UIStateChanged -= eventHandler;
      }
      this._dbSave = value;
      MGASystems.Tools.DBSaveUI.DBSaveUI dbSave2 = this._dbSave;
      if (dbSave2 == null)
        return;
      dbSave2.ClickingNew += cancelEventHandler1;
      dbSave2.ClickingSave += cancelEventHandler2;
      dbSave2.ClickingCancel += cancelEventHandler3;
      dbSave2.ClickingDelete += cancelEventHandler4;
      dbSave2.UIStateChanged += eventHandler;
    }
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmClientLocAltNum));
    Appearance appearance1 = new Appearance();
    UltraGridBand ultraGridBand = new UltraGridBand("tblClientNum", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("NumberID");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("AltPhone");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("AltFax");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("OfficeGUID");
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    Appearance appearance11 = new Appearance();
    Appearance appearance12 = new Appearance();
    Appearance appearance13 = new Appearance();
    Appearance appearance14 = new Appearance();
    this.da = new SqlDataAdapter();
    this.SqlDeleteCommand1 = new SqlCommand();
    this.SqlInsertCommand1 = new SqlCommand();
    this.SqlSelectCommand1 = new SqlCommand();
    this.SqlUpdateCommand1 = new SqlCommand();
    this.ugAltNum = new UltraGrid();
    this.ds = new dsClientLocAltNum();
    this.MgaGroupBox1 = new MGAGroupBox();
    this.Label1 = new Label();
    this.Label3 = new Label();
    this.txtAltFax = new MGAMaskedEdit();
    this.txtPhone = new MGAMaskedEdit();
    this.dbSave = new MGASystems.Tools.DBSaveUI.DBSaveUI();
    this.err = new ErrorProvider(this.components);
    ((ISupportInitialize) this.ugAltNum).BeginInit();
    this.ds.BeginInit();
    ((ISupportInitialize) this.MgaGroupBox1).BeginInit();
    ((Control) this.MgaGroupBox1).SuspendLayout();
    ((ISupportInitialize) this.txtAltFax).BeginInit();
    ((ISupportInitialize) this.txtPhone).BeginInit();
    ((ISupportInitialize) this.err).BeginInit();
    this.SuspendLayout();
    this.da.DeleteCommand = this.SqlDeleteCommand1;
    this.da.InsertCommand = this.SqlInsertCommand1;
    this.da.SelectCommand = this.SqlSelectCommand1;
    this.da.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblClientOffices", new DataColumnMapping[18]
      {
        new DataColumnMapping("OfficeGUID", "OfficeGUID"),
        new DataColumnMapping("Location", "Location"),
        new DataColumnMapping("Address1", "Address1"),
        new DataColumnMapping("Address2", "Address2"),
        new DataColumnMapping("City", "City"),
        new DataColumnMapping("County", "County"),
        new DataColumnMapping("State", "State"),
        new DataColumnMapping("Phone", "Phone"),
        new DataColumnMapping("Fax", "Fax"),
        new DataColumnMapping("FEIN", "FEIN"),
        new DataColumnMapping("ZipCode", "ZipCode"),
        new DataColumnMapping("ZipPlus", "ZipPlus"),
        new DataColumnMapping("StatusID", "StatusID"),
        new DataColumnMapping("NextInvoiceNum", "NextInvoiceNum"),
        new DataColumnMapping("AccountingOffice", "AccountingOffice"),
        new DataColumnMapping("Region", "Region"),
        new DataColumnMapping("ISOCountryCode", "ISOCountryCode"),
        new DataColumnMapping("ParentOfficeGuid", "ParentOfficeGuid")
      })
    });
    this.da.UpdateCommand = this.SqlUpdateCommand1;
    this.SqlInsertCommand1.CommandText = componentResourceManager.GetString("SqlInsertCommand1.CommandText");
    this.SqlInsertCommand1.Parameters.AddRange(new SqlParameter[3]
    {
      new SqlParameter("@OfficeGUID", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "OfficeGUID"),
      new SqlParameter("@AltPhone", SqlDbType.VarChar, 14, "AltPhone"),
      new SqlParameter("@AltFax", SqlDbType.VarChar, 14, "AltFax")
    });
    this.SqlSelectCommand1.CommandText = "SELECT AltPhone, AltFax, OfficeGUID, NumberID FROM dbo.tblClientOfficesAlternateNumbers WHERE (OfficeGUID = @OfficeGuid)";
    this.SqlSelectCommand1.Parameters.AddRange(new SqlParameter[1]
    {
      new SqlParameter("@OfficeGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "OfficeGUID")
    });
    this.SqlUpdateCommand1.CommandText = componentResourceManager.GetString("SqlUpdateCommand1.CommandText");
    this.SqlUpdateCommand1.Parameters.AddRange(new SqlParameter[5]
    {
      new SqlParameter("@OfficeGUID", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "OfficeGUID"),
      new SqlParameter("@AltPhone", SqlDbType.VarChar, 14, "AltPhone"),
      new SqlParameter("@AltFax", SqlDbType.VarChar, 14, "AltFax"),
      new SqlParameter("@Original_NumberID", SqlDbType.Int, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "NumberID", DataRowVersion.Original, (object) null),
      new SqlParameter("@NumberID", SqlDbType.Int, 4, "NumberID")
    });
    ((UltraGridBase) this.ugAltNum).DataSource = (object) this.ds.tblClientNum;
    appearance1.BackColor = Color.White;
    appearance1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.ugAltNum).DisplayLayout.Appearance = (AppearanceBase) appearance1;
    ((UltraGridBase) this.ugAltNum).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ((HeaderBase) ultraGridColumn1.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ((HeaderBase) ultraGridColumn2.Header).Caption = "Phone";
    ((HeaderBase) ultraGridColumn2.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn2.Header.VisiblePosition = 1;
    ultraGridColumn2.Width = 147;
    ((HeaderBase) ultraGridColumn3.Header).Caption = "Fax";
    ((HeaderBase) ultraGridColumn3.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn3.Header.VisiblePosition = 2;
    ultraGridColumn3.Width = 171;
    ((HeaderBase) ultraGridColumn4.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn4.Header.VisiblePosition = 3;
    ultraGridColumn4.Hidden = true;
    ultraGridBand.Columns.AddRange(new object[4]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3,
      (object) ultraGridColumn4
    });
    ((UltraGridBase) this.ugAltNum).DisplayLayout.BandsSerializer.Add((object) ultraGridBand);
    ((UltraGridBase) this.ugAltNum).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance2.BackColor = Color.LightSteelBlue;
    appearance2.FontData.SizeInPoints = 10f;
    appearance2.ForeColor = Color.Black;
    ((UltraGridBase) this.ugAltNum).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance2;
    appearance3.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance3.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance3.ForeColor = Color.Black;
    ((UltraGridBase) this.ugAltNum).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance3;
    ((UltraGridBase) this.ugAltNum).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.ugAltNum).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.ugAltNum).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    appearance4.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugAltNum).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance4;
    appearance5.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.ugAltNum).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance5;
    ((UltraGridBase) this.ugAltNum).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance6.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.ugAltNum).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance6;
    appearance7.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugAltNum).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance7;
    ((UltraGridBase) this.ugAltNum).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance8.BackColor = Color.Transparent;
    appearance8.ForeColor = Color.Black;
    ((UltraGridBase) this.ugAltNum).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance8;
    appearance9.BackColor = Color.WhiteSmoke;
    appearance9.BorderColor = Color.Silver;
    scrollBarLook.ButtonAppearance = (AppearanceBase) appearance9;
    appearance10.BackColor = Color.White;
    scrollBarLook.TrackAppearance = (AppearanceBase) appearance10;
    ((UltraGridBase) this.ugAltNum).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((Control) this.ugAltNum).Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.ugAltNum).Location = new Point(8, 8);
    ((Control) this.ugAltNum).Name = "ugAltNum";
    ((Control) this.ugAltNum).Size = new Size(320, 136);
    ((Control) this.ugAltNum).TabIndex = 0;
    ((Control) this.ugAltNum).Text = "Alternate Office Phone Numbers";
    ((UltraControlBase) this.ugAltNum).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.ugAltNum).UseOsThemes = (DefaultableBoolean) 2;
    this.ds.DataSetName = "dsClientLocAltNum";
    this.ds.Locale = new CultureInfo("en-US");
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    appearance11.BackColor = Color.FromArgb(239, 247, 253);
    appearance11.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.MgaGroupBox1.ContentAreaAppearance = (AppearanceBase) appearance11;
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.Label1);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.Label3);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.txtAltFax);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.txtPhone);
    appearance12.AlphaLevel = (short) 230;
    appearance12.FontData.SizeInPoints = 10f;
    appearance12.ForeColor = Color.White;
    appearance12.ForegroundAlpha = (Alpha) 2;
    appearance12.ImageAlpha = (Alpha) 2;
    appearance12.ImageBackground = (Image) componentResourceManager.GetObject("Appearance14.ImageBackground");
    appearance12.ImageBackgroundStyle = (ImageBackgroundStyle) 3;
    this.MgaGroupBox1.HeaderAppearance = (AppearanceBase) appearance12;
    ((Control) this.MgaGroupBox1).Location = new Point(8, 152);
    ((Control) this.MgaGroupBox1).Name = "MgaGroupBox1";
    ((Control) this.MgaGroupBox1).Size = new Size(320, 96 /*0x60*/);
    ((Control) this.MgaGroupBox1).TabIndex = 11;
    this.MgaGroupBox1.Text = "Alternate Phone / Fax ";
    this.MgaGroupBox1.ViewStyle = (GroupBoxViewStyle) 2;
    this.Label1.AutoSize = true;
    this.Label1.BackColor = Color.FromArgb(239, 247, 253);
    this.Label1.Location = new Point(32 /*0x20*/, 64 /*0x40*/);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(77, 13);
    this.Label1.TabIndex = 13;
    this.Label1.Text = "Alternate Fax:";
    this.Label1.TextAlign = ContentAlignment.MiddleRight;
    this.Label3.AutoSize = true;
    this.Label3.BackColor = Color.FromArgb(239, 247, 253);
    this.Label3.Location = new Point(24, 40);
    this.Label3.Name = "Label3";
    this.Label3.Size = new Size(89, 13);
    this.Label3.TabIndex = 12;
    this.Label3.Text = "Alternate Phone:";
    this.Label3.TextAlign = ContentAlignment.MiddleRight;
    appearance13.BorderColor = Color.Gray;
    this.txtAltFax.Appearance = (AppearanceBase) appearance13;
    ((Control) this.txtAltFax).DataBindings.Add(new Binding("Value", (object) this.ds, "tblClientNum.AltFax", true));
    this.txtAltFax.EditAs = (EditAsType) 1;
    this.txtAltFax.InputMask = "###-###-####";
    ((Control) this.txtAltFax).Location = new Point(120, 64 /*0x40*/);
    ((Control) this.txtAltFax).Name = "txtAltFax";
    this.txtAltFax.NonAutoSizeHeight = 20;
    ((Control) this.txtAltFax).Size = new Size(80 /*0x50*/, 21);
    ((Control) this.txtAltFax).TabIndex = 9;
    this.txtAltFax.TabNavigation = (MaskedEditTabNavigation) 0;
    this.txtAltFax.Text = "--";
    ((UltraControlBase) this.txtAltFax).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtAltFax).UseOsThemes = (DefaultableBoolean) 2;
    appearance14.BorderColor = Color.Gray;
    this.txtPhone.Appearance = (AppearanceBase) appearance14;
    ((Control) this.txtPhone).DataBindings.Add(new Binding("Value", (object) this.ds, "tblClientNum.AltPhone", true));
    this.txtPhone.EditAs = (EditAsType) 1;
    this.txtPhone.InputMask = "###-###-####";
    ((Control) this.txtPhone).Location = new Point(120, 40);
    ((Control) this.txtPhone).Name = "txtPhone";
    this.txtPhone.NonAutoSizeHeight = 20;
    ((Control) this.txtPhone).Size = new Size(80 /*0x50*/, 21);
    ((Control) this.txtPhone).TabIndex = 8;
    this.txtPhone.TabNavigation = (MaskedEditTabNavigation) 0;
    this.txtPhone.Text = "--";
    ((UltraControlBase) this.txtPhone).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtPhone).UseOsThemes = (DefaultableBoolean) 2;
    this.dbSave.EditStyle = EditStyle.ShowEditButton;
    this.dbSave.FreezeEvents = false;
    this.dbSave.Location = new Point(216, 264);
    this.dbSave.Name = "dbSave";
    this.dbSave.Size = new Size(112 /*0x70*/, 40);
    this.dbSave.TabIndex = 20;
    this.dbSave.UIState = UIState.HasRecordsNotEditing;
    this.err.ContainerControl = (ContainerControl) this;
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.White;
    this.ClientSize = new Size(336, 318);
    this.Controls.Add((Control) this.MgaGroupBox1);
    this.Controls.Add((Control) this.ugAltNum);
    this.Controls.Add((Control) this.dbSave);
    this.Font = new Font("Tahoma", 8.25f);
    this.ForeColor = Color.Black;
    this.Name = nameof (frmClientLocAltNum);
    this.Text = "Office Location - Alternate Numbers";
    ((ISupportInitialize) this.ugAltNum).EndInit();
    this.ds.EndInit();
    ((ISupportInitialize) this.MgaGroupBox1).EndInit();
    ((Control) this.MgaGroupBox1).ResumeLayout(false);
    ((Control) this.MgaGroupBox1).PerformLayout();
    ((ISupportInitialize) this.txtAltFax).EndInit();
    ((ISupportInitialize) this.txtPhone).EndInit();
    ((ISupportInitialize) this.err).EndInit();
    this.ResumeLayout(false);
  }

  [field: AccessedThroughProperty("bmb")]
  private virtual BindingManagerBase bmb { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  public frmClientLocAltNum(Guid officeGuid)
  {
    this.Load += new EventHandler(this.frmClientLocAltNum_Load);
    this.InitializeComponent();
    this._officeGuid = officeGuid;
  }

  private void frmClientLocAltNum_Load(object sender, EventArgs e)
  {
    this.bmb = this.BindingContext[(object) this.ds, this.ds.tblClientNum.TableName];
    SqlDataAdapter da = this.da;
    if (da.SelectCommand == null)
      da.SelectCommand = new SqlCommand();
    if (da.DeleteCommand == null)
      da.DeleteCommand = new SqlCommand();
    if (da.UpdateCommand == null)
      da.UpdateCommand = new SqlCommand();
    if (da.InsertCommand == null)
      da.InsertCommand = new SqlCommand();
    Utility.SetDataAdapterConnections((DbDataAdapter) this.da, (DbConnection) DefaultDatabase.CreateConnection(), (DbTransaction) null);
    this.ReloadTable();
    if (this.ds.tblClientNum.Count == 0)
      this.dbSave.UIState = UIState.NoRecordsNotEditing;
    else
      this.dbSave.UIState = UIState.HasRecordsNotEditing;
  }

  private void ReloadTable()
  {
    this.ds.tblClientNum.Clear();
    this.da.SelectCommand.Parameters["@OfficeGuid"].Value = (object) this._officeGuid;
    DefaultDatabase.DataAdapterFill((DbDataAdapter) this.da, (DataTable) this.ds.tblClientNum);
  }

  private void ReloadSaveUI()
  {
    if (this.ds.tblClientNum.Count == 0 || this.bmb.Position == -1)
      this.dbSave.UIState = UIState.NoRecordsNotEditing;
    else
      this.dbSave.UIState = UIState.HasRecordsNotEditing;
  }

  private bool ValidForm()
  {
    bool flag = true;
    if (this.txtPhone.Value == DBNull.Value && this.txtAltFax.Value == DBNull.Value)
    {
      this.err.SetError((Control) this.txtPhone, "At least one field required");
      this.err.SetError((Control) this.txtAltFax, "At least one field required");
      flag = false;
    }
    else
    {
      this.err.SetError((Control) this.txtPhone, string.Empty);
      this.err.SetError((Control) this.txtAltFax, string.Empty);
    }
    return flag;
  }

  private void dbSave_ClickingNew(object sender, CancelEventArgs e)
  {
    this.txtAltFax.Value = (object) null;
    this.txtPhone.Value = (object) null;
    this.txtAltFax.Text = string.Empty;
    this.txtPhone.Text = string.Empty;
    dsClientLocAltNum.tblClientNumRow row = this.ds.tblClientNum.NewtblClientNumRow();
    row.OfficeGUID = this._officeGuid;
    this.ds.tblClientNum.AddtblClientNumRow(row);
    this.bmb.Position = this.ds.tblClientNum.Count - 1;
  }

  private void dbSave_ClickingSave(object sender, CancelEventArgs e)
  {
    this.bmb.EndCurrentEdit();
    if (this.ValidForm())
    {
      if (this.txtPhone.Value == DBNull.Value)
        this.ds.tblClientNum[this.bmb.Position].SetAltPhoneNull();
      else
        this.ds.tblClientNum[this.bmb.Position].AltPhone = Conversions.ToString(this.txtPhone.Value);
      if (this.txtAltFax.Value == DBNull.Value)
        this.ds.tblClientNum[this.bmb.Position].SetAltFaxNull();
      else
        this.ds.tblClientNum[this.bmb.Position].AltFax = Conversions.ToString(this.txtAltFax.Value);
      DefaultDatabase.DataAdapterUpdate((DbDataAdapter) this.da, (DataTable) this.ds.tblClientNum);
      this.ReloadTable();
    }
    else
      e.Cancel = true;
  }

  private void dbSave_ClickingCancel(object sender, CancelEventArgs e)
  {
    this.ds.tblClientNum.RejectChanges();
    e.Cancel = true;
    this.ReloadTable();
    this.ReloadSaveUI();
  }

  private void dbSave_ClickingDelete(object sender, CancelEventArgs e)
  {
    if (((UltraGridBase) this.ugAltNum).ActiveRow == null)
      return;
    DefaultDatabase.ExecuteNonQuery(CommandType.Text, "DELETE FROM dbo.tblClientOfficesAlternateNumbers WHERE NumberID = @numID", new object[2]
    {
      (object) "@numID",
      (object) (int) ((UltraGridBase) this.ugAltNum).ActiveRow.Cells["NumberID"].Value
    });
    this.ReloadTable();
    this.ReloadSaveUI();
  }

  private void dbSave_UIStateChanged(object sender, EventArgs e)
  {
    try
    {
      foreach (Control control in ((Control) this.MgaGroupBox1).Controls)
      {
        if (control is MGAMaskedEdit)
          control.Enabled = this.dbSave.UIState == UIState.Editing;
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private void ugAltNum_AfterRowActivate(object sender, EventArgs e)
  {
    if (this.bmb.Position < 0 || ((UltraGridBase) this.ugAltNum).ActiveRow == null)
      return;
    Database.MoveTo((object) (int) ((UltraGridBase) this.ugAltNum).ActiveRow.Cells["NumberID"].Value, this.ds.tblClientNum.NumberIDColumn.ColumnName, (DataTable) this.ds.tblClientNum, this.bmb);
    if (((UltraGridBase) this.ugAltNum).ActiveRow.Cells["AltFax"].Value != DBNull.Value)
      this.txtAltFax.Value = (object) (string) ((UltraGridBase) this.ugAltNum).ActiveRow.Cells["AltFax"].Value;
    if (((UltraGridBase) this.ugAltNum).ActiveRow.Cells["AltPhone"].Value == DBNull.Value)
      return;
    this.txtPhone.Value = (object) (string) ((UltraGridBase) this.ugAltNum).ActiveRow.Cells["AltPhone"].Value;
  }
}
