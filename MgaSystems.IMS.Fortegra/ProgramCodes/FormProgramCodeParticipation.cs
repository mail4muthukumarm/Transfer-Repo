// Decompiled with JetBrains decompiler
// Type: MgaSystems.Ims.Fortegra.ProgramCodes.FormProgramCodeParticipation
// Assembly: MgaSystems.Ims.Fortegra, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 27007E94-85B4-4A1A-9444-255CCA5487B0
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Fortegra.dll

using Infragistics.Win;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinMaskedEdit;
using MGASystems.Data;
using MGASystems.Tools;
using MGASystems.Tools.DBSaveUI;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace MgaSystems.Ims.Fortegra.ProgramCodes;

public class FormProgramCodeParticipation : Form
{
  private readonly int _ProgramID;
  private BindingManagerBase _bmb;
  private IContainer components;
  protected UltraGrid dgParticipation;
  private dsProgCodeExt ds;
  private UltraDropDown ddCompanyLocations;
  private GroupBox grpDetails;
  private Label label4;
  protected MGASimpleComboBox cboCompanyLocation;
  protected MGANumericEditor numShare;
  private Label label3;
  private Label label1;
  protected MGADateTimePicker dtEndDate;
  private Label label2;
  protected MGADateTimePicker dtStartDate;
  protected MGASystems.Tools.DBSaveUI.DBSaveUI dbSave;
  private SqlDataAdapter da;
  private SqlCommand SqlDeleteCommand1;
  private SqlCommand SqlInsertCommand1;
  private SqlCommand SqlSelectCommand1;
  private SqlCommand SqlUpdateCommand1;
  private ErrorProvider err;

  public FormProgramCodeParticipation(int ProgramID, string progCode)
  {
    this.InitializeComponent();
    this._ProgramID = ProgramID;
    Utility.SetDataAdapterConnections((DbDataAdapter) this.da, (DbConnection) DefaultDatabase.CreateConnection(), (DbTransaction) null);
    ((Control) this.dgParticipation).Text = $"{((Control) this.dgParticipation).Text} [{progCode}]";
  }

