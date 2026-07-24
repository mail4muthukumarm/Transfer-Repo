// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Claims.Claims.FormTest
// Assembly: MgaSystems.IMS.Claims, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FCD9D0B7-28CF-40B9-8EB7-297871E1AF5F
// Assembly location: F:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims.dll

using MGASystems.AddressResolver;
using MGASystems.IMS.Forms;
using MGASystems.Tools;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Claims.Claims;

[TestForm]
public class FormTest : Form
{
  private IContainer components;
  private AddressResolver_MULTI addressResolver_MULTI1;
  private AddressResolver_MULTI ar2;
  private Button button1;
  private TextBox textBox1;

  public FormTest() => this.InitializeComponent();

  private void button1_Click(object sender, EventArgs e) => this.textBox1.Text = this.ar2.ZipCode;

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    this.addressResolver_MULTI1 = new AddressResolver_MULTI();
    this.ar2 = new AddressResolver_MULTI();
    this.button1 = new Button();
    this.textBox1 = new TextBox();
    this.SuspendLayout();
    this.addressResolver_MULTI1.Address1 = "";
    this.addressResolver_MULTI1.Address2 = "";
    this.addressResolver_MULTI1.City = "";
    this.addressResolver_MULTI1.County = "";
    ((Control) this.addressResolver_MULTI1).Font = new Font("Tahoma", 8f);
    this.addressResolver_MULTI1.ISOCountryCode = "";
    this.addressResolver_MULTI1.ISOCountryCodeMember = "";
    this.addressResolver_MULTI1.ISOCountryList = (object) null;
    this.addressResolver_MULTI1.ISOCountryNameMember = "";
    ((Control) this.addressResolver_MULTI1).Location = new Point(64 /*0x40*/, 35);
    this.addressResolver_MULTI1.MGAStyle = (MGAStyles) 0;
    ((Control) this.addressResolver_MULTI1).Name = "addressResolver_MULTI1";
    this.addressResolver_MULTI1.Password = (string) null;
    ((Control) this.addressResolver_MULTI1).Size = new Size(240 /*0xF0*/, 152);
    this.addressResolver_MULTI1.State = "";
    ((Control) this.addressResolver_MULTI1).TabIndex = 0;
    this.addressResolver_MULTI1.UserID = (string) null;
    this.addressResolver_MULTI1.WebserviceUrl = (string) null;
    this.addressResolver_MULTI1.ZipCode = "";
    this.addressResolver_MULTI1.ZipCodeExtension = "";
    this.ar2.Address1 = "";
    this.ar2.Address2 = "";
    this.ar2.City = "";
    this.ar2.County = "";
    ((Control) this.ar2).Font = new Font("Tahoma", 8f);
    this.ar2.ISOCountryCode = "";
    this.ar2.ISOCountryCodeMember = "";
    this.ar2.ISOCountryList = (object) null;
    this.ar2.ISOCountryNameMember = "";
    ((Control) this.ar2).Location = new Point(25, 23);
    this.ar2.MGAStyle = (MGAStyles) 0;
    ((Control) this.ar2).Name = "ar2";
    this.ar2.Password = (string) null;
    ((Control) this.ar2).Size = new Size(240 /*0xF0*/, 152);
    this.ar2.State = "";
    ((Control) this.ar2).TabIndex = 1;
    this.ar2.UserID = (string) null;
    this.ar2.WebserviceUrl = (string) null;
    this.ar2.ZipCode = "";
    this.ar2.ZipCodeExtension = "";
    this.button1.Location = new Point(368, 32 /*0x20*/);
    this.button1.Name = "button1";
    this.button1.Size = new Size(75, 23);
    this.button1.TabIndex = 2;
    this.button1.Text = "button1";
    this.button1.UseVisualStyleBackColor = true;
    this.button1.Click += new EventHandler(this.button1_Click);
    this.textBox1.Location = new Point(368, 87);
    this.textBox1.Name = "textBox1";
    this.textBox1.Size = new Size(100, 20);
    this.textBox1.TabIndex = 3;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(800, 450);
    this.Controls.Add((Control) this.textBox1);
    this.Controls.Add((Control) this.button1);
    this.Controls.Add((Control) this.ar2);
    this.Name = nameof (FormTest);
    this.Text = nameof (FormTest);
    this.ResumeLayout(false);
    this.PerformLayout();
  }
}
