// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.FormProducerLog
// Assembly: MgaSystems.IMS.IPC, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: F22CEF02-8C0F-420D-8344-A8A010CA7834
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.IPC.dll

using Infragistics.Win;
using Infragistics.Win.Layout;
using Infragistics.Win.UltraWinGrid;
using MGASystems.Data;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.InsuredsProducersCompanies;

[DesignerGenerated]
public class FormProducerLog : Form
{
  private IContainer components;
  private Guid _producerGUID;
  private Guid _producerLocationGUID;

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
    UltraGridBand ultraGridBand = new UltraGridBand("tblLog", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("Action");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("ActionDate");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("Name_LastFirst", -1, (object) null, 0, (SortIndicator) 1, false);
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
    this.UltraGrid1 = new UltraGrid();
    this.ds = new dsProducerLog();
    ((ISupportInitialize) this.UltraGrid1).BeginInit();
    this.ds.BeginInit();
    this.SuspendLayout();
    ((UltraGridBase) this.UltraGrid1).DataMember = "tblLog";
    ((UltraGridBase) this.UltraGrid1).DataSource = (object) this.ds;
    appearance1.BackColor = SystemColors.Window;
    appearance1.BorderColor = SystemColors.InactiveCaption;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Appearance = (AppearanceBase) appearance1;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn1.AllowGroupBy = (DefaultableBoolean) 1;
    ultraGridColumn1.AutoSizeEdit = (DefaultableBoolean) 1;
    ultraGridColumn1.CellActivation = (Activation) 3;
    ultraGridColumn1.CellMultiLine = (DefaultableBoolean) 1;
    ((HeaderBase) ultraGridColumn1.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn1.Header.VisiblePosition = 1;
    ultraGridColumn1.RowLayoutColumnInfo.AllowCellSizing = (RowLayoutSizing) 4;
    ultraGridColumn1.VertScrollBar = true;
    ultraGridColumn1.Width = 461;
    ultraGridColumn2.CellActivation = (Activation) 3;
    ultraGridColumn2.CellMultiLine = (DefaultableBoolean) 1;
    ultraGridColumn2.Format = "";
    ((HeaderBase) ultraGridColumn2.Header).Caption = "Action Date";
    ((HeaderBase) ultraGridColumn2.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn2.Header.VisiblePosition = 2;
    ultraGridColumn2.Width = 67;
    ((HeaderBase) ultraGridColumn3.Header).Caption = "User";
    ((HeaderBase) ultraGridColumn3.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn3.Header.VisiblePosition = 0;
    ultraGridColumn3.Width = 129;
    ultraGridBand.Columns.AddRange(new object[3]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3
    });
    ultraGridBand.Override.AllowDelete = (DefaultableBoolean) 2;
    ultraGridBand.Override.AllowRowLayoutCellSizing = (RowLayoutSizing) 4;
    ultraGridBand.Override.AllowRowLayoutCellSpanSizing = (GridBagLayoutAllowSpanSizing) 2;
    ultraGridBand.Override.RowSizing = (RowSizing) 5;
    ultraGridBand.Override.RowSizingArea = (RowSizingArea) 3;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.BandsSerializer.Add((object) ultraGridBand);
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.CaptionVisible = (DefaultableBoolean) 2;
    appearance2.BackColor = SystemColors.ActiveBorder;
    appearance2.BackColor2 = SystemColors.ControlDark;
    appearance2.BackGradientStyle = (GradientStyle) 2;
    appearance2.BorderColor = SystemColors.Window;
    ((SpecialBoxBase) ((UltraGridBase) this.UltraGrid1).DisplayLayout.GroupByBox).Appearance = (AppearanceBase) appearance2;
    appearance3.ForeColor = SystemColors.GrayText;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.GroupByBox.BandLabelAppearance = (AppearanceBase) appearance3;
    ((SpecialBoxBase) ((UltraGridBase) this.UltraGrid1).DisplayLayout.GroupByBox).BorderStyle = (UIElementBorderStyle) 4;
    appearance4.BackColor = SystemColors.ControlLightLight;
    appearance4.BackColor2 = SystemColors.Control;
    appearance4.BackGradientStyle = (GradientStyle) 3;
    appearance4.ForeColor = SystemColors.GrayText;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.GroupByBox.PromptAppearance = (AppearanceBase) appearance4;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.MaxColScrollRegions = 1;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.MaxRowScrollRegions = 1;
    appearance5.BackColor = SystemColors.Window;
    appearance5.ForeColor = SystemColors.ControlText;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Override.ActiveCellAppearance = (AppearanceBase) appearance5;
    appearance6.BackColor = SystemColors.Highlight;
    appearance6.ForeColor = SystemColors.HighlightText;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance6;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Override.AllowColSwapping = (AllowColSwapping) 1;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Override.AllowGroupBy = (DefaultableBoolean) 2;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 2;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 2;
    appearance7.BackColor = SystemColors.Window;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Override.CardAreaAppearance = (AppearanceBase) appearance7;
    appearance8.BorderColor = Color.Silver;
    appearance8.TextTrimming = (TextTrimming) 3;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance8;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Override.CellClickAction = (CellClickAction) 4;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Override.CellPadding = 0;
    appearance9.BackColor = SystemColors.Control;
    appearance9.BackColor2 = SystemColors.ControlDark;
    appearance9.BackGradientAlignment = (GradientAlignment) 1;
    appearance9.BackGradientStyle = (GradientStyle) 3;
    appearance9.BorderColor = SystemColors.Window;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Override.GroupByRowAppearance = (AppearanceBase) appearance9;
    ((AppearanceBase) appearance10).TextHAlignAsString = "Left";
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance10;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 2;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Override.HeaderStyle = (HeaderStyle) 2;
    appearance11.BackColor = SystemColors.Window;
    appearance11.BorderColor = Color.Silver;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance11;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance12.BackColor = SystemColors.ControlLight;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Override.TemplateAddRowAppearance = (AppearanceBase) appearance12;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Scrollbars = (Scrollbars) 3;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.ScrollBounds = (ScrollBounds) 0;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.ScrollStyle = (ScrollStyle) 1;
    ((Control) this.UltraGrid1).Dock = DockStyle.Fill;
    ((Control) this.UltraGrid1).Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.UltraGrid1).Location = new Point(0, 0);
    ((Control) this.UltraGrid1).Name = "UltraGrid1";
    ((Control) this.UltraGrid1).Size = new Size(676, 371);
    ((Control) this.UltraGrid1).TabIndex = 0;
    ((Control) this.UltraGrid1).Text = "UltraGrid1";
    this.ds.DataSetName = "dsProducerLog";
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    this.ClientSize = new Size(676, 371);
    this.Controls.Add((Control) this.UltraGrid1);
    this.Name = nameof (FormProducerLog);
    this.Text = "Producer / Location Activity Log";
    ((ISupportInitialize) this.UltraGrid1).EndInit();
    this.ds.EndInit();
    this.ResumeLayout(false);
  }

  [field: AccessedThroughProperty("ds")]
  internal virtual dsProducerLog ds { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraGrid1")]
  internal virtual UltraGrid UltraGrid1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  public FormProducerLog(Guid producerGUID, Guid producerLocationGUID)
  {
    this.Load += new EventHandler(this.FormProducerLog_Load);
    this.InitializeComponent();
    this._producerGUID = producerGUID;
    this._producerLocationGUID = producerLocationGUID;
  }

  private void FormProducerLog_Load(object sender, EventArgs e)
  {
    DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[1]
    {
      "tblLog"
    }, "dbo.GetProducerLogItems", new object[4]
    {
      (object) "@ProducerGUID",
      (object) this._producerGUID,
      (object) "@ProducerLocationGUID",
      (object) this._producerLocationGUID
    });
  }
}
