// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.frmNetRateReconnectData
// Assembly: MgaSystems.IMS.Policies, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 2FF2C709-F7BF-41DA-82BD-FF6319CA235D
// Assembly location: C:\Users\muthu\Downloads\MgaSystems.IMS.Policies.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using MGASystems.Common;
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

#nullable disable
namespace MGASystems.IMS.Policies;

[DesignerGenerated]
public class frmNetRateReconnectData : Form
{
  private IContainer components;
  private readonly int _quoteId;
  private readonly Guid _quoteGuid;

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
    this.lblNetRateQuoteId = new MGATextBox();
    this.Label1 = new Label();
    this.btnSave = new MGAButton();
    this.btnHelp = new MGAButton();
    ((ISupportInitialize) this.lblNetRateQuoteId).BeginInit();
    ((ISupportInitialize) this.btnSave).BeginInit();
    ((ISupportInitialize) this.btnHelp).BeginInit();
    this.SuspendLayout();
    this.lblNetRateUnitNumber.AutoSize = true;
    this.lblNetRateUnitNumber.Location = new Point(21, 38);
    this.lblNetRateUnitNumber.Name = "lblNetRateUnitNumber";
    this.lblNetRateUnitNumber.Size = new Size(97, 13);
    this.lblNetRateUnitNumber.TabIndex = 10;
    this.lblNetRateUnitNumber.Text = "NetRate Quote Id:";
    this.lblNetRateUnitNumber.TextAlign = ContentAlignment.MiddleRight;
    appearance1.BackColor = Color.White;
    appearance1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance1.ForeColor = Color.Black;
    ((TextEditorControlBase) this.lblNetRateQuoteId).Appearance = (AppearanceBase) appearance1;
    ((TextEditorControlBase) this.lblNetRateQuoteId).BackColor = Color.White;
    ((Control) this.lblNetRateQuoteId).Location = new Point((int) sbyte.MaxValue, 34);
    this.lblNetRateQuoteId.MGAStyle = (MGAStyles) 2;
    ((Control) this.lblNetRateQuoteId).Name = "lblNetRateQuoteId";
    ((Control) this.lblNetRateQuoteId).Size = new Size(107, 20);
    ((Control) this.lblNetRateQuoteId).TabIndex = 13;
    ((UltraControlBase) this.lblNetRateQuoteId).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.lblNetRateQuoteId).UseOsThemes = (DefaultableBoolean) 2;
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
    this.Controls.Add((Control) this.lblNetRateQuoteId);
    this.Controls.Add((Control) this.lblNetRateUnitNumber);
    this.Font = new Font("Tahoma", 8.25f);
    this.ForeColor = Color.Black;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmNetRateReconnectData);
    this.Text = "NetRate Reconnect Data Form";
    ((ISupportInitialize) this.lblNetRateQuoteId).EndInit();
    ((ISupportInitialize) this.btnSave).EndInit();
    ((ISupportInitialize) this.btnHelp).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  [field: AccessedThroughProperty("lblNetRateUnitNumber")]
  private virtual Label lblNetRateUnitNumber { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblNetRateQuoteId")]
  internal virtual MGATextBox lblNetRateQuoteId { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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

  public frmNetRateReconnectData(Guid quoteGuid, int QuoteId)
  {
    this.Load += new EventHandler(this.frmNetRateReconnectData_Load);
    this.InitializeComponent();
    this._quoteGuid = quoteGuid;
    this._quoteId = QuoteId;
  }

  public frmNetRateReconnectData(int quoteId)
  {
    this.Load += new EventHandler(this.frmNetRateReconnectData_Load);
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
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((TextEditorControlBase) this.lblNetRateQuoteId).Text, "", false) != 0)
    {
      if (this.checkQuoteIdValidity(((TextEditorControlBase) this.lblNetRateQuoteId).Text))
      {
        if (DefaultDatabase.ExecuteNonQuery(CommandType.Text, "UPDATE NetRate_Quote_Insur_Quote SET unitnumber = @UnitId WHERE QuoteId in (select netrate_quoteid from tblquotes where quoteid = @QuoteId)", new object[4]
        {
          (object) "@UnitId",
          (object) ((TextEditorControlBase) this.lblNetRateQuoteId).Text,
          (object) "@QuoteId",
          (object) this._quoteId
        }) == 1)
        {
          CurrentUser.Instance.LogAction("NetRate Reconnected Quote Id. Unit Number Entered = " + ((TextEditorControlBase) this.lblNetRateQuoteId).Text, this._quoteGuid);
          int num = (int) MessageBox.Show("The NetRate Quote Id has been successfully reconnected to the IMS application.");
        }
        else
        {
          int num1 = (int) MessageBox.Show("The NetRate Quote Id could not be reconnected to the IMS application. Please contact techsupport@mgasystems.com for additional help.");
        }
        this.Close();
      }
      else
      {
        int num2 = (int) MessageBox.Show("Please enter a valid QuoteId.");
      }
    }
    else
    {
      int num3 = (int) MessageBox.Show("Please enter the NetRate QuoteId found in the top center of the NetRate application.");
    }
  }

  private void btnHelp_Click(object sender, EventArgs e)
  {
    int num = (int) MessageBox.Show("To reconnect this policy to the NetRate application you need to enter the Quote Id. The Quote Id is located at the top center of the NetRate Quote tab. Once you have copied the Quote Id close the NetRate application be clicking on the 'X' located in the upper right hand corner of the application. DO NOT RETURN TO THE IMS FROM THE NETRATE APPLICATION. To Make changes use the rating link as you normally would after the Quote Id have been saved.\r \rINSTRUCTIONS: \r1) Copy the NetRate Quote Id location at the top center of the Quote Tab.\r2) Close the NetRate Application by clicking on the 'X' located at the upper right hand corner.\r3) Enter the Quote Id into the text box of the NetRate Reconnect Data Form and save.\r4) You should now be able to click on the NetRate link located under Policy Action in the Policy Detail window.\r \rNOTE: If you do not see the NetRate application open check the taskbar located at the bottom of your screen. If it is not \rthere you might have to wait several minutes for it to open. If it does not or you receive an error(s) anytime during this \rprocess please email techsupport@mgasystems.com with the control number and the information from the error message(s) if \rone was received.");
  }

  public enum NetRateUpdateStatus
  {
    Failed,
    Successful,
  }
}
