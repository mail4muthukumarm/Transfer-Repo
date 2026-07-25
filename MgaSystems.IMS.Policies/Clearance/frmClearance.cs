// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Clearance.frmClearance
// Assembly: MgaSystems.IMS.Policies, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 2FF2C709-F7BF-41DA-82BD-FF6319CA235D
// Assembly location: C:\Users\muthu\Downloads\MgaSystems.IMS.Policies.dll

using Infragistics.Shared;
using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.Misc.CommonControls;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinMaskedEdit;
using Infragistics.Win.UltraWinScrollBar;
using Infragistics.Win.UltraWinToolbars;
using MGASystems.BusinessObjects;
using MGASystems.BusinessObjects.Exceptions;
using MGASystems.BusinessObjects.Rating;
using MGASystems.Common;
using MGASystems.Common.BroadcastMessaging;
using MGASystems.Common.CustomExceptions;
using MGASystems.Common.Enums;
using MGASystems.Common.ErrorHandling;
using MGASystems.Common.Extensions;
using MGASystems.Common.Functions;
using MGASystems.Common.Settings;
using MGASystems.Data;
using MGASystems.ExtendedEditors.DragDrop;
using MGASystems.IMS.DocumentAutomation;
using MGASystems.IMS.DocumentAutomation.TemplateDocuments;
using MGASystems.IMS.InsuredsProducersCompanies;
using MGASystems.IMS.InsuredsProducersCompanies.BusinessObjects;
using MGASystems.IMS.InsuredsProducersCompanies.Insureds;
using MGASystems.IMS.InsuredsProducersCompanies.Producers;
using MGASystems.IMS.NoteDocuments;
using MGASystems.IMS.Policies.Claims;
using MGASystems.IMS.Policies.Clearance.MultiQuotePrinting;
using MGASystems.IMS.Policies.PolicyBusinessObjects;
using MGASystems.IMS.Policies.PolicyDetail;
using MGASystems.IMS.Reporting;
using MGASystems.IMS.Reporting.AutomationReports;
using MGASystems.IMS.Security;
using MGASystems.InfragisticsExtensions.Editors;
using MGASystems.Tools;
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
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Xml;

#nullable disable
namespace MGASystems.IMS.Policies.Clearance;

