// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Core.Forms.FormAppliedUnaccounted
// Assembly: MgaSystems.IMS.Accounting.Core, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 923053EF-B70A-44B5-B8DA-B227263F4FD2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Core.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.IMS.Accounting.Core.Properties;
using MGASystems.Tools;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Core.Forms;

public class FormAppliedUnaccounted : FormBase
{
  private Guid _entityGuid;
  private IContainer components;
  private dsAppliedUnaccounted dsAppliedUnaccounted1;
  protected UltraGrid gridUnaccounted;
  protected MGAButton buttonCancel;
  protected MGAButton buttonSave;

  public dsAppliedUnaccounted AppliedUnaccountedData => this.dsAppliedUnaccounted1;

  public virtual Decimal AppliedAmount
  {
    get => (Decimal) ((UltraGridBase) this.gridUnaccounted).Rows.SummaryValues[0].Value;
  }

  public string CheckNumber
  {
    get
    {
      int num = 0;
      string empty = string.Empty;
      foreach (UltraGridRow row in ((UltraGridBase) this.gridUnaccounted).Rows)
      {
        if (row.Cells["appliedamount"].Value != DBNull.Value)
          ++num;
      }
      if (num == 1)
      {
        foreach (UltraGridRow row in ((UltraGridBase) this.gridUnaccounted).Rows)
        {
          if (row.Cells["appliedamount"].Value != DBNull.Value)
          {
            empty = row.Cells[nameof (CheckNumber)].Value.ToString();
            break;
          }
        }
      }
      return empty;
    }
  }

  public FormAppliedUnaccounted() => this.InitializeComponent();

  public FormAppliedUnaccounted(Guid entityGuid)
  {
    this.InitializeComponent();
    this._entityGuid = entityGuid;
  }

  private void FormAppliedUnaccounted_Load(object sender, EventArgs e)
  {
    if (this.DesignMode)
      return;
    DefaultDatabase.LoadDataSet((DataSet) this.dsAppliedUnaccounted1, new string[1]
    {
      "AppliedUnaccounted"
    }, "spFin_GetEntityUnaccountedTransactions", new object[2]
    {
      (object) "@entityGuid",
      (object) this._entityGuid
    });
  }

  private void buttonSave_Click(object sender, EventArgs e)
  {
    ((UltraGridBase) this.gridUnaccounted).UpdateData();
    if (!this.ValidateForm())
      return;
    this.DialogResult = DialogResult.OK;
    this.Close();
  }

  private void buttonCancel_Click(object sender, EventArgs e)
  {
    this.DialogResult = DialogResult.Cancel;
    this.Close();
  }

  protected virtual void gridUnaccounted_ClickCellButton(object sender, CellEventArgs e)
  {
    e.Cell.Value = (object) -Decimal.Parse(e.Cell.Row.Cells["balance"].Value.ToString(), NumberStyles.Any);
  }

