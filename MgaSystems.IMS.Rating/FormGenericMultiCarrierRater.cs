// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Rating.FormGenericMultiCarrierRater
// Assembly: MgaSystems.IMS.Rating, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 370B8F0A-FA1A-41D0-87BD-563CC23E9EA7
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Rating.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using Infragistics.Win.UltraWinTabControl;
using Infragistics.Win.UltraWinTabs;
using MGASystems.BusinessObjects;
using MGASystems.Common;
using MGASystems.Common.ErrorHandling;
using MGASystems.Common.Extensions;
using MGASystems.Data;
using MGASystems.IMS.Policies.Rating.ExposureCapture;
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
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Policies.Rating;

[DesignerGenerated]
public class FormGenericMultiCarrierRater : frmRaterBase
{
  private IContainer components;
  private Guid _quoteGuid;
  private int _quoteID;

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
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (FormGenericMultiCarrierRater));
    Appearance appearance10 = new Appearance();
    UltraTab ultraTab1 = new UltraTab();
    UltraTab ultraTab2 = new UltraTab();
    UltraTab ultraTab3 = new UltraTab();
    UltraTab ultraTab4 = new UltraTab();
    UltraTab ultraTab5 = new UltraTab();
    UltraTab ultraTab6 = new UltraTab();
    UltraTab ultraTab7 = new UltraTab();
    UltraTab ultraTab8 = new UltraTab();
    UltraTab ultraTab9 = new UltraTab();
    Appearance appearance11 = new Appearance();
    UltraGridBand ultraGridBand = new UltraGridBand("dtPropertyInfo", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("Carrier");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("Premium");
    Appearance appearance12 = new Appearance();
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("TRIAPremium");
    Appearance appearance13 = new Appearance();
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("CompanyLocationGuid");
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("FeeAmount");
    Appearance appearance14 = new Appearance();
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("Limit");
    Appearance appearance15 = new Appearance();
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("Participation");
    Appearance appearance16 = new Appearance();
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("AddFees");
    Appearance appearance17 = new Appearance();
    SummarySettings summarySettings1 = new SummarySettings("", (SummaryType) 1, (string) null, "Premium", 1, true, "dtPropertyInfo", 0, (SummaryPosition) 3, "Premium", 1, true);
    Appearance appearance18 = new Appearance();
    Appearance appearance19 = new Appearance();
    SummarySettings summarySettings2 = new SummarySettings("", (SummaryType) 1, (string) null, "TRIAPremium", 2, true, "dtPropertyInfo", 0, (SummaryPosition) 3, "TRIAPremium", 2, true);
    Appearance appearance20 = new Appearance();
    Appearance appearance21 = new Appearance();
    SummarySettings summarySettings3 = new SummarySettings("", (SummaryType) 1, (string) null, "FeeAmount", 4, true, "dtPropertyInfo", 0, (SummaryPosition) 3, "FeeAmount", 4, true);
    Appearance appearance22 = new Appearance();
    Appearance appearance23 = new Appearance();
    Appearance appearance24 = new Appearance();
    Appearance appearance25 = new Appearance();
    Appearance appearance26 = new Appearance();
    Appearance appearance27 = new Appearance();
    Appearance appearance28 = new Appearance();
    Appearance appearance29 = new Appearance();
    Appearance appearance30 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    this.UltraTabPageControl7 = new UltraTabPageControl();
    this.UltraGroupBox6 = new UltraGroupBox();
    this.txtLimit = new RichTextBox();
    this.UltraTabPageControl9 = new UltraTabPageControl();
    this.UltraGroupBox8 = new UltraGroupBox();
    this.txtSubLimits = new RichTextBox();
    this.UltraTabPageControl8 = new UltraTabPageControl();
    this.UltraGroupBox7 = new UltraGroupBox();
    this.txtDeductible = new RichTextBox();
    this.UltraTabPageControl2 = new UltraTabPageControl();
    this.UltraGroupBox1 = new UltraGroupBox();
    this.txtPerils = new RichTextBox();
    this.UltraTabPageControl3 = new UltraTabPageControl();
    this.UltraGroupBox2 = new UltraGroupBox();
    this.txtCovering = new RichTextBox();
    this.UltraTabPageControl4 = new UltraTabPageControl();
    this.UltraGroupBox3 = new UltraGroupBox();
    this.txtValuation = new RichTextBox();
    this.UltraTabPageControl5 = new UltraTabPageControl();
    this.UltraGroupBox4 = new UltraGroupBox();
    this.txtExcluding = new RichTextBox();
    this.UltraTabPageControl6 = new UltraTabPageControl();
    this.UltraGroupBox5 = new UltraGroupBox();
    this.txtAdditionalComments = new RichTextBox();
    this.tabExposure = new UltraTabPageControl();
    this.lnkPremiumAllocation = new LinkLabel();
    this.btnExposure = new MGAButton();
    this.listExposureLines = new MGAListBox();
    this.Label8 = new Label();
    this.btnSave = new MGAButton();
    this.cn = new SqlConnection();
    this.da = new SqlDataAdapter();
    this.SqlDeleteCommand2 = new SqlCommand();
    this.SqlInsertCommand2 = new SqlCommand();
    this.SqlSelectCommand4 = new SqlCommand();
    this.SqlUpdateCommand2 = new SqlCommand();
    this.MgaTab1 = new UltraTabControl();
    this.UltraTabSharedControlsPage1 = new UltraTabSharedControlsPage();
    this.UltraTabPageControl1 = new UltraTabPageControl();
    this.linkEndorsementOffsets = new LinkLabel();
    this.linkOffsetTransaction = new LinkLabel();
    this.lnkNewOption = new LinkLabel();
    this.Label9 = new Label();
    this.lnkFCW = new LinkLabel();
    this.Label2 = new Label();
    this.Label1 = new Label();
    this.Label6 = new Label();
    this.Label5 = new Label();
    this.Label3 = new Label();
    this.Label7 = new Label();
    this.Label4 = new Label();
    this.daGenericLimits = new SqlDataAdapter();
    this.SqlDeleteCommand3 = new SqlCommand();
    this.SqlInsertCommand3 = new SqlCommand();
    this.SqlSelectCommand3 = new SqlCommand();
    this.SqlUpdateCommand3 = new SqlCommand();
    this.lnkOffset = new LinkLabel();
    this.ugCarriers = new UltraGrid();
    this.ds = new dsGenericMultiRater();
    this.lblPart = new Label();
    this.lblParticipationPercentage = new Label();
    ((Control) this.UltraTabPageControl7).SuspendLayout();
    ((ISupportInitialize) this.UltraGroupBox6).BeginInit();
    ((Control) this.UltraGroupBox6).SuspendLayout();
    ((Control) this.UltraTabPageControl9).SuspendLayout();
    ((ISupportInitialize) this.UltraGroupBox8).BeginInit();
    ((Control) this.UltraGroupBox8).SuspendLayout();
    ((Control) this.UltraTabPageControl8).SuspendLayout();
    ((ISupportInitialize) this.UltraGroupBox7).BeginInit();
    ((Control) this.UltraGroupBox7).SuspendLayout();
    ((Control) this.UltraTabPageControl2).SuspendLayout();
    ((ISupportInitialize) this.UltraGroupBox1).BeginInit();
    ((Control) this.UltraGroupBox1).SuspendLayout();
    ((Control) this.UltraTabPageControl3).SuspendLayout();
    ((ISupportInitialize) this.UltraGroupBox2).BeginInit();
    ((Control) this.UltraGroupBox2).SuspendLayout();
    ((Control) this.UltraTabPageControl4).SuspendLayout();
    ((ISupportInitialize) this.UltraGroupBox3).BeginInit();
    ((Control) this.UltraGroupBox3).SuspendLayout();
    ((Control) this.UltraTabPageControl5).SuspendLayout();
    ((ISupportInitialize) this.UltraGroupBox4).BeginInit();
    ((Control) this.UltraGroupBox4).SuspendLayout();
    ((Control) this.UltraTabPageControl6).SuspendLayout();
    ((ISupportInitialize) this.UltraGroupBox5).BeginInit();
    ((Control) this.UltraGroupBox5).SuspendLayout();
    ((Control) this.tabExposure).SuspendLayout();
    ((ISupportInitialize) this.btnExposure).BeginInit();
    ((ISupportInitialize) this.listExposureLines).BeginInit();
    ((ISupportInitialize) this.btnSave).BeginInit();
    ((ISupportInitialize) this.MgaTab1).BeginInit();
    ((Control) this.MgaTab1).SuspendLayout();
    ((Control) this.UltraTabPageControl1).SuspendLayout();
    ((ISupportInitialize) this.ugCarriers).BeginInit();
    this.ds.BeginInit();
    this.SuspendLayout();
    ((Control) this.UltraTabPageControl7).Controls.Add((Control) this.UltraGroupBox6);
    ((Control) this.UltraTabPageControl7).Location = new Point(-10000, -10000);
    ((Control) this.UltraTabPageControl7).Name = "UltraTabPageControl7";
    ((Control) this.UltraTabPageControl7).Size = new Size(756, 248);
    this.UltraGroupBox6.BackColorInternal = Color.FromArgb(240 /*0xF0*/, 247, 253);
    appearance1.BackColor = Color.White;
    appearance1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.UltraGroupBox6.ContentAreaAppearance = (AppearanceBase) appearance1;
    ((Control) this.UltraGroupBox6).Controls.Add((Control) this.txtLimit);
    ((Control) this.UltraGroupBox6).Location = new Point(13, 10);
    ((Control) this.UltraGroupBox6).Name = "UltraGroupBox6";
    ((Control) this.UltraGroupBox6).Size = new Size(731, 220);
    ((Control) this.UltraGroupBox6).TabIndex = 6;
    this.UltraGroupBox6.Text = "Limit";
    this.txtLimit.AcceptsTab = true;
    this.txtLimit.BackColor = Color.White;
    this.txtLimit.BorderStyle = BorderStyle.None;
    this.txtLimit.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.txtLimit.ForeColor = Color.Black;
    this.txtLimit.Location = new Point(8, 16 /*0x10*/);
    this.txtLimit.Name = "txtLimit";
    this.txtLimit.Size = new Size(523, 198);
    this.txtLimit.TabIndex = 3;
    this.txtLimit.Text = "";
    ((Control) this.UltraTabPageControl9).Controls.Add((Control) this.UltraGroupBox8);
    ((Control) this.UltraTabPageControl9).Location = new Point(1, 26);
    ((Control) this.UltraTabPageControl9).Name = "UltraTabPageControl9";
    ((Control) this.UltraTabPageControl9).Size = new Size(756, 248);
    this.UltraGroupBox8.BackColorInternal = Color.FromArgb(240 /*0xF0*/, 247, 253);
    appearance2.BackColor = Color.White;
    appearance2.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.UltraGroupBox8.ContentAreaAppearance = (AppearanceBase) appearance2;
    ((Control) this.UltraGroupBox8).Controls.Add((Control) this.txtSubLimits);
    ((Control) this.UltraGroupBox8).Location = new Point(10, 10);
    ((Control) this.UltraGroupBox8).Name = "UltraGroupBox8";
    ((Control) this.UltraGroupBox8).Size = new Size(580, 200);
    ((Control) this.UltraGroupBox8).TabIndex = 7;
    this.UltraGroupBox8.Text = "Sub Limits";
    this.txtSubLimits.AcceptsTab = true;
    this.txtSubLimits.BackColor = Color.White;
    this.txtSubLimits.BorderStyle = BorderStyle.None;
    this.txtSubLimits.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.txtSubLimits.ForeColor = Color.Black;
    this.txtSubLimits.Location = new Point(8, 16 /*0x10*/);
    this.txtSubLimits.Name = "txtSubLimits";
    this.txtSubLimits.Size = new Size(568, 176 /*0xB0*/);
    this.txtSubLimits.TabIndex = 3;
    this.txtSubLimits.Text = "";
    ((Control) this.UltraTabPageControl8).Controls.Add((Control) this.UltraGroupBox7);
    ((Control) this.UltraTabPageControl8).Location = new Point(-10000, -10000);
    ((Control) this.UltraTabPageControl8).Name = "UltraTabPageControl8";
    ((Control) this.UltraTabPageControl8).Size = new Size(756, 248);
    this.UltraGroupBox7.BackColorInternal = Color.FromArgb(240 /*0xF0*/, 247, 253);
    appearance3.BackColor = Color.White;
    appearance3.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.UltraGroupBox7.ContentAreaAppearance = (AppearanceBase) appearance3;
    ((Control) this.UltraGroupBox7).Controls.Add((Control) this.txtDeductible);
    ((Control) this.UltraGroupBox7).Location = new Point(10, 10);
    ((Control) this.UltraGroupBox7).Name = "UltraGroupBox7";
    ((Control) this.UltraGroupBox7).Size = new Size(580, 200);
    ((Control) this.UltraGroupBox7).TabIndex = 7;
    this.UltraGroupBox7.Text = "Deductible";
    this.txtDeductible.AcceptsTab = true;
    this.txtDeductible.BackColor = Color.White;
    this.txtDeductible.BorderStyle = BorderStyle.None;
    this.txtDeductible.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.txtDeductible.ForeColor = Color.Black;
    this.txtDeductible.Location = new Point(5, 16 /*0x10*/);
    this.txtDeductible.Name = "txtDeductible";
    this.txtDeductible.Size = new Size(571, 176 /*0xB0*/);
    this.txtDeductible.TabIndex = 3;
    this.txtDeductible.Text = "";
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.UltraGroupBox1);
    ((Control) this.UltraTabPageControl2).Location = new Point(-10000, -10000);
    ((Control) this.UltraTabPageControl2).Name = "UltraTabPageControl2";
    ((Control) this.UltraTabPageControl2).Size = new Size(756, 248);
    this.UltraGroupBox1.BackColorInternal = Color.FromArgb(240 /*0xF0*/, 247, 253);
    appearance4.BackColor = Color.White;
    appearance4.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.UltraGroupBox1.ContentAreaAppearance = (AppearanceBase) appearance4;
    ((Control) this.UltraGroupBox1).Controls.Add((Control) this.txtPerils);
    ((Control) this.UltraGroupBox1).Location = new Point(10, 10);
    ((Control) this.UltraGroupBox1).Name = "UltraGroupBox1";
    ((Control) this.UltraGroupBox1).Size = new Size(580, 200);
    ((Control) this.UltraGroupBox1).TabIndex = 4;
    this.UltraGroupBox1.Text = "Perils/Coverage";
    this.txtPerils.AcceptsTab = true;
    this.txtPerils.BackColor = Color.White;
    this.txtPerils.BorderStyle = BorderStyle.None;
    this.txtPerils.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.txtPerils.ForeColor = Color.Black;
    this.txtPerils.Location = new Point(5, 15);
    this.txtPerils.Name = "txtPerils";
    this.txtPerils.Size = new Size(570, 180);
    this.txtPerils.TabIndex = 3;
    this.txtPerils.Text = "";
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.UltraGroupBox2);
    ((Control) this.UltraTabPageControl3).Location = new Point(-10000, -10000);
    ((Control) this.UltraTabPageControl3).Name = "UltraTabPageControl3";
    ((Control) this.UltraTabPageControl3).Size = new Size(756, 248);
    this.UltraGroupBox2.BackColorInternal = Color.FromArgb(240 /*0xF0*/, 247, 253);
    appearance5.BackColor = Color.White;
    appearance5.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.UltraGroupBox2.ContentAreaAppearance = (AppearanceBase) appearance5;
    ((Control) this.UltraGroupBox2).Controls.Add((Control) this.txtCovering);
    ((Control) this.UltraGroupBox2).Location = new Point(10, 10);
    ((Control) this.UltraGroupBox2).Name = "UltraGroupBox2";
    ((Control) this.UltraGroupBox2).Size = new Size(580, 200);
    ((Control) this.UltraGroupBox2).TabIndex = 5;
    this.UltraGroupBox2.Text = "Covering";
    this.txtCovering.AcceptsTab = true;
    this.txtCovering.BackColor = Color.White;
    this.txtCovering.BorderStyle = BorderStyle.None;
    this.txtCovering.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.txtCovering.ForeColor = Color.Black;
    this.txtCovering.Location = new Point(5, 16 /*0x10*/);
    this.txtCovering.Name = "txtCovering";
    this.txtCovering.Size = new Size(571, 176 /*0xB0*/);
    this.txtCovering.TabIndex = 3;
    this.txtCovering.Text = "";
    ((Control) this.UltraTabPageControl4).Controls.Add((Control) this.UltraGroupBox3);
    ((Control) this.UltraTabPageControl4).Location = new Point(-10000, -10000);
    ((Control) this.UltraTabPageControl4).Name = "UltraTabPageControl4";
    ((Control) this.UltraTabPageControl4).Size = new Size(756, 248);
    this.UltraGroupBox3.BackColorInternal = Color.FromArgb(240 /*0xF0*/, 247, 253);
    appearance6.BackColor = Color.White;
    appearance6.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.UltraGroupBox3.ContentAreaAppearance = (AppearanceBase) appearance6;
    ((Control) this.UltraGroupBox3).Controls.Add((Control) this.txtValuation);
    ((Control) this.UltraGroupBox3).Location = new Point(10, 10);
    ((Control) this.UltraGroupBox3).Name = "UltraGroupBox3";
    ((Control) this.UltraGroupBox3).Size = new Size(580, 200);
    ((Control) this.UltraGroupBox3).TabIndex = 5;
    this.UltraGroupBox3.Text = "Valuation";
    this.txtValuation.AcceptsTab = true;
    this.txtValuation.BackColor = Color.White;
    this.txtValuation.BorderStyle = BorderStyle.None;
    this.txtValuation.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.txtValuation.ForeColor = Color.Black;
    this.txtValuation.Location = new Point(5, 16 /*0x10*/);
    this.txtValuation.Name = "txtValuation";
    this.txtValuation.Size = new Size(571, 176 /*0xB0*/);
    this.txtValuation.TabIndex = 3;
    this.txtValuation.Text = "";
    ((Control) this.UltraTabPageControl5).Controls.Add((Control) this.UltraGroupBox4);
    ((Control) this.UltraTabPageControl5).Location = new Point(-10000, -10000);
    ((Control) this.UltraTabPageControl5).Name = "UltraTabPageControl5";
    ((Control) this.UltraTabPageControl5).Size = new Size(756, 248);
    this.UltraGroupBox4.BackColorInternal = Color.FromArgb(240 /*0xF0*/, 247, 253);
    appearance7.BackColor = Color.White;
    appearance7.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.UltraGroupBox4.ContentAreaAppearance = (AppearanceBase) appearance7;
    ((Control) this.UltraGroupBox4).Controls.Add((Control) this.txtExcluding);
    ((Control) this.UltraGroupBox4).Location = new Point(10, 10);
    ((Control) this.UltraGroupBox4).Name = "UltraGroupBox4";
    ((Control) this.UltraGroupBox4).Size = new Size(580, 200);
    ((Control) this.UltraGroupBox4).TabIndex = 5;
    this.UltraGroupBox4.Text = "Excluding";
    this.txtExcluding.AcceptsTab = true;
    this.txtExcluding.BackColor = Color.White;
    this.txtExcluding.BorderStyle = BorderStyle.None;
    this.txtExcluding.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.txtExcluding.ForeColor = Color.Black;
    this.txtExcluding.Location = new Point(5, 24);
    this.txtExcluding.Name = "txtExcluding";
    this.txtExcluding.Size = new Size(571, 168);
    this.txtExcluding.TabIndex = 3;
    this.txtExcluding.Text = "";
    ((Control) this.UltraTabPageControl6).Controls.Add((Control) this.UltraGroupBox5);
    ((Control) this.UltraTabPageControl6).Location = new Point(-10000, -10000);
    ((Control) this.UltraTabPageControl6).Name = "UltraTabPageControl6";
    ((Control) this.UltraTabPageControl6).Size = new Size(756, 248);
    this.UltraGroupBox5.BackColorInternal = Color.FromArgb(240 /*0xF0*/, 247, 253);
    appearance8.BackColor = Color.White;
    appearance8.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.UltraGroupBox5.ContentAreaAppearance = (AppearanceBase) appearance8;
    ((Control) this.UltraGroupBox5).Controls.Add((Control) this.txtAdditionalComments);
    ((Control) this.UltraGroupBox5).Location = new Point(10, 10);
    ((Control) this.UltraGroupBox5).Name = "UltraGroupBox5";
    ((Control) this.UltraGroupBox5).Size = new Size(580, 200);
    ((Control) this.UltraGroupBox5).TabIndex = 5;
    this.UltraGroupBox5.Text = "Comments";
    this.txtAdditionalComments.AcceptsTab = true;
    this.txtAdditionalComments.BackColor = Color.White;
    this.txtAdditionalComments.BorderStyle = BorderStyle.None;
    this.txtAdditionalComments.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.txtAdditionalComments.ForeColor = Color.Black;
    this.txtAdditionalComments.Location = new Point(5, 16 /*0x10*/);
    this.txtAdditionalComments.Name = "txtAdditionalComments";
    this.txtAdditionalComments.Size = new Size(571, 176 /*0xB0*/);
    this.txtAdditionalComments.TabIndex = 3;
    this.txtAdditionalComments.Text = "";
    ((Control) this.tabExposure).Controls.Add((Control) this.lnkPremiumAllocation);
    ((Control) this.tabExposure).Controls.Add((Control) this.btnExposure);
    ((Control) this.tabExposure).Controls.Add((Control) this.listExposureLines);
    ((Control) this.tabExposure).Controls.Add((Control) this.Label8);
    ((Control) this.tabExposure).Location = new Point(-10000, -10000);
    ((Control) this.tabExposure).Name = "tabExposure";
    ((Control) this.tabExposure).Size = new Size(756, 248);
    this.lnkPremiumAllocation.AutoSize = true;
    this.lnkPremiumAllocation.BackColor = Color.Transparent;
    this.lnkPremiumAllocation.Location = new Point(10, 220);
    this.lnkPremiumAllocation.Name = "lnkPremiumAllocation";
    this.lnkPremiumAllocation.Size = new Size(298, 13);
    this.lnkPremiumAllocation.TabIndex = 5;
    this.lnkPremiumAllocation.TabStop = true;
    this.lnkPremiumAllocation.Text = "Click here for premium allocation by state, company, and TIV";
    appearance9.BackColor = Color.FromArgb(248, 248, 248);
    appearance9.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance9.BackGradientStyle = (GradientStyle) 2;
    appearance9.BorderColor = Color.DarkGray;
    appearance9.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance9.Image"));
    appearance9.ImageHAlign = (HAlign) 3;
    appearance9.ImageVAlign = (VAlign) 2;
    ((AppearanceBase) appearance9).TextHAlignAsString = "Left";
    ((ControlBase) this.btnExposure).Appearance = (AppearanceBase) appearance9;
    ((Control) this.btnExposure).Location = new Point(260, 168);
    ((Control) this.btnExposure).Name = "btnExposure";
    ((ControlBase) this.btnExposure).Padding = new Size(5, 0);
    ((Control) this.btnExposure).Size = new Size(120, 30);
    ((Control) this.btnExposure).TabIndex = 4;
    ((ControlBase) this.btnExposure).Text = "Go to Exposure";
    this.btnExposure.UseOSThemes = (DefaultableBoolean) 2;
    this.listExposureLines.BackColor = Color.White;
    this.listExposureLines.ForeColor = Color.Black;
    this.listExposureLines.Location = new Point(10, 40);
    this.listExposureLines.MGAStyle = MGAStyles.Blue;
    this.listExposureLines.Name = "listExposureLines";
    this.listExposureLines.Size = new Size(245, 158);
    this.listExposureLines.TabIndex = 3;
    this.Label8.BackColor = Color.Transparent;
    this.Label8.Location = new Point(10, 15);
    this.Label8.Name = "Label8";
    this.Label8.Size = new Size(310, 20);
    this.Label8.TabIndex = 2;
    this.Label8.Text = "Please select the line you would like to enter exposure for:";
    ((Control) this.btnSave).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance10.BackColor = Color.FromArgb(248, 248, 248);
    appearance10.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance10.BackGradientStyle = (GradientStyle) 2;
    appearance10.BorderColor = Color.DarkGray;
    appearance10.FontData.UnderlineAsString = "True";
    appearance10.ForeColor = Color.Blue;
    appearance10.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance10.Image"));
    appearance10.ImageHAlign = (HAlign) 1;
    appearance10.ImageVAlign = (VAlign) 2;
    ((AppearanceBase) appearance10).TextHAlignAsString = "Right";
    ((ControlBase) this.btnSave).Appearance = (AppearanceBase) appearance10;
    ((Control) this.btnSave).Font = new Font("Tahoma", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.btnSave).Location = new Point(673, 574);
    ((Control) this.btnSave).Name = "btnSave";
    ((ControlBase) this.btnSave).Padding = new Size(5, 0);
    ((Control) this.btnSave).Size = new Size(97, 40);
    ((Control) this.btnSave).TabIndex = 213;
    ((ControlBase) this.btnSave).Text = "Save";
    this.btnSave.UseOSThemes = (DefaultableBoolean) 2;
    this.cn.ConnectionString = "Data Source=COLOSQL1;Initial Catalog=GEP;Persist Security Info=True;User ID=erichards";
    this.cn.FireInfoMessageEventOnUserErrors = false;
    this.da.DeleteCommand = this.SqlDeleteCommand2;
    this.da.InsertCommand = this.SqlInsertCommand2;
    this.da.SelectCommand = this.SqlSelectCommand4;
    this.da.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblCarrierPremium", new DataColumnMapping[5]
      {
        new DataColumnMapping("ID", "ID"),
        new DataColumnMapping("QuoteID", "QuoteID"),
        new DataColumnMapping("CompanyLocationGuid", "CompanyLocationGuid"),
        new DataColumnMapping("Premium", "Premium"),
        new DataColumnMapping("TRIAPremium", "TRIAPremium")
      })
    });
    this.da.UpdateCommand = this.SqlUpdateCommand2;
    this.SqlDeleteCommand2.CommandText = "DELETE FROM [dbo].[tblCarrierPremium] WHERE (([ID] = @Original_ID))";
    this.SqlDeleteCommand2.Connection = this.cn;
    this.SqlDeleteCommand2.Parameters.AddRange(new SqlParameter[1]
    {
      new SqlParameter("@Original_ID", SqlDbType.Int, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "ID", DataRowVersion.Original, (object) null)
    });
    this.SqlInsertCommand2.CommandText = componentResourceManager.GetString("SqlInsertCommand2.CommandText");
    this.SqlInsertCommand2.Connection = this.cn;
    this.SqlInsertCommand2.Parameters.AddRange(new SqlParameter[4]
    {
      new SqlParameter("@QuoteID", SqlDbType.Int, 0, "QuoteID"),
      new SqlParameter("@CompanyLocationGuid", SqlDbType.UniqueIdentifier, 0, "CompanyLocationGuid"),
      new SqlParameter("@Premium", SqlDbType.Money, 0, "Premium"),
      new SqlParameter("@TRIAPremium", SqlDbType.Money, 0, "TRIAPremium")
    });
    this.SqlSelectCommand4.CommandText = "SELECT     ID, QuoteID, CompanyLocationGuid, Premium, TRIAPremium\r\nFROM         dbo.tblCarrierPremium\r\nWHERE     (QuoteID = @QuoteID)";
    this.SqlSelectCommand4.Connection = this.cn;
    this.SqlSelectCommand4.Parameters.AddRange(new SqlParameter[1]
    {
      new SqlParameter("@QuoteID", SqlDbType.Int, 4, "QuoteID")
    });
    this.SqlUpdateCommand2.CommandText = componentResourceManager.GetString("SqlUpdateCommand2.CommandText");
    this.SqlUpdateCommand2.Connection = this.cn;
    this.SqlUpdateCommand2.Parameters.AddRange(new SqlParameter[6]
    {
      new SqlParameter("@QuoteID", SqlDbType.Int, 0, "QuoteID"),
      new SqlParameter("@CompanyLocationGuid", SqlDbType.UniqueIdentifier, 0, "CompanyLocationGuid"),
      new SqlParameter("@Premium", SqlDbType.Money, 0, "Premium"),
      new SqlParameter("@TRIAPremium", SqlDbType.Money, 0, "TRIAPremium"),
      new SqlParameter("@Original_ID", SqlDbType.Int, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "ID", DataRowVersion.Original, (object) null),
      new SqlParameter("@ID", SqlDbType.Int, 4, "ID")
    });
    ((Control) this.MgaTab1).Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraTabControlBase) this.MgaTab1).BackColorInternal = Color.White;
    ((Control) this.MgaTab1).Controls.Add((Control) this.UltraTabSharedControlsPage1);
    ((Control) this.MgaTab1).Controls.Add((Control) this.UltraTabPageControl2);
    ((Control) this.MgaTab1).Controls.Add((Control) this.UltraTabPageControl3);
    ((Control) this.MgaTab1).Controls.Add((Control) this.UltraTabPageControl4);
    ((Control) this.MgaTab1).Controls.Add((Control) this.UltraTabPageControl5);
    ((Control) this.MgaTab1).Controls.Add((Control) this.tabExposure);
    ((Control) this.MgaTab1).Controls.Add((Control) this.UltraTabPageControl6);
    ((Control) this.MgaTab1).Controls.Add((Control) this.UltraTabPageControl7);
    ((Control) this.MgaTab1).Controls.Add((Control) this.UltraTabPageControl8);
    ((Control) this.MgaTab1).Controls.Add((Control) this.UltraTabPageControl9);
    ((Control) this.MgaTab1).Location = new Point(12, 280);
    ((Control) this.MgaTab1).Name = "MgaTab1";
    ((UltraTabControlBase) this.MgaTab1).SharedControlsPage = this.UltraTabSharedControlsPage1;
    ((Control) this.MgaTab1).Size = new Size(758, 275);
    ((Control) this.MgaTab1).TabIndex = 214;
    ((UltraTabControlBase) this.MgaTab1).TabLayoutStyle = (TabLayoutStyle) 2;
    ((UltraTabControlBase) this.MgaTab1).TabPadding = new Size(5, 3);
    ultraTab1.TabPage = this.UltraTabPageControl7;
    ultraTab1.Text = "Limit";
    ultraTab2.TabPage = this.UltraTabPageControl9;
    ultraTab2.Text = "Sub Limits";
    ultraTab3.TabPage = this.UltraTabPageControl8;
    ultraTab3.Text = "Deductible";
    ultraTab4.TabPage = this.UltraTabPageControl2;
    ultraTab4.Text = "Perils/Coverage";
    ultraTab5.TabPage = this.UltraTabPageControl3;
    ultraTab5.Text = "Covering";
    ultraTab6.TabPage = this.UltraTabPageControl4;
    ultraTab6.Text = "Valuation";
    ultraTab7.TabPage = this.UltraTabPageControl5;
    ultraTab7.Text = "Excluding";
    ultraTab8.TabPage = this.UltraTabPageControl6;
    ultraTab8.Text = "Comments";
    ultraTab9.TabPage = this.tabExposure;
    ultraTab9.Text = "Exposure";
    ((UltraTabControlBase) this.MgaTab1).Tabs.AddRange(new UltraTab[9]
    {
      ultraTab1,
      ultraTab2,
      ultraTab3,
      ultraTab4,
      ultraTab5,
      ultraTab6,
      ultraTab7,
      ultraTab8,
      ultraTab9
    });
    ((UltraControlBase) this.MgaTab1).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaTab1).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraTabControlBase) this.MgaTab1).ViewStyle = (ViewStyle) 4;
    ((Control) this.UltraTabSharedControlsPage1).Location = new Point(-10000, -10000);
    ((Control) this.UltraTabSharedControlsPage1).Name = "UltraTabSharedControlsPage1";
    ((Control) this.UltraTabSharedControlsPage1).Size = new Size(756, 248);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.linkEndorsementOffsets);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.linkOffsetTransaction);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.lnkNewOption);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.Label9);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.lnkFCW);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.Label2);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.Label1);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.Label6);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.Label5);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.Label3);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.Label7);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.Label4);
    ((Control) this.UltraTabPageControl1).Location = new Point(-10000, -10000);
    ((Control) this.UltraTabPageControl1).Name = "UltraTabPageControl1";
    ((Control) this.UltraTabPageControl1).Size = new Size(763, 248);
    this.linkEndorsementOffsets.AutoSize = true;
    this.linkEndorsementOffsets.Location = new Point(636, 73);
    this.linkEndorsementOffsets.Name = "linkEndorsementOffsets";
    this.linkEndorsementOffsets.Size = new Size(105, 13);
    this.linkEndorsementOffsets.TabIndex = 24;
    this.linkEndorsementOffsets.TabStop = true;
    this.linkEndorsementOffsets.Text = "Endorsement Offsets";
    this.linkEndorsementOffsets.TextAlign = ContentAlignment.MiddleLeft;
    this.linkOffsetTransaction.AutoSize = true;
    this.linkOffsetTransaction.Location = new Point(574, 46);
    this.linkOffsetTransaction.Name = "linkOffsetTransaction";
    this.linkOffsetTransaction.Size = new Size(165, 13);
    this.linkOffsetTransaction.TabIndex = 22;
    this.linkOffsetTransaction.TabStop = true;
    this.linkOffsetTransaction.Text = "Offset Prior Monetary Transaction";
    this.linkOffsetTransaction.TextAlign = ContentAlignment.MiddleLeft;
    this.lnkNewOption.AutoSize = true;
    this.lnkNewOption.BackColor = Color.Transparent;
    this.lnkNewOption.Location = new Point(660, 19);
    this.lnkNewOption.Name = "lnkNewOption";
    this.lnkNewOption.Size = new Size(85, 13);
    this.lnkNewOption.TabIndex = 21;
    this.lnkNewOption.TabStop = true;
    this.lnkNewOption.Text = "Add New Option";
    this.lnkNewOption.TextAlign = ContentAlignment.MiddleLeft;
    this.Label9.AutoSize = true;
    this.Label9.BackColor = Color.Transparent;
    this.Label9.Location = new Point(12, 97);
    this.Label9.Name = "Label9";
    this.Label9.Size = new Size(54, 13);
    this.Label9.TabIndex = 19;
    this.Label9.Text = "Company:";
    this.Label9.TextAlign = ContentAlignment.MiddleRight;
    this.lnkFCW.AutoSize = true;
    this.lnkFCW.BackColor = Color.Transparent;
    this.lnkFCW.Location = new Point(75, 225);
    this.lnkFCW.Name = "lnkFCW";
    this.lnkFCW.Size = new Size(145, 13);
    this.lnkFCW.TabIndex = 18;
    this.lnkFCW.TabStop = true;
    this.lnkFCW.Text = "Forms/Conditions/Warranties";
    this.Label2.AutoSize = true;
    this.Label2.BackColor = Color.Transparent;
    this.Label2.Location = new Point(15, 147);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(50, 13);
    this.Label2.TabIndex = 2;
    this.Label2.Text = "Premium:";
    this.Label2.TextAlign = ContentAlignment.MiddleRight;
    this.Label1.AutoSize = true;
    this.Label1.BackColor = Color.Transparent;
    this.Label1.Location = new Point(33, 122);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(35, 13);
    this.Label1.TabIndex = 0;
    this.Label1.Text = "State:";
    this.Label1.TextAlign = ContentAlignment.MiddleRight;
    this.Label6.AutoSize = true;
    this.Label6.BackColor = Color.Transparent;
    this.Label6.Location = new Point(28, 71);
    this.Label6.Name = "Label6";
    this.Label6.Size = new Size(40, 13);
    this.Label6.TabIndex = 10;
    this.Label6.Text = "Factor:";
    this.Label6.TextAlign = ContentAlignment.MiddleRight;
    this.Label5.AutoSize = true;
    this.Label5.BackColor = Color.Transparent;
    this.Label5.Location = new Point(16 /*0x10*/, 46);
    this.Label5.Name = "Label5";
    this.Label5.Size = new Size(52, 13);
    this.Label5.TabIndex = 8;
    this.Label5.Text = "Effective:";
    this.Label5.TextAlign = ContentAlignment.MiddleRight;
    this.Label3.AutoSize = true;
    this.Label3.BackColor = Color.Transparent;
    this.Label3.Location = new Point(30, 172);
    this.Label3.Name = "Label3";
    this.Label3.Size = new Size(38, 13);
    this.Label3.TabIndex = 4;
    this.Label3.Text = "Office:";
    this.Label3.TextAlign = ContentAlignment.MiddleRight;
    this.Label7.AutoSize = true;
    this.Label7.BackColor = Color.Transparent;
    this.Label7.Location = new Point(10, 19);
    this.Label7.Name = "Label7";
    this.Label7.Size = new Size(58, 13);
    this.Label7.TabIndex = 14;
    this.Label7.Text = "Calc Type:";
    this.Label7.TextAlign = ContentAlignment.MiddleRight;
    this.Label4.AutoSize = true;
    this.Label4.BackColor = Color.Transparent;
    this.Label4.Location = new Point(20, 197);
    this.Label4.Name = "Label4";
    this.Label4.Size = new Size(46, 13);
    this.Label4.TabIndex = 7;
    this.Label4.Text = "Amount:";
    this.Label4.TextAlign = ContentAlignment.MiddleRight;
    this.daGenericLimits.DeleteCommand = this.SqlDeleteCommand3;
    this.daGenericLimits.InsertCommand = this.SqlInsertCommand3;
    this.daGenericLimits.SelectCommand = this.SqlSelectCommand3;
    this.daGenericLimits.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblGenericLimits", new DataColumnMapping[9]
      {
        new DataColumnMapping("QuoteID", "QuoteID"),
        new DataColumnMapping("Limit", "Limit"),
        new DataColumnMapping("SubLimits", "SubLimits"),
        new DataColumnMapping("Perils", "Perils"),
        new DataColumnMapping("Covering", "Covering"),
        new DataColumnMapping("Deductible", "Deductible"),
        new DataColumnMapping("Valuation", "Valuation"),
        new DataColumnMapping("Excluding", "Excluding"),
        new DataColumnMapping("AdditionalComments", "AdditionalComments")
      })
    });
    this.daGenericLimits.UpdateCommand = this.SqlUpdateCommand3;
    this.SqlDeleteCommand3.CommandText = "DELETE FROM dbo.tblGenericLimits WHERE (QuoteID = @Original_QuoteID)";
    this.SqlDeleteCommand3.Connection = this.cn;
    this.SqlDeleteCommand3.Parameters.AddRange(new SqlParameter[1]
    {
      new SqlParameter("@Original_QuoteID", SqlDbType.Int, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "QuoteID", DataRowVersion.Original, (object) null)
    });
    this.SqlInsertCommand3.CommandText = componentResourceManager.GetString("SqlInsertCommand3.CommandText");
    this.SqlInsertCommand3.Connection = this.cn;
    this.SqlInsertCommand3.Parameters.AddRange(new SqlParameter[9]
    {
      new SqlParameter("@QuoteID", SqlDbType.Int, 4, "QuoteID"),
      new SqlParameter("@Limit", SqlDbType.VarChar, int.MaxValue, "Limit"),
      new SqlParameter("@SubLimits", SqlDbType.VarChar, int.MaxValue, "SubLimits"),
      new SqlParameter("@Perils", SqlDbType.VarChar, int.MaxValue, "Perils"),
      new SqlParameter("@Covering", SqlDbType.VarChar, int.MaxValue, "Covering"),
      new SqlParameter("@Deductible", SqlDbType.VarChar, int.MaxValue, "Deductible"),
      new SqlParameter("@Valuation", SqlDbType.VarChar, int.MaxValue, "Valuation"),
      new SqlParameter("@Excluding", SqlDbType.VarChar, int.MaxValue, "Excluding"),
      new SqlParameter("@AdditionalComments", SqlDbType.VarChar, int.MaxValue, "AdditionalComments")
    });
    this.SqlSelectCommand3.CommandText = "SELECT QuoteID, Limit, SubLimits, Perils, Covering, Deductible, Valuation, Excluding, AdditionalComments FROM dbo.tblGenericLimits WHERE (QuoteID = @QuoteID)";
    this.SqlSelectCommand3.Connection = this.cn;
    this.SqlSelectCommand3.Parameters.AddRange(new SqlParameter[1]
    {
      new SqlParameter("@QuoteID", SqlDbType.Int, 4, "QuoteID")
    });
    this.SqlUpdateCommand3.CommandText = componentResourceManager.GetString("SqlUpdateCommand3.CommandText");
    this.SqlUpdateCommand3.Connection = this.cn;
    this.SqlUpdateCommand3.Parameters.AddRange(new SqlParameter[10]
    {
      new SqlParameter("@QuoteID", SqlDbType.Int, 4, "QuoteID"),
      new SqlParameter("@Limit", SqlDbType.VarChar, int.MaxValue, "Limit"),
      new SqlParameter("@SubLimits", SqlDbType.VarChar, int.MaxValue, "SubLimits"),
      new SqlParameter("@Perils", SqlDbType.VarChar, int.MaxValue, "Perils"),
      new SqlParameter("@Covering", SqlDbType.VarChar, int.MaxValue, "Covering"),
      new SqlParameter("@Deductible", SqlDbType.VarChar, int.MaxValue, "Deductible"),
      new SqlParameter("@Valuation", SqlDbType.VarChar, int.MaxValue, "Valuation"),
      new SqlParameter("@Excluding", SqlDbType.VarChar, int.MaxValue, "Excluding"),
      new SqlParameter("@AdditionalComments", SqlDbType.VarChar, int.MaxValue, "AdditionalComments"),
      new SqlParameter("@Original_QuoteID", SqlDbType.Int, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "QuoteID", DataRowVersion.Original, (object) null)
    });
    this.lnkOffset.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkOffset.AutoSize = true;
    this.lnkOffset.BackColor = Color.Transparent;
    this.lnkOffset.Location = new Point(10, 587);
    this.lnkOffset.Name = "lnkOffset";
    this.lnkOffset.Size = new Size(171, 13);
    this.lnkOffset.TabIndex = 215;
    this.lnkOffset.TabStop = true;
    this.lnkOffset.Text = "Offset Prior Monetary Transaction";
    this.lnkOffset.TextAlign = ContentAlignment.MiddleLeft;
    ((Control) this.ugCarriers).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraControlBase) this.ugCarriers).Cursor = Cursors.Hand;
    ((UltraGridBase) this.ugCarriers).DataMember = "dtPropertyInfo";
    ((UltraGridBase) this.ugCarriers).DataSource = (object) this.ds;
    appearance11.BackColor = Color.White;
    appearance11.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.ugCarriers).DisplayLayout.Appearance = (AppearanceBase) appearance11;
    ((UltraGridBase) this.ugCarriers).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Width = 247;
    ((AppearanceBase) appearance12).TextHAlignAsString = "Right";
    ultraGridColumn2.CellAppearance = (AppearanceBase) appearance12;
    ultraGridColumn2.Format = "c";
    ultraGridColumn2.Header.VisiblePosition = 1;
    ultraGridColumn2.Width = 80 /*0x50*/;
    ((AppearanceBase) appearance13).TextHAlignAsString = "Right";
    ultraGridColumn3.CellAppearance = (AppearanceBase) appearance13;
    ultraGridColumn3.Format = "c";
    ((HeaderBase) ultraGridColumn3.Header).Caption = "TRIA Premium";
    ultraGridColumn3.Header.VisiblePosition = 2;
    ultraGridColumn3.Width = 82;
    ultraGridColumn4.Header.VisiblePosition = 3;
    ultraGridColumn4.Hidden = true;
    ultraGridColumn4.Width = 264;
    ((AppearanceBase) appearance14).TextHAlignAsString = "Right";
    ultraGridColumn5.CellAppearance = (AppearanceBase) appearance14;
    ultraGridColumn5.Format = "c";
    ((HeaderBase) ultraGridColumn5.Header).Caption = "Fees";
    ultraGridColumn5.Header.VisiblePosition = 4;
    ultraGridColumn5.Width = 78;
    ((AppearanceBase) appearance15).TextHAlignAsString = "Right";
    ultraGridColumn6.CellAppearance = (AppearanceBase) appearance15;
    ultraGridColumn6.Format = "c";
    ultraGridColumn6.Header.VisiblePosition = 5;
    ultraGridColumn6.Width = 90;
    ((AppearanceBase) appearance16).TextHAlignAsString = "Right";
    ultraGridColumn7.CellAppearance = (AppearanceBase) appearance16;
    ultraGridColumn7.Format = "";
    ultraGridColumn7.Header.VisiblePosition = 6;
    ultraGridColumn7.Width = 102;
    ((AppearanceBase) appearance17).TextHAlignAsString = "Center";
    ultraGridColumn8.CellAppearance = (AppearanceBase) appearance17;
    ((HeaderBase) ultraGridColumn8.Header).Caption = "Add Fees";
    ultraGridColumn8.Header.VisiblePosition = 7;
    ultraGridColumn8.Width = 77;
    ultraGridBand.Columns.AddRange(new object[8]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3,
      (object) ultraGridColumn4,
      (object) ultraGridColumn5,
      (object) ultraGridColumn6,
      (object) ultraGridColumn7,
      (object) ultraGridColumn8
    });
    ((AppearanceBase) appearance18).TextHAlignAsString = "Right";
    summarySettings1.Appearance = (AppearanceBase) appearance18;
    summarySettings1.DisplayFormat = "{0:c}";
    summarySettings1.GroupBySummaryValueAppearance = (AppearanceBase) appearance19;
    ((AppearanceBase) appearance20).TextHAlignAsString = "Right";
    summarySettings2.Appearance = (AppearanceBase) appearance20;
    summarySettings2.DisplayFormat = "{0:c}";
    summarySettings2.GroupBySummaryValueAppearance = (AppearanceBase) appearance21;
    ((AppearanceBase) appearance22).TextHAlignAsString = "Right";
    summarySettings3.Appearance = (AppearanceBase) appearance22;
    summarySettings3.DisplayFormat = "{0:c}";
    summarySettings3.GroupBySummaryValueAppearance = (AppearanceBase) appearance23;
    ultraGridBand.Summaries.AddRange(new SummarySettings[3]
    {
      summarySettings1,
      summarySettings2,
      summarySettings3
    });
    ((UltraGridBase) this.ugCarriers).DisplayLayout.BandsSerializer.Add((object) ultraGridBand);
    ((UltraGridBase) this.ugCarriers).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance24.BackColor = Color.LightSteelBlue;
    appearance24.FontData.SizeInPoints = 10f;
    appearance24.ForeColor = Color.Black;
    ((UltraGridBase) this.ugCarriers).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance24;
    appearance25.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance25.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance25.ForeColor = Color.Black;
    ((UltraGridBase) this.ugCarriers).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance25;
    ((UltraGridBase) this.ugCarriers).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.ugCarriers).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.ugCarriers).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 1;
    appearance26.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugCarriers).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance26;
    ((UltraGridBase) this.ugCarriers).DisplayLayout.Override.CellClickAction = (CellClickAction) 1;
    appearance27.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.ugCarriers).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance27;
    ((UltraGridBase) this.ugCarriers).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance28.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.ugCarriers).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance28;
    appearance29.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugCarriers).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance29;
    ((UltraGridBase) this.ugCarriers).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance30.BackColor = Color.Transparent;
    appearance30.ForeColor = Color.Black;
    ((UltraGridBase) this.ugCarriers).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance30;
    ((UltraGridBase) this.ugCarriers).DisplayLayout.Override.SelectTypeCell = (SelectType) 2;
    scrollBarLook.ViewStyle = (ScrollBarViewStyle) 3;
    ((UltraGridBase) this.ugCarriers).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((Control) this.ugCarriers).Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.ugCarriers).Location = new Point(12, 12);
    ((Control) this.ugCarriers).Name = "ugCarriers";
    ((Control) this.ugCarriers).Size = new Size(758, 262);
    ((Control) this.ugCarriers).TabIndex = 6;
    ((Control) this.ugCarriers).Text = "Carriers";
    ((UltraControlBase) this.ugCarriers).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.ugCarriers).UseOsThemes = (DefaultableBoolean) 2;
    this.ds.DataSetName = "dsGenericMultiRater";
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.lblPart.AutoSize = true;
    this.lblPart.BackColor = Color.Transparent;
    this.lblPart.Location = new Point(227, 587);
    this.lblPart.Name = "lblPart";
    this.lblPart.Size = new Size(106, 13);
    this.lblPart.TabIndex = 216;
    this.lblPart.Text = "Actual Participation: ";
    this.lblParticipationPercentage.AutoSize = true;
    this.lblParticipationPercentage.BackColor = Color.Transparent;
    this.lblParticipationPercentage.Location = new Point(339, 587);
    this.lblParticipationPercentage.Name = "lblParticipationPercentage";
    this.lblParticipationPercentage.Size = new Size(41, 13);
    this.lblParticipationPercentage.TabIndex = 217;
    this.lblParticipationPercentage.Text = "0.0000";
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    this.ClientSize = new Size(782, 623);
    this.Controls.Add((Control) this.lblParticipationPercentage);
    this.Controls.Add((Control) this.lblPart);
    this.Controls.Add((Control) this.lnkOffset);
    this.Controls.Add((Control) this.MgaTab1);
    this.Controls.Add((Control) this.btnSave);
    this.Controls.Add((Control) this.ugCarriers);
    this.Name = nameof (FormGenericMultiCarrierRater);
    this.Text = "Generic Multi-Carrier Rater";
    this.Controls.SetChildIndex((Control) this.ugCarriers, 0);
    this.Controls.SetChildIndex((Control) this.btnSave, 0);
    this.Controls.SetChildIndex((Control) this.MgaTab1, 0);
    this.Controls.SetChildIndex((Control) this.lnkOffset, 0);
    this.Controls.SetChildIndex((Control) this.lblPart, 0);
    this.Controls.SetChildIndex((Control) this.lblParticipationPercentage, 0);
    ((Control) this.UltraTabPageControl7).ResumeLayout(false);
    ((ISupportInitialize) this.UltraGroupBox6).EndInit();
    ((Control) this.UltraGroupBox6).ResumeLayout(false);
    ((Control) this.UltraTabPageControl9).ResumeLayout(false);
    ((ISupportInitialize) this.UltraGroupBox8).EndInit();
    ((Control) this.UltraGroupBox8).ResumeLayout(false);
    ((Control) this.UltraTabPageControl8).ResumeLayout(false);
    ((ISupportInitialize) this.UltraGroupBox7).EndInit();
    ((Control) this.UltraGroupBox7).ResumeLayout(false);
    ((Control) this.UltraTabPageControl2).ResumeLayout(false);
    ((ISupportInitialize) this.UltraGroupBox1).EndInit();
    ((Control) this.UltraGroupBox1).ResumeLayout(false);
    ((Control) this.UltraTabPageControl3).ResumeLayout(false);
    ((ISupportInitialize) this.UltraGroupBox2).EndInit();
    ((Control) this.UltraGroupBox2).ResumeLayout(false);
    ((Control) this.UltraTabPageControl4).ResumeLayout(false);
    ((ISupportInitialize) this.UltraGroupBox3).EndInit();
    ((Control) this.UltraGroupBox3).ResumeLayout(false);
    ((Control) this.UltraTabPageControl5).ResumeLayout(false);
    ((ISupportInitialize) this.UltraGroupBox4).EndInit();
    ((Control) this.UltraGroupBox4).ResumeLayout(false);
    ((Control) this.UltraTabPageControl6).ResumeLayout(false);
    ((ISupportInitialize) this.UltraGroupBox5).EndInit();
    ((Control) this.UltraGroupBox5).ResumeLayout(false);
    ((Control) this.tabExposure).ResumeLayout(false);
    ((Control) this.tabExposure).PerformLayout();
    ((ISupportInitialize) this.btnExposure).EndInit();
    ((ISupportInitialize) this.listExposureLines).EndInit();
    ((ISupportInitialize) this.btnSave).EndInit();
    ((ISupportInitialize) this.MgaTab1).EndInit();
    ((Control) this.MgaTab1).ResumeLayout(false);
    ((Control) this.UltraTabPageControl1).ResumeLayout(false);
    ((Control) this.UltraTabPageControl1).PerformLayout();
    ((ISupportInitialize) this.ugCarriers).EndInit();
    this.ds.EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  [field: AccessedThroughProperty("ds")]
  protected virtual dsGenericMultiRater ds { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cn")]
  private virtual SqlConnection cn { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("da")]
  private virtual SqlDataAdapter da { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlDeleteCommand2")]
  private virtual SqlCommand SqlDeleteCommand2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlInsertCommand2")]
  private virtual SqlCommand SqlInsertCommand2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlSelectCommand4")]
  private virtual SqlCommand SqlSelectCommand4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlUpdateCommand2")]
  private virtual SqlCommand SqlUpdateCommand2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected virtual UltraTabControl MgaTab1
  {
    get => this._MgaTab1;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      SelectedTabChangedEventHandler changedEventHandler = new SelectedTabChangedEventHandler(this.MgaTab1_SelectedTabChanged);
      UltraTabControl mgaTab1_1 = this._MgaTab1;
      if (mgaTab1_1 != null)
        ((UltraTabControlBase) mgaTab1_1).SelectedTabChanged -= changedEventHandler;
      this._MgaTab1 = value;
      UltraTabControl mgaTab1_2 = this._MgaTab1;
      if (mgaTab1_2 == null)
        return;
      ((UltraTabControlBase) mgaTab1_2).SelectedTabChanged += changedEventHandler;
    }
  }

  [field: AccessedThroughProperty("UltraTabSharedControlsPage1")]
  protected virtual UltraTabSharedControlsPage UltraTabSharedControlsPage1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraGroupBox1")]
  protected virtual UltraGroupBox UltraGroupBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtPerils")]
  protected virtual RichTextBox txtPerils { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraGroupBox2")]
  protected virtual UltraGroupBox UltraGroupBox2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtCovering")]
  protected virtual RichTextBox txtCovering { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraGroupBox3")]
  protected virtual UltraGroupBox UltraGroupBox3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtValuation")]
  protected virtual RichTextBox txtValuation { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraGroupBox4")]
  protected virtual UltraGroupBox UltraGroupBox4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtExcluding")]
  protected virtual RichTextBox txtExcluding { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label8")]
  protected virtual Label Label8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraGroupBox5")]
  protected virtual UltraGroupBox UltraGroupBox5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtAdditionalComments")]
  protected virtual RichTextBox txtAdditionalComments { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraTabPageControl1")]
  protected virtual UltraTabPageControl UltraTabPageControl1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("linkEndorsementOffsets")]
  protected virtual LinkLabel linkEndorsementOffsets { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("linkOffsetTransaction")]
  protected virtual LinkLabel linkOffsetTransaction { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lnkNewOption")]
  protected virtual LinkLabel lnkNewOption { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label9")]
  protected virtual Label Label9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lnkFCW")]
  protected virtual LinkLabel lnkFCW { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label2")]
  protected virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label1")]
  protected virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label6")]
  protected virtual Label Label6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label5")]
  protected virtual Label Label5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label3")]
  protected virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label7")]
  protected virtual Label Label7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label4")]
  protected virtual Label Label4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("daGenericLimits")]
  protected virtual SqlDataAdapter daGenericLimits { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlDeleteCommand3")]
  protected virtual SqlCommand SqlDeleteCommand3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlInsertCommand3")]
  protected virtual SqlCommand SqlInsertCommand3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlSelectCommand3")]
  protected virtual SqlCommand SqlSelectCommand3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlUpdateCommand3")]
  protected virtual SqlCommand SqlUpdateCommand3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected virtual UltraGrid ugCarriers
  {
    get => this._ugCarriers;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ugCarriers_AfterRowActivate);
      UltraGrid ugCarriers1 = this._ugCarriers;
      if (ugCarriers1 != null)
        ugCarriers1.AfterRowActivate -= eventHandler;
      this._ugCarriers = value;
      UltraGrid ugCarriers2 = this._ugCarriers;
      if (ugCarriers2 == null)
        return;
      ugCarriers2.AfterRowActivate += eventHandler;
    }
  }

  protected virtual MGAButton btnSave
  {
    get => this._btnSave;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnSave_Click);
      MGAButton btnSave1 = this._btnSave;
      if (btnSave1 != null)
        ((Control) btnSave1).Click -= eventHandler;
      this._btnSave = value;
      MGAButton btnSave2 = this._btnSave;
      if (btnSave2 == null)
        return;
      ((Control) btnSave2).Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("UltraTabPageControl2")]
  protected virtual UltraTabPageControl UltraTabPageControl2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraTabPageControl3")]
  protected virtual UltraTabPageControl UltraTabPageControl3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraTabPageControl4")]
  protected virtual UltraTabPageControl UltraTabPageControl4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraTabPageControl5")]
  protected virtual UltraTabPageControl UltraTabPageControl5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("tabExposure")]
  protected virtual UltraTabPageControl tabExposure { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lnkPremiumAllocation")]
  protected virtual LinkLabel lnkPremiumAllocation { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected virtual MGAButton btnExposure
  {
    get => this._btnExposure;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnExposure_Click);
      MGAButton btnExposure1 = this._btnExposure;
      if (btnExposure1 != null)
        ((Control) btnExposure1).Click -= eventHandler;
      this._btnExposure = value;
      MGAButton btnExposure2 = this._btnExposure;
      if (btnExposure2 == null)
        return;
      ((Control) btnExposure2).Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("listExposureLines")]
  protected virtual MGAListBox listExposureLines { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraTabPageControl6")]
  protected virtual UltraTabPageControl UltraTabPageControl6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraTabPageControl7")]
  protected virtual UltraTabPageControl UltraTabPageControl7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraGroupBox6")]
  protected virtual UltraGroupBox UltraGroupBox6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtLimit")]
  protected virtual RichTextBox txtLimit { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraTabPageControl8")]
  protected virtual UltraTabPageControl UltraTabPageControl8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraGroupBox7")]
  protected virtual UltraGroupBox UltraGroupBox7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtDeductible")]
  protected virtual RichTextBox txtDeductible { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraTabPageControl9")]
  protected virtual UltraTabPageControl UltraTabPageControl9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraGroupBox8")]
  protected virtual UltraGroupBox UltraGroupBox8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtSubLimits")]
  protected virtual RichTextBox txtSubLimits { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected virtual LinkLabel lnkOffset
  {
    get => this._lnkOffset;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkOffset_LinkClicked);
      LinkLabel lnkOffset1 = this._lnkOffset;
      if (lnkOffset1 != null)
        lnkOffset1.LinkClicked -= clickedEventHandler;
      this._lnkOffset = value;
      LinkLabel lnkOffset2 = this._lnkOffset;
      if (lnkOffset2 == null)
        return;
      lnkOffset2.LinkClicked += clickedEventHandler;
    }
  }

  [field: AccessedThroughProperty("lblPart")]
  internal virtual Label lblPart { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblParticipationPercentage")]
  internal virtual Label lblParticipationPercentage { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected virtual HyperlinkEditor tempLink
  {
    get => this._tempLink;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      CancelEventHandler cancelEventHandler = new CancelEventHandler(this._hlk_HyperLinkOpening);
      HyperlinkEditor tempLink1 = this._tempLink;
      if (tempLink1 != null)
        tempLink1.HyperLinkOpening -= cancelEventHandler;
      this._tempLink = value;
      HyperlinkEditor tempLink2 = this._tempLink;
      if (tempLink2 == null)
        return;
      tempLink2.HyperLinkOpening += cancelEventHandler;
    }
  }

  public FormGenericMultiCarrierRater()
  {
    this.Load += new EventHandler(this.FormGenericMultiCarrierRater_Load);
    this.tempLink = new HyperlinkEditor();
    this.InitializeComponent();
    this.cn.ConnectionString = CurrentUser.Instance.ConnectionString;
    ((UltraGridBase) this.ugCarriers).DisplayLayout.Bands[0].Columns["AddFees"].Editor = (EmbeddableEditorBase) this.tempLink;
    ((UltraGridBase) this.ugCarriers).UpdateData();
  }

  private void FormGenericMultiCarrierRater_Load(object sender, EventArgs e)
  {
    if (this.DesignMode)
      return;
    this._quoteGuid = this.Rater.QuoteGuid;
    this._quoteID = this.Rater.Quote.QuoteID;
    this.FillData();
    if (this.ds.tblGenericLimits.Count == 0)
      this.AddGenericRow();
    else
      this.ShowLimitWording();
    ((UltraGridBase) this.ugCarriers).UpdateData();
    ((UltraGridBase) this.ugCarriers).DisplayLayout.Bands[0].Columns["Participation"].Format = "p";
    ((UltraGridBase) this.ugCarriers).DisplayLayout.Bands[0].Columns["Participation"].MaskInput = "nnn.nnnnnnn%";
    this.FormLoadOnClient();
  }

  private void FillDefaults()
  {
    Decimal d1_1 = 0M;
    Decimal num1 = 0M;
    Decimal num2 = 0M;
    try
    {
      foreach (dsGenericMultiRater.dtPropertyInfoRow row in this.ds.dtPropertyInfo.Rows)
      {
        if (!row.IsFeeAmountNull())
          num1 = Decimal.Add(num1, row.FeeAmount);
        if (!row.IsPremiumNull())
          d1_1 = Decimal.Add(d1_1, row.Premium);
        if (!row.IsTRIAPremiumNull())
          num2 = Decimal.Add(num2, row.TRIAPremium);
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    try
    {
      foreach (dsGenericMultiRater.dtPropertyInfoRow row in this.ds.dtPropertyInfo.Rows)
      {
        dsGenericMultiRater.tblMultiCarrierRaterDataRow locationGuidQuoteId = this.ds.tblMultiCarrierRaterData.FindByCompanyLocationGuidQuoteID(row.CompanyLocationGuid, this._quoteID);
        Decimal d1_2 = 0M;
        Decimal d2_1 = 0M;
        Decimal d2_2 = 0M;
        if (!row.IsPremiumNull())
          d1_2 = row.Premium;
        if (!row.IsFeeAmountNull())
          d2_1 = row.FeeAmount;
        if (!row.IsTRIAPremiumNull())
          d2_2 = row.TRIAPremium;
        if (locationGuidQuoteId != null && !locationGuidQuoteId.IsLimitNull())
          row.Limit = locationGuidQuoteId.Limit;
        if (locationGuidQuoteId != null && !locationGuidQuoteId.IsParticipationNull())
        {
          if (Decimal.Compare(locationGuidQuoteId.Participation, 0M) != 0)
            row.Participation = locationGuidQuoteId.Participation;
          else if (Decimal.Compare(Decimal.Add(Decimal.Add(d1_1, num1), num2), 0M) != 0)
            row.Participation = Decimal.Divide(Decimal.Add(Decimal.Add(d1_2, d2_1), d2_2), Decimal.Add(Decimal.Add(d1_1, num1), num2));
        }
        else if (Decimal.Compare(Decimal.Add(Decimal.Add(d1_1, num1), num2), 0M) != 0)
          row.Participation = Decimal.Divide(Decimal.Add(Decimal.Add(d1_2, d2_1), d2_2), Decimal.Add(Decimal.Add(d1_1, num1), num2));
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    ((UltraGridBase) this.ugCarriers).UpdateData();
  }

  protected virtual void FormLoadOnClient()
  {
  }

  private void FillData()
  {
    this.ds.dtPropertyInfo.Clear();
    this.ds.tblCarrierPremium.Clear();
    this.ds.tblGenericLimits.Clear();
    this.ds.tblMultiCarrierRaterData.Clear();
    string[] strArray = new string[4]
    {
      "dtPropertyInfo",
      "tblCarrierPremium",
      "tblGenericLimits",
      "tblMultiCarrierRaterData"
    };
    try
    {
      DefaultDatabase.LoadDataSet((DataSet) this.ds, strArray, "GetGenericMultiCarrierRaterData", new object[2]
      {
        (object) "@QuoteGuid",
        (object) this._quoteGuid
      });
    }
    catch (ConstraintException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      ErrorHandler.ShowDataSetErrors((DataSet) this.ds, ex);
      ProjectData.ClearProjectError();
    }
    try
    {
      foreach (dsGenericMultiRater.tblCarrierPremiumRow row in this.ds.tblCarrierPremium.Rows)
      {
        dsGenericMultiRater.dtPropertyInfoRow companyLocationGuid = this.ds.dtPropertyInfo.FindByCompanyLocationGuid(row.CompanyLocationGuid);
        if (companyLocationGuid != null)
        {
          if (!row.IsPremiumNull())
            companyLocationGuid.Premium = row.Premium;
          if (!row.IsTRIAPremiumNull())
            companyLocationGuid.TRIAPremium = row.TRIAPremium;
        }
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    this.FillDefaults();
    ((UltraGridBase) this.ugCarriers).DisplayLayout.ScrollBounds = (ScrollBounds) 0;
  }

  private void AddGenericRow()
  {
    dsGenericMultiRater.tblGenericLimitsRow row = this.ds.tblGenericLimits.NewtblGenericLimitsRow();
    row.QuoteID = this.Rater.Quote.QuoteID;
    object objectValue = RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT QuoteAdditionalComments FROM tblCompanyLines WITH(NOLOCK) WHERE CompanyLineGUID = dbo.GetQuoteCompanyLineGuid(@QuoteGuid)", new object[2]
    {
      (object) "@QuoteGuid",
      (object) this.Rater.QuoteGuid
    }));
    if (objectValue == DBNull.Value)
      row.SetAdditionalCommentsNull();
    else
      row.AdditionalComments = objectValue.ToString();
    DataRow dataRow = DefaultDatabase.ExecuteDataRow(CommandType.Text, "SELECT Perils, Covering, Valuation, Excluding, Comments  FROM tblCompanyLineGenericQuoteWording WHERE CompanyLineID=@CompanyLineID", new object[2]
    {
      (object) "@CompanyLineID",
      (object) this.Rater.Quote.CompanyLine.CompanyLineID
    });
    if (dataRow != null)
    {
      dsGenericMultiRater.tblGenericLimitsRow genericLimitsRow = row;
      if (dataRow["Perils"] != DBNull.Value)
        genericLimitsRow.Perils = (string) dataRow["Perils"];
      if (dataRow["Covering"] != DBNull.Value)
        genericLimitsRow.Covering = (string) dataRow["Covering"];
      if (dataRow["Valuation"] != DBNull.Value)
        genericLimitsRow.Valuation = (string) dataRow["Valuation"];
      if (dataRow["Excluding"] != DBNull.Value)
        genericLimitsRow.Excluding = (string) dataRow["Excluding"];
      if (dataRow["Comments"] != DBNull.Value)
        genericLimitsRow.AdditionalComments = (string) dataRow["Comments"];
    }
    this.ds.tblGenericLimits.AddtblGenericLimitsRow(row);
  }

  private void ShowLimitWording()
  {
    if (this.ds.tblGenericLimits.Count <= 0)
      return;
    dsGenericMultiRater.tblGenericLimitsRow tblGenericLimit = this.ds.tblGenericLimits[0];
    if (tblGenericLimit.IsPerilsNull())
    {
      this.txtPerils.Text = string.Empty;
    }
    else
    {
      try
      {
        this.txtPerils.Rtf = tblGenericLimit.Perils;
      }
      catch (ArgumentException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        this.txtPerils.Text = tblGenericLimit.Perils;
        ProjectData.ClearProjectError();
      }
    }
    if (tblGenericLimit.IsCoveringNull())
    {
      this.txtCovering.Text = string.Empty;
    }
    else
    {
      try
      {
        this.txtCovering.Rtf = tblGenericLimit.Covering;
      }
      catch (ArgumentException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        this.txtCovering.Text = tblGenericLimit.Covering;
        ProjectData.ClearProjectError();
      }
    }
    if (tblGenericLimit.IsValuationNull())
    {
      this.txtValuation.Text = string.Empty;
    }
    else
    {
      try
      {
        this.txtValuation.Rtf = tblGenericLimit.Valuation;
      }
      catch (ArgumentException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        this.txtValuation.Text = tblGenericLimit.Valuation;
        ProjectData.ClearProjectError();
      }
    }
    if (tblGenericLimit.IsExcludingNull())
    {
      this.txtExcluding.Text = string.Empty;
    }
    else
    {
      try
      {
        this.txtExcluding.Rtf = tblGenericLimit.Excluding;
      }
      catch (ArgumentException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        this.txtExcluding.Text = tblGenericLimit.Excluding;
        ProjectData.ClearProjectError();
      }
    }
    if (tblGenericLimit.IsLimitNull())
    {
      this.txtLimit.Text = string.Empty;
    }
    else
    {
      try
      {
        this.txtLimit.Rtf = tblGenericLimit.Limit;
      }
      catch (ArgumentException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        this.txtLimit.Text = tblGenericLimit.Limit;
        ProjectData.ClearProjectError();
      }
    }
    if (tblGenericLimit.IsDeductibleNull())
    {
      this.txtDeductible.Text = string.Empty;
    }
    else
    {
      try
      {
        this.txtDeductible.Rtf = tblGenericLimit.Deductible;
      }
      catch (ArgumentException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        this.txtDeductible.Text = tblGenericLimit.Deductible;
        ProjectData.ClearProjectError();
      }
    }
    if (tblGenericLimit.IsAdditionalCommentsNull())
    {
      this.txtAdditionalComments.Text = string.Empty;
    }
    else
    {
      try
      {
        this.txtAdditionalComments.Rtf = tblGenericLimit.AdditionalComments;
      }
      catch (ArgumentException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        this.txtAdditionalComments.Text = tblGenericLimit.AdditionalComments;
        ProjectData.ClearProjectError();
      }
    }
    if (tblGenericLimit.IsSubLimitsNull())
    {
      this.txtSubLimits.Text = string.Empty;
    }
    else
    {
      try
      {
        this.txtSubLimits.Rtf = tblGenericLimit.SubLimits;
      }
      catch (ArgumentException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        this.txtSubLimits.Text = tblGenericLimit.SubLimits;
        ProjectData.ClearProjectError();
      }
    }
  }

  private void FillCarrierPremiums()
  {
    this.ds.tblCarrierPremium.Clear();
    foreach (UltraGridRow row1 in ((UltraGridBase) this.ugCarriers).Rows)
    {
      dsGenericMultiRater.tblCarrierPremiumRow row2 = this.ds.tblCarrierPremium.NewtblCarrierPremiumRow();
      row2.QuoteID = this.Rater.Quote.QuoteID;
      row2.CompanyLocationGuid = (Guid) row1.Cells["CompanyLocationGuid"].Value;
      row2.Premium = row1.Cells["Premium"].Value == null || row1.Cells["Premium"].Value == DBNull.Value ? 0M : Convert.ToDecimal(RuntimeHelpers.GetObjectValue(row1.Cells["Premium"].Value));
      row2.TRIAPremium = row1.Cells["TRIAPremium"].Value == null || row1.Cells["TRIAPremium"].Value == DBNull.Value ? 0M : Convert.ToDecimal(RuntimeHelpers.GetObjectValue(row1.Cells["TRIAPremium"].Value));
      this.ds.tblCarrierPremium.AddtblCarrierPremiumRow(row2);
    }
  }

  private void btnSave_Click(object sender, EventArgs e)
  {
    if (!this.IsValidData())
      return;
    if (this.ds.tblGenericLimits.Count > 0)
      this.SaveGenericLimitInfo();
    this.Cursor = MgaCursors.WaitCursor;
    try
    {
      DefaultDatabase.ExecuteTransaction((EventHandler<ExecuteTransactionEventArgs>) ([SpecialName] (obj, args) =>
      {
        try
        {
          this.DeleteCarrierPremium();
          this.FillCarrierPremiums();
          this.daGenericLimits.UpdateCommand.Transaction = (SqlTransaction) args.Transaction;
          this.daGenericLimits.InsertCommand.Transaction = (SqlTransaction) args.Transaction;
          this.da.UpdateCommand.Transaction = (SqlTransaction) args.Transaction;
          this.da.InsertCommand.Transaction = (SqlTransaction) args.Transaction;
          DefaultDatabase.DataAdapterUpdate((DbDataAdapter) this.daGenericLimits, (DataTable) this.ds.tblGenericLimits);
          DefaultDatabase.DataAdapterUpdate((DbDataAdapter) this.da, (DataTable) this.ds.tblCarrierPremium);
          this.SaveMultiCarrierRaterData();
          this.SaveGenericMultiRaterData();
          this.SaveOnClient((SqlTransaction) args.Transaction);
          args.Transaction.Commit();
        }
        catch (SqlException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          if (args.Transaction != null)
            args.Transaction.Rollback();
          throw;
        }
      }));
    }
    catch (SqlException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      ErrorHandler.HandleError((Exception) ex);
      ProjectData.ClearProjectError();
    }
    finally
    {
      this.Cursor = MgaCursors.Default;
    }
    this.Close();
  }

  protected virtual void SaveOnClient(SqlTransaction trans)
  {
  }

  private void DeleteCarrierPremium()
  {
    DefaultDatabase.ExecuteNonQuery(CommandType.Text, "DELETE FROM tblCarrierPremium WHERE QuoteID = @QID", new object[2]
    {
      (object) "@QID",
      (object) this.Rater.Quote.QuoteID
    });
  }

  private void SaveMultiCarrierRaterData()
  {
    DefaultDatabase.ExecuteNonQuery(CommandType.Text, "DELETE FROM tblMultiCarrierRaterData WHERE QuoteID = @quoteID", new object[2]
    {
      (object) "@quoteID",
      (object) this.Rater.Quote.QuoteID
    });
    try
    {
      foreach (dsGenericMultiRater.dtPropertyInfoRow dtPropertyInfoRow in (TypedTableBase<dsGenericMultiRater.dtPropertyInfoRow>) this.ds.dtPropertyInfo)
      {
        object limit = !dtPropertyInfoRow.IsLimitNull() ? (object) dtPropertyInfoRow.Limit : (object) null;
        object participation = !dtPropertyInfoRow.IsParticipationNull() ? (object) dtPropertyInfoRow.Participation : (object) null;
        DefaultDatabase.ExecuteNonQuery("dbo.SaveMultiCarrierData", new object[8]
        {
          (object) "@QuoteID",
          (object) this.Rater.Quote.QuoteID,
          (object) "@CompanyLocationGuid",
          (object) dtPropertyInfoRow.CompanyLocationGuid,
          (object) "@Limit",
          limit,
          (object) "@Participation",
          participation
        });
      }
    }
    finally
    {
      IEnumerator<dsGenericMultiRater.dtPropertyInfoRow> enumerator;
      enumerator?.Dispose();
    }
  }

  private void SaveGenericMultiRaterData()
  {
    DefaultDatabase.ExecuteNonQuery("dbo.SaveGenericMultiCarrierPremium", new object[2]
    {
      (object) "@QuoteID",
      (object) this.Rater.Quote.QuoteID
    });
  }

  protected virtual bool IsValidData()
  {
    bool flag = true;
    foreach (UltraGridRow row in ((UltraGridBase) this.ugCarriers).Rows)
      ;
    return flag;
  }

  private void SaveGenericLimitInfo()
  {
    dsGenericMultiRater.tblGenericLimitsRow tblGenericLimit = this.ds.tblGenericLimits[0];
    this.SavePerilsInfo(tblGenericLimit);
    this.SaveCoveringInfo(tblGenericLimit);
    this.SaveValuationInfo(tblGenericLimit);
    this.SaveExcludingInfo(tblGenericLimit);
    this.SaveAdditionalComments(tblGenericLimit);
    this.SaveLimits(tblGenericLimit);
    if (tblGenericLimit.IsDeductibleNull() && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtDeductible.Text, string.Empty, false) != 0 || !tblGenericLimit.IsDeductibleNull() && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(tblGenericLimit.Deductible, this.txtDeductible.Text, false) != 0)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtDeductible.Text, string.Empty, false) == 0)
        tblGenericLimit.SetDeductibleNull();
      else
        tblGenericLimit.Deductible = this.txtDeductible.Rtf;
    }
    if (tblGenericLimit.IsSubLimitsNull() && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtSubLimits.Text, string.Empty, false) != 0 || !tblGenericLimit.IsSubLimitsNull() && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(tblGenericLimit.SubLimits, this.txtSubLimits.Text, false) != 0)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtSubLimits.Text, string.Empty, false) == 0)
        tblGenericLimit.SetSubLimitsNull();
      else
        tblGenericLimit.SubLimits = this.txtSubLimits.Rtf;
    }
    if (!tblGenericLimit.IsLimitNull() || !tblGenericLimit.IsDeductibleNull() || !tblGenericLimit.IsCoveringNull() || !tblGenericLimit.IsExcludingNull() || !tblGenericLimit.IsPerilsNull() || !tblGenericLimit.IsValuationNull() || !tblGenericLimit.IsAdditionalCommentsNull() || !tblGenericLimit.IsSubLimitsNull())
      return;
    if (tblGenericLimit.RowState == DataRowState.Added)
      this.ds.tblGenericLimits.RemovetblGenericLimitsRow(tblGenericLimit);
    else
      tblGenericLimit.Delete();
  }

  private void SavePerilsInfo(dsGenericMultiRater.tblGenericLimitsRow dr)
  {
    if ((!dr.IsPerilsNull() || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtPerils.Text, string.Empty, false) == 0) && (dr.IsPerilsNull() || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(dr.Perils, this.txtPerils.Text, false) == 0))
      return;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtPerils.Text, string.Empty, false) == 0)
      dr.SetPerilsNull();
    else
      dr.Perils = this.txtPerils.Rtf;
  }

  private void SaveCoveringInfo(dsGenericMultiRater.tblGenericLimitsRow dr)
  {
    if ((!dr.IsCoveringNull() || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtCovering.Text, string.Empty, false) == 0) && (dr.IsCoveringNull() || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(dr.Covering, this.txtCovering.Text, false) == 0))
      return;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtCovering.Text, string.Empty, false) == 0)
      dr.SetCoveringNull();
    else
      dr.Covering = this.txtCovering.Rtf;
  }

  private void SaveValuationInfo(dsGenericMultiRater.tblGenericLimitsRow dr)
  {
    if ((!dr.IsValuationNull() || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtValuation.Text, string.Empty, false) == 0) && (dr.IsValuationNull() || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(dr.Valuation, this.txtValuation.Text, false) == 0))
      return;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtValuation.Text, string.Empty, false) == 0)
      dr.SetValuationNull();
    else
      dr.Valuation = this.txtValuation.Rtf;
  }

  private void SaveExcludingInfo(dsGenericMultiRater.tblGenericLimitsRow dr)
  {
    if ((!dr.IsExcludingNull() || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtExcluding.Text, string.Empty, false) == 0) && (dr.IsExcludingNull() || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(dr.Excluding, this.txtExcluding.Text, false) == 0))
      return;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtExcluding.Text, string.Empty, false) == 0)
      dr.SetExcludingNull();
    else
      dr.Excluding = this.txtExcluding.Rtf;
  }

  private void SaveAdditionalComments(dsGenericMultiRater.tblGenericLimitsRow dr)
  {
    if ((!dr.IsAdditionalCommentsNull() || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtAdditionalComments.Text, string.Empty, false) == 0) && (dr.IsAdditionalCommentsNull() || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(dr.AdditionalComments, this.txtAdditionalComments.Text, false) == 0))
      return;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtAdditionalComments.Text, string.Empty, false) == 0)
      dr.SetAdditionalCommentsNull();
    else
      dr.AdditionalComments = this.txtAdditionalComments.Rtf;
  }

  private void SaveLimits(dsGenericMultiRater.tblGenericLimitsRow dr)
  {
    if ((!dr.IsLimitNull() || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtLimit.Text, string.Empty, false) == 0) && (dr.IsLimitNull() || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(dr.Limit, this.txtLimit.Text, false) == 0))
      return;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtLimit.Text, string.Empty, false) == 0)
      dr.SetLimitNull();
    else
      dr.Limit = this.txtLimit.Rtf;
  }

  private void btnExposure_Click(object sender, EventArgs e)
  {
    if (this.listExposureLines.SelectedItem == null)
      return;
    IExposureCapture exposureCapture = (IExposureCapture) ObjectFactory.Instance.CreateObject(((FormGenericMultiCarrierRater.ExposureCaptureItem) this.listExposureLines.SelectedItem).CaptureType);
    exposureCapture.SetQuoteId(this.Rater.Quote.QuoteID);
    Form form = (Form) exposureCapture;
    try
    {
      form.ShowInTaskbar = false;
      int num = (int) form.ShowDialog();
    }
    finally
    {
      form.Dispose();
    }
  }

  private void MgaTab1_SelectedTabChanged(object sender, SelectedTabChangedEventArgs e)
  {
    if (((UltraTabControlBase) this.MgaTab1).SelectedTab.TabPage != this.tabExposure || this.listExposureLines.Items.Count != 0)
      return;
    ThreadPool.QueueUserWorkItem(new WaitCallback(this.ShowExposureCaptures));
  }

  private void ShowExposureCaptures(object state)
  {
    ExposureCaptureAttribute searchAttribute = new ExposureCaptureAttribute();
    Type[] typeArray = ObjectFactory.Instance.QueryTypesWithAttribute((Attribute) searchAttribute);
    int index = 0;
    while (index < typeArray.Length)
    {
      Type type = typeArray[index];
      MDIControls.Instance.MDIParent.BetterInvoke((Delegate) new FormGenericMultiCarrierRater.AddExposureCaptureHandler(this.AddExposureCapture), (object) ((ExposureCaptureAttribute) ObjectFactory.GetAttributeFromType(type, (Attribute) searchAttribute)).LineName, (object) type);
      checked { ++index; }
    }
  }

  private void AddExposureCapture(string captureName, Type t)
  {
    try
    {
      foreach (FormGenericMultiCarrierRater.ExposureCaptureItem exposureCaptureItem in this.listExposureLines.Items)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(exposureCaptureItem.ToString(), captureName, false) == 0)
          return;
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    this.listExposureLines.Items.Add((object) new FormGenericMultiCarrierRater.ExposureCaptureItem(captureName, t));
    this.listExposureLines.SelectedIndex = 0;
  }

  private void _hlk_HyperLinkOpening(object sender, CancelEventArgs e)
  {
    e.Cancel = true;
    Guid empty = Guid.Empty;
    if (((UltraGridBase) this.ugCarriers).ActiveRow.Cells["CompanyLocationGuid"].Value == null || ((UltraGridBase) this.ugCarriers).ActiveRow.Cells["CompanyLocationGuid"].Value == DBNull.Value)
      return;
    object objectValue = RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar("GetGenericMultiCarrrierOption", new object[4]
    {
      (object) "@CompanyLocationGuid",
      (object) (Guid) ((UltraGridBase) this.ugCarriers).ActiveRow.Cells["CompanyLocationGuid"].Value,
      (object) "@QuoteGuid",
      (object) this.Rater.QuoteGuid
    }));
    if (objectValue == null || objectValue == DBNull.Value)
      return;
    Type typeFromString = ObjectFactory.Instance.CreateTypeFromString("MGASystems.IMS.Policies.Fees.frmPolicyFees");
    Form form = (Form) null;
    try
    {
      if ((object) typeFromString != null)
      {
        form = (Form) ObjectFactory.Instance.CreateObjectEX(typeFromString, objectValue);
        if (form != null)
        {
          form.ShowInTaskbar = true;
          form.BringToFront();
          int num = (int) form.ShowDialog();
        }
      }
    }
    finally
    {
      form?.Dispose();
    }
    this.FillData();
  }

  private void lnkOffset_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    if (MessageBox.Show("Are you sure you want to offset the previous transaction?", "Offset Previous Transaction", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.Yes)
      return;
    object objectValue = RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar("dbo.spOffsetPreviousGenericMultiCarrierTransaction", new object[2]
    {
      (object) "@ControlNo",
      (object) this.Rater.Quote.ControlNo
    }));
    if (objectValue == null || objectValue == DBNull.Value)
      return;
    this.RefreshPremiums((Guid) objectValue);
    QuoteOption quoteOption = new QuoteOption((Guid) objectValue);
    this.LoadPremiums();
  }

  private void LoadPremiums() => this.FillData();

  private void RefreshPremiums(Guid quoteOptionGuid)
  {
    QuoteOption quoteOption = new QuoteOption(quoteOptionGuid);
    MDIControls.Instance.StatusBarText = "Rating option...";
    this.Rater.RateOption(quoteOption.QuoteOptionGuid);
  }

  private void ugCarriers_AfterRowActivate(object sender, EventArgs e)
  {
    this.lblParticipationPercentage.Text = string.Empty;
    if (((UltraGridBase) this.ugCarriers).ActiveRow == null || ((UltraGridBase) this.ugCarriers).ActiveRow.Cells["Participation"].Value == null || ((UltraGridBase) this.ugCarriers).ActiveRow.Cells["Participation"].Value == DBNull.Value)
      return;
    this.lblParticipationPercentage.Text = ((UltraGridBase) this.ugCarriers).ActiveRow.Cells["Participation"].Value.ToString();
  }

  private delegate void AddExposureCaptureHandler(string captureName, Type t);

  private class ExposureCaptureItem
  {
    private readonly string _captureName;
    private readonly Type _t;

    public ExposureCaptureItem(string captureName, Type t)
    {
      this._captureName = captureName;
      this._t = t;
    }

    public Type CaptureType => this._t;

    public override string ToString() => this._captureName;
  }
}
