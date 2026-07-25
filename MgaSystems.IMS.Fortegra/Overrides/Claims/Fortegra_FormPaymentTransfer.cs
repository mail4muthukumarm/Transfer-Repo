// Decompiled with JetBrains decompiler
// Type: MgaSystems.Ims.Fortegra.Overrides.Claims.Fortegra_FormPaymentTransfer
// Assembly: MgaSystems.Ims.Fortegra, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 27007E94-85B4-4A1A-9444-255CCA5487B0
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Fortegra.dll

using Infragistics.Shared;
using Infragistics.Win;
using Infragistics.Win.Layout;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using Infragistics.Win.UltraWinToolbars;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.IMS.Claims;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

#nullable disable
namespace MgaSystems.Ims.Fortegra.Overrides.Claims;

[Override(typeof (FormPaymentTransfer))]
public class Fortegra_FormPaymentTransfer : FormPaymentTransfer
{
  private IContainer components;
  private UltraDropDown comboPaymentMethodTypes;

  public Fortegra_FormPaymentTransfer() => this.InitializeComponent();

  protected override void LoadPayments()
  {
    DefaultDatabase.LoadDataTable((DataTable) this.dsPaymentTransfer.Payments, "Fortegra_spClaims_GetPaymentTransfer");
    this.FormatPaymentTransferGrid();
  }

  public override void Transfer(string paymentProcedureName, params object[] args)
  {
    this.Cursor = MgaCursors.WaitCursor;
    if (string.IsNullOrEmpty(paymentProcedureName))
      paymentProcedureName = "Fortegra_spClaims_TransferPayment";
    try
    {
      if (((UltraGridBase) this.gridPayments).Rows.GetFilteredInNonGroupByRows().Length == 0)
        return;
      this.TransferPayments(paymentProcedureName);
    }
    catch
    {
      throw;
    }
    finally
    {
      this.Cursor = MgaCursors.Default;
    }
  }

  private void TransferPayments(string paymentProcedureName)
  {
    DefaultDatabase.ExecuteTransaction((EventHandler<ExecuteTransactionEventArgs>) ((_, e) =>
    {
      UltraGridRow[] inNonGroupByRows = ((UltraGridBase) this.gridPayments).Rows.GetFilteredInNonGroupByRows();
      List<UltraGridRow> paymentsToTransfer = new List<UltraGridRow>();
      if (inNonGroupByRows != null)
        paymentsToTransfer = ((IEnumerable<UltraGridRow>) inNonGroupByRows).Where<UltraGridRow>((System.Func<UltraGridRow, bool>) (x => (bool) x.Cells["SELECT"].Value)).ToList<UltraGridRow>();
      this.ExecutePaymentTransfers(paymentsToTransfer, paymentProcedureName);
      e.Transaction.Commit();
    }));
  }

  protected override void ultraToolbarsManager1_ToolClick(object sender, ToolClickEventArgs e)
  {
    switch (((KeyedSubObjectBase) ((ToolEventArgs) e).Tool).Key)
    {
      case "CREATECHECKALL":
        this.SetAllDropdownsToCheckOrOffset(true);
        break;
      case "NOCREATECHECK":
        this.SetAllDropdownsToCheckOrOffset(false);
        break;
      default:
        base.ultraToolbarsManager1_ToolClick(sender, e);
        break;
    }
  }

  private void ExecutePaymentTransfers(
    List<UltraGridRow> paymentsToTransfer,
    string paymentProcedureName)
  {
    if (paymentsToTransfer.Count == 0)
      return;
    foreach (UltraGridRow ultraGridRow in paymentsToTransfer)
    {
      ultraGridRow.Update();
      List<object> objectList = new List<object>()
      {
        (object) "@ResPayId",
        ultraGridRow.Cells["ResPayId"].Value,
        (object) "@UserGuid",
        (object) CurrentUser.Instance.UserGUID
      };
      if ((Decimal) ultraGridRow.Cells["ResPayAmount"].Value > 0M)
      {
        string str = Utility.IsNull<string>(ultraGridRow.Cells["PaymentMethod"].Value, string.Empty);
        objectList.Add((object) "@CreateCheck");
        objectList.Add((object) (bool) ultraGridRow.Cells["CREATECHECK"].Value);
        objectList.Add((object) "@PaymentMethod");
        objectList.Add((object) str);
        DefaultDatabase.ExecuteNonQuery(paymentProcedureName, objectList.ToArray());
      }
      else
        DefaultDatabase.ExecuteNonQuery("Fortegra_spClaims_TransferRecoveryPayment", objectList.ToArray());
    }
  }

