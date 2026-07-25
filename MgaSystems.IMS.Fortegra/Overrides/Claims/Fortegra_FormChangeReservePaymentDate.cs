// Decompiled with JetBrains decompiler
// Type: MgaSystems.Ims.Fortegra.Overrides.Claims.Fortegra_FormChangeReservePaymentDate
// Assembly: MgaSystems.Ims.Fortegra, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 27007E94-85B4-4A1A-9444-255CCA5487B0
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Fortegra.dll

using MGASystems.Common;
using MGASystems.Data;
using MGASystems.IMS.Claims;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace MgaSystems.Ims.Fortegra.Overrides.Claims;

[Override(typeof (FormChangeReservePaymentDate))]
public class Fortegra_FormChangeReservePaymentDate : FormChangeReservePaymentDate
{
  private IContainer components;

  public Fortegra_FormChangeReservePaymentDate() => this.InitializeComponent();

  protected override void Save()
  {
    if (!this.VerifyForm())
      return;
    DefaultDatabase.ExecuteNonQuery("Fortegra_spClaims_UpdateReservePaymentDate", new object[4]
    {
      (object) "@ResPayId",
      (object) this.ResPayId,
      (object) "@newDate",
      (object) this.dateTimeDate.DateTime
    });
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    ((ISupportInitialize) this.dateTimeDate).BeginInit();
    this.SuspendLayout();
    ((Control) this.dateTimeDate).Margin = new Padding(2, 2, 2, 2);
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(194, 76);
    this.Margin = new Padding(2, 2, 2, 2);
    this.Name = nameof (Fortegra_FormChangeReservePaymentDate);
    this.ShowIcon = false;
    ((ISupportInitialize) this.dateTimeDate).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }
}
