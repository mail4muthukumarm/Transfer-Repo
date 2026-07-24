// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.ErrorHandling.ConnectivityIssuesForm
// Assembly: MgaSystems.IMS.Common, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 46CE8D79-2C19-419C-BC23-F8C69E623B17
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using MGASystems.Tools;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.Common.ErrorHandling;

[DesignerGenerated]
public class ConnectivityIssuesForm : Form
{
  private IContainer components;
  private Exception _ex;

  [DebuggerNonUserCode]
  protected override void Dispose(bool disposing)
  {
    try
    {
      if (!disposing || this.components == null)
        return;
      this.components.Dispose();
    }
    finally
    {
      base.Dispose(disposing);
    }
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (ConnectivityIssuesForm));
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    this.UltraFlowLayoutManager1 = new UltraFlowLayoutManager(this.components);
    this.Label1 = new Label();
    this.Label2 = new Label();
    this.buttonContinue = new MGAButton();
    this.buttonSendReport = new MGAButton();
    this.Label3 = new Label();
    this.PictureBox1 = new PictureBox();
    ((ISupportInitialize) this.UltraFlowLayoutManager1).BeginInit();
    ((ISupportInitialize) this.buttonContinue).BeginInit();
    ((ISupportInitialize) this.buttonSendReport).BeginInit();
    ((ISupportInitialize) this.PictureBox1).BeginInit();
    this.SuspendLayout();
    this.Label1.BackColor = Color.Transparent;
    this.Label1.Font = new Font("Tahoma", 10f);
    this.Label1.Location = new Point(168, 12);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(383, 21);
    this.Label1.TabIndex = 0;
    this.Label1.Text = "The last operation failed due to a network connectivity issue.";
    this.Label2.BackColor = Color.Transparent;
    this.Label2.Location = new Point(168, 45);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(374, 63 /*0x3F*/);
    this.Label2.TabIndex = 1;
    this.Label2.Text = componentResourceManager.GetString("Label2.Text");
    appearance1.BackColor = Color.FromArgb(248, 248, 248);
    appearance1.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance1.BackGradientStyle = (GradientStyle) 2;
    appearance1.BorderColor = Color.DarkGray;
    appearance1.ImageHAlign = (HAlign) 2;
    appearance1.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonContinue).Appearance = (AppearanceBase) appearance1;
    ((Control) this.buttonContinue).Location = new Point(223, 159);
    ((Control) this.buttonContinue).Name = "buttonContinue";
    ((Control) this.buttonContinue).Size = new Size(114, 31 /*0x1F*/);
    ((Control) this.buttonContinue).TabIndex = 2;
    ((ControlBase) this.buttonContinue).Text = "Continue";
    this.buttonContinue.UseOSThemes = (DefaultableBoolean) 2;
    appearance2.BackColor = Color.FromArgb(248, 248, 248);
    appearance2.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance2.BackGradientStyle = (GradientStyle) 2;
    appearance2.BorderColor = Color.DarkGray;
    appearance2.ImageHAlign = (HAlign) 2;
    appearance2.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonSendReport).Appearance = (AppearanceBase) appearance2;
    ((Control) this.buttonSendReport).Location = new Point(343, 160 /*0xA0*/);
    ((Control) this.buttonSendReport).Name = "buttonSendReport";
    ((Control) this.buttonSendReport).Size = new Size(114, 30);
    ((Control) this.buttonSendReport).TabIndex = 3;
    ((ControlBase) this.buttonSendReport).Text = "Send Error Report";
    this.buttonSendReport.UseOSThemes = (DefaultableBoolean) 2;
    this.Label3.BackColor = Color.Transparent;
    this.Label3.Location = new Point(168, 108);
    this.Label3.Name = "Label3";
    this.Label3.Size = new Size(374, 30);
    this.Label3.TabIndex = 4;
    this.Label3.Text = "If the problem persists, please click the \"Send Error Report\" button to send more information to technical support.";
    this.PictureBox1.Image = (Image) componentResourceManager.GetObject("PictureBox1.Image");
    this.PictureBox1.Location = new Point(12, 12);
    this.PictureBox1.Name = "PictureBox1";
    this.PictureBox1.Size = new Size(150, 163);
    this.PictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
    this.PictureBox1.TabIndex = 5;
    this.PictureBox1.TabStop = false;
    this.AcceptButton = (IButtonControl) this.buttonContinue;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    this.ClientSize = new Size(562, 202);
    this.Controls.Add((Control) this.Label3);
    this.Controls.Add((Control) this.buttonSendReport);
    this.Controls.Add((Control) this.buttonContinue);
    this.Controls.Add((Control) this.Label2);
    this.Controls.Add((Control) this.Label1);
    this.Controls.Add((Control) this.PictureBox1);
    this.Font = new Font("Tahoma", 8.25f);
    this.ForeColor = Color.Black;
    this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
    this.Name = nameof (ConnectivityIssuesForm);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Connectivity Issue";
    ((ISupportInitialize) this.UltraFlowLayoutManager1).EndInit();
    ((ISupportInitialize) this.buttonContinue).EndInit();
    ((ISupportInitialize) this.buttonSendReport).EndInit();
    ((ISupportInitialize) this.PictureBox1).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  [field: AccessedThroughProperty("UltraFlowLayoutManager1")]
  internal virtual UltraFlowLayoutManager UltraFlowLayoutManager1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label1")]
  internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label2")]
  internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual MGAButton buttonContinue
  {
    get => this._buttonContinue;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.buttonContinue_Click);
      MGAButton buttonContinue1 = this._buttonContinue;
      if (buttonContinue1 != null)
        ((Control) buttonContinue1).Click -= eventHandler;
      this._buttonContinue = value;
      MGAButton buttonContinue2 = this._buttonContinue;
      if (buttonContinue2 == null)
        return;
      ((Control) buttonContinue2).Click += eventHandler;
    }
  }

  internal virtual MGAButton buttonSendReport
  {
    get => this._buttonSendReport;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.buttonSendReport_Click);
      MGAButton buttonSendReport1 = this._buttonSendReport;
      if (buttonSendReport1 != null)
        ((Control) buttonSendReport1).Click -= eventHandler;
      this._buttonSendReport = value;
      MGAButton buttonSendReport2 = this._buttonSendReport;
      if (buttonSendReport2 == null)
        return;
      ((Control) buttonSendReport2).Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("Label3")]
  internal virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("PictureBox1")]
  internal virtual PictureBox PictureBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  public ConnectivityIssuesForm(Exception ex)
  {
    if (ex == null)
      throw new ArgumentNullException(nameof (ex));
    this.InitializeComponent();
    this._ex = ex;
  }

  private void buttonSendReport_Click(object sender, EventArgs e)
  {
    ErrorHandler.HandleError(this._ex);
  }

  private void buttonContinue_Click(object sender, EventArgs e) => this.Close();
}