  private void FormatPaymentTransferGrid()
  {
    UltraGridBand band = ((UltraGridBase) this.gridPayments).DisplayLayout.Bands[0];
    this.FormatPaymentMethodColumn(band);
    this.FormatPolicyLineColumn(band);
    this.FormatCreateCheckColumn(band);
    band.Columns["Child Line"].CellActivation = (Activation) 3;
    band.Columns["Created By User"].CellActivation = (Activation) 3;
    this.gridPayments.UpdateMode = (UpdateMode) 3;
    ((ToolsCollectionBase) ((UltraToolbarBase) this.ultraToolbarsManager1.Toolbars[0]).Tools)["BANKACCOUNTS"].SharedProps.Visible = false;
    band.Columns["ResPayTypeDescription"].Width = 100;
    band.Columns["ResPayAmount"].Width = 75;
    band.Columns["Child Line"].Width = 75;
    this.gridPayments.CellChange += new CellEventHandler(this.gridPayments_CellChange);
  }

  private void FormatPaymentMethodColumn(UltraGridBand transferPaymentsGrid)
  {
    UltraGridColumn column = transferPaymentsGrid.Columns["PaymentMethod"];
    ((HeaderBase) transferPaymentsGrid.Columns["PaymentMethod"].Header).Caption = "Payment Methods";
    ((HeaderBase) transferPaymentsGrid.Columns["PaymentMethod"].Header).VisiblePosition = 15;
    transferPaymentsGrid.Columns["PaymentMethod"].Width = 105;
    column.Style = (ColumnStyle) 6;
    column.ValueList = (IValueList) this.comboPaymentMethodTypes;
    ((UltraGridBase) this.comboPaymentMethodTypes).DataSource = (object) DefaultDatabase.ExecuteDataSet("Fortegra_GetAllPaymentTransferPaymentMethods");
    ((UltraDropDownBase) this.comboPaymentMethodTypes).DisplayMember = "MethodName";
    ((UltraDropDownBase) this.comboPaymentMethodTypes).ValueMember = "PayMethodID";
    UltraGridBand band = ((UltraGridBase) this.comboPaymentMethodTypes).DisplayLayout.Bands[0];
    band.ColHeadersVisible = false;
    band.Columns["PayMethodID"].Hidden = true;
    band.Columns["MethodName"].Width = 300;
    if (!((IEnumerable<UltraGridRow>) ((UltraGridBase) this.comboPaymentMethodTypes).Rows).Any<UltraGridRow>())
      return;
    ((UltraDropDownBase) this.comboPaymentMethodTypes).SelectedRow = ((UltraGridBase) this.comboPaymentMethodTypes).Rows[0];
  }

  private void FormatPolicyLineColumn(UltraGridBand transferPaymentsGrid)
  {
    transferPaymentsGrid.Columns["Policy Line"].Width = 105;
    ((HeaderBase) transferPaymentsGrid.Columns["Policy Line"].Header).VisiblePosition = 11;
    transferPaymentsGrid.Columns["CoverageType"].Hidden = true;
  }

  private void FormatCreateCheckColumn(UltraGridBand transferPaymentsGrid)
  {
    this.ToggleCreateCheckAll(true);
    ((HeaderBase) transferPaymentsGrid.Columns["CREATECHECK"].Header).VisiblePosition = 16 /*0x10*/;
  }

  private void SetAllDropdownsToCheckOrOffset(bool isCreateCheckAll)
  {
    this.ToggleCreateCheckAll(isCreateCheckAll);
    if (isCreateCheckAll)
    {
      foreach (UltraGridRow row in ((UltraGridBase) this.gridPayments).Rows)
        row.Cells["PaymentMethod"].Value = (object) "C";
    }
    else
    {
      foreach (UltraGridRow row in ((UltraGridBase) this.gridPayments).Rows)
        row.Cells["PaymentMethod"].Value = (object) "O";
    }
  }

  private void comboPaymentMethodTypes_RowSelected(object sender, RowSelectedEventArgs e)
  {
    if (((UltraGridBase) this.gridPayments).ActiveRow == null || ((UltraGridBase) this.comboPaymentMethodTypes).ActiveRow == null)
      return;
    CellsCollection cells1 = ((UltraGridBase) this.comboPaymentMethodTypes).ActiveRow.Cells;
    CellsCollection cells2 = ((UltraGridBase) this.gridPayments).ActiveRow.Cells;
    if ((string) cells1["PayMethodId"].Value == "C")
      cells2["CREATECHECK"].Value = (object) true;
    else
      cells2["CREATECHECK"].Value = (object) false;
  }

