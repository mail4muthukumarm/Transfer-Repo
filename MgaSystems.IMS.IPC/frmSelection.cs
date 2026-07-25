// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.frmSelection
// Assembly: MgaSystems.IMS.IPC, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: F22CEF02-8C0F-420D-8344-A8A010CA7834
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.IPC.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using MGASystems.BusinessObjects;
using MGASystems.Common;
using MGASystems.Common.ErrorHandling;
using MGASystems.Common.NativeWindowMethods;
using MGASystems.Data;
using MGASystems.IMS.InsuredsProducersCompanies.Companies;
using MGASystems.IMS.InsuredsProducersCompanies.Insureds;
using MGASystems.IMS.InsuredsProducersCompanies.Producers;
using MGASystems.IMS.Security;
using MGASystems.Tools;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.InsuredsProducersCompanies;

[SecureResource("{0686459C-80DE-4404-A113-387DEAF7EDAF}", "View Companies", "Controls the ability to access 'View Companies' menu.", "Companies")]
[SecureResource("{D5F7957A-AAA8-49fa-9FC8-8B33032D6DA8}", "View Insureds", "Controls the ability to access 'View Insureds' menu.", "Insureds")]
[SecureResource("{F84D8084-A0FB-4d3c-9F9F-545CB3CC5374}", "View Producers", "Controls the ability to access 'View Producers' menu.", "Producers")]
public class frmSelection : Form
{
  private readonly frmSelection.SelectionTypes _selectionType;
  private DataTable _dtSource;
  private bool _saved;
  private bool _launchForm;
  private bool _viewAllProducers;
  private string _storedProcName;
  private IContainer components;
  protected ToolTip Tips;
  protected Label lblSelect;
  private Label Label1;
  private Label lblLimitedResults;
  private DbCommand spEntitySearch;
  private bool _SetPrimarryOfficeTypeToBold;
  public const string CanViewCompanies = "{0686459C-80DE-4404-A113-387DEAF7EDAF}";
  public const string CanViewInsureds = "{D5F7957A-AAA8-49fa-9FC8-8B33032D6DA8}";
  public const string CanViewProducers = "{F84D8084-A0FB-4d3c-9F9F-545CB3CC5374}";

