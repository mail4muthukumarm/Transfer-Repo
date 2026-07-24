// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.NoteDocuments.GlobalNotesSetupFormML
// Assembly: MgaSystems.IMS.NotesDocuments, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 3F898CF7-066D-4B05-A9F1-D37DBC4FAA16
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.NotesDocuments.dll

using Infragistics.Shared;
using Infragistics.Win;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using Infragistics.Win.UltraWinTabControl;
using Infragistics.Win.UltraWinTabs;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.IMS.NoteDocuments.NoteDiarySystem;
using MGASystems.Tools;
using MGASystems.Tools.DBSaveUI;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Xml;

#nullable disable
namespace MGASystems.IMS.NoteDocuments;

[DesignerGenerated]
[SecureResource("{20FD3E39-4F89-435c-8A34-DDA629B0E35E}", "View / Access Global Notes Admin Form", "Allows the user to view / access Global Notes Administration Form.", "User")]
public class GlobalNotesSetupFormML : Form
{
  private IContainer components;
  private bool _isNewNoteEvent;
  private MemoryStream _gridLayout;
  private RequiredFieldValidator _mainValidator;
  private ObservableCollection<GlobalNoteAutomationRecipient> recipientList;
  public const string CanViewGlobalNotesAdminForm = "{20FD3E39-4F89-435c-8A34-DDA629B0E35E}";