[DocumentFolderFilter("Clearance Form")]
[SecureResource("{BCC1051B-E71E-4693-9335-8F535A8C3C50}", "Perform Search", "Controls the ability to perform clearance searches.", "Clearance")]
[SecureResource("{4AC22A74-7B62-40d3-B78D-CC400DFE3F26}", "Allow Policy Renew With Closed Producers", "Provides the security to renew policies with closed producers", "Clearances")]
[SecureResource("{26DBE3BE-3745-414e-8F30-C9315E9A3AA4}", "Allow Policy Renew With Inactive Producers", "Provides the security to renew policies with inactive producers", "Clearance")]
[SecureResource("{9225EE00-057D-4cc5-B09D-A626186BD713}", "Allow New Quotes With Inactive Insureds", "Provides the security to allow the creation of new quotes on inactive insureds", "Clearance")]
[SecureResource("{BFD2701B-C237-4f71-B918-113625AD47F9}", "Allow New Quotes With Closed Insureds", "Provides the security to allow the creation of new quotes on closed insureds", "Clearance")]
[SecureResource("{1737D110-1CA5-4d5e-8745-58C8CE134A67}", "Allow New Submission With Closed Insureds", "Provides the security to allow the creation of new submissions on closed insureds", "Clearance")]
[SecureResource("{11C43676-CF55-46ea-8144-B3CFFBCAD275}", "Allow New Submission With Inactive Insureds", "Provides the security to allow the creation of new submissions on inactive insureds", "Clearance")]
[SecureResource("{EF6FDCC0-050A-4128-BD7F-8F3DCC9D8FAE}", "Control Access to Duplicate Quote Menu", "Control access to duplicate quote menu item", "Clearance")]
[SecureResource("{B53921A4-696D-4b0f-9130-9EC205277AC8}", "Control Access to Renew Policy Menu", "Control access to the renew policy menu item", "Clearance")]
[SecureResource("{68CE5575-83C7-4df5-BB23-F9AA9747D39A}", "Control Access to Edit Quote Menu", "Control access to the edit quote menu item", "Clearance")]
[SecureResource("{9EAFD9EB-575F-4d5f-B68C-0E1367984C84}", "Control Access to Rewrite Policy Menu", "Control access to the rewrite policy menu item", "Clearance")]
[SecureResource("{305FFFDA-A10F-42af-B547-3E6AB798FEF1}", "Control Access to Change Status Menu", "Control access to the Change Status menu item", "Clearance")]
[SecureResource("{C05AEB0A-B1C4-4617-A252-D171BDC8C193}", "Allow Creation of New Quotes With Closed / Inactive Producers", "Provides the security to allow creation of new quotes on closed / inactive producers", "Clearance")]
[SecureResource("{9563C066-52CC-40d3-9B8E-F4B80614A97E}", "Allow Delete Quote On Clearance Screen", "Provides the security for Quotes deletion", "Clearance")]
[SecureResource("{F4F796D7-D625-4347-829F-8F3A328BAECE}", "Allow Opening of a Quote On Clearance Screen", "Provides the security for the opening of quotes", "Clearance")]
[SecureResource("{9EFA732E-DF81-4188-A447-7BFACAADD050}", "Controls Access to Add New Quotes On Clearance Screen", "Provides the security for adding of new quotes", "Clearance")]
[SecureResource("{31386F24-9D45-4667-A237-3CEFAE42F7F9}", "Controls Access to Add New Submissions On Clearance Screen", "Provides the security for adding new submissions", "Clearance")]
[SecureResource("{0450B0F5-9D72-40d4-A52A-67E5963A96DF}", "Controls Access to Edit Submissions On Clearance Screen", "Provides the security for editing submissions", "Clearance")]
[SecureResource("{BC922A87-8067-4d37-BB01-AD359A640A64}", "Controls Access to Change Quote Status Reason Context Menu Item", "Provides the security for viewing Change Quote Status Reason context menu (Right-Click on card)", "Clearance")]
[SecureResource("{552E167A-BA46-4D2E-879C-AC5A7D6DC387}", "Controls Access to Insured Summary Menu Item", "Provides the security for viewing Insured Summary context menu (Right-Click on card)", "Clearance")]
[SecureResource("{B986C908-BCE5-44F8-80DF-22CBA867EFBA}", "Controls Access to Quotes Context Menu", "Provides the security for viewing Quotes Context Menu(Right-Click on card)", "Clearance")]
[SecureResource("{25D35013-4336-48D8-88B0-3DD5E28C8A32}", "Controls Access to Submissions Context Menu", "Provides the security for viewing Submissions Context Menu(Right-Click on card)", "Clearance")]
[SecureResource("{BBE67BFC-DC78-4984-AB6F-A612D43AACA3}", "Allow Renewal With Inactive Company/Lines", "Provides the security to allow the creation of a renewal with an inactive company/line setup.", "Clearance")]
[SecureResource("{314D9C23-07F2-40CF-8C8A-B917FE519C02}", "Allow Policy Renew With Closed Producers with BOR", "Provides the security to renew policies with closed producers with BOR", "Clearance")]
[SecureResource("{423C569D-DED9-4410-8B0D-EF1992C8491C}", "Allow Policy Renew With Inactive Producers with BOR", "Provides the security to renew policies with closed producers with BOR", "Clearance")]
[SecureResource("{270AC55D-2B31-4273-B663-E600220C1AFA}", "Controls Access to menu item Change Underwriter on Clearance Screen", "Provides the security for Change Underwriter menu(Right-Click on card)", "Clearance")]
[SecureResource("{0A1516D8-ECC9-4754-AD6D-256D097E7B93}", "Allow Creation of Submission Record on Suspended Insureds", "Provides the security for creating submissions on Suspended Insureds", "Clearance")]
[SecureResource("{B53D292E-79C7-4806-9800-56CCC0300F67}", "Allow Renewal With Non-Renewed Quote Status", "Provides the security to renew policies with Non-Renewed quote status", "Clearance")]
public class frmClearance : 
  Form,
  ISupportDocumentSystem,
  ISupportNoteSystem,
  ISupportPolicyTemplateDocs,
  ISupportSubmissionTemplateDocs,
  ISupportInsuredLocationTemplateDocs,
  IMessageListener,
  ISupportQuoteContacts,
  IMultiPolicyDisplay
{
  private IContainer components;
  private Guid optionDetailGuid;
  private UltraGroupBox panelSearch;
  private AnimationControl AnimationControl1;
  private DbCommand DbSelectCommand2;
  private DbCommand DbSelectCommand3;
  private UltraToolbarsDockArea _frmClearance_Toolbars_Dock_Area_Left;
  private UltraToolbarsDockArea _frmClearance_Toolbars_Dock_Area_Right;
  private UltraToolbarsDockArea _frmClearance_Toolbars_Dock_Area_Top;
  private UltraToolbarsDockArea _frmClearance_Toolbars_Dock_Area_Bottom;
  private DragDropExtender DragDropOutlookExtender1;
  private ToolTip tt;
  public const string PerformSearch = "{BCC1051B-E71E-4693-9335-8F535A8C3C50}";
  public const string AllowRenewWithClosedProducer = "{4AC22A74-7B62-40d3-B78D-CC400DFE3F26}";
  public const string AllowRenewWithInactiveProducer = "{26DBE3BE-3745-414e-8F30-C9315E9A3AA4}";
  public const string AllowNewQuotesWithInactiveInsureds = "{9225EE00-057D-4cc5-B09D-A626186BD713}";
  public const string AllowNewQuotesWithClosedInsureds = "{BFD2701B-C237-4f71-B918-113625AD47F9}";
  public const string AllowNewSubmissionsWithClosedInsureds = "{1737D110-1CA5-4d5e-8745-58C8CE134A67}";
  public const string AllowNewSubmissionsWithInactiveInsureds = "{11C43676-CF55-46ea-8144-B3CFFBCAD275}";
  public const string AllowRenewalWithInactiveCompanyLine = "{BBE67BFC-DC78-4984-AB6F-A612D43AACA3}";
  public const string CanViewDuplicateQuoteMenu = "{EF6FDCC0-050A-4128-BD7F-8F3DCC9D8FAE}";
  public const string CanViewRenewMenu = "{B53921A4-696D-4b0f-9130-9EC205277AC8}";
  public const string CanViewEditQuoteMenu = "{68CE5575-83C7-4df5-BB23-F9AA9747D39A}";
  public const string CanViewRewriteQuoteMenu = "{9EAFD9EB-575F-4d5f-B68C-0E1367984C84}";
  public const string CanViewChangeStatusMenu = "{305FFFDA-A10F-42af-B547-3E6AB798FEF1}";
  public const string AllowNewQuotesWithInactiveOrClosedProducer = "{C05AEB0A-B1C4-4617-A252-D171BDC8C193}";
  public const string CanDeleteQuote = "{9563C066-52CC-40d3-9B8E-F4B80614A97E}";
  public const string CanOpenQuote = "{F4F796D7-D625-4347-829F-8F3A328BAECE}";
  public const string CanAddNewQuote = "{9EFA732E-DF81-4188-A447-7BFACAADD050}";
  public const string CanAddNewSubmission = "{31386F24-9D45-4667-A237-3CEFAE42F7F9}";
  public const string CanEditSubmission = "{0450B0F5-9D72-40d4-A52A-67E5963A96DF}";
  public const string CanViewChangeQuoteStatusReasonMenu = "{BC922A87-8067-4d37-BB01-AD359A640A64}";
  public const string CanViewInsuredSummaryMenu = "{552E167A-BA46-4D2E-879C-AC5A7D6DC387}";
  public const string CanViewQuotesContextMenu = "{B986C908-BCE5-44F8-80DF-22CBA867EFBA}";
  public const string CanViewSubmissionContextMenu = "{25D35013-4336-48D8-88B0-3DD5E28C8A32}";
  public const string AllowRenewWithClosedProducerWithBor = "{314D9C23-07F2-40CF-8C8A-B917FE519C02}";
  public const string AllowRenewWithInactiveProducerWithBor = "{423C569D-DED9-4410-8B0D-EF1992C8491C}";
  public const string AllowRenewalOnNonRenewedQuoteStatus = "{B53D292E-79C7-4806-9800-56CCC0300F67}";
  public const string CanViewChangeUnderwriterMenu = "{270AC55D-2B31-4273-B663-E600220C1AFA}";
  public const string CanCreateSubmissionWithSuspendedInsureds = "{0A1516D8-ECC9-4754-AD6D-256D097E7B93}";
  private DbConnection _cnDB;
  private DbDataAdapter _daInsureds;
  private DbDataAdapter _daProducerSubmissions;
  private DbDataAdapter _daQuotes;
  private const int SQL_CONSTRAINT_VIOLATION = 547;
  private const int EXPIREDSTATUS = -20;
  private const int BOUNDISSUEDSTATUS = -21;
  private const int NON_RENEWED = 17;
  private ClearanceDragDropManager _clearanceDragDropManager;
  private readonly HyperlinkEditor _hlk;
  private TabClearanceSearch _tabClearanceSearch;
  private MemoryStream _layoutStream;
  private QuoteStatusChangeMenu _statusChangeMenu;
  private readonly Bitmap _notesImage;
  private readonly bool AUTO_EXPAND_ON_SINGLE_RESULT;
  private IDocTag _docTag;
  private ITagParserFactory _tagParserFactoryInstance;
  private bool _CanViewInsuredSummaryMenu;
  private bool _CanViewQuotesContextMenu;
  private bool _CanViewRewriteQuoteMenu;
  private bool _CanViewSubmissionContextMenu;
  private bool _CanViewEditQuoteMenu;
  private bool _CanViewRenewMenu;
  private bool _CanViewDuplicateQuoteMenu;
  private bool _CanViewChangeQuoteStatusReasonMenu;
  private bool _CanViewChangeUnderwriterMenu;
  private readonly Dictionary<int, bool> _pastDueDictionary;
  private readonly Dictionary<int, CultureInfo> _currencySymbolDictionary;
  private static readonly Lazy<bool> _queryForNotesOnQuoteCard = SystemSettings.GetLazySetting<bool>("QueryForNotesOnQuoteCard", false, true);
  private readonly Lazy<bool> _identifyPassDueAccount;
  private readonly Lazy<bool> _viewSubmissionInspectionRequests;
  private readonly Lazy<bool> _colorCodeBoundCards;
  private readonly Lazy<bool> _canRenewOnCancelledPolicy;
  private readonly Lazy<bool> _showDuplicateQuoteMenuOption;
  private readonly Lazy<string> _tagInformationHeader;
  private readonly Lazy<string> _tagInformationDocTag;
  private readonly Lazy<bool> _displayCurrencySymbol;
  private bool _inSearch;
  private readonly Dictionary<int, string> _quoteStatusCommentsCache;
  private DateTime _quoteSearchStartTime;
  private StringFormat _sf;
  private ClearanceSearchInfo _searchInfo;

  protected virtual UltraToolbarsManager toolBar
  {
    get => this._toolBar;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      BeforeToolDropdownEventHandler dropdownEventHandler1 = new BeforeToolDropdownEventHandler(this.toolBar_BeforeToolDropdown);
      ToolClickEventHandler clickEventHandler = new ToolClickEventHandler(this.toolBar_ToolClick);
      BeforeToolbarListDropdownEventHandler dropdownEventHandler2 = new BeforeToolbarListDropdownEventHandler(this.toolBar_BeforeToolbarListDropdown);
      UltraToolbarsManager toolBar1 = this._toolBar;
      if (toolBar1 != null)
      {
        toolBar1.BeforeToolDropdown -= dropdownEventHandler1;
        toolBar1.ToolClick -= clickEventHandler;
        toolBar1.BeforeToolbarListDropdown -= dropdownEventHandler2;
      }
      this._toolBar = value;
      UltraToolbarsManager toolBar2 = this._toolBar;
      if (toolBar2 == null)
        return;
      toolBar2.BeforeToolDropdown += dropdownEventHandler1;
      toolBar2.ToolClick += clickEventHandler;
      toolBar2.BeforeToolbarListDropdown += dropdownEventHandler2;
    }
  }

  protected virtual UltraGrid ugInsuredNavigation
  {
    get => this._ugInsuredNavigation;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      BeforeRowsDeletedEventHandler deletedEventHandler = new BeforeRowsDeletedEventHandler(this.ugInsuredNavigation_BeforeRowsDeleted);
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.ugInsuredNavigation_KeyDown);
      UIElementEventHandler elementEventHandler = new UIElementEventHandler(this.ugInsuredNavigation_MouseEnterElement);
      EventHandler eventHandler1 = new EventHandler(this.ugInsuredNavigation_AfterRowActivate);
      EventHandler eventHandler2 = new EventHandler(this.ugInsuredNavigation_DoubleClick);
      ControlEventHandler controlEventHandler1 = new ControlEventHandler(this.ugInsuredNavigation_ControlAdded);
      ControlEventHandler controlEventHandler2 = new ControlEventHandler(this.ugInsuredNavigation_ControlRemoved);
      CancelableRowEventHandler cancelableRowEventHandler = new CancelableRowEventHandler(this.ugInsuredNavigation_BeforeRowExpanded);
      InitializeRowEventHandler initializeRowEventHandler = new InitializeRowEventHandler(this.ugInsuredNavigation_InitializeRow);
      MouseEventHandler mouseEventHandler = new MouseEventHandler(this.ugInsuredNavigation_MouseDown);
      UltraGrid insuredNavigation1 = this._ugInsuredNavigation;
      if (insuredNavigation1 != null)
      {
        insuredNavigation1.BeforeRowsDeleted -= deletedEventHandler;
        ((Control) insuredNavigation1).KeyDown -= keyEventHandler;
        ((UltraControlBase) insuredNavigation1).MouseEnterElement -= elementEventHandler;
        insuredNavigation1.AfterRowActivate -= eventHandler1;
        ((Control) insuredNavigation1).DoubleClick -= eventHandler2;
        ((Control) insuredNavigation1).ControlAdded -= controlEventHandler1;
        ((Control) insuredNavigation1).ControlRemoved -= controlEventHandler2;
        insuredNavigation1.BeforeRowExpanded -= cancelableRowEventHandler;
        insuredNavigation1.InitializeRow -= initializeRowEventHandler;
        ((Control) insuredNavigation1).MouseDown -= mouseEventHandler;
      }
      this._ugInsuredNavigation = value;
      UltraGrid insuredNavigation2 = this._ugInsuredNavigation;
      if (insuredNavigation2 == null)
        return;
      insuredNavigation2.BeforeRowsDeleted += deletedEventHandler;
      ((Control) insuredNavigation2).KeyDown += keyEventHandler;
      ((UltraControlBase) insuredNavigation2).MouseEnterElement += elementEventHandler;
      insuredNavigation2.AfterRowActivate += eventHandler1;
      ((Control) insuredNavigation2).DoubleClick += eventHandler2;
      ((Control) insuredNavigation2).ControlAdded += controlEventHandler1;
      ((Control) insuredNavigation2).ControlRemoved += controlEventHandler2;
      insuredNavigation2.BeforeRowExpanded += cancelableRowEventHandler;
      insuredNavigation2.InitializeRow += initializeRowEventHandler;
      ((Control) insuredNavigation2).MouseDown += mouseEventHandler;
    }
  }

  [field: AccessedThroughProperty("labelSearchText")]
  private virtual Label labelSearchText { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ball1Gray")]
  internal virtual PictureBox ball1Gray { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ball3Gray")]
  internal virtual PictureBox ball3Gray { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ball2Gray")]
  internal virtual PictureBox ball2Gray { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ball3Green")]
  internal virtual PictureBox ball3Green { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ball2Green")]
  internal virtual PictureBox ball2Green { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ball1Green")]
  internal virtual PictureBox ball1Green { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("DbSelectCommand")]
  internal virtual DbCommand DbSelectCommand { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("DsInsuredNavigation")]
  protected virtual dsInsuredNavigation DsInsuredNavigation { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    Appearance appearance1 = new Appearance();
    UltraGridBand ultraGridBand1 = new UltraGridBand("tblInsureds", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("InsuredGuid");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("Name");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("InsuredID");
    Appearance appearance2 = new Appearance();
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("SubmissionCount");
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("ViewSubmissions");
    Appearance appearance3 = new Appearance();
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("tblInsuredstblProducerSubmissions");
    UltraGridBand ultraGridBand2 = new UltraGridBand("tblInsuredstblProducerSubmissions", 0);
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("InsuredGuid");
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("Name");
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("ProducerLocationGuid");
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("ProducerGuid");
    UltraGridColumn ultraGridColumn11 = new UltraGridColumn("DateSubmitted");
    UltraGridColumn ultraGridColumn12 = new UltraGridColumn("SubmissionGroupGuid");
    UltraGridColumn ultraGridColumn13 = new UltraGridColumn("ViewQuotes");
    Appearance appearance4 = new Appearance();
    UltraGridColumn ultraGridColumn14 = new UltraGridColumn("Underwriter");
    UltraGridColumn ultraGridColumn15 = new UltraGridColumn("ProducerType");
    UltraGridColumn ultraGridColumn16 = new UltraGridColumn("SubmissionGroupID");
    Appearance appearance5 = new Appearance();
    UltraGridColumn ultraGridColumn17 = new UltraGridColumn("tblProducerstblLinesToCompany");
    UltraGridBand ultraGridBand3 = new UltraGridBand("tblProducerstblLinesToCompany", 1);
    UltraGridColumn ultraGridColumn18 = new UltraGridColumn("InsuredPolicyName");
    UltraGridColumn ultraGridColumn19 = new UltraGridColumn("InsuredDBA");
    UltraGridColumn ultraGridColumn20 = new UltraGridColumn("ProducerContact");
    UltraGridColumn ultraGridColumn21 = new UltraGridColumn("EffectiveDate");
    UltraGridColumn ultraGridColumn22 = new UltraGridColumn("ExpirationDate");
    UltraGridColumn ultraGridColumn23 = new UltraGridColumn("QuoteGuid");
    UltraGridColumn ultraGridColumn24 = new UltraGridColumn("SubmissionGroupGuid");
    UltraGridColumn ultraGridColumn25 = new UltraGridColumn("ControlGuid");
    UltraGridColumn ultraGridColumn26 = new UltraGridColumn("PolicyNumber");
    UltraGridColumn ultraGridColumn27 = new UltraGridColumn("LineName");
    UltraGridColumn ultraGridColumn28 = new UltraGridColumn("Name");
    UltraGridColumn ultraGridColumn29 = new UltraGridColumn("CompanyLocationGuid");
    UltraGridColumn ultraGridColumn30 = new UltraGridColumn("ControlNo");
    UltraGridColumn ultraGridColumn31 = new UltraGridColumn("State");
    UltraGridColumn ultraGridColumn32 = new UltraGridColumn("QuickQuote");
    UltraGridColumn ultraGridColumn33 = new UltraGridColumn("Underwriter");
    UltraGridColumn ultraGridColumn34 = new UltraGridColumn("Premium");
    UltraGridColumn ultraGridColumn35 = new UltraGridColumn("Reason");
    UltraGridColumn ultraGridColumn36 = new UltraGridColumn("RiskDescription");
    UltraGridColumn ultraGridColumn37 = new UltraGridColumn("PolicyDescription");
    UltraGridColumn ultraGridColumn38 = new UltraGridColumn("TACSR");
    UltraGridColumn ultraGridColumn39 = new UltraGridColumn("UnderwriterAssitant");
    UltraGridColumn ultraGridColumn40 = new UltraGridColumn("QuoteStatus");
    UltraGridColumn ultraGridColumn41 = new UltraGridColumn("QuoteStatusID");
    UltraGridColumn ultraGridColumn42 = new UltraGridColumn("HasPopupNotes");
    UltraGridColumn ultraGridColumn43 = new UltraGridColumn("QuotingOffice");
    UltraGridColumn ultraGridColumn44 = new UltraGridColumn("ReasonColor");
    UltraGridColumn ultraGridColumn45 = new UltraGridColumn("NeededByDate");
    UltraGridColumn ultraGridColumn46 = new UltraGridColumn("TagInformation", 0);
    UltraGridColumn ultraGridColumn47 = new UltraGridColumn("NoteCount", 1);
    UltraGridColumn ultraGridColumn48 = new UltraGridColumn("TargetPremium", 2);
    UltraGridColumn ultraGridColumn49 = new UltraGridColumn("AdditionalInformation", 3);
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
    Appearance appearance18 = new Appearance();
    Appearance appearance19 = new Appearance();
    Appearance appearance20 = new Appearance();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmClearance));
    Appearance appearance21 = new Appearance();
    UltraToolbar ultraToolbar1 = new UltraToolbar("toolbarClearance");
    ButtonTool buttonTool1 = new ButtonTool("New Insured");
    ButtonTool buttonTool2 = new ButtonTool("New Submission");
    ButtonTool buttonTool3 = new ButtonTool("Edit Submission");
    ButtonTool buttonTool4 = new ButtonTool("New Quote");
    ButtonTool buttonTool5 = new ButtonTool("Open Quote");
    ButtonTool buttonTool6 = new ButtonTool("Insured Summary");
    UltraToolbar ultraToolbar2 = new UltraToolbar("contextMenu");
    ButtonTool buttonTool7 = new ButtonTool("New Insured");
    ButtonTool buttonTool8 = new ButtonTool("New Submission");
    ButtonTool buttonTool9 = new ButtonTool("Edit Submission");
    ButtonTool buttonTool10 = new ButtonTool("New Quote");
    ButtonTool buttonTool11 = new ButtonTool("Open Quote");
    PopupMenuTool popupMenuTool = new PopupMenuTool("contextMenu");
    ButtonTool buttonTool12 = new ButtonTool("Delete Insured");
    ButtonTool buttonTool13 = new ButtonTool("Delete Submission");
    ButtonTool buttonTool14 = new ButtonTool("Duplicate Submission");
    ButtonTool buttonTool15 = new ButtonTool("Duplicate Quote");
    ButtonTool buttonTool16 = new ButtonTool("Renew Policy");
    ButtonTool buttonTool17 = new ButtonTool("Delete Quote");
    ButtonTool buttonTool18 = new ButtonTool("Edit Quote");
    ButtonTool buttonTool19 = new ButtonTool("Unbind Policy");
    ButtonTool buttonTool20 = new ButtonTool("Print Quote");
    ButtonTool buttonTool21 = new ButtonTool("Expand All");
    ButtonTool buttonTool22 = new ButtonTool("Collapse All");
    ButtonTool buttonTool23 = new ButtonTool("Submission Overview");
    ButtonTool buttonTool24 = new ButtonTool("Rewrite Policy");
    ButtonTool buttonTool25 = new ButtonTool("Insured Summary");
    ButtonTool buttonTool26 = new ButtonTool("PrintQuotes");
    ButtonTool buttonTool27 = new ButtonTool("Change Quote Status Reason");
    ButtonTool buttonTool28 = new ButtonTool("Bind Quotes in Submission");
    ButtonTool buttonTool29 = new ButtonTool("Quote Option Details");
    ButtonTool buttonTool30 = new ButtonTool("Renew All");
    ButtonTool buttonTool31 = new ButtonTool("Print Binders in Submission");
    ButtonTool buttonTool32 = new ButtonTool("Change Underwriter");
    ButtonTool buttonTool33 = new ButtonTool("Submission Inspection Requests");
    ButtonTool buttonTool34 = new ButtonTool("New Quote");
    ButtonTool buttonTool35 = new ButtonTool("Move Insured");
    ButtonTool buttonTool36 = new ButtonTool("Expand All");
    ButtonTool buttonTool37 = new ButtonTool("Collapse All");
    ButtonTool buttonTool38 = new ButtonTool("Delete Insured");
    ButtonTool buttonTool39 = new ButtonTool("Delete Submission");
    ButtonTool buttonTool40 = new ButtonTool("Duplicate Submission");
    ButtonTool buttonTool41 = new ButtonTool("Duplicate Quote");
    ButtonTool buttonTool42 = new ButtonTool("Renew Policy");
    ButtonTool buttonTool43 = new ButtonTool("Delete Quote");
    ButtonTool buttonTool44 = new ButtonTool("Edit Quote");
    ButtonTool buttonTool45 = new ButtonTool("Unbind Policy");
    ButtonTool buttonTool46 = new ButtonTool("Print Quote");
    ButtonTool buttonTool47 = new ButtonTool("Submission Overview");
    ButtonTool buttonTool48 = new ButtonTool("Rewrite Policy");
    ButtonTool buttonTool49 = new ButtonTool("Insured Summary");
    ButtonTool buttonTool50 = new ButtonTool("PrintQuotes");
    ButtonTool buttonTool51 = new ButtonTool("Change Quote Status Reason");
    ButtonTool buttonTool52 = new ButtonTool("Bind Quotes in Submission");
    ButtonTool buttonTool53 = new ButtonTool("Quote Option Details");
    ButtonTool buttonTool54 = new ButtonTool("Renew All");
    ButtonTool buttonTool55 = new ButtonTool("Print Binders in Submission");
    ButtonTool buttonTool56 = new ButtonTool("Change Underwriter");
    ButtonTool buttonTool57 = new ButtonTool("Submission Inspection Requests");
    ButtonTool buttonTool58 = new ButtonTool("Move Insured");
    this.DsInsuredNavigation = new dsInsuredNavigation();
    this._daInsureds = DefaultDatabase.CreateDataAdapter();
    this.DbSelectCommand = DefaultDatabase.CreateCommand();
    this._daProducerSubmissions = DefaultDatabase.CreateDataAdapter();
    this.DbSelectCommand2 = DefaultDatabase.CreateCommand();
    this._daQuotes = DefaultDatabase.CreateDataAdapter();
    this.DbSelectCommand3 = DefaultDatabase.CreateCommand();
    this.ugInsuredNavigation = new UltraGrid();
    this.panelSearch = new UltraGroupBox();
    this.ball3Green = new PictureBox();
    this.ball2Green = new PictureBox();
    this.ball1Green = new PictureBox();
    this.ball3Gray = new PictureBox();
    this.ball2Gray = new PictureBox();
    this.ball1Gray = new PictureBox();
    this.labelSearchText = new Label();
    this.AnimationControl1 = new AnimationControl();
    this.DragDropOutlookExtender1 = new DragDropExtender(this.components);
    this.tt = new ToolTip(this.components);
    this._frmClearance_Toolbars_Dock_Area_Left = new UltraToolbarsDockArea();
    this.toolBar = new UltraToolbarsManager(this.components);
    this._frmClearance_Toolbars_Dock_Area_Right = new UltraToolbarsDockArea();
    this._frmClearance_Toolbars_Dock_Area_Top = new UltraToolbarsDockArea();
    this._frmClearance_Toolbars_Dock_Area_Bottom = new UltraToolbarsDockArea();
    Label label = new Label();
    this.DsInsuredNavigation.BeginInit();
    ((ISupportInitialize) this.ugInsuredNavigation).BeginInit();
    ((ISupportInitialize) this.panelSearch).BeginInit();
    ((Control) this.panelSearch).SuspendLayout();
    ((ISupportInitialize) this.ball3Green).BeginInit();
    ((ISupportInitialize) this.ball2Green).BeginInit();
    ((ISupportInitialize) this.ball1Green).BeginInit();
    ((ISupportInitialize) this.ball3Gray).BeginInit();
    ((ISupportInitialize) this.ball2Gray).BeginInit();
    ((ISupportInitialize) this.ball1Gray).BeginInit();
    ((ISupportInitialize) this.toolBar).BeginInit();
    this.SuspendLayout();
    label.AutoSize = true;
    label.Font = new Font("Tahoma", 12f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    label.Location = new Point(72, 14);
    label.Name = "label2";
    label.Size = new Size(183, 19);
    label.TabIndex = 1;
    label.Text = "Searching... Please Wait.";
    this.DsInsuredNavigation.DataSetName = "dsInsuredNavigation";
    this.DsInsuredNavigation.Locale = new CultureInfo("en-US");
    this.DsInsuredNavigation.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this._daInsureds.SelectCommand = this.DbSelectCommand;
    this._daInsureds.TableMappings.AddRange(new DataTableMapping[8]
    {
      new DataTableMapping("Table", "spMGA_InsNav_InsuredsSelect", new DataColumnMapping[4]
      {
        new DataColumnMapping("Name", "Name"),
        new DataColumnMapping("InsuredGUID", "InsuredGUID"),
        new DataColumnMapping("InsuredID", "InsuredID"),
        new DataColumnMapping("SubmissionCount", "SubmissionCount")
      }),
      new DataTableMapping("Table1", "Table1", new DataColumnMapping[4]
      {
        new DataColumnMapping("Name", "Name"),
        new DataColumnMapping("InsuredGUID", "InsuredGUID"),
        new DataColumnMapping("InsuredID", "InsuredID"),
        new DataColumnMapping("SubmissionCount", "SubmissionCount")
      }),
      new DataTableMapping("Table2", "Table2", new DataColumnMapping[4]
      {
        new DataColumnMapping("Name", "Name"),
        new DataColumnMapping("InsuredGUID", "InsuredGUID"),
        new DataColumnMapping("InsuredID", "InsuredID"),
        new DataColumnMapping("SubmissiONCount", "SubmissiONCount")
      }),
      new DataTableMapping("Table3", "Table3", new DataColumnMapping[4]
      {
        new DataColumnMapping("Name", "Name"),
        new DataColumnMapping("InsuredGUID", "InsuredGUID"),
        new DataColumnMapping("InsuredID", "InsuredID"),
        new DataColumnMapping("SubmissionCount", "SubmissionCount")
      }),
      new DataTableMapping("Table4", "Table4", new DataColumnMapping[4]
      {
        new DataColumnMapping("Name", "Name"),
        new DataColumnMapping("InsuredGUID", "InsuredGUID"),
        new DataColumnMapping("InsuredID", "InsuredID"),
        new DataColumnMapping("SubmissionCount", "SubmissionCount")
      }),
      new DataTableMapping("Table5", "Table5", new DataColumnMapping[4]
      {
        new DataColumnMapping("Name", "Name"),
        new DataColumnMapping("InsuredGUID", "InsuredGUID"),
        new DataColumnMapping("InsuredID", "InsuredID"),
        new DataColumnMapping("SubmissionCount", "SubmissionCount")
      }),
      new DataTableMapping("Table6", "Table6", new DataColumnMapping[4]
      {
        new DataColumnMapping("Name", "Name"),
        new DataColumnMapping("InsuredGUID", "InsuredGUID"),
        new DataColumnMapping("InsuredID", "InsuredID"),
        new DataColumnMapping("SubmissionCount", "SubmissionCount")
      }),
      new DataTableMapping("Table7", "Table7", new DataColumnMapping[4]
      {
        new DataColumnMapping("Name", "Name"),
        new DataColumnMapping("InsuredGUID", "InsuredGUID"),
        new DataColumnMapping("InsuredID", "InsuredID"),
        new DataColumnMapping("SubmissionCount", "SubmissionCount")
      })
    });
    this.DbSelectCommand.CommandText = "dbo.spMGA_InsNav_InsuredsSelect";
    this.DbSelectCommand.CommandType = CommandType.StoredProcedure;
    this.DbSelectCommand.Parameters.AddRange((Array) new DbParameter[36]
    {
      DefaultDatabase.CreateParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, false, (byte) 0, (byte) 0, "", DataRowVersion.Current, (object) null),
      DefaultDatabase.CreateParameter("@InsuredName", SqlDbType.VarChar, 50),
      DefaultDatabase.CreateParameter("@Address", SqlDbType.VarChar, 250),
      DefaultDatabase.CreateParameter("@EffectiveStart", SqlDbType.DateTime, 8),
      DefaultDatabase.CreateParameter("@EffectiveEnd", SqlDbType.DateTime, 8),
      DefaultDatabase.CreateParameter("@ExpirationStart", SqlDbType.DateTime, 8),
      DefaultDatabase.CreateParameter("@ExpirationEnd", SqlDbType.DateTime, 8),
      DefaultDatabase.CreateParameter("@ProducerLocationGUID", SqlDbType.UniqueIdentifier, 16 /*0x10*/),
      DefaultDatabase.CreateParameter("@PolicyNumber", SqlDbType.VarChar, 50),
      DefaultDatabase.CreateParameter("@LineGUID", SqlDbType.UniqueIdentifier, 16 /*0x10*/),
      DefaultDatabase.CreateParameter("@QuoteStatusID", SqlDbType.TinyInt, 1),
      DefaultDatabase.CreateParameter("@BusinessTypeID", SqlDbType.TinyInt, 1),
      DefaultDatabase.CreateParameter("@FEIN", SqlDbType.VarChar, 9),
      DefaultDatabase.CreateParameter("@InForce", SqlDbType.Bit, 1),
      DefaultDatabase.CreateParameter("@StartsWith", SqlDbType.Bit, 1),
      DefaultDatabase.CreateParameter("@NumResults", SqlDbType.TinyInt, 1),
      DefaultDatabase.CreateParameter("@InsuredID", SqlDbType.Int, 4),
      DefaultDatabase.CreateParameter("@ControlNo", SqlDbType.Int, 4),
      DefaultDatabase.CreateParameter("@PolicyStateID", SqlDbType.VarChar, 2),
      DefaultDatabase.CreateParameter("@InsuredStateID", SqlDbType.VarChar, 2),
      DefaultDatabase.CreateParameter("@CompanyLocationGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/),
      DefaultDatabase.CreateParameter("@PolicyTypeID", SqlDbType.TinyInt, 1),
      DefaultDatabase.CreateParameter("@HideVoids", SqlDbType.Bit, 1),
      DefaultDatabase.CreateParameter("@UnderwriterGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/),
      DefaultDatabase.CreateParameter("@QuotingOffice", SqlDbType.UniqueIdentifier, 16 /*0x10*/),
      DefaultDatabase.CreateParameter("@IssuingOffice", SqlDbType.UniqueIdentifier, 16 /*0x10*/),
      DefaultDatabase.CreateParameter("@InsuredPhone", SqlDbType.VarChar, 12),
      DefaultDatabase.CreateParameter("@SubmissionID", SqlDbType.Int, 4),
      DefaultDatabase.CreateParameter("@ViewUnBoundStatus", SqlDbType.Bit, 1),
      DefaultDatabase.CreateParameter("@AccountNumber", SqlDbType.VarChar, 20),
      DefaultDatabase.CreateParameter("@SearchingUserID", SqlDbType.Int, 4),
      DefaultDatabase.CreateParameter("@ClaimNo", SqlDbType.VarChar, 50),
      DefaultDatabase.CreateParameter("@Address1", SqlDbType.VarChar, 250),
      DefaultDatabase.CreateParameter("@ProducerEmail", SqlDbType.VarChar, 50),
      DefaultDatabase.CreateParameter("@InsuredCity", SqlDbType.VarChar, 200),
      DefaultDatabase.CreateParameter("@RiskID", SqlDbType.VarChar, 50)
    });
    this._daProducerSubmissions.SelectCommand = this.DbSelectCommand2;
    this.DbSelectCommand2.CommandText = "[spMGA_InsNav_ProducersSelect]";
    this.DbSelectCommand2.CommandType = CommandType.StoredProcedure;
    this.DbSelectCommand2.Parameters.AddRange((Array) new DbParameter[26]
    {
      DefaultDatabase.CreateParameter("@InsuredName", SqlDbType.VarChar, 50),
      DefaultDatabase.CreateParameter("@InsuredGUID", SqlDbType.UniqueIdentifier, 16 /*0x10*/),
      DefaultDatabase.CreateParameter("@ProducerLocationGUID", SqlDbType.UniqueIdentifier, 16 /*0x10*/),
      DefaultDatabase.CreateParameter("@EffectiveStart", SqlDbType.DateTime, 8),
      DefaultDatabase.CreateParameter("@EffectiveEnd", SqlDbType.DateTime, 8),
      DefaultDatabase.CreateParameter("@ExpirationStart", SqlDbType.DateTime, 8),
      DefaultDatabase.CreateParameter("@ExpirationEnd", SqlDbType.DateTime, 8),
      DefaultDatabase.CreateParameter("@PolicyNumber", SqlDbType.VarChar, 50),
      DefaultDatabase.CreateParameter("@AccountNumber", SqlDbType.VarChar, 20),
      DefaultDatabase.CreateParameter("@LineGUID", SqlDbType.UniqueIdentifier, 16 /*0x10*/),
      DefaultDatabase.CreateParameter("@PolicyTypeID", SqlDbType.TinyInt, 1),
      DefaultDatabase.CreateParameter("@QuoteStatusID", SqlDbType.TinyInt, 1),
      DefaultDatabase.CreateParameter("@InForce", SqlDbType.Bit, 1),
      DefaultDatabase.CreateParameter("@ControlNo", SqlDbType.Int, 4),
      DefaultDatabase.CreateParameter("@PolicyStateID", SqlDbType.VarChar, 2),
      DefaultDatabase.CreateParameter("@CompanyLocationGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/),
      DefaultDatabase.CreateParameter("@UnderwriterGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/),
      DefaultDatabase.CreateParameter("@SubmissionGroupGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/),
      DefaultDatabase.CreateParameter("@HideVoids", SqlDbType.Bit, 1),
      DefaultDatabase.CreateParameter("@QuotingOffice", SqlDbType.UniqueIdentifier, 16 /*0x10*/),
      DefaultDatabase.CreateParameter("@IssuingOffice", SqlDbType.UniqueIdentifier, 16 /*0x10*/),
      DefaultDatabase.CreateParameter("@SubmissionID", SqlDbType.Int, 4),
      DefaultDatabase.CreateParameter("@ViewUnBoundStatus", SqlDbType.Bit),
      DefaultDatabase.CreateParameter("@SearchingUserID", SqlDbType.Int, 4),
      DefaultDatabase.CreateParameter("@ClaimNo", SqlDbType.VarChar, 50),
      DefaultDatabase.CreateParameter("@ProducerEmail", SqlDbType.VarChar, 50)
    });
    this._daQuotes.AcceptChangesDuringFill = false;
    this._daQuotes.SelectCommand = this.DbSelectCommand3;
    this.DbSelectCommand3.CommandText = "[spMGA_InsNav_QuotesSelect]";
    this.DbSelectCommand3.CommandType = CommandType.StoredProcedure;
    this.DbSelectCommand3.Parameters.AddRange((Array) new DbParameter[24]
    {
      DefaultDatabase.CreateParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, false, (byte) 0, (byte) 0, "", DataRowVersion.Current, (object) null),
      DefaultDatabase.CreateParameter("@InsuredName", SqlDbType.VarChar, 50),
      DefaultDatabase.CreateParameter("@QuoteGUID", SqlDbType.UniqueIdentifier, 16 /*0x10*/),
      DefaultDatabase.CreateParameter("@SubmissionGroupGUID", SqlDbType.UniqueIdentifier, 16 /*0x10*/),
      DefaultDatabase.CreateParameter("@EffectiveStart", SqlDbType.DateTime, 8),
      DefaultDatabase.CreateParameter("@EffectiveEnd", SqlDbType.DateTime, 8),
      DefaultDatabase.CreateParameter("@ExpirationStart", SqlDbType.DateTime, 8),
      DefaultDatabase.CreateParameter("@ExpirationEnd", SqlDbType.DateTime, 8),
      DefaultDatabase.CreateParameter("@PolicyNumber", SqlDbType.VarChar, 50),
      DefaultDatabase.CreateParameter("@AccountNumber", SqlDbType.VarChar, 20),
      DefaultDatabase.CreateParameter("@LineGUID", SqlDbType.UniqueIdentifier, 16 /*0x10*/),
      DefaultDatabase.CreateParameter("@QuoteStatusID", SqlDbType.TinyInt, 1),
      DefaultDatabase.CreateParameter("@InForce", SqlDbType.Bit, 1),
      DefaultDatabase.CreateParameter("@ControlNo", SqlDbType.Int, 4),
      DefaultDatabase.CreateParameter("@PolicyStateID", SqlDbType.VarChar, 2),
      DefaultDatabase.CreateParameter("@CompanyLocationGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/),
      DefaultDatabase.CreateParameter("@PolicyTypeID", SqlDbType.TinyInt, 1),
      DefaultDatabase.CreateParameter("@HideVoids", SqlDbType.Bit, 1),
      DefaultDatabase.CreateParameter("@UnderwriterGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/),
      DefaultDatabase.CreateParameter("@SearchingUserID", SqlDbType.Int, 4),
      DefaultDatabase.CreateParameter("@QuotingOffice", SqlDbType.UniqueIdentifier, 16 /*0x10*/),
      DefaultDatabase.CreateParameter("@IssuingOffice", SqlDbType.UniqueIdentifier, 16 /*0x10*/),
      DefaultDatabase.CreateParameter("@ViewUnBoundStatus", SqlDbType.Bit),
      DefaultDatabase.CreateParameter("@ClaimNo", SqlDbType.VarChar, 50)
    });
    ((Control) this.ugInsuredNavigation).AllowDrop = true;
    this.toolBar.SetContextMenuUltra((Component) this.ugInsuredNavigation, "contextMenu");
    ((UltraGridBase) this.ugInsuredNavigation).DataSource = (object) this.DsInsuredNavigation.tblInsureds;
    ((SpecialBoxBase) ((UltraGridBase) this.ugInsuredNavigation).DisplayLayout.AddNewBox).ButtonConnectorStyle = (UIElementBorderStyle) 1;
    ((SpecialBoxBase) ((UltraGridBase) this.ugInsuredNavigation).DisplayLayout.AddNewBox).Prompt = "New...";
    ((UltraGridBase) this.ugInsuredNavigation).DisplayLayout.AddNewBox.Style = (AddNewBoxStyle) 1;
    appearance1.BackColor = Color.White;
    appearance1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.ugInsuredNavigation).DisplayLayout.Appearance = (AppearanceBase) appearance1;
    ((UltraGridBase) this.ugInsuredNavigation).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridBand1.AddButtonCaption = "Insured";
    ultraGridColumn1.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn1.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn2.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn2.CellActivation = (Activation) 3;
    ultraGridColumn2.CellDisplayStyle = (CellDisplayStyle) 1;
    ((HeaderBase) ultraGridColumn2.Header).Caption = "Insured";
    ((HeaderBase) ultraGridColumn2.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn2.Header.VisiblePosition = 1;
    ultraGridColumn2.Width = 311;
    ultraGridColumn3.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn3.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance2).TextHAlignAsString = "Center";
    ultraGridColumn3.CellAppearance = (AppearanceBase) appearance2;
    ultraGridColumn3.CellDisplayStyle = (CellDisplayStyle) 1;
    ((HeaderBase) ultraGridColumn3.Header).Caption = "Insured #";
    ((HeaderBase) ultraGridColumn3.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn3.Header.VisiblePosition = 2;
    ultraGridColumn3.Width = 183;
    ultraGridColumn4.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn4.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn4.Header.VisiblePosition = 4;
    ultraGridColumn4.Hidden = true;
    ultraGridColumn5.AutoCompleteMode = (AutoCompleteMode) 2;
    appearance3.ForeColor = Color.Blue;
    ((AppearanceBase) appearance3).TextHAlignAsString = "Center";
    ultraGridColumn5.CellAppearance = (AppearanceBase) appearance3;
    ((HeaderBase) ultraGridColumn5.Header).Caption = "Submissions";
    ((HeaderBase) ultraGridColumn5.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn5.Header.VisiblePosition = 3;
    ultraGridColumn5.Width = 229;
    ultraGridColumn6.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn6.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn6.Header.VisiblePosition = 5;
    ultraGridBand1.Columns.AddRange(new object[6]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3,
      (object) ultraGridColumn4,
      (object) ultraGridColumn5,
      (object) ultraGridColumn6
    });
    ultraGridColumn7.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn7.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn7.Header.VisiblePosition = 0;
    ultraGridColumn7.Hidden = true;
    ultraGridColumn8.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn8.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn8.Header).Caption = "Producer";
    ((HeaderBase) ultraGridColumn8.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn8.Header.VisiblePosition = 2;
    ultraGridColumn8.Width = 183;
    ultraGridColumn9.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn9.CellDisplayStyle = (CellDisplayStyle) 1;
    ((HeaderBase) ultraGridColumn9.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn9.Header.VisiblePosition = 7;
    ultraGridColumn9.Hidden = true;
    ultraGridColumn10.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn10.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn10.Header.VisiblePosition = 8;
    ultraGridColumn10.Hidden = true;
    ultraGridColumn11.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn11.CellActivation = (Activation) 3;
    ultraGridColumn11.Format = "d";
    ((HeaderBase) ultraGridColumn11.Header).Caption = "Submitted";
    ((HeaderBase) ultraGridColumn11.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn11.Header.VisiblePosition = 5;
    ultraGridColumn11.Width = 84;
    ultraGridColumn12.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn12.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn12.Header.VisiblePosition = 9;
    ultraGridColumn12.Hidden = true;
    ultraGridColumn13.AutoCompleteMode = (AutoCompleteMode) 2;
    appearance4.ForeColor = Color.Blue;
    ((AppearanceBase) appearance4).TextHAlignAsString = "Center";
    ultraGridColumn13.CellAppearance = (AppearanceBase) appearance4;
    ((HeaderBase) ultraGridColumn13.Header).Caption = "Quotes";
    ((HeaderBase) ultraGridColumn13.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn13.Header.VisiblePosition = 6;
    ultraGridColumn13.Width = 63 /*0x3F*/;
    ultraGridColumn14.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn14.CellActivation = (Activation) 3;
    ultraGridColumn14.CellDisplayStyle = (CellDisplayStyle) 1;
    ((HeaderBase) ultraGridColumn14.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn14.Header.VisiblePosition = 4;
    ultraGridColumn14.Width = 137;
    ultraGridColumn15.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn15.Header).Caption = "Producer Type";
    ((HeaderBase) ultraGridColumn15.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn15.Header.VisiblePosition = 3;
    ultraGridColumn15.Width = 163;
    ultraGridColumn16.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance5).TextHAlignAsString = "Center";
    ultraGridColumn16.CellAppearance = (AppearanceBase) appearance5;
    ((HeaderBase) ultraGridColumn16.Header).Caption = "ID";
    ((HeaderBase) ultraGridColumn16.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn16.Header.VisiblePosition = 1;
    ultraGridColumn16.Width = 74;
    ultraGridColumn17.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn17.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn17.Header.VisiblePosition = 10;
    ultraGridBand2.Columns.AddRange(new object[11]
    {
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
      (object) ultraGridColumn17
    });
    ultraGridBand3.CardSettings.CaptionField = "QuoteStatus";
    ultraGridBand3.CardSettings.Width = 200;
    ultraGridBand3.CardView = true;
    ultraGridColumn18.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn18.CellDisplayStyle = (CellDisplayStyle) 2;
    ((HeaderBase) ultraGridColumn18.Header).Caption = "Insured";
    ((HeaderBase) ultraGridColumn18.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn18.Header.VisiblePosition = 0;
    ultraGridColumn19.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn19.Header).Caption = "DBA";
    ((HeaderBase) ultraGridColumn19.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn19.Header.VisiblePosition = 1;
    ultraGridColumn20.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn20.CellDisplayStyle = (CellDisplayStyle) 2;
    ((HeaderBase) ultraGridColumn20.Header).Caption = "Producer Contact";
    ((HeaderBase) ultraGridColumn20.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn20.Header.VisiblePosition = 3;
    ultraGridColumn21.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn21.CellDisplayStyle = (CellDisplayStyle) 2;
    ((HeaderBase) ultraGridColumn21.Header).Caption = "Effective";
    ((HeaderBase) ultraGridColumn21.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn21.Header.VisiblePosition = 5;
    ultraGridColumn22.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn22.CellDisplayStyle = (CellDisplayStyle) 2;
    ((HeaderBase) ultraGridColumn22.Header).Caption = "Expires";
    ((HeaderBase) ultraGridColumn22.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn22.Header.VisiblePosition = 6;
    ultraGridColumn23.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn23.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn23.Header.VisiblePosition = 7;
    ultraGridColumn23.Hidden = true;
    ultraGridColumn24.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn24.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn24.Header.VisiblePosition = 9;
    ultraGridColumn24.Hidden = true;
    ultraGridColumn25.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn25.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn25.Header.VisiblePosition = 8;
    ultraGridColumn25.Hidden = true;
    ultraGridColumn26.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn26.CellDisplayStyle = (CellDisplayStyle) 2;
    ((HeaderBase) ultraGridColumn26.Header).Caption = "Policy #";
    ((HeaderBase) ultraGridColumn26.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn26.Header.VisiblePosition = 4;
    ultraGridColumn27.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn27.CellDisplayStyle = (CellDisplayStyle) 2;
    ((HeaderBase) ultraGridColumn27.Header).Caption = "Line";
    ((HeaderBase) ultraGridColumn27.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn27.Header.VisiblePosition = 11;
    ultraGridColumn28.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn28.CellDisplayStyle = (CellDisplayStyle) 2;
    ((HeaderBase) ultraGridColumn28.Header).Caption = "Company";
    ((HeaderBase) ultraGridColumn28.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn28.Header.VisiblePosition = 12;
    ultraGridColumn29.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn29.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn29.Header.VisiblePosition = 13;
    ultraGridColumn29.Hidden = true;
    ultraGridColumn30.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn30.CellDisplayStyle = (CellDisplayStyle) 2;
    ((HeaderBase) ultraGridColumn30.Header).Caption = "Control #";
    ((HeaderBase) ultraGridColumn30.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn30.Header.VisiblePosition = 2;
    ultraGridColumn31.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn31.CellDisplayStyle = (CellDisplayStyle) 2;
    ((HeaderBase) ultraGridColumn31.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn31.Header.VisiblePosition = 14;
    ultraGridColumn32.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn32.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn32.Header.VisiblePosition = 15;
    ultraGridColumn32.Hidden = true;
    ultraGridColumn33.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn33.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn33.Header.VisiblePosition = 16 /*0x10*/;
    ultraGridColumn34.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn34.Format = "c";
    ((HeaderBase) ultraGridColumn34.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn34.Header.VisiblePosition = 17;
    ultraGridColumn35.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn35.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn35.Header.VisiblePosition = 18;
    ultraGridColumn36.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn36.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn36.Header.VisiblePosition = 19;
    ultraGridColumn36.Hidden = true;
    ultraGridColumn37.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn37.Header).Caption = "Policy Type";
    ((HeaderBase) ultraGridColumn37.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn37.Header.VisiblePosition = 20;
    ultraGridColumn38.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn38.Header).Caption = "TA / CSR";
    ((HeaderBase) ultraGridColumn38.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn38.Header.VisiblePosition = 21;
    ultraGridColumn39.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn39.Header).Caption = "Und. Assistant";
    ((HeaderBase) ultraGridColumn39.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn39.Header.VisiblePosition = 22;
    ultraGridColumn40.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn40.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn40.Header.VisiblePosition = 10;
    ultraGridColumn40.Hidden = true;
    ultraGridColumn41.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn41.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn41.Header.VisiblePosition = 23;
    ultraGridColumn41.Hidden = true;
    ultraGridColumn42.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn42.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn42.Header.VisiblePosition = 24;
    ultraGridColumn42.Hidden = true;
    ultraGridColumn43.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn43.Header).Caption = "Quoting Office";
    ((HeaderBase) ultraGridColumn43.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn43.Header.VisiblePosition = 25;
    ((HeaderBase) ultraGridColumn44.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn44.Header.VisiblePosition = 26;
    ultraGridColumn44.Hidden = true;
    ultraGridColumn45.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn45.Header).Caption = "Needed By";
    ((HeaderBase) ultraGridColumn45.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn45.Header.VisiblePosition = 28;
    ((HeaderBase) ultraGridColumn46.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn46.Header.VisiblePosition = 27;
    ultraGridColumn46.Hidden = true;
    ultraGridColumn47.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn47.CellDisplayStyle = (CellDisplayStyle) 2;
    ((HeaderBase) ultraGridColumn47.Header).Caption = "Note Count";
    ((HeaderBase) ultraGridColumn47.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn47.Header.VisiblePosition = 29;
    ultraGridColumn48.Format = "c";
    ((HeaderBase) ultraGridColumn48.Header).Caption = "Target Premium";
    ((HeaderBase) ultraGridColumn48.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn48.Header.VisiblePosition = 30;
    appearance6.ForeColor = Color.Blue;
    ultraGridColumn49.CellAppearance = (AppearanceBase) appearance6;
    ultraGridColumn49.CellClickAction = (CellClickAction) 1;
    ((HeaderBase) ultraGridColumn49.Header).Caption = "Additional Information";
    ((HeaderBase) ultraGridColumn49.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn49.Header.VisiblePosition = 31 /*0x1F*/;
    ultraGridColumn49.Hidden = true;
    ultraGridBand3.Columns.AddRange(new object[32 /*0x20*/]
    {
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
      (object) ultraGridColumn49
    });
    appearance7.BackColor = Color.White;
    appearance7.BackColor2 = Color.Gainsboro;
    appearance7.BackGradientAlignment = (GradientAlignment) 2;
    appearance7.BackGradientStyle = (GradientStyle) 3;
    ((AppearanceBase) appearance7).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridBand3.Header).Appearance = (AppearanceBase) appearance7;
    ((HeaderBase) ultraGridBand3.Header).Caption = "Right-click cards for more options...";
    ((HeaderBase) ultraGridBand3.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridBand3.HeaderVisible = true;
    appearance8.BackColor = Color.LightSteelBlue;
    appearance8.FontData.BoldAsString = "True";
    appearance8.ForeColor = Color.Black;
    ultraGridBand3.Override.ActiveCardCaptionAppearance = (AppearanceBase) appearance8;
    appearance9.BackColor = Color.LightSteelBlue;
    appearance9.BackColor2 = Color.White;
    appearance9.BackGradientAlignment = (GradientAlignment) 2;
    appearance9.BackGradientStyle = (GradientStyle) 2;
    ultraGridBand3.Override.ActiveRowAppearance = (AppearanceBase) appearance9;
    ultraGridBand3.Override.AllowUpdate = (DefaultableBoolean) 2;
    appearance10.BackColor = Color.White;
    appearance10.BackColor2 = Color.Gainsboro;
    appearance10.BackGradientAlignment = (GradientAlignment) 2;
    appearance10.BackGradientStyle = (GradientStyle) 3;
    appearance10.BorderColor = Color.DarkGray;
    ultraGridBand3.Override.CardAreaAppearance = (AppearanceBase) appearance10;
    appearance11.BackColor = Color.Beige;
    appearance11.ForeColor = Color.Black;
    ultraGridBand3.Override.CardCaptionAppearance = (AppearanceBase) appearance11;
    appearance12.BackColor = Color.Ivory;
    appearance12.BackColor2 = Color.White;
    appearance12.BackGradientAlignment = (GradientAlignment) 2;
    appearance12.BackGradientStyle = (GradientStyle) 2;
    ultraGridBand3.Override.CellAppearance = (AppearanceBase) appearance12;
    ultraGridBand3.Override.CellClickAction = (CellClickAction) 2;
    ultraGridBand3.Override.CellSpacing = 0;
    appearance13.BackColor = Color.White;
    appearance13.BackColor2 = Color.Gainsboro;
    appearance13.BackGradientAlignment = (GradientAlignment) 2;
    appearance13.BackGradientStyle = (GradientStyle) 3;
    ((AppearanceBase) appearance13).TextHAlignAsString = "Right";
    ultraGridBand3.Override.HeaderAppearance = (AppearanceBase) appearance13;
    ((UltraGridBase) this.ugInsuredNavigation).DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    ((UltraGridBase) this.ugInsuredNavigation).DisplayLayout.BandsSerializer.Add((object) ultraGridBand2);
    ((UltraGridBase) this.ugInsuredNavigation).DisplayLayout.BandsSerializer.Add((object) ultraGridBand3);
    ((UltraGridBase) this.ugInsuredNavigation).DisplayLayout.BorderStyle = (UIElementBorderStyle) 1;
    appearance14.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance14.ForeColor = Color.Black;
    ((UltraGridBase) this.ugInsuredNavigation).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance14;
    ((UltraGridBase) this.ugInsuredNavigation).DisplayLayout.Override.BorderStyleRowSelector = (UIElementBorderStyle) 4;
    appearance15.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugInsuredNavigation).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance15;
    ((UltraGridBase) this.ugInsuredNavigation).DisplayLayout.Override.ExpansionIndicator = (ShowExpansionIndicator) 1;
    appearance16.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    appearance16.ForeColor = Color.Black;
    ((UltraGridBase) this.ugInsuredNavigation).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance16;
    ((UltraGridBase) this.ugInsuredNavigation).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance17.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.ugInsuredNavigation).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance17;
    appearance18.BackColor = Color.White;
    appearance18.BorderColor = Color.LightGray;
    appearance18.ForeColor = Color.Black;
    ((UltraGridBase) this.ugInsuredNavigation).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance18;
    ((UltraGridBase) this.ugInsuredNavigation).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance19.BackColor = Color.White;
    appearance19.ForeColor = Color.Black;
    ((UltraGridBase) this.ugInsuredNavigation).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance19;
    ((UltraGridBase) this.ugInsuredNavigation).DisplayLayout.RowConnectorColor = Color.Silver;
    ((Control) this.ugInsuredNavigation).Dock = DockStyle.Fill;
    ((Control) this.ugInsuredNavigation).Location = new Point(0, 23);
    ((Control) this.ugInsuredNavigation).Name = "ugInsuredNavigation";
    ((Control) this.ugInsuredNavigation).Size = new Size(742, 478);
    ((Control) this.ugInsuredNavigation).TabIndex = 8;
    ((UltraControlBase) this.ugInsuredNavigation).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.ugInsuredNavigation).UseOsThemes = (DefaultableBoolean) 2;
    this.panelSearch.BackColorInternal = Color.White;
    appearance20.BorderColor = Color.Gray;
    this.panelSearch.ContentAreaAppearance = (AppearanceBase) appearance20;
    ((Control) this.panelSearch).Controls.Add((Control) this.ball3Green);
    ((Control) this.panelSearch).Controls.Add((Control) this.ball2Green);
    ((Control) this.panelSearch).Controls.Add((Control) this.ball1Green);
    ((Control) this.panelSearch).Controls.Add((Control) this.ball3Gray);
    ((Control) this.panelSearch).Controls.Add((Control) this.ball2Gray);
    ((Control) this.panelSearch).Controls.Add((Control) this.ball1Gray);
    ((Control) this.panelSearch).Controls.Add((Control) this.labelSearchText);
    ((Control) this.panelSearch).Controls.Add((Control) this.AnimationControl1);
    ((Control) this.panelSearch).Controls.Add((Control) label);
    ((Control) this.panelSearch).ForeColor = Color.Black;
    ((Control) this.panelSearch).Location = new Point(214, 221);
    ((Control) this.panelSearch).Name = "panelSearch";
    ((Control) this.panelSearch).Size = new Size(330, 91);
    ((Control) this.panelSearch).TabIndex = 15;
    ((Control) this.panelSearch).Visible = false;
    this.ball3Green.Image = (Image) componentResourceManager.GetObject("ball3Green.Image");
    this.ball3Green.Location = new Point(291, 65);
    this.ball3Green.Name = "ball3Green";
    this.ball3Green.Size = new Size(16 /*0x10*/, 16 /*0x10*/);
    this.ball3Green.SizeMode = PictureBoxSizeMode.AutoSize;
    this.ball3Green.TabIndex = 9;
    this.ball3Green.TabStop = false;
    this.ball3Green.Visible = false;
    this.ball2Green.Image = (Image) componentResourceManager.GetObject("ball2Green.Image");
    this.ball2Green.Location = new Point(269, 65);
    this.ball2Green.Name = "ball2Green";
    this.ball2Green.Size = new Size(16 /*0x10*/, 16 /*0x10*/);
    this.ball2Green.SizeMode = PictureBoxSizeMode.AutoSize;
    this.ball2Green.TabIndex = 8;
    this.ball2Green.TabStop = false;
    this.ball2Green.Visible = false;
    this.ball1Green.Image = (Image) componentResourceManager.GetObject("ball1Green.Image");
    this.ball1Green.Location = new Point(247, 65);
    this.ball1Green.Name = "ball1Green";
    this.ball1Green.Size = new Size(16 /*0x10*/, 16 /*0x10*/);
    this.ball1Green.SizeMode = PictureBoxSizeMode.AutoSize;
    this.ball1Green.TabIndex = 7;
    this.ball1Green.TabStop = false;
    this.ball1Green.Visible = false;
    this.ball3Gray.Image = (Image) componentResourceManager.GetObject("ball3Gray.Image");
    this.ball3Gray.Location = new Point(171, 65);
    this.ball3Gray.Name = "ball3Gray";
    this.ball3Gray.Size = new Size(16 /*0x10*/, 16 /*0x10*/);
    this.ball3Gray.SizeMode = PictureBoxSizeMode.AutoSize;
    this.ball3Gray.TabIndex = 6;
    this.ball3Gray.TabStop = false;
    this.ball2Gray.Image = (Image) componentResourceManager.GetObject("ball2Gray.Image");
    this.ball2Gray.Location = new Point(149, 65);
    this.ball2Gray.Name = "ball2Gray";
    this.ball2Gray.Size = new Size(16 /*0x10*/, 16 /*0x10*/);
    this.ball2Gray.SizeMode = PictureBoxSizeMode.AutoSize;
    this.ball2Gray.TabIndex = 5;
    this.ball2Gray.TabStop = false;
    this.ball1Gray.Image = (Image) componentResourceManager.GetObject("ball1Gray.Image");
    this.ball1Gray.Location = new Point((int) sbyte.MaxValue, 65);
    this.ball1Gray.Name = "ball1Gray";
    this.ball1Gray.Size = new Size(16 /*0x10*/, 16 /*0x10*/);
    this.ball1Gray.SizeMode = PictureBoxSizeMode.AutoSize;
    this.ball1Gray.TabIndex = 4;
    this.ball1Gray.TabStop = false;
    this.labelSearchText.Font = new Font("Tahoma", 8f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.labelSearchText.Location = new Point(12, 43);
    this.labelSearchText.Name = "labelSearchText";
    this.labelSearchText.Size = new Size(299, 19);
    this.labelSearchText.TabIndex = 3;
    this.labelSearchText.Text = "Getting insureds ...";
    this.labelSearchText.TextAlign = ContentAlignment.MiddleCenter;
    this.AnimationControl1.AnimationSource = (AnimationType) 151;
    this.AnimationControl1.AutoPlay = true;
    this.AnimationControl1.BorderStyle = BorderStyle.None;
    ((Control) this.AnimationControl1).Location = new Point(44, 14);
    ((Control) this.AnimationControl1).Name = "AnimationControl1";
    ((Control) this.AnimationControl1).Size = new Size(20, 20);
    ((Control) this.AnimationControl1).TabIndex = 2;
    this.DragDropOutlookExtender1.DropTarget = (Control) this.ugInsuredNavigation;
    this.tt.ShowAlways = true;
    ((Control) this._frmClearance_Toolbars_Dock_Area_Left).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._frmClearance_Toolbars_Dock_Area_Left).BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this._frmClearance_Toolbars_Dock_Area_Left.DockedPosition = (DockedPosition) 2;
    ((Control) this._frmClearance_Toolbars_Dock_Area_Left).ForeColor = Color.Black;
    ((Control) this._frmClearance_Toolbars_Dock_Area_Left).Location = new Point(0, 23);
    ((Control) this._frmClearance_Toolbars_Dock_Area_Left).Name = "_frmClearance_Toolbars_Dock_Area_Left";
    ((Control) this._frmClearance_Toolbars_Dock_Area_Left).Size = new Size(0, 478);
    this._frmClearance_Toolbars_Dock_Area_Left.ToolbarsManager = this.toolBar;
    appearance21.BackColor = Color.White;
    appearance21.ForeColor = Color.Black;
    appearance21.ForeColorDisabled = Color.DarkGray;
    this.toolBar.Appearance = (AppearanceBase) appearance21;
    this.toolBar.DesignerFlags = 1;
    this.toolBar.DockWithinContainer = (Control) this;
    this.toolBar.DockWithinContainerBaseType = typeof (Form);
    this.toolBar.MdiMergeable = false;
    this.toolBar.ShowFullMenusDelay = 500;
    this.toolBar.Style = (ToolbarStyle) 5;
    ultraToolbar1.DockedColumn = 0;
    ultraToolbar1.DockedPosition = (DockedPosition) 1;
    ultraToolbar1.DockedRow = 0;
    ((UltraToolbarBase) ultraToolbar1).NonInheritedTools.AddRange(new ToolBase[6]
    {
      (ToolBase) buttonTool1,
      (ToolBase) buttonTool2,
      (ToolBase) buttonTool3,
      (ToolBase) buttonTool4,
      (ToolBase) buttonTool5,
      (ToolBase) buttonTool6
    });
    ultraToolbar1.Settings.AllowCustomize = (DefaultableBoolean) 2;
    ultraToolbar1.Settings.AllowDockLeft = (DefaultableBoolean) 2;
    ultraToolbar1.Settings.AllowDockRight = (DefaultableBoolean) 2;
    ultraToolbar1.Settings.AllowDockTop = (DefaultableBoolean) 2;
    ultraToolbar1.Settings.AllowFloating = (DefaultableBoolean) 2;
    ((SettingsBase) ultraToolbar1.Settings).ToolDisplayStyle = (ToolDisplayStyle) 4;
    ultraToolbar1.Text = "toolbarClearance";
    ultraToolbar2.DockedColumn = 0;
    ultraToolbar2.DockedRow = 0;
    ultraToolbar2.FloatingLocation = new Point(78, 268);
    ultraToolbar2.FloatingSize = new Size(112 /*0x70*/, 48 /*0x30*/);
    ultraToolbar2.Text = "contextMenu";
    this.toolBar.Toolbars.AddRange(new UltraToolbar[2]
    {
      ultraToolbar1,
      ultraToolbar2
    });
    this.toolBar.ToolbarSettings.AllowCustomize = (DefaultableBoolean) 2;
    this.toolBar.ToolbarSettings.AllowFloating = (DefaultableBoolean) 2;
    this.toolBar.ToolbarSettings.AllowHiding = (DefaultableBoolean) 2;
    this.toolBar.ToolbarSettings.FillEntireRow = (DefaultableBoolean) 1;
    this.toolBar.ToolbarSettings.GrabHandleStyle = (GrabHandleStyle) 1;
    ((ToolbarSettingsBase) this.toolBar.ToolbarSettings).PaddingBottom = 5;
    ((ToolbarSettingsBase) this.toolBar.ToolbarSettings).PaddingLeft = 10;
    ((ToolbarSettingsBase) this.toolBar.ToolbarSettings).ToolSpacing = 15;
    ((ToolPropsBase) ((ToolBase) buttonTool7).SharedPropsInternal).Caption = "New &Insured";
    ((ToolBase) buttonTool7).SharedPropsInternal.Category = "Toolbar";
    ((ToolPropsBase) ((ToolBase) buttonTool8).SharedPropsInternal).Caption = "New &Submission";
    ((ToolBase) buttonTool8).SharedPropsInternal.Category = "Toolbar";
    ((ToolPropsBase) ((ToolBase) buttonTool9).SharedPropsInternal).Caption = "&Edit Submission";
    ((ToolBase) buttonTool9).SharedPropsInternal.Category = "Toolbar";
    ((ToolBase) buttonTool9).SharedPropsInternal.Enabled = false;
    ((ToolPropsBase) ((ToolBase) buttonTool10).SharedPropsInternal).Caption = "New &Quote";
    ((ToolBase) buttonTool10).SharedPropsInternal.Category = "Toolbar";
    ((ToolBase) buttonTool10).SharedPropsInternal.Enabled = false;
    ((ToolPropsBase) ((ToolBase) buttonTool11).SharedPropsInternal).Caption = "&Open Quote";
    ((ToolBase) buttonTool11).SharedPropsInternal.Category = "Toolbar";
    ((ToolBase) buttonTool11).SharedPropsInternal.Enabled = false;
    ((ToolPropsBase) ((ToolBase) popupMenuTool).SharedPropsInternal).Caption = "ContextMenu";
    ((ToolsCollectionBase) popupMenuTool.Tools).AddRange(new ToolBase[24]
    {
      (ToolBase) buttonTool12,
      (ToolBase) buttonTool13,
      (ToolBase) buttonTool14,
      (ToolBase) buttonTool15,
      (ToolBase) buttonTool16,
      (ToolBase) buttonTool17,
      (ToolBase) buttonTool18,
      (ToolBase) buttonTool19,
      (ToolBase) buttonTool20,
      (ToolBase) buttonTool21,
      (ToolBase) buttonTool22,
      (ToolBase) buttonTool23,
      (ToolBase) buttonTool24,
      (ToolBase) buttonTool25,
      (ToolBase) buttonTool26,
      (ToolBase) buttonTool27,
      (ToolBase) buttonTool28,
      (ToolBase) buttonTool29,
      (ToolBase) buttonTool30,
      (ToolBase) buttonTool31,
      (ToolBase) buttonTool32,
      (ToolBase) buttonTool33,
      (ToolBase) buttonTool34,
      (ToolBase) buttonTool35
    });
    ((ToolPropsBase) ((ToolBase) buttonTool36).SharedPropsInternal).Caption = "Expand All";
    ((ToolBase) buttonTool36).SharedPropsInternal.Category = "ContextMenu";
    ((ToolPropsBase) ((ToolBase) buttonTool37).SharedPropsInternal).Caption = "Collapse All";
    ((ToolBase) buttonTool37).SharedPropsInternal.Category = "ContextMenu";
    ((ToolPropsBase) ((ToolBase) buttonTool38).SharedPropsInternal).Caption = "Delete Insured";
    ((ToolBase) buttonTool38).SharedPropsInternal.Category = "ContextMenu";
    ((ToolPropsBase) ((ToolBase) buttonTool39).SharedPropsInternal).Caption = "Delete Submission";
    ((ToolBase) buttonTool39).SharedPropsInternal.Category = "ContextMenu";
    ((ToolPropsBase) ((ToolBase) buttonTool40).SharedPropsInternal).Caption = "Duplicate Submission";
    ((ToolBase) buttonTool40).SharedPropsInternal.Category = "ContextMenu";
    ((ToolPropsBase) ((ToolBase) buttonTool41).SharedPropsInternal).Caption = "Duplicate Quote";
    ((ToolBase) buttonTool41).SharedPropsInternal.Category = "ContextMenu";
    ((ToolPropsBase) ((ToolBase) buttonTool42).SharedPropsInternal).Caption = "Renew Policy";
    ((ToolBase) buttonTool42).SharedPropsInternal.Category = "ContextMenu";
    ((ToolPropsBase) ((ToolBase) buttonTool43).SharedPropsInternal).Caption = "Delete Quote";
    ((ToolBase) buttonTool43).SharedPropsInternal.Category = "ContextMenu";
    ((ToolPropsBase) ((ToolBase) buttonTool44).SharedPropsInternal).Caption = "Edit Quote";
    ((ToolBase) buttonTool44).SharedPropsInternal.Category = "ContextMenu";
    ((ToolPropsBase) ((ToolBase) buttonTool45).SharedPropsInternal).Caption = "Unbind Policy";
    ((ToolBase) buttonTool45).SharedPropsInternal.Category = "ContextMenu";
    ((ToolPropsBase) ((ToolBase) buttonTool46).SharedPropsInternal).Caption = "Print Quote";
    ((ToolBase) buttonTool46).SharedPropsInternal.Category = "ContextMenu";
    ((ToolPropsBase) ((ToolBase) buttonTool47).SharedPropsInternal).Caption = "Submission Overview";
    ((ToolBase) buttonTool47).SharedPropsInternal.Category = "ContextMenu";
    ((ToolPropsBase) ((ToolBase) buttonTool48).SharedPropsInternal).Caption = "Rewrite Policy";
    ((ToolPropsBase) ((ToolBase) buttonTool48).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((ToolPropsBase) ((ToolBase) buttonTool49).SharedPropsInternal).Caption = "Insured Summary";
    ((ToolBase) buttonTool49).SharedPropsInternal.Category = "ContextMenu";
    ((ToolPropsBase) ((ToolBase) buttonTool50).SharedPropsInternal).Caption = "Print All Quotes in Submission";
    ((ToolPropsBase) ((ToolBase) buttonTool51).SharedPropsInternal).Caption = "Change Quote Status Reason";
    ((ToolBase) buttonTool51).SharedPropsInternal.Category = "ContextMenu";
    ((ToolPropsBase) ((ToolBase) buttonTool52).SharedPropsInternal).Caption = "Bind Quotes in Submission";
    ((ToolPropsBase) ((ToolBase) buttonTool53).SharedPropsInternal).Caption = "Quote Option Details";
    ((ToolBase) buttonTool53).SharedPropsInternal.Category = "ContextMenu";
    ((ToolPropsBase) ((ToolBase) buttonTool54).SharedPropsInternal).Caption = "Renew All";
    ((ToolPropsBase) ((ToolBase) buttonTool55).SharedPropsInternal).Caption = "Print Binders in Submission";
    ((ToolPropsBase) ((ToolBase) buttonTool56).SharedPropsInternal).Caption = "Change Underwriter";
    ((ToolPropsBase) ((ToolBase) buttonTool57).SharedPropsInternal).Caption = "Submission Inspection Requests";
    ((ToolBase) buttonTool57).SharedPropsInternal.Category = "ContextMenu";
    ((ToolPropsBase) ((ToolBase) buttonTool58).SharedPropsInternal).Caption = "Move Insured";
    ((ToolBase) buttonTool58).SharedPropsInternal.Category = "ContextMenu";
    this.toolBar.Tools.AddRange(new ToolBase[29]
    {
      (ToolBase) buttonTool7,
      (ToolBase) buttonTool8,
      (ToolBase) buttonTool9,
      (ToolBase) buttonTool10,
      (ToolBase) buttonTool11,
      (ToolBase) popupMenuTool,
      (ToolBase) buttonTool36,
      (ToolBase) buttonTool37,
      (ToolBase) buttonTool38,
      (ToolBase) buttonTool39,
      (ToolBase) buttonTool40,
      (ToolBase) buttonTool41,
      (ToolBase) buttonTool42,
      (ToolBase) buttonTool43,
      (ToolBase) buttonTool44,
      (ToolBase) buttonTool45,
      (ToolBase) buttonTool46,
      (ToolBase) buttonTool47,
      (ToolBase) buttonTool48,
      (ToolBase) buttonTool49,
      (ToolBase) buttonTool50,
      (ToolBase) buttonTool51,
      (ToolBase) buttonTool52,
      (ToolBase) buttonTool53,
      (ToolBase) buttonTool54,
      (ToolBase) buttonTool55,
      (ToolBase) buttonTool56,
      (ToolBase) buttonTool57,
      (ToolBase) buttonTool58
    });
    ((UltraComponentControlManagerBase) this.toolBar).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this._frmClearance_Toolbars_Dock_Area_Right).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._frmClearance_Toolbars_Dock_Area_Right).BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this._frmClearance_Toolbars_Dock_Area_Right.DockedPosition = (DockedPosition) 3;
    ((Control) this._frmClearance_Toolbars_Dock_Area_Right).ForeColor = Color.Black;
    ((Control) this._frmClearance_Toolbars_Dock_Area_Right).Location = new Point(742, 23);
    ((Control) this._frmClearance_Toolbars_Dock_Area_Right).Name = "_frmClearance_Toolbars_Dock_Area_Right";
    ((Control) this._frmClearance_Toolbars_Dock_Area_Right).Size = new Size(0, 478);
    this._frmClearance_Toolbars_Dock_Area_Right.ToolbarsManager = this.toolBar;
    ((Control) this._frmClearance_Toolbars_Dock_Area_Top).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._frmClearance_Toolbars_Dock_Area_Top).BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this._frmClearance_Toolbars_Dock_Area_Top.DockedPosition = (DockedPosition) 0;
    ((Control) this._frmClearance_Toolbars_Dock_Area_Top).ForeColor = Color.Black;
    ((Control) this._frmClearance_Toolbars_Dock_Area_Top).Location = new Point(0, 0);
    ((Control) this._frmClearance_Toolbars_Dock_Area_Top).Name = "_frmClearance_Toolbars_Dock_Area_Top";
    ((Control) this._frmClearance_Toolbars_Dock_Area_Top).Size = new Size(742, 23);
    this._frmClearance_Toolbars_Dock_Area_Top.ToolbarsManager = this.toolBar;
    ((Control) this._frmClearance_Toolbars_Dock_Area_Bottom).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._frmClearance_Toolbars_Dock_Area_Bottom).BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this._frmClearance_Toolbars_Dock_Area_Bottom.DockedPosition = (DockedPosition) 1;
    ((Control) this._frmClearance_Toolbars_Dock_Area_Bottom).ForeColor = Color.Black;
    ((Control) this._frmClearance_Toolbars_Dock_Area_Bottom).Location = new Point(0, 501);
    ((Control) this._frmClearance_Toolbars_Dock_Area_Bottom).Name = "_frmClearance_Toolbars_Dock_Area_Bottom";
    ((Control) this._frmClearance_Toolbars_Dock_Area_Bottom).Size = new Size(742, 31 /*0x1F*/);
    this._frmClearance_Toolbars_Dock_Area_Bottom.ToolbarsManager = this.toolBar;
    this.AutoScaleBaseSize = new Size(5, 14);
    this.ClientSize = new Size(742, 532);
    this.Controls.Add((Control) this.panelSearch);
    this.Controls.Add((Control) this.ugInsuredNavigation);
    this.Controls.Add((Control) this._frmClearance_Toolbars_Dock_Area_Left);
    this.Controls.Add((Control) this._frmClearance_Toolbars_Dock_Area_Right);
    this.Controls.Add((Control) this._frmClearance_Toolbars_Dock_Area_Bottom);
    this.Controls.Add((Control) this._frmClearance_Toolbars_Dock_Area_Top);
    this.DoubleBuffered = true;
    this.Font = new Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.MinimumSize = new Size(588, 532);
    this.Name = nameof (frmClearance);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Insured Navigation";
    this.DsInsuredNavigation.EndInit();
    ((ISupportInitialize) this.ugInsuredNavigation).EndInit();
    ((ISupportInitialize) this.panelSearch).EndInit();
    ((Control) this.panelSearch).ResumeLayout(false);
    ((Control) this.panelSearch).PerformLayout();
    ((ISupportInitialize) this.ball3Green).EndInit();
    ((ISupportInitialize) this.ball2Green).EndInit();
    ((ISupportInitialize) this.ball1Green).EndInit();
    ((ISupportInitialize) this.ball3Gray).EndInit();
    ((ISupportInitialize) this.ball2Gray).EndInit();
    ((ISupportInitialize) this.ball1Gray).EndInit();
    ((ISupportInitialize) this.toolBar).EndInit();
    this.ResumeLayout(false);
  }

  protected SqlDataAdapter daInsureds
  {
    get => this._daInsureds as SqlDataAdapter;
    set => this._daInsureds = (DbDataAdapter) value;
  }

  protected SqlDataAdapter daProducerSubmissions
  {
    get => this._daProducerSubmissions as SqlDataAdapter;
    set => this._daProducerSubmissions = (DbDataAdapter) value;
  }

  protected SqlDataAdapter daQuotes
  {
    get => this._daQuotes as SqlDataAdapter;
    set => this._daQuotes = (DbDataAdapter) value;
  }

  public frmClearance()
  {
    this.Load += new EventHandler(this.frmClearance_Load);
    this.Closing += new CancelEventHandler(this.frmClearance_Closing);
    this._cnDB = DefaultDatabase.CreateDbConnection();
    this._hlk = new HyperlinkEditor();
    this.AUTO_EXPAND_ON_SINGLE_RESULT = true;
    this._pastDueDictionary = new Dictionary<int, bool>();
    this._currencySymbolDictionary = new Dictionary<int, CultureInfo>();
    this._identifyPassDueAccount = SystemSettings.GetLazySetting<bool>("IdentifyPassDueAccountOnClearanceSearch", false, true);
    this._viewSubmissionInspectionRequests = SystemSettings.GetLazySetting<bool>("ViewSubmissionInspectionRequests", false, true);
    this._colorCodeBoundCards = SystemSettings.GetLazySetting<bool>("ColorCodeBoundClearanceCards", false, true);
    this._canRenewOnCancelledPolicy = SystemSettings.GetLazySetting<bool>("CanRenewOnCancelledPolicy", false, true);
    this._showDuplicateQuoteMenuOption = SystemSettings.GetLazySetting<bool>("Card.Show.DuplicateQuote.MenuOption", false, true);
    this._tagInformationHeader = SystemSettings.GetLazySetting<string>("ClearanceSettings.Card.TagInformationHeader", "", true);
    this._tagInformationDocTag = SystemSettings.GetLazySetting<string>("ClearanceSettings.Card.TagInformationDocTag", "", true);
    this._displayCurrencySymbol = SystemSettings.GetLazySetting<bool>("ClearanceSettings.Card.DisplayCurrencySymbol", false, true);
    this._quoteStatusCommentsCache = new Dictionary<int, string>();
    this.InitializeComponent();
    Utility.SetDataAdapterConnections(this._daInsureds, this._cnDB, (DbTransaction) null);
    Utility.SetDataAdapterConnections(this._daProducerSubmissions, this._cnDB, (DbTransaction) null);
    Utility.SetDataAdapterConnections(this._daQuotes, this._cnDB, (DbTransaction) null);
    this.ball1Green.Location = this.ball1Gray.Location;
    this.ball2Green.Location = this.ball2Gray.Location;
    this.ball3Green.Location = this.ball3Gray.Location;
    this._notesImage = new Bitmap(Assembly.GetExecutingAssembly().GetManifestResourceStream("MGASystems.IMS.Policies.note_edit.png"));
    this._hlk.HyperLinkOpening += new CancelEventHandler(this.GridBandsHyperLinkOpening);
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing)
    {
      if (this.components != null)
        this.components.Dispose();
      ((DisposableObject) this._hlk)?.Dispose();
      this._notesImage?.Dispose();
    }
    base.Dispose(disposing);
  }

  private ITagParserFactory TagParserFactoryInstance
  {
    get
    {
      if (this._tagParserFactoryInstance == null)
        this._tagParserFactoryInstance = (ITagParserFactory) ObjectFactory.Instance.CreateObjectAs<TagParserFactory>(new object[0]);
      return this._tagParserFactoryInstance;
    }
  }

  private Stream GridLayout
  {
    get
    {
      if (this._layoutStream == null)
        this._layoutStream = new MemoryStream();
      return (Stream) this._layoutStream;
    }
  }

  private Guid CurrentSubmissionGroupGuid
  {
    get
    {
      UltraGridRow activeRow = ((UltraGridBase) this.ugInsuredNavigation).ActiveRow;
      Guid empty;
      if (activeRow == null)
      {
        empty = Guid.Empty;
      }
      else
      {
        switch (activeRow.Band.Index)
        {
          case 0:
            empty = Guid.Empty;
            break;
          case 1:
            empty = (Guid) activeRow.Cells["SubmissionGroupGuid"].Value;
            break;
          case 2:
            empty = (Guid) activeRow.Cells["SubmissionGroupGuid"].Value;
            break;
        }
      }
      return empty;
    }
  }

  public Guid CurrentSelectedInsuredGuid
  {
    get
    {
      UltraGridRow activeRow = ((UltraGridBase) this.ugInsuredNavigation).ActiveRow;
      Guid empty;
      if (activeRow == null)
      {
        empty = Guid.Empty;
      }
      else
      {
        switch (activeRow.Band.Index)
        {
          case 0:
            empty = (Guid) activeRow.Cells["InsuredGuid"].Value;
            break;
          case 1:
            empty = (Guid) activeRow.Cells["InsuredGuid"].Value;
            break;
          case 2:
            empty = (Guid) activeRow.ParentRow.Cells["InsuredGuid"].Value;
            break;
        }
      }
      return empty;
    }
  }

  public void UpdatePolicyNumber(Guid quoteGuid, string newPolicyNumber)
  {
    dsInsuredNavigation.tblLinesToCompanyRow byQuoteGuid = this.DsInsuredNavigation.tblLinesToCompany.FindByQuoteGuid(quoteGuid);
    if (byQuoteGuid == null)
      return;
    byQuoteGuid.PolicyNumber = newPolicyNumber;
    ((UltraGridBase) this.ugInsuredNavigation).Rows.Refresh((RefreshRow) 2, true);
  }

  public event frmClearance.SearchCompleteEventHandler SearchComplete;

  public void InitiateSearch(ClearanceSearchInfo searchInfo)
  {
    if (((Control) this.panelSearch).Visible)
      return;
    if (!SecurityManager.Instance.AssertPermission("{BCC1051B-E71E-4693-9335-8F535A8C3C50}"))
    {
      int num = (int) MessageBox.Show("You do not have the authorization to perform clearance searches.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
    else
    {
      this.Cursor = MgaCursors.Working;
      ((Control) this.AnimationControl1).Visible = true;
      this.AnimationControl1.Play();
      this.ball1Green.Visible = false;
      this.ball2Green.Visible = false;
      this.ball3Green.Visible = false;
      this.labelSearchText.Text = "Getting insureds ...";
      ((Control) this.panelSearch).Visible = true;
      this.Refresh();
      this._searchInfo = searchInfo;
      this.ugInsuredNavigation.AfterRowActivate -= new EventHandler(this.ugInsuredNavigation_AfterRowActivate);
      DbCommand selectCommand = this._daInsureds.SelectCommand;
      selectCommand.Parameters["@InsuredStateID"].Value = (object) this._searchInfo.InsuredStateID;
      selectCommand.Parameters["@InsuredID"].Value = (object) this._searchInfo.InsuredID;
      selectCommand.Parameters["@SubmissionID"].Value = (object) this._searchInfo.SubmissionID;
      selectCommand.Parameters["@NumResults"].Value = (object) this._searchInfo.NumResults;
      selectCommand.Parameters["@StartsWith"].Value = (object) this._searchInfo.StartsWith;
      selectCommand.Parameters["@InsuredName"].Value = this._searchInfo.InsuredName == null ? (object) null : (object) this._searchInfo.InsuredName.ToString().Replace("'", "''");
      selectCommand.Parameters["@InsuredPhone"].Value = (object) this._searchInfo.InsuredPhone;
      selectCommand.Parameters["@Address"].Value = (object) this._searchInfo.Address;
      selectCommand.Parameters["@Address1"].Value = (object) null;
      selectCommand.Parameters["@ProducerLocationGuid"].Value = (object) this._searchInfo.ProducerLocationGuid;
      selectCommand.Parameters["@BusinessTypeID"].Value = (object) this._searchInfo.BusinessTypeID;
      selectCommand.Parameters["@FEIN"].Value = (object) this._searchInfo.FEIN;
      if (!this._searchInfo.QuotingOffice.Equals((object) Guid.Empty))
        selectCommand.Parameters["@QuotingOffice"].Value = (object) this._searchInfo.QuotingOffice;
      if (!this._searchInfo.IssuingOffice.Equals((object) Guid.Empty))
        selectCommand.Parameters["@IssuingOffice"].Value = (object) this._searchInfo.IssuingOffice;
      selectCommand.Parameters["@ProducerEmail"].Value = (object) this._searchInfo.ProducerEmail;
      selectCommand.Parameters["@InsuredCity"].Value = (object) this._searchInfo.InsuredCity;
      selectCommand.Parameters["@RiskID"].Value = (object) this._searchInfo.RiskID;
      this.SetPolicyParameters(this._daInsureds.SelectCommand, frmClearance.SelectCommandType.Insureds);
      dsInsuredNavigation insuredNavigation = this.DsInsuredNavigation;
      if (insuredNavigation.tblLinesToCompany.Rows.Count > 0)
      {
        try
        {
          insuredNavigation.tblLinesToCompany.Clear();
        }
        catch (ArgumentOutOfRangeException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          ProjectData.ClearProjectError();
        }
      }
      if (insuredNavigation.tblProducerSubmissions.Rows.Count > 0)
      {
        try
        {
          insuredNavigation.tblProducerSubmissions.Clear();
        }
        catch (ArgumentOutOfRangeException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          ProjectData.ClearProjectError();
        }
      }
      if (insuredNavigation.tblInsureds.Rows.Count > 0)
      {
        try
        {
          insuredNavigation.tblInsureds.Clear();
        }
        catch (ArgumentOutOfRangeException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          ProjectData.ClearProjectError();
        }
      }
      ((UltraGridBase) this.ugInsuredNavigation).DisplayLayout.Save(this.GridLayout);
      ((UltraGridBase) this.ugInsuredNavigation).DataSource = (object) null;
      ThreadPool.QueueUserWorkItem(new WaitCallback(this.DoSearch));
    }
  }

  private void SearchCompleted()
  {
    try
    {
      this.ball1Green.Visible = true;
      if (((UltraGridBase) this.ugInsuredNavigation).DisplayLayout != null)
      {
        this._inSearch = false;
        ((UltraGridBase) this.ugInsuredNavigation).DataSource = (object) this.DsInsuredNavigation.tblInsureds;
        this.GridLayout.Position = 0L;
        ((UltraGridBase) this.ugInsuredNavigation).DisplayLayout.Load(this.GridLayout);
        ((UltraGridBase) this.ugInsuredNavigation).DisplayLayout.ScrollBarLook.ViewStyle = (ScrollBarViewStyle) 3;
        this.SetupGridLayout();
        this.Refresh();
        if (this._searchInfo.IsSinglePolicySearch)
          ((UltraGridBase) this.ugInsuredNavigation).Rows.ExpandAll(true);
        else if (this.AUTO_EXPAND_ON_SINGLE_RESULT && this.DsInsuredNavigation.tblInsureds.Rows.Count == 1)
          ((UltraGridBase) this.ugInsuredNavigation).Rows[0].Expanded = true;
        int count = this.DsInsuredNavigation.tblInsureds.Rows.Count;
        if (count == this._searchInfo.NumResults && CurrentUser.Instance.UsingXP)
          this.TabClearanceSearch.ShowBalloonTip("Search Limited", $"Your search was limited to the top {count.ToString()} results.", (BalloonTip.BalloonTipIcons) 1);
        this.ugInsuredNavigation.AfterRowActivate += new EventHandler(this.ugInsuredNavigation_AfterRowActivate);
        MDIControls.Instance.StatusBarText = this.DsInsuredNavigation.tblInsureds.Rows.Count.ToString() + " insureds found which matched your criteria.";
        if (this._searchInfo.IsSinglePolicySearch && this._quoteSearchStartTime.Subtract(DateAndTime.Now).Seconds < 2)
          Thread.Sleep(500);
        if (!this.ball2Green.Visible)
        {
          this.ball2Green.Visible = true;
          Thread.Sleep(250);
        }
        if (!this.ball3Green.Visible)
        {
          this.ball3Green.Visible = true;
          Thread.Sleep(250);
        }
        ((Control) this.panelSearch).Visible = false;
        this.UpdateButtonEnabledState();
        // ISSUE: reference to a compiler-generated field
        ISupportNoteSystem.EntityInfoChangedEventHandler noteChangedEvent = this.NoteChangedEvent;
        if (noteChangedEvent != null)
          noteChangedEvent((object) this, EventArgs.Empty);
        // ISSUE: reference to a compiler-generated field
        ISupportDocumentSystem.EntityInfoChangedEventHandler documentChangedEvent = this.DocumentChangedEvent;
        if (documentChangedEvent != null)
          documentChangedEvent((object) this, EventArgs.Empty);
      }
    }
    catch (ObjectDisposedException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      ErrorHandler.SilentLogError((Exception) ex);
      ProjectData.ClearProjectError();
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      ErrorHandler.HandleError(ex);
      ProjectData.ClearProjectError();
    }
    // ISSUE: reference to a compiler-generated field
    frmClearance.SearchCompleteEventHandler searchCompleteEvent = this.SearchCompleteEvent;
    if (searchCompleteEvent != null)
      searchCompleteEvent((object) this, EventArgs.Empty);
    this.Cursor = MgaCursors.Default;
  }

  private void DoSearch(object state)
  {
    this._inSearch = true;
    this.FillInsureds(this.DsInsuredNavigation.tblInsureds);
    if (this.IsDisposed)
      return;
    if (this.Disposing)
      return;
    try
    {
      InvokeExtensions.BetterInvoke((ISynchronizeInvoke) MDIControls.Instance.MDIParent, (Delegate) new MethodInvoker(this.SearchCompleted), new object[0]);
    }
    catch (ObjectDisposedException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      ErrorHandler.SilentLogError((Exception) ex);
      ProjectData.ClearProjectError();
    }
  }

  public void AddQuote(
    Guid quoteGuid,
    Guid submissionGroupGuid,
    object companyLocationGuid,
    DateTime effectiveDate,
    DateTime expirationDate,
    string lineName,
    string companyName,
    int controlNo,
    string state,
    bool quickQuote)
  {
    // ISSUE: unable to decompile the method.
  }

  private void ActivateQuoteCard(Guid quoteGuid, UltraGridRow row)
  {
    for (UltraGridRow ultraGridRow = row.GetChild((ChildRow) 0); ultraGridRow != null; ultraGridRow = ultraGridRow.GetSibling((SiblingRow) 2))
    {
      if (ultraGridRow.Band.Index == 2 && ultraGridRow.Cells["QuoteGuid"].Value.Equals((object) quoteGuid))
      {
        this.ugInsuredNavigation.Selected.Rows.Clear();
        ultraGridRow.Selected = true;
        ultraGridRow.Activate();
        break;
      }
    }
  }

  public void RefreshSearch()
  {
    try
    {
      this.DsInsuredNavigation.tblLinesToCompany.Clear();
      this.DsInsuredNavigation.tblProducerSubmissions.Clear();
      this.DsInsuredNavigation.tblInsureds.Clear();
    }
    catch (ArgumentOutOfRangeException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      ErrorHandler.SilentLogError((Exception) ex);
      ProjectData.ClearProjectError();
    }
    this.FillInsureds(this.DsInsuredNavigation.tblInsureds);
  }

  public void SetQuickQuote(Guid quoteGuid, bool quickQuote)
  {
    if (this.DsInsuredNavigation.tblLinesToCompany.FindByQuoteGuid(quoteGuid) == null)
      return;
    try
    {
      this.DsInsuredNavigation.tblLinesToCompany.FindByQuoteGuid(quoteGuid).QuickQuote = quickQuote;
    }
    catch (ArgumentOutOfRangeException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      ErrorHandler.SilentLogError((Exception) ex);
      ProjectData.ClearProjectError();
    }
  }

  public void UpdateQuoteGuid(Guid originalQuoteGuid, Guid newQuoteGuid)
  {
    dsInsuredNavigation.tblLinesToCompanyRow byQuoteGuid = this.DsInsuredNavigation.tblLinesToCompany.FindByQuoteGuid(originalQuoteGuid);
    if (byQuoteGuid != null)
    {
      byQuoteGuid.QuoteGuid = newQuoteGuid;
      ((UltraGridBase) this.ugInsuredNavigation).Rows.Refresh((RefreshRow) 2, true);
    }
    this.RefreshControl(new Quote(newQuoteGuid).ControlNo);
  }

  [Obsolete("Please call the overload UpdateQuoteStatus that accepts only a quoteGuid as a parameter.")]
  public void UpdateQuoteStatus(Guid quoteGuid, QuoteStatus status)
  {
    this.UpdateQuoteStatus(quoteGuid);
  }

  internal void UpdateQuoteStatus(Guid quoteGuid)
  {
    dsInsuredNavigation.tblLinesToCompanyRow byQuoteGuid = this.DsInsuredNavigation.tblLinesToCompany.FindByQuoteGuid(quoteGuid);
    if (byQuoteGuid == null)
      return;
    Quote quote = new Quote(quoteGuid);
    byQuoteGuid.QuoteStatus = quote.DisplayStatus;
    ((UltraGridBase) this.ugInsuredNavigation).Rows.Refresh((RefreshRow) 2, true);
  }

  public void RefreshSubmissionGroup(
    Guid submissionGroupGuid,
    string producerName,
    string underWriter)
  {
    dsInsuredNavigation.tblProducerSubmissionsRow submissionGroupGuid1 = this.DsInsuredNavigation.tblProducerSubmissions.FindBySubmissionGroupGuid(submissionGroupGuid);
    if (submissionGroupGuid1 != null)
    {
      submissionGroupGuid1.Underwriter = underWriter;
      submissionGroupGuid1.Name = producerName;
      ((UltraGridBase) this.ugInsuredNavigation).UpdateData();
    }
    else
    {
      Cursor.Current = MgaCursors.WaitCursor;
      Guid InsuredGuid = DefaultDatabase.ExecuteScalar<Guid>(CommandType.Text, "SELECT InsuredGuid FROM tblSubmissionGroup WHERE SubmissionGroupGuid=@SGG", new object[2]
      {
        (object) "@SGG",
        (object) submissionGroupGuid
      });
      if (this.DsInsuredNavigation.tblInsureds.FindByInsuredGuid(InsuredGuid) == null)
        return;
      this._daProducerSubmissions.SelectCommand.Parameters["@InsuredGuid"].Value = (object) InsuredGuid;
      try
      {
        DefaultDatabase.DataAdapterFill(this._daProducerSubmissions, (DataTable) this.DsInsuredNavigation.tblProducerSubmissions);
      }
      catch (ArgumentOutOfRangeException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        ErrorHandler.SilentLogError((Exception) ex);
        ProjectData.ClearProjectError();
      }
      finally
      {
        Cursor.Current = MgaCursors.Default;
      }
      foreach (UltraGridRow row1 in ((UltraGridBase) this.ugInsuredNavigation).Rows)
      {
        if (row1.Band.Index == 0 && row1.Cells["InsuredGuid"].Value.Equals((object) InsuredGuid))
        {
          row1.Cells["SubmissionCount"].Value = (object) (Conversions.ToInteger(row1.Cells["SubmissionCount"].Value) + 1);
          row1.Expanded = true;
          this.InitializeRow(row1);
          foreach (UltraGridRow row2 in row1.ChildBands[0].Rows)
          {
            if (row2.Cells["SubmissionGroupGuid"].Value.Equals((object) submissionGroupGuid))
            {
              row2.ParentCollection.Move(row2, 0);
              ((UltraGridBase) this.ugInsuredNavigation).ActiveRowScrollRegion.ScrollRowIntoView(row1);
              break;
            }
          }
          break;
        }
      }
      this.AddSubmissionStatus(this.DsInsuredNavigation.tblProducerSubmissions);
    }
  }

  public void RefreshControl(int controlNo)
  {
    DataRow[] dataRowArray = this.DsInsuredNavigation.tblLinesToCompany.Select($"ControlNo = {controlNo}");
    if (dataRowArray == null || dataRowArray.Length != 1)
      return;
    dsInsuredNavigation.tblLinesToCompanyRow linesToCompanyRow = (dsInsuredNavigation.tblLinesToCompanyRow) dataRowArray[0];
    Exception exception;
    try
    {
      linesToCompanyRow.Delete();
      this.DsInsuredNavigation.tblLinesToCompany.AcceptChanges();
    }
    catch (Exception ex) when (
    {
      // ISSUE: unable to correctly present filter
      ProjectData.SetProjectError(ex);
      exception = ex;
      if (exception is ArgumentOutOfRangeException || exception is RowNotInTableException)
      {
        SuccessfulFiltering;
      }
      else
        throw;
    }
    )
    {
      ErrorHandler.SilentLogError(exception);
      ProjectData.ClearProjectError();
    }
    Quote quote = Quote.FromControlNo(controlNo);
    if (quote == null)
      return;
    this._daQuotes.SelectCommand.Parameters["@QuoteGuid"].Value = (object) quote.QuoteGuid;
    this.FillQuotes(this.DsInsuredNavigation.tblLinesToCompany);
  }

  public void UpdateQuote(Guid quoteGuid)
  {
    ((EventManagerBase) this.ugInsuredNavigation.EventManager).AllEventsEnabled = false;
    dsInsuredNavigation.tblLinesToCompanyDataTable tbl = new dsInsuredNavigation.tblLinesToCompanyDataTable();
    this._daQuotes.SelectCommand.Parameters["@QuoteGuid"].Value = (object) quoteGuid;
    this.FillQuotes(tbl);
    if (tbl.Rows.Count > 0)
    {
      if (this.DsInsuredNavigation.tblProducerSubmissions.FindBySubmissionGroupGuid(tbl[0].SubmissionGroupGuid) == null)
        return;
      DataRow[] dataRowArray = this.DsInsuredNavigation.tblLinesToCompany.Select("ControlNo=" + tbl[0]["ControlNo"].ToString());
      dsInsuredNavigation.tblLinesToCompanyRow row = dataRowArray == null || dataRowArray.Length == 0 ? this.DsInsuredNavigation.tblLinesToCompany.NewtblLinesToCompanyRow() : (dsInsuredNavigation.tblLinesToCompanyRow) dataRowArray[0];
      try
      {
        foreach (DataColumn column in (InternalDataCollectionBase) tbl.Columns)
        {
          if (row.Table.Columns.Contains(column.ColumnName))
            row[column.ColumnName] = RuntimeHelpers.GetObjectValue(tbl[0][column]);
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
      if (row.RowState == DataRowState.Detached)
      {
        try
        {
          this.DsInsuredNavigation.tblLinesToCompany.AddtblLinesToCompanyRow(row);
        }
        catch (ArgumentOutOfRangeException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          ErrorHandler.SilentLogError((Exception) ex);
          ProjectData.ClearProjectError();
        }
      }
    }
    ((UltraGridBase) this.ugInsuredNavigation).Rows.Refresh((RefreshRow) 2, true);
    ((EventManagerBase) this.ugInsuredNavigation.EventManager).AllEventsEnabled = true;
  }

  public TabClearanceSearch TabClearanceSearch
  {
    get => this._tabClearanceSearch;
    set => this._tabClearanceSearch = value;
  }

  public object GridTag
  {
    get => ((Control) this.ugInsuredNavigation).Tag;
    set => ((Control) this.ugInsuredNavigation).Tag = RuntimeHelpers.GetObjectValue(value);
  }

  protected Guid QuoteGuid
  {
    get
    {
      if (((UltraGridBase) this.ugInsuredNavigation).ActiveRow == null || ((UltraGridBase) this.ugInsuredNavigation).ActiveRow.Band.Index != 2)
        throw new InvalidOperationException("No quote selected");
      return (Guid) ((UltraGridBase) this.ugInsuredNavigation).ActiveRow.Cells[nameof (QuoteGuid)].Value;
    }
  }

  protected QuoteStatusChangeMenu QuoteStatusChangeMenu
  {
    get
    {
      this.LoadQuoteStatusChangeMenu();
      return this._statusChangeMenu;
    }
  }

  private void ugInsuredNavigation_BeforeRowsDeleted(object sender, BeforeRowsDeletedEventArgs e)
  {
    e.DisplayPromptMsg = false;
    if (e.Rows[0].Band.Index == 0)
    {
      if (this.DsInsuredNavigation.tblInsureds.FindByInsuredGuid((Guid) e.Rows[0].Cells["InsuredGuid"].Value) == null)
        return;
      ((CancelEventArgs) e).Cancel = true;
    }
    else if (e.Rows[0].Band.Index == 1)
    {
      if (this.DsInsuredNavigation.tblProducerSubmissions.FindBySubmissionGroupGuid((Guid) e.Rows[0].Cells["SubmissionGroupGuid"].Value) == null)
        return;
      ((CancelEventArgs) e).Cancel = true;
    }
    else
    {
      if (e.Rows[0].Band.Index != 2 || this.DsInsuredNavigation.tblLinesToCompany.FindByQuoteGuid((Guid) e.Rows[0].Cells["QuoteGuid"].Value) == null)
        return;
      ((CancelEventArgs) e).Cancel = true;
    }
  }

  private void ugInsuredNavigation_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Delete || ((UltraGridBase) this.ugInsuredNavigation).ActiveRow == null)
      return;
    if (((UltraGridBase) this.ugInsuredNavigation).ActiveRow.Band.Index == 0)
      this.DeleteInsured();
    else if (((UltraGridBase) this.ugInsuredNavigation).ActiveRow.Band.Index == 1)
    {
      this.DeleteSubmission();
    }
    else
    {
      if (((UltraGridBase) this.ugInsuredNavigation).ActiveRow.Band.Index != 2)
        return;
      DeleteQuoteOverride objectAs = ObjectFactory.Instance.CreateObjectAs<DeleteQuoteOverride>(new object[0]);
      Quote quote = Quote.CreateNew(this.QuoteGuid);
      Guid quoteGuid = this.QuoteGuid;
      if (!objectAs.CanDeleteQuote(quoteGuid) || (this.IsBound || quote.IsOriginalQuoteRecord) && quote.InvoiceCount != 0)
        return;
      this.DeleteQuote();
    }
  }

  private string MassageString(string tmpString)
  {
    bool flag = false;
    int num = tmpString.Length - 1;
    for (int index = 0; index <= num; ++index)
    {
      if (index > 0 && index % 50 == 0)
        flag = true;
      if (flag && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Conversions.ToString(tmpString[index]), " ", false) == 0)
      {
        tmpString = tmpString.Insert(index, Environment.NewLine);
        flag = false;
      }
    }
    return tmpString;
  }

  private void ugInsuredNavigation_MouseEnterElement(object sender, UIElementEventArgs e)
  {
    if (e.Element == null)
      return;
    if (e.Element is CellUIElement element)
    {
      if (((RowUIElement) ((UIElement) element).Parent.Parent).Row.IsCard)
      {
        try
        {
          UltraGridRow row = ((CellUIElementBase) element).Row;
          int num = (int) row.Cells["ControlNo"].Value;
          string str1 = string.Empty;
          string str2 = string.Empty;
          if (!this._quoteStatusCommentsCache.TryGetValue(num, out str1))
          {
            string str3 = DefaultDatabase.ExecuteScalar<string>(CommandType.Text, "SELECT TOP 1 QuoteStatusComment FROM tblQuotes WITH (NOLOCK) WHERE ControlNo=@CN And QuoteStatusComment Is Not NULL ORDER BY QuoteID DESC", new object[2]
            {
              (object) "@CN",
              (object) num
            });
            string str4 = DefaultDatabase.ExecuteScalar<string>(CommandType.Text, "SELECT TOP 1 q2.QuoteStatusReasonComment FROM tblQuotes q WITH (NOLOCK) INNER JOIN tblQuotes2 q2 WITH (NOLOCK) ON q2.QuoteID = q.QuoteID WHERE q.ControlNo=@CN And q2.QuoteStatusReasonComment Is Not NULL ORDER BY q.QuoteID DESC", new object[2]
            {
              (object) "@CN",
              (object) num
            });
            if (!string.IsNullOrEmpty(str3))
              str3 = this.MassageString($"Status Comment: {str3}");
            if (!string.IsNullOrEmpty(str4))
              str4 = this.MassageString($"Status Reason: {str4}");
            if (!string.IsNullOrEmpty(str3) || !string.IsNullOrEmpty(str4))
              str1 = $"{str3}{"\n"}{str4}".Trim("\n".ToCharArray());
            this._quoteStatusCommentsCache[num] = str1;
          }
          if (!string.IsNullOrEmpty(str1))
            str2 = str1;
          string empty = string.Empty;
          if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(row.Cells["RiskDescription"].Value)))
            empty = row.Cells["RiskDescription"].Value.ToString();
          if (!string.IsNullOrEmpty(empty))
          {
            if (!string.IsNullOrEmpty(str1))
              str2 += "\n\n";
            str2 = $"{str2}Risk Description: {empty}";
          }
          string caption = str2 + this.ExtendToolTipText(num);
          if (!string.IsNullOrEmpty(caption))
          {
            this.tt.SetToolTip((Control) this.ugInsuredNavigation, caption);
            return;
          }
          this.tt.SetToolTip((Control) this.ugInsuredNavigation, string.Empty);
          this.tt.Hide((IWin32Window) this.ugInsuredNavigation);
          return;
        }
        catch (NullReferenceException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          ErrorHandler.SilentLogError((Exception) ex);
          ProjectData.ClearProjectError();
          return;
        }
      }
    }
    this.tt.Hide((IWin32Window) this.ugInsuredNavigation);
  }

  protected virtual string ExtendToolTipText(int controlNo) => string.Empty;

  private void ugInsuredNavigation_AfterRowActivate(object sender, EventArgs e)
  {
    try
    {
      if (!this._inSearch)
      {
        // ISSUE: reference to a compiler-generated field
        ISupportNoteSystem.EntityInfoChangedEventHandler noteChangedEvent = this.NoteChangedEvent;
        if (noteChangedEvent != null)
          noteChangedEvent((object) this, e);
        // ISSUE: reference to a compiler-generated field
        ISupportDocumentSystem.EntityInfoChangedEventHandler documentChangedEvent = this.DocumentChangedEvent;
        if (documentChangedEvent != null)
          documentChangedEvent((object) this, e);
      }
      this.UpdateButtonEnabledState();
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      ErrorHandler.HandleError(ex);
      ProjectData.ClearProjectError();
    }
  }

  private void SetupGridLayout()
  {
    UltraGridLayout displayLayout = ((UltraGridBase) this.ugInsuredNavigation).DisplayLayout;
    displayLayout.Override.ExpansionIndicator = (ShowExpansionIndicator) 2;
    displayLayout.Bands[0].Columns["ViewSubmissions"].Editor = (EmbeddableEditorBase) this._hlk;
    displayLayout.Bands[1].Columns["ViewQuotes"].Editor = (EmbeddableEditorBase) this._hlk;
  }

  private void ugInsuredNavigation_DoubleClick(object sender, EventArgs e)
  {
    UIElement uiElement = ((UIElement) ((UltraGridBase) this.ugInsuredNavigation).DisplayLayout.UIElement).ElementFromPoint(((Control) this.ugInsuredNavigation).PointToClient(Cursor.Position));
    rowUiElement = (RowUIElement) null;
    switch (uiElement)
    {
      case null:
      case RowUIElement rowUiElement:
        if (rowUiElement == null)
          break;
        UltraGridRow context = (UltraGridRow) ((UIElement) rowUiElement).GetContext(typeof (UltraGridRow));
        if (context == null)
          break;
        this.ProcessGridRowDblClick(context);
        break;
      default:
        rowUiElement = uiElement.GetAncestor(typeof (RowUIElement)) as RowUIElement;
        goto case null;
    }
  }

  private void frmClearance_Load(object sender, EventArgs e)
  {
    if (this.DesignMode)
      return;
    try
    {
      if (!string.IsNullOrWhiteSpace(this._tagInformationHeader.Value) && !string.IsNullOrWhiteSpace(this._tagInformationDocTag.Value))
      {
        ((UltraGridBase) this.ugInsuredNavigation).DisplayLayout.Bands[2].Columns["TagInformation"].Hidden = false;
        ((HeaderBase) ((UltraGridBase) this.ugInsuredNavigation).DisplayLayout.Bands[2].Columns["TagInformation"].Header).Caption = this._tagInformationHeader.Value;
        ObjectFactory.Instance.CreateTypeFromString("MGASystems.IMS.DocumentAutomation.TemplateDocuments.DocTag");
        this._docTag = (IDocTag) ObjectFactory.Instance.CreateObjectAs<DocTag>(new object[0]);
        if (this._docTag != null)
          this._docTag.TagName = this._tagInformationDocTag.Value;
      }
      this._CanViewInsuredSummaryMenu = SecurityManager.Instance.AssertPermission("{552E167A-BA46-4D2E-879C-AC5A7D6DC387}");
      this._CanViewQuotesContextMenu = SecurityManager.Instance.AssertPermission("{B986C908-BCE5-44F8-80DF-22CBA867EFBA}");
      this._CanViewRewriteQuoteMenu = SecurityManager.Instance.AssertPermission("{9EAFD9EB-575F-4d5f-B68C-0E1367984C84}");
      this._CanViewSubmissionContextMenu = SecurityManager.Instance.AssertPermission("{25D35013-4336-48D8-88B0-3DD5E28C8A32}");
      this._CanViewEditQuoteMenu = SecurityManager.Instance.AssertPermission("{68CE5575-83C7-4df5-BB23-F9AA9747D39A}");
      this._CanViewRenewMenu = SecurityManager.Instance.AssertPermission("{B53921A4-696D-4b0f-9130-9EC205277AC8}");
      this._CanViewDuplicateQuoteMenu = SecurityManager.Instance.AssertPermission("{EF6FDCC0-050A-4128-BD7F-8F3DCC9D8FAE}");
      this._CanViewChangeQuoteStatusReasonMenu = SecurityManager.Instance.AssertPermission("{BC922A87-8067-4d37-BB01-AD359A640A64}");
      this._CanViewChangeUnderwriterMenu = SecurityManager.Instance.AssertPermission("{270AC55D-2B31-4273-B663-E600220C1AFA}");
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      ErrorHandler.HandleError(ex);
      ProjectData.ClearProjectError();
      return;
    }
    this.Cursor = MgaCursors.Default;
    UltraToolbar toolbar = this.toolBar.Toolbars[0];
    ((ToolPropsBase) ((ToolsCollectionBase) ((UltraToolbarBase) toolbar).Tools)[0].SharedProps).AppearancesSmall.AppearanceOnToolbar.Image = (object) ImageCache.Instance.NewImage;
    ((ToolPropsBase) ((ToolsCollectionBase) ((UltraToolbarBase) toolbar).Tools)[1].SharedProps).AppearancesSmall.AppearanceOnToolbar.Image = (object) ImageCache.Instance.NewImage;
    ((ToolPropsBase) ((ToolsCollectionBase) ((UltraToolbarBase) toolbar).Tools)[3].SharedProps).AppearancesSmall.AppearanceOnToolbar.Image = (object) ImageCache.Instance.NewImage;
    ((ToolPropsBase) ((ToolsCollectionBase) ((UltraToolbarBase) toolbar).Tools)[4].SharedProps).AppearancesSmall.AppearanceOnToolbar.Image = (object) ImageCache.Instance.Open;
    Imaging.MakeFormButtonsTransparent((Form) this);
    this.Visible = true;
    this.Show();
    this.Refresh();
    this._clearanceDragDropManager = new ClearanceDragDropManager(this.ugInsuredNavigation, (ISupportDocumentSystem) this);
    ((UltraGridBase) this.ugInsuredNavigation).DisplayLayout.Bands[0].Columns["InsuredGuid"].Hidden = true;
    if (SystemSettings.GetSetting<bool>("HideClearanceSubmissionID", false))
      ((UltraGridBase) this.ugInsuredNavigation).DisplayLayout.Bands[1].Columns["HideClearanceSubmissionID"].Hidden = true;
    this.InsertContextReports();
  }

  public void ugInsuredNavigation_ControlAdded(object sender, ControlEventArgs e)
  {
    if (e == null)
      throw new ArgumentNullException(nameof (e));
    e.Control.DoubleClick += new EventHandler(this.ugInsuredNavigation_DoubleClick);
  }

  public void ugInsuredNavigation_ControlRemoved(object sender, ControlEventArgs e)
  {
    if (e == null)
      throw new ArgumentNullException(nameof (e));
    e.Control.DoubleClick -= new EventHandler(this.ugInsuredNavigation_DoubleClick);
  }

  private void FillSubmission(Guid submissionGroupGuid)
  {
    frmClearance.ClearPolicyParameters(this._daProducerSubmissions.SelectCommand);
    try
    {
      this._daProducerSubmissions.SelectCommand.Parameters["@SubmissionGroupGuid"].Value = (object) submissionGroupGuid;
      DefaultDatabase.DataAdapterFill(this._daProducerSubmissions, (DataTable) this.DsInsuredNavigation.tblProducerSubmissions);
    }
    finally
    {
      this._daProducerSubmissions.SelectCommand.Parameters["@SubmissionGroupGuid"].Value = (object) null;
    }
  }

  protected virtual void AddSubmissionStatus(
    dsInsuredNavigation.tblProducerSubmissionsDataTable dt)
  {
  }

  protected virtual void AddAdditionalSubmissionInfo(
    Guid insuredGuid,
    dsInsuredNavigation.tblProducerSubmissionsDataTable dt)
  {
  }

  protected virtual void FillSubmissions(Guid insuredGuid)
  {
    Cursor.Current = MgaCursors.WaitCursor;
    dsInsuredNavigation.tblProducerSubmissionsRow[] producerSubmissionsRowArray = this.DsInsuredNavigation.tblInsureds.FindByInsuredGuid(insuredGuid).GettblProducerSubmissionsRows();
    int index = 0;
    while (index < producerSubmissionsRowArray.Length)
    {
      this.DsInsuredNavigation.tblProducerSubmissions.RemovetblProducerSubmissionsRow(producerSubmissionsRowArray[index]);
      checked { ++index; }
    }
    try
    {
      DbCommand selectCommand = this._daProducerSubmissions.SelectCommand;
      selectCommand.Parameters["@InsuredGuid"].Value = (object) insuredGuid;
      selectCommand.Parameters["@ProducerLocationGuid"].Value = (object) this._searchInfo.ProducerLocationGuid;
      selectCommand.Parameters["@SubmissionID"].Value = (object) this._searchInfo.SubmissionID;
      this.SetPolicyParameters(this._daProducerSubmissions.SelectCommand, frmClearance.SelectCommandType.Producers);
      this.labelSearchText.Text = "Getting submissions ...";
      ((UltraControlBase) this.panelSearch).Refresh();
      Thread.Sleep(500);
      try
      {
        DefaultDatabase.DataAdapterFill(this._daProducerSubmissions, (DataTable) this.DsInsuredNavigation.tblProducerSubmissions);
      }
      catch (ConstraintException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        ErrorHandler.ShowDataSetErrors((DataSet) this.DsInsuredNavigation, ex);
        ProjectData.ClearProjectError();
      }
      this.ball2Green.Visible = true;
      ((UltraGridBase) this.ugInsuredNavigation).Refresh();
    }
    finally
    {
      if (!((Control) this.panelSearch).Visible)
        Cursor.Current = MgaCursors.Default;
    }
    this.AddSubmissionStatus(this.DsInsuredNavigation.tblProducerSubmissions);
    this.AddAdditionalSubmissionInfo(insuredGuid, this.DsInsuredNavigation.tblProducerSubmissions);
  }

  private void ugInsuredNavigation_BeforeRowExpanded(object sender, CancelableRowEventArgs e)
  {
    try
    {
      switch (e.Row.Band.Index)
      {
        case 0:
          if (e.Row.HasChild())
            break;
          this.FillSubmissions((Guid) e.Row.Cells["insuredGuid"].Value);
          if (!this.AUTO_EXPAND_ON_SINGLE_RESULT || this.DsInsuredNavigation.tblProducerSubmissions.Rows.Count != 1 || !e.Row.HasChild())
            break;
          e.Row.GetChild((ChildRow) 0).Expanded = true;
          e.Row.GetChild((ChildRow) 0).Refresh();
          break;
        case 1:
          if (e.Row.HasChild())
            break;
          this._daQuotes.SelectCommand.Parameters["@submissiongroupGuid"].Value = (object) (Guid) e.Row.Cells["SubmissionGroupGuid"].Value;
          this.SetPolicyParameters(this._daQuotes.SelectCommand, frmClearance.SelectCommandType.Quotes);
          this._daQuotes.SelectCommand.Parameters["@QuoteGuid"].Value = (object) null;
          this.FillQuotes(this.DsInsuredNavigation.tblLinesToCompany);
          if (!this._searchInfo.ControlNo.HasValue)
            break;
          if (!SystemSettings.GetSetting<bool>("ShowAllQuotesInSubmission", false))
            break;
          try
          {
            foreach (UltraGridRow ultraGridRow in ((UltraGridBase) this.ugInsuredNavigation).Rows.GetRowEnumerator((GridRowType) 1, ((UltraGridBase) this.ugInsuredNavigation).DisplayLayout.Bands[2], (UltraGridBand) null))
            {
              if (this._searchInfo.ControlNo.HasValue && (int) ultraGridRow.Cells["ControlNo"].Value == this._searchInfo.ControlNo.Value)
              {
                ultraGridRow.Selected = true;
                ultraGridRow.Activate();
              }
            }
            break;
          }
          finally
          {
            IEnumerator enumerator;
            if (enumerator is IDisposable)
              (enumerator as IDisposable).Dispose();
          }
      }
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      ErrorHandler.HandleError(ex);
      ProjectData.ClearProjectError();
    }
  }

  protected virtual void FillQuotes(dsInsuredNavigation.tblLinesToCompanyDataTable tbl)
  {
    if (this._daQuotes.SelectCommand.Parameters["@SearchingUserID"].Value == null)
      this._daQuotes.SelectCommand.Parameters["@SearchingUserID"].Value = (object) CurrentUser.Instance.UserID;
    try
    {
      this.labelSearchText.Text = "Getting quote/policy information ...";
      ((UltraControlBase) this.panelSearch).Refresh();
      this._quoteSearchStartTime = DateAndTime.Now;
      DataTable table = tbl.Clone();
      DefaultDatabase.DataAdapterFill(this._daQuotes, table);
      if (table.Rows.Count == 0)
        return;
      tbl.Merge(table, true);
      this.AttachImageToNotes();
      this.SetPolicyRecordsOrder(tbl);
      this.ColorBoundQuotes();
      this.IdentifyPastDueAccounts(tbl);
      this.DisplayCurrencySymbol(tbl);
      this.ball3Green.Visible = true;
      ((UltraControlBase) this.panelSearch).Refresh();
    }
    catch (IndexOutOfRangeException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      ProjectData.ClearProjectError();
    }
    catch (ArgumentOutOfRangeException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      ProjectData.ClearProjectError();
    }
    catch (ConstraintException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      ErrorHandler.ShowDataSetErrors((DataSet) this.DsInsuredNavigation, ex);
      ProjectData.ClearProjectError();
    }
    finally
    {
      this.labelSearchText.Text = "Search Complete";
    }
  }

  private void DisplayCurrencySymbol(dsInsuredNavigation.tblLinesToCompanyDataTable tbl)
  {
    if (!this._displayCurrencySymbol.Value)
      return;
    CultureInfo cultureInfo = (CultureInfo) null;
    try
    {
      foreach (UltraGridRow ultraGridRow in ((UltraGridBase) this.ugInsuredNavigation).Rows.GetRowEnumerator((GridRowType) 1, ((UltraGridBase) this.ugInsuredNavigation).DisplayLayout.Bands[2], (UltraGridBand) null))
      {
        int integer = Conversions.ToInteger(ultraGridRow.Cells["ControlNo"].Value);
        if (!this._currencySymbolDictionary.TryGetValue(integer, out cultureInfo))
        {
          cultureInfo = MultiCurrencyUtilities.GetCultureInfo(DefaultDatabase.ExecuteScalar<string>(CommandType.Text, "Select dbo.GetQuoteCurrencyCode(@quoteId)", new object[2]
          {
            (object) "@QuoteId",
            (object) Quote.FromControlNo(Conversions.ToInteger(ultraGridRow.Cells["ControlNo"].Value)).QuoteID
          }));
          this._currencySymbolDictionary[integer] = cultureInfo;
        }
        if (cultureInfo != null)
        {
          EmbeddableEditorBase embeddableEditorBase = (EmbeddableEditorBase) new EditorWithMask((EmbeddableEditorOwnerBase) new DefaultEditorOwner(new DefaultEditorOwnerSettings()
          {
            FormatProvider = (IFormatProvider) cultureInfo,
            Format = "C",
            DataType = typeof (Decimal),
            MaskDataMode = (MaskMode) 0,
            MaskDisplayMode = (MaskMode) 3
          }));
          ultraGridRow.Cells["Premium"].Editor = embeddableEditorBase;
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

  private void ColorBoundQuotes()
  {
    if (!this._colorCodeBoundCards.Value)
      return;
    try
    {
      foreach (UltraGridRow ultraGridRow in ((UltraGridBase) this.ugInsuredNavigation).Rows.GetRowEnumerator((GridRowType) 1, ((UltraGridBase) this.ugInsuredNavigation).DisplayLayout.Bands[2], (UltraGridBand) null))
      {
        if (ultraGridRow.Cells["QuoteStatus"].Value.ToString().Equals("Bound") || ultraGridRow.Cells["QuoteStatus"].Value.ToString().Equals("Bound - Issued"))
        {
          ultraGridRow.Appearance.ForeColor = Color.Green;
          ultraGridRow.Appearance.BackColor = Color.White;
          ultraGridRow.Cells["ControlNo"].Appearance.FontData.Bold = (DefaultableBoolean) 1;
          ultraGridRow.Cells["InsuredPolicyName"].Appearance.FontData.Bold = (DefaultableBoolean) 1;
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

  private void IdentifyPastDueAccounts(dsInsuredNavigation.tblLinesToCompanyDataTable tbl)
  {
    if (!this._identifyPassDueAccount.Value)
      return;
    try
    {
      foreach (UltraGridRow ultraGridRow in ((UltraGridBase) this.ugInsuredNavigation).Rows.GetRowEnumerator((GridRowType) 1, ((UltraGridBase) this.ugInsuredNavigation).DisplayLayout.Bands[2], (UltraGridBand) null))
      {
        int integer = Conversions.ToInteger(ultraGridRow.Cells["ControlNo"].Value);
        bool flag;
        if (!this._pastDueDictionary.TryGetValue(integer, out flag))
        {
          flag = DefaultDatabase.ExecuteScalar<bool>(CommandType.Text, "SELECT dbo.IsPolicyPastDue(@controlNumber)", new object[2]
          {
            (object) "@controlNumber",
            (object) integer
          });
          this._pastDueDictionary[integer] = flag;
        }
        if (flag)
        {
          ultraGridRow.Cells["Premium"].Appearance.ForeColor = Color.Red;
          ultraGridRow.Cells["Premium"].Appearance.FontData.Bold = (DefaultableBoolean) 1;
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

  private void SetPolicyRecordsOrder(dsInsuredNavigation.tblLinesToCompanyDataTable tbl)
  {
    if (tbl.Rows.Count <= 1)
      return;
    DataTable fromTable1 = new DataTable();
    DataTable fromTable2 = new DataTable();
    DataTable fromTable3 = new DataTable();
    DataTable fromTable4 = new DataTable();
    DataTable fromTable5 = new DataTable();
    DataTable toTable = new DataTable();
    try
    {
      toTable = tbl.Clone();
      toTable.Rows.Clear();
      fromTable1 = tbl.Clone();
      fromTable1.Rows.Clear();
      fromTable2 = tbl.Clone();
      fromTable2.Rows.Clear();
      fromTable3 = tbl.Clone();
      fromTable3.Rows.Clear();
      fromTable4 = tbl.Clone();
      fromTable4.Rows.Clear();
      fromTable5 = tbl.Clone();
      fromTable5.Rows.Clear();
      for (int index = tbl.Rows.Count - 1; index >= 0; --index)
      {
        DataRow companyRow = (DataRow) this.DsInsuredNavigation.tblLinesToCompany.NewtblLinesToCompanyRow();
        DataRow row = tbl.Rows[index];
        switch (row.Field<int>("QuoteStatusID"))
        {
          case 3:
            fromTable1.ImportRow(row);
            tbl.Rows.Remove(row);
            break;
          case 7:
            fromTable2.ImportRow(row);
            tbl.Rows.Remove(row);
            break;
          case 8:
            fromTable5.ImportRow(row);
            tbl.Rows.Remove(row);
            break;
          case 9:
            fromTable3.ImportRow(row);
            tbl.Rows.Remove(row);
            break;
          case 16 /*0x10*/:
            fromTable4.ImportRow(row);
            tbl.Rows.Remove(row);
            break;
        }
      }
      this.CopyTableRows(fromTable3, toTable);
      this.CopyTableRows(fromTable4, toTable);
      this.CopyTableRows(fromTable2, toTable);
      this.CopyTableRows(fromTable5, toTable);
      this.CopyTableRows(fromTable1, toTable);
      try
      {
        foreach (DataRow row in tbl.Rows)
          toTable.ImportRow(row);
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
      tbl.Rows.Clear();
      try
      {
        foreach (DataRow row in toTable.Rows)
          tbl.ImportRow(row);
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
    }
    finally
    {
      toTable.Dispose();
      fromTable1.Dispose();
      fromTable2.Dispose();
      fromTable5.Dispose();
      fromTable4.Dispose();
      fromTable3.Dispose();
    }
  }

  private void CopyTableRows(DataTable fromTable, DataTable toTable)
  {
    try
    {
      foreach (DataRow row in fromTable.Rows)
        toTable.ImportRow(row);
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private static void ClearPolicyParameters(DbCommand cmd)
  {
    DbCommand dbCommand = cmd;
    dbCommand.Parameters["@InForce"].Value = (object) null;
    dbCommand.Parameters["@PolicyStateID"].Value = (object) null;
    dbCommand.Parameters["@ControlNo"].Value = (object) null;
    dbCommand.Parameters["@EffectiveStart"].Value = (object) null;
    dbCommand.Parameters["@EffectiveEnd"].Value = (object) null;
    dbCommand.Parameters["@ExpirationStart"].Value = (object) null;
    dbCommand.Parameters["@ExpirationEnd"].Value = (object) null;
    dbCommand.Parameters["@PolicyNumber"].Value = (object) null;
    dbCommand.Parameters["@AccountNumber"].Value = (object) null;
    dbCommand.Parameters["@LineGuid"].Value = (object) null;
    dbCommand.Parameters["@QuoteStatusID"].Value = (object) null;
    dbCommand.Parameters["@CompanyLocationGuid"].Value = (object) null;
    dbCommand.Parameters["@PolicyTypeID"].Value = (object) null;
    dbCommand.Parameters["@UnderwriterGuid"].Value = (object) null;
    dbCommand.Parameters["@HideVoids"].Value = (object) false;
    dbCommand.Parameters["@QuotingOffice"].Value = (object) null;
    dbCommand.Parameters["@IssuingOffice"].Value = (object) null;
    dbCommand.Parameters["@ViewUnBoundStatus"].Value = (object) null;
  }

  protected virtual void SetClientParameters(
    ref SqlCommand cmd,
    ClearanceSearchInfo si,
    frmClearance.SelectCommandType cmdType)
  {
  }

  protected virtual void SetClientParameters(
    ref DbCommand cmd,
    ClearanceSearchInfo si,
    frmClearance.SelectCommandType cmdType)
  {
    if (!(cmd is SqlCommand))
      return;
    SqlCommand cmd1 = cmd as SqlCommand;
    this.SetClientParameters(ref cmd1, si, cmdType);
  }

  private void SetPolicyParameters(DbCommand cmd, frmClearance.SelectCommandType cmdType)
  {
    DbCommand dbCommand = cmd;
    if (this._searchInfo.InForce)
    {
      dbCommand.Parameters["@InForce"].Value = (object) 1;
    }
    else
    {
      dbCommand.Parameters["@InForce"].Value = (object) null;
      dbCommand.Parameters["@PolicyStateID"].Value = (object) this._searchInfo.PolicyStateID;
      dbCommand.Parameters["@ControlNo"].Value = (object) this._searchInfo.ControlNo;
      dbCommand.Parameters["@EffectiveStart"].Value = (object) this._searchInfo.EffectiveStart;
      dbCommand.Parameters["@EffectiveEnd"].Value = (object) this._searchInfo.EffectiveEnd;
      dbCommand.Parameters["@ExpirationStart"].Value = (object) this._searchInfo.ExpirationStart;
      dbCommand.Parameters["@ExpirationEnd"].Value = (object) this._searchInfo.ExpirationEnd;
      dbCommand.Parameters["@InsuredName"].Value = (object) this._searchInfo.InsuredName?.Replace("'", "''");
      dbCommand.Parameters["@AccountNumber"].Value = (object) this._searchInfo.AccountNumber;
      dbCommand.Parameters["@PolicyNumber"].Value = (object) this._searchInfo.PolicyNumber;
      dbCommand.Parameters["@LineGuid"].Value = (object) this._searchInfo.LineGuid;
      dbCommand.Parameters["@QuoteStatusID"].Value = (object) this._searchInfo.PolicyStatus;
      dbCommand.Parameters["@CompanyLocationGuid"].Value = (object) this._searchInfo.CompanyLocationGuid;
      dbCommand.Parameters["@PolicyTypeID"].Value = (object) this._searchInfo.PolicyTypeID;
      dbCommand.Parameters["@UnderwriterGuid"].Value = (object) this._searchInfo.Undewriter;
      dbCommand.Parameters["@QuotingOffice"].Value = this._searchInfo.QuotingOffice.Equals((object) Guid.Empty) ? (object) null : (object) this._searchInfo.QuotingOffice;
      dbCommand.Parameters["@IssuingOffice"].Value = this._searchInfo.IssuingOffice.Equals((object) Guid.Empty) ? (object) null : (object) this._searchInfo.IssuingOffice;
      dbCommand.Parameters["@ClaimNo"].Value = string.IsNullOrEmpty(this._searchInfo.ClaimNo) ? (object) null : (object) this._searchInfo.ClaimNo;
      dbCommand.Parameters["@ViewUnBoundStatus"].Value = (object) this._searchInfo.LimitToBoundStatusOnly;
    }
    dbCommand.Parameters["@HideVoids"].Value = (object) this._searchInfo.HideVoids;
    dbCommand.Parameters["@SearchingUserID"].Value = (object) CurrentUser.Instance.UserID;
    this.SetClientParameters(ref cmd, this._searchInfo, cmdType);
  }

  public event ISupportNoteSystem.EntityInfoChangedEventHandler NoteChanged;

  public event ISupportDocumentSystem.EntityInfoChangedEventHandler DocumentChanged;

  string IRecreatableEntity.FriendlyEntityName => "Policy Detail";

  string IRecreatableEntity.RecreateTypeName
  {
    get
    {
      return ((UltraGridBase) this.ugInsuredNavigation).ActiveRow != null ? (((UltraGridBase) this.ugInsuredNavigation).ActiveRow.Band.Index != 0 ? (((UltraGridBase) this.ugInsuredNavigation).ActiveRow.Band.Index != 1 ? (((UltraGridBase) this.ugInsuredNavigation).ActiveRow.Band.Index != 2 ? string.Empty : (!(bool) ((UltraGridBase) this.ugInsuredNavigation).ActiveRow.Cells["QuickQuote"].Value ? typeof (frmPolicyDetail).ToString() : typeof (frmQuoteEdit).ToString())) : typeof (frmSubmissionGroup).ToString()) : typeof (frmInsureds).ToString()) : string.Empty;
    }
  }

  public bool CanCreateNewNote
  {
    get
    {
      return ((UltraGridBase) this.ugInsuredNavigation).ActiveRow != null && !this.EntityGuid.Equals(Guid.Empty);
    }
  }

  Guid IRecreatableEntity.EntityGuid
  {
    get
    {
      return ((UltraGridBase) this.ugInsuredNavigation).ActiveRow != null ? (((UltraGridBase) this.ugInsuredNavigation).ActiveRow.Band.Index != 0 ? (((UltraGridBase) this.ugInsuredNavigation).ActiveRow.Band.Index != 1 ? (((UltraGridBase) this.ugInsuredNavigation).ActiveRow.Band.Index != 2 ? Guid.Empty : (Guid) ((UltraGridBase) this.ugInsuredNavigation).ActiveRow.Cells["ControlGuid"].Value) : (!SecurityManager.Instance.AssertPermission("{569C99D3-9A8B-4a93-8A6D-2661E6237368}") ? Guid.Empty : (Guid) ((UltraGridBase) this.ugInsuredNavigation).ActiveRow.Cells["SubmissionGroupGuid"].Value)) : (Guid) ((UltraGridBase) this.ugInsuredNavigation).ActiveRow.Cells["InsuredGuid"].Value) : Guid.Empty;
    }
  }

  Guid IRecreatableEntity.ControlGUID
  {
    get
    {
      Guid controlGuid;
      try
      {
        controlGuid = ((UltraGridBase) this.ugInsuredNavigation).ActiveRow.Band.Index != 2 ? Guid.Empty : (Guid) ((UltraGridBase) this.ugInsuredNavigation).ActiveRow.Cells["ControlGuid"].Value;
      }
      catch (NullReferenceException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        controlGuid = Guid.Empty;
        ProjectData.ClearProjectError();
      }
      return controlGuid;
    }
  }

  bool IRecreatableEntity.HasControlGUID
  {
    get
    {
      return ((UltraGridBase) this.ugInsuredNavigation).ActiveRow != null && ((UltraGridBase) this.ugInsuredNavigation).ActiveRow.Band.Index == 2;
    }
  }

  string IRecreatableEntity.EntityName
  {
    get
    {
      return ((UltraGridBase) this.ugInsuredNavigation).ActiveRow != null ? (((UltraGridBase) this.ugInsuredNavigation).ActiveRow.Band.Index != 0 ? (((UltraGridBase) this.ugInsuredNavigation).ActiveRow.Band.Index != 1 ? (((UltraGridBase) this.ugInsuredNavigation).ActiveRow.Band.Index != 2 ? string.Empty : (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((UltraGridBase) this.ugInsuredNavigation).ActiveRow.Cells["PolicyNumber"].Value.ToString(), string.Empty, false) == 0 ? $"Control #{((UltraGridBase) this.ugInsuredNavigation).ActiveRow.Cells["ControlNo"].Value.ToString()} - {((UltraGridBase) this.ugInsuredNavigation).ActiveRow.Cells["InsuredPolicyName"].Value.ToString()}" : "Policy #" + ((UltraGridBase) this.ugInsuredNavigation).ActiveRow.Cells["PolicyNumber"].Value.ToString())) : $"Submission {RuntimeHelpers.GetObjectValue(((UltraGridBase) this.ugInsuredNavigation).ActiveRow.Cells["SubmissionGroupID"].Value)} {RuntimeHelpers.GetObjectValue(((UltraGridBase) this.ugInsuredNavigation).ActiveRow.Cells["Name"].Value)}") : ((UltraGridBase) this.ugInsuredNavigation).ActiveRow.Cells["Name"].Value.ToString()) : string.Empty;
    }
  }

  bool IRecreatableEntity.CanReCreateEntity
  {
    get
    {
      return ((UltraGridBase) this.ugInsuredNavigation).ActiveRow != null && (((UltraGridBase) this.ugInsuredNavigation).ActiveRow.Band.Index == 0 || ((UltraGridBase) this.ugInsuredNavigation).ActiveRow.Band.Index == 1 || ((UltraGridBase) this.ugInsuredNavigation).ActiveRow.Band.Index == 2);
    }
  }

  bool IRecreatableEntity.RecreateEntityInitialize(Guid entityGuid)
  {
    throw new InvalidOperationException("frmClearance does not implement RecreateEntityInitialize and should not be requested to do so.");
  }

  public bool AllowAddNewDocument => true;

  protected virtual void FillInsureds(dsInsuredNavigation.tblInsuredsDataTable tbl)
  {
    try
    {
      this._daInsureds.SelectCommand.CommandTimeout = 500;
      DefaultDatabase.DataAdapterFill(this._daInsureds, (DataTable) tbl);
    }
    catch (ConstraintException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      ErrorHandler.HandleErrorOnThread((Control) MDIControls.Instance.MDIParent, (Exception) ex);
      ProjectData.ClearProjectError();
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      ErrorHandler.HandleErrorOnThread((Control) MDIControls.Instance.MDIParent, ex);
      ProjectData.ClearProjectError();
    }
  }

  protected virtual void SetupQuoteContextMenuItems(Guid quoteGuid)
  {
    Cursor.Current = MgaCursors.WaitCursor;
    Quote objectAs = ObjectFactory.Instance.CreateObjectAs<Quote>(new object[1]
    {
      (object) quoteGuid
    });
    bool isBound = objectAs.IsBound;
    UltraToolbarsManager toolBar = this.toolBar;
    ((ToolsCollectionBase) toolBar.Tools)["Renew Policy"].SharedProps.Visible = isBound && (objectAs.QuoteStatus != 12 || this._canRenewOnCancelledPolicy.Value) && this._CanViewQuotesContextMenu && this._CanViewRenewMenu;
    ((ToolsCollectionBase) toolBar.Tools)["Delete Quote"].SharedProps.Visible = !isBound && (!objectAs.IsOriginalQuoteRecord || objectAs.InvoiceCount == 0) && this._CanViewQuotesContextMenu;
    ((ToolsCollectionBase) toolBar.Tools)["Edit Quote"].SharedProps.Visible = this._CanViewEditQuoteMenu && this._CanViewQuotesContextMenu;
    ((ToolsCollectionBase) toolBar.Tools)["Unbind Policy"].SharedProps.Visible = objectAs.CanUnbind && this._CanViewQuotesContextMenu;
    ((ToolsCollectionBase) toolBar.Tools)["Print Quote"].SharedProps.Visible = objectAs.OptionCount > 0 && this._CanViewQuotesContextMenu;
    ((ToolsCollectionBase) toolBar.Tools)["Duplicate Quote"].SharedProps.Visible = this._CanViewDuplicateQuoteMenu && this._CanViewQuotesContextMenu && this._showDuplicateQuoteMenuOption.Value;
    ((ToolsCollectionBase) toolBar.Tools)["Rewrite Policy"].SharedProps.Visible = isBound && this._CanViewRewriteQuoteMenu && this._CanViewQuotesContextMenu;
    ((ToolsCollectionBase) toolBar.Tools)["Change Quote Status Reason"].SharedProps.Visible = this._CanViewChangeQuoteStatusReasonMenu && this._CanViewQuotesContextMenu;
    ((ToolsCollectionBase) toolBar.Tools)["Renew All"].SharedProps.Visible = this._CanViewQuotesContextMenu;
    ((ToolsCollectionBase) toolBar.Tools)["Print Binders in Submission"].SharedProps.Visible = this._CanViewQuotesContextMenu;
    ((ToolsCollectionBase) toolBar.Tools)["Expand All"].SharedProps.Visible = this._CanViewQuotesContextMenu;
    ((ToolsCollectionBase) toolBar.Tools)["Collapse All"].SharedProps.Visible = this._CanViewQuotesContextMenu;
    ((ToolsCollectionBase) toolBar.Tools)["Insured Summary"].SharedProps.Visible = this._CanViewQuotesContextMenu;
    ((ToolsCollectionBase) toolBar.Tools)["Reports"].SharedProps.Visible = this._CanViewQuotesContextMenu;
    ((ToolsCollectionBase) toolBar.Tools)["Change Underwriter"].SharedProps.Visible = this._CanViewChangeUnderwriterMenu && this._CanViewQuotesContextMenu;
    this.optionDetailGuid = DefaultDatabase.ExecuteScalar<Guid?>("dbo.spResolveQuoteDetailsOption", new object[2]
    {
      (object) "@QuoteGuid",
      (object) objectAs.QuoteGuid
    }) ?? Guid.Empty;
    ((ToolsCollectionBase) toolBar.Tools)["Quote Option Details"].SharedProps.Visible = this.optionDetailGuid != Guid.Empty && this._CanViewQuotesContextMenu;
    this.QuoteStatusChangeMenu.EnableDisableItems(objectAs);
    ((ToolsCollectionBase) this.toolBar.Tools)["Change Status"].SharedProps.Visible = SecurityManager.Instance.AssertPermission("{305FFFDA-A10F-42af-B547-3E6AB798FEF1}") && this._CanViewQuotesContextMenu;
    Cursor.Current = MgaCursors.Default;
  }

  protected virtual void InsertContextReports()
  {
    Type[] typeArray = ObjectFactory.Instance.QueryTypesWithAttribute((Attribute) new ClearanceContextMenuAttribute());
    int index1 = 0;
    while (index1 < typeArray.Length)
    {
      Type type = typeArray[index1];
      object[] customAttributes = type.GetCustomAttributes(false);
      int index2 = 0;
      while (index2 < customAttributes.Length)
      {
        if (RuntimeHelpers.GetObjectValue(customAttributes[index2]) is ClearanceContextMenuAttribute objectValue)
        {
          try
          {
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(type.BaseType.Name, "MGAExcelReport", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(type.BaseType.Name, "MGAReport", false) == 0)
            {
              Attribute attributeFromType = ObjectFactory.GetAttributeFromType(type, (Attribute) new SecureReportResourceAttribute());
              if (attributeFromType == null)
                this.AddContextToolbarItem(type.ToString(), objectValue);
              else if (!SecurityManager.Instance.IsPermissionDenied(((SecureResourceAttribute) attributeFromType).UniqueIdentifier))
                this.AddContextToolbarItem(type.ToString(), objectValue);
            }
            else
              this.AddContextToolbarItem(type.ToString(), objectValue);
          }
          catch (InvalidOperationException ex)
          {
            ProjectData.SetProjectError((Exception) ex);
            InvalidOperationException operationException = ex;
            ErrorHandler.HandleError(operationException.Message, operationException.InnerException);
            ProjectData.ClearProjectError();
          }
        }
        checked { ++index2; }
      }
      checked { ++index1; }
    }
  }

  protected virtual void AddContextToolbarItem(string key, ClearanceContextMenuAttribute attribute)
  {
    PopupMenuTool popupMenuTool = string.IsNullOrEmpty(attribute.Folder) ? (PopupMenuTool) ((ToolsCollectionBase) this.toolBar.Tools)["contextMenu"] : this.AddContextSubMenu(attribute.Folder);
    ButtonTool buttonTool = new ButtonTool(key);
    ((ToolPropsBase) ((ToolBase) buttonTool).SharedProps).Caption = attribute.Caption;
    ((SubObjectBase) buttonTool).Tag = (object) attribute;
    ((ToolsCollectionBase) this.toolBar.Tools)["contextMenu"].ToolbarsManager.Tools.Add((ToolBase) buttonTool);
    popupMenuTool.Tools.AddTool(key);
  }

  private PopupMenuTool AddContextSubMenu(string caption)
  {
    PopupMenuTool tool;
    if (caption.Contains("Reports|"))
    {
      string str1 = "Reports";
      string str2 = Strings.Mid(caption, Strings.Len(caption) - caption.IndexOf("|") + 1);
      if (!((ToolsCollectionBase) this.toolBar.Tools).Exists(str1))
      {
        PopupMenuTool popupMenuTool = new PopupMenuTool(str1);
        ((ToolPropsBase) ((ToolBase) popupMenuTool).SharedProps).Caption = str1;
        ((ToolsCollectionBase) this.toolBar.Tools)["contextMenu"].ToolbarsManager.Tools.Add((ToolBase) popupMenuTool);
        ((PopupMenuTool) ((ToolsCollectionBase) this.toolBar.Tools)["contextMenu"]).Tools.AddTool(str1);
      }
      if (!((ToolsCollectionBase) this.toolBar.Tools).Exists(str2))
      {
        PopupMenuTool popupMenuTool = new PopupMenuTool(str2);
        ((ToolPropsBase) ((ToolBase) popupMenuTool).SharedProps).Caption = str2;
        ((ToolsCollectionBase) this.toolBar.Tools)["contextMenu"].ToolbarsManager.Tools.Add((ToolBase) popupMenuTool);
        ((ToolsCollectionBase) ((PopupMenuTool) ((ToolsCollectionBase) ((PopupMenuTool) ((ToolsCollectionBase) this.toolBar.Tools)["contextMenu"]).Tools)["Reports"]).Tools).AddRange(new ToolBase[1]
        {
          (ToolBase) popupMenuTool
        });
      }
      tool = (PopupMenuTool) ((ToolsCollectionBase) ((PopupMenuTool) ((ToolsCollectionBase) ((ToolsCollectionBase) this.toolBar.Tools)["contextMenu"].ToolbarsManager.Tools)["Reports"]).Tools)[str2];
    }
    else
    {
      if (!((ToolsCollectionBase) this.toolBar.Tools).Exists(caption))
      {
        PopupMenuTool popupMenuTool = new PopupMenuTool(caption);
        ((ToolPropsBase) ((ToolBase) popupMenuTool).SharedProps).Caption = caption;
        ((ToolsCollectionBase) this.toolBar.Tools)["contextMenu"].ToolbarsManager.Tools.Add((ToolBase) popupMenuTool);
        ((PopupMenuTool) ((ToolsCollectionBase) this.toolBar.Tools)["contextMenu"]).Tools.AddTool(caption);
      }
      tool = (PopupMenuTool) ((ToolsCollectionBase) ((ToolsCollectionBase) this.toolBar.Tools)["contextMenu"].ToolbarsManager.Tools)[caption];
    }
    return tool;
  }

  protected virtual void SetContextMenuItemsVisibility(ClearanceContextMenuLevelEnum level)
  {
    foreach (ToolBase tool in (ToolsCollectionBase) ((ToolsCollectionBase) this.toolBar.Tools)["contextMenu"].ToolbarsManager.Tools)
    {
      if (((SubObjectBase) tool).Tag is ClearanceContextMenuAttribute tag)
        tool.SharedProps.Visible = level == tag.Level;
    }
  }

  protected virtual string OriginalRecordFunction() => "SELECT dbo.IsUnboundOriginalQuote(@QG)";

  private void ExpandSubmissionRow(Guid submissionGroupGuid)
  {
    foreach (UltraGridRow row in ((UltraGridBase) this.ugInsuredNavigation).Rows)
    {
      if (row.HasChild())
      {
        for (UltraGridRow ultraGridRow = row.GetChild((ChildRow) 0); ultraGridRow != null; ultraGridRow = ultraGridRow.GetSibling((SiblingRow) 2))
        {
          if (ultraGridRow.Cells["SubmissionGroupGuid"].Value.Equals((object) submissionGroupGuid) && ultraGridRow.GetChild((ChildRow) 0) != null)
          {
            ultraGridRow.ExpandAll();
            ultraGridRow.GetChild((ChildRow) 0).Selected = true;
            ultraGridRow.GetChild((ChildRow) 0).Activate();
            break;
          }
        }
      }
    }
  }

  private void LoadQuoteStatusChangeMenu()
  {
    if (this._statusChangeMenu != null)
      return;
    this._statusChangeMenu = ObjectFactory.Instance.CreateObjectAs<QuoteStatusChangeMenu>(new object[1]
    {
      (object) ((ToolsCollectionBase) this.toolBar.Tools)["ContextMenu"]
    });
  }

  private void toolBar_BeforeToolDropdown(object sender, BeforeToolDropdownEventArgs e)
  {
    UltraGridRow activeRow = ((UltraGridBase) this.ugInsuredNavigation).ActiveRow;
    this.SetupInsuredContextMenuItems(activeRow.Band.Index == 0);
    this.SetupSubmissionContextMenuItems(activeRow.Band.Index == 1);
    this.tt.Hide((IWin32Window) this.ugInsuredNavigation);
    if (activeRow.Band.Index == 2)
    {
      this.SetupQuoteContextMenuItems(this.QuoteGuid);
      this.SetContextMenuItemsVisibility((ClearanceContextMenuLevelEnum) 2);
    }
    else
    {
      this.LoadQuoteStatusChangeMenu();
      this.HideQuoteContextMenuItems();
    }
  }

  private object ExistingQuote(string field)
  {
    return RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, $"SELECT TOP 1 ControlNo FROM tblQuotes WITH (NOLOCK) WHERE {field} IN (SELECT QuoteGuid FROM tblQuotes WITH (NOLOCK) WHERE ControlNo = @ControlNo) AND QuoteStatusID <> 14", new object[2]
    {
      (object) "@ControlNo",
      (object) this.ControlNum
    }));
  }

  private bool RenewalProducerCheck(Quote q)
  {
    ProducerLocation producerLocation = new ProducerLocation(q.ProducerLocationGuid);
    bool flag;
    if (producerLocation.StatusID == 3)
    {
      if (q.IsProducerBor && SecurityManager.Instance.AssertPermission("{314D9C23-07F2-40CF-8C8A-B917FE519C02}"))
      {
        flag = true;
        goto label_11;
      }
      if (!SecurityManager.Instance.AssertPermission("{4AC22A74-7B62-40d3-B78D-CC400DFE3F26}"))
      {
        Cursor.Current = MgaCursors.Default;
        int num = (int) MessageBox.Show("You do not have the required permissions to renew with a closed producer.", "Permissions Required", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        flag = false;
        goto label_11;
      }
    }
    if (producerLocation.StatusID == 2)
    {
      if (q.IsProducerBor && SecurityManager.Instance.AssertPermission("{423C569D-DED9-4410-8B0D-EF1992C8491C}"))
      {
        flag = true;
        goto label_11;
      }
      if (!SecurityManager.Instance.AssertPermission("{26DBE3BE-3745-414e-8F30-C9315E9A3AA4}"))
      {
        Cursor.Current = MgaCursors.Default;
        int num = (int) MessageBox.Show("You do not have the required permissions to renew with an inactive producer.", "Permissions Required", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        flag = false;
        goto label_11;
      }
    }
    flag = true;
label_11:
    return flag;
  }

  private void RenewQuote()
  {
    try
    {
      Cursor.Current = MgaCursors.WaitCursor;
      int? nullable1 = DefaultDatabase.ExecuteScalar<int?>("dbo.spRenewalExists", new object[2]
      {
        (object) "@ControlNo",
        (object) this.ControlNum
      });
      if (nullable1.HasValue)
      {
        Cursor.Current = MgaCursors.Default;
        int num = (int) MessageBox.Show($"A renewal for this policy already exists (control #{nullable1})", "Renewal Exists", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      }
      else
      {
        Quote q = Quote.FromQuoteGuid(this.QuoteGuid);
        if (q.QuoteStatus == 17 && !SecurityManager.Instance.AssertPermission("{B53D292E-79C7-4806-9800-56CCC0300F67}"))
        {
          Cursor.Current = MgaCursors.Default;
          int num = (int) MessageBox.Show("You do not have the required security to create renewals when quote status is 'Non-Renewed'.", "Insufficient Security.", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        else
        {
          if (!q.CompanyLine.IsActive)
          {
            if (SecurityManager.Instance.AssertPermission("{BBE67BFC-DC78-4984-AB6F-A612D43AACA3}"))
            {
              Cursor.Current = MgaCursors.Default;
              if (MessageBox.Show($"{$"The company/line on the policy is not active.{Environment.NewLine}{Environment.NewLine}"}{$"This company/line setup is closed or inactive.{Environment.NewLine}{Environment.NewLine}"}Would you like to create this renewal anyway?", "Company/Line not Active", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
                return;
              CurrentUser.Instance.LogAction("Bypassed warning of renewing on a closed or inactive company/line.", q.QuoteGuid);
            }
            else
            {
              Cursor.Current = MgaCursors.Default;
              int num = (int) MessageBox.Show($"The company/line on the policy is not active.{Environment.NewLine}{Environment.NewLine}" + "Renewals are not permitted on closed or inactive company/line.", "Company/Line not Active", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
              return;
            }
          }
          if (!this.RenewalProducerCheck(q))
          {
            Cursor.Current = MgaCursors.Default;
          }
          else
          {
            if (!this.ValidToRenewOnClient(q))
              return;
            if (DefaultDatabase.ExecuteScalar<int?>(CommandType.Text, "SELECT clm.ClaimID FROM dbo.tblClaimInformation clm WITH (NOLOCK) JOIN dbo.tblQuotes q WITH (NOLOCK) ON clm.ControlNo = q.ControlNo WHERE q.QuoteGUID = @qGuid", new object[2]
            {
              (object) "@qGuid",
              (object) q.QuoteGuid
            }).HasValue)
            {
              Cursor.Current = MgaCursors.Default;
              if (MessageBox.Show($"Claims exists on this quote.{Environment.NewLine}{Environment.NewLine}Do you wish to view these claims now?", "Claims Exist On Quote", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
              {
                using (FormSettings.ShowFormDialog(typeof (frmClaims), new object[1]
                {
                  (object) q.QuoteGuid
                }))
                  return;
              }
            }
            byte? nullable2 = DefaultDatabase.ExecuteScalar<byte?>("dbo.GetProducerContactStatusOnRenewal", new object[2]
            {
              (object) "@QuoteGUID",
              (object) q.QuoteGuid
            });
            int? nullable3 = nullable2.HasValue ? new int?((int) nullable2.GetValueOrDefault()) : new int?();
            if (nullable3.HasValue && nullable3.Value != 1)
            {
              Cursor.Current = MgaCursors.Default;
              if (MessageBox.Show($"You are about to renew with a Producer Contact whose status is not active.{Environment.NewLine}{Environment.NewLine}" + "Continue wth the renewal process?", "Reminder - Producer Contact not Active", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;
              CurrentUser.Instance.LogAction("Bypassed warning of renewing with a Producer Contact whose status is not active.", q.QuoteGuid);
            }
            Guid newQuoteGuid;
            try
            {
              newQuoteGuid = q.Renew();
            }
            catch (IncorrectNumberOfRenewalsException ex1)
            {
              ProjectData.SetProjectError((Exception) ex1);
              try
              {
                newQuoteGuid = q.Renew();
              }
              catch (IncorrectNumberOfRenewalsException ex2)
              {
                ProjectData.SetProjectError((Exception) ex2);
                int num = (int) MessageBox.Show($"An unexpected error occured when creating the renewal.{Environment.NewLine}{Environment.NewLine}If this problem continues, please contact technical support.", "Error During Renewal", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                ProjectData.ClearProjectError();
                return;
              }
              ProjectData.ClearProjectError();
            }
            Quote newQuote = Quote.CreateNew(newQuoteGuid);
            Guid submissionGroupGuid = newQuote.SubmissionGroupGuid;
            this.FillSubmission(submissionGroupGuid);
            this._daQuotes.SelectCommand.Parameters["@QuoteGuid"].Value = (object) newQuoteGuid;
            this._daQuotes.SelectCommand.Parameters["@SubmissionGroupGuid"].Value = (object) submissionGroupGuid;
            this._daQuotes.SelectCommand.Parameters["@ControlNo"].Value = (object) newQuote.ControlNo;
            this.FillQuotes(this.DsInsuredNavigation.tblLinesToCompany);
            this.SetPolicyParameters(this._daQuotes.SelectCommand, frmClearance.SelectCommandType.Quotes);
            try
            {
              this.ugInsuredNavigation.BeforeRowExpanded -= new CancelableRowEventHandler(this.ugInsuredNavigation_BeforeRowExpanded);
              this.ExpandSubmissionRow(submissionGroupGuid);
            }
            finally
            {
              this.ugInsuredNavigation.BeforeRowExpanded += new CancelableRowEventHandler(this.ugInsuredNavigation_BeforeRowExpanded);
            }
            if (!this.IsRenewQuoteValid(newQuote))
              return;
            this.ViewRenewedQuote(newQuote, newQuoteGuid);
          }
        }
      }
    }
    finally
    {
      Cursor.Current = MgaCursors.Default;
    }
  }

  protected virtual bool ValidToRenewOnClient(Quote q) => true;

  protected virtual void ViewRenewedQuote(Quote newQuote, Guid newQuoteGuid)
  {
    DataRow dataRow = DefaultDatabase.ExecuteDataRow(CommandType.Text, "SELECT ControlNo, EffectiveDate, ExpirationDate FROM tblQuotes WHERE QuoteGUID= @quoteGUID", new object[2]
    {
      (object) "@quoteGUID",
      (object) newQuoteGuid
    });
    Cursor.Current = MgaCursors.Default;
    if (MessageBox.Show($"The following renewal was created: \nControl #: {Conversions.ToString((int) dataRow["ControlNo"])}\nEffective: {((DateTime) dataRow["EffectiveDate"]).ToShortDateString()}\nExpires:  {((DateTime) dataRow["ExpirationDate"]).ToShortDateString()}\n\nWould you like to view this renewal policy now?", "View Renewal?", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) != DialogResult.Yes)
      return;
    if (!newQuote.IsQuickQuote)
      FormSettings.ShowForm(typeof (frmPolicyDetail), new object[1]
      {
        (object) newQuoteGuid
      });
    else
      FormSettings.ShowForm(typeof (frmQuoteEdit), new object[2]
      {
        (object) newQuote.QuoteGuid,
        (object) newQuote.SubmissionGroupGuid
      });
  }

  protected virtual bool IsRenewQuoteValid(Quote newQuote) => true;

  private void RewriteQuote()
  {
    object objectValue = RuntimeHelpers.GetObjectValue(this.ExistingQuote("RewriteOfQuoteGuid"));
    if (objectValue != null)
    {
      int num1 = (int) MessageBox.Show($"A rewrite for this policy already exists (control #{RuntimeHelpers.GetObjectValue(objectValue)})", "Rewrite Exists", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    else
    {
      SelectRewritePolicyType rewritePolicyType = new SelectRewritePolicyType();
      int policyTypeId;
      try
      {
        int num2 = (int) ((Form) rewritePolicyType).ShowDialog();
        if (!rewritePolicyType.Saved)
          return;
        policyTypeId = rewritePolicyType.PolicyTypeID;
      }
      finally
      {
        ((Component) rewritePolicyType).Dispose();
      }
      Quote newAs1 = Quote.CreateNewAs<Quote>(this.QuoteGuid);
      DialogResult dialogResult = this.AskKeepPolicyNumber(newAs1.PolicyNumber);
      this.Cursor = MgaCursors.WaitCursor;
      Guid newQuoteGuid = newAs1.Rewrite(policyTypeId);
      if (dialogResult == DialogResult.Yes)
        DefaultDatabase.ExecuteNonQuery("dbo.spCopyPolicyNumberOnRewrite", new object[4]
        {
          (object) "@originalQuoteGuid",
          (object) newAs1.QuoteGuid,
          (object) "@newQuoteGuid",
          (object) newQuoteGuid
        });
      this.KeepPolicyNumberOnClient(newAs1.QuoteGuid, newQuoteGuid, dialogResult == DialogResult.Yes);
      Quote newAs2 = Quote.CreateNewAs<Quote>(newQuoteGuid);
      this.FillSubmission(newAs2.SubmissionGroupGuid);
      dsInsuredNavigation.tblLinesToCompanyRow byQuoteGuid = this.DsInsuredNavigation.tblLinesToCompany.FindByQuoteGuid(newAs1.QuoteGuid);
      if (byQuoteGuid != null)
      {
        try
        {
          byQuoteGuid.Delete();
          this.DsInsuredNavigation.tblLinesToCompany.AcceptChanges();
        }
        catch (ArgumentOutOfRangeException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          ProjectData.ClearProjectError();
        }
        catch (RowNotInTableException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          ProjectData.ClearProjectError();
        }
      }
      this._daQuotes.SelectCommand.Parameters["@QuoteGuid"].Value = (object) newQuoteGuid;
      this.FillQuotes(this.DsInsuredNavigation.tblLinesToCompany);
      try
      {
        this.ugInsuredNavigation.BeforeRowExpanded -= new CancelableRowEventHandler(this.ugInsuredNavigation_BeforeRowExpanded);
        this.ExpandSubmissionRow(newAs1.SubmissionGroupGuid);
      }
      finally
      {
        this.ugInsuredNavigation.BeforeRowExpanded += new CancelableRowEventHandler(this.ugInsuredNavigation_BeforeRowExpanded);
      }
      this.Cursor = MgaCursors.Default;
      DefaultDatabase.ExecuteDataRow(CommandType.Text, "SELECT ControlNo, EffectiveDate, ExpirationDate FROM tblQuotes WHERE QuoteGUID= @quoteGUID", new object[2]
      {
        (object) "@quoteGUID",
        (object) newQuoteGuid
      });
      if (MessageBox.Show($"The following rewrite was created: {"\n"}{"\n"}Control #: {newAs2.ControlNo}{"\n"}Effective: {newAs2.EffectiveDate:s}{"\n"}Expires: {newAs2.ExpirationDate:s}{"\n"}{"\n"}Would you like to view this now?", "Rewrite Created", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) != DialogResult.Yes)
        return;
      FormSettings.ShowForm(typeof (frmPolicyDetail), new object[1]
      {
        (object) newQuoteGuid
      });
    }
  }

  protected virtual void KeepPolicyNumberOnClient(
    Guid oldQuoteGuid,
    Guid newQuoteGuid,
    bool KeepPolicyNumber)
  {
  }

  protected virtual DialogResult AskKeepPolicyNumber(string policyNumber)
  {
    return !new Quote(this.QuoteGuid).CompanyLine.KeepPolicyNumberOnRewrites ? MessageBox.Show($"Would you like to keep the existing policy number ({policyNumber})?", "Keep Policy Number?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) : DialogResult.Yes;
  }

  private void EditQuote()
  {
    if (!SecurityManager.Instance.AssertPermission("{F4F796D7-D625-4347-829F-8F3A328BAECE}"))
    {
      int num = (int) MessageBox.Show("You do not have the required security to open / edit quotes.", "Insufficient Security", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    else
      Quote.FromQuoteGuid(this.QuoteGuid).Edit();
  }

  private void DeleteQuote()
  {
    if (!SecurityManager.Instance.AssertPermission("{9563C066-52CC-40d3-9B8E-F4B80614A97E}"))
    {
      int num = (int) MessageBox.Show("You do not have the required security to delete quotes.", "Insufficient Security", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    else
    {
      Quote q = Quote.FromQuoteGuid(this.QuoteGuid);
      if (q.IsBound)
      {
        q.PolicyUnbound += new Quote.PolicyUnboundEventHandler(this.DeleteUnboundPolicy);
        frmClearance.UnbindQuote(q);
        q.PolicyUnbound -= new Quote.PolicyUnboundEventHandler(this.DeleteUnboundPolicy);
      }
      else
        q.Delete();
    }
  }

  private void UnbindQuote()
  {
    Quote q = Quote.FromQuoteGuid(this.QuoteGuid);
    frmClearance.UnbindQuote(q);
    this.UpdateQuote(q.QuoteGuid);
  }

  private static void UnbindQuote(Quote q)
  {
    q.SupressSuccessMessages = true;
    q.Unbind();
  }

  private void DeleteUnboundPolicy(object sender, QuoteEventArgs e) => e.Quote.Delete();

  private void SetupInsuredContextMenuItems(bool visible)
  {
    ((ToolsCollectionBase) this.toolBar.Tools)["Delete Insured"].SharedProps.Visible = visible;
    ((ToolsCollectionBase) this.toolBar.Tools)["Insured Summary"].SharedProps.Visible = (this.DsInsuredNavigation.tblProducerSubmissions.Count > 0 || this.DsInsuredNavigation.tblInsureds.Count > 0) && this._CanViewInsuredSummaryMenu;
    if (!visible)
      return;
    this.SetContextMenuItemsVisibility((ClearanceContextMenuLevelEnum) 0);
  }

  protected virtual void SetupSubmissionContextMenuItems(bool visible)
  {
    UltraToolbarsManager toolBar = this.toolBar;
    ((ToolsCollectionBase) toolBar.Tools)["Delete Submission"].SharedProps.Visible = visible && this._CanViewSubmissionContextMenu;
    ((ToolsCollectionBase) toolBar.Tools)["Duplicate Submission"].SharedProps.Visible = visible && this._CanViewSubmissionContextMenu;
    ((ToolsCollectionBase) toolBar.Tools)["Submission Overview"].SharedProps.Visible = visible && this._CanViewSubmissionContextMenu;
    ((ToolsCollectionBase) toolBar.Tools)["PrintQuotes"].SharedProps.Visible = visible && this._CanViewSubmissionContextMenu;
    ((ToolsCollectionBase) toolBar.Tools)["Bind Quotes in Submission"].SharedProps.Visible = visible && this._CanViewSubmissionContextMenu;
    ((ToolsCollectionBase) toolBar.Tools)["Print Binders in Submission"].SharedProps.Visible = visible && this._CanViewSubmissionContextMenu;
    ((ToolsCollectionBase) toolBar.Tools)["Expand All"].SharedProps.Visible = this._CanViewSubmissionContextMenu;
    ((ToolsCollectionBase) toolBar.Tools)["Collapse All"].SharedProps.Visible = this._CanViewSubmissionContextMenu;
    ((ToolsCollectionBase) toolBar.Tools)["Insured Summary"].SharedProps.Visible = this._CanViewSubmissionContextMenu && this._CanViewInsuredSummaryMenu;
    ((ToolsCollectionBase) toolBar.Tools)["Reports"].SharedProps.Visible = this._CanViewSubmissionContextMenu;
    ((ToolsCollectionBase) toolBar.Tools)["Submission Inspection Requests"].SharedProps.Visible = visible && this._CanViewSubmissionContextMenu && this._viewSubmissionInspectionRequests.Value;
    ((ToolsCollectionBase) toolBar.Tools)["Move Insured"].SharedProps.Visible = visible && this._CanViewSubmissionContextMenu;
    if (!visible)
      return;
    this.SetContextMenuItemsVisibility((ClearanceContextMenuLevelEnum) 1);
  }

  private void PrintQuote() => frmClearance.PrintQuote(this.QuoteGuid);

  internal static void PrintQuote(Guid quoteGuid)
  {
    ((frmPolicyDetail) ObjectFactory.Instance.CreateFormEX(typeof (frmPolicyDetail), new object[1]
    {
      (object) quoteGuid
    })).PrintQuote();
  }

  private void NewSubmission()
  {
    if (!SecurityManager.Instance.AssertPermission("{31386F24-9D45-4667-A237-3CEFAE42F7F9}"))
    {
      int num1 = (int) MessageBox.Show("You do not have the required security to add new submissions", "Insufficient Security", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    else if (this.CurrentSelectedInsuredGuid.Equals(Guid.Empty))
    {
      int num2 = (int) MessageBox.Show("Please select an insured in the grid before proceeding.", "No Insured Selected", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    else
      this.NewSubmission(this.CurrentSelectedInsuredGuid);
  }

  private void NewSubmission(Guid insuredGuid)
  {
    byte status = new Insured(insuredGuid).Status;
    if (status != (byte) 1)
    {
      if (status == (byte) 2 && !SecurityManager.Instance.AssertPermission("{11C43676-CF55-46ea-8144-B3CFFBCAD275}"))
      {
        int num = (int) MessageBox.Show("You do not have the required security to create new submissions on an inactive insured", "Cannot Add New Submission On Inactive Insured", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        return;
      }
      if (status == (byte) 3 && !SecurityManager.Instance.AssertPermission("{1737D110-1CA5-4d5e-8745-58C8CE134A67}"))
      {
        int num = (int) MessageBox.Show("You do not have the required security to create new submissions on a closed insured", "Cannot Add New Submission On Closed Insured", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        return;
      }
      if (((int) SystemSettings.GetSetting<byte?>("SuspendedInsuredStatusID", new byte?()) ?? -1) == (int) status && !SecurityManager.Instance.AssertPermission("{0A1516D8-ECC9-4754-AD6D-256D097E7B93}"))
      {
        int num = (int) MessageBox.Show("You do not have the required security to create new submissions on a suspended insured", "Cannot Add New Submission On Suspended Insured", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        return;
      }
    }
    this.ShowSubmissionGroupForm(insuredGuid);
  }

  public virtual void ShowSubmissionGroupForm(Guid insuredGuid)
  {
    Cursor.Current = MgaCursors.WaitCursor;
    try
    {
      using (FormSettings.ShowFormDialog(typeof (frmSubmissionGroup), new object[1]
      {
        (object) insuredGuid
      }))
        ;
    }
    finally
    {
      Cursor.Current = MgaCursors.Default;
    }
  }

  private void OpenQuote()
  {
    if (((UltraGridBase) this.ugInsuredNavigation).ActiveRow == null || ((UltraGridBase) this.ugInsuredNavigation).ActiveRow.Band.Index != 2)
      return;
    Quote.FromQuoteGuid(this.QuoteGuid).Open();
  }

  private void EditSubmission()
  {
    if (!SecurityManager.Instance.AssertPermission("{0450B0F5-9D72-40d4-A52A-67E5963A96DF}"))
    {
      int num = (int) MessageBox.Show("You do not have sufficient security to edit submissions.", "Insufficient Security", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    else
    {
      Cursor.Current = MgaCursors.WaitCursor;
      try
      {
        using (FormSettings.ShowFormDialog(typeof (frmSubmissionGroup), new object[2]
        {
          (object) this.CurrentSelectedInsuredGuid,
          (object) this.CurrentSubmissionGroupGuid
        }))
          ;
      }
      finally
      {
        Cursor.Current = MgaCursors.Default;
      }
    }
  }

  private void ExpandAll()
  {
    Cursor.Current = MgaCursors.WaitCursor;
    try
    {
      RowEnumerator enumerator = ((UltraGridBase) this.ugInsuredNavigation).Rows.GetEnumerator();
      while (enumerator.MoveNext())
        enumerator.Current.ExpandAll();
    }
    finally
    {
      Cursor.Current = MgaCursors.Default;
    }
  }

  private void CollapseAll()
  {
    Cursor.Current = MgaCursors.WaitCursor;
    try
    {
      RowEnumerator enumerator = ((UltraGridBase) this.ugInsuredNavigation).Rows.GetEnumerator();
      while (enumerator.MoveNext())
        enumerator.Current.CollapseAll();
    }
    finally
    {
      Cursor.Current = MgaCursors.Default;
    }
  }

  private void toolBar_ToolClick(object sender, ToolClickEventArgs e)
  {
    string key = ((ToolEventArgs) e).Tool.Key;
    // ISSUE: reference to a compiler-generated method
    switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(key))
    {
      case 214036300:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Print Quote", false) == 0)
        {
          this.PrintQuote();
          return;
        }
        break;
      case 255497830:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Expand All", false) == 0)
        {
          this.ExpandAll();
          return;
        }
        break;
      case 294268480:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Print Binders in Submission", false) == 0)
        {
          this.PrintBindersInSubmission();
          return;
        }
        break;
      case 321450149:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "New Quote", false) == 0)
        {
          this.NewQuote();
          return;
        }
        break;
      case 506987437:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Open Quote", false) == 0)
        {
          this.OpenQuote();
          return;
        }
        break;
      case 663442429:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "PrintQuotes", false) == 0)
        {
          FormSettings.ShowForm(typeof (FormMultiQuotePrinting), new object[1]
          {
            (object) (Guid) ((UltraGridBase) this.ugInsuredNavigation).ActiveRow.Cells["SubmissionGroupGuid"].Value
          });
          return;
        }
        break;
      case 680834897:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Renew All", false) == 0)
        {
          this.RenewAllPolicies();
          return;
        }
        break;
      case 731348138:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Delete Submission", false) == 0)
        {
          this.DeleteSubmission();
          return;
        }
        break;
      case 950364450:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Delete Quote", false) == 0)
        {
          if (!ObjectFactory.Instance.CreateObjectAs<DeleteQuoteOverride>(new object[0]).CanDeleteQuote(this.QuoteGuid))
            return;
          this.DeleteQuote();
          return;
        }
        break;
      case 1102577777:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Insured Summary", false) == 0)
        {
          FormSettings.ShowForm(typeof (frmInsuredSummary), new object[2]
          {
            (object) this.CurrentSelectedInsuredGuid,
            (object) this.GetSelectedInsuredLocationGuid()
          });
          return;
        }
        break;
      case 1204109860:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Submission Overview", false) == 0)
        {
          FormSettings.ShowForm(typeof (frmClearanceView), new object[1]
          {
            (object) (Guid) ((UltraGridBase) this.ugInsuredNavigation).ActiveRow.Cells["SubmissionGroupGuid"].Value
          });
          return;
        }
        break;
      case 1399782638:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Duplicate Submission", false) == 0)
        {
          this.CopySubmission();
          return;
        }
        break;
      case 1690999987:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "New Insured", false) == 0)
        {
          if (!SecurityManager.Instance.AssertPermission("{ADAE0A61-DE61-4aaf-8BCA-39F8158C9248}"))
          {
            int num = (int) MessageBox.Show("You do not have the required security to add new insureds.", "Insufficient Security", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            return;
          }
          FormSettings.ShowForm(typeof (frmInsureds));
          return;
        }
        break;
      case 1710383617:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Collapse All", false) == 0)
        {
          this.CollapseAll();
          return;
        }
        break;
      case 2156852455:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Rewrite Policy", false) == 0)
        {
          this.RewriteQuote();
          return;
        }
        break;
      case 2626281249:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Submission Inspection Requests", false) == 0)
        {
          this.SubmissionInspectionRequests();
          return;
        }
        break;
      case 2646226853:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Edit Quote", false) == 0)
        {
          this.EditQuote();
          return;
        }
        break;
      case 2787453627:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Change Quote Status Reason", false) == 0)
        {
          this.ChangeQuoteStatusReason();
          return;
        }
        break;
      case 3109677194:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Quote Option Details", false) == 0)
        {
          this.ShowQuoteOptionDetails();
          return;
        }
        break;
      case 3329622926:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Bind Quotes in Submission", false) == 0)
        {
          this.BindQuotesInSubmission();
          return;
        }
        break;
      case 3506011517:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Unbind Policy", false) == 0)
        {
          this.UnbindQuote();
          return;
        }
        break;
      case 3509358764:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Renew Policy", false) == 0)
        {
          this.RenewQuote();
          return;
        }
        break;
      case 3543490247:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "New Submission", false) == 0)
        {
          this.NewSubmission();
          return;
        }
        break;
      case 3647460742:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Move Insured", false) == 0)
        {
          using (frmSelection frmSelection = new frmSelection((frmSelection.SelectionTypes) 4, true))
          {
            int num1 = (int) ((Form) frmSelection).ShowDialog();
            if (MessageBox.Show($"Move to Insured {frmSelection.SelectedText}?", "Move Insured", MessageBoxButtons.OKCancel) != DialogResult.OK)
              return;
            DefaultDatabase.ExecuteNonQuery(CommandType.StoredProcedure, "dbo.spMoveSubmissionInsured", new object[4]
            {
              (object) "@InsuredLocationGuid",
              (object) frmSelection.SelectedGuid,
              (object) "@SubmissionGroupGuid",
              (object) this.CurrentSubmissionGroupGuid
            });
            string text = $"Submission {RuntimeHelpers.GetObjectValue(((UltraGridBase) this.ugInsuredNavigation).ActiveRow.Cells["SubmissionGroupID"].Value)} {RuntimeHelpers.GetObjectValue(((UltraGridBase) this.ugInsuredNavigation).ActiveRow.Cells["Name"].Value)} Moved Insured to {frmSelection.SelectedText}";
            CurrentUser.Instance.LogAction(text, this.CurrentSubmissionGroupGuid);
            int num2 = (int) MessageBox.Show(text, "Move Insured", MessageBoxButtons.OK);
            this.RefreshSearch();
            return;
          }
        }
        break;
      case 3859937308:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Change Underwriter", false) == 0)
        {
          this.ChangeUnderwriter();
          return;
        }
        break;
      case 4206573630:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Duplicate Quote", false) == 0)
        {
          this.CreateDuplicateQuote();
          return;
        }
        break;
      case 4220482503:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Edit Submission", false) == 0)
        {
          this.EditSubmission();
          return;
        }
        break;
      case 4250604168:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Delete Insured", false) == 0)
        {
          this.DeleteInsured();
          return;
        }
        break;
    }
    if (((UltraGridBase) this.ugInsuredNavigation).ActiveRow.Band.Index == 2 && !this.ToolHasParentWithKey(((ToolEventArgs) e).Tool, "Change Status"))
      CurrentUser.Instance.LogAction($"Ran Policy Report -- {((ToolEventArgs) e).Tool.CustomizerCaptionResolved} for control {this.ControlNum}", this.QuoteGuid);
    this.SelectCustomClientMenuItem(((ToolEventArgs) e).Tool.Key);
  }

  private bool ToolHasParentWithKey(ToolBase tool, string menuKey)
  {
    return Microsoft.VisualBasic.CompilerServices.Operators.CompareString(tool.Owner is ToolBase owner ? owner.Key : (string) null, menuKey, false) == 0;
  }

  private void SubmissionInspectionRequests()
  {
    Guid guid = (Guid) ((UltraGridBase) this.ugInsuredNavigation).ActiveRow.Cells["SubmissionGroupGuid"].Value;
    Type typeFromString = ObjectFactory.Instance.CreateTypeFromString("MGASystems.IMS.Policies.Inspections.FormSubmissionGroupInspectionRequests");
    Form form = (Form) null;
    try
    {
      if ((object) typeFromString == null)
        return;
      form = (Form) ObjectFactory.Instance.CreateObjectEX(typeFromString, new object[1]
      {
        (object) guid
      });
      if (form == null)
        return;
      form.ShowInTaskbar = true;
      form.BringToFront();
      int num = (int) form.ShowDialog();
    }
    finally
    {
      form?.Dispose();
    }
  }

  private void PrintBindersInSubmission()
  {
    FormSettings.ShowForm(typeof (FormPrintSubmissionBinders), new object[1]
    {
      (object) (Guid) ((UltraGridBase) this.ugInsuredNavigation).ActiveRow.Cells["SubmissionGroupGuid"].Value
    });
  }

  private void RenewAllPolicies()
  {
    FormSettings.ShowForm(typeof (FormRenewAllPolicies), new object[1]
    {
      (object) this.ControlNum
    });
  }

  private void ShowQuoteOptionDetails()
  {
    if (!(this.optionDetailGuid != Guid.Empty))
      return;
    Cursor.Current = MgaCursors.WaitCursor;
    try
    {
      MDIControls.Instance.StatusBarText = "Reading premium value from rater...";
      Guid optionDetailGuid = this.optionDetailGuid;
      IRater rater = RaterFactory.GetRater((int) DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT dbo.GetRaterIDUsedOnOption(@quoteOptionGuid)", new object[2]
      {
        (object) "@quoteOptionGuid",
        (object) optionDetailGuid
      }));
      if (rater == null)
      {
        int num = (int) MessageBox.Show("Could not associate a rater to this quote. Please contact your system admin.", "No Rater Found", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
      else
      {
        QuoteOption quoteOption = new QuoteOption(optionDetailGuid);
        object objectValue = RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT dbo.GetQuoteOptionCompanyLineGuid(@quoteOptionID)", new object[2]
        {
          (object) "@quoteOptionID",
          (object) quoteOption.QuoteOptionID
        }));
        if (objectValue == DBNull.Value || objectValue == null)
          return;
        rater.InitializeState(this.QuoteGuid, quoteOption.CompanyLineGuid);
        StringBuilder stringBuilder = new StringBuilder();
        stringBuilder.Append(rater.GetOptionDescription(optionDetailGuid));
        FormSettings.ShowFormDialog(typeof (frmGenericInfo), new object[2]
        {
          (object) "Quote Option Information:",
          (object) stringBuilder
        }).Dispose();
      }
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      ErrorHandler.HandleError(ex);
      ProjectData.ClearProjectError();
    }
    finally
    {
      Cursor.Current = MgaCursors.Default;
      MDIControls.Instance.StatusBarText = string.Empty;
    }
  }

  private void BindQuotesInSubmission()
  {
    FormSettings.ShowForm(typeof (FormBindSubmissionQuotes), new object[1]
    {
      (object) (Guid) ((UltraGridBase) this.ugInsuredNavigation).ActiveRow.Cells["SubmissionGroupGuid"].Value
    });
  }

  private void ChangeQuoteStatusReason()
  {
    FormSettings.ShowForm(typeof (FormChangeQuoteStatusReason), new object[1]
    {
      (object) this.QuoteGuid
    });
  }

  private void SelectCustomClientMenuItem(string toolKey)
  {
    if (((SubObjectBase) ((ToolsCollectionBase) this.toolBar.Tools)[toolKey]).Tag is ClearanceContextMenuAttribute tag)
      this.RunContextMenuItem(tag.Level, toolKey);
    if (((UltraGridBase) this.ugInsuredNavigation).ActiveRow == null || ((UltraGridBase) this.ugInsuredNavigation).ActiveRow.Band.Index != 2)
      return;
    this._statusChangeMenu.ToolClick(toolKey, this.QuoteGuid);
  }

  private void NewQuote()
  {
    if (!SecurityManager.Instance.AssertPermission("{9EFA732E-DF81-4188-A447-7BFACAADD050}"))
    {
      int num1 = (int) MessageBox.Show("You do not have the required security to add new quotes.", "Insufficient Security", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    else if (this.CurrentSelectedInsuredGuid.Equals(Guid.Empty))
    {
      int num2 = (int) MessageBox.Show("Please select a submission to create this new quote under.", "No Submission Selected", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    else
    {
      short status = (short) new Insured(this.CurrentSelectedInsuredGuid).Status;
      if (status != (short) 1)
      {
        if (status == (short) 2 && !SecurityManager.Instance.AssertPermission("{9225EE00-057D-4cc5-B09D-A626186BD713}"))
        {
          int num3 = (int) MessageBox.Show("You do not have the required security to add new quotes on an inactive insured", "Need Required Security", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
          return;
        }
        if (status == (short) 3 && !SecurityManager.Instance.AssertPermission("{BFD2701B-C237-4f71-B918-113625AD47F9}"))
        {
          int num4 = (int) MessageBox.Show("You do not have the required security to add new quotes on a closed insured", "Need Required Security", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
          return;
        }
      }
      if (((UltraGridBase) this.ugInsuredNavigation).ActiveRow == null)
      {
        int num5 = (int) MessageBox.Show("Please select a submission in the grid to create the quote under.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      }
      else
      {
        Guid empty = Guid.Empty;
        if (((UltraGridBase) this.ugInsuredNavigation).ActiveRow.Band.Index == 1)
        {
          if (((UltraGridBase) this.ugInsuredNavigation).ActiveRow.Cells["ProducerLocationGuid"].Value != DBNull.Value && ((UltraGridBase) this.ugInsuredNavigation).ActiveRow.Cells["ProducerLocationGuid"].Value != null)
            empty = (Guid) ((UltraGridBase) this.ugInsuredNavigation).ActiveRow.Cells["ProducerLocationGuid"].Value;
        }
        else if (((UltraGridBase) this.ugInsuredNavigation).ActiveRow.Band.Index == 2 && ((UltraGridBase) this.ugInsuredNavigation).ActiveRow.ParentRow != null && ((UltraGridBase) this.ugInsuredNavigation).ActiveRow.ParentRow.Cells["ProducerLocationGuid"].Value != null && ((UltraGridBase) this.ugInsuredNavigation).ActiveRow.ParentRow.Cells["ProducerLocationGuid"].Value != DBNull.Value)
          empty = (Guid) ((UltraGridBase) this.ugInsuredNavigation).ActiveRow.ParentRow.Cells["ProducerLocationGuid"].Value;
        if (!empty.Equals(Guid.Empty) && new ProducerLocation(empty).StatusID != 1 && !SecurityManager.Instance.AssertPermission("{C05AEB0A-B1C4-4617-A252-D171BDC8C193}"))
        {
          int num6 = (int) MessageBox.Show("You do not have the required security to add new quotes on an inactive / closed producer location", "Need Required Security", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        else
        {
          UltraGridRow activeRow = ((UltraGridBase) this.ugInsuredNavigation).ActiveRow;
          if (activeRow.Band.Index != 2)
          {
            Quote.Create((Guid) activeRow.Cells["SubmissionGroupGuid"].Value);
          }
          else
          {
            this.ClientReplicateQuote();
            frmPolicyDetail.ReplicateQuote((Guid) activeRow.Cells["QuoteGuid"].Value);
          }
        }
      }
    }
  }

  protected virtual void ClientReplicateQuote()
  {
  }

  protected Guid CopySubmission(Guid submissionGroupGuid, bool showDialogs)
  {
    DataRow dataRow = DefaultDatabase.ExecuteDataRow("dbo.CopySubmission", new object[4]
    {
      (object) "@submissionGroupGuid",
      (object) submissionGroupGuid,
      (object) "@userGuid",
      (object) CurrentUser.Instance.UserGUID
    });
    Guid guid = (Guid) dataRow[0];
    int num1 = (int) dataRow[1];
    dsInsuredNavigation.tblProducerSubmissionsRow submissionGroupGuid1 = this.DsInsuredNavigation.tblProducerSubmissions.FindBySubmissionGroupGuid(submissionGroupGuid);
    dsInsuredNavigation.tblProducerSubmissionsRow row = this.DsInsuredNavigation.tblProducerSubmissions.NewtblProducerSubmissionsRow();
    dsInsuredNavigation.tblProducerSubmissionsRow producerSubmissionsRow = row;
    if (!submissionGroupGuid1.IsUnderwriterNull())
      producerSubmissionsRow.Underwriter = submissionGroupGuid1.Underwriter;
    if (!submissionGroupGuid1.IsViewQuotesNull())
      producerSubmissionsRow.ViewQuotes = submissionGroupGuid1.ViewQuotes;
    producerSubmissionsRow.DateSubmitted = submissionGroupGuid1.DateSubmitted;
    producerSubmissionsRow.InsuredGuid = submissionGroupGuid1.InsuredGuid;
    producerSubmissionsRow.Name = submissionGroupGuid1.Name;
    producerSubmissionsRow.ProducerGuid = submissionGroupGuid1.ProducerGuid;
    producerSubmissionsRow.ProducerLocationGuid = submissionGroupGuid1.ProducerLocationGuid;
    producerSubmissionsRow.SubmissionGroupGuid = guid;
    producerSubmissionsRow.SubmissionGroupID = num1;
    producerSubmissionsRow.tblInsuredsRow = row.tblInsuredsRow;
    this.DsInsuredNavigation.tblProducerSubmissions.AddtblProducerSubmissionsRow(row);
    if (DefaultDatabase.ExecuteScalar<bool>(CommandType.Text, "SELECT dbo.AreDocumentsAssociatedToEntityGuid(@subGroupGUID)", new object[2]
    {
      (object) "@subGroupGUID",
      (object) submissionGroupGuid
    }) && MessageBox.Show("Do you wish to copy over the documents to the new submission group?", "Copy Over Submission Group Documents?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
    {
      this.Cursor = MgaCursors.WaitCursor;
      try
      {
        DefaultDatabase.ExecuteNonQuery("dbo.spCopySubmissionGroupDocuments", new object[4]
        {
          (object) "@submissionGroupGuid",
          (object) submissionGroupGuid,
          (object) "@newSubmissionGroupGuid",
          (object) guid
        });
      }
      finally
      {
        this.Cursor = MgaCursors.Default;
      }
    }
    if (showDialogs)
    {
      int num2 = (int) MessageBox.Show("The submission was successfully copied.", "Submission Copied", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    return guid;
  }

  private void CopySubmission()
  {
    if (!SecurityManager.Instance.AssertPermission("{0450B0F5-9D72-40d4-A52A-67E5963A96DF}"))
    {
      int num = (int) MessageBox.Show("You do not have the required security to edit / duplicate submissions.", "Insufficient Security", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    else
      this.CopySubmission((Guid) ((UltraGridBase) this.ugInsuredNavigation).ActiveRow.Cells["SubmissionGroupGuid"].Value, true);
  }

  private void DeleteInsured()
  {
    Guid guid = (Guid) ((UltraGridBase) this.ugInsuredNavigation).ActiveRow.Cells["InsuredGuid"].Value;
    try
    {
      new Insured(guid).Delete();
    }
    catch (SubmissionsExistException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      int num = (int) MessageBox.Show("This insured cannot be deleted because they have existing submissions.", "Cannot Delete", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      ProjectData.ClearProjectError();
    }
  }

  private void DeleteSubmission()
  {
    // ISSUE: unable to decompile the method.
  }

  protected virtual void ClientWorkAfterSubmissionDeleted(Guid submissionGroupGuid)
  {
  }

  private void ugInsuredNavigation_InitializeRow(object sender, InitializeRowEventArgs e)
  {
    if (this.DesignMode)
      return;
    try
    {
      this.InitializeRow(e.Row);
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      ErrorHandler.HandleError(ex);
      ProjectData.ClearProjectError();
    }
  }

  private void InitializeRow(UltraGridRow row)
  {
    if (row.Band.Index == 0 && Versioned.IsNumeric((object) row.Cells["SubmissionCount"].Text))
    {
      if (row.Expanded & Conversions.ToInteger(row.Cells["SubmissionCount"].Text) > 0)
      {
        row.Cells["ViewSubmissions"].Value = (object) "Hide Submissions";
      }
      else
      {
        int integer = Conversions.ToInteger(row.Cells["SubmissionCount"].Text);
        if (integer > 0)
          row.Cells["ViewSubmissions"].Value = (object) (integer.ToString() + " Submissions");
        else
          row.Cells["ViewSubmissions"].Value = (object) "New Submission";
      }
    }
    else if (row.Band.Index == 1)
    {
      if (row.Expanded)
      {
        row.Cells["ViewQuotes"].Value = (object) "Hide Quotes";
      }
      else
      {
        int num = DefaultDatabase.ExecuteScalar<int>(CommandType.Text, "SELECT dbo.QuoteCount(@SubmissionGroupGuid)", new object[2]
        {
          (object) "@SubmissionGroupGuid",
          row.Cells["SubmissionGroupGuid"].Value
        });
        if (num > 0)
          row.Cells["ViewQuotes"].Value = (object) (num.ToString() + " Quotes");
        else
          row.Cells["ViewQuotes"].Value = (object) "New Quote";
      }
    }
    else
    {
      if (row.Band.Index != 2)
        return;
      if (!string.IsNullOrWhiteSpace(this._tagInformationHeader.Value) && !string.IsNullOrWhiteSpace(this._tagInformationDocTag.Value) && this._tagParserFactoryInstance != null)
      {
        if (this._tagParserFactoryInstance.QueryTagParser(1, new object[1]
        {
          (object) (Guid) row.Cells["QuoteGuid"].Value
        }) is ITagParser itagParser && this._docTag != null)
        {
          IList<IDocTag> idocTagList = itagParser.ProcessTagList((IList<IDocTag>) new List<IDocTag>()
          {
            this._docTag
          });
          if (idocTagList != null && idocTagList.Count > 0)
            row.Cells["TagInformation"].Value = (object) idocTagList[0].TagValue;
        }
      }
      bool flag = (int) row.Cells["QuoteStatusID"].Value == 12;
      DateTime now = (DateTime) row.Cells["ExpirationDate"].Value;
      DateTime date1 = now.Date;
      now = DateAndTime.Now;
      DateTime date2 = now.Date;
      if (DateTime.Compare(date1, date2) < 0 || flag)
      {
        Appearance appearance1 = row.Appearance;
        appearance1.BackColor = Color.WhiteSmoke;
        appearance1.ForeColor = Color.Gray;
        if (flag)
        {
          Appearance appearance2 = row.Cells["EffectiveDate"].Appearance;
          appearance2.ForeColor = Color.Red;
          appearance2.FontData.Bold = (DefaultableBoolean) 1;
          appearance2.FontData.Strikeout = (DefaultableBoolean) 1;
          AppearanceBase activeAppearance1 = row.Cells["EffectiveDate"].ActiveAppearance;
          activeAppearance1.ForeColor = Color.Red;
          activeAppearance1.FontData.Bold = (DefaultableBoolean) 1;
          activeAppearance1.FontData.Strikeout = (DefaultableBoolean) 1;
          Appearance appearance3 = row.Cells["ExpirationDate"].Appearance;
          appearance3.ForeColor = Color.Red;
          appearance3.FontData.Bold = (DefaultableBoolean) 1;
          appearance3.FontData.Strikeout = (DefaultableBoolean) 1;
          AppearanceBase activeAppearance2 = row.Cells["ExpirationDate"].ActiveAppearance;
          activeAppearance2.ForeColor = Color.Red;
          activeAppearance2.FontData.Bold = (DefaultableBoolean) 1;
          activeAppearance2.FontData.Strikeout = (DefaultableBoolean) 1;
        }
        else
        {
          Appearance appearance4 = row.Cells["ExpirationDate"].Appearance;
          appearance4.ForeColor = Color.Red;
          appearance4.FontData.Bold = (DefaultableBoolean) 1;
          AppearanceBase activeAppearance = row.Cells["ExpirationDate"].ActiveAppearance;
          activeAppearance.ForeColor = Color.Red;
          activeAppearance.FontData.Bold = (DefaultableBoolean) 1;
        }
      }
      else
      {
        Appearance appearance = row.Cells["ExpirationDate"].Appearance;
        appearance.ForeColor = Color.DarkGreen;
        appearance.FontData.Bold = (DefaultableBoolean) 2;
        AppearanceBase activeAppearance = row.Cells["ExpirationDate"].ActiveAppearance;
        activeAppearance.ForeColor = Color.DarkGreen;
        activeAppearance.FontData.Bold = (DefaultableBoolean) 2;
        row.Appearance.BorderColor = Color.DarkGreen;
      }
      if (Conversions.ToInteger(row.Cells["QuoteStatusID"].Value) == 14)
      {
        Appearance appearance = row.Appearance;
        appearance.ForeColor = Color.Red;
        appearance.FontData.Strikeout = (DefaultableBoolean) 1;
      }
      if (!Information.IsDBNull((object) row.Cells["ReasonColor"]) && !Information.IsDBNull(RuntimeHelpers.GetObjectValue(row.Cells["ReasonColor"].Value)) && Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(row.Cells["ReasonColor"].Value)))
      {
        row.Cells["Reason"].Appearance.ForeColor = Color.FromArgb(Conversions.ToInteger(row.Cells["ReasonColor"].Value));
        row.Cells["Reason"].ActiveAppearance.ForeColor = Color.FromArgb(Conversions.ToInteger(row.Cells["ReasonColor"].Value));
      }
      this.ShowAdditionalDataLink();
      this.LoadAdditionalData(row);
      this.GetPostSearchInfo(row);
    }
  }

  private void GetPostSearchInfo(UltraGridRow row)
  {
    if (!((KeyedSubObjectsCollectionBase) row.Cells).Exists("QuoteStatusID"))
      return;
    try
    {
      Quote quote = Quote.FromControlNo((int) row.Cells["ControlNo"].Value);
      if (!quote.IsBound && !quote.IsEndorsement)
        return;
      if (DateTime.Compare(quote.ExpirationDate.Date, DateAndTime.Now.Date) < 0)
        row.Cells["QuoteStatusID"].Value = (object) -20;
      else if (quote.PolicyIsNonRenewed)
      {
        row.Cells["QuoteStatusID"].Value = (object) 17;
      }
      else
      {
        if (!quote.PolicyDateIssued.HasValue)
          return;
        row.Cells["QuoteStatusID"].Value = (object) -21;
      }
    }
    catch (NullReferenceException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      ErrorHandler.SilentLogError((Exception) ex);
      ProjectData.ClearProjectError();
    }
  }

  private void GridBandsHyperLinkOpening(object sender, CancelEventArgs e)
  {
    UltraGridRow activeRow = ((UltraGridBase) this.ugInsuredNavigation).ActiveRow;
    if (activeRow == null)
      return;
    try
    {
      this.Cursor = MgaCursors.WaitCursor;
      if (activeRow.Band.Index == 0)
      {
        if (Conversions.ToInteger(activeRow.Cells["SubmissionCount"].Text) == 0)
        {
          this.NewSubmission();
          return;
        }
      }
      else if (activeRow.Band.Index == 1 && activeRow.Cells["ViewQuotes"].Text.Contains("New"))
      {
        this.NewQuote();
        return;
      }
      if (activeRow.Expanded)
      {
        activeRow.CollapseAll();
        activeRow.Activate();
      }
      else
        activeRow.Expanded = true;
      this.UpdateButtonEnabledState();
      this.InitializeRow(activeRow);
    }
    finally
    {
      if (!((Control) this.panelSearch).Visible)
        this.Cursor = MgaCursors.Default;
    }
  }

  private void ugInsuredNavigation_MouseDown(object sender, MouseEventArgs e)
  {
    UIElement uiElement = ((UIElement) ((UltraGridBase) this.ugInsuredNavigation).DisplayLayout.UIElement).ElementFromPoint(new Point(e.X, e.Y));
    if (uiElement == null)
      return;
    UltraGridRow context = (UltraGridRow) uiElement.GetContext(typeof (UltraGridRow), true);
    if (context == null)
      return;
    if (((UltraGridBase) this.ugInsuredNavigation).ActiveRow != context)
      ((UltraGridBase) this.ugInsuredNavigation).ActiveRow = context;
    if (context.Selected)
      return;
    this.ugInsuredNavigation.Selected.Rows.Clear();
  }

  private void HideQuoteContextMenuItems()
  {
    UltraToolbarsManager toolBar = this.toolBar;
    ((ToolsCollectionBase) toolBar.Tools)["Renew Policy"].SharedProps.Visible = false;
    ((ToolsCollectionBase) toolBar.Tools)["Delete Quote"].SharedProps.Visible = false;
    ((ToolsCollectionBase) toolBar.Tools)["Edit Quote"].SharedProps.Visible = false;
    ((ToolsCollectionBase) toolBar.Tools)["Unbind Policy"].SharedProps.Visible = false;
    ((ToolsCollectionBase) toolBar.Tools)["Print Quote"].SharedProps.Visible = false;
    ((ToolsCollectionBase) toolBar.Tools)["Duplicate Quote"].SharedProps.Visible = false;
    ((ToolsCollectionBase) toolBar.Tools)["Change Status"].SharedProps.Visible = false;
    ((ToolsCollectionBase) toolBar.Tools)["Rewrite Policy"].SharedProps.Visible = false;
    ((ToolsCollectionBase) toolBar.Tools)["Change Quote Status Reason"].SharedProps.Visible = false;
    ((ToolsCollectionBase) toolBar.Tools)["Quote Option Details"].SharedProps.Visible = false;
    ((ToolsCollectionBase) toolBar.Tools)["Renew All"].SharedProps.Visible = false;
    ((ToolsCollectionBase) toolBar.Tools)["Change Underwriter"].SharedProps.Visible = false;
  }

  private void ProcessGridRowDblClick(UltraGridRow row)
  {
    switch (row.Band.Index)
    {
      case 0:
        FormSettings.ShowForm(typeof (frmInsureds), new object[1]
        {
          (object) (Guid) row.Cells["InsuredGuid"].Value
        });
        break;
      case 1:
        if (!SecurityManager.Instance.AssertPermission("{F84D8084-A0FB-4d3c-9F9F-545CB3CC5374}"))
        {
          int num = (int) MessageBox.Show("You do not have the required security to view producers", "Insufficient Security", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
          break;
        }
        FormSettings.ShowForm(typeof (frmProducers), new object[2]
        {
          row.Cells["ProducerGuid"].Value,
          row.Cells["ProducerLocationGuid"].Value
        });
        break;
      case 2:
        if (this.CurrentSubmissionGroupGuid.Equals(Guid.Empty) || ((UltraGridBase) this.ugInsuredNavigation).ActiveRow == null)
          break;
        this.OpenQuote();
        break;
    }
  }

  private void UpdateButtonEnabledState()
  {
    try
    {
      if (((UltraGridBase) this.ugInsuredNavigation).ActiveRow != null)
      {
        foreach (UltraGridRow row in this.ugInsuredNavigation.Selected.Rows)
          row.Selected = false;
        ((UltraGridBase) this.ugInsuredNavigation).ActiveRow.Selected = true;
        ((ToolsCollectionBase) ((UltraToolbarBase) this.toolBar.Toolbars[0]).Tools)["New Submission"].SharedProps.Enabled = true;
        switch (((UltraGridBase) this.ugInsuredNavigation).ActiveRow.Band.Index)
        {
          case 1:
            UltraToolbar toolbar1 = this.toolBar.Toolbars[0];
            ((ToolsCollectionBase) ((UltraToolbarBase) toolbar1).Tools)["New Quote"].SharedProps.Enabled = true;
            ((ToolsCollectionBase) ((UltraToolbarBase) toolbar1).Tools)["Edit Submission"].SharedProps.Enabled = true;
            ((ToolsCollectionBase) ((UltraToolbarBase) toolbar1).Tools)["Open Quote"].SharedProps.Enabled = false;
            break;
          case 2:
            UltraToolbar toolbar2 = this.toolBar.Toolbars[0];
            ((ToolsCollectionBase) ((UltraToolbarBase) toolbar2).Tools)["New Quote"].SharedProps.Enabled = true;
            ((ToolsCollectionBase) ((UltraToolbarBase) toolbar2).Tools)["Edit Submission"].SharedProps.Enabled = true;
            ((ToolsCollectionBase) ((UltraToolbarBase) toolbar2).Tools)["Open Quote"].SharedProps.Enabled = true;
            break;
          default:
            UltraToolbar toolbar3 = this.toolBar.Toolbars[0];
            ((ToolsCollectionBase) ((UltraToolbarBase) toolbar3).Tools)["New Quote"].SharedProps.Enabled = false;
            ((ToolsCollectionBase) ((UltraToolbarBase) toolbar3).Tools)["Edit Submission"].SharedProps.Enabled = false;
            ((ToolsCollectionBase) ((UltraToolbarBase) toolbar3).Tools)["Open Quote"].SharedProps.Enabled = false;
            break;
        }
        ((ToolsCollectionBase) this.toolBar.Tools)["Insured Summary"].SharedProps.Visible = this.DsInsuredNavigation.tblProducerSubmissions.Count > 0 || this.DsInsuredNavigation.tblInsureds.Count > 0;
        if (this._CanViewInsuredSummaryMenu)
          return;
        ((ToolsCollectionBase) this.toolBar.Tools)["Insured Summary"].SharedProps.Visible = false;
      }
      else
      {
        UltraToolbar toolbar = this.toolBar.Toolbars[0];
        ((ToolsCollectionBase) ((UltraToolbarBase) toolbar).Tools)["New Quote"].SharedProps.Enabled = false;
        ((ToolsCollectionBase) ((UltraToolbarBase) toolbar).Tools)["Edit Submission"].SharedProps.Enabled = false;
        ((ToolsCollectionBase) ((UltraToolbarBase) toolbar).Tools)["Open Quote"].SharedProps.Enabled = false;
        ((ToolsCollectionBase) ((UltraToolbarBase) toolbar).Tools)["New Submission"].SharedProps.Enabled = false;
        ((ToolsCollectionBase) ((UltraToolbarBase) toolbar).Tools)["Insured Summary"].SharedProps.Visible = false;
      }
    }
    catch (NullReferenceException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      ProjectData.ClearProjectError();
    }
  }

  protected Guid CreateDuplicateQuote(Guid quoteGuid, bool showPrompts)
  {
    frmClearance frmClearance = this;
    Guid guid1 = quoteGuid;
    if (!DefaultDatabase.ExecuteScalar<bool>(CommandType.Text, this.OriginalRecordFunction(), new object[2]
    {
      (object) "@QG",
      (object) guid1
    }))
    {
      int num = (int) MessageBox.Show("This quote can not be duplicated.  It must be the originally submitted, unbound quote in order to duplicate.", "Can Not Duplicate", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    else if (!showPrompts || MessageBox.Show("Are you sure you want to duplicate this quote?", "Duplicate Quote?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
    {
      Cursor.Current = MgaCursors.WaitCursor;
      MDIControls.Instance.StatusBarText = "Duplicating quote...";
      Guid guid2;
      try
      {
        if (!DefaultDatabase.HasTransaction)
          DefaultDatabase.ExecuteTransaction((EventHandler<ExecuteTransactionEventArgs>) ([SpecialName] (tmpObject, transArgs) =>
          {
            guid2 = closure_1.QuoteDuplicate(closure_0);
            transArgs.Transaction.Commit();
          }));
        else
          guid2 = this.QuoteDuplicate(closure_0);
      }
      finally
      {
        Cursor.Current = MgaCursors.Default;
        MDIControls.Instance.StatusBarText = string.Empty;
      }
      this.updateKeyXMLNodes(closure_0, guid2);
      if (!guid2.Equals(Guid.Empty))
      {
        dsInsuredNavigation.tblLinesToCompanyRow byQuoteGuid = this.DsInsuredNavigation.tblLinesToCompany.FindByQuoteGuid(closure_0);
        this.AddCopiedQuoteToGrid(closure_0, guid2, byQuoteGuid.SubmissionGroupGuid);
        Messaging.SendBroadcastMessage(BroadcastMessages.QuoteDuplicated, (object) new QuoteDuplicatedContext(closure_0, guid2));
      }
      CurrentUser.Instance.LogAction($"Created new quote - duplicate of control # {this.ControlNum}", guid2);
    }
    Guid duplicateQuote;
    return duplicateQuote;
  }

  private Guid QuoteDuplicate(Guid quoteGuid)
  {
    return DefaultDatabase.ExecuteScalar<Guid>("dbo.[spCopyQuote]", new object[6]
    {
      (object) "@QuoteGuid",
      (object) quoteGuid,
      (object) "@TransactionTypeID",
      null,
      (object) "@QuoteStatusID",
      null
    });
  }

  private void updateKeyXMLNodes(Guid quoteGuid, Guid copyQuoteGuid)
  {
    try
    {
      DataTable dataTable1 = new DataTable();
      string empty1 = string.Empty;
      string empty2 = string.Empty;
      string empty3 = string.Empty;
      DataTable dataTable2 = DefaultDatabase.ExecuteDataTable(CommandType.Text, "Select\r\n                                controlno,\r\n                                (\r\n\t\t\t\t\t                select\tnetratexml\r\n\t\t\t\t\t\t            from\ttblquotes\r\n\t\t\t\t\t\t            where\tquoteguid = @QuoteGuid\r\n\t\t\t                    ) as oldnetratexml,\r\n                                insuredpolicyname\r\n                       from\r\n                                tblquotes\r\n                        where\r\n                                quoteguid = @CopyQuoteGuid", new object[4]
      {
        (object) "@QuoteGuid",
        (object) quoteGuid,
        (object) "@CopyQuoteGuid",
        (object) copyQuoteGuid
      });
      if (dataTable2 != null && dataTable2.Rows.Count != 0)
      {
        empty1 = dataTable2.Rows[0]["insuredpolicyname"].ToString();
        empty3 = dataTable2.Rows[0]["Controlno"].ToString();
        empty2 = dataTable2.Rows[0]["oldnetratexml"].ToString();
      }
      XmlDocument xmlDocument = new XmlDocument();
      xmlDocument.LoadXml(empty2);
      string nodeInnerText = this.getNodeInnerText(xmlDocument.SelectSingleNode("QuoteObject/Insured/Quote/IMSGUID"));
      this.setNodeInnerText(xmlDocument.SelectSingleNode("QuoteObject/Insured/LastName"), $"{empty1} C{empty3}");
      xmlDocument.SelectSingleNode("//QuoteObject/Insured/Quote").Attributes.RemoveNamedItem("UnitNumber");
      XmlNode xnParentNode = xmlDocument.SelectSingleNode("QuoteObject/Insured/Quote");
      XmlNode xnChildNode1 = xmlDocument.SelectSingleNode("QuoteObject/Insured/Quote/PolicyNumber");
      XmlNode xnChildNode2 = xmlDocument.SelectSingleNode("QuoteObject/Insured/Quote/QuoteIdentifier");
      XmlNode xnChildNode3 = xmlDocument.SelectSingleNode("QuoteObject/Insured/Quote/IMSGUID");
      this.deleteChildNode(xnParentNode, xnChildNode1);
      this.deleteChildNode(xnParentNode, xnChildNode2);
      this.deleteChildNode(xnParentNode, xnChildNode3);
      if (!string.IsNullOrEmpty(nodeInnerText))
      {
        object objectValue = RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, "Select ProfLiabXML FROM NetRate_ProfLiabXML WITH (NOLOCK) WHERE QuoteID = (SELECT QuoteID FROM tblQuotes WITH (NOLOCK) WHERE ControlGuid = @ControlGuid and originalquoteguid is null)", new object[2]
        {
          (object) "@ControlGuid",
          (object) nodeInnerText
        }));
        if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(objectValue)))
        {
          string str = empty2 + objectValue.ToString();
        }
      }
      DefaultDatabase.ExecuteNonQuery(CommandType.Text, "Update tblquotes set netrate_quoteid = null, netratexml = @xml where quoteguid = @CopyQuoteGuid", new object[4]
      {
        (object) "@xml",
        (object) xmlDocument.OuterXml,
        (object) "@CopyQuoteGuid",
        (object) copyQuoteGuid
      });
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      ProjectData.ClearProjectError();
    }
  }

  private string getNodeInnerText(XmlNode xnNode) => xnNode == null ? "" : xnNode.InnerText;

  private void setNodeInnerText(XmlNode xnNode, string s)
  {
    if (xnNode == null)
      return;
    xnNode.InnerText = s;
  }

  private void deleteChildNode(XmlNode xnParentNode, XmlNode xnChildNode)
  {
    if (xnParentNode == null || xnChildNode == null)
      return;
    xnParentNode.RemoveChild(xnChildNode);
  }

  protected void AddCopiedQuoteToGrid(
    Guid originalQuoteGuid,
    Guid newQuoteGuid,
    Guid submissionGroupGuid)
  {
    int controlNo = DefaultDatabase.ExecuteScalar<int>(CommandType.Text, "SELECT ControlNo FROM tblQuotes WITH (NOLOCK) WHERE QuoteGuid=@QuoteGuid", new object[2]
    {
      (object) "@QuoteGuid",
      (object) newQuoteGuid
    });
    dsInsuredNavigation.tblLinesToCompanyRow byQuoteGuid = this.DsInsuredNavigation.tblLinesToCompany.FindByQuoteGuid(originalQuoteGuid);
    object obj = (object) null;
    if (!byQuoteGuid.IsCompanyLocationGuidNull())
      obj = (object) byQuoteGuid.CompanyLocationGuid;
    string empty1 = string.Empty;
    string empty2 = string.Empty;
    if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(byQuoteGuid["Name"])))
      empty1 = byQuoteGuid["Name"].ToString();
    if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(byQuoteGuid["State"])))
      empty2 = byQuoteGuid["State"].ToString();
    this.AddQuote(newQuoteGuid, submissionGroupGuid, RuntimeHelpers.GetObjectValue(obj), byQuoteGuid.EffectiveDate, byQuoteGuid.ExpirationDate, byQuoteGuid.LineName, empty1, controlNo, empty2, byQuoteGuid.QuickQuote);
  }

  private void CreateDuplicateQuote() => this.CreateDuplicateQuote(this.QuoteGuid, true);

  private Guid GetSelectedInsuredLocationGuid()
  {
    Guid insuredLocationGuid;
    if (((UltraGridBase) this.ugInsuredNavigation).ActiveRow == null)
    {
      insuredLocationGuid = Guid.Empty;
    }
    else
    {
      Guid guid;
      switch (((UltraGridBase) this.ugInsuredNavigation).ActiveRow.Band.Index)
      {
        case 0:
          guid = (Guid) ((UltraGridBase) this.ugInsuredNavigation).ActiveRow.Cells["InsuredGuid"].Value;
          break;
        case 1:
          guid = (Guid) ((UltraGridBase) this.ugInsuredNavigation).ActiveRow.ParentRow.Cells["InsuredGuid"].Value;
          break;
        case 2:
          guid = (Guid) ((UltraGridBase) this.ugInsuredNavigation).ActiveRow.ParentRow.ParentRow.Cells["InsuredGuid"].Value;
          break;
      }
      insuredLocationGuid = DefaultDatabase.ExecuteScalar<Guid?>(CommandType.Text, "SELECT InsuredLocationGuid FROM dbo.tblInsuredLocations WITH (NOLOCK) WHERE InsuredGuid=@IG AND LocationTypeID=@LT", new object[4]
      {
        (object) "@IG",
        (object) guid,
        (object) "@LT",
        (object) (LocationTypes) 1
      }) ?? Guid.Empty;
    }
    return insuredLocationGuid;
  }

  private Guid GetSelectedSubmissionGroupGuid()
  {
    Guid empty;
    if (((UltraGridBase) this.ugInsuredNavigation).ActiveRow == null)
    {
      empty = Guid.Empty;
    }
    else
    {
      switch (((UltraGridBase) this.ugInsuredNavigation).ActiveRow.Band.Index)
      {
        case 1:
          empty = (Guid) ((UltraGridBase) this.ugInsuredNavigation).ActiveRow.Cells["SubmissionGroupGuid"].Value;
          break;
        case 2:
          empty = (Guid) ((UltraGridBase) this.ugInsuredNavigation).ActiveRow.ParentRow.Cells["SubmissionGroupGuid"].Value;
          break;
      }
    }
    return empty;
  }

  private void ShowContextMenuReport(ClearanceContextMenuLevelEnum level, Type myType)
  {
    object[] objArray;
    switch ((int) level)
    {
      case 0:
        objArray = new object[1]
        {
          (object) this.GetSelectedInsuredLocationGuid()
        };
        break;
      case 1:
        objArray = new object[1]
        {
          (object) this.GetSelectedSubmissionGroupGuid()
        };
        break;
      case 2:
        objArray = new object[1]{ (object) this.QuoteGuid };
        break;
      default:
        throw new InvalidOperationException("Invalid ClearanceContextMenuLevelEnum parameter passed");
    }
    if (typeof (MGAReport).IsAssignableFrom(myType))
      ReportFactory.Instance.ShowReport(false, myType, objArray);
    else if (typeof (ThirdPartyReport).IsAssignableFrom(myType))
      ReportFactory.Instance.ShowThirdPartyReport(false, myType, objArray);
    else if (typeof (MGAExcelReport).IsAssignableFrom(myType))
    {
      ReportFactory.Instance.ExportReport(myType, objArray);
    }
    else
    {
      if (!typeof (GenericAutomationReport).IsAssignableFrom(myType))
        return;
      AutomationReportAttribute automationReportAttribute = myType.GetCustomAttributes(true).OfType<AutomationReportAttribute>().FirstOrDefault<AutomationReportAttribute>();
      Guid guid = automationReportAttribute != null ? automationReportAttribute.AutomationReportGuid : Guid.Empty;
      Quote quote = Quote.CreateNew(this.QuoteGuid);
      CompanyDocumentAutomation objectAs = ObjectFactory.Instance.CreateObjectAs<CompanyDocumentAutomation>(new object[2]
      {
        (object) guid,
        (object) quote.CompanyLine.CompanyLineID
      });
      CompanyDocumentAutomation.Initialize();
      objectAs.QuoteGuid = quote.QuoteGuid;
      objectAs.CreatePDFPackage();
    }
  }

  private void RunContextMenuItem(ClearanceContextMenuLevelEnum level, string myType)
  {
    Type typeFromString = ObjectFactory.Instance.CreateTypeFromString(myType);
    if (typeof (MGAExcelReport).IsAssignableFrom(typeFromString) || typeof (MGAReport).IsAssignableFrom(typeFromString) || typeof (ThirdPartyReport).IsAssignableFrom(typeFromString) || typeof (GenericAutomationReport).IsAssignableFrom(typeFromString))
    {
      this.ShowContextMenuReport(level, typeFromString);
    }
    else
    {
      if (!typeof (Form).IsAssignableFrom(typeFromString))
        return;
      Guid submissionGroupGuid = this.GetSelectedSubmissionGroupGuid();
      ObjectFactory.Instance.CreateForm(typeFromString, new object[1]
      {
        (object) submissionGroupGuid
      }).Show();
    }
  }

  private void AttachImageToNotes()
  {
    if (!frmClearance._queryForNotesOnQuoteCard.Value)
      return;
    try
    {
      foreach (UltraGridRow ultraGridRow in ((UltraGridBase) this.ugInsuredNavigation).DisplayLayout.Bands[2].GetRowEnumerator((GridRowType) 1).OfType<UltraGridRow>())
      {
        if ((bool) ultraGridRow.Cells["HasPopupNotes"].Value)
        {
          ultraGridRow.Appearance.ImageHAlign = (HAlign) 3;
          ultraGridRow.Band.Override.CardCaptionAppearance.Image = (object) this._notesImage;
        }
      }
    }
    finally
    {
      IEnumerator<UltraGridRow> enumerator;
      enumerator?.Dispose();
    }
  }

  public void OnMessageReceived(Guid eventGuid, object context)
  {
    if (eventGuid.Equals(BroadcastMessages.InsuredDeleted))
      this.InsuredDeletedMessageReceived((Guid) context);
    else if (eventGuid.Equals(BroadcastMessages.InsuredAdded))
      this.RefreshSearch();
    else if (eventGuid.Equals(BroadcastMessages.QuoteDeleted))
    {
      this.QuoteDeletedMessageReceived((QuoteDeletedContext) context);
    }
    else
    {
      if (!eventGuid.Equals(BroadcastMessages.PremiumChanged))
        return;
      object[] objArray = (object[]) context;
      Guid QuoteGuid = (Guid) objArray[0];
      Decimal num = (Decimal) objArray[1];
      dsInsuredNavigation.tblLinesToCompanyRow byQuoteGuid = this.DsInsuredNavigation.tblLinesToCompany.FindByQuoteGuid(QuoteGuid);
      if (byQuoteGuid != null)
      {
        byQuoteGuid.Premium = Convert.ToDouble(num);
      }
      else
      {
        DataRow[] dataRowArray = this.DsInsuredNavigation.tblLinesToCompany.Select($"ControlNo={new Quote(QuoteGuid).ControlNo}");
        if (dataRowArray == null || dataRowArray.Length != 1)
          return;
        ((dsInsuredNavigation.tblLinesToCompanyRow) dataRowArray[0]).Premium = Convert.ToDouble(num);
      }
    }
  }

  private void InsuredDeletedMessageReceived(Guid insuredGuid)
  {
    if (this.DsInsuredNavigation.tblInsureds.FindByInsuredGuid(insuredGuid) == null)
      return;
    this.DsInsuredNavigation.tblInsureds.RemovetblInsuredsRow(this.DsInsuredNavigation.tblInsureds.FindByInsuredGuid(insuredGuid));
  }

  private void QuoteDeletedMessageReceived(QuoteDeletedContext qdc)
  {
    dsInsuredNavigation.tblLinesToCompanyRow byQuoteGuid = this.DsInsuredNavigation.tblLinesToCompany.FindByQuoteGuid(qdc.QuoteGuid);
    if (byQuoteGuid == null)
      return;
    try
    {
      byQuoteGuid.Delete();
      this.DsInsuredNavigation.tblLinesToCompany.AcceptChanges();
    }
    catch (ArgumentOutOfRangeException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      ProjectData.ClearProjectError();
    }
    catch (RowNotInTableException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      ProjectData.ClearProjectError();
    }
    Quote quote = Quote.FromControlNo(qdc.ControlNo);
    if (quote == null)
      return;
    this._daQuotes.SelectCommand.Parameters["@QuoteGuid"].Value = (object) quote.QuoteGuid;
    this.FillQuotes(this.DsInsuredNavigation.tblLinesToCompany);
  }

  List<int> ISupportTemplateDocs.SupportedTemplateGroupIDs
  {
    get
    {
      List<int> templateGroupIds;
      if (((UltraGridBase) this.ugInsuredNavigation).ActiveRow == null)
      {
        templateGroupIds = (List<int>) null;
      }
      else
      {
        List<int> intList = new List<int>();
        switch (((UltraGridBase) this.ugInsuredNavigation).ActiveRow.Band.Index)
        {
          case 0:
            intList.Add(4);
            break;
          case 1:
            intList.Add(4);
            intList.Add(3);
            break;
          case 2:
            intList.Add(4);
            intList.Add(3);
            intList.Add(1);
            break;
        }
        templateGroupIds = intList;
      }
      return templateGroupIds;
    }
  }

  public string InsuredLocationName
  {
    get => new InsuredLocation(this.GetSelectedInsuredLocationGuid()).LocationName;
  }

  public DateTime SubmissionDate
  {
    get => new SubmissionGroup(this.GetSelectedSubmissionGroupGuid()).DateSubmitted;
  }

  public string PolicyNum
  {
    get
    {
      return ((UltraGridBase) this.ugInsuredNavigation).ActiveRow.Cells["PolicyNumber"].Value.ToString();
    }
  }

  object[] ISupportTemplateDocs.TagParserConstructorArgs(int automationDocGroupID)
  {
    object[] objArray;
    switch ((MGASystems.IMS.Reporting.AutomationReports.Enums.AutomationDocGroups) Enum.Parse(typeof (MGASystems.IMS.Reporting.AutomationReports.Enums.AutomationDocGroups), automationDocGroupID.ToString()) - 1)
    {
      case 0:
        if (((UltraGridBase) this.ugInsuredNavigation).ActiveRow == null || ((UltraGridBase) this.ugInsuredNavigation).ActiveRow.Band.Index != 2)
        {
          int num = (int) MessageBox.Show("No quote is currently selected on the clearance screen.\n\nPlease select a quote card and try again.", "No Quote Selected", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
          objArray = (object[]) null;
          break;
        }
        objArray = new object[1]{ (object) this.QuoteGuid };
        break;
      case 2:
        objArray = new object[1]
        {
          (object) this.GetSelectedSubmissionGroupGuid()
        };
        break;
      case 3:
        Guid insuredLocationGuid = this.GetSelectedInsuredLocationGuid();
        if (insuredLocationGuid.Equals(Guid.Empty))
        {
          int num = (int) MessageBox.Show("Could not find a primary location for this insured.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
          objArray = (object[]) null;
          break;
        }
        objArray = new object[1]
        {
          (object) insuredLocationGuid
        };
        break;
      default:
        objArray = (object[]) null;
        break;
    }
    return objArray;
  }

  public int ControlNum
  {
    get => (int) ((UltraGridBase) this.ugInsuredNavigation).ActiveRow.Cells["ControlNo"].Value;
  }

  public bool IsBound => new Quote(this.QuoteGuid).IsBound;

  public Guid EntityQuoteGuid => this.QuoteGuid;

  public bool SupportsQuoteContacts => true;

  private void frmClearance_Closing(object sender, CancelEventArgs e)
  {
    this._clearanceDragDropManager.Dispose();
  }

  private void toolBar_BeforeToolbarListDropdown(
    object sender,
    BeforeToolbarListDropdownEventArgs e)
  {
    e.ShowCustomizeMenuItem = false;
    e.ShowLockToolbarsMenuItem = false;
  }

  public Guid[] GetVisibleControlGuids()
  {
    dsInsuredNavigation.tblLinesToCompanyDataTable tblLinesToCompany = this.DsInsuredNavigation.tblLinesToCompany;
    System.Func<dsInsuredNavigation.tblLinesToCompanyRow, Guid> selector;
    // ISSUE: reference to a compiler-generated field
    if (frmClearance._Closure\u0024__.\u0024I325\u002D0 != null)
    {
      // ISSUE: reference to a compiler-generated field
      selector = frmClearance._Closure\u0024__.\u0024I325\u002D0;
    }
    else
    {
      // ISSUE: reference to a compiler-generated field
      frmClearance._Closure\u0024__.\u0024I325\u002D0 = selector = (System.Func<dsInsuredNavigation.tblLinesToCompanyRow, Guid>) ([SpecialName] (row) => row.ControlGuid);
    }
    return tblLinesToCompany.Select<dsInsuredNavigation.tblLinesToCompanyRow, Guid>(selector).ToArray<Guid>();
  }

  private void ChangeUnderwriter()
  {
    if (!SecurityManager.Instance.AssertPermission("{270AC55D-2B31-4273-B663-E600220C1AFA}"))
    {
      int num1 = (int) MessageBox.Show("You do not have the required security to change underwriter on clearance (Right-Click) menu.", "Insufficient Security", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    else
    {
      bool flag1 = false;
      string str = string.Empty;
      bool flag2 = false;
      using (FormChangeUnderwriter formEx = (FormChangeUnderwriter) ObjectFactory.Instance.CreateFormEX(typeof (FormChangeUnderwriter), new object[1]
      {
        (object) this.QuoteGuid
      }))
      {
        int num2 = (int) formEx.ShowDialog();
        flag1 = formEx.UnderwriterChanged;
        str = formEx.NewUnderwriter;
        flag2 = formEx.CanChangeSubmissionUnderwriter;
      }
      if (!flag1)
        return;
      this.UpdateQuote(this.QuoteGuid);
      Quote quote = Quote.FromQuoteGuid(this.QuoteGuid);
      if (flag2)
      {
        dsInsuredNavigation.tblProducerSubmissionsRow submissionGroupGuid = this.DsInsuredNavigation.tblProducerSubmissions.FindBySubmissionGroupGuid(quote.SubmissionGroupGuid);
        if (submissionGroupGuid != null && !submissionGroupGuid.IsUnderwriterNull())
        {
          submissionGroupGuid.Underwriter = str;
          ((UltraGridBase) this.ugInsuredNavigation).UpdateData();
        }
      }
      quote.SendNewSubmissionDiaryItem();
      Messaging.SendBroadcastMessage(BroadcastMessages.UnderwriterChanged, (object) this.QuoteGuid);
    }
  }

  public virtual void ShowAdditionalDataLink()
  {
  }

  public virtual void LoadAdditionalData(UltraGridRow row)
  {
  }

  public delegate void SearchCompleteEventHandler(object sender, EventArgs e);

  internal enum Bands
  {
    Insured,
    Submission,
    Quotes,
  }

  public enum SelectCommandType
  {
    Insureds,
    Producers,
    Quotes,
  }
}