  protected virtual bool ValidateForm() => true;

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
    UltraGridBand ultraGridBand = new UltraGridBand("AppliedUnaccounted", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("PostDate");
    Appearance appearance4 = new Appearance();
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("TransactNum");
    Appearance appearance5 = new Appearance();
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("EnteredBy");
    Appearance appearance6 = new Appearance();
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("CheckNumber");
    Appearance appearance7 = new Appearance();
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("CheckAmount");
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("ARAmount");
    Appearance appearance10 = new Appearance();
    Appearance appearance11 = new Appearance();
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("Amount");
    Appearance appearance12 = new Appearance();
    Appearance appearance13 = new Appearance();
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("Balance");
    Appearance appearance14 = new Appearance();
    Appearance appearance15 = new Appearance();
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("AppliedAmount");
    Appearance appearance16 = new Appearance();
    Appearance appearance17 = new Appearance();
    Appearance appearance18 = new Appearance();
    SummarySettings summarySettings = new SummarySettings("", (SummaryType) 1, (string) null, "AppliedAmount", 8, true, "AppliedUnaccounted", 0, (SummaryPosition) 3, "AppliedAmount", 8, true);
    Appearance appearance19 = new Appearance();
    Appearance appearance20 = new Appearance();
    Appearance appearance21 = new Appearance();
    Appearance appearance22 = new Appearance();
    Appearance appearance23 = new Appearance();
    Appearance appearance24 = new Appearance();
    Appearance appearance25 = new Appearance();
    Appearance appearance26 = new Appearance();
    Appearance appearance27 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    Appearance appearance28 = new Appearance();
    Appearance appearance29 = new Appearance();
    this.buttonCancel = new MGAButton();
    this.buttonSave = new MGAButton();
    this.gridUnaccounted = new UltraGrid();
    this.dsAppliedUnaccounted1 = new dsAppliedUnaccounted();
    ((ISupportInitialize) this.buttonCancel).BeginInit();
    ((ISupportInitialize) this.buttonSave).BeginInit();
    ((ISupportInitialize) this.gridUnaccounted).BeginInit();
    this.dsAppliedUnaccounted1.BeginInit();
    this.SuspendLayout();
    ((AppearanceBase) appearance1).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance1).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance1).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance1).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance1).ImageHAlign = (HAlign) 2;
    ((AppearanceBase) appearance1).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonCancel).Appearance = (AppearanceBase) appearance1;
    ((Control) this.buttonCancel).Location = new Point(835, 345);
    ((Control) this.buttonCancel).Name = "buttonCancel";
    ((Control) this.buttonCancel).Size = new Size(91, 26);
    ((Control) this.buttonCancel).TabIndex = 1;
    ((Control) this.buttonCancel).Text = "Cancel";
    ((UltraControlBase) this.buttonCancel).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.buttonCancel).Click += new EventHandler(this.buttonCancel_Click);
    ((AppearanceBase) appearance2).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance2).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance2).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance2).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance2).ImageHAlign = (HAlign) 2;
    ((AppearanceBase) appearance2).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonSave).Appearance = (AppearanceBase) appearance2;
    ((Control) this.buttonSave).Location = new Point(738, 345);
    ((Control) this.buttonSave).Name = "buttonSave";
    ((Control) this.buttonSave).Size = new Size(91, 26);
    ((Control) this.buttonSave).TabIndex = 2;
    ((Control) this.buttonSave).Text = "Save";
    ((UltraControlBase) this.buttonSave).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.buttonSave).Click += new EventHandler(this.buttonSave_Click);
    ((UltraGridBase) this.gridUnaccounted).DataSource = (object) this.dsAppliedUnaccounted1;
    ((AppearanceBase) appearance3).BackColor = Color.White;
    ((AppearanceBase) appearance3).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.gridUnaccounted).DisplayLayout.Appearance = (AppearanceBase) appearance3;
    ((UltraGridBase) this.gridUnaccounted).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn1.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance4).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn1.Header).Appearance = (AppearanceBase) appearance4;
    ((HeaderBase) ultraGridColumn1.Header).Caption = "Post Date";
    ((HeaderBase) ultraGridColumn1.Header).VisiblePosition = 0;
    ultraGridColumn1.Width = 72;
    ultraGridColumn2.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance5).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn2.Header).Appearance = (AppearanceBase) appearance5;
    ((HeaderBase) ultraGridColumn2.Header).Caption = "Transaction #";
    ((HeaderBase) ultraGridColumn2.Header).VisiblePosition = 1;
    ultraGridColumn2.Width = 87;
    ultraGridColumn3.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance6).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn3.Header).Appearance = (AppearanceBase) appearance6;
    ((HeaderBase) ultraGridColumn3.Header).Caption = "Entered By";
    ((HeaderBase) ultraGridColumn3.Header).VisiblePosition = 2;
    ultraGridColumn3.Hidden = true;
    ultraGridColumn3.Width = 198;
    ultraGridColumn4.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance7).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn4.Header).Appearance = (AppearanceBase) appearance7;
    ((HeaderBase) ultraGridColumn4.Header).Caption = "Check #";
    ((HeaderBase) ultraGridColumn4.Header).VisiblePosition = 3;
    ultraGridColumn4.Width = 137;
    ultraGridColumn5.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance8).TextHAlignAsString = "Right";
    ultraGridColumn5.CellAppearance = (AppearanceBase) appearance8;
    ultraGridColumn5.Format = "c";
    ((AppearanceBase) appearance9).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn5.Header).Appearance = (AppearanceBase) appearance9;
    ((HeaderBase) ultraGridColumn5.Header).Caption = "Check Amount";
    ((HeaderBase) ultraGridColumn5.Header).VisiblePosition = 5;
    ultraGridColumn5.Width = 137;
    ultraGridColumn6.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance10).TextHAlignAsString = "Right";
    ultraGridColumn6.CellAppearance = (AppearanceBase) appearance10;
    ultraGridColumn6.Format = "c";
    ((AppearanceBase) appearance11).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn6.Header).Appearance = (AppearanceBase) appearance11;
    ((HeaderBase) ultraGridColumn6.Header).Caption = "AR Applied Amount";
    ((HeaderBase) ultraGridColumn6.Header).VisiblePosition = 6;
    ultraGridColumn6.Width = 135;
    ultraGridColumn7.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance12).TextHAlignAsString = "Right";
    ultraGridColumn7.CellAppearance = (AppearanceBase) appearance12;
    ultraGridColumn7.Format = "c";
    ((AppearanceBase) appearance13).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn7.Header).Appearance = (AppearanceBase) appearance13;
    ((HeaderBase) ultraGridColumn7.Header).VisiblePosition = 4;
    ultraGridColumn7.Hidden = true;
    ultraGridColumn7.Width = 105;
    ultraGridColumn8.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance14).TextHAlignAsString = "Right";
    ultraGridColumn8.CellAppearance = (AppearanceBase) appearance14;
    ultraGridColumn8.Format = "c";
    ((AppearanceBase) appearance15).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn8.Header).Appearance = (AppearanceBase) appearance15;
    ((HeaderBase) ultraGridColumn8.Header).Caption = "Un-Acct Balance";
    ((HeaderBase) ultraGridColumn8.Header).VisiblePosition = 7;
    ultraGridColumn8.Width = 179;
    ((AppearanceBase) appearance16).BackColor = Color.LightSteelBlue;
    ((AppearanceBase) appearance16).TextHAlignAsString = "Right";
    ultraGridColumn9.CellAppearance = (AppearanceBase) appearance16;
    ((AppearanceBase) appearance17).Image = (object) Resources.wrench_orange;
    ultraGridColumn9.CellButtonAppearance = (AppearanceBase) appearance17;
    ultraGridColumn9.Format = "c";
    ((AppearanceBase) appearance18).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn9.Header).Appearance = (AppearanceBase) appearance18;
    ((HeaderBase) ultraGridColumn9.Header).Caption = "Applied Un-Acct Amount";
    ((HeaderBase) ultraGridColumn9.Header).VisiblePosition = 8;
    ultraGridColumn9.Style = (ColumnStyle) 2;
    ultraGridColumn9.Width = 164;
    ultraGridBand.Columns.AddRange(new object[9]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3,
      (object) ultraGridColumn4,
      (object) ultraGridColumn5,
      (object) ultraGridColumn6,
      (object) ultraGridColumn7,
      (object) ultraGridColumn8,
      (object) ultraGridColumn9
    });
    ultraGridBand.Override.AllowUpdate = (DefaultableBoolean) 1;
    ((AppearanceBase) appearance19).BackColor = Color.LightSteelBlue;
    ((AppearanceBase) appearance19).FontData.BoldAsString = "True";
    ((AppearanceBase) appearance19).TextHAlignAsString = "Right";
    summarySettings.Appearance = (AppearanceBase) appearance19;
    summarySettings.DisplayFormat = "{0:c}";
    summarySettings.GroupBySummaryValueAppearance = (AppearanceBase) appearance20;
    ultraGridBand.Summaries.AddRange(new SummarySettings[1]
    {
      summarySettings
    });
    ultraGridBand.SummaryFooterCaption = "";
    ((UltraGridBase) this.gridUnaccounted).DisplayLayout.BandsSerializer.Add((object) ultraGridBand);
    ((UltraGridBase) this.gridUnaccounted).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((AppearanceBase) appearance21).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance21).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance21).ForeColor = Color.Black;
    ((UltraGridBase) this.gridUnaccounted).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance21;
    ((UltraGridBase) this.gridUnaccounted).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.gridUnaccounted).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridUnaccounted).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance22).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridUnaccounted).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance22;
    ((AppearanceBase) appearance23).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.gridUnaccounted).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance23;
    ((UltraGridBase) this.gridUnaccounted).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 2;
    ((UltraGridBase) this.gridUnaccounted).DisplayLayout.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance24).BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.gridUnaccounted).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance24;
    ((AppearanceBase) appearance25).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridUnaccounted).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance25;
    ((UltraGridBase) this.gridUnaccounted).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance26).BackColor = Color.Transparent;
    ((AppearanceBase) appearance26).ForeColor = Color.Black;
    ((UltraGridBase) this.gridUnaccounted).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance26;
    ((AppearanceBase) appearance27).BackColor = Color.LightSteelBlue;
    ((UltraGridBase) this.gridUnaccounted).DisplayLayout.Override.SummaryFooterAppearance = (AppearanceBase) appearance27;
    ((UltraGridBase) this.gridUnaccounted).DisplayLayout.Override.SummaryFooterCaptionVisible = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance28).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance28).BorderColor = Color.Silver;
    scrollBarLook.ButtonAppearance = (AppearanceBase) appearance28;
    ((AppearanceBase) appearance29).BackColor = Color.White;
    scrollBarLook.TrackAppearance = (AppearanceBase) appearance29;
    ((UltraGridBase) this.gridUnaccounted).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((Control) this.gridUnaccounted).Location = new Point(13, 13);
    ((Control) this.gridUnaccounted).Name = "gridUnaccounted";
    ((Control) this.gridUnaccounted).Size = new Size(913, 326);
    ((Control) this.gridUnaccounted).TabIndex = 0;
    ((UltraControlBase) this.gridUnaccounted).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.gridUnaccounted).UseOsThemes = (DefaultableBoolean) 2;
    this.gridUnaccounted.ClickCellButton += new CellEventHandler(this.gridUnaccounted_ClickCellButton);
    this.dsAppliedUnaccounted1.DataSetName = "dsAppliedUnaccounted";
    this.dsAppliedUnaccounted1.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(938, 375);
    this.Controls.Add((Control) this.buttonSave);
    this.Controls.Add((Control) this.buttonCancel);
    this.Controls.Add((Control) this.gridUnaccounted);
    this.Font = new Font("Tahoma", 8.25f);
    this.Name = nameof (FormAppliedUnaccounted);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Apply Un-Accounted";
    this.Load += new EventHandler(this.FormAppliedUnaccounted_Load);
    ((ISupportInitialize) this.buttonCancel).EndInit();
    ((ISupportInitialize) this.buttonSave).EndInit();
    ((ISupportInitialize) this.gridUnaccounted).EndInit();
    this.dsAppliedUnaccounted1.EndInit();
    this.ResumeLayout(false);
  }
}
