// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.FormSLStateRules
// Assembly: MgaSystems.IMS.Policies, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 2FF2C709-F7BF-41DA-82BD-FF6319CA235D
// Assembly location: C:\Users\muthu\Downloads\MgaSystems.IMS.Policies.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using Infragistics.Win.UltraWinTabControl;
using Infragistics.Win.UltraWinTabs;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.Tools;
using MGASystems.Tools.DBSaveUI;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Policies;

[DesignerGenerated]
[SecureResource("{28A8E319-226F-458d-A843-418A814E6761}", "Access Filing Automation Screen", "Controls access to Filing Automation.", "Policies")]
public class FormSLStateRules : Form
{
  private IContainer components;
  private Label Label3;
  private dsStateSLRules ds;
  private UltraTabControl UltraTabControl1;
  private UltraTabSharedControlsPage UltraTabSharedControlsPage1;
  private UltraTabPageControl UltraTabPageControl1;
  private UltraTabPageControl UltraTabPageControl2;
  private UltraTabPageControl tabDescription;
  private UltraTabPageControl UltraTabPageControl4;
  private UltraGroupBox grpFileTracking;
  private UltraTabPageControl UltraTabPageControl3;
  private Label Label1;
  private UltraTabPageControl UltraTabPageControl5;
  private UltraGroupBox UltraGroupBox3;
  private UltraPictureBox picBox;
  private OpenFileDialog fileDialog;
  private DbConnection _cn;
  public const string canViewFilingAutomationForm = "{28A8E319-226F-458d-A843-418A814E6761}";