  public GlobalNotesSetupFormML()
  {
    this.Load += new EventHandler(this.GlobalNotesSetupForm_Load);
    this.InitializeComponent();
  }

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
    UltraGridBand ultraGridBand1 = new UltraGridBand("tblAutomationLines", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("NoteAutomationID");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("LineGuid");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("LineName");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("Active");
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
    UltraTab ultraTab1 = new UltraTab();
    Appearance appearance15 = new Appearance();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (GlobalNotesSetupFormML));
    UltraTab ultraTab2 = new UltraTab();
    Appearance appearance16 = new Appearance();
    Appearance appearance17 = new Appearance();
    UltraGridBand ultraGridBand2 = new UltraGridBand("tblCreatedEvents", -1);
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("NoteAutomationId");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("Event Type", -1, (object) null, 78751204, 0, 0);
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("State", -1, (object) null, 78751204, 5, 0);
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("Line", -1, (object) null, 78751204, 2, 0);
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("Producer", -1, (object) null, 78751204, 3, 0);
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("ProducerLoc", -1, (object) null, 78751204, 4, 0);
    UltraGridColumn ultraGridColumn11 = new UltraGridColumn("Company", -1, (object) null, 78751204, 1, 0);
    UltraGridColumn ultraGridColumn12 = new UltraGridColumn("Subject", -1, (object) null, 78751204, 8, 1);
    UltraGridColumn ultraGridColumn13 = new UltraGridColumn("Body", -1, (object) null, 78751204, 9, 1);
    UltraGridColumn ultraGridColumn14 = new UltraGridColumn("Due In Days", -1, (object) null, 78751204, 10, 1);
    UltraGridColumn ultraGridColumn15 = new UltraGridColumn("Recipient", -1, (object) null, 78751204, 11, 1);
    UltraGridColumn ultraGridColumn16 = new UltraGridColumn("Popup", -1, (object) null, 78751204, 12, 1);
    UltraGridColumn ultraGridColumn17 = new UltraGridColumn("Type", -1, (object) null, 78751204, 13, 1);
    UltraGridColumn ultraGridColumn18 = new UltraGridColumn("Diary Start", -1, (object) null, 78751204, 14, 1);
    UltraGridColumn ultraGridColumn19 = new UltraGridColumn("EntryDataLoaded");
    UltraGridColumn ultraGridColumn20 = new UltraGridColumn("Licence Type", -1, (object) null, 78751204, 6, 0);
    UltraGridColumn ultraGridColumn21 = new UltraGridColumn("Document Template", -1, (object) null, 78751204, 7, 0);
    UltraGridColumn ultraGridColumn22 = new UltraGridColumn("IncludeEmail");
    UltraGridColumn ultraGridColumn23 = new UltraGridColumn("Mandatory");
    UltraGridColumn ultraGridColumn24 = new UltraGridColumn("RequiredToBind");
    UltraGridGroup ultraGridGroup = new UltraGridGroup("NewGroup0", 78751204);
    Appearance appearance18 = new Appearance();
    Appearance appearance19 = new Appearance();
    Appearance appearance20 = new Appearance();
    ScrollBarLook scrollBarLook2 = new ScrollBarLook();
    this.PolicyTabPage = new UltraTabPageControl();
    this.lblStatusReason = new Label();
    this.cboStatusReason = new MGASimpleComboBox();
    this.ContextMenuStrip1 = new ContextMenuStrip(this.components);
    this.ResetMenuItem = new ToolStripMenuItem();
    this.chkMandatory = new CheckBox();
    this.Label21 = new Label();
    this.dgAdditionalLines = new UltraGrid();
    this.cboProducer = new MGASimpleComboBox();
    this.Label20 = new Label();
    this.cboTemplateDocument = new MGASimpleComboBox();
    this.Label19 = new Label();
    this.cboLicenceType = new MGASimpleComboBox();
    this.chkNeverExpires = new CheckBox();
    this.Label18 = new Label();
    this.dtExpiration = new MGADateTimePicker();
    this.cboAutomationEvent = new MGASimpleComboBox();
    this.Label17 = new Label();
    this.Label10 = new Label();
    this.dtEffective = new MGADateTimePicker();
    this.Label7 = new Label();
    this.cboUnderwriter = new MGASimpleComboBox();
    this.Label8 = new Label();
    this.cboIssuingOffice = new MGASimpleComboBox();
    this.Label9 = new Label();
    this.cboPolicyType = new MGASimpleComboBox();
    this.Label4 = new Label();
    this.cboCompany = new MGASimpleComboBox();
    this.cboProducerLoc = new MGASimpleComboBox();
    this.cboState = new MGASimpleComboBox();
    this.cboLine = new MGASimpleComboBox();
    this.Label5 = new Label();
    this.cboOffices = new MGASimpleComboBox();
    this.Label6 = new Label();
    this.cboInHouseProducers = new MGASimpleComboBox();
    this.Label1 = new Label();
    this.Label2 = new Label();
    this.Label3 = new Label();
    this.dbSave = new MGASystems.Tools.DBSaveUI.DBSaveUI();
    this.NoteTabPage = new UltraTabPageControl();
    this.chkRequiredToBind = new MGACheckBox();
    this.pnlAdditionalRecipients = new Panel();
    this.btnAdditionalRecipients = new Button();
    this.txtAdditionalRecipients = new TextBox();
    this.Label22 = new Label();
    this.chkIncludeEmail = new MGACheckBox();
    this.cboDiaryStart = new MGASimpleComboBox();
    this.Label16 = new Label();
    this.popup = new MGACheckBox();
    this.cboNoteTypes = new MGASimpleComboBox();
    this.Label15 = new Label();
    this.cboNoteRecipients = new MGASimpleComboBox();
    this.Label14 = new Label();
    this.Label13 = new Label();
    this.dueInDays = new MGANumericEditor();
    this.Label12 = new Label();
    this.noteBody = new MGATextBox();
    this.Label11 = new Label();
    this.noteSubject = new MGATextBox();
    this.cnSQL = DefaultDatabase.CreateDbConnection();
    this.ToolTip1 = new ToolTip(this.components);
    this.daLoadData = DefaultDatabase.CreateDataAdapter();
    this.DbSelectCommand3 = DefaultDatabase.CreateCommand();
    this.UltraTabControl1 = new UltraTabControl();
    this.UltraTabSharedControlsPage1 = new UltraTabSharedControlsPage();
    this.InitialLoadBackgroundWorker = new BackgroundWorker();
    this.daCreatedEvents = DefaultDatabase.CreateDataAdapter();
    this.DbCommand1 = DefaultDatabase.CreateCommand();
    this.daLoadAutomationRows = DefaultDatabase.CreateDataAdapter();
    this.DbCommand2 = DefaultDatabase.CreateCommand();
    this.dgEvents = new UltraGrid();
    this.ds = new dsAdminGlobalNotes();
    this.dvMultipleLines = new DataView();
    this.dvUnderwriters = new DataView();
    this.dvOffices = new DataView();
    this.dvUsers = new DataView();
    this.dvIssuingOffices = new DataView();
    this.dvUnloadedEntries = new DataView();
    ((Control) this.PolicyTabPage).SuspendLayout();
    ((ISupportInitialize) this.cboStatusReason).BeginInit();
    this.ContextMenuStrip1.SuspendLayout();
    ((ISupportInitialize) this.dgAdditionalLines).BeginInit();
    ((ISupportInitialize) this.cboProducer).BeginInit();
    ((ISupportInitialize) this.cboTemplateDocument).BeginInit();
    ((ISupportInitialize) this.cboLicenceType).BeginInit();
    ((ISupportInitialize) this.dtExpiration).BeginInit();
    ((ISupportInitialize) this.cboAutomationEvent).BeginInit();
    ((ISupportInitialize) this.dtEffective).BeginInit();
    ((ISupportInitialize) this.cboUnderwriter).BeginInit();
    ((ISupportInitialize) this.cboIssuingOffice).BeginInit();
    ((ISupportInitialize) this.cboPolicyType).BeginInit();
    ((ISupportInitialize) this.cboCompany).BeginInit();
    ((ISupportInitialize) this.cboProducerLoc).BeginInit();
    ((ISupportInitialize) this.cboState).BeginInit();
    ((ISupportInitialize) this.cboLine).BeginInit();
    ((ISupportInitialize) this.cboOffices).BeginInit();
    ((ISupportInitialize) this.cboInHouseProducers).BeginInit();
    ((Control) this.NoteTabPage).SuspendLayout();
    ((ISupportInitialize) this.chkRequiredToBind).BeginInit();
    this.pnlAdditionalRecipients.SuspendLayout();
    ((ISupportInitialize) this.chkIncludeEmail).BeginInit();
    ((ISupportInitialize) this.cboDiaryStart).BeginInit();
    ((ISupportInitialize) this.popup).BeginInit();
    ((ISupportInitialize) this.cboNoteTypes).BeginInit();
    ((ISupportInitialize) this.cboNoteRecipients).BeginInit();
    ((ISupportInitialize) this.dueInDays).BeginInit();
    ((ISupportInitialize) this.noteBody).BeginInit();
    ((ISupportInitialize) this.noteSubject).BeginInit();
    ((ISupportInitialize) this.UltraTabControl1).BeginInit();
    ((Control) this.UltraTabControl1).SuspendLayout();
    ((Control) this.UltraTabSharedControlsPage1).SuspendLayout();
    ((ISupportInitialize) this.dgEvents).BeginInit();
    this.ds.BeginInit();
    this.dvMultipleLines.BeginInit();
    this.dvUnderwriters.BeginInit();
    this.dvOffices.BeginInit();
    this.dvUsers.BeginInit();
    this.dvIssuingOffices.BeginInit();
    this.dvUnloadedEntries.BeginInit();
    this.SuspendLayout();
    ((Control) this.PolicyTabPage).Controls.Add((Control) this.lblStatusReason);
    ((Control) this.PolicyTabPage).Controls.Add((Control) this.cboStatusReason);
    ((Control) this.PolicyTabPage).Controls.Add((Control) this.chkMandatory);
    ((Control) this.PolicyTabPage).Controls.Add((Control) this.Label21);
    ((Control) this.PolicyTabPage).Controls.Add((Control) this.dgAdditionalLines);
    ((Control) this.PolicyTabPage).Controls.Add((Control) this.cboProducer);
    ((Control) this.PolicyTabPage).Controls.Add((Control) this.Label20);
    ((Control) this.PolicyTabPage).Controls.Add((Control) this.cboTemplateDocument);
    ((Control) this.PolicyTabPage).Controls.Add((Control) this.Label19);
    ((Control) this.PolicyTabPage).Controls.Add((Control) this.cboLicenceType);
    ((Control) this.PolicyTabPage).Controls.Add((Control) this.chkNeverExpires);
    ((Control) this.PolicyTabPage).Controls.Add((Control) this.Label18);
    ((Control) this.PolicyTabPage).Controls.Add((Control) this.dtExpiration);
    ((Control) this.PolicyTabPage).Controls.Add((Control) this.cboAutomationEvent);
    ((Control) this.PolicyTabPage).Controls.Add((Control) this.Label17);
    ((Control) this.PolicyTabPage).Controls.Add((Control) this.Label10);
    ((Control) this.PolicyTabPage).Controls.Add((Control) this.dtEffective);
    ((Control) this.PolicyTabPage).Controls.Add((Control) this.Label7);
    ((Control) this.PolicyTabPage).Controls.Add((Control) this.cboUnderwriter);
    ((Control) this.PolicyTabPage).Controls.Add((Control) this.Label8);
    ((Control) this.PolicyTabPage).Controls.Add((Control) this.cboIssuingOffice);
    ((Control) this.PolicyTabPage).Controls.Add((Control) this.Label9);
    ((Control) this.PolicyTabPage).Controls.Add((Control) this.cboPolicyType);
    ((Control) this.PolicyTabPage).Controls.Add((Control) this.Label4);
    ((Control) this.PolicyTabPage).Controls.Add((Control) this.cboCompany);
    ((Control) this.PolicyTabPage).Controls.Add((Control) this.cboProducerLoc);
    ((Control) this.PolicyTabPage).Controls.Add((Control) this.cboState);
    ((Control) this.PolicyTabPage).Controls.Add((Control) this.cboLine);
    ((Control) this.PolicyTabPage).Controls.Add((Control) this.Label5);
    ((Control) this.PolicyTabPage).Controls.Add((Control) this.cboOffices);
    ((Control) this.PolicyTabPage).Controls.Add((Control) this.Label6);
    ((Control) this.PolicyTabPage).Controls.Add((Control) this.cboInHouseProducers);
    ((Control) this.PolicyTabPage).Controls.Add((Control) this.Label1);
    ((Control) this.PolicyTabPage).Controls.Add((Control) this.Label2);
    ((Control) this.PolicyTabPage).Controls.Add((Control) this.Label3);
    ((Control) this.PolicyTabPage).Controls.Add((Control) this.dbSave);
    ((Control) this.PolicyTabPage).Location = new Point(1, 26);
    ((Control) this.PolicyTabPage).Name = "PolicyTabPage";
    ((Control) this.PolicyTabPage).Size = new Size(760, 392);
    this.lblStatusReason.AutoSize = true;
    this.lblStatusReason.BackColor = Color.Transparent;
    this.lblStatusReason.Location = new Point(25, 305);
    this.lblStatusReason.Name = "lblStatusReason";
    this.lblStatusReason.Size = new Size(81, 13);
    this.lblStatusReason.TabIndex = 33;
    this.lblStatusReason.Text = "Status Reason:";
    this.lblStatusReason.TextAlign = ContentAlignment.MiddleRight;
    this.cboStatusReason.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.cboStatusReason).ContextMenuStrip = this.ContextMenuStrip1;
    this.cboStatusReason.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboStatusReason).Location = new Point(119, 301);
    this.cboStatusReason.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboStatusReason).Name = "cboStatusReason";
    ((Control) this.cboStatusReason).Size = new Size(336, 21);
    ((Control) this.cboStatusReason).TabIndex = 13;
    ((UltraControlBase) this.cboStatusReason).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboStatusReason).UseOsThemes = (DefaultableBoolean) 2;
    this.ContextMenuStrip1.Items.AddRange(new ToolStripItem[1]
    {
      (ToolStripItem) this.ResetMenuItem
    });
    this.ContextMenuStrip1.Name = "ContextMenuStrip1";
    this.ContextMenuStrip1.Size = new Size(119, 30);
    this.ResetMenuItem.Name = "ResetMenuItem";
    this.ResetMenuItem.Size = new Size(118, 26);
    this.ResetMenuItem.Text = "Reset";
    this.chkMandatory.AutoSize = true;
    this.chkMandatory.BackColor = Color.Transparent;
    this.chkMandatory.Location = new Point(229, 330);
    this.chkMandatory.Name = "chkMandatory";
    this.chkMandatory.Size = new Size(78, 17);
    this.chkMandatory.TabIndex = 15;
    this.chkMandatory.Text = "Mandatory";
    this.chkMandatory.UseVisualStyleBackColor = false;
    this.Label21.AutoSize = true;
    this.Label21.BackColor = Color.Transparent;
    this.Label21.Location = new Point(474, 38);
    this.Label21.Name = "Label21";
    this.Label21.Size = new Size(134, 13);
    this.Label21.TabIndex = 31 /*0x1F*/;
    this.Label21.Text = "Additional Lines: (optional)";
    this.Label21.TextAlign = ContentAlignment.MiddleRight;
    ((Control) this.dgAdditionalLines).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraControlBase) this.dgAdditionalLines).Cursor = Cursors.Hand;
    ((UltraGridBase) this.dgAdditionalLines).DataSource = (object) this.dvMultipleLines;
    appearance1.BackColor = Color.White;
    appearance1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.dgAdditionalLines).DisplayLayout.Appearance = (AppearanceBase) appearance1;
    ((UltraGridBase) this.dgAdditionalLines).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ((HeaderBase) ultraGridColumn1.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn1.Width = 113;
    ((HeaderBase) ultraGridColumn2.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn2.Header.VisiblePosition = 1;
    ultraGridColumn2.Hidden = true;
    ultraGridColumn2.Width = 117;
    ((HeaderBase) ultraGridColumn3.Header).Caption = "Line";
    ((HeaderBase) ultraGridColumn3.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn3.Header.VisiblePosition = 2;
    ultraGridColumn3.Width = 159;
    ((HeaderBase) ultraGridColumn4.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn4.Header.VisiblePosition = 3;
    ultraGridColumn4.Width = 98;
    ultraGridBand1.Columns.AddRange(new object[4]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3,
      (object) ultraGridColumn4
    });
    ultraGridBand1.GroupHeadersVisible = false;
    ultraGridBand1.Override.AllowRowFiltering = (DefaultableBoolean) 1;
    ((UltraGridBase) this.dgAdditionalLines).DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    ((UltraGridBase) this.dgAdditionalLines).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance2.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((UltraGridBase) this.dgAdditionalLines).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance2;
    ((UltraGridBase) this.dgAdditionalLines).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.dgAdditionalLines).DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 1;
    appearance3.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.dgAdditionalLines).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance3;
    ((UltraGridBase) this.dgAdditionalLines).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 2;
    appearance4.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.dgAdditionalLines).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance4;
    ((UltraGridBase) this.dgAdditionalLines).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((UltraGridBase) this.dgAdditionalLines).DisplayLayout.Override.RowSpacingAfter = 5;
    ((UltraGridBase) this.dgAdditionalLines).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance2;
    scrollBarLook1.ViewStyle = (ScrollBarViewStyle) 3;
    ((UltraGridBase) this.dgAdditionalLines).DisplayLayout.ScrollBarLook = scrollBarLook1;
    ((UltraGridBase) this.dgAdditionalLines).DisplayLayout.ScrollStyle = (ScrollStyle) 1;
    ((Control) this.dgAdditionalLines).Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.dgAdditionalLines).Location = new Point(477, 57);
    ((Control) this.dgAdditionalLines).Name = "dgAdditionalLines";
    ((Control) this.dgAdditionalLines).Size = new Size(259, 268);
    ((Control) this.dgAdditionalLines).TabIndex = 30;
    ((UltraControlBase) this.dgAdditionalLines).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dgAdditionalLines).UseOsThemes = (DefaultableBoolean) 2;
    this.cboProducer.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.cboProducer).ContextMenuStrip = this.ContextMenuStrip1;
    this.cboProducer.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboProducer).Location = new Point(119, 58);
    this.cboProducer.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboProducer).Name = "cboProducer";
    ((Control) this.cboProducer).Size = new Size(336, 21);
    ((Control) this.cboProducer).TabIndex = 2;
    ((UltraControlBase) this.cboProducer).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboProducer).UseOsThemes = (DefaultableBoolean) 2;
    this.Label20.AutoSize = true;
    this.Label20.BackColor = Color.Transparent;
    this.Label20.Location = new Point(52, 62);
    this.Label20.Name = "Label20";
    this.Label20.Size = new Size(54, 13);
    this.Label20.TabIndex = 28;
    this.Label20.Text = "Producer:";
    this.Label20.TextAlign = ContentAlignment.MiddleRight;
    ((Control) this.cboTemplateDocument).Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    this.cboTemplateDocument.BorderStyle = (UIElementBorderStyle) 4;
    this.cboTemplateDocument.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboTemplateDocument).Location = new Point(477, 4);
    this.cboTemplateDocument.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboTemplateDocument).Name = "cboTemplateDocument";
    ((Control) this.cboTemplateDocument).Size = new Size(259, 21);
    ((Control) this.cboTemplateDocument).TabIndex = 27;
    ((UltraControlBase) this.cboTemplateDocument).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboTemplateDocument).UseOsThemes = (DefaultableBoolean) 2;
    this.Label19.AutoSize = true;
    this.Label19.BackColor = Color.Transparent;
    this.Label19.Location = new Point(266, 278);
    this.Label19.Name = "Label19";
    this.Label19.Size = new Size(73, 13);
    this.Label19.TabIndex = 11;
    this.Label19.Text = "License Type:";
    this.Label19.TextAlign = ContentAlignment.MiddleRight;
    this.cboLicenceType.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.cboLicenceType).ContextMenuStrip = this.ContextMenuStrip1;
    this.cboLicenceType.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboLicenceType).Location = new Point(344, 274);
    this.cboLicenceType.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboLicenceType).Name = "cboLicenceType";
    ((Control) this.cboLicenceType).Size = new Size(111, 21);
    ((Control) this.cboLicenceType).TabIndex = 12;
    ((UltraControlBase) this.cboLicenceType).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboLicenceType).UseOsThemes = (DefaultableBoolean) 2;
    this.chkNeverExpires.AutoSize = true;
    this.chkNeverExpires.BackColor = Color.Transparent;
    this.chkNeverExpires.Location = new Point(229, 356);
    this.chkNeverExpires.Name = "chkNeverExpires";
    this.chkNeverExpires.Size = new Size(93, 17);
    this.chkNeverExpires.TabIndex = 17;
    this.chkNeverExpires.Text = "Never Expires";
    this.chkNeverExpires.UseVisualStyleBackColor = false;
    this.Label18.AutoSize = true;
    this.Label18.BackColor = Color.Transparent;
    this.Label18.Location = new Point(21, 358);
    this.Label18.Name = "Label18";
    this.Label18.Size = new Size(85, 13);
    this.Label18.TabIndex = 22;
    this.Label18.Text = "Expiration Date:";
    this.Label18.TextAlign = ContentAlignment.MiddleRight;
    appearance5.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.dtExpiration.Appearance = (AppearanceBase) appearance5;
    appearance6.AlphaLevel = (short) 14;
    appearance6.BackColor = Color.FromArgb(0, 0, 246, 253);
    appearance6.BackColor2 = Color.FromArgb(133, 162, 221);
    appearance6.BackColorAlpha = (Alpha) 2;
    appearance6.BackGradientAlignment = (GradientAlignment) 4;
    appearance6.BackGradientStyle = (GradientStyle) 5;
    appearance6.BorderAlpha = (Alpha) 1;
    appearance6.BorderColor = Color.FromArgb(78, 122, 171);
    appearance6.ForeColor = Color.FromArgb(49, 85, 153);
    appearance6.ForegroundAlpha = (Alpha) 2;
    this.dtExpiration.ButtonAppearance = (AppearanceBase) appearance6;
    ((Control) this.dtExpiration).ContextMenuStrip = this.ContextMenuStrip1;
    this.dtExpiration.DateTime = new DateTime(2007, 6, 6, 0, 0, 0, 0);
    ((Control) this.dtExpiration).Location = new Point(119, 354);
    this.dtExpiration.MaxDate = new DateTime(2079, 6, 6, 0, 0, 0, 0);
    this.dtExpiration.MGAStyle = MGAStyles.Blue;
    this.dtExpiration.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
    ((Control) this.dtExpiration).Name = "dtExpiration";
    ((Control) this.dtExpiration).Size = new Size(91, 20);
    ((Control) this.dtExpiration).TabIndex = 16 /*0x10*/;
    ((UltraControlBase) this.dtExpiration).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dtExpiration).UseOsThemes = (DefaultableBoolean) 2;
    this.dtExpiration.Value = (object) new DateTime(2007, 6, 6, 0, 0, 0, 0);
    this.cboAutomationEvent.BorderStyle = (UIElementBorderStyle) 4;
    this.cboAutomationEvent.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboAutomationEvent).Location = new Point(119, 4);
    this.cboAutomationEvent.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboAutomationEvent).Name = "cboAutomationEvent";
    ((Control) this.cboAutomationEvent).Size = new Size(336, 21);
    ((Control) this.cboAutomationEvent).TabIndex = 0;
    ((UltraControlBase) this.cboAutomationEvent).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboAutomationEvent).UseOsThemes = (DefaultableBoolean) 2;
    this.Label17.AutoSize = true;
    this.Label17.BackColor = Color.Transparent;
    this.Label17.Location = new Point(67, 8);
    this.Label17.Name = "Label17";
    this.Label17.Size = new Size(39, 13);
    this.Label17.TabIndex = 0;
    this.Label17.Text = "Event:";
    this.Label10.AutoSize = true;
    this.Label10.BackColor = Color.Transparent;
    this.Label10.Location = new Point(52, 332);
    this.Label10.Name = "Label10";
    this.Label10.Size = new Size(54, 13);
    this.Label10.TabIndex = 20;
    this.Label10.Text = "Effective:";
    this.Label10.TextAlign = ContentAlignment.MiddleRight;
    appearance7.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.dtEffective.Appearance = (AppearanceBase) appearance7;
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
    this.dtEffective.ButtonAppearance = (AppearanceBase) appearance8;
    ((Control) this.dtEffective).ContextMenuStrip = this.ContextMenuStrip1;
    this.dtEffective.DateTime = new DateTime(2007, 6, 6, 0, 0, 0, 0);
    ((Control) this.dtEffective).Location = new Point(119, 328);
    this.dtEffective.MaxDate = new DateTime(2079, 6, 6, 0, 0, 0, 0);
    this.dtEffective.MGAStyle = MGAStyles.Blue;
    this.dtEffective.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
    ((Control) this.dtEffective).Name = "dtEffective";
    ((Control) this.dtEffective).Size = new Size(91, 20);
    ((Control) this.dtEffective).TabIndex = 14;
    ((UltraControlBase) this.dtEffective).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dtEffective).UseOsThemes = (DefaultableBoolean) 2;
    this.dtEffective.Value = (object) new DateTime(2007, 6, 6, 0, 0, 0, 0);
    this.Label7.AutoSize = true;
    this.Label7.BackColor = Color.Transparent;
    this.Label7.Location = new Point(38, 224 /*0xE0*/);
    this.Label7.Name = "Label7";
    this.Label7.Size = new Size(68, 13);
    this.Label7.TabIndex = 14;
    this.Label7.Text = "Underwriter:";
    this.Label7.TextAlign = ContentAlignment.MiddleRight;
    this.cboUnderwriter.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.cboUnderwriter).ContextMenuStrip = this.ContextMenuStrip1;
    this.cboUnderwriter.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboUnderwriter).Location = new Point(119, 220);
    this.cboUnderwriter.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboUnderwriter).Name = "cboUnderwriter";
    ((Control) this.cboUnderwriter).Size = new Size(336, 21);
    ((Control) this.cboUnderwriter).TabIndex = 8;
    ((UltraControlBase) this.cboUnderwriter).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboUnderwriter).UseOsThemes = (DefaultableBoolean) 2;
    this.Label8.AutoSize = true;
    this.Label8.BackColor = Color.Transparent;
    this.Label8.Location = new Point(29, 251);
    this.Label8.Name = "Label8";
    this.Label8.Size = new Size(77, 13);
    this.Label8.TabIndex = 16 /*0x10*/;
    this.Label8.Text = "Issuing Office:";
    this.Label8.TextAlign = ContentAlignment.MiddleRight;
    this.cboIssuingOffice.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.cboIssuingOffice).ContextMenuStrip = this.ContextMenuStrip1;
    this.cboIssuingOffice.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboIssuingOffice).Location = new Point(119, 247);
    this.cboIssuingOffice.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboIssuingOffice).Name = "cboIssuingOffice";
    ((Control) this.cboIssuingOffice).Size = new Size(336, 21);
    ((Control) this.cboIssuingOffice).TabIndex = 9;
    ((UltraControlBase) this.cboIssuingOffice).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboIssuingOffice).UseOsThemes = (DefaultableBoolean) 2;
    this.Label9.AutoSize = true;
    this.Label9.BackColor = Color.Transparent;
    this.Label9.Location = new Point(41, 278);
    this.Label9.Name = "Label9";
    this.Label9.Size = new Size(65, 13);
    this.Label9.TabIndex = 18;
    this.Label9.Text = "Policy Type:";
    this.Label9.TextAlign = ContentAlignment.MiddleRight;
    this.cboPolicyType.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.cboPolicyType).ContextMenuStrip = this.ContextMenuStrip1;
    this.cboPolicyType.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboPolicyType).Location = new Point(119, 274);
    this.cboPolicyType.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboPolicyType).Name = "cboPolicyType";
    ((Control) this.cboPolicyType).Size = new Size(136, 21);
    ((Control) this.cboPolicyType).TabIndex = 10;
    ((UltraControlBase) this.cboPolicyType).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboPolicyType).UseOsThemes = (DefaultableBoolean) 2;
    this.Label4.AutoSize = true;
    this.Label4.BackColor = Color.Transparent;
    this.Label4.Location = new Point(69, 143);
    this.Label4.Name = "Label4";
    this.Label4.Size = new Size(30, 13);
    this.Label4.TabIndex = 8;
    this.Label4.Text = "Line:";
    this.Label4.TextAlign = ContentAlignment.MiddleRight;
    this.cboCompany.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.cboCompany).ContextMenuStrip = this.ContextMenuStrip1;
    this.cboCompany.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboCompany).Location = new Point(119, 31 /*0x1F*/);
    this.cboCompany.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboCompany).Name = "cboCompany";
    ((Control) this.cboCompany).Size = new Size(336, 21);
    ((Control) this.cboCompany).TabIndex = 1;
    ((UltraControlBase) this.cboCompany).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboCompany).UseOsThemes = (DefaultableBoolean) 2;
    this.cboProducerLoc.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.cboProducerLoc).ContextMenuStrip = this.ContextMenuStrip1;
    this.cboProducerLoc.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboProducerLoc).Location = new Point(119, 85);
    this.cboProducerLoc.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboProducerLoc).Name = "cboProducerLoc";
    ((Control) this.cboProducerLoc).Size = new Size(336, 21);
    ((Control) this.cboProducerLoc).TabIndex = 3;
    ((UltraControlBase) this.cboProducerLoc).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboProducerLoc).UseOsThemes = (DefaultableBoolean) 2;
    this.cboState.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.cboState).ContextMenuStrip = this.ContextMenuStrip1;
    this.cboState.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboState).Location = new Point(119, 112 /*0x70*/);
    this.cboState.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboState).Name = "cboState";
    ((Control) this.cboState).Size = new Size(336, 21);
    ((Control) this.cboState).TabIndex = 4;
    ((UltraControlBase) this.cboState).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboState).UseOsThemes = (DefaultableBoolean) 2;
    this.cboLine.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.cboLine).ContextMenuStrip = this.ContextMenuStrip1;
    this.cboLine.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboLine).Location = new Point(119, 139);
    this.cboLine.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboLine).Name = "cboLine";
    ((Control) this.cboLine).Size = new Size(336, 21);
    ((Control) this.cboLine).TabIndex = 5;
    ((UltraControlBase) this.cboLine).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboLine).UseOsThemes = (DefaultableBoolean) 2;
    this.Label5.AutoSize = true;
    this.Label5.BackColor = Color.Transparent;
    this.Label5.Location = new Point(66, 170);
    this.Label5.Name = "Label5";
    this.Label5.Size = new Size(40, 13);
    this.Label5.TabIndex = 10;
    this.Label5.Text = "Office:";
    this.Label5.TextAlign = ContentAlignment.MiddleRight;
    this.cboOffices.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.cboOffices).ContextMenuStrip = this.ContextMenuStrip1;
    this.cboOffices.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboOffices).Location = new Point(119, 166);
    this.cboOffices.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboOffices).Name = "cboOffices";
    ((Control) this.cboOffices).Size = new Size(336, 21);
    ((Control) this.cboOffices).TabIndex = 6;
    ((UltraControlBase) this.cboOffices).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboOffices).UseOsThemes = (DefaultableBoolean) 2;
    this.Label6.AutoSize = true;
    this.Label6.BackColor = Color.Transparent;
    this.Label6.Location = new Point(5, 197);
    this.Label6.Name = "Label6";
    this.Label6.Size = new Size(101, 13);
    this.Label6.TabIndex = 12;
    this.Label6.Text = "In-House Producer:";
    this.Label6.TextAlign = ContentAlignment.MiddleRight;
    this.cboInHouseProducers.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.cboInHouseProducers).ContextMenuStrip = this.ContextMenuStrip1;
    this.cboInHouseProducers.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboInHouseProducers).Location = new Point(119, 193);
    this.cboInHouseProducers.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboInHouseProducers).Name = "cboInHouseProducers";
    ((Control) this.cboInHouseProducers).Size = new Size(336, 21);
    ((Control) this.cboInHouseProducers).TabIndex = 7;
    ((UltraControlBase) this.cboInHouseProducers).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboInHouseProducers).UseOsThemes = (DefaultableBoolean) 2;
    this.Label1.AutoSize = true;
    this.Label1.BackColor = Color.Transparent;
    this.Label1.Location = new Point(50, 35);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(56, 13);
    this.Label1.TabIndex = 2;
    this.Label1.Text = "Company:";
    this.Label1.TextAlign = ContentAlignment.MiddleRight;
    this.Label2.AutoSize = true;
    this.Label2.BackColor = Color.Transparent;
    this.Label2.Location = new Point(9, 89);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(97, 13);
    this.Label2.TabIndex = 4;
    this.Label2.Text = "Producer Location:";
    this.Label2.TextAlign = ContentAlignment.MiddleRight;
    this.Label3.AutoSize = true;
    this.Label3.BackColor = Color.Transparent;
    this.Label3.Location = new Point(69, 116);
    this.Label3.Name = "Label3";
    this.Label3.Size = new Size(37, 13);
    this.Label3.TabIndex = 6;
    this.Label3.Text = "State:";
    this.Label3.TextAlign = ContentAlignment.MiddleRight;
    this.dbSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.dbSave.AutoQueryRowCountOnLoad = false;
    this.dbSave.EditStyle = EditStyle.ShowEditButton;
    this.dbSave.FreezeEvents = false;
    this.dbSave.Location = new Point(344, 341);
    this.dbSave.Name = "dbSave";
    this.dbSave.Size = new Size(112 /*0x70*/, 40);
    this.dbSave.TabIndex = 10;
    this.dbSave.UIState = UIState.HasRecordsNotEditing;
    ((Control) this.NoteTabPage).Controls.Add((Control) this.chkRequiredToBind);
    ((Control) this.NoteTabPage).Controls.Add((Control) this.pnlAdditionalRecipients);
    ((Control) this.NoteTabPage).Controls.Add((Control) this.chkIncludeEmail);
    ((Control) this.NoteTabPage).Controls.Add((Control) this.cboDiaryStart);
    ((Control) this.NoteTabPage).Controls.Add((Control) this.Label16);
    ((Control) this.NoteTabPage).Controls.Add((Control) this.popup);
    ((Control) this.NoteTabPage).Controls.Add((Control) this.cboNoteTypes);
    ((Control) this.NoteTabPage).Controls.Add((Control) this.Label15);
    ((Control) this.NoteTabPage).Controls.Add((Control) this.cboNoteRecipients);
    ((Control) this.NoteTabPage).Controls.Add((Control) this.Label14);
    ((Control) this.NoteTabPage).Controls.Add((Control) this.Label13);
    ((Control) this.NoteTabPage).Controls.Add((Control) this.dueInDays);
    ((Control) this.NoteTabPage).Controls.Add((Control) this.Label12);
    ((Control) this.NoteTabPage).Controls.Add((Control) this.noteBody);
    ((Control) this.NoteTabPage).Controls.Add((Control) this.Label11);
    ((Control) this.NoteTabPage).Controls.Add((Control) this.noteSubject);
    ((Control) this.NoteTabPage).Location = new Point(-10000, -10000);
    ((Control) this.NoteTabPage).Name = "NoteTabPage";
    ((Control) this.NoteTabPage).Size = new Size(760, 392);
    appearance9.BorderColor = Color.Gray;
    appearance9.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkRequiredToBind).Appearance = (AppearanceBase) appearance9;
    ((UltraToggleEditorBase) this.chkRequiredToBind).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkRequiredToBind).BackColorInternal = Color.Transparent;
    ((UltraToggleEditorBase) this.chkRequiredToBind).CheckAlign = ContentAlignment.MiddleRight;
    ((UltraToggleEditorBase) this.chkRequiredToBind).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkRequiredToBind).Location = new Point(199, 246);
    ((Control) this.chkRequiredToBind).Name = "chkRequiredToBind";
    ((Control) this.chkRequiredToBind).Size = new Size(196, 20);
    ((Control) this.chkRequiredToBind).TabIndex = 13;
    ((UltraToggleEditorBase) this.chkRequiredToBind).Text = "Completed Note Required to Bind";
    ((UltraControlBase) this.chkRequiredToBind).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkRequiredToBind).UseOsThemes = (DefaultableBoolean) 2;
    this.pnlAdditionalRecipients.Controls.Add((Control) this.btnAdditionalRecipients);
    this.pnlAdditionalRecipients.Controls.Add((Control) this.txtAdditionalRecipients);
    this.pnlAdditionalRecipients.Controls.Add((Control) this.Label22);
    this.pnlAdditionalRecipients.Location = new Point(509, 15);
    this.pnlAdditionalRecipients.Name = "pnlAdditionalRecipients";
    this.pnlAdditionalRecipients.Size = new Size(200, 225);
    this.pnlAdditionalRecipients.TabIndex = 12;
    this.btnAdditionalRecipients.Location = new Point(22, 194);
    this.btnAdditionalRecipients.Name = "btnAdditionalRecipients";
    this.btnAdditionalRecipients.Size = new Size(156, 23);
    this.btnAdditionalRecipients.TabIndex = 2;
    this.btnAdditionalRecipients.Text = "Edit Additional Recipients";
    this.btnAdditionalRecipients.UseVisualStyleBackColor = true;
    this.txtAdditionalRecipients.Location = new Point(7, 26);
    this.txtAdditionalRecipients.Multiline = true;
    this.txtAdditionalRecipients.Name = "txtAdditionalRecipients";
    this.txtAdditionalRecipients.ReadOnly = true;
    this.txtAdditionalRecipients.ScrollBars = ScrollBars.Vertical;
    this.txtAdditionalRecipients.Size = new Size(190, 164);
    this.txtAdditionalRecipients.TabIndex = 1;
    this.Label22.AutoSize = true;
    this.Label22.Location = new Point(4, 4);
    this.Label22.Name = "Label22";
    this.Label22.Size = new Size(106, 13);
    this.Label22.TabIndex = 0;
    this.Label22.Text = "Additional Recipients";
    appearance10.BorderColor = Color.Gray;
    appearance10.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkIncludeEmail).Appearance = (AppearanceBase) appearance10;
    ((UltraToggleEditorBase) this.chkIncludeEmail).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkIncludeEmail).BackColorInternal = Color.Transparent;
    ((UltraToggleEditorBase) this.chkIncludeEmail).CheckAlign = ContentAlignment.MiddleRight;
    ((UltraToggleEditorBase) this.chkIncludeEmail).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkIncludeEmail).Location = new Point(79, 246);
    ((Control) this.chkIncludeEmail).Name = "chkIncludeEmail";
    ((Control) this.chkIncludeEmail).Size = new Size(89, 20);
    ((Control) this.chkIncludeEmail).TabIndex = 9;
    ((UltraToggleEditorBase) this.chkIncludeEmail).Text = "Include Email";
    ((UltraControlBase) this.chkIncludeEmail).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkIncludeEmail).UseOsThemes = (DefaultableBoolean) 2;
    this.cboDiaryStart.BorderStyle = (UIElementBorderStyle) 4;
    this.cboDiaryStart.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboDiaryStart).Location = new Point(303, 160 /*0xA0*/);
    this.cboDiaryStart.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboDiaryStart).Name = "cboDiaryStart";
    ((Control) this.cboDiaryStart).Size = new Size(112 /*0x70*/, 21);
    ((Control) this.cboDiaryStart).TabIndex = 5;
    ((UltraControlBase) this.cboDiaryStart).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboDiaryStart).UseOsThemes = (DefaultableBoolean) 2;
    this.Label16.AutoSize = true;
    this.Label16.BackColor = Color.Transparent;
    this.Label16.Location = new Point(238, 160 /*0xA0*/);
    this.Label16.Name = "Label16";
    this.Label16.Size = new Size(59, 13);
    this.Label16.TabIndex = 4;
    this.Label16.Text = "Diary Start";
    appearance11.BorderColor = Color.Gray;
    appearance11.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.popup).Appearance = (AppearanceBase) appearance11;
    ((UltraToggleEditorBase) this.popup).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.popup).BackColorInternal = Color.Transparent;
    ((UltraToggleEditorBase) this.popup).CheckAlign = ContentAlignment.MiddleRight;
    ((UltraToggleEditorBase) this.popup).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.popup).Location = new Point(150, 158);
    ((Control) this.popup).Name = "popup";
    ((Control) this.popup).Size = new Size(56, 20);
    ((Control) this.popup).TabIndex = 3;
    ((UltraToggleEditorBase) this.popup).Text = "Popup";
    ((UltraControlBase) this.popup).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.popup).UseOsThemes = (DefaultableBoolean) 2;
    this.cboNoteTypes.BorderStyle = (UIElementBorderStyle) 4;
    this.cboNoteTypes.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboNoteTypes).Location = new Point(79, 219);
    this.cboNoteTypes.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboNoteTypes).Name = "cboNoteTypes";
    ((Control) this.cboNoteTypes).Size = new Size(336, 21);
    ((Control) this.cboNoteTypes).TabIndex = 7;
    ((UltraControlBase) this.cboNoteTypes).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboNoteTypes).UseOsThemes = (DefaultableBoolean) 2;
    this.Label15.AutoSize = true;
    this.Label15.BackColor = Color.Transparent;
    this.Label15.Location = new Point(3, 219);
    this.Label15.Name = "Label15";
    this.Label15.Size = new Size(31 /*0x1F*/, 13);
    this.Label15.TabIndex = 11;
    this.Label15.Text = "Type";
    this.cboNoteRecipients.BorderStyle = (UIElementBorderStyle) 4;
    this.cboNoteRecipients.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboNoteRecipients).Location = new Point(79, 192 /*0xC0*/);
    this.cboNoteRecipients.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboNoteRecipients).Name = "cboNoteRecipients";
    ((Control) this.cboNoteRecipients).Size = new Size(336, 21);
    ((Control) this.cboNoteRecipients).TabIndex = 6;
    ((UltraControlBase) this.cboNoteRecipients).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboNoteRecipients).UseOsThemes = (DefaultableBoolean) 2;
    this.Label14.AutoSize = true;
    this.Label14.BackColor = Color.Transparent;
    this.Label14.Location = new Point(3, 192 /*0xC0*/);
    this.Label14.Name = "Label14";
    this.Label14.Size = new Size(51, 13);
    this.Label14.TabIndex = 9;
    this.Label14.Text = "Recipient";
    this.Label13.AutoSize = true;
    this.Label13.BackColor = Color.Transparent;
    this.Label13.Location = new Point(3, 161);
    this.Label13.Name = "Label13";
    this.Label13.Size = new Size(66, 13);
    this.Label13.TabIndex = 4;
    this.Label13.Text = "Due In Days";
    appearance12.BorderColor = Color.Gray;
    ((UltraNumericEditorBase) this.dueInDays).Appearance = (AppearanceBase) appearance12;
    ((Control) this.dueInDays).Location = new Point(79, 158);
    this.dueInDays.MaskInput = "nnnn";
    this.dueInDays.MaxValue = (object) 999;
    this.dueInDays.MinValue = (object) -999;
    ((Control) this.dueInDays).Name = "dueInDays";
    ((UltraNumericEditorBase) this.dueInDays).PromptChar = ' ';
    ((Control) this.dueInDays).Size = new Size(37, 20);
    ((Control) this.dueInDays).TabIndex = 2;
    ((UltraControlBase) this.dueInDays).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dueInDays).UseOsThemes = (DefaultableBoolean) 2;
    this.Label12.AutoSize = true;
    this.Label12.BackColor = Color.Transparent;
    this.Label12.Location = new Point(3, 41);
    this.Label12.Name = "Label12";
    this.Label12.Size = new Size(31 /*0x1F*/, 13);
    this.Label12.TabIndex = 2;
    this.Label12.Text = "Body";
    appearance13.BackColor = Color.White;
    appearance13.BorderColor = Color.Gray;
    appearance13.ForeColor = Color.Black;
    ((TextEditorControlBase) this.noteBody).Appearance = (AppearanceBase) appearance13;
    ((TextEditorControlBase) this.noteBody).BackColor = Color.White;
    ((Control) this.noteBody).Location = new Point(79, 41);
    ((TextEditorControlBase) this.noteBody).MaxLength = 500;
    this.noteBody.Multiline = true;
    ((Control) this.noteBody).Name = "noteBody";
    this.noteBody.Scrollbars = ScrollBars.Vertical;
    ((Control) this.noteBody).Size = new Size(340, 111);
    ((Control) this.noteBody).TabIndex = 1;
    ((UltraControlBase) this.noteBody).TextRenderingMode = (TextRenderingMode) 2;
    ((UltraControlBase) this.noteBody).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.noteBody).UseOsThemes = (DefaultableBoolean) 2;
    this.Label11.AutoSize = true;
    this.Label11.BackColor = Color.Transparent;
    this.Label11.Location = new Point(3, 15);
    this.Label11.Name = "Label11";
    this.Label11.Size = new Size(43, 13);
    this.Label11.TabIndex = 0;
    this.Label11.Text = "Subject";
    appearance14.BackColor = Color.White;
    appearance14.BorderColor = Color.Gray;
    appearance14.ForeColor = Color.Black;
    ((TextEditorControlBase) this.noteSubject).Appearance = (AppearanceBase) appearance14;
    ((TextEditorControlBase) this.noteSubject).BackColor = Color.White;
    ((Control) this.noteSubject).Location = new Point(79, 15);
    ((TextEditorControlBase) this.noteSubject).MaxLength = 200;
    ((Control) this.noteSubject).Name = "noteSubject";
    ((Control) this.noteSubject).Size = new Size(340, 20);
    ((Control) this.noteSubject).TabIndex = 0;
    ((UltraControlBase) this.noteSubject).TextRenderingMode = (TextRenderingMode) 2;
    ((UltraControlBase) this.noteSubject).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.noteSubject).UseOsThemes = (DefaultableBoolean) 2;
    this.daLoadData.SelectCommand = this.DbSelectCommand3;
    this.daLoadData.TableMappings.AddRange(new DataTableMapping[14]
    {
      new DataTableMapping("Table1", "tblProducerLocations", new DataColumnMapping[2]
      {
        new DataColumnMapping("ProducerLocationGuid", "ProducerLocationGuid"),
        new DataColumnMapping("Name", "Name")
      }),
      new DataTableMapping("Table2", "lstStates", new DataColumnMapping[2]
      {
        new DataColumnMapping("StateID", "StateID"),
        new DataColumnMapping("State", "State")
      }),
      new DataTableMapping("Table3", "lstLines", new DataColumnMapping[2]
      {
        new DataColumnMapping("LineGuid", "LineGuid"),
        new DataColumnMapping("LineName", "LineName")
      }),
      new DataTableMapping("Table4", "tblClientOffices", new DataColumnMapping[2]
      {
        new DataColumnMapping("OfficeGuid", "OfficeGuid"),
        new DataColumnMapping("Location", "Location")
      }),
      new DataTableMapping("Table6", "lstPolicyTypes", new DataColumnMapping[2]
      {
        new DataColumnMapping("PolicyTypeID", "PolicyTypeID"),
        new DataColumnMapping("Description", "Description")
      }),
      new DataTableMapping("Table", "tblCompanyLocations", new DataColumnMapping[2]
      {
        new DataColumnMapping("CompanyLocationGuid", "CompanyLocationGuid"),
        new DataColumnMapping("Name", "Name")
      }),
      new DataTableMapping("Table5", "tblUsers", new DataColumnMapping[0]),
      new DataTableMapping("Table7", "lstNoteAutomationRecipients", new DataColumnMapping[0]),
      new DataTableMapping("Table8", "lstnotetypes", new DataColumnMapping[0]),
      new DataTableMapping("Table9", "lstAutomationDocumentEvents", new DataColumnMapping[0]),
      new DataTableMapping("Table10", "lstDiaryStartTypes", new DataColumnMapping[0]),
      new DataTableMapping("Table11", "lstLicenceTypes", new DataColumnMapping[0]),
      new DataTableMapping("Table12", "tblDocumentTemplates", new DataColumnMapping[2]
      {
        new DataColumnMapping("TemplateID", "TemplateID"),
        new DataColumnMapping("TemplateName", "TemplateName")
      }),
      new DataTableMapping("Table13", "tblProducers", new DataColumnMapping[2]
      {
        new DataColumnMapping("ProducerGUID", "ProducerGUID"),
        new DataColumnMapping("ProducerName", "ProducerName")
      })
    });
    this.DbSelectCommand3.CommandText = "dbo.NoteSystem_GlobalAdminLoadData";
    this.DbSelectCommand3.CommandType = CommandType.StoredProcedure;
    this.DbSelectCommand3.Connection = this.cnSQL;
    this.DbSelectCommand3.Parameters.AddRange((Array) new DbParameter[1]
    {
      DefaultDatabase.CreateParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, false, (byte) 0, (byte) 0, "", DataRowVersion.Current, (object) null)
    });
    ((Control) this.UltraTabControl1).Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraTabControlBase) this.UltraTabControl1).BackColorInternal = Color.White;
    ((Control) this.UltraTabControl1).Controls.Add((Control) this.UltraTabSharedControlsPage1);
    ((Control) this.UltraTabControl1).Controls.Add((Control) this.PolicyTabPage);
    ((Control) this.UltraTabControl1).Controls.Add((Control) this.NoteTabPage);
    ((Control) this.UltraTabControl1).Location = new Point(12, 280);
    ((Control) this.UltraTabControl1).Name = "UltraTabControl1";
    ((UltraTabControlBase) this.UltraTabControl1).SharedControls.AddRange(new Control[1]
    {
      (Control) this.dbSave
    });
    ((UltraTabControlBase) this.UltraTabControl1).SharedControlsPage = this.UltraTabSharedControlsPage1;
    ((Control) this.UltraTabControl1).Size = new Size(762, 419);
    ((Control) this.UltraTabControl1).TabIndex = 0;
    ((UltraTabControlBase) this.UltraTabControl1).TabLayoutStyle = (TabLayoutStyle) 1;
    ((UltraTabControlBase) this.UltraTabControl1).TabPadding = new Size(5, 3);
    appearance15.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance15.Image"));
    ultraTab1.Appearance = (AppearanceBase) appearance15;
    ultraTab1.Key = "POLICYINFO";
    ultraTab1.TabPage = this.PolicyTabPage;
    ultraTab1.Text = "Policy Info";
    appearance16.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance16.Image"));
    ultraTab2.Appearance = (AppearanceBase) appearance16;
    ultraTab2.Key = "NOTE";
    ultraTab2.TabPage = this.NoteTabPage;
    ultraTab2.Text = "Note";
    ((UltraTabControlBase) this.UltraTabControl1).Tabs.AddRange(new UltraTab[2]
    {
      ultraTab1,
      ultraTab2
    });
    ((UltraTabControlBase) this.UltraTabControl1).TabSize = new Size(125, 0);
    ((UltraTabControlBase) this.UltraTabControl1).ViewStyle = (ViewStyle) 4;
    ((Control) this.UltraTabSharedControlsPage1).Controls.Add((Control) this.dbSave);
    ((Control) this.UltraTabSharedControlsPage1).Location = new Point(-10000, -10000);
    ((Control) this.UltraTabSharedControlsPage1).Name = "UltraTabSharedControlsPage1";
    ((Control) this.UltraTabSharedControlsPage1).Size = new Size(760, 392);
    this.daCreatedEvents.SelectCommand = this.DbCommand1;
    this.daCreatedEvents.TableMappings.AddRange(new DataTableMapping[11]
    {
      new DataTableMapping("Table1", "tblProducerLocations", new DataColumnMapping[2]
      {
        new DataColumnMapping("ProducerLocationGuid", "ProducerLocationGuid"),
        new DataColumnMapping("Name", "Name")
      }),
      new DataTableMapping("Table2", "lstStates", new DataColumnMapping[2]
      {
        new DataColumnMapping("StateID", "StateID"),
        new DataColumnMapping("State", "State")
      }),
      new DataTableMapping("Table3", "lstLines", new DataColumnMapping[2]
      {
        new DataColumnMapping("LineGuid", "LineGuid"),
        new DataColumnMapping("LineName", "LineName")
      }),
      new DataTableMapping("Table4", "tblClientOffices", new DataColumnMapping[2]
      {
        new DataColumnMapping("OfficeGuid", "OfficeGuid"),
        new DataColumnMapping("Location", "Location")
      }),
      new DataTableMapping("Table6", "lstPolicyTypes", new DataColumnMapping[2]
      {
        new DataColumnMapping("PolicyTypeID", "PolicyTypeID"),
        new DataColumnMapping("Description", "Description")
      }),
      new DataTableMapping("Table", "tblCreatedEvents", new DataColumnMapping[2]
      {
        new DataColumnMapping("CompanyLocationGuid", "CompanyLocationGuid"),
        new DataColumnMapping("Name", "Name")
      }),
      new DataTableMapping("Table5", "tblUsers", new DataColumnMapping[0]),
      new DataTableMapping("Table7", "lstNoteAutomationRecipients", new DataColumnMapping[0]),
      new DataTableMapping("Table8", "lstnotetypes", new DataColumnMapping[0]),
      new DataTableMapping("Table9", "lstAutomationDocumentEvents", new DataColumnMapping[0]),
      new DataTableMapping("Table10", "lstDiaryStartTypes", new DataColumnMapping[0])
    });
    this.DbCommand1.CommandText = "dbo.NoteSystem_GlobalAdminLoadCreatedEvents";
    this.DbCommand1.CommandType = CommandType.StoredProcedure;
    this.DbCommand1.Connection = this.cnSQL;
    this.DbCommand1.Parameters.AddRange((Array) new DbParameter[2]
    {
      DefaultDatabase.CreateParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, false, (byte) 0, (byte) 0, "", DataRowVersion.Current, (object) null),
      DefaultDatabase.CreateParameter("@nullEventName", SqlDbType.VarChar, 40)
    });
    this.daLoadAutomationRows.SelectCommand = this.DbCommand2;
    this.daLoadAutomationRows.TableMappings.AddRange(new DataTableMapping[11]
    {
      new DataTableMapping("Table1", "tblProducerLocations", new DataColumnMapping[2]
      {
        new DataColumnMapping("ProducerLocationGuid", "ProducerLocationGuid"),
        new DataColumnMapping("Name", "Name")
      }),
      new DataTableMapping("Table2", "lstStates", new DataColumnMapping[2]
      {
        new DataColumnMapping("StateID", "StateID"),
        new DataColumnMapping("State", "State")
      }),
      new DataTableMapping("Table3", "lstLines", new DataColumnMapping[2]
      {
        new DataColumnMapping("LineGuid", "LineGuid"),
        new DataColumnMapping("LineName", "LineName")
      }),
      new DataTableMapping("Table4", "tblClientOffices", new DataColumnMapping[2]
      {
        new DataColumnMapping("OfficeGuid", "OfficeGuid"),
        new DataColumnMapping("Location", "Location")
      }),
      new DataTableMapping("Table6", "lstPolicyTypes", new DataColumnMapping[2]
      {
        new DataColumnMapping("PolicyTypeID", "PolicyTypeID"),
        new DataColumnMapping("Description", "Description")
      }),
      new DataTableMapping("Table5", "tblUsers", new DataColumnMapping[0]),
      new DataTableMapping("Table7", "lstNoteAutomationRecipients", new DataColumnMapping[0]),
      new DataTableMapping("Table8", "lstnotetypes", new DataColumnMapping[0]),
      new DataTableMapping("Table9", "lstAutomationDocumentEvents", new DataColumnMapping[0]),
      new DataTableMapping("Table10", "lstDiaryStartTypes", new DataColumnMapping[0]),
      new DataTableMapping("Table", "tblGlobalNoteAutomation", new DataColumnMapping[19]
      {
        new DataColumnMapping("NoteAutomationID", "NoteAutomationID"),
        new DataColumnMapping("EventGuid", "EventGuid"),
        new DataColumnMapping("StateID", "StateID"),
        new DataColumnMapping("LineGuid", "LineGuid"),
        new DataColumnMapping("ProducerLocationGuid", "ProducerLocationGuid"),
        new DataColumnMapping("CompanyLocationGuid", "CompanyLocationGuid"),
        new DataColumnMapping("InHouseProducerGuid", "InHouseProducerGuid"),
        new DataColumnMapping("OfficeLocationGuid", "OfficeLocationGuid"),
        new DataColumnMapping("UnderwriterGuid", "UnderwriterGuid"),
        new DataColumnMapping("IssuingOfficeGuid", "IssuingOfficeGuid"),
        new DataColumnMapping("PolicyTypeID", "PolicyTypeID"),
        new DataColumnMapping("Effective", "Effective"),
        new DataColumnMapping("NoteSubject", "NoteSubject"),
        new DataColumnMapping("NoteBody", "NoteBody"),
        new DataColumnMapping("DueInDays", "DueInDays"),
        new DataColumnMapping("NoteAutomationRecipientID", "NoteAutomationRecipientID"),
        new DataColumnMapping("Popup", "Popup"),
        new DataColumnMapping("Type", "Type"),
        new DataColumnMapping("DiaryStartDateID", "DiaryStartDateID")
      })
    });
    this.DbCommand2.CommandText = "NoteSystem_GlobalAdminFetchNoteAutomationData";
    this.DbCommand2.CommandType = CommandType.StoredProcedure;
    this.DbCommand2.Connection = this.cnSQL;
    this.DbCommand2.Parameters.AddRange((Array) new DbParameter[2]
    {
      DefaultDatabase.CreateParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, false, (byte) 0, (byte) 0, "", DataRowVersion.Current, (object) null),
      DefaultDatabase.CreateParameter("@noteAutomationIds", SqlDbType.Text, int.MaxValue)
    });
    ((Control) this.dgEvents).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraControlBase) this.dgEvents).Cursor = Cursors.Hand;
    ((UltraGridBase) this.dgEvents).DataMember = "tblCreatedEvents";
    ((UltraGridBase) this.dgEvents).DataSource = (object) this.ds;
    appearance17.BackColor = Color.White;
    appearance17.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.dgEvents).DisplayLayout.Appearance = (AppearanceBase) appearance17;
    ((UltraGridBase) this.dgEvents).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn5.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn5.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn5.Header.VisiblePosition = 0;
    ultraGridColumn5.Hidden = true;
    ultraGridColumn5.Width = 728;
    ultraGridColumn6.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn6.Width = 131;
    ultraGridColumn7.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn7.Width = 39;
    ultraGridColumn8.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn8.Width = 90;
    ultraGridColumn9.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn9.Width = 87;
    ultraGridColumn10.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn10.Header).Caption = "Producer Loc";
    ((HeaderBase) ultraGridColumn10.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn10.Width = 83;
    ultraGridColumn11.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn11.Width = 181;
    ultraGridColumn12.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn12.Width = 120;
    ultraGridColumn13.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn13.Width = 120;
    ultraGridColumn14.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn14.Width = 93;
    ultraGridColumn15.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn15.Width = 120;
    ultraGridColumn16.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn16.Width = 60;
    ultraGridColumn17.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn17.Width = 120;
    ultraGridColumn18.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn18.Width = (int) sbyte.MaxValue;
    ultraGridColumn19.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn19.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn19.Header.VisiblePosition = 16 /*0x10*/;
    ultraGridColumn19.Hidden = true;
    ultraGridColumn20.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn20.Width = 63 /*0x3F*/;
    ultraGridColumn21.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn21.Header).Caption = "Doc Template";
    ((HeaderBase) ultraGridColumn21.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn21.Width = 86;
    ((HeaderBase) ultraGridColumn22.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn22.Header.VisiblePosition = 17;
    ((HeaderBase) ultraGridColumn23.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn23.Header.VisiblePosition = 18;
    ((HeaderBase) ultraGridColumn24.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn24.Header.VisiblePosition = 19;
    ultraGridBand2.Columns.AddRange(new object[20]
    {
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
      (object) ultraGridColumn24
    });
    ultraGridBand2.GroupHeadersVisible = false;
    ((KeyedSubObjectBase) ultraGridGroup).Key = "NewGroup0";
    ultraGridBand2.Groups.AddRange(new UltraGridGroup[1]
    {
      ultraGridGroup
    });
    ultraGridBand2.LevelCount = 2;
    ultraGridBand2.Override.AllowRowFiltering = (DefaultableBoolean) 1;
    ((UltraGridBase) this.dgEvents).DisplayLayout.BandsSerializer.Add((object) ultraGridBand2);
    ((UltraGridBase) this.dgEvents).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance18.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance18.ForeColor = Color.Black;
    ((UltraGridBase) this.dgEvents).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance18;
    ((UltraGridBase) this.dgEvents).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.dgEvents).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((UltraGridBase) this.dgEvents).DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.dgEvents).DisplayLayout.Override.CellClickAction = (CellClickAction) 2;
    appearance19.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.dgEvents).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance19;
    ((UltraGridBase) this.dgEvents).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 2;
    appearance20.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.dgEvents).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance20;
    ((UltraGridBase) this.dgEvents).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((UltraGridBase) this.dgEvents).DisplayLayout.Override.RowSpacingAfter = 5;
    ((UltraGridBase) this.dgEvents).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance18;
    scrollBarLook2.ViewStyle = (ScrollBarViewStyle) 3;
    ((UltraGridBase) this.dgEvents).DisplayLayout.ScrollBarLook = scrollBarLook2;
    ((UltraGridBase) this.dgEvents).DisplayLayout.ScrollStyle = (ScrollStyle) 1;
    ((Control) this.dgEvents).Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.dgEvents).Location = new Point(12, 12);
    ((Control) this.dgEvents).Name = "dgEvents";
    ((Control) this.dgEvents).Size = new Size(762, 262);
    ((Control) this.dgEvents).TabIndex = 9;
    ((UltraControlBase) this.dgEvents).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dgEvents).UseOsThemes = (DefaultableBoolean) 2;
    this.ds.DataSetName = "dsAdminGlobalNotes";
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.dvMultipleLines.Table = (DataTable) this.ds.tblAutomationLines;
    this.dvUnderwriters.RowFilter = "IsUnderwriter = 1";
    this.dvUnderwriters.Table = (DataTable) this.ds.tblUsers;
    this.dvOffices.Table = (DataTable) this.ds.tblClientOffices;
    this.dvUsers.Table = (DataTable) this.ds.tblUsers;
    this.dvIssuingOffices.Table = (DataTable) this.ds.tblClientOffices;
    this.dvUnloadedEntries.RowFilter = "EntryDataLoaded=0";
    this.dvUnloadedEntries.Table = (DataTable) this.ds.tblCreatedEvents;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.WhiteSmoke;
    this.ClientSize = new Size(786, 711);
    this.Controls.Add((Control) this.dgEvents);
    this.Controls.Add((Control) this.UltraTabControl1);
    this.Font = new Font("Tahoma", 8.25f);
    this.Name = nameof (GlobalNotesSetupFormML);
    this.StartPosition = FormStartPosition.CenterParent;
    this.Text = "Admin Notes";
    ((Control) this.PolicyTabPage).ResumeLayout(false);
    ((Control) this.PolicyTabPage).PerformLayout();
    ((ISupportInitialize) this.cboStatusReason).EndInit();
    this.ContextMenuStrip1.ResumeLayout(false);
    ((ISupportInitialize) this.dgAdditionalLines).EndInit();
    ((ISupportInitialize) this.cboProducer).EndInit();
    ((ISupportInitialize) this.cboTemplateDocument).EndInit();
    ((ISupportInitialize) this.cboLicenceType).EndInit();
    ((ISupportInitialize) this.dtExpiration).EndInit();
    ((ISupportInitialize) this.cboAutomationEvent).EndInit();
    ((ISupportInitialize) this.dtEffective).EndInit();
    ((ISupportInitialize) this.cboUnderwriter).EndInit();
    ((ISupportInitialize) this.cboIssuingOffice).EndInit();
    ((ISupportInitialize) this.cboPolicyType).EndInit();
    ((ISupportInitialize) this.cboCompany).EndInit();
    ((ISupportInitialize) this.cboProducerLoc).EndInit();
    ((ISupportInitialize) this.cboState).EndInit();
    ((ISupportInitialize) this.cboLine).EndInit();
    ((ISupportInitialize) this.cboOffices).EndInit();
    ((ISupportInitialize) this.cboInHouseProducers).EndInit();
    ((Control) this.NoteTabPage).ResumeLayout(false);
    ((Control) this.NoteTabPage).PerformLayout();
    ((ISupportInitialize) this.chkRequiredToBind).EndInit();
    this.pnlAdditionalRecipients.ResumeLayout(false);
    this.pnlAdditionalRecipients.PerformLayout();
    ((ISupportInitialize) this.chkIncludeEmail).EndInit();
    ((ISupportInitialize) this.cboDiaryStart).EndInit();
    ((ISupportInitialize) this.popup).EndInit();
    ((ISupportInitialize) this.cboNoteTypes).EndInit();
    ((ISupportInitialize) this.cboNoteRecipients).EndInit();
    ((ISupportInitialize) this.dueInDays).EndInit();
    ((ISupportInitialize) this.noteBody).EndInit();
    ((ISupportInitialize) this.noteSubject).EndInit();
    ((ISupportInitialize) this.UltraTabControl1).EndInit();
    ((Control) this.UltraTabControl1).ResumeLayout(false);
    ((Control) this.UltraTabSharedControlsPage1).ResumeLayout(false);
    ((ISupportInitialize) this.dgEvents).EndInit();
    this.ds.EndInit();
    this.dvMultipleLines.EndInit();
    this.dvUnderwriters.EndInit();
    this.dvOffices.EndInit();
    this.dvUsers.EndInit();
    this.dvIssuingOffices.EndInit();
    this.dvUnloadedEntries.EndInit();
    this.ResumeLayout(false);
  }

  [field: AccessedThroughProperty("dvUnderwriters")]
  private virtual DataView dvUnderwriters { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("dvUsers")]
  private virtual DataView dvUsers { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cnSQL")]
  private virtual DbConnection cnSQL { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ToolTip1")]
  private virtual ToolTip ToolTip1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("daLoadData")]
  private virtual DbDataAdapter daLoadData { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("DbSelectCommand3")]
  private virtual DbCommand DbSelectCommand3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("dvOffices")]
  private virtual DataView dvOffices { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("dvIssuingOffices")]
  private virtual DataView dvIssuingOffices { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ds")]
  internal virtual dsAdminGlobalNotes ds { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual UltraTabControl UltraTabControl1
  {
    get => this._UltraTabControl1;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      ActiveTabChangedEventHandler changedEventHandler = new ActiveTabChangedEventHandler(this.UltraTabControl1_ActiveTabChanged);
      UltraTabControl ultraTabControl1_1 = this._UltraTabControl1;
      if (ultraTabControl1_1 != null)
        ((UltraTabControlBase) ultraTabControl1_1).ActiveTabChanged -= changedEventHandler;
      this._UltraTabControl1 = value;
      UltraTabControl ultraTabControl1_2 = this._UltraTabControl1;
      if (ultraTabControl1_2 == null)
        return;
      ((UltraTabControlBase) ultraTabControl1_2).ActiveTabChanged += changedEventHandler;
    }
  }

  [field: AccessedThroughProperty("UltraTabSharedControlsPage1")]
  private virtual UltraTabSharedControlsPage UltraTabSharedControlsPage1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual MGASystems.Tools.DBSaveUI.DBSaveUI dbSave
  {
    get => this._dbSave;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      CancelEventHandler cancelEventHandler1 = new CancelEventHandler(this.dbSave_ClickingDelete);
      QueryRowCountHandler queryRowCountHandler = new QueryRowCountHandler(this.dbSave_QueryRowCount);
      EventHandler eventHandler1 = new EventHandler(this.dbSave_ClickedCancel);
      EventHandler eventHandler2 = new EventHandler(this.dbSave_ClickedNew);
      CancelEventHandler cancelEventHandler2 = new CancelEventHandler(this.dbSave_ClickingSave);
      EventHandler eventHandler3 = new EventHandler(this.dbSave_UIStateChanged);
      EventHandler eventHandler4 = new EventHandler(this.dbSave_ClickedDelete);
      EventHandler eventHandler5 = new EventHandler(this.dbSave_ClickedEdit);
      EventHandler eventHandler6 = new EventHandler(this.dbSave_ClickedSave);
      MGASystems.Tools.DBSaveUI.DBSaveUI dbSave1 = this._dbSave;
      if (dbSave1 != null)
      {
        dbSave1.ClickingDelete -= cancelEventHandler1;
        dbSave1.QueryRowCount -= queryRowCountHandler;
        dbSave1.ClickedCancel -= eventHandler1;
        dbSave1.ClickedNew -= eventHandler2;
        dbSave1.ClickingSave -= cancelEventHandler2;
        dbSave1.UIStateChanged -= eventHandler3;
        dbSave1.ClickedDelete -= eventHandler4;
        dbSave1.ClickedEdit -= eventHandler5;
        dbSave1.ClickedSave -= eventHandler6;
      }
      this._dbSave = value;
      MGASystems.Tools.DBSaveUI.DBSaveUI dbSave2 = this._dbSave;
      if (dbSave2 == null)
        return;
      dbSave2.ClickingDelete += cancelEventHandler1;
      dbSave2.QueryRowCount += queryRowCountHandler;
      dbSave2.ClickedCancel += eventHandler1;
      dbSave2.ClickedNew += eventHandler2;
      dbSave2.ClickingSave += cancelEventHandler2;
      dbSave2.UIStateChanged += eventHandler3;
      dbSave2.ClickedDelete += eventHandler4;
      dbSave2.ClickedEdit += eventHandler5;
      dbSave2.ClickedSave += eventHandler6;
    }
  }

  [field: AccessedThroughProperty("PolicyTabPage")]
  private virtual UltraTabPageControl PolicyTabPage { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label10")]
  private virtual Label Label10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("dtEffective")]
  private virtual MGADateTimePicker dtEffective { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label7")]
  private virtual Label Label7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cboUnderwriter")]
  private virtual MGASimpleComboBox cboUnderwriter { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label8")]
  private virtual Label Label8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cboIssuingOffice")]
  private virtual MGASimpleComboBox cboIssuingOffice { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label9")]
  private virtual Label Label9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cboPolicyType")]
  private virtual MGASimpleComboBox cboPolicyType { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label4")]
  private virtual Label Label4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cboCompany")]
  private virtual MGASimpleComboBox cboCompany { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cboProducerLoc")]
  private virtual MGASimpleComboBox cboProducerLoc { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cboState")]
  private virtual MGASimpleComboBox cboState { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cboLine")]
  private virtual MGASimpleComboBox cboLine { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label5")]
  private virtual Label Label5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cboOffices")]
  private virtual MGASimpleComboBox cboOffices { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label6")]
  private virtual Label Label6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cboInHouseProducers")]
  private virtual MGASimpleComboBox cboInHouseProducers { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label1")]
  private virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label2")]
  private virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label3")]
  private virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("NoteTabPage")]
  private virtual UltraTabPageControl NoteTabPage { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual BackgroundWorker InitialLoadBackgroundWorker
  {
    get => this._InitialLoadBackgroundWorker;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      DoWorkEventHandler workEventHandler = new DoWorkEventHandler(this.InitialLoadBackgroundWorker_DoWork);
      RunWorkerCompletedEventHandler completedEventHandler = new RunWorkerCompletedEventHandler(this.InitialLoadBackgroundWorker_RunWorkerCompleted);
      BackgroundWorker backgroundWorker1 = this._InitialLoadBackgroundWorker;
      if (backgroundWorker1 != null)
      {
        backgroundWorker1.DoWork -= workEventHandler;
        backgroundWorker1.RunWorkerCompleted -= completedEventHandler;
      }
      this._InitialLoadBackgroundWorker = value;
      BackgroundWorker backgroundWorker2 = this._InitialLoadBackgroundWorker;
      if (backgroundWorker2 == null)
        return;
      backgroundWorker2.DoWork += workEventHandler;
      backgroundWorker2.RunWorkerCompleted += completedEventHandler;
    }
  }

  [field: AccessedThroughProperty("Label14")]
  internal virtual Label Label14 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label13")]
  internal virtual Label Label13 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("dueInDays")]
  internal virtual MGANumericEditor dueInDays { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label12")]
  internal virtual Label Label12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("noteBody")]
  internal virtual MGATextBox noteBody { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label11")]
  internal virtual Label Label11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("noteSubject")]
  internal virtual MGATextBox noteSubject { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label16")]
  internal virtual Label Label16 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("popup")]
  internal virtual MGACheckBox popup { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cboNoteTypes")]
  private virtual MGASimpleComboBox cboNoteTypes { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label15")]
  internal virtual Label Label15 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual MGASimpleComboBox cboNoteRecipients
  {
    get => this._cboNoteRecipients;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      InitializeLayoutEventHandler layoutEventHandler = new InitializeLayoutEventHandler(this.CboNoteRecipients_InitializeLayout);
      MGASimpleComboBox cboNoteRecipients1 = this._cboNoteRecipients;
      if (cboNoteRecipients1 != null)
        cboNoteRecipients1.InitializeLayout -= layoutEventHandler;
      this._cboNoteRecipients = value;
      MGASimpleComboBox cboNoteRecipients2 = this._cboNoteRecipients;
      if (cboNoteRecipients2 == null)
        return;
      cboNoteRecipients2.InitializeLayout += layoutEventHandler;
    }
  }

  [field: AccessedThroughProperty("cboDiaryStart")]
  private virtual MGASimpleComboBox cboDiaryStart { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual MGASimpleComboBox cboAutomationEvent
  {
    get => this._cboAutomationEvent;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.cboAutomationEvent_ValueChanged);
      MGASimpleComboBox cboAutomationEvent1 = this._cboAutomationEvent;
      if (cboAutomationEvent1 != null)
        cboAutomationEvent1.ValueChanged -= eventHandler;
      this._cboAutomationEvent = value;
      MGASimpleComboBox cboAutomationEvent2 = this._cboAutomationEvent;
      if (cboAutomationEvent2 == null)
        return;
      cboAutomationEvent2.ValueChanged += eventHandler;
    }
  }

  [field: AccessedThroughProperty("Label17")]
  internal virtual Label Label17 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("daCreatedEvents")]
  private virtual DbDataAdapter daCreatedEvents { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("DbCommand1")]
  private virtual DbCommand DbCommand1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual UltraGrid dgEvents
  {
    get => this._dgEvents;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.dgEvents_AfterRowActivate);
      UltraGrid dgEvents1 = this._dgEvents;
      if (dgEvents1 != null)
        dgEvents1.AfterRowActivate -= eventHandler;
      this._dgEvents = value;
      UltraGrid dgEvents2 = this._dgEvents;
      if (dgEvents2 == null)
        return;
      dgEvents2.AfterRowActivate += eventHandler;
    }
  }

  [field: AccessedThroughProperty("daLoadAutomationRows")]
  private virtual DbDataAdapter daLoadAutomationRows { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("DbCommand2")]
  private virtual DbCommand DbCommand2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("dvUnloadedEntries")]
  private virtual DataView dvUnloadedEntries { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ContextMenuStrip1")]
  internal virtual ContextMenuStrip ContextMenuStrip1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual ToolStripMenuItem ResetMenuItem
  {
    get => this._ResetMenuItem;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ResetMenuItem_Click);
      ToolStripMenuItem resetMenuItem1 = this._ResetMenuItem;
      if (resetMenuItem1 != null)
        resetMenuItem1.Click -= eventHandler;
      this._ResetMenuItem = value;
      ToolStripMenuItem resetMenuItem2 = this._ResetMenuItem;
      if (resetMenuItem2 == null)
        return;
      resetMenuItem2.Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("Label18")]
  private virtual Label Label18 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("dtExpiration")]
  private virtual MGADateTimePicker dtExpiration { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual CheckBox chkNeverExpires
  {
    get => this._chkNeverExpires;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.chkNeverExpires_CheckedChanged);
      CheckBox chkNeverExpires1 = this._chkNeverExpires;
      if (chkNeverExpires1 != null)
        chkNeverExpires1.CheckedChanged -= eventHandler;
      this._chkNeverExpires = value;
      CheckBox chkNeverExpires2 = this._chkNeverExpires;
      if (chkNeverExpires2 == null)
        return;
      chkNeverExpires2.CheckedChanged += eventHandler;
    }
  }

  [field: AccessedThroughProperty("Label19")]
  private virtual Label Label19 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cboLicenceType")]
  private virtual MGASimpleComboBox cboLicenceType { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cboTemplateDocument")]
  private virtual MGASimpleComboBox cboTemplateDocument { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cboProducer")]
  private virtual MGASimpleComboBox cboProducer { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label20")]
  private virtual Label Label20 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkIncludeEmail")]
  internal virtual MGACheckBox chkIncludeEmail { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("dgAdditionalLines")]
  private virtual UltraGrid dgAdditionalLines { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label21")]
  private virtual Label Label21 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("dvMultipleLines")]
  internal virtual DataView dvMultipleLines { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("pnlAdditionalRecipients")]
  internal virtual Panel pnlAdditionalRecipients { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual Button btnAdditionalRecipients
  {
    get => this._btnAdditionalRecipients;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnAdditionalRecipients_Click);
      Button additionalRecipients1 = this._btnAdditionalRecipients;
      if (additionalRecipients1 != null)
        additionalRecipients1.Click -= eventHandler;
      this._btnAdditionalRecipients = value;
      Button additionalRecipients2 = this._btnAdditionalRecipients;
      if (additionalRecipients2 == null)
        return;
      additionalRecipients2.Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("txtAdditionalRecipients")]
  internal virtual TextBox txtAdditionalRecipients { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label22")]
  internal virtual Label Label22 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkMandatory")]
  internal virtual CheckBox chkMandatory { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkRequiredToBind")]
  internal virtual MGACheckBox chkRequiredToBind { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblStatusReason")]
  private virtual Label lblStatusReason { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual MGASimpleComboBox cboStatusReason
  {
    get => this._cboStatusReason;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      CancelEventHandler cancelEventHandler = new CancelEventHandler(this.cboStatusReason_BeforeDropDown);
      MGASimpleComboBox cboStatusReason1 = this._cboStatusReason;
      if (cboStatusReason1 != null)
        cboStatusReason1.BeforeDropDown -= cancelEventHandler;
      this._cboStatusReason = value;
      MGASimpleComboBox cboStatusReason2 = this._cboStatusReason;
      if (cboStatusReason2 == null)
        return;
      cboStatusReason2.BeforeDropDown += cancelEventHandler;
    }
  }

  private void GlobalNotesSetupForm_Load(object sender, EventArgs e)
  {
    bool setting1 = SystemSettings.GetSetting<bool>("AdminNotes.AdditionalRecipients", false);
    this.pnlAdditionalRecipients.Visible = setting1;
    this.pnlAdditionalRecipients.Enabled = setting1;
    bool setting2 = SystemSettings.GetSetting<bool>("NoteAutomation.UseReqToBind", false);
    ((Control) this.chkRequiredToBind).Visible = setting2;
    ((Control) this.chkRequiredToBind).Enabled = setting2;
    this._gridLayout = new MemoryStream();
    ((UltraGridBase) this.dgEvents).DisplayLayout.Save((Stream) this._gridLayout);
    this._gridLayout.Position = 0L;
    ((UltraGridBase) this.dgEvents).DataSource = (object) null;
    this.EnableEntry(false);
    this.InitialLoadBackgroundWorker.RunWorkerAsync();
  }

  private void InitialLoadBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
  {
    DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[16 /*0x10*/]
    {
      "tblCompanyLocations",
      "tblProducerLocations",
      "lstStates",
      "lstLines",
      "tblClientOffices",
      "tblUsers",
      "lstPolicyTypes",
      "lstNoteAutomationRecipients",
      "lstnotetypes",
      "lstAutomationDocumentEvents",
      "lstDiaryStartTypes",
      "lstLicenceTypes",
      "tblDocumentTemplates",
      "tblProducers",
      "lstQuoteStatusReasons",
      "dtQuoteStatusEvents"
    }, "NoteSystem_GlobalAdminLoadData");
    this.ds.lstAutomationDocumentEvents.AddlstAutomationDocumentEventsRow(BroadcastMessages.TemplateDocumentInstanceCreated, "Template Document Created");
    this.daCreatedEvents.SelectCommand.Parameters["@nullEventName"].Value = (object) "Template Document Created";
    DefaultDatabase.DataAdapterFill(this.daCreatedEvents, (DataTable) this.ds.tblCreatedEvents);
  }

  private void InitialLoadBackgroundWorker_RunWorkerCompleted(
    object sender,
    RunWorkerCompletedEventArgs e)
  {
    ((UltraGridBase) this.dgEvents).DataMember = "tblCreatedEvents";
    ((UltraGridBase) this.dgEvents).DataSource = (object) this.ds;
    ((UltraGridBase) this.dgEvents).DisplayLayout.Load((Stream) this._gridLayout);
    this._gridLayout.Dispose();
    this._gridLayout = (MemoryStream) null;
    GlobalNotesSetupFormML.AttachComboDataSource(this.cboCompany, (object) this.ds.tblCompanyLocations, "CompanyLocationGuid", "Name");
    GlobalNotesSetupFormML.AttachComboDataSource(this.cboProducerLoc, (object) this.ds.tblProducerLocations, "ProducerLocationGuid", "Name");
    GlobalNotesSetupFormML.AttachComboDataSource(this.cboState, (object) this.ds.lstStates, "StateID", "State");
    GlobalNotesSetupFormML.AttachComboDataSource(this.cboLine, (object) this.ds.lstLines, "LineGuid", "LineName");
    GlobalNotesSetupFormML.AttachComboDataSource(this.cboOffices, (object) this.dvOffices, "OfficeGuid", "Location");
    GlobalNotesSetupFormML.AttachComboDataSource(this.cboInHouseProducers, (object) this.ds.tblUsers, "UserGuid", "UserName");
    GlobalNotesSetupFormML.AttachComboDataSource(this.cboUnderwriter, (object) this.dvUnderwriters, "UserGuid", "UserName");
    GlobalNotesSetupFormML.AttachComboDataSource(this.cboIssuingOffice, (object) this.dvIssuingOffices, "OfficeGuid", "Location");
    GlobalNotesSetupFormML.AttachComboDataSource(this.cboPolicyType, (object) this.ds.lstPolicyTypes, "PolicyTypeID", "Description");
    GlobalNotesSetupFormML.AttachComboDataSource(this.cboNoteRecipients, (object) this.ds.lstNoteAutomationRecipients, "NoteAutomationRecipientID", "RecipientName");
    GlobalNotesSetupFormML.AttachComboDataSource(this.cboNoteTypes, (object) this.ds.lstnotetypes, "NoteTypeID", "Description");
    GlobalNotesSetupFormML.AttachComboDataSource(this.cboAutomationEvent, (object) this.ds.lstAutomationDocumentEvents, "EventGuid", "EventName");
    GlobalNotesSetupFormML.AttachComboDataSource(this.cboDiaryStart, (object) this.ds.lstDiaryStartTypes, "DiaryStartTypeId", "Description");
    GlobalNotesSetupFormML.AttachComboDataSource(this.cboLicenceType, (object) this.ds.lstLicenceTypes, "CompanyLicenceTypeId", "CompanyLicenceType");
    GlobalNotesSetupFormML.AttachComboDataSource(this.cboTemplateDocument, (object) this.ds.tblDocumentTemplates, "TemplateID", "TemplateName");
    GlobalNotesSetupFormML.AttachComboDataSource(this.cboProducer, (object) this.ds.tblProducers, "ProducerGuid", "ProducerName");
    GlobalNotesSetupFormML.AttachComboDataSource(this.cboStatusReason, (object) this.ds.lstQuoteStatusReasons, "ID", "Reason");
    this.AttachRequiredFieldValidator((Control) this.noteSubject, "Text");
    this.AttachRequiredFieldValidator((Control) this.noteBody, "Text");
    this.AttachRequiredFieldValidator((Control) this.cboNoteRecipients, "Value");
    this.AttachRequiredFieldValidator((Control) this.cboNoteTypes, "Value");
    this.AttachRequiredFieldValidator((Control) this.cboAutomationEvent, "Value");
    this.AttachRequiredFieldValidator((Control) this.cboTemplateDocument, "Value");
    this.dbSave.ResetUI();
  }

  private void AttachRequiredFieldValidator(Control ctl, string field)
  {
    RequiredFieldValidator requiredFieldValidator = new RequiredFieldValidator();
    requiredFieldValidator.ValidationStyle = ValidationStyle.ValidateManual;
    requiredFieldValidator.ControlToValidate = ctl;
    requiredFieldValidator.FieldToValidate = field;
    this.components.Add((IComponent) requiredFieldValidator);
    if (this._mainValidator != null)
      return;
    this._mainValidator = requiredFieldValidator;
  }

  private void EnableRequiredFieldValidator(Control ctl, bool enable)
  {
    if (this.components == null)
      return;
    try
    {
      foreach (IComponent component in (ReadOnlyCollectionBase) this.components.Components)
      {
        if (component is RequiredFieldValidator requiredFieldValidator && requiredFieldValidator.ControlToValidate == ctl)
          requiredFieldValidator.Enabled = enable;
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private void dbSave_ClickingDelete(object sender, CancelEventArgs e)
  {
    e.Cancel = MessageBox.Show("Are you sure you want to remove the note(s)?", "Confirm note deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes;
  }

  private void dbSave_QueryRowCount(object sender, QueryRowCountEventArgs e)
  {
    e.RowCount = this.ds.tblCreatedEvents.Count;
  }

  private void dbSave_ClickedCancel(object sender, EventArgs e)
  {
    this._mainValidator.ResetAllValidators();
    this.NoteTabPage.Tab.Appearance.ResetBackColor();
    this.PolicyTabPage.Tab.Appearance.ResetBackColor();
    if (((UltraGridBase) this.dgEvents).ActiveRow == null)
      return;
    this.PopulateEntry(this.ActiveNoteAutomationId);
    this.RefreshRecipients();
  }

  private void dbSave_ClickedNew(object sender, EventArgs e)
  {
    this.ClearEntryForm();
    this.recipientList = new ObservableCollection<GlobalNoteAutomationRecipient>();
    this.txtAdditionalRecipients.Text = "";
    this._isNewNoteEvent = true;
  }

  private void dbSave_ClickingSave(object sender, CancelEventArgs e)
  {
    e.Cancel = !this._mainValidator.IsAllValidatorsValid;
    this.NoteTabPage.Tab.Appearance.ResetBackColor();
    this.PolicyTabPage.Tab.Appearance.ResetBackColor();
    if (!e.Cancel)
      return;
    if (this.cboAutomationEvent.Value == null && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((UltraTabControlBase) this.UltraTabControl1).ActiveTab.Key, "POLICYINFO", false) != 0)
      this.PolicyTabPage.Tab.Appearance.BackColor = Color.FromArgb((int) byte.MaxValue, 128 /*0x80*/, 128 /*0x80*/);
    if (this.cboAutomationEvent.Value == null || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((UltraTabControlBase) this.UltraTabControl1).ActiveTab.Key, "NOTE", false) == 0)
      return;
    this.NoteTabPage.Tab.Appearance.BackColor = Color.FromArgb((int) byte.MaxValue, 128 /*0x80*/, 128 /*0x80*/);
  }

  private void dbSave_UIStateChanged(object sender, EventArgs e)
  {
    this.EnableEntry(this.dbSave.UIState == UIState.Editing);
  }

  private void dbSave_ClickedDelete(object sender, EventArgs e)
  {
    List<int> intList = new List<int>();
    foreach (UltraGridRow row in this.dgEvents.Selected.Rows)
      intList.Add((int) row.Cells["NoteAutomationId"].Value);
    try
    {
      foreach (int num in intList)
      {
        Note_System.NonInteractiveNoteManipulator.DeleteGlobalNoteEvent(num);
        this.ds.tblCreatedEvents.FindByNoteAutomationId(num)?.Delete();
        DefaultDatabase.ExecuteNonQuery("NoteSystem_DeleteGlobalNoteAutomationEventLines", new object[2]
        {
          (object) "NoteAutomationID",
          (object) num
        });
      }
    }
    finally
    {
      List<int>.Enumerator enumerator;
      enumerator.Dispose();
    }
  }

  private void dbSave_ClickedEdit(object sender, EventArgs e) => this._isNewNoteEvent = false;

  private void EnableEntry(bool enable)
  {
    GlobalNotesSetupFormML.EnableChildControls(!enable, (Control) this);
    GlobalNotesSetupFormML.EnableChildControls(enable, (Control) this.PolicyTabPage);
    GlobalNotesSetupFormML.EnableChildControls(enable, (Control) this.NoteTabPage);
    ((Control) this.UltraTabControl1).Enabled = true;
    this.dbSave.Enabled = true;
  }

  private static void AttachComboDataSource(
    MGASimpleComboBox combo,
    object dataSource,
    string valueMember,
    string displayMember)
  {
    ((UltraDropDownBase) combo).ValueMember = valueMember;
    ((UltraDropDownBase) combo).DisplayMember = displayMember;
    ((UltraGridBase) combo).DataSource = RuntimeHelpers.GetObjectValue(dataSource);
  }

  private static void ClearChildControls(Control parentControl)
  {
    try
    {
      foreach (Control control in parentControl.Controls)
      {
        switch (control)
        {
          case MGATextBox mgaTextBox:
            ((TextEditorControlBase) mgaTextBox).Text = "";
            continue;
          case MGASimpleComboBox mgaSimpleComboBox:
            mgaSimpleComboBox.Text = "";
            mgaSimpleComboBox.Value = (object) null;
            continue;
          case MGACheckBox mgaCheckBox:
            ((UltraToggleEditorBase) mgaCheckBox).Checked = false;
            continue;
          default:
            continue;
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

  private static void EnableChildControls(bool enable, Control parentControl)
  {
    try
    {
      foreach (Control control in parentControl.Controls)
        control.Enabled = enable;
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private void UpdateGlobalEvent(GlobalEventInfo info, Guid[] multipleLines)
  {
    Note_System.NonInteractiveNoteManipulator.UpdateGlobalNoteEvent(info.NoteAutomationId, info.EventGuid, info.StateId, info.LineGuid, info.ProducerGuid, info.ProducerLocationGuid, info.CompanyLocationGuid, info.InHouseProducerGuid, info.OfficeLocationGuid, info.UnderwriterGuid, info.IssuingOfficeGuid, info.PolicyTypeId, info.Effective, info.ExpirationDate, info.Subject, info.Body, info.DueInDays, info.RecipientId, info.IsPopup, info.NoteType, info.DiaryStartDate, info.CompanyLicenceTypeId, info.TemplateId, info.IncludeEmail, info.Mandatory, info.RequiredToBind, info.StatusReasonID);
    dsAdminGlobalNotes.tblCreatedEventsRow noteAutomationId1 = this.ds.tblCreatedEvents.FindByNoteAutomationId(info.NoteAutomationId);
    if (noteAutomationId1 == null)
      throw new InvalidOperationException("Cannot edit a non existing row");
    noteAutomationId1.Event_Type = this.cboAutomationEvent.Text;
    noteAutomationId1.State = this.cboState.Text;
    noteAutomationId1.Line = this.cboLine.Text;
    noteAutomationId1.Producer = this.cboProducer.Text;
    noteAutomationId1.ProducerLoc = this.cboProducerLoc.Text;
    noteAutomationId1.Company = this.cboCompany.Text;
    noteAutomationId1.Subject = ((TextEditorControlBase) this.noteSubject).Text;
    noteAutomationId1.Body = ((TextEditorControlBase) this.noteBody).Text;
    noteAutomationId1.Due_In_Days = (int) Conversions.ToShort(this.dueInDays.Value);
    noteAutomationId1.Recipient = this.cboNoteRecipients.Text;
    noteAutomationId1.Popup = ((UltraToggleEditorBase) this.popup).Checked;
    noteAutomationId1.Type = this.cboNoteTypes.Text;
    noteAutomationId1.Diary_Start = this.cboDiaryStart.Text;
    noteAutomationId1.Licence_Type = this.cboLicenceType.Text;
    noteAutomationId1.Document_Template = this.cboTemplateDocument.Text;
    noteAutomationId1.IncludeEmail = ((UltraToggleEditorBase) this.chkIncludeEmail).Checked;
    noteAutomationId1.Mandatory = this.chkMandatory.Checked;
    noteAutomationId1.RequiredToBind = ((UltraToggleEditorBase) this.chkRequiredToBind).Checked;
    dsAdminGlobalNotes.tblGlobalNoteAutomationRow noteAutomationId2 = this.ds.tblGlobalNoteAutomation.FindByNoteAutomationID(info.NoteAutomationId);
    info.CopyToTblGlobalNoteAutomationRow(noteAutomationId2);
    if (multipleLines != null)
      this.UpdateAssociatedLines(info.NoteAutomationId, multipleLines);
    GlobalNoteAutomationRecipient.UpdateRecipientList(this.ActiveNoteAutomationId, this.recipientList);
  }

  private int AddNewGlobalEvent(GlobalEventInfo info, Guid[] multipleLines)
  {
    dsAdminGlobalNotes.tblCreatedEventsRow createdEventsRow = this.ds.tblCreatedEvents.AddtblCreatedEventsRow(this.cboAutomationEvent.Text, this.cboState.Text, this.cboLine.Text, this.cboProducer.Text, this.cboProducerLoc.Text, this.cboCompany.Text, ((TextEditorControlBase) this.noteSubject).Text, ((TextEditorControlBase) this.noteBody).Text, Conversions.ToInteger(this.dueInDays.Value), this.cboNoteRecipients.Text, ((UltraToggleEditorBase) this.popup).Checked, this.cboNoteTypes.Text, this.cboDiaryStart.Text, true, this.cboLicenceType.Text, this.cboTemplateDocument.Text, ((UltraToggleEditorBase) this.chkIncludeEmail).Checked, this.chkMandatory.Checked, ((UltraToggleEditorBase) this.chkRequiredToBind).Checked);
    createdEventsRow.NoteAutomationId = Note_System.NonInteractiveNoteManipulator.InsertGlobalNoteEvent(info.EventGuid, info.StateId, info.LineGuid, info.ProducerGuid, info.ProducerLocationGuid, info.CompanyLocationGuid, info.InHouseProducerGuid, info.OfficeLocationGuid, info.UnderwriterGuid, info.IssuingOfficeGuid, info.PolicyTypeId, info.Effective, info.ExpirationDate, info.Subject, info.Body, info.DueInDays, info.RecipientId, info.IsPopup, info.NoteType, info.DiaryStartDate, info.CompanyLicenceTypeId, info.TemplateId, info.IncludeEmail, info.Mandatory, info.RequiredToBind, info.StatusReasonID);
    dsAdminGlobalNotes.tblGlobalNoteAutomationRow row = this.ds.tblGlobalNoteAutomation.NewtblGlobalNoteAutomationRow();
    info.CopyToTblGlobalNoteAutomationRow(row);
    row.NoteAutomationID = createdEventsRow.NoteAutomationId;
    this.ds.tblGlobalNoteAutomation.AddtblGlobalNoteAutomationRow(row);
    if (multipleLines != null)
      this.UpdateAssociatedLines(createdEventsRow.NoteAutomationId, multipleLines);
    GlobalNoteAutomationRecipient.UpdateRecipientList(createdEventsRow.NoteAutomationId, this.recipientList);
    return createdEventsRow.NoteAutomationId;
  }

  private void UpdateAssociatedLines(int noteAutomationID, Guid[] multipleLines)
  {
    DefaultDatabase.ExecuteNonQuery(CommandType.Text, "delete from tblGlobalNoteAutomationLines where NoteAutomationID = @NoteAutomationID", new object[2]
    {
      (object) "@NoteAutomationID",
      (object) noteAutomationID
    });
    Guid[] guidArray = multipleLines;
    int index = 0;
    while (index < guidArray.Length)
    {
      Guid guid = guidArray[index];
      DefaultDatabase.ExecuteNonQuery(CommandType.Text, "insert into tblGlobalNoteAutomationLines (NoteAutomationID, LineGuid) values (@NoteAutomationID, @LineGuid)", new object[4]
      {
        (object) "@NoteAutomationID",
        (object) noteAutomationID,
        (object) "@LineGuid",
        (object) guid
      });
      checked { ++index; }
    }
  }

  private static void SetStringValue(DataRow row, string value, string columnName)
  {
    if (string.IsNullOrEmpty(value))
      return;
    row[columnName] = (object) value;
  }

  private static void SetNullableValue<T>(T? value, DataRow row, string columnName) where T : struct
  {
    if (!value.HasValue)
      return;
    row[columnName] = (object) value.Value;
  }

  private void dbSave_ClickedSave(object sender, EventArgs e)
  {
    object obj = (object) null;
    if (!this.chkNeverExpires.Checked)
      obj = RuntimeHelpers.GetObjectValue(this.dtExpiration.Value);
    GlobalEventInfo info = new GlobalEventInfo(-1, RuntimeHelpers.GetObjectValue(this.cboAutomationEvent.Value), RuntimeHelpers.GetObjectValue(this.cboState.Value), RuntimeHelpers.GetObjectValue(this.cboLine.Value), RuntimeHelpers.GetObjectValue(this.cboProducer.Value), RuntimeHelpers.GetObjectValue(this.cboProducerLoc.Value), RuntimeHelpers.GetObjectValue(this.cboCompany.Value), RuntimeHelpers.GetObjectValue(this.cboInHouseProducers.Value), RuntimeHelpers.GetObjectValue(this.cboOffices.Value), RuntimeHelpers.GetObjectValue(this.cboUnderwriter.Value), RuntimeHelpers.GetObjectValue(this.cboIssuingOffice.Value), RuntimeHelpers.GetObjectValue(this.cboPolicyType.Value), RuntimeHelpers.GetObjectValue(this.dtEffective.Value), ((TextEditorControlBase) this.noteSubject).Text, ((TextEditorControlBase) this.noteBody).Text, RuntimeHelpers.GetObjectValue(this.cboNoteRecipients.Value), ((UltraToggleEditorBase) this.popup).Checked, RuntimeHelpers.GetObjectValue(this.cboNoteTypes.Value), RuntimeHelpers.GetObjectValue(this.cboDiaryStart.Value), RuntimeHelpers.GetObjectValue(this.dueInDays.Value), RuntimeHelpers.GetObjectValue(obj), RuntimeHelpers.GetObjectValue(this.cboLicenceType.Value), RuntimeHelpers.GetObjectValue(this.cboTemplateDocument.Value), ((UltraToggleEditorBase) this.chkIncludeEmail).Checked, this.chkMandatory.Checked, ((UltraToggleEditorBase) this.chkRequiredToBind).Checked, RuntimeHelpers.GetObjectValue(this.cboStatusReason.Value));
    EnumerableRowCollection<DataRow> source = this.dvMultipleLines.ToTable().AsEnumerable().Where<DataRow>((System.Func<DataRow, bool>) ([SpecialName] (row) => !info.LineGuid.HasValue ? row.Field<bool>("Active") : row.Field<bool>("Active") && info.LineGuid.Value != row.Field<Guid>("LineGuid")));
    System.Func<DataRow, Guid> selector;
    // ISSUE: reference to a compiler-generated field
    if (GlobalNotesSetupFormML._Closure\u0024__.\u0024I343\u002D1 != null)
    {
      // ISSUE: reference to a compiler-generated field
      selector = GlobalNotesSetupFormML._Closure\u0024__.\u0024I343\u002D1;
    }
    else
    {
      // ISSUE: reference to a compiler-generated field
      GlobalNotesSetupFormML._Closure\u0024__.\u0024I343\u002D1 = selector = (System.Func<DataRow, Guid>) ([SpecialName] (row) => row.Field<Guid>("LineGuid"));
    }
    Guid[] array = source.Select<DataRow, Guid>(selector).ToArray<Guid>();
    if (this._isNewNoteEvent)
    {
      this.AddNewGlobalEvent(info, array);
    }
    else
    {
      if (((UltraGridBase) this.dgEvents).Rows.Count == 0 || ((UltraGridBase) this.dgEvents).ActiveRow == null)
        throw new InvalidOperationException("Cannot edit a non existing row");
      info.NoteAutomationId = this.ActiveNoteAutomationId;
      this.UpdateGlobalEvent(info, array);
    }
  }

  private void ClearEntryForm()
  {
    GlobalNotesSetupFormML.ClearChildControls((Control) this.PolicyTabPage);
    GlobalNotesSetupFormML.ClearChildControls((Control) this.NoteTabPage);
    this.dvMultipleLines.RowFilter = "NoteAutomationID is null";
    if (this.dvMultipleLines.Count == 0)
    {
      DataTable dataTable = DefaultDatabase.ExecuteDataTable("NoteSystem_GetGlobalNoteAutomationEventLines", new object[2]
      {
        (object) "@NoteAutomationID",
        (object) -1
      });
      if (dataTable != null)
      {
        if (dataTable.Rows.Count > 0)
        {
          try
          {
            foreach (DataRow row in dataTable.Rows)
              this.ds.tblAutomationLines.AddtblAutomationLinesRow((dsAdminGlobalNotes.tblGlobalNoteAutomationRow) null, row.Field<Guid>("LineGuid"), row.Field<string>("LineName"), row.Field<int>("Active") == 1);
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
    try
    {
      foreach (DataRowView dvMultipleLine in this.dvMultipleLines)
        dvMultipleLine.Row["Active"] = (object) false;
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private void PopulateEntry(int noteAutomationEventId)
  {
    dsAdminGlobalNotes.tblGlobalNoteAutomationRow noteAutomationRow = this.ds.tblGlobalNoteAutomation.FindByNoteAutomationID(noteAutomationEventId) ?? this.FetchGlobalNoteAutomationRows(noteAutomationEventId);
    this.PopulateEntryValues(noteAutomationRow);
    if (noteAutomationRow.GettblAutomationLinesRows().Length == 0)
    {
      DataTable dataTable = DefaultDatabase.ExecuteDataTable("NoteSystem_GetGlobalNoteAutomationEventLines", new object[2]
      {
        (object) "@NoteAutomationID",
        (object) noteAutomationEventId
      });
      if (dataTable != null)
      {
        if (dataTable.Rows.Count > 0)
        {
          try
          {
            foreach (DataRow row in dataTable.Rows)
              this.ds.tblAutomationLines.AddtblAutomationLinesRow(noteAutomationRow, row.Field<Guid>("LineGuid"), row.Field<string>("LineName"), row.Field<int>("Active") == 1);
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
    this.dvMultipleLines.RowFilter = $"NoteAutomationID = {noteAutomationEventId}";
  }

  private void PopulateEntryValues(dsAdminGlobalNotes.tblGlobalNoteAutomationRow row)
  {
    this.cboAutomationEvent.Value = (object) row.EventGuid;
    this.cboState.Value = RuntimeHelpers.GetObjectValue(GlobalNotesSetupFormML.GetNullableValue("StateID", (DataRow) row));
    this.cboLine.Value = RuntimeHelpers.GetObjectValue(GlobalNotesSetupFormML.GetNullableValue("LineGuid", (DataRow) row));
    this.cboProducerLoc.Value = RuntimeHelpers.GetObjectValue(GlobalNotesSetupFormML.GetNullableValue("ProducerLocationGuid", (DataRow) row));
    this.cboProducer.Value = RuntimeHelpers.GetObjectValue(GlobalNotesSetupFormML.GetNullableValue("ProducerGuid", (DataRow) row));
    this.cboCompany.Value = RuntimeHelpers.GetObjectValue(GlobalNotesSetupFormML.GetNullableValue("CompanyLocationGuid", (DataRow) row));
    this.cboInHouseProducers.Value = RuntimeHelpers.GetObjectValue(GlobalNotesSetupFormML.GetNullableValue("InHouseProducerGuid", (DataRow) row));
    this.cboOffices.Value = RuntimeHelpers.GetObjectValue(GlobalNotesSetupFormML.GetNullableValue("OfficeLocationGuid", (DataRow) row));
    this.cboUnderwriter.Value = RuntimeHelpers.GetObjectValue(GlobalNotesSetupFormML.GetNullableValue("UnderwriterGuid", (DataRow) row));
    this.cboIssuingOffice.Value = RuntimeHelpers.GetObjectValue(GlobalNotesSetupFormML.GetNullableValue("IssuingOfficeGuid", (DataRow) row));
    this.cboPolicyType.Value = RuntimeHelpers.GetObjectValue(GlobalNotesSetupFormML.GetNullableValue("PolicyTypeID", (DataRow) row));
    this.dtEffective.Value = RuntimeHelpers.GetObjectValue(GlobalNotesSetupFormML.GetNullableValue("Effective", (DataRow) row));
    this.dtExpiration.Value = RuntimeHelpers.GetObjectValue(GlobalNotesSetupFormML.GetNullableValue("ExpirationDate", (DataRow) row));
    ((TextEditorControlBase) this.noteSubject).Text = row.NoteSubject;
    ((TextEditorControlBase) this.noteBody).Text = row.NoteBody;
    this.cboNoteRecipients.Value = RuntimeHelpers.GetObjectValue(GlobalNotesSetupFormML.GetNullableValue("NoteAutomationRecipientID", (DataRow) row));
    ((UltraToggleEditorBase) this.popup).Checked = GlobalNotesSetupFormML.GetNullableBoolValue("Popup", (DataRow) row);
    this.cboNoteTypes.Value = RuntimeHelpers.GetObjectValue(GlobalNotesSetupFormML.GetNullableValue("Type", (DataRow) row));
    this.cboDiaryStart.Value = RuntimeHelpers.GetObjectValue(GlobalNotesSetupFormML.GetNullableValue("DiaryStartDateID", (DataRow) row));
    this.cboLicenceType.Value = RuntimeHelpers.GetObjectValue(GlobalNotesSetupFormML.GetNullableValue("CompanyLicenceTypeID", (DataRow) row));
    this.dueInDays.Value = RuntimeHelpers.GetObjectValue(GlobalNotesSetupFormML.GetNullableValue("DueInDays", (DataRow) row));
    this.cboTemplateDocument.Value = RuntimeHelpers.GetObjectValue(GlobalNotesSetupFormML.GetNullableValue("TemplateID", (DataRow) row));
    ((UltraToggleEditorBase) this.chkIncludeEmail).Checked = GlobalNotesSetupFormML.GetNullableBoolValue("IncludeEmail", (DataRow) row);
    this.chkMandatory.Checked = GlobalNotesSetupFormML.GetNullableBoolValue("Mandatory", (DataRow) row);
    ((UltraToggleEditorBase) this.chkRequiredToBind).Checked = GlobalNotesSetupFormML.GetNullableBoolValue("RequiredToBind", (DataRow) row);
    this.cboStatusReason.Value = RuntimeHelpers.GetObjectValue(GlobalNotesSetupFormML.GetNullableValue("StatusReasonID", (DataRow) row));
    object objectValue = RuntimeHelpers.GetObjectValue(this.dtExpiration.Value);
    if (objectValue == null)
    {
      this.dtExpiration.Value = (object) null;
      this.chkNeverExpires.Checked = true;
    }
    else
    {
      this.dtExpiration.Value = RuntimeHelpers.GetObjectValue(objectValue);
      this.chkNeverExpires.Checked = false;
    }
  }

  private static bool GetNullableBoolValue(string columnName, DataRow row)
  {
    object objectValue = RuntimeHelpers.GetObjectValue(GlobalNotesSetupFormML.GetNullableValue(columnName, row));
    return objectValue != null && (bool) objectValue;
  }

  private static object GetNullableValue(string columnName, DataRow row)
  {
    return !row.IsNull(columnName) ? row[columnName] : (object) null;
  }

  private dsAdminGlobalNotes.tblGlobalNoteAutomationRow FetchGlobalNoteAutomationRows(
    int noteAutomationEventId)
  {
    List<int> noteAutomationIds = new List<int>();
    List<dsAdminGlobalNotes.tblCreatedEventsRow> createdEventsRowList = new List<dsAdminGlobalNotes.tblCreatedEventsRow>();
    dsAdminGlobalNotes.tblCreatedEventsRow noteAutomationId = this.ds.tblCreatedEvents.FindByNoteAutomationId(noteAutomationEventId);
    noteAutomationIds.Add(noteAutomationId.NoteAutomationId);
    noteAutomationId.EntryDataLoaded = true;
    if (this.dvUnloadedEntries.Count > 30)
    {
      int recordIndex = 0;
      do
      {
        dsAdminGlobalNotes.tblCreatedEventsRow row = (dsAdminGlobalNotes.tblCreatedEventsRow) this.dvUnloadedEntries[recordIndex].Row;
        createdEventsRowList.Add(row);
        noteAutomationIds.Add(row.NoteAutomationId);
        ++recordIndex;
      }
      while (recordIndex <= 30);
    }
    else
    {
      try
      {
        foreach (DataRowView dvUnloadedEntry in this.dvUnloadedEntries)
        {
          dsAdminGlobalNotes.tblCreatedEventsRow row = (dsAdminGlobalNotes.tblCreatedEventsRow) dvUnloadedEntry.Row;
          createdEventsRowList.Add(row);
          noteAutomationIds.Add(row.NoteAutomationId);
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
    }
    this.daLoadAutomationRows.SelectCommand.Parameters["@noteAutomationIds"].Value = (object) GlobalNotesSetupFormML.NoteAutomationIdsToXml(noteAutomationIds);
    DefaultDatabase.DataAdapterFill(this.daLoadAutomationRows, (DataTable) this.ds.tblGlobalNoteAutomation);
    try
    {
      foreach (dsAdminGlobalNotes.tblCreatedEventsRow createdEventsRow in createdEventsRowList)
        createdEventsRow.EntryDataLoaded = true;
    }
    finally
    {
      List<dsAdminGlobalNotes.tblCreatedEventsRow>.Enumerator enumerator;
      enumerator.Dispose();
    }
    return this.ds.tblGlobalNoteAutomation.FindByNoteAutomationID(noteAutomationEventId);
  }

  private static string NoteAutomationIdsToXml(List<int> noteAutomationIds)
  {
    XmlDocument xmlDocument = new XmlDocument();
    XmlNode node1 = xmlDocument.CreateNode(XmlNodeType.Element, "note-automation-info-collection", "");
    xmlDocument.AppendChild(node1);
    try
    {
      foreach (int noteAutomationId in noteAutomationIds)
      {
        XmlNode node2 = xmlDocument.CreateNode(XmlNodeType.Element, "info", "");
        XmlAttribute attribute = xmlDocument.CreateAttribute("id");
        attribute.Value = noteAutomationId.ToString();
        node2.Attributes.Append(attribute);
        node1.AppendChild(node2);
      }
    }
    finally
    {
      List<int>.Enumerator enumerator;
      enumerator.Dispose();
    }
    return xmlDocument.OuterXml;
  }

  private void dgEvents_AfterRowActivate(object sender, EventArgs e)
  {
    this.PopulateEntry(this.ActiveNoteAutomationId);
    this.RefreshRecipients();
  }

  private int ActiveNoteAutomationId
  {
    get => (int) ((UltraGridBase) this.dgEvents).ActiveRow.Cells["NoteAutomationId"].Value;
  }

  private void ResetMenuItem_Click(object sender, EventArgs e)
  {
    if (this.ActiveControl is MGASimpleComboBox activeControl1)
    {
      activeControl1.Value = (object) null;
      ((UltraGridBase) activeControl1).UpdateData();
    }
    else
    {
      if (!(this.ActiveControl is MGADateTimePicker activeControl))
        return;
      activeControl.Value = (object) null;
      ((UltraControlBase) activeControl).Update();
    }
  }

  private void UltraTabControl1_ActiveTabChanged(object sender, ActiveTabChangedEventArgs e)
  {
    this.PolicyTabPage.Tab.Appearance.ResetBackColor();
    this.NoteTabPage.Tab.Appearance.ResetBackColor();
  }

  private void chkNeverExpires_CheckedChanged(object sender, EventArgs e)
  {
    ((Control) this.dtExpiration).Enabled = !this.chkNeverExpires.Checked;
  }

  private void cboAutomationEvent_ValueChanged(object sender, EventArgs e)
  {
    ((Control) this.cboTemplateDocument).Visible = this.cboAutomationEvent.Value != null && this.cboAutomationEvent.Value.Equals((object) BroadcastMessages.TemplateDocumentInstanceCreated);
    this.EnableRequiredFieldValidator((Control) this.cboTemplateDocument, ((Control) this.cboTemplateDocument).Visible);
  }

  private void btnAdditionalRecipients_Click(object sender, EventArgs e)
  {
    ObservableCollection<GlobalNoteAutomationRecipient> observableCollection = (ObservableCollection<GlobalNoteAutomationRecipient>) ObjectFactory.Instance.CreateObjectAs<AdditionalRecipientController>(typeof (AdditionalRecipientController)).DisplayUI(this.recipientList);
    if (observableCollection == null)
      return;
    this.recipientList = observableCollection;
    TextBox additionalRecipients = this.txtAdditionalRecipients;
    string separator = ", " + Environment.NewLine;
    ObservableCollection<GlobalNoteAutomationRecipient> recipientList = this.recipientList;
    System.Func<GlobalNoteAutomationRecipient, string> selector;
    // ISSUE: reference to a compiler-generated field
    if (GlobalNotesSetupFormML._Closure\u0024__.\u0024I358\u002D0 != null)
    {
      // ISSUE: reference to a compiler-generated field
      selector = GlobalNotesSetupFormML._Closure\u0024__.\u0024I358\u002D0;
    }
    else
    {
      // ISSUE: reference to a compiler-generated field
      GlobalNotesSetupFormML._Closure\u0024__.\u0024I358\u002D0 = selector = (System.Func<GlobalNoteAutomationRecipient, string>) ([SpecialName] (r) => r.UserName);
    }
    IEnumerable<string> source = recipientList.Select<GlobalNoteAutomationRecipient, string>(selector);
    System.Func<string, string> keySelector;
    // ISSUE: reference to a compiler-generated field
    if (GlobalNotesSetupFormML._Closure\u0024__.\u0024I358\u002D1 != null)
    {
      // ISSUE: reference to a compiler-generated field
      keySelector = GlobalNotesSetupFormML._Closure\u0024__.\u0024I358\u002D1;
    }
    else
    {
      // ISSUE: reference to a compiler-generated field
      GlobalNotesSetupFormML._Closure\u0024__.\u0024I358\u002D1 = keySelector = (System.Func<string, string>) ([SpecialName] (s) => s);
    }
    IOrderedEnumerable<string> values = source.OrderBy<string, string>(keySelector);
    string str = string.Join(separator, (IEnumerable<string>) values);
    additionalRecipients.Text = str;
  }

  private void RefreshRecipients()
  {
    this.recipientList = GlobalNoteAutomationRecipient.GetGlobalNoteAutomationRecipientList(this.ActiveNoteAutomationId);
    TextBox additionalRecipients = this.txtAdditionalRecipients;
    string separator = ", " + Environment.NewLine;
    ObservableCollection<GlobalNoteAutomationRecipient> recipientList = this.recipientList;
    System.Func<GlobalNoteAutomationRecipient, string> selector;
    // ISSUE: reference to a compiler-generated field
    if (GlobalNotesSetupFormML._Closure\u0024__.\u0024I359\u002D0 != null)
    {
      // ISSUE: reference to a compiler-generated field
      selector = GlobalNotesSetupFormML._Closure\u0024__.\u0024I359\u002D0;
    }
    else
    {
      // ISSUE: reference to a compiler-generated field
      GlobalNotesSetupFormML._Closure\u0024__.\u0024I359\u002D0 = selector = (System.Func<GlobalNoteAutomationRecipient, string>) ([SpecialName] (r) => r.UserName);
    }
    IEnumerable<string> source = recipientList.Select<GlobalNoteAutomationRecipient, string>(selector);
    System.Func<string, string> keySelector;
    // ISSUE: reference to a compiler-generated field
    if (GlobalNotesSetupFormML._Closure\u0024__.\u0024I359\u002D1 != null)
    {
      // ISSUE: reference to a compiler-generated field
      keySelector = GlobalNotesSetupFormML._Closure\u0024__.\u0024I359\u002D1;
    }
    else
    {
      // ISSUE: reference to a compiler-generated field
      GlobalNotesSetupFormML._Closure\u0024__.\u0024I359\u002D1 = keySelector = (System.Func<string, string>) ([SpecialName] (s) => s);
    }
    IOrderedEnumerable<string> values = source.OrderBy<string, string>(keySelector);
    string str = string.Join(separator, (IEnumerable<string>) values);
    additionalRecipients.Text = str;
  }

  private void CboNoteRecipients_InitializeLayout(object sender, InitializeLayoutEventArgs e)
  {
    e.Layout.Bands[0].SortedColumns.Add("RecipientName", false);
  }

  private void cboStatusReason_BeforeDropDown(object sender, CancelEventArgs e)
  {
    Guid eventGuid;
    if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(this.cboAutomationEvent.Value)))
      eventGuid = (Guid) this.cboAutomationEvent.Value;
    Guid lineGuid;
    if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(this.cboLine.Value)))
      lineGuid = (Guid) this.cboLine.Value;
    foreach (UltraGridRow row in ((UltraGridBase) this.cboStatusReason).Rows)
      row.Hidden = !this.IsAsscociatedStatus(eventGuid, Conversions.ToInteger(row.Cells["QuoteStatusID"].Value), lineGuid, Conversions.ToInteger(row.Cells["ID"].Value));
  }

  private bool IsAsscociatedStatus(Guid eventGuid, int quoteStatusID, Guid lineGuid, int reasonID)
  {
    bool flag;
    try
    {
      foreach (dsAdminGlobalNotes.dtQuoteStatusEventsRow row in this.ds.dtQuoteStatusEvents.Rows)
      {
        if (row.QuoteStatusID == quoteStatusID && row.EventGuid.Equals(eventGuid))
        {
          if (lineGuid.Equals(Guid.Empty))
          {
            flag = true;
            goto label_11;
          }
          dsAdminGlobalNotes.lstQuoteStatusReasonsRow byId = this.ds.lstQuoteStatusReasons.FindByID(reasonID);
          if (byId != null && (byId.IsLineGuidNull() || byId.LineGuid.Equals(lineGuid)))
          {
            flag = true;
            goto label_11;
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
    flag = false;
label_11:
    return flag;
  }
}
