// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.Companies.frmCompanyProducerInfo
// Assembly: MgaSystems.IMS.IPC, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: F22CEF02-8C0F-420D-8344-A8A010CA7834
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.IPC.dll

using Infragistics.Win;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using MGASystems.Common;
using MGASystems.Data;
using System;
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
namespace MGASystems.IMS.InsuredsProducersCompanies.Companies;

public sealed class frmCompanyProducerInfo : Form
{
  private IContainer components;
  private SqlDataAdapter daCompanyProducer;
  private SqlCommand SqlSelectCommand1;
  private SqlCommand SqlInsertCommand1;
  private SqlCommand SqlUpdateCommand1;
  private SqlCommand SqlDeleteCommand1;
  private dsCompanyProducerInfo ds;
  private UltraDropDown UltraDropDown1;
  private readonly int _companyID;
  private readonly SqlConnection _cn;

  private virtual UltraGrid UltraGrid1
  {
    get => this._UltraGrid1;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      RowEventHandler rowEventHandler = new RowEventHandler(this.UltraGrid1_AfterRowInsert);
      CancelableRowEventHandler cancelableRowEventHandler = new CancelableRowEventHandler(this.UltraGrid1_BeforeRowUpdate);
      UltraGrid ultraGrid1_1 = this._UltraGrid1;
      if (ultraGrid1_1 != null)
      {
        ultraGrid1_1.AfterRowInsert -= rowEventHandler;
        ultraGrid1_1.BeforeRowUpdate -= cancelableRowEventHandler;
      }
      this._UltraGrid1 = value;
      UltraGrid ultraGrid1_2 = this._UltraGrid1;
      if (ultraGrid1_2 == null)
        return;
      ultraGrid1_2.AfterRowInsert += rowEventHandler;
      ultraGrid1_2.BeforeRowUpdate += cancelableRowEventHandler;
    }
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    UltraGridBand ultraGridBand1 = new UltraGridBand("tblCompanyProducerInfo", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("CompanyID");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("ProducerLocationID", -1, (object) "UltraDropDown1");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("BranchCode");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("ProducerCode");
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmCompanyProducerInfo));
    Appearance appearance11 = new Appearance();
    UltraGridBand ultraGridBand2 = new UltraGridBand("tblProducerLocations", -1);
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("ProducerLocationID");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("Name");
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("tblProducerLocationstblCompanyProducerInfo");
    UltraGridBand ultraGridBand3 = new UltraGridBand("tblProducerLocationstblCompanyProducerInfo", 0);
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("CompanyID");
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("ProducerLocationID");
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("BranchCode");
    UltraGridColumn ultraGridColumn11 = new UltraGridColumn("ProducerCode");
    this.UltraGrid1 = new UltraGrid();
    this.ds = new dsCompanyProducerInfo();
    this.daCompanyProducer = new SqlDataAdapter();
    this.SqlDeleteCommand1 = new SqlCommand();
    this.SqlInsertCommand1 = new SqlCommand();
    this.SqlSelectCommand1 = new SqlCommand();
    this.SqlUpdateCommand1 = new SqlCommand();
    this.UltraDropDown1 = new UltraDropDown();
    ((ISupportInitialize) this.UltraGrid1).BeginInit();
    this.ds.BeginInit();
    ((ISupportInitialize) this.UltraDropDown1).BeginInit();
    this.SuspendLayout();
    ((UltraGridBase) this.UltraGrid1).DataSource = (object) this.ds.tblCompanyProducerInfo;
    appearance1.BackColor = Color.WhiteSmoke;
    appearance1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((SpecialBoxBase) ((UltraGridBase) this.UltraGrid1).DisplayLayout.AddNewBox).Appearance = (AppearanceBase) appearance1;
    appearance2.BackColor = Color.WhiteSmoke;
    appearance2.BorderColor = Color.WhiteSmoke;
    appearance2.FontData.UnderlineAsString = "True";
    appearance2.ForeColor = Color.Blue;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.AddNewBox.ButtonAppearance = (AppearanceBase) appearance2;
    ((SpecialBoxBase) ((UltraGridBase) this.UltraGrid1).DisplayLayout.AddNewBox).Hidden = false;
    ((SpecialBoxBase) ((UltraGridBase) this.UltraGrid1).DisplayLayout.AddNewBox).Prompt = " ";
    appearance3.BackColor = Color.White;
    appearance3.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Appearance = (AppearanceBase) appearance3;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridBand1.AddButtonCaption = "Add new company/producer setup...";
    ((HeaderBase) ultraGridColumn1.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn1.Width = 112 /*0x70*/;
    ((HeaderBase) ultraGridColumn2.Header).Caption = "Producer";
    ((HeaderBase) ultraGridColumn2.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn2.Header.VisiblePosition = 1;
    ultraGridColumn2.Style = (ColumnStyle) 6;
    ultraGridColumn2.Width = 208 /*0xD0*/;
    ((HeaderBase) ultraGridColumn3.Header).Caption = "Branch Code";
    ((HeaderBase) ultraGridColumn3.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn3.Header.VisiblePosition = 2;
    ultraGridColumn3.Width = 179;
    ((HeaderBase) ultraGridColumn4.Header).Caption = "Producer Code";
    ((HeaderBase) ultraGridColumn4.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn4.Header.VisiblePosition = 3;
    ultraGridColumn4.Width = 179;
    ultraGridBand1.Columns.AddRange(new object[4]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3,
      (object) ultraGridColumn4
    });
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance4.BackColor = Color.LightSteelBlue;
    appearance4.FontData.SizeInPoints = 10f;
    appearance4.ForeColor = Color.Black;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance4;
    appearance5.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance5.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance5.ForeColor = Color.Black;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance5;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    appearance6.BorderColor = Color.LightGray;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance6;
    appearance7.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance7;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance8.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance8;
    appearance9.BorderColor = Color.LightGray;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance9;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance10.BackColor = Color.Transparent;
    appearance10.ForeColor = Color.Black;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance10;
    scrollBarLook.ViewStyle = (ScrollBarViewStyle) 3;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((Control) this.UltraGrid1).Dock = DockStyle.Fill;
    ((Control) this.UltraGrid1).Location = new Point(0, 0);
    ((Control) this.UltraGrid1).Name = "UltraGrid1";
    ((Control) this.UltraGrid1).Size = new Size(568, 294);
    ((Control) this.UltraGrid1).TabIndex = 0;
    ((UltraControlBase) this.UltraGrid1).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.UltraGrid1).UseOsThemes = (DefaultableBoolean) 2;
    this.ds.DataSetName = "dsCompanyProducerInfo";
    this.ds.Locale = new CultureInfo("en-US");
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.daCompanyProducer.DeleteCommand = this.SqlDeleteCommand1;
    this.daCompanyProducer.InsertCommand = this.SqlInsertCommand1;
    this.daCompanyProducer.SelectCommand = this.SqlSelectCommand1;
    this.daCompanyProducer.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblCompanyProducerInfo", new DataColumnMapping[4]
      {
        new DataColumnMapping("CompanyID", "CompanyID"),
        new DataColumnMapping("ProducerLocationID", "ProducerLocationID"),
        new DataColumnMapping("BranchCode", "BranchCode"),
        new DataColumnMapping("ProducerCode", "ProducerCode")
      })
    });
    this.daCompanyProducer.UpdateCommand = this.SqlUpdateCommand1;
    this.SqlDeleteCommand1.CommandText = componentResourceManager.GetString("SqlDeleteCommand1.CommandText");
    this.SqlDeleteCommand1.Parameters.AddRange(new SqlParameter[4]
    {
      new SqlParameter("@Original_CompanyID", SqlDbType.Int, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "CompanyID", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_ProducerLocationID", SqlDbType.Int, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "ProducerLocationID", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_BranchCode", SqlDbType.VarChar, 10, ParameterDirection.Input, false, (byte) 0, (byte) 0, "BranchCode", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_ProducerCode", SqlDbType.VarChar, 10, ParameterDirection.Input, false, (byte) 0, (byte) 0, "ProducerCode", DataRowVersion.Original, (object) null)
    });
    this.SqlInsertCommand1.CommandText = componentResourceManager.GetString("SqlInsertCommand1.CommandText");
    this.SqlInsertCommand1.Parameters.AddRange(new SqlParameter[4]
    {
      new SqlParameter("@CompanyID", SqlDbType.Int, 4, "CompanyID"),
      new SqlParameter("@ProducerLocationID", SqlDbType.Int, 4, "ProducerLocationID"),
      new SqlParameter("@BranchCode", SqlDbType.VarChar, 10, "BranchCode"),
      new SqlParameter("@ProducerCode", SqlDbType.VarChar, 10, "ProducerCode")
    });
    this.SqlSelectCommand1.CommandText = "SELECT CompanyID, ProducerLocationID, BranchCode, ProducerCode FROM tblCompanyProducerInfo WHERE (CompanyID = @companyID)";
    this.SqlSelectCommand1.Parameters.AddRange(new SqlParameter[1]
    {
      new SqlParameter("@companyID", SqlDbType.Int, 4, "CompanyID")
    });
    this.SqlUpdateCommand1.CommandText = componentResourceManager.GetString("SqlUpdateCommand1.CommandText");
    this.SqlUpdateCommand1.Parameters.AddRange(new SqlParameter[8]
    {
      new SqlParameter("@CompanyID", SqlDbType.Int, 4, "CompanyID"),
      new SqlParameter("@ProducerLocationID", SqlDbType.Int, 4, "ProducerLocationID"),
      new SqlParameter("@BranchCode", SqlDbType.VarChar, 10, "BranchCode"),
      new SqlParameter("@ProducerCode", SqlDbType.VarChar, 10, "ProducerCode"),
      new SqlParameter("@Original_CompanyID", SqlDbType.Int, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "CompanyID", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_ProducerLocationID", SqlDbType.Int, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "ProducerLocationID", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_BranchCode", SqlDbType.VarChar, 10, ParameterDirection.Input, false, (byte) 0, (byte) 0, "BranchCode", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_ProducerCode", SqlDbType.VarChar, 10, ParameterDirection.Input, false, (byte) 0, (byte) 0, "ProducerCode", DataRowVersion.Original, (object) null)
    });
    ((UltraGridBase) this.UltraDropDown1).DataSource = (object) this.ds.tblProducerLocations;
    appearance11.BackColor = Color.White;
    appearance11.BorderColor = Color.Gray;
    ((UltraGridBase) this.UltraDropDown1).DisplayLayout.Appearance = (AppearanceBase) appearance11;
    ultraGridBand2.ColHeadersVisible = false;
    ((HeaderBase) ultraGridColumn5.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn5.Header.VisiblePosition = 0;
    ultraGridColumn5.Hidden = true;
    ((HeaderBase) ultraGridColumn6.Header).Caption = "Producer";
    ((HeaderBase) ultraGridColumn6.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn6.Header.VisiblePosition = 1;
    ultraGridColumn6.Width = 422;
    ((HeaderBase) ultraGridColumn7.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn7.Header.VisiblePosition = 2;
    ultraGridBand2.Columns.AddRange(new object[3]
    {
      (object) ultraGridColumn5,
      (object) ultraGridColumn6,
      (object) ultraGridColumn7
    });
    ultraGridBand2.Override.BorderStyleCell = (UIElementBorderStyle) 1;
    ultraGridBand2.Override.BorderStyleRow = (UIElementBorderStyle) 1;
    ((HeaderBase) ultraGridColumn8.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn8.Header.VisiblePosition = 0;
    ((HeaderBase) ultraGridColumn9.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn9.Header.VisiblePosition = 1;
    ((HeaderBase) ultraGridColumn10.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn10.Header.VisiblePosition = 2;
    ((HeaderBase) ultraGridColumn11.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn11.Header.VisiblePosition = 3;
    ultraGridBand3.Columns.AddRange(new object[4]
    {
      (object) ultraGridColumn8,
      (object) ultraGridColumn9,
      (object) ultraGridColumn10,
      (object) ultraGridColumn11
    });
    ((UltraGridBase) this.UltraDropDown1).DisplayLayout.BandsSerializer.Add((object) ultraGridBand2);
    ((UltraGridBase) this.UltraDropDown1).DisplayLayout.BandsSerializer.Add((object) ultraGridBand3);
    ((UltraDropDownBase) this.UltraDropDown1).DisplayMember = "Name";
    ((Control) this.UltraDropDown1).Location = new Point(32 /*0x20*/, 152);
    ((Control) this.UltraDropDown1).Name = "UltraDropDown1";
    ((Control) this.UltraDropDown1).Size = new Size(424, 80 /*0x50*/);
    ((Control) this.UltraDropDown1).TabIndex = 1;
    ((UltraControlBase) this.UltraDropDown1).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.UltraDropDown1).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.UltraDropDown1).ValueMember = "ProducerLocationID";
    ((Control) this.UltraDropDown1).Visible = false;
    this.AutoScaleBaseSize = new Size(5, 14);
    this.ClientSize = new Size(568, 294);
    this.Controls.Add((Control) this.UltraDropDown1);
    this.Controls.Add((Control) this.UltraGrid1);
    this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Name = nameof (frmCompanyProducerInfo);
    this.Text = "Company Producer Info";
    ((ISupportInitialize) this.UltraGrid1).EndInit();
    this.ds.EndInit();
    ((ISupportInitialize) this.UltraDropDown1).EndInit();
    this.ResumeLayout(false);
  }

  public frmCompanyProducerInfo(int companyID)
  {
    this.Load += new EventHandler(this.frmCompanyProducerInfo_Load);
    this.Closed += new EventHandler(this.frmCompanyProducerInfo_Closed);
    this.InitializeComponent();
    this._companyID = companyID;
    this._cn = DefaultDatabase.CreateConnection();
  }

  private void frmCompanyProducerInfo_Load(object sender, EventArgs e)
  {
    DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[1]
    {
      "tblProducerLocations"
    }, "[GetCompanyProducerData]", new object[2]
    {
      (object) "@companyID",
      (object) this._companyID
    });
    SqlDataAdapter daCompanyProducer = this.daCompanyProducer;
    daCompanyProducer.SelectCommand.Connection = this._cn;
    daCompanyProducer.InsertCommand.Connection = this._cn;
    daCompanyProducer.DeleteCommand.Connection = this._cn;
    daCompanyProducer.UpdateCommand.Connection = this._cn;
    this.daCompanyProducer.SelectCommand.Parameters["@companyID"].Value = (object) this._companyID;
    DefaultDatabase.DataAdapterFill((DbDataAdapter) this.daCompanyProducer, (DataTable) this.ds.tblCompanyProducerInfo);
  }

  private void UltraGrid1_AfterRowInsert(object sender, RowEventArgs e)
  {
    e.Row.Cells["CompanyID"].Value = (object) this._companyID;
  }

  private void UltraGrid1_BeforeRowUpdate(object sender, CancelableRowEventArgs e)
  {
    if (e.Row.Cells["BranchCode"].Value != DBNull.Value || e.Row.Cells["ProducerCode"].Value != DBNull.Value)
      return;
    ((CancelEventArgs) e).Cancel = true;
  }

  private void frmCompanyProducerInfo_Closed(object sender, EventArgs e)
  {
    this.UltraGrid1.PerformAction((UltraGridAction) 44);
    if (((UltraGridBase) this.UltraGrid1).ActiveRow != null)
      ((UltraGridBase) this.UltraGrid1).ActiveRow.Update();
    ((UltraGridBase) this.UltraGrid1).UpdateData();
    try
    {
      Cursor.Current = MgaCursors.WaitCursor;
      DefaultDatabase.DataAdapterUpdate((DbDataAdapter) this.daCompanyProducer, (DataTable) this.ds.tblCompanyProducerInfo);
    }
    finally
    {
      Cursor.Current = MgaCursors.Default;
    }
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing)
    {
      if (this.components != null)
        this.components.Dispose();
      if (this._cn != null)
        this._cn.Dispose();
    }
    base.Dispose(disposing);
  }
}
