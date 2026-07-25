// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Underwriting.Risk_Meter.FormRiskMeter
// Assembly: MGASystems.IMS.Underwriting, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 1057C5B8-8299-4767-8242-AF9F1EF932DB
// Assembly location: D:\augusta\fortegra\IMS Project\MGASystems.IMS.Underwriting.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using MGASystems.AddressResolver;
using MGASystems.BusinessObjects;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.IMS.Logging.Administration;
using MGASystems.Tools;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Underwriting.Risk_Meter;

[LogCategory("Underwriting.RiskMeter.RiskMeterWebRequests", "Underwriting.RiskMeter.RiskMeterWebRequests")]
[SecureResource("{4A685563-11FB-4814-94AC-12789925FB04}", "Run Risk Meter", "Allows the user to run Risk Meter Web Service.", "Policy")]
public class FormRiskMeter : Form
{
  private readonly Guid _quoteGuid = Guid.Empty;
  private string _invalidChar;
  private string _riskMeterUrl;
  private string _riskMeterPassword;
  private string _riskMeterUserName;
  internal const string LogKey = "Underwriting.RiskMeter.RiskMeterWebRequests";
  public const string CAN_RUN_RISK_METER = "{4A685563-11FB-4814-94AC-12789925FB04}";
  private IContainer components;
  private MGAGroupBox grpAddressDetails;
  internal LinkLabel lnkUseCurrentLocation;
  protected MGA_ZipCodeResolver ZipAddress;
  private dsRiskMeter ds;
  private ErrorProvider err;
  private MGAButton btnSubmit;
  protected UltraGrid ugLocations;
  private SqlConnection cn;
  private SqlDataAdapter da;
  private SqlCommand SqlDeleteCommand2;
  private SqlCommand SqlInsertCommand2;
  private SqlCommand SqlSelectCommand4;
  private SqlCommand SqlUpdateCommand2;

  public FormRiskMeter() => this.InitializeComponent();

  public FormRiskMeter(Guid quoteGuid)
  {
    this.InitializeComponent();
    this._quoteGuid = quoteGuid;
  }

