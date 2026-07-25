// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Endorsements.EndorsementInfo
// Assembly: MgaSystems.IMS.Policies, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 2FF2C709-F7BF-41DA-82BD-FF6319CA235D
// Assembly location: C:\Users\muthu\Downloads\MgaSystems.IMS.Policies.dll

using Infragistics.Win;
using Infragistics.Win.UltraWinEditors;
using MGASystems.BusinessObjects;
using MGASystems.BusinessObjects.Rating;
using MGASystems.Common.Enums;
using MGASystems.Tools;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Policies.Endorsements;

public sealed class EndorsementInfo : UserControl
{
  private IContainer components;
  private MGATextBox txtComment;
  private MGADateTimePicker dtEffective;
  private Label Label1;
  private RadioButton rbFlat;
  private RadioButton rbProRata;
  private Label Label2;
  private RadioButton rbShortRate;
  private RadioButton rbMinEarned;

  public EndorsementInfo()
  {
    this.Load += new EventHandler(this.EndorsementInfo_Load);
    this.InitializeComponent();
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  [field: AccessedThroughProperty("lblComment")]
  protected virtual Label lblComment { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    this.txtComment = new MGATextBox();
    this.lblComment = new Label();
    this.dtEffective = new MGADateTimePicker();
    this.Label1 = new Label();
    this.rbFlat = new RadioButton();
    this.rbProRata = new RadioButton();
    this.Label2 = new Label();
    this.rbShortRate = new RadioButton();
    this.rbMinEarned = new RadioButton();
    ((ISupportInitialize) this.txtComment).BeginInit();
    ((ISupportInitialize) this.dtEffective).BeginInit();
    this.SuspendLayout();
    appearance1.BackColor = Color.White;
    appearance1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance1.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtComment).Appearance = (AppearanceBase) appearance1;
    ((TextEditorControlBase) this.txtComment).BackColor = Color.White;
    ((Control) this.txtComment).Location = new Point(136, 36);
    ((TextEditorControlBase) this.txtComment).MaxLength = 250;
    this.txtComment.MGAStyle = (MGAStyles) 2;
    ((Control) this.txtComment).Name = "txtComment";
    ((Control) this.txtComment).Size = new Size(203, 20);
    ((Control) this.txtComment).TabIndex = 7;
    ((UltraControlBase) this.txtComment).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtComment).UseOsThemes = (DefaultableBoolean) 2;
    this.lblComment.Location = new Point(72, 38);
    this.lblComment.Name = "lblComment";
    this.lblComment.Size = new Size(56, 16 /*0x10*/);
    this.lblComment.TabIndex = 6;
    this.lblComment.Text = "Comment:";
    this.lblComment.TextAlign = ContentAlignment.MiddleRight;
    appearance2.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraDateTimeEditor) this.dtEffective).Appearance = (AppearanceBase) appearance2;
    appearance3.AlphaLevel = (short) 14;
    appearance3.BackColor = Color.FromArgb(0, 0, 246, 253);
    appearance3.BackColor2 = Color.FromArgb(133, 162, 221);
    appearance3.BackColorAlpha = (Alpha) 2;
    appearance3.BackGradientAlignment = (GradientAlignment) 4;
    appearance3.BackGradientStyle = (GradientStyle) 5;
    appearance3.BorderAlpha = (Alpha) 1;
    appearance3.BorderColor = Color.FromArgb(78, 122, 171);
    appearance3.ForeColor = Color.FromArgb(49, 85, 153);
    appearance3.ForegroundAlpha = (Alpha) 2;
    ((UltraDateTimeEditor) this.dtEffective).ButtonAppearance = (AppearanceBase) appearance3;
    ((UltraDateTimeEditor) this.dtEffective).FormatString = "D";
    ((Control) this.dtEffective).Location = new Point(136, 8);
    this.dtEffective.MGAStyle = (MGAStyles) 2;
    ((Control) this.dtEffective).Name = "dtEffective";
    ((Control) this.dtEffective).Size = new Size(200, 20);
    ((Control) this.dtEffective).TabIndex = 5;
    ((UltraControlBase) this.dtEffective).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dtEffective).UseOsThemes = (DefaultableBoolean) 2;
    this.Label1.AutoSize = true;
    this.Label1.Location = new Point(8, 10);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(120, 13);
    this.Label1.TabIndex = 4;
    this.Label1.Text = "Endorsement Effective:";
    this.Label1.TextAlign = ContentAlignment.MiddleRight;
    this.rbFlat.Location = new Point(296, 64 /*0x40*/);
    this.rbFlat.Name = "rbFlat";
    this.rbFlat.Size = new Size(56, 24);
    this.rbFlat.TabIndex = 16 /*0x10*/;
    this.rbFlat.Text = "Flat";
    this.rbProRata.Checked = true;
    this.rbProRata.Location = new Point(136, 64 /*0x40*/);
    this.rbProRata.Name = "rbProRata";
    this.rbProRata.Size = new Size(70, 24);
    this.rbProRata.TabIndex = 14;
    this.rbProRata.TabStop = true;
    this.rbProRata.Text = "Pro-Rata";
    this.Label2.AutoSize = true;
    this.Label2.Location = new Point(36, 68);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(90, 13);
    this.Label2.TabIndex = 13;
    this.Label2.Text = "Calculation Type:";
    this.Label2.TextAlign = ContentAlignment.MiddleRight;
    this.rbShortRate.Location = new Point(208 /*0xD0*/, 64 /*0x40*/);
    this.rbShortRate.Name = "rbShortRate";
    this.rbShortRate.Size = new Size(82, 24);
    this.rbShortRate.TabIndex = 15;
    this.rbShortRate.Text = "Short-Rate";
    this.rbMinEarned.Location = new Point(136, 88);
    this.rbMinEarned.Name = "rbMinEarned";
    this.rbMinEarned.Size = new Size(112 /*0x70*/, 24);
    this.rbMinEarned.TabIndex = 17;
    this.rbMinEarned.Text = "Minimum Earned";
    this.Controls.Add((Control) this.rbMinEarned);
    this.Controls.Add((Control) this.rbFlat);
    this.Controls.Add((Control) this.rbShortRate);
    this.Controls.Add((Control) this.rbProRata);
    this.Controls.Add((Control) this.Label2);
    this.Controls.Add((Control) this.txtComment);
    this.Controls.Add((Control) this.lblComment);
    this.Controls.Add((Control) this.dtEffective);
    this.Controls.Add((Control) this.Label1);
    this.Font = new Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Name = nameof (EndorsementInfo);
    this.Size = new Size(360, 112 /*0x70*/);
    ((ISupportInitialize) this.txtComment).EndInit();
    ((ISupportInitialize) this.dtEffective).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  public EndorsementCalcTypes EndorsementCalcType
  {
    get
    {
      if (this.rbFlat.Checked)
        return (EndorsementCalcTypes) 3;
      if (this.rbProRata.Checked)
        return (EndorsementCalcTypes) 1;
      if (this.rbMinEarned.Checked)
        return (EndorsementCalcTypes) 4;
      if (this.rbShortRate.Checked)
        return (EndorsementCalcTypes) 2;
      throw new InvalidOperationException("Unexpected EndorsementCalcType");
    }
    set
    {
      switch (value - 1)
      {
        case 0:
          this.rbProRata.Checked = true;
          break;
        case 1:
          this.rbShortRate.Checked = true;
          break;
        case 2:
          this.rbFlat.Checked = true;
          break;
        case 3:
          this.rbMinEarned.Checked = true;
          break;
        default:
          throw new InvalidOperationException("Unexpected EndorsementCalcType");
      }
    }
  }

  public DateTime EffectiveDate
  {
    get
    {
      return ((UltraDateTimeEditor) this.dtEffective).Value != null ? ((UltraDateTimeEditor) this.dtEffective).DateTime : DateTime.MinValue;
    }
    set => ((UltraDateTimeEditor) this.dtEffective).DateTime = value;
  }

  public string Comment
  {
    get => ((TextEditorControlBase) this.txtComment).Text;
    set => ((TextEditorControlBase) this.txtComment).Text = value;
  }

  public string CommentLabelText
  {
    get => this.lblComment.Text;
    set => this.lblComment.Text = value;
  }

  private void EndorsementInfo_Load(object sender, EventArgs e)
  {
    ((UltraDateTimeEditor) this.dtEffective).Value = (object) DateAndTime.Now.Date;
  }

  public void ClearEffectiveDate()
  {
    ((UltraDateTimeEditor) this.dtEffective).Value = (object) null;
  }

  public void CalculationTypeVisibility(Guid quoteGuid)
  {
    List<CreateEndorsementOptions> endorsementOptions = new Quote(quoteGuid).GetCreateEndorsementOptions();
    Func<CreateEndorsementOptions, bool> predicate;
    // ISSUE: reference to a compiler-generated field
    if (EndorsementInfo._Closure\u0024__.\u0024I30\u002D0 != null)
    {
      // ISSUE: reference to a compiler-generated field
      predicate = EndorsementInfo._Closure\u0024__.\u0024I30\u002D0;
    }
    else
    {
      // ISSUE: reference to a compiler-generated field
      EndorsementInfo._Closure\u0024__.\u0024I30\u002D0 = predicate = (Func<CreateEndorsementOptions, bool>) ([SpecialName] (createEndorsementOptions) => createEndorsementOptions.CalculationType == 0);
    }
    if (!endorsementOptions.All<CreateEndorsementOptions>(predicate))
      return;
    this.Label2.Visible = false;
    this.rbProRata.Visible = false;
    this.rbShortRate.Visible = false;
    this.rbFlat.Visible = false;
    this.rbMinEarned.Visible = false;
    this.lblComment.Location = new Point(this.lblComment.Location.X, this.lblComment.Location.Y + 25);
    ((Control) this.txtComment).Location = new Point(((Control) this.txtComment).Location.X, ((Control) this.txtComment).Location.Y + 25);
  }
}
