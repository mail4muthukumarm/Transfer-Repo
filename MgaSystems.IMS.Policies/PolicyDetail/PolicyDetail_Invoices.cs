// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.PolicyDetail.PolicyDetail_Invoices
// Assembly: MgaSystems.IMS.Policies, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 2FF2C709-F7BF-41DA-82BD-FF6319CA235D
// Assembly location: C:\Users\muthu\Downloads\MgaSystems.IMS.Policies.dll

using Infragistics.Shared;
using Infragistics.Win;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using Infragistics.Win.UltraWinToolbars;
using MGASystems.BusinessObjects;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.IMS.Policies.BindPolicy;
using MGASystems.IMS.Reporting;
using MGASystems.InfragisticsExtensions.Editors;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Policies.PolicyDetail;

[PolicyDetail_Plugin("Invoices", "Invoices")]
public class PolicyDetail_Invoices : PolicyDetail_Plugin
{
  private IContainer components;
  protected dsInvoices ds;
  private readonly Guid _quoteGuid;
  private HyperlinkEditor _hlkInvoices;
  private HyperlinkEditor _hlkInvoiceDetail;
  private HyperlinkEditor _hlkInvoiceEmail;
  private CultureInfo _cultureInfo;

  protected override void Dispose(bool disposing)
  {
    if (disposing)
    {
      if (this.components != null)
        this.components.Dispose();
      if (this._hlkInvoices != null)
      {
        this._hlkInvoices.HyperLinkOpening -= new CancelEventHandler(this.hlkInvoices_HyperLinkOpening);
        ((DisposableObject) this._hlkInvoices).Dispose();
      }
      if (this._hlkInvoiceDetail != null)
      {
        this._hlkInvoices.HyperLinkOpening -= new CancelEventHandler(this.hlkInvoiceDetail_HyperLinkOpening);
        ((DisposableObject) this._hlkInvoiceDetail).Dispose();
      }
    }
    base.Dispose(disposing);
  }

