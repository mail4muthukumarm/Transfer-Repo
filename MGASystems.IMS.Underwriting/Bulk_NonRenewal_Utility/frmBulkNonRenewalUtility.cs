// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Underwriting.Bulk_NonRenewal_Utility.frmBulkNonRenewalUtility
// Assembly: MGASystems.IMS.Underwriting, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 1057C5B8-8299-4767-8242-AF9F1EF932DB
// Assembly location: D:\augusta\fortegra\IMS Project\MGASystems.IMS.Underwriting.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.IMS.Underwriting.Bulk_Renewal_Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Underwriting.Bulk_NonRenewal_Utility;

public class frmBulkNonRenewalUtility : FormBase
{
  private IContainer components;
  protected UltraDateTimeEditor dtFrom;
  protected UltraComboEditor ddlLine;
  protected UltraComboEditor ddlLocations;
  protected UltraLabel ultraLabel4;
  protected UltraLabel lblExpirationDate;
  protected UltraDateTimeEditor dtTo;
  protected UltraButton btnSearch;
  protected UltraButton btnCancel;
  protected UltraLabel lblLine;
  protected UltraLabel lblLocations;
  protected UltraComboEditor ddState;
  protected UltraLabel ultraLabel1;
  protected UltraGrid ugProducers;
  protected UltraLabel lblProducers;
  protected UltraComboEditor ddlOffice;
  protected UltraLabel lblOffice;
  private dsNonRenwalSelection dsNonRenwalSelection1;
  private ErrorProvider err;
  protected UltraButton btnSkipSearch;

  public frmBulkNonRenewalUtility() => this.InitializeComponent();

  private void frmBulkNonRenewalUtility_Load(object sender, EventArgs e)
  {
    if (this.DesignMode)
      return;
    this.FillSelectionCriteria();
  }

  protected DataTable Producers
  {
    get
    {
      return this.dsNonRenwalSelection1.Tables.Count > 0 ? this.dsNonRenwalSelection1.Tables["tblproducers"] ?? this.dsNonRenwalSelection1.Tables[0] : (DataTable) null;
    }
  }

  protected virtual string StoredProcedure => "spGetBulkNonRenewalUtilityList";

  private void FillSelectionCriteria()
  {
    DefaultDatabase.LoadDataSet((DataSet) this.dsNonRenwalSelection1, new string[6]
    {
      this.dsNonRenwalSelection1.tblProducers.TableName,
      this.dsNonRenwalSelection1.Company.TableName,
      this.dsNonRenwalSelection1.Lines.TableName,
      this.dsNonRenwalSelection1.lstStates.TableName,
      this.dsNonRenwalSelection1.lstQuoteStatusReasons.TableName,
      this.dsNonRenwalSelection1.tblClientOffices.TableName
    }, "spBulkNonRenewals_GetSelectionCriteria");
    this.dtFrom.Value = (object) DateTime.Today;
    this.dtTo.Value = (object) DateTime.Today;
  }

  public bool ValidateInputs()
  {
    if (this.Producers.Select("Selected = 1").Length <= 200 || this.Producers.Rows[0].Field<bool>("Selected"))
      return true;
    this.err.SetError((Control) this.ugProducers, "Cannot have more than 200 producers selected unless 'All Producers' is selected.");
    return false;
  }

  protected void AddParameterValue(List<object> listObj, string parameter, object value)
  {
    listObj.Add((object) parameter);
    listObj.Add(value);
  }

  protected void AddParameterFromCombo(List<object> listTo, UltraComboEditor control, string param)
  {
    if (control.SelectedItem == null || ((TextEditorControlBase) control).Value == null || ((TextEditorControlBase) control).Value == DBNull.Value)
      return;
    listTo.Add((object) param);
    listTo.Add(((TextEditorControlBase) control).Value);
  }

