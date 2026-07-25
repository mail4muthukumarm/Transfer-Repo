// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.frmNetRateUpdateXML
// Assembly: MgaSystems.IMS.Policies, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 2FF2C709-F7BF-41DA-82BD-FF6319CA235D
// Assembly location: C:\Users\muthu\Downloads\MgaSystems.IMS.Policies.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using MGASystems.Data;
using MGASystems.Tools;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml;

#nullable disable
namespace MGASystems.IMS.Policies;

[DesignerGenerated]
public class frmNetRateUpdateXML : Form
{
  private IContainer components;
  private int _ControlNo;
  private bool _UpdatePolicyXML;
  private XmlDocument _NewAccountXML;
  private int _quoteId;

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
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    this.lblNetRateUnitNumber = new Label();
    this.lblNetRateControlNo = new MGATextBox();
    this.Label1 = new Label();
    this.btnSave = new MGAButton();
    this.btnHelp = new MGAButton();
    ((ISupportInitialize) this.lblNetRateControlNo).BeginInit();
    ((ISupportInitialize) this.btnSave).BeginInit();
    ((ISupportInitialize) this.btnHelp).BeginInit();
    this.SuspendLayout();
    this.lblNetRateUnitNumber.AutoSize = true;
    this.lblNetRateUnitNumber.Location = new Point(21, 9);
    this.lblNetRateUnitNumber.Name = "lblNetRateUnitNumber";
    this.lblNetRateUnitNumber.Size = new Size(220, 13);
    this.lblNetRateUnitNumber.TabIndex = 10;
    this.lblNetRateUnitNumber.Text = "Existing Control Number to Copy Data From:";
    this.lblNetRateUnitNumber.TextAlign = ContentAlignment.MiddleRight;
    appearance1.BackColor = Color.White;
    appearance1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance1.ForeColor = Color.Black;
    ((TextEditorControlBase) this.lblNetRateControlNo).Appearance = (AppearanceBase) appearance1;
    ((TextEditorControlBase) this.lblNetRateControlNo).BackColor = Color.White;
    ((Control) this.lblNetRateControlNo).Location = new Point(24, 38);
    this.lblNetRateControlNo.MGAStyle = (MGAStyles) 2;
    ((Control) this.lblNetRateControlNo).Name = "lblNetRateControlNo";
    ((Control) this.lblNetRateControlNo).Size = new Size(107, 20);
    ((Control) this.lblNetRateControlNo).TabIndex = 13;
    ((UltraControlBase) this.lblNetRateControlNo).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.lblNetRateControlNo).UseOsThemes = (DefaultableBoolean) 2;
    this.Label1.AutoSize = true;
    this.Label1.Location = new Point(21, 18);
    this.Label1.MaximumSize = new Size(350, 100);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(0, 13);
    this.Label1.TabIndex = 14;
    appearance2.BackColor = Color.FromArgb(248, 248, 248);
    appearance2.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance2.BackGradientStyle = (GradientStyle) 2;
    appearance2.BorderColor = Color.DarkGray;
    appearance2.ImageHAlign = (HAlign) 2;
    appearance2.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnSave).Appearance = (AppearanceBase) appearance2;
    ((ControlBase) this.btnSave).ImageSize = new Size(24, 24);
    ((ControlBase) this.btnSave).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnSave).Location = new Point((int) byte.MaxValue, 18);
    ((Control) this.btnSave).Name = "btnSave";
    ((Control) this.btnSave).Size = new Size(40, 40);
    ((Control) this.btnSave).TabIndex = 15;
    this.btnSave.UseOSThemes = (DefaultableBoolean) 2;
    appearance3.BackColor = Color.FromArgb(248, 248, 248);
    appearance3.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance3.BackGradientStyle = (GradientStyle) 2;
    appearance3.BorderColor = Color.DarkGray;
    appearance3.ImageHAlign = (HAlign) 2;
    appearance3.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnHelp).Appearance = (AppearanceBase) appearance3;
    ((ControlBase) this.btnHelp).ImageSize = new Size(24, 24);
    ((ControlBase) this.btnHelp).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnHelp).Location = new Point(312, 18);
    ((Control) this.btnHelp).Name = "btnHelp";
    ((Control) this.btnHelp).Size = new Size(40, 40);
    ((Control) this.btnHelp).TabIndex = 16 /*0x10*/;
    this.btnHelp.UseOSThemes = (DefaultableBoolean) 2;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    this.ClientSize = new Size(367, 78);
    this.Controls.Add((Control) this.btnHelp);
    this.Controls.Add((Control) this.btnSave);
    this.Controls.Add((Control) this.Label1);
    this.Controls.Add((Control) this.lblNetRateControlNo);
    this.Controls.Add((Control) this.lblNetRateUnitNumber);
    this.Font = new Font("Tahoma", 8.25f);
    this.ForeColor = Color.Black;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmNetRateUpdateXML);
    this.Text = "Update Policy with Existing NetRate Account";
    ((ISupportInitialize) this.lblNetRateControlNo).EndInit();
    ((ISupportInitialize) this.btnSave).EndInit();
    ((ISupportInitialize) this.btnHelp).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  [field: AccessedThroughProperty("lblNetRateUnitNumber")]
  private virtual Label lblNetRateUnitNumber { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual MGATextBox lblNetRateControlNo
  {
    get => this._lblNetRateControlNo;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.lblNetRateQuoteId_ValueChanged);
      MGATextBox netRateControlNo1 = this._lblNetRateControlNo;
      if (netRateControlNo1 != null)
        ((TextEditorControlBase) netRateControlNo1).ValueChanged -= eventHandler;
      this._lblNetRateControlNo = value;
      MGATextBox netRateControlNo2 = this._lblNetRateControlNo;
      if (netRateControlNo2 == null)
        return;
      ((TextEditorControlBase) netRateControlNo2).ValueChanged += eventHandler;
    }
  }

  [field: AccessedThroughProperty("Label1")]
  internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual MGAButton btnSave
  {
    get => this._btnSave;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnSave_Click);
      MGAButton btnSave1 = this._btnSave;
      if (btnSave1 != null)
        ((Control) btnSave1).Click -= eventHandler;
      this._btnSave = value;
      MGAButton btnSave2 = this._btnSave;
      if (btnSave2 == null)
        return;
      ((Control) btnSave2).Click += eventHandler;
    }
  }

  private virtual MGAButton btnHelp
  {
    get => this._btnHelp;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnHelp_Click);
      MGAButton btnHelp1 = this._btnHelp;
      if (btnHelp1 != null)
        ((Control) btnHelp1).Click -= eventHandler;
      this._btnHelp = value;
      MGAButton btnHelp2 = this._btnHelp;
      if (btnHelp2 == null)
        return;
      ((Control) btnHelp2).Click += eventHandler;
    }
  }

  public int ControlnoToUpdate => this._ControlNo;

  public XmlDocument GetNewAccountXML => this._NewAccountXML;

  public bool UpdatePolicyXML => this._UpdatePolicyXML;

  public int ControlNo => this._ControlNo;

  public frmNetRateUpdateXML()
  {
    this.Load += new EventHandler(this.frmNetRateReconnectData_Load);
    this._UpdatePolicyXML = false;
    this._NewAccountXML = new XmlDocument();
    this.InitializeComponent();
  }

  public frmNetRateUpdateXML(int quoteId)
  {
    this.Load += new EventHandler(this.frmNetRateReconnectData_Load);
    this._UpdatePolicyXML = false;
    this._NewAccountXML = new XmlDocument();
    this.InitializeComponent();
    this._quoteId = quoteId;
  }

  private void frmNetRateReconnectData_Load(object sender, EventArgs e)
  {
    ImageCache instance = ImageCache.Instance;
    ((ControlBase) this.btnSave).Appearance.Image = (object) instance.Save;
    ((ControlBase) this.btnHelp).Appearance.Image = (object) instance.Help;
  }

  private bool checkQuoteIdValidity(string QuoteId) => !new Regex("[a-zA-Z]").IsMatch(QuoteId);

  private void btnSave_Click(object sender, EventArgs e)
  {
    bool flag1 = true;
    bool flag2 = true;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((TextEditorControlBase) this.lblNetRateControlNo).Text, "", false) != 0)
    {
      if (this.checkQuoteIdValidity(((TextEditorControlBase) this.lblNetRateControlNo).Text))
      {
        if (!Utility.IsNull((object) DefaultDatabase.ExecuteScalar<string>(CommandType.Text, "SELECT NetRateXml FROM dbo.tblquotes WHERE QuoteID = @QuoteID", new object[2]
        {
          (object) "@QuoteID",
          (object) this._quoteId
        })) && MessageBox.Show("There is already netrate data associated with this policy. Are you sure you want to override it?", "Existing NetRate Data found", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation).Equals((object) DialogResult.No))
          flag1 = false;
        if (flag1)
        {
          string xml = DefaultDatabase.ExecuteScalar<string>(CommandType.Text, "SELECT NetRateXml FROM dbo.tblQuotes Where ControlNo = @ControlNo AND OriginalQuoteGuid IS NULL", new object[2]
          {
            (object) "@ControlNo",
            (object) ((TextEditorControlBase) this.lblNetRateControlNo).Text
          });
          if (!Utility.IsNull((object) xml))
          {
            if (!string.IsNullOrEmpty(xml))
            {
              this._NewAccountXML.LoadXml(xml);
              this._UpdatePolicyXML = true;
              this._ControlNo = int.Parse(((TextEditorControlBase) this.lblNetRateControlNo).Text);
              this.Close();
            }
            else
            {
              flag2 = false;
              int num = (int) MessageBox.Show("The Control Number entered is not linked to a netrate account. Please enter a valid control number.");
            }
          }
          if (!this._UpdatePolicyXML)
          {
            flag2 = false;
            int num = (int) MessageBox.Show("The control number you entered could not be used. If this is a valid control number with an associated netrate account please email techsupport@mgasystems.com with the control number for additional information.");
          }
        }
      }
      else
      {
        flag2 = false;
        int num = (int) MessageBox.Show("Please enter a valid Control Number.");
      }
    }
    else
    {
      flag2 = false;
      int num = (int) MessageBox.Show("Please enter a valid Control Number.");
    }
    if (!flag2)
      return;
    this.Close();
  }

  private void btnHelp_Click(object sender, EventArgs e)
  {
    int num = (int) MessageBox.Show("This form will allow the user to copy over netrate data from an existing netrate account. This may be useful when the user is creating a new netrate policy and can save time entering data by referencing an existing netrate policy. \r\rThe netrate data copied will be from the original transaction of the inputted control number. The control number entered must have netrate data that has been successfully returned to the IMS. Upon clicking the save button the netrate app will be opened with the data from the inputted control number. Once opened the user may have to correct any information that does not match the policy created. Failure to do so will prompt an error message when trying to bind the policy. \r\rNOTE: If you do not see the NetRate application open check the taskbar located at the bottom of your screen. If it is not there you might have to wait several minutes for it to open. If it still does not open or you receive an error(s) anytime  during this process please email techsupport@mgasystems.com with the control number and the information from the error  message(s) if one was received.", "HELP INFORMATION - Netrate Transfer Data from Existing Policy", MessageBoxButtons.OK, MessageBoxIcon.Question);
  }

  private void lblNetRateQuoteId_ValueChanged(object sender, EventArgs e)
  {
  }
}
