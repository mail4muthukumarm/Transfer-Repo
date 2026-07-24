// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Forms.FormAdminInspectionRequests
// Assembly: MgaSystems.IMS.Forms, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FB3F392E-40B6-486F-8F0B-A4A494A546D4
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Forms.dll

using GrapeCity.ActiveReports;
using Infragistics.Shared;
using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using Infragistics.Win.UltraWinTabControl;
using MGASystems.BusinessObjects;
using MGASystems.Common;
using MGASystems.Common.ErrorHandling;
using MGASystems.Data;
using MGASystems.IMS.NoteDocuments;
using MGASystems.IMS.NoteDocuments.NoteDiarySystem;
using MGASystems.IMS.Policies;
using MGASystems.IMS.Policies.Clearance;
using MGASystems.IMS.Policies.PolicyDetail;
using MGASystems.IMS.Reporting;
using MGASystems.InfragisticsExtensions.Editors;
using MGASystems.Tools;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Forms;

[DesignerGenerated]
[SecureResource("{691E15C5-F8DE-4F77-94E1-F332F76A4B61}", "View Admin Inspection Requests", "Controls the ability to view Admin Inspection Request.", "Users")]
[Preference("AdminInspections.ShowClosedItems", false)]
public class FormAdminInspectionRequests : Form
{
  private IContainer components;
  private HyperlinkEditor _hlkControlNo;
  private MemoryStream _gridLayout;
  private bool _clickedNew;
  private List<int> _hiddenInspectioncompanies;
  private int _inspectTypeDefault;
  private bool _loadComplete;
  private bool _allowEdits;
  public const string CanViewAdminInspectionRequests = "{691E15C5-F8DE-4F77-94E1-F332F76A4B61}";

