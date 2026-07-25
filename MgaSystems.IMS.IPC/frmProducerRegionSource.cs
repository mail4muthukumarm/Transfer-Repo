// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.frmProducerRegionSource
// Assembly: MgaSystems.IMS.IPC, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: F22CEF02-8C0F-420D-8344-A8A010CA7834
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.IPC.dll

using Infragistics.Win;
using Infragistics.Win.UltraWinGrid;
using Microsoft.VisualBasic.CompilerServices;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.InsuredsProducersCompanies;

[DesignerGenerated]
internal class frmProducerRegionSource : Form
{
  private IContainer components;

  public frmProducerRegionSource() => this.InitializeComponent();

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
    UltraGridBand ultraGridBand = new UltraGridBand("lstProducerLocationRegions", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("id");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("ProducerRegion");
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    this.ugSource = new UltraGrid();
    this.DsRegionSource1 = new dsRegionSource();
    ((ISupportInitialize) this.ugSource).BeginInit();
    this.DsRegionSource1.BeginInit();
    this.SuspendLayout();
    ((Control) this.ugSource).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraGridBase) this.ugSource).DataMember = "lstProducerLocationRegions";
    ((UltraGridBase) this.ugSource).DataSource = (object) this.DsRegionSource1;
    appearance1.BackColor = Color.LightGray;
    appearance1.FontData.BoldAsString = "True";
    appearance1.FontData.UnderlineAsString = "True";
    ((SpecialBoxBase) ((UltraGridBase) this.ugSource).DisplayLayout.AddNewBox).Appearance = (AppearanceBase) appearance1;
    appearance2.BorderColor = Color.Black;
    ((UltraGridBase) this.ugSource).DisplayLayout.AddNewBox.ButtonAppearance = (AppearanceBase) appearance2;
    ((SpecialBoxBase) ((UltraGridBase) this.ugSource).DisplayLayout.AddNewBox).Hidden = false;
    ((SpecialBoxBase) ((UltraGridBase) this.ugSource).DisplayLayout.AddNewBox).Prompt = " ";
    ((UltraGridBase) this.ugSource).DisplayLayout.AddNewBox.Style = (AddNewBoxStyle) 1;
    appearance3.BackColor = Color.White;
    appearance3.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.ugSource).DisplayLayout.Appearance = (AppearanceBase) appearance3;
    ((UltraGridBase) this.ugSource).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridBand.AddButtonCaption = "Add Source";
    ultraGridColumn1.CellActivation = (Activation) 2;
    ((HeaderBase) ultraGridColumn1.Header).Caption = "ID";
    ((HeaderBase) ultraGridColumn1.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.LockedWidth = true;
    ultraGridColumn1.Width = 42;
    ((HeaderBase) ultraGridColumn2.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn2.Header.VisiblePosition = 1;
    ultraGridColumn2.Width = 422;
    ultraGridBand.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2
    });
    ultraGridBand.Override.AllowDelete = (DefaultableBoolean) 1;
    ultraGridBand.Override.AllowUpdate = (DefaultableBoolean) 1;
    ((UltraGridBase) this.ugSource).DisplayLayout.BandsSerializer.Add((object) ultraGridBand);
    ((UltraGridBase) this.ugSource).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance4.BackColor = Color.LightSteelBlue;
    appearance4.FontData.SizeInPoints = 10f;
    appearance4.ForeColor = Color.Black;
    ((UltraGridBase) this.ugSource).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance4;
    appearance5.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance5.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance5.ForeColor = Color.Black;
    ((UltraGridBase) this.ugSource).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance5;
    ((UltraGridBase) this.ugSource).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.ugSource).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 1;
    ((UltraGridBase) this.ugSource).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 1;
    appearance6.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugSource).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance6;
    appearance7.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.ugSource).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance7;
    ((UltraGridBase) this.ugSource).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 2;
    ((UltraGridBase) this.ugSource).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance8.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.ugSource).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance8;
    appearance9.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugSource).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance9;
    ((UltraGridBase) this.ugSource).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 1;
    appearance10.BackColor = Color.Transparent;
    appearance10.ForeColor = Color.Black;
    ((UltraGridBase) this.ugSource).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance10;
    ((Control) this.ugSource).Font = new Font("Tahoma", 8.25f);
    ((Control) this.ugSource).Location = new Point(3, 3);
    ((Control) this.ugSource).Name = "ugSource";
    ((Control) this.ugSource).Size = new Size(485, 435);
    ((Control) this.ugSource).TabIndex = 375;
    ((Control) this.ugSource).Text = "Available Producer Regions";
    ((UltraControlBase) this.ugSource).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.ugSource).UseOsThemes = (DefaultableBoolean) 2;
    this.DsRegionSource1.DataSetName = "dsRegionSource";
    this.DsRegionSource1.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(500, 450);
    this.Controls.Add((Control) this.ugSource);
    this.Name = nameof (frmProducerRegionSource);
    this.Text = "Producer Region Source";
    ((ISupportInitialize) this.ugSource).EndInit();
    this.DsRegionSource1.EndInit();
    this.ResumeLayout(false);
  }

  [field: AccessedThroughProperty("ugSource")]
  protected virtual UltraGrid ugSource { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("DsRegionSource1")]
  internal virtual dsRegionSource DsRegionSource1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }
}
