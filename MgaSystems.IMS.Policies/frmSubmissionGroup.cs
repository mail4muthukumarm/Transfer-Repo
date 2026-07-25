// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.frmSubmissionGroup
// Assembly: MgaSystems.IMS.Policies, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 2FF2C709-F7BF-41DA-82BD-FF6319CA235D
// Assembly location: C:\Users\muthu\Downloads\MgaSystems.IMS.Policies.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinProgressBar;
using Infragistics.Win.UltraWinScrollBar;
using MGASystems.BusinessObjects;
using MGASystems.Common;
using MGASystems.Common.ErrorHandling;
using MGASystems.Common.Extensions;
using MGASystems.Data;
using MGASystems.IMS.NoteDocuments;
using MGASystems.IMS.Policies.Clearance;
using MGASystems.IMS.Policies.PolicyBusinessObjects;
using MGASystems.IMS.Security;
using MGASystems.Tools;
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
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Policies;

[DocumentFolderFilter("Submission Groups")]
[SecureResource("{6131D451-E9FF-4ba8-83D0-C4025BE43BCE}", "Ability to Change Underwriter if Submission has Bound Policies", "Controls whether or not users have the security to change the underwriter when there is at least one bound quote on the submisssion.", "Submissions")]
[SecureResource("{E4171CD7-1384-4caf-85CA-C4D5ED8AE994}", "Ability to Change TA/CSR if Submission has Bound Policies", "Controls whether or not users have the security to change the TA/CSR when there is at least one bound quote on the submisssion.", "Submissions")]
[SecureResource("{25DCF2EC-C34B-4068-9C52-BB13B97B8B89}", "Ability to Change Submission Date if Submission has Bound Policies", "Controls whether or not users have the security to change the submission date when there is at least one bound quote on the submisssion.", "Submissions")]
[SecureResource("{CEFEA70E-1938-475d-906A-5A59DBEF9CC7}", "Ability to Change Producer CSR if Submission has Bound Policies", "Controls whether or not users have the security to change the producer CSR when there is at least one bound quote on the submisssion.", "Submissions")]
[SecureResource("{569C99D3-9A8B-4a93-8A6D-2661E6237368}", "View submission level documents", "Determines whether or not a user can see submission level documents.", "Submissions")]
[SecureResource("{4F098D1D-A921-4a5b-9751-8D90993954D4}", "Change In-House Producer", "Controls whether or not the in-house producer can be changed on existing submissions.", "Submissions")]
[SecureResource("{71D6425E-D540-451D-8DDB-185E6DB8395D}", "Change Submision Contact", "Controls whether or not a contact can be changed on existing submissions whenever quotes exist.", "Submissions")]
[SecureResource("{838F21B0-6BFF-43DA-AEEF-96E4CBC494B3}", "Create Submissions When Producer / Contact Status Is Inactive", "Controls whether a user can create a submission if the status of producer or contact status is Inactive.", "Submissions")]
[SecureResource("{7E133147-96E3-4C5C-A1F2-02305605906B}", "Create Submissions When Producer / Contact Status Is Closed", "Controls whether a user can create a submission if the status of producer or contact status is Closed.", "Submissions")]
[SecureResource("{5617EF6F-A64C-4422-90E4-C8473C10BAE8}", "Allow Search by Producer By Contact", "Controls the ability to Search by Producer By Contact", "Submissions")]
public class frmSubmissionGroup : Form, ISupportDocumentSystem, ISupportNoteSystem
{
  private IContainer components;
  private Label lblProducer;
  private ErrorProvider err;
  private DbCommand DbSelectCommand2;
  private DbDataAdapter daUnderwriters;
  private DbDataAdapter daSubmissionGroups;
  private DbCommand DbSelectCommand4;
  private DbCommand DbInsertCommand1;
  private DbCommand DbUpdateCommand1;
  protected Label Label2;
  protected Label Label4;
  protected MGAGroupBox MgaGroupBox1;
  private Label Label1;
  internal const string ChangeInHouseProducer = "{4F098D1D-A921-4a5b-9751-8D90993954D4}";
  internal const string CanChangeUnderwriter = "{6131D451-E9FF-4ba8-83D0-C4025BE43BCE}";
  internal const string CanChangeTACSR = "{E4171CD7-1384-4caf-85CA-C4D5ED8AE994}";
  internal const string CanChangeSubmittedDate = "{25DCF2EC-C34B-4068-9C52-BB13B97B8B89}";
  internal const string CanChangeProducerCSR = "{CEFEA70E-1938-475d-906A-5A59DBEF9CC7}";
  internal const string SecurityIDViewSubmissionLevelDocuments = "{569C99D3-9A8B-4a93-8A6D-2661E6237368}";
  internal const string CanSearchByProducerByContact = "{5617EF6F-A64C-4422-90E4-C8473C10BAE8}";
  internal const string CanChangeContactWhenQuoteExists = "{71D6425E-D540-451D-8DDB-185E6DB8395D}";
  internal const string CreateNewSubmissionWithInactiveStatus = "{838F21B0-6BFF-43DA-AEEF-96E4CBC494B3}";
  internal const string CreateNewSubmissionWithClosedStatus = "{7E133147-96E3-4C5C-A1F2-02305605906B}";
  protected Guid _insuredGuid;
  protected Guid _submissionGroupGuid;
  protected bool _isEdit;
  private bool _cboProducerByContactComboChosen;
  private bool _isSaving;
  private Guid _producerOnSubmmission;
  private bool _quoteExists;
  private bool _submissionSaved;
  protected string _submissionProducersProc;
  private Dictionary<Guid, Guid> _producerLocationDictionary;
  private string _submissionUnderwritersProc;
  private bool _hasPermissionForInactiveStatus;
  private bool _hasPermissionForClosedStatus;

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  [field: AccessedThroughProperty("Label5")]
  protected virtual Label Label5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected virtual MGAButton btnCancel
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

