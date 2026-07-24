// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Services.ExcelImport.UC_WorksheetList
// Assembly: MgaSystems.IMS.Accounting.Services, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EEF87E2E-9738-4C33-AE03-5712A958CE99
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Services.dll

using Infragistics.Shared;
using Infragistics.Win;
using Infragistics.Win.UltraWinGrid;
using MGASystems.Tools;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Services.ExcelImport;

public class UC_WorksheetList : UserControl
{
  private IContainer components;
  private MGASimpleComboBox comboWorksheetList;
  private Label label1;

  public DataTable WorksheetListDataSource
  {
    set => ((UltraGridBase) this.comboWorksheetList).DataSource = (object) value;
  }

  public string DisplayMember
  {
    set => ((UltraDropDownBase) this.comboWorksheetList).DisplayMember = value;
  }

  public string ValueMember
  {
    set => ((UltraDropDownBase) this.comboWorksheetList).ValueMember = value;
  }

  [Browsable(true)]
  public int ComboBoxWidth
  {
    set => ((Control) this.comboWorksheetList).Width = value;
    get => ((Control) this.comboWorksheetList).Width;
  }

  [Browsable(false)]
  public string SelectedWorksheet => ((Control) this.comboWorksheetList).Text;

  [Browsable(true)]
  public event UC_WorksheetList.RowSelectedHandler RowSelected;

  protected void OnRowSelected(RowSelectedEventArgs e)
  {
    if (this.RowSelected == null)
      return;
    this.RowSelected((object) this.comboWorksheetList, e);
  }

  public UC_WorksheetList() => this.InitializeComponent();

  private void comboWorksheetList_RowSelected(object sender, RowSelectedEventArgs e)
  {
    if (((UltraDropDownBase) this.comboWorksheetList).SelectedRow == null)
      return;
    this.OnRowSelected(e);
  }

  public void SetSelectedRow(int index)
  {
    if (index >= ((DisposableObjectCollectionBase) ((UltraGridBase) this.comboWorksheetList).Rows).Count)
      throw new IndexOutOfRangeException("The index you provided is greater than the available row index.");
    ((UltraDropDownBase) this.comboWorksheetList).SelectedRow = ((UltraGridBase) this.comboWorksheetList).Rows[index];
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    this.comboWorksheetList = new MGASimpleComboBox();
    this.label1 = new Label();
    ((ISupportInitialize) this.comboWorksheetList).BeginInit();
    this.SuspendLayout();
    ((Control) this.comboWorksheetList).Anchor = AnchorStyles.Left | AnchorStyles.Right;
    this.comboWorksheetList.BorderStyle = (UIElementBorderStyle) 4;
    this.comboWorksheetList.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboWorksheetList).Font = new Font("Tahoma", 8.25f);
    ((Control) this.comboWorksheetList).Location = new Point(6, 17);
    this.comboWorksheetList.MGAStyle = MGAStyles.Blue;
    ((Control) this.comboWorksheetList).Name = "comboWorksheetList";
    ((Control) this.comboWorksheetList).Size = new Size(284, 21);
    ((Control) this.comboWorksheetList).TabIndex = 3;
    ((UltraControlBase) this.comboWorksheetList).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboWorksheetList).UseOsThemes = (DefaultableBoolean) 2;
    this.comboWorksheetList.RowSelected += new RowSelectedEventHandler(this.comboWorksheetList_RowSelected);
    this.label1.AutoSize = true;
    this.label1.Font = new Font("Tahoma", 8.25f);
    this.label1.Location = new Point(3, 2);
    this.label1.Name = "label1";
    this.label1.Size = new Size(91, 13);
    this.label1.TabIndex = 2;
    this.label1.Text = "Excel Worksheet:";
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.Transparent;
    this.Controls.Add((Control) this.comboWorksheetList);
    this.Controls.Add((Control) this.label1);
    this.Name = nameof (UC_WorksheetList);
    this.Size = new Size(293, 48 /*0x30*/);
    ((ISupportInitialize) this.comboWorksheetList).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  public delegate void RowSelectedHandler(object sender, RowSelectedEventArgs e);
}
