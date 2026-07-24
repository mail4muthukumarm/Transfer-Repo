// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Services.ExcelImport.UC_OfficeLocation
// Assembly: MgaSystems.IMS.Accounting.Services, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EEF87E2E-9738-4C33-AE03-5712A958CE99
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Services.dll

using Infragistics.Win;
using Infragistics.Win.UltraWinGrid;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.Tools;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Services.ExcelImport;

public class UC_OfficeLocation : UserControl
{
  private IContainer components;
  private Label label1;
  private MGASimpleComboBox comboOfficeLocations;

  [Browsable(false)]
  public int SelectedOfficeId
  {
    get
    {
      int selectedOfficeId = -1;
      if (((UltraDropDownBase) this.comboOfficeLocations).SelectedRow != null)
        selectedOfficeId = (int) ((UltraDropDownBase) this.comboOfficeLocations).SelectedRow.Cells["ID"].Value;
      return selectedOfficeId;
    }
  }

  [Browsable(false)]
  public bool OfficeIdSelected
  {
    get => ((UltraDropDownBase) this.comboOfficeLocations).SelectedRow != null;
  }

  [Browsable(true)]
  public int ComboBoxWidth
  {
    set => ((Control) this.comboOfficeLocations).Width = value;
    get => ((Control) this.comboOfficeLocations).Width;
  }

  [Browsable(true)]
  public event UC_OfficeLocation.RowSelectedHandler RowSelected;

  protected void OnRowSelected(RowSelectedEventArgs e)
  {
    if (this.RowSelected == null)
      return;
    this.RowSelected((object) this.comboOfficeLocations, e);
  }

  public UC_OfficeLocation() => this.InitializeComponent();

  private void UC_OfficeLocation_Load(object sender, EventArgs e)
  {
    if (this.DesignMode)
      return;
    ((UltraGridBase) this.comboOfficeLocations).DataSource = (object) DefaultDatabase.ExecuteDataTable("spFin_GetOfficeLocations", new object[2]
    {
      (object) "@userGuid",
      (object) CurrentUser.Instance.UserGUID
    });
    ((UltraDropDownBase) this.comboOfficeLocations).DisplayMember = "Office Location";
    ((UltraDropDownBase) this.comboOfficeLocations).ValueMember = "ID";
  }

  private void comboOfficeLocations_RowSelected(object sender, RowSelectedEventArgs e)
  {
    this.OnRowSelected(e);
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    this.label1 = new Label();
    this.comboOfficeLocations = new MGASimpleComboBox();
    ((ISupportInitialize) this.comboOfficeLocations).BeginInit();
    this.SuspendLayout();
    this.label1.AutoSize = true;
    this.label1.Font = new Font("Tahoma", 8.25f);
    this.label1.Location = new Point(3, 2);
    this.label1.Name = "label1";
    this.label1.Size = new Size(83, 13);
    this.label1.TabIndex = 0;
    this.label1.Text = "Office Location:";
    ((Control) this.comboOfficeLocations).Anchor = AnchorStyles.Left | AnchorStyles.Right;
    this.comboOfficeLocations.BorderStyle = (UIElementBorderStyle) 4;
    this.comboOfficeLocations.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboOfficeLocations).Font = new Font("Tahoma", 8.25f);
    ((Control) this.comboOfficeLocations).Location = new Point(6, 17);
    this.comboOfficeLocations.MGAStyle = MGAStyles.Blue;
    ((Control) this.comboOfficeLocations).Name = "comboOfficeLocations";
    ((Control) this.comboOfficeLocations).Size = new Size(284, 21);
    ((Control) this.comboOfficeLocations).TabIndex = 4;
    ((UltraControlBase) this.comboOfficeLocations).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboOfficeLocations).UseOsThemes = (DefaultableBoolean) 2;
    this.comboOfficeLocations.RowSelected += new RowSelectedEventHandler(this.comboOfficeLocations_RowSelected);
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.Transparent;
    this.Controls.Add((Control) this.comboOfficeLocations);
    this.Controls.Add((Control) this.label1);
    this.Font = new Font("Tahoma", 8.25f);
    this.Name = nameof (UC_OfficeLocation);
    this.Size = new Size(293, 48 /*0x30*/);
    this.Load += new EventHandler(this.UC_OfficeLocation_Load);
    ((ISupportInitialize) this.comboOfficeLocations).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  public delegate void RowSelectedHandler(object sender, RowSelectedEventArgs e);
}
