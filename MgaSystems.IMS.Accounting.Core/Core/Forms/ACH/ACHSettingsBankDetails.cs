// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Core.Forms.ACH.ACHSettingsBankDetails
// Assembly: MgaSystems.IMS.Accounting.Core, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 923053EF-B70A-44B5-B8DA-B227263F4FD2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Core.dll

using Infragistics.Win;
using Infragistics.Win.UltraWinEditors;
using MGASystems.AddressResolver;
using MGASystems.Tools;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Core.Forms.ACH;

public class ACHSettingsBankDetails : UserControl
{
  private IContainer components;
  public MGATextBox bankName;
  public MGATextBox swiftCode;
  public AddressResolver_MULTI bankAddress;
  private Label swiftCodeLabel;
  private Label bankNameLabel;
  private Label bankId;
  public MGATextBox sortCode;
  private Label sortCodeLabel;

  public int? BankId
  {
    get
    {
      return !string.IsNullOrEmpty(this.bankId.Text) ? new int?(Convert.ToInt32(this.bankId.Text)) : new int?();
    }
    set => this.bankId.Text = value.HasValue ? value.ToString() : string.Empty;
  }

  public string BankName
  {
    get => ACHSettingsBankDetails.GetValueOrNull(((Control) this.bankName).Text, 300);
    set => ((Control) this.bankName).Text = value;
  }

  public string IsoCountryCode
  {
    get => ACHSettingsBankDetails.GetValueOrNull(this.bankAddress.ISOCountryCode, 10);
    set => this.bankAddress.ISOCountryCode = value;
  }

  public string Address1
  {
    get => ACHSettingsBankDetails.GetValueOrNull(this.bankAddress.Address1, 100);
    set => this.bankAddress.Address1 = value;
  }

  public string Address2
  {
    get => ACHSettingsBankDetails.GetValueOrNull(this.bankAddress.Address2, 100);
    set => this.bankAddress.Address2 = value;
  }

  public string City
  {
    get => ACHSettingsBankDetails.GetValueOrNull(this.bankAddress.City, 150);
    set => this.bankAddress.City = value;
  }

  public string State
  {
    get => ACHSettingsBankDetails.GetValueOrNull(this.bankAddress.State, 20);
    set => this.bankAddress.State = value;
  }

  public string ZipCode
  {
    get => ACHSettingsBankDetails.GetValueOrNull(this.bankAddress.ZipCode, 20);
    set => this.bankAddress.ZipCode = value;
  }

  public string ZipCodeExtension
  {
    get => ACHSettingsBankDetails.GetValueOrNull(this.bankAddress.ZipCodeExtension, 10);
    set => this.bankAddress.ZipCodeExtension = value;
  }

  public string SwiftCode
  {
    get => ACHSettingsBankDetails.GetValueOrNull(((Control) this.swiftCode).Text, 100);
    set => ((Control) this.swiftCode).Text = value;
  }

  public string SortCode
  {
    get => ACHSettingsBankDetails.GetValueOrNull(((Control) this.sortCode).Text, 50);
    set => ((Control) this.sortCode).Text = value;
  }

  public ACHSettingsBankDetails() => this.InitializeComponent();

  private static string GetValueOrNull(string value, int maxLength)
  {
    return !string.IsNullOrWhiteSpace(value) ? value.Truncate(maxLength) : (string) null;
  }

