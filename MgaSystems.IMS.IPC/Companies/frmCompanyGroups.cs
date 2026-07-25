// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.Companies.frmCompanyGroups
// Assembly: MgaSystems.IMS.IPC, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: F22CEF02-8C0F-420D-8344-A8A010CA7834
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.IPC.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.Tools;
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

[SecureResource("{2511FCC6-2140-47a5-856E-C282891DAB4E}", "Access Company Group Screen", "Controls access to Company Group screen.", "Companies")]
public sealed class frmCompanyGroups : Form
{
  private IContainer components;
  private SqlDataAdapter daCompanyGroups;
  private SqlCommand SqlSelectCommand1;
  private SqlCommand SqlInsertCommand1;
  private SqlCommand SqlUpdateCommand1;
  private SqlCommand SqlDeleteCommand1;
  private SqlConnection cnSQL;
  private dsCompanies dsCompany;
  public const string canOpenCompGroupForm = "{2511FCC6-2140-47a5-856E-C282891DAB4E}";

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

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

  private virtual UltraGrid dgCompanyGroups
  {
    get => this._dgCompanyGroups;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      RowEventHandler rowEventHandler = new RowEventHandler(this.dgCompanyGroups_AfterRowInsert);
      UltraGrid dgCompanyGroups1 = this._dgCompanyGroups;
      if (dgCompanyGroups1 != null)
        dgCompanyGroups1.AfterRowInsert -= rowEventHandler;
      this._dgCompanyGroups = value;
      UltraGrid dgCompanyGroups2 = this._dgCompanyGroups;
      if (dgCompanyGroups2 == null)
        return;
      dgCompanyGroups2.AfterRowInsert += rowEventHandler;
    }
  }

  [field: AccessedThroughProperty("err")]
  internal virtual ErrorProvider err { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmCompanyGroups));
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    UltraGridBand ultraGridBand1 = new UltraGridBand("tblCompanyGroups", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("CompanyGroupID");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("CompanyGroupGuid");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("CompanyGroupName");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("tblCompanyGroupstblCompanies");
    UltraGridBand ultraGridBand2 = new UltraGridBand("tblCompanyGroupstblCompanies", 0);
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("CompanyID");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("CompanyGuid");
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("CompanyName");
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("CompanyGroupGuid");
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("Closed");
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("FSR");
    UltraGridColumn ultraGridColumn11 = new UltraGridColumn("FSC");
    UltraGridColumn ultraGridColumn12 = new UltraGridColumn("NAIC");
    UltraGridColumn ultraGridColumn13 = new UltraGridColumn("tblCompaniestblCompanyLocations");
    UltraGridBand ultraGridBand3 = new UltraGridBand("tblCompaniestblCompanyLocations", 1);
    UltraGridColumn ultraGridColumn14 = new UltraGridColumn("CompanyLocationCode");
    UltraGridColumn ultraGridColumn15 = new UltraGridColumn("CompanyLocationGuid");
    UltraGridColumn ultraGridColumn16 = new UltraGridColumn("CompanyGuid");
    UltraGridColumn ultraGridColumn17 = new UltraGridColumn("Address1");
    UltraGridColumn ultraGridColumn18 = new UltraGridColumn("Address2");
    UltraGridColumn ultraGridColumn19 = new UltraGridColumn("City");
    UltraGridColumn ultraGridColumn20 = new UltraGridColumn("County");
    UltraGridColumn ultraGridColumn21 = new UltraGridColumn("ZipPlus");
    UltraGridColumn ultraGridColumn22 = new UltraGridColumn("Phone");
    UltraGridColumn ultraGridColumn23 = new UltraGridColumn("Fax");
    UltraGridColumn ultraGridColumn24 = new UltraGridColumn("WebSite");
    UltraGridColumn ultraGridColumn25 = new UltraGridColumn("DeliveryMethodID");
    UltraGridColumn ultraGridColumn26 = new UltraGridColumn("DateAdded");
    UltraGridColumn ultraGridColumn27 = new UltraGridColumn("LocationTypeID");
    UltraGridColumn ultraGridColumn28 = new UltraGridColumn("StatusID");
    UltraGridColumn ultraGridColumn29 = new UltraGridColumn("IntermediaryGuid");
    UltraGridColumn ultraGridColumn30 = new UltraGridColumn("Hidden");
    UltraGridColumn ultraGridColumn31 = new UltraGridColumn("State");
    UltraGridColumn ultraGridColumn32 = new UltraGridColumn("ZipCode");
    UltraGridColumn ultraGridColumn33 = new UltraGridColumn("ClaimPhone");
    UltraGridColumn ultraGridColumn34 = new UltraGridColumn("ClaimFax");
    UltraGridColumn ultraGridColumn35 = new UltraGridColumn("LocationName");
    UltraGridColumn ultraGridColumn36 = new UltraGridColumn("ISOCountryCode");
    UltraGridColumn ultraGridColumn37 = new UltraGridColumn("Region");
    UltraGridColumn ultraGridColumn38 = new UltraGridColumn("Email");
    UltraGridColumn ultraGridColumn39 = new UltraGridColumn("LocationCode");
    UltraGridColumn ultraGridColumn40 = new UltraGridColumn("tblCompanyLocationstblCompanyContacts");
    UltraGridBand ultraGridBand4 = new UltraGridBand("tblCompanyLocationstblCompanyContacts", 2);
    UltraGridColumn ultraGridColumn41 = new UltraGridColumn("CompanyContactGuid");
    UltraGridColumn ultraGridColumn42 = new UltraGridColumn("CompanyLocationGuid");
    UltraGridColumn ultraGridColumn43 = new UltraGridColumn("Name");
    UltraGridColumn ultraGridColumn44 = new UltraGridColumn("StatusID");
    UltraGridColumn ultraGridColumn45 = new UltraGridColumn("FromIntermediary");
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    Appearance appearance11 = new Appearance();
    this.dsCompany = new dsCompanies();
    this.daCompanyGroups = new SqlDataAdapter();
    this.SqlDeleteCommand1 = new SqlCommand();
    this.cnSQL = new SqlConnection();
    this.SqlInsertCommand1 = new SqlCommand();
    this.SqlSelectCommand1 = new SqlCommand();
    this.SqlUpdateCommand1 = new SqlCommand();
    this.dgCompanyGroups = new UltraGrid();
    this.btnSave = new MGAButton();
    this.err = new ErrorProvider(this.components);
    this.dsCompany.BeginInit();
    ((ISupportInitialize) this.dgCompanyGroups).BeginInit();
    ((ISupportInitialize) this.btnSave).BeginInit();
    ((ISupportInitialize) this.err).BeginInit();
    this.SuspendLayout();
    this.dsCompany.DataSetName = "dsCompanies";
    this.dsCompany.Locale = new CultureInfo("en-US");
    this.dsCompany.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.daCompanyGroups.DeleteCommand = this.SqlDeleteCommand1;
    this.daCompanyGroups.InsertCommand = this.SqlInsertCommand1;
    this.daCompanyGroups.SelectCommand = this.SqlSelectCommand1;
    this.daCompanyGroups.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblCompanyGroups", new DataColumnMapping[1]
      {
        new DataColumnMapping("CompanyGroupName", "CompanyGroupName")
      })
    });
    this.daCompanyGroups.UpdateCommand = this.SqlUpdateCommand1;
    this.SqlDeleteCommand1.CommandText = "DELETE FROM tblCompanyGroups WHERE (CompanyGroupGuid = @Original_CompanyGroupGuid) AND (CompanyGroupName = @Original_CompanyGroupName)";
    this.SqlDeleteCommand1.Connection = this.cnSQL;
    this.SqlDeleteCommand1.Parameters.AddRange(new SqlParameter[2]
    {
      new SqlParameter("@Original_CompanyGroupGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, ParameterDirection.Input, false, (byte) 0, (byte) 0, "CompanyGroupGuid", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_CompanyGroupName", SqlDbType.VarChar, 50, ParameterDirection.Input, false, (byte) 0, (byte) 0, "CompanyGroupName", DataRowVersion.Original, (object) null)
    });
    this.cnSQL.ConnectionString = "Data Source=MGASYSTEMS;Initial Catalog=IMS;Integrated Security=True";
    this.cnSQL.FireInfoMessageEventOnUserErrors = false;
    this.SqlInsertCommand1.CommandText = componentResourceManager.GetString("SqlInsertCommand1.CommandText");
    this.SqlInsertCommand1.Connection = this.cnSQL;
    this.SqlInsertCommand1.Parameters.AddRange(new SqlParameter[2]
    {
      new SqlParameter("@CompanyGroupName", SqlDbType.VarChar, 50, "CompanyGroupName"),
      new SqlParameter("@CompanyGroupGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "CompanyGroupGuid")
    });
    this.SqlSelectCommand1.CommandText = "SELECT     CompanyGroupName, CompanyGroupGUID\r\nFROM         dbo.tblCompanyGroups\r\nORDER BY CompanyGroupName";
    this.SqlSelectCommand1.Connection = this.cnSQL;
    this.SqlUpdateCommand1.CommandText = componentResourceManager.GetString("SqlUpdateCommand1.CommandText");
    this.SqlUpdateCommand1.Connection = this.cnSQL;
    this.SqlUpdateCommand1.Parameters.AddRange(new SqlParameter[4]
    {
      new SqlParameter("@CompanyGroupName", SqlDbType.VarChar, 50, "CompanyGroupName"),
      new SqlParameter("@CompanyGroupGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "CompanyGroupGuid"),
      new SqlParameter("@Original_CompanyGroupGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, ParameterDirection.Input, false, (byte) 0, (byte) 0, "CompanyGroupGuid", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_CompanyGroupName", SqlDbType.VarChar, 50, ParameterDirection.Input, false, (byte) 0, (byte) 0, "CompanyGroupName", DataRowVersion.Original, (object) null)
    });
    ((Control) this.dgCompanyGroups).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraControlBase) this.dgCompanyGroups).Cursor = Cursors.Hand;
    ((UltraGridBase) this.dgCompanyGroups).DataSource = (object) this.dsCompany.tblCompanyGroups;
    appearance1.BackColor = Color.WhiteSmoke;
    ((SpecialBoxBase) ((UltraGridBase) this.dgCompanyGroups).DisplayLayout.AddNewBox).Appearance = (AppearanceBase) appearance1;
    appearance2.BackColor = Color.WhiteSmoke;
    appearance2.BorderColor = Color.WhiteSmoke;
    appearance2.FontData.UnderlineAsString = "True";
    appearance2.ForeColor = Color.Blue;
    ((UltraGridBase) this.dgCompanyGroups).DisplayLayout.AddNewBox.ButtonAppearance = (AppearanceBase) appearance2;
    ((SpecialBoxBase) ((UltraGridBase) this.dgCompanyGroups).DisplayLayout.AddNewBox).Hidden = false;
    ((SpecialBoxBase) ((UltraGridBase) this.dgCompanyGroups).DisplayLayout.AddNewBox).Prompt = " ";
    ((UltraGridBase) this.dgCompanyGroups).DisplayLayout.AddNewBox.Style = (AddNewBoxStyle) 1;
    appearance3.BackColor = Color.White;
    appearance3.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.dgCompanyGroups).DisplayLayout.Appearance = (AppearanceBase) appearance3;
    ((UltraGridBase) this.dgCompanyGroups).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridBand1.AddButtonCaption = "Click here to add a new company group ...";
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn2.Header.VisiblePosition = 1;
    ultraGridColumn2.Hidden = true;
    ((HeaderBase) ultraGridColumn3.Header).Caption = "Company Group";
    ultraGridColumn3.Header.VisiblePosition = 2;
    ultraGridColumn3.Width = 401;
    ultraGridColumn4.Header.VisiblePosition = 3;
    ultraGridBand1.Columns.AddRange(new object[4]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3,
      (object) ultraGridColumn4
    });
    ultraGridColumn5.Header.VisiblePosition = 0;
    ultraGridColumn6.Header.VisiblePosition = 1;
    ultraGridColumn7.Header.VisiblePosition = 2;
    ultraGridColumn8.Header.VisiblePosition = 3;
    ultraGridColumn9.Header.VisiblePosition = 4;
    ultraGridColumn10.Header.VisiblePosition = 5;
    ultraGridColumn11.Header.VisiblePosition = 6;
    ultraGridColumn12.Header.VisiblePosition = 7;
    ultraGridColumn13.Header.VisiblePosition = 8;
    ultraGridBand2.Columns.AddRange(new object[9]
    {
      (object) ultraGridColumn5,
      (object) ultraGridColumn6,
      (object) ultraGridColumn7,
      (object) ultraGridColumn8,
      (object) ultraGridColumn9,
      (object) ultraGridColumn10,
      (object) ultraGridColumn11,
      (object) ultraGridColumn12,
      (object) ultraGridColumn13
    });
    ultraGridColumn14.Header.VisiblePosition = 0;
    ultraGridColumn15.Header.VisiblePosition = 1;
    ultraGridColumn16.Header.VisiblePosition = 2;
    ultraGridColumn17.Header.VisiblePosition = 3;
    ultraGridColumn18.Header.VisiblePosition = 4;
    ultraGridColumn19.Header.VisiblePosition = 5;
    ultraGridColumn20.Header.VisiblePosition = 6;
    ultraGridColumn21.Header.VisiblePosition = 7;
    ultraGridColumn22.Header.VisiblePosition = 8;
    ultraGridColumn23.Header.VisiblePosition = 9;
    ultraGridColumn24.Header.VisiblePosition = 10;
    ultraGridColumn25.Header.VisiblePosition = 11;
    ultraGridColumn26.Header.VisiblePosition = 12;
    ultraGridColumn27.Header.VisiblePosition = 13;
    ultraGridColumn28.Header.VisiblePosition = 14;
    ultraGridColumn29.Header.VisiblePosition = 15;
    ultraGridColumn30.Header.VisiblePosition = 16 /*0x10*/;
    ultraGridColumn31.Header.VisiblePosition = 17;
    ultraGridColumn32.Header.VisiblePosition = 18;
    ultraGridColumn33.Header.VisiblePosition = 19;
    ultraGridColumn34.Header.VisiblePosition = 20;
    ultraGridColumn35.Header.VisiblePosition = 21;
    ultraGridColumn36.Header.VisiblePosition = 22;
    ultraGridColumn37.Header.VisiblePosition = 23;
    ultraGridColumn38.Header.VisiblePosition = 24;
    ultraGridColumn39.Header.VisiblePosition = 25;
    ultraGridColumn40.Header.VisiblePosition = 26;
    ultraGridBand3.Columns.AddRange(new object[27]
    {
      (object) ultraGridColumn14,
      (object) ultraGridColumn15,
      (object) ultraGridColumn16,
      (object) ultraGridColumn17,
      (object) ultraGridColumn18,
      (object) ultraGridColumn19,
      (object) ultraGridColumn20,
      (object) ultraGridColumn21,
      (object) ultraGridColumn22,
      (object) ultraGridColumn23,
      (object) ultraGridColumn24,
      (object) ultraGridColumn25,
      (object) ultraGridColumn26,
      (object) ultraGridColumn27,
      (object) ultraGridColumn28,
      (object) ultraGridColumn29,
      (object) ultraGridColumn30,
      (object) ultraGridColumn31,
      (object) ultraGridColumn32,
      (object) ultraGridColumn33,
      (object) ultraGridColumn34,
      (object) ultraGridColumn35,
      (object) ultraGridColumn36,
      (object) ultraGridColumn37,
      (object) ultraGridColumn38,
      (object) ultraGridColumn39,
      (object) ultraGridColumn40
    });
    ultraGridColumn41.Header.VisiblePosition = 0;
    ultraGridColumn42.Header.VisiblePosition = 1;
    ultraGridColumn43.Header.VisiblePosition = 2;
    ultraGridColumn44.Header.VisiblePosition = 3;
    ultraGridColumn45.Header.VisiblePosition = 4;
    ultraGridBand4.Columns.AddRange(new object[5]
    {
      (object) ultraGridColumn41,
      (object) ultraGridColumn42,
      (object) ultraGridColumn43,
      (object) ultraGridColumn44,
      (object) ultraGridColumn45
    });
    ((UltraGridBase) this.dgCompanyGroups).DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    ((UltraGridBase) this.dgCompanyGroups).DisplayLayout.BandsSerializer.Add((object) ultraGridBand2);
    ((UltraGridBase) this.dgCompanyGroups).DisplayLayout.BandsSerializer.Add((object) ultraGridBand3);
    ((UltraGridBase) this.dgCompanyGroups).DisplayLayout.BandsSerializer.Add((object) ultraGridBand4);
    ((UltraGridBase) this.dgCompanyGroups).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance4.BackColor = Color.LightSteelBlue;
    appearance4.FontData.SizeInPoints = 10f;
    appearance4.ForeColor = Color.Black;
    ((UltraGridBase) this.dgCompanyGroups).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance4;
    appearance5.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance5.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance5.ForeColor = Color.Black;
    ((UltraGridBase) this.dgCompanyGroups).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance5;
    ((UltraGridBase) this.dgCompanyGroups).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    appearance6.BorderColor = Color.LightGray;
    ((UltraGridBase) this.dgCompanyGroups).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance6;
    appearance7.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.dgCompanyGroups).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance7;
    ((UltraGridBase) this.dgCompanyGroups).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance8.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.dgCompanyGroups).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance8;
    appearance9.BorderColor = Color.LightGray;
    ((UltraGridBase) this.dgCompanyGroups).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance9;
    ((UltraGridBase) this.dgCompanyGroups).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 1;
    ((UltraGridBase) this.dgCompanyGroups).DisplayLayout.Override.RowSelectorStyle = (HeaderStyle) 2;
    appearance10.BackColor = Color.Transparent;
    appearance10.ForeColor = Color.Black;
    ((UltraGridBase) this.dgCompanyGroups).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance10;
    scrollBarLook.ViewStyle = (ScrollBarViewStyle) 3;
    ((UltraGridBase) this.dgCompanyGroups).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((UltraGridBase) this.dgCompanyGroups).DisplayLayout.ViewStyle = (ViewStyle) 0;
    ((Control) this.dgCompanyGroups).Location = new Point(12, 12);
    ((Control) this.dgCompanyGroups).Name = "dgCompanyGroups";
    ((Control) this.dgCompanyGroups).Size = new Size(422, 221);
    ((Control) this.dgCompanyGroups).TabIndex = 0;
    ((UltraControlBase) this.dgCompanyGroups).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dgCompanyGroups).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.btnSave).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance11.ImageHAlign = (HAlign) 2;
    appearance11.ImageVAlign = (VAlign) 2;
    ((AppearanceBase) appearance11).TextHAlignAsString = "Center";
    ((ControlBase) this.btnSave).Appearance = (AppearanceBase) appearance11;
    ((ControlBase) this.btnSave).ImageSize = new Size(24, 24);
    ((ControlBase) this.btnSave).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnSave).Location = new Point(394, 239);
    ((Control) this.btnSave).Name = "btnSave";
    ((Control) this.btnSave).Size = new Size(40, 40);
    ((Control) this.btnSave).TabIndex = 1;
    this.btnSave.UseOSThemes = (DefaultableBoolean) 2;
    this.err.ContainerControl = (ContainerControl) this;
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.White;
    this.ClientSize = new Size(446, 290);
    this.Controls.Add((Control) this.btnSave);
    this.Controls.Add((Control) this.dgCompanyGroups);
    this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.ForeColor = Color.Black;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmCompanyGroups);
    this.Text = "Company Groups";
    this.dsCompany.EndInit();
    ((ISupportInitialize) this.dgCompanyGroups).EndInit();
    ((ISupportInitialize) this.btnSave).EndInit();
    ((ISupportInitialize) this.err).EndInit();
    this.ResumeLayout(false);
  }

  public frmCompanyGroups()
  {
    this.Load += new EventHandler(this.frmComapnyGroups_Load);
    this.Closing += new CancelEventHandler(this.frmCompanyGroups_Closing);
    this.InitializeComponent();
  }

  private void frmComapnyGroups_Load(object sender, EventArgs e)
  {
    this.cnSQL.ConnectionString = CurrentUser.Instance.ConnectionString;
    ((ControlBase) this.btnSave).Appearance.Image = (object) ImageCache.Instance.Save;
    DefaultDatabase.DataAdapterFill((DbDataAdapter) this.daCompanyGroups, (DataTable) this.dsCompany.tblCompanyGroups);
  }

  private void frmCompanyGroups_Closing(object sender, CancelEventArgs e)
  {
    Cursor.Current = MgaCursors.WaitCursor;
    Form[] mdiChildren = MDIControls.Instance.MDIParent.MdiChildren;
    int index = 0;
    while (index < mdiChildren.Length)
    {
      if (mdiChildren[index] is frmCompanies frmCompanies)
        frmCompanies.FillCompanyGroups();
      checked { ++index; }
    }
    Cursor.Current = MgaCursors.Default;
  }

  private bool ValidateForm()
  {
    bool flag = true;
    foreach (UltraGridRow row in ((UltraGridBase) this.dgCompanyGroups).Rows)
    {
      if (row.Cells["CompanyGroupName"].Value == null || row.Cells["CompanyGroupName"].Value == DBNull.Value)
      {
        this.err.SetError((Control) this.btnSave, "Missing Company Group Name");
        flag = false;
        break;
      }
      this.err.SetError((Control) this.btnSave, string.Empty);
    }
    return flag;
  }

  private void btnSave_Click(object sender, EventArgs e)
  {
    if (!this.ValidateForm())
      return;
    ((UltraGridBase) this.dgCompanyGroups).UpdateData();
    DefaultDatabase.DataAdapterUpdate((DbDataAdapter) this.daCompanyGroups, (DataTable) this.dsCompany.tblCompanyGroups);
    this.Close();
  }

  private void dgCompanyGroups_AfterRowInsert(object sender, RowEventArgs e)
  {
    e.Row.Cells["CompanyGroupGuid"].Value = (object) Guid.NewGuid();
  }
}
