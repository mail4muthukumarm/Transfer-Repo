// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.PolicyDetail.PolicyDetail_Premiums
// Assembly: MgaSystems.IMS.Policies, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 2FF2C709-F7BF-41DA-82BD-FF6319CA235D
// Assembly location: C:\Users\muthu\Downloads\MgaSystems.IMS.Policies.dll

using Infragistics.Shared;
using Infragistics.Win;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinMaskedEdit;
using Infragistics.Win.UltraWinScrollBar;
using MGASystems.BusinessObjects;
using MGASystems.BusinessObjects.Rating;
using MGASystems.Common;
using MGASystems.Common.Enums;
using MGASystems.Common.ErrorHandling;
using MGASystems.Common.Settings;
using MGASystems.Data;
using MGASystems.Data.DbExtensions;
using MGASystems.IMS.Policies.Clearance;
using MGASystems.IMS.Policies.InstallmentBilling;
using MGASystems.InfragisticsExtensions.Editors;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Policies.PolicyDetail;

[PolicyDetail_Plugin("Premiums", "Premiums and Fees")]
public class PolicyDetail_Premiums : PolicyDetail_Plugin
{
  private IContainer components;
  private dsPolicyDetail_Premiums ds;
  protected Guid _quoteGuid;
  private PolicyDetail_Premiums.Style _style;
  private HyperlinkEditor _hlkOptions;
  private HyperlinkEditor _hlkInstallmentBilling;
  private dsPolicyDetail_Premiums _dsPremiums;
  protected Quote _quote;
  private bool _hasZeroPremiumZeroFeesOnCurrentVersion;
  private dsPolicyDetail_Premiums _dsCurrentVersionPremiums;
  private bool _collapseZeroPremiumRows;
  protected string _SpNameForClients;
  private Guid _currentUserGuid;
  private CultureInfo _cultureInfo;
  private string _culturenameOnQuote;

  protected override void Dispose(bool disposing)
  {
    if (disposing)
    {
      if (this.components != null)
        this.components.Dispose();
      if (this._hlkOptions != null)
      {
        this._hlkOptions.HyperLinkOpening -= new CancelEventHandler(this.hlkOptions_Opening);
        ((DisposableObject) this._hlkOptions).Dispose();
      }
      if (this._hlkInstallmentBilling != null)
      {
        this._hlkInstallmentBilling.HyperLinkOpening -= new CancelEventHandler(this.hlkInstallmentBilling_Opening);
        ((DisposableObject) this._hlkInstallmentBilling).Dispose();
      }
    }
    base.Dispose(disposing);
  }

