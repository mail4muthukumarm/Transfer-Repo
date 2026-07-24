// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Claims.ReserveSecurity.FormClaimReserveSecurity
// Assembly: MgaSystems.IMS.Claims, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FCD9D0B7-28CF-40B9-8EB7-297871E1AF5F
// Assembly location: F:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.IMS.Claims.Properties;
using MGASystems.Tools;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Claims.ReserveSecurity;

public class FormClaimReserveSecurity : FormBase
{
  private IContainer components;
  private MGAButton buttonCancel;
  private MGAButton buttonSave;
  private UltraGrid gridReserveLevels;

  public FormClaimReserveSecurity() => this.InitializeComponent();

  private void LoadReserveLevels()
  {
    ((UltraGridBase) this.gridReserveLevels).DataSource = (object) DefaultDatabase.ExecuteDataSet("spClaims_GetClaimLevelReserveLimits").Tables[0];
  }

  private void gridReserveLevels_InitializeLayout(object sender, InitializeLayoutEventArgs e)
  {
    ((UltraGridBase) this.gridReserveLevels).DisplayLayout.Bands[0].Columns[0].Hidden = true;
    ((HeaderBase) ((UltraGridBase) this.gridReserveLevels).DisplayLayout.Bands[0].Columns[1].Header).Caption = "Reserve Level";
    ((HeaderBase) ((UltraGridBase) this.gridReserveLevels).DisplayLayout.Bands[0].Columns[1].Header).Appearance.TextHAlign = (HAlign) 1;
    ((UltraGridBase) this.gridReserveLevels).DisplayLayout.Bands[0].Columns[1].CellActivation = (Activation) 3;
    ((HeaderBase) ((UltraGridBase) this.gridReserveLevels).DisplayLayout.Bands[0].Columns[2].Header).Caption = "Maximum Reserve Amount";
    ((HeaderBase) ((UltraGridBase) this.gridReserveLevels).DisplayLayout.Bands[0].Columns[2].Header).Appearance.TextHAlign = (HAlign) 3;
    ((UltraGridBase) this.gridReserveLevels).DisplayLayout.Bands[0].Columns[2].Format = "c";
    ((UltraGridBase) this.gridReserveLevels).DisplayLayout.Bands[0].Columns[2].CellAppearance.TextHAlign = (HAlign) 3;
    ((UltraGridBase) this.gridReserveLevels).DisplayLayout.Bands[0].Columns[2].CellActivation = (Activation) 0;
  }

  private void buttonCancel_Click(object sender, EventArgs e)
  {
    this.DialogResult = DialogResult.Cancel;
    this.Close();
  }

