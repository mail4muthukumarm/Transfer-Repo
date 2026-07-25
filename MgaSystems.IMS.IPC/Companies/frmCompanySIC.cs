// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.Companies.frmCompanySIC
// Assembly: MgaSystems.IMS.IPC, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: F22CEF02-8C0F-420D-8344-A8A010CA7834
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.IPC.dll

using Infragistics.Win;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using MGASystems.Common;
using MGASystems.Common.ErrorHandling;
using MGASystems.Data;
using Microsoft.VisualBasic.CompilerServices;
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

public class frmCompanySIC : Form
{
  private IContainer components;
  private SqlDataAdapter daCompanySIC;
  private SqlCommand SqlSelectCommand1;
  private SqlCommand SqlInsertCommand1;
  private SqlCommand SqlUpdateCommand1;
  private SqlCommand SqlDeleteCommand1;
  private SqlConnection cn;
  private Label Label1;
  private dsCompanySIC ds;
  private UltraDropDown ddAccess;
  private UltraDropDown UltraDropDown2;
  private Guid _companyLineGuid;

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private virtual UltraGrid ugSic
  {
    get => this._ugSic;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      RowEventHandler rowEventHandler = new RowEventHandler(this.ugSic_AfterRowInsert);
      CancelableRowEventHandler cancelableRowEventHandler = new CancelableRowEventHandler(this.ugSic_BeforeRowUpdate);
      UltraGrid ugSic1 = this._ugSic;
      if (ugSic1 != null)
      {
        ugSic1.AfterRowInsert -= rowEventHandler;
        ugSic1.BeforeRowUpdate -= cancelableRowEventHandler;
      }
      this._ugSic = value;
      UltraGrid ugSic2 = this._ugSic;
      if (ugSic2 == null)
        return;
      ugSic2.AfterRowInsert += rowEventHandler;
      ugSic2.BeforeRowUpdate += cancelableRowEventHandler;
    }
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    UltraGridBand ultraGridBand1 = new UltraGridBand("tblCompany_SIC", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("CompanyLineGuid");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("SIC_Code", -1, (object) "UltraDropDown2");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("Access", -1, (object) "ddAccess");
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    ScrollBarLook scrollBarLook1 = new ScrollBarLook();
    Appearance appearance6 = new Appearance();
    UltraGridBand ultraGridBand2 = new UltraGridBand("lstAccess", -1);
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("Access");
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("AccessDescription");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("lstAccesstblCompany_SIC");
    UltraGridBand ultraGridBand3 = new UltraGridBand("lstAccesstblCompany_SIC", 0);
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("CompanyLineGuid");
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("SIC_Code");
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("Access");
    ScrollBarLook scrollBarLook2 = new ScrollBarLook();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    UltraGridBand ultraGridBand4 = new UltraGridBand("lstSIC_Codes", -1);
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("SIC_Code");
    UltraGridColumn ultraGridColumn11 = new UltraGridColumn("SIC_Family_Description");
    UltraGridColumn ultraGridColumn12 = new UltraGridColumn("SIC_Description");
    UltraGridColumn ultraGridColumn13 = new UltraGridColumn("lstSIC_CodestblCompany_SIC");
    UltraGridBand ultraGridBand5 = new UltraGridBand("lstSIC_CodestblCompany_SIC", 0);
    UltraGridColumn ultraGridColumn14 = new UltraGridColumn("CompanyLineGuid");
    UltraGridColumn ultraGridColumn15 = new UltraGridColumn("SIC_Code");
    UltraGridColumn ultraGridColumn16 = new UltraGridColumn("Access");
    ScrollBarLook scrollBarLook3 = new ScrollBarLook();
    Appearance appearance10 = new Appearance();
    Appearance appearance11 = new Appearance();
    this.ugSic = new UltraGrid();
    this.ds = new dsCompanySIC();
    this.daCompanySIC = new SqlDataAdapter();
    this.SqlDeleteCommand1 = new SqlCommand();
    this.cn = new SqlConnection();
    this.SqlInsertCommand1 = new SqlCommand();
    this.SqlSelectCommand1 = new SqlCommand();
    this.SqlUpdateCommand1 = new SqlCommand();
    this.Label1 = new Label();
    this.ddAccess = new UltraDropDown();
    this.UltraDropDown2 = new UltraDropDown();
    ((ISupportInitialize) this.ugSic).BeginInit();
    this.ds.BeginInit();
    ((ISupportInitialize) this.ddAccess).BeginInit();
    ((ISupportInitialize) this.UltraDropDown2).BeginInit();
    this.SuspendLayout();
    ((Control) this.ugSic).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraGridBase) this.ugSic).DataSource = (object) this.ds.tblCompany_SIC;
    appearance1.BackColor = Color.WhiteSmoke;
    ((SpecialBoxBase) ((UltraGridBase) this.ugSic).DisplayLayout.AddNewBox).Appearance = (AppearanceBase) appearance1;
    appearance2.BackColor = Color.WhiteSmoke;
    appearance2.BorderColor = Color.WhiteSmoke;
    appearance2.FontData.UnderlineAsString = "True";
    appearance2.ForeColor = Color.Blue;
    ((UltraGridBase) this.ugSic).DisplayLayout.AddNewBox.ButtonAppearance = (AppearanceBase) appearance2;
    ((SpecialBoxBase) ((UltraGridBase) this.ugSic).DisplayLayout.AddNewBox).Hidden = false;
    appearance3.BackColor = Color.White;
    appearance3.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugSic).DisplayLayout.Appearance = (AppearanceBase) appearance3;
    ultraGridBand1.AddButtonCaption = "New SIC Code";
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ((HeaderBase) ultraGridColumn2.Header).Caption = "SIC Code";
    ultraGridColumn2.Header.VisiblePosition = 1;
    ultraGridColumn2.Style = (ColumnStyle) 6;
    ultraGridColumn2.Width = 237;
    ultraGridColumn3.Header.VisiblePosition = 2;
    ultraGridColumn3.Style = (ColumnStyle) 6;
    ultraGridColumn3.Width = 238;
    ultraGridBand1.Columns.AddRange(new object[3]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3
    });
    ((UltraGridBase) this.ugSic).DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    appearance4.BackColor = Color.Gainsboro;
    appearance4.BackColor2 = Color.White;
    appearance4.BackGradientStyle = (GradientStyle) 2;
    ((UltraGridBase) this.ugSic).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance4;
    appearance5.BackColor = Color.WhiteSmoke;
    ((UltraGridBase) this.ugSic).DisplayLayout.Override.RowSelectorAppearance = (AppearanceBase) appearance5;
    scrollBarLook1.ViewStyle = (ScrollBarViewStyle) 3;
    ((UltraGridBase) this.ugSic).DisplayLayout.ScrollBarLook = scrollBarLook1;
    ((Control) this.ugSic).Location = new Point(8, 48 /*0x30*/);
    ((Control) this.ugSic).Name = "ugSic";
    ((Control) this.ugSic).Size = new Size(497, 304);
    ((Control) this.ugSic).TabIndex = 0;
    ((UltraControlBase) this.ugSic).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.ugSic).UseOsThemes = (DefaultableBoolean) 2;
    this.ds.DataSetName = "dsCompanySIC";
    this.ds.Locale = new CultureInfo("en-US");
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.daCompanySIC.DeleteCommand = this.SqlDeleteCommand1;
    this.daCompanySIC.InsertCommand = this.SqlInsertCommand1;
    this.daCompanySIC.SelectCommand = this.SqlSelectCommand1;
    this.daCompanySIC.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblCompany_SIC", new DataColumnMapping[3]
      {
        new DataColumnMapping("CompanyLineGuid", "CompanyLineGuid"),
        new DataColumnMapping("SIC_Code", "SIC_Code"),
        new DataColumnMapping("Access", "Access")
      })
    });
    this.daCompanySIC.UpdateCommand = this.SqlUpdateCommand1;
    this.SqlDeleteCommand1.CommandText = "DELETE FROM tblCompany_SIC WHERE (CompanyLineGuid = @Original_CompanyLineGuid) AND (SIC_Code = @Original_SIC_Code)";
    this.SqlDeleteCommand1.Connection = this.cn;
    this.SqlDeleteCommand1.Parameters.AddRange(new SqlParameter[2]
    {
      new SqlParameter("@Original_CompanyLineGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, ParameterDirection.Input, false, (byte) 0, (byte) 0, "CompanyLineGuid", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_SIC_Code", SqlDbType.VarChar, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "SIC_Code", DataRowVersion.Original, (object) null)
    });
    this.cn.ConnectionString = "workstation id=PSARNOWSKI2;packet size=4096;integrated security=SSPI;data source=MGASYSTEMS;persist security info=False;initial catalog=IMS";
    this.cn.FireInfoMessageEventOnUserErrors = false;
    this.SqlInsertCommand1.CommandText = "INSERT INTO tblCompany_SIC(CompanyLineGuid, SIC_Code, Access) VALUES (@CompanyLineGuid, @SIC_Code, @Access)";
    this.SqlInsertCommand1.Connection = this.cn;
    this.SqlInsertCommand1.Parameters.AddRange(new SqlParameter[3]
    {
      new SqlParameter("@CompanyLineGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "CompanyLineGuid"),
      new SqlParameter("@SIC_Code", SqlDbType.VarChar, 4, "SIC_Code"),
      new SqlParameter("@Access", SqlDbType.VarChar, 1, "Access")
    });
    this.SqlSelectCommand1.CommandText = "SELECT CompanyLineGuid, SIC_Code, Access FROM tblCompany_SIC";
    this.SqlSelectCommand1.Connection = this.cn;
    this.SqlUpdateCommand1.CommandText = "UPDATE tblCompany_SIC SET CompanyLineGuid = @CompanyLineGuid, SIC_Code = @SIC_Code, Access = @Access WHERE (CompanyLineGuid = @Original_CompanyLineGuid) AND (SIC_Code = @Original_SIC_Code)";
    this.SqlUpdateCommand1.Connection = this.cn;
    this.SqlUpdateCommand1.Parameters.AddRange(new SqlParameter[5]
    {
      new SqlParameter("@CompanyLineGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "CompanyLineGuid"),
      new SqlParameter("@SIC_Code", SqlDbType.VarChar, 4, "SIC_Code"),
      new SqlParameter("@Access", SqlDbType.VarChar, 1, "Access"),
      new SqlParameter("@Original_CompanyLineGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, ParameterDirection.Input, false, (byte) 0, (byte) 0, "CompanyLineGuid", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_SIC_Code", SqlDbType.VarChar, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "SIC_Code", DataRowVersion.Original, (object) null)
    });
    this.Label1.Location = new Point(8, 8);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(496, 32 /*0x20*/);
    this.Label1.TabIndex = 1;
    this.Label1.Text = "All SIC codes are available by default.  This screen is used to mark certain SIC codes as restricted or prohibited.";
    ((UltraGridBase) this.ddAccess).DataSource = (object) this.ds.lstAccess;
    appearance6.BackColor = Color.White;
    appearance6.BorderColor = Color.Silver;
    appearance6.ForeColor = Color.Black;
    ((UltraGridBase) this.ddAccess).DisplayLayout.Appearance = (AppearanceBase) appearance6;
    ultraGridBand2.ColHeadersVisible = false;
    ultraGridColumn4.Header.VisiblePosition = 0;
    ultraGridColumn4.Hidden = true;
    ultraGridColumn5.Header.VisiblePosition = 1;
    ultraGridColumn5.Width = 250;
    ultraGridColumn6.Header.VisiblePosition = 2;
    ultraGridBand2.Columns.AddRange(new object[3]
    {
      (object) ultraGridColumn4,
      (object) ultraGridColumn5,
      (object) ultraGridColumn6
    });
    ultraGridColumn7.Header.VisiblePosition = 0;
    ultraGridColumn8.Header.VisiblePosition = 1;
    ultraGridColumn9.Header.VisiblePosition = 2;
    ultraGridBand3.Columns.AddRange(new object[3]
    {
      (object) ultraGridColumn7,
      (object) ultraGridColumn8,
      (object) ultraGridColumn9
    });
    ((UltraGridBase) this.ddAccess).DisplayLayout.BandsSerializer.Add((object) ultraGridBand2);
    ((UltraGridBase) this.ddAccess).DisplayLayout.BandsSerializer.Add((object) ultraGridBand3);
    ((UltraGridBase) this.ddAccess).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.ddAccess).DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.ddAccess).DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 1;
    appearance7.BackColor = Color.WhiteSmoke;
    appearance7.BorderColor = Color.Silver;
    scrollBarLook2.ButtonAppearance = (AppearanceBase) appearance7;
    appearance8.BackColor = Color.White;
    appearance8.BorderColor = Color.Silver;
    scrollBarLook2.TrackAppearance = (AppearanceBase) appearance8;
    ((UltraGridBase) this.ddAccess).DisplayLayout.ScrollBarLook = scrollBarLook2;
    ((UltraDropDownBase) this.ddAccess).DisplayMember = "AccessDescription";
    ((Control) this.ddAccess).Location = new Point(24, 136);
    ((Control) this.ddAccess).Name = "ddAccess";
    ((Control) this.ddAccess).Size = new Size(216, 50);
    ((Control) this.ddAccess).TabIndex = 2;
    ((UltraControlBase) this.ddAccess).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.ddAccess).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.ddAccess).ValueMember = "Access";
    ((Control) this.ddAccess).Visible = false;
    ((UltraGridBase) this.UltraDropDown2).DataSource = (object) this.ds.lstSIC_Codes;
    appearance9.BackColor = Color.White;
    appearance9.BorderColor = Color.Silver;
    appearance9.ForeColor = Color.Black;
    ((UltraGridBase) this.UltraDropDown2).DisplayLayout.Appearance = (AppearanceBase) appearance9;
    ultraGridBand4.ColHeadersVisible = false;
    ultraGridColumn10.Header.VisiblePosition = 0;
    ultraGridColumn11.Header.VisiblePosition = 1;
    ultraGridColumn12.Header.VisiblePosition = 2;
    ultraGridColumn13.Header.VisiblePosition = 3;
    ultraGridBand4.Columns.AddRange(new object[4]
    {
      (object) ultraGridColumn10,
      (object) ultraGridColumn11,
      (object) ultraGridColumn12,
      (object) ultraGridColumn13
    });
    ultraGridColumn14.Header.VisiblePosition = 0;
    ultraGridColumn15.Header.VisiblePosition = 1;
    ultraGridColumn16.Header.VisiblePosition = 2;
    ultraGridBand5.Columns.AddRange(new object[3]
    {
      (object) ultraGridColumn14,
      (object) ultraGridColumn15,
      (object) ultraGridColumn16
    });
    ((UltraGridBase) this.UltraDropDown2).DisplayLayout.BandsSerializer.Add((object) ultraGridBand4);
    ((UltraGridBase) this.UltraDropDown2).DisplayLayout.BandsSerializer.Add((object) ultraGridBand5);
    ((UltraGridBase) this.UltraDropDown2).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.UltraDropDown2).DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.UltraDropDown2).DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 1;
    appearance10.BackColor = Color.WhiteSmoke;
    appearance10.BorderColor = Color.Silver;
    scrollBarLook3.ButtonAppearance = (AppearanceBase) appearance10;
    appearance11.BackColor = Color.White;
    appearance11.BorderColor = Color.Silver;
    scrollBarLook3.TrackAppearance = (AppearanceBase) appearance11;
    ((UltraGridBase) this.UltraDropDown2).DisplayLayout.ScrollBarLook = scrollBarLook3;
    ((Control) this.UltraDropDown2).Location = new Point(226, 150);
    ((Control) this.UltraDropDown2).Name = "UltraDropDown2";
    ((Control) this.UltraDropDown2).Size = new Size(272, 80 /*0x50*/);
    ((Control) this.UltraDropDown2).TabIndex = 3;
    ((Control) this.UltraDropDown2).Text = "UltraDropDown2";
    ((UltraControlBase) this.UltraDropDown2).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.UltraDropDown2).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.UltraDropDown2).Visible = false;
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.White;
    this.ClientSize = new Size(513, 357);
    this.Controls.Add((Control) this.UltraDropDown2);
    this.Controls.Add((Control) this.ddAccess);
    this.Controls.Add((Control) this.Label1);
    this.Controls.Add((Control) this.ugSic);
    this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.ForeColor = Color.Black;
    this.Name = nameof (frmCompanySIC);
    this.Text = "Company/Line SIC Codes";
    ((ISupportInitialize) this.ugSic).EndInit();
    this.ds.EndInit();
    ((ISupportInitialize) this.ddAccess).EndInit();
    ((ISupportInitialize) this.UltraDropDown2).EndInit();
    this.ResumeLayout(false);
  }

  public frmCompanySIC(Guid companyLineGuid)
  {
    this.Load += new EventHandler(this.frmCompanySIC_Load);
    this.Closing += new CancelEventHandler(this.frmCompanySIC_Closing);
    this.InitializeComponent();
    this._companyLineGuid = companyLineGuid;
  }

  private void frmCompanySIC_Load(object sender, EventArgs e)
  {
    this.cn.ConnectionString = CurrentUser.Instance.ConnectionString;
    DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[3]
    {
      "lstSIC_Codes",
      "lstAccess",
      "tblCompany_SIC"
    }, this.SicStoredProcedureOverride(), new object[2]
    {
      (object) "@CompanyLineGuid",
      (object) this._companyLineGuid
    });
  }

  protected virtual string SicStoredProcedureOverride() => "GetCompanySIC";

  private void frmCompanySIC_Closing(object sender, CancelEventArgs e)
  {
    this.ugSic.PerformAction((UltraGridAction) 44);
    if (((UltraGridBase) this.ugSic).ActiveRow != null)
      ((UltraGridBase) this.ugSic).ActiveRow.Update();
    ((UltraGridBase) this.ugSic).UpdateData();
    try
    {
      Cursor.Current = MgaCursors.WaitCursor;
      DefaultDatabase.DataAdapterUpdate((DbDataAdapter) this.daCompanySIC, (DataTable) this.ds.tblCompany_SIC);
    }
    catch (SqlException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      ErrorHandler.HandleError((Exception) ex);
      if (MessageBox.Show("An error has occured.\n\nWould you like to close the form anyway?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.No)
        e.Cancel = true;
      ProjectData.ClearProjectError();
    }
    finally
    {
      Cursor.Current = MgaCursors.Default;
    }
  }

  private void ugSic_AfterRowInsert(object sender, RowEventArgs e)
  {
    e.Row.Cells["CompanyLineGuid"].Value = (object) this._companyLineGuid;
  }

  private void ugSic_BeforeRowUpdate(object sender, CancelableRowEventArgs e)
  {
    if (e.Row.Cells[1].Value != DBNull.Value && e.Row.Cells[2].Value != DBNull.Value)
      return;
    ((CancelEventArgs) e).Cancel = true;
  }
}
