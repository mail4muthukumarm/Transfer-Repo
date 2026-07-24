// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Services.Forms.FormAllocations
// Assembly: MgaSystems.IMS.Accounting.Services, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EEF87E2E-9738-4C33-AE03-5712A958CE99
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Services.dll

using Infragistics.Shared;
using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Services.Forms;

public class FormAllocations : FormBase
{
  private Decimal _amountToAllocate;
  private Decimal _leftToAllocate;
  private int _glCompanyId = -1;
  private List<Allocation> _costCenterAllocations;
  private IContainer components;
  private UltraGrid gridCostCenters;
  private MGAButton buttonCancel;
  private MGAButton buttonSave;
  private Label label1;
  private Label labelLeftToAllocate;

  public List<Allocation> CostCenterAllocations => this._costCenterAllocations;

  public FormAllocations() => this.InitializeComponent();

  public FormAllocations(int glCompanyId, Decimal amountToAllocate)
  {
    this.InitializeComponent();
    this._glCompanyId = glCompanyId;
    this._amountToAllocate = amountToAllocate;
    StringBuilder stringBuilder = new StringBuilder();
    stringBuilder.Append(this.Text);
    stringBuilder.Append(" - Amount To Allocate = ");
    stringBuilder.Append(this._amountToAllocate.ToString("c"));
    this.Text = stringBuilder.ToString();
  }

  public FormAllocations(int glCompanyId, Decimal amountToAllocate, List<Allocation> allocations)
  {
    this.InitializeComponent();
    this._costCenterAllocations = allocations;
    this._glCompanyId = glCompanyId;
    this._amountToAllocate = amountToAllocate;
    StringBuilder stringBuilder = new StringBuilder();
    stringBuilder.Append(this.Text);
    stringBuilder.Append(" - Amount To Allocate = ");
    stringBuilder.Append(this._amountToAllocate.ToString("c"));
    this.Text = stringBuilder.ToString();
  }

  private void mgaButton2_Click(object sender, EventArgs e)
  {
    this.DialogResult = DialogResult.Cancel;
    this.Close();
  }

  private void FormAllocations_Load(object sender, EventArgs e)
  {
    this.labelLeftToAllocate.Text = this._amountToAllocate.ToString("c");
    DataTable dataTable = DefaultDatabase.ExecuteDataTable("spfin_GetCostCentersList", new object[2]
    {
      (object) "@glcompanyid",
      (object) this._glCompanyId
    });
    dataTable.Columns.Add("Percentage", typeof (Decimal));
    dataTable.Columns["Percentage"].DefaultValue = (object) 0.0;
    dataTable.Columns.Add("Allocate", typeof (Decimal));
    dataTable.Columns["Allocate"].DefaultValue = (object) 0M;
    ((UltraGridBase) this.gridCostCenters).DataSource = (object) dataTable;
    ((UltraGridBase) this.gridCostCenters).DisplayLayout.Bands[0].Columns["CostCenterId"].Hidden = true;
    ((UltraGridBase) this.gridCostCenters).DisplayLayout.Bands[0].Columns["Name"].CellActivation = (Activation) 3;
    ((UltraGridBase) this.gridCostCenters).DisplayLayout.Bands[0].Columns["Allocate"].CellActivation = (Activation) 0;
    ((UltraGridBase) this.gridCostCenters).DisplayLayout.Bands[0].Columns["Allocate"].CellAppearance.TextHAlign = (HAlign) 3;
    ((HeaderBase) ((UltraGridBase) this.gridCostCenters).DisplayLayout.Bands[0].Columns["Allocate"].Header).Appearance.TextHAlign = (HAlign) 3;
    ((UltraGridBase) this.gridCostCenters).DisplayLayout.Bands[0].Columns["Allocate"].Format = "c";
    ((UltraGridBase) this.gridCostCenters).DisplayLayout.Bands[0].Columns["Percentage"].CellActivation = (Activation) 0;
    ((UltraGridBase) this.gridCostCenters).DisplayLayout.Bands[0].Columns["Percentage"].CellAppearance.TextHAlign = (HAlign) 3;
    ((HeaderBase) ((UltraGridBase) this.gridCostCenters).DisplayLayout.Bands[0].Columns["Percentage"].Header).Appearance.TextHAlign = (HAlign) 3;
    ((UltraGridBase) this.gridCostCenters).DisplayLayout.Bands[0].Columns["Percentage"].Format = "p";
    ((UltraGridBase) this.gridCostCenters).DisplayLayout.Bands[0].Columns["Percentage"].Nullable = (Nullable) 1;
    ((HeaderBase) ((UltraGridBase) this.gridCostCenters).DisplayLayout.Bands[0].Columns["Name"].Header).Appearance.TextHAlign = (HAlign) 1;
    ((UltraGridBase) this.gridCostCenters).DisplayLayout.Bands[0].Override.AllowAddNew = (AllowAddNew) 2;
    ((UltraGridBase) this.gridCostCenters).DisplayLayout.Bands[0].Override.AllowUpdate = (DefaultableBoolean) 1;
    ((UltraGridBase) this.gridCostCenters).DisplayLayout.Bands[0].Summaries.Add("AmountSummary", (SummaryType) 1, ((UltraGridBase) this.gridCostCenters).DisplayLayout.Bands[0].Columns["Allocate"], (SummaryPosition) 3);
    ((UltraGridBase) this.gridCostCenters).DisplayLayout.Bands[0].Summaries[0].Appearance.TextHAlign = (HAlign) 3;
    ((UltraGridBase) this.gridCostCenters).DisplayLayout.Bands[0].Summaries[0].DisplayFormat = "{0:c}";
    if (this._costCenterAllocations == null)
      return;
    this.DisplayCurrentAllocations();
  }

