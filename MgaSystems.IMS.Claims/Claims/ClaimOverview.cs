// Decompiled with JetBrains decompiler
// Type: Claims.ClaimOverview
// Assembly: MgaSystems.IMS.Claims, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FCD9D0B7-28CF-40B9-8EB7-297871E1AF5F
// Assembly location: F:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims.dll

using Infragistics.Win;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinMaskedEdit;
using Infragistics.Win.UltraWinTabControl;
using MGASystems.Tools;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace Claims;

public class ClaimOverview : UserControl
{
  private IContainer components;
  private Label label1;
  private Label ClaimNumber_Label;
  private Label label4;
  private Label label6;
  private Label label8;
  private MGATextBox textClaimNumber;
  private MGATextBox mgaTextBox2;
  private MGATextBox mgaTextBox4;
  private MGAMaskedEdit mgaMaskedEdit1;
  private UltraTabControl ultraTabControl1;
  private UltraTabSharedControlsPage ultraTabSharedControlsPage1;
  private UltraTabPageControl ultraTabPageControl1;
  private UltraTabPageControl ultraTabPageControl2;
  private UltraTabPageControl ultraTabPageControl3;
  private UltraTabControl ultraTabControl2;
  private UltraTabSharedControlsPage ultraTabSharedControlsPage2;
  private UltraTabPageControl ultraTabPageControl5;
  private UltraTabPageControl ultraTabPageControl4;
  private UltraGrid ultraGrid1;

  public ClaimOverview()
  {
    this.InitializeComponent();
    this.SetDockStyle();
  }

  private void SetDockStyle() => this.Dock = DockStyle.Fill;