  [field: AccessedThroughProperty("Label1")]
  protected internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected internal virtual LinkLabel lnkThisTransaction
  {
    get => this._lnkThisTransaction;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkThisTransaction_LinkClicked);
      LinkLabel lnkThisTransaction1 = this._lnkThisTransaction;
      if (lnkThisTransaction1 != null)
        lnkThisTransaction1.LinkClicked -= clickedEventHandler;
      this._lnkThisTransaction = value;
      LinkLabel lnkThisTransaction2 = this._lnkThisTransaction;
      if (lnkThisTransaction2 == null)
        return;
      lnkThisTransaction2.LinkClicked += clickedEventHandler;
    }
  }

  protected internal virtual LinkLabel lnkAllTransactions
  {
    get => this._lnkAllTransactions;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkAllTransactions_LinkClicked);
      LinkLabel lnkAllTransactions1 = this._lnkAllTransactions;
      if (lnkAllTransactions1 != null)
        lnkAllTransactions1.LinkClicked -= clickedEventHandler;
      this._lnkAllTransactions = value;
      LinkLabel lnkAllTransactions2 = this._lnkAllTransactions;
      if (lnkAllTransactions2 == null)
        return;
      lnkAllTransactions2.LinkClicked += clickedEventHandler;
    }
  }

  protected internal virtual UltraGrid dgOptions
  {
    get => this._dgOptions;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      CellEventHandler cellEventHandler = new CellEventHandler(this.dgOptions_CellChange);
      InitializeRowEventHandler initializeRowEventHandler = new InitializeRowEventHandler(this.ColorNegativeValuesInGrid);
      UltraGrid dgOptions1 = this._dgOptions;
      if (dgOptions1 != null)
      {
        dgOptions1.CellChange -= cellEventHandler;
        dgOptions1.InitializeRow -= initializeRowEventHandler;
      }
      this._dgOptions = value;
      UltraGrid dgOptions2 = this._dgOptions;
      if (dgOptions2 == null)
        return;
      dgOptions2.CellChange += cellEventHandler;
      dgOptions2.InitializeRow += initializeRowEventHandler;
    }
  }

  protected internal virtual LinkLabel lnkViewSummary
  {
    get => this._lnkViewSummary;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkViewSummary_LinkClicked);
      LinkLabel lnkViewSummary1 = this._lnkViewSummary;
      if (lnkViewSummary1 != null)
        lnkViewSummary1.LinkClicked -= clickedEventHandler;
      this._lnkViewSummary = value;
      LinkLabel lnkViewSummary2 = this._lnkViewSummary;
      if (lnkViewSummary2 == null)
        return;
      lnkViewSummary2.LinkClicked += clickedEventHandler;
    }
  }

  [field: AccessedThroughProperty("lblClaimsExist")]
  protected internal virtual Label lblClaimsExist { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected internal virtual LinkLabel lnkSelectAllBind
  {
    get => this._lnkSelectAllBind;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.LnkSelectAllBind_LinkClicked);
      LinkLabel lnkSelectAllBind1 = this._lnkSelectAllBind;
      if (lnkSelectAllBind1 != null)
        lnkSelectAllBind1.LinkClicked -= clickedEventHandler;
      this._lnkSelectAllBind = value;
      LinkLabel lnkSelectAllBind2 = this._lnkSelectAllBind;
      if (lnkSelectAllBind2 == null)
        return;
      lnkSelectAllBind2.LinkClicked += clickedEventHandler;
    }
  }

  protected internal virtual LinkLabel lnkSelectAllQuote
  {
    get => this._lnkSelectAllQuote;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.LnkSelectAllQuote_LinkClicked);
      LinkLabel lnkSelectAllQuote1 = this._lnkSelectAllQuote;
      if (lnkSelectAllQuote1 != null)
        lnkSelectAllQuote1.LinkClicked -= clickedEventHandler;
      this._lnkSelectAllQuote = value;
      LinkLabel lnkSelectAllQuote2 = this._lnkSelectAllQuote;
      if (lnkSelectAllQuote2 == null)
        return;
      lnkSelectAllQuote2.LinkClicked += clickedEventHandler;
    }
  }

  private virtual UltraGrid dgTotalPolicy
  {
    get => this._dgTotalPolicy;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      InitializeRowEventHandler initializeRowEventHandler = new InitializeRowEventHandler(this.ColorNegativeValuesInGrid);
      UltraGrid dgTotalPolicy1 = this._dgTotalPolicy;
      if (dgTotalPolicy1 != null)
        dgTotalPolicy1.InitializeRow -= initializeRowEventHandler;
      this._dgTotalPolicy = value;
      UltraGrid dgTotalPolicy2 = this._dgTotalPolicy;
      if (dgTotalPolicy2 == null)
        return;
      dgTotalPolicy2.InitializeRow += initializeRowEventHandler;
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
    UltraGridColumn ultraGridColumn15 = new UltraGridColumn("CurrencyCode");
    UltraGridColumn ultraGridColumn16 = new UltraGridColumn("tblQuoteOptionsviewOptionPremiums1");
    UltraGridBand ultraGridBand3 = new UltraGridBand("tblQuoteOptionsviewOptionPremiums1", 1);
    UltraGridColumn ultraGridColumn17 = new UltraGridColumn("QuoteOptionGuid");
    UltraGridColumn ultraGridColumn18 = new UltraGridColumn("StateID");
    UltraGridColumn ultraGridColumn19 = new UltraGridColumn("ChargeName");
    UltraGridColumn ultraGridColumn20 = new UltraGridColumn("Premium");
    UltraGridColumn ultraGridColumn21 = new UltraGridColumn("Location");
    UltraGridColumn ultraGridColumn22 = new UltraGridColumn("CurrencyCode");
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    ScrollBarLook scrollBarLook1 = new ScrollBarLook();
    Appearance appearance11 = new Appearance();
    UltraGridBand ultraGridBand4 = new UltraGridBand("AllLinesOptions", -1);
    UltraGridColumn ultraGridColumn23 = new UltraGridColumn("LineGuid");
    UltraGridColumn ultraGridColumn24 = new UltraGridColumn("LineName");
    Appearance appearance12 = new Appearance();
    UltraGridColumn ultraGridColumn25 = new UltraGridColumn("AllLinesOptionsBoundOptions");
    UltraGridBand ultraGridBand5 = new UltraGridBand("AllLinesOptionsBoundOptions", 0);
    UltraGridColumn ultraGridColumn26 = new UltraGridColumn("StateID");
    UltraGridColumn ultraGridColumn27 = new UltraGridColumn("ChargeName");
    UltraGridColumn ultraGridColumn28 = new UltraGridColumn("Premium");
    UltraGridColumn ultraGridColumn29 = new UltraGridColumn("Location");
    UltraGridColumn ultraGridColumn30 = new UltraGridColumn("LineGuid");
    Appearance appearance13 = new Appearance();
    Appearance appearance14 = new Appearance();
    ScrollBarLook scrollBarLook2 = new ScrollBarLook();
    this.ds = new dsPolicyDetail_Premiums();
    this.dgOptions = new UltraGrid();
    this.lnkThisTransaction = new LinkLabel();
    this.lnkAllTransactions = new LinkLabel();
    this.Label1 = new Label();
    this.dgTotalPolicy = new UltraGrid();
    this.lnkViewSummary = new LinkLabel();
    this.lblClaimsExist = new Label();
    this.lnkSelectAllBind = new LinkLabel();
    this.lnkSelectAllQuote = new LinkLabel();
    this.ds.BeginInit();
    ((ISupportInitialize) this.dgOptions).BeginInit();
    ((ISupportInitialize) this.dgTotalPolicy).BeginInit();
    this.SuspendLayout();
    this.ds.DataSetName = "dsPolicyDetail_Premiums_Premiums";
    this.ds.Locale = new CultureInfo("en-US");
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    ((Control) this.dgOptions).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraGridBase) this.dgOptions).DataSource = (object) this.ds.LinesOptions;
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
    ultraGridColumn3.Width = 643;
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
    ultraGridColumn8.Width = 152;
    ultraGridColumn9.CellActivation = (Activation) 3;
    ultraGridColumn9.Format = "d";
    ((HeaderBase) ultraGridColumn9.Header).Caption = "Created";
    ((HeaderBase) ultraGridColumn9.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn9.Header.VisiblePosition = 5;
    ultraGridColumn9.Width = 87;
    ((HeaderBase) ultraGridColumn10.Header).Caption = "Bind";
    ((HeaderBase) ultraGridColumn10.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn10.Header.VisiblePosition = 6;
    ultraGridColumn10.Width = 46;
    ((HeaderBase) ultraGridColumn11.Header).Caption = "Quoted";
    ((HeaderBase) ultraGridColumn11.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn11.Header.VisiblePosition = 7;
    ultraGridColumn11.Width = 59;
    ultraGridColumn12.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance5).TextHAlignAsString = "Right";
    ultraGridColumn12.CellAppearance = (AppearanceBase) appearance5;
    ultraGridColumn12.Format = "c";
    ((AppearanceBase) appearance6).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn12.Header).Appearance = (AppearanceBase) appearance6;
    ((HeaderBase) ultraGridColumn12.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn12.Header.VisiblePosition = 4;
    ultraGridColumn12.Width = 130;
    appearance7.FontData.UnderlineAsString = "True";
    appearance7.ForeColor = Color.Blue;
    ((AppearanceBase) appearance7).TextHAlignAsString = "Center";
    ultraGridColumn13.CellAppearance = (AppearanceBase) appearance7;
    ((HeaderBase) ultraGridColumn13.Header).Caption = "Detail";
    ((HeaderBase) ultraGridColumn13.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn13.Header.VisiblePosition = 8;
    ultraGridColumn13.Width = 39;
    appearance8.FontData.UnderlineAsString = "True";
    appearance8.ForeColor = Color.Blue;
    ((AppearanceBase) appearance8).TextHAlignAsString = "Center";
    ultraGridColumn14.CellAppearance = (AppearanceBase) appearance8;
    ((HeaderBase) ultraGridColumn14.Header).Caption = "Installment Billing";
    ((HeaderBase) ultraGridColumn14.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn14.Header.VisiblePosition = 9;
    ultraGridColumn14.Width = 111;
    ((HeaderBase) ultraGridColumn15.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn15.Header.VisiblePosition = 10;
    ultraGridColumn15.Hidden = true;
    ultraGridColumn15.Width = 87;
    ((HeaderBase) ultraGridColumn16.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn16.Header.VisiblePosition = 11;
    ultraGridBand2.Columns.AddRange(new object[12]
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
      (object) ultraGridColumn15,
      (object) ultraGridColumn16
    });
    ((HeaderBase) ultraGridColumn17.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn17.Header.VisiblePosition = 0;
    ultraGridColumn17.Hidden = true;
    ultraGridColumn17.Width = 239;
    ultraGridColumn18.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn18.Header).Caption = "State";
    ((HeaderBase) ultraGridColumn18.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn18.Header.VisiblePosition = 1;
    ultraGridColumn18.Width = 57;
    ultraGridColumn19.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn19.Header).Caption = "Item";
    ((HeaderBase) ultraGridColumn19.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn19.Header.VisiblePosition = 2;
    ultraGridColumn19.Width = 240 /*0xF0*/;
    ultraGridColumn20.CellActivation = (Activation) 3;
    ultraGridColumn20.Format = "c";
    ((HeaderBase) ultraGridColumn20.Header).Caption = "Amount";
    ((HeaderBase) ultraGridColumn20.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn20.Header.VisiblePosition = 3;
    ultraGridColumn20.Width = 140;
    ultraGridColumn21.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn21.Header).Caption = "Office";
    ((HeaderBase) ultraGridColumn21.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn21.Header.VisiblePosition = 4;
    ultraGridColumn21.Width = 168;
    ((HeaderBase) ultraGridColumn22.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn22.Header.VisiblePosition = 5;
    ultraGridColumn22.Hidden = true;
    ultraGridColumn22.Width = 85;
    ultraGridBand3.Columns.AddRange(new object[6]
    {
      (object) ultraGridColumn17,
      (object) ultraGridColumn18,
      (object) ultraGridColumn19,
      (object) ultraGridColumn20,
      (object) ultraGridColumn21,
      (object) ultraGridColumn22
    });
    ultraGridBand3.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((UltraGridBase) this.dgOptions).DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    ((UltraGridBase) this.dgOptions).DisplayLayout.BandsSerializer.Add((object) ultraGridBand2);
    ((UltraGridBase) this.dgOptions).DisplayLayout.BandsSerializer.Add((object) ultraGridBand3);
    ((UltraGridBase) this.dgOptions).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.dgOptions).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.dgOptions).DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.dgOptions).DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 1;
    appearance9.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.dgOptions).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance9;
    appearance10.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.dgOptions).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance10;
    ((UltraGridBase) this.dgOptions).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    scrollBarLook1.ViewStyle = (ScrollBarViewStyle) 3;
    ((UltraGridBase) this.dgOptions).DisplayLayout.ScrollBarLook = scrollBarLook1;
    ((Control) this.dgOptions).Location = new Point(0, 0);
    ((Control) this.dgOptions).Name = "dgOptions";
    ((Control) this.dgOptions).Size = new Size(664, 187);
    ((Control) this.dgOptions).TabIndex = 9;
    ((UltraControlBase) this.dgOptions).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dgOptions).UseOsThemes = (DefaultableBoolean) 2;
    this.lnkThisTransaction.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkThisTransaction.Location = new Point(0, 187);
    this.lnkThisTransaction.Name = "lnkThisTransaction";
    this.lnkThisTransaction.Size = new Size(88, 23);
    this.lnkThisTransaction.TabIndex = 10;
    this.lnkThisTransaction.TabStop = true;
    this.lnkThisTransaction.Text = "This Transaction";
    this.lnkThisTransaction.TextAlign = ContentAlignment.MiddleLeft;
    this.lnkAllTransactions.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkAllTransactions.Location = new Point(104, 187);
    this.lnkAllTransactions.Name = "lnkAllTransactions";
    this.lnkAllTransactions.Size = new Size(88, 23);
    this.lnkAllTransactions.TabIndex = 11;
    this.lnkAllTransactions.TabStop = true;
    this.lnkAllTransactions.Text = "All Transactions";
    this.lnkAllTransactions.TextAlign = ContentAlignment.MiddleLeft;
    this.Label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.Label1.Location = new Point(88, 187);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(16 /*0x10*/, 23);
    this.Label1.TabIndex = 12;
    this.Label1.Text = "/";
    this.Label1.TextAlign = ContentAlignment.MiddleCenter;
    ((Control) this.dgTotalPolicy).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraGridBase) this.dgTotalPolicy).DataSource = (object) this.ds.AllLinesOptions;
    appearance11.BackColor = Color.White;
    appearance11.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.dgTotalPolicy).DisplayLayout.Appearance = (AppearanceBase) appearance11;
    ((UltraGridBase) this.dgTotalPolicy).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ((HeaderBase) ultraGridColumn23.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn23.Header.VisiblePosition = 0;
    ultraGridColumn23.Hidden = true;
    ultraGridColumn24.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance12).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn24.Header).Appearance = (AppearanceBase) appearance12;
    ((HeaderBase) ultraGridColumn24.Header).Caption = "Line";
    ((HeaderBase) ultraGridColumn24.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn24.Header.VisiblePosition = 1;
    ultraGridColumn24.Width = 596;
    ((HeaderBase) ultraGridColumn25.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn25.Header.VisiblePosition = 2;
    ultraGridBand4.Columns.AddRange(new object[3]
    {
      (object) ultraGridColumn23,
      (object) ultraGridColumn24,
      (object) ultraGridColumn25
    });
    ((HeaderBase) ultraGridColumn26.Header).Caption = "State";
    ((HeaderBase) ultraGridColumn26.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn26.Header.VisiblePosition = 0;
    ultraGridColumn26.Width = 47;
    ((HeaderBase) ultraGridColumn27.Header).Caption = "Item";
    ((HeaderBase) ultraGridColumn27.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn27.Header.VisiblePosition = 1;
    ultraGridColumn27.Width = 212;
    ultraGridColumn28.Format = "c";
    ((HeaderBase) ultraGridColumn28.Header).Caption = "Amount";
    ((HeaderBase) ultraGridColumn28.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn28.Header.VisiblePosition = 2;
    ultraGridColumn28.Width = 103;
    ((HeaderBase) ultraGridColumn29.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn29.Header.VisiblePosition = 3;
    ultraGridColumn29.Width = 215;
    ((HeaderBase) ultraGridColumn30.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn30.Header.VisiblePosition = 4;
    ultraGridColumn30.Hidden = true;
    ultraGridBand5.Columns.AddRange(new object[5]
    {
      (object) ultraGridColumn26,
      (object) ultraGridColumn27,
      (object) ultraGridColumn28,
      (object) ultraGridColumn29,
      (object) ultraGridColumn30
    });
    ((UltraGridBase) this.dgTotalPolicy).DisplayLayout.BandsSerializer.Add((object) ultraGridBand4);
    ((UltraGridBase) this.dgTotalPolicy).DisplayLayout.BandsSerializer.Add((object) ultraGridBand5);
    ((UltraGridBase) this.dgTotalPolicy).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.dgTotalPolicy).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.dgTotalPolicy).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.dgTotalPolicy).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((UltraGridBase) this.dgTotalPolicy).DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.dgTotalPolicy).DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 1;
    appearance13.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.dgTotalPolicy).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance13;
    appearance14.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.dgTotalPolicy).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance14;
    ((UltraGridBase) this.dgTotalPolicy).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    scrollBarLook2.ViewStyle = (ScrollBarViewStyle) 3;
    ((UltraGridBase) this.dgTotalPolicy).DisplayLayout.ScrollBarLook = scrollBarLook2;
    ((Control) this.dgTotalPolicy).Location = new Point(197, 210);
    ((Control) this.dgTotalPolicy).Name = "dgTotalPolicy";
    ((Control) this.dgTotalPolicy).Size = new Size(617, 244);
    ((Control) this.dgTotalPolicy).TabIndex = 13;
    ((UltraControlBase) this.dgTotalPolicy).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dgTotalPolicy).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.dgTotalPolicy).Visible = false;
    this.lnkViewSummary.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkViewSummary.Location = new Point(563, 187);
    this.lnkViewSummary.Name = "lnkViewSummary";
    this.lnkViewSummary.Size = new Size(87, 23);
    this.lnkViewSummary.TabIndex = 14;
    this.lnkViewSummary.TabStop = true;
    this.lnkViewSummary.Text = "View Summary";
    this.lnkViewSummary.TextAlign = ContentAlignment.MiddleLeft;
    this.lblClaimsExist.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lblClaimsExist.AutoSize = true;
    this.lblClaimsExist.Font = new Font("Microsoft Sans Serif", 10.5f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.lblClaimsExist.ForeColor = Color.Red;
    this.lblClaimsExist.Location = new Point(233, 189);
    this.lblClaimsExist.Name = "lblClaimsExist";
    this.lblClaimsExist.Size = new Size(203, 17);
    this.lblClaimsExist.TabIndex = 15;
    this.lblClaimsExist.Text = "Alert! Claims exist on this policy";
    this.lnkSelectAllBind.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkSelectAllBind.Location = new Point(0, 210);
    this.lnkSelectAllBind.Name = "lnkSelectAllBind";
    this.lnkSelectAllBind.Size = new Size(88, 23);
    this.lnkSelectAllBind.TabIndex = 16 /*0x10*/;
    this.lnkSelectAllBind.TabStop = true;
    this.lnkSelectAllBind.Text = "Select All Bind";
    this.lnkSelectAllBind.TextAlign = ContentAlignment.MiddleLeft;
    this.lnkSelectAllQuote.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkSelectAllQuote.Location = new Point(88, 210);
    this.lnkSelectAllQuote.Name = "lnkSelectAllQuote";
    this.lnkSelectAllQuote.Size = new Size(103, 23);
    this.lnkSelectAllQuote.TabIndex = 17;
    this.lnkSelectAllQuote.TabStop = true;
    this.lnkSelectAllQuote.Text = "Select All Quoted";
    this.lnkSelectAllQuote.TextAlign = ContentAlignment.MiddleLeft;
    this.BackColor = Color.White;
    this.Controls.Add((Control) this.lnkSelectAllQuote);
    this.Controls.Add((Control) this.lnkSelectAllBind);
    this.Controls.Add((Control) this.lblClaimsExist);
    this.Controls.Add((Control) this.dgTotalPolicy);
    this.Controls.Add((Control) this.Label1);
    this.Controls.Add((Control) this.lnkAllTransactions);
    this.Controls.Add((Control) this.lnkThisTransaction);
    this.Controls.Add((Control) this.dgOptions);
    this.Controls.Add((Control) this.lnkViewSummary);
    this.Name = nameof (PolicyDetail_Premiums);
    this.Size = new Size(664, 234);
    this.ds.EndInit();
    ((ISupportInitialize) this.dgOptions).EndInit();
    ((ISupportInitialize) this.dgTotalPolicy).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  public List<(Guid lineGuid, int companyLocationID)> LineGuidsToHide { get; set; }

  internal PolicyDetail_Premiums()
  {
    this.Load += new EventHandler(this.PolicyDetail_Premiums_Load);
    this._style = PolicyDetail_Premiums.Style.ThisVersion;
    this._hlkOptions = new HyperlinkEditor();
    this._hlkInstallmentBilling = new HyperlinkEditor();
    this.LineGuidsToHide = new List<(Guid, int)>();
    this.InitializeComponent();
    this.SetStyle(ControlStyles.DoubleBuffer, true);
    this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
    ((Control) this.dgOptions).Location = new Point(0, 0);
  }

  public PolicyDetail_Premiums(Guid quoteGuid)
    : this()
  {
    this._quoteGuid = quoteGuid;
    this._quote = new Quote(quoteGuid);
    if (SystemSettings.KeyExists("CollapseZeroPremiumRows") && SystemSettings.GetBoolSetting("CollapseZeroPremiumRows"))
      this._collapseZeroPremiumRows = true;
    this._currentUserGuid = CurrentUser.Instance.UserGUID;
  }

  public event PolicyDetail_Premiums.PremiumsControlLoadedEventHandler PremiumsControlLoaded;

  internal bool FillComplete
  {
    get => this._dsPremiums != null && this._dsPremiums.tblQuoteOptions != null;
  }

  internal int OptionCount => this._dsPremiums.tblQuoteOptions.Count;

  internal bool ZeroPremiumZeroFees()
  {
    bool flag = true;
    try
    {
      foreach (dsPolicyDetail_Premiums.tblQuoteOptionsRow tblQuoteOption in (TypedTableBase<dsPolicyDetail_Premiums.tblQuoteOptionsRow>) this._dsPremiums.tblQuoteOptions)
      {
        if (tblQuoteOption.Bound && (Decimal.Compare(tblQuoteOption.Premium, 0M) != 0 || Decimal.Compare(tblQuoteOption.Fees, 0M) != 0))
        {
          flag = false;
          break;
        }
      }
    }
    finally
    {
      IEnumerator<dsPolicyDetail_Premiums.tblQuoteOptionsRow> enumerator;
      enumerator?.Dispose();
    }
    return flag;
  }

  public bool HasPremium
  {
    get
    {
      bool hasPremium;
      if (this._dsPremiums == null)
      {
        hasPremium = false;
      }
      else
      {
        try
        {
          foreach (dsPolicyDetail_Premiums.tblQuoteOptionsRow tblQuoteOption in (TypedTableBase<dsPolicyDetail_Premiums.tblQuoteOptionsRow>) this._dsPremiums.tblQuoteOptions)
          {
            if (Decimal.Compare(tblQuoteOption.Premium, 0M) != 0 || Decimal.Compare(tblQuoteOption.Fees, 0M) != 0)
            {
              hasPremium = true;
              goto label_10;
            }
          }
        }
        finally
        {
          IEnumerator<dsPolicyDetail_Premiums.tblQuoteOptionsRow> enumerator;
          enumerator?.Dispose();
        }
        hasPremium = false;
      }
label_10:
      return hasPremium;
    }
  }

  public bool CurrentVersionZeroPremiumZeroFees => this._hasZeroPremiumZeroFeesOnCurrentVersion;

  public dsPolicyDetail_Premiums CurrentVersionPremiums => this._dsCurrentVersionPremiums;

  public frmPolicyDetail PolicyDetailForm => this.ParentForm as frmPolicyDetail;

  private void PolicyDetail_Premiums_Load(object sender, EventArgs e)
  {
    if (this.DesignMode)
      return;
    this._hlkOptions.HyperLinkOpening += new CancelEventHandler(this.hlkOptions_Opening);
    this._hlkInstallmentBilling.HyperLinkOpening += new CancelEventHandler(this.hlkInstallmentBilling_Opening);
    if (this._quote.IsBound)
    {
      ((UltraGridBase) this.dgOptions).DisplayLayout.Bands[1].Columns["Bound"].CellActivation = (Activation) 3;
      ((UltraGridBase) this.dgOptions).DisplayLayout.Bands[1].Columns["Quote"].CellActivation = (Activation) 3;
    }
    DataRow row = DefaultDatabase.ExecuteDataRow("dbo.spPolicyClaimsExist", new object[2]
    {
      (object) "@controlNo",
      (object) this._quote.ControlNo
    });
    bool flag1 = row.Field<bool>("claimExists");
    bool flag2 = row.Field<bool>("claimExistsOnExpired");
    if (flag1 | flag2)
    {
      this.lblClaimsExist.Visible = true;
      if (this._quote.IsRenewal | this._quote.IsImsRenewal | this._quote.IsTrueImsRenewal)
      {
        if (flag1)
          this.lblClaimsExist.Text = "Alert! Claims exist on this policy.";
        if (!flag1 && flag2)
          this.lblClaimsExist.Text = "Alert! Claims exist on expiring policy.";
      }
      else if (flag1)
        this.lblClaimsExist.Text = "Alert! Claims exist on this policy.";
    }
    else
      this.lblClaimsExist.Visible = false;
    if (!this.lblClaimsExist.Visible)
    {
      if (DefaultDatabase.ExecuteScalar<bool>("dbo.spPolicyClaimsExistOnInsured", new object[2]
      {
        (object) "@controlNo",
        (object) this._quote.ControlNo
      }))
      {
        this.lblClaimsExist.Visible = true;
        this.lblClaimsExist.Text = "Alert! This Insured Has Claims";
      }
    }
    try
    {
      string str = MGASystems.Common.Telematics.Telematics.telematicsSingleton.PolicyDetailMessage(this._quote.ControlNo);
      if (str.Length > 0)
      {
        this.lblClaimsExist.Visible = true;
        this.lblClaimsExist.Text = this.lblClaimsExist.Text.Length <= 0 ? str : (!this.lblClaimsExist.Text.EndsWith(".") ? $"{this.lblClaimsExist.Text}, {str}" : $"{this.lblClaimsExist.Text} {str}");
      }
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      ErrorHandler.SilentHandleError(ex);
      ProjectData.ClearProjectError();
    }
    this.AfterFormLoad();
  }

  protected virtual void AfterFormLoad()
  {
  }

  public override void Fill() => ThreadPool.QueueUserWorkItem(new WaitCallback(this.ThreadedFill));

  public void SetOptionBound(Guid quoteOptionGuid, bool bound, CellEventArgs e)
  {
    if (e == null)
      throw new ArgumentNullException(nameof (e));
    if (this._quote.IsBound)
      throw new InvalidOperationException("Can Not modify Option status On a bound policy");
    this._dsPremiums.tblQuoteOptions.FindByQuoteOptionGuid(quoteOptionGuid).Bound = bound;
    e.Cell.CancelUpdate();
    ((UltraGridBase) this.dgOptions).Rows.Refresh((RefreshRow) 2, true);
  }

  public void SetOptionBound(Guid quoteOptionGuid, bool bound)
  {
    if (this._quote.IsBound)
      throw new InvalidOperationException("Can Not modify Option status On a bound policy");
    this._dsPremiums.tblQuoteOptions.FindByQuoteOptionGuid(quoteOptionGuid).Bound = bound;
    ((UltraGridBase) this.dgOptions).Rows.Refresh((RefreshRow) 2, true);
  }

  internal Guid GetOnlyOptionGuid()
  {
    if (this._dsPremiums.tblQuoteOptions.Count != 1)
      throw new InvalidOperationException("This method should be called When only one Option Is expected.");
    return this._dsPremiums.tblQuoteOptions[0].QuoteOptionGuid;
  }

  internal bool ReadyToPrint()
  {
    bool print;
    if (this._dsPremiums == null)
    {
      print = false;
    }
    else
    {
      try
      {
        foreach (dsPolicyDetail_Premiums.LinesOptionsRow linesOption in (TypedTableBase<dsPolicyDetail_Premiums.LinesOptionsRow>) this._dsPremiums.LinesOptions)
        {
          int length = this._dsPremiums.tblQuoteOptions.Select($"LineGuid='{linesOption.LineGuid.ToString()}' AND Quote=1").Length;
          if (length == 0)
          {
            if (this._dsPremiums.tblQuoteOptions.Select($"LineGuid='{linesOption.LineGuid.ToString()}'").Length == 1)
              ((dsPolicyDetail_Premiums.tblQuoteOptionsRow) this._dsPremiums.tblQuoteOptions.Select($"LineGuid='{linesOption.LineGuid.ToString()}'")[0]).Quote = true;
          }
          else if (length > 1 && !this._quote.IsMultiCompanyPolicy)
          {
            int num = (int) MessageBox.Show(linesOption.LineName + " can only have one option marked as quoted, which will be used for the quote.", "Bound Option Required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            print = false;
            goto label_13;
          }
        }
      }
      finally
      {
        IEnumerator<dsPolicyDetail_Premiums.LinesOptionsRow> enumerator;
        enumerator?.Dispose();
      }
      print = true;
    }
label_13:
    return print;
  }

  internal bool HasLine(Guid lineGuid)
  {
    return this._dsPremiums.LinesOptions.Select($"LineGuid='{lineGuid.ToString()}'").Length > 0;
  }

  internal bool CurrentQuoteVersionHasLine(Guid lineGuid)
  {
    return this._dsCurrentVersionPremiums.LinesOptions.Select($"LineGuid='{lineGuid.ToString()}'").Length > 0;
  }

  internal bool ReadyToBind()
  {
    bool bind;
    if (this._dsPremiums == null)
    {
      bind = true;
    }
    else
    {
      if (!this._quote.IsMultiCompanyPolicy)
      {
        try
        {
          foreach (dsPolicyDetail_Premiums.LinesOptionsRow linesOption in (TypedTableBase<dsPolicyDetail_Premiums.LinesOptionsRow>) this._dsPremiums.LinesOptions)
          {
            int length = this._dsPremiums.tblQuoteOptions.Select($"LineGuid='{linesOption.LineGuid.ToString()}' AND Bound=1").Length;
            if (length == 0 && this._dsPremiums.tblQuoteOptions.Select($"LineGuid='{linesOption.LineGuid.ToString()}'").Length == 1)
            {
              dsPolicyDetail_Premiums.tblQuoteOptionsRow tblQuoteOptionsRow = (dsPolicyDetail_Premiums.tblQuoteOptionsRow) this._dsPremiums.tblQuoteOptions.Select($"LineGuid='{linesOption.LineGuid.ToString()}'")[0];
              Guid quoteOptionGuid = tblQuoteOptionsRow.QuoteOptionGuid;
              tblQuoteOptionsRow.Bound = true;
              this.BindUnbindOption(true, quoteOptionGuid);
            }
            else
            {
              if (length == 0)
              {
                int num = (int) MessageBox.Show($"Please bind an option for {linesOption.LineName}.", "Bound Option Required", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                bind = false;
                goto label_15;
              }
              if (length > 1 && !this._quote.IsMultiCompanyPolicy)
              {
                int num = (int) MessageBox.Show(linesOption.LineName + " can only have one bound option.", "Bound Option Required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                bind = false;
                goto label_15;
              }
            }
          }
        }
        finally
        {
          IEnumerator<dsPolicyDetail_Premiums.LinesOptionsRow> enumerator;
          enumerator?.Dispose();
        }
      }
      bind = true;
    }
label_15:
    return bind;
  }

  private void dgOptions_CellChange(object sender, CellEventArgs e)
  {
    this.CellChangeHelper(RuntimeHelpers.GetObjectValue(sender), e);
  }

  private void UpdateQuoteStatus(bool quoted)
  {
    this._quote.QuoteStatus = !quoted ? (QuoteStatus) 1 : (QuoteStatus) 2;
    try
    {
      foreach (frmClearance frmClearance in MDIControls.Instance.MDIParent.MdiChildren.OfType<frmClearance>())
      {
        if (quoted)
          frmClearance.UpdateQuoteStatus(this._quoteGuid);
        else
          frmClearance.UpdateQuoteStatus(this._quoteGuid);
      }
    }
    finally
    {
      IEnumerator<frmClearance> enumerator;
      enumerator?.Dispose();
    }
    this.PolicyDetailForm.RefreshPolicyData();
    this.QuoteStatusChanged(quoted, this._quoteGuid, Utility.IsNull<Decimal>(RuntimeHelpers.GetObjectValue(this._dsPremiums.tblQuoteOptions.Compute("SUM(Premium)", string.Empty)), 0M));
  }

  private void hlkOptions_Opening(object sender, CancelEventArgs e) => this.UpdateOptionDetail();

  private void hlkInstallmentBilling_Opening(object sender, CancelEventArgs e)
  {
    e.Cancel = true;
    Guid quoteOptionGuid = (Guid) ((UltraGridBase) this.dgOptions).ActiveRow.Cells["QuoteOptionGuid"].Value;
    QuoteOption quoteOption = new QuoteOption(quoteOptionGuid);
    quoteOption.SetupDefaultInstallmentBilling();
    InstallmentBillingPay priorInstallBillOpt = new InstallmentBillingPay(quoteOptionGuid);
    frmInstallmentBillingOptions formEx = (frmInstallmentBillingOptions) ObjectFactory.Instance.CreateFormEX(typeof (frmInstallmentBillingOptions), new object[1]
    {
      (object) quoteOption.QuoteOptionID
    });
    formEx.ShowInTaskbar = false;
    int num = (int) formEx.ShowDialog();
    bool clickedSaved = formEx.ClickedSaved;
    formEx.Dispose();
    if (!clickedSaved || this._quote.OptionCount <= 1)
      return;
    this.UpdateOtherInstallmentBillingPlans(quoteOptionGuid, priorInstallBillOpt);
  }

  private void UpdateOptionDetail()
  {
    Cursor.Current = MgaCursors.WaitCursor;
    try
    {
      MDIControls.Instance.StatusBarText = "Reading premium value from rater...";
      Guid guid = (Guid) ((UltraGridBase) this.dgOptions).ActiveRow.Cells["QuoteOptionGuid"].Value;
      IRater rater = RaterFactory.GetRater(DefaultDatabase.ExecuteScalar<int>(CommandType.Text, "SELECT dbo.GetRaterIDUsedOnOption(@quoteOptionGuid)", new object[2]
      {
        (object) "@quoteOptionGuid",
        (object) guid
      }));
      if (rater == null)
      {
        int num = (int) MessageBox.Show("Could not associate a rater to this quote. Please contact your system admin.", "No Rater Found", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
      else
      {
        QuoteOption quoteOption = new QuoteOption(guid);
        if (Utility.IsNull(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT dbo.GetQuoteOptionCompanyLineGuid(@quoteOptionID)", new object[2]
        {
          (object) "@quoteOptionID",
          (object) quoteOption.QuoteOptionID
        })))))
          return;
        rater.InitializeState(this._quoteGuid, quoteOption.CompanyLineGuid);
        StringBuilder stringBuilder = new StringBuilder();
        stringBuilder.Append(rater.GetOptionDescription(guid));
        FormSettings.ShowFormDialog(typeof (frmGenericInfo), new object[2]
        {
          (object) "Quote Option Information:",
          (object) stringBuilder
        }).Dispose();
      }
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
      MDIControls.Instance.StatusBarText = string.Empty;
    }
  }

  private void SetControlStyle(PolicyDetail_Premiums.Style style)
  {
    if (style == this._style)
      return;
    this._style = style;
    switch (style)
    {
      case PolicyDetail_Premiums.Style.ThisVersion:
        ((Control) this.dgOptions).Visible = true;
        ((Control) this.dgTotalPolicy).Visible = false;
        ((Control) this.dgOptions).Location = new Point(0, 0);
        break;
      case PolicyDetail_Premiums.Style.TotalPolicy:
        ((Control) this.dgOptions).Visible = false;
        ((Control) this.dgTotalPolicy).Visible = true;
        UltraGrid dgTotalPolicy = this.dgTotalPolicy;
        ((Control) dgTotalPolicy).Height = ((Control) this.dgOptions).Height;
        ((Control) dgTotalPolicy).Width = ((Control) this.dgOptions).Width;
        ((Control) dgTotalPolicy).Location = new Point(0, 0);
        break;
    }
    this.Fill();
  }

  private void ThreadedFill(object state)
  {
    switch (this._style)
    {
      case PolicyDetail_Premiums.Style.ThisVersion:
        this.FillThisVersion();
        break;
      case PolicyDetail_Premiums.Style.TotalPolicy:
        this.FillTotalPolicy();
        break;
    }
  }

  protected virtual void SetStoredProcforClients()
  {
    this._SpNameForClients = "dbo.spPolicyDetail_Premiums";
  }

  private void FillThisVersion()
  {
    this.SetStoredProcforClients();
    if (!this._quoteGuid.Equals(Guid.Empty))
    {
      this._culturenameOnQuote = frmPolicyDetail.CurrencyCodeOnQuote;
      this._cultureInfo = frmPolicyDetail.CurrentCultureInfo;
    }
    DataTable dataTable = (DataTable) null;
    dsPolicyDetail_Premiums dsPremiums = new dsPolicyDetail_Premiums();
    try
    {
      DefaultDatabase.LoadDataSet((DataSet) dsPremiums, new string[3]
      {
        "LinesOptions",
        "tblQuoteOptions",
        "viewOptionPremiums"
      }, this._SpNameForClients, new object[2]
      {
        (object) "@QuoteGuid",
        (object) this._quoteGuid
      });
      dataTable = DefaultDatabase.ExecuteDataTable("dbo.GetFeeRestrictionsPerUser", new object[6]
      {
        (object) "@WholePolicy",
        (object) false,
        (object) "@QuoteGuid",
        (object) this._quoteGuid,
        (object) "@UserGuid",
        (object) this._currentUserGuid
      });
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      this.ShowExceptionOnUIThread((DataSet) null, ex);
      ProjectData.ClearProjectError();
    }
    catch (ConstraintException ex1)
    {
      ProjectData.SetProjectError((Exception) ex1);
      ConstraintException ex2 = ex1;
      this.ShowExceptionOnUIThread((DataSet) dsPremiums, (Exception) ex2);
      ProjectData.ClearProjectError();
    }
    if (!this.IsDisposed && !this.Disposing && !MDIControls.Instance.MDIParent.IsDisposed && !MDIControls.Instance.MDIParent.Disposing)
      MDIControls.Instance.MDIParent.Invoke((Delegate) new PolicyDetail_Premiums.ThreadedFillCompleteHandler(this.ThreadedFillComplete), (object) dsPremiums, (object) dataTable);
    if (!SystemSettings.KeyExists("ShowCurrencySymbolforQuoteOptions") || !SystemSettings.GetBoolSetting("ShowCurrencySymbolforQuoteOptions"))
      return;
    EmbeddableEditorBase embeddableEditorBase = (EmbeddableEditorBase) new EditorWithMask((EmbeddableEditorOwnerBase) new DefaultEditorOwner(new DefaultEditorOwnerSettings()
    {
      FormatProvider = (IFormatProvider) this._cultureInfo,
      Format = "C",
      DataType = typeof (Decimal),
      MaskDataMode = (MaskMode) 0,
      MaskDisplayMode = (MaskMode) 3
    }));
    if (((UltraGridBase) this.dgOptions).DisplayLayout != null && ((KeyedSubObjectsCollectionBase) ((UltraGridBase) this.dgOptions).DisplayLayout.Bands).Exists("LinesOptionstblQuoteOptions"))
    {
      UltraGridBand band = ((UltraGridBase) this.dgOptions).DisplayLayout.Bands["LinesOptionstblQuoteOptions"];
      if (((KeyedSubObjectsCollectionBase) band.Columns).Exists("Premium"))
      {
        band.Columns["premium"].Editor = embeddableEditorBase;
        band.Columns["premium"].Style = (ColumnStyle) 17;
      }
      if (((KeyedSubObjectsCollectionBase) band.Columns).Exists("Fees"))
      {
        band.Columns["Fees"].Editor = embeddableEditorBase;
        band.Columns["Fees"].Style = (ColumnStyle) 17;
      }
    }
    if (((UltraGridBase) this.dgOptions).DisplayLayout == null || !((KeyedSubObjectsCollectionBase) ((UltraGridBase) this.dgOptions).DisplayLayout.Bands).Exists("tblQuoteOptionsviewOptionPremiums1"))
      return;
    UltraGridBand band1 = ((UltraGridBase) this.dgOptions).DisplayLayout.Bands["tblQuoteOptionsviewOptionPremiums1"];
    if (!((KeyedSubObjectsCollectionBase) band1.Columns).Exists("Premium"))
      return;
    band1.Columns["Premium"].Editor = embeddableEditorBase;
    band1.Columns["Premium"].Style = (ColumnStyle) 17;
  }

  private void ShowExceptionOnUIThread(DataSet dsPremiums, Exception ex)
  {
    if (MDIControls.Instance.MDIParent.InvokeRequired)
      MDIControls.Instance.MDIParent.Invoke((Delegate) new PolicyDetail_Premiums.ShowExceptionOnUIThreadHandler(this.ShowExceptionOnUIThread), (object) dsPremiums, (object) ex);
    else
      ErrorHandler.HandleError(ex);
  }

  private void FillTotalPolicy()
  {
    dsPolicyDetail_Premiums policyDetailPremiums = new dsPolicyDetail_Premiums();
    DataTable dataTable = (DataTable) null;
    using (DbConnection dbConnection = DefaultDatabase.CreateDbConnection())
    {
      using (DbDataAdapter dataAdapter = DefaultDatabase.CreateDataAdapter("dbo.spPolicyDetail_Premiums", dbConnection))
      {
        DbCommand selectCommand = dataAdapter.SelectCommand;
        selectCommand.CommandType = CommandType.StoredProcedure;
        DbParameterCollectionExtensions.DerivedAdd(selectCommand.Parameters, "@ControlNo", SqlDbType.Int, 4);
        DbParameterCollectionExtensions.DerivedAdd(selectCommand.Parameters, "@QuoteGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/);
        selectCommand.Parameters[0].Value = (object) this._quote.ControlNo;
        selectCommand.Parameters[1].Value = (object) this._quote.QuoteGuid;
        DataTableMappingCollection tableMappings = dataAdapter.TableMappings;
        tableMappings.Clear();
        tableMappings.Add("Table", this.ds.AllLinesOptions.TableName);
        tableMappings.Add("Table1", this.ds.BoundOptions.TableName);
        DefaultDatabase.DataAdapterFill(dataAdapter, (DataSet) policyDetailPremiums);
        dataTable = DefaultDatabase.ExecuteDataTable("dbo.GetFeeRestrictionsPerUser", new object[6]
        {
          (object) "@WholePolicy",
          (object) true,
          (object) "@QuoteGuid",
          (object) this._quoteGuid,
          (object) "@UserGuid",
          (object) this._currentUserGuid
        });
      }
    }
    if (this.IsDisposed || this.Disposing)
      return;
    if (MDIControls.Instance.MDIParent.IsDisposed)
      return;
    try
    {
      MDIControls.Instance.MDIParent.Invoke((Delegate) new PolicyDetail_Premiums.ThreadedFillCompleteHandler(this.ThreadedFillComplete), (object) policyDetailPremiums, (object) dataTable);
    }
    catch (ObjectDisposedException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      ProjectData.ClearProjectError();
    }
  }

  private void ThreadedFillComplete(dsPolicyDetail_Premiums dsPremiums, DataTable feeTable)
  {
    try
    {
      frmPolicyDetail policyDetailForm = this.PolicyDetailForm;
      if (policyDetailForm != null && policyDetailForm.Quote.QuoteGuid.Equals(this._quoteGuid))
        policyDetailForm.SetupMenus();
      this._dsPremiums = dsPremiums;
      MemoryStream memoryStream = new MemoryStream();
      UltraGrid ultraGrid;
      DataTable dataTable;
      if (this._style == PolicyDetail_Premiums.Style.ThisVersion)
      {
        ultraGrid = this.dgOptions;
        dataTable = (DataTable) dsPremiums.LinesOptions;
        this._dsCurrentVersionPremiums = dsPremiums;
        this._hasZeroPremiumZeroFeesOnCurrentVersion = this.ZeroPremiumZeroFees();
      }
      else
      {
        ultraGrid = this.dgTotalPolicy;
        dataTable = (DataTable) dsPremiums.AllLinesOptions;
      }
      ((UltraGridBase) ultraGrid).DisplayLayout.Save((Stream) memoryStream);
      ((UltraGridBase) ultraGrid).DataMember = string.Empty;
      ((UltraGridBase) ultraGrid).DataSource = (object) dataTable;
      memoryStream.Position = 0L;
      ((UltraGridBase) ultraGrid).DisplayLayout.Load((Stream) memoryStream);
      ((UltraGridBase) ultraGrid).DisplayLayout.ScrollBarLook.ViewStyle = (ScrollBarViewStyle) 3;
      if (!this._collapseZeroPremiumRows)
        ((UltraGridBase) ultraGrid).Rows.ExpandAll(true);
      ((UltraGridBase) this.dgOptions).DisplayLayout.Bands[1].Columns["btnOptionDetail"].Editor = (EmbeddableEditorBase) this._hlkOptions;
      ((UltraGridBase) this.dgOptions).DisplayLayout.Bands[1].Columns["InstallmentSetup"].Editor = (EmbeddableEditorBase) this._hlkInstallmentBilling;
      this.lnkViewSummary.Visible = ((UltraGridBase) this.dgOptions).Rows.Count > 0;
      // ISSUE: reference to a compiler-generated field
      PolicyDetail_Premiums.PremiumsControlLoadedEventHandler controlLoadedEvent = this.PremiumsControlLoadedEvent;
      if (controlLoadedEvent != null)
        controlLoadedEvent((object) this, new EventArgs());
      try
      {
        foreach (DataRow tblQuoteOption in (TypedTableBase<dsPolicyDetail_Premiums.tblQuoteOptionsRow>) this._dsPremiums.tblQuoteOptions)
          tblQuoteOption["CurrencyCode"] = (object) this._culturenameOnQuote;
      }
      finally
      {
        IEnumerator<dsPolicyDetail_Premiums.tblQuoteOptionsRow> enumerator;
        enumerator?.Dispose();
      }
      try
      {
        foreach (DataRow viewOptionPremium in (TypedTableBase<dsPolicyDetail_Premiums.viewOptionPremiumsRow>) this._dsPremiums.viewOptionPremiums)
          viewOptionPremium["CurrencyCode"] = (object) this._culturenameOnQuote;
      }
      finally
      {
        IEnumerator<dsPolicyDetail_Premiums.viewOptionPremiumsRow> enumerator;
        enumerator?.Dispose();
      }
      if (feeTable == null)
        return;
      if (feeTable.Rows.Count <= 0)
        return;
      try
      {
        foreach (UltraGridRow ultraGridRow in ((UltraGridBase) this.dgOptions).Rows.GetRowEnumerator((GridRowType) 1, ((UltraGridBase) this.dgOptions).DisplayLayout.Bands[2], (UltraGridBand) null))
        {
          if (feeTable.Select($"ChargeName='{ultraGridRow.Cells["ChargeName"].Value.ToString()}'").Length > 0)
          {
            ultraGridRow.Hidden = true;
            if (ultraGridRow.ParentRow != null)
              ultraGridRow.ParentRow.Cells["Fees"].Value = (object) Decimal.Subtract(Conversions.ToDecimal(ultraGridRow.ParentRow.Cells["Fees"].Value), Conversions.ToDecimal(ultraGridRow.Cells["Premium"].Value));
          }
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
    }
    catch (NullReferenceException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      ProjectData.ClearProjectError();
    }
    catch (ObjectDisposedException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      ProjectData.ClearProjectError();
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      ProjectData.ClearProjectError();
    }
  }

  private void lnkThisTransaction_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    this.SetControlStyle(PolicyDetail_Premiums.Style.ThisVersion);
  }

  private void lnkAllTransactions_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    this.SetControlStyle(PolicyDetail_Premiums.Style.TotalPolicy);
  }

  private void ColorNegativeValuesInGrid(object sender, InitializeRowEventArgs e)
  {
    if (e.Row.Band.Index == 1)
    {
      if (Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(e.Row.Cells["Premium"].Value)) && Decimal.Compare(Conversions.ToDecimal(e.Row.Cells["Premium"].Value), 0M) < 0)
        e.Row.Cells["Premium"].Appearance.ForeColor = Color.Red;
      if (((KeyedSubObjectsCollectionBase) e.Row.Band.Columns).Exists("Fees") && Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(e.Row.Cells["Fees"].Value)) && Decimal.Compare(Conversions.ToDecimal(e.Row.Cells["Fees"].Value), 0M) < 0)
        e.Row.Cells["Fees"].Appearance.ForeColor = Color.Red;
    }
    else if (e.Row.Band.Index == 2 && Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(e.Row.Cells["Premium"].Value)) && Decimal.Compare(Conversions.ToDecimal(e.Row.Cells["Premium"].Value), 0M) < 0)
      e.Row.Cells["Premium"].Appearance.ForeColor = Color.Red;
    this.CollapseZeroPremiumRows(RuntimeHelpers.GetObjectValue(sender), e);
  }

  internal void BindUnbindOption(bool bind, Guid quoteOptionGuid)
  {
    this.BindUnbindOption(bind, quoteOptionGuid, (CellEventArgs) null);
  }

  protected virtual void BindUnbindOption(bool bind, Guid quoteOptionGuid, CellEventArgs e)
  {
    try
    {
      Cursor.Current = MgaCursors.WaitCursor;
      DefaultDatabase.ExecuteNonQuery(CommandType.Text, "UPDATE dbo.tblQuoteOptions SET Bound=@B WHERE QuoteOptionGuid=@Q", new object[4]
      {
        (object) "@B",
        (object) bind,
        (object) "@Q",
        (object) quoteOptionGuid
      });
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      Exception exception = ex;
      e?.Cell.CancelUpdate();
      Cursor.Current = MgaCursors.Default;
      ErrorHandler.HandleError(exception);
      ProjectData.ClearProjectError();
    }
    finally
    {
      Cursor.Current = MgaCursors.Default;
    }
  }

  protected virtual void QuoteStatusChanged(bool quoted, Guid quoteGuid, Decimal totalPremium)
  {
  }

  protected virtual bool OtherClientQuoteStatus() => false;

  private void lnkViewSummary_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    if (this._dsPremiums == null || this.dgOptions == null || this.dgTotalPolicy == null || this._quote == null)
      return;
    Decimal totalPremium;
    Decimal boundPremium;
    Decimal totalFees;
    Decimal grandTotalFees;
    if (this._style == PolicyDetail_Premiums.Style.ThisVersion)
    {
      totalPremium = Utility.IsNull<Decimal>(RuntimeHelpers.GetObjectValue(this._dsPremiums.tblQuoteOptions.Compute("SUM(Premium)", "")), 0.0M);
      boundPremium = Utility.IsNull<Decimal>(RuntimeHelpers.GetObjectValue(this._dsPremiums.tblQuoteOptions.Compute("SUM(Premium)", "Bound=1")), 0.0M);
      totalFees = Utility.IsNull<Decimal>(RuntimeHelpers.GetObjectValue(this._dsPremiums.tblQuoteOptions.Compute("SUM(Fees)", "Bound=1")), 0.0M);
      grandTotalFees = Utility.IsNull<Decimal>(RuntimeHelpers.GetObjectValue(this._dsPremiums.tblQuoteOptions.Compute("SUM(Fees)", "")), 0.0M);
    }
    else
    {
      totalPremium = Utility.IsNull<Decimal>(RuntimeHelpers.GetObjectValue(this._dsPremiums.BoundOptions.Compute("SUM(Premium)", "")), 0.0M);
      boundPremium = 0M;
      totalFees = 0M;
      grandTotalFees = 0M;
    }
    frmViewSummary frmViewSummary = new frmViewSummary((int) this._style, this._dsPremiums, RuntimeHelpers.GetObjectValue(((UltraGridBase) this.dgOptions).DataSource), RuntimeHelpers.GetObjectValue(((UltraGridBase) this.dgTotalPolicy).DataSource), this._quote.ControlNo, totalPremium, totalFees, boundPremium, grandTotalFees);
    try
    {
      frmViewSummary.ShowInTaskbar = false;
      int num = (int) frmViewSummary.ShowDialog();
    }
    finally
    {
      frmViewSummary.Dispose();
    }
  }

  private void CollapseZeroPremiumRows(object sender, InitializeRowEventArgs e)
  {
    if (!this._collapseZeroPremiumRows)
      return;
    if (e.Row.Band.Index == 0)
    {
      e.Row.Expanded = true;
    }
    else
    {
      if (e.Row.Band.Index != 1)
        return;
      if (Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(e.Row.Cells["Premium"].Value)) && Decimal.Compare((Decimal) e.Row.Cells["Premium"].Value, 0M) != 0)
        e.Row.Expanded = true;
      else if (e.Row.HasParent())
        e.Row.ParentRow.Expanded = false;
      else
        e.Row.Expanded = false;
    }
  }

  private void LnkSelectAllBind_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    foreach (UltraGridRow row in ((UltraGridBase) this.dgOptions).Rows)
    {
      UltraGridCell cell = row.ChildBands[0].Rows[0].Cells["Bound"];
      if (!Conversions.ToBoolean(cell.Value))
      {
        cell.Value = (object) true;
        this.CellChangeHelper((object) this.dgOptions, new CellEventArgs(cell));
      }
    }
  }

  private void LnkSelectAllQuote_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    foreach (UltraGridRow row in ((UltraGridBase) this.dgOptions).Rows)
    {
      UltraGridCell cell = row.ChildBands[0].Rows[0].Cells["Quote"];
      if (!Conversions.ToBoolean(cell.Value))
      {
        cell.Value = (object) true;
        this.CellChangeHelper((object) this.dgOptions, new CellEventArgs(cell));
      }
    }
  }

  private void CellChangeHelper(object sender, CellEventArgs e)
  {
    this._quote = new Quote(this._quoteGuid);
    if (this._quote.IsBound)
    {
      e.Cell.CancelUpdate();
    }
    else
    {
      Guid quoteOptionGuid = (Guid) e.Cell.Row.Cells["QuoteOptionGuid"].Value;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(e.Cell.Column.Key, "Bound", false) == 0)
      {
        Guid guid = (Guid) e.Cell.Row.Cells["LineGuid"].Value;
        if (this._quote.IsMultiCompanyPolicy)
        {
          int num = (int) e.Cell.Row.Cells["companyLocationID"].Value;
          DefaultDatabase.ExecuteNonQuery(CommandType.Text, "UPDATE dbo.tblQuoteOptions SET Bound=0 WHERE QuoteGuid=@QuoteGuid AND LineGuid=@LineGuid AND companyLocationID=@companyLocationID", new object[6]
          {
            (object) "@QuoteGuid",
            (object) this._quoteGuid,
            (object) "@LineGuid",
            (object) guid,
            (object) "@companyLocationID",
            (object) num
          });
        }
        else
          DefaultDatabase.ExecuteNonQuery(CommandType.Text, "UPDATE dbo.tblQuoteOptions SET Bound=0 WHERE QuoteGuid=@QuoteGuid AND LineGuid=@LineGuid", new object[4]
          {
            (object) "@QuoteGuid",
            (object) this._quoteGuid,
            (object) "@LineGuid",
            (object) guid
          });
        int num1 = (int) e.Cell.Row.Cells["companyLocationID"].Value;
        DataRow[] dataRowArray1 = this._dsPremiums.tblQuoteOptions.Select($"LineGuid='{guid.ToString()}' and companyLocationID='{Conversions.ToString(num1)}'");
        if (dataRowArray1.Length > 0)
        {
          string lineName = ((dsPolicyDetail_Premiums.tblQuoteOptionsRow) dataRowArray1[0]).LinesOptionsRowParent.LineName;
          CurrentUser.Instance.LogAction($"Bind sets to: {e.Cell.Text} - Line: {lineName}", this._quoteGuid);
        }
        DataRow[] dataRowArray2 = this.ds.tblQuoteOptions.Select($"LineGuid='{guid.ToString()}'");
        int index = 0;
        while (index < dataRowArray2.Length)
        {
          ((dsPolicyDetail_Premiums.tblQuoteOptionsRow) dataRowArray2[index]).Bound = false;
          checked { ++index; }
        }
        this.BindUnbindOption(Conversions.ToBoolean(e.Cell.Text), quoteOptionGuid, e);
        if (!SystemSettings.GetSetting<bool>("CollapseAllOnBind", false))
          return;
        ((UltraGridBase) sender).Rows.CollapseAll(true);
      }
      else
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(e.Cell.Column.Key, "Quote", false) != 0)
          return;
        bool boolean = Conversions.ToBoolean(e.Cell.Text);
        if (this._quote.QuoteStatus == 1 || this._quote.QuoteStatus == 2 || this.OtherClientQuoteStatus())
        {
          DefaultDatabase.ExecuteNonQuery(CommandType.Text, "UPDATE dbo.tblQuoteOptions SET Quote=@Quote WHERE QuoteOptionGuid=@QuoteOptionGuid", new object[4]
          {
            (object) "@QuoteOptionGuid",
            (object) quoteOptionGuid,
            (object) "@Quote",
            (object) boolean
          });
          this.UpdateQuoteStatus(boolean);
        }
        else
          e.Cell.CancelUpdate();
      }
    }
  }

  public void ZeroPremFeeRowsDisplay(bool hideZeroPremiumRow)
  {
    this.LineGuidsToHide.Clear();
    foreach (UltraGridRow row1 in ((UltraGridBase) this.dgOptions).Rows)
    {
      if (hideZeroPremiumRow)
      {
        UltraGridChildBand childBand = row1.ChildBands["LinesOptionstblQuoteOptions"];
        if (childBand != null)
        {
          bool flag = true;
          foreach (UltraGridRow row2 in childBand.Rows)
          {
            if (Decimal.Compare(Conversions.ToDecimal(row2.Cells["Premium"].Value), 0M) != 0 || Decimal.Compare(Conversions.ToDecimal(row2.Cells["Fees"].Value), 0M) != 0)
            {
              flag = false;
              break;
            }
          }
          if (flag)
          {
            List<(Guid, int)> lineGuidsToHide1 = this.LineGuidsToHide;
            object obj1 = row1.Cells["LineGuid"].Value;
            (Guid, int) valueTuple1 = (obj1 != null ? (Guid) obj1 : new Guid(), (int) row1.Cells["CompanyLocationID"].Value);
            if (!lineGuidsToHide1.Contains(valueTuple1))
            {
              List<(Guid, int)> lineGuidsToHide2 = this.LineGuidsToHide;
              object obj2 = row1.Cells["LineGuid"].Value;
              (Guid, int) valueTuple2 = (obj2 != null ? (Guid) obj2 : new Guid(), (int) row1.Cells["CompanyLocationID"].Value);
              lineGuidsToHide2.Add(valueTuple2);
            }
          }
          row1.Hidden = flag;
        }
      }
      else
        row1.Hidden = false;
    }
  }

  private void UpdateOtherInstallmentBillingPlans(
    Guid quoteOptionGuid,
    InstallmentBillingPay priorInstallBillOpt)
  {
    if (!SystemSettings.GetSetting<bool>("InstallmentBillingOptions.UpdateOtherPayPlan", false))
      return;
    InstallmentBillingPay other = new InstallmentBillingPay(quoteOptionGuid);
    if (!priorInstallBillOpt.HasChanges(other))
      return;
    List<InstallmentBillingPay> installmentBillingOptions = other.GetOtherInstallmentBillingOptions;
    if (installmentBillingOptions.Count <= 0 || MessageBox.Show($"Installment billing info changed.{Environment.NewLine}{Environment.NewLine}Update other options with this information?", "Update Other Options?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
      return;
    InstallmentBillingPay.UpdateOtherInstallmentBilling(quoteOptionGuid, installmentBillingOptions);
  }

  internal enum Style
  {
    ThisVersion,
    TotalPolicy,
  }

  public delegate void PremiumsControlLoadedEventHandler(object sender, EventArgs e);

  private delegate void ShowExceptionOnUIThreadHandler(DataSet ds, Exception ex);

  private delegate void ThreadedFillCompleteHandler(dsPolicyDetail_Premiums ds, DataTable feeTable);
}
