// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.DocumentAutomation.frmViewPrintEmail
// Assembly: MgaSystems.IMS.DocumentAutomation, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: B33F9A76-E654-4386-A032-7A12D7CD66DE
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.DocumentAutomation.dll

using MGASystems.BusinessObjects;
using MGASystems.Common;
using MGASystems.Common.BroadcastMessaging;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.DocumentAutomation;

public sealed class frmViewPrintEmail : Form
{
  private IContainer components;
  private Label lblText;
  private ViewPrintEmail ViewPrintEmail1;
  private int controlNo;

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  [field: AccessedThroughProperty("PictureBox1")]
  internal virtual PictureBox PictureBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label1")]
  internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label2")]
  internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    ResourceManager resourceManager = new ResourceManager(typeof (frmViewPrintEmail));
    this.lblText = new Label();
    this.ViewPrintEmail1 = !this.DesignMode ? (ViewPrintEmail) ObjectFactory.Instance.CreateObjectEX(typeof (ViewPrintEmail)) : new ViewPrintEmail();
    this.PictureBox1 = new PictureBox();
    this.Label1 = new Label();
    this.Label2 = new Label();
    this.SuspendLayout();
    this.lblText.AutoSize = true;
    this.lblText.ForeColor = Color.Black;
    this.lblText.Location = new Point(128 /*0x80*/, 48 /*0x30*/);
    this.lblText.Name = "lblText";
    this.lblText.Size = new Size(290, 16 /*0x10*/);
    this.lblText.TabIndex = 3;
    this.lblText.Text = "The following documents were created via a system event.";
    this.ViewPrintEmail1.BackColor = Color.White;
    this.ViewPrintEmail1.Font = new Font("Tahoma", 8.25f);
    this.ViewPrintEmail1.Location = new Point(8, 120);
    this.ViewPrintEmail1.Name = "ViewPrintEmail1";
    this.ViewPrintEmail1.Size = new Size(576, 160 /*0xA0*/);
    this.ViewPrintEmail1.TabIndex = 4;
    this.PictureBox1.Image = (Image) resourceManager.GetObject("PictureBox1.Image");
    this.PictureBox1.Location = new Point(8, 8);
    this.PictureBox1.Name = "PictureBox1";
    this.PictureBox1.Size = new Size(112 /*0x70*/, 96 /*0x60*/);
    this.PictureBox1.TabIndex = 5;
    this.PictureBox1.TabStop = false;
    this.Label1.AutoSize = true;
    this.Label1.Font = new Font("Tahoma", 13f);
    this.Label1.Location = new Point(128 /*0x80*/, 16 /*0x10*/);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(161, 24);
    this.Label1.TabIndex = 6;
    this.Label1.Text = "Documents Created";
    this.Label2.AutoSize = true;
    this.Label2.ForeColor = Color.Black;
    this.Label2.Location = new Point(128 /*0x80*/, 72);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(393, 16 /*0x10*/);
    this.Label2.TabIndex = 7;
    this.Label2.Text = "You can view, print, or email any or all of these documents from the grid below.";
    this.AutoScaleBaseSize = new Size(5, 13);
    this.BackColor = Color.White;
    this.ClientSize = new Size(586, 280);
    this.Controls.Add((Control) this.Label2);
    this.Controls.Add((Control) this.Label1);
    this.Controls.Add((Control) this.PictureBox1);
    this.Controls.Add((Control) this.ViewPrintEmail1);
    this.Controls.Add((Control) this.lblText);
    this.Font = new Font("Tahoma", 8f);
    this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
    this.MinimumSize = new Size(344, 112 /*0x70*/);
    this.Name = nameof (frmViewPrintEmail);
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Document Options";
    this.TopMost = true;
    this.ResumeLayout(false);
  }

  public frmViewPrintEmail(Guid[] documentStoreGuids, string[] emailAddresses, Quote quote)
    : this(documentStoreGuids, emailAddresses, quote, (ViewPrintEmail.Settings) null)
  {
  }

  public frmViewPrintEmail(
    Guid[] documentStoreGuids,
    string[] emailAddresses,
    Quote quote,
    ViewPrintEmail.Settings settings)
  {
    this.Closed += new EventHandler(this.frmViewPrintEmail_Closed);
    this.controlNo = 0;
    this.InitializeComponent();
    if (quote != null)
    {
      this.Text = $"Document Options - {(quote.InsuredPolicyName.Length > 50 ? (object) (quote.InsuredPolicyName.Substring(0, 50) + "...") : (object) quote.InsuredPolicyName)} (Control #{quote.ControlNo})";
      this.controlNo = quote.ControlNo;
    }
    this.ViewPrintEmail1.Initialize(documentStoreGuids, emailAddresses, quote, settings);
  }

  private void frmViewPrintEmail_Closed(object sender, EventArgs e)
  {
    Messaging.SendBroadcastMessage(BroadcastMessages.ClosefrmViewPrintEmail, (object) this.controlNo);
  }
}
