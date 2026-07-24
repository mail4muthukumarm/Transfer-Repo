// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Forms.Envelopes.frmPrintEnvelope_EnvelopesOptions
// Assembly: MgaSystems.IMS.Forms, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FB3F392E-40B6-486F-8F0B-A4A494A546D4
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Forms.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinTabControl;
using MGASystems.Data;
using MGASystems.Tools;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Forms.Envelopes;

public sealed class frmPrintEnvelope_EnvelopesOptions : Form
{
  private MGATab MgaTab1;
  private UltraTabSharedControlsPage UltraTabSharedControlsPage1;
  private UltraTabPageControl UltraTabPageControl1;
  private UltraTabPageControl UltraTabPageControl2;
  private EnvelopeLayout EnvelopePreview;
  private Label Label8;
  private Label Label4;
  private Label Label3;
  private Label Label2;
  private Label Label1;
  private Label Label7;
  private Label Label6;
  private Label Label5;
  private MGASimpleComboBox cboEnvelopeType;
  private Label Label9;
  private readonly Envelope _originalEnvelope;
  private Envelope _newEnvelope;
  private dsEnvelopes.tblEnvelopeTypesDataTable _envelopeTypes;

  private virtual MGAButton btnOk
  {
    get => this._btnOk;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnOk_Click);
      MGAButton btnOk1 = this._btnOk;
      if (btnOk1 != null)
        ((Control) btnOk1).Click -= eventHandler;
      this._btnOk = value;
      MGAButton btnOk2 = this._btnOk;
      if (btnOk2 == null)
        return;
      ((Control) btnOk2).Click += eventHandler;
    }
  }

  private virtual MGAButton btnCancel
  {
    get => this._btnCancel;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnCancel_Click);
      MGAButton btnCancel1 = this._btnCancel;
      if (btnCancel1 != null)
        ((Control) btnCancel1).Click -= eventHandler;
      this._btnCancel = value;
      MGAButton btnCancel2 = this._btnCancel;
      if (btnCancel2 == null)
        return;
      ((Control) btnCancel2).Click += eventHandler;
    }
  }

  private virtual MGAButton btnDeliveryAddressFont
  {
    get => this._btnDeliveryAddressFont;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnDeliveryAddressFont_Click);
      MGAButton deliveryAddressFont1 = this._btnDeliveryAddressFont;
      if (deliveryAddressFont1 != null)
        ((Control) deliveryAddressFont1).Click -= eventHandler;
      this._btnDeliveryAddressFont = value;
      MGAButton deliveryAddressFont2 = this._btnDeliveryAddressFont;
      if (deliveryAddressFont2 == null)
        return;
      ((Control) deliveryAddressFont2).Click += eventHandler;
    }
  }

  private virtual NumericUpDown UpDownReturnAddressFromTop
  {
    get => this._UpDownReturnAddressFromTop;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.UpDownReturnAddressFromTop_ValueChanged);
      NumericUpDown returnAddressFromTop1 = this._UpDownReturnAddressFromTop;
      if (returnAddressFromTop1 != null)
        returnAddressFromTop1.ValueChanged -= eventHandler;
      this._UpDownReturnAddressFromTop = value;
      NumericUpDown returnAddressFromTop2 = this._UpDownReturnAddressFromTop;
      if (returnAddressFromTop2 == null)
        return;
      returnAddressFromTop2.ValueChanged += eventHandler;
    }
  }

  private virtual NumericUpDown UpDownReturnAddressFromLeft
  {
    get => this._UpDownReturnAddressFromLeft;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.UpDownReturnAddressFromLeft_ValueChanged);
      NumericUpDown returnAddressFromLeft1 = this._UpDownReturnAddressFromLeft;
      if (returnAddressFromLeft1 != null)
        returnAddressFromLeft1.ValueChanged -= eventHandler;
      this._UpDownReturnAddressFromLeft = value;
      NumericUpDown returnAddressFromLeft2 = this._UpDownReturnAddressFromLeft;
      if (returnAddressFromLeft2 == null)
        return;
      returnAddressFromLeft2.ValueChanged += eventHandler;
    }
  }

  private virtual NumericUpDown UpDownDeliveryAddressFromTop
  {
    get => this._UpDownDeliveryAddressFromTop;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.UpDownDeliveryAddressFromTop_ValueChanged);
      NumericUpDown deliveryAddressFromTop1 = this._UpDownDeliveryAddressFromTop;
      if (deliveryAddressFromTop1 != null)
        deliveryAddressFromTop1.ValueChanged -= eventHandler;
      this._UpDownDeliveryAddressFromTop = value;
      NumericUpDown deliveryAddressFromTop2 = this._UpDownDeliveryAddressFromTop;
      if (deliveryAddressFromTop2 == null)
        return;
      deliveryAddressFromTop2.ValueChanged += eventHandler;
    }
  }

  private virtual NumericUpDown UpDownDeliveryAddressFromLeft
  {
    get => this._UpDownDeliveryAddressFromLeft;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.UpDownDeliveryAddressFromLeft_ValueChanged);
      NumericUpDown deliveryAddressFromLeft1 = this._UpDownDeliveryAddressFromLeft;
      if (deliveryAddressFromLeft1 != null)
        deliveryAddressFromLeft1.ValueChanged -= eventHandler;
      this._UpDownDeliveryAddressFromLeft = value;
      NumericUpDown deliveryAddressFromLeft2 = this._UpDownDeliveryAddressFromLeft;
      if (deliveryAddressFromLeft2 == null)
        return;
      deliveryAddressFromLeft2.ValueChanged += eventHandler;
    }
  }

  private virtual MGAButton btnReturnAddressFont
  {
    get => this._btnReturnAddressFont;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnReturnAddressFont_Click);
      MGAButton returnAddressFont1 = this._btnReturnAddressFont;
      if (returnAddressFont1 != null)
        ((Control) returnAddressFont1).Click -= eventHandler;
      this._btnReturnAddressFont = value;
      MGAButton returnAddressFont2 = this._btnReturnAddressFont;
      if (returnAddressFont2 == null)
        return;
      ((Control) returnAddressFont2).Click += eventHandler;
    }
  }

  private virtual RadioButton rbFaceDown
  {
    get => this._rbFaceDown;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.rbFaceDown_CheckedChanged);
      RadioButton rbFaceDown1 = this._rbFaceDown;
      if (rbFaceDown1 != null)
        rbFaceDown1.CheckedChanged -= eventHandler;
      this._rbFaceDown = value;
      RadioButton rbFaceDown2 = this._rbFaceDown;
      if (rbFaceDown2 == null)
        return;
      rbFaceDown2.CheckedChanged += eventHandler;
    }
  }

  private virtual RadioButton rbFaceUp
  {
    get => this._rbFaceUp;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.rbFaceUp_CheckedChanged);
      RadioButton rbFaceUp1 = this._rbFaceUp;
      if (rbFaceUp1 != null)
        rbFaceUp1.CheckedChanged -= eventHandler;
      this._rbFaceUp = value;
      RadioButton rbFaceUp2 = this._rbFaceUp;
      if (rbFaceUp2 == null)
        return;
      rbFaceUp2.CheckedChanged += eventHandler;
    }
  }

  private virtual PictureBox env6
  {
    get => this._env6;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.env6_Click);
      PictureBox env6_1 = this._env6;
      if (env6_1 != null)
        env6_1.Click -= eventHandler;
      this._env6 = value;
      PictureBox env6_2 = this._env6;
      if (env6_2 == null)
        return;
      env6_2.Click += eventHandler;
    }
  }

  private virtual PictureBox env5
  {
    get => this._env5;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.env5_Click);
      PictureBox env5_1 = this._env5;
      if (env5_1 != null)
        env5_1.Click -= eventHandler;
      this._env5 = value;
      PictureBox env5_2 = this._env5;
      if (env5_2 == null)
        return;
      env5_2.Click += eventHandler;
    }
  }

  private virtual PictureBox env4
  {
    get => this._env4;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.env4_Click);
      PictureBox env4_1 = this._env4;
      if (env4_1 != null)
        env4_1.Click -= eventHandler;
      this._env4 = value;
      PictureBox env4_2 = this._env4;
      if (env4_2 == null)
        return;
      env4_2.Click += eventHandler;
    }
  }

  private virtual PictureBox env3
  {
    get => this._env3;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.env3_Click);
      PictureBox env3_1 = this._env3;
      if (env3_1 != null)
        env3_1.Click -= eventHandler;
      this._env3 = value;
      PictureBox env3_2 = this._env3;
      if (env3_2 == null)
        return;
      env3_2.Click += eventHandler;
    }
  }

  private virtual PictureBox env2
  {
    get => this._env2;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.env2_Click);
      PictureBox env2_1 = this._env2;
      if (env2_1 != null)
        env2_1.Click -= eventHandler;
      this._env2 = value;
      PictureBox env2_2 = this._env2;
      if (env2_2 == null)
        return;
      env2_2.Click += eventHandler;
    }
  }

  private virtual PictureBox env1
  {
    get => this._env1;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.env1_Click);
      PictureBox env1_1 = this._env1;
      if (env1_1 != null)
        env1_1.Click -= eventHandler;
      this._env1 = value;
      PictureBox env1_2 = this._env1;
      if (env1_2 == null)
        return;
      env1_2.Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("FontDialog1")]
  internal virtual FontDialog FontDialog1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label10")]
  internal virtual Label Label10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private void InitializeComponent()
  {
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    UltraTab ultraTab1 = new UltraTab();
    UltraTab ultraTab2 = new UltraTab();
    this.UltraTabPageControl1 = new UltraTabPageControl();
    this.Label10 = new Label();
    this.Label8 = new Label();
    this.Label4 = new Label();
    this.Label3 = new Label();
    this.Label2 = new Label();
    this.btnDeliveryAddressFont = new MGAButton();
    this.Label1 = new Label();
    this.UpDownReturnAddressFromTop = new NumericUpDown();
    this.UpDownReturnAddressFromLeft = new NumericUpDown();
    this.UpDownDeliveryAddressFromTop = new NumericUpDown();
    this.UpDownDeliveryAddressFromLeft = new NumericUpDown();
    this.Label7 = new Label();
    this.btnReturnAddressFont = new MGAButton();
    this.Label6 = new Label();
    this.Label5 = new Label();
    this.cboEnvelopeType = new MGASimpleComboBox();
    this.UltraTabPageControl2 = new UltraTabPageControl();
    this.rbFaceDown = new RadioButton();
    this.rbFaceUp = new RadioButton();
    this.env6 = new PictureBox();
    this.env5 = new PictureBox();
    this.env4 = new PictureBox();
    this.env3 = new PictureBox();
    this.env2 = new PictureBox();
    this.env1 = new PictureBox();
    this.Label9 = new Label();
    this.btnOk = new MGAButton();
    this.btnCancel = new MGAButton();
    this.MgaTab1 = new MGATab();
    this.UltraTabSharedControlsPage1 = new UltraTabSharedControlsPage();
    this.FontDialog1 = new FontDialog();
    this.EnvelopePreview = new EnvelopeLayout();
    ((Control) this.UltraTabPageControl1).SuspendLayout();
    ((ISupportInitialize) this.btnDeliveryAddressFont).BeginInit();
    this.UpDownReturnAddressFromTop.BeginInit();
    this.UpDownReturnAddressFromLeft.BeginInit();
    this.UpDownDeliveryAddressFromTop.BeginInit();
    this.UpDownDeliveryAddressFromLeft.BeginInit();
    ((ISupportInitialize) this.btnReturnAddressFont).BeginInit();
    ((ISupportInitialize) this.cboEnvelopeType).BeginInit();
    ((Control) this.UltraTabPageControl2).SuspendLayout();
    ((ISupportInitialize) this.env6).BeginInit();
    ((ISupportInitialize) this.env5).BeginInit();
    ((ISupportInitialize) this.env4).BeginInit();
    ((ISupportInitialize) this.env3).BeginInit();
    ((ISupportInitialize) this.env2).BeginInit();
    ((ISupportInitialize) this.env1).BeginInit();
    ((ISupportInitialize) this.btnOk).BeginInit();
    ((ISupportInitialize) this.btnCancel).BeginInit();
    ((ISupportInitialize) this.MgaTab1).BeginInit();
    ((Control) this.MgaTab1).SuspendLayout();
    this.SuspendLayout();
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.Label10);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.EnvelopePreview);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.Label8);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.Label4);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.Label3);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.Label2);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.btnDeliveryAddressFont);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.Label1);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.UpDownReturnAddressFromTop);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.UpDownReturnAddressFromLeft);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.UpDownDeliveryAddressFromTop);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.UpDownDeliveryAddressFromLeft);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.Label7);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.btnReturnAddressFont);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.Label6);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.Label5);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.cboEnvelopeType);
    ((Control) this.UltraTabPageControl1).Location = new Point(1, 20);
    ((Control) this.UltraTabPageControl1).Name = "UltraTabPageControl1";
    ((Control) this.UltraTabPageControl1).Size = new Size(310, 283);
    this.Label10.Location = new Point(8, 8);
    this.Label10.Name = "Label10";
    this.Label10.Size = new Size(100, 16 /*0x10*/);
    this.Label10.TabIndex = 35;
    this.Label10.Text = "Envelope Size:";
    this.Label8.Location = new Point(8, 184);
    this.Label8.Name = "Label8";
    this.Label8.Size = new Size(100, 16 /*0x10*/);
    this.Label8.TabIndex = 34;
    this.Label8.Text = "Preview:";
    this.Label4.Location = new Point(-17, -43);
    this.Label4.Name = "Label4";
    this.Label4.Size = new Size(100, 18);
    this.Label4.TabIndex = 27;
    this.Label4.Text = "Envelope size:";
    this.Label3.Location = new Point(160 /*0xA0*/, 88);
    this.Label3.Name = "Label3";
    this.Label3.Size = new Size(64 /*0x40*/, 16 /*0x10*/);
    this.Label3.TabIndex = 24;
    this.Label3.Text = "From Top:";
    this.Label2.Location = new Point(160 /*0xA0*/, 64 /*0x40*/);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(64 /*0x40*/, 16 /*0x10*/);
    this.Label2.TabIndex = 21;
    this.Label2.Text = "From Left:";
    appearance1.BackColor = Color.FromArgb(248, 248, 248);
    appearance1.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance1.BackGradientStyle = (GradientStyle) 2;
    appearance1.BorderColor = Color.DarkGray;
    ((ControlBase) this.btnDeliveryAddressFont).Appearance = (AppearanceBase) appearance1;
    ((Control) this.btnDeliveryAddressFont).Location = new Point(8, 64 /*0x40*/);
    ((Control) this.btnDeliveryAddressFont).Name = "btnDeliveryAddressFont";
    ((Control) this.btnDeliveryAddressFont).Size = new Size(75, 24);
    ((Control) this.btnDeliveryAddressFont).TabIndex = 22;
    ((ControlBase) this.btnDeliveryAddressFont).Text = "Font...";
    this.btnDeliveryAddressFont.UseOSThemes = (DefaultableBoolean) 2;
    this.Label1.Location = new Point(8, 48 /*0x30*/);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(100, 16 /*0x10*/);
    this.Label1.TabIndex = 19;
    this.Label1.Text = "Delivery Address:";
    this.UpDownReturnAddressFromTop.DecimalPlaces = 2;
    this.UpDownReturnAddressFromTop.Increment = new Decimal(new int[4]
    {
      1,
      0,
      0,
      65536 /*0x010000*/
    });
    this.UpDownReturnAddressFromTop.Location = new Point(224 /*0xE0*/, 160 /*0xA0*/);
    this.UpDownReturnAddressFromTop.Name = "UpDownReturnAddressFromTop";
    this.UpDownReturnAddressFromTop.Size = new Size(72, 21);
    this.UpDownReturnAddressFromTop.TabIndex = 29;
    this.UpDownReturnAddressFromLeft.DecimalPlaces = 2;
    this.UpDownReturnAddressFromLeft.Increment = new Decimal(new int[4]
    {
      1,
      0,
      0,
      65536 /*0x010000*/
    });
    this.UpDownReturnAddressFromLeft.Location = new Point(224 /*0xE0*/, 136);
    this.UpDownReturnAddressFromLeft.Name = "UpDownReturnAddressFromLeft";
    this.UpDownReturnAddressFromLeft.Size = new Size(72, 21);
    this.UpDownReturnAddressFromLeft.TabIndex = 28;
    this.UpDownDeliveryAddressFromTop.DecimalPlaces = 2;
    this.UpDownDeliveryAddressFromTop.Increment = new Decimal(new int[4]
    {
      1,
      0,
      0,
      65536 /*0x010000*/
    });
    this.UpDownDeliveryAddressFromTop.Location = new Point(224 /*0xE0*/, 88);
    this.UpDownDeliveryAddressFromTop.Name = "UpDownDeliveryAddressFromTop";
    this.UpDownDeliveryAddressFromTop.Size = new Size(72, 21);
    this.UpDownDeliveryAddressFromTop.TabIndex = 25;
    this.UpDownDeliveryAddressFromLeft.DecimalPlaces = 2;
    this.UpDownDeliveryAddressFromLeft.Increment = new Decimal(new int[4]
    {
      1,
      0,
      0,
      65536 /*0x010000*/
    });
    this.UpDownDeliveryAddressFromLeft.Location = new Point(224 /*0xE0*/, 64 /*0x40*/);
    this.UpDownDeliveryAddressFromLeft.Name = "UpDownDeliveryAddressFromLeft";
    this.UpDownDeliveryAddressFromLeft.Size = new Size(72, 21);
    this.UpDownDeliveryAddressFromLeft.TabIndex = 23;
    this.Label7.Location = new Point(8, 120);
    this.Label7.Name = "Label7";
    this.Label7.Size = new Size(100, 16 /*0x10*/);
    this.Label7.TabIndex = 31 /*0x1F*/;
    this.Label7.Text = "Return Address:";
    appearance2.BackColor = Color.FromArgb(248, 248, 248);
    appearance2.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance2.BackGradientStyle = (GradientStyle) 2;
    appearance2.BorderColor = Color.DarkGray;
    ((ControlBase) this.btnReturnAddressFont).Appearance = (AppearanceBase) appearance2;
    ((Control) this.btnReturnAddressFont).Location = new Point(8, 136);
    ((Control) this.btnReturnAddressFont).Name = "btnReturnAddressFont";
    ((Control) this.btnReturnAddressFont).Size = new Size(75, 24);
    ((Control) this.btnReturnAddressFont).TabIndex = 26;
    ((ControlBase) this.btnReturnAddressFont).Text = "Font...";
    this.btnReturnAddressFont.UseOSThemes = (DefaultableBoolean) 2;
    this.Label6.Location = new Point(160 /*0xA0*/, 136);
    this.Label6.Name = "Label6";
    this.Label6.Size = new Size(56, 16 /*0x10*/);
    this.Label6.TabIndex = 32 /*0x20*/;
    this.Label6.Text = "From Left:";
    this.Label5.Location = new Point(160 /*0xA0*/, 160 /*0xA0*/);
    this.Label5.Name = "Label5";
    this.Label5.Size = new Size(64 /*0x40*/, 16 /*0x10*/);
    this.Label5.TabIndex = 33;
    this.Label5.Text = "From Top:";
    this.cboEnvelopeType.CharacterCasing = CharacterCasing.Normal;
    this.cboEnvelopeType.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboEnvelopeType).Location = new Point(8, 24);
    ((Control) this.cboEnvelopeType).Name = "cboEnvelopeType";
    ((Control) this.cboEnvelopeType).Size = new Size(288, 21);
    ((Control) this.cboEnvelopeType).TabIndex = 20;
    ((UltraControlBase) this.cboEnvelopeType).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboEnvelopeType).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.rbFaceDown);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.rbFaceUp);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.env6);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.env5);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.env4);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.env3);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.env2);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.env1);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.Label9);
    ((Control) this.UltraTabPageControl2).Location = new Point(-10000, -10000);
    ((Control) this.UltraTabPageControl2).Name = "UltraTabPageControl2";
    ((Control) this.UltraTabPageControl2).Size = new Size(310, 283);
    this.rbFaceDown.Location = new Point(160 /*0xA0*/, 88);
    this.rbFaceDown.Name = "rbFaceDown";
    this.rbFaceDown.Size = new Size(80 /*0x50*/, 16 /*0x10*/);
    this.rbFaceDown.TabIndex = 11;
    this.rbFaceDown.Text = "Face &down";
    this.rbFaceDown.Visible = false;
    this.rbFaceUp.Location = new Point(16 /*0x10*/, 88);
    this.rbFaceUp.Name = "rbFaceUp";
    this.rbFaceUp.Size = new Size(80 /*0x50*/, 16 /*0x10*/);
    this.rbFaceUp.TabIndex = 9;
    this.rbFaceUp.TabStop = true;
    this.rbFaceUp.Text = "Face &up";
    this.rbFaceUp.Visible = false;
    this.env6.BackColor = Color.White;
    this.env6.BorderStyle = BorderStyle.FixedSingle;
    this.env6.Location = new Point(256 /*0x0100*/, 32 /*0x20*/);
    this.env6.Name = "env6";
    this.env6.Size = new Size(40, 48 /*0x30*/);
    this.env6.TabIndex = 15;
    this.env6.TabStop = false;
    this.env5.BackColor = Color.White;
    this.env5.BorderStyle = BorderStyle.FixedSingle;
    this.env5.Location = new Point(208 /*0xD0*/, 32 /*0x20*/);
    this.env5.Name = "env5";
    this.env5.Size = new Size(40, 48 /*0x30*/);
    this.env5.TabIndex = 14;
    this.env5.TabStop = false;
    this.env4.BackColor = Color.White;
    this.env4.BorderStyle = BorderStyle.FixedSingle;
    this.env4.Location = new Point(160 /*0xA0*/, 32 /*0x20*/);
    this.env4.Name = "env4";
    this.env4.Size = new Size(40, 48 /*0x30*/);
    this.env4.TabIndex = 13;
    this.env4.TabStop = false;
    this.env3.BackColor = Color.White;
    this.env3.BorderStyle = BorderStyle.FixedSingle;
    this.env3.Location = new Point(112 /*0x70*/, 32 /*0x20*/);
    this.env3.Name = "env3";
    this.env3.Size = new Size(40, 48 /*0x30*/);
    this.env3.TabIndex = 12;
    this.env3.TabStop = false;
    this.env2.BackColor = Color.White;
    this.env2.BorderStyle = BorderStyle.FixedSingle;
    this.env2.Location = new Point(64 /*0x40*/, 32 /*0x20*/);
    this.env2.Name = "env2";
    this.env2.Size = new Size(40, 48 /*0x30*/);
    this.env2.TabIndex = 10;
    this.env2.TabStop = false;
    this.env1.BackColor = Color.White;
    this.env1.BorderStyle = BorderStyle.FixedSingle;
    this.env1.Location = new Point(16 /*0x10*/, 32 /*0x20*/);
    this.env1.Name = "env1";
    this.env1.Size = new Size(40, 48 /*0x30*/);
    this.env1.TabIndex = 8;
    this.env1.TabStop = false;
    this.Label9.Location = new Point(8, 8);
    this.Label9.Name = "Label9";
    this.Label9.Size = new Size(80 /*0x50*/, 16 /*0x10*/);
    this.Label9.TabIndex = 7;
    this.Label9.Text = "Feed method:";
    ((Control) this.btnOk).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance3.BackColor = Color.FromArgb(248, 248, 248);
    appearance3.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance3.BackGradientStyle = (GradientStyle) 2;
    appearance3.BorderColor = Color.DarkGray;
    ((ControlBase) this.btnOk).Appearance = (AppearanceBase) appearance3;
    ((UltraButtonBase) this.btnOk).DialogResult = DialogResult.OK;
    ((Control) this.btnOk).Location = new Point(165, 320);
    ((Control) this.btnOk).Name = "btnOk";
    ((Control) this.btnOk).Size = new Size(72, 24);
    ((Control) this.btnOk).TabIndex = 9;
    ((ControlBase) this.btnOk).Text = "OK";
    this.btnOk.UseOSThemes = (DefaultableBoolean) 2;
    ((Control) this.btnCancel).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance4.BackColor = Color.FromArgb(248, 248, 248);
    appearance4.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance4.BackGradientStyle = (GradientStyle) 2;
    appearance4.BorderColor = Color.DarkGray;
    ((ControlBase) this.btnCancel).Appearance = (AppearanceBase) appearance4;
    ((UltraButtonBase) this.btnCancel).DialogResult = DialogResult.Cancel;
    ((Control) this.btnCancel).Location = new Point(245, 320);
    ((Control) this.btnCancel).Name = "btnCancel";
    ((Control) this.btnCancel).Size = new Size(72, 24);
    ((Control) this.btnCancel).TabIndex = 10;
    ((ControlBase) this.btnCancel).Text = "Cancel";
    this.btnCancel.UseOSThemes = (DefaultableBoolean) 2;
    appearance5.BackColor = Color.Gainsboro;
    ((UltraTabControlBase) this.MgaTab1).Appearance = (AppearanceBase) appearance5;
    ((Control) this.MgaTab1).Controls.Add((Control) this.UltraTabSharedControlsPage1);
    ((Control) this.MgaTab1).Controls.Add((Control) this.UltraTabPageControl1);
    ((Control) this.MgaTab1).Controls.Add((Control) this.UltraTabPageControl2);
    ((Control) this.MgaTab1).Location = new Point(5, 8);
    ((Control) this.MgaTab1).Name = "MgaTab1";
    appearance6.BackColor = Color.WhiteSmoke;
    appearance6.BorderColor = Color.Gray;
    ((UltraTabControlBase) this.MgaTab1).SelectedTabAppearance = (AppearanceBase) appearance6;
    ((UltraTabControlBase) this.MgaTab1).SharedControlsPage = this.UltraTabSharedControlsPage1;
    ((Control) this.MgaTab1).Size = new Size(312, 304);
    ((UltraTabControlBase) this.MgaTab1).Style = (UltraTabControlStyle) 12;
    ((Control) this.MgaTab1).TabIndex = 11;
    ultraTab1.TabPage = this.UltraTabPageControl1;
    ultraTab1.Text = "Envelope Options";
    ultraTab2.TabPage = this.UltraTabPageControl2;
    ultraTab2.Text = "Printing Options";
    ((UltraTabControlBase) this.MgaTab1).Tabs.AddRange(new UltraTab[2]
    {
      ultraTab1,
      ultraTab2
    });
    ((UltraControlBase) this.MgaTab1).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaTab1).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.UltraTabSharedControlsPage1).Location = new Point(-10000, -10000);
    ((Control) this.UltraTabSharedControlsPage1).Name = "UltraTabSharedControlsPage1";
    ((Control) this.UltraTabSharedControlsPage1).Size = new Size(310, 283);
    this.EnvelopePreview.Envelope = (Envelope) null;
    this.EnvelopePreview.Font = new Font("Tahoma", 8.25f);
    this.EnvelopePreview.ForeColor = Color.Black;
    this.EnvelopePreview.Location = new Point(8, 200);
    this.EnvelopePreview.Name = "EnvelopePreview";
    this.EnvelopePreview.Size = new Size(296, 104);
    this.EnvelopePreview.TabIndex = 30;
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.WhiteSmoke;
    this.ClientSize = new Size(322, 352);
    this.Controls.Add((Control) this.MgaTab1);
    this.Controls.Add((Control) this.btnCancel);
    this.Controls.Add((Control) this.btnOk);
    this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.ForeColor = Color.Black;
    this.FormBorderStyle = FormBorderStyle.FixedSingle;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmPrintEnvelope_EnvelopesOptions);
    this.Text = "Envelope Options";
    ((Control) this.UltraTabPageControl1).ResumeLayout(false);
    ((Control) this.UltraTabPageControl1).PerformLayout();
    ((ISupportInitialize) this.btnDeliveryAddressFont).EndInit();
    this.UpDownReturnAddressFromTop.EndInit();
    this.UpDownReturnAddressFromLeft.EndInit();
    this.UpDownDeliveryAddressFromTop.EndInit();
    this.UpDownDeliveryAddressFromLeft.EndInit();
    ((ISupportInitialize) this.btnReturnAddressFont).EndInit();
    ((ISupportInitialize) this.cboEnvelopeType).EndInit();
    ((Control) this.UltraTabPageControl2).ResumeLayout(false);
    ((ISupportInitialize) this.env6).EndInit();
    ((ISupportInitialize) this.env5).EndInit();
    ((ISupportInitialize) this.env4).EndInit();
    ((ISupportInitialize) this.env3).EndInit();
    ((ISupportInitialize) this.env2).EndInit();
    ((ISupportInitialize) this.env1).EndInit();
    ((ISupportInitialize) this.btnOk).EndInit();
    ((ISupportInitialize) this.btnCancel).EndInit();
    ((ISupportInitialize) this.MgaTab1).EndInit();
    ((Control) this.MgaTab1).ResumeLayout(false);
    this.ResumeLayout(false);
  }

  private void FillEnvelopeTypes()
  {
    DefaultDatabase.LoadDataTable((DataTable) this._envelopeTypes, CommandType.Text, "SELECT EnvelopeTypeID, Description, Height, Width, DeliveryAddressFromLeft, DeliveryAddressFromTop, DeliveryAddressFromLeftMAX, DeliveryAddressFromTopMAX, DeliveryAddressFromLeftMIN, DeliveryAddressFromTopMIN, ReturnAddressFromLeft, ReturnAddressFromTop, ReturnAddressFromLeftMAX, ReturnAddressFromTopMAX, ReturnAddressFromLeftMIN, ReturnAddressFromTopMIN, DefaultEnvelope FROM dbo.tblEnvelopeTypes ORDER BY EnvelopeTypeID ASC");
    this.cboEnvelopeType.ValueChanged -= new EventHandler(this.cboEnvelopeType_ValueChanged);
    MGASimpleComboBox cboEnvelopeType = this.cboEnvelopeType;
    ((UltraDropDownBase) cboEnvelopeType).DisplayMember = "Description";
    ((UltraDropDownBase) cboEnvelopeType).ValueMember = "EnvelopeTypeID";
    ((UltraGridBase) cboEnvelopeType).DataSource = (object) this._envelopeTypes;
    this.cboEnvelopeType.ValueChanged += new EventHandler(this.cboEnvelopeType_ValueChanged);
  }

  private void UpdateEnvelopeDisplay()
  {
    this.EnvelopePreview.Envelope = this._newEnvelope;
    this.EnvelopePreview.Refresh();
  }

  private void LoadSavedEnvelopeSettings()
  {
    DataTable dataTable = DefaultDatabase.ExecuteDataTable("dbo.GetDefaultEnvelopeSettings", new object[2]
    {
      (object) "@EnvelopeTypeID",
      (object) Conversions.ToInteger(this.cboEnvelopeType.Value)
    });
    if (dataTable.Rows.Count <= 0)
      return;
    this.UpDownDeliveryAddressFromLeft.Value = Conversions.ToDecimal(dataTable.Rows[0]["DeliveryAddressFromLeft"]);
    this.UpDownDeliveryAddressFromTop.Value = Conversions.ToDecimal(dataTable.Rows[0]["DeliveryAddressFromTop"]);
    this.UpDownReturnAddressFromLeft.Value = Conversions.ToDecimal(dataTable.Rows[0]["ReturnAddressFromLeft"]);
    this.UpDownReturnAddressFromTop.Value = Conversions.ToDecimal(dataTable.Rows[0]["ReturnAddressFromTop"]);
    this.env1.Image = ImageCache.Instance.Envelope_FaceUp_1;
    this.env2.Image = ImageCache.Instance.Envelope_FaceUp_2;
    this.env3.Image = ImageCache.Instance.Envelope_FaceUp_3;
    this.env4.Image = ImageCache.Instance.Envelope_FaceUp_4;
    this.env5.Image = ImageCache.Instance.Envelope_FaceUp_5;
    this.env6.Image = ImageCache.Instance.Envelope_FaceUp_6;
    string Left = dataTable.Rows[0]["EnvelopeFeedMethod"].ToString();
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "envelope_feed_1", false) != 0)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "envelope_feed_2", false) != 0)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "envelope_feed_3", false) != 0)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "envelope_feed_4", false) != 0)
          {
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "envelope_feed_5", false) != 0)
            {
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "envelope_feed_6", false) != 0)
                return;
              this._newEnvelope.FeedMethod = Envelope.EnvelopeFeedMethod.envelope_feed_6;
              this.env6.Image = ImageCache.CreateLayeredImage(this.env6.Image, ImageCache.Instance.Envelope_Selected, ContentAlignment.MiddleCenter);
            }
            else
            {
              this._newEnvelope.FeedMethod = Envelope.EnvelopeFeedMethod.envelope_feed_5;
              this.env5.Image = ImageCache.CreateLayeredImage(this.env5.Image, ImageCache.Instance.Envelope_Selected, ContentAlignment.MiddleCenter);
            }
          }
          else
          {
            this._newEnvelope.FeedMethod = Envelope.EnvelopeFeedMethod.envelope_feed_4;
            this.env4.Image = ImageCache.CreateLayeredImage(this.env4.Image, ImageCache.Instance.Envelope_Selected, ContentAlignment.MiddleCenter);
          }
        }
        else
        {
          this._newEnvelope.FeedMethod = Envelope.EnvelopeFeedMethod.envelope_feed_3;
          this.env3.Image = ImageCache.CreateLayeredImage(this.env3.Image, ImageCache.Instance.Envelope_Selected, ContentAlignment.MiddleCenter);
        }
      }
      else
      {
        this._newEnvelope.FeedMethod = Envelope.EnvelopeFeedMethod.envelope_feed_2;
        this.env2.Image = ImageCache.CreateLayeredImage(this.env2.Image, ImageCache.Instance.Envelope_Selected, ContentAlignment.MiddleCenter);
      }
    }
    else
    {
      this._newEnvelope.FeedMethod = Envelope.EnvelopeFeedMethod.envelope_feed_1;
      this.env1.Image = ImageCache.CreateLayeredImage(this.env1.Image, ImageCache.Instance.Envelope_Selected, ContentAlignment.MiddleCenter);
    }
  }

  private void SaveEnvelopeSettings()
  {
    int integer = Conversions.ToInteger(this.cboEnvelopeType.Value);
    Decimal num1 = this.UpDownDeliveryAddressFromLeft.Value;
    Decimal num2 = this.UpDownDeliveryAddressFromTop.Value;
    Decimal num3 = this.UpDownReturnAddressFromLeft.Value;
    Decimal num4 = this.UpDownReturnAddressFromTop.Value;
    string str1 = this._newEnvelope.FeedMethod.ToString();
    string str2 = this._newEnvelope.DeliveryAddress.Font.ToString();
    string str3 = this._newEnvelope.ReturnAddress.Font.ToString();
    DefaultDatabase.ExecuteNonQuery("SetDefaultEnvelopeSettings", new object[16 /*0x10*/]
    {
      (object) "@EnvelopeTypeID",
      (object) integer,
      (object) "@DeliveryAddressLeft",
      (object) num1,
      (object) "@DeliveryAddressTop",
      (object) num2,
      (object) "@ReturnAddressLeft",
      (object) num3,
      (object) "@ReturnAddressTop",
      (object) num4,
      (object) "@EnvelopeFeedMethod",
      (object) str1,
      (object) "@ReturnAddressFont",
      (object) str3,
      (object) "@DeliveryAddressFont",
      (object) str2
    });
  }

  private void SetCurrentEnvelopeMeasurements()
  {
    Envelope newEnvelope = this._newEnvelope;
    this._newEnvelope.Height = newEnvelope.Height;
    this._newEnvelope.Width = newEnvelope.Width;
    this.UpDownDeliveryAddressFromLeft.Value = new Decimal(newEnvelope.DeliveryAddress.fromLeft);
    this.UpDownDeliveryAddressFromTop.Value = new Decimal(newEnvelope.DeliveryAddress.fromTop);
    this.UpDownReturnAddressFromLeft.Value = new Decimal(newEnvelope.ReturnAddress.fromLeft);
    this.UpDownReturnAddressFromTop.Value = new Decimal(newEnvelope.ReturnAddress.fromTop);
  }

  private void SetFeedMethods()
  {
    switch (this._newEnvelope.Face)
    {
      case Envelope.EnvelopeFace.up:
        this.rbFaceUp.CheckedChanged -= new EventHandler(this.rbFaceUp_CheckedChanged);
        this.rbFaceUp.Checked = true;
        this.rbFaceUp.CheckedChanged += new EventHandler(this.rbFaceUp_CheckedChanged);
        this.env1.Image = ImageCache.Instance.Envelope_FaceUp_1;
        this.env2.Image = ImageCache.Instance.Envelope_FaceUp_2;
        this.env3.Image = ImageCache.Instance.Envelope_FaceUp_3;
        this.env4.Image = ImageCache.Instance.Envelope_FaceUp_4;
        this.env5.Image = ImageCache.Instance.Envelope_FaceUp_5;
        this.env6.Image = ImageCache.Instance.Envelope_FaceUp_6;
        break;
      case Envelope.EnvelopeFace.down:
        this.rbFaceDown.CheckedChanged -= new EventHandler(this.rbFaceDown_CheckedChanged);
        this.rbFaceDown.Checked = true;
        this.rbFaceDown.CheckedChanged += new EventHandler(this.rbFaceDown_CheckedChanged);
        this.env1.Image = ImageCache.Instance.Envelope_FaceDown_1;
        this.env2.Image = ImageCache.Instance.Envelope_FaceDown_2;
        this.env3.Image = ImageCache.Instance.Envelope_FaceDown_3;
        this.env4.Image = ImageCache.Instance.Envelope_FaceDown_4;
        this.env5.Image = ImageCache.Instance.Envelope_FaceDown_5;
        this.env6.Image = ImageCache.Instance.Envelope_FaceDown_6;
        break;
    }
    switch (this._newEnvelope.FeedMethod)
    {
      case Envelope.EnvelopeFeedMethod.envelope_feed_1:
        this.env1.Image = ImageCache.CreateLayeredImage(this.env1.Image, ImageCache.Instance.Envelope_Selected, ContentAlignment.MiddleCenter);
        break;
      case Envelope.EnvelopeFeedMethod.envelope_feed_2:
        this.env2.Image = ImageCache.CreateLayeredImage(this.env2.Image, ImageCache.Instance.Envelope_Selected, ContentAlignment.MiddleCenter);
        break;
      case Envelope.EnvelopeFeedMethod.envelope_feed_3:
        this.env3.Image = ImageCache.CreateLayeredImage(this.env3.Image, ImageCache.Instance.Envelope_Selected, ContentAlignment.MiddleCenter);
        break;
      case Envelope.EnvelopeFeedMethod.envelope_feed_4:
        this.env4.Image = ImageCache.CreateLayeredImage(this.env4.Image, ImageCache.Instance.Envelope_Selected, ContentAlignment.MiddleCenter);
        break;
      case Envelope.EnvelopeFeedMethod.envelope_feed_5:
        this.env5.Image = ImageCache.CreateLayeredImage(this.env5.Image, ImageCache.Instance.Envelope_Selected, ContentAlignment.MiddleCenter);
        break;
      case Envelope.EnvelopeFeedMethod.envelope_feed_6:
        this.env6.Image = ImageCache.CreateLayeredImage(this.env6.Image, ImageCache.Instance.Envelope_Selected, ContentAlignment.MiddleCenter);
        break;
    }
  }

  public frmPrintEnvelope_EnvelopesOptions(Envelope e)
  {
    this.Load += new EventHandler(this.frmPrintEnvelope_newEnvelopesOptions_Load);
    this._envelopeTypes = new dsEnvelopes.tblEnvelopeTypesDataTable();
    this.InitializeComponent();
    this._originalEnvelope = e;
  }

  private void frmPrintEnvelope_newEnvelopesOptions_Load(object sender, EventArgs e)
  {
    this.FillEnvelopeTypes();
    this._newEnvelope = this._originalEnvelope.Clone();
    this.cboEnvelopeType.Value = (object) this._newEnvelope.EnvelopeTypeID;
    this.SetCurrentEnvelopeMeasurements();
    this.UpdateEnvelopeDisplay();
    this.LoadSavedEnvelopeSettings();
    this.SetFeedMethods();
    this.cboEnvelopeType.ValueChanged += new EventHandler(this.cboEnvelopeType_ValueChanged);
  }

  private void btnOk_Click(object sender, EventArgs e)
  {
    if (MessageBox.Show("Do you want to save your envelope settings", "Save Envelope Settings", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
      this.SaveEnvelopeSettings();
    this.Close();
  }

  private void btnCancel_Click(object sender, EventArgs e) => this.Close();

  private void UpDownDeliveryAddressFromLeft_ValueChanged(object sender, EventArgs e)
  {
    this._newEnvelope.DeliveryAddress.fromLeft = Convert.ToSingle(this.UpDownDeliveryAddressFromLeft.Value);
    this.UpdateEnvelopeDisplay();
  }

  private void UpDownDeliveryAddressFromTop_ValueChanged(object sender, EventArgs e)
  {
    this._newEnvelope.DeliveryAddress.fromTop = Convert.ToSingle(this.UpDownDeliveryAddressFromTop.Value);
    this.UpdateEnvelopeDisplay();
  }

  private void UpDownReturnAddressFromLeft_ValueChanged(object sender, EventArgs e)
  {
    this._newEnvelope.ReturnAddress.fromLeft = Convert.ToSingle(this.UpDownReturnAddressFromLeft.Value);
    this.UpdateEnvelopeDisplay();
  }

  private void UpDownReturnAddressFromTop_ValueChanged(object sender, EventArgs e)
  {
    this._newEnvelope.ReturnAddress.fromTop = Convert.ToSingle(this.UpDownReturnAddressFromTop.Value);
    this.UpdateEnvelopeDisplay();
  }

  private void cboEnvelopeType_ValueChanged(object sender, EventArgs e)
  {
    int integer = Conversions.ToInteger(this.cboEnvelopeType.Value);
    if (this == null || this._envelopeTypes.FindByEnvelopeTypeID(integer) == null)
      return;
    dsEnvelopes.tblEnvelopeTypesRow byEnvelopeTypeId = this._envelopeTypes.FindByEnvelopeTypeID(integer);
    this._newEnvelope.Height = Convert.ToSingle(byEnvelopeTypeId.Height);
    this._newEnvelope.Width = Convert.ToSingle(byEnvelopeTypeId.Width);
    this.UpDownDeliveryAddressFromLeft.CausesValidation = false;
    this.UpDownDeliveryAddressFromLeft.Maximum = byEnvelopeTypeId.DeliveryAddressFromLeftMAX;
    this.UpDownDeliveryAddressFromLeft.Minimum = byEnvelopeTypeId.DeliveryAddressFromLeftMIN;
    this.UpDownDeliveryAddressFromLeft.Value = byEnvelopeTypeId.DeliveryAddressFromLeft;
    this.UpDownDeliveryAddressFromLeft.CausesValidation = true;
    this.UpDownDeliveryAddressFromTop.CausesValidation = false;
    this.UpDownDeliveryAddressFromTop.Maximum = byEnvelopeTypeId.DeliveryAddressFromTopMAX;
    this.UpDownDeliveryAddressFromTop.Minimum = byEnvelopeTypeId.DeliveryAddressFromTopMIN;
    this.UpDownDeliveryAddressFromTop.Value = byEnvelopeTypeId.DeliveryAddressFromTop;
    this.UpDownDeliveryAddressFromTop.CausesValidation = true;
    this.UpDownReturnAddressFromLeft.CausesValidation = false;
    this.UpDownReturnAddressFromLeft.Maximum = byEnvelopeTypeId.ReturnAddressFromLeftMAX;
    this.UpDownReturnAddressFromLeft.Minimum = byEnvelopeTypeId.ReturnAddressFromLeftMIN;
    this.UpDownReturnAddressFromLeft.Value = byEnvelopeTypeId.ReturnAddressFromLeft;
    this.UpDownReturnAddressFromLeft.CausesValidation = true;
    this.UpDownReturnAddressFromTop.CausesValidation = false;
    this.UpDownReturnAddressFromTop.Maximum = byEnvelopeTypeId.ReturnAddressFromTopMAX;
    this.UpDownReturnAddressFromTop.Minimum = byEnvelopeTypeId.ReturnAddressFromTopMIN;
    this.UpDownReturnAddressFromTop.Value = byEnvelopeTypeId.ReturnAddressFromTop;
    this.UpDownReturnAddressFromTop.CausesValidation = true;
    this.LoadSavedEnvelopeSettings();
  }

  private void rbFaceUp_CheckedChanged(object sender, EventArgs e)
  {
    if (!this.rbFaceUp.Checked)
      return;
    this._newEnvelope.Face = Envelope.EnvelopeFace.up;
    this.SetFeedMethods();
  }

  private void rbFaceDown_CheckedChanged(object sender, EventArgs e)
  {
    if (!this.rbFaceDown.Checked)
      return;
    this._newEnvelope.Face = Envelope.EnvelopeFace.down;
    this.SetFeedMethods();
  }

  private void env1_Click(object sender, EventArgs e)
  {
    this._newEnvelope.FeedMethod = Envelope.EnvelopeFeedMethod.envelope_feed_1;
    this.SetFeedMethods();
  }

  private void env2_Click(object sender, EventArgs e)
  {
    this._newEnvelope.FeedMethod = Envelope.EnvelopeFeedMethod.envelope_feed_2;
    this.SetFeedMethods();
  }

  private void env3_Click(object sender, EventArgs e)
  {
    this._newEnvelope.FeedMethod = Envelope.EnvelopeFeedMethod.envelope_feed_3;
    this.SetFeedMethods();
  }

  private void env4_Click(object sender, EventArgs e)
  {
    this._newEnvelope.FeedMethod = Envelope.EnvelopeFeedMethod.envelope_feed_4;
    this.SetFeedMethods();
  }

  private void env5_Click(object sender, EventArgs e)
  {
    this._newEnvelope.FeedMethod = Envelope.EnvelopeFeedMethod.envelope_feed_5;
    this.SetFeedMethods();
  }

  private void env6_Click(object sender, EventArgs e)
  {
    this._newEnvelope.FeedMethod = Envelope.EnvelopeFeedMethod.envelope_feed_6;
    this.SetFeedMethods();
  }

  public Envelope NewEnvelope => this._newEnvelope;

  private void btnDeliveryAddressFont_Click(object sender, EventArgs e)
  {
    FontDialog fontDialog = new FontDialog();
    fontDialog.ShowApply = true;
    fontDialog.ShowEffects = true;
    fontDialog.ShowHelp = true;
    if (fontDialog.ShowDialog() != DialogResult.OK)
      return;
    this._newEnvelope.DeliveryAddress.Font = fontDialog.Font;
  }

  private void btnReturnAddressFont_Click(object sender, EventArgs e)
  {
    FontDialog fontDialog = new FontDialog();
    fontDialog.ShowApply = true;
    fontDialog.ShowEffects = true;
    fontDialog.ShowHelp = true;
    if (fontDialog.ShowDialog() != DialogResult.OK)
      return;
    this._newEnvelope.ReturnAddress.Font = fontDialog.Font;
  }
}
