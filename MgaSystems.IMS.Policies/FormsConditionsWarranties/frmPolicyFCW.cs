// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.FormsConditionsWarranties.frmPolicyFCW
// Assembly: MgaSystems.IMS.Policies, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 2FF2C709-F7BF-41DA-82BD-FF6319CA235D
// Assembly location: C:\Users\muthu\Downloads\MgaSystems.IMS.Policies.dll

using Infragistics.Shared;
using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinProgressBar;
using Infragistics.Win.UltraWinScrollBar;
using Infragistics.Win.UltraWinTabControl;
using Infragistics.Win.UltraWinTabs;
using Infragistics.Win.UltraWinToolbars;
using Infragistics.Win.UltraWinToolTip;
using MGASystems.AsposeFacade.Words;
using MGASystems.BusinessObjects;
using MGASystems.BusinessObjects.Rating;
using MGASystems.Common;
using MGASystems.Common.ErrorHandling;
using MGASystems.Common.Extensions;
using MGASystems.Common.Settings;
using MGASystems.Common.ThreadingFunctions;
using MGASystems.Data;
using MGASystems.IMS.DocumentAutomation;
using MGASystems.IMS.DocumentAutomation.DocumentPreview;
using MGASystems.IMS.DocumentAutomation.TemplateDocuments;
using MGASystems.IMS.NoteDocuments;
using MGASystems.IMS.Policies.Administration;
using MGASystems.IMS.Policies.Clearance.MultiQuotePrinting;
using MGASystems.IMS.Policies.Rating;
using MGASystems.IMS.Security;
using MGASystems.Tools;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Xml.Linq;

#nullable disable
namespace MGASystems.IMS.Policies.FormsConditionsWarranties;