  private void buttonSave_Click(object sender, EventArgs e)
  {
    ((UltraGridBase) this.gridCostCenters).ActiveRow.Update();
    ((UltraGridBase) this.gridCostCenters).UpdateData();
    if (this._leftToAllocate != 0M)
    {
      int num = (int) MessageBox.Show("You must allocate the entire amount to continue.", "Invalid Allocation!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
    else
    {
      this._costCenterAllocations = new List<Allocation>();
      foreach (UltraGridRow row in ((UltraGridBase) this.gridCostCenters).Rows)
      {
        Decimal result;
        if (row.Cells["Allocate"].Value != null && Decimal.TryParse(row.Cells["Allocate"].Value.ToString(), out result))
        {
          if (row.Cells["Percentage"].Value == null || string.IsNullOrEmpty(row.Cells["percentage"].Value.ToString()))
            this._costCenterAllocations.Add(new Allocation(row.Cells["Name"].Value.ToString(), (int) row.Cells["CostCenterId"].Value, result));
          else
            this._costCenterAllocations.Add(new Allocation(row.Cells["Name"].Value.ToString(), (int) row.Cells["CostCenterId"].Value, Decimal.Parse(row.Cells["percentage"].Value.ToString()), result));
        }
      }
      this.DialogResult = DialogResult.OK;
      this.Close();
    }
  }

  private void gridCostCenters_SummaryValueChanged(object sender, SummaryValueChangedEventArgs e)
  {
  }

  private void DisplayCurrentAllocations()
  {
    for (int index = 0; index < this._costCenterAllocations.Count; ++index)
    {
      foreach (UltraGridRow row in ((UltraGridBase) this.gridCostCenters).Rows)
      {
        if ((int) row.Cells["CostCenterId"].Value == this._costCenterAllocations[index].CostCenterId)
        {
          row.Cells["Allocate"].Value = (object) this._costCenterAllocations[index].AllocatedAmount;
          if (this._costCenterAllocations[index].Percentage.HasValue)
          {
            row.Cells["Percentage"].Value = (object) this._costCenterAllocations[index].Percentage;
            break;
          }
          break;
        }
      }
    }
  }

  private void gridCostCenters_AfterSelectChange(object sender, AfterSelectChangeEventArgs e)
  {
    if (((SparseCollectionBase) this.gridCostCenters.Selected.Rows).Count == 0)
      return;
    this.gridCostCenters.Selected.Rows[0].Cells["Allocate"].Activate();
  }

  private void gridCostCenters_AfterCellUpdate(object sender, CellEventArgs e)
  {
    switch (((KeyedSubObjectBase) e.Cell.Column).Key)
    {
      case "Percentage":
        if (string.IsNullOrEmpty(e.Cell.Value.ToString()))
          break;
        this.gridCostCenters.EventManager.SetEnabled((GridEventIds) 4, false);
        e.Cell.Row.Cells["Allocate"].Value = (object) Math.Round(this._amountToAllocate * (Decimal) e.Cell.Value, 2);
        this.gridCostCenters.EventManager.SetEnabled((GridEventIds) 4, true);
        break;
      case "Allocate":
        if (string.IsNullOrEmpty(e.Cell.Row.Cells["Percentage"].Value.ToString()) || !((Decimal) e.Cell.Row.Cells["Percentage"].Value != 0M) || !(Decimal.Parse(e.Cell.Value.ToString()) != Decimal.Round(this._amountToAllocate * (Decimal) e.Cell.Row.Cells["Percentage"].Value, 2)))
          break;
        if (MessageBox.Show("Changing this value will invalidate the percentage entered. Continue?", "Clear Percentage?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        {
          this.gridCostCenters.EventManager.SetEnabled((GridEventIds) 4, false);
          this.gridCostCenters.EventManager.SetEnabled((GridEventIds) 57, false);
          e.Cell.Row.Cells["Percentage"].Value = (object) DBNull.Value;
          this.gridCostCenters.EventManager.SetEnabled((GridEventIds) 57, true);
          this.gridCostCenters.EventManager.SetEnabled((GridEventIds) 4, true);
          break;
        }
        e.Cell.Value = (object) Decimal.Round(this._amountToAllocate * (Decimal) e.Cell.Row.Cells["Percentage"].Value, 2);
        break;
    }
  }

  private void gridCostCenters_AfterRowUpdate(object sender, RowEventArgs e)
  {
    Decimal num = 0M;
    Decimal result = 0M;
    foreach (UltraGridRow row in ((UltraGridBase) this.gridCostCenters).Rows)
    {
      if (Decimal.TryParse(row.Cells["Allocate"].Value.ToString(), out result))
        num += result;
    }
    this._leftToAllocate = this._amountToAllocate - num;
    this.labelLeftToAllocate.Text = (this._amountToAllocate - num).ToString("c");
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
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (FormAllocations));
    Appearance appearance11 = new Appearance();
    this.gridCostCenters = new UltraGrid();
    this.buttonCancel = new MGAButton();
    this.buttonSave = new MGAButton();
    this.label1 = new Label();
    this.labelLeftToAllocate = new Label();
    ((ISupportInitialize) this.gridCostCenters).BeginInit();
    ((ISupportInitialize) this.buttonCancel).BeginInit();
    ((ISupportInitialize) this.buttonSave).BeginInit();
    this.SuspendLayout();
    ((AppearanceBase) appearance1).BackColor = Color.White;
    ((AppearanceBase) appearance1).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.gridCostCenters).DisplayLayout.Appearance = (AppearanceBase) appearance1;
    ((UltraGridBase) this.gridCostCenters).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ((UltraGridBase) this.gridCostCenters).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((AppearanceBase) appearance2).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance2).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance2).ForeColor = Color.Black;
    ((UltraGridBase) this.gridCostCenters).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance2;
    ((UltraGridBase) this.gridCostCenters).DisplayLayout.Override.AllowAddNew = (AllowAddNew) 2;
    ((UltraGridBase) this.gridCostCenters).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 1;
    ((UltraGridBase) this.gridCostCenters).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridCostCenters).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 1;
    ((AppearanceBase) appearance3).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridCostCenters).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance3;
    ((AppearanceBase) appearance4).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.gridCostCenters).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance4;
    ((UltraGridBase) this.gridCostCenters).DisplayLayout.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance5).BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.gridCostCenters).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance5;
    ((AppearanceBase) appearance6).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridCostCenters).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance6;
    ((UltraGridBase) this.gridCostCenters).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance7).BackColor = Color.Transparent;
    ((AppearanceBase) appearance7).ForeColor = Color.Black;
    ((UltraGridBase) this.gridCostCenters).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance7;
    ((UltraGridBase) this.gridCostCenters).DisplayLayout.Override.SummaryFooterCaptionVisible = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance8).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance8).BorderColor = Color.Silver;
    scrollBarLook.ButtonAppearance = (AppearanceBase) appearance8;
    ((AppearanceBase) appearance9).BackColor = Color.White;
    scrollBarLook.TrackAppearance = (AppearanceBase) appearance9;
    ((UltraGridBase) this.gridCostCenters).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((Control) this.gridCostCenters).Location = new Point(13, 12);
    ((Control) this.gridCostCenters).Name = "gridCostCenters";
    ((Control) this.gridCostCenters).Size = new Size(324, 369);
    ((Control) this.gridCostCenters).TabIndex = 0;
    ((UltraControlBase) this.gridCostCenters).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.gridCostCenters).UseOsThemes = (DefaultableBoolean) 2;
    this.gridCostCenters.AfterCellUpdate += new CellEventHandler(this.gridCostCenters_AfterCellUpdate);
    this.gridCostCenters.AfterRowUpdate += new RowEventHandler(this.gridCostCenters_AfterRowUpdate);
    this.gridCostCenters.AfterSelectChange += new AfterSelectChangeEventHandler(this.gridCostCenters_AfterSelectChange);
    this.gridCostCenters.SummaryValueChanged += new SummaryValueChangedEventHandler(this.gridCostCenters_SummaryValueChanged);
    ((AppearanceBase) appearance10).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance10).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance10).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance10).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance10).Image = componentResourceManager.GetObject("appearance13.Image");
    ((AppearanceBase) appearance10).ImageHAlign = (HAlign) 1;
    ((AppearanceBase) appearance10).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonCancel).Appearance = (AppearanceBase) appearance10;
    ((UltraButtonBase) this.buttonCancel).DialogResult = DialogResult.Cancel;
    ((Control) this.buttonCancel).Location = new Point(265, 388);
    ((Control) this.buttonCancel).Name = "buttonCancel";
    ((Control) this.buttonCancel).Size = new Size(75, 27);
    ((Control) this.buttonCancel).TabIndex = 2;
    ((Control) this.buttonCancel).Text = "Cancel";
    ((UltraControlBase) this.buttonCancel).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.buttonCancel).Click += new EventHandler(this.mgaButton2_Click);
    ((AppearanceBase) appearance11).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance11).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance11).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance11).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance11).Image = componentResourceManager.GetObject("appearance14.Image");
    ((AppearanceBase) appearance11).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonSave).Appearance = (AppearanceBase) appearance11;
    ((Control) this.buttonSave).Location = new Point(187, 388);
    ((Control) this.buttonSave).Name = "buttonSave";
    ((Control) this.buttonSave).Size = new Size(72, 27);
    ((Control) this.buttonSave).TabIndex = 3;
    ((Control) this.buttonSave).Text = "Save";
    ((UltraControlBase) this.buttonSave).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.buttonSave).Click += new EventHandler(this.buttonSave_Click);
    this.label1.AutoSize = true;
    this.label1.BackColor = Color.Transparent;
    this.label1.Font = new Font("Tahoma", 8.25f, FontStyle.Bold);
    this.label1.Location = new Point(13, 388);
    this.label1.Name = "label1";
    this.label1.Size = new Size(98, 13);
    this.label1.TabIndex = 4;
    this.label1.Text = "Left To Allocate:";
    this.labelLeftToAllocate.AutoSize = true;
    this.labelLeftToAllocate.BackColor = Color.Transparent;
    this.labelLeftToAllocate.Location = new Point(11, 402);
    this.labelLeftToAllocate.Name = "labelLeftToAllocate";
    this.labelLeftToAllocate.Size = new Size(35, 13);
    this.labelLeftToAllocate.TabIndex = 5;
    this.labelLeftToAllocate.Text = "$0.00";
    this.AcceptButton = (IButtonControl) this.buttonSave;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.CancelButton = (IButtonControl) this.buttonCancel;
    this.ClientSize = new Size(349, 419);
    this.ControlBox = false;
    this.Controls.Add((Control) this.labelLeftToAllocate);
    this.Controls.Add((Control) this.label1);
    this.Controls.Add((Control) this.buttonSave);
    this.Controls.Add((Control) this.buttonCancel);
    this.Controls.Add((Control) this.gridCostCenters);
    this.Font = new Font("Tahoma", 8.25f);
    this.FormBorderStyle = FormBorderStyle.FixedDialog;
    this.Name = nameof (FormAllocations);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Cost Center Allocation";
    this.Load += new EventHandler(this.FormAllocations_Load);
    ((ISupportInitialize) this.gridCostCenters).EndInit();
    ((ISupportInitialize) this.buttonCancel).EndInit();
    ((ISupportInitialize) this.buttonSave).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }
}
