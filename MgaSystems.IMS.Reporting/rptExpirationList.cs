// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Reporting.rptExpirationList
// Assembly: MgaSystems.IMS.Reporting, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D0217E27-C87B-4FD0-8041-819EA70A118B
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Reporting.dll

using DDCssLib;
using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.Document.Section;
using GrapeCity.ActiveReports.SectionReportModel;
using GrapeCity.ActiveReports.Viewer.Win;
using MGASystems.Common;
using MGASystems.Common.BroadcastMessaging;
using MGASystems.Data;
using MGASystems.IMS.Reporting.ReportControls;
using MGASystems.IMS.Security;
using MGASystems.Tools;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.Reporting;

[SecureReportResource("{A3F787E6-4611-464e-9F5A-76F83200EA98}", "Expiration List", "Expiration List Report.", "General")]
[SecureResource("{C3353D0F-5206-4ed8-86F4-DAC33F2E24AC}", "Expiration List Report User Access to Underwriters", "Allows user to run report for any/all underwriters.", "Reports")]
[SecureResource("{1841D651-9C8A-444d-92EC-503F074C390C}", "Expiration List Report User Access to In-House Producers", "Allows user to run report for any/all in-house producers.", "Reports")]
[SecureResource("{E3ABCDE6-7FAA-46BE-8B9B-9A291963BBE9}", "Expiration List Report User Access to TA/CSR", "Allows user to run report for any/all TA/CSR users.", "Reports")]
public class rptExpirationList : MGAReport, IReport
{
  internal const string SecurityIDReportGuid = "{A3F787E6-4611-464e-9F5A-76F83200EA98}";
  internal const string SecurityIDAllUsers = "{C3353D0F-5206-4ed8-86F4-DAC33F2E24AC}";
  internal const string SecurityIDInHouseProducerAllUsers = "{1841D651-9C8A-444d-92EC-503F074C390C}";
  internal const string SecurityIDTACSRAllUsers = "{E3ABCDE6-7FAA-46BE-8B9B-9A291963BBE9}";
  private Label Label1;
  private Label Label3;
  private Label Label4;
  private Label Label5;
  private Label Label6;
  private Label Label7;
  private Label Label8;
  private Label Label9;
  private Label Label10;
  private Label Label11;
  private Label Label12;
  private Label Label13;
  private Label Label14;
  private Label Label15;
  private Label Label16;
  private Label Label17;
  private Label Label19;
  private Label Label20;
  private Label Label21;
  private Label Label22;
  private Label Label23;
  private Label Label24;
  private Label Label25;
  private TextBox txtMonthAndYear;
  private Label Month;
  private Label Year;
  private Label Label;
  private Label Label2;
  private Label Label18;
  private Label Label27;
  private Label Label28;
  private Label Label29;
  private Label Label30;
  private Label Label31;
  private Label Label32;
  private Label Label33;
  private Label Label34;
  private Label Label35;
  protected TextBox txtInsured;
  private TextBox txtBroker;
  private TextBox txtEffDate;
  private TextBox txtCarrier;
  private TextBox txtProd;
  private TextBox txtPremium;
  private TextBox txtLines;
  private TextBox txtStatus;
  private TextBox TextBox;
  private TextBox TextBox1;
  private TextBox TextBox2;
  protected TextBox TextBox3;
  private Label Label26;
  private readonly string _ProducerGuids;
  private Guid _CompanyLocationGuid;
  private readonly string _UnderwriterGuid;
  private readonly Guid _InHouseProducerGuid;
  private readonly Guid _TACSRUserGuid;
  private readonly DateTime _datFrom;
  private readonly DateTime _datTo;
  private readonly bool _IncludeNonRenewed;
  private DataTable _dt;
  private Guid _coverageLine;
  private readonly int _CostCenterID;
  private readonly int _groupID;
  private readonly Decimal _premium;
  private readonly Decimal _totalPremiumFrom;
  private readonly Decimal _totalPremiumTo;
  private readonly bool _HideRenewals;
  private Guid _CompanyGroupGUID;
  private Guid _clientOfficeGuid;

