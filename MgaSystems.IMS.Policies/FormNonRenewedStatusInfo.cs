// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.FormNonRenewedStatusInfo
// Assembly: MgaSystems.IMS.Policies, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 2FF2C709-F7BF-41DA-82BD-FF6319CA235D
// Assembly location: C:\Users\muthu\Downloads\MgaSystems.IMS.Policies.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using MGASystems.BusinessObjects;
using MGASystems.Data;
using MGASystems.Tools;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Policies;

[DesignerGenerated]
public class FormNonRenewedStatusInfo : Form
{
  private IContainer components;
  private Guid _QuoteGuid;
  private int _QuoteID;
  private int _NewQuoteStatusID;
  private Quote _quote;

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
    this.dtpMailingDate = new MGADateTimePicker();
    this.Label1 = new Label();
    this.btnSave = new MGAButton();
    ((ISupportInitialize) this.dtpMailingDate).BeginInit();
    ((ISupportInitialize) this.btnSave).BeginInit();
    this.SuspendLayout();
    appearance1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraDateTimeEditor) this.dtpMailingDate).Appearance = (AppearanceBase) appearance1;
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
    ((UltraDateTimeEditor) this.dtpMailingDate).ButtonAppearance = (AppearanceBase) appearance2;
    ((Control) this.dtpMailingDate).Location = new Point(107, 36);
    this.dtpMailingDate.MGAStyle = (MGAStyles) 2;
    ((Control) this.dtpMailingDate).Name = "dtpMailingDate";
    ((Control) this.dtpMailingDate).Size = new Size(117, 19);
    ((Control) this.dtpMailingDate).TabIndex = 9;
    ((UltraControlBase) this.dtpMailingDate).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dtpMailingDate).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDateTimeEditor) this.dtpMailingDate).Value = (object) null;
    this.Label1.AutoSize = true;
    this.Label1.Location = new Point(27, 39);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(69, 13);
    this.Label1.TabIndex = 10;
    this.Label1.Text = "Mailing Date:";
    ((Control) this.btnSave).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance3.ImageHAlign = (HAlign) 2;
    appearance3.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnSave).Appearance = (AppearanceBase) appearance3;
    ((ControlBase) this.btnSave).ImageSize = new Size(24, 24);
    ((ControlBase) this.btnSave).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnSave).Location = new Point(107, 129);
    ((Control) this.btnSave).Name = "btnSave";
    ((Control) this.btnSave).Size = new Size(40, 40);
    ((Control) this.btnSave).TabIndex = 25;
    this.btnSave.UseOSThemes = (DefaultableBoolean) 2;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    this.ClientSize = new Size(279, 181);
    this.Controls.Add((Control) this.btnSave);
    this.Controls.Add((Control) this.Label1);
    this.Controls.Add((Control) this.dtpMailingDate);
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (FormNonRenewedStatusInfo);
    this.Text = "Non-Renewed Status Info";
    ((ISupportInitialize) this.dtpMailingDate).EndInit();
    ((ISupportInitialize) this.btnSave).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  [field: AccessedThroughProperty("dtpMailingDate")]
  protected virtual MGADateTimePicker dtpMailingDate { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label1")]
  internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual MGAButton btnSave
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

  public FormNonRenewedStatusInfo()
  {
    this.Load += new EventHandler(this.FormNonRenewedStatusInfo_Load);
    this.InitializeComponent();
  }

  public FormNonRenewedStatusInfo(Guid quoteGuid, int quoteStatusID)
  {
    this.Load += new EventHandler(this.FormNonRenewedStatusInfo_Load);
    this.InitializeComponent();
    this._QuoteGuid = quoteGuid;
    this._NewQuoteStatusID = quoteStatusID;
    this._quote = new Quote(quoteGuid);
    this._QuoteID = this._quote.QuoteID;
  }

  private void FormNonRenewedStatusInfo_Load(object sender, EventArgs e)
  {
    ((ControlBase) this.btnSave).Appearance.Image = (object) ImageCache.Instance.Save;
    ((UltraDateTimeEditor) this.dtpMailingDate).Value = RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT NonRenewedMailingDate FROM dbo.tblQuotes2 WHERE QuoteID = @QID", new object[2]
    {
      (object) "@QID",
      (object) this._QuoteID
    }));
  }

  private void btnSave_Click(object sender, EventArgs e)
  {
    DefaultDatabase.ExecuteNonQuery("dbo.spSaveNonRenewedStatusInfo", new object[4]
    {
      (object) "@QuoteID",
      (object) this._QuoteID,
      (object) "@NonRenewedMailingDate",
      ((UltraDateTimeEditor) this.dtpMailingDate).Value
    });
    this.Close();
  }
}