  protected virtual MGASimpleComboBox cboUnderwriters
  {
    get => this._cboUnderwriters;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      CancelEventHandler cancelEventHandler = new CancelEventHandler(this.cboUnderwriters_BeforeDropDown);
      MGASimpleComboBox cboUnderwriters1 = this._cboUnderwriters;
      if (cboUnderwriters1 != null)
        ((UltraCombo) cboUnderwriters1).BeforeDropDown -= cancelEventHandler;
      this._cboUnderwriters = value;
      MGASimpleComboBox cboUnderwriters2 = this._cboUnderwriters;
      if (cboUnderwriters2 == null)
        return;
      ((UltraCombo) cboUnderwriters2).BeforeDropDown += cancelEventHandler;
    }
  }

  [field: AccessedThroughProperty("cboTACSR")]
  protected virtual MGASimpleComboBox cboTACSR { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("dtSubmitted")]
  protected virtual MGADateTimePicker dtSubmitted { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cboInHouseProducers")]
  protected virtual MGASimpleComboBox cboInHouseProducers { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("progress")]
  protected virtual UltraProgressBar progress { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label3")]
  protected virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected virtual MGAComboBox cboProducers
  {
    get => this._cboProducers;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler1 = new EventHandler(this.cboProducers_AfterCloseUp);
      CancelEventHandler cancelEventHandler = new CancelEventHandler(this.cboProducers_BeforeDropDown);
      EventHandler eventHandler2 = new EventHandler(this.cboProducers_ValueChanged);
      MGAComboBox cboProducers1 = this._cboProducers;
      if (cboProducers1 != null)
      {
        ((UltraCombo) cboProducers1).AfterCloseUp -= eventHandler1;
        ((UltraCombo) cboProducers1).BeforeDropDown -= cancelEventHandler;
        ((UltraCombo) cboProducers1).ValueChanged -= eventHandler2;
      }
      this._cboProducers = value;
      MGAComboBox cboProducers2 = this._cboProducers;
      if (cboProducers2 == null)
        return;
      ((UltraCombo) cboProducers2).AfterCloseUp += eventHandler1;
      ((UltraCombo) cboProducers2).BeforeDropDown += cancelEventHandler;
      ((UltraCombo) cboProducers2).ValueChanged += eventHandler2;
    }
  }

  [field: AccessedThroughProperty("ds")]
  protected virtual dsNewSubmissionGroup ds { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected virtual MGAComboBox cboProducerByContact
  {
    get => this._cboProducerByContact;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler1 = new EventHandler(this.cboProducers_AfterCloseUp);
      CancelEventHandler cancelEventHandler = new CancelEventHandler(this.cboProducers_BeforeDropDown);
      EventHandler eventHandler2 = new EventHandler(this.cboProducers_ValueChanged);
      EventHandler eventHandler3 = new EventHandler(this.cboProducerByContact_AfterCloseUp);
      MGAComboBox producerByContact1 = this._cboProducerByContact;
      if (producerByContact1 != null)
      {
        ((UltraCombo) producerByContact1).AfterCloseUp -= eventHandler1;
        ((UltraCombo) producerByContact1).BeforeDropDown -= cancelEventHandler;
        ((UltraCombo) producerByContact1).ValueChanged -= eventHandler2;
        ((UltraCombo) producerByContact1).AfterCloseUp -= eventHandler3;
      }
      this._cboProducerByContact = value;
      MGAComboBox producerByContact2 = this._cboProducerByContact;
      if (producerByContact2 == null)
        return;
      ((UltraCombo) producerByContact2).AfterCloseUp += eventHandler1;
      ((UltraCombo) producerByContact2).BeforeDropDown += cancelEventHandler;
      ((UltraCombo) producerByContact2).ValueChanged += eventHandler2;
      ((UltraCombo) producerByContact2).AfterCloseUp += eventHandler3;
    }
  }

  protected virtual MGAComboBox cboSecProducerContact
  {
    get => this._cboSecProducerContact;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      CancelEventHandler cancelEventHandler = new CancelEventHandler(this.cboSecProducerContact_BeforeDropDown);
      MGAComboBox secProducerContact1 = this._cboSecProducerContact;
      if (secProducerContact1 != null)
        ((UltraCombo) secProducerContact1).BeforeDropDown -= cancelEventHandler;
      this._cboSecProducerContact = value;
      MGAComboBox secProducerContact2 = this._cboSecProducerContact;
      if (secProducerContact2 == null)
        return;
      ((UltraCombo) secProducerContact2).BeforeDropDown += cancelEventHandler;
    }
  }

  [field: AccessedThroughProperty("Label6")]
  protected virtual Label Label6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("dvProducerLocations")]
  protected virtual DataView dvProducerLocations { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    Appearance appearance1 = new Appearance();
    UltraGridBand ultraGridBand1 = new UltraGridBand("tblProducerLocations", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("ProducerLocationGUID");
    Appearance appearance2 = new Appearance();
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("Name");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("StatusID");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("ProducerContact");
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("ProducerContactID");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("ContactAndProducer");
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("ContactStatusID");
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    ScrollBarLook scrollBarLook1 = new ScrollBarLook();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    Appearance appearance11 = new Appearance();
    UltraGridBand ultraGridBand2 = new UltraGridBand("tblProducerLocations", -1);
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("ProducerLocationGUID");
    Appearance appearance12 = new Appearance();
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("Name");
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("StatusID");
    UltraGridColumn ultraGridColumn11 = new UltraGridColumn("ProducerContact");
    UltraGridColumn ultraGridColumn12 = new UltraGridColumn("ProducerContactID");
    UltraGridColumn ultraGridColumn13 = new UltraGridColumn("ContactAndProducer");
    UltraGridColumn ultraGridColumn14 = new UltraGridColumn("ContactStatusID");
    Appearance appearance13 = new Appearance();
    Appearance appearance14 = new Appearance();
    Appearance appearance15 = new Appearance();
    ScrollBarLook scrollBarLook2 = new ScrollBarLook();
    Appearance appearance16 = new Appearance();
    UltraGridBand ultraGridBand3 = new UltraGridBand("tblProducerLocations", -1);
    UltraGridColumn ultraGridColumn15 = new UltraGridColumn("ProducerLocationGUID");
    UltraGridColumn ultraGridColumn16 = new UltraGridColumn("Name");
    UltraGridColumn ultraGridColumn17 = new UltraGridColumn("StatusID");
    UltraGridColumn ultraGridColumn18 = new UltraGridColumn("ProducerContact", -1, (object) null, 0, (SortIndicator) 1, false);
    UltraGridColumn ultraGridColumn19 = new UltraGridColumn("ProducerContactID");
    UltraGridColumn ultraGridColumn20 = new UltraGridColumn("ContactAndProducer");
    UltraGridColumn ultraGridColumn21 = new UltraGridColumn("ContactStatusID");
    Appearance appearance17 = new Appearance();
    Appearance appearance18 = new Appearance();
    Appearance appearance19 = new Appearance();
    ScrollBarLook scrollBarLook3 = new ScrollBarLook();
    Appearance appearance20 = new Appearance();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmSubmissionGroup));
    this.lblProducer = new Label();
    this.cboProducers = new MGAComboBox();
    this.ds = new dsNewSubmissionGroup();
    this.err = new ErrorProvider(this.components);
    this.btnCancel = new MGAButton();
    this.cboUnderwriters = new MGASimpleComboBox();
    this.Label2 = new Label();
    this.daUnderwriters = DefaultDatabase.CreateDataAdapter();
    this.DbSelectCommand2 = DefaultDatabase.CreateCommand();
    this.cboTACSR = new MGASimpleComboBox();
    this.Label3 = new Label();
    this.daSubmissionGroups = DefaultDatabase.CreateDataAdapter();
    this.DbInsertCommand1 = DefaultDatabase.CreateCommand();
    this.DbSelectCommand4 = DefaultDatabase.CreateCommand();
    this.DbUpdateCommand1 = DefaultDatabase.CreateCommand();
    this.Label4 = new Label();
    this.dtSubmitted = new MGADateTimePicker();
    this.cboInHouseProducers = new MGASimpleComboBox();
    this.Label5 = new Label();
    this.MgaGroupBox1 = new MGAGroupBox();
    this.lnkChangeContact = new LinkLabel();
    this.Label6 = new Label();
    this.cboSecProducerContact = new MGAComboBox();
    this.dvProducerLocations = new DataView();
    this.cboProducerByContact = new MGAComboBox();
    this.Label1 = new Label();
    this.progress = new UltraProgressBar();
    this.btnSave = new MGAButton();
    ((ISupportInitialize) this.cboProducers).BeginInit();
    this.ds.BeginInit();
    ((ISupportInitialize) this.err).BeginInit();
    ((ISupportInitialize) this.btnCancel).BeginInit();
    ((ISupportInitialize) this.cboUnderwriters).BeginInit();
    ((ISupportInitialize) this.cboTACSR).BeginInit();
    ((ISupportInitialize) this.dtSubmitted).BeginInit();
    ((ISupportInitialize) this.cboInHouseProducers).BeginInit();
    ((ISupportInitialize) this.MgaGroupBox1).BeginInit();
    ((Control) this.MgaGroupBox1).SuspendLayout();
    ((ISupportInitialize) this.cboSecProducerContact).BeginInit();
    this.dvProducerLocations.BeginInit();
    ((ISupportInitialize) this.cboProducerByContact).BeginInit();
    ((ISupportInitialize) this.btnSave).BeginInit();
    this.SuspendLayout();
    this.lblProducer.AutoSize = true;
    this.lblProducer.BackColor = Color.Transparent;
    this.lblProducer.Font = new Font("Tahoma", 8.25f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lblProducer.Location = new Point(7, 37);
    this.lblProducer.Name = "lblProducer";
    this.lblProducer.Size = new Size(129, 13);
    this.lblProducer.TabIndex = 0;
    this.lblProducer.Text = "Producer By Location:";
    this.lblProducer.TextAlign = ContentAlignment.MiddleRight;
    ((UltraCombo) this.cboProducers).BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.cboProducers).DataBindings.Add(new Binding("Value", (object) this.ds, "tblSubmissionGroup.ProducerContactID", true));
    ((UltraGridBase) this.cboProducers).DataSource = (object) this.ds.tblProducerLocations;
    appearance1.BackColor = Color.White;
    appearance1.BorderColor = Color.FromArgb(78, 122, 171);
    this.cboProducers.DisplayLayout.Appearance = (AppearanceBase) appearance1;
    this.cboProducers.DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridBand1.ColHeadersVisible = false;
    ultraGridColumn1.AutoCompleteMode = (AutoCompleteMode) 2;
    appearance2.TextTrimming = (TextTrimming) 1;
    ((HeaderBase) ultraGridColumn1.Header).Appearance = (AppearanceBase) appearance2;
    ((HeaderBase) ultraGridColumn1.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn1.Width = 185;
    ultraGridColumn2.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn2.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn2.Header.VisiblePosition = 1;
    ultraGridColumn2.Width = 106;
    ultraGridColumn3.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn3.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn3.Header.VisiblePosition = 2;
    ultraGridColumn3.Hidden = true;
    ultraGridColumn3.Width = 23;
    ultraGridColumn4.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn4.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn4.Header.VisiblePosition = 3;
    ultraGridColumn4.Width = 105;
    ultraGridColumn5.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn5.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn5.Header.VisiblePosition = 4;
    ultraGridColumn5.Hidden = true;
    ultraGridColumn5.Width = 44;
    ultraGridColumn6.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn6.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn6.Header.VisiblePosition = 5;
    ultraGridColumn6.Width = 170;
    ((HeaderBase) ultraGridColumn7.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn7.Header.VisiblePosition = 6;
    ultraGridColumn7.Hidden = true;
    ultraGridColumn7.Width = 80 /*0x50*/;
    ultraGridBand1.Columns.AddRange(new object[7]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3,
      (object) ultraGridColumn4,
      (object) ultraGridColumn5,
      (object) ultraGridColumn6,
      (object) ultraGridColumn7
    });
    this.cboProducers.DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    this.cboProducers.DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    this.cboProducers.DisplayLayout.BorderStyleCaption = (UIElementBorderStyle) 1;
    this.cboProducers.DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 1;
    this.cboProducers.DisplayLayout.Override.BorderStyleHeader = (UIElementBorderStyle) 1;
    this.cboProducers.DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 1;
    this.cboProducers.DisplayLayout.Override.BorderStyleRowSelector = (UIElementBorderStyle) 1;
    this.cboProducers.DisplayLayout.Override.BorderStyleSummaryFooter = (UIElementBorderStyle) 1;
    this.cboProducers.DisplayLayout.Override.BorderStyleSummaryFooterCaption = (UIElementBorderStyle) 1;
    this.cboProducers.DisplayLayout.Override.BorderStyleSummaryValue = (UIElementBorderStyle) 1;
    this.cboProducers.DisplayLayout.Override.BorderStyleTemplateAddRow = (UIElementBorderStyle) 1;
    appearance3.BackColor = Color.FromArgb(240 /*0xF0*/, 246, 254);
    appearance3.BorderColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this.cboProducers.DisplayLayout.Override.HotTrackRowAppearance = (AppearanceBase) appearance3;
    appearance4.BorderColor = Color.White;
    this.cboProducers.DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance4;
    this.cboProducers.DisplayLayout.Override.RowSpacingAfter = 1;
    appearance5.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance5.BorderColor = Color.FromArgb((int) byte.MaxValue, 214, 88);
    appearance5.ForeColor = Color.Black;
    this.cboProducers.DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance5;
    scrollBarLook1.ViewStyle = (ScrollBarViewStyle) 3;
    this.cboProducers.DisplayLayout.ScrollBarLook = scrollBarLook1;
    ((UltraDropDownBase) this.cboProducers).DisplayMember = "Name";
    ((UltraCombo) this.cboProducers).DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboProducers).DropDownWidth = 400;
    ((Control) this.cboProducers).Location = new Point(147, 35);
    ((MGASimpleComboBox) this.cboProducers).MGAStyle = (MGAStyles) 2;
    ((Control) this.cboProducers).Name = "cboProducers";
    ((Control) this.cboProducers).Size = new Size(294, 21);
    ((Control) this.cboProducers).TabIndex = 2;
    ((UltraControlBase) this.cboProducers).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboProducers).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboProducers).ValueMember = "ProducerContactID";
    this.ds.DataSetName = "dsNewSubmissionGroup";
    this.ds.Locale = new CultureInfo("en-US");
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.err.ContainerControl = (ContainerControl) this;
    appearance6.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance19.Image"));
    appearance6.ImageHAlign = (HAlign) 2;
    ((ControlBase) this.btnCancel).Appearance = (AppearanceBase) appearance6;
    ((UltraButtonBase) this.btnCancel).DialogResult = DialogResult.Cancel;
    ((ControlBase) this.btnCancel).ImageSize = new Size(24, 24);
    ((ControlBase) this.btnCancel).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnCancel).Location = new Point(399, 238);
    ((Control) this.btnCancel).Name = "btnCancel";
    ((Control) this.btnCancel).Size = new Size(42, 42);
    ((Control) this.btnCancel).TabIndex = 10;
    this.btnCancel.UseOSThemes = (DefaultableBoolean) 2;
    ((UltraCombo) this.cboUnderwriters).BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.cboUnderwriters).DataBindings.Add(new Binding("Value", (object) this.ds, "tblSubmissionGroup.UnderwriterUserGUID", true));
    ((UltraGridBase) this.cboUnderwriters).DataSource = (object) this.ds.Underwriters;
    ((UltraDropDownBase) this.cboUnderwriters).DisplayMember = "Name";
    ((UltraCombo) this.cboUnderwriters).DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboUnderwriters).DropDownWidth = 294;
    ((Control) this.cboUnderwriters).Location = new Point(147, 119);
    this.cboUnderwriters.MGAStyle = (MGAStyles) 2;
    ((Control) this.cboUnderwriters).Name = "cboUnderwriters";
    ((Control) this.cboUnderwriters).Size = new Size(294, 21);
    ((Control) this.cboUnderwriters).TabIndex = 5;
    ((UltraControlBase) this.cboUnderwriters).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboUnderwriters).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboUnderwriters).ValueMember = "UserGUID";
    this.Label2.AutoSize = true;
    this.Label2.BackColor = Color.Transparent;
    this.Label2.Font = new Font("Tahoma", 8.25f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label2.Location = new Point(63 /*0x3F*/, 119);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(78, 13);
    this.Label2.TabIndex = 3;
    this.Label2.Text = "Underwriter:";
    this.Label2.TextAlign = ContentAlignment.MiddleRight;
    this.daUnderwriters.SelectCommand = this.DbSelectCommand2;
    this.daUnderwriters.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblUsers", new DataColumnMapping[2]
      {
        new DataColumnMapping("UserGUID", "UserGUID"),
        new DataColumnMapping("Name", "Name")
      })
    });
    this.DbSelectCommand2.CommandText = componentResourceManager.GetString("DbSelectCommand2.CommandText");
    ((UltraCombo) this.cboTACSR).BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.cboTACSR).DataBindings.Add(new Binding("Value", (object) this.ds, "tblSubmissionGroup.TACSRUserGuid", true));
    ((UltraGridBase) this.cboTACSR).DataSource = (object) this.ds.TACSR;
    ((UltraDropDownBase) this.cboTACSR).DisplayMember = "Name";
    ((UltraCombo) this.cboTACSR).DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboTACSR).DropDownWidth = 294;
    ((Control) this.cboTACSR).Location = new Point(147, 147);
    this.cboTACSR.MGAStyle = (MGAStyles) 2;
    ((Control) this.cboTACSR).Name = "cboTACSR";
    ((Control) this.cboTACSR).Size = new Size(294, 21);
    ((Control) this.cboTACSR).TabIndex = 6;
    ((UltraControlBase) this.cboTACSR).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboTACSR).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboTACSR).ValueMember = "UserGUID";
    this.Label3.AutoSize = true;
    this.Label3.BackColor = Color.Transparent;
    this.Label3.Font = new Font("Tahoma", 8.25f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label3.Location = new Point(84, 149);
    this.Label3.Name = "Label3";
    this.Label3.Size = new Size(53, 13);
    this.Label3.TabIndex = 5;
    this.Label3.Text = "TA/CSR:";
    this.Label3.TextAlign = ContentAlignment.MiddleRight;
    this.daSubmissionGroups.InsertCommand = this.DbInsertCommand1;
    this.daSubmissionGroups.SelectCommand = this.DbSelectCommand4;
    this.daSubmissionGroups.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblSubmissionGroup", new DataColumnMapping[9]
      {
        new DataColumnMapping("SubmissionGroupGUID", "SubmissionGroupGUID"),
        new DataColumnMapping("InsuredGuid", "InsuredGuid"),
        new DataColumnMapping("ProducerLocationGuid", "ProducerLocationGuid"),
        new DataColumnMapping("UnderwriterUserGuid", "UnderwriterUserGuid"),
        new DataColumnMapping("TACSRUserGuid", "TACSRUserGuid"),
        new DataColumnMapping("DateSubmitted", "DateSubmitted"),
        new DataColumnMapping("InHouseProducerUserGuid", "InHouseProducerUserGuid"),
        new DataColumnMapping("AddedByUserGuid", "AddedByUserGuid"),
        new DataColumnMapping("ProducerContactID", "ProducerContactID")
      })
    });
    this.daSubmissionGroups.UpdateCommand = this.DbUpdateCommand1;
    this.DbInsertCommand1.CommandText = componentResourceManager.GetString("DbInsertCommand1.CommandText");
    this.DbInsertCommand1.Parameters.AddRange((Array) new DbParameter[10]
    {
      DefaultDatabase.CreateParameter("@SubmissionGroupGUID", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "SubmissionGroupGUID"),
      DefaultDatabase.CreateParameter("@InsuredGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "InsuredGuid"),
      DefaultDatabase.CreateParameter("@ProducerLocationGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "ProducerLocationGuid"),
      DefaultDatabase.CreateParameter("@UnderwriterUserGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "UnderwriterUserGuid"),
      DefaultDatabase.CreateParameter("@TACSRUserGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "TACSRUserGuid"),
      DefaultDatabase.CreateParameter("@DateSubmitted", SqlDbType.DateTime, 8, "DateSubmitted"),
      DefaultDatabase.CreateParameter("@InHouseProducerUserGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "InHouseProducerUserGuid"),
      DefaultDatabase.CreateParameter("@AddedByUserGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "AddedByUserGuid"),
      DefaultDatabase.CreateParameter("@ProducerContactID", SqlDbType.Int, 4, "ProducerContactID"),
      DefaultDatabase.CreateParameter("@SecProducerContactID", SqlDbType.Int, 4, "SecProducerContactID")
    });
    this.DbSelectCommand4.CommandText = componentResourceManager.GetString("DbSelectCommand4.CommandText");
    this.DbSelectCommand4.Parameters.AddRange((Array) new DbParameter[1]
    {
      DefaultDatabase.CreateParameter("@SubmissionGroupGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "SubmissionGroupGUID")
    });
    this.DbUpdateCommand1.CommandText = componentResourceManager.GetString("DbUpdateCommand1.CommandText");
    this.DbUpdateCommand1.Parameters.AddRange((Array) new DbParameter[20]
    {
      DefaultDatabase.CreateParameter("@SubmissionGroupGUID", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "SubmissionGroupGUID"),
      DefaultDatabase.CreateParameter("@InsuredGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "InsuredGuid"),
      DefaultDatabase.CreateParameter("@ProducerLocationGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "ProducerLocationGuid"),
      DefaultDatabase.CreateParameter("@UnderwriterUserGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "UnderwriterUserGuid"),
      DefaultDatabase.CreateParameter("@TACSRUserGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "TACSRUserGuid"),
      DefaultDatabase.CreateParameter("@DateSubmitted", SqlDbType.DateTime, 8, "DateSubmitted"),
      DefaultDatabase.CreateParameter("@InHouseProducerUserGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "InHouseProducerUserGuid"),
      DefaultDatabase.CreateParameter("@AddedByUserGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "AddedByUserGuid"),
      DefaultDatabase.CreateParameter("@ProducerContactID", SqlDbType.Int, 4, "ProducerContactID"),
      DefaultDatabase.CreateParameter("@SecProducerContactID", SqlDbType.Int, 4, "SecProducerContactID"),
      DefaultDatabase.CreateParameter("@Original_SubmissionGroupGUID", SqlDbType.UniqueIdentifier, 16 /*0x10*/, ParameterDirection.Input, false, (byte) 0, (byte) 0, "SubmissionGroupGUID", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@Original_AddedByUserGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, ParameterDirection.Input, false, (byte) 0, (byte) 0, "AddedByUserGuid", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@Original_DateSubmitted", SqlDbType.DateTime, 8, ParameterDirection.Input, false, (byte) 0, (byte) 0, "DateSubmitted", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@Original_InHouseProducerUserGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, ParameterDirection.Input, false, (byte) 0, (byte) 0, "InHouseProducerUserGuid", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@Original_InsuredGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, ParameterDirection.Input, false, (byte) 0, (byte) 0, "InsuredGuid", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@Original_ProducerContactID", SqlDbType.Int, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "ProducerContactID", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@Original_ProducerLocationGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, ParameterDirection.Input, false, (byte) 0, (byte) 0, "ProducerLocationGuid", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@Original_TACSRUserGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, ParameterDirection.Input, false, (byte) 0, (byte) 0, "TACSRUserGuid", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@Original_UnderwriterUserGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, ParameterDirection.Input, false, (byte) 0, (byte) 0, "UnderwriterUserGuid", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@Original_SecProducerContactID", SqlDbType.Int, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "SecProducerContactID", DataRowVersion.Original, (object) null)
    });
    this.Label4.AutoSize = true;
    this.Label4.BackColor = Color.Transparent;
    this.Label4.Font = new Font("Tahoma", 8.25f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label4.Location = new Point(70, 177);
    this.Label4.Name = "Label4";
    this.Label4.Size = new Size(69, 13);
    this.Label4.TabIndex = 7;
    this.Label4.Text = "Submitted:";
    this.Label4.TextAlign = ContentAlignment.MiddleRight;
    appearance7.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraDateTimeEditor) this.dtSubmitted).Appearance = (AppearanceBase) appearance7;
    appearance8.AlphaLevel = (short) 14;
    appearance8.BackColor = Color.FromArgb(0, 0, 246, 253);
    appearance8.BackColor2 = Color.FromArgb(133, 162, 221);
    appearance8.BackColorAlpha = (Alpha) 2;
    appearance8.BackGradientAlignment = (GradientAlignment) 4;
    appearance8.BackGradientStyle = (GradientStyle) 5;
    appearance8.BorderAlpha = (Alpha) 1;
    appearance8.BorderColor = Color.FromArgb(78, 122, 171);
    appearance8.ForeColor = Color.FromArgb(49, 85, 153);
    appearance8.ForegroundAlpha = (Alpha) 2;
    ((UltraDateTimeEditor) this.dtSubmitted).ButtonAppearance = (AppearanceBase) appearance8;
    ((Control) this.dtSubmitted).DataBindings.Add(new Binding("Value", (object) this.ds, "tblSubmissionGroup.DateSubmitted", true));
    ((Control) this.dtSubmitted).Location = new Point(147, 175);
    this.dtSubmitted.MGAStyle = (MGAStyles) 2;
    ((Control) this.dtSubmitted).Name = "dtSubmitted";
    ((Control) this.dtSubmitted).Size = new Size(144 /*0x90*/, 20);
    ((Control) this.dtSubmitted).TabIndex = 7;
    ((UltraControlBase) this.dtSubmitted).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dtSubmitted).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraCombo) this.cboInHouseProducers).BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.cboInHouseProducers).DataBindings.Add(new Binding("Value", (object) this.ds, "tblSubmissionGroup.InHouseProducerUserGuid", true));
    ((UltraGridBase) this.cboInHouseProducers).DataSource = (object) this.ds.InhouseProducers;
    ((UltraDropDownBase) this.cboInHouseProducers).DisplayMember = "Name";
    ((UltraCombo) this.cboInHouseProducers).DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboInHouseProducers).DropDownWidth = 294;
    ((Control) this.cboInHouseProducers).Location = new Point(147, 91);
    this.cboInHouseProducers.MGAStyle = (MGAStyles) 2;
    ((Control) this.cboInHouseProducers).Name = "cboInHouseProducers";
    ((Control) this.cboInHouseProducers).Size = new Size(294, 21);
    ((Control) this.cboInHouseProducers).TabIndex = 4;
    ((UltraControlBase) this.cboInHouseProducers).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboInHouseProducers).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboInHouseProducers).ValueMember = "UserGUID";
    this.Label5.AutoSize = true;
    this.Label5.BackColor = Color.Transparent;
    this.Label5.Font = new Font("Tahoma", 8.25f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label5.Location = new Point(21, 91);
    this.Label5.Name = "Label5";
    this.Label5.Size = new Size(116, 13);
    this.Label5.TabIndex = 9;
    this.Label5.Text = "In-House Producer:";
    this.Label5.TextAlign = ContentAlignment.MiddleRight;
    appearance9.BackColor = Color.FromArgb(239, 247, 253);
    appearance9.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGroupBox) this.MgaGroupBox1).ContentAreaAppearance = (AppearanceBase) appearance9;
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.lnkChangeContact);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.Label6);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.cboSecProducerContact);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.cboProducerByContact);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.Label1);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.progress);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.Label3);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.cboTACSR);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.lblProducer);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.Label5);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.cboInHouseProducers);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.dtSubmitted);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.cboUnderwriters);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.Label4);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.Label2);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.cboProducers);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.btnSave);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.btnCancel);
    appearance10.AlphaLevel = (short) 230;
    appearance10.FontData.SizeInPoints = 10f;
    appearance10.ForeColor = Color.Black;
    appearance10.ImageBackgroundStyle = (ImageBackgroundStyle) 3;
    ((UltraGroupBox) this.MgaGroupBox1).HeaderAppearance = (AppearanceBase) appearance10;
    ((Control) this.MgaGroupBox1).Location = new Point(8, 6);
    ((Control) this.MgaGroupBox1).Name = "MgaGroupBox1";
    ((Control) this.MgaGroupBox1).Size = new Size(469, 285);
    ((Control) this.MgaGroupBox1).TabIndex = 11;
    ((UltraGroupBox) this.MgaGroupBox1).Text = "Submission Information";
    ((UltraGroupBox) this.MgaGroupBox1).ViewStyle = (GroupBoxViewStyle) 2;
    this.lnkChangeContact.AutoSize = true;
    this.lnkChangeContact.BackColor = Color.Transparent;
    this.lnkChangeContact.Location = new Point(356, 179);
    this.lnkChangeContact.Name = "lnkChangeContact";
    this.lnkChangeContact.Size = new Size(85, 13);
    this.lnkChangeContact.TabIndex = 207;
    this.lnkChangeContact.TabStop = true;
    this.lnkChangeContact.Text = "Change Contact";
    this.lnkChangeContact.Visible = false;
    this.Label6.AutoSize = true;
    this.Label6.BackColor = Color.Transparent;
    this.Label6.Font = new Font("Tahoma", 8.25f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label6.Location = new Point(49, 205);
    this.Label6.Name = "Label6";
    this.Label6.Size = new Size(86, 13);
    this.Label6.TabIndex = 206;
    this.Label6.Text = "Producer CSR:";
    this.Label6.TextAlign = ContentAlignment.MiddleRight;
    ((UltraCombo) this.cboSecProducerContact).BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.cboSecProducerContact).DataBindings.Add(new Binding("Value", (object) this.ds, "tblSubmissionGroup.SecProducerContactID", true));
    ((UltraGridBase) this.cboSecProducerContact).DataSource = (object) this.dvProducerLocations;
    appearance11.BackColor = Color.White;
    appearance11.BorderColor = Color.FromArgb(78, 122, 171);
    this.cboSecProducerContact.DisplayLayout.Appearance = (AppearanceBase) appearance11;
    this.cboSecProducerContact.DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridBand2.ColHeadersVisible = false;
    ultraGridColumn8.AutoCompleteMode = (AutoCompleteMode) 2;
    appearance12.TextTrimming = (TextTrimming) 1;
    ((HeaderBase) ultraGridColumn8.Header).Appearance = (AppearanceBase) appearance12;
    ((HeaderBase) ultraGridColumn8.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn8.Header.VisiblePosition = 0;
    ultraGridColumn8.Hidden = true;
    ultraGridColumn8.Width = 400;
    ultraGridColumn9.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn9.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn9.Header.VisiblePosition = 1;
    ultraGridColumn9.Hidden = true;
    ultraGridColumn9.Width = 81;
    ultraGridColumn10.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn10.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn10.Header.VisiblePosition = 2;
    ultraGridColumn10.Hidden = true;
    ultraGridColumn10.Width = 49;
    ultraGridColumn11.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn11.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn11.Header.VisiblePosition = 3;
    ultraGridColumn11.Width = 306;
    ultraGridColumn12.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn12.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn12.Header.VisiblePosition = 4;
    ultraGridColumn12.Hidden = true;
    ultraGridColumn12.Width = 92;
    ultraGridColumn13.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn13.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn13.Header.VisiblePosition = 5;
    ultraGridColumn13.Hidden = true;
    ((HeaderBase) ultraGridColumn14.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn14.Header.VisiblePosition = 6;
    ultraGridColumn14.Width = 75;
    ultraGridBand2.Columns.AddRange(new object[7]
    {
      (object) ultraGridColumn8,
      (object) ultraGridColumn9,
      (object) ultraGridColumn10,
      (object) ultraGridColumn11,
      (object) ultraGridColumn12,
      (object) ultraGridColumn13,
      (object) ultraGridColumn14
    });
    this.cboSecProducerContact.DisplayLayout.BandsSerializer.Add((object) ultraGridBand2);
    this.cboSecProducerContact.DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    this.cboSecProducerContact.DisplayLayout.BorderStyleCaption = (UIElementBorderStyle) 1;
    this.cboSecProducerContact.DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 1;
    this.cboSecProducerContact.DisplayLayout.Override.BorderStyleHeader = (UIElementBorderStyle) 1;
    this.cboSecProducerContact.DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 1;
    this.cboSecProducerContact.DisplayLayout.Override.BorderStyleRowSelector = (UIElementBorderStyle) 1;
    this.cboSecProducerContact.DisplayLayout.Override.BorderStyleSummaryFooter = (UIElementBorderStyle) 1;
    this.cboSecProducerContact.DisplayLayout.Override.BorderStyleSummaryFooterCaption = (UIElementBorderStyle) 1;
    this.cboSecProducerContact.DisplayLayout.Override.BorderStyleSummaryValue = (UIElementBorderStyle) 1;
    this.cboSecProducerContact.DisplayLayout.Override.BorderStyleTemplateAddRow = (UIElementBorderStyle) 1;
    appearance13.BackColor = Color.FromArgb(240 /*0xF0*/, 246, 254);
    appearance13.BorderColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this.cboSecProducerContact.DisplayLayout.Override.HotTrackRowAppearance = (AppearanceBase) appearance13;
    appearance14.BorderColor = Color.White;
    this.cboSecProducerContact.DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance14;
    this.cboSecProducerContact.DisplayLayout.Override.RowSpacingAfter = 1;
    appearance15.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance15.BorderColor = Color.FromArgb((int) byte.MaxValue, 214, 88);
    appearance15.ForeColor = Color.Black;
    this.cboSecProducerContact.DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance15;
    scrollBarLook2.ViewStyle = (ScrollBarViewStyle) 3;
    this.cboSecProducerContact.DisplayLayout.ScrollBarLook = scrollBarLook2;
    ((UltraDropDownBase) this.cboSecProducerContact).DisplayMember = "ProducerContact";
    ((UltraCombo) this.cboSecProducerContact).DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboSecProducerContact).DropDownWidth = 400;
    ((Control) this.cboSecProducerContact).Location = new Point(147, 203);
    ((MGASimpleComboBox) this.cboSecProducerContact).MGAStyle = (MGAStyles) 2;
    ((Control) this.cboSecProducerContact).Name = "cboSecProducerContact";
    ((Control) this.cboSecProducerContact).Size = new Size(294, 21);
    ((Control) this.cboSecProducerContact).TabIndex = 8;
    ((UltraControlBase) this.cboSecProducerContact).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboSecProducerContact).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboSecProducerContact).ValueMember = "ProducerContactID";
    this.dvProducerLocations.Table = (DataTable) this.ds.tblProducerLocations;
    ((UltraCombo) this.cboProducerByContact).BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.cboProducerByContact).DataBindings.Add(new Binding("Value", (object) this.ds, "tblSubmissionGroup.ProducerContactID", true));
    ((UltraGridBase) this.cboProducerByContact).DataSource = (object) this.ds.tblProducerLocations;
    appearance16.BackColor = Color.White;
    appearance16.BorderColor = Color.FromArgb(78, 122, 171);
    this.cboProducerByContact.DisplayLayout.Appearance = (AppearanceBase) appearance16;
    this.cboProducerByContact.DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridBand3.ColHeadersVisible = false;
    ultraGridColumn15.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn15.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn15.Header.VisiblePosition = 1;
    ultraGridColumn15.Hidden = true;
    ultraGridColumn15.Width = 122;
    ultraGridColumn16.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn16.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn16.Header.VisiblePosition = 2;
    ultraGridColumn16.Width = 103;
    ultraGridColumn17.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn17.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn17.Header.VisiblePosition = 3;
    ultraGridColumn17.Hidden = true;
    ultraGridColumn17.Width = 32 /*0x20*/;
    ultraGridColumn18.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn18.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn18.Header.VisiblePosition = 0;
    ultraGridColumn18.Width = 130;
    ultraGridColumn19.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn19.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn19.Header.VisiblePosition = 4;
    ultraGridColumn19.Hidden = true;
    ultraGridColumn19.Width = 59;
    ultraGridColumn20.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn20.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn20.Header.VisiblePosition = 5;
    ultraGridColumn20.Width = 148;
    ((HeaderBase) ultraGridColumn21.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn21.Header.VisiblePosition = 6;
    ultraGridColumn21.Hidden = true;
    ultraGridColumn21.Width = 80 /*0x50*/;
    ultraGridBand3.Columns.AddRange(new object[7]
    {
      (object) ultraGridColumn15,
      (object) ultraGridColumn16,
      (object) ultraGridColumn17,
      (object) ultraGridColumn18,
      (object) ultraGridColumn19,
      (object) ultraGridColumn20,
      (object) ultraGridColumn21
    });
    this.cboProducerByContact.DisplayLayout.BandsSerializer.Add((object) ultraGridBand3);
    this.cboProducerByContact.DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    this.cboProducerByContact.DisplayLayout.BorderStyleCaption = (UIElementBorderStyle) 1;
    this.cboProducerByContact.DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 1;
    this.cboProducerByContact.DisplayLayout.Override.BorderStyleHeader = (UIElementBorderStyle) 1;
    this.cboProducerByContact.DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 1;
    this.cboProducerByContact.DisplayLayout.Override.BorderStyleRowSelector = (UIElementBorderStyle) 1;
    this.cboProducerByContact.DisplayLayout.Override.BorderStyleSummaryFooter = (UIElementBorderStyle) 1;
    this.cboProducerByContact.DisplayLayout.Override.BorderStyleSummaryFooterCaption = (UIElementBorderStyle) 1;
    this.cboProducerByContact.DisplayLayout.Override.BorderStyleSummaryValue = (UIElementBorderStyle) 1;
    this.cboProducerByContact.DisplayLayout.Override.BorderStyleTemplateAddRow = (UIElementBorderStyle) 1;
    appearance17.BackColor = Color.FromArgb(240 /*0xF0*/, 246, 254);
    appearance17.BorderColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this.cboProducerByContact.DisplayLayout.Override.HotTrackRowAppearance = (AppearanceBase) appearance17;
    appearance18.BorderColor = Color.White;
    this.cboProducerByContact.DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance18;
    this.cboProducerByContact.DisplayLayout.Override.RowSpacingAfter = 1;
    appearance19.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance19.BorderColor = Color.FromArgb((int) byte.MaxValue, 214, 88);
    appearance19.ForeColor = Color.Black;
    this.cboProducerByContact.DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance19;
    scrollBarLook3.ViewStyle = (ScrollBarViewStyle) 3;
    this.cboProducerByContact.DisplayLayout.ScrollBarLook = scrollBarLook3;
    ((UltraDropDownBase) this.cboProducerByContact).DisplayMember = "Name";
    ((UltraCombo) this.cboProducerByContact).DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboProducerByContact).DropDownWidth = 400;
    ((Control) this.cboProducerByContact).Location = new Point(147, 63 /*0x3F*/);
    ((MGASimpleComboBox) this.cboProducerByContact).MGAStyle = (MGAStyles) 2;
    ((Control) this.cboProducerByContact).Name = "cboProducerByContact";
    ((Control) this.cboProducerByContact).Size = new Size(294, 21);
    ((Control) this.cboProducerByContact).TabIndex = 3;
    ((UltraControlBase) this.cboProducerByContact).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboProducerByContact).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboProducerByContact).ValueMember = "ProducerContactID";
    this.Label1.AutoSize = true;
    this.Label1.BackColor = Color.Transparent;
    this.Label1.Font = new Font("Tahoma", 8.25f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label1.Location = new Point(14, 65);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(125, 13);
    this.Label1.TabIndex = 12;
    this.Label1.Text = "Producer By Contact:";
    this.Label1.TextAlign = ContentAlignment.MiddleRight;
    ((Control) this.progress).Location = new Point(21, 252);
    ((Control) this.progress).Name = "progress";
    ((Control) this.progress).Size = new Size(315, 14);
    ((Control) this.progress).TabIndex = 11;
    this.progress.Text = "[Formatted]";
    appearance20.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance18.Image"));
    appearance20.ImageHAlign = (HAlign) 2;
    ((ControlBase) this.btnSave).Appearance = (AppearanceBase) appearance20;
    ((ControlBase) this.btnSave).ImageSize = new Size(24, 24);
    ((ControlBase) this.btnSave).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnSave).Location = new Point(350, 238);
    ((Control) this.btnSave).Name = "btnSave";
    ((Control) this.btnSave).Size = new Size(42, 42);
    ((Control) this.btnSave).TabIndex = 9;
    this.btnSave.UseOSThemes = (DefaultableBoolean) 2;
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.White;
    this.ClientSize = new Size(485, 297);
    this.Controls.Add((Control) this.MgaGroupBox1);
    this.DoubleBuffered = true;
    this.Font = new Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.ForeColor = Color.Black;
    this.FormBorderStyle = FormBorderStyle.FixedDialog;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmSubmissionGroup);
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    ((ISupportInitialize) this.cboProducers).EndInit();
    this.ds.EndInit();
    ((ISupportInitialize) this.err).EndInit();
    ((ISupportInitialize) this.btnCancel).EndInit();
    ((ISupportInitialize) this.cboUnderwriters).EndInit();
    ((ISupportInitialize) this.cboTACSR).EndInit();
    ((ISupportInitialize) this.dtSubmitted).EndInit();
    ((ISupportInitialize) this.cboInHouseProducers).EndInit();
    ((ISupportInitialize) this.MgaGroupBox1).EndInit();
    ((Control) this.MgaGroupBox1).ResumeLayout(false);
    ((Control) this.MgaGroupBox1).PerformLayout();
    ((ISupportInitialize) this.cboSecProducerContact).EndInit();
    this.dvProducerLocations.EndInit();
    ((ISupportInitialize) this.cboProducerByContact).EndInit();
    ((ISupportInitialize) this.btnSave).EndInit();
    this.ResumeLayout(false);
  }

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

  protected virtual LinkLabel lnkChangeContact
  {
    get => this._lnkChangeContact;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkChangeContact_LinkClicked);
      LinkLabel lnkChangeContact1 = this._lnkChangeContact;
      if (lnkChangeContact1 != null)
        lnkChangeContact1.LinkClicked -= clickedEventHandler;
      this._lnkChangeContact = value;
      LinkLabel lnkChangeContact2 = this._lnkChangeContact;
      if (lnkChangeContact2 == null)
        return;
      lnkChangeContact2.LinkClicked += clickedEventHandler;
    }
  }

  private BindingManagerBase bmb
  {
    get => this.BindingContext[(object) this.ds, this.ds.tblSubmissionGroup.TableName];
  }

  protected string SubmissionProducersProc
  {
    get => this._submissionProducersProc;
    set => this._submissionProducersProc = value;
  }

  protected virtual string SubmissionUnderwritersProc => this._submissionUnderwritersProc;

  public bool IsSubmissionSaved => this._submissionSaved;

  protected bool IsSaving => this._isSaving;

  protected dsNewSubmissionGroup.tblUsersDataTable UsersTable => this.ds.tblUsers;

  protected Guid SubmissionGroupGuid => this.ds.tblSubmissionGroup[0].SubmissionGroupGUID;

  protected Guid GetSubmissionGroupGuid => this._submissionGroupGuid;

  protected bool IsEdit => this._isEdit;

  protected Guid InsuredGuid => this._insuredGuid;

  public frmSubmissionGroup()
  {
    this.Load += new EventHandler(this.frmNewSubmissionGroup_Load);
    this._producerOnSubmmission = Guid.Empty;
    this._submissionSaved = false;
    this._submissionProducersProc = "dbo.spGetSubmissionProducers";
    this._producerLocationDictionary = new Dictionary<Guid, Guid>();
    this._submissionUnderwritersProc = "dbo.spGetUserInfo";
    this.InitializeComponent();
    Utility.SetDataAdapterConnections(this.daSubmissionGroups, DefaultDatabase.CreateDbConnection(), (DbTransaction) null);
    Utility.SetDataAdapterConnections(this.daUnderwriters, DefaultDatabase.CreateDbConnection(), (DbTransaction) null);
    try
    {
      foreach (Control control in ((Control) this.MgaGroupBox1).Controls)
      {
        if (control is MGASimpleComboBox mgaSimpleComboBox)
          ((UltraCombo) mgaSimpleComboBox).DropDownStyle = (UltraComboStyle) 0;
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  public frmSubmissionGroup(Guid insuredGuid)
    : this()
  {
    this._insuredGuid = insuredGuid;
    this._submissionGroupGuid = Guid.NewGuid();
    this.Text = "Add new submission group";
  }

  public frmSubmissionGroup(Guid insuredGuid, Guid submissionGroupGuid)
    : this(insuredGuid)
  {
    this._submissionGroupGuid = submissionGroupGuid;
    this._isEdit = true;
    this.Text = "Edit submission group";
  }

  private void frmNewSubmissionGroup_Load(object sender, EventArgs e)
  {
    if (this.DesignMode)
      return;
    if (!SecurityManager.Instance.AssertPermission("{5617EF6F-A64C-4422-90E4-C8473C10BAE8}"))
    {
      this.lblProducer.Top = this.Label1.Top;
      ((Control) this.cboProducers).Top = ((Control) this.cboProducerByContact).Top;
      this.Label1.Visible = false;
      ((Control) this.cboProducerByContact).Enabled = false;
      ((Control) this.cboProducerByContact).Visible = false;
    }
    try
    {
      foreach (Control control in ((Control) this.MgaGroupBox1).Controls)
        control.Enabled = false;
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    new Thread(new ThreadStart(this.FillDataThread))
    {
      Name = "frmSubmissionGroup - Fill Data",
      IsBackground = true
    }.Start();
  }

  private void FillDataThread()
  {
    Thread.Sleep(500);
    try
    {
      if (!this.IsHandleCreated || this.IsDisposed || this.Disposing)
        return;
      InvokeExtensions.BetterInvoke((ISynchronizeInvoke) MDIControls.Instance.MDIParent, (Delegate) new MethodInvoker(this.FillData), new object[0]);
    }
    catch (NullReferenceException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      ProjectData.ClearProjectError();
    }
  }

  protected virtual void FillData()
  {
    this.progress.Maximum = 4;
    try
    {
      if (this._isEdit)
      {
        this.daSubmissionGroups.SelectCommand.Parameters["@SubmissionGroupGuid"].Value = (object) this._submissionGroupGuid;
        DefaultDatabase.DataAdapterFill(this.daSubmissionGroups, (DataTable) this.ds.tblSubmissionGroup);
        if (this.ds.tblSubmissionGroup.Count == 0)
        {
          this.Invoke((Delegate) new frmSubmissionGroup.ShowSubmissionGroupErrorHandler(this.ShowSubmissionError), (object) "An error occured while trying to get the submission group.\n\nPlease ensure that this submission group exists.");
          this.Close();
          return;
        }
        object objectValue = RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT CASE WHEN EXISTS(SELECT * FROM tblQuotes WHERE SubmissionGroupGuid=@submissionGroupGuid) THEN 1 ELSE 0 END", new object[2]
        {
          (object) "@submissionGroupGuid",
          (object) this._submissionGroupGuid
        }));
        if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(objectValue)))
          this._quoteExists = Conversions.ToInteger(objectValue) == 1;
      }
      else
      {
        dsNewSubmissionGroup.tblSubmissionGroupRow row = this.ds.tblSubmissionGroup.NewtblSubmissionGroupRow();
        dsNewSubmissionGroup.tblSubmissionGroupRow submissionGroupRow = row;
        submissionGroupRow.SubmissionGroupGUID = this._submissionGroupGuid;
        submissionGroupRow.InsuredGUID = this._insuredGuid;
        submissionGroupRow.DateSubmitted = CurrentUser.ServerTime;
        this.ds.tblSubmissionGroup.AddtblSubmissionGroupRow(row);
      }
      if (!this._quoteExists)
      {
        dsNewSubmissionGroup.tblProducerLocationsRow row = this.ds.tblProducerLocations.NewtblProducerLocationsRow();
        dsNewSubmissionGroup.tblProducerLocationsRow producerLocationsRow = row;
        producerLocationsRow.Name = string.Empty;
        producerLocationsRow.ProducerContact = string.Empty;
        producerLocationsRow.ProducerContactID = -1;
        producerLocationsRow.ProducerLocationGUID = Guid.Empty;
        producerLocationsRow.StatusID = 1;
        producerLocationsRow.ContactStatusID = 1;
        this.ds.tblProducerLocations.AddtblProducerLocationsRow(row);
      }
      if (this._quoteExists)
        this._producerOnSubmmission = this.ds.tblSubmissionGroup[0].ProducerLocationGUID;
      bool flag1 = SecurityManager.Instance.AssertPermission(new Guid("{2D117606-DE51-4902-B36F-C415C27F52E0}"));
      if (!this._isEdit)
        DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[1]
        {
          "tblProducerLocations"
        }, this.SubmissionProducersProc, new object[4]
        {
          (object) "@CurrentUserGuid",
          (object) CurrentUser.Instance.UserGUID,
          (object) "@ViewAllProducers",
          (object) flag1
        });
      else if (!this._quoteExists)
        DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[1]
        {
          "tblProducerLocations"
        }, this.SubmissionProducersProc, new object[6]
        {
          (object) "@submissionGroupGuid",
          (object) this._submissionGroupGuid,
          (object) "@CurrentUserGuid",
          (object) CurrentUser.Instance.UserGUID,
          (object) "@ViewAllProducers",
          (object) flag1
        });
      else
        DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[1]
        {
          "tblProducerLocations"
        }, this.SubmissionProducersProc, new object[8]
        {
          (object) "@submissionGroupGuid",
          (object) this._submissionGroupGuid,
          (object) "@ProducerLocationGUID",
          (object) this._producerOnSubmmission,
          (object) "@CurrentUserGuid",
          (object) CurrentUser.Instance.UserGUID,
          (object) "@ViewAllProducers",
          (object) flag1
        });
      try
      {
        foreach (dsNewSubmissionGroup.tblProducerLocationsRow row in this.ds.tblProducerLocations.Rows)
          row.ContactAndProducer = $"{row.ProducerContact}/{row.Name}";
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
      ((UltraDropDownBase) this.cboProducerByContact).DisplayMember = "ContactAndProducer";
      UltraProgressBar progress1;
      int num1 = (progress1 = this.progress).Value + 1;
      progress1.Value = num1;
      ((UltraControlBase) this.progress).Refresh();
      UltraProgressBar progress2;
      int num2 = (progress2 = this.progress).Value + 1;
      progress2.Value = num2;
      ((UltraControlBase) this.progress).Refresh();
      UltraProgressBar progress3;
      int num3 = (progress3 = this.progress).Value + 1;
      progress3.Value = num3;
      ((UltraControlBase) this.progress).Refresh();
      this.cboInHouseProducers.DisplayLayout.Bands[0].Columns["UserGuid"].Hidden = true;
      this.cboTACSR.DisplayLayout.Bands[0].Columns["UserGuid"].Hidden = true;
      UltraGridBand band1 = this.cboProducers.DisplayLayout.Bands[0];
      band1.Columns["ProducerLocationGUID"].Hidden = true;
      band1.Columns["StatusID"].Hidden = true;
      band1.Columns["ProducerContactID"].Hidden = true;
      band1.Columns["Name"].Width = 430;
      band1.Columns["ProducerContact"].Width = 170;
      UltraGridBand band2 = this.cboProducerByContact.DisplayLayout.Bands[0];
      band2.Columns["ProducerLocationGUID"].Hidden = true;
      band2.Columns["StatusID"].Hidden = true;
      band2.Columns["ProducerContactID"].Hidden = true;
      band2.Columns["Name"].Width = 430;
      band2.Columns["ProducerContact"].Width = 170;
      ((UltraCombo) this.cboProducers).Focus();
      this.ds.tblUsers.AddtblUsersRow(Guid.Empty, string.Empty);
      DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[1]
      {
        "tblUsers"
      }, CommandType.Text, "SELECT UserGUID, LastName + @commaSpace + FirstName AS Name FROM tblUsers WITH (NOLOCK) ORDER BY LastName", new object[2]
      {
        (object) "@commaSpace",
        (object) ", "
      });
      this.ds.InhouseProducers.AddInhouseProducersRow(Guid.Empty, string.Empty);
      if (!this.ds.tblSubmissionGroup[0].IsInHouseProducerUserGuidNull())
        DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[1]
        {
          "InhouseProducers"
        }, "dbo.spGetUserInfo", new object[4]
        {
          (object) "@userGuid",
          (object) this.ds.tblSubmissionGroup[0].InHouseProducerUserGuid,
          (object) "@automationCode",
          (object) "INHPR"
        });
      else
        DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[1]
        {
          "InhouseProducers"
        }, "dbo.spGetUserInfo", new object[4]
        {
          (object) "@userGuid",
          null,
          (object) "@automationCode",
          (object) "INHPR"
        });
      this.ds.TACSR.AddTACSRRow(Guid.Empty, string.Empty);
      if (!this.ds.tblSubmissionGroup[0].IsTACSRUserGuidNull())
        DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[1]
        {
          "TACSR"
        }, "dbo.spGetUserInfo", new object[4]
        {
          (object) "@userGuid",
          (object) this.ds.tblSubmissionGroup[0].TACSRUserGuid,
          (object) "@automationCode",
          (object) "TACSR"
        });
      else
        DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[1]
        {
          "TACSR"
        }, "dbo.spGetUserInfo", new object[4]
        {
          (object) "@userGuid",
          null,
          (object) "@automationCode",
          (object) "TACSR"
        });
      this.ds.Underwriters.AddUnderwritersRow(Guid.Empty, string.Empty);
      if (!this.ds.tblSubmissionGroup[0].IsUnderwriterUserGUIDNull())
        DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[1]
        {
          "Underwriters"
        }, this.SubmissionUnderwritersProc, new object[4]
        {
          (object) "@userGuid",
          (object) this.ds.tblSubmissionGroup[0].UnderwriterUserGUID,
          (object) "@automationCode",
          (object) "UNDR"
        });
      else
        DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[1]
        {
          "Underwriters"
        }, this.SubmissionUnderwritersProc, new object[4]
        {
          (object) "@userGuid",
          null,
          (object) "@automationCode",
          (object) "UNDR"
        });
      DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[1]
      {
        "tblProducerInhouse"
      }, CommandType.Text, "SELECT ProducerLocationGuid, ProducerGuid, InhouseProducerGuid FROM dbo.tblProducerInhouse WITH (NOLOCK)");
      DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[1]
      {
        "lststatus"
      }, CommandType.Text, "Select StatusID, Status from lststatus order by Status");
      this.daUnderwriters.Dispose();
      UltraProgressBar progress4;
      int num4 = (progress4 = this.progress).Value + 1;
      progress4.Value = num4;
      ((UltraControlBase) this.progress).Refresh();
      this.bmb.Position = this.bmb.Count - 1;
      bool flag2 = SecurityManager.Instance.AssertPermission("{4F098D1D-A921-4a5b-9751-8D90993954D4}");
      try
      {
        foreach (Control control in ((Control) this.MgaGroupBox1).Controls)
        {
          if (control == this.cboProducers || control == this.cboProducerByContact)
            control.Enabled = !this._quoteExists;
          else if (control == this.cboInHouseProducers && this._isEdit)
            ((Control) this.cboInHouseProducers).Enabled = flag2;
          else
            control.Enabled = true;
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
      this.SetupSecurity();
      this.ShowInactiveClosedProducersRed();
      ((Control) this.progress).Visible = false;
      if (!this.IsHandleCreated || this.IsDisposed || this.Disposing)
        return;
      InvokeExtensions.BetterInvoke((ISynchronizeInvoke) MDIControls.Instance.MDIParent, (Delegate) new MethodInvoker(this.FormLoadComplete), new object[0]);
    }
    catch (NullReferenceException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      ProjectData.ClearProjectError();
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      ErrorHandler.HandleError(ex);
      this.Close();
      ProjectData.ClearProjectError();
    }
  }

  protected virtual void FormLoadComplete()
  {
  }

  private void ShowSubmissionError(string message)
  {
    if (MDIControls.Instance.MDIParent.InvokeRequired)
      throw new InvalidOperationException("Can not display a MessageBox on the UI Thread");
    int num = (int) MessageBox.Show(message, "Submission not found", MessageBoxButtons.OK, MessageBoxIcon.Hand);
  }

  private void ShowInactiveClosedProducersRed()
  {
    foreach (UltraGridRow row in ((UltraGridBase) this.cboProducerByContact).Rows)
    {
      if (Conversions.ToInteger(row.Cells["StatusID"].Value) != 1 || Conversions.ToInteger(row.Cells["ContactStatusID"].Value) != 1)
      {
        UltraGridRow ultraGridRow = row;
        ultraGridRow.Appearance.FontData.Strikeout = (DefaultableBoolean) 1;
        ultraGridRow.Appearance.ForeColor = Color.Red;
      }
    }
    foreach (UltraGridRow row in ((UltraGridBase) this.cboProducers).Rows)
    {
      if (Conversions.ToInteger(row.Cells["StatusID"].Value) != 1 || Conversions.ToInteger(row.Cells["ContactStatusID"].Value) != 1)
      {
        UltraGridRow ultraGridRow = row;
        ultraGridRow.Appearance.FontData.Strikeout = (DefaultableBoolean) 1;
        ultraGridRow.Appearance.ForeColor = Color.Red;
      }
    }
  }

  private void SetupSecurity()
  {
    if (this.IsEdit)
    {
      object objectValue = RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT CASE WHEN EXISTS(SELECT * FROM tblQuotes WHERE QuoteStatusID = 3 AND SubmissionGroupGuid=@submissionGroupGuid) THEN 1 ELSE 0 END", new object[2]
      {
        (object) "@submissionGroupGuid",
        (object) this._submissionGroupGuid
      }));
      if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(objectValue)) && Conversions.ToInteger(objectValue) == 1)
      {
        ((Control) this.cboUnderwriters).Enabled = SecurityManager.Instance.AssertPermission("{6131D451-E9FF-4ba8-83D0-C4025BE43BCE}");
        ((Control) this.cboTACSR).Enabled = SecurityManager.Instance.AssertPermission("{E4171CD7-1384-4caf-85CA-C4D5ED8AE994}");
        ((Control) this.dtSubmitted).Enabled = SecurityManager.Instance.AssertPermission("{25DCF2EC-C34B-4068-9C52-BB13B97B8B89}");
        ((Control) this.cboSecProducerContact).Enabled = SecurityManager.Instance.AssertPermission("{CEFEA70E-1938-475d-906A-5A59DBEF9CC7}");
      }
      if (this._quoteExists && SystemSettings.KeyExists("ShowChangeContactOnSubmissionUI") && SystemSettings.GetBoolSetting("ShowChangeContactOnSubmissionUI") && this.ds.tblProducerLocations.Count >= 1 && SecurityManager.Instance.AssertPermission("{71D6425E-D540-451D-8DDB-185E6DB8395D}"))
      {
        this.lnkChangeContact.Enabled = true;
        this.lnkChangeContact.Visible = true;
      }
    }
    this._hasPermissionForInactiveStatus = SecurityManager.Instance.AssertPermission("{838F21B0-6BFF-43DA-AEEF-96E4CBC494B3}");
    this._hasPermissionForClosedStatus = SecurityManager.Instance.AssertPermission("{7E133147-96E3-4C5C-A1F2-02305605906B}");
  }

  private bool ValidProducerSelection()
  {
    bool flag1 = true;
    bool flag2;
    if (this._quoteExists)
    {
      flag2 = true;
    }
    else
    {
      dsNewSubmissionGroup.tblProducerLocationsRow producerContactId = this.ds.tblProducerLocations.FindByProducerContactID(string.IsNullOrEmpty(((UltraCombo) this.cboProducers).Text) ? (int) ((UltraCombo) this.cboProducerByContact).Value : (int) ((UltraCombo) this.cboProducers).Value);
      if (this.ContinueSelection(producerContactId.ContactStatusID) && this.ContinueSelection(producerContactId.StatusID))
        flag2 = true;
      else if (producerContactId.StatusID != 1)
      {
        int num = (int) MessageBox.Show("The current producer selection has an invalid status.", "Invalid Producer Location Selection", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        flag2 = false;
      }
      else if (producerContactId.ContactStatusID != 1)
      {
        int num = (int) MessageBox.Show("The current contact selection for this producer has an invalid status.", "Invalid Producer Contact Selection", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        flag2 = false;
      }
      else
        flag2 = flag1;
    }
    return flag2;
  }

  protected virtual bool ValidateForm()
  {
    bool flag1 = true;
    bool flag2 = false;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((UltraCombo) this.cboProducers).Text, string.Empty, false) == 0 || ((UltraCombo) this.cboProducers).Value == null)
      flag2 = true;
    if ((Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((UltraCombo) this.cboProducerByContact).Text, string.Empty, false) == 0 || ((UltraCombo) this.cboProducerByContact).Value == null) && flag2 && !this._isEdit)
    {
      if (!SecurityManager.Instance.AssertPermission("{5617EF6F-A64C-4422-90E4-C8473C10BAE8}"))
      {
        this.err.SetError((Control) this.cboProducers, "Please select a value");
      }
      else
      {
        this.err.SetError((Control) this.cboProducers, "Please select a value from either of these.");
        this.err.SetError((Control) this.cboProducerByContact, "Please select a value from either of these.");
      }
      flag1 = false;
    }
    else
    {
      this.err.SetError((Control) this.cboProducers, string.Empty);
      this.err.SetError((Control) this.cboProducerByContact, string.Empty);
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((UltraCombo) this.cboProducerByContact).Text, string.Empty, false) != 0 && !flag2 && !this._isEdit)
    {
      this.err.SetError((Control) this.cboProducers, "Cannot select from both...select a value from either of these.");
      this.err.SetError((Control) this.cboProducerByContact, "Cannot select from both...select a value from either of these.");
      flag1 = false;
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((UltraWinEditorMaskedControlBase) this.dtSubmitted).Text, string.Empty, false) == 0 || ((UltraDateTimeEditor) this.dtSubmitted).Value == null || ((UltraDateTimeEditor) this.dtSubmitted).Value == DBNull.Value)
    {
      this.err.SetError((Control) this.dtSubmitted, "Please select a date.");
      flag1 = false;
    }
    else
      this.err.SetError((Control) this.dtSubmitted, string.Empty);
    if (flag1)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((UltraCombo) this.cboProducerByContact).Text, string.Empty, false) == 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((UltraCombo) this.cboProducers).Text, string.Empty, false) == 0)
      {
        if (!SecurityManager.Instance.AssertPermission("{5617EF6F-A64C-4422-90E4-C8473C10BAE8}"))
        {
          this.err.SetError((Control) this.cboProducers, "Select a value from this control.");
        }
        else
        {
          this.err.SetError((Control) this.cboProducers, "Select a value from either of these controls.");
          this.err.SetError((Control) this.cboProducerByContact, "Select a value from either of these controls.");
        }
        flag1 = false;
      }
      else
      {
        this.err.SetError((Control) this.cboProducers, string.Empty);
        this.err.SetError((Control) this.cboProducerByContact, string.Empty);
      }
    }
    if (flag1 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((UltraCombo) this.cboProducerByContact).Text, string.Empty, false) != 0)
      this._cboProducerByContactComboChosen = true;
    if (flag1)
      flag1 = this.ValidProducerSelection();
    return flag1;
  }

  private static bool SubmissionExists(
    DateTime dateSubmitted,
    Guid insuredGuid,
    Guid producerlocationGuid)
  {
    return DefaultDatabase.ExecuteScalar<int>(CommandType.Text, "SELECT Count(*) FROM tblSubmissionGroup WHERE (DateDiff(d,DateSubmitted,@DS) = 0) AND InsuredGuid=@IG AND ProducerLocationGuid=@PLG", new object[6]
    {
      (object) "@DS",
      (object) dateSubmitted,
      (object) "IG",
      (object) insuredGuid,
      (object) "@PLG",
      (object) producerlocationGuid
    }) != 0;
  }

  private void cboProducers_AfterCloseUp(object sender, EventArgs e)
  {
    if (((UltraGridBase) sender).ActiveRow == null || Conversions.ToInteger(((UltraCombo) sender).Value) == -1)
      return;
    bool flag = false;
    string text = string.Empty;
    string caption = string.Empty;
    if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(((UltraCombo) sender).Value)))
    {
      int integer1 = Conversions.ToInteger(((UltraGridBase) sender).ActiveRow.Cells["StatusID"].Value);
      int integer2 = Conversions.ToInteger(((UltraGridBase) sender).ActiveRow.Cells["ContactStatusID"].Value);
      if (integer1 != 1 && !this.ContinueSelection(integer1))
      {
        ((UltraCombo) sender).Value = (object) null;
        flag = true;
        text = $"The chosen producer location is not active. '{this.ds.lstStatus.FindByStatusID(integer1).Status}' status.";
        caption = "Inactive Producer Location";
      }
      else if (integer2 != 1 && !this.ContinueSelection(integer2))
      {
        ((UltraCombo) sender).Value = (object) null;
        flag = true;
        text = $"The chosen producer contact is not active. '{this.ds.lstStatus.FindByStatusID(integer2).Status}' status.";
        caption = "Inactive Producer Contact";
      }
    }
    if (!flag)
      return;
    int num = (int) MessageBox.Show(text, caption, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
  }

  private void cboProducers_BeforeDropDown(object sender, CancelEventArgs e)
  {
    MGAComboBox mgaComboBox = (MGAComboBox) sender;
    ((UltraDropDownBase) mgaComboBox).DropDownWidth = 600;
    DataView dataView = new DataView();
    DataView defaultView = this.ds.tblProducerLocations.DefaultView;
    this.ClientCboFilter(RuntimeHelpers.GetObjectValue(sender), defaultView);
    if (sender == this.cboProducers)
    {
      defaultView.Sort = "Name, StatusID";
    }
    else
    {
      defaultView.Sort = "ProducerContact, ContactStatusID";
      ((UltraDropDownBase) this.cboProducerByContact).DisplayMember = "ProducerContact";
    }
    mgaComboBox.DisplayLayout.Bands[0].Columns["ContactAndProducer"].Hidden = true;
  }

  protected virtual void ClientCboFilter(object sender, DataView dv)
  {
  }

  private void btnCancel_Click(object sender, EventArgs e)
  {
    this.CancelOnClient();
    this.Close();
  }

  protected virtual void CancelOnClient()
  {
  }

  protected virtual void cboProducers_ValueChanged(object sender, EventArgs e)
  {
    MGAComboBox mgaComboBox = (MGAComboBox) sender;
    if (((UltraDropDownBase) mgaComboBox).SelectedRow == null || this._isEdit || this._isSaving)
      return;
    ((UltraCombo) this.cboUnderwriters).Value = (object) null;
    dsNewSubmissionGroup.tblProducerLocationsRow producerContactId = this.ds.tblProducerLocations.FindByProducerContactID((int) ((UltraCombo) mgaComboBox).Value);
    if (producerContactId == null || producerContactId["ProducerLocationGUID"] == DBNull.Value)
      return;
    object objectValue1 = RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar("spGetSubmissionsDefaultProducerUnderwriter", new object[4]
    {
      (object) "@ProducerLocationGUID",
      (object) (Guid) producerContactId["ProducerLocationGUID"],
      (object) "@ProducerContactID",
      (object) (int) producerContactId["ProducerContactID"]
    }));
    if (objectValue1 != null && objectValue1 != DBNull.Value && this.ds.Underwriters.Count > 0 && this.ds.Underwriters.FindByUserGUID((Guid) objectValue1) != null)
      ((UltraCombo) this.cboUnderwriters).Value = RuntimeHelpers.GetObjectValue(objectValue1);
    object objectValue2 = RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar("spGetSubmissionsDefaultTACSR", new object[4]
    {
      (object) "@ProducerLocationGUID",
      (object) (Guid) producerContactId["ProducerLocationGUID"],
      (object) "@ProducerContactID",
      (object) (int) producerContactId["ProducerContactID"]
    }));
    if (objectValue2 != null && objectValue2 != DBNull.Value && this.ds.TACSR.Count > 0 && this.ds.TACSR.FindByUserGUID((Guid) objectValue2) != null)
      ((UltraCombo) this.cboTACSR).Value = RuntimeHelpers.GetObjectValue(objectValue2);
    this.DefaultInhouseProducer();
  }

  private Guid SaveProducerSelection()
  {
    Guid guid;
    if (!this._cboProducerByContactComboChosen)
    {
      guid = (Guid) ((UltraDropDownBase) this.cboProducers).SelectedRow.Cells["producerLocationGUID"].Value;
      this.ds.tblSubmissionGroup[0].ProducerContactID = (int) ((UltraCombo) this.cboProducers).Value;
    }
    else
    {
      guid = (Guid) ((UltraDropDownBase) this.cboProducerByContact).SelectedRow.Cells["producerLocationGUID"].Value;
      ((UltraCombo) this.cboProducers).Value = (object) (int) ((UltraDropDownBase) this.cboProducerByContact).SelectedRow.Cells["ProducerContactID"].Value;
      this.ds.tblSubmissionGroup[0].ProducerContactID = (int) ((UltraCombo) this.cboProducers).Value;
    }
    return guid;
  }

  private void btnSave_Click(object sender, EventArgs e)
  {
    this._isSaving = true;
    if (this.ValidateForm())
    {
      this.ds.tblSubmissionGroup[0].AddedByUserGuid = CurrentUser.Instance.UserGUID;
      Guid g = this.SaveProducerSelection();
      this.bmb.EndCurrentEdit();
      dsNewSubmissionGroup.tblSubmissionGroupRow submissionGroupRow1 = this.ds.tblSubmissionGroup[this.bmb.Position];
      if (submissionGroupRow1.IsProducerLocationGUIDNull() || !submissionGroupRow1.ProducerLocationGUID.Equals(g))
        submissionGroupRow1.ProducerLocationGUID = g;
      if (((UltraCombo) this.cboInHouseProducers).Text.Length == 0 && !submissionGroupRow1.IsInHouseProducerUserGuidNull())
        submissionGroupRow1.SetInHouseProducerUserGuidNull();
      if (((UltraCombo) this.cboTACSR).Text.Length == 0 && !submissionGroupRow1.IsTACSRUserGuidNull())
        submissionGroupRow1.SetTACSRUserGuidNull();
      if (((UltraCombo) this.cboUnderwriters).Text.Length == 0 && !submissionGroupRow1.IsUnderwriterUserGUIDNull())
        submissionGroupRow1.SetUnderwriterUserGUIDNull();
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((UltraCombo) this.cboSecProducerContact).Text, string.Empty, false) == 0)
        submissionGroupRow1.SetSecProducerContactIDNull();
      bool isNewSubmission = this.ds.tblSubmissionGroup[0].RowState == DataRowState.Added;
      dsNewSubmissionGroup.tblSubmissionGroupRow submissionGroupRow2 = this.ds.tblSubmissionGroup[0];
      if (isNewSubmission && frmSubmissionGroup.SubmissionExists(submissionGroupRow2.DateSubmitted, submissionGroupRow2.InsuredGUID, submissionGroupRow2.ProducerLocationGUID) && MessageBox.Show("A submission already exists from this producer on this date.\n\nAre you sure you want to add this new submission?", "Submission Exists", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
        return;
      bool continueProcess = true;
      this.SaveToDatabase(ref continueProcess);
      if (continueProcess)
      {
        this.LogAction(isNewSubmission);
        this.UpdateClearanceForm();
        if (!this._isEdit)
        {
          this.Visible = false;
          Quote.Create(this._submissionGroupGuid);
        }
      }
      this.Close();
    }
    this._isSaving = false;
    this._submissionSaved = true;
  }

  private void LogAction(bool isNewSubmission)
  {
    if (isNewSubmission)
      CurrentUser.Instance.LogAction("New Submission", this.ds.tblSubmissionGroup[0].SubmissionGroupGUID);
    else
      CurrentUser.Instance.LogAction("Modify Submission", this.ds.tblSubmissionGroup[0].SubmissionGroupGUID);
  }

  private void UpdateClearanceForm()
  {
    Form[] mdiChildren = MDIControls.Instance.MDIParent.MdiChildren;
    int index = 0;
    while (index < mdiChildren.Length)
    {
      if (mdiChildren[index] is frmClearance frmClearance)
      {
        if (!this._cboProducerByContactComboChosen)
          frmClearance.RefreshSubmissionGroup(this._submissionGroupGuid, ((UltraCombo) this.cboProducers).Text, ((UltraCombo) this.cboUnderwriters).Text);
        else
          frmClearance.RefreshSubmissionGroup(this._submissionGroupGuid, ((UltraCombo) this.cboProducerByContact).Text, ((UltraCombo) this.cboUnderwriters).Text);
      }
      checked { ++index; }
    }
  }

  private void SaveToDatabase(ref bool continueProcess)
  {
    frmSubmissionGroup frmSubmissionGroup = this;
    bool flag = true;
    DefaultDatabase.ExecuteTransaction((EventHandler<ExecuteTransactionEventArgs>) ([SpecialName] (obj, t) =>
    {
      try
      {
        DefaultDatabase.DataAdapterUpdate(frmSubmissionGroup.daSubmissionGroups, (DataTable) frmSubmissionGroup.ds.tblSubmissionGroup);
        frmSubmissionGroup.SaveData((SqlTransaction) t.Transaction);
        t.Transaction.Commit();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        if (t.Transaction != null)
          t.Transaction.Rollback();
        if (exception.Message.Contains("FK_tblSubmissionGroup_tblInsureds"))
        {
          int num = (int) MessageBox.Show("The insured for this submission could not be located.", "Cannot Locate Insured", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
          flag = false;
          ProjectData.ClearProjectError();
        }
        else
          throw;
      }
    }));
    continueProcess = flag;
  }

  protected virtual void SaveData(SqlTransaction t)
  {
  }

  protected virtual void SaveData(DbTransaction t)
  {
    if (!(t is SqlTransaction))
      return;
    this.SaveData(t as SqlTransaction);
  }

  protected virtual string GetNoteTypeName() => string.Empty;

  Guid IRecreatableEntity.ControlGUID => Guid.Empty;

  bool IRecreatableEntity.HasControlGUID => false;

  public bool AllowAddNewDocument
  {
    get
    {
      return SecurityManager.Instance.AssertPermission("{569C99D3-9A8B-4a93-8A6D-2661E6237368}") && !this._submissionGroupGuid.Equals(Guid.Empty);
    }
  }

  Guid IRecreatableEntity.EntityGuid
  {
    get
    {
      return !SecurityManager.Instance.AssertPermission("{569C99D3-9A8B-4a93-8A6D-2661E6237368}") ? Guid.Empty : this._submissionGroupGuid;
    }
  }

  public event ISupportDocumentSystem.EntityInfoChangedEventHandler EntityInfoChanged;

  string IRecreatableEntity.EntityName => "Edit Submission Group" + this.GetNoteTypeName();

  bool IRecreatableEntity.CanReCreateEntity => true;

  public event ISupportNoteSystem.EntityInfoChangedEventHandler EntityInfoChanged1;

  string IRecreatableEntity.FriendlyEntityName => "Submission Group";

  bool IRecreatableEntity.RecreateEntityInitialize(Guid entityGUID)
  {
    this._submissionGroupGuid = entityGUID;
    this._insuredGuid = new SubmissionGroup(this._submissionGroupGuid).InsuredGuid;
    this._isSaving = false;
    this._isEdit = true;
    return true;
  }

  string IRecreatableEntity.RecreateTypeName => typeof (frmSubmissionGroup).ToString();

  private void cboProducerByContact_AfterCloseUp(object sender, EventArgs e)
  {
    this.cboProducerByContact.DisplayLayout.Bands[0].Columns["ContactAndProducer"].Hidden = true;
    ((UltraDropDownBase) this.cboProducerByContact).DisplayMember = "ContactAndProducer";
  }

  private void cboSecProducerContact_BeforeDropDown(object sender, CancelEventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((UltraCombo) this.cboProducerByContact).Text, string.Empty, false) != 0)
    {
      this.dvProducerLocations.RowFilter = $"ProducerLocationGUID = '{((dsNewSubmissionGroup.tblProducerLocationsRow) this.ds.tblProducerLocations.Select("ProducerContactID = " + Conversions.ToString((int) ((UltraCombo) this.cboProducerByContact).Value))[0]).ProducerLocationGUID.ToString()}'";
      this.ClientdvProducerLocations();
    }
    else
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((UltraCombo) this.cboProducers).Text, string.Empty, false) == 0)
        return;
      this.dvProducerLocations.RowFilter = $"ProducerLocationGUID = '{((dsNewSubmissionGroup.tblProducerLocationsRow) this.ds.tblProducerLocations.Select("ProducerContactID = " + Conversions.ToString((int) ((UltraCombo) this.cboProducers).Value))[0]).ProducerLocationGUID.ToString()}'";
      this.ClientdvProducerLocations();
    }
  }

  protected virtual void ClientdvProducerLocations()
  {
  }

  private void DefaultInhouseProducer()
  {
    if (this._isEdit)
      return;
    ((UltraCombo) this.cboInHouseProducers).Value = (object) null;
    Guid key = Guid.Empty;
    if (!string.IsNullOrEmpty(((UltraCombo) this.cboProducerByContact).Text))
      key = ((dsNewSubmissionGroup.tblProducerLocationsRow) this.ds.tblProducerLocations.Select("ProducerContactID = " + Conversions.ToString((int) ((UltraCombo) this.cboProducerByContact).Value))[0]).ProducerLocationGUID;
    if (!string.IsNullOrEmpty(((UltraCombo) this.cboProducers).Text))
      key = ((dsNewSubmissionGroup.tblProducerLocationsRow) this.ds.tblProducerLocations.Select("ProducerContactID = " + Conversions.ToString((int) ((UltraCombo) this.cboProducers).Value))[0]).ProducerLocationGUID;
    if (key.Equals(Guid.Empty))
      return;
    if (this.ds.tblProducerInhouse.Select($"ProducerLocationGuid='{key.ToString()}'").Length > 0)
    {
      ((UltraCombo) this.cboInHouseProducers).Value = (object) ((dsNewSubmissionGroup.tblProducerInhouseRow) this.ds.tblProducerInhouse.Select($"ProducerLocationGuid ='{key.ToString()}'")[0]).InhouseProducerGuid;
    }
    else
    {
      if (!this._producerLocationDictionary.ContainsKey(key))
      {
        ProducerLocation producerLocation = new ProducerLocation(key);
        this._producerLocationDictionary.Add(key, producerLocation.ProducerGuid);
      }
      if (this.ds.tblProducerInhouse.Select($"ProducerGuid='{this._producerLocationDictionary[key].ToString()}'").Length <= 0)
        return;
      ((UltraCombo) this.cboInHouseProducers).Value = (object) ((dsNewSubmissionGroup.tblProducerInhouseRow) this.ds.tblProducerInhouse.Select($"ProducerGuid ='{this._producerLocationDictionary[key].ToString()}'")[0]).InhouseProducerGuid;
    }
  }

  private void cboUnderwriters_BeforeDropDown(object sender, CancelEventArgs e)
  {
    this.BeforeUnderwritersDropdown(RuntimeHelpers.GetObjectValue(sender), e);
  }

  protected virtual void BeforeUnderwritersDropdown(object sender, CancelEventArgs e)
  {
  }

  private void lnkChangeContact_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    if (!this._isEdit)
    {
      int num1 = (int) MessageBox.Show("Cannot continue - User has to be editing submissions.", "Must Edit", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    else if (this.ds.tblSubmissionGroup.Count == 0 || this.ds.tblSubmissionGroup[0].IsProducerLocationGUIDNull())
    {
      int num2 = (int) MessageBox.Show("Cannot continue - No submission row exists.", "No Row Exists", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    else
    {
      bool flag = false;
      int num3 = int.MinValue;
      using (FormChangeSubmissionContact formEx = (FormChangeSubmissionContact) ObjectFactory.Instance.CreateFormEX(typeof (FormChangeSubmissionContact), new object[3]
      {
        (object) this.ds,
        (object) this.ds.tblSubmissionGroup[0].ProducerLocationGUID,
        ((UltraCombo) this.cboProducerByContact).Value
      }))
      {
        int num4 = (int) formEx.ShowDialog();
        flag = formEx.ClickedSave;
        num3 = formEx.ContactID;
      }
      if (!flag || num3 == int.MinValue)
        return;
      ((UltraCombo) this.cboProducerByContact).Value = (object) num3;
      ((UltraCombo) this.cboProducers).Value = (object) num3;
      this.ds.tblSubmissionGroup[0].ProducerContactID = num3;
    }
  }

  private bool ContinueSelection(int statusID)
  {
    return this._isEdit || statusID == 1 || statusID == 2 && this._hasPermissionForInactiveStatus || statusID == 3 && this._hasPermissionForClosedStatus;
  }

  private enum ProducerAndContactStatus
  {
    Active = 1,
    Inactive = 2,
    Closed = 3,
  }

  private delegate void ShowSubmissionGroupErrorHandler(string message);
}