[DesignerGenerated]
[SecureResource("{7C98DC14-C1A2-475e-B6BE-4533DFFCBBE2}", "Allow Forms, Conditions and Warranties Update When Policy Issued", "Allows a user to update forms, conditions and warranties when a policy is issued.", "Policy")]
[SecureResource("{8459B5E5-69B6-489b-89E3-1D57042A92A8}", "Allow Removal of Auto-Applied Forms.", "Allow Auto-Selected Forms to be Removed.", "Policies")]
[SecureResource("{950155CA-805C-45c5-A43A-FA65131EA8C8}", "Allow Access to Forms, Conditions and Warranties Screen", "Allows users to view Forms, Conditions and Warranties Screen.", "Policies")]
[SecureResource("{D96148F1-0DAC-4f2e-B117-9B11245F398E}", "Allow removal of Mandatory Forms", "Allows users to remove Mandatory forms.", "Policies")]
[SecureResource("{A4369441-0F7F-4406-BADC-88CCAFDA9AE2}", "Allow Forms, Conditions, Warranties Records to be Reset", "Allows users to reset the Forms/Conditions/Warranties record associated with a policy.", "Policies")]
[SecureResource("{D5C89BF2-26D9-4BD0-A727-6EC3B2D72812}", "Allow Forms, Conditions, Warranties Rules to be Cleared", "Allows users to clear the underlying rule associated with an applied Forms/Conditions/Warranties record.", "Policies")]
[SecureResource("{25F97952-2D4A-49B1-A335-A5381BFA25C2}", "Allow Override of Endorsement Not Required Setting", "Allow user to set endorsement number, even if column disabled due to not requiring a number.", "Policies")]
[Override(typeof (frmPolicyFCW))]
public class frmPolicyFCW : Form
{
  private IContainer components;
  private UltraTabControl ultraTabFCW;
  private UltraTabSharedControlsPage UltraTabSharedControlsPage1;
  private UltraTabPageControl UltraTabPageControl1;
  private UltraTabPageControl UltraTabPageControl2;
  private UltraTabPageControl UltraTabPageControl3;
  private dsPolicyFCW ds;
  private UltraToolbarsDockArea _frmPolicyFCW_Toolbars_Dock_Area_Left;
  private UltraToolbarsDockArea _frmPolicyFCW_Toolbars_Dock_Area_Right;
  private UltraToolbarsDockArea _frmPolicyFCW_Toolbars_Dock_Area_Top;
  private UltraToolbarsDockArea _frmPolicyFCW_Toolbars_Dock_Area_Bottom;
  private Label lblEndorsementInfo;
  private UltraGroupBox panelSaving;
  private UltraProgressBar progress;
  private ToolTip tt;
  private UltraTabPageControl UltraTabPageControl4;
  private UltraTabPageControl UltraTabPageControl5;
  private Label Label12;
  private Label Label11;
  private Label labelInformation;
  private UltraLabel labelLoading;
  private UltraTabPageControl tabAdditionalComments;
  private MGATextBox txtAdditionalComments;
  private DbCommand DbCommand3;
  private UltraProgressBar progressLoading;
  private UltraToolTipManager UltraToolTipManager1;
  private Label labelStatus;
  internal const string AllowFCWUpdateWhenIssued = "{7C98DC14-C1A2-475e-B6BE-4533DFFCBBE2}";
  public const string CanViewFormsConditionsWarrantiesForm = "{950155CA-805C-45c5-A43A-FA65131EA8C8}";
  internal const string AllowRemovalOfSelectedAutoAppliedForm = "{8459B5E5-69B6-489b-89E3-1D57042A92A8}";
  internal const string AllowRemovalOfMandatoryForm = "{D96148F1-0DAC-4f2e-B117-9B11245F398E}";
  internal const string AllowResetOfFCWRecords = "{A4369441-0F7F-4406-BADC-88CCAFDA9AE2}";
  internal const string AllowClearFCWRules = "{D5C89BF2-26D9-4BD0-A727-6EC3B2D72812}";
  internal const string CanSetEndorsementNumberIfNotRequired = "{25F97952-2D4A-49B1-A335-A5381BFA25C2}";
  private readonly Quote _quote;
  private dsPolicyFCW.tblQuoteFormsConditionsWarrantiesDataTable _dataTable;
  private DateTime _lastLoadTime;
  private DataSet _dsNetRateAutoData;
  private MemoryStream _formsGridLayout;
  private MemoryStream _conditionsGridLayout;
  private MemoryStream _warrantiesGridLayout;
  private bool _AllowRemovalOfAutoAppliedForm;
  private readonly Guid _companyLineGuid;
  private bool _AllowRemovalOfMandatoryForm;
  private Dictionary<int, string> _raterConditionalForms;
  private Dictionary<int, string> _raterConditionalConditions;
  private Dictionary<int, IRater> _raterCache;
  private List<(int, int)> _policyRaters;
  private readonly Lazy<bool> _useNewEndorsementNumCheck;
  private readonly Lazy<bool> _allowNonNumericEndorsement;
  private readonly Lazy<bool> _useFcwInclusiveFiltering;
  private readonly Lazy<bool> _allowRaterParentForms;
  private readonly Lazy<bool> _supportVisibilityConditions;
  private readonly Lazy<bool> _disableEndorsementNum;
  private Thread _loadThread;
  private bool _blackBoxMode;
  private StringBuilder statusSB;
  private UltraGrid _toolGrid;

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    Appearance appearance1 = new Appearance();
    UltraGridBand ultraGridBand1 = new UltraGridBand("tblPolicyForms", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("FormID");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("FormName");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("Description");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("EndorsementNum");
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("Applied");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("RequiresEndorsementNumber");
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("FormNumber");
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("ParentFormID");
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("WaivedByUserGuid");
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("AllowDuplicates");
    UltraGridColumn ultraGridColumn11 = new UltraGridColumn("PlacedByCompanyLineID");
    UltraGridColumn ultraGridColumn12 = new UltraGridColumn("LineName");
    UltraGridColumn ultraGridColumn13 = new UltraGridColumn("AddedByUserGuid");
    UltraGridColumn ultraGridColumn14 = new UltraGridColumn("FormCompanyLineGuid");
    UltraGridColumn ultraGridColumn15 = new UltraGridColumn("Mandatory");
    UltraGridColumn ultraGridColumn16 = new UltraGridColumn("Company_FCW_ID");
    UltraGridColumn ultraGridColumn17 = new UltraGridColumn("AssociatedWarrantyID");
    UltraGridColumn ultraGridColumn18 = new UltraGridColumn("AssociatedFormID");
    UltraGridColumn ultraGridColumn19 = new UltraGridColumn("FormType");
    UltraGridColumn ultraGridColumn20 = new UltraGridColumn("EditionDate");
    UltraGridColumn ultraGridColumn21 = new UltraGridColumn("Comments");
    UltraGridColumn ultraGridColumn22 = new UltraGridColumn("PolicyFormComments", -1, (object) null, 0, (SortIndicator) 1, false);
    UltraGridColumn ultraGridColumn23 = new UltraGridColumn("RaterID");
    UltraGridColumn ultraGridColumn24 = new UltraGridColumn("Hidden");
    UltraGridColumn ultraGridColumn25 = new UltraGridColumn("RaterConditionalID");
    UltraGridColumn ultraGridColumn26 = new UltraGridColumn("OncePer");
    UltraGridColumn ultraGridColumn27 = new UltraGridColumn("RequiresEdit");
    UltraGridColumn ultraGridColumn28 = new UltraGridColumn("tblPolicyFormstblQuoteFormsConditionsWarranties");
    UltraGridColumn ultraGridColumn29 = new UltraGridColumn("tblPolicyFormstblWarrantyForms");
    UltraGridBand ultraGridBand2 = new UltraGridBand("tblPolicyFormstblQuoteFormsConditionsWarranties", 0);
    UltraGridColumn ultraGridColumn30 = new UltraGridColumn("Quote_FCW_ID");
    UltraGridColumn ultraGridColumn31 = new UltraGridColumn("QuoteID");
    UltraGridColumn ultraGridColumn32 = new UltraGridColumn("PolicyFormID");
    UltraGridColumn ultraGridColumn33 = new UltraGridColumn("ConditionID");
    UltraGridColumn ultraGridColumn34 = new UltraGridColumn("WarrantyID");
    UltraGridColumn ultraGridColumn35 = new UltraGridColumn("EndorsementNum");
    UltraGridColumn ultraGridColumn36 = new UltraGridColumn("Deleted");
    UltraGridColumn ultraGridColumn37 = new UltraGridColumn("OriginalID");
    UltraGridColumn ultraGridColumn38 = new UltraGridColumn("WaivedByUserGuid");
    UltraGridColumn ultraGridColumn39 = new UltraGridColumn("AllowDuplicates");
    UltraGridColumn ultraGridColumn40 = new UltraGridColumn("AddedByUserGuid");
    UltraGridColumn ultraGridColumn41 = new UltraGridColumn("Mandatory");
    UltraGridColumn ultraGridColumn42 = new UltraGridColumn("Company_FCW_ID");
    UltraGridColumn ultraGridColumn43 = new UltraGridColumn("Added");
    UltraGridColumn ultraGridColumn44 = new UltraGridColumn("PolicyFormComments");
    UltraGridColumn ultraGridColumn45 = new UltraGridColumn("CompanyLineID");
    UltraGridColumn ultraGridColumn46 = new UltraGridColumn("RaterID");
    UltraGridColumn ultraGridColumn47 = new UltraGridColumn("RaterConditionalID");
    UltraGridBand ultraGridBand3 = new UltraGridBand("tblPolicyFormstblWarrantyForms", 0);
    UltraGridColumn ultraGridColumn48 = new UltraGridColumn("WarrantyID");
    UltraGridColumn ultraGridColumn49 = new UltraGridColumn("PolicyFormID");
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    ScrollBarLook scrollBarLook1 = new ScrollBarLook();
    Appearance appearance8 = new Appearance();
    UltraGridBand ultraGridBand4 = new UltraGridBand("tblConditions", -1);
    UltraGridColumn ultraGridColumn50 = new UltraGridColumn("ConditionID");
    UltraGridColumn ultraGridColumn51 = new UltraGridColumn("Condition", -1, (object) null, 0, (SortIndicator) 2, false);
    UltraGridColumn ultraGridColumn52 = new UltraGridColumn("Applied");
    UltraGridColumn ultraGridColumn53 = new UltraGridColumn("Mandatory");
    UltraGridColumn ultraGridColumn54 = new UltraGridColumn("Company_FCW_ID");
    UltraGridColumn ultraGridColumn55 = new UltraGridColumn("WaivedByUserGuid");
    UltraGridColumn ultraGridColumn56 = new UltraGridColumn("AddedByUserGuid");
    UltraGridColumn ultraGridColumn57 = new UltraGridColumn("PlacedByCompanyLineID");
    UltraGridColumn ultraGridColumn58 = new UltraGridColumn("RaterID");
    UltraGridColumn ultraGridColumn59 = new UltraGridColumn("Hidden");
    UltraGridColumn ultraGridColumn60 = new UltraGridColumn("RaterConditionalID");
    UltraGridColumn ultraGridColumn61 = new UltraGridColumn("tblConditionstblQuoteFormsConditionsWarranties");
    UltraGridBand ultraGridBand5 = new UltraGridBand("tblConditionstblQuoteFormsConditionsWarranties", 0);
    UltraGridColumn ultraGridColumn62 = new UltraGridColumn("Quote_FCW_ID");
    UltraGridColumn ultraGridColumn63 = new UltraGridColumn("QuoteID");
    UltraGridColumn ultraGridColumn64 = new UltraGridColumn("PolicyFormID");
    UltraGridColumn ultraGridColumn65 = new UltraGridColumn("ConditionID");
    UltraGridColumn ultraGridColumn66 = new UltraGridColumn("WarrantyID");
    UltraGridColumn ultraGridColumn67 = new UltraGridColumn("EndorsementNum");
    UltraGridColumn ultraGridColumn68 = new UltraGridColumn("Deleted");
    UltraGridColumn ultraGridColumn69 = new UltraGridColumn("OriginalID");
    UltraGridColumn ultraGridColumn70 = new UltraGridColumn("WaivedByUserGuid");
    UltraGridColumn ultraGridColumn71 = new UltraGridColumn("AllowDuplicates");
    UltraGridColumn ultraGridColumn72 = new UltraGridColumn("AddedByUserGuid");
    UltraGridColumn ultraGridColumn73 = new UltraGridColumn("Mandatory");
    UltraGridColumn ultraGridColumn74 = new UltraGridColumn("Company_FCW_ID");
    UltraGridColumn ultraGridColumn75 = new UltraGridColumn("Added");
    UltraGridColumn ultraGridColumn76 = new UltraGridColumn("PolicyFormComments");
    UltraGridColumn ultraGridColumn77 = new UltraGridColumn("CompanyLineID");
    UltraGridColumn ultraGridColumn78 = new UltraGridColumn("RaterID");
    UltraGridColumn ultraGridColumn79 = new UltraGridColumn("RaterConditionalID");
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    Appearance appearance11 = new Appearance();
    Appearance appearance12 = new Appearance();
    Appearance appearance13 = new Appearance();
    Appearance appearance14 = new Appearance();
    ScrollBarLook scrollBarLook2 = new ScrollBarLook();
    Appearance appearance15 = new Appearance();
    UltraGridBand ultraGridBand6 = new UltraGridBand("tblWarranties", -1);
    UltraGridColumn ultraGridColumn80 = new UltraGridColumn("WarrantyID");
    UltraGridColumn ultraGridColumn81 = new UltraGridColumn("WarrantyName");
    UltraGridColumn ultraGridColumn82 = new UltraGridColumn("Applied");
    UltraGridColumn ultraGridColumn83 = new UltraGridColumn("Mandatory");
    UltraGridColumn ultraGridColumn84 = new UltraGridColumn("Company_FCW_ID");
    UltraGridColumn ultraGridColumn85 = new UltraGridColumn("WaivedByUserGuid");
    UltraGridColumn ultraGridColumn86 = new UltraGridColumn("AddedByUserGuid");
    UltraGridColumn ultraGridColumn87 = new UltraGridColumn("PlacedByCompanyLineID");
    UltraGridColumn ultraGridColumn88 = new UltraGridColumn("tblWarrantiestblQuoteFormsConditionsWarranties");
    UltraGridColumn ultraGridColumn89 = new UltraGridColumn("tblWarrantiestblWarrantyForms");
    UltraGridBand ultraGridBand7 = new UltraGridBand("tblWarrantiestblQuoteFormsConditionsWarranties", 0);
    UltraGridColumn ultraGridColumn90 = new UltraGridColumn("Quote_FCW_ID");
    UltraGridColumn ultraGridColumn91 = new UltraGridColumn("QuoteID");
    UltraGridColumn ultraGridColumn92 = new UltraGridColumn("PolicyFormID");
    UltraGridColumn ultraGridColumn93 = new UltraGridColumn("ConditionID");
    UltraGridColumn ultraGridColumn94 = new UltraGridColumn("WarrantyID");
    UltraGridColumn ultraGridColumn95 = new UltraGridColumn("EndorsementNum");
    UltraGridColumn ultraGridColumn96 = new UltraGridColumn("Deleted");
    UltraGridColumn ultraGridColumn97 = new UltraGridColumn("OriginalID");
    UltraGridColumn ultraGridColumn98 = new UltraGridColumn("WaivedByUserGuid");
    UltraGridColumn ultraGridColumn99 = new UltraGridColumn("AllowDuplicates");
    UltraGridColumn ultraGridColumn100 = new UltraGridColumn("AddedByUserGuid");
    UltraGridColumn ultraGridColumn101 = new UltraGridColumn("Mandatory");
    UltraGridColumn ultraGridColumn102 = new UltraGridColumn("Company_FCW_ID");
    UltraGridColumn ultraGridColumn103 = new UltraGridColumn("Added");
    UltraGridColumn ultraGridColumn104 = new UltraGridColumn("PolicyFormComments");
    UltraGridColumn ultraGridColumn105 = new UltraGridColumn("CompanyLineID");
    UltraGridColumn ultraGridColumn106 = new UltraGridColumn("RaterID");
    UltraGridColumn ultraGridColumn107 = new UltraGridColumn("RaterConditionalID");
    UltraGridBand ultraGridBand8 = new UltraGridBand("tblWarrantiestblWarrantyForms", 0);
    UltraGridColumn ultraGridColumn108 = new UltraGridColumn("WarrantyID");
    UltraGridColumn ultraGridColumn109 = new UltraGridColumn("PolicyFormID");
    Appearance appearance16 = new Appearance();
    Appearance appearance17 = new Appearance();
    Appearance appearance18 = new Appearance();
    Appearance appearance19 = new Appearance();
    Appearance appearance20 = new Appearance();
    Appearance appearance21 = new Appearance();
    ScrollBarLook scrollBarLook3 = new ScrollBarLook();
    Appearance appearance22 = new Appearance();
    Appearance appearance23 = new Appearance();
    Appearance appearance24 = new Appearance();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmPolicyFCW));
    Appearance appearance25 = new Appearance();
    UltraTab ultraTab1 = new UltraTab();
    Appearance appearance26 = new Appearance();
    UltraTab ultraTab2 = new UltraTab();
    Appearance appearance27 = new Appearance();
    UltraTab ultraTab3 = new UltraTab();
    Appearance appearance28 = new Appearance();
    UltraTab ultraTab4 = new UltraTab();
    Appearance appearance29 = new Appearance();
    Appearance appearance30 = new Appearance();
    Appearance appearance31 = new Appearance();
    UltraToolbar ultraToolbar = new UltraToolbar("UltraToolbar1");
    PopupMenuTool popupMenuTool1 = new PopupMenuTool("formsPopup");
    PopupMenuTool popupMenuTool2 = new PopupMenuTool("formsPopup");
    ButtonTool buttonTool1 = new ButtonTool("Print");
    ButtonTool buttonTool2 = new ButtonTool("Mark as New");
    ButtonTool buttonTool3 = new ButtonTool("Undelete");
    ButtonTool buttonTool4 = new ButtonTool("Clear Rule");
    ButtonTool buttonTool5 = new ButtonTool("Reset Record");
    ButtonTool buttonTool6 = new ButtonTool("Extract Tags");
    ButtonTool buttonTool7 = new ButtonTool("Preview");
    ButtonTool buttonTool8 = new ButtonTool("Print");
    Appearance appearance32 = new Appearance();
    ButtonTool buttonTool9 = new ButtonTool("Mark as New");
    Appearance appearance33 = new Appearance();
    ButtonTool buttonTool10 = new ButtonTool("Undelete");
    Appearance appearance34 = new Appearance();
    ButtonTool buttonTool11 = new ButtonTool("Reset Record");
    Appearance appearance35 = new Appearance();
    PopupMenuTool popupMenuTool3 = new PopupMenuTool("condsPopup");
    ButtonTool buttonTool12 = new ButtonTool("Clear Rule");
    ButtonTool buttonTool13 = new ButtonTool("Reset Record");
    PopupMenuTool popupMenuTool4 = new PopupMenuTool("warrsPopup");
    ButtonTool buttonTool14 = new ButtonTool("Clear Rule");
    ButtonTool buttonTool15 = new ButtonTool("Reset Record");
    ButtonTool buttonTool16 = new ButtonTool("Clear Rule");
    Appearance appearance36 = new Appearance();
    ButtonTool buttonTool17 = new ButtonTool("Extract Tags");
    Appearance appearance37 = new Appearance();
    ButtonTool buttonTool18 = new ButtonTool("Preview");
    Appearance appearance38 = new Appearance();
    Appearance appearance39 = new Appearance();
    Appearance appearance40 = new Appearance();
    Appearance appearance41 = new Appearance();
    this.UltraTabPageControl1 = new UltraTabPageControl();
    this.ugForms = new UltraGrid();
    this.ds = new dsPolicyFCW();
    this.UltraTabPageControl2 = new UltraTabPageControl();
    this.ugConditions = new UltraGrid();
    this.UltraTabPageControl3 = new UltraTabPageControl();
    this.ugWarranties = new UltraGrid();
    this.tabAdditionalComments = new UltraTabPageControl();
    this.txtAdditionalComments = new MGATextBox();
    this.panelPleaseWait = new UltraGroupBox();
    this.progressLoading = new UltraProgressBar();
    this.labelLoading = new UltraLabel();
    this.Label13 = new Label();
    this.PictureBox1 = new PictureBox();
    this.panelSaving = new UltraGroupBox();
    this.progress = new UltraProgressBar();
    this.labelStatus = new Label();
    this.UltraTabPageControl4 = new UltraTabPageControl();
    this.UltraTabPageControl5 = new UltraTabPageControl();
    this.labelInformation = new Label();
    this.Label12 = new Label();
    this.Label11 = new Label();
    this.ultraTabFCW = new UltraTabControl();
    this.UltraTabSharedControlsPage1 = new UltraTabSharedControlsPage();
    this.lblEndorsementInfo = new Label();
    this.lnkCustom = new LinkLabel();
    this.btnSave = new MGAButton();
    this.btnCancel = new MGAButton();
    this.tt = new ToolTip(this.components);
    this._frmPolicyFCW_Toolbars_Dock_Area_Left = new UltraToolbarsDockArea();
    this.UltraToolbarsManager1 = new UltraToolbarsManager(this.components);
    this._frmPolicyFCW_Toolbars_Dock_Area_Right = new UltraToolbarsDockArea();
    this._frmPolicyFCW_Toolbars_Dock_Area_Top = new UltraToolbarsDockArea();
    this._frmPolicyFCW_Toolbars_Dock_Area_Bottom = new UltraToolbarsDockArea();
    this.daNRExtendedData = DefaultDatabase.CreateDataAdapter();
    this.DbCommand2 = DefaultDatabase.CreateCommand();
    this.DbCommand3 = DefaultDatabase.CreateCommand();
    this.DbCommand4 = DefaultDatabase.CreateCommand();
    this.DbCommand5 = DefaultDatabase.CreateCommand();
    this.UltraToolTipManager1 = new UltraToolTipManager(this.components);
    this.lnkRaterLog = new LinkLabel();
    this.DsMultiQuotePrinting1 = new dsMultiQuotePrinting();
    this.lnkClearEndorsementNumbers = new LinkLabel();
    this.txtFormsFilter = new MGATextBox();
    this.txtDescriptionFilter = new MGATextBox();
    this.txtFormNumberFilter = new MGATextBox();
    this.txtCommentsFilter = new MGATextBox();
    this.chkShowHidden = new CheckBox();
    this.lblCustomConditionsExist = new Label();
    ((Control) this.UltraTabPageControl1).SuspendLayout();
    ((ISupportInitialize) this.ugForms).BeginInit();
    this.ds.BeginInit();
    ((Control) this.UltraTabPageControl2).SuspendLayout();
    ((ISupportInitialize) this.ugConditions).BeginInit();
    ((Control) this.UltraTabPageControl3).SuspendLayout();
    ((ISupportInitialize) this.ugWarranties).BeginInit();
    ((Control) this.tabAdditionalComments).SuspendLayout();
    ((ISupportInitialize) this.txtAdditionalComments).BeginInit();
    ((ISupportInitialize) this.panelPleaseWait).BeginInit();
    ((Control) this.panelPleaseWait).SuspendLayout();
    ((ISupportInitialize) this.PictureBox1).BeginInit();
    ((ISupportInitialize) this.panelSaving).BeginInit();
    ((Control) this.panelSaving).SuspendLayout();
    ((Control) this.UltraTabPageControl5).SuspendLayout();
    ((ISupportInitialize) this.ultraTabFCW).BeginInit();
    ((Control) this.ultraTabFCW).SuspendLayout();
    ((ISupportInitialize) this.btnSave).BeginInit();
    ((ISupportInitialize) this.btnCancel).BeginInit();
    ((ISupportInitialize) this.UltraToolbarsManager1).BeginInit();
    this.DsMultiQuotePrinting1.BeginInit();
    ((ISupportInitialize) this.txtFormsFilter).BeginInit();
    ((ISupportInitialize) this.txtDescriptionFilter).BeginInit();
    ((ISupportInitialize) this.txtFormNumberFilter).BeginInit();
    ((ISupportInitialize) this.txtCommentsFilter).BeginInit();
    this.SuspendLayout();
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.ugForms);
    ((Control) this.UltraTabPageControl1).Location = new Point(1, 26);
    ((Control) this.UltraTabPageControl1).Name = "UltraTabPageControl1";
    ((Control) this.UltraTabPageControl1).Size = new Size(993, 438);
    this.UltraToolbarsManager1.SetContextMenuUltra((Component) this.ugForms, "formsPopup");
    ((UltraGridBase) this.ugForms).DataSource = (object) this.ds.tblPolicyForms;
    appearance1.BackColor = Color.White;
    appearance1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.ugForms).DisplayLayout.Appearance = (AppearanceBase) appearance1;
    ((UltraGridBase) this.ugForms).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn1.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn1.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn1.Width = 33;
    ultraGridColumn2.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn2.CellActivation = (Activation) 1;
    ((HeaderBase) ultraGridColumn2.Header).Caption = "Form";
    ((HeaderBase) ultraGridColumn2.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn2.Header.VisiblePosition = 2;
    ultraGridColumn2.Width = 237;
    ultraGridColumn3.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn3.CellActivation = (Activation) 1;
    ((HeaderBase) ultraGridColumn3.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn3.Header.VisiblePosition = 3;
    ultraGridColumn3.Width = 110;
    ultraGridColumn4.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn4.Header).Caption = "End #";
    ((HeaderBase) ultraGridColumn4.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn4.Header.VisiblePosition = 7;
    ultraGridColumn4.Width = 61;
    ultraGridColumn5.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn5.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn5.Header.VisiblePosition = 1;
    ultraGridColumn5.Width = 39;
    ultraGridColumn6.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn6.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn6.Header.VisiblePosition = 8;
    ultraGridColumn6.Hidden = true;
    ultraGridColumn6.Width = 115;
    ultraGridColumn7.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn7.CellActivation = (Activation) 1;
    ((HeaderBase) ultraGridColumn7.Header).Caption = "Form #";
    ((HeaderBase) ultraGridColumn7.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn7.Header.VisiblePosition = 4;
    ultraGridColumn7.Width = 96 /*0x60*/;
    ultraGridColumn8.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn8.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn8.Header.VisiblePosition = 9;
    ultraGridColumn8.Hidden = true;
    ultraGridColumn8.Width = 60;
    ultraGridColumn9.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn9.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn9.Header.VisiblePosition = 10;
    ultraGridColumn9.Hidden = true;
    ultraGridColumn9.Width = 168;
    ultraGridColumn10.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn10.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn10.Header.VisiblePosition = 11;
    ultraGridColumn10.Hidden = true;
    ultraGridColumn10.Width = 84;
    ultraGridColumn11.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn11.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn11.Header.VisiblePosition = 12;
    ultraGridColumn11.Hidden = true;
    ultraGridColumn11.Width = 119;
    ultraGridColumn12.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn12.CellActivation = (Activation) 1;
    ((HeaderBase) ultraGridColumn12.Header).Caption = "Line";
    ((HeaderBase) ultraGridColumn12.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn12.Header.VisiblePosition = 13;
    ultraGridColumn12.Width = 78;
    ultraGridColumn13.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn13.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn13.Header.VisiblePosition = 14;
    ultraGridColumn13.Hidden = true;
    ultraGridColumn13.Width = 180;
    ((HeaderBase) ultraGridColumn14.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn14.Header.VisiblePosition = 15;
    ultraGridColumn14.Hidden = true;
    ultraGridColumn14.Width = 175;
    ultraGridColumn15.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn15.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn15.Header.VisiblePosition = 16 /*0x10*/;
    ultraGridColumn15.Width = 63 /*0x3F*/;
    ((HeaderBase) ultraGridColumn16.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn16.Header.VisiblePosition = 17;
    ultraGridColumn16.Hidden = true;
    ultraGridColumn16.Width = 96 /*0x60*/;
    ((HeaderBase) ultraGridColumn17.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn17.Header.VisiblePosition = 18;
    ultraGridColumn17.Hidden = true;
    ultraGridColumn17.Width = 109;
    ((HeaderBase) ultraGridColumn18.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn18.Header.VisiblePosition = 19;
    ultraGridColumn18.Hidden = true;
    ultraGridColumn18.Width = 94;
    ((HeaderBase) ultraGridColumn19.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn19.Header.VisiblePosition = 20;
    ultraGridColumn19.Hidden = true;
    ultraGridColumn19.Width = 91;
    ultraGridColumn20.CellActivation = (Activation) 1;
    ((HeaderBase) ultraGridColumn20.Header).Caption = "Edition Date";
    ((HeaderBase) ultraGridColumn20.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn20.Header.VisiblePosition = 5;
    ultraGridColumn20.Width = 80 /*0x50*/;
    ultraGridColumn21.CellActivation = (Activation) 1;
    ((HeaderBase) ultraGridColumn21.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn21.Header.VisiblePosition = 6;
    ultraGridColumn21.Width = 90;
    ((HeaderBase) ultraGridColumn22.Header).Caption = "Policy Form Comments";
    ((HeaderBase) ultraGridColumn22.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn22.Header.VisiblePosition = 21;
    ultraGridColumn22.Width = 137;
    ((HeaderBase) ultraGridColumn23.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn23.Header.VisiblePosition = 22;
    ultraGridColumn23.Hidden = true;
    ultraGridColumn23.Width = 55;
    ((HeaderBase) ultraGridColumn24.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn24.Header.VisiblePosition = 23;
    ultraGridColumn24.Hidden = true;
    ultraGridColumn24.Width = 49;
    ((HeaderBase) ultraGridColumn25.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn25.Header.VisiblePosition = 24;
    ultraGridColumn25.Hidden = true;
    ultraGridColumn25.Width = 100;
    ((HeaderBase) ultraGridColumn26.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn26.Header.VisiblePosition = 25;
    ultraGridColumn26.Hidden = true;
    ultraGridColumn26.Width = 116;
    ((HeaderBase) ultraGridColumn27.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn27.Header.VisiblePosition = 26;
    ultraGridColumn27.Hidden = true;
    ultraGridColumn27.Width = 88;
    ultraGridColumn28.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn28.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn28.Header.VisiblePosition = 27;
    ultraGridColumn29.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn29.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn29.Header.VisiblePosition = 28;
    ultraGridBand1.Columns.AddRange(new object[29]
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
      (object) ultraGridColumn29
    });
    ultraGridColumn30.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn30.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn30.Header.VisiblePosition = 0;
    ultraGridColumn31.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn31.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn31.Header.VisiblePosition = 1;
    ultraGridColumn32.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn32.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn32.Header.VisiblePosition = 2;
    ultraGridColumn33.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn33.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn33.Header.VisiblePosition = 3;
    ultraGridColumn34.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn34.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn34.Header.VisiblePosition = 4;
    ultraGridColumn35.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn35.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn35.Header.VisiblePosition = 5;
    ultraGridColumn36.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn36.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn36.Header.VisiblePosition = 6;
    ultraGridColumn37.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn37.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn37.Header.VisiblePosition = 7;
    ultraGridColumn38.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn38.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn38.Header.VisiblePosition = 8;
    ultraGridColumn39.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn39.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn39.Header.VisiblePosition = 9;
    ultraGridColumn40.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn40.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn40.Header.VisiblePosition = 10;
    ultraGridColumn41.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn41.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn41.Header.VisiblePosition = 11;
    ((HeaderBase) ultraGridColumn42.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn42.Header.VisiblePosition = 12;
    ultraGridColumn42.Hidden = true;
    ((HeaderBase) ultraGridColumn43.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn43.Header.VisiblePosition = 13;
    ((HeaderBase) ultraGridColumn44.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn44.Header.VisiblePosition = 14;
    ((HeaderBase) ultraGridColumn45.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn45.Header.VisiblePosition = 15;
    ((HeaderBase) ultraGridColumn46.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn46.Header.VisiblePosition = 16 /*0x10*/;
    ultraGridColumn46.Hidden = true;
    ((HeaderBase) ultraGridColumn47.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn47.Header.VisiblePosition = 17;
    ultraGridBand2.Columns.AddRange(new object[18]
    {
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
      (object) ultraGridColumn47
    });
    ultraGridColumn48.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn48.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn48.Header.VisiblePosition = 0;
    ultraGridColumn49.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn49.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn49.Header.VisiblePosition = 1;
    ultraGridBand3.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn48,
      (object) ultraGridColumn49
    });
    ((UltraGridBase) this.ugForms).DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    ((UltraGridBase) this.ugForms).DisplayLayout.BandsSerializer.Add((object) ultraGridBand2);
    ((UltraGridBase) this.ugForms).DisplayLayout.BandsSerializer.Add((object) ultraGridBand3);
    ((UltraGridBase) this.ugForms).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance2.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance2.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance2.ForeColor = Color.Black;
    ((UltraGridBase) this.ugForms).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance2;
    ((UltraGridBase) this.ugForms).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    appearance3.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugForms).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance3;
    appearance4.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.ugForms).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance4;
    ((UltraGridBase) this.ugForms).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 2;
    ((UltraGridBase) this.ugForms).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance5.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.ugForms).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance5;
    appearance6.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugForms).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance6;
    ((UltraGridBase) this.ugForms).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance7.BackColor = Color.Transparent;
    appearance7.ForeColor = Color.Black;
    ((UltraGridBase) this.ugForms).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance7;
    ((UltraGridBase) this.ugForms).DisplayLayout.Override.TipStyleCell = (TipStyle) 2;
    scrollBarLook1.ViewStyle = (ScrollBarViewStyle) 3;
    ((UltraGridBase) this.ugForms).DisplayLayout.ScrollBarLook = scrollBarLook1;
    ((UltraGridBase) this.ugForms).DisplayLayout.ViewStyle = (ViewStyle) 0;
    ((Control) this.ugForms).Dock = DockStyle.Fill;
    ((Control) this.ugForms).Location = new Point(0, 0);
    ((Control) this.ugForms).Name = "ugForms";
    ((Control) this.ugForms).Size = new Size(993, 438);
    ((Control) this.ugForms).TabIndex = 0;
    ((UltraControlBase) this.ugForms).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.ugForms).UseOsThemes = (DefaultableBoolean) 2;
    this.ds.DataSetName = "dsPolicyFCW";
    this.ds.Locale = new CultureInfo("en-US");
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.ugConditions);
    ((Control) this.UltraTabPageControl2).Location = new Point(-10000, -10000);
    ((Control) this.UltraTabPageControl2).Name = "UltraTabPageControl2";
    ((Control) this.UltraTabPageControl2).Size = new Size(993, 438);
    this.UltraToolbarsManager1.SetContextMenuUltra((Component) this.ugConditions, "condsPopup");
    ((UltraGridBase) this.ugConditions).DataSource = (object) this.ds.tblConditions;
    appearance8.BackColor = Color.White;
    appearance8.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.ugConditions).DisplayLayout.Appearance = (AppearanceBase) appearance8;
    ((UltraGridBase) this.ugConditions).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn50.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn50.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn50.Header.VisiblePosition = 0;
    ultraGridColumn50.Hidden = true;
    ultraGridColumn50.Width = 217;
    ultraGridColumn51.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn51.CellActivation = (Activation) 1;
    ((HeaderBase) ultraGridColumn51.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn51.Header.VisiblePosition = 2;
    ultraGridColumn51.Width = 813;
    ultraGridColumn52.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn52.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn52.Header.VisiblePosition = 1;
    ultraGridColumn52.Width = 84;
    ultraGridColumn53.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn53.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn53.Header.VisiblePosition = 3;
    ultraGridColumn53.Width = 94;
    ((HeaderBase) ultraGridColumn54.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn54.Header.VisiblePosition = 4;
    ultraGridColumn54.Hidden = true;
    ultraGridColumn54.Width = 106;
    ((HeaderBase) ultraGridColumn55.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn55.Header.VisiblePosition = 5;
    ultraGridColumn55.Hidden = true;
    ultraGridColumn55.Width = 175;
    ((HeaderBase) ultraGridColumn56.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn56.Header.VisiblePosition = 6;
    ultraGridColumn56.Hidden = true;
    ultraGridColumn56.Width = 181;
    ((HeaderBase) ultraGridColumn57.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn57.Header.VisiblePosition = 7;
    ultraGridColumn57.Hidden = true;
    ultraGridColumn57.Width = 123;
    ((HeaderBase) ultraGridColumn58.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn58.Header.VisiblePosition = 8;
    ultraGridColumn58.Hidden = true;
    ultraGridColumn58.Width = 49;
    ((HeaderBase) ultraGridColumn59.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn59.Header.VisiblePosition = 9;
    ultraGridColumn59.Hidden = true;
    ultraGridColumn59.Width = 49;
    ((HeaderBase) ultraGridColumn60.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn60.Header.VisiblePosition = 10;
    ultraGridColumn60.Hidden = true;
    ultraGridColumn60.Width = 100;
    ultraGridColumn61.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn61.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn61.Header.VisiblePosition = 11;
    ultraGridBand4.Columns.AddRange(new object[12]
    {
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
      (object) ultraGridColumn61
    });
    ultraGridColumn62.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn62.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn62.Header.VisiblePosition = 0;
    ultraGridColumn63.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn63.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn63.Header.VisiblePosition = 1;
    ultraGridColumn64.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn64.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn64.Header.VisiblePosition = 2;
    ultraGridColumn65.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn65.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn65.Header.VisiblePosition = 3;
    ultraGridColumn66.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn66.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn66.Header.VisiblePosition = 4;
    ultraGridColumn67.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn67.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn67.Header.VisiblePosition = 5;
    ultraGridColumn68.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn68.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn68.Header.VisiblePosition = 6;
    ultraGridColumn69.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn69.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn69.Header.VisiblePosition = 7;
    ultraGridColumn70.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn70.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn70.Header.VisiblePosition = 8;
    ultraGridColumn70.Hidden = true;
    ultraGridColumn71.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn71.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn71.Header.VisiblePosition = 9;
    ultraGridColumn72.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn72.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn72.Header.VisiblePosition = 10;
    ultraGridColumn72.Hidden = true;
    ultraGridColumn73.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn73.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn73.Header.VisiblePosition = 11;
    ((HeaderBase) ultraGridColumn74.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn74.Header.VisiblePosition = 12;
    ((HeaderBase) ultraGridColumn75.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn75.Header.VisiblePosition = 13;
    ((HeaderBase) ultraGridColumn76.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn76.Header.VisiblePosition = 14;
    ((HeaderBase) ultraGridColumn77.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn77.Header.VisiblePosition = 15;
    ((HeaderBase) ultraGridColumn78.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn78.Header.VisiblePosition = 16 /*0x10*/;
    ultraGridColumn78.Hidden = true;
    ((HeaderBase) ultraGridColumn79.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn79.Header.VisiblePosition = 17;
    ultraGridBand5.Columns.AddRange(new object[18]
    {
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
      (object) ultraGridColumn72,
      (object) ultraGridColumn73,
      (object) ultraGridColumn74,
      (object) ultraGridColumn75,
      (object) ultraGridColumn76,
      (object) ultraGridColumn77,
      (object) ultraGridColumn78,
      (object) ultraGridColumn79
    });
    ((UltraGridBase) this.ugConditions).DisplayLayout.BandsSerializer.Add((object) ultraGridBand4);
    ((UltraGridBase) this.ugConditions).DisplayLayout.BandsSerializer.Add((object) ultraGridBand5);
    ((UltraGridBase) this.ugConditions).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance9.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance9.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance9.ForeColor = Color.Black;
    ((UltraGridBase) this.ugConditions).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance9;
    ((UltraGridBase) this.ugConditions).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    appearance10.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugConditions).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance10;
    appearance11.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.ugConditions).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance11;
    ((UltraGridBase) this.ugConditions).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 2;
    ((UltraGridBase) this.ugConditions).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance12.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.ugConditions).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance12;
    appearance13.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugConditions).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance13;
    ((UltraGridBase) this.ugConditions).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance14.BackColor = Color.Transparent;
    appearance14.ForeColor = Color.Black;
    ((UltraGridBase) this.ugConditions).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance14;
    scrollBarLook2.ViewStyle = (ScrollBarViewStyle) 3;
    ((UltraGridBase) this.ugConditions).DisplayLayout.ScrollBarLook = scrollBarLook2;
    ((UltraGridBase) this.ugConditions).DisplayLayout.ViewStyle = (ViewStyle) 0;
    ((Control) this.ugConditions).Dock = DockStyle.Fill;
    ((Control) this.ugConditions).Location = new Point(0, 0);
    ((Control) this.ugConditions).Name = "ugConditions";
    ((Control) this.ugConditions).Size = new Size(993, 438);
    ((Control) this.ugConditions).TabIndex = 1;
    ((UltraControlBase) this.ugConditions).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.ugConditions).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.ugWarranties);
    ((Control) this.UltraTabPageControl3).Location = new Point(-10000, -10000);
    ((Control) this.UltraTabPageControl3).Name = "UltraTabPageControl3";
    ((Control) this.UltraTabPageControl3).Size = new Size(993, 438);
    this.UltraToolbarsManager1.SetContextMenuUltra((Component) this.ugWarranties, "warrsPopup");
    ((UltraGridBase) this.ugWarranties).DataSource = (object) this.ds.tblWarranties;
    appearance15.BackColor = Color.White;
    appearance15.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.ugWarranties).DisplayLayout.Appearance = (AppearanceBase) appearance15;
    ((UltraGridBase) this.ugWarranties).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn80.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn80.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn80.Header.VisiblePosition = 0;
    ultraGridColumn80.Hidden = true;
    ultraGridColumn80.Width = 213;
    ultraGridColumn81.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn81.CellActivation = (Activation) 1;
    ((HeaderBase) ultraGridColumn81.Header).Caption = "Warranty";
    ((HeaderBase) ultraGridColumn81.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn81.Header.VisiblePosition = 2;
    ultraGridColumn81.Width = 778;
    ultraGridColumn82.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn82.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn82.Header.VisiblePosition = 1;
    ultraGridColumn82.Width = 119;
    ultraGridColumn83.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn83.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn83.Header.VisiblePosition = 3;
    ultraGridColumn83.Width = 94;
    ((HeaderBase) ultraGridColumn84.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn84.Header.VisiblePosition = 4;
    ultraGridColumn84.Hidden = true;
    ultraGridColumn84.Width = 106;
    ((HeaderBase) ultraGridColumn85.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn85.Header.VisiblePosition = 5;
    ultraGridColumn85.Hidden = true;
    ultraGridColumn85.Width = 175;
    ((HeaderBase) ultraGridColumn86.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn86.Header.VisiblePosition = 6;
    ultraGridColumn86.Hidden = true;
    ultraGridColumn86.Width = 181;
    ((HeaderBase) ultraGridColumn87.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn87.Header.VisiblePosition = 7;
    ultraGridColumn87.Hidden = true;
    ultraGridColumn87.Width = 132;
    ultraGridColumn88.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn88.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn88.Header.VisiblePosition = 8;
    ultraGridColumn89.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn89.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn89.Header.VisiblePosition = 9;
    ultraGridBand6.Columns.AddRange(new object[10]
    {
      (object) ultraGridColumn80,
      (object) ultraGridColumn81,
      (object) ultraGridColumn82,
      (object) ultraGridColumn83,
      (object) ultraGridColumn84,
      (object) ultraGridColumn85,
      (object) ultraGridColumn86,
      (object) ultraGridColumn87,
      (object) ultraGridColumn88,
      (object) ultraGridColumn89
    });
    ultraGridColumn90.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn90.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn90.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn90.Header.VisiblePosition = 0;
    ultraGridColumn91.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn91.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn91.Header.VisiblePosition = 1;
    ultraGridColumn92.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn92.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn92.Header.VisiblePosition = 2;
    ultraGridColumn93.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn93.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn93.Header.VisiblePosition = 3;
    ultraGridColumn94.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn94.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn94.Header.VisiblePosition = 4;
    ultraGridColumn95.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn95.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn95.Header.VisiblePosition = 5;
    ultraGridColumn96.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn96.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn96.Header.VisiblePosition = 6;
    ultraGridColumn97.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn97.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn97.Header.VisiblePosition = 7;
    ultraGridColumn98.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn98.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn98.Header.VisiblePosition = 8;
    ultraGridColumn99.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn99.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn99.Header.VisiblePosition = 9;
    ultraGridColumn100.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn100.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn100.Header.VisiblePosition = 10;
    ((HeaderBase) ultraGridColumn101.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn101.Header.VisiblePosition = 11;
    ((HeaderBase) ultraGridColumn102.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn102.Header.VisiblePosition = 12;
    ((HeaderBase) ultraGridColumn103.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn103.Header.VisiblePosition = 13;
    ((HeaderBase) ultraGridColumn104.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn104.Header.VisiblePosition = 14;
    ((HeaderBase) ultraGridColumn105.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn105.Header.VisiblePosition = 15;
    ((HeaderBase) ultraGridColumn106.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn106.Header.VisiblePosition = 16 /*0x10*/;
    ultraGridColumn106.Hidden = true;
    ((HeaderBase) ultraGridColumn107.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn107.Header.VisiblePosition = 17;
    ultraGridBand7.Columns.AddRange(new object[18]
    {
      (object) ultraGridColumn90,
      (object) ultraGridColumn91,
      (object) ultraGridColumn92,
      (object) ultraGridColumn93,
      (object) ultraGridColumn94,
      (object) ultraGridColumn95,
      (object) ultraGridColumn96,
      (object) ultraGridColumn97,
      (object) ultraGridColumn98,
      (object) ultraGridColumn99,
      (object) ultraGridColumn100,
      (object) ultraGridColumn101,
      (object) ultraGridColumn102,
      (object) ultraGridColumn103,
      (object) ultraGridColumn104,
      (object) ultraGridColumn105,
      (object) ultraGridColumn106,
      (object) ultraGridColumn107
    });
    ultraGridColumn108.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn108.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn108.Header.VisiblePosition = 0;
    ultraGridColumn109.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn109.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn109.Header.VisiblePosition = 1;
    ultraGridBand8.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn108,
      (object) ultraGridColumn109
    });
    ((UltraGridBase) this.ugWarranties).DisplayLayout.BandsSerializer.Add((object) ultraGridBand6);
    ((UltraGridBase) this.ugWarranties).DisplayLayout.BandsSerializer.Add((object) ultraGridBand7);
    ((UltraGridBase) this.ugWarranties).DisplayLayout.BandsSerializer.Add((object) ultraGridBand8);
    ((UltraGridBase) this.ugWarranties).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance16.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance16.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance16.ForeColor = Color.Black;
    ((UltraGridBase) this.ugWarranties).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance16;
    ((UltraGridBase) this.ugWarranties).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    appearance17.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugWarranties).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance17;
    appearance18.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.ugWarranties).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance18;
    ((UltraGridBase) this.ugWarranties).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 2;
    ((UltraGridBase) this.ugWarranties).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance19.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.ugWarranties).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance19;
    appearance20.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugWarranties).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance20;
    ((UltraGridBase) this.ugWarranties).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance21.BackColor = Color.Transparent;
    appearance21.ForeColor = Color.Black;
    ((UltraGridBase) this.ugWarranties).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance21;
    scrollBarLook3.ViewStyle = (ScrollBarViewStyle) 3;
    ((UltraGridBase) this.ugWarranties).DisplayLayout.ScrollBarLook = scrollBarLook3;
    ((UltraGridBase) this.ugWarranties).DisplayLayout.ViewStyle = (ViewStyle) 0;
    ((Control) this.ugWarranties).Dock = DockStyle.Fill;
    ((Control) this.ugWarranties).Location = new Point(0, 0);
    ((Control) this.ugWarranties).Name = "ugWarranties";
    ((Control) this.ugWarranties).Size = new Size(993, 438);
    ((Control) this.ugWarranties).TabIndex = 1;
    ((UltraControlBase) this.ugWarranties).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.ugWarranties).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.tabAdditionalComments).Controls.Add((Control) this.txtAdditionalComments);
    ((Control) this.tabAdditionalComments).Location = new Point(-10000, -10000);
    ((Control) this.tabAdditionalComments).Name = "tabAdditionalComments";
    ((Control) this.tabAdditionalComments).Size = new Size(993, 438);
    appearance22.BackColor = Color.White;
    appearance22.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance22.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtAdditionalComments).Appearance = (AppearanceBase) appearance22;
    ((TextEditorControlBase) this.txtAdditionalComments).BackColor = Color.White;
    ((Control) this.txtAdditionalComments).Location = new Point(12, 12);
    ((TextEditorControlBase) this.txtAdditionalComments).MaxLength = 8000;
    this.txtAdditionalComments.MGAStyle = (MGAStyles) 2;
    ((UltraTextEditor) this.txtAdditionalComments).Multiline = true;
    ((Control) this.txtAdditionalComments).Name = "txtAdditionalComments";
    ((Control) this.txtAdditionalComments).Size = new Size(890, 301);
    ((Control) this.txtAdditionalComments).TabIndex = 5;
    ((UltraControlBase) this.txtAdditionalComments).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtAdditionalComments).UseOsThemes = (DefaultableBoolean) 2;
    appearance23.BackColor = Color.White;
    appearance23.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.panelPleaseWait.ContentAreaAppearance = (AppearanceBase) appearance23;
    ((Control) this.panelPleaseWait).Controls.Add((Control) this.progressLoading);
    ((Control) this.panelPleaseWait).Controls.Add((Control) this.labelLoading);
    ((Control) this.panelPleaseWait).Controls.Add((Control) this.Label13);
    ((Control) this.panelPleaseWait).Controls.Add((Control) this.PictureBox1);
    ((Control) this.panelPleaseWait).Location = new Point(334, 240 /*0xF0*/);
    ((Control) this.panelPleaseWait).Name = "panelPleaseWait";
    ((Control) this.panelPleaseWait).Size = new Size(337, 87);
    ((Control) this.panelPleaseWait).TabIndex = 25;
    ((Control) this.progressLoading).Location = new Point(17, 74);
    ((Control) this.progressLoading).Name = "progressLoading";
    ((Control) this.progressLoading).Size = new Size(314, 13);
    ((Control) this.progressLoading).TabIndex = 3;
    this.progressLoading.Text = "[Formatted]";
    ((Control) this.progressLoading).Visible = false;
    appearance24.BackColor = Color.White;
    ((ControlBase) this.labelLoading).Appearance = (AppearanceBase) appearance24;
    ((Control) this.labelLoading).Location = new Point(58, 45);
    ((Control) this.labelLoading).Name = "labelLoading";
    ((Control) this.labelLoading).Size = new Size(273, 23);
    ((Control) this.labelLoading).TabIndex = 2;
    ((ControlBase) this.labelLoading).Text = "Loading forms, conditions, and warranties ...";
    ((ControlBase) this.labelLoading).WrapText = false;
    this.Label13.BackColor = Color.White;
    this.Label13.Font = new Font("Tahoma", 11f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label13.Location = new Point(55, 17);
    this.Label13.Name = "Label13";
    this.Label13.Size = new Size(180, 21);
    this.Label13.TabIndex = 1;
    this.Label13.Text = "Loading ... please wait ...";
    this.PictureBox1.Image = (Image) componentResourceManager.GetObject("PictureBox1.Image");
    this.PictureBox1.Location = new Point(17, 26);
    this.PictureBox1.Name = "PictureBox1";
    this.PictureBox1.Size = new Size(32 /*0x20*/, 32 /*0x20*/);
    this.PictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
    this.PictureBox1.TabIndex = 0;
    this.PictureBox1.TabStop = false;
    appearance25.BackColor = Color.FromArgb(240 /*0xF0*/, 247, 253);
    appearance25.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.panelSaving.ContentAreaAppearance = (AppearanceBase) appearance25;
    ((Control) this.panelSaving).Controls.Add((Control) this.progress);
    ((Control) this.panelSaving).Controls.Add((Control) this.labelStatus);
    ((Control) this.panelSaving).Location = new Point(322, 233);
    ((Control) this.panelSaving).Name = "panelSaving";
    ((Control) this.panelSaving).Size = new Size(360, 101);
    ((Control) this.panelSaving).TabIndex = 12;
    ((Control) this.panelSaving).Visible = false;
    ((Control) this.progress).Location = new Point(16 /*0x10*/, 64 /*0x40*/);
    this.progress.Maximum = 700;
    ((Control) this.progress).Name = "progress";
    ((Control) this.progress).Size = new Size(336, 16 /*0x10*/);
    this.progress.Step = 1;
    ((Control) this.progress).TabIndex = 12;
    this.progress.Text = "[Formatted]";
    this.labelStatus.AutoSize = true;
    this.labelStatus.BackColor = Color.Transparent;
    this.labelStatus.Font = new Font("Tahoma", 12f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.labelStatus.Location = new Point(95, 24);
    this.labelStatus.Name = "labelStatus";
    this.labelStatus.Size = new Size(169, 19);
    this.labelStatus.TabIndex = 11;
    this.labelStatus.Text = "Saving... please wait...";
    this.labelStatus.TextAlign = ContentAlignment.MiddleRight;
    ((Control) this.UltraTabPageControl4).Location = new Point(-10000, -10000);
    ((Control) this.UltraTabPageControl4).Name = "UltraTabPageControl4";
    ((Control) this.UltraTabPageControl4).Size = new Size(662, 325);
    ((Control) this.UltraTabPageControl5).Controls.Add((Control) this.labelInformation);
    ((Control) this.UltraTabPageControl5).Location = new Point(-10000, -10000);
    ((Control) this.UltraTabPageControl5).Name = "UltraTabPageControl5";
    ((Control) this.UltraTabPageControl5).Size = new Size(662, 325);
    this.labelInformation.AutoSize = true;
    this.labelInformation.ForeColor = Color.Red;
    this.labelInformation.Location = new Point(6, 6);
    this.labelInformation.Name = "labelInformation";
    this.labelInformation.Size = new Size(211, 13);
    this.labelInformation.TabIndex = 1;
    this.labelInformation.Text = "Please wait while the auto data is retrieved.";
    this.Label12.Location = new Point(0, 0);
    this.Label12.Name = "Label12";
    this.Label12.Size = new Size(100, 23);
    this.Label12.TabIndex = 0;
    this.Label11.Location = new Point(0, 0);
    this.Label11.Name = "Label11";
    this.Label11.Size = new Size(100, 23);
    this.Label11.TabIndex = 0;
    ((Control) this.ultraTabFCW).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((Control) this.ultraTabFCW).Controls.Add((Control) this.UltraTabSharedControlsPage1);
    ((Control) this.ultraTabFCW).Controls.Add((Control) this.UltraTabPageControl1);
    ((Control) this.ultraTabFCW).Controls.Add((Control) this.UltraTabPageControl2);
    ((Control) this.ultraTabFCW).Controls.Add((Control) this.UltraTabPageControl3);
    ((Control) this.ultraTabFCW).Controls.Add((Control) this.tabAdditionalComments);
    ((Control) this.ultraTabFCW).Location = new Point(8, 29);
    ((Control) this.ultraTabFCW).Name = "ultraTabFCW";
    ((UltraTabControlBase) this.ultraTabFCW).SharedControlsPage = this.UltraTabSharedControlsPage1;
    ((Control) this.ultraTabFCW).Size = new Size(995, 465);
    ((Control) this.ultraTabFCW).TabIndex = 0;
    ((UltraTabControlBase) this.ultraTabFCW).TabLayoutStyle = (TabLayoutStyle) 2;
    ((UltraTabControlBase) this.ultraTabFCW).TabPadding = new Size(5, 3);
    appearance26.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance25.Image"));
    ultraTab1.Appearance = (AppearanceBase) appearance26;
    ultraTab1.FixedWidth = 120;
    ultraTab1.TabPage = this.UltraTabPageControl1;
    ((SubObjectBase) ultraTab1).Tag = (object) "tabForms";
    ultraTab1.Text = "Forms";
    appearance27.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance26.Image"));
    ultraTab2.Appearance = (AppearanceBase) appearance27;
    ultraTab2.FixedWidth = 120;
    ultraTab2.TabPage = this.UltraTabPageControl2;
    ultraTab2.Text = "Conditions";
    appearance28.Image = (object) strings.tick;
    ultraTab3.Appearance = (AppearanceBase) appearance28;
    ultraTab3.FixedWidth = 120;
    ultraTab3.TabPage = this.UltraTabPageControl3;
    ultraTab3.Text = "Warranties";
    appearance29.Image = (object) strings.application_form_edit;
    ultraTab4.Appearance = (AppearanceBase) appearance29;
    ultraTab4.TabPage = this.tabAdditionalComments;
    ultraTab4.Text = "Additional Comments";
    ((UltraTabControlBase) this.ultraTabFCW).Tabs.AddRange(new UltraTab[4]
    {
      ultraTab1,
      ultraTab2,
      ultraTab3,
      ultraTab4
    });
    ((UltraTabControlBase) this.ultraTabFCW).TabSize = new Size(161, 0);
    ((UltraTabControlBase) this.ultraTabFCW).ViewStyle = (ViewStyle) 4;
    ((Control) this.UltraTabSharedControlsPage1).Location = new Point(-10000, -10000);
    ((Control) this.UltraTabSharedControlsPage1).Name = "UltraTabSharedControlsPage1";
    ((Control) this.UltraTabSharedControlsPage1).Size = new Size(993, 438);
    this.lblEndorsementInfo.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lblEndorsementInfo.AutoSize = true;
    this.lblEndorsementInfo.Location = new Point(8, 521);
    this.lblEndorsementInfo.Name = "lblEndorsementInfo";
    this.lblEndorsementInfo.Size = new Size(291, 13);
    this.lblEndorsementInfo.TabIndex = 7;
    this.lblEndorsementInfo.Text = "Items in gray italics were applied prior to this endorsement.";
    this.lnkCustom.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkCustom.AutoSize = true;
    this.lnkCustom.Location = new Point(8, 545);
    this.lnkCustom.Name = "lnkCustom";
    this.lnkCustom.Size = new Size(269, 13);
    this.lnkCustom.TabIndex = 12;
    this.lnkCustom.TabStop = true;
    this.lnkCustom.Text = "Click here to add custom forms/conditions to this policy";
    ((Control) this.btnSave).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance30.BackColor = Color.FromArgb(248, 248, 248);
    appearance30.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance30.BackGradientStyle = (GradientStyle) 2;
    appearance30.BorderColor = Color.DarkGray;
    appearance30.ImageHAlign = (HAlign) 2;
    appearance30.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnSave).Appearance = (AppearanceBase) appearance30;
    ((ControlBase) this.btnSave).ImageSize = new Size(24, 24);
    ((Control) this.btnSave).Location = new Point(902, 521);
    ((Control) this.btnSave).Name = "btnSave";
    ((Control) this.btnSave).Size = new Size(40, 40);
    ((Control) this.btnSave).TabIndex = 17;
    this.btnSave.UseOSThemes = (DefaultableBoolean) 2;
    ((Control) this.btnCancel).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance31.BackColor = Color.FromArgb(248, 248, 248);
    appearance31.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance31.BackGradientStyle = (GradientStyle) 2;
    appearance31.BorderColor = Color.DarkGray;
    appearance31.ImageHAlign = (HAlign) 2;
    appearance31.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnCancel).Appearance = (AppearanceBase) appearance31;
    ((ControlBase) this.btnCancel).ImageSize = new Size(24, 24);
    ((Control) this.btnCancel).Location = new Point(950, 521);
    ((Control) this.btnCancel).Name = "btnCancel";
    ((Control) this.btnCancel).Size = new Size(40, 40);
    ((Control) this.btnCancel).TabIndex = 18;
    this.btnCancel.UseOSThemes = (DefaultableBoolean) 2;
    ((Control) this._frmPolicyFCW_Toolbars_Dock_Area_Left).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._frmPolicyFCW_Toolbars_Dock_Area_Left).BackColor = Color.WhiteSmoke;
    this._frmPolicyFCW_Toolbars_Dock_Area_Left.DockedPosition = (DockedPosition) 2;
    ((Control) this._frmPolicyFCW_Toolbars_Dock_Area_Left).ForeColor = Color.Black;
    ((Control) this._frmPolicyFCW_Toolbars_Dock_Area_Left).Location = new Point(0, 0);
    ((Control) this._frmPolicyFCW_Toolbars_Dock_Area_Left).Name = "_frmPolicyFCW_Toolbars_Dock_Area_Left";
    ((Control) this._frmPolicyFCW_Toolbars_Dock_Area_Left).Size = new Size(0, 567);
    this._frmPolicyFCW_Toolbars_Dock_Area_Left.ToolbarsManager = this.UltraToolbarsManager1;
    this.UltraToolbarsManager1.DesignerFlags = 0;
    this.UltraToolbarsManager1.DockWithinContainer = (Control) this;
    this.UltraToolbarsManager1.DockWithinContainerBaseType = typeof (Form);
    this.UltraToolbarsManager1.ImageSizeSmall = new Size(16 /*0x10*/, 15);
    this.UltraToolbarsManager1.MdiMergeable = false;
    this.UltraToolbarsManager1.ShowFullMenusDelay = 500;
    ultraToolbar.DockedColumn = 0;
    ultraToolbar.DockedRow = 0;
    ((UltraToolbarBase) ultraToolbar).NonInheritedTools.AddRange(new ToolBase[1]
    {
      (ToolBase) popupMenuTool1
    });
    ultraToolbar.Text = "UltraToolbar1";
    ultraToolbar.Visible = false;
    this.UltraToolbarsManager1.Toolbars.AddRange(new UltraToolbar[1]
    {
      ultraToolbar
    });
    ((ToolPropsBase) ((ToolBase) popupMenuTool2).SharedPropsInternal).Caption = "Forms Popup Menu";
    ((ToolsCollectionBase) popupMenuTool2.Tools).AddRange(new ToolBase[7]
    {
      (ToolBase) buttonTool1,
      (ToolBase) buttonTool2,
      (ToolBase) buttonTool3,
      (ToolBase) buttonTool4,
      (ToolBase) buttonTool5,
      (ToolBase) buttonTool6,
      (ToolBase) buttonTool7
    });
    appearance32.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance29.Image"));
    ((ToolPropsBase) ((ToolBase) buttonTool8).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance32;
    ((ToolPropsBase) ((ToolBase) buttonTool8).SharedPropsInternal).Caption = "Print";
    appearance33.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance30.Image"));
    ((ToolPropsBase) ((ToolBase) buttonTool9).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance33;
    ((ToolPropsBase) ((ToolBase) buttonTool9).SharedPropsInternal).Caption = "Mark as New";
    appearance34.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance31.Image"));
    ((ToolPropsBase) ((ToolBase) buttonTool10).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance34;
    ((ToolPropsBase) ((ToolBase) buttonTool10).SharedPropsInternal).Caption = "Undelete";
    appearance35.Image = (object) strings.delete;
    ((ToolPropsBase) ((ToolBase) buttonTool11).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance35;
    ((ToolPropsBase) ((ToolBase) buttonTool11).SharedPropsInternal).Caption = "Reset Record";
    ((ToolPropsBase) ((ToolBase) popupMenuTool3).SharedPropsInternal).Caption = "Conditions Popup Menu";
    ((ToolsCollectionBase) popupMenuTool3.Tools).AddRange(new ToolBase[2]
    {
      (ToolBase) buttonTool12,
      (ToolBase) buttonTool13
    });
    ((ToolPropsBase) ((ToolBase) popupMenuTool4).SharedPropsInternal).Caption = "Warranties Popup Menu";
    ((ToolsCollectionBase) popupMenuTool4.Tools).AddRange(new ToolBase[2]
    {
      (ToolBase) buttonTool14,
      (ToolBase) buttonTool15
    });
    appearance36.Image = (object) strings.eraser;
    ((ToolPropsBase) ((ToolBase) buttonTool16).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance36;
    ((ToolPropsBase) ((ToolBase) buttonTool16).SharedPropsInternal).Caption = "Clear Rule";
    appearance37.Image = (object) strings._86;
    ((ToolPropsBase) ((ToolBase) buttonTool17).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance37;
    ((ToolPropsBase) ((ToolBase) buttonTool17).SharedPropsInternal).Caption = "Extract Tags";
    ((ToolPropsBase) ((ToolBase) buttonTool18).SharedPropsInternal).Caption = "Preview";
    this.UltraToolbarsManager1.Tools.AddRange(new ToolBase[10]
    {
      (ToolBase) popupMenuTool2,
      (ToolBase) buttonTool8,
      (ToolBase) buttonTool9,
      (ToolBase) buttonTool10,
      (ToolBase) buttonTool11,
      (ToolBase) popupMenuTool3,
      (ToolBase) popupMenuTool4,
      (ToolBase) buttonTool16,
      (ToolBase) buttonTool17,
      (ToolBase) buttonTool18
    });
    ((Control) this._frmPolicyFCW_Toolbars_Dock_Area_Right).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._frmPolicyFCW_Toolbars_Dock_Area_Right).BackColor = Color.WhiteSmoke;
    this._frmPolicyFCW_Toolbars_Dock_Area_Right.DockedPosition = (DockedPosition) 3;
    ((Control) this._frmPolicyFCW_Toolbars_Dock_Area_Right).ForeColor = Color.Black;
    ((Control) this._frmPolicyFCW_Toolbars_Dock_Area_Right).Location = new Point(1004, 0);
    ((Control) this._frmPolicyFCW_Toolbars_Dock_Area_Right).Name = "_frmPolicyFCW_Toolbars_Dock_Area_Right";
    ((Control) this._frmPolicyFCW_Toolbars_Dock_Area_Right).Size = new Size(0, 567);
    this._frmPolicyFCW_Toolbars_Dock_Area_Right.ToolbarsManager = this.UltraToolbarsManager1;
    ((Control) this._frmPolicyFCW_Toolbars_Dock_Area_Top).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._frmPolicyFCW_Toolbars_Dock_Area_Top).BackColor = Color.WhiteSmoke;
    this._frmPolicyFCW_Toolbars_Dock_Area_Top.DockedPosition = (DockedPosition) 0;
    ((Control) this._frmPolicyFCW_Toolbars_Dock_Area_Top).ForeColor = Color.Black;
    ((Control) this._frmPolicyFCW_Toolbars_Dock_Area_Top).Location = new Point(0, 0);
    ((Control) this._frmPolicyFCW_Toolbars_Dock_Area_Top).Name = "_frmPolicyFCW_Toolbars_Dock_Area_Top";
    ((Control) this._frmPolicyFCW_Toolbars_Dock_Area_Top).Size = new Size(1004, 0);
    this._frmPolicyFCW_Toolbars_Dock_Area_Top.ToolbarsManager = this.UltraToolbarsManager1;
    ((Control) this._frmPolicyFCW_Toolbars_Dock_Area_Bottom).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._frmPolicyFCW_Toolbars_Dock_Area_Bottom).BackColor = Color.WhiteSmoke;
    this._frmPolicyFCW_Toolbars_Dock_Area_Bottom.DockedPosition = (DockedPosition) 1;
    ((Control) this._frmPolicyFCW_Toolbars_Dock_Area_Bottom).ForeColor = Color.Black;
    ((Control) this._frmPolicyFCW_Toolbars_Dock_Area_Bottom).Location = new Point(0, 567);
    ((Control) this._frmPolicyFCW_Toolbars_Dock_Area_Bottom).Name = "_frmPolicyFCW_Toolbars_Dock_Area_Bottom";
    ((Control) this._frmPolicyFCW_Toolbars_Dock_Area_Bottom).Size = new Size(1004, 0);
    this._frmPolicyFCW_Toolbars_Dock_Area_Bottom.ToolbarsManager = this.UltraToolbarsManager1;
    this.daNRExtendedData.DeleteCommand = this.DbCommand2;
    this.daNRExtendedData.InsertCommand = this.DbCommand3;
    this.daNRExtendedData.SelectCommand = this.DbCommand4;
    this.daNRExtendedData.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblNetRateAdditionalData", new DataColumnMapping[3]
      {
        new DataColumnMapping("QuoteGuid", "QuoteGuid"),
        new DataColumnMapping("ID", "ID"),
        new DataColumnMapping("AdditionalComments", "AdditionalComments")
      })
    });
    this.daNRExtendedData.UpdateCommand = this.DbCommand5;
    this.DbCommand2.CommandText = "DELETE FROM [dbo].[tblNetRateAdditionalData] WHERE (([ID] = @Original_ID))";
    this.DbCommand2.Parameters.AddRange((Array) new DbParameter[1]
    {
      DefaultDatabase.CreateParameter("@Original_ID", SqlDbType.Int, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "ID", DataRowVersion.Original, (object) null)
    });
    this.DbCommand3.CommandText = componentResourceManager.GetString("DbCommand3.CommandText");
    this.DbCommand3.Parameters.AddRange((Array) new DbParameter[2]
    {
      DefaultDatabase.CreateParameter("@QuoteGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "QuoteGuid"),
      DefaultDatabase.CreateParameter("@AdditionalComments", SqlDbType.VarChar, 8000, "AdditionalComments")
    });
    this.DbCommand4.CommandText = "SELECT     QuoteGuid, ID, AdditionalComments\r\nFROM         dbo.tblNetRateAdditionalData\r\nWHERE     (QuoteGuid = @QuoteGuid)";
    this.DbCommand4.Parameters.AddRange((Array) new DbParameter[1]
    {
      DefaultDatabase.CreateParameter("@QuoteGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "QuoteGuid")
    });
    this.DbCommand5.CommandText = componentResourceManager.GetString("DbCommand5.CommandText");
    this.DbCommand5.Parameters.AddRange((Array) new DbParameter[4]
    {
      DefaultDatabase.CreateParameter("@QuoteGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "QuoteGuid"),
      DefaultDatabase.CreateParameter("@AdditionalComments", SqlDbType.VarChar, 8000, "AdditionalComments"),
      DefaultDatabase.CreateParameter("@Original_ID", SqlDbType.Int, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "ID", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@ID", SqlDbType.Int, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "ID", DataRowVersion.Original, (object) null)
    });
    this.UltraToolTipManager1.ContainingControl = (Control) this;
    this.UltraToolTipManager1.DisplayStyle = (ToolTipDisplayStyle) 3;
    this.UltraToolTipManager1.ToolTipImage = (ToolTipImage) 3;
    this.UltraToolTipManager1.ToolTipTitle = "Form Information";
    this.lnkRaterLog.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkRaterLog.AutoSize = true;
    this.lnkRaterLog.Location = new Point(297, 545);
    this.lnkRaterLog.Name = "lnkRaterLog";
    this.lnkRaterLog.Size = new Size(110, 13);
    this.lnkRaterLog.TabIndex = 12;
    this.lnkRaterLog.TabStop = true;
    this.lnkRaterLog.Text = "Rater Conditional Log";
    this.DsMultiQuotePrinting1.DataSetName = "dsMultiQuotePrinting";
    this.DsMultiQuotePrinting1.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.lnkClearEndorsementNumbers.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkClearEndorsementNumbers.AutoSize = true;
    this.lnkClearEndorsementNumbers.BackColor = Color.Transparent;
    this.lnkClearEndorsementNumbers.Location = new Point(442, 545);
    this.lnkClearEndorsementNumbers.Name = "lnkClearEndorsementNumbers";
    this.lnkClearEndorsementNumbers.Size = new Size(114, 13);
    this.lnkClearEndorsementNumbers.TabIndex = 30;
    this.lnkClearEndorsementNumbers.TabStop = true;
    this.lnkClearEndorsementNumbers.Text = "Clear Endorsement #s";
    ((Control) this.txtFormsFilter).Anchor = AnchorStyles.Top | AnchorStyles.Right;
    appearance38.BackColor = Color.White;
    appearance38.BorderColor = Color.Gray;
    appearance38.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtFormsFilter).Appearance = (AppearanceBase) appearance38;
    ((TextEditorControlBase) this.txtFormsFilter).BackColor = Color.White;
    ((Control) this.txtFormsFilter).Location = new Point(87, 3);
    ((Control) this.txtFormsFilter).Name = "txtFormsFilter";
    ((TextEditorControlBase) this.txtFormsFilter).NullText = "Filter Forms";
    ((Control) this.txtFormsFilter).Size = new Size(158, 20);
    ((Control) this.txtFormsFilter).TabIndex = 35;
    ((UltraControlBase) this.txtFormsFilter).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtFormsFilter).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.txtDescriptionFilter).Anchor = AnchorStyles.Top | AnchorStyles.Right;
    appearance39.BackColor = Color.White;
    appearance39.BorderColor = Color.Gray;
    appearance39.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtDescriptionFilter).Appearance = (AppearanceBase) appearance39;
    ((TextEditorControlBase) this.txtDescriptionFilter).BackColor = Color.White;
    ((Control) this.txtDescriptionFilter).Location = new Point(275, 3);
    ((Control) this.txtDescriptionFilter).Name = "txtDescriptionFilter";
    ((TextEditorControlBase) this.txtDescriptionFilter).NullText = "Filter Form Description";
    ((Control) this.txtDescriptionFilter).Size = new Size(158, 20);
    ((Control) this.txtDescriptionFilter).TabIndex = 36;
    ((UltraControlBase) this.txtDescriptionFilter).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtDescriptionFilter).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.txtFormNumberFilter).Anchor = AnchorStyles.Top | AnchorStyles.Right;
    appearance40.BackColor = Color.White;
    appearance40.BorderColor = Color.Gray;
    appearance40.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtFormNumberFilter).Appearance = (AppearanceBase) appearance40;
    ((TextEditorControlBase) this.txtFormNumberFilter).BackColor = Color.White;
    ((Control) this.txtFormNumberFilter).Location = new Point(463, 3);
    ((Control) this.txtFormNumberFilter).Name = "txtFormNumberFilter";
    ((TextEditorControlBase) this.txtFormNumberFilter).NullText = "Filter Form #";
    ((Control) this.txtFormNumberFilter).Size = new Size(158, 20);
    ((Control) this.txtFormNumberFilter).TabIndex = 37;
    ((UltraControlBase) this.txtFormNumberFilter).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtFormNumberFilter).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.txtCommentsFilter).Anchor = AnchorStyles.Top | AnchorStyles.Right;
    appearance41.BackColor = Color.White;
    appearance41.BorderColor = Color.Gray;
    appearance41.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtCommentsFilter).Appearance = (AppearanceBase) appearance41;
    ((TextEditorControlBase) this.txtCommentsFilter).BackColor = Color.White;
    ((Control) this.txtCommentsFilter).Location = new Point(651, 3);
    ((Control) this.txtCommentsFilter).Name = "txtCommentsFilter";
    ((TextEditorControlBase) this.txtCommentsFilter).NullText = "Filter Comments";
    ((Control) this.txtCommentsFilter).Size = new Size(158, 20);
    ((Control) this.txtCommentsFilter).TabIndex = 38;
    ((UltraControlBase) this.txtCommentsFilter).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtCommentsFilter).UseOsThemes = (DefaultableBoolean) 2;
    this.chkShowHidden.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.chkShowHidden.AutoSize = true;
    this.chkShowHidden.Location = new Point(904, 6);
    this.chkShowHidden.Name = "chkShowHidden";
    this.chkShowHidden.Size = new Size(88, 17);
    this.chkShowHidden.TabIndex = 43;
    this.chkShowHidden.Text = "Show Hidden";
    this.chkShowHidden.UseVisualStyleBackColor = true;
    this.chkShowHidden.Visible = false;
    this.lblCustomConditionsExist.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lblCustomConditionsExist.AutoSize = true;
    this.lblCustomConditionsExist.ForeColor = Color.Red;
    this.lblCustomConditionsExist.Location = new Point(8, 501);
    this.lblCustomConditionsExist.Name = "lblCustomConditionsExist";
    this.lblCustomConditionsExist.Size = new Size(187, 13);
    this.lblCustomConditionsExist.TabIndex = 48 /*0x30*/;
    this.lblCustomConditionsExist.Text = "Custom Conditions exist on this Policy";
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.WhiteSmoke;
    this.ClientSize = new Size(1004, 567);
    this.Controls.Add((Control) this.lblCustomConditionsExist);
    this.Controls.Add((Control) this.chkShowHidden);
    this.Controls.Add((Control) this.txtCommentsFilter);
    this.Controls.Add((Control) this.txtFormNumberFilter);
    this.Controls.Add((Control) this.txtDescriptionFilter);
    this.Controls.Add((Control) this.txtFormsFilter);
    this.Controls.Add((Control) this.lnkClearEndorsementNumbers);
    this.Controls.Add((Control) this.panelPleaseWait);
    this.Controls.Add((Control) this.panelSaving);
    this.Controls.Add((Control) this.btnCancel);
    this.Controls.Add((Control) this.btnSave);
    this.Controls.Add((Control) this.lnkRaterLog);
    this.Controls.Add((Control) this.lnkCustom);
    this.Controls.Add((Control) this.lblEndorsementInfo);
    this.Controls.Add((Control) this.ultraTabFCW);
    this.Controls.Add((Control) this._frmPolicyFCW_Toolbars_Dock_Area_Left);
    this.Controls.Add((Control) this._frmPolicyFCW_Toolbars_Dock_Area_Right);
    this.Controls.Add((Control) this._frmPolicyFCW_Toolbars_Dock_Area_Bottom);
    this.Controls.Add((Control) this._frmPolicyFCW_Toolbars_Dock_Area_Top);
    this.DoubleBuffered = true;
    this.Font = new Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.ForeColor = Color.Black;
    this.Name = nameof (frmPolicyFCW);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Forms / Conditions / Warranties";
    ((Control) this.UltraTabPageControl1).ResumeLayout(false);
    ((ISupportInitialize) this.ugForms).EndInit();
    this.ds.EndInit();
    ((Control) this.UltraTabPageControl2).ResumeLayout(false);
    ((ISupportInitialize) this.ugConditions).EndInit();
    ((Control) this.UltraTabPageControl3).ResumeLayout(false);
    ((ISupportInitialize) this.ugWarranties).EndInit();
    ((Control) this.tabAdditionalComments).ResumeLayout(false);
    ((Control) this.tabAdditionalComments).PerformLayout();
    ((ISupportInitialize) this.txtAdditionalComments).EndInit();
    ((ISupportInitialize) this.panelPleaseWait).EndInit();
    ((Control) this.panelPleaseWait).ResumeLayout(false);
    ((Control) this.panelPleaseWait).PerformLayout();
    ((ISupportInitialize) this.PictureBox1).EndInit();
    ((ISupportInitialize) this.panelSaving).EndInit();
    ((Control) this.panelSaving).ResumeLayout(false);
    ((Control) this.panelSaving).PerformLayout();
    ((Control) this.UltraTabPageControl5).ResumeLayout(false);
    ((Control) this.UltraTabPageControl5).PerformLayout();
    ((ISupportInitialize) this.ultraTabFCW).EndInit();
    ((Control) this.ultraTabFCW).ResumeLayout(false);
    ((ISupportInitialize) this.btnSave).EndInit();
    ((ISupportInitialize) this.btnCancel).EndInit();
    ((ISupportInitialize) this.UltraToolbarsManager1).EndInit();
    this.DsMultiQuotePrinting1.EndInit();
    ((ISupportInitialize) this.txtFormsFilter).EndInit();
    ((ISupportInitialize) this.txtDescriptionFilter).EndInit();
    ((ISupportInitialize) this.txtFormNumberFilter).EndInit();
    ((ISupportInitialize) this.txtCommentsFilter).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  private virtual UltraToolbarsManager UltraToolbarsManager1
  {
    get => this._UltraToolbarsManager1;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      BeforeToolDropdownEventHandler dropdownEventHandler = new BeforeToolDropdownEventHandler(this.UltraToolbarsManager1_BeforeToolDropdown);
      ToolClickEventHandler clickEventHandler = new ToolClickEventHandler(this.UltraToolbarsManager1_ToolClick);
      UltraToolbarsManager toolbarsManager1_1 = this._UltraToolbarsManager1;
      if (toolbarsManager1_1 != null)
      {
        toolbarsManager1_1.BeforeToolDropdown -= dropdownEventHandler;
        toolbarsManager1_1.ToolClick -= clickEventHandler;
      }
      this._UltraToolbarsManager1 = value;
      UltraToolbarsManager toolbarsManager1_2 = this._UltraToolbarsManager1;
      if (toolbarsManager1_2 == null)
        return;
      toolbarsManager1_2.BeforeToolDropdown += dropdownEventHandler;
      toolbarsManager1_2.ToolClick += clickEventHandler;
    }
  }

  private virtual LinkLabel lnkCustom
  {
    get => this._lnkCustom;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkCustom_LinkClicked);
      LinkLabel lnkCustom1 = this._lnkCustom;
      if (lnkCustom1 != null)
        lnkCustom1.LinkClicked -= clickedEventHandler;
      this._lnkCustom = value;
      LinkLabel lnkCustom2 = this._lnkCustom;
      if (lnkCustom2 == null)
        return;
      lnkCustom2.LinkClicked += clickedEventHandler;
    }
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

  private virtual MGAButton btnCancel
  {
    get => this._btnCancel;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnCancel_Click);
      MGAButton btnCancel1 = this._btnCancel;
      if (btnCancel1 != null)
        ((Control) btnCancel1).Click -= eventHandler;
      this._btnCancel = value;
      MGAButton btnCancel2 = this._btnCancel;
      if (btnCancel2 == null)
        return;
      ((Control) btnCancel2).Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("panelPleaseWait")]
  private virtual UltraGroupBox panelPleaseWait { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label13")]
  private virtual Label Label13 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("PictureBox1")]
  private virtual PictureBox PictureBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("daNRExtendedData")]
  private virtual DbDataAdapter daNRExtendedData { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("DbCommand2")]
  private virtual DbCommand DbCommand2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("DbCommand4")]
  private virtual DbCommand DbCommand4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("DbCommand5")]
  private virtual DbCommand DbCommand5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual LinkLabel lnkRaterLog
  {
    get => this._lnkRaterLog;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkRaterLog_LinkClicked);
      LinkLabel lnkRaterLog1 = this._lnkRaterLog;
      if (lnkRaterLog1 != null)
        lnkRaterLog1.LinkClicked -= clickedEventHandler;
      this._lnkRaterLog = value;
      LinkLabel lnkRaterLog2 = this._lnkRaterLog;
      if (lnkRaterLog2 == null)
        return;
      lnkRaterLog2.LinkClicked += clickedEventHandler;
    }
  }

  [field: AccessedThroughProperty("DsMultiQuotePrinting1")]
  internal virtual dsMultiQuotePrinting DsMultiQuotePrinting1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual LinkLabel lnkClearEndorsementNumbers
  {
    get => this._lnkClearEndorsementNumbers;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkClearEndorsementNumbers_LinkClicked);
      LinkLabel endorsementNumbers1 = this._lnkClearEndorsementNumbers;
      if (endorsementNumbers1 != null)
        endorsementNumbers1.LinkClicked -= clickedEventHandler;
      this._lnkClearEndorsementNumbers = value;
      LinkLabel endorsementNumbers2 = this._lnkClearEndorsementNumbers;
      if (endorsementNumbers2 == null)
        return;
      endorsementNumbers2.LinkClicked += clickedEventHandler;
    }
  }

  protected virtual UltraGrid ugForms
  {
    get => this._ugForms;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      MouseEventHandler mouseEventHandler = new MouseEventHandler(this.ugGrids_MouseDown);
      CancelableCellEventHandler cellEventHandler1 = new CancelableCellEventHandler(this.ugForms_BeforeCellActivate);
      BeforeExitEditModeEventHandler modeEventHandler = new BeforeExitEditModeEventHandler(this.ugForms_BeforeExitEditMode);
      CellEventHandler cellEventHandler2 = new CellEventHandler(this.CellChange);
      UIElementEventHandler elementEventHandler1 = new UIElementEventHandler(this.ugForms_MouseEnterElement);
      UIElementEventHandler elementEventHandler2 = new UIElementEventHandler(this.ugForms_MouseLeaveElement);
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.ugForms_KeyDown);
      InitializeLayoutEventHandler layoutEventHandler = new InitializeLayoutEventHandler(this.ugForms_InitializeLayout);
      UltraGrid ugForms1 = this._ugForms;
      if (ugForms1 != null)
      {
        ((Control) ugForms1).MouseDown -= mouseEventHandler;
        ugForms1.BeforeCellActivate -= cellEventHandler1;
        ugForms1.BeforeExitEditMode -= modeEventHandler;
        ugForms1.CellChange -= cellEventHandler2;
        ((UltraControlBase) ugForms1).MouseEnterElement -= elementEventHandler1;
        ((UltraControlBase) ugForms1).MouseLeaveElement -= elementEventHandler2;
        ((Control) ugForms1).KeyDown -= keyEventHandler;
        ugForms1.InitializeLayout -= layoutEventHandler;
      }
      this._ugForms = value;
      UltraGrid ugForms2 = this._ugForms;
      if (ugForms2 == null)
        return;
      ((Control) ugForms2).MouseDown += mouseEventHandler;
      ugForms2.BeforeCellActivate += cellEventHandler1;
      ugForms2.BeforeExitEditMode += modeEventHandler;
      ugForms2.CellChange += cellEventHandler2;
      ((UltraControlBase) ugForms2).MouseEnterElement += elementEventHandler1;
      ((UltraControlBase) ugForms2).MouseLeaveElement += elementEventHandler2;
      ((Control) ugForms2).KeyDown += keyEventHandler;
      ugForms2.InitializeLayout += layoutEventHandler;
    }
  }

  protected virtual UltraGrid ugConditions
  {
    get => this._ugConditions;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      MouseEventHandler mouseEventHandler = new MouseEventHandler(this.ugGrids_MouseDown);
      CellEventHandler cellEventHandler = new CellEventHandler(this.CellChange);
      UltraGrid ugConditions1 = this._ugConditions;
      if (ugConditions1 != null)
      {
        ((Control) ugConditions1).MouseDown -= mouseEventHandler;
        ugConditions1.CellChange -= cellEventHandler;
      }
      this._ugConditions = value;
      UltraGrid ugConditions2 = this._ugConditions;
      if (ugConditions2 == null)
        return;
      ((Control) ugConditions2).MouseDown += mouseEventHandler;
      ugConditions2.CellChange += cellEventHandler;
    }
  }

  protected virtual UltraGrid ugWarranties
  {
    get => this._ugWarranties;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      MouseEventHandler mouseEventHandler = new MouseEventHandler(this.ugGrids_MouseDown);
      CellEventHandler cellEventHandler = new CellEventHandler(this.CellChange);
      UltraGrid ugWarranties1 = this._ugWarranties;
      if (ugWarranties1 != null)
      {
        ((Control) ugWarranties1).MouseDown -= mouseEventHandler;
        ugWarranties1.CellChange -= cellEventHandler;
      }
      this._ugWarranties = value;
      UltraGrid ugWarranties2 = this._ugWarranties;
      if (ugWarranties2 == null)
        return;
      ((Control) ugWarranties2).MouseDown += mouseEventHandler;
      ugWarranties2.CellChange += cellEventHandler;
    }
  }

  protected virtual MGATextBox txtCommentsFilter
  {
    get => this._txtCommentsFilter;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.txtCommentsFilter_TextChanged);
      MGATextBox txtCommentsFilter1 = this._txtCommentsFilter;
      if (txtCommentsFilter1 != null)
        ((Control) txtCommentsFilter1).TextChanged -= eventHandler;
      this._txtCommentsFilter = value;
      MGATextBox txtCommentsFilter2 = this._txtCommentsFilter;
      if (txtCommentsFilter2 == null)
        return;
      ((Control) txtCommentsFilter2).TextChanged += eventHandler;
    }
  }

  protected virtual MGATextBox txtFormNumberFilter
  {
    get => this._txtFormNumberFilter;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.txtFormNumberFilter_TextChanged);
      MGATextBox formNumberFilter1 = this._txtFormNumberFilter;
      if (formNumberFilter1 != null)
        ((Control) formNumberFilter1).TextChanged -= eventHandler;
      this._txtFormNumberFilter = value;
      MGATextBox formNumberFilter2 = this._txtFormNumberFilter;
      if (formNumberFilter2 == null)
        return;
      ((Control) formNumberFilter2).TextChanged += eventHandler;
    }
  }

  protected virtual MGATextBox txtDescriptionFilter
  {
    get => this._txtDescriptionFilter;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.txtDescriptionFilter_TextChanged);
      MGATextBox descriptionFilter1 = this._txtDescriptionFilter;
      if (descriptionFilter1 != null)
        ((Control) descriptionFilter1).TextChanged -= eventHandler;
      this._txtDescriptionFilter = value;
      MGATextBox descriptionFilter2 = this._txtDescriptionFilter;
      if (descriptionFilter2 == null)
        return;
      ((Control) descriptionFilter2).TextChanged += eventHandler;
    }
  }

  protected virtual MGATextBox txtFormsFilter
  {
    get => this._txtFormsFilter;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.txtFormsFilter_TextChanged);
      MGATextBox txtFormsFilter1 = this._txtFormsFilter;
      if (txtFormsFilter1 != null)
        ((Control) txtFormsFilter1).TextChanged -= eventHandler;
      this._txtFormsFilter = value;
      MGATextBox txtFormsFilter2 = this._txtFormsFilter;
      if (txtFormsFilter2 == null)
        return;
      ((Control) txtFormsFilter2).TextChanged += eventHandler;
    }
  }

  internal virtual CheckBox chkShowHidden
  {
    get => this._chkShowHidden;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.chkShowHidden_CheckedChanged);
      CheckBox chkShowHidden1 = this._chkShowHidden;
      if (chkShowHidden1 != null)
        chkShowHidden1.CheckedChanged -= eventHandler;
      this._chkShowHidden = value;
      CheckBox chkShowHidden2 = this._chkShowHidden;
      if (chkShowHidden2 == null)
        return;
      chkShowHidden2.CheckedChanged += eventHandler;
    }
  }

  [field: AccessedThroughProperty("lblCustomConditionsExist")]
  private virtual Label lblCustomConditionsExist { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  public frmPolicyFCW()
  {
    this.FormClosing += new FormClosingEventHandler(this.frmPolicyFCW_FormClosing);
    this.Load += new EventHandler(this.frmPolicyFCW_Load);
    this._lastLoadTime = DateTime.Now;
    this._formsGridLayout = new MemoryStream();
    this._conditionsGridLayout = new MemoryStream();
    this._warrantiesGridLayout = new MemoryStream();
    this._raterConditionalForms = new Dictionary<int, string>();
    this._raterConditionalConditions = new Dictionary<int, string>();
    this._useNewEndorsementNumCheck = SystemSettings.GetLazySetting<bool>("UseNewFCWEndorsementNumCheck", false, true);
    this._allowNonNumericEndorsement = SystemSettings.GetLazySetting<bool>("AllowNonNumericEndorsements", false, true);
    this._useFcwInclusiveFiltering = SystemSettings.GetLazySetting<bool>("UseFCWInclusiveFiltering", false, true);
    this._allowRaterParentForms = SystemSettings.GetLazySetting<bool>("Policy.FCW.Conditionals.ApplyChildForms", false, true);
    this._supportVisibilityConditions = SystemSettings.GetLazySetting<bool>("CompanyLine.RaterConditionals.VisibilityFilters", false, true);
    this._disableEndorsementNum = SystemSettings.GetLazySetting<bool>("FCW.DisableEndorsementNumIfNotRequires", false, true);
    this.statusSB = new StringBuilder();
  }

  public frmPolicyFCW(int quoteID)
    : this(Quote.CreateNew(quoteID), false)
  {
  }

  public frmPolicyFCW(Guid quoteGuid)
    : this(Quote.CreateNew(quoteGuid), false)
  {
  }

  public frmPolicyFCW(Quote quoteObj, bool blackbox)
    : this()
  {
    this._quote = quoteObj;
    this._companyLineGuid = this._quote.CompanyLineGuid.Value;
    this._blackBoxMode = blackbox;
    if (!this._blackBoxMode)
    {
      this.InitializeComponent();
      ((Control) this.panelPleaseWait).Height = 93;
      ((Control) this.progressLoading).Visible = false;
      this.progressLoading.Maximum = 0;
      ((ControlBase) this.btnSave).Appearance.Image = (object) ImageCache.Instance.Save;
      ((ControlBase) this.btnCancel).Appearance.Image = (object) ImageCache.Instance.Undo;
      this.lblEndorsementInfo.Visible = this._quote.IsEndorsement;
      ((UltraGridBase) this.ugForms).DisplayLayout.Bands[0].Columns["LineName"].Hidden = !this._quote.IsPackagePolicy;
    }
    else
      this.ds = new dsPolicyFCW();
    Utility.SetDataAdapterConnections(this.daNRExtendedData, DefaultDatabase.CreateDbConnection(), (DbTransaction) null);
  }

  protected override void Dispose(bool disposing)
  {
    try
    {
      if (this._raterCache != null)
      {
        if (this._raterCache.Count > 0)
        {
          try
          {
            foreach (KeyValuePair<int, IRater> keyValuePair in this._raterCache)
              ((IDisposable) keyValuePair.Value)?.Dispose();
          }
          finally
          {
            Dictionary<int, IRater>.Enumerator enumerator;
            enumerator.Dispose();
          }
          this._raterCache = (Dictionary<int, IRater>) null;
        }
      }
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }
    catch (NullReferenceException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      ProjectData.ClearProjectError();
    }
  }

  private void frmPolicyFCW_FormClosing(object sender, FormClosingEventArgs e)
  {
    if (this._loadThread == null || !this._loadThread.IsAlive)
      return;
    this._loadThread.Abort();
  }

  private void frmPolicyFCW_Load(object sender, EventArgs e)
  {
    if (this.DesignMode)
      return;
    ((Control) this.btnSave).Enabled = false;
    ((Control) this.btnCancel).Enabled = false;
    ((Control) this.ultraTabFCW).Enabled = false;
    ((UltraGridBase) this.ugForms).DisplayLayout.Save((Stream) this._formsGridLayout);
    ((UltraGridBase) this.ugForms).DataSource = (object) null;
    ((UltraGridBase) this.ugConditions).DisplayLayout.Save((Stream) this._conditionsGridLayout);
    ((UltraGridBase) this.ugConditions).DataSource = (object) null;
    ((UltraGridBase) this.ugWarranties).DisplayLayout.Save((Stream) this._warrantiesGridLayout);
    ((UltraGridBase) this.ugWarranties).DataSource = (object) null;
    this.LoadNetRateInfo();
    this.ShowCustomConditionsExistLabel();
    this.chkShowHidden.Visible = this._supportVisibilityConditions.Value;
    this._loadThread = new Thread(new ParameterizedThreadStart(this.ThreadedLoad));
    this._loadThread.Name = "Policy F/C/W - Load Thread";
    this._loadThread.Start();
  }

  private void ShowCustomConditionsExistLabel()
  {
    this.lblCustomConditionsExist.Visible = DefaultDatabase.ExecuteScalar<int>(CommandType.Text, "SELECT COUNT(*) FROM tblAdditionalWarranties\r\n\t\tWHERE (QuoteID = @QuoteID)", new object[2]
    {
      (object) "@QuoteID",
      (object) this._quote.QuoteID
    }) > 0 && SystemSettings.GetSetting<bool>("Policy.FCW.Show.CustomConditionExistLabel", false);
  }

  private void LoadNetRateInfo()
  {
    if (this._blackBoxMode)
      return;
    if (this._quote.UsingNetRate || this.ShouldShowAdditionalComments())
    {
      this.daNRExtendedData.SelectCommand.Parameters["@QuoteGuid"].Value = (object) this._quote.QuoteGuid;
      DefaultDatabase.DataAdapterFill(this.daNRExtendedData, (DataTable) this.ds.tblNetRateAdditionalData);
      ((UltraTabControlBase) this.ultraTabFCW).Tabs[3].Visible = true;
      ((Control) this.txtAdditionalComments).Enabled = !this._quote.IsBound;
      if (this.ds.tblNetRateAdditionalData.Rows.Count > 0)
      {
        ((TextEditorControlBase) this.txtAdditionalComments).Text = this.ds.tblNetRateAdditionalData[0].AdditionalComments;
        RichTextBox richTextBox = new RichTextBox();
        try
        {
          richTextBox.Rtf = this.ds.tblNetRateAdditionalData.Rows[0]["AdditionalComments"].ToString();
          this.ds.tblNetRateAdditionalData.Rows[0]["AdditionalComments"] = (object) richTextBox.Text.Replace("\n", "\r\n");
        }
        catch (ArgumentException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          ProjectData.ClearProjectError();
        }
        finally
        {
          richTextBox.Dispose();
        }
      }
      if (this.ds.tblNetRateAdditionalData.Rows.Count == 0)
      {
        DataRow row = (DataRow) this.ds.tblNetRateAdditionalData.NewtblNetRateAdditionalDataRow();
        row["QuoteGuid"] = (object) this._quote.QuoteGuid;
        this.ds.tblNetRateAdditionalData.Rows.Add(row);
      }
      if (!this.ds.tblNetRateAdditionalData[0].IsAdditionalCommentsNull() && !string.IsNullOrEmpty(this.ds.tblNetRateAdditionalData[0].AdditionalComments))
        return;
      ((TextEditorControlBase) this.txtAdditionalComments).Text = this._quote.CompanyLine.QuoteAdditionalComments;
    }
    else
      ((UltraTabControlBase) this.ultraTabFCW).Tabs[3].Visible = false;
  }

  private void ThreadedLoad(object state)
  {
    this.ApplyDefaultFCW();
    if (this.IsHandleCreated && !this.IsDisposed && !this.Disposing)
    {
      this.SetStatusText("Loading forms, conditions, and warranties ...");
      this.FillData();
    }
    if (this.IsHandleCreated && !this.IsDisposed && !this.Disposing)
      this.LoadAdditionalScreenData();
    if (this.IsHandleCreated && !this.IsDisposed && !this.Disposing && !this._quote.IsIssued)
    {
      this.ConfigureRaterConditionalForms();
      this.ConfigureRaterConditions();
    }
    if (this.BlackBoxMode || !this.IsHandleCreated || this.IsDisposed || this.Disposing)
      return;
    InvokeExtensions.BetterInvoke((ISynchronizeInvoke) MDIControls.Instance.MDIParent, (Delegate) new MethodInvoker(this.LoadComplete), new object[0]);
  }

  private void RebindGrids()
  {
    ((UltraGridBase) this.ugForms).DataSource = (object) this.ds.tblPolicyForms;
    this._formsGridLayout.Position = 0L;
    ((UltraGridBase) this.ugForms).DisplayLayout.Load((Stream) this._formsGridLayout);
    ((UltraGridBase) this.ugForms).DisplayLayout.ScrollBarLook.ViewStyle = (ScrollBarViewStyle) 3;
    ((UltraGridBase) this.ugConditions).DataSource = (object) this.ds.tblConditions;
    this._conditionsGridLayout.Position = 0L;
    ((UltraGridBase) this.ugConditions).DisplayLayout.Load((Stream) this._conditionsGridLayout);
    ((UltraGridBase) this.ugConditions).DisplayLayout.ScrollBarLook.ViewStyle = (ScrollBarViewStyle) 3;
    ((UltraGridBase) this.ugWarranties).DataSource = (object) this.ds.tblWarranties;
    this._warrantiesGridLayout.Position = 0L;
    ((UltraGridBase) this.ugWarranties).DisplayLayout.Load((Stream) this._warrantiesGridLayout);
    ((UltraGridBase) this.ugWarranties).DisplayLayout.ScrollBarLook.ViewStyle = (ScrollBarViewStyle) 3;
  }

  protected virtual void LoadComplete()
  {
    if (this.IsHandleCreated && !this.IsDisposed && !this.Disposing && !this.BlackBoxMode)
      this.RebindGrids();
    if (((Control) this.progressLoading).Visible)
    {
      this.progressLoading.Value = this.progressLoading.Maximum;
      Thread.Sleep(500);
    }
    this.ColorGrids();
    if (this._quote.IsIssued && !SecurityManager.Instance.AssertPermission("{7C98DC14-C1A2-475e-B6BE-4533DFFCBBE2}"))
    {
      ((Control) this.btnSave).Enabled = false;
      this.lnkCustom.Enabled = false;
      foreach (UltraTab tab in ((UltraTabControlBase) this.ultraTabFCW).Tabs)
      {
        try
        {
          foreach (Control control in ((Control) tab.TabPage).Controls)
          {
            if (control is UltraGrid ultraGrid)
              ((UltraGridBase) ultraGrid).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
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
    else
    {
      ((Control) this.btnSave).Enabled = true;
      ((Control) this.txtAdditionalComments).Enabled = true;
    }
    ((Control) this.btnCancel).Enabled = true;
    ((Control) this.ultraTabFCW).Enabled = true;
    this.SortFormGrid();
    this._AllowRemovalOfAutoAppliedForm = SecurityManager.Instance.AssertPermission("{8459B5E5-69B6-489b-89E3-1D57042A92A8}");
    this._AllowRemovalOfMandatoryForm = SecurityManager.Instance.AssertPermission("{D96148F1-0DAC-4f2e-B117-9B11245F398E}");
    bool flag1 = true;
    if (!SecurityManager.Instance.AssertPermission("{A4369441-0F7F-4406-BADC-88CCAFDA9AE2}"))
    {
      ((ToolsCollectionBase) this.UltraToolbarsManager1.Tools)["Reset Record"].SharedProps.Visible = false;
      flag1 = false;
    }
    if (!SecurityManager.Instance.AssertPermission("{D5C89BF2-26D9-4BD0-A727-6EC3B2D72812}"))
    {
      ((ToolsCollectionBase) this.UltraToolbarsManager1.Tools)["Clear Rule"].SharedProps.Visible = false;
      if (!flag1)
      {
        this.UltraToolbarsManager1.SetContextMenuUltra((Component) this.ugConditions, "");
        this.UltraToolbarsManager1.SetContextMenuUltra((Component) this.ugWarranties, "");
      }
    }
    ((Control) this.panelPleaseWait).Visible = false;
    this.ApplyGridFilters();
    if (!this._disableEndorsementNum.Value || this.BlackBoxMode)
      return;
    bool flag2 = SecurityManager.Instance.AssertPermission("{25F97952-2D4A-49B1-A335-A5381BFA25C2}");
    foreach (UltraGridRow row in ((UltraGridBase) this.ugForms).Rows)
    {
      if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(row.Cells["RequiresEndorsementNumber"].Value)) && !Convert.ToBoolean(RuntimeHelpers.GetObjectValue(row.Cells["RequiresEndorsementNumber"].Value)))
      {
        if (!flag2)
        {
          row.Cells["EndorsementNum"].Activation = (Activation) 2;
          row.Cells["EndorsementNum"].Appearance.BackColor = SystemColors.Control;
        }
        else
          row.Cells["EndorsementNum"].Appearance.BackColor = Color.PowderBlue;
      }
    }
  }

  private void SortFormGrid()
  {
    bool flag = false;
    if (SystemSettings.GetSetting<bool>("SortFCWOnApplied", false))
    {
      ((UltraGridBase) this.ugForms).DisplayLayout.Bands[0].Columns["Applied"].SortIndicator = (SortIndicator) 2;
      ((UltraGridBase) this.ugConditions).DisplayLayout.Bands[0].Columns["Applied"].SortIndicator = (SortIndicator) 2;
      flag = true;
    }
    if (flag || !SystemSettings.GetSetting<bool>("SortFCWOnMandatory", false))
      return;
    ((UltraGridBase) this.ugForms).DisplayLayout.Bands[0].Columns["Mandatory"].SortIndicator = (SortIndicator) 2;
    ((UltraGridBase) this.ugConditions).DisplayLayout.Bands[0].Columns["Mandatory"].SortIndicator = (SortIndicator) 2;
  }

  public bool BlackBoxMode
  {
    get => this._blackBoxMode;
    set => this._blackBoxMode = value;
  }

  protected Quote Quote => this._quote;

  protected UltraGrid FormsGrid => this.ugForms;

  protected MGAButton SaveButton => this.btnSave;

  protected Dictionary<int, string> RaterConditionalForms
  {
    get => this._raterConditionalForms;
    set => this._raterConditionalForms = value;
  }

  protected Dictionary<int, string> RaterConditionalConditions
  {
    get => this._raterConditionalConditions;
    set => this._raterConditionalConditions = value;
  }

  protected Dictionary<int, IRater> RaterCache
  {
    get
    {
      if (this._raterCache == null)
      {
        this._raterCache = new Dictionary<int, IRater>();
        try
        {
          foreach ((int CompanyLineID, int RaterID) policyRater in this.PolicyRaters)
          {
            try
            {
              if (!this._raterCache.ContainsKey(policyRater.RaterID))
                this._raterCache.Add(policyRater.RaterID, RaterFactory.GetRater(policyRater.RaterID));
            }
            catch (Exception ex)
            {
              ProjectData.SetProjectError(ex);
              ErrorHandler.SilentLogError(ex);
              ProjectData.ClearProjectError();
            }
          }
        }
        finally
        {
          List<(int CompanyLineID, int RaterID)>.Enumerator enumerator;
          enumerator.Dispose();
        }
        try
        {
          Dictionary<int, IRater> raterCache = this._raterCache;
          System.Func<KeyValuePair<int, IRater>, bool> predicate;
          if (frmPolicyFCW._Closure\u0024__.\u0024I178\u002D0 != null)
            predicate = frmPolicyFCW._Closure\u0024__.\u0024I178\u002D0;
          else
            frmPolicyFCW._Closure\u0024__.\u0024I178\u002D0 = predicate = (System.Func<KeyValuePair<int, IRater>, bool>) ([SpecialName] (kvp) => kvp.Value == null);
          IEnumerable<KeyValuePair<int, IRater>> source = raterCache.Where<KeyValuePair<int, IRater>>(predicate);
          System.Func<KeyValuePair<int, IRater>, int> selector;
          if (frmPolicyFCW._Closure\u0024__.\u0024I178\u002D1 != null)
            selector = frmPolicyFCW._Closure\u0024__.\u0024I178\u002D1;
          else
            frmPolicyFCW._Closure\u0024__.\u0024I178\u002D1 = selector = (System.Func<KeyValuePair<int, IRater>, int>) ([SpecialName] (kvp) => kvp.Key);
          foreach (int key in source.Select<KeyValuePair<int, IRater>, int>(selector).ToList<int>())
            this._raterCache.Remove(key);
        }
        finally
        {
          List<int>.Enumerator enumerator;
          enumerator.Dispose();
        }
      }
      return this._raterCache;
    }
  }

  protected List<(int CompanyLineID, int RaterID)> PolicyRaters
  {
    get
    {
      if (this._policyRaters == null)
      {
        this._policyRaters = new List<(int, int)>();
        DataTable dataTable = DefaultDatabase.ExecuteDataTable("GetPolicyCompanyLineRaters", new object[2]
        {
          (object) "@quoteGuid",
          (object) this._quote.QuoteGuid
        });
        try
        {
          foreach (DataRow row in dataTable.Rows)
          {
            if (!row.IsNull("RaterID"))
              this._policyRaters.Add((row.Field<int>("CompanyLineID"), row.Field<int>("RaterID")));
          }
        }
        finally
        {
          IEnumerator enumerator;
          if (enumerator is IDisposable)
            (enumerator as IDisposable).Dispose();
        }
      }
      return this._policyRaters;
    }
  }

  protected dsPolicyFCW PolicyFCWDataSet => this.ds;

  protected virtual void LoadAdditionalScreenData()
  {
  }

  private void SetStatusText(string text)
  {
    if (this.BlackBoxMode)
      return;
    if (MDIControls.Instance.MDIParent.InvokeRequired)
    {
      InvokeExtensions.BetterInvoke((ISynchronizeInvoke) MDIControls.Instance.MDIParent, (Delegate) new Action<string>(this.SetStatusText), new object[1]
      {
        (object) text
      });
    }
    else
    {
      this.statusSB.AppendLine(text);
      ((ControlBase) this.labelLoading).Text = text;
      ((UltraControlBase) this.labelLoading).Refresh();
    }
  }

  private void ConfigureRaterConditionalForms()
  {
    if (this.ds.tblPolicyForms.Count == 0)
      return;
    try
    {
      foreach ((int CompanyLineID, int RaterID) policyRater in this.PolicyRaters)
      {
        if (!this.BlackBoxMode && this.progressLoading.Maximum == 0)
        {
          this.progressLoading.Maximum = this.PolicyRaters.Count * this.ds.tblPolicyForms.Count;
          InvokeExtensions.BetterInvoke((ISynchronizeInvoke) MDIControls.Instance.MDIParent, (Delegate) new MethodInvoker(this.ShowLoadProgress), new object[0]);
        }
        CompanyLine companyLine = new CompanyLine(policyRater.CompanyLineID);
        int raterId = policyRater.RaterID;
        IRater irater = (IRater) null;
        if (!this.RaterCache.TryGetValue(raterId, out irater))
        {
          if (this.BlackBoxMode)
            throw new InvalidOperationException($"Rater with ID {raterId} could not be located.");
          MessageBox.Show($"Rater with ID {raterId} could not be located.{"\n"}{"\n"}Unable to determine conditional forms.", "Rater Not Found", MessageBoxButtons.OK, MessageBoxIcon.Hand);
          return;
        }
        irater.InitializeState(this._quote.QuoteGuid, companyLine.CompanyLineGuid);
        irater.RaterConditionalElements(companyLine.LineCode);
        string str1 = (irater is RaterBase raterBase1 ? raterBase1.RaterName : (string) null) ?? string.Empty;
        DataTable dataTable = DefaultDatabase.ExecuteDataTable("dbo.spGetRaterConditionalPolicyForms", new object[8]
        {
          (object) "@companyLineID",
          (object) companyLine.CompanyLineID,
          (object) "@raterID",
          (object) raterId,
          (object) "@policyFormID",
          null,
          (object) "@quoteGuid",
          (object) this._quote.QuoteGuid
        });
        List<int> intList = new List<int>();
        try
        {
          foreach (DataRow row in dataTable.Rows)
          {
            int integer = Conversions.ToInteger(row["PolicyFormID"]);
            if (!intList.Contains(integer) && this.ds.tblPolicyForms.FindByFormID(integer) != null)
              intList.Add(integer);
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
          foreach (int FormID in intList)
          {
            try
            {
              dsPolicyFCW.tblPolicyFormsRow byFormId = this.ds.tblPolicyForms.FindByFormID(FormID);
              if (!byFormId.Applied)
              {
                if (byFormId.IsWaivedByUserGuidNull())
                {
                  this.SetStatusText($"Getting conditionals for form {byFormId.FormName}");
                  bool flag1 = false;
                  DataRow[] dataRowArray = dataTable.Select($"PolicyFormID = {FormID}", "FormVisibility DESC, FormOrder");
                  int index = 0;
                  int num;
                  while (index < dataRowArray.Length)
                  {
                    DataRow row = dataRowArray[index];
                    bool flag2 = row.Field<bool>("FormVisibility");
                    if (!flag2 || this._supportVisibilityConditions.Value)
                    {
                      num = row.Field<int>("SetupID");
                      if (!this.BlackBoxMode)
                      {
                        string empty = string.Empty;
                        string str2 = (irater is RaterBase raterBase2 ? raterBase2.FindCondition(row.Field<int>("ConditionalID")) : (RaterConditionalElement) null)?.Condition ?? row.Field<string>("Condition");
                        this.SetStatusText($"Checking {(flag2 ? (object) "visibility " : (object) "")}condition \"{str2}\" ({RuntimeHelpers.GetObjectValue(row["ConditionalID"])})...");
                      }
                      flag1 = irater.DoesConditionApply(row.Field<int>("ConditionalID"), frmPolicyFCW.GetPolicyFormCondition(row["Operator"].ToString()), RuntimeHelpers.GetObjectValue(row["Amount"]));
                      if (!flag1)
                      {
                        byFormId.Hidden = flag2;
                        this.SetStatusText($"Condition {(row.IsNull("Amount") ? (object) "" : (object) $"with value \"{RuntimeHelpers.GetObjectValue(row["Amount"])}\" ")}not met!{(flag2 ? (object) " Hiding form!" : (object) "")}");
                        break;
                      }
                    }
                    checked { ++index; }
                  }
                  if (flag1)
                  {
                    this.SetStatusText("Applied rater form " + byFormId.FormName);
                    this._raterConditionalForms[byFormId.FormID] = str1;
                    if (byFormId.RequiresEndorsementNumber)
                      byFormId.EndorsementNum = this.GetFormEndorsementNumber(byFormId.FormID);
                    byFormId.RaterID = raterId;
                    byFormId.RaterConditionalID = num;
                    if (this._allowRaterParentForms.Value)
                      this.CheckPolicyForm(byFormId.FormID, new int?(raterId));
                  }
                  byFormId.Applied = flag1;
                }
              }
            }
            finally
            {
              this.BumpLoadProgress();
            }
          }
        }
        finally
        {
          List<int>.Enumerator enumerator;
          enumerator.Dispose();
        }
        this.BumpLoadProgress(this.ds.tblPolicyForms.Count - intList.Count);
      }
    }
    finally
    {
      List<(int CompanyLineID, int RaterID)>.Enumerator enumerator;
      enumerator.Dispose();
    }
    this.ClientRaterConditionalForms(this.RaterCache, this.ds.tblPolicyForms);
  }

  protected virtual void ClientRaterConditionalForms(
    Dictionary<int, IRater> raterCache,
    dsPolicyFCW.tblPolicyFormsDataTable policyForms)
  {
  }

  private void ConfigureRaterConditions()
  {
    if (this.ds.tblConditions.Count == 0)
      return;
    if (!this.BlackBoxMode)
      this.progressLoading.Maximum = 0;
    try
    {
      foreach ((int CompanyLineID, int RaterID) policyRater in this.PolicyRaters)
      {
        if (!this.BlackBoxMode && this.progressLoading.Maximum == 0)
        {
          this.progressLoading.Maximum = this.PolicyRaters.Count * this.ds.tblConditions.Count;
          InvokeExtensions.BetterInvoke((ISynchronizeInvoke) MDIControls.Instance.MDIParent, (Delegate) new MethodInvoker(this.ShowLoadProgress), new object[0]);
        }
        CompanyLine companyLine = new CompanyLine(policyRater.CompanyLineID);
        int raterId = policyRater.RaterID;
        IRater irater = (IRater) null;
        if (!this.RaterCache.TryGetValue(raterId, out irater))
        {
          if (this.BlackBoxMode)
            throw new InvalidOperationException($"Rater with ID {raterId} could not be located.");
          MessageBox.Show($"Rater with ID {raterId} could not be located.{"\n"}{"\n"}Unable to determine conditions.", "Rater Not Found", MessageBoxButtons.OK, MessageBoxIcon.Hand);
          return;
        }
        irater.InitializeState(this._quote.QuoteGuid, companyLine.CompanyLineGuid);
        irater.RaterConditionalElements(companyLine.LineCode);
        string str1 = (irater is RaterBase raterBase1 ? raterBase1.RaterName : (string) null) ?? string.Empty;
        DataTable dataTable = DefaultDatabase.ExecuteDataTable("dbo.spGetRaterConditions", new object[8]
        {
          (object) "@companyLineID",
          (object) companyLine.CompanyLineID,
          (object) "@raterID",
          (object) raterId,
          (object) "@conditionID",
          null,
          (object) "@quoteGuid",
          (object) this._quote.QuoteGuid
        });
        List<int> intList = new List<int>();
        try
        {
          foreach (DataRow row in dataTable.Rows)
          {
            int integer = Conversions.ToInteger(row["CompanyLineConditionID"]);
            if (!intList.Contains(integer) && this.ds.tblConditions.FindByConditionID(integer) != null)
              intList.Add(integer);
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
          foreach (int ConditionID in intList)
          {
            try
            {
              dsPolicyFCW.tblConditionsRow byConditionId = this.ds.tblConditions.FindByConditionID(ConditionID);
              if (!byConditionId.Applied)
              {
                if (byConditionId.IsWaivedByUserGuidNull())
                {
                  this.SetStatusText($"Getting conditions for condition {byConditionId.Condition}");
                  bool flag1 = false;
                  DataRow[] dataRowArray = dataTable.Select($"CompanyLineConditionID = {ConditionID}", "FormVisibility DESC, CompanyLineConditionID");
                  int index = 0;
                  int num;
                  while (index < dataRowArray.Length)
                  {
                    DataRow row = dataRowArray[index];
                    bool flag2 = row.Field<bool>("FormVisibility");
                    if (!flag2 || this._supportVisibilityConditions.Value)
                    {
                      num = row.Field<int>("SetupID");
                      if (!this.BlackBoxMode)
                      {
                        string empty = string.Empty;
                        string str2 = (irater is RaterBase raterBase2 ? raterBase2.FindCondition(row.Field<int>("ConditionalID")) : (RaterConditionalElement) null)?.Condition ?? row.Field<string>("Condition");
                        this.SetStatusText($"Checking {(flag2 ? (object) "visibility " : (object) "")}condition \"{str2}\" ({RuntimeHelpers.GetObjectValue(row["ConditionalID"])})...");
                      }
                      flag1 = irater.DoesConditionApply(Conversions.ToInteger(row["ConditionalID"]), frmPolicyFCW.GetPolicyFormCondition(row["Operator"].ToString()), RuntimeHelpers.GetObjectValue(row["Amount"]));
                      if (!flag1)
                      {
                        byConditionId.Hidden = flag2;
                        this.SetStatusText($"Condition {(row.IsNull("Amount") ? (object) "" : (object) $"with value \"{RuntimeHelpers.GetObjectValue(row["Amount"])}\" ")}not met!{(flag2 ? (object) " Hiding condition!" : (object) "")}");
                        break;
                      }
                    }
                    checked { ++index; }
                  }
                  if (flag1)
                  {
                    this.SetStatusText("Applied rater condition " + byConditionId.Condition);
                    this._raterConditionalConditions[byConditionId.ConditionID] = str1;
                    byConditionId.RaterID = raterId;
                    byConditionId.RaterConditionalID = num;
                  }
                  byConditionId.Applied = flag1;
                }
              }
            }
            finally
            {
              this.BumpLoadProgress();
            }
          }
        }
        finally
        {
          List<int>.Enumerator enumerator;
          enumerator.Dispose();
        }
        this.BumpLoadProgress(this.ds.tblConditions.Count - intList.Count);
      }
    }
    finally
    {
      List<(int CompanyLineID, int RaterID)>.Enumerator enumerator;
      enumerator.Dispose();
    }
    this.ClientRaterConditions(this.RaterCache, this.ds.tblConditions);
  }

  protected virtual void ClientRaterConditions(
    Dictionary<int, IRater> raterCache,
    dsPolicyFCW.tblConditionsDataTable policyConditions)
  {
  }

  private string ConfigureWarrantiesAndForms(int WarrantyID, bool AddForms)
  {
    StringBuilder stringBuilder = new StringBuilder();
    string warrantyName = this.ds.tblWarranties.FindByWarrantyID(WarrantyID).WarrantyName;
    DataRow[] dataRowArray = this.ds.tblWarrantiesAssociatedForms.Select("WarrantyID = " + Conversions.ToString(WarrantyID));
    int index = 0;
    while (index < dataRowArray.Length)
    {
      dsPolicyFCW.tblPolicyFormsRow byFormId = this.ds.tblPolicyForms.FindByFormID(((dsPolicyFCW.tblWarrantiesAssociatedFormsRow) dataRowArray[index]).PolicyFormID);
      if (byFormId != null && (AddForms && !byFormId.Applied || !AddForms && this.ds.tblWarrantyForms.Select("PolicyFormID=" + Conversions.ToString(byFormId.FormID)).Length == 0))
      {
        byFormId.Applied = AddForms;
        byFormId["WaivedByUserGuid"] = RuntimeHelpers.GetObjectValue(AddForms ? (object) DBNull.Value : (object) CurrentUser.Instance.UserGUID);
        byFormId.AssociatedWarrantyID = WarrantyID;
        byFormId.SetAssociatedFormIDNull();
        if (AddForms)
          byFormId.AddedByUserGuid = CurrentUser.Instance.UserGUID;
        stringBuilder.AppendLine(byFormId.FormName);
      }
      checked { ++index; }
    }
    return stringBuilder.ToString();
  }

  [Obsolete("This method is not being used anywhere, and it's private so child forms can't call it.")]
  private bool FormWarrantyAlreadyApplied(int warrantyID, int policyFormID) => false;

  private void ShowLoadProgress() => ((Control) this.progressLoading).Visible = true;

  private void BumpLoadProgress(int number = 1)
  {
    if (this.BlackBoxMode)
      return;
    if (MDIControls.Instance.MDIParent.InvokeRequired)
    {
      MDIControls.Instance.MDIParent.Invoke((Delegate) new Action<int>(this.BumpLoadProgress), (object) number);
    }
    else
    {
      if (this.progressLoading.Value + number > this.progressLoading.Maximum)
        return;
      UltraProgressBar progressLoading;
      int num = (progressLoading = this.progressLoading).Value + number;
      progressLoading.Value = num;
    }
  }

  private static ConditionalOperators GetPolicyFormCondition(string condition)
  {
    string str = condition;
    ConditionalOperators policyFormCondition;
    // ISSUE: reference to a compiler-generated method
    switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(str))
    {
      case 600578307:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "EQ", false) == 0)
        {
          policyFormCondition = (ConditionalOperators) 4;
          break;
        }
        break;
      case 653618115:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "TR", false) == 0)
        {
          policyFormCondition = (ConditionalOperators) 0;
          break;
        }
        break;
      case 904296662:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "NC", false) == 0)
        {
          policyFormCondition = (ConditionalOperators) 7;
          break;
        }
        break;
      case 937851900:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "NE", false) == 0)
        {
          policyFormCondition = (ConditionalOperators) 5;
          break;
        }
        break;
      case 1792083446:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "GT", false) == 0)
        {
          policyFormCondition = (ConditionalOperators) 2;
          break;
        }
        break;
      case 1792671826:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "CT", false) == 0)
        {
          policyFormCondition = (ConditionalOperators) 6;
          break;
        }
        break;
      case 2095213421:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "LT", false) == 0)
        {
          policyFormCondition = (ConditionalOperators) 3;
          break;
        }
        break;
      case 2211671016:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "FA", false) == 0)
        {
          policyFormCondition = (ConditionalOperators) 1;
          break;
        }
        break;
    }
    return policyFormCondition;
  }

  [Obsolete("This is being done in the GetPolicyFCWData stored procedure now.")]
  private void SetItemsChecked()
  {
  }

  private void FillData()
  {
    try
    {
      DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[7]
      {
        this.ds.tblConditions.TableName,
        this.ds.tblPolicyForms.TableName,
        this.ds.tblWarranties.TableName,
        this.ds.tblWarrantyForms.TableName,
        this.ds.tblUsers.TableName,
        this.ds.tblQuoteFormsConditionsWarranties.TableName,
        this.ds.tblWarrantiesAssociatedForms.TableName
      }, "dbo.GetPolicyFCWData", new object[2]
      {
        (object) "@quoteGuid",
        (object) this._quote.QuoteGuid
      });
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      Exception exception = ex;
      if (exception is ConstraintException)
      {
        this.RemoveInvalidRows();
      }
      else
      {
        if (exception is ThreadAbortException)
        {
          ProjectData.ClearProjectError();
          return;
        }
        if (this.BlackBoxMode)
          throw;
        ErrorHandler.HandleErrorOnThread((Control) MDIControls.Instance.MDIParent, exception);
      }
      ProjectData.ClearProjectError();
    }
    if (this.ds.tblUsers.FindByUserGUID(CurrentUser.Instance.UserGUID) != null)
      return;
    this.ds.tblUsers.AddtblUsersRow(CurrentUser.Instance.UserGUID, $"{CurrentUser.Instance.LastName}, {CurrentUser.Instance.FirstName}");
  }

  [Obsolete("This was part of the SetItemsChecked process, which is no longer needed.")]
  private void ApplyForm(
    dsPolicyFCW.tblQuoteFormsConditionsWarrantiesRow dr)
  {
    dsPolicyFCW.tblPolicyFormsRow byFormId = this.ds.tblPolicyForms.FindByFormID(dr.PolicyFormID);
    DataRow[] dataRowArray = this.ds.tblQuoteFormsConditionsWarranties.Select("PolicyFormID=" + dr.PolicyFormID.ToString());
    if (dataRowArray != null && dataRowArray.Length > 0)
    {
      dsPolicyFCW.tblQuoteFormsConditionsWarrantiesRow conditionsWarrantiesRow = (dsPolicyFCW.tblQuoteFormsConditionsWarrantiesRow) dataRowArray[0];
      if (!conditionsWarrantiesRow.IsEndorsementNumNull())
        byFormId.EndorsementNum = conditionsWarrantiesRow.EndorsementNum;
      if (!conditionsWarrantiesRow.IsWaivedByUserGuidNull())
        byFormId.WaivedByUserGuid = conditionsWarrantiesRow.WaivedByUserGuid;
      if (!conditionsWarrantiesRow.IsAddedByUserGuidNull())
        byFormId.AddedByUserGuid = conditionsWarrantiesRow.AddedByUserGuid;
    }
    byFormId.Applied = !dr.Deleted && dr.IsWaivedByUserGuidNull();
  }

  [Obsolete("This was part of the SetItemsChecked process, which is no longer needed.")]
  private void ApplyFCW(
    dsPolicyFCW.tblQuoteFormsConditionsWarrantiesRow dr)
  {
    DataRow baseDataRow = this.GetBaseDataRow(dr);
    if (!dr.IsPolicyFormIDNull() && !dr.IsEndorsementNumNull())
      baseDataRow.SetField<string>("EndorsementNum", dr.EndorsementNum);
    if (!dr.IsWaivedByUserGuidNull())
      baseDataRow.SetField<Guid>("WaivedByUserGuid", dr.WaivedByUserGuid);
    if (!dr.IsAddedByUserGuidNull())
      baseDataRow.SetField<Guid>("AddedByUserGuid", dr.AddedByUserGuid);
    baseDataRow.SetField<bool>("Mandatory", dr.Mandatory);
    baseDataRow.SetField<bool>("Applied", !dr.Deleted && dr.IsWaivedByUserGuidNull());
  }

  private void ColorGrids()
  {
    bool setting = SystemSettings.GetSetting<bool>("Policy.FCW.RequiresEdit.Bold", false);
    foreach (UltraTab tab in ((UltraTabControlBase) this.ultraTabFCW).Tabs)
    {
      if (((Control) tab.TabPage).Controls[0] is UltraGrid control)
      {
        foreach (UltraGridRow row in ((UltraGridBase) control).Rows)
        {
          dsPolicyFCW.tblQuoteFormsConditionsWarrantiesRow associatedFcwRow = this.GetAssociatedFCWRow(control, row);
          dsPolicyFCW.tblPolicyFormsRow tblPolicyFormsRow = associatedFcwRow?.tblPolicyFormsRow;
          bool flag1 = false;
          bool flag2 = false;
          bool flag3 = false;
          bool flag4 = false;
          bool flag5 = control != this.ugWarranties && Conversions.ToBoolean(row.Cells["Hidden"]?.Value ?? (object) false);
          if (associatedFcwRow != null)
          {
            flag2 = associatedFcwRow.Deleted;
            flag1 = !associatedFcwRow.IsOriginalIDNull();
            flag3 = !flag2 && !associatedFcwRow.IsWaivedByUserGuidNull();
            flag4 = flag1 && associatedFcwRow.AllowDuplicates;
          }
          UltraGridRow ultraGridRow = row;
          if (flag3)
            ultraGridRow.Appearance.ForeColor = Color.Goldenrod;
          else if (flag1 && !flag2)
          {
            if (!flag4)
              ultraGridRow.Appearance.ForeColor = Color.Gray;
            ultraGridRow.Appearance.FontData.Italic = (DefaultableBoolean) 1;
          }
          else if (flag2)
          {
            ultraGridRow.Appearance.ForeColor = Color.Red;
            ultraGridRow.Appearance.FontData.Strikeout = (DefaultableBoolean) 1;
          }
          else if (associatedFcwRow != null)
            ultraGridRow.Appearance.ForeColor = Color.Green;
          else if (flag5)
          {
            ultraGridRow.Appearance.BackColor = Color.DarkSlateGray;
            ultraGridRow.Appearance.ForeColor = Color.GhostWhite;
          }
          else
            ultraGridRow.Appearance.ForeColor = Color.Black;
          if (setting && (tblPolicyFormsRow != null ? (tblPolicyFormsRow.Field<bool?>("RequiresEdit").GetValueOrDefault() ? 1 : 0) : 0) != 0)
            ultraGridRow.Appearance.FontData.Bold = (DefaultableBoolean) 1;
        }
      }
    }
  }

  private void RemoveInvalidRows()
  {
    List<int> removeIDs1 = new List<int>();
    List<int> removeIDs2 = new List<int>();
    List<int> removeIDs3 = new List<int>();
    for (int index = this.ds.tblQuoteFormsConditionsWarranties.Count - 1; index >= 0; index += -1)
    {
      dsPolicyFCW.tblQuoteFormsConditionsWarrantiesRow conditionsWarranty = this.ds.tblQuoteFormsConditionsWarranties[index];
      if (!conditionsWarranty.IsPolicyFormIDNull() && this.ds.tblPolicyForms.FindByFormID(conditionsWarranty.PolicyFormID) == null)
      {
        removeIDs1.Add(conditionsWarranty.PolicyFormID);
        this.ds.tblQuoteFormsConditionsWarranties.RemovetblQuoteFormsConditionsWarrantiesRow(conditionsWarranty);
      }
      else if (!conditionsWarranty.IsConditionIDNull() && this.ds.tblConditions.FindByConditionID(conditionsWarranty.ConditionID) == null)
      {
        removeIDs3.Add(conditionsWarranty.ConditionID);
        this.ds.tblQuoteFormsConditionsWarranties.RemovetblQuoteFormsConditionsWarrantiesRow(conditionsWarranty);
      }
      else if (!conditionsWarranty.IsWarrantyIDNull() && this.ds.tblWarranties.FindByWarrantyID(conditionsWarranty.WarrantyID) == null)
      {
        removeIDs2.Add(conditionsWarranty.WarrantyID);
        this.ds.tblQuoteFormsConditionsWarranties.RemovetblQuoteFormsConditionsWarrantiesRow(conditionsWarranty);
      }
    }
    if (!this._quote.IsCurrent || this._quote.IsBound)
      return;
    if (removeIDs1.Count > 0)
      this.RemoveInvalidDatabaseEntries(removeIDs1, "PolicyFormID");
    if (removeIDs2.Count > 0)
      this.RemoveInvalidDatabaseEntries(removeIDs2, "WarrantyID");
    if (removeIDs3.Count <= 0)
      return;
    this.RemoveInvalidDatabaseEntries(removeIDs3, "ConditionID");
  }

  private void RemoveInvalidDatabaseEntries(List<int> removeIDs, string columnName)
  {
    if (!this._quote.IsCurrent || this._quote.IsBound)
      return;
    List<int> source1 = removeIDs;
    Func<int, int, VB\u0024AnonymousType_0<string, int>> selector1;
    // ISSUE: reference to a compiler-generated field
    if (frmPolicyFCW._Closure\u0024__.\u0024I201\u002D0 != null)
    {
      // ISSUE: reference to a compiler-generated field
      selector1 = frmPolicyFCW._Closure\u0024__.\u0024I201\u002D0;
    }
    else
    {
      // ISSUE: reference to a compiler-generated field
      frmPolicyFCW._Closure\u0024__.\u0024I201\u002D0 = selector1 = [SpecialName] (tid, idx) => new
      {
        Key = $"@P{idx}",
        Value = tid
      };
    }
    IEnumerable<VB\u0024AnonymousType_0<string, int>> source2 = source1.Select(selector1);
    System.Func<VB\u0024AnonymousType_0<string, int>, string> keySelector;
    // ISSUE: reference to a compiler-generated field
    if (frmPolicyFCW._Closure\u0024__.\u0024I201\u002D1 != null)
    {
      // ISSUE: reference to a compiler-generated field
      keySelector = frmPolicyFCW._Closure\u0024__.\u0024I201\u002D1;
    }
    else
    {
      // ISSUE: reference to a compiler-generated field
      frmPolicyFCW._Closure\u0024__.\u0024I201\u002D1 = keySelector = [SpecialName] (tx) => tx.Key;
    }
    System.Func<VB\u0024AnonymousType_0<string, int>, int> elementSelector;
    // ISSUE: reference to a compiler-generated field
    if (frmPolicyFCW._Closure\u0024__.\u0024I201\u002D2 != null)
    {
      // ISSUE: reference to a compiler-generated field
      elementSelector = frmPolicyFCW._Closure\u0024__.\u0024I201\u002D2;
    }
    else
    {
      // ISSUE: reference to a compiler-generated field
      frmPolicyFCW._Closure\u0024__.\u0024I201\u002D2 = elementSelector = [SpecialName] (tx) => tx.Value;
    }
    Dictionary<string, int> dictionary = source2.ToDictionary(keySelector, elementSelector);
    string str1 = $"DELETE FROM dbo.tblQuoteFormsConditionsWarranties WHERE QuoteID = @QuoteID AND {columnName} IN ({string.Join(",", (IEnumerable<string>) dictionary.Keys)})";
    dictionary.Add("@QuoteID", this._quote.QuoteID);
    string str2 = str1;
    Dictionary<string, int> source3 = dictionary;
    System.Func<KeyValuePair<string, int>, IEnumerable<object>> selector2;
    // ISSUE: reference to a compiler-generated field
    if (frmPolicyFCW._Closure\u0024__.\u0024I201\u002D3 != null)
    {
      // ISSUE: reference to a compiler-generated field
      selector2 = frmPolicyFCW._Closure\u0024__.\u0024I201\u002D3;
    }
    else
    {
      // ISSUE: reference to a compiler-generated field
      frmPolicyFCW._Closure\u0024__.\u0024I201\u002D3 = selector2 = (System.Func<KeyValuePair<string, int>, IEnumerable<object>>) ([SpecialName] (kvp) => (IEnumerable<object>) new object[2]
      {
        (object) kvp.Key,
        (object) kvp.Value
      });
    }
    object[] array = source3.SelectMany<KeyValuePair<string, int>, object>(selector2).ToArray<object>();
    DefaultDatabase.ExecuteNonQuery(CommandType.Text, str2, array);
  }

  private void PrintForm(int formID, int placedByCompanyLineID)
  {
    dsPolicyFCW.tblPolicyFormsRow byFormId = this.ds.tblPolicyForms.FindByFormID(formID);
    DataRow dataRow = DefaultDatabase.ExecuteDataRow(CommandType.Text, "Select TemplateID, AutomationReportGuid, PDF, PDF_Filename FROM dbo.tblPolicyForms WITH(NOLOCK) WHERE FormID=@FormID", new object[2]
    {
      (object) "@FormID",
      (object) formID
    });
    CompanyDocumentAutomation objectAs;
    if (dataRow["TemplateID"] != DBNull.Value)
    {
      int num = (int) dataRow["TemplateID"];
      string str = byFormId != null ? byFormId.Field<string>("OncePer") : (string) null;
      objectAs = ObjectFactory.Instance.CreateObjectAs<CompanyDocumentAutomation>(new object[4]
      {
        (object) num,
        (object) placedByCompanyLineID,
        (object) formID,
        (object) (str ?? string.Empty)
      });
    }
    else if (dataRow["AutomationReportGuid"] != DBNull.Value)
      objectAs = ObjectFactory.Instance.CreateObjectAs<CompanyDocumentAutomation>(new object[2]
      {
        (object) (Guid) dataRow["AutomationReportGuid"],
        (object) placedByCompanyLineID
      });
    else if (dataRow["PDF"] != DBNull.Value)
    {
      objectAs = ObjectFactory.Instance.CreateObjectAs<CompanyDocumentAutomation>(new object[2]
      {
        (object) (byte[]) dataRow["PDF"],
        (object) (string) dataRow["PDF_Filename"]
      });
    }
    else
    {
      MessageBox.Show("This Is Not a printable document.", "Unprintable Document", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      return;
    }
    CompanyDocumentAutomation.Initialize();
    objectAs.QuoteGuid = this._quote.QuoteGuid;
    objectAs.PolicyFormId = formID;
    objectAs.CreatePDFPackage();
  }

  private void MarkFormAsNew(int formID)
  {
    DataRow[] dataRowArray = this.ds.tblQuoteFormsConditionsWarranties.Select("PolicyFormID=" + formID.ToString());
    if (dataRowArray == null || dataRowArray.Length <= 0 || MessageBox.Show("Are you sure you want To mark this form As New?", "Mark Form As New?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.Yes)
      return;
    dataRowArray[0].SetField<bool>("AllowDuplicates", true);
  }

  private void lnkCustom_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    using (FormSettings.ShowFormDialog(typeof (frmAdditionalWarranties), new object[2]
    {
      (object) this._quote.QuoteID,
      (object) ((UltraTabControlBase) this.ultraTabFCW).SelectedTab.Text
    }))
      ;
  }

  private void lnkRaterLog_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    using (FormSettings.ShowFormDialog(typeof (frmTextInfo), new object[2]
    {
      (object) this.statusSB.ToString(),
      (object) "Rater Conditionals Log"
    }))
      ;
  }

  private void ugGrids_MouseDown(object sender, MouseEventArgs e)
  {
    if (e.Button != MouseButtons.Right)
      return;
    UltraGrid ultraGrid = (UltraGrid) sender;
    UIElement lastElementEntered = ((ControlUIElementBase) ((UltraGridBase) ultraGrid).DisplayLayout.UIElement).LastElementEntered;
    if (lastElementEntered == null)
      return;
    UltraGridRow context = (UltraGridRow) lastElementEntered.GetContext(typeof (UltraGridRow), true);
    if (context == null)
      return;
    ((UltraGridBase) ultraGrid).ActiveRow = context;
    ultraGrid.Selected.Rows.Clear();
    context.Selected = true;
  }

  private void ApplyDefaultFCW()
  {
    if (this._quote == null || this._quote.IsIssued)
      return;
    if (!this.BlackBoxMode && !this._quote.PolicyFormsAutoApplied && CurrentUser.Instance != null)
      CurrentUser.Instance.LogAction("Applying Default FCW rules.", this._quote.QuoteGuid);
    DefaultDatabase.ExecuteNonQuery("dbo.[ApplyDefaultFormsConditionsWarranties]", new object[2]
    {
      (object) "@QuoteID",
      (object) this._quote.QuoteID
    });
  }

  private void btnCancel_Click(object sender, EventArgs e) => this.Close();

  private bool IsValidForm()
  {
    bool flag = true;
    foreach (UltraGridRow row in ((UltraGridBase) this.ugForms).Rows)
    {
      if ((bool) row.Cells["Applied"].Value && (bool) row.Cells["RequiresEndorsementNumber"].Value && row.Cells["EndorsementNum"].Value == DBNull.Value)
      {
        row.Appearance.BackColor = Color.MistyRose;
        flag = false;
      }
    }
    if (!flag)
      MessageBox.Show("Endorsement numbers are required For the highlighted policy forms.", "Endorsement Numbers Required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    return flag;
  }

  private void AddFCW(
    dsPolicyFCW.tblQuoteFormsConditionsWarrantiesDataTable dt,
    frmPolicyFCW.FCWTypes type)
  {
    string columnName1 = ((frmPolicyFCW.FCWNameColumns) type).ToString();
    DataTable dataTable;
    string columnName2;
    string columnName3;
    switch (type)
    {
      case frmPolicyFCW.FCWTypes.Form:
        dataTable = (DataTable) this.ds.tblPolicyForms;
        columnName2 = "PolicyFormID";
        columnName3 = "FormID";
        break;
      case frmPolicyFCW.FCWTypes.Condition:
        dataTable = (DataTable) this.ds.tblConditions;
        columnName2 = "ConditionID";
        columnName3 = "ConditionID";
        break;
      case frmPolicyFCW.FCWTypes.Warranty:
        dataTable = (DataTable) this.ds.tblWarranties;
        columnName2 = "WarrantyID";
        columnName3 = "WarrantyID";
        break;
      default:
        throw new InvalidOperationException("Unexpected type");
    }
    try
    {
      foreach (DataRow row1 in dataTable.Rows)
      {
        if (!ExtensionsMethods.FieldOrDefault<bool>(row1, "Hidden", false))
        {
          DataRow[] dataRowArray = this.ds.tblQuoteFormsConditionsWarranties.Select($"{columnName2}={row1[columnName3].ToString()}");
          dsPolicyFCW.tblQuoteFormsConditionsWarrantiesRow row2 = (dsPolicyFCW.tblQuoteFormsConditionsWarrantiesRow) null;
          if (dataRowArray.Length == 1)
            row2 = (dsPolicyFCW.tblQuoteFormsConditionsWarrantiesRow) dataRowArray[0];
          else if (dataRowArray.Length > 1)
            throw new InvalidOperationException($"Duplicate {columnName2}s detected");
          bool flag = (bool) row1["Applied"];
          string str1 = "";
          if (flag || !row1.IsNull("WaivedByUserGuid") || row2 != null && row2.Deleted)
          {
            dsPolicyFCW.tblQuoteFormsConditionsWarrantiesRow row3 = dt.NewtblQuoteFormsConditionsWarrantiesRow();
            switch (type)
            {
              case frmPolicyFCW.FCWTypes.Form:
                dsPolicyFCW.tblPolicyFormsRow row4 = (dsPolicyFCW.tblPolicyFormsRow) row1;
                if (row4.IsPolicyFormCommentsNull())
                  row3.SetPolicyFormCommentsNull();
                else
                  row3.PolicyFormComments = row4.PolicyFormComments;
                row3.AllowDuplicates = row2 != null && row2.AllowDuplicates;
                if (this._raterConditionalForms.ContainsKey(row4.FormID))
                  str1 = " rater form" + (string.IsNullOrEmpty(this._raterConditionalForms[row4.FormID]) ? "" : $" ({this._raterConditionalForms[row4.FormID]})");
                else if (!row4.IsAssociatedWarrantyIDNull())
                  str1 += $" with warranty {this.ds.tblWarranties.FindByWarrantyID(row4.AssociatedWarrantyID).WarrantyName}";
                else if (!row4.IsAssociatedFormIDNull())
                  str1 += $" with parent{(!row4.IsRaterIDNull() ? (object) " rater" : (object) string.Empty)} form {this.ds.tblPolicyForms.FindByFormID(row4.AssociatedFormID).FormName}";
                if (!row4.IsEndorsementNumNull())
                {
                  str1 += $" [#{row4.EndorsementNum}]";
                  row3.EndorsementNum = row4.EndorsementNum;
                }
                else
                  row3.SetEndorsementNumNull();
                row3.SetField<int?>("RaterID", row4.Field<int?>("RaterID"));
                row3.SetField<int?>("RaterConditionalID", row4.Field<int?>("RaterConditionalID"));
                break;
              case frmPolicyFCW.FCWTypes.Condition:
                dsPolicyFCW.tblConditionsRow row5 = (dsPolicyFCW.tblConditionsRow) row1;
                if (this._raterConditionalConditions.ContainsKey(row5.ConditionID))
                {
                  str1 = " rater condition";
                  if (!string.IsNullOrEmpty(this._raterConditionalConditions[row5.ConditionID]))
                    str1 += $" ({this._raterConditionalConditions[row5.ConditionID]})";
                }
                row3.SetField<int?>("RaterID", row5.Field<int?>("RaterID"));
                row3.SetField<int?>("RaterConditionalID", row5.Field<int?>("RaterConditionalID"));
                break;
            }
            string str2;
            if (row2 == null)
              str2 = flag ? "Added" : "Waived";
            else if (flag && (row2.Field<bool>("Deleted", DataRowVersion.Original) || !row2.IsWaivedByUserGuidNull()) && !row1.IsNull("AddedByUserGuid"))
              str2 = "Added";
            else if (!flag && !row2.Field<bool>("Deleted", DataRowVersion.Original) && row2.IsWaivedByUserGuidNull())
            {
              str2 = "Removed";
            }
            else
            {
              str2 = "";
              str1 = "";
            }
            if (!string.IsNullOrEmpty(str2))
              CurrentUser.Instance.LogAction($"{type.ToString()} - {row1[columnName1]}: {str2}{str1}", this._quote.QuoteGuid);
            row3[columnName2] = RuntimeHelpers.GetObjectValue(row1[columnName3]);
            row3.QuoteID = this._quote.QuoteID;
            row3.SetField<int?>("CompanyLineID", row1.Field<int?>("PlacedByCompanyLineID"));
            if (!row1.IsNull("Company_FCW_ID"))
              row3.Company_FCW_ID = row1.Field<int>("Company_FCW_ID");
            if (!row1.IsNull("WaivedByUserGuid"))
              row3.WaivedByUserGuid = row1.Field<Guid>("WaivedByUserGuid");
            if (!row1.IsNull("AddedByUserGuid"))
              row3.AddedByUserGuid = row1.Field<Guid>("AddedByUserGuid");
            if (row2 != null)
            {
              row3.Deleted = row2.Deleted;
              row3.Added = row2.Added;
              if (!row2.IsOriginalIDNull())
                row3.OriginalID = row2.OriginalID;
              else
                row3.SetOriginalIDNull();
            }
            dt.AddtblQuoteFormsConditionsWarrantiesRow(row3);
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

  private void SaveNetRateAdditionalComments()
  {
    if (this.ds.tblNetRateAdditionalData.Count <= 0)
      return;
    dsPolicyFCW.tblNetRateAdditionalDataRow additionalDataRow = this.ds.tblNetRateAdditionalData[0];
    additionalDataRow.QuoteGuid = this._quote.QuoteGuid;
    additionalDataRow.AdditionalComments = ((TextEditorControlBase) this.txtAdditionalComments).Text;
    DefaultDatabase.ExecuteNonQuery("spSaveNetRateAdditionalDataInfo", new object[4]
    {
      (object) "@quoteguid",
      (object) this._quote.QuoteGuid,
      (object) "@AdditionalComments",
      (object) ((TextEditorControlBase) this.txtAdditionalComments).Text
    });
  }

  private void btnSave_Click(object sender, EventArgs e)
  {
    if (!this.IsValidForm())
      return;
    Cursor.Current = MgaCursors.WaitCursor;
    ((Control) this.panelSaving).Visible = true;
    try
    {
      foreach (Control control in this.Controls)
      {
        if (!(control is UltraGroupBox))
          control.Enabled = false;
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    this.SaveData();
  }

  private bool ShouldShowAdditionalComments()
  {
    PolicyFCWSettingsOverride objectAs = ObjectFactory.Instance.CreateObjectAs<PolicyFCWSettingsOverride>(typeof (PolicyFCWSettingsOverride), new object[0]);
    return objectAs != null && objectAs.ShouldShowAdditionalComments(this.Quote);
  }

  private void SaveData()
  {
    if (!this.BlackBoxMode)
    {
      ((UltraGridBase) this.ugConditions).UpdateData();
      ((UltraGridBase) this.ugWarranties).UpdateData();
      ((UltraGridBase) this.ugForms).UpdateData();
      this.ugForms.PerformAction((UltraGridAction) 44);
    }
    dsPolicyFCW.tblQuoteFormsConditionsWarrantiesDataTable dt = new dsPolicyFCW.tblQuoteFormsConditionsWarrantiesDataTable();
    this.AddFCW(dt, frmPolicyFCW.FCWTypes.Form);
    this.AddFCW(dt, frmPolicyFCW.FCWTypes.Condition);
    this.AddFCW(dt, frmPolicyFCW.FCWTypes.Warranty);
    if (!this.BlackBoxMode && (this._quote.UsingNetRate || this.ShouldShowAdditionalComments()))
      this.SaveNetRateAdditionalComments();
    this._dataTable = dt;
    if (this.BlackBoxMode)
      this.UploadData((object) null);
    else
      ThreadPool.QueueUserWorkItem(new WaitCallback(this.UploadData));
  }

  private void SetProgressMax(int max)
  {
    if (this.BlackBoxMode)
      return;
    if (MDIControls.Instance.MDIParent.InvokeRequired)
      MDIControls.Instance.MDIParent.Invoke((Delegate) new Action<int>(this.SetProgressMax), (object) max);
    else
      this.progress.Maximum = max;
  }

  private void MoveProgress()
  {
    if (this.BlackBoxMode)
      return;
    if (MDIControls.Instance.MDIParent.InvokeRequired)
    {
      InvokeExtensions.BetterInvoke((ISynchronizeInvoke) MDIControls.Instance.MDIParent, (Delegate) new MethodInvoker(this.MoveProgress), new object[0]);
    }
    else
    {
      UltraProgressBar progress;
      int num = (progress = this.progress).Value + 1;
      progress.Value = num;
    }
  }

  private void CloseForm() => this.Close();

  private void HideLoadingPanel()
  {
    try
    {
      foreach (Control control in this.Controls)
      {
        if (!(control is UltraGroupBox))
          control.Enabled = true;
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    ((Control) this.panelSaving).Visible = false;
  }

  protected dsPolicyFCW.tblQuoteFormsConditionsWarrantiesRow GetAssociatedFCWRow(
    UltraGrid grid,
    UltraGridRow row)
  {
    DataRow[] dataRowArray;
    if (grid == this.ugForms)
      dataRowArray = this.ds.tblQuoteFormsConditionsWarranties.Select("PolicyFormID=" + row.Cells["FormID"].Value.ToString());
    else if (grid == this.ugConditions)
    {
      dataRowArray = this.ds.tblQuoteFormsConditionsWarranties.Select("ConditionID=" + row.Cells["ConditionID"].Value.ToString());
    }
    else
    {
      if (grid != this.ugWarranties)
        throw new InvalidOperationException("Invalid grid encountered");
      dataRowArray = this.ds.tblQuoteFormsConditionsWarranties.Select("WarrantyID=" + row.Cells["WarrantyID"].Value.ToString());
    }
    return dataRowArray.Length <= 0 ? (dsPolicyFCW.tblQuoteFormsConditionsWarrantiesRow) null : (dsPolicyFCW.tblQuoteFormsConditionsWarrantiesRow) dataRowArray[0];
  }

  private frmPolicyFCW.FCWTypes GetAssociatedFCWType(UltraGrid grid)
  {
    if (grid == this.ugForms)
      return frmPolicyFCW.FCWTypes.Form;
    if (grid == this.ugConditions)
      return frmPolicyFCW.FCWTypes.Condition;
    if (grid == this.ugWarranties)
      return frmPolicyFCW.FCWTypes.Warranty;
    throw new NotSupportedException("Grid type does not have associated FCW type");
  }

  [Obsolete("This was part of SetItemsChecked, which is now deprecated.")]
  protected DataRow GetBaseDataRow(
    dsPolicyFCW.tblQuoteFormsConditionsWarrantiesRow dr)
  {
    DataRow dataRow;
    string columnName;
    if (!dr.IsPolicyFormIDNull())
    {
      dataRow = (DataRow) dr.tblPolicyFormsRow;
      columnName = "PolicyFormID";
    }
    else if (!dr.IsConditionIDNull())
    {
      dataRow = (DataRow) dr.tblConditionsRow;
      columnName = "ConditionID";
    }
    else
    {
      dataRow = !dr.IsWarrantyIDNull() ? (DataRow) dr.tblWarrantiesRow : throw new InvalidOperationException("PolicyFormID, ConditionID, and WarrantyID are all null");
      columnName = "WarrantyID";
    }
    return dataRow != null ? dataRow : throw new InvalidOperationException($"Base row for {columnName} {RuntimeHelpers.GetObjectValue(dr[columnName])} does not exist");
  }

  public void ApplyForms()
  {
    this.ApplyDefaultFCW();
    this.FillData();
    this.ConfigureRaterConditionalForms();
    this.ConfigureRaterConditions();
    this.SaveData();
  }

  public void PreviewDocument(int docID)
  {
    DataRow row = DefaultDatabase.ExecuteDataRow(CommandType.Text, "Select TemplateID, AutomationReportGuid, PDF, PDF_Filename FROM tblPolicyForms WHERE FormID=@FormID", new object[2]
    {
      (object) "@FormID",
      (object) docID
    });
    int templateID;
    try
    {
      templateID = row.Field<int>("TemplateID");
    }
    catch (InvalidCastException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      int num = (int) MessageBox.Show($"No valid document available to preview.{Environment.NewLine}Preview only available for Word Documents (*.doc, *.docx)", "Invalid for Preview", MessageBoxButtons.OK);
      ProjectData.ClearProjectError();
      return;
    }
    string str = this.DownloadForPreview(templateID);
    if (str.Equals(string.Empty))
      return;
    using (FormSettings.ShowFormDialog(typeof (frmDocumentPreview), new object[1]
    {
      (object) str
    }))
      ;
  }

  public string DownloadForPreview(int templateID)
  {
    Cursor.Current = MgaCursors.WaitCursor;
    try
    {
      DataRow row = DefaultDatabase.ExecuteDataRow("spGetDocumentTemplate", new object[2]
      {
        (object) "@TID",
        (object) templateID
      });
      string path2 = row.Field<string>("OriginalFileName");
      char[] invalidFileNameChars = Path.GetInvalidFileNameChars();
      int index = 0;
      while (index < invalidFileNameChars.Length)
      {
        char ch = invalidFileNameChars[index];
        path2 = path2.Replace(Conversions.ToString(ch), string.Empty);
        checked { ++index; }
      }
      string path = Path.Combine(Path.GetTempPath(), path2);
      File.WriteAllBytes(path, row.Field<byte[]>("Template"));
      return path;
    }
    finally
    {
      Cursor.Current = MgaCursors.Default;
    }
  }

  protected virtual void AfterSave()
  {
  }

  protected virtual void CheckForEndorsementNumberGapsAndReorder()
  {
  }

  private void UltraToolbarsManager1_BeforeToolDropdown(
    object sender,
    BeforeToolDropdownEventArgs e)
  {
    this._toolGrid = e.SourceControl as UltraGrid;
    if (this._toolGrid == null && e.SourceControl is Control)
      this._toolGrid = e.SourceControl.Parent as UltraGrid;
    if (this._toolGrid != null && ((UltraGridBase) this._toolGrid).ActiveRow != null)
      return;
    ((CancelEventArgs) e).Cancel = true;
  }

  private void UltraToolbarsManager1_ToolClick(object sender, ToolClickEventArgs e)
  {
    UltraGrid toolGrid = this._toolGrid;
    int num;
    if (toolGrid == this.ugForms)
      num = (int) ((UltraGridBase) toolGrid).ActiveRow.Cells["FormID"].Value;
    else if (toolGrid == this.ugConditions)
      num = (int) ((UltraGridBase) toolGrid).ActiveRow.Cells["ConditionID"].Value;
    else if (toolGrid == this.ugWarranties)
      num = (int) ((UltraGridBase) toolGrid).ActiveRow.Cells["WarrantyID"].Value;
    string key = ((ToolEventArgs) e).Tool.Key;
    // ISSUE: reference to a compiler-generated method
    switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(key))
    {
      case 57464387:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Extract Tags", false) != 0)
          break;
        this.ExtractTags(num);
        break;
      case 3254019168:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Clear Rule", false) != 0)
          break;
        this.ClearRule(ref toolGrid);
        break;
      case 3384875262:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Mark as New", false) != 0)
          break;
        this.MarkFormAsNew(num);
        break;
      case 3895594280:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Print", false) != 0)
          break;
        int placedByCompanyLineID = (int) ((UltraGridBase) this.ugForms).ActiveRow.Cells["PlacedByCompanyLineID"].Value;
        this.PrintForm(num, placedByCompanyLineID);
        break;
      case 4071670757:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Reset Record", false) != 0)
          break;
        this.ResetRecord(ref toolGrid);
        break;
      case 4188720709:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Undelete", false) != 0)
          break;
        this.Undelete();
        break;
      case 4258942199:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Preview", false) != 0)
          break;
        this.PreviewDocument(num);
        break;
    }
  }

  private void ExtractTags(int formID)
  {
    DataRow dataRow = DefaultDatabase.ExecuteDataRow(CommandType.Text, "SELECT TemplateID, AutomationReportGuid, PDF, PDF_Filename FROM tblPolicyForms WHERE FormID=@FormID", new object[2]
    {
      (object) "@FormID",
      (object) formID
    });
    List<DocTag> docTagList = new List<DocTag>();
    if (dataRow["TemplateID"] != DBNull.Value)
    {
      List<DocTag> tags = DocumentHandling.ExtractTags((int) dataRow["TemplateID"]);
      if (tags.Count > 0)
        FormSettings.ShowForm(typeof (frmTagExtractor), new object[2]
        {
          (object) tags,
          (object) this.Quote.QuoteGuid
        });
      else
        MessageBox.Show("This document has no template tags.", "No tags found.", MessageBoxButtons.OK, MessageBoxIcon.None);
    }
    else
      MessageBox.Show("This is not a template document.", "Non-Template Document", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
  }

  private Document GetTemplateDocument(int templateID)
  {
    string path = Path.GetTempFileName() + ".doc";
    byte[] array = DefaultDatabase.ExecuteScalar<byte[]>(CommandType.Text, "SELECT Template FROM tblDocumentTemplates (NOLOCK) WHERE TemplateID=@TID", new object[2]
    {
      (object) "@TID",
      (object) templateID
    });
    using (FileStream fileStream = new FileStream(path, FileMode.Create))
    {
      fileStream.Write(array, 0, array.Length);
      fileStream.Close();
    }
    return new Document(path);
  }

  private Document GetAutomationDocument(Guid autoRptGuid)
  {
    string str = Path.GetTempFileName() + ".doc";
    return (Document) null;
  }

  private void Undelete()
  {
    if (this._quote.IsIssued)
      return;
    dsPolicyFCW.tblQuoteFormsConditionsWarrantiesRow associatedFcwRow = this.GetAssociatedFCWRow(this.ugForms, ((UltraGridBase) this.ugForms).ActiveRow);
    if (associatedFcwRow == null || MessageBox.Show("Are you sure you want to undelete this form?", "Undelete?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.Yes)
      return;
    DefaultDatabase.ExecuteNonQuery(CommandType.Text, "UPDATE tblQuoteFormsConditionsWarranties SET Deleted=0 WHERE Quote_FCW_ID=@ID", new object[2]
    {
      (object) "@ID",
      (object) associatedFcwRow.Quote_FCW_ID
    });
    associatedFcwRow.Deleted = false;
    UltraGridRow activeRow = ((UltraGridBase) this.ugForms).ActiveRow;
    activeRow.Appearance.ForeColor = Color.Black;
    activeRow.Appearance.FontData.Strikeout = (DefaultableBoolean) 2;
  }

  private void ResetRecord(ref UltraGrid grid)
  {
    if (this._quote.IsIssued)
      return;
    dsPolicyFCW.tblQuoteFormsConditionsWarrantiesRow associatedFcwRow = this.GetAssociatedFCWRow(grid, ((UltraGridBase) grid).ActiveRow);
    if (associatedFcwRow == null)
      return;
    DataRow row = ((DataRowView) ((UltraGridBase) grid).ActiveRow.ListObject).Row;
    if (row == null)
      return;
    DefaultDatabase.ExecuteNonQuery(CommandType.Text, "DELETE FROM tblQuoteFormsConditionsWarranties WHERE Quote_FCW_ID=@ID", new object[2]
    {
      (object) "@ID",
      (object) associatedFcwRow.Quote_FCW_ID
    });
    frmPolicyFCW.FCWTypes associatedFcwType = this.GetAssociatedFCWType(grid);
    CurrentUser.Instance.LogAction($"Resetting record for {associatedFcwType.ToString()} - {row.Field<string>(((frmPolicyFCW.FCWNameColumns) associatedFcwType).ToString())}", this._quote.QuoteGuid);
    associatedFcwRow.Delete();
    associatedFcwRow.AcceptChanges();
    row.SetField<bool>("Applied", false);
    row.SetField<Guid?>("AddedByUserGuid", new Guid?());
    row.SetField<Guid?>("WaivedByUserGuid", new Guid?());
    row.SetField<int?>("Company_FCW_ID", new int?());
    if (row.Table.Columns.Contains("LineName"))
      row.SetField<string>("LineName", (string) null);
    row.AcceptChanges();
    UltraGridRow activeRow = ((UltraGridBase) grid).ActiveRow;
    activeRow.Appearance.ForeColor = Color.Black;
    activeRow.Appearance.FontData.Strikeout = (DefaultableBoolean) 2;
    activeRow.Appearance.FontData.Italic = (DefaultableBoolean) 2;
  }

  private void ClearRule(ref UltraGrid grid)
  {
    if (this._quote.IsIssued)
      return;
    dsPolicyFCW.tblQuoteFormsConditionsWarrantiesRow associatedFcwRow = this.GetAssociatedFCWRow(grid, ((UltraGridBase) grid).ActiveRow);
    if (associatedFcwRow == null)
      return;
    DataRow row = ((DataRowView) ((UltraGridBase) grid).ActiveRow.ListObject).Row;
    if (row == null || row.IsNull("Company_FCW_ID"))
      return;
    DefaultDatabase.ExecuteNonQuery(CommandType.Text, "UPDATE tblQuoteFormsConditionsWarranties SET Company_FCW_ID = NULL WHERE Quote_FCW_ID=@ID", new object[2]
    {
      (object) "@ID",
      (object) associatedFcwRow.Quote_FCW_ID
    });
    frmPolicyFCW.FCWTypes associatedFcwType = this.GetAssociatedFCWType(grid);
    CurrentUser.Instance.LogAction($"Clearing associated rule for {associatedFcwType.ToString()} - {row.Field<string>(((frmPolicyFCW.FCWNameColumns) associatedFcwType).ToString())}", this._quote.QuoteGuid);
    row.SetField<int?>("Company_FCW_ID", new int?());
    if (!row.Table.Columns.Contains("LineName"))
      return;
    row.SetField<string>("LineName", (string) null);
  }

  private void UploadData(object state)
  {
    // ISSUE: variable of a compiler-generated type
    frmPolicyFCW._Closure\u0024__238\u002D0 closure2380_1;
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    frmPolicyFCW._Closure\u0024__238\u002D0 closure2380_2 = new frmPolicyFCW._Closure\u0024__238\u002D0(closure2380_1);
    // ISSUE: reference to a compiler-generated field
    closure2380_2.\u0024VB\u0024Local_serverTime = this.BlackBoxMode ? DefaultDatabase.ExecuteScalar<DateTime>(CommandType.Text, "SELECT GETDATE()") : CurrentUser.ServerTime;
    this.SetProgressMax(2);
    // ISSUE: reference to a compiler-generated method
    XElement xelement1 = new XElement((XName) "QuoteForms", (object) this._dataTable.AsEnumerable<dsPolicyFCW.tblQuoteFormsConditionsWarrantiesRow>().Select<dsPolicyFCW.tblQuoteFormsConditionsWarrantiesRow, XElement>(new System.Func<dsPolicyFCW.tblQuoteFormsConditionsWarrantiesRow, XElement>(closure2380_2._Lambda\u0024__0)));
    try
    {
      foreach (XElement xelement2 in xelement1.Descendants().ToList<XElement>())
      {
        if (xelement2.IsEmpty || string.IsNullOrEmpty(xelement2.Value))
          xelement2.Remove();
      }
    }
    finally
    {
      List<XElement>.Enumerator enumerator;
      enumerator.Dispose();
    }
    this.MoveProgress();
    try
    {
      DefaultDatabase.ExecuteNonQuery("dbo.spFCW_UpdateData", new object[4]
      {
        (object) "@QuoteID",
        (object) this._quote.QuoteID,
        (object) "@fcwXml",
        (object) xelement1.ToString()
      });
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      Exception exception = ex;
      if (exception.Message.Contains("IX_tblQuoteFormsConditionsWarranties"))
      {
        if (this.BlackBoxMode)
          throw new InvalidOperationException("One or more policy forms could not be saved, because they are duplicates.");
        int num = (int) MessageBox.Show("One or more policy forms could not be saved, because they are duplicates.\n\nPlease check the policy forms setup to ensure there are no duplicates configured.", "Duplicate Forms Detected", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      }
      else
      {
        if (this.BlackBoxMode)
          throw;
        ErrorHandler.HandleErrorOnThread((Control) MDIControls.Instance.MDIParent, exception);
        InvokeExtensions.BetterInvoke((ISynchronizeInvoke) MDIControls.Instance.MDIParent, (Delegate) new MethodInvoker(this.CloseForm), new object[0]);
      }
      ProjectData.ClearProjectError();
      return;
    }
    this.MoveProgress();
    this.AfterSave();
    if (this.BlackBoxMode)
      return;
    InvokeExtensions.BetterInvoke((ISynchronizeInvoke) MDIControls.Instance.MDIParent, (Delegate) new MethodInvoker(this.CloseForm), new object[0]);
  }

  private void ugForms_BeforeCellActivate(object sender, CancelableCellEventArgs e)
  {
    if (e.Cell == null || e.Cell.Row == null || !e.Cell.Column.Key.Equals("Applied") || this._AllowRemovalOfAutoAppliedForm && this._AllowRemovalOfMandatoryForm)
      return;
    dsPolicyFCW.tblQuoteFormsConditionsWarrantiesRow associatedFcwRow = this.GetAssociatedFCWRow((UltraGrid) sender, e.Cell.Row);
    dsPolicyFCW.tblPolicyFormsRow tblPolicyFormsRow = associatedFcwRow?.tblPolicyFormsRow ?? (e.Cell.Row.ListObject is DataRowView listObject ? listObject.Row : (DataRow) null) as dsPolicyFCW.tblPolicyFormsRow;
    if (tblPolicyFormsRow == null || !tblPolicyFormsRow.Applied || !tblPolicyFormsRow.IsAddedByUserGuidNull())
      return;
    if (associatedFcwRow != null && !associatedFcwRow.IsPolicyFormIDNull() && associatedFcwRow.IsAddedByUserGuidNull() && !this._AllowRemovalOfAutoAppliedForm)
    {
      MessageBox.Show("You do not have the required security to remove auto-selected forms.", "Insufficient Security", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      ((CancelEventArgs) e).Cancel = true;
    }
    else
    {
      if (!tblPolicyFormsRow.Mandatory || this._AllowRemovalOfMandatoryForm)
        return;
      MessageBox.Show("You do not have the required security to remove mandatory forms.", "Insufficient Security", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      ((CancelEventArgs) e).Cancel = true;
    }
  }

  private void ugForms_BeforeExitEditMode(object sender, BeforeExitEditModeEventArgs e)
  {
    if (e.CancellingEditOperation || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.ugForms.ActiveCell.Column.Key, "EndorsementNum", false) != 0 || Conversions.ToBoolean(((UltraGridBase) this.ugForms).ActiveRow.Cells["Applied"].Text) && (Versioned.IsNumeric((object) this.ugForms.ActiveCell.Text) || this._allowNonNumericEndorsement.Value))
      return;
    this.ugForms.ActiveCell.CancelUpdate();
  }

  private void CellChange(object sender, CellEventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(e.Cell.Column.Key, "PolicyFormComments", false) == 0)
      return;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(e.Cell.Column.Key, "EndorsementNum", false) == 0 && !this._useNewEndorsementNumCheck.Value)
    {
      e.Cell.CancelUpdate();
    }
    else
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(e.Cell.Column.Key, "Applied", false) != 0)
        return;
      if (sender != this.ugWarranties && Conversions.ToBoolean(e.Cell.Row.Cells["Hidden"]?.Value ?? (object) false))
      {
        e.Cell.CancelUpdate();
      }
      else
      {
        bool boolean = Conversions.ToBoolean(e.Cell.Row.Cells["Applied"].Text);
        dsPolicyFCW.tblQuoteFormsConditionsWarrantiesRow associatedFcwRow = this.GetAssociatedFCWRow((UltraGrid) sender, e.Cell.Row);
        bool flag1 = false;
        bool flag2 = true;
        string empty = string.Empty;
        if (associatedFcwRow != null)
          flag1 = !associatedFcwRow.IsOriginalIDNull();
        if (flag1)
        {
          if (!boolean)
          {
            if (MessageBox.Show("This item was applied on a previous version of this policy.\n\nAre you sure you want to remove this item from the policy?", "Remove Item?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
              UltraGridRow row = e.Cell.Row;
              row.Appearance.ForeColor = Color.Red;
              row.Appearance.FontData.Strikeout = (DefaultableBoolean) 1;
              associatedFcwRow.Deleted = true;
            }
            else
            {
              e.Cell.Row.Cells["Applied"].Value = (object) true;
              return;
            }
          }
          else
          {
            UltraGridRow row = e.Cell.Row;
            row.Appearance.ForeColor = Color.Black;
            row.Appearance.FontData.Strikeout = (DefaultableBoolean) 2;
            associatedFcwRow.Deleted = false;
          }
        }
        if (sender == this.ugWarranties)
        {
          int num = (int) e.Cell.Row.Cells["WarrantyID"].Value;
          string Left = (boolean ? this.CheckWarranty(num) : this.UncheckWarranty(num)) + this.ConfigureWarrantiesAndForms(num, boolean);
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, string.Empty, false) != 0)
            MessageBox.Show($"The following forms were {(boolean ? "added" : "removed along")} with this warranty:\n\n{Left}", boolean ? "Associated Forms" : "Removed Forms", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        else if (sender == this.ugForms)
        {
          int num = (int) e.Cell.Row.Cells["FormID"].Value;
          if (boolean)
          {
            if ((bool) e.Cell.Row.Cells["RequiresEndorsementNumber"].Value)
              e.Cell.Row.Cells["EndorsementNum"].Value = (object) this.GetFormEndorsementNumber(num);
            this.CheckPolicyForm(num);
          }
          else if (flag2)
          {
            e.Cell.Row.Cells["EndorsementNum"].Value = (object) DBNull.Value;
            this.UncheckPolicyForm(num);
            if (associatedFcwRow == null && !this._raterConditionalForms.ContainsKey(num))
              e.Cell.Row.Cells["AddedByUserGuid"].Value = (object) DBNull.Value;
          }
          this.ds.tblPolicyForms.FindByFormID(num).SetAssociatedWarrantyIDNull();
          this.ds.tblPolicyForms.FindByFormID(num).SetAssociatedFormIDNull();
        }
        else if (sender == this.ugConditions)
        {
          int key = (int) e.Cell.Row.Cells["ConditionID"].Value;
          if (!boolean && associatedFcwRow == null && !this._raterConditionalConditions.ContainsKey(key))
            e.Cell.Row.Cells["AddedByUserGuid"].Value = (object) DBNull.Value;
        }
        if (associatedFcwRow == null && (sender != this.ugForms || !this._raterConditionalForms.ContainsKey((int) e.Cell.Row.Cells["FormID"].Value)) && (sender != this.ugConditions || !this._raterConditionalConditions.ContainsKey((int) e.Cell.Row.Cells["ConditionID"].Value)))
          e.Cell.Row.Cells["AddedByUserGuid"].Value = (object) DBNull.Value;
        e.Cell.Row.Cells["WaivedByUserGuid"].Value = RuntimeHelpers.GetObjectValue(boolean ? (object) DBNull.Value : (object) CurrentUser.Instance.UserGUID);
        if (!boolean)
          return;
        e.Cell.Row.Cells["AddedByUserGuid"].Value = (object) CurrentUser.Instance.UserGUID;
      }
    }
  }

  protected virtual string GetFormEndorsementNumber(int formId)
  {
    List<int> intList = new List<int>();
    int num = 0;
    try
    {
      foreach (dsPolicyFCW.tblPolicyFormsRow tblPolicyForm in (TypedTableBase<dsPolicyFCW.tblPolicyFormsRow>) this.ds.tblPolicyForms)
      {
        int result;
        if (tblPolicyForm.FormID != formId && int.TryParse(tblPolicyForm.Field<string>("EndorsementNum"), out result))
        {
          if (result > num)
            num = result;
          intList.Add(result);
        }
      }
    }
    finally
    {
      IEnumerator<dsPolicyFCW.tblPolicyFormsRow> enumerator;
      enumerator?.Dispose();
    }
    string endorsementNumber = (num + 1).ToString();
    if (intList.Count > 0)
    {
      intList.Sort();
      IEnumerable<int> source = Enumerable.Range(1, intList.Max()).Except<int>((IEnumerable<int>) intList);
      if (source.Count<int>() > 0)
        endorsementNumber = source.First<int>().ToString();
    }
    return endorsementNumber;
  }

  private string CheckWarranty(int warrantyID)
  {
    StringBuilder stringBuilder = new StringBuilder();
    DataRow[] dataRowArray = this.ds.tblWarrantyForms.Select("WarrantyID=" + warrantyID.ToString());
    int index = 0;
    while (index < dataRowArray.Length)
    {
      dsPolicyFCW.tblPolicyFormsRow byFormId = this.ds.tblPolicyForms.FindByFormID(((dsPolicyFCW.tblWarrantyFormsRow) dataRowArray[index]).PolicyFormID);
      if (!byFormId.Applied)
      {
        byFormId.Applied = true;
        byFormId.SetWaivedByUserGuidNull();
        byFormId.AddedByUserGuid = CurrentUser.Instance.UserGUID;
        byFormId.AssociatedWarrantyID = warrantyID;
        byFormId.SetAssociatedFormIDNull();
        if (byFormId.RequiresEndorsementNumber)
          byFormId.EndorsementNum = this.GetFormEndorsementNumber(byFormId.FormID);
        stringBuilder.Append(byFormId.FormName + "\n");
      }
      checked { ++index; }
    }
    return stringBuilder.ToString();
  }

  private string UncheckWarranty(int warrantyID)
  {
    StringBuilder stringBuilder = new StringBuilder();
    DataRow[] dataRowArray = this.ds.tblWarrantyForms.Select("WarrantyID=" + warrantyID.ToString());
    int index = 0;
    while (index < dataRowArray.Length)
    {
      dsPolicyFCW.tblWarrantyFormsRow warrantyFormsRow = (dsPolicyFCW.tblWarrantyFormsRow) dataRowArray[index];
      if (this.UnapplyPolicyForm(warrantyID, warrantyFormsRow.PolicyFormID))
      {
        dsPolicyFCW.tblPolicyFormsRow byFormId = this.ds.tblPolicyForms.FindByFormID(warrantyFormsRow.PolicyFormID);
        if (byFormId.Applied)
        {
          byFormId.Applied = false;
          byFormId.WaivedByUserGuid = CurrentUser.Instance.UserGUID;
          byFormId.SetAddedByUserGuidNull();
          byFormId.AssociatedWarrantyID = warrantyID;
          byFormId.SetAssociatedFormIDNull();
          stringBuilder.Append(byFormId.FormName + "\n");
        }
      }
      checked { ++index; }
    }
    return stringBuilder.ToString();
  }

  private void CheckPolicyForm(int formID, int? raterID = null)
  {
    dsPolicyFCW.tblPolicyFormsRow[] tblPolicyFormsRowArray1 = (dsPolicyFCW.tblPolicyFormsRow[]) this.ds.tblPolicyForms.Select("ParentFormID=" + formID.ToString());
    if (tblPolicyFormsRowArray1 != null && tblPolicyFormsRowArray1.Length > 0)
    {
      StringBuilder stringBuilder = new StringBuilder();
      stringBuilder.Append("The following forms were also added with this form:\n\n");
      dsPolicyFCW.tblPolicyFormsRow[] tblPolicyFormsRowArray2 = tblPolicyFormsRowArray1;
      int index = 0;
      while (index < tblPolicyFormsRowArray2.Length)
      {
        dsPolicyFCW.tblPolicyFormsRow tblPolicyFormsRow1 = tblPolicyFormsRowArray2[index];
        if (!raterID.HasValue || tblPolicyFormsRow1.IsAddedByUserGuidNull() && tblPolicyFormsRow1.IsWaivedByUserGuidNull())
        {
          dsPolicyFCW.tblPolicyFormsRow tblPolicyFormsRow2 = tblPolicyFormsRow1;
          tblPolicyFormsRow2.Applied = true;
          tblPolicyFormsRow2.SetWaivedByUserGuidNull();
          tblPolicyFormsRow2.SetAssociatedWarrantyIDNull();
          tblPolicyFormsRow2.AssociatedFormID = formID;
          if (raterID.HasValue)
          {
            this.SetStatusText("--Applied child rater form " + tblPolicyFormsRow1.FormName);
            tblPolicyFormsRow2.RaterID = raterID.Value;
          }
          else
            tblPolicyFormsRow2.AddedByUserGuid = CurrentUser.Instance.UserGUID;
          stringBuilder.Append(tblPolicyFormsRow2.FormName + "\n");
        }
        checked { ++index; }
      }
      if (!raterID.HasValue)
        MessageBox.Show(stringBuilder.ToString(), "Additional Forms Added", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    this.CheckForEndorsementNumberGapsAndReorder();
  }

  private void UncheckPolicyForm(int formID)
  {
    dsPolicyFCW.tblPolicyFormsRow[] tblPolicyFormsRowArray = (dsPolicyFCW.tblPolicyFormsRow[]) this.ds.tblPolicyForms.Select("Applied = 1 AND ParentFormID=" + formID.ToString());
    if (tblPolicyFormsRowArray != null && tblPolicyFormsRowArray.Length > 0)
    {
      StringBuilder stringBuilder = new StringBuilder();
      stringBuilder.Append("The following forms were also added with this form:\n\n");
      int num1 = tblPolicyFormsRowArray.Length - 1;
      for (int index = 0; index <= num1; ++index)
        stringBuilder.Append(tblPolicyFormsRowArray[index].FormName + "\n");
      stringBuilder.Append("Would you like to remove these forms also?");
      bool flag = MessageBox.Show(stringBuilder.ToString(), "Remove Additional Forms?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
      int num2 = tblPolicyFormsRowArray.Length - 1;
      for (int index = 0; index <= num2; ++index)
      {
        dsPolicyFCW.tblPolicyFormsRow tblPolicyFormsRow = tblPolicyFormsRowArray[index];
        if (flag)
        {
          tblPolicyFormsRow.Applied = false;
          tblPolicyFormsRow.WaivedByUserGuid = CurrentUser.Instance.UserGUID;
          tblPolicyFormsRow.SetAssociatedWarrantyIDNull();
          tblPolicyFormsRow.AssociatedFormID = formID;
        }
        else
          tblPolicyFormsRow.SetAssociatedFormIDNull();
      }
    }
    this.CheckForEndorsementNumberGapsAndReorder();
  }

  private bool UnapplyPolicyForm(int warrantyID, int policyFormID)
  {
    DataRow[] dataRowArray = this.ds.tblWarrantyForms.Select($"PolicyFormID = {Conversions.ToString(policyFormID)} AND WarrantyID <> {Conversions.ToString(warrantyID)}");
    int index = 0;
    bool flag;
    while (index < dataRowArray.Length)
    {
      dsPolicyFCW.tblWarrantiesRow byWarrantyId = this.ds.tblWarranties.FindByWarrantyID(((dsPolicyFCW.tblWarrantyFormsRow) dataRowArray[index]).WarrantyID);
      if (byWarrantyId != null && byWarrantyId.Applied)
      {
        flag = false;
        goto label_6;
      }
      checked { ++index; }
    }
    flag = true;
label_6:
    return flag;
  }

  private void ugForms_MouseEnterElement(object sender, UIElementEventArgs e)
  {
    if (!(e.Element is RowUIElement))
      return;
    UltraGridRow row = ((RowUIElement) e.Element).Row;
    if (!this._lastLoadTime.Equals(DateTime.MinValue) && DateAndTime.Now.Subtract(this._lastLoadTime).Seconds < 1 && row.Cells["FormType"].Value == DBNull.Value)
      return;
    this._lastLoadTime = DateAndTime.Now;
    string str;
    if (row.Cells["FormType"].Value != DBNull.Value)
    {
      str = Conversions.ToString(row.Cells["FormType"].Value);
    }
    else
    {
      str = DefaultDatabase.ExecuteScalar<string>(CommandType.Text, "SELECT dbo.GetFormDocumentName(@FormID)", new object[2]
      {
        (object) "@FormID",
        row.Cells["FormID"].Value
      });
      row.Cells["FormType"].Value = (object) str;
      row.Update();
    }
    if (row.Cells["OncePer"].Value != DBNull.Value)
      str += $" (Once Per: {RuntimeHelpers.GetObjectValue(row.Cells["OncePer"].Value)})";
    if (row.Cells["WaivedByUserGuid"].Value != DBNull.Value)
      str += $"{"\n"}{"\n"}Waived By: {this.ds.tblUsers.FindByUserGUID((Guid) row.Cells["WaivedByUserGuid"].Value).User}";
    if (row.Cells["AddedByUserGuid"].Value != DBNull.Value)
      str += $"{"\n"}{"\n"}Added By: {this.ds.tblUsers.FindByUserGUID((Guid) row.Cells["AddedByUserGuid"].Value).User}";
    if (row.Cells["RequiresEdit"].Value != DBNull.Value && Conversions.ToBoolean(row.Cells["RequiresEdit"].Value))
      str += $"{"\n"}{"\n"}Requires Edit";
    if (Conversions.ToBoolean(row.Cells["Hidden"]?.Value ?? (object) false))
      str = $"Filtered by Condition{"\n"}{"\n"}{str}";
    this.UltraToolTipManager1.SetUltraToolTip((Control) this.ugForms, new UltraToolTipInfo(str, (ToolTipImage) 3, "Form Information", (DefaultableBoolean) 1));
    this.UltraToolTipManager1.ShowToolTip((Control) this.ugForms);
  }

  private void ugForms_MouseLeaveElement(object sender, UIElementEventArgs e)
  {
    if (!(e.Element is RowUIElement))
      return;
    this.UltraToolTipManager1.HideToolTip();
    this.UltraToolTipManager1.SetUltraToolTip((Control) this.ugForms, (UltraToolTipInfo) null);
  }

  private void lnkClearEndorsementNumbers_LinkClicked(
    object sender,
    LinkLabelLinkClickedEventArgs e)
  {
    if (MessageBox.Show("Continue to clear all Endorsement #s on Applied forms?", "Clear Endorsement #s", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
      return;
    try
    {
      foreach (dsPolicyFCW.tblPolicyFormsRow row in this.ds.tblPolicyForms.Rows)
      {
        if (row.RowState != DataRowState.Deleted && row.Applied)
        {
          row.SetEndorsementNumNull();
          row.RequiresEndorsementNumber = false;
        }
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    ((UltraGridBase) this.ugForms).UpdateData();
  }

  private void ApplyGridFilters()
  {
    ((UltraGridBase) this.ugForms).DisplayLayout.Bands[0].Columns["FormName"].AllowRowFiltering = (DefaultableBoolean) 1;
    ((UltraGridBase) this.ugForms).DisplayLayout.Bands[0].Columns["Description"].AllowRowFiltering = (DefaultableBoolean) 1;
    ((UltraGridBase) this.ugForms).DisplayLayout.Bands[0].Columns["FormNumber"].AllowRowFiltering = (DefaultableBoolean) 1;
    ((UltraGridBase) this.ugForms).DisplayLayout.Bands[0].Columns["Comments"].AllowRowFiltering = (DefaultableBoolean) 1;
    ((UltraGridBase) this.ugForms).DisplayLayout.Bands[0].ColumnFilters["Hidden"].FilterConditions.Add((FilterComparisionOperator) 1, (object) true);
    ((UltraGridBase) this.ugConditions).DisplayLayout.Bands[0].ColumnFilters["Hidden"].FilterConditions.Add((FilterComparisionOperator) 1, (object) true);
    ((UltraGridBase) this.ugForms).DisplayLayout.Bands[0].Columns["LineName"].AllowRowFiltering = (DefaultableBoolean) 1;
  }

  private void txtFormsFilter_TextChanged(object sender, EventArgs e)
  {
    this.ApplyFilter(((TextEditorControlBase) this.txtFormsFilter).Text, "FormName");
  }

  private void txtDescriptionFilter_TextChanged(object sender, EventArgs e)
  {
    this.ApplyFilter(((TextEditorControlBase) this.txtDescriptionFilter).Text, "Description");
  }

  private void txtFormNumberFilter_TextChanged(object sender, EventArgs e)
  {
    this.ApplyFilter(((TextEditorControlBase) this.txtFormNumberFilter).Text, "FormNumber");
  }

  private void txtCommentsFilter_TextChanged(object sender, EventArgs e)
  {
    this.ApplyFilter(((TextEditorControlBase) this.txtCommentsFilter).Text, "Comments");
  }

  private void ApplyFilter(string containsString, string columnName)
  {
    if (!this._useFcwInclusiveFiltering.Value)
    {
      foreach (UltraGridRow row in ((UltraGridBase) this.ugForms).Rows)
        row.Hidden = !string.IsNullOrEmpty(containsString) && (Utility.IsNull(RuntimeHelpers.GetObjectValue(row.Cells[columnName].Value)) || !frmDocumentTemplates.ContainsCaseInsensitive(row.Cells[columnName].Value.ToString(), containsString));
    }
    else
    {
      string str1 = ((TextEditorControlBase) this.txtFormsFilter).Text.Replace(" ", string.Empty).ToString();
      string str2 = ((TextEditorControlBase) this.txtDescriptionFilter).Text.Replace(" ", string.Empty).ToString();
      string str3 = ((TextEditorControlBase) this.txtFormNumberFilter).Text.Replace(" ", string.Empty).ToString();
      string str4 = ((TextEditorControlBase) this.txtCommentsFilter).Text.Replace(" ", string.Empty).ToString();
      foreach (UltraGridRow row in ((UltraGridBase) this.ugForms).Rows)
      {
        bool flag1 = !Utility.IsNull(RuntimeHelpers.GetObjectValue(row.Cells["FormName"].Value));
        bool flag2 = !Utility.IsNull(RuntimeHelpers.GetObjectValue(row.Cells["Description"].Value));
        bool flag3 = !Utility.IsNull(RuntimeHelpers.GetObjectValue(row.Cells["FormNumber"].Value));
        bool flag4 = !Utility.IsNull(RuntimeHelpers.GetObjectValue(row.Cells["Comments"].Value));
        bool flag5 = true;
        bool flag6 = true;
        bool flag7 = true;
        bool flag8 = true;
        if (string.IsNullOrEmpty(str1) && string.IsNullOrEmpty(str2) && string.IsNullOrEmpty(str3) && string.IsNullOrEmpty(str4))
          row.Hidden = false;
        else if (!flag1 && !flag2 && !flag3 && !flag4)
        {
          row.Hidden = false;
        }
        else
        {
          if (!string.IsNullOrEmpty(str1))
            flag5 = flag1 && frmDocumentTemplates.ContainsCaseInsensitive(row.Cells["FormName"].Value.ToString(), str1);
          if (!string.IsNullOrEmpty(str2))
            flag6 = flag2 && frmDocumentTemplates.ContainsCaseInsensitive(row.Cells["Description"].Value.ToString(), str2);
          if (!string.IsNullOrEmpty(str3))
            flag7 = flag1 && frmDocumentTemplates.ContainsCaseInsensitive(row.Cells["FormNumber"].Value.ToString(), str3);
          if (!string.IsNullOrEmpty(str4))
            flag8 = flag4 && frmDocumentTemplates.ContainsCaseInsensitive(row.Cells["Comments"].Value.ToString(), str4);
          row.Hidden = !flag5 || !flag6 || !flag7 || !flag8;
        }
      }
    }
  }

  private void ugForms_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Space || sender != this.ugForms || ((UltraGridBase) this.ugForms).ActiveRow.Cells["EndorsementNum"].IsActiveCell || ((UltraGridBase) this.ugForms).ActiveRow.Cells["PolicyFormComments"].IsActiveCell)
      return;
    this.PreviewDocument((int) ((UltraGridBase) this.ugForms).ActiveRow.Cells["FormID"].Value);
  }

  private void chkShowHidden_CheckedChanged(object sender, EventArgs e)
  {
    if (this.chkShowHidden.Checked)
    {
      ((UltraGridBase) this.ugForms).DisplayLayout.Bands[0].ColumnFilters["Hidden"].ClearFilterConditions();
      ((UltraGridBase) this.ugConditions).DisplayLayout.Bands[0].ColumnFilters["Hidden"].ClearFilterConditions();
    }
    else
    {
      ((UltraGridBase) this.ugForms).DisplayLayout.Bands[0].ColumnFilters["Hidden"].FilterConditions.Add((FilterComparisionOperator) 1, (object) true);
      ((UltraGridBase) this.ugConditions).DisplayLayout.Bands[0].ColumnFilters["Hidden"].FilterConditions.Add((FilterComparisionOperator) 1, (object) true);
    }
  }

  private void ugForms_InitializeLayout(object sender, InitializeLayoutEventArgs e)
  {
    e.Layout.Bands[0].Columns["FormType"].Hidden = !SystemSettings.GetSetting<bool>("Policy.FCW.ShowFormTypesColumn", false);
  }

  private enum FCWTypes
  {
    Form = 1,
    Condition = 2,
    Warranty = 3,
  }

  private enum FCWNameColumns
  {
    FormName = 1,
    Condition = 2,
    WarrantyName = 3,
  }
}
