// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.NoteDocuments.frmCopyNotesToCompanyLines
// Assembly: MgaSystems.IMS.NotesDocuments, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 3F898CF7-066D-4B05-A9F1-D37DBC4FAA16
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.NotesDocuments.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using MGASystems.Common;
using MGASystems.Common.DataAccess;
using MGASystems.Tools;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
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

[SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly")]
public class frmCopyNotesToCompanyLines : Form
{
  private IContainer components;
  private Guid _existingCompanyLineGuid;

  public frmCopyNotesToCompanyLines()
  {
    this.Load += new EventHandler(this.frmCopyNotesToCompanyLines_Load);
    this.InitializeComponent();
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  [field: AccessedThroughProperty("Label2")]
  internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label3")]
  internal virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label4")]
  internal virtual Label Label4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("dgCompanyLines")]
  internal virtual UltraGrid dgCompanyLines { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cboCompany")]
  private virtual MGASimpleComboBox cboCompany { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ds")]
  internal virtual dsCopyNotesToCompanyLine ds { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlSelectCommand1")]
  internal virtual SqlCommand SqlSelectCommand1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cn")]
  internal virtual SqlConnection cn { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("daGetCompanyLines")]
  internal virtual SqlDataAdapter daGetCompanyLines { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cboLine")]
  internal virtual MGASimpleComboBox cboLine { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cboState")]
  internal virtual MGASimpleComboBox cboState { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual MGAButton btnCopyNotes
  {
    get => this._btnCopyNotes;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnCopyNotes_Click);
      MGAButton btnCopyNotes1 = this._btnCopyNotes;
      if (btnCopyNotes1 != null)
        ((Control) btnCopyNotes1).Click -= eventHandler;
      this._btnCopyNotes = value;
      MGAButton btnCopyNotes2 = this._btnCopyNotes;
      if (btnCopyNotes2 == null)
        return;
      ((Control) btnCopyNotes2).Click += eventHandler;
    }
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    UltraGridBand ultraGridBand1 = new UltraGridBand("ViewCompanyLines", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("CompanyLineGuid");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("LineName");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("Name");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("State");
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("CompanyLocationGuid");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("ViewCompanyLinesViewCompanyLinesChildren");
    UltraGridBand ultraGridBand2 = new UltraGridBand("ViewCompanyLinesViewCompanyLinesChildren", 0);
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("CompanyLineGuid");
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("LineName");
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("Name");
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("State");
    UltraGridColumn ultraGridColumn11 = new UltraGridColumn("CompanyLocationGuid");
    UltraGridColumn ultraGridColumn12 = new UltraGridColumn("ParentCompanyLineGuid");
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    this.btnCopyNotes = new MGAButton();
    this.cboCompany = new MGASimpleComboBox();
    this.ds = new dsCopyNotesToCompanyLine();
    this.cboLine = new MGASimpleComboBox();
    this.cboState = new MGASimpleComboBox();
    this.Label2 = new Label();
    this.Label3 = new Label();
    this.Label4 = new Label();
    this.dgCompanyLines = new UltraGrid();
    this.daGetCompanyLines = new SqlDataAdapter();
    this.SqlSelectCommand1 = new SqlCommand();
    this.cn = new SqlConnection();
    ((ISupportInitialize) this.btnCopyNotes).BeginInit();
    ((ISupportInitialize) this.cboCompany).BeginInit();
    this.ds.BeginInit();
    ((ISupportInitialize) this.cboLine).BeginInit();
    ((ISupportInitialize) this.cboState).BeginInit();
    ((ISupportInitialize) this.dgCompanyLines).BeginInit();
    this.SuspendLayout();
    ((Control) this.btnCopyNotes).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance1.BackColor = Color.FromArgb(248, 248, 248);
    appearance1.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance1.BackGradientStyle = (GradientStyle) 2;
    appearance1.BorderColor = Color.DarkGray;
    appearance1.ImageHAlign = (HAlign) 2;
    appearance1.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnCopyNotes).Appearance = (AppearanceBase) appearance1;
    ((ControlBase) this.btnCopyNotes).ImageSize = new Size(24, 24);
    ((ControlBase) this.btnCopyNotes).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnCopyNotes).Location = new Point(600, 360);
    ((Control) this.btnCopyNotes).Name = "btnCopyNotes";
    ((Control) this.btnCopyNotes).Size = new Size(104, 32 /*0x20*/);
    ((Control) this.btnCopyNotes).TabIndex = 4;
    ((ControlBase) this.btnCopyNotes).Text = "Copy Note";
    this.cboCompany.BorderStyle = (UIElementBorderStyle) 4;
    this.cboCompany.CharacterCasing = CharacterCasing.Normal;
    ((UltraGridBase) this.cboCompany).DataSource = (object) this.ds.tblCompanyLocations;
    ((UltraDropDownBase) this.cboCompany).DisplayMember = "Name";
    this.cboCompany.DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboCompany).DropDownWidth = 500;
    ((Control) this.cboCompany).Location = new Point(8, 24);
    this.cboCompany.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboCompany).Name = "cboCompany";
    ((Control) this.cboCompany).Size = new Size(224 /*0xE0*/, 19);
    ((Control) this.cboCompany).TabIndex = 5;
    ((UltraDropDownBase) this.cboCompany).ValueMember = "CompanyLocationGuid";
    this.ds.DataSetName = "dsCopyNotesToCompanyLine";
    this.ds.Locale = new CultureInfo("en-US");
    this.cboLine.BorderStyle = (UIElementBorderStyle) 4;
    this.cboLine.CharacterCasing = CharacterCasing.Normal;
    ((UltraGridBase) this.cboLine).DataSource = (object) this.ds.lstLines;
    ((UltraDropDownBase) this.cboLine).DisplayMember = "LineName";
    this.cboLine.DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboLine).DropDownWidth = 500;
    ((Control) this.cboLine).Location = new Point(240 /*0xF0*/, 24);
    this.cboLine.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboLine).Name = "cboLine";
    ((Control) this.cboLine).Size = new Size(224 /*0xE0*/, 19);
    ((Control) this.cboLine).TabIndex = 6;
    ((UltraDropDownBase) this.cboLine).ValueMember = "LineGuid";
    this.cboState.BorderStyle = (UIElementBorderStyle) 4;
    this.cboState.CharacterCasing = CharacterCasing.Normal;
    ((UltraGridBase) this.cboState).DataSource = (object) this.ds.lstStates;
    ((UltraDropDownBase) this.cboState).DisplayMember = "State";
    this.cboState.DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboState).DropDownWidth = 500;
    ((Control) this.cboState).Location = new Point(480, 24);
    this.cboState.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboState).Name = "cboState";
    ((Control) this.cboState).Size = new Size(224 /*0xE0*/, 19);
    ((Control) this.cboState).TabIndex = 7;
    ((UltraDropDownBase) this.cboState).ValueMember = "StateID";
    this.Label2.BackColor = Color.Transparent;
    this.Label2.Location = new Point(8, 8);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(88, 16 /*0x10*/);
    this.Label2.TabIndex = 8;
    this.Label2.Text = "Company";
    this.Label3.BackColor = Color.Transparent;
    this.Label3.Location = new Point(240 /*0xF0*/, 8);
    this.Label3.Name = "Label3";
    this.Label3.Size = new Size(88, 16 /*0x10*/);
    this.Label3.TabIndex = 9;
    this.Label3.Text = "Line";
    this.Label4.BackColor = Color.Transparent;
    this.Label4.Location = new Point(480, 8);
    this.Label4.Name = "Label4";
    this.Label4.Size = new Size(88, 16 /*0x10*/);
    this.Label4.TabIndex = 10;
    this.Label4.Text = "State";
    ((Control) this.dgCompanyLines).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraGridBase) this.dgCompanyLines).DataSource = (object) this.ds.ViewCompanyLines;
    appearance2.BackColor = Color.White;
    appearance2.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.dgCompanyLines).DisplayLayout.Appearance = (AppearanceBase) appearance2;
    ((UltraGridBase) this.dgCompanyLines).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn1.Width = 156;
    ((HeaderBase) ultraGridColumn2.Header).Caption = "Line";
    ultraGridColumn2.Header.VisiblePosition = 2;
    ultraGridColumn2.Width = 272;
    ((HeaderBase) ultraGridColumn3.Header).Caption = "Company";
    ultraGridColumn3.Header.VisiblePosition = 1;
    ultraGridColumn3.Width = 265;
    ultraGridColumn4.Header.VisiblePosition = 3;
    ultraGridColumn4.Width = 146;
    ultraGridColumn5.Header.VisiblePosition = 4;
    ultraGridColumn5.Hidden = true;
    ultraGridColumn5.Width = 248;
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
    ultraGridColumn7.Header.VisiblePosition = 0;
    ultraGridColumn7.Hidden = true;
    ((HeaderBase) ultraGridColumn8.Header).Caption = "Line";
    ultraGridColumn8.Header.VisiblePosition = 2;
    ultraGridColumn8.Width = 166;
    ((HeaderBase) ultraGridColumn9.Header).Caption = "Company";
    ultraGridColumn9.Header.VisiblePosition = 1;
    ultraGridColumn9.Width = 344;
    ultraGridColumn10.Header.VisiblePosition = 3;
    ultraGridColumn10.Width = 154;
    ultraGridColumn11.Header.VisiblePosition = 4;
    ultraGridColumn11.Hidden = true;
    ultraGridColumn12.Header.VisiblePosition = 5;
    ultraGridColumn12.Hidden = true;
    ultraGridBand2.Columns.AddRange(new object[6]
    {
      (object) ultraGridColumn7,
      (object) ultraGridColumn8,
      (object) ultraGridColumn9,
      (object) ultraGridColumn10,
      (object) ultraGridColumn11,
      (object) ultraGridColumn12
    });
    ((UltraGridBase) this.dgCompanyLines).DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    ((UltraGridBase) this.dgCompanyLines).DisplayLayout.BandsSerializer.Add((object) ultraGridBand2);
    ((UltraGridBase) this.dgCompanyLines).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance3.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance3.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.dgCompanyLines).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance3;
    ((UltraGridBase) this.dgCompanyLines).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.dgCompanyLines).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.dgCompanyLines).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    appearance4.BorderColor = Color.LightGray;
    ((UltraGridBase) this.dgCompanyLines).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance4;
    ((UltraGridBase) this.dgCompanyLines).DisplayLayout.Override.CellClickAction = (CellClickAction) 2;
    ((UltraGridBase) this.dgCompanyLines).DisplayLayout.Override.ExpansionIndicator = (ShowExpansionIndicator) 3;
    appearance5.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.dgCompanyLines).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance5;
    ((UltraGridBase) this.dgCompanyLines).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance6.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.dgCompanyLines).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance6;
    appearance7.BorderColor = Color.LightGray;
    ((UltraGridBase) this.dgCompanyLines).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance7;
    ((UltraGridBase) this.dgCompanyLines).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance8.BackColor = Color.Transparent;
    appearance8.ForeColor = Color.Black;
    ((UltraGridBase) this.dgCompanyLines).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance8;
    appearance9.BackColor = Color.WhiteSmoke;
    appearance9.BorderColor = Color.Silver;
    scrollBarLook.ButtonAppearance = (AppearanceBase) appearance9;
    appearance10.BackColor = Color.White;
    scrollBarLook.TrackAppearance = (AppearanceBase) appearance10;
    ((UltraGridBase) this.dgCompanyLines).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((UltraControlBase) this.dgCompanyLines).UseFlatMode = (DefaultableBoolean) 1;
    ((Control) this.dgCompanyLines).Location = new Point(0, 48 /*0x30*/);
    ((Control) this.dgCompanyLines).Name = "dgCompanyLines";
    ((Control) this.dgCompanyLines).Size = new Size(704, 304);
    ((UltraControlBase) this.dgCompanyLines).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.dgCompanyLines).TabIndex = 11;
    this.daGetCompanyLines.SelectCommand = this.SqlSelectCommand1;
    this.daGetCompanyLines.TableMappings.AddRange(new DataTableMapping[4]
    {
      new DataTableMapping("Table", "dbo_GetCompanyLines", new DataColumnMapping[26]
      {
        new DataColumnMapping("CompanyLineGUID", "CompanyLineGUID"),
        new DataColumnMapping("ParentCompanyLineGUID", "ParentCompanyLineGUID"),
        new DataColumnMapping("CompanyLocationGUID", "CompanyLocationGUID"),
        new DataColumnMapping("LineGUID", "LineGUID"),
        new DataColumnMapping("StateID", "StateID"),
        new DataColumnMapping("CompanyLicenseTypeID", "CompanyLicenseTypeID"),
        new DataColumnMapping("StatusID", "StatusID"),
        new DataColumnMapping("LicenseTypeID", "LicenseTypeID"),
        new DataColumnMapping("UserSignatureGUID", "UserSignatureGUID"),
        new DataColumnMapping("Hidden", "Hidden"),
        new DataColumnMapping("AllowAutomaticNOC", "AllowAutomaticNOC"),
        new DataColumnMapping("MailingNumDays", "MailingNumDays"),
        new DataColumnMapping("NocNumDays", "NocNumDays"),
        new DataColumnMapping("EmailReminder", "EmailReminder"),
        new DataColumnMapping("EmailReminderDays", "EmailReminderDays"),
        new DataColumnMapping("NOCIncludeFees", "NOCIncludeFees"),
        new DataColumnMapping("InvoiceMailingDays", "InvoiceMailingDays"),
        new DataColumnMapping("QuoteAdditionalComments", "QuoteAdditionalComments"),
        new DataColumnMapping("BinderExpirationDays", "BinderExpirationDays"),
        new DataColumnMapping("MinimumEarnedPercentage", "MinimumEarnedPercentage"),
        new DataColumnMapping("Added", "Added"),
        new DataColumnMapping("MaxBackDateDays", "MaxBackDateDays"),
        new DataColumnMapping("EnforceUniquePolicyNumbers", "EnforceUniquePolicyNumbers"),
        new DataColumnMapping("DefaultInvoiceComment", "DefaultInvoiceComment"),
        new DataColumnMapping("BinderComments", "BinderComments"),
        new DataColumnMapping("AllowEndorsementsWithoutIssuance", "AllowEndorsementsWithoutIssuance")
      }),
      new DataTableMapping("Table1", "Table1", new DataColumnMapping[5]
      {
        new DataColumnMapping("CompanyLineGuid", "CompanyLineGuid"),
        new DataColumnMapping("LineName", "LineName"),
        new DataColumnMapping("Name", "Name"),
        new DataColumnMapping("CompanyLocationGUID", "CompanyLocationGUID"),
        new DataColumnMapping("State", "State")
      }),
      new DataTableMapping("Table2", "Table2", new DataColumnMapping[6]
      {
        new DataColumnMapping("CompanyLineGuid", "CompanyLineGuid"),
        new DataColumnMapping("ParentCompanyLineGUID", "ParentCompanyLineGUID"),
        new DataColumnMapping("LineName", "LineName"),
        new DataColumnMapping("Name", "Name"),
        new DataColumnMapping("CompanyLocationGUID", "CompanyLocationGUID"),
        new DataColumnMapping("State", "State")
      }),
      new DataTableMapping("Table3", "Table3", new DataColumnMapping[2]
      {
        new DataColumnMapping("CompanyLineGuid", "CompanyLineGuid"),
        new DataColumnMapping("Parent", "Parent")
      })
    });
    this.SqlSelectCommand1.CommandText = "dbo.[GetCompanyLines]";
    this.SqlSelectCommand1.CommandType = CommandType.StoredProcedure;
    this.SqlSelectCommand1.Connection = this.cn;
    this.SqlSelectCommand1.Parameters.Add(new SqlParameter("@companyLocationGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/));
    this.SqlSelectCommand1.Parameters.Add(new SqlParameter("@lineGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/));
    this.SqlSelectCommand1.Parameters.Add(new SqlParameter("@stateID", SqlDbType.VarChar, 2));
    this.cn.ConnectionString = "workstation id=ERICHARDS1;packet size=4096;integrated security=SSPI;data source=MGASYSTEMS;persist security info=False;initial catalog=IMS";
    this.AutoScaleBaseSize = new Size(5, 13);
    this.BackColor = Color.White;
    this.ClientSize = new Size(712, 398);
    this.Controls.Add((Control) this.dgCompanyLines);
    this.Controls.Add((Control) this.Label4);
    this.Controls.Add((Control) this.Label3);
    this.Controls.Add((Control) this.Label2);
    this.Controls.Add((Control) this.cboState);
    this.Controls.Add((Control) this.cboLine);
    this.Controls.Add((Control) this.cboCompany);
    this.Controls.Add((Control) this.btnCopyNotes);
    this.Name = nameof (frmCopyNotesToCompanyLines);
    this.Text = "Copy Notes To Company Lines";
    ((ISupportInitialize) this.btnCopyNotes).EndInit();
    ((ISupportInitialize) this.cboCompany).EndInit();
    this.ds.EndInit();
    ((ISupportInitialize) this.cboLine).EndInit();
    ((ISupportInitialize) this.cboState).EndInit();
    ((ISupportInitialize) this.dgCompanyLines).EndInit();
    this.ResumeLayout(false);
  }

  public frmCopyNotesToCompanyLines(Guid originalCompanyLineGuid)
  {
    this.Load += new EventHandler(this.frmCopyNotesToCompanyLines_Load);
    this.InitializeComponent();
    this._existingCompanyLineGuid = originalCompanyLineGuid;
    this.cn.ConnectionString = CurrentUser.Instance.ConnectionString;
  }

  private void frmCopyNotesToCompanyLines_Load(object sender, EventArgs e)
  {
    dsCopyNotesToCompanyLine.tblCompanyLocationsRow row = this.ds.tblCompanyLocations.NewtblCompanyLocationsRow();
    row.CompanyLocationGuid = Guid.Empty;
    row.Name = "Any";
    this.ds.tblCompanyLocations.AddtblCompanyLocationsRow(row);
    Database.Instance.QueryText.PerformTableQuery("SELECT CompanyLocationGuid, Name FROM tblCompanyLocations (NOLOCK) ORDER BY Name", (DataTable) this.ds.tblCompanyLocations);
    dsCopyNotesToCompanyLine.lstLinesRow lstLinesRow = this.ds.lstLines.NewlstLinesRow();
    lstLinesRow.LineGuid = Guid.Empty;
    lstLinesRow.LineName = "Any";
    Database.Instance.QueryText.PerformTableQuery("SELECT LineGuid, LineName FROM lstLines (NOLOCK) ORDER BY LineName", (DataTable) this.ds.lstLines);
    dsCopyNotesToCompanyLine.lstStatesRow lstStatesRow = this.ds.lstStates.NewlstStatesRow();
    lstStatesRow.StateID = string.Empty;
    lstStatesRow.State = "Any";
    Database.Instance.QueryText.PerformTableQuery("SELECT StateID, State FROM lstStates ORDER BY State", (DataTable) this.ds.lstStates);
    this.daGetCompanyLines.TableMappings.Clear();
    DataTableMappingCollection tableMappings = this.daGetCompanyLines.TableMappings;
    tableMappings.Add("Table", this.ds.tblCompanyLines.TableName);
    tableMappings.Add("Table1", this.ds.ViewCompanyLines.TableName);
    tableMappings.Add("Table2", this.ds.ViewCompanyLinesChildren.TableName);
    tableMappings.Add("Table3", this.ds.Parents.TableName);
    try
    {
      foreach (DataTable table in (InternalDataCollectionBase) this.ds.Tables)
        table.BeginLoadData();
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    this.cboCompany.ValueChanged += new EventHandler(this.FilterGrid);
    this.cboLine.ValueChanged += new EventHandler(this.FilterGrid);
    this.cboState.ValueChanged += new EventHandler(this.FilterGrid);
  }

  private void FilterGrid(object sender, EventArgs e)
  {
    this.ds.EnforceConstraints = false;
    try
    {
      this.ds.ViewCompanyLines.Clear();
      this.ds.ViewCompanyLinesChildren.Clear();
      this.ds.tblCompanyLines.Clear();
      this.ds.Parents.Clear();
    }
    catch (ArgumentOutOfRangeException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      ProjectData.ClearProjectError();
    }
    SqlCommand selectCommand = this.daGetCompanyLines.SelectCommand;
    selectCommand.Parameters["@CompanyLocationGuid"].Value = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cboCompany.Text, "Any", false) == 0 ? (object) null : RuntimeHelpers.GetObjectValue(this.cboCompany.Value);
    selectCommand.Parameters["@lineGuid"].Value = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cboLine.Text, "Any", false) == 0 ? (object) null : RuntimeHelpers.GetObjectValue(this.cboLine.Value);
    selectCommand.Parameters["@stateID"].Value = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cboState.Text, "Any", false) == 0 ? (object) null : RuntimeHelpers.GetObjectValue(this.cboState.Value);
    this.Cursor = MgaCursors.WaitCursor;
    try
    {
      Database.SafeDataAdapterFill(this.daGetCompanyLines, (DataSet) this.ds);
    }
    finally
    {
      this.Cursor = MgaCursors.Default;
    }
    dsCopyNotesToCompanyLine.ViewCompanyLinesRow byCompanyLineGuid1 = this.ds.ViewCompanyLines.FindByCompanyLineGuid(this._existingCompanyLineGuid);
    if (byCompanyLineGuid1 != null)
      this.ds.ViewCompanyLines.RemoveViewCompanyLinesRow(byCompanyLineGuid1);
    dsCopyNotesToCompanyLine.ViewCompanyLinesChildrenRow byCompanyLineGuid2 = this.ds.ViewCompanyLinesChildren.FindByCompanyLineGuid(this._existingCompanyLineGuid);
    if (byCompanyLineGuid2 != null)
      this.ds.ViewCompanyLinesChildren.RemoveViewCompanyLinesChildrenRow(byCompanyLineGuid2);
    dsCopyNotesToCompanyLine.tblCompanyLinesRow byCompanyLineGuid3 = this.ds.tblCompanyLines.FindByCompanyLineGuid(this._existingCompanyLineGuid);
    if (byCompanyLineGuid3 == null)
      return;
    this.ds.tblCompanyLines.RemovetblCompanyLinesRow(byCompanyLineGuid3);
  }

  private void btnCopyNotes_Click(object sender, EventArgs e)
  {
    if (((UltraGridBase) this.dgCompanyLines).Rows.Count < 1 || ((UltraGridBase) this.dgCompanyLines).ActiveRow == null)
      return;
    if (MessageBox.Show($"Do you wish to copy all note automation events to {(string) ((UltraGridBase) this.dgCompanyLines).ActiveRow.Cells["Name"].Value}, {(string) ((UltraGridBase) this.dgCompanyLines).ActiveRow.Cells["LineName"].Value}, {(string) ((UltraGridBase) this.dgCompanyLines).ActiveRow.Cells["State"].Value}?", "Continue With Copy", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
      return;
    Database.Instance.QuerySP.PerformNonQuery("dbo.CopyNoteAutomationEvents", (object) "@newCompanyLineGuid", (object) (Guid) ((UltraGridBase) this.dgCompanyLines).ActiveRow.Cells["CompanyLineGuid"].Value, (object) "@exisitingCompanyLineGUID", (object) this._existingCompanyLineGuid);
  }
}
