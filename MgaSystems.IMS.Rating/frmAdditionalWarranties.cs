// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Rating.frmAdditionalWarranties
// Assembly: MgaSystems.IMS.Rating, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 370B8F0A-FA1A-41D0-87BD-563CC23E9EA7
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Rating.dll

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
namespace MGASystems.IMS.Policies.Rating;

public class frmAdditionalWarranties : Form
{
  private IContainer components;
  private SqlConnection cn;
  private SqlDataAdapter da;
  private dsAdditionalWarranties ds;
  private SqlCommand SqlSelectCommand1;
  private SqlCommand SqlInsertCommand1;
  private SqlCommand SqlUpdateCommand1;
  private SqlCommand SqlDeleteCommand1;
  private readonly int _quoteID;

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

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
    UltraGridBand ultraGridBand = new UltraGridBand("tblAdditionalWarranties", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("AdditionalWarrantyID");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("QuoteID");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("Warranty");
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmAdditionalWarranties));
    this.UltraGrid1 = new UltraGrid();
    this.ds = new dsAdditionalWarranties();
    this.cn = new SqlConnection();
    this.da = new SqlDataAdapter();
    this.SqlDeleteCommand1 = new SqlCommand();
    this.SqlInsertCommand1 = new SqlCommand();
    this.SqlSelectCommand1 = new SqlCommand();
    this.SqlUpdateCommand1 = new SqlCommand();
    ((ISupportInitialize) this.UltraGrid1).BeginInit();
    this.ds.BeginInit();
    this.SuspendLayout();
    ((UltraGridBase) this.UltraGrid1).DataSource = (object) this.ds.tblAdditionalWarranties;
    appearance1.BackColor = Color.WhiteSmoke;
    ((SpecialBoxBase) ((UltraGridBase) this.UltraGrid1).DisplayLayout.AddNewBox).Appearance = (AppearanceBase) appearance1;
    appearance2.BackColor = Color.WhiteSmoke;
    appearance2.BorderColor = Color.WhiteSmoke;
    appearance2.FontData.UnderlineAsString = "True";
    appearance2.ForeColor = Color.Blue;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.AddNewBox.ButtonAppearance = (AppearanceBase) appearance2;
    ((SpecialBoxBase) ((UltraGridBase) this.UltraGrid1).DisplayLayout.AddNewBox).Hidden = false;
    ((SpecialBoxBase) ((UltraGridBase) this.UltraGrid1).DisplayLayout.AddNewBox).Prompt = " ";
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.AddNewBox.Style = (AddNewBoxStyle) 1;
    appearance3.BackColor = Color.White;
    appearance3.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Appearance = (AppearanceBase) appearance3;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridBand.AddButtonCaption = "Click here to add a new warranty";
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn1.Width = 245;
    ultraGridColumn2.Header.VisiblePosition = 1;
    ultraGridColumn2.Hidden = true;
    ultraGridColumn2.Width = 114;
    ultraGridColumn3.Header.VisiblePosition = 2;
    ultraGridColumn3.Width = 536;
    ultraGridBand.Columns.AddRange(new object[3]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3
    });
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.BandsSerializer.Add((object) ultraGridBand);
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance4.BackColor = Color.LightSteelBlue;
    appearance4.FontData.SizeInPoints = 10f;
    appearance4.ForeColor = Color.Black;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance4;
    appearance5.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance5.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance5.ForeColor = Color.Black;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance5;
    appearance6.BorderColor = Color.LightGray;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance6;
    appearance7.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance7;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance8.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance8;
    appearance9.BorderColor = Color.LightGray;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance9;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 1;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Override.RowSelectorStyle = (HeaderStyle) 2;
    appearance10.BackColor = Color.Transparent;
    appearance10.ForeColor = Color.Black;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance10;
    scrollBarLook.ViewStyle = (ScrollBarViewStyle) 3;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((Control) this.UltraGrid1).Dock = DockStyle.Fill;
    ((Control) this.UltraGrid1).Location = new Point(0, 0);
    ((Control) this.UltraGrid1).Name = "UltraGrid1";
    ((Control) this.UltraGrid1).Size = new Size(557, 351);
    ((Control) this.UltraGrid1).TabIndex = 0;
    ((UltraControlBase) this.UltraGrid1).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.UltraGrid1).UseOsThemes = (DefaultableBoolean) 2;
    this.ds.DataSetName = "dsAdditionalWarranties";
    this.ds.Locale = new CultureInfo("en-US");
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.cn.ConnectionString = "workstation id=PSARNOWSKI;packet size=4096;integrated security=SSPI;data source=MGASYSTEMS;persist security info=False;initial catalog=IMS";
    this.cn.FireInfoMessageEventOnUserErrors = false;
    this.da.DeleteCommand = this.SqlDeleteCommand1;
    this.da.InsertCommand = this.SqlInsertCommand1;
    this.da.SelectCommand = this.SqlSelectCommand1;
    this.da.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblAdditionalWarranties", new DataColumnMapping[3]
      {
        new DataColumnMapping("AdditionalWarrantyID", "AdditionalWarrantyID"),
        new DataColumnMapping("QuoteID", "QuoteID"),
        new DataColumnMapping("Warranty", "Warranty")
      })
    });
    this.da.UpdateCommand = this.SqlUpdateCommand1;
    this.SqlDeleteCommand1.CommandText = "DELETE FROM tblAdditionalWarranties WHERE (AdditionalWarrantyID = @Original_AdditionalWarrantyID)";
    this.SqlDeleteCommand1.Connection = this.cn;
    this.SqlDeleteCommand1.Parameters.AddRange(new SqlParameter[1]
    {
      new SqlParameter("@Original_AdditionalWarrantyID", SqlDbType.Int, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "AdditionalWarrantyID", DataRowVersion.Original, (object) null)
    });
    this.SqlInsertCommand1.CommandText = componentResourceManager.GetString("SqlInsertCommand1.CommandText");
    this.SqlInsertCommand1.Connection = this.cn;
    this.SqlInsertCommand1.Parameters.AddRange(new SqlParameter[2]
    {
      new SqlParameter("@QuoteID", SqlDbType.Int, 4, "QuoteID"),
      new SqlParameter("@Warranty", SqlDbType.VarChar, 500, "Warranty")
    });
    this.SqlSelectCommand1.CommandText = "SELECT AdditionalWarrantyID, QuoteID, Warranty FROM tblAdditionalWarranties WHERE (QuoteID = @QuoteID)";
    this.SqlSelectCommand1.Connection = this.cn;
    this.SqlSelectCommand1.Parameters.AddRange(new SqlParameter[1]
    {
      new SqlParameter("@QuoteID", SqlDbType.Int, 4, "QuoteID")
    });
    this.SqlUpdateCommand1.CommandText = componentResourceManager.GetString("SqlUpdateCommand1.CommandText");
    this.SqlUpdateCommand1.Connection = this.cn;
    this.SqlUpdateCommand1.Parameters.AddRange(new SqlParameter[4]
    {
      new SqlParameter("@QuoteID", SqlDbType.Int, 4, "QuoteID"),
      new SqlParameter("@Warranty", SqlDbType.VarChar, 500, "Warranty"),
      new SqlParameter("@Original_AdditionalWarrantyID", SqlDbType.Int, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "AdditionalWarrantyID", DataRowVersion.Original, (object) null),
      new SqlParameter("@AdditionalWarrantyID", SqlDbType.Int, 4, "AdditionalWarrantyID")
    });
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.White;
    this.ClientSize = new Size(557, 351);
    this.Controls.Add((Control) this.UltraGrid1);
    this.Font = new Font("Tahoma", 8.25f);
    this.ForeColor = Color.Black;
    this.Name = nameof (frmAdditionalWarranties);
    this.Text = "Additional Warranties";
    ((ISupportInitialize) this.UltraGrid1).EndInit();
    this.ds.EndInit();
    this.ResumeLayout(false);
  }

  public frmAdditionalWarranties(int quoteID)
  {
    this.Closing += new CancelEventHandler(this.frmAdditionalWarranties_Closing);
    this.InitializeComponent();
    this._quoteID = quoteID;
    this.cn.ConnectionString = CurrentUser.Instance.ConnectionString;
    this.da.SelectCommand.Parameters["@QuoteID"].Value = (object) this._quoteID;
    DefaultDatabase.DataAdapterFill((DbDataAdapter) this.da, (DataTable) this.ds.tblAdditionalWarranties);
  }

  private void frmAdditionalWarranties_Closing(object sender, CancelEventArgs e)
  {
    try
    {
      this.Cursor = MgaCursors.WaitCursor;
      ((UltraGridBase) this.UltraGrid1).UpdateData();
      DefaultDatabase.DataAdapterUpdate((DbDataAdapter) this.da, (DataTable) this.ds.tblAdditionalWarranties);
    }
    finally
    {
      this.Cursor = MgaCursors.Default;
    }
  }

  private void UltraGrid1_AfterRowInsert(object sender, RowEventArgs e)
  {
    e.Row.Cells["QuoteID"].Value = (object) this._quoteID;
  }

  private void UltraGrid1_BeforeRowUpdate(object sender, CancelableRowEventArgs e)
  {
    if (e.Row.Cells["Warranty"].Value != DBNull.Value && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(e.Row.Cells["Warranty"].Value.ToString(), string.Empty, false) != 0)
      return;
    ((CancelEventArgs) e).Cancel = true;
  }
}