  public FormAdminInspectionRequests()
  {
    this.Load += new EventHandler(this.FormAdminInspectionRequests_Load);
    this._hlkControlNo = new HyperlinkEditor();
    this._gridLayout = new MemoryStream();
    this._hiddenInspectioncompanies = new List<int>();
    this.InitializeComponent();
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    Appearance appearance1 = new Appearance();
    UltraGridBand ultraGridBand1 = new UltraGridBand("lstAdminInspectionTypes", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("ID");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("InspectionType");
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    ScrollBarLook scrollBarLook1 = new ScrollBarLook();
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
    Appearance appearance15 = new Appearance();
    Appearance appearance16 = new Appearance();
    Appearance appearance17 = new Appearance();
    UltraGridBand ultraGridBand2 = new UltraGridBand("tblFin_ExpensePayees", -1);
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("PayeeID");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("PayeeName");
    Appearance appearance18 = new Appearance();
    Appearance appearance19 = new Appearance();
    Appearance appearance20 = new Appearance();
    ScrollBarLook scrollBarLook2 = new ScrollBarLook();
    Appearance appearance21 = new Appearance();
    Appearance appearance22 = new Appearance();
    Appearance appearance23 = new Appearance();
    UltraGridBand ultraGridBand3 = new UltraGridBand("lstAdminInspectionStatus", -1);
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("ID");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("InspectionStatus");
    Appearance appearance24 = new Appearance();
    Appearance appearance25 = new Appearance();
    Appearance appearance26 = new Appearance();
    ScrollBarLook scrollBarLook3 = new ScrollBarLook();
    Appearance appearance27 = new Appearance();
    Appearance appearance28 = new Appearance();
    Appearance appearance29 = new Appearance();
    Appearance appearance30 = new Appearance();
    Appearance appearance31 = new Appearance();
    Appearance appearance32 = new Appearance();
    Appearance appearance33 = new Appearance();
    Appearance appearance34 = new Appearance();
    Appearance appearance35 = new Appearance();
    Appearance appearance36 = new Appearance();
    Appearance appearance37 = new Appearance();
    Appearance appearance38 = new Appearance();
    Appearance appearance39 = new Appearance();
    Appearance appearance40 = new Appearance();
    Appearance appearance41 = new Appearance();
    Appearance appearance42 = new Appearance();
    Appearance appearance43 = new Appearance();
    Appearance appearance44 = new Appearance();
    Appearance appearance45 = new Appearance();
    Appearance appearance46 = new Appearance();
    Appearance appearance47 = new Appearance();
    Appearance appearance48 = new Appearance();
    Appearance appearance49 = new Appearance();
    Appearance appearance50 = new Appearance();
    Appearance appearance51 = new Appearance();
    Appearance appearance52 = new Appearance();
    Appearance appearance53 = new Appearance();
    Appearance appearance54 = new Appearance();
    UltraGridBand ultraGridBand4 = new UltraGridBand("lstInspectionsAdminRecStatus", -1);
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("ID");
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("RecStatus");
    Appearance appearance55 = new Appearance();
    Appearance appearance56 = new Appearance();
    Appearance appearance57 = new Appearance();
    ScrollBarLook scrollBarLook4 = new ScrollBarLook();
    Appearance appearance58 = new Appearance();
    UltraGridBand ultraGridBand5 = new UltraGridBand("tblAdminInspectionRequests", -1);
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("ID");
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("FollowUp");
    UltraGridColumn ultraGridColumn11 = new UltraGridColumn("ControlNo");
    UltraGridColumn ultraGridColumn12 = new UltraGridColumn("PolicyNumber");
    UltraGridColumn ultraGridColumn13 = new UltraGridColumn("Insured");
    UltraGridColumn ultraGridColumn14 = new UltraGridColumn("LOB");
    UltraGridColumn ultraGridColumn15 = new UltraGridColumn("LocationID");
    UltraGridColumn ultraGridColumn16 = new UltraGridColumn("LocationNumber");
    UltraGridColumn ultraGridColumn17 = new UltraGridColumn("LocationAddress");
    UltraGridColumn ultraGridColumn18 = new UltraGridColumn("Address1");
    UltraGridColumn ultraGridColumn19 = new UltraGridColumn("Address2");
    UltraGridColumn ultraGridColumn20 = new UltraGridColumn("City");
    UltraGridColumn ultraGridColumn21 = new UltraGridColumn("State");
    UltraGridColumn ultraGridColumn22 = new UltraGridColumn("Zip");
    UltraGridColumn ultraGridColumn23 = new UltraGridColumn("InspectionCompanyID", -1, (object) "ddInspectComp");
    UltraGridColumn ultraGridColumn24 = new UltraGridColumn("InspectionContact");
    UltraGridColumn ultraGridColumn25 = new UltraGridColumn("InspectionContactPhone");
    UltraGridColumn ultraGridColumn26 = new UltraGridColumn("Underwriter");
    UltraGridColumn ultraGridColumn27 = new UltraGridColumn("EffectiveDate");
    UltraGridColumn ultraGridColumn28 = new UltraGridColumn("OrderDate");
    UltraGridColumn ultraGridColumn29 = new UltraGridColumn("DropDeadDate");
    UltraGridColumn ultraGridColumn30 = new UltraGridColumn("FollowupDate");
    UltraGridColumn ultraGridColumn31 = new UltraGridColumn("ReceivedDate");
    UltraGridColumn ultraGridColumn32 = new UltraGridColumn("Received");
    UltraGridColumn ultraGridColumn33 = new UltraGridColumn("RevisedContactInfo");
    UltraGridColumn ultraGridColumn34 = new UltraGridColumn("InspectionStatus", -1, (object) "ddInspStatus");
    UltraGridColumn ultraGridColumn35 = new UltraGridColumn("OrderedBy");
    UltraGridColumn ultraGridColumn36 = new UltraGridColumn("InspType");
    UltraGridColumn ultraGridColumn37 = new UltraGridColumn("OnEndorsement");
    UltraGridColumn ultraGridColumn38 = new UltraGridColumn("PolicyType");
    UltraGridColumn ultraGridColumn39 = new UltraGridColumn("InsuredID");
    UltraGridColumn ultraGridColumn40 = new UltraGridColumn("PolicyStatus");
    UltraGridColumn ultraGridColumn41 = new UltraGridColumn("Closed");
    UltraGridColumn ultraGridColumn42 = new UltraGridColumn("ClosedDate");
    UltraGridColumn ultraGridColumn43 = new UltraGridColumn("CriticalOutstanding");
    UltraGridColumn ultraGridColumn44 = new UltraGridColumn("CriticalWaived");
    UltraGridColumn ultraGridColumn45 = new UltraGridColumn("CriticalComplete");
    UltraGridColumn ultraGridColumn46 = new UltraGridColumn("CriticalTotal");
    UltraGridColumn ultraGridColumn47 = new UltraGridColumn("NonCriticalOutstanding");
    UltraGridColumn ultraGridColumn48 = new UltraGridColumn("NonCriticalWaived");
    UltraGridColumn ultraGridColumn49 = new UltraGridColumn("NonCriticalComplete");
    UltraGridColumn ultraGridColumn50 = new UltraGridColumn("NonCriticalTotal");
    UltraGridColumn ultraGridColumn51 = new UltraGridColumn("RecStatusID", -1, (object) "ddRecStatus");
    UltraGridColumn ultraGridColumn52 = new UltraGridColumn("RecSent");
    UltraGridColumn ultraGridColumn53 = new UltraGridColumn("RecsFollowUp");
    UltraGridColumn ultraGridColumn54 = new UltraGridColumn("RecsCompleted");
    UltraGridColumn ultraGridColumn55 = new UltraGridColumn("Roof");
    UltraGridColumn ultraGridColumn56 = new UltraGridColumn("Notes");
    UltraGridColumn ultraGridColumn57 = new UltraGridColumn("RecsReceived");
    UltraGridColumn ultraGridColumn58 = new UltraGridColumn("CPR");
    UltraGridColumn ultraGridColumn59 = new UltraGridColumn("Map");
    UltraGridColumn ultraGridColumn60 = new UltraGridColumn("SprinklerTest");
    UltraGridColumn ultraGridColumn61 = new UltraGridColumn("Thermo");
    UltraGridColumn ultraGridColumn62 = new UltraGridColumn("FirePump");
    UltraGridColumn ultraGridColumn63 = new UltraGridColumn("FocusAccount");
    UltraGridColumn ultraGridColumn64 = new UltraGridColumn("CriticalAccount");
    UltraGridColumn ultraGridColumn65 = new UltraGridColumn("LastAssessmentDate");
    UltraGridColumn ultraGridColumn66 = new UltraGridColumn("InspectionTypeID");
    Appearance appearance59 = new Appearance();
    Appearance appearance60 = new Appearance();
    Appearance appearance61 = new Appearance();
    Appearance appearance62 = new Appearance();
    Appearance appearance63 = new Appearance();
    Appearance appearance64 = new Appearance();
    Appearance appearance65 = new Appearance();
    ScrollBarLook scrollBarLook5 = new ScrollBarLook();
    Appearance appearance66 = new Appearance();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (FormAdminInspectionRequests));
    UltraTab ultraTab1 = new UltraTab();
    UltraTab ultraTab2 = new UltraTab();
    UltraGridBand ultraGridBand6 = new UltraGridBand("lstInspectionsAdminRecStatus", -1);
    UltraGridColumn ultraGridColumn67 = new UltraGridColumn("ID");
    UltraGridColumn ultraGridColumn68 = new UltraGridColumn("RecStatus");
    UltraGridBand ultraGridBand7 = new UltraGridBand("lstAdminInspectionStatus", -1);
    UltraGridColumn ultraGridColumn69 = new UltraGridColumn("ID");
    UltraGridColumn ultraGridColumn70 = new UltraGridColumn("InspectionStatus");
    UltraGridBand ultraGridBand8 = new UltraGridBand("tblFin_ExpensePayees", -1);
    UltraGridColumn ultraGridColumn71 = new UltraGridColumn("PayeeID");
    UltraGridColumn ultraGridColumn72 = new UltraGridColumn("PayeeName");
    this.utpcInspectionInformation = new UltraTabPageControl();
    this.Label80 = new Label();
    this.Label79 = new Label();
    this.cboAdminInspectionTypes = new MGAComboBox();
    this.ds = new dsAdminInspReq();
    this.lnkSelectUser = new LinkLabel();
    this.lnkPolicyInfo = new LinkLabel();
    this.lnkSearchLoc = new LinkLabel();
    this.btnNew = new MGAButton();
    this.btnUndo = new MGAButton();
    this.Label64 = new Label();
    this.chkRecsReceived = new MGACheckBox();
    this.Label63 = new Label();
    this.lblNotes = new Label();
    this.txtNotes = new TextBox();
    this.chkRoof = new MGACheckBox();
    this.Label40 = new Label();
    this.Label39 = new Label();
    this.dtpReceivedDate = new MGADateTimePicker();
    this.dtpClosedDate = new MGADateTimePicker();
    this.Label17 = new Label();
    this.Label38 = new Label();
    this.Label15 = new Label();
    this.chkClosed = new MGACheckBox();
    this.Label18 = new Label();
    this.txtPolicyType = new TextBox();
    this.txtZip = new TextBox();
    this.Label29 = new Label();
    this.txtInspectionContact = new TextBox();
    this.chkOnEndorsement = new MGACheckBox();
    this.Label13 = new Label();
    this.txtInspType = new TextBox();
    this.Label19 = new Label();
    this.Label28 = new Label();
    this.Label12 = new Label();
    this.txtOrderedBy = new TextBox();
    this.txtContactPhone = new TextBox();
    this.Label16 = new Label();
    this.dtpDropDeadDate = new MGADateTimePicker();
    this.lnkGridReport = new LinkLabel();
    this.txtState = new TextBox();
    this.lnkDeSelectAll = new LinkLabel();
    this.txtCity = new TextBox();
    this.lnkSelectAllRows = new LinkLabel();
    this.Label14 = new Label();
    this.lnkResetAllFilter = new LinkLabel();
    this.txtAddress2 = new TextBox();
    this.Label30 = new Label();
    this.Label21 = new Label();
    this.cboInspectionCompany = new MGAComboBox();
    this.Label11 = new Label();
    this.Label26 = new Label();
    this.dtpEffectiveDate = new MGADateTimePicker();
    this.Label4 = new Label();
    this.txtUnderwriter = new TextBox();
    this.Label3 = new Label();
    this.Label20 = new Label();
    this.btnFollowUp = new Button();
    this.Label10 = new Label();
    this.Label2 = new Label();
    this.txtAddress1 = new TextBox();
    this.Label1 = new Label();
    this.Label22 = new Label();
    this.cboInspectionStatus = new MGAComboBox();
    this.txtAddress = new TextBox();
    this.txtControlNo = new TextBox();
    this.txtInsured = new TextBox();
    this.Label37 = new Label();
    this.txtLocationNumber = new TextBox();
    this.Label34 = new Label();
    this.Label9 = new Label();
    this.Label33 = new Label();
    this.dtpFollowupDate = new MGADateTimePicker();
    this.chkReceived = new MGACheckBox();
    this.Label8 = new Label();
    this.Label23 = new Label();
    this.Label7 = new Label();
    this.txtPolicyNo = new TextBox();
    this.dtpOrderDate = new MGADateTimePicker();
    this.Label5 = new Label();
    this.Label6 = new Label();
    this.btnMakeNote = new Button();
    this.Label24 = new Label();
    this.chkRevisedContactInfo = new MGACheckBox();
    this.Label25 = new Label();
    this.btnSave = new MGAButton();
    this.utcRecommendations = new UltraTabPageControl();
    this.dtLastAssessmentDate = new MGADateTimePicker();
    this.Label77 = new Label();
    this.Label78 = new Label();
    this.Label76 = new Label();
    this.Label75 = new Label();
    this.Label74 = new Label();
    this.Label73 = new Label();
    this.Label72 = new Label();
    this.Label71 = new Label();
    this.chkCriticalAccount = new MGACheckBox();
    this.Label70 = new Label();
    this.chkFocusAccount = new MGACheckBox();
    this.dtpMap = new MGADateTimePicker();
    this.Label69 = new Label();
    this.dtpSprinklerTest = new MGADateTimePicker();
    this.Label68 = new Label();
    this.dtpThermo = new MGADateTimePicker();
    this.Label67 = new Label();
    this.dtpFirePump = new MGADateTimePicker();
    this.Label66 = new Label();
    this.dtpCPR = new MGADateTimePicker();
    this.Label65 = new Label();
    this.dtpRecsSent = new MGADateTimePicker();
    this.dtpRecsFollowUp = new MGADateTimePicker();
    this.dtpRecsCompleted = new MGADateTimePicker();
    this.Label62 = new Label();
    this.Label61 = new Label();
    this.Label60 = new Label();
    this.Label59 = new Label();
    this.Label58 = new Label();
    this.Label57 = new Label();
    this.Label56 = new Label();
    this.Label55 = new Label();
    this.Label54 = new Label();
    this.Label53 = new Label();
    this.Label52 = new Label();
    this.Label51 = new Label();
    this.Label50 = new Label();
    this.cboRecStatus = new MGAComboBox();
    this.Label49 = new Label();
    this.Label48 = new Label();
    this.Label47 = new Label();
    this.txtNonCriticalWaived = new TextBox();
    this.txtNonCriticalComplete = new TextBox();
    this.txtNonCriticalTotal = new TextBox();
    this.txtNonCriticalOutstanding = new TextBox();
    this.Label46 = new Label();
    this.Label45 = new Label();
    this.Label44 = new Label();
    this.Label43 = new Label();
    this.Label42 = new Label();
    this.Label41 = new Label();
    this.txtCriticalWaived = new TextBox();
    this.txtCriticalComplete = new TextBox();
    this.txtCriticalTotal = new TextBox();
    this.txtCriticalOutstanding = new TextBox();
    this.err = new ErrorProvider(this.components);
    this.ugLocations = new UltraGrid();
    this.dvSource = new DataView();
    this.txtFilterControlNo = new TextBox();
    this.Label31 = new Label();
    this.Label32 = new Label();
    this.txtFilterPolicyNumber = new TextBox();
    this.Label35 = new Label();
    this.txtFilterAddress = new TextBox();
    this.Label36 = new Label();
    this.txtFilterName = new TextBox();
    this.lnkLogInfo = new LinkLabel();
    this.panelSearch = new UltraGroupBox();
    this.spinner = new PictureBox();
    this.labelSearchText = new Label();
    this.tabInspections = new UltraTabControl();
    this.ultraTabSharedControlsPage1 = new UltraTabSharedControlsPage();
    this.lblShowRecords = new LinkLabel();
    this.ttInspAdminReq = new ToolTip(this.components);
    this.ddRecStatus = new UltraDropDown();
    this.ddInspStatus = new UltraDropDown();
    this.ddInspectComp = new UltraDropDown();
    Label label = new Label();
    ((Control) this.utpcInspectionInformation).SuspendLayout();
    ((ISupportInitialize) this.cboAdminInspectionTypes).BeginInit();
    this.ds.BeginInit();
    ((ISupportInitialize) this.btnNew).BeginInit();
    ((ISupportInitialize) this.btnUndo).BeginInit();
    ((ISupportInitialize) this.chkRecsReceived).BeginInit();
    ((ISupportInitialize) this.chkRoof).BeginInit();
    ((ISupportInitialize) this.dtpReceivedDate).BeginInit();
    ((ISupportInitialize) this.dtpClosedDate).BeginInit();
    ((ISupportInitialize) this.chkClosed).BeginInit();
    ((ISupportInitialize) this.chkOnEndorsement).BeginInit();
    ((ISupportInitialize) this.dtpDropDeadDate).BeginInit();
    ((ISupportInitialize) this.cboInspectionCompany).BeginInit();
    ((ISupportInitialize) this.dtpEffectiveDate).BeginInit();
    ((ISupportInitialize) this.cboInspectionStatus).BeginInit();
    ((ISupportInitialize) this.dtpFollowupDate).BeginInit();
    ((ISupportInitialize) this.chkReceived).BeginInit();
    ((ISupportInitialize) this.dtpOrderDate).BeginInit();
    ((ISupportInitialize) this.chkRevisedContactInfo).BeginInit();
    ((ISupportInitialize) this.btnSave).BeginInit();
    ((Control) this.utcRecommendations).SuspendLayout();
    ((ISupportInitialize) this.dtLastAssessmentDate).BeginInit();
    ((ISupportInitialize) this.chkCriticalAccount).BeginInit();
    ((ISupportInitialize) this.chkFocusAccount).BeginInit();
    ((ISupportInitialize) this.dtpMap).BeginInit();
    ((ISupportInitialize) this.dtpSprinklerTest).BeginInit();
    ((ISupportInitialize) this.dtpThermo).BeginInit();
    ((ISupportInitialize) this.dtpFirePump).BeginInit();
    ((ISupportInitialize) this.dtpCPR).BeginInit();
    ((ISupportInitialize) this.dtpRecsSent).BeginInit();
    ((ISupportInitialize) this.dtpRecsFollowUp).BeginInit();
    ((ISupportInitialize) this.dtpRecsCompleted).BeginInit();
    ((ISupportInitialize) this.cboRecStatus).BeginInit();
    ((ISupportInitialize) this.err).BeginInit();
    ((ISupportInitialize) this.ugLocations).BeginInit();
    this.dvSource.BeginInit();
    ((ISupportInitialize) this.panelSearch).BeginInit();
    ((Control) this.panelSearch).SuspendLayout();
    ((ISupportInitialize) this.spinner).BeginInit();
    ((ISupportInitialize) this.tabInspections).BeginInit();
    ((Control) this.tabInspections).SuspendLayout();
    ((ISupportInitialize) this.ddRecStatus).BeginInit();
    ((ISupportInitialize) this.ddInspStatus).BeginInit();
    ((ISupportInitialize) this.ddInspectComp).BeginInit();
    this.SuspendLayout();
    label.AutoSize = true;
    label.Font = new Font("Tahoma", 12f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    label.Location = new Point(72, 14);
    label.Name = "Label27";
    label.Size = new Size(175, 19);
    label.TabIndex = 1;
    label.Text = "Loading ... Please Wait.";
    ((Control) this.utpcInspectionInformation).Controls.Add((Control) this.Label80);
    ((Control) this.utpcInspectionInformation).Controls.Add((Control) this.Label79);
    ((Control) this.utpcInspectionInformation).Controls.Add((Control) this.cboAdminInspectionTypes);
    ((Control) this.utpcInspectionInformation).Controls.Add((Control) this.lnkSelectUser);
    ((Control) this.utpcInspectionInformation).Controls.Add((Control) this.lnkPolicyInfo);
    ((Control) this.utpcInspectionInformation).Controls.Add((Control) this.lnkSearchLoc);
    ((Control) this.utpcInspectionInformation).Controls.Add((Control) this.btnNew);
    ((Control) this.utpcInspectionInformation).Controls.Add((Control) this.btnUndo);
    ((Control) this.utpcInspectionInformation).Controls.Add((Control) this.Label64);
    ((Control) this.utpcInspectionInformation).Controls.Add((Control) this.chkRecsReceived);
    ((Control) this.utpcInspectionInformation).Controls.Add((Control) this.Label63);
    ((Control) this.utpcInspectionInformation).Controls.Add((Control) this.lblNotes);
    ((Control) this.utpcInspectionInformation).Controls.Add((Control) this.txtNotes);
    ((Control) this.utpcInspectionInformation).Controls.Add((Control) this.chkRoof);
    ((Control) this.utpcInspectionInformation).Controls.Add((Control) this.Label40);
    ((Control) this.utpcInspectionInformation).Controls.Add((Control) this.Label39);
    ((Control) this.utpcInspectionInformation).Controls.Add((Control) this.dtpReceivedDate);
    ((Control) this.utpcInspectionInformation).Controls.Add((Control) this.dtpClosedDate);
    ((Control) this.utpcInspectionInformation).Controls.Add((Control) this.Label17);
    ((Control) this.utpcInspectionInformation).Controls.Add((Control) this.Label38);
    ((Control) this.utpcInspectionInformation).Controls.Add((Control) this.Label15);
    ((Control) this.utpcInspectionInformation).Controls.Add((Control) this.chkClosed);
    ((Control) this.utpcInspectionInformation).Controls.Add((Control) this.Label18);
    ((Control) this.utpcInspectionInformation).Controls.Add((Control) this.txtPolicyType);
    ((Control) this.utpcInspectionInformation).Controls.Add((Control) this.txtZip);
    ((Control) this.utpcInspectionInformation).Controls.Add((Control) this.Label29);
    ((Control) this.utpcInspectionInformation).Controls.Add((Control) this.txtInspectionContact);
    ((Control) this.utpcInspectionInformation).Controls.Add((Control) this.chkOnEndorsement);
    ((Control) this.utpcInspectionInformation).Controls.Add((Control) this.Label13);
    ((Control) this.utpcInspectionInformation).Controls.Add((Control) this.txtInspType);
    ((Control) this.utpcInspectionInformation).Controls.Add((Control) this.Label19);
    ((Control) this.utpcInspectionInformation).Controls.Add((Control) this.Label28);
    ((Control) this.utpcInspectionInformation).Controls.Add((Control) this.Label12);
    ((Control) this.utpcInspectionInformation).Controls.Add((Control) this.txtOrderedBy);
    ((Control) this.utpcInspectionInformation).Controls.Add((Control) this.txtContactPhone);
    ((Control) this.utpcInspectionInformation).Controls.Add((Control) this.Label16);
    ((Control) this.utpcInspectionInformation).Controls.Add((Control) this.dtpDropDeadDate);
    ((Control) this.utpcInspectionInformation).Controls.Add((Control) this.lnkGridReport);
    ((Control) this.utpcInspectionInformation).Controls.Add((Control) this.txtState);
    ((Control) this.utpcInspectionInformation).Controls.Add((Control) this.lnkDeSelectAll);
    ((Control) this.utpcInspectionInformation).Controls.Add((Control) this.txtCity);
    ((Control) this.utpcInspectionInformation).Controls.Add((Control) this.lnkSelectAllRows);
    ((Control) this.utpcInspectionInformation).Controls.Add((Control) this.Label14);
    ((Control) this.utpcInspectionInformation).Controls.Add((Control) this.lnkResetAllFilter);
    ((Control) this.utpcInspectionInformation).Controls.Add((Control) this.txtAddress2);
    ((Control) this.utpcInspectionInformation).Controls.Add((Control) this.Label30);
    ((Control) this.utpcInspectionInformation).Controls.Add((Control) this.Label21);
    ((Control) this.utpcInspectionInformation).Controls.Add((Control) this.cboInspectionCompany);
    ((Control) this.utpcInspectionInformation).Controls.Add((Control) this.Label11);
    ((Control) this.utpcInspectionInformation).Controls.Add((Control) this.Label26);
    ((Control) this.utpcInspectionInformation).Controls.Add((Control) this.dtpEffectiveDate);
    ((Control) this.utpcInspectionInformation).Controls.Add((Control) this.Label4);
    ((Control) this.utpcInspectionInformation).Controls.Add((Control) this.txtUnderwriter);
    ((Control) this.utpcInspectionInformation).Controls.Add((Control) this.Label3);
    ((Control) this.utpcInspectionInformation).Controls.Add((Control) this.Label20);
    ((Control) this.utpcInspectionInformation).Controls.Add((Control) this.btnFollowUp);
    ((Control) this.utpcInspectionInformation).Controls.Add((Control) this.Label10);
    ((Control) this.utpcInspectionInformation).Controls.Add((Control) this.Label2);
    ((Control) this.utpcInspectionInformation).Controls.Add((Control) this.txtAddress1);
    ((Control) this.utpcInspectionInformation).Controls.Add((Control) this.Label1);
    ((Control) this.utpcInspectionInformation).Controls.Add((Control) this.Label22);
    ((Control) this.utpcInspectionInformation).Controls.Add((Control) this.cboInspectionStatus);
    ((Control) this.utpcInspectionInformation).Controls.Add((Control) this.txtAddress);
    ((Control) this.utpcInspectionInformation).Controls.Add((Control) this.txtControlNo);
    ((Control) this.utpcInspectionInformation).Controls.Add((Control) this.txtInsured);
    ((Control) this.utpcInspectionInformation).Controls.Add((Control) this.Label37);
    ((Control) this.utpcInspectionInformation).Controls.Add((Control) this.txtLocationNumber);
    ((Control) this.utpcInspectionInformation).Controls.Add((Control) this.Label34);
    ((Control) this.utpcInspectionInformation).Controls.Add((Control) this.Label9);
    ((Control) this.utpcInspectionInformation).Controls.Add((Control) this.Label33);
    ((Control) this.utpcInspectionInformation).Controls.Add((Control) this.dtpFollowupDate);
    ((Control) this.utpcInspectionInformation).Controls.Add((Control) this.chkReceived);
    ((Control) this.utpcInspectionInformation).Controls.Add((Control) this.Label8);
    ((Control) this.utpcInspectionInformation).Controls.Add((Control) this.Label23);
    ((Control) this.utpcInspectionInformation).Controls.Add((Control) this.Label7);
    ((Control) this.utpcInspectionInformation).Controls.Add((Control) this.txtPolicyNo);
    ((Control) this.utpcInspectionInformation).Controls.Add((Control) this.dtpOrderDate);
    ((Control) this.utpcInspectionInformation).Controls.Add((Control) this.Label5);
    ((Control) this.utpcInspectionInformation).Controls.Add((Control) this.Label6);
    ((Control) this.utpcInspectionInformation).Controls.Add((Control) this.btnMakeNote);
    ((Control) this.utpcInspectionInformation).Controls.Add((Control) this.Label24);
    ((Control) this.utpcInspectionInformation).Controls.Add((Control) this.chkRevisedContactInfo);
    ((Control) this.utpcInspectionInformation).Controls.Add((Control) this.Label25);
    ((Control) this.utpcInspectionInformation).Controls.Add((Control) this.btnSave);
    ((Control) this.utpcInspectionInformation).Location = new Point(1, 30);
    ((Control) this.utpcInspectionInformation).Name = "utpcInspectionInformation";
    ((Control) this.utpcInspectionInformation).Size = new Size(908, 388);
    this.Label80.AutoSize = true;
    this.Label80.BackColor = Color.Transparent;
    this.Label80.Font = new Font("Microsoft Sans Serif", 10f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label80.ForeColor = Color.Red;
    this.Label80.Location = new Point(607, 308);
    this.Label80.Name = "Label80";
    this.Label80.Size = new Size(14, 17);
    this.Label80.TabIndex = 134;
    this.Label80.Text = "*";
    this.Label79.AutoSize = true;
    this.Label79.BackColor = Color.Transparent;
    this.Label79.Location = new Point(280, 312);
    this.Label79.Name = "Label79";
    this.Label79.Size = new Size(89, 13);
    this.Label79.TabIndex = 133;
    this.Label79.Text = "Admin Insp Type:";
    this.cboAdminInspectionTypes.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.cboAdminInspectionTypes).DataMember = "lstAdminInspectionTypes";
    ((UltraGridBase) this.cboAdminInspectionTypes).DataSource = (object) this.ds;
    appearance1.BackColor = Color.White;
    appearance1.BorderColor = Color.FromArgb(78, 122, 171);
    this.cboAdminInspectionTypes.DisplayLayout.Appearance = (AppearanceBase) appearance1;
    this.cboAdminInspectionTypes.DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridBand1.ColHeadersVisible = false;
    ((HeaderBase) ultraGridColumn1.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn1.Width = 38;
    ((HeaderBase) ultraGridColumn2.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn2.Header.VisiblePosition = 1;
    ultraGridColumn2.Width = 281;
    ultraGridBand1.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2
    });
    this.cboAdminInspectionTypes.DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    this.cboAdminInspectionTypes.DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    this.cboAdminInspectionTypes.DisplayLayout.BorderStyleCaption = (UIElementBorderStyle) 1;
    this.cboAdminInspectionTypes.DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 1;
    this.cboAdminInspectionTypes.DisplayLayout.Override.BorderStyleHeader = (UIElementBorderStyle) 1;
    this.cboAdminInspectionTypes.DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 1;
    this.cboAdminInspectionTypes.DisplayLayout.Override.BorderStyleRowSelector = (UIElementBorderStyle) 1;
    this.cboAdminInspectionTypes.DisplayLayout.Override.BorderStyleSummaryFooter = (UIElementBorderStyle) 1;
    this.cboAdminInspectionTypes.DisplayLayout.Override.BorderStyleSummaryFooterCaption = (UIElementBorderStyle) 1;
    this.cboAdminInspectionTypes.DisplayLayout.Override.BorderStyleSummaryValue = (UIElementBorderStyle) 1;
    this.cboAdminInspectionTypes.DisplayLayout.Override.BorderStyleTemplateAddRow = (UIElementBorderStyle) 1;
    appearance2.BackColor = Color.FromArgb(240 /*0xF0*/, 246, 254);
    appearance2.BorderColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this.cboAdminInspectionTypes.DisplayLayout.Override.HotTrackRowAppearance = (AppearanceBase) appearance2;
    appearance3.BorderColor = Color.White;
    this.cboAdminInspectionTypes.DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance3;
    this.cboAdminInspectionTypes.DisplayLayout.Override.RowSpacingAfter = 1;
    appearance4.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance4.BorderColor = Color.FromArgb((int) byte.MaxValue, 214, 88);
    appearance4.ForeColor = Color.Black;
    this.cboAdminInspectionTypes.DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance4;
    scrollBarLook1.ViewStyle = (ScrollBarViewStyle) 3;
    this.cboAdminInspectionTypes.DisplayLayout.ScrollBarLook = scrollBarLook1;
    ((UltraDropDownBase) this.cboAdminInspectionTypes).DisplayMember = "InspectionType";
    this.cboAdminInspectionTypes.DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboAdminInspectionTypes).DropDownWidth = 300;
    ((Control) this.cboAdminInspectionTypes).Location = new Point(401, 305);
    this.cboAdminInspectionTypes.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboAdminInspectionTypes).Name = "cboAdminInspectionTypes";
    ((Control) this.cboAdminInspectionTypes).Size = new Size(201, 20);
    ((Control) this.cboAdminInspectionTypes).TabIndex = 132;
    ((UltraControlBase) this.cboAdminInspectionTypes).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboAdminInspectionTypes).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboAdminInspectionTypes).ValueMember = "ID";
    this.ds.DataSetName = "dsAdminInspReq";
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.lnkSelectUser.AutoSize = true;
    this.lnkSelectUser.BackColor = Color.Transparent;
    this.lnkSelectUser.Location = new Point(607, 233);
    this.lnkSelectUser.Name = "lnkSelectUser";
    this.lnkSelectUser.Size = new Size(29, 13);
    this.lnkSelectUser.TabIndex = 131;
    this.lnkSelectUser.TabStop = true;
    this.lnkSelectUser.Text = "User";
    this.lnkPolicyInfo.AutoSize = true;
    this.lnkPolicyInfo.BackColor = Color.Transparent;
    this.lnkPolicyInfo.Location = new Point(231, 24);
    this.lnkPolicyInfo.Name = "lnkPolicyInfo";
    this.lnkPolicyInfo.Size = new Size(22, 13);
    this.lnkPolicyInfo.TabIndex = 130;
    this.lnkPolicyInfo.TabStop = true;
    this.lnkPolicyInfo.Text = "Pol";
    this.lnkSearchLoc.AutoSize = true;
    this.lnkSearchLoc.BackColor = Color.Transparent;
    this.lnkSearchLoc.Location = new Point(231, 90);
    this.lnkSearchLoc.Name = "lnkSearchLoc";
    this.lnkSearchLoc.Size = new Size(25, 13);
    this.lnkSearchLoc.TabIndex = 129;
    this.lnkSearchLoc.TabStop = true;
    this.lnkSearchLoc.Text = "Loc";
    ((Control) this.btnNew).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance5.BackColor = Color.Gainsboro;
    appearance5.BackColor2 = Color.White;
    appearance5.BackGradientStyle = (GradientStyle) 2;
    appearance5.BorderColor = Color.Gray;
    appearance5.ImageHAlign = (HAlign) 2;
    appearance5.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnNew).Appearance = (AppearanceBase) appearance5;
    ((ControlBase) this.btnNew).ImageSize = new Size(24, 24);
    ((ControlBase) this.btnNew).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnNew).Location = new Point(741, 338);
    ((Control) this.btnNew).Name = "btnNew";
    ((Control) this.btnNew).Size = new Size(40, 40);
    ((Control) this.btnNew).TabIndex = 128 /*0x80*/;
    this.btnNew.UseOSThemes = (DefaultableBoolean) 2;
    ((Control) this.btnNew).Visible = false;
    ((Control) this.btnUndo).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance6.BackColor = Color.Gainsboro;
    appearance6.BackColor2 = Color.White;
    appearance6.BackGradientStyle = (GradientStyle) 2;
    appearance6.BorderColor = Color.Gray;
    appearance6.ImageHAlign = (HAlign) 2;
    appearance6.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnUndo).Appearance = (AppearanceBase) appearance6;
    ((ControlBase) this.btnUndo).ImageSize = new Size(24, 24);
    ((ControlBase) this.btnUndo).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnUndo).Location = new Point(793, 338);
    ((Control) this.btnUndo).Name = "btnUndo";
    ((Control) this.btnUndo).Size = new Size(40, 40);
    ((Control) this.btnUndo).TabIndex = (int) sbyte.MaxValue;
    this.btnUndo.UseOSThemes = (DefaultableBoolean) 2;
    ((Control) this.btnUndo).Visible = false;
    this.Label64.AutoSize = true;
    this.Label64.BackColor = Color.Transparent;
    this.Label64.Font = new Font("Microsoft Sans Serif", 10f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label64.ForeColor = Color.Red;
    this.Label64.Location = new Point(249, 348);
    this.Label64.Name = "Label64";
    this.Label64.Size = new Size(14, 17);
    this.Label64.TabIndex = 126;
    this.Label64.Text = "*";
    appearance7.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance7.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkRecsReceived).Appearance = (AppearanceBase) appearance7;
    ((UltraToggleEditorBase) this.chkRecsReceived).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkRecsReceived).BackColorInternal = Color.Transparent;
    ((UltraToggleEditorBase) this.chkRecsReceived).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkRecsReceived).Location = new Point(100, 347);
    this.chkRecsReceived.MGAStyle = MGAStyles.Blue;
    ((Control) this.chkRecsReceived).Name = "chkRecsReceived";
    ((Control) this.chkRecsReceived).Size = new Size(134, 18);
    ((Control) this.chkRecsReceived).TabIndex = 125;
    ((UltraToggleEditorBase) this.chkRecsReceived).Text = "Recs Received";
    ((UltraControlBase) this.chkRecsReceived).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkRecsReceived).UseOsThemes = (DefaultableBoolean) 2;
    this.Label63.AutoSize = true;
    this.Label63.BackColor = Color.Transparent;
    this.Label63.Font = new Font("Microsoft Sans Serif", 10f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label63.ForeColor = Color.Red;
    this.Label63.Location = new Point(861, 229);
    this.Label63.Name = "Label63";
    this.Label63.Size = new Size(14, 17);
    this.Label63.TabIndex = 124;
    this.Label63.Text = "*";
    this.lblNotes.AutoSize = true;
    this.lblNotes.BackColor = Color.Transparent;
    this.lblNotes.Location = new Point(674, 209);
    this.lblNotes.Name = "lblNotes";
    this.lblNotes.Size = new Size(38, 13);
    this.lblNotes.TabIndex = 123;
    this.lblNotes.Text = "Notes:";
    this.txtNotes.Location = new Point(677, 230);
    this.txtNotes.MaxLength = 3000;
    this.txtNotes.Multiline = true;
    this.txtNotes.Name = "txtNotes";
    this.txtNotes.Size = new Size(178, 63 /*0x3F*/);
    this.txtNotes.TabIndex = 122;
    appearance8.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance8.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkRoof).Appearance = (AppearanceBase) appearance8;
    ((UltraToggleEditorBase) this.chkRoof).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkRoof).BackColorInternal = Color.Transparent;
    ((UltraToggleEditorBase) this.chkRoof).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkRoof).Location = new Point(401, 361);
    this.chkRoof.MGAStyle = MGAStyles.Blue;
    ((Control) this.chkRoof).Name = "chkRoof";
    ((Control) this.chkRoof).Size = new Size(104, 19);
    ((Control) this.chkRoof).TabIndex = 121;
    ((UltraToggleEditorBase) this.chkRoof).Text = "Roof Inspection";
    ((UltraControlBase) this.chkRoof).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkRoof).UseOsThemes = (DefaultableBoolean) 2;
    this.Label40.AutoSize = true;
    this.Label40.BackColor = Color.Transparent;
    this.Label40.Font = new Font("Microsoft Sans Serif", 10f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label40.ForeColor = Color.Red;
    this.Label40.Location = new Point(841, 42);
    this.Label40.Name = "Label40";
    this.Label40.Size = new Size(14, 17);
    this.Label40.TabIndex = 120;
    this.Label40.Text = "*";
    this.Label39.AutoSize = true;
    this.Label39.BackColor = Color.Transparent;
    this.Label39.Location = new Point(674, 44);
    this.Label39.Name = "Label39";
    this.Label39.Size = new Size(68, 13);
    this.Label39.TabIndex = 119;
    this.Label39.Text = "Closed Date:";
    appearance9.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.dtpReceivedDate.Appearance = (AppearanceBase) appearance9;
    appearance10.AlphaLevel = (short) 14;
    appearance10.BackColor = Color.FromArgb(0, 0, 246, 253);
    appearance10.BackColor2 = Color.FromArgb(133, 162, 221);
    appearance10.BackColorAlpha = (Alpha) 2;
    appearance10.BackGradientAlignment = (GradientAlignment) 4;
    appearance10.BackGradientStyle = (GradientStyle) 5;
    appearance10.BorderAlpha = (Alpha) 1;
    appearance10.BorderColor = Color.FromArgb(78, 122, 171);
    appearance10.ForeColor = Color.FromArgb(49, 85, 153);
    appearance10.ForegroundAlpha = (Alpha) 2;
    this.dtpReceivedDate.ButtonAppearance = (AppearanceBase) appearance10;
    this.dtpReceivedDate.DateTime = new DateTime(1753, 1, 1, 0, 0, 0, 0);
    ((Control) this.dtpReceivedDate).Location = new Point(401, 110);
    this.dtpReceivedDate.MGAStyle = MGAStyles.Blue;
    ((Control) this.dtpReceivedDate).Name = "dtpReceivedDate";
    ((Control) this.dtpReceivedDate).Size = new Size(84, 19);
    ((Control) this.dtpReceivedDate).TabIndex = 16 /*0x10*/;
    ((UltraControlBase) this.dtpReceivedDate).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dtpReceivedDate).UseOsThemes = (DefaultableBoolean) 2;
    this.dtpReceivedDate.Value = (object) null;
    appearance11.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.dtpClosedDate.Appearance = (AppearanceBase) appearance11;
    appearance12.AlphaLevel = (short) 14;
    appearance12.BackColor = Color.FromArgb(0, 0, 246, 253);
    appearance12.BackColor2 = Color.FromArgb(133, 162, 221);
    appearance12.BackColorAlpha = (Alpha) 2;
    appearance12.BackGradientAlignment = (GradientAlignment) 4;
    appearance12.BackGradientStyle = (GradientStyle) 5;
    appearance12.BorderAlpha = (Alpha) 1;
    appearance12.BorderColor = Color.FromArgb(78, 122, 171);
    appearance12.ForeColor = Color.FromArgb(49, 85, 153);
    appearance12.ForegroundAlpha = (Alpha) 2;
    this.dtpClosedDate.ButtonAppearance = (AppearanceBase) appearance12;
    this.dtpClosedDate.DateTime = new DateTime(1753, 1, 1, 0, 0, 0, 0);
    ((Control) this.dtpClosedDate).Location = new Point(751, 41);
    this.dtpClosedDate.MGAStyle = MGAStyles.Blue;
    ((Control) this.dtpClosedDate).Name = "dtpClosedDate";
    ((Control) this.dtpClosedDate).Size = new Size(84, 19);
    ((Control) this.dtpClosedDate).TabIndex = 26;
    ((UltraControlBase) this.dtpClosedDate).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dtpClosedDate).UseOsThemes = (DefaultableBoolean) 2;
    this.dtpClosedDate.Value = (object) null;
    this.Label17.AutoSize = true;
    this.Label17.BackColor = Color.Transparent;
    this.Label17.Location = new Point(280, 21);
    this.Label17.Name = "Label17";
    this.Label17.Size = new Size(106, 13);
    this.Label17.TabIndex = 51;
    this.Label17.Text = "Inspection Company:";
    this.Label38.AutoSize = true;
    this.Label38.BackColor = Color.Transparent;
    this.Label38.Font = new Font("Microsoft Sans Serif", 10f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label38.ForeColor = Color.Red;
    this.Label38.Location = new Point(750, 20);
    this.Label38.Name = "Label38";
    this.Label38.Size = new Size(14, 17);
    this.Label38.TabIndex = 117;
    this.Label38.Text = "*";
    this.Label15.AutoSize = true;
    this.Label15.BackColor = Color.Transparent;
    this.Label15.Location = new Point(23, 257);
    this.Label15.Name = "Label15";
    this.Label15.Size = new Size(25, 13);
    this.Label15.TabIndex = 48 /*0x30*/;
    this.Label15.Text = "Zip:";
    appearance13.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance13.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkClosed).Appearance = (AppearanceBase) appearance13;
    ((UltraToggleEditorBase) this.chkClosed).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkClosed).BackColorInternal = Color.Transparent;
    ((UltraToggleEditorBase) this.chkClosed).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkClosed).Location = new Point(677, 19);
    this.chkClosed.MGAStyle = MGAStyles.Blue;
    ((Control) this.chkClosed).Name = "chkClosed";
    ((Control) this.chkClosed).Size = new Size(65, 19);
    ((Control) this.chkClosed).TabIndex = 25;
    ((UltraToggleEditorBase) this.chkClosed).Text = "Closed";
    ((UltraControlBase) this.chkClosed).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkClosed).UseOsThemes = (DefaultableBoolean) 2;
    this.Label18.AutoSize = true;
    this.Label18.BackColor = Color.Transparent;
    this.Label18.Location = new Point(280, 44);
    this.Label18.Name = "Label18";
    this.Label18.Size = new Size(99, 13);
    this.Label18.TabIndex = 53;
    this.Label18.Text = "Inspection Contact:";
    this.txtPolicyType.Location = new Point(401, 279);
    this.txtPolicyType.MaxLength = 150;
    this.txtPolicyType.Name = "txtPolicyType";
    this.txtPolicyType.Size = new Size(201, 20);
    this.txtPolicyType.TabIndex = 23;
    this.txtZip.Location = new Point(100, 253);
    this.txtZip.MaxLength = 150;
    this.txtZip.Name = "txtZip";
    this.txtZip.Size = new Size(124, 20);
    this.txtZip.TabIndex = 9;
    this.Label29.AutoSize = true;
    this.Label29.BackColor = Color.Transparent;
    this.Label29.Location = new Point(280, 282);
    this.Label29.Name = "Label29";
    this.Label29.Size = new Size(65, 13);
    this.Label29.TabIndex = 114;
    this.Label29.Text = "Policy Type:";
    this.txtInspectionContact.Location = new Point(401, 40);
    this.txtInspectionContact.MaxLength = 150;
    this.txtInspectionContact.Name = "txtInspectionContact";
    this.txtInspectionContact.Size = new Size(137, 20);
    this.txtInspectionContact.TabIndex = 13;
    appearance14.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance14.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkOnEndorsement).Appearance = (AppearanceBase) appearance14;
    ((UltraToggleEditorBase) this.chkOnEndorsement).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkOnEndorsement).BackColorInternal = Color.Transparent;
    ((UltraToggleEditorBase) this.chkOnEndorsement).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkOnEndorsement).Location = new Point(401, 330);
    this.chkOnEndorsement.MGAStyle = MGAStyles.Blue;
    ((Control) this.chkOnEndorsement).Name = "chkOnEndorsement";
    ((Control) this.chkOnEndorsement).Size = new Size(157, 27);
    ((Control) this.chkOnEndorsement).TabIndex = 24;
    ((UltraToggleEditorBase) this.chkOnEndorsement).Text = "Endorsement (@ ordering)";
    ((UltraControlBase) this.chkOnEndorsement).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkOnEndorsement).UseOsThemes = (DefaultableBoolean) 2;
    this.Label13.AutoSize = true;
    this.Label13.BackColor = Color.Transparent;
    this.Label13.Location = new Point(23, 234);
    this.Label13.Name = "Label13";
    this.Label13.Size = new Size(35, 13);
    this.Label13.TabIndex = 42;
    this.Label13.Text = "State:";
    this.txtInspType.Location = new Point(401, 253);
    this.txtInspType.MaxLength = 150;
    this.txtInspType.Name = "txtInspType";
    this.txtInspType.Size = new Size(201, 20);
    this.txtInspType.TabIndex = 22;
    this.Label19.AutoSize = true;
    this.Label19.BackColor = Color.Transparent;
    this.Label19.Location = new Point(280, 67);
    this.Label19.Name = "Label19";
    this.Label19.Size = new Size(81, 13);
    this.Label19.TabIndex = 55;
    this.Label19.Text = "Contact Phone:";
    this.Label28.AutoSize = true;
    this.Label28.BackColor = Color.Transparent;
    this.Label28.Location = new Point(280, 256 /*0x0100*/);
    this.Label28.Name = "Label28";
    this.Label28.Size = new Size(86, 13);
    this.Label28.TabIndex = 111;
    this.Label28.Text = "Inspection Type:";
    this.Label12.AutoSize = true;
    this.Label12.BackColor = Color.Transparent;
    this.Label12.Location = new Point(23, 211);
    this.Label12.Name = "Label12";
    this.Label12.Size = new Size(27, 13);
    this.Label12.TabIndex = 41;
    this.Label12.Text = "City:";
    this.txtOrderedBy.Location = new Point(401, 230);
    this.txtOrderedBy.MaxLength = 150;
    this.txtOrderedBy.Name = "txtOrderedBy";
    this.txtOrderedBy.ReadOnly = true;
    this.txtOrderedBy.Size = new Size(201, 20);
    this.txtOrderedBy.TabIndex = 21;
    this.txtContactPhone.Location = new Point(401, 64 /*0x40*/);
    this.txtContactPhone.MaxLength = 150;
    this.txtContactPhone.Name = "txtContactPhone";
    this.txtContactPhone.Size = new Size(137, 20);
    this.txtContactPhone.TabIndex = 14;
    this.Label16.AutoSize = true;
    this.Label16.BackColor = Color.Transparent;
    this.Label16.Location = new Point(280, 233);
    this.Label16.Name = "Label16";
    this.Label16.Size = new Size(63 /*0x3F*/, 13);
    this.Label16.TabIndex = 109;
    this.Label16.Text = "Ordered By:";
    appearance15.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.dtpDropDeadDate.Appearance = (AppearanceBase) appearance15;
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
    this.dtpDropDeadDate.ButtonAppearance = (AppearanceBase) appearance16;
    this.dtpDropDeadDate.DateTime = new DateTime(1753, 1, 1, 0, 0, 0, 0);
    ((Control) this.dtpDropDeadDate).Location = new Point(401, 135);
    this.dtpDropDeadDate.MGAStyle = MGAStyles.Blue;
    ((Control) this.dtpDropDeadDate).Name = "dtpDropDeadDate";
    ((EditorButtonControlBase) this.dtpDropDeadDate).ReadOnly = true;
    ((Control) this.dtpDropDeadDate).Size = new Size(84, 19);
    ((Control) this.dtpDropDeadDate).TabIndex = 17;
    ((UltraControlBase) this.dtpDropDeadDate).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dtpDropDeadDate).UseOsThemes = (DefaultableBoolean) 2;
    this.dtpDropDeadDate.Value = (object) null;
    this.lnkGridReport.AutoSize = true;
    this.lnkGridReport.BackColor = Color.Transparent;
    this.lnkGridReport.Location = new Point(674, 188);
    this.lnkGridReport.Name = "lnkGridReport";
    this.lnkGridReport.Size = new Size(130, 13);
    this.lnkGridReport.TabIndex = 32 /*0x20*/;
    this.lnkGridReport.TabStop = true;
    this.lnkGridReport.Text = "Get Report from Grid Data";
    this.txtState.Location = new Point(100, 230);
    this.txtState.MaxLength = 150;
    this.txtState.Name = "txtState";
    this.txtState.Size = new Size(154, 20);
    this.txtState.TabIndex = 8;
    this.lnkDeSelectAll.AutoSize = true;
    this.lnkDeSelectAll.BackColor = Color.Transparent;
    this.lnkDeSelectAll.Location = new Point(674, 91);
    this.lnkDeSelectAll.Name = "lnkDeSelectAll";
    this.lnkDeSelectAll.Size = new Size(116, 13);
    this.lnkDeSelectAll.TabIndex = 28;
    this.lnkDeSelectAll.TabStop = true;
    this.lnkDeSelectAll.Text = "De-Select All Follow-up";
    this.txtCity.Location = new Point(100, 207);
    this.txtCity.MaxLength = 150;
    this.txtCity.Name = "txtCity";
    this.txtCity.Size = new Size(154, 20);
    this.txtCity.TabIndex = 7;
    this.lnkSelectAllRows.AutoSize = true;
    this.lnkSelectAllRows.BackColor = Color.Transparent;
    this.lnkSelectAllRows.Location = new Point(674, 68);
    this.lnkSelectAllRows.Name = "lnkSelectAllRows";
    this.lnkSelectAllRows.Size = new Size(117, 13);
    this.lnkSelectAllRows.TabIndex = 27;
    this.lnkSelectAllRows.TabStop = true;
    this.lnkSelectAllRows.Text = "Select All For Follow-up";
    this.Label14.AutoSize = true;
    this.Label14.BackColor = Color.Transparent;
    this.Label14.Location = new Point(280, 137);
    this.Label14.Name = "Label14";
    this.Label14.Size = new Size(88, 13);
    this.Label14.TabIndex = 46;
    this.Label14.Text = "Drop Dead Date:";
    this.lnkResetAllFilter.AutoSize = true;
    this.lnkResetAllFilter.BackColor = Color.Transparent;
    this.lnkResetAllFilter.Location = new Point(674, 113);
    this.lnkResetAllFilter.Name = "lnkResetAllFilter";
    this.lnkResetAllFilter.Size = new Size(79, 13);
    this.lnkResetAllFilter.TabIndex = 29;
    this.lnkResetAllFilter.TabStop = true;
    this.lnkResetAllFilter.Text = "Reset All Filters";
    this.txtAddress2.Location = new Point(100, 184);
    this.txtAddress2.MaxLength = 150;
    this.txtAddress2.Name = "txtAddress2";
    this.txtAddress2.Size = new Size(154, 20);
    this.txtAddress2.TabIndex = 6;
    this.Label30.AutoSize = true;
    this.Label30.BackColor = Color.Transparent;
    this.Label30.Font = new Font("Microsoft Sans Serif", 10f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label30.ForeColor = Color.Red;
    this.Label30.Location = new Point(495, 112 /*0x70*/);
    this.Label30.Name = "Label30";
    this.Label30.Size = new Size(14, 17);
    this.Label30.TabIndex = 104;
    this.Label30.Text = "*";
    this.Label21.AutoSize = true;
    this.Label21.BackColor = Color.Transparent;
    this.Label21.Location = new Point(23, 280);
    this.Label21.Name = "Label21";
    this.Label21.Size = new Size(64 /*0x40*/, 13);
    this.Label21.TabIndex = 59;
    this.Label21.Text = "Underwriter:";
    this.cboInspectionCompany.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.cboInspectionCompany).DataMember = "tblFin_ExpensePayees";
    ((UltraGridBase) this.cboInspectionCompany).DataSource = (object) this.ds;
    appearance17.BackColor = Color.White;
    appearance17.BorderColor = Color.FromArgb(78, 122, 171);
    this.cboInspectionCompany.DisplayLayout.Appearance = (AppearanceBase) appearance17;
    this.cboInspectionCompany.DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridBand2.ColHeadersVisible = false;
    ((HeaderBase) ultraGridColumn3.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn3.Header.VisiblePosition = 0;
    ultraGridColumn3.Hidden = true;
    ultraGridColumn3.Width = 141;
    ((HeaderBase) ultraGridColumn4.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn4.Header.VisiblePosition = 1;
    ultraGridColumn4.Width = 331;
    ultraGridBand2.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn3,
      (object) ultraGridColumn4
    });
    this.cboInspectionCompany.DisplayLayout.BandsSerializer.Add((object) ultraGridBand2);
    this.cboInspectionCompany.DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    this.cboInspectionCompany.DisplayLayout.BorderStyleCaption = (UIElementBorderStyle) 1;
    this.cboInspectionCompany.DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 1;
    this.cboInspectionCompany.DisplayLayout.Override.BorderStyleHeader = (UIElementBorderStyle) 1;
    this.cboInspectionCompany.DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 1;
    this.cboInspectionCompany.DisplayLayout.Override.BorderStyleRowSelector = (UIElementBorderStyle) 1;
    this.cboInspectionCompany.DisplayLayout.Override.BorderStyleSummaryFooter = (UIElementBorderStyle) 1;
    this.cboInspectionCompany.DisplayLayout.Override.BorderStyleSummaryFooterCaption = (UIElementBorderStyle) 1;
    this.cboInspectionCompany.DisplayLayout.Override.BorderStyleSummaryValue = (UIElementBorderStyle) 1;
    this.cboInspectionCompany.DisplayLayout.Override.BorderStyleTemplateAddRow = (UIElementBorderStyle) 1;
    appearance18.BackColor = Color.FromArgb(240 /*0xF0*/, 246, 254);
    appearance18.BorderColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this.cboInspectionCompany.DisplayLayout.Override.HotTrackRowAppearance = (AppearanceBase) appearance18;
    appearance19.BorderColor = Color.White;
    this.cboInspectionCompany.DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance19;
    this.cboInspectionCompany.DisplayLayout.Override.RowSpacingAfter = 1;
    appearance20.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance20.BorderColor = Color.FromArgb((int) byte.MaxValue, 214, 88);
    appearance20.ForeColor = Color.Black;
    this.cboInspectionCompany.DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance20;
    scrollBarLook2.ViewStyle = (ScrollBarViewStyle) 3;
    this.cboInspectionCompany.DisplayLayout.ScrollBarLook = scrollBarLook2;
    ((UltraDropDownBase) this.cboInspectionCompany).DisplayMember = "PayeeName";
    this.cboInspectionCompany.DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboInspectionCompany).DropDownWidth = 350;
    ((Control) this.cboInspectionCompany).Location = new Point(401, 18);
    this.cboInspectionCompany.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboInspectionCompany).Name = "cboInspectionCompany";
    ((Control) this.cboInspectionCompany).Size = new Size(231, 20);
    ((Control) this.cboInspectionCompany).TabIndex = 12;
    ((UltraControlBase) this.cboInspectionCompany).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboInspectionCompany).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboInspectionCompany).ValueMember = "PayeeID";
    this.Label11.AutoSize = true;
    this.Label11.BackColor = Color.Transparent;
    this.Label11.Location = new Point(23, 188);
    this.Label11.Name = "Label11";
    this.Label11.Size = new Size(57, 13);
    this.Label11.TabIndex = 37;
    this.Label11.Text = "Address 2:";
    this.Label26.AutoSize = true;
    this.Label26.BackColor = Color.Transparent;
    this.Label26.Font = new Font("Microsoft Sans Serif", 10f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label26.ForeColor = Color.Red;
    this.Label26.Location = new Point(648, 20);
    this.Label26.Name = "Label26";
    this.Label26.Size = new Size(14, 17);
    this.Label26.TabIndex = 94;
    this.Label26.Text = "*";
    appearance21.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.dtpEffectiveDate.Appearance = (AppearanceBase) appearance21;
    appearance22.AlphaLevel = (short) 14;
    appearance22.BackColor = Color.FromArgb(0, 0, 246, 253);
    appearance22.BackColor2 = Color.FromArgb(133, 162, 221);
    appearance22.BackColorAlpha = (Alpha) 2;
    appearance22.BackGradientAlignment = (GradientAlignment) 4;
    appearance22.BackGradientStyle = (GradientStyle) 5;
    appearance22.BorderAlpha = (Alpha) 1;
    appearance22.BorderColor = Color.FromArgb(78, 122, 171);
    appearance22.ForeColor = Color.FromArgb(49, 85, 153);
    appearance22.ForegroundAlpha = (Alpha) 2;
    this.dtpEffectiveDate.ButtonAppearance = (AppearanceBase) appearance22;
    this.dtpEffectiveDate.DateTime = new DateTime(1753, 1, 1, 0, 0, 0, 0);
    ((Control) this.dtpEffectiveDate).Location = new Point(401, 88);
    this.dtpEffectiveDate.MGAStyle = MGAStyles.Blue;
    ((Control) this.dtpEffectiveDate).Name = "dtpEffectiveDate";
    ((EditorButtonControlBase) this.dtpEffectiveDate).ReadOnly = true;
    ((Control) this.dtpEffectiveDate).Size = new Size(84, 19);
    ((Control) this.dtpEffectiveDate).TabIndex = 15;
    ((UltraControlBase) this.dtpEffectiveDate).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dtpEffectiveDate).UseOsThemes = (DefaultableBoolean) 2;
    this.dtpEffectiveDate.Value = (object) null;
    this.Label4.AutoSize = true;
    this.Label4.BackColor = Color.Transparent;
    this.Label4.Font = new Font("Microsoft Sans Serif", 10f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label4.ForeColor = Color.Red;
    this.Label4.Location = new Point(544, 42);
    this.Label4.Name = "Label4";
    this.Label4.Size = new Size(14, 17);
    this.Label4.TabIndex = 93;
    this.Label4.Text = "*";
    this.txtUnderwriter.Location = new Point(102, 273);
    this.txtUnderwriter.MaxLength = 150;
    this.txtUnderwriter.Name = "txtUnderwriter";
    this.txtUnderwriter.Size = new Size(154, 20);
    this.txtUnderwriter.TabIndex = 9;
    this.Label3.AutoSize = true;
    this.Label3.BackColor = Color.Transparent;
    this.Label3.Font = new Font("Microsoft Sans Serif", 10f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label3.ForeColor = Color.Red;
    this.Label3.Location = new Point(544, 69);
    this.Label3.Name = "Label3";
    this.Label3.Size = new Size(14, 17);
    this.Label3.TabIndex = 92;
    this.Label3.Text = "*";
    this.Label20.AutoSize = true;
    this.Label20.BackColor = Color.Transparent;
    this.Label20.Location = new Point(280, 90);
    this.Label20.Name = "Label20";
    this.Label20.Size = new Size(78, 13);
    this.Label20.TabIndex = 58;
    this.Label20.Text = "Effective Date:";
    this.btnFollowUp.Location = new Point(677, 131);
    this.btnFollowUp.Name = "btnFollowUp";
    this.btnFollowUp.Size = new Size(124, 27);
    this.btnFollowUp.TabIndex = 30;
    this.btnFollowUp.Text = "Follow Up";
    this.btnFollowUp.UseVisualStyleBackColor = true;
    this.Label10.AutoSize = true;
    this.Label10.BackColor = Color.Transparent;
    this.Label10.Location = new Point(23, 165);
    this.Label10.Name = "Label10";
    this.Label10.Size = new Size(57, 13);
    this.Label10.TabIndex = 30;
    this.Label10.Text = "Address 1:";
    this.Label2.AutoSize = true;
    this.Label2.BackColor = Color.Transparent;
    this.Label2.Font = new Font("Microsoft Sans Serif", 10f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label2.ForeColor = Color.Red;
    this.Label2.Location = new Point(610, 207);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(14, 17);
    this.Label2.TabIndex = 90;
    this.Label2.Text = "*";
    this.txtAddress1.Location = new Point(100, 161);
    this.txtAddress1.MaxLength = 150;
    this.txtAddress1.Name = "txtAddress1";
    this.txtAddress1.Size = new Size(154, 20);
    this.txtAddress1.TabIndex = 5;
    this.Label1.AutoSize = true;
    this.Label1.BackColor = Color.Transparent;
    this.Label1.Location = new Point(282, 210);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(92, 13);
    this.Label1.TabIndex = 89;
    this.Label1.Text = "Inspection Status:";
    this.Label22.AutoSize = true;
    this.Label22.BackColor = Color.Transparent;
    this.Label22.Location = new Point(280, 112 /*0x70*/);
    this.Label22.Name = "Label22";
    this.Label22.Size = new Size(82, 13);
    this.Label22.TabIndex = 62;
    this.Label22.Text = "Received Date:";
    this.cboInspectionStatus.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.cboInspectionStatus).DataMember = "lstAdminInspectionStatus";
    ((UltraGridBase) this.cboInspectionStatus).DataSource = (object) this.ds;
    appearance23.BackColor = Color.White;
    appearance23.BorderColor = Color.FromArgb(78, 122, 171);
    this.cboInspectionStatus.DisplayLayout.Appearance = (AppearanceBase) appearance23;
    this.cboInspectionStatus.DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridBand3.ColHeadersVisible = false;
    ((HeaderBase) ultraGridColumn5.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn5.Header.VisiblePosition = 0;
    ultraGridColumn5.Hidden = true;
    ultraGridColumn5.Width = 38;
    ((HeaderBase) ultraGridColumn6.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn6.Header.VisiblePosition = 1;
    ultraGridColumn6.Width = 281;
    ultraGridBand3.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn5,
      (object) ultraGridColumn6
    });
    this.cboInspectionStatus.DisplayLayout.BandsSerializer.Add((object) ultraGridBand3);
    this.cboInspectionStatus.DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    this.cboInspectionStatus.DisplayLayout.BorderStyleCaption = (UIElementBorderStyle) 1;
    this.cboInspectionStatus.DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 1;
    this.cboInspectionStatus.DisplayLayout.Override.BorderStyleHeader = (UIElementBorderStyle) 1;
    this.cboInspectionStatus.DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 1;
    this.cboInspectionStatus.DisplayLayout.Override.BorderStyleRowSelector = (UIElementBorderStyle) 1;
    this.cboInspectionStatus.DisplayLayout.Override.BorderStyleSummaryFooter = (UIElementBorderStyle) 1;
    this.cboInspectionStatus.DisplayLayout.Override.BorderStyleSummaryFooterCaption = (UIElementBorderStyle) 1;
    this.cboInspectionStatus.DisplayLayout.Override.BorderStyleSummaryValue = (UIElementBorderStyle) 1;
    this.cboInspectionStatus.DisplayLayout.Override.BorderStyleTemplateAddRow = (UIElementBorderStyle) 1;
    appearance24.BackColor = Color.FromArgb(240 /*0xF0*/, 246, 254);
    appearance24.BorderColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this.cboInspectionStatus.DisplayLayout.Override.HotTrackRowAppearance = (AppearanceBase) appearance24;
    appearance25.BorderColor = Color.White;
    this.cboInspectionStatus.DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance25;
    this.cboInspectionStatus.DisplayLayout.Override.RowSpacingAfter = 1;
    appearance26.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance26.BorderColor = Color.FromArgb((int) byte.MaxValue, 214, 88);
    appearance26.ForeColor = Color.Black;
    this.cboInspectionStatus.DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance26;
    scrollBarLook3.ViewStyle = (ScrollBarViewStyle) 3;
    this.cboInspectionStatus.DisplayLayout.ScrollBarLook = scrollBarLook3;
    ((UltraDropDownBase) this.cboInspectionStatus).DisplayMember = "InspectionStatus";
    this.cboInspectionStatus.DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboInspectionStatus).DropDownWidth = 300;
    ((Control) this.cboInspectionStatus).Location = new Point(401, 207);
    this.cboInspectionStatus.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboInspectionStatus).Name = "cboInspectionStatus";
    ((Control) this.cboInspectionStatus).Size = new Size(201, 20);
    ((Control) this.cboInspectionStatus).TabIndex = 20;
    ((UltraControlBase) this.cboInspectionStatus).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboInspectionStatus).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboInspectionStatus).ValueMember = "ID";
    this.txtAddress.Location = new Point(100, 110);
    this.txtAddress.MaxLength = 150;
    this.txtAddress.Multiline = true;
    this.txtAddress.Name = "txtAddress";
    this.txtAddress.Size = new Size(154, 48 /*0x30*/);
    this.txtAddress.TabIndex = 4;
    this.txtControlNo.Location = new Point(100, 18);
    this.txtControlNo.MaxLength = 150;
    this.txtControlNo.Name = "txtControlNo";
    this.txtControlNo.ReadOnly = true;
    this.txtControlNo.Size = new Size(125, 20);
    this.txtControlNo.TabIndex = 0;
    this.txtInsured.Location = new Point(100, 64 /*0x40*/);
    this.txtInsured.MaxLength = 150;
    this.txtInsured.Name = "txtInsured";
    this.txtInsured.Size = new Size(125, 20);
    this.txtInsured.TabIndex = 2;
    this.Label37.AutoSize = true;
    this.Label37.BackColor = Color.Transparent;
    this.Label37.Font = new Font("Microsoft Sans Serif", 10f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label37.ForeColor = Color.Red;
    this.Label37.Location = new Point(249, 325);
    this.Label37.Name = "Label37";
    this.Label37.Size = new Size(14, 17);
    this.Label37.TabIndex = 86;
    this.Label37.Text = "*";
    this.txtLocationNumber.Location = new Point(100, 87);
    this.txtLocationNumber.MaxLength = 150;
    this.txtLocationNumber.Name = "txtLocationNumber";
    this.txtLocationNumber.ReadOnly = true;
    this.txtLocationNumber.Size = new Size(125, 20);
    this.txtLocationNumber.TabIndex = 3;
    this.Label34.AutoSize = true;
    this.Label34.BackColor = Color.Transparent;
    this.Label34.Font = new Font("Microsoft Sans Serif", 10f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label34.ForeColor = Color.Red;
    this.Label34.Location = new Point(495, 186);
    this.Label34.Name = "Label34";
    this.Label34.Size = new Size(14, 17);
    this.Label34.TabIndex = 83;
    this.Label34.Text = "*";
    this.Label9.AutoSize = true;
    this.Label9.BackColor = Color.Transparent;
    this.Label9.Location = new Point(23, 138);
    this.Label9.Name = "Label9";
    this.Label9.Size = new Size(48 /*0x30*/, 13);
    this.Label9.TabIndex = 29;
    this.Label9.Text = "Address:";
    this.Label33.AutoSize = true;
    this.Label33.BackColor = Color.Transparent;
    this.Label33.Font = new Font("Microsoft Sans Serif", 10f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label33.ForeColor = Color.Red;
    this.Label33.Location = new Point(249, 302);
    this.Label33.Name = "Label33";
    this.Label33.Size = new Size(14, 17);
    this.Label33.TabIndex = 82;
    this.Label33.Text = "*";
    appearance27.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.dtpFollowupDate.Appearance = (AppearanceBase) appearance27;
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
    this.dtpFollowupDate.ButtonAppearance = (AppearanceBase) appearance28;
    this.dtpFollowupDate.DateTime = new DateTime(1753, 1, 1, 0, 0, 0, 0);
    ((Control) this.dtpFollowupDate).Location = new Point(401, 185);
    this.dtpFollowupDate.MGAStyle = MGAStyles.Blue;
    ((Control) this.dtpFollowupDate).Name = "dtpFollowupDate";
    ((Control) this.dtpFollowupDate).Size = new Size(84, 19);
    ((Control) this.dtpFollowupDate).TabIndex = 19;
    ((UltraControlBase) this.dtpFollowupDate).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dtpFollowupDate).UseOsThemes = (DefaultableBoolean) 2;
    this.dtpFollowupDate.Value = (object) null;
    appearance29.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance29.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkReceived).Appearance = (AppearanceBase) appearance29;
    ((UltraToggleEditorBase) this.chkReceived).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkReceived).BackColorInternal = Color.Transparent;
    ((UltraToggleEditorBase) this.chkReceived).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkReceived).Location = new Point(100, 323);
    this.chkReceived.MGAStyle = MGAStyles.Blue;
    ((Control) this.chkReceived).Name = "chkReceived";
    ((Control) this.chkReceived).Size = new Size(134, 20);
    ((Control) this.chkReceived).TabIndex = 11;
    ((UltraToggleEditorBase) this.chkReceived).Text = "Inspection Received";
    ((UltraControlBase) this.chkReceived).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkReceived).UseOsThemes = (DefaultableBoolean) 2;
    this.Label8.AutoSize = true;
    this.Label8.BackColor = Color.Transparent;
    this.Label8.Location = new Point(23, 94);
    this.Label8.Name = "Label8";
    this.Label8.Size = new Size(61, 13);
    this.Label8.TabIndex = 28;
    this.Label8.Text = "Location #:";
    this.Label23.AutoSize = true;
    this.Label23.BackColor = Color.Transparent;
    this.Label23.Location = new Point(280, 187);
    this.Label23.Name = "Label23";
    this.Label23.Size = new Size(81, 13);
    this.Label23.TabIndex = 68;
    this.Label23.Text = "Follow-up Date:";
    this.Label7.AutoSize = true;
    this.Label7.BackColor = Color.Transparent;
    this.Label7.Location = new Point(23, 68);
    this.Label7.Name = "Label7";
    this.Label7.Size = new Size(45, 13);
    this.Label7.TabIndex = 27;
    this.Label7.Text = "Insured:";
    this.txtPolicyNo.Location = new Point(100, 41);
    this.txtPolicyNo.MaxLength = 150;
    this.txtPolicyNo.Name = "txtPolicyNo";
    this.txtPolicyNo.Size = new Size(125, 20);
    this.txtPolicyNo.TabIndex = 1;
    appearance30.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.dtpOrderDate.Appearance = (AppearanceBase) appearance30;
    appearance31.AlphaLevel = (short) 14;
    appearance31.BackColor = Color.FromArgb(0, 0, 246, 253);
    appearance31.BackColor2 = Color.FromArgb(133, 162, 221);
    appearance31.BackColorAlpha = (Alpha) 2;
    appearance31.BackGradientAlignment = (GradientAlignment) 4;
    appearance31.BackGradientStyle = (GradientStyle) 5;
    appearance31.BorderAlpha = (Alpha) 1;
    appearance31.BorderColor = Color.FromArgb(78, 122, 171);
    appearance31.ForeColor = Color.FromArgb(49, 85, 153);
    appearance31.ForegroundAlpha = (Alpha) 2;
    this.dtpOrderDate.ButtonAppearance = (AppearanceBase) appearance31;
    this.dtpOrderDate.DateTime = new DateTime(1753, 1, 1, 0, 0, 0, 0);
    ((Control) this.dtpOrderDate).Location = new Point(401, 162);
    this.dtpOrderDate.MGAStyle = MGAStyles.Blue;
    ((Control) this.dtpOrderDate).Name = "dtpOrderDate";
    ((EditorButtonControlBase) this.dtpOrderDate).ReadOnly = true;
    ((Control) this.dtpOrderDate).Size = new Size(84, 19);
    ((Control) this.dtpOrderDate).TabIndex = 18;
    ((UltraControlBase) this.dtpOrderDate).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dtpOrderDate).UseOsThemes = (DefaultableBoolean) 2;
    this.dtpOrderDate.Value = (object) null;
    this.Label5.AutoSize = true;
    this.Label5.BackColor = Color.Transparent;
    this.Label5.Location = new Point(23, 22);
    this.Label5.Name = "Label5";
    this.Label5.Size = new Size(53, 13);
    this.Label5.TabIndex = 25;
    this.Label5.Text = "Control #:";
    this.Label6.AutoSize = true;
    this.Label6.BackColor = Color.Transparent;
    this.Label6.Location = new Point(23, 45);
    this.Label6.Name = "Label6";
    this.Label6.Size = new Size(48 /*0x30*/, 13);
    this.Label6.TabIndex = 26;
    this.Label6.Text = "Policy #:";
    this.btnMakeNote.Location = new Point(677, 158);
    this.btnMakeNote.Name = "btnMakeNote";
    this.btnMakeNote.Size = new Size(124, 27);
    this.btnMakeNote.TabIndex = 31 /*0x1F*/;
    this.btnMakeNote.Text = "Make Inspection Note";
    this.btnMakeNote.UseVisualStyleBackColor = true;
    this.Label24.AutoSize = true;
    this.Label24.BackColor = Color.Transparent;
    this.Label24.Location = new Point(280, 164);
    this.Label24.Name = "Label24";
    this.Label24.Size = new Size(62, 13);
    this.Label24.TabIndex = 70;
    this.Label24.Text = "Order Date:";
    appearance32.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance32.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkRevisedContactInfo).Appearance = (AppearanceBase) appearance32;
    ((UltraToggleEditorBase) this.chkRevisedContactInfo).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkRevisedContactInfo).BackColorInternal = Color.Transparent;
    ((UltraToggleEditorBase) this.chkRevisedContactInfo).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkRevisedContactInfo).Location = new Point(100, 302);
    this.chkRevisedContactInfo.MGAStyle = MGAStyles.Blue;
    ((Control) this.chkRevisedContactInfo).Name = "chkRevisedContactInfo";
    ((Control) this.chkRevisedContactInfo).Size = new Size(134, 17);
    ((Control) this.chkRevisedContactInfo).TabIndex = 10;
    ((UltraToggleEditorBase) this.chkRevisedContactInfo).Text = "Revised Contact Info";
    ((UltraControlBase) this.chkRevisedContactInfo).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkRevisedContactInfo).UseOsThemes = (DefaultableBoolean) 2;
    this.Label25.AutoSize = true;
    this.Label25.BackColor = Color.Transparent;
    this.Label25.Font = new Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label25.ForeColor = Color.Black;
    this.Label25.Location = new Point(637, 312);
    this.Label25.Name = "Label25";
    this.Label25.Size = new Size(197, 13);
    this.Label25.TabIndex = 36;
    this.Label25.Text = "Only Asterisked Controls Updated";
    ((Control) this.btnSave).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance33.BackColor = Color.Gainsboro;
    appearance33.BackColor2 = Color.White;
    appearance33.BackGradientStyle = (GradientStyle) 2;
    appearance33.BorderColor = Color.Gray;
    appearance33.ImageHAlign = (HAlign) 2;
    appearance33.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnSave).Appearance = (AppearanceBase) appearance33;
    ((ControlBase) this.btnSave).ImageSize = new Size(24, 24);
    ((ControlBase) this.btnSave).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnSave).Location = new Point(855, 338);
    ((Control) this.btnSave).Name = "btnSave";
    ((Control) this.btnSave).Size = new Size(40, 40);
    ((Control) this.btnSave).TabIndex = 35;
    this.btnSave.UseOSThemes = (DefaultableBoolean) 2;
    ((Control) this.utcRecommendations).Controls.Add((Control) this.dtLastAssessmentDate);
    ((Control) this.utcRecommendations).Controls.Add((Control) this.Label77);
    ((Control) this.utcRecommendations).Controls.Add((Control) this.Label78);
    ((Control) this.utcRecommendations).Controls.Add((Control) this.Label76);
    ((Control) this.utcRecommendations).Controls.Add((Control) this.Label75);
    ((Control) this.utcRecommendations).Controls.Add((Control) this.Label74);
    ((Control) this.utcRecommendations).Controls.Add((Control) this.Label73);
    ((Control) this.utcRecommendations).Controls.Add((Control) this.Label72);
    ((Control) this.utcRecommendations).Controls.Add((Control) this.Label71);
    ((Control) this.utcRecommendations).Controls.Add((Control) this.chkCriticalAccount);
    ((Control) this.utcRecommendations).Controls.Add((Control) this.Label70);
    ((Control) this.utcRecommendations).Controls.Add((Control) this.chkFocusAccount);
    ((Control) this.utcRecommendations).Controls.Add((Control) this.dtpMap);
    ((Control) this.utcRecommendations).Controls.Add((Control) this.Label69);
    ((Control) this.utcRecommendations).Controls.Add((Control) this.dtpSprinklerTest);
    ((Control) this.utcRecommendations).Controls.Add((Control) this.Label68);
    ((Control) this.utcRecommendations).Controls.Add((Control) this.dtpThermo);
    ((Control) this.utcRecommendations).Controls.Add((Control) this.Label67);
    ((Control) this.utcRecommendations).Controls.Add((Control) this.dtpFirePump);
    ((Control) this.utcRecommendations).Controls.Add((Control) this.Label66);
    ((Control) this.utcRecommendations).Controls.Add((Control) this.dtpCPR);
    ((Control) this.utcRecommendations).Controls.Add((Control) this.Label65);
    ((Control) this.utcRecommendations).Controls.Add((Control) this.dtpRecsSent);
    ((Control) this.utcRecommendations).Controls.Add((Control) this.dtpRecsFollowUp);
    ((Control) this.utcRecommendations).Controls.Add((Control) this.dtpRecsCompleted);
    ((Control) this.utcRecommendations).Controls.Add((Control) this.Label62);
    ((Control) this.utcRecommendations).Controls.Add((Control) this.Label61);
    ((Control) this.utcRecommendations).Controls.Add((Control) this.Label60);
    ((Control) this.utcRecommendations).Controls.Add((Control) this.Label59);
    ((Control) this.utcRecommendations).Controls.Add((Control) this.Label58);
    ((Control) this.utcRecommendations).Controls.Add((Control) this.Label57);
    ((Control) this.utcRecommendations).Controls.Add((Control) this.Label56);
    ((Control) this.utcRecommendations).Controls.Add((Control) this.Label55);
    ((Control) this.utcRecommendations).Controls.Add((Control) this.Label54);
    ((Control) this.utcRecommendations).Controls.Add((Control) this.Label53);
    ((Control) this.utcRecommendations).Controls.Add((Control) this.Label52);
    ((Control) this.utcRecommendations).Controls.Add((Control) this.Label51);
    ((Control) this.utcRecommendations).Controls.Add((Control) this.Label50);
    ((Control) this.utcRecommendations).Controls.Add((Control) this.cboRecStatus);
    ((Control) this.utcRecommendations).Controls.Add((Control) this.Label49);
    ((Control) this.utcRecommendations).Controls.Add((Control) this.Label48);
    ((Control) this.utcRecommendations).Controls.Add((Control) this.Label47);
    ((Control) this.utcRecommendations).Controls.Add((Control) this.txtNonCriticalWaived);
    ((Control) this.utcRecommendations).Controls.Add((Control) this.txtNonCriticalComplete);
    ((Control) this.utcRecommendations).Controls.Add((Control) this.txtNonCriticalTotal);
    ((Control) this.utcRecommendations).Controls.Add((Control) this.txtNonCriticalOutstanding);
    ((Control) this.utcRecommendations).Controls.Add((Control) this.Label46);
    ((Control) this.utcRecommendations).Controls.Add((Control) this.Label45);
    ((Control) this.utcRecommendations).Controls.Add((Control) this.Label44);
    ((Control) this.utcRecommendations).Controls.Add((Control) this.Label43);
    ((Control) this.utcRecommendations).Controls.Add((Control) this.Label42);
    ((Control) this.utcRecommendations).Controls.Add((Control) this.Label41);
    ((Control) this.utcRecommendations).Controls.Add((Control) this.txtCriticalWaived);
    ((Control) this.utcRecommendations).Controls.Add((Control) this.txtCriticalComplete);
    ((Control) this.utcRecommendations).Controls.Add((Control) this.txtCriticalTotal);
    ((Control) this.utcRecommendations).Controls.Add((Control) this.txtCriticalOutstanding);
    ((Control) this.utcRecommendations).Location = new Point(-10000, -10000);
    ((Control) this.utcRecommendations).Name = "utcRecommendations";
    ((Control) this.utcRecommendations).Size = new Size(891, 388);
    appearance34.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.dtLastAssessmentDate.Appearance = (AppearanceBase) appearance34;
    appearance35.AlphaLevel = (short) 14;
    appearance35.BackColor = Color.FromArgb(0, 0, 246, 253);
    appearance35.BackColor2 = Color.FromArgb(133, 162, 221);
    appearance35.BackColorAlpha = (Alpha) 2;
    appearance35.BackGradientAlignment = (GradientAlignment) 4;
    appearance35.BackGradientStyle = (GradientStyle) 5;
    appearance35.BorderAlpha = (Alpha) 1;
    appearance35.BorderColor = Color.FromArgb(78, 122, 171);
    appearance35.ForeColor = Color.FromArgb(49, 85, 153);
    appearance35.ForegroundAlpha = (Alpha) 2;
    this.dtLastAssessmentDate.ButtonAppearance = (AppearanceBase) appearance35;
    this.dtLastAssessmentDate.DateTime = new DateTime(1753, 1, 1, 0, 0, 0, 0);
    ((Control) this.dtLastAssessmentDate).Location = new Point(406, 100);
    this.dtLastAssessmentDate.MGAStyle = MGAStyles.Blue;
    ((Control) this.dtLastAssessmentDate).Name = "dtLastAssessmentDate";
    ((Control) this.dtLastAssessmentDate).Size = new Size(124, 19);
    ((Control) this.dtLastAssessmentDate).TabIndex = 25;
    ((UltraControlBase) this.dtLastAssessmentDate).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dtLastAssessmentDate).UseOsThemes = (DefaultableBoolean) 2;
    this.dtLastAssessmentDate.Value = (object) null;
    this.Label77.AutoSize = true;
    this.Label77.BackColor = Color.Transparent;
    this.Label77.Font = new Font("Microsoft Sans Serif", 10f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label77.ForeColor = Color.Red;
    this.Label77.Location = new Point(536, 103);
    this.Label77.Name = "Label77";
    this.Label77.Size = new Size(14, 17);
    this.Label77.TabIndex = 31 /*0x1F*/;
    this.Label77.Text = "*";
    this.Label78.AutoSize = true;
    this.Label78.BackColor = Color.Transparent;
    this.Label78.Location = new Point((int) byte.MaxValue, 103);
    this.Label78.Name = "Label78";
    this.Label78.Size = new Size(115, 13);
    this.Label78.TabIndex = 13;
    this.Label78.Text = "Last Assessment Date:";
    this.Label76.AutoSize = true;
    this.Label76.BackColor = Color.Transparent;
    this.Label76.Font = new Font("Microsoft Sans Serif", 10f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label76.ForeColor = Color.Red;
    this.Label76.Location = new Point(201, 220);
    this.Label76.Name = "Label76";
    this.Label76.Size = new Size(14, 17);
    this.Label76.TabIndex = 17;
    this.Label76.Text = "*";
    this.Label75.AutoSize = true;
    this.Label75.BackColor = Color.Transparent;
    this.Label75.Font = new Font("Microsoft Sans Serif", 10f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label75.ForeColor = Color.Red;
    this.Label75.Location = new Point(201, 250);
    this.Label75.Name = "Label75";
    this.Label75.Size = new Size(14, 17);
    this.Label75.TabIndex = 18;
    this.Label75.Text = "*";
    this.Label74.AutoSize = true;
    this.Label74.BackColor = Color.Transparent;
    this.Label74.Font = new Font("Microsoft Sans Serif", 10f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label74.ForeColor = Color.Red;
    this.Label74.Location = new Point(201, 280);
    this.Label74.Name = "Label74";
    this.Label74.Size = new Size(14, 17);
    this.Label74.TabIndex = 19;
    this.Label74.Text = "*";
    this.Label73.AutoSize = true;
    this.Label73.BackColor = Color.Transparent;
    this.Label73.Font = new Font("Microsoft Sans Serif", 10f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label73.ForeColor = Color.Red;
    this.Label73.Location = new Point(201, 309);
    this.Label73.Name = "Label73";
    this.Label73.Size = new Size(14, 17);
    this.Label73.TabIndex = 124;
    this.Label73.Text = "*";
    this.Label72.AutoSize = true;
    this.Label72.BackColor = Color.Transparent;
    this.Label72.Font = new Font("Microsoft Sans Serif", 10f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label72.ForeColor = Color.Red;
    this.Label72.Location = new Point(201, 340);
    this.Label72.Name = "Label72";
    this.Label72.Size = new Size(14, 17);
    this.Label72.TabIndex = 20;
    this.Label72.Text = "*";
    this.Label71.AutoSize = true;
    this.Label71.BackColor = Color.Transparent;
    this.Label71.Font = new Font("Microsoft Sans Serif", 10f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label71.ForeColor = Color.Red;
    this.Label71.Location = new Point(386, 163);
    this.Label71.Name = "Label71";
    this.Label71.Size = new Size(14, 17);
    this.Label71.TabIndex = 27;
    this.Label71.Text = "*";
    appearance36.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance36.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkCriticalAccount).Appearance = (AppearanceBase) appearance36;
    ((UltraToggleEditorBase) this.chkCriticalAccount).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkCriticalAccount).BackColorInternal = Color.Transparent;
    ((UltraToggleEditorBase) this.chkCriticalAccount).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkCriticalAccount).Location = new Point(258, 160 /*0xA0*/);
    this.chkCriticalAccount.MGAStyle = MGAStyles.Blue;
    ((Control) this.chkCriticalAccount).Name = "chkCriticalAccount";
    ((Control) this.chkCriticalAccount).Size = new Size(115, 20);
    ((Control) this.chkCriticalAccount).TabIndex = 22;
    ((UltraToggleEditorBase) this.chkCriticalAccount).Text = "Critical Account";
    ((UltraControlBase) this.chkCriticalAccount).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkCriticalAccount).UseOsThemes = (DefaultableBoolean) 2;
    this.Label70.AutoSize = true;
    this.Label70.BackColor = Color.Transparent;
    this.Label70.Font = new Font("Microsoft Sans Serif", 10f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label70.ForeColor = Color.Red;
    this.Label70.Location = new Point(386, 133);
    this.Label70.Name = "Label70";
    this.Label70.Size = new Size(14, 17);
    this.Label70.TabIndex = 26;
    this.Label70.Text = "*";
    appearance37.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance37.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkFocusAccount).Appearance = (AppearanceBase) appearance37;
    ((UltraToggleEditorBase) this.chkFocusAccount).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkFocusAccount).BackColorInternal = Color.Transparent;
    ((UltraToggleEditorBase) this.chkFocusAccount).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkFocusAccount).Location = new Point(258, 130);
    this.chkFocusAccount.MGAStyle = MGAStyles.Blue;
    ((Control) this.chkFocusAccount).Name = "chkFocusAccount";
    ((Control) this.chkFocusAccount).Size = new Size(111, 20);
    ((Control) this.chkFocusAccount).TabIndex = 21;
    ((UltraToggleEditorBase) this.chkFocusAccount).Text = "Focus Account";
    ((UltraControlBase) this.chkFocusAccount).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkFocusAccount).UseOsThemes = (DefaultableBoolean) 2;
    appearance38.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.dtpMap.Appearance = (AppearanceBase) appearance38;
    appearance39.AlphaLevel = (short) 14;
    appearance39.BackColor = Color.FromArgb(0, 0, 246, 253);
    appearance39.BackColor2 = Color.FromArgb(133, 162, 221);
    appearance39.BackColorAlpha = (Alpha) 2;
    appearance39.BackGradientAlignment = (GradientAlignment) 4;
    appearance39.BackGradientStyle = (GradientStyle) 5;
    appearance39.BorderAlpha = (Alpha) 1;
    appearance39.BorderColor = Color.FromArgb(78, 122, 171);
    appearance39.ForeColor = Color.FromArgb(49, 85, 153);
    appearance39.ForegroundAlpha = (Alpha) 2;
    this.dtpMap.ButtonAppearance = (AppearanceBase) appearance39;
    this.dtpMap.DateTime = new DateTime(1753, 1, 1, 0, 0, 0, 0);
    ((Control) this.dtpMap).Location = new Point(100, 247);
    this.dtpMap.MGAStyle = MGAStyles.Blue;
    ((Control) this.dtpMap).Name = "dtpMap";
    ((Control) this.dtpMap).Size = new Size(84, 19);
    ((Control) this.dtpMap).TabIndex = 7;
    ((UltraControlBase) this.dtpMap).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dtpMap).UseOsThemes = (DefaultableBoolean) 2;
    this.dtpMap.Value = (object) null;
    this.Label69.AutoSize = true;
    this.Label69.BackColor = Color.Transparent;
    this.Label69.Location = new Point(4, 250);
    this.Label69.Name = "Label69";
    this.Label69.Size = new Size(31 /*0x1F*/, 13);
    this.Label69.TabIndex = 117;
    this.Label69.Text = "Map:";
    appearance40.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.dtpSprinklerTest.Appearance = (AppearanceBase) appearance40;
    appearance41.AlphaLevel = (short) 14;
    appearance41.BackColor = Color.FromArgb(0, 0, 246, 253);
    appearance41.BackColor2 = Color.FromArgb(133, 162, 221);
    appearance41.BackColorAlpha = (Alpha) 2;
    appearance41.BackGradientAlignment = (GradientAlignment) 4;
    appearance41.BackGradientStyle = (GradientStyle) 5;
    appearance41.BorderAlpha = (Alpha) 1;
    appearance41.BorderColor = Color.FromArgb(78, 122, 171);
    appearance41.ForeColor = Color.FromArgb(49, 85, 153);
    appearance41.ForegroundAlpha = (Alpha) 2;
    this.dtpSprinklerTest.ButtonAppearance = (AppearanceBase) appearance41;
    this.dtpSprinklerTest.DateTime = new DateTime(1753, 1, 1, 0, 0, 0, 0);
    ((Control) this.dtpSprinklerTest).Location = new Point(100, 277);
    this.dtpSprinklerTest.MGAStyle = MGAStyles.Blue;
    ((Control) this.dtpSprinklerTest).Name = "dtpSprinklerTest";
    ((Control) this.dtpSprinklerTest).Size = new Size(84, 19);
    ((Control) this.dtpSprinklerTest).TabIndex = 8;
    ((UltraControlBase) this.dtpSprinklerTest).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dtpSprinklerTest).UseOsThemes = (DefaultableBoolean) 2;
    this.dtpSprinklerTest.Value = (object) null;
    this.Label68.AutoSize = true;
    this.Label68.BackColor = Color.Transparent;
    this.Label68.Location = new Point(4, 280);
    this.Label68.Name = "Label68";
    this.Label68.Size = new Size(75, 13);
    this.Label68.TabIndex = 115;
    this.Label68.Text = "Sprinkler Test:";
    appearance42.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.dtpThermo.Appearance = (AppearanceBase) appearance42;
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
    this.dtpThermo.ButtonAppearance = (AppearanceBase) appearance43;
    this.dtpThermo.DateTime = new DateTime(1753, 1, 1, 0, 0, 0, 0);
    ((Control) this.dtpThermo).Location = new Point(100, 307);
    this.dtpThermo.MGAStyle = MGAStyles.Blue;
    ((Control) this.dtpThermo).Name = "dtpThermo";
    ((Control) this.dtpThermo).Size = new Size(84, 19);
    ((Control) this.dtpThermo).TabIndex = 9;
    ((UltraControlBase) this.dtpThermo).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dtpThermo).UseOsThemes = (DefaultableBoolean) 2;
    this.dtpThermo.Value = (object) null;
    this.Label67.AutoSize = true;
    this.Label67.BackColor = Color.Transparent;
    this.Label67.Location = new Point(4, 310);
    this.Label67.Name = "Label67";
    this.Label67.Size = new Size(46, 13);
    this.Label67.TabIndex = 113;
    this.Label67.Text = "Thermo:";
    appearance44.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.dtpFirePump.Appearance = (AppearanceBase) appearance44;
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
    this.dtpFirePump.ButtonAppearance = (AppearanceBase) appearance45;
    this.dtpFirePump.DateTime = new DateTime(1753, 1, 1, 0, 0, 0, 0);
    ((Control) this.dtpFirePump).Location = new Point(100, 337);
    this.dtpFirePump.MGAStyle = MGAStyles.Blue;
    ((Control) this.dtpFirePump).Name = "dtpFirePump";
    ((Control) this.dtpFirePump).Size = new Size(84, 19);
    ((Control) this.dtpFirePump).TabIndex = 10;
    ((UltraControlBase) this.dtpFirePump).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dtpFirePump).UseOsThemes = (DefaultableBoolean) 2;
    this.dtpFirePump.Value = (object) null;
    this.Label66.AutoSize = true;
    this.Label66.BackColor = Color.Transparent;
    this.Label66.Location = new Point(4, 340);
    this.Label66.Name = "Label66";
    this.Label66.Size = new Size(57, 13);
    this.Label66.TabIndex = 111;
    this.Label66.Text = "Fire Pump:";
    appearance46.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.dtpCPR.Appearance = (AppearanceBase) appearance46;
    appearance47.AlphaLevel = (short) 14;
    appearance47.BackColor = Color.FromArgb(0, 0, 246, 253);
    appearance47.BackColor2 = Color.FromArgb(133, 162, 221);
    appearance47.BackColorAlpha = (Alpha) 2;
    appearance47.BackGradientAlignment = (GradientAlignment) 4;
    appearance47.BackGradientStyle = (GradientStyle) 5;
    appearance47.BorderAlpha = (Alpha) 1;
    appearance47.BorderColor = Color.FromArgb(78, 122, 171);
    appearance47.ForeColor = Color.FromArgb(49, 85, 153);
    appearance47.ForegroundAlpha = (Alpha) 2;
    this.dtpCPR.ButtonAppearance = (AppearanceBase) appearance47;
    this.dtpCPR.DateTime = new DateTime(1753, 1, 1, 0, 0, 0, 0);
    ((Control) this.dtpCPR).Location = new Point(100, 217);
    this.dtpCPR.MGAStyle = MGAStyles.Blue;
    ((Control) this.dtpCPR).Name = "dtpCPR";
    ((Control) this.dtpCPR).Size = new Size(84, 19);
    ((Control) this.dtpCPR).TabIndex = 6;
    ((UltraControlBase) this.dtpCPR).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dtpCPR).UseOsThemes = (DefaultableBoolean) 2;
    this.dtpCPR.Value = (object) null;
    this.Label65.AutoSize = true;
    this.Label65.BackColor = Color.Transparent;
    this.Label65.Location = new Point(4, 220);
    this.Label65.Name = "Label65";
    this.Label65.Size = new Size(32 /*0x20*/, 13);
    this.Label65.TabIndex = 109;
    this.Label65.Text = "CPR:";
    appearance48.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.dtpRecsSent.Appearance = (AppearanceBase) appearance48;
    appearance49.AlphaLevel = (short) 14;
    appearance49.BackColor = Color.FromArgb(0, 0, 246, 253);
    appearance49.BackColor2 = Color.FromArgb(133, 162, 221);
    appearance49.BackColorAlpha = (Alpha) 2;
    appearance49.BackGradientAlignment = (GradientAlignment) 4;
    appearance49.BackGradientStyle = (GradientStyle) 5;
    appearance49.BorderAlpha = (Alpha) 1;
    appearance49.BorderColor = Color.FromArgb(78, 122, 171);
    appearance49.ForeColor = Color.FromArgb(49, 85, 153);
    appearance49.ForegroundAlpha = (Alpha) 2;
    this.dtpRecsSent.ButtonAppearance = (AppearanceBase) appearance49;
    this.dtpRecsSent.DateTime = new DateTime(1753, 1, 1, 0, 0, 0, 0);
    ((Control) this.dtpRecsSent).Location = new Point(100, (int) sbyte.MaxValue);
    this.dtpRecsSent.MGAStyle = MGAStyles.Blue;
    ((Control) this.dtpRecsSent).Name = "dtpRecsSent";
    ((Control) this.dtpRecsSent).Size = new Size(84, 19);
    ((Control) this.dtpRecsSent).TabIndex = 3;
    ((UltraControlBase) this.dtpRecsSent).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dtpRecsSent).UseOsThemes = (DefaultableBoolean) 2;
    this.dtpRecsSent.Value = (object) null;
    appearance50.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.dtpRecsFollowUp.Appearance = (AppearanceBase) appearance50;
    appearance51.AlphaLevel = (short) 14;
    appearance51.BackColor = Color.FromArgb(0, 0, 246, 253);
    appearance51.BackColor2 = Color.FromArgb(133, 162, 221);
    appearance51.BackColorAlpha = (Alpha) 2;
    appearance51.BackGradientAlignment = (GradientAlignment) 4;
    appearance51.BackGradientStyle = (GradientStyle) 5;
    appearance51.BorderAlpha = (Alpha) 1;
    appearance51.BorderColor = Color.FromArgb(78, 122, 171);
    appearance51.ForeColor = Color.FromArgb(49, 85, 153);
    appearance51.ForegroundAlpha = (Alpha) 2;
    this.dtpRecsFollowUp.ButtonAppearance = (AppearanceBase) appearance51;
    this.dtpRecsFollowUp.DateTime = new DateTime(1753, 1, 1, 0, 0, 0, 0);
    ((Control) this.dtpRecsFollowUp).Location = new Point(100, 157);
    this.dtpRecsFollowUp.MGAStyle = MGAStyles.Blue;
    ((Control) this.dtpRecsFollowUp).Name = "dtpRecsFollowUp";
    ((Control) this.dtpRecsFollowUp).Size = new Size(84, 19);
    ((Control) this.dtpRecsFollowUp).TabIndex = 4;
    ((UltraControlBase) this.dtpRecsFollowUp).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dtpRecsFollowUp).UseOsThemes = (DefaultableBoolean) 2;
    this.dtpRecsFollowUp.Value = (object) null;
    appearance52.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.dtpRecsCompleted.Appearance = (AppearanceBase) appearance52;
    appearance53.AlphaLevel = (short) 14;
    appearance53.BackColor = Color.FromArgb(0, 0, 246, 253);
    appearance53.BackColor2 = Color.FromArgb(133, 162, 221);
    appearance53.BackColorAlpha = (Alpha) 2;
    appearance53.BackGradientAlignment = (GradientAlignment) 4;
    appearance53.BackGradientStyle = (GradientStyle) 5;
    appearance53.BorderAlpha = (Alpha) 1;
    appearance53.BorderColor = Color.FromArgb(78, 122, 171);
    appearance53.ForeColor = Color.FromArgb(49, 85, 153);
    appearance53.ForegroundAlpha = (Alpha) 2;
    this.dtpRecsCompleted.ButtonAppearance = (AppearanceBase) appearance53;
    this.dtpRecsCompleted.DateTime = new DateTime(1753, 1, 1, 0, 0, 0, 0);
    ((Control) this.dtpRecsCompleted).Location = new Point(100, 187);
    this.dtpRecsCompleted.MGAStyle = MGAStyles.Blue;
    ((Control) this.dtpRecsCompleted).Name = "dtpRecsCompleted";
    ((Control) this.dtpRecsCompleted).Size = new Size(84, 19);
    ((Control) this.dtpRecsCompleted).TabIndex = 5;
    ((UltraControlBase) this.dtpRecsCompleted).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dtpRecsCompleted).UseOsThemes = (DefaultableBoolean) 2;
    this.dtpRecsCompleted.Value = (object) null;
    this.Label62.AutoSize = true;
    this.Label62.BackColor = Color.Transparent;
    this.Label62.Font = new Font("Microsoft Sans Serif", 10f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label62.ForeColor = Color.Red;
    this.Label62.Location = new Point(694, 64 /*0x40*/);
    this.Label62.Name = "Label62";
    this.Label62.Size = new Size(14, 17);
    this.Label62.TabIndex = 105;
    this.Label62.Text = "*";
    this.Label61.AutoSize = true;
    this.Label61.BackColor = Color.Transparent;
    this.Label61.Font = new Font("Microsoft Sans Serif", 10f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label61.ForeColor = Color.Red;
    this.Label61.Location = new Point(232, 98);
    this.Label61.Name = "Label61";
    this.Label61.Size = new Size(14, 17);
    this.Label61.TabIndex = 104;
    this.Label61.Text = "*";
    this.Label60.AutoSize = true;
    this.Label60.BackColor = Color.Transparent;
    this.Label60.Font = new Font("Microsoft Sans Serif", 10f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label60.ForeColor = Color.Red;
    this.Label60.Location = new Point(201, 128 /*0x80*/);
    this.Label60.Name = "Label60";
    this.Label60.Size = new Size(14, 17);
    this.Label60.TabIndex = 14;
    this.Label60.Text = "*";
    this.Label59.AutoSize = true;
    this.Label59.BackColor = Color.Transparent;
    this.Label59.Font = new Font("Microsoft Sans Serif", 10f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label59.ForeColor = Color.Red;
    this.Label59.Location = new Point(201, 158);
    this.Label59.Name = "Label59";
    this.Label59.Size = new Size(14, 17);
    this.Label59.TabIndex = 15;
    this.Label59.Text = "*";
    this.Label58.AutoSize = true;
    this.Label58.BackColor = Color.Transparent;
    this.Label58.Font = new Font("Microsoft Sans Serif", 10f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label58.ForeColor = Color.Red;
    this.Label58.Location = new Point(201, 188);
    this.Label58.Name = "Label58";
    this.Label58.Size = new Size(14, 17);
    this.Label58.TabIndex = 16 /*0x10*/;
    this.Label58.Text = "*";
    this.Label57.AutoSize = true;
    this.Label57.BackColor = Color.Transparent;
    this.Label57.Font = new Font("Microsoft Sans Serif", 10f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label57.ForeColor = Color.Red;
    this.Label57.Location = new Point(232, 36);
    this.Label57.Name = "Label57";
    this.Label57.Size = new Size(14, 17);
    this.Label57.TabIndex = 11;
    this.Label57.Text = "*";
    this.Label56.AutoSize = true;
    this.Label56.BackColor = Color.Transparent;
    this.Label56.Font = new Font("Microsoft Sans Serif", 10f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label56.ForeColor = Color.Red;
    this.Label56.Location = new Point(694, 34);
    this.Label56.Name = "Label56";
    this.Label56.Size = new Size(14, 17);
    this.Label56.TabIndex = 99;
    this.Label56.Text = "*";
    this.Label55.AutoSize = true;
    this.Label55.BackColor = Color.Transparent;
    this.Label55.Font = new Font("Microsoft Sans Serif", 10f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label55.ForeColor = Color.Red;
    this.Label55.Location = new Point(536, 66);
    this.Label55.Name = "Label55";
    this.Label55.Size = new Size(14, 17);
    this.Label55.TabIndex = 98;
    this.Label55.Text = "*";
    this.Label54.AutoSize = true;
    this.Label54.BackColor = Color.Transparent;
    this.Label54.Font = new Font("Microsoft Sans Serif", 10f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label54.ForeColor = Color.Red;
    this.Label54.Location = new Point(536, 36);
    this.Label54.Name = "Label54";
    this.Label54.Size = new Size(14, 17);
    this.Label54.TabIndex = 3;
    this.Label54.Text = "*";
    this.Label53.AutoSize = true;
    this.Label53.BackColor = Color.Transparent;
    this.Label53.Font = new Font("Microsoft Sans Serif", 10f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label53.ForeColor = Color.Red;
    this.Label53.Location = new Point(386, 36);
    this.Label53.Name = "Label53";
    this.Label53.Size = new Size(14, 17);
    this.Label53.TabIndex = 2;
    this.Label53.Text = "*";
    this.Label52.AutoSize = true;
    this.Label52.BackColor = Color.Transparent;
    this.Label52.Font = new Font("Microsoft Sans Serif", 10f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label52.ForeColor = Color.Red;
    this.Label52.Location = new Point(386, 66);
    this.Label52.Name = "Label52";
    this.Label52.Size = new Size(14, 17);
    this.Label52.TabIndex = 95;
    this.Label52.Text = "*";
    this.Label51.AutoSize = true;
    this.Label51.BackColor = Color.Transparent;
    this.Label51.Font = new Font("Microsoft Sans Serif", 10f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label51.ForeColor = Color.Red;
    this.Label51.Location = new Point(232, 66);
    this.Label51.Name = "Label51";
    this.Label51.Size = new Size(14, 17);
    this.Label51.TabIndex = 12;
    this.Label51.Text = "*";
    this.Label50.AutoSize = true;
    this.Label50.BackColor = Color.Transparent;
    this.Label50.Location = new Point(3, 94);
    this.Label50.Name = "Label50";
    this.Label50.Size = new Size(68, 13);
    this.Label50.TabIndex = 46;
    this.Label50.Text = "Recs Status:";
    this.cboRecStatus.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.cboRecStatus).DataMember = "lstInspectionsAdminRecStatus";
    ((UltraGridBase) this.cboRecStatus).DataSource = (object) this.ds;
    appearance54.BackColor = Color.White;
    appearance54.BorderColor = Color.FromArgb(78, 122, 171);
    this.cboRecStatus.DisplayLayout.Appearance = (AppearanceBase) appearance54;
    this.cboRecStatus.DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridBand4.ColHeadersVisible = false;
    ((HeaderBase) ultraGridColumn7.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn7.Header.VisiblePosition = 0;
    ultraGridColumn7.Hidden = true;
    ultraGridColumn7.Width = 38;
    ((HeaderBase) ultraGridColumn8.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn8.Header.VisiblePosition = 1;
    ultraGridColumn8.Width = 281;
    ultraGridBand4.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn7,
      (object) ultraGridColumn8
    });
    this.cboRecStatus.DisplayLayout.BandsSerializer.Add((object) ultraGridBand4);
    this.cboRecStatus.DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    this.cboRecStatus.DisplayLayout.BorderStyleCaption = (UIElementBorderStyle) 1;
    this.cboRecStatus.DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 1;
    this.cboRecStatus.DisplayLayout.Override.BorderStyleHeader = (UIElementBorderStyle) 1;
    this.cboRecStatus.DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 1;
    this.cboRecStatus.DisplayLayout.Override.BorderStyleRowSelector = (UIElementBorderStyle) 1;
    this.cboRecStatus.DisplayLayout.Override.BorderStyleSummaryFooter = (UIElementBorderStyle) 1;
    this.cboRecStatus.DisplayLayout.Override.BorderStyleSummaryFooterCaption = (UIElementBorderStyle) 1;
    this.cboRecStatus.DisplayLayout.Override.BorderStyleSummaryValue = (UIElementBorderStyle) 1;
    this.cboRecStatus.DisplayLayout.Override.BorderStyleTemplateAddRow = (UIElementBorderStyle) 1;
    appearance55.BackColor = Color.FromArgb(240 /*0xF0*/, 246, 254);
    appearance55.BorderColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this.cboRecStatus.DisplayLayout.Override.HotTrackRowAppearance = (AppearanceBase) appearance55;
    appearance56.BorderColor = Color.White;
    this.cboRecStatus.DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance56;
    this.cboRecStatus.DisplayLayout.Override.RowSpacingAfter = 1;
    appearance57.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance57.BorderColor = Color.FromArgb((int) byte.MaxValue, 214, 88);
    appearance57.ForeColor = Color.Black;
    this.cboRecStatus.DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance57;
    scrollBarLook4.ViewStyle = (ScrollBarViewStyle) 3;
    this.cboRecStatus.DisplayLayout.ScrollBarLook = scrollBarLook4;
    ((UltraDropDownBase) this.cboRecStatus).DisplayMember = "RecStatus";
    this.cboRecStatus.DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboRecStatus).DropDownWidth = 300;
    ((Control) this.cboRecStatus).Location = new Point(100, 96 /*0x60*/);
    this.cboRecStatus.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboRecStatus).Name = "cboRecStatus";
    ((Control) this.cboRecStatus).Size = new Size(124, 20);
    ((Control) this.cboRecStatus).TabIndex = 2;
    ((UltraControlBase) this.cboRecStatus).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboRecStatus).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboRecStatus).ValueMember = "ID";
    this.Label49.AutoSize = true;
    this.Label49.BackColor = Color.Transparent;
    this.Label49.Location = new Point(4, 190);
    this.Label49.Name = "Label49";
    this.Label49.Size = new Size(88, 13);
    this.Label49.TabIndex = 43;
    this.Label49.Text = "Recs Completed:";
    this.Label48.AutoSize = true;
    this.Label48.BackColor = Color.Transparent;
    this.Label48.Location = new Point(4, 160 /*0xA0*/);
    this.Label48.Name = "Label48";
    this.Label48.Size = new Size(83, 13);
    this.Label48.TabIndex = 41;
    this.Label48.Text = "Recs Follow-up:";
    this.Label47.AutoSize = true;
    this.Label47.BackColor = Color.Transparent;
    this.Label47.Location = new Point(4, 130);
    this.Label47.Name = "Label47";
    this.Label47.Size = new Size(60, 13);
    this.Label47.TabIndex = 39;
    this.Label47.Text = "Recs Sent:";
    this.txtNonCriticalWaived.Location = new Point(258, 64 /*0x40*/);
    this.txtNonCriticalWaived.MaxLength = 150;
    this.txtNonCriticalWaived.Name = "txtNonCriticalWaived";
    this.txtNonCriticalWaived.Size = new Size(124, 20);
    this.txtNonCriticalWaived.TabIndex = 5;
    this.txtNonCriticalComplete.Location = new Point(406, 64 /*0x40*/);
    this.txtNonCriticalComplete.MaxLength = 150;
    this.txtNonCriticalComplete.Name = "txtNonCriticalComplete";
    this.txtNonCriticalComplete.Size = new Size(124, 20);
    this.txtNonCriticalComplete.TabIndex = 24;
    this.txtNonCriticalTotal.Location = new Point(557, 64 /*0x40*/);
    this.txtNonCriticalTotal.MaxLength = 150;
    this.txtNonCriticalTotal.Name = "txtNonCriticalTotal";
    this.txtNonCriticalTotal.Size = new Size(124, 20);
    this.txtNonCriticalTotal.TabIndex = 30;
    this.txtNonCriticalOutstanding.Location = new Point(100, 65);
    this.txtNonCriticalOutstanding.MaxLength = 150;
    this.txtNonCriticalOutstanding.Name = "txtNonCriticalOutstanding";
    this.txtNonCriticalOutstanding.Size = new Size(124, 20);
    this.txtNonCriticalOutstanding.TabIndex = 1;
    this.Label46.AutoSize = true;
    this.Label46.BackColor = Color.Transparent;
    this.Label46.Location = new Point(444, 10);
    this.Label46.Name = "Label46";
    this.Label46.Size = new Size(51, 13);
    this.Label46.TabIndex = 34;
    this.Label46.Text = "Complete";
    this.Label45.AutoSize = true;
    this.Label45.BackColor = Color.Transparent;
    this.Label45.Location = new Point(4, 36);
    this.Label45.Name = "Label45";
    this.Label45.Size = new Size(41, 13);
    this.Label45.TabIndex = 33;
    this.Label45.Text = "Critical:";
    this.Label44.AutoSize = true;
    this.Label44.BackColor = Color.Transparent;
    this.Label44.Location = new Point(3, 68);
    this.Label44.Name = "Label44";
    this.Label44.Size = new Size(64 /*0x40*/, 13);
    this.Label44.TabIndex = 32 /*0x20*/;
    this.Label44.Text = "Non-Critical:";
    this.Label43.AutoSize = true;
    this.Label43.BackColor = Color.Transparent;
    this.Label43.Location = new Point(137, 10);
    this.Label43.Name = "Label43";
    this.Label43.Size = new Size(61, 13);
    this.Label43.TabIndex = 31 /*0x1F*/;
    this.Label43.Text = "Oustanding";
    this.Label42.AutoSize = true;
    this.Label42.BackColor = Color.Transparent;
    this.Label42.Location = new Point(298, 10);
    this.Label42.Name = "Label42";
    this.Label42.Size = new Size(44, 13);
    this.Label42.TabIndex = 30;
    this.Label42.Text = "Waived";
    this.Label41.AutoSize = true;
    this.Label41.BackColor = Color.Transparent;
    this.Label41.Location = new Point(593, 10);
    this.Label41.Name = "Label41";
    this.Label41.Size = new Size(31 /*0x1F*/, 13);
    this.Label41.TabIndex = 29;
    this.Label41.Text = "Total";
    this.txtCriticalWaived.Location = new Point(258, 34);
    this.txtCriticalWaived.MaxLength = 150;
    this.txtCriticalWaived.Name = "txtCriticalWaived";
    this.txtCriticalWaived.Size = new Size(124, 20);
    this.txtCriticalWaived.TabIndex = 1;
    this.txtCriticalComplete.Location = new Point(406, 34);
    this.txtCriticalComplete.MaxLength = 150;
    this.txtCriticalComplete.Name = "txtCriticalComplete";
    this.txtCriticalComplete.Size = new Size(124, 20);
    this.txtCriticalComplete.TabIndex = 23;
    this.txtCriticalTotal.Location = new Point(557, 34);
    this.txtCriticalTotal.MaxLength = 150;
    this.txtCriticalTotal.Name = "txtCriticalTotal";
    this.txtCriticalTotal.Size = new Size(124, 20);
    this.txtCriticalTotal.TabIndex = 28;
    this.txtCriticalOutstanding.Location = new Point(100, 34);
    this.txtCriticalOutstanding.MaxLength = 150;
    this.txtCriticalOutstanding.Name = "txtCriticalOutstanding";
    this.txtCriticalOutstanding.Size = new Size(124, 20);
    this.txtCriticalOutstanding.TabIndex = 0;
    this.err.ContainerControl = (ContainerControl) this;
    ((Control) this.ugLocations).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraControlBase) this.ugLocations).Cursor = Cursors.Hand;
    ((UltraGridBase) this.ugLocations).DataSource = (object) this.dvSource;
    appearance58.BackColor = Color.White;
    appearance58.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.ugLocations).DisplayLayout.Appearance = (AppearanceBase) appearance58;
    ((UltraGridBase) this.ugLocations).DisplayLayout.AutoFitStyle = (AutoFitStyle) 2;
    ((HeaderBase) ultraGridColumn9.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn9.Header.VisiblePosition = 0;
    ((HeaderBase) ultraGridColumn10.Header).Caption = "Follow Up";
    ((HeaderBase) ultraGridColumn10.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn10.Header.VisiblePosition = 1;
    ((HeaderBase) ultraGridColumn11.Header).Caption = "Control #";
    ((HeaderBase) ultraGridColumn11.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn11.Header.VisiblePosition = 2;
    ((HeaderBase) ultraGridColumn12.Header).Caption = "Policy #";
    ((HeaderBase) ultraGridColumn12.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn12.Header.VisiblePosition = 3;
    ((HeaderBase) ultraGridColumn13.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn13.Header.VisiblePosition = 4;
    ((HeaderBase) ultraGridColumn14.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn14.Header.VisiblePosition = 5;
    ((HeaderBase) ultraGridColumn15.Header).Caption = "Location ID";
    ((HeaderBase) ultraGridColumn15.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn15.Header.VisiblePosition = 6;
    ((HeaderBase) ultraGridColumn16.Header).Caption = "Location #";
    ((HeaderBase) ultraGridColumn16.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn16.Header.VisiblePosition = 7;
    ((HeaderBase) ultraGridColumn17.Header).Caption = "Location Address";
    ((HeaderBase) ultraGridColumn17.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn17.Header.VisiblePosition = 8;
    ((HeaderBase) ultraGridColumn18.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn18.Header.VisiblePosition = 9;
    ((HeaderBase) ultraGridColumn19.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn19.Header.VisiblePosition = 10;
    ((HeaderBase) ultraGridColumn20.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn20.Header.VisiblePosition = 11;
    ((HeaderBase) ultraGridColumn21.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn21.Header.VisiblePosition = 12;
    ((HeaderBase) ultraGridColumn22.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn22.Header.VisiblePosition = 13;
    ((HeaderBase) ultraGridColumn23.Header).Caption = "Inspection Company";
    ((HeaderBase) ultraGridColumn23.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn23.Header.VisiblePosition = 14;
    ultraGridColumn23.Style = (ColumnStyle) 6;
    ((HeaderBase) ultraGridColumn24.Header).Caption = "Insp.. Contact";
    ((HeaderBase) ultraGridColumn24.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn24.Header.VisiblePosition = 15;
    ((HeaderBase) ultraGridColumn25.Header).Caption = "Insp.. Contact Phone";
    ((HeaderBase) ultraGridColumn25.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn25.Header.VisiblePosition = 16 /*0x10*/;
    ((HeaderBase) ultraGridColumn26.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn26.Header.VisiblePosition = 17;
    ((HeaderBase) ultraGridColumn27.Header).Caption = "Effective Date";
    ((HeaderBase) ultraGridColumn27.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn27.Header.VisiblePosition = 18;
    ((HeaderBase) ultraGridColumn28.Header).Caption = "Order Date";
    ((HeaderBase) ultraGridColumn28.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn28.Header.VisiblePosition = 19;
    ((HeaderBase) ultraGridColumn29.Header).Caption = "Drop Dead Date";
    ((HeaderBase) ultraGridColumn29.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn29.Header.VisiblePosition = 20;
    ((HeaderBase) ultraGridColumn30.Header).Caption = "Followup Date";
    ((HeaderBase) ultraGridColumn30.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn30.Header.VisiblePosition = 21;
    ((HeaderBase) ultraGridColumn31.Header).Caption = "Received Date";
    ((HeaderBase) ultraGridColumn31.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn31.Header.VisiblePosition = 22;
    ((HeaderBase) ultraGridColumn32.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn32.Header.VisiblePosition = 23;
    ((HeaderBase) ultraGridColumn33.Header).Caption = "Revised Contact Info";
    ((HeaderBase) ultraGridColumn33.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn33.Header.VisiblePosition = 24;
    ((HeaderBase) ultraGridColumn34.Header).Caption = "Insp.. Status";
    ((HeaderBase) ultraGridColumn34.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn34.Header.VisiblePosition = 25;
    ultraGridColumn34.Style = (ColumnStyle) 6;
    ((HeaderBase) ultraGridColumn35.Header).Caption = "Ordered By";
    ((HeaderBase) ultraGridColumn35.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn35.Header.VisiblePosition = 26;
    ((HeaderBase) ultraGridColumn36.Header).Caption = "Insp.. Type";
    ((HeaderBase) ultraGridColumn36.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn36.Header.VisiblePosition = 27;
    ((HeaderBase) ultraGridColumn37.Header).Caption = "On Endorsement";
    ((HeaderBase) ultraGridColumn37.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn37.Header.VisiblePosition = 28;
    ((HeaderBase) ultraGridColumn38.Header).Caption = "Policy Type";
    ((HeaderBase) ultraGridColumn38.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn38.Header.VisiblePosition = 29;
    ((HeaderBase) ultraGridColumn39.Header).Caption = "Insured ID";
    ((HeaderBase) ultraGridColumn39.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn39.Header.VisiblePosition = 30;
    ((HeaderBase) ultraGridColumn40.Header).Caption = "Policy Status";
    ((HeaderBase) ultraGridColumn40.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn40.Header.VisiblePosition = 31 /*0x1F*/;
    ((HeaderBase) ultraGridColumn41.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn41.Header.VisiblePosition = 32 /*0x20*/;
    ((HeaderBase) ultraGridColumn42.Header).Caption = "Closed Date";
    ((HeaderBase) ultraGridColumn42.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn42.Header.VisiblePosition = 33;
    ((HeaderBase) ultraGridColumn43.Header).Caption = "Critical Outstanding";
    ((HeaderBase) ultraGridColumn43.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn43.Header.VisiblePosition = 34;
    ((HeaderBase) ultraGridColumn44.Header).Caption = "Critical Waived";
    ((HeaderBase) ultraGridColumn44.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn44.Header.VisiblePosition = 35;
    ((HeaderBase) ultraGridColumn45.Header).Caption = "Critical Complete";
    ((HeaderBase) ultraGridColumn45.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn45.Header.VisiblePosition = 36;
    ((HeaderBase) ultraGridColumn46.Header).Caption = "Critical Total";
    ((HeaderBase) ultraGridColumn46.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn46.Header.VisiblePosition = 37;
    ((HeaderBase) ultraGridColumn47.Header).Caption = "NonCritical Outstanding";
    ((HeaderBase) ultraGridColumn47.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn47.Header.VisiblePosition = 38;
    ((HeaderBase) ultraGridColumn48.Header).Caption = "NonCritical Waived";
    ((HeaderBase) ultraGridColumn48.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn48.Header.VisiblePosition = 39;
    ((HeaderBase) ultraGridColumn49.Header).Caption = "NonCritical Complete";
    ((HeaderBase) ultraGridColumn49.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn49.Header.VisiblePosition = 40;
    ((HeaderBase) ultraGridColumn50.Header).Caption = "NonCritical Total";
    ((HeaderBase) ultraGridColumn50.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn50.Header.VisiblePosition = 41;
    ((HeaderBase) ultraGridColumn51.Header).Caption = "Rec Status";
    ((HeaderBase) ultraGridColumn51.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn51.Header.VisiblePosition = 42;
    ultraGridColumn51.Style = (ColumnStyle) 6;
    ((HeaderBase) ultraGridColumn52.Header).Caption = "Rec Sent";
    ((HeaderBase) ultraGridColumn52.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn52.Header.VisiblePosition = 43;
    ((HeaderBase) ultraGridColumn53.Header).Caption = "Recs FollowUp";
    ((HeaderBase) ultraGridColumn53.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn53.Header.VisiblePosition = 44;
    ((HeaderBase) ultraGridColumn54.Header).Caption = "Recs Completed";
    ((HeaderBase) ultraGridColumn54.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn54.Header.VisiblePosition = 45;
    ((HeaderBase) ultraGridColumn55.Header).Caption = "Roof Inspection";
    ((HeaderBase) ultraGridColumn55.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn55.Header.VisiblePosition = 46;
    ((HeaderBase) ultraGridColumn56.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn56.Header.VisiblePosition = 47;
    ((HeaderBase) ultraGridColumn57.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn57.Header.VisiblePosition = 48 /*0x30*/;
    ((HeaderBase) ultraGridColumn58.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn58.Header.VisiblePosition = 49;
    ((HeaderBase) ultraGridColumn59.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn59.Header.VisiblePosition = 50;
    ((HeaderBase) ultraGridColumn60.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn60.Header.VisiblePosition = 51;
    ((HeaderBase) ultraGridColumn61.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn61.Header.VisiblePosition = 52;
    ((HeaderBase) ultraGridColumn62.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn62.Header.VisiblePosition = 53;
    ((HeaderBase) ultraGridColumn63.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn63.Header.VisiblePosition = 54;
    ((HeaderBase) ultraGridColumn64.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn64.Header.VisiblePosition = 55;
    ((HeaderBase) ultraGridColumn65.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn65.Header.VisiblePosition = 56;
    ((HeaderBase) ultraGridColumn66.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn66.Header.VisiblePosition = 57;
    ultraGridColumn66.Hidden = true;
    ultraGridBand5.Columns.AddRange(new object[58]
    {
      (object) ultraGridColumn9,
      (object) ultraGridColumn10,
      (object) ultraGridColumn11,
      (object) ultraGridColumn12,
      (object) ultraGridColumn13,
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
      (object) ultraGridColumn66
    });
    ((UltraGridBase) this.ugLocations).DisplayLayout.BandsSerializer.Add((object) ultraGridBand5);
    ((UltraGridBase) this.ugLocations).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance59.BackColor = Color.LightSteelBlue;
    appearance59.FontData.SizeInPoints = 10f;
    appearance59.ForeColor = Color.Black;
    ((UltraGridBase) this.ugLocations).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance59;
    ((UltraGridBase) this.ugLocations).DisplayLayout.MaxRowScrollRegions = 40;
    appearance60.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance60.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance60.ForeColor = Color.Black;
    ((UltraGridBase) this.ugLocations).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance60;
    ((UltraGridBase) this.ugLocations).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.ugLocations).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.ugLocations).DisplayLayout.Override.AllowRowFiltering = (DefaultableBoolean) 1;
    appearance61.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugLocations).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance61;
    appearance62.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.ugLocations).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance62;
    ((UltraGridBase) this.ugLocations).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 2;
    ((UltraGridBase) this.ugLocations).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance63.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.ugLocations).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance63;
    appearance64.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugLocations).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance64;
    ((UltraGridBase) this.ugLocations).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance65.BackColor = Color.Transparent;
    appearance65.ForeColor = Color.Black;
    ((UltraGridBase) this.ugLocations).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance65;
    scrollBarLook5.ViewStyle = (ScrollBarViewStyle) 3;
    ((UltraGridBase) this.ugLocations).DisplayLayout.ScrollBarLook = scrollBarLook5;
    ((UltraGridBase) this.ugLocations).DisplayLayout.Scrollbars = (Scrollbars) 3;
    ((UltraGridBase) this.ugLocations).DisplayLayout.ScrollBounds = (ScrollBounds) 0;
    ((Control) this.ugLocations).Font = new Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.ugLocations).Location = new Point(12, 50);
    ((Control) this.ugLocations).Name = "ugLocations";
    ((Control) this.ugLocations).Size = new Size(910, 292);
    ((Control) this.ugLocations).TabIndex = 13;
    ((Control) this.ugLocations).Text = "Inspected Locations";
    ((UltraControlBase) this.ugLocations).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.ugLocations).UseOsThemes = (DefaultableBoolean) 2;
    this.dvSource.Table = (DataTable) this.ds.tblAdminInspectionRequests;
    this.txtFilterControlNo.Location = new Point(96 /*0x60*/, 3);
    this.txtFilterControlNo.MaxLength = 150;
    this.txtFilterControlNo.Name = "txtFilterControlNo";
    this.txtFilterControlNo.Size = new Size(124, 20);
    this.txtFilterControlNo.TabIndex = 108;
    this.Label31.AutoSize = true;
    this.Label31.BackColor = Color.Transparent;
    this.Label31.Location = new Point(19, 7);
    this.Label31.Name = "Label31";
    this.Label31.Size = new Size(53, 13);
    this.Label31.TabIndex = 108;
    this.Label31.Text = "Control #:";
    this.Label32.AutoSize = true;
    this.Label32.BackColor = Color.Transparent;
    this.Label32.Location = new Point(19, 30);
    this.Label32.Name = "Label32";
    this.Label32.Size = new Size(48 /*0x30*/, 13);
    this.Label32.TabIndex = 109;
    this.Label32.Text = "Policy #:";
    this.txtFilterPolicyNumber.Location = new Point(96 /*0x60*/, 26);
    this.txtFilterPolicyNumber.MaxLength = 150;
    this.txtFilterPolicyNumber.Name = "txtFilterPolicyNumber";
    this.txtFilterPolicyNumber.Size = new Size(124, 20);
    this.txtFilterPolicyNumber.TabIndex = 110;
    this.Label35.AutoSize = true;
    this.Label35.BackColor = Color.Transparent;
    this.Label35.Location = new Point(262, 7);
    this.Label35.Name = "Label35";
    this.Label35.Size = new Size(48 /*0x30*/, 13);
    this.Label35.TabIndex = 111;
    this.Label35.Text = "Address:";
    this.txtFilterAddress.Location = new Point(344, 3);
    this.txtFilterAddress.MaxLength = 150;
    this.txtFilterAddress.Name = "txtFilterAddress";
    this.txtFilterAddress.Size = new Size(124, 20);
    this.txtFilterAddress.TabIndex = 112 /*0x70*/;
    this.Label36.AutoSize = true;
    this.Label36.BackColor = Color.Transparent;
    this.Label36.Location = new Point(262, 30);
    this.Label36.Name = "Label36";
    this.Label36.Size = new Size(76, 13);
    this.Label36.TabIndex = 113;
    this.Label36.Text = "Name Insured:";
    this.txtFilterName.Location = new Point(344, 26);
    this.txtFilterName.MaxLength = 150;
    this.txtFilterName.Name = "txtFilterName";
    this.txtFilterName.Size = new Size(124, 20);
    this.txtFilterName.TabIndex = 114;
    this.lnkLogInfo.AutoSize = true;
    this.lnkLogInfo.BackColor = Color.Transparent;
    this.lnkLogInfo.Location = new Point(650, 26);
    this.lnkLogInfo.Name = "lnkLogInfo";
    this.lnkLogInfo.Size = new Size(165, 13);
    this.lnkLogInfo.TabIndex = 113;
    this.lnkLogInfo.TabStop = true;
    this.lnkLogInfo.Text = "Show current record Logging Info";
    this.panelSearch.BackColorInternal = Color.White;
    appearance66.BorderColor = Color.Gray;
    this.panelSearch.ContentAreaAppearance = (AppearanceBase) appearance66;
    ((Control) this.panelSearch).Controls.Add((Control) this.spinner);
    ((Control) this.panelSearch).Controls.Add((Control) this.labelSearchText);
    ((Control) this.panelSearch).Controls.Add((Control) label);
    ((Control) this.panelSearch).ForeColor = Color.Black;
    ((Control) this.panelSearch).Location = new Point(310, 121);
    ((Control) this.panelSearch).Name = "panelSearch";
    ((Control) this.panelSearch).Size = new Size(318, 140);
    ((Control) this.panelSearch).TabIndex = 115;
    ((Control) this.panelSearch).Visible = false;
    this.spinner.Image = (Image) componentResourceManager.GetObject("spinner.Image");
    this.spinner.Location = new Point(128 /*0x80*/, 81);
    this.spinner.Name = "spinner";
    this.spinner.Size = new Size(60, 44);
    this.spinner.SizeMode = PictureBoxSizeMode.Zoom;
    this.spinner.TabIndex = 116;
    this.spinner.TabStop = false;
    this.labelSearchText.Font = new Font("Tahoma", 8f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.labelSearchText.Location = new Point(10, 52);
    this.labelSearchText.Name = "labelSearchText";
    this.labelSearchText.Size = new Size(299, 19);
    this.labelSearchText.TabIndex = 3;
    this.labelSearchText.Text = "Getting Inspection Requests Records ...";
    this.labelSearchText.TextAlign = ContentAlignment.MiddleCenter;
    ((UltraTabControlBase) this.tabInspections).AllowTabMoving = true;
    ((Control) this.tabInspections).Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((Control) this.tabInspections).Controls.Add((Control) this.ultraTabSharedControlsPage1);
    ((Control) this.tabInspections).Controls.Add((Control) this.utpcInspectionInformation);
    ((Control) this.tabInspections).Controls.Add((Control) this.utcRecommendations);
    ((Control) this.tabInspections).Location = new Point(12, 348);
    ((UltraTabControlBase) this.tabInspections).MinTabWidth = 60;
    ((Control) this.tabInspections).Name = "tabInspections";
    ((UltraTabControlBase) this.tabInspections).SharedControlsPage = this.ultraTabSharedControlsPage1;
    ((Control) this.tabInspections).Size = new Size(910, 419);
    ((Control) this.tabInspections).TabIndex = 0;
    ((UltraTabControlBase) this.tabInspections).TabPadding = new Size(1, 5);
    ultraTab1.FixedWidth = 200;
    ultraTab1.TabPage = this.utpcInspectionInformation;
    ultraTab1.Text = "Inspection Information";
    ultraTab2.TabPage = this.utcRecommendations;
    ultraTab2.Text = "Recommendations";
    ((UltraTabControlBase) this.tabInspections).Tabs.AddRange(new UltraTab[2]
    {
      ultraTab1,
      ultraTab2
    });
    ((UltraTabControlBase) this.tabInspections).ViewStyle = (ViewStyle) 4;
    ((Control) this.ultraTabSharedControlsPage1).Location = new Point(-10000, -10000);
    ((Control) this.ultraTabSharedControlsPage1).Name = "ultraTabSharedControlsPage1";
    ((Control) this.ultraTabSharedControlsPage1).Size = new Size(908, 388);
    this.lblShowRecords.AutoSize = true;
    this.lblShowRecords.BackColor = Color.Transparent;
    this.lblShowRecords.Location = new Point(486, 26);
    this.lblShowRecords.Name = "lblShowRecords";
    this.lblShowRecords.Size = new Size(140, 13);
    this.lblShowRecords.TabIndex = 118;
    this.lblShowRecords.TabStop = true;
    this.lblShowRecords.Text = "Show CLOSED records only";
    ((UltraGridBase) this.ddRecStatus).DataMember = "lstInspectionsAdminRecStatus";
    ((UltraGridBase) this.ddRecStatus).DataSource = (object) this.ds;
    ((HeaderBase) ultraGridColumn67.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn67.Header.VisiblePosition = 0;
    ultraGridColumn67.Hidden = true;
    ((HeaderBase) ultraGridColumn68.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn68.Header.VisiblePosition = 1;
    ultraGridColumn68.Width = 207;
    ultraGridBand6.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn67,
      (object) ultraGridColumn68
    });
    ((UltraGridBase) this.ddRecStatus).DisplayLayout.BandsSerializer.Add((object) ultraGridBand6);
    ((UltraDropDownBase) this.ddRecStatus).DisplayMember = "RecStatus";
    ((UltraDropDownBase) this.ddRecStatus).DropDownWidth = 210;
    ((Control) this.ddRecStatus).Location = new Point(634, 193);
    ((Control) this.ddRecStatus).Name = "ddRecStatus";
    ((Control) this.ddRecStatus).Size = new Size(144 /*0x90*/, 78);
    ((Control) this.ddRecStatus).TabIndex = 117;
    ((UltraDropDownBase) this.ddRecStatus).ValueMember = "ID";
    ((Control) this.ddRecStatus).Visible = false;
    ((UltraGridBase) this.ddInspStatus).DataMember = "lstAdminInspectionStatus";
    ((UltraGridBase) this.ddInspStatus).DataSource = (object) this.ds;
    ((HeaderBase) ultraGridColumn69.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn69.Header.VisiblePosition = 0;
    ultraGridColumn69.Hidden = true;
    ((HeaderBase) ultraGridColumn70.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn70.Header.VisiblePosition = 1;
    ultraGridColumn70.Width = 194;
    ultraGridBand7.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn69,
      (object) ultraGridColumn70
    });
    ((UltraGridBase) this.ddInspStatus).DisplayLayout.BandsSerializer.Add((object) ultraGridBand7);
    ((UltraDropDownBase) this.ddInspStatus).DisplayMember = "InspectionStatus";
    ((UltraDropDownBase) this.ddInspStatus).DropDownWidth = 210;
    ((Control) this.ddInspStatus).Location = new Point(106, 147);
    ((Control) this.ddInspStatus).Name = "ddInspStatus";
    ((Control) this.ddInspStatus).Size = new Size(144 /*0x90*/, 74);
    ((Control) this.ddInspStatus).TabIndex = 74;
    ((UltraDropDownBase) this.ddInspStatus).ValueMember = "ID";
    ((Control) this.ddInspStatus).Visible = false;
    ((UltraGridBase) this.ddInspectComp).DataMember = "tblFin_ExpensePayees";
    ((UltraGridBase) this.ddInspectComp).DataSource = (object) this.ds;
    ((HeaderBase) ultraGridColumn71.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn71.Header.VisiblePosition = 0;
    ultraGridColumn71.Hidden = true;
    ((HeaderBase) ultraGridColumn72.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn72.Header.VisiblePosition = 1;
    ultraGridColumn72.Width = 247;
    ultraGridBand8.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn71,
      (object) ultraGridColumn72
    });
    ((UltraGridBase) this.ddInspectComp).DisplayLayout.BandsSerializer.Add((object) ultraGridBand8);
    ((UltraDropDownBase) this.ddInspectComp).DisplayMember = "PayeeName";
    ((UltraDropDownBase) this.ddInspectComp).DropDownWidth = 210;
    ((Control) this.ddInspectComp).Location = new Point(664, 121);
    ((Control) this.ddInspectComp).Name = "ddInspectComp";
    ((Control) this.ddInspectComp).Size = new Size(184, 69);
    ((Control) this.ddInspectComp).TabIndex = 73;
    ((UltraDropDownBase) this.ddInspectComp).ValueMember = "PayeeID";
    ((Control) this.ddInspectComp).Visible = false;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    this.ClientSize = new Size(931, 768 /*0x0300*/);
    this.Controls.Add((Control) this.lblShowRecords);
    this.Controls.Add((Control) this.ddRecStatus);
    this.Controls.Add((Control) this.tabInspections);
    this.Controls.Add((Control) this.panelSearch);
    this.Controls.Add((Control) this.lnkLogInfo);
    this.Controls.Add((Control) this.txtFilterName);
    this.Controls.Add((Control) this.Label36);
    this.Controls.Add((Control) this.txtFilterAddress);
    this.Controls.Add((Control) this.Label35);
    this.Controls.Add((Control) this.txtFilterPolicyNumber);
    this.Controls.Add((Control) this.Label32);
    this.Controls.Add((Control) this.Label31);
    this.Controls.Add((Control) this.txtFilterControlNo);
    this.Controls.Add((Control) this.ddInspStatus);
    this.Controls.Add((Control) this.ddInspectComp);
    this.Controls.Add((Control) this.ugLocations);
    this.Name = nameof (FormAdminInspectionRequests);
    this.Text = "Inspection Requests Administration";
    ((Control) this.utpcInspectionInformation).ResumeLayout(false);
    ((Control) this.utpcInspectionInformation).PerformLayout();
    ((ISupportInitialize) this.cboAdminInspectionTypes).EndInit();
    this.ds.EndInit();
    ((ISupportInitialize) this.btnNew).EndInit();
    ((ISupportInitialize) this.btnUndo).EndInit();
    ((ISupportInitialize) this.chkRecsReceived).EndInit();
    ((ISupportInitialize) this.chkRoof).EndInit();
    ((ISupportInitialize) this.dtpReceivedDate).EndInit();
    ((ISupportInitialize) this.dtpClosedDate).EndInit();
    ((ISupportInitialize) this.chkClosed).EndInit();
    ((ISupportInitialize) this.chkOnEndorsement).EndInit();
    ((ISupportInitialize) this.dtpDropDeadDate).EndInit();
    ((ISupportInitialize) this.cboInspectionCompany).EndInit();
    ((ISupportInitialize) this.dtpEffectiveDate).EndInit();
    ((ISupportInitialize) this.cboInspectionStatus).EndInit();
    ((ISupportInitialize) this.dtpFollowupDate).EndInit();
    ((ISupportInitialize) this.chkReceived).EndInit();
    ((ISupportInitialize) this.dtpOrderDate).EndInit();
    ((ISupportInitialize) this.chkRevisedContactInfo).EndInit();
    ((ISupportInitialize) this.btnSave).EndInit();
    ((Control) this.utcRecommendations).ResumeLayout(false);
    ((Control) this.utcRecommendations).PerformLayout();
    ((ISupportInitialize) this.dtLastAssessmentDate).EndInit();
    ((ISupportInitialize) this.chkCriticalAccount).EndInit();
    ((ISupportInitialize) this.chkFocusAccount).EndInit();
    ((ISupportInitialize) this.dtpMap).EndInit();
    ((ISupportInitialize) this.dtpSprinklerTest).EndInit();
    ((ISupportInitialize) this.dtpThermo).EndInit();
    ((ISupportInitialize) this.dtpFirePump).EndInit();
    ((ISupportInitialize) this.dtpCPR).EndInit();
    ((ISupportInitialize) this.dtpRecsSent).EndInit();
    ((ISupportInitialize) this.dtpRecsFollowUp).EndInit();
    ((ISupportInitialize) this.dtpRecsCompleted).EndInit();
    ((ISupportInitialize) this.cboRecStatus).EndInit();
    ((ISupportInitialize) this.err).EndInit();
    ((ISupportInitialize) this.ugLocations).EndInit();
    this.dvSource.EndInit();
    ((ISupportInitialize) this.panelSearch).EndInit();
    ((Control) this.panelSearch).ResumeLayout(false);
    ((Control) this.panelSearch).PerformLayout();
    ((ISupportInitialize) this.spinner).EndInit();
    ((ISupportInitialize) this.tabInspections).EndInit();
    ((Control) this.tabInspections).ResumeLayout(false);
    ((ISupportInitialize) this.ddRecStatus).EndInit();
    ((ISupportInitialize) this.ddInspStatus).EndInit();
    ((ISupportInitialize) this.ddInspectComp).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  internal virtual Button btnMakeNote
  {
    get => this._btnMakeNote;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnMakeNote_Click);
      Button btnMakeNote1 = this._btnMakeNote;
      if (btnMakeNote1 != null)
        btnMakeNote1.Click -= eventHandler;
      this._btnMakeNote = value;
      Button btnMakeNote2 = this._btnMakeNote;
      if (btnMakeNote2 == null)
        return;
      btnMakeNote2.Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("Label5")]
  internal virtual Label Label5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label6")]
  internal virtual Label Label6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label7")]
  internal virtual Label Label7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label8")]
  internal virtual Label Label8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label9")]
  internal virtual Label Label9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label10")]
  internal virtual Label Label10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtPolicyNo")]
  internal virtual TextBox txtPolicyNo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtLocationNumber")]
  internal virtual TextBox txtLocationNumber { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtInsured")]
  internal virtual TextBox txtInsured { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtAddress")]
  internal virtual TextBox txtAddress { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtAddress1")]
  internal virtual TextBox txtAddress1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label11")]
  internal virtual Label Label11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtAddress2")]
  internal virtual TextBox txtAddress2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtCity")]
  internal virtual TextBox txtCity { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtState")]
  internal virtual TextBox txtState { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label12")]
  internal virtual Label Label12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label13")]
  internal virtual Label Label13 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("dtpDropDeadDate")]
  private virtual MGADateTimePicker dtpDropDeadDate { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label14")]
  internal virtual Label Label14 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtZip")]
  internal virtual TextBox txtZip { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label15")]
  internal virtual Label Label15 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label17")]
  internal virtual Label Label17 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtInspectionContact")]
  internal virtual TextBox txtInspectionContact { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label18")]
  internal virtual Label Label18 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtContactPhone")]
  internal virtual TextBox txtContactPhone { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label19")]
  internal virtual Label Label19 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label20")]
  internal virtual Label Label20 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("dtpEffectiveDate")]
  private virtual MGADateTimePicker dtpEffectiveDate { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtUnderwriter")]
  internal virtual TextBox txtUnderwriter { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label21")]
  internal virtual Label Label21 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label22")]
  internal virtual Label Label22 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("dtpReceivedDate")]
  private virtual MGADateTimePicker dtpReceivedDate { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkRevisedContactInfo")]
  private virtual MGACheckBox chkRevisedContactInfo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label23")]
  internal virtual Label Label23 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("dtpFollowupDate")]
  private virtual MGADateTimePicker dtpFollowupDate { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label24")]
  internal virtual Label Label24 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("dtpOrderDate")]
  private virtual MGADateTimePicker dtpOrderDate { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ddInspectComp")]
  private virtual UltraDropDown ddInspectComp { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual MGACheckBox chkReceived
  {
    get => this._chkReceived;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.chkReceived_CheckedChanged);
      MGACheckBox chkReceived1 = this._chkReceived;
      if (chkReceived1 != null)
        ((UltraToggleEditorBase) chkReceived1).CheckedChanged -= eventHandler;
      this._chkReceived = value;
      MGACheckBox chkReceived2 = this._chkReceived;
      if (chkReceived2 == null)
        return;
      ((UltraToggleEditorBase) chkReceived2).CheckedChanged += eventHandler;
    }
  }

  [field: AccessedThroughProperty("Label37")]
  internal virtual Label Label37 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label34")]
  internal virtual Label Label34 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label33")]
  internal virtual Label Label33 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("err")]
  internal virtual ErrorProvider err { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtControlNo")]
  internal virtual TextBox txtControlNo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label1")]
  internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cboInspectionStatus")]
  protected virtual MGAComboBox cboInspectionStatus { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label2")]
  internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ddInspStatus")]
  private virtual UltraDropDown ddInspStatus { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label26")]
  internal virtual Label Label26 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label4")]
  internal virtual Label Label4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label3")]
  internal virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual Button btnFollowUp
  {
    get => this._btnFollowUp;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnFollowUp_Click);
      Button btnFollowUp1 = this._btnFollowUp;
      if (btnFollowUp1 != null)
        btnFollowUp1.Click -= eventHandler;
      this._btnFollowUp = value;
      Button btnFollowUp2 = this._btnFollowUp;
      if (btnFollowUp2 == null)
        return;
      btnFollowUp2.Click += eventHandler;
    }
  }

  protected virtual MGAComboBox cboInspectionCompany
  {
    get => this._cboInspectionCompany;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      CancelEventHandler cancelEventHandler = new CancelEventHandler(this.cboInspectionCompany_BeforeDropDown);
      MGAComboBox inspectionCompany1 = this._cboInspectionCompany;
      if (inspectionCompany1 != null)
        inspectionCompany1.BeforeDropDown -= cancelEventHandler;
      this._cboInspectionCompany = value;
      MGAComboBox inspectionCompany2 = this._cboInspectionCompany;
      if (inspectionCompany2 == null)
        return;
      inspectionCompany2.BeforeDropDown += cancelEventHandler;
    }
  }

  [field: AccessedThroughProperty("dvSource")]
  protected virtual DataView dvSource { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label30")]
  internal virtual Label Label30 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual LinkLabel lnkResetAllFilter
  {
    get => this._lnkResetAllFilter;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkResetAllFilter_LinkClicked);
      LinkLabel lnkResetAllFilter1 = this._lnkResetAllFilter;
      if (lnkResetAllFilter1 != null)
        lnkResetAllFilter1.LinkClicked -= clickedEventHandler;
      this._lnkResetAllFilter = value;
      LinkLabel lnkResetAllFilter2 = this._lnkResetAllFilter;
      if (lnkResetAllFilter2 == null)
        return;
      lnkResetAllFilter2.LinkClicked += clickedEventHandler;
    }
  }

  internal virtual TextBox txtFilterName
  {
    get => this._txtFilterName;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.txtFilterName_TextChanged);
      TextBox txtFilterName1 = this._txtFilterName;
      if (txtFilterName1 != null)
        txtFilterName1.TextChanged -= eventHandler;
      this._txtFilterName = value;
      TextBox txtFilterName2 = this._txtFilterName;
      if (txtFilterName2 == null)
        return;
      txtFilterName2.TextChanged += eventHandler;
    }
  }

  [field: AccessedThroughProperty("Label36")]
  internal virtual Label Label36 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual TextBox txtFilterAddress
  {
    get => this._txtFilterAddress;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.txtFilterAddress_TextChanged);
      TextBox txtFilterAddress1 = this._txtFilterAddress;
      if (txtFilterAddress1 != null)
        txtFilterAddress1.TextChanged -= eventHandler;
      this._txtFilterAddress = value;
      TextBox txtFilterAddress2 = this._txtFilterAddress;
      if (txtFilterAddress2 == null)
        return;
      txtFilterAddress2.TextChanged += eventHandler;
    }
  }

  [field: AccessedThroughProperty("Label35")]
  internal virtual Label Label35 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual TextBox txtFilterPolicyNumber
  {
    get => this._txtFilterPolicyNumber;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.txtFilterPolicyNumber_TextChanged);
      TextBox filterPolicyNumber1 = this._txtFilterPolicyNumber;
      if (filterPolicyNumber1 != null)
        filterPolicyNumber1.TextChanged -= eventHandler;
      this._txtFilterPolicyNumber = value;
      TextBox filterPolicyNumber2 = this._txtFilterPolicyNumber;
      if (filterPolicyNumber2 == null)
        return;
      filterPolicyNumber2.TextChanged += eventHandler;
    }
  }

  [field: AccessedThroughProperty("Label32")]
  internal virtual Label Label32 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label31")]
  internal virtual Label Label31 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual TextBox txtFilterControlNo
  {
    get => this._txtFilterControlNo;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.txtFilterControlNo_TextChanged);
      TextBox txtFilterControlNo1 = this._txtFilterControlNo;
      if (txtFilterControlNo1 != null)
        txtFilterControlNo1.TextChanged -= eventHandler;
      this._txtFilterControlNo = value;
      TextBox txtFilterControlNo2 = this._txtFilterControlNo;
      if (txtFilterControlNo2 == null)
        return;
      txtFilterControlNo2.TextChanged += eventHandler;
    }
  }

  internal virtual LinkLabel lnkGridReport
  {
    get => this._lnkGridReport;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkGridReport_LinkClicked);
      LinkLabel lnkGridReport1 = this._lnkGridReport;
      if (lnkGridReport1 != null)
        lnkGridReport1.LinkClicked -= clickedEventHandler;
      this._lnkGridReport = value;
      LinkLabel lnkGridReport2 = this._lnkGridReport;
      if (lnkGridReport2 == null)
        return;
      lnkGridReport2.LinkClicked += clickedEventHandler;
    }
  }

  [field: AccessedThroughProperty("Label16")]
  internal virtual Label Label16 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtOrderedBy")]
  internal virtual TextBox txtOrderedBy { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtInspType")]
  internal virtual TextBox txtInspType { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label28")]
  internal virtual Label Label28 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual LinkLabel lnkDeSelectAll
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

  internal virtual LinkLabel lnkSelectAllRows
  {
    get => this._lnkSelectAllRows;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkSelectAllRows_LinkClicked);
      LinkLabel lnkSelectAllRows1 = this._lnkSelectAllRows;
      if (lnkSelectAllRows1 != null)
        lnkSelectAllRows1.LinkClicked -= clickedEventHandler;
      this._lnkSelectAllRows = value;
      LinkLabel lnkSelectAllRows2 = this._lnkSelectAllRows;
      if (lnkSelectAllRows2 == null)
        return;
      lnkSelectAllRows2.LinkClicked += clickedEventHandler;
    }
  }

  internal virtual LinkLabel lnkLogInfo
  {
    get => this._lnkLogInfo;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkLogInfo_LinkClicked);
      LinkLabel lnkLogInfo1 = this._lnkLogInfo;
      if (lnkLogInfo1 != null)
        lnkLogInfo1.LinkClicked -= clickedEventHandler;
      this._lnkLogInfo = value;
      LinkLabel lnkLogInfo2 = this._lnkLogInfo;
      if (lnkLogInfo2 == null)
        return;
      lnkLogInfo2.LinkClicked += clickedEventHandler;
    }
  }

  [field: AccessedThroughProperty("panelSearch")]
  private virtual UltraGroupBox panelSearch { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("labelSearchText")]
  private virtual Label labelSearchText { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("spinner")]
  public virtual PictureBox spinner { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkOnEndorsement")]
  private virtual MGACheckBox chkOnEndorsement { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtPolicyType")]
  internal virtual TextBox txtPolicyType { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label29")]
  internal virtual Label Label29 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label40")]
  internal virtual Label Label40 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label39")]
  internal virtual Label Label39 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("dtpClosedDate")]
  private virtual MGADateTimePicker dtpClosedDate { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label38")]
  internal virtual Label Label38 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual MGACheckBox chkClosed
  {
    get => this._chkClosed;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.chkClosed_CheckedChanged);
      MGACheckBox chkClosed1 = this._chkClosed;
      if (chkClosed1 != null)
        ((UltraToggleEditorBase) chkClosed1).CheckedChanged -= eventHandler;
      this._chkClosed = value;
      MGACheckBox chkClosed2 = this._chkClosed;
      if (chkClosed2 == null)
        return;
      ((UltraToggleEditorBase) chkClosed2).CheckedChanged += eventHandler;
    }
  }

  [field: AccessedThroughProperty("ultraTabSharedControlsPage1")]
  private virtual UltraTabSharedControlsPage ultraTabSharedControlsPage1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("utpcInspectionInformation")]
  protected virtual UltraTabPageControl utpcInspectionInformation { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("utcRecommendations")]
  protected virtual UltraTabPageControl utcRecommendations { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected virtual MGAButton btnSave
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

  [field: AccessedThroughProperty("Label50")]
  internal virtual Label Label50 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cboRecStatus")]
  protected virtual MGAComboBox cboRecStatus { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label49")]
  internal virtual Label Label49 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label48")]
  internal virtual Label Label48 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label47")]
  internal virtual Label Label47 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtNonCriticalWaived")]
  internal virtual TextBox txtNonCriticalWaived { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtNonCriticalComplete")]
  internal virtual TextBox txtNonCriticalComplete { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtNonCriticalTotal")]
  internal virtual TextBox txtNonCriticalTotal { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtNonCriticalOutstanding")]
  internal virtual TextBox txtNonCriticalOutstanding { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label46")]
  internal virtual Label Label46 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label45")]
  internal virtual Label Label45 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label44")]
  internal virtual Label Label44 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label43")]
  internal virtual Label Label43 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label42")]
  internal virtual Label Label42 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label41")]
  internal virtual Label Label41 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtCriticalWaived")]
  internal virtual TextBox txtCriticalWaived { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtCriticalComplete")]
  internal virtual TextBox txtCriticalComplete { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtCriticalTotal")]
  internal virtual TextBox txtCriticalTotal { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtCriticalOutstanding")]
  internal virtual TextBox txtCriticalOutstanding { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label25")]
  internal virtual Label Label25 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label62")]
  internal virtual Label Label62 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label61")]
  internal virtual Label Label61 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label60")]
  internal virtual Label Label60 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label59")]
  internal virtual Label Label59 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label58")]
  internal virtual Label Label58 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label57")]
  internal virtual Label Label57 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label56")]
  internal virtual Label Label56 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label55")]
  internal virtual Label Label55 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label54")]
  internal virtual Label Label54 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label53")]
  internal virtual Label Label53 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label52")]
  internal virtual Label Label52 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label51")]
  internal virtual Label Label51 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ddRecStatus")]
  private virtual UltraDropDown ddRecStatus { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("dtpRecsSent")]
  private virtual MGADateTimePicker dtpRecsSent { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("dtpRecsFollowUp")]
  private virtual MGADateTimePicker dtpRecsFollowUp { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("dtpRecsCompleted")]
  private virtual MGADateTimePicker dtpRecsCompleted { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected virtual UltraGrid ugLocations
  {
    get => this._ugLocations;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ugLocations_AfterRowActivate);
      UltraGrid ugLocations1 = this._ugLocations;
      if (ugLocations1 != null)
        ugLocations1.AfterRowActivate -= eventHandler;
      this._ugLocations = value;
      UltraGrid ugLocations2 = this._ugLocations;
      if (ugLocations2 == null)
        return;
      ugLocations2.AfterRowActivate += eventHandler;
    }
  }

  [field: AccessedThroughProperty("tabInspections")]
  protected virtual UltraTabControl tabInspections { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkRoof")]
  private virtual MGACheckBox chkRoof { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblNotes")]
  protected virtual Label lblNotes { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtNotes")]
  protected virtual TextBox txtNotes { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label63")]
  protected virtual Label Label63 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ds")]
  protected virtual dsAdminInspReq ds { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label64")]
  internal virtual Label Label64 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkRecsReceived")]
  private virtual MGACheckBox chkRecsReceived { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected virtual LinkLabel lblShowRecords
  {
    get => this._lblShowRecords;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lblShowRecords_LinkClicked);
      LinkLabel lblShowRecords1 = this._lblShowRecords;
      if (lblShowRecords1 != null)
        lblShowRecords1.LinkClicked -= clickedEventHandler;
      this._lblShowRecords = value;
      LinkLabel lblShowRecords2 = this._lblShowRecords;
      if (lblShowRecords2 == null)
        return;
      lblShowRecords2.LinkClicked += clickedEventHandler;
    }
  }

  [field: AccessedThroughProperty("Label76")]
  internal virtual Label Label76 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label75")]
  internal virtual Label Label75 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label74")]
  internal virtual Label Label74 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label73")]
  internal virtual Label Label73 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label72")]
  internal virtual Label Label72 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label71")]
  internal virtual Label Label71 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkCriticalAccount")]
  private virtual MGACheckBox chkCriticalAccount { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label70")]
  internal virtual Label Label70 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkFocusAccount")]
  private virtual MGACheckBox chkFocusAccount { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("dtpMap")]
  private virtual MGADateTimePicker dtpMap { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label69")]
  internal virtual Label Label69 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("dtpSprinklerTest")]
  private virtual MGADateTimePicker dtpSprinklerTest { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label68")]
  internal virtual Label Label68 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("dtpThermo")]
  private virtual MGADateTimePicker dtpThermo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label67")]
  internal virtual Label Label67 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("dtpFirePump")]
  private virtual MGADateTimePicker dtpFirePump { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label66")]
  internal virtual Label Label66 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("dtpCPR")]
  private virtual MGADateTimePicker dtpCPR { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label65")]
  internal virtual Label Label65 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("dtLastAssessmentDate")]
  private virtual MGADateTimePicker dtLastAssessmentDate { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label77")]
  internal virtual Label Label77 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label78")]
  internal virtual Label Label78 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected virtual MGAButton btnUndo
  {
    get => this._btnUndo;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnUndo_Click);
      MGAButton btnUndo1 = this._btnUndo;
      if (btnUndo1 != null)
        ((Control) btnUndo1).Click -= eventHandler;
      this._btnUndo = value;
      MGAButton btnUndo2 = this._btnUndo;
      if (btnUndo2 == null)
        return;
      ((Control) btnUndo2).Click += eventHandler;
    }
  }

  protected virtual MGAButton btnNew
  {
    get => this._btnNew;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnNew_Click);
      MGAButton btnNew1 = this._btnNew;
      if (btnNew1 != null)
        ((Control) btnNew1).Click -= eventHandler;
      this._btnNew = value;
      MGAButton btnNew2 = this._btnNew;
      if (btnNew2 == null)
        return;
      ((Control) btnNew2).Click += eventHandler;
    }
  }

  protected virtual LinkLabel lnkSearchLoc
  {
    get => this._lnkSearchLoc;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkSearchLoc_LinkClicked);
      EventHandler eventHandler = new EventHandler(this.lnkSearchLoc_MouseHover);
      LinkLabel lnkSearchLoc1 = this._lnkSearchLoc;
      if (lnkSearchLoc1 != null)
      {
        lnkSearchLoc1.LinkClicked -= clickedEventHandler;
        lnkSearchLoc1.MouseHover -= eventHandler;
      }
      this._lnkSearchLoc = value;
      LinkLabel lnkSearchLoc2 = this._lnkSearchLoc;
      if (lnkSearchLoc2 == null)
        return;
      lnkSearchLoc2.LinkClicked += clickedEventHandler;
      lnkSearchLoc2.MouseHover += eventHandler;
    }
  }

  protected virtual LinkLabel lnkPolicyInfo
  {
    get => this._lnkPolicyInfo;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkPolicyInfo_LinkClicked);
      EventHandler eventHandler = new EventHandler(this.lnkPolicyInfo_MouseHover);
      LinkLabel lnkPolicyInfo1 = this._lnkPolicyInfo;
      if (lnkPolicyInfo1 != null)
      {
        lnkPolicyInfo1.LinkClicked -= clickedEventHandler;
        lnkPolicyInfo1.MouseHover -= eventHandler;
      }
      this._lnkPolicyInfo = value;
      LinkLabel lnkPolicyInfo2 = this._lnkPolicyInfo;
      if (lnkPolicyInfo2 == null)
        return;
      lnkPolicyInfo2.LinkClicked += clickedEventHandler;
      lnkPolicyInfo2.MouseHover += eventHandler;
    }
  }

  protected virtual LinkLabel lnkSelectUser
  {
    get => this._lnkSelectUser;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkSelectUser_LinkClicked);
      EventHandler eventHandler = new EventHandler(this.lnkSelectUser_MouseHover);
      LinkLabel lnkSelectUser1 = this._lnkSelectUser;
      if (lnkSelectUser1 != null)
      {
        lnkSelectUser1.LinkClicked -= clickedEventHandler;
        lnkSelectUser1.MouseHover -= eventHandler;
      }
      this._lnkSelectUser = value;
      LinkLabel lnkSelectUser2 = this._lnkSelectUser;
      if (lnkSelectUser2 == null)
        return;
      lnkSelectUser2.LinkClicked += clickedEventHandler;
      lnkSelectUser2.MouseHover += eventHandler;
    }
  }

  [field: AccessedThroughProperty("ttInspAdminReq")]
  internal virtual ToolTip ttInspAdminReq { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label79")]
  internal virtual Label Label79 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected virtual MGAComboBox cboAdminInspectionTypes
  {
    get => this._cboAdminInspectionTypes;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.cboAdminInspectionTypes_ValueChanged);
      MGAComboBox adminInspectionTypes1 = this._cboAdminInspectionTypes;
      if (adminInspectionTypes1 != null)
        adminInspectionTypes1.ValueChanged -= eventHandler;
      this._cboAdminInspectionTypes = value;
      MGAComboBox adminInspectionTypes2 = this._cboAdminInspectionTypes;
      if (adminInspectionTypes2 == null)
        return;
      adminInspectionTypes2.ValueChanged += eventHandler;
    }
  }

  [field: AccessedThroughProperty("Label80")]
  internal virtual Label Label80 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  public bool ClickedNew => this._clickedNew;

  private void FormAdminInspectionRequests_Load(object sender, EventArgs e)
  {
    if (this.DesignMode)
      return;
    ((ControlBase) this.btnSave).Appearance.Image = (object) ImageCache.Instance.Save;
    ((ControlBase) this.btnUndo).Appearance.Image = (object) ImageCache.Instance.Undo;
    ((ControlBase) this.btnNew).Appearance.Image = (object) ImageCache.Instance.NewImage;
    ((Control) this.btnSave).Enabled = false;
    this.lnkGridReport.Enabled = false;
    ((Control) this.panelSearch).Visible = true;
    ((UltraToggleEditorBase) this.chkReceived).CheckedChanged -= new EventHandler(this.chkReceived_CheckedChanged);
    this._hlkControlNo.HyperLinkOpening += new CancelEventHandler(this._hlkControlNo_Opening);
    ((UltraTabControlBase) this.tabInspections).Tabs[1].Visible = MGASystems.Common.Settings.SystemSettings.GetSetting<bool>("ShowInspAdminRecommendationsTab");
    this._inspectTypeDefault = MGASystems.Common.Settings.SystemSettings.GetSetting<int>("AdminInspectionRequest.InspectionType.Default");
    this._allowEdits = MGASystems.Common.Settings.SystemSettings.GetSetting<bool>("AdminInspectionRequest.AllowEdits");
    this.ds.lstAdminInspectionStatus.AddlstAdminInspectionStatusRow(string.Empty);
    this.ds.lstAdminInspectionTypes.AddlstAdminInspectionTypesRow(string.Empty);
    this.SetPanelText("Loading list tables ...");
    DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[4]
    {
      "tblFin_ExpensePayees",
      "lstAdminInspectionStatus",
      "lstInspectionsAdminRecStatus",
      "lstAdminInspectionTypes"
    }, "spGetAdminInspectionsListTables");
    this.lblShowRecords.Enabled = false;
    EnumerableRowCollection<DataRow> source = DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT PayeeID FROM lstHiddenInspectionCompanies").AsEnumerable();
    System.Func<DataRow, int> selector;
    // ISSUE: reference to a compiler-generated field
    if (FormAdminInspectionRequests._Closure\u0024__.\u0024I675\u002D0 != null)
    {
      // ISSUE: reference to a compiler-generated field
      selector = FormAdminInspectionRequests._Closure\u0024__.\u0024I675\u002D0;
    }
    else
    {
      // ISSUE: reference to a compiler-generated field
      FormAdminInspectionRequests._Closure\u0024__.\u0024I675\u002D0 = selector = (System.Func<DataRow, int>) ([SpecialName] (datarow) => datarow.Field<int>("PayeeID"));
    }
    this._hiddenInspectioncompanies = source.Select<DataRow, int>(selector).ToList<int>();
    this.FillData(false);
  }

  private void FillData(bool tmpClosed)
  {
    this.ds.tblAdminInspectionRequests.Clear();
    ((UltraGridBase) this.ugLocations).DisplayLayout.Save((Stream) this._gridLayout);
    ((UltraGridBase) this.ugLocations).DataSource = (object) null;
    ThreadPool.QueueUserWorkItem(new WaitCallback(this.ThreadedFill), (object) tmpClosed);
  }

  private void SetPanelText(string txt)
  {
    this.labelSearchText.Text = txt;
    ((UltraControlBase) this.panelSearch).Refresh();
  }

  private void ThreadedFill(object state)
  {
    object obj = (object) DBNull.Value;
    if (MGASystems.Common.Settings.SystemSettings.GetSetting<bool>("Admin.InspectionRequest.LimitControlNo"))
    {
      Form[] mdiChildren = MDIControls.Instance.MDIParent.MdiChildren;
      int index = 0;
      while (index < mdiChildren.Length)
      {
        switch (mdiChildren[index])
        {
          case frmPolicyDetail frmPolicyDetail:
            obj = (object) frmPolicyDetail.ControlNumber;
            goto label_7;
          case frmClearance frmClearance:
            obj = (object) frmClearance.ControlNum;
            goto label_7;
          default:
            checked { ++index; }
            continue;
        }
      }
    }
label_7:
    MDIControls.Instance.MDIParent.BeginInvoke((Delegate) new FormAdminInspectionRequests.ThreadProgressBarHandler(this.SetPanelText), (object) (Conversions.ToBoolean(state) ? "Fetching CLOSED Admin Inpection Data ..." : "Fetching OPENED Admin Inpection Data ..."));
    DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[1]
    {
      "tblAdminInspectionRequests"
    }, "dbo.GetAdminInspectionsData", new object[4]
    {
      (object) "@Closed",
      (object) Conversions.ToBoolean(state),
      (object) "@Controlno",
      obj
    });
    MDIControls.Instance.MDIParent.BeginInvoke((Delegate) new FormAdminInspectionRequests.ThreadCompleteHandler(this.ThreadComplete), (object) this, (object) EventArgs.Empty);
  }

  private void ThreadComplete(object sender, EventArgs e)
  {
    this.SetPanelText(string.Empty);
    ((UltraGridBase) this.ugLocations).DataSource = (object) this.dvSource;
    this._gridLayout.Position = 0L;
    ((UltraGridBase) this.ugLocations).DisplayLayout.Load((Stream) this._gridLayout);
    ((UltraGridBase) this.ugLocations).DisplayLayout.ScrollBarLook.ViewStyle = (ScrollBarViewStyle) 3;
    foreach (UltraGridRow row in ((UltraGridBase) this.ugLocations).Rows)
      row.Cells["ControlNo"].Appearance.ForeColor = Utility.IsNull(RuntimeHelpers.GetObjectValue(row.Cells["Received"].Value)) || !Conversions.ToBoolean(row.Cells["Received"].Value) ? Color.Black : Color.Red;
    List<string> stringList = new List<string>()
    {
      "CriticalOutstanding",
      "CriticalWaived",
      "CriticalComplete",
      "CriticalTotal",
      "NonCriticalOutstanding",
      "NonCriticalWaived",
      "NonCriticalComplete",
      "NonCriticalTotal",
      "RecSent",
      "RecStatusID",
      "RecsFollowUp",
      "RecsCompleted",
      "CPR",
      "Map",
      "SprinklerTest",
      "Thermo",
      "FirePump",
      "FocusAccount",
      "CriticalAccount",
      "LastAssessmentDate"
    };
    if (!MGASystems.Common.Settings.SystemSettings.GetSetting<bool>("ShowInspAdminRecommendationsTab"))
    {
      foreach (UltraGridColumn column in ((UltraGridBase) this.ugLocations).DisplayLayout.Bands[0].Columns)
      {
        if (stringList.Contains(column.Key))
          column.Hidden = true;
      }
    }
    this.ugLocations.AfterRowActivate += new EventHandler(this.ugLocations_AfterRowActivate);
    ((UltraToggleEditorBase) this.chkReceived).CheckedChanged += new EventHandler(this.chkReceived_CheckedChanged);
    ((UltraGridBase) this.ugLocations).DisplayLayout.Bands[0].Columns["ControlNo"].Editor = (EmbeddableEditorBase) this._hlkControlNo;
    ((UltraGridBase) this.ugLocations).DisplayLayout.Bands[0].Columns["ControlNo"].CellAppearance.FontData.Underline = (DefaultableBoolean) 1;
    string str = "Received=" + Conversions.ToString(0);
    if (MGASystems.Common.Settings.SystemSettings.GetSetting<bool>("ShowAllRecordsOnInspAdminLoad"))
      str = string.Empty;
    this.dvSource.RowFilter = str;
    ((Control) this.btnSave).Enabled = true;
    this.lnkGridReport.Enabled = true;
    ((Control) this.panelSearch).Visible = false;
    this.lblShowRecords.Enabled = true;
    this.MakeControlsReadOnly(true);
    if (this._allowEdits)
    {
      ((Control) this.btnUndo).Visible = true;
      ((Control) this.btnNew).Visible = true;
    }
    this._loadComplete = true;
  }

  private void btnMakeNote_Click(object sender, EventArgs e)
  {
    if (((UltraGridBase) this.ugLocations).ActiveRow == null)
    {
      int num1 = (int) MessageBox.Show("Please select a row in the grid to work with.", "No Row Selected", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    else
    {
      int integer1 = Conversions.ToInteger(((UltraGridBase) this.ugLocations).ActiveRow.Cells["ControlNo"].Value);
      if (!DefaultDatabase.ExecuteScalar<bool>("ValidateUserRightControlNo", new object[4]
      {
        (object) "@ControlNo",
        (object) integer1,
        (object) "@UserGuid",
        (object) CurrentUser.Instance.UserGUID
      }))
      {
        int num2 = (int) MessageBox.Show($"Control # {integer1} does not exist.", "Control # Not Exist", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      }
      else
      {
        Quote quote = Quote.FromControlNo(integer1);
        int integer2 = Conversions.ToInteger(((UltraGridBase) this.ugLocations).ActiveRow.Cells["LocationID"].Value);
        if (MGASystems.Common.Settings.SystemSettings.GetSetting<int>("InspectionNoteTypeID", -1) == -1)
        {
          int num3 = (int) MessageBox.Show("Please administer Inspection Note Type via system setting.", "Inspection Note Type Needed", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        else
        {
          NoteSupportCache noteSupport = new NoteSupportCache(quote.ControlGuid, $"Loc:{integer2} / Policy: {quote.PolicyNumber} / {quote.InsuredPolicyName} / ", $"Policy: {quote.ControlNo}", "MGASystems.IMS.Policies.PolicyDetail.frmPolicyDetail", true, quote.ControlGuid);
          string str1 = string.Empty;
          if (this.cboInspectionCompany.Value != null && this.cboInspectionCompany.Value != DBNull.Value)
            str1 = this.cboInspectionCompany.Text;
          string str2 = string.Empty;
          if (((UltraGridBase) this.ugLocations).ActiveRow.Cells["Address1"].Value != DBNull.Value)
            str2 = $"{RuntimeHelpers.GetObjectValue(((UltraGridBase) this.ugLocations).ActiveRow.Cells["Address1"].Value)}, ";
          if (((UltraGridBase) this.ugLocations).ActiveRow.Cells["City"].Value != DBNull.Value)
            str2 = $"{str2}{RuntimeHelpers.GetObjectValue(((UltraGridBase) this.ugLocations).ActiveRow.Cells["City"].Value)}, ";
          if (((UltraGridBase) this.ugLocations).ActiveRow.Cells["State"].Value != DBNull.Value)
            str2 = $"{str2}{RuntimeHelpers.GetObjectValue(((UltraGridBase) this.ugLocations).ActiveRow.Cells["State"].Value)} ";
          if (((UltraGridBase) this.ugLocations).ActiveRow.Cells["Zip"].Value != DBNull.Value)
            str2 = $"{str2}{RuntimeHelpers.GetObjectValue(((UltraGridBase) this.ugLocations).ActiveRow.Cells["Zip"].Value)}";
          string str3 = $"ALERT! An inspection report for this account has not been received within 55 days of inception.{Environment.NewLine}" + $"Please let us know if you want notice of cancellation sent or will accept the risk with a late report.{Environment.NewLine}" + $"Location Address: {str2}" + $"{Environment.NewLine}Control #: {quote.ControlNo}{Environment.NewLine}Inspection requested with {str1}{Environment.NewLine}Location Address: {this.txtAddress.Text}";
          DateAndTime.Now.AddDays(30.0);
          object objectValue;
          if (!quote.UsingNetRate)
            objectValue = RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT DueDate FROM tblUnderwritingLocations WITH (NOLOCK) WHERE LocationID = @LD", new object[2]
            {
              (object) "@LD",
              (object) integer2
            }));
          else
            objectValue = RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT DueDate FROM tblInspectionsNetRateLocData WITH (NOLOCK) WHERE LocationID = @LD", new object[2]
            {
              (object) "@LD",
              (object) integer2
            }));
          if (objectValue != null && objectValue != DBNull.Value)
            Convert.ToDateTime(RuntimeHelpers.GetObjectValue(objectValue));
          Note_System.Instance.UIInteractive.CreateBoundNote((ISupportNoteSystem) noteSupport);
        }
      }
    }
  }

  private void btnSave_Click(object sender, EventArgs e)
  {
    if (((UltraGridBase) this.ugLocations).ActiveRow == null && !this.ClickedNew)
    {
      int num1 = (int) MessageBox.Show("Please select a row in the grid to save.", "No Row Selected", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    else if (((UltraToggleEditorBase) this.chkClosed).Checked && Utility.IsNull(RuntimeHelpers.GetObjectValue(this.dtpClosedDate.Value)))
    {
      int num2 = (int) MessageBox.Show("Closed check box is checked without a closed date entry.", "No Closed Date Selected", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
    else if (!((UltraToggleEditorBase) this.chkClosed).Checked && !Utility.IsNull(RuntimeHelpers.GetObjectValue(this.dtpClosedDate.Value)))
    {
      int num3 = (int) MessageBox.Show("Closed date is selected and whilst closed check box is unchecked.", "Closed Check Box Not Selected", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
    else
    {
      if (!this.ClickedNew && MessageBox.Show("Please note that only the controls asterisked in red will be saved.\n\nContinue to save data?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No || this.ClickedNew && !this.ValidateOnClickNew())
        return;
      try
      {
        this.Cursor = MgaCursors.WaitCursor;
        UltraGridRow gridRow = (UltraGridRow) null;
        int integer1;
        int integer2;
        Decimal num4;
        if (!this.ClickedNew)
        {
          gridRow = ((UltraGridBase) this.ugLocations).ActiveRow;
          integer1 = Conversions.ToInteger(((UltraGridBase) this.ugLocations).ActiveRow.Cells["LocationID"].Value);
          integer2 = Conversions.ToInteger(((UltraGridBase) this.ugLocations).ActiveRow.Cells["ControlNo"].Value);
          num4 = Conversions.ToDecimal(((UltraGridBase) this.ugLocations).ActiveRow.Cells["ID"].Value);
        }
        else
        {
          integer1 = Conversions.ToInteger(this.txtLocationNumber.Tag);
          integer2 = Conversions.ToInteger(this.txtControlNo.Text);
        }
        object objectValue1 = RuntimeHelpers.GetObjectValue(Interaction.IIf(!string.IsNullOrEmpty(this.cboInspectionStatus.Text), RuntimeHelpers.GetObjectValue(this.cboInspectionStatus.Value), (object) DBNull.Value));
        object objectValue2 = RuntimeHelpers.GetObjectValue(Interaction.IIf(!Utility.IsNull(RuntimeHelpers.GetObjectValue(this.dtpReceivedDate.Value)), RuntimeHelpers.GetObjectValue(this.dtpReceivedDate.Value), (object) DBNull.Value));
        object objectValue3 = RuntimeHelpers.GetObjectValue(Interaction.IIf(!Utility.IsNull(RuntimeHelpers.GetObjectValue(this.dtpFollowupDate.Value)), RuntimeHelpers.GetObjectValue(this.dtpFollowupDate.Value), (object) DBNull.Value));
        object objectValue4 = RuntimeHelpers.GetObjectValue(Interaction.IIf(!Utility.IsNull(RuntimeHelpers.GetObjectValue(this.dtpDropDeadDate.Value)), RuntimeHelpers.GetObjectValue(this.dtpDropDeadDate.Value), (object) DBNull.Value));
        object objectValue5 = RuntimeHelpers.GetObjectValue(Interaction.IIf(!Utility.IsNull(RuntimeHelpers.GetObjectValue(this.dtpOrderDate.Value)), RuntimeHelpers.GetObjectValue(this.dtpOrderDate.Value), (object) DBNull.Value));
        object objectValue6 = RuntimeHelpers.GetObjectValue(Interaction.IIf(!Utility.IsNull(RuntimeHelpers.GetObjectValue(this.cboInspectionCompany.Value)), RuntimeHelpers.GetObjectValue(this.cboInspectionCompany.Value), (object) DBNull.Value));
        object objectValue7 = RuntimeHelpers.GetObjectValue(Interaction.IIf(!Utility.IsNull(RuntimeHelpers.GetObjectValue(this.dtpClosedDate.Value)), RuntimeHelpers.GetObjectValue(this.dtpClosedDate.Value), (object) DBNull.Value));
        object objectValue8 = RuntimeHelpers.GetObjectValue(Interaction.IIf(!Utility.IsNull(RuntimeHelpers.GetObjectValue(this.cboRecStatus.Value)), RuntimeHelpers.GetObjectValue(this.cboRecStatus.Value), (object) DBNull.Value));
        object objectValue9 = RuntimeHelpers.GetObjectValue(Interaction.IIf(!Utility.IsNull(RuntimeHelpers.GetObjectValue(this.dtpRecsSent.Value)), RuntimeHelpers.GetObjectValue(this.dtpRecsSent.Value), (object) DBNull.Value));
        object objectValue10 = RuntimeHelpers.GetObjectValue(Interaction.IIf(!Utility.IsNull(RuntimeHelpers.GetObjectValue(this.dtpRecsFollowUp.Value)), RuntimeHelpers.GetObjectValue(this.dtpRecsFollowUp.Value), (object) DBNull.Value));
        object objectValue11 = RuntimeHelpers.GetObjectValue(Interaction.IIf(!Utility.IsNull(RuntimeHelpers.GetObjectValue(this.dtpRecsCompleted.Value)), RuntimeHelpers.GetObjectValue(this.dtpRecsCompleted.Value), (object) DBNull.Value));
        object objectValue12 = RuntimeHelpers.GetObjectValue(Interaction.IIf(!Utility.IsNull(RuntimeHelpers.GetObjectValue(this.dtpCPR.Value)), RuntimeHelpers.GetObjectValue(this.dtpCPR.Value), (object) DBNull.Value));
        object objectValue13 = RuntimeHelpers.GetObjectValue(Interaction.IIf(!Utility.IsNull(RuntimeHelpers.GetObjectValue(this.dtpMap.Value)), RuntimeHelpers.GetObjectValue(this.dtpMap.Value), (object) DBNull.Value));
        object objectValue14 = RuntimeHelpers.GetObjectValue(Interaction.IIf(!Utility.IsNull(RuntimeHelpers.GetObjectValue(this.dtpSprinklerTest.Value)), RuntimeHelpers.GetObjectValue(this.dtpSprinklerTest.Value), (object) DBNull.Value));
        object objectValue15 = RuntimeHelpers.GetObjectValue(Interaction.IIf(!Utility.IsNull(RuntimeHelpers.GetObjectValue(this.dtpThermo.Value)), RuntimeHelpers.GetObjectValue(this.dtpThermo.Value), (object) DBNull.Value));
        object objectValue16 = RuntimeHelpers.GetObjectValue(Interaction.IIf(!Utility.IsNull(RuntimeHelpers.GetObjectValue(this.dtpFirePump.Value)), RuntimeHelpers.GetObjectValue(this.dtpFirePump.Value), (object) DBNull.Value));
        object objectValue17 = RuntimeHelpers.GetObjectValue(Interaction.IIf(!Utility.IsNull(RuntimeHelpers.GetObjectValue(this.dtLastAssessmentDate.Value)), RuntimeHelpers.GetObjectValue(this.dtLastAssessmentDate.Value), (object) DBNull.Value));
        object objectValue18 = RuntimeHelpers.GetObjectValue(Interaction.IIf(!string.IsNullOrEmpty(this.cboAdminInspectionTypes.Text), RuntimeHelpers.GetObjectValue(this.cboAdminInspectionTypes.Value), (object) DBNull.Value));
        if (!this.ClickedNew)
          DefaultDatabase.ExecuteNonQuery("SaveAdminInspectionData", new object[78]
          {
            (object) "@LocationID",
            (object) integer1,
            (object) "@ControlNo",
            (object) this.txtControlNo.Text,
            (object) "@OrderDate",
            this.dtpOrderDate.Value,
            (object) "@DropDeadDate",
            this.dtpDropDeadDate.Value,
            (object) "@FollowupDate",
            this.dtpFollowupDate.Value,
            (object) "@ReceivedDate",
            this.dtpReceivedDate.Value,
            (object) "@Received",
            (object) ((UltraToggleEditorBase) this.chkReceived).Checked,
            (object) "@RevisedContactInfo",
            (object) ((UltraToggleEditorBase) this.chkRevisedContactInfo).Checked,
            (object) "@InspectionContact",
            (object) this.txtInspectionContact.Text,
            (object) "@InspectionContactPhone",
            (object) this.txtContactPhone.Text,
            (object) "@InspectionCompanyID",
            this.cboInspectionCompany.Value,
            (object) "@InspectionStatus",
            objectValue1,
            (object) "@ID",
            (object) num4,
            (object) "@Closed",
            (object) ((UltraToggleEditorBase) this.chkClosed).Checked,
            (object) "@ClosedDate",
            objectValue7,
            (object) "@CriticalOutstanding",
            (object) this.txtCriticalOutstanding.Text,
            (object) "@CriticalWaived",
            (object) this.txtCriticalWaived.Text,
            (object) "@CriticalComplete",
            (object) this.txtCriticalComplete.Text,
            (object) "@CriticalTotal",
            (object) this.txtCriticalTotal.Text,
            (object) "@NonCriticalOutstanding",
            (object) this.txtNonCriticalOutstanding.Text,
            (object) "@NonCriticalWaived",
            (object) this.txtNonCriticalWaived.Text,
            (object) "@NonCriticalComplete",
            (object) this.txtNonCriticalComplete.Text,
            (object) "@NonCriticalTotal",
            (object) this.txtNonCriticalTotal.Text,
            (object) "@RecStatusID",
            objectValue8,
            (object) "@RecSent",
            this.dtpRecsSent.Value,
            (object) "@RecsFollowUp",
            this.dtpRecsFollowUp.Value,
            (object) "@RecsCompleted",
            this.dtpRecsCompleted.Value,
            (object) "@Notes",
            (object) this.txtNotes.Text,
            (object) "@RecsReceived",
            (object) ((UltraToggleEditorBase) this.chkRecsReceived).Checked,
            (object) "@CPR",
            objectValue12,
            (object) "@Map",
            objectValue13,
            (object) "@SprinklerTest",
            objectValue14,
            (object) "@Thermo",
            objectValue15,
            (object) "@FirePump",
            objectValue16,
            (object) "@FocusAccount",
            (object) ((UltraToggleEditorBase) this.chkFocusAccount).Checked,
            (object) "@CriticalAccount",
            (object) ((UltraToggleEditorBase) this.chkCriticalAccount).Checked,
            (object) "@LastAssessmentDate",
            objectValue17,
            (object) "@InspectionTypeID",
            objectValue18,
            (object) "@InspectionType",
            (object) this.txtInspType.Text
          });
        else
          num4 = this.InsertRecord(integer1, RuntimeHelpers.GetObjectValue(objectValue1), RuntimeHelpers.GetObjectValue(objectValue7), RuntimeHelpers.GetObjectValue(objectValue8), RuntimeHelpers.GetObjectValue(objectValue12), RuntimeHelpers.GetObjectValue(objectValue13), RuntimeHelpers.GetObjectValue(objectValue14), RuntimeHelpers.GetObjectValue(objectValue15), RuntimeHelpers.GetObjectValue(objectValue16), RuntimeHelpers.GetObjectValue(objectValue17), RuntimeHelpers.GetObjectValue(objectValue18));
        try
        {
          foreach (DataRow row in this.dvSource.Table.Rows)
          {
            if (Decimal.Compare(new Decimal(Conversions.ToInteger(row["ID"])), num4) == 0)
            {
              row["OrderDate"] = RuntimeHelpers.GetObjectValue(objectValue5);
              row["DropDeadDate"] = RuntimeHelpers.GetObjectValue(objectValue4);
              row["FollowupDate"] = RuntimeHelpers.GetObjectValue(objectValue3);
              row["ReceivedDate"] = RuntimeHelpers.GetObjectValue(objectValue2);
              row["Received"] = (object) ((UltraToggleEditorBase) this.chkReceived).Checked;
              row["RevisedContactInfo"] = (object) ((UltraToggleEditorBase) this.chkRevisedContactInfo).Checked;
              row["InspectionContact"] = (object) this.txtInspectionContact.Text;
              row["InspectionContactPhone"] = (object) this.txtContactPhone.Text;
              row["InspectionCompanyID"] = RuntimeHelpers.GetObjectValue(objectValue6);
              row["InspectionStatus"] = RuntimeHelpers.GetObjectValue(objectValue1);
              row["Closed"] = (object) ((UltraToggleEditorBase) this.chkClosed).Checked;
              row["ClosedDate"] = RuntimeHelpers.GetObjectValue(objectValue7);
              row["CriticalOutstanding"] = (object) this.txtCriticalOutstanding.Text;
              row["CriticalWaived"] = (object) this.txtCriticalWaived.Text;
              row["CriticalComplete"] = (object) this.txtCriticalComplete.Text;
              row["CriticalTotal"] = (object) this.txtCriticalTotal.Text;
              row["NonCriticalOutstanding"] = (object) this.txtNonCriticalOutstanding.Text;
              row["NonCriticalWaived"] = (object) this.txtNonCriticalWaived.Text;
              row["NonCriticalComplete"] = (object) this.txtNonCriticalComplete.Text;
              row["NonCriticalTotal"] = (object) this.txtNonCriticalTotal.Text;
              row["RecStatusID"] = RuntimeHelpers.GetObjectValue(objectValue8);
              row["RecSent"] = RuntimeHelpers.GetObjectValue(objectValue9);
              row["RecsFollowUp"] = RuntimeHelpers.GetObjectValue(objectValue10);
              row["RecsCompleted"] = RuntimeHelpers.GetObjectValue(objectValue11);
              row["Notes"] = (object) this.txtNotes.Text;
              row["RecsReceived"] = (object) ((UltraToggleEditorBase) this.chkRecsReceived).Checked;
              row["CPR"] = RuntimeHelpers.GetObjectValue(objectValue12);
              row["Map"] = RuntimeHelpers.GetObjectValue(objectValue13);
              row["SprinklerTest"] = RuntimeHelpers.GetObjectValue(objectValue14);
              row["Thermo"] = RuntimeHelpers.GetObjectValue(objectValue15);
              row["FirePump"] = RuntimeHelpers.GetObjectValue(objectValue16);
              row["FocusAccount"] = (object) ((UltraToggleEditorBase) this.chkFocusAccount).Checked;
              row["CriticalAccount"] = (object) ((UltraToggleEditorBase) this.chkCriticalAccount).Checked;
              row["LastAssessmentDate"] = RuntimeHelpers.GetObjectValue(objectValue17);
              row["InspectionTypeID"] = RuntimeHelpers.GetObjectValue(objectValue18);
              row["OrderedBy"] = (object) this.txtOrderedBy.Text;
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
        ((UltraGridBase) this.ugLocations).UpdateData();
        if (!this.ClickedNew)
        {
          this.LogInspectionInfo(gridRow);
        }
        else
        {
          Guid userGuid = CurrentUser.Instance.UserGUID;
          string str = $"Create admin inspection request for location # {this.txtLocationNumber.Text} on control # {this.txtControlNo.Text}";
          DefaultDatabase.ExecuteNonQuery("LogAdminInspInfo", new object[10]
          {
            (object) "@AdminInspID",
            (object) num4,
            (object) "@LocationID",
            (object) integer1,
            (object) "@CurrentUser",
            (object) userGuid,
            (object) "@ControlNo",
            (object) integer2,
            (object) "@Action",
            (object) str
          });
        }
        this.SetActiveRow(num4);
        this.OnClickingSave(num4);
      }
      finally
      {
        ((Control) this.ugLocations).Enabled = true;
        this._clickedNew = false;
        ((Control) this.btnNew).Enabled = true;
        this.MakeControlsReadOnly(true);
        this.Cursor = MgaCursors.Default;
      }
    }
  }

  protected virtual void OnClickingSave(Decimal ID)
  {
  }

  private void LoadData()
  {
    try
    {
      this.ds.tblAdminInspectionRequests.Clear();
      DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[1]
      {
        "tblAdminInspectionRequests"
      }, "GetAdminInspectionsData");
    }
    catch (ConstraintException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      ErrorHandler.ShowDataSetErrors((DataSet) this.ds, ex);
      ProjectData.ClearProjectError();
    }
    foreach (UltraGridRow row in ((UltraGridBase) this.ugLocations).Rows)
      row.Cells["ControlNo"].Appearance.ForeColor = row.Cells["Received"].Value == null || row.Cells["Received"].Value == DBNull.Value || !Conversions.ToBoolean(row.Cells["Received"].Value) ? Color.Black : Color.Red;
  }

  private void SetActiveRow(Decimal ID)
  {
    int num = 0;
    foreach (UltraGridRow row in ((UltraGridBase) this.ugLocations).Rows)
    {
      if (Decimal.Compare(ID, new Decimal(Conversions.ToInteger(row.Cells[nameof (ID)].Value))) == 0)
      {
        ((UltraGridBase) this.ugLocations).Rows[num].Activate();
        break;
      }
      ++num;
    }
  }

  private void ClearControls()
  {
    try
    {
      foreach (Control control in ((Control) this.utpcInspectionInformation).Controls)
      {
        if (control is MGATextBox)
          control.Text = string.Empty;
        else if (control is MGADateTimePicker mgaDateTimePicker)
        {
          mgaDateTimePicker.Value = (object) null;
        }
        else
        {
          if (control is MGACheckBox mgaCheckBox)
            ((UltraToggleEditorBase) mgaCheckBox).Checked = false;
          if (control is MGAComboBox mgaComboBox)
            mgaComboBox.Value = (object) null;
          if (control is TextBox textBox)
            textBox.Text = string.Empty;
        }
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
      foreach (Control control in ((Control) this.utcRecommendations).Controls)
      {
        if (control is MGATextBox)
          control.Text = string.Empty;
        else if (control is MGADateTimePicker mgaDateTimePicker)
        {
          mgaDateTimePicker.Value = (object) null;
        }
        else
        {
          if (control is MGACheckBox mgaCheckBox)
            ((UltraToggleEditorBase) mgaCheckBox).Checked = false;
          if (control is MGAComboBox mgaComboBox)
            mgaComboBox.Value = (object) null;
          if (control is TextBox textBox)
            textBox.Text = string.Empty;
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

  private void ugLocations_AfterRowActivate(object sender, EventArgs e)
  {
    this.ClearControls();
    if (((UltraGridBase) this.ugLocations).ActiveRow == null)
      return;
    Decimal ID = Conversions.ToDecimal(((UltraGridBase) this.ugLocations).ActiveRow.Cells["ID"].Value);
    dsAdminInspReq.tblAdminInspectionRequestsRow byId = this.ds.tblAdminInspectionRequests.FindByID(ID);
    this.txtControlNo.Text = byId.ControlNo.ToString();
    this.txtPolicyNo.Text = byId.PolicyNumber;
    this.txtInsured.Text = byId.Insured;
    if (!byId.IsLocationNumberNull())
      this.txtLocationNumber.Text = byId.LocationNumber;
    this.cboInspectionCompany.Value = (object) byId.InspectionCompanyID;
    if (!byId.IsAddress1Null())
    {
      this.txtAddress1.Text = byId.Address1;
      this.txtAddress.Text = byId.Address1 + "\n";
    }
    if (!byId.IsAddress2Null())
      this.txtAddress2.Text = byId.Address2;
    if (!byId.IsCityNull())
    {
      this.txtCity.Text = byId.City;
      this.txtAddress.Text = $"{this.txtAddress.Text}, {byId.City}";
    }
    if (!byId.IsStateNull())
    {
      this.txtState.Text = byId.State;
      this.txtAddress.Text = $"{this.txtAddress.Text}, {byId.State}";
    }
    if (!byId.IsZipNull())
    {
      this.txtZip.Text = byId.Zip;
      this.txtAddress.Text = $"{this.txtAddress.Text} {byId.Zip}";
    }
    if (!byId.IsInspectionContactNull())
      this.txtInspectionContact.Text = byId.InspectionContact;
    if (!byId.IsInspectionContactPhoneNull())
      this.txtContactPhone.Text = byId.InspectionContactPhone;
    this.txtUnderwriter.Text = byId.Underwriter;
    if (!byId.IsEffectiveDateNull())
      this.dtpEffectiveDate.Value = (object) byId.EffectiveDate;
    if (!byId.IsReceivedDateNull())
      this.dtpReceivedDate.Value = (object) byId.ReceivedDate;
    if (!byId.IsDropDeadDateNull())
      this.dtpDropDeadDate.Value = (object) byId.DropDeadDate;
    if (!byId.IsFollowupDateNull())
      this.dtpFollowupDate.Value = (object) byId.FollowupDate;
    if (!byId.IsOrderDateNull())
      this.dtpOrderDate.Value = (object) byId.OrderDate;
    if (!byId.IsRevisedContactInfoNull())
      ((UltraToggleEditorBase) this.chkRevisedContactInfo).Checked = byId.RevisedContactInfo;
    try
    {
      ((UltraToggleEditorBase) this.chkReceived).CheckedChanged -= new EventHandler(this.chkReceived_CheckedChanged);
      if (!byId.IsReceivedNull())
        ((UltraToggleEditorBase) this.chkReceived).Checked = byId.Received;
    }
    finally
    {
      ((UltraToggleEditorBase) this.chkReceived).CheckedChanged += new EventHandler(this.chkReceived_CheckedChanged);
    }
    if (!byId.IsInspectionStatusNull())
      this.cboInspectionStatus.Value = (object) byId.InspectionStatus;
    if (!byId.IsOrderedByNull())
      this.txtOrderedBy.Text = byId.OrderedBy;
    if (!byId.IsInspTypeNull())
      this.txtInspType.Text = byId.InspType;
    if (!byId.IsPolicyTypeNull())
      this.txtPolicyType.Text = byId.PolicyType;
    if (!byId.IsOnEndorsementNull())
      ((UltraToggleEditorBase) this.chkOnEndorsement).Checked = byId.OnEndorsement;
    if (!byId.IsClosedNull())
      ((UltraToggleEditorBase) this.chkClosed).Checked = byId.Closed;
    if (!byId.IsClosedDateNull())
      this.dtpClosedDate.Value = (object) byId.ClosedDate;
    if (!byId.IsCriticalOutstandingNull())
      this.txtCriticalOutstanding.Text = byId.CriticalOutstanding;
    if (!byId.IsCriticalWaivedNull())
      this.txtCriticalWaived.Text = byId.CriticalWaived;
    if (!byId.IsCriticalCompleteNull())
      this.txtCriticalComplete.Text = byId.CriticalComplete;
    if (!byId.IsCriticalTotalNull())
      this.txtCriticalTotal.Text = byId.CriticalTotal;
    if (!byId.IsNonCriticalOutstandingNull())
      this.txtNonCriticalOutstanding.Text = byId.NonCriticalOutstanding;
    if (!byId.IsNonCriticalWaivedNull())
      this.txtNonCriticalWaived.Text = byId.NonCriticalWaived;
    if (!byId.IsNonCriticalCompleteNull())
      this.txtNonCriticalComplete.Text = byId.NonCriticalComplete;
    if (!byId.IsNonCriticalTotalNull())
      this.txtNonCriticalTotal.Text = byId.NonCriticalTotal;
    if (!byId.IsRecStatusIDNull())
      this.cboRecStatus.Value = (object) byId.RecStatusID;
    if (!byId.IsRecSentNull())
      this.dtpRecsSent.Value = (object) byId.RecSent;
    if (!byId.IsRecsFollowUpNull())
      this.dtpRecsFollowUp.Value = (object) byId.RecsFollowUp;
    if (!byId.IsRecsCompletedNull())
      this.dtpRecsCompleted.Value = (object) byId.RecsCompleted;
    if (!byId.IsRoofNull())
      ((UltraToggleEditorBase) this.chkRoof).Checked = byId.Roof;
    if (!byId.IsNotesNull())
      this.txtNotes.Text = byId.Notes;
    if (!byId.IsRecsReceivedNull())
      ((UltraToggleEditorBase) this.chkRecsReceived).Checked = byId.RecsReceived;
    if (!byId.IsCPRNull())
      this.dtpCPR.Value = (object) byId.CPR;
    if (!byId.IsMapNull())
      this.dtpMap.Value = (object) byId.Map;
    if (!byId.IsSprinklerTestNull())
      this.dtpSprinklerTest.Value = (object) byId.SprinklerTest;
    if (!byId.IsThermoNull())
      this.dtpThermo.Value = (object) byId.Thermo;
    if (!byId.IsFirePumpNull())
      this.dtpFirePump.Value = (object) byId.FirePump;
    if (!byId.IsFocusAccountNull())
      ((UltraToggleEditorBase) this.chkFocusAccount).Checked = byId.FocusAccount;
    if (!byId.IsCriticalAccountNull())
      ((UltraToggleEditorBase) this.chkCriticalAccount).Checked = byId.CriticalAccount;
    if (!byId.IsLastAssessmentDateNull())
      this.dtLastAssessmentDate.Value = (object) byId.LastAssessmentDate;
    if (!byId.IsInspectionTypeIDNull())
      this.cboAdminInspectionTypes.Value = (object) byId.InspectionTypeID;
    this.OnRecordChange(ID);
  }

  private int VisibleRowCount()
  {
    int num = 0;
    foreach (UltraGridRow row in ((UltraGridBase) this.ugLocations).Rows)
    {
      if (!row.IsFilteredOut)
        ++num;
    }
    return num;
  }

  private int VisibleFollowupRowCount()
  {
    int num = 0;
    foreach (UltraGridRow row in ((UltraGridBase) this.ugLocations).Rows)
    {
      if (!row.IsFilteredOut && row.Cells["FollowUp"].Value != null && row.Cells["FollowUp"].Value != DBNull.Value && Conversions.ToBoolean(row.Cells["FollowUp"].Value))
        ++num;
    }
    return num;
  }

  private void btnFollowUp_Click(object sender, EventArgs e)
  {
    DateTime dateTime;
    ref DateTime local = ref dateTime;
    DateTime now = DateTime.Now;
    int year = now.Year;
    now = DateTime.Now;
    int month = now.Month;
    now = DateTime.Now;
    int day = now.Day;
    local = new DateTime(year, month, day);
    if (MessageBox.Show($"You are about To change the follow-up Date Of {this.VisibleFollowupRowCount()} row(s) To {dateTime.ToShortDateString()}" + $"{Environment.NewLine}{Environment.NewLine}Do you wish To Continue?", "Continue Follow-up?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
      return;
    Guid userGuid = CurrentUser.Instance.UserGUID;
    string idString = string.Empty;
    foreach (UltraGridRow row in ((UltraGridBase) this.ugLocations).Rows)
    {
      if (!row.IsFilteredOut && row.Cells["FollowUp"].Value != null && row.Cells["FollowUp"].Value != DBNull.Value && Conversions.ToBoolean(row.Cells["FollowUp"].Value))
      {
        Decimal num = Conversions.ToDecimal(row.Cells["ID"].Value);
        int integer1 = Conversions.ToInteger(row.Cells["LocationID"].Value);
        int integer2 = Conversions.ToInteger(row.Cells["ControlNo"].Value);
        string str = "Followed up with inspection company. " + $"{Environment.NewLine}Follow-up Date changed from {RuntimeHelpers.GetObjectValue(row.Cells["FollowupDate"].Value)} to {dateTime.ToShortDateString()}";
        DefaultDatabase.ExecuteNonQuery(CommandType.Text, "UPDATE tblAdminInspectionRequests Set FollowupDate = @FD WHERE ID = @ID", new object[4]
        {
          (object) "@FD",
          (object) DateTime.Now,
          (object) "@ID",
          (object) Conversions.ToInteger(row.Cells["ID"].Value)
        });
        DefaultDatabase.ExecuteNonQuery("LogAdminInspInfo", new object[10]
        {
          (object) "@AdminInspID",
          (object) num,
          (object) "@LocationID",
          (object) integer1,
          (object) "@CurrentUser",
          (object) userGuid,
          (object) "@ControlNo",
          (object) integer2,
          (object) "@Action",
          (object) str
        });
        row.Cells["FollowupDate"].Value = (object) dateTime;
        idString = $"{idString}{row.Cells["ID"].Value.ToString()},";
      }
    }
    try
    {
      this.Cursor = MgaCursors.WaitCursor;
      string hiddenColumns = string.Empty;
      bool flag = false;
      using (FormReportColumnChooser reportColumnChooser = new FormReportColumnChooser())
      {
        int num = (int) reportColumnChooser.ShowDialog();
        if (reportColumnChooser.ButtonClick)
        {
          flag = true;
          hiddenColumns = reportColumnChooser.HiddenColumns;
        }
      }
      if (!flag)
        return;
      using (AdminInspGenericReport report = new AdminInspGenericReport(idString, hiddenColumns))
      {
        ReportingTraceListener.RunCannedReportAndLogSqlDetails((SectionReport) report);
        new frmPrint((SectionReport) report).Show();
      }
    }
    finally
    {
      this.Cursor = MgaCursors.Default;
    }
  }

  private void chkReceived_CheckedChanged(object sender, EventArgs e)
  {
    if (((UltraToggleEditorBase) this.chkReceived).Checked)
      this.dtpReceivedDate.Value = (object) DateTime.Now;
    else
      this.dtpReceivedDate.Value = (object) DBNull.Value;
  }

  private void _hlkControlNo_Opening(object sender, CancelEventArgs e)
  {
    int integer = Conversions.ToInteger(((UltraGridBase) this.ugLocations).ActiveRow.Cells["ControlNo"].Value);
    if (!DefaultDatabase.ExecuteScalar<bool>("ValidateUserRightControlNo", new object[4]
    {
      (object) "@ControlNo",
      (object) integer,
      (object) "@UserGuid",
      (object) CurrentUser.Instance.UserGUID
    }))
    {
      int num = (int) MessageBox.Show($"Control # {integer.ToString()} does not exist.", "Control # Not Exist", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    else
    {
      Quote quote = Quote.FromControlNo(integer);
      if (!quote.IsQuickQuote)
        FormSettings.ShowForm(typeof (frmPolicyDetail), (object) integer);
      else
        FormSettings.ShowForm(typeof (frmQuoteEdit), (object) quote.QuoteGuid, (object) quote.SubmissionGroupGuid);
    }
  }

  private void lnkResetAllFilter_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    this.dvSource.RowFilter = string.Empty;
    ((UltraGridBase) this.ugLocations).Rows.ColumnFilters.ClearAllFilters();
  }

  private void lnkSelectAllRows_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    this.SetGridRowSelection(true);
  }

  private void lnkDeSelectAll_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    this.SetGridRowSelection(false);
  }

  private void SetGridRowSelection(bool tmpBooleanValue)
  {
    foreach (UltraGridRow row in ((UltraGridBase) this.ugLocations).Rows)
    {
      if (!row.IsFilteredOut)
        row.Cells["FollowUp"].Value = (object) tmpBooleanValue;
    }
  }

  private void txtFilterControlNo_TextChanged(object sender, EventArgs e)
  {
    this.FilterSearch(this.txtFilterControlNo, "ControlNo", "S");
  }

  private void txtFilterPolicyNumber_TextChanged(object sender, EventArgs e)
  {
    this.FilterSearch(this.txtFilterPolicyNumber, "PolicyNumber", "S");
  }

  private void txtFilterAddress_TextChanged(object sender, EventArgs e)
  {
    this.FilterSearch(this.txtFilterAddress, "Address1", "S");
  }

  private void txtFilterName_TextChanged(object sender, EventArgs e)
  {
    this.FilterSearch(this.txtFilterName, "Insured", "S");
  }

  private void FilterSearch(TextBox tb, string columnName, string tmpType)
  {
    if (string.IsNullOrEmpty(tb.Text))
      this.dvSource.RowFilter = string.Empty;
    else if (tmpType.Equals("N") && !Decimal.TryParse(tb.Text, out Decimal _))
      this.dvSource.RowFilter = string.Empty;
    else
      this.dvSource.RowFilter = !tmpType.Equals("S") ? $"{columnName} = {tb.Text}" : $"{columnName} LIKE '%{tb.Text}%'";
  }

  private void lnkGridReport_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    string hiddenColumns = string.Empty;
    bool flag = false;
    FormReportColumnChooser reportColumnChooser = (FormReportColumnChooser) null;
    try
    {
      reportColumnChooser = new FormReportColumnChooser();
      int num = (int) reportColumnChooser.ShowDialog();
      if (reportColumnChooser.ButtonClick)
      {
        flag = true;
        hiddenColumns = reportColumnChooser.HiddenColumns;
      }
    }
    finally
    {
      reportColumnChooser?.Dispose();
    }
    if (!flag)
      return;
    string idString = string.Empty;
    foreach (UltraGridRow row in ((UltraGridBase) this.ugLocations).Rows)
    {
      if (!row.IsFilteredOut)
        idString = $"{idString}{row.Cells["ID"].Value.ToString()},";
    }
    try
    {
      this.Cursor = MgaCursors.WaitCursor;
      using (AdminInspGenericReport report = new AdminInspGenericReport(idString, hiddenColumns))
      {
        ReportingTraceListener.RunCannedReportAndLogSqlDetails((SectionReport) report);
        new frmPrint((SectionReport) report).Show();
      }
    }
    finally
    {
      this.Cursor = MgaCursors.Default;
    }
  }

  private void lnkLogInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    if (((UltraGridBase) this.ugLocations).ActiveRow == null)
    {
      int num = (int) MessageBox.Show("Please select an active row in the grid.", "No Row Selected", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
    else
    {
      int integer1 = Conversions.ToInteger(((UltraGridBase) this.ugLocations).ActiveRow.Cells["ControlNo"].Value);
      int integer2 = Conversions.ToInteger(((UltraGridBase) this.ugLocations).ActiveRow.Cells["LocationID"].Value);
      int integer3 = Conversions.ToInteger(((UltraGridBase) this.ugLocations).ActiveRow.Cells["ID"].Value);
      FormSettings.ShowForm(typeof (FormInspectionLogging), (object) integer2, (object) integer1, (object) integer3);
    }
  }

  private void LogInspectionInfo(UltraGridRow gridRow)
  {
    List<string> stringList = new List<string>()
    {
      "OrderDate",
      "DropDeadDate",
      "FollowupDate",
      "ReceivedDate",
      "Received",
      "RevisedContactInfo",
      "InspectionContact",
      "InspectionCompanyID",
      "InspectionContactPhone",
      "InspectionStatus",
      "Closed",
      "ClosedDate",
      "CriticalOutstanding",
      "CriticalWaived",
      "CriticalComplete",
      "CriticalTotal",
      "NonCriticalOutstanding",
      "NonCriticalWaived",
      "NonCriticalComplete",
      "NonCriticalTotal",
      "RecStatusID",
      "RecSent",
      "RecsFollowUp",
      "RecsCompleted"
    };
    Decimal ID = Conversions.ToDecimal(gridRow.Cells["ID"].Value);
    dsAdminInspReq.tblAdminInspectionRequestsRow byId = this.ds.tblAdminInspectionRequests.FindByID(ID);
    int integer1 = Conversions.ToInteger(gridRow.Cells["LocationID"].Value);
    int integer2 = Conversions.ToInteger(gridRow.Cells["ControlNo"].Value);
    Guid userGuid = CurrentUser.Instance.UserGUID;
    string empty1 = string.Empty;
    if (gridRow.Cells["LocationNumber"].Value != null && gridRow.Cells["LocationNumber"].Value != DBNull.Value)
      empty1 = gridRow.Cells["LocationNumber"].Value.ToString();
    try
    {
      foreach (DataColumn column in (InternalDataCollectionBase) this.ds.tblAdminInspectionRequests.Columns)
      {
        if (stringList.Contains(column.ColumnName))
        {
          string str1 = string.Empty;
          string str2 = string.Empty;
          string empty2 = string.Empty;
          if (byId != null && byId[column, DataRowVersion.Original] != DBNull.Value)
            str2 = byId[column, DataRowVersion.Original].ToString();
          string columnName = column.ColumnName;
          // ISSUE: reference to a compiler-generated method
          switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(columnName))
          {
            case 152904649:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(columnName, "RevisedContactInfo", false) == 0)
              {
                str1 = ((UltraToggleEditorBase) this.chkRevisedContactInfo).Checked.ToString();
                break;
              }
              break;
            case 338055431:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(columnName, "InspectionCompanyID", false) == 0 && this.cboInspectionCompany.Value != null && this.cboInspectionCompany.Value != DBNull.Value)
              {
                str1 = this.cboInspectionCompany.Text;
                if (!str2.Equals(string.Empty))
                {
                  str2 = this.ds.tblFin_ExpensePayees.FindByPayeeID(Conversions.ToInteger(str2)).PayeeName;
                  break;
                }
                break;
              }
              break;
            case 472419922:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(columnName, "CriticalWaived", false) == 0 && !string.IsNullOrEmpty(this.txtCriticalWaived.Text))
              {
                str1 = this.txtCriticalWaived.Text;
                break;
              }
              break;
            case 507135791:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(columnName, "CriticalComplete", false) == 0 && !string.IsNullOrEmpty(this.txtCriticalComplete.Text))
              {
                str1 = this.txtCriticalComplete.Text;
                break;
              }
              break;
            case 521701617:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(columnName, "FollowupDate", false) == 0 && this.dtpFollowupDate.Value != null && this.dtpFollowupDate.Value != DBNull.Value)
              {
                str1 = this.dtpFollowupDate.Value.ToString();
                break;
              }
              break;
            case 684217957:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(columnName, "InspectionContact", false) == 0 && !string.IsNullOrEmpty(this.txtInspectionContact.Text))
              {
                str1 = this.txtInspectionContact.Text;
                break;
              }
              break;
            case 716118831:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(columnName, "InspectionContactPhone", false) == 0 && !string.IsNullOrEmpty(this.txtContactPhone.Text))
              {
                str1 = this.txtContactPhone.Text;
                break;
              }
              break;
            case 790613539:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(columnName, "RecsCompleted", false) == 0 && this.dtpRecsCompleted.Value != null && this.dtpRecsCompleted.Value != DBNull.Value)
              {
                str1 = this.dtpRecsCompleted.Value.ToString();
                break;
              }
              break;
            case 838978277:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(columnName, "Closed", false) == 0)
              {
                str1 = ((UltraToggleEditorBase) this.chkClosed).Checked.ToString();
                break;
              }
              break;
            case 1077633573:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(columnName, "InspectionStatus", false) == 0 && this.cboInspectionStatus.Value != null && this.cboInspectionStatus.Value != DBNull.Value)
              {
                str1 = this.cboInspectionStatus.Text;
                if (!str2.Equals(string.Empty))
                {
                  str2 = this.ds.lstAdminInspectionStatus.FindByID(Conversions.ToInteger(str2)).InspectionStatus;
                  break;
                }
                break;
              }
              break;
            case 1300934063:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(columnName, "NonCriticalWaived", false) == 0 && !string.IsNullOrEmpty(this.txtNonCriticalWaived.Text))
              {
                str1 = this.txtNonCriticalWaived.Text;
                break;
              }
              break;
            case 1445049386:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(columnName, "NonCriticalComplete", false) == 0 && !string.IsNullOrEmpty(this.txtNonCriticalComplete.Text))
              {
                str1 = this.txtNonCriticalComplete.Text;
                break;
              }
              break;
            case 1559762898:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(columnName, "Received", false) == 0)
              {
                str1 = ((UltraToggleEditorBase) this.chkReceived).Checked.ToString();
                break;
              }
              break;
            case 1762409811:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(columnName, "OrderDate", false) == 0 && this.dtpOrderDate.Value != null && this.dtpOrderDate.Value != DBNull.Value)
              {
                str1 = this.dtpOrderDate.Value.ToString();
                break;
              }
              break;
            case 1829351854:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(columnName, "RecsFollowUp", false) == 0 && this.dtpRecsFollowUp.Value != null && this.dtpRecsFollowUp.Value != DBNull.Value)
              {
                str1 = this.dtpRecsFollowUp.Value.ToString();
                break;
              }
              break;
            case 1853471391:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(columnName, "NonCriticalOutstanding", false) == 0 && !string.IsNullOrEmpty(this.txtNonCriticalOutstanding.Text))
              {
                str1 = this.txtNonCriticalOutstanding.Text;
                break;
              }
              break;
            case 2461235206:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(columnName, "DropDeadDate", false) == 0 && this.dtpDropDeadDate.Value != null && this.dtpDropDeadDate.Value != DBNull.Value)
              {
                str1 = this.dtpDropDeadDate.Value.ToString();
                break;
              }
              break;
            case 2724295340:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(columnName, "CriticalOutstanding", false) == 0 && !string.IsNullOrEmpty(this.txtCriticalOutstanding.Text))
              {
                str1 = this.txtCriticalOutstanding.Text;
                break;
              }
              break;
            case 3049118041:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(columnName, "ClosedDate", false) == 0 && this.dtpClosedDate.Value != null && this.dtpClosedDate.Value != DBNull.Value)
              {
                str1 = this.dtpClosedDate.Value.ToString();
                break;
              }
              break;
            case 3169677990:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(columnName, "RecStatusID", false) == 0 && this.cboRecStatus.Value != null && this.cboRecStatus.Value != DBNull.Value)
              {
                str1 = this.cboRecStatus.Text;
                if (!str2.Equals(string.Empty))
                {
                  str2 = this.ds.lstInspectionsAdminRecStatus.FindByID(Conversions.ToInteger(str2)).RecStatus;
                  break;
                }
                break;
              }
              break;
            case 3219680763:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(columnName, "RecSent", false) == 0 && this.dtpRecsSent.Value != null && this.dtpRecsSent.Value != DBNull.Value)
              {
                str1 = this.dtpRecsSent.Value.ToString();
                break;
              }
              break;
            case 3430946565:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(columnName, "NonCriticalTotal", false) == 0 && !string.IsNullOrEmpty(this.txtNonCriticalTotal.Text))
              {
                str1 = this.txtNonCriticalTotal.Text;
                break;
              }
              break;
            case 3467256850:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(columnName, "CriticalTotal", false) == 0 && !string.IsNullOrEmpty(this.txtCriticalTotal.Text))
              {
                str1 = this.txtCriticalTotal.Text;
                break;
              }
              break;
            case 3586151510:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(columnName, "ReceivedDate", false) == 0 && this.dtpReceivedDate.Value != null && this.dtpReceivedDate.Value != DBNull.Value)
              {
                str1 = this.dtpReceivedDate.Value.ToString();
                break;
              }
              break;
          }
          if (!str1.Equals(str2))
          {
            string str3 = empty1.Equals(string.Empty) ? empty2 + "Change " : "Update location # " + empty1 + ". Change ";
            if (str2.Equals(string.Empty))
              str2 = "<NULL>";
            if (str1.Equals(string.Empty))
              str1 = "<NULL>";
            string str4 = $"{str3}{column.ColumnName} from {str2} to {str1}.";
            DefaultDatabase.ExecuteNonQuery("LogAdminInspInfo", new object[10]
            {
              (object) "@AdminInspID",
              (object) ID,
              (object) "@LocationID",
              (object) integer1,
              (object) "@CurrentUser",
              (object) userGuid,
              (object) "@ControlNo",
              (object) integer2,
              (object) "@Action",
              (object) str4
            });
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

  private void chkClosed_CheckedChanged(object sender, EventArgs e)
  {
    if (((UltraToggleEditorBase) this.chkClosed).Checked)
      this.dtpClosedDate.Value = (object) DateTime.Now;
    else
      this.dtpClosedDate.Value = (object) DBNull.Value;
  }

  private void lblShowRecords_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    ((Control) this.panelSearch).Visible = true;
    this.lblShowRecords.Enabled = false;
    if (this.lblShowRecords.Text.Equals("Show CLOSED records only"))
    {
      this.lblShowRecords.Text = "Show OPENED records only";
      this.FillData(true);
    }
    else
    {
      this.lblShowRecords.Text = "Show CLOSED records only";
      this.FillData(false);
    }
  }

  protected override void Dispose(bool disposing)
  {
    try
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      if (this._hlkControlNo != null)
        ((DisposableObject) this._hlkControlNo).Dispose();
      if (this.lnkLogInfo != null)
        this.lnkLogInfo.Dispose();
      if (this.lblShowRecords != null)
        this.lblShowRecords.Dispose();
      if (this.spinner != null)
        this.spinner.Dispose();
      if (this.panelSearch == null)
        return;
      ((Component) this.panelSearch).Dispose();
    }
    finally
    {
      base.Dispose(disposing);
    }
  }

  protected virtual void OnRecordChange(Decimal ID)
  {
  }

  private void btnUndo_Click(object sender, EventArgs e)
  {
    this._clickedNew = false;
    this.MakeControlsReadOnly(true);
    ((Control) this.btnNew).Enabled = true;
    ((Control) this.ugLocations).Enabled = true;
    this.ugLocations_AfterRowActivate((object) null, EventArgs.Empty);
  }

  private void btnNew_Click(object sender, EventArgs e)
  {
    this._clickedNew = true;
    this.txtLocationNumber.Tag = (object) null;
    ((Control) this.ugLocations).Enabled = false;
    this.MakeControlsReadOnly(false);
    this.ClearControls();
    ((Control) this.btnNew).Enabled = false;
    if (this._inspectTypeDefault == 0)
      return;
    this.cboAdminInspectionTypes.Value = (object) this._inspectTypeDefault;
  }

  private void MakeControlsReadOnly(bool rOnly)
  {
    this.txtControlNo.ReadOnly = rOnly;
    this.txtLocationNumber.ReadOnly = rOnly;
    ((EditorButtonControlBase) this.dtpEffectiveDate).ReadOnly = rOnly;
    ((EditorButtonControlBase) this.dtpOrderDate).ReadOnly = rOnly;
    ((EditorButtonControlBase) this.dtpDropDeadDate).ReadOnly = rOnly;
    this.lnkSearchLoc.Visible = !rOnly;
    this.lnkSelectUser.Visible = !rOnly;
    this.lnkPolicyInfo.Visible = !rOnly;
  }

  protected virtual bool ValidateOnClickNew()
  {
    bool flag1;
    if (!this.ClickedNew)
      flag1 = true;
    else if (this.ValidaControlNo() == -1)
    {
      flag1 = false;
    }
    else
    {
      this.err.SetError((Control) this.txtControlNo, string.Empty);
      this.err.SetError((Control) this.txtPolicyNo, string.Empty);
      this.err.SetError((Control) this.txtInsured, string.Empty);
      this.err.SetError((Control) this.txtAddress, string.Empty);
      this.err.SetError((Control) this.txtUnderwriter, string.Empty);
      bool flag2 = true;
      if (string.IsNullOrEmpty(this.txtControlNo.Text))
      {
        flag2 = false;
        this.err.SetError((Control) this.txtControlNo, "Enter a value.");
      }
      if (string.IsNullOrEmpty(this.txtPolicyNo.Text))
      {
        flag2 = false;
        this.err.SetError((Control) this.txtPolicyNo, "Enter a value.");
      }
      if (string.IsNullOrEmpty(this.txtInsured.Text))
      {
        flag2 = false;
        this.err.SetError((Control) this.txtInsured, "Enter a value.");
      }
      if (string.IsNullOrEmpty(this.txtLocationNumber.Text))
      {
        flag2 = false;
        this.err.SetError((Control) this.txtLocationNumber, "Enter a value.");
      }
      if (string.IsNullOrEmpty(this.cboInspectionCompany.Text))
      {
        flag2 = false;
        this.err.SetError((Control) this.cboInspectionCompany, "Enter a value.");
      }
      if (string.IsNullOrEmpty(this.txtAddress.Text))
      {
        flag2 = false;
        this.err.SetError((Control) this.txtAddress, "Enter a value.");
      }
      if (string.IsNullOrEmpty(this.txtUnderwriter.Text))
      {
        flag2 = false;
        this.err.SetError((Control) this.txtUnderwriter, "Enter a value.");
      }
      flag1 = flag2;
    }
    return flag1;
  }

  private void lnkSearchLoc_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    int controlNo = this.ValidaControlNo();
    if (controlNo == -1)
      return;
    Quote quote = Quote.FromControlNo(controlNo);
    Guid lineguid = new Guid("69C3C52A-7BDC-4A64-A1EF-C788781DDF98");
    bool usingNetRate = quote.UsingNetRate;
    if (!usingNetRate)
      lineguid = quote.LineGuid;
    FormChooseLocation formChooseLocation = (FormChooseLocation) null;
    try
    {
      formChooseLocation = new FormChooseLocation(quote.QuoteGuid, lineguid, usingNetRate);
      int num = (int) formChooseLocation.ShowDialog();
      if (formChooseLocation.MakeSelection)
      {
        this.txtLocationNumber.Tag = (object) formChooseLocation.LocationID;
        this.txtLocationNumber.Text = formChooseLocation.Loc;
        this.txtAddress1.Text = formChooseLocation.Address;
        this.txtAddress2.Text = formChooseLocation.Address2;
        this.txtCity.Text = formChooseLocation.City;
        this.txtState.Text = formChooseLocation.State;
        this.txtZip.Text = formChooseLocation.ZipCode;
        this.txtAddress.Text = $"{this.txtAddress1.Text} {Environment.NewLine}{this.txtCity.Text}, {this.txtState.Text} {this.txtZip.Text}";
      }
      else
      {
        this.txtLocationNumber.Tag = (object) null;
        this.txtLocationNumber.Text = string.Empty;
        this.txtAddress1.Text = string.Empty;
        this.txtAddress2.Text = string.Empty;
        this.txtCity.Text = string.Empty;
        this.txtState.Text = string.Empty;
        this.txtZip.Text = string.Empty;
        this.txtAddress.Text = string.Empty;
      }
    }
    finally
    {
      formChooseLocation?.Dispose();
    }
  }

  private int ValidaControlNo()
  {
    int num1;
    if (string.IsNullOrEmpty(this.txtControlNo.Text))
    {
      int num2 = (int) MessageBox.Show("Please enter a valid control #.", "Invalid Control #", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      num1 = -1;
    }
    else
    {
      int result;
      if (!int.TryParse(this.txtControlNo.Text, out result))
      {
        int num3 = (int) MessageBox.Show("Control # must be numeric.", "Invalid Control #", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        num1 = -1;
      }
      else if (Utility.IsNull(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT TOP 1 QuoteID FROM tblQuotes WITH (NOLOCK) WHERE ControlNo = @cNo", new object[2]
      {
        (object) "@cNo",
        (object) result
      })))))
      {
        int num4 = (int) MessageBox.Show("Control # does not exist.", "Invalid Control #", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        num1 = -1;
      }
      else
        num1 = Conversions.ToInteger(this.txtControlNo.Text);
    }
    return num1;
  }

  private void lnkPolicyInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    int controlNo = this.ValidaControlNo();
    if (controlNo == -1)
      return;
    Quote quote = Quote.FromControlNo(controlNo);
    if (quote.HasPolicyNumber)
      this.txtPolicyNo.Text = quote.PolicyNumber;
    this.txtInsured.Text = quote.InsuredPolicyName;
    this.txtUnderwriter.Text = quote.Underwriter.Name_LastFirst;
    this.txtPolicyType.Text = DefaultDatabase.ExecuteScalar<string>(CommandType.Text, "SELECT Description FROM lstPolicyTypes WITH (NOLOCK) WHERE PolicyTypeID = @ID", new object[2]
    {
      (object) "@ID",
      (object) quote.PolicyTypeID
    });
    this.dtpEffectiveDate.Value = (object) quote.EffectiveDate;
    this.dtpDropDeadDate.Value = (object) quote.EffectiveDate.AddDays(55.0);
  }

  private Decimal InsertRecord(
    int locationID,
    object objInspStatus,
    object objClosedDate,
    object objRecStatusID,
    object objCPR,
    object objMap,
    object objSprinklerTest,
    object objThermo,
    object objFirePump,
    object objLastAssessmentDate,
    object objInspTypeID)
  {
    object obj = (object) null;
    if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(this.txtOrderedBy.Tag)))
      obj = RuntimeHelpers.GetObjectValue(this.txtOrderedBy.Tag);
    Decimal num = DefaultDatabase.ExecuteScalar<Decimal>("SaveAdminInspectionDataInsert", new object[104]
    {
      (object) "@LocationID",
      (object) locationID,
      (object) "@ControlNo",
      (object) this.txtControlNo.Text,
      (object) "@PolicyNumber",
      (object) this.txtPolicyNo.Text,
      (object) "@Insured",
      (object) this.txtInsured.Text,
      (object) "@EffectiveDate",
      this.dtpEffectiveDate.Value,
      (object) "@LocationNumber ",
      (object) this.txtLocationNumber.Text,
      (object) "@LocationAddress",
      (object) this.txtAddress.Text,
      (object) "@Address1",
      (object) this.txtAddress1.Text,
      (object) "@Address2",
      (object) this.txtAddress2.Text,
      (object) "@City",
      (object) this.txtCity.Text,
      (object) "@State",
      (object) this.txtState.Text,
      (object) "@Zip",
      (object) this.txtZip.Text,
      (object) "@OrderBy",
      obj,
      (object) "@OrderDate",
      this.dtpOrderDate.Value,
      (object) "@InspectionType",
      (object) this.txtInspType.Text,
      (object) "@PolicyType",
      (object) this.txtPolicyType.Text,
      (object) "@DropDeadDate",
      this.dtpDropDeadDate.Value,
      (object) "@FollowupDate",
      this.dtpFollowupDate.Value,
      (object) "@ReceivedDate",
      this.dtpReceivedDate.Value,
      (object) "@Received",
      (object) ((UltraToggleEditorBase) this.chkReceived).Checked,
      (object) "@RevisedContactInfo",
      (object) ((UltraToggleEditorBase) this.chkRevisedContactInfo).Checked,
      (object) "@InspectionContact",
      (object) this.txtInspectionContact.Text,
      (object) "@InspectionContactPhone",
      (object) this.txtContactPhone.Text,
      (object) "@InspectionCompanyID",
      this.cboInspectionCompany.Value,
      (object) "@InspectionStatus",
      objInspStatus,
      (object) "@Closed",
      (object) ((UltraToggleEditorBase) this.chkClosed).Checked,
      (object) "@ClosedDate",
      objClosedDate,
      (object) "@CriticalOutstanding",
      (object) this.txtCriticalOutstanding.Text,
      (object) "@CriticalWaived",
      (object) this.txtCriticalWaived.Text,
      (object) "@CriticalComplete",
      (object) this.txtCriticalComplete.Text,
      (object) "@CriticalTotal",
      (object) this.txtCriticalTotal.Text,
      (object) "@NonCriticalOutstanding",
      (object) this.txtNonCriticalOutstanding.Text,
      (object) "@NonCriticalWaived",
      (object) this.txtNonCriticalWaived.Text,
      (object) "@NonCriticalComplete",
      (object) this.txtNonCriticalComplete.Text,
      (object) "@NonCriticalTotal",
      (object) this.txtNonCriticalTotal.Text,
      (object) "@RecStatusID",
      objRecStatusID,
      (object) "@RecSent",
      this.dtpRecsSent.Value,
      (object) "@RecsFollowUp",
      this.dtpRecsFollowUp.Value,
      (object) "@RecsCompleted",
      this.dtpRecsCompleted.Value,
      (object) "@Notes",
      (object) this.txtNotes.Text,
      (object) "@RecsReceived",
      (object) ((UltraToggleEditorBase) this.chkRecsReceived).Checked,
      (object) "@CPR",
      objCPR,
      (object) "@Map",
      objMap,
      (object) "@SprinklerTest",
      objSprinklerTest,
      (object) "@Thermo",
      objThermo,
      (object) "@FirePump",
      objFirePump,
      (object) "@FocusAccount",
      (object) ((UltraToggleEditorBase) this.chkFocusAccount).Checked,
      (object) "@CriticalAccount",
      (object) ((UltraToggleEditorBase) this.chkCriticalAccount).Checked,
      (object) "@OnEndorsement",
      (object) ((UltraToggleEditorBase) this.chkOnEndorsement).Checked,
      (object) "@Roof",
      (object) ((UltraToggleEditorBase) this.chkRoof).Checked,
      (object) "@Underwriter",
      (object) this.txtUnderwriter.Text,
      (object) "@InspectionTypeID",
      objInspTypeID
    });
    dsAdminInspReq.tblAdminInspectionRequestsRow row = this.ds.tblAdminInspectionRequests.NewtblAdminInspectionRequestsRow();
    row.ID = num;
    row.ControlNo = this.txtControlNo.Text;
    if (!string.IsNullOrEmpty(this.txtPolicyNo.Text))
      row.PolicyNumber = this.txtPolicyNo.Text;
    if (!string.IsNullOrEmpty(this.txtInsured.Text))
      row.Insured = this.txtInsured.Text;
    Quote quote = Quote.FromControlNo(Conversions.ToInteger(row.ControlNo));
    row.LOB = quote.LineName;
    row.LocationID = locationID;
    if (!string.IsNullOrEmpty(this.txtLocationNumber.Text))
      row.LocationNumber = this.txtLocationNumber.Text;
    row.LocationAddress = this.txtAddress.Text;
    row.Address1 = this.txtAddress1.Text;
    row.Address2 = this.txtAddress2.Text;
    row.City = this.txtCity.Text;
    row.State = this.txtState.Text;
    row.Zip = this.txtZip.Text;
    if (!string.IsNullOrEmpty(this.cboInspectionCompany.Text))
      row.InspectionCompanyID = Conversions.ToInteger(this.cboInspectionCompany.Value);
    row.InspectionContact = this.txtInspectionContact.Text;
    row.InspectionContactPhone = this.txtContactPhone.Text;
    row.Underwriter = this.txtUnderwriter.Text;
    if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(this.dtpEffectiveDate.Value)))
      row.EffectiveDate = Conversions.ToDate(this.dtpEffectiveDate.Value);
    if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(this.dtpOrderDate.Value)))
      row.OrderDate = Conversions.ToDate(this.dtpOrderDate.Value);
    if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(this.dtpDropDeadDate.Value)))
      row.DropDeadDate = Conversions.ToDate(this.dtpDropDeadDate.Value);
    if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(this.dtpFollowupDate.Value)))
      row.FollowupDate = Conversions.ToDate(this.dtpFollowupDate.Value);
    if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(this.dtpReceivedDate.Value)))
      row.ReceivedDate = Conversions.ToDate(this.dtpReceivedDate.Value);
    row.Received = ((UltraToggleEditorBase) this.chkReceived).Checked;
    if (!string.IsNullOrEmpty(this.cboInspectionStatus.Text))
      row.InspectionStatus = Conversions.ToInteger(this.cboInspectionStatus.Value);
    row.OrderedBy = this.txtOrderedBy.Text;
    row.InspType = this.txtInspType.Text;
    row.PolicyType = this.txtPolicyType.Text;
    row.Closed = ((UltraToggleEditorBase) this.chkClosed).Checked;
    if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(this.dtpClosedDate.Value)))
      row.ClosedDate = Conversions.ToDate(this.dtpClosedDate.Value);
    row.Notes = this.txtNotes.Text;
    row.OnEndorsement = ((UltraToggleEditorBase) this.chkOnEndorsement).Checked;
    row.Roof = ((UltraToggleEditorBase) this.chkRoof).Checked;
    row.RevisedContactInfo = ((UltraToggleEditorBase) this.chkRevisedContactInfo).Checked;
    row.Received = ((UltraToggleEditorBase) this.chkReceived).Checked;
    row.RecsReceived = ((UltraToggleEditorBase) this.chkRecsReceived).Checked;
    this.ds.tblAdminInspectionRequests.AddtblAdminInspectionRequestsRow(row);
    return num;
  }

  private void lnkSelectUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    frmEntitySearch frmEntitySearch = new frmEntitySearch(frmEntitySearch.SearchEntityTypes.ShowUsers);
    try
    {
      if (frmEntitySearch.ShowDialog() == DialogResult.OK)
      {
        this.txtOrderedBy.Tag = (object) frmEntitySearch.EntityGuid;
        this.txtOrderedBy.Text = frmEntitySearch.EntityName;
      }
      else
      {
        this.txtOrderedBy.Tag = (object) null;
        this.txtOrderedBy.Text = string.Empty;
      }
    }
    finally
    {
      frmEntitySearch.Dispose();
    }
  }

  private void lnkPolicyInfo_MouseHover(object sender, EventArgs e)
  {
    this.ttInspAdminReq.SetToolTip((Control) this.lnkPolicyInfo, "Populate policy info.");
  }

  private void lnkSearchLoc_MouseHover(object sender, EventArgs e)
  {
    this.ttInspAdminReq.SetToolTip((Control) this.lnkSearchLoc, "Search and populate location info.");
  }

  private void lnkSelectUser_MouseHover(object sender, EventArgs e)
  {
    this.ttInspAdminReq.SetToolTip((Control) this.lnkSelectUser, "Search and populate user info.");
  }

  private void cboInspectionCompany_BeforeDropDown(object sender, CancelEventArgs e)
  {
    if (!this.ClickedNew)
      return;
    foreach (UltraGridRow row in ((UltraGridBase) this.cboInspectionCompany).Rows)
      row.Hidden = this._hiddenInspectioncompanies.Contains(Conversions.ToInteger(row.Cells["PayeeID"].Value));
  }

  private void cboAdminInspectionTypes_ValueChanged(object sender, EventArgs e)
  {
    if (!this._loadComplete || !this._allowEdits || this._inspectTypeDefault == 0)
      return;
    this.txtInspType.Text = this.cboAdminInspectionTypes.Text;
  }

  private delegate void ThreadCompleteHandler(object sender, EventArgs e);

  private delegate void ThreadProgressBarHandler(string txt);
}