  protected virtual UltraGrid ugInvoices
  {
    get => this._ugInvoices;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      InitializeRowEventHandler initializeRowEventHandler = new InitializeRowEventHandler(this.ugInvoices_InitializeRow);
      InitializeLayoutEventHandler layoutEventHandler = new InitializeLayoutEventHandler(this.ugInvoices_InitializeLayout);
      UltraGrid ugInvoices1 = this._ugInvoices;
      if (ugInvoices1 != null)
      {
        ugInvoices1.InitializeRow -= initializeRowEventHandler;
        ugInvoices1.InitializeLayout -= layoutEventHandler;
      }
      this._ugInvoices = value;
      UltraGrid ugInvoices2 = this._ugInvoices;
      if (ugInvoices2 == null)
        return;
      ugInvoices2.InitializeRow += initializeRowEventHandler;
      ugInvoices2.InitializeLayout += layoutEventHandler;
    }
  }

  [field: AccessedThroughProperty("_PolicyDetail_Invoices_Toolbars_Dock_Area_Top")]
  private virtual UltraToolbarsDockArea _PolicyDetail_Invoices_Toolbars_Dock_Area_Top { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("_PolicyDetail_Invoices_Toolbars_Dock_Area_Bottom")]
  private virtual UltraToolbarsDockArea _PolicyDetail_Invoices_Toolbars_Dock_Area_Bottom { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("_PolicyDetail_Invoices_Toolbars_Dock_Area_Left")]
  private virtual UltraToolbarsDockArea _PolicyDetail_Invoices_Toolbars_Dock_Area_Left { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("_PolicyDetail_Invoices_Toolbars_Dock_Area_Right")]
  private virtual UltraToolbarsDockArea _PolicyDetail_Invoices_Toolbars_Dock_Area_Right { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    Appearance appearance1 = new Appearance();
    UltraGridBand ultraGridBand = new UltraGridBand("Invoices", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("InvoiceNum");
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("InvoiceDate");
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("DueDate");
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("Amount");
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("OfficeInvoiceNum");
    Appearance appearance10 = new Appearance();
    Appearance appearance11 = new Appearance();
    Appearance appearance12 = new Appearance();
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("Failed");
    Appearance appearance13 = new Appearance();
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("User");
    Appearance appearance14 = new Appearance();
    Appearance appearance15 = new Appearance();
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("QuoteID");
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("OfficeID");
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("Detail");
    Appearance appearance16 = new Appearance();
    UltraGridColumn ultraGridColumn11 = new UltraGridColumn("GrossPremium");
    Appearance appearance17 = new Appearance();
    Appearance appearance18 = new Appearance();
    UltraGridColumn ultraGridColumn12 = new UltraGridColumn("Email");
    Appearance appearance19 = new Appearance();
    UltraGridColumn ultraGridColumn13 = new UltraGridColumn("Remitter");
    Appearance appearance20 = new Appearance();
    Appearance appearance21 = new Appearance();
    UltraGridColumn ultraGridColumn14 = new UltraGridColumn("Payee");
    Appearance appearance22 = new Appearance();
    UltraGridColumn ultraGridColumn15 = new UltraGridColumn("InvoiceTypeID");
    Appearance appearance23 = new Appearance();
    Appearance appearance24 = new Appearance();
    UltraGridColumn ultraGridColumn16 = new UltraGridColumn("EndorsementComment");
    Appearance appearance25 = new Appearance();
    Appearance appearance26 = new Appearance();
    SummarySettings summarySettings1 = new SummarySettings("", (SummaryType) 1, (string) null, "Amount", 3, true, "Invoices", 0, (SummaryPosition) 3, (string) null, -1, false);
    Appearance appearance27 = new Appearance();
    SummarySettings summarySettings2 = new SummarySettings("", (SummaryType) 1, (string) null, "GrossPremium", 10, true, "Invoices", 0, (SummaryPosition) 3, (string) null, -1, false);
    Appearance appearance28 = new Appearance();
    Appearance appearance29 = new Appearance();
    Appearance appearance30 = new Appearance();
    Appearance appearance31 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    this.ds = new dsInvoices();
    this._PolicyDetail_Invoices_Toolbars_Dock_Area_Top = new UltraToolbarsDockArea();
    this._PolicyDetail_Invoices_Toolbars_Dock_Area_Bottom = new UltraToolbarsDockArea();
    this._PolicyDetail_Invoices_Toolbars_Dock_Area_Left = new UltraToolbarsDockArea();
    this._PolicyDetail_Invoices_Toolbars_Dock_Area_Right = new UltraToolbarsDockArea();
    this.ugInvoices = new UltraGrid();
    this.ds.BeginInit();
    ((ISupportInitialize) this.ugInvoices).BeginInit();
    this.SuspendLayout();
    this.ds.DataSetName = "dsInvoices";
    this.ds.Locale = new CultureInfo("en-US");
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    ((Control) this._PolicyDetail_Invoices_Toolbars_Dock_Area_Top).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._PolicyDetail_Invoices_Toolbars_Dock_Area_Top).BackColor = SystemColors.Control;
    this._PolicyDetail_Invoices_Toolbars_Dock_Area_Top.DockedPosition = (DockedPosition) 0;
    ((Control) this._PolicyDetail_Invoices_Toolbars_Dock_Area_Top).ForeColor = SystemColors.ControlText;
    ((Control) this._PolicyDetail_Invoices_Toolbars_Dock_Area_Top).Location = new Point(0, 0);
    ((Control) this._PolicyDetail_Invoices_Toolbars_Dock_Area_Top).Name = "_PolicyDetail_Invoices_Toolbars_Dock_Area_Top";
    ((Control) this._PolicyDetail_Invoices_Toolbars_Dock_Area_Top).Size = new Size(728, 0);
    ((Control) this._PolicyDetail_Invoices_Toolbars_Dock_Area_Bottom).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._PolicyDetail_Invoices_Toolbars_Dock_Area_Bottom).BackColor = SystemColors.Control;
    this._PolicyDetail_Invoices_Toolbars_Dock_Area_Bottom.DockedPosition = (DockedPosition) 1;
    ((Control) this._PolicyDetail_Invoices_Toolbars_Dock_Area_Bottom).ForeColor = SystemColors.ControlText;
    ((Control) this._PolicyDetail_Invoices_Toolbars_Dock_Area_Bottom).Location = new Point(0, 288);
    ((Control) this._PolicyDetail_Invoices_Toolbars_Dock_Area_Bottom).Name = "_PolicyDetail_Invoices_Toolbars_Dock_Area_Bottom";
    ((Control) this._PolicyDetail_Invoices_Toolbars_Dock_Area_Bottom).Size = new Size(728, 0);
    ((Control) this._PolicyDetail_Invoices_Toolbars_Dock_Area_Left).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._PolicyDetail_Invoices_Toolbars_Dock_Area_Left).BackColor = SystemColors.Control;
    this._PolicyDetail_Invoices_Toolbars_Dock_Area_Left.DockedPosition = (DockedPosition) 2;
    ((Control) this._PolicyDetail_Invoices_Toolbars_Dock_Area_Left).ForeColor = SystemColors.ControlText;
    ((Control) this._PolicyDetail_Invoices_Toolbars_Dock_Area_Left).Location = new Point(0, 0);
    ((Control) this._PolicyDetail_Invoices_Toolbars_Dock_Area_Left).Name = "_PolicyDetail_Invoices_Toolbars_Dock_Area_Left";
    ((Control) this._PolicyDetail_Invoices_Toolbars_Dock_Area_Left).Size = new Size(0, 288);
    ((Control) this._PolicyDetail_Invoices_Toolbars_Dock_Area_Right).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._PolicyDetail_Invoices_Toolbars_Dock_Area_Right).BackColor = SystemColors.Control;
    this._PolicyDetail_Invoices_Toolbars_Dock_Area_Right.DockedPosition = (DockedPosition) 3;
    ((Control) this._PolicyDetail_Invoices_Toolbars_Dock_Area_Right).ForeColor = SystemColors.ControlText;
    ((Control) this._PolicyDetail_Invoices_Toolbars_Dock_Area_Right).Location = new Point(728, 0);
    ((Control) this._PolicyDetail_Invoices_Toolbars_Dock_Area_Right).Name = "_PolicyDetail_Invoices_Toolbars_Dock_Area_Right";
    ((Control) this._PolicyDetail_Invoices_Toolbars_Dock_Area_Right).Size = new Size(0, 288);
    ((UltraGridBase) this.ugInvoices).DataSource = (object) this.ds.Invoices;
    appearance1.BackColor = Color.White;
    appearance1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.ugInvoices).DisplayLayout.Appearance = (AppearanceBase) appearance1;
    ((UltraGridBase) this.ugInvoices).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn1.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance2).TextHAlignAsString = "Left";
    ultraGridColumn1.CellAppearance = (AppearanceBase) appearance2;
    ((AppearanceBase) appearance3).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn1.Header).Appearance = (AppearanceBase) appearance3;
    ((HeaderBase) ultraGridColumn1.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn1.Width = 55;
    ultraGridColumn2.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn2.CellActivation = (Activation) 1;
    ((AppearanceBase) appearance4).TextHAlignAsString = "Left";
    ultraGridColumn2.CellAppearance = (AppearanceBase) appearance4;
    ultraGridColumn2.Format = "d";
    ((AppearanceBase) appearance5).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn2.Header).Appearance = (AppearanceBase) appearance5;
    ((HeaderBase) ultraGridColumn2.Header).Caption = "Billed";
    ((HeaderBase) ultraGridColumn2.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn2.Header.VisiblePosition = 5;
    ultraGridColumn2.Width = 56;
    ultraGridColumn3.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn3.CellActivation = (Activation) 1;
    ((AppearanceBase) appearance6).TextHAlignAsString = "Left";
    ultraGridColumn3.CellAppearance = (AppearanceBase) appearance6;
    ultraGridColumn3.Format = "d";
    ((AppearanceBase) appearance7).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn3.Header).Appearance = (AppearanceBase) appearance7;
    ((HeaderBase) ultraGridColumn3.Header).Caption = "Due";
    ((HeaderBase) ultraGridColumn3.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn3.Header.VisiblePosition = 6;
    ultraGridColumn3.Width = 51;
    ultraGridColumn4.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn4.CellActivation = (Activation) 1;
    ((AppearanceBase) appearance8).TextHAlignAsString = "Right";
    ultraGridColumn4.CellAppearance = (AppearanceBase) appearance8;
    ultraGridColumn4.Format = "c";
    ((AppearanceBase) appearance9).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn4.Header).Appearance = (AppearanceBase) appearance9;
    ((HeaderBase) ultraGridColumn4.Header).Caption = "Amount Billed";
    ((HeaderBase) ultraGridColumn4.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn4.Header.VisiblePosition = 3;
    ultraGridColumn4.Width = 72;
    ultraGridColumn5.AutoCompleteMode = (AutoCompleteMode) 2;
    appearance10.FontData.UnderlineAsString = "True";
    appearance10.ForeColor = Color.Blue;
    appearance10.ImageHAlign = (HAlign) 2;
    ((AppearanceBase) appearance10).TextHAlignAsString = "Left";
    appearance10.TextTrimming = (TextTrimming) 6;
    ultraGridColumn5.CellAppearance = (AppearanceBase) appearance10;
    ((AppearanceBase) appearance11).TextHAlignAsString = "Left";
    ultraGridColumn5.CellButtonAppearance = (AppearanceBase) appearance11;
    ((AppearanceBase) appearance12).TextHAlignAsString = "Center";
    ((HeaderBase) ultraGridColumn5.Header).Appearance = (AppearanceBase) appearance12;
    ((HeaderBase) ultraGridColumn5.Header).Caption = "Invoice #";
    ((HeaderBase) ultraGridColumn5.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn5.Header.VisiblePosition = 1;
    ultraGridColumn5.Width = 43;
    ultraGridColumn6.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn6.CellActivation = (Activation) 1;
    ((AppearanceBase) appearance13).TextHAlignAsString = "Center";
    ultraGridColumn6.CellAppearance = (AppearanceBase) appearance13;
    ((HeaderBase) ultraGridColumn6.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn6.Header.VisiblePosition = 7;
    ultraGridColumn6.Hidden = true;
    ultraGridColumn6.Width = 61;
    ultraGridColumn7.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn7.CellActivation = (Activation) 1;
    ((AppearanceBase) appearance14).TextHAlignAsString = "Left";
    ultraGridColumn7.CellAppearance = (AppearanceBase) appearance14;
    ((AppearanceBase) appearance15).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn7.Header).Appearance = (AppearanceBase) appearance15;
    ((HeaderBase) ultraGridColumn7.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn7.Header.VisiblePosition = 10;
    ultraGridColumn7.Width = 62;
    ultraGridColumn8.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn8.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn8.Header.VisiblePosition = 11;
    ultraGridColumn8.Hidden = true;
    ultraGridColumn9.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn9.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn9.Header.VisiblePosition = 12;
    ultraGridColumn9.Hidden = true;
    ultraGridColumn10.AutoCompleteMode = (AutoCompleteMode) 2;
    appearance16.FontData.UnderlineAsString = "True";
    appearance16.ForeColor = Color.Blue;
    ((AppearanceBase) appearance16).TextHAlignAsString = "Center";
    ultraGridColumn10.CellAppearance = (AppearanceBase) appearance16;
    ((HeaderBase) ultraGridColumn10.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn10.Header.VisiblePosition = 13;
    ultraGridColumn10.Width = 38;
    ultraGridColumn11.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance17).TextHAlignAsString = "Right";
    ultraGridColumn11.CellAppearance = (AppearanceBase) appearance17;
    ultraGridColumn11.Format = "c";
    ((AppearanceBase) appearance18).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn11.Header).Appearance = (AppearanceBase) appearance18;
    ((HeaderBase) ultraGridColumn11.Header).Caption = "Gross Prem.";
    ((HeaderBase) ultraGridColumn11.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn11.Header.VisiblePosition = 4;
    ultraGridColumn11.Width = 65;
    ultraGridColumn12.AutoCompleteMode = (AutoCompleteMode) 2;
    appearance19.FontData.UnderlineAsString = "True";
    appearance19.ForeColor = Color.Blue;
    ((AppearanceBase) appearance19).TextHAlignAsString = "Center";
    ultraGridColumn12.CellAppearance = (AppearanceBase) appearance19;
    ((HeaderBase) ultraGridColumn12.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn12.Header.VisiblePosition = 14;
    ultraGridColumn12.Width = 38;
    ultraGridColumn13.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance20).TextHAlignAsString = "Left";
    ultraGridColumn13.CellAppearance = (AppearanceBase) appearance20;
    ((AppearanceBase) appearance21).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn13.Header).Appearance = (AppearanceBase) appearance21;
    ((HeaderBase) ultraGridColumn13.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn13.Header.VisiblePosition = 8;
    ultraGridColumn13.Width = 73;
    ultraGridColumn14.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance22).TextHAlignAsString = "Center";
    ultraGridColumn14.CellAppearance = (AppearanceBase) appearance22;
    ((HeaderBase) ultraGridColumn14.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn14.Header.VisiblePosition = 9;
    ultraGridColumn14.Width = 47;
    ((AppearanceBase) appearance23).TextHAlignAsString = "Left";
    ultraGridColumn15.CellAppearance = (AppearanceBase) appearance23;
    ((AppearanceBase) appearance24).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn15.Header).Appearance = (AppearanceBase) appearance24;
    ((HeaderBase) ultraGridColumn15.Header).Caption = "Invoice Type";
    ((HeaderBase) ultraGridColumn15.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn15.Header.VisiblePosition = 2;
    ultraGridColumn15.Width = 69;
    ((AppearanceBase) appearance25).TextHAlignAsString = "Left";
    ultraGridColumn16.CellAppearance = (AppearanceBase) appearance25;
    ((AppearanceBase) appearance26).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn16.Header).Appearance = (AppearanceBase) appearance26;
    ((HeaderBase) ultraGridColumn16.Header).Caption = "Comment";
    ((HeaderBase) ultraGridColumn16.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn16.Header.VisiblePosition = 15;
    ultraGridColumn16.Width = 112 /*0x70*/;
    ultraGridBand.Columns.AddRange(new object[16 /*0x10*/]
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
      (object) ultraGridColumn14,
      (object) ultraGridColumn15,
      (object) ultraGridColumn16
    });
    ultraGridBand.Override.SummaryFooterCaptionVisible = (DefaultableBoolean) 2;
    appearance27.BackColor = Color.LightYellow;
    ((AppearanceBase) appearance27).TextHAlignAsString = "Right";
    summarySettings1.Appearance = (AppearanceBase) appearance27;
    summarySettings1.DisplayFormat = "{0:c}";
    appearance28.BackColor = Color.LightYellow;
    ((AppearanceBase) appearance28).TextHAlignAsString = "Right";
    summarySettings2.Appearance = (AppearanceBase) appearance28;
    summarySettings2.DisplayFormat = "{0:c}";
    ultraGridBand.Summaries.AddRange(new SummarySettings[2]
    {
      summarySettings1,
      summarySettings2
    });
    ultraGridBand.SummaryFooterCaption = "";
    ((UltraGridBase) this.ugInvoices).DisplayLayout.BandsSerializer.Add((object) ultraGridBand);
    ((UltraGridBase) this.ugInvoices).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.ugInvoices).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.ugInvoices).DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.ugInvoices).DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 1;
    appearance29.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    appearance29.ForeColor = Color.Black;
    ((UltraGridBase) this.ugInvoices).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance29;
    appearance30.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.ugInvoices).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance30;
    appearance31.BackColor = Color.White;
    appearance31.ForeColor = Color.Black;
    ((UltraGridBase) this.ugInvoices).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance31;
    ((UltraGridBase) this.ugInvoices).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    scrollBarLook.ViewStyle = (ScrollBarViewStyle) 3;
    ((UltraGridBase) this.ugInvoices).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((Control) this.ugInvoices).Dock = DockStyle.Fill;
    ((Control) this.ugInvoices).Font = new Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.ugInvoices).Location = new Point(0, 0);
    ((Control) this.ugInvoices).Name = "ugInvoices";
    ((Control) this.ugInvoices).Size = new Size(728, 288);
    ((Control) this.ugInvoices).TabIndex = 1;
    ((UltraControlBase) this.ugInvoices).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.ugInvoices).UseOsThemes = (DefaultableBoolean) 2;
    this.Controls.Add((Control) this._PolicyDetail_Invoices_Toolbars_Dock_Area_Top);
    this.Controls.Add((Control) this._PolicyDetail_Invoices_Toolbars_Dock_Area_Bottom);
    this.Controls.Add((Control) this._PolicyDetail_Invoices_Toolbars_Dock_Area_Left);
    this.Controls.Add((Control) this._PolicyDetail_Invoices_Toolbars_Dock_Area_Right);
    this.Controls.Add((Control) this.ugInvoices);
    this.Name = nameof (PolicyDetail_Invoices);
    this.Size = new Size(728, 288);
    this.ds.EndInit();
    ((ISupportInitialize) this.ugInvoices).EndInit();
    this.ResumeLayout(false);
  }

  internal PolicyDetail_Invoices()
  {
    this.Load += new EventHandler(this.PolicyDetail_Invoices_Load);
    this._hlkInvoices = new HyperlinkEditor();
    this._hlkInvoiceDetail = new HyperlinkEditor();
    this._hlkInvoiceEmail = new HyperlinkEditor();
    this.InitializeComponent();
  }

  public PolicyDetail_Invoices(Guid quoteGuid)
    : this()
  {
    this._quoteGuid = quoteGuid;
  }

  internal UltraGrid InvoicesGrid => this.ugInvoices;

  private void PolicyDetail_Invoices_Load(object sender, EventArgs e)
  {
    UltraGridBand band = ((UltraGridBase) this.ugInvoices).DisplayLayout.Bands[0];
    band.Columns["OfficeInvoiceNum"].Editor = (EmbeddableEditorBase) this._hlkInvoices;
    band.Columns["Detail"].Editor = (EmbeddableEditorBase) this._hlkInvoiceDetail;
    band.Columns["Email"].Editor = (EmbeddableEditorBase) this._hlkInvoiceEmail;
    this._hlkInvoices.HyperLinkOpening += new CancelEventHandler(this.hlkInvoices_HyperLinkOpening);
    this._hlkInvoiceDetail.HyperLinkOpening += new CancelEventHandler(this.hlkInvoiceDetail_HyperLinkOpening);
    this._hlkInvoiceEmail.HyperLinkOpening += new CancelEventHandler(this._hlkInvoiceEmail_HyperLinkOpening);
    if (this._quoteGuid.Equals(Guid.Empty))
      return;
    this._cultureInfo = frmPolicyDetail.CurrentCultureInfo;
  }

  public override void Fill() => ThreadPool.QueueUserWorkItem(new WaitCallback(this.FillThread));

  protected virtual string EmailSubjectLine(string policyNum, string insuredPolName)
  {
    return $"Policy #{policyNum} - {insuredPolName}";
  }

  protected virtual void InitializeInvoiceGridLayout()
  {
  }

  private void ugInvoices_InitializeRow(object sender, InitializeRowEventArgs e)
  {
    if ((double) e.Row.Cells["Amount"].Value < 0.0)
      e.Row.Cells["Amount"].Appearance.ForeColor = Color.Red;
    if ((double) e.Row.Cells["GrossPremium"].Value < 0.0)
      e.Row.Cells["GrossPremium"].Appearance.ForeColor = Color.Red;
    if (!Conversions.ToBoolean(e.Row.Cells["Failed"].Value))
      return;
    Appearance appearance = e.Row.Appearance;
    appearance.FontData.Strikeout = (DefaultableBoolean) 1;
    appearance.ForeColor = Color.Red;
    e.Row.Cells["OfficeInvoiceNum"].Appearance.FontData.Strikeout = (DefaultableBoolean) 2;
    e.Row.Cells["Detail"].Appearance.FontData.Strikeout = (DefaultableBoolean) 2;
  }

  private void FillThread(object state)
  {
    Quote quote = new Quote(this._quoteGuid);
    dsInvoices dsInvoices = new dsInvoices();
    DefaultDatabase.LoadDataSet((DataSet) dsInvoices, new string[1]
    {
      "Invoices"
    }, "dbo.PolicyDetailInvoices", new object[2]
    {
      (object) "@controlNo",
      (object) quote.ControlNo
    });
    dsInvoices.InvoicesDataTable invoices = dsInvoices.Invoices;
    if (MDIControls.Instance.MDIParent.IsDisposed || MDIControls.Instance.MDIParent.Disposing || !MDIControls.Instance.MDIParent.IsHandleCreated)
      return;
    MDIControls.Instance.MDIParent.Invoke((Delegate) new PolicyDetail_Invoices.FillThreadCompleteHandler(this.FillThreadComplete), (object) invoices);
  }

  protected virtual void FillThreadComplete(dsInvoices.InvoicesDataTable dt)
  {
    try
    {
      ((UltraGridBase) this.ugInvoices).DataMember = string.Empty;
      ((UltraGridBase) this.ugInvoices).DataSource = (object) dt;
      if (((UltraGridBase) this.ugInvoices).Rows.Count > 0)
      {
        UltraGridBand band = ((UltraGridBase) this.ugInvoices).DisplayLayout.Bands[0];
        band.Summaries.Clear();
        band.Summaries.Add((SummaryType) 5, (ICustomSummaryCalculator) new PolicyDetail_Invoices.InvoiceSummary(), band.Columns["Amount"], (SummaryPosition) 3, band.Columns["Amount"]);
        band.Summaries[0].DisplayFormat = "{0:c}";
        band.Summaries[0].Appearance.BackColor = Color.LightGoldenrodYellow;
        band.Override.SummaryValueAppearance.TextHAlign = (HAlign) 3;
        band.Override.SummaryFooterCaptionVisible = (DefaultableBoolean) 2;
        band.Summaries.Add((SummaryType) 5, (ICustomSummaryCalculator) new PolicyDetail_Invoices.GrossPremiumSummary(), band.Columns["GrossPremium"], (SummaryPosition) 3, band.Columns["GrossPremium"]);
        band.Summaries[1].DisplayFormat = "{0:c}";
        band.Summaries[1].Appearance.BackColor = Color.LightGoldenrodYellow;
        band.Override.SummaryValueAppearance.TextHAlign = (HAlign) 3;
        band.Override.SummaryFooterCaptionVisible = (DefaultableBoolean) 2;
      }
      if (this._cultureInfo != null && frmPolicyDetail.ImplementCurrencyDisplay)
      {
        ((UltraGridBase) this.ugInvoices).DisplayLayout.Bands[0].Columns["Amount"].FormatInfo = (IFormatProvider) this._cultureInfo;
        ((UltraGridBase) this.ugInvoices).DisplayLayout.Bands[0].Columns["GrossPremium"].FormatInfo = (IFormatProvider) this._cultureInfo;
      }
      ((UltraGridBase) this.ugInvoices).Rows.ExpandAll(true);
    }
    catch (NullReferenceException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      ProjectData.ClearProjectError();
    }
  }

  private void hlkInvoiceDetail_HyperLinkOpening(object sender, CancelEventArgs e)
  {
    e.Cancel = true;
    Cursor.Current = MgaCursors.WaitCursor;
    StringBuilder stringBuilder = new StringBuilder();
    int integer1 = Conversions.ToInteger(((UltraGridBase) this.ugInvoices).ActiveRow.Cells["InvoiceNum"].Value);
    DataTable dataTable = DefaultDatabase.ExecuteDataTable("dbo.GetInvoiceDetail", new object[2]
    {
      (object) "@invoiceNum",
      (object) integer1
    });
    try
    {
      foreach (DataRow row in dataTable.Rows)
      {
        foreach (UltraGridColumn column in ((UltraGridBase) this.ugInvoices).DisplayLayout.Bands[0].Columns)
        {
          if (!column.Hidden && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(column.Key, "Detail", false) != 0)
          {
            object objectValue = RuntimeHelpers.GetObjectValue(((UltraGridBase) this.ugInvoices).ActiveRow.Cells[column].Value);
            string str = !(objectValue is DateTime dateTime) ? (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(column.Key, "Amount", false) != 0 ? objectValue.ToString() : Strings.FormatCurrency(RuntimeHelpers.GetObjectValue(objectValue))) : dateTime.ToShortDateString();
            if (str.Length > 0)
              stringBuilder.Append($"{((HeaderBase) column.Header).Caption}: {str}\n");
          }
        }
        stringBuilder.Append($"Office: {row["Office"].ToString()}\n");
        int integer2 = Conversions.ToInteger(row["NumPayments"]);
        if (integer2 == 1)
          stringBuilder.Append("1 payment.\n");
        else
          stringBuilder.Append(integer2.ToString() + " payments.\n");
        if (row["DownpaymentBillingType"] != DBNull.Value)
          stringBuilder.Append($"Downpayment: {Strings.FormatCurrency(RuntimeHelpers.GetObjectValue(row["Downpayment"]), 2)}\nDownpayment Billing Type: {row["DownpaymentBillingType"].ToString()}\n");
        if (Conversions.ToBoolean(row["SingleInvoice"]))
          stringBuilder.Append("Billed as a single invoice.\n");
        if (row["OptionName"] != DBNull.Value)
          stringBuilder.Append($"Company Installment Setup: {row["OptionName"].ToString()}\n");
        if (row["DateIssued"] != DBNull.Value)
          stringBuilder.Append($"Printed Manually: {row["OptionName"].ToString()}\n");
        else
          stringBuilder.Append("Not Printed Manually\n");
        if (Conversions.ToBoolean(row["IssuedViaAutomation"]))
          stringBuilder.Append("Printed via Automation\n");
        else
          stringBuilder.Append("Not Printed via Automation\n");
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    DataRow dataRow = DefaultDatabase.ExecuteDataRow(CommandType.Text, "SELECT Q.EndorsementEffective,  ISNULL(lstQuoteStatusReasons.Reason, @E) + ISNULL(@D + Q.EndorsementComment, @E) AS Reason FROM tblQuotes Q INNER JOIN lstQuoteStatusReasons ON Q.QuoteStatusReasonID = dbo.lstQuoteStatusReasons.ID INNER JOIN tblFin_Invoices I ON I.QuoteID = Q.QuoteID WHERE I.InvoiceNum=@I", new object[6]
    {
      (object) "@I",
      (object) integer1,
      (object) "@E",
      (object) "",
      (object) "@D",
      (object) " - "
    });
    if (dataRow != null)
    {
      string Left = string.Empty;
      if (dataRow["Reason"] != DBNull.Value)
        Left = "End. Reason - " + (string) dataRow["Reason"];
      if (dataRow["EndorsementEffective"] != DBNull.Value)
        Left = $"{Left}, Effective - {Conversions.ToString((DateTime) dataRow["EndorsementEffective"])}";
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, string.Empty, false) != 0)
        stringBuilder.Append(Left);
    }
    using (FormSettings.ShowFormDialog(typeof (frmGenericInfo), new object[2]
    {
      (object) "Invoice Information:",
      (object) stringBuilder
    }))
      ;
    Cursor.Current = MgaCursors.Default;
  }

  private void hlkInvoices_HyperLinkOpening(object sender, CancelEventArgs e)
  {
    e.Cancel = true;
    int num = (int) ((UltraGridBase) this.ugInvoices).ActiveRow.Cells["InvoiceNum"].Value;
    MDIControls.Instance.StatusBarText = $"Showing invoice #{num.ToString()}...";
    bool flag = SystemSettings.KeyExists("PrintBrokerCopyInvoiceOnly") && SystemSettings.GetBoolSetting("PrintBrokerCopyInvoiceOnly");
    try
    {
      ArrayList arrayList = new ArrayList();
      if (!flag)
      {
        InvoiceItem[] invoices = new InvoiceItem[2]
        {
          new InvoiceItem(num, arrayList),
          null
        };
        arrayList.AddRange((ICollection) new object[2]
        {
          (object) "MGACopy",
          (object) true
        });
        invoices[1] = new InvoiceItem(num, arrayList);
        this.ShowInvoices(invoices);
      }
      else
        this.ShowInvoices(new InvoiceItem[1]
        {
          new InvoiceItem(num, arrayList)
        });
    }
    finally
    {
      MDIControls.Instance.StatusBarText = string.Empty;
    }
  }

  protected virtual void ShowInvoices(InvoiceItem[] invoices)
  {
    new InvoiceGeneration().ShowInvoices(invoices, true);
  }

  private void _hlkInvoiceEmail_HyperLinkOpening(object sender, CancelEventArgs e)
  {
    e.Cancel = true;
    Cursor.Current = MgaCursors.WaitCursor;
    try
    {
      Quote quote = new Quote(this._quoteGuid);
      string emailSubject = this.EmailSubjectLine(quote.PolicyNumber, quote.InsuredPolicyName);
      using (frmBinderConfirmation formEx = (frmBinderConfirmation) ObjectFactory.Instance.CreateFormEX(typeof (frmBinderConfirmation), new object[2]
      {
        (object) this._quoteGuid,
        (object) new List<int>()
      }))
        formEx.ClientWorkOnEmailInvoice(false, (UltraGridBase) this.ugInvoices, emailSubject, this._quoteGuid);
    }
    finally
    {
      Cursor.Current = MgaCursors.Default;
    }
  }

  protected virtual void ugInvoices_InitializeLayout(object sender, InitializeLayoutEventArgs e)
  {
    this.InitializeInvoiceGridLayout();
    e.Layout.Bands[0].Columns["OfficeInvoiceNum"].CellAppearance.TextHAlign = (HAlign) 1;
  }

  private delegate void FillThreadCompleteHandler(dsInvoices.InvoicesDataTable dt);

  private sealed class InvoiceSummary : ICustomSummaryCalculator
  {
    private double _sum;

    void ICustomSummaryCalculator.AggregateCustomSummary(
      SummarySettings summarySettings,
      UltraGridRow row)
    {
      if (Conversions.ToBoolean(row.Cells["Failed"].Value) || row.Cells["Amount"].Value == DBNull.Value || row.Cells["Amount"].Value == null)
        return;
      // ISSUE: variable of a reference type
      double& local;
      // ISSUE: explicit reference operation
      double num = ^(local = ref this._sum) + (double) row.Cells["Amount"].Value;
      local = num;
    }

    void ICustomSummaryCalculator.BeginCustomSummary(
      SummarySettings summarySettings,
      RowsCollection rows)
    {
      this._sum = 0.0;
    }

    object ICustomSummaryCalculator.EndCustomSummary(
      SummarySettings summarySettings,
      RowsCollection rows)
    {
      return (object) this._sum;
    }
  }

  private sealed class GrossPremiumSummary : ICustomSummaryCalculator
  {
    private double _sum;

    void ICustomSummaryCalculator.AggregateCustomSummary(
      SummarySettings summarySettings,
      UltraGridRow row)
    {
      if (Conversions.ToBoolean(row.Cells["Failed"].Value) || row.Cells["GrossPremium"].Value == DBNull.Value || row.Cells["GrossPremium"].Value == null)
        return;
      // ISSUE: variable of a reference type
      double& local;
      // ISSUE: explicit reference operation
      double num = ^(local = ref this._sum) + (double) row.Cells["GrossPremium"].Value;
      local = num;
    }

    void ICustomSummaryCalculator.BeginCustomSummary(
      SummarySettings summarySettings,
      RowsCollection rows)
    {
      this._sum = 0.0;
    }

    object ICustomSummaryCalculator.EndCustomSummary(
      SummarySettings summarySettings,
      RowsCollection rows)
    {
      return (object) this._sum;
    }
  }
}
