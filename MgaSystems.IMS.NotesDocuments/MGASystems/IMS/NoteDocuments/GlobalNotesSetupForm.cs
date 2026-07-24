// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.NoteDocuments.GlobalNotesSetupForm
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
using MGASystems.Data;
using MGASystems.Tools;
using MGASystems.Tools.DBSaveUI;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.NoteDocuments;

[DesignerGenerated]
internal class GlobalNotesSetupForm : Form
{
  private IContainer components;

  public GlobalNotesSetupForm() => this.InitializeComponent();

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
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    UltraTab ultraTab1 = new UltraTab();
    Appearance appearance10 = new Appearance();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (GlobalNotesSetupForm));
    UltraTab ultraTab2 = new UltraTab();
    Appearance appearance11 = new Appearance();
    Appearance appearance12 = new Appearance();
    UltraGridBand ultraGridBand = new UltraGridBand("tblCreatedEvents", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("NoteAutomationId");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("Event Type", -1, (object) null, 410888288, 0, 0);
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("State", -1, (object) null, 410888288, 5, 0);
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("Line", -1, (object) null, 410888288, 2, 0);
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("Producer", -1, (object) null, 410888288, 3, 0);
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("ProducerLoc", -1, (object) null, 410888288, 4, 0);
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("Company", -1, (object) null, 410888288, 1, 0);
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("Subject", -1, (object) null, 410888288, 8, 1);
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("Body", -1, (object) null, 410888288, 9, 1);
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("Due In Days", -1, (object) null, 410888288, 10, 1);
    UltraGridColumn ultraGridColumn11 = new UltraGridColumn("Recipient", -1, (object) null, 410888288, 11, 1);
    UltraGridColumn ultraGridColumn12 = new UltraGridColumn("Popup", -1, (object) null, 410888288, 12, 1);
    UltraGridColumn ultraGridColumn13 = new UltraGridColumn("Type", -1, (object) null, 410888288, 13, 1);
    UltraGridColumn ultraGridColumn14 = new UltraGridColumn("Diary Start", -1, (object) null, 410888288, 14, 1);
    UltraGridColumn ultraGridColumn15 = new UltraGridColumn("EntryDataLoaded");
    UltraGridColumn ultraGridColumn16 = new UltraGridColumn("Licence Type", -1, (object) null, 410888288, 6, 0);
    UltraGridColumn ultraGridColumn17 = new UltraGridColumn("Document Template", -1, (object) null, 410888288, 7, 0);
    UltraGridColumn ultraGridColumn18 = new UltraGridColumn("IncludeEmail");
    UltraGridGroup ultraGridGroup = new UltraGridGroup("NewGroup0", 410888288);
    Appearance appearance13 = new Appearance();
    Appearance appearance14 = new Appearance();
    Appearance appearance15 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    this.PolicyTabPage = new UltraTabPageControl();
    this.cboProducer = new MGASimpleComboBox();
    this.ContextMenuStrip1 = new ContextMenuStrip(this.components);
    this.ResetMenuItem = new ToolStripMenuItem();
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
    this.dvUnderwriters = new DataView();
    this.dvOffices = new DataView();
    this.dvUsers = new DataView();
    this.dvIssuingOffices = new DataView();
    this.dvUnloadedEntries = new DataView();
    ((Control) this.PolicyTabPage).SuspendLayout();
    ((ISupportInitialize) this.cboProducer).BeginInit();
    this.ContextMenuStrip1.SuspendLayout();
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
    this.dvUnderwriters.BeginInit();
    this.dvOffices.BeginInit();
    this.dvUsers.BeginInit();
    this.dvIssuingOffices.BeginInit();
    this.dvUnloadedEntries.BeginInit();
    this.SuspendLayout();
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
    ((Control) this.PolicyTabPage).Location = new Point(-10000, -10000);
    ((Control) this.PolicyTabPage).Name = "PolicyTabPage";
    ((Control) this.PolicyTabPage).Size = new Size(760, 362);
    this.cboProducer.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.cboProducer).ContextMenuStrip = this.ContextMenuStrip1;
    this.cboProducer.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboProducer).Location = new Point(119, 57);
    this.cboProducer.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboProducer).Name = "cboProducer";
    ((Control) this.cboProducer).Size = new Size(336, 21);
    ((Control) this.cboProducer).TabIndex = 29;
    ((UltraControlBase) this.cboProducer).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboProducer).UseOsThemes = (DefaultableBoolean) 2;
    this.ContextMenuStrip1.Items.AddRange(new ToolStripItem[1]
    {
      (ToolStripItem) this.ResetMenuItem
    });
    this.ContextMenuStrip1.Name = "ContextMenuStrip1";
    this.ContextMenuStrip1.Size = new Size(103, 26);
    this.ResetMenuItem.Name = "ResetMenuItem";
    this.ResetMenuItem.Size = new Size(102, 22);
    this.ResetMenuItem.Text = "Reset";
    this.Label20.AutoSize = true;
    this.Label20.BackColor = Color.Transparent;
    this.Label20.Location = new Point(52, 59);
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
    this.Label19.Location = new Point(266, 274);
    this.Label19.Name = "Label19";
    this.Label19.Size = new Size(73, 13);
    this.Label19.TabIndex = 25;
    this.Label19.Text = "License Type:";
    this.Label19.TextAlign = ContentAlignment.MiddleRight;
    this.cboLicenceType.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.cboLicenceType).ContextMenuStrip = this.ContextMenuStrip1;
    this.cboLicenceType.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboLicenceType).Location = new Point(344, 274);
    this.cboLicenceType.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboLicenceType).Name = "cboLicenceType";
    ((Control) this.cboLicenceType).Size = new Size(111, 21);
    ((Control) this.cboLicenceType).TabIndex = 26;
    ((UltraControlBase) this.cboLicenceType).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboLicenceType).UseOsThemes = (DefaultableBoolean) 2;
    this.chkNeverExpires.AutoSize = true;
    this.chkNeverExpires.BackColor = Color.Transparent;
    this.chkNeverExpires.Location = new Point(216, 333);
    this.chkNeverExpires.Name = "chkNeverExpires";
    this.chkNeverExpires.Size = new Size(93, 17);
    this.chkNeverExpires.TabIndex = 24;
    this.chkNeverExpires.Text = "Never Expires";
    this.chkNeverExpires.UseVisualStyleBackColor = false;
    this.Label18.AutoSize = true;
    this.Label18.BackColor = Color.Transparent;
    this.Label18.Location = new Point(21, 334);
    this.Label18.Name = "Label18";
    this.Label18.Size = new Size(85, 13);
    this.Label18.TabIndex = 22;
    this.Label18.Text = "Expiration Date:";
    this.Label18.TextAlign = ContentAlignment.MiddleRight;
    appearance1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.dtExpiration.Appearance = (AppearanceBase) appearance1;
    appearance2.AlphaLevel = (short) 14;
    appearance2.BackColor = Color.FromArgb(0, 0, 246, 253);
    appearance2.BackColor2 = Color.FromArgb(133, 162, 221);
    appearance2.BackColorAlpha = (Alpha) 2;
    appearance2.BackGradientAlignment = (GradientAlignment) 4;
    appearance2.BackGradientStyle = (GradientStyle) 5;
    appearance2.BorderAlpha = (Alpha) 1;
    appearance2.BorderColor = Color.FromArgb(78, 122, 171);
    appearance2.ForeColor = Color.FromArgb(49, 85, 153);
    appearance2.ForegroundAlpha = (Alpha) 2;
    this.dtExpiration.ButtonAppearance = (AppearanceBase) appearance2;
    ((Control) this.dtExpiration).ContextMenuStrip = this.ContextMenuStrip1;
    this.dtExpiration.DateTime = new DateTime(2007, 6, 6, 0, 0, 0, 0);
    ((Control) this.dtExpiration).Location = new Point(119, 331);
    this.dtExpiration.MaxDate = new DateTime(2079, 6, 6, 0, 0, 0, 0);
    this.dtExpiration.MGAStyle = MGAStyles.Blue;
    this.dtExpiration.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
    ((Control) this.dtExpiration).Name = "dtExpiration";
    ((Control) this.dtExpiration).Size = new Size(91, 20);
    ((Control) this.dtExpiration).TabIndex = 23;
    ((UltraControlBase) this.dtExpiration).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dtExpiration).UseOsThemes = (DefaultableBoolean) 2;
    this.dtExpiration.Value = (object) new DateTime(2007, 6, 6, 0, 0, 0, 0);
    this.cboAutomationEvent.BorderStyle = (UIElementBorderStyle) 4;
    this.cboAutomationEvent.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboAutomationEvent).Location = new Point(119, 4);
    this.cboAutomationEvent.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboAutomationEvent).Name = "cboAutomationEvent";
    ((Control) this.cboAutomationEvent).Size = new Size(336, 21);
    ((Control) this.cboAutomationEvent).TabIndex = 1;
    ((UltraControlBase) this.cboAutomationEvent).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboAutomationEvent).UseOsThemes = (DefaultableBoolean) 2;
    this.Label17.AutoSize = true;
    this.Label17.BackColor = Color.Transparent;
    this.Label17.Location = new Point(67, 4);
    this.Label17.Name = "Label17";
    this.Label17.Size = new Size(39, 13);
    this.Label17.TabIndex = 0;
    this.Label17.Text = "Event:";
    this.Label10.AutoSize = true;
    this.Label10.BackColor = Color.Transparent;
    this.Label10.Location = new Point(52, 304);
    this.Label10.Name = "Label10";
    this.Label10.Size = new Size(54, 13);
    this.Label10.TabIndex = 20;
    this.Label10.Text = "Effective:";
    this.Label10.TextAlign = ContentAlignment.MiddleRight;
    appearance3.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.dtEffective.Appearance = (AppearanceBase) appearance3;
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
    this.dtEffective.ButtonAppearance = (AppearanceBase) appearance4;
    ((Control) this.dtEffective).ContextMenuStrip = this.ContextMenuStrip1;
    this.dtEffective.DateTime = new DateTime(2007, 6, 6, 0, 0, 0, 0);
    ((Control) this.dtEffective).Location = new Point(119, 302);
    this.dtEffective.MaxDate = new DateTime(2079, 6, 6, 0, 0, 0, 0);
    this.dtEffective.MGAStyle = MGAStyles.Blue;
    this.dtEffective.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
    ((Control) this.dtEffective).Name = "dtEffective";
    ((Control) this.dtEffective).Size = new Size(91, 20);
    ((Control) this.dtEffective).TabIndex = 21;
    ((UltraControlBase) this.dtEffective).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dtEffective).UseOsThemes = (DefaultableBoolean) 2;
    this.dtEffective.Value = (object) new DateTime(2007, 6, 6, 0, 0, 0, 0);
    this.Label7.AutoSize = true;
    this.Label7.BackColor = Color.Transparent;
    this.Label7.Location = new Point(38, 218);
    this.Label7.Name = "Label7";
    this.Label7.Size = new Size(68, 13);
    this.Label7.TabIndex = 14;
    this.Label7.Text = "Underwriter:";
    this.Label7.TextAlign = ContentAlignment.MiddleRight;
    this.cboUnderwriter.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.cboUnderwriter).ContextMenuStrip = this.ContextMenuStrip1;
    this.cboUnderwriter.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboUnderwriter).Location = new Point(119, 218);
    this.cboUnderwriter.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboUnderwriter).Name = "cboUnderwriter";
    ((Control) this.cboUnderwriter).Size = new Size(336, 21);
    ((Control) this.cboUnderwriter).TabIndex = 15;
    ((UltraControlBase) this.cboUnderwriter).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboUnderwriter).UseOsThemes = (DefaultableBoolean) 2;
    this.Label8.AutoSize = true;
    this.Label8.BackColor = Color.Transparent;
    this.Label8.Location = new Point(29, 246);
    this.Label8.Name = "Label8";
    this.Label8.Size = new Size(77, 13);
    this.Label8.TabIndex = 16 /*0x10*/;
    this.Label8.Text = "Issuing Office:";
    this.Label8.TextAlign = ContentAlignment.MiddleRight;
    this.cboIssuingOffice.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.cboIssuingOffice).ContextMenuStrip = this.ContextMenuStrip1;
    this.cboIssuingOffice.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboIssuingOffice).Location = new Point(119, 246);
    this.cboIssuingOffice.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboIssuingOffice).Name = "cboIssuingOffice";
    ((Control) this.cboIssuingOffice).Size = new Size(336, 21);
    ((Control) this.cboIssuingOffice).TabIndex = 17;
    ((UltraControlBase) this.cboIssuingOffice).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboIssuingOffice).UseOsThemes = (DefaultableBoolean) 2;
    this.Label9.AutoSize = true;
    this.Label9.BackColor = Color.Transparent;
    this.Label9.Location = new Point(41, 274);
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
    ((Control) this.cboPolicyType).TabIndex = 19;
    ((UltraControlBase) this.cboPolicyType).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboPolicyType).UseOsThemes = (DefaultableBoolean) 2;
    this.Label4.AutoSize = true;
    this.Label4.BackColor = Color.Transparent;
    this.Label4.Location = new Point(76, 137);
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
    ((Control) this.cboCompany).TabIndex = 3;
    ((UltraControlBase) this.cboCompany).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboCompany).UseOsThemes = (DefaultableBoolean) 2;
    this.cboProducerLoc.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.cboProducerLoc).ContextMenuStrip = this.ContextMenuStrip1;
    this.cboProducerLoc.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboProducerLoc).Location = new Point(119, 83);
    this.cboProducerLoc.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboProducerLoc).Name = "cboProducerLoc";
    ((Control) this.cboProducerLoc).Size = new Size(336, 21);
    ((Control) this.cboProducerLoc).TabIndex = 5;
    ((UltraControlBase) this.cboProducerLoc).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboProducerLoc).UseOsThemes = (DefaultableBoolean) 2;
    this.cboState.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.cboState).ContextMenuStrip = this.ContextMenuStrip1;
    this.cboState.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboState).Location = new Point(119, 109);
    this.cboState.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboState).Name = "cboState";
    ((Control) this.cboState).Size = new Size(336, 21);
    ((Control) this.cboState).TabIndex = 7;
    ((UltraControlBase) this.cboState).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboState).UseOsThemes = (DefaultableBoolean) 2;
    this.cboLine.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.cboLine).ContextMenuStrip = this.ContextMenuStrip1;
    this.cboLine.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboLine).Location = new Point(119, 135);
    this.cboLine.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboLine).Name = "cboLine";
    ((Control) this.cboLine).Size = new Size(336, 21);
    ((Control) this.cboLine).TabIndex = 9;
    ((UltraControlBase) this.cboLine).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboLine).UseOsThemes = (DefaultableBoolean) 2;
    this.Label5.AutoSize = true;
    this.Label5.BackColor = Color.Transparent;
    this.Label5.Location = new Point(66, 163);
    this.Label5.Name = "Label5";
    this.Label5.Size = new Size(40, 13);
    this.Label5.TabIndex = 10;
    this.Label5.Text = "Office:";
    this.Label5.TextAlign = ContentAlignment.MiddleRight;
    this.cboOffices.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.cboOffices).ContextMenuStrip = this.ContextMenuStrip1;
    this.cboOffices.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboOffices).Location = new Point(119, 161);
    this.cboOffices.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboOffices).Name = "cboOffices";
    ((Control) this.cboOffices).Size = new Size(336, 21);
    ((Control) this.cboOffices).TabIndex = 11;
    ((UltraControlBase) this.cboOffices).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboOffices).UseOsThemes = (DefaultableBoolean) 2;
    this.Label6.AutoSize = true;
    this.Label6.BackColor = Color.Transparent;
    this.Label6.Location = new Point(5, 189);
    this.Label6.Name = "Label6";
    this.Label6.Size = new Size(101, 13);
    this.Label6.TabIndex = 12;
    this.Label6.Text = "In-House Producer:";
    this.Label6.TextAlign = ContentAlignment.MiddleRight;
    this.cboInHouseProducers.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.cboInHouseProducers).ContextMenuStrip = this.ContextMenuStrip1;
    this.cboInHouseProducers.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboInHouseProducers).Location = new Point(119, 187);
    this.cboInHouseProducers.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboInHouseProducers).Name = "cboInHouseProducers";
    ((Control) this.cboInHouseProducers).Size = new Size(336, 21);
    ((Control) this.cboInHouseProducers).TabIndex = 13;
    ((UltraControlBase) this.cboInHouseProducers).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboInHouseProducers).UseOsThemes = (DefaultableBoolean) 2;
    this.Label1.AutoSize = true;
    this.Label1.BackColor = Color.Transparent;
    this.Label1.Location = new Point(50, 33);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(56, 13);
    this.Label1.TabIndex = 2;
    this.Label1.Text = "Company:";
    this.Label1.TextAlign = ContentAlignment.MiddleRight;
    this.Label2.AutoSize = true;
    this.Label2.BackColor = Color.Transparent;
    this.Label2.Location = new Point(9, 85);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(97, 13);
    this.Label2.TabIndex = 4;
    this.Label2.Text = "Producer Location:";
    this.Label2.TextAlign = ContentAlignment.MiddleRight;
    this.Label3.AutoSize = true;
    this.Label3.BackColor = Color.Transparent;
    this.Label3.Location = new Point(69, 111);
    this.Label3.Name = "Label3";
    this.Label3.Size = new Size(37, 13);
    this.Label3.TabIndex = 6;
    this.Label3.Text = "State:";
    this.Label3.TextAlign = ContentAlignment.MiddleRight;
    this.dbSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.dbSave.AutoQueryRowCountOnLoad = false;
    this.dbSave.EditStyle = EditStyle.ShowEditButton;
    this.dbSave.FreezeEvents = false;
    this.dbSave.Location = new Point(344, 311);
    this.dbSave.Name = "dbSave";
    this.dbSave.Size = new Size(112 /*0x70*/, 40);
    this.dbSave.TabIndex = 10;
    this.dbSave.UIState = UIState.HasRecordsNotEditing;
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
    ((Control) this.NoteTabPage).Controls.Add((Control) this.dbSave);
    ((Control) this.NoteTabPage).Location = new Point(1, 26);
    ((Control) this.NoteTabPage).Name = "NoteTabPage";
    ((Control) this.NoteTabPage).Size = new Size(760, 362);
    appearance5.BorderColor = Color.Gray;
    appearance5.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkIncludeEmail).Appearance = (AppearanceBase) appearance5;
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
    appearance6.BorderColor = Color.Gray;
    appearance6.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.popup).Appearance = (AppearanceBase) appearance6;
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
    appearance7.BorderColor = Color.Gray;
    ((UltraNumericEditorBase) this.dueInDays).Appearance = (AppearanceBase) appearance7;
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
    appearance8.BackColor = Color.White;
    appearance8.BorderColor = Color.Gray;
    appearance8.ForeColor = Color.Black;
    ((TextEditorControlBase) this.noteBody).Appearance = (AppearanceBase) appearance8;
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
    appearance9.BackColor = Color.White;
    appearance9.BorderColor = Color.Gray;
    appearance9.ForeColor = Color.Black;
    ((TextEditorControlBase) this.noteSubject).Appearance = (AppearanceBase) appearance9;
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
    ((Control) this.UltraTabControl1).Location = new Point(12, 258);
    ((Control) this.UltraTabControl1).Name = "UltraTabControl1";
    ((UltraTabControlBase) this.UltraTabControl1).SharedControls.AddRange(new Control[1]
    {
      (Control) this.dbSave
    });
    ((UltraTabControlBase) this.UltraTabControl1).SharedControlsPage = this.UltraTabSharedControlsPage1;
    ((Control) this.UltraTabControl1).Size = new Size(762, 389);
    ((Control) this.UltraTabControl1).TabIndex = 0;
    ((UltraTabControlBase) this.UltraTabControl1).TabLayoutStyle = (TabLayoutStyle) 1;
    ((UltraTabControlBase) this.UltraTabControl1).TabPadding = new Size(5, 3);
    appearance10.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance9.Image"));
    ultraTab1.Appearance = (AppearanceBase) appearance10;
    ultraTab1.Key = "POLICYINFO";
    ultraTab1.TabPage = this.PolicyTabPage;
    ultraTab1.Text = "Policy Info";
    appearance11.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance10.Image"));
    ultraTab2.Appearance = (AppearanceBase) appearance11;
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
    ((Control) this.UltraTabSharedControlsPage1).Size = new Size(760, 362);
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
    appearance12.BackColor = Color.White;
    appearance12.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.dgEvents).DisplayLayout.Appearance = (AppearanceBase) appearance12;
    ((UltraGridBase) this.dgEvents).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn1.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn1.Width = 728;
    ultraGridColumn2.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn2.Width = 131;
    ultraGridColumn3.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn3.Width = 39;
    ultraGridColumn4.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn4.Width = 90;
    ultraGridColumn5.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn5.Width = 87;
    ultraGridColumn6.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn6.Header).Caption = "Producer Loc";
    ultraGridColumn6.Width = 83;
    ultraGridColumn7.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn7.Width = 181;
    ultraGridColumn8.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn8.Width = 120;
    ultraGridColumn9.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn9.Width = 120;
    ultraGridColumn10.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn10.Width = 93;
    ultraGridColumn11.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn11.Width = 120;
    ultraGridColumn12.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn12.Width = 60;
    ultraGridColumn13.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn13.Width = 120;
    ultraGridColumn14.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn14.Width = (int) sbyte.MaxValue;
    ultraGridColumn15.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn15.Header.VisiblePosition = 16 /*0x10*/;
    ultraGridColumn15.Hidden = true;
    ultraGridColumn16.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn16.Width = 63 /*0x3F*/;
    ultraGridColumn17.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn17.Header).Caption = "Doc Template";
    ultraGridColumn17.Width = 86;
    ultraGridColumn18.Header.VisiblePosition = 17;
    ultraGridBand.Columns.AddRange(new object[18]
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
      (object) ultraGridColumn18
    });
    ultraGridBand.GroupHeadersVisible = false;
    ((KeyedSubObjectBase) ultraGridGroup).Key = "NewGroup0";
    ultraGridBand.Groups.AddRange(new UltraGridGroup[1]
    {
      ultraGridGroup
    });
    ultraGridBand.LevelCount = 2;
    ultraGridBand.Override.AllowRowFiltering = (DefaultableBoolean) 1;
    ((UltraGridBase) this.dgEvents).DisplayLayout.BandsSerializer.Add((object) ultraGridBand);
    ((UltraGridBase) this.dgEvents).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance13.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((UltraGridBase) this.dgEvents).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance13;
    ((UltraGridBase) this.dgEvents).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.dgEvents).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((UltraGridBase) this.dgEvents).DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.dgEvents).DisplayLayout.Override.CellClickAction = (CellClickAction) 2;
    appearance14.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.dgEvents).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance14;
    ((UltraGridBase) this.dgEvents).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 2;
    appearance15.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.dgEvents).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance15;
    ((UltraGridBase) this.dgEvents).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((UltraGridBase) this.dgEvents).DisplayLayout.Override.RowSpacingAfter = 5;
    ((UltraGridBase) this.dgEvents).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance13;
    scrollBarLook.ViewStyle = (ScrollBarViewStyle) 3;
    ((UltraGridBase) this.dgEvents).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((UltraGridBase) this.dgEvents).DisplayLayout.ScrollStyle = (ScrollStyle) 1;
    ((Control) this.dgEvents).Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.dgEvents).Location = new Point(12, 12);
    ((Control) this.dgEvents).Name = "dgEvents";
    ((Control) this.dgEvents).Size = new Size(762, 240 /*0xF0*/);
    ((Control) this.dgEvents).TabIndex = 9;
    ((UltraControlBase) this.dgEvents).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dgEvents).UseOsThemes = (DefaultableBoolean) 2;
    this.ds.DataSetName = "dsAdminGlobalNotes";
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
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
    this.ClientSize = new Size(786, 659);
    this.Controls.Add((Control) this.dgEvents);
    this.Controls.Add((Control) this.UltraTabControl1);
    this.Font = new Font("Tahoma", 8.25f);
    this.Name = nameof (GlobalNotesSetupForm);
    this.StartPosition = FormStartPosition.CenterParent;
    this.Text = "Admin Notes";
    ((Control) this.PolicyTabPage).ResumeLayout(false);
    ((Control) this.PolicyTabPage).PerformLayout();
    ((ISupportInitialize) this.cboProducer).EndInit();
    this.ContextMenuStrip1.ResumeLayout(false);
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

  [field: AccessedThroughProperty("UltraTabControl1")]
  private virtual UltraTabControl UltraTabControl1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraTabSharedControlsPage1")]
  private virtual UltraTabSharedControlsPage UltraTabSharedControlsPage1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("dbSave")]
  private virtual MGASystems.Tools.DBSaveUI.DBSaveUI dbSave { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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

  [field: AccessedThroughProperty("InitialLoadBackgroundWorker")]
  internal virtual BackgroundWorker InitialLoadBackgroundWorker { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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

  [field: AccessedThroughProperty("cboNoteRecipients")]
  private virtual MGASimpleComboBox cboNoteRecipients { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cboDiaryStart")]
  private virtual MGASimpleComboBox cboDiaryStart { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cboAutomationEvent")]
  private virtual MGASimpleComboBox cboAutomationEvent { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label17")]
  internal virtual Label Label17 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("daCreatedEvents")]
  private virtual DbDataAdapter daCreatedEvents { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("DbCommand1")]
  private virtual DbCommand DbCommand1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("dgEvents")]
  private virtual UltraGrid dgEvents { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("daLoadAutomationRows")]
  private virtual DbDataAdapter daLoadAutomationRows { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("DbCommand2")]
  private virtual DbCommand DbCommand2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("dvUnloadedEntries")]
  private virtual DataView dvUnloadedEntries { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ContextMenuStrip1")]
  internal virtual ContextMenuStrip ContextMenuStrip1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ResetMenuItem")]
  internal virtual ToolStripMenuItem ResetMenuItem { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label18")]
  private virtual Label Label18 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("dtExpiration")]
  private virtual MGADateTimePicker dtExpiration { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkNeverExpires")]
  internal virtual CheckBox chkNeverExpires { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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
}
