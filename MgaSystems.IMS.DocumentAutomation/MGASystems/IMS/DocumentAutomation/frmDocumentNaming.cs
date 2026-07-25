// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.DocumentAutomation.frmDocumentNaming
// Assembly: MgaSystems.IMS.DocumentAutomation, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: B33F9A76-E654-4386-A032-7A12D7CD66DE
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.DocumentAutomation.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinListView;
using Infragistics.Win.UltraWinScrollBar;
using MGASystems.Common;
using MGASystems.Common.ErrorHandling;
using MGASystems.Data;
using MGASystems.Tools;
using MGASystems.Tools.DBSaveUI;
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
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.DocumentAutomation;

[DesignerGenerated]
[SecureResource("{C3330283-1241-4905-B18E-E29C85BF49F8}", "Custom Document Naming / Descriptions", "Control naming/descriptions of documents based on specific events.", "Document System")]
public class frmDocumentNaming : FormBase
{
  private IContainer components;
  private DataTable _tags;
  public const string CanSpecifyCustomDocumentNames = "{C3330283-1241-4905-B18E-E29C85BF49F8}";
  private dsDocumentAutomation.tblDocumentFoldersDataTable _documentFolders;
  private bool _mouseClicked;
  private Point _lastPosition;
  private MGATextBox lastTextbox;
  private static Regex PropertyRegex = new Regex("(\\{\\{)*\\{(?<property>[_a-z,A-Z,0-9\\[\\]\\(\\).]+)(?<format>:[^}]*)?\\}(\\}\\})*");
  private static frmDocumentNaming.Settings _setting;

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
    UltraGridBand ultraGridBand1 = new UltraGridBand("lstLines", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("LineGuid");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("LineName");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("Active");
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
    Appearance appearance13 = new Appearance();
    UltraGridBand ultraGridBand2 = new UltraGridBand("lstStates", -1);
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("StateID");
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("State");
    Appearance appearance14 = new Appearance();
    Appearance appearance15 = new Appearance();
    Appearance appearance16 = new Appearance();
    Appearance appearance17 = new Appearance();
    Appearance appearance18 = new Appearance();
    Appearance appearance19 = new Appearance();
    Appearance appearance20 = new Appearance();
    Appearance appearance21 = new Appearance();
    Appearance appearance22 = new Appearance();
    Appearance appearance23 = new Appearance();
    Appearance appearance24 = new Appearance();
    Appearance appearance25 = new Appearance();
    UltraGridBand ultraGridBand3 = new UltraGridBand("tblCompanyLocations", -1);
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("CompanyLocationGuid");
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("LocationName");
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("CompanyGuid");
    Appearance appearance26 = new Appearance();
    Appearance appearance27 = new Appearance();
    Appearance appearance28 = new Appearance();
    Appearance appearance29 = new Appearance();
    Appearance appearance30 = new Appearance();
    Appearance appearance31 = new Appearance();
    Appearance appearance32 = new Appearance();
    Appearance appearance33 = new Appearance();
    Appearance appearance34 = new Appearance();
    Appearance appearance35 = new Appearance();
    Appearance appearance36 = new Appearance();
    Appearance appearance37 = new Appearance();
    UltraGridBand ultraGridBand4 = new UltraGridBand("tblCompany", -1);
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("CompanyGuid");
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("CompanyName");
    Appearance appearance38 = new Appearance();
    Appearance appearance39 = new Appearance();
    Appearance appearance40 = new Appearance();
    Appearance appearance41 = new Appearance();
    Appearance appearance42 = new Appearance();
    Appearance appearance43 = new Appearance();
    Appearance appearance44 = new Appearance();
    Appearance appearance45 = new Appearance();
    Appearance appearance46 = new Appearance();
    Appearance appearance47 = new Appearance();
    Appearance appearance48 = new Appearance();
    Appearance appearance49 = new Appearance();
    UltraGridBand ultraGridBand5 = new UltraGridBand("lstAutomationEvents", -1);
    UltraGridColumn ultraGridColumn11 = new UltraGridColumn("EventGuid");
    UltraGridColumn ultraGridColumn12 = new UltraGridColumn("EventName");
    Appearance appearance50 = new Appearance();
    Appearance appearance51 = new Appearance();
    Appearance appearance52 = new Appearance();
    Appearance appearance53 = new Appearance();
    Appearance appearance54 = new Appearance();
    Appearance appearance55 = new Appearance();
    Appearance appearance56 = new Appearance();
    Appearance appearance57 = new Appearance();
    Appearance appearance58 = new Appearance();
    Appearance appearance59 = new Appearance();
    Appearance appearance60 = new Appearance();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmDocumentNaming));
    Appearance appearance61 = new Appearance();
    UltraGridBand ultraGridBand6 = new UltraGridBand("lstLimitPackage", -1);
    UltraGridColumn ultraGridColumn13 = new UltraGridColumn("LimitToPackage");
    UltraGridColumn ultraGridColumn14 = new UltraGridColumn("Display");
    Appearance appearance62 = new Appearance();
    Appearance appearance63 = new Appearance();
    Appearance appearance64 = new Appearance();
    Appearance appearance65 = new Appearance();
    Appearance appearance66 = new Appearance();
    Appearance appearance67 = new Appearance();
    Appearance appearance68 = new Appearance();
    Appearance appearance69 = new Appearance();
    Appearance appearance70 = new Appearance();
    Appearance appearance71 = new Appearance();
    Appearance appearance72 = new Appearance();
    Appearance appearance73 = new Appearance();
    Appearance appearance74 = new Appearance();
    Appearance appearance75 = new Appearance();
    UltraGridBand ultraGridBand7 = new UltraGridBand("lstLines", -1);
    UltraGridColumn ultraGridColumn15 = new UltraGridColumn("LineGuid");
    UltraGridColumn ultraGridColumn16 = new UltraGridColumn("LineName");
    UltraGridColumn ultraGridColumn17 = new UltraGridColumn("Active");
    Appearance appearance76 = new Appearance();
    Appearance appearance77 = new Appearance();
    Appearance appearance78 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    Appearance appearance79 = new Appearance();
    Appearance appearance80 = new Appearance();
    Appearance appearance81 = new Appearance();
    Appearance appearance82 = new Appearance();
    UltraGridBand ultraGridBand8 = new UltraGridBand("tblCompanyDocumentNaming", -1);
    UltraGridColumn ultraGridColumn18 = new UltraGridColumn("ID");
    UltraGridColumn ultraGridColumn19 = new UltraGridColumn("EventGuid", -1, (object) "ddEvents");
    UltraGridColumn ultraGridColumn20 = new UltraGridColumn("CompanyGuid");
    UltraGridColumn ultraGridColumn21 = new UltraGridColumn("CompanyLocationGuid");
    UltraGridColumn ultraGridColumn22 = new UltraGridColumn("StateID");
    UltraGridColumn ultraGridColumn23 = new UltraGridColumn("LimitToPackage");
    UltraGridColumn ultraGridColumn24 = new UltraGridColumn("FilenameFormatString");
    UltraGridColumn ultraGridColumn25 = new UltraGridColumn("LineGuid");
    UltraGridColumn ultraGridColumn26 = new UltraGridColumn("FilenameDescriptionString");
    UltraGridColumn ultraGridColumn27 = new UltraGridColumn("FolderOverride");
    UltraGridColumn ultraGridColumn28 = new UltraGridColumn("officeGuid");
    Appearance appearance83 = new Appearance();
    Appearance appearance84 = new Appearance();
    Appearance appearance85 = new Appearance();
    Appearance appearance86 = new Appearance();
    Appearance appearance87 = new Appearance();
    Appearance appearance88 = new Appearance();
    Appearance appearance89 = new Appearance();
    Appearance appearance90 = new Appearance();
    Appearance appearance91 = new Appearance();
    Appearance appearance92 = new Appearance();
    Appearance appearance93 = new Appearance();
    Appearance appearance94 = new Appearance();
    Appearance appearance95 = new Appearance();
    this.cbSystemEvents = new MGASimpleComboBox();
    this.DsDocumentNaming = new dsDocumentNaming();
    this.DsDocumentNamingBindingSource = new BindingSource(this.components);
    this.cbCompanyFilter = new MGASimpleComboBox();
    this.cbLocationFilter = new MGASimpleComboBox();
    this.cbStateFilter = new MGASimpleComboBox();
    this.cbPackageFilter = new MGASimpleComboBox();
    this.cbLineFilter = new MGASimpleComboBox();
    this.cbOffice = new MGASimpleComboBox();
    this.ddLines = new UltraDropDown();
    this.ddStates = new UltraDropDown();
    this.ddLocations = new UltraDropDown();
    this.ddCompanies = new UltraDropDown();
    this.ddEvents = new UltraDropDown();
    this.err = new ErrorProvider(this.components);
    this.SqlSelectCommand1 = new SqlCommand();
    this.cnSql = new SqlConnection();
    this.SqlInsertCommand1 = new SqlCommand();
    this.SqlUpdateCommand1 = new SqlCommand();
    this.SqlDeleteCommand1 = new SqlCommand();
    this.daDocumentNaming = new SqlDataAdapter();
    this.ddPackage = new UltraDropDown();
    this.dbSave = new MGASystems.Tools.DBSaveUI.DBSaveUI();
    this.grpRuleInfo = new MGAGroupBox();
    this.lblOfficeLoc = new Label();
    this.dgAdditionalLines = new UltraGrid();
    this.Label21 = new Label();
    this.lnkChangeFolder = new LinkLabel();
    this.lnkShowTags = new LinkLabel();
    this.txtDescription = new MGATextBox();
    this.txtFolderName = new MGATextBox();
    this.txtFilename = new MGATextBox();
    this.Label2 = new Label();
    this.lblLimitTo = new Label();
    this.lblState = new Label();
    this.Label5 = new Label();
    this.Label1 = new Label();
    this.lblLine = new Label();
    this.lblFilename = new Label();
    this.lblLocation = new Label();
    this.lblCompany = new Label();
    this.pnlTagsHeader = new Panel();
    this.btnHideTags = new Button();
    this.lblTagsHeader = new Label();
    this.pnlTags = new Panel();
    this.lstAvailableTags = new UltraListView();
    this.ugCompDocNames = new UltraGrid();
    this.TblClientOfficesBindingSource = new BindingSource(this.components);
    ((ISupportInitialize) this.cbSystemEvents).BeginInit();
    this.DsDocumentNaming.BeginInit();
    ((ISupportInitialize) this.DsDocumentNamingBindingSource).BeginInit();
    ((ISupportInitialize) this.cbCompanyFilter).BeginInit();
    ((ISupportInitialize) this.cbLocationFilter).BeginInit();
    ((ISupportInitialize) this.cbStateFilter).BeginInit();
    ((ISupportInitialize) this.cbPackageFilter).BeginInit();
    ((ISupportInitialize) this.cbLineFilter).BeginInit();
    ((ISupportInitialize) this.cbOffice).BeginInit();
    ((ISupportInitialize) this.ddLines).BeginInit();
    ((ISupportInitialize) this.ddStates).BeginInit();
    ((ISupportInitialize) this.ddLocations).BeginInit();
    ((ISupportInitialize) this.ddCompanies).BeginInit();
    ((ISupportInitialize) this.ddEvents).BeginInit();
    ((ISupportInitialize) this.err).BeginInit();
    ((ISupportInitialize) this.ddPackage).BeginInit();
    ((ISupportInitialize) this.grpRuleInfo).BeginInit();
    ((Control) this.grpRuleInfo).SuspendLayout();
    ((ISupportInitialize) this.dgAdditionalLines).BeginInit();
    ((ISupportInitialize) this.txtDescription).BeginInit();
    ((ISupportInitialize) this.txtFolderName).BeginInit();
    ((ISupportInitialize) this.txtFilename).BeginInit();
    this.pnlTagsHeader.SuspendLayout();
    this.pnlTags.SuspendLayout();
    ((ISupportInitialize) this.lstAvailableTags).BeginInit();
    ((ISupportInitialize) this.ugCompDocNames).BeginInit();
    ((ISupportInitialize) this.TblClientOfficesBindingSource).BeginInit();
    this.SuspendLayout();
    this.cbSystemEvents.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.cbSystemEvents).DataBindings.Add(new Binding("Value", (object) this.DsDocumentNaming, "tblCompanyDocumentNaming.EventGuid", true, DataSourceUpdateMode.OnPropertyChanged));
    ((UltraGridBase) this.cbSystemEvents).DataMember = "lstAutomationEvents";
    ((UltraGridBase) this.cbSystemEvents).DataSource = (object) this.DsDocumentNamingBindingSource;
    ((UltraDropDownBase) this.cbSystemEvents).DisplayMember = "EventName";
    this.cbSystemEvents.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cbSystemEvents).Enabled = false;
    ((Control) this.cbSystemEvents).Location = new Point(121, 25);
    this.cbSystemEvents.MGAStyle = MGAStyles.Blue;
    ((Control) this.cbSystemEvents).Name = "cbSystemEvents";
    this.cbSystemEvents.NullText = "Choose an event...";
    ((Control) this.cbSystemEvents).Size = new Size(277, 20);
    ((Control) this.cbSystemEvents).TabIndex = 31 /*0x1F*/;
    ((UltraControlBase) this.cbSystemEvents).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cbSystemEvents).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cbSystemEvents).ValueMember = "EventGuid";
    this.DsDocumentNaming.DataSetName = "dsDocumentNaming";
    this.DsDocumentNaming.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.DsDocumentNamingBindingSource.DataSource = (object) this.DsDocumentNaming;
    this.DsDocumentNamingBindingSource.Position = 0;
    this.cbCompanyFilter.AllowNull = (DefaultableBoolean) 1;
    this.cbCompanyFilter.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.cbCompanyFilter).DataBindings.Add(new Binding("Value", (object) this.DsDocumentNaming, "tblCompanyDocumentNaming.CompanyGuid", true, DataSourceUpdateMode.OnPropertyChanged));
    ((UltraGridBase) this.cbCompanyFilter).DataMember = "tblCompany";
    ((UltraGridBase) this.cbCompanyFilter).DataSource = (object) this.DsDocumentNamingBindingSource;
    ((UltraDropDownBase) this.cbCompanyFilter).DisplayMember = "CompanyName";
    this.cbCompanyFilter.DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cbCompanyFilter).DropDownWidth = 500;
    ((Control) this.cbCompanyFilter).Enabled = false;
    ((Control) this.cbCompanyFilter).Location = new Point(121, 51);
    this.cbCompanyFilter.MGAStyle = MGAStyles.Blue;
    ((Control) this.cbCompanyFilter).Name = "cbCompanyFilter";
    this.cbCompanyFilter.NullText = "Any";
    ((Control) this.cbCompanyFilter).Size = new Size(277, 20);
    ((Control) this.cbCompanyFilter).TabIndex = 32 /*0x20*/;
    ((UltraControlBase) this.cbCompanyFilter).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cbCompanyFilter).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cbCompanyFilter).ValueMember = "CompanyGuid";
    this.cbLocationFilter.AllowNull = (DefaultableBoolean) 1;
    this.cbLocationFilter.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.cbLocationFilter).DataBindings.Add(new Binding("Value", (object) this.DsDocumentNaming, "tblCompanyDocumentNaming.CompanyLocationGuid", true, DataSourceUpdateMode.OnPropertyChanged));
    ((UltraGridBase) this.cbLocationFilter).DataMember = "tblCompanyLocations";
    ((UltraGridBase) this.cbLocationFilter).DataSource = (object) this.DsDocumentNamingBindingSource;
    ((UltraDropDownBase) this.cbLocationFilter).DisplayMember = "LocationName";
    this.cbLocationFilter.DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cbLocationFilter).DropDownWidth = 500;
    ((Control) this.cbLocationFilter).Enabled = false;
    ((Control) this.cbLocationFilter).Location = new Point(121, 77);
    this.cbLocationFilter.MGAStyle = MGAStyles.Blue;
    ((Control) this.cbLocationFilter).Name = "cbLocationFilter";
    this.cbLocationFilter.NullText = "Any";
    ((Control) this.cbLocationFilter).Size = new Size(277, 20);
    ((Control) this.cbLocationFilter).TabIndex = 32 /*0x20*/;
    ((UltraControlBase) this.cbLocationFilter).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cbLocationFilter).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cbLocationFilter).ValueMember = "CompanyLocationGuid";
    this.cbStateFilter.AllowNull = (DefaultableBoolean) 1;
    this.cbStateFilter.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.cbStateFilter).DataBindings.Add(new Binding("Value", (object) this.DsDocumentNaming, "tblCompanyDocumentNaming.StateID", true, DataSourceUpdateMode.OnPropertyChanged));
    ((UltraGridBase) this.cbStateFilter).DataMember = "lstStates";
    ((UltraGridBase) this.cbStateFilter).DataSource = (object) this.DsDocumentNamingBindingSource;
    ((UltraDropDownBase) this.cbStateFilter).DisplayMember = "State";
    this.cbStateFilter.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cbStateFilter).Enabled = false;
    ((Control) this.cbStateFilter).Location = new Point(121, 102);
    this.cbStateFilter.MGAStyle = MGAStyles.Blue;
    ((Control) this.cbStateFilter).Name = "cbStateFilter";
    this.cbStateFilter.NullText = "Any";
    ((Control) this.cbStateFilter).Size = new Size(277, 20);
    ((Control) this.cbStateFilter).TabIndex = 34;
    ((UltraControlBase) this.cbStateFilter).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cbStateFilter).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cbStateFilter).ValueMember = "StateID";
    this.cbPackageFilter.AllowNull = (DefaultableBoolean) 1;
    this.cbPackageFilter.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.cbPackageFilter).DataBindings.Add(new Binding("Value", (object) this.DsDocumentNaming, "tblCompanyDocumentNaming.LimitToPackage", true, DataSourceUpdateMode.OnPropertyChanged));
    ((UltraGridBase) this.cbPackageFilter).DataMember = "lstLimitPackage";
    ((UltraGridBase) this.cbPackageFilter).DataSource = (object) this.DsDocumentNamingBindingSource;
    ((UltraDropDownBase) this.cbPackageFilter).DisplayMember = "Display";
    this.cbPackageFilter.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cbPackageFilter).Enabled = false;
    ((Control) this.cbPackageFilter).Location = new Point(463, 51);
    this.cbPackageFilter.MGAStyle = MGAStyles.Blue;
    ((Control) this.cbPackageFilter).Name = "cbPackageFilter";
    this.cbPackageFilter.NullText = "Both (Package/Monoline)";
    ((Control) this.cbPackageFilter).Size = new Size(224 /*0xE0*/, 20);
    ((Control) this.cbPackageFilter).TabIndex = 34;
    ((UltraControlBase) this.cbPackageFilter).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cbPackageFilter).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cbPackageFilter).ValueMember = "LimitToPackage";
    this.cbLineFilter.AllowNull = (DefaultableBoolean) 1;
    this.cbLineFilter.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.cbLineFilter).DataBindings.Add(new Binding("Value", (object) this.DsDocumentNaming, "tblCompanyDocumentNaming.LineGuid", true, DataSourceUpdateMode.OnPropertyChanged));
    ((UltraGridBase) this.cbLineFilter).DataMember = "lstLines";
    ((UltraGridBase) this.cbLineFilter).DataSource = (object) this.DsDocumentNamingBindingSource;
    ((UltraDropDownBase) this.cbLineFilter).DisplayMember = "LineName";
    this.cbLineFilter.DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cbLineFilter).DropDownWidth = 300;
    ((Control) this.cbLineFilter).Enabled = false;
    ((Control) this.cbLineFilter).Location = new Point(463, 25);
    this.cbLineFilter.MGAStyle = MGAStyles.Blue;
    ((Control) this.cbLineFilter).Name = "cbLineFilter";
    this.cbLineFilter.NullText = "Any";
    ((Control) this.cbLineFilter).Size = new Size(224 /*0xE0*/, 20);
    ((Control) this.cbLineFilter).TabIndex = 33;
    ((UltraControlBase) this.cbLineFilter).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cbLineFilter).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cbLineFilter).ValueMember = "LineGuid";
    this.cbOffice.AllowNull = (DefaultableBoolean) 1;
    this.cbOffice.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.cbOffice).DataBindings.Add(new Binding("Value", (object) this.DsDocumentNaming, "tblCompanyDocumentNaming.officeGuid", true));
    ((UltraGridBase) this.cbOffice).DataMember = "tblClientOffices";
    ((UltraGridBase) this.cbOffice).DataSource = (object) this.DsDocumentNamingBindingSource;
    ((UltraDropDownBase) this.cbOffice).DisplayMember = "location";
    this.cbOffice.DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cbOffice).DropDownWidth = 500;
    ((Control) this.cbOffice).Enabled = false;
    ((Control) this.cbOffice).Location = new Point(121, 128 /*0x80*/);
    this.cbOffice.MGAStyle = MGAStyles.Blue;
    ((Control) this.cbOffice).Name = "cbOffice";
    this.cbOffice.NullText = "Any";
    ((Control) this.cbOffice).Size = new Size(277, 20);
    ((Control) this.cbOffice).TabIndex = 44;
    ((UltraControlBase) this.cbOffice).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cbOffice).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cbOffice).ValueMember = "officeGuid";
    ((UltraGridBase) this.ddLines).DataMember = "lstLines";
    ((UltraGridBase) this.ddLines).DataSource = (object) this.DsDocumentNamingBindingSource;
    appearance1.BackColor = SystemColors.Window;
    appearance1.BorderColor = SystemColors.InactiveCaption;
    ((UltraGridBase) this.ddLines).DisplayLayout.Appearance = (AppearanceBase) appearance1;
    ((HeaderBase) ultraGridColumn1.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn1.Header.VisiblePosition = 0;
    ((HeaderBase) ultraGridColumn2.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn2.Header.VisiblePosition = 1;
    ((HeaderBase) ultraGridColumn3.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn3.Header.VisiblePosition = 2;
    ultraGridBand1.Columns.AddRange(new object[3]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3
    });
    ((UltraGridBase) this.ddLines).DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    ((UltraGridBase) this.ddLines).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.ddLines).DisplayLayout.CaptionVisible = (DefaultableBoolean) 2;
    appearance2.BackColor = SystemColors.ActiveBorder;
    appearance2.BackColor2 = SystemColors.ControlDark;
    appearance2.BackGradientStyle = (GradientStyle) 2;
    appearance2.BorderColor = SystemColors.Window;
    ((SpecialBoxBase) ((UltraGridBase) this.ddLines).DisplayLayout.GroupByBox).Appearance = (AppearanceBase) appearance2;
    appearance3.ForeColor = SystemColors.GrayText;
    ((UltraGridBase) this.ddLines).DisplayLayout.GroupByBox.BandLabelAppearance = (AppearanceBase) appearance3;
    ((SpecialBoxBase) ((UltraGridBase) this.ddLines).DisplayLayout.GroupByBox).BorderStyle = (UIElementBorderStyle) 4;
    appearance4.BackColor = SystemColors.ControlLightLight;
    appearance4.BackColor2 = SystemColors.Control;
    appearance4.BackGradientStyle = (GradientStyle) 3;
    appearance4.ForeColor = SystemColors.GrayText;
    ((UltraGridBase) this.ddLines).DisplayLayout.GroupByBox.PromptAppearance = (AppearanceBase) appearance4;
    ((UltraGridBase) this.ddLines).DisplayLayout.MaxColScrollRegions = 1;
    ((UltraGridBase) this.ddLines).DisplayLayout.MaxRowScrollRegions = 1;
    appearance5.BackColor = SystemColors.Window;
    appearance5.ForeColor = SystemColors.ControlText;
    ((UltraGridBase) this.ddLines).DisplayLayout.Override.ActiveCellAppearance = (AppearanceBase) appearance5;
    appearance6.BackColor = SystemColors.Highlight;
    appearance6.ForeColor = SystemColors.HighlightText;
    ((UltraGridBase) this.ddLines).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance6;
    ((UltraGridBase) this.ddLines).DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 2;
    ((UltraGridBase) this.ddLines).DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 2;
    appearance7.BackColor = SystemColors.Window;
    ((UltraGridBase) this.ddLines).DisplayLayout.Override.CardAreaAppearance = (AppearanceBase) appearance7;
    appearance8.BorderColor = Color.Silver;
    appearance8.TextTrimming = (TextTrimming) 3;
    ((UltraGridBase) this.ddLines).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance8;
    ((UltraGridBase) this.ddLines).DisplayLayout.Override.CellClickAction = (CellClickAction) 4;
    ((UltraGridBase) this.ddLines).DisplayLayout.Override.CellPadding = 0;
    appearance9.BackColor = SystemColors.Control;
    appearance9.BackColor2 = SystemColors.ControlDark;
    appearance9.BackGradientAlignment = (GradientAlignment) 1;
    appearance9.BackGradientStyle = (GradientStyle) 3;
    appearance9.BorderColor = SystemColors.Window;
    ((UltraGridBase) this.ddLines).DisplayLayout.Override.GroupByRowAppearance = (AppearanceBase) appearance9;
    ((AppearanceBase) appearance10).TextHAlignAsString = "Left";
    ((UltraGridBase) this.ddLines).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance10;
    ((UltraGridBase) this.ddLines).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 3;
    ((UltraGridBase) this.ddLines).DisplayLayout.Override.HeaderStyle = (HeaderStyle) 2;
    appearance11.BackColor = SystemColors.Window;
    appearance11.BorderColor = Color.Silver;
    ((UltraGridBase) this.ddLines).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance11;
    ((UltraGridBase) this.ddLines).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance12.BackColor = SystemColors.ControlLight;
    ((UltraGridBase) this.ddLines).DisplayLayout.Override.TemplateAddRowAppearance = (AppearanceBase) appearance12;
    ((UltraGridBase) this.ddLines).DisplayLayout.ScrollBounds = (ScrollBounds) 0;
    ((UltraGridBase) this.ddLines).DisplayLayout.ScrollStyle = (ScrollStyle) 1;
    ((UltraGridBase) this.ddLines).DisplayLayout.ViewStyleBand = (ViewStyleBand) 2;
    ((UltraDropDownBase) this.ddLines).DisplayMember = "LineName";
    ((Control) this.ddLines).Location = new Point(0, 385);
    ((Control) this.ddLines).Name = "ddLines";
    ((Control) this.ddLines).Size = new Size(158, 80 /*0x50*/);
    ((Control) this.ddLines).TabIndex = 157;
    ((UltraDropDownBase) this.ddLines).ValueMember = "LineGuid";
    ((Control) this.ddLines).Visible = false;
    ((UltraGridBase) this.ddStates).DataMember = "lstStates";
    ((UltraGridBase) this.ddStates).DataSource = (object) this.DsDocumentNamingBindingSource;
    appearance13.BackColor = SystemColors.Window;
    appearance13.BorderColor = SystemColors.InactiveCaption;
    ((UltraGridBase) this.ddStates).DisplayLayout.Appearance = (AppearanceBase) appearance13;
    ((HeaderBase) ultraGridColumn4.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn4.Header.VisiblePosition = 0;
    ((HeaderBase) ultraGridColumn5.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn5.Header.VisiblePosition = 1;
    ultraGridBand2.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn4,
      (object) ultraGridColumn5
    });
    ((UltraGridBase) this.ddStates).DisplayLayout.BandsSerializer.Add((object) ultraGridBand2);
    ((UltraGridBase) this.ddStates).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.ddStates).DisplayLayout.CaptionVisible = (DefaultableBoolean) 2;
    appearance14.BackColor = SystemColors.ActiveBorder;
    appearance14.BackColor2 = SystemColors.ControlDark;
    appearance14.BackGradientStyle = (GradientStyle) 2;
    appearance14.BorderColor = SystemColors.Window;
    ((SpecialBoxBase) ((UltraGridBase) this.ddStates).DisplayLayout.GroupByBox).Appearance = (AppearanceBase) appearance14;
    appearance15.ForeColor = SystemColors.GrayText;
    ((UltraGridBase) this.ddStates).DisplayLayout.GroupByBox.BandLabelAppearance = (AppearanceBase) appearance15;
    ((SpecialBoxBase) ((UltraGridBase) this.ddStates).DisplayLayout.GroupByBox).BorderStyle = (UIElementBorderStyle) 4;
    appearance16.BackColor = SystemColors.ControlLightLight;
    appearance16.BackColor2 = SystemColors.Control;
    appearance16.BackGradientStyle = (GradientStyle) 3;
    appearance16.ForeColor = SystemColors.GrayText;
    ((UltraGridBase) this.ddStates).DisplayLayout.GroupByBox.PromptAppearance = (AppearanceBase) appearance16;
    ((UltraGridBase) this.ddStates).DisplayLayout.MaxColScrollRegions = 1;
    ((UltraGridBase) this.ddStates).DisplayLayout.MaxRowScrollRegions = 1;
    appearance17.BackColor = SystemColors.Window;
    appearance17.ForeColor = SystemColors.ControlText;
    ((UltraGridBase) this.ddStates).DisplayLayout.Override.ActiveCellAppearance = (AppearanceBase) appearance17;
    appearance18.BackColor = SystemColors.Highlight;
    appearance18.ForeColor = SystemColors.HighlightText;
    ((UltraGridBase) this.ddStates).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance18;
    ((UltraGridBase) this.ddStates).DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 2;
    ((UltraGridBase) this.ddStates).DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 2;
    appearance19.BackColor = SystemColors.Window;
    ((UltraGridBase) this.ddStates).DisplayLayout.Override.CardAreaAppearance = (AppearanceBase) appearance19;
    appearance20.BorderColor = Color.Silver;
    appearance20.TextTrimming = (TextTrimming) 3;
    ((UltraGridBase) this.ddStates).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance20;
    ((UltraGridBase) this.ddStates).DisplayLayout.Override.CellClickAction = (CellClickAction) 4;
    ((UltraGridBase) this.ddStates).DisplayLayout.Override.CellPadding = 0;
    appearance21.BackColor = SystemColors.Control;
    appearance21.BackColor2 = SystemColors.ControlDark;
    appearance21.BackGradientAlignment = (GradientAlignment) 1;
    appearance21.BackGradientStyle = (GradientStyle) 3;
    appearance21.BorderColor = SystemColors.Window;
    ((UltraGridBase) this.ddStates).DisplayLayout.Override.GroupByRowAppearance = (AppearanceBase) appearance21;
    ((AppearanceBase) appearance22).TextHAlignAsString = "Left";
    ((UltraGridBase) this.ddStates).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance22;
    ((UltraGridBase) this.ddStates).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 3;
    ((UltraGridBase) this.ddStates).DisplayLayout.Override.HeaderStyle = (HeaderStyle) 2;
    appearance23.BackColor = SystemColors.Window;
    appearance23.BorderColor = Color.Silver;
    ((UltraGridBase) this.ddStates).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance23;
    ((UltraGridBase) this.ddStates).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance24.BackColor = SystemColors.ControlLight;
    ((UltraGridBase) this.ddStates).DisplayLayout.Override.TemplateAddRowAppearance = (AppearanceBase) appearance24;
    ((UltraGridBase) this.ddStates).DisplayLayout.ScrollBounds = (ScrollBounds) 0;
    ((UltraGridBase) this.ddStates).DisplayLayout.ScrollStyle = (ScrollStyle) 1;
    ((UltraGridBase) this.ddStates).DisplayLayout.ViewStyleBand = (ViewStyleBand) 2;
    ((UltraDropDownBase) this.ddStates).DisplayMember = "State";
    ((Control) this.ddStates).Location = new Point(50, 385);
    ((Control) this.ddStates).Name = "ddStates";
    ((Control) this.ddStates).Size = new Size(205, 80 /*0x50*/);
    ((Control) this.ddStates).TabIndex = 156;
    ((UltraDropDownBase) this.ddStates).ValueMember = "StateID";
    ((Control) this.ddStates).Visible = false;
    ((UltraGridBase) this.ddLocations).DataMember = "tblCompanyLocations";
    ((UltraGridBase) this.ddLocations).DataSource = (object) this.DsDocumentNamingBindingSource;
    appearance25.BackColor = SystemColors.Window;
    appearance25.BorderColor = SystemColors.InactiveCaption;
    ((UltraGridBase) this.ddLocations).DisplayLayout.Appearance = (AppearanceBase) appearance25;
    ((HeaderBase) ultraGridColumn6.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn6.Header.VisiblePosition = 0;
    ((HeaderBase) ultraGridColumn7.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn7.Header.VisiblePosition = 1;
    ((HeaderBase) ultraGridColumn8.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn8.Header.VisiblePosition = 2;
    ultraGridBand3.Columns.AddRange(new object[3]
    {
      (object) ultraGridColumn6,
      (object) ultraGridColumn7,
      (object) ultraGridColumn8
    });
    ((UltraGridBase) this.ddLocations).DisplayLayout.BandsSerializer.Add((object) ultraGridBand3);
    ((UltraGridBase) this.ddLocations).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.ddLocations).DisplayLayout.CaptionVisible = (DefaultableBoolean) 2;
    appearance26.BackColor = SystemColors.ActiveBorder;
    appearance26.BackColor2 = SystemColors.ControlDark;
    appearance26.BackGradientStyle = (GradientStyle) 2;
    appearance26.BorderColor = SystemColors.Window;
    ((SpecialBoxBase) ((UltraGridBase) this.ddLocations).DisplayLayout.GroupByBox).Appearance = (AppearanceBase) appearance26;
    appearance27.ForeColor = SystemColors.GrayText;
    ((UltraGridBase) this.ddLocations).DisplayLayout.GroupByBox.BandLabelAppearance = (AppearanceBase) appearance27;
    ((SpecialBoxBase) ((UltraGridBase) this.ddLocations).DisplayLayout.GroupByBox).BorderStyle = (UIElementBorderStyle) 4;
    appearance28.BackColor = SystemColors.ControlLightLight;
    appearance28.BackColor2 = SystemColors.Control;
    appearance28.BackGradientStyle = (GradientStyle) 3;
    appearance28.ForeColor = SystemColors.GrayText;
    ((UltraGridBase) this.ddLocations).DisplayLayout.GroupByBox.PromptAppearance = (AppearanceBase) appearance28;
    ((UltraGridBase) this.ddLocations).DisplayLayout.MaxColScrollRegions = 1;
    ((UltraGridBase) this.ddLocations).DisplayLayout.MaxRowScrollRegions = 1;
    appearance29.BackColor = SystemColors.Window;
    appearance29.ForeColor = SystemColors.ControlText;
    ((UltraGridBase) this.ddLocations).DisplayLayout.Override.ActiveCellAppearance = (AppearanceBase) appearance29;
    appearance30.BackColor = SystemColors.Highlight;
    appearance30.ForeColor = SystemColors.HighlightText;
    ((UltraGridBase) this.ddLocations).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance30;
    ((UltraGridBase) this.ddLocations).DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 2;
    ((UltraGridBase) this.ddLocations).DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 2;
    appearance31.BackColor = SystemColors.Window;
    ((UltraGridBase) this.ddLocations).DisplayLayout.Override.CardAreaAppearance = (AppearanceBase) appearance31;
    appearance32.BorderColor = Color.Silver;
    appearance32.TextTrimming = (TextTrimming) 3;
    ((UltraGridBase) this.ddLocations).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance32;
    ((UltraGridBase) this.ddLocations).DisplayLayout.Override.CellClickAction = (CellClickAction) 4;
    ((UltraGridBase) this.ddLocations).DisplayLayout.Override.CellPadding = 0;
    appearance33.BackColor = SystemColors.Control;
    appearance33.BackColor2 = SystemColors.ControlDark;
    appearance33.BackGradientAlignment = (GradientAlignment) 1;
    appearance33.BackGradientStyle = (GradientStyle) 3;
    appearance33.BorderColor = SystemColors.Window;
    ((UltraGridBase) this.ddLocations).DisplayLayout.Override.GroupByRowAppearance = (AppearanceBase) appearance33;
    ((AppearanceBase) appearance34).TextHAlignAsString = "Left";
    ((UltraGridBase) this.ddLocations).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance34;
    ((UltraGridBase) this.ddLocations).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 3;
    ((UltraGridBase) this.ddLocations).DisplayLayout.Override.HeaderStyle = (HeaderStyle) 2;
    appearance35.BackColor = SystemColors.Window;
    appearance35.BorderColor = Color.Silver;
    ((UltraGridBase) this.ddLocations).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance35;
    ((UltraGridBase) this.ddLocations).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance36.BackColor = SystemColors.ControlLight;
    ((UltraGridBase) this.ddLocations).DisplayLayout.Override.TemplateAddRowAppearance = (AppearanceBase) appearance36;
    ((UltraGridBase) this.ddLocations).DisplayLayout.ScrollBounds = (ScrollBounds) 0;
    ((UltraGridBase) this.ddLocations).DisplayLayout.ScrollStyle = (ScrollStyle) 1;
    ((UltraGridBase) this.ddLocations).DisplayLayout.ViewStyleBand = (ViewStyleBand) 2;
    ((UltraDropDownBase) this.ddLocations).DisplayMember = "LocationName";
    ((Control) this.ddLocations).Location = new Point(199, 385);
    ((Control) this.ddLocations).Name = "ddLocations";
    ((Control) this.ddLocations).Size = new Size(148, 80 /*0x50*/);
    ((Control) this.ddLocations).TabIndex = 155;
    ((UltraDropDownBase) this.ddLocations).ValueMember = "CompanyLocationGuid";
    ((Control) this.ddLocations).Visible = false;
    ((UltraGridBase) this.ddCompanies).DataMember = "tblCompany";
    ((UltraGridBase) this.ddCompanies).DataSource = (object) this.DsDocumentNamingBindingSource;
    appearance37.BackColor = SystemColors.Window;
    appearance37.BorderColor = SystemColors.InactiveCaption;
    ((UltraGridBase) this.ddCompanies).DisplayLayout.Appearance = (AppearanceBase) appearance37;
    ((HeaderBase) ultraGridColumn9.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn9.Header.VisiblePosition = 0;
    ((HeaderBase) ultraGridColumn10.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn10.Header.VisiblePosition = 1;
    ultraGridBand4.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn9,
      (object) ultraGridColumn10
    });
    ((UltraGridBase) this.ddCompanies).DisplayLayout.BandsSerializer.Add((object) ultraGridBand4);
    ((UltraGridBase) this.ddCompanies).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.ddCompanies).DisplayLayout.CaptionVisible = (DefaultableBoolean) 2;
    appearance38.BackColor = SystemColors.ActiveBorder;
    appearance38.BackColor2 = SystemColors.ControlDark;
    appearance38.BackGradientStyle = (GradientStyle) 2;
    appearance38.BorderColor = SystemColors.Window;
    ((SpecialBoxBase) ((UltraGridBase) this.ddCompanies).DisplayLayout.GroupByBox).Appearance = (AppearanceBase) appearance38;
    appearance39.ForeColor = SystemColors.GrayText;
    ((UltraGridBase) this.ddCompanies).DisplayLayout.GroupByBox.BandLabelAppearance = (AppearanceBase) appearance39;
    ((SpecialBoxBase) ((UltraGridBase) this.ddCompanies).DisplayLayout.GroupByBox).BorderStyle = (UIElementBorderStyle) 4;
    appearance40.BackColor = SystemColors.ControlLightLight;
    appearance40.BackColor2 = SystemColors.Control;
    appearance40.BackGradientStyle = (GradientStyle) 3;
    appearance40.ForeColor = SystemColors.GrayText;
    ((UltraGridBase) this.ddCompanies).DisplayLayout.GroupByBox.PromptAppearance = (AppearanceBase) appearance40;
    ((UltraGridBase) this.ddCompanies).DisplayLayout.MaxColScrollRegions = 1;
    ((UltraGridBase) this.ddCompanies).DisplayLayout.MaxRowScrollRegions = 1;
    appearance41.BackColor = SystemColors.Window;
    appearance41.ForeColor = SystemColors.ControlText;
    ((UltraGridBase) this.ddCompanies).DisplayLayout.Override.ActiveCellAppearance = (AppearanceBase) appearance41;
    appearance42.BackColor = SystemColors.Highlight;
    appearance42.ForeColor = SystemColors.HighlightText;
    ((UltraGridBase) this.ddCompanies).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance42;
    ((UltraGridBase) this.ddCompanies).DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 2;
    ((UltraGridBase) this.ddCompanies).DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 2;
    appearance43.BackColor = SystemColors.Window;
    ((UltraGridBase) this.ddCompanies).DisplayLayout.Override.CardAreaAppearance = (AppearanceBase) appearance43;
    appearance44.BorderColor = Color.Silver;
    appearance44.TextTrimming = (TextTrimming) 3;
    ((UltraGridBase) this.ddCompanies).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance44;
    ((UltraGridBase) this.ddCompanies).DisplayLayout.Override.CellClickAction = (CellClickAction) 4;
    ((UltraGridBase) this.ddCompanies).DisplayLayout.Override.CellPadding = 0;
    appearance45.BackColor = SystemColors.Control;
    appearance45.BackColor2 = SystemColors.ControlDark;
    appearance45.BackGradientAlignment = (GradientAlignment) 1;
    appearance45.BackGradientStyle = (GradientStyle) 3;
    appearance45.BorderColor = SystemColors.Window;
    ((UltraGridBase) this.ddCompanies).DisplayLayout.Override.GroupByRowAppearance = (AppearanceBase) appearance45;
    ((AppearanceBase) appearance46).TextHAlignAsString = "Left";
    ((UltraGridBase) this.ddCompanies).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance46;
    ((UltraGridBase) this.ddCompanies).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 3;
    ((UltraGridBase) this.ddCompanies).DisplayLayout.Override.HeaderStyle = (HeaderStyle) 2;
    appearance47.BackColor = SystemColors.Window;
    appearance47.BorderColor = Color.Silver;
    ((UltraGridBase) this.ddCompanies).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance47;
    ((UltraGridBase) this.ddCompanies).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance48.BackColor = SystemColors.ControlLight;
    ((UltraGridBase) this.ddCompanies).DisplayLayout.Override.TemplateAddRowAppearance = (AppearanceBase) appearance48;
    ((UltraGridBase) this.ddCompanies).DisplayLayout.ScrollBounds = (ScrollBounds) 0;
    ((UltraGridBase) this.ddCompanies).DisplayLayout.ScrollStyle = (ScrollStyle) 1;
    ((UltraGridBase) this.ddCompanies).DisplayLayout.ViewStyleBand = (ViewStyleBand) 2;
    ((UltraDropDownBase) this.ddCompanies).DisplayMember = "CompanyName";
    ((Control) this.ddCompanies).Location = new Point(316, 385);
    ((Control) this.ddCompanies).Name = "ddCompanies";
    ((Control) this.ddCompanies).Size = new Size(148, 80 /*0x50*/);
    ((Control) this.ddCompanies).TabIndex = 155;
    ((UltraDropDownBase) this.ddCompanies).ValueMember = "CompanyGuid";
    ((Control) this.ddCompanies).Visible = false;
    ((UltraGridBase) this.ddEvents).DataMember = "lstAutomationEvents";
    ((UltraGridBase) this.ddEvents).DataSource = (object) this.DsDocumentNamingBindingSource;
    appearance49.BackColor = SystemColors.Window;
    appearance49.BorderColor = SystemColors.InactiveCaption;
    ((UltraGridBase) this.ddEvents).DisplayLayout.Appearance = (AppearanceBase) appearance49;
    ((HeaderBase) ultraGridColumn11.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn11.Header.VisiblePosition = 0;
    ((HeaderBase) ultraGridColumn12.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn12.Header.VisiblePosition = 1;
    ultraGridBand5.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn11,
      (object) ultraGridColumn12
    });
    ((UltraGridBase) this.ddEvents).DisplayLayout.BandsSerializer.Add((object) ultraGridBand5);
    ((UltraGridBase) this.ddEvents).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.ddEvents).DisplayLayout.CaptionVisible = (DefaultableBoolean) 2;
    appearance50.BackColor = SystemColors.ActiveBorder;
    appearance50.BackColor2 = SystemColors.ControlDark;
    appearance50.BackGradientStyle = (GradientStyle) 2;
    appearance50.BorderColor = SystemColors.Window;
    ((SpecialBoxBase) ((UltraGridBase) this.ddEvents).DisplayLayout.GroupByBox).Appearance = (AppearanceBase) appearance50;
    appearance51.ForeColor = SystemColors.GrayText;
    ((UltraGridBase) this.ddEvents).DisplayLayout.GroupByBox.BandLabelAppearance = (AppearanceBase) appearance51;
    ((SpecialBoxBase) ((UltraGridBase) this.ddEvents).DisplayLayout.GroupByBox).BorderStyle = (UIElementBorderStyle) 4;
    appearance52.BackColor = SystemColors.ControlLightLight;
    appearance52.BackColor2 = SystemColors.Control;
    appearance52.BackGradientStyle = (GradientStyle) 3;
    appearance52.ForeColor = SystemColors.GrayText;
    ((UltraGridBase) this.ddEvents).DisplayLayout.GroupByBox.PromptAppearance = (AppearanceBase) appearance52;
    ((UltraGridBase) this.ddEvents).DisplayLayout.MaxColScrollRegions = 1;
    ((UltraGridBase) this.ddEvents).DisplayLayout.MaxRowScrollRegions = 1;
    appearance53.BackColor = SystemColors.Window;
    appearance53.ForeColor = SystemColors.ControlText;
    ((UltraGridBase) this.ddEvents).DisplayLayout.Override.ActiveCellAppearance = (AppearanceBase) appearance53;
    appearance54.BackColor = SystemColors.Highlight;
    appearance54.ForeColor = SystemColors.HighlightText;
    ((UltraGridBase) this.ddEvents).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance54;
    ((UltraGridBase) this.ddEvents).DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 2;
    ((UltraGridBase) this.ddEvents).DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 2;
    appearance55.BackColor = SystemColors.Window;
    ((UltraGridBase) this.ddEvents).DisplayLayout.Override.CardAreaAppearance = (AppearanceBase) appearance55;
    appearance56.BorderColor = Color.Silver;
    appearance56.TextTrimming = (TextTrimming) 3;
    ((UltraGridBase) this.ddEvents).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance56;
    ((UltraGridBase) this.ddEvents).DisplayLayout.Override.CellClickAction = (CellClickAction) 4;
    ((UltraGridBase) this.ddEvents).DisplayLayout.Override.CellPadding = 0;
    appearance57.BackColor = SystemColors.Control;
    appearance57.BackColor2 = SystemColors.ControlDark;
    appearance57.BackGradientAlignment = (GradientAlignment) 1;
    appearance57.BackGradientStyle = (GradientStyle) 3;
    appearance57.BorderColor = SystemColors.Window;
    ((UltraGridBase) this.ddEvents).DisplayLayout.Override.GroupByRowAppearance = (AppearanceBase) appearance57;
    ((AppearanceBase) appearance58).TextHAlignAsString = "Left";
    ((UltraGridBase) this.ddEvents).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance58;
    ((UltraGridBase) this.ddEvents).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 3;
    ((UltraGridBase) this.ddEvents).DisplayLayout.Override.HeaderStyle = (HeaderStyle) 2;
    appearance59.BackColor = SystemColors.Window;
    appearance59.BorderColor = Color.Silver;
    ((UltraGridBase) this.ddEvents).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance59;
    ((UltraGridBase) this.ddEvents).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance60.BackColor = SystemColors.ControlLight;
    ((UltraGridBase) this.ddEvents).DisplayLayout.Override.TemplateAddRowAppearance = (AppearanceBase) appearance60;
    ((UltraGridBase) this.ddEvents).DisplayLayout.ScrollBounds = (ScrollBounds) 0;
    ((UltraGridBase) this.ddEvents).DisplayLayout.ScrollStyle = (ScrollStyle) 1;
    ((UltraGridBase) this.ddEvents).DisplayLayout.ViewStyleBand = (ViewStyleBand) 2;
    ((UltraDropDownBase) this.ddEvents).DisplayMember = "EventName";
    ((Control) this.ddEvents).Location = new Point(420, 385);
    ((Control) this.ddEvents).Name = "ddEvents";
    ((Control) this.ddEvents).Size = new Size(148, 80 /*0x50*/);
    ((Control) this.ddEvents).TabIndex = 155;
    ((UltraDropDownBase) this.ddEvents).ValueMember = "EventGuid";
    ((Control) this.ddEvents).Visible = false;
    this.err.ContainerControl = (ContainerControl) this;
    this.SqlSelectCommand1.CommandText = "SELECT * FROM tblCompanyDocumentNaming";
    this.SqlSelectCommand1.Connection = this.cnSql;
    this.cnSql.FireInfoMessageEventOnUserErrors = false;
    this.SqlInsertCommand1.CommandText = componentResourceManager.GetString("SqlInsertCommand1.CommandText");
    this.SqlInsertCommand1.Connection = this.cnSql;
    this.SqlInsertCommand1.Parameters.AddRange(new SqlParameter[10]
    {
      new SqlParameter("@EventGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "EventGuid"),
      new SqlParameter("@LineGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "LineGuid"),
      new SqlParameter("@CompanyGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "CompanyGuid"),
      new SqlParameter("@CompanyLocationGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "CompanyLocationGuid"),
      new SqlParameter("@StateID", SqlDbType.Char, 2, "StateID"),
      new SqlParameter("@LimitToPackage", SqlDbType.Bit, 1, "LimitToPackage"),
      new SqlParameter("@FilenameFormatString", SqlDbType.VarChar, 250, "FilenameFormatString"),
      new SqlParameter("@FilenameDescriptionString", SqlDbType.VarChar, 250, "FilenameDescriptionString"),
      new SqlParameter("@FolderOverride", SqlDbType.Int, 4, "FolderOverride"),
      new SqlParameter("@officeGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "officeGuid")
    });
    this.SqlUpdateCommand1.CommandText = componentResourceManager.GetString("SqlUpdateCommand1.CommandText");
    this.SqlUpdateCommand1.Connection = this.cnSql;
    this.SqlUpdateCommand1.Parameters.AddRange(new SqlParameter[11]
    {
      new SqlParameter("@EventGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "EventGuid"),
      new SqlParameter("@LineGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "LineGuid"),
      new SqlParameter("@CompanyGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "CompanyGuid"),
      new SqlParameter("@CompanyLocationGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "CompanyLocationGuid"),
      new SqlParameter("@StateID", SqlDbType.Char, 2, "StateID"),
      new SqlParameter("@LimitToPackage", SqlDbType.Bit, 1, "LimitToPackage"),
      new SqlParameter("@FilenameFormatString", SqlDbType.VarChar, 250, "FilenameFormatString"),
      new SqlParameter("@FilenameDescriptionString", SqlDbType.VarChar, 250, "FilenameDescriptionString"),
      new SqlParameter("@FolderOverride", SqlDbType.Int, 4, "FolderOverride"),
      new SqlParameter("@Original_ID", SqlDbType.Int, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "ID", DataRowVersion.Original, (object) null),
      new SqlParameter("@officeGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "officeGuid")
    });
    this.SqlDeleteCommand1.CommandText = "DELETE FROM [tblCompanyDocumentNamingLines] WHERE ([DocumentNamingID] = @Original_ID) DELETE FROM [tblCompanyDocumentNaming] WHERE ([ID] = @Original_ID)";
    this.SqlDeleteCommand1.Connection = this.cnSql;
    this.SqlDeleteCommand1.Parameters.AddRange(new SqlParameter[1]
    {
      new SqlParameter("@Original_ID", SqlDbType.Int, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "ID", DataRowVersion.Original, (object) null)
    });
    this.daDocumentNaming.DeleteCommand = this.SqlDeleteCommand1;
    this.daDocumentNaming.InsertCommand = this.SqlInsertCommand1;
    this.daDocumentNaming.SelectCommand = this.SqlSelectCommand1;
    this.daDocumentNaming.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblCompanyDocumentNaming", new DataColumnMapping[11]
      {
        new DataColumnMapping("ID", "ID"),
        new DataColumnMapping("EventGuid", "EventGuid"),
        new DataColumnMapping("LineGuid", "LineGuid"),
        new DataColumnMapping("CompanyGuid", "CompanyGuid"),
        new DataColumnMapping("CompanyLocationGuid", "CompanyLocationGuid"),
        new DataColumnMapping("StateID", "StateID"),
        new DataColumnMapping("LimitToPackage", "LimitToPackage"),
        new DataColumnMapping("FilenameFormatString", "FilenameFormatString"),
        new DataColumnMapping("FilenameDescriptionString", "FilenameDescriptionString"),
        new DataColumnMapping("FolderOverride", "FolderOverride"),
        new DataColumnMapping("officeGuid", "officeGuid")
      })
    });
    this.daDocumentNaming.UpdateCommand = this.SqlUpdateCommand1;
    ((UltraGridBase) this.ddPackage).DataMember = "lstLimitPackage";
    ((UltraGridBase) this.ddPackage).DataSource = (object) this.DsDocumentNamingBindingSource;
    appearance61.BackColor = SystemColors.Window;
    appearance61.BorderColor = SystemColors.InactiveCaption;
    ((UltraGridBase) this.ddPackage).DisplayLayout.Appearance = (AppearanceBase) appearance61;
    ((HeaderBase) ultraGridColumn13.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn13.Header.VisiblePosition = 0;
    ((HeaderBase) ultraGridColumn14.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn14.Header.VisiblePosition = 1;
    ultraGridBand6.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn13,
      (object) ultraGridColumn14
    });
    ((UltraGridBase) this.ddPackage).DisplayLayout.BandsSerializer.Add((object) ultraGridBand6);
    ((UltraGridBase) this.ddPackage).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.ddPackage).DisplayLayout.CaptionVisible = (DefaultableBoolean) 2;
    appearance62.BackColor = SystemColors.ActiveBorder;
    appearance62.BackColor2 = SystemColors.ControlDark;
    appearance62.BackGradientStyle = (GradientStyle) 2;
    appearance62.BorderColor = SystemColors.Window;
    ((SpecialBoxBase) ((UltraGridBase) this.ddPackage).DisplayLayout.GroupByBox).Appearance = (AppearanceBase) appearance62;
    appearance63.ForeColor = SystemColors.GrayText;
    ((UltraGridBase) this.ddPackage).DisplayLayout.GroupByBox.BandLabelAppearance = (AppearanceBase) appearance63;
    ((SpecialBoxBase) ((UltraGridBase) this.ddPackage).DisplayLayout.GroupByBox).BorderStyle = (UIElementBorderStyle) 4;
    appearance64.BackColor = SystemColors.ControlLightLight;
    appearance64.BackColor2 = SystemColors.Control;
    appearance64.BackGradientStyle = (GradientStyle) 3;
    appearance64.ForeColor = SystemColors.GrayText;
    ((UltraGridBase) this.ddPackage).DisplayLayout.GroupByBox.PromptAppearance = (AppearanceBase) appearance64;
    ((UltraGridBase) this.ddPackage).DisplayLayout.MaxColScrollRegions = 1;
    ((UltraGridBase) this.ddPackage).DisplayLayout.MaxRowScrollRegions = 1;
    appearance65.BackColor = SystemColors.Window;
    appearance65.ForeColor = SystemColors.ControlText;
    ((UltraGridBase) this.ddPackage).DisplayLayout.Override.ActiveCellAppearance = (AppearanceBase) appearance65;
    appearance66.BackColor = SystemColors.Highlight;
    appearance66.ForeColor = SystemColors.HighlightText;
    ((UltraGridBase) this.ddPackage).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance66;
    ((UltraGridBase) this.ddPackage).DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 2;
    ((UltraGridBase) this.ddPackage).DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 2;
    appearance67.BackColor = SystemColors.Window;
    ((UltraGridBase) this.ddPackage).DisplayLayout.Override.CardAreaAppearance = (AppearanceBase) appearance67;
    appearance68.BorderColor = Color.Silver;
    appearance68.TextTrimming = (TextTrimming) 3;
    ((UltraGridBase) this.ddPackage).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance68;
    ((UltraGridBase) this.ddPackage).DisplayLayout.Override.CellClickAction = (CellClickAction) 4;
    ((UltraGridBase) this.ddPackage).DisplayLayout.Override.CellPadding = 0;
    appearance69.BackColor = SystemColors.Control;
    appearance69.BackColor2 = SystemColors.ControlDark;
    appearance69.BackGradientAlignment = (GradientAlignment) 1;
    appearance69.BackGradientStyle = (GradientStyle) 3;
    appearance69.BorderColor = SystemColors.Window;
    ((UltraGridBase) this.ddPackage).DisplayLayout.Override.GroupByRowAppearance = (AppearanceBase) appearance69;
    ((AppearanceBase) appearance70).TextHAlignAsString = "Left";
    ((UltraGridBase) this.ddPackage).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance70;
    ((UltraGridBase) this.ddPackage).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 3;
    ((UltraGridBase) this.ddPackage).DisplayLayout.Override.HeaderStyle = (HeaderStyle) 2;
    appearance71.BackColor = SystemColors.Window;
    appearance71.BorderColor = Color.Silver;
    ((UltraGridBase) this.ddPackage).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance71;
    ((UltraGridBase) this.ddPackage).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance72.BackColor = SystemColors.ControlLight;
    ((UltraGridBase) this.ddPackage).DisplayLayout.Override.TemplateAddRowAppearance = (AppearanceBase) appearance72;
    ((UltraGridBase) this.ddPackage).DisplayLayout.ScrollBounds = (ScrollBounds) 0;
    ((UltraGridBase) this.ddPackage).DisplayLayout.ScrollStyle = (ScrollStyle) 1;
    ((UltraGridBase) this.ddPackage).DisplayLayout.ViewStyleBand = (ViewStyleBand) 2;
    ((UltraDropDownBase) this.ddPackage).DisplayMember = "Display";
    ((Control) this.ddPackage).Location = new Point(505, 385);
    ((Control) this.ddPackage).Name = "ddPackage";
    ((Control) this.ddPackage).Size = new Size(148, 80 /*0x50*/);
    ((Control) this.ddPackage).TabIndex = 155;
    ((UltraDropDownBase) this.ddPackage).ValueMember = "LimitToPackage";
    ((Control) this.ddPackage).Visible = false;
    this.dbSave.AutoQueryRowCountOnLoad = false;
    this.dbSave.EditStyle = EditStyle.ShowEditButton;
    this.dbSave.FreezeEvents = false;
    this.dbSave.Location = new Point(286, 231);
    this.dbSave.Name = "dbSave";
    this.dbSave.Size = new Size(112 /*0x70*/, 40);
    this.dbSave.TabIndex = 38;
    ((Control) this.grpRuleInfo).Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    appearance73.BackColor = Color.FromArgb(239, 247, 253);
    appearance73.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.grpRuleInfo.ContentAreaAppearance = (AppearanceBase) appearance73;
    ((Control) this.grpRuleInfo).Controls.Add((Control) this.lblOfficeLoc);
    ((Control) this.grpRuleInfo).Controls.Add((Control) this.cbOffice);
    ((Control) this.grpRuleInfo).Controls.Add((Control) this.dgAdditionalLines);
    ((Control) this.grpRuleInfo).Controls.Add((Control) this.Label21);
    ((Control) this.grpRuleInfo).Controls.Add((Control) this.lnkChangeFolder);
    ((Control) this.grpRuleInfo).Controls.Add((Control) this.dbSave);
    ((Control) this.grpRuleInfo).Controls.Add((Control) this.lnkShowTags);
    ((Control) this.grpRuleInfo).Controls.Add((Control) this.txtDescription);
    ((Control) this.grpRuleInfo).Controls.Add((Control) this.txtFolderName);
    ((Control) this.grpRuleInfo).Controls.Add((Control) this.txtFilename);
    ((Control) this.grpRuleInfo).Controls.Add((Control) this.cbSystemEvents);
    ((Control) this.grpRuleInfo).Controls.Add((Control) this.cbPackageFilter);
    ((Control) this.grpRuleInfo).Controls.Add((Control) this.cbStateFilter);
    ((Control) this.grpRuleInfo).Controls.Add((Control) this.Label2);
    ((Control) this.grpRuleInfo).Controls.Add((Control) this.lblLimitTo);
    ((Control) this.grpRuleInfo).Controls.Add((Control) this.lblState);
    ((Control) this.grpRuleInfo).Controls.Add((Control) this.Label5);
    ((Control) this.grpRuleInfo).Controls.Add((Control) this.Label1);
    ((Control) this.grpRuleInfo).Controls.Add((Control) this.lblLine);
    ((Control) this.grpRuleInfo).Controls.Add((Control) this.lblFilename);
    ((Control) this.grpRuleInfo).Controls.Add((Control) this.lblLocation);
    ((Control) this.grpRuleInfo).Controls.Add((Control) this.lblCompany);
    ((Control) this.grpRuleInfo).Controls.Add((Control) this.cbLocationFilter);
    ((Control) this.grpRuleInfo).Controls.Add((Control) this.cbCompanyFilter);
    ((Control) this.grpRuleInfo).Controls.Add((Control) this.cbLineFilter);
    appearance74.ForeColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.grpRuleInfo.HeaderAppearance = (AppearanceBase) appearance74;
    ((Control) this.grpRuleInfo).Location = new Point(7, 253);
    ((Control) this.grpRuleInfo).Name = "grpRuleInfo";
    ((Control) this.grpRuleInfo).Size = new Size(734, 281);
    ((Control) this.grpRuleInfo).TabIndex = 39;
    this.grpRuleInfo.Text = "Rule Information";
    this.grpRuleInfo.ViewStyle = (GroupBoxViewStyle) 2;
    this.lblOfficeLoc.AutoSize = true;
    this.lblOfficeLoc.BackColor = Color.Transparent;
    this.lblOfficeLoc.Location = new Point(35, 133);
    this.lblOfficeLoc.Name = "lblOfficeLoc";
    this.lblOfficeLoc.Size = new Size(82, 13);
    this.lblOfficeLoc.TabIndex = 45;
    this.lblOfficeLoc.Text = "Office Location:";
    ((Control) this.dgAdditionalLines).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraControlBase) this.dgAdditionalLines).Cursor = Cursors.Hand;
    ((UltraGridBase) this.dgAdditionalLines).DataMember = "lstLines";
    ((UltraGridBase) this.dgAdditionalLines).DataSource = (object) this.DsDocumentNamingBindingSource;
    appearance75.BackColor = Color.White;
    appearance75.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.dgAdditionalLines).DisplayLayout.Appearance = (AppearanceBase) appearance75;
    ((UltraGridBase) this.dgAdditionalLines).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ((HeaderBase) ultraGridColumn15.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn15.Header.VisiblePosition = 0;
    ultraGridColumn15.Hidden = true;
    ultraGridColumn15.Width = 186;
    ((HeaderBase) ultraGridColumn16.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn16.Header.VisiblePosition = 1;
    ultraGridColumn16.Width = 205;
    ((HeaderBase) ultraGridColumn17.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn17.Header.VisiblePosition = 2;
    ultraGridColumn17.Width = 97;
    ultraGridBand7.Columns.AddRange(new object[3]
    {
      (object) ultraGridColumn15,
      (object) ultraGridColumn16,
      (object) ultraGridColumn17
    });
    ((UltraGridBase) this.dgAdditionalLines).DisplayLayout.BandsSerializer.Add((object) ultraGridBand7);
    ((UltraGridBase) this.dgAdditionalLines).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance76.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((UltraGridBase) this.dgAdditionalLines).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance76;
    ((UltraGridBase) this.dgAdditionalLines).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.dgAdditionalLines).DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 1;
    appearance77.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.dgAdditionalLines).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance77;
    ((UltraGridBase) this.dgAdditionalLines).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 2;
    appearance78.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.dgAdditionalLines).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance78;
    ((UltraGridBase) this.dgAdditionalLines).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((UltraGridBase) this.dgAdditionalLines).DisplayLayout.Override.RowSpacingAfter = 5;
    ((UltraGridBase) this.dgAdditionalLines).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance76;
    scrollBarLook.ViewStyle = (ScrollBarViewStyle) 3;
    ((UltraGridBase) this.dgAdditionalLines).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((UltraGridBase) this.dgAdditionalLines).DisplayLayout.ScrollStyle = (ScrollStyle) 1;
    ((Control) this.dgAdditionalLines).Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.dgAdditionalLines).Location = new Point(413, 95);
    ((Control) this.dgAdditionalLines).Name = "dgAdditionalLines";
    ((Control) this.dgAdditionalLines).Size = new Size(304, 170);
    ((Control) this.dgAdditionalLines).TabIndex = 43;
    ((UltraControlBase) this.dgAdditionalLines).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dgAdditionalLines).UseOsThemes = (DefaultableBoolean) 2;
    this.Label21.AutoSize = true;
    this.Label21.BackColor = Color.Transparent;
    this.Label21.Location = new Point(410, 79);
    this.Label21.Name = "Label21";
    this.Label21.Size = new Size(130, 13);
    this.Label21.TabIndex = 42;
    this.Label21.Text = "Additional Lines: (optional)";
    this.Label21.TextAlign = ContentAlignment.MiddleRight;
    this.lnkChangeFolder.AutoSize = true;
    this.lnkChangeFolder.BackColor = Color.Transparent;
    this.lnkChangeFolder.Enabled = false;
    this.lnkChangeFolder.Location = new Point(320, 200);
    this.lnkChangeFolder.Name = "lnkChangeFolder";
    this.lnkChangeFolder.Size = new Size(78, 13);
    this.lnkChangeFolder.TabIndex = 41;
    this.lnkChangeFolder.TabStop = true;
    this.lnkChangeFolder.Text = "(change folder)";
    this.lnkChangeFolder.TextAlign = ContentAlignment.MiddleLeft;
    this.lnkShowTags.AutoSize = true;
    this.lnkShowTags.BackColor = Color.Transparent;
    this.lnkShowTags.Enabled = false;
    this.lnkShowTags.Location = new Point(118, 232);
    this.lnkShowTags.Name = "lnkShowTags";
    this.lnkShowTags.Size = new Size(77, 13);
    this.lnkShowTags.TabIndex = 40;
    this.lnkShowTags.TabStop = true;
    this.lnkShowTags.Text = "Available Tags";
    appearance79.BackColor = Color.White;
    appearance79.BorderColor = Color.Gray;
    appearance79.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtDescription).Appearance = (AppearanceBase) appearance79;
    ((TextEditorControlBase) this.txtDescription).BackColor = Color.White;
    ((Control) this.txtDescription).DataBindings.Add(new Binding("Value", (object) this.DsDocumentNaming, "tblCompanyDocumentNaming.FilenameDescriptionString", true, DataSourceUpdateMode.OnPropertyChanged));
    ((Control) this.txtDescription).Enabled = false;
    ((Control) this.txtDescription).Location = new Point(121, 175);
    ((Control) this.txtDescription).Name = "txtDescription";
    ((Control) this.txtDescription).Size = new Size(277, 19);
    ((Control) this.txtDescription).TabIndex = 39;
    ((UltraControlBase) this.txtDescription).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtDescription).UseOsThemes = (DefaultableBoolean) 2;
    appearance80.BackColor = Color.White;
    appearance80.BorderColor = Color.Gray;
    appearance80.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtFolderName).Appearance = (AppearanceBase) appearance80;
    ((TextEditorControlBase) this.txtFolderName).BackColor = Color.White;
    ((Control) this.txtFolderName).Enabled = false;
    ((Control) this.txtFolderName).Location = new Point(121, 197);
    ((Control) this.txtFolderName).Name = "txtFolderName";
    ((Control) this.txtFolderName).Size = new Size(193, 19);
    ((Control) this.txtFolderName).TabIndex = 39;
    ((UltraControlBase) this.txtFolderName).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtFolderName).UseOsThemes = (DefaultableBoolean) 2;
    appearance81.BackColor = Color.White;
    appearance81.BorderColor = Color.Gray;
    appearance81.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtFilename).Appearance = (AppearanceBase) appearance81;
    ((TextEditorControlBase) this.txtFilename).BackColor = Color.White;
    ((Control) this.txtFilename).DataBindings.Add(new Binding("Value", (object) this.DsDocumentNaming, "tblCompanyDocumentNaming.FilenameFormatString", true, DataSourceUpdateMode.OnPropertyChanged));
    ((Control) this.txtFilename).Enabled = false;
    ((Control) this.txtFilename).Location = new Point(121, 153);
    ((Control) this.txtFilename).Name = "txtFilename";
    ((Control) this.txtFilename).Size = new Size(277, 19);
    ((Control) this.txtFilename).TabIndex = 39;
    ((UltraControlBase) this.txtFilename).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtFilename).UseOsThemes = (DefaultableBoolean) 2;
    this.Label2.AutoSize = true;
    this.Label2.BackColor = Color.Transparent;
    this.Label2.Location = new Point(74, 200);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(39, 13);
    this.Label2.TabIndex = 37;
    this.Label2.Text = "Folder:";
    this.lblLimitTo.AutoSize = true;
    this.lblLimitTo.BackColor = Color.Transparent;
    this.lblLimitTo.Location = new Point(410, 54);
    this.lblLimitTo.Name = "lblLimitTo";
    this.lblLimitTo.Size = new Size(47, 13);
    this.lblLimitTo.TabIndex = 37;
    this.lblLimitTo.Text = "Limit To:";
    this.lblState.AutoSize = true;
    this.lblState.BackColor = Color.Transparent;
    this.lblState.Location = new Point(80 /*0x50*/, 104);
    this.lblState.Name = "lblState";
    this.lblState.Size = new Size(35, 13);
    this.lblState.TabIndex = 37;
    this.lblState.Text = "State:";
    this.Label5.AutoSize = true;
    this.Label5.BackColor = Color.Transparent;
    this.Label5.Location = new Point(40, 28);
    this.Label5.Name = "Label5";
    this.Label5.Size = new Size(75, 13);
    this.Label5.TabIndex = 30;
    this.Label5.Text = "System Event:";
    this.Label5.TextAlign = ContentAlignment.MiddleRight;
    this.Label1.AutoSize = true;
    this.Label1.BackColor = Color.Transparent;
    this.Label1.Location = new Point(50, 178);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(63 /*0x3F*/, 13);
    this.Label1.TabIndex = 35;
    this.Label1.Text = "Description:";
    this.lblLine.AutoSize = true;
    this.lblLine.BackColor = Color.Transparent;
    this.lblLine.Location = new Point(427, 28);
    this.lblLine.Name = "lblLine";
    this.lblLine.Size = new Size(30, 13);
    this.lblLine.TabIndex = 36;
    this.lblLine.Text = "Line:";
    this.lblFilename.AutoSize = true;
    this.lblFilename.BackColor = Color.Transparent;
    this.lblFilename.Location = new Point(61, 156);
    this.lblFilename.Name = "lblFilename";
    this.lblFilename.Size = new Size(52, 13);
    this.lblFilename.TabIndex = 35;
    this.lblFilename.Text = "Filename:";
    this.lblLocation.AutoSize = true;
    this.lblLocation.BackColor = Color.Transparent;
    this.lblLocation.Location = new Point(64 /*0x40*/, 79);
    this.lblLocation.Name = "lblLocation";
    this.lblLocation.Size = new Size(51, 13);
    this.lblLocation.TabIndex = 35;
    this.lblLocation.Text = "Location:";
    this.lblCompany.AutoSize = true;
    this.lblCompany.BackColor = Color.Transparent;
    this.lblCompany.Location = new Point(61, 54);
    this.lblCompany.Name = "lblCompany";
    this.lblCompany.Size = new Size(54, 13);
    this.lblCompany.TabIndex = 35;
    this.lblCompany.Text = "Company:";
    this.pnlTagsHeader.BackColor = SystemColors.Highlight;
    this.pnlTagsHeader.Controls.Add((Control) this.btnHideTags);
    this.pnlTagsHeader.Controls.Add((Control) this.lblTagsHeader);
    this.pnlTagsHeader.Dock = DockStyle.Top;
    this.pnlTagsHeader.Location = new Point(0, 0);
    this.pnlTagsHeader.Name = "pnlTagsHeader";
    this.pnlTagsHeader.Size = new Size(150, 20);
    this.pnlTagsHeader.TabIndex = 0;
    this.btnHideTags.Cursor = Cursors.Hand;
    this.btnHideTags.Dock = DockStyle.Right;
    this.btnHideTags.FlatStyle = FlatStyle.Flat;
    this.btnHideTags.Font = new Font("Microsoft Sans Serif", 6.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.btnHideTags.Location = new Point(130, 0);
    this.btnHideTags.Margin = new Padding(0);
    this.btnHideTags.Name = "btnHideTags";
    this.btnHideTags.Size = new Size(20, 20);
    this.btnHideTags.TabIndex = 38;
    this.btnHideTags.Text = "X";
    this.btnHideTags.UseVisualStyleBackColor = true;
    this.lblTagsHeader.AutoSize = true;
    this.lblTagsHeader.BackColor = Color.Transparent;
    this.lblTagsHeader.Location = new Point(3, 3);
    this.lblTagsHeader.Name = "lblTagsHeader";
    this.lblTagsHeader.Size = new Size(80 /*0x50*/, 13);
    this.lblTagsHeader.TabIndex = 37;
    this.lblTagsHeader.Text = "Available Tags:";
    this.lblTagsHeader.TextAlign = ContentAlignment.MiddleLeft;
    this.pnlTags.BorderStyle = BorderStyle.FixedSingle;
    this.pnlTags.Controls.Add((Control) this.lstAvailableTags);
    this.pnlTags.Controls.Add((Control) this.pnlTagsHeader);
    this.pnlTags.Location = new Point(208 /*0xD0*/, 391);
    this.pnlTags.Name = "pnlTags";
    this.pnlTags.Size = new Size(152, 100);
    this.pnlTags.TabIndex = 158;
    this.pnlTags.Visible = false;
    this.lstAvailableTags.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.lstAvailableTags).Dock = DockStyle.Fill;
    this.lstAvailableTags.ItemSettings.AllowEdit = (DefaultableBoolean) 2;
    ((Control) this.lstAvailableTags).Location = new Point(0, 20);
    ((Control) this.lstAvailableTags).Name = "lstAvailableTags";
    this.lstAvailableTags.ShowGroups = false;
    ((Control) this.lstAvailableTags).Size = new Size(150, 78);
    ((Control) this.lstAvailableTags).TabIndex = 1;
    this.lstAvailableTags.View = (UltraListViewStyle) 2;
    this.lstAvailableTags.ViewSettingsDetails.AllowColumnMoving = false;
    this.lstAvailableTags.ViewSettingsDetails.AllowColumnSizing = false;
    this.lstAvailableTags.ViewSettingsDetails.AllowColumnSorting = false;
    this.lstAvailableTags.ViewSettingsDetails.AutoFitColumns = (AutoFitColumns) 2;
    ((UltraListViewSettingsBase) this.lstAvailableTags.ViewSettingsDetails).ImageSize = new Size(0, 0);
    ((UltraListViewSettingsBase) this.lstAvailableTags.ViewSettingsList).ImageSize = new Size(0, 0);
    this.lstAvailableTags.ViewSettingsList.MultiColumn = false;
    ((Control) this.ugCompDocNames).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraGridBase) this.ugCompDocNames).DataMember = "tblCompanyDocumentNaming";
    ((UltraGridBase) this.ugCompDocNames).DataSource = (object) this.DsDocumentNaming;
    appearance82.BackColor = Color.White;
    appearance82.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.ugCompDocNames).DisplayLayout.Appearance = (AppearanceBase) appearance82;
    ((UltraGridBase) this.ugCompDocNames).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ((HeaderBase) ultraGridColumn18.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn18.Header.VisiblePosition = 0;
    ultraGridColumn18.Hidden = true;
    ultraGridColumn18.Width = 26;
    ultraGridColumn19.CellActivation = (Activation) 3;
    ultraGridColumn19.EditorComponent = (Component) this.cbSystemEvents;
    ((HeaderBase) ultraGridColumn19.Header).Caption = "Event";
    ((HeaderBase) ultraGridColumn19.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn19.Header.VisiblePosition = 1;
    ultraGridColumn19.Width = 135;
    ultraGridColumn20.CellActivation = (Activation) 3;
    ultraGridColumn20.EditorComponent = (Component) this.cbCompanyFilter;
    ((HeaderBase) ultraGridColumn20.Header).Caption = "Company";
    ((HeaderBase) ultraGridColumn20.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn20.Header.VisiblePosition = 2;
    ultraGridColumn20.NullText = "Any";
    ultraGridColumn20.Width = 102;
    ultraGridColumn21.CellActivation = (Activation) 3;
    ultraGridColumn21.EditorComponent = (Component) this.cbLocationFilter;
    ((HeaderBase) ultraGridColumn21.Header).Caption = "Location";
    ((HeaderBase) ultraGridColumn21.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn21.Header.VisiblePosition = 3;
    ultraGridColumn21.NullText = "Any";
    ultraGridColumn21.Width = 95;
    ultraGridColumn22.CellActivation = (Activation) 3;
    ultraGridColumn22.EditorComponent = (Component) this.cbStateFilter;
    ((HeaderBase) ultraGridColumn22.Header).Caption = "State";
    ((HeaderBase) ultraGridColumn22.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn22.Header.VisiblePosition = 4;
    ultraGridColumn22.NullText = "Any";
    ultraGridColumn22.Width = 42;
    ultraGridColumn23.CellActivation = (Activation) 3;
    ultraGridColumn23.EditorComponent = (Component) this.cbPackageFilter;
    ((HeaderBase) ultraGridColumn23.Header).Caption = "Limit";
    ((HeaderBase) ultraGridColumn23.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn23.Header.VisiblePosition = 5;
    ultraGridColumn23.NullText = "Both";
    ultraGridColumn23.Width = 37;
    ultraGridColumn24.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn24.Header).Caption = "Filename";
    ((HeaderBase) ultraGridColumn24.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn24.Header.VisiblePosition = 7;
    ultraGridColumn24.NullText = "Any";
    ultraGridColumn24.Width = 50;
    ultraGridColumn25.CellActivation = (Activation) 3;
    ultraGridColumn25.EditorComponent = (Component) this.cbLineFilter;
    ((HeaderBase) ultraGridColumn25.Header).Caption = "Line";
    ((HeaderBase) ultraGridColumn25.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn25.Header.VisiblePosition = 6;
    ultraGridColumn25.NullText = "Any";
    ultraGridColumn25.Width = 93;
    ultraGridColumn26.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn26.Header).Caption = "Description";
    ((HeaderBase) ultraGridColumn26.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn26.Header.VisiblePosition = 8;
    ultraGridColumn26.NullText = "N/A";
    ultraGridColumn26.Width = 56;
    ultraGridColumn27.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn27.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn27.Header.VisiblePosition = 9;
    ultraGridColumn27.Hidden = true;
    ultraGridColumn27.Width = 82;
    ultraGridColumn28.CellActivation = (Activation) 3;
    ultraGridColumn28.EditorComponent = (Component) this.cbOffice;
    ((HeaderBase) ultraGridColumn28.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn28.Header.VisiblePosition = 10;
    ultraGridColumn28.Width = 122;
    ultraGridBand8.Columns.AddRange(new object[11]
    {
      (object) ultraGridColumn18,
      (object) ultraGridColumn19,
      (object) ultraGridColumn20,
      (object) ultraGridColumn21,
      (object) ultraGridColumn22,
      (object) ultraGridColumn23,
      (object) ultraGridColumn24,
      (object) ultraGridColumn25,
      (object) ultraGridColumn26,
      (object) ultraGridColumn27,
      (object) ultraGridColumn28
    });
    ((UltraGridBase) this.ugCompDocNames).DisplayLayout.BandsSerializer.Add((object) ultraGridBand8);
    ((UltraGridBase) this.ugCompDocNames).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance83.BackColor = Color.LightSteelBlue;
    appearance83.FontData.SizeInPoints = 10f;
    appearance83.ForeColor = Color.FromArgb(21, 66, 139);
    ((UltraGridBase) this.ugCompDocNames).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance83;
    ((UltraGridBase) this.ugCompDocNames).DisplayLayout.CaptionVisible = (DefaultableBoolean) 2;
    appearance84.BackColor = SystemColors.ActiveBorder;
    appearance84.BackColor2 = SystemColors.ControlDark;
    appearance84.BackGradientStyle = (GradientStyle) 2;
    appearance84.BorderColor = SystemColors.Window;
    ((SpecialBoxBase) ((UltraGridBase) this.ugCompDocNames).DisplayLayout.GroupByBox).Appearance = (AppearanceBase) appearance84;
    appearance85.ForeColor = SystemColors.GrayText;
    ((UltraGridBase) this.ugCompDocNames).DisplayLayout.GroupByBox.BandLabelAppearance = (AppearanceBase) appearance85;
    ((SpecialBoxBase) ((UltraGridBase) this.ugCompDocNames).DisplayLayout.GroupByBox).BorderStyle = (UIElementBorderStyle) 4;
    ((SpecialBoxBase) ((UltraGridBase) this.ugCompDocNames).DisplayLayout.GroupByBox).Hidden = true;
    appearance86.BackColor = SystemColors.ControlLightLight;
    appearance86.BackColor2 = SystemColors.Control;
    appearance86.BackGradientStyle = (GradientStyle) 3;
    appearance86.ForeColor = SystemColors.GrayText;
    ((UltraGridBase) this.ugCompDocNames).DisplayLayout.GroupByBox.PromptAppearance = (AppearanceBase) appearance86;
    ((UltraGridBase) this.ugCompDocNames).DisplayLayout.MaxColScrollRegions = 1;
    ((UltraGridBase) this.ugCompDocNames).DisplayLayout.MaxRowScrollRegions = 1;
    appearance87.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance87.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance87.ForeColor = Color.Black;
    ((UltraGridBase) this.ugCompDocNames).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance87;
    ((UltraGridBase) this.ugCompDocNames).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.ugCompDocNames).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.ugCompDocNames).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((UltraGridBase) this.ugCompDocNames).DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 2;
    ((UltraGridBase) this.ugCompDocNames).DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 2;
    appearance88.BackColor = SystemColors.Window;
    ((UltraGridBase) this.ugCompDocNames).DisplayLayout.Override.CardAreaAppearance = (AppearanceBase) appearance88;
    appearance89.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugCompDocNames).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance89;
    appearance90.BackColor = SystemColors.Control;
    appearance90.BackColor2 = SystemColors.ControlDark;
    appearance90.BackGradientAlignment = (GradientAlignment) 1;
    appearance90.BackGradientStyle = (GradientStyle) 3;
    appearance90.BorderColor = SystemColors.Window;
    ((UltraGridBase) this.ugCompDocNames).DisplayLayout.Override.GroupByRowAppearance = (AppearanceBase) appearance90;
    appearance91.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.ugCompDocNames).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance91;
    ((UltraGridBase) this.ugCompDocNames).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance92.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.ugCompDocNames).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance92;
    appearance93.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugCompDocNames).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance93;
    ((UltraGridBase) this.ugCompDocNames).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance94.BackColor = Color.Transparent;
    appearance94.ForeColor = Color.Black;
    ((UltraGridBase) this.ugCompDocNames).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance94;
    appearance95.BackColor = SystemColors.ControlLight;
    ((UltraGridBase) this.ugCompDocNames).DisplayLayout.Override.TemplateAddRowAppearance = (AppearanceBase) appearance95;
    ((UltraGridBase) this.ugCompDocNames).DisplayLayout.ScrollBounds = (ScrollBounds) 0;
    ((UltraGridBase) this.ugCompDocNames).DisplayLayout.ScrollStyle = (ScrollStyle) 1;
    ((UltraGridBase) this.ugCompDocNames).DisplayLayout.ViewStyle = (ViewStyle) 0;
    ((UltraGridBase) this.ugCompDocNames).DisplayLayout.ViewStyleBand = (ViewStyleBand) 2;
    ((Control) this.ugCompDocNames).Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.ugCompDocNames).Location = new Point(7, 7);
    ((Control) this.ugCompDocNames).Name = "ugCompDocNames";
    ((Control) this.ugCompDocNames).Size = new Size(734, 240 /*0xF0*/);
    ((Control) this.ugCompDocNames).TabIndex = 40;
    ((UltraControlBase) this.ugCompDocNames).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.ugCompDocNames).UseOsThemes = (DefaultableBoolean) 2;
    this.TblClientOfficesBindingSource.DataMember = "tblClientOffices";
    this.TblClientOfficesBindingSource.DataSource = (object) this.DsDocumentNamingBindingSource;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(749, 546);
    this.Controls.Add((Control) this.pnlTags);
    this.Controls.Add((Control) this.grpRuleInfo);
    this.Controls.Add((Control) this.ddLines);
    this.Controls.Add((Control) this.ddStates);
    this.Controls.Add((Control) this.ddLocations);
    this.Controls.Add((Control) this.ugCompDocNames);
    this.Controls.Add((Control) this.ddCompanies);
    this.Controls.Add((Control) this.ddPackage);
    this.Controls.Add((Control) this.ddEvents);
    this.Name = nameof (frmDocumentNaming);
    this.Text = "Company Document Naming";
    ((ISupportInitialize) this.cbSystemEvents).EndInit();
    this.DsDocumentNaming.EndInit();
    ((ISupportInitialize) this.DsDocumentNamingBindingSource).EndInit();
    ((ISupportInitialize) this.cbCompanyFilter).EndInit();
    ((ISupportInitialize) this.cbLocationFilter).EndInit();
    ((ISupportInitialize) this.cbStateFilter).EndInit();
    ((ISupportInitialize) this.cbPackageFilter).EndInit();
    ((ISupportInitialize) this.cbLineFilter).EndInit();
    ((ISupportInitialize) this.cbOffice).EndInit();
    ((ISupportInitialize) this.ddLines).EndInit();
    ((ISupportInitialize) this.ddStates).EndInit();
    ((ISupportInitialize) this.ddLocations).EndInit();
    ((ISupportInitialize) this.ddCompanies).EndInit();
    ((ISupportInitialize) this.ddEvents).EndInit();
    ((ISupportInitialize) this.err).EndInit();
    ((ISupportInitialize) this.ddPackage).EndInit();
    ((ISupportInitialize) this.grpRuleInfo).EndInit();
    ((Control) this.grpRuleInfo).ResumeLayout(false);
    ((Control) this.grpRuleInfo).PerformLayout();
    ((ISupportInitialize) this.dgAdditionalLines).EndInit();
    ((ISupportInitialize) this.txtDescription).EndInit();
    ((ISupportInitialize) this.txtFolderName).EndInit();
    ((ISupportInitialize) this.txtFilename).EndInit();
    this.pnlTagsHeader.ResumeLayout(false);
    this.pnlTagsHeader.PerformLayout();
    this.pnlTags.ResumeLayout(false);
    ((ISupportInitialize) this.lstAvailableTags).EndInit();
    ((ISupportInitialize) this.ugCompDocNames).EndInit();
    ((ISupportInitialize) this.TblClientOfficesBindingSource).EndInit();
    this.ResumeLayout(false);
  }

  [field: AccessedThroughProperty("lblState")]
  private virtual Label lblState { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblLine")]
  private virtual Label lblLine { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblCompany")]
  private virtual Label lblCompany { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cbStateFilter")]
  private virtual MGASimpleComboBox cbStateFilter { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual MGASimpleComboBox cbCompanyFilter
  {
    get => this._cbCompanyFilter;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.cbCompanyFilter_ValueChanged);
      MGASimpleComboBox cbCompanyFilter1 = this._cbCompanyFilter;
      if (cbCompanyFilter1 != null)
        cbCompanyFilter1.ValueChanged -= eventHandler;
      this._cbCompanyFilter = value;
      MGASimpleComboBox cbCompanyFilter2 = this._cbCompanyFilter;
      if (cbCompanyFilter2 == null)
        return;
      cbCompanyFilter2.ValueChanged += eventHandler;
    }
  }

  private virtual MGASimpleComboBox cbLineFilter
  {
    get => this._cbLineFilter;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.cbLineFilter_ValueChanged);
      MGASimpleComboBox cbLineFilter1 = this._cbLineFilter;
      if (cbLineFilter1 != null)
        cbLineFilter1.ValueChanged -= eventHandler;
      this._cbLineFilter = value;
      MGASimpleComboBox cbLineFilter2 = this._cbLineFilter;
      if (cbLineFilter2 == null)
        return;
      cbLineFilter2.ValueChanged += eventHandler;
    }
  }

  [field: AccessedThroughProperty("cbSystemEvents")]
  private virtual MGASimpleComboBox cbSystemEvents { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label5")]
  private virtual Label Label5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("grpRuleInfo")]
  internal virtual MGAGroupBox grpRuleInfo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cbPackageFilter")]
  private virtual MGASimpleComboBox cbPackageFilter { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblLimitTo")]
  private virtual Label lblLimitTo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblLocation")]
  private virtual Label lblLocation { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual MGASimpleComboBox cbLocationFilter
  {
    get => this._cbLocationFilter;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.cbLocationFilter_ValueChanged);
      MGASimpleComboBox cbLocationFilter1 = this._cbLocationFilter;
      if (cbLocationFilter1 != null)
        cbLocationFilter1.ValueChanged -= eventHandler;
      this._cbLocationFilter = value;
      MGASimpleComboBox cbLocationFilter2 = this._cbLocationFilter;
      if (cbLocationFilter2 == null)
        return;
      cbLocationFilter2.ValueChanged += eventHandler;
    }
  }

  internal virtual MGATextBox txtFilename
  {
    get => this._txtFilename;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.Format_Enter);
      MGATextBox txtFilename1 = this._txtFilename;
      if (txtFilename1 != null)
        ((Control) txtFilename1).Enter -= eventHandler;
      this._txtFilename = value;
      MGATextBox txtFilename2 = this._txtFilename;
      if (txtFilename2 == null)
        return;
      ((Control) txtFilename2).Enter += eventHandler;
    }
  }

  internal virtual MGASystems.Tools.DBSaveUI.DBSaveUI dbSave
  {
    get => this._dbSave;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      CancelEventHandler cancelEventHandler1 = new CancelEventHandler(this.dbSave_ClickingSave);
      CancelEventHandler cancelEventHandler2 = new CancelEventHandler(this.dbSave_ClickingDelete);
      EventHandler eventHandler1 = new EventHandler(this.dbSave_ClickedNew);
      EventHandler eventHandler2 = new EventHandler(this.dbSave_ClickedCancel);
      EventHandler eventHandler3 = new EventHandler(this.dbSave_ClickedEdit);
      MGASystems.Tools.DBSaveUI.DBSaveUI dbSave1 = this._dbSave;
      if (dbSave1 != null)
      {
        dbSave1.ClickingSave -= cancelEventHandler1;
        dbSave1.ClickingDelete -= cancelEventHandler2;
        dbSave1.ClickedNew -= eventHandler1;
        dbSave1.ClickedCancel -= eventHandler2;
        dbSave1.ClickedEdit -= eventHandler3;
      }
      this._dbSave = value;
      MGASystems.Tools.DBSaveUI.DBSaveUI dbSave2 = this._dbSave;
      if (dbSave2 == null)
        return;
      dbSave2.ClickingSave += cancelEventHandler1;
      dbSave2.ClickingDelete += cancelEventHandler2;
      dbSave2.ClickedNew += eventHandler1;
      dbSave2.ClickedCancel += eventHandler2;
      dbSave2.ClickedEdit += eventHandler3;
    }
  }

  [field: AccessedThroughProperty("lblFilename")]
  private virtual Label lblFilename { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ugCompDocNames")]
  internal virtual UltraGrid ugCompDocNames { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("DsDocumentNamingBindingSource")]
  internal virtual BindingSource DsDocumentNamingBindingSource { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("DsDocumentNaming")]
  internal virtual dsDocumentNaming DsDocumentNaming { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ddLines")]
  internal virtual UltraDropDown ddLines { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ddStates")]
  internal virtual UltraDropDown ddStates { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ddLocations")]
  internal virtual UltraDropDown ddLocations { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ddCompanies")]
  internal virtual UltraDropDown ddCompanies { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ddEvents")]
  internal virtual UltraDropDown ddEvents { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("err")]
  internal virtual ErrorProvider err { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlSelectCommand1")]
  internal virtual SqlCommand SqlSelectCommand1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cnSql")]
  internal virtual SqlConnection cnSql { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlInsertCommand1")]
  internal virtual SqlCommand SqlInsertCommand1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlUpdateCommand1")]
  internal virtual SqlCommand SqlUpdateCommand1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlDeleteCommand1")]
  internal virtual SqlCommand SqlDeleteCommand1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("daDocumentNaming")]
  internal virtual SqlDataAdapter daDocumentNaming { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ddPackage")]
  internal virtual UltraDropDown ddPackage { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual MGATextBox txtDescription
  {
    get => this._txtDescription;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.Format_Enter);
      MGATextBox txtDescription1 = this._txtDescription;
      if (txtDescription1 != null)
        ((Control) txtDescription1).Enter -= eventHandler;
      this._txtDescription = value;
      MGATextBox txtDescription2 = this._txtDescription;
      if (txtDescription2 == null)
        return;
      ((Control) txtDescription2).Enter += eventHandler;
    }
  }

  [field: AccessedThroughProperty("Label1")]
  private virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("pnlTags")]
  internal virtual Panel pnlTags { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual Panel pnlTagsHeader
  {
    get => this._pnlTagsHeader;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      MouseEventHandler mouseEventHandler1 = new MouseEventHandler(this.Tags_MouseDown);
      MouseEventHandler mouseEventHandler2 = new MouseEventHandler(this.Tags_MouseMove);
      MouseEventHandler mouseEventHandler3 = new MouseEventHandler(this.Tags_MouseUp);
      Panel pnlTagsHeader1 = this._pnlTagsHeader;
      if (pnlTagsHeader1 != null)
      {
        pnlTagsHeader1.MouseDown -= mouseEventHandler1;
        pnlTagsHeader1.MouseMove -= mouseEventHandler2;
        pnlTagsHeader1.MouseUp -= mouseEventHandler3;
      }
      this._pnlTagsHeader = value;
      Panel pnlTagsHeader2 = this._pnlTagsHeader;
      if (pnlTagsHeader2 == null)
        return;
      pnlTagsHeader2.MouseDown += mouseEventHandler1;
      pnlTagsHeader2.MouseMove += mouseEventHandler2;
      pnlTagsHeader2.MouseUp += mouseEventHandler3;
    }
  }

  internal virtual Button btnHideTags
  {
    get => this._btnHideTags;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnHideTags_Click);
      Button btnHideTags1 = this._btnHideTags;
      if (btnHideTags1 != null)
        btnHideTags1.Click -= eventHandler;
      this._btnHideTags = value;
      Button btnHideTags2 = this._btnHideTags;
      if (btnHideTags2 == null)
        return;
      btnHideTags2.Click += eventHandler;
    }
  }

  private virtual Label lblTagsHeader
  {
    get => this._lblTagsHeader;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      MouseEventHandler mouseEventHandler1 = new MouseEventHandler(this.Tags_MouseDown);
      MouseEventHandler mouseEventHandler2 = new MouseEventHandler(this.Tags_MouseMove);
      MouseEventHandler mouseEventHandler3 = new MouseEventHandler(this.Tags_MouseUp);
      Label lblTagsHeader1 = this._lblTagsHeader;
      if (lblTagsHeader1 != null)
      {
        lblTagsHeader1.MouseDown -= mouseEventHandler1;
        lblTagsHeader1.MouseMove -= mouseEventHandler2;
        lblTagsHeader1.MouseUp -= mouseEventHandler3;
      }
      this._lblTagsHeader = value;
      Label lblTagsHeader2 = this._lblTagsHeader;
      if (lblTagsHeader2 == null)
        return;
      lblTagsHeader2.MouseDown += mouseEventHandler1;
      lblTagsHeader2.MouseMove += mouseEventHandler2;
      lblTagsHeader2.MouseUp += mouseEventHandler3;
    }
  }

  internal virtual UltraListView lstAvailableTags
  {
    get => this._lstAvailableTags;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      ItemDoubleClickEventHandler clickEventHandler = new ItemDoubleClickEventHandler(this.lstAvailableTags_ItemDoubleClick);
      UltraListView lstAvailableTags1 = this._lstAvailableTags;
      if (lstAvailableTags1 != null)
        lstAvailableTags1.ItemDoubleClick -= clickEventHandler;
      this._lstAvailableTags = value;
      UltraListView lstAvailableTags2 = this._lstAvailableTags;
      if (lstAvailableTags2 == null)
        return;
      lstAvailableTags2.ItemDoubleClick += clickEventHandler;
    }
  }

  internal virtual LinkLabel lnkShowTags
  {
    get => this._lnkShowTags;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkShowTags_LinkClicked);
      LinkLabel lnkShowTags1 = this._lnkShowTags;
      if (lnkShowTags1 != null)
        lnkShowTags1.LinkClicked -= clickedEventHandler;
      this._lnkShowTags = value;
      LinkLabel lnkShowTags2 = this._lnkShowTags;
      if (lnkShowTags2 == null)
        return;
      lnkShowTags2.LinkClicked += clickedEventHandler;
    }
  }

  [field: AccessedThroughProperty("txtFolderName")]
  internal virtual MGATextBox txtFolderName { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label2")]
  private virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual LinkLabel lnkChangeFolder
  {
    get => this._lnkChangeFolder;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkChangeFolder_LinkClicked);
      LinkLabel lnkChangeFolder1 = this._lnkChangeFolder;
      if (lnkChangeFolder1 != null)
        lnkChangeFolder1.LinkClicked -= clickedEventHandler;
      this._lnkChangeFolder = value;
      LinkLabel lnkChangeFolder2 = this._lnkChangeFolder;
      if (lnkChangeFolder2 == null)
        return;
      lnkChangeFolder2.LinkClicked += clickedEventHandler;
    }
  }

  [field: AccessedThroughProperty("dgAdditionalLines")]
  private virtual UltraGrid dgAdditionalLines { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label21")]
  private virtual Label Label21 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cbOffice")]
  private virtual MGASimpleComboBox cbOffice { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TblClientOfficesBindingSource")]
  internal virtual BindingSource TblClientOfficesBindingSource { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblOfficeLoc")]
  private virtual Label lblOfficeLoc { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual BindingManagerBase bmb
  {
    get => this._bmb;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.bmb_PositionChanged);
      BindingManagerBase bmb1 = this._bmb;
      if (bmb1 != null)
        bmb1.PositionChanged -= eventHandler;
      this._bmb = value;
      BindingManagerBase bmb2 = this._bmb;
      if (bmb2 == null)
        return;
      bmb2.PositionChanged += eventHandler;
    }
  }

  public frmDocumentNaming()
  {
    this.Load += new EventHandler(this.frmDocumentNaming_Load);
    this._tags = new DataTable();
    this._documentFolders = new dsDocumentAutomation.tblDocumentFoldersDataTable();
    this._mouseClicked = false;
    this.InitializeComponent();
  }

  private void frmDocumentNaming_Load(object sender, EventArgs e)
  {
    if (this.DesignMode)
      return;
    DefaultDatabase.LoadDataTable((DataTable) this._documentFolders, CommandType.Text, "SELECT FolderID, ParentFolderID, FolderName FROM dbo.tblDocumentFolders ORDER BY FolderName, ParentFolderID");
    this.bmb = this.BindingContext[(object) this.DsDocumentNaming, this.DsDocumentNaming.tblCompanyDocumentNaming.TableName];
    this.cnSql.ConnectionString = CurrentUser.Instance.ConnectionString;
    DefaultDatabase.LoadDataSet((DataSet) this.DsDocumentNaming, new string[7]
    {
      "lstAutomationEvents",
      "lstLines",
      "lstStates",
      "tblCompany",
      "tblCompanyLocations",
      "tblCompanyDocumentNaming",
      "tblClientOffices"
    }, "spDocumentNaming_GetFormData");
    this.DsDocumentNaming.lstLimitPackage.AddlstLimitPackageRow(true, "Package");
    this.DsDocumentNaming.lstLimitPackage.AddlstLimitPackageRow(false, "Monoline");
    DataTable dataTable = DefaultDatabase.FetchStoredProcedureSchemaTable(frmDocumentNaming.GetSetting.QuoteDataProcedure);
    try
    {
      foreach (DataRow row in dataTable.Rows)
      {
        this.lstAvailableTags.Items.Add(row.Field<string>("ColumnName"), (object) $"{{{row.Field<string>("ColumnName")}}}");
        this._tags.Columns.Add(row.Field<string>("ColumnName"));
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    this._tags.Rows.Add((object[]) Enumerable.Repeat<string>(string.Empty, this._tags.Columns.Count).ToArray<string>());
    this.bmb.Position = -1;
    this.lastTextbox = this.txtFilename;
  }

  private void dbSave_ClickingSave(object sender, CancelEventArgs e)
  {
    if (!this.ValidData())
    {
      e.Cancel = true;
    }
    else
    {
      dsDocumentNaming.tblCompanyDocumentNamingRow row = this.DsDocumentNaming.tblCompanyDocumentNaming[this.bmb.Position];
      row.SetField<object>("EventGuid", RuntimeHelpers.GetObjectValue(this.cbSystemEvents.Value));
      row.SetField<object>("CompanyGuid", RuntimeHelpers.GetObjectValue(this.cbCompanyFilter.Value ?? (object) DBNull.Value));
      row.SetField<object>("CompanyLocationGuid", RuntimeHelpers.GetObjectValue(this.cbLocationFilter.Value ?? (object) DBNull.Value));
      row.SetField<object>("LineGuid", RuntimeHelpers.GetObjectValue(this.cbLineFilter.Value ?? (object) DBNull.Value));
      row.SetField<object>("LimitToPackage", RuntimeHelpers.GetObjectValue(this.cbPackageFilter.Value ?? (object) DBNull.Value));
      row.SetField<object>("StateID", RuntimeHelpers.GetObjectValue(this.cbStateFilter.Value ?? (object) DBNull.Value));
      row.SetField<object>("FilenameFormatString", RuntimeHelpers.GetObjectValue(string.IsNullOrEmpty(((TextEditorControlBase) this.txtFilename).Text) ? (object) DBNull.Value : (object) ((TextEditorControlBase) this.txtFilename).Text));
      row.SetField<object>("FilenameDescriptionString", RuntimeHelpers.GetObjectValue(string.IsNullOrEmpty(((TextEditorControlBase) this.txtDescription).Text) ? (object) DBNull.Value : (object) ((TextEditorControlBase) this.txtDescription).Text));
      row.SetField<object>("FolderOverride", RuntimeHelpers.GetObjectValue(((Control) this.txtFolderName).Tag));
      row.SetField<object>("officeGuid", RuntimeHelpers.GetObjectValue(this.cbOffice.Value ?? (object) DBNull.Value));
      this.bmb.EndCurrentEdit();
      try
      {
        this.daDocumentNaming.Update((DataTable) this.DsDocumentNaming.tblCompanyDocumentNaming);
        try
        {
          dsDocumentNaming.lstLinesDataTable lstLines = this.DsDocumentNaming.lstLines;
          System.Func<dsDocumentNaming.lstLinesRow, bool> predicate;
          // ISSUE: reference to a compiler-generated field
          if (frmDocumentNaming._Closure\u0024__.\u0024I206\u002D0 != null)
          {
            // ISSUE: reference to a compiler-generated field
            predicate = frmDocumentNaming._Closure\u0024__.\u0024I206\u002D0;
          }
          else
          {
            // ISSUE: reference to a compiler-generated field
            frmDocumentNaming._Closure\u0024__.\u0024I206\u002D0 = predicate = (System.Func<dsDocumentNaming.lstLinesRow, bool>) ([SpecialName] (x) => x.RowState == DataRowState.Modified);
          }
          foreach (dsDocumentNaming.lstLinesRow lstLinesRow in lstLines.Where<dsDocumentNaming.lstLinesRow>(predicate))
          {
            if (lstLinesRow.Active)
              DefaultDatabase.ExecuteNonQuery("spDocumentNaming_AddAdditionalLine", new object[4]
              {
                (object) "@docNamingID",
                (object) row.ID,
                (object) "@lineGuid",
                (object) lstLinesRow.LineGuid
              });
            else
              DefaultDatabase.ExecuteNonQuery("spDocumentNaming_DeleteAdditionalLine", new object[4]
              {
                (object) "@docNamingID",
                (object) row.ID,
                (object) "@lineGuid",
                (object) lstLinesRow.LineGuid
              });
          }
        }
        finally
        {
          IEnumerator<dsDocumentNaming.lstLinesRow> enumerator;
          enumerator?.Dispose();
        }
        this.EnableEditingControls(false);
        return;
      }
      catch (SqlException ex1)
      {
        ProjectData.SetProjectError((Exception) ex1);
        SqlException ex2 = ex1;
        if (ex2.Message.IndexOf("IX_tblCompanyDocumentNaming_Unique", StringComparison.OrdinalIgnoreCase) > -1)
        {
          int num = (int) MessageBox.Show("Setup already exists", "Duplicate Detected", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          if (row.RowState != DataRowState.Added)
          {
            row.RejectChanges();
            this.DsDocumentNaming.lstLines.RejectChanges();
          }
        }
        else
          ErrorHandler.HandleError((Exception) ex2);
        ProjectData.ClearProjectError();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ErrorHandler.HandleError(ex);
        ProjectData.ClearProjectError();
      }
      e.Cancel = true;
    }
  }

  private void dbSave_ClickingDelete(object sender, CancelEventArgs e)
  {
    dsDocumentNaming.tblCompanyDocumentNamingRow documentNamingRow = this.DsDocumentNaming.tblCompanyDocumentNaming[this.bmb.Position];
    documentNamingRow.Delete();
    try
    {
      this.daDocumentNaming.Update((DataTable) this.DsDocumentNaming.tblCompanyDocumentNaming);
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      documentNamingRow.RejectChanges();
      this.bmb.CancelCurrentEdit();
      ProjectData.ClearProjectError();
    }
    finally
    {
      this.bmb.Position = -1;
    }
  }

  private void dbSave_ClickedNew(object sender, EventArgs e)
  {
    this.DsDocumentNaming.tblCompanyDocumentNaming.AddtblCompanyDocumentNamingRow(this.DsDocumentNaming.tblCompanyDocumentNaming.NewtblCompanyDocumentNamingRow());
    this.bmb.Position = this.DsDocumentNaming.tblCompanyDocumentNaming.Count - 1;
    this.dbSave.UIState = UIState.Editing;
    this.EnableEditingControls(true);
  }

  private void dbSave_ClickedCancel(object sender, EventArgs e)
  {
    if (this.bmb.Position <= -1)
      return;
    this.DsDocumentNaming.tblCompanyDocumentNaming[this.bmb.Position].RejectChanges();
    this.DsDocumentNaming.lstLines.RejectChanges();
    this.bmb.CancelCurrentEdit();
    this.bmb.Position = -1;
    this.EnableEditingControls(false);
  }

  private void dbSave_ClickedEdit(object sender, EventArgs e) => this.EnableEditingControls(true);

  private void cbCompanyFilter_ValueChanged(object sender, EventArgs e)
  {
    if (this.cbCompanyFilter.Value == null || this.cbCompanyFilter.Value == DBNull.Value || this.cbLocationFilter.Value == null || this.cbLocationFilter.Value == DBNull.Value || this.DsDocumentNaming.tblCompanyLocations.FindByCompanyLocationGuid((Guid) this.cbLocationFilter.Value).CompanyGuid.Equals(RuntimeHelpers.GetObjectValue(this.cbCompanyFilter.Value)))
      return;
    this.cbLocationFilter.Value = (object) null;
  }

  private void cbLocationFilter_ValueChanged(object sender, EventArgs e)
  {
    if (this.cbLocationFilter.Value == null || this.cbLocationFilter.Value == DBNull.Value || this.cbCompanyFilter.Value == null || this.cbCompanyFilter.Value == DBNull.Value || this.DsDocumentNaming.tblCompanyLocations.FindByCompanyLocationGuid((Guid) this.cbLocationFilter.Value).CompanyGuid.Equals(RuntimeHelpers.GetObjectValue(this.cbCompanyFilter.Value)))
      return;
    this.cbCompanyFilter.Value = (object) null;
  }

  private void bmb_PositionChanged(object sender, EventArgs e)
  {
    if (this.bmb.Position > -1)
    {
      int? nullable = this.DsDocumentNaming.tblCompanyDocumentNaming[this.bmb.Position].Field<int?>("FolderOverride");
      ((Control) this.txtFolderName).Tag = (object) nullable;
      if (nullable.HasValue)
        ((TextEditorControlBase) this.txtFolderName).Text = this._documentFolders.FindByFolderID(nullable.Value).FolderName;
      else
        ((TextEditorControlBase) this.txtFolderName).Text = string.Empty;
      this.LoadAdditionalLines(this.DsDocumentNaming.tblCompanyDocumentNaming[this.bmb.Position]);
      this.dbSave.UIState = UIState.HasRecordsNotEditing;
    }
    else
    {
      ((Control) this.txtFolderName).Tag = (object) null;
      ((TextEditorControlBase) this.txtFolderName).Text = string.Empty;
      this.dbSave.UIState = UIState.NoRecordsNotEditing;
    }
  }

  private void Tags_MouseDown(object sender, MouseEventArgs e)
  {
    this._mouseClicked = true;
    this._lastPosition = Control.MousePosition;
  }

  private void Tags_MouseMove(object sender, MouseEventArgs e)
  {
    if (!this._mouseClicked)
      return;
    Point point;
    ref Point local = ref point;
    Point mousePosition = Control.MousePosition;
    int x1 = mousePosition.X - this._lastPosition.X;
    mousePosition = Control.MousePosition;
    int y1 = mousePosition.Y - this._lastPosition.Y;
    local = new Point(x1, y1);
    if (point.X + this.pnlTags.Location.X + this.pnlTags.Width > this.ClientSize.Width)
      return;
    int y2 = point.Y;
    Point location = this.pnlTags.Location;
    int y3 = location.Y;
    if (y2 + y3 + this.pnlTags.Height > this.ClientSize.Height)
      return;
    int x2 = point.X;
    location = this.pnlTags.Location;
    int x3 = location.X;
    if (x2 + x3 < 0)
      return;
    int y4 = point.Y;
    location = this.pnlTags.Location;
    int y5 = location.Y;
    if (y4 + y5 < 0)
      return;
    Panel pnlTags = this.pnlTags;
    location = this.pnlTags.Location;
    int x4 = location.X + point.X;
    location = this.pnlTags.Location;
    int y6 = location.Y + point.Y;
    pnlTags.SetBounds(x4, y6, 0, 0, BoundsSpecified.Location);
    this._lastPosition = Control.MousePosition;
  }

  private void Tags_MouseUp(object sender, MouseEventArgs e) => this._mouseClicked = false;

  private void btnHideTags_Click(object sender, EventArgs e)
  {
    this.pnlTags.Visible = false;
    this.pnlTags.SendToBack();
  }

  private void lnkShowTags_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    this.pnlTags.Visible = true;
    this.pnlTags.BringToFront();
  }

  private void Format_Enter(object sender, EventArgs e) => this.lastTextbox = (MGATextBox) sender;

  private void lstAvailableTags_ItemDoubleClick(object sender, ItemDoubleClickEventArgs e)
  {
    if (this.lastTextbox == null)
      return;
    if (((TextEditorControlBase) this.lastTextbox).TextLength == 0)
      ((TextEditorControlBase) this.lastTextbox).Focus();
    ((TextEditorControlBase) this.lastTextbox).SelectedText = ((UltraListViewItemBase) ((ItemEventArgs) e).Item).Value.ToString();
  }

  private void lnkChangeFolder_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    using (frmSelectDocumentFolder selectDocumentFolder = (frmSelectDocumentFolder) FormSettings.ShowFormDialog(typeof (frmSelectDocumentFolder), (object) this._documentFolders))
    {
      if (selectDocumentFolder.FolderSelected)
      {
        ((TextEditorControlBase) this.txtFolderName).Text = selectDocumentFolder.FolderName;
        ((Control) this.txtFolderName).Tag = (object) selectDocumentFolder.FolderID;
      }
      else
      {
        ((TextEditorControlBase) this.txtFolderName).Text = string.Empty;
        ((Control) this.txtFolderName).Tag = (object) null;
      }
    }
  }

  private void cbLineFilter_ValueChanged(object sender, EventArgs e)
  {
    ((Control) this.dgAdditionalLines).Enabled = this.dbSave.UIState == UIState.Editing && this.cbLineFilter.Value != null && this.cbLineFilter.Value != DBNull.Value;
  }

  private void LoadAdditionalLines(dsDocumentNaming.tblCompanyDocumentNamingRow dr)
  {
    List<Guid> guidList = new List<Guid>();
    if (dr != null && dr.RowState != DataRowState.Added)
    {
      DataTable dataTable = DefaultDatabase.ExecuteDataTable("spDocumentNaming_GetAdditionalLines", new object[2]
      {
        (object) "@docNamingID",
        (object) dr.ID
      });
      try
      {
        foreach (DataRow row in dataTable.Rows)
          guidList.Add(row.Field<Guid>("LineGuid"));
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
    }
    try
    {
      foreach (dsDocumentNaming.lstLinesRow lstLine in (TypedTableBase<dsDocumentNaming.lstLinesRow>) this.DsDocumentNaming.lstLines)
        lstLine.Active = guidList.Contains(lstLine.LineGuid);
    }
    finally
    {
      IEnumerator<dsDocumentNaming.lstLinesRow> enumerator;
      enumerator?.Dispose();
    }
    this.DsDocumentNaming.lstLines.AcceptChanges();
  }

  private void EnableEditingControls(bool enabled)
  {
    ((Control) this.cbCompanyFilter).Enabled = enabled;
    ((Control) this.cbLineFilter).Enabled = enabled;
    ((Control) this.cbLocationFilter).Enabled = enabled;
    ((Control) this.cbPackageFilter).Enabled = enabled;
    ((Control) this.cbStateFilter).Enabled = enabled;
    ((Control) this.cbSystemEvents).Enabled = enabled;
    ((Control) this.txtFilename).Enabled = enabled;
    ((Control) this.txtDescription).Enabled = enabled;
    this.lnkShowTags.Enabled = enabled;
    this.lnkChangeFolder.Enabled = enabled;
    ((Control) this.cbOffice).Enabled = enabled;
    ((Control) this.dgAdditionalLines).Enabled = enabled && this.cbLineFilter.Value != null && this.cbLineFilter.Value != DBNull.Value;
    if (!enabled)
      this.btnHideTags.PerformClick();
    ((Control) this.ugCompDocNames).Enabled = !enabled;
  }

  public bool ValidData()
  {
    this.err.SetError((Control) this.cbSystemEvents, "");
    this.err.SetError((Control) this.txtFilename, "");
    this.err.SetError((Control) this.txtDescription, "");
    this.err.SetError((Control) this.txtFolderName, "");
    bool flag1;
    if (this.cbSystemEvents.Value == DBNull.Value || this.cbSystemEvents.Value == null)
    {
      this.err.SetError((Control) this.cbSystemEvents, "Please select a valid system event");
      flag1 = false;
    }
    else if (string.IsNullOrEmpty(((TextEditorControlBase) this.txtFilename).Text.Trim()) && string.IsNullOrEmpty(((TextEditorControlBase) this.txtDescription).Text.Trim()) && ((Control) this.txtFolderName).Tag == null)
    {
      this.err.SetError((Control) this.txtFilename, "Must specify a folder, filename, or description");
      this.err.SetError((Control) this.txtDescription, "Must specify a folder, filename, or description");
      this.err.SetError((Control) this.txtFolderName, "Must specify a folder, filename, or description");
      flag1 = false;
    }
    else
    {
      bool flag2 = true;
      string errMsg1 = "";
      string result = "";
      if (!string.IsNullOrEmpty(((TextEditorControlBase) this.txtFilename).Text.Trim()))
      {
        if (!frmDocumentNaming.ValidateFormat(((TextEditorControlBase) this.txtFilename).Text.Trim(), this._tags.Rows[0], ref result, ref errMsg1))
        {
          flag2 = false;
        }
        else
        {
          if (result.IndexOfAny(Path.GetInvalidFileNameChars()) > -1)
          {
            errMsg1 = "Invalid filename";
            flag2 = false;
          }
          if (!Path.HasExtension(result))
          {
            if (errMsg1.Length > 0)
              errMsg1 += "; ";
            errMsg1 += "Missing extension";
            flag2 = false;
          }
        }
        this.err.SetError((Control) this.txtFilename, errMsg1);
      }
      string errMsg2 = "";
      if (!string.IsNullOrEmpty(((TextEditorControlBase) this.txtDescription).Text.Trim()) && !frmDocumentNaming.ValidateFormat(((TextEditorControlBase) this.txtDescription).Text.Trim(), this._tags.Rows[0], ref result, ref errMsg2))
      {
        this.err.SetError((Control) this.txtDescription, errMsg2);
        flag2 = false;
      }
      flag1 = flag2;
    }
    return flag1;
  }

  public static frmDocumentNaming.Settings GetSetting
  {
    get
    {
      if (frmDocumentNaming._setting == null)
      {
        try
        {
          frmDocumentNaming._setting = (frmDocumentNaming.Settings) ObjectFactory.Instance.CreateObject(typeof (frmDocumentNaming.Settings));
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          frmDocumentNaming._setting = new frmDocumentNaming.Settings();
          ProjectData.ClearProjectError();
        }
      }
      return frmDocumentNaming._setting;
    }
  }

  public static bool ValidateFormat(
    string formatStr,
    DataRow dr,
    ref string result,
    ref string errMsg)
  {
    // ISSUE: variable of a compiler-generated type
    frmDocumentNaming._Closure\u0024__233\u002D0 closure2330_1;
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    frmDocumentNaming._Closure\u0024__233\u002D0 closure2330_2 = new frmDocumentNaming._Closure\u0024__233\u002D0(closure2330_1);
    // ISSUE: reference to a compiler-generated field
    closure2330_2.\u0024VB\u0024Local_dr = dr;
    bool flag;
    if (string.IsNullOrEmpty(formatStr))
    {
      flag = true;
    }
    else
    {
      string str1;
      try
      {
        // ISSUE: reference to a compiler-generated method
        str1 = frmDocumentNaming.PropertyRegex.Replace(formatStr, new MatchEvaluator(closure2330_2._Lambda\u0024__0));
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        errMsg = "Incorrect formats specified";
        flag = false;
        ProjectData.ClearProjectError();
        goto label_13;
      }
      if (str1.Contains("!!!#") && str1.Contains("#!!!"))
      {
        errMsg = "Bad tags: ";
        string[] strArray = str1.Split(new string[1]
        {
          "!!!"
        }, StringSplitOptions.None);
        int index = 0;
        while (index < strArray.Length)
        {
          string str2 = strArray[index];
          if (str2.StartsWith("#") && str2.EndsWith("#"))
            errMsg = $"{errMsg}{str2.Replace("#", string.Empty)}, ";
          checked { ++index; }
        }
        errMsg = errMsg.TrimEnd(' ', ',');
        flag = false;
      }
      else
      {
        result = str1;
        flag = true;
      }
    }
label_13:
    return flag;
  }

  public static string ResolveString(string name, DataRow dr)
  {
    string str1;
    if (string.IsNullOrEmpty(name))
    {
      str1 = (string) null;
    }
    else
    {
      string str2 = (string) null;
      try
      {
        str2 = frmDocumentNaming.PropertyRegex.Replace(name, (MatchEvaluator) ([SpecialName] (x) => frmDocumentNaming.ReplaceColumnToken(x, dr)));
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ErrorHandler.SilentHandleError(ex);
        ProjectData.ClearProjectError();
      }
      str1 = str2;
    }
    return str1;
  }

  private static string ReplaceColumnToken(Match match, DataRow dr, string notFoundString = "#${property}#")
  {
    string str = match.Groups["property"].Value;
    return !dr.Table.Columns.Contains(str) ? match.Result(notFoundString) : string.Format(StringLiteralFormatter.Instance, match.Result("$1{0${format}}$2"), RuntimeHelpers.GetObjectValue(dr[str]));
  }

  public class Settings
  {
    public virtual string QuoteDataProcedure => "spDocumentNaming_GetQuoteData";
  }
}