  private void gridPayments_CellChange(object sender, CellEventArgs e)
  {
    if (!(((KeyedSubObjectBase) e.Cell.Column).Key == "CREATECHECK"))
      return;
    if ((bool) e.Cell.Row.Cells["CREATECHECK"].Value)
      e.Cell.Row.Cells["PaymentMethod"].Value = (object) "C";
    else
      e.Cell.Row.Cells["PaymentMethod"].Value = (object) "O";
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    Appearance appearance1 = new Appearance();
    UltraGridBand ultraGridBand = new UltraGridBand("Payments", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("ResPayId");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("DateCreated");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("Payee Name");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("CompanyName");
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("ClaimNumber");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("PolicyNumber");
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("ResPayTypeDescription");
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("CoverageType");
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("ResPayAmount");
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("ClaimantGuid");
    UltraGridColumn ultraGridColumn11 = new UltraGridColumn("SELECT", 0);
    UltraGridColumn ultraGridColumn12 = new UltraGridColumn("CREATECHECK", 1);
    UltraGridColumn ultraGridColumn13 = new UltraGridColumn("PaymentMethod", 2, (object) "comboPaymentMethodTypes");
    UltraGridColumn ultraGridColumn14 = new UltraGridColumn("PolicyLine", 3, (object) null, 0, (SortIndicator) 1, false);
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
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
    Appearance appearance20 = new Appearance();
    Appearance appearance21 = new Appearance();
    Appearance appearance22 = new Appearance();
    this.comboPaymentMethodTypes = new UltraDropDown();
    this.dsPaymentTransfer.BeginInit();
    ((ISupportInitialize) this.gridPayments).BeginInit();
    this.FormBackground_Fill_Panel.SuspendLayout();
    ((ISupportInitialize) this.ultraToolbarsManager1).BeginInit();
    ((ISupportInitialize) this.comboPaymentMethodTypes).BeginInit();
    this.SuspendLayout();
    ((AppearanceBase) appearance1).BackColor = Color.Transparent;
    ((AppearanceBase) appearance1).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.gridPayments).DisplayLayout.Appearance = (AppearanceBase) appearance1;
    ((UltraGridBase) this.gridPayments).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn1.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn1.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn1.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn1.Header).VisiblePosition = 1;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn1.Width = 47;
    ultraGridColumn2.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn2.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn2.Header).Caption = "Date";
    ((HeaderBase) ultraGridColumn2.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn2.Header).VisiblePosition = 2;
    ultraGridColumn2.Width = 59;
    ((HeaderBase) ultraGridColumn3.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn3.Header).VisiblePosition = 3;
    ultraGridColumn3.Width = 103;
    ultraGridColumn4.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn4.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn4.Header).Caption = "Company";
    ((HeaderBase) ultraGridColumn4.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn4.Header).VisiblePosition = 4;
    ultraGridColumn4.Width = 124;
    ultraGridColumn5.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn5.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn5.Header).Caption = "Claim #";
    ((HeaderBase) ultraGridColumn5.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn5.Header).VisiblePosition = 5;
    ultraGridColumn5.Style = (ColumnStyle) 2;
    ultraGridColumn5.Width = 116;
    ultraGridColumn6.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn6.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn6.Header).Caption = "Policy #";
    ((HeaderBase) ultraGridColumn6.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn6.Header).VisiblePosition = 6;
    ultraGridColumn6.Width = 118;
    ultraGridColumn7.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn7.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn7.Header).Caption = "Payment Type";
    ((HeaderBase) ultraGridColumn7.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn7.Header).VisiblePosition = 7;
    ultraGridColumn7.Width = 105;
    ultraGridColumn8.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn8.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn8.Header).Caption = "Coverage Type";
    ((HeaderBase) ultraGridColumn8.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn8.Header).VisiblePosition = 8;
    ultraGridColumn8.Width = 135;
    ultraGridColumn9.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn9.CellActivation = (Activation) 3;
    ultraGridColumn9.Format = "c";
    ((HeaderBase) ultraGridColumn9.Header).Caption = "Amount";
    ((HeaderBase) ultraGridColumn9.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn9.Header).VisiblePosition = 9;
    ultraGridColumn9.Width = 122;
    ultraGridColumn10.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn10.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn10.Header).VisiblePosition = 10;
    ultraGridColumn10.Hidden = true;
    ultraGridColumn10.Width = 199;
    ultraGridColumn11.AllowRowFiltering = (DefaultableBoolean) 2;
    ultraGridColumn11.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn11.DataType = typeof (bool);
    ultraGridColumn11.DefaultCellValue = (object) true;
    ((HeaderBase) ultraGridColumn11.Header).Caption = "";
    ((HeaderBase) ultraGridColumn11.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn11.Header).VisiblePosition = 0;
    ultraGridColumn11.Style = (ColumnStyle) 3;
    ultraGridColumn11.Width = 24;
    ultraGridColumn12.CellActivation = (Activation) 3;
    ultraGridColumn12.DataType = typeof (bool);
    ultraGridColumn12.DefaultCellValue = (object) true;
    ((HeaderBase) ultraGridColumn12.Header).Caption = "Create Check?";
    ((HeaderBase) ultraGridColumn12.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn12.Header).VisiblePosition = 12;
    ultraGridColumn12.Style = (ColumnStyle) 3;
    ultraGridColumn12.Width = 52;
    ultraGridColumn13.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn13.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn13.Header).Caption = "Payment Methods";
    ((HeaderBase) ultraGridColumn13.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn13.Header).VisiblePosition = 11;
    ultraGridColumn13.Width = 138;
    ultraGridColumn14.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn14.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn14.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn14.Header).VisiblePosition = 13;
    ultraGridColumn14.Width = 138;
    ultraGridBand.Columns.AddRange(new object[14]
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
      (object) ultraGridColumn14
    });
    ((UltraGridBase) this.gridPayments).DisplayLayout.BandsSerializer.Add((object) ultraGridBand);
    ((UltraGridBase) this.gridPayments).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((AppearanceBase) appearance2).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance2).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance2).ForeColor = Color.Black;
    ((UltraGridBase) this.gridPayments).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance2;
    ((UltraGridBase) this.gridPayments).DisplayLayout.Override.AllowAddNew = (AllowAddNew) 2;
    ((UltraGridBase) this.gridPayments).DisplayLayout.Override.AllowColMoving = (AllowColMoving) 1;
    ((UltraGridBase) this.gridPayments).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.gridPayments).DisplayLayout.Override.AllowColSwapping = (AllowColSwapping) 1;
    ((UltraGridBase) this.gridPayments).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 1;
    ((UltraGridBase) this.gridPayments).DisplayLayout.Override.AllowGroupBy = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridPayments).DisplayLayout.Override.AllowGroupMoving = (AllowGroupMoving) 1;
    ((UltraGridBase) this.gridPayments).DisplayLayout.Override.AllowGroupSwapping = (AllowGroupSwapping) 1;
    ((UltraGridBase) this.gridPayments).DisplayLayout.Override.AllowMultiCellOperations = (AllowMultiCellOperation) 0;
    ((UltraGridBase) this.gridPayments).DisplayLayout.Override.AllowRowFiltering = (DefaultableBoolean) 1;
    ((UltraGridBase) this.gridPayments).DisplayLayout.Override.AllowRowLayoutCellSizing = (RowLayoutSizing) 1;
    ((UltraGridBase) this.gridPayments).DisplayLayout.Override.AllowRowLayoutCellSpanSizing = (GridBagLayoutAllowSpanSizing) 1;
    ((UltraGridBase) this.gridPayments).DisplayLayout.Override.AllowRowLayoutColMoving = (GridBagLayoutAllowMoving) 1;
    ((UltraGridBase) this.gridPayments).DisplayLayout.Override.AllowRowLayoutLabelSizing = (RowLayoutSizing) 1;
    ((UltraGridBase) this.gridPayments).DisplayLayout.Override.AllowRowLayoutLabelSpanSizing = (GridBagLayoutAllowSpanSizing) 1;
    ((UltraGridBase) this.gridPayments).DisplayLayout.Override.AllowRowSummaries = (AllowRowSummaries) 2;
    ((UltraGridBase) this.gridPayments).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 1;
    ((AppearanceBase) appearance3).BorderColor = Color.LightGray;
    ((AppearanceBase) appearance3).TextHAlignAsString = "Left";
    ((UltraGridBase) this.gridPayments).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance3;
    ((UltraGridBase) this.gridPayments).DisplayLayout.Override.CellClickAction = (CellClickAction) 1;
    ((AppearanceBase) appearance4).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((AppearanceBase) appearance4).TextHAlignAsString = "Left";
    ((UltraGridBase) this.gridPayments).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance4;
    ((UltraGridBase) this.gridPayments).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 2;
    ((UltraGridBase) this.gridPayments).DisplayLayout.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance5).BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.gridPayments).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance5;
    ((AppearanceBase) appearance6).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridPayments).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance6;
    ((UltraGridBase) this.gridPayments).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridPayments).DisplayLayout.Override.RowSpacingAfter = 1;
    ((AppearanceBase) appearance7).BackColor = Color.Transparent;
    ((AppearanceBase) appearance7).ForeColor = Color.Black;
    ((UltraGridBase) this.gridPayments).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance7;
    ((AppearanceBase) appearance8).BackColor = Color.LightSteelBlue;
    ((UltraGridBase) this.gridPayments).DisplayLayout.Override.TemplateAddRowAppearance = (AppearanceBase) appearance8;
    ((AppearanceBase) appearance9).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance9).BorderColor = Color.Silver;
    scrollBarLook.ButtonAppearance = (AppearanceBase) appearance9;
    ((AppearanceBase) appearance10).BackColor = Color.White;
    scrollBarLook.TrackAppearance = (AppearanceBase) appearance10;
    ((UltraGridBase) this.gridPayments).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((Control) this.gridPayments).Size = new Size(1236, 540);
    this.FormBackground_Fill_Panel.Controls.Add((Control) this.comboPaymentMethodTypes);
    this.FormBackground_Fill_Panel.Location = new Point(0, 47);
    this.FormBackground_Fill_Panel.Size = new Size(1236, 540);
    this.FormBackground_Fill_Panel.Controls.SetChildIndex((Control) this.gridPayments, 0);
    this.FormBackground_Fill_Panel.Controls.SetChildIndex((Control) this.comboPaymentMethodTypes, 0);
    ((SettingsBase) this.ultraToolbarsManager1.MenuSettings).ForceSerialization = true;
    ((SettingsBase) this.ultraToolbarsManager1.ToolbarSettings).ForceSerialization = true;
    ((AppearanceBase) appearance11).BackColor = SystemColors.Window;
    ((AppearanceBase) appearance11).BorderColor = SystemColors.InactiveCaption;
    ((UltraGridBase) this.comboPaymentMethodTypes).DisplayLayout.Appearance = (AppearanceBase) appearance11;
    ((UltraGridBase) this.comboPaymentMethodTypes).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.comboPaymentMethodTypes).DisplayLayout.CaptionVisible = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance12).BackColor = SystemColors.ActiveBorder;
    ((AppearanceBase) appearance12).BackColor2 = SystemColors.ControlDark;
    ((AppearanceBase) appearance12).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance12).BorderColor = SystemColors.Window;
    ((SpecialBoxBase) ((UltraGridBase) this.comboPaymentMethodTypes).DisplayLayout.GroupByBox).Appearance = (AppearanceBase) appearance12;
    ((AppearanceBase) appearance13).ForeColor = SystemColors.GrayText;
    ((UltraGridBase) this.comboPaymentMethodTypes).DisplayLayout.GroupByBox.BandLabelAppearance = (AppearanceBase) appearance13;
    ((SpecialBoxBase) ((UltraGridBase) this.comboPaymentMethodTypes).DisplayLayout.GroupByBox).BorderStyle = (UIElementBorderStyle) 4;
    ((AppearanceBase) appearance14).BackColor = SystemColors.ControlLightLight;
    ((AppearanceBase) appearance14).BackColor2 = SystemColors.Control;
    ((AppearanceBase) appearance14).BackGradientStyle = (GradientStyle) 3;
    ((AppearanceBase) appearance14).ForeColor = SystemColors.GrayText;
    ((UltraGridBase) this.comboPaymentMethodTypes).DisplayLayout.GroupByBox.PromptAppearance = (AppearanceBase) appearance14;
    ((UltraGridBase) this.comboPaymentMethodTypes).DisplayLayout.MaxColScrollRegions = 1;
    ((UltraGridBase) this.comboPaymentMethodTypes).DisplayLayout.MaxRowScrollRegions = 1;
    ((AppearanceBase) appearance15).BackColor = SystemColors.Window;
    ((AppearanceBase) appearance15).ForeColor = SystemColors.ControlText;
    ((UltraGridBase) this.comboPaymentMethodTypes).DisplayLayout.Override.ActiveCellAppearance = (AppearanceBase) appearance15;
    ((AppearanceBase) appearance16).BackColor = SystemColors.Highlight;
    ((AppearanceBase) appearance16).ForeColor = SystemColors.HighlightText;
    ((UltraGridBase) this.comboPaymentMethodTypes).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance16;
    ((UltraGridBase) this.comboPaymentMethodTypes).DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 2;
    ((UltraGridBase) this.comboPaymentMethodTypes).DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 2;
    ((AppearanceBase) appearance17).BackColor = SystemColors.Window;
    ((UltraGridBase) this.comboPaymentMethodTypes).DisplayLayout.Override.CardAreaAppearance = (AppearanceBase) appearance17;
    ((AppearanceBase) appearance18).BorderColor = Color.Silver;
    ((AppearanceBase) appearance18).TextTrimming = (TextTrimming) 3;
    ((UltraGridBase) this.comboPaymentMethodTypes).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance18;
    ((UltraGridBase) this.comboPaymentMethodTypes).DisplayLayout.Override.CellClickAction = (CellClickAction) 4;
    ((UltraGridBase) this.comboPaymentMethodTypes).DisplayLayout.Override.CellPadding = 0;
    ((AppearanceBase) appearance19).BackColor = SystemColors.Control;
    ((AppearanceBase) appearance19).BackColor2 = SystemColors.ControlDark;
    ((AppearanceBase) appearance19).BackGradientAlignment = (GradientAlignment) 1;
    ((AppearanceBase) appearance19).BackGradientStyle = (GradientStyle) 3;
    ((AppearanceBase) appearance19).BorderColor = SystemColors.Window;
    ((UltraGridBase) this.comboPaymentMethodTypes).DisplayLayout.Override.GroupByRowAppearance = (AppearanceBase) appearance19;
    ((AppearanceBase) appearance20).TextHAlignAsString = "Left";
    ((UltraGridBase) this.comboPaymentMethodTypes).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance20;
    ((UltraGridBase) this.comboPaymentMethodTypes).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 3;
    ((UltraGridBase) this.comboPaymentMethodTypes).DisplayLayout.Override.HeaderStyle = (HeaderStyle) 2;
    ((AppearanceBase) appearance21).BackColor = SystemColors.Window;
    ((AppearanceBase) appearance21).BorderColor = Color.Silver;
    ((UltraGridBase) this.comboPaymentMethodTypes).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance21;
    ((UltraGridBase) this.comboPaymentMethodTypes).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance22).BackColor = SystemColors.ControlLight;
    ((UltraGridBase) this.comboPaymentMethodTypes).DisplayLayout.Override.TemplateAddRowAppearance = (AppearanceBase) appearance22;
    ((UltraGridBase) this.comboPaymentMethodTypes).DisplayLayout.ScrollBounds = (ScrollBounds) 0;
    ((UltraGridBase) this.comboPaymentMethodTypes).DisplayLayout.ScrollStyle = (ScrollStyle) 1;
    ((UltraGridBase) this.comboPaymentMethodTypes).DisplayLayout.ViewStyleBand = (ViewStyleBand) 2;
    ((Control) this.comboPaymentMethodTypes).Location = new Point(600, 412);
    ((Control) this.comboPaymentMethodTypes).Name = "comboPaymentMethodTypes";
    ((Control) this.comboPaymentMethodTypes).Size = new Size(424, 80 /*0x50*/);
    ((Control) this.comboPaymentMethodTypes).TabIndex = 2;
    ((Control) this.comboPaymentMethodTypes).Text = "ultraDropDown1";
    ((Control) this.comboPaymentMethodTypes).Visible = false;
    this.comboPaymentMethodTypes.RowSelected += new RowSelectedEventHandler(this.comboPaymentMethodTypes_RowSelected);
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(1236, 587);
    this.Name = nameof (Fortegra_FormPaymentTransfer);
    this.ShowIcon = false;
    this.Text = "Claims Payment Transfer (Fortegra)";
    this.dsPaymentTransfer.EndInit();
    ((ISupportInitialize) this.gridPayments).EndInit();
    this.FormBackground_Fill_Panel.ResumeLayout(false);
    ((ISupportInitialize) this.ultraToolbarsManager1).EndInit();
    ((ISupportInitialize) this.comboPaymentMethodTypes).EndInit();
    this.ResumeLayout(false);
  }
}
