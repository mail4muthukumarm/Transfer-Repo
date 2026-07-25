// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Rating.Endorsements.frmEndorsementActionDate
// Assembly: MgaSystems.IMS.Rating, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 370B8F0A-FA1A-41D0-87BD-563CC23E9EA7
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Rating.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using MGASystems.BusinessObjects;
using MGASystems.Common.Enums;
using MGASystems.Tools;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Policies.Rating.Endorsements;

public sealed class frmEndorsementActionDate : Form
{
  private IContainer components;
  private UltraLabel Label1;
  private UltraLabel Label2;
  private UltraLabel Label4;
  private UltraLabel lblExpiration;
  private MGATextBox txtFactor;
  private ErrorProvider err;
  private readonly Quote _quote;
  private readonly IQuoteOption _quoteOption;
  private readonly EndorsementCalcTypes _calcType;
  private bool _saved;
  private Decimal _factor;

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private virtual MGAButton btnOK
  {
    get => this._btnOK;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnOK_Click);
      MGAButton btnOk1 = this._btnOK;
      if (btnOk1 != null)
        ((Control) btnOk1).Click -= eventHandler;
      this._btnOK = value;
      MGAButton btnOk2 = this._btnOK;
      if (btnOk2 == null)
        return;
      ((Control) btnOk2).Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("dtEffective")]
  private virtual MGADateTimePicker dtEffective { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    this.Label1 = new UltraLabel();
    this.btnOK = new MGAButton();
    this.Label2 = new UltraLabel();
    this.lblExpiration = new UltraLabel();
    this.Label4 = new UltraLabel();
    this.dtEffective = new MGADateTimePicker();
    this.txtFactor = new MGATextBox();
    this.err = new ErrorProvider();
    ((ISupportInitialize) this.btnOK).BeginInit();
    ((ISupportInitialize) this.dtEffective).BeginInit();
    ((ISupportInitialize) this.txtFactor).BeginInit();
    this.SuspendLayout();
    ((Control) this.Label1).Location = new Point(8, 8);
    ((Control) this.Label1).Name = "Label1";
    ((Control) this.Label1).Size = new Size(256 /*0x0100*/, 16 /*0x10*/);
    ((Control) this.Label1).TabIndex = 1;
    ((ControlBase) this.Label1).Text = "Please select the date of this exposure change.";
    appearance1.BackColor = Color.Gainsboro;
    appearance1.BackColor2 = Color.White;
    appearance1.BackGradientStyle = (GradientStyle) 2;
    appearance1.BorderColor = Color.Gray;
    ((ControlBase) this.btnOK).Appearance = (AppearanceBase) appearance1;
    ((Control) this.btnOK).Location = new Point(83, 128 /*0x80*/);
    ((Control) this.btnOK).Name = "btnOK";
    ((Control) this.btnOK).Size = new Size(84, 24);
    ((Control) this.btnOK).TabIndex = 2;
    ((ControlBase) this.btnOK).Text = "OK";
    ((AutoSizeControlBase) this.Label2).AutoSize = true;
    ((Control) this.Label2).Location = new Point(24, 67);
    ((Control) this.Label2).Name = "Label2";
    ((Control) this.Label2).Size = new Size(91, 14);
    ((Control) this.Label2).TabIndex = 3;
    ((ControlBase) this.Label2).Text = "Policy Expiration:";
    appearance2.BorderColor = Color.Gray;
    appearance2.TextHAlign = (HAlign) 1;
    appearance2.TextVAlign = (VAlign) 2;
    ((ControlBase) this.lblExpiration).Appearance = (AppearanceBase) appearance2;
    ((ControlBase) this.lblExpiration).BackColor = Color.WhiteSmoke;
    this.lblExpiration.BorderStyleOuter = (UIElementBorderStyle) 4;
    ((Control) this.lblExpiration).Location = new Point(128 /*0x80*/, 64 /*0x40*/);
    ((Control) this.lblExpiration).Name = "lblExpiration";
    ((Control) this.lblExpiration).Size = new Size(100, 20);
    ((Control) this.lblExpiration).TabIndex = 4;
    ((AutoSizeControlBase) this.Label4).AutoSize = true;
    ((Control) this.Label4).Location = new Point(73, 99);
    ((Control) this.Label4).Name = "Label4";
    ((Control) this.Label4).Size = new Size(39, 14);
    ((Control) this.Label4).TabIndex = 5;
    ((ControlBase) this.Label4).Text = "Factor:";
    appearance3.BorderColor = Color.Gray;
    this.dtEffective.Appearance = (AppearanceBase) appearance3;
    appearance4.BackColor = Color.LightGray;
    appearance4.BackColor2 = Color.White;
    appearance4.BackGradientStyle = (GradientStyle) 2;
    appearance4.BorderColor = Color.LightGray;
    appearance4.ForeColor = Color.FromArgb(60, 60, 60);
    this.dtEffective.ButtonAppearance = (AppearanceBase) appearance4;
    ((Control) this.dtEffective).Location = new Point(53, 32 /*0x20*/);
    ((Control) this.dtEffective).Name = "dtEffective";
    ((Control) this.dtEffective).Size = new Size(144 /*0x90*/, 20);
    ((Control) this.dtEffective).TabIndex = 7;
    appearance5.BackColor = Color.White;
    appearance5.BorderColor = Color.Gray;
    appearance5.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtFactor).Appearance = (AppearanceBase) appearance5;
    ((Control) this.txtFactor).Location = new Point(128 /*0x80*/, 96 /*0x60*/);
    ((Control) this.txtFactor).Name = "txtFactor";
    ((Control) this.txtFactor).TabIndex = 8;
    this.err.ContainerControl = (ContainerControl) this;
    this.AutoScaleBaseSize = new Size(5, 13);
    this.BackColor = Color.White;
    this.ClientSize = new Size(250, 167);
    this.Controls.Add((Control) this.txtFactor);
    this.Controls.Add((Control) this.dtEffective);
    this.Controls.Add((Control) this.Label4);
    this.Controls.Add((Control) this.lblExpiration);
    this.Controls.Add((Control) this.Label2);
    this.Controls.Add((Control) this.btnOK);
    this.Controls.Add((Control) this.Label1);
    this.Font = new Font("Tahoma", 8f);
    this.FormBorderStyle = FormBorderStyle.FixedDialog;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmEndorsementActionDate);
    this.Text = "Select Action Date";
    ((ISupportInitialize) this.btnOK).EndInit();
    ((ISupportInitialize) this.dtEffective).EndInit();
    ((ISupportInitialize) this.txtFactor).EndInit();
    this.ResumeLayout(false);
  }

  public Decimal Factor => Conversions.ToDecimal(((TextEditorControlBase) this.txtFactor).Text);

  public bool Saved => this._saved;

  public DateTime ActionDate => this.dtEffective.DateTime;

  public bool FactorOverridden
  {
    get
    {
      return Decimal.Compare(Conversions.ToDecimal(((TextEditorControlBase) this.txtFactor).Text), this._factor) != 0;
    }
  }

  public frmEndorsementActionDate(
    IQuoteOption quoteOption,
    Quote quote,
    EndorsementCalcTypes endorsementCalcType,
    DateTime effective)
  {
    this.Load += new EventHandler(this.frmEndorsementActionDate_Load);
    this.InitializeComponent();
    this._quoteOption = quoteOption;
    this._quote = quote;
    this._calcType = endorsementCalcType;
    this.dtEffective.Value = (object) effective;
  }

  private void frmEndorsementActionDate_Load(object sender, EventArgs e)
  {
    this.dtEffective.MinDate = this._quote.EffectiveDate.AddDays(-1.0);
    this.dtEffective.MaxDate = this._quote.ExpirationDate.AddDays(1.0);
    ((ControlBase) this.lblExpiration).Text = this._quote.ExpirationDate.ToShortDateString();
    ((TextEditorControlBase) this.txtFactor).Text = Strings.FormatNumber((object) this._quoteOption.CalculateFactor(this._calcType, this.dtEffective.DateTime), 4);
    this.dtEffective.ValueChanged += new EventHandler(this.dtEffective_ValueChanged);
  }

  private void btnOK_Click(object sender, EventArgs e)
  {
    if (!Versioned.IsNumeric((object) ((TextEditorControlBase) this.txtFactor).Text))
    {
      this.err.SetError((Control) this.txtFactor, "Invalid Factor");
    }
    else
    {
      this.err.SetError((Control) this.txtFactor, string.Empty);
      this._saved = true;
      this.Close();
    }
  }

  private void dtEffective_ValueChanged(object sender, EventArgs e)
  {
    this._factor = this._quoteOption.CalculateFactor(this._calcType, this.dtEffective.DateTime);
    ((TextEditorControlBase) this.txtFactor).Text = Strings.FormatNumber((object) this._factor, 4);
  }
}
