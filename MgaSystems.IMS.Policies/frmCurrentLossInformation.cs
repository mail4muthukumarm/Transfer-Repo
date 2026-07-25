// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.frmCurrentLossInformation
// Assembly: MgaSystems.IMS.Policies, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 2FF2C709-F7BF-41DA-82BD-FF6319CA235D
// Assembly location: C:\Users\muthu\Downloads\MgaSystems.IMS.Policies.dll

using Infragistics.Win;
using Infragistics.Win.CalcEngine;
using Infragistics.Win.UltraWinCalcManager;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using MGASystems.AsposeFacade.Cells;
using MGASystems.Common.ErrorHandling;
using MGASystems.Data;
using MGASystems.InfragisticsExtensions.Editors;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Policies;

[DesignerGenerated]
public class frmCurrentLossInformation : Form
{
  private IContainer components;
  protected int _quoteID;
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
    Appearance appearance9 = new Appearance();
    SummarySettings summarySettings2 = new SummarySettings("", (SummaryType) 1, (string) null, "Premium", 8, true, "dtCurrentLossInformation", 0, (SummaryPosition) 3, "Premium", 8, true);
    Appearance appearance10 = new Appearance();
    Appearance appearance11 = new Appearance();
    SummarySettings summarySettings3 = new SummarySettings("", (SummaryType) 6, "SUM( [TotalIncurred] ) / SUM( [Premium] )", "LossRatio", 9, true, "dtCurrentLossInformation", 0, (SummaryPosition) 3, "LossRatio", 9, true);
    Appearance appearance12 = new Appearance();
    Appearance appearance13 = new Appearance();
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
    UltraGridColumn ultraGridColumn24 = new UltraGridColumn("GrossIndemnityPaid");
    UltraGridColumn ultraGridColumn25 = new UltraGridColumn("GrossIndemnityReserve");
    UltraGridColumn ultraGridColumn26 = new UltraGridColumn("InsuredName");
    UltraGridColumn ultraGridColumn27 = new UltraGridColumn("LegalReserve");
    UltraGridColumn ultraGridColumn28 = new UltraGridColumn("LegalPaid");
    UltraGridColumn ultraGridColumn29 = new UltraGridColumn("TotalRecovery");
    Appearance appearance14 = new Appearance();
    UltraGridColumn ultraGridColumn30 = new UltraGridColumn("TotalReserves");
    Appearance appearance15 = new Appearance();
    UltraGridColumn ultraGridColumn31 = new UltraGridColumn("ClaimID");
    UltraGridColumn ultraGridColumn32 = new UltraGridColumn("LAEReserve");
    UltraGridColumn ultraGridColumn33 = new UltraGridColumn("LAEPaid");
    UltraGridColumn ultraGridColumn34 = new UltraGridColumn("DeductibleRecovery");
    UltraGridColumn ultraGridColumn35 = new UltraGridColumn("OtherRecovery");
    UltraGridColumn ultraGridColumn36 = new UltraGridColumn("NetIncurred");
    SummarySettings summarySettings4 = new SummarySettings("", (SummaryType) 1, (string) null, "TotalRecovery", 15, true, "FK_dtCurrentLossInformation_dtCurrentLossInformationSub", 1, (SummaryPosition) 3, (string) null, -1, false);
    Appearance appearance16 = new Appearance();
    Appearance appearance17 = new Appearance();
    SummarySettings summarySettings5 = new SummarySettings("", (SummaryType) 1, (string) null, "TotalReserves", 16 /*0x10*/, true, "FK_dtCurrentLossInformation_dtCurrentLossInformationSub", 1, (SummaryPosition) 3, (string) null, -1, false);
    Appearance appearance18 = new Appearance();
    Appearance appearance19 = new Appearance();
    SummarySettings summarySettings6 = new SummarySettings("", (SummaryType) 1, "", "GrossIndemnityPaid", 10, true, "FK_dtCurrentLossInformation_dtCurrentLossInformationSub", 1, (SummaryPosition) 3, (string) null, -1, false);
    Appearance appearance20 = new Appearance();
    SummarySettings summarySettings7 = new SummarySettings("", (SummaryType) 1, (string) null, "GrossIndemnityReserve", 11, true, "FK_dtCurrentLossInformation_dtCurrentLossInformationSub", 1, (SummaryPosition) 3, (string) null, -1, false);
    Appearance appearance21 = new Appearance();
    SummarySettings summarySettings8 = new SummarySettings("", (SummaryType) 1, (string) null, "LegalReserve", 13, true, "FK_dtCurrentLossInformation_dtCurrentLossInformationSub", 1, (SummaryPosition) 3, (string) null, -1, false);
    Appearance appearance22 = new Appearance();
    SummarySettings summarySettings9 = new SummarySettings("", (SummaryType) 1, (string) null, "LegalPaid", 14, true, "FK_dtCurrentLossInformation_dtCurrentLossInformationSub", 1, (SummaryPosition) 3, (string) null, -1, false);
    Appearance appearance23 = new Appearance();
    SummarySettings summarySettings10 = new SummarySettings("", (SummaryType) 1, (string) null, "DeductibleRecovery", 20, true, "FK_dtCurrentLossInformation_dtCurrentLossInformationSub", 1, (SummaryPosition) 3, (string) null, -1, false);
    Appearance appearance24 = new Appearance();
    SummarySettings summarySettings11 = new SummarySettings("", (SummaryType) 1, (string) null, "OtherRecovery", 21, true, "FK_dtCurrentLossInformation_dtCurrentLossInformationSub", 1, (SummaryPosition) 3, (string) null, -1, false);
    Appearance appearance25 = new Appearance();
    SummarySettings summarySettings12 = new SummarySettings("", (SummaryType) 1, (string) null, "LAEReserve", 18, true, "FK_dtCurrentLossInformation_dtCurrentLossInformationSub", 1, (SummaryPosition) 3, (string) null, -1, false);
    Appearance appearance26 = new Appearance();
    SummarySettings summarySettings13 = new SummarySettings("", (SummaryType) 1, (string) null, "LAEPaid", 19, true, "FK_dtCurrentLossInformation_dtCurrentLossInformationSub", 1, (SummaryPosition) 3, (string) null, -1, false);
    Appearance appearance27 = new Appearance();
    SummarySettings summarySettings14 = new SummarySettings("", (SummaryType) 1, (string) null, "NetIncurred", 22, true, "FK_dtCurrentLossInformation_dtCurrentLossInformationSub", 1, (SummaryPosition) 3, (string) null, -1, false);
    Appearance appearance28 = new Appearance();
    Appearance appearance29 = new Appearance();
    Appearance appearance30 = new Appearance();
    Appearance appearance31 = new Appearance();
    Appearance appearance32 = new Appearance();
    Appearance appearance33 = new Appearance();
    Appearance appearance34 = new Appearance();
    Appearance appearance35 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    this.UltraCalcManager1 = new UltraCalcManager(this.components);
    this.lnkViewReport = new LinkLabel();
    this.dgCurrentLossInfo = new UltraGrid();
    this.ds = new dsCurrentLossInformation();
    ((ISupportInitialize) this.UltraCalcManager1).BeginInit();
    ((ISupportInitialize) this.dgCurrentLossInfo).BeginInit();
    this.ds.BeginInit();
    this.SuspendLayout();
    this.UltraCalcManager1.ContainingControl = (ContainerControl) this;
    this.lnkViewReport.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkViewReport.AutoSize = true;
    this.lnkViewReport.Location = new Point(620, 321);
    this.lnkViewReport.Name = "lnkViewReport";
    this.lnkViewReport.Size = new Size(89, 13);
    this.lnkViewReport.TabIndex = 21;
    this.lnkViewReport.TabStop = true;
    this.lnkViewReport.Text = "View As a Report";
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
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.RowLayoutColumnInfo.PreferredCellSize = new Size((int) sbyte.MaxValue, 0);
    ultraGridColumn1.Width = 131;
    ultraGridColumn2.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn2.Header).Caption = "Policy Number";
    ultraGridColumn2.Header.VisiblePosition = 1;
    ultraGridColumn2.RowLayoutColumnInfo.PreferredCellSize = new Size(134, 0);
    ultraGridColumn2.Width = 146;
    ((HeaderBase) ultraGridColumn3.Header).Caption = "Line";
    ultraGridColumn3.Header.VisiblePosition = 2;
    ultraGridColumn4.Format = "c";
    ultraGridColumn4.Header.VisiblePosition = 3;
    ultraGridColumn5.Format = "c";
    ultraGridColumn5.Header.VisiblePosition = 4;
    ultraGridColumn6.Format = "c";
    ultraGridColumn6.Header.VisiblePosition = 5;
    ultraGridColumn7.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance3).TextHAlignAsString = "Right";
    ultraGridColumn7.CellAppearance = (AppearanceBase) appearance3;
    ultraGridColumn7.Format = "c";
    ultraGridColumn7.Header.VisiblePosition = 6;
    ultraGridColumn7.Width = 138;
    ultraGridColumn8.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn8.Header.VisiblePosition = 7;
    ultraGridColumn8.Hidden = true;
    ultraGridColumn9.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance4).TextHAlignAsString = "Right";
    ultraGridColumn9.CellAppearance = (AppearanceBase) appearance4;
    ultraGridColumn9.Format = "c";
    ultraGridColumn9.Header.VisiblePosition = 8;
    ((AppearanceBase) appearance5).TextHAlignAsString = "Right";
    ultraGridColumn10.CellAppearance = (AppearanceBase) appearance5;
    ultraGridColumn10.Format = "p0";
    ((HeaderBase) ultraGridColumn10.Header).Caption = "Loss Ratio";
    ultraGridColumn10.Header.VisiblePosition = 9;
    ((AppearanceBase) appearance6).TextHAlignAsString = "Right";
    ultraGridColumn11.CellAppearance = (AppearanceBase) appearance6;
    ultraGridColumn11.Format = "c";
    ((HeaderBase) ultraGridColumn11.Header).Caption = "Earned Premium";
    ultraGridColumn11.Header.VisiblePosition = 10;
    ((AppearanceBase) appearance7).TextHAlignAsString = "Right";
    ultraGridColumn12.CellAppearance = (AppearanceBase) appearance7;
    ultraGridColumn12.Format = "p0";
    ((HeaderBase) ultraGridColumn12.Header).Caption = "Earned Premium Loss Ratio";
    ultraGridColumn12.Header.VisiblePosition = 11;
    ultraGridColumn13.AutoCompleteMode = (AutoCompleteMode) 2;
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
    summarySettings1.GroupBySummaryValueAppearance = (AppearanceBase) appearance9;
    appearance10.BackColor = Color.Ivory;
    ((AppearanceBase) appearance10).TextHAlignAsString = "Right";
    summarySettings2.Appearance = (AppearanceBase) appearance10;
    summarySettings2.DisplayFormat = "{0:c}";
    summarySettings2.GroupBySummaryValueAppearance = (AppearanceBase) appearance11;
    appearance12.BackColor = Color.Ivory;
    ((AppearanceBase) appearance12).TextHAlignAsString = "Right";
    summarySettings3.Appearance = (AppearanceBase) appearance12;
    summarySettings3.DisplayFormat = "{0:p0}";
    summarySettings3.GroupBySummaryValueAppearance = (AppearanceBase) appearance13;
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
    ultraGridColumn14.Header.VisiblePosition = 1;
    ultraGridColumn14.Hidden = true;
    ultraGridColumn14.Width = 97;
    ultraGridColumn15.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn15.Header).Caption = "Policy Number";
    ultraGridColumn15.Header.VisiblePosition = 2;
    ultraGridColumn15.Hidden = true;
    ultraGridColumn15.Width = 95;
    ultraGridColumn16.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn16.Header).Caption = "Line";
    ultraGridColumn16.Header.VisiblePosition = 3;
    ultraGridColumn16.Hidden = true;
    ultraGridColumn16.Width = 79;
    ultraGridColumn17.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn17.Header).Caption = "Effective";
    ultraGridColumn17.Header.VisiblePosition = 4;
    ultraGridColumn17.Width = 68;
    ultraGridColumn18.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn18.Header).Caption = "Expiration";
    ultraGridColumn18.Header.VisiblePosition = 5;
    ultraGridColumn18.Width = 71;
    ultraGridColumn19.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn19.Header).Caption = "Claim #";
    ultraGridColumn19.Header.VisiblePosition = 6;
    ultraGridColumn19.Width = 65;
    ultraGridColumn20.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn20.Header).Caption = "Date Reported";
    ultraGridColumn20.Header.VisiblePosition = 7;
    ultraGridColumn20.Width = 95;
    ultraGridColumn21.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn21.Header).Caption = "Loss Date";
    ultraGridColumn21.Header.VisiblePosition = 8;
    ultraGridColumn21.Width = 83;
    ultraGridColumn22.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn22.Header.VisiblePosition = 9;
    ultraGridColumn22.Width = 66;
    ultraGridColumn23.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn23.Header).Caption = "Description Injury";
    ultraGridColumn23.Header.VisiblePosition = 10;
    ultraGridColumn23.Width = 106;
    ultraGridColumn24.Format = "c";
    ultraGridColumn24.Header.VisiblePosition = 12;
    ultraGridColumn25.Format = "c";
    ultraGridColumn25.Header.VisiblePosition = 11;
    ultraGridColumn26.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn26.Header.VisiblePosition = 0;
    ultraGridColumn26.Hidden = true;
    ultraGridColumn27.Format = "c";
    ultraGridColumn27.Header.VisiblePosition = 13;
    ultraGridColumn28.Format = "c";
    ultraGridColumn28.Header.VisiblePosition = 14;
    ultraGridColumn29.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance14).TextHAlignAsString = "Right";
    ultraGridColumn29.CellAppearance = (AppearanceBase) appearance14;
    ultraGridColumn29.Format = "c";
    ((HeaderBase) ultraGridColumn29.Header).Caption = "Total Recovery";
    ultraGridColumn29.Header.VisiblePosition = 17;
    ultraGridColumn29.Hidden = true;
    ultraGridColumn30.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance15).TextHAlignAsString = "Right";
    ultraGridColumn30.CellAppearance = (AppearanceBase) appearance15;
    ultraGridColumn30.Format = "c";
    ((HeaderBase) ultraGridColumn30.Header).Caption = "Total Reserves";
    ultraGridColumn30.Header.VisiblePosition = 18;
    ultraGridColumn30.Hidden = true;
    ultraGridColumn31.Header.VisiblePosition = 19;
    ultraGridColumn31.Hidden = true;
    ultraGridColumn32.Format = "c";
    ultraGridColumn32.Header.VisiblePosition = 15;
    ultraGridColumn33.Format = "c";
    ultraGridColumn33.Header.VisiblePosition = 16 /*0x10*/;
    ultraGridColumn34.Format = "c";
    ultraGridColumn34.Header.VisiblePosition = 20;
    ultraGridColumn35.Format = "c";
    ultraGridColumn35.Header.VisiblePosition = 21;
    ultraGridColumn36.Format = "c";
    ultraGridColumn36.Header.VisiblePosition = 22;
    ultraGridBand2.Columns.AddRange(new object[23]
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
      (object) ultraGridColumn32,
      (object) ultraGridColumn33,
      (object) ultraGridColumn34,
      (object) ultraGridColumn35,
      (object) ultraGridColumn36
    });
    ((AppearanceBase) appearance16).TextHAlignAsString = "Right";
    summarySettings4.Appearance = (AppearanceBase) appearance16;
    summarySettings4.DisplayFormat = "{0:c}";
    summarySettings4.GroupBySummaryValueAppearance = (AppearanceBase) appearance17;
    ((AppearanceBase) appearance18).TextHAlignAsString = "Right";
    summarySettings5.Appearance = (AppearanceBase) appearance18;
    summarySettings5.DisplayFormat = "{0:c}";
    summarySettings5.GroupBySummaryValueAppearance = (AppearanceBase) appearance19;
    summarySettings6.DisplayFormat = "{0:c}";
    summarySettings6.GroupBySummaryValueAppearance = (AppearanceBase) appearance20;
    summarySettings7.DisplayFormat = "{0:c}";
    summarySettings7.GroupBySummaryValueAppearance = (AppearanceBase) appearance21;
    summarySettings8.DisplayFormat = "{0:c}";
    summarySettings8.GroupBySummaryValueAppearance = (AppearanceBase) appearance22;
    summarySettings9.DisplayFormat = "{0:c}";
    summarySettings9.GroupBySummaryValueAppearance = (AppearanceBase) appearance23;
    summarySettings10.DisplayFormat = "{0:c}";
    summarySettings10.GroupBySummaryValueAppearance = (AppearanceBase) appearance24;
    summarySettings11.DisplayFormat = "{0:c}";
    summarySettings11.GroupBySummaryValueAppearance = (AppearanceBase) appearance25;
    summarySettings12.DisplayFormat = "{0:c}";
    summarySettings12.GroupBySummaryValueAppearance = (AppearanceBase) appearance26;
    summarySettings13.DisplayFormat = "{0:c}";
    summarySettings13.GroupBySummaryValueAppearance = (AppearanceBase) appearance27;
    summarySettings14.DisplayFormat = "{0:c}";
    summarySettings14.GroupBySummaryValueAppearance = (AppearanceBase) appearance28;
    ultraGridBand2.Summaries.AddRange(new SummarySettings[11]
    {
      summarySettings4,
      summarySettings5,
      summarySettings6,
      summarySettings7,
      summarySettings8,
      summarySettings9,
      summarySettings10,
      summarySettings11,
      summarySettings12,
      summarySettings13,
      summarySettings14
    });
    ultraGridBand2.SummaryFooterCaption = "Totals";
    ((UltraGridBase) this.dgCurrentLossInfo).DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    ((UltraGridBase) this.dgCurrentLossInfo).DisplayLayout.BandsSerializer.Add((object) ultraGridBand2);
    ((UltraGridBase) this.dgCurrentLossInfo).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance29.BackColor = Color.LightSteelBlue;
    appearance29.FontData.SizeInPoints = 10f;
    appearance29.ForeColor = Color.Black;
    ((UltraGridBase) this.dgCurrentLossInfo).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance29;
    appearance30.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance30.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance30.ForeColor = Color.Black;
    ((UltraGridBase) this.dgCurrentLossInfo).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance30;
    ((UltraGridBase) this.dgCurrentLossInfo).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.dgCurrentLossInfo).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.dgCurrentLossInfo).DisplayLayout.Override.AllowRowFiltering = (DefaultableBoolean) 1;
    appearance31.BorderColor = Color.LightGray;
    ((UltraGridBase) this.dgCurrentLossInfo).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance31;
    appearance32.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.dgCurrentLossInfo).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance32;
    ((UltraGridBase) this.dgCurrentLossInfo).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance33.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.dgCurrentLossInfo).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance33;
    appearance34.BorderColor = Color.LightGray;
    ((UltraGridBase) this.dgCurrentLossInfo).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance34;
    ((UltraGridBase) this.dgCurrentLossInfo).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance35.BackColor = Color.Transparent;
    appearance35.ForeColor = Color.Black;
    ((UltraGridBase) this.dgCurrentLossInfo).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance35;
    scrollBarLook.ViewStyle = (ScrollBarViewStyle) 3;
    ((UltraGridBase) this.dgCurrentLossInfo).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((Control) this.dgCurrentLossInfo).Dock = DockStyle.Fill;
    ((Control) this.dgCurrentLossInfo).Font = new Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.dgCurrentLossInfo).Location = new Point(0, 0);
    ((Control) this.dgCurrentLossInfo).Name = "dgCurrentLossInfo";
    ((Control) this.dgCurrentLossInfo).Size = new Size(1330, 392);
    ((Control) this.dgCurrentLossInfo).TabIndex = 4;
    ((Control) this.dgCurrentLossInfo).Text = "Title of Insured";
    ((UltraControlBase) this.dgCurrentLossInfo).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dgCurrentLossInfo).UseOsThemes = (DefaultableBoolean) 2;
    this.ds.DataSetName = "dsCurrentLossInformation";
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    this.ClientSize = new Size(1330, 392);
    this.Controls.Add((Control) this.lnkViewReport);
    this.Controls.Add((Control) this.dgCurrentLossInfo);
    this.Font = new Font("Tahoma", 8.25f);
    this.ForeColor = Color.Black;
    this.Name = nameof (frmCurrentLossInformation);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Insured's Current Loss Information";
    ((ISupportInitialize) this.UltraCalcManager1).EndInit();
    ((ISupportInitialize) this.dgCurrentLossInfo).EndInit();
    this.ds.EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

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
  protected virtual dsCurrentLossInformation ds { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraCalcManager1")]
  protected virtual UltraCalcManager UltraCalcManager1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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

  public frmCurrentLossInformation(int quoteID)
  {
    this.Load += new EventHandler(this.frmCurrentLossInformation_Load);
    this._hlkControlNo = new HyperlinkEditor();
    this.InitializeComponent();
    this._quoteID = quoteID;
  }

  public frmCurrentLossInformation()
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
    }, "dbo.GetCurrentLossInformation", (object[]) new string[2]
    {
      "@QuoteId",
      Conversions.ToString(this._quoteID)
    });
  }

  private void OpenPolicy(object sender, ClickCellEventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(e.Cell.Column.Key, "ControlNo", false) != 0)
      return;
    frmControlNumberJump.LaunchAppropriateQuoteForm(Conversions.ToInteger(e.Cell.Row.Cells["ControlNo"].Value));
  }

  private void lnkViewReport_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    this.SaveDialog();
  }

  private void SaveDialog()
  {
    FileDialog fileDialog = (FileDialog) new SaveFileDialog();
    fileDialog.Filter = "Excel File (*.xlsx)|*.xlsx";
    if (fileDialog.ShowDialog() != DialogResult.OK)
      return;
    this.ExportData(fileDialog.FileName);
  }

  protected virtual void ExportData(string SaveFileTo)
  {
    try
    {
      Workbook workbook = new Workbook();
      workbook.Worksheets.Clear();
      int length = Enum.GetNames(typeof (frmCurrentLossInformation.DataFeedTabs)).Length;
      for (int index1 = 1; index1 <= length; ++index1)
      {
        frmCurrentLossInformation.DataFeedTabs dataFeedTabs = (frmCurrentLossInformation.DataFeedTabs) index1;
        Worksheet wks = workbook.Worksheets.Add(dataFeedTabs.ToString());
        wks.DisplayZeros = true;
        wks.IsRowColumnHeadersVisible = true;
        DataTable dataTable1 = new DataTable();
        switch (index1)
        {
          case 1:
            // ISSUE: reference to a compiler-generated field
            DataTable dataTable2 = this.ResetColumnsOrder(this._ds.Tables[0], new string[12]
            {
              "InsuredName",
              "ControlNo",
              "PolicyNumber",
              "LineName",
              "TotalPaid",
              "TotalReserves",
              "TotalRecovery",
              "TotalIncurred",
              "Premium",
              "LossRatio",
              "EarnedPremium",
              "EarnedPremiumLossRatio"
            });
            wks.Cells.ImportDataTable(dataTable2, true, 0, 0, false, false);
            wks.Cells[dataTable2.Rows.Count + 2, 0].PutValue("Insured Totals");
            this.SetColumnTotal(dataTable2, wks, "TotalPaid", dataTable2.Rows.Count + 2);
            this.SetColumnTotal(dataTable2, wks, "TotalReserves", dataTable2.Rows.Count + 2);
            this.SetColumnTotal(dataTable2, wks, "TotalRecovery", dataTable2.Rows.Count + 2);
            EnumerableRowCollection<DataRow> source1 = dataTable2.AsEnumerable();
            System.Func<DataRow, bool> predicate;
            // ISSUE: reference to a compiler-generated field
            if (frmCurrentLossInformation._Closure\u0024__.\u0024I29\u002D0 != null)
            {
              // ISSUE: reference to a compiler-generated field
              predicate = frmCurrentLossInformation._Closure\u0024__.\u0024I29\u002D0;
            }
            else
            {
              // ISSUE: reference to a compiler-generated field
              frmCurrentLossInformation._Closure\u0024__.\u0024I29\u002D0 = predicate = (System.Func<DataRow, bool>) ([SpecialName] (row) => !Information.IsDBNull(RuntimeHelpers.GetObjectValue(row["TotalIncurred"])));
            }
            EnumerableRowCollection<DataRow> source2 = source1.Where<DataRow>(predicate);
            System.Func<DataRow, Decimal?> selector;
            // ISSUE: reference to a compiler-generated field
            if (frmCurrentLossInformation._Closure\u0024__.\u0024I29\u002D1 != null)
            {
              // ISSUE: reference to a compiler-generated field
              selector = frmCurrentLossInformation._Closure\u0024__.\u0024I29\u002D1;
            }
            else
            {
              // ISSUE: reference to a compiler-generated field
              frmCurrentLossInformation._Closure\u0024__.\u0024I29\u002D1 = selector = (System.Func<DataRow, Decimal?>) ([SpecialName] (row) => row.Field<Decimal?>("TotalIncurred"));
            }
            Decimal d1 = source2.Select<DataRow, Decimal?>(selector).Sum().Value;
            wks.Cells[dataTable2.Rows.Count + 2, dataTable2.Columns["TotalIncurred"].Ordinal].PutValue(d1);
            Decimal d2_1 = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataTable2.Compute("SUM(Premium)", string.Empty)));
            wks.Cells[dataTable2.Rows.Count + 2, dataTable2.Columns["Premium"].Ordinal].PutValue(d2_1);
            Decimal d2_2 = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataTable2.Compute("SUM(EarnedPremium)", string.Empty)));
            wks.Cells[dataTable2.Rows.Count + 2, dataTable2.Columns["EarnedPremium"].Ordinal].PutValue(d2_2);
            wks.Cells[dataTable2.Rows.Count + 2, dataTable2.Columns["LossRatio"].Ordinal].PutValue(Decimal.Divide(d1, d2_1));
            wks.Cells[dataTable2.Rows.Count + 2, dataTable2.Columns["EarnedPremiumLossRatio"].Ordinal].PutValue(Decimal.Divide(d1, d2_2));
            StyleFlag styleFlag = new StyleFlag();
            styleFlag.All = true;
            MGASystems.AsposeFacade.Cells.Cells cells = wks.Cells;
            Style style = new Style();
            style.Number = 9;
            cells.CreateRange(1, dataTable2.Columns["LossRatio"].Ordinal, dataTable2.Rows.Count + 2, 1).ApplyStyle(style, styleFlag);
            cells.CreateRange(1, dataTable2.Columns["EarnedPremiumLossRatio"].Ordinal, dataTable2.Rows.Count + 2, 1).ApplyStyle(style, styleFlag);
            break;
          case 2:
            // ISSUE: reference to a compiler-generated field
            DataTable dataTable3 = this.ResetColumnsOrder(this._ds.Tables[1], new string[22]
            {
              "InsuredName",
              "ControlNo",
              "PolicyNumber",
              "LineName",
              "EffectiveDate",
              "ExpirationDate",
              "ClaimNo",
              "DateReported",
              "LossDate",
              "Status",
              "DescriptionInjury",
              "GrossIndemnityReserve",
              "GrossIndemnityPaid",
              "LegalReserve",
              "LegalPaid",
              "TotalRecovery",
              "TotalReserves",
              "LAEReserve",
              "LAEPaid",
              "DeductibleRecovery",
              "OtherRecovery",
              "NetIncurred"
            });
            dataTable3.DefaultView.Sort = "ControlNo ASC";
            DataTable table1 = dataTable3.DefaultView.ToTable();
            DataTable table2 = table1.DefaultView.ToTable(true, "Controlno");
            int num = 0;
            try
            {
              foreach (DataRow row in table2.Rows)
              {
                int integer = Conversions.ToInteger(row["ControlNo"]);
                DataRow[] dataRowArray = table1.Select("ControlNo = " + integer.ToString());
                DataTable dt = table1.Clone();
                int upperBound = dataRowArray.GetUpperBound(0);
                for (int index2 = 0; index2 <= upperBound; ++index2)
                  dt.ImportRow(dataRowArray[index2]);
                if (num != 0)
                {
                  wks.Cells.ImportDataTable(dt, false, num, 0, false, false);
                }
                else
                {
                  wks.Cells.ImportDataTable(dt, true, num, 0, false, false);
                  num = 1;
                }
                int iRowCount = num + dt.Rows.Count;
                wks.Cells[iRowCount, 0].PutValue("Totals");
                wks.Cells[iRowCount, dt.Columns["DescriptionInjury"].Ordinal].PutValue("Totals");
                this.SetColumnTotal(dt, wks, "GrossIndemnityReserve", iRowCount);
                this.SetColumnTotal(dt, wks, "GrossIndemnityPaid", iRowCount);
                this.SetColumnTotal(dt, wks, "LegalReserve", iRowCount);
                this.SetColumnTotal(dt, wks, "LegalPaid", iRowCount);
                this.SetColumnTotal(dt, wks, "LAEReserve", iRowCount);
                this.SetColumnTotal(dt, wks, "LAEPaid", iRowCount);
                this.SetColumnTotal(dt, wks, "DeductibleRecovery", iRowCount);
                this.SetColumnTotal(dt, wks, "OtherRecovery", iRowCount);
                this.SetColumnTotal(dt, wks, "NetIncurred", iRowCount);
                num = iRowCount + 1;
              }
              break;
            }
            finally
            {
              IEnumerator enumerator;
              if (enumerator is IDisposable)
                (enumerator as IDisposable).Dispose();
            }
        }
        wks.AutoFitColumns();
      }
      workbook.Save(SaveFileTo, (SaveFormat) 6);
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      ErrorHandler.HandleError(ex);
      ProjectData.ClearProjectError();
    }
  }

  protected DataTable SetColumnTotal(
    DataTable dt,
    Worksheet wks,
    string columnName,
    int iRowCount)
  {
    Cell cell = wks.Cells[iRowCount, dt.Columns[columnName].Ordinal];
    if (!string.IsNullOrEmpty(dt.Rows[0][columnName].ToString()))
    {
      Decimal num = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dt.Compute($"SUM({columnName})", string.Empty)));
      cell.PutValue(num);
    }
    else
      cell.PutValue(0);
    DataTable dataTable;
    return dataTable;
  }

  protected DataTable ResetColumnsOrder(DataTable dtCopyForm, string[] columnNames)
  {
    DataTable dataTable = dtCopyForm.Copy();
    int ordinal = 0;
    string[] strArray = columnNames;
    int index = 0;
    while (index < strArray.Length)
    {
      string name = strArray[index];
      dataTable.Columns[name].SetOrdinal(ordinal);
      ++ordinal;
      checked { ++index; }
    }
    return dataTable;
  }

  public enum DataFeedTabs
  {
    Insured = 1,
    Claims = 2,
  }
}