  private void FormProgramCodeParticipation_Load(object sender, EventArgs e)
  {
    this.ds.tblCompanyLocations.AddtblCompanyLocationsRow(int.MinValue, string.Empty);
    DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[2]
    {
      "Fortegra_tblCompanyProgramParticpation",
      "tblCompanyLocations"
    }, "dbo.Fortegra_GetProgramCodeParticipationData", new object[2]
    {
      (object) "@ProgramID",
      (object) this._ProgramID
    });
    this._bmb = this.BindingContext[(object) this.ds, this.ds.Fortegra_tblCompanyProgramParticpation.TableName];
    this._bmb.Position = this.ds.Fortegra_tblCompanyProgramParticpation.Count - 1;
    this.SetEnabledState(false);
    this.SetSaveState();
  }

  private void dbSave_ClickingDelete(object sender, CancelEventArgs e)
  {
    if (this._bmb.Position < 0)
      e.Cancel = true;
    else if (DialogResult.Yes != MessageBox.Show("Continue Delete?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
    {
      e.Cancel = true;
    }
    else
    {
      this.ds.Fortegra_tblCompanyProgramParticpation[this._bmb.Position].Delete();
      DefaultDatabase.DataAdapterUpdate((DbDataAdapter) this.da, (DataTable) this.ds.Fortegra_tblCompanyProgramParticpation);
      this.SetEnabledState(false);
      this.SetSaveState();
    }
  }

  private void dbSave_ClickingNew(object sender, CancelEventArgs e)
  {
    this.SetEnabledState(true);
    dsProgCodeExt.Fortegra_tblCompanyProgramParticpationRow row = this.ds.Fortegra_tblCompanyProgramParticpation.NewFortegra_tblCompanyProgramParticpationRow();
    row.StartDate = DateTime.Now;
    row.EndDate = DateTime.Now.AddYears(1);
    row.CompanyLocationID = int.MinValue;
    row.ProgramID = this._ProgramID;
    this.ds.Fortegra_tblCompanyProgramParticpation.AddFortegra_tblCompanyProgramParticpationRow(row);
    this._bmb.Position = this.ds.Fortegra_tblCompanyProgramParticpation.Count - 1;
  }

  private void dbSave_ClickingEdit(object sender, CancelEventArgs e) => this.SetEnabledState(true);

  private void dbSave_ClickingSave(object sender, CancelEventArgs e)
  {
    if (!this.IsValidData())
    {
      e.Cancel = true;
    }
    else
    {
      this._bmb.EndCurrentEdit();
      DefaultDatabase.DataAdapterUpdate((DbDataAdapter) this.da, (DataTable) this.ds.Fortegra_tblCompanyProgramParticpation);
      int num = (int) MessageBox.Show("Data saved successfully", "Data Saved", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
  }

  private bool IsValidData()
  {
    bool flag = true;
    this.err.SetError((Control) this.cboCompanyLocation, string.Empty);
    this.err.SetError((Control) this.dtStartDate, string.Empty);
    if (string.IsNullOrEmpty(((Control) this.cboCompanyLocation).Text))
    {
      this.err.SetError((Control) this.cboCompanyLocation, "Please select a value");
      flag = false;
    }
    if (this.dtStartDate.Value == null || this.dtStartDate.Value == DBNull.Value)
    {
      this.err.SetError((Control) this.dtStartDate, "Please enter a value");
      flag = false;
    }
    return flag;
  }

  private void dbSave_ClickedCancel(object sender, EventArgs e)
  {
    this.ds.Fortegra_tblCompanyProgramParticpation.RejectChanges();
    this.SetSaveState();
    this.SetEnabledState(false);
  }

  private void SetSaveState()
  {
    if (this.ds.Fortegra_tblCompanyProgramParticpation.Count > 0)
      this.dbSave.UIState = UIState.HasRecordsNotEditing;
    else
      this.dbSave.UIState = UIState.NoRecordsNotEditing;
  }

  private void SetEnabledState(bool isEditing) => this.grpDetails.Enabled = isEditing;

  private void dbSave_ClickedSave(object sender, EventArgs e) => this.SetEnabledState(false);

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    UltraGridBand ultraGridBand1 = new UltraGridBand("Fortegra_tblCompanyProgramParticpation", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("ProgramID");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("CompanyLocationID", -1, (object) "ddCompanyLocations");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("Share");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("StartDate");
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("EndDate");
    SummarySettings summarySettings = new SummarySettings("", (SummaryType) 1, (string) null, "Share", 2, true, "Fortegra_tblCompanyProgramParticpation", 0, (SummaryPosition) 3, "Share", 2, true);
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    UltraGridBand ultraGridBand2 = new UltraGridBand("tblCompanyLocations", -1);
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("CompanyLocationID");
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("LocationName");
    Appearance appearance10 = new Appearance();
    Appearance appearance11 = new Appearance();
    Appearance appearance12 = new Appearance();
    Appearance appearance13 = new Appearance();
    Appearance appearance14 = new Appearance();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (FormProgramCodeParticipation));
    this.dgParticipation = new UltraGrid();
    this.ds = new dsProgCodeExt();
    this.ddCompanyLocations = new UltraDropDown();
    this.grpDetails = new GroupBox();
    this.label4 = new Label();
    this.cboCompanyLocation = new MGASimpleComboBox();
    this.numShare = new MGANumericEditor();
    this.label3 = new Label();
    this.label1 = new Label();
    this.dtEndDate = new MGADateTimePicker();
    this.label2 = new Label();
    this.dtStartDate = new MGADateTimePicker();
    this.dbSave = new MGASystems.Tools.DBSaveUI.DBSaveUI();
    this.da = new SqlDataAdapter();
    this.SqlDeleteCommand1 = new SqlCommand();
    this.SqlInsertCommand1 = new SqlCommand();
    this.SqlSelectCommand1 = new SqlCommand();
    this.SqlUpdateCommand1 = new SqlCommand();
    this.err = new ErrorProvider(this.components);
    ((ISupportInitialize) this.dgParticipation).BeginInit();
    this.ds.BeginInit();
    ((ISupportInitialize) this.ddCompanyLocations).BeginInit();
    this.grpDetails.SuspendLayout();
    ((ISupportInitialize) this.cboCompanyLocation).BeginInit();
    ((ISupportInitialize) this.numShare).BeginInit();
    ((ISupportInitialize) this.dtEndDate).BeginInit();
    ((ISupportInitialize) this.dtStartDate).BeginInit();
    ((ISupportInitialize) this.err).BeginInit();
    this.SuspendLayout();
    ((Control) this.dgParticipation).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraGridBase) this.dgParticipation).DataMember = "Fortegra_tblCompanyProgramParticpation";
    ((UltraGridBase) this.dgParticipation).DataSource = (object) this.ds;
    ((AppearanceBase) appearance1).FontData.BoldAsString = "False";
    ((AppearanceBase) appearance1).FontData.UnderlineAsString = "True";
    ((SpecialBoxBase) ((UltraGridBase) this.dgParticipation).DisplayLayout.AddNewBox).Appearance = (AppearanceBase) appearance1;
    ((SpecialBoxBase) ((UltraGridBase) this.dgParticipation).DisplayLayout.AddNewBox).Prompt = " ";
    ((UltraGridBase) this.dgParticipation).DisplayLayout.AddNewBox.Style = (AddNewBoxStyle) 1;
    ((AppearanceBase) appearance2).BackColor = Color.White;
    ((AppearanceBase) appearance2).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.dgParticipation).DisplayLayout.Appearance = (AppearanceBase) appearance2;
    ((UltraGridBase) this.dgParticipation).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ((HeaderBase) ultraGridColumn1.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn1.Header).VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn1.Width = 83;
    ((HeaderBase) ultraGridColumn2.Header).Caption = "Company Location";
    ((HeaderBase) ultraGridColumn2.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn2.Header).VisiblePosition = 1;
    ultraGridColumn2.Style = (ColumnStyle) 6;
    ultraGridColumn2.Width = 292;
    ((HeaderBase) ultraGridColumn3.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn3.Header).VisiblePosition = 2;
    ultraGridColumn3.Width = 111;
    ((HeaderBase) ultraGridColumn4.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn4.Header).VisiblePosition = 3;
    ultraGridColumn4.Width = 93;
    ((HeaderBase) ultraGridColumn5.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn5.Header).VisiblePosition = 4;
    ultraGridColumn5.Width = 92;
    ultraGridBand1.Columns.AddRange(new object[5]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3,
      (object) ultraGridColumn4,
      (object) ultraGridColumn5
    });
    summarySettings.DisplayFormat = "{0}";
    ultraGridBand1.Summaries.AddRange(new SummarySettings[1]
    {
      summarySettings
    });
    ultraGridBand1.SummaryFooterCaption = "";
    ((UltraGridBase) this.dgParticipation).DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    ((UltraGridBase) this.dgParticipation).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((AppearanceBase) appearance3).BackColor = Color.LightSteelBlue;
    ((AppearanceBase) appearance3).FontData.SizeInPoints = 10f;
    ((AppearanceBase) appearance3).ForeColor = Color.Black;
    ((UltraGridBase) this.dgParticipation).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance3;
    ((AppearanceBase) appearance4).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance4).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance4).ForeColor = Color.Black;
    ((UltraGridBase) this.dgParticipation).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance4;
    ((UltraGridBase) this.dgParticipation).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.dgParticipation).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 1;
    ((UltraGridBase) this.dgParticipation).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 1;
    ((AppearanceBase) appearance5).BorderColor = Color.LightGray;
    ((UltraGridBase) this.dgParticipation).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance5;
    ((AppearanceBase) appearance6).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.dgParticipation).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance6;
    ((UltraGridBase) this.dgParticipation).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 2;
    ((UltraGridBase) this.dgParticipation).DisplayLayout.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance7).BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.dgParticipation).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance7;
    ((AppearanceBase) appearance8).BorderColor = Color.LightGray;
    ((UltraGridBase) this.dgParticipation).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance8;
    ((UltraGridBase) this.dgParticipation).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance9).BackColor = Color.Transparent;
    ((AppearanceBase) appearance9).ForeColor = Color.Black;
    ((UltraGridBase) this.dgParticipation).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance9;
    ((UltraGridBase) this.dgParticipation).DisplayLayout.Override.SummaryFooterCaptionVisible = (DefaultableBoolean) 2;
    ((Control) this.dgParticipation).Font = new Font("Tahoma", 8.25f);
    ((Control) this.dgParticipation).Location = new Point(12, 12);
    ((Control) this.dgParticipation).Name = "dgParticipation";
    ((Control) this.dgParticipation).Size = new Size(590, 248);
    ((Control) this.dgParticipation).TabIndex = 33;
    ((Control) this.dgParticipation).Text = "Program Codes Participation";
    ((UltraControlBase) this.dgParticipation).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dgParticipation).UseOsThemes = (DefaultableBoolean) 2;
    this.ds.DataSetName = "dsProgCodeExt";
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    ((Control) this.ddCompanyLocations).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    ((UltraGridBase) this.ddCompanyLocations).DataMember = "tblCompanyLocations";
    ((UltraGridBase) this.ddCompanyLocations).DataSource = (object) this.ds;
    ((UltraGridBase) this.ddCompanyLocations).DisplayLayout.AutoFitStyle = (AutoFitStyle) 2;
    ((HeaderBase) ultraGridColumn6.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn6.Header).VisiblePosition = 0;
    ultraGridColumn6.Hidden = true;
    ((HeaderBase) ultraGridColumn7.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn7.Header).VisiblePosition = 1;
    ultraGridBand2.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn6,
      (object) ultraGridColumn7
    });
    ((UltraGridBase) this.ddCompanyLocations).DisplayLayout.BandsSerializer.Add((object) ultraGridBand2);
    ((UltraDropDownBase) this.ddCompanyLocations).DisplayMember = "LocationName";
    ((UltraDropDownBase) this.ddCompanyLocations).DropDownWidth = 400;
    ((Control) this.ddCompanyLocations).Location = new Point(244, 107);
    ((Control) this.ddCompanyLocations).Name = "ddCompanyLocations";
    ((Control) this.ddCompanyLocations).Size = new Size(129, 82);
    ((Control) this.ddCompanyLocations).TabIndex = 223;
    ((Control) this.ddCompanyLocations).Text = "UltraDropDown2";
    ((UltraDropDownBase) this.ddCompanyLocations).ValueMember = "CompanyLocationID";
    ((Control) this.ddCompanyLocations).Visible = false;
    this.grpDetails.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.grpDetails.Controls.Add((Control) this.label4);
    this.grpDetails.Controls.Add((Control) this.cboCompanyLocation);
    this.grpDetails.Controls.Add((Control) this.numShare);
    this.grpDetails.Controls.Add((Control) this.label3);
    this.grpDetails.Controls.Add((Control) this.label1);
    this.grpDetails.Controls.Add((Control) this.dtEndDate);
    this.grpDetails.Controls.Add((Control) this.label2);
    this.grpDetails.Controls.Add((Control) this.dtStartDate);
    this.grpDetails.Location = new Point(12, 266);
    this.grpDetails.Name = "grpDetails";
    this.grpDetails.Size = new Size(590, 134);
    this.grpDetails.TabIndex = 224 /*0xE0*/;
    this.grpDetails.TabStop = false;
    this.grpDetails.Text = "Participation Details";
    this.label4.AutoSize = true;
    this.label4.Location = new Point(63 /*0x3F*/, 109);
    this.label4.Name = "label4";
    this.label4.Size = new Size(38, 13);
    this.label4.TabIndex = 38;
    this.label4.Text = "Share:";
    this.cboCompanyLocation.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.cboCompanyLocation).DataBindings.Add(new Binding("Value", (object) this.ds, "Fortegra_tblCompanyProgramParticpation.CompanyLocationID", true));
    ((UltraGridBase) this.cboCompanyLocation).DataMember = "tblCompanyLocations";
    ((UltraGridBase) this.cboCompanyLocation).DataSource = (object) this.ds;
    ((UltraDropDownBase) this.cboCompanyLocation).DisplayMember = "LocationName";
    this.cboCompanyLocation.DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboCompanyLocation).DropDownWidth = 400;
    ((Control) this.cboCompanyLocation).Location = new Point(113, 15);
    this.cboCompanyLocation.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboCompanyLocation).Name = "cboCompanyLocation";
    ((Control) this.cboCompanyLocation).Size = new Size(398, 20);
    ((Control) this.cboCompanyLocation).TabIndex = 0;
    ((UltraControlBase) this.cboCompanyLocation).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboCompanyLocation).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboCompanyLocation).ValueMember = "CompanyLocationID";
    ((AppearanceBase) appearance10).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.numShare).Appearance = (AppearanceBase) appearance10;
    ((Control) this.numShare).DataBindings.Add(new Binding("Value", (object) this.ds, "Fortegra_tblCompanyProgramParticpation.Share", true));
    ((UltraNumericEditorBase) this.numShare).FormatString = "";
    ((Control) this.numShare).Location = new Point(113, 106);
    ((UltraNumericEditorBase) this.numShare).MaskInput = "nnn.nnnnnnn";
    this.numShare.MGAStyle = MGAStyles.Blue;
    ((Control) this.numShare).Name = "numShare";
    this.numShare.Nullable = true;
    this.numShare.NumericType = (NumericType) 2;
    ((Control) this.numShare).Size = new Size(80 /*0x50*/, 19);
    ((Control) this.numShare).TabIndex = 3;
    ((UltraWinEditorMaskedControlBase) this.numShare).TabNavigation = (MaskedEditTabNavigation) 0;
    ((UltraControlBase) this.numShare).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.numShare).UseOsThemes = (DefaultableBoolean) 2;
    this.label3.AutoSize = true;
    this.label3.Location = new Point(46, 79);
    this.label3.Name = "label3";
    this.label3.Size = new Size(55, 13);
    this.label3.TabIndex = 37;
    this.label3.Text = "End Date:";
    this.label1.AutoSize = true;
    this.label1.Location = new Point(3, 19);
    this.label1.Name = "label1";
    this.label1.Size = new Size(98, 13);
    this.label1.TabIndex = 34;
    this.label1.Text = "Company Location:";
    ((AppearanceBase) appearance11).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.dtEndDate.Appearance = (AppearanceBase) appearance11;
    ((AppearanceBase) appearance12).AlphaLevel = (short) 14;
    ((AppearanceBase) appearance12).BackColor = Color.FromArgb(0, 0, 246, 253);
    ((AppearanceBase) appearance12).BackColor2 = Color.FromArgb(133, 162, 221);
    ((AppearanceBase) appearance12).BackColorAlpha = (Alpha) 2;
    ((AppearanceBase) appearance12).BackGradientAlignment = (GradientAlignment) 4;
    ((AppearanceBase) appearance12).BackGradientStyle = (GradientStyle) 5;
    ((AppearanceBase) appearance12).BorderAlpha = (Alpha) 1;
    ((AppearanceBase) appearance12).BorderColor = Color.FromArgb(78, 122, 171);
    ((AppearanceBase) appearance12).ForeColor = Color.FromArgb(49, 85, 153);
    ((AppearanceBase) appearance12).ForegroundAlpha = (Alpha) 2;
    this.dtEndDate.ButtonAppearance = (AppearanceBase) appearance12;
    ((Control) this.dtEndDate).DataBindings.Add(new Binding("Value", (object) this.ds, "Fortegra_tblCompanyProgramParticpation.EndDate", true));
    this.dtEndDate.DateTime = new DateTime(2013, 7, 15, 0, 0, 0, 0);
    ((Control) this.dtEndDate).Location = new Point(113, 76);
    this.dtEndDate.MGAStyle = MGAStyles.Blue;
    ((Control) this.dtEndDate).Name = "dtEndDate";
    this.dtEndDate.Nullable = false;
    ((Control) this.dtEndDate).Size = new Size(99, 19);
    ((Control) this.dtEndDate).TabIndex = 2;
    ((UltraControlBase) this.dtEndDate).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dtEndDate).UseOsThemes = (DefaultableBoolean) 2;
    this.dtEndDate.Value = (object) new DateTime(2013, 7, 15, 0, 0, 0, 0);
    this.label2.AutoSize = true;
    this.label2.Location = new Point(43, 49);
    this.label2.Name = "label2";
    this.label2.Size = new Size(58, 13);
    this.label2.TabIndex = 36;
    this.label2.Text = "Start Date:";
    ((AppearanceBase) appearance13).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.dtStartDate.Appearance = (AppearanceBase) appearance13;
    ((AppearanceBase) appearance14).AlphaLevel = (short) 14;
    ((AppearanceBase) appearance14).BackColor = Color.FromArgb(0, 0, 246, 253);
    ((AppearanceBase) appearance14).BackColor2 = Color.FromArgb(133, 162, 221);
    ((AppearanceBase) appearance14).BackColorAlpha = (Alpha) 2;
    ((AppearanceBase) appearance14).BackGradientAlignment = (GradientAlignment) 4;
    ((AppearanceBase) appearance14).BackGradientStyle = (GradientStyle) 5;
    ((AppearanceBase) appearance14).BorderAlpha = (Alpha) 1;
    ((AppearanceBase) appearance14).BorderColor = Color.FromArgb(78, 122, 171);
    ((AppearanceBase) appearance14).ForeColor = Color.FromArgb(49, 85, 153);
    ((AppearanceBase) appearance14).ForegroundAlpha = (Alpha) 2;
    this.dtStartDate.ButtonAppearance = (AppearanceBase) appearance14;
    ((Control) this.dtStartDate).DataBindings.Add(new Binding("Value", (object) this.ds, "Fortegra_tblCompanyProgramParticpation.StartDate", true));
    this.dtStartDate.DateTime = new DateTime(2013, 7, 15, 0, 0, 0, 0);
    ((Control) this.dtStartDate).Location = new Point(113, 46);
    this.dtStartDate.MGAStyle = MGAStyles.Blue;
    ((Control) this.dtStartDate).Name = "dtStartDate";
    ((Control) this.dtStartDate).Size = new Size(99, 19);
    ((Control) this.dtStartDate).TabIndex = 1;
    ((UltraControlBase) this.dtStartDate).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dtStartDate).UseOsThemes = (DefaultableBoolean) 2;
    this.dtStartDate.Value = (object) new DateTime(2013, 7, 15, 0, 0, 0, 0);
    this.dbSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.dbSave.AutoQueryRowCountOnLoad = false;
    this.dbSave.EditStyle = EditStyle.ShowEditButton;
    this.dbSave.FreezeEvents = false;
    this.dbSave.Location = new Point(490, 419);
    this.dbSave.Name = "dbSave";
    this.dbSave.Size = new Size(112 /*0x70*/, 40);
    this.dbSave.TabIndex = 225;
    this.dbSave.ClickingNew += new CancelEventHandler(this.dbSave_ClickingNew);
    this.dbSave.ClickingSave += new CancelEventHandler(this.dbSave_ClickingSave);
    this.dbSave.ClickedSave += new EventHandler(this.dbSave_ClickedSave);
    this.dbSave.ClickingDelete += new CancelEventHandler(this.dbSave_ClickingDelete);
    this.dbSave.ClickedCancel += new EventHandler(this.dbSave_ClickedCancel);
    this.dbSave.ClickingEdit += new CancelEventHandler(this.dbSave_ClickingEdit);
    this.da.DeleteCommand = this.SqlDeleteCommand1;
    this.da.InsertCommand = this.SqlInsertCommand1;
    this.da.SelectCommand = this.SqlSelectCommand1;
    this.da.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "Fortegra_tblCompanyProgramParticpation", new DataColumnMapping[5]
      {
        new DataColumnMapping("ProgramID", "ProgramID"),
        new DataColumnMapping("CompanyLocationID", "CompanyLocationID"),
        new DataColumnMapping("Share", "Share"),
        new DataColumnMapping("StartDate", "StartDate"),
        new DataColumnMapping("EndDate", "EndDate")
      })
    });
    this.da.UpdateCommand = this.SqlUpdateCommand1;
    this.SqlDeleteCommand1.CommandText = "DELETE FROM [Fortegra_tblCompanyProgramParticpation] WHERE (([ProgramID] = @Original_ProgramID) AND ([CompanyLocationID] = @Original_CompanyLocationID) AND ([StartDate] = @Original_StartDate))";
    this.SqlDeleteCommand1.Parameters.AddRange(new SqlParameter[3]
    {
      new SqlParameter("@Original_ProgramID", SqlDbType.Int, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "ProgramID", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_CompanyLocationID", SqlDbType.Int, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "CompanyLocationID", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_StartDate", SqlDbType.Date, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "StartDate", DataRowVersion.Original, (object) null)
    });
    this.SqlInsertCommand1.CommandText = componentResourceManager.GetString("SqlInsertCommand1.CommandText");
    this.SqlInsertCommand1.Parameters.AddRange(new SqlParameter[5]
    {
      new SqlParameter("@ProgramID", SqlDbType.Int, 0, "ProgramID"),
      new SqlParameter("@CompanyLocationID", SqlDbType.Int, 0, "CompanyLocationID"),
      new SqlParameter("@Share", SqlDbType.Decimal, 0, ParameterDirection.Input, false, (byte) 11, (byte) 7, "Share", DataRowVersion.Current, (object) null),
      new SqlParameter("@StartDate", SqlDbType.Date, 0, "StartDate"),
      new SqlParameter("@EndDate", SqlDbType.Date, 0, "EndDate")
    });
    this.SqlSelectCommand1.CommandText = "SELECT      ProgramID, CompanyLocationID, Share, StartDate, EndDate\r\nFROM         Fortegra_tblCompanyProgramParticpation\r\nWHERE      (ProgramID = @ProgramID)";
    this.SqlSelectCommand1.Parameters.AddRange(new SqlParameter[1]
    {
      new SqlParameter("@ProgramID", SqlDbType.Int, 4, "ProgramID")
    });
    this.SqlUpdateCommand1.CommandText = componentResourceManager.GetString("SqlUpdateCommand1.CommandText");
    this.SqlUpdateCommand1.Parameters.AddRange(new SqlParameter[8]
    {
      new SqlParameter("@ProgramID", SqlDbType.Int, 0, "ProgramID"),
      new SqlParameter("@CompanyLocationID", SqlDbType.Int, 0, "CompanyLocationID"),
      new SqlParameter("@Share", SqlDbType.Decimal, 0, ParameterDirection.Input, false, (byte) 11, (byte) 7, "Share", DataRowVersion.Current, (object) null),
      new SqlParameter("@StartDate", SqlDbType.Date, 0, "StartDate"),
      new SqlParameter("@EndDate", SqlDbType.Date, 0, "EndDate"),
      new SqlParameter("@Original_ProgramID", SqlDbType.Int, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "ProgramID", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_CompanyLocationID", SqlDbType.Int, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "CompanyLocationID", DataRowVersion.Original, (object) null),
      new SqlParameter("@Original_StartDate", SqlDbType.Date, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "StartDate", DataRowVersion.Original, (object) null)
    });
    this.err.ContainerControl = (ContainerControl) this;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    this.ClientSize = new Size(614, 471);
    this.Controls.Add((Control) this.dbSave);
    this.Controls.Add((Control) this.grpDetails);
    this.Controls.Add((Control) this.ddCompanyLocations);
    this.Controls.Add((Control) this.dgParticipation);
    this.Name = nameof (FormProgramCodeParticipation);
    this.Text = nameof (FormProgramCodeParticipation);
    this.Load += new EventHandler(this.FormProgramCodeParticipation_Load);
    ((ISupportInitialize) this.dgParticipation).EndInit();
    this.ds.EndInit();
    ((ISupportInitialize) this.ddCompanyLocations).EndInit();
    this.grpDetails.ResumeLayout(false);
    this.grpDetails.PerformLayout();
    ((ISupportInitialize) this.cboCompanyLocation).EndInit();
    ((ISupportInitialize) this.numShare).EndInit();
    ((ISupportInitialize) this.dtEndDate).EndInit();
    ((ISupportInitialize) this.dtStartDate).EndInit();
    ((ISupportInitialize) this.err).EndInit();
    this.ResumeLayout(false);
  }
}
