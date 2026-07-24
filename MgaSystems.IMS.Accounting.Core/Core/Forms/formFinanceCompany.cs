// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Core.Forms.formFinanceCompany
// Assembly: MgaSystems.IMS.Accounting.Core, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 923053EF-B70A-44B5-B8DA-B227263F4FD2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Core.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using MGASystems.IMS.Accounting.Core.ClassObjects;
using MGASystems.IMS.Accounting.Core.Properties;
using MGASystems.Tools;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Core.Forms;

public class formFinanceCompany : Form
{
  private Guid _financeCompanyGuid;
  private string _financeCompanyName;
  private IContainer components;
  private MGATextBox textFinanceCompany;
  private MGATextBox textAccountNumber;
  private UltraLabel ultraLabel1;
  private UltraLabel ultraLabel2;
  private UltraLabel ultraLabel3;
  private MGAButton buttonCancel;
  private MGAButton buttonSave;
  private MGAButton buttonSearch;
  private MGAButton buttonClearFinanceCompany;

  public Guid FinanceCompanyGuid
  {
    get => this._financeCompanyGuid;
    private set => this._financeCompanyGuid = value;
  }

  public string FinanceCompany
  {
    get => this._financeCompanyName;
    private set
    {
      this._financeCompanyName = value;
      ((Control) this.textFinanceCompany).Text = value;
    }
  }

  public string AccountNumber
  {
    get => ((Control) this.textAccountNumber).Text;
    private set => ((Control) this.textAccountNumber).Text = value;
  }

  public bool ClearFinanceCompany { get; set; }

  public formFinanceCompany() => this.InitializeComponent();

  public formFinanceCompany(
    string financeCompanyName,
    Guid financeCompanyGuid,
    string financeAccountNumber)
  {
    this.InitializeComponent();
    if (!(financeCompanyGuid != Guid.Empty))
      return;
    this.FinanceCompanyGuid = financeCompanyGuid;
    this.FinanceCompany = financeCompanyName;
    this.AccountNumber = financeAccountNumber;
  }

  private void buttonSearch_Click(object sender, EventArgs e)
  {
    using (FormSearchEntity formSearchEntity = new FormSearchEntity(Utility.SearchEntityTypes.ShowFinanceCompanies))
    {
      if (formSearchEntity.ShowDialog() != DialogResult.OK)
        return;
      this._financeCompanyGuid = formSearchEntity.EntityGuid;
      this._financeCompanyName = formSearchEntity.EntityName;
      ((Control) this.textFinanceCompany).Text = formSearchEntity.EntityName;
    }
  }

