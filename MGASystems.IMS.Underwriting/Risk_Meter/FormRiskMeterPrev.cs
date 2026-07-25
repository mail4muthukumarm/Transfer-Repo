// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Underwriting.Risk_Meter.FormRiskMeterPrev
// Assembly: MGASystems.IMS.Underwriting, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 1057C5B8-8299-4767-8242-AF9F1EF932DB
// Assembly location: D:\augusta\fortegra\IMS Project\MGASystems.IMS.Underwriting.dll

using Infragistics.Win;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using MGASystems.Data;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Underwriting.Risk_Meter;

public class FormRiskMeterPrev : Form
{
  private int _quoteID;
  private IContainer components;
  private UltraGrid ug;
  private dsRiskMeter ds;

  public FormRiskMeterPrev(int quoteID)
  {
    this.InitializeComponent();
    this._quoteID = quoteID;
  }

  private void FormRiskMeterPrev_Load(object sender, EventArgs e)
  {
    DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[1]
    {
      "dtPrevious"
    }, "GetPreviousRiskMeterResults", new object[2]
    {
      (object) "@quoteID",
      (object) this._quoteID
    });
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
    UltraGridBand ultraGridBand = new UltraGridBand("dtPrevious", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("RanBy");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("Item");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("ItemResults");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("Added");
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("ItemDescription");
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    this.ug = new UltraGrid();
    this.ds = new dsRiskMeter();
    ((ISupportInitialize) this.ug).BeginInit();
    this.ds.BeginInit();
    this.SuspendLayout();
    ((Control) this.ug).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((Control) this.ug).Cursor = Cursors.Hand;
    ((UltraGridBase) this.ug).DataMember = "dtPrevious";
    ((UltraGridBase) this.ug).DataSource = (object) this.ds;
    ((AppearanceBase) appearance1).BackColor = Color.White;
    ((AppearanceBase) appearance1).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.ug).DisplayLayout.Appearance = (AppearanceBase) appearance1;
    ((UltraGridBase) this.ug).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn1.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn1.Header).Caption = "Ran By";
    ((HeaderBase) ultraGridColumn1.Header).VisiblePosition = 0;
    ultraGridColumn1.Width = 77;
    ultraGridColumn2.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn2.Header).VisiblePosition = 1;
    ultraGridColumn2.Width = 106;
    ultraGridColumn3.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn3.Header).Caption = "Item Results";
    ((HeaderBase) ultraGridColumn3.Header).VisiblePosition = 2;
    ultraGridColumn3.Width = 213;
    ultraGridColumn4.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn4.Header).VisiblePosition = 4;
    ultraGridColumn4.Width = 102;
    ultraGridColumn5.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn5.Header).Caption = "Item Description";
    ((HeaderBase) ultraGridColumn5.Header).VisiblePosition = 3;
    ultraGridColumn5.Width = 339;
    ultraGridBand.Columns.AddRange(new object[5]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3,
      (object) ultraGridColumn4,
      (object) ultraGridColumn5
    });
    ((UltraGridBase) this.ug).DisplayLayout.BandsSerializer.Add((object) ultraGridBand);
    ((UltraGridBase) this.ug).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((AppearanceBase) appearance2).BackColor = Color.LightSteelBlue;
    ((AppearanceBase) appearance2).FontData.SizeInPoints = 10f;
    ((AppearanceBase) appearance2).ForeColor = Color.Black;
    ((UltraGridBase) this.ug).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance2;
    ((AppearanceBase) appearance3).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance3).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance3).ForeColor = Color.Black;
    ((UltraGridBase) this.ug).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance3;
    ((UltraGridBase) this.ug).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((AppearanceBase) appearance4).BorderColor = Color.LightGray;
    ((UltraGridBase) this.ug).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance4;
    ((UltraGridBase) this.ug).DisplayLayout.Override.CellClickAction = (CellClickAction) 2;
    ((AppearanceBase) appearance5).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.ug).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance5;
    ((UltraGridBase) this.ug).DisplayLayout.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance6).BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.ug).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance6;
    ((AppearanceBase) appearance7).BorderColor = Color.LightGray;
    ((UltraGridBase) this.ug).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance7;
    ((AppearanceBase) appearance8).BackColor = Color.Transparent;
    ((AppearanceBase) appearance8).ForeColor = Color.Black;
    ((UltraGridBase) this.ug).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance8;
    scrollBarLook.ViewStyle = (ScrollBarViewStyle) 3;
    ((UltraGridBase) this.ug).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((Control) this.ug).Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.ug).Location = new Point(12, 12);
    ((Control) this.ug).Name = "ug";
    ((Control) this.ug).Size = new Size(858, 475);
    ((Control) this.ug).TabIndex = 259;
    ((Control) this.ug).Text = "Previous Risk Meter Results";
    ((UltraControlBase) this.ug).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.ug).UseOsThemes = (DefaultableBoolean) 2;
    this.ds.DataSetName = "dsRiskMeter";
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    this.ClientSize = new Size(882, 499);
    this.Controls.Add((Control) this.ug);
    this.Name = nameof (FormRiskMeterPrev);
    this.Text = "Previous Results";
    this.Load += new EventHandler(this.FormRiskMeterPrev_Load);
    ((ISupportInitialize) this.ug).EndInit();
    this.ds.EndInit();
    this.ResumeLayout(false);
  }
}