  protected virtual void GetNonRenewals(object senderbw, DoWorkEventArgs dwargs)
  {
    dsNonRenewalResults.NonRenewalsResultsDataTable resultsDataTable = new dsNonRenewalResults.NonRenewalsResultsDataTable();
    string str = string.Empty;
    Guid empty1 = Guid.Empty;
    Guid empty2 = Guid.Empty;
    string empty3 = string.Empty;
    Guid empty4 = Guid.Empty;
    if (this.Producers.Rows.Count > 0 && !this.Producers.Rows[0].Field<bool>("Selected"))
      str = string.Join(",", this.Producers.AsEnumerable().Where<DataRow>((System.Func<DataRow, bool>) (dr => dr.Field<bool>("Selected"))).Select<DataRow, string>((System.Func<DataRow, string>) (tr => tr.Field<Guid>("ProducerGUID").ToString())).ToArray<string>());
    if (!Utility.IsNull((object) this.ddlLocations.SelectedItem) && !Utility.IsNull(((TextEditorControlBase) this.ddlLocations).Value))
      empty1 = (Guid) ((TextEditorControlBase) this.ddlLocations).Value;
    if (!Utility.IsNull((object) this.ddlLine.SelectedItem) && !Utility.IsNull(((TextEditorControlBase) this.ddlLine).Value))
      empty2 = (Guid) ((TextEditorControlBase) this.ddlLine).Value;
    if (!Utility.IsNull((object) this.ddState.SelectedItem) && !Utility.IsNull(((TextEditorControlBase) this.ddState).Value))
      empty3 = ((TextEditorControlBase) this.ddState).Value.ToString();
    if (!Utility.IsNull((object) this.ddlOffice.SelectedItem) && !Utility.IsNull(((TextEditorControlBase) this.ddlOffice).Value))
      empty4 = (Guid) ((TextEditorControlBase) this.ddlOffice).Value;
    DefaultDatabase.LoadDataTable((DataTable) resultsDataTable, this.StoredProcedure, new object[14]
    {
      (object) "@ProducerGuids",
      (object) str,
      (object) "@CompanyLocationGuid",
      (object) empty1,
      (object) "@LineGuid",
      (object) empty2,
      (object) "@StateID",
      (object) empty3,
      (object) "@DateFrom",
      this.dtFrom.Value,
      (object) "@DateTo",
      this.dtTo.Value,
      (object) "@ClientOfficeGuid",
      (object) empty4
    });
    dwargs.Result = (object) resultsDataTable;
  }

  private void btnSearch_Click(object sender, EventArgs e)
  {
    if (!this.ValidateInputs())
      return;
    frmPleaseWaitMessage waitScreen = new frmPleaseWaitMessage("Searching for non- renewal candidates...");
    waitScreen.StartPosition = FormStartPosition.CenterScreen;
    waitScreen.TopMost = true;
    waitScreen.Show();
    try
    {
      Utility.ExecuteThread(new DoWorkEventHandler(this.GetNonRenewals), (RunWorkerCompletedEventHandler) ((objbw, wcargs) =>
      {
        waitScreen.Close();
        waitScreen = (frmPleaseWaitMessage) null;
        if (wcargs.Result == null)
          return;
        FormSettings.ShowForm(typeof (fmBulkNonRenewalResults), wcargs.Result);
        this.Close();
      }), (ProgressChangedEventHandler) null);
    }
    catch (Exception ex)
    {
      string message = ex.Message;
    }
  }

  private void ugProducers_CellChange(object sender, CellEventArgs e)
  {
    this.ugProducers.PerformAction((UltraGridAction) 44);
    this.ugProducers.PerformAction((UltraGridAction) 47);
    if (e.Cell.Row.Index == 0)
    {
      bool flag = (bool) e.Cell.Value;
      for (int index = 1; index < this.Producers.Rows.Count; ++index)
        this.Producers.Rows[index].SetField<bool>("Selected", flag);
    }
    else
      this.Producers.Rows[0].SetField<bool>("Selected", this.Producers.Select("ProducerGUID IS NOT NULL AND Selected = 1").Length >= this.Producers.Rows.Count - 1);
  }

