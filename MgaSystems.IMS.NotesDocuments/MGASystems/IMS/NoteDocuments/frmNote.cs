// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.NoteDocuments.frmNote
// Assembly: MgaSystems.IMS.NotesDocuments, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 3F898CF7-066D-4B05-A9F1-D37DBC4FAA16
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.NotesDocuments.dll

using GrapeCity.ActiveReports;
using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using Infragistics.Win.UltraWinTabControl;
using Infragistics.Win.UltraWinTabs;
using MGASystems.Common;
using MGASystems.Common.DataAccess;
using MGASystems.Common.Extensions;
using MGASystems.Common.ReportSystem;
using MGASystems.Data;
using MGASystems.IMS.NoteDocuments.DocumentSystem;
using MGASystems.IMS.NoteDocuments.NoteDiarySystem;
using MGASystems.IMS.NoteDocuments.Serialization;
using MGASystems.IMS.Security;
using MGASystems.Tools;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.NoteDocuments;

[SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly")]
[Preference("Screens.Note.SelectedEntryTab", 0)]
[Preference("Screens.Note.DocumentsAndEntities.Visible", false)]
[Preference("Screens.Note.Height", 384)]
[Preference("Screens.Note.Width", 520)]
[SecureResource("{88D709B6-0BDC-411d-9EAA-1A664AA9C362}", "Show entry edit view", "Allows a user to view what edits were made to an entry and by whom", "Note System")]
[Preference("Screens.Note.EntryEdit.Height", 64 /*0x40*/)]
public class frmNote : 
  Form,
  ISupportNoteSystem,
  IUIElementDrawFilter,
  ISupportDocumentSystem,
  ISupportDocumentPanel,
  ISupportReports,
  INoteForm,
  ISupportNoteDocumentBinding
{
  private Guid _externalDocumentToBindTo;
  private bool _startInEditMode;
  private bool _firstEntryViewLoadWithBoundDoc;
  private bool _ignoreClickNote;
  private bool _unbound;
  private frmNote.NoteState _noteState;
  private bool _ignoreClickInternal;
  private bool _ignoreClickPopup;
  private bool _ignoreClickDiary;
  private string _initialSubject;
  private Dictionary<Guid, string> _fullBodyHash;
  private bool _docsAndEntitiesExpanded;
  private const int _docEntityHeight = 112 /*0x70*/;
  internal const string SECURE_RESOURCE_SHOWENTRYEDITS = "{88D709B6-0BDC-411d-9EAA-1A664AA9C362}";
  private Guid[] _documentGuids;
  internal const string PREFERENCE_SELECTEDTAB = "Screens.Note.SelectedEntryTab";
  internal const string PREFERENCE_ENTRYEDIT_HEIGHT = "Screens.Note.EntryEdit.Height";
  internal const string PREFERENCE_DISPLAYDOCS = "Screens.Note.DocumentsAndEntities.Visible";
  internal const string PREFERENCE_DEFAULT_HEIGHT = "Screens.Note.Height";
  internal const string PREFERENCE_DEFAULT_WIDTH = "Screens.Note.Width";
  private Guid _initialEntryGUID;
  private Guid _noteGuid;
  private MGASystems.IMS.NoteDocuments.NoteDiarySystem.NoteSupportCache _noteSupportCache;
  private DataTable _tblNoteTypes;
  private bool _formLoaded;
  private bool _dataFetchThreadCompleted;
  private bool _controlsBound;
  private DataTable _tblUsers;
  private DataTable _tblSystemUsers;
  private ISupportNoteSystem _secondaryAssociation;
  private readonly bool _useServerDateTime;
  private IContainer components;
  private Label lblDateCreated;
  private MGANoteRecipientListBox lbRecipients;
  private UltraTabSharedControlsPage UltraTabSharedControlsPage2;
  private UltraTabPageControl UltraTabPageControl1;
  private UltraTabPageControl UltraTabPageControl2;
  private UltraTabPageControl UltraTabPageControl3;
  private Panel Panel1;
  private RequiredFieldValidator RequiredFieldValidatorSubject;
  private Panel pnlEntry;
  private RequiredFieldValidator RequiredFieldValidatorEntryText;
  private UltraGroupBox mainGroupBox;
  private Panel Panel2;
  private DbConnection cnSQL;
  private Label lblCreateBy;
  private MGADateTimePicker dtFinal;
  private MGADateTimePicker dtDue;
  private RequiredFieldValidator RequiredFieldValidatorTypeValue;
  private EntityNotePanel EntityNotePanel1;
  private Label lblDiaryDue;
  private Label lblDiaryDeadline;

  private virtual DocumentPanel DocumentPanel1
  {
    get => this._DocumentPanel1;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      QueryEntityHandler queryEntityHandler = new QueryEntityHandler(this.DocumentPanel1_QueryEntity);
      DocumentPanel documentPanel1_1 = this._DocumentPanel1;
      if (documentPanel1_1 != null)
        documentPanel1_1.QueryEntity -= queryEntityHandler;
      this._DocumentPanel1 = value;
      DocumentPanel documentPanel1_2 = this._DocumentPanel1;
      if (documentPanel1_2 == null)
        return;
      documentPanel1_2.QueryEntity += queryEntityHandler;
    }
  }

  private virtual MGATextBox txtSubject
  {
    get => this._txtSubject;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.txtSubject_AfterEnterEditMode);
      MGATextBox txtSubject1 = this._txtSubject;
      if (txtSubject1 != null)
        ((TextEditorControlBase) txtSubject1).AfterEnterEditMode -= eventHandler;
      this._txtSubject = value;
      MGATextBox txtSubject2 = this._txtSubject;
      if (txtSubject2 == null)
        return;
      ((TextEditorControlBase) txtSubject2).AfterEnterEditMode += eventHandler;
    }
  }

  private virtual MGASimpleComboBox cboNoteType
  {
    get => this._cboNoteType;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.cboNoteType_ValueChanged);
      MGASimpleComboBox cboNoteType1 = this._cboNoteType;
      if (cboNoteType1 != null)
        cboNoteType1.ValueChanged -= eventHandler;
      this._cboNoteType = value;
      MGASimpleComboBox cboNoteType2 = this._cboNoteType;
      if (cboNoteType2 == null)
        return;
      cboNoteType2.ValueChanged += eventHandler;
    }
  }

  private virtual LinkLabel lnkAddRecipient
  {
    get => this._lnkAddRecipient;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkAddRecipient_LinkClicked);
      LinkLabel lnkAddRecipient1 = this._lnkAddRecipient;
      if (lnkAddRecipient1 != null)
        lnkAddRecipient1.LinkClicked -= clickedEventHandler;
      this._lnkAddRecipient = value;
      LinkLabel lnkAddRecipient2 = this._lnkAddRecipient;
      if (lnkAddRecipient2 == null)
        return;
      lnkAddRecipient2.LinkClicked += clickedEventHandler;
    }
  }

  [field: AccessedThroughProperty("MgaTab1")]
  private virtual UltraTabControl MgaTab1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual MGATextBox txtEntry
  {
    get => this._txtEntry;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.txtEntry_AfterEnterEditMode);
      MGATextBox txtEntry1 = this._txtEntry;
      if (txtEntry1 != null)
        ((TextEditorControlBase) txtEntry1).AfterEnterEditMode -= eventHandler;
      this._txtEntry = value;
      MGATextBox txtEntry2 = this._txtEntry;
      if (txtEntry2 == null)
        return;
      ((TextEditorControlBase) txtEntry2).AfterEnterEditMode += eventHandler;
    }
  }

  private virtual LinkLabel lnkExpandScreen
  {
    get => this._lnkExpandScreen;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkExpandScreen_LinkClicked);
      LinkLabel lnkExpandScreen1 = this._lnkExpandScreen;
      if (lnkExpandScreen1 != null)
        lnkExpandScreen1.LinkClicked -= clickedEventHandler;
      this._lnkExpandScreen = value;
      LinkLabel lnkExpandScreen2 = this._lnkExpandScreen;
      if (lnkExpandScreen2 == null)
        return;
      lnkExpandScreen2.LinkClicked += clickedEventHandler;
    }
  }

  private virtual LinkLabel lnkNewNoteNewWindow
  {
    get => this._lnkNewNoteNewWindow;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkNewNoteNewWindow_LinkClicked);
      LinkLabel newNoteNewWindow1 = this._lnkNewNoteNewWindow;
      if (newNoteNewWindow1 != null)
        newNoteNewWindow1.LinkClicked -= clickedEventHandler;
      this._lnkNewNoteNewWindow = value;
      LinkLabel newNoteNewWindow2 = this._lnkNewNoteNewWindow;
      if (newNoteNewWindow2 == null)
        return;
      newNoteNewWindow2.LinkClicked += clickedEventHandler;
    }
  }

  private virtual UltraGrid grdEntries
  {
    get => this._grdEntries;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.grdEntries_AfterRowActivate);
      UltraGrid grdEntries1 = this._grdEntries;
      if (grdEntries1 != null)
        grdEntries1.AfterRowActivate -= eventHandler;
      this._grdEntries = value;
      UltraGrid grdEntries2 = this._grdEntries;
      if (grdEntries2 == null)
        return;
      grdEntries2.AfterRowActivate += eventHandler;
    }
  }

  private virtual MGACheckBox chkComplete
  {
    get => this._chkComplete;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.chkComplete_CheckedChanged);
      MGACheckBox chkComplete1 = this._chkComplete;
      if (chkComplete1 != null)
        ((UltraToggleEditorBase) chkComplete1).CheckedChanged -= eventHandler;
      this._chkComplete = value;
      MGACheckBox chkComplete2 = this._chkComplete;
      if (chkComplete2 == null)
        return;
      ((UltraToggleEditorBase) chkComplete2).CheckedChanged += eventHandler;
    }
  }

  private virtual MGAButton btnEditCancel
  {
    get => this._btnEditCancel;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnEditCancel_Click);
      MGAButton btnEditCancel1 = this._btnEditCancel;
      if (btnEditCancel1 != null)
        ((Control) btnEditCancel1).Click -= eventHandler;
      this._btnEditCancel = value;
      MGAButton btnEditCancel2 = this._btnEditCancel;
      if (btnEditCancel2 == null)
        return;
      ((Control) btnEditCancel2).Click += eventHandler;
    }
  }

  private virtual MGAButton btnNewSave
  {
    get => this._btnNewSave;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnNewSave_Click);
      MGAButton btnNewSave1 = this._btnNewSave;
      if (btnNewSave1 != null)
        ((Control) btnNewSave1).Click -= eventHandler;
      this._btnNewSave = value;
      MGAButton btnNewSave2 = this._btnNewSave;
      if (btnNewSave2 == null)
        return;
      ((Control) btnNewSave2).Click += eventHandler;
    }
  }

  private virtual LinkLabel lnkNewNote
  {
    get => this._lnkNewNote;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkNewNote_LinkClicked);
      LinkLabel lnkNewNote1 = this._lnkNewNote;
      if (lnkNewNote1 != null)
        lnkNewNote1.LinkClicked -= clickedEventHandler;
      this._lnkNewNote = value;
      LinkLabel lnkNewNote2 = this._lnkNewNote;
      if (lnkNewNote2 == null)
        return;
      lnkNewNote2.LinkClicked += clickedEventHandler;
    }
  }

  private virtual MGACheckBox chkPopup
  {
    get => this._chkPopup;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.chkPopup_CheckedChanged);
      MGACheckBox chkPopup1 = this._chkPopup;
      if (chkPopup1 != null)
        ((UltraToggleEditorBase) chkPopup1).CheckedChanged -= eventHandler;
      this._chkPopup = value;
      MGACheckBox chkPopup2 = this._chkPopup;
      if (chkPopup2 == null)
        return;
      ((UltraToggleEditorBase) chkPopup2).CheckedChanged += eventHandler;
    }
  }

  private virtual MGACheckBox chkInternal
  {
    get => this._chkInternal;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.chkInternal_CheckedChanged);
      MGACheckBox chkInternal1 = this._chkInternal;
      if (chkInternal1 != null)
        ((UltraToggleEditorBase) chkInternal1).CheckedChanged -= eventHandler;
      this._chkInternal = value;
      MGACheckBox chkInternal2 = this._chkInternal;
      if (chkInternal2 == null)
        return;
      ((UltraToggleEditorBase) chkInternal2).CheckedChanged += eventHandler;
    }
  }

  private virtual MGACheckBox chkDiaryCompleteAllTab
  {
    get => this._chkDiaryCompleteAllTab;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.chkDiaryCompleteAllTab_CheckedChanged);
      MGACheckBox diaryCompleteAllTab1 = this._chkDiaryCompleteAllTab;
      if (diaryCompleteAllTab1 != null)
        ((UltraToggleEditorBase) diaryCompleteAllTab1).CheckedChanged -= eventHandler;
      this._chkDiaryCompleteAllTab = value;
      MGACheckBox diaryCompleteAllTab2 = this._chkDiaryCompleteAllTab;
      if (diaryCompleteAllTab2 == null)
        return;
      ((UltraToggleEditorBase) diaryCompleteAllTab2).CheckedChanged += eventHandler;
    }
  }

  private virtual LinkLabel lnkViewEdits
  {
    get => this._lnkViewEdits;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkViewEdits_LinkClicked);
      LinkLabel lnkViewEdits1 = this._lnkViewEdits;
      if (lnkViewEdits1 != null)
        lnkViewEdits1.LinkClicked -= clickedEventHandler;
      this._lnkViewEdits = value;
      LinkLabel lnkViewEdits2 = this._lnkViewEdits;
      if (lnkViewEdits2 == null)
        return;
      lnkViewEdits2.LinkClicked += clickedEventHandler;
    }
  }

  private virtual CustomValidator CustomValidatorRecipientList
  {
    get => this._CustomValidatorRecipientList;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      CustomValidator.ValidateEventHandler validateEventHandler = new CustomValidator.ValidateEventHandler(this.CustomValidatorRecipientList_CustomValidate);
      CustomValidator validatorRecipientList1 = this._CustomValidatorRecipientList;
      if (validatorRecipientList1 != null)
        validatorRecipientList1.CustomValidate -= validateEventHandler;
      this._CustomValidatorRecipientList = value;
      CustomValidator validatorRecipientList2 = this._CustomValidatorRecipientList;
      if (validatorRecipientList2 == null)
        return;
      validatorRecipientList2.CustomValidate += validateEventHandler;
    }
  }

  [field: AccessedThroughProperty("ds")]
  internal virtual dsNoteForm ds { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual MGACheckBox chkRead
  {
    get => this._chkRead;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.chkRead_CheckedChanged);
      MGACheckBox chkRead1 = this._chkRead;
      if (chkRead1 != null)
        ((UltraToggleEditorBase) chkRead1).CheckedChanged -= eventHandler;
      this._chkRead = value;
      MGACheckBox chkRead2 = this._chkRead;
      if (chkRead2 == null)
        return;
      ((UltraToggleEditorBase) chkRead2).CheckedChanged += eventHandler;
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
    UltraGridBand ultraGridBand = new UltraGridBand("Entities", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("ID");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("Body");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("CreatedDate");
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("LastEditedBy");
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("IsFirstLine");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("IsDiary");
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("DueDate");
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("FinalDeadline");
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("Internal");
    Appearance appearance11 = new Appearance();
    Appearance appearance12 = new Appearance();
    Appearance appearance13 = new Appearance();
    Appearance appearance14 = new Appearance();
    Appearance appearance15 = new Appearance();
    Appearance appearance16 = new Appearance();
    Appearance appearance17 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
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
    UltraTab ultraTab1 = new UltraTab();
    Appearance appearance28 = new Appearance();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmNote));
    UltraTab ultraTab2 = new UltraTab();
    Appearance appearance29 = new Appearance();
    UltraTab ultraTab3 = new UltraTab();
    Appearance appearance30 = new Appearance();
    this.UltraTabPageControl1 = new UltraTabPageControl();
    this.chkRead = new MGACheckBox();
    this.btnEditCancel = new MGAButton();
    this.btnNewSave = new MGAButton();
    this.chkPopup = new MGACheckBox();
    this.chkInternal = new MGACheckBox();
    this.Panel1 = new Panel();
    this.Panel2 = new Panel();
    this.grdEntries = new UltraGrid();
    this.ds = new dsNoteForm();
    this.pnlEntry = new Panel();
    this.txtEntry = new MGATextBox();
    this.UltraTabPageControl2 = new UltraTabPageControl();
    this.dtFinal = new MGADateTimePicker();
    this.dtDue = new MGADateTimePicker();
    this.chkComplete = new MGACheckBox();
    this.UltraTabPageControl3 = new UltraTabPageControl();
    this.lblDiaryDeadline = new Label();
    this.lblDiaryDue = new Label();
    this.chkDiaryCompleteAllTab = new MGACheckBox();
    this.txtSubject = new MGATextBox();
    this.RequiredFieldValidatorSubject = new RequiredFieldValidator(this.components);
    this.lblDateCreated = new Label();
    this.cboNoteType = new MGASimpleComboBox();
    this.mainGroupBox = new UltraGroupBox();
    this.lbRecipients = new MGANoteRecipientListBox();
    this.lnkAddRecipient = new LinkLabel();
    this.MgaTab1 = new UltraTabControl();
    this.UltraTabSharedControlsPage2 = new UltraTabSharedControlsPage();
    this.RequiredFieldValidatorEntryText = new RequiredFieldValidator(this.components);
    this.lnkNewNote = new LinkLabel();
    this.lnkNewNoteNewWindow = new LinkLabel();
    this.lnkViewEdits = new LinkLabel();
    this.lnkExpandScreen = new LinkLabel();
    this.cnSQL = DefaultDatabase.CreateDbConnection();
    this.lblCreateBy = new Label();
    this.RequiredFieldValidatorTypeValue = new RequiredFieldValidator(this.components);
    this.CustomValidatorRecipientList = new CustomValidator(this.components);
    this.DocumentPanel1 = new DocumentPanel();
    this.EntityNotePanel1 = new EntityNotePanel();
    Splitter splitter = new Splitter();
    Label label1 = new Label();
    Label label2 = new Label();
    Label label3 = new Label();
    Label label4 = new Label();
    Label label5 = new Label();
    Label label6 = new Label();
    Label label7 = new Label();
    ((Control) this.UltraTabPageControl1).SuspendLayout();
    ((ISupportInitialize) this.chkRead).BeginInit();
    ((ISupportInitialize) this.btnEditCancel).BeginInit();
    ((ISupportInitialize) this.btnNewSave).BeginInit();
    ((ISupportInitialize) this.chkPopup).BeginInit();
    ((ISupportInitialize) this.chkInternal).BeginInit();
    this.Panel1.SuspendLayout();
    this.Panel2.SuspendLayout();
    ((ISupportInitialize) this.grdEntries).BeginInit();
    this.ds.BeginInit();
    this.pnlEntry.SuspendLayout();
    ((ISupportInitialize) this.txtEntry).BeginInit();
    ((Control) this.UltraTabPageControl2).SuspendLayout();
    ((ISupportInitialize) this.dtFinal).BeginInit();
    ((ISupportInitialize) this.dtDue).BeginInit();
    ((ISupportInitialize) this.chkComplete).BeginInit();
    ((Control) this.UltraTabPageControl3).SuspendLayout();
    ((ISupportInitialize) this.chkDiaryCompleteAllTab).BeginInit();
    ((ISupportInitialize) this.txtSubject).BeginInit();
    ((ISupportInitialize) this.RequiredFieldValidatorSubject).BeginInit();
    ((ISupportInitialize) this.cboNoteType).BeginInit();
    ((ISupportInitialize) this.mainGroupBox).BeginInit();
    ((Control) this.mainGroupBox).SuspendLayout();
    ((ISupportInitialize) this.MgaTab1).BeginInit();
    ((Control) this.MgaTab1).SuspendLayout();
    ((Control) this.UltraTabSharedControlsPage2).SuspendLayout();
    ((ISupportInitialize) this.RequiredFieldValidatorEntryText).BeginInit();
    ((ISupportInitialize) this.RequiredFieldValidatorTypeValue).BeginInit();
    ((ISupportInitialize) this.CustomValidatorRecipientList).BeginInit();
    this.SuspendLayout();
    splitter.BackColor = Color.WhiteSmoke;
    splitter.Dock = DockStyle.Bottom;
    splitter.Location = new Point(0, 128 /*0x80*/);
    splitter.Name = "Splitter1";
    splitter.Size = new Size(504, 3);
    splitter.TabIndex = 4;
    splitter.TabStop = false;
    label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    label1.AutoSize = true;
    label1.BackColor = Color.Transparent;
    label1.Location = new Point(9, (int) byte.MaxValue);
    label1.Name = "Label6";
    label1.Size = new Size(77, 13);
    label1.TabIndex = 9;
    label1.Text = "Final Deadline:";
    label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    label2.AutoSize = true;
    label2.BackColor = Color.Transparent;
    label2.Location = new Point(9, 231);
    label2.Name = "Label5";
    label2.Size = new Size(30, 13);
    label2.TabIndex = 8;
    label2.Text = "Due:";
    label3.AutoSize = true;
    label3.Location = new Point(8, 12);
    label3.Name = "Label1";
    label3.Size = new Size(47, 13);
    label3.TabIndex = 1;
    label3.Text = "Subject:";
    label4.AutoSize = true;
    label4.Location = new Point(6, 36);
    label4.Name = "Label2";
    label4.Size = new Size(50, 13);
    label4.TabIndex = 2;
    label4.Text = "Created:";
    label4.TextAlign = ContentAlignment.MiddleLeft;
    label5.AutoSize = true;
    label5.Location = new Point(344, 36);
    label5.Name = "Label3";
    label5.Size = new Size(35, 13);
    label5.TabIndex = 5;
    label5.Text = "Type:";
    label5.TextAlign = ContentAlignment.MiddleLeft;
    label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    label6.AutoSize = true;
    label6.Location = new Point(533, 29);
    label6.Name = "Label4";
    label6.Size = new Size(56, 13);
    label6.TabIndex = 9;
    label6.Text = "Recipients";
    label7.AutoSize = true;
    label7.Location = new Point(113, 36);
    label7.Name = "Label7";
    label7.Size = new Size(23, 13);
    label7.TabIndex = 12;
    label7.Text = "By:";
    label7.TextAlign = ContentAlignment.MiddleLeft;
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.chkRead);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.btnEditCancel);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.btnNewSave);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.chkPopup);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.chkInternal);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.Panel1);
    ((Control) this.UltraTabPageControl1).Location = new Point(1, 24);
    ((Control) this.UltraTabPageControl1).Name = "UltraTabPageControl1";
    ((Control) this.UltraTabPageControl1).Size = new Size(518, 278);
    appearance1.BorderColor = Color.Gray;
    appearance1.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkRead).Appearance = (AppearanceBase) appearance1;
    ((UltraToggleEditorBase) this.chkRead).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkRead).BackColorInternal = Color.Transparent;
    ((UltraToggleEditorBase) this.chkRead).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkRead).Location = new Point(8, 0);
    ((Control) this.chkRead).Name = "chkRead";
    ((Control) this.chkRead).Size = new Size(56, 20);
    ((Control) this.chkRead).TabIndex = 19;
    ((UltraToggleEditorBase) this.chkRead).Text = "Read";
    ((UltraControlBase) this.chkRead).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkRead).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.btnEditCancel).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance2.BackColor = Color.FromArgb(248, 248, 248);
    appearance2.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance2.BackGradientStyle = (GradientStyle) 2;
    appearance2.BorderColor = Color.DarkGray;
    appearance2.ImageHAlign = (HAlign) 2;
    appearance2.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnEditCancel).Appearance = (AppearanceBase) appearance2;
    ((ControlBase) this.btnEditCancel).ImageSize = new Size(21, 24);
    ((Control) this.btnEditCancel).Location = new Point(464, 227);
    ((Control) this.btnEditCancel).Name = "btnEditCancel";
    ((Control) this.btnEditCancel).Size = new Size(40, 40);
    ((Control) this.btnEditCancel).TabIndex = 16 /*0x10*/;
    this.btnEditCancel.UseOSThemes = (DefaultableBoolean) 2;
    ((Control) this.btnNewSave).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance3.BackColor = Color.FromArgb(248, 248, 248);
    appearance3.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance3.BackGradientStyle = (GradientStyle) 2;
    appearance3.BorderColor = Color.DarkGray;
    appearance3.ImageHAlign = (HAlign) 2;
    appearance3.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnNewSave).Appearance = (AppearanceBase) appearance3;
    ((ControlBase) this.btnNewSave).ImageSize = new Size(24, 24);
    ((Control) this.btnNewSave).Location = new Point(416, 227);
    ((Control) this.btnNewSave).Name = "btnNewSave";
    ((Control) this.btnNewSave).Size = new Size(40, 40);
    ((Control) this.btnNewSave).TabIndex = 15;
    this.btnNewSave.UseOSThemes = (DefaultableBoolean) 2;
    ((Control) this.chkPopup).Anchor = AnchorStyles.Top | AnchorStyles.Right;
    appearance4.BorderColor = Color.Gray;
    appearance4.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkPopup).Appearance = (AppearanceBase) appearance4;
    ((UltraToggleEditorBase) this.chkPopup).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkPopup).BackColorInternal = Color.Transparent;
    ((UltraToggleEditorBase) this.chkPopup).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkPopup).Location = new Point(448, 0);
    ((Control) this.chkPopup).Name = "chkPopup";
    ((Control) this.chkPopup).Size = new Size(56, 20);
    ((Control) this.chkPopup).TabIndex = 5;
    ((UltraToggleEditorBase) this.chkPopup).Text = "Popup";
    ((UltraControlBase) this.chkPopup).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkPopup).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.chkInternal).Anchor = AnchorStyles.Top | AnchorStyles.Right;
    appearance5.BorderColor = Color.Gray;
    appearance5.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkInternal).Appearance = (AppearanceBase) appearance5;
    ((UltraToggleEditorBase) this.chkInternal).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkInternal).BackColorInternal = Color.Transparent;
    ((UltraToggleEditorBase) this.chkInternal).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkInternal).Location = new Point(376, 0);
    ((Control) this.chkInternal).Name = "chkInternal";
    ((Control) this.chkInternal).Size = new Size(72, 20);
    ((Control) this.chkInternal).TabIndex = 4;
    ((UltraToggleEditorBase) this.chkInternal).Text = "Internal";
    ((UltraControlBase) this.chkInternal).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkInternal).UseOsThemes = (DefaultableBoolean) 2;
    this.Panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.Panel1.BackColor = Color.Transparent;
    this.Panel1.Controls.Add((Control) this.Panel2);
    this.Panel1.Controls.Add((Control) splitter);
    this.Panel1.Controls.Add((Control) this.pnlEntry);
    this.Panel1.Location = new Point(7, 24);
    this.Panel1.Name = "Panel1";
    this.Panel1.Size = new Size(504, 195);
    this.Panel1.TabIndex = 11;
    this.Panel2.Controls.Add((Control) this.grdEntries);
    this.Panel2.Dock = DockStyle.Fill;
    this.Panel2.Location = new Point(0, 0);
    this.Panel2.Name = "Panel2";
    this.Panel2.Size = new Size(504, 128 /*0x80*/);
    this.Panel2.TabIndex = 5;
    ((Control) this.grdEntries).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraGridBase) this.grdEntries).DataMember = "Entities";
    ((UltraGridBase) this.grdEntries).DataSource = (object) this.ds;
    ((SpecialBoxBase) ((UltraGridBase) this.grdEntries).DisplayLayout.AddNewBox).Prompt = " ";
    appearance6.BackColor = Color.White;
    appearance6.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.grdEntries).DisplayLayout.Appearance = (AppearanceBase) appearance6;
    ((UltraGridBase) this.grdEntries).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn1.Width = 179;
    ultraGridColumn2.Header.VisiblePosition = 1;
    ultraGridColumn2.Width = 122;
    ((AppearanceBase) appearance7).TextHAlignAsString = "Right";
    ultraGridColumn3.CellAppearance = (AppearanceBase) appearance7;
    ultraGridColumn3.Format = "d";
    ((AppearanceBase) appearance8).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn3.Header).Appearance = (AppearanceBase) appearance8;
    ((HeaderBase) ultraGridColumn3.Header).Caption = "Created";
    ultraGridColumn3.Header.VisiblePosition = 2;
    ultraGridColumn3.Width = 145;
    ((HeaderBase) ultraGridColumn4.Header).Caption = "Last Edit";
    ultraGridColumn4.Header.VisiblePosition = 3;
    ultraGridColumn4.Width = 146;
    ultraGridColumn5.Header.VisiblePosition = 4;
    ultraGridColumn5.Hidden = true;
    ultraGridColumn5.Width = 82;
    ultraGridColumn6.Header.VisiblePosition = 5;
    ultraGridColumn6.Hidden = true;
    ultraGridColumn6.Width = 30;
    ((AppearanceBase) appearance9).TextHAlignAsString = "Right";
    ultraGridColumn7.CellAppearance = (AppearanceBase) appearance9;
    ultraGridColumn7.Format = "d";
    ((AppearanceBase) appearance10).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn7.Header).Appearance = (AppearanceBase) appearance10;
    ((HeaderBase) ultraGridColumn7.Header).Caption = "Due";
    ultraGridColumn7.Header.VisiblePosition = 6;
    ultraGridColumn7.Width = 89;
    ultraGridColumn8.Header.VisiblePosition = 7;
    ultraGridColumn8.Hidden = true;
    ultraGridColumn8.Width = 52;
    ultraGridColumn9.Header.VisiblePosition = 8;
    ultraGridColumn9.Hidden = true;
    ultraGridColumn9.Width = 32 /*0x20*/;
    ultraGridBand.Columns.AddRange(new object[9]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3,
      (object) ultraGridColumn4,
      (object) ultraGridColumn5,
      (object) ultraGridColumn6,
      (object) ultraGridColumn7,
      (object) ultraGridColumn8,
      (object) ultraGridColumn9
    });
    ((UltraGridBase) this.grdEntries).DisplayLayout.BandsSerializer.Add((object) ultraGridBand);
    ((UltraGridBase) this.grdEntries).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance11.BackColor = Color.LightSteelBlue;
    appearance11.FontData.SizeInPoints = 10f;
    appearance11.ForeColor = Color.Black;
    ((UltraGridBase) this.grdEntries).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance11;
    appearance12.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance12.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance12.ForeColor = Color.Black;
    ((UltraGridBase) this.grdEntries).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance12;
    ((UltraGridBase) this.grdEntries).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.grdEntries).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.grdEntries).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    appearance13.BorderColor = Color.LightGray;
    ((UltraGridBase) this.grdEntries).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance13;
    appearance14.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.grdEntries).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance14;
    ((UltraGridBase) this.grdEntries).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance15.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.grdEntries).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance15;
    appearance16.BorderColor = Color.LightGray;
    ((UltraGridBase) this.grdEntries).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance16;
    ((UltraGridBase) this.grdEntries).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance17.BackColor = Color.Transparent;
    appearance17.ForeColor = Color.Black;
    ((UltraGridBase) this.grdEntries).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance17;
    scrollBarLook.ViewStyle = (ScrollBarViewStyle) 3;
    ((UltraGridBase) this.grdEntries).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((Control) this.grdEntries).Location = new Point(0, 0);
    ((Control) this.grdEntries).Name = "grdEntries";
    ((Control) this.grdEntries).Size = new Size(504, 128 /*0x80*/);
    ((Control) this.grdEntries).TabIndex = 1;
    ((UltraControlBase) this.grdEntries).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.grdEntries).UseOsThemes = (DefaultableBoolean) 2;
    this.ds.DataSetName = "dsNoteForm";
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.pnlEntry.Controls.Add((Control) this.txtEntry);
    this.pnlEntry.Dock = DockStyle.Bottom;
    this.pnlEntry.Location = new Point(0, 131);
    this.pnlEntry.Name = "pnlEntry";
    this.pnlEntry.Size = new Size(504, 64 /*0x40*/);
    this.pnlEntry.TabIndex = 3;
    this.txtEntry.AcceptsReturn = true;
    ((Control) this.txtEntry).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    appearance18.BackColor = Color.White;
    appearance18.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance18.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtEntry).Appearance = (AppearanceBase) appearance18;
    ((TextEditorControlBase) this.txtEntry).BackColor = Color.White;
    ((Control) this.txtEntry).Location = new Point(0, 0);
    this.txtEntry.MGAStyle = MGAStyles.Blue;
    this.txtEntry.Multiline = true;
    ((Control) this.txtEntry).Name = "txtEntry";
    ((Control) this.txtEntry).Size = new Size(504, 64 /*0x40*/);
    ((Control) this.txtEntry).TabIndex = 2;
    ((UltraControlBase) this.txtEntry).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtEntry).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) label1);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) label2);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.dtFinal);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.dtDue);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.chkComplete);
    ((Control) this.UltraTabPageControl2).Location = new Point(-10000, -10000);
    ((Control) this.UltraTabPageControl2).Name = "UltraTabPageControl2";
    ((Control) this.UltraTabPageControl2).Size = new Size(518, 278);
    ((Control) this.dtFinal).Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    appearance19.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.dtFinal.Appearance = (AppearanceBase) appearance19;
    appearance20.AlphaLevel = (short) 14;
    appearance20.BackColor = Color.FromArgb(0, 0, 246, 253);
    appearance20.BackColor2 = Color.FromArgb(133, 162, 221);
    appearance20.BackColorAlpha = (Alpha) 2;
    appearance20.BackGradientAlignment = (GradientAlignment) 4;
    appearance20.BackGradientStyle = (GradientStyle) 5;
    appearance20.BorderAlpha = (Alpha) 1;
    appearance20.BorderColor = Color.FromArgb(78, 122, 171);
    appearance20.ForeColor = Color.FromArgb(49, 85, 153);
    appearance20.ForegroundAlpha = (Alpha) 2;
    this.dtFinal.ButtonAppearance = (AppearanceBase) appearance20;
    this.dtFinal.DateTime = new DateTime(2005, 5, 5, 0, 0, 0, 0);
    ((Control) this.dtFinal).Location = new Point(97, 251);
    this.dtFinal.MGAStyle = MGAStyles.Blue;
    ((Control) this.dtFinal).Name = "dtFinal";
    ((Control) this.dtFinal).Size = new Size(96 /*0x60*/, 20);
    ((Control) this.dtFinal).TabIndex = 7;
    ((UltraControlBase) this.dtFinal).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dtFinal).UseOsThemes = (DefaultableBoolean) 2;
    this.dtFinal.Value = (object) new DateTime(2005, 5, 5, 0, 0, 0, 0);
    ((Control) this.dtDue).Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    appearance21.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.dtDue.Appearance = (AppearanceBase) appearance21;
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
    this.dtDue.ButtonAppearance = (AppearanceBase) appearance22;
    this.dtDue.DateTime = new DateTime(2005, 5, 5, 0, 0, 0, 0);
    ((Control) this.dtDue).Location = new Point(97, 227);
    this.dtDue.MGAStyle = MGAStyles.Blue;
    ((Control) this.dtDue).Name = "dtDue";
    ((Control) this.dtDue).Size = new Size(96 /*0x60*/, 20);
    ((Control) this.dtDue).TabIndex = 6;
    ((UltraControlBase) this.dtDue).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dtDue).UseOsThemes = (DefaultableBoolean) 2;
    this.dtDue.Value = (object) new DateTime(2005, 5, 5, 0, 0, 0, 0);
    appearance23.BorderColor = Color.Gray;
    appearance23.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkComplete).Appearance = (AppearanceBase) appearance23;
    ((UltraToggleEditorBase) this.chkComplete).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkComplete).BackColorInternal = Color.Transparent;
    ((UltraToggleEditorBase) this.chkComplete).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkComplete).Location = new Point(8, 0);
    ((Control) this.chkComplete).Name = "chkComplete";
    ((Control) this.chkComplete).Size = new Size(72, 20);
    ((Control) this.chkComplete).TabIndex = 12;
    ((UltraToggleEditorBase) this.chkComplete).Text = "Complete";
    ((UltraControlBase) this.chkComplete).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkComplete).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.lblDiaryDeadline);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.lblDiaryDue);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.chkDiaryCompleteAllTab);
    ((Control) this.UltraTabPageControl3).Location = new Point(-10000, -10000);
    ((Control) this.UltraTabPageControl3).Name = "UltraTabPageControl3";
    ((Control) this.UltraTabPageControl3).Size = new Size(518, 278);
    this.lblDiaryDeadline.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lblDiaryDeadline.AutoSize = true;
    this.lblDiaryDeadline.BackColor = Color.Transparent;
    this.lblDiaryDeadline.Location = new Point(5, 240 /*0xF0*/);
    this.lblDiaryDeadline.Name = "lblDiaryDeadline";
    this.lblDiaryDeadline.Size = new Size(76, 13);
    this.lblDiaryDeadline.TabIndex = 19;
    this.lblDiaryDeadline.Text = "Diary Deadline";
    this.lblDiaryDue.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lblDiaryDue.AutoSize = true;
    this.lblDiaryDue.BackColor = Color.Transparent;
    this.lblDiaryDue.Location = new Point(5, 224 /*0xE0*/);
    this.lblDiaryDue.Name = "lblDiaryDue";
    this.lblDiaryDue.Size = new Size(54, 13);
    this.lblDiaryDue.TabIndex = 18;
    this.lblDiaryDue.Text = "Diary Due";
    appearance24.BorderColor = Color.Gray;
    appearance24.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkDiaryCompleteAllTab).Appearance = (AppearanceBase) appearance24;
    ((UltraToggleEditorBase) this.chkDiaryCompleteAllTab).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkDiaryCompleteAllTab).BackColorInternal = Color.Transparent;
    ((UltraToggleEditorBase) this.chkDiaryCompleteAllTab).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkDiaryCompleteAllTab).Location = new Point(8, 0);
    ((Control) this.chkDiaryCompleteAllTab).Name = "chkDiaryCompleteAllTab";
    ((Control) this.chkDiaryCompleteAllTab).Size = new Size(72, 20);
    ((Control) this.chkDiaryCompleteAllTab).TabIndex = 17;
    ((UltraToggleEditorBase) this.chkDiaryCompleteAllTab).Text = "Complete";
    ((UltraControlBase) this.chkDiaryCompleteAllTab).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkDiaryCompleteAllTab).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.chkDiaryCompleteAllTab).Visible = false;
    ((Control) this.txtSubject).Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    appearance25.BackColor = Color.White;
    appearance25.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance25.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtSubject).Appearance = (AppearanceBase) appearance25;
    ((TextEditorControlBase) this.txtSubject).BackColor = Color.White;
    ((Control) this.txtSubject).Location = new Point(56, 8);
    ((TextEditorControlBase) this.txtSubject).MaxLength = 200;
    this.txtSubject.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtSubject).Name = "txtSubject";
    ((Control) this.txtSubject).Size = new Size(676, 20);
    ((Control) this.txtSubject).TabIndex = 1;
    ((UltraControlBase) this.txtSubject).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtSubject).UseOsThemes = (DefaultableBoolean) 2;
    this.RequiredFieldValidatorSubject.ControlToValidate = (Control) this.txtSubject;
    this.RequiredFieldValidatorSubject.Enabled = true;
    this.RequiredFieldValidatorSubject.FieldToValidate = "Text";
    this.RequiredFieldValidatorSubject.InvalidBackcolor = Color.White;
    this.lblDateCreated.AutoSize = true;
    this.lblDateCreated.Location = new Point(56, 36);
    this.lblDateCreated.Name = "lblDateCreated";
    this.lblDateCreated.Size = new Size(51, 13);
    this.lblDateCreated.TabIndex = 3;
    this.lblDateCreated.Text = "00/00/00";
    this.lblDateCreated.TextAlign = ContentAlignment.MiddleLeft;
    ((Control) this.cboNoteType).Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    this.cboNoteType.BorderStyle = (UIElementBorderStyle) 4;
    this.cboNoteType.CharacterCasing = CharacterCasing.Normal;
    this.cboNoteType.DisplayStyle = (EmbeddableElementDisplayStyle) 0;
    this.cboNoteType.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboNoteType).Location = new Point(385, 32 /*0x20*/);
    this.cboNoteType.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboNoteType).Name = "cboNoteType";
    ((Control) this.cboNoteType).Size = new Size(347, 21);
    ((Control) this.cboNoteType).TabIndex = 0;
    ((UltraControlBase) this.cboNoteType).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboNoteType).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.mainGroupBox).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    appearance26.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.mainGroupBox.ContentAreaAppearance = (AppearanceBase) appearance26;
    ((Control) this.mainGroupBox).Controls.Add((Control) label6);
    ((Control) this.mainGroupBox).Controls.Add((Control) this.lbRecipients);
    ((Control) this.mainGroupBox).Controls.Add((Control) this.lnkAddRecipient);
    ((Control) this.mainGroupBox).Controls.Add((Control) this.MgaTab1);
    appearance27.ForeColor = Color.Black;
    this.mainGroupBox.HeaderAppearance = (AppearanceBase) appearance27;
    ((Control) this.mainGroupBox).Location = new Point(8, 56);
    ((Control) this.mainGroupBox).Name = "mainGroupBox";
    ((Control) this.mainGroupBox).Size = new Size(728, 333);
    ((Control) this.mainGroupBox).TabIndex = 7;
    this.mainGroupBox.Text = "Entries";
    this.mainGroupBox.ViewStyle = (GroupBoxViewStyle) 2;
    this.lbRecipients.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
    this.lbRecipients.BackColor = Color.White;
    this.lbRecipients.BorderStyle = BorderStyle.FixedSingle;
    this.lbRecipients.DrawMode = DrawMode.OwnerDrawFixed;
    this.lbRecipients.ForeColor = Color.Black;
    this.lbRecipients.IntegralHeight = false;
    this.lbRecipients.Location = new Point(536, 48 /*0x30*/);
    this.lbRecipients.Name = "lbRecipients";
    this.lbRecipients.Size = new Size(176 /*0xB0*/, 277);
    this.lbRecipients.Sorted = true;
    this.lbRecipients.TabIndex = 0;
    this.lnkAddRecipient.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.lnkAddRecipient.AutoSize = true;
    this.lnkAddRecipient.Location = new Point(645, 32 /*0x20*/);
    this.lnkAddRecipient.Name = "lnkAddRecipient";
    this.lnkAddRecipient.Size = new Size(67, 13);
    this.lnkAddRecipient.TabIndex = 8;
    this.lnkAddRecipient.TabStop = true;
    this.lnkAddRecipient.Text = "Add/Change";
    ((Control) this.MgaTab1).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((Control) this.MgaTab1).Controls.Add((Control) this.UltraTabSharedControlsPage2);
    ((Control) this.MgaTab1).Controls.Add((Control) this.UltraTabPageControl1);
    ((Control) this.MgaTab1).Controls.Add((Control) this.UltraTabPageControl2);
    ((Control) this.MgaTab1).Controls.Add((Control) this.UltraTabPageControl3);
    ((Control) this.MgaTab1).Location = new Point(8, 22);
    ((Control) this.MgaTab1).Name = "MgaTab1";
    ((UltraTabControlBase) this.MgaTab1).SharedControls.AddRange(new Control[5]
    {
      (Control) this.btnEditCancel,
      (Control) this.btnNewSave,
      (Control) this.chkPopup,
      (Control) this.chkInternal,
      (Control) this.Panel1
    });
    ((UltraTabControlBase) this.MgaTab1).SharedControlsPage = this.UltraTabSharedControlsPage2;
    ((Control) this.MgaTab1).Size = new Size(520, 303);
    ((Control) this.MgaTab1).TabIndex = 8;
    ((UltraTabControlBase) this.MgaTab1).TabLayoutStyle = (TabLayoutStyle) 1;
    appearance28.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance27.Image"));
    ultraTab1.Appearance = (AppearanceBase) appearance28;
    ultraTab1.Key = "NONDIARY";
    ultraTab1.TabPage = this.UltraTabPageControl1;
    ultraTab1.Text = "Messages";
    ultraTab1.ToolTipText = "All entries not marked as diaries";
    appearance29.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance28.Image"));
    ultraTab2.Appearance = (AppearanceBase) appearance29;
    ultraTab2.Key = "DIARY";
    ultraTab2.TabPage = this.UltraTabPageControl2;
    ultraTab2.Text = "Tasks";
    ultraTab2.ToolTipText = "All entries marked as diary";
    appearance30.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance29.Image"));
    ultraTab3.Appearance = (AppearanceBase) appearance30;
    ultraTab3.Key = "ALL";
    ultraTab3.TabPage = this.UltraTabPageControl3;
    ultraTab3.Text = "All";
    ultraTab3.ToolTipText = "All entries on the note";
    ((UltraTabControlBase) this.MgaTab1).Tabs.AddRange(new UltraTab[3]
    {
      ultraTab1,
      ultraTab2,
      ultraTab3
    });
    ((UltraTabControlBase) this.MgaTab1).TabSize = new Size(100, 23);
    ((UltraControlBase) this.MgaTab1).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaTab1).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraTabControlBase) this.MgaTab1).ViewStyle = (ViewStyle) 4;
    ((Control) this.UltraTabSharedControlsPage2).Controls.Add((Control) this.btnEditCancel);
    ((Control) this.UltraTabSharedControlsPage2).Controls.Add((Control) this.btnNewSave);
    ((Control) this.UltraTabSharedControlsPage2).Controls.Add((Control) this.chkPopup);
    ((Control) this.UltraTabSharedControlsPage2).Controls.Add((Control) this.chkInternal);
    ((Control) this.UltraTabSharedControlsPage2).Controls.Add((Control) this.Panel1);
    ((Control) this.UltraTabSharedControlsPage2).Location = new Point(-10000, -10000);
    ((Control) this.UltraTabSharedControlsPage2).Name = "UltraTabSharedControlsPage2";
    ((Control) this.UltraTabSharedControlsPage2).Size = new Size(518, 278);
    this.RequiredFieldValidatorEntryText.ControlToValidate = (Control) this.txtEntry;
    this.RequiredFieldValidatorEntryText.Enabled = true;
    this.RequiredFieldValidatorEntryText.FieldToValidate = "Text";
    this.RequiredFieldValidatorEntryText.InvalidBackcolor = Color.White;
    this.lnkNewNote.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.lnkNewNote.AutoSize = true;
    this.lnkNewNote.Location = new Point(544, 393);
    this.lnkNewNote.Name = "lnkNewNote";
    this.lnkNewNote.Size = new Size(53, 13);
    this.lnkNewNote.TabIndex = 9;
    this.lnkNewNote.TabStop = true;
    this.lnkNewNote.Text = "New note";
    this.lnkNewNoteNewWindow.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.lnkNewNoteNewWindow.AutoSize = true;
    this.lnkNewNoteNewWindow.Location = new Point(600, 393);
    this.lnkNewNoteNewWindow.Name = "lnkNewNoteNewWindow";
    this.lnkNewNoteNewWindow.Size = new Size(126, 13);
    this.lnkNewNoteNewWindow.TabIndex = 10;
    this.lnkNewNoteNewWindow.TabStop = true;
    this.lnkNewNoteNewWindow.Text = "New note in new window";
    this.lnkViewEdits.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.lnkViewEdits.AutoSize = true;
    this.lnkViewEdits.Location = new Point(448, 393);
    this.lnkViewEdits.Name = "lnkViewEdits";
    this.lnkViewEdits.Size = new Size(84, 13);
    this.lnkViewEdits.TabIndex = 14;
    this.lnkViewEdits.TabStop = true;
    this.lnkViewEdits.Text = "View Entry Edits";
    this.lnkViewEdits.Visible = false;
    this.lnkExpandScreen.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkExpandScreen.Location = new Point(8, 393);
    this.lnkExpandScreen.Name = "lnkExpandScreen";
    this.lnkExpandScreen.Size = new Size(192 /*0xC0*/, 16 /*0x10*/);
    this.lnkExpandScreen.TabIndex = 11;
    this.lnkExpandScreen.TabStop = true;
    this.lnkExpandScreen.Text = "Display docs and entities on this note";
    this.lblCreateBy.AutoSize = true;
    this.lblCreateBy.Location = new Point(142, 36);
    this.lblCreateBy.Name = "lblCreateBy";
    this.lblCreateBy.Size = new Size(62, 13);
    this.lblCreateBy.TabIndex = 13;
    this.lblCreateBy.Text = "lblCreateBy";
    this.lblCreateBy.TextAlign = ContentAlignment.MiddleLeft;
    this.RequiredFieldValidatorTypeValue.ControlToValidate = (Control) this.cboNoteType;
    this.RequiredFieldValidatorTypeValue.Enabled = true;
    this.RequiredFieldValidatorTypeValue.FieldToValidate = "Value";
    this.RequiredFieldValidatorTypeValue.InvalidBackcolor = Color.White;
    this.CustomValidatorRecipientList.ControlToValidate = (Control) this.lbRecipients;
    this.CustomValidatorRecipientList.Enabled = true;
    this.CustomValidatorRecipientList.ErrorMessage = "Please add at least one recipient";
    this.CustomValidatorRecipientList.FieldToValidate = "Text";
    this.DocumentPanel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.DocumentPanel1.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.DocumentPanel1.Location = new Point(8, 409);
    this.DocumentPanel1.Name = "DocumentPanel1";
    this.DocumentPanel1.NoteGuid = new Guid("00000000-0000-0000-0000-000000000000");
    this.DocumentPanel1.Size = new Size(504, 104);
    this.DocumentPanel1.TabIndex = 34;
    this.EntityNotePanel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.EntityNotePanel1.BackColor = Color.White;
    this.EntityNotePanel1.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.EntityNotePanel1.ForeColor = Color.Black;
    this.EntityNotePanel1.Location = new Point(520, 409);
    this.EntityNotePanel1.Name = "EntityNotePanel1";
    this.EntityNotePanel1.NoteGUID = new Guid("00000000-0000-0000-0000-000000000000");
    this.EntityNotePanel1.Size = new Size(216, 104);
    this.EntityNotePanel1.TabIndex = 15;
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.White;
    this.ClientSize = new Size(744, 519);
    this.Controls.Add((Control) this.DocumentPanel1);
    this.Controls.Add((Control) this.EntityNotePanel1);
    this.Controls.Add((Control) this.lnkViewEdits);
    this.Controls.Add((Control) this.lblCreateBy);
    this.Controls.Add((Control) label7);
    this.Controls.Add((Control) this.lnkNewNoteNewWindow);
    this.Controls.Add((Control) this.lnkNewNote);
    this.Controls.Add((Control) this.mainGroupBox);
    this.Controls.Add((Control) label5);
    this.Controls.Add((Control) this.lblDateCreated);
    this.Controls.Add((Control) label4);
    this.Controls.Add((Control) label3);
    this.Controls.Add((Control) this.lnkExpandScreen);
    this.Controls.Add((Control) this.cboNoteType);
    this.Controls.Add((Control) this.txtSubject);
    this.DoubleBuffered = true;
    this.Font = new Font("Tahoma", 8.25f);
    this.ForeColor = Color.Black;
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.MinimumSize = new Size(520, 384);
    this.Name = nameof (frmNote);
    this.Text = " ";
    ((Control) this.UltraTabPageControl1).ResumeLayout(false);
    ((ISupportInitialize) this.chkRead).EndInit();
    ((ISupportInitialize) this.btnEditCancel).EndInit();
    ((ISupportInitialize) this.btnNewSave).EndInit();
    ((ISupportInitialize) this.chkPopup).EndInit();
    ((ISupportInitialize) this.chkInternal).EndInit();
    this.Panel1.ResumeLayout(false);
    this.Panel2.ResumeLayout(false);
    ((ISupportInitialize) this.grdEntries).EndInit();
    this.ds.EndInit();
    this.pnlEntry.ResumeLayout(false);
    this.pnlEntry.PerformLayout();
    ((ISupportInitialize) this.txtEntry).EndInit();
    ((Control) this.UltraTabPageControl2).ResumeLayout(false);
    ((Control) this.UltraTabPageControl2).PerformLayout();
    ((ISupportInitialize) this.dtFinal).EndInit();
    ((ISupportInitialize) this.dtDue).EndInit();
    ((ISupportInitialize) this.chkComplete).EndInit();
    ((Control) this.UltraTabPageControl3).ResumeLayout(false);
    ((Control) this.UltraTabPageControl3).PerformLayout();
    ((ISupportInitialize) this.chkDiaryCompleteAllTab).EndInit();
    ((ISupportInitialize) this.txtSubject).EndInit();
    ((ISupportInitialize) this.RequiredFieldValidatorSubject).EndInit();
    ((ISupportInitialize) this.cboNoteType).EndInit();
    ((ISupportInitialize) this.mainGroupBox).EndInit();
    ((Control) this.mainGroupBox).ResumeLayout(false);
    ((Control) this.mainGroupBox).PerformLayout();
    ((ISupportInitialize) this.MgaTab1).EndInit();
    ((Control) this.MgaTab1).ResumeLayout(false);
    ((Control) this.UltraTabSharedControlsPage2).ResumeLayout(false);
    ((ISupportInitialize) this.RequiredFieldValidatorEntryText).EndInit();
    ((ISupportInitialize) this.RequiredFieldValidatorTypeValue).EndInit();
    ((ISupportInitialize) this.CustomValidatorRecipientList).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private void ExpandDocsAndEntities(bool expand)
  {
    if (expand == this._docsAndEntitiesExpanded)
      return;
    this.MinimumSize = new Size(0, 0);
    this._docsAndEntitiesExpanded = expand;
    AnchorStyles anchor1 = ((Control) this.mainGroupBox).Anchor;
    AnchorStyles anchor2 = this.lnkViewEdits.Anchor;
    AnchorStyles anchor3 = this.lnkExpandScreen.Anchor;
    AnchorStyles anchor4 = this.lnkNewNote.Anchor;
    AnchorStyles anchor5 = this.lnkNewNoteNewWindow.Anchor;
    AnchorStyles anchor6 = this.EntityNotePanel1.Anchor;
    AnchorStyles anchor7 = this.DocumentPanel1.Anchor;
    this.EntityNotePanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left;
    this.DocumentPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left;
    this.lnkViewEdits.Anchor = AnchorStyles.Top | AnchorStyles.Left;
    this.lnkExpandScreen.Anchor = AnchorStyles.Top | AnchorStyles.Left;
    this.lnkNewNote.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.lnkNewNoteNewWindow.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    ((Control) this.mainGroupBox).Anchor = AnchorStyles.Top | AnchorStyles.Right;
    if (expand)
    {
      this.Height += 112 /*0x70*/;
      this.lnkExpandScreen.Text = "Hide docs and entities on this note";
      this.MinimumSize = new Size(520, 496);
    }
    else
    {
      this.Height -= 112 /*0x70*/;
      this.lnkExpandScreen.Text = "Display docs and entities on this note";
      this.MinimumSize = new Size(520, 384);
    }
    ((Control) this.mainGroupBox).Anchor = anchor1;
    this.lnkViewEdits.Anchor = anchor2;
    this.lnkExpandScreen.Anchor = anchor3;
    this.lnkNewNote.Anchor = anchor4;
    this.lnkNewNoteNewWindow.Anchor = anchor5;
    this.EntityNotePanel1.Anchor = anchor6;
    this.DocumentPanel1.Anchor = anchor7;
  }

  private void lnkExpandScreen_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    this.ExpandDocsAndEntities(!this._docsAndEntitiesExpanded);
  }

  private void StartDataFetch()
  {
    this.lbRecipients.Clear();
    this.cboNoteType.Text = "Loading...";
    ThreadPool.QueueUserWorkItem(new WaitCallback(this.InitialThreadedDataFetch));
  }

  private void SetupNoteState(frmNote.NoteState state)
  {
    if (MDIControls.Instance.MDIParent.InvokeRequired)
    {
      MDIControls.Instance.MDIParent.BetterInvoke((Delegate) new frmNote.SetupNoteStateHandler(this.SetupNoteState), (object) state);
    }
    else
    {
      this._noteState = state;
      switch (this._noteState)
      {
        case frmNote.NoteState.NewNoteWithNoEntriesNotEditing:
          this.lnkViewEdits.Enabled = true;
          this.RequiredFieldValidatorEntryText.Enabled = false;
          this.RequiredFieldValidatorSubject.Enabled = false;
          this.RequiredFieldValidatorTypeValue.Enabled = false;
          ((Control) this.chkInternal).Enabled = true;
          this.lblDateCreated.Text = this.CurrentDate.ToShortDateString();
          this.lblCreateBy.Text = $"{CurrentUser.Instance.LastName}, {CurrentUser.Instance.FirstName}";
          ((TextEditorControlBase) this.txtSubject).Text = string.Empty;
          ((TextEditorControlBase) this.txtEntry).Text = string.Empty;
          ((Control) this.grdEntries).Enabled = true;
          this.EnableAllTabs();
          ((Control) this.btnEditCancel).Visible = false;
          ((Control) this.btnNewSave).Visible = true;
          ((ControlBase) this.btnNewSave).Appearance.Image = (object) ImageCache.Instance.NewImage;
          this.lnkAddRecipient.Enabled = false;
          this.cboNoteType.ReadOnly = false;
          this.lnkNewNote.Enabled = true;
          this.lnkNewNoteNewWindow.Enabled = true;
          ((EditorButtonControlBase) this.txtEntry).ReadOnly = true;
          ((Control) this.dtFinal).Enabled = false;
          ((Control) this.dtDue).Enabled = false;
          ((EditorButtonControlBase) this.txtEntry).ReadOnly = true;
          ((Control) this.cboNoteType).Enabled = false;
          ((Control) this.dtFinal).Enabled = false;
          ((Control) this.dtDue).Enabled = false;
          this.DocumentPanel1.Enabled = false;
          break;
        case frmNote.NoteState.NewNoteWithNoEntriesEditingFirstEntry:
          this.lnkViewEdits.Enabled = false;
          this.RequiredFieldValidatorEntryText.Enabled = true;
          this.RequiredFieldValidatorSubject.Enabled = true;
          this.RequiredFieldValidatorTypeValue.Enabled = true;
          ((Control) this.chkInternal).Enabled = true;
          this._ignoreClickPopup = true;
          this._ignoreClickInternal = true;
          ((UltraToggleEditorBase) this.chkInternal).Checked = false;
          this._ignoreClickInternal = false;
          this._ignoreClickPopup = false;
          ((Control) this.grdEntries).Enabled = false;
          this.DisableAllTab();
          ((Control) this.btnEditCancel).Visible = true;
          ((Control) this.btnNewSave).Visible = true;
          ((ControlBase) this.btnNewSave).Appearance.Image = (object) ImageCache.Instance.Save;
          ((ControlBase) this.btnEditCancel).Appearance.Image = (object) ImageCache.Instance.Undo;
          this.lnkAddRecipient.Enabled = true;
          this.cboNoteType.ReadOnly = false;
          this.lnkNewNote.Enabled = false;
          this.lnkNewNoteNewWindow.Enabled = false;
          this.dtDue.DateTime = this.CurrentDate.AddDays(1.0);
          this.dtFinal.DateTime = this.CurrentDate.AddDays(14.0);
          ((TextEditorControlBase) this.txtEntry).Text = string.Empty;
          ((EditorButtonControlBase) this.txtEntry).ReadOnly = false;
          ((Control) this.dtFinal).Enabled = true;
          ((Control) this.dtDue).Enabled = true;
          this.DocumentPanel1.Enabled = false;
          break;
        case frmNote.NoteState.NoteWithEntriesUnknown:
          this.lnkViewEdits.Enabled = true;
          this.RequiredFieldValidatorEntryText.Enabled = false;
          this.RequiredFieldValidatorSubject.Enabled = false;
          this.RequiredFieldValidatorTypeValue.Enabled = false;
          ((Control) this.chkInternal).Enabled = true;
          this.EnableAllTabs();
          ((Control) this.grdEntries).Enabled = true;
          ((Control) this.btnEditCancel).Visible = true;
          ((Control) this.btnNewSave).Visible = true;
          ((ControlBase) this.btnNewSave).Appearance.Image = (object) ImageCache.Instance.NewImage;
          ((ControlBase) this.btnEditCancel).Appearance.Image = (object) ImageCache.Instance.Edit;
          this.lnkAddRecipient.Enabled = false;
          this.cboNoteType.ReadOnly = true;
          this.lnkNewNote.Enabled = true;
          this.lnkNewNoteNewWindow.Enabled = true;
          ((EditorButtonControlBase) this.txtEntry).ReadOnly = true;
          ((Control) this.dtFinal).Enabled = false;
          ((Control) this.dtDue).Enabled = false;
          this.DocumentPanel1.Enabled = true;
          break;
        case frmNote.NoteState.NoteWithEntriesNotEditing:
          this.lnkViewEdits.Enabled = true;
          this.RequiredFieldValidatorEntryText.Enabled = false;
          this.RequiredFieldValidatorSubject.Enabled = false;
          this.RequiredFieldValidatorTypeValue.Enabled = false;
          ((Control) this.chkInternal).Enabled = true;
          this.EnableAllTabs();
          ((Control) this.grdEntries).Enabled = true;
          ((Control) this.btnEditCancel).Visible = true;
          ((Control) this.btnNewSave).Visible = true;
          ((ControlBase) this.btnNewSave).Appearance.Image = (object) ImageCache.Instance.NewImage;
          ((ControlBase) this.btnEditCancel).Appearance.Image = (object) ImageCache.Instance.Edit;
          this.lnkAddRecipient.Enabled = false;
          this.cboNoteType.ReadOnly = true;
          this.lnkNewNote.Enabled = true;
          this.lnkNewNoteNewWindow.Enabled = true;
          ((EditorButtonControlBase) this.txtEntry).ReadOnly = true;
          ((Control) this.dtFinal).Enabled = false;
          ((Control) this.dtDue).Enabled = false;
          this.DocumentPanel1.Enabled = true;
          break;
        case frmNote.NoteState.NoteWithNoActiveEntries:
          this.lnkViewEdits.Enabled = true;
          this.RequiredFieldValidatorEntryText.Enabled = false;
          this.RequiredFieldValidatorSubject.Enabled = false;
          this.RequiredFieldValidatorTypeValue.Enabled = false;
          ((Control) this.chkInternal).Enabled = true;
          this.EnableAllTabs();
          ((TextEditorControlBase) this.txtEntry).Text = string.Empty;
          ((Control) this.grdEntries).Enabled = true;
          ((Control) this.btnEditCancel).Visible = false;
          ((Control) this.btnNewSave).Visible = true;
          ((ControlBase) this.btnNewSave).Appearance.Image = (object) ImageCache.Instance.NewImage;
          ((ControlBase) this.btnEditCancel).Appearance.Image = (object) ImageCache.Instance.Edit;
          this.lnkAddRecipient.Enabled = false;
          this.cboNoteType.ReadOnly = true;
          this.lnkNewNote.Enabled = true;
          this.lnkNewNoteNewWindow.Enabled = true;
          ((EditorButtonControlBase) this.txtEntry).ReadOnly = true;
          ((Control) this.dtFinal).Enabled = false;
          ((Control) this.dtDue).Enabled = false;
          this.DocumentPanel1.Enabled = true;
          break;
        case frmNote.NoteState.NoteWithEntriesEditingExistingEntry:
          this.lnkViewEdits.Enabled = false;
          this.RequiredFieldValidatorEntryText.Enabled = true;
          this.RequiredFieldValidatorSubject.Enabled = false;
          this.RequiredFieldValidatorTypeValue.Enabled = false;
          ((Control) this.chkInternal).Enabled = true;
          ((Control) this.grdEntries).Enabled = false;
          this.DisableAllButCurrentTab();
          ((Control) this.btnEditCancel).Visible = true;
          ((Control) this.btnNewSave).Visible = true;
          ((ControlBase) this.btnNewSave).Appearance.Image = (object) ImageCache.Instance.Save;
          ((ControlBase) this.btnEditCancel).Appearance.Image = (object) ImageCache.Instance.Undo;
          this.lnkAddRecipient.Enabled = false;
          this.cboNoteType.ReadOnly = true;
          this.lnkNewNote.Enabled = false;
          this.lnkNewNoteNewWindow.Enabled = false;
          ((EditorButtonControlBase) this.txtEntry).ReadOnly = false;
          ((Control) this.dtFinal).Enabled = false;
          ((Control) this.dtDue).Enabled = false;
          this.DocumentPanel1.Enabled = true;
          break;
        case frmNote.NoteState.NoteWithEntriesEditingNewEntry:
          this.lnkViewEdits.Enabled = false;
          this.dtDue.DateTime = this.CurrentDate.AddDays(1.0);
          this.dtFinal.DateTime = this.CurrentDate.AddDays(14.0);
          ((TextEditorControlBase) this.txtEntry).Text = string.Empty;
          this.RequiredFieldValidatorEntryText.Enabled = true;
          this.RequiredFieldValidatorSubject.Enabled = false;
          this.RequiredFieldValidatorTypeValue.Enabled = false;
          ((Control) this.chkInternal).Enabled = true;
          this._ignoreClickInternal = true;
          ((UltraToggleEditorBase) this.chkInternal).Checked = false;
          this._ignoreClickInternal = false;
          this._ignoreClickPopup = false;
          ((Control) this.grdEntries).Enabled = false;
          this.DisableAllTab();
          ((Control) this.btnEditCancel).Visible = true;
          ((Control) this.btnNewSave).Visible = true;
          ((ControlBase) this.btnNewSave).Appearance.Image = (object) ImageCache.Instance.Save;
          ((ControlBase) this.btnEditCancel).Appearance.Image = (object) ImageCache.Instance.Undo;
          this.lnkAddRecipient.Enabled = true;
          this.cboNoteType.ReadOnly = true;
          this.lnkNewNote.Enabled = false;
          this.lnkNewNoteNewWindow.Enabled = false;
          ((EditorButtonControlBase) this.txtEntry).ReadOnly = false;
          ((Control) this.dtFinal).Enabled = true;
          ((Control) this.dtDue).Enabled = true;
          this.DocumentPanel1.Enabled = true;
          break;
      }
    }
  }

  private frmNote.NoteState CurrentNoteState
  {
    get => this._noteState;
    set => this.SetupNoteState(value);
  }

  private void InitialThreadedDataFetch(object state)
  {
    this._tblNoteTypes = Database.Instance.QueryText.PerformTableQuery("SELECT NoteTypeID, Description FROM dbo.lstNoteTypes (NOLOCK)");
    this._tblUsers = Database.Instance.QueryText.PerformTableQuery("SELECT lastName + ', ' + firstname as FullName, UserGUID FROM dbo.tblUsers (NOLOCK)");
    this._tblSystemUsers = Database.Instance.QueryText.PerformTableQuery("SELECT SystemEntityID, Description FROM dbo.lstSystemEntities (NOLOCK)");
    if (this.CurrentNoteState != frmNote.NoteState.NewNoteWithNoEntriesNotEditing && this.CurrentNoteState != frmNote.NoteState.NewNoteWithNoEntriesNotEditing)
    {
      this.ds.tblNoteStore.Clear();
      Database.Instance.QueryText.PerformTableQuery("SELECT CreatedDate, Type, Subject, UserGUID,SystemEntityID FROM tblNoteStore (NOLOCK) WHERE [ID] = @NoteGUID", (DataTable) this.ds.tblNoteStore, (object) "@NoteGUID", (object) this._noteGuid);
    }
    if (this._formLoaded && !this._controlsBound && this.Visible && !this.IsDisposed && !this.Disposing)
      this.BetterInvoke((Delegate) new EventHandler(this.BindControls));
    this._dataFetchThreadCompleted = true;
  }

  private void RefreshEntryGrid()
  {
    if (this.CurrentNoteState == frmNote.NoteState.NewNoteWithNoEntriesNotEditing || this.CurrentNoteState == frmNote.NoteState.NewNoteWithNoEntriesEditingFirstEntry)
      return;
    this.CurrentNoteState = frmNote.NoteState.NoteWithEntriesUnknown;
    Database.Instance.QueryMultithreadedSP.PerformTableQuery(new TableQueryMultithreadEventHandler(this.Entries_TableFilled), (Control) this, (object) "Entries_TableFilled", "dbo.NoteForm_RefreshEntryGrid", (object) "@NoteGUID", (object) this._noteGuid);
  }

  private void Entries_TableFilled(object sender, TableQueryMultithreadEventArgs e)
  {
    this.ConvertTableToEntryTable(e.Table);
    UltraGrid grdEntries = this.grdEntries;
    ((UltraGridBase) grdEntries).DisplayLayout.Override.RowSizing = (RowSizing) 5;
    ((UltraGridBase) grdEntries).DisplayLayout.Override.CellMultiLine = (DefaultableBoolean) 1;
    ((UltraGridBase) grdEntries).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((UltraGridBase) grdEntries).DisplayLayout.Override.RowSpacingAfter = 0;
    ((UltraGridBase) grdEntries).DisplayLayout.Override.RowSpacingBefore = 0;
    ((UltraControlBase) grdEntries).DrawFilter = (IUIElementDrawFilter) this;
    if (e.Table.Rows.Count > 0)
    {
      this.lnkViewEdits.Enabled = true;
      if (this._initialEntryGUID.Equals(Guid.Empty))
      {
        if (((UltraGridBase) this.grdEntries).Rows.Count > 0)
          ((UltraGridBase) this.grdEntries).ActiveRow = ((UltraGridBase) this.grdEntries).Rows[0];
      }
      else
      {
        foreach (UltraGridRow row in ((UltraGridBase) this.grdEntries).Rows)
        {
          if (((Guid) row.Cells["ID"].Value).Equals(this._initialEntryGUID))
          {
            ((UltraGridBase) this.grdEntries).ActiveRow = row;
            break;
          }
        }
        this._initialEntryGUID = Guid.Empty;
      }
      if (((UltraGridBase) this.grdEntries).ActiveRow != null)
        this.PopulateRecipients((Guid) ((UltraGridBase) this.grdEntries).ActiveRow.Cells["ID"].Value);
    }
    else
      this.lnkViewEdits.Enabled = false;
    if (this._firstEntryViewLoadWithBoundDoc && this._initialEntryGUID.Equals(Guid.Empty) && this.ds.Entities.Count > 0 && this.ds.Entities[this.ds.Entities.Count - 1].IsDiary)
      ((UltraTabControlBase) this.MgaTab1).SelectedTab = ((UltraTabControlBase) this.MgaTab1).Tabs["DIARY"];
    this.UpdateEntryView();
  }

  private void BindControls(object sender, EventArgs e)
  {
    this._controlsBound = true;
    MGASimpleComboBox cboNoteType = this.cboNoteType;
    ((UltraGridBase) cboNoteType).DataSource = (object) this._tblNoteTypes;
    ((UltraDropDownBase) cboNoteType).DisplayMember = "Description";
    ((UltraDropDownBase) cboNoteType).ValueMember = "NoteTypeID";
    if (this.ds.tblNoteStore.Count > 0 && this.CurrentNoteState != frmNote.NoteState.NewNoteWithNoEntriesEditingFirstEntry && this.CurrentNoteState != frmNote.NoteState.NewNoteWithNoEntriesNotEditing)
    {
      dsNoteForm.tblNoteStoreRow tblNoteStoreRow = this.ds.tblNoteStore[0];
      this.lblDateCreated.Text = tblNoteStoreRow.CreatedDate.ToShortDateString();
      this.cboNoteType.Value = (object) tblNoteStoreRow.Type;
      ((TextEditorControlBase) this.txtSubject).Text = tblNoteStoreRow.Subject;
      this._initialSubject = ((TextEditorControlBase) this.txtSubject).Text;
      if (!tblNoteStoreRow.IsUserGUIDNull())
      {
        DataRow[] dataRowArray = this._tblUsers.Select($"UserGUID = '{tblNoteStoreRow.UserGUID.ToString()}'");
        this.lblCreateBy.Text = dataRowArray == null || dataRowArray.Length <= 0 ? "Unknown user" : Conversions.ToString(dataRowArray[0]["FullName"]);
      }
      else
      {
        DataRow[] dataRowArray = this._tblSystemUsers.Select($"SystemEntityID = '{tblNoteStoreRow.SystemEntityID.ToString()}'");
        this.lblCreateBy.Text = dataRowArray == null || dataRowArray.Length <= 0 ? "Unknown user" : Conversions.ToString(dataRowArray[0]["Description"]);
      }
    }
    this.EntityNotePanel1.NoteGUID = this._noteGuid;
    if (this._noteSupportCache == null)
    {
      DataRow dataRow = (DataRow) null;
      DataTable dataTable = Database.Instance.QuerySP.PerformTableQuery("NoteSystem_FetchEntitiesOnNote", (object) "@NoteGUID", (object) this._noteGuid);
      if (dataTable.Rows.Count > 1)
      {
        using (frmNoteResolveEntity noteResolveEntity = new frmNoteResolveEntity())
        {
          try
          {
            foreach (DataRow row in dataTable.Rows)
              noteResolveEntity.AddEntity(row, Conversions.ToString(row["EntityName"]));
          }
          finally
          {
            IEnumerator enumerator;
            if (enumerator is IDisposable)
              (enumerator as IDisposable).Dispose();
          }
          int num = (int) noteResolveEntity.ShowDialog((IWin32Window) this);
          dataRow = noteResolveEntity.ActiveEntityRow;
        }
      }
      else if (dataTable.Rows.Count == 1)
        dataRow = dataTable.Rows[0];
      if (dataRow != null)
      {
        object obj = dataRow["AssociatedEntityGUID"];
        this._noteSupportCache = new MGASystems.IMS.NoteDocuments.NoteDiarySystem.NoteSupportCache(obj != null ? (Guid) obj : new Guid(), Conversions.ToString(dataRow["EntityName"]), Conversions.ToString(dataRow["EntityFormName"]), Conversions.ToString(dataRow["EntityType"]), false, Guid.Empty);
        DocumentManager.FireEntityDocumentCollectionChanged();
      }
    }
    this.RefreshEntryGrid();
  }

  private void InitializeData()
  {
    this._firstEntryViewLoadWithBoundDoc = true;
    this.StartDataFetch();
    this._formLoaded = true;
    if (this.CurrentNoteState == frmNote.NoteState.NewNoteWithNoEntriesEditingFirstEntry || this.CurrentNoteState == frmNote.NoteState.NewNoteWithNoEntriesNotEditing)
    {
      this.lblCreateBy.Text = $"{CurrentUser.Instance.LastName}, {CurrentUser.Instance.FirstName}";
      this.lblDateCreated.Text = this.CurrentDate.ToShortDateString();
    }
    this.ExpandDocsAndEntities(false);
    this.ExpandDocsAndEntities(Preferences.GetPreferenceBool("Screens.Note.DocumentsAndEntities.Visible"));
    this.pnlEntry.Height = Preferences.GetPreferenceInt("Screens.Note.EntryEdit.Height");
    if (this._dataFetchThreadCompleted && !this._controlsBound)
      this.BindControls((object) this, EventArgs.Empty);
    if (this.CurrentNoteState == frmNote.NoteState.NewNoteWithNoEntriesEditingFirstEntry && this._noteSupportCache != null)
      this.EntityNotePanel1.AddPlaceHolderItem($"{this.NoteSupportCache.EntityName} / Carrier: {Database.Instance.QueryText.PerformScalarQueryString("SELECT tblCompanyLocations.Name   FROM tblQuotes  (NOLOCK)  INNER JOIN tblCompanyLocations (NOLOCK) ON tblQuotes.CompanyLocationGuid = tblCompanyLocations.CompanyLocationGUID  WHERE .tblQuotes.ControlGuid = @cGuid", (object) "@cGuid", (object) this.NoteSupportCache.ControlGUID)}", this.NoteSupportCache.EntityGuid, this.NoteSupportCache.RecreateTypeName);
    this.lnkViewEdits.Visible = SecurityManager.Instance.AssertPermission("{88D709B6-0BDC-411d-9EAA-1A664AA9C362}");
    if (this._documentGuids != null)
    {
      Guid[] documentGuids = this._documentGuids;
      int index = 0;
      while (index < documentGuids.Length)
      {
        Guid documentGuid = documentGuids[index];
        DocSupportCache docSupportCache = new DocSupportCache((ISupportDocumentSystem) this);
        docSupportCache.SetEntityGUID(this._noteGuid);
        DocSupportCache docSupport = docSupportCache;
        DocumentManager.BindDocument(documentGuid, (ISupportDocumentSystem) docSupport);
        this.DocumentPanel1.RefreshView();
        checked { ++index; }
      }
    }
    this.Refresh();
    this.Height = Preferences.GetPreferenceInt("Screens.Note.Height");
    this.Width = Preferences.GetPreferenceInt("Screens.Note.Width");
    if (this.CurrentNoteState == frmNote.NoteState.NewNoteWithNoEntriesEditingFirstEntry || this.CurrentNoteState == frmNote.NoteState.NoteWithEntriesEditingNewEntry)
      this.AddCurrentUserToRecipientList();
    ((UltraTabControlBase) this.MgaTab1).SelectedTabChanging += new SelectedTabChangingEventHandler(this.MgaTab1_SelectedTabChanging);
    ((UltraTabControlBase) this.MgaTab1).SelectedTabChanged += new SelectedTabChangedEventHandler(this.MgaTab1_SelectedTabChanged);
  }

  private void frmNote_Load(object sender, EventArgs e)
  {
    this.InitializeData();
    if (this._noteState != frmNote.NoteState.NewNoteWithNoEntriesEditingFirstEntry && this._noteState != frmNote.NoteState.NewNoteWithNoEntriesNotEditing)
      return;
    ((TextEditorControlBase) this.txtSubject).Text = "Please choose a Note Type first";
    ((EditorButtonControlBase) this.txtSubject).ReadOnly = true;
  }

  public Guid NoteGuid => this._noteGuid;

  public bool HasNoteGuid => !this._noteGuid.Equals(Guid.Empty);

  private void frmNote_Closing(object sender, CancelEventArgs e)
  {
    if (this.CurrentNoteState != frmNote.NoteState.NewNoteWithNoEntriesEditingFirstEntry && this.CurrentNoteState != frmNote.NoteState.NewNoteWithNoEntriesNotEditing && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((TextEditorControlBase) this.txtSubject).Text, this._initialSubject, false) != 0)
    {
      this.RequiredFieldValidatorSubject.Enabled = true;
      this.RequiredFieldValidatorSubject.Validate();
      if (this.RequiredFieldValidatorSubject.IsValid)
      {
        Note_System.Instance.NonInteractive.BeginUpdateNote(this._noteGuid, ((TextEditorControlBase) this.txtSubject).Text);
      }
      else
      {
        e.Cancel = true;
        return;
      }
    }
    if (this.CurrentNoteState == frmNote.NoteState.NewNoteWithNoEntriesEditingFirstEntry || this.CurrentNoteState == frmNote.NoteState.NoteWithEntriesEditingExistingEntry || this.CurrentNoteState == frmNote.NoteState.NoteWithEntriesEditingNewEntry)
    {
      switch (MessageBox.Show("You are currently editing this note, would you like to save it before closing?", "Edit in progress", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question))
      {
        case DialogResult.Cancel:
          e.Cancel = true;
          return;
        case DialogResult.Yes:
          if (!this.RequiredFieldValidatorTypeValue.IsAllValidatorsValid)
          {
            e.Cancel = true;
            return;
          }
          this.DoSave();
          break;
      }
    }
    if (((UltraTabControlBase) this.MgaTab1).SelectedTab != null)
      Preferences.SetPreference("Screens.Note.SelectedEntryTab", ((UltraTabControlBase) this.MgaTab1).SelectedTab.Index);
    Preferences.SetPreference("Screens.Note.DocumentsAndEntities.Visible", this._docsAndEntitiesExpanded);
    Preferences.SetPreference("Screens.Note.EntryEdit.Height", this.pnlEntry.Height);
    this.ExpandDocsAndEntities(false);
    Preferences.SetPreference("Screens.Note.Height", this.Height);
    Preferences.SetPreference("Screens.Note.Width", this.Width);
  }

  public frmNote(ISupportNoteSystem noteSupport)
  {
    this.Load += new EventHandler(this.frmNote_Load);
    this.Closing += new CancelEventHandler(this.frmNote_Closing);
    this._fullBodyHash = new Dictionary<Guid, string>();
    this._docsAndEntitiesExpanded = true;
    this._initialEntryGUID = Guid.Empty;
    this._useServerDateTime = SystemSettings.GetSetting<bool>("NoteView.UseServerDateTime");
    this._noteGuid = Guid.NewGuid();
    this.InitializeComponent();
    this.CurrentNoteState = frmNote.NoteState.NewNoteWithNoEntriesEditingFirstEntry;
    this._noteSupportCache = new MGASystems.IMS.NoteDocuments.NoteDiarySystem.NoteSupportCache(noteSupport);
    this.DocumentPanel1.NoteGuid = this._noteGuid;
  }

  public frmNote(Guid noteGUID, ISupportNoteSystem noteSupport)
  {
    this.Load += new EventHandler(this.frmNote_Load);
    this.Closing += new CancelEventHandler(this.frmNote_Closing);
    this._fullBodyHash = new Dictionary<Guid, string>();
    this._docsAndEntitiesExpanded = true;
    this._initialEntryGUID = Guid.Empty;
    this._useServerDateTime = SystemSettings.GetSetting<bool>("NoteView.UseServerDateTime");
    this.InitializeComponent();
    this.CurrentNoteState = frmNote.NoteState.NoteWithEntriesUnknown;
    this._noteGuid = noteGUID;
    this._noteSupportCache = new MGASystems.IMS.NoteDocuments.NoteDiarySystem.NoteSupportCache(noteSupport);
    this.DocumentPanel1.NoteGuid = this._noteGuid;
  }

  public frmNote(Guid noteGUID, Guid entryGUID, ISupportNoteSystem noteSupport)
  {
    this.Load += new EventHandler(this.frmNote_Load);
    this.Closing += new CancelEventHandler(this.frmNote_Closing);
    this._fullBodyHash = new Dictionary<Guid, string>();
    this._docsAndEntitiesExpanded = true;
    this._initialEntryGUID = Guid.Empty;
    this._useServerDateTime = SystemSettings.GetSetting<bool>("NoteView.UseServerDateTime");
    this.InitializeComponent();
    this.CurrentNoteState = frmNote.NoteState.NoteWithEntriesUnknown;
    this._noteGuid = noteGUID;
    this._initialEntryGUID = entryGUID;
    if (noteSupport != null)
      this._noteSupportCache = new MGASystems.IMS.NoteDocuments.NoteDiarySystem.NoteSupportCache(noteSupport);
    this.DocumentPanel1.NoteGuid = this._noteGuid;
  }

  public frmNote(Guid noteGUID)
  {
    this.Load += new EventHandler(this.frmNote_Load);
    this.Closing += new CancelEventHandler(this.frmNote_Closing);
    this._fullBodyHash = new Dictionary<Guid, string>();
    this._docsAndEntitiesExpanded = true;
    this._initialEntryGUID = Guid.Empty;
    this._useServerDateTime = SystemSettings.GetSetting<bool>("NoteView.UseServerDateTime");
    this.InitializeComponent();
    this.CurrentNoteState = frmNote.NoteState.NoteWithEntriesUnknown;
    this._noteGuid = noteGUID;
    this.DocumentPanel1.NoteGuid = this._noteGuid;
  }

  public frmNote(Guid noteGUID, bool startInEditMode)
  {
    this.Load += new EventHandler(this.frmNote_Load);
    this.Closing += new CancelEventHandler(this.frmNote_Closing);
    this._fullBodyHash = new Dictionary<Guid, string>();
    this._docsAndEntitiesExpanded = true;
    this._initialEntryGUID = Guid.Empty;
    this._useServerDateTime = SystemSettings.GetSetting<bool>("NoteView.UseServerDateTime");
    this.InitializeComponent();
    this.CurrentNoteState = frmNote.NoteState.NoteWithEntriesUnknown;
    this._noteGuid = noteGUID;
    this.DocumentPanel1.NoteGuid = this._noteGuid;
    this._startInEditMode = startInEditMode;
  }

  public frmNote(Guid noteGUID, Guid[] documentGuids, ISupportDocumentSystem docSupport)
  {
    this.Load += new EventHandler(this.frmNote_Load);
    this.Closing += new CancelEventHandler(this.frmNote_Closing);
    this._fullBodyHash = new Dictionary<Guid, string>();
    this._docsAndEntitiesExpanded = true;
    this._initialEntryGUID = Guid.Empty;
    this._useServerDateTime = SystemSettings.GetSetting<bool>("NoteView.UseServerDateTime");
    this.InitializeComponent();
    this.CurrentNoteState = frmNote.NoteState.NoteWithEntriesUnknown;
    this._noteGuid = noteGUID;
    this._documentGuids = documentGuids;
    ISupportDocumentSystem supportDocumentSystem = docSupport;
    this._noteSupportCache = new MGASystems.IMS.NoteDocuments.NoteDiarySystem.NoteSupportCache(supportDocumentSystem.EntityGuid, supportDocumentSystem.EntityName, supportDocumentSystem.FriendlyEntityName, supportDocumentSystem.RecreateTypeName, supportDocumentSystem.HasControlGUID, supportDocumentSystem.ControlGUID);
    this.DocumentPanel1.NoteGuid = this._noteGuid;
    this._startInEditMode = true;
  }

  public frmNote()
  {
    this.Load += new EventHandler(this.frmNote_Load);
    this.Closing += new CancelEventHandler(this.frmNote_Closing);
    this._fullBodyHash = new Dictionary<Guid, string>();
    this._docsAndEntitiesExpanded = true;
    this._initialEntryGUID = Guid.Empty;
    this._useServerDateTime = SystemSettings.GetSetting<bool>("NoteView.UseServerDateTime");
    this._unbound = true;
    this.InitializeComponent();
    this.CurrentNoteState = frmNote.NoteState.NewNoteWithNoEntriesEditingFirstEntry;
    this._noteSupportCache = new MGASystems.IMS.NoteDocuments.NoteDiarySystem.NoteSupportCache();
    this._noteGuid = Guid.NewGuid();
    this.DocumentPanel1.NoteGuid = this._noteGuid;
  }

  private void lnkNewNoteNewWindow_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    (this._noteSupportCache == null ? (Control) new frmNote() : (Control) new frmNote((ISupportNoteSystem) this._noteSupportCache)).Show();
  }

  bool IRecreatableEntity.CanReCreateEntity
  {
    get => this._noteSupportCache != null && this._noteSupportCache.CanReCreateEntity;
  }

  Guid IRecreatableEntity.EntityGuid
  {
    get => this._noteSupportCache != null ? this._noteSupportCache.EntityGUID : Guid.Empty;
  }

  string IRecreatableEntity.EntityName
  {
    get => this._noteSupportCache != null ? this._noteSupportCache.EntityName : string.Empty;
  }

  string IRecreatableEntity.FriendlyEntityName
  {
    get
    {
      return this._noteSupportCache != null ? this._noteSupportCache.FriendlyEntityName : string.Empty;
    }
  }

  bool IRecreatableEntity.RecreateEntityInitialize(Guid entityGuid)
  {
    this._noteGuid = Database.Instance.QuerySP.PerformScalarQueryGuid("NoteSystem_NoteGuidFromEntryGuid", (object) "@EntryGuid", (object) entityGuid);
    bool flag;
    if (!this._noteGuid.Equals(Guid.Empty))
    {
      this.CurrentNoteState = frmNote.NoteState.NoteWithEntriesUnknown;
      this.DocumentPanel1.NoteGuid = this._noteGuid;
      this.InitializeData();
      flag = true;
    }
    else
      flag = false;
    return flag;
  }

  string IRecreatableEntity.RecreateTypeName
  {
    get => this._noteSupportCache != null ? this._noteSupportCache.RecreateTypeName : string.Empty;
  }

  public event ISupportNoteSystem.EntityInfoChangedEventHandler EntityInfoChanged;

  public bool CanCreateNewNote
  {
    get => this._noteSupportCache != null && this._noteSupportCache.CanCreateNewNote;
  }

  private string[] GetEntryBreakDown(string body)
  {
    if (string.IsNullOrEmpty(body))
      body = " ";
    Graphics graphics = (Graphics) null;
    List<string> stringList1 = new List<string>();
    try
    {
      List<string> stringList2 = new List<string>();
      graphics = this.CreateGraphics();
      Font font = ((Control) this.grdEntries).Font;
      int num1 = (int) Math.Round((double) graphics.MeasureString("OOOOOOOOOO", font).Width);
      int num2 = (int) Math.Round((double) (int) Math.Round((double) (((Control) this.grdEntries).ClientSize.Width - SystemInformation.VerticalScrollBarWidth) * 0.65) / (double) num1) * 10;
      int length = body.Length;
      char[] charArray = body.ToCharArray();
      StringBuilder stringBuilder1 = new StringBuilder();
      int num3 = 0;
      int num4 = length - 1;
      for (int index1 = 0; index1 <= num4; ++index1)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Conversions.ToString(charArray[index1]), "\r\n", false) == 0 || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Conversions.ToString(charArray[index1]), "\n", false) == 0)
        {
          stringList2.Add(stringBuilder1.ToString());
          stringBuilder1 = new StringBuilder();
          num3 = 0;
        }
        else if (num3 >= num2)
        {
          int num5 = 0;
          int num6 = index1;
          int num7 = length;
          for (int index2 = num6; index2 <= num7; ++index2)
          {
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Conversions.ToString(charArray[index2]), "\r\n", false) == 0 || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Conversions.ToString(charArray[index2]), "\n", false) == 0 || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Conversions.ToString(charArray[index2]), " ", false) == 0 || index2 >= length - 1)
            {
              stringList2.Add(stringBuilder1.ToString());
              num5 = index2;
              break;
            }
            stringBuilder1.Append(charArray[index2]);
            ++num3;
          }
          index1 = num5;
          stringBuilder1 = new StringBuilder();
          num3 = 0;
        }
        else
          stringBuilder1.Append(charArray[index1]);
        if (stringList2.Count >= 6)
        {
          StringBuilder stringBuilder2 = new StringBuilder();
          int num8 = 1;
          try
          {
            foreach (string str in stringList2)
            {
              stringBuilder2.Append(str);
              if (num8 < stringList2.Count)
                stringBuilder2.Append("\r\n");
              ++num8;
            }
          }
          finally
          {
            List<string>.Enumerator enumerator;
            enumerator.Dispose();
          }
          stringList1.Add(stringBuilder2.ToString());
          stringList2.Clear();
        }
        ++num3;
      }
      StringBuilder stringBuilder3 = new StringBuilder();
      int num9 = 1;
      try
      {
        foreach (string str in stringList2)
        {
          stringBuilder3.Append(str);
          if (num9 < stringList2.Count)
            stringBuilder3.Append("\r\n");
          ++num9;
        }
      }
      finally
      {
        List<string>.Enumerator enumerator;
        enumerator.Dispose();
      }
      if (stringBuilder3.Length > 0)
        stringList1.Add(stringBuilder3.ToString());
      if (stringBuilder1.Length > 0)
        stringList1.Add(stringBuilder1.ToString());
    }
    finally
    {
      graphics?.Dispose();
    }
    return stringList1.ToArray();
  }

  private void ConvertTableToEntryTable(DataTable table)
  {
    int num1 = 0;
    int num2 = 0;
    this._fullBodyHash.Clear();
    this.ds.Entities.Clear();
    try
    {
      foreach (DataRow row1 in table.Rows)
      {
        this._fullBodyHash.Add((Guid) row1["ID"], Conversions.ToString(row1["Body"]));
        string[] entryBreakDown = this.GetEntryBreakDown(Conversions.ToString(row1["Body"]));
        bool flag = true;
        if (row1.IsNull("DueDate"))
          ++num2;
        else
          ++num1;
        string[] strArray = entryBreakDown;
        int index = 0;
        while (index < strArray.Length)
        {
          string str = strArray[index];
          dsNoteForm.EntitiesRow row2 = this.ds.Entities.NewEntitiesRow();
          if (flag)
          {
            flag = false;
            row2.ID = (Guid) row1["ID"];
            row2.Body = str;
            row2.CreatedDate = Conversions.ToDate(row1["CreatedDate"]);
            row2.LastEditedBy = row1["LastEditedBy"].ToString();
            row2.IsFirstLine = true;
            row2.Internal = Conversions.ToBoolean(row1["Internal"]);
            this.ds.Entities.AddEntitiesRow(row2);
          }
          else
          {
            row2.ID = (Guid) row1["ID"];
            row2.Body = str;
            row2.IsFirstLine = false;
            row2.Internal = Conversions.ToBoolean(row1["Internal"]);
            this.ds.Entities.AddEntitiesRow(row2);
          }
          if (row1.IsNull("DueDate"))
          {
            row2.IsDiary = false;
            row2.DueDate = this.CurrentDate;
            row2.FinalDeadline = this.CurrentDate;
          }
          else
          {
            row2.IsDiary = true;
            row2.DueDate = Conversions.ToDate(row1["DueDate"]);
            row2.FinalDeadline = Conversions.ToDate(row1["FinalDeadline"]);
          }
          checked { ++index; }
        }
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    ((UltraTabControlBase) this.MgaTab1).Tabs["NONDIARY"].Text = $"Messages ({num2})";
    ((UltraTabControlBase) this.MgaTab1).Tabs["DIARY"].Text = $"Tasks ({num1})";
    ((UltraTabControlBase) this.MgaTab1).Tabs["ALL"].Text = $"All ({num1 + num2})";
  }

  public bool DrawElement(DrawPhase drawPhase, ref UIElementDrawParams drawParams)
  {
    UIElement element = ((UIElementDrawParams) ref drawParams).Element;
    bool flag1;
    switch (element)
    {
      case EmbeddableUIElementBase _:
        UltraGridCell context = (UltraGridCell) element.GetContext(typeof (UltraGridCell));
        UltraGridRow row = context.Row;
        if (context.Column.Index == 1)
        {
          flag1 = !Conversions.ToBoolean(row.Cells["IsFirstLine"].Value);
          break;
        }
        if (context.Column.Index == 2)
        {
          flag1 = !Conversions.ToBoolean(row.Cells["IsFirstLine"].Value);
          break;
        }
        break;
      case RowCellAreaUIElement _:
        flag1 = Conversions.ToBoolean(((UltraGridCell) element.GetDescendant(typeof (CellUIElement)).GetContext(typeof (UltraGridCell))).Row.Cells["IsFirstLine"].Value);
        break;
    }
    DrawPhase drawPhase1 = drawPhase;
    bool flag2;
    if (drawPhase1 != 128 /*0x80*/)
    {
      if (drawPhase1 == 65536 /*0x010000*/)
      {
        if (((UIElementDrawParams) ref drawParams).Element is RowCellAreaUIElement)
        {
          if (flag1)
          {
            ((UIElementDrawParams) ref drawParams).DrawBorders((UIElementBorderStyle) 4, Border3DSide.Top, Rectangle.Inflate(((UIElementDrawParams) ref drawParams).Element.Rect, 0, 0));
          }
          else
          {
            ((AppearanceData) ref drawParams.AppearanceData).BorderColor = SystemColors.Window;
            ((UIElementDrawParams) ref drawParams).DrawBorders((UIElementBorderStyle) 4, Border3DSide.Top, Rectangle.Inflate(((UIElementDrawParams) ref drawParams).Element.Rect, 0, 0));
          }
        }
        flag2 = true;
      }
      else
        flag2 = false;
    }
    else
      flag2 = true;
    return flag2;
  }

  public DrawPhase GetPhasesToFilter(ref UIElementDrawParams drawParams)
  {
    DrawPhase phasesToFilter;
    if (((UIElementDrawParams) ref drawParams).Element is CellUIElement || ((UIElementDrawParams) ref drawParams).Element is RowCellAreaUIElement)
      phasesToFilter = (DrawPhase) 65664 /*0x010080*/;
    else if (((UIElementDrawParams) ref drawParams).Element is EmbeddableUIElementBase)
      phasesToFilter = (DrawPhase) 1;
    return phasesToFilter;
  }

  private void MgaTab1_SelectedTabChanging(object sender, SelectedTabChangingEventArgs e)
  {
    if (this.CurrentNoteState != frmNote.NoteState.NewNoteWithNoEntriesEditingFirstEntry && this.CurrentNoteState != frmNote.NoteState.NoteWithEntriesEditingNewEntry || this.lbRecipients.Items.Count <= 1)
      return;
    if (MessageBox.Show("Changing the entry type will require you to re-enter your recipients, are you sure you want to change the entry type?", "Recipient re-entry required", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
      this.AddCurrentUserToRecipientList();
    else
      ((CancelEventArgs) e).Cancel = true;
  }

  private void MgaTab1_SelectedTabChanged(object sender, SelectedTabChangedEventArgs e)
  {
    if (this.CurrentNoteState == frmNote.NoteState.NoteWithEntriesNotEditing || this.CurrentNoteState == frmNote.NoteState.NoteWithNoActiveEntries)
      this.CurrentNoteState = frmNote.NoteState.NoteWithEntriesUnknown;
    if (this.CurrentNoteState == frmNote.NoteState.NewNoteWithNoEntriesEditingFirstEntry || this.CurrentNoteState == frmNote.NoteState.NoteWithEntriesEditingNewEntry)
      this.AddCurrentUserToRecipientList();
    this.UpdateEntryView();
  }

  private void UpdateEntryView()
  {
    if (((UltraGridBase) this.grdEntries).DataSource == null)
      return;
    string key = ((UltraTabControlBase) this.MgaTab1).SelectedTab.Key;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "NONDIARY", false) != 0)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "DIARY", false) != 0)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "ALL", false) == 0)
          ((dsNoteForm) ((UltraGridBase) this.grdEntries).DataSource).Entities.DefaultView.RowFilter = string.Empty;
      }
      else
        ((dsNoteForm) ((UltraGridBase) this.grdEntries).DataSource).Entities.DefaultView.RowFilter = "IsDiary = true";
    }
    else
      ((dsNoteForm) ((UltraGridBase) this.grdEntries).DataSource).Entities.DefaultView.RowFilter = "IsDiary = false";
    if (this.CurrentNoteState == frmNote.NoteState.NoteWithEntriesUnknown)
    {
      if (((UltraGridBase) this.grdEntries).Rows.Count > 0)
      {
        this.CurrentNoteState = frmNote.NoteState.NoteWithEntriesNotEditing;
        ((Control) this.chkComplete).Enabled = true;
        ((Control) this.chkRead).Enabled = true;
      }
      else
      {
        this.CurrentNoteState = frmNote.NoteState.NoteWithNoActiveEntries;
        ((Control) this.chkComplete).Enabled = false;
        ((Control) this.chkRead).Enabled = false;
      }
    }
    if (this.IsStartedInEditMode && this._firstEntryViewLoadWithBoundDoc && ((UltraGridBase) this.grdEntries).Rows.Count > 0)
    {
      this._firstEntryViewLoadWithBoundDoc = false;
      this.ClickEdit();
      ((TextEditorControlBase) this.txtEntry).SelectAll();
      this.lnkAddRecipient.Enabled = true;
      ((Control) this.cboNoteType).Enabled = true;
      this.cboNoteType.ReadOnly = false;
      ((Control) this.dtDue).Enabled = true;
      ((Control) this.dtFinal).Enabled = true;
      this.RequiredFieldValidatorTypeValue.Enabled = true;
      this.RequiredFieldValidatorEntryText.Enabled = true;
      this.CustomValidatorRecipientList.Enabled = true;
      this.RequiredFieldValidatorSubject.Enabled = true;
    }
    if (((UltraGridBase) this.grdEntries).Rows.Count != 0)
      return;
    this.lbRecipients.Clear();
  }

  private bool IsStartedInEditMode => this._startInEditMode;

  private void grdEntries_AfterRowActivate(object sender, EventArgs e)
  {
    if (((UltraGridBase) this.grdEntries).ActiveRow != null)
    {
      object obj = ((UltraGridBase) this.grdEntries).ActiveRow.Cells["ID"].Value;
      Guid guid = obj != null ? (Guid) obj : new Guid();
      bool boolean1 = Conversions.ToBoolean(((UltraGridBase) this.grdEntries).ActiveRow.Cells["IsDiary"].Value);
      ((Control) this.chkDiaryCompleteAllTab).Visible = boolean1;
      bool boolean2 = Conversions.ToBoolean(((UltraGridBase) this.grdEntries).ActiveRow.Cells["Internal"].Value);
      this._ignoreClickInternal = true;
      ((UltraToggleEditorBase) this.chkInternal).Checked = boolean2;
      this._ignoreClickInternal = false;
      this.PopulateRecipients(guid);
      Database.Instance.QueryMultithreadedText.PerformScalarQuery((Control) this, (object) guid, "SELECT Popup FROM tblNoteEntries (NOLOCK) WHERE [ID] = @EntryGUID", new ScalarQueryMultithreadedEventHandler(this.IsPopupEntry_ScalarQueryCompleted), (object) "@EntryGUID", (object) guid);
      if (boolean1)
      {
        Database.Instance.QueryMultithreadedText.PerformScalarQuery((Control) this, (object) guid, "SELECT CompletedDate FROM tblNoteRecipients (NOLOCK) WHERE EntryGUID = @EntryGUID AND UserGUID = @UserGUID", new ScalarQueryMultithreadedEventHandler(this.DiaryComplete_ScalarQueryCompleted), (object) "@EntryGUID", (object) guid, (object) "@UserGUID", (object) CurrentUser.Instance.UserGUID);
        this.dtDue.DateTime = Conversions.ToDate(((UltraGridBase) this.grdEntries).ActiveRow.Cells["DueDate"].Value);
        this.dtFinal.DateTime = Conversions.ToDate(((UltraGridBase) this.grdEntries).ActiveRow.Cells["FinalDeadline"].Value);
        Label lblDiaryDue = this.lblDiaryDue;
        DateTime dateTime = this.dtDue.DateTime;
        string str1 = $"Due: {dateTime.ToShortDateString()}";
        lblDiaryDue.Text = str1;
        Label lblDiaryDeadline = this.lblDiaryDeadline;
        dateTime = this.dtFinal.DateTime;
        string str2 = $"Final Deadline: {dateTime.ToShortDateString()}";
        lblDiaryDeadline.Text = str2;
      }
      Database.Instance.QueryMultithreadedText.PerformScalarQuery((Control) this, (object) guid, "SELECT IsRead FROM tblNoteRecipients (NOLOCK) WHERE EntryGUID = @EntryGUID AND UserGUID = @UserGUID", new ScalarQueryMultithreadedEventHandler(this.NoteRead_ScalarQueryCompleted), (object) "@EntryGUID", (object) guid, (object) "@UserGUID", (object) CurrentUser.Instance.UserGUID);
      if (!this.IsEditing && this._fullBodyHash.ContainsKey(guid))
        ((TextEditorControlBase) this.txtEntry).Text = this._fullBodyHash[guid];
    }
    else
      ((Control) this.chkDiaryCompleteAllTab).Visible = false;
    this.lblDiaryDeadline.Visible = ((Control) this.chkDiaryCompleteAllTab).Visible;
    this.lblDiaryDue.Visible = ((Control) this.chkDiaryCompleteAllTab).Visible;
  }

  private void IsPopupEntry_ScalarQueryCompleted(object sender, ScalarQueryMultithreadedEventArgs e)
  {
    this._ignoreClickPopup = true;
    ((UltraToggleEditorBase) this.chkPopup).Checked = Conversions.ToBoolean(e.Result);
    this._ignoreClickPopup = false;
  }

  private void DiaryComplete_ScalarQueryCompleted(
    object sender,
    ScalarQueryMultithreadedEventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((UltraTabControlBase) this.MgaTab1).SelectedTab.Key, "DIARY", false) != 0 || ((UltraGridBase) this.grdEntries).ActiveRow == null)
      return;
    object key = e.Key;
    Guid guid = key != null ? (Guid) key : new Guid();
    object obj = ((UltraGridBase) this.grdEntries).ActiveRow.Cells["ID"].Value;
    Guid g = obj != null ? (Guid) obj : new Guid();
    if (!guid.Equals(g))
      return;
    this._ignoreClickDiary = true;
    if (Database.IsValueNull(RuntimeHelpers.GetObjectValue(e.Result)))
      ((UltraToggleEditorBase) this.chkDiaryCompleteAllTab).Checked = false;
    else
      ((UltraToggleEditorBase) this.chkDiaryCompleteAllTab).Checked = true;
    this._ignoreClickDiary = false;
  }

  private void NoteRead_ScalarQueryCompleted(object sender, ScalarQueryMultithreadedEventArgs e)
  {
    if (((UltraGridBase) this.grdEntries).ActiveRow == null)
      return;
    object key = e.Key;
    Guid guid = key != null ? (Guid) key : new Guid();
    object obj = ((UltraGridBase) this.grdEntries).ActiveRow.Cells["ID"].Value;
    Guid g = obj != null ? (Guid) obj : new Guid();
    if (!guid.Equals(g))
      return;
    this._ignoreClickNote = true;
    if (Database.IsNull(RuntimeHelpers.GetObjectValue(e.Result), 0) == 0)
      ((UltraToggleEditorBase) this.chkRead).Checked = false;
    else
      ((UltraToggleEditorBase) this.chkRead).Checked = true;
    this._ignoreClickNote = false;
  }

  private void PopulateRecipients(Guid entryGUID)
  {
    this.lbRecipients.Clear();
    if (entryGUID.Equals(Guid.Empty))
      return;
    Database.Instance.QueryMultithreadedText.PerformTableQuery(new TableQueryMultithreadEventHandler(this.Recipients_TableFilled), (Control) this, (object) nameof (PopulateRecipients), "SELECT UserGUID, IsRead, IsDiary, CompletedDate FROM tblNoteRecipients (NOLOCK) WHERE (EntryGUID = @EntryGUID)", (object) "@EntryGUID", (object) entryGUID);
  }

  private void Recipients_TableFilled(object sender, TableQueryMultithreadEventArgs e)
  {
    int num1 = 0;
    int num2 = 0;
    this.lbRecipients.Clear();
    try
    {
      foreach (DataRow row in e.Table.Rows)
      {
        string str = string.Empty;
        Guid guid1;
        if (!row.IsNull("UserGUID"))
        {
          object obj = row["UserGUID"];
          Guid guid2;
          if (obj == null)
          {
            guid1 = new Guid();
            guid2 = guid1;
          }
          else
            guid2 = (Guid) obj;
          DataRow[] dataRowArray = this._tblUsers.Select($"UserGUID = '{guid2.ToString()}'");
          str = dataRowArray == null || dataRowArray.Length <= 0 ? "Unknown user" : Conversions.ToString(dataRowArray[0]["FullName"]);
        }
        MGANoteRecipientListBox.DiaryStatus diaryStatus;
        if (Conversions.ToBoolean(row["IsDiary"]))
        {
          ++num1;
          this._ignoreClickDiary = true;
          if (!row.IsNull("CompletedDate"))
            ++num2;
          if (row.IsNull("CompletedDate"))
          {
            diaryStatus = MGANoteRecipientListBox.DiaryStatus.NotComplete;
            if (!row.IsNull("UserGUID"))
            {
              object obj = row["UserGUID"];
              Guid guid3;
              if (obj == null)
              {
                guid1 = new Guid();
                guid3 = guid1;
              }
              else
                guid3 = (Guid) obj;
              guid1 = guid3;
              if (guid1.Equals(CurrentUser.Instance.UserGUID))
                ((UltraToggleEditorBase) this.chkDiaryCompleteAllTab).Checked = false;
            }
          }
          else
          {
            diaryStatus = MGANoteRecipientListBox.DiaryStatus.Complete;
            if (!row.IsNull("UserGUID"))
            {
              object obj = row["UserGUID"];
              Guid guid4;
              if (obj == null)
              {
                guid1 = new Guid();
                guid4 = guid1;
              }
              else
                guid4 = (Guid) obj;
              guid1 = guid4;
              if (guid1.Equals(CurrentUser.Instance.UserGUID))
                ((UltraToggleEditorBase) this.chkDiaryCompleteAllTab).Checked = true;
            }
          }
          this._ignoreClickDiary = false;
        }
        else
          diaryStatus = MGANoteRecipientListBox.DiaryStatus.None;
        MGANoteRecipientListBox lbRecipients = this.lbRecipients;
        object obj1 = row["UserGUID"];
        Guid userGuid;
        if (obj1 == null)
        {
          guid1 = new Guid();
          userGuid = guid1;
        }
        else
          userGuid = (Guid) obj1;
        string userName = str;
        int num3 = Conversions.ToBoolean(row["IsRead"]) ? 1 : 0;
        int diary = (int) diaryStatus;
        lbRecipients.AddUser(userGuid, userName, num3 != 0, (MGANoteRecipientListBox.DiaryStatus) diary);
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    this._ignoreClickDiary = true;
    if (num1 > 0)
    {
      if (num1 == num2)
        ((UltraToggleEditorBase) this.chkComplete).CheckState = CheckState.Checked;
      else if (num2 == 0)
        ((UltraToggleEditorBase) this.chkComplete).CheckState = CheckState.Unchecked;
      else
        ((UltraToggleEditorBase) this.chkComplete).CheckState = CheckState.Indeterminate;
    }
    this._ignoreClickDiary = false;
  }

  private void DisableAllButCurrentTab()
  {
    if (((UltraGridBase) this.grdEntries).ActiveRow == null)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((UltraTabControlBase) this.MgaTab1).SelectedTab.Key, "ALL", false) == 0)
        ((UltraTabControlBase) this.MgaTab1).Tabs["NONDIARY"].Selected = true;
      foreach (UltraTab tab in ((UltraTabControlBase) this.MgaTab1).Tabs)
      {
        if (!tab.Active)
          tab.Enabled = false;
      }
    }
    else
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((UltraTabControlBase) this.MgaTab1).SelectedTab.Key, "ALL", false) == 0)
      {
        if (Conversions.ToBoolean(((UltraGridBase) this.grdEntries).ActiveRow.Cells["IsDiary"].Value))
          ((UltraTabControlBase) this.MgaTab1).Tabs["DIARY"].Selected = true;
        else
          ((UltraTabControlBase) this.MgaTab1).Tabs["NONDIARY"].Selected = true;
      }
      foreach (UltraTab tab in ((UltraTabControlBase) this.MgaTab1).Tabs)
      {
        if (!tab.Active)
          tab.Enabled = false;
      }
    }
  }

  private void DisableAllTab()
  {
    if (((UltraTabControlBase) this.MgaTab1).SelectedTab != null)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((UltraTabControlBase) this.MgaTab1).SelectedTab.Key, "ALL", false) == 0)
        ((UltraTabControlBase) this.MgaTab1).Tabs["NONDIARY"].Selected = true;
    }
    else
      ((UltraTabControlBase) this.MgaTab1).Tabs["NONDIARY"].Selected = true;
    ((UltraTabControlBase) this.MgaTab1).Tabs["ALL"].Enabled = false;
  }

  private void EnableAllTabs()
  {
    foreach (UltraTab tab in ((UltraTabControlBase) this.MgaTab1).Tabs)
      tab.Enabled = true;
  }

  private Guid[] GetCurrentDiaryRecipients()
  {
    List<Guid> guidList = new List<Guid>();
    try
    {
      foreach (MGANoteRecipientListBox.MGANoteRecipientListItem recipientListItem in this.lbRecipients.Items)
      {
        if (recipientListItem.Diary != MGANoteRecipientListBox.DiaryStatus.None || recipientListItem.UserGUID.Equals(CurrentUser.Instance.UserGUID))
          guidList.Add(recipientListItem.UserGUID);
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    return guidList.ToArray();
  }

  private Guid[] GetCurrentRecipients()
  {
    List<Guid> guidList = new List<Guid>();
    try
    {
      foreach (MGANoteRecipientListBox.MGANoteRecipientListItem recipientListItem in this.lbRecipients.Items)
      {
        if (recipientListItem.Diary == MGANoteRecipientListBox.DiaryStatus.None && (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((UltraTabControlBase) this.MgaTab1).SelectedTab.Key, "DIARY", false) != 0 || !recipientListItem.UserGUID.Equals(CurrentUser.Instance.UserGUID)))
          guidList.Add(recipientListItem.UserGUID);
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    return guidList.ToArray();
  }

  private void AddCurrentUserToRecipientList()
  {
    this.lbRecipients.Clear();
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((UltraTabControlBase) this.MgaTab1).SelectedTab.Key, "DIARY", false) == 0)
      this.lbRecipients.AddUser(CurrentUser.Instance.UserGUID, $"{CurrentUser.Instance.LastName}, {CurrentUser.Instance.FirstName}", true, MGANoteRecipientListBox.DiaryStatus.NotComplete);
    else
      this.lbRecipients.AddUser(CurrentUser.Instance.UserGUID, $"{CurrentUser.Instance.LastName}, {CurrentUser.Instance.FirstName}", true, MGANoteRecipientListBox.DiaryStatus.None);
  }

  private void DoSave()
  {
    bool allValidatorsValid = this.RequiredFieldValidatorTypeValue.IsAllValidatorsValid;
    switch (this.CurrentNoteState)
    {
      case frmNote.NoteState.NewNoteWithNoEntriesNotEditing:
        this.CurrentNoteState = frmNote.NoteState.NewNoteWithNoEntriesEditingFirstEntry;
        break;
      case frmNote.NoteState.NewNoteWithNoEntriesEditingFirstEntry:
        if (!allValidatorsValid)
          break;
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((UltraTabControlBase) this.MgaTab1).SelectedTab.Key, "NONDIARY", false) == 0)
        {
          if (this._unbound)
          {
            this._noteGuid = Note_System.Instance.NonInteractive.CreateNote(Conversions.ToInteger(this.cboNoteType.Value), ((TextEditorControlBase) this.txtSubject).Text, CurrentUser.Instance.UserGUID, ((TextEditorControlBase) this.txtEntry).Text, ((UltraToggleEditorBase) this.chkInternal).Checked, this.GetCurrentRecipients(), ((UltraToggleEditorBase) this.chkPopup).Checked);
          }
          else
          {
            this._noteGuid = Note_System.Instance.NonInteractive.CreateBoundNote(Conversions.ToInteger(this.cboNoteType.Value), ((TextEditorControlBase) this.txtSubject).Text, CurrentUser.Instance.UserGUID, ((TextEditorControlBase) this.txtEntry).Text, ((UltraToggleEditorBase) this.chkInternal).Checked, this.GetCurrentRecipients(), (ISupportNoteSystem) this, ((UltraToggleEditorBase) this.chkPopup).Checked);
            if (this.ExternalDocumentToBindTo.HasValue)
            {
              ISupportDocumentPanel supportDocumentPanel = (ISupportDocumentPanel) this;
              DocumentManager.BeginBindDocument(this.ExternalDocumentToBindTo.Value, (ISupportDocumentSystem) new DocSupportCache(true, true, supportDocumentPanel.EntityGuid, supportDocumentPanel.EntityName, supportDocumentPanel.FriendlyEntityName, supportDocumentPanel.RecreateTypeName, false, Guid.Empty));
              if (this.SecondaryAssociation != null)
                Note_System.Instance.NonInteractive.BeginBindNote(this._noteGuid, this.SecondaryAssociation);
            }
          }
        }
        else
          this._noteGuid = !this._unbound ? Note_System.Instance.NonInteractive.CreateBoundNote(Conversions.ToInteger(this.cboNoteType.Value), ((TextEditorControlBase) this.txtSubject).Text, CurrentUser.Instance.UserGUID, ((TextEditorControlBase) this.txtEntry).Text, ((UltraToggleEditorBase) this.chkInternal).Checked, this.GetCurrentRecipients(), this.GetCurrentDiaryRecipients(), (ISupportNoteSystem) this, this.dtDue.DateTime, this.dtFinal.DateTime, ((UltraToggleEditorBase) this.chkPopup).Checked) : Note_System.Instance.NonInteractive.CreateNote(Conversions.ToInteger(this.cboNoteType.Value), ((TextEditorControlBase) this.txtSubject).Text, CurrentUser.Instance.UserGUID, ((TextEditorControlBase) this.txtEntry).Text, ((UltraToggleEditorBase) this.chkInternal).Checked, this.GetCurrentRecipients(), this.GetCurrentDiaryRecipients(), this.dtDue.DateTime, this.dtFinal.DateTime, ((UltraToggleEditorBase) this.chkPopup).Checked);
        if (!this._unbound)
        {
          EntityListItem[] editedEntityListItems = this.EntityNotePanel1.GetEditedEntityListItems();
          int index = 0;
          while (index < editedEntityListItems.Length)
          {
            EntityListItem entityListItem = editedEntityListItems[index];
            Note_System.Instance.NonInteractive.EditEntityDescription(this._noteGuid, entityListItem.EntityGUID, entityListItem.Text);
            checked { ++index; }
          }
          this.EntityNotePanel1.NoteGUID = this._noteGuid;
        }
        this.CurrentNoteState = frmNote.NoteState.NoteWithEntriesUnknown;
        this.RefreshEntryGrid();
        break;
      case frmNote.NoteState.NoteWithEntriesUnknown:
      case frmNote.NoteState.NoteWithEntriesNotEditing:
      case frmNote.NoteState.NoteWithNoActiveEntries:
        this.CurrentNoteState = frmNote.NoteState.NoteWithEntriesEditingNewEntry;
        break;
      case frmNote.NoteState.NoteWithEntriesEditingExistingEntry:
        if (!allValidatorsValid)
          break;
        object obj = ((UltraGridBase) this.grdEntries).ActiveRow.Cells["ID"].Value;
        Guid guid = obj != null ? (Guid) obj : new Guid();
        Note_System.Instance.NonInteractive.UpdateNoteEntry(guid, ((TextEditorControlBase) this.txtEntry).Text, ((UltraToggleEditorBase) this.chkPopup).Checked);
        if (this.IsStartedInEditMode)
        {
          Note_System.Instance.NonInteractive.ClearEntryDiaryRecipients(guid);
          Note_System.Instance.NonInteractive.ClearEntryRecipients(guid);
          Note_System.Instance.NonInteractive.AddEntryDiaryRecipients(guid, this.GetCurrentDiaryRecipients());
          Note_System.Instance.NonInteractive.AddEntryRecipients(guid, this.GetCurrentRecipients());
          Note_System.Instance.NonInteractive.ChangeNoteType(this._noteGuid, Conversions.ToInteger(this.cboNoteType.Value));
        }
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((UltraTabControlBase) this.MgaTab1).SelectedTab.Key, "DIARY", false) == 0)
          Note_System.Instance.NonInteractive.UpdateDiaryInfo(guid, this._noteGuid, this.dtDue.DateTime, this.dtFinal.DateTime);
        this.CurrentNoteState = frmNote.NoteState.NoteWithEntriesUnknown;
        this.RefreshEntryGrid();
        break;
      case frmNote.NoteState.NoteWithEntriesEditingNewEntry:
        if (!allValidatorsValid)
          break;
        Note_System.Instance.NonInteractive.MarkNoteRead(Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((UltraTabControlBase) this.MgaTab1).SelectedTab.Key, "DIARY", false) != 0 ? Note_System.Instance.NonInteractive.AppendNoteEntry(this._noteGuid, ((TextEditorControlBase) this.txtEntry).Text, ((UltraToggleEditorBase) this.chkInternal).Checked, CurrentUser.Instance.UserGUID, this.GetCurrentRecipients(), ((UltraToggleEditorBase) this.chkPopup).Checked) : Note_System.Instance.NonInteractive.AppendNoteEntry(this._noteGuid, ((TextEditorControlBase) this.txtEntry).Text, ((UltraToggleEditorBase) this.chkInternal).Checked, CurrentUser.Instance.UserGUID, this.GetCurrentRecipients(), this.GetCurrentDiaryRecipients(), this.dtDue.DateTime, this.dtFinal.DateTime, ((UltraToggleEditorBase) this.chkPopup).Checked), CurrentUser.Instance.UserGUID);
        this.RefreshEntryGrid();
        break;
    }
  }

  private void btnNewSave_Click(object sender, EventArgs e)
  {
    if (!frmNoteUserSelectEx.VerifyRelevantRecipients(Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((UltraTabControlBase) this.MgaTab1).SelectedTab.Key, "DIARY", false) == 0, this.lbRecipients))
      return;
    this.DoSave();
  }

  private void ClickEdit()
  {
    switch (this.CurrentNoteState)
    {
      case frmNote.NoteState.NewNoteWithNoEntriesEditingFirstEntry:
        this.CurrentNoteState = frmNote.NoteState.NewNoteWithNoEntriesNotEditing;
        break;
      case frmNote.NoteState.NoteWithEntriesNotEditing:
        this.CurrentNoteState = frmNote.NoteState.NoteWithEntriesEditingExistingEntry;
        break;
      case frmNote.NoteState.NoteWithEntriesEditingExistingEntry:
        this.CurrentNoteState = frmNote.NoteState.NoteWithEntriesUnknown;
        this.RefreshEntryGrid();
        break;
      case frmNote.NoteState.NoteWithEntriesEditingNewEntry:
        this.CurrentNoteState = frmNote.NoteState.NoteWithEntriesUnknown;
        this.RefreshEntryGrid();
        break;
    }
  }

  private void btnEditCancel_Click(object sender, EventArgs e) => this.ClickEdit();

  private static CheckState DetermineCompletionState() => CheckState.Checked;

  private void chkComplete_CheckedChanged(object sender, EventArgs e)
  {
    if (this._ignoreClickDiary || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((UltraTabControlBase) this.MgaTab1).SelectedTab.Key, "DIARY", false) != 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((UltraTabControlBase) this.MgaTab1).SelectedTab.Key, "ALL", false) != 0 || ((UltraGridBase) this.grdEntries).Rows.Count <= 0 || ((UltraGridBase) this.grdEntries).ActiveRow == null)
      return;
    object obj = ((UltraGridBase) this.grdEntries).ActiveRow.Cells["ID"].Value;
    Guid guid = obj != null ? (Guid) obj : new Guid();
    if (((UltraToggleEditorBase) this.chkComplete).CheckedValue.Equals((object) DBNull.Value))
      ((UltraToggleEditorBase) this.chkComplete).Checked = true;
    Note_System.Instance.UIInteractive.CompleteDiary(CurrentUser.Instance.UserGUID, guid, ((UltraToggleEditorBase) this.chkComplete).Checked);
    this.PopulateRecipients(guid);
  }

  private void chkRead_CheckedChanged(object sender, EventArgs e)
  {
    if (this._ignoreClickNote || ((UltraGridBase) this.grdEntries).Rows.Count <= 0 || ((UltraGridBase) this.grdEntries).ActiveRow == null)
      return;
    object obj = ((UltraGridBase) this.grdEntries).ActiveRow.Cells["ID"].Value;
    Guid entryGUID = obj != null ? (Guid) obj : new Guid();
    Note_System.Instance.NonInteractive.MarkNoteRead(entryGUID, CurrentUser.Instance.UserGUID, ((UltraToggleEditorBase) this.chkRead).Checked);
    this.PopulateRecipients(entryGUID);
  }

  private void chkInternal_CheckedChanged(object sender, EventArgs e)
  {
    if (this._ignoreClickInternal || ((UltraGridBase) this.grdEntries).Rows.Count <= 0 || ((UltraGridBase) this.grdEntries).ActiveRow == null)
      return;
    object obj = ((UltraGridBase) this.grdEntries).ActiveRow.Cells["ID"].Value;
    Note_System.Instance.NonInteractive.BeginMarkEntryAsInternal(((UltraToggleEditorBase) this.chkInternal).Checked, obj != null ? (Guid) obj : new Guid());
    this.RefreshEntryGrid();
  }

  private void lnkAddRecipient_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    if (((UltraTabControlBase) this.MgaTab1).SelectedTab == null)
      return;
    using (frmNoteUserSelectEx noteUserSelectEx = new frmNoteUserSelectEx(this.lbRecipients, Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((UltraTabControlBase) this.MgaTab1).SelectedTab.Key, "DIARY", false) == 0))
    {
      int num = (int) noteUserSelectEx.ShowDialog();
    }
  }

  private void chkDiaryCompleteAllTab_CheckedChanged(object sender, EventArgs e)
  {
    int num = this._ignoreClickDiary ? 1 : 0;
  }

  private void ResetNote()
  {
    this._noteGuid = Guid.NewGuid();
    ((TextEditorControlBase) this.txtEntry).Text = string.Empty;
    ((TextEditorControlBase) this.txtSubject).Text = string.Empty;
    ((UltraGridBase) this.grdEntries).DataSource = (object) null;
    ((UltraTabControlBase) this.MgaTab1).Tabs["NONDIARY"].Text = "Non-diary (0)";
    ((UltraTabControlBase) this.MgaTab1).Tabs["DIARY"].Text = "Diary (0)";
    ((UltraTabControlBase) this.MgaTab1).Tabs["ALL"].Text = "All (0)";
    this.CurrentNoteState = frmNote.NoteState.NewNoteWithNoEntriesEditingFirstEntry;
    this.StartDataFetch();
  }

  private void lnkNewNote_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    if (this.CurrentNoteState == frmNote.NoteState.NewNoteWithNoEntriesEditingFirstEntry || this.CurrentNoteState == frmNote.NoteState.NoteWithEntriesEditingExistingEntry || this.CurrentNoteState == frmNote.NoteState.NoteWithEntriesEditingNewEntry)
    {
      if (MessageBox.Show("You are currently editing an entry, would you like to save your changes?", "Not finished editing?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
      {
        if (!this.RequiredFieldValidatorTypeValue.IsAllValidatorsValid)
          return;
        this.DoSave();
      }
      this.ResetNote();
    }
    else
      this.ResetNote();
  }

  private void lnkViewEdits_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    if (this.IsEditing || ((UltraGridBase) this.grdEntries).Rows.Count <= 0 || ((UltraGridBase) this.grdEntries).ActiveRow == null)
      return;
    object obj = ((UltraGridBase) this.grdEntries).ActiveRow.Cells["ID"].Value;
    using (frmNoteEditLog frmNoteEditLog = new frmNoteEditLog(obj != null ? (Guid) obj : new Guid()))
    {
      int num = (int) frmNoteEditLog.ShowDialog();
    }
  }

  private bool IsEditing
  {
    get
    {
      return this.CurrentNoteState == frmNote.NoteState.NewNoteWithNoEntriesEditingFirstEntry || this.CurrentNoteState == frmNote.NoteState.NoteWithEntriesEditingExistingEntry || this.CurrentNoteState == frmNote.NoteState.NoteWithEntriesEditingNewEntry;
    }
  }

  private void DocumentPanel1_QueryEntity(object sender, QueryEntityEventArgs e)
  {
    e.EntityGUID = this._noteGuid;
  }

  public ISupportDocumentSystem DocumentSupportCache
  {
    get
    {
      return (ISupportDocumentSystem) new frmNote.InternalDocumentSupportCache(this._noteSupportCache);
    }
  }

  public bool AllowAddNewDocument => true;

  public event ISupportDocumentSystem.EntityInfoChangedEventHandler EntityInfoChanged1;

  Guid IRecreatableEntity.ControlGUID
  {
    get => this._noteSupportCache == null ? Guid.Empty : this._noteSupportCache.ControlGUID;
  }

  bool IRecreatableEntity.HasControlGUID
  {
    get => this._noteSupportCache != null && this._noteSupportCache.HasControlGUID;
  }

  public bool CanReCreateEntity1 => true;

  public Guid EntityGuid1 => this._noteGuid;

  public string EntityName1 => $"Note: {((TextEditorControlBase) this.txtSubject).Text}";

  public string FriendlyEntityName1 => "Note";

  public bool RecreateEntityInitialize1(Guid entityGuid)
  {
    return this.RecreateEntityInitialize(entityGuid);
  }

  public string RecreateTypeName1 => this.GetType().ToString();

  public ISupportNoteSystem NoteSupportCache => (ISupportNoteSystem) this._noteSupportCache;

  public void PrintErrorOccured(Exception ex, ref bool showDialog)
  {
  }

  [SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes")]
  public SectionReport PrintReport(string key)
  {
    // ISSUE: unable to decompile the method.
  }

  public DictionaryEntry[] ReportItems
  {
    get
    {
      return new DictionaryEntry[1]
      {
        new DictionaryEntry((object) "Print_StdNote", (object) "Print Note")
      };
    }
  }

  private void CustomValidatorRecipientList_CustomValidate(object sender, ValidateEventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((UltraTabControlBase) this.MgaTab1).SelectedTab.Key, "DIARY", false) == 0)
      return;
    e.IsValid = this.lbRecipients.Items.Count > 0;
  }

  private void chkPopup_CheckedChanged(object sender, EventArgs e)
  {
    if (this._ignoreClickPopup || ((UltraGridBase) this.grdEntries).Rows.Count <= 0 || ((UltraGridBase) this.grdEntries).ActiveRow == null)
      return;
    object obj = ((UltraGridBase) this.grdEntries).ActiveRow.Cells["ID"].Value;
    Note_System.Instance.NonInteractive.BeginMarkEntryToPopup(((UltraToggleEditorBase) this.chkPopup).Checked, obj != null ? (Guid) obj : new Guid());
  }

  private void txtSubject_AfterEnterEditMode(object sender, EventArgs e)
  {
    ((TextEditorControlBase) this.txtSubject).SelectAll();
  }

  private void txtEntry_AfterEnterEditMode(object sender, EventArgs e)
  {
    ((TextEditorControlBase) this.txtEntry).SelectAll();
  }

  private void cboNoteType_ValueChanged(object sender, EventArgs e)
  {
    if ((!this._formLoaded || this._noteState != frmNote.NoteState.NewNoteWithNoEntriesEditingFirstEntry) && this._noteState != frmNote.NoteState.NewNoteWithNoEntriesNotEditing && !this._startInEditMode || this.cboNoteType.Value == null)
      return;
    if (((EditorButtonControlBase) this.txtSubject).ReadOnly)
      ((EditorButtonControlBase) this.txtSubject).ReadOnly = false;
    DataRow dataRow = DefaultDatabase.ExecuteDataRow("NoteSystem_FetchNoteTypeInfo", new object[2]
    {
      (object) "@noteTypeID",
      this.cboNoteType.Value
    });
    if (dataRow == null)
      return;
    if (dataRow.IsNull("DefaultNoteSubject"))
      ((TextEditorControlBase) this.txtSubject).Text = string.Empty;
    else
      ((TextEditorControlBase) this.txtSubject).Text = (string) dataRow["DefaultNoteSubject"];
    if (!dataRow.IsNull("DefaultNoteIsPopup"))
      ((UltraToggleEditorBase) this.chkPopup).Checked = (bool) dataRow["DefaultNoteIsPopup"];
    if (dataRow.IsNull("DefaultNoteBody"))
      ((TextEditorControlBase) this.txtEntry).Text = string.Empty;
    else
      ((TextEditorControlBase) this.txtEntry).Text = (string) dataRow["DefaultNoteBody"];
    if (!dataRow.IsNull("DefaultNoteDiaryStartId") && !dataRow.IsNull("DefaultNoteDiaryRecipientId") && !dataRow.IsNull("DefaultNoteDueInDays"))
    {
      ((UltraTabControlBase) this.MgaTab1).SelectedTab = ((UltraTabControlBase) this.MgaTab1).Tabs["DIARY"];
      ((UltraTabControlBase) this.MgaTab1).ActiveTab = ((UltraTabControlBase) this.MgaTab1).Tabs["DIARY"];
      DateTime dateTime1 = this.CurrentDate;
      if (!this._unbound && this._noteSupportCache != null)
      {
        switch (Conversions.ToInteger(dataRow["DefaultNoteDiaryStartId"]))
        {
          case 0:
            dateTime1 = this.CurrentDate;
            break;
          case 1:
            if (this._noteSupportCache.HasControlGUID)
            {
              dateTime1 = Database.IsNull(RuntimeHelpers.GetObjectValue(Database.Instance.QueryText.PerformScalarQuery("select EffectiveDate from tblquotes where controlGuid = @controlGuid", (object) "@controlGuid", (object) this._noteSupportCache.ControlGUID)), this.CurrentDate);
              break;
            }
            break;
          case 2:
            if (this._noteSupportCache.HasControlGUID)
            {
              dateTime1 = Database.IsNull(RuntimeHelpers.GetObjectValue(Database.Instance.QueryText.PerformScalarQuery("select ExpirationDate from tblquotes where controlGuid = @controlGuid", (object) "@controlGuid", (object) this._noteSupportCache.ControlGUID)), this.CurrentDate);
              break;
            }
            break;
          default:
            throw new InvalidOperationException($"The value {Conversions.ToInteger(dataRow["DiaryStartDateID"])} is not a valid startDateID");
        }
        List<Guid> guidList = frmNote.OnResolveAutomationRecipients(Conversions.ToInteger(dataRow["DefaultNoteDiaryRecipientId"]), this._noteSupportCache.ControlGUID);
        this.lbRecipients.Clear();
        if (guidList.Count > 0)
        {
          try
          {
            foreach (Guid userGuid in guidList)
            {
              DataRow[] dataRowArray = this._tblUsers.Select($"UserGUID = '{MGASystems.IMS.NoteDocuments.Common.UserGUID.ToString()}'");
              string empty = string.Empty;
              string userName = dataRowArray == null || dataRowArray.Length <= 0 ? "Unknown user" : Conversions.ToString(dataRowArray[0]["FullName"]);
              this.lbRecipients.AddUser(userGuid, userName, false, MGANoteRecipientListBox.DiaryStatus.NotComplete);
            }
          }
          finally
          {
            List<Guid>.Enumerator enumerator;
            enumerator.Dispose();
          }
        }
      }
      DateTime dateTime2 = dateTime1.AddDays((double) Conversions.ToInteger(dataRow["DefaultNoteDueInDays"]));
      this.dtDue.DateTime = dateTime2;
      this.dtFinal.DateTime = dateTime2.AddDays(14.0);
    }
    else
    {
      if (dataRow.IsNull("DefaultNoteBody"))
        return;
      ((UltraTabControlBase) this.MgaTab1).SelectedTab = ((UltraTabControlBase) this.MgaTab1).Tabs["NONDIARY"];
      ((UltraTabControlBase) this.MgaTab1).ActiveTab = ((UltraTabControlBase) this.MgaTab1).Tabs["NONDIARY"];
    }
  }

  protected static List<Guid> OnResolveAutomationRecipients(int recipientId, Guid controlGuid)
  {
    List<Guid> guidList = new List<Guid>();
    switch (recipientId)
    {
      case 0:
        guidList.Add(Database.IsNull(RuntimeHelpers.GetObjectValue(Database.Instance.QueryText.PerformScalarQuery("SELECT TACSRUserGuid FROM dbo.tblQuotes (NOLOCK) WHERE (ControlGuid = @ControlGuid)", (object) "@ControlGuid", (object) controlGuid)), CurrentUser.Instance.UserGUID));
        break;
      case 1:
        guidList.Add(Database.Instance.QueryText.PerformScalarQueryGuid("SELECT UnderWriterUserGuid FROM dbo.tblQuotes (NOLOCK) WHERE (ControlGuid = @ControlGuid)", (object) "@ControlGuid", (object) controlGuid));
        break;
      case 2:
        guidList.Add(CurrentUser.Instance.UserGUID);
        break;
      case 5:
        guidList.Add(Database.IsNull(RuntimeHelpers.GetObjectValue(Database.Instance.QueryText.PerformScalarQuery("SELECT UnderWritingAssistantGuid FROM dbo.tblQuotes (NOLOCK) WHERE (ControlGuid = @ControlGuid)", (object) "@ControlGuid", (object) controlGuid)), CurrentUser.Instance.UserGUID));
        break;
    }
    return guidList;
  }

  public Guid? ExternalDocumentToBindTo
  {
    get
    {
      return !this._externalDocumentToBindTo.Equals(Guid.Empty) ? new Guid?(this._externalDocumentToBindTo) : new Guid?();
    }
    set => this._externalDocumentToBindTo = value.Value;
  }

  public ISupportNoteSystem SecondaryAssociation
  {
    get => this._secondaryAssociation;
    set => this._secondaryAssociation = value;
  }

  private DateTime CurrentDate => this._useServerDateTime ? CurrentUser.ServerTime : DateTime.Now;

  private delegate void SetupNoteStateHandler(frmNote.NoteState state);

  private enum NoteState
  {
    NewNoteWithNoEntriesNotEditing,
    NewNoteWithNoEntriesEditingFirstEntry,
    NoteWithEntriesUnknown,
    NoteWithEntriesNotEditing,
    NoteWithNoActiveEntries,
    NoteWithEntriesEditingExistingEntry,
    NoteWithEntriesEditingNewEntry,
  }

  private class InternalDocumentSupportCache : ISupportDocumentSystem
  {
    private MGASystems.IMS.NoteDocuments.NoteDiarySystem.NoteSupportCache _noteSupportCache;

    public InternalDocumentSupportCache(MGASystems.IMS.NoteDocuments.NoteDiarySystem.NoteSupportCache NoteSupportCache)
    {
      this._noteSupportCache = NoteSupportCache;
    }

    bool IRecreatableEntity.CanReCreateEntity => this._noteSupportCache.CanReCreateEntity;

    Guid IRecreatableEntity.EntityGuid => this._noteSupportCache.EntityGUID;

    string IRecreatableEntity.EntityName => this._noteSupportCache.EntityName;

    string IRecreatableEntity.FriendlyEntityName => this._noteSupportCache.FriendlyEntityName;

    bool IRecreatableEntity.RecreateEntityInitialize(Guid entityGuid)
    {
      bool flag;
      return flag;
    }

    string IRecreatableEntity.RecreateTypeName => this._noteSupportCache.RecreateTypeName;

    public bool AllowAddNewDocument => this._noteSupportCache.CanCreateNewNote;

    public event ISupportDocumentSystem.EntityInfoChangedEventHandler EntityInfoChanged;

    Guid IRecreatableEntity.ControlGUID => this._noteSupportCache.ControlGUID;

    bool IRecreatableEntity.HasControlGUID => this._noteSupportCache.HasControlGUID;
  }
}