  private bool VerifyForm()
  {
    if (!string.IsNullOrEmpty(((Control) this.textFinanceCompany).Text))
      return true;
    int num = (int) MessageBox.Show("You must specify a finance company to continue.", "Required Field Missing", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    return false;
  }

  private void buttonSave_Click(object sender, EventArgs e)
  {
    if (!this.VerifyForm())
      return;
    this.ClearFinanceCompany = false;
    this.DialogResult = DialogResult.OK;
    this.Close();
  }

  private void buttonCancel_Click(object sender, EventArgs e)
  {
    this.ClearFinanceCompany = false;
    this.DialogResult = DialogResult.Cancel;
    this.Close();
  }

  private void buttonClearFinanceCompany_Click(object sender, EventArgs e)
  {
    if (MessageBox.Show("This will clear the finance company from this policy, continue?", "Clear Finance Company?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
      return;
    this.ClearFinanceCompany = true;
    this.DialogResult = DialogResult.OK;
    this.Close();
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
    Appearance appearance4 = new Appearance();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (formFinanceCompany));
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    this.textFinanceCompany = new MGATextBox();
    this.textAccountNumber = new MGATextBox();
    this.ultraLabel1 = new UltraLabel();
    this.ultraLabel2 = new UltraLabel();
    this.ultraLabel3 = new UltraLabel();
    this.buttonCancel = new MGAButton();
    this.buttonSave = new MGAButton();
    this.buttonSearch = new MGAButton();
    this.buttonClearFinanceCompany = new MGAButton();
    ((ISupportInitialize) this.textFinanceCompany).BeginInit();
    ((ISupportInitialize) this.textAccountNumber).BeginInit();
    ((ISupportInitialize) this.buttonCancel).BeginInit();
    ((ISupportInitialize) this.buttonSave).BeginInit();
    ((ISupportInitialize) this.buttonSearch).BeginInit();
    ((ISupportInitialize) this.buttonClearFinanceCompany).BeginInit();
    this.SuspendLayout();
    ((AppearanceBase) appearance1).BackColor = Color.White;
    ((AppearanceBase) appearance1).BorderColor = Color.Gray;
    ((AppearanceBase) appearance1).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textFinanceCompany).Appearance = (AppearanceBase) appearance1;
    ((Control) this.textFinanceCompany).BackColor = Color.White;
    ((Control) this.textFinanceCompany).Location = new Point(108, 42);
    ((Control) this.textFinanceCompany).Name = "textFinanceCompany";
    ((EditorButtonControlBase) this.textFinanceCompany).ReadOnly = true;
    ((Control) this.textFinanceCompany).Size = new Size(282, 20);
    ((Control) this.textFinanceCompany).TabIndex = 0;
    ((UltraControlBase) this.textFinanceCompany).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textFinanceCompany).UseOsThemes = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance2).BackColor = Color.White;
    ((AppearanceBase) appearance2).BorderColor = Color.Gray;
    ((AppearanceBase) appearance2).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textAccountNumber).Appearance = (AppearanceBase) appearance2;
    ((Control) this.textAccountNumber).BackColor = Color.White;
    ((Control) this.textAccountNumber).Location = new Point(108, 68);
    ((Control) this.textAccountNumber).Name = "textAccountNumber";
    ((Control) this.textAccountNumber).Size = new Size(282, 20);
    ((Control) this.textAccountNumber).TabIndex = 1;
    ((UltraControlBase) this.textAccountNumber).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textAccountNumber).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.ultraLabel1).AutoSize = true;
    ((Control) this.ultraLabel1).Location = new Point(5, 42);
    ((Control) this.ultraLabel1).Name = "ultraLabel1";
    ((Control) this.ultraLabel1).Size = new Size(97, 15);
    ((Control) this.ultraLabel1).TabIndex = 2;
    ((Control) this.ultraLabel1).Text = "Finance Company:";
    ((Control) this.ultraLabel2).AutoSize = true;
    ((Control) this.ultraLabel2).Location = new Point(5, 68);
    ((Control) this.ultraLabel2).Name = "ultraLabel2";
    ((Control) this.ultraLabel2).Size = new Size(60, 15);
    ((Control) this.ultraLabel2).TabIndex = 3;
    ((Control) this.ultraLabel2).Text = "Account #:";
    ((AppearanceBase) appearance3).TextHAlignAsString = "Left";
    ((AppearanceBase) appearance3).TextVAlignAsString = "Middle";
    ((ControlBase) this.ultraLabel3).Appearance = (AppearanceBase) appearance3;
    ((Control) this.ultraLabel3).Location = new Point(5, 0);
    ((Control) this.ultraLabel3).Name = "ultraLabel3";
    ((Control) this.ultraLabel3).Size = new Size(416, 36);
    ((Control) this.ultraLabel3).TabIndex = 4;
    ((Control) this.ultraLabel3).Text = "Use this form to assign a finance company and finance company account number to this policy.";
    ((AppearanceBase) appearance4).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance4).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance4).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance4).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance4).Image = componentResourceManager.GetObject("appearance4.Image");
    ((AppearanceBase) appearance4).ImageHAlign = (HAlign) 1;
    ((AppearanceBase) appearance4).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonCancel).Appearance = (AppearanceBase) appearance4;
    ((UltraButtonBase) this.buttonCancel).DialogResult = DialogResult.Cancel;
    ((Control) this.buttonCancel).Location = new Point(328, 106);
    ((Control) this.buttonCancel).Name = "buttonCancel";
    ((Control) this.buttonCancel).Size = new Size(91, 27);
    ((Control) this.buttonCancel).TabIndex = 5;
    ((Control) this.buttonCancel).Text = "&Cancel";
    ((UltraControlBase) this.buttonCancel).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.buttonCancel).Click += new EventHandler(this.buttonCancel_Click);
    ((AppearanceBase) appearance5).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance5).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance5).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance5).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance5).Image = componentResourceManager.GetObject("appearance5.Image");
    ((AppearanceBase) appearance5).ImageHAlign = (HAlign) 1;
    ((AppearanceBase) appearance5).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonSave).Appearance = (AppearanceBase) appearance5;
    ((Control) this.buttonSave).Location = new Point(231, 107);
    ((Control) this.buttonSave).Name = "buttonSave";
    ((Control) this.buttonSave).Size = new Size(91, 27);
    ((Control) this.buttonSave).TabIndex = 6;
    ((Control) this.buttonSave).Text = "&Save";
    ((UltraControlBase) this.buttonSave).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.buttonSave).Click += new EventHandler(this.buttonSave_Click);
    ((AppearanceBase) appearance6).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance6).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance6).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance6).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance6).Image = componentResourceManager.GetObject("appearance6.Image");
    ((AppearanceBase) appearance6).ImageHAlign = (HAlign) 2;
    ((AppearanceBase) appearance6).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonSearch).Appearance = (AppearanceBase) appearance6;
    ((Control) this.buttonSearch).Location = new Point(396, 41);
    ((Control) this.buttonSearch).Name = "buttonSearch";
    ((Control) this.buttonSearch).Size = new Size(21, 21);
    ((Control) this.buttonSearch).TabIndex = 7;
    ((UltraControlBase) this.buttonSearch).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.buttonSearch).Click += new EventHandler(this.buttonSearch_Click);
    ((AppearanceBase) appearance7).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance7).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance7).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance7).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance7).Image = (object) Resources.arrow_refresh;
    ((AppearanceBase) appearance7).ImageHAlign = (HAlign) 1;
    ((AppearanceBase) appearance7).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonClearFinanceCompany).Appearance = (AppearanceBase) appearance7;
    ((Control) this.buttonClearFinanceCompany).Location = new Point(5, 106);
    ((Control) this.buttonClearFinanceCompany).Name = "buttonClearFinanceCompany";
    ((Control) this.buttonClearFinanceCompany).Size = new Size(158, 27);
    ((Control) this.buttonClearFinanceCompany).TabIndex = 8;
    ((Control) this.buttonClearFinanceCompany).Text = "Clear Finance Company";
    ((UltraControlBase) this.buttonClearFinanceCompany).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.buttonClearFinanceCompany).Click += new EventHandler(this.buttonClearFinanceCompany_Click);
    this.AcceptButton = (IButtonControl) this.buttonSave;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.FromArgb(239, 247, 253);
    this.CancelButton = (IButtonControl) this.buttonCancel;
    this.ClientSize = new Size(429, 147);
    this.ControlBox = false;
    this.Controls.Add((Control) this.buttonClearFinanceCompany);
    this.Controls.Add((Control) this.buttonSearch);
    this.Controls.Add((Control) this.buttonSave);
    this.Controls.Add((Control) this.buttonCancel);
    this.Controls.Add((Control) this.ultraLabel3);
    this.Controls.Add((Control) this.ultraLabel2);
    this.Controls.Add((Control) this.ultraLabel1);
    this.Controls.Add((Control) this.textAccountNumber);
    this.Controls.Add((Control) this.textFinanceCompany);
    this.Font = new Font("Tahoma", 8.25f);
    this.ForeColor = Color.Black;
    this.FormBorderStyle = FormBorderStyle.FixedDialog;
    this.Name = nameof (formFinanceCompany);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Assign Finance Company";
    ((ISupportInitialize) this.textFinanceCompany).EndInit();
    ((ISupportInitialize) this.textAccountNumber).EndInit();
    ((ISupportInitialize) this.buttonCancel).EndInit();
    ((ISupportInitialize) this.buttonSave).EndInit();
    ((ISupportInitialize) this.buttonSearch).EndInit();
    ((ISupportInitialize) this.buttonClearFinanceCompany).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }
}
