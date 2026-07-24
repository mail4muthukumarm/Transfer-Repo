// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.MVC.BaseClasses.View.LoadingPanelControl
// Assembly: MgaSystems.IMS.Accounting.Services, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EEF87E2E-9738-4C33-AE03-5712A958CE99
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Services.dll

using MGASystems.IMS.Accounting.Services.Properties;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.Common.MVC.BaseClasses.View;

public class LoadingPanelControl : UserControl
{
  private IContainer components;
  private TableLayoutPanel centeringPanel;
  private FlowLayoutPanel OpaquePanel;
  private PictureBox pictureBox1;
  private Label loadingLabel;

  public LoadingPanelControl() => this.InitializeComponent();

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    this.centeringPanel = new TableLayoutPanel();
    this.OpaquePanel = new FlowLayoutPanel();
    this.pictureBox1 = new PictureBox();
    this.loadingLabel = new Label();
    this.centeringPanel.SuspendLayout();
    this.OpaquePanel.SuspendLayout();
    ((ISupportInitialize) this.pictureBox1).BeginInit();
    this.SuspendLayout();
    this.centeringPanel.ColumnCount = 3;
    this.centeringPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
    this.centeringPanel.ColumnStyles.Add(new ColumnStyle());
    this.centeringPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
    this.centeringPanel.Controls.Add((Control) this.OpaquePanel, 1, 1);
    this.centeringPanel.Dock = DockStyle.Fill;
    this.centeringPanel.Location = new Point(0, 0);
    this.centeringPanel.Name = "centeringPanel";
    this.centeringPanel.RowCount = 3;
    this.centeringPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50f));
    this.centeringPanel.RowStyles.Add(new RowStyle());
    this.centeringPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50f));
    this.centeringPanel.Size = new Size(618, 451);
    this.centeringPanel.TabIndex = 2;
    this.OpaquePanel.AutoSize = true;
    this.OpaquePanel.BackColor = Color.WhiteSmoke;
    this.OpaquePanel.Controls.Add((Control) this.pictureBox1);
    this.OpaquePanel.Controls.Add((Control) this.loadingLabel);
    this.OpaquePanel.Dock = DockStyle.Fill;
    this.OpaquePanel.Location = new Point(203, 202);
    this.OpaquePanel.Margin = new Padding(0);
    this.OpaquePanel.Name = "OpaquePanel";
    this.OpaquePanel.Size = new Size(211, 46);
    this.OpaquePanel.TabIndex = 0;
    this.OpaquePanel.WrapContents = false;
    this.pictureBox1.BackgroundImageLayout = ImageLayout.Center;
    this.pictureBox1.Image = (Image) Resources.loading_animation;
    this.pictureBox1.Location = new Point(3, 3);
    this.pictureBox1.Name = "pictureBox1";
    this.pictureBox1.Size = new Size(40, 40);
    this.pictureBox1.TabIndex = 0;
    this.pictureBox1.TabStop = false;
    this.loadingLabel.AutoSize = true;
    this.loadingLabel.Font = new Font("Microsoft Sans Serif", 24f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.loadingLabel.Location = new Point(49, 3);
    this.loadingLabel.Margin = new Padding(3);
    this.loadingLabel.Name = "loadingLabel";
    this.loadingLabel.Size = new Size(159, 37);
    this.loadingLabel.TabIndex = 0;
    this.loadingLabel.Text = "Loading...";
    this.loadingLabel.TextAlign = ContentAlignment.MiddleCenter;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
    this.BackColor = Color.Transparent;
    this.Controls.Add((Control) this.centeringPanel);
    this.Cursor = Cursors.WaitCursor;
    this.Margin = new Padding(0);
    this.Name = nameof (LoadingPanelControl);
    this.Size = new Size(618, 451);
    this.centeringPanel.ResumeLayout(false);
    this.centeringPanel.PerformLayout();
    this.OpaquePanel.ResumeLayout(false);
    this.OpaquePanel.PerformLayout();
    ((ISupportInitialize) this.pictureBox1).EndInit();
    this.ResumeLayout(false);
  }
}
