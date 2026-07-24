// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Analysis.GLMasterAccounts.FormOfficeLocations
// Assembly: MgaSystems.IMS.Accounting.Analysis, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 8E3A477E-E77B-44DA-B1A6-ED3671BCE2BE
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Analysis.dll

using Infragistics.Shared;
using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinListView;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Analysis.GLMasterAccounts;

public class FormOfficeLocations : FormBase
{
  private List<int> _selectedOffices;
  private IContainer components;
  private MGAButton buttonSave;
  private MGAButton buttonCancel;
  private UltraListView ultraListView1;

  public FormOfficeLocations()
  {
    this.InitializeComponent();
    this.LoadOfficeLocations();
  }

  public List<int> SelectedOffices => this._selectedOffices;

  private void buttonCancel_Click(object sender, EventArgs e)
  {
    this.DialogResult = DialogResult.Cancel;
  }

  private void LoadOfficeLocations()
  {
    this.ultraListView1.Items.Clear();
    foreach (DataRow row in (InternalDataCollectionBase) DefaultDatabase.ExecuteDataSet("spFin_GetOfficeLocations").Tables[0].Rows)
      this.ultraListView1.Items.Add(row["ID"].ToString(), (object) row["Office Location"].ToString());
  }

  private void buttonSave_Click(object sender, EventArgs e)
  {
    this._selectedOffices = new List<int>();
    for (int index = 0; index < ((DisposableObjectCollectionBase) this.ultraListView1.Items).Count; ++index)
    {
      if (this.ultraListView1.Items[index].CheckState == CheckState.Checked)
        this._selectedOffices.Add(int.Parse(((KeyedSubObjectBase) this.ultraListView1.Items[index]).Key));
    }
    this.DialogResult = DialogResult.OK;
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
    UltraListViewItem ultraListViewItem = new UltraListViewItem((object) "121", (UltraListViewSubItem[]) null, (object) null);
    Appearance appearance4 = new Appearance();
    this.buttonSave = new MGAButton();
    this.buttonCancel = new MGAButton();
    this.ultraListView1 = new UltraListView();
    ((ISupportInitialize) this.buttonSave).BeginInit();
    ((ISupportInitialize) this.buttonCancel).BeginInit();
    ((ISupportInitialize) this.ultraListView1).BeginInit();
    this.SuspendLayout();
    ((AppearanceBase) appearance1).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance1).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance1).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance1).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance1).ImageHAlign = (HAlign) 2;
    ((AppearanceBase) appearance1).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonSave).Appearance = (AppearanceBase) appearance1;
    ((Control) this.buttonSave).Location = new Point(133, 196);
    ((Control) this.buttonSave).Name = "buttonSave";
    ((Control) this.buttonSave).Size = new Size(74, 26);
    ((Control) this.buttonSave).TabIndex = 1;
    ((Control) this.buttonSave).Text = "Save";
    ((UltraControlBase) this.buttonSave).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.buttonSave).Click += new EventHandler(this.buttonSave_Click);
    ((AppearanceBase) appearance2).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance2).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance2).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance2).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance2).ImageHAlign = (HAlign) 2;
    ((AppearanceBase) appearance2).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonCancel).Appearance = (AppearanceBase) appearance2;
    ((Control) this.buttonCancel).Location = new Point(213, 196);
    ((Control) this.buttonCancel).Name = "buttonCancel";
    ((Control) this.buttonCancel).Size = new Size(74, 26);
    ((Control) this.buttonCancel).TabIndex = 2;
    ((Control) this.buttonCancel).Text = "Cancel";
    ((UltraControlBase) this.buttonCancel).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.buttonCancel).Click += new EventHandler(this.buttonCancel_Click);
    ((AppearanceBase) appearance3).BackColor2 = Color.LightSteelBlue;
    ((AppearanceBase) appearance3).BackGradientStyle = (GradientStyle) 11;
    this.ultraListView1.Appearance = (AppearanceBase) appearance3;
    this.ultraListView1.GroupHeadersVisible = (DefaultableBoolean) 2;
    ((KeyedSubObjectBase) ultraListViewItem).Key = "1";
    this.ultraListView1.Items.AddRange(new UltraListViewItem[1]
    {
      ultraListViewItem
    });
    ((AppearanceBase) appearance4).BackColor = Color.Transparent;
    this.ultraListView1.ItemSettings.Appearance = (AppearanceBase) appearance4;
    ((Control) this.ultraListView1).Location = new Point(-1, 1);
    ((Control) this.ultraListView1).Name = "ultraListView1";
    ((Control) this.ultraListView1).Size = new Size(294, 184);
    ((Control) this.ultraListView1).TabIndex = 3;
    ((Control) this.ultraListView1).Text = "ultraListView1";
    ((UltraControlBase) this.ultraListView1).UseFlatMode = (DefaultableBoolean) 1;
    this.ultraListView1.View = (UltraListViewStyle) 2;
    ((UltraListViewListSettingsBase) this.ultraListView1.ViewSettingsList).CheckBoxStyle = (CheckBoxStyle) 1;
    ((UltraListViewSettingsBase) this.ultraListView1.ViewSettingsList).ImageSize = new Size(0, 0);
    this.ultraListView1.ViewSettingsList.MultiColumn = false;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(292, 230);
    this.ControlBox = false;
    this.Controls.Add((Control) this.ultraListView1);
    this.Controls.Add((Control) this.buttonCancel);
    this.Controls.Add((Control) this.buttonSave);
    this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Name = nameof (FormOfficeLocations);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Office Locations";
    ((ISupportInitialize) this.buttonSave).EndInit();
    ((ISupportInitialize) this.buttonCancel).EndInit();
    ((ISupportInitialize) this.ultraListView1).EndInit();
    this.ResumeLayout(false);
  }
}
