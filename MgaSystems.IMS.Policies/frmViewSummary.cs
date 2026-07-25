// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.frmViewSummary
// Assembly: MgaSystems.IMS.Policies, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 2FF2C709-F7BF-41DA-82BD-FF6319CA235D
// Assembly location: C:\Users\muthu\Downloads\MgaSystems.IMS.Policies.dll

using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.Export.Pdf.Section;
using Infragistics.Shared;
using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using MGASystems.BusinessObjects;
using MGASystems.Common;
using MGASystems.Common.ErrorHandling;
using MGASystems.Data;
using MGASystems.IMS.NoteDocuments;
using MGASystems.IMS.NoteDocuments.DocumentSystem;
using MGASystems.IMS.Policies.PolicyDetail;
using MGASystems.IMS.Reporting;
using MGASystems.Tools;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Policies;

public class frmViewSummary : Form
{
  private dsPolicyDetail_Premiums _dsPremiums;
  private int _isThisTransaction;
  private int _controlno;
  private IContainer components;
  private UltraGrid dgOptions;
  private UltraGrid dgTotalPolicy;
  private Label Label1;
  private Label lblTotalFees;
  private Label lblQuotedPremium;

  [field: AccessedThroughProperty("Label6")]
  internal virtual Label Label6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("LblTotalPremiumandFees")]
  private virtual Label LblTotalPremiumandFees { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  public frmViewSummary(
    int isThisTransaction,
    dsPolicyDetail_Premiums dsPremiums,
    object optionsDatasource,
    object dgDatasource,
    int controlNo,
    Decimal totalPremium,
    Decimal totalFees,
    Decimal boundPremium,
    Decimal grandTotalFees)
  {
    this.Load += new EventHandler(this.frmViewSummary_Load);
    this.InitializeComponent();
    this.Text = $"{this.Text} For Control No:{Conversions.ToString(controlNo)}";
    ((UltraGridBase) this.dgOptions).DataSource = RuntimeHelpers.GetObjectValue(optionsDatasource);
    ((UltraGridBase) this.dgTotalPolicy).DataSource = RuntimeHelpers.GetObjectValue(dgDatasource);
    this._isThisTransaction = isThisTransaction;
    this._controlno = controlNo;
    CultureInfo currentCultureInfo = frmPolicyDetail.CurrentCultureInfo;
    this.lblQuotedPremium.Text = totalPremium.ToString("c", (IFormatProvider) currentCultureInfo);
    if (this._isThisTransaction == 0)
    {
      this.lblTotalFees.Text = grandTotalFees.ToString("c", (IFormatProvider) currentCultureInfo);
      this.lblBoundPremium.Text = boundPremium.ToString("c", (IFormatProvider) currentCultureInfo);
      this.lblBoundFees.Text = totalFees.ToString("c", (IFormatProvider) currentCultureInfo);
      this.LblTotalPremiumandFees.Text = Decimal.Add(totalPremium, grandTotalFees).ToString("c", (IFormatProvider) currentCultureInfo);
    }
    if (Decimal.Compare(totalPremium, 0M) > 0)
      this.lblQuotedPremium.ForeColor = Color.DarkGreen;
    else if (Decimal.Compare(totalPremium, 0M) == 0)
      this.lblQuotedPremium.ForeColor = Color.Black;
    else if (Decimal.Compare(totalPremium, 0M) == 0)
      this.lblQuotedPremium.ForeColor = Color.Red;
    if (Decimal.Compare(Decimal.Add(totalPremium, totalFees), 0M) > 0)
      this.LblTotalPremiumandFees.ForeColor = Color.DarkGreen;
    else if (Decimal.Compare(Decimal.Add(totalPremium, totalFees), 0M) == 0)
      this.LblTotalPremiumandFees.ForeColor = Color.Black;
    else if (Decimal.Compare(Decimal.Add(totalPremium, totalFees), 0M) == 0)
      this.LblTotalPremiumandFees.ForeColor = Color.Red;
    if (this._isThisTransaction == 0)
    {
      if (Decimal.Compare(boundPremium, 0M) > 0)
        this.lblBoundPremium.ForeColor = Color.DarkGreen;
      else if (Decimal.Compare(boundPremium, 0M) == 0)
        this.lblBoundPremium.ForeColor = Color.Black;
      else if (Decimal.Compare(boundPremium, 0M) == 0)
        this.lblBoundPremium.ForeColor = Color.Red;
      if (Decimal.Compare(totalFees, 0M) > 0)
        this.lblBoundFees.ForeColor = Color.DarkGreen;
      else if (Decimal.Compare(totalFees, 0M) == 0)
        this.lblBoundFees.ForeColor = Color.Black;
      else if (Decimal.Compare(totalFees, 0M) == 0)
        this.lblBoundFees.ForeColor = Color.Red;
      if (Decimal.Compare(grandTotalFees, 0M) > 0)
        this.lblTotalFees.ForeColor = Color.DarkGreen;
      else if (Decimal.Compare(grandTotalFees, 0M) == 0)
        this.lblTotalFees.ForeColor = Color.Black;
      else if (Decimal.Compare(grandTotalFees, 0M) == 0)
        this.lblTotalFees.ForeColor = Color.Red;
    }
    this._dsPremiums = dsPremiums;
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private virtual MGAButton btnOK
  {
    get => this._btnOK;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnOK_Click);
      MGAButton btnOk1 = this._btnOK;
      if (btnOk1 != null)
        ((Control) btnOk1).Click -= eventHandler;
      this._btnOK = value;
      MGAButton btnOk2 = this._btnOK;
      if (btnOk2 == null)
        return;
      ((Control) btnOk2).Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("Label4")]
  internal virtual Label Label4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label2")]
  internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label3")]
  internal virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblBoundPremium")]
  private virtual Label lblBoundPremium { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label5")]
  internal virtual Label Label5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblBoundFees")]
  private virtual Label lblBoundFees { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual LinkLabel lnkViewReport
  {
    get => this._lnkViewReport;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkViewReport_LinkClicked);
      LinkLabel lnkViewReport1 = this._lnkViewReport;
      if (lnkViewReport1 != null)
        lnkViewReport1.LinkClicked -= clickedEventHandler;
      this._lnkViewReport = value;
      LinkLabel lnkViewReport2 = this._lnkViewReport;
      if (lnkViewReport2 == null)
        return;
      lnkViewReport2.LinkClicked += clickedEventHandler;
    }
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    Appearance appearance1 = new Appearance();
    UltraGridBand ultraGridBand1 = new UltraGridBand("LinesOptions", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("LineGuid");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("CompanyLocationID");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("LineName");
    Appearance appearance2 = new Appearance();
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("LinesOptionstblQuoteOptions");
    UltraGridBand ultraGridBand2 = new UltraGridBand("LinesOptionstblQuoteOptions", 0);
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("QuoteOptionGuid");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("LineGuid");
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("CompanyLocationID");
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("Premium");
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("DateCreated");
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("Bound");
    UltraGridColumn ultraGridColumn11 = new UltraGridColumn("Quote");
    UltraGridColumn ultraGridColumn12 = new UltraGridColumn("Fees");
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    UltraGridColumn ultraGridColumn13 = new UltraGridColumn("btnOptionDetail");
    Appearance appearance7 = new Appearance();
    UltraGridColumn ultraGridColumn14 = new UltraGridColumn("InstallmentSetup");
    Appearance appearance8 = new Appearance();
    UltraGridColumn ultraGridColumn15 = new UltraGridColumn("tblQuoteOptionsviewOptionPremiums1");
    UltraGridBand ultraGridBand3 = new UltraGridBand("tblQuoteOptionsviewOptionPremiums1", 1);
    UltraGridColumn ultraGridColumn16 = new UltraGridColumn("QuoteOptionGuid");
    UltraGridColumn ultraGridColumn17 = new UltraGridColumn("StateID");
    UltraGridColumn ultraGridColumn18 = new UltraGridColumn("ChargeName");
    UltraGridColumn ultraGridColumn19 = new UltraGridColumn("Premium");
    UltraGridColumn ultraGridColumn20 = new UltraGridColumn("Location");
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    ScrollBarLook scrollBarLook1 = new ScrollBarLook();
    Appearance appearance11 = new Appearance();
    Appearance appearance12 = new Appearance();
    UltraGridBand ultraGridBand4 = new UltraGridBand("AllLinesOptions", -1);
    UltraGridColumn ultraGridColumn21 = new UltraGridColumn("LineGuid");
    UltraGridColumn ultraGridColumn22 = new UltraGridColumn("LineName");
    Appearance appearance13 = new Appearance();
    UltraGridColumn ultraGridColumn23 = new UltraGridColumn("AllLinesOptionsBoundOptions");
    UltraGridBand ultraGridBand5 = new UltraGridBand("AllLinesOptionsBoundOptions", 0);
    UltraGridColumn ultraGridColumn24 = new UltraGridColumn("StateID");
    UltraGridColumn ultraGridColumn25 = new UltraGridColumn("ChargeName");
    UltraGridColumn ultraGridColumn26 = new UltraGridColumn("Premium");
    UltraGridColumn ultraGridColumn27 = new UltraGridColumn("Location");
    UltraGridColumn ultraGridColumn28 = new UltraGridColumn("LineGuid");
    Appearance appearance14 = new Appearance();
    Appearance appearance15 = new Appearance();
    ScrollBarLook scrollBarLook2 = new ScrollBarLook();
    this.dgOptions = new UltraGrid();
    this.btnOK = new MGAButton();
    this.dgTotalPolicy = new UltraGrid();
    this.Label1 = new Label();
    this.lblTotalFees = new Label();
    this.lblQuotedPremium = new Label();
    this.lnkViewReport = new LinkLabel();
    this.Label4 = new Label();
    this.Label2 = new Label();
    this.Label3 = new Label();
    this.lblBoundPremium = new Label();
    this.Label5 = new Label();
    this.lblBoundFees = new Label();
    this.Label6 = new Label();
    this.LblTotalPremiumandFees = new Label();
    ((ISupportInitialize) this.dgOptions).BeginInit();
    ((ISupportInitialize) this.btnOK).BeginInit();
    ((ISupportInitialize) this.dgTotalPolicy).BeginInit();
    this.SuspendLayout();
    ((Control) this.dgOptions).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    appearance1.BackColor = Color.White;
    appearance1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.dgOptions).DisplayLayout.Appearance = (AppearanceBase) appearance1;
    ((UltraGridBase) this.dgOptions).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ((HeaderBase) ultraGridColumn1.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ((HeaderBase) ultraGridColumn2.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn2.Header.VisiblePosition = 1;
    ultraGridColumn2.Hidden = true;
    ultraGridColumn2.Width = 102;
    ultraGridColumn3.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance2).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn3.Header).Appearance = (AppearanceBase) appearance2;
    ((HeaderBase) ultraGridColumn3.Header).Caption = "Line";
    ((HeaderBase) ultraGridColumn3.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn3.Header.VisiblePosition = 2;
    ultraGridColumn3.Width = 761;
    ((HeaderBase) ultraGridColumn4.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn4.Header.VisiblePosition = 3;
    ultraGridBand1.Columns.AddRange(new object[4]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3,
      (object) ultraGridColumn4
    });
    ultraGridBand1.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((HeaderBase) ultraGridColumn5.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn5.Header.VisiblePosition = 0;
    ultraGridColumn5.Hidden = true;
    ultraGridColumn5.Width = 207;
    ((HeaderBase) ultraGridColumn6.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn6.Header.VisiblePosition = 1;
    ultraGridColumn6.Hidden = true;
    ultraGridColumn6.Width = 151;
    ((HeaderBase) ultraGridColumn7.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn7.Header.VisiblePosition = 2;
    ultraGridColumn7.Hidden = true;
    ultraGridColumn7.Width = 99;
    ultraGridColumn8.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance3).TextHAlignAsString = "Right";
    ultraGridColumn8.CellAppearance = (AppearanceBase) appearance3;
    ultraGridColumn8.Format = "c";
    ((AppearanceBase) appearance4).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn8.Header).Appearance = (AppearanceBase) appearance4;
    ((HeaderBase) ultraGridColumn8.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn8.Header.VisiblePosition = 3;
    ultraGridColumn8.Width = 178;
    ultraGridColumn9.CellActivation = (Activation) 3;
    ultraGridColumn9.Format = "d";
    ((HeaderBase) ultraGridColumn9.Header).Caption = "Created";
    ((HeaderBase) ultraGridColumn9.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn9.Header.VisiblePosition = 5;
    ultraGridColumn9.Width = 110;
    ((HeaderBase) ultraGridColumn10.Header).Caption = "Bind";
    ((HeaderBase) ultraGridColumn10.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn10.Header.VisiblePosition = 6;
    ultraGridColumn10.Width = 53;
    ((HeaderBase) ultraGridColumn11.Header).Caption = "Quoted";
    ((HeaderBase) ultraGridColumn11.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn11.Header.VisiblePosition = 7;
    ultraGridColumn11.Width = 71;
    ultraGridColumn12.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance5).TextHAlignAsString = "Right";
    ultraGridColumn12.CellAppearance = (AppearanceBase) appearance5;
    ultraGridColumn12.Format = "c";
    ((AppearanceBase) appearance6).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn12.Header).Appearance = (AppearanceBase) appearance6;
    ((HeaderBase) ultraGridColumn12.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn12.Header.VisiblePosition = 4;
    ultraGridColumn12.Width = 155;
    appearance7.FontData.UnderlineAsString = "True";
    appearance7.ForeColor = Color.Blue;
    ((AppearanceBase) appearance7).TextHAlignAsString = "Center";
    ultraGridColumn13.CellAppearance = (AppearanceBase) appearance7;
    ((HeaderBase) ultraGridColumn13.Header).Caption = "Detail";
    ((HeaderBase) ultraGridColumn13.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn13.Header.VisiblePosition = 8;
    ultraGridColumn13.Width = 48 /*0x30*/;
    appearance8.FontData.UnderlineAsString = "True";
    appearance8.ForeColor = Color.Blue;
    ((AppearanceBase) appearance8).TextHAlignAsString = "Center";
    ultraGridColumn14.CellAppearance = (AppearanceBase) appearance8;
    ((HeaderBase) ultraGridColumn14.Header).Caption = "Installment Billing";
    ((HeaderBase) ultraGridColumn14.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn14.Header.VisiblePosition = 9;
    ultraGridColumn14.Width = (int) sbyte.MaxValue;
    ((HeaderBase) ultraGridColumn15.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn15.Header.VisiblePosition = 10;
    ultraGridBand2.Columns.AddRange(new object[11]
    {
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
      (object) ultraGridColumn15
    });
    ((HeaderBase) ultraGridColumn16.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn16.Header.VisiblePosition = 0;
    ultraGridColumn16.Hidden = true;
    ultraGridColumn16.Width = 239;
    ultraGridColumn17.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn17.Header).Caption = "State";
    ((HeaderBase) ultraGridColumn17.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn17.Header.VisiblePosition = 1;
    ultraGridColumn17.Width = 207;
    ultraGridColumn18.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn18.Header).Caption = "Item";
    ((HeaderBase) ultraGridColumn18.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn18.Header.VisiblePosition = 2;
    ultraGridColumn18.Width = 193;
    ultraGridColumn19.CellActivation = (Activation) 3;
    ultraGridColumn19.Format = "c";
    ((HeaderBase) ultraGridColumn19.Header).Caption = "Amount";
    ((HeaderBase) ultraGridColumn19.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn19.Header.VisiblePosition = 3;
    ultraGridColumn19.Width = 145;
    ultraGridColumn20.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn20.Header).Caption = "Office";
    ((HeaderBase) ultraGridColumn20.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn20.Header.VisiblePosition = 4;
    ultraGridColumn20.Width = 178;
    ultraGridBand3.Columns.AddRange(new object[5]
    {
      (object) ultraGridColumn16,
      (object) ultraGridColumn17,
      (object) ultraGridColumn18,
      (object) ultraGridColumn19,
      (object) ultraGridColumn20
    });
    ultraGridBand3.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((UltraGridBase) this.dgOptions).DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    ((UltraGridBase) this.dgOptions).DisplayLayout.BandsSerializer.Add((object) ultraGridBand2);
    ((UltraGridBase) this.dgOptions).DisplayLayout.BandsSerializer.Add((object) ultraGridBand3);
    ((UltraGridBase) this.dgOptions).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.dgOptions).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.dgOptions).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((UltraGridBase) this.dgOptions).DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.dgOptions).DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 1;
    appearance9.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.dgOptions).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance9;
    appearance10.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.dgOptions).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance10;
    ((UltraGridBase) this.dgOptions).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    scrollBarLook1.ViewStyle = (ScrollBarViewStyle) 3;
    ((UltraGridBase) this.dgOptions).DisplayLayout.ScrollBarLook = scrollBarLook1;
    ((Control) this.dgOptions).Location = new Point(15, 44);
    ((Control) this.dgOptions).Name = "dgOptions";
    ((Control) this.dgOptions).Size = new Size(799, 372);
    ((Control) this.dgOptions).TabIndex = 10;
    ((UltraControlBase) this.dgOptions).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dgOptions).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.btnOK).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance11.BackColor = Color.FromArgb(248, 248, 248);
    appearance11.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance11.BackGradientStyle = (GradientStyle) 2;
    appearance11.BorderColor = Color.DarkGray;
    appearance11.ImageHAlign = (HAlign) 2;
    appearance11.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnOK).Appearance = (AppearanceBase) appearance11;
    ((Control) this.btnOK).Font = new Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.btnOK).Location = new Point(744, 518);
    ((Control) this.btnOK).Name = "btnOK";
    ((Control) this.btnOK).Size = new Size(74, 24);
    ((Control) this.btnOK).TabIndex = 11;
    ((ControlBase) this.btnOK).Text = "OK";
    this.btnOK.UseOSThemes = (DefaultableBoolean) 2;
    appearance12.BackColor = Color.White;
    appearance12.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.dgTotalPolicy).DisplayLayout.Appearance = (AppearanceBase) appearance12;
    ((UltraGridBase) this.dgTotalPolicy).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ((HeaderBase) ultraGridColumn21.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn21.Header.VisiblePosition = 0;
    ultraGridColumn21.Hidden = true;
    ultraGridColumn22.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance13).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn22.Header).Appearance = (AppearanceBase) appearance13;
    ((HeaderBase) ultraGridColumn22.Header).Caption = "Line";
    ((HeaderBase) ultraGridColumn22.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn22.Header.VisiblePosition = 1;
    ultraGridColumn22.Width = 727;
    ((HeaderBase) ultraGridColumn23.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn23.Header.VisiblePosition = 2;
    ultraGridBand4.Columns.AddRange(new object[3]
    {
      (object) ultraGridColumn21,
      (object) ultraGridColumn22,
      (object) ultraGridColumn23
    });
    ((HeaderBase) ultraGridColumn24.Header).Caption = "State";
    ((HeaderBase) ultraGridColumn24.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn24.Header.VisiblePosition = 0;
    ultraGridColumn24.Width = 79;
    ((HeaderBase) ultraGridColumn25.Header).Caption = "Item";
    ((HeaderBase) ultraGridColumn25.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn25.Header.VisiblePosition = 1;
    ultraGridColumn25.Width = 254;
    ultraGridColumn26.Format = "c";
    ((HeaderBase) ultraGridColumn26.Header).Caption = "Amount";
    ((HeaderBase) ultraGridColumn26.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn26.Header.VisiblePosition = 2;
    ultraGridColumn26.Width = 125;
    ((HeaderBase) ultraGridColumn27.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn27.Header.VisiblePosition = 3;
    ultraGridColumn27.Width = 250;
    ((HeaderBase) ultraGridColumn28.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn28.Header.VisiblePosition = 4;
    ultraGridColumn28.Hidden = true;
    ultraGridBand5.Columns.AddRange(new object[5]
    {
      (object) ultraGridColumn24,
      (object) ultraGridColumn25,
      (object) ultraGridColumn26,
      (object) ultraGridColumn27,
      (object) ultraGridColumn28
    });
    ((UltraGridBase) this.dgTotalPolicy).DisplayLayout.BandsSerializer.Add((object) ultraGridBand4);
    ((UltraGridBase) this.dgTotalPolicy).DisplayLayout.BandsSerializer.Add((object) ultraGridBand5);
    ((UltraGridBase) this.dgTotalPolicy).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.dgTotalPolicy).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.dgTotalPolicy).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.dgTotalPolicy).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((UltraGridBase) this.dgTotalPolicy).DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.dgTotalPolicy).DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 1;
    appearance14.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.dgTotalPolicy).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance14;
    appearance15.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.dgTotalPolicy).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance15;
    ((UltraGridBase) this.dgTotalPolicy).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    scrollBarLook2.ViewStyle = (ScrollBarViewStyle) 3;
    ((UltraGridBase) this.dgTotalPolicy).DisplayLayout.ScrollBarLook = scrollBarLook2;
    ((Control) this.dgTotalPolicy).Location = new Point(31 /*0x1F*/, 104);
    ((Control) this.dgTotalPolicy).Name = "dgTotalPolicy";
    ((Control) this.dgTotalPolicy).Size = new Size(765, 269);
    ((Control) this.dgTotalPolicy).TabIndex = 14;
    ((UltraControlBase) this.dgTotalPolicy).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dgTotalPolicy).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.dgTotalPolicy).Visible = false;
    this.Label1.Location = new Point(12, 9);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(600, 16 /*0x10*/);
    this.Label1.TabIndex = 15;
    this.Label1.Text = "This screen only allows for the viewing of premiums and fees.  No modification of the data is possible from this screen.";
    this.lblTotalFees.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lblTotalFees.Location = new Point(143, 486);
    this.lblTotalFees.Name = "lblTotalFees";
    this.lblTotalFees.Size = new Size(72, 16 /*0x10*/);
    this.lblTotalFees.TabIndex = 16 /*0x10*/;
    this.lblTotalFees.Text = "TotalFees";
    this.lblTotalFees.TextAlign = ContentAlignment.MiddleLeft;
    this.lblQuotedPremium.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lblQuotedPremium.Location = new Point(143, 440);
    this.lblQuotedPremium.Name = "lblQuotedPremium";
    this.lblQuotedPremium.Size = new Size(88, 16 /*0x10*/);
    this.lblQuotedPremium.TabIndex = 17;
    this.lblQuotedPremium.Text = "Total Premium";
    this.lblQuotedPremium.TextAlign = ContentAlignment.MiddleLeft;
    this.lnkViewReport.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkViewReport.AutoSize = true;
    this.lnkViewReport.Location = new Point(456, 529);
    this.lnkViewReport.Name = "lnkViewReport";
    this.lnkViewReport.Size = new Size(89, 13);
    this.lnkViewReport.TabIndex = 20;
    this.lnkViewReport.TabStop = true;
    this.lnkViewReport.Text = "View As a Report";
    this.Label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.Label4.AutoSize = true;
    this.Label4.Location = new Point(12, 488);
    this.Label4.Name = "Label4";
    this.Label4.Size = new Size(61, 13);
    this.Label4.TabIndex = 21;
    this.Label4.Text = "Total Fees:";
    this.Label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.Label2.AutoSize = true;
    this.Label2.Location = new Point(13, 442);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(117, 13);
    this.Label2.TabIndex = 22;
    this.Label2.Text = "Total Quoted Premium:";
    this.Label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.Label3.AutoSize = true;
    this.Label3.Location = new Point(13, 465);
    this.Label3.Name = "Label3";
    this.Label3.Size = new Size(84, 13);
    this.Label3.TabIndex = 24;
    this.Label3.Text = "Bound Premium:";
    this.lblBoundPremium.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lblBoundPremium.Location = new Point(143, 463);
    this.lblBoundPremium.Name = "lblBoundPremium";
    this.lblBoundPremium.Size = new Size(88, 16 /*0x10*/);
    this.lblBoundPremium.TabIndex = 23;
    this.lblBoundPremium.Text = "Bound Premium";
    this.lblBoundPremium.TextAlign = ContentAlignment.MiddleLeft;
    this.Label5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.Label5.AutoSize = true;
    this.Label5.Location = new Point(12, 511 /*0x01FF*/);
    this.Label5.Name = "Label5";
    this.Label5.Size = new Size(67, 13);
    this.Label5.TabIndex = 26;
    this.Label5.Text = "Bound Fees:";
    this.lblBoundFees.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lblBoundFees.Location = new Point(143, 509);
    this.lblBoundFees.Name = "lblBoundFees";
    this.lblBoundFees.Size = new Size(72, 16 /*0x10*/);
    this.lblBoundFees.TabIndex = 25;
    this.lblBoundFees.Text = "Bound Fees";
    this.lblBoundFees.TextAlign = ContentAlignment.MiddleLeft;
    this.Label6.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.Label6.AutoSize = true;
    this.Label6.Location = new Point(12, 535);
    this.Label6.Name = "Label6";
    this.Label6.Size = new Size(125, 13);
    this.Label6.TabIndex = 28;
    this.Label6.Text = "Total Premium and Fees:";
    this.LblTotalPremiumandFees.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.LblTotalPremiumandFees.Location = new Point(143, 533);
    this.LblTotalPremiumandFees.Name = "LblTotalPremiumandFees";
    this.LblTotalPremiumandFees.Size = new Size(161, 16 /*0x10*/);
    this.LblTotalPremiumandFees.TabIndex = 27;
    this.LblTotalPremiumandFees.Text = "Total Premium and Fees";
    this.LblTotalPremiumandFees.TextAlign = ContentAlignment.MiddleLeft;
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.White;
    this.ClientSize = new Size(826, 556);
    this.Controls.Add((Control) this.Label6);
    this.Controls.Add((Control) this.LblTotalPremiumandFees);
    this.Controls.Add((Control) this.Label5);
    this.Controls.Add((Control) this.lblBoundFees);
    this.Controls.Add((Control) this.Label3);
    this.Controls.Add((Control) this.lblBoundPremium);
    this.Controls.Add((Control) this.Label2);
    this.Controls.Add((Control) this.Label4);
    this.Controls.Add((Control) this.lnkViewReport);
    this.Controls.Add((Control) this.lblQuotedPremium);
    this.Controls.Add((Control) this.lblTotalFees);
    this.Controls.Add((Control) this.Label1);
    this.Controls.Add((Control) this.dgTotalPolicy);
    this.Controls.Add((Control) this.btnOK);
    this.Controls.Add((Control) this.dgOptions);
    this.Font = new Font("Tahoma", 8.25f);
    this.ForeColor = Color.Black;
    this.Name = nameof (frmViewSummary);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "View Quote Summary";
    ((ISupportInitialize) this.dgOptions).EndInit();
    ((ISupportInitialize) this.btnOK).EndInit();
    ((ISupportInitialize) this.dgTotalPolicy).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  private void frmViewSummary_Load(object sender, EventArgs e)
  {
    if (this._isThisTransaction == 1)
    {
      ((Control) this.dgOptions).Visible = false;
      ((Control) this.dgTotalPolicy).Visible = true;
      this.lnkViewReport.Visible = false;
      this.Label3.Visible = false;
      this.Label4.Visible = false;
      this.Label5.Visible = false;
      this.lblBoundPremium.Visible = false;
      this.lblTotalFees.Visible = false;
      this.lblBoundFees.Visible = false;
      this.LblTotalPremiumandFees.Visible = false;
      foreach (UltraGridRow row in ((UltraGridBase) this.dgTotalPolicy).Rows)
        row.ExpandAll();
    }
    else
    {
      ((UltraGridBase) this.dgOptions).DisplayLayout.Bands[1].Columns["btnOptionDetail"].Hidden = true;
      ((UltraGridBase) this.dgOptions).DisplayLayout.Bands[1].Columns["InstallmentSetup"].Hidden = true;
      foreach (UltraGridRow row in ((UltraGridBase) this.dgOptions).Rows)
        row.ExpandAll();
      this.lnkViewReport.Visible = true;
    }
    if (!frmPolicyDetail.CurrentMultiCurrency || !frmPolicyDetail.ImplementCurrencyDisplay)
      return;
    CultureInfo currentCultureInfo = frmPolicyDetail.CurrentCultureInfo;
    if (!Utility.IsNull((object) ((UltraGridBase) this.dgOptions).DisplayLayout) && ((KeyedSubObjectsCollectionBase) ((UltraGridBase) this.dgOptions).DisplayLayout.Bands).Exists("LinesOptionstblQuoteOptions"))
    {
      UltraGridBand band = ((UltraGridBase) this.dgOptions).DisplayLayout.Bands["LinesOptionstblQuoteOptions"];
      if (((KeyedSubObjectsCollectionBase) band.Columns).Exists("Premium"))
        band.Columns["premium"].FormatInfo = (IFormatProvider) currentCultureInfo;
      if (((KeyedSubObjectsCollectionBase) band.Columns).Exists("Fees"))
        band.Columns["Fees"].FormatInfo = (IFormatProvider) currentCultureInfo;
    }
    if (Utility.IsNull((object) ((UltraGridBase) this.dgOptions).DisplayLayout) || !((KeyedSubObjectsCollectionBase) ((UltraGridBase) this.dgOptions).DisplayLayout.Bands).Exists("tblQuoteOptionsviewOptionPremiums1"))
      return;
    UltraGridBand band1 = ((UltraGridBase) this.dgOptions).DisplayLayout.Bands["tblQuoteOptionsviewOptionPremiums1"];
    if (!((KeyedSubObjectsCollectionBase) band1.Columns).Exists("Premium"))
      return;
    band1.Columns["Premium"].FormatInfo = (IFormatProvider) currentCultureInfo;
  }

  private void btnOK_Click(object sender, EventArgs e) => this.Close();

  private void lnkViewReport_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    try
    {
      this.Cursor = MgaCursors.WaitCursor;
      ViewSummaryReport viewSummaryReport = new ViewSummaryReport(this._dsPremiums);
      viewSummaryReport.Run();
      ((Control) new frmPrint((SectionReport) viewSummaryReport)).Show();
      using (PdfExport pdfExport = new PdfExport())
      {
        using (MemoryStream memoryStream = new MemoryStream())
        {
          pdfExport.Export(viewSummaryReport.Document, (Stream) memoryStream);
          string str = $"PremiumsAndFeesSummaryReport-ControlNo{Conversions.ToString(this._controlno)}.pdf".Replace("/", string.Empty).Replace("\\", string.Empty).Replace(" ", string.Empty);
          char[] invalidFileNameChars = Path.GetInvalidFileNameChars();
          int index = 0;
          while (index < invalidFileNameChars.Length)
          {
            char ch = invalidFileNameChars[index];
            str = str.Replace(Conversions.ToString(ch), string.Empty);
            checked { ++index; }
          }
          string path = MGATempFolder.MGATempPath + str;
          using (FileStream fileStream = new FileStream(path, FileMode.Create))
          {
            memoryStream.WriteTo((Stream) fileStream);
            fileStream.Write(memoryStream.ToArray(), 0, (int) memoryStream.Position);
          }
          if (this._isThisTransaction != 0)
            return;
          QuoteOption quoteOption = new QuoteOption(this._dsPremiums.tblQuoteOptions[0].QuoteOptionGuid);
          DocumentManager.BeginFileAddWithBind(path, (ISupportDocumentSystem) quoteOption.Quote, string.Empty);
        }
      }
    }
    catch (IOException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      IOException ioException = ex;
      if (ioException.Message.Contains("used by another process"))
      {
        int num = (int) MessageBox.Show("Cannot execute this request because the report is being used by another process", "Report Being Used By Another Process", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      }
      else
        ErrorHandler.HandleError((Exception) ioException);
      ProjectData.ClearProjectError();
    }
    finally
    {
      this.Cursor = MgaCursors.Default;
    }
  }
}
