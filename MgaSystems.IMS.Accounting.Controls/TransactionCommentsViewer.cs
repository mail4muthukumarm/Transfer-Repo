// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Controls.TransactionCommentsViewer
// Assembly: MgaSystems.IMS.Accounting.Controls, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 69E8E7CF-F3E0-45A9-94CD-B8A0D33430C8
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Accounting.Controls.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using MGASystems.Data;
using MGASystems.Tools;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Controls;

public class TransactionCommentsViewer : UserControl
{
  private IContainer components;
  private string _transactionNumber;

  public TransactionCommentsViewer()
  {
    this.InitializeComponent();
    this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  [field: AccessedThroughProperty("EllipsePanel1")]
  internal virtual EllipsePanel EllipsePanel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("textComments")]
  internal virtual MGATextBox textComments { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual MGAButton MgaButton1
  {
    get => this._MgaButton1;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.MgaButton1_Click);
      MGAButton mgaButton1_1 = this._MgaButton1;
      if (mgaButton1_1 != null)
        ((Control) mgaButton1_1).Click -= eventHandler;
      this._MgaButton1 = value;
      MGAButton mgaButton1_2 = this._MgaButton1;
      if (mgaButton1_2 == null)
        return;
      ((Control) mgaButton1_2).Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("Label1")]
  internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual MGAButton buttonCancelEditComment
  {
    get => this._buttonCancelEditComment;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.buttonCancelEditComment_Click);
      MGAButton cancelEditComment1 = this._buttonCancelEditComment;
      if (cancelEditComment1 != null)
        ((Control) cancelEditComment1).Click -= eventHandler;
      this._buttonCancelEditComment = value;
      MGAButton cancelEditComment2 = this._buttonCancelEditComment;
      if (cancelEditComment2 == null)
        return;
      ((Control) cancelEditComment2).Click += eventHandler;
    }
  }

  private virtual MGAButton buttonSaveEditComment
  {
    get => this._buttonSaveEditComment;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.buttonSaveEditComment_Click);
      MGAButton buttonSaveEditComment1 = this._buttonSaveEditComment;
      if (buttonSaveEditComment1 != null)
        ((Control) buttonSaveEditComment1).Click -= eventHandler;
      this._buttonSaveEditComment = value;
      MGAButton buttonSaveEditComment2 = this._buttonSaveEditComment;
      if (buttonSaveEditComment2 == null)
        return;
      ((Control) buttonSaveEditComment2).Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("labelNonefound")]
  internal virtual Label labelNonefound { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    this.EllipsePanel1 = new EllipsePanel();
    this.labelNonefound = new Label();
    this.Label1 = new Label();
    this.MgaButton1 = new MGAButton();
    this.textComments = new MGATextBox();
    this.buttonCancelEditComment = new MGAButton();
    this.buttonSaveEditComment = new MGAButton();
    this.EllipsePanel1.SuspendLayout();
    ((ISupportInitialize) this.MgaButton1).BeginInit();
    ((ISupportInitialize) this.textComments).BeginInit();
    ((ISupportInitialize) this.buttonCancelEditComment).BeginInit();
    ((ISupportInitialize) this.buttonSaveEditComment).BeginInit();
    this.SuspendLayout();
    this.EllipsePanel1.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    this.EllipsePanel1.Controls.Add((Control) this.buttonCancelEditComment);
    this.EllipsePanel1.Controls.Add((Control) this.buttonSaveEditComment);
    this.EllipsePanel1.Controls.Add((Control) this.labelNonefound);
    this.EllipsePanel1.Controls.Add((Control) this.Label1);
    this.EllipsePanel1.Controls.Add((Control) this.MgaButton1);
    this.EllipsePanel1.Controls.Add((Control) this.textComments);
    this.EllipsePanel1.Location = new Point(0, 0);
    this.EllipsePanel1.Name = "EllipsePanel1";
    this.EllipsePanel1.Size = new Size(280, 211);
    this.EllipsePanel1.TabIndex = 0;
    this.labelNonefound.BackColor = Color.White;
    this.labelNonefound.Location = new Point(16 /*0x10*/, 88);
    this.labelNonefound.Name = "labelNonefound";
    this.labelNonefound.Size = new Size(248, 23);
    this.labelNonefound.TabIndex = 3;
    this.labelNonefound.Text = "No comments found.";
    this.labelNonefound.TextAlign = ContentAlignment.MiddleCenter;
    this.labelNonefound.Visible = false;
    this.Label1.AutoSize = true;
    this.Label1.Font = new Font("Tahoma", 8f, FontStyle.Bold | FontStyle.Underline);
    this.Label1.ForeColor = Color.Black;
    this.Label1.Location = new Point(8, 8);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(138, 13);
    this.Label1.TabIndex = 2;
    this.Label1.Text = "Transaction Comments";
    appearance1.BackColor = Color.FromArgb(248, 248, 248);
    appearance1.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance1.BackGradientStyle = (GradientStyle) 2;
    appearance1.BorderColor = Color.DarkGray;
    ((ControlBase) this.MgaButton1).Appearance = (AppearanceBase) appearance1;
    ((Control) this.MgaButton1).Location = new Point(260, 4);
    ((Control) this.MgaButton1).Name = "MgaButton1";
    ((Control) this.MgaButton1).Size = new Size(16 /*0x10*/, 16 /*0x10*/);
    ((Control) this.MgaButton1).TabIndex = 1;
    ((ControlBase) this.MgaButton1).Text = "X";
    this.MgaButton1.UseOSThemes = (DefaultableBoolean) 2;
    ((Control) this.MgaButton1).Visible = false;
    appearance2.BackColor = Color.White;
    appearance2.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance2.ForeColor = Color.Black;
    ((TextEditorControlBase) this.textComments).Appearance = (AppearanceBase) appearance2;
    ((TextEditorControlBase) this.textComments).BackColor = Color.White;
    ((Control) this.textComments).Location = new Point(8, 24);
    this.textComments.MGAStyle = MGAStyles.Blue;
    this.textComments.Multiline = true;
    ((Control) this.textComments).Name = "textComments";
    ((Control) this.textComments).Size = new Size(264, 152);
    ((Control) this.textComments).TabIndex = 0;
    ((UltraControlBase) this.textComments).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textComments).UseOsThemes = (DefaultableBoolean) 2;
    appearance3.BackColor = Color.FromArgb(248, 248, 248);
    appearance3.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance3.BackGradientStyle = (GradientStyle) 2;
    appearance3.BorderColor = Color.DarkGray;
    appearance3.Image = (object) MGASystems.IMS.Accounting.Controls.My.Resources.Resources.delete;
    appearance3.ImageHAlign = (HAlign) 2;
    appearance3.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonCancelEditComment).Appearance = (AppearanceBase) appearance3;
    ((Control) this.buttonCancelEditComment).Location = new Point(248, 180);
    ((Control) this.buttonCancelEditComment).Name = "buttonCancelEditComment";
    ((Control) this.buttonCancelEditComment).Size = new Size(24, 24);
    ((Control) this.buttonCancelEditComment).TabIndex = 24;
    ((UltraControlBase) this.buttonCancelEditComment).UseFlatMode = (DefaultableBoolean) 1;
    this.buttonCancelEditComment.UseOSThemes = (DefaultableBoolean) 2;
    appearance4.BackColor = Color.FromArgb(248, 248, 248);
    appearance4.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance4.BackGradientStyle = (GradientStyle) 2;
    appearance4.BorderColor = Color.DarkGray;
    appearance4.Image = (object) MGASystems.IMS.Accounting.Controls.My.Resources.Resources.disk;
    appearance4.ImageHAlign = (HAlign) 2;
    appearance4.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonSaveEditComment).Appearance = (AppearanceBase) appearance4;
    ((Control) this.buttonSaveEditComment).Location = new Point(222, 180);
    ((Control) this.buttonSaveEditComment).Name = "buttonSaveEditComment";
    ((Control) this.buttonSaveEditComment).Size = new Size(24, 24);
    ((Control) this.buttonSaveEditComment).TabIndex = 23;
    ((UltraControlBase) this.buttonSaveEditComment).UseFlatMode = (DefaultableBoolean) 1;
    this.buttonSaveEditComment.UseOSThemes = (DefaultableBoolean) 2;
    this.BackColor = SystemColors.Control;
    this.Controls.Add((Control) this.EllipsePanel1);
    this.Font = new Font("Tahoma", 8f);
    this.ForeColor = Color.Black;
    this.Name = nameof (TransactionCommentsViewer);
    this.Size = new Size(280, 211);
    this.EllipsePanel1.ResumeLayout(false);
    this.EllipsePanel1.PerformLayout();
    ((ISupportInitialize) this.MgaButton1).EndInit();
    ((ISupportInitialize) this.textComments).EndInit();
    ((ISupportInitialize) this.buttonCancelEditComment).EndInit();
    ((ISupportInitialize) this.buttonSaveEditComment).EndInit();
    this.ResumeLayout(false);
  }

  public void LoadComments(int transactionNumber)
  {
    this._transactionNumber = Conversions.ToString(transactionNumber);
    ((TextEditorControlBase) this.textComments).Text = DefaultDatabase.ExecuteScalar<string>("spFin_GetTransactionPostingComment", new object[2]
    {
      (object) "@transactnum",
      (object) transactionNumber
    });
  }

  private void MgaButton1_Click(object sender, EventArgs e) => this.Visible = false;

  private void buttonSaveEditComment_Click(object sender, EventArgs e)
  {
    DefaultDatabase.ExecuteNonQuery("spFin_UpdateTransactionComment", new object[4]
    {
      (object) "@transactNum",
      (object) this._transactionNumber,
      (object) "@comments",
      (object) ((TextEditorControlBase) this.textComments).Text
    });
    this.Visible = false;
  }

  private void buttonCancelEditComment_Click(object sender, EventArgs e) => this.Visible = false;
}