  private void ultraButton1_Click(object sender, EventArgs e)
  {
    FormSettings.ShowForm(typeof (fmBulkNonRenewalResults));
    this.Close();
  }

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
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    UltraGridBand ultraGridBand = new UltraGridBand("tblProducers", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("ProducerGuid");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("ProducerName");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("Sort");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("Selected");
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    Appearance appearance11 = new Appearance();
    Appearance appearance12 = new Appearance();
    Appearance appearance13 = new Appearance();
    Appearance appearance14 = new Appearance();
    Appearance appearance15 = new Appearance();
    Appearance appearance16 = new Appearance();
    Appearance appearance17 = new Appearance();
    Appearance appearance18 = new Appearance();
    Appearance appearance19 = new Appearance();
    this.dtFrom = new UltraDateTimeEditor();
    this.ddlLine = new UltraComboEditor();
    this.dsNonRenwalSelection1 = new dsNonRenwalSelection();
    this.ddlLocations = new UltraComboEditor();
    this.ultraLabel4 = new UltraLabel();
    this.lblExpirationDate = new UltraLabel();
    this.dtTo = new UltraDateTimeEditor();
    this.btnSearch = new UltraButton();
    this.btnCancel = new UltraButton();
    this.lblLine = new UltraLabel();
    this.lblLocations = new UltraLabel();
    this.ddState = new UltraComboEditor();
    this.ultraLabel1 = new UltraLabel();
    this.ugProducers = new UltraGrid();
    this.lblProducers = new UltraLabel();
    this.ddlOffice = new UltraComboEditor();
    this.lblOffice = new UltraLabel();
    this.err = new ErrorProvider(this.components);
    this.btnSkipSearch = new UltraButton();
    ((ISupportInitialize) this.dtFrom).BeginInit();
    ((ISupportInitialize) this.ddlLine).BeginInit();
    this.dsNonRenwalSelection1.BeginInit();
    ((ISupportInitialize) this.ddlLocations).BeginInit();
    ((ISupportInitialize) this.dtTo).BeginInit();
    ((ISupportInitialize) this.ddState).BeginInit();
    ((ISupportInitialize) this.ugProducers).BeginInit();
    ((ISupportInitialize) this.ddlOffice).BeginInit();
    ((ISupportInitialize) this.err).BeginInit();
    this.SuspendLayout();
    this.dtFrom.DateTime = new DateTime(2020, 3, 12, 0, 0, 0, 0);
    ((Control) this.dtFrom).Location = new Point(131, 179);
    ((Control) this.dtFrom).Name = "dtFrom";
    ((Control) this.dtFrom).Size = new Size(96 /*0x60*/, 21);
    ((Control) this.dtFrom).TabIndex = 80 /*0x50*/;
    this.dtFrom.Value = (object) new DateTime(2020, 3, 12, 0, 0, 0, 0);
    ((Control) this.ddlLine).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
    this.ddlLine.DataMember = "Lines";
    this.ddlLine.DataSource = (object) this.dsNonRenwalSelection1;
    this.ddlLine.DisplayMember = "LineName";
    this.ddlLine.DropDownStyle = (DropDownStyle) 1;
    ((Control) this.ddlLine).Location = new Point(132, 125);
    ((Control) this.ddlLine).Name = "ddlLine";
    ((Control) this.ddlLine).Size = new Size(358, 21);
    ((Control) this.ddlLine).TabIndex = 72;
    this.ddlLine.ValueMember = "LineGUID";
    this.dsNonRenwalSelection1.DataSetName = "dsNonRenwalSelection";
    this.dsNonRenwalSelection1.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    ((Control) this.ddlLocations).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
    this.ddlLocations.DataMember = "Company";
    this.ddlLocations.DataSource = (object) this.dsNonRenwalSelection1;
    this.ddlLocations.DisplayMember = "CompanyName";
    this.ddlLocations.DropDownStyle = (DropDownStyle) 1;
    ((Control) this.ddlLocations).Location = new Point(132, 98);
    ((Control) this.ddlLocations).Name = "ddlLocations";
    ((Control) this.ddlLocations).Size = new Size(358, 21);
    ((Control) this.ddlLocations).TabIndex = 76;
    this.ddlLocations.ValueMember = "CompanyLocationGUID";
    ((AppearanceBase) appearance1).BackColorAlpha = (Alpha) 3;
    ((ControlBase) this.ultraLabel4).Appearance = (AppearanceBase) appearance1;
    ((Control) this.ultraLabel4).Location = new Point(232, 183);
    ((Control) this.ultraLabel4).Name = "ultraLabel4";
    ((Control) this.ultraLabel4).Size = new Size(19, 18);
    ((Control) this.ultraLabel4).TabIndex = 53;
    ((Control) this.ultraLabel4).Text = "to";
    ((AppearanceBase) appearance2).BackColorAlpha = (Alpha) 3;
    ((ControlBase) this.lblExpirationDate).Appearance = (AppearanceBase) appearance2;
    ((Control) this.lblExpirationDate).Location = new Point(17, 182);
    ((Control) this.lblExpirationDate).Name = "lblExpirationDate";
    ((Control) this.lblExpirationDate).Size = new Size(110, 18);
    ((Control) this.lblExpirationDate).TabIndex = 56;
    ((Control) this.lblExpirationDate).Text = "Expiration Date:";
    this.dtTo.DateTime = new DateTime(2020, 3, 12, 0, 0, 0, 0);
    ((Control) this.dtTo).Location = new Point(257, 179);
    ((Control) this.dtTo).Name = "dtTo";
    ((Control) this.dtTo).Size = new Size(96 /*0x60*/, 21);
    ((Control) this.dtTo).TabIndex = 79;
    this.dtTo.Value = (object) new DateTime(2020, 3, 12, 0, 0, 0, 0);
    ((Control) this.btnSearch).Anchor = AnchorStyles.Bottom;
    ((UltraButtonBase) this.btnSearch).DialogResult = DialogResult.Cancel;
    ((Control) this.btnSearch).Location = new Point(394, 234);
    ((Control) this.btnSearch).Name = "btnSearch";
    ((Control) this.btnSearch).Size = new Size(96 /*0x60*/, 23);
    ((Control) this.btnSearch).TabIndex = 68;
    ((Control) this.btnSearch).Text = "Search";
    ((Control) this.btnSearch).Click += new EventHandler(this.btnSearch_Click);
    ((Control) this.btnCancel).Anchor = AnchorStyles.Bottom;
    ((UltraButtonBase) this.btnCancel).DialogResult = DialogResult.Cancel;
    ((Control) this.btnCancel).Location = new Point(292, 234);
    ((Control) this.btnCancel).Name = "btnCancel";
    ((Control) this.btnCancel).Size = new Size(96 /*0x60*/, 23);
    ((Control) this.btnCancel).TabIndex = 69;
    ((Control) this.btnCancel).Text = "Cancel";
    ((AppearanceBase) appearance3).BackColorAlpha = (Alpha) 3;
    ((ControlBase) this.lblLine).Appearance = (AppearanceBase) appearance3;
    ((Control) this.lblLine).Location = new Point(15, 128 /*0x80*/);
    ((Control) this.lblLine).Name = "lblLine";
    ((Control) this.lblLine).Size = new Size(109, 18);
    ((Control) this.lblLine).TabIndex = 52;
    ((Control) this.lblLine).Text = "Line:";
    ((AppearanceBase) appearance4).BackColorAlpha = (Alpha) 3;
    ((ControlBase) this.lblLocations).Appearance = (AppearanceBase) appearance4;
    ((Control) this.lblLocations).Location = new Point(15, 101);
    ((Control) this.lblLocations).Name = "lblLocations";
    ((Control) this.lblLocations).Size = new Size(110, 18);
    ((Control) this.lblLocations).TabIndex = 60;
    ((Control) this.lblLocations).Text = "Company Locations:";
    ((Control) this.ddState).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
    this.ddState.DataMember = "lstStates";
    this.ddState.DataSource = (object) this.dsNonRenwalSelection1;
    this.ddState.DisplayMember = "State";
    this.ddState.DropDownStyle = (DropDownStyle) 1;
    ((Control) this.ddState).Location = new Point(132, 152);
    ((Control) this.ddState).Name = "ddState";
    ((Control) this.ddState).Size = new Size(222, 21);
    ((Control) this.ddState).TabIndex = 82;
    this.ddState.ValueMember = "StateId";
    ((AppearanceBase) appearance5).BackColorAlpha = (Alpha) 3;
    ((ControlBase) this.ultraLabel1).Appearance = (AppearanceBase) appearance5;
    ((Control) this.ultraLabel1).Location = new Point(17, 152);
    ((Control) this.ultraLabel1).Name = "ultraLabel1";
    ((Control) this.ultraLabel1).Size = new Size(109, 18);
    ((Control) this.ultraLabel1).TabIndex = 81;
    ((Control) this.ultraLabel1).Text = "State:";
    ((UltraGridBase) this.ugProducers).DataMember = "tblProducers";
    ((UltraGridBase) this.ugProducers).DataSource = (object) this.dsNonRenwalSelection1;
    ((AppearanceBase) appearance6).BackColor = SystemColors.Window;
    ((AppearanceBase) appearance6).BorderColor = SystemColors.InactiveCaption;
    ((UltraGridBase) this.ugProducers).DisplayLayout.Appearance = (AppearanceBase) appearance6;
    ((UltraGridBase) this.ugProducers).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridBand.ColHeadersVisible = false;
    ultraGridColumn1.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn1.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn1.Header).VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn1.Width = 315;
    ultraGridColumn2.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn2.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn2.Header).VisiblePosition = 1;
    ultraGridColumn2.Width = 210;
    ultraGridColumn3.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn3.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn3.Header).VisiblePosition = 2;
    ultraGridColumn3.Hidden = true;
    ultraGridColumn3.Width = 71;
    ((HeaderBase) ultraGridColumn4.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn4.Header).VisiblePosition = 3;
    ultraGridColumn4.Width = 129;
    ultraGridBand.Columns.AddRange(new object[4]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3,
      (object) ultraGridColumn4
    });
    ((UltraGridBase) this.ugProducers).DisplayLayout.BandsSerializer.Add((object) ultraGridBand);
    ((UltraGridBase) this.ugProducers).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.ugProducers).DisplayLayout.CaptionVisible = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance7).BackColor = SystemColors.ActiveBorder;
    ((AppearanceBase) appearance7).BackColor2 = SystemColors.ControlDark;
    ((AppearanceBase) appearance7).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance7).BorderColor = SystemColors.Window;
    ((SpecialBoxBase) ((UltraGridBase) this.ugProducers).DisplayLayout.GroupByBox).Appearance = (AppearanceBase) appearance7;
    ((AppearanceBase) appearance8).ForeColor = SystemColors.GrayText;
    ((UltraGridBase) this.ugProducers).DisplayLayout.GroupByBox.BandLabelAppearance = (AppearanceBase) appearance8;
    ((SpecialBoxBase) ((UltraGridBase) this.ugProducers).DisplayLayout.GroupByBox).BorderStyle = (UIElementBorderStyle) 4;
    ((SpecialBoxBase) ((UltraGridBase) this.ugProducers).DisplayLayout.GroupByBox).Hidden = true;
    ((AppearanceBase) appearance9).BackColor = SystemColors.ControlLightLight;
    ((AppearanceBase) appearance9).BackColor2 = SystemColors.Control;
    ((AppearanceBase) appearance9).BackGradientStyle = (GradientStyle) 3;
    ((AppearanceBase) appearance9).ForeColor = SystemColors.GrayText;
    ((UltraGridBase) this.ugProducers).DisplayLayout.GroupByBox.PromptAppearance = (AppearanceBase) appearance9;
    ((UltraGridBase) this.ugProducers).DisplayLayout.MaxColScrollRegions = 1;
    ((UltraGridBase) this.ugProducers).DisplayLayout.MaxRowScrollRegions = 1;
    ((AppearanceBase) appearance10).BackColor = SystemColors.Window;
    ((AppearanceBase) appearance10).ForeColor = SystemColors.ControlText;
    ((UltraGridBase) this.ugProducers).DisplayLayout.Override.ActiveCellAppearance = (AppearanceBase) appearance10;
    ((AppearanceBase) appearance11).BackColor = SystemColors.Highlight;
    ((AppearanceBase) appearance11).ForeColor = SystemColors.HighlightText;
    ((UltraGridBase) this.ugProducers).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance11;
    ((UltraGridBase) this.ugProducers).DisplayLayout.Override.AllowAddNew = (AllowAddNew) 2;
    ((UltraGridBase) this.ugProducers).DisplayLayout.Override.AllowColMoving = (AllowColMoving) 1;
    ((UltraGridBase) this.ugProducers).DisplayLayout.Override.AllowColSwapping = (AllowColSwapping) 1;
    ((UltraGridBase) this.ugProducers).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.ugProducers).DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 2;
    ((UltraGridBase) this.ugProducers).DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 2;
    ((AppearanceBase) appearance12).BackColor = SystemColors.Window;
    ((UltraGridBase) this.ugProducers).DisplayLayout.Override.CardAreaAppearance = (AppearanceBase) appearance12;
    ((AppearanceBase) appearance13).BorderColor = Color.Silver;
    ((AppearanceBase) appearance13).TextTrimming = (TextTrimming) 3;
    ((UltraGridBase) this.ugProducers).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance13;
    ((UltraGridBase) this.ugProducers).DisplayLayout.Override.CellClickAction = (CellClickAction) 4;
    ((UltraGridBase) this.ugProducers).DisplayLayout.Override.CellPadding = 0;
    ((AppearanceBase) appearance14).BackColor = SystemColors.Control;
    ((AppearanceBase) appearance14).BackColor2 = SystemColors.ControlDark;
    ((AppearanceBase) appearance14).BackGradientAlignment = (GradientAlignment) 1;
    ((AppearanceBase) appearance14).BackGradientStyle = (GradientStyle) 3;
    ((AppearanceBase) appearance14).BorderColor = SystemColors.Window;
    ((UltraGridBase) this.ugProducers).DisplayLayout.Override.GroupByRowAppearance = (AppearanceBase) appearance14;
    ((AppearanceBase) appearance15).TextHAlignAsString = "Left";
    ((UltraGridBase) this.ugProducers).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance15;
    ((UltraGridBase) this.ugProducers).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 3;
    ((UltraGridBase) this.ugProducers).DisplayLayout.Override.HeaderStyle = (HeaderStyle) 2;
    ((AppearanceBase) appearance16).BackColor = SystemColors.Window;
    ((AppearanceBase) appearance16).BorderColor = Color.Silver;
    ((UltraGridBase) this.ugProducers).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance16;
    ((UltraGridBase) this.ugProducers).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance17).BackColor = SystemColors.ControlLight;
    ((UltraGridBase) this.ugProducers).DisplayLayout.Override.TemplateAddRowAppearance = (AppearanceBase) appearance17;
    ((UltraGridBase) this.ugProducers).DisplayLayout.Scrollbars = (Scrollbars) 2;
    ((UltraGridBase) this.ugProducers).DisplayLayout.ScrollBounds = (ScrollBounds) 0;
    ((UltraGridBase) this.ugProducers).DisplayLayout.ScrollStyle = (ScrollStyle) 1;
    ((UltraGridBase) this.ugProducers).DisplayLayout.ViewStyleBand = (ViewStyleBand) 2;
    ((Control) this.ugProducers).Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.ugProducers).Location = new Point(132, 9);
    ((Control) this.ugProducers).Name = "ugProducers";
    ((Control) this.ugProducers).Size = new Size(358, 80 /*0x50*/);
    ((Control) this.ugProducers).TabIndex = 88;
    this.ugProducers.CellChange += new CellEventHandler(this.ugProducers_CellChange);
    ((AppearanceBase) appearance18).BackColorAlpha = (Alpha) 3;
    ((ControlBase) this.lblProducers).Appearance = (AppearanceBase) appearance18;
    ((Control) this.lblProducers).Location = new Point(17, 16 /*0x10*/);
    ((Control) this.lblProducers).Name = "lblProducers";
    ((Control) this.lblProducers).Size = new Size(109, 19);
    ((Control) this.lblProducers).TabIndex = 87;
    ((Control) this.lblProducers).Text = "Producer(s):";
    ((Control) this.ddlOffice).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
    this.ddlOffice.DataMember = "tblClientOffices";
    this.ddlOffice.DataSource = (object) this.dsNonRenwalSelection1;
    this.ddlOffice.DisplayMember = "OfficeName";
    this.ddlOffice.DropDownStyle = (DropDownStyle) 1;
    ((Control) this.ddlOffice).Location = new Point(131, 203);
    ((Control) this.ddlOffice).Name = "ddlOffice";
    ((Control) this.ddlOffice).Size = new Size(359, 21);
    ((Control) this.ddlOffice).TabIndex = 90;
    this.ddlOffice.ValueMember = "OfficeGUID";
    ((AppearanceBase) appearance19).BackColorAlpha = (Alpha) 3;
    ((ControlBase) this.lblOffice).Appearance = (AppearanceBase) appearance19;
    ((Control) this.lblOffice).Location = new Point(18, 206);
    ((Control) this.lblOffice).Name = "lblOffice";
    ((Control) this.lblOffice).Size = new Size(109, 18);
    ((Control) this.lblOffice).TabIndex = 89;
    ((Control) this.lblOffice).Text = "Issuing Office:";
    this.err.ContainerControl = (ContainerControl) this;
    ((Control) this.btnSkipSearch).Anchor = AnchorStyles.Bottom;
    ((UltraButtonBase) this.btnSkipSearch).DialogResult = DialogResult.Cancel;
    ((Control) this.btnSkipSearch).Location = new Point(108, 234);
    ((Control) this.btnSkipSearch).Name = "btnSkipSearch";
    ((Control) this.btnSkipSearch).Size = new Size(178, 23);
    ((Control) this.btnSkipSearch).TabIndex = 91;
    ((Control) this.btnSkipSearch).Text = "Skip Search / Upload Excel File";
    ((Control) this.btnSkipSearch).Click += new EventHandler(this.ultraButton1_Click);
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(502, 260);
    this.Controls.Add((Control) this.btnSkipSearch);
    this.Controls.Add((Control) this.ddlOffice);
    this.Controls.Add((Control) this.lblOffice);
    this.Controls.Add((Control) this.ugProducers);
    this.Controls.Add((Control) this.lblProducers);
    this.Controls.Add((Control) this.ddState);
    this.Controls.Add((Control) this.ultraLabel1);
    this.Controls.Add((Control) this.dtFrom);
    this.Controls.Add((Control) this.ddlLine);
    this.Controls.Add((Control) this.ddlLocations);
    this.Controls.Add((Control) this.ultraLabel4);
    this.Controls.Add((Control) this.lblExpirationDate);
    this.Controls.Add((Control) this.dtTo);
    this.Controls.Add((Control) this.btnSearch);
    this.Controls.Add((Control) this.btnCancel);
    this.Controls.Add((Control) this.lblLine);
    this.Controls.Add((Control) this.lblLocations);
    this.Name = nameof (frmBulkNonRenewalUtility);
    this.Text = "Bulk NonRenewal";
    this.Load += new EventHandler(this.frmBulkNonRenewalUtility_Load);
    ((ISupportInitialize) this.dtFrom).EndInit();
    ((ISupportInitialize) this.ddlLine).EndInit();
    this.dsNonRenwalSelection1.EndInit();
    ((ISupportInitialize) this.ddlLocations).EndInit();
    ((ISupportInitialize) this.dtTo).EndInit();
    ((ISupportInitialize) this.ddState).EndInit();
    ((ISupportInitialize) this.ugProducers).EndInit();
    ((ISupportInitialize) this.ddlOffice).EndInit();
    ((ISupportInitialize) this.err).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }
}