  private void FormRiskMeter_Load(object sender, EventArgs e)
  {
    if (this.DesignMode)
      return;
    this._invalidChar = MGASystems.Common.Settings.SystemSettings.GetSetting<string>("RiskMeterInvalidChars", string.Empty);
    this._riskMeterUrl = MGASystems.Common.Settings.SystemSettings.GetSetting<string>("RiskMeterURL", string.Empty);
    this._riskMeterPassword = MGASystems.Common.Settings.SystemSettings.GetSetting<string>("RiskMeterURLpw", string.Empty);
    this._riskMeterUserName = MGASystems.Common.Settings.SystemSettings.GetSetting<string>("RiskMeterURLun", string.Empty);
    this.ZipAddress.AddressServiceURL = AddressResolverSettings.AddressResolverURL;
    this.ZipAddress.UserID = AddressResolverSettings.AddressResolveUserName;
    this.ZipAddress.Password = AddressResolverSettings.AddressResolverPassword;
    if (!this._quoteGuid.Equals(Guid.Empty))
      DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[1]
      {
        "dtLocations"
      }, CommandType.StoredProcedure, "dbo.GetRiskMeterLocations", new object[2]
      {
        (object) "@QuoteGuid",
        (object) this._quoteGuid
      });
    this.lnkUseCurrentLocation.Enabled = this.ds.dtLocations.Count > 0;
  }

  private bool ValidateData()
  {
    bool flag = true;
    if (this._riskMeterUrl.Equals(string.Empty))
    {
      int num = (int) MessageBox.Show("No URL is provided to access RiskMeter Online Application", "No URL Present", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      return false;
    }
    if (this._riskMeterPassword.Equals(string.Empty))
    {
      int num = (int) MessageBox.Show("No password is provided to access RiskMeter Online Application", "No Password Present", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      return false;
    }
    if (this._riskMeterUserName.Equals(string.Empty))
    {
      int num = (int) MessageBox.Show("No username is provided to access RiskMeter Online Application", "No User Name Present", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      return false;
    }
    if (flag)
      flag = this.ValidateAddress();
    return flag;
  }

  private bool ValidateAddress()
  {
    bool flag = true;
    this.err.SetError((Control) this.ZipAddress, string.Empty);
    if (this.ZipAddress.Street1.Replace(" ", string.Empty).Length == 0)
    {
      this.err.SetError((Control) this.ZipAddress, "Please enter a street");
      flag = false;
    }
    if (this.ZipAddress.City.Replace(" ", string.Empty).Length == 0)
    {
      this.err.SetError((Control) this.ZipAddress, "Please enter a city");
      flag = false;
    }
    if (this.ZipAddress.State.Replace(" ", string.Empty).Length == 0)
    {
      this.err.SetError((Control) this.ZipAddress, "Please enter a state");
      flag = false;
    }
    if (flag)
    {
      string empty1 = string.Empty;
      if (this.HasInvalidChars(this.ZipAddress.City, ref empty1))
      {
        this.err.SetError((Control) this.ZipAddress, "Please remove the invalid character - " + empty1);
        return false;
      }
      string empty2 = string.Empty;
      if (this.HasInvalidChars(this.ZipAddress.State, ref empty2))
      {
        this.err.SetError((Control) this.ZipAddress, "Please remove the invalid character - " + empty2);
        return false;
      }
      string empty3 = string.Empty;
      if (this.HasInvalidChars(this.ZipAddress.Street1, ref empty3))
      {
        this.err.SetError((Control) this.ZipAddress, "Please remove the invalid character - " + empty3);
        return false;
      }
      string empty4 = string.Empty;
      if (this.HasInvalidChars(this.ZipAddress.ZipCode, ref empty4))
      {
        this.err.SetError((Control) this.ZipAddress, "Please remove the invalid character - " + empty4);
        return false;
      }
    }
    return flag;
  }

  private bool HasInvalidChars(string str, ref string invalStr)
  {
    bool flag = false;
    if (this._invalidChar.Equals(string.Empty) || str.Replace(" ", string.Empty).Length == 0)
      return false;
    char[] charArray = this._invalidChar.ToCharArray();
    for (int index = 0; index < charArray.Length - 1; ++index)
    {
      if (str.Contains(charArray[index].ToString()))
      {
        invalStr = charArray[index].ToString();
        return true;
      }
    }
    return flag;
  }

  private void ZipAddress_StateChanged(object sender, EventArgs e)
  {
  }

  private void EmptyZip()
  {
    this.ZipAddress.Street1 = string.Empty;
    this.ZipAddress.Street2 = string.Empty;
    this.ZipAddress.City = string.Empty;
    this.ZipAddress.State = string.Empty;
    this.ZipAddress.ZipCode = string.Empty;
    this.ZipAddress.ZipCodeExtension = string.Empty;
  }

  private void lnkUseCurrentLocation_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    if (((UltraGridBase) this.ugLocations).ActiveRow == null)
    {
      int num = (int) MessageBox.Show("Please select a row in the grid.", "No Row Selected", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    else
    {
      dsRiskMeter.dtLocationsRow byLocationId = this.ds.dtLocations.FindByLocationID((int) ((UltraGridBase) this.ugLocations).ActiveRow.Cells["LocationID"].Value);
      if (byLocationId == null)
        return;
      this.AssignAddressFromLocation(byLocationId);
      this.ZipAddress_StateChanged((object) null, (EventArgs) null);
    }
  }

  private void AssignAddressFromLocation(dsRiskMeter.dtLocationsRow row)
  {
    if (!row.IsStreetNull())
      this.ZipAddress.Street1 = row.Street;
    if (!row.IsCityNull())
      this.ZipAddress.City = row.City;
    if (!row.IsStateNull())
      this.ZipAddress.State = row.State;
    if (!row.IsZipNull())
      this.ZipAddress.ZipCode = row.Zip;
    if (row.IsZipPlusNull())
      return;
    this.ZipAddress.ZipCodeExtension = row.ZipPlus;
  }

  private void btnSubmit_Click(object sender, EventArgs e)
  {
    if (!this.ValidateData())
      return;
    try
    {
      this.Cursor = MgaCursors.WaitCursor;
      this.OnSubmit(new Quote(this._quoteGuid));
    }
    finally
    {
      this.Cursor = MgaCursors.Default;
    }
  }

  protected virtual void OnSubmit(Quote quote)
  {
    string address = this.BuildAddressString();
    this._riskMeterUrl += address;
    this._riskMeterUrl = $"{this._riskMeterUrl}&UserName={this._riskMeterUserName}&Password={this._riskMeterPassword}";
    FormRiskImage formRiskImage = new FormRiskImage(this._quoteGuid, this._riskMeterUrl, address);
    formRiskImage.TopLevel = true;
    formRiskImage.ShowInTaskbar = true;
    formRiskImage.BringToFront();
    formRiskImage.Show();
  }

  private string BuildAddressString()
  {
    string str = $"{$"{"Address= " + this.ZipAddress.Street1.Replace(" ", "+")}&City={this.ZipAddress.City.Replace(" ", "+")}"}&State={this.ZipAddress.State}";
    if (this.ZipAddress.ZipCode.Length > 0)
      str = $"{str}&Zip={this.ZipAddress.ZipCode.Replace(" ", string.Empty)}";
    return str;
  }

  private void ugLocations_AfterRowActivate(object sender, EventArgs e)
  {
    this.EmptyZip();
    if (((UltraGridBase) this.ugLocations).ActiveRow == null)
      return;
    this.AssignAddressFromLocation(this.ds.dtLocations.FindByLocationID((int) ((UltraGridBase) this.ugLocations).ActiveRow.Cells["LocationID"].Value));
  }

  private void lnkPreviousSub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    int num = (int) new FormRiskMeterPrev(new Quote(this._quoteGuid).QuoteID).ShowDialog();
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
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (FormRiskMeter));
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    UltraGridBand ultraGridBand = new UltraGridBand("dtLocations", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("Street");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("City");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("State");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("Zip");
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("ZipPlus");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("LocationID");
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("LocStatus");
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("LocationNo");
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("Type");
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("BuildingNo");
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    Appearance appearance11 = new Appearance();
    Appearance appearance12 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    this.grpAddressDetails = new MGAGroupBox();
    this.lnkUseCurrentLocation = new LinkLabel();
    this.ZipAddress = new MGA_ZipCodeResolver();
    this.err = new ErrorProvider(this.components);
    this.btnSubmit = new MGAButton();
    this.ugLocations = new UltraGrid();
    this.ds = new dsRiskMeter();
    this.cn = new SqlConnection();
    this.da = new SqlDataAdapter();
    this.SqlDeleteCommand2 = new SqlCommand();
    this.SqlInsertCommand2 = new SqlCommand();
    this.SqlSelectCommand4 = new SqlCommand();
    this.SqlUpdateCommand2 = new SqlCommand();
    ((ISupportInitialize) this.grpAddressDetails).BeginInit();
    ((Control) this.grpAddressDetails).SuspendLayout();
    ((ISupportInitialize) this.err).BeginInit();
    ((ISupportInitialize) this.btnSubmit).BeginInit();
    ((ISupportInitialize) this.ugLocations).BeginInit();
    this.ds.BeginInit();
    this.SuspendLayout();
    ((AppearanceBase) appearance1).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.grpAddressDetails.Appearance = (AppearanceBase) appearance1;
    ((AppearanceBase) appearance2).BackColor = Color.FromArgb(239, 247, 253);
    ((AppearanceBase) appearance2).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.grpAddressDetails.ContentAreaAppearance = (AppearanceBase) appearance2;
    ((Control) this.grpAddressDetails).Controls.Add((Control) this.lnkUseCurrentLocation);
    ((Control) this.grpAddressDetails).Controls.Add((Control) this.ZipAddress);
    ((AppearanceBase) appearance3).AlphaLevel = (short) 230;
    ((AppearanceBase) appearance3).FontData.SizeInPoints = 10f;
    ((AppearanceBase) appearance3).ForeColor = Color.White;
    ((AppearanceBase) appearance3).ForegroundAlpha = (Alpha) 2;
    ((AppearanceBase) appearance3).ImageAlpha = (Alpha) 2;
    ((AppearanceBase) appearance3).ImageBackground = (Image) componentResourceManager.GetObject("Appearance14.ImageBackground");
    ((AppearanceBase) appearance3).ImageBackgroundStyle = (ImageBackgroundStyle) 3;
    this.grpAddressDetails.HeaderAppearance = (AppearanceBase) appearance3;
    ((Control) this.grpAddressDetails).Location = new Point(114, 175);
    ((Control) this.grpAddressDetails).Name = "grpAddressDetails";
    ((Control) this.grpAddressDetails).Size = new Size(415, 208 /*0xD0*/);
    ((Control) this.grpAddressDetails).TabIndex = 253;
    ((Control) this.grpAddressDetails).Text = "Address";
    this.grpAddressDetails.ViewStyle = (GroupBoxViewStyle) 2;
    this.lnkUseCurrentLocation.AutoSize = true;
    this.lnkUseCurrentLocation.BackColor = Color.Transparent;
    this.lnkUseCurrentLocation.Location = new Point(28, 35);
    this.lnkUseCurrentLocation.Name = "lnkUseCurrentLocation";
    this.lnkUseCurrentLocation.Size = new Size(175, 13);
    this.lnkUseCurrentLocation.TabIndex = 250;
    this.lnkUseCurrentLocation.TabStop = true;
    this.lnkUseCurrentLocation.Text = "Default Current Location to Address";
    this.lnkUseCurrentLocation.LinkClicked += new LinkLabelLinkClickedEventHandler(this.lnkUseCurrentLocation_LinkClicked);
    this.ZipAddress.AddressServiceURL = "";
    this.ZipAddress.AutoScrollMargin = new Size(0, 0);
    this.ZipAddress.AutoScrollMinSize = new Size(0, 0);
    ((Control) this.ZipAddress).BackColor = Color.Transparent;
    this.ZipAddress.City = "";
    this.ZipAddress.County = "";
    this.ZipAddress.GeoRegion = "";
    this.ZipAddress.LabelAlignment = ContentAlignment.TopLeft;
    ((Control) this.ZipAddress).Location = new Point(31 /*0x1F*/, 64 /*0x40*/);
    this.ZipAddress.MGAStyle = MGAStyles.Blue;
    ((Control) this.ZipAddress).Name = "ZipAddress";
    this.ZipAddress.Password = "";
    ((Control) this.ZipAddress).Size = new Size(295, 114);
    this.ZipAddress.State = "";
    this.ZipAddress.Street1 = "";
    this.ZipAddress.Street2 = "";
    ((Control) this.ZipAddress).TabIndex = 249;
    this.ZipAddress.UserID = "";
    this.ZipAddress.ZipCode = "";
    this.ZipAddress.ZipCodeExtension = "";
    this.ZipAddress.StateChanged += new EventHandler(this.ZipAddress_StateChanged);
    this.err.ContainerControl = (ContainerControl) this;
    ((Control) this.btnSubmit).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    ((AppearanceBase) appearance4).BackColor = Color.White;
    ((AppearanceBase) appearance4).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance4).Image = componentResourceManager.GetObject("Appearance1.Image");
    ((ControlBase) this.btnSubmit).Appearance = (AppearanceBase) appearance4;
    ((ControlBase) this.btnSubmit).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnSubmit).Location = new Point(574, 380);
    ((Control) this.btnSubmit).Name = "btnSubmit";
    ((ControlBase) this.btnSubmit).Padding = new Size(5, 0);
    ((Control) this.btnSubmit).Size = new Size(96 /*0x60*/, 33);
    ((Control) this.btnSubmit).TabIndex = 256 /*0x0100*/;
    ((Control) this.btnSubmit).Text = "Submit";
    ((UltraControlBase) this.btnSubmit).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.btnSubmit).Click += new EventHandler(this.btnSubmit_Click);
    ((Control) this.ugLocations).Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    ((Control) this.ugLocations).Cursor = Cursors.Hand;
    ((UltraGridBase) this.ugLocations).DataMember = "dtLocations";
    ((UltraGridBase) this.ugLocations).DataSource = (object) this.ds;
    ((AppearanceBase) appearance5).BackColor = Color.White;
    ((AppearanceBase) appearance5).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.ugLocations).DisplayLayout.Appearance = (AppearanceBase) appearance5;
    ((UltraGridBase) this.ugLocations).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn1.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn1.Header).VisiblePosition = 2;
    ultraGridColumn1.Width = 140;
    ultraGridColumn2.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn2.Header).VisiblePosition = 3;
    ultraGridColumn2.Width = 130;
    ultraGridColumn3.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn3.Header).VisiblePosition = 4;
    ultraGridColumn3.Width = 45;
    ultraGridColumn4.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn4.Header).VisiblePosition = 5;
    ultraGridColumn4.Width = 63 /*0x3F*/;
    ultraGridColumn5.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn5.Header).VisiblePosition = 6;
    ultraGridColumn5.Hidden = true;
    ultraGridColumn5.Width = 79;
    ultraGridColumn6.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn6.Header).VisiblePosition = 7;
    ultraGridColumn6.Hidden = true;
    ultraGridColumn6.Width = 48 /*0x30*/;
    ultraGridColumn7.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn7.Header).Caption = "Status";
    ((HeaderBase) ultraGridColumn7.Header).VisiblePosition = 8;
    ultraGridColumn7.Width = 57;
    ultraGridColumn8.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn8.Header).Caption = "Loc #";
    ((HeaderBase) ultraGridColumn8.Header).VisiblePosition = 0;
    ultraGridColumn8.Width = 46;
    ultraGridColumn9.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn9.Header).VisiblePosition = 9;
    ultraGridColumn9.Width = 71;
    ultraGridColumn10.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn10.Header).Caption = "Bldg # ";
    ((HeaderBase) ultraGridColumn10.Header).VisiblePosition = 1;
    ultraGridColumn10.Width = 85;
    ultraGridBand.Columns.AddRange(new object[10]
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
      (object) ultraGridColumn10
    });
    ((UltraGridBase) this.ugLocations).DisplayLayout.BandsSerializer.Add((object) ultraGridBand);
    ((UltraGridBase) this.ugLocations).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((AppearanceBase) appearance6).BackColor = Color.LightSteelBlue;
    ((AppearanceBase) appearance6).FontData.SizeInPoints = 10f;
    ((AppearanceBase) appearance6).ForeColor = Color.Black;
    ((UltraGridBase) this.ugLocations).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance6;
    ((AppearanceBase) appearance7).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance7).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance7).ForeColor = Color.Black;
    ((UltraGridBase) this.ugLocations).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance7;
    ((UltraGridBase) this.ugLocations).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.ugLocations).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 1;
    ((UltraGridBase) this.ugLocations).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 1;
    ((AppearanceBase) appearance8).BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugLocations).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance8;
    ((UltraGridBase) this.ugLocations).DisplayLayout.Override.CellClickAction = (CellClickAction) 1;
    ((AppearanceBase) appearance9).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.ugLocations).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance9;
    ((UltraGridBase) this.ugLocations).DisplayLayout.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance10).BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.ugLocations).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance10;
    ((AppearanceBase) appearance11).BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugLocations).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance11;
    ((UltraGridBase) this.ugLocations).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 1;
    ((AppearanceBase) appearance12).BackColor = Color.Transparent;
    ((AppearanceBase) appearance12).ForeColor = Color.Black;
    ((UltraGridBase) this.ugLocations).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance12;
    ((UltraGridBase) this.ugLocations).DisplayLayout.Override.SelectTypeCell = (SelectType) 2;
    scrollBarLook.ViewStyle = (ScrollBarViewStyle) 3;
    ((UltraGridBase) this.ugLocations).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((Control) this.ugLocations).Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.ugLocations).Location = new Point(14, 12);
    ((Control) this.ugLocations).Name = "ugLocations";
    ((Control) this.ugLocations).Size = new Size(658, 157);
    ((Control) this.ugLocations).TabIndex = 258;
    ((Control) this.ugLocations).Text = "Available Locations";
    ((UltraControlBase) this.ugLocations).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.ugLocations).UseOsThemes = (DefaultableBoolean) 2;
    this.ugLocations.AfterRowActivate += new EventHandler(this.ugLocations_AfterRowActivate);
    this.ds.DataSetName = "dsRiskMeter";
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.cn.ConnectionString = "Data Source=MGASYSTEMS;Initial Catalog=IMS;Integrated Security=True";
    this.cn.FireInfoMessageEventOnUserErrors = false;
    this.da.DeleteCommand = this.SqlDeleteCommand2;
    this.da.InsertCommand = this.SqlInsertCommand2;
    this.da.SelectCommand = this.SqlSelectCommand4;
    this.da.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblQuoteRiskMeterResults", new DataColumnMapping[4]
      {
        new DataColumnMapping("ID", "ID"),
        new DataColumnMapping("QuoteID", "QuoteID"),
        new DataColumnMapping("Item", "Item"),
        new DataColumnMapping("ItemResults", "ItemResults")
      })
    });
    this.da.UpdateCommand = this.SqlUpdateCommand2;
    this.SqlDeleteCommand2.CommandText = "DELETE FROM [dbo].[tblQuoteRiskMeterResults] WHERE (([ID] = @Original_ID))";
    this.SqlDeleteCommand2.Connection = this.cn;
    this.SqlDeleteCommand2.Parameters.AddRange(new SqlParameter[1]
    {
      new SqlParameter("@Original_ID", SqlDbType.Int, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "ID", DataRowVersion.Original, (object) null)
    });
    this.SqlInsertCommand2.CommandText = componentResourceManager.GetString("SqlInsertCommand2.CommandText");
    this.SqlInsertCommand2.Connection = this.cn;
    this.SqlInsertCommand2.Parameters.AddRange(new SqlParameter[3]
    {
      new SqlParameter("@QuoteID", SqlDbType.Int, 0, "QuoteID"),
      new SqlParameter("@Item", SqlDbType.VarChar, 0, "Item"),
      new SqlParameter("@ItemResults", SqlDbType.VarChar, 0, "ItemResults")
    });
    this.SqlSelectCommand4.CommandText = "SELECT     ID, QuoteID, Item, ItemResults\r\nFROM         dbo.tblQuoteRiskMeterResults";
    this.SqlSelectCommand4.Connection = this.cn;
    this.SqlUpdateCommand2.CommandText = componentResourceManager.GetString("SqlUpdateCommand2.CommandText");
    this.SqlUpdateCommand2.Connection = this.cn;
    this.SqlUpdateCommand2.Parameters.AddRange(new SqlParameter[5]
    {
      new SqlParameter("@QuoteID", SqlDbType.Int, 0, "QuoteID"),
      new SqlParameter("@Item", SqlDbType.VarChar, 0, "Item"),
      new SqlParameter("@ItemResults", SqlDbType.VarChar, 0, "ItemResults"),
      new SqlParameter("@Original_ID", SqlDbType.Int, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "ID", DataRowVersion.Original, (object) null),
      new SqlParameter("@ID", SqlDbType.Int, 4, "ID")
    });
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    this.ClientSize = new Size(682, 425);
    this.Controls.Add((Control) this.ugLocations);
    this.Controls.Add((Control) this.btnSubmit);
    this.Controls.Add((Control) this.grpAddressDetails);
    this.Name = nameof (FormRiskMeter);
    this.Text = "Risk Meter Administration";
    this.Load += new EventHandler(this.FormRiskMeter_Load);
    ((ISupportInitialize) this.grpAddressDetails).EndInit();
    ((Control) this.grpAddressDetails).ResumeLayout(false);
    ((Control) this.grpAddressDetails).PerformLayout();
    ((ISupportInitialize) this.err).EndInit();
    ((ISupportInitialize) this.btnSubmit).EndInit();
    ((ISupportInitialize) this.ugLocations).EndInit();
    this.ds.EndInit();
    this.ResumeLayout(false);
  }
}
