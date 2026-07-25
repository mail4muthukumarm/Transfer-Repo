// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Rating.FormDriversInfo
// Assembly: MgaSystems.IMS.Rating, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 370B8F0A-FA1A-41D0-87BD-563CC23E9EA7
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Rating.dll

using GrapeCity.ActiveReports;
using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinMaskedEdit;
using Infragistics.Win.UltraWinScrollBar;
using Infragistics.Win.UltraWinTabControl;
using Infragistics.Win.UltraWinTabs;
using Mga.Wpf.Ims.ExtensionMethods;
using MGASystems.AsposeFacade.Words;
using MGASystems.BusinessObjects;
using MGASystems.Common;
using MGASystems.Common.BroadcastMessaging;
using MGASystems.Common.Enums;
using MGASystems.Common.ErrorHandling;
using MGASystems.Common.Extensions;
using MGASystems.Data;
using MGASystems.Data.DataEncryption;
using MGASystems.IMS.DocumentAutomation.TemplateDocuments;
using MGASystems.IMS.NoteDocuments;
using MGASystems.IMS.NoteDocuments.DocumentSystem;
using MGASystems.IMS.Reporting;
using MGASystems.IMS.Security;
using MgaSystems.IMS.UnderwritingServices;
using MgaSystems.IMS.UnderwritingServices.Proxy.Verisk.Iix;
using MgaSystems.IMS.UnderwritingServices.Verisk.Controller;
using MgaSystems.IMS.UnderwritingServices.Verisk.ServiceObjects.Mvr;
using MGASystems.Tools;
using MGASystems.Tools.DBSaveUI;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Policies.Rating;

[DesignerGenerated]
[SecureResource("{94A70A52-72AD-41FC-AB43-E80119EB97C7}", "Can View Driver DOB", "Allows users to view drivers date of birth.", "Drivers")]
[SecureResource("{6737F846-CC52-4FBF-BFD3-11506D3551AE}", "Can View Driver License Number", "Allows users to view drivers license number.", "Drivers")]
public class FormDriversInfo : Form
{
  private IContainer components;
  private Guid _QuoteGuid;
  private readonly int _ControlNo;
  private SqlDataAdapter daDrivers;
  private SqlConnection cnSQL;
  private SqlCommand sqlSelectCommand2;
  private UltraDropDown uddDriverStatus;
  private UltraDropDown uddState;
  private SqlCommand sqlSelectCommand1;
  private SqlCommand sqlInsertCommand1;
  private SqlCommand sqlUpdateCommand1;
  private SqlCommand sqlDeleteCommand1;
  private SqlCommand sqlSelectCommand3;
  private Lazy<int> _ADRPassStatusID;
  private Lazy<int> _ADRFailStatusID;
  private string _billing;
  private Quote _currentQuote;
  private Lazy<int> _deletedStatusID;
  private const string _unAvailableString = "<Unavailable>";
  private const string _noneString = "<None>";
  private bool _includeLicenseNumberInFileName;
  private bool _generateGenericTemplate;
  private bool _requireDobForProcecessing;
  private bool _iixOrders;
  private bool _useVolta;
  private bool _canViewLicense;
  private bool _canViewDOB;
  private bool _encryptDriverData;
  private const string _activityTriggeredString = "ACTIVITY TRIGGERED";
  private bool _usePdf;
  private Lazy<bool> _excludeDeletedDrivers;
  public const string CanViewDriverDOB = "{94A70A52-72AD-41FC-AB43-E80119EB97C7}";
  public const string CanViewDriverLicense = "{6737F846-CC52-4FBF-BFD3-11506D3551AE}";
  private static CoffeeTripleDesEncrypter _encryptor = new CoffeeTripleDesEncrypter();

  [DebuggerNonUserCode]
  protected override void Dispose(bool disposing)
  {
    try
    {
      if (!disposing || this.components == null)
        return;
      this.components.Dispose();
    }
    finally
    {
      base.Dispose(disposing);
    }
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    Appearance appearance1 = new Appearance();
    UltraGridBand ultraGridBand1 = new UltraGridBand("lstDriverCDL", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("ID");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("CDL");
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    Appearance appearance11 = new Appearance();
    Appearance appearance12 = new Appearance();
    Appearance appearance13 = new Appearance();
    Appearance appearance14 = new Appearance();
    ScrollBarLook scrollBarLook1 = new ScrollBarLook();
    Appearance appearance15 = new Appearance();
    Appearance appearance16 = new Appearance();
    Appearance appearance17 = new Appearance();
    Appearance appearance18 = new Appearance();
    Appearance appearance19 = new Appearance();
    Appearance appearance20 = new Appearance();
    Appearance appearance21 = new Appearance();
    Appearance appearance22 = new Appearance();
    Appearance appearance23 = new Appearance();
    Appearance appearance24 = new Appearance();
    Appearance appearance25 = new Appearance();
    Appearance appearance26 = new Appearance();
    Appearance appearance27 = new Appearance();
    Appearance appearance28 = new Appearance();
    Appearance appearance29 = new Appearance();
    Appearance appearance30 = new Appearance();
    UltraGridBand ultraGridBand2 = new UltraGridBand("lstDriverStatusInfo", -1);
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("ID");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("Status");
    Appearance appearance31 = new Appearance();
    Appearance appearance32 = new Appearance();
    Appearance appearance33 = new Appearance();
    Appearance appearance34 = new Appearance();
    Appearance appearance35 = new Appearance();
    Appearance appearance36 = new Appearance();
    Appearance appearance37 = new Appearance();
    Appearance appearance38 = new Appearance();
    Appearance appearance39 = new Appearance();
    ScrollBarLook scrollBarLook2 = new ScrollBarLook();
    Appearance appearance40 = new Appearance();
    Appearance appearance41 = new Appearance();
    Appearance appearance42 = new Appearance();
    Appearance appearance43 = new Appearance();
    Appearance appearance44 = new Appearance();
    Appearance appearance45 = new Appearance();
    Appearance appearance46 = new Appearance();
    UltraGridBand ultraGridBand3 = new UltraGridBand("lstDriverStatus", -1);
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("DriverStatusID");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("Status");
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("Inactive");
    Appearance appearance47 = new Appearance();
    Appearance appearance48 = new Appearance();
    Appearance appearance49 = new Appearance();
    Appearance appearance50 = new Appearance();
    Appearance appearance51 = new Appearance();
    Appearance appearance52 = new Appearance();
    Appearance appearance53 = new Appearance();
    Appearance appearance54 = new Appearance();
    Appearance appearance55 = new Appearance();
    Appearance appearance56 = new Appearance();
    Appearance appearance57 = new Appearance();
    Appearance appearance58 = new Appearance();
    Appearance appearance59 = new Appearance();
    ScrollBarLook scrollBarLook3 = new ScrollBarLook();
    Appearance appearance60 = new Appearance();
    UltraGridBand ultraGridBand4 = new UltraGridBand("lstStates", -1);
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("StateID");
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("State");
    Appearance appearance61 = new Appearance();
    Appearance appearance62 = new Appearance();
    Appearance appearance63 = new Appearance();
    Appearance appearance64 = new Appearance();
    Appearance appearance65 = new Appearance();
    Appearance appearance66 = new Appearance();
    Appearance appearance67 = new Appearance();
    Appearance appearance68 = new Appearance();
    Appearance appearance69 = new Appearance();
    Appearance appearance70 = new Appearance();
    Appearance appearance71 = new Appearance();
    Appearance appearance72 = new Appearance();
    Appearance appearance73 = new Appearance();
    ScrollBarLook scrollBarLook4 = new ScrollBarLook();
    Appearance appearance74 = new Appearance();
    Appearance appearance75 = new Appearance();
    Appearance appearance76 = new Appearance();
    Appearance appearance77 = new Appearance();
    Appearance appearance78 = new Appearance();
    Appearance appearance79 = new Appearance();
    Appearance appearance80 = new Appearance();
    Appearance appearance81 = new Appearance();
    Appearance appearance82 = new Appearance();
    Appearance appearance83 = new Appearance();
    Appearance appearance84 = new Appearance();
    Appearance appearance85 = new Appearance();
    Appearance appearance86 = new Appearance();
    Appearance appearance87 = new Appearance();
    Appearance appearance88 = new Appearance();
    Appearance appearance89 = new Appearance();
    Appearance appearance90 = new Appearance();
    Appearance appearance91 = new Appearance();
    Appearance appearance92 = new Appearance();
    Appearance appearance93 = new Appearance();
    Appearance appearance94 = new Appearance();
    Appearance appearance95 = new Appearance();
    Appearance appearance96 = new Appearance();
    Appearance appearance97 = new Appearance();
    Appearance appearance98 = new Appearance();
    Appearance appearance99 = new Appearance();
    Appearance appearance100 = new Appearance();
    Appearance appearance101 = new Appearance();
    Appearance appearance102 = new Appearance();
    Appearance appearance103 = new Appearance();
    Appearance appearance104 = new Appearance();
    Appearance appearance105 = new Appearance();
    Appearance appearance106 = new Appearance();
    UltraGridBand ultraGridBand5 = new UltraGridBand("tblUsers", -1);
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("UserGUID");
    UltraGridColumn ultraGridColumn11 = new UltraGridColumn("Name_LastFirst");
    Appearance appearance107 = new Appearance();
    Appearance appearance108 = new Appearance();
    Appearance appearance109 = new Appearance();
    Appearance appearance110 = new Appearance();
    Appearance appearance111 = new Appearance();
    Appearance appearance112 = new Appearance();
    Appearance appearance113 = new Appearance();
    Appearance appearance114 = new Appearance();
    Appearance appearance115 = new Appearance();
    Appearance appearance116 = new Appearance();
    Appearance appearance117 = new Appearance();
    Appearance appearance118 = new Appearance();
    Appearance appearance119 = new Appearance();
    ScrollBarLook scrollBarLook5 = new ScrollBarLook();
    Appearance appearance120 = new Appearance();
    Appearance appearance121 = new Appearance();
    UltraTab ultraTab1 = new UltraTab();
    Appearance appearance122 = new Appearance();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (FormDriversInfo));
    UltraTab ultraTab2 = new UltraTab();
    Appearance appearance123 = new Appearance();
    UltraTab ultraTab3 = new UltraTab();
    Appearance appearance124 = new Appearance();
    Appearance appearance125 = new Appearance();
    Appearance appearance126 = new Appearance();
    Appearance appearance127 = new Appearance();
    UltraGridBand ultraGridBand6 = new UltraGridBand("lstDriverCDL", -1);
    UltraGridColumn ultraGridColumn12 = new UltraGridColumn("ID");
    UltraGridColumn ultraGridColumn13 = new UltraGridColumn("CDL");
    Appearance appearance128 = new Appearance();
    Appearance appearance129 = new Appearance();
    Appearance appearance130 = new Appearance();
    Appearance appearance131 = new Appearance();
    Appearance appearance132 = new Appearance();
    Appearance appearance133 = new Appearance();
    Appearance appearance134 = new Appearance();
    Appearance appearance135 = new Appearance();
    Appearance appearance136 = new Appearance();
    Appearance appearance137 = new Appearance();
    Appearance appearance138 = new Appearance();
    Appearance appearance139 = new Appearance();
    UltraGridBand ultraGridBand7 = new UltraGridBand("lstStates", -1);
    UltraGridColumn ultraGridColumn14 = new UltraGridColumn("StateID");
    UltraGridColumn ultraGridColumn15 = new UltraGridColumn("State");
    Appearance appearance140 = new Appearance();
    Appearance appearance141 = new Appearance();
    Appearance appearance142 = new Appearance();
    Appearance appearance143 = new Appearance();
    Appearance appearance144 = new Appearance();
    Appearance appearance145 = new Appearance();
    Appearance appearance146 = new Appearance();
    Appearance appearance147 = new Appearance();
    Appearance appearance148 = new Appearance();
    Appearance appearance149 = new Appearance();
    Appearance appearance150 = new Appearance();
    Appearance appearance151 = new Appearance();
    UltraGridBand ultraGridBand8 = new UltraGridBand("lstDriverStatus", -1);
    UltraGridColumn ultraGridColumn16 = new UltraGridColumn("DriverStatusID");
    UltraGridColumn ultraGridColumn17 = new UltraGridColumn("Status");
    UltraGridColumn ultraGridColumn18 = new UltraGridColumn("Inactive");
    Appearance appearance152 = new Appearance();
    Appearance appearance153 = new Appearance();
    Appearance appearance154 = new Appearance();
    Appearance appearance155 = new Appearance();
    Appearance appearance156 = new Appearance();
    Appearance appearance157 = new Appearance();
    Appearance appearance158 = new Appearance();
    Appearance appearance159 = new Appearance();
    Appearance appearance160 = new Appearance();
    Appearance appearance161 = new Appearance();
    Appearance appearance162 = new Appearance();
    Appearance appearance163 = new Appearance();
    UltraGridBand ultraGridBand9 = new UltraGridBand("tblDriverInfo", -1);
    UltraGridColumn ultraGridColumn19 = new UltraGridColumn("DriverID");
    UltraGridColumn ultraGridColumn20 = new UltraGridColumn("ControlNo");
    UltraGridColumn ultraGridColumn21 = new UltraGridColumn("QuoteGuid");
    UltraGridColumn ultraGridColumn22 = new UltraGridColumn("FirstName");
    UltraGridColumn ultraGridColumn23 = new UltraGridColumn("LastName");
    UltraGridColumn ultraGridColumn24 = new UltraGridColumn("DOB");
    UltraGridColumn ultraGridColumn25 = new UltraGridColumn("LicenseNumber");
    UltraGridColumn ultraGridColumn26 = new UltraGridColumn("StateID", -1, (object) "uddState");
    UltraGridColumn ultraGridColumn27 = new UltraGridColumn("StatusID", -1, (object) "uddDriverStatus");
    UltraGridColumn ultraGridColumn28 = new UltraGridColumn("DateAdded");
    UltraGridColumn ultraGridColumn29 = new UltraGridColumn("DriverDeleted");
    UltraGridColumn ultraGridColumn30 = new UltraGridColumn("DriverAdded");
    UltraGridColumn ultraGridColumn31 = new UltraGridColumn("NumberOfPoints");
    UltraGridColumn ultraGridColumn32 = new UltraGridColumn("FurnishedCar");
    UltraGridColumn ultraGridColumn33 = new UltraGridColumn("Comments");
    UltraGridColumn ultraGridColumn34 = new UltraGridColumn("FullPartTime");
    UltraGridColumn ultraGridColumn35 = new UltraGridColumn("CopyOnRenewal");
    UltraGridColumn ultraGridColumn36 = new UltraGridColumn("ModifiedDate");
    UltraGridColumn ultraGridColumn37 = new UltraGridColumn("LicenseExpDate");
    UltraGridColumn ultraGridColumn38 = new UltraGridColumn("Street1");
    UltraGridColumn ultraGridColumn39 = new UltraGridColumn("Street2");
    UltraGridColumn ultraGridColumn40 = new UltraGridColumn("City");
    UltraGridColumn ultraGridColumn41 = new UltraGridColumn("ZipCode");
    UltraGridColumn ultraGridColumn42 = new UltraGridColumn("ZipPlus");
    UltraGridColumn ultraGridColumn43 = new UltraGridColumn("DriverRatingFactor");
    UltraGridColumn ultraGridColumn44 = new UltraGridColumn("LicenseClass");
    UltraGridColumn ultraGridColumn45 = new UltraGridColumn("ADR");
    UltraGridColumn ultraGridColumn46 = new UltraGridColumn("NumAtFaultAcc");
    UltraGridColumn ultraGridColumn47 = new UltraGridColumn("NumOtherAcc");
    UltraGridColumn ultraGridColumn48 = new UltraGridColumn("SpeedingLessTenMPH");
    UltraGridColumn ultraGridColumn49 = new UltraGridColumn("SpeedingMoreTenMPH");
    UltraGridColumn ultraGridColumn50 = new UltraGridColumn("SecVltns");
    UltraGridColumn ultraGridColumn51 = new UltraGridColumn("EquipVltns");
    UltraGridColumn ultraGridColumn52 = new UltraGridColumn("OtherMovingVltns");
    UltraGridColumn ultraGridColumn53 = new UltraGridColumn("TotalVtlns");
    UltraGridColumn ultraGridColumn54 = new UltraGridColumn("MedicalExpiration");
    UltraGridColumn ultraGridColumn55 = new UltraGridColumn("NoteRecipient");
    UltraGridColumn ultraGridColumn56 = new UltraGridColumn("NoteSubject");
    UltraGridColumn ultraGridColumn57 = new UltraGridColumn("NoteBody");
    UltraGridColumn ultraGridColumn58 = new UltraGridColumn("DaysDue");
    UltraGridColumn ultraGridColumn59 = new UltraGridColumn("PopUpNote");
    UltraGridColumn ultraGridColumn60 = new UltraGridColumn("DateOfHire");
    UltraGridColumn ultraGridColumn61 = new UltraGridColumn("DateOfOrigCDL");
    UltraGridColumn ultraGridColumn62 = new UltraGridColumn("YearsLogTruckExperienceNum");
    UltraGridColumn ultraGridColumn63 = new UltraGridColumn("MVRDate");
    UltraGridColumn ultraGridColumn64 = new UltraGridColumn("CDLDriverID", -1, (object) "uddCDL");
    UltraGridColumn ultraGridColumn65 = new UltraGridColumn("DriverExcluded");
    UltraGridColumn ultraGridColumn66 = new UltraGridColumn("GenerateDoc");
    UltraGridColumn ultraGridColumn67 = new UltraGridColumn("DOC");
    UltraGridColumn ultraGridColumn68 = new UltraGridColumn("JobTitle");
    UltraGridColumn ultraGridColumn69 = new UltraGridColumn("LicenseNumberEncrypted");
    UltraGridColumn ultraGridColumn70 = new UltraGridColumn("DOBEncrypted");
    UltraGridColumn ultraGridColumn71 = new UltraGridColumn("BulkDelete");
    UltraGridColumn ultraGridColumn72 = new UltraGridColumn("TruVision", -1, (object) null, 0, (SortIndicator) 1, false);
    Appearance appearance164 = new Appearance();
    Appearance appearance165 = new Appearance();
    Appearance appearance166 = new Appearance();
    Appearance appearance167 = new Appearance();
    Appearance appearance168 = new Appearance();
    Appearance appearance169 = new Appearance();
    Appearance appearance170 = new Appearance();
    ScrollBarLook scrollBarLook6 = new ScrollBarLook();
    Appearance appearance171 = new Appearance();
    Appearance appearance172 = new Appearance();
    this.tabDriverInfo = new UltraTabPageControl();
    this.Label36 = new Label();
    this.cboCDLDriver = new MGAComboBox();
    this.ds = new dsDriverInfo();
    this.Label34 = new Label();
    this.dtMVRDate = new MGADateTimePicker();
    this.Label29 = new Label();
    this.dtMedicalExpiration = new MGADateTimePicker();
    this.chkFurnishedCar = new MGACheckBox();
    this.MgaTextBox1 = new MGATextBox();
    this.Label12 = new Label();
    this.Label11 = new Label();
    this.numDriverRatingFactor = new MGANumericEditor();
    this.Label10 = new Label();
    this.Label8 = new Label();
    this.Label7 = new Label();
    this.Label6 = new Label();
    this.Label5 = new Label();
    this.Label3 = new Label();
    this.Label9 = new Label();
    this.Label21 = new Label();
    this.Label2 = new Label();
    this.Label22 = new Label();
    this.Label1 = new Label();
    this.Label23 = new Label();
    this.Label20 = new Label();
    this.Label18 = new Label();
    this.Label4 = new Label();
    this.Label19 = new Label();
    this.txtZipPlus = new MGATextBox();
    this.Label17 = new Label();
    this.txtZipCode = new MGATextBox();
    this.txtCity = new MGATextBox();
    this.txtStreet2 = new MGATextBox();
    this.txtStreet1 = new MGATextBox();
    this.dtLicenseExpDate = new MGADateTimePicker();
    this.MgaCheckBox1 = new MGACheckBox();
    this.cboFullorPartTime = new MGAComboBox();
    this.txtNumPoints = new MGATextBox();
    this.txtComments = new MGATextBox();
    this.dtpDriverAdded = new MGADateTimePicker();
    this.dtpDriverDeleted = new MGADateTimePicker();
    this.comboDriverStatus = new MGAComboBox();
    this.comboState = new MGAComboBox();
    this.txtLicenseNumber = new MGATextBox();
    this.dtPDateOfBirth = new MGADateTimePicker();
    this.txtLastName = new MGATextBox();
    this.txtFirstName = new MGATextBox();
    this.tabAddlDriverInfo = new UltraTabPageControl();
    this.txtErrorDescription = new MGATextBox();
    this.lblErrorDescription = new Label();
    this.txtCompanyClass = new MGATextBox();
    this.txtInvoicePath = new MGATextBox();
    this.lblCompanyClass = new Label();
    this.lblInvoicePath = new Label();
    this.txtMatchError = new MGATextBox();
    this.lblMatchError = new Label();
    this.txtDocumentValidationResult = new MGATextBox();
    this.lblLicenseValidationResult = new Label();
    this.MgaTextBox13 = new MGATextBox();
    this.Label41 = new Label();
    this.chkHasDOC = new MGACheckBox();
    this.Label38 = new Label();
    this.dtpDriverExcluded = new MGADateTimePicker();
    this.lblYearsLogTruckExperience = new Label();
    this.numYearsLogTruckExperienceNum = new MGANumericEditor();
    this.Label35 = new Label();
    this.dtpDateOfOrigCDL = new MGADateTimePicker();
    this.lblDateOfHire = new Label();
    this.dtpDateOfHire = new MGADateTimePicker();
    this.GroupBox1 = new GroupBox();
    this.txtDLStatus = new MGATextBox();
    this.lblDLStatus = new Label();
    this.txtValid = new MGATextBox();
    this.txtIsClear = new MGATextBox();
    this.Label40 = new Label();
    this.Label39 = new Label();
    this.MgaTextBox9 = new MGATextBox();
    this.Label28 = new Label();
    this.MgaTextBox8 = new MGATextBox();
    this.Label26 = new Label();
    this.MgaTextBox7 = new MGATextBox();
    this.Label25 = new Label();
    this.MgaTextBox6 = new MGATextBox();
    this.Label14 = new Label();
    this.MgaTextBox2 = new MGATextBox();
    this.Label13 = new Label();
    this.MgaTextBox5 = new MGATextBox();
    this.Label24 = new Label();
    this.MgaTextBox4 = new MGATextBox();
    this.Label16 = new Label();
    this.MgaTextBox3 = new MGATextBox();
    this.Label15 = new Label();
    this.tabNotes = new UltraTabPageControl();
    this.btnCopyOnRenewal = new MGAButton();
    this.lnkDeSelectAllCopyRenewal = new LinkLabel();
    this.lnkSelectAllCopyRenewal = new LinkLabel();
    this.btnBulkDelete = new MGAButton();
    this.lnkDeSelectDeletes = new LinkLabel();
    this.lnkSelectDeletes = new LinkLabel();
    this.GroupBox2 = new GroupBox();
    this.chkPopup = new MGACheckBox();
    this.Label33 = new Label();
    this.MgaTextBox12 = new MGATextBox();
    this.Label32 = new Label();
    this.MgaTextBox11 = new MGATextBox();
    this.Label31 = new Label();
    this.MgaComboBox1 = new MGAComboBox();
    this.Label30 = new Label();
    this.MgaTextBox10 = new MGATextBox();
    this.err = new ErrorProvider(this.components);
    this.lnkDeletedRecords = new LinkLabel();
    this.daDrivers = new SqlDataAdapter();
    this.sqlDeleteCommand1 = new SqlCommand();
    this.cnSQL = new SqlConnection();
    this.sqlInsertCommand1 = new SqlCommand();
    this.sqlSelectCommand1 = new SqlCommand();
    this.sqlUpdateCommand1 = new SqlCommand();
    this.sqlSelectCommand2 = new SqlCommand();
    this.sqlSelectCommand3 = new SqlCommand();
    this.lnkCopyFromExpiringQuote = new LinkLabel();
    this.lnkCopyFromAnotherQuote = new LinkLabel();
    this.lnkPrintDrivers = new LinkLabel();
    this.lnkADRConnect = new LinkLabel();
    this.lnkSelectAll = new LinkLabel();
    this.lnkDeSelectAll = new LinkLabel();
    this.panelProcessingADR = new UltraGroupBox();
    this.spinner = new PictureBox();
    this.labelSearchText = new Label();
    this.lnkPasswordUpdate = new LinkLabel();
    this.tabDriverTab = new UltraTabControl();
    this.ultraTabSharedControlsPage1 = new UltraTabSharedControlsPage();
    this.lnkOvernightOrders = new LinkLabel();
    this.lnkGenerateDocument = new LinkLabel();
    this.Label37 = new Label();
    this.btnProcessOvernightOrders = new Button();
    this.UltraTextEditor1 = new UltraTextEditor();
    this.btnIIX = new MGAButton();
    this.cboTemplates = new MGASimpleComboBox();
    this.btnQuery = new MGAButton();
    this.dbSave = new MGASystems.Tools.DBSaveUI.DBSaveUI();
    this.uddCDL = new UltraDropDown();
    this.uddState = new UltraDropDown();
    this.uddDriverStatus = new UltraDropDown();
    this.ugDrivers = new UltraGrid();
    this.lnkSambaOffice = new LinkLabel();
    Label label = new Label();
    ((Control) this.tabDriverInfo).SuspendLayout();
    ((ISupportInitialize) this.cboCDLDriver).BeginInit();
    this.ds.BeginInit();
    ((ISupportInitialize) this.dtMVRDate).BeginInit();
    ((ISupportInitialize) this.dtMedicalExpiration).BeginInit();
    ((ISupportInitialize) this.chkFurnishedCar).BeginInit();
    ((ISupportInitialize) this.MgaTextBox1).BeginInit();
    ((ISupportInitialize) this.numDriverRatingFactor).BeginInit();
    ((ISupportInitialize) this.txtZipPlus).BeginInit();
    ((ISupportInitialize) this.txtZipCode).BeginInit();
    ((ISupportInitialize) this.txtCity).BeginInit();
    ((ISupportInitialize) this.txtStreet2).BeginInit();
    ((ISupportInitialize) this.txtStreet1).BeginInit();
    ((ISupportInitialize) this.dtLicenseExpDate).BeginInit();
    ((ISupportInitialize) this.MgaCheckBox1).BeginInit();
    ((ISupportInitialize) this.cboFullorPartTime).BeginInit();
    ((ISupportInitialize) this.txtNumPoints).BeginInit();
    ((ISupportInitialize) this.txtComments).BeginInit();
    ((ISupportInitialize) this.dtpDriverAdded).BeginInit();
    ((ISupportInitialize) this.dtpDriverDeleted).BeginInit();
    ((ISupportInitialize) this.comboDriverStatus).BeginInit();
    ((ISupportInitialize) this.comboState).BeginInit();
    ((ISupportInitialize) this.txtLicenseNumber).BeginInit();
    ((ISupportInitialize) this.dtPDateOfBirth).BeginInit();
    ((ISupportInitialize) this.txtLastName).BeginInit();
    ((ISupportInitialize) this.txtFirstName).BeginInit();
    ((Control) this.tabAddlDriverInfo).SuspendLayout();
    ((ISupportInitialize) this.txtErrorDescription).BeginInit();
    ((ISupportInitialize) this.txtCompanyClass).BeginInit();
    ((ISupportInitialize) this.txtInvoicePath).BeginInit();
    ((ISupportInitialize) this.txtMatchError).BeginInit();
    ((ISupportInitialize) this.txtDocumentValidationResult).BeginInit();
    ((ISupportInitialize) this.MgaTextBox13).BeginInit();
    ((ISupportInitialize) this.chkHasDOC).BeginInit();
    ((ISupportInitialize) this.dtpDriverExcluded).BeginInit();
    ((ISupportInitialize) this.numYearsLogTruckExperienceNum).BeginInit();
    ((ISupportInitialize) this.dtpDateOfOrigCDL).BeginInit();
    ((ISupportInitialize) this.dtpDateOfHire).BeginInit();
    this.GroupBox1.SuspendLayout();
    ((ISupportInitialize) this.txtDLStatus).BeginInit();
    ((ISupportInitialize) this.txtValid).BeginInit();
    ((ISupportInitialize) this.txtIsClear).BeginInit();
    ((ISupportInitialize) this.MgaTextBox9).BeginInit();
    ((ISupportInitialize) this.MgaTextBox8).BeginInit();
    ((ISupportInitialize) this.MgaTextBox7).BeginInit();
    ((ISupportInitialize) this.MgaTextBox6).BeginInit();
    ((ISupportInitialize) this.MgaTextBox2).BeginInit();
    ((ISupportInitialize) this.MgaTextBox5).BeginInit();
    ((ISupportInitialize) this.MgaTextBox4).BeginInit();
    ((ISupportInitialize) this.MgaTextBox3).BeginInit();
    ((Control) this.tabNotes).SuspendLayout();
    ((ISupportInitialize) this.btnCopyOnRenewal).BeginInit();
    ((ISupportInitialize) this.btnBulkDelete).BeginInit();
    this.GroupBox2.SuspendLayout();
    ((ISupportInitialize) this.chkPopup).BeginInit();
    ((ISupportInitialize) this.MgaTextBox12).BeginInit();
    ((ISupportInitialize) this.MgaTextBox11).BeginInit();
    ((ISupportInitialize) this.MgaComboBox1).BeginInit();
    ((ISupportInitialize) this.MgaTextBox10).BeginInit();
    ((ISupportInitialize) this.err).BeginInit();
    ((ISupportInitialize) this.panelProcessingADR).BeginInit();
    ((Control) this.panelProcessingADR).SuspendLayout();
    ((ISupportInitialize) this.spinner).BeginInit();
    ((ISupportInitialize) this.tabDriverTab).BeginInit();
    ((Control) this.tabDriverTab).SuspendLayout();
    ((ISupportInitialize) this.UltraTextEditor1).BeginInit();
    ((ISupportInitialize) this.btnIIX).BeginInit();
    ((ISupportInitialize) this.cboTemplates).BeginInit();
    ((ISupportInitialize) this.btnQuery).BeginInit();
    ((ISupportInitialize) this.uddCDL).BeginInit();
    ((ISupportInitialize) this.uddState).BeginInit();
    ((ISupportInitialize) this.uddDriverStatus).BeginInit();
    ((ISupportInitialize) this.ugDrivers).BeginInit();
    this.SuspendLayout();
    label.AutoSize = true;
    label.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    label.Location = new Point(46, 21);
    label.Name = "Label27";
    label.Size = new Size(231, 19);
    label.TabIndex = 1;
    label.Text = "Processing ADR ... Please Wait.";
    ((Control) this.tabDriverInfo).Controls.Add((Control) this.Label36);
    ((Control) this.tabDriverInfo).Controls.Add((Control) this.cboCDLDriver);
    ((Control) this.tabDriverInfo).Controls.Add((Control) this.Label34);
    ((Control) this.tabDriverInfo).Controls.Add((Control) this.dtMVRDate);
    ((Control) this.tabDriverInfo).Controls.Add((Control) this.Label29);
    ((Control) this.tabDriverInfo).Controls.Add((Control) this.dtMedicalExpiration);
    ((Control) this.tabDriverInfo).Controls.Add((Control) this.chkFurnishedCar);
    ((Control) this.tabDriverInfo).Controls.Add((Control) this.MgaTextBox1);
    ((Control) this.tabDriverInfo).Controls.Add((Control) this.Label12);
    ((Control) this.tabDriverInfo).Controls.Add((Control) this.Label11);
    ((Control) this.tabDriverInfo).Controls.Add((Control) this.numDriverRatingFactor);
    ((Control) this.tabDriverInfo).Controls.Add((Control) this.Label10);
    ((Control) this.tabDriverInfo).Controls.Add((Control) this.Label8);
    ((Control) this.tabDriverInfo).Controls.Add((Control) this.Label7);
    ((Control) this.tabDriverInfo).Controls.Add((Control) this.Label6);
    ((Control) this.tabDriverInfo).Controls.Add((Control) this.Label5);
    ((Control) this.tabDriverInfo).Controls.Add((Control) this.Label3);
    ((Control) this.tabDriverInfo).Controls.Add((Control) this.Label9);
    ((Control) this.tabDriverInfo).Controls.Add((Control) this.Label21);
    ((Control) this.tabDriverInfo).Controls.Add((Control) this.Label2);
    ((Control) this.tabDriverInfo).Controls.Add((Control) this.Label22);
    ((Control) this.tabDriverInfo).Controls.Add((Control) this.Label1);
    ((Control) this.tabDriverInfo).Controls.Add((Control) this.Label23);
    ((Control) this.tabDriverInfo).Controls.Add((Control) this.Label20);
    ((Control) this.tabDriverInfo).Controls.Add((Control) this.Label18);
    ((Control) this.tabDriverInfo).Controls.Add((Control) this.Label4);
    ((Control) this.tabDriverInfo).Controls.Add((Control) this.Label19);
    ((Control) this.tabDriverInfo).Controls.Add((Control) this.txtZipPlus);
    ((Control) this.tabDriverInfo).Controls.Add((Control) this.Label17);
    ((Control) this.tabDriverInfo).Controls.Add((Control) this.txtZipCode);
    ((Control) this.tabDriverInfo).Controls.Add((Control) this.txtCity);
    ((Control) this.tabDriverInfo).Controls.Add((Control) this.txtStreet2);
    ((Control) this.tabDriverInfo).Controls.Add((Control) this.txtStreet1);
    ((Control) this.tabDriverInfo).Controls.Add((Control) this.dtLicenseExpDate);
    ((Control) this.tabDriverInfo).Controls.Add((Control) this.MgaCheckBox1);
    ((Control) this.tabDriverInfo).Controls.Add((Control) this.cboFullorPartTime);
    ((Control) this.tabDriverInfo).Controls.Add((Control) this.txtNumPoints);
    ((Control) this.tabDriverInfo).Controls.Add((Control) this.txtComments);
    ((Control) this.tabDriverInfo).Controls.Add((Control) this.dtpDriverAdded);
    ((Control) this.tabDriverInfo).Controls.Add((Control) this.dtpDriverDeleted);
    ((Control) this.tabDriverInfo).Controls.Add((Control) this.comboDriverStatus);
    ((Control) this.tabDriverInfo).Controls.Add((Control) this.comboState);
    ((Control) this.tabDriverInfo).Controls.Add((Control) this.txtLicenseNumber);
    ((Control) this.tabDriverInfo).Controls.Add((Control) this.dtPDateOfBirth);
    ((Control) this.tabDriverInfo).Controls.Add((Control) this.txtLastName);
    ((Control) this.tabDriverInfo).Controls.Add((Control) this.txtFirstName);
    ((Control) this.tabDriverInfo).Location = new Point(1, 30);
    ((Control) this.tabDriverInfo).Name = "tabDriverInfo";
    ((Control) this.tabDriverInfo).Size = new Size(1011, 174);
    this.Label36.AutoSize = true;
    this.Label36.BackColor = Color.Transparent;
    this.Label36.Location = new Point(600, 125);
    this.Label36.Name = "Label36";
    this.Label36.Size = new Size(62, 13);
    this.Label36.TabIndex = 94;
    this.Label36.Text = "CDL Driver:";
    this.cboCDLDriver.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.cboCDLDriver).DataBindings.Add(new Binding("Value", (object) this.ds, "tblDriverInfo.CDLDriverID", true));
    ((UltraGridBase) this.cboCDLDriver).DataMember = "lstDriverCDL";
    ((UltraGridBase) this.cboCDLDriver).DataSource = (object) this.ds;
    appearance1.BackColor = Color.White;
    appearance1.BorderColor = Color.FromArgb(78, 122, 171);
    appearance1.ForeColor = Color.Black;
    this.cboCDLDriver.DisplayLayout.Appearance = (AppearanceBase) appearance1;
    this.cboCDLDriver.DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridBand1.ColHeadersVisible = false;
    ultraGridColumn1.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn1.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn1.Width = 31 /*0x1F*/;
    ((HeaderBase) ultraGridColumn2.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn2.Header.VisiblePosition = 1;
    ultraGridColumn2.Width = 181;
    ultraGridBand1.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2
    });
    this.cboCDLDriver.DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    this.cboCDLDriver.DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    this.cboCDLDriver.DisplayLayout.CaptionVisible = (DefaultableBoolean) 2;
    appearance2.BackColor = Color.White;
    appearance2.BackColor2 = Color.White;
    appearance2.BackGradientStyle = (GradientStyle) 2;
    appearance2.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance2.ForeColor = Color.Black;
    ((SpecialBoxBase) this.cboCDLDriver.DisplayLayout.GroupByBox).Appearance = (AppearanceBase) appearance2;
    appearance3.BackColor = Color.FromArgb(240 /*0xF0*/, 246, 254);
    appearance3.BorderColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    appearance3.ForeColor = SystemColors.GrayText;
    this.cboCDLDriver.DisplayLayout.GroupByBox.BandLabelAppearance = (AppearanceBase) appearance3;
    ((SpecialBoxBase) this.cboCDLDriver.DisplayLayout.GroupByBox).BorderStyle = (UIElementBorderStyle) 4;
    appearance4.BackColor = SystemColors.ControlLightLight;
    appearance4.BackColor2 = SystemColors.Control;
    appearance4.BackGradientStyle = (GradientStyle) 3;
    appearance4.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance4.ForeColor = SystemColors.GrayText;
    this.cboCDLDriver.DisplayLayout.GroupByBox.PromptAppearance = (AppearanceBase) appearance4;
    this.cboCDLDriver.DisplayLayout.MaxColScrollRegions = 1;
    this.cboCDLDriver.DisplayLayout.MaxRowScrollRegions = 1;
    appearance5.AlphaLevel = (short) 14;
    appearance5.BackColor = Color.FromArgb(0, 0, 246, 253);
    appearance5.BackColor2 = Color.FromArgb(133, 162, 221);
    appearance5.BackColorAlpha = (Alpha) 2;
    appearance5.BackGradientAlignment = (GradientAlignment) 4;
    appearance5.BackGradientStyle = (GradientStyle) 5;
    appearance5.BorderAlpha = (Alpha) 1;
    appearance5.BorderColor = Color.FromArgb(78, 122, 171);
    appearance5.ForeColor = Color.FromArgb(49, 85, 153);
    appearance5.ForegroundAlpha = (Alpha) 2;
    this.cboCDLDriver.DisplayLayout.Override.ActiveCellAppearance = (AppearanceBase) appearance5;
    appearance6.BackColor = Color.White;
    appearance6.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance6.ForeColor = Color.Black;
    this.cboCDLDriver.DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance6;
    this.cboCDLDriver.DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 1;
    this.cboCDLDriver.DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 1;
    appearance7.BackColor = Color.FromArgb(240 /*0xF0*/, 246, 254);
    appearance7.BorderColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this.cboCDLDriver.DisplayLayout.Override.CardAreaAppearance = (AppearanceBase) appearance7;
    appearance8.BackColor = Color.White;
    appearance8.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance8.ForeColor = Color.Black;
    appearance8.TextTrimming = (TextTrimming) 3;
    this.cboCDLDriver.DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance8;
    this.cboCDLDriver.DisplayLayout.Override.CellClickAction = (CellClickAction) 4;
    this.cboCDLDriver.DisplayLayout.Override.CellPadding = 0;
    appearance9.BackColor = Color.White;
    appearance9.BackColor2 = Color.White;
    appearance9.BackGradientAlignment = (GradientAlignment) 1;
    appearance9.BackGradientStyle = (GradientStyle) 3;
    appearance9.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance9.ForeColor = Color.Black;
    this.cboCDLDriver.DisplayLayout.Override.GroupByRowAppearance = (AppearanceBase) appearance9;
    appearance10.BackColor = Color.White;
    appearance10.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance10.ForeColor = Color.Black;
    ((AppearanceBase) appearance10).TextHAlignAsString = "Left";
    this.cboCDLDriver.DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance10;
    this.cboCDLDriver.DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 3;
    this.cboCDLDriver.DisplayLayout.Override.HeaderStyle = (HeaderStyle) 2;
    appearance11.BackColor = Color.FromArgb(240 /*0xF0*/, 246, 254);
    appearance11.BorderColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this.cboCDLDriver.DisplayLayout.Override.HotTrackRowAppearance = (AppearanceBase) appearance11;
    appearance12.BackColor = SystemColors.Window;
    appearance12.BorderColor = Color.White;
    this.cboCDLDriver.DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance12;
    this.cboCDLDriver.DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    this.cboCDLDriver.DisplayLayout.Override.RowSpacingAfter = 1;
    appearance13.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance13.BorderColor = Color.FromArgb((int) byte.MaxValue, 214, 88);
    appearance13.ForeColor = Color.Black;
    this.cboCDLDriver.DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance13;
    appearance14.BackColor = SystemColors.ControlLight;
    appearance14.BorderColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this.cboCDLDriver.DisplayLayout.Override.TemplateAddRowAppearance = (AppearanceBase) appearance14;
    scrollBarLook1.ViewStyle = (ScrollBarViewStyle) 3;
    this.cboCDLDriver.DisplayLayout.ScrollBarLook = scrollBarLook1;
    this.cboCDLDriver.DisplayLayout.ScrollBounds = (ScrollBounds) 0;
    this.cboCDLDriver.DisplayLayout.ScrollStyle = (ScrollStyle) 1;
    this.cboCDLDriver.DisplayLayout.ViewStyleBand = (ViewStyleBand) 2;
    ((UltraDropDownBase) this.cboCDLDriver).DisplayMember = "CDL";
    this.cboCDLDriver.DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboCDLDriver).DropDownWidth = 200;
    ((Control) this.cboCDLDriver).Location = new Point(669, 121);
    this.cboCDLDriver.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboCDLDriver).Name = "cboCDLDriver";
    ((Control) this.cboCDLDriver).Size = new Size(78, 21);
    ((Control) this.cboCDLDriver).TabIndex = 93;
    ((UltraControlBase) this.cboCDLDriver).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboCDLDriver).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboCDLDriver).ValueMember = "ID";
    this.ds.DataSetName = "dsDriverInfo";
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.Label34.AutoSize = true;
    this.Label34.BackColor = Color.Transparent;
    this.Label34.Location = new Point(453, 152);
    this.Label34.Name = "Label34";
    this.Label34.Size = new Size(58, 13);
    this.Label34.TabIndex = 92;
    this.Label34.Text = "MVR Date:";
    appearance15.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.dtMVRDate.Appearance = (AppearanceBase) appearance15;
    appearance16.AlphaLevel = (short) 14;
    appearance16.BackColor = Color.FromArgb(0, 0, 246, 253);
    appearance16.BackColor2 = Color.FromArgb(133, 162, 221);
    appearance16.BackColorAlpha = (Alpha) 2;
    appearance16.BackGradientAlignment = (GradientAlignment) 4;
    appearance16.BackGradientStyle = (GradientStyle) 5;
    appearance16.BorderAlpha = (Alpha) 1;
    appearance16.BorderColor = Color.FromArgb(78, 122, 171);
    appearance16.ForeColor = Color.FromArgb(49, 85, 153);
    appearance16.ForegroundAlpha = (Alpha) 2;
    this.dtMVRDate.ButtonAppearance = (AppearanceBase) appearance16;
    ((Control) this.dtMVRDate).DataBindings.Add(new Binding("Value", (object) this.ds, "tblDriverInfo.MVRDate", true));
    this.dtMVRDate.DateTime = new DateTime(1753, 1, 1, 0, 0, 0, 0);
    ((Control) this.dtMVRDate).Location = new Point(561, 148);
    this.dtMVRDate.MGAStyle = MGAStyles.Blue;
    ((Control) this.dtMVRDate).Name = "dtMVRDate";
    ((Control) this.dtMVRDate).Size = new Size(98, 20);
    ((Control) this.dtMVRDate).TabIndex = 15;
    ((UltraControlBase) this.dtMVRDate).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dtMVRDate).UseOsThemes = (DefaultableBoolean) 2;
    this.dtMVRDate.Value = (object) null;
    this.Label29.AutoSize = true;
    this.Label29.BackColor = Color.Transparent;
    this.Label29.Location = new Point(453, 71);
    this.Label29.Name = "Label29";
    this.Label29.Size = new Size(97, 13);
    this.Label29.TabIndex = 90;
    this.Label29.Text = "Medical Expiration:";
    appearance17.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.dtMedicalExpiration.Appearance = (AppearanceBase) appearance17;
    appearance18.AlphaLevel = (short) 14;
    appearance18.BackColor = Color.FromArgb(0, 0, 246, 253);
    appearance18.BackColor2 = Color.FromArgb(133, 162, 221);
    appearance18.BackColorAlpha = (Alpha) 2;
    appearance18.BackGradientAlignment = (GradientAlignment) 4;
    appearance18.BackGradientStyle = (GradientStyle) 5;
    appearance18.BorderAlpha = (Alpha) 1;
    appearance18.BorderColor = Color.FromArgb(78, 122, 171);
    appearance18.ForeColor = Color.FromArgb(49, 85, 153);
    appearance18.ForegroundAlpha = (Alpha) 2;
    this.dtMedicalExpiration.ButtonAppearance = (AppearanceBase) appearance18;
    ((Control) this.dtMedicalExpiration).DataBindings.Add(new Binding("Value", (object) this.ds, "tblDriverInfo.MedicalExpiration", true));
    this.dtMedicalExpiration.DateTime = new DateTime(1753, 1, 1, 0, 0, 0, 0);
    ((Control) this.dtMedicalExpiration).Location = new Point(561, 67);
    this.dtMedicalExpiration.MGAStyle = MGAStyles.Blue;
    ((Control) this.dtMedicalExpiration).Name = "dtMedicalExpiration";
    ((Control) this.dtMedicalExpiration).Size = new Size(98, 20);
    ((Control) this.dtMedicalExpiration).TabIndex = 12;
    ((UltraControlBase) this.dtMedicalExpiration).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dtMedicalExpiration).UseOsThemes = (DefaultableBoolean) 2;
    this.dtMedicalExpiration.Value = (object) null;
    appearance19.BackColor = Color.Transparent;
    appearance19.BorderColor = Color.Gray;
    appearance19.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkFurnishedCar).Appearance = (AppearanceBase) appearance19;
    ((UltraToggleEditorBase) this.chkFurnishedCar).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkFurnishedCar).BackColorInternal = Color.Transparent;
    ((Control) this.chkFurnishedCar).DataBindings.Add(new Binding("CheckedValue", (object) this.ds, "tblDriverInfo.FurnishedCar", true));
    ((UltraToggleEditorBase) this.chkFurnishedCar).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkFurnishedCar).Location = new Point(843, 122);
    ((Control) this.chkFurnishedCar).Name = "chkFurnishedCar";
    ((Control) this.chkFurnishedCar).Size = new Size(98, 19);
    ((Control) this.chkFurnishedCar).TabIndex = 21;
    ((UltraToggleEditorBase) this.chkFurnishedCar).Text = "Furnished Car";
    ((UltraControlBase) this.chkFurnishedCar).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkFurnishedCar).UseOsThemes = (DefaultableBoolean) 2;
    appearance20.BackColor = Color.White;
    appearance20.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance20.ForeColor = Color.Black;
    ((AppearanceBase) appearance20).TextHAlignAsString = "Center";
    ((TextEditorControlBase) this.MgaTextBox1).Appearance = (AppearanceBase) appearance20;
    ((TextEditorControlBase) this.MgaTextBox1).BackColor = Color.White;
    ((Control) this.MgaTextBox1).DataBindings.Add(new Binding("Value", (object) this.ds, "tblDriverInfo.LicenseClass", true));
    ((Control) this.MgaTextBox1).Location = new Point(561, 121);
    ((TextEditorControlBase) this.MgaTextBox1).MaxLength = 1;
    this.MgaTextBox1.MGAStyle = MGAStyles.Blue;
    ((Control) this.MgaTextBox1).Name = "MgaTextBox1";
    ((Control) this.MgaTextBox1).Size = new Size(33, 20);
    ((Control) this.MgaTextBox1).TabIndex = 14;
    ((UltraControlBase) this.MgaTextBox1).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaTextBox1).UseOsThemes = (DefaultableBoolean) 2;
    this.Label12.AutoSize = true;
    this.Label12.BackColor = Color.Transparent;
    this.Label12.Location = new Point(453, 125);
    this.Label12.Name = "Label12";
    this.Label12.Size = new Size(74, 13);
    this.Label12.TabIndex = 88;
    this.Label12.Text = "License Class:";
    this.Label11.AutoSize = true;
    this.Label11.BackColor = Color.Transparent;
    this.Label11.Location = new Point(453, 98);
    this.Label11.Name = "Label11";
    this.Label11.Size = new Size(108, 13);
    this.Label11.TabIndex = 87;
    this.Label11.Text = "Driver Rating Factor:";
    appearance21.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.numDriverRatingFactor).Appearance = (AppearanceBase) appearance21;
    ((Control) this.numDriverRatingFactor).DataBindings.Add(new Binding("Value", (object) this.ds, "tblDriverInfo.DriverRatingFactor", true));
    ((UltraNumericEditorBase) this.numDriverRatingFactor).FormatString = "";
    ((Control) this.numDriverRatingFactor).Location = new Point(561, 94);
    this.numDriverRatingFactor.MaskInput = "n.nnnn";
    this.numDriverRatingFactor.MaxValue = (object) 9.9999;
    this.numDriverRatingFactor.MGAStyle = MGAStyles.Blue;
    this.numDriverRatingFactor.MinValue = (object) -9.9999;
    ((Control) this.numDriverRatingFactor).Name = "numDriverRatingFactor";
    this.numDriverRatingFactor.Nullable = true;
    this.numDriverRatingFactor.NumericType = (NumericType) 2;
    ((Control) this.numDriverRatingFactor).Size = new Size(55, 20);
    ((Control) this.numDriverRatingFactor).TabIndex = 13;
    ((UltraWinEditorMaskedControlBase) this.numDriverRatingFactor).TabNavigation = (MaskedEditTabNavigation) 0;
    ((UltraControlBase) this.numDriverRatingFactor).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.numDriverRatingFactor).UseOsThemes = (DefaultableBoolean) 2;
    this.numDriverRatingFactor.Value = (object) null;
    this.Label10.AutoSize = true;
    this.Label10.BackColor = Color.Transparent;
    this.Label10.Location = new Point(784, 71);
    this.Label10.Name = "Label10";
    this.Label10.Size = new Size(30, 13);
    this.Label10.TabIndex = 86;
    this.Label10.Text = "City:";
    this.Label8.AutoSize = true;
    this.Label8.BackColor = Color.Transparent;
    this.Label8.Location = new Point(784, 16 /*0x10*/);
    this.Label8.Name = "Label8";
    this.Label8.Size = new Size(50, 13);
    this.Label8.TabIndex = 85;
    this.Label8.Text = "Street 1:";
    this.Label7.AutoSize = true;
    this.Label7.BackColor = Color.Transparent;
    this.Label7.Location = new Point(784, 99);
    this.Label7.Name = "Label7";
    this.Label7.Size = new Size(53, 13);
    this.Label7.TabIndex = 84;
    this.Label7.Text = "Zip Code:";
    this.Label6.AutoSize = true;
    this.Label6.BackColor = Color.Transparent;
    this.Label6.Location = new Point(784, 43);
    this.Label6.Name = "Label6";
    this.Label6.Size = new Size(50, 13);
    this.Label6.TabIndex = 83;
    this.Label6.Text = "Street 2:";
    this.Label5.AutoSize = true;
    this.Label5.BackColor = Color.Transparent;
    this.Label5.Location = new Point(453, 44);
    this.Label5.Name = "Label5";
    this.Label5.Size = new Size(97, 13);
    this.Label5.TabIndex = 82;
    this.Label5.Text = "License Expiration:";
    this.Label3.AutoSize = true;
    this.Label3.BackColor = Color.Transparent;
    this.Label3.Location = new Point(453, 17);
    this.Label3.Name = "Label3";
    this.Label3.Size = new Size(88, 13);
    this.Label3.TabIndex = 81;
    this.Label3.Text = "Full or Part Time:";
    this.Label9.AutoSize = true;
    this.Label9.BackColor = Color.Transparent;
    this.Label9.Location = new Point(243, 152);
    this.Label9.Name = "Label9";
    this.Label9.Size = new Size(74, 13);
    this.Label9.TabIndex = 76;
    this.Label9.Text = "Driver Added:";
    this.Label21.AutoSize = true;
    this.Label21.BackColor = Color.Transparent;
    this.Label21.Location = new Point(245, 71);
    this.Label21.Name = "Label21";
    this.Label21.Size = new Size(37, 13);
    this.Label21.TabIndex = 78;
    this.Label21.Text = "State:";
    this.Label2.AutoSize = true;
    this.Label2.BackColor = Color.Transparent;
    this.Label2.Location = new Point(245, 125);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(80 /*0x50*/, 13);
    this.Label2.TabIndex = 75;
    this.Label2.Text = "Driver Deleted:";
    this.Label22.AutoSize = true;
    this.Label22.BackColor = Color.Transparent;
    this.Label22.Location = new Point(245, 44);
    this.Label22.Name = "Label22";
    this.Label22.Size = new Size(74, 13);
    this.Label22.TabIndex = 79;
    this.Label22.Text = "Driver Status:";
    this.Label1.AutoSize = true;
    this.Label1.BackColor = Color.Transparent;
    this.Label1.Location = new Point(245, 98);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(64 /*0x40*/, 13);
    this.Label1.TabIndex = 74;
    this.Label1.Text = "# of Points:";
    this.Label23.AutoSize = true;
    this.Label23.BackColor = Color.Transparent;
    this.Label23.Location = new Point(245, 17);
    this.Label23.Name = "Label23";
    this.Label23.Size = new Size(72, 13);
    this.Label23.TabIndex = 80 /*0x50*/;
    this.Label23.Text = "Date of Birth:";
    this.Label20.AutoSize = true;
    this.Label20.BackColor = Color.Transparent;
    this.Label20.Location = new Point(13, 99);
    this.Label20.Name = "Label20";
    this.Label20.Size = new Size(61, 13);
    this.Label20.TabIndex = 73;
    this.Label20.Text = "Comments:";
    this.Label18.AutoSize = true;
    this.Label18.BackColor = Color.Transparent;
    this.Label18.Location = new Point(13, 16 /*0x10*/);
    this.Label18.Name = "Label18";
    this.Label18.Size = new Size(57, 13);
    this.Label18.TabIndex = 70;
    this.Label18.Text = "License #:";
    this.Label4.AutoSize = true;
    this.Label4.BackColor = Color.Transparent;
    this.Label4.Location = new Point(13, 72);
    this.Label4.Name = "Label4";
    this.Label4.Size = new Size(61, 13);
    this.Label4.TabIndex = 71;
    this.Label4.Text = "Last Name:";
    this.Label19.AutoSize = true;
    this.Label19.BackColor = Color.Transparent;
    this.Label19.Location = new Point(13, 44);
    this.Label19.Name = "Label19";
    this.Label19.Size = new Size(62, 13);
    this.Label19.TabIndex = 72;
    this.Label19.Text = "First Name:";
    appearance22.BackColor = Color.White;
    appearance22.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance22.ForeColor = Color.Black;
    appearance22.TextTrimming = (TextTrimming) 3;
    ((TextEditorControlBase) this.txtZipPlus).Appearance = (AppearanceBase) appearance22;
    ((TextEditorControlBase) this.txtZipPlus).BackColor = Color.White;
    ((Control) this.txtZipPlus).DataBindings.Add(new Binding("Value", (object) this.ds, "tblDriverInfo.ZipPlus", true));
    ((Control) this.txtZipPlus).Location = new Point(928, 95);
    ((TextEditorControlBase) this.txtZipPlus).MaxLength = 4;
    this.txtZipPlus.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtZipPlus).Name = "txtZipPlus";
    ((Control) this.txtZipPlus).Size = new Size(43, 20);
    ((Control) this.txtZipPlus).TabIndex = 20;
    ((UltraControlBase) this.txtZipPlus).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtZipPlus).UseOsThemes = (DefaultableBoolean) 2;
    this.Label17.BackColor = Color.Transparent;
    this.Label17.Location = new Point(912, 94);
    this.Label17.Name = "Label17";
    this.Label17.Size = new Size(10, 23);
    this.Label17.TabIndex = 77;
    this.Label17.Text = "-";
    this.Label17.TextAlign = ContentAlignment.MiddleRight;
    appearance23.BackColor = Color.White;
    appearance23.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance23.ForeColor = Color.Black;
    ((AppearanceBase) appearance23).TextHAlignAsString = "Left";
    ((TextEditorControlBase) this.txtZipCode).Appearance = (AppearanceBase) appearance23;
    ((TextEditorControlBase) this.txtZipCode).BackColor = Color.White;
    ((Control) this.txtZipCode).DataBindings.Add(new Binding("Value", (object) this.ds, "tblDriverInfo.ZipCode", true));
    ((Control) this.txtZipCode).Location = new Point(843, 95);
    ((TextEditorControlBase) this.txtZipCode).MaxLength = 5;
    this.txtZipCode.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtZipCode).Name = "txtZipCode";
    ((Control) this.txtZipCode).Size = new Size(63 /*0x3F*/, 20);
    ((Control) this.txtZipCode).TabIndex = 19;
    ((UltraControlBase) this.txtZipCode).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtZipCode).UseOsThemes = (DefaultableBoolean) 2;
    appearance24.BackColor = Color.White;
    appearance24.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance24.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtCity).Appearance = (AppearanceBase) appearance24;
    ((TextEditorControlBase) this.txtCity).BackColor = Color.White;
    ((Control) this.txtCity).DataBindings.Add(new Binding("Value", (object) this.ds, "tblDriverInfo.City", true));
    ((Control) this.txtCity).Location = new Point(843, 67);
    ((TextEditorControlBase) this.txtCity).MaxLength = 100;
    this.txtCity.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtCity).Name = "txtCity";
    ((Control) this.txtCity).Size = new Size(128 /*0x80*/, 20);
    ((Control) this.txtCity).TabIndex = 18;
    ((UltraControlBase) this.txtCity).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtCity).UseOsThemes = (DefaultableBoolean) 2;
    appearance25.BackColor = Color.White;
    appearance25.BackColor2 = Color.White;
    appearance25.BackGradientAlignment = (GradientAlignment) 1;
    appearance25.BackGradientStyle = (GradientStyle) 3;
    appearance25.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance25.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtStreet2).Appearance = (AppearanceBase) appearance25;
    ((TextEditorControlBase) this.txtStreet2).BackColor = Color.White;
    ((Control) this.txtStreet2).DataBindings.Add(new Binding("Value", (object) this.ds, "tblDriverInfo.Street2", true));
    ((Control) this.txtStreet2).Location = new Point(843, 39);
    ((TextEditorControlBase) this.txtStreet2).MaxLength = 250;
    this.txtStreet2.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtStreet2).Name = "txtStreet2";
    ((Control) this.txtStreet2).Size = new Size(128 /*0x80*/, 20);
    ((Control) this.txtStreet2).TabIndex = 17;
    ((UltraControlBase) this.txtStreet2).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtStreet2).UseOsThemes = (DefaultableBoolean) 2;
    appearance26.BackColor = Color.White;
    appearance26.BackColor2 = Color.White;
    appearance26.BackGradientStyle = (GradientStyle) 2;
    appearance26.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance26.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtStreet1).Appearance = (AppearanceBase) appearance26;
    ((TextEditorControlBase) this.txtStreet1).BackColor = Color.White;
    ((Control) this.txtStreet1).DataBindings.Add(new Binding("Value", (object) this.ds, "tblDriverInfo.Street1", true));
    ((Control) this.txtStreet1).Location = new Point(843, 12);
    ((TextEditorControlBase) this.txtStreet1).MaxLength = 250;
    this.txtStreet1.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtStreet1).Name = "txtStreet1";
    ((Control) this.txtStreet1).Size = new Size(128 /*0x80*/, 20);
    ((Control) this.txtStreet1).TabIndex = 16 /*0x10*/;
    ((UltraControlBase) this.txtStreet1).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtStreet1).UseOsThemes = (DefaultableBoolean) 2;
    appearance27.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.dtLicenseExpDate.Appearance = (AppearanceBase) appearance27;
    appearance28.AlphaLevel = (short) 14;
    appearance28.BackColor = Color.FromArgb(0, 0, 246, 253);
    appearance28.BackColor2 = Color.FromArgb(133, 162, 221);
    appearance28.BackColorAlpha = (Alpha) 2;
    appearance28.BackGradientAlignment = (GradientAlignment) 4;
    appearance28.BackGradientStyle = (GradientStyle) 5;
    appearance28.BorderAlpha = (Alpha) 1;
    appearance28.BorderColor = Color.FromArgb(78, 122, 171);
    appearance28.ForeColor = Color.FromArgb(49, 85, 153);
    appearance28.ForegroundAlpha = (Alpha) 2;
    this.dtLicenseExpDate.ButtonAppearance = (AppearanceBase) appearance28;
    ((Control) this.dtLicenseExpDate).DataBindings.Add(new Binding("Value", (object) this.ds, "tblDriverInfo.LicenseExpDate", true));
    this.dtLicenseExpDate.DateTime = new DateTime(1753, 1, 1, 0, 0, 0, 0);
    ((Control) this.dtLicenseExpDate).Location = new Point(561, 40);
    this.dtLicenseExpDate.MGAStyle = MGAStyles.Blue;
    ((Control) this.dtLicenseExpDate).Name = "dtLicenseExpDate";
    ((Control) this.dtLicenseExpDate).Size = new Size(98, 20);
    ((Control) this.dtLicenseExpDate).TabIndex = 11;
    ((UltraControlBase) this.dtLicenseExpDate).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dtLicenseExpDate).UseOsThemes = (DefaultableBoolean) 2;
    this.dtLicenseExpDate.Value = (object) null;
    appearance29.BackColor = Color.Transparent;
    appearance29.BorderColor = Color.Gray;
    appearance29.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.MgaCheckBox1).Appearance = (AppearanceBase) appearance29;
    ((UltraToggleEditorBase) this.MgaCheckBox1).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.MgaCheckBox1).BackColorInternal = Color.Transparent;
    ((Control) this.MgaCheckBox1).DataBindings.Add(new Binding("CheckedValue", (object) this.ds, "tblDriverInfo.CopyOnRenewal", true));
    ((UltraToggleEditorBase) this.MgaCheckBox1).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.MgaCheckBox1).Location = new Point(843, 148);
    ((Control) this.MgaCheckBox1).Name = "MgaCheckBox1";
    ((Control) this.MgaCheckBox1).Size = new Size(122, 19);
    ((Control) this.MgaCheckBox1).TabIndex = 22;
    ((UltraToggleEditorBase) this.MgaCheckBox1).Text = "Copy on Renewal";
    ((UltraControlBase) this.MgaCheckBox1).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaCheckBox1).UseOsThemes = (DefaultableBoolean) 2;
    this.cboFullorPartTime.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.cboFullorPartTime).DataBindings.Add(new Binding("Value", (object) this.ds, "tblDriverInfo.FullPartTime", true));
    ((UltraGridBase) this.cboFullorPartTime).DataMember = "lstDriverStatusInfo";
    ((UltraGridBase) this.cboFullorPartTime).DataSource = (object) this.ds;
    appearance30.BackColor = Color.White;
    appearance30.BorderColor = Color.FromArgb(78, 122, 171);
    appearance30.ForeColor = Color.Black;
    this.cboFullorPartTime.DisplayLayout.Appearance = (AppearanceBase) appearance30;
    this.cboFullorPartTime.DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridBand2.ColHeadersVisible = false;
    ultraGridColumn3.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn3.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn3.Header.VisiblePosition = 0;
    ultraGridColumn3.Hidden = true;
    ultraGridColumn3.Width = 31 /*0x1F*/;
    ultraGridColumn4.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn4.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn4.Header.VisiblePosition = 1;
    ultraGridColumn4.Width = 181;
    ultraGridBand2.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn3,
      (object) ultraGridColumn4
    });
    this.cboFullorPartTime.DisplayLayout.BandsSerializer.Add((object) ultraGridBand2);
    this.cboFullorPartTime.DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    this.cboFullorPartTime.DisplayLayout.CaptionVisible = (DefaultableBoolean) 2;
    ((SpecialBoxBase) this.cboFullorPartTime.DisplayLayout.GroupByBox).Appearance = (AppearanceBase) appearance26;
    appearance31.BackColor = Color.FromArgb(240 /*0xF0*/, 246, 254);
    appearance31.BorderColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    appearance31.ForeColor = SystemColors.GrayText;
    this.cboFullorPartTime.DisplayLayout.GroupByBox.BandLabelAppearance = (AppearanceBase) appearance31;
    ((SpecialBoxBase) this.cboFullorPartTime.DisplayLayout.GroupByBox).BorderStyle = (UIElementBorderStyle) 4;
    appearance32.BackColor = SystemColors.ControlLightLight;
    appearance32.BackColor2 = SystemColors.Control;
    appearance32.BackGradientStyle = (GradientStyle) 3;
    appearance32.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance32.ForeColor = SystemColors.GrayText;
    this.cboFullorPartTime.DisplayLayout.GroupByBox.PromptAppearance = (AppearanceBase) appearance32;
    this.cboFullorPartTime.DisplayLayout.MaxColScrollRegions = 1;
    this.cboFullorPartTime.DisplayLayout.MaxRowScrollRegions = 1;
    appearance33.AlphaLevel = (short) 14;
    appearance33.BackColor = Color.FromArgb(0, 0, 246, 253);
    appearance33.BackColor2 = Color.FromArgb(133, 162, 221);
    appearance33.BackColorAlpha = (Alpha) 2;
    appearance33.BackGradientAlignment = (GradientAlignment) 4;
    appearance33.BackGradientStyle = (GradientStyle) 5;
    appearance33.BorderAlpha = (Alpha) 1;
    appearance33.BorderColor = Color.FromArgb(78, 122, 171);
    appearance33.ForeColor = Color.FromArgb(49, 85, 153);
    appearance33.ForegroundAlpha = (Alpha) 2;
    this.cboFullorPartTime.DisplayLayout.Override.ActiveCellAppearance = (AppearanceBase) appearance33;
    appearance34.BackColor = Color.White;
    appearance34.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance34.ForeColor = Color.Black;
    this.cboFullorPartTime.DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance34;
    this.cboFullorPartTime.DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 1;
    this.cboFullorPartTime.DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 1;
    appearance35.BackColor = Color.FromArgb(240 /*0xF0*/, 246, 254);
    appearance35.BorderColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this.cboFullorPartTime.DisplayLayout.Override.CardAreaAppearance = (AppearanceBase) appearance35;
    this.cboFullorPartTime.DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance22;
    this.cboFullorPartTime.DisplayLayout.Override.CellClickAction = (CellClickAction) 4;
    this.cboFullorPartTime.DisplayLayout.Override.CellPadding = 0;
    this.cboFullorPartTime.DisplayLayout.Override.GroupByRowAppearance = (AppearanceBase) appearance25;
    this.cboFullorPartTime.DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance23;
    this.cboFullorPartTime.DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 3;
    this.cboFullorPartTime.DisplayLayout.Override.HeaderStyle = (HeaderStyle) 2;
    appearance36.BackColor = Color.FromArgb(240 /*0xF0*/, 246, 254);
    appearance36.BorderColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this.cboFullorPartTime.DisplayLayout.Override.HotTrackRowAppearance = (AppearanceBase) appearance36;
    appearance37.BackColor = SystemColors.Window;
    appearance37.BorderColor = Color.White;
    this.cboFullorPartTime.DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance37;
    this.cboFullorPartTime.DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    this.cboFullorPartTime.DisplayLayout.Override.RowSpacingAfter = 1;
    appearance38.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance38.BorderColor = Color.FromArgb((int) byte.MaxValue, 214, 88);
    appearance38.ForeColor = Color.Black;
    this.cboFullorPartTime.DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance38;
    appearance39.BackColor = SystemColors.ControlLight;
    appearance39.BorderColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this.cboFullorPartTime.DisplayLayout.Override.TemplateAddRowAppearance = (AppearanceBase) appearance39;
    scrollBarLook2.ViewStyle = (ScrollBarViewStyle) 3;
    this.cboFullorPartTime.DisplayLayout.ScrollBarLook = scrollBarLook2;
    this.cboFullorPartTime.DisplayLayout.ScrollBounds = (ScrollBounds) 0;
    this.cboFullorPartTime.DisplayLayout.ScrollStyle = (ScrollStyle) 1;
    this.cboFullorPartTime.DisplayLayout.ViewStyleBand = (ViewStyleBand) 2;
    ((UltraDropDownBase) this.cboFullorPartTime).DisplayMember = "Status";
    this.cboFullorPartTime.DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboFullorPartTime).DropDownWidth = 200;
    ((Control) this.cboFullorPartTime).Location = new Point(561, 13);
    this.cboFullorPartTime.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboFullorPartTime).Name = "cboFullorPartTime";
    ((Control) this.cboFullorPartTime).Size = new Size(186, 21);
    ((Control) this.cboFullorPartTime).TabIndex = 10;
    ((UltraControlBase) this.cboFullorPartTime).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboFullorPartTime).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboFullorPartTime).ValueMember = "ID";
    appearance40.BackColor = Color.White;
    appearance40.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance40.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtNumPoints).Appearance = (AppearanceBase) appearance40;
    ((TextEditorControlBase) this.txtNumPoints).BackColor = Color.White;
    ((Control) this.txtNumPoints).DataBindings.Add(new Binding("Value", (object) this.ds, "tblDriverInfo.NumberOfPoints", true));
    ((Control) this.txtNumPoints).Location = new Point(341, 94);
    ((TextEditorControlBase) this.txtNumPoints).MaxLength = 100;
    this.txtNumPoints.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtNumPoints).Name = "txtNumPoints";
    ((Control) this.txtNumPoints).Size = new Size(96 /*0x60*/, 20);
    ((Control) this.txtNumPoints).TabIndex = 7;
    ((UltraControlBase) this.txtNumPoints).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtNumPoints).UseOsThemes = (DefaultableBoolean) 2;
    appearance41.BackColor = Color.White;
    appearance41.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance41.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtComments).Appearance = (AppearanceBase) appearance41;
    ((TextEditorControlBase) this.txtComments).BackColor = Color.White;
    ((Control) this.txtComments).DataBindings.Add(new Binding("Value", (object) this.ds, "tblDriverInfo.Comments", true));
    ((Control) this.txtComments).Location = new Point(92, 94);
    ((TextEditorControlBase) this.txtComments).MaxLength = 1000;
    this.txtComments.MGAStyle = MGAStyles.Blue;
    this.txtComments.Multiline = true;
    ((Control) this.txtComments).Name = "txtComments";
    ((Control) this.txtComments).Size = new Size(128 /*0x80*/, 71);
    ((Control) this.txtComments).TabIndex = 3;
    ((UltraControlBase) this.txtComments).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtComments).UseOsThemes = (DefaultableBoolean) 2;
    appearance42.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.dtpDriverAdded.Appearance = (AppearanceBase) appearance42;
    appearance43.AlphaLevel = (short) 14;
    appearance43.BackColor = Color.FromArgb(0, 0, 246, 253);
    appearance43.BackColor2 = Color.FromArgb(133, 162, 221);
    appearance43.BackColorAlpha = (Alpha) 2;
    appearance43.BackGradientAlignment = (GradientAlignment) 4;
    appearance43.BackGradientStyle = (GradientStyle) 5;
    appearance43.BorderAlpha = (Alpha) 1;
    appearance43.BorderColor = Color.FromArgb(78, 122, 171);
    appearance43.ForeColor = Color.FromArgb(49, 85, 153);
    appearance43.ForegroundAlpha = (Alpha) 2;
    this.dtpDriverAdded.ButtonAppearance = (AppearanceBase) appearance43;
    ((Control) this.dtpDriverAdded).DataBindings.Add(new Binding("Value", (object) this.ds, "tblDriverInfo.DriverAdded", true));
    this.dtpDriverAdded.DateTime = new DateTime(1753, 1, 1, 0, 0, 0, 0);
    ((Control) this.dtpDriverAdded).Location = new Point(339, 148);
    this.dtpDriverAdded.MGAStyle = MGAStyles.Blue;
    ((Control) this.dtpDriverAdded).Name = "dtpDriverAdded";
    ((Control) this.dtpDriverAdded).Size = new Size(98, 20);
    ((Control) this.dtpDriverAdded).TabIndex = 9;
    ((Control) this.dtpDriverAdded).Tag = (object) "NotRequired";
    ((UltraControlBase) this.dtpDriverAdded).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dtpDriverAdded).UseOsThemes = (DefaultableBoolean) 2;
    this.dtpDriverAdded.Value = (object) null;
    appearance44.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.dtpDriverDeleted.Appearance = (AppearanceBase) appearance44;
    appearance45.AlphaLevel = (short) 14;
    appearance45.BackColor = Color.FromArgb(0, 0, 246, 253);
    appearance45.BackColor2 = Color.FromArgb(133, 162, 221);
    appearance45.BackColorAlpha = (Alpha) 2;
    appearance45.BackGradientAlignment = (GradientAlignment) 4;
    appearance45.BackGradientStyle = (GradientStyle) 5;
    appearance45.BorderAlpha = (Alpha) 1;
    appearance45.BorderColor = Color.FromArgb(78, 122, 171);
    appearance45.ForeColor = Color.FromArgb(49, 85, 153);
    appearance45.ForegroundAlpha = (Alpha) 2;
    this.dtpDriverDeleted.ButtonAppearance = (AppearanceBase) appearance45;
    ((Control) this.dtpDriverDeleted).DataBindings.Add(new Binding("Value", (object) this.ds, "tblDriverInfo.DriverDeleted", true));
    this.dtpDriverDeleted.DateTime = new DateTime(1753, 1, 1, 0, 0, 0, 0);
    ((Control) this.dtpDriverDeleted).Location = new Point(341, 121);
    this.dtpDriverDeleted.MGAStyle = MGAStyles.Blue;
    ((Control) this.dtpDriverDeleted).Name = "dtpDriverDeleted";
    ((Control) this.dtpDriverDeleted).Size = new Size(96 /*0x60*/, 20);
    ((Control) this.dtpDriverDeleted).TabIndex = 8;
    ((Control) this.dtpDriverDeleted).Tag = (object) "NotRequired";
    ((UltraControlBase) this.dtpDriverDeleted).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dtpDriverDeleted).UseOsThemes = (DefaultableBoolean) 2;
    this.dtpDriverDeleted.Value = (object) null;
    this.comboDriverStatus.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.comboDriverStatus).DataBindings.Add(new Binding("Value", (object) this.ds, "tblDriverInfo.StatusID", true));
    ((UltraGridBase) this.comboDriverStatus).DataMember = "lstDriverStatus";
    ((UltraGridBase) this.comboDriverStatus).DataSource = (object) this.ds;
    appearance46.BackColor = Color.White;
    appearance46.BorderColor = Color.FromArgb(78, 122, 171);
    this.comboDriverStatus.DisplayLayout.Appearance = (AppearanceBase) appearance46;
    this.comboDriverStatus.DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridBand3.ColHeadersVisible = false;
    ultraGridColumn5.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn5.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn5.Header.VisiblePosition = 0;
    ultraGridColumn5.Hidden = true;
    ultraGridColumn6.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn6.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn6.Header.VisiblePosition = 1;
    ultraGridColumn6.Width = 181;
    ((HeaderBase) ultraGridColumn7.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn7.Header.VisiblePosition = 2;
    ultraGridColumn7.Hidden = true;
    ultraGridColumn7.Width = 46;
    ultraGridBand3.Columns.AddRange(new object[3]
    {
      (object) ultraGridColumn5,
      (object) ultraGridColumn6,
      (object) ultraGridColumn7
    });
    this.comboDriverStatus.DisplayLayout.BandsSerializer.Add((object) ultraGridBand3);
    this.comboDriverStatus.DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    this.comboDriverStatus.DisplayLayout.CaptionVisible = (DefaultableBoolean) 2;
    appearance47.BackColor = SystemColors.ActiveBorder;
    appearance47.BackColor2 = SystemColors.ControlDark;
    appearance47.BackGradientStyle = (GradientStyle) 2;
    appearance47.BorderColor = SystemColors.Window;
    ((SpecialBoxBase) this.comboDriverStatus.DisplayLayout.GroupByBox).Appearance = (AppearanceBase) appearance47;
    appearance48.ForeColor = SystemColors.GrayText;
    this.comboDriverStatus.DisplayLayout.GroupByBox.BandLabelAppearance = (AppearanceBase) appearance48;
    ((SpecialBoxBase) this.comboDriverStatus.DisplayLayout.GroupByBox).BorderStyle = (UIElementBorderStyle) 4;
    appearance49.BackColor = SystemColors.ControlLightLight;
    appearance49.BackColor2 = SystemColors.Control;
    appearance49.BackGradientStyle = (GradientStyle) 3;
    appearance49.ForeColor = SystemColors.GrayText;
    this.comboDriverStatus.DisplayLayout.GroupByBox.PromptAppearance = (AppearanceBase) appearance49;
    this.comboDriverStatus.DisplayLayout.MaxColScrollRegions = 1;
    this.comboDriverStatus.DisplayLayout.MaxRowScrollRegions = 1;
    appearance50.BackColor = SystemColors.Window;
    appearance50.ForeColor = SystemColors.ControlText;
    this.comboDriverStatus.DisplayLayout.Override.ActiveCellAppearance = (AppearanceBase) appearance50;
    appearance51.BackColor = SystemColors.Highlight;
    appearance51.ForeColor = SystemColors.HighlightText;
    this.comboDriverStatus.DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance51;
    this.comboDriverStatus.DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 1;
    this.comboDriverStatus.DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 1;
    appearance52.BackColor = SystemColors.Window;
    this.comboDriverStatus.DisplayLayout.Override.CardAreaAppearance = (AppearanceBase) appearance52;
    appearance53.BorderColor = Color.Silver;
    appearance53.TextTrimming = (TextTrimming) 3;
    this.comboDriverStatus.DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance53;
    this.comboDriverStatus.DisplayLayout.Override.CellClickAction = (CellClickAction) 4;
    this.comboDriverStatus.DisplayLayout.Override.CellPadding = 0;
    appearance54.BackColor = SystemColors.Control;
    appearance54.BackColor2 = SystemColors.ControlDark;
    appearance54.BackGradientAlignment = (GradientAlignment) 1;
    appearance54.BackGradientStyle = (GradientStyle) 3;
    appearance54.BorderColor = SystemColors.Window;
    this.comboDriverStatus.DisplayLayout.Override.GroupByRowAppearance = (AppearanceBase) appearance54;
    ((AppearanceBase) appearance55).TextHAlignAsString = "Left";
    this.comboDriverStatus.DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance55;
    this.comboDriverStatus.DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 3;
    this.comboDriverStatus.DisplayLayout.Override.HeaderStyle = (HeaderStyle) 2;
    appearance56.BackColor = Color.FromArgb(240 /*0xF0*/, 246, 254);
    appearance56.BorderColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this.comboDriverStatus.DisplayLayout.Override.HotTrackRowAppearance = (AppearanceBase) appearance56;
    appearance57.BackColor = SystemColors.Window;
    appearance57.BorderColor = Color.White;
    this.comboDriverStatus.DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance57;
    this.comboDriverStatus.DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    this.comboDriverStatus.DisplayLayout.Override.RowSpacingAfter = 1;
    appearance58.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance58.BorderColor = Color.FromArgb((int) byte.MaxValue, 214, 88);
    appearance58.ForeColor = Color.Black;
    this.comboDriverStatus.DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance58;
    appearance59.BackColor = SystemColors.ControlLight;
    this.comboDriverStatus.DisplayLayout.Override.TemplateAddRowAppearance = (AppearanceBase) appearance59;
    scrollBarLook3.ViewStyle = (ScrollBarViewStyle) 3;
    this.comboDriverStatus.DisplayLayout.ScrollBarLook = scrollBarLook3;
    this.comboDriverStatus.DisplayLayout.ScrollBounds = (ScrollBounds) 0;
    this.comboDriverStatus.DisplayLayout.ScrollStyle = (ScrollStyle) 1;
    this.comboDriverStatus.DisplayLayout.ViewStyleBand = (ViewStyleBand) 2;
    ((UltraDropDownBase) this.comboDriverStatus).DisplayMember = "Status";
    this.comboDriverStatus.DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.comboDriverStatus).DropDownWidth = 200;
    ((Control) this.comboDriverStatus).Location = new Point(341, 40);
    this.comboDriverStatus.MGAStyle = MGAStyles.Blue;
    ((Control) this.comboDriverStatus).Name = "comboDriverStatus";
    ((Control) this.comboDriverStatus).Size = new Size(96 /*0x60*/, 21);
    ((Control) this.comboDriverStatus).TabIndex = 5;
    ((UltraControlBase) this.comboDriverStatus).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboDriverStatus).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.comboDriverStatus).ValueMember = "DriverStatusID";
    this.comboState.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.comboState).DataBindings.Add(new Binding("Value", (object) this.ds, "tblDriverInfo.StateID", true));
    ((UltraGridBase) this.comboState).DataMember = "lstStates";
    ((UltraGridBase) this.comboState).DataSource = (object) this.ds;
    appearance60.BackColor = Color.White;
    appearance60.BorderColor = Color.FromArgb(78, 122, 171);
    this.comboState.DisplayLayout.Appearance = (AppearanceBase) appearance60;
    this.comboState.DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridBand4.ColHeadersVisible = false;
    ultraGridColumn8.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn8.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn8.Header.VisiblePosition = 0;
    ultraGridColumn8.Hidden = true;
    ultraGridColumn9.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn9.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn9.Header.VisiblePosition = 1;
    ultraGridColumn9.Width = 181;
    ultraGridBand4.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn8,
      (object) ultraGridColumn9
    });
    this.comboState.DisplayLayout.BandsSerializer.Add((object) ultraGridBand4);
    this.comboState.DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    this.comboState.DisplayLayout.CaptionVisible = (DefaultableBoolean) 2;
    appearance61.BackColor = SystemColors.ActiveBorder;
    appearance61.BackColor2 = SystemColors.ControlDark;
    appearance61.BackGradientStyle = (GradientStyle) 2;
    appearance61.BorderColor = SystemColors.Window;
    ((SpecialBoxBase) this.comboState.DisplayLayout.GroupByBox).Appearance = (AppearanceBase) appearance61;
    appearance62.ForeColor = SystemColors.GrayText;
    this.comboState.DisplayLayout.GroupByBox.BandLabelAppearance = (AppearanceBase) appearance62;
    ((SpecialBoxBase) this.comboState.DisplayLayout.GroupByBox).BorderStyle = (UIElementBorderStyle) 4;
    appearance63.BackColor = SystemColors.ControlLightLight;
    appearance63.BackColor2 = SystemColors.Control;
    appearance63.BackGradientStyle = (GradientStyle) 3;
    appearance63.ForeColor = SystemColors.GrayText;
    this.comboState.DisplayLayout.GroupByBox.PromptAppearance = (AppearanceBase) appearance63;
    this.comboState.DisplayLayout.MaxColScrollRegions = 1;
    this.comboState.DisplayLayout.MaxRowScrollRegions = 1;
    appearance64.BackColor = SystemColors.Window;
    appearance64.ForeColor = SystemColors.ControlText;
    this.comboState.DisplayLayout.Override.ActiveCellAppearance = (AppearanceBase) appearance64;
    appearance65.BackColor = SystemColors.Highlight;
    appearance65.ForeColor = SystemColors.HighlightText;
    this.comboState.DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance65;
    this.comboState.DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 1;
    this.comboState.DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 1;
    appearance66.BackColor = SystemColors.Window;
    this.comboState.DisplayLayout.Override.CardAreaAppearance = (AppearanceBase) appearance66;
    appearance67.BorderColor = Color.Silver;
    appearance67.TextTrimming = (TextTrimming) 3;
    this.comboState.DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance67;
    this.comboState.DisplayLayout.Override.CellClickAction = (CellClickAction) 4;
    this.comboState.DisplayLayout.Override.CellPadding = 0;
    appearance68.BackColor = SystemColors.Control;
    appearance68.BackColor2 = SystemColors.ControlDark;
    appearance68.BackGradientAlignment = (GradientAlignment) 1;
    appearance68.BackGradientStyle = (GradientStyle) 3;
    appearance68.BorderColor = SystemColors.Window;
    this.comboState.DisplayLayout.Override.GroupByRowAppearance = (AppearanceBase) appearance68;
    ((AppearanceBase) appearance69).TextHAlignAsString = "Left";
    this.comboState.DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance69;
    this.comboState.DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 3;
    this.comboState.DisplayLayout.Override.HeaderStyle = (HeaderStyle) 2;
    appearance70.BackColor = Color.FromArgb(240 /*0xF0*/, 246, 254);
    appearance70.BorderColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this.comboState.DisplayLayout.Override.HotTrackRowAppearance = (AppearanceBase) appearance70;
    appearance71.BackColor = SystemColors.Window;
    appearance71.BorderColor = Color.White;
    this.comboState.DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance71;
    this.comboState.DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    this.comboState.DisplayLayout.Override.RowSpacingAfter = 1;
    appearance72.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance72.BorderColor = Color.FromArgb((int) byte.MaxValue, 214, 88);
    appearance72.ForeColor = Color.Black;
    this.comboState.DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance72;
    appearance73.BackColor = SystemColors.ControlLight;
    this.comboState.DisplayLayout.Override.TemplateAddRowAppearance = (AppearanceBase) appearance73;
    scrollBarLook4.ViewStyle = (ScrollBarViewStyle) 3;
    this.comboState.DisplayLayout.ScrollBarLook = scrollBarLook4;
    this.comboState.DisplayLayout.ScrollBounds = (ScrollBounds) 0;
    this.comboState.DisplayLayout.ScrollStyle = (ScrollStyle) 1;
    this.comboState.DisplayLayout.ViewStyleBand = (ViewStyleBand) 2;
    ((UltraDropDownBase) this.comboState).DisplayMember = "State";
    this.comboState.DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.comboState).DropDownWidth = 200;
    ((Control) this.comboState).Location = new Point(341, 67);
    this.comboState.MGAStyle = MGAStyles.Blue;
    ((Control) this.comboState).Name = "comboState";
    ((Control) this.comboState).Size = new Size(96 /*0x60*/, 21);
    ((Control) this.comboState).TabIndex = 6;
    ((UltraControlBase) this.comboState).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboState).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.comboState).ValueMember = "StateID";
    appearance74.BackColor = Color.White;
    appearance74.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance74.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtLicenseNumber).Appearance = (AppearanceBase) appearance74;
    ((TextEditorControlBase) this.txtLicenseNumber).BackColor = Color.White;
    ((Control) this.txtLicenseNumber).DataBindings.Add(new Binding("Value", (object) this.ds, "tblDriverInfo.LicenseNumber", true));
    ((Control) this.txtLicenseNumber).Location = new Point(92, 13);
    ((TextEditorControlBase) this.txtLicenseNumber).MaxLength = 50;
    this.txtLicenseNumber.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtLicenseNumber).Name = "txtLicenseNumber";
    ((Control) this.txtLicenseNumber).Size = new Size(128 /*0x80*/, 20);
    ((Control) this.txtLicenseNumber).TabIndex = 0;
    ((UltraControlBase) this.txtLicenseNumber).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtLicenseNumber).UseOsThemes = (DefaultableBoolean) 2;
    this.dtPDateOfBirth.Appearance = (AppearanceBase) appearance32;
    this.dtPDateOfBirth.BackColor = SystemColors.ControlLightLight;
    this.dtPDateOfBirth.ButtonAppearance = (AppearanceBase) appearance33;
    ((Control) this.dtPDateOfBirth).DataBindings.Add(new Binding("Value", (object) this.ds, "tblDriverInfo.DOB", true));
    this.dtPDateOfBirth.DateTime = new DateTime(1753, 1, 1, 0, 0, 0, 0);
    ((Control) this.dtPDateOfBirth).Location = new Point(341, 13);
    this.dtPDateOfBirth.MGAStyle = MGAStyles.Blue;
    ((Control) this.dtPDateOfBirth).Name = "dtPDateOfBirth";
    ((Control) this.dtPDateOfBirth).Size = new Size(96 /*0x60*/, 20);
    ((Control) this.dtPDateOfBirth).TabIndex = 4;
    ((UltraControlBase) this.dtPDateOfBirth).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dtPDateOfBirth).UseOsThemes = (DefaultableBoolean) 2;
    this.dtPDateOfBirth.Value = (object) null;
    ((TextEditorControlBase) this.txtLastName).Appearance = (AppearanceBase) appearance34;
    ((TextEditorControlBase) this.txtLastName).BackColor = Color.White;
    ((Control) this.txtLastName).DataBindings.Add(new Binding("Value", (object) this.ds, "tblDriverInfo.LastName", true));
    ((Control) this.txtLastName).Location = new Point(92, 68);
    ((TextEditorControlBase) this.txtLastName).MaxLength = 100;
    this.txtLastName.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtLastName).Name = "txtLastName";
    ((Control) this.txtLastName).Size = new Size(128 /*0x80*/, 20);
    ((Control) this.txtLastName).TabIndex = 2;
    ((UltraControlBase) this.txtLastName).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtLastName).UseOsThemes = (DefaultableBoolean) 2;
    appearance75.BackColor = Color.White;
    appearance75.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance75.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtFirstName).Appearance = (AppearanceBase) appearance75;
    ((TextEditorControlBase) this.txtFirstName).BackColor = Color.White;
    ((Control) this.txtFirstName).DataBindings.Add(new Binding("Value", (object) this.ds, "tblDriverInfo.FirstName", true));
    ((Control) this.txtFirstName).Location = new Point(92, 40);
    ((TextEditorControlBase) this.txtFirstName).MaxLength = 100;
    this.txtFirstName.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtFirstName).Name = "txtFirstName";
    ((Control) this.txtFirstName).Size = new Size(128 /*0x80*/, 20);
    ((Control) this.txtFirstName).TabIndex = 1;
    ((UltraControlBase) this.txtFirstName).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtFirstName).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.tabAddlDriverInfo).Controls.Add((Control) this.txtErrorDescription);
    ((Control) this.tabAddlDriverInfo).Controls.Add((Control) this.lblErrorDescription);
    ((Control) this.tabAddlDriverInfo).Controls.Add((Control) this.txtCompanyClass);
    ((Control) this.tabAddlDriverInfo).Controls.Add((Control) this.txtInvoicePath);
    ((Control) this.tabAddlDriverInfo).Controls.Add((Control) this.lblCompanyClass);
    ((Control) this.tabAddlDriverInfo).Controls.Add((Control) this.lblInvoicePath);
    ((Control) this.tabAddlDriverInfo).Controls.Add((Control) this.txtMatchError);
    ((Control) this.tabAddlDriverInfo).Controls.Add((Control) this.lblMatchError);
    ((Control) this.tabAddlDriverInfo).Controls.Add((Control) this.txtDocumentValidationResult);
    ((Control) this.tabAddlDriverInfo).Controls.Add((Control) this.lblLicenseValidationResult);
    ((Control) this.tabAddlDriverInfo).Controls.Add((Control) this.MgaTextBox13);
    ((Control) this.tabAddlDriverInfo).Controls.Add((Control) this.Label41);
    ((Control) this.tabAddlDriverInfo).Controls.Add((Control) this.chkHasDOC);
    ((Control) this.tabAddlDriverInfo).Controls.Add((Control) this.Label38);
    ((Control) this.tabAddlDriverInfo).Controls.Add((Control) this.dtpDriverExcluded);
    ((Control) this.tabAddlDriverInfo).Controls.Add((Control) this.lblYearsLogTruckExperience);
    ((Control) this.tabAddlDriverInfo).Controls.Add((Control) this.numYearsLogTruckExperienceNum);
    ((Control) this.tabAddlDriverInfo).Controls.Add((Control) this.Label35);
    ((Control) this.tabAddlDriverInfo).Controls.Add((Control) this.dtpDateOfOrigCDL);
    ((Control) this.tabAddlDriverInfo).Controls.Add((Control) this.lblDateOfHire);
    ((Control) this.tabAddlDriverInfo).Controls.Add((Control) this.dtpDateOfHire);
    ((Control) this.tabAddlDriverInfo).Controls.Add((Control) this.GroupBox1);
    ((Control) this.tabAddlDriverInfo).Location = new Point(-10000, -10000);
    ((Control) this.tabAddlDriverInfo).Name = "tabAddlDriverInfo";
    ((Control) this.tabAddlDriverInfo).Size = new Size(1011, 174);
    appearance76.BackColor = Color.White;
    appearance76.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance76.ForeColor = Color.Black;
    ((AppearanceBase) appearance76).TextHAlignAsString = "Left";
    ((TextEditorControlBase) this.txtErrorDescription).Appearance = (AppearanceBase) appearance76;
    ((TextEditorControlBase) this.txtErrorDescription).BackColor = Color.White;
    ((Control) this.txtErrorDescription).Location = new Point(782, 52);
    ((TextEditorControlBase) this.txtErrorDescription).MaxLength = 100;
    this.txtErrorDescription.MGAStyle = MGAStyles.Blue;
    this.txtErrorDescription.Multiline = true;
    ((Control) this.txtErrorDescription).Name = "txtErrorDescription";
    ((EditorButtonControlBase) this.txtErrorDescription).ReadOnly = true;
    ((Control) this.txtErrorDescription).Size = new Size(120, 30);
    ((Control) this.txtErrorDescription).TabIndex = 144 /*0x90*/;
    ((UltraControlBase) this.txtErrorDescription).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtErrorDescription).UseOsThemes = (DefaultableBoolean) 2;
    this.lblErrorDescription.AutoSize = true;
    this.lblErrorDescription.BackColor = Color.Transparent;
    this.lblErrorDescription.Location = new Point(648, 52);
    this.lblErrorDescription.Name = "lblErrorDescription";
    this.lblErrorDescription.Size = new Size(91, 13);
    this.lblErrorDescription.TabIndex = 145;
    this.lblErrorDescription.Text = "Error Description:";
    appearance77.BackColor = Color.White;
    appearance77.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance77.ForeColor = Color.Black;
    ((AppearanceBase) appearance77).TextHAlignAsString = "Left";
    ((TextEditorControlBase) this.txtCompanyClass).Appearance = (AppearanceBase) appearance77;
    ((TextEditorControlBase) this.txtCompanyClass).BackColor = Color.White;
    ((Control) this.txtCompanyClass).Location = new Point(782, 26);
    ((TextEditorControlBase) this.txtCompanyClass).MaxLength = 100;
    this.txtCompanyClass.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtCompanyClass).Name = "txtCompanyClass";
    ((EditorButtonControlBase) this.txtCompanyClass).ReadOnly = true;
    ((Control) this.txtCompanyClass).Size = new Size(120, 20);
    ((Control) this.txtCompanyClass).TabIndex = 137;
    ((UltraControlBase) this.txtCompanyClass).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtCompanyClass).UseOsThemes = (DefaultableBoolean) 2;
    appearance78.BackColor = Color.White;
    appearance78.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance78.ForeColor = Color.Black;
    ((AppearanceBase) appearance78).TextHAlignAsString = "Left";
    ((TextEditorControlBase) this.txtInvoicePath).Appearance = (AppearanceBase) appearance78;
    ((TextEditorControlBase) this.txtInvoicePath).BackColor = Color.White;
    ((Control) this.txtInvoicePath).Font = new Font("Tahoma", 8f, FontStyle.Bold);
    ((Control) this.txtInvoicePath).Location = new Point(782, 140);
    ((TextEditorControlBase) this.txtInvoicePath).MaxLength = 10;
    this.txtInvoicePath.MGAStyle = MGAStyles.Blue;
    this.txtInvoicePath.Multiline = true;
    ((Control) this.txtInvoicePath).Name = "txtInvoicePath";
    ((EditorButtonControlBase) this.txtInvoicePath).ReadOnly = true;
    ((Control) this.txtInvoicePath).Size = new Size(120, 31 /*0x1F*/);
    ((Control) this.txtInvoicePath).TabIndex = 142;
    ((UltraControlBase) this.txtInvoicePath).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtInvoicePath).UseOsThemes = (DefaultableBoolean) 2;
    this.lblCompanyClass.AutoSize = true;
    this.lblCompanyClass.BackColor = Color.Transparent;
    this.lblCompanyClass.Location = new Point(647, 30);
    this.lblCompanyClass.Name = "lblCompanyClass";
    this.lblCompanyClass.Size = new Size(84, 13);
    this.lblCompanyClass.TabIndex = 138;
    this.lblCompanyClass.Text = "Company Class:";
    this.lblInvoicePath.AutoSize = true;
    this.lblInvoicePath.BackColor = Color.Transparent;
    this.lblInvoicePath.Location = new Point(648, 142);
    this.lblInvoicePath.Name = "lblInvoicePath";
    this.lblInvoicePath.Size = new Size(71, 13);
    this.lblInvoicePath.TabIndex = 143;
    this.lblInvoicePath.Text = "Invoice Path:";
    appearance79.BackColor = Color.White;
    appearance79.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance79.ForeColor = Color.Black;
    ((AppearanceBase) appearance79).TextHAlignAsString = "Left";
    ((TextEditorControlBase) this.txtMatchError).Appearance = (AppearanceBase) appearance79;
    ((TextEditorControlBase) this.txtMatchError).BackColor = Color.White;
    ((Control) this.txtMatchError).Font = new Font("Tahoma", 8f, FontStyle.Bold);
    ((Control) this.txtMatchError).Location = new Point(782, 114);
    ((TextEditorControlBase) this.txtMatchError).MaxLength = 10;
    this.txtMatchError.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtMatchError).Name = "txtMatchError";
    ((EditorButtonControlBase) this.txtMatchError).ReadOnly = true;
    ((Control) this.txtMatchError).Size = new Size(119, 20);
    ((Control) this.txtMatchError).TabIndex = 140;
    ((UltraControlBase) this.txtMatchError).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtMatchError).UseOsThemes = (DefaultableBoolean) 2;
    this.lblMatchError.AutoSize = true;
    this.lblMatchError.BackColor = Color.Transparent;
    this.lblMatchError.Location = new Point(648, 118);
    this.lblMatchError.Name = "lblMatchError";
    this.lblMatchError.Size = new Size(105, 13);
    this.lblMatchError.TabIndex = 141;
    this.lblMatchError.Text = "License Match Error:";
    appearance80.BackColor = Color.White;
    appearance80.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance80.ForeColor = Color.Black;
    ((AppearanceBase) appearance80).TextHAlignAsString = "Left";
    ((TextEditorControlBase) this.txtDocumentValidationResult).Appearance = (AppearanceBase) appearance80;
    ((TextEditorControlBase) this.txtDocumentValidationResult).BackColor = Color.White;
    ((Control) this.txtDocumentValidationResult).Font = new Font("Tahoma", 8f, FontStyle.Bold);
    ((Control) this.txtDocumentValidationResult).Location = new Point(782, 88);
    ((TextEditorControlBase) this.txtDocumentValidationResult).MaxLength = 10;
    this.txtDocumentValidationResult.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtDocumentValidationResult).Name = "txtDocumentValidationResult";
    ((EditorButtonControlBase) this.txtDocumentValidationResult).ReadOnly = true;
    ((Control) this.txtDocumentValidationResult).Size = new Size(119, 20);
    ((Control) this.txtDocumentValidationResult).TabIndex = 137;
    ((UltraControlBase) this.txtDocumentValidationResult).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtDocumentValidationResult).UseOsThemes = (DefaultableBoolean) 2;
    this.lblLicenseValidationResult.AutoSize = true;
    this.lblLicenseValidationResult.BackColor = Color.Transparent;
    this.lblLicenseValidationResult.Location = new Point(648, 92);
    this.lblLicenseValidationResult.Name = "lblLicenseValidationResult";
    this.lblLicenseValidationResult.Size = new Size(128 /*0x80*/, 13);
    this.lblLicenseValidationResult.TabIndex = 139;
    this.lblLicenseValidationResult.Text = "License Validation Result:";
    appearance81.BackColor = Color.White;
    appearance81.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance81.ForeColor = Color.Black;
    ((AppearanceBase) appearance81).TextHAlignAsString = "Left";
    ((TextEditorControlBase) this.MgaTextBox13).Appearance = (AppearanceBase) appearance81;
    ((TextEditorControlBase) this.MgaTextBox13).BackColor = Color.White;
    ((Control) this.MgaTextBox13).DataBindings.Add(new Binding("Text", (object) this.ds, "tblDriverInfo.JobTitle", true));
    ((Control) this.MgaTextBox13).Font = new Font("Tahoma", 8f);
    ((Control) this.MgaTextBox13).Location = new Point(454, 140);
    ((TextEditorControlBase) this.MgaTextBox13).MaxLength = 100;
    this.MgaTextBox13.MGAStyle = MGAStyles.Blue;
    this.MgaTextBox13.Multiline = true;
    ((Control) this.MgaTextBox13).Name = "MgaTextBox13";
    ((Control) this.MgaTextBox13).Size = new Size(144 /*0x90*/, 26);
    ((Control) this.MgaTextBox13).TabIndex = 138;
    ((UltraControlBase) this.MgaTextBox13).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaTextBox13).UseOsThemes = (DefaultableBoolean) 2;
    this.Label41.AutoSize = true;
    this.Label41.BackColor = Color.Transparent;
    this.Label41.Location = new Point(379, 143);
    this.Label41.Name = "Label41";
    this.Label41.Size = new Size(51, 13);
    this.Label41.TabIndex = 137;
    this.Label41.Text = "Job Title:";
    appearance82.BackColor = Color.Transparent;
    appearance82.BorderColor = Color.Gray;
    appearance82.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkHasDOC).Appearance = (AppearanceBase) appearance82;
    ((UltraToggleEditorBase) this.chkHasDOC).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkHasDOC).BackColorInternal = Color.Transparent;
    ((Control) this.chkHasDOC).DataBindings.Add(new Binding("CheckedValue", (object) this.ds, "tblDriverInfo.DOC", true));
    ((UltraToggleEditorBase) this.chkHasDOC).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkHasDOC).Location = new Point(651, 3);
    ((Control) this.chkHasDOC).Name = "chkHasDOC";
    ((Control) this.chkHasDOC).Size = new Size(187, 19);
    ((Control) this.chkHasDOC).TabIndex = 129;
    ((UltraToggleEditorBase) this.chkHasDOC).Text = "Has Driver For Other Car (DOC)?";
    ((UltraControlBase) this.chkHasDOC).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkHasDOC).UseOsThemes = (DefaultableBoolean) 2;
    this.Label38.AutoSize = true;
    this.Label38.BackColor = Color.Transparent;
    this.Label38.Location = new Point(379, 85);
    this.Label38.Name = "Label38";
    this.Label38.Size = new Size(86, 13);
    this.Label38.TabIndex = 128 /*0x80*/;
    this.Label38.Text = "Driver Excluded:";
    appearance83.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.dtpDriverExcluded.Appearance = (AppearanceBase) appearance83;
    appearance84.AlphaLevel = (short) 14;
    appearance84.BackColor = Color.FromArgb(0, 0, 246, 253);
    appearance84.BackColor2 = Color.FromArgb(133, 162, 221);
    appearance84.BackColorAlpha = (Alpha) 2;
    appearance84.BackGradientAlignment = (GradientAlignment) 4;
    appearance84.BackGradientStyle = (GradientStyle) 5;
    appearance84.BorderAlpha = (Alpha) 1;
    appearance84.BorderColor = Color.FromArgb(78, 122, 171);
    appearance84.ForeColor = Color.FromArgb(49, 85, 153);
    appearance84.ForegroundAlpha = (Alpha) 2;
    this.dtpDriverExcluded.ButtonAppearance = (AppearanceBase) appearance84;
    ((Control) this.dtpDriverExcluded).DataBindings.Add(new Binding("Value", (object) this.ds, "tblDriverInfo.DriverExcluded", true));
    this.dtpDriverExcluded.DateTime = new DateTime(1753, 1, 1, 0, 0, 0, 0);
    ((Control) this.dtpDriverExcluded).Location = new Point(528, 81);
    this.dtpDriverExcluded.MGAStyle = MGAStyles.Blue;
    ((Control) this.dtpDriverExcluded).Name = "dtpDriverExcluded";
    ((Control) this.dtpDriverExcluded).Size = new Size(98, 20);
    ((Control) this.dtpDriverExcluded).TabIndex = 2;
    ((UltraControlBase) this.dtpDriverExcluded).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dtpDriverExcluded).UseOsThemes = (DefaultableBoolean) 2;
    this.dtpDriverExcluded.Value = (object) null;
    this.lblYearsLogTruckExperience.AutoSize = true;
    this.lblYearsLogTruckExperience.BackColor = Color.Transparent;
    this.lblYearsLogTruckExperience.Location = new Point(379, 116);
    this.lblYearsLogTruckExperience.Name = "lblYearsLogTruckExperience";
    this.lblYearsLogTruckExperience.Size = new Size(143, 13);
    this.lblYearsLogTruckExperience.TabIndex = 126;
    this.lblYearsLogTruckExperience.Text = "Years Log Truck Experience:";
    appearance85.BackColorDisabled = Color.Gainsboro;
    appearance85.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.numYearsLogTruckExperienceNum).Appearance = (AppearanceBase) appearance85;
    ((Control) this.numYearsLogTruckExperienceNum).DataBindings.Add(new Binding("Value", (object) this.ds, "tblDriverInfo.YearsLogTruckExperienceNum", true));
    ((UltraNumericEditorBase) this.numYearsLogTruckExperienceNum).FormatString = "";
    ((Control) this.numYearsLogTruckExperienceNum).Location = new Point(528, 112 /*0x70*/);
    this.numYearsLogTruckExperienceNum.MaskInput = "nnnnnnn";
    this.numYearsLogTruckExperienceNum.MaxValue = (object) new Decimal(new int[4]
    {
      9999999,
      0,
      0,
      0
    });
    this.numYearsLogTruckExperienceNum.MGAStyle = MGAStyles.Blue;
    this.numYearsLogTruckExperienceNum.MinValue = (object) new Decimal(new int[4]
    {
      9999999,
      0,
      0,
      int.MinValue
    });
    ((Control) this.numYearsLogTruckExperienceNum).Name = "numYearsLogTruckExperienceNum";
    this.numYearsLogTruckExperienceNum.Nullable = true;
    ((Control) this.numYearsLogTruckExperienceNum).Size = new Size(70, 20);
    ((Control) this.numYearsLogTruckExperienceNum).TabIndex = 3;
    ((UltraWinEditorMaskedControlBase) this.numYearsLogTruckExperienceNum).TabNavigation = (MaskedEditTabNavigation) 0;
    ((UltraControlBase) this.numYearsLogTruckExperienceNum).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.numYearsLogTruckExperienceNum).UseOsThemes = (DefaultableBoolean) 2;
    this.Label35.AutoSize = true;
    this.Label35.BackColor = Color.Transparent;
    this.Label35.Location = new Point(379, 54);
    this.Label35.Name = "Label35";
    this.Label35.Size = new Size(96 /*0x60*/, 13);
    this.Label35.TabIndex = 124;
    this.Label35.Text = "Date of Orig. CDL:";
    appearance86.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.dtpDateOfOrigCDL.Appearance = (AppearanceBase) appearance86;
    appearance87.AlphaLevel = (short) 14;
    appearance87.BackColor = Color.FromArgb(0, 0, 246, 253);
    appearance87.BackColor2 = Color.FromArgb(133, 162, 221);
    appearance87.BackColorAlpha = (Alpha) 2;
    appearance87.BackGradientAlignment = (GradientAlignment) 4;
    appearance87.BackGradientStyle = (GradientStyle) 5;
    appearance87.BorderAlpha = (Alpha) 1;
    appearance87.BorderColor = Color.FromArgb(78, 122, 171);
    appearance87.ForeColor = Color.FromArgb(49, 85, 153);
    appearance87.ForegroundAlpha = (Alpha) 2;
    this.dtpDateOfOrigCDL.ButtonAppearance = (AppearanceBase) appearance87;
    ((Control) this.dtpDateOfOrigCDL).DataBindings.Add(new Binding("Value", (object) this.ds, "tblDriverInfo.DateOfOrigCDL", true));
    this.dtpDateOfOrigCDL.DateTime = new DateTime(1753, 1, 1, 0, 0, 0, 0);
    ((Control) this.dtpDateOfOrigCDL).Location = new Point(528, 50);
    this.dtpDateOfOrigCDL.MGAStyle = MGAStyles.Blue;
    ((Control) this.dtpDateOfOrigCDL).Name = "dtpDateOfOrigCDL";
    ((Control) this.dtpDateOfOrigCDL).Size = new Size(98, 20);
    ((Control) this.dtpDateOfOrigCDL).TabIndex = 1;
    ((UltraControlBase) this.dtpDateOfOrigCDL).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dtpDateOfOrigCDL).UseOsThemes = (DefaultableBoolean) 2;
    this.dtpDateOfOrigCDL.Value = (object) null;
    this.lblDateOfHire.AutoSize = true;
    this.lblDateOfHire.BackColor = Color.Transparent;
    this.lblDateOfHire.Location = new Point(379, 23);
    this.lblDateOfHire.Name = "lblDateOfHire";
    this.lblDateOfHire.Size = new Size(69, 13);
    this.lblDateOfHire.TabIndex = 122;
    this.lblDateOfHire.Text = "Date of Hire:";
    appearance88.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.dtpDateOfHire.Appearance = (AppearanceBase) appearance88;
    appearance89.AlphaLevel = (short) 14;
    appearance89.BackColor = Color.FromArgb(0, 0, 246, 253);
    appearance89.BackColor2 = Color.FromArgb(133, 162, 221);
    appearance89.BackColorAlpha = (Alpha) 2;
    appearance89.BackGradientAlignment = (GradientAlignment) 4;
    appearance89.BackGradientStyle = (GradientStyle) 5;
    appearance89.BorderAlpha = (Alpha) 1;
    appearance89.BorderColor = Color.FromArgb(78, 122, 171);
    appearance89.ForeColor = Color.FromArgb(49, 85, 153);
    appearance89.ForegroundAlpha = (Alpha) 2;
    this.dtpDateOfHire.ButtonAppearance = (AppearanceBase) appearance89;
    ((Control) this.dtpDateOfHire).DataBindings.Add(new Binding("Value", (object) this.ds, "tblDriverInfo.DateOfHire", true));
    this.dtpDateOfHire.DateTime = new DateTime(1753, 1, 1, 0, 0, 0, 0);
    ((Control) this.dtpDateOfHire).Location = new Point(528, 19);
    this.dtpDateOfHire.MGAStyle = MGAStyles.Blue;
    ((Control) this.dtpDateOfHire).Name = "dtpDateOfHire";
    ((Control) this.dtpDateOfHire).Size = new Size(98, 20);
    ((Control) this.dtpDateOfHire).TabIndex = 0;
    ((UltraControlBase) this.dtpDateOfHire).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dtpDateOfHire).UseOsThemes = (DefaultableBoolean) 2;
    this.dtpDateOfHire.Value = (object) null;
    this.GroupBox1.BackColor = Color.Transparent;
    this.GroupBox1.Controls.Add((Control) this.txtDLStatus);
    this.GroupBox1.Controls.Add((Control) this.lblDLStatus);
    this.GroupBox1.Controls.Add((Control) this.txtValid);
    this.GroupBox1.Controls.Add((Control) this.txtIsClear);
    this.GroupBox1.Controls.Add((Control) this.Label40);
    this.GroupBox1.Controls.Add((Control) this.Label39);
    this.GroupBox1.Controls.Add((Control) this.MgaTextBox9);
    this.GroupBox1.Controls.Add((Control) this.Label28);
    this.GroupBox1.Controls.Add((Control) this.MgaTextBox8);
    this.GroupBox1.Controls.Add((Control) this.Label26);
    this.GroupBox1.Controls.Add((Control) this.MgaTextBox7);
    this.GroupBox1.Controls.Add((Control) this.Label25);
    this.GroupBox1.Controls.Add((Control) this.MgaTextBox6);
    this.GroupBox1.Controls.Add((Control) this.Label14);
    this.GroupBox1.Controls.Add((Control) this.MgaTextBox2);
    this.GroupBox1.Controls.Add((Control) this.Label13);
    this.GroupBox1.Controls.Add((Control) this.MgaTextBox5);
    this.GroupBox1.Controls.Add((Control) this.Label24);
    this.GroupBox1.Controls.Add((Control) this.MgaTextBox4);
    this.GroupBox1.Controls.Add((Control) this.Label16);
    this.GroupBox1.Controls.Add((Control) this.MgaTextBox3);
    this.GroupBox1.Controls.Add((Control) this.Label15);
    this.GroupBox1.FlatStyle = FlatStyle.Flat;
    this.GroupBox1.Location = new Point(3, 3);
    this.GroupBox1.Name = "GroupBox1";
    this.GroupBox1.Size = new Size(370, 168);
    this.GroupBox1.TabIndex = 120;
    this.GroupBox1.TabStop = false;
    this.GroupBox1.Text = "MVR Analysis / Add'l Info";
    appearance90.BackColor = Color.White;
    appearance90.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance90.ForeColor = Color.Black;
    ((AppearanceBase) appearance90).TextHAlignAsString = "Left";
    ((TextEditorControlBase) this.txtDLStatus).Appearance = (AppearanceBase) appearance90;
    ((TextEditorControlBase) this.txtDLStatus).BackColor = Color.White;
    ((Control) this.txtDLStatus).Font = new Font("Tahoma", 8f, FontStyle.Bold);
    ((Control) this.txtDLStatus).Location = new Point((int) byte.MaxValue, 139);
    ((TextEditorControlBase) this.txtDLStatus).MaxLength = 10;
    this.txtDLStatus.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtDLStatus).Name = "txtDLStatus";
    ((EditorButtonControlBase) this.txtDLStatus).ReadOnly = true;
    ((Control) this.txtDLStatus).Size = new Size(109, 20);
    ((Control) this.txtDLStatus).TabIndex = 136;
    ((UltraControlBase) this.txtDLStatus).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtDLStatus).UseOsThemes = (DefaultableBoolean) 2;
    this.lblDLStatus.AutoSize = true;
    this.lblDLStatus.BackColor = Color.Transparent;
    this.lblDLStatus.Location = new Point(192 /*0xC0*/, 143);
    this.lblDLStatus.Name = "lblDLStatus";
    this.lblDLStatus.Size = new Size(57, 13);
    this.lblDLStatus.TabIndex = 135;
    this.lblDLStatus.Text = "DL Status:";
    appearance91.BackColor = Color.White;
    appearance91.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance91.ForeColor = Color.Black;
    ((AppearanceBase) appearance91).TextHAlignAsString = "Left";
    ((TextEditorControlBase) this.txtValid).Appearance = (AppearanceBase) appearance91;
    ((TextEditorControlBase) this.txtValid).BackColor = Color.White;
    ((Control) this.txtValid).Font = new Font("Tahoma", 8f, FontStyle.Bold);
    ((Control) this.txtValid).Location = new Point(320, 109);
    ((TextEditorControlBase) this.txtValid).MaxLength = 10;
    this.txtValid.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtValid).Name = "txtValid";
    ((EditorButtonControlBase) this.txtValid).ReadOnly = true;
    ((Control) this.txtValid).Size = new Size(31 /*0x1F*/, 20);
    ((Control) this.txtValid).TabIndex = 134;
    ((UltraControlBase) this.txtValid).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtValid).UseOsThemes = (DefaultableBoolean) 2;
    appearance92.BackColor = Color.White;
    appearance92.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance92.ForeColor = Color.Black;
    ((AppearanceBase) appearance92).TextHAlignAsString = "Left";
    ((TextEditorControlBase) this.txtIsClear).Appearance = (AppearanceBase) appearance92;
    ((TextEditorControlBase) this.txtIsClear).BackColor = Color.White;
    ((Control) this.txtIsClear).Font = new Font("Tahoma", 8f, FontStyle.Bold);
    ((Control) this.txtIsClear).Location = new Point(243, 109);
    ((TextEditorControlBase) this.txtIsClear).MaxLength = 10;
    this.txtIsClear.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtIsClear).Name = "txtIsClear";
    ((EditorButtonControlBase) this.txtIsClear).ReadOnly = true;
    ((Control) this.txtIsClear).Size = new Size(31 /*0x1F*/, 20);
    ((Control) this.txtIsClear).TabIndex = 133;
    ((UltraControlBase) this.txtIsClear).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtIsClear).UseOsThemes = (DefaultableBoolean) 2;
    this.Label40.AutoSize = true;
    this.Label40.BackColor = Color.Transparent;
    this.Label40.Location = new Point(280, 113);
    this.Label40.Name = "Label40";
    this.Label40.Size = new Size(33, 13);
    this.Label40.TabIndex = 132;
    this.Label40.Text = "Valid:";
    this.Label39.AutoSize = true;
    this.Label39.BackColor = Color.Transparent;
    this.Label39.Location = new Point(192 /*0xC0*/, 113);
    this.Label39.Name = "Label39";
    this.Label39.Size = new Size(48 /*0x30*/, 13);
    this.Label39.TabIndex = 131;
    this.Label39.Text = "Is Clear:";
    appearance93.BackColor = Color.White;
    appearance93.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance93.ForeColor = Color.Black;
    ((AppearanceBase) appearance93).TextHAlignAsString = "Left";
    ((TextEditorControlBase) this.MgaTextBox9).Appearance = (AppearanceBase) appearance93;
    ((TextEditorControlBase) this.MgaTextBox9).BackColor = Color.White;
    ((Control) this.MgaTextBox9).DataBindings.Add(new Binding("Value", (object) this.ds, "tblDriverInfo.TotalVtlns", true));
    ((Control) this.MgaTextBox9).Location = new Point(320, 79);
    ((TextEditorControlBase) this.MgaTextBox9).MaxLength = 10;
    this.MgaTextBox9.MGAStyle = MGAStyles.Blue;
    ((Control) this.MgaTextBox9).Name = "MgaTextBox9";
    ((Control) this.MgaTextBox9).Size = new Size(44, 20);
    ((Control) this.MgaTextBox9).TabIndex = 7;
    ((UltraControlBase) this.MgaTextBox9).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaTextBox9).UseOsThemes = (DefaultableBoolean) 2;
    this.Label28.AutoSize = true;
    this.Label28.BackColor = Color.Transparent;
    this.Label28.Location = new Point(192 /*0xC0*/, 83);
    this.Label28.Name = "Label28";
    this.Label28.Size = new Size(35, 13);
    this.Label28.TabIndex = 68;
    this.Label28.Text = "Total:";
    appearance94.BackColor = Color.White;
    appearance94.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance94.ForeColor = Color.Black;
    ((AppearanceBase) appearance94).TextHAlignAsString = "Left";
    ((TextEditorControlBase) this.MgaTextBox8).Appearance = (AppearanceBase) appearance94;
    ((TextEditorControlBase) this.MgaTextBox8).BackColor = Color.White;
    ((Control) this.MgaTextBox8).DataBindings.Add(new Binding("Value", (object) this.ds, "tblDriverInfo.OtherMovingVltns", true));
    ((Control) this.MgaTextBox8).Location = new Point(320, 49);
    ((TextEditorControlBase) this.MgaTextBox8).MaxLength = 10;
    this.MgaTextBox8.MGAStyle = MGAStyles.Blue;
    ((Control) this.MgaTextBox8).Name = "MgaTextBox8";
    ((Control) this.MgaTextBox8).Size = new Size(44, 20);
    ((Control) this.MgaTextBox8).TabIndex = 6;
    ((UltraControlBase) this.MgaTextBox8).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaTextBox8).UseOsThemes = (DefaultableBoolean) 2;
    this.Label26.AutoSize = true;
    this.Label26.BackColor = Color.Transparent;
    this.Label26.Location = new Point(192 /*0xC0*/, 53);
    this.Label26.Name = "Label26";
    this.Label26.Size = new Size(124, 13);
    this.Label26.TabIndex = 66;
    this.Label26.Text = "Other Moving Violations:";
    appearance95.BackColor = Color.White;
    appearance95.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance95.ForeColor = Color.Black;
    ((AppearanceBase) appearance95).TextHAlignAsString = "Left";
    ((TextEditorControlBase) this.MgaTextBox7).Appearance = (AppearanceBase) appearance95;
    ((TextEditorControlBase) this.MgaTextBox7).BackColor = Color.White;
    ((Control) this.MgaTextBox7).DataBindings.Add(new Binding("Value", (object) this.ds, "tblDriverInfo.EquipVltns", true));
    ((Control) this.MgaTextBox7).Location = new Point(320, 19);
    ((TextEditorControlBase) this.MgaTextBox7).MaxLength = 10;
    this.MgaTextBox7.MGAStyle = MGAStyles.Blue;
    ((Control) this.MgaTextBox7).Name = "MgaTextBox7";
    ((Control) this.MgaTextBox7).Size = new Size(44, 20);
    ((Control) this.MgaTextBox7).TabIndex = 5;
    ((UltraControlBase) this.MgaTextBox7).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaTextBox7).UseOsThemes = (DefaultableBoolean) 2;
    this.Label25.AutoSize = true;
    this.Label25.BackColor = Color.Transparent;
    this.Label25.Location = new Point(192 /*0xC0*/, 23);
    this.Label25.Name = "Label25";
    this.Label25.Size = new Size(89, 13);
    this.Label25.TabIndex = 64 /*0x40*/;
    this.Label25.Text = "Equip. Violations:";
    appearance96.BackColor = Color.White;
    appearance96.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance96.ForeColor = Color.Black;
    ((AppearanceBase) appearance96).TextHAlignAsString = "Left";
    ((TextEditorControlBase) this.MgaTextBox6).Appearance = (AppearanceBase) appearance96;
    ((TextEditorControlBase) this.MgaTextBox6).BackColor = Color.White;
    ((Control) this.MgaTextBox6).DataBindings.Add(new Binding("Value", (object) this.ds, "tblDriverInfo.NumOtherAcc", true));
    ((Control) this.MgaTextBox6).Location = new Point(131, 49);
    ((TextEditorControlBase) this.MgaTextBox6).MaxLength = 10;
    this.MgaTextBox6.MGAStyle = MGAStyles.Blue;
    ((Control) this.MgaTextBox6).Name = "MgaTextBox6";
    ((Control) this.MgaTextBox6).Size = new Size(44, 20);
    ((Control) this.MgaTextBox6).TabIndex = 1;
    ((UltraControlBase) this.MgaTextBox6).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaTextBox6).UseOsThemes = (DefaultableBoolean) 2;
    this.Label14.AutoSize = true;
    this.Label14.BackColor = Color.Transparent;
    this.Label14.Location = new Point(6, 53);
    this.Label14.Name = "Label14";
    this.Label14.Size = new Size(94, 13);
    this.Label14.TabIndex = 62;
    this.Label14.Text = "# Other Accident:";
    appearance97.BackColor = Color.White;
    appearance97.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance97.ForeColor = Color.Black;
    ((AppearanceBase) appearance97).TextHAlignAsString = "Left";
    ((TextEditorControlBase) this.MgaTextBox2).Appearance = (AppearanceBase) appearance97;
    ((TextEditorControlBase) this.MgaTextBox2).BackColor = Color.White;
    ((Control) this.MgaTextBox2).DataBindings.Add(new Binding("Value", (object) this.ds, "tblDriverInfo.SecVltns", true));
    ((Control) this.MgaTextBox2).Location = new Point(131, 139);
    ((TextEditorControlBase) this.MgaTextBox2).MaxLength = 10;
    this.MgaTextBox2.MGAStyle = MGAStyles.Blue;
    ((Control) this.MgaTextBox2).Name = "MgaTextBox2";
    ((Control) this.MgaTextBox2).Size = new Size(44, 20);
    ((Control) this.MgaTextBox2).TabIndex = 4;
    ((UltraControlBase) this.MgaTextBox2).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaTextBox2).UseOsThemes = (DefaultableBoolean) 2;
    this.Label13.AutoSize = true;
    this.Label13.BackColor = Color.Transparent;
    this.Label13.Location = new Point(6, 143);
    this.Label13.Name = "Label13";
    this.Label13.Size = new Size(80 /*0x50*/, 13);
    this.Label13.TabIndex = 60;
    this.Label13.Text = "Sec. Violations:";
    appearance98.BackColor = Color.White;
    appearance98.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance98.ForeColor = Color.Black;
    ((AppearanceBase) appearance98).TextHAlignAsString = "Left";
    ((TextEditorControlBase) this.MgaTextBox5).Appearance = (AppearanceBase) appearance98;
    ((TextEditorControlBase) this.MgaTextBox5).BackColor = Color.White;
    ((Control) this.MgaTextBox5).DataBindings.Add(new Binding("Value", (object) this.ds, "tblDriverInfo.SpeedingMoreTenMPH", true));
    ((Control) this.MgaTextBox5).Location = new Point(131, 109);
    ((TextEditorControlBase) this.MgaTextBox5).MaxLength = 10;
    this.MgaTextBox5.MGAStyle = MGAStyles.Blue;
    ((Control) this.MgaTextBox5).Name = "MgaTextBox5";
    ((Control) this.MgaTextBox5).Size = new Size(44, 20);
    ((Control) this.MgaTextBox5).TabIndex = 3;
    ((UltraControlBase) this.MgaTextBox5).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaTextBox5).UseOsThemes = (DefaultableBoolean) 2;
    this.Label24.AutoSize = true;
    this.Label24.BackColor = Color.Transparent;
    this.Label24.Location = new Point(6, 113);
    this.Label24.Name = "Label24";
    this.Label24.Size = new Size(105, 13);
    this.Label24.TabIndex = 58;
    this.Label24.Text = "Speeding > 10 MPH:";
    appearance99.BackColor = Color.White;
    appearance99.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance99.ForeColor = Color.Black;
    ((AppearanceBase) appearance99).TextHAlignAsString = "Left";
    ((TextEditorControlBase) this.MgaTextBox4).Appearance = (AppearanceBase) appearance99;
    ((TextEditorControlBase) this.MgaTextBox4).BackColor = Color.White;
    ((Control) this.MgaTextBox4).DataBindings.Add(new Binding("Value", (object) this.ds, "tblDriverInfo.SpeedingLessTenMPH", true));
    ((Control) this.MgaTextBox4).Location = new Point(131, 79);
    ((TextEditorControlBase) this.MgaTextBox4).MaxLength = 10;
    this.MgaTextBox4.MGAStyle = MGAStyles.Blue;
    ((Control) this.MgaTextBox4).Name = "MgaTextBox4";
    ((Control) this.MgaTextBox4).Size = new Size(44, 20);
    ((Control) this.MgaTextBox4).TabIndex = 2;
    ((UltraControlBase) this.MgaTextBox4).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaTextBox4).UseOsThemes = (DefaultableBoolean) 2;
    this.Label16.AutoSize = true;
    this.Label16.BackColor = Color.Transparent;
    this.Label16.Location = new Point(6, 83);
    this.Label16.Name = "Label16";
    this.Label16.Size = new Size(105, 13);
    this.Label16.TabIndex = 56;
    this.Label16.Text = "Speeding < 10 MPH:";
    appearance100.BackColor = Color.White;
    appearance100.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance100.ForeColor = Color.Black;
    ((AppearanceBase) appearance100).TextHAlignAsString = "Left";
    ((TextEditorControlBase) this.MgaTextBox3).Appearance = (AppearanceBase) appearance100;
    ((TextEditorControlBase) this.MgaTextBox3).BackColor = Color.White;
    ((Control) this.MgaTextBox3).DataBindings.Add(new Binding("Value", (object) this.ds, "tblDriverInfo.NumAtFaultAcc", true));
    ((Control) this.MgaTextBox3).Location = new Point(131, 19);
    ((TextEditorControlBase) this.MgaTextBox3).MaxLength = 10;
    this.MgaTextBox3.MGAStyle = MGAStyles.Blue;
    ((Control) this.MgaTextBox3).Name = "MgaTextBox3";
    ((Control) this.MgaTextBox3).Size = new Size(44, 20);
    ((Control) this.MgaTextBox3).TabIndex = 0;
    ((UltraControlBase) this.MgaTextBox3).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaTextBox3).UseOsThemes = (DefaultableBoolean) 2;
    this.Label15.AutoSize = true;
    this.Label15.BackColor = Color.Transparent;
    this.Label15.Location = new Point(6, 23);
    this.Label15.Name = "Label15";
    this.Label15.Size = new Size(104, 13);
    this.Label15.TabIndex = 54;
    this.Label15.Text = "# At Fault Accident:";
    ((Control) this.tabNotes).Controls.Add((Control) this.btnCopyOnRenewal);
    ((Control) this.tabNotes).Controls.Add((Control) this.lnkDeSelectAllCopyRenewal);
    ((Control) this.tabNotes).Controls.Add((Control) this.lnkSelectAllCopyRenewal);
    ((Control) this.tabNotes).Controls.Add((Control) this.btnBulkDelete);
    ((Control) this.tabNotes).Controls.Add((Control) this.lnkDeSelectDeletes);
    ((Control) this.tabNotes).Controls.Add((Control) this.lnkSelectDeletes);
    ((Control) this.tabNotes).Controls.Add((Control) this.GroupBox2);
    ((Control) this.tabNotes).Location = new Point(-10000, -10000);
    ((Control) this.tabNotes).Name = "tabNotes";
    ((Control) this.tabNotes).Size = new Size(1011, 174);
    ((Control) this.btnCopyOnRenewal).Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    appearance101.ImageHAlign = (HAlign) 2;
    appearance101.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnCopyOnRenewal).Appearance = (AppearanceBase) appearance101;
    ((ControlBase) this.btnCopyOnRenewal).BackColorInternal = Color.FromArgb(250, 250, 250);
    ((ControlBase) this.btnCopyOnRenewal).ImageSize = new Size(24, 25);
    ((Control) this.btnCopyOnRenewal).Location = new Point(591, 82);
    ((Control) this.btnCopyOnRenewal).Name = "btnCopyOnRenewal";
    ((Control) this.btnCopyOnRenewal).Size = new Size(69, 26);
    ((Control) this.btnCopyOnRenewal).TabIndex = 304;
    ((ControlBase) this.btnCopyOnRenewal).Text = "Copy";
    this.btnCopyOnRenewal.UseOSThemes = (DefaultableBoolean) 2;
    this.lnkDeSelectAllCopyRenewal.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkDeSelectAllCopyRenewal.AutoSize = true;
    this.lnkDeSelectAllCopyRenewal.BackColor = Color.Transparent;
    this.lnkDeSelectAllCopyRenewal.Location = new Point(396, 117);
    this.lnkDeSelectAllCopyRenewal.Name = "lnkDeSelectAllCopyRenewal";
    this.lnkDeSelectAllCopyRenewal.Size = new Size(175, 13);
    this.lnkDeSelectAllCopyRenewal.TabIndex = 303;
    this.lnkDeSelectAllCopyRenewal.TabStop = true;
    this.lnkDeSelectAllCopyRenewal.Text = "De-Select All For Copy On Renewal";
    this.lnkSelectAllCopyRenewal.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkSelectAllCopyRenewal.AutoSize = true;
    this.lnkSelectAllCopyRenewal.BackColor = Color.Transparent;
    this.lnkSelectAllCopyRenewal.Location = new Point(396, 87);
    this.lnkSelectAllCopyRenewal.Name = "lnkSelectAllCopyRenewal";
    this.lnkSelectAllCopyRenewal.Size = new Size(158, 13);
    this.lnkSelectAllCopyRenewal.TabIndex = 302;
    this.lnkSelectAllCopyRenewal.TabStop = true;
    this.lnkSelectAllCopyRenewal.Text = "Select All For Copy On Renewal";
    ((Control) this.btnBulkDelete).Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    appearance102.ImageHAlign = (HAlign) 2;
    appearance102.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnBulkDelete).Appearance = (AppearanceBase) appearance102;
    ((ControlBase) this.btnBulkDelete).BackColorInternal = Color.FromArgb(250, 250, 250);
    ((ControlBase) this.btnBulkDelete).ImageSize = new Size(24, 25);
    ((Control) this.btnBulkDelete).Location = new Point(591, 11);
    ((Control) this.btnBulkDelete).Name = "btnBulkDelete";
    ((Control) this.btnBulkDelete).Size = new Size(69, 26);
    ((Control) this.btnBulkDelete).TabIndex = 301;
    ((ControlBase) this.btnBulkDelete).Text = "Delete";
    this.btnBulkDelete.UseOSThemes = (DefaultableBoolean) 2;
    ((Control) this.btnBulkDelete).Visible = false;
    this.lnkDeSelectDeletes.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkDeSelectDeletes.AutoSize = true;
    this.lnkDeSelectDeletes.BackColor = Color.Transparent;
    this.lnkDeSelectDeletes.Location = new Point(396, 45);
    this.lnkDeSelectDeletes.Name = "lnkDeSelectDeletes";
    this.lnkDeSelectDeletes.Size = new Size(120, 13);
    this.lnkDeSelectDeletes.TabIndex = 124;
    this.lnkDeSelectDeletes.TabStop = true;
    this.lnkDeSelectDeletes.Text = "De-Select All For Delete";
    this.lnkSelectDeletes.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkSelectDeletes.AutoSize = true;
    this.lnkSelectDeletes.BackColor = Color.Transparent;
    this.lnkSelectDeletes.Location = new Point(396, 15);
    this.lnkSelectDeletes.Name = "lnkSelectDeletes";
    this.lnkSelectDeletes.Size = new Size(103, 13);
    this.lnkSelectDeletes.TabIndex = 123;
    this.lnkSelectDeletes.TabStop = true;
    this.lnkSelectDeletes.Text = "Select All For Delete";
    this.GroupBox2.BackColor = Color.Transparent;
    this.GroupBox2.Controls.Add((Control) this.chkPopup);
    this.GroupBox2.Controls.Add((Control) this.Label33);
    this.GroupBox2.Controls.Add((Control) this.MgaTextBox12);
    this.GroupBox2.Controls.Add((Control) this.Label32);
    this.GroupBox2.Controls.Add((Control) this.MgaTextBox11);
    this.GroupBox2.Controls.Add((Control) this.Label31);
    this.GroupBox2.Controls.Add((Control) this.MgaComboBox1);
    this.GroupBox2.Controls.Add((Control) this.Label30);
    this.GroupBox2.Controls.Add((Control) this.MgaTextBox10);
    this.GroupBox2.Location = new Point(17, 0);
    this.GroupBox2.Name = "GroupBox2";
    this.GroupBox2.Size = new Size(342, 168);
    this.GroupBox2.TabIndex = 122;
    this.GroupBox2.TabStop = false;
    appearance103.BackColor = Color.Transparent;
    appearance103.BorderColor = Color.Gray;
    appearance103.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkPopup).Appearance = (AppearanceBase) appearance103;
    ((UltraToggleEditorBase) this.chkPopup).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkPopup).BackColorInternal = Color.Transparent;
    ((Control) this.chkPopup).DataBindings.Add(new Binding("CheckedValue", (object) this.ds, "tblDriverInfo.PopUpNote", true));
    ((UltraToggleEditorBase) this.chkPopup).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkPopup).Location = new Point(134, 65);
    ((Control) this.chkPopup).Name = "chkPopup";
    ((Control) this.chkPopup).Size = new Size(70, 19);
    ((Control) this.chkPopup).TabIndex = 3;
    ((UltraToggleEditorBase) this.chkPopup).Text = "PopUp";
    ((UltraControlBase) this.chkPopup).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkPopup).UseOsThemes = (DefaultableBoolean) 2;
    this.Label33.AutoSize = true;
    this.Label33.BackColor = Color.Transparent;
    this.Label33.Location = new Point(12, 68);
    this.Label33.Name = "Label33";
    this.Label33.Size = new Size(57, 13);
    this.Label33.TabIndex = 83;
    this.Label33.Text = "Days Due:";
    appearance104.BackColor = Color.White;
    appearance104.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance104.ForeColor = Color.Black;
    ((AppearanceBase) appearance104).TextHAlignAsString = "Center";
    ((TextEditorControlBase) this.MgaTextBox12).Appearance = (AppearanceBase) appearance104;
    ((TextEditorControlBase) this.MgaTextBox12).BackColor = Color.White;
    ((Control) this.MgaTextBox12).DataBindings.Add(new Binding("Value", (object) this.ds, "tblDriverInfo.DaysDue", true));
    ((Control) this.MgaTextBox12).Location = new Point(82, 64 /*0x40*/);
    ((TextEditorControlBase) this.MgaTextBox12).MaxLength = 4;
    this.MgaTextBox12.MGAStyle = MGAStyles.Blue;
    ((Control) this.MgaTextBox12).Name = "MgaTextBox12";
    ((Control) this.MgaTextBox12).Size = new Size(33, 20);
    ((Control) this.MgaTextBox12).TabIndex = 2;
    ((UltraControlBase) this.MgaTextBox12).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaTextBox12).UseOsThemes = (DefaultableBoolean) 2;
    this.Label32.AutoSize = true;
    this.Label32.BackColor = Color.Transparent;
    this.Label32.Location = new Point(12, 95);
    this.Label32.Name = "Label32";
    this.Label32.Size = new Size(35, 13);
    this.Label32.TabIndex = 81;
    this.Label32.Text = "Body:";
    appearance105.BackColor = Color.White;
    appearance105.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance105.ForeColor = Color.Black;
    ((TextEditorControlBase) this.MgaTextBox11).Appearance = (AppearanceBase) appearance105;
    ((TextEditorControlBase) this.MgaTextBox11).BackColor = Color.White;
    ((Control) this.MgaTextBox11).DataBindings.Add(new Binding("Value", (object) this.ds, "tblDriverInfo.NoteBody", true));
    ((Control) this.MgaTextBox11).Location = new Point(82, 90);
    ((TextEditorControlBase) this.MgaTextBox11).MaxLength = 800;
    this.MgaTextBox11.MGAStyle = MGAStyles.Blue;
    this.MgaTextBox11.Multiline = true;
    ((Control) this.MgaTextBox11).Name = "MgaTextBox11";
    ((Control) this.MgaTextBox11).Size = new Size(247, 69);
    ((Control) this.MgaTextBox11).TabIndex = 4;
    ((UltraControlBase) this.MgaTextBox11).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaTextBox11).UseOsThemes = (DefaultableBoolean) 2;
    this.Label31.AutoSize = true;
    this.Label31.BackColor = Color.Transparent;
    this.Label31.Location = new Point(12, 15);
    this.Label31.Name = "Label31";
    this.Label31.Size = new Size(55, 13);
    this.Label31.TabIndex = 79;
    this.Label31.Text = "Recipient:";
    this.MgaComboBox1.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.MgaComboBox1).DataBindings.Add(new Binding("Value", (object) this.ds, "tblDriverInfo.NoteRecipient", true));
    ((UltraGridBase) this.MgaComboBox1).DataMember = "tblUsers";
    ((UltraGridBase) this.MgaComboBox1).DataSource = (object) this.ds;
    appearance106.BackColor = Color.White;
    appearance106.BorderColor = Color.FromArgb(78, 122, 171);
    this.MgaComboBox1.DisplayLayout.Appearance = (AppearanceBase) appearance106;
    this.MgaComboBox1.DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridBand5.ColHeadersVisible = false;
    ((HeaderBase) ultraGridColumn10.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn10.Header.VisiblePosition = 0;
    ultraGridColumn10.Hidden = true;
    ultraGridColumn10.Width = 128 /*0x80*/;
    ((HeaderBase) ultraGridColumn11.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn11.Header.VisiblePosition = 1;
    ultraGridColumn11.Width = 181;
    ultraGridBand5.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn10,
      (object) ultraGridColumn11
    });
    this.MgaComboBox1.DisplayLayout.BandsSerializer.Add((object) ultraGridBand5);
    this.MgaComboBox1.DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    this.MgaComboBox1.DisplayLayout.CaptionVisible = (DefaultableBoolean) 2;
    appearance107.BackColor = SystemColors.ActiveBorder;
    appearance107.BackColor2 = SystemColors.ControlDark;
    appearance107.BackGradientStyle = (GradientStyle) 2;
    appearance107.BorderColor = SystemColors.Window;
    ((SpecialBoxBase) this.MgaComboBox1.DisplayLayout.GroupByBox).Appearance = (AppearanceBase) appearance107;
    appearance108.ForeColor = SystemColors.GrayText;
    this.MgaComboBox1.DisplayLayout.GroupByBox.BandLabelAppearance = (AppearanceBase) appearance108;
    ((SpecialBoxBase) this.MgaComboBox1.DisplayLayout.GroupByBox).BorderStyle = (UIElementBorderStyle) 4;
    appearance109.BackColor = SystemColors.ControlLightLight;
    appearance109.BackColor2 = SystemColors.Control;
    appearance109.BackGradientStyle = (GradientStyle) 3;
    appearance109.ForeColor = SystemColors.GrayText;
    this.MgaComboBox1.DisplayLayout.GroupByBox.PromptAppearance = (AppearanceBase) appearance109;
    this.MgaComboBox1.DisplayLayout.MaxColScrollRegions = 1;
    this.MgaComboBox1.DisplayLayout.MaxRowScrollRegions = 1;
    appearance110.BackColor = SystemColors.Window;
    appearance110.ForeColor = SystemColors.ControlText;
    this.MgaComboBox1.DisplayLayout.Override.ActiveCellAppearance = (AppearanceBase) appearance110;
    appearance111.BackColor = SystemColors.Highlight;
    appearance111.ForeColor = SystemColors.HighlightText;
    this.MgaComboBox1.DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance111;
    this.MgaComboBox1.DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 1;
    this.MgaComboBox1.DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 1;
    appearance112.BackColor = SystemColors.Window;
    this.MgaComboBox1.DisplayLayout.Override.CardAreaAppearance = (AppearanceBase) appearance112;
    appearance113.BorderColor = Color.Silver;
    appearance113.TextTrimming = (TextTrimming) 3;
    this.MgaComboBox1.DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance113;
    this.MgaComboBox1.DisplayLayout.Override.CellClickAction = (CellClickAction) 4;
    this.MgaComboBox1.DisplayLayout.Override.CellPadding = 0;
    appearance114.BackColor = SystemColors.Control;
    appearance114.BackColor2 = SystemColors.ControlDark;
    appearance114.BackGradientAlignment = (GradientAlignment) 1;
    appearance114.BackGradientStyle = (GradientStyle) 3;
    appearance114.BorderColor = SystemColors.Window;
    this.MgaComboBox1.DisplayLayout.Override.GroupByRowAppearance = (AppearanceBase) appearance114;
    ((AppearanceBase) appearance115).TextHAlignAsString = "Left";
    this.MgaComboBox1.DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance115;
    this.MgaComboBox1.DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 3;
    this.MgaComboBox1.DisplayLayout.Override.HeaderStyle = (HeaderStyle) 2;
    appearance116.BackColor = Color.FromArgb(240 /*0xF0*/, 246, 254);
    appearance116.BorderColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this.MgaComboBox1.DisplayLayout.Override.HotTrackRowAppearance = (AppearanceBase) appearance116;
    appearance117.BackColor = SystemColors.Window;
    appearance117.BorderColor = Color.White;
    this.MgaComboBox1.DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance117;
    this.MgaComboBox1.DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    this.MgaComboBox1.DisplayLayout.Override.RowSpacingAfter = 1;
    appearance118.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance118.BorderColor = Color.FromArgb((int) byte.MaxValue, 214, 88);
    appearance118.ForeColor = Color.Black;
    this.MgaComboBox1.DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance118;
    appearance119.BackColor = SystemColors.ControlLight;
    this.MgaComboBox1.DisplayLayout.Override.TemplateAddRowAppearance = (AppearanceBase) appearance119;
    scrollBarLook5.ViewStyle = (ScrollBarViewStyle) 3;
    this.MgaComboBox1.DisplayLayout.ScrollBarLook = scrollBarLook5;
    this.MgaComboBox1.DisplayLayout.ScrollBounds = (ScrollBounds) 0;
    this.MgaComboBox1.DisplayLayout.ScrollStyle = (ScrollStyle) 1;
    this.MgaComboBox1.DisplayLayout.ViewStyleBand = (ViewStyleBand) 2;
    ((UltraDropDownBase) this.MgaComboBox1).DisplayMember = "Name_LastFirst";
    this.MgaComboBox1.DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.MgaComboBox1).DropDownWidth = 200;
    ((Control) this.MgaComboBox1).Location = new Point(82, 11);
    this.MgaComboBox1.MGAStyle = MGAStyles.Blue;
    ((Control) this.MgaComboBox1).Name = "MgaComboBox1";
    ((Control) this.MgaComboBox1).Size = new Size(247, 21);
    ((Control) this.MgaComboBox1).TabIndex = 0;
    ((UltraControlBase) this.MgaComboBox1).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaComboBox1).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.MgaComboBox1).ValueMember = "UserGUID";
    this.Label30.AutoSize = true;
    this.Label30.BackColor = Color.Transparent;
    this.Label30.Location = new Point(12, 42);
    this.Label30.Name = "Label30";
    this.Label30.Size = new Size(47, 13);
    this.Label30.TabIndex = 77;
    this.Label30.Text = "Subject:";
    appearance120.BackColor = Color.White;
    appearance120.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance120.ForeColor = Color.Black;
    ((TextEditorControlBase) this.MgaTextBox10).Appearance = (AppearanceBase) appearance120;
    ((TextEditorControlBase) this.MgaTextBox10).BackColor = Color.White;
    ((Control) this.MgaTextBox10).DataBindings.Add(new Binding("Value", (object) this.ds, "tblDriverInfo.NoteSubject", true));
    ((Control) this.MgaTextBox10).Location = new Point(82, 38);
    ((TextEditorControlBase) this.MgaTextBox10).MaxLength = 100;
    this.MgaTextBox10.MGAStyle = MGAStyles.Blue;
    ((Control) this.MgaTextBox10).Name = "MgaTextBox10";
    ((Control) this.MgaTextBox10).Size = new Size(247, 20);
    ((Control) this.MgaTextBox10).TabIndex = 1;
    ((UltraControlBase) this.MgaTextBox10).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaTextBox10).UseOsThemes = (DefaultableBoolean) 2;
    this.err.ContainerControl = (ContainerControl) this;
    this.lnkDeletedRecords.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkDeletedRecords.AutoSize = true;
    this.lnkDeletedRecords.BackColor = Color.Transparent;
    this.lnkDeletedRecords.Location = new Point(5, 482);
    this.lnkDeletedRecords.Name = "lnkDeletedRecords";
    this.lnkDeletedRecords.Size = new Size(89, 13);
    this.lnkDeletedRecords.TabIndex = 26;
    this.lnkDeletedRecords.TabStop = true;
    this.lnkDeletedRecords.Text = "Show All Records";
    this.daDrivers.DeleteCommand = this.sqlDeleteCommand1;
    this.daDrivers.InsertCommand = this.sqlInsertCommand1;
    this.daDrivers.SelectCommand = this.sqlSelectCommand1;
    this.daDrivers.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblDriverInfo", new DataColumnMapping[47]
      {
        new DataColumnMapping("DriverID", "DriverID"),
        new DataColumnMapping("ControlNo", "ControlNo"),
        new DataColumnMapping("QuoteGuid", "QuoteGuid"),
        new DataColumnMapping("FirstName", "FirstName"),
        new DataColumnMapping("LastName", "LastName"),
        new DataColumnMapping("DOB", "DOB"),
        new DataColumnMapping("LicenseNumber", "LicenseNumber"),
        new DataColumnMapping("StateID", "StateID"),
        new DataColumnMapping("StatusID", "StatusID"),
        new DataColumnMapping("DateAdded", "DateAdded"),
        new DataColumnMapping("DriverDeleted", "DriverDeleted"),
        new DataColumnMapping("DriverAdded", "DriverAdded"),
        new DataColumnMapping("NumberOfPoints", "NumberOfPoints"),
        new DataColumnMapping("FurnishedCar", "FurnishedCar"),
        new DataColumnMapping("Comments", "Comments"),
        new DataColumnMapping("FullPartTime", "FullPartTime"),
        new DataColumnMapping("CopyOnRenewal", "CopyOnRenewal"),
        new DataColumnMapping("ModifiedDate", "ModifiedDate"),
        new DataColumnMapping("LicenseExpDate", "LicenseExpDate"),
        new DataColumnMapping("Street1", "Street1"),
        new DataColumnMapping("Street2", "Street2"),
        new DataColumnMapping("City", "City"),
        new DataColumnMapping("ZipCode", "ZipCode"),
        new DataColumnMapping("ZipPlus", "ZipPlus"),
        new DataColumnMapping("DriverRatingFactor", "DriverRatingFactor"),
        new DataColumnMapping("LicenseClass", "LicenseClass"),
        new DataColumnMapping("NumAtFaultAcc", "NumAtFaultAcc"),
        new DataColumnMapping("NumOtherAcc", "NumOtherAcc"),
        new DataColumnMapping("SpeedingLessTenMPH", "SpeedingLessTenMPH"),
        new DataColumnMapping("SpeedingMoreTenMPH", "SpeedingMoreTenMPH"),
        new DataColumnMapping("SecVltns", "SecVltns"),
        new DataColumnMapping("EquipVltns", "EquipVltns"),
        new DataColumnMapping("OtherMovingVltns", "OtherMovingVltns"),
        new DataColumnMapping("TotalVtlns", "TotalVtlns"),
        new DataColumnMapping("MedicalExpiration", "MedicalExpiration"),
        new DataColumnMapping("NoteRecipient", "NoteRecipient"),
        new DataColumnMapping("NoteSubject", "NoteSubject"),
        new DataColumnMapping("NoteBody", "NoteBody"),
        new DataColumnMapping("DaysDue", "DaysDue"),
        new DataColumnMapping("PopUpNote", "PopUpNote"),
        new DataColumnMapping("DateOfHire", "DateOfHire"),
        new DataColumnMapping("DateOfOrigCDL", "DateOfOrigCDL"),
        new DataColumnMapping("YearsLogTruckExperienceNum", "YearsLogTruckExperienceNum"),
        new DataColumnMapping("MVRDate", "MVRDate"),
        new DataColumnMapping("CDLDriverID", "CDLDriverID"),
        new DataColumnMapping("DriverExcluded", "DriverExcluded"),
        new DataColumnMapping("DOC", "DOC")
      })
    });
    this.daDrivers.UpdateCommand = this.sqlUpdateCommand1;
    this.sqlDeleteCommand1.CommandText = "DELETE FROM [dbo].[tblDriverInfo] WHERE (([DriverID] = @Original_DriverID))";
    this.sqlDeleteCommand1.Connection = this.cnSQL;
    this.sqlDeleteCommand1.Parameters.AddRange(new SqlParameter[1]
    {
      new SqlParameter("@Original_DriverID", SqlDbType.BigInt, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "DriverID", DataRowVersion.Original, (object) null)
    });
    this.cnSQL.ConnectionString = "Data Source=mgasystems2012.ny.mgasystems.com;Initial Catalog=IMS;Integrated Security=True";
    this.cnSQL.FireInfoMessageEventOnUserErrors = false;
    this.sqlInsertCommand1.CommandText = componentResourceManager.GetString("sqlInsertCommand1.CommandText");
    this.sqlInsertCommand1.Connection = this.cnSQL;
    this.sqlInsertCommand1.Parameters.AddRange(new SqlParameter[49]
    {
      new SqlParameter("@ControlNo", SqlDbType.Int, 4, "ControlNo"),
      new SqlParameter("@QuoteGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "QuoteGuid"),
      new SqlParameter("@FirstName", SqlDbType.VarChar, 100, "FirstName"),
      new SqlParameter("@LastName", SqlDbType.VarChar, 100, "LastName"),
      new SqlParameter("@DOB", SqlDbType.SmallDateTime, 4, "DOB"),
      new SqlParameter("@LicenseNumber", SqlDbType.VarChar, 50, "LicenseNumber"),
      new SqlParameter("@StateID", SqlDbType.Char, 2, "StateID"),
      new SqlParameter("@StatusID", SqlDbType.Int, 4, "StatusID"),
      new SqlParameter("@DateAdded", SqlDbType.SmallDateTime, 4, "DateAdded"),
      new SqlParameter("@DriverDeleted", SqlDbType.SmallDateTime, 4, "DriverDeleted"),
      new SqlParameter("@DriverAdded", SqlDbType.SmallDateTime, 4, "DriverAdded"),
      new SqlParameter("@NumberOfPoints", SqlDbType.VarChar, 100, "NumberOfPoints"),
      new SqlParameter("@FurnishedCar", SqlDbType.Bit, 1, "FurnishedCar"),
      new SqlParameter("@Comments", SqlDbType.VarChar, 1000, "Comments"),
      new SqlParameter("@FullPartTime", SqlDbType.TinyInt, 1, "FullPartTime"),
      new SqlParameter("@CopyOnRenewal", SqlDbType.Bit, 1, "CopyOnRenewal"),
      new SqlParameter("@ModifiedDate", SqlDbType.DateTime, 8, "ModifiedDate"),
      new SqlParameter("@LicenseExpDate", SqlDbType.DateTime, 8, "LicenseExpDate"),
      new SqlParameter("@Street1", SqlDbType.VarChar, 250, "Street1"),
      new SqlParameter("@Street2", SqlDbType.VarChar, 250, "Street2"),
      new SqlParameter("@City", SqlDbType.VarChar, 100, "City"),
      new SqlParameter("@ZipCode", SqlDbType.Char, 5, "ZipCode"),
      new SqlParameter("@ZipPlus", SqlDbType.Char, 4, "ZipPlus"),
      new SqlParameter("@DriverRatingFactor", SqlDbType.Decimal, 5, ParameterDirection.Input, false, (byte) 5, (byte) 4, "DriverRatingFactor", DataRowVersion.Current, (object) null),
      new SqlParameter("@LicenseClass", SqlDbType.Char, 1, "LicenseClass"),
      new SqlParameter("@NumAtFaultAcc", SqlDbType.VarChar, 10, "NumAtFaultAcc"),
      new SqlParameter("@NumOtherAcc", SqlDbType.VarChar, 10, "NumOtherAcc"),
      new SqlParameter("@SpeedingLessTenMPH", SqlDbType.VarChar, 10, "SpeedingLessTenMPH"),
      new SqlParameter("@SpeedingMoreTenMPH", SqlDbType.VarChar, 10, "SpeedingMoreTenMPH"),
      new SqlParameter("@SecVltns", SqlDbType.VarChar, 10, "SecVltns"),
      new SqlParameter("@EquipVltns", SqlDbType.VarChar, 10, "EquipVltns"),
      new SqlParameter("@OtherMovingVltns", SqlDbType.VarChar, 10, "OtherMovingVltns"),
      new SqlParameter("@TotalVtlns", SqlDbType.VarChar, 10, "TotalVtlns"),
      new SqlParameter("@MedicalExpiration", SqlDbType.DateTime, 8, "MedicalExpiration"),
      new SqlParameter("@NoteRecipient", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "NoteRecipient"),
      new SqlParameter("@NoteSubject", SqlDbType.VarChar, 100, "NoteSubject"),
      new SqlParameter("@NoteBody", SqlDbType.VarChar, 800, "NoteBody"),
      new SqlParameter("@DaysDue", SqlDbType.SmallInt, 2, "DaysDue"),
      new SqlParameter("@PopUpNote", SqlDbType.Bit, 1, "PopUpNote"),
      new SqlParameter("@DateOfHire", SqlDbType.DateTime, 8, "DateOfHire"),
      new SqlParameter("@DateOfOrigCDL", SqlDbType.DateTime, 8, "DateOfOrigCDL"),
      new SqlParameter("@YearsLogTruckExperienceNum", SqlDbType.Int, 4, "YearsLogTruckExperienceNum"),
      new SqlParameter("@MVRDate", SqlDbType.DateTime, 8, "MVRDate"),
      new SqlParameter("@CDLDriverID", SqlDbType.Int, 4, "CDLDriverID"),
      new SqlParameter("@DriverExcluded", SqlDbType.DateTime, 8, "DriverExcluded"),
      new SqlParameter("@DOC", SqlDbType.Bit, 1, "DOC"),
      new SqlParameter("@JobTitle", SqlDbType.VarChar, 100, "JobTitle"),
      new SqlParameter("@LicenseNumberEncrypted", SqlDbType.VarChar, 150, "LicenseNumberEncrypted"),
      new SqlParameter("@DOBEncrypted", SqlDbType.VarChar, 150, "DOBEncrypted")
    });
    this.sqlSelectCommand1.CommandText = componentResourceManager.GetString("sqlSelectCommand1.CommandText");
    this.sqlSelectCommand1.Connection = this.cnSQL;
    this.sqlSelectCommand1.Parameters.AddRange(new SqlParameter[1]
    {
      new SqlParameter("@ControlNo", SqlDbType.Int, 4, "ControlNo")
    });
    this.sqlUpdateCommand1.CommandText = componentResourceManager.GetString("sqlUpdateCommand1.CommandText");
    this.sqlUpdateCommand1.Connection = this.cnSQL;
    this.sqlUpdateCommand1.Parameters.AddRange(new SqlParameter[51]
    {
      new SqlParameter("@ControlNo", SqlDbType.Int, 4, "ControlNo"),
      new SqlParameter("@QuoteGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "QuoteGuid"),
      new SqlParameter("@FirstName", SqlDbType.VarChar, 100, "FirstName"),
      new SqlParameter("@LastName", SqlDbType.VarChar, 100, "LastName"),
      new SqlParameter("@DOB", SqlDbType.SmallDateTime, 4, "DOB"),
      new SqlParameter("@LicenseNumber", SqlDbType.VarChar, 50, "LicenseNumber"),
      new SqlParameter("@StateID", SqlDbType.Char, 2, "StateID"),
      new SqlParameter("@StatusID", SqlDbType.Int, 4, "StatusID"),
      new SqlParameter("@DateAdded", SqlDbType.SmallDateTime, 4, "DateAdded"),
      new SqlParameter("@DriverDeleted", SqlDbType.SmallDateTime, 4, "DriverDeleted"),
      new SqlParameter("@DriverAdded", SqlDbType.SmallDateTime, 4, "DriverAdded"),
      new SqlParameter("@NumberOfPoints", SqlDbType.VarChar, 100, "NumberOfPoints"),
      new SqlParameter("@FurnishedCar", SqlDbType.Bit, 1, "FurnishedCar"),
      new SqlParameter("@Comments", SqlDbType.VarChar, 1000, "Comments"),
      new SqlParameter("@FullPartTime", SqlDbType.TinyInt, 1, "FullPartTime"),
      new SqlParameter("@CopyOnRenewal", SqlDbType.Bit, 1, "CopyOnRenewal"),
      new SqlParameter("@ModifiedDate", SqlDbType.DateTime, 8, "ModifiedDate"),
      new SqlParameter("@LicenseExpDate", SqlDbType.DateTime, 8, "LicenseExpDate"),
      new SqlParameter("@Street1", SqlDbType.VarChar, 250, "Street1"),
      new SqlParameter("@Street2", SqlDbType.VarChar, 250, "Street2"),
      new SqlParameter("@City", SqlDbType.VarChar, 100, "City"),
      new SqlParameter("@ZipCode", SqlDbType.Char, 5, "ZipCode"),
      new SqlParameter("@ZipPlus", SqlDbType.Char, 4, "ZipPlus"),
      new SqlParameter("@DriverRatingFactor", SqlDbType.Decimal, 5, ParameterDirection.Input, false, (byte) 5, (byte) 4, "DriverRatingFactor", DataRowVersion.Current, (object) null),
      new SqlParameter("@LicenseClass", SqlDbType.Char, 1, "LicenseClass"),
      new SqlParameter("@NumAtFaultAcc", SqlDbType.VarChar, 10, "NumAtFaultAcc"),
      new SqlParameter("@NumOtherAcc", SqlDbType.VarChar, 10, "NumOtherAcc"),
      new SqlParameter("@SpeedingLessTenMPH", SqlDbType.VarChar, 10, "SpeedingLessTenMPH"),
      new SqlParameter("@SpeedingMoreTenMPH", SqlDbType.VarChar, 10, "SpeedingMoreTenMPH"),
      new SqlParameter("@SecVltns", SqlDbType.VarChar, 10, "SecVltns"),
      new SqlParameter("@EquipVltns", SqlDbType.VarChar, 10, "EquipVltns"),
      new SqlParameter("@OtherMovingVltns", SqlDbType.VarChar, 10, "OtherMovingVltns"),
      new SqlParameter("@TotalVtlns", SqlDbType.VarChar, 10, "TotalVtlns"),
      new SqlParameter("@MedicalExpiration", SqlDbType.DateTime, 8, "MedicalExpiration"),
      new SqlParameter("@NoteRecipient", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "NoteRecipient"),
      new SqlParameter("@NoteSubject", SqlDbType.VarChar, 100, "NoteSubject"),
      new SqlParameter("@NoteBody", SqlDbType.VarChar, 800, "NoteBody"),
      new SqlParameter("@DaysDue", SqlDbType.SmallInt, 2, "DaysDue"),
      new SqlParameter("@PopUpNote", SqlDbType.Bit, 1, "PopUpNote"),
      new SqlParameter("@DateOfHire", SqlDbType.DateTime, 8, "DateOfHire"),
      new SqlParameter("@DateOfOrigCDL", SqlDbType.DateTime, 8, "DateOfOrigCDL"),
      new SqlParameter("@YearsLogTruckExperienceNum", SqlDbType.Int, 4, "YearsLogTruckExperienceNum"),
      new SqlParameter("@MVRDate", SqlDbType.DateTime, 8, "MVRDate"),
      new SqlParameter("@CDLDriverID", SqlDbType.Int, 4, "CDLDriverID"),
      new SqlParameter("@DriverExcluded", SqlDbType.DateTime, 8, "DriverExcluded"),
      new SqlParameter("@DOC", SqlDbType.Bit, 1, "DOC"),
      new SqlParameter("@JobTitle", SqlDbType.VarChar, 100, "JobTitle"),
      new SqlParameter("@LicenseNumberEncrypted", SqlDbType.VarChar, 150, "LicenseNumberEncrypted"),
      new SqlParameter("@DOBEncrypted", SqlDbType.VarChar, 150, "DOBEncrypted"),
      new SqlParameter("@Original_DriverID", SqlDbType.BigInt, 8, ParameterDirection.Input, false, (byte) 0, (byte) 0, "DriverID", DataRowVersion.Original, (object) null),
      new SqlParameter("@DriverID", SqlDbType.BigInt, 8, ParameterDirection.Input, false, (byte) 0, (byte) 0, "DriverID", DataRowVersion.Original, (object) null)
    });
    this.sqlSelectCommand2.CommandText = "SELECT StateID, State FROM dbo.lstStates";
    this.sqlSelectCommand2.Connection = this.cnSQL;
    this.sqlSelectCommand3.CommandText = "SELECT DriverStatusID, Status FROM lstDriverStatus ORDER BY Status";
    this.sqlSelectCommand3.Connection = this.cnSQL;
    this.lnkCopyFromExpiringQuote.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkCopyFromExpiringQuote.AutoSize = true;
    this.lnkCopyFromExpiringQuote.BackColor = Color.Transparent;
    this.lnkCopyFromExpiringQuote.Location = new Point(108, 428);
    this.lnkCopyFromExpiringQuote.Name = "lnkCopyFromExpiringQuote";
    this.lnkCopyFromExpiringQuote.Size = new Size(168, 13);
    this.lnkCopyFromExpiringQuote.TabIndex = 27;
    this.lnkCopyFromExpiringQuote.TabStop = true;
    this.lnkCopyFromExpiringQuote.Text = "Copy Drivers from Expiring Quote";
    this.lnkCopyFromAnotherQuote.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkCopyFromAnotherQuote.AutoSize = true;
    this.lnkCopyFromAnotherQuote.BackColor = Color.Transparent;
    this.lnkCopyFromAnotherQuote.Location = new Point(108, 482);
    this.lnkCopyFromAnotherQuote.Name = "lnkCopyFromAnotherQuote";
    this.lnkCopyFromAnotherQuote.Size = new Size(225, 13);
    this.lnkCopyFromAnotherQuote.TabIndex = 28;
    this.lnkCopyFromAnotherQuote.TabStop = true;
    this.lnkCopyFromAnotherQuote.Text = "Search and Copy Drivers from another Quote";
    this.lnkPrintDrivers.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkPrintDrivers.AutoSize = true;
    this.lnkPrintDrivers.Location = new Point(5, 428);
    this.lnkPrintDrivers.Name = "lnkPrintDrivers";
    this.lnkPrintDrivers.Size = new Size(66, 13);
    this.lnkPrintDrivers.TabIndex = 29;
    this.lnkPrintDrivers.TabStop = true;
    this.lnkPrintDrivers.Text = "Print Drivers";
    this.lnkADRConnect.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkADRConnect.AutoSize = true;
    this.lnkADRConnect.BackColor = Color.Transparent;
    this.lnkADRConnect.Font = new Font("Tahoma", 9f);
    this.lnkADRConnect.Location = new Point(628, 427);
    this.lnkADRConnect.Name = "lnkADRConnect";
    this.lnkADRConnect.Size = new Size(173, 14);
    this.lnkADRConnect.TabIndex = 30;
    this.lnkADRConnect.TabStop = true;
    this.lnkADRConnect.Text = "ADR Connect - Process Drivers";
    this.lnkSelectAll.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkSelectAll.AutoSize = true;
    this.lnkSelectAll.BackColor = Color.Transparent;
    this.lnkSelectAll.Location = new Point(445, 428);
    this.lnkSelectAll.Name = "lnkSelectAll";
    this.lnkSelectAll.Size = new Size(145, 13);
    this.lnkSelectAll.TabIndex = 31 /*0x1F*/;
    this.lnkSelectAll.TabStop = true;
    this.lnkSelectAll.Text = "Select All for ADR Processing";
    this.lnkDeSelectAll.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkDeSelectAll.AutoSize = true;
    this.lnkDeSelectAll.BackColor = Color.Transparent;
    this.lnkDeSelectAll.Location = new Point(445, 482);
    this.lnkDeSelectAll.Name = "lnkDeSelectAll";
    this.lnkDeSelectAll.Size = new Size(162, 13);
    this.lnkDeSelectAll.TabIndex = 32 /*0x20*/;
    this.lnkDeSelectAll.TabStop = true;
    this.lnkDeSelectAll.Text = "De-Select All for ADR Processing";
    this.panelProcessingADR.BackColorInternal = Color.White;
    appearance121.BorderColor = Color.Gray;
    this.panelProcessingADR.ContentAreaAppearance = (AppearanceBase) appearance121;
    ((Control) this.panelProcessingADR).Controls.Add((Control) this.spinner);
    ((Control) this.panelProcessingADR).Controls.Add((Control) this.labelSearchText);
    ((Control) this.panelProcessingADR).Controls.Add((Control) label);
    ((Control) this.panelProcessingADR).ForeColor = Color.Black;
    ((Control) this.panelProcessingADR).Location = new Point(291, 74);
    ((Control) this.panelProcessingADR).Name = "panelProcessingADR";
    ((Control) this.panelProcessingADR).Size = new Size(335, 140);
    ((Control) this.panelProcessingADR).TabIndex = 116;
    ((Control) this.panelProcessingADR).Visible = false;
    this.spinner.Image = (Image) componentResourceManager.GetObject("spinner.Image");
    this.spinner.Location = new Point(128 /*0x80*/, 81);
    this.spinner.Name = "spinner";
    this.spinner.Size = new Size(72, 44);
    this.spinner.SizeMode = PictureBoxSizeMode.Zoom;
    this.spinner.TabIndex = 116;
    this.spinner.TabStop = false;
    this.labelSearchText.Font = new Font("Tahoma", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.labelSearchText.Location = new Point(10, 52);
    this.labelSearchText.Name = "labelSearchText";
    this.labelSearchText.Size = new Size(319, 19);
    this.labelSearchText.TabIndex = 3;
    this.labelSearchText.Text = "Processing '[NAME]' Record ...";
    this.labelSearchText.TextAlign = ContentAlignment.MiddleCenter;
    this.lnkPasswordUpdate.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkPasswordUpdate.AutoSize = true;
    this.lnkPasswordUpdate.BackColor = Color.Transparent;
    this.lnkPasswordUpdate.Font = new Font("Tahoma", 9f);
    this.lnkPasswordUpdate.Location = new Point(628, 454);
    this.lnkPasswordUpdate.Name = "lnkPasswordUpdate";
    this.lnkPasswordUpdate.Size = new Size(145, 14);
    this.lnkPasswordUpdate.TabIndex = 117;
    this.lnkPasswordUpdate.TabStop = true;
    this.lnkPasswordUpdate.Text = "ADR Password Update ...";
    ((Control) this.tabDriverTab).Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((Control) this.tabDriverTab).Controls.Add((Control) this.ultraTabSharedControlsPage1);
    ((Control) this.tabDriverTab).Controls.Add((Control) this.tabDriverInfo);
    ((Control) this.tabDriverTab).Controls.Add((Control) this.tabAddlDriverInfo);
    ((Control) this.tabDriverTab).Controls.Add((Control) this.tabNotes);
    ((Control) this.tabDriverTab).Location = new Point(4, 215);
    ((Control) this.tabDriverTab).Name = "tabDriverTab";
    ((UltraTabControlBase) this.tabDriverTab).SharedControlsPage = this.ultraTabSharedControlsPage1;
    ((Control) this.tabDriverTab).Size = new Size(1013, 205);
    ((Control) this.tabDriverTab).TabIndex = 291;
    ((UltraTabControlBase) this.tabDriverTab).TabLayoutStyle = (TabLayoutStyle) 2;
    ((UltraTabControlBase) this.tabDriverTab).TabPadding = new Size(1, 5);
    appearance122.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance135.Image"));
    ultraTab1.Appearance = (AppearanceBase) appearance122;
    ultraTab1.TabPage = this.tabDriverInfo;
    ultraTab1.Text = "Driver Information";
    appearance123.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance136.Image"));
    ultraTab2.Appearance = (AppearanceBase) appearance123;
    ultraTab2.TabPage = this.tabAddlDriverInfo;
    ultraTab2.Text = "Add'l Driver Info";
    appearance124.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance137.Image"));
    ultraTab3.Appearance = (AppearanceBase) appearance124;
    ultraTab3.TabPage = this.tabNotes;
    ultraTab3.Text = "Notes";
    ((UltraTabControlBase) this.tabDriverTab).Tabs.AddRange(new UltraTab[3]
    {
      ultraTab1,
      ultraTab2,
      ultraTab3
    });
    ((UltraTabControlBase) this.tabDriverTab).ViewStyle = (ViewStyle) 4;
    ((Control) this.ultraTabSharedControlsPage1).Location = new Point(-10000, -10000);
    ((Control) this.ultraTabSharedControlsPage1).Name = "ultraTabSharedControlsPage1";
    ((Control) this.ultraTabSharedControlsPage1).Size = new Size(1011, 174);
    this.lnkOvernightOrders.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkOvernightOrders.AutoSize = true;
    this.lnkOvernightOrders.BackColor = Color.Transparent;
    this.lnkOvernightOrders.Font = new Font("Tahoma", 9f);
    this.lnkOvernightOrders.Location = new Point(631, 481);
    this.lnkOvernightOrders.Name = "lnkOvernightOrders";
    this.lnkOvernightOrders.Size = new Size(198, 14);
    this.lnkOvernightOrders.TabIndex = 292;
    this.lnkOvernightOrders.TabStop = true;
    this.lnkOvernightOrders.Text = "ADR - Receive Overnight Orders ...";
    this.lnkGenerateDocument.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkGenerateDocument.AutoSize = true;
    this.lnkGenerateDocument.BackColor = Color.Transparent;
    this.lnkGenerateDocument.Location = new Point(230, 453);
    this.lnkGenerateDocument.Name = "lnkGenerateDocument";
    this.lnkGenerateDocument.Size = new Size(103, 13);
    this.lnkGenerateDocument.TabIndex = 296;
    this.lnkGenerateDocument.TabStop = true;
    this.lnkGenerateDocument.Text = "Generate Document";
    this.Label37.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.Label37.AutoSize = true;
    this.Label37.BackColor = Color.Transparent;
    this.Label37.Location = new Point(5, 453);
    this.Label37.Name = "Label37";
    this.Label37.Size = new Size(60, 13);
    this.Label37.TabIndex = 95;
    this.Label37.Text = "Templates:";
    this.btnProcessOvernightOrders.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.btnProcessOvernightOrders.Location = new Point(448, 452);
    this.btnProcessOvernightOrders.Name = "btnProcessOvernightOrders";
    this.btnProcessOvernightOrders.Size = new Size(142, 25);
    this.btnProcessOvernightOrders.TabIndex = 298;
    this.btnProcessOvernightOrders.Text = "Process Overnight Orders";
    this.btnProcessOvernightOrders.UseVisualStyleBackColor = true;
    ((Control) this.UltraTextEditor1).Location = new Point(827, 428);
    ((Control) this.UltraTextEditor1).Name = "UltraTextEditor1";
    this.UltraTextEditor1.PasswordChar = '*';
    ((Control) this.UltraTextEditor1).Size = new Size(15, 22);
    ((Control) this.UltraTextEditor1).TabIndex = 300;
    ((Control) this.UltraTextEditor1).Visible = false;
    ((Control) this.btnIIX).Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    appearance125.ImageHAlign = (HAlign) 2;
    appearance125.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnIIX).Appearance = (AppearanceBase) appearance125;
    ((ControlBase) this.btnIIX).BackColorInternal = Color.FromArgb(250, 250, 250);
    ((ControlBase) this.btnIIX).ImageSize = new Size(24, 25);
    ((Control) this.btnIIX).Location = new Point(346, 424);
    ((Control) this.btnIIX).Name = "btnIIX";
    ((Control) this.btnIIX).Size = new Size(69, 26);
    ((Control) this.btnIIX).TabIndex = 299;
    ((ControlBase) this.btnIIX).Text = "IIX - mvrs";
    this.btnIIX.UseOSThemes = (DefaultableBoolean) 2;
    ((Control) this.btnIIX).Visible = false;
    ((Control) this.cboTemplates).Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.cboTemplates.BorderStyle = (UIElementBorderStyle) 4;
    this.cboTemplates.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboTemplates).Location = new Point(71, 453);
    this.cboTemplates.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboTemplates).Name = "cboTemplates";
    ((Control) this.cboTemplates).Size = new Size(153, 21);
    ((Control) this.cboTemplates).TabIndex = 297;
    ((UltraControlBase) this.cboTemplates).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboTemplates).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.btnQuery).Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    appearance126.ImageHAlign = (HAlign) 2;
    appearance126.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnQuery).Appearance = (AppearanceBase) appearance126;
    ((ControlBase) this.btnQuery).BackColorInternal = Color.FromArgb(250, 250, 250);
    ((ControlBase) this.btnQuery).ImageSize = new Size(24, 24);
    ((Control) this.btnQuery).Location = new Point(346, 459);
    ((Control) this.btnQuery).Name = "btnQuery";
    ((Control) this.btnQuery).Size = new Size(54, 36);
    ((Control) this.btnQuery).TabIndex = 293;
    this.btnQuery.UseOSThemes = (DefaultableBoolean) 2;
    this.dbSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.dbSave.AutoQueryRowCountOnLoad = false;
    this.dbSave.EditStyle = EditStyle.ShowEditButton;
    this.dbSave.FreezeEvents = false;
    this.dbSave.Location = new Point(900, 455);
    this.dbSave.Name = "dbSave";
    this.dbSave.Size = new Size(117, 34);
    this.dbSave.TabIndex = 2;
    ((UltraGridBase) this.uddCDL).DataMember = "lstDriverCDL";
    ((UltraGridBase) this.uddCDL).DataSource = (object) this.ds;
    appearance127.BackColor = SystemColors.Window;
    appearance127.BorderColor = SystemColors.InactiveCaption;
    ((UltraGridBase) this.uddCDL).DisplayLayout.Appearance = (AppearanceBase) appearance127;
    ((HeaderBase) ultraGridColumn12.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn12.Header.VisiblePosition = 0;
    ((HeaderBase) ultraGridColumn13.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn13.Header.VisiblePosition = 1;
    ultraGridBand6.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn12,
      (object) ultraGridColumn13
    });
    ((UltraGridBase) this.uddCDL).DisplayLayout.BandsSerializer.Add((object) ultraGridBand6);
    ((UltraGridBase) this.uddCDL).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.uddCDL).DisplayLayout.CaptionVisible = (DefaultableBoolean) 2;
    appearance128.BackColor = SystemColors.ActiveBorder;
    appearance128.BackColor2 = SystemColors.ControlDark;
    appearance128.BackGradientStyle = (GradientStyle) 2;
    appearance128.BorderColor = SystemColors.Window;
    ((SpecialBoxBase) ((UltraGridBase) this.uddCDL).DisplayLayout.GroupByBox).Appearance = (AppearanceBase) appearance128;
    appearance129.BackColor = Color.FromArgb(240 /*0xF0*/, 246, 254);
    appearance129.BorderColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    appearance129.ForeColor = SystemColors.GrayText;
    ((UltraGridBase) this.uddCDL).DisplayLayout.GroupByBox.BandLabelAppearance = (AppearanceBase) appearance129;
    ((SpecialBoxBase) ((UltraGridBase) this.uddCDL).DisplayLayout.GroupByBox).BorderStyle = (UIElementBorderStyle) 4;
    appearance130.BackColor = SystemColors.ControlLightLight;
    appearance130.BackColor2 = SystemColors.Control;
    appearance130.BackGradientStyle = (GradientStyle) 3;
    appearance130.BorderColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    appearance130.ForeColor = SystemColors.GrayText;
    ((UltraGridBase) this.uddCDL).DisplayLayout.GroupByBox.PromptAppearance = (AppearanceBase) appearance130;
    ((UltraGridBase) this.uddCDL).DisplayLayout.MaxColScrollRegions = 1;
    ((UltraGridBase) this.uddCDL).DisplayLayout.MaxRowScrollRegions = 1;
    appearance131.BackColor = SystemColors.Window;
    appearance131.BorderColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    appearance131.ForeColor = SystemColors.ControlText;
    ((UltraGridBase) this.uddCDL).DisplayLayout.Override.ActiveCellAppearance = (AppearanceBase) appearance131;
    appearance132.BackColor = SystemColors.Highlight;
    appearance132.BorderColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    appearance132.ForeColor = SystemColors.HighlightText;
    ((UltraGridBase) this.uddCDL).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance132;
    ((UltraGridBase) this.uddCDL).DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 2;
    ((UltraGridBase) this.uddCDL).DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 2;
    appearance133.BackColor = SystemColors.Window;
    appearance133.BorderColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    ((UltraGridBase) this.uddCDL).DisplayLayout.Override.CardAreaAppearance = (AppearanceBase) appearance133;
    appearance134.BackColor = Color.FromArgb(240 /*0xF0*/, 246, 254);
    appearance134.BorderColor = Color.Silver;
    appearance134.TextTrimming = (TextTrimming) 3;
    ((UltraGridBase) this.uddCDL).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance134;
    ((UltraGridBase) this.uddCDL).DisplayLayout.Override.CellClickAction = (CellClickAction) 4;
    ((UltraGridBase) this.uddCDL).DisplayLayout.Override.CellPadding = 0;
    appearance135.BackColor = SystemColors.Control;
    appearance135.BackColor2 = SystemColors.ControlDark;
    appearance135.BackGradientAlignment = (GradientAlignment) 1;
    appearance135.BackGradientStyle = (GradientStyle) 3;
    appearance135.BorderColor = SystemColors.Window;
    ((UltraGridBase) this.uddCDL).DisplayLayout.Override.GroupByRowAppearance = (AppearanceBase) appearance135;
    appearance136.BackColor = Color.FromArgb(240 /*0xF0*/, 246, 254);
    appearance136.BorderColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    ((AppearanceBase) appearance136).TextHAlignAsString = "Left";
    ((UltraGridBase) this.uddCDL).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance136;
    ((UltraGridBase) this.uddCDL).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 3;
    ((UltraGridBase) this.uddCDL).DisplayLayout.Override.HeaderStyle = (HeaderStyle) 2;
    appearance137.BackColor = SystemColors.Window;
    appearance137.BorderColor = Color.Silver;
    ((UltraGridBase) this.uddCDL).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance137;
    ((UltraGridBase) this.uddCDL).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance138.BackColor = SystemColors.ControlLight;
    appearance138.BorderColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    ((UltraGridBase) this.uddCDL).DisplayLayout.Override.TemplateAddRowAppearance = (AppearanceBase) appearance138;
    ((UltraGridBase) this.uddCDL).DisplayLayout.ScrollBounds = (ScrollBounds) 0;
    ((UltraGridBase) this.uddCDL).DisplayLayout.ScrollStyle = (ScrollStyle) 1;
    ((UltraGridBase) this.uddCDL).DisplayLayout.ViewStyleBand = (ViewStyleBand) 2;
    ((UltraDropDownBase) this.uddCDL).DisplayMember = "CDL";
    ((Control) this.uddCDL).Location = new Point(26, 161);
    ((Control) this.uddCDL).Name = "uddCDL";
    ((Control) this.uddCDL).Size = new Size(96 /*0x60*/, 32 /*0x20*/);
    ((Control) this.uddCDL).TabIndex = 294;
    ((UltraDropDownBase) this.uddCDL).ValueMember = "ID";
    ((Control) this.uddCDL).Visible = false;
    ((UltraGridBase) this.uddState).DataMember = "lstStates";
    ((UltraGridBase) this.uddState).DataSource = (object) this.ds;
    appearance139.BackColor = SystemColors.Window;
    appearance139.BorderColor = SystemColors.InactiveCaption;
    ((UltraGridBase) this.uddState).DisplayLayout.Appearance = (AppearanceBase) appearance139;
    ((HeaderBase) ultraGridColumn14.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn14.Header.VisiblePosition = 0;
    ((HeaderBase) ultraGridColumn15.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn15.Header.VisiblePosition = 1;
    ultraGridBand7.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn14,
      (object) ultraGridColumn15
    });
    ((UltraGridBase) this.uddState).DisplayLayout.BandsSerializer.Add((object) ultraGridBand7);
    ((UltraGridBase) this.uddState).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.uddState).DisplayLayout.CaptionVisible = (DefaultableBoolean) 2;
    appearance140.BackColor = SystemColors.ActiveBorder;
    appearance140.BackColor2 = SystemColors.ControlDark;
    appearance140.BackGradientStyle = (GradientStyle) 2;
    appearance140.BorderColor = SystemColors.Window;
    ((SpecialBoxBase) ((UltraGridBase) this.uddState).DisplayLayout.GroupByBox).Appearance = (AppearanceBase) appearance140;
    appearance141.BackColor = Color.FromArgb(240 /*0xF0*/, 246, 254);
    appearance141.BorderColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    appearance141.ForeColor = SystemColors.GrayText;
    ((UltraGridBase) this.uddState).DisplayLayout.GroupByBox.BandLabelAppearance = (AppearanceBase) appearance141;
    ((SpecialBoxBase) ((UltraGridBase) this.uddState).DisplayLayout.GroupByBox).BorderStyle = (UIElementBorderStyle) 4;
    appearance142.BackColor = SystemColors.ControlLightLight;
    appearance142.BackColor2 = SystemColors.Control;
    appearance142.BackGradientStyle = (GradientStyle) 3;
    appearance142.BorderColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    appearance142.ForeColor = SystemColors.GrayText;
    ((UltraGridBase) this.uddState).DisplayLayout.GroupByBox.PromptAppearance = (AppearanceBase) appearance142;
    ((UltraGridBase) this.uddState).DisplayLayout.MaxColScrollRegions = 1;
    ((UltraGridBase) this.uddState).DisplayLayout.MaxRowScrollRegions = 1;
    appearance143.BackColor = SystemColors.Window;
    appearance143.BorderColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    appearance143.ForeColor = SystemColors.ControlText;
    ((UltraGridBase) this.uddState).DisplayLayout.Override.ActiveCellAppearance = (AppearanceBase) appearance143;
    appearance144.BackColor = SystemColors.Highlight;
    appearance144.BorderColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    appearance144.ForeColor = SystemColors.HighlightText;
    ((UltraGridBase) this.uddState).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance144;
    ((UltraGridBase) this.uddState).DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 2;
    ((UltraGridBase) this.uddState).DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 2;
    appearance145.BackColor = SystemColors.Window;
    appearance145.BorderColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    ((UltraGridBase) this.uddState).DisplayLayout.Override.CardAreaAppearance = (AppearanceBase) appearance145;
    appearance146.BackColor = Color.FromArgb(240 /*0xF0*/, 246, 254);
    appearance146.BorderColor = Color.Silver;
    appearance146.TextTrimming = (TextTrimming) 3;
    ((UltraGridBase) this.uddState).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance146;
    ((UltraGridBase) this.uddState).DisplayLayout.Override.CellClickAction = (CellClickAction) 4;
    ((UltraGridBase) this.uddState).DisplayLayout.Override.CellPadding = 0;
    appearance147.BackColor = SystemColors.Control;
    appearance147.BackColor2 = SystemColors.ControlDark;
    appearance147.BackGradientAlignment = (GradientAlignment) 1;
    appearance147.BackGradientStyle = (GradientStyle) 3;
    appearance147.BorderColor = SystemColors.Window;
    ((UltraGridBase) this.uddState).DisplayLayout.Override.GroupByRowAppearance = (AppearanceBase) appearance147;
    appearance148.BackColor = Color.FromArgb(240 /*0xF0*/, 246, 254);
    appearance148.BorderColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    ((AppearanceBase) appearance148).TextHAlignAsString = "Left";
    ((UltraGridBase) this.uddState).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance148;
    ((UltraGridBase) this.uddState).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 3;
    ((UltraGridBase) this.uddState).DisplayLayout.Override.HeaderStyle = (HeaderStyle) 2;
    appearance149.BackColor = SystemColors.Window;
    appearance149.BorderColor = Color.Silver;
    ((UltraGridBase) this.uddState).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance149;
    ((UltraGridBase) this.uddState).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance150.BackColor = SystemColors.ControlLight;
    appearance150.BorderColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    ((UltraGridBase) this.uddState).DisplayLayout.Override.TemplateAddRowAppearance = (AppearanceBase) appearance150;
    ((UltraGridBase) this.uddState).DisplayLayout.ScrollBounds = (ScrollBounds) 0;
    ((UltraGridBase) this.uddState).DisplayLayout.ScrollStyle = (ScrollStyle) 1;
    ((UltraGridBase) this.uddState).DisplayLayout.ViewStyleBand = (ViewStyleBand) 2;
    ((UltraDropDownBase) this.uddState).DisplayMember = "State";
    ((Control) this.uddState).Location = new Point(26, 123);
    ((Control) this.uddState).Name = "uddState";
    ((Control) this.uddState).Size = new Size(96 /*0x60*/, 32 /*0x20*/);
    ((Control) this.uddState).TabIndex = 4;
    ((UltraDropDownBase) this.uddState).ValueMember = "StateID";
    ((Control) this.uddState).Visible = false;
    ((UltraGridBase) this.uddDriverStatus).DataMember = "lstDriverStatus";
    ((UltraGridBase) this.uddDriverStatus).DataSource = (object) this.ds;
    appearance151.BackColor = SystemColors.Window;
    appearance151.BorderColor = SystemColors.InactiveCaption;
    ((UltraGridBase) this.uddDriverStatus).DisplayLayout.Appearance = (AppearanceBase) appearance151;
    ((HeaderBase) ultraGridColumn16.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn16.Header.VisiblePosition = 0;
    ((HeaderBase) ultraGridColumn17.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn17.Header.VisiblePosition = 1;
    ((HeaderBase) ultraGridColumn18.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn18.Header.VisiblePosition = 2;
    ultraGridBand8.Columns.AddRange(new object[3]
    {
      (object) ultraGridColumn16,
      (object) ultraGridColumn17,
      (object) ultraGridColumn18
    });
    ((UltraGridBase) this.uddDriverStatus).DisplayLayout.BandsSerializer.Add((object) ultraGridBand8);
    ((UltraGridBase) this.uddDriverStatus).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.uddDriverStatus).DisplayLayout.CaptionVisible = (DefaultableBoolean) 2;
    appearance152.BackColor = SystemColors.ActiveBorder;
    appearance152.BackColor2 = SystemColors.ControlDark;
    appearance152.BackGradientStyle = (GradientStyle) 2;
    appearance152.BorderColor = SystemColors.Window;
    ((SpecialBoxBase) ((UltraGridBase) this.uddDriverStatus).DisplayLayout.GroupByBox).Appearance = (AppearanceBase) appearance152;
    appearance153.BackColor = Color.FromArgb(240 /*0xF0*/, 246, 254);
    appearance153.BorderColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    appearance153.ForeColor = SystemColors.GrayText;
    ((UltraGridBase) this.uddDriverStatus).DisplayLayout.GroupByBox.BandLabelAppearance = (AppearanceBase) appearance153;
    ((SpecialBoxBase) ((UltraGridBase) this.uddDriverStatus).DisplayLayout.GroupByBox).BorderStyle = (UIElementBorderStyle) 4;
    appearance154.BackColor = SystemColors.ControlLightLight;
    appearance154.BackColor2 = SystemColors.Control;
    appearance154.BackGradientStyle = (GradientStyle) 3;
    appearance154.BorderColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    appearance154.ForeColor = SystemColors.GrayText;
    ((UltraGridBase) this.uddDriverStatus).DisplayLayout.GroupByBox.PromptAppearance = (AppearanceBase) appearance154;
    ((UltraGridBase) this.uddDriverStatus).DisplayLayout.MaxColScrollRegions = 1;
    ((UltraGridBase) this.uddDriverStatus).DisplayLayout.MaxRowScrollRegions = 1;
    appearance155.BackColor = SystemColors.Window;
    appearance155.BorderColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    appearance155.ForeColor = SystemColors.ControlText;
    ((UltraGridBase) this.uddDriverStatus).DisplayLayout.Override.ActiveCellAppearance = (AppearanceBase) appearance155;
    appearance156.BackColor = SystemColors.Highlight;
    appearance156.BorderColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    appearance156.ForeColor = SystemColors.HighlightText;
    ((UltraGridBase) this.uddDriverStatus).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance156;
    ((UltraGridBase) this.uddDriverStatus).DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 2;
    ((UltraGridBase) this.uddDriverStatus).DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 2;
    appearance157.BackColor = SystemColors.Window;
    appearance157.BorderColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    ((UltraGridBase) this.uddDriverStatus).DisplayLayout.Override.CardAreaAppearance = (AppearanceBase) appearance157;
    appearance158.BackColor = Color.FromArgb(240 /*0xF0*/, 246, 254);
    appearance158.BorderColor = Color.Silver;
    appearance158.TextTrimming = (TextTrimming) 3;
    ((UltraGridBase) this.uddDriverStatus).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance158;
    ((UltraGridBase) this.uddDriverStatus).DisplayLayout.Override.CellClickAction = (CellClickAction) 4;
    ((UltraGridBase) this.uddDriverStatus).DisplayLayout.Override.CellPadding = 0;
    appearance159.BackColor = SystemColors.Control;
    appearance159.BackColor2 = SystemColors.ControlDark;
    appearance159.BackGradientAlignment = (GradientAlignment) 1;
    appearance159.BackGradientStyle = (GradientStyle) 3;
    appearance159.BorderColor = SystemColors.Window;
    ((UltraGridBase) this.uddDriverStatus).DisplayLayout.Override.GroupByRowAppearance = (AppearanceBase) appearance159;
    appearance160.BackColor = Color.FromArgb(240 /*0xF0*/, 246, 254);
    appearance160.BorderColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    ((AppearanceBase) appearance160).TextHAlignAsString = "Left";
    ((UltraGridBase) this.uddDriverStatus).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance160;
    ((UltraGridBase) this.uddDriverStatus).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 3;
    ((UltraGridBase) this.uddDriverStatus).DisplayLayout.Override.HeaderStyle = (HeaderStyle) 2;
    appearance161.BackColor = SystemColors.Window;
    appearance161.BorderColor = Color.Silver;
    ((UltraGridBase) this.uddDriverStatus).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance161;
    ((UltraGridBase) this.uddDriverStatus).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance162.BackColor = SystemColors.ControlLight;
    appearance162.BorderColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    ((UltraGridBase) this.uddDriverStatus).DisplayLayout.Override.TemplateAddRowAppearance = (AppearanceBase) appearance162;
    ((UltraGridBase) this.uddDriverStatus).DisplayLayout.ScrollBounds = (ScrollBounds) 0;
    ((UltraGridBase) this.uddDriverStatus).DisplayLayout.ScrollStyle = (ScrollStyle) 1;
    ((UltraGridBase) this.uddDriverStatus).DisplayLayout.ViewStyleBand = (ViewStyleBand) 2;
    ((UltraDropDownBase) this.uddDriverStatus).DisplayMember = "Status";
    ((Control) this.uddDriverStatus).Location = new Point(26, 95);
    ((Control) this.uddDriverStatus).Name = "uddDriverStatus";
    ((Control) this.uddDriverStatus).Size = new Size(96 /*0x60*/, 32 /*0x20*/);
    ((Control) this.uddDriverStatus).TabIndex = 3;
    ((UltraDropDownBase) this.uddDriverStatus).ValueMember = "DriverStatusID";
    ((Control) this.uddDriverStatus).Visible = false;
    ((Control) this.ugDrivers).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraGridBase) this.ugDrivers).DataMember = "tblDriverInfo";
    ((UltraGridBase) this.ugDrivers).DataSource = (object) this.ds;
    appearance163.BackColor = Color.White;
    appearance163.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.ugDrivers).DisplayLayout.Appearance = (AppearanceBase) appearance163;
    ((UltraGridBase) this.ugDrivers).DisplayLayout.AutoFitStyle = (AutoFitStyle) 2;
    ultraGridColumn19.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn19.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn19.Header.VisiblePosition = 0;
    ultraGridColumn19.Hidden = true;
    ultraGridColumn20.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn20.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn20.Header.VisiblePosition = 1;
    ultraGridColumn20.Hidden = true;
    ultraGridColumn21.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn21.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn21.Header.VisiblePosition = 2;
    ultraGridColumn21.Hidden = true;
    ultraGridColumn22.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn22.Header).Caption = "First Name";
    ((HeaderBase) ultraGridColumn22.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn22.Header.VisiblePosition = 7;
    ultraGridColumn22.Width = 118;
    ultraGridColumn23.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn23.Header).Caption = "Last Name";
    ((HeaderBase) ultraGridColumn23.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn23.Header.VisiblePosition = 8;
    ultraGridColumn23.Width = 112 /*0x70*/;
    ultraGridColumn24.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn24.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn24.Header.VisiblePosition = 9;
    ultraGridColumn24.Width = 65;
    ultraGridColumn25.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn25.Header).Caption = "License #";
    ((HeaderBase) ultraGridColumn25.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn25.Header.VisiblePosition = 10;
    ultraGridColumn25.Width = 93;
    ultraGridColumn26.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn26.Header).Caption = "State";
    ((HeaderBase) ultraGridColumn26.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn26.Header.VisiblePosition = 11;
    ultraGridColumn26.Style = (ColumnStyle) 6;
    ultraGridColumn26.Width = 65;
    ultraGridColumn27.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn27.Header).Caption = "Status";
    ((HeaderBase) ultraGridColumn27.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn27.Header.VisiblePosition = 12;
    ultraGridColumn27.Style = (ColumnStyle) 6;
    ultraGridColumn28.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn28.Header).Caption = "Added";
    ((HeaderBase) ultraGridColumn28.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn28.Header.VisiblePosition = 13;
    ultraGridColumn28.Width = 66;
    ultraGridColumn29.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn29.Header).Caption = "Deleted";
    ((HeaderBase) ultraGridColumn29.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn29.Header.VisiblePosition = 18;
    ultraGridColumn30.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn30.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn30.Header.VisiblePosition = 17;
    ultraGridColumn31.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn31.Header).Caption = "# Points";
    ((HeaderBase) ultraGridColumn31.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn31.Header.VisiblePosition = 14;
    ultraGridColumn31.Width = 66;
    ultraGridColumn32.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn32.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn32.Header.VisiblePosition = 19;
    ultraGridColumn33.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn33.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn33.Header.VisiblePosition = 20;
    ultraGridColumn34.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn34.Header).Caption = "Full Part Time";
    ((HeaderBase) ultraGridColumn34.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn34.Header.VisiblePosition = 21;
    ultraGridColumn35.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn35.Header).Caption = "Copy On Renewal";
    ((HeaderBase) ultraGridColumn35.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn35.Header.VisiblePosition = 16 /*0x10*/;
    ultraGridColumn36.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn36.Header).Caption = "Modified";
    ((HeaderBase) ultraGridColumn36.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn36.Header.VisiblePosition = 22;
    ultraGridColumn37.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn37.Header).Caption = "License Exp Date";
    ((HeaderBase) ultraGridColumn37.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn37.Header.VisiblePosition = 23;
    ultraGridColumn38.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn38.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn38.Header.VisiblePosition = 24;
    ultraGridColumn39.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn39.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn39.Header.VisiblePosition = 25;
    ultraGridColumn40.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn40.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn40.Header.VisiblePosition = 26;
    ultraGridColumn41.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn41.Header).Caption = "Zip";
    ((HeaderBase) ultraGridColumn41.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn41.Header.VisiblePosition = 27;
    ultraGridColumn42.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn42.Header).Caption = "Zip Plus";
    ((HeaderBase) ultraGridColumn42.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn42.Header.VisiblePosition = 28;
    ultraGridColumn43.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn43.Header).Caption = "Rating Factor";
    ((HeaderBase) ultraGridColumn43.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn43.Header.VisiblePosition = 29;
    ultraGridColumn44.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn44.Header).Caption = "License Class";
    ((HeaderBase) ultraGridColumn44.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn44.Header.VisiblePosition = 30;
    ((HeaderBase) ultraGridColumn45.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn45.Header.VisiblePosition = 4;
    ((HeaderBase) ultraGridColumn46.Header).Caption = "# At Fault Acc";
    ((HeaderBase) ultraGridColumn46.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn46.Header.VisiblePosition = 31 /*0x1F*/;
    ((HeaderBase) ultraGridColumn47.Header).Caption = "# Other Acc";
    ((HeaderBase) ultraGridColumn47.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn47.Header.VisiblePosition = 32 /*0x20*/;
    ((HeaderBase) ultraGridColumn48.Header).Caption = "Speeding < 10 MPH";
    ((HeaderBase) ultraGridColumn48.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn48.Header.VisiblePosition = 33;
    ((HeaderBase) ultraGridColumn49.Header).Caption = "Speeding > 10 MPH";
    ((HeaderBase) ultraGridColumn49.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn49.Header.VisiblePosition = 34;
    ((HeaderBase) ultraGridColumn50.Header).Caption = "Sec. Violations";
    ((HeaderBase) ultraGridColumn50.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn50.Header.VisiblePosition = 35;
    ((HeaderBase) ultraGridColumn51.Header).Caption = "Equip. Violations";
    ((HeaderBase) ultraGridColumn51.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn51.Header.VisiblePosition = 36;
    ((HeaderBase) ultraGridColumn52.Header).Caption = "Other Moving Violations";
    ((HeaderBase) ultraGridColumn52.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn52.Header.VisiblePosition = 37;
    ((HeaderBase) ultraGridColumn53.Header).Caption = "Total Violations";
    ((HeaderBase) ultraGridColumn53.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn53.Header.VisiblePosition = 38;
    ((HeaderBase) ultraGridColumn54.Header).Caption = "Medical Exp";
    ((HeaderBase) ultraGridColumn54.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn54.Header.VisiblePosition = 39;
    ((HeaderBase) ultraGridColumn55.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn55.Header.VisiblePosition = 40;
    ultraGridColumn55.Hidden = true;
    ((HeaderBase) ultraGridColumn56.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn56.Header.VisiblePosition = 41;
    ultraGridColumn56.Hidden = true;
    ((HeaderBase) ultraGridColumn57.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn57.Header.VisiblePosition = 42;
    ultraGridColumn57.Hidden = true;
    ((HeaderBase) ultraGridColumn58.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn58.Header.VisiblePosition = 43;
    ultraGridColumn58.Hidden = true;
    ((HeaderBase) ultraGridColumn59.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn59.Header.VisiblePosition = 44;
    ((HeaderBase) ultraGridColumn60.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn60.Header.VisiblePosition = 45;
    ((HeaderBase) ultraGridColumn61.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn61.Header.VisiblePosition = 46;
    ((HeaderBase) ultraGridColumn62.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn62.Header.VisiblePosition = 47;
    ((HeaderBase) ultraGridColumn63.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn63.Header.VisiblePosition = 48 /*0x30*/;
    ultraGridColumn64.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn64.Header).Caption = "CDL Driver";
    ((HeaderBase) ultraGridColumn64.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn64.Header.VisiblePosition = 15;
    ultraGridColumn64.Style = (ColumnStyle) 6;
    ((HeaderBase) ultraGridColumn65.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn65.Header.VisiblePosition = 49;
    ((HeaderBase) ultraGridColumn66.Header).Caption = "Generate Doc";
    ((HeaderBase) ultraGridColumn66.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn66.Header.VisiblePosition = 5;
    ((HeaderBase) ultraGridColumn67.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn67.Header.VisiblePosition = 50;
    ((HeaderBase) ultraGridColumn68.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn68.Header.VisiblePosition = 51;
    ((HeaderBase) ultraGridColumn69.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn69.Header.VisiblePosition = 52;
    ultraGridColumn69.Hidden = true;
    ((HeaderBase) ultraGridColumn70.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn70.Header.VisiblePosition = 53;
    ultraGridColumn70.Hidden = true;
    ((HeaderBase) ultraGridColumn71.Header).Caption = "Delete";
    ((HeaderBase) ultraGridColumn71.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn71.Header.VisiblePosition = 6;
    ((HeaderBase) ultraGridColumn72.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn72.Header.VisiblePosition = 3;
    ultraGridColumn72.Hidden = true;
    ultraGridBand9.Columns.AddRange(new object[54]
    {
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
      (object) ultraGridColumn40,
      (object) ultraGridColumn41,
      (object) ultraGridColumn42,
      (object) ultraGridColumn43,
      (object) ultraGridColumn44,
      (object) ultraGridColumn45,
      (object) ultraGridColumn46,
      (object) ultraGridColumn47,
      (object) ultraGridColumn48,
      (object) ultraGridColumn49,
      (object) ultraGridColumn50,
      (object) ultraGridColumn51,
      (object) ultraGridColumn52,
      (object) ultraGridColumn53,
      (object) ultraGridColumn54,
      (object) ultraGridColumn55,
      (object) ultraGridColumn56,
      (object) ultraGridColumn57,
      (object) ultraGridColumn58,
      (object) ultraGridColumn59,
      (object) ultraGridColumn60,
      (object) ultraGridColumn61,
      (object) ultraGridColumn62,
      (object) ultraGridColumn63,
      (object) ultraGridColumn64,
      (object) ultraGridColumn65,
      (object) ultraGridColumn66,
      (object) ultraGridColumn67,
      (object) ultraGridColumn68,
      (object) ultraGridColumn69,
      (object) ultraGridColumn70,
      (object) ultraGridColumn71,
      (object) ultraGridColumn72
    });
    ((UltraGridBase) this.ugDrivers).DisplayLayout.BandsSerializer.Add((object) ultraGridBand9);
    ((UltraGridBase) this.ugDrivers).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance164.BackColor = Color.LightSteelBlue;
    appearance164.FontData.SizeInPoints = 10f;
    appearance164.ForeColor = Color.Black;
    ((UltraGridBase) this.ugDrivers).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance164;
    appearance165.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance165.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance165.ForeColor = Color.Black;
    ((UltraGridBase) this.ugDrivers).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance165;
    ((UltraGridBase) this.ugDrivers).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.ugDrivers).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.ugDrivers).DisplayLayout.Override.AllowRowFiltering = (DefaultableBoolean) 1;
    appearance166.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugDrivers).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance166;
    appearance167.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.ugDrivers).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance167;
    ((UltraGridBase) this.ugDrivers).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 2;
    ((UltraGridBase) this.ugDrivers).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance168.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.ugDrivers).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance168;
    appearance169.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugDrivers).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance169;
    ((UltraGridBase) this.ugDrivers).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance170.BackColor = Color.Transparent;
    appearance170.ForeColor = Color.Black;
    ((UltraGridBase) this.ugDrivers).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance170;
    appearance171.BackColor = Color.WhiteSmoke;
    appearance171.BorderColor = Color.Silver;
    scrollBarLook6.ButtonAppearance = (AppearanceBase) appearance171;
    appearance172.BackColor = Color.White;
    scrollBarLook6.TrackAppearance = (AppearanceBase) appearance172;
    ((UltraGridBase) this.ugDrivers).DisplayLayout.ScrollBarLook = scrollBarLook6;
    ((UltraGridBase) this.ugDrivers).DisplayLayout.ViewStyle = (ViewStyle) 0;
    ((Control) this.ugDrivers).Location = new Point(4, 8);
    ((Control) this.ugDrivers).Name = "ugDrivers";
    ((Control) this.ugDrivers).Size = new Size(1013, 201);
    ((Control) this.ugDrivers).TabIndex = 1;
    ((UltraControlBase) this.ugDrivers).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.ugDrivers).UseOsThemes = (DefaultableBoolean) 2;
    this.lnkSambaOffice.AutoSize = true;
    this.lnkSambaOffice.Location = new Point(798, 455);
    this.lnkSambaOffice.Name = "lnkSambaOffice";
    this.lnkSambaOffice.Size = new Size(72, 13);
    this.lnkSambaOffice.TabIndex = 301;
    this.lnkSambaOffice.TabStop = true;
    this.lnkSambaOffice.Text = "Office Access";
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    this.ClientSize = new Size(1021, 501);
    this.Controls.Add((Control) this.lnkSambaOffice);
    this.Controls.Add((Control) this.UltraTextEditor1);
    this.Controls.Add((Control) this.btnIIX);
    this.Controls.Add((Control) this.btnProcessOvernightOrders);
    this.Controls.Add((Control) this.cboTemplates);
    this.Controls.Add((Control) this.Label37);
    this.Controls.Add((Control) this.lnkGenerateDocument);
    this.Controls.Add((Control) this.uddCDL);
    this.Controls.Add((Control) this.btnQuery);
    this.Controls.Add((Control) this.lnkOvernightOrders);
    this.Controls.Add((Control) this.tabDriverTab);
    this.Controls.Add((Control) this.lnkPasswordUpdate);
    this.Controls.Add((Control) this.panelProcessingADR);
    this.Controls.Add((Control) this.lnkDeSelectAll);
    this.Controls.Add((Control) this.lnkSelectAll);
    this.Controls.Add((Control) this.lnkADRConnect);
    this.Controls.Add((Control) this.lnkPrintDrivers);
    this.Controls.Add((Control) this.lnkCopyFromAnotherQuote);
    this.Controls.Add((Control) this.lnkCopyFromExpiringQuote);
    this.Controls.Add((Control) this.lnkDeletedRecords);
    this.Controls.Add((Control) this.uddState);
    this.Controls.Add((Control) this.uddDriverStatus);
    this.Controls.Add((Control) this.ugDrivers);
    this.Controls.Add((Control) this.dbSave);
    this.Font = new Font("Tahoma", 8f);
    this.ForeColor = Color.Black;
    this.MinimumSize = new Size(1037, 540);
    this.Name = nameof (FormDriversInfo);
    this.Text = "Driver Info";
    ((Control) this.tabDriverInfo).ResumeLayout(false);
    ((Control) this.tabDriverInfo).PerformLayout();
    ((ISupportInitialize) this.cboCDLDriver).EndInit();
    this.ds.EndInit();
    ((ISupportInitialize) this.dtMVRDate).EndInit();
    ((ISupportInitialize) this.dtMedicalExpiration).EndInit();
    ((ISupportInitialize) this.chkFurnishedCar).EndInit();
    ((ISupportInitialize) this.MgaTextBox1).EndInit();
    ((ISupportInitialize) this.numDriverRatingFactor).EndInit();
    ((ISupportInitialize) this.txtZipPlus).EndInit();
    ((ISupportInitialize) this.txtZipCode).EndInit();
    ((ISupportInitialize) this.txtCity).EndInit();
    ((ISupportInitialize) this.txtStreet2).EndInit();
    ((ISupportInitialize) this.txtStreet1).EndInit();
    ((ISupportInitialize) this.dtLicenseExpDate).EndInit();
    ((ISupportInitialize) this.MgaCheckBox1).EndInit();
    ((ISupportInitialize) this.cboFullorPartTime).EndInit();
    ((ISupportInitialize) this.txtNumPoints).EndInit();
    ((ISupportInitialize) this.txtComments).EndInit();
    ((ISupportInitialize) this.dtpDriverAdded).EndInit();
    ((ISupportInitialize) this.dtpDriverDeleted).EndInit();
    ((ISupportInitialize) this.comboDriverStatus).EndInit();
    ((ISupportInitialize) this.comboState).EndInit();
    ((ISupportInitialize) this.txtLicenseNumber).EndInit();
    ((ISupportInitialize) this.dtPDateOfBirth).EndInit();
    ((ISupportInitialize) this.txtLastName).EndInit();
    ((ISupportInitialize) this.txtFirstName).EndInit();
    ((Control) this.tabAddlDriverInfo).ResumeLayout(false);
    ((Control) this.tabAddlDriverInfo).PerformLayout();
    ((ISupportInitialize) this.txtErrorDescription).EndInit();
    ((ISupportInitialize) this.txtCompanyClass).EndInit();
    ((ISupportInitialize) this.txtInvoicePath).EndInit();
    ((ISupportInitialize) this.txtMatchError).EndInit();
    ((ISupportInitialize) this.txtDocumentValidationResult).EndInit();
    ((ISupportInitialize) this.MgaTextBox13).EndInit();
    ((ISupportInitialize) this.chkHasDOC).EndInit();
    ((ISupportInitialize) this.dtpDriverExcluded).EndInit();
    ((ISupportInitialize) this.numYearsLogTruckExperienceNum).EndInit();
    ((ISupportInitialize) this.dtpDateOfOrigCDL).EndInit();
    ((ISupportInitialize) this.dtpDateOfHire).EndInit();
    this.GroupBox1.ResumeLayout(false);
    this.GroupBox1.PerformLayout();
    ((ISupportInitialize) this.txtDLStatus).EndInit();
    ((ISupportInitialize) this.txtValid).EndInit();
    ((ISupportInitialize) this.txtIsClear).EndInit();
    ((ISupportInitialize) this.MgaTextBox9).EndInit();
    ((ISupportInitialize) this.MgaTextBox8).EndInit();
    ((ISupportInitialize) this.MgaTextBox7).EndInit();
    ((ISupportInitialize) this.MgaTextBox6).EndInit();
    ((ISupportInitialize) this.MgaTextBox2).EndInit();
    ((ISupportInitialize) this.MgaTextBox5).EndInit();
    ((ISupportInitialize) this.MgaTextBox4).EndInit();
    ((ISupportInitialize) this.MgaTextBox3).EndInit();
    ((Control) this.tabNotes).ResumeLayout(false);
    ((Control) this.tabNotes).PerformLayout();
    ((ISupportInitialize) this.btnCopyOnRenewal).EndInit();
    ((ISupportInitialize) this.btnBulkDelete).EndInit();
    this.GroupBox2.ResumeLayout(false);
    this.GroupBox2.PerformLayout();
    ((ISupportInitialize) this.chkPopup).EndInit();
    ((ISupportInitialize) this.MgaTextBox12).EndInit();
    ((ISupportInitialize) this.MgaTextBox11).EndInit();
    ((ISupportInitialize) this.MgaComboBox1).EndInit();
    ((ISupportInitialize) this.MgaTextBox10).EndInit();
    ((ISupportInitialize) this.err).EndInit();
    ((ISupportInitialize) this.panelProcessingADR).EndInit();
    ((Control) this.panelProcessingADR).ResumeLayout(false);
    ((Control) this.panelProcessingADR).PerformLayout();
    ((ISupportInitialize) this.spinner).EndInit();
    ((ISupportInitialize) this.tabDriverTab).EndInit();
    ((Control) this.tabDriverTab).ResumeLayout(false);
    ((ISupportInitialize) this.UltraTextEditor1).EndInit();
    ((ISupportInitialize) this.btnIIX).EndInit();
    ((ISupportInitialize) this.cboTemplates).EndInit();
    ((ISupportInitialize) this.btnQuery).EndInit();
    ((ISupportInitialize) this.uddCDL).EndInit();
    ((ISupportInitialize) this.uddState).EndInit();
    ((ISupportInitialize) this.uddDriverStatus).EndInit();
    ((ISupportInitialize) this.ugDrivers).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  [field: AccessedThroughProperty("err")]
  protected virtual ErrorProvider err { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected virtual MGASystems.Tools.DBSaveUI.DBSaveUI dbSave
  {
    get => this._dbSave;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler1 = new EventHandler(this.dbSave_ClickedCancel);
      EventHandler eventHandler2 = new EventHandler(this.dbSave_ClickedDelete);
      EventHandler eventHandler3 = new EventHandler(this.dbSave_ClickedNew);
      EventHandler eventHandler4 = new EventHandler(this.dbSave_ClickedSave);
      CancelEventHandler cancelEventHandler1 = new CancelEventHandler(this.dbSave_ClickingDelete);
      CancelEventHandler cancelEventHandler2 = new CancelEventHandler(this.dbSave_ClickingEdit);
      CancelEventHandler cancelEventHandler3 = new CancelEventHandler(this.dbSave_ClickingNew);
      CancelEventHandler cancelEventHandler4 = new CancelEventHandler(this.dbSave_ClickingSave);
      EventHandler eventHandler5 = new EventHandler(this.dbSave_UIStateChanged);
      MGASystems.Tools.DBSaveUI.DBSaveUI dbSave1 = this._dbSave;
      if (dbSave1 != null)
      {
        dbSave1.ClickedCancel -= eventHandler1;
        dbSave1.ClickedDelete -= eventHandler2;
        dbSave1.ClickedNew -= eventHandler3;
        dbSave1.ClickedSave -= eventHandler4;
        dbSave1.ClickingDelete -= cancelEventHandler1;
        dbSave1.ClickingEdit -= cancelEventHandler2;
        dbSave1.ClickingNew -= cancelEventHandler3;
        dbSave1.ClickingSave -= cancelEventHandler4;
        dbSave1.UIStateChanged -= eventHandler5;
      }
      this._dbSave = value;
      MGASystems.Tools.DBSaveUI.DBSaveUI dbSave2 = this._dbSave;
      if (dbSave2 == null)
        return;
      dbSave2.ClickedCancel += eventHandler1;
      dbSave2.ClickedDelete += eventHandler2;
      dbSave2.ClickedNew += eventHandler3;
      dbSave2.ClickedSave += eventHandler4;
      dbSave2.ClickingDelete += cancelEventHandler1;
      dbSave2.ClickingEdit += cancelEventHandler2;
      dbSave2.ClickingNew += cancelEventHandler3;
      dbSave2.ClickingSave += cancelEventHandler4;
      dbSave2.UIStateChanged += eventHandler5;
    }
  }

  protected virtual UltraGrid ugDrivers
  {
    get => this._ugDrivers;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ugDrivers_AfterRowActivate);
      InitializeRowEventHandler initializeRowEventHandler = new InitializeRowEventHandler(this.ugDrivers_InitializeRow);
      InitializeLayoutEventHandler layoutEventHandler = new InitializeLayoutEventHandler(this.ugDrivers_InitializeLayout);
      UltraGrid ugDrivers1 = this._ugDrivers;
      if (ugDrivers1 != null)
      {
        ugDrivers1.AfterRowActivate -= eventHandler;
        ugDrivers1.InitializeRow -= initializeRowEventHandler;
        ugDrivers1.InitializeLayout -= layoutEventHandler;
      }
      this._ugDrivers = value;
      UltraGrid ugDrivers2 = this._ugDrivers;
      if (ugDrivers2 == null)
        return;
      ugDrivers2.AfterRowActivate += eventHandler;
      ugDrivers2.InitializeRow += initializeRowEventHandler;
      ugDrivers2.InitializeLayout += layoutEventHandler;
    }
  }

  protected virtual LinkLabel lnkDeletedRecords
  {
    get => this._lnkDeletedRecords;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkDeletedRecords_LinkClicked);
      LinkLabel lnkDeletedRecords1 = this._lnkDeletedRecords;
      if (lnkDeletedRecords1 != null)
        lnkDeletedRecords1.LinkClicked -= clickedEventHandler;
      this._lnkDeletedRecords = value;
      LinkLabel lnkDeletedRecords2 = this._lnkDeletedRecords;
      if (lnkDeletedRecords2 == null)
        return;
      lnkDeletedRecords2.LinkClicked += clickedEventHandler;
    }
  }

  protected virtual LinkLabel lnkCopyFromExpiringQuote
  {
    get => this._lnkCopyFromExpiringQuote;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.lnkCopyFromExpiringQuote_Click);
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkCopyFromExpiringQuote_Click);
      LinkLabel fromExpiringQuote1 = this._lnkCopyFromExpiringQuote;
      if (fromExpiringQuote1 != null)
      {
        fromExpiringQuote1.Click -= eventHandler;
        fromExpiringQuote1.LinkClicked -= clickedEventHandler;
      }
      this._lnkCopyFromExpiringQuote = value;
      LinkLabel fromExpiringQuote2 = this._lnkCopyFromExpiringQuote;
      if (fromExpiringQuote2 == null)
        return;
      fromExpiringQuote2.Click += eventHandler;
      fromExpiringQuote2.LinkClicked += clickedEventHandler;
    }
  }

  protected virtual LinkLabel lnkCopyFromAnotherQuote
  {
    get => this._lnkCopyFromAnotherQuote;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkCopyFromAnotherQuote_LinkClicked);
      LinkLabel fromAnotherQuote1 = this._lnkCopyFromAnotherQuote;
      if (fromAnotherQuote1 != null)
        fromAnotherQuote1.LinkClicked -= clickedEventHandler;
      this._lnkCopyFromAnotherQuote = value;
      LinkLabel fromAnotherQuote2 = this._lnkCopyFromAnotherQuote;
      if (fromAnotherQuote2 == null)
        return;
      fromAnotherQuote2.LinkClicked += clickedEventHandler;
    }
  }

  protected virtual LinkLabel lnkPrintDrivers
  {
    get => this._lnkPrintDrivers;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkPrintDrivers_LinkClicked);
      LinkLabel lnkPrintDrivers1 = this._lnkPrintDrivers;
      if (lnkPrintDrivers1 != null)
        lnkPrintDrivers1.LinkClicked -= clickedEventHandler;
      this._lnkPrintDrivers = value;
      LinkLabel lnkPrintDrivers2 = this._lnkPrintDrivers;
      if (lnkPrintDrivers2 == null)
        return;
      lnkPrintDrivers2.LinkClicked += clickedEventHandler;
    }
  }

  protected virtual LinkLabel lnkADRConnect
  {
    get => this._lnkADRConnect;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkADRConnect_LinkClicked);
      LinkLabel lnkAdrConnect1 = this._lnkADRConnect;
      if (lnkAdrConnect1 != null)
        lnkAdrConnect1.LinkClicked -= clickedEventHandler;
      this._lnkADRConnect = value;
      LinkLabel lnkAdrConnect2 = this._lnkADRConnect;
      if (lnkAdrConnect2 == null)
        return;
      lnkAdrConnect2.LinkClicked += clickedEventHandler;
    }
  }

  protected virtual LinkLabel lnkDeSelectAll
  {
    get => this._lnkDeSelectAll;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkDeSelectAll_LinkClicked);
      LinkLabel lnkDeSelectAll1 = this._lnkDeSelectAll;
      if (lnkDeSelectAll1 != null)
        lnkDeSelectAll1.LinkClicked -= clickedEventHandler;
      this._lnkDeSelectAll = value;
      LinkLabel lnkDeSelectAll2 = this._lnkDeSelectAll;
      if (lnkDeSelectAll2 == null)
        return;
      lnkDeSelectAll2.LinkClicked += clickedEventHandler;
    }
  }

  protected virtual LinkLabel lnkSelectAll
  {
    get => this._lnkSelectAll;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkSelectAll_LinkClicked);
      LinkLabel lnkSelectAll1 = this._lnkSelectAll;
      if (lnkSelectAll1 != null)
        lnkSelectAll1.LinkClicked -= clickedEventHandler;
      this._lnkSelectAll = value;
      LinkLabel lnkSelectAll2 = this._lnkSelectAll;
      if (lnkSelectAll2 == null)
        return;
      lnkSelectAll2.LinkClicked += clickedEventHandler;
    }
  }

  [field: AccessedThroughProperty("panelProcessingADR")]
  protected virtual UltraGroupBox panelProcessingADR { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("spinner")]
  public virtual PictureBox spinner { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("labelSearchText")]
  private virtual Label labelSearchText { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected virtual LinkLabel lnkPasswordUpdate
  {
    get => this._lnkPasswordUpdate;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkPasswordUpdate_LinkClicked);
      LinkLabel lnkPasswordUpdate1 = this._lnkPasswordUpdate;
      if (lnkPasswordUpdate1 != null)
        lnkPasswordUpdate1.LinkClicked -= clickedEventHandler;
      this._lnkPasswordUpdate = value;
      LinkLabel lnkPasswordUpdate2 = this._lnkPasswordUpdate;
      if (lnkPasswordUpdate2 == null)
        return;
      lnkPasswordUpdate2.LinkClicked += clickedEventHandler;
    }
  }

  [field: AccessedThroughProperty("ultraTabSharedControlsPage1")]
  private virtual UltraTabSharedControlsPage ultraTabSharedControlsPage1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("tabDriverInfo")]
  protected virtual UltraTabPageControl tabDriverInfo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label18")]
  internal virtual Label Label18 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label4")]
  internal virtual Label Label4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label19")]
  internal virtual Label Label19 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtZipPlus")]
  protected virtual MGATextBox txtZipPlus { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtZipCode")]
  protected virtual MGATextBox txtZipCode { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtCity")]
  protected virtual MGATextBox txtCity { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtStreet2")]
  protected virtual MGATextBox txtStreet2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtStreet1")]
  protected virtual MGATextBox txtStreet1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("dtLicenseExpDate")]
  protected virtual MGADateTimePicker dtLicenseExpDate { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("dtpDriverAdded")]
  protected virtual MGADateTimePicker dtpDriverAdded { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("dtpDriverDeleted")]
  protected virtual MGADateTimePicker dtpDriverDeleted { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected virtual MGAComboBox comboDriverStatus
  {
    get => this._comboDriverStatus;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      InitializeRowEventHandler initializeRowEventHandler = new InitializeRowEventHandler(this.ComboDriverStatus_InitializeRow);
      MGAComboBox comboDriverStatus1 = this._comboDriverStatus;
      if (comboDriverStatus1 != null)
        comboDriverStatus1.InitializeRow -= initializeRowEventHandler;
      this._comboDriverStatus = value;
      MGAComboBox comboDriverStatus2 = this._comboDriverStatus;
      if (comboDriverStatus2 == null)
        return;
      comboDriverStatus2.InitializeRow += initializeRowEventHandler;
    }
  }

  [field: AccessedThroughProperty("comboState")]
  protected virtual MGAComboBox comboState { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("dtPDateOfBirth")]
  protected virtual MGADateTimePicker dtPDateOfBirth { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtLastName")]
  protected virtual MGATextBox txtLastName { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtFirstName")]
  protected virtual MGATextBox txtFirstName { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("tabAddlDriverInfo")]
  protected virtual UltraTabPageControl tabAddlDriverInfo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaTextBox5")]
  protected virtual MGATextBox MgaTextBox5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label24")]
  internal virtual Label Label24 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaTextBox4")]
  protected virtual MGATextBox MgaTextBox4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label16")]
  internal virtual Label Label16 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaTextBox3")]
  protected virtual MGATextBox MgaTextBox3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label15")]
  internal virtual Label Label15 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaTextBox9")]
  protected virtual MGATextBox MgaTextBox9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label28")]
  internal virtual Label Label28 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaTextBox8")]
  protected virtual MGATextBox MgaTextBox8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label26")]
  internal virtual Label Label26 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaTextBox7")]
  protected virtual MGATextBox MgaTextBox7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label25")]
  internal virtual Label Label25 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaTextBox6")]
  protected virtual MGATextBox MgaTextBox6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label14")]
  internal virtual Label Label14 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaTextBox2")]
  protected virtual MGATextBox MgaTextBox2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label13")]
  protected virtual Label Label13 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("dtMedicalExpiration")]
  protected virtual MGADateTimePicker dtMedicalExpiration { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("tabNotes")]
  protected virtual UltraTabPageControl tabNotes { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("GroupBox2")]
  internal virtual GroupBox GroupBox2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label33")]
  internal virtual Label Label33 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaTextBox12")]
  private virtual MGATextBox MgaTextBox12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label32")]
  internal virtual Label Label32 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaTextBox11")]
  private virtual MGATextBox MgaTextBox11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label31")]
  internal virtual Label Label31 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaComboBox1")]
  protected virtual MGAComboBox MgaComboBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label30")]
  internal virtual Label Label30 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaTextBox10")]
  private virtual MGATextBox MgaTextBox10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkPopup")]
  private virtual MGACheckBox chkPopup { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected virtual LinkLabel lnkOvernightOrders
  {
    get => this._lnkOvernightOrders;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkOvernightOrders_LinkClicked);
      LinkLabel lnkOvernightOrders1 = this._lnkOvernightOrders;
      if (lnkOvernightOrders1 != null)
        lnkOvernightOrders1.LinkClicked -= clickedEventHandler;
      this._lnkOvernightOrders = value;
      LinkLabel lnkOvernightOrders2 = this._lnkOvernightOrders;
      if (lnkOvernightOrders2 == null)
        return;
      lnkOvernightOrders2.LinkClicked += clickedEventHandler;
    }
  }

  [field: AccessedThroughProperty("lblYearsLogTruckExperience")]
  internal virtual Label lblYearsLogTruckExperience { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("numYearsLogTruckExperienceNum")]
  protected virtual MGANumericEditor numYearsLogTruckExperienceNum { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label35")]
  internal virtual Label Label35 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("dtpDateOfOrigCDL")]
  protected virtual MGADateTimePicker dtpDateOfOrigCDL { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblDateOfHire")]
  internal virtual Label lblDateOfHire { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("dtpDateOfHire")]
  protected virtual MGADateTimePicker dtpDateOfHire { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected virtual MGAButton btnQuery
  {
    get => this._btnQuery;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnQuery_Click);
      MGAButton btnQuery1 = this._btnQuery;
      if (btnQuery1 != null)
        ((Control) btnQuery1).Click -= eventHandler;
      this._btnQuery = value;
      MGAButton btnQuery2 = this._btnQuery;
      if (btnQuery2 == null)
        return;
      ((Control) btnQuery2).Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("dtMVRDate")]
  protected virtual MGADateTimePicker dtMVRDate { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cboCDLDriver")]
  protected virtual MGAComboBox cboCDLDriver { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("uddCDL")]
  private virtual UltraDropDown uddCDL { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label37")]
  internal virtual Label Label37 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected virtual LinkLabel lnkGenerateDocument
  {
    get => this._lnkGenerateDocument;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkGenerateDocument_LinkClicked);
      LinkLabel generateDocument1 = this._lnkGenerateDocument;
      if (generateDocument1 != null)
        generateDocument1.LinkClicked -= clickedEventHandler;
      this._lnkGenerateDocument = value;
      LinkLabel generateDocument2 = this._lnkGenerateDocument;
      if (generateDocument2 == null)
        return;
      generateDocument2.LinkClicked += clickedEventHandler;
    }
  }

  [field: AccessedThroughProperty("cboTemplates")]
  private virtual MGASimpleComboBox cboTemplates { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label38")]
  internal virtual Label Label38 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("dtpDriverExcluded")]
  protected virtual MGADateTimePicker dtpDriverExcluded { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual Button btnProcessOvernightOrders
  {
    get => this._btnProcessOvernightOrders;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnProcessOvernightOrders_Click);
      Button processOvernightOrders1 = this._btnProcessOvernightOrders;
      if (processOvernightOrders1 != null)
        processOvernightOrders1.Click -= eventHandler;
      this._btnProcessOvernightOrders = value;
      Button processOvernightOrders2 = this._btnProcessOvernightOrders;
      if (processOvernightOrders2 == null)
        return;
      processOvernightOrders2.Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("tabDriverTab")]
  protected virtual UltraTabControl tabDriverTab { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkHasDOC")]
  private virtual MGACheckBox chkHasDOC { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtValid")]
  protected virtual MGATextBox txtValid { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtIsClear")]
  protected virtual MGATextBox txtIsClear { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtDLStatus")]
  protected virtual MGATextBox txtDLStatus { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaTextBox13")]
  protected virtual MGATextBox MgaTextBox13 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaTextBox1")]
  protected virtual MGATextBox MgaTextBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label12")]
  protected virtual Label Label12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label11")]
  protected virtual Label Label11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("numDriverRatingFactor")]
  protected virtual MGANumericEditor numDriverRatingFactor { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label3")]
  protected virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label9")]
  protected virtual Label Label9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label2")]
  protected virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label1")]
  protected virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label20")]
  protected virtual Label Label20 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cboFullorPartTime")]
  protected virtual MGAComboBox cboFullorPartTime { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtNumPoints")]
  protected virtual MGATextBox txtNumPoints { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtComments")]
  protected virtual MGATextBox txtComments { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label29")]
  protected virtual Label Label29 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label34")]
  protected virtual Label Label34 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label36")]
  protected virtual Label Label36 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkFurnishedCar")]
  protected virtual MGACheckBox chkFurnishedCar { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label10")]
  protected virtual Label Label10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label8")]
  protected virtual Label Label8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label7")]
  protected virtual Label Label7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label6")]
  protected virtual Label Label6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaCheckBox1")]
  protected virtual MGACheckBox MgaCheckBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label21")]
  protected virtual Label Label21 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label22")]
  protected virtual Label Label22 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label23")]
  protected virtual Label Label23 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label41")]
  protected virtual Label Label41 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label5")]
  protected virtual Label Label5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtLicenseNumber")]
  protected virtual MGATextBox txtLicenseNumber { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("GroupBox1")]
  protected virtual GroupBox GroupBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label40")]
  protected virtual Label Label40 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label39")]
  protected virtual Label Label39 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblDLStatus")]
  protected virtual Label lblDLStatus { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label17")]
  protected virtual Label Label17 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ds")]
  protected virtual dsDriverInfo ds { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected virtual MGAButton btnIIX
  {
    get => this._btnIIX;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnIIX_Click);
      MGAButton btnIix1 = this._btnIIX;
      if (btnIix1 != null)
        ((Control) btnIix1).Click -= eventHandler;
      this._btnIIX = value;
      MGAButton btnIix2 = this._btnIIX;
      if (btnIix2 == null)
        return;
      ((Control) btnIix2).Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("txtDocumentValidationResult")]
  protected virtual MGATextBox txtDocumentValidationResult { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblLicenseValidationResult")]
  protected virtual Label lblLicenseValidationResult { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtMatchError")]
  protected virtual MGATextBox txtMatchError { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblMatchError")]
  protected virtual Label lblMatchError { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtInvoicePath")]
  protected virtual MGATextBox txtInvoicePath { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblInvoicePath")]
  protected virtual Label lblInvoicePath { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraTextEditor1")]
  internal virtual UltraTextEditor UltraTextEditor1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtCompanyClass")]
  protected virtual MGATextBox txtCompanyClass { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblCompanyClass")]
  protected virtual Label lblCompanyClass { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtErrorDescription")]
  protected virtual MGATextBox txtErrorDescription { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblErrorDescription")]
  protected virtual Label lblErrorDescription { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected virtual MGAButton btnBulkDelete
  {
    get => this._btnBulkDelete;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnBulkDelete_Click);
      MGAButton btnBulkDelete1 = this._btnBulkDelete;
      if (btnBulkDelete1 != null)
        ((Control) btnBulkDelete1).Click -= eventHandler;
      this._btnBulkDelete = value;
      MGAButton btnBulkDelete2 = this._btnBulkDelete;
      if (btnBulkDelete2 == null)
        return;
      ((Control) btnBulkDelete2).Click += eventHandler;
    }
  }

  protected virtual LinkLabel lnkDeSelectDeletes
  {
    get => this._lnkDeSelectDeletes;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkDeSelectDeletes_LinkClicked);
      LinkLabel lnkDeSelectDeletes1 = this._lnkDeSelectDeletes;
      if (lnkDeSelectDeletes1 != null)
        lnkDeSelectDeletes1.LinkClicked -= clickedEventHandler;
      this._lnkDeSelectDeletes = value;
      LinkLabel lnkDeSelectDeletes2 = this._lnkDeSelectDeletes;
      if (lnkDeSelectDeletes2 == null)
        return;
      lnkDeSelectDeletes2.LinkClicked += clickedEventHandler;
    }
  }

  protected virtual LinkLabel lnkSelectDeletes
  {
    get => this._lnkSelectDeletes;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkSelectDeletes_LinkClicked);
      LinkLabel lnkSelectDeletes1 = this._lnkSelectDeletes;
      if (lnkSelectDeletes1 != null)
        lnkSelectDeletes1.LinkClicked -= clickedEventHandler;
      this._lnkSelectDeletes = value;
      LinkLabel lnkSelectDeletes2 = this._lnkSelectDeletes;
      if (lnkSelectDeletes2 == null)
        return;
      lnkSelectDeletes2.LinkClicked += clickedEventHandler;
    }
  }

  protected virtual MGAButton btnCopyOnRenewal
  {
    get => this._btnCopyOnRenewal;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnCopyOnRenewal_Click);
      MGAButton btnCopyOnRenewal1 = this._btnCopyOnRenewal;
      if (btnCopyOnRenewal1 != null)
        ((Control) btnCopyOnRenewal1).Click -= eventHandler;
      this._btnCopyOnRenewal = value;
      MGAButton btnCopyOnRenewal2 = this._btnCopyOnRenewal;
      if (btnCopyOnRenewal2 == null)
        return;
      ((Control) btnCopyOnRenewal2).Click += eventHandler;
    }
  }

  protected virtual LinkLabel lnkDeSelectAllCopyRenewal
  {
    get => this._lnkDeSelectAllCopyRenewal;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkDeSelectAllCopyRenewal_LinkClicked);
      LinkLabel selectAllCopyRenewal1 = this._lnkDeSelectAllCopyRenewal;
      if (selectAllCopyRenewal1 != null)
        selectAllCopyRenewal1.LinkClicked -= clickedEventHandler;
      this._lnkDeSelectAllCopyRenewal = value;
      LinkLabel selectAllCopyRenewal2 = this._lnkDeSelectAllCopyRenewal;
      if (selectAllCopyRenewal2 == null)
        return;
      selectAllCopyRenewal2.LinkClicked += clickedEventHandler;
    }
  }

  protected virtual LinkLabel lnkSelectAllCopyRenewal
  {
    get => this._lnkSelectAllCopyRenewal;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkSelectAllCopyRenewal_LinkClicked);
      LinkLabel selectAllCopyRenewal1 = this._lnkSelectAllCopyRenewal;
      if (selectAllCopyRenewal1 != null)
        selectAllCopyRenewal1.LinkClicked -= clickedEventHandler;
      this._lnkSelectAllCopyRenewal = value;
      LinkLabel selectAllCopyRenewal2 = this._lnkSelectAllCopyRenewal;
      if (selectAllCopyRenewal2 == null)
        return;
      selectAllCopyRenewal2.LinkClicked += clickedEventHandler;
    }
  }

  protected internal virtual LinkLabel lnkSambaOffice
  {
    get => this._lnkSambaOffice;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkSambaOffice_LinkClicked);
      LinkLabel lnkSambaOffice1 = this._lnkSambaOffice;
      if (lnkSambaOffice1 != null)
        lnkSambaOffice1.LinkClicked -= clickedEventHandler;
      this._lnkSambaOffice = value;
      LinkLabel lnkSambaOffice2 = this._lnkSambaOffice;
      if (lnkSambaOffice2 == null)
        return;
      lnkSambaOffice2.LinkClicked += clickedEventHandler;
    }
  }

  public FormDriversInfo(int controlNo, Guid quoteGuid)
  {
    this.Load += new EventHandler(this.FormDriversInfo_Load);
    this._ADRPassStatusID = MGASystems.Common.Settings.SystemSettings.GetLazySetting<int>("ADRPassStatusID", int.MinValue);
    this._ADRFailStatusID = MGASystems.Common.Settings.SystemSettings.GetLazySetting<int>("ADRFailStatusID", int.MinValue);
    this._billing = string.Empty;
    this._deletedStatusID = MGASystems.Common.Settings.SystemSettings.GetLazySetting<int>("DriverDeletedStatusID", 4);
    this._includeLicenseNumberInFileName = false;
    this._generateGenericTemplate = false;
    this._requireDobForProcecessing = false;
    this._excludeDeletedDrivers = MGASystems.Common.Settings.SystemSettings.GetLazySetting<bool>("ADR.ExcludeDeletedDrivers", false, true);
    this.InitializeComponent();
    this._ControlNo = controlNo;
    this._QuoteGuid = quoteGuid;
    this._currentQuote = new Quote(quoteGuid);
    this.Text = $"{this.Text}- Control No.{this._ControlNo}";
  }

  public FormDriversInfo()
  {
    this.Load += new EventHandler(this.FormDriversInfo_Load);
    this._ADRPassStatusID = MGASystems.Common.Settings.SystemSettings.GetLazySetting<int>("ADRPassStatusID", int.MinValue);
    this._ADRFailStatusID = MGASystems.Common.Settings.SystemSettings.GetLazySetting<int>("ADRFailStatusID", int.MinValue);
    this._billing = string.Empty;
    this._deletedStatusID = MGASystems.Common.Settings.SystemSettings.GetLazySetting<int>("DriverDeletedStatusID", 4);
    this._includeLicenseNumberInFileName = false;
    this._generateGenericTemplate = false;
    this._requireDobForProcecessing = false;
    this._excludeDeletedDrivers = MGASystems.Common.Settings.SystemSettings.GetLazySetting<bool>("ADR.ExcludeDeletedDrivers", false, true);
    this.InitializeComponent();
  }

  private bool IsOvernightState(string currentStateID)
  {
    return Enum.TryParse<FormDriversInfo.OvernightStates>(currentStateID, out FormDriversInfo.OvernightStates _);
  }

  public BindingManagerBase bmb
  {
    get => this.BindingContext[(object) this.ds, this.ds.tblDriverInfo.TableName];
  }

  public dsDriverInfo DriverInfoDataset => this.ds;

  public Quote Quote => this._currentQuote;

  public Lazy<int> DeletedStatus => this._deletedStatusID;

  public Lazy<bool> ExcludeDeletedDrivers => this._excludeDeletedDrivers;

  protected virtual bool ValidForm()
  {
    bool flag = true;
    if (string.IsNullOrEmpty(((TextEditorControlBase) this.txtFirstName).Text))
    {
      flag = false;
      this.err.SetError((Control) this.txtFirstName, "First Name required.");
    }
    else
      this.err.SetError((Control) this.txtFirstName, string.Empty);
    if (string.IsNullOrEmpty(((TextEditorControlBase) this.txtLastName).Text))
    {
      flag = false;
      this.err.SetError((Control) this.txtLastName, "Last Name required.");
    }
    else
      this.err.SetError((Control) this.txtLastName, string.Empty);
    if (flag)
      flag = this.ValidDateOfBirth();
    if (flag)
      flag = this.ValidState();
    if (flag)
      flag = this.ValidDriverStatus();
    if (flag)
      flag = this.ValidNumberPoints();
    if (flag)
      flag = this.ValidFullOrPartTime();
    if (flag)
      flag = this.ValidLicense();
    if (!flag)
      ((UltraTabControlBase) this.tabDriverTab).SelectedTab = ((UltraTabControlBase) this.tabDriverTab).Tabs[0];
    return flag;
  }

  protected virtual bool ValidDateOfBirth()
  {
    bool flag = true;
    if (this.dtPDateOfBirth.Value != null && this.dtPDateOfBirth.Value != null)
    {
      this.err.SetError((Control) this.dtPDateOfBirth, string.Empty);
    }
    else
    {
      flag = false;
      this.err.SetError((Control) this.dtPDateOfBirth, "Date of Birth required.");
    }
    return flag;
  }

  protected virtual bool ValidState()
  {
    bool flag = true;
    if (this.comboState.Value != null && this.comboState.Value != null)
    {
      this.err.SetError((Control) this.comboState, string.Empty);
    }
    else
    {
      flag = false;
      this.err.SetError((Control) this.comboState, "State required.");
    }
    return flag;
  }

  protected virtual bool ValidLicense()
  {
    bool flag = true;
    this.err.SetError((Control) this.txtLicenseNumber, string.Empty);
    if (string.IsNullOrEmpty(((TextEditorControlBase) this.txtLicenseNumber).Text))
    {
      flag = false;
      this.err.SetError((Control) this.txtLicenseNumber, "License # required.");
    }
    return flag;
  }

  protected virtual bool ValidDriverStatus()
  {
    bool flag = true;
    if (this.comboDriverStatus.Value != null && this.comboDriverStatus.Value != null)
    {
      this.err.SetError((Control) this.comboDriverStatus, string.Empty);
    }
    else
    {
      flag = false;
      this.err.SetError((Control) this.comboDriverStatus, "Driver Status required.");
    }
    return flag;
  }

  protected virtual bool ValidNumberPoints()
  {
    bool flag = true;
    if (string.IsNullOrEmpty(((TextEditorControlBase) this.txtNumPoints).Text))
    {
      flag = false;
      this.err.SetError((Control) this.txtNumPoints, "# of Points required.");
    }
    else
      this.err.SetError((Control) this.txtNumPoints, string.Empty);
    return flag;
  }

  protected virtual bool ValidFullOrPartTime()
  {
    bool flag = true;
    if (this.cboFullorPartTime.Value != null && this.cboFullorPartTime.Value != null)
    {
      this.err.SetError((Control) this.cboFullorPartTime, string.Empty);
    }
    else
    {
      flag = false;
      this.err.SetError((Control) this.cboFullorPartTime, "Full or Part Time required.");
    }
    return flag;
  }

  private string GetInsuredName()
  {
    string insuredPolicyName = this.Quote.InsuredPolicyName;
    return insuredPolicyName.Length <= 30 ? insuredPolicyName : insuredPolicyName.Substring(0, 30);
  }

  private void FormDriversInfo_Load(object sender, EventArgs e)
  {
    if (this.DesignMode)
      return;
    this._billing = this.Quote.ControlNo.ToString();
    if (this.Quote.HasPolicyNumber)
      this._billing = $"{this._billing}/{this.Quote.PolicyNumber}";
    this._useVolta = DriverUtilityFunctions.UsesVolta();
    this._usePdf = DriverUtilityFunctions.UsesPdfFileExtension();
    this.BeforeDataLoad();
    ((ControlBase) this.btnQuery).Appearance.Image = (object) ImageCache.Instance.Search;
    this.cnSQL.ConnectionString = CurrentUser.Instance.ConnectionString;
    this.SetSearchPanelVisible(false);
    this.daDrivers.SelectCommand.Parameters["@ControlNo"].Value = (object) this._ControlNo;
    DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[7]
    {
      "lstStates",
      "lstDriverStatus",
      "lstDriverStatusInfo",
      "tblUsers",
      "tblDriverInfo",
      "lstDriverCDL",
      "tblDriverReqs"
    }, "spGetDriversInfo", new object[2]
    {
      (object) "@ControlNo",
      (object) this._ControlNo
    });
    this.dbSave.UIState = this.ds.tblDriverInfo.Rows.Count != 0 ? UIState.HasRecordsNotEditing : UIState.NoRecordsNotEditing;
    this.SetControlsEnableStatus(false);
    this.lnkDeletedRecords_LinkClicked((object) null, (LinkLabelLinkClickedEventArgs) null);
    this.lnkCopyFromExpiringQuote.Enabled = this.Quote.PolicyType == PolicyTypes.Renewal && this.Quote.IsImsRenewal;
    if (this.Quote.IsImsRenewal)
    {
      Quote quote = new Quote(this.Quote.RenewalOfQuoteGuid.Value);
      LinkLabel fromExpiringQuote;
      string str = $"{(fromExpiringQuote = this.lnkCopyFromExpiringQuote).Text}. [Control # {quote.ControlNo.ToString()}]";
      fromExpiringQuote.Text = str;
    }
    this._includeLicenseNumberInFileName = MGASystems.Common.Settings.SystemSettings.GetSetting<bool>("ADR.IncludeLicenseNumberInFileName");
    this._requireDobForProcecessing = MGASystems.Common.Settings.SystemSettings.GetSetting<bool>("ADR.DOBRequiredForProcessing");
    this._generateGenericTemplate = MGASystems.Common.Settings.SystemSettings.GetSetting<bool>("DriverInfo.GenerateGenericTemplate");
    this._iixOrders = MGASystems.Common.Settings.SystemSettings.GetSetting<bool>("IIX.CanOrderMVRs");
    if (this._iixOrders)
    {
      ((Control) this.btnIIX).Visible = true;
      ((HeaderBase) ((UltraGridBase) this.ugDrivers).DisplayLayout.Bands[0].Columns["ADR"].Header).Caption = "MVR";
    }
    this.SetDriverProcessSelection(false);
    this.SetDocumentProcessSelection(false);
    this.CheckDriverStatus();
    this.SetDeletedRowAppearance();
    ((UltraGridBase) this.cboTemplates).DataSource = (object) DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT TemplateID, TemplateName FROM tblDocumentTemplates WHERE Hidden = 0 AND AutomationGroupID = 12 ORDER BY TemplateName");
    ((UltraDropDownBase) this.cboTemplates).DisplayMember = "TemplateName";
    ((UltraDropDownBase) this.cboTemplates).ValueMember = "TemplateID";
    this.AfterFormLoad();
    if (!ADRConnectWrapper.ImplementsLicenseLookup)
    {
      this.lblLicenseValidationResult.Visible = false;
      this.lblMatchError.Visible = false;
      ((Control) this.txtDocumentValidationResult).Visible = false;
      ((Control) this.txtMatchError).Visible = false;
      this.lblInvoicePath.Visible = false;
      ((Control) this.txtInvoicePath).Visible = false;
    }
    else
    {
      this.lblLicenseValidationResult.Visible = true;
      this.lblMatchError.Visible = true;
      ((Control) this.txtDocumentValidationResult).Visible = true;
      ((Control) this.txtMatchError).Visible = true;
      this.lblInvoicePath.Visible = true;
      ((Control) this.txtInvoicePath).Visible = true;
    }
    this._encryptDriverData = MGASystems.Common.Settings.SystemSettings.GetSetting<bool>("Drivers.EncriptDataPoints");
    bool setting1 = MGASystems.Common.Settings.SystemSettings.GetSetting<bool>("ADR.ImplementBulkDelete");
    ((UltraGridBase) this.ugDrivers).DisplayLayout.Bands[0].Columns["BulkDelete"].Hidden = !setting1;
    this.lnkSelectDeletes.Visible = setting1;
    this.lnkDeSelectDeletes.Visible = setting1;
    ((Control) this.btnBulkDelete).Visible = setting1;
    bool setting2 = MGASystems.Common.Settings.SystemSettings.GetSetting<bool>("ADR.ImplementBulkCopyOnRenewal");
    if (setting2)
      ((UltraGridBase) this.ugDrivers).DisplayLayout.Bands[0].Columns["CopyOnRenewal"].CellActivation = (Activation) 0;
    this.lnkSelectAllCopyRenewal.Visible = setting2;
    this.lnkDeSelectAllCopyRenewal.Visible = setting2;
    ((Control) this.btnCopyOnRenewal).Visible = setting2;
    if (MGASystems.Common.Settings.SystemSettings.GetSetting<bool>("DriverInfo.TruVision.ColumnEnabled"))
      ((UltraGridBase) this.ugDrivers).DisplayLayout.Bands[0].Columns["TruVision"].Hidden = false;
    this.DecryptDataPoints();
    this.ObscureLicenseAndBirthDate();
  }

  protected virtual void AfterFormLoad()
  {
  }

  private void CheckDriverStatus()
  {
    if (this._ADRFailStatusID.Value == int.MinValue)
      return;
    try
    {
      foreach (dsDriverInfo.tblDriverInfoRow row in this.ds.tblDriverInfo.Rows)
      {
        if (!row.IsStatusIDNull() && row.StatusID == this._ADRFailStatusID.Value)
          this.MarkDriver((int) row.DriverID);
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  protected virtual DateTime DriverDeletedDate(dsDriverInfo.tblDriverInfoRow currentDriverRow)
  {
    return CurrentUser.ServerTime;
  }

  protected virtual void SetDeletedDriverStatus(long driverID)
  {
    this.ds.tblDriverInfo.FindByDriverID(driverID).StatusID = this.DeletedStatus.Value;
    this.comboDriverStatus.Value = (object) this.DeletedStatus.Value;
  }

  private void dbSave_ClickedCancel(object sender, EventArgs e)
  {
    this.ds.tblDriverInfo.RejectChanges();
    this.ClearAllErrors();
    this.SetControlsEnableStatus(false);
    this.dbSave.UIState = this.ds.tblDriverInfo.Rows.Count != 0 ? UIState.HasRecordsNotEditing : UIState.NoRecordsNotEditing;
    this.ObscureLicenseAndBirthDate();
  }

  private void dbSave_ClickedDelete(object sender, EventArgs e)
  {
    long driverId = this.ds.tblDriverInfo[this.bmb.Position].DriverID;
    this.ds.tblDriverInfo.FindByDriverID(driverId).DriverDeleted = this.DriverDeletedDate(this.ds.tblDriverInfo[this.bmb.Position]);
    this.SetDeletedDriverStatus(driverId);
    this.SaveData();
    if (this.ds.tblDriverInfo.Count == 0)
      this.dbSave.UIState = UIState.NoRecordsNotEditing;
    this.SetControlsEnableStatus(false);
  }

  private void dbSave_ClickedNew(object sender, EventArgs e)
  {
    this.DisplayLicenseAndBirthDate();
    dsDriverInfo.tblDriverInfoRow row = this.ds.tblDriverInfo.NewtblDriverInfoRow();
    DateTime serverTime = CurrentUser.ServerTime;
    row.QuoteGuid = this._QuoteGuid;
    row.ControlNo = this._ControlNo;
    row.DateAdded = serverTime;
    row.FurnishedCar = false;
    row.CopyOnRenewal = true;
    row.ADR = false;
    row.GenerateDoc = false;
    row.DOC = false;
    this.ds.tblDriverInfo.AddtblDriverInfoRow(row);
    this.bmb.Position = this.ds.tblDriverInfo.Count - 1;
    this.SetControlsEnableStatus(true);
    this.dtpDriverAdded.Value = (object) serverTime;
    ((UltraGridBase) this.ugDrivers).UpdateData();
    ((TextEditorControlBase) this.txtLicenseNumber).Focus();
  }

  private void dbSave_ClickedSave(object sender, EventArgs e)
  {
    try
    {
      this.SaveData();
      this.ClearAllErrors();
      this.SetControlsEnableStatus(false);
    }
    finally
    {
      this.ObscureLicenseAndBirthDate();
    }
  }

  private void dbSave_ClickingDelete(object sender, CancelEventArgs e)
  {
    if (MessageBox.Show("Are you sure you want to delete this driver?", "Delete Driver?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
      return;
    e.Cancel = true;
  }

  private void dbSave_ClickingEdit(object sender, CancelEventArgs e)
  {
    this.SetControlsEnableStatus(true);
  }

  private void dbSave_ClickingNew(object sender, CancelEventArgs e)
  {
    if (this.ds.lstDriverStatus.Rows.Count != 0)
      return;
    e.Cancel = true;
  }

  private void dbSave_ClickingSave(object sender, CancelEventArgs e)
  {
    if (this.ValidForm())
      return;
    e.Cancel = true;
  }

  protected virtual void SetControlsEnableStatus(bool booleanStatus)
  {
    try
    {
      foreach (Control control1 in ((Control) this.tabDriverTab).Controls)
      {
        if (control1 is UltraTabPageControl)
        {
          try
          {
            foreach (Control control2 in control1.Controls)
              control2.Enabled = booleanStatus;
          }
          finally
          {
            IEnumerator enumerator;
            if (enumerator is IDisposable)
              (enumerator as IDisposable).Dispose();
          }
        }
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    this.lnkSelectDeletes.Enabled = true;
    this.lnkDeSelectDeletes.Enabled = true;
    ((Control) this.btnBulkDelete).Enabled = true;
    this.lnkSelectAllCopyRenewal.Enabled = true;
    this.lnkDeSelectAllCopyRenewal.Enabled = true;
    ((Control) this.btnCopyOnRenewal).Enabled = true;
  }

  private void ClearAllErrors()
  {
    try
    {
      foreach (Control control1 in ((Control) this.tabDriverTab).Controls)
      {
        if (control1 is UltraTabPageControl)
        {
          try
          {
            foreach (Control control2 in control1.Controls)
              this.err.SetError(control2, string.Empty);
          }
          finally
          {
            IEnumerator enumerator;
            if (enumerator is IDisposable)
              (enumerator as IDisposable).Dispose();
          }
        }
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private void AssignTransaction(SqlDataAdapter da, SqlTransaction trans)
  {
    da.UpdateCommand.Transaction = trans;
    da.DeleteCommand.Transaction = trans;
    da.SelectCommand.Transaction = trans;
    da.InsertCommand.Transaction = trans;
  }

  private void ugDrivers_AfterRowActivate(object sender, EventArgs e)
  {
    ((TextEditorControlBase) this.txtValid).Text = string.Empty;
    ((TextEditorControlBase) this.txtIsClear).Text = string.Empty;
    ((TextEditorControlBase) this.txtDLStatus).Text = string.Empty;
    ((TextEditorControlBase) this.txtDocumentValidationResult).Text = string.Empty;
    ((TextEditorControlBase) this.txtMatchError).Text = string.Empty;
    ((TextEditorControlBase) this.txtInvoicePath).Text = string.Empty;
    ((TextEditorControlBase) this.txtCompanyClass).Text = string.Empty;
    ((TextEditorControlBase) this.txtErrorDescription).Text = string.Empty;
    if (((UltraGridBase) this.ugDrivers).ActiveRow != null)
    {
      DataRow byDriverId1 = (DataRow) this.ds.tblDriverInfo.FindByDriverID((long) ((UltraGridBase) this.ugDrivers).ActiveRow.Cells["DriverId"].Value);
      if (byDriverId1 != null)
        this.bmb.Position = this.ds.tblDriverInfo.Rows.IndexOf(byDriverId1);
      dsDriverInfo.tblDriverReqsRow byDriverId2 = this.ds.tblDriverReqs.FindByDriverID(Conversions.ToInteger(((UltraGridBase) this.ugDrivers).ActiveRow.Cells["DriverID"].Value));
      if (byDriverId2 != null)
      {
        if (!byDriverId2.IsValidNull())
          ((TextEditorControlBase) this.txtValid).Text = byDriverId2.Valid;
        if (!byDriverId2.IsIsClearNull())
          ((TextEditorControlBase) this.txtIsClear).Text = byDriverId2.IsClear;
        if (!byDriverId2.IsDLStatusNull())
          ((TextEditorControlBase) this.txtDLStatus).Text = byDriverId2.DLStatus;
        if (!byDriverId2.IsDocumentValidationResultNull())
          ((TextEditorControlBase) this.txtDocumentValidationResult).Text = byDriverId2.DocumentValidationResult;
        if (!byDriverId2.IsMatchErrorNull())
          ((TextEditorControlBase) this.txtMatchError).Text = byDriverId2.MatchError;
        if (!byDriverId2.IsInvoicePathNull())
          ((TextEditorControlBase) this.txtInvoicePath).Text = byDriverId2.InvoicePath;
        if (!byDriverId2.IsCompanyClassNull())
          ((TextEditorControlBase) this.txtCompanyClass).Text = byDriverId2.CompanyClass;
        if (!byDriverId2.IsErrorDescriptionNull())
          ((TextEditorControlBase) this.txtErrorDescription).Text = byDriverId2.ErrorDescription;
      }
    }
    this.AfterRowActivate_OnClient();
  }

  protected virtual void AfterRowActivate_OnClient()
  {
  }

  private void dbSave_UIStateChanged(object sender, EventArgs e)
  {
    ((Control) this.ugDrivers).Enabled = this.dbSave.UIState != UIState.Editing;
    this.SetControlsEnableStatus(!((Control) this.ugDrivers).Enabled);
  }

  private void SaveData()
  {
    // ISSUE: variable of a compiler-generated type
    FormDriversInfo._Closure\u0024__621\u002D0 closure6210_1;
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    FormDriversInfo._Closure\u0024__621\u002D0 closure6210_2 = new FormDriversInfo._Closure\u0024__621\u002D0(closure6210_1);
    // ISSUE: reference to a compiler-generated field
    closure6210_2.\u0024VB\u0024Me = this;
    // ISSUE: reference to a compiler-generated field
    closure6210_2.\u0024VB\u0024Local_statusContext = (BroadcastMessages.Types.DriverStatusChangedContext) null;
    this.ds.tblDriverInfo[this.bmb.Position].SetLicenseNumberEncryptedNull();
    this.ds.tblDriverInfo[this.bmb.Position].SetDOBEncryptedNull();
    if (!this.ds.tblDriverInfo[this.bmb.Position].IsLicenseNumberNull())
      this.ds.tblDriverInfo[this.bmb.Position].LicenseNumberEncrypted = ((TripleDesEncrypter) FormDriversInfo._encryptor).Encrypt(this.ds.tblDriverInfo[this.bmb.Position].LicenseNumber);
    if (!this.ds.tblDriverInfo[this.bmb.Position].IsDOBNull())
      this.ds.tblDriverInfo[this.bmb.Position].DOBEncrypted = ((TripleDesEncrypter) FormDriversInfo._encryptor).Encrypt(this.ds.tblDriverInfo[this.bmb.Position].DOB.ToShortDateString());
    this.bmb.EndCurrentEdit();
    try
    {
      // ISSUE: reference to a compiler-generated method
      DefaultDatabase.ExecuteTransaction(new EventHandler<ExecuteTransactionEventArgs>(closure6210_2._Lambda\u0024__0));
      // ISSUE: reference to a compiler-generated field
      if (closure6210_2.\u0024VB\u0024Local_statusContext == null)
        return;
      // ISSUE: reference to a compiler-generated field
      Messaging.SendBroadcastMessage(BroadcastMessages.DriverStatusChanged, (object) closure6210_2.\u0024VB\u0024Local_statusContext);
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      ErrorHandler.SilentHandleError(ex);
      throw;
    }
  }

  protected virtual void SetClientRowState(DataRowState rs)
  {
  }

  protected virtual void SaveDataOnClient()
  {
  }

  protected virtual void SaveDataOnClient(DataRowState rowstate) => this.SaveDataOnClient();

  private void ugDrivers_InitializeRow(object sender, InitializeRowEventArgs e)
  {
    if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(e.Row.Cells["DriverDeleted"].Value)))
    {
      e.Row.Appearance.ForeColor = Color.Red;
      e.Row.Appearance.FontData.Strikeout = (DefaultableBoolean) 1;
    }
    else
    {
      e.Row.Appearance.ForeColor = Color.Blue;
      e.Row.Appearance.FontData.Strikeout = (DefaultableBoolean) 2;
    }
    this.ugDrivers_InitializeRowOnClient(RuntimeHelpers.GetObjectValue(sender), e);
  }

  private void lnkDeletedRecords_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    if (this.lnkDeletedRecords.Text.Equals("Show All Records"))
    {
      this.HideDeletedDrivers(false);
      this.lnkDeletedRecords.Text = "Hide Deleted Records";
    }
    else
    {
      this.HideDeletedDrivers(true);
      this.lnkDeletedRecords.Text = "Show All Records";
    }
    ((UltraGridBase) this.ugDrivers).DisplayLayout.ScrollBounds = (ScrollBounds) 0;
  }

  private void HideDeletedDrivers(bool enable)
  {
    foreach (UltraGridRow row in ((UltraGridBase) this.ugDrivers).Rows)
      row.Hidden = enable ? row.Cells["DriverDeleted"].Value != null && row.Cells["DriverDeleted"].Value != DBNull.Value : enable;
  }

  private void lnkCopyFromExpiringQuote_Click(object sender, EventArgs e)
  {
    FormCopyRenewalDrivers formEx = (FormCopyRenewalDrivers) ObjectFactory.Instance.CreateFormEX(typeof (FormCopyRenewalDrivers), (object) this._ControlNo, (object) this._QuoteGuid);
    try
    {
      int num = (int) formEx.ShowDialog();
    }
    finally
    {
      formEx.Dispose();
    }
    this.ds.tblDriverInfo.Clear();
    this.daDrivers.SelectCommand.Parameters["@ControlNo"].Value = (object) this._ControlNo;
    DefaultDatabase.DataAdapterFill((DbDataAdapter) this.daDrivers, (DataTable) this.ds.tblDriverInfo);
  }

  private void lnkCopyFromAnotherQuote_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    bool flag = false;
    string str = string.Empty;
    FormCopyDriversFromAnotherQuote formEx = (FormCopyDriversFromAnotherQuote) ObjectFactory.Instance.CreateFormEX(typeof (FormCopyDriversFromAnotherQuote), (object) this._ControlNo);
    try
    {
      formEx.ShowInTaskbar = false;
      formEx.StartPosition = FormStartPosition.CenterScreen;
      int num = (int) formEx.ShowDialog();
      flag = formEx.SelectCopy;
      str = formEx.DriversNumbers;
    }
    finally
    {
      formEx.Dispose();
    }
    if (!flag)
      return;
    if (str.Equals(string.Empty))
    {
      int num1 = (int) MessageBox.Show("No driver been been selected to copy.", "No Driver Selected", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    else
    {
      try
      {
        this.Cursor = MgaCursors.WaitCursor;
        DefaultDatabase.ExecuteNonQuery("spCopyDriversInfoFromControlNumbers", new object[4]
        {
          (object) "@ToControlNo",
          (object) this._ControlNo,
          (object) "@DriversNumbers",
          (object) str
        });
        this.ds.tblDriverInfo.Clear();
        this.daDrivers.SelectCommand.Parameters["@ControlNo"].Value = (object) this._ControlNo;
        DefaultDatabase.DataAdapterFill((DbDataAdapter) this.daDrivers, (DataTable) this.ds.tblDriverInfo);
      }
      finally
      {
        this.Cursor = MgaCursors.Default;
      }
    }
  }

  private void lnkPrintDrivers_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    MGAReport objectAs = (MGAReport) ObjectFactory.Instance.CreateObjectAs<rptPrintDriverInfo>(typeof (rptPrintDriverInfo), (object) this._QuoteGuid, (object) this._ControlNo);
    objectAs.Run();
    new frmPrint((SectionReport) objectAs).Show();
  }

  private bool IsReadyForProcessing()
  {
    bool flag;
    try
    {
      foreach (dsDriverInfo.tblDriverInfoRow row in this.ds.tblDriverInfo.Rows)
      {
        if (!row.IsADRNull() && row.ADR)
        {
          flag = true;
          goto label_8;
        }
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    flag = false;
label_8:
    return flag;
  }

  private string IsValidBirthDateCheckForProcessing()
  {
    string empty;
    if (!this._requireDobForProcecessing)
    {
      empty = string.Empty;
    }
    else
    {
      StringBuilder stringBuilder = new StringBuilder();
      try
      {
        foreach (dsDriverInfo.tblDriverInfoRow row in this.ds.tblDriverInfo.Rows)
        {
          string str1 = string.Empty;
          string str2 = string.Empty;
          if (!row.IsADRNull() && row.ADR && row.IsDOBNull())
          {
            if (!row.IsFirstNameNull())
              str1 = row.FirstName;
            if (!row.IsLastNameNull())
              str2 = row.LastName;
            stringBuilder.AppendLine($"{str1} {str2}");
          }
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
      empty = stringBuilder.ToString();
    }
    return empty;
  }

  private string IsValidLicenseCheckForProcessing()
  {
    StringBuilder stringBuilder = new StringBuilder();
    try
    {
      foreach (dsDriverInfo.tblDriverInfoRow row in this.ds.tblDriverInfo.Rows)
      {
        string str1 = string.Empty;
        string str2 = string.Empty;
        if (!row.IsADRNull() && row.ADR && string.IsNullOrEmpty(row.LicenseNumber))
        {
          if (!row.IsFirstNameNull())
            str1 = row.FirstName;
          if (!row.IsLastNameNull())
            str2 = row.LastName;
          stringBuilder.AppendLine($"{str1} {str2}");
        }
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    return stringBuilder.ToString();
  }

  private void lnkADRConnect_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    if (!DriverUtilityFunctions.SambaIssuingOfficeAccess(this._QuoteGuid))
    {
      int num = (int) MessageBox.Show($"Cannot Continue!{Environment.NewLine}{Environment.NewLine}Samba Safety functionality is restricted by the issuing office on this policy.", "Issuing Office Restriction", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    else
      this.SambaSafetyConnect();
  }

  private void MarkDriver(int driverID)
  {
    // ISSUE: variable of a compiler-generated type
    FormDriversInfo._Closure\u0024__635\u002D0 closure6350;
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: reference to a compiler-generated method
    IEnumerable<UltraGridRow> source = ((IEnumerable<UltraGridRow>) ((UltraGridBase) this.ugDrivers).Rows).Where<UltraGridRow>(new System.Func<UltraGridRow, bool>(new FormDriversInfo._Closure\u0024__635\u002D0(closure6350)
    {
      \u0024VB\u0024Local_driverID = driverID
    }._Lambda\u0024__0));
    if (source.Count<UltraGridRow>() <= 0)
      return;
    source.ElementAtOrDefault<UltraGridRow>(0).CellAppearance.ForeColor = Color.Red;
    bool flag = !Utility.IsNull(RuntimeHelpers.GetObjectValue(source.ElementAtOrDefault<UltraGridRow>(0).Cells["StatusID"].Value)) && (int) source.ElementAtOrDefault<UltraGridRow>(0).Cells["StatusID"].Value == this.DeletedStatus.Value;
    try
    {
      foreach (DataColumn column in (InternalDataCollectionBase) this.ds.tblDriverInfo.Columns)
        source.ElementAtOrDefault<UltraGridRow>(0).Cells[column.ColumnName].Appearance.FontData.Strikeout = flag ? (DefaultableBoolean) 1 : (DefaultableBoolean) 2;
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private void ProcessXmlResults(string xmlResultString, dsDriverInfo.dtOrderingRow dRow)
  {
    if (xmlResultString.Length == 0)
      return;
    xmlResultString = ADRConnectWrapper.EscapeString(xmlResultString);
    try
    {
      DefaultDatabase.ExecuteNonQuery(CommandType.Text, "UPDATE tblDriverInfo SET DriverXml = @ADR WHERE DriverID=@DID", new object[4]
      {
        (object) "@ADR",
        (object) xmlResultString,
        (object) "@DID",
        (object) dRow.DriverID
      });
    }
    catch (Exception ex1)
    {
      ProjectData.SetProjectError(ex1);
      Exception ex2 = ex1;
      this.LogSavingException(dRow);
      ErrorHandler.SilentHandleError(ex2);
      ProjectData.ClearProjectError();
    }
    int minValue = int.MinValue;
    if (this._ADRPassStatusID.Value != int.MinValue && this._ADRFailStatusID.Value != int.MinValue)
    {
      string openingTag = "<CompanyClass>";
      string closingTag = "</CompanyClass>";
      bool flag1 = false;
      bool flag2 = false;
      bool xLic = this.xLicense(int.MinValue, dRow);
      if (!xLic && xmlResultString.Contains(openingTag) && xmlResultString.Contains(closingTag))
      {
        flag1 = true;
        string tagsValue = FormDriversInfo.GetTagsValue(xmlResultString, openingTag, closingTag);
        minValue = this._ADRFailStatusID.Value;
        bool flag3 = false;
        try
        {
          foreach (DataRow row in DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT PassValue FROM lstDriverPassResults WITH (NOLOCK)").Rows)
          {
            if (!row.IsNull("PassValue") && row.Field<string>("PassValue").EqualsNoCase(tagsValue))
            {
              flag3 = true;
              break;
            }
          }
        }
        finally
        {
          IEnumerator enumerator;
          if (enumerator is IDisposable)
            (enumerator as IDisposable).Dispose();
        }
        if (flag3)
          minValue = this._ADRPassStatusID.Value;
        else
          this.MarkDriver(dRow.DriverID);
        this.ds.tblDriverInfo.FindByDriverID((long) dRow.DriverID).StatusID = minValue;
        DefaultDatabase.ExecuteNonQuery(CommandType.Text, "UPDATE tblDriverInfo SET StatusID=@ST WHERE DriverID=@DID", new object[4]
        {
          (object) "@ST",
          (object) minValue,
          (object) "@DID",
          (object) dRow.DriverID
        });
        this.ds.tblDriverInfo.FindByDriverID((long) dRow.DriverID).StatusID = minValue;
      }
      if (!flag1 || xLic)
        flag2 = this.CheckInvoicePath(dRow, xmlResultString, xLic);
      if (!flag1 && !flag2)
        this.CheckMessageList(dRow, xmlResultString, xLic);
    }
    if (!dRow.IsStateIDNull() && this.IsOvernightState(dRow.StateID))
    {
      if ((xmlResultString.EqualsNoCase("SUCCESS") || xmlResultString.EqualsNoCase("PASS")) && this._ADRPassStatusID.Value != int.MinValue && this._ADRFailStatusID.Value != int.MinValue)
      {
        minValue = this._ADRPassStatusID.Value;
        DefaultDatabase.ExecuteNonQuery(CommandType.Text, "UPDATE tblDriverInfo SET StatusID=@ST WHERE DriverID=@DID", new object[4]
        {
          (object) "@ST",
          (object) minValue,
          (object) "@DID",
          (object) dRow.DriverID
        });
      }
      else
        this.MarkDriver(dRow.DriverID);
      if (minValue == int.MinValue)
        return;
      this.ds.tblDriverInfo.FindByDriverID((long) dRow.DriverID).StatusID = minValue;
    }
    else
      this.ProcessPolicyWatch(xmlResultString, dRow.DriverID);
  }

  private bool CheckMessageList(dsDriverInfo.dtOrderingRow dRow, string xmlResultString, bool xLic)
  {
    bool flag = false;
    if (!dRow.IsStateIDNull() && this._useVolta && DriverUtilityFunctions.IsVolta(dRow.StateID))
    {
      string openingTag = "<MessageList>";
      string closingTag = "</MessageList>";
      if (xmlResultString.Contains(openingTag) && xmlResultString.Contains(closingTag))
      {
        flag = true;
        int minValue = int.MinValue;
        string tagsValue = FormDriversInfo.GetTagsValue(FormDriversInfo.GetTagsValue(xmlResultString, openingTag, closingTag), "<Line>", "</Line>");
        if (StringExtensions.ContainsCaseInsensitive(tagsValue, "INVOICE PATH"))
        {
          if (!xLic)
          {
            if (StringExtensions.ContainsCaseInsensitive(tagsValue, "PASS") || StringExtensions.ContainsCaseInsensitive(tagsValue, "CLEAN"))
              minValue = this._ADRPassStatusID.Value;
            else if (StringExtensions.ContainsCaseInsensitive(tagsValue, "VIOLATIONS") || StringExtensions.ContainsCaseInsensitive(tagsValue, "FAIL") || StringExtensions.ContainsCaseInsensitive(tagsValue, "ACTIVITY"))
            {
              minValue = this._ADRFailStatusID.Value;
              this.MarkDriver(dRow.DriverID);
            }
          }
          else if (StringExtensions.ContainsCaseInsensitive(tagsValue, "CLEAN"))
            minValue = this._ADRPassStatusID.Value;
          else if (StringExtensions.ContainsCaseInsensitive(tagsValue, "ACTIVITY TRIGGERED"))
          {
            minValue = this._ADRFailStatusID.Value;
            this.MarkDriver(dRow.DriverID);
          }
          if (minValue != int.MinValue)
          {
            this.ds.tblDriverInfo.FindByDriverID((long) dRow.DriverID).StatusID = minValue;
            DefaultDatabase.ExecuteNonQuery(CommandType.Text, "UPDATE tblDriverInfo SET StatusID=@ST WHERE DriverID=@DID", new object[4]
            {
              (object) "@ST",
              (object) minValue,
              (object) "@DID",
              (object) dRow.DriverID
            });
            this.ds.tblDriverInfo.FindByDriverID((long) dRow.DriverID).StatusID = minValue;
          }
        }
      }
    }
    return flag;
  }

  private bool CheckInvoicePath(dsDriverInfo.dtOrderingRow dRow, string xmlResultString, bool xLic)
  {
    bool flag = false;
    if (!dRow.IsStateIDNull() && this._useVolta && DriverUtilityFunctions.IsVolta(dRow.StateID))
    {
      string openingTag = "<InvoicePath>";
      string closingTag = "</InvoicePath>";
      if (xmlResultString.Contains(openingTag) && xmlResultString.Contains(closingTag))
      {
        flag = true;
        int minValue = int.MinValue;
        string tagsValue = FormDriversInfo.GetTagsValue(xmlResultString, openingTag, closingTag);
        if (!xLic)
        {
          if (StringExtensions.ContainsCaseInsensitive(tagsValue, "PASS") || StringExtensions.ContainsCaseInsensitive(tagsValue, "CLEAN"))
            minValue = this._ADRPassStatusID.Value;
          else if (StringExtensions.ContainsCaseInsensitive(tagsValue, "VIOLATIONS") || StringExtensions.ContainsCaseInsensitive(tagsValue, "FAIL") || StringExtensions.ContainsCaseInsensitive(tagsValue, "ACTIVITY"))
          {
            minValue = this._ADRFailStatusID.Value;
            this.MarkDriver(dRow.DriverID);
          }
        }
        else if (StringExtensions.ContainsCaseInsensitive(tagsValue, "CLEAN"))
          minValue = this._ADRPassStatusID.Value;
        else if (StringExtensions.ContainsCaseInsensitive(tagsValue, "ACTIVITY TRIGGERED"))
        {
          minValue = this._ADRFailStatusID.Value;
          this.MarkDriver(dRow.DriverID);
        }
        if (minValue != int.MinValue)
        {
          this.ds.tblDriverInfo.FindByDriverID((long) dRow.DriverID).StatusID = minValue;
          DefaultDatabase.ExecuteNonQuery(CommandType.Text, "UPDATE tblDriverInfo SET StatusID=@ST WHERE DriverID=@DID", new object[4]
          {
            (object) "@ST",
            (object) minValue,
            (object) "@DID",
            (object) dRow.DriverID
          });
          this.ds.tblDriverInfo.FindByDriverID((long) dRow.DriverID).StatusID = minValue;
        }
      }
    }
    return flag;
  }

  private void ProcessPolicyWatch(string xmlResultString, int driverID)
  {
    object obj1 = (object) DBNull.Value;
    object obj2 = (object) DBNull.Value;
    object obj3 = (object) DBNull.Value;
    object tagsValue1 = (object) DBNull.Value;
    object obj4 = (object) DBNull.Value;
    object obj5 = (object) DBNull.Value;
    object obj6 = (object) DBNull.Value;
    object obj7 = (object) DBNull.Value;
    object obj8 = (object) DBNull.Value;
    object obj9 = (object) DBNull.Value;
    object obj10 = (object) DBNull.Value;
    object obj11 = (object) DBNull.Value;
    object obj12 = (object) DBNull.Value;
    if (xmlResultString.Contains("<Result>") && xmlResultString.Contains("</Result>"))
    {
      string tagsValue2 = FormDriversInfo.GetTagsValue(xmlResultString, "<Result>", "</Result>");
      if (tagsValue2.Length > 0)
      {
        string tagsValue3 = FormDriversInfo.GetTagsValue(tagsValue2, "<Valid>", "</Valid>");
        if (tagsValue3.Length > 0)
          obj1 = (object) tagsValue3;
        string tagsValue4 = FormDriversInfo.GetTagsValue(tagsValue2, "<InvoicePath>", "</InvoicePath>");
        if (tagsValue4.Length > 0)
          obj12 = (object) tagsValue4;
      }
    }
    if (xmlResultString.Contains("<Result>") && xmlResultString.Contains("</Result>"))
    {
      string tagsValue5 = FormDriversInfo.GetTagsValue(xmlResultString, "<Result>", "</Result>");
      if (tagsValue5.Length > 0)
        tagsValue1 = (object) FormDriversInfo.GetTagsValue(tagsValue5, "<Control>", "</Control>");
    }
    if (xmlResultString.Contains("<ErrorCode>") && xmlResultString.Contains("</ErrorCode>"))
    {
      string tagsValue6 = FormDriversInfo.GetTagsValue(xmlResultString, "<ErrorCode>", "</ErrorCode>");
      if (tagsValue6.Length > 0)
        obj2 = (object) tagsValue6;
    }
    if (xmlResultString.Contains("<ErrorDescription>") && xmlResultString.Contains("</ErrorDescription>"))
    {
      string tagsValue7 = FormDriversInfo.GetTagsValue(xmlResultString, "<ErrorDescription>", "</ErrorDescription>");
      if (tagsValue7.Length > 0)
        obj3 = (object) tagsValue7;
    }
    if (xmlResultString.Contains("<Result>") && xmlResultString.Contains("</Result>"))
    {
      string tagsValue8 = FormDriversInfo.GetTagsValue(xmlResultString, "<Result>", "</Result>");
      if (tagsValue8.Length > 0)
      {
        string tagsValue9 = FormDriversInfo.GetTagsValue(tagsValue8, "<IsClear>", "</IsClear>");
        if (tagsValue9.Length > 0)
          obj4 = (object) tagsValue9;
      }
    }
    if (xmlResultString.Contains("<Result>") && xmlResultString.Contains("</Result>"))
    {
      string tagsValue10 = FormDriversInfo.GetTagsValue(xmlResultString, "<Result>", "</Result>");
      if (tagsValue10.Length > 0)
      {
        string tagsValue11 = FormDriversInfo.GetTagsValue(tagsValue10, "<CompanyClass>", "</CompanyClass>");
        if (tagsValue11.Length > 0)
          obj5 = (object) tagsValue11;
      }
    }
    if (xmlResultString.Contains("<Result>") && xmlResultString.Contains("</Result>"))
    {
      string tagsValue12 = FormDriversInfo.GetTagsValue(xmlResultString, "<Result>", "</Result>");
      if (tagsValue12.Length > 0)
      {
        string tagsValue13 = FormDriversInfo.GetTagsValue(tagsValue12, "<CompanyScore>", "</CompanyScore>");
        if (tagsValue13.Length > 0)
          obj6 = (object) tagsValue13;
      }
    }
    object obj13 = (object) false;
    string lower = "<Subtype>SUSPENSION</Subtype>".ToLower();
    if (xmlResultString.ToLower().Contains(lower))
      obj13 = (object) true;
    object obj14 = (object) false;
    if (xmlResultString.Contains("<EventList>") && xmlResultString.Contains("</EventList>"))
    {
      string tagsValue14 = FormDriversInfo.GetTagsValue(xmlResultString, "<EventList>", "</EventList>");
      if (tagsValue14.Length > 0)
      {
        string tagsValue15 = FormDriversInfo.GetTagsValue(tagsValue14, "<EventItem>", "</EventItem>");
        if (tagsValue15.Length > 0)
        {
          string tagsValue16 = FormDriversInfo.GetTagsValue(tagsValue15, "<Violation>", "</Violation>");
          if (tagsValue16.Length > 0)
          {
            string tagsValue17 = FormDriversInfo.GetTagsValue(tagsValue16, "<Disposition>", "</Disposition>");
            if (tagsValue17.Length > 0 && tagsValue17.ToString().ToUpper().Equals("GUILTY"))
              obj14 = (object) true;
          }
          else
          {
            string tagsValue18 = FormDriversInfo.GetTagsValue(tagsValue15, "<Common>", "</Common>");
            if (tagsValue18.Length > 0)
            {
              string tagsValue19 = FormDriversInfo.GetTagsValue(tagsValue18, "<Subtype>", "</Subtype>");
              if (tagsValue19.Length > 0 && tagsValue19.ToUpper().Equals("VIOL"))
                obj14 = (object) true;
            }
          }
        }
      }
    }
    object obj15 = (object) false;
    if (xmlResultString.Contains("<CurrentLicense>") && xmlResultString.Contains("</CurrentLicense>"))
    {
      string tagsValue20 = FormDriversInfo.GetTagsValue(xmlResultString, "<CurrentLicense>", "</CurrentLicense>");
      if (tagsValue20.Length > 0)
      {
        string tagsValue21 = FormDriversInfo.GetTagsValue(tagsValue20, "<Commercial>", "</Commercial>");
        if (tagsValue21.Length > 0)
        {
          string tagsValue22 = FormDriversInfo.GetTagsValue(tagsValue21, "<StatusItem>", "</StatusItem>");
          if (tagsValue22.Length > 0)
          {
            string tagsValue23 = FormDriversInfo.GetTagsValue(tagsValue22, "<Name>", "</Name>");
            if (tagsValue23.Length > 0 && tagsValue23.ToUpper().Equals("VALID"))
              obj15 = (object) true;
          }
          obj7 = (object) this.LicenseDate(tagsValue21);
          if (DateTime.Compare(Conversions.ToDate(obj7), DateTime.MinValue) == 0)
            obj7 = (object) DBNull.Value;
        }
      }
    }
    object obj16 = (object) false;
    if (xmlResultString.Contains("<CurrentLicense>") && xmlResultString.Contains("</CurrentLicense>"))
    {
      string xmlString1 = FormDriversInfo.GetTagsValue(xmlResultString, "<CurrentLicense>", "</CurrentLicense>");
      if (xmlString1.Length > 0)
      {
        string tagsValue24 = FormDriversInfo.GetTagsValue(xmlString1, "<PermitList>", "</PermitList>");
        if (tagsValue24.Length > 0)
        {
          int count = Regex.Matches(tagsValue24, "<PermitItem>").Count;
          string xmlString2 = string.Empty;
          for (int index = count; index >= 0; index += -1)
          {
            string tagsValue25 = FormDriversInfo.GetTagsValue(xmlString1, "<PermitItem>", "</PermitItem>");
            if (tagsValue25.Length > 0)
            {
              if (!StringExtensions.ContainsCaseInsensitive(tagsValue25, "COMMERCIAL PERMIT"))
              {
                xmlString1 = xmlString1.Replace(tagsValue25, string.Empty);
              }
              else
              {
                xmlString2 = tagsValue25;
                break;
              }
            }
          }
          if (xmlString2.Length > 0)
          {
            string tagsValue26 = FormDriversInfo.GetTagsValue(xmlString2, "<StatusItem>", "</StatusItem>");
            if (tagsValue26.Length > 0)
            {
              string tagsValue27 = FormDriversInfo.GetTagsValue(tagsValue26, "<Name>", "</Name>");
              if (tagsValue27.Length > 0 && tagsValue27.ToUpper().Equals("VALID".ToUpper()))
                obj16 = (object) true;
            }
          }
        }
      }
    }
    if (xmlResultString.Contains("<CurrentLicense>") && xmlResultString.Contains("</CurrentLicense>"))
    {
      string tagsValue28 = FormDriversInfo.GetTagsValue(xmlResultString, "<CurrentLicense>", "</CurrentLicense>");
      if (tagsValue28.Length > 0)
      {
        string tagsValue29 = FormDriversInfo.GetTagsValue(tagsValue28, "<Personal>", "</Personal>");
        if (tagsValue29.Length > 0)
        {
          obj8 = (object) this.LicenseDate(tagsValue29);
          if (DateTime.Compare(Conversions.ToDate(obj8), DateTime.MinValue) == 0)
            obj8 = (object) DBNull.Value;
        }
      }
    }
    if (xmlResultString.Contains("<CurrentLicense>") && xmlResultString.Contains("</CurrentLicense>"))
    {
      string tagsValue30 = FormDriversInfo.GetTagsValue(xmlResultString, "<CurrentLicense>", "</CurrentLicense>");
      if (tagsValue30.Length > 0)
      {
        string tagsValue31 = FormDriversInfo.GetTagsValue(tagsValue30, "<ExpirationDate>", "</ExpirationDate>");
        if (tagsValue31.Length > 0)
        {
          string tagsValue32 = FormDriversInfo.GetTagsValue(tagsValue31, "<Year>", "</Year>");
          string tagsValue33 = FormDriversInfo.GetTagsValue(tagsValue31, "<Month>", "</Month>");
          string tagsValue34 = FormDriversInfo.GetTagsValue(tagsValue31, "<Day>", "</Day>");
          obj9 = (object) new DateTime(Conversions.ToInteger(tagsValue32), Conversions.ToInteger(tagsValue33), Conversions.ToInteger(tagsValue34));
        }
      }
    }
    if (xmlResultString.Contains("<OrderDate>") && xmlResultString.Contains("</OrderDate>"))
    {
      string tagsValue35 = FormDriversInfo.GetTagsValue(xmlResultString, "<OrderDate>", "</OrderDate>");
      if (tagsValue35.Length > 0)
      {
        string tagsValue36 = FormDriversInfo.GetTagsValue(tagsValue35, "<Year>", "</Year>");
        string tagsValue37 = FormDriversInfo.GetTagsValue(tagsValue35, "<Month>", "</Month>");
        string tagsValue38 = FormDriversInfo.GetTagsValue(tagsValue35, "<Day>", "</Day>");
        obj10 = (object) new DateTime(Conversions.ToInteger(tagsValue36), Conversions.ToInteger(tagsValue37), Conversions.ToInteger(tagsValue38));
        this.ds.tblDriverInfo.FindByDriverID((long) driverID).MVRDate = new DateTime(Conversions.ToInteger(tagsValue36), Conversions.ToInteger(tagsValue37), Conversions.ToInteger(tagsValue38));
      }
    }
    if (xmlResultString.Contains("<CurrentLicense>") && xmlResultString.Contains("</CurrentLicense>"))
    {
      string tagsValue39 = FormDriversInfo.GetTagsValue(xmlResultString, "<CurrentLicense>", "</CurrentLicense>");
      if (tagsValue39.Length > 0)
      {
        string tagsValue40 = FormDriversInfo.GetTagsValue(tagsValue39, "<PersonalStatusList>", "</PersonalStatusList>");
        if (tagsValue40.Length > 0)
        {
          string tagsValue41 = FormDriversInfo.GetTagsValue(tagsValue40, "<StatusItem>", "</StatusItem>");
          if (tagsValue41.Length > 0)
            tagsValue41 = FormDriversInfo.GetTagsValue(tagsValue41, "<Name>", "</Name>");
          if (tagsValue41.Length > 0)
            obj11 = (object) tagsValue41;
        }
      }
    }
    if (obj11 == DBNull.Value)
    {
      string tagsValue42 = FormDriversInfo.GetTagsValue(xmlResultString, "<CurrentLicense>", "</CurrentLicense>");
      if (tagsValue42.Length > 0)
      {
        string tagsValue43 = FormDriversInfo.GetTagsValue(tagsValue42, "<CommercialStatusList>", "</CommercialStatusList>");
        if (tagsValue43.Length > 0)
        {
          string tagsValue44 = FormDriversInfo.GetTagsValue(tagsValue43, "<StatusItem>", "</StatusItem>");
          if (tagsValue44.Length > 0)
          {
            string tagsValue45 = FormDriversInfo.GetTagsValue(tagsValue44, "<Name>", "</Name>");
            if (tagsValue45.Length > 0)
              obj11 = (object) tagsValue45;
          }
        }
      }
    }
    if (obj11 == DBNull.Value)
    {
      string tagsValue46 = FormDriversInfo.GetTagsValue(xmlResultString, "<CurrentLicense>", "</CurrentLicense>");
      if (tagsValue46.Length > 0)
      {
        string tagsValue47 = FormDriversInfo.GetTagsValue(tagsValue46, "<StatusList>", "</StatusList>");
        if (tagsValue47.Length > 0)
        {
          string tagsValue48 = FormDriversInfo.GetTagsValue(tagsValue47, "<StatusItem>", "</StatusItem>");
          if (tagsValue48.Length > 0)
            tagsValue48 = FormDriversInfo.GetTagsValue(tagsValue48, "<Name>", "</Name>");
          if (tagsValue48.Length > 0)
            obj11 = (object) tagsValue48;
        }
      }
    }
    if (obj11 == DBNull.Value)
      obj9 = (object) DBNull.Value;
    object obj17 = (object) DBNull.Value;
    object obj18 = (object) DBNull.Value;
    object obj19 = (object) DBNull.Value;
    if (ADRConnectWrapper.ImplementsLicenseLookup)
    {
      if (xmlResultString.Contains("<LicenseValidationLookupFlag>") && xmlResultString.Contains("</LicenseValidationLookupFlag>"))
      {
        string tagsValue49 = FormDriversInfo.GetTagsValue(xmlResultString, "<LicenseValidationLookupFlag>", "</LicenseValidationLookupFlag>");
        if (tagsValue49.Length > 0)
        {
          if (tagsValue49.ToUpper().Equals("Y") || tagsValue49.ToUpper().Equals("YES") || tagsValue49.ToUpper().Equals("T") || tagsValue49.ToUpper().Equals("TRUE"))
            obj17 = (object) true;
          else if (tagsValue49.ToUpper().Equals("N") || tagsValue49.ToUpper().Equals("NO") || tagsValue49.ToUpper().Equals("F") || tagsValue49.ToUpper().Equals("FALSE"))
            obj17 = (object) false;
        }
      }
      if (xmlResultString.Contains("<LicenseValidation>") && xmlResultString.Contains("</LicenseValidation>"))
      {
        string tagsValue50 = FormDriversInfo.GetTagsValue(xmlResultString, "<DocumentValidationResult>", "</DocumentValidationResult>");
        if (tagsValue50.Length > 0)
          obj18 = (object) tagsValue50;
        string tagsValue51 = FormDriversInfo.GetTagsValue(xmlResultString, "<MatchError>", "</MatchError>");
        if (tagsValue51.Length > 0)
          obj19 = (object) tagsValue51;
      }
    }
    object objectValue1 = RuntimeHelpers.GetObjectValue(DriverUtilityFunctions.GetDriverClassCode(FormDriversInfo.GetTagsValue(xmlResultString, "<CurrentLicense>", "</CurrentLicense>"), "Personal"));
    object objectValue2 = RuntimeHelpers.GetObjectValue(DriverUtilityFunctions.GetDriverClassCode(FormDriversInfo.GetTagsValue(xmlResultString, "<CurrentLicense>", "</CurrentLicense>"), "Commercial"));
    object objectValue3 = RuntimeHelpers.GetObjectValue(DriverUtilityFunctions.GetLicenseOriginalIssueDate(FormDriversInfo.GetTagsValue(xmlResultString, "<CurrentLicense>", "</CurrentLicense>")));
    DefaultDatabase.ExecuteNonQuery("spSaveDriverRequests", new object[50]
    {
      (object) "@DriverID",
      (object) driverID,
      (object) "@RequestData",
      (object) xmlResultString,
      (object) "@RequestControl",
      tagsValue1,
      (object) "@Valid",
      obj1,
      (object) "@ErrorCode",
      obj2,
      (object) "@ErrorDescription",
      obj3,
      (object) "@IsClear",
      obj4,
      (object) "@OrderDate",
      obj10,
      (object) "@CompanyClass",
      obj5,
      (object) "@CompanyScore",
      obj6,
      (object) "@HasSuspensions",
      obj13,
      (object) "@HasMajorViolations",
      obj14,
      (object) "@HasCommercialLicense",
      obj15,
      (object) "@HasCommercialPermit",
      obj16,
      (object) "@PersonalLicenseIssueDate",
      obj8,
      (object) "@CommercialLicenseIssueDate",
      obj7,
      (object) "@ExpirationDate",
      obj9,
      (object) "@DLStatus",
      obj11,
      (object) "@LicenseValidationLookup",
      obj17,
      (object) "@InvoicePath",
      obj12,
      (object) "@DocumentValidationResult",
      obj18,
      (object) "@MatchError",
      obj19,
      (object) "@PersonalClassCode",
      objectValue1,
      (object) "@CommercialClassCode",
      objectValue2,
      (object) "@LicenseOrigIssueDate",
      objectValue3
    });
    DriverUtilityFunctions.SaveViolations(driverID, xmlResultString, true);
    DriverUtilityFunctions.SaveRestrictions(driverID, xmlResultString, true);
    this.AssignViolationPoints(driverID, xmlResultString);
    this.ProcessPolicyWatchOnClient(driverID, xmlResultString);
  }

  protected virtual void AssignViolationPoints(int driverID, string xmlResultString)
  {
    if (MGASystems.Common.Settings.SystemSettings.GetSetting<bool>("Drivers.AssignClientViolationPoints"))
    {
      int totPoints = DriverUtilityFunctions.NumberAssignedPointsLookup(driverID, xmlResultString, true);
      this.UpdateDriverPoints(driverID, totPoints);
    }
    else if (MGASystems.Common.Settings.SystemSettings.GetSetting<bool>("Drivers.AssignSambaViolationPoints"))
    {
      int totPoints = DriverUtilityFunctions.NumberAssignedPointsLookup(driverID, xmlResultString, false);
      this.UpdateDriverPoints(driverID, totPoints);
    }
    else
    {
      if (!MGASystems.Common.Settings.SystemSettings.GetSetting<bool>("Drivers.AssignViolationPoints"))
        return;
      int totPoints = DriverUtilityFunctions.NumberAssignedPoints(driverID, xmlResultString);
      this.UpdateDriverPoints(driverID, totPoints);
    }
  }

  private void UpdateDriverPoints(int driverID, int totPoints)
  {
    DefaultDatabase.ExecuteNonQuery(CommandType.Text, "UPDATE tblDriverInfo SET NumberOfPoints = @NP WHERE DriverID = @ID", new object[4]
    {
      (object) "@ID",
      (object) driverID,
      (object) "@NP",
      (object) totPoints
    });
    if (this.ds.tblDriverInfo.FindByDriverID((long) driverID) == null)
      return;
    this.ds.tblDriverInfo.FindByDriverID((long) driverID).NumberOfPoints = totPoints.ToString();
  }

  private DateTime LicenseDate(string str)
  {
    DateTime dateTime = DateTime.MinValue;
    string openingTag = "<IssueDate>";
    string closingTag = "</IssueDate>";
    string tagsValue1 = FormDriversInfo.GetTagsValue(str, openingTag, closingTag);
    if (tagsValue1.Length > 0)
    {
      string tagsValue2 = FormDriversInfo.GetTagsValue(tagsValue1, "<Year>", "</Year>");
      string tagsValue3 = FormDriversInfo.GetTagsValue(tagsValue1, "<Day>", "</Day>");
      string tagsValue4 = FormDriversInfo.GetTagsValue(tagsValue1, "<Month>", "</Month>");
      dateTime = new DateTime(Conversions.ToInteger(tagsValue2), Conversions.ToInteger(tagsValue4), Conversions.ToInteger(tagsValue3));
    }
    return dateTime;
  }

  public static string GetTagsValue(string xmlString, string openingTag, string closingTag)
  {
    string tagsValue = string.Empty;
    if (xmlString.Contains(openingTag) && xmlString.Contains(closingTag))
    {
      int startIndex = xmlString.IndexOf(openingTag) + openingTag.Length;
      int num = xmlString.IndexOf(closingTag, startIndex);
      tagsValue = xmlString.Substring(startIndex, num - startIndex);
    }
    return tagsValue;
  }

  public static object GetTagsValueObject(string xmlString, string openingTag, string closingTag)
  {
    string str = string.Empty;
    if (xmlString.Contains(openingTag) && xmlString.Contains(closingTag))
    {
      int startIndex = xmlString.IndexOf(openingTag) + openingTag.Length;
      int num = xmlString.IndexOf(closingTag, startIndex);
      str = xmlString.Substring(startIndex, num - startIndex);
    }
    return string.IsNullOrEmpty(str) ? (object) DBNull.Value : (object) str;
  }

  private void ProcessOvernightDriverResultStatus(string xmlResultString, int driverID)
  {
    if (driverID == int.MinValue || xmlResultString.Length == 0 || this._ADRPassStatusID.Value == int.MinValue || this._ADRFailStatusID.Value == int.MinValue)
      return;
    int num = this._ADRFailStatusID.Value;
    string str = "UPDATE tblDriverInfo SET StatusID=@ST, ADRResults = @DR WHERE DriverID=@DID";
    string openingTag1 = "<CompanyClass>";
    string closingTag1 = "</CompanyClass>";
    bool flag1 = false;
    bool flag2 = this.xLicense(driverID, (dsDriverInfo.dtOrderingRow) null);
    if (!flag2 && xmlResultString.Contains(openingTag1) || !xmlResultString.Contains(closingTag1))
    {
      flag1 = true;
      string tagsValue = FormDriversInfo.GetTagsValue(xmlResultString, openingTag1, closingTag1);
      bool flag3 = false;
      try
      {
        foreach (DataRow row in DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT PassValue FROM lstDriverPassResults WITH (NOLOCK)").Rows)
        {
          if (!row.IsNull("PassValue") && row.Field<string>("PassValue").EqualsNoCase(tagsValue))
          {
            flag3 = true;
            break;
          }
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
      if (flag3)
        num = this._ADRPassStatusID.Value;
      else
        this.MarkDriver(driverID);
      if (this.ds.tblDriverInfo.FindByDriverID((long) driverID) != null)
        this.ds.tblDriverInfo.FindByDriverID((long) driverID).StatusID = num;
      DefaultDatabase.ExecuteNonQuery(CommandType.Text, str, new object[6]
      {
        (object) "@ST",
        (object) num,
        (object) "@DR",
        (object) tagsValue,
        (object) "@DID",
        (object) driverID
      });
    }
    if (!flag2 && (flag1 || !this._useVolta))
      return;
    object objectValue = RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT StateID FROM tblDriverInfo WITH (NOLOCK) WHERE DriverID = @ID", new object[2]
    {
      (object) "@ID",
      (object) driverID
    }));
    if (Utility.IsNull(RuntimeHelpers.GetObjectValue(objectValue)) || !DriverUtilityFunctions.IsVolta(objectValue.ToString()))
      return;
    string openingTag2 = "<InvoicePath>";
    string closingTag2 = "</InvoicePath>";
    if (!xmlResultString.Contains(openingTag2) || !xmlResultString.Contains(closingTag2))
      return;
    int minValue = int.MinValue;
    string tagsValue1 = FormDriversInfo.GetTagsValue(xmlResultString, openingTag2, closingTag2);
    if (!flag2)
    {
      if (tagsValue1.ToUpper().Equals("PASS") || tagsValue1.ToUpper().Contains("CLEAN"))
        minValue = this._ADRPassStatusID.Value;
      else if (tagsValue1.ToUpper().Contains("VIOLATIONS") || tagsValue1.ToUpper().Contains("FAIL") || tagsValue1.ToUpper().Contains("ACTIVITY"))
      {
        minValue = this._ADRFailStatusID.Value;
        this.MarkDriver(driverID);
      }
    }
    else if (tagsValue1.ToUpper().Contains("CLEAN"))
      minValue = this._ADRPassStatusID.Value;
    else if (tagsValue1.ToUpper().Contains("ACTIVITY TRIGGERED"))
    {
      minValue = this._ADRFailStatusID.Value;
      this.MarkDriver(driverID);
    }
    if (minValue == int.MinValue)
      return;
    if (this.ds.tblDriverInfo.FindByDriverID((long) driverID) != null)
      this.ds.tblDriverInfo.FindByDriverID((long) driverID).StatusID = minValue;
    DefaultDatabase.ExecuteNonQuery(CommandType.Text, "UPDATE tblDriverInfo SET StatusID=@ST WHERE DriverID=@DID", new object[4]
    {
      (object) "@ST",
      (object) minValue,
      (object) "@DID",
      (object) driverID
    });
  }

  private void ProcessDriverResult(string str, dsDriverInfo.dtOrderingRow row)
  {
    if (str.Equals(string.Empty))
      return;
    string newValue = " <!DOCTYPE html>";
    string oldValue = "<html>";
    str = str.Replace(oldValue, newValue);
    if (!row.IsStateIDNull() && this.IsOvernightState(row.StateID))
    {
      if (this._ADRPassStatusID.Value == int.MinValue || this._ADRFailStatusID.Value == int.MinValue)
        return;
      int num = this._ADRFailStatusID.Value;
      if (str.ToLower().Equals("success") || str.ToLower().Equals("pass"))
      {
        string str1 = "UPDATE tblDriverInfo SET StatusID=@ST, ADRResults = @DR WHERE DriverID=@DID";
        num = this._ADRPassStatusID.Value;
        DefaultDatabase.ExecuteNonQuery(CommandType.Text, str1, new object[6]
        {
          (object) "@ST",
          (object) num,
          (object) "@DR",
          (object) str,
          (object) "@DID",
          (object) row.DriverID
        });
      }
      else
        this.MarkDriver(row.DriverID);
      this.ds.tblDriverInfo.FindByDriverID((long) row.DriverID).StatusID = num;
    }
    else
    {
      try
      {
        this.Cursor = MgaCursors.WaitCursor;
        string str2 = DriverUtilityFunctions.RemoveInvalidCharacters(row.LastName);
        string str3 = DriverUtilityFunctions.RemoveInvalidCharacters(row.FirstName);
        string str4 = string.Empty;
        if (this._includeLicenseNumberInFileName && !row.IsLicenseNumberNull())
          str4 = DriverUtilityFunctions.RemoveInvalidCharacters("-" + row.LicenseNumber);
        string str5 = $"{MGATempFolder.MGATempPath}{str3.Replace(" ", string.Empty)}-{str2.Replace(" ", string.Empty)}{str4.Replace(" ", string.Empty)}-ADR";
        string str6 = $"{str5}.html";
        DriverUtilityFunctions.DeleteFile(str6);
        using (MemoryStream memoryStream = new MemoryStream(Encoding.ASCII.GetBytes(str)))
        {
          byte[] array = memoryStream.ToArray();
          File.WriteAllBytes(str6, array);
        }
        if (this._usePdf)
        {
          string str7 = $"{str5}.pdf";
          DriverUtilityFunctions.DeleteFile(str7);
          new Document(str6).Save(str7, (SaveFormat) 3);
          DriverUtilityFunctions.UploadDriverFile(str7, this.Quote.QuoteGuid);
        }
        else
          DriverUtilityFunctions.UploadDriverFile(str6, this.Quote.QuoteGuid);
      }
      catch (Exception ex1)
      {
        ProjectData.SetProjectError(ex1);
        Exception ex2 = ex1;
        int num = (int) MessageBox.Show(ex2.Message, "File Upload Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        ErrorHandler.SilentHandleError(ex2);
        ProjectData.ClearProjectError();
      }
      finally
      {
        this.Cursor = MgaCursors.Default;
      }
    }
  }

  private void lnkSelectAll_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    this.SetDriverProcessSelection(true);
  }

  private void lnkDeSelectAll_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    this.SetDriverProcessSelection(false);
  }

  private void SetDriverProcessSelection(bool selectionValue)
  {
    try
    {
      foreach (dsDriverInfo.tblDriverInfoRow row in this.ds.tblDriverInfo.Rows)
        row.ADR = (!selectionValue || !this.ExcludeDeletedDrivers.Value || row.IsStatusIDNull() || row.StatusID != this.DeletedStatus.Value) && selectionValue;
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    ((UltraGridBase) this.ugDrivers).UpdateData();
  }

  private void lnkPasswordUpdate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    if (!SecurityManager.Instance.AssertPermission("{89C20FA5-ADC9-4383-AF64-57DB5B17D996}"))
    {
      int num1 = (int) MessageBox.Show("You Do Not have the required security To auto-generate And update ADR password.", "In-sufficient Security", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
    else
    {
      FormAdrPasswordUpdate formEx = (FormAdrPasswordUpdate) ObjectFactory.Instance.CreateFormEX(typeof (FormAdrPasswordUpdate));
      try
      {
        formEx.ControlNo = this._ControlNo;
        formEx.QuoteGuid = this._QuoteGuid;
        int num2 = (int) formEx.ShowDialog();
      }
      finally
      {
        formEx.Dispose();
      }
    }
  }

  public static void DetermineDriverFromHtmlResults(
    string html,
    ref string firstName,
    ref string lastName,
    ref int driverID,
    string driverLicense)
  {
    firstName = string.Empty;
    lastName = string.Empty;
    driverID = int.MinValue;
    driverLicense = driverLicense.Replace(" ", string.Empty);
    DataTable dataTable = DefaultDatabase.ExecuteDataTable("spGetDriverInfo", new object[2]
    {
      (object) "@LicenseNumber",
      (object) driverLicense
    });
    try
    {
      foreach (DataRow row in dataTable.Rows)
      {
        if (row["FirstName"] != DBNull.Value && row["LastName"] != DBNull.Value)
        {
          driverID = Conversions.ToInteger(row["DriverID"]);
          firstName = row["FirstName"].ToString();
          lastName = row["LastName"].ToString();
          break;
        }
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  public static string GetLicenseString(string htmlResult)
  {
    htmlResult = Regex.Replace(htmlResult, "<(.|\\n)*?>", "");
    htmlResult = htmlResult.Replace("\r", "");
    htmlResult = htmlResult.Replace("\n", "");
    htmlResult = htmlResult.Replace("]", "");
    htmlResult = htmlResult.Replace("[", "");
    string str1 = "License:";
    string str2 = "Name:";
    int startIndex1 = htmlResult.IndexOf(str1) + str1.Length;
    int num1 = htmlResult.IndexOf(str2, startIndex1);
    string str3 = htmlResult.Substring(startIndex1, num1 - startIndex1);
    string licenseString;
    if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT DriverID FROM tblDriverInfo WITH (NOLOCK) WHERE LicenseNumber = @LN", new object[2]
    {
      (object) "@LN",
      (object) str3
    })))))
    {
      licenseString = str3;
    }
    else
    {
      string str4 = "License:";
      string str5 = "End Date:";
      int startIndex2 = htmlResult.IndexOf(str4) + str4.Length;
      int num2 = htmlResult.IndexOf(str5, startIndex2);
      if (num2 != -1)
      {
        string str6 = htmlResult.Substring(startIndex2, num2 - startIndex2);
        if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT DriverID FROM tblDriverInfo WITH (NOLOCK) WHERE LicenseNumber = @LN", new object[2]
        {
          (object) "@LN",
          (object) str6
        })))))
        {
          licenseString = str6;
          goto label_14;
        }
      }
      try
      {
        foreach (DataRow row in DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT LicenseNumber FROM tblDriverInfo WITH (NOLOCK)").Rows)
        {
          if (!row.IsNull("LicenseNumber") && htmlResult.Contains($"License:{row.Field<string>("LicenseNumber")}"))
          {
            licenseString = row.Field<string>("LicenseNumber");
            goto label_14;
          }
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
      licenseString = "WOW! X0X0X0X0X0X-CANNOT FIND LICENSE!!";
    }
label_14:
    return licenseString;
  }

  private void lnkOvernightOrders_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    string[] overnightOrders;
    using (ADRConnectWrapper adrConnectWrapper = new ADRConnectWrapper())
      overnightOrders = adrConnectWrapper.ReceiveOvernightOrders();
    if (overnightOrders.Length == 0)
    {
      int num = (int) MessageBox.Show("No driver record received.", "No Records", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    else
    {
      Guid userGuid = CurrentUser.Instance.UserGUID;
      string newValue = " <!DOCTYPE html>";
      string oldValue = "<html>";
      string str1 = "INSERT INTO tblOvernightDriverRecord( UserGuid, DriverRecord, ControlNo) SELECT @UserGuid, @DriverRecord, @ControlNo";
      string str2 = "SELECT ControlNo FROM tblDriverInfo WITH (NOLOCK) WHERE DriverID = @D";
      try
      {
        this.Cursor = MgaCursors.WaitCursor;
        string empty1 = string.Empty;
        string empty2 = string.Empty;
        string empty3 = string.Empty;
        string[] strArray = overnightOrders;
        int index = 0;
        while (index < strArray.Length)
        {
          string str3 = strArray[index];
          string empty4 = string.Empty;
          string empty5 = string.Empty;
          int minValue = int.MinValue;
          string licenseString = FormDriversInfo.GetLicenseString(str3);
          FormDriversInfo.DetermineDriverFromHtmlResults(str3, ref empty4, ref empty5, ref minValue, licenseString);
          if (!string.IsNullOrEmpty(empty4) && !string.IsNullOrEmpty(empty5) && minValue != int.MinValue)
          {
            object objectValue = RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, str2, new object[2]
            {
              (object) "@D",
              (object) minValue
            }));
            if (objectValue != DBNull.Value && objectValue != null)
            {
              string str4 = str3.Replace(oldValue, newValue);
              DefaultDatabase.ExecuteNonQuery(CommandType.Text, str1, new object[6]
              {
                (object) "@UserGuid",
                (object) userGuid,
                (object) "@DriverRecord",
                (object) str4,
                (object) "@ControlNo",
                objectValue
              });
              Quote docSupport = Quote.FromControlNo(Conversions.ToInteger(objectValue));
              this.ProcessOvernightDriverResultStatus(str3, minValue);
              string s = str3.Replace(oldValue, newValue);
              string path = $"{MGATempFolder.MGATempPath}{empty4}-{empty5}-ADR.html";
              if (File.Exists(path))
                File.Delete(path);
              using (MemoryStream memoryStream = new MemoryStream(Encoding.ASCII.GetBytes(s)))
              {
                byte[] array = memoryStream.ToArray();
                File.WriteAllBytes(path, array);
              }
              int? setting = MGASystems.Common.Settings.SystemSettings.GetSetting<int?>("ADRDocumentFolderID");
              if (setting.HasValue)
                DocumentManager.BeginFileAddWithBind(path, setting.Value, (ISupportDocumentSystem) docSupport, string.Empty);
              else
                DocumentManager.BeginFileAddWithBind(path, (ISupportDocumentSystem) docSupport, string.Empty);
            }
          }
          checked { ++index; }
        }
      }
      finally
      {
        this.Cursor = MgaCursors.Default;
      }
    }
  }

  private void btnQuery_Click(object sender, EventArgs e)
  {
    if (((UltraGridBase) this.ugDrivers).ActiveRow == null)
    {
      int num1 = (int) MessageBox.Show("No active row selected.", "No Active Row", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    else if (this.ds.tblDriverInfo[this.bmb.Position].RowState == DataRowState.Added)
    {
      int num2 = (int) MessageBox.Show("Save current row before proceeding.", "Save Current Row", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    else
    {
      using (FormQueryDrivers formQueryDrivers = new FormQueryDrivers(Conversions.ToInteger(((UltraGridBase) this.ugDrivers).ActiveRow.Cells["DriverID"].Value), this._ControlNo))
      {
        int num3 = (int) formQueryDrivers.ShowDialog();
      }
    }
  }

  private void lnkGenerateDocument_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    if (this.cboTemplates.SelectedIndex > -1)
    {
      Cursor.Current = MgaCursors.WaitCursor;
      try
      {
        List<object> driverIDs = new List<object>();
        int templateID = (int) this.cboTemplates.Value;
        try
        {
          foreach (dsDriverInfo.tblDriverInfoRow row in this.ds.tblDriverInfo.Rows)
          {
            if (!row.IsGenerateDocNull() && row.GenerateDoc)
              driverIDs.Add((object) row);
          }
        }
        finally
        {
          IEnumerator enumerator;
          if (enumerator is IDisposable)
            (enumerator as IDisposable).Dispose();
        }
        if (driverIDs.Count > 0)
          ((DocumentHandling) ObjectFactory.Instance.CreateObjectEX(typeof (DocumentHandling), (object) templateID)).CreateDriverDocuments(driverIDs, this._currentQuote.QuoteGuid);
        else if (this._generateGenericTemplate)
        {
          this.AddTemplateDocumentToDocHandler(templateID);
        }
        else
        {
          int num = (int) MessageBox.Show("No drivers selected to generate document", "Driver Template", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
      }
      finally
      {
        Cursor.Current = MgaCursors.Default;
      }
    }
    else
    {
      int num1 = (int) MessageBox.Show("Must select Template to Generate Document", "Driver Template", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
  }

  private void SetDocumentProcessSelection(bool selectionValue)
  {
    try
    {
      foreach (dsDriverInfo.tblDriverInfoRow row in this.ds.tblDriverInfo.Rows)
        row.GenerateDoc = selectionValue;
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    ((UltraGridBase) this.ugDrivers).UpdateData();
  }

  private void LogChanges(dsDriverInfo.tblDriverInfoDataTable dt, DataRowState rs)
  {
    string str1 = rs != DataRowState.Added ? "Modified driver '" : "Added driver '";
    if (!dt[0].IsFirstNameNull())
      str1 += dt[0].FirstName;
    if (!dt[0].IsLastNameNull())
      str1 = $"{str1} {dt[0].LastName}";
    string action = str1 + "'";
    if (!dt[0].IsStateIDNull() && dt[0].StateID.Replace(" ", string.Empty).Length > 0)
      action = $"{action} of {this.ds.lstStates.FindByStateID(dt[0].StateID).State}";
    if (!dt[0].IsLicenseNumberNull())
      action = $"{action} - With lic # {dt[0].LicenseNumber}";
    if (rs == DataRowState.Added)
    {
      CurrentUser.Instance.LogAction(action, this._QuoteGuid);
    }
    else
    {
      string str2 = "<null>";
      try
      {
        foreach (DataColumn column in (InternalDataCollectionBase) dt.Columns)
        {
          if (!column.ColumnName.Equals("ADR") && !column.ColumnName.Equals("GenerateDoc"))
          {
            string str3 = str2;
            string str4 = str2;
            string str5 = column.ColumnName;
            switch (str5)
            {
              case "FullPartTime":
                str5 = "Full or Part Time";
                break;
              case "StatusID":
                str5 = "Driver Status";
                break;
            }
            if (dt[0][column.ColumnName, DataRowVersion.Original] != DBNull.Value)
              str3 = dt[0][column.ColumnName, DataRowVersion.Original].ToString();
            if (dt[0][column.ColumnName, DataRowVersion.Current] != DBNull.Value)
              str4 = dt[0][column.ColumnName, DataRowVersion.Current].ToString();
            if (!str3.Equals(str4))
            {
              if (column.ColumnName.Equals("FullPartTime"))
              {
                if (str3.Equals("0"))
                  str3 = str2;
                else if (!str3.Equals(str2))
                  str3 = this.ds.lstDriverStatusInfo.FindByID(Conversions.ToByte(str3)).Status;
                if (!str4.Equals(str2))
                  str4 = this.ds.lstDriverStatusInfo.FindByID(Conversions.ToByte(str4)).Status;
              }
              else if (column.ColumnName.Equals("StatusID"))
              {
                if (!str3.Equals(str2))
                  str3 = this.ds.lstDriverStatus.FindByDriverStatusID(Conversions.ToInteger(str3)).Status;
                if (!str4.Equals(str2))
                  str4 = this.ds.lstDriverStatus.FindByDriverStatusID(Conversions.ToInteger(str4)).Status;
              }
              CurrentUser.Instance.LogAction($"{action}. - Changed {str5} from '{str3}' to '{str4}'", this._QuoteGuid);
            }
          }
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
    }
  }

  private void btnProcessOvernightOrders_Click(object sender, EventArgs e)
  {
    int num1 = (int) MessageBox.Show("Remember to first retrieve overnight orders by clicking on the link \n\n'ADR - Receive Overnight Orders ...'", "Remember to Retrieve Overnight Orders", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    this.Cursor = MgaCursors.WaitCursor;
    FormOvernigtOrders formEx = (FormOvernigtOrders) ObjectFactory.Instance.CreateFormEX(typeof (FormOvernigtOrders), (object) this._ControlNo);
    try
    {
      formEx.ShowInTaskbar = false;
      formEx.StartPosition = FormStartPosition.CenterScreen;
      this.Cursor = MgaCursors.Default;
      int num2 = (int) formEx.ShowDialog();
    }
    finally
    {
      this.Cursor = MgaCursors.Default;
      formEx.Dispose();
    }
  }

  private void ComboDriverStatus_InitializeRow(object sender, InitializeRowEventArgs e)
  {
    if (e.Row.Cells["Inactive"].Value == DBNull.Value || !Conversions.ToBoolean(e.Row.Cells["Inactive"].Value))
      return;
    e.Row.Hidden = true;
  }

  private string DebugTestString()
  {
    return "<Record>\r\n\t<DlRecord>\r\n\t\t<Criteria>\r\n\t\t\t<OrderDate>\r\n\t\t\t\t<Year>2019</Year>\r\n\t\t\t\t<Month>7</Month>\r\n\t\t\t\t<Day>23</Day>\r\n\t\t\t</OrderDate>\r\n\t\t\t<OrderTime>\r\n\t\t\t\t<Hour>8</Hour>\r\n\t\t\t\t<Minute>18</Minute>\r\n\t\t\t\t<Second>0</Second>\r\n\t\t\t</OrderTime>\r\n\t\t\t<AccountID>K1191</AccountID>\r\n\t\t\t<UserID>K119101</UserID>\r\n\t\t\t<Routing>LILO</Routing>\r\n\t\t\t<Purpose>AA</Purpose>\r\n\t\t\t<TrackingNumber>000000</TrackingNumber>\r\n\t\t\t<Host>OL</Host>\r\n\t\t\t<ProductID>JX</ProductID>\r\n\t\t\t<State>\r\n\t\t\t\t<Abbrev>WI</Abbrev>\r\n\t\t\t\t<Full>WISCONSIN</Full>\r\n\t\t\t</State>\r\n\t\t\t<Subtype>ST</Subtype>\r\n\t\t\t<SubtypeFull>JUDICIAL LOOKBACK</SubtypeFull>\r\n\t\t\t<FirstName>HEATHER</FirstName>\r\n\t\t\t<LastName>SAMUEL</LastName>\r\n\t\t\t<BirthDate>\r\n\t\t\t\t<Year>2010</Year>\r\n\t\t\t\t<Month>3</Month>\r\n\t\t\t\t<Day>30</Day>\r\n\t\t\t</BirthDate>\r\n\t\t\t<LicenseNumber>X2019400000001</LicenseNumber>\r\n\t\t</Criteria>\r\n\t\t<Result>\r\n\t\t\t<Control>040ZO5</Control>\r\n\t\t\t<Valid>Y</Valid>\r\n\t\t\t<ReturnedDate>\r\n\t\t\t\t<Year>2019</Year>\r\n\t\t\t\t<Month>7</Month>\r\n\t\t\t\t<Day>23</Day>\r\n\t\t\t</ReturnedDate>\r\n\t\t\t<ReturnedTime>\r\n\t\t\t\t<Hour>8</Hour>\r\n\t\t\t\t<Minute>18</Minute>\r\n\t\t\t\t<Second>0</Second>\r\n\t\t\t</ReturnedTime>\r\n\t\t\t<CompanyClass>pass</CompanyClass>\r\n\t\t\t<CompanyScore>15</CompanyScore>\r\n\t\t\t<IsClear>N</IsClear>\r\n\t\t\t<InvoicePath>ON DEMAND</InvoicePath>\r\n\t\t</Result>\r\n\t\t<Driver>\r\n\t\t\t<FirstName>HEATHER</FirstName>\r\n\t\t\t<LastName>SAMUEL</LastName>\r\n\t\t</Driver>\r\n\t\t<CurrentLicense>\r\n\t\t\t<Personal>\r\n\t\t\t\t<Type>PERSONAL</Type>\r\n\t\t\t\t<ClassDescription>PROBATIONARY</ClassDescription>\r\n\t\t\t\t<ClassCode>D</ClassCode>\r\n\t\t\t\t<IssueDate>\r\n\t\t\t\t\t<Year>2019</Year>\r\n\t\t\t\t\t<Month>3</Month>\r\n\t\t\t\t\t<Day>13</Day>\r\n\t\t\t\t</IssueDate>\r\n\t\t\t\t<ExpirationDate>\r\n\t\t\t\t\t<Year>2021</Year>\r\n\t\t\t\t\t<Month>2</Month>\r\n\t\t\t\t\t<Day>25</Day>\r\n\t\t\t\t</ExpirationDate>\r\n\t\t\t\t<StatusList>\r\n\t\t\t\t\t<StatusItem>\r\n\t\t\t\t\t\t<Name>INVALID</Name>\r\n\t\t\t\t\t</StatusItem>\r\n\t\t\t\t</StatusList>\r\n\t\t\t</Personal>\r\n\t\t\t<Commercial>\r\n\t\t\t\t<Type>COMMERCIAL</Type>\r\n\t\t\t\t<ClassDescription>REGULAR LICENSE</ClassDescription>\r\n\t\t\t\t<ClassCode>A</ClassCode>\r\n\t\t\t\t<IssueDate>\r\n\t\t\t\t\t<Year>2019</Year>\r\n\t\t\t\t\t<Month>4</Month>\r\n\t\t\t\t\t<Day>27</Day>\r\n\t\t\t\t</IssueDate>\r\n\t\t\t\t<ExpirationDate>\r\n\t\t\t\t\t<Year>2021</Year>\r\n\t\t\t\t\t<Month>2</Month>\r\n\t\t\t\t\t<Day>25</Day>\r\n\t\t\t\t</ExpirationDate>\r\n\t\t\t\t<StatusList>\r\n\t\t\t\t\t<StatusItem>\r\n\t\t\t\t\t\t<Name>VALID</Name>\r\n\t\t\t\t\t</StatusItem>\r\n\t\t\t\t</StatusList>\r\n\t\t\t\t<RestrictionList>\r\n\t\t\t\t\t<RestrictionItem>\r\n\t\t\t\t\t\t<Name>NO MANUAL TRANS EQUIP CMV</Name>\r\n\t\t\t\t\t</RestrictionItem>\r\n\t\t\t\t</RestrictionList>\r\n\t\t\t</Commercial>\r\n\t\t\t<Number>J2019400000001</Number>\r\n\t\t\t<ExactOriginalIssueDate>\r\n\t\t\t\t<Year>2019</Year>\r\n\t\t\t\t<Month>3</Month>\r\n\t\t\t\t<Day>16</Day>\r\n\t\t\t</ExactOriginalIssueDate>\r\n\t\t\t<PermitList>\r\n\t\t\t\t<PermitItem>\r\n\t\t\t\t\t<Type>COMMERCIAL PERMIT</Type>\r\n\t\t\t\t\t<ClassDescription>COMMERCIAL INSTRUCTION PERMIT</ClassDescription>\r\n\t\t\t\t\t<ClassCode>A</ClassCode>\r\n\t\t\t\t\t<IssueDate>\r\n\t\t\t\t\t\t<Year>2019</Year>\r\n\t\t\t\t\t\t<Month>3</Month>\r\n\t\t\t\t\t\t<Day>16</Day>\r\n\t\t\t\t\t</IssueDate>\r\n\t\t\t\t\t<ExpirationDate>\r\n\t\t\t\t\t\t<Year>2019</Year>\r\n\t\t\t\t\t\t<Month>9</Month>\r\n\t\t\t\t\t\t<Day>12</Day>\r\n\t\t\t\t\t</ExpirationDate>\r\n\t\t\t\t\t<StatusList>\r\n\t\t\t\t\t\t<StatusItem>\r\n\t\t\t\t\t\t\t<Name>VALID</Name>\r\n\t\t\t\t\t\t</StatusItem>\r\n\t\t\t\t\t</StatusList>\r\n\t\t\t\t\t<RestrictionList>\r\n\t\t\t\t\t\t<RestrictionItem>\r\n\t\t\t\t\t\t\t<Name>INVALID UNLESS ACCOMPANIED BY A VALID WI DRIVER LICENSE</Name>\r\n\t\t\t\t\t\t</RestrictionItem>\r\n\t\t\t\t\t\t<RestrictionItem>\r\n\t\t\t\t\t\t\t<Name>OTHER: ACCOMPANIED BY INSTRUCTOR OR PERSON OVER 21 W/LIC AUTHORIZING VEH OPERATION WITH</Name>\r\n\t\t\t\t\t\t</RestrictionItem>\r\n\t\t\t\t\t\t<RestrictionItem>\r\n\t\t\t\t\t\t\t<Name>PROPER CLS &amp; EDT</Name>\r\n\t\t\t\t\t\t</RestrictionItem>\r\n\t\t\t\t\t\t<RestrictionItem>\r\n\t\t\t\t\t\t\t<Name>NO PASSENGERS WITHOUT INSTRUCTOR</Name>\r\n\t\t\t\t\t\t</RestrictionItem>\r\n\t\t\t\t\t</RestrictionList>\r\n\t\t\t\t</PermitItem>\r\n\t\t\t\t<PermitItem>\r\n\t\t\t\t\t<Type>PERMIT</Type>\r\n\t\t\t\t\t<ClassDescription>INSTRUCTION PERMIT</ClassDescription>\r\n\t\t\t\t\t<ClassCode>D</ClassCode>\r\n\t\t\t\t\t<IssueDate>\r\n\t\t\t\t\t\t<Year>2018</Year>\r\n\t\t\t\t\t\t<Month>8</Month>\r\n\t\t\t\t\t\t<Day>27</Day>\r\n\t\t\t\t\t</IssueDate>\r\n\t\t\t\t\t<ExpirationDate>\r\n\t\t\t\t\t\t<Year>2019</Year>\r\n\t\t\t\t\t\t<Month>8</Month>\r\n\t\t\t\t\t\t<Day>27</Day>\r\n\t\t\t\t\t</ExpirationDate>\r\n\t\t\t\t\t<StatusList>\r\n\t\t\t\t\t\t<StatusItem>\r\n\t\t\t\t\t\t\t<Name>INVALID</Name>\r\n\t\t\t\t\t\t</StatusItem>\r\n\t\t\t\t\t</StatusList>\r\n\t\t\t\t\t<RestrictionList>\r\n\t\t\t\t\t\t<RestrictionItem>\r\n\t\t\t\t\t\t\t<Name>OTHER: PERSON SEATED BESIDE OPERATOR HOLDS VALID REG LIC AND IS: INSTRUCTOR, PARENT,</Name>\r\n\t\t\t\t\t\t</RestrictionItem>\r\n\t\t\t\t\t\t<RestrictionItem>\r\n\t\t\t\t\t\t\t<Name>GUARDIAN, SPOUSE OVER 19</Name>\r\n\t\t\t\t\t\t</RestrictionItem>\r\n\t\t\t\t\t\t<RestrictionItem>\r\n\t\t\t\t\t\t\t<Name>FAMILY MEMBER ONLY IN FRONT SEAT</Name>\r\n\t\t\t\t\t\t</RestrictionItem>\r\n\t\t\t\t\t\t<RestrictionItem>\r\n\t\t\t\t\t\t\t<Name>DR UNDER 18, PARENT OR GUARDIAN MUST DESG DR &gt;21</Name>\r\n\t\t\t\t\t\t</RestrictionItem>\r\n\t\t\t\t\t</RestrictionList>\r\n\t\t\t\t</PermitItem>\r\n\t\t\t</PermitList>\r\n\t\t</CurrentLicense>\r\n\t\t<MedicalCertificateList>\r\n\t\t\t<MedicalCertificateItem>\r\n\t\t\t\t<Status>CERTIFIED</Status>\r\n\t\t\t\t<ExpirationDate>\r\n\t\t\t\t\t<Year>2021</Year>\r\n\t\t\t\t\t<Month>3</Month>\r\n\t\t\t\t\t<Day>15</Day>\r\n\t\t\t\t</ExpirationDate>\r\n\t\t\t\t<IssueDate>\r\n\t\t\t\t\t<Year>2019</Year>\r\n\t\t\t\t\t<Month>3</Month>\r\n\t\t\t\t\t<Day>15</Day>\r\n\t\t\t\t</IssueDate>\r\n\t\t\t\t<Examiner>\r\n\t\t\t\t\t<First>SARA</First>\r\n\t\t\t\t\t<Last>VANDERBURGH</Last>\r\n\t\t\t\t\t<License>4231-23</License>\r\n\t\t\t\t\t<LicenseState>\r\n\t\t\t\t\t\t<Abbrev>WI</Abbrev>\r\n\t\t\t\t\t\t<Full>WISCONSIN</Full>\r\n\t\t\t\t\t</LicenseState>\r\n\t\t\t\t\t<RegistrationNumber>7607982866</RegistrationNumber>\r\n\t\t\t\t\t<Phone>(414)885-0456</Phone>\r\n\t\t\t\t\t<SpecialtyDescription>PHYSICIAN ASSISTANT</SpecialtyDescription>\r\n\t\t\t\t</Examiner>\r\n\t\t\t\t<SelfCertification>\r\n\t\t\t\t\t<Type>NON-EXCEPTED INTERSTATE</Type>\r\n\t\t\t\t</SelfCertification>\r\n\t\t\t</MedicalCertificateItem>\r\n\t\t</MedicalCertificateList>\r\n\t\t<MessageList>\r\n\t\t\t<MessageItem>\r\n\t\t\t\t<Line>invoice path</Line>\r\n\t\t\t</MessageItem>\r\n\t\t</MessageList>\r\n\t\t<EventList>\r\n\t\t\t<EventItem>\r\n\t\t\t\t<Common>\r\n\t\t\t\t\t<Subtype>VIOL</Subtype>\r\n\t\t\t\t\t<State>\r\n\t\t\t\t\t\t<Abbrev>WI</Abbrev>\r\n\t\t\t\t\t\t<Full>WISCONSIN</Full>\r\n\t\t\t\t\t</State>\r\n\t\t\t\t\t<Date>\r\n\t\t\t\t\t\t<Year>2019</Year>\r\n\t\t\t\t\t\t<Month>1</Month>\r\n\t\t\t\t\t\t<Day>3</Day>\r\n\t\t\t\t\t</Date>\r\n\t\t\t\t\t<Location>DANE COUNTY CIRCUIT COURT</Location>\r\n\t\t\t\t\t<DocketNumber>2222TT222222</DocketNumber>\r\n\t\t\t\t</Common>\r\n\t\t\t\t<NoteList>\r\n\t\t\t\t\t<NoteItem>\r\n\t\t\t\t\t\t<Note>CITATION NUMBER: BC649480-6</Note>\r\n\t\t\t\t\t</NoteItem>\r\n\t\t\t\t</NoteList>\r\n\t\t\t\t<DescriptionList>\r\n\t\t\t\t\t<DescriptionItem>\r\n\t\t\t\t\t\t<AdrLargeDescription>COMPULSORY INSURANCE - NO PROOF</AdrLargeDescription>\r\n\t\t\t\t\t\t<AdrSmallDescription>COMPULSORY INSURANCE - NO PROOF</AdrSmallDescription>\r\n\t\t\t\t\t\t<StateDescription>CNP-COMPULSORY INSURANCE - NO PROOF</StateDescription>\r\n\t\t\t\t\t\t<StateCode>344.62(2)</StateCode>\r\n\t\t\t\t\t\t<Acd>-</Acd>\r\n\t\t\t\t\t\t<Avd1>DE03</Avd1>\r\n\t\t\t\t\t\t<Avd2>DE03</Avd2>\r\n\t\t\t\t\t\t<Avd3>DE03</Avd3>\r\n\t\t\t\t\t\t<CompanyCode>MINOR</CompanyCode>\r\n\t\t\t\t\t\t<StateAssignedPoints>0</StateAssignedPoints>\r\n\t\t\t\t\t\t<TableKey>WIA02COMPULSORY INSURANCE - NO PROOF</TableKey>\r\n\t\t\t\t\t</DescriptionItem>\r\n\t\t\t\t</DescriptionList>\r\n\t\t\t\t<Violation>\r\n\t\t\t\t\t<ConvictionDate>\r\n\t\t\t\t\t\t<Year>2019</Year>\r\n\t\t\t\t\t\t<Month>2</Month>\r\n\t\t\t\t\t\t<Day>11</Day>\r\n\t\t\t\t\t</ConvictionDate>\r\n\t\t\t\t\t<Disposition>GUILTY</Disposition>\r\n\t\t\t\t</Violation>\r\n\t\t\t</EventItem>\r\n\t\t\t<EventItem>\r\n\t\t\t\t<Common>\r\n\t\t\t\t\t<Subtype>VIOL</Subtype>\r\n\t\t\t\t\t<State>\r\n\t\t\t\t\t\t<Abbrev>WI</Abbrev>\r\n\t\t\t\t\t\t<Full>WISCONSIN</Full>\r\n\t\t\t\t\t</State>\r\n\t\t\t\t\t<Date>\r\n\t\t\t\t\t\t<Year>2019</Year>\r\n\t\t\t\t\t\t<Month>1</Month>\r\n\t\t\t\t\t\t<Day>3</Day>\r\n\t\t\t\t\t</Date>\r\n\t\t\t\t\t<Location>DANE COUNTY CIRCUIT COURT</Location>\r\n\t\t\t\t\t<DocketNumber>2222TT222222</DocketNumber>\r\n\t\t\t\t</Common>\r\n\t\t\t\t<NoteList>\r\n\t\t\t\t\t<NoteItem>\r\n\t\t\t\t\t\t<Note>CITATION NUMBER: BC649479-5</Note>\r\n\t\t\t\t\t</NoteItem>\r\n\t\t\t\t</NoteList>\r\n\t\t\t\t<DescriptionList>\r\n\t\t\t\t\t<DescriptionItem>\r\n\t\t\t\t\t\t<AdrLargeDescription>SPEEDING EXCESS (20 OR MORE OVER)</AdrLargeDescription>\r\n\t\t\t\t\t\t<AdrSmallDescription>SPEEDING EXCESS (20 OR MORE OVER)</AdrSmallDescription>\r\n\t\t\t\t\t\t<StateDescription>SE-SPEEDING EXCESS (20 OR MORE OVER) POSTED 070 OVER 035</StateDescription>\r\n\t\t\t\t\t\t<StateCode>SE</StateCode>\r\n\t\t\t\t\t\t<Acd>S92</Acd>\r\n\t\t\t\t\t\t<Avd1>SA12</Avd1>\r\n\t\t\t\t\t\t<Avd2>SB06</Avd2>\r\n\t\t\t\t\t\t<Avd3>SA12</Avd3>\r\n\t\t\t\t\t\t<CompanyCode>MAJOR</CompanyCode>\r\n\t\t\t\t\t\t<StateAssignedPoints>6</StateAssignedPoints>\r\n\t\t\t\t\t\t<TableKey>WIA02SPEEDING EXCESS (20 OR MORE OVER)</TableKey>\r\n\t\t\t\t\t</DescriptionItem>\r\n\t\t\t\t</DescriptionList>\r\n\t\t\t\t<Violation>\r\n\t\t\t\t\t<ConvictionDate>\r\n\t\t\t\t\t\t<Year>2019</Year>\r\n\t\t\t\t\t\t<Month>2</Month>\r\n\t\t\t\t\t\t<Day>11</Day>\r\n\t\t\t\t\t</ConvictionDate>\r\n\t\t\t\t\t<ActualSpeed>105</ActualSpeed>\r\n\t\t\t\t\t<PostedSpeed>70</PostedSpeed>\r\n\t\t\t\t\t<Disposition>GUILTY</Disposition>\r\n\t\t\t\t</Violation>\r\n\t\t\t</EventItem>\r\n\t\t\t<EventItem>\r\n\t\t\t\t<Common>\r\n\t\t\t\t\t<Subtype>SUSPENSION</Subtype>\r\n\t\t\t\t\t<State>\r\n\t\t\t\t\t\t<Abbrev>WI</Abbrev>\r\n\t\t\t\t\t\t<Full>WISCONSIN</Full>\r\n\t\t\t\t\t</State>\r\n\t\t\t\t\t<Date>\r\n\t\t\t\t\t\t<Year>2019</Year>\r\n\t\t\t\t\t\t<Month>2</Month>\r\n\t\t\t\t\t\t<Day>13</Day>\r\n\t\t\t\t\t</Date>\r\n\t\t\t\t\t<DocketNumber>S273980</DocketNumber>\r\n\t\t\t\t</Common>\r\n\t\t\t\t<DescriptionList>\r\n\t\t\t\t\t<DescriptionItem>\r\n\t\t\t\t\t\t<AdrLargeDescription>SPEEDING EXCESS (20 OR MORE OVER)</AdrLargeDescription>\r\n\t\t\t\t\t\t<AdrSmallDescription>SPEEDING EXCESS (20 OR MORE OVER)</AdrSmallDescription>\r\n\t\t\t\t\t\t<StateDescription>SPEEDING EXCESS (20 OR MORE OVER)</StateDescription>\r\n\t\t\t\t\t\t<StateCode>SE</StateCode>\r\n\t\t\t\t\t\t<Acd>S92</Acd>\r\n\t\t\t\t\t\t<Avd1>SA12</Avd1>\r\n\t\t\t\t\t\t<Avd2>SA12</Avd2>\r\n\t\t\t\t\t\t<Avd3>SA12</Avd3>\r\n\t\t\t\t\t\t<TableKey>WIA02SPEEDING EXCESS (20 OR MORE OVER)</TableKey>\r\n\t\t\t\t\t</DescriptionItem>\r\n\t\t\t\t</DescriptionList>\r\n\t\t\t\t<Action>\r\n\t\t\t\t\t<ClearDate>\r\n\t\t\t\t\t\t<Year>2019</Year>\r\n\t\t\t\t\t\t<Month>3</Month>\r\n\t\t\t\t\t\t<Day>13</Day>\r\n\t\t\t\t\t</ClearDate>\r\n\t\t\t\t\t<ActionEndDate>\r\n\t\t\t\t\t\t<Year>2019</Year>\r\n\t\t\t\t\t\t<Month>3</Month>\r\n\t\t\t\t\t\t<Day>1</Day>\r\n\t\t\t\t\t</ActionEndDate>\r\n\t\t\t\t\t<MailDate>\r\n\t\t\t\t\t\t<Year>2019</Year>\r\n\t\t\t\t\t\t<Month>2</Month>\r\n\t\t\t\t\t\t<Day>13</Day>\r\n\t\t\t\t\t</MailDate>\r\n\t\t\t\t</Action>\r\n\t\t\t</EventItem>\r\n\t\t</EventList>\r\n\t</DlRecord>\r\n</Record>";
  }

  protected virtual void ProcessPolicyWatchOnClient(int driverID, string orderXml)
  {
  }

  protected virtual void BeforeDataLoad()
  {
  }

  protected virtual void ActivateActiveGridRow()
  {
    this.ugDrivers_AfterRowActivate((object) null, EventArgs.Empty);
  }

  protected virtual void ugDrivers_InitializeRowOnClient(object sender, InitializeRowEventArgs e)
  {
  }

  protected virtual string GetReference(int driverID) => string.Empty;

  private void AddTemplateDocumentToDocHandler(int templateID)
  {
    DataRow dataRow = DefaultDatabase.ExecuteDataRow(CommandType.Text, "SELECT Template, TemplateName, Description, FolderID, SaveAsType FROM tblDocumentTemplates WHERE TemplateID=@ID", new object[2]
    {
      (object) "@ID",
      (object) templateID
    });
    string str = ".doc";
    if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(dataRow["SaveAsType"])))
    {
      string Left = dataRow["SaveAsType"].ToString();
      str = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "P", false) == 0 ? ".pdf" : (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "W", false) == 0 ? ".doc" : (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "E", false) == 0 ? ".xlsx" : ".doc"));
    }
    string path = $"{MGATempFolder.MGATempPath}{dataRow["TemplateName"].ToString()}{str}";
    File.WriteAllBytes(path, (byte[]) dataRow["Template"]);
    int folderId = -1;
    if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(dataRow["FolderID"])))
      folderId = Convert.ToInt32(RuntimeHelpers.GetObjectValue(dataRow["FolderID"]));
    DocumentManager.BeginFileAddWithBind(path, folderId, (ISupportDocumentSystem) this.Quote);
  }

  private void btnIIX_Click(object sender, EventArgs e)
  {
    using (FormIxOrdering formIxOrdering = FormSettings.ShowFormDialog<FormIxOrdering>((object) this._ControlNo, (object) this._QuoteGuid, (object) this.ds))
    {
      if (!formIxOrdering.ContinueProcess)
        return;
      this.ProcessIixDrivers(formIxOrdering.ProcessTable, formIxOrdering.ReportFormat);
    }
  }

  protected void SetSearchPanelVisible(bool show)
  {
    ((Control) this.panelProcessingADR).Visible = show;
    if (show)
      ((Control) this.panelProcessingADR).BringToFront();
    else
      ((Control) this.panelProcessingADR).SendToBack();
  }

  protected void SetSearchLabelText(string labelText) => this.labelSearchText.Text = labelText;

  protected virtual void ProcessIixDrivers(
    dsDriverInfo.dtIIXDataTable processTable,
    string resultFormat)
  {
    // ISSUE: variable of a compiler-generated type
    FormDriversInfo._Closure\u0024__670\u002D1 closure6701_1;
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    FormDriversInfo._Closure\u0024__670\u002D1 closure6701_2 = new FormDriversInfo._Closure\u0024__670\u002D1(closure6701_1);
    // ISSUE: reference to a compiler-generated field
    closure6701_2.\u0024VB\u0024Me = this;
    // ISSUE: reference to a compiler-generated field
    closure6701_2.\u0024VB\u0024Local_processTable = processTable;
    // ISSUE: reference to a compiler-generated field
    closure6701_2.\u0024VB\u0024Local_resultFormat = resultFormat;
    // ISSUE: reference to a compiler-generated field
    if (closure6701_2.\u0024VB\u0024Local_processTable == null)
      return;
    // ISSUE: reference to a compiler-generated field
    if (closure6701_2.\u0024VB\u0024Local_processTable.Count == 0)
      return;
    try
    {
      // ISSUE: variable of a compiler-generated type
      FormDriversInfo._Closure\u0024__670\u002D0 closure6700_1;
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      FormDriversInfo._Closure\u0024__670\u002D0 closure6700_2 = new FormDriversInfo._Closure\u0024__670\u002D0(closure6700_1);
      // ISSUE: reference to a compiler-generated field
      closure6700_2.\u0024VB\u0024NonLocal_\u0024VB\u0024Closure_2 = closure6701_2;
      // ISSUE: reference to a compiler-generated field
      closure6700_2.\u0024VB\u0024Local_requestData = (string) null;
      // ISSUE: reference to a compiler-generated field
      closure6700_2.\u0024VB\u0024Local_responseData = (string) null;
      (string, string, string, string, string) valueTuple = (MGASystems.Common.Settings.SystemSettings.GetSetting<string>("IIXurl"), MGASystems.Common.Settings.SystemSettings.GetSetting<string>("IIXUserName"), MGASystems.Common.Settings.SystemSettings.GetSetting<string>("IIXPassword"), MGASystems.Common.Settings.SystemSettings.GetSetting<string>("IIXBillingCode"), MGASystems.Common.Settings.SystemSettings.GetSetting<string>("IIXAccountID"));
      if (((IEnumerable<string>) new string[4]
      {
        valueTuple.Item1,
        valueTuple.Item2,
        valueTuple.Item3,
        valueTuple.Item4
      }).Any<string>(new System.Func<string, bool>(string.IsNullOrEmpty)))
        throw new InvalidOperationException("IIX Service is missing credentials - Username, Password, URL and Bill Code required.");
      // ISSUE: reference to a compiler-generated field
      closure6700_2.\u0024VB\u0024Local_updateProgress = (IProgress<string>) new Progress<string>(new Action<string>(this.SetSearchLabelText));
      // ISSUE: variable of a compiler-generated type
      FormDriversInfo._Closure\u0024__670\u002D0 closure6700_3 = closure6700_2;
      Action<string> handler;
      // ISSUE: reference to a compiler-generated field
      if (FormDriversInfo._Closure\u0024__.\u0024I670\u002D0 != null)
      {
        // ISSUE: reference to a compiler-generated field
        handler = FormDriversInfo._Closure\u0024__.\u0024I670\u002D0;
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        FormDriversInfo._Closure\u0024__.\u0024I670\u002D0 = handler = (Action<string>) ([SpecialName] (progress) => MDIControls.Instance.StatusBarText = progress);
      }
      Progress<string> progress1 = new Progress<string>(handler);
      // ISSUE: reference to a compiler-generated field
      closure6700_3.\u0024VB\u0024Local_updateStatusbar = (IProgress<string>) progress1;
      IProgress<Exception> errorHandlingAction = (IProgress<Exception>) new Progress<Exception>(new Action<Exception>(ErrorHandler.SilentHandleError));
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      closure6700_2.\u0024VB\u0024Local_veriskClient = new MvrController(valueTuple.Item1, closure6700_2.\u0024VB\u0024Local_updateStatusbar, errorHandlingAction).SetRequestStringListener(new SoapServiceBase<MvrController, SoapAuthPortType, SoapAuthPortTypeClient>.MethodAndDataHandler(closure6700_2._Lambda\u0024__1)).SetResponseStringListener(new SoapServiceBase<MvrController, SoapAuthPortType, SoapAuthPortTypeClient>.MethodAndDataHandler(closure6700_2._Lambda\u0024__2)).SetDefaultCredentials(valueTuple.Item2, valueTuple.Item3, valueTuple.Item5, valueTuple.Item4);
      this.SetSearchPanelVisible(true);
      // ISSUE: reference to a compiler-generated method
      Task.Run(new Func<Task>(closure6700_2._Lambda\u0024__3)).ContinueWith((Action<Task>) ([SpecialName] (discard) => this.SetSearchPanelVisible(false)), TaskScheduler.FromCurrentSynchronizationContext());
    }
    catch (AggregateException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      ErrorHandler.HandleError((Exception) ex.Flatten());
      ProjectData.ClearProjectError();
    }
  }

  protected static string GetResponseError(CombinedResponse mvrResponse)
  {
    BaseResponse[] baseResponseArray = new BaseResponse[3]
    {
      (BaseResponse) mvrResponse.ReportResponse,
      (BaseResponse) mvrResponse.PdfResponse,
      (BaseResponse) mvrResponse.XmlResponse
    };
    int index = 0;
    string responseError;
    while (index < baseResponseArray.Length)
    {
      BaseResponse baseResponse = baseResponseArray[index];
      if ((baseResponse != null ? (baseResponse.IsErrorResponse ? 1 : 0) : 0) != 0)
      {
        responseError = baseResponse.CreateException?.Message ?? baseResponse.ResponseDescription;
        goto label_6;
      }
      checked { ++index; }
    }
    responseError = string.Empty;
label_6:
    return responseError;
  }

  private static DateTime DisplayDates(string dateStr)
  {
    if (dateStr.Length == 7)
      dateStr = "0" + dateStr;
    int int32_1 = Convert.ToInt32(dateStr.Substring(0, 2));
    int int32_2 = Convert.ToInt32(dateStr.Substring(2, 2));
    return new DateTime(Convert.ToInt32(dateStr.Substring(4, 4)), int32_1, int32_2);
  }

  private void SaveIIXResponse(
    int driverID,
    string iiXml,
    string iiPDF,
    string reqData,
    string responseData,
    bool validReq,
    string errMess)
  {
    object tagsValue1 = (object) DBNull.Value;
    object tagsValue2 = (object) DBNull.Value;
    object tagsValue3 = (object) DBNull.Value;
    object tagsValue4 = (object) DBNull.Value;
    object tagsValue5 = (object) DBNull.Value;
    object tagsValue6 = (object) DBNull.Value;
    object obj1 = (object) DBNull.Value;
    object obj2 = (object) DBNull.Value;
    object tagsValue7 = (object) DBNull.Value;
    object tagsValue8 = (object) DBNull.Value;
    object tagsValue9 = (object) DBNull.Value;
    object tagsValue10 = (object) DBNull.Value;
    object tagsValue11 = (object) DBNull.Value;
    object tagsValue12 = (object) DBNull.Value;
    object tagsValue13 = (object) DBNull.Value;
    object tagsValue14 = (object) DBNull.Value;
    object tagsValue15 = (object) DBNull.Value;
    object tagsValue16 = (object) DBNull.Value;
    object tagsValue17 = (object) DBNull.Value;
    object tagsValue18 = (object) DBNull.Value;
    object tagsValue19 = (object) DBNull.Value;
    object tagsValue20 = (object) DBNull.Value;
    object tagsValue21 = (object) DBNull.Value;
    object tagsValue22 = (object) DBNull.Value;
    object tagsValue23 = (object) DBNull.Value;
    if (!string.IsNullOrEmpty(iiXml))
    {
      tagsValue1 = (object) FormDriversInfo.GetTagsValue(iiXml, "<MVRStatus>", "</MVRStatus>");
      tagsValue2 = (object) FormDriversInfo.GetTagsValue(iiXml, "<AssignedPoints>", "</AssignedPoints>");
      tagsValue3 = (object) FormDriversInfo.GetTagsValue(iiXml, "<RequestID>", "</RequestID>");
      tagsValue4 = (object) FormDriversInfo.GetTagsValue(iiXml, "<ReportID>", "</ReportID>");
      tagsValue5 = (object) FormDriversInfo.GetTagsValue(iiXml, "<ViolationCoding>", "</ViolationCoding>");
      tagsValue6 = (object) FormDriversInfo.GetTagsValue(iiXml, "<ViolationCodeTotal>", "</ViolationCodeTotal>");
      obj1 = (object) FormDriversInfo.GetTagsValue(iiXml, "<DateIssued>", "</DateIssued>");
      obj2 = (object) FormDriversInfo.GetTagsValue(iiXml, "<DateExpires>", "</DateExpires>");
      if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(obj1)) && obj1.ToString().Length > 0)
        obj1 = (object) FormDriversInfo.DisplayDates(obj1.ToString());
      if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(obj2)) && obj2.ToString().Length > 0)
        obj2 = (object) FormDriversInfo.DisplayDates(obj2.ToString());
      tagsValue7 = (object) FormDriversInfo.GetTagsValue(iiXml, "<Account>", "</Account>");
      tagsValue8 = (object) FormDriversInfo.GetTagsValue(iiXml, "<BillCode>", "</BillCode>");
      tagsValue9 = (object) FormDriversInfo.GetTagsValue(iiXml, "<UserBatchCode>", "</UserBatchCode >");
      tagsValue10 = (object) FormDriversInfo.GetTagsValue(iiXml, "<OrderPurpose>", "</OrderPurpose>");
      tagsValue11 = (object) FormDriversInfo.GetTagsValue(iiXml, "<UserRefNo>", "</UserRefNo>");
      tagsValue12 = (object) FormDriversInfo.GetTagsValue(iiXml, "<Quoteback>", "</Quoteback>");
      tagsValue13 = (object) FormDriversInfo.GetTagsValue(iiXml, "<DLState>", "</DLState>");
      tagsValue14 = (object) FormDriversInfo.GetTagsValue(iiXml, "<ReportTypeCode>", "</ReportTypeCode>");
      tagsValue15 = (object) FormDriversInfo.GetTagsValue(iiXml, "<ReportTypeDescription>", "</ReportTypeDescription>");
      tagsValue16 = (object) FormDriversInfo.GetTagsValue(iiXml, "<RequestorInit>", "</RequestorInit>");
      tagsValue17 = (object) FormDriversInfo.GetTagsValue(iiXml, "<DLNumber>", "</DLNumber>");
      tagsValue18 = (object) FormDriversInfo.GetTagsValue(iiXml, "<DOB>", "</DOB>");
      tagsValue19 = (object) FormDriversInfo.GetTagsValue(iiXml, "<LastName>", "</LastName>");
      tagsValue20 = (object) FormDriversInfo.GetTagsValue(iiXml, "<NameSuffix>", "</NameSuffix>");
      tagsValue21 = (object) FormDriversInfo.GetTagsValue(iiXml, "<FirstName>", "</FirstName>");
      tagsValue22 = (object) FormDriversInfo.GetTagsValue(iiXml, "<MiddleName>", "</MiddleName>");
      tagsValue23 = (object) FormDriversInfo.GetTagsValue(iiXml, "<Gender>", "</Gender>");
    }
    Guid requestGuid = Guid.NewGuid();
    DefaultDatabase.ExecuteNonQuery(CommandType.Text, "INSERT INTO tblDriverIIXReqs (DriverID, RequestGuid, RequestData, Response, Valid, ErrorDescription, OrderDate, PDF, MvrStatus, Points, RequestID, DriverXML, ReportID, ViolationCoding, ViolationCodeTotal, IssueDate, ExpirationDate,  Account, BillCode, UserBatchCode, OrderPurpose, UserRefNo, Quoteback, DLState, ReportTypeCode, ReportTypeDescription,\r\n          RequestorInit, DLNumber, DOB, LastName, NameSuffix, FirstName, MiddleName, Gender ) VALUES(@DriverID, @RequestGuid, @RequestData, @Response, @Valid, @ErrorDescription, @OrderDate, @PDF,  @MvrStatus, @Points, @RequestID, @DriverXML, @ReportID, @ViolationCoding,  @ViolationCodeTotal, @IssueDate, @ExpirationDate,  @Account, @BillCode, @UserBatchCode, @OrderPurpose, @UserRefNo, @Quoteback, @DLState, @ReportTypeCode, @ReportTypeDescription,  @RequestorInit, @DLNumber, @DOB, @LastName, @NameSuffix, @FirstName, @MiddleName, @Gender)", new object[68]
    {
      (object) "@DriverID",
      (object) driverID,
      (object) "@RequestGuid",
      (object) requestGuid,
      (object) "@RequestData",
      (object) reqData,
      (object) "@Response",
      (object) responseData,
      (object) "@Valid",
      (object) validReq,
      (object) "@ErrorDescription",
      (object) errMess,
      (object) "@OrderDate",
      (object) CurrentUser.ServerTime,
      (object) "@MvrStatus",
      tagsValue1,
      (object) "@Points",
      tagsValue2,
      (object) "@RequestID",
      tagsValue3,
      (object) "@DriverXML",
      string.IsNullOrEmpty(iiXml) ? (object) (string) null : (object) iiXml,
      (object) "@ReportID",
      tagsValue4,
      (object) "@ViolationCoding",
      tagsValue5,
      (object) "@ViolationCodeTotal",
      tagsValue6,
      (object) "@IssueDate",
      obj1,
      (object) "@ExpirationDate",
      obj2,
      (object) "@PDF",
      (object) iiPDF,
      (object) "@Account",
      tagsValue7,
      (object) "@BillCode",
      tagsValue8,
      (object) "@UserBatchCode",
      tagsValue9,
      (object) "@OrderPurpose",
      tagsValue10,
      (object) "@UserRefNo",
      tagsValue11,
      (object) "@Quoteback",
      tagsValue12,
      (object) "@DLState",
      tagsValue13,
      (object) "@ReportTypeCode",
      tagsValue14,
      (object) "@ReportTypeDescription",
      tagsValue15,
      (object) "@RequestorInit",
      tagsValue16,
      (object) "@DLNumber",
      tagsValue17,
      (object) "@DOB",
      tagsValue18,
      (object) "@LastName",
      tagsValue19,
      (object) "@NameSuffix",
      tagsValue20,
      (object) "@FirstName",
      tagsValue21,
      (object) "@MiddleName",
      tagsValue22,
      (object) "@Gender",
      tagsValue23
    });
    this.SaveIIXReports(iiXml, requestGuid, driverID);
  }

  private void SaveIIXReports(string iiXml, Guid requestGuid, int driverID)
  {
    if (string.IsNullOrEmpty(iiXml))
      return;
    string xmlString1 = FormDriversInfo.GetTagsValue(iiXml, "<MVRReports>", "</MVRReports>");
    while (xmlString1.Contains(">") && xmlString1.Contains("</"))
    {
      string tagsValue1 = FormDriversInfo.GetTagsValue(xmlString1, "<MVRReport>", "</MVRReport>");
      xmlString1 = xmlString1.Replace(tagsValue1, string.Empty).Replace("<MVRReport></MVRReport>", string.Empty);
      object objectValue1 = RuntimeHelpers.GetObjectValue(FormDriversInfo.GetTagsValueObject(tagsValue1, "<ArchiveFlag>", "</ArchiveFlag>"));
      object objectValue2 = RuntimeHelpers.GetObjectValue(FormDriversInfo.GetTagsValueObject(tagsValue1, "<ClientCode>", "</ClientCode>"));
      object objectValue3 = RuntimeHelpers.GetObjectValue(FormDriversInfo.GetTagsValueObject(tagsValue1, "<DateExpires>", "</DateExpires>"));
      object objectValue4 = RuntimeHelpers.GetObjectValue(FormDriversInfo.GetTagsValueObject(tagsValue1, "<DateIssued>", "</DateIssued>"));
      object objectValue5 = RuntimeHelpers.GetObjectValue(FormDriversInfo.GetTagsValueObject(tagsValue1, "<DLNumber>", "</DLNumber>"));
      object objectValue6 = RuntimeHelpers.GetObjectValue(FormDriversInfo.GetTagsValueObject(tagsValue1, "<DLState>", "</DLState>"));
      object objectValue7 = RuntimeHelpers.GetObjectValue(FormDriversInfo.GetTagsValueObject(tagsValue1, "<DMVAccountNumber>", "</DMVAccountNumber>"));
      object objectValue8 = RuntimeHelpers.GetObjectValue(FormDriversInfo.GetTagsValueObject(tagsValue1, "<DOB>", "</DOB>"));
      object objectValue9 = RuntimeHelpers.GetObjectValue(FormDriversInfo.GetTagsValueObject(tagsValue1, "<DPPAFlag>", "</DPPAFlag>"));
      object objectValue10 = RuntimeHelpers.GetObjectValue(FormDriversInfo.GetTagsValueObject(tagsValue1, "<DriverCityStateZip>", "</DriverCityStateZip>"));
      object objectValue11 = RuntimeHelpers.GetObjectValue(FormDriversInfo.GetTagsValueObject(tagsValue1, "<DriverName>", "</DriverName>"));
      object objectValue12 = RuntimeHelpers.GetObjectValue(FormDriversInfo.GetTagsValueObject(tagsValue1, "<DriverStreetAddr>", "</DriverStreetAddr>"));
      object objectValue13 = RuntimeHelpers.GetObjectValue(FormDriversInfo.GetTagsValueObject(tagsValue1, "<EyeColor>", "</EyeColor>"));
      object objectValue14 = RuntimeHelpers.GetObjectValue(FormDriversInfo.GetTagsValueObject(tagsValue1, "<Gender>", "</Gender>"));
      object objectValue15 = RuntimeHelpers.GetObjectValue(FormDriversInfo.GetTagsValueObject(tagsValue1, "<HairColor>", "</HairColor>"));
      object objectValue16 = RuntimeHelpers.GetObjectValue(FormDriversInfo.GetTagsValueObject(tagsValue1, "<Height>", "</Height>"));
      object objectValue17 = RuntimeHelpers.GetObjectValue(FormDriversInfo.GetTagsValueObject(tagsValue1, "<LicClass>", "</LicClass>"));
      object objectValue18 = RuntimeHelpers.GetObjectValue(FormDriversInfo.GetTagsValueObject(tagsValue1, "<LicStatus>", "</LicStatus>"));
      object obj1 = RuntimeHelpers.GetObjectValue(FormDriversInfo.GetTagsValueObject(tagsValue1, "<MiscDetail>", "</MiscDetail>"));
      if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(obj1)) && obj1.ToString().Length > 0)
        obj1 = (object) obj1.ToString().Replace("<Detail>", string.Empty).Replace("</Detail>", string.Empty);
      object objectValue19 = RuntimeHelpers.GetObjectValue(FormDriversInfo.GetTagsValueObject(tagsValue1, "<MVRFormat>", "</MVRFormat>"));
      object objectValue20 = RuntimeHelpers.GetObjectValue(FormDriversInfo.GetTagsValueObject(tagsValue1, "<MVRStatus>", "</MVRStatus>"));
      object objectValue21 = RuntimeHelpers.GetObjectValue(FormDriversInfo.GetTagsValueObject(tagsValue1, "<ReportID>", "</ReportID>"));
      object objectValue22 = RuntimeHelpers.GetObjectValue(FormDriversInfo.GetTagsValueObject(tagsValue1, "<ReportSequenceNumber>", "</ReportSequenceNumber>"));
      object objectValue23 = RuntimeHelpers.GetObjectValue(FormDriversInfo.GetTagsValueObject(tagsValue1, "<Restrictions>", "</Restrictions>"));
      object objectValue24 = RuntimeHelpers.GetObjectValue(FormDriversInfo.GetTagsValueObject(tagsValue1, "<ViolationCodeTotal>", "</ViolationCodeTotal>"));
      object objectValue25 = RuntimeHelpers.GetObjectValue(FormDriversInfo.GetTagsValueObject(tagsValue1, "<ViolationCoding>", "</ViolationCoding>"));
      object objectValue26 = RuntimeHelpers.GetObjectValue(FormDriversInfo.GetTagsValueObject(tagsValue1, "<VRReportDate>", "</VRReportDate>"));
      object objectValue27 = RuntimeHelpers.GetObjectValue(FormDriversInfo.GetTagsValueObject(tagsValue1, "<Weight>", "</Weight>"));
      Guid guid = Guid.NewGuid();
      DefaultDatabase.ExecuteNonQuery(CommandType.Text, "INSERT INTO tblDriverIIXReports (DriverReportGuid, ArchiveFlag,ClientCode,DateExpires,DateIssued,DLNumber,DLState,DMVAccountNumber,DOB,DPPAFlag,DriverCityStateZip, DriverID,DriverName,DriverStreetAddr,EyeColor,Gender,HairColor,Height,LicClass,LicStatus,MiscDetail,MVRFormat, MVRStatus,ReportID,ReportSequenceNumber,RequestGuid,Restrictions,ViolationCodeTotal,ViolationCoding,VRReportDate,Weight) VALUES(@DriverReportGuid, @ArchiveFlag,@ClientCode, @DateExpires, @DateIssued, @DLNumber, @DLState, @DMVAccountNumber, @DOB, @DPPAFlag, @DriverCityStateZip,  @DriverID, @DriverName, @DriverStreetAddr, @EyeColor, @Gender, @HairColor, @Height, @LicClass, @LicStatus, @MiscDetail, @MVRFormat,  @MVRStatus, @ReportID, @ReportSequenceNumber, @RequestGuid, @Restrictions, @ViolationCodeTotal, @ViolationCoding, @VRReportDate, @Weight)", new object[62]
      {
        (object) "@DriverReportGuid",
        (object) guid,
        (object) "@ArchiveFlag",
        objectValue1,
        (object) "@ClientCode",
        objectValue2,
        (object) "@DateExpires",
        objectValue3,
        (object) "@DateIssued",
        objectValue4,
        (object) "@DLNumber",
        objectValue5,
        (object) "@DLState",
        objectValue6,
        (object) "@DMVAccountNumber",
        objectValue7,
        (object) "@DOB",
        objectValue8,
        (object) "@DPPAFlag",
        objectValue9,
        (object) "@DriverCityStateZip",
        objectValue10,
        (object) "@DriverID",
        (object) driverID,
        (object) "@DriverName",
        objectValue11,
        (object) "@DriverStreetAddr",
        objectValue12,
        (object) "@EyeColor",
        objectValue13,
        (object) "@Gender",
        objectValue14,
        (object) "@HairColor",
        objectValue15,
        (object) "@Height",
        objectValue16,
        (object) "@LicClass",
        objectValue17,
        (object) "@LicStatus",
        objectValue18,
        (object) "@MiscDetail",
        obj1,
        (object) "@MVRFormat",
        objectValue19,
        (object) "@MVRStatus",
        objectValue20,
        (object) "@ReportID",
        objectValue21,
        (object) "@ReportSequenceNumber",
        objectValue22,
        (object) "@RequestGuid",
        (object) requestGuid,
        (object) "@Restrictions",
        objectValue23,
        (object) "@ViolationCodeTotal",
        objectValue24,
        (object) "@ViolationCoding",
        objectValue25,
        (object) "@VRReportDate",
        objectValue26,
        (object) "@Weight",
        objectValue27
      });
      string xmlString2 = FormDriversInfo.GetTagsValue(tagsValue1, "<Violations>", "</Violations>");
      if (!string.IsNullOrEmpty(xmlString2))
      {
        while (true)
        {
          if (xmlString2.Contains(">") && xmlString2.Contains("</"))
          {
            string tagsValue2 = FormDriversInfo.GetTagsValue(xmlString2, "<Violation>", "</Violation>");
            xmlString2 = xmlString2.Replace(tagsValue2, string.Empty).Replace("<Violation></Violation>", string.Empty);
            object objectValue28 = RuntimeHelpers.GetObjectValue(FormDriversInfo.GetTagsValueObject(tagsValue1, "<ViolationType>", "</ViolationType>"));
            object objectValue29 = RuntimeHelpers.GetObjectValue(FormDriversInfo.GetTagsValueObject(tagsValue1, "<ViolationDate>", "</ViolationDate>"));
            object objectValue30 = RuntimeHelpers.GetObjectValue(FormDriversInfo.GetTagsValueObject(tagsValue1, "<ConvictionDate>", "</ConvictionDate>"));
            object objectValue31 = RuntimeHelpers.GetObjectValue(FormDriversInfo.GetTagsValueObject(tagsValue1, "<ViolationCode>", "</ViolationCode>"));
            object objectValue32 = RuntimeHelpers.GetObjectValue(FormDriversInfo.GetTagsValueObject(tagsValue1, "<Points>", "</Points>"));
            object objectValue33 = RuntimeHelpers.GetObjectValue(FormDriversInfo.GetTagsValueObject(tagsValue1, "<AssignedViolationCode>", "</AssignedViolationCode>"));
            object objectValue34 = RuntimeHelpers.GetObjectValue(FormDriversInfo.GetTagsValueObject(tagsValue1, "<AssignedPoints>", "</AssignedPoints>"));
            object obj2 = RuntimeHelpers.GetObjectValue(FormDriversInfo.GetTagsValueObject(tagsValue1, "<ViolationDetail>", "</ViolationDetail>"));
            if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(obj2)) && obj2.ToString().Length > 0)
              obj2 = (object) obj2.ToString().Replace("<Detail>", string.Empty).Replace("</Detail>", string.Empty);
            DefaultDatabase.ExecuteNonQuery(CommandType.Text, "INSERT INTO tblDriverIIXViolatons (DriverID, DriverReportGuid, ViolationType, ViolationDate, ConvictionDate, ViolationCode, Points, AssignedViolationCode, AssignedPoints, ViolationDetail) VALUES(@DriverID, @DriverReportGuid, @ViolationType, @ViolationDate, @ConvictionDate, @ViolationCode, @Points, @AssignedViolationCode, @AssignedPoints, @ViolationDetail)", new object[20]
            {
              (object) "@DriverID",
              (object) driverID,
              (object) "@DriverReportGuid",
              (object) guid,
              (object) "@ViolationType",
              objectValue28,
              (object) "@ViolationDate",
              objectValue29,
              (object) "@ConvictionDate",
              objectValue30,
              (object) "@ViolationCode",
              objectValue31,
              (object) "@Points",
              objectValue32,
              (object) "@AssignedViolationCode",
              objectValue33,
              (object) "@AssignedPoints",
              objectValue34,
              (object) "@ViolationDetail",
              obj2
            });
          }
          else
            goto label_10;
        }
      }
      else
        continue;
label_10:;
    }
  }

  private void SaveIIXPDFResponse(ReportPdfResponse iiPDF, dsDriverInfo.dtIIXRow row)
  {
    FormDriversInfo formDriversInfo = this;
    if ((iiPDF != null ? (iiPDF.IsValidReport ? 1 : 0) : 0) == 0)
      return;
    string path = Path.Combine(MGATempFolder.MGATempPath, string.Join("-", new List<string>()
    {
      row.Field<string>("FirstName"),
      row.Field<string>("LastName"),
      row.Field<string>("LicenseNumber"),
      "IIX.pdf"
    }.WhereNotNullOrEmpty().Select<string, string>(new System.Func<string, string>(DriverUtilityFunctions.RemoveInvalidCharacters))));
    if (File.Exists(path))
      File.Delete(path);
    File.WriteAllBytes(path, iiPDF.PdfBytes);
    int? defaultValue = new int?();
    int? setting;
    int folderId = (setting = MGASystems.Common.Settings.SystemSettings.GetSetting<int?>("IIX.MVRs.DocumentFolderID", defaultValue)).HasValue ? setting.GetValueOrDefault() : -1;
    if (MDIControls.Instance.MDIParent.InvokeRequired)
      MDIControls.Instance.MDIParent.BetterInvoke((Action) ([SpecialName] () => DocumentManager.BeginFileAddWithBind(path, folderId, (ISupportDocumentSystem) formDriversInfo.Quote, string.Empty)));
    else
      DocumentManager.BeginFileAddWithBind(path, folderId, (ISupportDocumentSystem) this.Quote, string.Empty);
  }

  private string IIXDebugTestString()
  {
    return "<MVR>\r\n      <MVRRequest>\r\n    <RequestID>814026190</RequestID>\r\n    <Account>099901</Account>\r\n    <BillCode>000</BillCode>\r\n    <UserBatchCode>0*</UserBatchCode>\r\n    <RequestorInit>IIX</RequestorInit>\r\n    <OrderPurpose>I</OrderPurpose>\r\n    <Quoteback />\r\n    <DLState>NY</DLState>\r\n    <ReportType>\r\n      <ReportTypeCode>M</ReportTypeCode>\r\n      <ReportTypeDescription>Med Cert MVR</ReportTypeDescription>\r\n    </ReportType>\r\n    <DLNumber>ABCTEST</DLNumber>\r\n    <DOB>20210805</DOB>\r\n    <LastName>TESTING</LastName>\r\n    <FirstName>MGA</FirstName>\r\n  </MVRRequest>\r\n  <MVRReports>\r\n    <MVRReport>\r\n      <ReportID>452340927</ReportID>\r\n      <DLState>NY</DLState>\r\n      <ReportSequenceNumber>217000000</ReportSequenceNumber>\r\n      <DriverName>TESTING, MGA</DriverName>\r\n      <MVRStatus>E</MVRStatus>\r\n      <ViolationCoding>N</ViolationCoding>\r\n      <MVRFormat>V20</MVRFormat>\r\n      <MVRReportDate>08052021</MVRReportDate>\r\n      <DLNumber>ABCTEST</DLNumber>\r\n      <ArchiveFlag>N</ArchiveFlag>\r\n      <DPPAFlag>N</DPPAFlag>\r\n      <DOB>08052021</DOB>\r\n      <MiscDetail>\r\n        <Detail>EDIT  Invalid state report type.</Detail>\r\n        <Detail>EDIT  DL Number is not in correct format.</Detail>\r\n        <Detail>This report is generated for insurance purposes only and may not be used for any other purpose. </Detail>\r\n        <Detail>The use and dissemination of the report and information in it must comply with your iiX agreement and the </Detail>\r\n        <Detail>Fair Credit Reporting Act, the Driver's Privacy Protection Act, and any applicable state statute(s). </Detail>\r\n        <Detail>The data in the report from the applicable state agency or service bureau is provided through iiX</Detail>\r\n      </MiscDetail>\r\n      <Violations />\r\n    </MVRReport>\r\n\t<MVRReport>\r\n\t\t  <ReportID>222222</ReportID>\r\n\t\t  <DLState>CA</DLState>\r\n\t\t  <ReportSequenceNumber>24454554000000</ReportSequenceNumber>\r\n\t\t  <DriverName>More, Test</DriverName>\r\n\t\t  <MVRStatus>E</MVRStatus>\r\n\t\t  <ViolationCoding>E</ViolationCoding>\r\n\t\t  <MVRFormat>T44</MVRFormat>\r\n\t\t  <MVRReportDate>08052021</MVRReportDate>\r\n\t\t  <DLNumber>GOOD LIC</DLNumber>\r\n\t\t  <ArchiveFlag>N</ArchiveFlag>\r\n\t\t  <DPPAFlag>N</DPPAFlag>\r\n\t\t  <DOB>08052021</DOB>\r\n\t\t  <MiscDetail>\r\n\t\t\t  <Detail>EDIT  Invalid state report type.</Detail>\r\n\t\t\t  <Detail>EDIT  DL Number is not in correct format.</Detail>\r\n\t\t\t  <Detail>This report is generated for insurance purposes only and may not be used for any other purpose. </Detail>\r\n\t\t\t  <Detail>The use and dissemination of the report and information in it must comply with your iiX agreement and the </Detail>\r\n\t\t\t  <Detail>Fair Credit Reporting Act, the Driver's Privacy Protection Act, and any applicable state statute(s). </Detail>\r\n\t\t\t  <Detail>The data in the report from the applicable state agency or service bureau is provided through iiX</Detail>\r\n\t\t  </MiscDetail>\r\n\t\t <Violations>\r\n\t\t\t <Violation>\r\n\t\t\t\t <ViolationType>TYPE 1</ViolationType>\r\n\t\t\t\t <ViolationDate>08052021</ViolationDate>\r\n\t\t\t\t <ConvictionDate>08052020</ConvictionDate>\r\n\t\t\t\t <ViolationCode>CCC</ViolationCode>\r\n\t\t\t\t <Points>0</Points>\r\n\t\t\t\t <AssignedViolationCode>NONE</AssignedViolationCode>\r\n\t\t\t\t <AssignedPoints>0</AssignedPoints>\r\n\t\t\t </Violation>\r\n\t\t </Violations>\r\n\t  </MVRReport>\r\n  </MVRReports>\r\n</MVR>";
  }

  private void ugDrivers_InitializeLayout(object sender, InitializeLayoutEventArgs e)
  {
    this._canViewDOB = SecurityManager.Instance.AssertPermission("{94A70A52-72AD-41FC-AB43-E80119EB97C7}");
    this._canViewLicense = SecurityManager.Instance.AssertPermission("{6737F846-CC52-4FBF-BFD3-11506D3551AE}");
    UltraGridBand band = e.Layout.Bands[0];
    this.UltraTextEditor1.PasswordChar = '*';
    if (!this._canViewLicense)
      band.Columns["LicenseNumber"].EditorComponent = (Component) this.UltraTextEditor1;
    if (this._canViewDOB)
      return;
    band.Columns["DOB"].EditorComponent = (Component) this.UltraTextEditor1;
  }

  private void DisplayLicenseAndBirthDate()
  {
    this.txtLicenseNumber.PasswordChar = new char();
    this.dtPDateOfBirth.Appearance.FontData.Strikeout = (DefaultableBoolean) 2;
    this.dtPDateOfBirth.Appearance.FontData.Underline = (DefaultableBoolean) 2;
    this.dtPDateOfBirth.Appearance.FontData.Italic = (DefaultableBoolean) 2;
    this.dtPDateOfBirth.Appearance.FontData.SizeInPoints = 8f;
  }

  private void ObscureLicenseAndBirthDate()
  {
    if (!this._canViewLicense)
      this.txtLicenseNumber.PasswordChar = '*';
    if (this._canViewDOB)
      return;
    this.dtPDateOfBirth.Appearance.FontData.Strikeout = (DefaultableBoolean) 1;
    this.dtPDateOfBirth.Appearance.FontData.Underline = (DefaultableBoolean) 1;
    this.dtPDateOfBirth.Appearance.FontData.Italic = (DefaultableBoolean) 1;
    this.dtPDateOfBirth.Appearance.FontData.SizeInPoints = 4f;
  }

  private void DecryptDataPoints()
  {
    try
    {
      foreach (dsDriverInfo.tblDriverInfoRow row in this.ds.tblDriverInfo.Rows)
      {
        if (row.IsLicenseNumberEncryptedNull() && !row.IsLicenseNumberNull())
          row.LicenseNumberEncrypted = ((TripleDesEncrypter) FormDriversInfo._encryptor).Encrypt(row.LicenseNumber);
        if (row.IsDOBEncryptedNull() && !row.IsDOBNull())
          row.DOBEncrypted = ((TripleDesEncrypter) FormDriversInfo._encryptor).Encrypt(row.DOB.ToShortDateString());
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    try
    {
      foreach (dsDriverInfo.tblDriverInfoRow row in this.ds.tblDriverInfo.Rows)
      {
        if (!row.IsLicenseNumberEncryptedNull())
          row.LicenseNumber = ((TripleDesEncrypter) FormDriversInfo._encryptor).Decrypt(row.LicenseNumberEncrypted);
        if (!row.IsDOBEncryptedNull())
          row.DOB = Convert.ToDateTime(((TripleDesEncrypter) FormDriversInfo._encryptor).Decrypt(row.DOBEncrypted));
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    this.ds.tblDriverInfo.AcceptChanges();
  }

  private void LogSavingException(dsDriverInfo.dtOrderingRow dRow)
  {
    string str1 = string.Empty;
    string str2 = string.Empty;
    if (!dRow.IsFirstNameNull())
      str1 = dRow.FirstName;
    if (!dRow.IsLastNameNull())
      str2 = dRow.LastName;
    CurrentUser.Instance.LogAction($"The XML for driver {str1} {str2} is not saved to the db...It may contain invalid characters.", this._QuoteGuid);
  }

  private bool xLicense(int driverID, dsDriverInfo.dtOrderingRow dRow)
  {
    bool flag;
    if (dRow != null)
      flag = !dRow.IsLicenseNumberNull() && !string.IsNullOrEmpty(dRow.LicenseNumber) && (dRow.LicenseNumber.StartsWith("X") || dRow.LicenseNumber.StartsWith("x"));
    else if (driverID != int.MinValue)
    {
      object objectValue = RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT LicenseNumber FROM tblDriverInfo WITH (NOLOCK) WHERE DriverID = @ID", new object[2]
      {
        (object) "@ID",
        (object) driverID
      }));
      flag = !Utility.IsNull(RuntimeHelpers.GetObjectValue(objectValue)) && (objectValue.ToString().StartsWith("X") || objectValue.ToString().StartsWith("x"));
    }
    else
      flag = false;
    return flag;
  }

  protected virtual void AfterDriversProcess()
  {
  }

  protected virtual void SambaSafetyConnect()
  {
    if (!this.IsReadyForProcessing())
    {
      int num1 = (int) MessageBox.Show("'ADR' check is needed for processing of driver information.", "ADR Check", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    else
    {
      string setting1 = MGASystems.Common.Settings.SystemSettings.GetSetting<string>("ADRUserName", string.Empty);
      string setting2 = MGASystems.Common.Settings.SystemSettings.GetSetting<string>("ADRPassword", string.Empty);
      string setting3 = MGASystems.Common.Settings.SystemSettings.GetSetting<string>("ADRAccountID", string.Empty);
      if (string.IsNullOrEmpty(setting1) || string.IsNullOrEmpty(setting2) || string.IsNullOrEmpty(setting3))
      {
        int num2 = (int) MessageBox.Show("ADR credentials are missing.", "Missing ADR Credentials", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      }
      else
      {
        string text1 = this.IsValidBirthDateCheckForProcessing();
        if (!string.IsNullOrEmpty(text1))
        {
          int num3 = (int) MessageBox.Show(text1, "Cannnot Continue - Driver(s) Missing DOB", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        else
        {
          string text2 = this.IsValidLicenseCheckForProcessing();
          if (!string.IsNullOrEmpty(text2))
          {
            int num4 = (int) MessageBox.Show(text2, "Cannnot Continue - Driver(s) Missing License #", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
          }
          else
          {
            bool flag1 = false;
            dsDriverInfo.dtOrderingDataTable orderingDataTable = (dsDriverInfo.dtOrderingDataTable) null;
            try
            {
              using (FormDriverOrderingRecord driverOrderingRecord = FormSettings.ShowFormDialog<FormDriverOrderingRecord>((object) this._ControlNo, (object) this._QuoteGuid, (object) this.ds))
              {
                flag1 = driverOrderingRecord.ContinueProcess;
                orderingDataTable = driverOrderingRecord.ProcessOrderTable;
              }
            }
            catch (Exception ex)
            {
              ProjectData.SetProjectError(ex);
              ErrorHandler.SilentHandleError(ex);
              throw;
            }
            if (!flag1)
              return;
            bool flag2 = false;
            Dictionary<dsDriverInfo.dtOrderingRow, string> dictionary1 = new Dictionary<dsDriverInfo.dtOrderingRow, string>();
            Dictionary<dsDriverInfo.dtOrderingRow, string> dictionary2 = new Dictionary<dsDriverInfo.dtOrderingRow, string>();
            bool flag3 = false;
            int num5 = -1;
            string str1 = string.Empty;
            string str2 = string.Empty;
            int num6 = -1;
            try
            {
              try
              {
                foreach (dsDriverInfo.dtOrderingRow row in orderingDataTable.Rows)
                {
                  using (ADRConnectWrapper adrConnectWrapper = new ADRConnectWrapper(row.DriverID))
                  {
                    adrConnectWrapper.Product = row.ProductID;
                    if (!flag2)
                    {
                      flag2 = true;
                      if (!adrConnectWrapper.IsValidCredentials)
                      {
                        flag3 = true;
                        break;
                      }
                    }
                    this.SetSearchPanelVisible(true);
                    this.SetSearchLabelText($"Processing '[{row.FirstName} {row.LastName}]' Record ...");
                    ((UltraControlBase) this.panelProcessingADR).Refresh();
                    string driverMiddleName = string.Empty;
                    if (!row.IsMiddleNameNull())
                      driverMiddleName = row.MiddleName;
                    string driverSuffix = string.Empty;
                    if (!row.IsSuffixNull())
                      driverSuffix = row.Suffix;
                    string misc = string.Empty;
                    if (!row.IsMiscNull())
                      misc = row.Misc;
                    DriverRecord arrDrivers = new DriverRecord(row.LicenseNumber, row.FirstName, driverMiddleName, row.LastName, driverSuffix, (object) row.DOB, (object) row.StateID, (object) row.ProductID, (object) row.SubType, (object) row.Purpose, (object) misc, this._billing, this.GetInsuredName());
                    string str3 = string.Empty;
                    if (!row.IsHintMvrInsuranceOptionNull())
                      str3 = row.HintMvrInsuranceOption;
                    if (str3.Equals("<None>") || str3.Equals("<Unavailable>"))
                      str3 = string.Empty;
                    arrDrivers.HintMvrInsuranceOption = str3;
                    arrDrivers.Reference = this.GetReference(row.DriverID);
                    if (ADRConnectWrapper.ImplementsLicenseLookup && !row.IsLicenseValidationLookupNull() && row.LicenseValidationLookup)
                      arrDrivers.LicenseValidationLookup = row.LicenseValidationLookup;
                    string empty = string.Empty;
                    str1 = row.FirstName;
                    str2 = row.LastName;
                    num6 = row.DriverID;
                    string str4 = adrConnectWrapper.IsDemoService() ? adrConnectWrapper.ProcessDemoInformation(arrDrivers) : (row.IsStateIDNull() || !this.IsOvernightState(row.StateID) ? adrConnectWrapper.ProcessDriverInformation(arrDrivers) : adrConnectWrapper.SendOvernightOrders(arrDrivers));
                    num5 = adrConnectWrapper.DaysLeft;
                    dictionary1.Add(row, str4);
                    dictionary2.Add(row, adrConnectWrapper.XmlResult);
                  }
                }
              }
              finally
              {
                IEnumerator enumerator;
                if (enumerator is IDisposable)
                  (enumerator as IDisposable).Dispose();
              }
              if (flag3)
              {
                int num7 = (int) MessageBox.Show("There are missing credentials necessary to connect to ADR service", "Credentials are missing", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
              }
              try
              {
                foreach (KeyValuePair<dsDriverInfo.dtOrderingRow, string> keyValuePair in dictionary1)
                {
                  dsDriverInfo.dtOrderingRow key = keyValuePair.Key;
                  CurrentUser.Instance.LogAction($"Processed ADR for driver - {key.FirstName} {key.LastName}", this._QuoteGuid);
                  this.ProcessDriverResult(keyValuePair.Value, key);
                }
              }
              finally
              {
                Dictionary<dsDriverInfo.dtOrderingRow, string>.Enumerator enumerator;
                enumerator.Dispose();
              }
              try
              {
                foreach (KeyValuePair<dsDriverInfo.dtOrderingRow, string> keyValuePair in dictionary2)
                {
                  dsDriverInfo.dtOrderingRow key = keyValuePair.Key;
                  this.ProcessXmlResults(keyValuePair.Value, key);
                }
              }
              finally
              {
                Dictionary<dsDriverInfo.dtOrderingRow, string>.Enumerator enumerator;
                enumerator.Dispose();
              }
            }
            catch (Exception ex1)
            {
              ProjectData.SetProjectError(ex1);
              Exception ex2 = ex1;
              string str5 = string.Empty;
              if (num5 != -1)
                str5 = $"Days left to password change - {num5.ToString()}.";
              CurrentUser.Instance.LogAction($"Error on processing ADR. DriverID={num6}. {str1} {str2}", this._QuoteGuid);
              ErrorHandler.SilentHandleError(ex2);
              int num8 = (int) MessageBox.Show($"{str5}\n\nADR service experiences the following error: \n\n{ex2.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
              throw;
            }
            finally
            {
              this.SetSearchPanelVisible(false);
            }
            this.AfterDriversProcess();
            if (num5 > 3)
              return;
            int num9 = (int) MessageBox.Show($"Days left to password change - {num5.ToString()}.", "Please Change Password Soon", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
          }
        }
      }
    }
  }

  private void lnkSelectDeletes_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    this.SetBulkDelete(true);
  }

  private void lnkDeSelectDeletes_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    this.SetBulkDelete(false);
  }

  private void SetBulkDelete(bool deleteValue)
  {
    foreach (UltraGridRow row in ((UltraGridBase) this.ugDrivers).Rows)
      row.Cells["BulkDelete"].Value = (object) deleteValue;
    ((UltraGridBase) this.ugDrivers).UpdateData();
  }

  private void btnBulkDelete_Click(object sender, EventArgs e)
  {
    // ISSUE: variable of a compiler-generated type
    FormDriversInfo._Closure\u0024__689\u002D1 closure6891_1;
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    FormDriversInfo._Closure\u0024__689\u002D1 closure6891_2 = new FormDriversInfo._Closure\u0024__689\u002D1(closure6891_1);
    // ISSUE: reference to a compiler-generated field
    closure6891_2.\u0024VB\u0024Me = this;
    if (MessageBox.Show("Are you sure you want to continue with bulk delete?", "Continue Bulk Delete?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.Yes)
      return;
    List<string> stringList = new List<string>();
    string status1 = this.ds.lstDriverStatus.FindByDriverStatusID(this.DeletedStatus.Value).Status;
    List<long> values = new List<long>();
    try
    {
      foreach (dsDriverInfo.tblDriverInfoRow row in this.ds.tblDriverInfo.Rows)
      {
        if (row.RowState == DataRowState.Modified && !row.IsBulkDeleteNull() && row.BulkDelete)
        {
          int DriverStatusID = row.Field<int?>("StatusID", DataRowVersion.Original) ?? -1;
          if (DriverStatusID != this.DeletedStatus.Value)
          {
            row.StatusID = this.DeletedStatus.Value;
            row.DriverDeleted = this.DriverDeletedDate(row);
            values.Add(row.DriverID);
            string status2 = this.ds.lstDriverStatus.FindByDriverStatusID(DriverStatusID).Status;
            stringList.Add($"Changed driver '{Conversions.ToString(Interaction.IIf(row.IsFirstNameNull(), (object) string.Empty, (object) row.FirstName))} {Conversions.ToString(Interaction.IIf(row.IsLastNameNull(), (object) string.Empty, (object) row.LastName))}' status via bulk delete from {status2} to {status1}.");
          }
        }
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    // ISSUE: reference to a compiler-generated field
    closure6891_2.\u0024VB\u0024Local_deleteSuccess = false;
    if (values.Count > 0)
    {
      // ISSUE: variable of a compiler-generated type
      FormDriversInfo._Closure\u0024__689\u002D0 closure6890;
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: reference to a compiler-generated method
      DefaultDatabase.ExecuteTransaction(new EventHandler<ExecuteTransactionEventArgs>(new FormDriversInfo._Closure\u0024__689\u002D0(closure6890)
      {
        \u0024VB\u0024NonLocal_\u0024VB\u0024Closure_2 = closure6891_2,
        \u0024VB\u0024Local_params = string.Join<long>(",", (IEnumerable<long>) values)
      }._Lambda\u0024__0));
    }
    // ISSUE: reference to a compiler-generated field
    if (!closure6891_2.\u0024VB\u0024Local_deleteSuccess)
      return;
    this.ds.tblDriverInfo.AcceptChanges();
    this.SetDeletedRowAppearance();
    try
    {
      foreach (string action in stringList)
        CurrentUser.Instance.LogAction(action, this._QuoteGuid);
    }
    finally
    {
      List<string>.Enumerator enumerator;
      enumerator.Dispose();
    }
  }

  private void lnkSelectAllCopyRenewal_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    this.SetBulkCopyOnRenewal(true);
  }

  private void lnkDeSelectAllCopyRenewal_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    this.SetBulkCopyOnRenewal(false);
  }

  private void SetBulkCopyOnRenewal(bool copyValue)
  {
    foreach (UltraGridRow row in ((UltraGridBase) this.ugDrivers).Rows)
      row.Cells["CopyOnRenewal"].Value = (object) copyValue;
    ((UltraGridBase) this.ugDrivers).UpdateData();
  }

  private void btnCopyOnRenewal_Click(object sender, EventArgs e)
  {
    // ISSUE: variable of a compiler-generated type
    FormDriversInfo._Closure\u0024__693\u002D1 closure6931_1;
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    FormDriversInfo._Closure\u0024__693\u002D1 closure6931_2 = new FormDriversInfo._Closure\u0024__693\u002D1(closure6931_1);
    if (MessageBox.Show("Are you sure you want to continue with bulk copy on renewal?", "Continue Bulk Copy On Renewal?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.Yes)
      return;
    List<string> stringList = new List<string>();
    List<long> values1 = new List<long>();
    List<int> values2 = new List<int>();
    try
    {
      foreach (dsDriverInfo.tblDriverInfoRow row in this.ds.tblDriverInfo.Rows)
      {
        if (row.RowState == DataRowState.Modified && !row.IsCopyOnRenewalNull())
        {
          bool flag = row.Field<bool?>("CopyOnRenewal", DataRowVersion.Original) ?? false;
          if (flag != row.CopyOnRenewal)
          {
            values1.Add(row.DriverID);
            values2.Add(row.CopyOnRenewal ? 1 : 0);
            stringList.Add($"Changed driver '{Conversions.ToString(Interaction.IIf(row.IsFirstNameNull(), (object) string.Empty, (object) row.FirstName))} {Conversions.ToString(Interaction.IIf(row.IsLastNameNull(), (object) string.Empty, (object) row.LastName))}' copy on renewal flag from {flag} to {row.CopyOnRenewal}.");
          }
        }
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    // ISSUE: reference to a compiler-generated field
    closure6931_2.\u0024VB\u0024Local_copyRenewSuccess = false;
    if (values1.Count > 0)
    {
      // ISSUE: variable of a compiler-generated type
      FormDriversInfo._Closure\u0024__693\u002D0 closure6930;
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: reference to a compiler-generated method
      DefaultDatabase.ExecuteTransaction(new EventHandler<ExecuteTransactionEventArgs>(new FormDriversInfo._Closure\u0024__693\u002D0(closure6930)
      {
        \u0024VB\u0024NonLocal_\u0024VB\u0024Closure_2 = closure6931_2,
        \u0024VB\u0024Local_params = string.Join<long>(",", (IEnumerable<long>) values1),
        \u0024VB\u0024Local_parambools = string.Join<int>(",", (IEnumerable<int>) values2)
      }._Lambda\u0024__0));
    }
    // ISSUE: reference to a compiler-generated field
    if (!closure6931_2.\u0024VB\u0024Local_copyRenewSuccess)
      return;
    try
    {
      foreach (string action in stringList)
        CurrentUser.Instance.LogAction(action, this._QuoteGuid);
    }
    finally
    {
      List<string>.Enumerator enumerator;
      enumerator.Dispose();
    }
  }

  private void SetDeletedRowAppearance()
  {
    try
    {
      foreach (dsDriverInfo.tblDriverInfoRow row in this.ds.tblDriverInfo.Rows)
      {
        if (!row.IsStatusIDNull() && row.StatusID == this.DeletedStatus.Value)
          this.MarkDriver((int) row.DriverID);
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private void lnkSambaOffice_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    FormSettings.ShowFormDialog(typeof (FormSambaOffice));
  }

  private enum OvernightStates
  {
    HI,
  }
}
