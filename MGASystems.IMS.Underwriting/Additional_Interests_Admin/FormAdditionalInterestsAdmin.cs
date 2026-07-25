// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Underwriting.Additional_Interests_Admin.FormAdditionalInterestsAdmin
// Assembly: MGASystems.IMS.Underwriting, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 1057C5B8-8299-4767-8242-AF9F1EF932DB
// Assembly location: D:\augusta\fortegra\IMS Project\MGASystems.IMS.Underwriting.dll

using Infragistics.Win;
using Infragistics.Win.Layout;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinMaskedEdit;
using Infragistics.Win.UltraWinScrollBar;
using MGASystems.AddressResolver;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.Tools;
using MGASystems.Tools.DBSaveUI;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Underwriting.Additional_Interests_Admin;

public class FormAdditionalInterestsAdmin : FormBase
{
  private int _interestId = -1;
  private IContainer components;
  private UltraGrid gridAdditionalInterests;
  private SqlDataAdapter da;
  private SqlCommand SqlSelectCommand1;
  private SqlConnection cn;
  private MGASystems.Tools.DBSaveUI.DBSaveUI dbSave;
  private MGAGroupBox grbInterest;
  private MGATextBox txtInterestName;
  private Label Label1;
  private dsAdditionalInterest ds;
  private SqlCommand sqlDeleteCommand;
  private SqlCommand sqlInsertCommand;
  private SqlCommand sqlUpdateCommand;
  private ErrorProvider err;
  private AddressResolver_MULTI zipCodeResolver;
  private UltraMaskedEdit txtMobile;
  private MGATextBox mgaTxtEmail;
  private Label lblEmail;
  private Label lblMobile;

  public FormAdditionalInterestsAdmin() => this.InitializeComponent();

  private void FormAdditionalInterestsAdmin_Load(object sender, EventArgs e)
  {
    this.SetAddressResolverSettings();
    this.LoadAdditionalInterests();
    this.SetSaveState();
    this.EnableControls(false);
  }

