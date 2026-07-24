// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.GeneralLedger.Forms.FormImportErrors
// Assembly: MgaSystems.IMS.Accounting.GeneralLedger, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: DC511D5D-5AA9-4B52-8578-E2A0BCB046C3
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Accounting.GeneralLedger.dll

using Infragistics.Win;
using Infragistics.Win.UltraWinEditors;
using MGASystems.Common;
using MGASystems.Tools;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.GeneralLedger.Forms;

public class FormImportErrors : FormBase
{
  private IContainer components;
  private MGATextBox textErrors;

  public FormImportErrors(string errorText)
  {
    this.InitializeComponent();
    ((Control) this.textErrors).Text = errorText;
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
    this.textErrors = new MGATextBox();
    ((ISupportInitialize) this.textErrors).BeginInit();
    this.SuspendLayout();
    ((AppearanceBase) appearance).BackColor = Color.White;
    ((AppearanceBase) appearance).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textErrors).Appearance = (AppearanceBase) appearance;
    ((Control) this.textErrors).BackColor = Color.White;
    ((Control) this.textErrors).Dock = DockStyle.Fill;
    ((Control) this.textErrors).Font = new Font("Tahoma", 9f);
    ((Control) this.textErrors).Location = new Point(0, 0);
    this.textErrors.MGAStyle = MGAStyles.Blue;
    this.textErrors.Multiline = true;
    ((Control) this.textErrors).Name = "textErrors";
    this.textErrors.Scrollbars = ScrollBars.Vertical;
    ((Control) this.textErrors).Size = new Size(603, 475);
    ((Control) this.textErrors).TabIndex = 0;
    ((UltraControlBase) this.textErrors).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textErrors).UseOsThemes = (DefaultableBoolean) 2;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(603, 475);
    this.Controls.Add((Control) this.textErrors);
    this.Font = new Font("Tahoma", 8.25f);
    this.FormBorderStyle = FormBorderStyle.FixedDialog;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (FormImportErrors);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Journal Entry Import Errors";
    ((ISupportInitialize) this.textErrors).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }
}