  private void gridReserveLevels_CellDataError(object sender, CellDataErrorEventArgs e)
  {
    e.RestoreOriginalValue = true;
    e.RaiseErrorEvent = false;
    int num = (int) MessageBox.Show("Invalid reserve amount!", "Invalid Reserve Amount!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
  }

  private void buttonSave_Click(object sender, EventArgs e)
  {
    foreach (UltraGridRow row in ((UltraGridBase) this.gridReserveLevels).Rows)
      DefaultDatabase.ExecuteNonQuery("spClaims_UpdateClaimLevelReserveLimit", new object[4]
      {
        (object) "@SecurityGuid",
        (object) row.Cells["SecurityGuid"].Value.ToString(),
        (object) "@ReserveLevelValue",
        row.Cells["ReserveLevelValue"].Value
      });
    this.DialogResult = DialogResult.OK;
    this.Close();
  }

  private void FormClaimReserveSecurity_Load(object sender, EventArgs e)
  {
    this.LoadReserveLevels();
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
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    Appearance appearance11 = new Appearance();
    Appearance appearance12 = new Appearance();
    this.buttonCancel = new MGAButton();
    this.buttonSave = new MGAButton();
    this.gridReserveLevels = new UltraGrid();
    ((ISupportInitialize) this.buttonCancel).BeginInit();
    ((ISupportInitialize) this.buttonSave).BeginInit();
    ((ISupportInitialize) this.gridReserveLevels).BeginInit();
    this.SuspendLayout();
    ((AppearanceBase) appearance1).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance1).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance1).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance1).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance1).Image = (object) Resources.DeleteClaimSmall;
    ((AppearanceBase) appearance1).ImageHAlign = (HAlign) 1;
    ((AppearanceBase) appearance1).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonCancel).Appearance = (AppearanceBase) appearance1;
    ((Control) this.buttonCancel).Location = new Point(544, 224 /*0xE0*/);
    ((Control) this.buttonCancel).Name = "buttonCancel";
    ((Control) this.buttonCancel).Size = new Size(88, 32 /*0x20*/);
    ((Control) this.buttonCancel).TabIndex = 5;
    ((Control) this.buttonCancel).Text = "&Cancel";
    ((UltraControlBase) this.buttonCancel).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.buttonCancel).Click += new EventHandler(this.buttonCancel_Click);
    ((AppearanceBase) appearance2).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance2).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance2).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance2).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance2).Image = (object) Resources.Save;
    ((AppearanceBase) appearance2).ImageHAlign = (HAlign) 1;
    ((AppearanceBase) appearance2).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonSave).Appearance = (AppearanceBase) appearance2;
    ((Control) this.buttonSave).Location = new Point(448, 224 /*0xE0*/);
    ((Control) this.buttonSave).Name = "buttonSave";
    ((Control) this.buttonSave).Size = new Size(88, 32 /*0x20*/);
    ((Control) this.buttonSave).TabIndex = 4;
    ((Control) this.buttonSave).Text = "&Save";
    ((UltraControlBase) this.buttonSave).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.buttonSave).Click += new EventHandler(this.buttonSave_Click);
    ((AppearanceBase) appearance3).BackColor = Color.White;
    ((AppearanceBase) appearance3).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.gridReserveLevels).DisplayLayout.Appearance = (AppearanceBase) appearance3;
    ((UltraGridBase) this.gridReserveLevels).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ((UltraGridBase) this.gridReserveLevels).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((AppearanceBase) appearance4).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance4).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance4).ForeColor = Color.Black;
    ((UltraGridBase) this.gridReserveLevels).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance4;
    ((UltraGridBase) this.gridReserveLevels).DisplayLayout.Override.AllowAddNew = (AllowAddNew) 2;
    ((UltraGridBase) this.gridReserveLevels).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.gridReserveLevels).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridReserveLevels).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 1;
    ((AppearanceBase) appearance5).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridReserveLevels).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance5;
    ((AppearanceBase) appearance6).ForeColor = Color.Red;
    ((UltraGridBase) this.gridReserveLevels).DisplayLayout.Override.DataErrorCellAppearance = (AppearanceBase) appearance6;
    ((AppearanceBase) appearance7).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.gridReserveLevels).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance7;
    ((UltraGridBase) this.gridReserveLevels).DisplayLayout.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance8).BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.gridReserveLevels).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance8;
    ((AppearanceBase) appearance9).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridReserveLevels).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance9;
    ((UltraGridBase) this.gridReserveLevels).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance10).BackColor = Color.Transparent;
    ((AppearanceBase) appearance10).ForeColor = Color.Black;
    ((UltraGridBase) this.gridReserveLevels).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance10;
    ((AppearanceBase) appearance11).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance11).BorderColor = Color.Silver;
    scrollBarLook.ButtonAppearance = (AppearanceBase) appearance11;
    ((AppearanceBase) appearance12).BackColor = Color.White;
    scrollBarLook.TrackAppearance = (AppearanceBase) appearance12;
    ((UltraGridBase) this.gridReserveLevels).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((Control) this.gridReserveLevels).Location = new Point(12, 9);
    ((Control) this.gridReserveLevels).Name = "gridReserveLevels";
    ((Control) this.gridReserveLevels).Size = new Size(620, 209);
    ((Control) this.gridReserveLevels).TabIndex = 3;
    this.gridReserveLevels.UpdateMode = (UpdateMode) 2;
    ((UltraControlBase) this.gridReserveLevels).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.gridReserveLevels).UseOsThemes = (DefaultableBoolean) 2;
    this.gridReserveLevels.InitializeLayout += new InitializeLayoutEventHandler(this.gridReserveLevels_InitializeLayout);
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(644, 265);
    this.Controls.Add((Control) this.buttonCancel);
    this.Controls.Add((Control) this.buttonSave);
    this.Controls.Add((Control) this.gridReserveLevels);
    this.Font = new Font("Tahoma", 8.25f);
    this.Name = nameof (FormClaimReserveSecurity);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Claim Level - Reserve Security";
    this.Load += new EventHandler(this.FormClaimReserveSecurity_Load);
    ((ISupportInitialize) this.buttonCancel).EndInit();
    ((ISupportInitialize) this.buttonSave).EndInit();
    ((ISupportInitialize) this.gridReserveLevels).EndInit();
    this.ResumeLayout(false);
  }
}
