// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Services.ExcelImport.FormExcelImportTest
// Assembly: MgaSystems.IMS.Accounting.Services, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EEF87E2E-9738-4C33-AE03-5712A958CE99
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Services.dll

using Infragistics.Win;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using Infragistics.Win.UltraWinToolbars;
using MGASystems.IMS.Forms;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Services.ExcelImport;

[TestForm]
public class FormExcelImportTest : FormExcelImportBase
{
  private const string DB_TABLENAME = "dbo.TestExcelImport";
  private IContainer components;

  public FormExcelImportTest()
    : base(true, false)
  {
    this.InitializeComponent();
  }

  private void FormExcelImportTest_Load(object sender, EventArgs e) => this.SetMappings();

  private void SetMappings()
  {
    this.Mappings.Add(new ExcelImportMapping("Dan1", typeof (string), true));
    this.Mappings.Add(new ExcelImportMapping("Dan2", typeof (Decimal)));
    this.Mappings.Add(new ExcelImportMapping("Dan3", typeof (int)));
    this.Mappings.Add(new ExcelImportMapping("Dan4", typeof (DateTime)));
    this.Mappings.Add(new ExcelImportMapping("DateFieldFromHell", typeof (DateTime), (object) null));
  }

  private void FormExcelImportTest_ExcelMappingsComplete(object sender, EventArgs e)
  {
    this.PerformDataCheck();
    if (this.DataIssuesFound)
      return;
    this.PerformBulkInsert("dbo.TestExcelImport");
  }

  private void FormExcelImportTest_ExcelMappingsReset(object sender, EventArgs e)
  {
    this.SetMappings();
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
    ((ISupportInitialize) this.toolManager).BeginInit();
    ((Control) this.FormExcelImportBase_Fill_Panel.ClientArea).SuspendLayout();
    ((Control) this.FormExcelImportBase_Fill_Panel).SuspendLayout();
    ((ISupportInitialize) this.gridExcelData).BeginInit();
    this.SuspendLayout();
    ((SettingsBase) this.toolManager.MenuSettings).ForceSerialization = true;
    ((SettingsBase) this.toolManager.ToolbarSettings).ForceSerialization = true;
    ((Control) this.FormExcelImportBase_Fill_Panel).Location = new Point(0, 50);
    ((Control) this.FormExcelImportBase_Fill_Panel).Size = new Size(1045, 612);
    ((AppearanceBase) appearance1).BackColor = Color.White;
    ((AppearanceBase) appearance1).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.gridExcelData).DisplayLayout.Appearance = (AppearanceBase) appearance1;
    ((UltraGridBase) this.gridExcelData).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ((UltraGridBase) this.gridExcelData).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((AppearanceBase) appearance2).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance2).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance2).ForeColor = Color.Black;
    ((UltraGridBase) this.gridExcelData).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance2;
    ((UltraGridBase) this.gridExcelData).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.gridExcelData).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridExcelData).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance3).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridExcelData).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance3;
    ((UltraGridBase) this.gridExcelData).DisplayLayout.Override.CellClickAction = (CellClickAction) 2;
    ((AppearanceBase) appearance4).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.gridExcelData).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance4;
    ((UltraGridBase) this.gridExcelData).DisplayLayout.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance5).BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.gridExcelData).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance5;
    ((AppearanceBase) appearance6).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridExcelData).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance6;
    ((UltraGridBase) this.gridExcelData).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance7).BackColor = Color.Transparent;
    ((AppearanceBase) appearance7).ForeColor = Color.Black;
    ((UltraGridBase) this.gridExcelData).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance7;
    ((AppearanceBase) appearance8).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance8).BorderColor = Color.Silver;
    scrollBarLook.ButtonAppearance = (AppearanceBase) appearance8;
    ((AppearanceBase) appearance9).BackColor = Color.White;
    scrollBarLook.TrackAppearance = (AppearanceBase) appearance9;
    ((UltraGridBase) this.gridExcelData).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((Control) this.gridExcelData).Size = new Size(1045, 612);
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(1045, 662);
    this.Name = nameof (FormExcelImportTest);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Excel Import Test";
    this.ExcelMappingsComplete += new EventHandler<EventArgs>(this.FormExcelImportTest_ExcelMappingsComplete);
    this.ExcelMappingsReset += new EventHandler<EventArgs>(this.FormExcelImportTest_ExcelMappingsReset);
    this.Load += new EventHandler(this.FormExcelImportTest_Load);
    ((ISupportInitialize) this.toolManager).EndInit();
    ((Control) this.FormExcelImportBase_Fill_Panel.ClientArea).ResumeLayout(false);
    ((Control) this.FormExcelImportBase_Fill_Panel).ResumeLayout(false);
    ((ISupportInitialize) this.gridExcelData).EndInit();
    this.ResumeLayout(false);
  }
}
