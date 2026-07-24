// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Claims.UserLog.FormClaimUserLog
// Assembly: MgaSystems.IMS.Claims, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FCD9D0B7-28CF-40B9-8EB7-297871E1AF5F
// Assembly location: F:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims.dll

using Infragistics.Win;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using MGASystems.Data;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Claims.UserLog;

public class FormClaimUserLog : Form
{
  private int _claimId;
  private IContainer components;
  private UltraGrid gridActionLog;

  public FormClaimUserLog(int claimId)
  {
    this.InitializeComponent();
    this._claimId = claimId;
  }

  private void FormClaimUserLog_Load(object sender, EventArgs e)
  {
    ((UltraGridBase) this.gridActionLog).DataSource = (object) DefaultDatabase.ExecuteDataTable("spClaims_GetUserActionLog", new object[2]
    {
      (object) "@claimId",
      (object) this._claimId
    });
    this.FormatGrid();
  }

  private void FormatGrid()
  {
    ((UltraGridBase) this.gridActionLog).DisplayLayout.Bands[0].Columns["date"].Format = "dddd, MMMM d yyyy HH:mm:ss tt";
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
    this.gridActionLog = new UltraGrid();
    ((ISupportInitialize) this.gridActionLog).BeginInit();
    this.SuspendLayout();
    ((AppearanceBase) appearance1).BackColor = Color.White;
    ((AppearanceBase) appearance1).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.gridActionLog).DisplayLayout.Appearance = (AppearanceBase) appearance1;
    ((UltraGridBase) this.gridActionLog).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ((UltraGridBase) this.gridActionLog).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((AppearanceBase) appearance2).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance2).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance2).ForeColor = Color.Black;
    ((UltraGridBase) this.gridActionLog).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance2;
    ((UltraGridBase) this.gridActionLog).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.gridActionLog).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridActionLog).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance3).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridActionLog).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance3;
    ((UltraGridBase) this.gridActionLog).DisplayLayout.Override.CellClickAction = (CellClickAction) 2;
    ((AppearanceBase) appearance4).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.gridActionLog).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance4;
    ((UltraGridBase) this.gridActionLog).DisplayLayout.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance5).BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.gridActionLog).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance5;
    ((AppearanceBase) appearance6).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridActionLog).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance6;
    ((UltraGridBase) this.gridActionLog).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance7).BackColor = Color.Transparent;
    ((AppearanceBase) appearance7).ForeColor = Color.Black;
    ((UltraGridBase) this.gridActionLog).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance7;
    ((AppearanceBase) appearance8).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance8).BorderColor = Color.Silver;
    scrollBarLook.ButtonAppearance = (AppearanceBase) appearance8;
    ((AppearanceBase) appearance9).BackColor = Color.White;
    scrollBarLook.TrackAppearance = (AppearanceBase) appearance9;
    ((UltraGridBase) this.gridActionLog).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((Control) this.gridActionLog).Dock = DockStyle.Fill;
    ((Control) this.gridActionLog).Location = new Point(0, 0);
    ((Control) this.gridActionLog).Name = "gridActionLog";
    ((Control) this.gridActionLog).Size = new Size(794, 571);
    ((Control) this.gridActionLog).TabIndex = 0;
    ((UltraControlBase) this.gridActionLog).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.gridActionLog).UseOsThemes = (DefaultableBoolean) 2;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(794, 571);
    this.Controls.Add((Control) this.gridActionLog);
    this.Font = new Font("Tahoma", 8.25f);
    this.FormBorderStyle = FormBorderStyle.FixedDialog;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (FormClaimUserLog);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "User Action Log";
    this.Load += new EventHandler(this.FormClaimUserLog_Load);
    ((ISupportInitialize) this.gridActionLog).EndInit();
    this.ResumeLayout(false);
  }
}