  [field: AccessedThroughProperty("TextBox4")]
  private virtual TextBox TextBox4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox5")]
  private virtual TextBox TextBox5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label36")]
  private virtual Label Label36 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label37")]
  private virtual Label Label37 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label38")]
  private virtual Label Label38 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label39")]
  private virtual Label Label39 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label40")]
  private virtual Label Label40 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label41")]
  private virtual Label Label41 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox6")]
  private virtual TextBox TextBox6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox7")]
  private virtual TextBox TextBox7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox8")]
  private virtual TextBox TextBox8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox9")]
  private virtual TextBox TextBox9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label42")]
  private virtual Label Label42 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label43")]
  private virtual Label Label43 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label44")]
  private virtual Label Label44 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox10")]
  private virtual TextBox TextBox10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblRenewalControlno")]
  private virtual TextBox lblRenewalControlno { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblBottomRenewalControlno")]
  private virtual Label lblBottomRenewalControlno { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblMiddleRenewalControlno")]
  private virtual Label lblMiddleRenewalControlno { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblTopRenewalControlno")]
  private virtual Label lblTopRenewalControlno { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblRenewalStatus")]
  private virtual TextBox lblRenewalStatus { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblTopRenewalStatus")]
  private virtual Label lblTopRenewalStatus { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblMiddleRenewalStatus")]
  private virtual Label lblMiddleRenewalStatus { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblBottomRenewalStatus")]
  private virtual Label lblBottomRenewalStatus { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox11")]
  private virtual TextBox TextBox11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label45")]
  private virtual Label Label45 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label46")]
  private virtual Label Label46 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label47")]
  private virtual Label Label47 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ghYear")]
  private virtual GroupHeader ghYear { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual GroupHeader ghMonth
  {
    get => this._ghMonth;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler1 = new EventHandler(this.ghMonth_BeforePrint);
      EventHandler eventHandler2 = new EventHandler(this.ghMonth_Format);
      GroupHeader ghMonth1 = this._ghMonth;
      if (ghMonth1 != null)
      {
        ((GrapeCity.ActiveReports.SectionReportModel.Section) ghMonth1).BeforePrint -= eventHandler1;
        ((GrapeCity.ActiveReports.SectionReportModel.Section) ghMonth1).Format -= eventHandler2;
      }
      this._ghMonth = value;
      GroupHeader ghMonth2 = this._ghMonth;
      if (ghMonth2 == null)
        return;
      ((GrapeCity.ActiveReports.SectionReportModel.Section) ghMonth2).BeforePrint += eventHandler1;
      ((GrapeCity.ActiveReports.SectionReportModel.Section) ghMonth2).Format += eventHandler2;
    }
  }

  private virtual Detail Detail
  {
    get => this._Detail;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.Detail_BeforePrint);
      Detail detail1 = this._Detail;
      if (detail1 != null)
        ((GrapeCity.ActiveReports.SectionReportModel.Section) detail1).BeforePrint -= eventHandler;
      this._Detail = value;
      Detail detail2 = this._Detail;
      if (detail2 == null)
        return;
      ((GrapeCity.ActiveReports.SectionReportModel.Section) detail2).BeforePrint += eventHandler;
    }
  }

  private virtual GroupFooter gfMonth
  {
    get => this._gfMonth;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.gfMonth_Format);
      GroupFooter gfMonth1 = this._gfMonth;
      if (gfMonth1 != null)
        ((GrapeCity.ActiveReports.SectionReportModel.Section) gfMonth1).Format -= eventHandler;
      this._gfMonth = value;
      GroupFooter gfMonth2 = this._gfMonth;
      if (gfMonth2 == null)
        return;
      ((GrapeCity.ActiveReports.SectionReportModel.Section) gfMonth2).Format += eventHandler;
    }
  }

  [field: AccessedThroughProperty("gfYear")]
  private virtual GroupFooter gfYear { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  public rptExpirationList()
  {
    this.ReportStart += new EventHandler(this.rptExpirationList_ReportStart);
    this._dt = new DataTable();
  }

  public rptExpirationList(
    string ProducerGuids,
    Guid CompanyLocationGuid,
    Guid CompanyGroupGUID,
    string UnderwriterGuid,
    Guid TACSRUserGuid,
    int CostCenterID,
    Guid CoverageLine,
    int GroupID,
    Guid ClientOfficeGuid,
    Guid InHouseProducerGuid,
    DateTime datFrom,
    DateTime datTo,
    bool IncludeNonRenewed,
    Decimal Premium,
    Decimal TotalPremiumFrom,
    Decimal TotalPremiumTo,
    bool HideRenewals)
  {
    this.ReportStart += new EventHandler(this.rptExpirationList_ReportStart);
    this._dt = new DataTable();
    this.InitializeComponent();
    this._ProducerGuids = ProducerGuids;
    this._CompanyLocationGuid = CompanyLocationGuid;
    this._CompanyGroupGUID = CompanyGroupGUID;
    this._UnderwriterGuid = UnderwriterGuid;
    this._TACSRUserGuid = TACSRUserGuid;
    this._CostCenterID = CostCenterID;
    this._coverageLine = CoverageLine;
    this._groupID = GroupID;
    this._clientOfficeGuid = ClientOfficeGuid;
    this._InHouseProducerGuid = InHouseProducerGuid;
    this._datFrom = datFrom;
    this._datTo = datTo;
    this._IncludeNonRenewed = IncludeNonRenewed;
    this._premium = Premium;
    this._totalPremiumFrom = TotalPremiumFrom;
    this._totalPremiumTo = TotalPremiumTo;
    this._HideRenewals = HideRenewals;
  }

  private void Detail_BeforePrint(object sender, EventArgs e) => this.DetailBeforePrint();

  private void ghMonth_BeforePrint(object sender, EventArgs e)
  {
    this.txtMonthAndYear.Text = $"{this.Month.Text} - {this.Year.Text}";
  }

  private void gfMonth_Format(object sender, EventArgs e)
  {
    if (Decimal.Compare(Decimal.Parse(this.TextBox8.Value.ToString(), NumberStyles.Currency), 0M) == 0)
      this.TextBox10.Text = Strings.FormatPercent((object) 0);
    else
      this.TextBox10.Text = Strings.FormatPercent((object) Decimal.Divide(Decimal.Parse(this.TextBox7.Value.ToString(), NumberStyles.Currency), Decimal.Parse(this.TextBox8.Value.ToString(), NumberStyles.Currency)));
  }

  private ArrayList getParams()
  {
    ArrayList arrayList = new ArrayList();
    if (this._ProducerGuids.Length > 0)
    {
      arrayList.Add((object) "@ProducerGuids");
      arrayList.Add((object) this._ProducerGuids);
    }
    if (!this._CompanyLocationGuid.Equals(Guid.Empty))
    {
      arrayList.Add((object) "@CompanyLocationGuid");
      arrayList.Add((object) this._CompanyLocationGuid);
    }
    if (!this._CompanyGroupGUID.Equals(Guid.Empty))
    {
      arrayList.Add((object) "@CompanyGroupGuid");
      arrayList.Add((object) this._CompanyGroupGUID);
    }
    if (!this._TACSRUserGuid.Equals(Guid.Empty))
      arrayList.AddRange((ICollection) new object[2]
      {
        (object) "@TACSRUserGuid",
        (object) this._TACSRUserGuid
      });
    if (!this._UnderwriterGuid.Equals((object) Guid.Empty))
    {
      arrayList.Add((object) "@UnderwriterGuids");
      arrayList.Add((object) this._UnderwriterGuid);
    }
    if (this._CostCenterID != -1)
    {
      arrayList.Add((object) "@CostCenterID");
      arrayList.Add((object) this._CostCenterID);
    }
    if (!this._coverageLine.Equals(Guid.Empty))
    {
      arrayList.Add((object) "@LineGUID");
      arrayList.Add((object) this._coverageLine);
    }
    if (!this._clientOfficeGuid.Equals(Guid.Empty))
    {
      arrayList.Add((object) "@ClientOfficeGuid");
      arrayList.Add((object) this._clientOfficeGuid);
    }
    if (this._groupID != -1)
    {
      arrayList.Add((object) "@DepartmentID");
      arrayList.Add((object) this._groupID);
    }
    if (!this._InHouseProducerGuid.Equals(Guid.Empty))
    {
      arrayList.Add((object) "@InHouseProducerGuid");
      arrayList.Add((object) this._InHouseProducerGuid);
    }
    arrayList.Add((object) "@DateFrom");
    arrayList.Add((object) this._datFrom);
    arrayList.Add((object) "@DateTo");
    arrayList.Add((object) this._datTo);
    arrayList.Add((object) "@IncludeNonRenewed");
    arrayList.Add((object) this._IncludeNonRenewed);
    arrayList.Add((object) "@Premium");
    if (Decimal.Compare(this._premium, 0M) == 0)
      arrayList.Add((object) 0);
    else
      arrayList.Add((object) this._premium);
    arrayList.Add((object) "@totalpremiumfrom");
    if (Decimal.Compare(this._totalPremiumFrom, 0M) == 0)
      arrayList.Add((object) 0);
    else
      arrayList.Add((object) this._totalPremiumFrom);
    arrayList.Add((object) "@totalpremiumto");
    if (Decimal.Compare(this._totalPremiumTo, 0M) == 0)
      arrayList.Add((object) 0);
    else
      arrayList.Add((object) this._totalPremiumTo);
    arrayList.Add((object) "@HideRenewals");
    arrayList.Add((object) this._HideRenewals);
    if (SystemSettings.KeyExists("CheckQuotingOfficeGuid") && SystemSettings.GetBoolSetting("CheckQuotingOfficeGuid") && !this.CurrentUserGuid.Equals((object) string.Empty))
    {
      arrayList.Add((object) "@CurrentUserGuid");
      arrayList.Add((object) this.CurrentUserGuid);
    }
    return arrayList;
  }

  protected virtual void DetailBeforePrint()
  {
    if (this.TextBox3.Text != null)
      this.TextBox3.HyperLink = this.TextBox3.Text.ToString();
    this.SetDetailControlsHeight();
  }

  private void rptExpirationList_ReportStart(object sender, EventArgs e)
  {
    this.BouncingProgress(true);
    this._dt = DefaultDatabase.ExecuteDataTable(CommandType.StoredProcedure, nameof (rptExpirationList), 0, (CommandArgumentType) 0, this.getParams().ToArray());
    this.DataSource = (object) this._dt;
    this._dt.Columns.Add("Month", typeof (string));
    this._dt.Columns.Add("Year", typeof (string));
    try
    {
      foreach (DataRow row in this._dt.Rows)
      {
        row["Month"] = (object) Conversions.ToDate(row["ExpirationDate"]).ToString("MMMM");
        row["Year"] = (object) Conversions.ToDate(row["ExpirationDate"]).ToString("yyyy");
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    if (!this._HideRenewals)
      return;
    ((ARControl) this.lblTopRenewalControlno).Visible = false;
    ((ARControl) this.lblMiddleRenewalControlno).Visible = false;
    ((ARControl) this.lblBottomRenewalControlno).Visible = false;
    ((ARControl) this.lblRenewalControlno).Visible = false;
    ((ARControl) this.lblTopRenewalStatus).Visible = false;
    ((ARControl) this.lblMiddleRenewalStatus).Visible = false;
    ((ARControl) this.lblBottomRenewalStatus).Visible = false;
    ((ARControl) this.lblRenewalStatus).Visible = false;
  }

  public override bool IsThreaded => true;

  public override void Hyperlink(object sender, HyperLinkEventArgs e)
  {
    Messaging.SendBroadcastMessage(BroadcastMessages.LaunchPolicyDetailScreen, (object) Conversions.ToInteger(e.HyperLink));
  }

  private void InitializeComponent()
  {
    ResourceManager resourceManager = new ResourceManager(typeof (rptExpirationList));
    this.Detail = new Detail();
    this.txtInsured = new TextBox();
    this.txtBroker = new TextBox();
    this.txtEffDate = new TextBox();
    this.txtCarrier = new TextBox();
    this.txtProd = new TextBox();
    this.txtPremium = new TextBox();
    this.txtLines = new TextBox();
    this.txtStatus = new TextBox();
    this.TextBox = new TextBox();
    this.TextBox1 = new TextBox();
    this.TextBox2 = new TextBox();
    this.TextBox3 = new TextBox();
    this.TextBox4 = new TextBox();
    this.TextBox5 = new TextBox();
    this.TextBox9 = new TextBox();
    this.lblRenewalControlno = new TextBox();
    this.lblRenewalStatus = new TextBox();
    this.TextBox11 = new TextBox();
    this.ghYear = new GroupHeader();
    this.gfYear = new GroupFooter();
    this.ghMonth = new GroupHeader();
    this.Label1 = new Label();
    this.Label3 = new Label();
    this.Label4 = new Label();
    this.Label5 = new Label();
    this.Label6 = new Label();
    this.Label7 = new Label();
    this.Label8 = new Label();
    this.Label9 = new Label();
    this.Label10 = new Label();
    this.Label11 = new Label();
    this.Label12 = new Label();
    this.Label13 = new Label();
    this.Label14 = new Label();
    this.Label15 = new Label();
    this.Label16 = new Label();
    this.Label17 = new Label();
    this.Label19 = new Label();
    this.Label20 = new Label();
    this.Label21 = new Label();
    this.Label22 = new Label();
    this.Label23 = new Label();
    this.Label24 = new Label();
    this.Label25 = new Label();
    this.txtMonthAndYear = new TextBox();
    this.Month = new Label();
    this.Year = new Label();
    this.Label = new Label();
    this.Label2 = new Label();
    this.Label18 = new Label();
    this.Label27 = new Label();
    this.Label28 = new Label();
    this.Label29 = new Label();
    this.Label30 = new Label();
    this.Label31 = new Label();
    this.Label32 = new Label();
    this.Label33 = new Label();
    this.Label34 = new Label();
    this.Label35 = new Label();
    this.Label36 = new Label();
    this.Label37 = new Label();
    this.Label38 = new Label();
    this.Label39 = new Label();
    this.Label40 = new Label();
    this.Label41 = new Label();
    this.Label42 = new Label();
    this.Label43 = new Label();
    this.Label44 = new Label();
    this.lblBottomRenewalControlno = new Label();
    this.lblMiddleRenewalControlno = new Label();
    this.lblTopRenewalControlno = new Label();
    this.lblTopRenewalStatus = new Label();
    this.lblMiddleRenewalStatus = new Label();
    this.lblBottomRenewalStatus = new Label();
    this.Label45 = new Label();
    this.Label46 = new Label();
    this.Label47 = new Label();
    this.gfMonth = new GroupFooter();
    this.Label26 = new Label();
    this.TextBox6 = new TextBox();
    this.TextBox7 = new TextBox();
    this.TextBox8 = new TextBox();
    this.TextBox10 = new TextBox();
    ((ISupportInitialize) this.txtInsured).BeginInit();
    ((ISupportInitialize) this.txtBroker).BeginInit();
    ((ISupportInitialize) this.txtEffDate).BeginInit();
    ((ISupportInitialize) this.txtCarrier).BeginInit();
    ((ISupportInitialize) this.txtProd).BeginInit();
    ((ISupportInitialize) this.txtPremium).BeginInit();
    ((ISupportInitialize) this.txtLines).BeginInit();
    ((ISupportInitialize) this.txtStatus).BeginInit();
    ((ISupportInitialize) this.TextBox).BeginInit();
    ((ISupportInitialize) this.TextBox1).BeginInit();
    ((ISupportInitialize) this.TextBox2).BeginInit();
    ((ISupportInitialize) this.TextBox3).BeginInit();
    ((ISupportInitialize) this.TextBox4).BeginInit();
    ((ISupportInitialize) this.TextBox5).BeginInit();
    ((ISupportInitialize) this.TextBox9).BeginInit();
    ((ISupportInitialize) this.lblRenewalControlno).BeginInit();
    ((ISupportInitialize) this.lblRenewalStatus).BeginInit();
    ((ISupportInitialize) this.TextBox11).BeginInit();
    ((ISupportInitialize) this.Label1).BeginInit();
    ((ISupportInitialize) this.Label3).BeginInit();
    ((ISupportInitialize) this.Label4).BeginInit();
    ((ISupportInitialize) this.Label5).BeginInit();
    ((ISupportInitialize) this.Label6).BeginInit();
    ((ISupportInitialize) this.Label7).BeginInit();
    ((ISupportInitialize) this.Label8).BeginInit();
    ((ISupportInitialize) this.Label9).BeginInit();
    ((ISupportInitialize) this.Label10).BeginInit();
    ((ISupportInitialize) this.Label11).BeginInit();
    ((ISupportInitialize) this.Label12).BeginInit();
    ((ISupportInitialize) this.Label13).BeginInit();
    ((ISupportInitialize) this.Label14).BeginInit();
    ((ISupportInitialize) this.Label15).BeginInit();
    ((ISupportInitialize) this.Label16).BeginInit();
    ((ISupportInitialize) this.Label17).BeginInit();
    ((ISupportInitialize) this.Label19).BeginInit();
    ((ISupportInitialize) this.Label20).BeginInit();
    ((ISupportInitialize) this.Label21).BeginInit();
    ((ISupportInitialize) this.Label22).BeginInit();
    ((ISupportInitialize) this.Label23).BeginInit();
    ((ISupportInitialize) this.Label24).BeginInit();
    ((ISupportInitialize) this.Label25).BeginInit();
    ((ISupportInitialize) this.txtMonthAndYear).BeginInit();
    ((ISupportInitialize) this.Month).BeginInit();
    ((ISupportInitialize) this.Year).BeginInit();
    ((ISupportInitialize) this.Label).BeginInit();
    ((ISupportInitialize) this.Label2).BeginInit();
    ((ISupportInitialize) this.Label18).BeginInit();
    ((ISupportInitialize) this.Label27).BeginInit();
    ((ISupportInitialize) this.Label28).BeginInit();
    ((ISupportInitialize) this.Label29).BeginInit();
    ((ISupportInitialize) this.Label30).BeginInit();
    ((ISupportInitialize) this.Label31).BeginInit();
    ((ISupportInitialize) this.Label32).BeginInit();
    ((ISupportInitialize) this.Label33).BeginInit();
    ((ISupportInitialize) this.Label34).BeginInit();
    ((ISupportInitialize) this.Label35).BeginInit();
    ((ISupportInitialize) this.Label36).BeginInit();
    ((ISupportInitialize) this.Label37).BeginInit();
    ((ISupportInitialize) this.Label38).BeginInit();
    ((ISupportInitialize) this.Label39).BeginInit();
    ((ISupportInitialize) this.Label40).BeginInit();
    ((ISupportInitialize) this.Label41).BeginInit();
    ((ISupportInitialize) this.Label42).BeginInit();
    ((ISupportInitialize) this.Label43).BeginInit();
    ((ISupportInitialize) this.Label44).BeginInit();
    ((ISupportInitialize) this.lblBottomRenewalControlno).BeginInit();
    ((ISupportInitialize) this.lblMiddleRenewalControlno).BeginInit();
    ((ISupportInitialize) this.lblTopRenewalControlno).BeginInit();
    ((ISupportInitialize) this.lblTopRenewalStatus).BeginInit();
    ((ISupportInitialize) this.lblMiddleRenewalStatus).BeginInit();
    ((ISupportInitialize) this.lblBottomRenewalStatus).BeginInit();
    ((ISupportInitialize) this.Label45).BeginInit();
    ((ISupportInitialize) this.Label46).BeginInit();
    ((ISupportInitialize) this.Label47).BeginInit();
    ((ISupportInitialize) this.Label26).BeginInit();
    ((ISupportInitialize) this.TextBox6).BeginInit();
    ((ISupportInitialize) this.TextBox7).BeginInit();
    ((ISupportInitialize) this.TextBox8).BeginInit();
    ((ISupportInitialize) this.TextBox10).BeginInit();
    ((ISupportInitialize) this).BeginInit();
    this.Detail.ColumnSpacing = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Controls.AddRange(new ARControl[18]
    {
      (ARControl) this.txtInsured,
      (ARControl) this.txtBroker,
      (ARControl) this.txtEffDate,
      (ARControl) this.txtCarrier,
      (ARControl) this.txtProd,
      (ARControl) this.txtPremium,
      (ARControl) this.txtLines,
      (ARControl) this.txtStatus,
      (ARControl) this.TextBox,
      (ARControl) this.TextBox1,
      (ARControl) this.TextBox2,
      (ARControl) this.TextBox3,
      (ARControl) this.TextBox4,
      (ARControl) this.TextBox5,
      (ARControl) this.TextBox9,
      (ARControl) this.lblRenewalControlno,
      (ARControl) this.lblRenewalStatus,
      (ARControl) this.TextBox11
    });
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Height = 0.125f;
    this.Detail.KeepTogether = true;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Name = "Detail";
    ((ARControl) this.txtInsured).Border.BottomColor = Color.Black;
    ((ARControl) this.txtInsured).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtInsured).Border.LeftColor = Color.Black;
    ((ARControl) this.txtInsured).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtInsured).Border.RightColor = Color.Black;
    ((ARControl) this.txtInsured).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtInsured).Border.TopColor = Color.Black;
    ((ARControl) this.txtInsured).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtInsured).DataField = "Insured";
    ((ARControl) this.txtInsured).Height = 0.125f;
    ((ARControl) this.txtInsured).Left = 0.0f;
    ((ARControl) this.txtInsured).Name = "txtInsured";
    this.txtInsured.Style = "ddo-char-set: 0; font-size: 6.75pt; ";
    this.txtInsured.Text = (string) null;
    ((ARControl) this.txtInsured).Top = 0.0f;
    ((ARControl) this.txtInsured).Width = 2.125f;
    ((ARControl) this.txtBroker).Border.BottomColor = Color.Black;
    ((ARControl) this.txtBroker).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtBroker).Border.LeftColor = Color.Black;
    ((ARControl) this.txtBroker).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtBroker).Border.RightColor = Color.Black;
    ((ARControl) this.txtBroker).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtBroker).Border.TopColor = Color.Black;
    ((ARControl) this.txtBroker).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtBroker).DataField = "Broker";
    ((ARControl) this.txtBroker).Height = 0.125f;
    ((ARControl) this.txtBroker).Left = 3.770833f;
    ((ARControl) this.txtBroker).Name = "txtBroker";
    this.txtBroker.Style = "ddo-char-set: 0; font-size: 6.75pt; ";
    this.txtBroker.Text = (string) null;
    ((ARControl) this.txtBroker).Top = 0.0f;
    ((ARControl) this.txtBroker).Width = 1.397638f;
    ((ARControl) this.txtEffDate).Border.BottomColor = Color.Black;
    ((ARControl) this.txtEffDate).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtEffDate).Border.LeftColor = Color.Black;
    ((ARControl) this.txtEffDate).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtEffDate).Border.RightColor = Color.Black;
    ((ARControl) this.txtEffDate).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtEffDate).Border.TopColor = Color.Black;
    ((ARControl) this.txtEffDate).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtEffDate).DataField = "ExpirationDate";
    ((ARControl) this.txtEffDate).Height = 0.125f;
    ((ARControl) this.txtEffDate).Left = 5.166667f;
    ((ARControl) this.txtEffDate).Name = "txtEffDate";
    this.txtEffDate.OutputFormat = resourceManager.GetString("txtEffDate.OutputFormat");
    this.txtEffDate.Style = "ddo-char-set: 0; text-align: center; font-size: 6.75pt; ";
    this.txtEffDate.Text = (string) null;
    ((ARControl) this.txtEffDate).Top = 0.0f;
    ((ARControl) this.txtEffDate).Width = 9f / 16f;
    ((ARControl) this.txtCarrier).Border.BottomColor = Color.Black;
    ((ARControl) this.txtCarrier).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtCarrier).Border.LeftColor = Color.Black;
    ((ARControl) this.txtCarrier).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtCarrier).Border.RightColor = Color.Black;
    ((ARControl) this.txtCarrier).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtCarrier).Border.TopColor = Color.Black;
    ((ARControl) this.txtCarrier).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtCarrier).DataField = "Company";
    ((ARControl) this.txtCarrier).Height = 0.125f;
    ((ARControl) this.txtCarrier).Left = 5.729167f;
    ((ARControl) this.txtCarrier).Name = "txtCarrier";
    this.txtCarrier.Style = "ddo-char-set: 0; font-size: 6.75pt; ";
    this.txtCarrier.Text = (string) null;
    ((ARControl) this.txtCarrier).Top = 0.0f;
    ((ARControl) this.txtCarrier).Width = 1.34252f;
    ((ARControl) this.txtProd).Border.BottomColor = Color.Black;
    ((ARControl) this.txtProd).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtProd).Border.LeftColor = Color.Black;
    ((ARControl) this.txtProd).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtProd).Border.RightColor = Color.Black;
    ((ARControl) this.txtProd).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtProd).Border.TopColor = Color.Black;
    ((ARControl) this.txtProd).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtProd).DataField = "Und";
    ((ARControl) this.txtProd).Height = 0.125f;
    ((ARControl) this.txtProd).Left = 7.645833f;
    ((ARControl) this.txtProd).Name = "txtProd";
    this.txtProd.Style = "ddo-char-set: 0; font-size: 6.75pt; ";
    this.txtProd.Text = (string) null;
    ((ARControl) this.txtProd).Top = 0.0f;
    ((ARControl) this.txtProd).Width = 5f / 16f;
    ((ARControl) this.txtPremium).Border.BottomColor = Color.Black;
    ((ARControl) this.txtPremium).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtPremium).Border.LeftColor = Color.Black;
    ((ARControl) this.txtPremium).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtPremium).Border.RightColor = Color.Black;
    ((ARControl) this.txtPremium).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtPremium).Border.TopColor = Color.Black;
    ((ARControl) this.txtPremium).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtPremium).DataField = "Premium";
    ((ARControl) this.txtPremium).Height = 0.125f;
    ((ARControl) this.txtPremium).Left = 135f / 16f;
    ((ARControl) this.txtPremium).Name = "txtPremium";
    this.txtPremium.OutputFormat = resourceManager.GetString("txtPremium.OutputFormat");
    this.txtPremium.Style = "ddo-char-set: 0; text-align: right; font-size: 6.75pt; ";
    this.txtPremium.Text = (string) null;
    ((ARControl) this.txtPremium).Top = 0.0f;
    ((ARControl) this.txtPremium).Width = 11f / 16f;
    ((ARControl) this.txtLines).Border.BottomColor = Color.Black;
    ((ARControl) this.txtLines).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtLines).Border.LeftColor = Color.Black;
    ((ARControl) this.txtLines).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtLines).Border.RightColor = Color.Black;
    ((ARControl) this.txtLines).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtLines).Border.TopColor = Color.Black;
    ((ARControl) this.txtLines).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtLines).DataField = "Lines";
    ((ARControl) this.txtLines).Height = 0.125f;
    ((ARControl) this.txtLines).Left = 9.125f;
    ((ARControl) this.txtLines).Name = "txtLines";
    this.txtLines.Style = "ddo-char-set: 0; font-size: 6.75pt; ";
    this.txtLines.Text = (string) null;
    ((ARControl) this.txtLines).Top = 0.0f;
    ((ARControl) this.txtLines).Width = 0.75f;
    ((ARControl) this.txtStatus).Border.BottomColor = Color.Black;
    ((ARControl) this.txtStatus).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtStatus).Border.LeftColor = Color.Black;
    ((ARControl) this.txtStatus).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtStatus).Border.RightColor = Color.Black;
    ((ARControl) this.txtStatus).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtStatus).Border.TopColor = Color.Black;
    ((ARControl) this.txtStatus).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtStatus).DataField = "Status";
    ((ARControl) this.txtStatus).Height = 0.125f;
    ((ARControl) this.txtStatus).Left = 9.875f;
    ((ARControl) this.txtStatus).Name = "txtStatus";
    this.txtStatus.Style = "ddo-char-set: 0; font-size: 6.75pt; ";
    this.txtStatus.Text = (string) null;
    ((ARControl) this.txtStatus).Top = 0.0f;
    ((ARControl) this.txtStatus).Width = 7f / 16f;
    ((ARControl) this.TextBox).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox).DataField = "PolicyNumber";
    ((ARControl) this.TextBox).Height = 0.125f;
    ((ARControl) this.TextBox).Left = 2.125f;
    ((ARControl) this.TextBox).Name = "TextBox";
    this.TextBox.Style = "ddo-char-set: 0; text-align: center; font-size: 6.75pt; ";
    this.TextBox.Text = (string) null;
    ((ARControl) this.TextBox).Top = 0.0f;
    ((ARControl) this.TextBox).Width = 13f / 16f;
    ((ARControl) this.TextBox1).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox1).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox1).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox1).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox1).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox1).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox1).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox1).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox1).DataField = "State";
    ((ARControl) this.TextBox1).Height = 0.125f;
    ((ARControl) this.TextBox1).Left = 3.395833f;
    ((ARControl) this.TextBox1).Name = "TextBox1";
    this.TextBox1.Style = "ddo-char-set: 0; text-align: center; font-size: 6.75pt; ";
    this.TextBox1.Text = (string) null;
    ((ARControl) this.TextBox1).Top = 0.0f;
    ((ARControl) this.TextBox1).Width = 0.375f;
    ((ARControl) this.TextBox2).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox2).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox2).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox2).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox2).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox2).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox2).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox2).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox2).DataField = "TACSR";
    ((ARControl) this.TextBox2).Height = 0.125f;
    ((ARControl) this.TextBox2).Left = 7.072917f;
    ((ARControl) this.TextBox2).Name = "TextBox2";
    this.TextBox2.Style = "ddo-char-set: 0; font-size: 6.75pt; ";
    this.TextBox2.Text = (string) null;
    ((ARControl) this.TextBox2).Top = 0.0f;
    ((ARControl) this.TextBox2).Width = 0.5748032f;
    ((ARControl) this.TextBox3).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox3).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox3).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox3).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox3).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox3).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox3).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox3).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox3).DataField = "ControlNo";
    ((ARControl) this.TextBox3).Height = 0.125f;
    ((ARControl) this.TextBox3).Left = 47f / 16f;
    ((ARControl) this.TextBox3).Name = "TextBox3";
    this.TextBox3.Style = "ddo-char-set: 0; text-align: center; font-size: 6.75pt; ";
    this.TextBox3.Text = (string) null;
    ((ARControl) this.TextBox3).Top = 0.0f;
    ((ARControl) this.TextBox3).Width = 0.4566929f;
    ((ARControl) this.TextBox4).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox4).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox4).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox4).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox4).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox4).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox4).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox4).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox4).DataField = "ClaimCount";
    ((ARControl) this.TextBox4).Height = 0.125f;
    ((ARControl) this.TextBox4).Left = 165f / 16f;
    ((ARControl) this.TextBox4).Name = "TextBox4";
    this.TextBox4.OutputFormat = resourceManager.GetString("TextBox4.OutputFormat");
    this.TextBox4.Style = "ddo-char-set: 0; text-align: center; font-size: 6.75pt; ";
    this.TextBox4.Text = (string) null;
    ((ARControl) this.TextBox4).Top = 0.0f;
    ((ARControl) this.TextBox4).Width = 7f / 16f;
    ((ARControl) this.TextBox5).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox5).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox5).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox5).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox5).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox5).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox5).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox5).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox5).DataField = "TotalIncurred";
    ((ARControl) this.TextBox5).Height = 0.125f;
    ((ARControl) this.TextBox5).Left = 10.75f;
    ((ARControl) this.TextBox5).Name = "TextBox5";
    this.TextBox5.OutputFormat = resourceManager.GetString("TextBox5.OutputFormat");
    this.TextBox5.Style = "ddo-char-set: 0; text-align: right; font-size: 6.75pt; ";
    this.TextBox5.Text = (string) null;
    ((ARControl) this.TextBox5).Top = 0.0f;
    ((ARControl) this.TextBox5).Width = 13f / 16f;
    ((ARControl) this.TextBox9).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox9).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox9).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox9).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox9).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox9).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox9).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox9).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox9).DataField = "LossRatio";
    ((ARControl) this.TextBox9).Height = 0.125f;
    ((ARControl) this.TextBox9).Left = 185f / 16f;
    ((ARControl) this.TextBox9).Name = "TextBox9";
    this.TextBox9.OutputFormat = resourceManager.GetString("TextBox9.OutputFormat");
    this.TextBox9.Style = "ddo-char-set: 0; text-align: right; font-size: 6.75pt; ";
    this.TextBox9.Text = (string) null;
    ((ARControl) this.TextBox9).Top = 0.0f;
    ((ARControl) this.TextBox9).Width = 0.625f;
    ((ARControl) this.lblRenewalControlno).Border.BottomColor = Color.Black;
    ((ARControl) this.lblRenewalControlno).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.lblRenewalControlno).Border.LeftColor = Color.Black;
    ((ARControl) this.lblRenewalControlno).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.lblRenewalControlno).Border.RightColor = Color.Black;
    ((ARControl) this.lblRenewalControlno).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.lblRenewalControlno).Border.TopColor = Color.Black;
    ((ARControl) this.lblRenewalControlno).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.lblRenewalControlno).DataField = "RenewalControlNo";
    ((ARControl) this.lblRenewalControlno).Height = 0.125f;
    ((ARControl) this.lblRenewalControlno).Left = 195f / 16f;
    ((ARControl) this.lblRenewalControlno).Name = "lblRenewalControlno";
    this.lblRenewalControlno.Style = "ddo-char-set: 0; text-align: center; font-size: 6.75pt; ";
    this.lblRenewalControlno.Text = (string) null;
    ((ARControl) this.lblRenewalControlno).Top = 0.0f;
    ((ARControl) this.lblRenewalControlno).Width = 9f / 16f;
    ((ARControl) this.lblRenewalStatus).Border.BottomColor = Color.Black;
    ((ARControl) this.lblRenewalStatus).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.lblRenewalStatus).Border.LeftColor = Color.Black;
    ((ARControl) this.lblRenewalStatus).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.lblRenewalStatus).Border.RightColor = Color.Black;
    ((ARControl) this.lblRenewalStatus).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.lblRenewalStatus).Border.TopColor = Color.Black;
    ((ARControl) this.lblRenewalStatus).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.lblRenewalStatus).DataField = "RenewalStatus";
    ((ARControl) this.lblRenewalStatus).Height = 0.125f;
    ((ARControl) this.lblRenewalStatus).Left = 12.75f;
    ((ARControl) this.lblRenewalStatus).Name = "lblRenewalStatus";
    this.lblRenewalStatus.Style = "ddo-char-set: 0; text-align: center; font-size: 6.75pt; ";
    this.lblRenewalStatus.Text = (string) null;
    ((ARControl) this.lblRenewalStatus).Top = 0.0f;
    ((ARControl) this.lblRenewalStatus).Width = 0.625f;
    ((ARControl) this.TextBox11).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox11).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox11).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox11).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox11).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox11).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox11).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox11).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox11).DataField = "UndAssist";
    ((ARControl) this.TextBox11).Height = 0.125f;
    ((ARControl) this.TextBox11).Left = 7.958333f;
    ((ARControl) this.TextBox11).Name = "TextBox11";
    this.TextBox11.Style = "ddo-char-set: 0; font-size: 6.75pt; ";
    this.TextBox11.Text = (string) null;
    ((ARControl) this.TextBox11).Top = 0.0f;
    ((ARControl) this.TextBox11).Width = 0.480315f;
    this.ghYear.DataField = "Year";
    this.ghYear.Height = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ghYear).Name = "ghYear";
    this.gfYear.Height = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfYear).Name = "gfYear";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ghMonth).Controls.AddRange(new ARControl[56]
    {
      (ARControl) this.Label1,
      (ARControl) this.Label3,
      (ARControl) this.Label4,
      (ARControl) this.Label5,
      (ARControl) this.Label6,
      (ARControl) this.Label7,
      (ARControl) this.Label8,
      (ARControl) this.Label9,
      (ARControl) this.Label10,
      (ARControl) this.Label11,
      (ARControl) this.Label12,
      (ARControl) this.Label13,
      (ARControl) this.Label14,
      (ARControl) this.Label15,
      (ARControl) this.Label16,
      (ARControl) this.Label17,
      (ARControl) this.Label19,
      (ARControl) this.Label20,
      (ARControl) this.Label21,
      (ARControl) this.Label22,
      (ARControl) this.Label23,
      (ARControl) this.Label24,
      (ARControl) this.Label25,
      (ARControl) this.txtMonthAndYear,
      (ARControl) this.Month,
      (ARControl) this.Year,
      (ARControl) this.Label,
      (ARControl) this.Label2,
      (ARControl) this.Label18,
      (ARControl) this.Label27,
      (ARControl) this.Label28,
      (ARControl) this.Label29,
      (ARControl) this.Label30,
      (ARControl) this.Label31,
      (ARControl) this.Label32,
      (ARControl) this.Label33,
      (ARControl) this.Label34,
      (ARControl) this.Label35,
      (ARControl) this.Label36,
      (ARControl) this.Label37,
      (ARControl) this.Label38,
      (ARControl) this.Label39,
      (ARControl) this.Label40,
      (ARControl) this.Label41,
      (ARControl) this.Label42,
      (ARControl) this.Label43,
      (ARControl) this.Label44,
      (ARControl) this.lblBottomRenewalControlno,
      (ARControl) this.lblMiddleRenewalControlno,
      (ARControl) this.lblTopRenewalControlno,
      (ARControl) this.lblTopRenewalStatus,
      (ARControl) this.lblMiddleRenewalStatus,
      (ARControl) this.lblBottomRenewalStatus,
      (ARControl) this.Label45,
      (ARControl) this.Label46,
      (ARControl) this.Label47
    });
    this.ghMonth.DataField = "Month";
    this.ghMonth.Height = 0.9375002f;
    this.ghMonth.KeepTogether = true;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ghMonth).Name = "ghMonth";
    this.ghMonth.RepeatStyle = (RepeatStyle) 1;
    ((ARControl) this.Label1).Border.BottomColor = Color.Black;
    ((ARControl) this.Label1).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label1).Border.LeftColor = Color.Black;
    ((ARControl) this.Label1).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label1).Border.RightColor = Color.Black;
    ((ARControl) this.Label1).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label1).Border.TopColor = Color.Black;
    ((ARControl) this.Label1).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label1).Height = 5f / 16f;
    this.Label1.HyperLink = (string) null;
    ((ARControl) this.Label1).Left = 0.0f;
    ((ARControl) this.Label1).Name = "Label1";
    this.Label1.Style = "font-weight: bold; font-size: 8pt; vertical-align: bottom; ";
    this.Label1.Text = "Insured";
    ((ARControl) this.Label1).Top = 0.625f;
    ((ARControl) this.Label1).Width = 2.125f;
    ((ARControl) this.Label3).Border.BottomColor = Color.Black;
    ((ARControl) this.Label3).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label3).Border.LeftColor = Color.Black;
    ((ARControl) this.Label3).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label3).Border.RightColor = Color.Black;
    ((ARControl) this.Label3).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label3).Border.TopColor = Color.Black;
    ((ARControl) this.Label3).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label3).Height = 5f / 16f;
    this.Label3.HyperLink = (string) null;
    ((ARControl) this.Label3).Left = 9.125f;
    ((ARControl) this.Label3).Name = "Label3";
    this.Label3.Style = "font-weight: bold; font-size: 8pt; vertical-align: bottom; ";
    this.Label3.Text = "Line(s)";
    ((ARControl) this.Label3).Top = 0.625f;
    ((ARControl) this.Label3).Width = 0.75f;
    ((ARControl) this.Label4).Border.BottomColor = Color.Black;
    ((ARControl) this.Label4).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label4).Border.LeftColor = Color.Black;
    ((ARControl) this.Label4).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label4).Border.RightColor = Color.Black;
    ((ARControl) this.Label4).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label4).Border.TopColor = Color.Black;
    ((ARControl) this.Label4).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label4).Height = 5f / 16f;
    this.Label4.HyperLink = (string) null;
    ((ARControl) this.Label4).Left = 5.729167f;
    ((ARControl) this.Label4).Name = "Label4";
    this.Label4.Style = "font-weight: bold; font-size: 8pt; vertical-align: bottom; ";
    this.Label4.Text = "Carrier";
    ((ARControl) this.Label4).Top = 0.625f;
    ((ARControl) this.Label4).Width = 43f / 32f;
    ((ARControl) this.Label5).Border.BottomColor = Color.Black;
    ((ARControl) this.Label5).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label5).Border.LeftColor = Color.Black;
    ((ARControl) this.Label5).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label5).Border.RightColor = Color.Black;
    ((ARControl) this.Label5).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label5).Border.TopColor = Color.Black;
    ((ARControl) this.Label5).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label5).Height = 5f / 16f;
    this.Label5.HyperLink = (string) null;
    ((ARControl) this.Label5).Left = 135f / 16f;
    ((ARControl) this.Label5).Name = "Label5";
    this.Label5.Style = "text-align: right; font-weight: bold; font-size: 8pt; vertical-align: bottom; ";
    this.Label5.Text = "Premium";
    ((ARControl) this.Label5).Top = 0.625f;
    ((ARControl) this.Label5).Width = 11f / 16f;
    ((ARControl) this.Label6).Border.BottomColor = Color.Black;
    ((ARControl) this.Label6).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label6).Border.LeftColor = Color.Black;
    ((ARControl) this.Label6).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label6).Border.RightColor = Color.Black;
    ((ARControl) this.Label6).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label6).Border.TopColor = Color.Black;
    ((ARControl) this.Label6).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label6).Height = 5f / 16f;
    this.Label6.HyperLink = (string) null;
    ((ARControl) this.Label6).Left = 7.645833f;
    ((ARControl) this.Label6).Name = "Label6";
    this.Label6.Style = "font-weight: bold; font-size: 8pt; vertical-align: bottom; ";
    this.Label6.Text = "Und.";
    ((ARControl) this.Label6).Top = 0.625f;
    ((ARControl) this.Label6).Width = 5f / 16f;
    ((ARControl) this.Label7).Border.BottomColor = Color.Black;
    ((ARControl) this.Label7).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label7).Border.LeftColor = Color.Black;
    ((ARControl) this.Label7).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label7).Border.RightColor = Color.Black;
    ((ARControl) this.Label7).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label7).Border.TopColor = Color.Black;
    ((ARControl) this.Label7).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label7).Height = 5f / 16f;
    this.Label7.HyperLink = (string) null;
    ((ARControl) this.Label7).Left = 9.875f;
    ((ARControl) this.Label7).Name = "Label7";
    this.Label7.Style = "font-weight: bold; font-size: 8pt; vertical-align: bottom; ";
    this.Label7.Text = "Status";
    ((ARControl) this.Label7).Top = 0.625f;
    ((ARControl) this.Label7).Width = 7f / 16f;
    ((ARControl) this.Label8).Border.BottomColor = Color.Black;
    ((ARControl) this.Label8).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label8).Border.LeftColor = Color.Black;
    ((ARControl) this.Label8).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label8).Border.RightColor = Color.Black;
    ((ARControl) this.Label8).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label8).Border.TopColor = Color.Black;
    ((ARControl) this.Label8).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label8).Height = 5f / 16f;
    this.Label8.HyperLink = (string) null;
    ((ARControl) this.Label8).Left = 5.166667f;
    ((ARControl) this.Label8).Name = "Label8";
    this.Label8.Style = "text-align: center; font-weight: bold; font-size: 8pt; vertical-align: bottom; ";
    this.Label8.Text = "Exp Date";
    ((ARControl) this.Label8).Top = 0.625f;
    ((ARControl) this.Label8).Width = 9f / 16f;
    ((ARControl) this.Label9).Border.BottomColor = Color.Black;
    ((ARControl) this.Label9).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label9).Border.LeftColor = Color.Black;
    ((ARControl) this.Label9).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label9).Border.RightColor = Color.Black;
    ((ARControl) this.Label9).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label9).Border.TopColor = Color.Black;
    ((ARControl) this.Label9).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label9).Height = 5f / 16f;
    this.Label9.HyperLink = (string) null;
    ((ARControl) this.Label9).Left = 3.770833f;
    ((ARControl) this.Label9).Name = "Label9";
    this.Label9.Style = "font-weight: bold; font-size: 8pt; vertical-align: bottom; ";
    this.Label9.Text = "Broker";
    ((ARControl) this.Label9).Top = 0.625f;
    ((ARControl) this.Label9).Width = 1.395833f;
    ((ARControl) this.Label10).Border.BottomColor = Color.Black;
    ((ARControl) this.Label10).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label10).Border.LeftColor = Color.Black;
    ((ARControl) this.Label10).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label10).Border.RightColor = Color.Black;
    ((ARControl) this.Label10).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label10).Border.TopColor = Color.Black;
    ((ARControl) this.Label10).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label10).Height = 3f / 16f;
    this.Label10.HyperLink = (string) null;
    ((ARControl) this.Label10).Left = 0.0f;
    ((ARControl) this.Label10).Name = "Label10";
    this.Label10.Style = "text-align: center; font-weight: bold; font-size: 8pt; ";
    this.Label10.Text = " ";
    ((ARControl) this.Label10).Top = 7f / 16f;
    ((ARControl) this.Label10).Width = 2.125f;
    ((ARControl) this.Label11).Border.BottomColor = Color.Black;
    ((ARControl) this.Label11).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label11).Border.LeftColor = Color.Black;
    ((ARControl) this.Label11).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label11).Border.RightColor = Color.Black;
    ((ARControl) this.Label11).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label11).Border.TopColor = Color.Black;
    ((ARControl) this.Label11).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label11).Height = 3f / 16f;
    this.Label11.HyperLink = (string) null;
    ((ARControl) this.Label11).Left = 9.125f;
    ((ARControl) this.Label11).Name = "Label11";
    this.Label11.Style = "text-align: center; font-weight: bold; font-size: 8pt; ";
    this.Label11.Text = " ";
    ((ARControl) this.Label11).Top = 7f / 16f;
    ((ARControl) this.Label11).Width = 0.75f;
    ((ARControl) this.Label12).Border.BottomColor = Color.Black;
    ((ARControl) this.Label12).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label12).Border.LeftColor = Color.Black;
    ((ARControl) this.Label12).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label12).Border.RightColor = Color.Black;
    ((ARControl) this.Label12).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label12).Border.TopColor = Color.Black;
    ((ARControl) this.Label12).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label12).Height = 3f / 16f;
    this.Label12.HyperLink = (string) null;
    ((ARControl) this.Label12).Left = 5.729167f;
    ((ARControl) this.Label12).Name = "Label12";
    this.Label12.Style = "text-align: center; font-weight: bold; font-size: 8pt; ";
    this.Label12.Text = " ";
    ((ARControl) this.Label12).Top = 7f / 16f;
    ((ARControl) this.Label12).Width = 43f / 32f;
    ((ARControl) this.Label13).Border.BottomColor = Color.Black;
    ((ARControl) this.Label13).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label13).Border.LeftColor = Color.Black;
    ((ARControl) this.Label13).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label13).Border.RightColor = Color.Black;
    ((ARControl) this.Label13).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label13).Border.TopColor = Color.Black;
    ((ARControl) this.Label13).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label13).Height = 3f / 16f;
    this.Label13.HyperLink = (string) null;
    ((ARControl) this.Label13).Left = 135f / 16f;
    ((ARControl) this.Label13).Name = "Label13";
    this.Label13.Style = "text-align: center; font-weight: bold; font-size: 8pt; ";
    this.Label13.Text = " ";
    ((ARControl) this.Label13).Top = 7f / 16f;
    ((ARControl) this.Label13).Width = 11f / 16f;
    ((ARControl) this.Label14).Border.BottomColor = Color.Black;
    ((ARControl) this.Label14).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label14).Border.LeftColor = Color.Black;
    ((ARControl) this.Label14).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label14).Border.RightColor = Color.Black;
    ((ARControl) this.Label14).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label14).Border.TopColor = Color.Black;
    ((ARControl) this.Label14).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label14).Height = 3f / 16f;
    this.Label14.HyperLink = (string) null;
    ((ARControl) this.Label14).Left = 7.645833f;
    ((ARControl) this.Label14).Name = "Label14";
    this.Label14.Style = "text-align: center; font-weight: bold; font-size: 8pt; ";
    this.Label14.Text = " ";
    ((ARControl) this.Label14).Top = 7f / 16f;
    ((ARControl) this.Label14).Width = 5f / 16f;
    ((ARControl) this.Label15).Border.BottomColor = Color.Black;
    ((ARControl) this.Label15).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label15).Border.LeftColor = Color.Black;
    ((ARControl) this.Label15).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label15).Border.RightColor = Color.Black;
    ((ARControl) this.Label15).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label15).Border.TopColor = Color.Black;
    ((ARControl) this.Label15).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label15).Height = 3f / 16f;
    this.Label15.HyperLink = (string) null;
    ((ARControl) this.Label15).Left = 9.875f;
    ((ARControl) this.Label15).Name = "Label15";
    this.Label15.Style = "text-align: center; font-weight: bold; font-size: 8pt; ";
    this.Label15.Text = " ";
    ((ARControl) this.Label15).Top = 7f / 16f;
    ((ARControl) this.Label15).Width = 7f / 16f;
    ((ARControl) this.Label16).Border.BottomColor = Color.Black;
    ((ARControl) this.Label16).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label16).Border.LeftColor = Color.Black;
    ((ARControl) this.Label16).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label16).Border.RightColor = Color.Black;
    ((ARControl) this.Label16).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label16).Border.TopColor = Color.Black;
    ((ARControl) this.Label16).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label16).Height = 3f / 16f;
    this.Label16.HyperLink = (string) null;
    ((ARControl) this.Label16).Left = 5.166667f;
    ((ARControl) this.Label16).Name = "Label16";
    this.Label16.Style = "text-align: center; font-weight: bold; font-size: 8pt; ";
    this.Label16.Text = " ";
    ((ARControl) this.Label16).Top = 7f / 16f;
    ((ARControl) this.Label16).Width = 9f / 16f;
    ((ARControl) this.Label17).Border.BottomColor = Color.Black;
    ((ARControl) this.Label17).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label17).Border.LeftColor = Color.Black;
    ((ARControl) this.Label17).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label17).Border.RightColor = Color.Black;
    ((ARControl) this.Label17).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label17).Border.TopColor = Color.Black;
    ((ARControl) this.Label17).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label17).Height = 3f / 16f;
    this.Label17.HyperLink = (string) null;
    ((ARControl) this.Label17).Left = 3.770833f;
    ((ARControl) this.Label17).Name = "Label17";
    this.Label17.Style = "text-align: center; font-weight: bold; font-size: 8pt; ";
    this.Label17.Text = " ";
    ((ARControl) this.Label17).Top = 7f / 16f;
    ((ARControl) this.Label17).Width = 1.395833f;
    ((ARControl) this.Label19).Border.BottomColor = Color.Black;
    ((ARControl) this.Label19).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label19).Border.LeftColor = Color.Black;
    ((ARControl) this.Label19).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label19).Border.RightColor = Color.Black;
    ((ARControl) this.Label19).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label19).Border.TopColor = Color.Black;
    ((ARControl) this.Label19).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label19).Height = 7f / 16f;
    this.Label19.HyperLink = (string) null;
    ((ARControl) this.Label19).Left = 9.125f;
    ((ARControl) this.Label19).Name = "Label19";
    this.Label19.Style = "text-align: center; font-weight: bold; font-size: 8pt; vertical-align: bottom; ";
    this.Label19.Text = " ";
    ((ARControl) this.Label19).Top = 0.0f;
    ((ARControl) this.Label19).Width = 0.75f;
    ((ARControl) this.Label20).Border.BottomColor = Color.Black;
    ((ARControl) this.Label20).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label20).Border.LeftColor = Color.Black;
    ((ARControl) this.Label20).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label20).Border.RightColor = Color.Black;
    ((ARControl) this.Label20).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label20).Border.TopColor = Color.Black;
    ((ARControl) this.Label20).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label20).Height = 7f / 16f;
    this.Label20.HyperLink = (string) null;
    ((ARControl) this.Label20).Left = 5.729167f;
    ((ARControl) this.Label20).Name = "Label20";
    this.Label20.Style = "text-align: center; font-weight: bold; font-size: 8pt; vertical-align: bottom; ";
    this.Label20.Text = "";
    ((ARControl) this.Label20).Top = 0.0f;
    ((ARControl) this.Label20).Width = 43f / 32f;
    ((ARControl) this.Label21).Border.BottomColor = Color.Black;
    ((ARControl) this.Label21).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label21).Border.LeftColor = Color.Black;
    ((ARControl) this.Label21).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label21).Border.RightColor = Color.Black;
    ((ARControl) this.Label21).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label21).Border.TopColor = Color.Black;
    ((ARControl) this.Label21).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label21).Height = 7f / 16f;
    this.Label21.HyperLink = (string) null;
    ((ARControl) this.Label21).Left = 135f / 16f;
    ((ARControl) this.Label21).Name = "Label21";
    this.Label21.Style = "text-align: center; font-weight: bold; font-size: 8pt; vertical-align: bottom; ";
    this.Label21.Text = " ";
    ((ARControl) this.Label21).Top = 0.0f;
    ((ARControl) this.Label21).Width = 11f / 16f;
    ((ARControl) this.Label22).Border.BottomColor = Color.Black;
    ((ARControl) this.Label22).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label22).Border.LeftColor = Color.Black;
    ((ARControl) this.Label22).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label22).Border.RightColor = Color.Black;
    ((ARControl) this.Label22).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label22).Border.TopColor = Color.Black;
    ((ARControl) this.Label22).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label22).Height = 7f / 16f;
    this.Label22.HyperLink = (string) null;
    ((ARControl) this.Label22).Left = 7.645833f;
    ((ARControl) this.Label22).Name = "Label22";
    this.Label22.Style = "text-align: center; font-weight: bold; font-size: 8pt; vertical-align: bottom; ";
    this.Label22.Text = "";
    ((ARControl) this.Label22).Top = 0.0f;
    ((ARControl) this.Label22).Width = 5f / 16f;
    ((ARControl) this.Label23).Border.BottomColor = Color.Black;
    ((ARControl) this.Label23).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label23).Border.LeftColor = Color.Black;
    ((ARControl) this.Label23).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label23).Border.RightColor = Color.Black;
    ((ARControl) this.Label23).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label23).Border.TopColor = Color.Black;
    ((ARControl) this.Label23).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label23).Height = 7f / 16f;
    this.Label23.HyperLink = (string) null;
    ((ARControl) this.Label23).Left = 9.875f;
    ((ARControl) this.Label23).Name = "Label23";
    this.Label23.Style = "text-align: center; font-weight: bold; font-size: 8pt; vertical-align: bottom; ";
    this.Label23.Text = " ";
    ((ARControl) this.Label23).Top = 0.0f;
    ((ARControl) this.Label23).Width = 7f / 16f;
    ((ARControl) this.Label24).Border.BottomColor = Color.Black;
    ((ARControl) this.Label24).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label24).Border.LeftColor = Color.Black;
    ((ARControl) this.Label24).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label24).Border.RightColor = Color.Black;
    ((ARControl) this.Label24).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label24).Border.TopColor = Color.Black;
    ((ARControl) this.Label24).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label24).Height = 7f / 16f;
    this.Label24.HyperLink = (string) null;
    ((ARControl) this.Label24).Left = 5.166667f;
    ((ARControl) this.Label24).Name = "Label24";
    this.Label24.Style = "text-align: center; font-weight: bold; font-size: 8pt; vertical-align: bottom; ";
    this.Label24.Text = "";
    ((ARControl) this.Label24).Top = 0.0f;
    ((ARControl) this.Label24).Width = 9f / 16f;
    ((ARControl) this.Label25).Border.BottomColor = Color.Black;
    ((ARControl) this.Label25).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label25).Border.LeftColor = Color.Black;
    ((ARControl) this.Label25).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label25).Border.RightColor = Color.Black;
    ((ARControl) this.Label25).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label25).Border.TopColor = Color.Black;
    ((ARControl) this.Label25).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label25).Height = 7f / 16f;
    this.Label25.HyperLink = (string) null;
    ((ARControl) this.Label25).Left = 3.770833f;
    ((ARControl) this.Label25).Name = "Label25";
    this.Label25.Style = "text-align: center; font-weight: bold; font-size: 8pt; vertical-align: bottom; ";
    this.Label25.Text = "";
    ((ARControl) this.Label25).Top = 0.0f;
    ((ARControl) this.Label25).Width = 1.395833f;
    ((ARControl) this.txtMonthAndYear).Border.BottomColor = Color.Black;
    ((ARControl) this.txtMonthAndYear).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtMonthAndYear).Border.LeftColor = Color.Black;
    ((ARControl) this.txtMonthAndYear).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtMonthAndYear).Border.RightColor = Color.Black;
    ((ARControl) this.txtMonthAndYear).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtMonthAndYear).Border.TopColor = Color.Black;
    ((ARControl) this.txtMonthAndYear).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtMonthAndYear).DataField = "ExpirationDate";
    ((ARControl) this.txtMonthAndYear).Height = 7f / 16f;
    ((ARControl) this.txtMonthAndYear).Left = 0.0f;
    ((ARControl) this.txtMonthAndYear).Name = "txtMonthAndYear";
    this.txtMonthAndYear.Style = "font-weight: bold; font-size: 11pt; vertical-align: bottom; ";
    this.txtMonthAndYear.Text = (string) null;
    ((ARControl) this.txtMonthAndYear).Top = 0.0f;
    ((ARControl) this.txtMonthAndYear).Width = 2.125f;
    ((ARControl) this.Month).Border.BottomColor = Color.Black;
    ((ARControl) this.Month).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Month).Border.LeftColor = Color.Black;
    ((ARControl) this.Month).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Month).Border.RightColor = Color.Black;
    ((ARControl) this.Month).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Month).Border.TopColor = Color.Black;
    ((ARControl) this.Month).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Month).DataField = "Month";
    ((ARControl) this.Month).Height = 0.125f;
    this.Month.HyperLink = (string) null;
    ((ARControl) this.Month).Left = 0.0f;
    ((ARControl) this.Month).Name = "Month";
    this.Month.Style = "ddo-char-set: 0; background-color: Yellow; ";
    this.Month.Text = "";
    ((ARControl) this.Month).Top = 0.0f;
    ((ARControl) this.Month).Visible = false;
    ((ARControl) this.Month).Width = 1f;
    ((ARControl) this.Year).Border.BottomColor = Color.Black;
    ((ARControl) this.Year).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Year).Border.LeftColor = Color.Black;
    ((ARControl) this.Year).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Year).Border.RightColor = Color.Black;
    ((ARControl) this.Year).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Year).Border.TopColor = Color.Black;
    ((ARControl) this.Year).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Year).DataField = "Year";
    ((ARControl) this.Year).Height = 0.125f;
    this.Year.HyperLink = (string) null;
    ((ARControl) this.Year).Left = 2.25f;
    ((ARControl) this.Year).Name = "Year";
    this.Year.Style = "ddo-char-set: 0; background-color: Yellow; ";
    this.Year.Text = "";
    ((ARControl) this.Year).Top = 0.0f;
    ((ARControl) this.Year).Visible = false;
    ((ARControl) this.Year).Width = 1f;
    ((ARControl) this.Label).Border.BottomColor = Color.Black;
    ((ARControl) this.Label).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label).Border.LeftColor = Color.Black;
    ((ARControl) this.Label).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label).Border.RightColor = Color.Black;
    ((ARControl) this.Label).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label).Border.TopColor = Color.Black;
    ((ARControl) this.Label).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label).Height = 7f / 16f;
    this.Label.HyperLink = (string) null;
    ((ARControl) this.Label).Left = 2.125f;
    ((ARControl) this.Label).Name = "Label";
    this.Label.Style = "text-align: center; font-weight: bold; font-size: 8pt; vertical-align: bottom; ";
    this.Label.Text = "";
    ((ARControl) this.Label).Top = 0.0f;
    ((ARControl) this.Label).Width = 13f / 16f;
    ((ARControl) this.Label2).Border.BottomColor = Color.Black;
    ((ARControl) this.Label2).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label2).Border.LeftColor = Color.Black;
    ((ARControl) this.Label2).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label2).Border.RightColor = Color.Black;
    ((ARControl) this.Label2).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label2).Border.TopColor = Color.Black;
    ((ARControl) this.Label2).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label2).Height = 3f / 16f;
    this.Label2.HyperLink = (string) null;
    ((ARControl) this.Label2).Left = 2.125f;
    ((ARControl) this.Label2).Name = "Label2";
    this.Label2.Style = "text-align: center; font-weight: bold; font-size: 8pt; ";
    this.Label2.Text = " ";
    ((ARControl) this.Label2).Top = 7f / 16f;
    ((ARControl) this.Label2).Width = 13f / 16f;
    ((ARControl) this.Label18).Border.BottomColor = Color.Black;
    ((ARControl) this.Label18).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label18).Border.LeftColor = Color.Black;
    ((ARControl) this.Label18).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label18).Border.RightColor = Color.Black;
    ((ARControl) this.Label18).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label18).Border.TopColor = Color.Black;
    ((ARControl) this.Label18).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label18).Height = 5f / 16f;
    this.Label18.HyperLink = (string) null;
    ((ARControl) this.Label18).Left = 2.125f;
    ((ARControl) this.Label18).Name = "Label18";
    this.Label18.Style = "text-align: center; font-weight: bold; font-size: 8pt; vertical-align: bottom; ";
    this.Label18.Text = "Policy #";
    ((ARControl) this.Label18).Top = 0.625f;
    ((ARControl) this.Label18).Width = 13f / 16f;
    ((ARControl) this.Label27).Border.BottomColor = Color.Black;
    ((ARControl) this.Label27).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label27).Border.LeftColor = Color.Black;
    ((ARControl) this.Label27).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label27).Border.RightColor = Color.Black;
    ((ARControl) this.Label27).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label27).Border.TopColor = Color.Black;
    ((ARControl) this.Label27).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label27).Height = 5f / 16f;
    this.Label27.HyperLink = (string) null;
    ((ARControl) this.Label27).Left = 3.395833f;
    ((ARControl) this.Label27).Name = "Label27";
    this.Label27.Style = "text-align: center; font-weight: bold; font-size: 8pt; vertical-align: bottom; ";
    this.Label27.Text = "State";
    ((ARControl) this.Label27).Top = 0.625f;
    ((ARControl) this.Label27).Width = 0.375f;
    ((ARControl) this.Label28).Border.BottomColor = Color.Black;
    ((ARControl) this.Label28).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label28).Border.LeftColor = Color.Black;
    ((ARControl) this.Label28).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label28).Border.RightColor = Color.Black;
    ((ARControl) this.Label28).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label28).Border.TopColor = Color.Black;
    ((ARControl) this.Label28).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label28).Height = 7f / 16f;
    this.Label28.HyperLink = (string) null;
    ((ARControl) this.Label28).Left = 3.395833f;
    ((ARControl) this.Label28).Name = "Label28";
    this.Label28.Style = "text-align: center; font-weight: bold; font-size: 8pt; vertical-align: bottom; ";
    this.Label28.Text = "";
    ((ARControl) this.Label28).Top = 0.0f;
    ((ARControl) this.Label28).Width = 0.375f;
    ((ARControl) this.Label29).Border.BottomColor = Color.Black;
    ((ARControl) this.Label29).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label29).Border.LeftColor = Color.Black;
    ((ARControl) this.Label29).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label29).Border.RightColor = Color.Black;
    ((ARControl) this.Label29).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label29).Border.TopColor = Color.Black;
    ((ARControl) this.Label29).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label29).Height = 3f / 16f;
    this.Label29.HyperLink = (string) null;
    ((ARControl) this.Label29).Left = 3.395833f;
    ((ARControl) this.Label29).Name = "Label29";
    this.Label29.Style = "text-align: center; font-weight: bold; font-size: 8pt; ";
    this.Label29.Text = " ";
    ((ARControl) this.Label29).Top = 7f / 16f;
    ((ARControl) this.Label29).Width = 0.375f;
    ((ARControl) this.Label30).Border.BottomColor = Color.Black;
    ((ARControl) this.Label30).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label30).Border.LeftColor = Color.Black;
    ((ARControl) this.Label30).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label30).Border.RightColor = Color.Black;
    ((ARControl) this.Label30).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label30).Border.TopColor = Color.Black;
    ((ARControl) this.Label30).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label30).Height = 5f / 16f;
    this.Label30.HyperLink = (string) null;
    ((ARControl) this.Label30).Left = 7.072917f;
    ((ARControl) this.Label30).Name = "Label30";
    this.Label30.Style = "font-weight: bold; font-size: 8pt; vertical-align: bottom; ";
    this.Label30.Text = "TA/CSR";
    ((ARControl) this.Label30).Top = 0.625f;
    ((ARControl) this.Label30).Width = 0.5729167f;
    ((ARControl) this.Label31).Border.BottomColor = Color.Black;
    ((ARControl) this.Label31).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label31).Border.LeftColor = Color.Black;
    ((ARControl) this.Label31).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label31).Border.RightColor = Color.Black;
    ((ARControl) this.Label31).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label31).Border.TopColor = Color.Black;
    ((ARControl) this.Label31).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label31).Height = 3f / 16f;
    this.Label31.HyperLink = (string) null;
    ((ARControl) this.Label31).Left = 7.072917f;
    ((ARControl) this.Label31).Name = "Label31";
    this.Label31.Style = "text-align: center; font-weight: bold; font-size: 8pt; ";
    this.Label31.Text = " ";
    ((ARControl) this.Label31).Top = 7f / 16f;
    ((ARControl) this.Label31).Width = 0.5729167f;
    ((ARControl) this.Label32).Border.BottomColor = Color.Black;
    ((ARControl) this.Label32).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label32).Border.LeftColor = Color.Black;
    ((ARControl) this.Label32).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label32).Border.RightColor = Color.Black;
    ((ARControl) this.Label32).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label32).Border.TopColor = Color.Black;
    ((ARControl) this.Label32).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label32).Height = 7f / 16f;
    this.Label32.HyperLink = (string) null;
    ((ARControl) this.Label32).Left = 7.072917f;
    ((ARControl) this.Label32).Name = "Label32";
    this.Label32.Style = "text-align: center; font-weight: bold; font-size: 8pt; vertical-align: bottom; ";
    this.Label32.Text = "";
    ((ARControl) this.Label32).Top = 0.0f;
    ((ARControl) this.Label32).Width = 0.5729167f;
    ((ARControl) this.Label33).Border.BottomColor = Color.Black;
    ((ARControl) this.Label33).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label33).Border.LeftColor = Color.Black;
    ((ARControl) this.Label33).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label33).Border.RightColor = Color.Black;
    ((ARControl) this.Label33).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label33).Border.TopColor = Color.Black;
    ((ARControl) this.Label33).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label33).Height = 7f / 16f;
    this.Label33.HyperLink = (string) null;
    ((ARControl) this.Label33).Left = 47f / 16f;
    ((ARControl) this.Label33).Name = "Label33";
    this.Label33.Style = "text-align: center; font-weight: bold; font-size: 8pt; vertical-align: bottom; ";
    this.Label33.Text = "";
    ((ARControl) this.Label33).Top = 0.0f;
    ((ARControl) this.Label33).Width = 0.4583333f;
    ((ARControl) this.Label34).Border.BottomColor = Color.Black;
    ((ARControl) this.Label34).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label34).Border.LeftColor = Color.Black;
    ((ARControl) this.Label34).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label34).Border.RightColor = Color.Black;
    ((ARControl) this.Label34).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label34).Border.TopColor = Color.Black;
    ((ARControl) this.Label34).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label34).Height = 3f / 16f;
    this.Label34.HyperLink = (string) null;
    ((ARControl) this.Label34).Left = 47f / 16f;
    ((ARControl) this.Label34).Name = "Label34";
    this.Label34.Style = "text-align: center; font-weight: bold; font-size: 8pt; ";
    this.Label34.Text = " ";
    ((ARControl) this.Label34).Top = 7f / 16f;
    ((ARControl) this.Label34).Width = 0.4583333f;
    ((ARControl) this.Label35).Border.BottomColor = Color.Black;
    ((ARControl) this.Label35).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label35).Border.LeftColor = Color.Black;
    ((ARControl) this.Label35).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label35).Border.RightColor = Color.Black;
    ((ARControl) this.Label35).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label35).Border.TopColor = Color.Black;
    ((ARControl) this.Label35).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label35).Height = 5f / 16f;
    this.Label35.HyperLink = (string) null;
    ((ARControl) this.Label35).Left = 47f / 16f;
    ((ARControl) this.Label35).Name = "Label35";
    this.Label35.Style = "text-align: center; font-weight: bold; font-size: 8pt; vertical-align: bottom; ";
    this.Label35.Text = "Ctrl #";
    ((ARControl) this.Label35).Top = 0.625f;
    ((ARControl) this.Label35).Width = 0.4583333f;
    ((ARControl) this.Label36).Border.BottomColor = Color.Black;
    ((ARControl) this.Label36).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label36).Border.LeftColor = Color.Black;
    ((ARControl) this.Label36).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label36).Border.RightColor = Color.Black;
    ((ARControl) this.Label36).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label36).Border.TopColor = Color.Black;
    ((ARControl) this.Label36).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label36).Height = 7f / 16f;
    this.Label36.HyperLink = (string) null;
    ((ARControl) this.Label36).Left = 165f / 16f;
    ((ARControl) this.Label36).Name = "Label36";
    this.Label36.Style = "text-align: center; font-weight: bold; font-size: 8pt; vertical-align: bottom; ";
    this.Label36.Text = " ";
    ((ARControl) this.Label36).Top = 0.0f;
    ((ARControl) this.Label36).Width = 7f / 16f;
    ((ARControl) this.Label37).Border.BottomColor = Color.Black;
    ((ARControl) this.Label37).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label37).Border.LeftColor = Color.Black;
    ((ARControl) this.Label37).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label37).Border.RightColor = Color.Black;
    ((ARControl) this.Label37).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label37).Border.TopColor = Color.Black;
    ((ARControl) this.Label37).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label37).Height = 5f / 16f;
    this.Label37.HyperLink = (string) null;
    ((ARControl) this.Label37).Left = 165f / 16f;
    ((ARControl) this.Label37).Name = "Label37";
    this.Label37.Style = "text-align: center; font-weight: bold; font-size: 8pt; vertical-align: bottom; ";
    this.Label37.Text = "Claim Count";
    ((ARControl) this.Label37).Top = 0.625f;
    ((ARControl) this.Label37).Width = 7f / 16f;
    ((ARControl) this.Label38).Border.BottomColor = Color.Black;
    ((ARControl) this.Label38).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label38).Border.LeftColor = Color.Black;
    ((ARControl) this.Label38).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label38).Border.RightColor = Color.Black;
    ((ARControl) this.Label38).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label38).Border.TopColor = Color.Black;
    ((ARControl) this.Label38).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label38).Height = 5f / 16f;
    this.Label38.HyperLink = (string) null;
    ((ARControl) this.Label38).Left = 10.75f;
    ((ARControl) this.Label38).Name = "Label38";
    this.Label38.Style = "text-align: right; font-weight: bold; font-size: 8pt; vertical-align: bottom; ";
    this.Label38.Text = "Total Incurred";
    ((ARControl) this.Label38).Top = 0.625f;
    ((ARControl) this.Label38).Width = 13f / 16f;
    ((ARControl) this.Label39).Border.BottomColor = Color.Black;
    ((ARControl) this.Label39).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label39).Border.LeftColor = Color.Black;
    ((ARControl) this.Label39).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label39).Border.RightColor = Color.Black;
    ((ARControl) this.Label39).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label39).Border.TopColor = Color.Black;
    ((ARControl) this.Label39).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label39).Height = 3f / 16f;
    this.Label39.HyperLink = (string) null;
    ((ARControl) this.Label39).Left = 165f / 16f;
    ((ARControl) this.Label39).Name = "Label39";
    this.Label39.Style = "text-align: center; font-weight: bold; font-size: 8pt; ";
    this.Label39.Text = " ";
    ((ARControl) this.Label39).Top = 7f / 16f;
    ((ARControl) this.Label39).Width = 7f / 16f;
    ((ARControl) this.Label40).Border.BottomColor = Color.Black;
    ((ARControl) this.Label40).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label40).Border.LeftColor = Color.Black;
    ((ARControl) this.Label40).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label40).Border.RightColor = Color.Black;
    ((ARControl) this.Label40).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label40).Border.TopColor = Color.Black;
    ((ARControl) this.Label40).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label40).Height = 3f / 16f;
    this.Label40.HyperLink = (string) null;
    ((ARControl) this.Label40).Left = 10.75f;
    ((ARControl) this.Label40).Name = "Label40";
    this.Label40.Style = "text-align: center; font-weight: bold; font-size: 8pt; ";
    this.Label40.Text = " ";
    ((ARControl) this.Label40).Top = 7f / 16f;
    ((ARControl) this.Label40).Width = 13f / 16f;
    ((ARControl) this.Label41).Border.BottomColor = Color.Black;
    ((ARControl) this.Label41).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label41).Border.LeftColor = Color.Black;
    ((ARControl) this.Label41).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label41).Border.RightColor = Color.Black;
    ((ARControl) this.Label41).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label41).Border.TopColor = Color.Black;
    ((ARControl) this.Label41).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label41).Height = 7f / 16f;
    this.Label41.HyperLink = (string) null;
    ((ARControl) this.Label41).Left = 10.75f;
    ((ARControl) this.Label41).Name = "Label41";
    this.Label41.Style = "text-align: center; font-weight: bold; font-size: 8pt; vertical-align: bottom; ";
    this.Label41.Text = " ";
    ((ARControl) this.Label41).Top = 0.0f;
    ((ARControl) this.Label41).Width = 13f / 16f;
    ((ARControl) this.Label42).Border.BottomColor = Color.Black;
    ((ARControl) this.Label42).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label42).Border.LeftColor = Color.Black;
    ((ARControl) this.Label42).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label42).Border.RightColor = Color.Black;
    ((ARControl) this.Label42).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label42).Border.TopColor = Color.Black;
    ((ARControl) this.Label42).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label42).Height = 7f / 16f;
    this.Label42.HyperLink = (string) null;
    ((ARControl) this.Label42).Left = 185f / 16f;
    ((ARControl) this.Label42).Name = "Label42";
    this.Label42.Style = "text-align: center; font-weight: bold; font-size: 8pt; vertical-align: bottom; ";
    this.Label42.Text = " ";
    ((ARControl) this.Label42).Top = 0.0f;
    ((ARControl) this.Label42).Width = 0.625f;
    ((ARControl) this.Label43).Border.BottomColor = Color.Black;
    ((ARControl) this.Label43).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label43).Border.LeftColor = Color.Black;
    ((ARControl) this.Label43).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label43).Border.RightColor = Color.Black;
    ((ARControl) this.Label43).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label43).Border.TopColor = Color.Black;
    ((ARControl) this.Label43).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label43).Height = 3f / 16f;
    this.Label43.HyperLink = (string) null;
    ((ARControl) this.Label43).Left = 185f / 16f;
    ((ARControl) this.Label43).Name = "Label43";
    this.Label43.Style = "text-align: center; font-weight: bold; font-size: 8pt; ";
    this.Label43.Text = " ";
    ((ARControl) this.Label43).Top = 7f / 16f;
    ((ARControl) this.Label43).Width = 0.625f;
    ((ARControl) this.Label44).Border.BottomColor = Color.Black;
    ((ARControl) this.Label44).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label44).Border.LeftColor = Color.Black;
    ((ARControl) this.Label44).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label44).Border.RightColor = Color.Black;
    ((ARControl) this.Label44).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label44).Border.TopColor = Color.Black;
    ((ARControl) this.Label44).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label44).Height = 5f / 16f;
    this.Label44.HyperLink = (string) null;
    ((ARControl) this.Label44).Left = 185f / 16f;
    ((ARControl) this.Label44).Name = "Label44";
    this.Label44.Style = "text-align: right; font-weight: bold; font-size: 8pt; vertical-align: bottom; ";
    this.Label44.Text = "Loss Ratio";
    ((ARControl) this.Label44).Top = 0.625f;
    ((ARControl) this.Label44).Width = 0.625f;
    ((ARControl) this.lblBottomRenewalControlno).Border.BottomColor = Color.Black;
    ((ARControl) this.lblBottomRenewalControlno).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.lblBottomRenewalControlno).Border.LeftColor = Color.Black;
    ((ARControl) this.lblBottomRenewalControlno).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.lblBottomRenewalControlno).Border.RightColor = Color.Black;
    ((ARControl) this.lblBottomRenewalControlno).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.lblBottomRenewalControlno).Border.TopColor = Color.Black;
    ((ARControl) this.lblBottomRenewalControlno).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.lblBottomRenewalControlno).Height = 5f / 16f;
    this.lblBottomRenewalControlno.HyperLink = (string) null;
    ((ARControl) this.lblBottomRenewalControlno).Left = 195f / 16f;
    ((ARControl) this.lblBottomRenewalControlno).Name = "lblBottomRenewalControlno";
    this.lblBottomRenewalControlno.Style = "text-align: center; font-weight: bold; font-size: 8pt; vertical-align: bottom; ";
    this.lblBottomRenewalControlno.Text = "Renewal Control #";
    ((ARControl) this.lblBottomRenewalControlno).Top = 0.625f;
    ((ARControl) this.lblBottomRenewalControlno).Width = 9f / 16f;
    ((ARControl) this.lblMiddleRenewalControlno).Border.BottomColor = Color.Black;
    ((ARControl) this.lblMiddleRenewalControlno).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.lblMiddleRenewalControlno).Border.LeftColor = Color.Black;
    ((ARControl) this.lblMiddleRenewalControlno).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.lblMiddleRenewalControlno).Border.RightColor = Color.Black;
    ((ARControl) this.lblMiddleRenewalControlno).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.lblMiddleRenewalControlno).Border.TopColor = Color.Black;
    ((ARControl) this.lblMiddleRenewalControlno).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.lblMiddleRenewalControlno).Height = 3f / 16f;
    this.lblMiddleRenewalControlno.HyperLink = (string) null;
    ((ARControl) this.lblMiddleRenewalControlno).Left = 195f / 16f;
    ((ARControl) this.lblMiddleRenewalControlno).Name = "lblMiddleRenewalControlno";
    this.lblMiddleRenewalControlno.Style = "text-align: center; font-weight: bold; font-size: 8pt; ";
    this.lblMiddleRenewalControlno.Text = " ";
    ((ARControl) this.lblMiddleRenewalControlno).Top = 7f / 16f;
    ((ARControl) this.lblMiddleRenewalControlno).Width = 9f / 16f;
    ((ARControl) this.lblTopRenewalControlno).Border.BottomColor = Color.Black;
    ((ARControl) this.lblTopRenewalControlno).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.lblTopRenewalControlno).Border.LeftColor = Color.Black;
    ((ARControl) this.lblTopRenewalControlno).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.lblTopRenewalControlno).Border.RightColor = Color.Black;
    ((ARControl) this.lblTopRenewalControlno).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.lblTopRenewalControlno).Border.TopColor = Color.Black;
    ((ARControl) this.lblTopRenewalControlno).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.lblTopRenewalControlno).Height = 7f / 16f;
    this.lblTopRenewalControlno.HyperLink = (string) null;
    ((ARControl) this.lblTopRenewalControlno).Left = 195f / 16f;
    ((ARControl) this.lblTopRenewalControlno).Name = "lblTopRenewalControlno";
    this.lblTopRenewalControlno.Style = "text-align: center; font-weight: bold; font-size: 8pt; vertical-align: bottom; ";
    this.lblTopRenewalControlno.Text = "";
    ((ARControl) this.lblTopRenewalControlno).Top = 0.0f;
    ((ARControl) this.lblTopRenewalControlno).Width = 9f / 16f;
    ((ARControl) this.lblTopRenewalStatus).Border.BottomColor = Color.Black;
    ((ARControl) this.lblTopRenewalStatus).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.lblTopRenewalStatus).Border.LeftColor = Color.Black;
    ((ARControl) this.lblTopRenewalStatus).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.lblTopRenewalStatus).Border.RightColor = Color.Black;
    ((ARControl) this.lblTopRenewalStatus).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.lblTopRenewalStatus).Border.TopColor = Color.Black;
    ((ARControl) this.lblTopRenewalStatus).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.lblTopRenewalStatus).Height = 7f / 16f;
    this.lblTopRenewalStatus.HyperLink = (string) null;
    ((ARControl) this.lblTopRenewalStatus).Left = 12.75f;
    ((ARControl) this.lblTopRenewalStatus).Name = "lblTopRenewalStatus";
    this.lblTopRenewalStatus.Style = "text-align: center; font-weight: bold; font-size: 8pt; vertical-align: bottom; ";
    this.lblTopRenewalStatus.Text = "";
    ((ARControl) this.lblTopRenewalStatus).Top = 0.0f;
    ((ARControl) this.lblTopRenewalStatus).Width = 0.625f;
    ((ARControl) this.lblMiddleRenewalStatus).Border.BottomColor = Color.Black;
    ((ARControl) this.lblMiddleRenewalStatus).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.lblMiddleRenewalStatus).Border.LeftColor = Color.Black;
    ((ARControl) this.lblMiddleRenewalStatus).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.lblMiddleRenewalStatus).Border.RightColor = Color.Black;
    ((ARControl) this.lblMiddleRenewalStatus).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.lblMiddleRenewalStatus).Border.TopColor = Color.Black;
    ((ARControl) this.lblMiddleRenewalStatus).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.lblMiddleRenewalStatus).Height = 3f / 16f;
    this.lblMiddleRenewalStatus.HyperLink = (string) null;
    ((ARControl) this.lblMiddleRenewalStatus).Left = 12.75f;
    ((ARControl) this.lblMiddleRenewalStatus).Name = "lblMiddleRenewalStatus";
    this.lblMiddleRenewalStatus.Style = "text-align: center; font-weight: bold; font-size: 8pt; ";
    this.lblMiddleRenewalStatus.Text = " ";
    ((ARControl) this.lblMiddleRenewalStatus).Top = 7f / 16f;
    ((ARControl) this.lblMiddleRenewalStatus).Width = 0.625f;
    ((ARControl) this.lblBottomRenewalStatus).Border.BottomColor = Color.Black;
    ((ARControl) this.lblBottomRenewalStatus).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.lblBottomRenewalStatus).Border.LeftColor = Color.Black;
    ((ARControl) this.lblBottomRenewalStatus).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.lblBottomRenewalStatus).Border.RightColor = Color.Black;
    ((ARControl) this.lblBottomRenewalStatus).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.lblBottomRenewalStatus).Border.TopColor = Color.Black;
    ((ARControl) this.lblBottomRenewalStatus).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.lblBottomRenewalStatus).Height = 5f / 16f;
    this.lblBottomRenewalStatus.HyperLink = (string) null;
    ((ARControl) this.lblBottomRenewalStatus).Left = 12.75f;
    ((ARControl) this.lblBottomRenewalStatus).Name = "lblBottomRenewalStatus";
    this.lblBottomRenewalStatus.Style = "text-align: center; font-weight: bold; font-size: 8pt; vertical-align: bottom; ";
    this.lblBottomRenewalStatus.Text = "Renewal Status";
    ((ARControl) this.lblBottomRenewalStatus).Top = 0.625f;
    ((ARControl) this.lblBottomRenewalStatus).Width = 0.625f;
    ((ARControl) this.Label45).Border.BottomColor = Color.Black;
    ((ARControl) this.Label45).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label45).Border.LeftColor = Color.Black;
    ((ARControl) this.Label45).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label45).Border.RightColor = Color.Black;
    ((ARControl) this.Label45).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label45).Border.TopColor = Color.Black;
    ((ARControl) this.Label45).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label45).Height = 5f / 16f;
    this.Label45.HyperLink = (string) null;
    ((ARControl) this.Label45).Left = 7.958333f;
    ((ARControl) this.Label45).Name = "Label45";
    this.Label45.Style = "font-weight: bold; font-size: 8pt; vertical-align: bottom; ";
    this.Label45.Text = "Und. Assist";
    ((ARControl) this.Label45).Top = 0.625f;
    ((ARControl) this.Label45).Width = 0.4791667f;
    ((ARControl) this.Label46).Border.BottomColor = Color.Black;
    ((ARControl) this.Label46).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label46).Border.LeftColor = Color.Black;
    ((ARControl) this.Label46).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label46).Border.RightColor = Color.Black;
    ((ARControl) this.Label46).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label46).Border.TopColor = Color.Black;
    ((ARControl) this.Label46).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label46).Height = 7f / 16f;
    this.Label46.HyperLink = (string) null;
    ((ARControl) this.Label46).Left = 7.958333f;
    ((ARControl) this.Label46).Name = "Label46";
    this.Label46.Style = "text-align: center; font-weight: bold; font-size: 8pt; vertical-align: bottom; ";
    this.Label46.Text = "";
    ((ARControl) this.Label46).Top = 0.0f;
    ((ARControl) this.Label46).Width = 0.4791667f;
    ((ARControl) this.Label47).Border.BottomColor = Color.Black;
    ((ARControl) this.Label47).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label47).Border.LeftColor = Color.Black;
    ((ARControl) this.Label47).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label47).Border.RightColor = Color.Black;
    ((ARControl) this.Label47).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label47).Border.TopColor = Color.Black;
    ((ARControl) this.Label47).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label47).Height = 3f / 16f;
    this.Label47.HyperLink = (string) null;
    ((ARControl) this.Label47).Left = 7.958333f;
    ((ARControl) this.Label47).Name = "Label47";
    this.Label47.Style = "text-align: center; font-weight: bold; font-size: 8pt; ";
    this.Label47.Text = " ";
    ((ARControl) this.Label47).Top = 7f / 16f;
    ((ARControl) this.Label47).Width = 0.4791667f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfMonth).Controls.AddRange(new ARControl[5]
    {
      (ARControl) this.Label26,
      (ARControl) this.TextBox6,
      (ARControl) this.TextBox7,
      (ARControl) this.TextBox8,
      (ARControl) this.TextBox10
    });
    this.gfMonth.Height = 0.25f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfMonth).Name = "gfMonth";
    this.gfMonth.NewPage = (NewPage) 2;
    ((ARControl) this.Label26).Border.BottomColor = Color.Black;
    ((ARControl) this.Label26).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label26).Border.LeftColor = Color.Black;
    ((ARControl) this.Label26).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label26).Border.RightColor = Color.Black;
    ((ARControl) this.Label26).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label26).Border.TopColor = Color.Black;
    ((ARControl) this.Label26).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label26).Height = 3f / 16f;
    this.Label26.HyperLink = (string) null;
    ((ARControl) this.Label26).Left = 6.25f;
    ((ARControl) this.Label26).Name = "Label26";
    this.Label26.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 8.25pt; font-family: Microsoft Sans Serif; vertical-align: middle; ";
    this.Label26.Text = "Total:";
    ((ARControl) this.Label26).Top = 1f / 16f;
    ((ARControl) this.Label26).Width = 1.25f;
    ((ARControl) this.TextBox6).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox6).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox6).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox6).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox6).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox6).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox6).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox6).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox6).DataField = "ClaimCount";
    ((ARControl) this.TextBox6).Height = 3f / 16f;
    ((ARControl) this.TextBox6).Left = 10.25f;
    ((ARControl) this.TextBox6).Name = "TextBox6";
    this.TextBox6.OutputFormat = resourceManager.GetString("TextBox6.OutputFormat");
    this.TextBox6.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 6.75pt; font-family: Microsoft Sans Serif; vertical-align: middle; ";
    this.TextBox6.SummaryGroup = "ghMonth";
    this.TextBox6.SummaryRunning = (SummaryRunning) 1;
    this.TextBox6.SummaryType = (SummaryType) 3;
    this.TextBox6.Text = (string) null;
    ((ARControl) this.TextBox6).Top = 1f / 16f;
    ((ARControl) this.TextBox6).Width = 0.5f;
    ((ARControl) this.TextBox7).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox7).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox7).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox7).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox7).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox7).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox7).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox7).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox7).DataField = "TotalIncurred";
    ((ARControl) this.TextBox7).Height = 3f / 16f;
    ((ARControl) this.TextBox7).Left = 10.75f;
    ((ARControl) this.TextBox7).Name = "TextBox7";
    this.TextBox7.OutputFormat = resourceManager.GetString("TextBox7.OutputFormat");
    this.TextBox7.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 6.75pt; font-family: Microsoft Sans Serif; vertical-align: middle; ";
    this.TextBox7.SummaryGroup = "ghMonth";
    this.TextBox7.SummaryRunning = (SummaryRunning) 1;
    this.TextBox7.SummaryType = (SummaryType) 3;
    this.TextBox7.Text = (string) null;
    ((ARControl) this.TextBox7).Top = 1f / 16f;
    ((ARControl) this.TextBox7).Width = 13f / 16f;
    ((ARControl) this.TextBox8).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox8).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox8).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox8).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox8).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox8).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox8).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox8).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox8).DataField = "Premium";
    ((ARControl) this.TextBox8).Height = 3f / 16f;
    ((ARControl) this.TextBox8).Left = 7.875f;
    ((ARControl) this.TextBox8).Name = "TextBox8";
    this.TextBox8.OutputFormat = resourceManager.GetString("TextBox8.OutputFormat");
    this.TextBox8.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 6.75pt; font-family: Microsoft Sans Serif; vertical-align: middle; ";
    this.TextBox8.SummaryGroup = "ghMonth";
    this.TextBox8.SummaryRunning = (SummaryRunning) 1;
    this.TextBox8.SummaryType = (SummaryType) 3;
    this.TextBox8.Text = (string) null;
    ((ARControl) this.TextBox8).Top = 1f / 16f;
    ((ARControl) this.TextBox8).Width = 1.25f;
    ((ARControl) this.TextBox10).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox10).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox10).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox10).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox10).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox10).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox10).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox10).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox10).Height = 3f / 16f;
    ((ARControl) this.TextBox10).Left = 185f / 16f;
    ((ARControl) this.TextBox10).Name = "TextBox10";
    this.TextBox10.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 6.75pt; font-family: Microsoft Sans Serif; vertical-align: middle; ";
    this.TextBox10.SummaryGroup = "ghMonth";
    this.TextBox10.SummaryRunning = (SummaryRunning) 1;
    this.TextBox10.SummaryType = (SummaryType) 3;
    this.TextBox10.Text = (string) null;
    ((ARControl) this.TextBox10).Top = 1f / 16f;
    ((ARControl) this.TextBox10).Width = 0.625f;
    this.MasterReport = false;
    this.PageSettings.DefaultPaperSize = false;
    this.PageSettings.Margins.Bottom = 0.3f;
    this.PageSettings.Margins.Left = 0.3f;
    this.PageSettings.Margins.Right = 0.3f;
    this.PageSettings.Margins.Top = 0.3f;
    this.PageSettings.Orientation = (PageOrientation) 2;
    this.PageSettings.PaperHeight = 14f;
    this.PageSettings.PaperKind = PaperKind.Legal;
    this.PageSettings.PaperWidth = 8.5f;
    this.PrintWidth = 13.38541f;
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.ghYear);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.ghMonth);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfMonth);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfYear);
    this.StyleSheet.Add(new StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: normal; font-size: 10pt; color: Black; ", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-size: 16pt; font-weight: bold; ", "Heading1", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: italic; ", "Heading2", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-size: 13pt; font-weight: bold; ", "Heading3", "Normal"));
    ((ISupportInitialize) this.txtInsured).EndInit();
    ((ISupportInitialize) this.txtBroker).EndInit();
    ((ISupportInitialize) this.txtEffDate).EndInit();
    ((ISupportInitialize) this.txtCarrier).EndInit();
    ((ISupportInitialize) this.txtProd).EndInit();
    ((ISupportInitialize) this.txtPremium).EndInit();
    ((ISupportInitialize) this.txtLines).EndInit();
    ((ISupportInitialize) this.txtStatus).EndInit();
    ((ISupportInitialize) this.TextBox).EndInit();
    ((ISupportInitialize) this.TextBox1).EndInit();
    ((ISupportInitialize) this.TextBox2).EndInit();
    ((ISupportInitialize) this.TextBox3).EndInit();
    ((ISupportInitialize) this.TextBox4).EndInit();
    ((ISupportInitialize) this.TextBox5).EndInit();
    ((ISupportInitialize) this.TextBox9).EndInit();
    ((ISupportInitialize) this.lblRenewalControlno).EndInit();
    ((ISupportInitialize) this.lblRenewalStatus).EndInit();
    ((ISupportInitialize) this.TextBox11).EndInit();
    ((ISupportInitialize) this.Label1).EndInit();
    ((ISupportInitialize) this.Label3).EndInit();
    ((ISupportInitialize) this.Label4).EndInit();
    ((ISupportInitialize) this.Label5).EndInit();
    ((ISupportInitialize) this.Label6).EndInit();
    ((ISupportInitialize) this.Label7).EndInit();
    ((ISupportInitialize) this.Label8).EndInit();
    ((ISupportInitialize) this.Label9).EndInit();
    ((ISupportInitialize) this.Label10).EndInit();
    ((ISupportInitialize) this.Label11).EndInit();
    ((ISupportInitialize) this.Label12).EndInit();
    ((ISupportInitialize) this.Label13).EndInit();
    ((ISupportInitialize) this.Label14).EndInit();
    ((ISupportInitialize) this.Label15).EndInit();
    ((ISupportInitialize) this.Label16).EndInit();
    ((ISupportInitialize) this.Label17).EndInit();
    ((ISupportInitialize) this.Label19).EndInit();
    ((ISupportInitialize) this.Label20).EndInit();
    ((ISupportInitialize) this.Label21).EndInit();
    ((ISupportInitialize) this.Label22).EndInit();
    ((ISupportInitialize) this.Label23).EndInit();
    ((ISupportInitialize) this.Label24).EndInit();
    ((ISupportInitialize) this.Label25).EndInit();
    ((ISupportInitialize) this.txtMonthAndYear).EndInit();
    ((ISupportInitialize) this.Month).EndInit();
    ((ISupportInitialize) this.Year).EndInit();
    ((ISupportInitialize) this.Label).EndInit();
    ((ISupportInitialize) this.Label2).EndInit();
    ((ISupportInitialize) this.Label18).EndInit();
    ((ISupportInitialize) this.Label27).EndInit();
    ((ISupportInitialize) this.Label28).EndInit();
    ((ISupportInitialize) this.Label29).EndInit();
    ((ISupportInitialize) this.Label30).EndInit();
    ((ISupportInitialize) this.Label31).EndInit();
    ((ISupportInitialize) this.Label32).EndInit();
    ((ISupportInitialize) this.Label33).EndInit();
    ((ISupportInitialize) this.Label34).EndInit();
    ((ISupportInitialize) this.Label35).EndInit();
    ((ISupportInitialize) this.Label36).EndInit();
    ((ISupportInitialize) this.Label37).EndInit();
    ((ISupportInitialize) this.Label38).EndInit();
    ((ISupportInitialize) this.Label39).EndInit();
    ((ISupportInitialize) this.Label40).EndInit();
    ((ISupportInitialize) this.Label41).EndInit();
    ((ISupportInitialize) this.Label42).EndInit();
    ((ISupportInitialize) this.Label43).EndInit();
    ((ISupportInitialize) this.Label44).EndInit();
    ((ISupportInitialize) this.lblBottomRenewalControlno).EndInit();
    ((ISupportInitialize) this.lblMiddleRenewalControlno).EndInit();
    ((ISupportInitialize) this.lblTopRenewalControlno).EndInit();
    ((ISupportInitialize) this.lblTopRenewalStatus).EndInit();
    ((ISupportInitialize) this.lblMiddleRenewalStatus).EndInit();
    ((ISupportInitialize) this.lblBottomRenewalStatus).EndInit();
    ((ISupportInitialize) this.Label45).EndInit();
    ((ISupportInitialize) this.Label46).EndInit();
    ((ISupportInitialize) this.Label47).EndInit();
    ((ISupportInitialize) this.Label26).EndInit();
    ((ISupportInitialize) this.TextBox6).EndInit();
    ((ISupportInitialize) this.TextBox7).EndInit();
    ((ISupportInitialize) this.TextBox8).EndInit();
    ((ISupportInitialize) this.TextBox10).EndInit();
    ((ISupportInitialize) this).EndInit();
  }

  public Type getLaunchForm => (Type) null;

  public BaseReportControl[] getReportControls
  {
    get
    {
      Underwriters_Multi underwritersMulti = !SecurityManager.Instance.AssertPermission("{C3353D0F-5206-4ed8-86F4-DAC33F2E24AC}") ? new Underwriters_Multi("Underwriter", this.CurrentUserGuid) : new Underwriters_Multi("Underwriter", true);
      GenericComboBox genericComboBox1 = !SecurityManager.Instance.AssertPermission("{1841D651-9C8A-444d-92EC-503F074C390C}") ? new GenericComboBox("In-House Producer", $"(SELECT 1 As Sort, tblUsers.FirstName + ' ' + tblUsers.LastName As UserName, UserGuid FROM tblUsers WHERE UserGuid = '{this.CurrentUserGuid}') ORDER BY Sort", "UserGuid", "UserName", typeof (Guid)) : new GenericComboBox("In-House Producer", $"(SELECT -1 As Sort, 'All In-House Producers' As UserName, '{Guid.Empty}' As UserGuid) UNION (SELECT DISTINCT 1 As Sort, tblUsers.FirstName + ' ' + tblUsers.LastName As UserName, UserGuid FROM tblSubmissionGroup INNER JOIN tblUsers ON tblSubmissionGroup.InHouseProducerUserGuid = tblUsers.UserGUID) ORDER BY Sort,UserName", "UserGuid", "UserName", typeof (Guid));
      GenericComboBox genericComboBox2 = !SecurityManager.Instance.AssertPermission("{E3ABCDE6-7FAA-46BE-8B9B-9A291963BBE9}") ? new GenericComboBox("TA/CSR", $"(SELECT 1 As [Order], FirstName + ' ' + LastName As [Name], UserGuid FROM tblUsers WHERE UserGuid = '{this.CurrentUserGuid}')", "UserGuid", "Name", typeof (Guid)) : new GenericComboBox("TA/CSR", string.Format("((SELECT -1 As [Order], 'All TA/CSRs' As [Name], '00000000-0000-0000-0000-000000000000' As UserGuid) UNION (SELECT 1 As [Order], FirstName + ' ' + LastName As [Name], UserGuid FROM tblUsers WHERE EXISTS(SELECT TACSRUSerGuid FROM tblQuotes WHERE TACSRUSerGuid IS NOT NULL)))ORDER BY [Order], [Name]", (object) Guid.Empty), "UserGuid", "Name", typeof (string));
      BaseReportControl[] getReportControls = new BaseReportControl[16 /*0x10*/]
      {
        (BaseReportControl) new Producers_Multi("Producer(s)", true),
        (BaseReportControl) new CompanyLocations("Company Location", true),
        (BaseReportControl) new GenericComboBox("Company Group", $"((SELECT -1 As Sort, 'All Groups' As CompanyGroupName, '{Guid.Empty}' As CompanyGroupGuid) UNION (SELECT 1 As Sort, CompanyGroupName, CompanyGroupGuid FROM tblCompanyGroups)) ORDER BY Sort, CompanyGroupName", "CompanyGroupGuid", "CompanyGroupName", typeof (Guid)),
        (BaseReportControl) underwritersMulti,
        (BaseReportControl) genericComboBox2,
        null,
        (BaseReportControl) new GenericComboBox("Cost Center", "((SELECT -1 As Sort, 'All Cost Centers' As Display, 0 As Value) UNION (SELECT 1 As Sort, GroupName AS Display, GroupId AS Value FROM tblEntityGroups)) ORDER BY Sort, Display", "Value", "Display", typeof (int)),
        (BaseReportControl) new GenericComboBox("Line", $"(SELECT 0 As Sort, 'All Lines' As Display, '{Guid.Empty}' As Value) UNION (SELECT 1 As Sort, LineName As Display, LineGuid As Value FROM lstLines) ORDER BY Sort, Display", "Value", "Display", typeof (Guid)),
        (BaseReportControl) new GenericComboBox("Department", "(SELECT 'All Groups' AS GroupName, -1 AS GroupID, 0 as sort) UNION (SELECT DISTINCT dbo.tblEntityGroups.GroupName, dbo.tblEntityGroups.GroupId, 1 as sort FROM dbo.tblEntityGroups INNER JOIN dbo.tblEntityGroupEntities ON dbo.tblEntityGroups.GroupId = dbo.tblEntityGroupEntities.GroupId INNER JOIN dbo.tblUsers ON dbo.tblEntityGroupEntities.EntityGuid = dbo.tblUsers.UserGUID) ORDER BY sort, GroupName", "GroupID", "GroupName", typeof (int)),
        (BaseReportControl) new OfficeLocations("Issuing Office", true),
        (BaseReportControl) genericComboBox1,
        null,
        null,
        null,
        null,
        null
      };
      DateTime now = DateAndTime.Now;
      DateTime date1 = now.Date;
      now = DateAndTime.Now;
      DateTime date2 = now.Date;
      getReportControls[11] = (BaseReportControl) new DateRangePicker("Expiration Date", date1, date2, false);
      getReportControls[12] = (BaseReportControl) new GenericCheckBox("Non-Renewal Items", "Include Non-Renewal Items");
      getReportControls[13] = (BaseReportControl) new TextInput("Enter minimum premium ", TextInput.ReturnType.Dec, false);
      getReportControls[14] = (BaseReportControl) new MoneyRange("Total Acct Premium from", true);
      getReportControls[15] = (BaseReportControl) new GenericCheckBox("Hide Renewals", "Hide Renewals");
      return getReportControls;
    }
  }

  public override void ExportToExcel(string SaveFileTo)
  {
    ExcelExport.ToExcel(this._dt, SaveFileTo);
  }

  private void ghMonth_Format(object sender, EventArgs e)
  {
  }
}