  private void swiftCode_ValueChanged(object sender, EventArgs e)
  {
    if (this.swiftCode.PasswordChar == char.MinValue)
      return;
    ((Control) this.swiftCode).Text = string.Empty;
    this.swiftCode.PasswordChar = char.MinValue;
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
    this.bankName = new MGATextBox();
    this.swiftCode = new MGATextBox();
    this.bankAddress = new AddressResolver_MULTI();
    this.swiftCodeLabel = new Label();
    this.bankNameLabel = new Label();
    this.bankId = new Label();
    this.sortCode = new MGATextBox();
    this.sortCodeLabel = new Label();
    ((ISupportInitialize) this.bankName).BeginInit();
    ((ISupportInitialize) this.swiftCode).BeginInit();
    ((ISupportInitialize) this.sortCode).BeginInit();
    this.SuspendLayout();
    ((AppearanceBase) appearance1).BackColor = Color.White;
    ((AppearanceBase) appearance1).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance1).ForeColor = Color.Black;
    ((TextEditorControlBase) this.bankName).Appearance = (AppearanceBase) appearance1;
    ((Control) this.bankName).BackColor = Color.White;
    ((Control) this.bankName).Location = new Point(108, 5);
    ((TextEditorControlBase) this.bankName).MaxLength = 300;
    this.bankName.MGAStyle = MGAStyles.Blue;
    ((Control) this.bankName).Name = "bankName";
    ((Control) this.bankName).Size = new Size(360, 20);
    ((Control) this.bankName).TabIndex = 1;
    ((UltraControlBase) this.bankName).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.bankName).UseOsThemes = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance2).BackColor = Color.White;
    ((AppearanceBase) appearance2).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance2).ForeColor = Color.Black;
    ((TextEditorControlBase) this.swiftCode).Appearance = (AppearanceBase) appearance2;
    ((Control) this.swiftCode).BackColor = Color.White;
    ((Control) this.swiftCode).Location = new Point(108, 30);
    ((TextEditorControlBase) this.swiftCode).MaxLength = 20;
    this.swiftCode.MGAStyle = MGAStyles.Blue;
    ((Control) this.swiftCode).Name = "swiftCode";
    ((Control) this.swiftCode).Size = new Size(360, 20);
    ((Control) this.swiftCode).TabIndex = 2;
    ((UltraControlBase) this.swiftCode).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.swiftCode).UseOsThemes = (DefaultableBoolean) 2;
    ((TextEditorControlBase) this.swiftCode).ValueChanged += new EventHandler(this.swiftCode_ValueChanged);
    this.bankAddress.Address1 = "";
    this.bankAddress.Address2 = "";
    ((Control) this.bankAddress).BackColor = Color.Transparent;
    this.bankAddress.City = "";
    this.bankAddress.County = "";
    ((Control) this.bankAddress).Font = new Font("Tahoma", 8f);
    this.bankAddress.ISOCountryCode = "";
    this.bankAddress.ISOCountryCodeMember = "";
    this.bankAddress.ISOCountryList = (object) null;
    this.bankAddress.ISOCountryNameMember = "";
    ((Control) this.bankAddress).Location = new Point(-1, 72);
    this.bankAddress.MGAStyle = MGAStyles.Blue;
    ((Control) this.bankAddress).Name = "bankAddress";
    this.bankAddress.Password = (string) null;
    ((Control) this.bankAddress).Size = new Size(477, 152);
    this.bankAddress.State = "";
    ((Control) this.bankAddress).TabIndex = 4;
    this.bankAddress.TextAlign = ContentAlignment.TopLeft;
    this.bankAddress.UserID = (string) null;
    this.bankAddress.WebserviceUrl = (string) null;
    this.bankAddress.ZipCode = "";
    this.bankAddress.ZipCodeExtension = "";
    this.swiftCodeLabel.AutoSize = true;
    this.swiftCodeLabel.BackColor = Color.Transparent;
    this.swiftCodeLabel.Location = new Point(6, 30);
    this.swiftCodeLabel.Name = "swiftCodeLabel";
    this.swiftCodeLabel.Size = new Size(71, 13);
    this.swiftCodeLabel.TabIndex = 42;
    this.swiftCodeLabel.Text = "SWIFT Code:";
    this.bankNameLabel.AutoSize = true;
    this.bankNameLabel.BackColor = Color.Transparent;
    this.bankNameLabel.Location = new Point(6, 5);
    this.bankNameLabel.Name = "bankNameLabel";
    this.bankNameLabel.Size = new Size(64 /*0x40*/, 13);
    this.bankNameLabel.TabIndex = 40;
    this.bankNameLabel.Text = "Bank Name:";
    this.bankId.AutoSize = true;
    this.bankId.Location = new Point(4, 182);
    this.bankId.Name = "bankId";
    this.bankId.Size = new Size(0, 13);
    this.bankId.TabIndex = 45;
    this.bankId.Visible = false;
    ((AppearanceBase) appearance3).BackColor = Color.White;
    ((AppearanceBase) appearance3).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance3).ForeColor = Color.Black;
    ((TextEditorControlBase) this.sortCode).Appearance = (AppearanceBase) appearance3;
    ((Control) this.sortCode).BackColor = Color.White;
    ((Control) this.sortCode).Location = new Point(108, 55);
    ((TextEditorControlBase) this.sortCode).MaxLength = 10;
    this.sortCode.MGAStyle = MGAStyles.Blue;
    ((Control) this.sortCode).Name = "sortCode";
    ((Control) this.sortCode).Size = new Size(360, 20);
    ((Control) this.sortCode).TabIndex = 3;
    ((UltraControlBase) this.sortCode).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.sortCode).UseOsThemes = (DefaultableBoolean) 2;
    this.sortCodeLabel.AutoSize = true;
    this.sortCodeLabel.BackColor = Color.Transparent;
    this.sortCodeLabel.Location = new Point(6, 55);
    this.sortCodeLabel.Name = "sortCodeLabel";
    this.sortCodeLabel.Size = new Size(59, 13);
    this.sortCodeLabel.TabIndex = 47;
    this.sortCodeLabel.Text = "Sort Code:";
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.Transparent;
    this.Controls.Add((Control) this.sortCode);
    this.Controls.Add((Control) this.sortCodeLabel);
    this.Controls.Add((Control) this.bankId);
    this.Controls.Add((Control) this.bankName);
    this.Controls.Add((Control) this.swiftCode);
    this.Controls.Add((Control) this.bankAddress);
    this.Controls.Add((Control) this.swiftCodeLabel);
    this.Controls.Add((Control) this.bankNameLabel);
    this.Font = new Font("Tahoma", 8.25f);
    this.Name = nameof (ACHSettingsBankDetails);
    this.Size = new Size(474, 231);
    ((ISupportInitialize) this.bankName).EndInit();
    ((ISupportInitialize) this.swiftCode).EndInit();
    ((ISupportInitialize) this.sortCode).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }
}
