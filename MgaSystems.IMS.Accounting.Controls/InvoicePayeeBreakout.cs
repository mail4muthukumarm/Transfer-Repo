// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Controls.InvoicePayeeBreakout
// Assembly: MgaSystems.IMS.Accounting.Controls, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 69E8E7CF-F3E0-45A9-94CD-B8A0D33430C8
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Accounting.Controls.dll

using Infragistics.Win;
using Infragistics.Win.Layout;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinGrid;
using MGASystems.Data;
using MGASystems.Tools;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Controls;

[DesignerGenerated]
public class InvoicePayeeBreakout : UserControl
{
  private IContainer components;

  public InvoicePayeeBreakout() => this.InitializeComponent();

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
    UltraGridBand ultraGridBand = new UltraGridBand("InvoicePayees", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("PayeeName");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("PayeeAmount");
    Appearance appearance2 = new Appearance();
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
    this.EllipsePanel1 = new EllipsePanel();
    this.gridInvoicePayees = new UltraGrid();
    this.DsInvoicePayees1 = new dsInvoicePayees();
    this.Label1 = new Label();
    this.MgaButton1 = new MGAButton();
    this.EllipsePanel1.SuspendLayout();
    ((ISupportInitialize) this.gridInvoicePayees).BeginInit();
    this.DsInvoicePayees1.BeginInit();
    ((ISupportInitialize) this.MgaButton1).BeginInit();
    this.SuspendLayout();
    this.EllipsePanel1.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    this.EllipsePanel1.Controls.Add((Control) this.gridInvoicePayees);
    this.EllipsePanel1.Controls.Add((Control) this.Label1);
    this.EllipsePanel1.Controls.Add((Control) this.MgaButton1);
    this.EllipsePanel1.Location = new Point(0, 0);
    this.EllipsePanel1.Name = "EllipsePanel1";
    this.EllipsePanel1.Size = new Size(415, 368);
    this.EllipsePanel1.TabIndex = 1;
    ((UltraGridBase) this.gridInvoicePayees).DataSource = (object) this.DsInvoicePayees1;
    appearance1.BackColor = Color.Transparent;
    appearance1.BorderColor = SystemColors.InactiveCaption;
    ((UltraGridBase) this.gridInvoicePayees).DisplayLayout.Appearance = (AppearanceBase) appearance1;
    ((UltraGridBase) this.gridInvoicePayees).DisplayLayout.AutoFitStyle = (AutoFitStyle) 2;
    ultraGridBand.ColHeadersVisible = false;
    ultraGridColumn1.CellActivation = (Activation) 3;
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Width = 284;
    ultraGridColumn2.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance2).TextHAlignAsString = "Right";
    ultraGridColumn2.CellAppearance = (AppearanceBase) appearance2;
    ultraGridColumn2.Format = "c";
    ultraGridColumn2.Header.VisiblePosition = 1;
    ultraGridColumn2.Width = 101;
    ultraGridBand.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2
    });
    ((UltraGridBase) this.gridInvoicePayees).DisplayLayout.BandsSerializer.Add((object) ultraGridBand);
    ((UltraGridBase) this.gridInvoicePayees).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.gridInvoicePayees).DisplayLayout.CaptionVisible = (DefaultableBoolean) 2;
    appearance3.BackColor = SystemColors.ActiveBorder;
    appearance3.BackColor2 = SystemColors.ControlDark;
    appearance3.BackGradientStyle = (GradientStyle) 2;
    appearance3.BorderColor = SystemColors.Window;
    ((SpecialBoxBase) ((UltraGridBase) this.gridInvoicePayees).DisplayLayout.GroupByBox).Appearance = (AppearanceBase) appearance3;
    appearance4.ForeColor = SystemColors.GrayText;
    ((UltraGridBase) this.gridInvoicePayees).DisplayLayout.GroupByBox.BandLabelAppearance = (AppearanceBase) appearance4;
    ((SpecialBoxBase) ((UltraGridBase) this.gridInvoicePayees).DisplayLayout.GroupByBox).BorderStyle = (UIElementBorderStyle) 4;
    ((SpecialBoxBase) ((UltraGridBase) this.gridInvoicePayees).DisplayLayout.GroupByBox).Hidden = true;
    appearance5.BackColor = SystemColors.ControlLightLight;
    appearance5.BackColor2 = SystemColors.Control;
    appearance5.BackGradientStyle = (GradientStyle) 3;
    appearance5.ForeColor = SystemColors.GrayText;
    ((UltraGridBase) this.gridInvoicePayees).DisplayLayout.GroupByBox.PromptAppearance = (AppearanceBase) appearance5;
    ((UltraGridBase) this.gridInvoicePayees).DisplayLayout.MaxColScrollRegions = 1;
    ((UltraGridBase) this.gridInvoicePayees).DisplayLayout.MaxRowScrollRegions = 1;
    appearance6.BackColor = SystemColors.Window;
    appearance6.ForeColor = SystemColors.ControlText;
    ((UltraGridBase) this.gridInvoicePayees).DisplayLayout.Override.ActiveCellAppearance = (AppearanceBase) appearance6;
    appearance7.BackColor = SystemColors.Highlight;
    appearance7.ForeColor = SystemColors.HighlightText;
    ((UltraGridBase) this.gridInvoicePayees).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance7;
    ((UltraGridBase) this.gridInvoicePayees).DisplayLayout.Override.AllowAddNew = (AllowAddNew) 2;
    ((UltraGridBase) this.gridInvoicePayees).DisplayLayout.Override.AllowColMoving = (AllowColMoving) 1;
    ((UltraGridBase) this.gridInvoicePayees).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 1;
    ((UltraGridBase) this.gridInvoicePayees).DisplayLayout.Override.AllowColSwapping = (AllowColSwapping) 1;
    ((UltraGridBase) this.gridInvoicePayees).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridInvoicePayees).DisplayLayout.Override.AllowGroupBy = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridInvoicePayees).DisplayLayout.Override.AllowGroupMoving = (AllowGroupMoving) 1;
    ((UltraGridBase) this.gridInvoicePayees).DisplayLayout.Override.AllowGroupSwapping = (AllowGroupSwapping) 1;
    ((UltraGridBase) this.gridInvoicePayees).DisplayLayout.Override.AllowMultiCellOperations = (AllowMultiCellOperation) 0;
    ((UltraGridBase) this.gridInvoicePayees).DisplayLayout.Override.AllowRowFiltering = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridInvoicePayees).DisplayLayout.Override.AllowRowLayoutCellSizing = (RowLayoutSizing) 1;
    ((UltraGridBase) this.gridInvoicePayees).DisplayLayout.Override.AllowRowLayoutCellSpanSizing = (GridBagLayoutAllowSpanSizing) 1;
    ((UltraGridBase) this.gridInvoicePayees).DisplayLayout.Override.AllowRowLayoutColMoving = (GridBagLayoutAllowMoving) 1;
    ((UltraGridBase) this.gridInvoicePayees).DisplayLayout.Override.AllowRowLayoutLabelSizing = (RowLayoutSizing) 1;
    ((UltraGridBase) this.gridInvoicePayees).DisplayLayout.Override.AllowRowLayoutLabelSpanSizing = (GridBagLayoutAllowSpanSizing) 1;
    ((UltraGridBase) this.gridInvoicePayees).DisplayLayout.Override.AllowRowSummaries = (AllowRowSummaries) 2;
    ((UltraGridBase) this.gridInvoicePayees).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridInvoicePayees).DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.gridInvoicePayees).DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 1;
    appearance8.BackColor = SystemColors.Window;
    ((UltraGridBase) this.gridInvoicePayees).DisplayLayout.Override.CardAreaAppearance = (AppearanceBase) appearance8;
    appearance9.BorderColor = Color.Silver;
    appearance9.TextTrimming = (TextTrimming) 3;
    ((UltraGridBase) this.gridInvoicePayees).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance9;
    ((UltraGridBase) this.gridInvoicePayees).DisplayLayout.Override.CellClickAction = (CellClickAction) 2;
    ((UltraGridBase) this.gridInvoicePayees).DisplayLayout.Override.CellPadding = 0;
    appearance10.BackColor = SystemColors.Control;
    appearance10.BackColor2 = SystemColors.ControlDark;
    appearance10.BackGradientAlignment = (GradientAlignment) 1;
    appearance10.BackGradientStyle = (GradientStyle) 3;
    appearance10.BorderColor = SystemColors.Window;
    ((UltraGridBase) this.gridInvoicePayees).DisplayLayout.Override.GroupByRowAppearance = (AppearanceBase) appearance10;
    ((AppearanceBase) appearance11).TextHAlignAsString = "Left";
    ((UltraGridBase) this.gridInvoicePayees).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance11;
    ((UltraGridBase) this.gridInvoicePayees).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 3;
    ((UltraGridBase) this.gridInvoicePayees).DisplayLayout.Override.HeaderStyle = (HeaderStyle) 2;
    appearance12.BackColor = Color.Transparent;
    appearance12.BorderColor = Color.Silver;
    ((UltraGridBase) this.gridInvoicePayees).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance12;
    ((UltraGridBase) this.gridInvoicePayees).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance13.BackColor = SystemColors.ControlLight;
    ((UltraGridBase) this.gridInvoicePayees).DisplayLayout.Override.TemplateAddRowAppearance = (AppearanceBase) appearance13;
    ((UltraGridBase) this.gridInvoicePayees).DisplayLayout.ScrollBounds = (ScrollBounds) 0;
    ((UltraGridBase) this.gridInvoicePayees).DisplayLayout.ScrollStyle = (ScrollStyle) 1;
    ((UltraGridBase) this.gridInvoicePayees).DisplayLayout.ViewStyleBand = (ViewStyleBand) 2;
    ((Control) this.gridInvoicePayees).Location = new Point(11, 25);
    ((Control) this.gridInvoicePayees).Name = "gridInvoicePayees";
    ((Control) this.gridInvoicePayees).Size = new Size(391, 337);
    ((Control) this.gridInvoicePayees).TabIndex = 3;
    ((Control) this.gridInvoicePayees).Text = "UltraGrid1";
    this.DsInvoicePayees1.DataSetName = "dsInvoicePayees";
    this.DsInvoicePayees1.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.Label1.AutoSize = true;
    this.Label1.Font = new Font("Tahoma", 8f, FontStyle.Bold | FontStyle.Underline);
    this.Label1.ForeColor = Color.Black;
    this.Label1.Location = new Point(8, 8);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(93, 13);
    this.Label1.TabIndex = 2;
    this.Label1.Text = "Invoice Payees";
    appearance14.BackColor = Color.FromArgb(248, 248, 248);
    appearance14.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance14.BackGradientStyle = (GradientStyle) 2;
    appearance14.BorderColor = Color.DarkGray;
    ((ControlBase) this.MgaButton1).Appearance = (AppearanceBase) appearance14;
    ((Control) this.MgaButton1).Location = new Point(393, 4);
    ((Control) this.MgaButton1).Name = "MgaButton1";
    ((Control) this.MgaButton1).Size = new Size(16 /*0x10*/, 16 /*0x10*/);
    ((Control) this.MgaButton1).TabIndex = 1;
    ((ControlBase) this.MgaButton1).Text = "X";
    this.MgaButton1.UseOSThemes = (DefaultableBoolean) 2;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.Controls.Add((Control) this.EllipsePanel1);
    this.Font = new Font("Tahoma", 8.25f);
    this.Name = nameof (InvoicePayeeBreakout);
    this.Size = new Size(417, 370);
    this.EllipsePanel1.ResumeLayout(false);
    this.EllipsePanel1.PerformLayout();
    ((ISupportInitialize) this.gridInvoicePayees).EndInit();
    this.DsInvoicePayees1.EndInit();
    ((ISupportInitialize) this.MgaButton1).EndInit();
    this.ResumeLayout(false);
  }

  [field: AccessedThroughProperty("EllipsePanel1")]
  internal virtual EllipsePanel EllipsePanel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label1")]
  internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual MGAButton MgaButton1
  {
    get => this._MgaButton1;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.MgaButton1_Click);
      MGAButton mgaButton1_1 = this._MgaButton1;
      if (mgaButton1_1 != null)
        ((Control) mgaButton1_1).Click -= eventHandler;
      this._MgaButton1 = value;
      MGAButton mgaButton1_2 = this._MgaButton1;
      if (mgaButton1_2 == null)
        return;
      ((Control) mgaButton1_2).Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("gridInvoicePayees")]
  internal virtual UltraGrid gridInvoicePayees { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("DsInvoicePayees1")]
  internal virtual dsInvoicePayees DsInvoicePayees1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  public void ShowInvoicePayees(int invoiceNumber)
  {
    DefaultDatabase.LoadDataSet((DataSet) this.DsInvoicePayees1, new string[1]
    {
      "InvoicePayees"
    }, "spFin_PolicyInquiry_GetInvoicePayees", new object[2]
    {
      (object) "@invoiceNum",
      (object) invoiceNumber
    });
  }

  private void MgaButton1_Click(object sender, EventArgs e) => this.Visible = false;

  public void Clear() => this.DsInvoicePayees1.Clear();
}