  public FormSLStateRules()
  {
    this.Load += new EventHandler(this.FormSLStateRules_Load);
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (FormSLStateRules));
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    UltraGridBand ultraGridBand1 = new UltraGridBand("tblStatesSLRequiredData", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("StateID");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("RequiredDataID", -1, (object) "ddRequiredData");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("UseForFiling");
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    Appearance appearance11 = new Appearance();
    Appearance appearance12 = new Appearance();
    ScrollBarLook scrollBarLook1 = new ScrollBarLook();
    Appearance appearance13 = new Appearance();
    Appearance appearance14 = new Appearance();
    Appearance appearance15 = new Appearance();
    Appearance appearance16 = new Appearance();
    Appearance appearance17 = new Appearance();
    UltraGridBand ultraGridBand2 = new UltraGridBand("tblSLStateRulesForms", -1);
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("StateID");
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("TemplateID", -1, (object) "ddTemplates");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("UseOnBinder");
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("UserOnQuote");
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("InsuredSigns");
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("ProducerSigns");
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("UseOnIssuance");
    Appearance appearance18 = new Appearance();
    Appearance appearance19 = new Appearance();
    Appearance appearance20 = new Appearance();
    Appearance appearance21 = new Appearance();
    Appearance appearance22 = new Appearance();
    Appearance appearance23 = new Appearance();
    Appearance appearance24 = new Appearance();
    ScrollBarLook scrollBarLook2 = new ScrollBarLook();
    Appearance appearance25 = new Appearance();
    Appearance appearance26 = new Appearance();
    Appearance appearance27 = new Appearance();
    Appearance appearance28 = new Appearance();
    Appearance appearance29 = new Appearance();
    UltraTab ultraTab1 = new UltraTab();
    Appearance appearance30 = new Appearance();
    UltraTab ultraTab2 = new UltraTab();
    Appearance appearance31 = new Appearance();
    UltraTab ultraTab3 = new UltraTab();
    Appearance appearance32 = new Appearance();
    UltraTab ultraTab4 = new UltraTab();
    Appearance appearance33 = new Appearance();
    UltraTab ultraTab5 = new UltraTab();
    Appearance appearance34 = new Appearance();
    UltraTab ultraTab6 = new UltraTab();
    Appearance appearance35 = new Appearance();
    Appearance appearance36 = new Appearance();
    Appearance appearance37 = new Appearance();
    Appearance appearance38 = new Appearance();
    Appearance appearance39 = new Appearance();
    UltraGridBand ultraGridBand3 = new UltraGridBand("tblDocumentTemplates", -1);
    UltraGridColumn ultraGridColumn11 = new UltraGridColumn("TemplateID");
    UltraGridColumn ultraGridColumn12 = new UltraGridColumn("TemplateName");
    UltraGridColumn ultraGridColumn13 = new UltraGridColumn("tblDocumentTemplates_tblSLStateRulesForms");
    UltraGridBand ultraGridBand4 = new UltraGridBand("tblDocumentTemplates_tblSLStateRulesForms", 0);
    UltraGridColumn ultraGridColumn14 = new UltraGridColumn("StateID");
    UltraGridColumn ultraGridColumn15 = new UltraGridColumn("TemplateID");
    UltraGridColumn ultraGridColumn16 = new UltraGridColumn("UseOnBinder");
    UltraGridColumn ultraGridColumn17 = new UltraGridColumn("UserOnQuote");
    UltraGridColumn ultraGridColumn18 = new UltraGridColumn("InsuredSigns");
    UltraGridColumn ultraGridColumn19 = new UltraGridColumn("ProducerSigns");
    UltraGridColumn ultraGridColumn20 = new UltraGridColumn("UseOnIssuance");
    UltraGridBand ultraGridBand5 = new UltraGridBand("lstStateSLRequiredData", -1);
    UltraGridColumn ultraGridColumn21 = new UltraGridColumn("ID");
    UltraGridColumn ultraGridColumn22 = new UltraGridColumn("RequiredData");
    UltraGridColumn ultraGridColumn23 = new UltraGridColumn("lstStateSLRequiredData_tblStatesSLRequiredData1");
    UltraGridBand ultraGridBand6 = new UltraGridBand("lstStateSLRequiredData_tblStatesSLRequiredData1", 0);
    UltraGridColumn ultraGridColumn24 = new UltraGridColumn("StateID");
    UltraGridColumn ultraGridColumn25 = new UltraGridColumn("RequiredDataID");
    UltraGridColumn ultraGridColumn26 = new UltraGridColumn("UseForFiling");
    this.txtDescription = new RichTextBox();
    this.txtOtherInfo = new RichTextBox();
    this.UltraTabPageControl1 = new UltraTabPageControl();
    this.ugRequiredData = new UltraGrid();
    this.ds = new dsStateSLRules();
    this.UltraTabPageControl2 = new UltraTabPageControl();
    this.ugForms = new UltraGrid();
    this.tabDescription = new UltraTabPageControl();
    this.UltraTabPageControl4 = new UltraTabPageControl();
    this.UltraTabPageControl3 = new UltraTabPageControl();
    this.editorCtrlComments = new RichTextBox();
    this.UltraTabPageControl5 = new UltraTabPageControl();
    this.lnkClearImage = new LinkLabel();
    this.lnkLoadImage = new LinkLabel();
    this.UltraGroupBox3 = new UltraGroupBox();
    this.picBox = new UltraPictureBox();
    this.Label3 = new Label();
    this.chkNotAllowPremiumAllocation = new MGACheckBox();
    this.chkUseCorpLic = new MGACheckBox();
    this.chkFilingReqZeroPremium = new MGACheckBox();
    this.daStateSLRules = DefaultDatabase.CreateDataAdapter();
    this.DbDeleteCommand1 = DefaultDatabase.CreateCommand();
    this.DbInsertCommand1 = DefaultDatabase.CreateCommand();
    this.UltraTabControl1 = new UltraTabControl();
    this.UltraTabSharedControlsPage1 = new UltraTabSharedControlsPage();
    this.daStateRulesTemplates = DefaultDatabase.CreateDataAdapter();
    this.DbCommand1 = DefaultDatabase.CreateCommand();
    this.DbCommand2 = DefaultDatabase.CreateCommand();
    this.DbCommand3 = DefaultDatabase.CreateCommand();
    this.DbCommand4 = DefaultDatabase.CreateCommand();
    this.daRequiredData = DefaultDatabase.CreateDataAdapter();
    this.DbCommand5 = DefaultDatabase.CreateCommand();
    this.DbCommand6 = DefaultDatabase.CreateCommand();
    this.DbCommand8 = DefaultDatabase.CreateCommand();
    this.rbRetain = new RadioButton();
    this.rbOnline = new RadioButton();
    this.rbMail = new RadioButton();
    this.dbSave = new MGASystems.Tools.DBSaveUI.DBSaveUI();
    this.grpFileTracking = new UltraGroupBox();
    this.btnPrevious = new MGAButton();
    this.btnNext = new MGAButton();
    this.Label1 = new Label();
    this.fileDialog = new OpenFileDialog();
    this.chkExportList = new MGACheckBox();
    this.chkWhiteList = new MGACheckBox();
    this.cboDocumentFolder = new MGASimpleComboBox();
    this.ddTemplates = new UltraDropDown();
    this.ddRequiredData = new UltraDropDown();
    this.cboState = new MGASimpleComboBox();
    DbCommand command1 = DefaultDatabase.CreateCommand();
    DbCommand command2 = DefaultDatabase.CreateCommand();
    UltraGroupBox ultraGroupBox1 = new UltraGroupBox();
    UltraGroupBox ultraGroupBox2 = new UltraGroupBox();
    DbCommand command3 = DefaultDatabase.CreateCommand();
    ((ISupportInitialize) ultraGroupBox1).BeginInit();
    ((Control) ultraGroupBox1).SuspendLayout();
    ((ISupportInitialize) ultraGroupBox2).BeginInit();
    ((Control) ultraGroupBox2).SuspendLayout();
    ((Control) this.UltraTabPageControl1).SuspendLayout();
    ((ISupportInitialize) this.ugRequiredData).BeginInit();
    this.ds.BeginInit();
    ((Control) this.UltraTabPageControl2).SuspendLayout();
    ((ISupportInitialize) this.ugForms).BeginInit();
    ((Control) this.tabDescription).SuspendLayout();
    ((Control) this.UltraTabPageControl4).SuspendLayout();
    ((Control) this.UltraTabPageControl3).SuspendLayout();
    ((Control) this.UltraTabPageControl5).SuspendLayout();
    ((ISupportInitialize) this.UltraGroupBox3).BeginInit();
    ((Control) this.UltraGroupBox3).SuspendLayout();
    ((ISupportInitialize) this.chkNotAllowPremiumAllocation).BeginInit();
    ((ISupportInitialize) this.chkUseCorpLic).BeginInit();
    ((ISupportInitialize) this.chkFilingReqZeroPremium).BeginInit();
    ((ISupportInitialize) this.UltraTabControl1).BeginInit();
    ((Control) this.UltraTabControl1).SuspendLayout();
    ((ISupportInitialize) this.grpFileTracking).BeginInit();
    ((Control) this.grpFileTracking).SuspendLayout();
    ((ISupportInitialize) this.btnPrevious).BeginInit();
    ((ISupportInitialize) this.btnNext).BeginInit();
    ((ISupportInitialize) this.chkExportList).BeginInit();
    ((ISupportInitialize) this.chkWhiteList).BeginInit();
    ((ISupportInitialize) this.cboDocumentFolder).BeginInit();
    ((ISupportInitialize) this.ddTemplates).BeginInit();
    ((ISupportInitialize) this.ddRequiredData).BeginInit();
    ((ISupportInitialize) this.cboState).BeginInit();
    this.SuspendLayout();
    command1.CommandText = componentResourceManager.GetString("DbSelectCommand2.CommandText");
    command1.Parameters.AddRange((Array) new DbParameter[1]
    {
      DefaultDatabase.CreateParameter("@StateID", SqlDbType.Char, 2, "StateID")
    });
    command2.CommandText = componentResourceManager.GetString("DbUpdateCommand1.CommandText");
    command2.Parameters.AddRange((Array) new DbParameter[16 /*0x10*/]
    {
      DefaultDatabase.CreateParameter("@StateID", SqlDbType.Char, 0, "StateID"),
      DefaultDatabase.CreateParameter("@OtherInfo", SqlDbType.VarChar, 0, "OtherInfo"),
      DefaultDatabase.CreateParameter("@NoAllowPremiumAllocation", SqlDbType.Bit, 0, "NoAllowPremiumAllocation"),
      DefaultDatabase.CreateParameter("@FilingRequiredForZeroPremium", SqlDbType.Bit, 0, "FilingRequiredForZeroPremium"),
      DefaultDatabase.CreateParameter("@UseCorporateLic", SqlDbType.Bit, 0, "UseCorporateLic"),
      DefaultDatabase.CreateParameter("@Description", SqlDbType.VarChar, 0, "Description"),
      DefaultDatabase.CreateParameter("@Mail", SqlDbType.Bit, 0, "Mail"),
      DefaultDatabase.CreateParameter("@Online", SqlDbType.Bit, 0, "Online"),
      DefaultDatabase.CreateParameter("@Retain", SqlDbType.Bit, 0, "Retain"),
      DefaultDatabase.CreateParameter("@Comments", SqlDbType.Text, 0, "Comments"),
      DefaultDatabase.CreateParameter("@FolderID", SqlDbType.Int, 0, "FolderID"),
      DefaultDatabase.CreateParameter("@SLImageData", SqlDbType.Image, 0, "SLImageData"),
      DefaultDatabase.CreateParameter("@StatePubWhiteList", SqlDbType.Bit, 0, "StatePubWhiteList"),
      DefaultDatabase.CreateParameter("@StatePubExportList", SqlDbType.Bit, 0, "StatePubExportList"),
      DefaultDatabase.CreateParameter("@Original_ID", SqlDbType.Int, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "ID", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@ID", SqlDbType.Int, 4, "ID")
    });
    appearance1.BackColor = Color.White;
    appearance1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ultraGroupBox1.ContentAreaAppearance = (AppearanceBase) appearance1;
    ((Control) ultraGroupBox1).Controls.Add((Control) this.txtDescription);
    ((Control) ultraGroupBox1).Location = new Point(3, 3);
    ((Control) ultraGroupBox1).Name = "UltraGroupBox1";
    ((Control) ultraGroupBox1).Size = new Size(752, 432);
    ((Control) ultraGroupBox1).TabIndex = 6;
    this.txtDescription.AcceptsTab = true;
    this.txtDescription.BackColor = Color.White;
    this.txtDescription.BorderStyle = BorderStyle.None;
    this.txtDescription.Font = new Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.txtDescription.ForeColor = Color.Black;
    this.txtDescription.Location = new Point(6, 3);
    this.txtDescription.MaxLength = 6000;
    this.txtDescription.Name = "txtDescription";
    this.txtDescription.Size = new Size(663, 344);
    this.txtDescription.TabIndex = 5;
    this.txtDescription.Text = "";
    appearance2.BackColor = Color.White;
    appearance2.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ultraGroupBox2.ContentAreaAppearance = (AppearanceBase) appearance2;
    ((Control) ultraGroupBox2).Controls.Add((Control) this.txtOtherInfo);
    ((Control) ultraGroupBox2).Location = new Point(3, 3);
    ((Control) ultraGroupBox2).Name = "UltraGroupBox2";
    ((Control) ultraGroupBox2).Size = new Size(752, 438);
    ((Control) ultraGroupBox2).TabIndex = 7;
    this.txtOtherInfo.AcceptsTab = true;
    this.txtOtherInfo.BackColor = Color.White;
    this.txtOtherInfo.BorderStyle = BorderStyle.None;
    this.txtOtherInfo.Font = new Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.txtOtherInfo.ForeColor = Color.Black;
    this.txtOtherInfo.Location = new Point(6, 3);
    this.txtOtherInfo.MaxLength = 6000;
    this.txtOtherInfo.Name = "txtOtherInfo";
    this.txtOtherInfo.Size = new Size(663, 344);
    this.txtOtherInfo.TabIndex = 5;
    this.txtOtherInfo.Text = "";
    command3.CommandText = "SELECT     StateID, RequiredDataID, UseForFiling\r\nFROM         dbo.tblStatesSLRequiredData\r\nWHERE     (StateID = @StateID)";
    command3.Parameters.AddRange((Array) new DbParameter[1]
    {
      DefaultDatabase.CreateParameter("@StateID", SqlDbType.Char, 2, "StateID")
    });
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.ugRequiredData);
    ((Control) this.UltraTabPageControl1).Location = new Point(1, 26);
    ((Control) this.UltraTabPageControl1).Name = "UltraTabPageControl1";
    ((Control) this.UltraTabPageControl1).Size = new Size(675, 353);
    ((UltraGridBase) this.ugRequiredData).DataMember = "tblStatesSLRequiredData";
    ((UltraGridBase) this.ugRequiredData).DataSource = (object) this.ds;
    appearance3.BackColor = Color.White;
    appearance3.BackColor2 = Color.Gainsboro;
    appearance3.BackGradientStyle = (GradientStyle) 2;
    appearance3.FontData.Name = "Tahoma";
    appearance3.FontData.SizeInPoints = 8.25f;
    ((SpecialBoxBase) ((UltraGridBase) this.ugRequiredData).DisplayLayout.AddNewBox).Appearance = (AppearanceBase) appearance3;
    appearance4.BackColor = Color.Transparent;
    appearance4.BorderColor = Color.Transparent;
    appearance4.ForeColor = Color.Navy;
    ((UltraGridBase) this.ugRequiredData).DisplayLayout.AddNewBox.ButtonAppearance = (AppearanceBase) appearance4;
    ((SpecialBoxBase) ((UltraGridBase) this.ugRequiredData).DisplayLayout.AddNewBox).Hidden = false;
    ((SpecialBoxBase) ((UltraGridBase) this.ugRequiredData).DisplayLayout.AddNewBox).Prompt = " ";
    ((UltraGridBase) this.ugRequiredData).DisplayLayout.AddNewBox.Style = (AddNewBoxStyle) 1;
    appearance5.BackColor = Color.White;
    appearance5.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.ugRequiredData).DisplayLayout.Appearance = (AppearanceBase) appearance5;
    ((UltraGridBase) this.ugRequiredData).DisplayLayout.AutoFitStyle = (AutoFitStyle) 2;
    ultraGridBand1.AddButtonCaption = "Click here to add additional required data ...";
    ultraGridColumn1.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn2.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn2.Header).Caption = "Required Data";
    ultraGridColumn2.Header.VisiblePosition = 1;
    ultraGridColumn2.Style = (ColumnStyle) 6;
    ultraGridColumn2.Width = 516;
    ultraGridColumn3.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn3.DefaultCellValue = (object) "False";
    ((HeaderBase) ultraGridColumn3.Header).Caption = "Use For Filing";
    ultraGridColumn3.Header.VisiblePosition = 2;
    ultraGridBand1.Columns.AddRange(new object[3]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3
    });
    ((UltraGridBase) this.ugRequiredData).DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    ((UltraGridBase) this.ugRequiredData).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance6.BackColor = Color.LightSteelBlue;
    appearance6.FontData.SizeInPoints = 10f;
    appearance6.ForeColor = Color.Black;
    ((UltraGridBase) this.ugRequiredData).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance6;
    appearance7.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance7.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance7.ForeColor = Color.Black;
    ((UltraGridBase) this.ugRequiredData).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance7;
    ((UltraGridBase) this.ugRequiredData).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    appearance8.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugRequiredData).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance8;
    appearance9.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.ugRequiredData).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance9;
    ((UltraGridBase) this.ugRequiredData).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance10.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.ugRequiredData).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance10;
    appearance11.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugRequiredData).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance11;
    ((UltraGridBase) this.ugRequiredData).DisplayLayout.Override.RowSelectorStyle = (HeaderStyle) 2;
    appearance12.BackColor = Color.Transparent;
    appearance12.ForeColor = Color.Black;
    ((UltraGridBase) this.ugRequiredData).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance12;
    appearance13.BackColor = Color.WhiteSmoke;
    appearance13.BorderColor = Color.Silver;
    scrollBarLook1.ButtonAppearance = (AppearanceBase) appearance13;
    appearance14.BackColor = Color.White;
    scrollBarLook1.TrackAppearance = (AppearanceBase) appearance14;
    ((UltraGridBase) this.ugRequiredData).DisplayLayout.ScrollBarLook = scrollBarLook1;
    ((Control) this.ugRequiredData).Dock = DockStyle.Left;
    ((Control) this.ugRequiredData).Location = new Point(0, 0);
    ((Control) this.ugRequiredData).Name = "ugRequiredData";
    ((Control) this.ugRequiredData).Size = new Size(672, 353);
    ((Control) this.ugRequiredData).TabIndex = 29;
    ((UltraControlBase) this.ugRequiredData).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.ugRequiredData).UseOsThemes = (DefaultableBoolean) 2;
    this.ds.DataSetName = "dsStateSLRules";
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.ugForms);
    ((Control) this.UltraTabPageControl2).Location = new Point(-10000, -10000);
    ((Control) this.UltraTabPageControl2).Name = "UltraTabPageControl2";
    ((Control) this.UltraTabPageControl2).Size = new Size(675, 353);
    ((UltraGridBase) this.ugForms).DataMember = "tblSLStateRulesForms";
    ((UltraGridBase) this.ugForms).DataSource = (object) this.ds;
    appearance15.BackColor = Color.White;
    appearance15.BackColor2 = Color.Gainsboro;
    appearance15.BackGradientStyle = (GradientStyle) 2;
    appearance15.FontData.Name = "Tahoma";
    appearance15.FontData.SizeInPoints = 8.25f;
    ((SpecialBoxBase) ((UltraGridBase) this.ugForms).DisplayLayout.AddNewBox).Appearance = (AppearanceBase) appearance15;
    appearance16.BackColor = Color.Transparent;
    appearance16.BorderColor = Color.Transparent;
    appearance16.ForeColor = Color.Navy;
    ((UltraGridBase) this.ugForms).DisplayLayout.AddNewBox.ButtonAppearance = (AppearanceBase) appearance16;
    ((SpecialBoxBase) ((UltraGridBase) this.ugForms).DisplayLayout.AddNewBox).Hidden = false;
    ((SpecialBoxBase) ((UltraGridBase) this.ugForms).DisplayLayout.AddNewBox).Prompt = " ";
    ((UltraGridBase) this.ugForms).DisplayLayout.AddNewBox.Style = (AddNewBoxStyle) 1;
    appearance17.BackColor = Color.White;
    appearance17.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.ugForms).DisplayLayout.Appearance = (AppearanceBase) appearance17;
    ((UltraGridBase) this.ugForms).DisplayLayout.AutoFitStyle = (AutoFitStyle) 2;
    ultraGridBand2.AddButtonCaption = "Click here to add a new template setup ...";
    ultraGridColumn4.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn4.Header.VisiblePosition = 0;
    ultraGridColumn4.Hidden = true;
    ultraGridColumn5.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn5.Header).Caption = "Template";
    ultraGridColumn5.Header.VisiblePosition = 1;
    ultraGridColumn5.Style = (ColumnStyle) 6;
    ultraGridColumn5.Width = 340;
    ultraGridColumn6.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn6.Header).Caption = "Binder";
    ultraGridColumn6.Header.VisiblePosition = 2;
    ultraGridColumn6.Width = 45;
    ultraGridColumn7.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn7.Header).Caption = "Quote";
    ultraGridColumn7.Header.VisiblePosition = 3;
    ultraGridColumn7.Width = 45;
    ultraGridColumn8.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn8.Header).Caption = "Insured Signs";
    ultraGridColumn8.Header.VisiblePosition = 5;
    ultraGridColumn8.Width = 75;
    ultraGridColumn9.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn9.Header).Caption = "Producer Signs";
    ultraGridColumn9.Header.VisiblePosition = 6;
    ultraGridColumn9.Width = 85;
    ((HeaderBase) ultraGridColumn10.Header).Caption = "Issuance";
    ultraGridColumn10.Header.VisiblePosition = 4;
    ultraGridBand2.Columns.AddRange(new object[7]
    {
      (object) ultraGridColumn4,
      (object) ultraGridColumn5,
      (object) ultraGridColumn6,
      (object) ultraGridColumn7,
      (object) ultraGridColumn8,
      (object) ultraGridColumn9,
      (object) ultraGridColumn10
    });
    ((UltraGridBase) this.ugForms).DisplayLayout.BandsSerializer.Add((object) ultraGridBand2);
    ((UltraGridBase) this.ugForms).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance18.BackColor = Color.LightSteelBlue;
    appearance18.FontData.SizeInPoints = 10f;
    appearance18.ForeColor = Color.Black;
    ((UltraGridBase) this.ugForms).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance18;
    appearance19.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance19.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance19.ForeColor = Color.Black;
    ((UltraGridBase) this.ugForms).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance19;
    ((UltraGridBase) this.ugForms).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    appearance20.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugForms).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance20;
    appearance21.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.ugForms).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance21;
    ((UltraGridBase) this.ugForms).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance22.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.ugForms).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance22;
    appearance23.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugForms).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance23;
    ((UltraGridBase) this.ugForms).DisplayLayout.Override.RowSelectorStyle = (HeaderStyle) 2;
    appearance24.BackColor = Color.Transparent;
    appearance24.ForeColor = Color.Black;
    ((UltraGridBase) this.ugForms).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance24;
    appearance25.BackColor = Color.WhiteSmoke;
    appearance25.BorderColor = Color.Silver;
    scrollBarLook2.ButtonAppearance = (AppearanceBase) appearance25;
    appearance26.BackColor = Color.White;
    scrollBarLook2.TrackAppearance = (AppearanceBase) appearance26;
    ((UltraGridBase) this.ugForms).DisplayLayout.ScrollBarLook = scrollBarLook2;
    ((Control) this.ugForms).Dock = DockStyle.Fill;
    ((Control) this.ugForms).Location = new Point(0, 0);
    ((Control) this.ugForms).Name = "ugForms";
    ((Control) this.ugForms).Size = new Size(675, 353);
    ((Control) this.ugForms).TabIndex = 28;
    ((UltraControlBase) this.ugForms).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.ugForms).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.tabDescription).Controls.Add((Control) ultraGroupBox1);
    ((Control) this.tabDescription).Location = new Point(-10000, -10000);
    ((Control) this.tabDescription).Name = "tabDescription";
    ((Control) this.tabDescription).Size = new Size(675, 353);
    ((Control) this.UltraTabPageControl4).Controls.Add((Control) ultraGroupBox2);
    ((Control) this.UltraTabPageControl4).Location = new Point(-10000, -10000);
    ((Control) this.UltraTabPageControl4).Name = "UltraTabPageControl4";
    ((Control) this.UltraTabPageControl4).Size = new Size(675, 353);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.editorCtrlComments);
    ((Control) this.UltraTabPageControl3).Location = new Point(-10000, -10000);
    ((Control) this.UltraTabPageControl3).Name = "UltraTabPageControl3";
    ((Control) this.UltraTabPageControl3).Size = new Size(675, 353);
    this.editorCtrlComments.BackColor = Color.White;
    this.editorCtrlComments.Dock = DockStyle.Fill;
    this.editorCtrlComments.Font = new Font("Times New Roman", 12f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.editorCtrlComments.ForeColor = SystemColors.Window;
    this.editorCtrlComments.Location = new Point(0, 0);
    this.editorCtrlComments.Name = "editorCtrlComments";
    this.editorCtrlComments.Size = new Size(675, 353);
    this.editorCtrlComments.TabIndex = 211;
    this.editorCtrlComments.Text = "editorControl1";
    ((Control) this.UltraTabPageControl5).Controls.Add((Control) this.lnkClearImage);
    ((Control) this.UltraTabPageControl5).Controls.Add((Control) this.lnkLoadImage);
    ((Control) this.UltraTabPageControl5).Controls.Add((Control) this.UltraGroupBox3);
    ((Control) this.UltraTabPageControl5).Location = new Point(-10000, -10000);
    ((Control) this.UltraTabPageControl5).Name = "UltraTabPageControl5";
    ((Control) this.UltraTabPageControl5).Size = new Size(675, 353);
    this.lnkClearImage.AutoSize = true;
    this.lnkClearImage.BackColor = Color.Transparent;
    this.lnkClearImage.Location = new Point(115, 326);
    this.lnkClearImage.Name = "lnkClearImage";
    this.lnkClearImage.Size = new Size(65, 13);
    this.lnkClearImage.TabIndex = 3;
    this.lnkClearImage.TabStop = true;
    this.lnkClearImage.Text = "Clear Image";
    this.lnkLoadImage.AutoSize = true;
    this.lnkLoadImage.BackColor = Color.Transparent;
    this.lnkLoadImage.Location = new Point(19, 326);
    this.lnkLoadImage.Name = "lnkLoadImage";
    this.lnkLoadImage.Size = new Size(63 /*0x3F*/, 13);
    this.lnkLoadImage.TabIndex = 2;
    this.lnkLoadImage.TabStop = true;
    this.lnkLoadImage.Text = "Load Image";
    ((Control) this.UltraGroupBox3).Controls.Add((Control) this.picBox);
    ((Control) this.UltraGroupBox3).Location = new Point(14, 14);
    ((Control) this.UltraGroupBox3).Name = "UltraGroupBox3";
    ((Control) this.UltraGroupBox3).Size = new Size(647, 294);
    ((Control) this.UltraGroupBox3).TabIndex = 1;
    this.UltraGroupBox3.Text = "SL Image";
    this.picBox.BorderShadowColor = Color.Transparent;
    ((Control) this.picBox).Location = new Point(8, 20);
    ((Control) this.picBox).Name = "picBox";
    ((Control) this.picBox).Size = new Size(633, 256 /*0x0100*/);
    ((Control) this.picBox).TabIndex = 0;
    this.Label3.AutoSize = true;
    this.Label3.Location = new Point(24, 12);
    this.Label3.Name = "Label3";
    this.Label3.Size = new Size(37, 13);
    this.Label3.TabIndex = 18;
    this.Label3.Text = "State:";
    ((Control) this.chkNotAllowPremiumAllocation).Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    appearance27.BorderColor = Color.Gray;
    appearance27.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkNotAllowPremiumAllocation).Appearance = (AppearanceBase) appearance27;
    ((UltraToggleEditorBase) this.chkNotAllowPremiumAllocation).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkNotAllowPremiumAllocation).BackColorInternal = Color.Transparent;
    ((UltraToggleEditorBase) this.chkNotAllowPremiumAllocation).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkNotAllowPremiumAllocation).Location = new Point(12, 424);
    ((Control) this.chkNotAllowPremiumAllocation).Name = "chkNotAllowPremiumAllocation";
    ((Control) this.chkNotAllowPremiumAllocation).Size = new Size(195, 24);
    ((Control) this.chkNotAllowPremiumAllocation).TabIndex = 23;
    ((UltraToggleEditorBase) this.chkNotAllowPremiumAllocation).Text = "Do not allow Premium Allocation ";
    ((UltraControlBase) this.chkNotAllowPremiumAllocation).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkNotAllowPremiumAllocation).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.chkUseCorpLic).Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    appearance28.BorderColor = Color.Gray;
    appearance28.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkUseCorpLic).Appearance = (AppearanceBase) appearance28;
    ((UltraToggleEditorBase) this.chkUseCorpLic).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkUseCorpLic).BackColorInternal = Color.Transparent;
    ((UltraToggleEditorBase) this.chkUseCorpLic).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkUseCorpLic).Location = new Point(12, 484);
    ((Control) this.chkUseCorpLic).Name = "chkUseCorpLic";
    ((Control) this.chkUseCorpLic).Size = new Size(235, 24);
    ((Control) this.chkUseCorpLic).TabIndex = 25;
    ((UltraToggleEditorBase) this.chkUseCorpLic).Text = "Use Corporate Lic when filing in this State";
    ((UltraControlBase) this.chkUseCorpLic).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkUseCorpLic).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.chkFilingReqZeroPremium).Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    appearance29.BorderColor = Color.Gray;
    appearance29.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkFilingReqZeroPremium).Appearance = (AppearanceBase) appearance29;
    ((UltraToggleEditorBase) this.chkFilingReqZeroPremium).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkFilingReqZeroPremium).BackColorInternal = Color.Transparent;
    ((UltraToggleEditorBase) this.chkFilingReqZeroPremium).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkFilingReqZeroPremium).Location = new Point(12, 454);
    ((Control) this.chkFilingReqZeroPremium).Name = "chkFilingReqZeroPremium";
    ((Control) this.chkFilingReqZeroPremium).Size = new Size(194, 24);
    ((Control) this.chkFilingReqZeroPremium).TabIndex = 24;
    ((UltraToggleEditorBase) this.chkFilingReqZeroPremium).Text = "Filing Required for $0 Premium";
    ((UltraControlBase) this.chkFilingReqZeroPremium).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkFilingReqZeroPremium).UseOsThemes = (DefaultableBoolean) 2;
    this.daStateSLRules.DeleteCommand = this.DbDeleteCommand1;
    this.daStateSLRules.InsertCommand = this.DbInsertCommand1;
    this.daStateSLRules.SelectCommand = command1;
    this.daStateSLRules.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblStateSLRules", new DataColumnMapping[15]
      {
        new DataColumnMapping("ID", "ID"),
        new DataColumnMapping("StateID", "StateID"),
        new DataColumnMapping("OtherInfo", "OtherInfo"),
        new DataColumnMapping("NoAllowPremiumAllocation", "NoAllowPremiumAllocation"),
        new DataColumnMapping("FilingRequiredForZeroPremium", "FilingRequiredForZeroPremium"),
        new DataColumnMapping("UseCorporateLic", "UseCorporateLic"),
        new DataColumnMapping("Description", "Description"),
        new DataColumnMapping("Mail", "Mail"),
        new DataColumnMapping("Online", "Online"),
        new DataColumnMapping("Retain", "Retain"),
        new DataColumnMapping("Comments", "Comments"),
        new DataColumnMapping("FolderID", "FolderID"),
        new DataColumnMapping("SLImageData", "SLImageData"),
        new DataColumnMapping("StatePubWhiteList", "StatePubWhiteList"),
        new DataColumnMapping("StatePubExportList", "StatePubExportList")
      })
    });
    this.daStateSLRules.UpdateCommand = command2;
    this.DbDeleteCommand1.CommandText = "DELETE FROM [dbo].[tblStateSLRules] WHERE (([ID] = @Original_ID))";
    this.DbDeleteCommand1.Parameters.AddRange((Array) new DbParameter[1]
    {
      DefaultDatabase.CreateParameter("@Original_ID", SqlDbType.Int, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "ID", DataRowVersion.Original, (object) null)
    });
    this.DbInsertCommand1.CommandText = componentResourceManager.GetString("DbInsertCommand1.CommandText");
    this.DbInsertCommand1.Parameters.AddRange((Array) new DbParameter[14]
    {
      DefaultDatabase.CreateParameter("@StateID", SqlDbType.Char, 0, "StateID"),
      DefaultDatabase.CreateParameter("@OtherInfo", SqlDbType.VarChar, 0, "OtherInfo"),
      DefaultDatabase.CreateParameter("@NoAllowPremiumAllocation", SqlDbType.Bit, 0, "NoAllowPremiumAllocation"),
      DefaultDatabase.CreateParameter("@FilingRequiredForZeroPremium", SqlDbType.Bit, 0, "FilingRequiredForZeroPremium"),
      DefaultDatabase.CreateParameter("@UseCorporateLic", SqlDbType.Bit, 0, "UseCorporateLic"),
      DefaultDatabase.CreateParameter("@Description", SqlDbType.VarChar, 0, "Description"),
      DefaultDatabase.CreateParameter("@Mail", SqlDbType.Bit, 0, "Mail"),
      DefaultDatabase.CreateParameter("@Online", SqlDbType.Bit, 0, "Online"),
      DefaultDatabase.CreateParameter("@Retain", SqlDbType.Bit, 0, "Retain"),
      DefaultDatabase.CreateParameter("@Comments", SqlDbType.Text, 0, "Comments"),
      DefaultDatabase.CreateParameter("@FolderID", SqlDbType.Int, 0, "FolderID"),
      DefaultDatabase.CreateParameter("@SLImageData", SqlDbType.Image, 0, "SLImageData"),
      DefaultDatabase.CreateParameter("@StatePubWhiteList", SqlDbType.Bit, 0, "StatePubWhiteList"),
      DefaultDatabase.CreateParameter("@StatePubExportList", SqlDbType.Bit, 0, "StatePubExportList")
    });
    ((Control) this.UltraTabControl1).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((Control) this.UltraTabControl1).Controls.Add((Control) this.UltraTabSharedControlsPage1);
    ((Control) this.UltraTabControl1).Controls.Add((Control) this.UltraTabPageControl1);
    ((Control) this.UltraTabControl1).Controls.Add((Control) this.UltraTabPageControl2);
    ((Control) this.UltraTabControl1).Controls.Add((Control) this.tabDescription);
    ((Control) this.UltraTabControl1).Controls.Add((Control) this.UltraTabPageControl4);
    ((Control) this.UltraTabControl1).Controls.Add((Control) this.UltraTabPageControl3);
    ((Control) this.UltraTabControl1).Controls.Add((Control) this.UltraTabPageControl5);
    ((Control) this.UltraTabControl1).Location = new Point(12, 38);
    ((Control) this.UltraTabControl1).Name = "UltraTabControl1";
    ((UltraTabControlBase) this.UltraTabControl1).SharedControlsPage = this.UltraTabSharedControlsPage1;
    ((Control) this.UltraTabControl1).Size = new Size(677, 380);
    ((Control) this.UltraTabControl1).TabIndex = 28;
    ((UltraTabControlBase) this.UltraTabControl1).TabLayoutStyle = (TabLayoutStyle) 2;
    appearance30.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance30.Image"));
    ultraTab1.Appearance = (AppearanceBase) appearance30;
    ultraTab1.TabPage = this.UltraTabPageControl1;
    ultraTab1.Text = "Required Data";
    appearance31.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance31.Image"));
    ultraTab2.Appearance = (AppearanceBase) appearance31;
    ultraTab2.TabPage = this.UltraTabPageControl2;
    ultraTab2.Text = "Applicable Documents";
    appearance32.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance32.Image"));
    ultraTab3.Appearance = (AppearanceBase) appearance32;
    ultraTab3.TabPage = this.tabDescription;
    ultraTab3.Text = "User Notes";
    appearance33.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance33.Image"));
    ultraTab4.Appearance = (AppearanceBase) appearance33;
    ultraTab4.TabPage = this.UltraTabPageControl4;
    ultraTab4.Text = "Filing Notes";
    appearance34.Image = (object) strings.pencil_add;
    ultraTab5.Appearance = (AppearanceBase) appearance34;
    ultraTab5.TabPage = this.UltraTabPageControl3;
    ultraTab5.Text = "Stamp Wording";
    appearance35.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance35.Image"));
    ultraTab6.Appearance = (AppearanceBase) appearance35;
    ultraTab6.TabPage = this.UltraTabPageControl5;
    ultraTab6.Text = "SL Image Data";
    ((UltraTabControlBase) this.UltraTabControl1).Tabs.AddRange(new UltraTab[6]
    {
      ultraTab1,
      ultraTab2,
      ultraTab3,
      ultraTab4,
      ultraTab5,
      ultraTab6
    });
    ((UltraTabControlBase) this.UltraTabControl1).TabSize = new Size(0, 25);
    ((UltraTabControlBase) this.UltraTabControl1).ViewStyle = (ViewStyle) 4;
    ((Control) this.UltraTabSharedControlsPage1).Location = new Point(-10000, -10000);
    ((Control) this.UltraTabSharedControlsPage1).Name = "UltraTabSharedControlsPage1";
    ((Control) this.UltraTabSharedControlsPage1).Size = new Size(675, 353);
    this.daStateRulesTemplates.DeleteCommand = this.DbCommand1;
    this.daStateRulesTemplates.InsertCommand = this.DbCommand2;
    this.daStateRulesTemplates.SelectCommand = this.DbCommand3;
    this.daStateRulesTemplates.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblSLStateRulesForms", new DataColumnMapping[7]
      {
        new DataColumnMapping("StateID", "StateID"),
        new DataColumnMapping("TemplateID", "TemplateID"),
        new DataColumnMapping("UseOnBinder", "UseOnBinder"),
        new DataColumnMapping("UserOnQuote", "UserOnQuote"),
        new DataColumnMapping("InsuredSigns", "InsuredSigns"),
        new DataColumnMapping("ProducerSigns", "ProducerSigns"),
        new DataColumnMapping("UseOnIssuance", "UseOnIssuance")
      })
    });
    this.daStateRulesTemplates.UpdateCommand = this.DbCommand4;
    this.DbCommand1.CommandText = "DELETE FROM [dbo].[tblSLStateRulesForms] WHERE (([StateID] = @Original_StateID) AND ([TemplateID] = @Original_TemplateID))";
    this.DbCommand1.Parameters.AddRange((Array) new DbParameter[2]
    {
      DefaultDatabase.CreateParameter("@Original_StateID", SqlDbType.Char, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "StateID", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@Original_TemplateID", SqlDbType.Int, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "TemplateID", DataRowVersion.Original, (object) null)
    });
    this.DbCommand2.CommandText = componentResourceManager.GetString("DbCommand2.CommandText");
    this.DbCommand2.Parameters.AddRange((Array) new DbParameter[7]
    {
      DefaultDatabase.CreateParameter("@StateID", SqlDbType.Char, 0, "StateID"),
      DefaultDatabase.CreateParameter("@TemplateID", SqlDbType.Int, 0, "TemplateID"),
      DefaultDatabase.CreateParameter("@UseOnBinder", SqlDbType.Bit, 0, "UseOnBinder"),
      DefaultDatabase.CreateParameter("@UserOnQuote", SqlDbType.Bit, 0, "UserOnQuote"),
      DefaultDatabase.CreateParameter("@InsuredSigns", SqlDbType.Bit, 0, "InsuredSigns"),
      DefaultDatabase.CreateParameter("@ProducerSigns", SqlDbType.Bit, 0, "ProducerSigns"),
      DefaultDatabase.CreateParameter("@UseOnIssuance", SqlDbType.Bit, 0, "UseOnIssuance")
    });
    this.DbCommand3.CommandText = "SELECT        StateID, TemplateID, UseOnBinder, UserOnQuote, InsuredSigns, ProducerSigns, UseOnIssuance\r\nFROM            dbo.tblSLStateRulesForms\r\nWHERE        (StateID = @StateID)";
    this.DbCommand3.Parameters.AddRange((Array) new DbParameter[1]
    {
      DefaultDatabase.CreateParameter("@StateID", SqlDbType.Char, 2, "StateID")
    });
    this.DbCommand4.CommandText = componentResourceManager.GetString("DbCommand4.CommandText");
    this.DbCommand4.Parameters.AddRange((Array) new DbParameter[9]
    {
      DefaultDatabase.CreateParameter("@StateID", SqlDbType.Char, 0, "StateID"),
      DefaultDatabase.CreateParameter("@TemplateID", SqlDbType.Int, 0, "TemplateID"),
      DefaultDatabase.CreateParameter("@UseOnBinder", SqlDbType.Bit, 0, "UseOnBinder"),
      DefaultDatabase.CreateParameter("@UserOnQuote", SqlDbType.Bit, 0, "UserOnQuote"),
      DefaultDatabase.CreateParameter("@InsuredSigns", SqlDbType.Bit, 0, "InsuredSigns"),
      DefaultDatabase.CreateParameter("@ProducerSigns", SqlDbType.Bit, 0, "ProducerSigns"),
      DefaultDatabase.CreateParameter("@UseOnIssuance", SqlDbType.Bit, 0, "UseOnIssuance"),
      DefaultDatabase.CreateParameter("@Original_StateID", SqlDbType.Char, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "StateID", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@Original_TemplateID", SqlDbType.Int, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "TemplateID", DataRowVersion.Original, (object) null)
    });
    this.daRequiredData.DeleteCommand = this.DbCommand5;
    this.daRequiredData.InsertCommand = this.DbCommand6;
    this.daRequiredData.SelectCommand = command3;
    this.daRequiredData.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblStatesSLRequiredData", new DataColumnMapping[2]
      {
        new DataColumnMapping("StateID", "StateID"),
        new DataColumnMapping("RequiredDataID", "RequiredDataID")
      })
    });
    this.daRequiredData.UpdateCommand = this.DbCommand8;
    this.DbCommand5.CommandText = "DELETE FROM [dbo].[tblStatesSLRequiredData] WHERE (([StateID] = @Original_StateID) AND ([RequiredDataID] = @Original_RequiredDataID))";
    this.DbCommand5.Parameters.AddRange((Array) new DbParameter[2]
    {
      DefaultDatabase.CreateParameter("@Original_StateID", SqlDbType.Char, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "StateID", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@Original_RequiredDataID", SqlDbType.Int, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "RequiredDataID", DataRowVersion.Original, (object) null)
    });
    this.DbCommand6.CommandText = componentResourceManager.GetString("DbCommand6.CommandText");
    this.DbCommand6.Parameters.AddRange((Array) new DbParameter[3]
    {
      DefaultDatabase.CreateParameter("@StateID", SqlDbType.Char, 2, "StateID"),
      DefaultDatabase.CreateParameter("@RequiredDataID", SqlDbType.Int, 4, "RequiredDataID"),
      DefaultDatabase.CreateParameter("@UseForFiling", SqlDbType.Bit, 1, "UseForFiling")
    });
    this.DbCommand8.CommandText = componentResourceManager.GetString("DbCommand8.CommandText");
    this.DbCommand8.Parameters.AddRange((Array) new DbParameter[5]
    {
      DefaultDatabase.CreateParameter("@StateID", SqlDbType.Char, 2, "StateID"),
      DefaultDatabase.CreateParameter("@RequiredDataID", SqlDbType.Int, 4, "RequiredDataID"),
      DefaultDatabase.CreateParameter("@UseForFiling", SqlDbType.Bit, 1, "UseForFiling"),
      DefaultDatabase.CreateParameter("@Original_StateID", SqlDbType.Char, 2, ParameterDirection.Input, false, (byte) 0, (byte) 0, "StateID", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@Original_RequiredDataID", SqlDbType.Int, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "RequiredDataID", DataRowVersion.Original, (object) null)
    });
    this.rbRetain.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.rbRetain.BackColor = Color.Transparent;
    this.rbRetain.ForeColor = Color.Black;
    this.rbRetain.Location = new Point(18, 60);
    this.rbRetain.Name = "rbRetain";
    this.rbRetain.Size = new Size(67, 19);
    this.rbRetain.TabIndex = 15;
    this.rbRetain.Text = "Retain";
    this.rbRetain.UseVisualStyleBackColor = false;
    this.rbOnline.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.rbOnline.BackColor = Color.Transparent;
    this.rbOnline.ForeColor = Color.Black;
    this.rbOnline.Location = new Point(18, 39);
    this.rbOnline.Name = "rbOnline";
    this.rbOnline.Size = new Size(67, 15);
    this.rbOnline.TabIndex = 14;
    this.rbOnline.Text = "Online";
    this.rbOnline.UseVisualStyleBackColor = false;
    this.rbMail.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.rbMail.BackColor = Color.Transparent;
    this.rbMail.ForeColor = Color.Black;
    this.rbMail.Location = new Point(18, 18);
    this.rbMail.Name = "rbMail";
    this.rbMail.Size = new Size(53, 15);
    this.rbMail.TabIndex = 13;
    this.rbMail.Text = "Mail";
    this.rbMail.UseVisualStyleBackColor = false;
    ((Control) this.dbSave).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.dbSave.AutoQueryRowCountOnLoad = false;
    ((UserControl) this.dbSave).AutoSizeMode = AutoSizeMode.GrowAndShrink;
    this.dbSave.EditStyle = (EditStyle) 1;
    this.dbSave.FreezeEvents = false;
    ((Control) this.dbSave).Location = new Point(576, 469);
    ((Control) this.dbSave).Name = "dbSave";
    ((Control) this.dbSave).Size = new Size(112 /*0x70*/, 40);
    ((Control) this.dbSave).TabIndex = 39;
    ((Control) this.grpFileTracking).Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    ((Control) this.grpFileTracking).Controls.Add((Control) this.rbRetain);
    ((Control) this.grpFileTracking).Controls.Add((Control) this.rbOnline);
    ((Control) this.grpFileTracking).Controls.Add((Control) this.rbMail);
    ((Control) this.grpFileTracking).Location = new Point(253, 424);
    ((Control) this.grpFileTracking).Name = "grpFileTracking";
    ((Control) this.grpFileTracking).Size = new Size(114, 85);
    ((Control) this.grpFileTracking).TabIndex = 26;
    this.grpFileTracking.Text = "Track Filing";
    this.grpFileTracking.ViewStyle = (GroupBoxViewStyle) 5;
    appearance36.BackColor = Color.Gainsboro;
    appearance36.BackColor2 = Color.White;
    appearance36.BackGradientStyle = (GradientStyle) 2;
    appearance36.BorderColor = Color.Gray;
    ((ControlBase) this.btnPrevious).Appearance = (AppearanceBase) appearance36;
    ((Control) this.btnPrevious).Location = new Point(217, 8);
    ((Control) this.btnPrevious).Name = "btnPrevious";
    ((Control) this.btnPrevious).Size = new Size(75, 24);
    ((Control) this.btnPrevious).TabIndex = 2;
    ((ControlBase) this.btnPrevious).Text = "Previous";
    this.btnPrevious.UseOSThemes = (DefaultableBoolean) 2;
    appearance37.BackColor = Color.Gainsboro;
    appearance37.BackColor2 = Color.White;
    appearance37.BackGradientStyle = (GradientStyle) 2;
    appearance37.BorderColor = Color.Gray;
    ((ControlBase) this.btnNext).Appearance = (AppearanceBase) appearance37;
    ((Control) this.btnNext).Location = new Point(307, 8);
    ((Control) this.btnNext).Name = "btnNext";
    ((Control) this.btnNext).Size = new Size(75, 24);
    ((Control) this.btnNext).TabIndex = 3;
    ((ControlBase) this.btnNext).Text = "Next";
    this.btnNext.UseOSThemes = (DefaultableBoolean) 2;
    this.Label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.Label1.AutoSize = true;
    this.Label1.Location = new Point(380, 428);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(92, 13);
    this.Label1.TabIndex = 44;
    this.Label1.Text = "Document Folder:";
    this.fileDialog.FileName = "OpenFileDialog1";
    this.fileDialog.Title = "Choose an image file";
    ((Control) this.chkExportList).Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    appearance38.BorderColor = Color.Gray;
    appearance38.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkExportList).Appearance = (AppearanceBase) appearance38;
    ((UltraToggleEditorBase) this.chkExportList).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkExportList).BackColorInternal = Color.Transparent;
    ((UltraToggleEditorBase) this.chkExportList).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkExportList).Location = new Point(383, 484);
    ((Control) this.chkExportList).Name = "chkExportList";
    ((Control) this.chkExportList).Size = new Size(154, 24);
    ((Control) this.chkExportList).TabIndex = 29;
    ((UltraToggleEditorBase) this.chkExportList).Text = "State Publishes Export List";
    ((UltraControlBase) this.chkExportList).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkExportList).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.chkWhiteList).Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    appearance39.BorderColor = Color.Gray;
    appearance39.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkWhiteList).Appearance = (AppearanceBase) appearance39;
    ((UltraToggleEditorBase) this.chkWhiteList).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkWhiteList).BackColorInternal = Color.Transparent;
    ((UltraToggleEditorBase) this.chkWhiteList).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkWhiteList).Location = new Point(383, 454);
    ((Control) this.chkWhiteList).Name = "chkWhiteList";
    ((Control) this.chkWhiteList).Size = new Size(154, 24);
    ((Control) this.chkWhiteList).TabIndex = 28;
    ((UltraToggleEditorBase) this.chkWhiteList).Text = "State Publishes White List";
    ((UltraControlBase) this.chkWhiteList).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkWhiteList).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.cboDocumentFolder).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    ((UltraCombo) this.cboDocumentFolder).BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.cboDocumentFolder).DataMember = "tblDocumentFolders";
    ((UltraGridBase) this.cboDocumentFolder).DataSource = (object) this.ds;
    ((UltraDropDownBase) this.cboDocumentFolder).DisplayMember = "FolderName";
    ((UltraCombo) this.cboDocumentFolder).DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboDocumentFolder).DropDownWidth = 300;
    ((Control) this.cboDocumentFolder).Location = new Point(478, 424);
    this.cboDocumentFolder.MGAStyle = (MGAStyles) 2;
    ((Control) this.cboDocumentFolder).Name = "cboDocumentFolder";
    ((Control) this.cboDocumentFolder).Size = new Size(210, 21);
    ((Control) this.cboDocumentFolder).TabIndex = 27;
    ((UltraControlBase) this.cboDocumentFolder).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboDocumentFolder).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboDocumentFolder).ValueMember = "FolderID";
    ((Control) this.ddTemplates).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    ((UltraGridBase) this.ddTemplates).DataMember = "tblDocumentTemplates";
    ((UltraGridBase) this.ddTemplates).DataSource = (object) this.ds;
    ((UltraGridBase) this.ddTemplates).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn11.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn11.Header.VisiblePosition = 0;
    ultraGridColumn11.Hidden = true;
    ultraGridColumn11.Width = 187;
    ultraGridColumn12.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn12.Header).Caption = "Template";
    ultraGridColumn12.Header.VisiblePosition = 1;
    ultraGridColumn12.Width = 455;
    ultraGridColumn13.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn13.Header.VisiblePosition = 2;
    ultraGridBand3.Columns.AddRange(new object[3]
    {
      (object) ultraGridColumn11,
      (object) ultraGridColumn12,
      (object) ultraGridColumn13
    });
    ultraGridColumn14.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn14.Header.VisiblePosition = 0;
    ultraGridColumn15.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn15.Header.VisiblePosition = 1;
    ultraGridColumn16.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn16.Header.VisiblePosition = 2;
    ultraGridColumn17.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn17.Header.VisiblePosition = 3;
    ultraGridColumn18.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn18.Header.VisiblePosition = 4;
    ultraGridColumn19.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn19.Header.VisiblePosition = 5;
    ultraGridColumn20.Header.VisiblePosition = 6;
    ultraGridBand4.Columns.AddRange(new object[7]
    {
      (object) ultraGridColumn14,
      (object) ultraGridColumn15,
      (object) ultraGridColumn16,
      (object) ultraGridColumn17,
      (object) ultraGridColumn18,
      (object) ultraGridColumn19,
      (object) ultraGridColumn20
    });
    ((UltraGridBase) this.ddTemplates).DisplayLayout.BandsSerializer.Add((object) ultraGridBand3);
    ((UltraGridBase) this.ddTemplates).DisplayLayout.BandsSerializer.Add((object) ultraGridBand4);
    ((UltraDropDownBase) this.ddTemplates).DisplayMember = "TemplateName";
    ((UltraDropDownBase) this.ddTemplates).DropDownWidth = 457;
    ((Control) this.ddTemplates).Location = new Point(537, -90);
    ((Control) this.ddTemplates).Name = "ddTemplates";
    ((Control) this.ddTemplates).Size = new Size(129, 24);
    ((Control) this.ddTemplates).TabIndex = 31 /*0x1F*/;
    ((UltraDropDownBase) this.ddTemplates).ValueMember = "TemplateID";
    ((Control) this.ddTemplates).Visible = false;
    ((Control) this.ddRequiredData).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    ((UltraGridBase) this.ddRequiredData).DataMember = "lstStateSLRequiredData";
    ((UltraGridBase) this.ddRequiredData).DataSource = (object) this.ds;
    ((UltraGridBase) this.ddRequiredData).DisplayLayout.AutoFitStyle = (AutoFitStyle) 2;
    ultraGridColumn21.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn21.Header.VisiblePosition = 0;
    ultraGridColumn21.Hidden = true;
    ultraGridColumn22.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn22.Header.VisiblePosition = 1;
    ultraGridColumn22.MaxLength = 2000;
    ultraGridColumn22.MaxWidth = 700;
    ultraGridColumn22.Width = 700;
    ultraGridColumn23.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn23.Header.VisiblePosition = 2;
    ultraGridBand5.Columns.AddRange(new object[3]
    {
      (object) ultraGridColumn21,
      (object) ultraGridColumn22,
      (object) ultraGridColumn23
    });
    ultraGridColumn24.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn24.Header.VisiblePosition = 0;
    ultraGridColumn25.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn25.Header.VisiblePosition = 1;
    ultraGridColumn26.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn26.Header.VisiblePosition = 2;
    ultraGridBand6.Columns.AddRange(new object[3]
    {
      (object) ultraGridColumn24,
      (object) ultraGridColumn25,
      (object) ultraGridColumn26
    });
    ((UltraGridBase) this.ddRequiredData).DisplayLayout.BandsSerializer.Add((object) ultraGridBand5);
    ((UltraGridBase) this.ddRequiredData).DisplayLayout.BandsSerializer.Add((object) ultraGridBand6);
    ((UltraDropDownBase) this.ddRequiredData).DisplayMember = "RequiredData";
    ((UltraDropDownBase) this.ddRequiredData).DropDownWidth = 516;
    ((Control) this.ddRequiredData).Location = new Point(412, -86);
    ((Control) this.ddRequiredData).Name = "ddRequiredData";
    ((Control) this.ddRequiredData).Size = new Size(129, 23);
    ((Control) this.ddRequiredData).TabIndex = 30;
    ((UltraDropDownBase) this.ddRequiredData).ValueMember = "ID";
    ((Control) this.ddRequiredData).Visible = false;
    ((UltraCombo) this.cboState).BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.cboState).DataMember = "lstStates";
    ((UltraGridBase) this.cboState).DataSource = (object) this.ds;
    ((UltraDropDownBase) this.cboState).DisplayMember = "State";
    ((UltraCombo) this.cboState).DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboState).DropDownWidth = 300;
    ((Control) this.cboState).Location = new Point(65, 8);
    this.cboState.MGAStyle = (MGAStyles) 2;
    ((Control) this.cboState).Name = "cboState";
    ((Control) this.cboState).Size = new Size(126, 21);
    ((Control) this.cboState).TabIndex = 1;
    ((UltraControlBase) this.cboState).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboState).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboState).ValueMember = "StateID";
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    this.ClientSize = new Size(701, 521);
    this.Controls.Add((Control) this.chkWhiteList);
    this.Controls.Add((Control) this.chkExportList);
    this.Controls.Add((Control) this.Label1);
    this.Controls.Add((Control) this.cboDocumentFolder);
    this.Controls.Add((Control) this.btnNext);
    this.Controls.Add((Control) this.btnPrevious);
    this.Controls.Add((Control) this.grpFileTracking);
    this.Controls.Add((Control) this.dbSave);
    this.Controls.Add((Control) this.ddTemplates);
    this.Controls.Add((Control) this.ddRequiredData);
    this.Controls.Add((Control) this.chkFilingReqZeroPremium);
    this.Controls.Add((Control) this.chkUseCorpLic);
    this.Controls.Add((Control) this.UltraTabControl1);
    this.Controls.Add((Control) this.chkNotAllowPremiumAllocation);
    this.Controls.Add((Control) this.cboState);
    this.Controls.Add((Control) this.Label3);
    this.Font = new Font("Tahoma", 8.25f);
    this.ForeColor = Color.Black;
    this.Name = nameof (FormSLStateRules);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "SL State Rules";
    ((ISupportInitialize) ultraGroupBox1).EndInit();
    ((Control) ultraGroupBox1).ResumeLayout(false);
    ((ISupportInitialize) ultraGroupBox2).EndInit();
    ((Control) ultraGroupBox2).ResumeLayout(false);
    ((Control) this.UltraTabPageControl1).ResumeLayout(false);
    ((ISupportInitialize) this.ugRequiredData).EndInit();
    this.ds.EndInit();
    ((Control) this.UltraTabPageControl2).ResumeLayout(false);
    ((ISupportInitialize) this.ugForms).EndInit();
    ((Control) this.tabDescription).ResumeLayout(false);
    ((Control) this.UltraTabPageControl4).ResumeLayout(false);
    ((Control) this.UltraTabPageControl3).ResumeLayout(false);
    ((Control) this.UltraTabPageControl5).ResumeLayout(false);
    ((Control) this.UltraTabPageControl5).PerformLayout();
    ((ISupportInitialize) this.UltraGroupBox3).EndInit();
    ((Control) this.UltraGroupBox3).ResumeLayout(false);
    ((ISupportInitialize) this.chkNotAllowPremiumAllocation).EndInit();
    ((ISupportInitialize) this.chkUseCorpLic).EndInit();
    ((ISupportInitialize) this.chkFilingReqZeroPremium).EndInit();
    ((ISupportInitialize) this.UltraTabControl1).EndInit();
    ((Control) this.UltraTabControl1).ResumeLayout(false);
    ((ISupportInitialize) this.grpFileTracking).EndInit();
    ((Control) this.grpFileTracking).ResumeLayout(false);
    ((ISupportInitialize) this.btnPrevious).EndInit();
    ((ISupportInitialize) this.btnNext).EndInit();
    ((ISupportInitialize) this.chkExportList).EndInit();
    ((ISupportInitialize) this.chkWhiteList).EndInit();
    ((ISupportInitialize) this.cboDocumentFolder).EndInit();
    ((ISupportInitialize) this.ddTemplates).EndInit();
    ((ISupportInitialize) this.ddRequiredData).EndInit();
    ((ISupportInitialize) this.cboState).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  protected virtual MGASimpleComboBox cboState
  {
    get => this._cboState;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.cboState_ValueChanged);
      MGASimpleComboBox cboState1 = this._cboState;
      if (cboState1 != null)
        ((UltraCombo) cboState1).ValueChanged -= eventHandler;
      this._cboState = value;
      MGASimpleComboBox cboState2 = this._cboState;
      if (cboState2 == null)
        return;
      ((UltraCombo) cboState2).ValueChanged += eventHandler;
    }
  }

  [field: AccessedThroughProperty("chkNotAllowPremiumAllocation")]
  private virtual MGACheckBox chkNotAllowPremiumAllocation { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkUseCorpLic")]
  private virtual MGACheckBox chkUseCorpLic { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkFilingReqZeroPremium")]
  private virtual MGACheckBox chkFilingReqZeroPremium { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("daStateSLRules")]
  private virtual DbDataAdapter daStateSLRules { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("DbDeleteCommand1")]
  private virtual DbCommand DbDeleteCommand1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("DbInsertCommand1")]
  private virtual DbCommand DbInsertCommand1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual UltraGrid ugForms
  {
    get => this._ugForms;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      RowEventHandler rowEventHandler = new RowEventHandler(this.ugForms_AfterRowInsert);
      UltraGrid ugForms1 = this._ugForms;
      if (ugForms1 != null)
        ugForms1.AfterRowInsert -= rowEventHandler;
      this._ugForms = value;
      UltraGrid ugForms2 = this._ugForms;
      if (ugForms2 == null)
        return;
      ugForms2.AfterRowInsert += rowEventHandler;
    }
  }

  [field: AccessedThroughProperty("txtDescription")]
  private virtual RichTextBox txtDescription { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual UltraGrid ugRequiredData
  {
    get => this._ugRequiredData;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      RowEventHandler rowEventHandler = new RowEventHandler(this.ugRequiredData_AfterRowInsert);
      UltraGrid ugRequiredData1 = this._ugRequiredData;
      if (ugRequiredData1 != null)
        ugRequiredData1.AfterRowInsert -= rowEventHandler;
      this._ugRequiredData = value;
      UltraGrid ugRequiredData2 = this._ugRequiredData;
      if (ugRequiredData2 == null)
        return;
      ugRequiredData2.AfterRowInsert += rowEventHandler;
    }
  }

  private virtual UltraDropDown ddRequiredData
  {
    get => this._ddRequiredData;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      CancelEventHandler cancelEventHandler = new CancelEventHandler(this.ddRequiredData_BeforeDropDown);
      UltraDropDown ddRequiredData1 = this._ddRequiredData;
      if (ddRequiredData1 != null)
        ddRequiredData1.BeforeDropDown -= cancelEventHandler;
      this._ddRequiredData = value;
      UltraDropDown ddRequiredData2 = this._ddRequiredData;
      if (ddRequiredData2 == null)
        return;
      ddRequiredData2.BeforeDropDown += cancelEventHandler;
    }
  }

  private virtual UltraDropDown ddTemplates
  {
    get => this._ddTemplates;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      CancelEventHandler cancelEventHandler = new CancelEventHandler(this.ddPolicyForms_BeforeDropDown);
      UltraDropDown ddTemplates1 = this._ddTemplates;
      if (ddTemplates1 != null)
        ddTemplates1.BeforeDropDown -= cancelEventHandler;
      this._ddTemplates = value;
      UltraDropDown ddTemplates2 = this._ddTemplates;
      if (ddTemplates2 == null)
        return;
      ddTemplates2.BeforeDropDown += cancelEventHandler;
    }
  }

  [field: AccessedThroughProperty("daStateRulesTemplates")]
  private virtual DbDataAdapter daStateRulesTemplates { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("DbCommand1")]
  private virtual DbCommand DbCommand1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("DbCommand2")]
  private virtual DbCommand DbCommand2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("DbCommand3")]
  private virtual DbCommand DbCommand3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("DbCommand4")]
  private virtual DbCommand DbCommand4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("daRequiredData")]
  private virtual DbDataAdapter daRequiredData { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("DbCommand5")]
  private virtual DbCommand DbCommand5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("DbCommand6")]
  private virtual DbCommand DbCommand6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("DbCommand8")]
  private virtual DbCommand DbCommand8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("rbRetain")]
  private virtual RadioButton rbRetain { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("rbOnline")]
  private virtual RadioButton rbOnline { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("rbMail")]
  private virtual RadioButton rbMail { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual MGASystems.Tools.DBSaveUI.DBSaveUI dbSave
  {
    get => this._dbSave;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      CancelEventHandler cancelEventHandler1 = new CancelEventHandler(this.dbSave_ClickingCancel);
      CancelEventHandler cancelEventHandler2 = new CancelEventHandler(this.dbSave_ClickingDelete);
      CancelEventHandler cancelEventHandler3 = new CancelEventHandler(this.dbSaveClickingNew);
      CancelEventHandler cancelEventHandler4 = new CancelEventHandler(this.dbSave_ClickingSave);
      EventHandler eventHandler = new EventHandler(this.dbSave_UIStateChanged);
      MGASystems.Tools.DBSaveUI.DBSaveUI dbSave1 = this._dbSave;
      if (dbSave1 != null)
      {
        dbSave1.ClickingCancel -= cancelEventHandler1;
        dbSave1.ClickingDelete -= cancelEventHandler2;
        dbSave1.ClickingNew -= cancelEventHandler3;
        dbSave1.ClickingSave -= cancelEventHandler4;
        dbSave1.UIStateChanged -= eventHandler;
      }
      this._dbSave = value;
      MGASystems.Tools.DBSaveUI.DBSaveUI dbSave2 = this._dbSave;
      if (dbSave2 == null)
        return;
      dbSave2.ClickingCancel += cancelEventHandler1;
      dbSave2.ClickingDelete += cancelEventHandler2;
      dbSave2.ClickingNew += cancelEventHandler3;
      dbSave2.ClickingSave += cancelEventHandler4;
      dbSave2.UIStateChanged += eventHandler;
    }
  }

  [field: AccessedThroughProperty("txtOtherInfo")]
  private virtual RichTextBox txtOtherInfo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual MGAButton btnPrevious
  {
    get => this._btnPrevious;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnPrevious_Click);
      MGAButton btnPrevious1 = this._btnPrevious;
      if (btnPrevious1 != null)
        ((Control) btnPrevious1).Click -= eventHandler;
      this._btnPrevious = value;
      MGAButton btnPrevious2 = this._btnPrevious;
      if (btnPrevious2 == null)
        return;
      ((Control) btnPrevious2).Click += eventHandler;
    }
  }

  private virtual MGAButton btnNext
  {
    get => this._btnNext;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnNext_Click);
      MGAButton btnNext1 = this._btnNext;
      if (btnNext1 != null)
        ((Control) btnNext1).Click -= eventHandler;
      this._btnNext = value;
      MGAButton btnNext2 = this._btnNext;
      if (btnNext2 == null)
        return;
      ((Control) btnNext2).Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("editorCtrlComments")]
  private virtual RichTextBox editorCtrlComments { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cboDocumentFolder")]
  protected virtual MGASimpleComboBox cboDocumentFolder { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual LinkLabel lnkLoadImage
  {
    get => this._lnkLoadImage;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkLoadImage_LinkClicked);
      LinkLabel lnkLoadImage1 = this._lnkLoadImage;
      if (lnkLoadImage1 != null)
        lnkLoadImage1.LinkClicked -= clickedEventHandler;
      this._lnkLoadImage = value;
      LinkLabel lnkLoadImage2 = this._lnkLoadImage;
      if (lnkLoadImage2 == null)
        return;
      lnkLoadImage2.LinkClicked += clickedEventHandler;
    }
  }

  private virtual LinkLabel lnkClearImage
  {
    get => this._lnkClearImage;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkClearImage_LinkClicked);
      LinkLabel lnkClearImage1 = this._lnkClearImage;
      if (lnkClearImage1 != null)
        lnkClearImage1.LinkClicked -= clickedEventHandler;
      this._lnkClearImage = value;
      LinkLabel lnkClearImage2 = this._lnkClearImage;
      if (lnkClearImage2 == null)
        return;
      lnkClearImage2.LinkClicked += clickedEventHandler;
    }
  }

  [field: AccessedThroughProperty("chkExportList")]
  private virtual MGACheckBox chkExportList { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkWhiteList")]
  private virtual MGACheckBox chkWhiteList { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private void FormSLStateRules_Load(object sender, EventArgs e)
  {
    if (this.DesignMode)
      return;
    this._cn = DefaultDatabase.CreateDbConnection();
    Utility.SetDataAdapterConnections(this.daRequiredData, this._cn, (DbTransaction) null);
    Utility.SetDataAdapterConnections(this.daStateRulesTemplates, this._cn, (DbTransaction) null);
    Utility.SetDataAdapterConnections(this.daStateSLRules, this._cn, (DbTransaction) null);
    ((Control) this.dbSave).Enabled = false;
    this.LoadData();
    this.EnableForm(false);
    this.fileDialog.Filter = "All Files|*.*|Bitmap files|*.bmp|jpeg files|*.jpg,*.jfif|Portable network graphics files|*.png|Gif files|*.gif|TIFF|*.tiff|ICO|*.ico";
  }

  private void LoadData()
  {
    DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[1]
    {
      "lstStates"
    }, CommandType.Text, "SELECT StateID, State FROM lstStates ORDER BY State");
    DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[1]
    {
      "tblDocumentTemplates"
    }, CommandType.Text, "SELECT TemplateID, TemplateName FROM tblDocumentTemplates ORDER BY TemplateName");
    DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[1]
    {
      "lstStateSLRequiredData"
    }, CommandType.Text, "SELECT ID, RequiredData FROM lstStateSLRequiredData ORDER BY RequiredData");
    dsStateSLRules.tblDocumentFoldersRow row = this.ds.tblDocumentFolders.NewtblDocumentFoldersRow();
    row.FolderID = -1;
    row.FolderName = string.Empty;
    this.ds.tblDocumentFolders.AddtblDocumentFoldersRow(row);
    DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[1]
    {
      "tblDocumentFolders"
    }, CommandType.Text, "SELECT FolderID, FolderName FROM tblDocumentFolders WITH (NOLOCK) ORDER BY FolderName");
  }

  private void EnableForm(bool value)
  {
    try
    {
      foreach (Control control in this.Controls)
      {
        if (!(control is MGASystems.Tools.DBSaveUI.DBSaveUI) && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(control.Name, ((Control) this.cboState).Name, false) != 0)
          control.Enabled = value;
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    ((Control) this.btnNext).Enabled = true;
    ((Control) this.btnPrevious).Enabled = true;
  }

  private void EmptyTextBoxes()
  {
    this.txtOtherInfo.Text = string.Empty;
    this.txtDescription.Text = string.Empty;
    this.editorCtrlComments.Rtf = "";
    this.picBox.Image = (object) null;
  }

  private void SetRadioButtons(bool value)
  {
    try
    {
      foreach (Control control in ((Control) this.grpFileTracking).Controls)
      {
        if (control is RadioButton radioButton)
          radioButton.Checked = value;
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private void SetCheckBoxes(bool value)
  {
    try
    {
      foreach (Control control in this.Controls)
      {
        if (control is MGACheckBox mgaCheckBox)
          ((UltraToggleEditorBase) mgaCheckBox).Checked = value;
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private void cboState_ValueChanged(object sender, EventArgs e)
  {
    try
    {
      this.Cursor = MgaCursors.WaitCursor;
      ((UltraCombo) this.cboDocumentFolder).Value = (object) null;
      this.ClearTables();
      this.EmptyTextBoxes();
      this.SetCheckBoxes(false);
      this.SetRadioButtons(false);
      if (((UltraCombo) this.cboState).Value != null)
        this.RefillTables();
      if (this.ds.tblStateSLRules.Rows.Count > 0)
      {
        if (this.dbSave.UIState != 2)
          this.dbSave.PerformAction((DBSaveUIAction) 3);
      }
      else
      {
        this.dbSave.UIState = (UIState) 0;
        this.SetCheckBoxes(false);
        this.SetRadioButtons(false);
        this.EmptyTextBoxes();
      }
      if (this.ds.tblStateSLRules.Rows.Count == 0)
        this.dbSave.UIState = (UIState) 0;
      this.EnableForm(this.ds.tblStateSLRules.Rows.Count > 0);
      ((Control) this.dbSave).Enabled = true;
    }
    finally
    {
      this.Cursor = MgaCursors.Default;
    }
  }

  private void RefillTables()
  {
    this.daStateSLRules.SelectCommand.Parameters["@StateID"].Value = RuntimeHelpers.GetObjectValue(((UltraCombo) this.cboState).Value);
    DefaultDatabase.DataAdapterFill(this.daStateSLRules, (DataTable) this.ds.tblStateSLRules);
    this.daStateRulesTemplates.SelectCommand.Parameters["@StateID"].Value = RuntimeHelpers.GetObjectValue(((UltraCombo) this.cboState).Value);
    DefaultDatabase.DataAdapterFill(this.daStateRulesTemplates, (DataTable) this.ds.tblSLStateRulesForms);
    this.daRequiredData.SelectCommand.Parameters["@StateID"].Value = RuntimeHelpers.GetObjectValue(((UltraCombo) this.cboState).Value);
    DefaultDatabase.DataAdapterFill(this.daRequiredData, (DataTable) this.ds.tblStatesSLRequiredData);
    if (this.ds.tblStateSLRules.Rows.Count <= 0)
      return;
    this.AssignDataToForm();
  }

  private void ClearTables()
  {
    this.ds.tblSLStateRulesForms.Rows.Clear();
    this.ds.tblStateSLRules.Rows.Clear();
    this.ds.tblStatesSLRequiredData.Rows.Clear();
  }

  private void AssignDataToForm()
  {
    if (this.ds.tblStateSLRules.Rows.Count > 0)
    {
      ((UltraToggleEditorBase) this.chkFilingReqZeroPremium).Checked = this.ds.tblStateSLRules[0].FilingRequiredForZeroPremium;
      ((UltraToggleEditorBase) this.chkNotAllowPremiumAllocation).Checked = this.ds.tblStateSLRules[0].NoAllowPremiumAllocation;
      ((UltraToggleEditorBase) this.chkUseCorpLic).Checked = this.ds.tblStateSLRules[0].UseCorporateLic;
      this.rbMail.Checked = this.ds.tblStateSLRules[0].Mail;
      this.rbOnline.Checked = this.ds.tblStateSLRules[0].Online;
      this.rbRetain.Checked = this.ds.tblStateSLRules[0].Retain;
      ((UltraToggleEditorBase) this.chkExportList).Checked = this.ds.tblStateSLRules[0].StatePubExportList;
      ((UltraToggleEditorBase) this.chkWhiteList).Checked = this.ds.tblStateSLRules[0].StatePubWhiteList;
      if (!this.ds.tblStateSLRules[0].IsDescriptionNull())
        this.txtDescription.Rtf = this.ds.tblStateSLRules[0].Description;
      else
        this.txtDescription.Text = string.Empty;
      if (!this.ds.tblStateSLRules[0].IsOtherInfoNull())
        this.txtOtherInfo.Rtf = this.ds.tblStateSLRules[0].OtherInfo;
      else
        this.txtOtherInfo.Text = string.Empty;
      if (!this.ds.tblStateSLRules[0].IsFolderIDNull())
        ((UltraCombo) this.cboDocumentFolder).Value = (object) this.ds.tblStateSLRules[0].FolderID;
      else
        ((UltraCombo) this.cboDocumentFolder).Value = (object) null;
      ASCIIEncoding asciiEncoding = new ASCIIEncoding();
      string s = string.Empty;
      if (!this.ds.tblStateSLRules[0].IsCommentsNull())
        s = this.ds.tblStateSLRules[0].Comments;
      MemoryStream memoryStream1 = new MemoryStream(asciiEncoding.GetBytes(s));
      this.editorCtrlComments.SelectAll();
      this.editorCtrlComments.SelectionFont = this.editorCtrlComments.Font;
      this.editorCtrlComments.Rtf = "";
      this.editorCtrlComments.SelectedRtf = s;
      this.picBox.Image = (object) null;
      try
      {
        if (!this.ds.tblStateSLRules[0].IsSLImageDataNull())
        {
          if (this.ds.tblStateSLRules[0].SLImageData.Length <= 0)
            return;
          MemoryStream memoryStream2 = new MemoryStream(this.ds.tblStateSLRules[0].SLImageData);
          try
          {
            this.picBox.Image = (object) new Bitmap((Stream) memoryStream2);
          }
          catch (ArgumentException ex)
          {
            ProjectData.SetProjectError((Exception) ex);
            this.picBox.Image = (object) null;
            ProjectData.ClearProjectError();
          }
          finally
          {
            memoryStream2.Close();
          }
        }
        else
          this.picBox.Image = (object) null;
      }
      catch (StrongTypingException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        this.picBox.Image = (object) null;
        ProjectData.ClearProjectError();
      }
    }
    else
    {
      this.EmptyTextBoxes();
      this.SetCheckBoxes(false);
      this.SetRadioButtons(false);
    }
  }

  private void SaveData()
  {
    DefaultDatabase.ExecuteTransaction((EventHandler<ExecuteTransactionEventArgs>) ([SpecialName] (tmpObject, transArgs) =>
    {
      DefaultDatabase.DataAdapterUpdate(this.daStateSLRules, (DataTable) this.ds.tblStateSLRules);
      DefaultDatabase.DataAdapterUpdate(this.daStateRulesTemplates, (DataTable) this.ds.tblSLStateRulesForms);
      DefaultDatabase.DataAdapterUpdate(this.daRequiredData, (DataTable) this.ds.tblStatesSLRequiredData);
      transArgs.Transaction.Commit();
    }));
  }

  private void AssignFormDataToRow()
  {
    dsStateSLRules.tblStateSLRulesRow tblStateSlRule = this.ds.tblStateSLRules[0];
    if (!string.IsNullOrEmpty(this.txtOtherInfo.Text))
      tblStateSlRule.OtherInfo = this.txtOtherInfo.Rtf.Length <= this.txtOtherInfo.MaxLength ? this.txtOtherInfo.Rtf : this.txtOtherInfo.Rtf.Substring(0, this.txtOtherInfo.MaxLength);
    else
      tblStateSlRule.SetOtherInfoNull();
    if (!string.IsNullOrEmpty(this.txtDescription.Text))
      tblStateSlRule.Description = this.txtDescription.Rtf.Length <= this.txtDescription.MaxLength ? this.txtDescription.Rtf : this.txtDescription.Rtf.Substring(0, this.txtDescription.MaxLength);
    else
      tblStateSlRule.SetDescriptionNull();
    using (MemoryStream data = new MemoryStream())
    {
      this.editorCtrlComments.SaveFile((Stream) data, RichTextBoxStreamType.RichText);
      data.Position = 0L;
      using (StreamReader streamReader = new StreamReader((Stream) data))
      {
        string end = streamReader.ReadToEnd();
        if (!string.IsNullOrEmpty(end))
          tblStateSlRule.Comments = end;
        else
          tblStateSlRule.SetCommentsNull();
      }
    }
    tblStateSlRule.FilingRequiredForZeroPremium = ((UltraToggleEditorBase) this.chkFilingReqZeroPremium).Checked;
    tblStateSlRule.UseCorporateLic = ((UltraToggleEditorBase) this.chkUseCorpLic).Checked;
    tblStateSlRule.NoAllowPremiumAllocation = ((UltraToggleEditorBase) this.chkNotAllowPremiumAllocation).Checked;
    tblStateSlRule.Mail = this.rbMail.Checked;
    tblStateSlRule.Online = this.rbOnline.Checked;
    tblStateSlRule.Retain = this.rbRetain.Checked;
    tblStateSlRule.StatePubWhiteList = ((UltraToggleEditorBase) this.chkWhiteList).Checked;
    tblStateSlRule.StatePubExportList = ((UltraToggleEditorBase) this.chkExportList).Checked;
    if (!string.IsNullOrEmpty(((UltraCombo) this.cboDocumentFolder).Text))
      tblStateSlRule.FolderID = Conversions.ToInteger(((UltraCombo) this.cboDocumentFolder).Value);
    else
      tblStateSlRule.SetFolderIDNull();
    tblStateSlRule.SLImageData = this.GetBytesFromImage();
  }

  private void btnCancel_Click(object sender, EventArgs e)
  {
    this.ds.tblStateSLRules.RejectChanges();
    this.ds.tblSLStateRulesForms.RejectChanges();
    this.ds.tblStatesSLRequiredData.RejectChanges();
    this.EnableForm(false);
    this.AssignDataToForm();
  }

  private void ugForms_AfterRowInsert(object sender, RowEventArgs e)
  {
    if (((UltraGridBase) this.ugForms).ActiveRow == null)
      return;
    ((UltraGridBase) this.ugForms).ActiveRow.Cells["StateID"].Value = RuntimeHelpers.GetObjectValue(((UltraCombo) this.cboState).Value);
  }

  private void ugRequiredData_AfterRowInsert(object sender, RowEventArgs e)
  {
    if (((UltraGridBase) this.ugRequiredData).ActiveRow == null)
      return;
    ((UltraGridBase) this.ugRequiredData).ActiveRow.Cells["StateID"].Value = RuntimeHelpers.GetObjectValue(((UltraCombo) this.cboState).Value);
  }

  private void ddRequiredData_BeforeDropDown(object sender, CancelEventArgs e)
  {
    this.ds.lstStateSLRequiredData.DefaultView.Sort = "RequiredData ASC";
    if (((UltraCombo) this.cboState).Value == DBNull.Value || ((UltraCombo) this.cboState).Value == null)
      return;
    foreach (UltraGridRow row in ((UltraGridBase) this.ddRequiredData).Rows)
    {
      dsStateSLRules.tblStatesSLRequiredDataRow idRequiredDataId = this.ds.tblStatesSLRequiredData.FindByStateIDRequiredDataID(((UltraCombo) this.cboState).Value.ToString(), Conversions.ToInteger(row.Cells["ID"].Value));
      row.Hidden = idRequiredDataId != null;
    }
  }

  private void ddPolicyForms_BeforeDropDown(object sender, CancelEventArgs e)
  {
    this.ds.tblDocumentTemplates.DefaultView.Sort = "TemplateName ASC";
    if (((UltraCombo) this.cboState).Value == DBNull.Value || ((UltraCombo) this.cboState).Value == null)
      return;
    foreach (UltraGridRow row in ((UltraGridBase) this.ddTemplates).Rows)
    {
      dsStateSLRules.tblSLStateRulesFormsRow stateIdTemplateId = this.ds.tblSLStateRulesForms.FindByStateIDTemplateID(((UltraCombo) this.cboState).Value.ToString(), Conversions.ToInteger(row.Cells["TemplateID"].Value));
      row.Hidden = stateIdTemplateId != null;
    }
  }

  private void dbSave_ClickingCancel(object sender, CancelEventArgs e)
  {
    ((UltraCombo) this.cboState).Value = (object) null;
    ((Control) this.dbSave).Enabled = false;
  }

  private void dbSave_ClickingDelete(object sender, CancelEventArgs e)
  {
    if (this.ds.tblStateSLRules.Rows.Count <= 0)
      return;
    try
    {
      foreach (DataRow row in this.ds.tblSLStateRulesForms.Rows)
        row.Delete();
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    try
    {
      foreach (DataRow row in this.ds.tblStatesSLRequiredData.Rows)
        row.Delete();
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    if (this.picBox.Image != null)
      this.picBox.Image = (object) null;
    this.ds.tblStateSLRules[0].Delete();
    this.SaveData();
    this.EmptyTextBoxes();
    this.SetCheckBoxes(false);
    this.SetRadioButtons(false);
  }

  private void dbSaveClickingNew(object sender, CancelEventArgs e)
  {
    if (this.ds.tblStateSLRules.Rows.Count == 0)
    {
      dsStateSLRules.tblStateSLRulesRow row = this.ds.tblStateSLRules.NewtblStateSLRulesRow();
      row.StateID = ((UltraCombo) this.cboState).Value.ToString();
      this.ds.tblStateSLRules.AddtblStateSLRulesRow(row);
    }
    else
    {
      e.Cancel = true;
      this.dbSave.UIState = (UIState) 2;
    }
    this.EnableForm(true);
  }

  private bool IsSingleDataUseForFiling()
  {
    bool flag = true;
    int num = 0;
    try
    {
      foreach (dsStateSLRules.tblStatesSLRequiredDataRow row in this.ds.tblStatesSLRequiredData.Rows)
      {
        if (row.UseForFiling)
          ++num;
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    if (num > 1)
      flag = false;
    return flag;
  }

  private void dbSave_ClickingSave(object sender, CancelEventArgs e)
  {
    if (!this.IsSingleDataUseForFiling())
    {
      int num = (int) MessageBox.Show("An attempt was made to assign more than one required data to be used for marking an account as 'Filed'\n\nOnly a single required data is necessary to mark an account as 'Filed'", "Invalid Number Of Required Data Selected For Marking Account 'Filed'", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      e.Cancel = true;
    }
    else if (this.ds.tblStateSLRules.Count == 0)
    {
      e.Cancel = true;
    }
    else
    {
      this.AssignFormDataToRow();
      this.SaveData();
    }
  }

  private void dbSave_UIStateChanged(object sender, EventArgs e)
  {
    this.EnableForm(this.dbSave.UIState == 2);
  }

  private void btnPrevious_Click(object sender, EventArgs e)
  {
    this.ProcessStatesMovements((byte) 1);
  }

  private void btnNext_Click(object sender, EventArgs e) => this.ProcessStatesMovements((byte) 2);

  private void MoveStateValue(byte senderID)
  {
    object obj = (object) null;
    bool flag = false;
    try
    {
      foreach (dsStateSLRules.lstStatesRow row in this.ds.lstStates.Rows)
      {
        if (!flag && !((UltraCombo) this.cboState).Value.ToString().Equals(row.StateID))
          obj = (object) row.StateID;
        if (flag && senderID == (byte) 2)
        {
          obj = (object) row.StateID;
          break;
        }
        if (flag)
        {
          if (senderID == (byte) 1)
            break;
        }
        if (((UltraCombo) this.cboState).Value.ToString().Equals(row.StateID))
          flag = true;
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    ((UltraCombo) this.cboState).Value = RuntimeHelpers.GetObjectValue(obj);
  }

  private void ProcessStatesMovements(byte senderID)
  {
    object obj = (object) this.ds.lstStates[0].StateID.ToString();
    object stateId = (object) this.ds.lstStates[this.ds.lstStates.Count - 1].StateID;
    if (((UltraCombo) this.cboState).Value != null)
    {
      if (senderID == (byte) 1)
      {
        if (((UltraCombo) this.cboState).Value.ToString().Equals(obj.ToString()))
          ((UltraCombo) this.cboState).Value = RuntimeHelpers.GetObjectValue(stateId);
        else
          this.MoveStateValue((byte) 1);
      }
      else if (((UltraCombo) this.cboState).Value.ToString().Equals(stateId.ToString()))
        ((UltraCombo) this.cboState).Value = RuntimeHelpers.GetObjectValue(obj);
      else
        this.MoveStateValue((byte) 2);
    }
    else if (senderID == (byte) 1)
      ((UltraCombo) this.cboState).Value = RuntimeHelpers.GetObjectValue(stateId);
    else
      ((UltraCombo) this.cboState).Value = RuntimeHelpers.GetObjectValue(obj);
  }

  public byte[] GetBytesFromImage()
  {
    MemoryStream memoryStream = new MemoryStream();
    try
    {
      if (this.picBox.Image != null)
      {
        Image image = (Image) this.picBox.Image;
        Bitmap bitmap = (Bitmap) null;
        Graphics graphics = (Graphics) null;
        try
        {
          bitmap = new Bitmap(image.Width, image.Height, PixelFormat.Format24bppRgb);
          graphics = Graphics.FromImage((Image) bitmap);
          graphics.DrawImageUnscaled(image, new Point(0, 0));
          bitmap.Save((Stream) memoryStream, ImageFormat.Bmp);
        }
        finally
        {
          bitmap?.Dispose();
          graphics?.Dispose();
        }
      }
      return memoryStream.ToArray();
    }
    finally
    {
      memoryStream.Close();
    }
  }

  private void lnkLoadImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    if (this.fileDialog.ShowDialog() != DialogResult.OK)
      return;
    try
    {
      this.picBox.Image = (object) null;
      this.picBox.Image = (object) new Bitmap(this.fileDialog.FileName);
    }
    catch (ArgumentException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      this.picBox.Image = (object) null;
      int num = (int) MessageBox.Show("File may not be of the right picture type, or it maybe be corrupted.", "File Not Valid", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      ProjectData.ClearProjectError();
    }
  }

  private void lnkClearImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    this.picBox.Image = (object) null;
  }
}
