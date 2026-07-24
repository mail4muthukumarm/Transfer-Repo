// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Forms.frmIssueEndorsementDate
// Assembly: MgaSystems.IMS.Forms, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FB3F392E-40B6-486F-8F0B-A4A494A546D4
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Forms.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using MGASystems.Common.DataAccess;
using MGASystems.Tools;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Forms;

public class frmIssueEndorsementDate : Form
{
  private IContainer components;
  private bool _OK;

  public frmIssueEndorsementDate()
  {
    this.Load += new EventHandler(this.frmIssueEndorsementDate_Load);
    this.InitializeComponent();
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  [field: AccessedThroughProperty("Label2")]
  internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label4")]
  internal virtual Label Label4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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

  internal virtual MGAButton btnCancel
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

  [field: AccessedThroughProperty("err")]
  internal virtual ErrorProvider err { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("dtIssueDate")]
  private virtual MGADateTimePicker dtIssueDate { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    this.Label2 = new Label();
    this.dtIssueDate = new MGADateTimePicker();
    this.Label4 = new Label();
    this.btnSave = new MGAButton();
    this.btnCancel = new MGAButton();
    this.err = new ErrorProvider();
    ((ISupportInitialize) this.dtIssueDate).BeginInit();
    ((ISupportInitialize) this.btnSave).BeginInit();
    ((ISupportInitialize) this.btnCancel).BeginInit();
    this.SuspendLayout();
    this.Label2.AutoSize = true;
    this.Label2.Location = new Point(8, 8);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(266, 17);
    this.Label2.TabIndex = 1;
    this.Label2.Text = "Please select an issuance date for this endorsement.";
    ((Control) this.dtIssueDate).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
    appearance1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.dtIssueDate.Appearance = (AppearanceBase) appearance1;
    appearance2.AlphaLevel = (short) 14;
    appearance2.BackColor = Color.FromArgb(0, 0, 246, 253);
    appearance2.BackColor2 = Color.FromArgb(133, 162, 221);
    appearance2.BackColorAlpha = (Alpha) 2;
    appearance2.BackGradientAlignment = (GradientAlignment) 4;
    appearance2.BackGradientStyle = (GradientStyle) 5;
    appearance2.BorderAlpha = (Alpha) 1;
    appearance2.BorderColor = Color.FromArgb(78, 122, 171);
    appearance2.ForeColor = Color.FromArgb(49, 85, 153);
    appearance2.ForegroundAlpha = (Alpha) 2;
    this.dtIssueDate.ButtonAppearance = (AppearanceBase) appearance2;
    ((Control) this.dtIssueDate).Location = new Point(144 /*0x90*/, 46);
    this.dtIssueDate.MGAStyle = MGAStyles.Blue;
    ((Control) this.dtIssueDate).Name = "dtIssueDate";
    ((Control) this.dtIssueDate).Size = new Size(128 /*0x80*/, 20);
    ((Control) this.dtIssueDate).TabIndex = 21;
    this.Label4.AutoSize = true;
    this.Label4.Location = new Point(24, 48 /*0x30*/);
    this.Label4.Name = "Label4";
    this.Label4.Size = new Size(110, 17);
    this.Label4.TabIndex = 22;
    this.Label4.Text = "Endorsement Issued:";
    this.Label4.TextAlign = ContentAlignment.MiddleRight;
    appearance3.BackColor = Color.FromArgb(248, 248, 248);
    appearance3.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance3.BackGradientStyle = (GradientStyle) 2;
    appearance3.BorderColor = Color.DarkGray;
    appearance3.ImageHAlign = (HAlign) 2;
    appearance3.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnSave).Appearance = (AppearanceBase) appearance3;
    ((ControlBase) this.btnSave).ImageSize = new Size(24, 24);
    ((Control) this.btnSave).Location = new Point(232, 88);
    ((Control) this.btnSave).Name = "btnSave";
    ((Control) this.btnSave).TabIndex = 33;
    ((Control) this.btnSave).Tag = (object) "KeepEnabled";
    appearance4.BackColor = Color.FromArgb(248, 248, 248);
    appearance4.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance4.BackGradientStyle = (GradientStyle) 2;
    appearance4.BorderColor = Color.DarkGray;
    appearance4.ImageHAlign = (HAlign) 2;
    appearance4.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnCancel).Appearance = (AppearanceBase) appearance4;
    ((ControlBase) this.btnCancel).ImageSize = new Size(24, 24);
    ((Control) this.btnCancel).Location = new Point(176 /*0xB0*/, 88);
    ((Control) this.btnCancel).Name = "btnCancel";
    ((Control) this.btnCancel).TabIndex = 34;
    ((Control) this.btnCancel).Tag = (object) "KeepEnabled";
    this.err.ContainerControl = (ContainerControl) this;
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.White;
    this.ClientSize = new Size(282, 144 /*0x90*/);
    this.Controls.Add((Control) this.btnCancel);
    this.Controls.Add((Control) this.btnSave);
    this.Controls.Add((Control) this.Label4);
    this.Controls.Add((Control) this.dtIssueDate);
    this.Controls.Add((Control) this.Label2);
    this.Font = new Font("Tahoma", 8.25f);
    this.ForeColor = Color.Black;
    this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
    this.Name = nameof (frmIssueEndorsementDate);
    this.Text = "Issue Endorsement - Select a Date";
    ((ISupportInitialize) this.dtIssueDate).EndInit();
    ((ISupportInitialize) this.btnSave).EndInit();
    ((ISupportInitialize) this.btnCancel).EndInit();
    this.ResumeLayout(false);
  }

  public bool ClickedSave => this._OK;

  public DateTime IssueDateChosen => (DateTime) this.dtIssueDate.Value;

  private void frmIssueEndorsementDate_Load(object sender, EventArgs e)
  {
    ((ControlBase) this.btnSave).Appearance.Image = (object) ImageCache.Instance.Save;
    ((ControlBase) this.btnCancel).Appearance.Image = (object) ImageCache.Instance.Undo;
  }

  private bool ValidateForm()
  {
    bool flag = true;
    if (DateTime.Compare((DateTime) this.dtIssueDate.Value, DateTime.MinValue) < 0 || Database.IsValueNull(RuntimeHelpers.GetObjectValue(this.dtIssueDate.Value)) || DateTime.Compare((DateTime) this.dtIssueDate.Value, DateTime.MaxValue) > 0)
    {
      this.err.SetError((Control) this.dtIssueDate, "Invalid Date");
      flag = false;
    }
    else
      this.err.SetError((Control) this.dtIssueDate, string.Empty);
    return flag;
  }

  private void btnSave_Click(object sender, EventArgs e)
  {
    if (!this.ValidateForm())
      return;
    this._OK = true;
    this.Close();
  }

  private void btnCancel_Click(object sender, EventArgs e)
  {
    this._OK = false;
    this.Close();
  }
}