  protected virtual MGACheckBox chkHideClosedInactive
  {
    get => this._chkHideClosedInactive;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ChkHideClosedInactive_CheckedChanged);
      MGACheckBox hideClosedInactive1 = this._chkHideClosedInactive;
      if (hideClosedInactive1 != null)
        ((UltraToggleEditorBase) hideClosedInactive1).CheckedChanged -= eventHandler;
      this._chkHideClosedInactive = value;
      MGACheckBox hideClosedInactive2 = this._chkHideClosedInactive;
      if (hideClosedInactive2 == null)
        return;
      ((UltraToggleEditorBase) hideClosedInactive2).CheckedChanged += eventHandler;
    }
  }

  [field: AccessedThroughProperty("cnSQL")]
  protected virtual DbConnection cnSQL { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected DataTable DtSource
  {
    get => this._dtSource;
    set => this._dtSource = value;
  }

  protected string SearchText => ((TextEditorControlBase) this.txtSearch).Text;

  protected string SearchCode => ((TextEditorControlBase) this.txtCode).Text;

  protected void ResultsUpdate()
  {
    this.lstResults.BeginUpdate();
    MGAListBox lstResults = this.lstResults;
    lstResults.DisplayMember = "DisplayItem";
    lstResults.ValueMember = "ValueItem";
    lstResults.DataSource = (object) this._dtSource;
    this.lstResults.EndUpdate();
  }

  public frmSelection()
  {
    this.Load += new EventHandler(this.frmSelection_Load);
    this._dtSource = new DataTable();
    this._launchForm = true;
    this._SetPrimarryOfficeTypeToBold = false;
    this.InitializeComponent();
  }

  public frmSelection(frmSelection.SelectionTypes formType)
    : this(formType, false)
  {
  }

  public frmSelection(frmSelection.SelectionTypes formType, bool selectionOnly)
    : this()
  {
    this._selectionType = formType;
    if (!selectionOnly)
      return;
    ((Control) this.btnNew).Enabled = false;
    this.Launch = false;
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  protected virtual MGAButton btnGo
  {
    get => this._btnGo;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnGo_Click);
      MGAButton btnGo1 = this._btnGo;
      if (btnGo1 != null)
        ((Control) btnGo1).Click -= eventHandler;
      this._btnGo = value;
      MGAButton btnGo2 = this._btnGo;
      if (btnGo2 == null)
        return;
      ((Control) btnGo2).Click += eventHandler;
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

  protected virtual MGAButton btnSearch
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

  private virtual MGATextBox txtSearch
  {
    get => this._txtSearch;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtSearch_KeyDown);
      MGATextBox txtSearch1 = this._txtSearch;
      if (txtSearch1 != null)
        ((Control) txtSearch1).KeyDown -= keyEventHandler;
      this._txtSearch = value;
      MGATextBox txtSearch2 = this._txtSearch;
      if (txtSearch2 == null)
        return;
      ((Control) txtSearch2).KeyDown += keyEventHandler;
    }
  }

  private virtual MGAListBox lstResults
  {
    get => this._lstResults;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler1 = new EventHandler(this.lstResults_SelectedIndexChanged);
      EventHandler eventHandler2 = new EventHandler(this.lstResults_DoubleClick);
      MGAListBox lstResults1 = this._lstResults;
      if (lstResults1 != null)
      {
        lstResults1.SelectedIndexChanged -= eventHandler1;
        lstResults1.DoubleClick -= eventHandler2;
      }
      this._lstResults = value;
      MGAListBox lstResults2 = this._lstResults;
      if (lstResults2 == null)
        return;
      lstResults2.SelectedIndexChanged += eventHandler1;
      lstResults2.DoubleClick += eventHandler2;
    }
  }

  internal virtual LinkLabel lnkAdvanceProducerSearch
  {
    get => this._lnkAdvanceProducerSearch;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkAdvanceProducerSearch_LinkClicked);
      LinkLabel advanceProducerSearch1 = this._lnkAdvanceProducerSearch;
      if (advanceProducerSearch1 != null)
        advanceProducerSearch1.LinkClicked -= clickedEventHandler;
      this._lnkAdvanceProducerSearch = value;
      LinkLabel advanceProducerSearch2 = this._lnkAdvanceProducerSearch;
      if (advanceProducerSearch2 == null)
        return;
      advanceProducerSearch2.LinkClicked += clickedEventHandler;
    }
  }

  [field: AccessedThroughProperty("txtCode")]
  internal virtual MGATextBox txtCode { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label2")]
  internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmSelection));
    this.lblSelect = new Label();
    this.btnGo = new MGAButton();
    this.Tips = new ToolTip(this.components);
    this.btnNew = new MGAButton();
    this.btnSearch = new MGAButton();
    this.Label1 = new Label();
    this.txtSearch = new MGATextBox();
    this.lstResults = new MGAListBox();
    this.lblLimitedResults = new Label();
    this.spEntitySearch = DefaultDatabase.CreateCommand();
    this.lnkAdvanceProducerSearch = new LinkLabel();
    this.txtCode = new MGATextBox();
    this.Label2 = new Label();
    this.chkHideClosedInactive = new MGACheckBox();
    this.cnSQL = DefaultDatabase.CreateDbConnection();
    ((ISupportInitialize) this.btnGo).BeginInit();
    ((ISupportInitialize) this.btnNew).BeginInit();
    ((ISupportInitialize) this.btnSearch).BeginInit();
    ((ISupportInitialize) this.txtSearch).BeginInit();
    ((ISupportInitialize) this.lstResults).BeginInit();
    ((ISupportInitialize) this.txtCode).BeginInit();
    ((ISupportInitialize) this.chkHideClosedInactive).BeginInit();
    this.SuspendLayout();
    this.lblSelect.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    this.lblSelect.Location = new Point(8, 7);
    this.lblSelect.Name = "lblSelect";
    this.lblSelect.Size = new Size(455, 20);
    this.lblSelect.TabIndex = 0;
    ((Control) this.btnGo).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance1.BackColor = Color.FromArgb(248, 248, 248);
    appearance1.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance1.BackGradientStyle = (GradientStyle) 2;
    appearance1.BorderColor = Color.DarkGray;
    appearance1.ImageHAlign = (HAlign) 2;
    appearance1.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnGo).Appearance = (AppearanceBase) appearance1;
    ((Control) this.btnGo).Enabled = false;
    ((Control) this.btnGo).Font = new Font("Tahoma", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((ControlBase) this.btnGo).ImageSize = new Size(24, 24);
    ((ControlBase) this.btnGo).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnGo).Location = new Point(463, 504);
    ((Control) this.btnGo).Name = "btnGo";
    ((Control) this.btnGo).Size = new Size(40, 40);
    ((Control) this.btnGo).TabIndex = 5;
    this.Tips.SetToolTip((Control) this.btnGo, "Continue");
    this.btnGo.UseOSThemes = (DefaultableBoolean) 2;
    ((Control) this.btnNew).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance2.BackColor = Color.FromArgb(248, 248, 248);
    appearance2.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance2.BackGradientStyle = (GradientStyle) 2;
    appearance2.BorderColor = Color.DarkGray;
    appearance2.ImageHAlign = (HAlign) 2;
    appearance2.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnNew).Appearance = (AppearanceBase) appearance2;
    ((Control) this.btnNew).Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((ControlBase) this.btnNew).ImageSize = new Size(24, 24);
    ((ControlBase) this.btnNew).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnNew).Location = new Point(414, 504);
    ((Control) this.btnNew).Name = "btnNew";
    ((Control) this.btnNew).Size = new Size(40, 40);
    ((Control) this.btnNew).TabIndex = 4;
    this.btnNew.UseOSThemes = (DefaultableBoolean) 2;
    ((Control) this.btnSearch).Anchor = AnchorStyles.Top | AnchorStyles.Right;
    appearance3.BackColor = Color.FromArgb(248, 248, 248);
    appearance3.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance3.BackGradientStyle = (GradientStyle) 2;
    appearance3.BorderColor = Color.DarkGray;
    appearance3.ImageHAlign = (HAlign) 2;
    appearance3.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnSearch).Appearance = (AppearanceBase) appearance3;
    ((Control) this.btnSearch).Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((ControlBase) this.btnSearch).ImageSize = new Size(24, 24);
    ((ControlBase) this.btnSearch).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnSearch).Location = new Point(470, 14);
    ((Control) this.btnSearch).Name = "btnSearch";
    ((Control) this.btnSearch).Size = new Size(40, 40);
    ((Control) this.btnSearch).TabIndex = 2;
    this.btnSearch.UseOSThemes = (DefaultableBoolean) 2;
    this.Label1.Location = new Point(7, 38);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(42, 14);
    this.Label1.TabIndex = 19;
    this.Label1.Text = "Name:";
    this.Label1.TextAlign = ContentAlignment.MiddleRight;
    ((Control) this.txtSearch).Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    appearance4.BackColor = Color.White;
    appearance4.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance4.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtSearch).Appearance = (AppearanceBase) appearance4;
    ((TextEditorControlBase) this.txtSearch).BackColor = Color.White;
    ((Control) this.txtSearch).Location = new Point(56, 35);
    ((TextEditorControlBase) this.txtSearch).MaxLength = 100;
    this.txtSearch.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtSearch).Name = "txtSearch";
    ((Control) this.txtSearch).Size = new Size(400, 20);
    ((Control) this.txtSearch).TabIndex = 1;
    ((UltraControlBase) this.txtSearch).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtSearch).UseOsThemes = (DefaultableBoolean) 2;
    this.lstResults.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.lstResults.BackColor = Color.White;
    this.lstResults.DrawMode = DrawMode.OwnerDrawFixed;
    this.lstResults.ForeColor = Color.Black;
    this.lstResults.Location = new Point(7, 91);
    this.lstResults.MGAStyle = MGAStyles.Blue;
    this.lstResults.Name = "lstResults";
    this.lstResults.Size = new Size(503, 392);
    this.lstResults.TabIndex = 21;
    this.lblLimitedResults.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.lblLimitedResults.AutoSize = true;
    this.lblLimitedResults.ForeColor = Color.Red;
    this.lblLimitedResults.Location = new Point(140, 518);
    this.lblLimitedResults.Name = "lblLimitedResults";
    this.lblLimitedResults.Size = new Size(134, 13);
    this.lblLimitedResults.TabIndex = 22;
    this.lblLimitedResults.Text = "Limiting to top 100 results.";
    this.lblLimitedResults.Visible = false;
    this.spEntitySearch.CommandText = "dbo.[spEntitySearch]";
    this.spEntitySearch.CommandType = CommandType.StoredProcedure;
    this.spEntitySearch.Connection = this.cnSQL;
    this.spEntitySearch.Parameters.AddRange((Array) new DbParameter[5]
    {
      DefaultDatabase.CreateParameter("@selectionType", SqlDbType.Int, 4),
      DefaultDatabase.CreateParameter("@searchText", SqlDbType.VarChar, 100),
      DefaultDatabase.CreateParameter("@code", SqlDbType.VarChar, 20),
      DefaultDatabase.CreateParameter("@CurrentUserGuid", SqlDbType.UniqueIdentifier),
      DefaultDatabase.CreateParameter("@ViewAllProducers", SqlDbType.Bit)
    });
    this.lnkAdvanceProducerSearch.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkAdvanceProducerSearch.AutoSize = true;
    this.lnkAdvanceProducerSearch.Location = new Point(21, 518);
    this.lnkAdvanceProducerSearch.Name = "lnkAdvanceProducerSearch";
    this.lnkAdvanceProducerSearch.Size = new Size(91, 13);
    this.lnkAdvanceProducerSearch.TabIndex = 23;
    this.lnkAdvanceProducerSearch.TabStop = true;
    this.lnkAdvanceProducerSearch.Text = "Advanced Search";
    this.lnkAdvanceProducerSearch.Visible = false;
    ((Control) this.txtCode).Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    appearance5.BackColor = Color.White;
    appearance5.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance5.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtCode).Appearance = (AppearanceBase) appearance5;
    ((TextEditorControlBase) this.txtCode).BackColor = Color.White;
    ((Control) this.txtCode).Location = new Point(56, 63 /*0x3F*/);
    ((TextEditorControlBase) this.txtCode).MaxLength = 20;
    this.txtCode.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtCode).Name = "txtCode";
    ((Control) this.txtCode).Size = new Size(97, 20);
    ((Control) this.txtCode).TabIndex = 3;
    ((UltraControlBase) this.txtCode).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtCode).UseOsThemes = (DefaultableBoolean) 2;
    this.Label2.Location = new Point(7, 66);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(42, 14);
    this.Label2.TabIndex = 25;
    this.Label2.Text = "Code:";
    this.Label2.TextAlign = ContentAlignment.MiddleRight;
    ((Control) this.chkHideClosedInactive).Anchor = AnchorStyles.Top | AnchorStyles.Right;
    appearance6.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance6.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkHideClosedInactive).Appearance = (AppearanceBase) appearance6;
    ((UltraToggleEditorBase) this.chkHideClosedInactive).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkHideClosedInactive).BackColorInternal = Color.Transparent;
    ((UltraToggleEditorBase) this.chkHideClosedInactive).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkHideClosedInactive).Location = new Point(159, 63 /*0x3F*/);
    this.chkHideClosedInactive.MGAStyle = MGAStyles.Blue;
    ((Control) this.chkHideClosedInactive).Name = "chkHideClosedInactive";
    ((Control) this.chkHideClosedInactive).Size = new Size(136, 20);
    ((Control) this.chkHideClosedInactive).TabIndex = 26;
    ((UltraToggleEditorBase) this.chkHideClosedInactive).Text = "Hide Closed\\Inactive";
    ((UltraControlBase) this.chkHideClosedInactive).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkHideClosedInactive).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.chkHideClosedInactive).Visible = false;
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.White;
    this.ClientSize = new Size(518, 561);
    this.Controls.Add((Control) this.chkHideClosedInactive);
    this.Controls.Add((Control) this.Label2);
    this.Controls.Add((Control) this.txtCode);
    this.Controls.Add((Control) this.lnkAdvanceProducerSearch);
    this.Controls.Add((Control) this.lblLimitedResults);
    this.Controls.Add((Control) this.lstResults);
    this.Controls.Add((Control) this.txtSearch);
    this.Controls.Add((Control) this.Label1);
    this.Controls.Add((Control) this.btnSearch);
    this.Controls.Add((Control) this.btnNew);
    this.Controls.Add((Control) this.btnGo);
    this.Controls.Add((Control) this.lblSelect);
    this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.ForeColor = Color.Black;
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.MaximizeBox = false;
    this.MinimumSize = new Size(441, 400);
    this.Name = nameof (frmSelection);
    ((ISupportInitialize) this.btnGo).EndInit();
    ((ISupportInitialize) this.btnNew).EndInit();
    ((ISupportInitialize) this.btnSearch).EndInit();
    ((ISupportInitialize) this.txtSearch).EndInit();
    ((ISupportInitialize) this.lstResults).EndInit();
    ((ISupportInitialize) this.txtCode).EndInit();
    ((ISupportInitialize) this.chkHideClosedInactive).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  public bool Launch
  {
    get => this._launchForm;
    set => this._launchForm = value;
  }

  public frmSelection.SelectionTypes SelectionType => this._selectionType;

  public Guid SelectedGuid
  {
    get
    {
      return this.lstResults.SelectedItem == null ? Guid.Empty : new Guid(((DataRowView) this.lstResults.SelectedItem).Row[0].ToString());
    }
  }

  public string SelectedText
  {
    get
    {
      return this.lstResults.SelectedItem == null ? string.Empty : (string) ((DataRowView) this.lstResults.SelectedItem).Row[1];
    }
  }

  public bool ItemSelected => this._saved && this.lstResults.SelectedIndex >= 0;

  protected void frmSelection_Load(object sender, EventArgs e)
  {
    if (this.DesignMode)
      return;
    this.lstResults.DrawItem += new DrawItemEventHandler(this.DrawItemListener);
    this.lstResults.SelectedIndexChanged += new EventHandler(this.SelectedIndexListener);
    ImageCache instance = ImageCache.Instance;
    ((ControlBase) this.btnNew).Appearance.Image = (object) instance.NewImage;
    ((ControlBase) this.btnGo).Appearance.Image = (object) instance.Forward;
    ((ControlBase) this.btnSearch).Appearance.Image = (object) instance.Search;
    this._dtSource.Columns.Add("ValueItem", typeof (Guid));
    this._dtSource.Columns.Add("DisplayItem", typeof (string));
    this._dtSource.Columns.Add("StatusID", typeof (short));
    this._dtSource.Columns.Add("LocationTypeID", typeof (short));
    this.Text = this._selectionType.ToString() + " Selection";
    this.lblSelect.Text = $"Please select a {this.SelectionType.ToString().ToLower()}:";
    switch (this.SelectionType)
    {
      case frmSelection.SelectionTypes.Producer:
        ((Control) this.btnNew).Visible = SecurityManager.Instance.AssertPermission("{5B098E3D-BAE4-42a2-BD20-EB5166A9D43A}");
        ((Control) this.chkHideClosedInactive).Visible = true;
        ((UltraToggleEditorBase) this.chkHideClosedInactive).Checked = MGASystems.Common.Settings.SystemSettings.GetSetting<bool>("Producers.Selection.DefaultHideClosedInactive");
        break;
      case frmSelection.SelectionTypes.Company:
        ((Control) this.btnNew).Visible = SecurityManager.Instance.AssertPermission("{C266F1AF-4856-4647-BC41-CE2D40D5E294}");
        break;
      case frmSelection.SelectionTypes.Retailer:
        ((Control) this.btnNew).Visible = SecurityManager.Instance.AssertPermission("{4C8083A6-CA95-4e6a-9581-0D1529E6590E}");
        break;
      case frmSelection.SelectionTypes.Insured:
        ((Control) this.btnNew).Visible = SecurityManager.Instance.AssertPermission("{ADAE0A61-DE61-4aaf-8BCA-39F8158C9248}");
        break;
    }
    this._viewAllProducers = SecurityManager.Instance.AssertPermission("{2D117606-DE51-4902-B36F-C415C27F52E0}");
    this.lnkAdvanceProducerSearch.Visible = this._selectionType == frmSelection.SelectionTypes.Producer || this._selectionType == frmSelection.SelectionTypes.Company;
    this._storedProcName = MGASystems.Common.Settings.SystemSettings.GetSetting<string>("EntitySearchStoredProcedure", "spEntitySearch");
    this._SetPrimarryOfficeTypeToBold = MGASystems.Common.Settings.SystemSettings.GetSetting<bool>("Producers.Selection.SetPrimaryOficeTypeToBold");
  }

  public void ModifyItem(Guid guidToModify, string newDisplayText)
  {
    DataRow[] dataRowArray = this._dtSource.Select($"ValueItem='{guidToModify.ToString()}'");
    if (dataRowArray.Length <= 0)
      return;
    dataRowArray[0]["DisplayItem"] = (object) newDisplayText;
  }

  public void AddItem(string displayText, Guid valueGuid)
  {
    DataRow row = this._dtSource.NewRow();
    row["ValueItem"] = (object) valueGuid;
    row["DisplayItem"] = (object) displayText;
    this._dtSource.Rows.Add(row);
  }

  public void RemoveItem(Guid valueGuid)
  {
    int num = this.lstResults.Items.Count - 1;
    for (int index = 0; index <= num; ++index)
    {
      if (((Guid) ((DataRowView) this.lstResults.Items[index]).Row["ValueItem"]).Equals(valueGuid))
      {
        this._dtSource.Rows.Remove(this._dtSource.Select($"ValueItem='{valueGuid.ToString()}'")[0]);
        break;
      }
    }
  }

  protected void FillComboBox()
  {
    Cursor.Current = MgaCursors.WaitCursor;
    this._dtSource = DefaultDatabase.ExecuteDataTable(CommandType.StoredProcedure, this._storedProcName, 120, (CommandArgumentType) 0, new object[10]
    {
      (object) "@selectionType",
      (object) this.SelectionType,
      (object) "@searchText",
      (object) ((TextEditorControlBase) this.txtSearch).Text,
      (object) "@CurrentUserGuid",
      (object) CurrentUser.Instance.UserGUID,
      (object) "@ViewAllProducers",
      (object) this._viewAllProducers,
      (object) "@code",
      Interaction.IIf(((TextEditorControlBase) this.txtCode).Text.Replace(" ", string.Empty).Length > 0, (object) ((TextEditorControlBase) this.txtCode).Text, (object) null)
    });
    try
    {
      this.lstResults.BeginUpdate();
      if (((UltraToggleEditorBase) this.chkHideClosedInactive).Checked)
      {
        MGAListBox lstResults = this.lstResults;
        lstResults.DisplayMember = "DisplayItem";
        lstResults.ValueMember = "ValueItem";
        EnumerableRowCollection<DataRow> source1 = this._dtSource.AsEnumerable();
        System.Func<DataRow, bool> predicate;
        // ISSUE: reference to a compiler-generated field
        if (frmSelection._Closure\u0024__.\u0024I86\u002D0 != null)
        {
          // ISSUE: reference to a compiler-generated field
          predicate = frmSelection._Closure\u0024__.\u0024I86\u002D0;
        }
        else
        {
          // ISSUE: reference to a compiler-generated field
          frmSelection._Closure\u0024__.\u0024I86\u002D0 = predicate = (System.Func<DataRow, bool>) ([SpecialName] (source) => source.Field<byte>("StatusID") != (byte) 2 && source.Field<byte>("StatusID") != (byte) 3);
        }
        EnumerableRowCollection<DataRow> source2 = source1.Where<DataRow>(predicate);
        System.Func<DataRow, DataRow> selector;
        // ISSUE: reference to a compiler-generated field
        if (frmSelection._Closure\u0024__.\u0024I86\u002D1 != null)
        {
          // ISSUE: reference to a compiler-generated field
          selector = frmSelection._Closure\u0024__.\u0024I86\u002D1;
        }
        else
        {
          // ISSUE: reference to a compiler-generated field
          frmSelection._Closure\u0024__.\u0024I86\u002D1 = selector = (System.Func<DataRow, DataRow>) ([SpecialName] (source) => source);
        }
        lstResults.DataSource = (object) source2.Select<DataRow, DataRow>(selector).AsDataView<DataRow>();
      }
      else
      {
        MGAListBox lstResults = this.lstResults;
        lstResults.DisplayMember = "DisplayItem";
        lstResults.ValueMember = "ValueItem";
        lstResults.DataSource = (object) this._dtSource;
      }
      this.lstResults.EndUpdate();
      if (this.lstResults.Items.Count < 100)
        return;
      if (CurrentUser.Instance.UsingXP)
        BalloonTip.ShowEditTip((Control) this.txtSearch, "Limiting Results", "More than 100 results were returned.\n\nPlease specify a better search criteria to limit the results.", BalloonTip.BalloonTipIcons.Info);
      else
        this.lblLimitedResults.Visible = true;
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
      ((Control) this.btnSearch).Enabled = true;
    }
  }

  protected void LaunchForm()
  {
    if (!this.Launch)
    {
      this.Close();
    }
    else
    {
      ((Control) this.btnGo).Enabled = false;
      Cursor.Current = MgaCursors.WaitCursor;
      try
      {
        Form form = (Form) null;
        switch (this._selectionType)
        {
          case frmSelection.SelectionTypes.Producer:
            Guid producerLocationGuid = new Guid(this.lstResults.SelectedValue.ToString());
            if (Utility.IsNull(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT ProducerGuid FROM tblProducerLocations WHERE ProducerLocationGuid=@PLG", new object[2]
            {
              (object) "@PLG",
              (object) producerLocationGuid.ToString()
            })))))
            {
              int num = (int) MessageBox.Show("The selected producer cannot be found. It is possible it was removed by another user or not successfully saved.", "Producer Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
              return;
            }
            ProducerLocation producerLocation = new ProducerLocation(producerLocationGuid);
            form = ObjectFactory.Instance.CreateFormEX(typeof (frmProducers), typeof (frmProducers), (object) producerLocation.ProducerGuid, (object) producerLocation.ProducerLocationGuid);
            break;
          case frmSelection.SelectionTypes.Company:
            Guid guid1 = new Guid(this.lstResults.SelectedValue.ToString());
            object objectValue = RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT CompanyGuid FROM tblCompanyLocations WHERE CompanyLocationGuid=@CLG", new object[2]
            {
              (object) "@CLG",
              (object) guid1
            }));
            if (objectValue == null)
            {
              int num = (int) MessageBox.Show("The selected company cannot be found. It is possible it was removed by another user.", "Company Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
              return;
            }
            form = ObjectFactory.Instance.CreateFormEX(typeof (frmCompanies), typeof (frmCompanies), (object) (Guid) objectValue, (object) guid1);
            break;
          case frmSelection.SelectionTypes.Retailer:
            this.Close();
            break;
          case frmSelection.SelectionTypes.Insured:
            Guid guid2 = new Guid(this.lstResults.SelectedValue.ToString());
            form = ObjectFactory.Instance.CreateFormEX(typeof (frmInsureds), typeof (frmInsureds), (object) DefaultDatabase.ExecuteScalar<Guid>(CommandType.Text, "SELECT InsuredGuid FROM tblInsuredLocations WHERE InsuredLocationGuid=@ILG", new object[2]
            {
              (object) "@ILG",
              (object) guid2
            }), (object) guid2);
            break;
        }
        if (form == null)
          return;
        form.MdiParent = MDIControls.Instance.MDIParent;
        API.LockWindowUpdate(MDIControls.Instance.MDIParent.Handle);
        form.Show();
        API.LockWindowUpdate(new IntPtr());
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ErrorHandler.HandleError(ex);
        ProjectData.ClearProjectError();
      }
      finally
      {
        ((Control) this.btnGo).Enabled = true;
        Cursor.Current = MgaCursors.Default;
      }
    }
  }

  protected void btnGo_Click(object sender, EventArgs e)
  {
    ((Control) this.btnGo).Enabled = false;
    if (this.lstResults.SelectedIndex < 0)
    {
      int num = (int) MessageBox.Show("Please select an item from the list before continuing.", "Select An Item", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
    else
    {
      Cursor.Current = MgaCursors.WaitCursor;
      this._saved = true;
      try
      {
        this.LaunchForm();
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
        ((Control) this.btnGo).Enabled = true;
      }
    }
  }

  protected void btnNew_Click(object sender, EventArgs e)
  {
    string entType = this._selectionType.ToString();
    if (!this.CanAddEntity(ref entType))
    {
      int num = (int) MessageBox.Show("You do not have the required permission to add " + entType, "Insufficient Permissions", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    else
    {
      Cursor.Current = MgaCursors.WaitCursor;
      Form form = (Form) null;
      switch (this._selectionType)
      {
        case frmSelection.SelectionTypes.Producer:
        case frmSelection.SelectionTypes.Retailer:
          form = ObjectFactory.Instance.CreateForm(typeof (frmProducers), typeof (frmProducers));
          break;
        case frmSelection.SelectionTypes.Company:
          form = ObjectFactory.Instance.CreateForm(typeof (frmCompanies), typeof (frmCompanies));
          break;
        case frmSelection.SelectionTypes.Insured:
          form = ObjectFactory.Instance.CreateForm(typeof (frmInsureds), typeof (frmInsureds));
          break;
      }
      if (form != null)
      {
        form.MdiParent = MDIControls.Instance.MDIParent;
        form.Show();
      }
      Cursor.Current = MgaCursors.Default;
    }
  }

  protected void lstResults_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.LaunchForm();
  }

  private bool CanAddEntity(ref string entType)
  {
    bool flag = true;
    entType = string.Empty;
    switch (this._selectionType)
    {
      case frmSelection.SelectionTypes.Producer:
        entType = "Producer";
        flag = frmProducers.CanAddProducer();
        break;
      case frmSelection.SelectionTypes.Company:
        entType = "Companies";
        flag = SecurityManager.Instance.AssertPermission("{C266F1AF-4856-4647-BC41-CE2D40D5E294}");
        break;
      case frmSelection.SelectionTypes.Retailer:
        entType = "Retailer";
        flag = frmProducers.CanAddRetailer();
        break;
      case frmSelection.SelectionTypes.Insured:
        entType = "Insureds";
        flag = SecurityManager.Instance.AssertPermission("{ADAE0A61-DE61-4aaf-8BCA-39F8158C9248}");
        break;
    }
    return flag;
  }

  private void btnSearch_Click(object sender, EventArgs e)
  {
    ((Control) this.btnSearch).Enabled = false;
    this._dtSource.Clear();
    this.FillComboBox();
  }

  private void txtSearch_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.btnSearch_Click(RuntimeHelpers.GetObjectValue(sender), (EventArgs) null);
  }

  private void lstResults_SelectedIndexChanged(object sender, EventArgs e)
  {
    ((Control) this.btnGo).Enabled = true;
  }

  private void lstResults_DoubleClick(object sender, EventArgs e)
  {
    this.btnGo_Click(RuntimeHelpers.GetObjectValue(sender), e);
  }

  private void GetMinMaxInfoHelper(ref Message m)
  {
    frmSelection.MINMAXINFO lparam = (frmSelection.MINMAXINFO) m.GetLParam(typeof (frmSelection.MINMAXINFO));
    Size size;
    if (!this.MinimumSize.IsEmpty)
    {
      ref frmSelection.POINTAPI local1 = ref lparam.ptMinTrackSize;
      size = this.MinimumSize;
      int width = size.Width;
      local1.x = width;
      ref frmSelection.POINTAPI local2 = ref lparam.ptMinTrackSize;
      size = this.MinimumSize;
      int height = size.Height;
      local2.y = height;
    }
    size = this.MaximumSize;
    if (!size.IsEmpty)
    {
      ref frmSelection.POINTAPI local3 = ref lparam.ptMaxTrackSize;
      size = this.MaximumSize;
      int width = size.Width;
      local3.x = width;
      ref frmSelection.POINTAPI local4 = ref lparam.ptMaxTrackSize;
      size = this.MaximumSize;
      int height = size.Height;
      local4.y = height;
    }
    Marshal.StructureToPtr<frmSelection.MINMAXINFO>(lparam, m.LParam, true);
    m.Result = IntPtr.Zero;
  }

  protected override void WndProc(ref Message m)
  {
    if (m.Msg == 36)
    {
      this.GetMinMaxInfoHelper(ref m);
    }
    else
    {
      try
      {
        base.WndProc(ref m);
      }
      catch (NullReferenceException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        ProjectData.ClearProjectError();
      }
    }
  }

  private void lnkAdvanceProducerSearch_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    switch (this._selectionType)
    {
      case frmSelection.SelectionTypes.Producer:
        FormSettings.ShowForm(typeof (frmAdvancedProducerSearch));
        break;
      case frmSelection.SelectionTypes.Company:
        FormSettings.ShowForm(typeof (MGASystems.IMS.InsuredsProducersCompanies.Companies.frmAdvancedCompanySearch));
        break;
    }
  }

  private void SelectedIndexListener(object sender, EventArgs e) => this.lstResults.Invalidate();

  private void DrawItemListener(object sender, DrawItemEventArgs e)
  {
    if (e.Index < 0)
      return;
    DataRowView dataRowView = (DataRowView) this.lstResults.Items[e.Index];
    if (dataRowView.Row.RowState != DataRowState.Deleted && dataRowView.Row.RowState != DataRowState.Detached)
    {
      string s = dataRowView.Row["DisplayItem"].ToString();
      short num1 = 1;
      short num2 = 0;
      if (dataRowView.Row["StatusID"] != null && dataRowView.Row["StatusID"] != DBNull.Value)
        num1 = Conversions.ToShort(dataRowView.Row["StatusID"]);
      if (dataRowView.Row["LocationTypeID"] != null && dataRowView.Row["LocationTypeID"] != DBNull.Value)
        num2 = Conversions.ToShort(dataRowView.Row["LocationTypeID"]);
      Font font = e.Font;
      Graphics graphics = e.Graphics;
      bool flag = false;
      if (e.Index == this.lstResults.SelectedIndex)
        flag = true;
      e.DrawBackground();
      if (num1 == (short) 3)
        font = new Font(e.Font, FontStyle.Strikeout);
      if (this._SetPrimarryOfficeTypeToBold)
      {
        if (num2 == (short) 1 && num1 == (short) 3)
          font = new Font(e.Font, FontStyle.Bold | FontStyle.Strikeout);
        else if (num2 == (short) 1 && num1 == (short) 1)
          font = new Font(e.Font, FontStyle.Bold);
      }
      if (!flag)
      {
        if (num1 != (short) 1)
          e.Graphics.DrawString(s, font, Brushes.Red, (RectangleF) e.Bounds, StringFormat.GenericDefault);
        else
          e.Graphics.DrawString(s, font, Brushes.Black, (RectangleF) e.Bounds, StringFormat.GenericDefault);
      }
      else
      {
        graphics.FillRectangle((Brush) new SolidBrush(Color.Blue), e.Bounds);
        e.Graphics.DrawString(s, font, Brushes.White, (RectangleF) e.Bounds, StringFormat.GenericDefault);
      }
    }
    e.DrawFocusRectangle();
  }

  private void ChkHideClosedInactive_CheckedChanged(object sender, EventArgs e)
  {
    MGAListBox lstResults = this.lstResults;
    if (((UltraToggleEditorBase) this.chkHideClosedInactive).Checked)
    {
      EnumerableRowCollection<DataRow> source1 = this._dtSource.AsEnumerable();
      System.Func<DataRow, bool> predicate;
      // ISSUE: reference to a compiler-generated field
      if (frmSelection._Closure\u0024__.\u0024I103\u002D0 != null)
      {
        // ISSUE: reference to a compiler-generated field
        predicate = frmSelection._Closure\u0024__.\u0024I103\u002D0;
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        frmSelection._Closure\u0024__.\u0024I103\u002D0 = predicate = (System.Func<DataRow, bool>) ([SpecialName] (source) =>
        {
          byte? nullable1 = source.Field<byte?>("StatusID");
          int? nullable2 = nullable1.HasValue ? new int?((int) nullable1.GetValueOrDefault()) : new int?();
          bool? nullable3;
          bool? nullable4 = nullable3 = nullable2.HasValue ? new bool?(nullable2.GetValueOrDefault() != 2) : new bool?();
          bool? nullable5;
          bool? nullable6;
          if (!nullable4.HasValue || nullable3.GetValueOrDefault())
          {
            nullable1 = source.Field<byte?>("StatusID");
            int? nullable7 = nullable1.HasValue ? new int?((int) nullable1.GetValueOrDefault()) : new int?();
            bool? nullable8;
            if (!nullable7.HasValue)
            {
              nullable4 = new bool?();
              nullable8 = nullable4;
            }
            else
              nullable8 = new bool?(nullable7.GetValueOrDefault() != 3);
            nullable5 = nullable8;
            nullable4 = nullable8;
            if (!nullable4.HasValue)
            {
              nullable4 = new bool?();
              nullable6 = nullable4;
            }
            else
              nullable6 = nullable5.GetValueOrDefault() ? nullable3 : new bool?(false);
          }
          else
            nullable6 = new bool?(false);
          nullable5 = nullable6;
          return nullable5.GetValueOrDefault();
        });
      }
      EnumerableRowCollection<DataRow> source2 = source1.Where<DataRow>(predicate);
      System.Func<DataRow, DataRow> selector;
      // ISSUE: reference to a compiler-generated field
      if (frmSelection._Closure\u0024__.\u0024I103\u002D1 != null)
      {
        // ISSUE: reference to a compiler-generated field
        selector = frmSelection._Closure\u0024__.\u0024I103\u002D1;
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        frmSelection._Closure\u0024__.\u0024I103\u002D1 = selector = (System.Func<DataRow, DataRow>) ([SpecialName] (source) => source);
      }
      DataView dataView = source2.Select<DataRow, DataRow>(selector).AsDataView<DataRow>();
      lstResults.DataSource = (object) dataView;
    }
    else
      lstResults.DataSource = (object) this._dtSource;
  }

  public enum SelectionTypes
  {
    Producer = 1,
    Company = 2,
    Retailer = 3,
    Insured = 4,
  }

  private enum StatusType
  {
    Active = 1,
    Inactive = 2,
    Closed = 3,
  }

  private struct POINTAPI
  {
    public int x;
    public int y;
  }

  private struct MINMAXINFO
  {
    public frmSelection.POINTAPI ptReserved;
    public frmSelection.POINTAPI ptMaxSize;
    public frmSelection.POINTAPI ptMaxPosition;
    public frmSelection.POINTAPI ptMinTrackSize;
    public frmSelection.POINTAPI ptMaxTrackSize;
  }
}