  private void LoadAdditionalInterests()
  {
    this.ds.Clear();
    DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[1]
    {
      "tblAdditionalInterests"
    }, "spLoadAdditionalInterests");
  }

  private void SetAddressResolverSettings()
  {
    this.zipCodeResolver.WebserviceUrl = AddressResolverSettings.AddressResolverURL;
    this.zipCodeResolver.UserID = AddressResolverSettings.AddressResolveUserName;
    this.zipCodeResolver.Password = AddressResolverSettings.AddressResolverPassword;
  }

  private void SetSaveState()
  {
    if (this.ds.tblAdditionalInterests.Count > 0)
      this.dbSave.UIState = UIState.HasRecordsNotEditing;
    else
      this.dbSave.UIState = UIState.NoRecordsNotEditing;
  }

  private void EnableControls(bool enable) => ((Control) this.grbInterest).Enabled = enable;

  private void ClearScreen()
  {
    this._interestId = -1;
    this.zipCodeResolver.Clear();
    ((Control) this.txtInterestName).Text = string.Empty;
    ((Control) this.txtMobile).Text = string.Empty;
    ((Control) this.mgaTxtEmail).Text = string.Empty;
  }

  private void dbSave_ClickedCancel(object sender, EventArgs e)
  {
    this._interestId = -1;
    this.SetSaveState();
    this.EnableControls(false);
  }

  private void dbSave_ClickingNew(object sender, CancelEventArgs e) => this.EnableControls(true);

  private void dbSave_ClickingEdit(object sender, CancelEventArgs e)
  {
    if (((UltraGridBase) this.gridAdditionalInterests).ActiveRow == null)
    {
      int num = (int) MessageBox.Show("You must select an additional interest to edit.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
    else
    {
      this._interestId = int.Parse(((UltraGridBase) this.gridAdditionalInterests).ActiveRow.Cells["InterestId"].Value.ToString());
      ((Control) this.txtInterestName).Text = ((UltraGridBase) this.gridAdditionalInterests).ActiveRow.Cells["Interest"].Value.ToString();
      ((Control) this.txtMobile).Text = ((UltraGridBase) this.gridAdditionalInterests).ActiveRow.Cells["Mobile"].Value.ToString();
      ((Control) this.mgaTxtEmail).Text = ((UltraGridBase) this.gridAdditionalInterests).ActiveRow.Cells["Email"].Value.ToString();
      this.zipCodeResolver.Address1 = ((UltraGridBase) this.gridAdditionalInterests).ActiveRow.Cells["Address1"].Value.ToString();
      this.zipCodeResolver.Address2 = ((UltraGridBase) this.gridAdditionalInterests).ActiveRow.Cells["Address2"].Value.ToString();
      this.zipCodeResolver.City = ((UltraGridBase) this.gridAdditionalInterests).ActiveRow.Cells["City"].Value.ToString();
      this.zipCodeResolver.State = ((UltraGridBase) this.gridAdditionalInterests).ActiveRow.Cells["StateId"].Value.ToString();
      this.zipCodeResolver.ZipCode = ((UltraGridBase) this.gridAdditionalInterests).ActiveRow.Cells["ZipCode"].Value.ToString();
      this.zipCodeResolver.ZipCodeExtension = ((UltraGridBase) this.gridAdditionalInterests).ActiveRow.Cells["ZipPlus"].Value.ToString();
      this.zipCodeResolver.ISOCountryCode = ((UltraGridBase) this.gridAdditionalInterests).ActiveRow.Cells["ISOCountryCode"].Value.ToString();
      this.EnableControls(true);
    }
  }

  private void dbSave_ClickingDelete(object sender, CancelEventArgs e)
  {
    if (((UltraGridBase) this.gridAdditionalInterests).ActiveRow == null)
      return;
    this.EnableControls(false);
    if (MessageBox.Show("This will permanently delete the selected additional interest, this action cannot be undone. Continue?", "Delete Additional Interest", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
      return;
    DefaultDatabase.ExecuteNonQuery("spDeleteAdditionalInterest", new object[2]
    {
      (object) "@InterestId",
      ((UltraGridBase) this.gridAdditionalInterests).ActiveRow.Cells["InterestId"].Value
    });
    this.ClearScreen();
    this.LoadAdditionalInterests();
  }

  private void dbSave_ClickingSave(object sender, CancelEventArgs e)
  {
    if (!this.IsValidForm())
    {
      e.Cancel = true;
    }
    else
    {
      if (this._interestId == -1)
        this.SaveAdditionalInterest();
      else
        this.UpdateAdditionalInterest();
      this.ClearScreen();
      this.LoadAdditionalInterests();
      this.EnableControls(false);
    }
  }

  private void dbSave_ClickedSave(object sender, EventArgs e)
  {
    if (this._interestId == -1)
      this.SaveAdditionalInterest();
    else
      this.UpdateAdditionalInterest();
    this.ClearScreen();
    this.LoadAdditionalInterests();
    this.EnableControls(false);
  }

  private void SaveAdditionalInterest()
  {
    DefaultDatabase.ExecuteNonQuery("spSaveAdditionalInterest", new object[20]
    {
      (object) "@Interest",
      (object) ((Control) this.txtInterestName).Text,
      (object) "@Mobile",
      (object) ((Control) this.txtMobile).Text,
      (object) "@Email",
      (object) ((Control) this.mgaTxtEmail).Text,
      (object) "@Address1",
      (object) this.zipCodeResolver.Address1,
      (object) "@Address2",
      (object) this.zipCodeResolver.Address2,
      (object) "@City",
      (object) this.zipCodeResolver.City,
      (object) "@StateId",
      (object) this.zipCodeResolver.State,
      (object) "@ISOCountryCode",
      (object) this.zipCodeResolver.ISOCountryCode,
      (object) "@ZipCode",
      (object) this.zipCodeResolver.ZipCode,
      (object) "@ZipPlus",
      (object) this.zipCodeResolver.ZipCodeExtension
    });
  }

  private void UpdateAdditionalInterest()
  {
    DefaultDatabase.ExecuteNonQuery("spUpdateAdditionalInterest", new object[22]
    {
      (object) "@InterestId",
      (object) this._interestId,
      (object) "@Interest",
      (object) ((Control) this.txtInterestName).Text,
      (object) "@Mobile",
      (object) ((Control) this.txtMobile).Text,
      (object) "@Email",
      (object) ((Control) this.mgaTxtEmail).Text,
      (object) "@Address1",
      (object) this.zipCodeResolver.Address1,
      (object) "@Address2",
      (object) this.zipCodeResolver.Address2,
      (object) "@City",
      (object) this.zipCodeResolver.City,
      (object) "@StateId",
      (object) this.zipCodeResolver.State,
      (object) "@ISOCountryCode",
      (object) this.zipCodeResolver.ISOCountryCode,
      (object) "@ZipCode",
      (object) this.zipCodeResolver.ZipCode,
      (object) "@ZipPlus",
      (object) this.zipCodeResolver.ZipCodeExtension
    });
  }

  private bool IsValidForm()
  {
    if (string.IsNullOrEmpty(((Control) this.txtInterestName).Text))
    {
      int num = (int) MessageBox.Show("You must specify an interest name to continue.", "Required Field Missing", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    if (string.IsNullOrEmpty(this.zipCodeResolver.Address1))
    {
      int num = (int) MessageBox.Show("You must specify an address.", "Required Field Missing", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    if (string.IsNullOrEmpty(this.zipCodeResolver.City))
    {
      int num = (int) MessageBox.Show("You must specify a city to continue.", "Required Field Missing", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    if (string.IsNullOrEmpty(this.zipCodeResolver.State))
    {
      int num = (int) MessageBox.Show("You must specify state to continue.", "Required Field Missing", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    if (string.IsNullOrEmpty(this.zipCodeResolver.ZipCode))
    {
      int num = (int) MessageBox.Show("You must specify a zip code to continue.", "Required Field Missing", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    if (!string.IsNullOrEmpty(this.zipCodeResolver.ISOCountryCode))
      return true;
    int num1 = (int) MessageBox.Show("You must specify a country to continue.", "Required Field Missing", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    return false;
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (FormAdditionalInterestsAdmin));
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    UltraGridBand ultraGridBand = new UltraGridBand("tblAdditionalInterests", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("InterestID");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("Interest");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("Address1");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("Address2");
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("City");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("County");
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("StateID");
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("Region");
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("ISOCountryCode");
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("ZipCode");
    UltraGridColumn ultraGridColumn11 = new UltraGridColumn("ZipPlus");
    UltraGridColumn ultraGridColumn12 = new UltraGridColumn("Mobile");
    UltraGridColumn ultraGridColumn13 = new UltraGridColumn("Email");
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    Appearance appearance11 = new Appearance();
    Appearance appearance12 = new Appearance();
    Appearance appearance13 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    Appearance appearance14 = new Appearance();
    Appearance appearance15 = new Appearance();
    Appearance appearance16 = new Appearance();
    this.da = new SqlDataAdapter();
    this.sqlDeleteCommand = new SqlCommand();
    this.cn = new SqlConnection();
    this.sqlInsertCommand = new SqlCommand();
    this.SqlSelectCommand1 = new SqlCommand();
    this.sqlUpdateCommand = new SqlCommand();
    this.dbSave = new MGASystems.Tools.DBSaveUI.DBSaveUI();
    this.grbInterest = new MGAGroupBox();
    this.txtInterestName = new MGATextBox();
    this.zipCodeResolver = new AddressResolver_MULTI();
    this.Label1 = new Label();
    this.err = new ErrorProvider(this.components);
    this.gridAdditionalInterests = new UltraGrid();
    this.ds = new dsAdditionalInterest();
    this.lblMobile = new Label();
    this.lblEmail = new Label();
    this.mgaTxtEmail = new MGATextBox();
    this.txtMobile = new UltraMaskedEdit();
    ((ISupportInitialize) this.grbInterest).BeginInit();
    ((Control) this.grbInterest).SuspendLayout();
    ((ISupportInitialize) this.txtInterestName).BeginInit();
    ((ISupportInitialize) this.err).BeginInit();
    ((ISupportInitialize) this.gridAdditionalInterests).BeginInit();
    this.ds.BeginInit();
    ((ISupportInitialize) this.mgaTxtEmail).BeginInit();
    this.SuspendLayout();
    this.da.DeleteCommand = this.sqlDeleteCommand;
    this.da.InsertCommand = this.sqlInsertCommand;
    this.da.SelectCommand = this.SqlSelectCommand1;
    this.da.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblAdditionalInterests", new DataColumnMapping[13]
      {
        new DataColumnMapping("InterestID", "InterestID"),
        new DataColumnMapping("Interest", "Interest"),
        new DataColumnMapping("Address1", "Address1"),
        new DataColumnMapping("Address2", "Address2"),
        new DataColumnMapping("City", "City"),
        new DataColumnMapping("County", "County"),
        new DataColumnMapping("StateID", "StateID"),
        new DataColumnMapping("Region", "Region"),
        new DataColumnMapping("ISOCountryCode", "ISOCountryCode"),
        new DataColumnMapping("ZipCode", "ZipCode"),
        new DataColumnMapping("ZipPlus", "ZipPlus"),
        new DataColumnMapping("mobile", "mobile"),
        new DataColumnMapping("email", "email")
      })
    });
    this.da.UpdateCommand = this.sqlUpdateCommand;
    this.sqlDeleteCommand.CommandText = componentResourceManager.GetString("sqlDeleteCommand.CommandText");
    this.sqlDeleteCommand.Connection = this.cn;
    this.sqlDeleteCommand.Parameters.AddRange(new SqlParameter[25]
    {
      new SqlParameter("@Original_InterestID", SqlDbType.Int, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "InterestID", DataRowVersion.Original, (object) null),
      new SqlParameter("@IsNull_Interest", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Interest", DataRowVersion.Original, true, (object) null, "", "", ""),
      new SqlParameter("@Original_Interest", SqlDbType.VarChar, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "Interest", DataRowVersion.Original, (object) null),
      new SqlParameter("@IsNull_Address1", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Address1", DataRowVersion.Original, true, (object) null, "", "", ""),
      new SqlParameter("@Original_Address1", SqlDbType.VarChar, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "Address1", DataRowVersion.Original, (object) null),
      new SqlParameter("@IsNull_Address2", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Address2", DataRowVersion.Original, true, (object) null, "", "", ""),
      new SqlParameter("@Original_Address2", SqlDbType.VarChar, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "Address2", DataRowVersion.Original, (object) null),
      new SqlParameter("@IsNull_City", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "City", DataRowVersion.Original, true, (object) null, "", "", ""),
      new SqlParameter("@Original_City", SqlDbType.VarChar, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "City", DataRowVersion.Original, (object) null),
      new SqlParameter("@IsNull_County", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "County", DataRowVersion.Original, true, (object) null, "", "", ""),
      new SqlParameter("@Original_County", SqlDbType.VarChar, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "County", DataRowVersion.Original, (object) null),
      new SqlParameter("@IsNull_StateID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "StateID", DataRowVersion.Original, true, (object) null, "", "", ""),
      new SqlParameter("@Original_StateID", SqlDbType.Char, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "StateID", DataRowVersion.Original, (object) null),
      new SqlParameter("@IsNull_Region", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Region", DataRowVersion.Original, true, (object) null, "", "", ""),
      new SqlParameter("@Original_Region", SqlDbType.VarChar, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "Region", DataRowVersion.Original, (object) null),
      new SqlParameter("@IsNull_ISOCountryCode", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ISOCountryCode", DataRowVersion.Original, true, (object) null, "", "", ""),
      new SqlParameter("@Original_ISOCountryCode", SqlDbType.Char, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "ISOCountryCode", DataRowVersion.Original, (object) null),
      new SqlParameter("@IsNull_ZipCode", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ZipCode", DataRowVersion.Original, true, (object) null, "", "", ""),
      new SqlParameter("@Original_ZipCode", SqlDbType.VarChar, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "ZipCode", DataRowVersion.Original, (object) null),
      new SqlParameter("@IsNull_ZipPlus", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ZipPlus", DataRowVersion.Original, true, (object) null, "", "", ""),
      new SqlParameter("@Original_ZipPlus", SqlDbType.VarChar, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "ZipPlus", DataRowVersion.Original, (object) null),
      new SqlParameter("@IsNull_mobile", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "mobile", DataRowVersion.Original, true, (object) null, "", "", ""),
      new SqlParameter("@Original_mobile", SqlDbType.VarChar, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "mobile", DataRowVersion.Original, (object) null),
      new SqlParameter("@IsNull_email", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "email", DataRowVersion.Original, true, (object) null, "", "", ""),
      new SqlParameter("@Original_email", SqlDbType.VarChar, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "email", DataRowVersion.Original, (object) null)
    });
    this.cn.ConnectionString = "workstation id=PSARNOWSKI2;packet size=4096;integrated security=SSPI;data source=MGASYSTEMS;persist security info=False;initial catalog=IMS";
    this.cn.FireInfoMessageEventOnUserErrors = false;
    this.sqlInsertCommand.CommandText = componentResourceManager.GetString("sqlInsertCommand.CommandText");
    this.sqlInsertCommand.Connection = this.cn;
    this.sqlInsertCommand.Parameters.AddRange(new SqlParameter[12]
    {
      new SqlParameter("@Interest", SqlDbType.VarChar, 0, "Interest"),
      new SqlParameter("@Address1", SqlDbType.VarChar, 0, "Address1"),
      new SqlParameter("@Address2", SqlDbType.VarChar, 0, "Address2"),
      new SqlParameter("@City", SqlDbType.VarChar, 0, "City"),
      new SqlParameter("@County", SqlDbType.VarChar, 0, "County"),
      new SqlParameter("@StateID", SqlDbType.Char, 0, "StateID"),
      new SqlParameter("@Region", SqlDbType.VarChar, 0, "Region"),
      new SqlParameter("@ISOCountryCode", SqlDbType.Char, 0, "ISOCountryCode"),
      new SqlParameter("@ZipCode", SqlDbType.VarChar, 0, "ZipCode"),
      new SqlParameter("@ZipPlus", SqlDbType.VarChar, 0, "ZipPlus"),
      new SqlParameter("@mobile", SqlDbType.VarChar, 0, "mobile"),
      new SqlParameter("@email", SqlDbType.VarChar, 0, "email")
    });
    this.SqlSelectCommand1.CommandText = "SELECT        InterestID, Interest, Address1, Address2, City, County, StateID, Region, ISOCountryCode, ZipCode, ZipPlus, mobile, email\r\nFROM            tblAdditionalInterests\r\nORDER BY Interest";
    this.SqlSelectCommand1.Connection = this.cn;
    this.sqlUpdateCommand.CommandText = componentResourceManager.GetString("sqlUpdateCommand.CommandText");
    this.sqlUpdateCommand.Connection = this.cn;
    this.sqlUpdateCommand.Parameters.AddRange(new SqlParameter[38]
    {
      new SqlParameter("@Interest", SqlDbType.VarChar, 0, "Interest"),
      new SqlParameter("@Address1", SqlDbType.VarChar, 0, "Address1"),
      new SqlParameter("@Address2", SqlDbType.VarChar, 0, "Address2"),
      new SqlParameter("@City", SqlDbType.VarChar, 0, "City"),
      new SqlParameter("@County", SqlDbType.VarChar, 0, "County"),
      new SqlParameter("@StateID", SqlDbType.Char, 0, "StateID"),
      new SqlParameter("@Region", SqlDbType.VarChar, 0, "Region"),
      new SqlParameter("@ISOCountryCode", SqlDbType.Char, 0, "ISOCountryCode"),
      new SqlParameter("@ZipCode", SqlDbType.VarChar, 0, "ZipCode"),
      new SqlParameter("@ZipPlus", SqlDbType.VarChar, 0, "ZipPlus"),
      new SqlParameter("@mobile", SqlDbType.VarChar, 0, "mobile"),
      new SqlParameter("@email", SqlDbType.VarChar, 0, "email"),
      new SqlParameter("@Original_InterestID", SqlDbType.Int, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "InterestID", DataRowVersion.Original, (object) null),
      new SqlParameter("@IsNull_Interest", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Interest", DataRowVersion.Original, true, (object) null, "", "", ""),
      new SqlParameter("@Original_Interest", SqlDbType.VarChar, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "Interest", DataRowVersion.Original, (object) null),
      new SqlParameter("@IsNull_Address1", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Address1", DataRowVersion.Original, true, (object) null, "", "", ""),
      new SqlParameter("@Original_Address1", SqlDbType.VarChar, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "Address1", DataRowVersion.Original, (object) null),
      new SqlParameter("@IsNull_Address2", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Address2", DataRowVersion.Original, true, (object) null, "", "", ""),
      new SqlParameter("@Original_Address2", SqlDbType.VarChar, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "Address2", DataRowVersion.Original, (object) null),
      new SqlParameter("@IsNull_City", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "City", DataRowVersion.Original, true, (object) null, "", "", ""),
      new SqlParameter("@Original_City", SqlDbType.VarChar, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "City", DataRowVersion.Original, (object) null),
      new SqlParameter("@IsNull_County", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "County", DataRowVersion.Original, true, (object) null, "", "", ""),
      new SqlParameter("@Original_County", SqlDbType.VarChar, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "County", DataRowVersion.Original, (object) null),
      new SqlParameter("@IsNull_StateID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "StateID", DataRowVersion.Original, true, (object) null, "", "", ""),
      new SqlParameter("@Original_StateID", SqlDbType.Char, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "StateID", DataRowVersion.Original, (object) null),
      new SqlParameter("@IsNull_Region", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Region", DataRowVersion.Original, true, (object) null, "", "", ""),
      new SqlParameter("@Original_Region", SqlDbType.VarChar, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "Region", DataRowVersion.Original, (object) null),
      new SqlParameter("@IsNull_ISOCountryCode", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ISOCountryCode", DataRowVersion.Original, true, (object) null, "", "", ""),
      new SqlParameter("@Original_ISOCountryCode", SqlDbType.Char, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "ISOCountryCode", DataRowVersion.Original, (object) null),
      new SqlParameter("@IsNull_ZipCode", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ZipCode", DataRowVersion.Original, true, (object) null, "", "", ""),
      new SqlParameter("@Original_ZipCode", SqlDbType.VarChar, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "ZipCode", DataRowVersion.Original, (object) null),
      new SqlParameter("@IsNull_ZipPlus", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "ZipPlus", DataRowVersion.Original, true, (object) null, "", "", ""),
      new SqlParameter("@Original_ZipPlus", SqlDbType.VarChar, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "ZipPlus", DataRowVersion.Original, (object) null),
      new SqlParameter("@IsNull_mobile", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "mobile", DataRowVersion.Original, true, (object) null, "", "", ""),
      new SqlParameter("@Original_mobile", SqlDbType.VarChar, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "mobile", DataRowVersion.Original, (object) null),
      new SqlParameter("@IsNull_email", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "email", DataRowVersion.Original, true, (object) null, "", "", ""),
      new SqlParameter("@Original_email", SqlDbType.VarChar, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "email", DataRowVersion.Original, (object) null),
      new SqlParameter("@InterestID", SqlDbType.Int, 4, "InterestID")
    });
    this.dbSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.dbSave.AutoQueryRowCountOnLoad = false;
    this.dbSave.AutoSizeMode = AutoSizeMode.GrowAndShrink;
    this.dbSave.EditStyle = EditStyle.ShowEditButton;
    this.dbSave.FreezeEvents = false;
    this.dbSave.Location = new Point(457, 465);
    this.dbSave.Name = "dbSave";
    this.dbSave.Size = new Size(112 /*0x70*/, 40);
    this.dbSave.TabIndex = 9;
    this.dbSave.ClickingNew += new CancelEventHandler(this.dbSave_ClickingNew);
    this.dbSave.ClickingSave += new CancelEventHandler(this.dbSave_ClickingSave);
    this.dbSave.ClickingDelete += new CancelEventHandler(this.dbSave_ClickingDelete);
    this.dbSave.ClickedCancel += new EventHandler(this.dbSave_ClickedCancel);
    this.dbSave.ClickingEdit += new CancelEventHandler(this.dbSave_ClickingEdit);
    ((Control) this.grbInterest).Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((AppearanceBase) appearance1).BackColor = Color.FromArgb(239, 247, 253);
    ((AppearanceBase) appearance1).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.grbInterest.ContentAreaAppearance = (AppearanceBase) appearance1;
    ((Control) this.grbInterest).Controls.Add((Control) this.txtMobile);
    ((Control) this.grbInterest).Controls.Add((Control) this.mgaTxtEmail);
    ((Control) this.grbInterest).Controls.Add((Control) this.lblEmail);
    ((Control) this.grbInterest).Controls.Add((Control) this.lblMobile);
    ((Control) this.grbInterest).Controls.Add((Control) this.txtInterestName);
    ((Control) this.grbInterest).Controls.Add((Control) this.zipCodeResolver);
    ((Control) this.grbInterest).Controls.Add((Control) this.Label1);
    ((AppearanceBase) appearance2).ForeColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.grbInterest.HeaderAppearance = (AppearanceBase) appearance2;
    ((Control) this.grbInterest).Location = new Point(12, 266);
    ((Control) this.grbInterest).Name = "grbInterest";
    ((Control) this.grbInterest).Size = new Size(557, 193);
    ((Control) this.grbInterest).TabIndex = 221;
    ((Control) this.grbInterest).Text = "Additional Interest Details";
    this.grbInterest.ViewStyle = (GroupBoxViewStyle) 2;
    ((AppearanceBase) appearance3).BackColor = Color.White;
    ((AppearanceBase) appearance3).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance3).ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtInterestName).Appearance = (AppearanceBase) appearance3;
    ((Control) this.txtInterestName).BackColor = Color.White;
    ((Control) this.txtInterestName).Location = new Point(83, 23);
    ((TextEditorControlBase) this.txtInterestName).MaxLength = 500;
    this.txtInterestName.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtInterestName).Name = "txtInterestName";
    ((Control) this.txtInterestName).Size = new Size(381, 19);
    ((Control) this.txtInterestName).TabIndex = 0;
    ((UltraControlBase) this.txtInterestName).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtInterestName).UseOsThemes = (DefaultableBoolean) 2;
    this.zipCodeResolver.Address1 = "";
    this.zipCodeResolver.Address2 = "";
    ((Control) this.zipCodeResolver).BackColor = Color.Transparent;
    this.zipCodeResolver.City = "";
    this.zipCodeResolver.County = "";
    ((Control) this.zipCodeResolver).Font = new Font("Tahoma", 8f);
    ((Control) this.zipCodeResolver).Location = new Point(-2, 37);
    this.zipCodeResolver.MGAStyle = MGAStyles.Blue;
    ((Control) this.zipCodeResolver).Name = "zipCodeResolver";
    this.zipCodeResolver.Password = (string) null;
    ((Control) this.zipCodeResolver).Size = new Size(261, 152);
    this.zipCodeResolver.State = "";
    ((Control) this.zipCodeResolver).TabIndex = 7;
    this.zipCodeResolver.TextAlign = ContentAlignment.MiddleLeft;
    this.zipCodeResolver.UserID = (string) null;
    this.zipCodeResolver.WebserviceUrl = (string) null;
    this.zipCodeResolver.ZipCode = "";
    this.zipCodeResolver.ZipCodeExtension = "";
    this.Label1.AutoSize = true;
    this.Label1.BackColor = Color.Transparent;
    this.Label1.Location = new Point(5, 23);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(72, 13);
    this.Label1.TabIndex = 6;
    this.Label1.Text = "Interest Type:";
    this.Label1.TextAlign = ContentAlignment.MiddleLeft;
    this.err.ContainerControl = (ContainerControl) this;
    ((Control) this.gridAdditionalInterests).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraGridBase) this.gridAdditionalInterests).DataMember = "tblAdditionalInterests";
    ((UltraGridBase) this.gridAdditionalInterests).DataSource = (object) this.ds;
    ((AppearanceBase) appearance4).BackColor = Color.White;
    ((AppearanceBase) appearance4).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.gridAdditionalInterests).DisplayLayout.Appearance = (AppearanceBase) appearance4;
    ((UltraGridBase) this.gridAdditionalInterests).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn1.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn1.Header).VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn1.Width = 35;
    ultraGridColumn2.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn2.Header).VisiblePosition = 1;
    ultraGridColumn2.Width = 81;
    ultraGridColumn3.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn3.Header).VisiblePosition = 2;
    ultraGridColumn3.Width = 85;
    ultraGridColumn4.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn4.Header).VisiblePosition = 3;
    ultraGridColumn4.Hidden = true;
    ultraGridColumn4.Width = 78;
    ultraGridColumn5.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn5.Header).VisiblePosition = 4;
    ultraGridColumn5.Width = 83;
    ultraGridColumn6.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn6.Header).VisiblePosition = 5;
    ultraGridColumn6.Hidden = true;
    ultraGridColumn6.Width = 90;
    ultraGridColumn7.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn7.Header).Caption = "State";
    ((HeaderBase) ultraGridColumn7.Header).VisiblePosition = 6;
    ultraGridColumn7.Width = 81;
    ultraGridColumn8.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn8.Header).VisiblePosition = 7;
    ultraGridColumn8.Hidden = true;
    ultraGridColumn8.Width = 52;
    ultraGridColumn9.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn9.Header).VisiblePosition = 8;
    ultraGridColumn9.Hidden = true;
    ultraGridColumn9.Width = 52;
    ultraGridColumn10.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn10.Header).Caption = "Zip Code";
    ((HeaderBase) ultraGridColumn10.Header).VisiblePosition = 9;
    ultraGridColumn10.Width = 79;
    ultraGridColumn11.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn11.Header).VisiblePosition = 10;
    ultraGridColumn11.Hidden = true;
    ultraGridColumn11.Width = 69;
    ((HeaderBase) ultraGridColumn12.Header).VisiblePosition = 11;
    ultraGridColumn12.Width = 73;
    ((HeaderBase) ultraGridColumn13.Header).VisiblePosition = 12;
    ultraGridColumn13.Width = 73;
    ultraGridBand.Columns.AddRange(new object[13]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3,
      (object) ultraGridColumn4,
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
    ((AppearanceBase) appearance5).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridBand.Header).Appearance = (AppearanceBase) appearance5;
    ((AppearanceBase) appearance6).TextHAlignAsString = "Left";
    ultraGridBand.Override.CellAppearance = (AppearanceBase) appearance6;
    ultraGridBand.Override.CellClickAction = (CellClickAction) 2;
    ((AppearanceBase) appearance7).TextHAlignAsString = "Left";
    ultraGridBand.Override.HeaderAppearance = (AppearanceBase) appearance7;
    ultraGridBand.Override.HeaderClickAction = (HeaderClickAction) 3;
    ((UltraGridBase) this.gridAdditionalInterests).DisplayLayout.BandsSerializer.Add((object) ultraGridBand);
    ((UltraGridBase) this.gridAdditionalInterests).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((AppearanceBase) appearance8).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance8).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance8).ForeColor = Color.Black;
    ((UltraGridBase) this.gridAdditionalInterests).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance8;
    ((UltraGridBase) this.gridAdditionalInterests).DisplayLayout.Override.AllowAddNew = (AllowAddNew) 2;
    ((UltraGridBase) this.gridAdditionalInterests).DisplayLayout.Override.AllowColMoving = (AllowColMoving) 1;
    ((UltraGridBase) this.gridAdditionalInterests).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.gridAdditionalInterests).DisplayLayout.Override.AllowColSwapping = (AllowColSwapping) 1;
    ((UltraGridBase) this.gridAdditionalInterests).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridAdditionalInterests).DisplayLayout.Override.AllowGroupBy = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridAdditionalInterests).DisplayLayout.Override.AllowGroupMoving = (AllowGroupMoving) 1;
    ((UltraGridBase) this.gridAdditionalInterests).DisplayLayout.Override.AllowGroupSwapping = (AllowGroupSwapping) 1;
    ((UltraGridBase) this.gridAdditionalInterests).DisplayLayout.Override.AllowMultiCellOperations = (AllowMultiCellOperation) 0;
    ((UltraGridBase) this.gridAdditionalInterests).DisplayLayout.Override.AllowRowFiltering = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridAdditionalInterests).DisplayLayout.Override.AllowRowLayoutCellSizing = (RowLayoutSizing) 1;
    ((UltraGridBase) this.gridAdditionalInterests).DisplayLayout.Override.AllowRowLayoutCellSpanSizing = (GridBagLayoutAllowSpanSizing) 1;
    ((UltraGridBase) this.gridAdditionalInterests).DisplayLayout.Override.AllowRowLayoutColMoving = (GridBagLayoutAllowMoving) 1;
    ((UltraGridBase) this.gridAdditionalInterests).DisplayLayout.Override.AllowRowLayoutLabelSizing = (RowLayoutSizing) 1;
    ((UltraGridBase) this.gridAdditionalInterests).DisplayLayout.Override.AllowRowLayoutLabelSpanSizing = (GridBagLayoutAllowSpanSizing) 1;
    ((UltraGridBase) this.gridAdditionalInterests).DisplayLayout.Override.AllowRowSummaries = (AllowRowSummaries) 2;
    ((UltraGridBase) this.gridAdditionalInterests).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance9).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridAdditionalInterests).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance9;
    ((UltraGridBase) this.gridAdditionalInterests).DisplayLayout.Override.CellClickAction = (CellClickAction) 2;
    ((AppearanceBase) appearance10).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.gridAdditionalInterests).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance10;
    ((UltraGridBase) this.gridAdditionalInterests).DisplayLayout.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance11).BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.gridAdditionalInterests).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance11;
    ((AppearanceBase) appearance12).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridAdditionalInterests).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance12;
    ((UltraGridBase) this.gridAdditionalInterests).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance13).BackColor = Color.Transparent;
    ((AppearanceBase) appearance13).ForeColor = Color.Black;
    ((UltraGridBase) this.gridAdditionalInterests).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance13;
    ((AppearanceBase) appearance14).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance14).BorderColor = Color.Silver;
    scrollBarLook.ButtonAppearance = (AppearanceBase) appearance14;
    ((AppearanceBase) appearance15).BackColor = Color.White;
    scrollBarLook.TrackAppearance = (AppearanceBase) appearance15;
    ((UltraGridBase) this.gridAdditionalInterests).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((Control) this.gridAdditionalInterests).Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.gridAdditionalInterests).Location = new Point(12, 12);
    ((Control) this.gridAdditionalInterests).Name = "gridAdditionalInterests";
    ((Control) this.gridAdditionalInterests).Size = new Size(557, 248);
    ((Control) this.gridAdditionalInterests).TabIndex = 8;
    ((UltraControlBase) this.gridAdditionalInterests).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.gridAdditionalInterests).UseOsThemes = (DefaultableBoolean) 2;
    this.ds.DataSetName = "dsAdditionalInterest";
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.lblMobile.AutoSize = true;
    this.lblMobile.BackColor = Color.Transparent;
    this.lblMobile.Location = new Point(305, 56);
    this.lblMobile.Name = "lblMobile";
    this.lblMobile.Size = new Size(41, 13);
    this.lblMobile.TabIndex = 8;
    this.lblMobile.Text = "Mobile:";
    this.lblMobile.TextAlign = ContentAlignment.MiddleLeft;
    this.lblEmail.AutoSize = true;
    this.lblEmail.BackColor = Color.Transparent;
    this.lblEmail.Location = new Point(305, 81);
    this.lblEmail.Name = "lblEmail";
    this.lblEmail.Size = new Size(35, 13);
    this.lblEmail.TabIndex = 9;
    this.lblEmail.Text = "Email:";
    this.lblEmail.TextAlign = ContentAlignment.MiddleLeft;
    ((AppearanceBase) appearance16).BackColor = Color.White;
    ((AppearanceBase) appearance16).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance16).ForeColor = Color.Black;
    ((TextEditorControlBase) this.mgaTxtEmail).Appearance = (AppearanceBase) appearance16;
    ((Control) this.mgaTxtEmail).BackColor = Color.White;
    ((Control) this.mgaTxtEmail).Location = new Point(346, 78);
    ((TextEditorControlBase) this.mgaTxtEmail).MaxLength = 75;
    this.mgaTxtEmail.MGAStyle = MGAStyles.Blue;
    ((Control) this.mgaTxtEmail).Name = "mgaTxtEmail";
    ((Control) this.mgaTxtEmail).Size = new Size(206, 19);
    ((Control) this.mgaTxtEmail).TabIndex = 10;
    ((UltraControlBase) this.mgaTxtEmail).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.mgaTxtEmail).UseOsThemes = (DefaultableBoolean) 2;
    this.txtMobile.EditAs = (EditAsType) 1;
    this.txtMobile.InputMask = "(###) ###-####";
    ((Control) this.txtMobile).Location = new Point(346, 49);
    ((Control) this.txtMobile).Name = "txtMobile";
    ((Control) this.txtMobile).Size = new Size(100, 20);
    ((Control) this.txtMobile).TabIndex = 11;
    ((Control) this.txtMobile).Text = "() -";
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    this.ClientSize = new Size(581, 507);
    this.Controls.Add((Control) this.grbInterest);
    this.Controls.Add((Control) this.dbSave);
    this.Controls.Add((Control) this.gridAdditionalInterests);
    this.Name = nameof (FormAdditionalInterestsAdmin);
    this.Text = "Additional Interests Administration";
    this.Load += new EventHandler(this.FormAdditionalInterestsAdmin_Load);
    ((ISupportInitialize) this.grbInterest).EndInit();
    ((Control) this.grbInterest).ResumeLayout(false);
    ((Control) this.grbInterest).PerformLayout();
    ((ISupportInitialize) this.txtInterestName).EndInit();
    ((ISupportInitialize) this.err).EndInit();
    ((ISupportInitialize) this.gridAdditionalInterests).EndInit();
    this.ds.EndInit();
    ((ISupportInitialize) this.mgaTxtEmail).EndInit();
    this.ResumeLayout(false);
  }
}
