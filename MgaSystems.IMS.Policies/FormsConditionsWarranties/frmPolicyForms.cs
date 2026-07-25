// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.FormsConditionsWarranties.frmPolicyForms
// Assembly: MgaSystems.IMS.Policies, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 2FF2C709-F7BF-41DA-82BD-FF6319CA235D
// Assembly location: C:\Users\muthu\Downloads\MgaSystems.IMS.Policies.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinProgressBar;
using Infragistics.Win.UltraWinScrollBar;
using Infragistics.Win.UltraWinTabControl;
using Infragistics.Win.UltraWinTabs;
using MGASystems.Common;
using MGASystems.Common.ErrorHandling;
using MGASystems.Common.Extensions;
using MGASystems.Data;
using MGASystems.IMS.DocumentAutomation.TemplateDocuments;
using MGASystems.IMS.NoteDocuments;
using MGASystems.IMS.Policies.Forms_Conditions_Warranties;
using MGASystems.IMS.Reporting.AutomationReports;
using MGASystems.IMS.Security;
using MGASystems.Tools;
using MGASystems.Tools.DBSaveUI;
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
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Policies.FormsConditionsWarranties;

[DocumentFolderFilter("PolicyForm Screen")]
[SecureResource("{0375E906-0641-4505-995E-02C400E706B5}", "Allows Access to Policy Forms", "Allows the user to view Policy Forms.", "Policies")]
[SecureResource("{144A29E6-6D80-4e66-93B7-82FD8AED41DA}", "Policy Forms", "Allows the user to save a PDF documents over a certain size.", "Policies")]
public sealed class frmPolicyForms : Form
{
  private IContainer components;
  private DbDataAdapter daPolicyForms;
  private Label Label1;
  private MGATextBox txtFormName;
  private Label Label2;
  private Label Label3;
  private dsPolicyForms ds;
  private MGATextBox txtDescription;
  private UltraDropDown ddTemplates;
  private ErrorProvider err;
  private Label Label4;
  private MGACheckBox chkRequiresEndorsementNumber;
  private Label Label5;
  private MGASimpleComboBox cboAutomationReports;
  private UltraDropDown UltraDropDown1;
  private Label Label6;
  private UltraTabControl UltraTabControl1;
  private UltraTabSharedControlsPage UltraTabSharedControlsPage1;
  private UltraTabPageControl UltraTabPageControl1;
  private UltraTabPageControl UltraTabPageControl2;
  private UltraLabel lblPDF;
  private Label Label7;
  private UltraDropDown ddParentForms;
  private MGASimpleComboBox cboParentForms;
  private UltraLabel lblTemplate;
  private Label Label8;
  private DbCommand DbSelectCommand1;
  private DbCommand DbInsertCommand1;
  private DbCommand DbUpdateCommand1;
  private DbCommand DbDeleteCommand1;
  private Label Label9;
  private UltraGroupBox panelLoading;
  private UltraProgressBar progress;
  private DataView dvForms;
  internal const string AllowFileSaveOverMaxLimit = "{144A29E6-6D80-4e66-93B7-82FD8AED41DA}";
  internal const string SecurityIDPolicyFormHotKey = "{480D7BE9-8D1D-4f05-BA35-4B6A704A3F9E}";
  public const string CanViewPolicyForms = "{0375E906-0641-4505-995E-02C400E706B5}";
  private int _formID;
  private dsPolicyForms.tblPolicyFormsRow _dRow;
  private string _filterLetter;
  private readonly List<string> _filters;

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private virtual UltraGrid ug
  {
    get => this._ug;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ug_AfterRowActivate);
      InitializeRowEventHandler initializeRowEventHandler = new InitializeRowEventHandler(this.ug_InitializeRow);
      UltraGrid ug1 = this._ug;
      if (ug1 != null)
      {
        ug1.AfterRowActivate -= eventHandler;
        ug1.InitializeRow -= initializeRowEventHandler;
      }
      this._ug = value;
      UltraGrid ug2 = this._ug;
      if (ug2 == null)
        return;
      ug2.AfterRowActivate += eventHandler;
      ug2.InitializeRow += initializeRowEventHandler;
    }
  }

  private virtual LinkLabel lnkAddNewPDF
  {
    get => this._lnkAddNewPDF;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkAddNewPDF_LinkClicked);
      LinkLabel lnkAddNewPdf1 = this._lnkAddNewPDF;
      if (lnkAddNewPdf1 != null)
        lnkAddNewPdf1.LinkClicked -= clickedEventHandler;
      this._lnkAddNewPDF = value;
      LinkLabel lnkAddNewPdf2 = this._lnkAddNewPDF;
      if (lnkAddNewPdf2 == null)
        return;
      lnkAddNewPdf2.LinkClicked += clickedEventHandler;
    }
  }

  private virtual LinkLabel lnkRemovePDF
  {
    get => this._lnkRemovePDF;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkRemovePDF_LinkClicked);
      LinkLabel lnkRemovePdf1 = this._lnkRemovePDF;
      if (lnkRemovePdf1 != null)
        lnkRemovePdf1.LinkClicked -= clickedEventHandler;
      this._lnkRemovePDF = value;
      LinkLabel lnkRemovePdf2 = this._lnkRemovePDF;
      if (lnkRemovePdf2 == null)
        return;
      lnkRemovePdf2.LinkClicked += clickedEventHandler;
    }
  }

  [field: AccessedThroughProperty("txtFormNumber")]
  private virtual MGATextBox txtFormNumber { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual LinkLabel lnkRemoveTemplate
  {
    get => this._lnkRemoveTemplate;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkRemoveTemplate_LinkClicked);
      LinkLabel lnkRemoveTemplate1 = this._lnkRemoveTemplate;
      if (lnkRemoveTemplate1 != null)
        lnkRemoveTemplate1.LinkClicked -= clickedEventHandler;
      this._lnkRemoveTemplate = value;
      LinkLabel lnkRemoveTemplate2 = this._lnkRemoveTemplate;
      if (lnkRemoveTemplate2 == null)
        return;
      lnkRemoveTemplate2.LinkClicked += clickedEventHandler;
    }
  }

  private virtual LinkLabel lnkAddNewTemplate
  {
    get => this._lnkAddNewTemplate;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkAddNewTemplate_LinkClicked);
      LinkLabel lnkAddNewTemplate1 = this._lnkAddNewTemplate;
      if (lnkAddNewTemplate1 != null)
        lnkAddNewTemplate1.LinkClicked -= clickedEventHandler;
      this._lnkAddNewTemplate = value;
      LinkLabel lnkAddNewTemplate2 = this._lnkAddNewTemplate;
      if (lnkAddNewTemplate2 == null)
        return;
      lnkAddNewTemplate2.LinkClicked += clickedEventHandler;
    }
  }

  private virtual AlphabetBar AlphabetBar1
  {
    get => this._AlphabetBar1;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      AlphabetBar.LetterClickedEventHandler clickedEventHandler = new AlphabetBar.LetterClickedEventHandler(this.AlphabetBar1_LetterClicked);
      AlphabetBar alphabetBar1_1 = this._AlphabetBar1;
      if (alphabetBar1_1 != null)
        alphabetBar1_1.LetterClicked -= clickedEventHandler;
      this._AlphabetBar1 = value;
      AlphabetBar alphabetBar1_2 = this._AlphabetBar1;
      if (alphabetBar1_2 == null)
        return;
      alphabetBar1_2.LetterClicked += clickedEventHandler;
    }
  }

  private virtual MGATextBox txtFormNumberFilter
  {
    get => this._txtFormNumberFilter;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.txtFormNumberFilter_ValueChanged);
      MGATextBox formNumberFilter1 = this._txtFormNumberFilter;
      if (formNumberFilter1 != null)
        ((TextEditorControlBase) formNumberFilter1).ValueChanged -= eventHandler;
      this._txtFormNumberFilter = value;
      MGATextBox formNumberFilter2 = this._txtFormNumberFilter;
      if (formNumberFilter2 == null)
        return;
      ((TextEditorControlBase) formNumberFilter2).ValueChanged += eventHandler;
    }
  }

  private virtual LinkLabel lnkNumber
  {
    get => this._lnkNumber;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkNumber_LinkClicked);
      LinkLabel lnkNumber1 = this._lnkNumber;
      if (lnkNumber1 != null)
        lnkNumber1.LinkClicked -= clickedEventHandler;
      this._lnkNumber = value;
      LinkLabel lnkNumber2 = this._lnkNumber;
      if (lnkNumber2 == null)
        return;
      lnkNumber2.LinkClicked += clickedEventHandler;
    }
  }

  private virtual LinkLabel lnkAll
  {
    get => this._lnkAll;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkAll_LinkClicked);
      LinkLabel lnkAll1 = this._lnkAll;
      if (lnkAll1 != null)
        lnkAll1.LinkClicked -= clickedEventHandler;
      this._lnkAll = value;
      LinkLabel lnkAll2 = this._lnkAll;
      if (lnkAll2 == null)
        return;
      lnkAll2.LinkClicked += clickedEventHandler;
    }
  }

  private virtual LinkLabel lnkAddNewTemplateDocuments
  {
    get => this._lnkAddNewTemplateDocuments;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkAddNewTemplateDocuments_LinkClicked);
      LinkLabel templateDocuments1 = this._lnkAddNewTemplateDocuments;
      if (templateDocuments1 != null)
        templateDocuments1.LinkClicked -= clickedEventHandler;
      this._lnkAddNewTemplateDocuments = value;
      LinkLabel templateDocuments2 = this._lnkAddNewTemplateDocuments;
      if (templateDocuments2 == null)
        return;
      templateDocuments2.LinkClicked += clickedEventHandler;
    }
  }

  [field: AccessedThroughProperty("Label10")]
  private virtual Label Label10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtEditionDate")]
  private virtual MGATextBox txtEditionDate { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblFormType")]
  private virtual Label lblFormType { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaCmbFormType")]
  private virtual MGASimpleComboBox MgaCmbFormType { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtComments")]
  private virtual MGATextBox txtComments { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblComments")]
  private virtual Label lblComments { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ddFormType")]
  private virtual UltraDropDown ddFormType { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblFormTypeFilter")]
  private virtual Label lblFormTypeFilter { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual MGATextBox txtFormTypeFilter
  {
    get => this._txtFormTypeFilter;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.txtFormTypeFilter_TextChanged);
      MGATextBox txtFormTypeFilter1 = this._txtFormTypeFilter;
      if (txtFormTypeFilter1 != null)
        ((Control) txtFormTypeFilter1).TextChanged -= eventHandler;
      this._txtFormTypeFilter = value;
      MGATextBox txtFormTypeFilter2 = this._txtFormTypeFilter;
      if (txtFormTypeFilter2 == null)
        return;
      ((Control) txtFormTypeFilter2).TextChanged += eventHandler;
    }
  }

  [field: AccessedThroughProperty("txtURL")]
  private virtual MGATextBox txtURL { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblURL")]
  private virtual Label lblURL { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual MGASystems.Tools.DBSaveUI.DBSaveUI dbSave
  {
    get => this._dbSave;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler1 = new EventHandler(this.dbSave_ClickedNew);
      CancelEventHandler cancelEventHandler1 = new CancelEventHandler(this.dbSave_ClickingDelete);
      CancelEventHandler cancelEventHandler2 = new CancelEventHandler(this.dbSave_ClickingCancel);
      EventHandler eventHandler2 = new EventHandler(this.dbSave_ClickedSave);
      EventHandler eventHandler3 = new EventHandler(this.dbSave_UIStateChanged);
      CancelEventHandler cancelEventHandler3 = new CancelEventHandler(this.dbSave_ClickingSave);
      MGASystems.Tools.DBSaveUI.DBSaveUI dbSave1 = this._dbSave;
      if (dbSave1 != null)
      {
        dbSave1.ClickedNew -= eventHandler1;
        dbSave1.ClickingDelete -= cancelEventHandler1;
        dbSave1.ClickingCancel -= cancelEventHandler2;
        dbSave1.ClickedSave -= eventHandler2;
        dbSave1.UIStateChanged -= eventHandler3;
        dbSave1.ClickingSave -= cancelEventHandler3;
      }
      this._dbSave = value;
      MGASystems.Tools.DBSaveUI.DBSaveUI dbSave2 = this._dbSave;
      if (dbSave2 == null)
        return;
      dbSave2.ClickedNew += eventHandler1;
      dbSave2.ClickingDelete += cancelEventHandler1;
      dbSave2.ClickingCancel += cancelEventHandler2;
      dbSave2.ClickedSave += eventHandler2;
      dbSave2.UIStateChanged += eventHandler3;
      dbSave2.ClickingSave += cancelEventHandler3;
    }
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmPolicyForms));
    Appearance appearance10 = new Appearance();
    UltraGridBand ultraGridBand1 = new UltraGridBand("tblPolicyForms", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("FormID");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("FormName");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("Description");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("TemplateID");
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("FormNumber");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("RequiresEndorsementNumber");
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("AutomationReportGuid");
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("PDF");
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("PDF_Filename");
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("ParentFormID", -1, (object) "ddParentForms");
    UltraGridColumn ultraGridColumn11 = new UltraGridColumn("EditionDate");
    UltraGridColumn ultraGridColumn12 = new UltraGridColumn("FormTypeID");
    UltraGridColumn ultraGridColumn13 = new UltraGridColumn("Comments");
    UltraGridColumn ultraGridColumn14 = new UltraGridColumn("URL");
    UltraGridColumn ultraGridColumn15 = new UltraGridColumn("RequiresEdit");
    UltraGridColumn ultraGridColumn16 = new UltraGridColumn("FilterCharacter");
    Appearance appearance11 = new Appearance();
    Appearance appearance12 = new Appearance();
    Appearance appearance13 = new Appearance();
    Appearance appearance14 = new Appearance();
    Appearance appearance15 = new Appearance();
    Appearance appearance16 = new Appearance();
    Appearance appearance17 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    UltraGridBand ultraGridBand2 = new UltraGridBand("tblDocumentTemplates", -1);
    UltraGridColumn ultraGridColumn17 = new UltraGridColumn("TemplateID");
    UltraGridColumn ultraGridColumn18 = new UltraGridColumn("TemplateName");
    UltraGridColumn ultraGridColumn19 = new UltraGridColumn("tblDocumentTemplatestblPolicyForms");
    UltraGridBand ultraGridBand3 = new UltraGridBand("tblDocumentTemplatestblPolicyForms", -1);
    UltraGridColumn ultraGridColumn20 = new UltraGridColumn("FormID");
    UltraGridColumn ultraGridColumn21 = new UltraGridColumn("FormName");
    UltraGridColumn ultraGridColumn22 = new UltraGridColumn("Description");
    UltraGridColumn ultraGridColumn23 = new UltraGridColumn("TemplateID");
    UltraGridColumn ultraGridColumn24 = new UltraGridColumn("FormNumber");
    UltraGridColumn ultraGridColumn25 = new UltraGridColumn("RequiresEndorsementNumber");
    UltraGridColumn ultraGridColumn26 = new UltraGridColumn("AutomationReportGuid");
    UltraGridColumn ultraGridColumn27 = new UltraGridColumn("PDF");
    UltraGridColumn ultraGridColumn28 = new UltraGridColumn("PDF_Filename");
    UltraGridColumn ultraGridColumn29 = new UltraGridColumn("ParentFormID");
    UltraTab ultraTab1 = new UltraTab();
    Appearance appearance18 = new Appearance();
    UltraTab ultraTab2 = new UltraTab();
    Appearance appearance19 = new Appearance();
    Appearance appearance20 = new Appearance();
    Appearance appearance21 = new Appearance();
    UltraGridBand ultraGridBand4 = new UltraGridBand("tblPolicyForms", -1);
    UltraGridColumn ultraGridColumn30 = new UltraGridColumn("FormID");
    UltraGridColumn ultraGridColumn31 = new UltraGridColumn("FormName");
    UltraGridColumn ultraGridColumn32 = new UltraGridColumn("Description");
    UltraGridColumn ultraGridColumn33 = new UltraGridColumn("TemplateID");
    UltraGridColumn ultraGridColumn34 = new UltraGridColumn("FormNumber");
    UltraGridColumn ultraGridColumn35 = new UltraGridColumn("RequiresEndorsementNumber");
    UltraGridColumn ultraGridColumn36 = new UltraGridColumn("AutomationReportGuid");
    UltraGridColumn ultraGridColumn37 = new UltraGridColumn("PDF");
    UltraGridColumn ultraGridColumn38 = new UltraGridColumn("PDF_Filename");
    UltraGridColumn ultraGridColumn39 = new UltraGridColumn("ParentFormID");
    UltraGridColumn ultraGridColumn40 = new UltraGridColumn("EditionDate");
    UltraGridColumn ultraGridColumn41 = new UltraGridColumn("FormTypeID");
    UltraGridColumn ultraGridColumn42 = new UltraGridColumn("Comments");
    UltraGridColumn ultraGridColumn43 = new UltraGridColumn("URL");
    UltraGridColumn ultraGridColumn44 = new UltraGridColumn("RequiresEdit");
    UltraGridColumn ultraGridColumn45 = new UltraGridColumn("FilterCharacter");
    UltraGridBand ultraGridBand5 = new UltraGridBand("AutomationReports", -1);
    UltraGridColumn ultraGridColumn46 = new UltraGridColumn("AutomationReportGuid");
    UltraGridColumn ultraGridColumn47 = new UltraGridColumn("Title");
    UltraGridColumn ultraGridColumn48 = new UltraGridColumn("AutomationReportstblPolicyForms");
    UltraGridBand ultraGridBand6 = new UltraGridBand("AutomationReportstblPolicyForms", 0);
    UltraGridColumn ultraGridColumn49 = new UltraGridColumn("FormID");
    UltraGridColumn ultraGridColumn50 = new UltraGridColumn("FormName");
    UltraGridColumn ultraGridColumn51 = new UltraGridColumn("Description");
    UltraGridColumn ultraGridColumn52 = new UltraGridColumn("TemplateID");
    UltraGridColumn ultraGridColumn53 = new UltraGridColumn("FormNumber");
    UltraGridColumn ultraGridColumn54 = new UltraGridColumn("RequiresEndorsementNumber");
    UltraGridColumn ultraGridColumn55 = new UltraGridColumn("AutomationReportGuid");
    UltraGridColumn ultraGridColumn56 = new UltraGridColumn("PDF");
    UltraGridColumn ultraGridColumn57 = new UltraGridColumn("PDF_Filename");
    UltraGridColumn ultraGridColumn58 = new UltraGridColumn("ParentFormID");
    UltraGridColumn ultraGridColumn59 = new UltraGridColumn("EditionDate");
    UltraGridColumn ultraGridColumn60 = new UltraGridColumn("FormTypeID");
    UltraGridColumn ultraGridColumn61 = new UltraGridColumn("Comments");
    UltraGridColumn ultraGridColumn62 = new UltraGridColumn("URL");
    UltraGridColumn ultraGridColumn63 = new UltraGridColumn("RequiresEdit");
    UltraGridColumn ultraGridColumn64 = new UltraGridColumn("FilterCharacter");
    UltraGridBand ultraGridBand7 = new UltraGridBand("lstFormTypes", -1);
    UltraGridColumn ultraGridColumn65 = new UltraGridColumn("FormTypeID");
    UltraGridColumn ultraGridColumn66 = new UltraGridColumn("FormType");
    UltraGridColumn ultraGridColumn67 = new UltraGridColumn("FK_lstFormTypes_tblPolicyForms");
    UltraGridBand ultraGridBand8 = new UltraGridBand("FK_lstFormTypes_tblPolicyForms", 0);
    UltraGridColumn ultraGridColumn68 = new UltraGridColumn("FormID");
    UltraGridColumn ultraGridColumn69 = new UltraGridColumn("FormName");
    UltraGridColumn ultraGridColumn70 = new UltraGridColumn("Description");
    UltraGridColumn ultraGridColumn71 = new UltraGridColumn("TemplateID");
    UltraGridColumn ultraGridColumn72 = new UltraGridColumn("FormNumber");
    UltraGridColumn ultraGridColumn73 = new UltraGridColumn("RequiresEndorsementNumber");
    UltraGridColumn ultraGridColumn74 = new UltraGridColumn("AutomationReportGuid");
    UltraGridColumn ultraGridColumn75 = new UltraGridColumn("PDF");
    UltraGridColumn ultraGridColumn76 = new UltraGridColumn("PDF_Filename");
    UltraGridColumn ultraGridColumn77 = new UltraGridColumn("ParentFormID");
    UltraGridColumn ultraGridColumn78 = new UltraGridColumn("EditionDate");
    UltraGridColumn ultraGridColumn79 = new UltraGridColumn("FormTypeID");
    UltraGridColumn ultraGridColumn80 = new UltraGridColumn("Comments");
    UltraGridColumn ultraGridColumn81 = new UltraGridColumn("URL");
    UltraGridColumn ultraGridColumn82 = new UltraGridColumn("RequiresEdit");
    UltraGridColumn ultraGridColumn83 = new UltraGridColumn("FilterCharacter");
    Appearance appearance22 = new Appearance();
    this.UltraTabPageControl1 = new UltraTabPageControl();
    this.txtURL = new MGATextBox();
    this.lblURL = new Label();
    this.txtComments = new MGATextBox();
    this.lblComments = new Label();
    this.MgaCmbFormType = new MGASimpleComboBox();
    this.ds = new dsPolicyForms();
    this.lblFormType = new Label();
    this.Label10 = new Label();
    this.txtEditionDate = new MGATextBox();
    this.Label7 = new Label();
    this.cboParentForms = new MGASimpleComboBox();
    this.txtDescription = new MGATextBox();
    this.Label2 = new Label();
    this.txtFormNumber = new MGATextBox();
    this.txtFormName = new MGATextBox();
    this.chkRequiresEndorsementNumber = new MGACheckBox();
    this.Label4 = new Label();
    this.Label1 = new Label();
    this.dbSave = new MGASystems.Tools.DBSaveUI.DBSaveUI();
    this.UltraTabPageControl2 = new UltraTabPageControl();
    this.lnkAddNewTemplateDocuments = new LinkLabel();
    this.lnkRemoveTemplate = new LinkLabel();
    this.lnkAddNewTemplate = new LinkLabel();
    this.lblTemplate = new UltraLabel();
    this.lnkRemovePDF = new LinkLabel();
    this.lblPDF = new UltraLabel();
    this.lnkAddNewPDF = new LinkLabel();
    this.Label5 = new Label();
    this.cboAutomationReports = new MGASimpleComboBox();
    this.Label3 = new Label();
    this.Label6 = new Label();
    this.daPolicyForms = DefaultDatabase.CreateDataAdapter();
    this.DbDeleteCommand1 = DefaultDatabase.CreateCommand();
    this.DbInsertCommand1 = DefaultDatabase.CreateCommand();
    this.DbSelectCommand1 = DefaultDatabase.CreateCommand();
    this.DbUpdateCommand1 = DefaultDatabase.CreateCommand();
    this.ug = new UltraGrid();
    this.dvForms = new DataView();
    this.ddTemplates = new UltraDropDown();
    this.err = new ErrorProvider(this.components);
    this.UltraTabControl1 = new UltraTabControl();
    this.UltraTabSharedControlsPage1 = new UltraTabSharedControlsPage();
    this.AlphabetBar1 = new AlphabetBar();
    this.Label8 = new Label();
    this.txtFormNumberFilter = new MGATextBox();
    this.panelLoading = new UltraGroupBox();
    this.progress = new UltraProgressBar();
    this.Label9 = new Label();
    this.lnkNumber = new LinkLabel();
    this.lnkAll = new LinkLabel();
    this.ddParentForms = new UltraDropDown();
    this.UltraDropDown1 = new UltraDropDown();
    this.ddFormType = new UltraDropDown();
    this.lblFormTypeFilter = new Label();
    this.txtFormTypeFilter = new MGATextBox();
    ((Control) this.UltraTabPageControl1).SuspendLayout();
    ((ISupportInitialize) this.txtURL).BeginInit();
    ((ISupportInitialize) this.txtComments).BeginInit();
    ((ISupportInitialize) this.MgaCmbFormType).BeginInit();
    this.ds.BeginInit();
    ((ISupportInitialize) this.txtEditionDate).BeginInit();
    ((ISupportInitialize) this.cboParentForms).BeginInit();
    ((ISupportInitialize) this.txtDescription).BeginInit();
    ((ISupportInitialize) this.txtFormNumber).BeginInit();
    ((ISupportInitialize) this.txtFormName).BeginInit();
    ((ISupportInitialize) this.chkRequiresEndorsementNumber).BeginInit();
    ((Control) this.UltraTabPageControl2).SuspendLayout();
    ((ISupportInitialize) this.cboAutomationReports).BeginInit();
    ((ISupportInitialize) this.ug).BeginInit();
    this.dvForms.BeginInit();
    ((ISupportInitialize) this.ddTemplates).BeginInit();
    ((ISupportInitialize) this.err).BeginInit();
    ((ISupportInitialize) this.UltraTabControl1).BeginInit();
    ((Control) this.UltraTabControl1).SuspendLayout();
    ((Control) this.UltraTabSharedControlsPage1).SuspendLayout();
    ((ISupportInitialize) this.txtFormNumberFilter).BeginInit();
    ((ISupportInitialize) this.panelLoading).BeginInit();
    ((Control) this.panelLoading).SuspendLayout();
    ((ISupportInitialize) this.ddParentForms).BeginInit();
    ((ISupportInitialize) this.UltraDropDown1).BeginInit();
    ((ISupportInitialize) this.ddFormType).BeginInit();
    ((ISupportInitialize) this.txtFormTypeFilter).BeginInit();
    this.SuspendLayout();
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.txtURL);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.lblURL);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.txtComments);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.lblComments);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.MgaCmbFormType);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.lblFormType);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.Label10);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.txtEditionDate);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.Label7);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.cboParentForms);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.txtDescription);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.Label2);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.txtFormNumber);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.txtFormName);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.chkRequiresEndorsementNumber);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.Label4);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.Label1);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.dbSave);
    ((Control) this.UltraTabPageControl1).Location = new Point(1, 26);
    ((Control) this.UltraTabPageControl1).Name = "UltraTabPageControl1";
    ((Control) this.UltraTabPageControl1).Size = new Size(793, 246);
    appearance1.BackColor = Color.White;
    appearance1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance1.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtURL).Appearance = (AppearanceBase) appearance1;
    ((TextEditorControlBase) this.txtURL).BackColor = Color.White;
    ((Control) this.txtURL).Location = new Point(80 /*0x50*/, 218);
    ((TextEditorControlBase) this.txtURL).MaxLength = 150;
    this.txtURL.MGAStyle = (MGAStyles) 2;
    ((Control) this.txtURL).Name = "txtURL";
    ((Control) this.txtURL).Size = new Size(249, 20);
    ((Control) this.txtURL).TabIndex = 19;
    ((UltraControlBase) this.txtURL).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtURL).UseOsThemes = (DefaultableBoolean) 2;
    this.lblURL.AutoSize = true;
    this.lblURL.BackColor = Color.Transparent;
    this.lblURL.Location = new Point(44, 222);
    this.lblURL.Name = "lblURL";
    this.lblURL.Size = new Size(30, 13);
    this.lblURL.TabIndex = 18;
    this.lblURL.Text = "URL:";
    this.lblURL.TextAlign = ContentAlignment.MiddleRight;
    appearance2.BackColor = Color.White;
    appearance2.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance2.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtComments).Appearance = (AppearanceBase) appearance2;
    ((TextEditorControlBase) this.txtComments).BackColor = Color.White;
    ((Control) this.txtComments).Location = new Point(80 /*0x50*/, 190);
    ((TextEditorControlBase) this.txtComments).MaxLength = 250;
    this.txtComments.MGAStyle = (MGAStyles) 2;
    ((Control) this.txtComments).Name = "txtComments";
    ((Control) this.txtComments).Size = new Size(249, 20);
    ((Control) this.txtComments).TabIndex = 17;
    ((UltraControlBase) this.txtComments).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtComments).UseOsThemes = (DefaultableBoolean) 2;
    this.lblComments.AutoSize = true;
    this.lblComments.BackColor = Color.Transparent;
    this.lblComments.Location = new Point(13, 193);
    this.lblComments.Name = "lblComments";
    this.lblComments.Size = new Size(61, 13);
    this.lblComments.TabIndex = 16 /*0x10*/;
    this.lblComments.Text = "Comments:";
    this.lblComments.TextAlign = ContentAlignment.MiddleRight;
    ((Control) this.MgaCmbFormType).Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraCombo) this.MgaCmbFormType).BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.MgaCmbFormType).DataSource = (object) this.ds.tblPolicyForms;
    ((UltraDropDownBase) this.MgaCmbFormType).DisplayMember = "FormType";
    ((UltraCombo) this.MgaCmbFormType).DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.MgaCmbFormType).Location = new Point(496, 80 /*0x50*/);
    this.MgaCmbFormType.MGAStyle = (MGAStyles) 2;
    ((Control) this.MgaCmbFormType).Name = "MgaCmbFormType";
    ((Control) this.MgaCmbFormType).Size = new Size(488, 21);
    ((Control) this.MgaCmbFormType).TabIndex = 15;
    ((UltraControlBase) this.MgaCmbFormType).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaCmbFormType).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.MgaCmbFormType).ValueMember = "FormTypeID";
    this.ds.DataSetName = "dsPolicyForms";
    this.ds.Locale = new CultureInfo("en-US");
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.lblFormType.AutoSize = true;
    this.lblFormType.BackColor = Color.Transparent;
    this.lblFormType.Location = new Point(425, 88);
    this.lblFormType.Name = "lblFormType";
    this.lblFormType.Size = new Size(62, 13);
    this.lblFormType.TabIndex = 14;
    this.lblFormType.Text = "Form Type:";
    this.lblFormType.TextAlign = ContentAlignment.MiddleRight;
    this.Label10.AutoSize = true;
    this.Label10.BackColor = Color.Transparent;
    this.Label10.Location = new Point(421, 59);
    this.Label10.Name = "Label10";
    this.Label10.Size = new Size(69, 13);
    this.Label10.TabIndex = 12;
    this.Label10.Text = "Edition Date:";
    this.Label10.TextAlign = ContentAlignment.MiddleRight;
    appearance3.BackColor = Color.White;
    appearance3.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance3.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtEditionDate).Appearance = (AppearanceBase) appearance3;
    ((TextEditorControlBase) this.txtEditionDate).BackColor = Color.White;
    ((Control) this.txtEditionDate).Location = new Point(496, 56);
    ((TextEditorControlBase) this.txtEditionDate).MaxLength = 15;
    this.txtEditionDate.MGAStyle = (MGAStyles) 2;
    ((Control) this.txtEditionDate).Name = "txtEditionDate";
    ((Control) this.txtEditionDate).Size = new Size(136, 20);
    ((Control) this.txtEditionDate).TabIndex = 11;
    ((UltraControlBase) this.txtEditionDate).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtEditionDate).UseOsThemes = (DefaultableBoolean) 2;
    this.Label7.AutoSize = true;
    this.Label7.BackColor = Color.Transparent;
    this.Label7.Location = new Point(2, 32 /*0x20*/);
    this.Label7.Name = "Label7";
    this.Label7.Size = new Size(70, 13);
    this.Label7.TabIndex = 10;
    this.Label7.Text = "Parent Form:";
    this.Label7.TextAlign = ContentAlignment.MiddleRight;
    ((Control) this.cboParentForms).Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraCombo) this.cboParentForms).BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.cboParentForms).DataSource = (object) this.ds.tblPolicyForms;
    ((UltraDropDownBase) this.cboParentForms).DisplayMember = "FormName";
    ((UltraCombo) this.cboParentForms).DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboParentForms).Location = new Point(80 /*0x50*/, 32 /*0x20*/);
    this.cboParentForms.MGAStyle = (MGAStyles) 2;
    ((Control) this.cboParentForms).Name = "cboParentForms";
    ((Control) this.cboParentForms).Size = new Size(692, 21);
    ((Control) this.cboParentForms).TabIndex = 9;
    ((UltraControlBase) this.cboParentForms).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboParentForms).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboParentForms).ValueMember = "FormID";
    ((Control) this.txtDescription).Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    appearance4.BackColor = Color.White;
    appearance4.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance4.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtDescription).Appearance = (AppearanceBase) appearance4;
    ((TextEditorControlBase) this.txtDescription).BackColor = Color.White;
    ((Control) this.txtDescription).Location = new Point(80 /*0x50*/, 112 /*0x70*/);
    this.txtDescription.MGAStyle = (MGAStyles) 2;
    ((UltraTextEditor) this.txtDescription).Multiline = true;
    ((Control) this.txtDescription).Name = "txtDescription";
    ((Control) this.txtDescription).Size = new Size(692, 72);
    ((Control) this.txtDescription).TabIndex = 6;
    ((UltraControlBase) this.txtDescription).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtDescription).UseOsThemes = (DefaultableBoolean) 2;
    this.Label2.AutoSize = true;
    this.Label2.BackColor = Color.Transparent;
    this.Label2.Location = new Point(8, 114);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(64 /*0x40*/, 13);
    this.Label2.TabIndex = 5;
    this.Label2.Text = "Description:";
    this.Label2.TextAlign = ContentAlignment.MiddleRight;
    appearance5.BackColor = Color.White;
    appearance5.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance5.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtFormNumber).Appearance = (AppearanceBase) appearance5;
    ((TextEditorControlBase) this.txtFormNumber).BackColor = Color.White;
    ((Control) this.txtFormNumber).Location = new Point(80 /*0x50*/, 56);
    ((TextEditorControlBase) this.txtFormNumber).MaxLength = 50;
    this.txtFormNumber.MGAStyle = (MGAStyles) 2;
    ((Control) this.txtFormNumber).Name = "txtFormNumber";
    ((Control) this.txtFormNumber).Size = new Size(249, 20);
    ((Control) this.txtFormNumber).TabIndex = 3;
    ((UltraControlBase) this.txtFormNumber).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtFormNumber).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.txtFormName).Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    appearance6.BackColor = Color.White;
    appearance6.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance6.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtFormName).Appearance = (AppearanceBase) appearance6;
    ((TextEditorControlBase) this.txtFormName).BackColor = Color.White;
    ((Control) this.txtFormName).Location = new Point(80 /*0x50*/, 8);
    this.txtFormName.MGAStyle = (MGAStyles) 2;
    ((Control) this.txtFormName).Name = "txtFormName";
    ((Control) this.txtFormName).Size = new Size(692, 20);
    ((Control) this.txtFormName).TabIndex = 1;
    ((UltraControlBase) this.txtFormName).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtFormName).UseOsThemes = (DefaultableBoolean) 2;
    appearance7.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance7.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkRequiresEndorsementNumber).Appearance = (AppearanceBase) appearance7;
    ((UltraToggleEditorBase) this.chkRequiresEndorsementNumber).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkRequiresEndorsementNumber).BackColorInternal = Color.Transparent;
    ((Control) this.chkRequiresEndorsementNumber).DataBindings.Add(new Binding("Checked", (object) this.ds, "tblPolicyForms.RequiresEndorsementNumber", true));
    ((UltraToggleEditorBase) this.chkRequiresEndorsementNumber).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkRequiresEndorsementNumber).Location = new Point(80 /*0x50*/, 80 /*0x50*/);
    this.chkRequiresEndorsementNumber.MGAStyle = (MGAStyles) 2;
    ((Control) this.chkRequiresEndorsementNumber).Name = "chkRequiresEndorsementNumber";
    ((Control) this.chkRequiresEndorsementNumber).Size = new Size(192 /*0xC0*/, 24);
    ((Control) this.chkRequiresEndorsementNumber).TabIndex = 4;
    ((UltraToggleEditorBase) this.chkRequiresEndorsementNumber).Text = "Requires Endorsement Number";
    ((UltraControlBase) this.chkRequiresEndorsementNumber).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkRequiresEndorsementNumber).UseOsThemes = (DefaultableBoolean) 2;
    this.Label4.AutoSize = true;
    this.Label4.BackColor = Color.Transparent;
    this.Label4.Location = new Point(26, 58);
    this.Label4.Name = "Label4";
    this.Label4.Size = new Size(46, 13);
    this.Label4.TabIndex = 2;
    this.Label4.Text = "Form #:";
    this.Label4.TextAlign = ContentAlignment.MiddleRight;
    this.Label1.AutoSize = true;
    this.Label1.BackColor = Color.Transparent;
    this.Label1.Location = new Point(9, 8);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(65, 13);
    this.Label1.TabIndex = 0;
    this.Label1.Text = "Form Name:";
    this.Label1.TextAlign = ContentAlignment.MiddleRight;
    ((Control) this.dbSave).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.dbSave.AutoQueryRowCountOnLoad = false;
    this.dbSave.EditStyle = (EditStyle) 1;
    this.dbSave.FreezeEvents = false;
    ((Control) this.dbSave).Location = new Point(676, 201);
    ((Control) this.dbSave).Name = "dbSave";
    ((Control) this.dbSave).Size = new Size(111, 40);
    ((Control) this.dbSave).TabIndex = 9;
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.lnkAddNewTemplateDocuments);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.lnkRemoveTemplate);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.lnkAddNewTemplate);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.lblTemplate);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.lnkRemovePDF);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.lblPDF);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.lnkAddNewPDF);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.Label5);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.cboAutomationReports);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.Label3);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.Label6);
    ((Control) this.UltraTabPageControl2).Location = new Point(-6250, -7000);
    ((Control) this.UltraTabPageControl2).Name = "UltraTabPageControl2";
    ((Control) this.UltraTabPageControl2).Size = new Size(793, 246);
    this.lnkAddNewTemplateDocuments.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    this.lnkAddNewTemplateDocuments.AutoSize = true;
    this.lnkAddNewTemplateDocuments.BackColor = Color.Transparent;
    this.lnkAddNewTemplateDocuments.Location = new Point(128 /*0x80*/, 104);
    this.lnkAddNewTemplateDocuments.Name = "lnkAddNewTemplateDocuments";
    this.lnkAddNewTemplateDocuments.Size = new Size(175, 13);
    this.lnkAddNewTemplateDocuments.TabIndex = 12;
    this.lnkAddNewTemplateDocuments.TabStop = true;
    this.lnkAddNewTemplateDocuments.Text = "(Create New Template Documents)";
    this.lnkAddNewTemplateDocuments.TextAlign = ContentAlignment.MiddleLeft;
    this.lnkRemoveTemplate.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.lnkRemoveTemplate.AutoSize = true;
    this.lnkRemoveTemplate.BackColor = Color.Transparent;
    this.lnkRemoveTemplate.Location = new Point(600, 20);
    this.lnkRemoveTemplate.Name = "lnkRemoveTemplate";
    this.lnkRemoveTemplate.Size = new Size(51, 13);
    this.lnkRemoveTemplate.TabIndex = 11;
    this.lnkRemoveTemplate.TabStop = true;
    this.lnkRemoveTemplate.Text = "(remove)";
    this.lnkRemoveTemplate.TextAlign = ContentAlignment.MiddleLeft;
    this.lnkAddNewTemplate.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.lnkAddNewTemplate.AutoSize = true;
    this.lnkAddNewTemplate.BackColor = Color.Transparent;
    this.lnkAddNewTemplate.Location = new Point(488, 20);
    this.lnkAddNewTemplate.Name = "lnkAddNewTemplate";
    this.lnkAddNewTemplate.Size = new Size(101, 13);
    this.lnkAddNewTemplate.TabIndex = 10;
    this.lnkAddNewTemplate.TabStop = true;
    this.lnkAddNewTemplate.Text = "(add new template)";
    this.lnkAddNewTemplate.TextAlign = ContentAlignment.MiddleLeft;
    ((Control) this.lblTemplate).Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    appearance8.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance8).TextVAlignAsString = "Middle";
    ((ControlBase) this.lblTemplate).Appearance = (AppearanceBase) appearance8;
    ((ControlBase) this.lblTemplate).BackColorInternal = Color.Transparent;
    this.lblTemplate.BorderStyleOuter = (UIElementBorderStyle) 7;
    ((Control) this.lblTemplate).Location = new Point(128 /*0x80*/, 15);
    ((Control) this.lblTemplate).Name = "lblTemplate";
    ((Control) this.lblTemplate).Size = new Size(352, 23);
    ((Control) this.lblTemplate).TabIndex = 9;
    ((UltraControlBase) this.lblTemplate).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.lblTemplate).UseOsThemes = (DefaultableBoolean) 2;
    this.lnkRemovePDF.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.lnkRemovePDF.AutoSize = true;
    this.lnkRemovePDF.BackColor = Color.Transparent;
    this.lnkRemovePDF.Location = new Point(576, 69);
    this.lnkRemovePDF.Name = "lnkRemovePDF";
    this.lnkRemovePDF.Size = new Size(51, 13);
    this.lnkRemovePDF.TabIndex = 7;
    this.lnkRemovePDF.TabStop = true;
    this.lnkRemovePDF.Text = "(remove)";
    this.lnkRemovePDF.TextAlign = ContentAlignment.MiddleLeft;
    ((Control) this.lblPDF).Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    appearance9.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance9).TextVAlignAsString = "Middle";
    ((ControlBase) this.lblPDF).Appearance = (AppearanceBase) appearance9;
    ((ControlBase) this.lblPDF).BackColorInternal = Color.Transparent;
    this.lblPDF.BorderStyleOuter = (UIElementBorderStyle) 7;
    ((Control) this.lblPDF).Location = new Point(128 /*0x80*/, 64 /*0x40*/);
    ((Control) this.lblPDF).Name = "lblPDF";
    ((Control) this.lblPDF).Size = new Size(352, 23);
    ((Control) this.lblPDF).TabIndex = 5;
    ((UltraControlBase) this.lblPDF).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.lblPDF).UseOsThemes = (DefaultableBoolean) 2;
    this.lnkAddNewPDF.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.lnkAddNewPDF.AutoSize = true;
    this.lnkAddNewPDF.BackColor = Color.Transparent;
    this.lnkAddNewPDF.Location = new Point(488, 69);
    this.lnkAddNewPDF.Name = "lnkAddNewPDF";
    this.lnkAddNewPDF.Size = new Size(78, 13);
    this.lnkAddNewPDF.TabIndex = 6;
    this.lnkAddNewPDF.TabStop = true;
    this.lnkAddNewPDF.Text = "(add new PDF)";
    this.lnkAddNewPDF.TextAlign = ContentAlignment.MiddleLeft;
    this.Label5.AutoSize = true;
    this.Label5.BackColor = Color.Transparent;
    this.Label5.Location = new Point(22, 42);
    this.Label5.Name = "Label5";
    this.Label5.Size = new Size(102, 13);
    this.Label5.TabIndex = 2;
    this.Label5.Text = "Automation Report:";
    this.Label5.TextAlign = ContentAlignment.MiddleRight;
    ((Control) this.cboAutomationReports).Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraCombo) this.cboAutomationReports).BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.cboAutomationReports).DataBindings.Add(new Binding("Value", (object) this.ds, "tblPolicyForms.AutomationReportGuid", true));
    ((UltraGridBase) this.cboAutomationReports).DataSource = (object) this.ds.AutomationReports;
    ((UltraDropDownBase) this.cboAutomationReports).DisplayMember = "Title";
    ((UltraCombo) this.cboAutomationReports).DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboAutomationReports).Location = new Point(128 /*0x80*/, 41);
    this.cboAutomationReports.MGAStyle = (MGAStyles) 2;
    ((Control) this.cboAutomationReports).Name = "cboAutomationReports";
    ((Control) this.cboAutomationReports).Size = new Size(352, 21);
    ((Control) this.cboAutomationReports).TabIndex = 3;
    ((UltraControlBase) this.cboAutomationReports).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboAutomationReports).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboAutomationReports).ValueMember = "AutomationReportGuid";
    this.Label3.AutoSize = true;
    this.Label3.BackColor = Color.Transparent;
    this.Label3.Location = new Point(69, 18);
    this.Label3.Name = "Label3";
    this.Label3.Size = new Size(55, 13);
    this.Label3.TabIndex = 0;
    this.Label3.Text = "Template:";
    this.Label3.TextAlign = ContentAlignment.MiddleRight;
    this.Label6.AutoSize = true;
    this.Label6.BackColor = Color.Transparent;
    this.Label6.Location = new Point(96 /*0x60*/, 66);
    this.Label6.Name = "Label6";
    this.Label6.Size = new Size(30, 13);
    this.Label6.TabIndex = 4;
    this.Label6.Text = "PDF:";
    this.Label6.TextAlign = ContentAlignment.MiddleRight;
    this.daPolicyForms.DeleteCommand = this.DbDeleteCommand1;
    this.daPolicyForms.InsertCommand = this.DbInsertCommand1;
    this.daPolicyForms.SelectCommand = this.DbSelectCommand1;
    this.daPolicyForms.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblPolicyForms", new DataColumnMapping[12]
      {
        new DataColumnMapping("FormID", "FormID"),
        new DataColumnMapping("FormName", "FormName"),
        new DataColumnMapping("Description", "Description"),
        new DataColumnMapping("TemplateID", "TemplateID"),
        new DataColumnMapping("FormNumber", "FormNumber"),
        new DataColumnMapping("RequiresEndorsementNumber", "RequiresEndorsementNumber"),
        new DataColumnMapping("AutomationReportGuid", "AutomationReportGuid"),
        new DataColumnMapping("PDF_Filename", "PDF_Filename"),
        new DataColumnMapping("ParentFormID", "ParentFormID"),
        new DataColumnMapping("EditionDate", "EditionDate"),
        new DataColumnMapping("FormTypeID", "FormTypeID"),
        new DataColumnMapping("PDF", "PDF")
      })
    });
    this.daPolicyForms.UpdateCommand = this.DbUpdateCommand1;
    this.DbDeleteCommand1.CommandText = "DELETE FROM tblPolicyForms\r\nWHERE        (FormID = @Original_FormID)";
    this.DbDeleteCommand1.Parameters.AddRange((Array) new DbParameter[1]
    {
      DefaultDatabase.CreateParameter("@Original_FormID", SqlDbType.Int, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "FormID", DataRowVersion.Original, (object) null)
    });
    this.DbInsertCommand1.CommandText = componentResourceManager.GetString("DbInsertCommand1.CommandText");
    this.DbInsertCommand1.Parameters.AddRange((Array) new DbParameter[13]
    {
      DefaultDatabase.CreateParameter("@FormName", SqlDbType.VarChar, 200, "FormName"),
      DefaultDatabase.CreateParameter("@Description", SqlDbType.VarChar, 2000, "Description"),
      DefaultDatabase.CreateParameter("@TemplateID", SqlDbType.Int, 4, "TemplateID"),
      DefaultDatabase.CreateParameter("@FormNumber", SqlDbType.VarChar, 50, "FormNumber"),
      DefaultDatabase.CreateParameter("@RequiresEndorsementNumber", SqlDbType.Bit, 1, "RequiresEndorsementNumber"),
      DefaultDatabase.CreateParameter("@AutomationReportGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "AutomationReportGuid"),
      DefaultDatabase.CreateParameter("@PDF_Filename", SqlDbType.VarChar, 200, "PDF_Filename"),
      DefaultDatabase.CreateParameter("@ParentFormID", SqlDbType.Int, 4, "ParentFormID"),
      DefaultDatabase.CreateParameter("@EditionDate", SqlDbType.VarChar, 15, "EditionDate"),
      DefaultDatabase.CreateParameter("@FormTypeID", SqlDbType.Int, 4, "FormTypeID"),
      DefaultDatabase.CreateParameter("@PDF", SqlDbType.Image, int.MaxValue, "PDF"),
      DefaultDatabase.CreateParameter("@Comments", SqlDbType.VarChar, 250, "Comments"),
      DefaultDatabase.CreateParameter("@URL", SqlDbType.VarChar, 150, "URL")
    });
    this.DbSelectCommand1.CommandText = "spGetGlobalPolicyForms";
    this.DbSelectCommand1.CommandType = CommandType.StoredProcedure;
    this.DbUpdateCommand1.CommandText = componentResourceManager.GetString("DbUpdateCommand1.CommandText");
    this.DbUpdateCommand1.Parameters.AddRange((Array) new DbParameter[14]
    {
      DefaultDatabase.CreateParameter("@FormName", SqlDbType.VarChar, 200, "FormName"),
      DefaultDatabase.CreateParameter("@Description", SqlDbType.VarChar, 2000, "Description"),
      DefaultDatabase.CreateParameter("@TemplateID", SqlDbType.Int, 4, "TemplateID"),
      DefaultDatabase.CreateParameter("@FormNumber", SqlDbType.VarChar, 50, "FormNumber"),
      DefaultDatabase.CreateParameter("@RequiresEndorsementNumber", SqlDbType.Bit, 1, "RequiresEndorsementNumber"),
      DefaultDatabase.CreateParameter("@AutomationReportGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "AutomationReportGuid"),
      DefaultDatabase.CreateParameter("@PDF_Filename", SqlDbType.VarChar, 200, "PDF_Filename"),
      DefaultDatabase.CreateParameter("@ParentFormID", SqlDbType.Int, 4, "ParentFormID"),
      DefaultDatabase.CreateParameter("@EditionDate", SqlDbType.VarChar, 15, "EditionDate"),
      DefaultDatabase.CreateParameter("@FormTypeID", SqlDbType.Int, 4, "FormTypeID"),
      DefaultDatabase.CreateParameter("@PDF", SqlDbType.Image, int.MaxValue, "PDF"),
      DefaultDatabase.CreateParameter("@Comments", SqlDbType.VarChar, 250, "Comments"),
      DefaultDatabase.CreateParameter("@URL", SqlDbType.VarChar, 150, "URL"),
      DefaultDatabase.CreateParameter("@FormID", SqlDbType.Int, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "FormID", DataRowVersion.Original, (object) null)
    });
    ((Control) this.ug).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraGridBase) this.ug).DataSource = (object) this.dvForms;
    appearance10.BackColor = Color.White;
    appearance10.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.ug).DisplayLayout.Appearance = (AppearanceBase) appearance10;
    ((UltraGridBase) this.ug).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn1.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn1.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn1.Width = 43;
    ultraGridColumn2.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn2.Header).Caption = "Form";
    ((HeaderBase) ultraGridColumn2.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn2.Header.VisiblePosition = 2;
    ultraGridColumn2.Width = 285;
    ultraGridColumn3.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn3.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn3.Header.VisiblePosition = 4;
    ultraGridColumn3.Hidden = true;
    ultraGridColumn3.Width = 114;
    ultraGridColumn4.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn4.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn4.Header.VisiblePosition = 3;
    ultraGridColumn4.Hidden = true;
    ultraGridColumn4.Width = 58;
    ultraGridColumn5.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn5.Header).Caption = "Form #";
    ((HeaderBase) ultraGridColumn5.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn5.Header.VisiblePosition = 6;
    ultraGridColumn5.Width = 128 /*0x80*/;
    ultraGridColumn6.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn6.Header).Caption = "End # Req";
    ((HeaderBase) ultraGridColumn6.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn6.Header.VisiblePosition = 8;
    ultraGridColumn6.Width = 93;
    ultraGridColumn7.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn7.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn7.Header.VisiblePosition = 1;
    ultraGridColumn7.Hidden = true;
    ultraGridColumn7.Width = 183;
    ultraGridColumn8.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn8.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn8.Header.VisiblePosition = 9;
    ultraGridColumn8.Hidden = true;
    ultraGridColumn8.Width = 39;
    ultraGridColumn9.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn9.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn9.Header.VisiblePosition = 10;
    ultraGridColumn9.Hidden = true;
    ultraGridColumn9.Width = 86;
    ultraGridColumn10.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn10.Header).Caption = "Parent Form";
    ((HeaderBase) ultraGridColumn10.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn10.Header.VisiblePosition = 5;
    ultraGridColumn10.Style = (ColumnStyle) 6;
    ultraGridColumn10.Width = 287;
    ((HeaderBase) ultraGridColumn11.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn11.Header.VisiblePosition = 11;
    ultraGridColumn11.Hidden = true;
    ultraGridColumn11.Width = 87;
    ((HeaderBase) ultraGridColumn12.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn12.Header.VisiblePosition = 7;
    ultraGridColumn12.Hidden = true;
    ultraGridColumn12.Width = 70;
    ((HeaderBase) ultraGridColumn13.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn13.Header.VisiblePosition = 12;
    ultraGridColumn13.Hidden = true;
    ultraGridColumn13.Width = 101;
    ((HeaderBase) ultraGridColumn14.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn14.Header.VisiblePosition = 13;
    ultraGridColumn14.Hidden = true;
    ultraGridColumn14.Width = 89;
    ((HeaderBase) ultraGridColumn15.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn15.Header.VisiblePosition = 14;
    ultraGridColumn15.Hidden = true;
    ultraGridColumn15.Width = 63 /*0x3F*/;
    ((HeaderBase) ultraGridColumn16.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn16.Header.VisiblePosition = 15;
    ultraGridColumn16.Hidden = true;
    ultraGridColumn16.Width = 89;
    ultraGridBand1.Columns.AddRange(new object[16 /*0x10*/]
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
      (object) ultraGridColumn16
    });
    ((UltraGridBase) this.ug).DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    ((UltraGridBase) this.ug).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance11.BackColor = Color.LightSteelBlue;
    appearance11.FontData.SizeInPoints = 10f;
    appearance11.ForeColor = Color.Black;
    ((UltraGridBase) this.ug).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance11;
    appearance12.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance12.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance12.ForeColor = Color.Black;
    ((UltraGridBase) this.ug).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance12;
    ((UltraGridBase) this.ug).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.ug).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.ug).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    appearance13.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ug).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance13;
    appearance14.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.ug).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance14;
    ((UltraGridBase) this.ug).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 2;
    ((UltraGridBase) this.ug).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance15.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.ug).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance15;
    appearance16.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ug).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance16;
    ((UltraGridBase) this.ug).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance17.BackColor = Color.Transparent;
    appearance17.ForeColor = Color.Black;
    ((UltraGridBase) this.ug).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance17;
    scrollBarLook.ViewStyle = (ScrollBarViewStyle) 3;
    ((UltraGridBase) this.ug).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((Control) this.ug).Location = new Point(8, 32 /*0x20*/);
    ((Control) this.ug).Name = "ug";
    ((Control) this.ug).Size = new Size(795, 192 /*0xC0*/);
    ((Control) this.ug).TabIndex = 0;
    ((UltraControlBase) this.ug).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.ug).UseOsThemes = (DefaultableBoolean) 2;
    this.dvForms.Table = (DataTable) this.ds.tblPolicyForms;
    ((HeaderBase) ultraGridColumn17.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn17.Header.VisiblePosition = 0;
    ((HeaderBase) ultraGridColumn18.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn18.Header.VisiblePosition = 1;
    ((HeaderBase) ultraGridColumn19.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn19.Header.VisiblePosition = 2;
    ultraGridBand2.Columns.AddRange(new object[3]
    {
      (object) ultraGridColumn17,
      (object) ultraGridColumn18,
      (object) ultraGridColumn19
    });
    ((HeaderBase) ultraGridColumn20.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn20.Header.VisiblePosition = 0;
    ((HeaderBase) ultraGridColumn21.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn21.Header.VisiblePosition = 1;
    ((HeaderBase) ultraGridColumn22.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn22.Header.VisiblePosition = 2;
    ((HeaderBase) ultraGridColumn23.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn23.Header.VisiblePosition = 3;
    ((HeaderBase) ultraGridColumn24.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn24.Header.VisiblePosition = 4;
    ((HeaderBase) ultraGridColumn25.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn25.Header.VisiblePosition = 5;
    ((HeaderBase) ultraGridColumn26.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn26.Header.VisiblePosition = 6;
    ((HeaderBase) ultraGridColumn27.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn27.Header.VisiblePosition = 7;
    ((HeaderBase) ultraGridColumn28.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn28.Header.VisiblePosition = 8;
    ((HeaderBase) ultraGridColumn29.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn29.Header.VisiblePosition = 9;
    ultraGridBand3.Columns.AddRange(new object[10]
    {
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
    ((UltraGridBase) this.ddTemplates).DisplayLayout.BandsSerializer.Add((object) ultraGridBand2);
    ((UltraGridBase) this.ddTemplates).DisplayLayout.BandsSerializer.Add((object) ultraGridBand3);
    ((UltraDropDownBase) this.ddTemplates).DisplayMember = "TemplateName";
    ((Control) this.ddTemplates).Location = new Point(112 /*0x70*/, 80 /*0x50*/);
    ((Control) this.ddTemplates).Name = "ddTemplates";
    ((Control) this.ddTemplates).Size = new Size(208 /*0xD0*/, 80 /*0x50*/);
    ((Control) this.ddTemplates).TabIndex = 1;
    ((UltraDropDownBase) this.ddTemplates).ValueMember = "TemplateID";
    ((Control) this.ddTemplates).Visible = false;
    this.err.ContainerControl = (ContainerControl) this;
    ((Control) this.UltraTabControl1).Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((Control) this.UltraTabControl1).Controls.Add((Control) this.UltraTabSharedControlsPage1);
    ((Control) this.UltraTabControl1).Controls.Add((Control) this.UltraTabPageControl1);
    ((Control) this.UltraTabControl1).Controls.Add((Control) this.UltraTabPageControl2);
    ((Control) this.UltraTabControl1).Location = new Point(8, 231);
    ((Control) this.UltraTabControl1).Name = "UltraTabControl1";
    ((UltraTabControlBase) this.UltraTabControl1).SharedControls.AddRange(new Control[1]
    {
      (Control) this.dbSave
    });
    ((UltraTabControlBase) this.UltraTabControl1).SharedControlsPage = this.UltraTabSharedControlsPage1;
    ((Control) this.UltraTabControl1).Size = new Size(795, 273);
    ((Control) this.UltraTabControl1).TabIndex = 3;
    ((UltraTabControlBase) this.UltraTabControl1).TabLayoutStyle = (TabLayoutStyle) 1;
    ((UltraTabControlBase) this.UltraTabControl1).TabPadding = new Size(5, 3);
    appearance18.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance21.Image"));
    ultraTab1.Appearance = (AppearanceBase) appearance18;
    ultraTab1.TabPage = this.UltraTabPageControl1;
    ultraTab1.Text = "Form Information";
    appearance19.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance22.Image"));
    ultraTab2.Appearance = (AppearanceBase) appearance19;
    ultraTab2.TabPage = this.UltraTabPageControl2;
    ultraTab2.Text = "Associated Document";
    ((UltraTabControlBase) this.UltraTabControl1).Tabs.AddRange(new UltraTab[2]
    {
      ultraTab1,
      ultraTab2
    });
    ((UltraTabControlBase) this.UltraTabControl1).TabSize = new Size(150, 0);
    ((UltraTabControlBase) this.UltraTabControl1).ViewStyle = (ViewStyle) 4;
    ((Control) this.UltraTabSharedControlsPage1).Controls.Add((Control) this.dbSave);
    ((Control) this.UltraTabSharedControlsPage1).Location = new Point(-10000, -10000);
    ((Control) this.UltraTabSharedControlsPage1).Name = "UltraTabSharedControlsPage1";
    ((Control) this.UltraTabSharedControlsPage1).Size = new Size(793, 246);
    ((Control) this.AlphabetBar1).Location = new Point(8, 8);
    ((Control) this.AlphabetBar1).Name = "AlphabetBar1";
    ((Control) this.AlphabetBar1).Size = new Size(424, 16 /*0x10*/);
    ((Control) this.AlphabetBar1).TabIndex = 8;
    this.Label8.AutoSize = true;
    this.Label8.Location = new Point(484, 11);
    this.Label8.Name = "Label8";
    this.Label8.Size = new Size(46, 13);
    this.Label8.TabIndex = 9;
    this.Label8.Text = "Form #:";
    appearance20.BackColor = Color.White;
    appearance20.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance20.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtFormNumberFilter).Appearance = (AppearanceBase) appearance20;
    ((TextEditorControlBase) this.txtFormNumberFilter).BackColor = Color.White;
    ((Control) this.txtFormNumberFilter).Location = new Point(536, 7);
    this.txtFormNumberFilter.MGAStyle = (MGAStyles) 2;
    ((Control) this.txtFormNumberFilter).Name = "txtFormNumberFilter";
    ((Control) this.txtFormNumberFilter).Size = new Size(96 /*0x60*/, 20);
    ((Control) this.txtFormNumberFilter).TabIndex = 10;
    ((UltraControlBase) this.txtFormNumberFilter).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtFormNumberFilter).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.panelLoading).Anchor = AnchorStyles.None;
    appearance21.BackColor = Color.FromArgb(240 /*0xF0*/, 247, 253);
    appearance21.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.panelLoading.ContentAreaAppearance = (AppearanceBase) appearance21;
    ((Control) this.panelLoading).Controls.Add((Control) this.progress);
    ((Control) this.panelLoading).Controls.Add((Control) this.Label9);
    ((Control) this.panelLoading).Location = new Point(224 /*0xE0*/, 71);
    ((Control) this.panelLoading).Name = "panelLoading";
    ((Control) this.panelLoading).Size = new Size(360, 100);
    ((Control) this.panelLoading).TabIndex = 11;
    ((Control) this.progress).Location = new Point(16 /*0x10*/, 64 /*0x40*/);
    ((Control) this.progress).Name = "progress";
    ((Control) this.progress).Size = new Size(336, 16 /*0x10*/);
    ((Control) this.progress).TabIndex = 12;
    this.progress.Text = "[Formatted]";
    this.Label9.AutoSize = true;
    this.Label9.BackColor = Color.Transparent;
    this.Label9.Font = new Font("Tahoma", 12f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label9.Location = new Point(91, 24);
    this.Label9.Name = "Label9";
    this.Label9.Size = new Size(178, 19);
    this.Label9.TabIndex = 11;
    this.Label9.Text = "Loading... please wait...";
    this.Label9.TextAlign = ContentAlignment.MiddleRight;
    this.lnkNumber.AutoSize = true;
    this.lnkNumber.Location = new Point(432, 8);
    this.lnkNumber.Name = "lnkNumber";
    this.lnkNumber.Size = new Size(15, 13);
    this.lnkNumber.TabIndex = 12;
    this.lnkNumber.TabStop = true;
    this.lnkNumber.Text = "#";
    this.lnkAll.AutoSize = true;
    this.lnkAll.Location = new Point(448, 8);
    this.lnkAll.Name = "lnkAll";
    this.lnkAll.Size = new Size(18, 13);
    this.lnkAll.TabIndex = 13;
    this.lnkAll.TabStop = true;
    this.lnkAll.Text = "All";
    ((UltraGridBase) this.ddParentForms).DataSource = (object) this.ds.tblPolicyForms;
    ultraGridColumn30.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn30.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn30.Header.VisiblePosition = 0;
    ultraGridColumn30.Hidden = true;
    ultraGridColumn31.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn31.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn31.Header.VisiblePosition = 1;
    ultraGridColumn32.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn32.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn32.Header.VisiblePosition = 2;
    ultraGridColumn33.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn33.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn33.Header.VisiblePosition = 3;
    ultraGridColumn33.Hidden = true;
    ultraGridColumn34.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn34.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn34.Header.VisiblePosition = 4;
    ultraGridColumn34.Hidden = true;
    ultraGridColumn35.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn35.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn35.Header.VisiblePosition = 5;
    ultraGridColumn35.Hidden = true;
    ultraGridColumn36.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn36.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn36.Header.VisiblePosition = 6;
    ultraGridColumn36.Hidden = true;
    ultraGridColumn37.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn37.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn37.Header.VisiblePosition = 7;
    ultraGridColumn37.Hidden = true;
    ultraGridColumn38.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn38.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn38.Header.VisiblePosition = 8;
    ultraGridColumn38.Hidden = true;
    ultraGridColumn39.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn39.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn39.Header.VisiblePosition = 9;
    ultraGridColumn39.Hidden = true;
    ((HeaderBase) ultraGridColumn40.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn40.Header.VisiblePosition = 10;
    ((HeaderBase) ultraGridColumn41.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn41.Header.VisiblePosition = 11;
    ((HeaderBase) ultraGridColumn42.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn42.Header.VisiblePosition = 12;
    ((HeaderBase) ultraGridColumn43.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn43.Header.VisiblePosition = 13;
    ((HeaderBase) ultraGridColumn44.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn44.Header.VisiblePosition = 14;
    ((HeaderBase) ultraGridColumn45.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn45.Header.VisiblePosition = 15;
    ultraGridBand4.Columns.AddRange(new object[16 /*0x10*/]
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
      (object) ultraGridColumn45
    });
    ((UltraGridBase) this.ddParentForms).DisplayLayout.BandsSerializer.Add((object) ultraGridBand4);
    ((UltraDropDownBase) this.ddParentForms).DisplayMember = "FormName";
    ((Control) this.ddParentForms).Location = new Point(48 /*0x30*/, 168);
    ((Control) this.ddParentForms).Name = "ddParentForms";
    ((Control) this.ddParentForms).Size = new Size(232, 48 /*0x30*/);
    ((Control) this.ddParentForms).TabIndex = 4;
    ((Control) this.ddParentForms).Text = "UltraDropDown2";
    ((UltraDropDownBase) this.ddParentForms).ValueMember = "FormID";
    ((Control) this.ddParentForms).Visible = false;
    ((UltraGridBase) this.UltraDropDown1).DataSource = (object) this.ds.AutomationReports;
    ultraGridColumn46.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn46.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn46.Header.VisiblePosition = 0;
    ultraGridColumn47.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn47.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn47.Header.VisiblePosition = 1;
    ultraGridColumn48.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn48.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn48.Header.VisiblePosition = 2;
    ultraGridBand5.Columns.AddRange(new object[3]
    {
      (object) ultraGridColumn46,
      (object) ultraGridColumn47,
      (object) ultraGridColumn48
    });
    ultraGridColumn49.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn49.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn49.Header.VisiblePosition = 0;
    ultraGridColumn50.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn50.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn50.Header.VisiblePosition = 1;
    ultraGridColumn51.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn51.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn51.Header.VisiblePosition = 2;
    ultraGridColumn52.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn52.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn52.Header.VisiblePosition = 3;
    ultraGridColumn53.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn53.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn53.Header.VisiblePosition = 4;
    ultraGridColumn54.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn54.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn54.Header.VisiblePosition = 5;
    ultraGridColumn55.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn55.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn55.Header.VisiblePosition = 6;
    ultraGridColumn56.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn56.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn56.Header.VisiblePosition = 7;
    ultraGridColumn57.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn57.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn57.Header.VisiblePosition = 8;
    ultraGridColumn58.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn58.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn58.Header.VisiblePosition = 9;
    ((HeaderBase) ultraGridColumn59.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn59.Header.VisiblePosition = 10;
    ((HeaderBase) ultraGridColumn60.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn60.Header.VisiblePosition = 11;
    ((HeaderBase) ultraGridColumn61.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn61.Header.VisiblePosition = 12;
    ((HeaderBase) ultraGridColumn62.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn62.Header.VisiblePosition = 13;
    ((HeaderBase) ultraGridColumn63.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn63.Header.VisiblePosition = 14;
    ((HeaderBase) ultraGridColumn64.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn64.Header.VisiblePosition = 15;
    ultraGridBand6.Columns.AddRange(new object[16 /*0x10*/]
    {
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
      (object) ultraGridColumn64
    });
    ((UltraGridBase) this.UltraDropDown1).DisplayLayout.BandsSerializer.Add((object) ultraGridBand5);
    ((UltraGridBase) this.UltraDropDown1).DisplayLayout.BandsSerializer.Add((object) ultraGridBand6);
    ((UltraDropDownBase) this.UltraDropDown1).DisplayMember = "Title";
    ((Control) this.UltraDropDown1).Location = new Point(376, 144 /*0x90*/);
    ((Control) this.UltraDropDown1).Name = "UltraDropDown1";
    ((Control) this.UltraDropDown1).Size = new Size(248, 64 /*0x40*/);
    ((Control) this.UltraDropDown1).TabIndex = 2;
    ((UltraDropDownBase) this.UltraDropDown1).ValueMember = "AutomationReportGuid";
    ((Control) this.UltraDropDown1).Visible = false;
    ((UltraGridBase) this.ddFormType).DataMember = "lstFormTypes";
    ((UltraGridBase) this.ddFormType).DataSource = (object) this.ds;
    ((HeaderBase) ultraGridColumn65.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn65.Header.VisiblePosition = 1;
    ultraGridColumn65.Hidden = true;
    ((HeaderBase) ultraGridColumn66.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn66.Header.VisiblePosition = 0;
    ultraGridColumn66.Width = 260;
    ((HeaderBase) ultraGridColumn67.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn67.Header.VisiblePosition = 2;
    ultraGridBand7.Columns.AddRange(new object[3]
    {
      (object) ultraGridColumn65,
      (object) ultraGridColumn66,
      (object) ultraGridColumn67
    });
    ((HeaderBase) ultraGridColumn68.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn68.Header.VisiblePosition = 0;
    ((HeaderBase) ultraGridColumn69.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn69.Header.VisiblePosition = 1;
    ((HeaderBase) ultraGridColumn70.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn70.Header.VisiblePosition = 2;
    ((HeaderBase) ultraGridColumn71.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn71.Header.VisiblePosition = 3;
    ((HeaderBase) ultraGridColumn72.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn72.Header.VisiblePosition = 4;
    ((HeaderBase) ultraGridColumn73.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn73.Header.VisiblePosition = 5;
    ((HeaderBase) ultraGridColumn74.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn74.Header.VisiblePosition = 6;
    ((HeaderBase) ultraGridColumn75.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn75.Header.VisiblePosition = 7;
    ((HeaderBase) ultraGridColumn76.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn76.Header.VisiblePosition = 8;
    ((HeaderBase) ultraGridColumn77.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn77.Header.VisiblePosition = 9;
    ((HeaderBase) ultraGridColumn78.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn78.Header.VisiblePosition = 10;
    ((HeaderBase) ultraGridColumn79.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn79.Header.VisiblePosition = 11;
    ((HeaderBase) ultraGridColumn80.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn80.Header.VisiblePosition = 12;
    ((HeaderBase) ultraGridColumn81.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn81.Header.VisiblePosition = 13;
    ((HeaderBase) ultraGridColumn82.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn82.Header.VisiblePosition = 14;
    ((HeaderBase) ultraGridColumn83.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn83.Header.VisiblePosition = 15;
    ultraGridBand8.Columns.AddRange(new object[16 /*0x10*/]
    {
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
      (object) ultraGridColumn79,
      (object) ultraGridColumn80,
      (object) ultraGridColumn81,
      (object) ultraGridColumn82,
      (object) ultraGridColumn83
    });
    ((UltraGridBase) this.ddFormType).DisplayLayout.BandsSerializer.Add((object) ultraGridBand7);
    ((UltraGridBase) this.ddFormType).DisplayLayout.BandsSerializer.Add((object) ultraGridBand8);
    ((UltraDropDownBase) this.ddFormType).DisplayMember = "FormType";
    ((Control) this.ddFormType).Location = new Point(505, 93);
    ((Control) this.ddFormType).Name = "ddFormType";
    ((Control) this.ddFormType).Size = new Size(248, 64 /*0x40*/);
    ((Control) this.ddFormType).TabIndex = 14;
    ((UltraDropDownBase) this.ddFormType).ValueMember = "FormTypeID";
    ((Control) this.ddFormType).Visible = false;
    this.lblFormTypeFilter.AutoSize = true;
    this.lblFormTypeFilter.Location = new Point(646, 11);
    this.lblFormTypeFilter.Name = "lblFormTypeFilter";
    this.lblFormTypeFilter.Size = new Size(62, 13);
    this.lblFormTypeFilter.TabIndex = 15;
    this.lblFormTypeFilter.Text = "Form Type:";
    appearance22.BackColor = Color.White;
    appearance22.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance22.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtFormTypeFilter).Appearance = (AppearanceBase) appearance22;
    ((TextEditorControlBase) this.txtFormTypeFilter).BackColor = Color.White;
    ((Control) this.txtFormTypeFilter).Location = new Point(714, 7);
    this.txtFormTypeFilter.MGAStyle = (MGAStyles) 2;
    ((Control) this.txtFormTypeFilter).Name = "txtFormTypeFilter";
    ((Control) this.txtFormTypeFilter).Size = new Size(89, 20);
    ((Control) this.txtFormTypeFilter).TabIndex = 16 /*0x10*/;
    ((UltraControlBase) this.txtFormTypeFilter).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtFormTypeFilter).UseOsThemes = (DefaultableBoolean) 2;
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.White;
    this.ClientSize = new Size(811, 510);
    this.Controls.Add((Control) this.lblFormTypeFilter);
    this.Controls.Add((Control) this.txtFormTypeFilter);
    this.Controls.Add((Control) this.ddFormType);
    this.Controls.Add((Control) this.lnkAll);
    this.Controls.Add((Control) this.lnkNumber);
    this.Controls.Add((Control) this.Label8);
    this.Controls.Add((Control) this.panelLoading);
    this.Controls.Add((Control) this.txtFormNumberFilter);
    this.Controls.Add((Control) this.AlphabetBar1);
    this.Controls.Add((Control) this.ddParentForms);
    this.Controls.Add((Control) this.UltraTabControl1);
    this.Controls.Add((Control) this.UltraDropDown1);
    this.Controls.Add((Control) this.ddTemplates);
    this.Controls.Add((Control) this.ug);
    this.DoubleBuffered = true;
    this.Font = new Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.ForeColor = Color.Black;
    this.Name = nameof (frmPolicyForms);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Policy Forms";
    ((Control) this.UltraTabPageControl1).ResumeLayout(false);
    ((Control) this.UltraTabPageControl1).PerformLayout();
    ((ISupportInitialize) this.txtURL).EndInit();
    ((ISupportInitialize) this.txtComments).EndInit();
    ((ISupportInitialize) this.MgaCmbFormType).EndInit();
    this.ds.EndInit();
    ((ISupportInitialize) this.txtEditionDate).EndInit();
    ((ISupportInitialize) this.cboParentForms).EndInit();
    ((ISupportInitialize) this.txtDescription).EndInit();
    ((ISupportInitialize) this.txtFormNumber).EndInit();
    ((ISupportInitialize) this.txtFormName).EndInit();
    ((ISupportInitialize) this.chkRequiresEndorsementNumber).EndInit();
    ((Control) this.UltraTabPageControl2).ResumeLayout(false);
    ((Control) this.UltraTabPageControl2).PerformLayout();
    ((ISupportInitialize) this.cboAutomationReports).EndInit();
    ((ISupportInitialize) this.ug).EndInit();
    this.dvForms.EndInit();
    ((ISupportInitialize) this.ddTemplates).EndInit();
    ((ISupportInitialize) this.err).EndInit();
    ((ISupportInitialize) this.UltraTabControl1).EndInit();
    ((Control) this.UltraTabControl1).ResumeLayout(false);
    ((Control) this.UltraTabSharedControlsPage1).ResumeLayout(false);
    ((ISupportInitialize) this.txtFormNumberFilter).EndInit();
    ((ISupportInitialize) this.panelLoading).EndInit();
    ((Control) this.panelLoading).ResumeLayout(false);
    ((Control) this.panelLoading).PerformLayout();
    ((ISupportInitialize) this.ddParentForms).EndInit();
    ((ISupportInitialize) this.UltraDropDown1).EndInit();
    ((ISupportInitialize) this.ddFormType).EndInit();
    ((ISupportInitialize) this.txtFormTypeFilter).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  public frmPolicyForms()
  {
    this.Load += new EventHandler(this.frmPolicyForms_Load);
    this.Closing += new CancelEventHandler(this.frmPolicyForms_Closing);
    this._filterLetter = "A";
    this._filters = new List<string>();
    this.InitializeComponent();
    ((Control) this.dbSave).Enabled = false;
    this.SetControlsEnabled(false);
  }

  private virtual frmDocumentTemplates _frmDocTemplates
  {
    get => this.__frmDocTemplates;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      frmDocumentTemplates.DocTemplateSelectedEventHandler selectedEventHandler = new frmDocumentTemplates.DocTemplateSelectedEventHandler(this._frmDocTemplates_DocTemplateSelected);
      frmDocumentTemplates.DocTemplateClosedEventHandler closedEventHandler = new frmDocumentTemplates.DocTemplateClosedEventHandler(this._frmDocTemplates_DocTemplateClosed);
      frmDocumentTemplates frmDocTemplates1 = this.__frmDocTemplates;
      if (frmDocTemplates1 != null)
      {
        frmDocTemplates1.DocTemplateSelected -= selectedEventHandler;
        frmDocTemplates1.DocTemplateClosed -= closedEventHandler;
      }
      this.__frmDocTemplates = value;
      frmDocumentTemplates frmDocTemplates2 = this.__frmDocTemplates;
      if (frmDocTemplates2 == null)
        return;
      frmDocTemplates2.DocTemplateSelected += selectedEventHandler;
      frmDocTemplates2.DocTemplateClosed += closedEventHandler;
    }
  }

  private void frmPolicyForms_Load(object sender, EventArgs e)
  {
    if (this.DesignMode)
      return;
    Utility.SetDataAdapterConnections(this.daPolicyForms, DefaultDatabase.CreateDbConnection(), (DbTransaction) null);
    this._dRow = this.ds.tblPolicyForms.NewtblPolicyFormsRow();
    this.SetFilters();
    ((UltraGridBase) this.MgaCmbFormType).DataSource = (object) this.ds.lstFormTypes;
    ((UltraGridBase) this.ddFormType).DataSource = (object) this.ds;
    ((UltraGridBase) this.ddFormType).DataMember = "lstFormTypes";
    ((UltraDropDownBase) this.ddFormType).DisplayMember = "FormType";
    ((UltraDropDownBase) this.ddFormType).ValueMember = "FormTypeID";
    UltraGridColumn column = ((UltraGridBase) this.ug).DisplayLayout.Bands[0].Columns["FormTypeID"];
    column.Style = (ColumnStyle) 6;
    column.ValueList = (IValueList) this.ddFormType;
    ((HeaderBase) column.Header).Caption = "Form Type";
    column.Hidden = false;
    this.ds.EnforceConstraints = false;
    this.ds.tblPolicyForms.BeginLoadData();
    ThreadPool.QueueUserWorkItem(new WaitCallback(this.GetAutomationReports));
    DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[1]
    {
      this.ds.lstFormTypes.TableName
    }, "sp_GetPolicyFormTypes");
    this.LoadPlugin();
  }

  private void LoadPlugin()
  {
    Type[] typeArray = ObjectFactory.Instance.QueryTypesWithAttribute((Attribute) new frmPolicyForms_ClientOverridePluginAttribute());
    int index1 = 0;
    while (index1 < typeArray.Length)
    {
      Type type = typeArray[index1];
      object[] customAttributes = type.GetCustomAttributes(false);
      int index2 = 0;
      frmPolicyForms_ClientOverridePlugin objectTypeAs;
      if (index2 < customAttributes.Length && (Attribute) customAttributes[index2] is frmPolicyForms_ClientOverridePluginAttribute)
        objectTypeAs = ObjectFactory.Instance.CreateObjectTypeAs<frmPolicyForms_ClientOverridePlugin>(type, new object[0]);
      if (objectTypeAs != null)
      {
        ((Control) this.UltraTabControl1).Controls.Add((Control) objectTypeAs);
        ((UltraTabControlBase) this.UltraTabControl1).SelectedTab = ((UltraTabControlBase) this.UltraTabControl1).Tabs[0];
        ((UltraTabControlBase) this.UltraTabControl1).Tabs[((UltraTabControlBase) this.UltraTabControl1).Tabs.Count - 1].Text = objectTypeAs.GetTabName();
        break;
      }
      checked { ++index1; }
    }
  }

  private void SetProgressMax(int max)
  {
    if (MDIControls.Instance.MDIParent.InvokeRequired)
      MDIControls.Instance.MDIParent.Invoke((Delegate) new frmPolicyForms.SetProgressMaxHandler(this.SetProgressMax), (object) max);
    else
      this.progress.Maximum = max;
  }

  private void MoveProgress()
  {
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

  private void ThreadedFill()
  {
    this.SetProgressMax(DefaultDatabase.ExecuteScalar<int>(CommandType.Text, "SELECT COUNT(1) FROM dbo.tblPolicyForms WITH(NOLOCK)"));
    DefaultDatabase.ExecuteReader((EventHandler<ExecuteReaderArgs>) ([SpecialName] (s, rea) =>
    {
      try
      {
        while (rea.Reader.Read())
        {
          dsPolicyForms.tblPolicyFormsRow dr = this.ds.tblPolicyForms.NewtblPolicyFormsRow();
          int num = rea.Reader.FieldCount - 1;
          for (int i = 0; i <= num; ++i)
            dr[rea.Reader.GetName(i)] = RuntimeHelpers.GetObjectValue(rea.Reader.GetValue(i));
          Match match = Regex.Match(dr.FormName, "[a-zA-Z0-9]");
          dsPolicyForms.tblPolicyFormsRow tblPolicyFormsRow = dr;
          CaptureCollection captures = match.Captures;
          string str = Regex.Replace((captures != null ? captures.OfType<System.Text.RegularExpressions.Capture>().FirstOrDefault<System.Text.RegularExpressions.Capture>()?.Value : (string) null) ?? "A", "\\d", "#");
          tblPolicyFormsRow.FilterCharacter = str;
          this.AddRow(dr);
          this.MoveProgress();
        }
      }
      finally
      {
        if (rea.Reader != null && !rea.Reader.IsClosed)
          rea.Reader.Close();
      }
    }), CommandType.Text, this.daPolicyForms.SelectCommand.CommandText, (object[]) null);
    if (this.IsDisposed || this.Disposing || !this.IsHandleCreated)
      return;
    InvokeExtensions.BetterInvoke((ISynchronizeInvoke) MDIControls.Instance.MDIParent, (Delegate) new MethodInvoker(this.LoadComplete), new object[0]);
  }

  private void AddRow(dsPolicyForms.tblPolicyFormsRow dr)
  {
    if (MDIControls.Instance.MDIParent.InvokeRequired)
      MDIControls.Instance.MDIParent.Invoke((Delegate) new frmPolicyForms.AddRowHandler(this.AddRow), (object) dr);
    else
      this.ds.tblPolicyForms.AddtblPolicyFormsRow(dr);
  }

  private void LoadComplete()
  {
    this.ds.tblPolicyForms.EndLoadData();
    StringBuilder stringBuilder = new StringBuilder("The following forms are associated with automation reports that could not be located.\n\n");
    stringBuilder.AppendLine("This can occur when a customization DLL containing these reports was not found or failed to load.\n");
    bool flag;
    for (int index = this.ds.tblPolicyForms.Count - 1; index >= 0; index += -1)
    {
      dsPolicyForms.tblPolicyFormsRow tblPolicyForm = this.ds.tblPolicyForms[index];
      if (!tblPolicyForm.IsAutomationReportGuidNull() && this.ds.AutomationReports.FindByAutomationReportGuid(tblPolicyForm.AutomationReportGuid) == null)
      {
        stringBuilder.AppendLine(tblPolicyForm.FormName);
        flag = true;
        this.ds.tblPolicyForms.RemovetblPolicyFormsRow(tblPolicyForm);
      }
    }
    if (flag)
    {
      int num = (int) MessageBox.Show(stringBuilder.ToString(), "Missing Reports", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
    try
    {
      this.ds.EnforceConstraints = true;
    }
    catch (ConstraintException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      ErrorHandler.ShowDataSetErrors((DataSet) this.ds, ex);
      ProjectData.ClearProjectError();
    }
    this.ds.AcceptChanges();
    this.ds.AutomationReports.DefaultView.Sort = "Title";
    ((UltraGridBase) this.cboParentForms).DataSource = (object) this.ds.tblPolicyForms;
    ((Control) this.panelLoading).Visible = false;
    ((Control) this.dbSave).Enabled = true;
  }

  private void lnkAll_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    this._filterLetter = "";
    this.SetFilters();
  }

  private void SetFilters()
  {
    Cursor.Current = MgaCursors.WaitCursor;
    this._filters.Clear();
    if (!string.IsNullOrEmpty(this._filterLetter))
      this._filters.Add($"FilterCharacter = '{this._filterLetter}'");
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((TextEditorControlBase) this.txtFormNumberFilter).Text, string.Empty, false) != 0)
      this._filters.Add($"FormNumber LIKE '%{((TextEditorControlBase) this.txtFormNumberFilter).Text.Replace("'", "''")}%'");
    this.dvForms.RowFilter = string.Join(" AND ", (IEnumerable<string>) this._filters);
    Cursor.Current = MgaCursors.Default;
  }

  private void txtFormNumberFilter_ValueChanged(object sender, EventArgs e) => this.SetFilters();

  private void AddAutomationReport(Guid reportGuid, string title)
  {
    if (MDIControls.Instance.MDIParent.InvokeRequired)
      MDIControls.Instance.MDIParent.Invoke((Delegate) new frmPolicyForms.AddAutomationReportHandler(this.AddAutomationReport), (object) reportGuid, (object) title);
    else
      this.ds.AutomationReports.AddAutomationReportsRow(reportGuid, title);
  }

  private void GetAutomationReports(object state)
  {
    Thread.Sleep(1000);
    this.AddAutomationReport(Guid.Empty, string.Empty);
    Type[] typeArray = ObjectFactory.Instance.QueryTypesWithAttribute((Attribute) new AutomationReportAttribute());
    int index1 = 0;
    while (index1 < typeArray.Length)
    {
      object[] customAttributes = typeArray[index1].GetCustomAttributes(false);
      int index2 = 0;
      while (index2 < customAttributes.Length)
      {
        if (RuntimeHelpers.GetObjectValue(customAttributes[index2]) is AutomationReportAttribute objectValue)
          this.AddAutomationReport(objectValue.AutomationReportGuid, objectValue.Title);
        checked { ++index2; }
      }
      checked { ++index1; }
    }
    DataTable dataTable = DefaultDatabase.ExecuteDataTable("GetAdHocAutomationDocuments");
    try
    {
      foreach (DataRow row in dataTable.Rows)
        this.AddAutomationReport(new Guid(row["AutomationReportGuid"].ToString()), row["Title"].ToString());
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    this.ThreadedFill();
  }

  private void AlphabetBar1_LetterClicked(object sender, LetterClickedEventArgs e)
  {
    this._filterLetter = e.Letter;
    this.SetFilters();
    this.EvaluateGrid();
  }

  private void lnkAddNewPDF_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    using (OpenFileDialog openFileDialog1 = new OpenFileDialog())
    {
      OpenFileDialog openFileDialog2 = openFileDialog1;
      openFileDialog2.CheckFileExists = true;
      openFileDialog2.CheckPathExists = true;
      openFileDialog2.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
      openFileDialog2.Multiselect = false;
      openFileDialog2.ReadOnlyChecked = true;
      openFileDialog2.ShowReadOnly = true;
      openFileDialog2.DefaultExt = ".pdf";
      openFileDialog2.Filter = "PDF Document (*.pdf)|*.pdf";
      if (openFileDialog1.ShowDialog((IWin32Window) MDIControls.Instance.MDIParent) == DialogResult.Cancel)
        return;
      if (SystemSettings.KeyExists("MaxPDFFileSize") && Decimal.Compare(new Decimal(new FileInfo(openFileDialog1.FileName).Length), SystemSettings.GetNumericSetting("MaxPDFFileSize")) > 0)
      {
        if (SecurityManager.Instance.AssertPermission("{144A29E6-6D80-4e66-93B7-82FD8AED41DA}"))
        {
          if (MessageBox.Show("File size is over the maximum limit allowed.\n\nAre you sure you want to save this file?", "File Over Max Limit", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
            return;
        }
        else
        {
          int num = (int) MessageBox.Show("Document cannot be uploaded because it is over the maximum size limit.\n\nPlease contact your system administrator for further assistance.", "Cannot Upload File", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return;
        }
      }
      FileStream fileStream = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
      byte[] array = new byte[(int) (fileStream.Length - 1L) + 1];
      try
      {
        fileStream.Read(array, 0, (int) fileStream.Length);
      }
      finally
      {
        fileStream.Close();
      }
      if (array.Length == 0)
      {
        int num1 = (int) MessageBox.Show($"IMS is unable to save file:{openFileDialog1.FileName} - It contains no data.", "Unable to Save File", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      }
      else
      {
        dsPolicyForms.tblPolicyFormsRow dRow = this._dRow;
        dRow.PDF = array;
        dRow.PDF_Filename = Path.GetFileName(openFileDialog1.FileName);
        ((ControlBase) this.lblPDF).Text = this._dRow.Field<string>("PDF_Filename");
      }
    }
  }

  private void lnkRemovePDF_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    this._dRow.SetPDF_FilenameNull();
    this._dRow.SetPDFNull();
    this.err.SetError((Control) this.lblPDF, string.Empty);
    ((ControlBase) this.lblPDF).Text = string.Empty;
  }

  private void dbSave_ClickedNew(object sender, EventArgs e)
  {
    this._dRow = this.ds.tblPolicyForms.NewtblPolicyFormsRow();
    this.ds.tblPolicyForms.AddtblPolicyFormsRow(this._dRow);
    ((ControlBase) this.lblTemplate).Text = string.Empty;
    ((Control) this.lblTemplate).Tag = (object) null;
    ((ControlBase) this.lblPDF).Text = string.Empty;
    ((TextEditorControlBase) this.txtFormName).Text = string.Empty;
    ((TextEditorControlBase) this.txtFormNumber).Text = string.Empty;
    ((UltraCombo) this.cboParentForms).Value = (object) -1;
    ((TextEditorControlBase) this.txtDescription).Text = string.Empty;
    ((UltraCombo) this.cboParentForms).Value = (object) -1;
    ((UltraCombo) this.cboAutomationReports).Value = (object) Guid.Empty;
    ((TextEditorControlBase) this.txtEditionDate).Text = string.Empty;
    ((UltraCombo) this.MgaCmbFormType).Value = (object) -1;
    ((TextEditorControlBase) this.txtComments).Text = string.Empty;
    ((TextEditorControlBase) this.txtURL).Text = string.Empty;
  }

  private void ug_AfterRowActivate(object sender, EventArgs e)
  {
    this._formID = (int) ((UltraGridBase) this.ug).ActiveRow.Cells["FormID"].Value;
    this._dRow = this.ds.tblPolicyForms.FindByFormID(this._formID);
    try
    {
      UltraTabControl ultraTabControl1 = this.UltraTabControl1;
      foreach (frmPolicyForms_ClientOverridePlugin clientOverridePlugin in ultraTabControl1 != null ? ((Control) ultraTabControl1).Controls.OfType<frmPolicyForms_ClientOverridePlugin>() : (IEnumerable<frmPolicyForms_ClientOverridePlugin>) null)
        clientOverridePlugin?.Fill(this._formID);
    }
    finally
    {
      IEnumerator<frmPolicyForms_ClientOverridePlugin> enumerator;
      enumerator?.Dispose();
    }
    if (!this._dRow.IsPDF_FilenameNull() && this._dRow.IsPDFNull())
      this._dRow.PDF = DefaultDatabase.ExecuteScalar<byte[]>(CommandType.Text, "SELECT PDF FROM tblPolicyForms WHERE FormID = @formid", new object[2]
      {
        (object) "@formid",
        (object) this._formID
      });
    ((TextEditorControlBase) this.txtFormName).Text = ((UltraGridBase) this.ug).ActiveRow.Cells["FormName"].Text;
    if (((UltraGridBase) this.ug).ActiveRow.Cells["ParentFormID"].Value != DBNull.Value)
      ((UltraCombo) this.cboParentForms).Value = (object) (int) ((UltraGridBase) this.ug).ActiveRow.Cells["ParentFormID"].Value;
    else
      ((UltraCombo) this.cboParentForms).Value = (object) -1;
    if (((UltraGridBase) this.ug).ActiveRow.Cells["FormTypeID"].Value != DBNull.Value)
      ((UltraCombo) this.MgaCmbFormType).Value = (object) (int) ((UltraGridBase) this.ug).ActiveRow.Cells["FormTypeID"].Value;
    else
      ((UltraCombo) this.MgaCmbFormType).Value = (object) -1;
    if (((UltraGridBase) this.ug).ActiveRow.Cells["AutomationReportGuid"].Value != DBNull.Value)
      ((UltraCombo) this.cboAutomationReports).Value = (object) (Guid) ((UltraGridBase) this.ug).ActiveRow.Cells["AutomationReportGuid"].Value;
    else
      ((UltraCombo) this.cboAutomationReports).Value = (object) Guid.Empty;
    ((UltraToggleEditorBase) this.chkRequiresEndorsementNumber).Checked = (bool) ((UltraGridBase) this.ug).ActiveRow.Cells["RequiresEndorsementNumber"].Value;
    ((TextEditorControlBase) this.txtFormNumber).Text = ((UltraGridBase) this.ug).ActiveRow.Cells["FormNumber"].Text;
    ((TextEditorControlBase) this.txtDescription).Text = ((UltraGridBase) this.ug).ActiveRow.Cells["Description"].Text;
    ((TextEditorControlBase) this.txtComments).Text = ((UltraGridBase) this.ug).ActiveRow.Cells["Comments"].Text;
    if (((UltraGridBase) this.ug).ActiveRow.Cells["TemplateID"].Value != DBNull.Value)
    {
      dsPolicyForms.tblDocumentTemplatesRow templateRow = this.GetTemplateRow((int) ((UltraGridBase) this.ug).ActiveRow.Cells["TemplateID"].Value);
      ((Control) this.lblTemplate).Tag = (object) templateRow.TemplateID;
      ((ControlBase) this.lblTemplate).Text = templateRow.TemplateDescription;
    }
    else
    {
      ((Control) this.lblTemplate).Tag = (object) null;
      ((ControlBase) this.lblTemplate).Text = string.Empty;
      this._dRow.SetRequiresEditNull();
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((UltraGridBase) this.ug).ActiveRow.Cells["PDF_Filename"].Text, string.Empty, false) != 0)
    {
      ((ControlBase) this.lblPDF).Text = ((UltraGridBase) this.ug).ActiveRow.Cells["PDF_Filename"].Text;
    }
    else
    {
      ((ControlBase) this.lblPDF).Text = string.Empty;
      ((Control) this.lblPDF).Tag = (object) null;
    }
    if (((UltraGridBase) this.ug).ActiveRow.Cells["EditionDate"].Value != DBNull.Value && ((UltraGridBase) this.ug).ActiveRow.Cells["EditionDate"].Value != null)
      ((TextEditorControlBase) this.txtEditionDate).Text = ((UltraGridBase) this.ug).ActiveRow.Cells["EditionDate"].Value.ToString();
    else
      ((TextEditorControlBase) this.txtEditionDate).Text = string.Empty;
    if (!Utility.IsNull((object) ((UltraGridBase) this.ug).ActiveRow.Cells["URL"].Text))
      ((TextEditorControlBase) this.txtURL).Text = ((UltraGridBase) this.ug).ActiveRow.Cells["URL"].Text;
    else
      ((TextEditorControlBase) this.txtURL).Text = string.Empty;
    if (this.dbSave.UIState != 2)
      this.dbSave.UIState = (UIState) 1;
    this._dRow.AcceptChanges();
  }

  private void dbSave_ClickingDelete(object sender, CancelEventArgs e)
  {
    if (MessageBox.Show("Are you sure you want to delete this form?", "Delete Form?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.Yes)
      return;
    try
    {
      foreach (DataRow row in this.ds.tblPolicyForms.Rows)
      {
        if ((int) row["FormID"] == this._formID)
        {
          row.Delete();
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
    try
    {
      Cursor.Current = MgaCursors.WaitCursor;
      DefaultDatabase.DataAdapterUpdate(this.daPolicyForms, (DataTable) this.ds.tblPolicyForms);
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      Exception exception = ex;
      if (exception.Message.Contains("FK_tblCompanyFormsConditionsWarranties_tblPolicyForms"))
      {
        int num1 = (int) MessageBox.Show("Cannot delete form because it has associated conditions and warranties.", "Unable to Delete Form", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      }
      else if (exception.Message.Contains("FK_tblQuoteFormsConditionsWarranties_tblPolicyForms"))
      {
        int num2 = (int) MessageBox.Show("Cannot Delete Form because it is associated with one or more policies", "Unable To Delete", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      }
      else if (exception.Message.Contains("FK_tblQuoteFormsConditionsWarranties_tblCompanyFormsConditionsWarranties"))
      {
        int num3 = (int) MessageBox.Show("Cannot Delete Form because it is associated with one or more policies.", "Unable To Delete", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      }
      else
        ErrorHandler.HandleError(exception);
      this.ds.tblPolicyForms.RejectChanges();
      e.Cancel = true;
      ProjectData.ClearProjectError();
    }
    finally
    {
      Cursor.Current = MgaCursors.Default;
      this.EvaluateGrid();
    }
  }

  private void dbSave_ClickingCancel(object sender, CancelEventArgs e)
  {
    this.EvaluateGrid();
    foreach (UltraTab tab in ((UltraTabControlBase) this.UltraTabControl1).Tabs)
    {
      try
      {
        foreach (Control control in ((Control) tab.TabPage).Controls)
        {
          if (control != this.dbSave)
            this.err.SetError(control, string.Empty);
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
    }
    this.ds.tblPolicyForms.RejectChanges();
  }

  private void dbSave_ClickedSave(object sender, EventArgs e)
  {
    DefaultDatabase.DataAdapterUpdate(this.daPolicyForms, (DataTable) this.ds.tblPolicyForms);
    try
    {
      UltraTabControl ultraTabControl1 = this.UltraTabControl1;
      foreach (frmPolicyForms_ClientOverridePlugin clientOverridePlugin in ultraTabControl1 != null ? ((Control) ultraTabControl1).Controls.OfType<frmPolicyForms_ClientOverridePlugin>() : (IEnumerable<frmPolicyForms_ClientOverridePlugin>) null)
        clientOverridePlugin?.Save(RuntimeHelpers.GetObjectValue(sender), e);
    }
    finally
    {
      IEnumerator<frmPolicyForms_ClientOverridePlugin> enumerator;
      enumerator?.Dispose();
    }
  }

  private void SetControlsEnabled(bool editing)
  {
    ((Control) this.ug).Enabled = !editing;
    foreach (UltraTab tab in ((UltraTabControlBase) this.UltraTabControl1).Tabs)
    {
      try
      {
        foreach (Control control in ((Control) tab.TabPage).Controls)
        {
          if (control != this.dbSave)
            control.Enabled = editing;
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

  private void dbSave_UIStateChanged(object sender, EventArgs e)
  {
    this.SetControlsEnabled(this.dbSave.UIState == 2);
  }

  private bool IsValidForm(dsPolicyForms.tblPolicyFormsRow dr)
  {
    bool flag = true;
    if (((TextEditorControlBase) this.txtFormName).Text.Length == 0)
    {
      this.err.SetError((Control) this.txtFormName, "Please enter a name for this form.");
      flag = false;
    }
    else
      this.err.SetError((Control) this.txtFormName, string.Empty);
    if (((TextEditorControlBase) this.txtFormNumber).Text.Length == 0)
    {
      this.err.SetError((Control) this.txtFormNumber, "Please enter a number for this form.");
      flag = false;
    }
    else
      this.err.SetError((Control) this.txtFormNumber, string.Empty);
    if (((UltraCombo) this.cboAutomationReports).Text.Length > 0 && ((Control) this.lblTemplate).Tag != null)
    {
      this.err.SetError((Control) this.lblTemplate, "Can not select both a template and automation report.");
      flag = false;
    }
    else
      this.err.SetError((Control) this.lblTemplate, string.Empty);
    if (((UltraCombo) this.cboAutomationReports).Text.Length > 0 && ((ControlBase) this.lblPDF).Text.Length > 0)
    {
      this.err.SetError((Control) this.cboAutomationReports, "Can not select both a PDF and automation report.");
      flag = false;
    }
    else
      this.err.SetError((Control) this.cboAutomationReports, string.Empty);
    if (((Control) this.lblTemplate).Tag != null && ((ControlBase) this.lblPDF).Text.Length > 0)
    {
      this.err.SetError((Control) this.lnkRemovePDF, "Can not select both a PDF and template.");
      flag = false;
    }
    else
      this.err.SetError((Control) this.lnkRemovePDF, string.Empty);
    if (flag)
    {
      if (!dr.IsPDF_FilenameNull() & dr.IsPDFNull())
      {
        this.err.SetError((Control) this.lnkRemovePDF, "Can not have a valid PDF_Filename and Null file contents.");
        flag = false;
      }
      else
        this.err.SetError((Control) this.lnkRemovePDF, string.Empty);
    }
    if (flag)
    {
      if (dr.IsPDF_FilenameNull() & !dr.IsPDFNull())
      {
        this.err.SetError((Control) this.lnkRemovePDF, "Can not have a valid PDF_File with no filename.");
        flag = false;
      }
      else
        this.err.SetError((Control) this.lnkRemovePDF, string.Empty);
    }
    return flag;
  }

  private void EvaluateGrid()
  {
    if (((UltraGridBase) this.ug).Rows.Count > 0 & ((UltraGridBase) this.ug).ActiveRow != null)
    {
      this._dRow = this.ds.tblPolicyForms.FindByFormID((int) ((UltraGridBase) this.ug).ActiveRow.Cells["FormID"].Value);
      this._formID = (int) ((UltraGridBase) this.ug).ActiveRow.Cells["FormID"].Value;
      ((TextEditorControlBase) this.txtFormName).Text = ((UltraGridBase) this.ug).ActiveRow.Cells["FormName"].Text;
      this._dRow.FormName = ((TextEditorControlBase) this.txtFormName).Text;
      if (((UltraGridBase) this.ug).ActiveRow.Cells["ParentFormID"].Value != DBNull.Value)
      {
        ((UltraCombo) this.cboParentForms).Value = (object) (int) ((UltraGridBase) this.ug).ActiveRow.Cells["ParentFormID"].Value;
        this._dRow.ParentFormID = (int) ((UltraCombo) this.cboParentForms).Value;
      }
      else
      {
        ((UltraCombo) this.cboParentForms).Value = (object) -1;
        this._dRow.SetParentFormIDNull();
      }
      if (((UltraGridBase) this.ug).ActiveRow.Cells["FormTypeID"].Value != DBNull.Value)
      {
        ((UltraCombo) this.MgaCmbFormType).Value = (object) (int) ((UltraGridBase) this.ug).ActiveRow.Cells["FormTypeID"].Value;
        this._dRow.FormTypeID = (int) ((UltraCombo) this.MgaCmbFormType).Value;
      }
      else
      {
        ((UltraCombo) this.MgaCmbFormType).Value = (object) -1;
        this._dRow.SetFormTypeIDNull();
      }
      if (((UltraGridBase) this.ug).ActiveRow.Cells["AutomationReportGuid"].Value != DBNull.Value)
      {
        ((UltraCombo) this.cboAutomationReports).Value = (object) (Guid) ((UltraGridBase) this.ug).ActiveRow.Cells["AutomationReportGuid"].Value;
        this._dRow["AutomationReportGuid"] = RuntimeHelpers.GetObjectValue(((UltraCombo) this.cboAutomationReports).Value);
      }
      else
      {
        ((UltraCombo) this.cboAutomationReports).Value = (object) Guid.Empty;
        this._dRow.SetAutomationReportGuidNull();
      }
      ((TextEditorControlBase) this.txtFormNumber).Text = ((UltraGridBase) this.ug).ActiveRow.Cells["FormNumber"].Text;
      this._dRow.FormNumber = ((TextEditorControlBase) this.txtFormNumber).Text;
      ((TextEditorControlBase) this.txtDescription).Text = ((UltraGridBase) this.ug).ActiveRow.Cells["Description"].Text;
      this._dRow.Description = ((TextEditorControlBase) this.txtDescription).Text;
      ((TextEditorControlBase) this.txtComments).Text = ((UltraGridBase) this.ug).ActiveRow.Cells["Comments"].Text;
      this._dRow.Comments = ((TextEditorControlBase) this.txtComments).Text;
      ((UltraToggleEditorBase) this.chkRequiresEndorsementNumber).Checked = (bool) ((UltraGridBase) this.ug).ActiveRow.Cells["RequiresEndorsementNumber"].Value;
      if (((UltraGridBase) this.ug).ActiveRow.Cells["TemplateID"].Value != DBNull.Value)
      {
        dsPolicyForms.tblDocumentTemplatesRow templateRow = this.GetTemplateRow((int) ((UltraGridBase) this.ug).ActiveRow.Cells["TemplateID"].Value);
        ((Control) this.lblTemplate).Tag = (object) templateRow.TemplateID;
        ((ControlBase) this.lblTemplate).Text = templateRow.TemplateDescription;
        this._dRow.TemplateID = templateRow.TemplateID;
        this._dRow.RequiresEdit = templateRow.RequiresEdit;
      }
      else
      {
        this._dRow.SetTemplateIDNull();
        this._dRow.SetRequiresEditNull();
        ((Control) this.lblTemplate).Tag = (object) null;
        ((ControlBase) this.lblTemplate).Text = string.Empty;
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((UltraGridBase) this.ug).ActiveRow.Cells["PDF_Filename"].Text, string.Empty, false) != 0)
      {
        ((ControlBase) this.lblPDF).Text = ((UltraGridBase) this.ug).ActiveRow.Cells["PDF_Filename"].Text;
        this._dRow.PDF_Filename = ((ControlBase) this.lblPDF).Text;
      }
      else
      {
        this._dRow.SetPDF_FilenameNull();
        this._dRow.SetPDFNull();
        ((ControlBase) this.lblPDF).Text = string.Empty;
        ((Control) this.lblPDF).Tag = (object) null;
      }
      if (!string.IsNullOrEmpty(((UltraGridBase) this.ug).ActiveRow.Cells["URL"].Text))
      {
        ((TextEditorControlBase) this.txtURL).Text = ((UltraGridBase) this.ug).ActiveRow.Cells["URL"].Text;
        this._dRow.URL = ((TextEditorControlBase) this.txtURL).Text;
      }
      else
      {
        ((TextEditorControlBase) this.txtURL).Text = string.Empty;
        this._dRow.SetURLNull();
      }
    }
    else
    {
      ((ControlBase) this.lblTemplate).Text = string.Empty;
      ((Control) this.lblTemplate).Tag = (object) null;
      ((TextEditorControlBase) this.txtFormName).Text = string.Empty;
      ((TextEditorControlBase) this.txtFormNumber).Text = string.Empty;
      ((UltraCombo) this.cboParentForms).Value = (object) -1;
      ((TextEditorControlBase) this.txtDescription).Text = string.Empty;
      ((UltraCombo) this.cboParentForms).Value = (object) -1;
      ((UltraCombo) this.cboAutomationReports).Value = (object) Guid.Empty;
      ((ControlBase) this.lblPDF).Text = string.Empty;
      ((TextEditorControlBase) this.txtEditionDate).Text = string.Empty;
      ((UltraCombo) this.MgaCmbFormType).Value = (object) -1;
      ((TextEditorControlBase) this.txtComments).Text = string.Empty;
      ((TextEditorControlBase) this.txtURL).Text = string.Empty;
    }
  }

  private void dbSave_ClickingSave(object sender, CancelEventArgs e)
  {
    this._dRow.FormName = ((TextEditorControlBase) this.txtFormName).Text;
    this._dRow.FormNumber = ((TextEditorControlBase) this.txtFormNumber).Text;
    if (((UltraCombo) this.cboParentForms).Value != DBNull.Value && ((UltraCombo) this.cboParentForms).Value != null)
      this._dRow.ParentFormID = (int) ((UltraCombo) this.cboParentForms).Value;
    if (((UltraCombo) this.MgaCmbFormType).Value != DBNull.Value && ((UltraCombo) this.MgaCmbFormType).Value != null)
      this._dRow.FormTypeID = (int) ((UltraCombo) this.MgaCmbFormType).Value;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((ControlBase) this.lblPDF).Text, string.Empty, false) != 0)
    {
      this._dRow.PDF_Filename = ((ControlBase) this.lblPDF).Text;
    }
    else
    {
      this._dRow.SetPDF_FilenameNull();
      this._dRow.SetPDFNull();
    }
    this._dRow.RequiresEndorsementNumber = ((UltraToggleEditorBase) this.chkRequiresEndorsementNumber).Checked;
    if (((UltraCombo) this.cboAutomationReports).Text.Length != 0)
      this._dRow["AutomationReportGuid"] = RuntimeHelpers.GetObjectValue(((UltraCombo) this.cboAutomationReports).Value);
    else
      this._dRow.SetAutomationReportGuidNull();
    this._dRow.Description = ((TextEditorControlBase) this.txtDescription).Text;
    this._dRow.Comments = ((TextEditorControlBase) this.txtComments).Text;
    if (!string.IsNullOrEmpty(((TextEditorControlBase) this.txtURL).Text))
      this._dRow.URL = ((TextEditorControlBase) this.txtURL).Text;
    else
      this._dRow.SetURLNull();
    if (this.IsValidForm(this._dRow))
    {
      Cursor.Current = MgaCursors.WaitCursor;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((UltraCombo) this.cboParentForms).Text, string.Empty, false) == 0 && !this._dRow.IsParentFormIDNull())
        this._dRow.SetParentFormIDNull();
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((UltraCombo) this.MgaCmbFormType).Text, string.Empty, false) == 0 && !this._dRow.IsFormTypeIDNull())
        this._dRow.SetFormTypeIDNull();
      if (((Control) this.lblTemplate).Tag == null && !this._dRow.IsTemplateIDNull())
      {
        this._dRow.SetTemplateIDNull();
        this._dRow.SetRequiresEditNull();
      }
      else if (((Control) this.lblTemplate).Tag != null)
      {
        int integer = Conversions.ToInteger(((Control) this.lblTemplate).Tag);
        if (this._dRow.IsTemplateIDNull() || this._dRow.TemplateID != integer)
        {
          dsPolicyForms.tblPolicyFormsRow dRow = this._dRow;
          dsPolicyForms.tblDocumentTemplatesRow byTemplateId = this.ds.tblDocumentTemplates.FindByTemplateID(integer);
          int num = byTemplateId != null ? (byTemplateId.RequiresEdit ? 1 : 0) : 0;
          dRow.RequiresEdit = num != 0;
          this._dRow.TemplateID = integer;
        }
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((UltraCombo) this.cboAutomationReports).Text, string.Empty, false) == 0)
        this._dRow.SetAutomationReportGuidNull();
      else if (!this._dRow.IsAutomationReportGuidNull() && !this._dRow.AutomationReportGuid.Equals(RuntimeHelpers.GetObjectValue(((UltraCombo) this.cboAutomationReports).Value)))
        this._dRow.AutomationReportGuid = (Guid) ((UltraCombo) this.cboAutomationReports).Value;
      if (string.IsNullOrEmpty(((TextEditorControlBase) this.txtEditionDate).Text.Trim()))
        this._dRow.SetEditionDateNull();
      else
        this._dRow.EditionDate = ((TextEditorControlBase) this.txtEditionDate).Text;
      try
      {
        DefaultDatabase.DataAdapterUpdate(this.daPolicyForms, (DataTable) this.ds.tblPolicyForms);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        if (exception.Message.Contains("FK_tblCompanyFormsConditionsWarranties_tblPolicyForms"))
        {
          int num1 = (int) MessageBox.Show("This operation is unsuccessful because of the record's underlying FormsConditionsWarranties.", "Record Not Updated", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        else if (exception.Message.Contains("CK_tblPolicyForms"))
        {
          int num2 = (int) MessageBox.Show("Operation is unsuccessful because there can either be a template,automated report or valid PDF.\n\nCannot have any two options at the same time.", "Record Not Updated", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        else
          ErrorHandler.HandleError(exception);
        e.Cancel = true;
        ProjectData.ClearProjectError();
      }
      finally
      {
        Cursor.Current = MgaCursors.Default;
      }
    }
    else
    {
      this.ShowErrorTabs();
      e.Cancel = true;
    }
  }

  private void ShowErrorTabs()
  {
    try
    {
      foreach (UltraTabPageControl ultraTabPageControl in ((Control) this.UltraTabControl1).Controls.OfType<UltraTabPageControl>())
      {
        try
        {
          foreach (Control control in ((Control) ultraTabPageControl).Controls)
          {
            if (this.err.GetError(control).Length > 0)
            {
              ((Control) ultraTabPageControl).Show();
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
    }
    finally
    {
      IEnumerator<UltraTabPageControl> enumerator;
      enumerator?.Dispose();
    }
  }

  private void lnkRemoveTemplate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    this._dRow.SetTemplateIDNull();
    this._dRow.SetRequiresEditNull();
    ((Control) this.lblTemplate).Tag = (object) null;
    ((ControlBase) this.lblTemplate).Text = string.Empty;
  }

  private dsPolicyForms.tblDocumentTemplatesRow GetTemplateRow(int templateID)
  {
    dsPolicyForms.tblDocumentTemplatesRow row = this.ds.tblDocumentTemplates.FindByTemplateID(templateID);
    if (row == null)
    {
      DefaultDatabase.LoadDataTable((DataTable) this.ds.tblDocumentTemplates, CommandType.Text, "SELECT TemplateID, TemplateName, Description, RequiresEdit FROM dbo.tblDocumentTemplates WITH(NOLOCK) WHERE TemplateID=@TemplateID", new object[2]
      {
        (object) "@TemplateID",
        (object) templateID
      });
      row = this.ds.tblDocumentTemplates.FindByTemplateID(templateID) ?? this.ds.tblDocumentTemplates.AddtblDocumentTemplatesRow(templateID, "Template Not Found", (string) null, false, (string) null);
      string templateName = row.TemplateName;
      if (!string.IsNullOrEmpty(row.Field<string>("Description")?.Trim()))
        templateName += $" - {row.Description}";
      row.TemplateDescription = templateName;
    }
    return row;
  }

  private void lnkAddNewTemplate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    if (this._frmDocTemplates == null)
    {
      this._frmDocTemplates = (frmDocumentTemplates) ObjectFactory.Instance.CreateForm(typeof (frmDocumentTemplates));
      this._frmDocTemplates.CloseOnDoubleClickTemplate = true;
      this._frmDocTemplates.HideOnDoubleClickTemplate = true;
      ((Form) this._frmDocTemplates).TopMost = true;
    }
    ((Form) this._frmDocTemplates).Activate();
    ((Control) this._frmDocTemplates).Show();
  }

  private void _frmDocTemplates_DocTemplateSelected(object sender, EventArgs e)
  {
    dsPolicyForms.tblDocumentTemplatesRow templateRow = this.GetTemplateRow(this._frmDocTemplates.SelectedTemplateID);
    if (templateRow == null)
      return;
    ((Control) this.lblTemplate).Tag = (object) templateRow.TemplateID;
    ((ControlBase) this.lblTemplate).Text = templateRow.TemplateDescription;
  }

  private void lnkNumber_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    this._filterLetter = "#";
    this.SetFilters();
  }

  private void lnkAddNewTemplateDocuments_LinkClicked(
    object sender,
    LinkLabelLinkClickedEventArgs e)
  {
    using (frmDocumentTemplates form = (frmDocumentTemplates) ObjectFactory.Instance.CreateForm(typeof (frmDocumentTemplates)))
    {
      int num = (int) ((Form) form).ShowDialog();
    }
  }

  private void frmPolicyForms_Closing(object sender, CancelEventArgs e)
  {
    if (this._frmDocTemplates == null)
      return;
    ((Form) this._frmDocTemplates).Close();
  }

  private void _frmDocTemplates_DocTemplateClosed(object sender, EventArgs e)
  {
    this._frmDocTemplates = (frmDocumentTemplates) null;
  }

  private void txtFormTypeFilter_TextChanged(object sender, EventArgs e)
  {
    foreach (UltraGridRow row in ((UltraGridBase) this.ug).Rows)
      row.Hidden = !string.IsNullOrEmpty(((TextEditorControlBase) this.txtFormTypeFilter).Text) && (Utility.IsNull(RuntimeHelpers.GetObjectValue(row.Cells["FormTypeID"].Value)) || !frmDocumentTemplates.ContainsCaseInsensitive(row.Cells["FormTypeID"].Text, ((TextEditorControlBase) this.txtFormTypeFilter).Text));
  }

  private void ug_InitializeRow(object sender, InitializeRowEventArgs e)
  {
    if (e.ReInitialize || !Utility.IsNull<bool>(RuntimeHelpers.GetObjectValue(e.Row.Cells["RequiresEdit"].Value), false))
      return;
    e.Row.Appearance.FontData.Bold = (DefaultableBoolean) 1;
    e.Row.Appearance.FontData.Italic = (DefaultableBoolean) 1;
  }

  private delegate void SetProgressMaxHandler(int max);

  private delegate void AddRowHandler(dsPolicyForms.tblPolicyFormsRow dr);

  private delegate void AddAutomationReportHandler(Guid reportGuid, string title);
}
