// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Claims.Claims.FormVoidTransactionComment
// Assembly: MgaSystems.IMS.Claims, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FCD9D0B7-28CF-40B9-8EB7-297871E1AF5F
// Assembly location: F:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.Tools;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Claims.Claims;

public class FormVoidTransactionComment : FormBase
{
  private int _transactionNumber;
  private IContainer components;
  protected MGATextBox textComments;
  protected Label label3;
  protected MGAButton buttonCancel;
  protected MGAButton buttonSave;

  public FormVoidTransactionComment(int transactionNumber)
  {
    this._transactionNumber = transactionNumber;
    this.InitializeComponent();
  }

  private void buttonSave_Click(object sender, EventArgs e)
  {
    DefaultDatabase.ExecuteNonQuery("dbo.spClaims_AddVoidTransactionComment", new object[4]
    {
      (object) "@TransactionNumber",
      (object) this._transactionNumber,
      (object) "@Comments",
      (object) ((Control) this.textComments).Text
    });
    this.Close();
  }

  private void buttonCancel_Click(object sender, EventArgs e) => this.Close();

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
    this.textComments = new MGATextBox();
    this.label3 = new Label();
    this.buttonCancel = new MGAButton();
    this.buttonSave = new MGAButton();
    ((ISupportInitialize) this.textComments).BeginInit();
    ((ISupportInitialize) this.buttonCancel).BeginInit();
    ((ISupportInitialize) this.buttonSave).BeginInit();
    this.SuspendLayout();
    ((AppearanceBase) appearance1).BackColor = Color.White;
    ((AppearanceBase) appearance1).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance1).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textComments).Appearance = (AppearanceBase) appearance1;
    ((Control) this.textComments).BackColor = Color.White;
    ((Control) this.textComments).Location = new Point(15, 26);
    this.textComments.MGAStyle = (MGAStyles) 2;
    ((UltraTextEditor) this.textComments).Multiline = true;
    ((Control) this.textComments).Name = "textComments";
    ((Control) this.textComments).Size = new Size(333, 128 /*0x80*/);
    ((Control) this.textComments).TabIndex = 10;
    ((UltraControlBase) this.textComments).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textComments).UseOsThemes = (DefaultableBoolean) 2;
    this.label3.AutoSize = true;
    this.label3.BackColor = Color.Transparent;
    this.label3.Location = new Point(12, 9);
    this.label3.Name = "label3";
    this.label3.Size = new Size(92, 13);
    this.label3.TabIndex = 9;
    this.label3.Text = "Posting Comment:";
    ((AppearanceBase) appearance2).BackColor = Color.Gainsboro;
    ((AppearanceBase) appearance2).BackColor2 = Color.White;
    ((AppearanceBase) appearance2).BackGradientStyle = (GradientStyle) 2;
    ((ControlBase) this.buttonCancel).Appearance = (AppearanceBase) appearance2;
    ((Control) this.buttonCancel).Location = new Point(244, 160 /*0xA0*/);
    ((Control) this.buttonCancel).Name = "buttonCancel";
    ((Control) this.buttonCancel).Size = new Size(104, 24);
    ((Control) this.buttonCancel).TabIndex = 8;
    ((Control) this.buttonCancel).Text = "Cancel";
    ((UltraControlBase) this.buttonCancel).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.buttonCancel).Click += new EventHandler(this.buttonCancel_Click);
    ((AppearanceBase) appearance3).BackColor = Color.Gainsboro;
    ((AppearanceBase) appearance3).BackColor2 = Color.White;
    ((AppearanceBase) appearance3).BackGradientStyle = (GradientStyle) 2;
    ((ControlBase) this.buttonSave).Appearance = (AppearanceBase) appearance3;
    ((Control) this.buttonSave).Location = new Point(124, 160 /*0xA0*/);
    ((Control) this.buttonSave).Name = "buttonSave";
    ((Control) this.buttonSave).Size = new Size(104, 24);
    ((Control) this.buttonSave).TabIndex = 7;
    ((Control) this.buttonSave).Text = "Save";
    ((UltraControlBase) this.buttonSave).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.buttonSave).Click += new EventHandler(this.buttonSave_Click);
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(356, 193);
    this.Controls.Add((Control) this.textComments);
    this.Controls.Add((Control) this.label3);
    this.Controls.Add((Control) this.buttonCancel);
    this.Controls.Add((Control) this.buttonSave);
    this.Name = "FormVoidComment";
    this.Text = "Add Void Comment?";
    ((ISupportInitialize) this.textComments).EndInit();
    ((ISupportInitialize) this.buttonCancel).EndInit();
    ((ISupportInitialize) this.buttonSave).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }
}