  private void ultraTabSharedControlsPage1_Paint(object sender, PaintEventArgs e)
  {
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
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    UltraTab ultraTab1 = new UltraTab();
    UltraTab ultraTab2 = new UltraTab();
    UltraTab ultraTab3 = new UltraTab();
    UltraTab ultraTab4 = new UltraTab();
    UltraTab ultraTab5 = new UltraTab();
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
    Appearance appearance16 = new Appearance();
    this.label1 = new Label();
    this.ClaimNumber_Label = new Label();
    this.label4 = new Label();
    this.label6 = new Label();
    this.label8 = new Label();
    this.textClaimNumber = new MGATextBox();
    this.mgaTextBox2 = new MGATextBox();
    this.mgaTextBox4 = new MGATextBox();
    this.mgaMaskedEdit1 = new MGAMaskedEdit();
    this.ultraTabControl1 = new UltraTabControl();
    this.ultraTabSharedControlsPage1 = new UltraTabSharedControlsPage();
    this.ultraTabPageControl1 = new UltraTabPageControl();
    this.ultraTabPageControl2 = new UltraTabPageControl();
    this.ultraTabPageControl3 = new UltraTabPageControl();
    this.ultraTabPageControl4 = new UltraTabPageControl();
    this.ultraTabControl2 = new UltraTabControl();
    this.ultraTabSharedControlsPage2 = new UltraTabSharedControlsPage();
    this.ultraTabPageControl5 = new UltraTabPageControl();
    this.ultraGrid1 = new UltraGrid();
    ((ISupportInitialize) this.textClaimNumber).BeginInit();
    ((ISupportInitialize) this.mgaTextBox2).BeginInit();
    ((ISupportInitialize) this.mgaTextBox4).BeginInit();
    ((ISupportInitialize) this.mgaMaskedEdit1).BeginInit();
    ((ISupportInitialize) this.ultraTabControl1).BeginInit();
    ((Control) this.ultraTabControl1).SuspendLayout();
    ((Control) this.ultraTabSharedControlsPage1).SuspendLayout();
    ((Control) this.ultraTabPageControl3).SuspendLayout();
    ((ISupportInitialize) this.ultraTabControl2).BeginInit();
    ((Control) this.ultraTabControl2).SuspendLayout();
    ((Control) this.ultraTabSharedControlsPage2).SuspendLayout();
    ((ISupportInitialize) this.ultraGrid1).BeginInit();
    this.SuspendLayout();
    this.label1.AutoSize = true;
    this.label1.BackColor = Color.Transparent;
    this.label1.Font = new Font("Tahoma", 10f, FontStyle.Bold | FontStyle.Underline);
    this.label1.Location = new Point(3, 20);
    this.label1.Name = "label1";
    this.label1.Size = new Size(133, 17);
    this.label1.TabIndex = 0;
    this.label1.Text = "Claim Information";
    this.ClaimNumber_Label.AutoSize = true;
    this.ClaimNumber_Label.BackColor = Color.Transparent;
    this.ClaimNumber_Label.Location = new Point(2, 41);
    this.ClaimNumber_Label.Name = "ClaimNumber_Label";
    this.ClaimNumber_Label.Size = new Size(76, 13);
    this.ClaimNumber_Label.TabIndex = 1;
    this.ClaimNumber_Label.Text = "Claim Number:";
    this.label4.AutoSize = true;
    this.label4.BackColor = Color.Transparent;
    this.label4.Location = new Point(3, 63 /*0x3F*/);
    this.label4.Name = "label4";
    this.label4.Size = new Size(62, 13);
    this.label4.TabIndex = 3;
    this.label4.Text = "Claim Date:";
    this.label6.AutoSize = true;
    this.label6.BackColor = Color.Transparent;
    this.label6.Location = new Point(3, 84);
    this.label6.Name = "label6";
    this.label6.Size = new Size(86, 13);
    this.label6.TabIndex = 5;
    this.label6.Text = "Insurance Type:";
    this.label8.AutoSize = true;
    this.label8.BackColor = Color.Transparent;
    this.label8.Location = new Point(3, 107);
    this.label8.Name = "label8";
    this.label8.Size = new Size(99, 13);
    this.label8.TabIndex = 7;
    this.label8.Text = "Catastrophy Code:";
    ((AppearanceBase) appearance1).BackColor = Color.White;
    ((AppearanceBase) appearance1).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance1).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textClaimNumber).Appearance = (AppearanceBase) appearance1;
    ((Control) this.textClaimNumber).BackColor = Color.White;
    ((Control) this.textClaimNumber).Location = new Point(101, 41);
    this.textClaimNumber.MGAStyle = (MGAStyles) 2;
    ((Control) this.textClaimNumber).Name = "textClaimNumber";
    ((Control) this.textClaimNumber).Size = new Size(196, 20);
    ((Control) this.textClaimNumber).TabIndex = 9;
    ((Control) this.textClaimNumber).Text = "IMS-CLAIM-0987548163891";
    ((UltraControlBase) this.textClaimNumber).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textClaimNumber).UseOsThemes = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance2).BackColor = Color.White;
    ((AppearanceBase) appearance2).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance2).ForeColor = Color.Black;
    ((TextEditorControlBase) this.mgaTextBox2).Appearance = (AppearanceBase) appearance2;
    ((Control) this.mgaTextBox2).BackColor = Color.White;
    ((Control) this.mgaTextBox2).Location = new Point(101, 86);
    this.mgaTextBox2.MGAStyle = (MGAStyles) 2;
    ((Control) this.mgaTextBox2).Name = "mgaTextBox2";
    ((EditorButtonControlBase) this.mgaTextBox2).ReadOnly = true;
    ((Control) this.mgaTextBox2).Size = new Size(196, 20);
    ((Control) this.mgaTextBox2).TabIndex = 10;
    ((UltraControlBase) this.mgaTextBox2).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.mgaTextBox2).UseOsThemes = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance3).BackColor = Color.White;
    ((AppearanceBase) appearance3).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance3).ForeColor = Color.Black;
    ((TextEditorControlBase) this.mgaTextBox4).Appearance = (AppearanceBase) appearance3;
    ((Control) this.mgaTextBox4).BackColor = Color.White;
    ((Control) this.mgaTextBox4).Location = new Point(101, 109);
    this.mgaTextBox4.MGAStyle = (MGAStyles) 2;
    ((Control) this.mgaTextBox4).Name = "mgaTextBox4";
    ((Control) this.mgaTextBox4).Size = new Size(196, 20);
    ((Control) this.mgaTextBox4).TabIndex = 12;
    ((UltraControlBase) this.mgaTextBox4).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.mgaTextBox4).UseOsThemes = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance4).BorderColor = Color.Gray;
    ((UltraMaskedEdit) this.mgaMaskedEdit1).Appearance = (AppearanceBase) appearance4;
    ((UltraMaskedEdit) this.mgaMaskedEdit1).EditAs = (EditAsType) 3;
    ((Control) this.mgaMaskedEdit1).Location = new Point(101, 63 /*0x3F*/);
    ((Control) this.mgaMaskedEdit1).Name = "mgaMaskedEdit1";
    ((Control) this.mgaMaskedEdit1).Size = new Size(73, 21);
    ((Control) this.mgaMaskedEdit1).TabIndex = 13;
    ((Control) this.mgaMaskedEdit1).Text = "mgaMaskedEdit1";
    ((UltraControlBase) this.mgaMaskedEdit1).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.mgaMaskedEdit1).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.ultraTabControl1).Controls.Add((Control) this.ultraTabSharedControlsPage1);
    ((Control) this.ultraTabControl1).Controls.Add((Control) this.ultraTabPageControl1);
    ((Control) this.ultraTabControl1).Controls.Add((Control) this.ultraTabPageControl2);
    ((Control) this.ultraTabControl1).Controls.Add((Control) this.ultraTabPageControl3);
    ((Control) this.ultraTabControl1).Controls.Add((Control) this.ultraTabPageControl4);
    ((Control) this.ultraTabControl1).Dock = DockStyle.Fill;
    ((Control) this.ultraTabControl1).Location = new Point(0, 0);
    ((Control) this.ultraTabControl1).Name = "ultraTabControl1";
    ((UltraTabControlBase) this.ultraTabControl1).SharedControls.AddRange(new Control[9]
    {
      (Control) this.label1,
      (Control) this.mgaMaskedEdit1,
      (Control) this.ClaimNumber_Label,
      (Control) this.mgaTextBox4,
      (Control) this.label4,
      (Control) this.mgaTextBox2,
      (Control) this.label6,
      (Control) this.textClaimNumber,
      (Control) this.label8
    });
    ((UltraTabControlBase) this.ultraTabControl1).SharedControlsPage = this.ultraTabSharedControlsPage1;
    ((Control) this.ultraTabControl1).Size = new Size(944, 633);
    ((Control) this.ultraTabControl1).TabIndex = 14;
    ultraTab1.TabPage = this.ultraTabPageControl1;
    ultraTab1.Text = "Claim Overview";
    ultraTab2.TabPage = this.ultraTabPageControl2;
    ultraTab2.Text = "Policy Information";
    ultraTab3.TabPage = this.ultraTabPageControl3;
    ultraTab3.Text = "Claimants";
    ultraTab4.TabPage = this.ultraTabPageControl4;
    ultraTab4.Text = "Reserves / Payments";
    ((UltraTabControlBase) this.ultraTabControl1).Tabs.AddRange(new UltraTab[4]
    {
      ultraTab1,
      ultraTab2,
      ultraTab3,
      ultraTab4
    });
    ((UltraTabControlBase) this.ultraTabControl1).ViewStyle = (ViewStyle) 4;
    ((Control) this.ultraTabSharedControlsPage1).Controls.Add((Control) this.label1);
    ((Control) this.ultraTabSharedControlsPage1).Controls.Add((Control) this.mgaMaskedEdit1);
    ((Control) this.ultraTabSharedControlsPage1).Controls.Add((Control) this.ClaimNumber_Label);
    ((Control) this.ultraTabSharedControlsPage1).Controls.Add((Control) this.mgaTextBox4);
    ((Control) this.ultraTabSharedControlsPage1).Controls.Add((Control) this.label4);
    ((Control) this.ultraTabSharedControlsPage1).Controls.Add((Control) this.mgaTextBox2);
    ((Control) this.ultraTabSharedControlsPage1).Controls.Add((Control) this.label6);
    ((Control) this.ultraTabSharedControlsPage1).Controls.Add((Control) this.textClaimNumber);
    ((Control) this.ultraTabSharedControlsPage1).Controls.Add((Control) this.label8);
    ((Control) this.ultraTabSharedControlsPage1).Location = new Point(-10000, -10000);
    ((Control) this.ultraTabSharedControlsPage1).Name = "ultraTabSharedControlsPage1";
    ((Control) this.ultraTabSharedControlsPage1).Size = new Size(942, 610);
    ((Control) this.ultraTabSharedControlsPage1).Paint += new PaintEventHandler(this.ultraTabSharedControlsPage1_Paint);
    ((Control) this.ultraTabPageControl1).Location = new Point(-10000, -10000);
    ((Control) this.ultraTabPageControl1).Name = "ultraTabPageControl1";
    ((Control) this.ultraTabPageControl1).Size = new Size(942, 610);
    ((Control) this.ultraTabPageControl2).Location = new Point(-10000, -10000);
    ((Control) this.ultraTabPageControl2).Name = "ultraTabPageControl2";
    ((Control) this.ultraTabPageControl2).Size = new Size(942, 610);
    ((Control) this.ultraTabPageControl3).Controls.Add((Control) this.ultraTabControl2);
    ((Control) this.ultraTabPageControl3).Location = new Point(1, 22);
    ((Control) this.ultraTabPageControl3).Name = "ultraTabPageControl3";
    ((Control) this.ultraTabPageControl3).Size = new Size(942, 610);
    ((Control) this.ultraTabPageControl4).Location = new Point(-10000, -10000);
    ((Control) this.ultraTabPageControl4).Name = "ultraTabPageControl4";
    ((Control) this.ultraTabPageControl4).Size = new Size(942, 610);
    ((Control) this.ultraTabControl2).Controls.Add((Control) this.ultraTabSharedControlsPage2);
    ((Control) this.ultraTabControl2).Controls.Add((Control) this.ultraTabPageControl5);
    ((Control) this.ultraTabControl2).Location = new Point(322, 41);
    ((Control) this.ultraTabControl2).Name = "ultraTabControl2";
    ((UltraTabControlBase) this.ultraTabControl2).SharedControls.AddRange(new Control[1]
    {
      (Control) this.ultraGrid1
    });
    ((UltraTabControlBase) this.ultraTabControl2).SharedControlsPage = this.ultraTabSharedControlsPage2;
    ((Control) this.ultraTabControl2).Size = new Size(603, 566);
    ((Control) this.ultraTabControl2).TabIndex = 14;
    ultraTab5.TabPage = this.ultraTabPageControl5;
    ultraTab5.Text = "Claimant Information";
    ((UltraTabControlBase) this.ultraTabControl2).Tabs.AddRange(new UltraTab[1]
    {
      ultraTab5
    });
    ((UltraTabControlBase) this.ultraTabControl2).ViewStyle = (ViewStyle) 4;
    ((Control) this.ultraTabSharedControlsPage2).Controls.Add((Control) this.ultraGrid1);
    ((Control) this.ultraTabSharedControlsPage2).Location = new Point(-10000, -10000);
    ((Control) this.ultraTabSharedControlsPage2).Name = "ultraTabSharedControlsPage2";
    ((Control) this.ultraTabSharedControlsPage2).Size = new Size(601, 543);
    ((Control) this.ultraTabPageControl5).Location = new Point(1, 22);
    ((Control) this.ultraTabPageControl5).Name = "ultraTabPageControl5";
    ((Control) this.ultraTabPageControl5).Size = new Size(601, 543);
    ((AppearanceBase) appearance5).BackColor = SystemColors.Window;
    ((AppearanceBase) appearance5).BorderColor = SystemColors.InactiveCaption;
    ((UltraGridBase) this.ultraGrid1).DisplayLayout.Appearance = (AppearanceBase) appearance5;
    ((UltraGridBase) this.ultraGrid1).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.ultraGrid1).DisplayLayout.CaptionVisible = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance6).BackColor = SystemColors.ActiveBorder;
    ((AppearanceBase) appearance6).BackColor2 = SystemColors.ControlDark;
    ((AppearanceBase) appearance6).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance6).BorderColor = SystemColors.Window;
    ((SpecialBoxBase) ((UltraGridBase) this.ultraGrid1).DisplayLayout.GroupByBox).Appearance = (AppearanceBase) appearance6;
    ((AppearanceBase) appearance7).ForeColor = SystemColors.GrayText;
    ((UltraGridBase) this.ultraGrid1).DisplayLayout.GroupByBox.BandLabelAppearance = (AppearanceBase) appearance7;
    ((SpecialBoxBase) ((UltraGridBase) this.ultraGrid1).DisplayLayout.GroupByBox).BorderStyle = (UIElementBorderStyle) 4;
    ((AppearanceBase) appearance8).BackColor = SystemColors.ControlLightLight;
    ((AppearanceBase) appearance8).BackColor2 = SystemColors.Control;
    ((AppearanceBase) appearance8).BackGradientStyle = (GradientStyle) 3;
    ((AppearanceBase) appearance8).ForeColor = SystemColors.GrayText;
    ((UltraGridBase) this.ultraGrid1).DisplayLayout.GroupByBox.PromptAppearance = (AppearanceBase) appearance8;
    ((UltraGridBase) this.ultraGrid1).DisplayLayout.MaxColScrollRegions = 1;
    ((UltraGridBase) this.ultraGrid1).DisplayLayout.MaxRowScrollRegions = 1;
    ((AppearanceBase) appearance9).BackColor = SystemColors.Window;
    ((AppearanceBase) appearance9).ForeColor = SystemColors.ControlText;
    ((UltraGridBase) this.ultraGrid1).DisplayLayout.Override.ActiveCellAppearance = (AppearanceBase) appearance9;
    ((AppearanceBase) appearance10).BackColor = SystemColors.Highlight;
    ((AppearanceBase) appearance10).ForeColor = SystemColors.HighlightText;
    ((UltraGridBase) this.ultraGrid1).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance10;
    ((UltraGridBase) this.ultraGrid1).DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 2;
    ((UltraGridBase) this.ultraGrid1).DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 2;
    ((AppearanceBase) appearance11).BackColor = SystemColors.Window;
    ((UltraGridBase) this.ultraGrid1).DisplayLayout.Override.CardAreaAppearance = (AppearanceBase) appearance11;
    ((AppearanceBase) appearance12).BorderColor = Color.Silver;
    ((AppearanceBase) appearance12).TextTrimming = (TextTrimming) 3;
    ((UltraGridBase) this.ultraGrid1).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance12;
    ((UltraGridBase) this.ultraGrid1).DisplayLayout.Override.CellClickAction = (CellClickAction) 4;
    ((UltraGridBase) this.ultraGrid1).DisplayLayout.Override.CellPadding = 0;
    ((AppearanceBase) appearance13).BackColor = SystemColors.Control;
    ((AppearanceBase) appearance13).BackColor2 = SystemColors.ControlDark;
    ((AppearanceBase) appearance13).BackGradientAlignment = (GradientAlignment) 1;
    ((AppearanceBase) appearance13).BackGradientStyle = (GradientStyle) 3;
    ((AppearanceBase) appearance13).BorderColor = SystemColors.Window;
    ((UltraGridBase) this.ultraGrid1).DisplayLayout.Override.GroupByRowAppearance = (AppearanceBase) appearance13;
    ((AppearanceBase) appearance14).TextHAlignAsString = "Left";
    ((UltraGridBase) this.ultraGrid1).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance14;
    ((UltraGridBase) this.ultraGrid1).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 3;
    ((UltraGridBase) this.ultraGrid1).DisplayLayout.Override.HeaderStyle = (HeaderStyle) 2;
    ((AppearanceBase) appearance15).BackColor = SystemColors.Window;
    ((AppearanceBase) appearance15).BorderColor = Color.Silver;
    ((UltraGridBase) this.ultraGrid1).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance15;
    ((UltraGridBase) this.ultraGrid1).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance16).BackColor = SystemColors.ControlLight;
    ((UltraGridBase) this.ultraGrid1).DisplayLayout.Override.TemplateAddRowAppearance = (AppearanceBase) appearance16;
    ((UltraGridBase) this.ultraGrid1).DisplayLayout.ScrollBounds = (ScrollBounds) 0;
    ((UltraGridBase) this.ultraGrid1).DisplayLayout.ScrollStyle = (ScrollStyle) 1;
    ((UltraGridBase) this.ultraGrid1).DisplayLayout.ViewStyleBand = (ViewStyleBand) 2;
    ((Control) this.ultraGrid1).Location = new Point(4, 4);
    ((Control) this.ultraGrid1).Name = "ultraGrid1";
    ((Control) this.ultraGrid1).Size = new Size(180, 534);
    ((Control) this.ultraGrid1).TabIndex = 0;
    ((Control) this.ultraGrid1).Text = "ultraGrid1";
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    this.Controls.Add((Control) this.ultraTabControl1);
    this.Font = new Font("Tahoma", 8.25f);
    this.ForeColor = Color.Black;
    this.Name = nameof (ClaimOverview);
    this.Size = new Size(944, 633);
    ((ISupportInitialize) this.textClaimNumber).EndInit();
    ((ISupportInitialize) this.mgaTextBox2).EndInit();
    ((ISupportInitialize) this.mgaTextBox4).EndInit();
    ((ISupportInitialize) this.mgaMaskedEdit1).EndInit();
    ((ISupportInitialize) this.ultraTabControl1).EndInit();
    ((Control) this.ultraTabControl1).ResumeLayout(false);
    ((Control) this.ultraTabSharedControlsPage1).ResumeLayout(false);
    ((Control) this.ultraTabSharedControlsPage1).PerformLayout();
    ((Control) this.ultraTabPageControl3).ResumeLayout(false);
    ((ISupportInitialize) this.ultraTabControl2).EndInit();
    ((Control) this.ultraTabControl2).ResumeLayout(false);
    ((Control) this.ultraTabSharedControlsPage2).ResumeLayout(false);
    ((ISupportInitialize) this.ultraGrid1).EndInit();
    this.ResumeLayout(false);
  }
}
