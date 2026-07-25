// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Rating.FormAdrPasswordUpdate
// Assembly: MgaSystems.IMS.Rating, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 370B8F0A-FA1A-41D0-87BD-563CC23E9EA7
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Rating.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using MGASystems.Common;
using MGASystems.Common.adrconnect.mvrs.com.adrconnect1._2013._04;
using MGASystems.Data;
using MGASystems.IMS.Security;
using MGASystems.Tools;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Policies.Rating;

[DesignerGenerated]
[SecureResource("{89C20FA5-ADC9-4383-AF64-57DB5B17D996}", "Can Update ADR Password", "Controls the ability to update ADR Password.", "Policies")]
public class FormAdrPasswordUpdate : Form
{
  private IContainer components;
  private readonly Random _random;
  private bool _hasPassword;
  private bool _hasUserName;
  private bool _hasAccountID;
  private bool _usePasswordService;
  public const string CanUpdateADRPassword = "{89C20FA5-ADC9-4383-AF64-57DB5B17D996}";

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
    Appearance appearance1 = new Appearance();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (FormAdrPasswordUpdate));
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    this.btnUpdate = new MGAButton();
    this.txtAccountID = new MGATextBox();
    this.Label5 = new Label();
    this.Label1 = new Label();
    this.txtADRDocumentFolder = new MGATextBox();
    this.Label2 = new Label();
    this.txtOldPassword = new MGATextBox();
    this.Label3 = new Label();
    this.txtNewPassword = new MGATextBox();
    this.Label4 = new Label();
    this.txtUserName = new MGATextBox();
    this.lblInfo = new Label();
    this.err = new ErrorProvider(this.components);
    this.btnCancel = new Button();
    this.lnkGeneratePassword = new LinkLabel();
    ((ISupportInitialize) this.btnUpdate).BeginInit();
    ((ISupportInitialize) this.txtAccountID).BeginInit();
    ((ISupportInitialize) this.txtADRDocumentFolder).BeginInit();
    ((ISupportInitialize) this.txtOldPassword).BeginInit();
    ((ISupportInitialize) this.txtNewPassword).BeginInit();
    ((ISupportInitialize) this.txtUserName).BeginInit();
    ((ISupportInitialize) this.err).BeginInit();
    this.SuspendLayout();
    ((Control) this.btnUpdate).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance1.BackColor = Color.FromArgb(248, 248, 248);
    appearance1.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance1.BackGradientStyle = (GradientStyle) 2;
    appearance1.BorderColor = Color.DimGray;
    appearance1.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance7.Image"));
    appearance1.ImageHAlign = (HAlign) 3;
    appearance1.ImageVAlign = (VAlign) 2;
    ((AppearanceBase) appearance1).TextHAlignAsString = "Left";
    ((ControlBase) this.btnUpdate).Appearance = (AppearanceBase) appearance1;
    this.btnUpdate.ButtonStyle = (UIElementButtonStyle) 11;
    ((Control) this.btnUpdate).Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    ((Control) this.btnUpdate).Location = new Point(219, 304);
    ((Control) this.btnUpdate).Name = "btnUpdate";
    ((ControlBase) this.btnUpdate).Padding = new Size(5, 0);
    ((Control) this.btnUpdate).Size = new Size(143, 30);
    ((Control) this.btnUpdate).TabIndex = 7;
    ((ControlBase) this.btnUpdate).Text = "Update Password";
    this.btnUpdate.UseOSThemes = (DefaultableBoolean) 2;
    appearance2.BackColor = Color.White;
    appearance2.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance2.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtAccountID).Appearance = (AppearanceBase) appearance2;
    ((TextEditorControlBase) this.txtAccountID).BackColor = Color.White;
    ((Control) this.txtAccountID).Location = new Point(163, 44);
    this.txtAccountID.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtAccountID).Name = "txtAccountID";
    ((EditorButtonControlBase) this.txtAccountID).ReadOnly = true;
    ((Control) this.txtAccountID).Size = new Size(165, 19);
    ((Control) this.txtAccountID).TabIndex = 1;
    ((UltraControlBase) this.txtAccountID).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtAccountID).UseOsThemes = (DefaultableBoolean) 2;
    this.Label5.AutoSize = true;
    this.Label5.BackColor = Color.Transparent;
    this.Label5.Location = new Point(18, 47);
    this.Label5.Name = "Label5";
    this.Label5.Size = new Size(64 /*0x40*/, 13);
    this.Label5.TabIndex = 9;
    this.Label5.Text = "Account ID:";
    this.Label5.TextAlign = ContentAlignment.MiddleRight;
    this.Label1.AutoSize = true;
    this.Label1.BackColor = Color.Transparent;
    this.Label1.Location = new Point(18, 15);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(117, 13);
    this.Label1.TabIndex = 11;
    this.Label1.Text = "ADR Document Folder:";
    this.Label1.TextAlign = ContentAlignment.MiddleRight;
    appearance3.BackColor = Color.White;
    appearance3.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance3.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtADRDocumentFolder).Appearance = (AppearanceBase) appearance3;
    ((TextEditorControlBase) this.txtADRDocumentFolder).BackColor = Color.White;
    ((Control) this.txtADRDocumentFolder).Location = new Point(163, 12);
    this.txtADRDocumentFolder.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtADRDocumentFolder).Name = "txtADRDocumentFolder";
    ((EditorButtonControlBase) this.txtADRDocumentFolder).ReadOnly = true;
    ((Control) this.txtADRDocumentFolder).Size = new Size(165, 19);
    ((Control) this.txtADRDocumentFolder).TabIndex = 0;
    ((UltraControlBase) this.txtADRDocumentFolder).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtADRDocumentFolder).UseOsThemes = (DefaultableBoolean) 2;
    this.Label2.AutoSize = true;
    this.Label2.BackColor = Color.Transparent;
    this.Label2.Location = new Point(18, 111);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(93, 13);
    this.Label2.TabIndex = 13;
    this.Label2.Text = "Current Password:";
    this.Label2.TextAlign = ContentAlignment.MiddleRight;
    appearance4.BackColor = Color.White;
    appearance4.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance4.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtOldPassword).Appearance = (AppearanceBase) appearance4;
    ((TextEditorControlBase) this.txtOldPassword).BackColor = Color.White;
    ((Control) this.txtOldPassword).Location = new Point(163, 108);
    this.txtOldPassword.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtOldPassword).Name = "txtOldPassword";
    ((EditorButtonControlBase) this.txtOldPassword).ReadOnly = true;
    ((Control) this.txtOldPassword).Size = new Size(165, 19);
    ((Control) this.txtOldPassword).TabIndex = 3;
    ((UltraControlBase) this.txtOldPassword).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtOldPassword).UseOsThemes = (DefaultableBoolean) 2;
    this.Label3.AutoSize = true;
    this.Label3.BackColor = Color.Transparent;
    this.Label3.Location = new Point(18, 143);
    this.Label3.Name = "Label3";
    this.Label3.Size = new Size(81, 13);
    this.Label3.TabIndex = 17;
    this.Label3.Text = "New Password:";
    this.Label3.TextAlign = ContentAlignment.MiddleRight;
    appearance5.BackColor = Color.White;
    appearance5.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance5.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtNewPassword).Appearance = (AppearanceBase) appearance5;
    ((TextEditorControlBase) this.txtNewPassword).BackColor = Color.White;
    ((Control) this.txtNewPassword).Location = new Point(163, 140);
    this.txtNewPassword.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtNewPassword).Name = "txtNewPassword";
    ((Control) this.txtNewPassword).Size = new Size(165, 19);
    ((Control) this.txtNewPassword).TabIndex = 4;
    ((UltraControlBase) this.txtNewPassword).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtNewPassword).UseOsThemes = (DefaultableBoolean) 2;
    this.Label4.AutoSize = true;
    this.Label4.BackColor = Color.Transparent;
    this.Label4.Location = new Point(18, 79);
    this.Label4.Name = "Label4";
    this.Label4.Size = new Size(63 /*0x3F*/, 13);
    this.Label4.TabIndex = 19;
    this.Label4.Text = "User Name:";
    this.Label4.TextAlign = ContentAlignment.MiddleRight;
    appearance6.BackColor = Color.White;
    appearance6.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance6.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtUserName).Appearance = (AppearanceBase) appearance6;
    ((TextEditorControlBase) this.txtUserName).BackColor = Color.White;
    ((Control) this.txtUserName).Location = new Point(163, 76);
    this.txtUserName.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtUserName).Name = "txtUserName";
    ((EditorButtonControlBase) this.txtUserName).ReadOnly = true;
    ((Control) this.txtUserName).Size = new Size(165, 19);
    ((Control) this.txtUserName).TabIndex = 2;
    ((UltraControlBase) this.txtUserName).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtUserName).UseOsThemes = (DefaultableBoolean) 2;
    this.lblInfo.BackColor = Color.Transparent;
    this.lblInfo.Location = new Point(18, 181);
    this.lblInfo.Name = "lblInfo";
    this.lblInfo.Size = new Size(347, 92);
    this.lblInfo.TabIndex = 63 /*0x3F*/;
    this.lblInfo.Text = componentResourceManager.GetString("lblInfo.Text");
    this.err.ContainerControl = (ContainerControl) this;
    this.btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.btnCancel.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.btnCancel.Location = new Point(12, 308);
    this.btnCancel.Name = "btnCancel";
    this.btnCancel.Size = new Size(75, 30);
    this.btnCancel.TabIndex = 5;
    this.btnCancel.Text = "Cancel";
    this.btnCancel.UseVisualStyleBackColor = true;
    this.lnkGeneratePassword.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkGeneratePassword.AutoSize = true;
    this.lnkGeneratePassword.BackColor = Color.Transparent;
    this.lnkGeneratePassword.Location = new Point(102, 317);
    this.lnkGeneratePassword.Name = "lnkGeneratePassword";
    this.lnkGeneratePassword.Size = new Size(100, 13);
    this.lnkGeneratePassword.TabIndex = 6;
    this.lnkGeneratePassword.TabStop = true;
    this.lnkGeneratePassword.Text = "Generate Password";
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    this.ClientSize = new Size(374, 347);
    this.Controls.Add((Control) this.lnkGeneratePassword);
    this.Controls.Add((Control) this.btnCancel);
    this.Controls.Add((Control) this.lblInfo);
    this.Controls.Add((Control) this.Label4);
    this.Controls.Add((Control) this.txtUserName);
    this.Controls.Add((Control) this.Label3);
    this.Controls.Add((Control) this.txtNewPassword);
    this.Controls.Add((Control) this.Label2);
    this.Controls.Add((Control) this.txtOldPassword);
    this.Controls.Add((Control) this.Label1);
    this.Controls.Add((Control) this.txtADRDocumentFolder);
    this.Controls.Add((Control) this.Label5);
    this.Controls.Add((Control) this.txtAccountID);
    this.Controls.Add((Control) this.btnUpdate);
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (FormAdrPasswordUpdate);
    this.Text = "ADR Password Update";
    ((ISupportInitialize) this.btnUpdate).EndInit();
    ((ISupportInitialize) this.txtAccountID).EndInit();
    ((ISupportInitialize) this.txtADRDocumentFolder).EndInit();
    ((ISupportInitialize) this.txtOldPassword).EndInit();
    ((ISupportInitialize) this.txtNewPassword).EndInit();
    ((ISupportInitialize) this.txtUserName).EndInit();
    ((ISupportInitialize) this.err).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  private virtual MGAButton btnUpdate
  {
    get => this._btnUpdate;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnUpdate_Click);
      MGAButton btnUpdate1 = this._btnUpdate;
      if (btnUpdate1 != null)
        ((Control) btnUpdate1).Click -= eventHandler;
      this._btnUpdate = value;
      MGAButton btnUpdate2 = this._btnUpdate;
      if (btnUpdate2 == null)
        return;
      ((Control) btnUpdate2).Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("txtAccountID")]
  private virtual MGATextBox txtAccountID { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label5")]
  private virtual Label Label5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label1")]
  private virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtADRDocumentFolder")]
  private virtual MGATextBox txtADRDocumentFolder { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label2")]
  private virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtOldPassword")]
  private virtual MGATextBox txtOldPassword { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label3")]
  private virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtNewPassword")]
  private virtual MGATextBox txtNewPassword { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label4")]
  private virtual Label Label4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtUserName")]
  private virtual MGATextBox txtUserName { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblInfo")]
  private virtual Label lblInfo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("err")]
  internal virtual ErrorProvider err { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected virtual Button btnCancel
  {
    get => this._btnCancel;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnCancel_Click);
      Button btnCancel1 = this._btnCancel;
      if (btnCancel1 != null)
        btnCancel1.Click -= eventHandler;
      this._btnCancel = value;
      Button btnCancel2 = this._btnCancel;
      if (btnCancel2 == null)
        return;
      btnCancel2.Click += eventHandler;
    }
  }

  internal virtual LinkLabel lnkGeneratePassword
  {
    get => this._lnkGeneratePassword;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkGeneratePassword_LinkClicked);
      LinkLabel generatePassword1 = this._lnkGeneratePassword;
      if (generatePassword1 != null)
        generatePassword1.LinkClicked -= clickedEventHandler;
      this._lnkGeneratePassword = value;
      LinkLabel generatePassword2 = this._lnkGeneratePassword;
      if (generatePassword2 == null)
        return;
      generatePassword2.LinkClicked += clickedEventHandler;
    }
  }

  public Guid QuoteGuid { get; set; }

  public int ControlNo { get; set; }

  public FormAdrPasswordUpdate()
  {
    this.Load += new EventHandler(this.FormAdrPasswordUpdate_Load);
    this._random = new Random(Convert.ToInt32(DateTime.Now.Second));
    this._hasPassword = true;
    this._hasUserName = true;
    this._hasAccountID = true;
    this.InitializeComponent();
  }

  private void FormAdrPasswordUpdate_Load(object sender, EventArgs e)
  {
    this._usePasswordService = SystemSettings.KeyExists("ADR.UsePasswordService") && SystemSettings.GetBoolSetting("ADR.UsePasswordService");
    if (SystemSettings.KeyExists("ADRAccountID"))
      ((TextEditorControlBase) this.txtAccountID).Text = SystemSettings.GetStringSetting("ADRAccountID");
    else
      this._hasAccountID = false;
    if (SystemSettings.KeyExists("ADRUserName"))
      ((TextEditorControlBase) this.txtUserName).Text = SystemSettings.GetStringSetting("ADRUserName");
    else
      this._hasUserName = false;
    if (SystemSettings.KeyExists("ADRPassword"))
      ((TextEditorControlBase) this.txtOldPassword).Text = SystemSettings.GetStringSetting("ADRPassword");
    else
      this._hasPassword = false;
    if (SystemSettings.KeyExists("ADRDocumentFolderID"))
    {
      string str = DefaultDatabase.ExecuteScalar<string>(CommandType.Text, "SELECT FolderName FROM tblDocumentFolders WITH (NOLOCK) WHERE FolderID = @FID", new object[2]
      {
        (object) "@FID",
        (object) Convert.ToInt32(SystemSettings.GetNumericSetting("ADRDocumentFolderID"))
      });
      if (!Utility.IsNull((object) str))
        ((TextEditorControlBase) this.txtADRDocumentFolder).Text = str.ToString();
    }
    this.lnkGeneratePassword.Visible = this._usePasswordService;
    if (!this._usePasswordService)
      return;
    ((TextEditorControlBase) this.txtNewPassword).Text = this.GenerateNewCredentials();
  }

  private void btnUpdate_Click(object sender, EventArgs e)
  {
    if (!this.ValidCredentials())
      return;
    if (MessageBox.Show("You are about to update the IMS with the same ADR password used to generate MVRs.\n\nDo you wish to continue?", "Update IMS With ADR Password", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
      return;
    try
    {
      this.Cursor = MgaCursors.WaitCursor;
      if (!this.UpdatePasswordService())
        return;
      this.ChangeExpiredPassword();
      this.Cursor = MgaCursors.Default;
      int num = (int) MessageBox.Show($"{Interaction.IIf(!this._usePasswordService, (object) "Password updated successfully in the IMS", (object) "Password updated successfully via Samba and the IMS").ToString()}", "Password Updated Successfully", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
    finally
    {
      this.Cursor = MgaCursors.Default;
    }
  }

  private bool Vowelized(char c, string currString)
  {
    string str = currString + c.ToString();
    int num = 0;
    if (str.ToUpper().Contains("A"))
      ++num;
    if (str.ToUpper().Contains("E"))
      ++num;
    if (str.ToUpper().Contains("I"))
      ++num;
    if (str.ToUpper().Contains("O"))
      ++num;
    if (str.ToUpper().Contains("U"))
      ++num;
    return num > 1;
  }

  private string GenerateRandomString(bool usingOctogonInitialization)
  {
    StringBuilder stringBuilder = new StringBuilder();
    int num1 = 0;
    do
    {
      stringBuilder.Clear();
      int num2 = 0;
      int integer = Conversions.ToInteger(Interaction.IIf(usingOctogonInitialization, (object) 5, (object) 6));
      while (Strings.Len(stringBuilder.ToString()) < integer)
      {
        char c = Convert.ToChar(Convert.ToInt32(Math.Floor(26.0 * this._random.NextDouble() + 65.0)));
        if (!this.Vowelized(c, stringBuilder.ToString()))
        {
          char ch = num2 % 2 != 0 ? Conversions.ToChar(c.ToString().ToLower()) : Conversions.ToChar(c.ToString().ToUpper());
          stringBuilder.Append(ch);
        }
        ++num2;
      }
      if (!this.ValidPrefixSuffix(stringBuilder.ToString()))
        ++num1;
      else
        break;
    }
    while (num1 <= 50);
    return stringBuilder.ToString();
  }

  private bool ValidPrefixSuffix(string tmpRandNum)
  {
    return !tmpRandNum.Equals(((TextEditorControlBase) this.txtAccountID).Text) && !((TextEditorControlBase) this.txtAccountID).Text.Contains(tmpRandNum) && !tmpRandNum.Equals(((TextEditorControlBase) this.txtUserName).Text) && !((TextEditorControlBase) this.txtUserName).Text.Contains(tmpRandNum) && tmpRandNum.ToLower().ToString().Length == tmpRandNum.ToLower().Distinct<char>().Count<char>();
  }

  private string GenerateNumberString(bool usingOctogonLength)
  {
    string empty = string.Empty;
    int num1 = new int[101].Length - 1;
    for (int index = 0; index <= num1; ++index)
    {
      if (usingOctogonLength)
      {
        int num2 = this._random.Next(12, 99);
        if (this.ValidPrefixSuffix(num2.ToString()))
        {
          empty = num2.ToString();
          break;
        }
      }
      else
      {
        int num3 = this._random.Next(101, 999);
        if (this.ValidPrefixSuffix(num3.ToString()))
        {
          empty = num3.ToString();
          break;
        }
      }
    }
    return empty;
  }

  private string GenerateNewCredentials()
  {
    bool flag = this._random.Next(1, 11) % 2 != 0;
    string str1;
    string str2;
    if (flag)
    {
      str1 = this.GenerateNumberString(flag);
      str2 = this.GenerateRandomString(flag);
    }
    else
    {
      str1 = this.GenerateRandomString(flag);
      str2 = this.GenerateNumberString(flag);
    }
    int length = str1.Length;
    if (str2.Length > length)
      length = str2.Length;
    int num1 = this._random.Next(1, length - 1);
    if (flag)
      --num1;
    StringBuilder stringBuilder = new StringBuilder();
    int num2 = length - 1;
    for (int index = 0; index <= num2; ++index)
    {
      if (index == num1)
        stringBuilder.Append(this.GetSpecialCharacter());
      if (index < str2.Length)
        stringBuilder.Append(str2[index]);
      if (index < str1.Length)
        stringBuilder.Append(str1[index]);
    }
    return stringBuilder.ToString();
  }

  private string GetSpecialCharacter()
  {
    return new List<string>() { ".", "!", "@" }[this._random.Next(0, 3)];
  }

  private void ChangeExpiredPassword()
  {
    DefaultDatabase.ExecuteNonQuery(CommandType.Text, "UPDATE tblSystemSettings SET SettingValueString = @PW WHERE Setting = @Setting", new object[4]
    {
      (object) "@PW",
      (object) ((TextEditorControlBase) this.txtNewPassword).Text,
      (object) "@Setting",
      (object) "ADRPassword"
    });
    CurrentUser.Instance.LogAction($"Change ADR password from {((TextEditorControlBase) this.txtOldPassword).Text} to {((TextEditorControlBase) this.txtNewPassword).Text}", this.QuoteGuid);
    this.Cursor = MgaCursors.Default;
    int num = (int) MessageBox.Show("Password has been updated successfully.\n\nPlease retry ordering MVRs.", "Password Changed", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    this.Close();
  }

  private bool ValidCredentials()
  {
    this.err.SetError((Control) this.txtADRDocumentFolder, string.Empty);
    this.err.SetError((Control) this.txtAccountID, string.Empty);
    this.err.SetError((Control) this.txtUserName, string.Empty);
    this.err.SetError((Control) this.txtOldPassword, string.Empty);
    this.err.SetError((Control) this.txtNewPassword, string.Empty);
    bool flag;
    if (!SecurityManager.Instance.AssertPermission("{89C20FA5-ADC9-4383-AF64-57DB5B17D996}"))
    {
      int num = (int) MessageBox.Show("You do not have the required security to auto-generate and update ADR password.", "In-sufficient Security", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      flag = false;
    }
    else if (!this._hasUserName)
    {
      int num = (int) MessageBox.Show("ADR 'User Name' credential is missing.\n\nPlease obtain an ADR user name to use in the IMS", "Missing UserName ADR Credentials", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      flag = false;
    }
    else if (!this._hasPassword)
    {
      int num = (int) MessageBox.Show("ADR 'Password' credential is missing.\n\nPlease obtain an ADR password to use in the IMS", "Missing Password ADR Credentials", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      flag = false;
    }
    else if (!this._hasAccountID)
    {
      int num = (int) MessageBox.Show("ADR 'Account ID' is missing.\n\nPlease obtain an ADR Account ID to use in the IMS", "Missing Account ID", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      flag = false;
    }
    else if (string.IsNullOrEmpty(((TextEditorControlBase) this.txtNewPassword).Text) || ((TextEditorControlBase) this.txtNewPassword).Text.Replace(" ", string.Empty).Length == 0)
    {
      this.err.SetError((Control) this.txtNewPassword, "Please enter a value");
      flag = false;
    }
    else if (string.IsNullOrEmpty(((TextEditorControlBase) this.txtUserName).Text) || ((TextEditorControlBase) this.txtUserName).Text.Replace(" ", string.Empty).Length == 0)
    {
      this.err.SetError((Control) this.txtUserName, "Please enter a value");
      flag = false;
    }
    else
      flag = true;
    return flag;
  }

  private void btnCancel_Click(object sender, EventArgs e) => this.Close();

  private void lnkGeneratePassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    ((TextEditorControlBase) this.txtNewPassword).Text = this.GenerateNewCredentials();
  }

  private bool UpdatePasswordService()
  {
    bool flag1;
    if (!this._usePasswordService)
    {
      flag1 = true;
    }
    else
    {
      string str = string.Empty;
      bool flag2;
      try
      {
        using (AdrConnectWebServiceClient webServiceClient = new AdrConnectWebServiceClient("BasicHttpBinding_IAdrConnectWebService"))
        {
          ChangePasswordResponseEntity passwordResponseEntity = webServiceClient.ChangePassword(((TextEditorControlBase) this.txtAccountID).Text, ((TextEditorControlBase) this.txtUserName).Text, ((TextEditorControlBase) this.txtOldPassword).Text, ((TextEditorControlBase) this.txtNewPassword).Text);
          if (passwordResponseEntity.CallValidation.ErrorId == 0)
          {
            flag2 = true;
          }
          else
          {
            flag2 = false;
            if (passwordResponseEntity.CallValidation != null)
              str = passwordResponseEntity.CallValidation.ErrorDescription;
          }
          webServiceClient.Close();
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        flag2 = false;
        str = $"{Environment.NewLine}{Environment.NewLine}{exception.Message}";
        ProjectData.ClearProjectError();
      }
      if (!flag2)
      {
        this.Cursor = MgaCursors.Default;
        int num = (int) MessageBox.Show($"Password has NOT been updated because of the following reason(s) - {str}", "Error Updating Password", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      }
      flag1 = flag2;
    }
    return flag1;
  }
}
