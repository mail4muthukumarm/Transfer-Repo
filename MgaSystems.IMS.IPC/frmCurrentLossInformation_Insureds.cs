// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.frmCurrentLossInformation_Insureds
// Assembly: MgaSystems.IMS.IPC, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: F22CEF02-8C0F-420D-8344-A8A010CA7834
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.IPC.dll

using Infragistics.Win;
using Infragistics.Win.CalcEngine;
using Infragistics.Win.UltraWinCalcManager;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.InfragisticsExtensions.Editors;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.InsuredsProducersCompanies;

[DesignerGenerated]
public class frmCurrentLossInformation_Insureds : Form
{
  private IContainer components;
  protected int _InsuredID;
  protected Guid _InsuredGuid;
  protected HyperlinkEditor _hlkControlNo;

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
    UltraGridBand ultraGridBand1 = new UltraGridBand("dtCurrentLossInformation", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("ControlNo");
    Appearance appearance2 = new Appearance();
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("PolicyNumber");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("LineName");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("TotalPaid");
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("TotalReserves");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("TotalRecovery");
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("TotalIncurred");
    Appearance appearance3 = new Appearance();
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("InsuredName");
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("Premium");
    Appearance appearance4 = new Appearance();
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("LossRatio");
    Appearance appearance5 = new Appearance();
    UltraGridColumn ultraGridColumn11 = new UltraGridColumn("EarnedPremium");
    Appearance appearance6 = new Appearance();
    UltraGridColumn ultraGridColumn12 = new UltraGridColumn("EarnedPremiumLossRatio");
    Appearance appearance7 = new Appearance();
    UltraGridColumn ultraGridColumn13 = new UltraGridColumn("FK_dtCurrentLossInformation_dtCurrentLossInformationSub");
    SummarySettings summarySettings1 = new SummarySettings("", (SummaryType) 1, (string) null, "TotalIncurred", 6, true, "dtCurrentLossInformation", 0, (SummaryPosition) 3, "TotalIncurred", 6, true);
    Appearance appearance8 = new Appearance();
    SummarySettings summarySettings2 = new SummarySettings("", (SummaryType) 1, (string) null, "Premium", 8, true, "dtCurrentLossInformation", 0, (SummaryPosition) 3, "Premium", 8, true);
    Appearance appearance9 = new Appearance();
    SummarySettings summarySettings3 = new SummarySettings("", (SummaryType) 6, "SUM( [TotalIncurred] ) / SUM( [Premium] )", "LossRatio", 9, true, "dtCurrentLossInformation", 0, (SummaryPosition) 3, "LossRatio", 9, true);
    Appearance appearance10 = new Appearance();
    UltraGridBand ultraGridBand2 = new UltraGridBand("FK_dtCurrentLossInformation_dtCurrentLossInformationSub", 0);
    UltraGridColumn ultraGridColumn14 = new UltraGridColumn("ControlNo");
    UltraGridColumn ultraGridColumn15 = new UltraGridColumn("PolicyNumber");
    UltraGridColumn ultraGridColumn16 = new UltraGridColumn("LineName");
    UltraGridColumn ultraGridColumn17 = new UltraGridColumn("EffectiveDate");
    UltraGridColumn ultraGridColumn18 = new UltraGridColumn("ExpirationDate");
    UltraGridColumn ultraGridColumn19 = new UltraGridColumn("ClaimNo");
    UltraGridColumn ultraGridColumn20 = new UltraGridColumn("DateReported");
    UltraGridColumn ultraGridColumn21 = new UltraGridColumn("LossDate");
    UltraGridColumn ultraGridColumn22 = new UltraGridColumn("Status");
    UltraGridColumn ultraGridColumn23 = new UltraGridColumn("DescriptionInjury");
    UltraGridColumn ultraGridColumn24 = new UltraGridColumn("IndemnityPTD");
    Appearance appearance11 = new Appearance();
    UltraGridColumn ultraGridColumn25 = new UltraGridColumn("OutIndRes");
    Appearance appearance12 = new Appearance();
    UltraGridColumn ultraGridColumn26 = new UltraGridColumn("LossIncurred");
    Appearance appearance13 = new Appearance();
    UltraGridColumn ultraGridColumn27 = new UltraGridColumn("InsuredName");
    UltraGridColumn ultraGridColumn28 = new UltraGridColumn("LAEPTD");
    Appearance appearance14 = new Appearance();
    UltraGridColumn ultraGridColumn29 = new UltraGridColumn("OutLAERes");
    Appearance appearance15 = new Appearance();
    UltraGridColumn ultraGridColumn30 = new UltraGridColumn("TotalRecovery");
    Appearance appearance16 = new Appearance();
    UltraGridColumn ultraGridColumn31 = new UltraGridColumn("TotalReserves");
    Appearance appearance17 = new Appearance();
    UltraGridColumn ultraGridColumn32 = new UltraGridColumn("ClaimID");
    SummarySettings summarySettings4 = new SummarySettings("", (SummaryType) 1, (string) null, "IndemnityPTD", 10, true, "FK_dtCurrentLossInformation_dtCurrentLossInformationSub", 1, (SummaryPosition) 3, "IndemnityPTD", 10, true);
    Appearance appearance18 = new Appearance();
    SummarySettings summarySettings5 = new SummarySettings("", (SummaryType) 1, (string) null, "OutIndRes", 11, true, "FK_dtCurrentLossInformation_dtCurrentLossInformationSub", 1, (SummaryPosition) 3, "OutIndRes", 11, true);
    Appearance appearance19 = new Appearance();
    SummarySettings summarySettings6 = new SummarySettings("", (SummaryType) 1, (string) null, "LossIncurred", 12, true, "FK_dtCurrentLossInformation_dtCurrentLossInformationSub", 1, (SummaryPosition) 3, "LossIncurred", 12, true);
    Appearance appearance20 = new Appearance();
    SummarySettings summarySettings7 = new SummarySettings("", (SummaryType) 1, (string) null, "LAEPTD", 14, true, "FK_dtCurrentLossInformation_dtCurrentLossInformationSub", 1, (SummaryPosition) 3, "LAEPTD", 14, true);
    Appearance appearance21 = new Appearance();
    SummarySettings summarySettings8 = new SummarySettings("", (SummaryType) 1, (string) null, "OutLAERes", 15, true, "FK_dtCurrentLossInformation_dtCurrentLossInformationSub", 1, (SummaryPosition) 3, (string) null, -1, false);
    Appearance appearance22 = new Appearance();
    SummarySettings summarySettings9 = new SummarySettings("", (SummaryType) 1, (string) null, "TotalRecovery", 16 /*0x10*/, true, "FK_dtCurrentLossInformation_dtCurrentLossInformationSub", 1, (SummaryPosition) 3, (string) null, -1, false);
    Appearance appearance23 = new Appearance();
    SummarySettings summarySettings10 = new SummarySettings("", (SummaryType) 1, (string) null, "TotalReserves", 17, true, "FK_dtCurrentLossInformation_dtCurrentLossInformationSub", 1, (SummaryPosition) 3, (string) null, -1, false);
    Appearance appearance24 = new Appearance();
    Appearance appearance25 = new Appearance();
    Appearance appearance26 = new Appearance();
    Appearance appearance27 = new Appearance();
    Appearance appearance28 = new Appearance();
    Appearance appearance29 = new Appearance();
    Appearance appearance30 = new Appearance();
    Appearance appearance31 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    this.ds = new dsCurrentLossInformation_Insureds();
    this.UltraCalcManager1 = new UltraCalcManager(this.components);
    this.dgCurrentLossInfo = new UltraGrid();
    this.ds.BeginInit();
    ((ISupportInitialize) this.UltraCalcManager1).BeginInit();
    ((ISupportInitialize) this.dgCurrentLossInfo).BeginInit();
    this.SuspendLayout();
    this.ds.DataSetName = "dsCurrentLossInformation_Insureds";
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.UltraCalcManager1.ContainingControl = (ContainerControl) this;
    ((UltraGridBase) this.dgCurrentLossInfo).CalcManager = (IUltraCalcManager) this.UltraCalcManager1;
    ((Control) this.dgCurrentLossInfo).DataBindings.Add(new Binding("Text", (object) this.ds, "dtCurrentLossInformation.InsuredName", true));
    ((UltraGridBase) this.dgCurrentLossInfo).DataSource = (object) this.ds;
    appearance1.BackColor = Color.White;
    appearance1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.dgCurrentLossInfo).DisplayLayout.Appearance = (AppearanceBase) appearance1;
    ultraGridColumn1.AutoCompleteMode = (AutoCompleteMode) 2;
    appearance2.ForeColor = Color.Blue;
    ultraGridColumn1.CellAppearance = (AppearanceBase) appearance2;
    ((HeaderBase) ultraGridColumn1.Header).Caption = "Control Number";
    ((HeaderBase) ultraGridColumn1.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.RowLayoutColumnInfo.PreferredCellSize = new Size((int) sbyte.MaxValue, 0);
    ultraGridColumn1.Width = 131;
    ultraGridColumn2.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn2.Header).Caption = "Policy Number";
    ((HeaderBase) ultraGridColumn2.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn2.Header.VisiblePosition = 1;
    ultraGridColumn2.RowLayoutColumnInfo.PreferredCellSize = new Size(134, 0);
    ultraGridColumn2.Width = 146;
    ((HeaderBase) ultraGridColumn3.Header).Caption = "Line";
    ((HeaderBase) ultraGridColumn3.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn3.Header.VisiblePosition = 2;
    ultraGridColumn4.Format = "c";
    ((HeaderBase) ultraGridColumn4.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn4.Header.VisiblePosition = 3;
    ultraGridColumn5.Format = "c";
    ((HeaderBase) ultraGridColumn5.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn5.Header.VisiblePosition = 4;
    ultraGridColumn6.Format = "c";
    ((HeaderBase) ultraGridColumn6.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn6.Header.VisiblePosition = 5;
    ultraGridColumn7.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance3).TextHAlignAsString = "Right";
    ultraGridColumn7.CellAppearance = (AppearanceBase) appearance3;
    ultraGridColumn7.Format = "c";
    ((HeaderBase) ultraGridColumn7.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn7.Header.VisiblePosition = 6;
    ultraGridColumn7.Width = 138;
    ultraGridColumn8.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn8.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn8.Header.VisiblePosition = 7;
    ultraGridColumn8.Hidden = true;
    ultraGridColumn9.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance4).TextHAlignAsString = "Right";
    ultraGridColumn9.CellAppearance = (AppearanceBase) appearance4;
    ultraGridColumn9.Format = "c";
    ((HeaderBase) ultraGridColumn9.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn9.Header.VisiblePosition = 8;
    ((AppearanceBase) appearance5).TextHAlignAsString = "Right";
    ultraGridColumn10.CellAppearance = (AppearanceBase) appearance5;
    ultraGridColumn10.Format = "p0";
    ((HeaderBase) ultraGridColumn10.Header).Caption = "Loss Ratio";
    ((HeaderBase) ultraGridColumn10.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn10.Header.VisiblePosition = 9;
    ((AppearanceBase) appearance6).TextHAlignAsString = "Right";
    ultraGridColumn11.CellAppearance = (AppearanceBase) appearance6;
    ultraGridColumn11.Format = "c";
    ((HeaderBase) ultraGridColumn11.Header).Caption = "Earned Premium";
    ((HeaderBase) ultraGridColumn11.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn11.Header.VisiblePosition = 10;
    ((AppearanceBase) appearance7).TextHAlignAsString = "Right";
    ultraGridColumn12.CellAppearance = (AppearanceBase) appearance7;
    ultraGridColumn12.Format = "p0";
    ((HeaderBase) ultraGridColumn12.Header).Caption = "Earned Premium Loss Ratio";
    ((HeaderBase) ultraGridColumn12.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn12.Header.VisiblePosition = 11;
    ultraGridColumn13.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn13.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn13.Header.VisiblePosition = 12;
    ultraGridBand1.Columns.AddRange(new object[13]
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
      (object) ultraGridColumn13
    });
    ultraGridBand1.Override.AllowUpdate = (DefaultableBoolean) 2;
    appearance8.BackColor = Color.Ivory;
    ((AppearanceBase) appearance8).TextHAlignAsString = "Right";
    summarySettings1.Appearance = (AppearanceBase) appearance8;
    summarySettings1.DisplayFormat = "{0:c}";
    appearance9.BackColor = Color.Ivory;
    ((AppearanceBase) appearance9).TextHAlignAsString = "Right";
    summarySettings2.Appearance = (AppearanceBase) appearance9;
    summarySettings2.DisplayFormat = "{0:c}";
    appearance10.BackColor = Color.Ivory;
    ((AppearanceBase) appearance10).TextHAlignAsString = "Right";
    summarySettings3.Appearance = (AppearanceBase) appearance10;
    summarySettings3.DisplayFormat = "{0:p0}";
    ultraGridBand1.Summaries.AddRange(new SummarySettings[3]
    {
      summarySettings1,
      summarySettings2,
      summarySettings3
    });
    ultraGridBand1.SummaryFooterCaption = "Insured Totals";
    ultraGridColumn14.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn14.Format = "c";
    ((HeaderBase) ultraGridColumn14.Header).Caption = "Control Number";
    ((HeaderBase) ultraGridColumn14.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn14.Header.VisiblePosition = 0;
    ultraGridColumn14.Hidden = true;
    ultraGridColumn14.Width = 97;
    ultraGridColumn15.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn15.Header).Caption = "Policy Number";
    ((HeaderBase) ultraGridColumn15.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn15.Header.VisiblePosition = 1;
    ultraGridColumn15.Hidden = true;
    ultraGridColumn15.Width = 95;
    ultraGridColumn16.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn16.Header).Caption = "Line";
    ((HeaderBase) ultraGridColumn16.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn16.Header.VisiblePosition = 2;
    ultraGridColumn16.Hidden = true;
    ultraGridColumn16.Width = 79;
    ultraGridColumn17.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn17.Header).Caption = "Effective";
    ((HeaderBase) ultraGridColumn17.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn17.Header.VisiblePosition = 3;
    ultraGridColumn17.Width = 68;
    ultraGridColumn18.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn18.Header).Caption = "Expiration";
    ((HeaderBase) ultraGridColumn18.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn18.Header.VisiblePosition = 4;
    ultraGridColumn18.Width = 71;
    ultraGridColumn19.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn19.Header).Caption = "Claim #";
    ((HeaderBase) ultraGridColumn19.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn19.Header.VisiblePosition = 5;
    ultraGridColumn19.Width = 65;
    ultraGridColumn20.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn20.Header).Caption = "Date Reported";
    ((HeaderBase) ultraGridColumn20.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn20.Header.VisiblePosition = 6;
    ultraGridColumn20.Width = 95;
    ultraGridColumn21.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn21.Header).Caption = "Loss Date";
    ((HeaderBase) ultraGridColumn21.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn21.Header.VisiblePosition = 7;
    ultraGridColumn21.Width = 83;
    ultraGridColumn22.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn22.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn22.Header.VisiblePosition = 8;
    ultraGridColumn22.Width = 66;
    ultraGridColumn23.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn23.Header).Caption = "Description Injury";
    ((HeaderBase) ultraGridColumn23.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn23.Header.VisiblePosition = 9;
    ultraGridColumn23.Width = 106;
    ultraGridColumn24.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance11).TextHAlignAsString = "Right";
    ultraGridColumn24.CellAppearance = (AppearanceBase) appearance11;
    ultraGridColumn24.Format = "c";
    ((HeaderBase) ultraGridColumn24.Header).Caption = "Indemnity PTD";
    ((HeaderBase) ultraGridColumn24.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn24.Header.VisiblePosition = 10;
    ultraGridColumn24.Width = 93;
    ultraGridColumn25.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance12).TextHAlignAsString = "Right";
    ultraGridColumn25.CellAppearance = (AppearanceBase) appearance12;
    ultraGridColumn25.Format = "c";
    ((HeaderBase) ultraGridColumn25.Header).Caption = "Out. Ind. Res.";
    ((HeaderBase) ultraGridColumn25.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn25.Header.VisiblePosition = 11;
    ultraGridColumn25.Width = 87;
    ultraGridColumn26.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance13).TextHAlignAsString = "Right";
    ultraGridColumn26.CellAppearance = (AppearanceBase) appearance13;
    ultraGridColumn26.Format = "c";
    ((HeaderBase) ultraGridColumn26.Header).Caption = "Loss Incurred";
    ((HeaderBase) ultraGridColumn26.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn26.Header.VisiblePosition = 17;
    ultraGridColumn26.Width = 90;
    ultraGridColumn27.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn27.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn27.Header.VisiblePosition = 12;
    ultraGridColumn27.Hidden = true;
    ultraGridColumn28.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance14).TextHAlignAsString = "Right";
    ultraGridColumn28.CellAppearance = (AppearanceBase) appearance14;
    ultraGridColumn28.Format = "c";
    ((HeaderBase) ultraGridColumn28.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn28.Header.VisiblePosition = 13;
    ultraGridColumn29.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance15).TextHAlignAsString = "Right";
    ultraGridColumn29.CellAppearance = (AppearanceBase) appearance15;
    ultraGridColumn29.Format = "c";
    ((HeaderBase) ultraGridColumn29.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn29.Header.VisiblePosition = 14;
    ultraGridColumn30.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance16).TextHAlignAsString = "Right";
    ultraGridColumn30.CellAppearance = (AppearanceBase) appearance16;
    ultraGridColumn30.Format = "c";
    ((HeaderBase) ultraGridColumn30.Header).Caption = "Total Recovery";
    ((HeaderBase) ultraGridColumn30.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn30.Header.VisiblePosition = 15;
    ultraGridColumn31.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance17).TextHAlignAsString = "Right";
    ultraGridColumn31.CellAppearance = (AppearanceBase) appearance17;
    ultraGridColumn31.Format = "c";
    ((HeaderBase) ultraGridColumn31.Header).Caption = "Total Reserves";
    ((HeaderBase) ultraGridColumn31.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn31.Header.VisiblePosition = 16 /*0x10*/;
    ((HeaderBase) ultraGridColumn32.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn32.Header.VisiblePosition = 18;
    ultraGridColumn32.Hidden = true;
    ultraGridBand2.Columns.AddRange(new object[19]
    {
      (object) ultraGridColumn14,
      (object) ultraGridColumn15,
      (object) ultraGridColumn16,
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
      (object) ultraGridColumn29,
      (object) ultraGridColumn30,
      (object) ultraGridColumn31,
      (object) ultraGridColumn32
    });
    ((AppearanceBase) appearance18).TextHAlignAsString = "Right";
    summarySettings4.Appearance = (AppearanceBase) appearance18;
    summarySettings4.DisplayFormat = "{0:c}";
    ((AppearanceBase) appearance19).TextHAlignAsString = "Right";
    summarySettings5.Appearance = (AppearanceBase) appearance19;
    summarySettings5.DisplayFormat = "{0:c}";
    ((AppearanceBase) appearance20).TextHAlignAsString = "Right";
    summarySettings6.Appearance = (AppearanceBase) appearance20;
    summarySettings6.DisplayFormat = "{0:c}";
    ((AppearanceBase) appearance21).TextHAlignAsString = "Right";
    summarySettings7.Appearance = (AppearanceBase) appearance21;
    summarySettings7.DisplayFormat = "{0:c}";
    ((AppearanceBase) appearance22).TextHAlignAsString = "Right";
    summarySettings8.Appearance = (AppearanceBase) appearance22;
    summarySettings8.DisplayFormat = "{0:c}";
    ((AppearanceBase) appearance23).TextHAlignAsString = "Right";
    summarySettings9.Appearance = (AppearanceBase) appearance23;
    summarySettings9.DisplayFormat = "{0:c}";
    ((AppearanceBase) appearance24).TextHAlignAsString = "Right";
    summarySettings10.Appearance = (AppearanceBase) appearance24;
    summarySettings10.DisplayFormat = "{0:c}";
    ultraGridBand2.Summaries.AddRange(new SummarySettings[7]
    {
      summarySettings4,
      summarySettings5,
      summarySettings6,
      summarySettings7,
      summarySettings8,
      summarySettings9,
      summarySettings10
    });
    ultraGridBand2.SummaryFooterCaption = "Totals";
    ((UltraGridBase) this.dgCurrentLossInfo).DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    ((UltraGridBase) this.dgCurrentLossInfo).DisplayLayout.BandsSerializer.Add((object) ultraGridBand2);
    ((UltraGridBase) this.dgCurrentLossInfo).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance25.BackColor = Color.LightSteelBlue;
    appearance25.FontData.SizeInPoints = 10f;
    appearance25.ForeColor = Color.Black;
    ((UltraGridBase) this.dgCurrentLossInfo).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance25;
    appearance26.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance26.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance26.ForeColor = Color.Black;
    ((UltraGridBase) this.dgCurrentLossInfo).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance26;
    ((UltraGridBase) this.dgCurrentLossInfo).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.dgCurrentLossInfo).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.dgCurrentLossInfo).DisplayLayout.Override.AllowRowFiltering = (DefaultableBoolean) 1;
    appearance27.BorderColor = Color.LightGray;
    ((UltraGridBase) this.dgCurrentLossInfo).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance27;
    appearance28.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.dgCurrentLossInfo).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance28;
    ((UltraGridBase) this.dgCurrentLossInfo).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance29.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.dgCurrentLossInfo).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance29;
    appearance30.BorderColor = Color.LightGray;
    ((UltraGridBase) this.dgCurrentLossInfo).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance30;
    ((UltraGridBase) this.dgCurrentLossInfo).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance31.BackColor = Color.Transparent;
    appearance31.ForeColor = Color.Black;
    ((UltraGridBase) this.dgCurrentLossInfo).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance31;
    scrollBarLook.ViewStyle = (ScrollBarViewStyle) 3;
    ((UltraGridBase) this.dgCurrentLossInfo).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((Control) this.dgCurrentLossInfo).Dock = DockStyle.Fill;
    ((Control) this.dgCurrentLossInfo).Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.dgCurrentLossInfo).Location = new Point(0, 0);
    ((Control) this.dgCurrentLossInfo).Name = "dgCurrentLossInfo";
    ((Control) this.dgCurrentLossInfo).Size = new Size(1045, 524);
    ((Control) this.dgCurrentLossInfo).TabIndex = 5;
    ((Control) this.dgCurrentLossInfo).Text = "Title of Insured";
    ((UltraControlBase) this.dgCurrentLossInfo).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dgCurrentLossInfo).UseOsThemes = (DefaultableBoolean) 2;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(1045, 524);
    this.Controls.Add((Control) this.dgCurrentLossInfo);
    this.Name = nameof (frmCurrentLossInformation_Insureds);
    this.Text = "Insured's Current Loss Information";
    this.ds.EndInit();
    ((ISupportInitialize) this.UltraCalcManager1).EndInit();
    ((ISupportInitialize) this.dgCurrentLossInfo).EndInit();
    this.ResumeLayout(false);
  }

  [field: AccessedThroughProperty("UltraCalcManager1")]
  internal virtual UltraCalcManager UltraCalcManager1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected virtual UltraGrid dgCurrentLossInfo
  {
    get => this._dgCurrentLossInfo;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      ClickCellEventHandler cellEventHandler = new ClickCellEventHandler(this.OpenPolicy);
      UltraGrid dgCurrentLossInfo1 = this._dgCurrentLossInfo;
      if (dgCurrentLossInfo1 != null)
        dgCurrentLossInfo1.ClickCell -= cellEventHandler;
      this._dgCurrentLossInfo = value;
      UltraGrid dgCurrentLossInfo2 = this._dgCurrentLossInfo;
      if (dgCurrentLossInfo2 == null)
        return;
      dgCurrentLossInfo2.ClickCell += cellEventHandler;
    }
  }

  [field: AccessedThroughProperty("ds")]
  protected virtual dsCurrentLossInformation_Insureds ds { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  public frmCurrentLossInformation_Insureds(Guid InsuredGuid)
  {
    this.Load += new EventHandler(this.frmCurrentLossInformation_Load);
    this._hlkControlNo = new HyperlinkEditor();
    this.InitializeComponent();
    this._InsuredGuid = InsuredGuid;
  }

  public frmCurrentLossInformation_Insureds()
  {
    this.Load += new EventHandler(this.frmCurrentLossInformation_Load);
    this._hlkControlNo = new HyperlinkEditor();
    this.InitializeComponent();
  }

  protected virtual void frmCurrentLossInformation_Load(object sender, EventArgs e)
  {
    if (this.DesignMode)
      return;
    this.GetLossInformation();
    ((UltraGridBase) this.dgCurrentLossInfo).DisplayLayout.Bands[0].Columns["ControlNo"].Editor = (EmbeddableEditorBase) this._hlkControlNo;
  }

  protected virtual void GetLossInformation()
  {
    DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[2]
    {
      this.ds.dtCurrentLossInformation.TableName,
      this.ds.dtCurrentLossInformationSub.TableName
    }, "dbo.GetCurrentLossInformation_Insured", (object[]) new string[2]
    {
      "@InsuredGuid",
      this._InsuredGuid.ToString()
    });
  }

  private void OpenPolicy(object sender, ClickCellEventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(e.Cell.Column.Key, "ControlNo", false) != 0)
      return;
    ObjectFactory.Instance.CreateTypeFromString("MGASystems.IMS.Policies.frmControlNumberJump").GetMethod("LaunchAppropriateQuoteForm", BindingFlags.Static | BindingFlags.Public).Invoke((object) null, new object[1]
    {
      (object) Conversions.ToInteger(e.Cell.Row.Cells["ControlNo"].Value)
    });
  }
}
