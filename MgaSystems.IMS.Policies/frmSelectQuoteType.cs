// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.frmSelectQuoteType
// Assembly: MgaSystems.IMS.Policies, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 2FF2C709-F7BF-41DA-82BD-FF6319CA235D
// Assembly location: C:\Users\muthu\Downloads\MgaSystems.IMS.Policies.dll

using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Policies;

public sealed class frmSelectQuoteType : Form
{
  private IContainer components;
  private Label Label1;
  private PictureBox PictureBox1;
  private PictureBox PictureBox2;
  private ToolTip ToolTip1;
  private Label Label2;
  private Label Label3;
  private bool _quoteTypeSelected;
  private bool _quickQuote;

  public frmSelectQuoteType() => this.InitializeComponent();

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private virtual LinkLabel lnkQuickQuote
  {
    get => this._lnkQuickQuote;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.LinkClicked);
      LinkLabel lnkQuickQuote1 = this._lnkQuickQuote;
      if (lnkQuickQuote1 != null)
        lnkQuickQuote1.LinkClicked -= clickedEventHandler;
      this._lnkQuickQuote = value;
      LinkLabel lnkQuickQuote2 = this._lnkQuickQuote;
      if (lnkQuickQuote2 == null)
        return;
      lnkQuickQuote2.LinkClicked += clickedEventHandler;
    }
  }

  private virtual LinkLabel lnkFullQuote
  {
    get => this._lnkFullQuote;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.LinkClicked);
      LinkLabel lnkFullQuote1 = this._lnkFullQuote;
      if (lnkFullQuote1 != null)
        lnkFullQuote1.LinkClicked -= clickedEventHandler;
      this._lnkFullQuote = value;
      LinkLabel lnkFullQuote2 = this._lnkFullQuote;
      if (lnkFullQuote2 == null)
        return;
      lnkFullQuote2.LinkClicked += clickedEventHandler;
    }
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmSelectQuoteType));
    this.Label1 = new Label();
    this.PictureBox1 = new PictureBox();
    this.PictureBox2 = new PictureBox();
    this.lnkQuickQuote = new LinkLabel();
    this.lnkFullQuote = new LinkLabel();
    this.ToolTip1 = new ToolTip(this.components);
    this.Label2 = new Label();
    this.Label3 = new Label();
    ((ISupportInitialize) this.PictureBox1).BeginInit();
    ((ISupportInitialize) this.PictureBox2).BeginInit();
    this.SuspendLayout();
    this.Label1.AutoSize = true;
    this.Label1.Font = new Font("Tahoma", 12f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label1.Location = new Point(32 /*0x20*/, 24);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(173, 19);
    this.Label1.TabIndex = 0;
    this.Label1.Text = "Select a Quote Type";
    this.PictureBox1.Image = (Image) componentResourceManager.GetObject("PictureBox1.Image");
    this.PictureBox1.Location = new Point(42, 160 /*0xA0*/);
    this.PictureBox1.Name = "PictureBox1";
    this.PictureBox1.Size = new Size(32 /*0x20*/, 32 /*0x20*/);
    this.PictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
    this.PictureBox1.TabIndex = 1;
    this.PictureBox1.TabStop = false;
    this.PictureBox2.Image = (Image) componentResourceManager.GetObject("PictureBox2.Image");
    this.PictureBox2.Location = new Point(42, 59);
    this.PictureBox2.Name = "PictureBox2";
    this.PictureBox2.Size = new Size(32 /*0x20*/, 32 /*0x20*/);
    this.PictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
    this.PictureBox2.TabIndex = 2;
    this.PictureBox2.TabStop = false;
    this.lnkQuickQuote.AutoSize = true;
    this.lnkQuickQuote.Font = new Font("Tahoma", 12f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.lnkQuickQuote.Location = new Point(90, 64 /*0x40*/);
    this.lnkQuickQuote.Name = "lnkQuickQuote";
    this.lnkQuickQuote.Size = new Size(104, 19);
    this.lnkQuickQuote.TabIndex = 3;
    this.lnkQuickQuote.TabStop = true;
    this.lnkQuickQuote.Text = "Quick Submit";
    this.ToolTip1.SetToolTip((Control) this.lnkQuickQuote, "A quick submission allows you to enter policy information without knowing detailed information such as the companies being approached.");
    this.lnkFullQuote.AutoSize = true;
    this.lnkFullQuote.Font = new Font("Tahoma", 12f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.lnkFullQuote.Location = new Point(90, 160 /*0xA0*/);
    this.lnkFullQuote.Name = "lnkFullQuote";
    this.lnkFullQuote.Size = new Size(82, 19);
    this.lnkFullQuote.TabIndex = 4;
    this.lnkFullQuote.TabStop = true;
    this.lnkFullQuote.Text = "Full Quote";
    this.ToolTip1.SetToolTip((Control) this.lnkFullQuote, "The full quote requires all information, including the company on the policy.");
    this.Label2.Location = new Point(96 /*0x60*/, 96 /*0x60*/);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(240 /*0xF0*/, 56);
    this.Label2.TabIndex = 5;
    this.Label2.Text = "A quick submission allows you to enter policy information for tracking purposes, without knowing detailed information such as the companies being approached.";
    this.Label3.Location = new Point(104, 192 /*0xC0*/);
    this.Label3.Name = "Label3";
    this.Label3.Size = new Size(240 /*0xF0*/, 56);
    this.Label3.TabIndex = 6;
    this.Label3.Text = "The full quote requires all information sufficient for rating and billing, including the company on the policy.";
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.White;
    this.ClientSize = new Size(354, 254);
    this.Controls.Add((Control) this.Label3);
    this.Controls.Add((Control) this.Label2);
    this.Controls.Add((Control) this.lnkFullQuote);
    this.Controls.Add((Control) this.lnkQuickQuote);
    this.Controls.Add((Control) this.PictureBox2);
    this.Controls.Add((Control) this.PictureBox1);
    this.Controls.Add((Control) this.Label1);
    this.DoubleBuffered = true;
    this.Font = new Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.ForeColor = Color.Black;
    this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
    this.Name = nameof (frmSelectQuoteType);
    this.StartPosition = FormStartPosition.CenterScreen;
    ((ISupportInitialize) this.PictureBox1).EndInit();
    ((ISupportInitialize) this.PictureBox2).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  public bool QuoteTypeSelected
  {
    get => this._quoteTypeSelected;
    set => this._quoteTypeSelected = value;
  }

  public bool QuickQuote
  {
    get => this._quickQuote;
    set => this._quickQuote = value;
  }

  private void LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    if (sender == this.lnkQuickQuote)
      this.QuickQuote = true;
    this.QuoteTypeSelected = true;
    this.Close();
  }
}
