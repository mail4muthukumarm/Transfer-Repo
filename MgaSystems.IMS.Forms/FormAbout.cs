// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Forms.FormAbout
// Assembly: MgaSystems.IMS.Forms, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FB3F392E-40B6-486F-8F0B-A4A494A546D4
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Forms.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using MGASystems.Common.ErrorHandling;
using MGASystems.Tools;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Forms;

internal sealed class FormAbout : Form
{
  private IContainer components;
  private readonly Queue _letterQueue;

  public FormAbout()
  {
    this.Load += new EventHandler(this.FormAbout_Load);
    this.KeyUp += new KeyEventHandler(this.Form1_KeyUp);
    this._letterQueue = new Queue();
    this.InitializeComponent();
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  [field: AccessedThroughProperty("Label1")]
  internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblCopyright")]
  internal virtual Label lblCopyright { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label4")]
  internal virtual Label Label4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("PictureBox1")]
  internal virtual PictureBox PictureBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual LinkLabel LinkLabel1
  {
    get => this._LinkLabel1;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.LinkLabel1_LinkClicked);
      LinkLabel linkLabel1_1 = this._LinkLabel1;
      if (linkLabel1_1 != null)
        linkLabel1_1.LinkClicked -= clickedEventHandler;
      this._LinkLabel1 = value;
      LinkLabel linkLabel1_2 = this._LinkLabel1;
      if (linkLabel1_2 == null)
        return;
      linkLabel1_2.LinkClicked += clickedEventHandler;
    }
  }

  private virtual MGAButton btnClose
  {
    get => this._btnClose;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnClose_Click);
      MGAButton btnClose1 = this._btnClose;
      if (btnClose1 != null)
        ((Control) btnClose1).Click -= eventHandler;
      this._btnClose = value;
      MGAButton btnClose2 = this._btnClose;
      if (btnClose2 == null)
        return;
      ((Control) btnClose2).Click += eventHandler;
    }
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    Appearance appearance = new Appearance();
    this.btnClose = new MGAButton();
    this.Label1 = new Label();
    this.lblCopyright = new Label();
    this.Label4 = new Label();
    this.PictureBox1 = new PictureBox();
    this.LinkLabel1 = new LinkLabel();
    ((ISupportInitialize) this.btnClose).BeginInit();
    ((ISupportInitialize) this.PictureBox1).BeginInit();
    this.SuspendLayout();
    appearance.BackColor = Color.FromArgb(248, 248, 248);
    appearance.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance.BackGradientStyle = (GradientStyle) 2;
    appearance.BorderColor = Color.DarkGray;
    appearance.ImageHAlign = (HAlign) 2;
    appearance.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnClose).Appearance = (AppearanceBase) appearance;
    ((ControlBase) this.btnClose).BackColorInternal = Color.WhiteSmoke;
    ((UltraButtonBase) this.btnClose).DialogResult = DialogResult.Cancel;
    ((Control) this.btnClose).Location = new Point(143, 240 /*0xF0*/);
    ((Control) this.btnClose).Name = "btnClose";
    ((Control) this.btnClose).Size = new Size(100, 24);
    ((Control) this.btnClose).TabIndex = 6;
    ((ControlBase) this.btnClose).Text = "OK";
    this.btnClose.UseOSThemes = (DefaultableBoolean) 2;
    this.Label1.AutoSize = true;
    this.Label1.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label1.Location = new Point(79, 146);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(229, 19);
    this.Label1.TabIndex = 8;
    this.Label1.Text = "Insurance Management System";
    this.lblCopyright.AutoSize = true;
    this.lblCopyright.Font = new Font("Tahoma", 8f);
    this.lblCopyright.Location = new Point(124, 168);
    this.lblCopyright.Name = "lblCopyright";
    this.lblCopyright.Size = new Size(152, 13);
    this.lblCopyright.TabIndex = 10;
    this.lblCopyright.Text = "Vertafore, Inc. © {Now.Year}";
    this.Label4.AutoSize = true;
    this.Label4.Font = new Font("Tahoma", 8f);
    this.Label4.Location = new Point(145, 186);
    this.Label4.Name = "Label4";
    this.Label4.Size = new Size(98, 13);
    this.Label4.TabIndex = 11;
    this.Label4.Text = "All rights reserved.";
    this.PictureBox1.Image = (Image) MGASystems.IMS.Forms.My.Resources.Resources.MGA_Logo_Small;
    this.PictureBox1.Location = new Point(12, 4);
    this.PictureBox1.Name = "PictureBox1";
    this.PictureBox1.Size = new Size(362, 128 /*0x80*/);
    this.PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
    this.PictureBox1.TabIndex = 7;
    this.PictureBox1.TabStop = false;
    this.LinkLabel1.AutoSize = true;
    this.LinkLabel1.Location = new Point(145, 210);
    this.LinkLabel1.Name = "LinkLabel1";
    this.LinkLabel1.Size = new Size(95, 13);
    this.LinkLabel1.TabIndex = 12;
    this.LinkLabel1.TabStop = true;
    this.LinkLabel1.Text = "Privacy Statement";
    this.AcceptButton = (IButtonControl) this.btnClose;
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.White;
    this.CancelButton = (IButtonControl) this.btnClose;
    this.ClientSize = new Size(386, 272);
    this.Controls.Add((Control) this.LinkLabel1);
    this.Controls.Add((Control) this.Label4);
    this.Controls.Add((Control) this.lblCopyright);
    this.Controls.Add((Control) this.Label1);
    this.Controls.Add((Control) this.PictureBox1);
    this.Controls.Add((Control) this.btnClose);
    this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.ForeColor = Color.Black;
    this.FormBorderStyle = FormBorderStyle.FixedSingle;
    this.KeyPreview = true;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (FormAbout);
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "About IMS";
    ((ISupportInitialize) this.btnClose).EndInit();
    ((ISupportInitialize) this.PictureBox1).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  private void FormAbout_Load(object sender, EventArgs e)
  {
    this.StartPosition = FormStartPosition.CenterScreen;
    this.lblCopyright.Text = $"Vertafore, Inc. © {DateAndTime.Now.Year}";
  }

  private void btnClose_Click(object sender, EventArgs e) => this.Close();

  private void Form1_KeyUp(object sender, KeyEventArgs e)
  {
    this._letterQueue.Enqueue((object) e.KeyData.ToString());
    if (this._letterQueue.Count > 5)
      this._letterQueue.Dequeue();
    if (this._letterQueue.Count != 5)
      return;
    FormAbout.OnFiveLetterAlphaCodeRecieved(this.QueueString);
  }

  private string QueueString
  {
    get
    {
      StringBuilder stringBuilder = new StringBuilder();
      try
      {
        foreach (object letter in this._letterQueue)
        {
          char ch = Conversions.ToChar(letter);
          stringBuilder.Append(ch);
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
      return stringBuilder.ToString();
    }
  }

  private static void OnFiveLetterAlphaCodeRecieved(string code)
  {
    string Left = code;
    if (Operators.CompareString(Left, "CRASH", false) != 0)
    {
      if (Operators.CompareString(Left, "SILEN", false) != 0)
      {
        if (Operators.CompareString(Left, "NULLE", false) != 0)
          return;
        ErrorHandler.HandleError(new Exception("I'm an Exception with no StackTrace"));
      }
      else
      {
        try
        {
          InvalidOperationException operationException = new InvalidOperationException("IMS Test Exception", new Exception("I'm an inner exception!"));
          operationException.Data[(object) "MGA Test Data Key 1"] = (object) "Test Value 1";
          operationException.Data[(object) "MGA Test Data Key 2"] = (object) 2;
          throw operationException;
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ErrorHandler.SilentHandleError(ex);
          ProjectData.ClearProjectError();
        }
      }
    }
    else
    {
      InvalidOperationException operationException = new InvalidOperationException("IMS Test Exception", new Exception("I'm an inner exception!"));
      operationException.Data[(object) "MGA Test Data Key 1"] = (object) "Test Value 1";
      operationException.Data[(object) "MGA Test Data Key 2"] = (object) 2;
      throw operationException;
    }
  }

  private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    Process.Start("https://www.vertafore.com/product-privacy-statement");
  }
}
