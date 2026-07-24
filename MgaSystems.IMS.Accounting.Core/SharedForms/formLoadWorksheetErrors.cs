// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.SharedForms.formLoadWorksheetErrors
// Assembly: MgaSystems.IMS.Accounting.Core, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 923053EF-B70A-44B5-B8DA-B227263F4FD2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Core.dll

using Infragistics.Win;
using Infragistics.Win.UltraWinEditors;
using MGASystems.IMS.Accounting.Services;
using MGASystems.Tools;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.SharedForms;

public class formLoadWorksheetErrors : AccountingNoteDocumentSupport
{
  private MGATextBox textErrorLog;
  private System.ComponentModel.Container components;

  public formLoadWorksheetErrors(ArrayList errorList)
  {
    this.InitializeComponent();
    this.DisplayErrors(errorList);
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    Appearance appearance = new Appearance();
    this.textErrorLog = new MGATextBox();
    ((ISupportInitialize) this.textErrorLog).BeginInit();
    this.SuspendLayout();
    ((AppearanceBase) appearance).BackColor = Color.White;
    ((AppearanceBase) appearance).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textErrorLog).Appearance = (AppearanceBase) appearance;
    ((Control) this.textErrorLog).Location = new Point(8, 8);
    this.textErrorLog.MGAStyle = MGAStyles.Blue;
    this.textErrorLog.Multiline = true;
    ((Control) this.textErrorLog).Name = "textErrorLog";
    this.textErrorLog.Scrollbars = ScrollBars.Vertical;
    ((Control) this.textErrorLog).Size = new Size(544, 408);
    ((Control) this.textErrorLog).TabIndex = 0;
    this.AutoScaleBaseSize = new Size(5, 13);
    this.BackColor = Color.FromArgb(239, 247, 253);
    this.ClientSize = new Size(560, 422);
    this.Controls.Add((Control) this.textErrorLog);
    this.Font = new Font("Tahoma", 8f);
    this.ForeColor = Color.Black;
    this.FormBorderStyle = FormBorderStyle.FixedDialog;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (formLoadWorksheetErrors);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Worksheet Errors";
    ((ISupportInitialize) this.textErrorLog).EndInit();
    this.ResumeLayout(false);
  }

  private void DisplayErrors(ArrayList errorList)
  {
    for (int index = 0; index < errorList.Count; ++index)
    {
      if (((Control) this.textErrorLog).Text.Equals(string.Empty))
      {
        MGATextBox textErrorLog = this.textErrorLog;
        ((Control) textErrorLog).Text = ((Control) textErrorLog).Text + errorList[index].ToString();
      }
      else
      {
        MGATextBox textErrorLog = this.textErrorLog;
        ((Control) textErrorLog).Text = ((Control) textErrorLog).Text + Environment.NewLine + errorList[index].ToString();
      }
    }
  }
}
