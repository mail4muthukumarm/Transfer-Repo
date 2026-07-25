// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.frmChangeProducer
// Assembly: MgaSystems.IMS.Policies, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 2FF2C709-F7BF-41DA-82BD-FF6319CA235D
// Assembly location: C:\Users\muthu\Downloads\MgaSystems.IMS.Policies.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using MGASystems.AddressResolver;
using MGASystems.BusinessObjects;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.Tools;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Policies;

public class frmChangeProducer : Form
{
  private IContainer components;
  private Label Label1;
  private Label Label3;
  private Label labelExistingProducer;
  private ErrorProvider ErrorProvider1;
  private dsChangeProducer ds;
  private Label Label2;
  private MGAComboBox cboExistingSubmissions;
  protected Guid _quoteGuid;
  private readonly Quote _quote;
  private readonly DateTime _submissionDate;
  private bool _onlyShowActiveStatus;

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

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

  protected virtual MGAComboBox cbProducers
  {
    get => this._cbProducers;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.cbProducers_ValueChanged);
      CancelEventHandler cancelEventHandler = new CancelEventHandler(this.cbProducers_BeforeDropDown);
      MGAComboBox cbProducers1 = this._cbProducers;
      if (cbProducers1 != null)
      {
        ((UltraCombo) cbProducers1).ValueChanged -= eventHandler;
        ((UltraCombo) cbProducers1).BeforeDropDown -= cancelEventHandler;
      }
      this._cbProducers = value;
      MGAComboBox cbProducers2 = this._cbProducers;
      if (cbProducers2 == null)
        return;
      ((UltraCombo) cbProducers2).ValueChanged += eventHandler;
      ((UltraCombo) cbProducers2).BeforeDropDown += cancelEventHandler;
    }
  }

  [field: AccessedThroughProperty("Label4")]
  private virtual Label Label4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("dtSubmittedDate")]
  private virtual MGADateTimePicker dtSubmittedDate { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("grpProducerLocationDetails")]
  internal virtual GroupBox grpProducerLocationDetails { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label5")]
  private virtual Label Label5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtCode")]
  protected virtual MGATextBox txtCode { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ctlZipCode")]
  protected virtual AddressResolver_MULTI ctlZipCode { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected virtual UltraOptionSet options
  {
    get => this._options;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.options_ValueChanged);
      UltraOptionSet options1 = this._options;
      if (options1 != null)
        options1.ValueChanged -= eventHandler;
      this._options = value;
      UltraOptionSet options2 = this._options;
      if (options2 == null)
        return;
      options2.ValueChanged += eventHandler;
    }
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    ValueListItem valueListItem1 = new ValueListItem();
    ValueListItem valueListItem2 = new ValueListItem();
    ValueListItem valueListItem3 = new ValueListItem();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    UltraGridBand ultraGridBand1 = new UltraGridBand("tblSubmissionGroup", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("SubmissionGroupGUID");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("Producer");
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    ScrollBarLook scrollBarLook1 = new ScrollBarLook();
    Appearance appearance10 = new Appearance();
    UltraGridBand ultraGridBand2 = new UltraGridBand("tblProducerLocations", -1);
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("ProducerLocationGUID");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("Name");
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("ProducerContact");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("ProducerContactGuid");
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("StatusID");
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("ProducerContactStatusID");
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("LocationCode");
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("Address1");
    UltraGridColumn ultraGridColumn11 = new UltraGridColumn("Address2");
    UltraGridColumn ultraGridColumn12 = new UltraGridColumn("City");
    UltraGridColumn ultraGridColumn13 = new UltraGridColumn("State");
    UltraGridColumn ultraGridColumn14 = new UltraGridColumn("ZipCode");
    UltraGridColumn ultraGridColumn15 = new UltraGridColumn("ZipPlus");
    UltraGridColumn ultraGridColumn16 = new UltraGridColumn("ISOCountryCode");
    Appearance appearance11 = new Appearance();
    Appearance appearance12 = new Appearance();
    Appearance appearance13 = new Appearance();
    ScrollBarLook scrollBarLook2 = new ScrollBarLook();
    this.Label1 = new Label();
    this.labelExistingProducer = new Label();
    this.Label3 = new Label();
    this.btnCancel = new MGAButton();
    this.btnSave = new MGAButton();
    this.ErrorProvider1 = new ErrorProvider(this.components);
    this.options = new UltraOptionSet();
    this.Label2 = new Label();
    this.dtSubmittedDate = new MGADateTimePicker();
    this.Label4 = new Label();
    this.ctlZipCode = new AddressResolver_MULTI();
    this.txtCode = new MGATextBox();
    this.grpProducerLocationDetails = new GroupBox();
    this.Label5 = new Label();
    this.cboExistingSubmissions = new MGAComboBox();
    this.ds = new dsChangeProducer();
    this.cbProducers = new MGAComboBox();
    ((ISupportInitialize) this.btnCancel).BeginInit();
    ((ISupportInitialize) this.btnSave).BeginInit();
    ((ISupportInitialize) this.ErrorProvider1).BeginInit();
    ((ISupportInitialize) this.options).BeginInit();
    ((ISupportInitialize) this.dtSubmittedDate).BeginInit();
    ((ISupportInitialize) this.txtCode).BeginInit();
    this.grpProducerLocationDetails.SuspendLayout();
    ((ISupportInitialize) this.cboExistingSubmissions).BeginInit();
    this.ds.BeginInit();
    ((ISupportInitialize) this.cbProducers).BeginInit();
    this.SuspendLayout();
    this.Label1.AutoSize = true;
    this.Label1.Font = new Font("Tahoma", 8.25f, System.Drawing.FontStyle.Bold);
    this.Label1.Location = new Point(48 /*0x30*/, 24);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(108, 13);
    this.Label1.TabIndex = 0;
    this.Label1.Text = "Existing Producer:";
    this.Label1.TextAlign = ContentAlignment.MiddleRight;
    this.labelExistingProducer.Location = new Point(168, 19);
    this.labelExistingProducer.Name = "labelExistingProducer";
    this.labelExistingProducer.Size = new Size(384, 23);
    this.labelExistingProducer.TabIndex = 1;
    this.labelExistingProducer.Text = "[Existing Producer Name Here]";
    this.labelExistingProducer.TextAlign = ContentAlignment.MiddleLeft;
    this.Label3.AutoSize = true;
    this.Label3.Font = new Font("Tahoma", 8.25f, System.Drawing.FontStyle.Bold);
    this.Label3.Location = new Point(16 /*0x10*/, 56);
    this.Label3.Name = "Label3";
    this.Label3.Size = new Size(143, 13);
    this.Label3.TabIndex = 2;
    this.Label3.Text = "New Producer / Contact:";
    this.Label3.TextAlign = ContentAlignment.MiddleRight;
    ((Control) this.btnCancel).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance1.BackColor = Color.FromArgb(248, 248, 248);
    appearance1.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance1.BackGradientStyle = (GradientStyle) 2;
    appearance1.BorderColor = Color.DarkGray;
    appearance1.ImageHAlign = (HAlign) 2;
    appearance1.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnCancel).Appearance = (AppearanceBase) appearance1;
    ((UltraButtonBase) this.btnCancel).DialogResult = DialogResult.Cancel;
    ((ControlBase) this.btnCancel).ImageSize = new Size(24, 24);
    ((Control) this.btnCancel).Location = new Point(472, 448);
    ((Control) this.btnCancel).Name = "btnCancel";
    ((Control) this.btnCancel).Size = new Size(40, 39);
    ((Control) this.btnCancel).TabIndex = 4;
    this.btnCancel.UseOSThemes = (DefaultableBoolean) 2;
    ((Control) this.btnSave).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance2.BackColor = Color.FromArgb(248, 248, 248);
    appearance2.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance2.BackGradientStyle = (GradientStyle) 2;
    appearance2.BorderColor = Color.DarkGray;
    appearance2.ImageHAlign = (HAlign) 2;
    appearance2.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnSave).Appearance = (AppearanceBase) appearance2;
    ((ControlBase) this.btnSave).ImageSize = new Size(24, 24);
    ((Control) this.btnSave).Location = new Point(518, 448);
    ((Control) this.btnSave).Name = "btnSave";
    ((Control) this.btnSave).Size = new Size(40, 39);
    ((Control) this.btnSave).TabIndex = 5;
    this.btnSave.UseOSThemes = (DefaultableBoolean) 2;
    this.ErrorProvider1.ContainerControl = (ContainerControl) this;
    this.options.BorderStyle = (UIElementBorderStyle) 1;
    this.options.CheckedIndex = 0;
    valueListItem1.DataValue = (object) "N";
    valueListItem1.DisplayText = "Create a new submission group, and move this quote under it";
    valueListItem2.DataValue = (object) "C";
    valueListItem2.DisplayText = "Change the producer for all quotes under the current submission";
    valueListItem3.DataValue = (object) "E";
    valueListItem3.DisplayText = "Move this quote under an existing submission group";
    this.options.Items.AddRange(new ValueListItem[3]
    {
      valueListItem1,
      valueListItem2,
      valueListItem3
    });
    this.options.ItemSpacingVertical = 5;
    ((Control) this.options).Location = new Point(168, 88);
    ((Control) this.options).Name = "options";
    ((Control) this.options).Size = new Size(362, 58);
    ((Control) this.options).TabIndex = 6;
    this.options.Text = "Create a new submission group, and move this quote under it";
    ((UltraControlBase) this.options).UseFlatMode = (DefaultableBoolean) 1;
    this.Label2.AutoSize = true;
    this.Label2.Location = new Point(16 /*0x10*/, 88);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(147, 13);
    this.Label2.TabIndex = 7;
    this.Label2.Text = "After changing the producer:";
    this.Label2.TextAlign = ContentAlignment.MiddleLeft;
    appearance3.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraDateTimeEditor) this.dtSubmittedDate).Appearance = (AppearanceBase) appearance3;
    appearance4.AlphaLevel = (short) 14;
    appearance4.BackColor = Color.FromArgb(0, 0, 246, 253);
    appearance4.BackColor2 = Color.FromArgb(133, 162, 221);
    appearance4.BackColorAlpha = (Alpha) 2;
    appearance4.BackGradientAlignment = (GradientAlignment) 4;
    appearance4.BackGradientStyle = (GradientStyle) 5;
    appearance4.BorderAlpha = (Alpha) 1;
    appearance4.BorderColor = Color.FromArgb(78, 122, 171);
    appearance4.ForeColor = Color.FromArgb(49, 85, 153);
    appearance4.ForegroundAlpha = (Alpha) 2;
    ((UltraDateTimeEditor) this.dtSubmittedDate).ButtonAppearance = (AppearanceBase) appearance4;
    ((Control) this.dtSubmittedDate).Location = new Point(168, 186);
    this.dtSubmittedDate.MGAStyle = (MGAStyles) 2;
    ((Control) this.dtSubmittedDate).Name = "dtSubmittedDate";
    ((Control) this.dtSubmittedDate).Size = new Size(125, 20);
    ((Control) this.dtSubmittedDate).TabIndex = 12;
    ((UltraControlBase) this.dtSubmittedDate).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dtSubmittedDate).UseOsThemes = (DefaultableBoolean) 2;
    this.Label4.AutoSize = true;
    this.Label4.Font = new Font("Tahoma", 8.25f, System.Drawing.FontStyle.Bold);
    this.Label4.Location = new Point(57, 193);
    this.Label4.Name = "Label4";
    this.Label4.Size = new Size(99, 13);
    this.Label4.TabIndex = 13;
    this.Label4.Text = "Submitted Date:";
    this.Label4.TextAlign = ContentAlignment.MiddleRight;
    this.ctlZipCode.Address1 = "";
    this.ctlZipCode.Address2 = "";
    ((Control) this.ctlZipCode).BackColor = Color.Transparent;
    this.ctlZipCode.City = "";
    this.ctlZipCode.County = "";
    ((Control) this.ctlZipCode).Font = new Font("Tahoma", 8f);
    this.ctlZipCode.ISOCountryCode = "";
    this.ctlZipCode.ISOCountryCodeMember = "";
    this.ctlZipCode.ISOCountryList = (object) null;
    this.ctlZipCode.ISOCountryNameMember = "";
    ((Control) this.ctlZipCode).Location = new Point(31 /*0x1F*/, 69);
    this.ctlZipCode.MGAStyle = (MGAStyles) 2;
    ((Control) this.ctlZipCode).Name = "ctlZipCode";
    this.ctlZipCode.Password = "";
    ((Control) this.ctlZipCode).Size = new Size(257, 171);
    this.ctlZipCode.State = "";
    ((Control) this.ctlZipCode).TabIndex = 14;
    this.ctlZipCode.UserID = "";
    this.ctlZipCode.WebserviceUrl = (string) null;
    this.ctlZipCode.ZipCode = "";
    this.ctlZipCode.ZipCodeExtension = "";
    appearance5.BackColor = Color.White;
    appearance5.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance5.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtCode).Appearance = (AppearanceBase) appearance5;
    ((TextEditorControlBase) this.txtCode).BackColor = Color.White;
    ((Control) this.txtCode).Location = new Point(111, 27);
    this.txtCode.MGAStyle = (MGAStyles) 2;
    ((Control) this.txtCode).Name = "txtCode";
    ((Control) this.txtCode).Size = new Size(125, 20);
    ((Control) this.txtCode).TabIndex = 15;
    ((UltraControlBase) this.txtCode).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtCode).UseOsThemes = (DefaultableBoolean) 2;
    this.grpProducerLocationDetails.Controls.Add((Control) this.Label5);
    this.grpProducerLocationDetails.Controls.Add((Control) this.txtCode);
    this.grpProducerLocationDetails.Controls.Add((Control) this.ctlZipCode);
    this.grpProducerLocationDetails.Enabled = false;
    this.grpProducerLocationDetails.Location = new Point(60, 225);
    this.grpProducerLocationDetails.Name = "grpProducerLocationDetails";
    this.grpProducerLocationDetails.Size = new Size(376, 262);
    this.grpProducerLocationDetails.TabIndex = 16 /*0x10*/;
    this.grpProducerLocationDetails.TabStop = false;
    this.grpProducerLocationDetails.Text = "Producer Location Details";
    this.Label5.AutoSize = true;
    this.Label5.Location = new Point(14, 31 /*0x1F*/);
    this.Label5.Name = "Label5";
    this.Label5.Size = new Size(82, 13);
    this.Label5.TabIndex = 17;
    this.Label5.Text = "Producer Code:";
    this.Label5.TextAlign = ContentAlignment.MiddleLeft;
    ((UltraCombo) this.cboExistingSubmissions).BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.cboExistingSubmissions).DataSource = (object) this.ds.tblSubmissionGroup;
    appearance6.BackColor = Color.White;
    appearance6.BorderColor = Color.FromArgb(78, 122, 171);
    this.cboExistingSubmissions.DisplayLayout.Appearance = (AppearanceBase) appearance6;
    this.cboExistingSubmissions.DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridBand1.ColHeadersVisible = false;
    ultraGridColumn1.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn1.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn2.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn2.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn2.Header.VisiblePosition = 1;
    ultraGridColumn2.Width = 381;
    ultraGridBand1.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2
    });
    this.cboExistingSubmissions.DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    this.cboExistingSubmissions.DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    this.cboExistingSubmissions.DisplayLayout.BorderStyleCaption = (UIElementBorderStyle) 1;
    this.cboExistingSubmissions.DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 1;
    this.cboExistingSubmissions.DisplayLayout.Override.BorderStyleHeader = (UIElementBorderStyle) 1;
    this.cboExistingSubmissions.DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 1;
    this.cboExistingSubmissions.DisplayLayout.Override.BorderStyleRowSelector = (UIElementBorderStyle) 1;
    this.cboExistingSubmissions.DisplayLayout.Override.BorderStyleSummaryFooter = (UIElementBorderStyle) 1;
    this.cboExistingSubmissions.DisplayLayout.Override.BorderStyleSummaryFooterCaption = (UIElementBorderStyle) 1;
    this.cboExistingSubmissions.DisplayLayout.Override.BorderStyleSummaryValue = (UIElementBorderStyle) 1;
    this.cboExistingSubmissions.DisplayLayout.Override.BorderStyleTemplateAddRow = (UIElementBorderStyle) 1;
    appearance7.BackColor = Color.FromArgb(240 /*0xF0*/, 246, 254);
    appearance7.BorderColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this.cboExistingSubmissions.DisplayLayout.Override.HotTrackRowAppearance = (AppearanceBase) appearance7;
    appearance8.BorderColor = Color.White;
    this.cboExistingSubmissions.DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance8;
    this.cboExistingSubmissions.DisplayLayout.Override.RowSpacingAfter = 1;
    appearance9.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance9.BorderColor = Color.FromArgb((int) byte.MaxValue, 214, 88);
    appearance9.ForeColor = Color.Black;
    this.cboExistingSubmissions.DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance9;
    scrollBarLook1.ViewStyle = (ScrollBarViewStyle) 3;
    this.cboExistingSubmissions.DisplayLayout.ScrollBarLook = scrollBarLook1;
    ((UltraDropDownBase) this.cboExistingSubmissions).DisplayMember = "Producer";
    ((UltraCombo) this.cboExistingSubmissions).DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboExistingSubmissions).DropDownWidth = 400;
    ((Control) this.cboExistingSubmissions).Location = new Point(168, 159);
    ((MGASimpleComboBox) this.cboExistingSubmissions).MGAStyle = (MGAStyles) 2;
    ((Control) this.cboExistingSubmissions).Name = "cboExistingSubmissions";
    ((Control) this.cboExistingSubmissions).Size = new Size(384, 21);
    ((Control) this.cboExistingSubmissions).TabIndex = 8;
    ((UltraControlBase) this.cboExistingSubmissions).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboExistingSubmissions).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboExistingSubmissions).ValueMember = "SubmissionGroupGUID";
    this.ds.DataSetName = "dsChangeProducer";
    this.ds.Locale = new CultureInfo("en-US");
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    ((UltraCombo) this.cbProducers).BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.cbProducers).DataSource = (object) this.ds.tblProducerLocations;
    appearance10.BackColor = Color.White;
    appearance10.BorderColor = Color.FromArgb(78, 122, 171);
    this.cbProducers.DisplayLayout.Appearance = (AppearanceBase) appearance10;
    this.cbProducers.DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridBand2.ColHeadersVisible = false;
    ultraGridColumn3.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn3.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn3.Header.VisiblePosition = 0;
    ultraGridColumn3.Hidden = true;
    ultraGridColumn4.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn4.Header).Caption = "Producer";
    ((HeaderBase) ultraGridColumn4.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn4.Header.VisiblePosition = 1;
    ultraGridColumn4.Width = 167;
    ultraGridColumn5.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn5.Header).Caption = "Contact";
    ((HeaderBase) ultraGridColumn5.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn5.Header.VisiblePosition = 2;
    ultraGridColumn5.Width = 100;
    ultraGridColumn6.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn6.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn6.Header.VisiblePosition = 3;
    ultraGridColumn6.Hidden = true;
    ultraGridColumn7.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn7.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn7.Header.VisiblePosition = 4;
    ultraGridColumn7.Hidden = true;
    ultraGridColumn7.Width = 53;
    ((HeaderBase) ultraGridColumn8.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn8.Header.VisiblePosition = 5;
    ultraGridColumn8.Hidden = true;
    ultraGridColumn8.Width = 105;
    ((HeaderBase) ultraGridColumn9.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn9.Header.VisiblePosition = 6;
    ultraGridColumn9.Hidden = true;
    ultraGridColumn9.Width = 39;
    ((HeaderBase) ultraGridColumn10.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn10.Header.VisiblePosition = 7;
    ultraGridColumn10.Hidden = true;
    ultraGridColumn10.Width = 39;
    ((HeaderBase) ultraGridColumn11.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn11.Header.VisiblePosition = 8;
    ultraGridColumn11.Hidden = true;
    ultraGridColumn11.Width = 39;
    ((HeaderBase) ultraGridColumn12.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn12.Header.VisiblePosition = 9;
    ultraGridColumn12.Hidden = true;
    ultraGridColumn12.Width = 39;
    ((HeaderBase) ultraGridColumn13.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn13.Header.VisiblePosition = 10;
    ultraGridColumn13.Hidden = true;
    ultraGridColumn13.Width = 39;
    ((HeaderBase) ultraGridColumn14.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn14.Header.VisiblePosition = 11;
    ultraGridColumn14.Hidden = true;
    ultraGridColumn14.Width = 39;
    ((HeaderBase) ultraGridColumn15.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn15.Header.VisiblePosition = 12;
    ultraGridColumn15.Hidden = true;
    ultraGridColumn15.Width = 151;
    ((HeaderBase) ultraGridColumn16.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn16.Header.VisiblePosition = 13;
    ultraGridColumn16.Width = 114;
    ultraGridBand2.Columns.AddRange(new object[14]
    {
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
    this.cbProducers.DisplayLayout.BandsSerializer.Add((object) ultraGridBand2);
    this.cbProducers.DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    this.cbProducers.DisplayLayout.BorderStyleCaption = (UIElementBorderStyle) 1;
    this.cbProducers.DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 1;
    this.cbProducers.DisplayLayout.Override.BorderStyleHeader = (UIElementBorderStyle) 1;
    this.cbProducers.DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 1;
    this.cbProducers.DisplayLayout.Override.BorderStyleRowSelector = (UIElementBorderStyle) 1;
    this.cbProducers.DisplayLayout.Override.BorderStyleSummaryFooter = (UIElementBorderStyle) 1;
    this.cbProducers.DisplayLayout.Override.BorderStyleSummaryFooterCaption = (UIElementBorderStyle) 1;
    this.cbProducers.DisplayLayout.Override.BorderStyleSummaryValue = (UIElementBorderStyle) 1;
    this.cbProducers.DisplayLayout.Override.BorderStyleTemplateAddRow = (UIElementBorderStyle) 1;
    appearance11.BackColor = Color.FromArgb(240 /*0xF0*/, 246, 254);
    appearance11.BorderColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this.cbProducers.DisplayLayout.Override.HotTrackRowAppearance = (AppearanceBase) appearance11;
    appearance12.BorderColor = Color.White;
    this.cbProducers.DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance12;
    this.cbProducers.DisplayLayout.Override.RowSpacingAfter = 1;
    appearance13.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance13.BorderColor = Color.FromArgb((int) byte.MaxValue, 214, 88);
    appearance13.ForeColor = Color.Black;
    this.cbProducers.DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance13;
    scrollBarLook2.ViewStyle = (ScrollBarViewStyle) 3;
    this.cbProducers.DisplayLayout.ScrollBarLook = scrollBarLook2;
    ((UltraDropDownBase) this.cbProducers).DisplayMember = "Name";
    ((UltraCombo) this.cbProducers).DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cbProducers).DropDownWidth = 650;
    ((Control) this.cbProducers).Location = new Point(168, 54);
    ((MGASimpleComboBox) this.cbProducers).MGAStyle = (MGAStyles) 2;
    ((Control) this.cbProducers).Name = "cbProducers";
    ((Control) this.cbProducers).Size = new Size(384, 21);
    ((Control) this.cbProducers).TabIndex = 3;
    ((UltraControlBase) this.cbProducers).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cbProducers).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cbProducers).ValueMember = "ProducerContactGuid";
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.White;
    this.ClientSize = new Size(565, 502);
    this.Controls.Add((Control) this.grpProducerLocationDetails);
    this.Controls.Add((Control) this.Label4);
    this.Controls.Add((Control) this.dtSubmittedDate);
    this.Controls.Add((Control) this.cboExistingSubmissions);
    this.Controls.Add((Control) this.Label2);
    this.Controls.Add((Control) this.options);
    this.Controls.Add((Control) this.btnSave);
    this.Controls.Add((Control) this.btnCancel);
    this.Controls.Add((Control) this.cbProducers);
    this.Controls.Add((Control) this.Label3);
    this.Controls.Add((Control) this.Label1);
    this.Controls.Add((Control) this.labelExistingProducer);
    this.Font = new Font("Tahoma", 8.25f);
    this.ForeColor = Color.Black;
    this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
    this.Name = nameof (frmChangeProducer);
    this.Text = "Change Producer / BOR";
    ((ISupportInitialize) this.btnCancel).EndInit();
    ((ISupportInitialize) this.btnSave).EndInit();
    ((ISupportInitialize) this.ErrorProvider1).EndInit();
    ((ISupportInitialize) this.options).EndInit();
    ((ISupportInitialize) this.dtSubmittedDate).EndInit();
    ((ISupportInitialize) this.txtCode).EndInit();
    this.grpProducerLocationDetails.ResumeLayout(false);
    this.grpProducerLocationDetails.PerformLayout();
    ((ISupportInitialize) this.cboExistingSubmissions).EndInit();
    this.ds.EndInit();
    ((ISupportInitialize) this.cbProducers).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  public frmChangeProducer(Guid quoteGuid)
  {
    this.Load += new EventHandler(this.frmChangeProducer_Load);
    this._submissionDate = DateAndTime.Now;
    this._onlyShowActiveStatus = false;
    this.InitializeComponent();
    if (this.DesignMode)
      return;
    this._quoteGuid = quoteGuid;
    ((ControlBase) this.btnSave).Appearance.Image = (object) ImageCache.Instance.Save;
    ((ControlBase) this.btnCancel).Appearance.Image = (object) ImageCache.Instance.Undo;
    this._quote = new Quote(quoteGuid);
    if (this._quote.IsBound)
      throw new InvalidOperationException("Unable to change producers on bound quotes");
    this.labelExistingProducer.Text = this._quote.ProducerLocation.LocationName;
    this._submissionDate = this._quote.SubmissionGroup.DateSubmitted;
  }

  private void frmChangeProducer_Load(object sender, EventArgs e)
  {
    if (this.DesignMode)
      return;
    DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[1]
    {
      "tblProducerLocations"
    }, "dbo.spGetAvailableProducers", new object[2]
    {
      (object) "@quoteGuid",
      (object) this._quoteGuid
    });
    DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[1]
    {
      "tblSubmissionGroup"
    }, CommandType.Text, "SELECT SG.SubmissionGroupGuid, CONVERT(VARCHAR,DateSubmitted,101) + @Dash + PL.Name AS Producer FROM tblSubmissionGroup SG INNER JOIN tblProducerLocations PL ON SG.ProducerLocationGuid = PL.ProducerLocationGuid WHERE InsuredGuid = @InsuredGuid AND SubmissionGroupGuid <> @SubmissionGroupGuid", new object[6]
    {
      (object) "@Dash",
      (object) " - ",
      (object) "@InsuredGuid",
      (object) this._quote.SubmissionGroup.InsuredLocation.Insured.InsuredGuid,
      (object) "@SubmissionGroupGuid",
      (object) this._quote.SubmissionGroupGuid
    });
    ((Control) this.cboExistingSubmissions).Enabled = this.ds.tblSubmissionGroup.Count > 0;
    ((UltraCombo) this.cbProducers).Value = (object) null;
    ((UltraDateTimeEditor) this.dtSubmittedDate).Value = (object) this._submissionDate;
    foreach (UltraGridRow row in ((UltraGridBase) this.cbProducers).Rows)
    {
      int num1 = int.MinValue;
      int num2 = int.MinValue;
      if (row.Cells["StatusID"].Value != DBNull.Value && row.Cells["StatusID"].Value != null)
        num1 = Conversions.ToInteger(row.Cells["StatusID"].Value);
      if (row.Cells["ProducerContactStatusID"].Value != DBNull.Value && row.Cells["ProducerContactStatusID"].Value != null)
        num2 = Conversions.ToInteger(row.Cells["ProducerContactStatusID"].Value);
      if (num1 == 3 || num2 == 3)
      {
        row.Appearance.FontData.Strikeout = (DefaultableBoolean) 1;
        row.Activation = (Activation) 2;
      }
      else if (num1 == 2 || num2 == 2)
      {
        row.Appearance.FontData.Strikeout = (DefaultableBoolean) 1;
        row.Appearance.ForeColor = Color.Red;
      }
    }
    this._onlyShowActiveStatus = SystemSettings.KeyExists("ChangeProducerBOR.OnlyShowActiveProducerAndContact") && SystemSettings.GetBoolSetting("ChangeProducerBOR.OnlyShowActiveProducerAndContact");
  }

  private void btnSave_Click(object sender, EventArgs e)
  {
    if (((UltraCombo) this.cbProducers).Value == null && ((Control) this.cbProducers).Enabled)
      this.ErrorProvider1.SetError((Control) this.cbProducers, "Please select a producer and contact from the list.");
    else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.options.Value.ToString(), "E", false) == 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((UltraCombo) this.cboExistingSubmissions).Text, string.Empty, false) == 0)
      this.ErrorProvider1.SetError((Control) this.cboExistingSubmissions, "Please select a value from this list.");
    else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.options.Value.ToString(), "N", false) == 0 && ((UltraDateTimeEditor) this.dtSubmittedDate).Value == null)
      this.ErrorProvider1.SetError((Control) this.dtSubmittedDate, "Please select a submitted date for the new submission");
    else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.options.Value.ToString(), "E", false) == 0 && !((Control) this.cboExistingSubmissions).Enabled)
    {
      int num1 = (int) MessageBox.Show("There are no existing submissions for this insured.\n\nPlease choose another option.", "No Existing Submissions", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    else
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.options.Value.ToString(), "C", false) == 0)
      {
        if (DefaultDatabase.ExecuteScalar<int>("GetSubmissionBoundControlNoCount", new object[2]
        {
          (object) "@SubmissionGroupGuid",
          (object) this._quote.SubmissionGroupGuid
        }) > 0)
        {
          int num2 = (int) MessageBox.Show("You can not change the producer on this submission group.\n\nAll quotes under this submission must be unbound transactions.", "Unable to Change Producer", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
          return;
        }
      }
      Guid quoteGuid = this._quoteGuid;
      Guid submissionGroupGuid = this._quote.SubmissionGroupGuid;
      DefaultDatabase.ExecuteTransaction((EventHandler<ExecuteTransactionEventArgs>) ([SpecialName] (obj, args) =>
      {
        this.ChangeProducer(RuntimeHelpers.GetObjectValue(obj), args);
        args.Transaction.Commit();
      }));
      this.ClientAfterSave();
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.options.Value.ToString(), "N", false) == 0 || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.options.Value.ToString(), "C", false) == 0)
        this.UpdateClientSubmissions(quoteGuid, submissionGroupGuid, this.options.Value.ToString());
      string str = !((Control) this.cbProducers).Enabled ? ((UltraCombo) this.cboExistingSubmissions).Text : ((UltraCombo) this.cbProducers).Text;
      CurrentUser.Instance.LogAction($"Changed producer from {this._quote.ProducerLocation.LocationName} to {str}", this._quoteGuid);
      int num3 = (int) MessageBox.Show($"The producer was successfully changed to \"{str}\".", "Producer Changed", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      this.Close();
    }
  }

  protected virtual void ClientAfterSave()
  {
  }

  private object ChangeProducer(object sender, ExecuteTransactionEventArgs e)
  {
    Guid empty = Guid.Empty;
    if (((UltraCombo) this.cbProducers).Value != null)
      empty = (Guid) ((UltraCombo) this.cbProducers).Value;
    this.ChangeProducerClientSave(empty, this._quoteGuid, this.options.Value.ToString(), RuntimeHelpers.GetObjectValue(((UltraCombo) this.cboExistingSubmissions).Value), RuntimeHelpers.GetObjectValue(((UltraDateTimeEditor) this.dtSubmittedDate).Value));
    return (object) null;
  }

  protected virtual void ChangeProducerClientSave(
    Guid producerContactGuid,
    Guid QuoteGuid,
    string changeType,
    object ExistingSubmissionsGuid,
    object SubmittedDate)
  {
    DefaultDatabase.ExecuteNonQuery("dbo.spChangeProducer", new object[12]
    {
      (object) "@quoteGuid",
      (object) QuoteGuid,
      (object) "@newProducerContactGuid",
      (object) producerContactGuid,
      (object) "@userGuid",
      (object) CurrentUser.Instance.UserGUID,
      (object) "@changeType",
      (object) changeType,
      (object) "@existingSubmissionGroupGuid",
      ExistingSubmissionsGuid,
      (object) "@submissionDate",
      SubmittedDate
    });
  }

  private void btnCancel_Click(object sender, EventArgs e) => this.Close();

  private void options_ValueChanged(object sender, EventArgs e)
  {
    ((Control) this.cbProducers).Enabled = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.options.Value.ToString(), "E", false) != 0;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.options.Value.ToString(), "N", false) != 0)
      ((UltraDateTimeEditor) this.dtSubmittedDate).Value = (object) null;
    else
      ((UltraDateTimeEditor) this.dtSubmittedDate).Value = (object) this._submissionDate;
    ((Control) this.dtSubmittedDate).Enabled = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.options.Value.ToString(), "N", false) == 0;
  }

  protected virtual void UpdateClientSubmissions(
    Guid quoteguid,
    Guid oldSubmissiongroupGuid,
    string changeType)
  {
  }

  private void ClearProducerLocationDetails()
  {
    ((TextEditorControlBase) this.txtCode).Text = string.Empty;
    this.ctlZipCode.ISOCountryCode = string.Empty;
    this.ctlZipCode.Address1 = string.Empty;
    this.ctlZipCode.Address2 = string.Empty;
    this.ctlZipCode.City = string.Empty;
    this.ctlZipCode.State = string.Empty;
    this.ctlZipCode.ZipCode = string.Empty;
    this.ctlZipCode.ZipCodeExtension = string.Empty;
  }

  private void cbProducers_ValueChanged(object sender, EventArgs e)
  {
    this.ClearProducerLocationDetails();
    if (((UltraCombo) this.cbProducers).Value == null || ((UltraCombo) this.cbProducers).Value == DBNull.Value)
      return;
    dsChangeProducer.tblProducerLocationsRow producerContactGuid = this.ds.tblProducerLocations.FindByProducerContactGuid((Guid) ((UltraCombo) this.cbProducers).Value);
    if (producerContactGuid == null)
      return;
    if (!producerContactGuid.IsLocationCodeNull())
      ((TextEditorControlBase) this.txtCode).Text = producerContactGuid.LocationCode;
    if (!producerContactGuid.IsAddress1Null())
      this.ctlZipCode.Address1 = producerContactGuid.Address1;
    if (!producerContactGuid.IsAddress2Null())
      this.ctlZipCode.Address2 = producerContactGuid.Address2;
    if (!producerContactGuid.IsCityNull())
      this.ctlZipCode.City = producerContactGuid.City;
    if (!producerContactGuid.IsStateNull())
      this.ctlZipCode.State = producerContactGuid.State;
    if (!producerContactGuid.IsZipCodeNull())
      this.ctlZipCode.ZipCode = producerContactGuid.ZipCode;
    if (!producerContactGuid.IsZipPlusNull())
      this.ctlZipCode.ZipCodeExtension = producerContactGuid.ZipPlus;
    if (producerContactGuid.IsISOCountryCodeNull())
      return;
    this.ctlZipCode.ISOCountryCode = producerContactGuid.ISOCountryCode;
  }

  private void cbProducers_BeforeDropDown(object sender, CancelEventArgs e)
  {
    if (!this._onlyShowActiveStatus)
      return;
    foreach (UltraGridRow row in ((UltraGridBase) this.cbProducers).Rows)
      row.Hidden = Conversions.ToInteger(row.Cells["StatusID"].Value) != 1 || Conversions.ToInteger(row.Cells["ProducerContactStatusID"].Value) != 1;
  }
}
