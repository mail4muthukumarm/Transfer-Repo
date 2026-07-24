// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Claims.Claims.testForm
// Assembly: MgaSystems.IMS.Claims, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FCD9D0B7-28CF-40B9-8EB7-297871E1AF5F
// Assembly location: F:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims.dll

using MGASystems.IMS.Forms;
using MGASystems.Tools;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Claims.Claims;

[TestForm]
public class testForm : Form
{
  private IContainer components;
  private Label labelCountryCode;
  private Button button1;
  private Label labelPhoneNumber;
  private MGAInternationalPhoneNumberEditor mgaInternationalPhoneNumberEditor1;

  public testForm() => this.InitializeComponent();

  private void button1_Click(object sender, EventArgs e)
  {
    this.labelPhoneNumber.Text = this.mgaInternationalPhoneNumberEditor1.ValueString;
    this.labelCountryCode.Text = this.mgaInternationalPhoneNumberEditor1.CountryCode;
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (testForm));
    this.labelCountryCode = new Label();
    this.button1 = new Button();
    this.labelPhoneNumber = new Label();
    this.mgaInternationalPhoneNumberEditor1 = new MGAInternationalPhoneNumberEditor();
    this.SuspendLayout();
    this.labelCountryCode.AutoSize = true;
    this.labelCountryCode.Location = new Point(25, 41);
    this.labelCountryCode.Name = "labelCountryCode";
    this.labelCountryCode.Size = new Size(35, 13);
    this.labelCountryCode.TabIndex = 1;
    this.labelCountryCode.Text = "label1";
    this.button1.Location = new Point(152, 13);
    this.button1.Name = "button1";
    this.button1.Size = new Size(75, 23);
    this.button1.TabIndex = 2;
    this.button1.Text = "button1";
    this.button1.UseVisualStyleBackColor = true;
    this.button1.Click += new EventHandler(this.button1_Click);
    this.labelPhoneNumber.AutoSize = true;
    this.labelPhoneNumber.Location = new Point(25, 64 /*0x40*/);
    this.labelPhoneNumber.Name = "labelPhoneNumber";
    this.labelPhoneNumber.Size = new Size(35, 13);
    this.labelPhoneNumber.TabIndex = 3;
    this.labelPhoneNumber.Text = "label1";
    this.mgaInternationalPhoneNumberEditor1.CountryCode = "";
    ((Control) this.mgaInternationalPhoneNumberEditor1).Location = new Point(28, 13);
    this.mgaInternationalPhoneNumberEditor1.MGAStyle = (MGAStyles) 1;
    ((Control) this.mgaInternationalPhoneNumberEditor1).Name = "mgaInternationalPhoneNumberEditor1";
    ((Control) this.mgaInternationalPhoneNumberEditor1).Size = new Size(118, 21);
    ((Control) this.mgaInternationalPhoneNumberEditor1).TabIndex = 4;
    this.mgaInternationalPhoneNumberEditor1.Value = componentResourceManager.GetObject("mgaInternationalPhoneNumberEditor1.Value");
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(800, 450);
    this.Controls.Add((Control) this.mgaInternationalPhoneNumberEditor1);
    this.Controls.Add((Control) this.labelPhoneNumber);
    this.Controls.Add((Control) this.button1);
    this.Controls.Add((Control) this.labelCountryCode);
    this.Name = nameof (testForm);
    this.Text = nameof (testForm);
    this.ResumeLayout(false);
    this.PerformLayout();
  }
}
