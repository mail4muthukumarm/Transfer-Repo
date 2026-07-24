// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Core.Forms.formRebuildWorkingTables
// Assembly: MgaSystems.IMS.Accounting.Core, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 923053EF-B70A-44B5-B8DA-B227263F4FD2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Core.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.IMS.Accounting.Core.Properties;
using MGASystems.Tools;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Core.Forms;

[SecureResource("{F8A3D1A6-84C0-4296-93AC-B0F95F5446ED}", "Rebuild Working Table Management", "Allows users to rebuild the accounting working tables.", "Accounting")]
public class formRebuildWorkingTables : Form
{
  private IContainer components;
  private Label labelGetStarted;
  private Label labelDone;
  private MGAButton buttonClose;
  private MGAButton buttonGo;
  private PictureBox picSpinner;

  public formRebuildWorkingTables() => this.InitializeComponent();

  private void buttonClose_Click(object sender, EventArgs e) => this.Close();

  private void Bgw_DoWork(object sender, DoWorkEventArgs e)
  {
    try
    {
      DefaultDatabase.ExecuteNonQuery(CommandType.StoredProcedure, "spFin_RebuildWorkingTables", 0, (CommandArgumentType) 2, Array.Empty<object>());
    }
    catch (Exception ex)
    {
      throw ex;
    }
  }

  private void Bgw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
  {
    this.picSpinner.Visible = false;
    this.labelDone.Visible = true;
    this.labelGetStarted.Visible = false;
    this.Refresh();
  }

  private void buttonGo_Click(object sender, EventArgs e)
  {
    if (MessageBox.Show("This process may take a while. It is recommended that no one is in the system while this process is running. Continue?", "Run Process?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
      return;
    CurrentUser.Instance.LogAction("Rebuild Working Tables", "Accounting");
    this.picSpinner.Visible = true;
    this.labelDone.Visible = false;
    this.labelGetStarted.Visible = false;
    this.Refresh();
    BackgroundWorker backgroundWorker = new BackgroundWorker();
    backgroundWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(this.Bgw_RunWorkerCompleted);
    backgroundWorker.DoWork += new DoWorkEventHandler(this.Bgw_DoWork);
    backgroundWorker.RunWorkerAsync();
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
    this.labelGetStarted = new Label();
    this.labelDone = new Label();
    this.buttonClose = new MGAButton();
    this.buttonGo = new MGAButton();
    this.picSpinner = new PictureBox();
    ((ISupportInitialize) this.buttonClose).BeginInit();
    ((ISupportInitialize) this.buttonGo).BeginInit();
    ((ISupportInitialize) this.picSpinner).BeginInit();
    this.SuspendLayout();
    this.labelGetStarted.BackColor = Color.Transparent;
    this.labelGetStarted.Font = new Font("Tahoma", 20f);
    this.labelGetStarted.Location = new Point(17, 49);
    this.labelGetStarted.Name = "labelGetStarted";
    this.labelGetStarted.Size = new Size(259, 56);
    this.labelGetStarted.TabIndex = 9;
    this.labelGetStarted.Text = "Start Process?";
    this.labelGetStarted.TextAlign = ContentAlignment.MiddleCenter;
    this.labelDone.BackColor = Color.Transparent;
    this.labelDone.Font = new Font("Tahoma", 20f);
    this.labelDone.Location = new Point(17, 49);
    this.labelDone.Name = "labelDone";
    this.labelDone.Size = new Size(259, 56);
    this.labelDone.TabIndex = 8;
    this.labelDone.Text = "All Done!";
    this.labelDone.TextAlign = ContentAlignment.MiddleCenter;
    this.labelDone.Visible = false;
    ((AppearanceBase) appearance1).BackColor = Color.SlateGray;
    ((AppearanceBase) appearance1).BackColor2 = Color.LightSlateGray;
    ((AppearanceBase) appearance1).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance1).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance1).ImageHAlign = (HAlign) 2;
    ((AppearanceBase) appearance1).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonClose).Appearance = (AppearanceBase) appearance1;
    ((Control) this.buttonClose).Font = new Font("Tahoma", 10f);
    ((Control) this.buttonClose).Location = new Point(9, 219);
    ((Control) this.buttonClose).Name = "buttonClose";
    ((Control) this.buttonClose).Size = new Size(267, 36);
    ((Control) this.buttonClose).TabIndex = 7;
    ((Control) this.buttonClose).Text = "Close";
    ((UltraControlBase) this.buttonClose).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.buttonClose).Click += new EventHandler(this.buttonClose_Click);
    ((AppearanceBase) appearance2).BackColor = Color.SlateGray;
    ((AppearanceBase) appearance2).BackColor2 = Color.SlateGray;
    ((AppearanceBase) appearance2).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance2).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance2).ImageHAlign = (HAlign) 2;
    ((AppearanceBase) appearance2).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonGo).Appearance = (AppearanceBase) appearance2;
    ((Control) this.buttonGo).Font = new Font("Tahoma", 10f);
    ((Control) this.buttonGo).Location = new Point(9, 177);
    ((Control) this.buttonGo).Name = "buttonGo";
    ((Control) this.buttonGo).Size = new Size(267, 36);
    ((Control) this.buttonGo).TabIndex = 6;
    ((Control) this.buttonGo).Text = "Rebuild Working Tables";
    ((UltraControlBase) this.buttonGo).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.buttonGo).Click += new EventHandler(this.buttonGo_Click);
    this.picSpinner.BackColor = Color.Transparent;
    this.picSpinner.Image = (Image) Resources.loading_spinner11;
    this.picSpinner.Location = new Point(78, 20);
    this.picSpinner.Name = "picSpinner";
    this.picSpinner.Size = new Size(128 /*0x80*/, 128 /*0x80*/);
    this.picSpinner.SizeMode = PictureBoxSizeMode.AutoSize;
    this.picSpinner.TabIndex = 5;
    this.picSpinner.TabStop = false;
    this.picSpinner.Visible = false;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(284, 261);
    this.ControlBox = false;
    this.Controls.Add((Control) this.labelGetStarted);
    this.Controls.Add((Control) this.labelDone);
    this.Controls.Add((Control) this.buttonClose);
    this.Controls.Add((Control) this.buttonGo);
    this.Controls.Add((Control) this.picSpinner);
    this.Font = new Font("Tahoma", 8.25f);
    this.FormBorderStyle = FormBorderStyle.FixedDialog;
    this.Name = nameof (formRebuildWorkingTables);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Rebuild Working Tables";
    ((ISupportInitialize) this.buttonClose).EndInit();
    ((ISupportInitialize) this.buttonGo).EndInit();
    ((ISupportInitialize) this.picSpinner).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }
}
