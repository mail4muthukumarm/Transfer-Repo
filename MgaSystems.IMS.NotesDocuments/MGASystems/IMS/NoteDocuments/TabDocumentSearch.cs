// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.NoteDocuments.TabDocumentSearch
// Assembly: MgaSystems.IMS.NotesDocuments, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 3F898CF7-066D-4B05-A9F1-D37DBC4FAA16
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.NotesDocuments.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinDock;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using MGASystems.Common;
using MGASystems.Common.DataAccess;
using MGASystems.Common.DockingManagement;
using MGASystems.Tools;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.NoteDocuments;

[SecureTabResource("{8204FCAB-14E0-4ae6-AC5E-961B0CD33CA5}", "Access Document Search Tab", "Ability of user to access the tab at all", "Document System")]
public sealed class TabDocumentSearch : DelayLoadUserControl, IDockingInfoProvider
{
  private IContainer components;
  private SqlDataAdapter daDocumentTypes;
  private SqlCommand SqlSelectCommand1;
  private SqlConnection cnSQL;
  private SqlDataAdapter daFileTypes;
  private SqlCommand SqlSelectCommand2;
  private dsDocumentSearch DsDocumentSearch;
  private Label Label6;
  private MGACheckBox chkDisplayProgress;
  private MGACheckBox chkDispResultsInNewWindow;
  private MGASimpleComboBox cboFileType;
  private Label Label10;
  private MGACheckBox chkCaseSensitive;
  private Panel Panel2;
  private MGANumericEditor MgaNumericEditor1;
  private MGASimpleComboBox cboFileSize;
  private Panel Panel1;
  private MGADateTimePicker dtModifiedTo;
  private MGADateTimePicker dtModifiedFrom;
  private MGASimpleComboBox cboModifiedDate;
  private Label Label8;
  private Label Label9;
  private Label Label7;
  private Label Label5;
  private MGASimpleComboBox cboDocType;
  private MGATextBox txtFileName;
  private Label Label4;
  private Label Label3;
  private Label Label2;
  private Label Label1;
  internal const string SecurityIDViewDocumentSearchTab = "{8204FCAB-14E0-4ae6-AC5E-961B0CD33CA5}";
  private string _cboDocTypeFieldMember;
  private string _cboFileTypeFieldMember;
  private string _cboDocTypeValueMember;
  private string _cboFileTypeValueMember;
  private string _cboOwnerValueMember;
  private string _cboOwnerFieldMember;
  private string _fileSize;
  private string _modifiedDate;

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private virtual MGATextBox txtDescription
  {
    get => this._txtDescription;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtDescription_KeyUp);
      MGATextBox txtDescription1 = this._txtDescription;
      if (txtDescription1 != null)
        ((Control) txtDescription1).KeyUp -= keyEventHandler;
      this._txtDescription = value;
      MGATextBox txtDescription2 = this._txtDescription;
      if (txtDescription2 == null)
        return;
      ((Control) txtDescription2).KeyUp += keyEventHandler;
    }
  }

  private virtual MGAButton btnReset
  {
    get => this._btnReset;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnReset_Click);
      MGAButton btnReset1 = this._btnReset;
      if (btnReset1 != null)
        ((Control) btnReset1).Click -= eventHandler;
      this._btnReset = value;
      MGAButton btnReset2 = this._btnReset;
      if (btnReset2 == null)
        return;
      ((Control) btnReset2).Click += eventHandler;
    }
  }

  private virtual RadioButton rbFileSizeSpecify
  {
    get => this._rbFileSizeSpecify;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.rbFileSizeSpecify_CheckedChanged);
      RadioButton rbFileSizeSpecify1 = this._rbFileSizeSpecify;
      if (rbFileSizeSpecify1 != null)
        rbFileSizeSpecify1.CheckedChanged -= eventHandler;
      this._rbFileSizeSpecify = value;
      RadioButton rbFileSizeSpecify2 = this._rbFileSizeSpecify;
      if (rbFileSizeSpecify2 == null)
        return;
      rbFileSizeSpecify2.CheckedChanged += eventHandler;
    }
  }

  private virtual RadioButton rbFileSizeLarge
  {
    get => this._rbFileSizeLarge;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.rbFileSizeLarge_CheckedChanged);
      RadioButton rbFileSizeLarge1 = this._rbFileSizeLarge;
      if (rbFileSizeLarge1 != null)
        rbFileSizeLarge1.CheckedChanged -= eventHandler;
      this._rbFileSizeLarge = value;
      RadioButton rbFileSizeLarge2 = this._rbFileSizeLarge;
      if (rbFileSizeLarge2 == null)
        return;
      rbFileSizeLarge2.CheckedChanged += eventHandler;
    }
  }

  private virtual RadioButton rbFileSizeMedium
  {
    get => this._rbFileSizeMedium;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.rbFileSizeMedium_CheckedChanged);
      RadioButton rbFileSizeMedium1 = this._rbFileSizeMedium;
      if (rbFileSizeMedium1 != null)
        rbFileSizeMedium1.CheckedChanged -= eventHandler;
      this._rbFileSizeMedium = value;
      RadioButton rbFileSizeMedium2 = this._rbFileSizeMedium;
      if (rbFileSizeMedium2 == null)
        return;
      rbFileSizeMedium2.CheckedChanged += eventHandler;
    }
  }

  private virtual RadioButton rbFileSizeSmall
  {
    get => this._rbFileSizeSmall;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.rbFileSizeSmall_CheckedChanged);
      RadioButton rbFileSizeSmall1 = this._rbFileSizeSmall;
      if (rbFileSizeSmall1 != null)
        rbFileSizeSmall1.CheckedChanged -= eventHandler;
      this._rbFileSizeSmall = value;
      RadioButton rbFileSizeSmall2 = this._rbFileSizeSmall;
      if (rbFileSizeSmall2 == null)
        return;
      rbFileSizeSmall2.CheckedChanged += eventHandler;
    }
  }

  private virtual RadioButton rbFileSizeDontRemember
  {
    get => this._rbFileSizeDontRemember;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.rbFileSizeDontRemember_CheckedChanged);
      RadioButton sizeDontRemember1 = this._rbFileSizeDontRemember;
      if (sizeDontRemember1 != null)
        sizeDontRemember1.CheckedChanged -= eventHandler;
      this._rbFileSizeDontRemember = value;
      RadioButton sizeDontRemember2 = this._rbFileSizeDontRemember;
      if (sizeDontRemember2 == null)
        return;
      sizeDontRemember2.CheckedChanged += eventHandler;
    }
  }

  private virtual RadioButton rbModifiedSpecify
  {
    get => this._rbModifiedSpecify;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.rbModifiedSpecify_CheckedChanged);
      RadioButton rbModifiedSpecify1 = this._rbModifiedSpecify;
      if (rbModifiedSpecify1 != null)
        rbModifiedSpecify1.CheckedChanged -= eventHandler;
      this._rbModifiedSpecify = value;
      RadioButton rbModifiedSpecify2 = this._rbModifiedSpecify;
      if (rbModifiedSpecify2 == null)
        return;
      rbModifiedSpecify2.CheckedChanged += eventHandler;
    }
  }

  private virtual RadioButton rbModifiedPastYear
  {
    get => this._rbModifiedPastYear;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.rbModifiedPastYear_CheckedChanged);
      RadioButton modifiedPastYear1 = this._rbModifiedPastYear;
      if (modifiedPastYear1 != null)
        modifiedPastYear1.CheckedChanged -= eventHandler;
      this._rbModifiedPastYear = value;
      RadioButton modifiedPastYear2 = this._rbModifiedPastYear;
      if (modifiedPastYear2 == null)
        return;
      modifiedPastYear2.CheckedChanged += eventHandler;
    }
  }

  private virtual RadioButton rbModifiedPastMonth
  {
    get => this._rbModifiedPastMonth;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.rbModifiedPastMonth_CheckedChanged);
      RadioButton modifiedPastMonth1 = this._rbModifiedPastMonth;
      if (modifiedPastMonth1 != null)
        modifiedPastMonth1.CheckedChanged -= eventHandler;
      this._rbModifiedPastMonth = value;
      RadioButton modifiedPastMonth2 = this._rbModifiedPastMonth;
      if (modifiedPastMonth2 == null)
        return;
      modifiedPastMonth2.CheckedChanged += eventHandler;
    }
  }

  private virtual RadioButton rbModifiedLastWeek
  {
    get => this._rbModifiedLastWeek;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.rbModifiedLastWeek_CheckedChanged);
      RadioButton modifiedLastWeek1 = this._rbModifiedLastWeek;
      if (modifiedLastWeek1 != null)
        modifiedLastWeek1.CheckedChanged -= eventHandler;
      this._rbModifiedLastWeek = value;
      RadioButton modifiedLastWeek2 = this._rbModifiedLastWeek;
      if (modifiedLastWeek2 == null)
        return;
      modifiedLastWeek2.CheckedChanged += eventHandler;
    }
  }

  private virtual RadioButton rbModifiedDontRemember
  {
    get => this._rbModifiedDontRemember;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.rbModifiedDontRemember_CheckedChanged);
      RadioButton modifiedDontRemember1 = this._rbModifiedDontRemember;
      if (modifiedDontRemember1 != null)
        modifiedDontRemember1.CheckedChanged -= eventHandler;
      this._rbModifiedDontRemember = value;
      RadioButton modifiedDontRemember2 = this._rbModifiedDontRemember;
      if (modifiedDontRemember2 == null)
        return;
      modifiedDontRemember2.CheckedChanged += eventHandler;
    }
  }

  private virtual MGAButton btnSearch
  {
    get => this._btnSearch;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnSearch_Click);
      MGAButton btnSearch1 = this._btnSearch;
      if (btnSearch1 != null)
        ((Control) btnSearch1).Click -= eventHandler;
      this._btnSearch = value;
      MGAButton btnSearch2 = this._btnSearch;
      if (btnSearch2 == null)
        return;
      ((Control) btnSearch2).Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("cboOwner")]
  internal virtual MGASimpleComboBox cboOwner { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label11")]
  internal virtual Label Label11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("daUsers")]
  internal virtual SqlDataAdapter daUsers { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlSelectCommand3")]
  internal virtual SqlCommand SqlSelectCommand3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ErrorProvider1")]
  internal virtual ErrorProvider ErrorProvider1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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
    Appearance appearance10 = new Appearance();
    Appearance appearance11 = new Appearance();
    Appearance appearance12 = new Appearance();
    this.DsDocumentSearch = new dsDocumentSearch();
    this.daDocumentTypes = new SqlDataAdapter();
    this.SqlSelectCommand1 = new SqlCommand();
    this.cnSQL = new SqlConnection();
    this.daFileTypes = new SqlDataAdapter();
    this.SqlSelectCommand2 = new SqlCommand();
    this.txtDescription = new MGATextBox();
    this.btnReset = new MGAButton();
    this.Label6 = new Label();
    this.chkDisplayProgress = new MGACheckBox();
    this.chkDispResultsInNewWindow = new MGACheckBox();
    this.cboFileType = new MGASimpleComboBox();
    this.Label10 = new Label();
    this.chkCaseSensitive = new MGACheckBox();
    this.Panel2 = new Panel();
    this.MgaNumericEditor1 = new MGANumericEditor();
    this.cboFileSize = new MGASimpleComboBox();
    this.rbFileSizeSpecify = new RadioButton();
    this.rbFileSizeLarge = new RadioButton();
    this.rbFileSizeMedium = new RadioButton();
    this.rbFileSizeSmall = new RadioButton();
    this.rbFileSizeDontRemember = new RadioButton();
    this.Panel1 = new Panel();
    this.dtModifiedTo = new MGADateTimePicker();
    this.dtModifiedFrom = new MGADateTimePicker();
    this.cboModifiedDate = new MGASimpleComboBox();
    this.rbModifiedSpecify = new RadioButton();
    this.rbModifiedPastYear = new RadioButton();
    this.rbModifiedPastMonth = new RadioButton();
    this.rbModifiedLastWeek = new RadioButton();
    this.rbModifiedDontRemember = new RadioButton();
    this.Label8 = new Label();
    this.Label9 = new Label();
    this.Label7 = new Label();
    this.Label5 = new Label();
    this.cboDocType = new MGASimpleComboBox();
    this.txtFileName = new MGATextBox();
    this.Label4 = new Label();
    this.Label3 = new Label();
    this.Label2 = new Label();
    this.Label1 = new Label();
    this.btnSearch = new MGAButton();
    this.cboOwner = new MGASimpleComboBox();
    this.Label11 = new Label();
    this.daUsers = new SqlDataAdapter();
    this.SqlSelectCommand3 = new SqlCommand();
    this.ErrorProvider1 = new ErrorProvider(this.components);
    this.DsDocumentSearch.BeginInit();
    ((ISupportInitialize) this.txtDescription).BeginInit();
    ((ISupportInitialize) this.btnReset).BeginInit();
    ((ISupportInitialize) this.chkDisplayProgress).BeginInit();
    ((ISupportInitialize) this.chkDispResultsInNewWindow).BeginInit();
    ((ISupportInitialize) this.cboFileType).BeginInit();
    ((ISupportInitialize) this.chkCaseSensitive).BeginInit();
    this.Panel2.SuspendLayout();
    ((ISupportInitialize) this.MgaNumericEditor1).BeginInit();
    ((ISupportInitialize) this.cboFileSize).BeginInit();
    this.Panel1.SuspendLayout();
    ((ISupportInitialize) this.dtModifiedTo).BeginInit();
    ((ISupportInitialize) this.dtModifiedFrom).BeginInit();
    ((ISupportInitialize) this.cboModifiedDate).BeginInit();
    ((ISupportInitialize) this.cboDocType).BeginInit();
    ((ISupportInitialize) this.txtFileName).BeginInit();
    ((ISupportInitialize) this.btnSearch).BeginInit();
    ((ISupportInitialize) this.cboOwner).BeginInit();
    ((ISupportInitialize) this.ErrorProvider1).BeginInit();
    this.SuspendLayout();
    this.DsDocumentSearch.DataSetName = "dsDocumentSearch";
    this.DsDocumentSearch.Locale = new CultureInfo("en-US");
    this.DsDocumentSearch.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.daDocumentTypes.SelectCommand = this.SqlSelectCommand1;
    this.daDocumentTypes.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblDocumentTypes", new DataColumnMapping[2]
      {
        new DataColumnMapping("TypeGuid", "TypeGuid"),
        new DataColumnMapping("TypeName", "TypeName")
      })
    });
    this.SqlSelectCommand1.CommandText = "SELECT TypeGuid, TypeName FROM tblDocumentTypes (NOLOCK)";
    this.SqlSelectCommand1.Connection = this.cnSQL;
    this.cnSQL.ConnectionString = "workstation id=DOMENIC;packet size=4096;user id=mgasystems;data source=\"169.207.38.53\";persist security info=False;initial catalog=Aegis";
    this.cnSQL.FireInfoMessageEventOnUserErrors = false;
    this.daFileTypes.SelectCommand = this.SqlSelectCommand2;
    this.daFileTypes.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblDocumentStore", new DataColumnMapping[1]
      {
        new DataColumnMapping("FileAssociation", "FileAssociation")
      })
    });
    this.SqlSelectCommand2.CommandText = "SELECT DISTINCT FileAssociation FROM tblDocumentStore (NOLOCK) ORDER BY FileAssociation";
    this.SqlSelectCommand2.Connection = this.cnSQL;
    ((Control) this.txtDescription).Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    appearance1.BackColor = Color.White;
    appearance1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance1.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtDescription).Appearance = (AppearanceBase) appearance1;
    ((TextEditorControlBase) this.txtDescription).BackColor = Color.White;
    ((Control) this.txtDescription).Location = new Point(16 /*0x10*/, 528);
    this.txtDescription.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtDescription).Name = "txtDescription";
    ((Control) this.txtDescription).Size = new Size(248, 20);
    ((Control) this.txtDescription).TabIndex = 36;
    ((UltraControlBase) this.txtDescription).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtDescription).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.btnReset).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance2.BackColor = Color.FromArgb(248, 248, 248);
    appearance2.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance2.BackGradientStyle = (GradientStyle) 2;
    appearance2.BorderColor = Color.DarkGray;
    appearance2.ImageHAlign = (HAlign) 2;
    appearance2.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnReset).Appearance = (AppearanceBase) appearance2;
    ((Control) this.btnReset).Location = new Point(96 /*0x60*/, 592);
    ((Control) this.btnReset).Name = "btnReset";
    ((Control) this.btnReset).Size = new Size(80 /*0x50*/, 24);
    ((Control) this.btnReset).TabIndex = 42;
    ((ControlBase) this.btnReset).Text = "Reset";
    this.btnReset.UseOSThemes = (DefaultableBoolean) 2;
    this.Label6.AutoSize = true;
    this.Label6.BackColor = Color.Transparent;
    this.Label6.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label6.Location = new Point(16 /*0x10*/, 512 /*0x0200*/);
    this.Label6.Name = "Label6";
    this.Label6.Size = new Size(60, 13);
    this.Label6.TabIndex = 41;
    this.Label6.Text = "Description";
    appearance3.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance3.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkDisplayProgress).Appearance = (AppearanceBase) appearance3;
    ((UltraToggleEditorBase) this.chkDisplayProgress).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkDisplayProgress).BackColorInternal = Color.Transparent;
    ((UltraToggleEditorBase) this.chkDisplayProgress).Checked = true;
    ((UltraToggleEditorBase) this.chkDisplayProgress).CheckState = CheckState.Checked;
    ((UltraToggleEditorBase) this.chkDisplayProgress).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkDisplayProgress).Location = new Point(120, 552);
    this.chkDisplayProgress.MGAStyle = MGAStyles.Blue;
    ((Control) this.chkDisplayProgress).Name = "chkDisplayProgress";
    ((Control) this.chkDisplayProgress).Size = new Size(112 /*0x70*/, 16 /*0x10*/);
    ((Control) this.chkDisplayProgress).TabIndex = 39;
    ((UltraToggleEditorBase) this.chkDisplayProgress).Text = "Display Progress";
    ((UltraControlBase) this.chkDisplayProgress).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkDisplayProgress).UseOsThemes = (DefaultableBoolean) 2;
    appearance4.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance4.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkDispResultsInNewWindow).Appearance = (AppearanceBase) appearance4;
    ((UltraToggleEditorBase) this.chkDispResultsInNewWindow).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkDispResultsInNewWindow).BackColorInternal = Color.Transparent;
    ((UltraToggleEditorBase) this.chkDispResultsInNewWindow).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkDispResultsInNewWindow).Location = new Point(16 /*0x10*/, 568);
    this.chkDispResultsInNewWindow.MGAStyle = MGAStyles.Blue;
    ((Control) this.chkDispResultsInNewWindow).Name = "chkDispResultsInNewWindow";
    ((Control) this.chkDispResultsInNewWindow).Size = new Size(208 /*0xD0*/, 24);
    ((Control) this.chkDispResultsInNewWindow).TabIndex = 38;
    ((UltraToggleEditorBase) this.chkDispResultsInNewWindow).Text = "Display results in new window.";
    ((UltraControlBase) this.chkDispResultsInNewWindow).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkDispResultsInNewWindow).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.cboFileType).Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    this.cboFileType.BorderStyle = (UIElementBorderStyle) 4;
    this.cboFileType.CharacterCasing = CharacterCasing.Normal;
    ((UltraGridBase) this.cboFileType).DataSource = (object) this.DsDocumentSearch.tblDocumentStore;
    ((UltraDropDownBase) this.cboFileType).DisplayMember = "FileAssociation";
    this.cboFileType.DisplayStyle = (EmbeddableElementDisplayStyle) 0;
    this.cboFileType.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboFileType).Location = new Point(16 /*0x10*/, 448);
    this.cboFileType.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboFileType).Name = "cboFileType";
    ((Control) this.cboFileType).Size = new Size(248, 21);
    ((Control) this.cboFileType).TabIndex = 35;
    ((UltraControlBase) this.cboFileType).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboFileType).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboFileType).ValueMember = "FileAssociation";
    this.Label10.AutoSize = true;
    this.Label10.BackColor = Color.Transparent;
    this.Label10.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label10.Location = new Point(16 /*0x10*/, 432);
    this.Label10.Name = "Label10";
    this.Label10.Size = new Size(65, 13);
    this.Label10.TabIndex = 34;
    this.Label10.Text = "Type of file:";
    appearance5.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance5.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkCaseSensitive).Appearance = (AppearanceBase) appearance5;
    ((UltraToggleEditorBase) this.chkCaseSensitive).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkCaseSensitive).BackColorInternal = Color.Transparent;
    ((UltraToggleEditorBase) this.chkCaseSensitive).Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((UltraToggleEditorBase) this.chkCaseSensitive).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkCaseSensitive).Location = new Point(16 /*0x10*/, 552);
    this.chkCaseSensitive.MGAStyle = MGAStyles.Blue;
    ((Control) this.chkCaseSensitive).Name = "chkCaseSensitive";
    ((Control) this.chkCaseSensitive).Size = new Size(96 /*0x60*/, 16 /*0x10*/);
    ((Control) this.chkCaseSensitive).TabIndex = 37;
    ((UltraToggleEditorBase) this.chkCaseSensitive).Text = "Case Sensitive";
    ((UltraControlBase) this.chkCaseSensitive).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkCaseSensitive).UseOsThemes = (DefaultableBoolean) 2;
    this.Panel2.BackColor = Color.Transparent;
    this.Panel2.Controls.Add((Control) this.MgaNumericEditor1);
    this.Panel2.Controls.Add((Control) this.cboFileSize);
    this.Panel2.Controls.Add((Control) this.rbFileSizeSpecify);
    this.Panel2.Controls.Add((Control) this.rbFileSizeLarge);
    this.Panel2.Controls.Add((Control) this.rbFileSizeMedium);
    this.Panel2.Controls.Add((Control) this.rbFileSizeSmall);
    this.Panel2.Controls.Add((Control) this.rbFileSizeDontRemember);
    this.Panel2.Location = new Point(16 /*0x10*/, 304);
    this.Panel2.Name = "Panel2";
    this.Panel2.Size = new Size(248, 112 /*0x70*/);
    this.Panel2.TabIndex = 33;
    appearance6.BackColorDisabled = Color.Gainsboro;
    appearance6.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.MgaNumericEditor1).Appearance = (AppearanceBase) appearance6;
    ((Control) this.MgaNumericEditor1).Enabled = false;
    ((Control) this.MgaNumericEditor1).Location = new Point(104, 88);
    this.MgaNumericEditor1.MaxValue = (object) 2097151 /*0x1FFFFF*/;
    this.MgaNumericEditor1.MGAStyle = MGAStyles.Blue;
    ((Control) this.MgaNumericEditor1).Name = "MgaNumericEditor1";
    this.MgaNumericEditor1.Nullable = true;
    ((Control) this.MgaNumericEditor1).Size = new Size(100, 20);
    ((Control) this.MgaNumericEditor1).TabIndex = 16 /*0x10*/;
    ((UltraControlBase) this.MgaNumericEditor1).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaNumericEditor1).UseOsThemes = (DefaultableBoolean) 2;
    this.cboFileSize.BorderStyle = (UIElementBorderStyle) 4;
    this.cboFileSize.CharacterCasing = CharacterCasing.Normal;
    this.cboFileSize.DisplayStyle = (EmbeddableElementDisplayStyle) 0;
    this.cboFileSize.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboFileSize).Enabled = false;
    ((Control) this.cboFileSize).Location = new Point(24, 88);
    this.cboFileSize.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboFileSize).Name = "cboFileSize";
    ((Control) this.cboFileSize).Size = new Size(72, 21);
    ((Control) this.cboFileSize).TabIndex = 15;
    ((UltraControlBase) this.cboFileSize).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboFileSize).UseOsThemes = (DefaultableBoolean) 2;
    this.rbFileSizeSpecify.Location = new Point(8, 68);
    this.rbFileSizeSpecify.Name = "rbFileSizeSpecify";
    this.rbFileSizeSpecify.Size = new Size(184, 24);
    this.rbFileSizeSpecify.TabIndex = 14;
    this.rbFileSizeSpecify.Text = "Specify size (in KB)";
    this.rbFileSizeLarge.Location = new Point(8, 51);
    this.rbFileSizeLarge.Name = "rbFileSizeLarge";
    this.rbFileSizeLarge.Size = new Size(184, 24);
    this.rbFileSizeLarge.TabIndex = 13;
    this.rbFileSizeLarge.Text = "Large (more than 1 MB)";
    this.rbFileSizeMedium.Location = new Point(8, 34);
    this.rbFileSizeMedium.Name = "rbFileSizeMedium";
    this.rbFileSizeMedium.Size = new Size(184, 24);
    this.rbFileSizeMedium.TabIndex = 12;
    this.rbFileSizeMedium.Text = "Medium (less than 1 MB)";
    this.rbFileSizeSmall.Location = new Point(8, 17);
    this.rbFileSizeSmall.Name = "rbFileSizeSmall";
    this.rbFileSizeSmall.Size = new Size(184, 24);
    this.rbFileSizeSmall.TabIndex = 11;
    this.rbFileSizeSmall.Text = "Small (less than 100 KB)";
    this.rbFileSizeDontRemember.Checked = true;
    this.rbFileSizeDontRemember.Location = new Point(8, 0);
    this.rbFileSizeDontRemember.Name = "rbFileSizeDontRemember";
    this.rbFileSizeDontRemember.Size = new Size(184, 24);
    this.rbFileSizeDontRemember.TabIndex = 10;
    this.rbFileSizeDontRemember.TabStop = true;
    this.rbFileSizeDontRemember.Text = "Don't Remember";
    this.Panel1.BackColor = Color.Transparent;
    this.Panel1.Controls.Add((Control) this.dtModifiedTo);
    this.Panel1.Controls.Add((Control) this.dtModifiedFrom);
    this.Panel1.Controls.Add((Control) this.cboModifiedDate);
    this.Panel1.Controls.Add((Control) this.rbModifiedSpecify);
    this.Panel1.Controls.Add((Control) this.rbModifiedPastYear);
    this.Panel1.Controls.Add((Control) this.rbModifiedPastMonth);
    this.Panel1.Controls.Add((Control) this.rbModifiedLastWeek);
    this.Panel1.Controls.Add((Control) this.rbModifiedDontRemember);
    this.Panel1.Controls.Add((Control) this.Label8);
    this.Panel1.Controls.Add((Control) this.Label9);
    this.Panel1.Location = new Point(16 /*0x10*/, 128 /*0x80*/);
    this.Panel1.Name = "Panel1";
    this.Panel1.Size = new Size(248, 160 /*0xA0*/);
    this.Panel1.TabIndex = 32 /*0x20*/;
    appearance7.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.dtModifiedTo.Appearance = (AppearanceBase) appearance7;
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
    this.dtModifiedTo.ButtonAppearance = (AppearanceBase) appearance8;
    ((Control) this.dtModifiedTo).Enabled = false;
    ((Control) this.dtModifiedTo).Location = new Point(56, 136);
    this.dtModifiedTo.MGAStyle = MGAStyles.Blue;
    ((Control) this.dtModifiedTo).Name = "dtModifiedTo";
    ((Control) this.dtModifiedTo).Size = new Size(104, 20);
    ((Control) this.dtModifiedTo).TabIndex = 9;
    ((UltraControlBase) this.dtModifiedTo).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dtModifiedTo).UseOsThemes = (DefaultableBoolean) 2;
    appearance9.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.dtModifiedFrom.Appearance = (AppearanceBase) appearance9;
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
    this.dtModifiedFrom.ButtonAppearance = (AppearanceBase) appearance10;
    ((Control) this.dtModifiedFrom).Enabled = false;
    ((Control) this.dtModifiedFrom).Location = new Point(56, 112 /*0x70*/);
    this.dtModifiedFrom.MGAStyle = MGAStyles.Blue;
    ((Control) this.dtModifiedFrom).Name = "dtModifiedFrom";
    ((Control) this.dtModifiedFrom).Size = new Size(104, 20);
    ((Control) this.dtModifiedFrom).TabIndex = 8;
    ((UltraControlBase) this.dtModifiedFrom).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dtModifiedFrom).UseOsThemes = (DefaultableBoolean) 2;
    this.cboModifiedDate.BorderStyle = (UIElementBorderStyle) 4;
    this.cboModifiedDate.CharacterCasing = CharacterCasing.Normal;
    this.cboModifiedDate.DisplayStyle = (EmbeddableElementDisplayStyle) 0;
    this.cboModifiedDate.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboModifiedDate).Enabled = false;
    ((Control) this.cboModifiedDate).Location = new Point(24, 88);
    this.cboModifiedDate.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboModifiedDate).Name = "cboModifiedDate";
    ((Control) this.cboModifiedDate).Size = new Size(112 /*0x70*/, 21);
    ((Control) this.cboModifiedDate).TabIndex = 7;
    ((UltraControlBase) this.cboModifiedDate).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboModifiedDate).UseOsThemes = (DefaultableBoolean) 2;
    this.rbModifiedSpecify.Location = new Point(8, 68);
    this.rbModifiedSpecify.Name = "rbModifiedSpecify";
    this.rbModifiedSpecify.Size = new Size(184, 24);
    this.rbModifiedSpecify.TabIndex = 6;
    this.rbModifiedSpecify.Text = "Specify dates";
    this.rbModifiedPastYear.Location = new Point(8, 51);
    this.rbModifiedPastYear.Name = "rbModifiedPastYear";
    this.rbModifiedPastYear.Size = new Size(184, 24);
    this.rbModifiedPastYear.TabIndex = 5;
    this.rbModifiedPastYear.Text = "Within the past year";
    this.rbModifiedPastMonth.Location = new Point(8, 34);
    this.rbModifiedPastMonth.Name = "rbModifiedPastMonth";
    this.rbModifiedPastMonth.Size = new Size(184, 24);
    this.rbModifiedPastMonth.TabIndex = 4;
    this.rbModifiedPastMonth.Text = "Past month";
    this.rbModifiedLastWeek.Location = new Point(8, 17);
    this.rbModifiedLastWeek.Name = "rbModifiedLastWeek";
    this.rbModifiedLastWeek.Size = new Size(184, 24);
    this.rbModifiedLastWeek.TabIndex = 3;
    this.rbModifiedLastWeek.Text = "Within the last week";
    this.rbModifiedDontRemember.Checked = true;
    this.rbModifiedDontRemember.Location = new Point(8, 0);
    this.rbModifiedDontRemember.Name = "rbModifiedDontRemember";
    this.rbModifiedDontRemember.Size = new Size(184, 24);
    this.rbModifiedDontRemember.TabIndex = 2;
    this.rbModifiedDontRemember.TabStop = true;
    this.rbModifiedDontRemember.Text = "Don't Remember";
    this.Label8.AutoSize = true;
    this.Label8.BackColor = Color.Transparent;
    this.Label8.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label8.Location = new Point(24, 112 /*0x70*/);
    this.Label8.Name = "Label8";
    this.Label8.Size = new Size(29, 13);
    this.Label8.TabIndex = 14;
    this.Label8.Text = "from";
    this.Label9.AutoSize = true;
    this.Label9.BackColor = Color.Transparent;
    this.Label9.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label9.Location = new Point(32 /*0x20*/, 136);
    this.Label9.Name = "Label9";
    this.Label9.Size = new Size(17, 13);
    this.Label9.TabIndex = 15;
    this.Label9.Text = "to";
    this.Label7.BackColor = Color.Transparent;
    this.Label7.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label7.Location = new Point(16 /*0x10*/, 72);
    this.Label7.Name = "Label7";
    this.Label7.Size = new Size(44, 16 /*0x10*/);
    this.Label7.TabIndex = 31 /*0x1F*/;
    this.Label7.Text = "Look in:";
    this.Label5.BackColor = Color.Transparent;
    this.Label5.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label5.Location = new Point(16 /*0x10*/, 32 /*0x20*/);
    this.Label5.Name = "Label5";
    this.Label5.Size = new Size(140, 16 /*0x10*/);
    this.Label5.TabIndex = 30;
    this.Label5.Text = "All or part of the file name:";
    ((Control) this.cboDocType).Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    this.cboDocType.BorderStyle = (UIElementBorderStyle) 4;
    this.cboDocType.CharacterCasing = CharacterCasing.Normal;
    ((UltraGridBase) this.cboDocType).DataSource = (object) this.DsDocumentSearch.tblDocumentTypes;
    ((UltraDropDownBase) this.cboDocType).DisplayMember = "TypeName";
    this.cboDocType.DisplayStyle = (EmbeddableElementDisplayStyle) 0;
    this.cboDocType.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboDocType).Location = new Point(16 /*0x10*/, 88);
    this.cboDocType.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboDocType).Name = "cboDocType";
    ((Control) this.cboDocType).Size = new Size(248, 21);
    ((Control) this.cboDocType).TabIndex = 26;
    ((UltraControlBase) this.cboDocType).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboDocType).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboDocType).ValueMember = "TypeGuid";
    ((Control) this.txtFileName).Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    appearance11.BackColor = Color.White;
    appearance11.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance11.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtFileName).Appearance = (AppearanceBase) appearance11;
    ((TextEditorControlBase) this.txtFileName).BackColor = Color.White;
    ((Control) this.txtFileName).Location = new Point(16 /*0x10*/, 48 /*0x30*/);
    this.txtFileName.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtFileName).Name = "txtFileName";
    ((Control) this.txtFileName).Size = new Size(248, 20);
    ((Control) this.txtFileName).TabIndex = 24;
    ((UltraControlBase) this.txtFileName).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtFileName).UseOsThemes = (DefaultableBoolean) 2;
    this.Label4.AutoSize = true;
    this.Label4.BackColor = Color.Transparent;
    this.Label4.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label4.Location = new Point(16 /*0x10*/, 416);
    this.Label4.Name = "Label4";
    this.Label4.Size = new Size(142, 13);
    this.Label4.TabIndex = 29;
    this.Label4.Text = "More advanced options.";
    this.Label3.AutoSize = true;
    this.Label3.BackColor = Color.Transparent;
    this.Label3.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label3.Location = new Point(16 /*0x10*/, 288);
    this.Label3.Name = "Label3";
    this.Label3.Size = new Size(91, 13);
    this.Label3.TabIndex = 28;
    this.Label3.Text = "What size is it?";
    this.Label2.AutoSize = true;
    this.Label2.BackColor = Color.Transparent;
    this.Label2.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label2.Location = new Point(16 /*0x10*/, 112 /*0x70*/);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(133, 13);
    this.Label2.TabIndex = 27;
    this.Label2.Text = "When was it modified?";
    this.Label1.AutoSize = true;
    this.Label1.BackColor = Color.Transparent;
    this.Label1.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label1.Location = new Point(16 /*0x10*/, 16 /*0x10*/);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(237, 13);
    this.Label1.TabIndex = 25;
    this.Label1.Text = "Search by any or all of the criteria below.";
    ((Control) this.btnSearch).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance12.BackColor = Color.FromArgb(248, 248, 248);
    appearance12.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance12.BackGradientStyle = (GradientStyle) 2;
    appearance12.BorderColor = Color.DarkGray;
    appearance12.ImageHAlign = (HAlign) 2;
    appearance12.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnSearch).Appearance = (AppearanceBase) appearance12;
    ((Control) this.btnSearch).Location = new Point(184, 592);
    ((Control) this.btnSearch).Name = "btnSearch";
    ((Control) this.btnSearch).Size = new Size(80 /*0x50*/, 24);
    ((Control) this.btnSearch).TabIndex = 40;
    ((ControlBase) this.btnSearch).Text = "Search";
    this.btnSearch.UseOSThemes = (DefaultableBoolean) 2;
    ((Control) this.cboOwner).Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    this.cboOwner.BorderStyle = (UIElementBorderStyle) 4;
    this.cboOwner.CharacterCasing = CharacterCasing.Normal;
    ((UltraGridBase) this.cboOwner).DataSource = (object) this.DsDocumentSearch.tblUsers;
    ((UltraDropDownBase) this.cboOwner).DisplayMember = "FullName";
    this.cboOwner.DisplayStyle = (EmbeddableElementDisplayStyle) 0;
    this.cboOwner.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboOwner).Location = new Point(16 /*0x10*/, 488);
    this.cboOwner.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboOwner).Name = "cboOwner";
    ((Control) this.cboOwner).Size = new Size(248, 21);
    ((Control) this.cboOwner).TabIndex = 44;
    ((UltraControlBase) this.cboOwner).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboOwner).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboOwner).ValueMember = "UserGUID";
    this.Label11.AutoSize = true;
    this.Label11.BackColor = Color.Transparent;
    this.Label11.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label11.Location = new Point(16 /*0x10*/, 472);
    this.Label11.Name = "Label11";
    this.Label11.Size = new Size(43, 13);
    this.Label11.TabIndex = 43;
    this.Label11.Text = "Owner:";
    this.daUsers.SelectCommand = this.SqlSelectCommand3;
    this.daUsers.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblUsers", new DataColumnMapping[2]
      {
        new DataColumnMapping("UserGUID", "UserGUID"),
        new DataColumnMapping("FullName", "FullName")
      })
    });
    this.SqlSelectCommand3.CommandText = "SELECT UserGUID, LastName + ', ' + FirstName AS FullName FROM tblUsers (NOLOCK) ORDER BY FullName";
    this.SqlSelectCommand3.Connection = this.cnSQL;
    this.ErrorProvider1.ContainerControl = (ContainerControl) this;
    this.BackColor = Color.FromArgb(193, 215, 249);
    this.Controls.Add((Control) this.cboOwner);
    this.Controls.Add((Control) this.Label11);
    this.Controls.Add((Control) this.txtDescription);
    this.Controls.Add((Control) this.btnReset);
    this.Controls.Add((Control) this.Label6);
    this.Controls.Add((Control) this.chkDisplayProgress);
    this.Controls.Add((Control) this.chkDispResultsInNewWindow);
    this.Controls.Add((Control) this.cboFileType);
    this.Controls.Add((Control) this.Label10);
    this.Controls.Add((Control) this.chkCaseSensitive);
    this.Controls.Add((Control) this.Panel2);
    this.Controls.Add((Control) this.Panel1);
    this.Controls.Add((Control) this.Label7);
    this.Controls.Add((Control) this.Label5);
    this.Controls.Add((Control) this.cboDocType);
    this.Controls.Add((Control) this.txtFileName);
    this.Controls.Add((Control) this.Label4);
    this.Controls.Add((Control) this.Label3);
    this.Controls.Add((Control) this.Label2);
    this.Controls.Add((Control) this.Label1);
    this.Controls.Add((Control) this.btnSearch);
    this.DoubleBuffered = true;
    this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.ForeColor = Color.Black;
    this.Name = nameof (TabDocumentSearch);
    this.Size = new Size(280, 624);
    this.DsDocumentSearch.EndInit();
    ((ISupportInitialize) this.txtDescription).EndInit();
    ((ISupportInitialize) this.btnReset).EndInit();
    ((ISupportInitialize) this.chkDisplayProgress).EndInit();
    ((ISupportInitialize) this.chkDispResultsInNewWindow).EndInit();
    ((ISupportInitialize) this.cboFileType).EndInit();
    ((ISupportInitialize) this.chkCaseSensitive).EndInit();
    this.Panel2.ResumeLayout(false);
    this.Panel2.PerformLayout();
    ((ISupportInitialize) this.MgaNumericEditor1).EndInit();
    ((ISupportInitialize) this.cboFileSize).EndInit();
    this.Panel1.ResumeLayout(false);
    this.Panel1.PerformLayout();
    ((ISupportInitialize) this.dtModifiedTo).EndInit();
    ((ISupportInitialize) this.dtModifiedFrom).EndInit();
    ((ISupportInitialize) this.cboModifiedDate).EndInit();
    ((ISupportInitialize) this.cboDocType).EndInit();
    ((ISupportInitialize) this.txtFileName).EndInit();
    ((ISupportInitialize) this.btnSearch).EndInit();
    ((ISupportInitialize) this.cboOwner).EndInit();
    ((ISupportInitialize) this.ErrorProvider1).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  public TabDocumentSearch()
  {
    this.DelayLoad += new EventHandler(this.TabDocumentSearch_DelayLoad);
    this._fileSize = string.Empty;
    this._modifiedDate = string.Empty;
    this.InitializeComponent();
    this.cnSQL.ConnectionString = CurrentUser.Instance.ConnectionString;
  }

  private void TabDocumentSearch_DelayLoad(object sender, EventArgs e)
  {
    MGASimpleComboBox cboDocType = this.cboDocType;
    this._cboDocTypeFieldMember = ((UltraDropDownBase) cboDocType).DisplayMember;
    this._cboDocTypeValueMember = ((UltraDropDownBase) cboDocType).ValueMember;
    ((UltraGridBase) cboDocType).DataSource = (object) null;
    MGASimpleComboBox cboFileType = this.cboFileType;
    this._cboFileTypeFieldMember = ((UltraDropDownBase) cboFileType).DisplayMember;
    this._cboFileTypeValueMember = ((UltraDropDownBase) cboFileType).ValueMember;
    ((UltraGridBase) cboFileType).DataSource = (object) null;
    MGASimpleComboBox cboOwner = this.cboOwner;
    this._cboOwnerFieldMember = ((UltraDropDownBase) cboOwner).DisplayMember;
    this._cboOwnerValueMember = ((UltraDropDownBase) cboOwner).ValueMember;
    ((UltraGridBase) cboOwner).DataSource = (object) null;
    Database.Instance.QueryMultithreadedDataAdapter.PerformTableQuery((Control) this, "Document Types", this.daDocumentTypes, new TableQueryMultithreadEventHandler(this.TableFilled), (DataTable) this.DsDocumentSearch.tblDocumentTypes);
    Database.Instance.QueryMultithreadedDataAdapter.PerformTableQuery((Control) this, "FileTypes", this.daFileTypes, new TableQueryMultithreadEventHandler(this.TableFilled), (DataTable) this.DsDocumentSearch.tblDocumentStore);
    Database.Instance.QueryMultithreadedDataAdapter.PerformTableQuery((Control) this, "Users", this.daUsers, new TableQueryMultithreadEventHandler(this.TableFilled), (DataTable) this.DsDocumentSearch.tblUsers);
  }

  private void TableFilled(object sender, TableQueryMultithreadEventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Conversions.ToString(e.Key), "FileTypes", false) == 0)
    {
      this.DsDocumentSearch.tblDocumentStore.AddtblDocumentStoreRow("");
      MGASimpleComboBox cboFileType = this.cboFileType;
      ((UltraGridBase) cboFileType).DataSource = (object) e.Table;
      ((UltraDropDownBase) cboFileType).DisplayMember = this._cboFileTypeFieldMember;
      ((UltraDropDownBase) cboFileType).ValueMember = this._cboFileTypeValueMember;
    }
    else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Conversions.ToString(e.Key), "Document Types", false) == 0)
    {
      this.DsDocumentSearch.tblDocumentTypes.AddtblDocumentTypesRow(Guid.Empty, "");
      MGASimpleComboBox cboDocType = this.cboDocType;
      ((UltraGridBase) cboDocType).DataSource = (object) e.Table;
      ((UltraDropDownBase) cboDocType).DisplayMember = this._cboDocTypeFieldMember;
      ((UltraDropDownBase) cboDocType).ValueMember = this._cboDocTypeValueMember;
    }
    else
    {
      this.DsDocumentSearch.tblUsers.AddtblUsersRow(Guid.Empty, "");
      MGASimpleComboBox cboOwner = this.cboOwner;
      ((UltraGridBase) cboOwner).DataSource = (object) e.Table;
      ((UltraDropDownBase) cboOwner).DisplayMember = this._cboOwnerFieldMember;
      ((UltraDropDownBase) cboOwner).ValueMember = this._cboOwnerValueMember;
    }
    this.cboDocType.Text = "";
    this.cboFileType.Text = "";
  }

  public void InitializeOnSplashLoad()
  {
  }

  void IMdiActivationListener.MDIChildActivating(Form mdiChild)
  {
  }

  void IMdiActivationListener.MDIChildDeActivate(Form mdiChild)
  {
  }

  public void AfterLogon()
  {
  }

  public DockWindowCreationInfo CreationInfo
  {
    get
    {
      return new DockWindowCreationInfo(false, "TabDocumentSearchPanel", "Document Search", (DockedLocation) 1, "LeftGroupKey", ImageCache.Instance.Search, true);
    }
  }

  private void btnSearch_Click(object sender, EventArgs e)
  {
    if (!(this.validDate() & this.validFileSize()))
      return;
    this.DoSearch();
  }

  private bool validDate()
  {
    bool flag;
    if (this.rbModifiedSpecify.Checked & DateTime.Compare(this.dtModifiedFrom.DateTime, this.dtModifiedTo.DateTime) > 0)
    {
      this.ErrorProvider1.SetError((Control) this.dtModifiedTo, "Please enter a valid date range");
      flag = false;
    }
    else
    {
      this.ErrorProvider1.SetError((Control) this.dtModifiedTo, string.Empty);
      flag = true;
    }
    return flag;
  }

  private bool validFileSize()
  {
    bool flag;
    if (this.rbFileSizeSpecify.Checked & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((UltraWinEditorMaskedControlBase) this.MgaNumericEditor1).Text, string.Empty, false) == 0)
    {
      this.ErrorProvider1.SetError((Control) this.MgaNumericEditor1, "Please specify a size");
      flag = false;
    }
    else
    {
      this.ErrorProvider1.SetError((Control) this.MgaNumericEditor1, string.Empty);
      flag = true;
    }
    return flag;
  }

  private void DoSearch()
  {
    (!((UltraToggleEditorBase) this.chkDispResultsInNewWindow).Checked ? (frmDocumentSearchResults) MDIControls.Instance.ActivateForm(typeof (frmDocumentSearchResults), true) : (frmDocumentSearchResults) FormSettings.ShowForm(typeof (frmDocumentSearchResults))).DoSearch(this.SQLSearchCriteria, ((UltraToggleEditorBase) this.chkDisplayProgress).Checked);
  }

  [SuppressMessage("Microsoft.Naming", "CA1705:LongAcronymsShouldBePascalCased", MessageId = "Member")]
  public string SQLSearchCriteria
  {
    get
    {
      return TabDocumentSearch.AddCriteria(TabDocumentSearch.AddCriteria(TabDocumentSearch.AddCriteria(TabDocumentSearch.AddCriteria(TabDocumentSearch.AddCriteria(TabDocumentSearch.AddCriteria(TabDocumentSearch.AddCriteria(string.Empty, this.SQLFileName), this.SQLDocumentType), this.SQLModifiedDate), this.SQLFileSize), this.SQLAdvancedOptions), this.SQLDescription), this.SQLFileOwner);
    }
  }

  private static string AddCriteria(string existingCriteria, string newCriteria)
  {
    string str;
    if (existingCriteria == null || newCriteria == null)
      str = string.Empty;
    else if (string.IsNullOrEmpty(newCriteria))
    {
      str = existingCriteria;
    }
    else
    {
      existingCriteria = !string.IsNullOrEmpty(existingCriteria) ? existingCriteria + " AND " : existingCriteria + " WHERE ";
      str = existingCriteria + newCriteria;
    }
    return str;
  }

  private string SQLFileName
  {
    get
    {
      return Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((TextEditorControlBase) this.txtFileName).Text, string.Empty, false) == 0 ? string.Empty : $"FileName LIKE '%{((TextEditorControlBase) this.txtFileName).Text.Replace("'", "''")}%' ";
    }
  }

  private string SQLDescription
  {
    get
    {
      return Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((TextEditorControlBase) this.txtDescription).Text, string.Empty, false) == 0 ? string.Empty : $"Description LIKE '%{((TextEditorControlBase) this.txtDescription).Text.Replace("'", "''")}%' ";
    }
  }

  private string SQLDocumentType
  {
    get
    {
      return string.IsNullOrEmpty(this.cboDocType.Text) ? string.Empty : $" TypeGuid = '{(Guid) this.cboDocType.Value}' ";
    }
  }

  private string SQLFileOwner
  {
    get
    {
      return string.IsNullOrEmpty(this.cboOwner.Text) ? string.Empty : $" UserGUIDOriginator = '{(Guid) this.cboOwner.Value}' ";
    }
  }

  private string SQLFileSize
  {
    get
    {
      if (this.rbFileSizeSpecify.Checked)
        this._fileSize = $" OriginalFileSize {RuntimeHelpers.GetObjectValue(Interaction.IIf(Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cboModifiedDate.Text, "at least", false) == 0, (object) ">=", (object) "<="))} {Conversions.ToInteger(this.MgaNumericEditor1.Value) * 1024 /*0x0400*/} ";
      return this._fileSize;
    }
  }

  private void rbFileSizeLarge_CheckedChanged(object sender, EventArgs e)
  {
    this._fileSize = " OriginalFileSize >= 1048576 ";
  }

  private void rbFileSizeMedium_CheckedChanged(object sender, EventArgs e)
  {
    this._fileSize = " OriginalFileSize < 1048576 ";
  }

  private void rbFileSizeSmall_CheckedChanged(object sender, EventArgs e)
  {
    this._fileSize = " OriginalFileSize < 102400 ";
  }

  private void rbFileSizeDontRemember_CheckedChanged(object sender, EventArgs e)
  {
    this._fileSize = string.Empty;
  }

  private string SQLAdvancedOptions
  {
    get
    {
      return this.cboFileType.Text.Length == 0 ? string.Empty : $" FileAssociation = '{this.cboFileType.Text}'";
    }
  }

  private string SQLModifiedDate
  {
    get
    {
      if (this.rbModifiedSpecify.Checked)
      {
        DateTime dateTime1 = this.dtModifiedFrom.DateTime;
        DateTime dateTime2 = this.dtModifiedTo.DateTime;
        this._modifiedDate = dateTime2.Day != dateTime1.Day || dateTime2.Month != dateTime1.Month || dateTime2.Year != dateTime1.Year ? (DateTime.Compare(dateTime2, dateTime1) < 0 ? $" DateAdded  <= CONVERT(char, '{dateTime1.ToShortDateString()}', 112) AND DateAdded  >= CONVERT(char, DATEADD(dd, 1, '{dateTime2.ToShortDateString()}'), 112) " : $" DateAdded  <= CONVERT(char, '{dateTime2.ToShortDateString()}', 112) AND DateAdded  >= CONVERT(char, DATEADD(dd, 1, '{dateTime1.ToShortDateString()}'), 112) ") : string.Format(" DateAdded  >= CONVERT(char, '{0}', 112) AND DateAdded  < CONVERT(char, DATEADD(dd, 1, '{0}'), 112) ", (object) dateTime1.ToShortDateString());
      }
      return this._modifiedDate;
    }
  }

  private void rbModifiedDontRemember_CheckedChanged(object sender, EventArgs e)
  {
    this._modifiedDate = string.Empty;
  }

  private void rbModifiedLastWeek_CheckedChanged(object sender, EventArgs e)
  {
    DateTime dateTime = DateAndTime.DateAdd(DateInterval.Day, 1.0, DateAndTime.Now);
    this._modifiedDate = $" DateAdded >= '{DateAndTime.DateAdd(DateInterval.Day, -7.0, DateAndTime.Now).ToShortDateString()}' AND DateAdded < '{dateTime.ToShortDateString()}' ";
  }

  private void rbModifiedPastMonth_CheckedChanged(object sender, EventArgs e)
  {
    DateTime dateTime = DateAndTime.DateAdd(DateInterval.Day, 1.0, DateAndTime.Now);
    this._modifiedDate = $" DateAdded >= '{DateAndTime.DateAdd(DateInterval.Month, -1.0, DateAndTime.Now).ToShortDateString()}' AND DateAdded < '{dateTime.ToShortDateString()}' ";
  }

  private void rbModifiedPastYear_CheckedChanged(object sender, EventArgs e)
  {
    DateTime dateTime = DateAndTime.DateAdd(DateInterval.Day, 1.0, DateAndTime.Now);
    this._modifiedDate = $" DateAdded >= '{DateAndTime.DateAdd(DateInterval.Year, -1.0, DateAndTime.Now).ToShortDateString()}' AND DateAdded < '{dateTime.ToShortDateString()}' ";
  }

  private void rbFileSizeSpecify_CheckedChanged(object sender, EventArgs e)
  {
    ((Control) this.cboFileSize).Enabled = this.rbFileSizeSpecify.Checked;
    ((Control) this.MgaNumericEditor1).Enabled = this.rbFileSizeSpecify.Checked;
  }

  private void rbModifiedSpecify_CheckedChanged(object sender, EventArgs e)
  {
    ((Control) this.dtModifiedFrom).Enabled = this.rbModifiedSpecify.Checked;
    ((Control) this.cboModifiedDate).Enabled = this.rbModifiedSpecify.Checked;
    ((Control) this.dtModifiedTo).Enabled = this.rbModifiedSpecify.Checked;
  }

  private void btnReset_Click(object sender, EventArgs e)
  {
    ((UltraToggleEditorBase) this.chkCaseSensitive).Checked = false;
    ((UltraToggleEditorBase) this.chkDisplayProgress).Checked = true;
    ((UltraToggleEditorBase) this.chkDispResultsInNewWindow).Checked = false;
    ((TextEditorControlBase) this.txtDescription).Text = string.Empty;
    this.cboDocType.Text = string.Empty;
    this.rbModifiedDontRemember.Checked = true;
    this.rbFileSizeDontRemember.Checked = true;
    ((UltraWinEditorMaskedControlBase) this.MgaNumericEditor1).Text = "0";
    this.cboFileType.Text = string.Empty;
    this.cboOwner.Text = string.Empty;
    ((TextEditorControlBase) this.txtFileName).Text = string.Empty;
    this.ErrorProvider1.SetError((Control) this.MgaNumericEditor1, string.Empty);
    this.ErrorProvider1.SetError((Control) this.dtModifiedTo, string.Empty);
    this.dtModifiedTo.DateTime = DateTime.Now;
    this.dtModifiedFrom.DateTime = DateTime.Now;
  }

  private void txtDescription_KeyUp(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.DoSearch();
  }

  public void BeforeLogOut()
  {
  }

  public int PreferredPosition => 5;
}
