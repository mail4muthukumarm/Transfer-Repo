// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Inspections.NetRate.frmInspectionRequest
// Assembly: MgaSystems.IMS.Inspections, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 07B8D1F3-634C-445B-ABFB-027DE209A43D
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Inspections.dll

using Infragistics.Shared;
using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using MGASystems.BusinessObjects;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.InfragisticsExtensions.Editors;
using MGASystems.Tools;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
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
namespace MGASystems.IMS.Policies.Inspections.NetRate;

[SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly")]
public class frmInspectionRequest : Form
{
  private IContainer components;
  private Label Label1;
  private readonly Quote _quote;
  private readonly Guid _lineGuid;
  private HyperlinkEditor _inspectLink;
  private HyperlinkEditor _removeLink;
  private string _locationContactName;
  private string _locationContactPhone;
  private InspectionRequest _inspReq;
  private bool _isPropertyLine;
  private bool _isAutoLine;
  private bool _isWorkersCompLine;
  private bool _duplicateLocationNameAndNumber;
  private string _storedProc;
  private bool _successfulRequest;
  private readonly SqlConnection _cn;

  protected virtual MGAButton btnRequestInspections
  {
    get => this._btnRequestInspections;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnRequestInspections_Click);
      MGAButton requestInspections1 = this._btnRequestInspections;
      if (requestInspections1 != null)
        ((Control) requestInspections1).Click -= eventHandler;
      this._btnRequestInspections = value;
      MGAButton requestInspections2 = this._btnRequestInspections;
      if (requestInspections2 == null)
        return;
      ((Control) requestInspections2).Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("Label2")]
  internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected virtual MGAComboBox cboInspectionCompanies
  {
    get => this._cboInspectionCompanies;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.cboInspectionCompanies_ValueChanged);
      MGAComboBox inspectionCompanies1 = this._cboInspectionCompanies;
      if (inspectionCompanies1 != null)
        inspectionCompanies1.ValueChanged -= eventHandler;
      this._cboInspectionCompanies = value;
      MGAComboBox inspectionCompanies2 = this._cboInspectionCompanies;
      if (inspectionCompanies2 == null)
        return;
      inspectionCompanies2.ValueChanged += eventHandler;
    }
  }

  [field: AccessedThroughProperty("err")]
  internal virtual ErrorProvider err { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected virtual UltraGrid grid
  {
    get => this._grid;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      CellEventHandler cellEventHandler = new CellEventHandler(this.grid_AfterCellUpdate);
      UltraGrid grid1 = this._grid;
      if (grid1 != null)
        grid1.AfterCellUpdate -= cellEventHandler;
      this._grid = value;
      UltraGrid grid2 = this._grid;
      if (grid2 == null)
        return;
      grid2.AfterCellUpdate += cellEventHandler;
    }
  }

  [field: AccessedThroughProperty("ds")]
  protected virtual dsInspectionRequest ds { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("gridLocations")]
  protected virtual UltraGrid gridLocations { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("daNetRateLoc")]
  internal virtual SqlDataAdapter daNetRateLoc { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlSelectCommand1")]
  internal virtual SqlCommand SqlSelectCommand1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlInsertCommand1")]
  internal virtual SqlCommand SqlInsertCommand1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlUpdateCommand1")]
  internal virtual SqlCommand SqlUpdateCommand1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("optionInspMethod")]
  protected virtual UltraOptionSet optionInspMethod { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("GroupBox1")]
  protected virtual GroupBox GroupBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlDeleteCommand1")]
  internal virtual SqlCommand SqlDeleteCommand1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    Appearance appearance1 = new Appearance();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmInspectionRequest));
    ValueListItem valueListItem1 = new ValueListItem();
    ValueListItem valueListItem2 = new ValueListItem();
    Appearance appearance2 = new Appearance();
    UltraGridBand ultraGridBand1 = new UltraGridBand("InspectionCompanies", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("PayeeID");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("PayeeName");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("ClientCode");
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
    Appearance appearance14 = new Appearance();
    Appearance appearance15 = new Appearance();
    ScrollBarLook scrollBarLook1 = new ScrollBarLook();
    Appearance appearance16 = new Appearance();
    UltraGridBand ultraGridBand2 = new UltraGridBand("Locations", -1);
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("LocationID");
    Appearance appearance17 = new Appearance();
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("Address");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("City");
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("State");
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("ZipCode");
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("InspectLink");
    Appearance appearance18 = new Appearance();
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("Location");
    UltraGridColumn ultraGridColumn11 = new UltraGridColumn("UniqueID");
    UltraGridColumn ultraGridColumn12 = new UltraGridColumn("Address2");
    UltraGridColumn ultraGridColumn13 = new UltraGridColumn("ClassCode");
    UltraGridColumn ultraGridColumn14 = new UltraGridColumn("SIC");
    UltraGridColumn ultraGridColumn15 = new UltraGridColumn("DueDate");
    UltraGridColumn ultraGridColumn16 = new UltraGridColumn("LocationsInspectionRequest");
    UltraGridBand ultraGridBand3 = new UltraGridBand("LocationsInspectionRequest", 0);
    UltraGridColumn ultraGridColumn17 = new UltraGridColumn("LocationID");
    UltraGridColumn ultraGridColumn18 = new UltraGridColumn("CostEstimator");
    UltraGridColumn ultraGridColumn19 = new UltraGridColumn("Photo");
    UltraGridColumn ultraGridColumn20 = new UltraGridColumn("Diagram");
    UltraGridColumn ultraGridColumn21 = new UltraGridColumn("LocationContact");
    UltraGridColumn ultraGridColumn22 = new UltraGridColumn("LocationContactPhone");
    UltraGridColumn ultraGridColumn23 = new UltraGridColumn("SpecialInstructions");
    UltraGridColumn ultraGridColumn24 = new UltraGridColumn("RemoveLink");
    UltraGridColumn ultraGridColumn25 = new UltraGridColumn("UniqueID");
    UltraGridColumn ultraGridColumn26 = new UltraGridColumn("DueDate");
    UltraGridColumn ultraGridColumn27 = new UltraGridColumn("Location");
    UltraGridColumn ultraGridColumn28 = new UltraGridColumn("Rush");
    UltraGridColumn ultraGridColumn29 = new UltraGridColumn("RecCheck");
    Appearance appearance19 = new Appearance();
    Appearance appearance20 = new Appearance();
    Appearance appearance21 = new Appearance();
    Appearance appearance22 = new Appearance();
    Appearance appearance23 = new Appearance();
    Appearance appearance24 = new Appearance();
    Appearance appearance25 = new Appearance();
    ScrollBarLook scrollBarLook2 = new ScrollBarLook();
    Appearance appearance26 = new Appearance();
    Appearance appearance27 = new Appearance();
    Appearance appearance28 = new Appearance();
    UltraGridBand ultraGridBand4 = new UltraGridBand("InspectionRequest", -1);
    UltraGridColumn ultraGridColumn30 = new UltraGridColumn("LocationID");
    Appearance appearance29 = new Appearance();
    UltraGridColumn ultraGridColumn31 = new UltraGridColumn("CostEstimator");
    UltraGridColumn ultraGridColumn32 = new UltraGridColumn("Photo");
    UltraGridColumn ultraGridColumn33 = new UltraGridColumn("Diagram");
    UltraGridColumn ultraGridColumn34 = new UltraGridColumn("LocationContact");
    UltraGridColumn ultraGridColumn35 = new UltraGridColumn("LocationContactPhone");
    UltraGridColumn ultraGridColumn36 = new UltraGridColumn("SpecialInstructions");
    UltraGridColumn ultraGridColumn37 = new UltraGridColumn("RemoveLink");
    Appearance appearance30 = new Appearance();
    UltraGridColumn ultraGridColumn38 = new UltraGridColumn("UniqueID");
    UltraGridColumn ultraGridColumn39 = new UltraGridColumn("DueDate");
    UltraGridColumn ultraGridColumn40 = new UltraGridColumn("Location");
    UltraGridColumn ultraGridColumn41 = new UltraGridColumn("Rush");
    UltraGridColumn ultraGridColumn42 = new UltraGridColumn("RecCheck");
    Appearance appearance31 = new Appearance();
    Appearance appearance32 = new Appearance();
    Appearance appearance33 = new Appearance();
    Appearance appearance34 = new Appearance();
    Appearance appearance35 = new Appearance();
    Appearance appearance36 = new Appearance();
    Appearance appearance37 = new Appearance();
    ScrollBarLook scrollBarLook3 = new ScrollBarLook();
    Appearance appearance38 = new Appearance();
    Appearance appearance39 = new Appearance();
    this.Label1 = new Label();
    this.btnRequestInspections = new MGAButton();
    this.Label2 = new Label();
    this.err = new ErrorProvider(this.components);
    this.daNetRateLoc = new SqlDataAdapter();
    this.SqlDeleteCommand1 = new SqlCommand();
    this.SqlInsertCommand1 = new SqlCommand();
    this.SqlSelectCommand1 = new SqlCommand();
    this.SqlUpdateCommand1 = new SqlCommand();
    this.optionInspMethod = new UltraOptionSet();
    this.GroupBox1 = new GroupBox();
    this.cboInspectionCompanies = new MGAComboBox();
    this.ds = new dsInspectionRequest();
    this.gridLocations = new UltraGrid();
    this.grid = new UltraGrid();
    ((ISupportInitialize) this.btnRequestInspections).BeginInit();
    ((ISupportInitialize) this.err).BeginInit();
    ((ISupportInitialize) this.optionInspMethod).BeginInit();
    this.GroupBox1.SuspendLayout();
    ((ISupportInitialize) this.cboInspectionCompanies).BeginInit();
    this.ds.BeginInit();
    ((ISupportInitialize) this.gridLocations).BeginInit();
    ((ISupportInitialize) this.grid).BeginInit();
    this.SuspendLayout();
    this.Label1.AutoSize = true;
    this.Label1.Location = new Point(16 /*0x10*/, 48 /*0x30*/);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(350, 13);
    this.Label1.TabIndex = 0;
    this.Label1.Text = "Please select which NetRate locations you would like to have inspected:";
    this.Label1.TextAlign = ContentAlignment.MiddleLeft;
    ((Control) this.btnRequestInspections).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance1.BackColor = Color.FromArgb(248, 248, 248);
    appearance1.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance1.BackGradientStyle = (GradientStyle) 2;
    appearance1.BorderColor = Color.DarkGray;
    appearance1.ImageHAlign = (HAlign) 2;
    appearance1.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnRequestInspections).Appearance = (AppearanceBase) appearance1;
    ((Control) this.btnRequestInspections).Location = new Point(621, 421);
    ((Control) this.btnRequestInspections).Name = "btnRequestInspections";
    ((Control) this.btnRequestInspections).Size = new Size(144 /*0x90*/, 24);
    ((Control) this.btnRequestInspections).TabIndex = 2;
    ((ControlBase) this.btnRequestInspections).Text = "Request Inspections";
    this.btnRequestInspections.UseOSThemes = (DefaultableBoolean) 2;
    this.Label2.AutoSize = true;
    this.Label2.Location = new Point(16 /*0x10*/, 18);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(109, 13);
    this.Label2.TabIndex = 4;
    this.Label2.Text = "Inspection Company:";
    this.Label2.TextAlign = ContentAlignment.MiddleLeft;
    this.err.ContainerControl = (ContainerControl) this;
    this.daNetRateLoc.DeleteCommand = this.SqlDeleteCommand1;
    this.daNetRateLoc.InsertCommand = this.SqlInsertCommand1;
    this.daNetRateLoc.SelectCommand = this.SqlSelectCommand1;
    this.daNetRateLoc.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblNetRateInspectionInfo", new DataColumnMapping[17]
      {
        new DataColumnMapping("ID", "ID"),
        new DataColumnMapping("ControlNo", "ControlNo"),
        new DataColumnMapping("LocationID", "LocationID"),
        new DataColumnMapping("PremesisID", "PremesisID"),
        new DataColumnMapping("ExposureID", "ExposureID"),
        new DataColumnMapping("CostEstimation", "CostEstimation"),
        new DataColumnMapping("Photo", "Photo"),
        new DataColumnMapping("Diagram", "Diagram"),
        new DataColumnMapping("LocationContact", "LocationContact"),
        new DataColumnMapping("ContactPhone", "ContactPhone"),
        new DataColumnMapping("SpecialInstructions", "SpecialInstructions"),
        new DataColumnMapping("Address1", "Address1"),
        new DataColumnMapping("Address2", "Address2"),
        new DataColumnMapping("City", "City"),
        new DataColumnMapping("State", "State"),
        new DataColumnMapping("Zip", "Zip"),
        new DataColumnMapping("SIC", "SIC")
      })
    });
    this.daNetRateLoc.UpdateCommand = this.SqlUpdateCommand1;
    this.SqlInsertCommand1.CommandText = componentResourceManager.GetString("SqlInsertCommand1.CommandText");
    this.SqlInsertCommand1.Parameters.AddRange(new SqlParameter[19]
    {
      new SqlParameter("@ControlNo", SqlDbType.Int, 4, "ControlNo"),
      new SqlParameter("@LocationID", SqlDbType.Int, 4, "LocationID"),
      new SqlParameter("@PremesisID", SqlDbType.Int, 4, "PremesisID"),
      new SqlParameter("@ExposureID", SqlDbType.Int, 4, "ExposureID"),
      new SqlParameter("@CostEstimation", SqlDbType.Bit, 1, "CostEstimation"),
      new SqlParameter("@Photo", SqlDbType.Bit, 1, "Photo"),
      new SqlParameter("@Diagram", SqlDbType.Bit, 1, "Diagram"),
      new SqlParameter("@LocationContact", SqlDbType.VarChar, 100, "LocationContact"),
      new SqlParameter("@ContactPhone", SqlDbType.VarChar, 20, "ContactPhone"),
      new SqlParameter("@SpecialInstructions", SqlDbType.VarChar, 2000, "SpecialInstructions"),
      new SqlParameter("@Address1", SqlDbType.VarChar, 500, "Address1"),
      new SqlParameter("@Address2", SqlDbType.VarChar, 500, "Address2"),
      new SqlParameter("@City", SqlDbType.VarChar, 200, "City"),
      new SqlParameter("@State", SqlDbType.VarChar, 70, "State"),
      new SqlParameter("@Zip", SqlDbType.VarChar, 15, "Zip"),
      new SqlParameter("@SIC", SqlDbType.VarChar, 70, "SIC"),
      new SqlParameter("@InspectionCompanyID", SqlDbType.Int, 4, "InspectionCompanyID"),
      new SqlParameter("@DateInspected", SqlDbType.DateTime, 8, "DateInspected"),
      new SqlParameter("@InspectionMethod", SqlDbType.TinyInt, 1, "InspectionMethod")
    });
    this.optionInspMethod.BackColor = Color.Transparent;
    this.optionInspMethod.BackColorInternal = Color.Transparent;
    this.optionInspMethod.BorderStyle = (UIElementBorderStyle) 1;
    this.optionInspMethod.GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007RadioButtonGlyphInfo;
    valueListItem1.DataValue = (object) (byte) 1;
    valueListItem1.DisplayText = "Phone Survey";
    valueListItem2.DataValue = (object) (byte) 2;
    valueListItem2.DisplayText = "Physical Inspection";
    this.optionInspMethod.Items.AddRange(new ValueListItem[2]
    {
      valueListItem1,
      valueListItem2
    });
    ((Control) this.optionInspMethod).Location = new Point(13, 12);
    ((Control) this.optionInspMethod).Name = "optionInspMethod";
    ((Control) this.optionInspMethod).Size = new Size(131, 35);
    ((Control) this.optionInspMethod).TabIndex = 6;
    ((UltraControlBase) this.optionInspMethod).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.optionInspMethod).UseOsThemes = (DefaultableBoolean) 2;
    this.GroupBox1.Controls.Add((Control) this.optionInspMethod);
    this.GroupBox1.Location = new Point(423, 8);
    this.GroupBox1.Name = "GroupBox1";
    this.GroupBox1.Size = new Size(140, 53);
    this.GroupBox1.TabIndex = 7;
    this.GroupBox1.TabStop = false;
    this.GroupBox1.Text = "Method of Inspection";
    this.cboInspectionCompanies.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.cboInspectionCompanies).DataSource = (object) this.ds.InspectionCompanies;
    appearance2.BackColor = Color.White;
    appearance2.BorderColor = Color.FromArgb(78, 122, 171);
    this.cboInspectionCompanies.DisplayLayout.Appearance = (AppearanceBase) appearance2;
    this.cboInspectionCompanies.DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridBand1.ColHeadersVisible = false;
    ultraGridColumn1.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn1.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn2.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn2.Header).Caption = "Inspection Company";
    ((HeaderBase) ultraGridColumn2.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn2.Header.VisiblePosition = 1;
    ultraGridColumn2.Width = 229;
    ultraGridColumn3.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn3.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn3.Header.VisiblePosition = 2;
    ultraGridColumn3.Hidden = true;
    ultraGridBand1.Columns.AddRange(new object[3]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3
    });
    this.cboInspectionCompanies.DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    this.cboInspectionCompanies.DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    this.cboInspectionCompanies.DisplayLayout.BorderStyleCaption = (UIElementBorderStyle) 1;
    this.cboInspectionCompanies.DisplayLayout.CaptionVisible = (DefaultableBoolean) 2;
    appearance3.BackColor = SystemColors.ActiveBorder;
    appearance3.BackColor2 = SystemColors.ControlDark;
    appearance3.BackGradientStyle = (GradientStyle) 2;
    appearance3.BorderColor = SystemColors.Window;
    ((SpecialBoxBase) this.cboInspectionCompanies.DisplayLayout.GroupByBox).Appearance = (AppearanceBase) appearance3;
    appearance4.ForeColor = SystemColors.GrayText;
    this.cboInspectionCompanies.DisplayLayout.GroupByBox.BandLabelAppearance = (AppearanceBase) appearance4;
    ((SpecialBoxBase) this.cboInspectionCompanies.DisplayLayout.GroupByBox).BorderStyle = (UIElementBorderStyle) 4;
    appearance5.BackColor = SystemColors.ControlLightLight;
    appearance5.BackColor2 = SystemColors.Control;
    appearance5.BackGradientStyle = (GradientStyle) 3;
    appearance5.ForeColor = SystemColors.GrayText;
    this.cboInspectionCompanies.DisplayLayout.GroupByBox.PromptAppearance = (AppearanceBase) appearance5;
    this.cboInspectionCompanies.DisplayLayout.MaxColScrollRegions = 1;
    this.cboInspectionCompanies.DisplayLayout.MaxRowScrollRegions = 1;
    appearance6.BackColor = SystemColors.Window;
    appearance6.ForeColor = SystemColors.ControlText;
    this.cboInspectionCompanies.DisplayLayout.Override.ActiveCellAppearance = (AppearanceBase) appearance6;
    appearance7.BackColor = SystemColors.Highlight;
    appearance7.ForeColor = SystemColors.HighlightText;
    this.cboInspectionCompanies.DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance7;
    this.cboInspectionCompanies.DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 1;
    this.cboInspectionCompanies.DisplayLayout.Override.BorderStyleHeader = (UIElementBorderStyle) 1;
    this.cboInspectionCompanies.DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 1;
    this.cboInspectionCompanies.DisplayLayout.Override.BorderStyleRowSelector = (UIElementBorderStyle) 1;
    this.cboInspectionCompanies.DisplayLayout.Override.BorderStyleSummaryFooter = (UIElementBorderStyle) 1;
    this.cboInspectionCompanies.DisplayLayout.Override.BorderStyleSummaryFooterCaption = (UIElementBorderStyle) 1;
    this.cboInspectionCompanies.DisplayLayout.Override.BorderStyleSummaryValue = (UIElementBorderStyle) 1;
    this.cboInspectionCompanies.DisplayLayout.Override.BorderStyleTemplateAddRow = (UIElementBorderStyle) 1;
    appearance8.BackColor = SystemColors.Window;
    this.cboInspectionCompanies.DisplayLayout.Override.CardAreaAppearance = (AppearanceBase) appearance8;
    appearance9.BorderColor = Color.Silver;
    appearance9.TextTrimming = (TextTrimming) 3;
    this.cboInspectionCompanies.DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance9;
    this.cboInspectionCompanies.DisplayLayout.Override.CellClickAction = (CellClickAction) 4;
    this.cboInspectionCompanies.DisplayLayout.Override.CellPadding = 0;
    appearance10.BackColor = SystemColors.Control;
    appearance10.BackColor2 = SystemColors.ControlDark;
    appearance10.BackGradientAlignment = (GradientAlignment) 1;
    appearance10.BackGradientStyle = (GradientStyle) 3;
    appearance10.BorderColor = SystemColors.Window;
    this.cboInspectionCompanies.DisplayLayout.Override.GroupByRowAppearance = (AppearanceBase) appearance10;
    ((AppearanceBase) appearance11).TextHAlignAsString = "Left";
    this.cboInspectionCompanies.DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance11;
    this.cboInspectionCompanies.DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 3;
    this.cboInspectionCompanies.DisplayLayout.Override.HeaderStyle = (HeaderStyle) 2;
    appearance12.BackColor = Color.FromArgb(240 /*0xF0*/, 246, 254);
    appearance12.BorderColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this.cboInspectionCompanies.DisplayLayout.Override.HotTrackRowAppearance = (AppearanceBase) appearance12;
    appearance13.BackColor = SystemColors.Window;
    appearance13.BorderColor = Color.White;
    this.cboInspectionCompanies.DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance13;
    this.cboInspectionCompanies.DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    this.cboInspectionCompanies.DisplayLayout.Override.RowSpacingAfter = 1;
    appearance14.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance14.BorderColor = Color.FromArgb((int) byte.MaxValue, 214, 88);
    appearance14.ForeColor = Color.Black;
    this.cboInspectionCompanies.DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance14;
    appearance15.BackColor = SystemColors.ControlLight;
    this.cboInspectionCompanies.DisplayLayout.Override.TemplateAddRowAppearance = (AppearanceBase) appearance15;
    scrollBarLook1.ViewStyle = (ScrollBarViewStyle) 3;
    this.cboInspectionCompanies.DisplayLayout.ScrollBarLook = scrollBarLook1;
    this.cboInspectionCompanies.DisplayLayout.ScrollBounds = (ScrollBounds) 0;
    this.cboInspectionCompanies.DisplayLayout.ScrollStyle = (ScrollStyle) 1;
    this.cboInspectionCompanies.DisplayLayout.ViewStyleBand = (ViewStyleBand) 2;
    ((UltraDropDownBase) this.cboInspectionCompanies).DisplayMember = "PayeeName";
    this.cboInspectionCompanies.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboInspectionCompanies).Location = new Point(136, 14);
    this.cboInspectionCompanies.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboInspectionCompanies).Name = "cboInspectionCompanies";
    ((Control) this.cboInspectionCompanies).Size = new Size(248, 21);
    ((Control) this.cboInspectionCompanies).TabIndex = 5;
    ((UltraControlBase) this.cboInspectionCompanies).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboInspectionCompanies).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboInspectionCompanies).ValueMember = "PayeeID";
    this.ds.DataSetName = "dsInspectionRequest";
    this.ds.Locale = new CultureInfo("en-US");
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    ((Control) this.gridLocations).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraGridBase) this.gridLocations).DataSource = (object) this.ds.Locations;
    appearance16.BackColor = Color.White;
    appearance16.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.gridLocations).DisplayLayout.Appearance = (AppearanceBase) appearance16;
    ((UltraGridBase) this.gridLocations).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn4.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance17).TextHAlignAsString = "Center";
    ultraGridColumn4.CellAppearance = (AppearanceBase) appearance17;
    ((HeaderBase) ultraGridColumn4.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn4.Header.VisiblePosition = 0;
    ultraGridColumn4.Hidden = true;
    ultraGridColumn4.Width = 80 /*0x50*/;
    ultraGridColumn5.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn5.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn5.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn5.Header.VisiblePosition = 2;
    ultraGridColumn5.Width = 198;
    ultraGridColumn6.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn6.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn6.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn6.Header.VisiblePosition = 4;
    ultraGridColumn6.Width = 139;
    ultraGridColumn7.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn7.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn7.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn7.Header.VisiblePosition = 5;
    ultraGridColumn7.Width = 47;
    ultraGridColumn8.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn8.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn8.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn8.Header.VisiblePosition = 6;
    ultraGridColumn8.Width = 74;
    ultraGridColumn9.AutoCompleteMode = (AutoCompleteMode) 2;
    appearance18.FontData.UnderlineAsString = "True";
    appearance18.ForeColor = Color.Blue;
    ((AppearanceBase) appearance18).TextHAlignAsString = "Center";
    ultraGridColumn9.CellAppearance = (AppearanceBase) appearance18;
    ((HeaderBase) ultraGridColumn9.Header).Caption = "Inspect";
    ((HeaderBase) ultraGridColumn9.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn9.Header.VisiblePosition = 8;
    ultraGridColumn9.Width = 44;
    ultraGridColumn10.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn10.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn10.Header.VisiblePosition = 1;
    ultraGridColumn10.Width = 167;
    ultraGridColumn11.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn11.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn11.Header.VisiblePosition = 9;
    ultraGridColumn11.Hidden = true;
    ultraGridColumn11.Width = 58;
    ultraGridColumn12.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn12.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn12.Header.VisiblePosition = 3;
    ultraGridColumn12.Hidden = true;
    ultraGridColumn12.Width = 71;
    ultraGridColumn13.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn13.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn13.Header.VisiblePosition = 10;
    ultraGridColumn13.Hidden = true;
    ultraGridColumn13.Width = 61;
    ultraGridColumn14.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn14.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn14.Header.VisiblePosition = 11;
    ultraGridColumn14.Hidden = true;
    ultraGridColumn14.Width = 71;
    ultraGridColumn15.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn15.Header).Caption = "Due Date";
    ((HeaderBase) ultraGridColumn15.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn15.Header.VisiblePosition = 7;
    ultraGridColumn15.Width = 76;
    ultraGridColumn16.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn16.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn16.Header.VisiblePosition = 12;
    ultraGridBand2.Columns.AddRange(new object[13]
    {
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
    ultraGridColumn17.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn17.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn17.Header.VisiblePosition = 0;
    ultraGridColumn18.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn18.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn18.Header.VisiblePosition = 1;
    ultraGridColumn19.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn19.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn19.Header.VisiblePosition = 2;
    ultraGridColumn20.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn20.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn20.Header.VisiblePosition = 3;
    ultraGridColumn21.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn21.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn21.Header.VisiblePosition = 4;
    ultraGridColumn22.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn22.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn22.Header.VisiblePosition = 5;
    ultraGridColumn23.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn23.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn23.Header.VisiblePosition = 6;
    ultraGridColumn24.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn24.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn24.Header.VisiblePosition = 7;
    ultraGridColumn25.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn25.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn25.Header.VisiblePosition = 8;
    ultraGridColumn26.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn26.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn26.Header.VisiblePosition = 9;
    ((HeaderBase) ultraGridColumn27.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn27.Header.VisiblePosition = 10;
    ((HeaderBase) ultraGridColumn28.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn28.Header.VisiblePosition = 11;
    ((HeaderBase) ultraGridColumn29.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn29.Header.VisiblePosition = 12;
    ultraGridBand3.Columns.AddRange(new object[13]
    {
      (object) ultraGridColumn17,
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
      (object) ultraGridColumn28,
      (object) ultraGridColumn29
    });
    ((UltraGridBase) this.gridLocations).DisplayLayout.BandsSerializer.Add((object) ultraGridBand2);
    ((UltraGridBase) this.gridLocations).DisplayLayout.BandsSerializer.Add((object) ultraGridBand3);
    ((UltraGridBase) this.gridLocations).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance19.BackColor = Color.LightSteelBlue;
    appearance19.FontData.SizeInPoints = 10f;
    appearance19.ForeColor = Color.Navy;
    ((UltraGridBase) this.gridLocations).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance19;
    appearance20.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance20.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance20.ForeColor = Color.Black;
    ((UltraGridBase) this.gridLocations).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance20;
    ((UltraGridBase) this.gridLocations).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.gridLocations).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    appearance21.BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridLocations).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance21;
    appearance22.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.gridLocations).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance22;
    ((UltraGridBase) this.gridLocations).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance23.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.gridLocations).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance23;
    appearance24.BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridLocations).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance24;
    ((UltraGridBase) this.gridLocations).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance25.BackColor = Color.Transparent;
    appearance25.ForeColor = Color.Black;
    ((UltraGridBase) this.gridLocations).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance25;
    appearance26.BackColor = Color.WhiteSmoke;
    appearance26.BorderColor = Color.Silver;
    scrollBarLook2.ButtonAppearance = (AppearanceBase) appearance26;
    appearance27.BackColor = Color.White;
    scrollBarLook2.TrackAppearance = (AppearanceBase) appearance27;
    ((UltraGridBase) this.gridLocations).DisplayLayout.ScrollBarLook = scrollBarLook2;
    ((UltraGridBase) this.gridLocations).DisplayLayout.ViewStyle = (ViewStyle) 0;
    ((Control) this.gridLocations).Font = new Font("Tahoma", 8.25f);
    ((Control) this.gridLocations).Location = new Point(16 /*0x10*/, 72);
    ((Control) this.gridLocations).Name = "gridLocations";
    ((Control) this.gridLocations).Size = new Size(747, 173);
    ((Control) this.gridLocations).TabIndex = 3;
    ((Control) this.gridLocations).Text = "Locations On This Policy";
    ((Control) this.grid).Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraGridBase) this.grid).DataSource = (object) this.ds.InspectionRequest;
    appearance28.BackColor = Color.White;
    appearance28.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.grid).DisplayLayout.Appearance = (AppearanceBase) appearance28;
    ((UltraGridBase) this.grid).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn30.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance29).TextHAlignAsString = "Center";
    ultraGridColumn30.CellAppearance = (AppearanceBase) appearance29;
    ((HeaderBase) ultraGridColumn30.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn30.Header.VisiblePosition = 0;
    ultraGridColumn30.Hidden = true;
    ultraGridColumn30.Width = 75;
    ultraGridColumn31.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn31.Header).Caption = "Cost Est";
    ((HeaderBase) ultraGridColumn31.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn31.Header.VisiblePosition = 2;
    ultraGridColumn31.Width = 46;
    ultraGridColumn32.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn32.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn32.Header.VisiblePosition = 3;
    ultraGridColumn32.Width = 36;
    ultraGridColumn33.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn33.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn33.Header.VisiblePosition = 4;
    ultraGridColumn33.Width = 40;
    ultraGridColumn34.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn34.Header).Caption = "Location Contact";
    ((HeaderBase) ultraGridColumn34.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn34.Header.VisiblePosition = 5;
    ultraGridColumn34.Width = 130;
    ultraGridColumn35.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn35.Header).Caption = "Contact Phone";
    ((HeaderBase) ultraGridColumn35.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn35.Header.VisiblePosition = 6;
    ultraGridColumn35.Width = 69;
    ultraGridColumn36.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn36.Header).Caption = "Special Instructions";
    ((HeaderBase) ultraGridColumn36.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn36.Header.VisiblePosition = 7;
    ultraGridColumn36.MaxLength = 2000;
    ultraGridColumn36.Width = 103;
    ultraGridColumn37.AutoCompleteMode = (AutoCompleteMode) 2;
    appearance30.FontData.UnderlineAsString = "True";
    appearance30.ForeColor = Color.Blue;
    ((AppearanceBase) appearance30).TextHAlignAsString = "Center";
    ultraGridColumn37.CellAppearance = (AppearanceBase) appearance30;
    ((HeaderBase) ultraGridColumn37.Header).Caption = "Remove";
    ((HeaderBase) ultraGridColumn37.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn37.Header.VisiblePosition = 9;
    ultraGridColumn37.Width = 52;
    ultraGridColumn38.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn38.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn38.Header.VisiblePosition = 10;
    ultraGridColumn38.Hidden = true;
    ultraGridColumn38.Width = 58;
    ultraGridColumn39.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn39.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn39.Header).Caption = "Due Date";
    ((HeaderBase) ultraGridColumn39.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn39.Header.VisiblePosition = 8;
    ultraGridColumn39.Width = 59;
    ultraGridColumn40.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn40.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn40.Header.VisiblePosition = 1;
    ultraGridColumn40.Width = 118;
    ((HeaderBase) ultraGridColumn41.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn41.Header.VisiblePosition = 11;
    ultraGridColumn41.Width = 36;
    ((HeaderBase) ultraGridColumn42.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn42.Header.VisiblePosition = 12;
    ultraGridColumn42.Width = 56;
    ultraGridBand4.Columns.AddRange(new object[13]
    {
      (object) ultraGridColumn30,
      (object) ultraGridColumn31,
      (object) ultraGridColumn32,
      (object) ultraGridColumn33,
      (object) ultraGridColumn34,
      (object) ultraGridColumn35,
      (object) ultraGridColumn36,
      (object) ultraGridColumn37,
      (object) ultraGridColumn38,
      (object) ultraGridColumn39,
      (object) ultraGridColumn40,
      (object) ultraGridColumn41,
      (object) ultraGridColumn42
    });
    ((UltraGridBase) this.grid).DisplayLayout.BandsSerializer.Add((object) ultraGridBand4);
    ((UltraGridBase) this.grid).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance31.BackColor = Color.LightSteelBlue;
    appearance31.FontData.SizeInPoints = 10f;
    appearance31.ForeColor = Color.Navy;
    ((UltraGridBase) this.grid).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance31;
    appearance32.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance32.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance32.ForeColor = Color.Black;
    ((UltraGridBase) this.grid).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance32;
    ((UltraGridBase) this.grid).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.grid).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    appearance33.BorderColor = Color.LightGray;
    ((UltraGridBase) this.grid).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance33;
    appearance34.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.grid).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance34;
    ((UltraGridBase) this.grid).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance35.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.grid).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance35;
    appearance36.BorderColor = Color.LightGray;
    ((UltraGridBase) this.grid).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance36;
    ((UltraGridBase) this.grid).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance37.BackColor = Color.Transparent;
    appearance37.ForeColor = Color.Black;
    ((UltraGridBase) this.grid).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance37;
    appearance38.BackColor = Color.WhiteSmoke;
    appearance38.BorderColor = Color.Silver;
    scrollBarLook3.ButtonAppearance = (AppearanceBase) appearance38;
    appearance39.BackColor = Color.White;
    scrollBarLook3.TrackAppearance = (AppearanceBase) appearance39;
    ((UltraGridBase) this.grid).DisplayLayout.ScrollBarLook = scrollBarLook3;
    ((Control) this.grid).Location = new Point(16 /*0x10*/, 253);
    ((Control) this.grid).Name = "grid";
    ((Control) this.grid).Size = new Size(747, 160 /*0xA0*/);
    ((Control) this.grid).TabIndex = 1;
    ((Control) this.grid).Text = "Locations To Be Inspected";
    ((UltraControlBase) this.grid).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.grid).UseOsThemes = (DefaultableBoolean) 2;
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.White;
    this.ClientSize = new Size(771, 451);
    this.Controls.Add((Control) this.GroupBox1);
    this.Controls.Add((Control) this.cboInspectionCompanies);
    this.Controls.Add((Control) this.Label2);
    this.Controls.Add((Control) this.Label1);
    this.Controls.Add((Control) this.gridLocations);
    this.Controls.Add((Control) this.btnRequestInspections);
    this.Controls.Add((Control) this.grid);
    this.Font = new Font("Tahoma", 8.25f);
    this.ForeColor = Color.Black;
    this.Name = nameof (frmInspectionRequest);
    this.Text = "Request Inspection";
    ((ISupportInitialize) this.btnRequestInspections).EndInit();
    ((ISupportInitialize) this.err).EndInit();
    ((ISupportInitialize) this.optionInspMethod).EndInit();
    this.GroupBox1.ResumeLayout(false);
    ((ISupportInitialize) this.cboInspectionCompanies).EndInit();
    this.ds.EndInit();
    ((ISupportInitialize) this.gridLocations).EndInit();
    ((ISupportInitialize) this.grid).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  public frmInspectionRequest()
  {
    this.Load += new EventHandler(this.frmInspectionRequest_Load);
    this._inspectLink = new HyperlinkEditor();
    this._removeLink = new HyperlinkEditor();
    this._duplicateLocationNameAndNumber = false;
    this._storedProc = string.Empty;
    this._successfulRequest = false;
    this.InitializeComponent();
  }

  public frmInspectionRequest(Guid quoteGuid, Guid lineGuid)
  {
    this.Load += new EventHandler(this.frmInspectionRequest_Load);
    this._inspectLink = new HyperlinkEditor();
    this._removeLink = new HyperlinkEditor();
    this._duplicateLocationNameAndNumber = false;
    this._storedProc = string.Empty;
    this._successfulRequest = false;
    this.InitializeComponent();
    this._quote = new Quote(quoteGuid);
    this._lineGuid = lineGuid;
    this._cn = DefaultDatabase.CreateConnection();
  }

  public string LocationsStoredProcedure
  {
    get
    {
      if (this._storedProc.Equals(string.Empty))
        this._storedProc = this.GetNetrateLocationsProc();
      return this._storedProc;
    }
  }

  public bool SuccessfulRequest => this._successfulRequest;

  private void frmInspectionRequest_Load(object sender, EventArgs e)
  {
    if (this.DesignMode)
      return;
    SqlDataAdapter daNetRateLoc = this.daNetRateLoc;
    daNetRateLoc.SelectCommand.Connection = this._cn;
    daNetRateLoc.DeleteCommand.Connection = this._cn;
    daNetRateLoc.InsertCommand.Connection = this._cn;
    daNetRateLoc.UpdateCommand.Connection = this._cn;
    this._inspReq = (InspectionRequest) ObjectFactory.Instance.CreateObjectEX(typeof (InspectionRequest), (object) this._quote.QuoteGuid);
    this._isPropertyLine = this._inspReq.IsPropertyLine(this._lineGuid);
    this._isAutoLine = this._inspReq.IsAutoLine(this._lineGuid);
    this._isWorkersCompLine = this._inspReq.IsWorkersCompLine(this._lineGuid);
    this._inspReq.LineGuid = this._lineGuid;
    DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[1]
    {
      "InspectionCompanies"
    }, "dbo.GetInspectionCompanies", new object[4]
    {
      (object) "@quoteID",
      (object) this._quote.QuoteID,
      (object) "@LineGuid",
      (object) this._lineGuid
    });
    if (this.ds.InspectionCompanies.Count == 1)
      this.cboInspectionCompanies.Value = (object) this.ds.InspectionCompanies[0].PayeeID;
    frmInspectionRequest.LoadBaseLocationsForNetRate(this.GetNetrateLocationsProc(), this.ds, this._quote.QuoteID, this._lineGuid);
    if (this.ds.Locations.Rows.Count == 0)
    {
      int num = (int) MessageBox.Show("There are no locations to be inspected found on this quote", "No Locations Found", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    this._inspectLink.HyperLinkOpening += new CancelEventHandler(this.InspectLink_HyperLinkOpening);
    this._removeLink.HyperLinkOpening += new CancelEventHandler(this.RemoveLink_HyperLinkOpening);
    ((UltraGridBase) this.gridLocations).DisplayLayout.Bands[0].Columns["InspectLink"].Editor = (EmbeddableEditorBase) this._inspectLink;
    ((UltraGridBase) this.grid).DisplayLayout.Bands[0].Columns["RemoveLink"].Editor = (EmbeddableEditorBase) this._removeLink;
    DataRow dataRow = DefaultDatabase.ExecuteDataRow("dbo.GetInspectionInsuredContactInformation", new object[2]
    {
      (object) "@InsuredGuid",
      (object) this._quote.SubmissionGroup.InsuredGuid
    });
    if (dataRow != null)
    {
      if (dataRow["FName"] != DBNull.Value && dataRow["LName"] != DBNull.Value)
        this._locationContactName = $"{(string) dataRow["LName"]}, {(string) dataRow["FName"]}";
      if (dataRow["Phone"] != DBNull.Value)
        this._locationContactPhone = (string) dataRow["Phone"];
    }
    this.SetSelectedInspectionMethod(0);
    if (!SystemSettings.KeyExists("DuplicateLocationContactAndNumber"))
      return;
    this._duplicateLocationNameAndNumber = SystemSettings.GetBoolSetting("DuplicateLocationContactAndNumber");
  }

  public static void LoadBaseLocationsForNetRate(
    string locationStoredProc,
    dsInspectionRequest tmpds,
    int tmpQuoteID,
    Guid lineGuid)
  {
    DefaultDatabase.LoadDataSet((DataSet) tmpds, new string[1]
    {
      "Locations"
    }, locationStoredProc, new object[4]
    {
      (object) "@quoteID",
      (object) tmpQuoteID,
      (object) "@lineGuid",
      (object) lineGuid
    });
  }

  private void RemoveLink_HyperLinkOpening(object sender, CancelEventArgs e)
  {
    e.Cancel = true;
    if (MessageBox.Show("Are you sure you want to remove this location from the inspection request?", "Remove Location?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
      return;
    int integer = Conversions.ToInteger(((UltraGridBase) this.grid).ActiveRow.Cells["UniqueID"].Value);
    this.ds.InspectionRequest.RemoveInspectionRequestRow((dsInspectionRequest.InspectionRequestRow) this.ds.InspectionRequest.Select("UniqueID = " + Conversions.ToString(integer))[0]);
    foreach (UltraGridRow row in ((UltraGridBase) this.gridLocations).Rows)
    {
      if (Conversions.ToInteger(row.Cells["UniqueID"].Value) == integer)
      {
        row.Hidden = false;
        break;
      }
    }
  }

  private void InspectLink_HyperLinkOpening(object sender, CancelEventArgs e)
  {
    e.Cancel = true;
    int integer1 = Conversions.ToInteger(((UltraGridBase) this.gridLocations).ActiveRow.Cells["LocationID"].Value);
    int integer2 = Conversions.ToInteger(((UltraGridBase) this.gridLocations).ActiveRow.Cells["UniqueID"].Value);
    dsInspectionRequest.InspectionRequestRow inspectionRequestRow = this.ds.InspectionRequest.NewInspectionRequestRow();
    inspectionRequestRow.LocationID = integer1;
    inspectionRequestRow.UniqueID = integer2;
    this.SetLocationContact(inspectionRequestRow);
    this.SetLocationPhone(inspectionRequestRow);
    this.DuplicateLocationContactNameAndNumber(inspectionRequestRow);
    if (((UltraGridBase) this.gridLocations).ActiveRow.Cells["Location"].Value != null && ((UltraGridBase) this.gridLocations).ActiveRow.Cells["Location"].Value != DBNull.Value)
      inspectionRequestRow.Location = ((UltraGridBase) this.gridLocations).ActiveRow.Cells["Location"].Value.ToString();
    else
      inspectionRequestRow.SetLocationNull();
    if (((UltraGridBase) this.gridLocations).ActiveRow.Cells["DueDate"].Value != null && ((UltraGridBase) this.gridLocations).ActiveRow.Cells["DueDate"].Value != DBNull.Value)
      inspectionRequestRow.DueDate = Conversions.ToDate(((UltraGridBase) this.gridLocations).ActiveRow.Cells["DueDate"].Value);
    else
      inspectionRequestRow.SetDueDateNull();
    try
    {
      ((UltraGridBase) this.gridLocations).ActiveRow.Hidden = true;
      this.ds.InspectionRequest.AddInspectionRequestRow(inspectionRequestRow);
    }
    catch (ConstraintException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      ProjectData.ClearProjectError();
    }
    this.InitializeNewRow(inspectionRequestRow);
  }

  protected virtual bool ValidateForm() => true;

  protected virtual bool ValidateContactAndPhone(dsInspectionRequest.InspectionRequestRow row)
  {
    return !row.IsLocationContactNull() && !row.IsLocationContactPhoneNull();
  }

  protected virtual bool ValidateLocations()
  {
    bool flag;
    try
    {
      foreach (dsInspectionRequest.InspectionRequestRow row in this.ds.InspectionRequest.Rows)
      {
        if (!this.ValidateContactAndPhone(row))
        {
          int num = (int) MessageBox.Show("Please ensure that Location Contact and Location Contact Phone are all filled in.", "Empty Location / Location Contact Phone", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
          flag = false;
          goto label_12;
        }
        dsInspectionRequest.LocationsRow locationsRow = (dsInspectionRequest.LocationsRow) this.ds.Locations.Select("UniqueID = " + Conversions.ToString(row.UniqueID))[0];
        if (locationsRow.IsAddressNull())
        {
          int num = (int) MessageBox.Show("One or more locations have missing address information.\n\nAn inspection can not be requested.", "Missing Address Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          flag = false;
          goto label_12;
        }
        if (locationsRow.IsClassCodeNull())
        {
          int num = (int) MessageBox.Show("One or more locations have missing class code.\n\nAn inspection can not be requested.", "Missing Class Code Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          flag = false;
          goto label_12;
        }
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    flag = true;
label_12:
    return flag;
  }

  protected virtual bool DuplicateRequest()
  {
    bool flag;
    try
    {
      foreach (dsInspectionRequest.InspectionRequestRow row in this.ds.InspectionRequest.Rows)
      {
        object objectValue = RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT ID FROM tblNetRateInspectionInfo WHERE LocationID = @locID AND ControlNo = @cNO", new object[4]
        {
          (object) "@locID",
          (object) row.LocationID,
          (object) "@cNo",
          (object) this._quote.ControlNo
        }));
        if (objectValue != null && objectValue != DBNull.Value && MessageBox.Show($"Inspection has already been requested for \n\n{((dsInspectionRequest.LocationsRow) this.ds.Locations.Select("LocationID = " + Conversions.ToString(row.LocationID))[0]).Location}.\n\nWould you like to continue requesting inspections?", "Continue Requesting Inspections?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
        {
          flag = true;
          goto label_8;
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
label_8:
    return flag;
  }

  private void btnRequestInspections_Click(object sender, EventArgs e)
  {
    this.Cursor = MgaCursors.WaitCursor;
    try
    {
      ((Control) this.btnRequestInspections).Enabled = false;
      if (!this.ValidateForm())
        return;
      this._inspReq = (InspectionRequest) ObjectFactory.Instance.CreateObjectEX(typeof (InspectionRequest), (object) this._quote.QuoteGuid);
      if (((UltraGridBase) this.grid).ActiveRow == null || this.ds.InspectionRequest.Rows.Count == 0)
      {
        int num = (int) MessageBox.Show("Please select at least one location to be inspected.", "No Location Selected", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      }
      else
      {
        if (!this.ValidateLocations() || this.DuplicateRequest())
          return;
        if (this.cboInspectionCompanies.Value == null)
        {
          this.err.SetError((Control) this.cboInspectionCompanies, "Please select an inspection company.");
        }
        else
        {
          this.err.SetError((Control) this.cboInspectionCompanies, string.Empty);
          ((UltraGridBase) this.grid).UpdateData();
          InspectionRequest.BlackBoxMode = false;
          dsInspectionRequest.InspectionCompaniesRow byPayeeId = this.ds.InspectionCompanies.FindByPayeeID(Conversions.ToInteger(this.cboInspectionCompanies.Value));
          this._inspReq.ClientCode = byPayeeId.ClientCode;
          this._inspReq.InspectionCompanyID = byPayeeId.PayeeID;
          dsNetRateInspect dsNetRateInspect = new dsNetRateInspect();
          DateTime now = DateTime.Now;
          string address = string.Empty;
          try
          {
            foreach (dsInspectionRequest.InspectionRequestRow dsInspect in (TypedTableBase<dsInspectionRequest.InspectionRequestRow>) this.ds.InspectionRequest)
            {
              string contactName = !dsInspect.IsLocationContactNull() ? dsInspect.LocationContact : string.Empty;
              string contactPhone = !dsInspect.IsLocationContactPhoneNull() ? dsInspect.LocationContactPhone : string.Empty;
              string specialInstructions = !dsInspect.IsSpecialInstructionsNull() ? dsInspect.SpecialInstructions : string.Empty;
              dsInspectionRequest.LocationsRow dsLoc = (dsInspectionRequest.LocationsRow) this.ds.Locations.Select("UniqueID = " + Conversions.ToString(dsInspect.UniqueID))[0];
              string address2 = dsLoc.IsAddress2Null() ? string.Empty : dsLoc.Address2;
              if (!dsLoc.IsAddressNull())
                address = this._inspReq.OmitLocationAndBuildingNumbers() || this.OmitLocationAndBuildingNumbersOnLog() ? dsLoc.Address : $"{dsLoc.Location} - {dsLoc.Address}";
              else if (!dsLoc.IsLocationNull())
                address = dsLoc.Location + " - ";
              string sic = string.Empty;
              if (!dsLoc.IsSICNull())
                sic = dsLoc.SIC;
              object obj = (object) null;
              if (!dsInspect.IsDueDateNull())
                obj = (object) dsInspect.DueDate;
              bool flag1 = false;
              if (!dsInspect.IsRushNull())
                flag1 = dsInspect.Rush;
              bool flag2 = false;
              if (!dsInspect.IsRecCheckNull())
                flag2 = dsInspect.RecCheck;
              DefaultDatabase.ExecuteNonQuery("UpdateNetRateInspDueDates", new object[8]
              {
                (object) "@LocationID",
                (object) dsInspect.LocationID,
                (object) "@DueDate",
                obj,
                (object) "@Rush",
                (object) flag1,
                (object) "@RecCheck",
                (object) flag2
              });
              this._inspReq.NetRateDataset = this.ds;
              this._inspReq.AddNetRateLocation(dsInspect.LocationID, dsInspect.UniqueID, address, address2, dsLoc.City, dsLoc.State, dsLoc.ZipCode, dsLoc.ClassCode, sic, contactName, contactPhone, specialInstructions, this.grid, dsInspect.Location);
              this._inspReq.AddNetRateReport(dsInspect.LocationID, dsInspect.CostEstimator, dsInspect.Photo, dsInspect.Diagram);
              this.InsertNetRateLocationData(dsNetRateInspect, dsInspect, dsLoc, now);
            }
          }
          finally
          {
            IEnumerator<dsInspectionRequest.InspectionRequestRow> enumerator;
            enumerator?.Dispose();
          }
          this._inspReq.LineGuid = this._lineGuid;
          this._inspReq.InspectionMethod = (object) null;
          if (this.optionInspMethod.Value != null)
            this._inspReq.InspectionMethod = (object) (byte) this.optionInspMethod.Value;
          this.SaveNetRateInspectionData(dsNetRateInspect);
          this.Cursor = Cursors.WaitCursor;
          try
          {
            this._inspReq.Send();
            if (!this._inspReq.HasError)
              this._successfulRequest = true;
          }
          finally
          {
            this.Cursor = Cursors.Default;
          }
          if (this._inspReq.HasError)
            return;
          this.SaveNetRateData(dsNetRateInspect);
        }
      }
    }
    finally
    {
      ((Control) this.btnRequestInspections).Enabled = true;
      this.Cursor = MgaCursors.Default;
    }
  }

  protected virtual void SaveNetRateInspectionData(dsNetRateInspect dsNetRate)
  {
  }

  protected virtual void SaveNetRateData(dsNetRateInspect dsNetRate)
  {
    if (dsNetRate.tblNetRateInspectionInfo.Rows.Count <= 0)
      return;
    this.daNetRateLoc.Update((DataSet) dsNetRate);
  }

  protected virtual void SetSelectedInspectionMethod(int IndexSelected)
  {
    this.optionInspMethod.CheckedItem = this.optionInspMethod.Items[IndexSelected];
  }

  protected virtual string GetNetrateLocationsProc() => "dbo.GetNetRateLocations";

  protected virtual void InitializeNewRow(dsInspectionRequest.InspectionRequestRow row)
  {
  }

  protected virtual void ClientAfterCellUpdate(object sender, CellEventArgs e)
  {
  }

  protected virtual bool OmitLocationAndBuildingNumbersOnLog() => false;

  private void InsertNetRateLocationData(
    dsNetRateInspect ds,
    dsInspectionRequest.InspectionRequestRow dsInspect,
    dsInspectionRequest.LocationsRow dsLoc,
    DateTime DateInspected)
  {
    dsNetRateInspect.tblNetRateInspectionInfoRow row = ds.tblNetRateInspectionInfo.NewtblNetRateInspectionInfoRow();
    row.ControlNo = this._quote.ControlNo;
    row.LocationID = dsInspect.LocationID;
    if (!dsInspect.IsLocationContactNull())
      row.LocationContact = dsInspect.LocationContact;
    else
      row.SetLocationContactNull();
    if (!dsInspect.IsLocationContactPhoneNull())
      row.ContactPhone = dsInspect.LocationContactPhone;
    else
      row.SetContactPhoneNull();
    if (!dsInspect.IsSpecialInstructionsNull())
      row.SpecialInstructions = dsInspect.SpecialInstructions;
    else
      row.SetSpecialInstructionsNull();
    if (this._isPropertyLine)
    {
      row.PremesisID = dsInspect.UniqueID;
      row.SetExposureIDNull();
    }
    else if (this._isAutoLine)
    {
      row.SetPremesisIDNull();
      row.SetExposureIDNull();
    }
    else if (this._isWorkersCompLine)
    {
      row.SetExposureIDNull();
      row.SetPremesisIDNull();
      row.WorkersCompID = dsInspect.UniqueID;
    }
    else
    {
      row.ExposureID = dsInspect.UniqueID;
      row.SetPremesisIDNull();
    }
    if (!dsLoc.IsAddressNull())
      row.Address1 = dsLoc.Address;
    else
      row.SetAddress1Null();
    if (!dsLoc.IsAddress2Null())
      row.Address2 = dsLoc.Address2;
    else
      row.SetAddress2Null();
    if (!dsLoc.IsCityNull())
      row.City = dsLoc.City;
    else
      row.SetCityNull();
    if (!dsLoc.IsStateNull())
      row.State = dsLoc.State;
    else
      row.SetStateNull();
    if (!dsLoc.IsZipCodeNull())
      row.Zip = dsLoc.ZipCode;
    else
      row.SetZipNull();
    if (!dsLoc.IsSICNull())
      row.SIC = dsLoc.SIC;
    else
      row.SetSICNull();
    row.CostEstimation = dsInspect.CostEstimator;
    row.Diagram = dsInspect.Diagram;
    row.Photo = dsInspect.Photo;
    row.InspectionCompanyID = this._inspReq.InspectionCompanyID;
    row.QuoteID = this._quote.QuoteID;
    row.DateInspected = DateInspected;
    if (this.optionInspMethod.Value != null)
      row.InspectionMethod = (byte) this.optionInspMethod.Value;
    ds.tblNetRateInspectionInfo.AddtblNetRateInspectionInfoRow(row);
  }

  private void grid_AfterCellUpdate(object sender, CellEventArgs e)
  {
    this.grid.AfterCellUpdate -= new CellEventHandler(this.grid_AfterCellUpdate);
    try
    {
      this.ClientAfterCellUpdate(RuntimeHelpers.GetObjectValue(sender), e);
    }
    finally
    {
      this.grid.AfterCellUpdate += new CellEventHandler(this.grid_AfterCellUpdate);
    }
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing)
    {
      if (this.components != null)
        this.components.Dispose();
      if (this._inspectLink != null)
      {
        this._inspectLink.HyperLinkOpening -= new CancelEventHandler(this.InspectLink_HyperLinkOpening);
        ((DisposableObject) this._inspectLink).Dispose();
      }
      if (this._removeLink != null)
      {
        this._removeLink.HyperLinkOpening -= new CancelEventHandler(this.RemoveLink_HyperLinkOpening);
        ((DisposableObject) this._removeLink).Dispose();
      }
      if (this._cn != null)
        this._cn.Dispose();
    }
    base.Dispose(disposing);
  }

  private void cboInspectionCompanies_ValueChanged(object sender, EventArgs e)
  {
    this.InspectionCompaniesValueChange(RuntimeHelpers.GetObjectValue(sender), e);
  }

  protected virtual void InspectionCompaniesValueChange(object sender, EventArgs e)
  {
  }

  protected virtual void SetLocationContact(dsInspectionRequest.InspectionRequestRow dr)
  {
    dr.LocationContact = this._locationContactName;
  }

  protected virtual void SetLocationPhone(dsInspectionRequest.InspectionRequestRow dr)
  {
    dr.LocationContactPhone = this._locationContactPhone;
  }

  private void DuplicateLocationContactNameAndNumber(dsInspectionRequest.InspectionRequestRow dr)
  {
    if (!this._duplicateLocationNameAndNumber || this.ds.InspectionRequest.Count <= 0)
      return;
    if (!this.ds.InspectionRequest[this.ds.InspectionRequest.Count - 1].IsLocationContactNull())
      dr.LocationContact = this.ds.InspectionRequest[this.ds.InspectionRequest.Count - 1].LocationContact;
    if (this.ds.InspectionRequest[this.ds.InspectionRequest.Count - 1].IsLocationContactPhoneNull())
      return;
    dr.LocationContactPhone = this.ds.InspectionRequest[this.ds.InspectionRequest.Count - 1].LocationContactPhone;
  }

  protected enum InspectionMethod
  {
    PhoneSurvey,
    PhysicalInspection,
  }
}
