// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Claims.FormMoveClaim
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
using System.Text;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Claims;

public class FormMoveClaim : FormBase
{
  private readonly int _claimId;
  private readonly int _fromControlNumber;
  private readonly string _claimNumber;
  private IContainer components;
  private Label label1;
  private MGATextBox textControlNumber;
  internal MGAButton buttonSearch;
  internal MGAButton buttonCancel;

  public FormMoveClaim(int claimId, int fromControlNumber, string claimNumber)
  {
    this.InitializeComponent();
    this._claimId = claimId;
    this._fromControlNumber = fromControlNumber;
    this._claimNumber = claimNumber;
  }

  private void buttonCancel_Click(object sender, EventArgs e)
  {
    this.DialogResult = DialogResult.Cancel;
  }

  private void buttonSearch_Click(object sender, EventArgs e)
  {
    if (!this.VerifyForm())
      return;
    int toControlNumber;
    if (!int.TryParse(((Control) this.textControlNumber).Text, out toControlNumber))
    {
      int num1 = (int) MessageBox.Show("Control number must be numeric.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
    else
    {
      StringBuilder stringBuilder = new StringBuilder();
      stringBuilder.AppendLine("Warning!");
      stringBuilder.AppendLine("The system will only validate that the same insured, company and producer location and line of business exists on the new control number. The date of loss and coverages will not be verified and may be invalid.");
      if (MessageBox.Show(stringBuilder.ToString(), "Move Claim?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.Yes)
        return;
      DefaultDatabase.ExecuteTransaction((EventHandler<ExecuteTransactionEventArgs>) ((s, etea) =>
      {
        try
        {
          DefaultDatabase.ExecuteNonQuery("dbo.spClaims_MoveClaim", new object[6]
          {
            (object) "@fromControlNo",
            (object) this._fromControlNumber,
            (object) "@toControlNo",
            (object) toControlNumber,
            (object) "@claimid",
            (object) this._claimId
          });
          CurrentUser.Instance.LogAction($"Moved claim number {this._claimNumber} from control number {this._fromControlNumber} to control number {toControlNumber}.");
          etea.Transaction.Commit();
          this.DialogResult = DialogResult.OK;
          this.Close();
        }
        catch (Exception ex)
        {
          etea.Transaction.Rollback();
          int num2 = (int) MessageBox.Show(ex.Message, "Cannot Move Claim!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }
      }));
    }
  }

  private bool VerifyForm()
  {
    if (!string.IsNullOrEmpty(((Control) this.textControlNumber).Text))
      return true;
    int num = (int) MessageBox.Show("You must enter a control number to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    return false;
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
    Appearance appearance3 = new Appearance();
    this.label1 = new Label();
    this.textControlNumber = new MGATextBox();
    this.buttonSearch = new MGAButton();
    this.buttonCancel = new MGAButton();
    ((ISupportInitialize) this.textControlNumber).BeginInit();
    ((ISupportInitialize) this.buttonSearch).BeginInit();
    ((ISupportInitialize) this.buttonCancel).BeginInit();
    this.SuspendLayout();
    this.label1.AutoSize = true;
    this.label1.BackColor = Color.Transparent;
    this.label1.Location = new Point(13, 13);
    this.label1.Name = "label1";
    this.label1.Size = new Size(83, 13);
    this.label1.TabIndex = 0;
    this.label1.Text = "Control Number:";
    ((AppearanceBase) appearance1).BackColor = Color.White;
    ((AppearanceBase) appearance1).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance1).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textControlNumber).Appearance = (AppearanceBase) appearance1;
    ((Control) this.textControlNumber).BackColor = Color.White;
    ((Control) this.textControlNumber).Location = new Point(102, 13);
    this.textControlNumber.MGAStyle = (MGAStyles) 2;
    ((Control) this.textControlNumber).Name = "textControlNumber";
    ((Control) this.textControlNumber).Size = new Size(134, 19);
    ((Control) this.textControlNumber).TabIndex = 2;
    ((UltraControlBase) this.textControlNumber).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textControlNumber).UseOsThemes = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance2).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance2).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance2).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance2).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance2).ImageHAlign = (HAlign) 2;
    ((AppearanceBase) appearance2).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonSearch).Appearance = (AppearanceBase) appearance2;
    ((Control) this.buttonSearch).Location = new Point(65, 40);
    ((Control) this.buttonSearch).Name = "buttonSearch";
    ((Control) this.buttonSearch).Size = new Size(83, 22);
    ((Control) this.buttonSearch).TabIndex = 36;
    ((Control) this.buttonSearch).Text = "Move Claim";
    ((UltraControlBase) this.buttonSearch).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.buttonSearch).Click += new EventHandler(this.buttonSearch_Click);
    ((AppearanceBase) appearance3).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance3).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance3).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance3).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance3).ImageHAlign = (HAlign) 2;
    ((AppearanceBase) appearance3).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonCancel).Appearance = (AppearanceBase) appearance3;
    ((Control) this.buttonCancel).Location = new Point(153, 40);
    ((Control) this.buttonCancel).Name = "buttonCancel";
    ((Control) this.buttonCancel).Size = new Size(83, 22);
    ((Control) this.buttonCancel).TabIndex = 37;
    ((Control) this.buttonCancel).Text = "Cancel/Clear";
    ((UltraControlBase) this.buttonCancel).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.buttonCancel).Click += new EventHandler(this.buttonCancel_Click);
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(248, 69);
    this.ControlBox = false;
    this.Controls.Add((Control) this.buttonSearch);
    this.Controls.Add((Control) this.buttonCancel);
    this.Controls.Add((Control) this.textControlNumber);
    this.Controls.Add((Control) this.label1);
    this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
    this.Name = nameof (FormMoveClaim);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Move Claim";
    ((ISupportInitialize) this.textControlNumber).EndInit();
    ((ISupportInitialize) this.buttonSearch).EndInit();
    ((ISupportInitialize) this.buttonCancel).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }
}
