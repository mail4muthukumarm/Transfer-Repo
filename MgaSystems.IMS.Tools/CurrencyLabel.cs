// Decompiled with JetBrains decompiler
// Type: MGASystems.Tools.CurrencyLabel
// Assembly: MgaSystems.IMS.Tools, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 1287D1AD-C908-42E9-BE8F-4574B2D0AB9E
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Tools.dll

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.Tools;

[ToolboxBitmap(typeof (Label))]
public sealed class CurrencyLabel : Label
{
  private bool _hooked;

  private void DecimalToCurrencyString(object sender, ConvertEventArgs cevent)
  {
    if (cevent.Value == DBNull.Value || !Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(cevent.Value)))
      return;
    cevent.Value = (object) Strings.FormatCurrency(RuntimeHelpers.GetObjectValue(cevent.Value));
  }

  [SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes")]
  protected override void OnPaint(PaintEventArgs e)
  {
    if (!this._hooked)
    {
      this._hooked = true;
      try
      {
        Binding dataBinding = this.DataBindings["Text"];
        if (dataBinding != null)
          dataBinding.Format += new ConvertEventHandler(this.DecimalToCurrencyString);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }
    base.OnPaint(e);
  }

  [SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes")]
  protected override void Dispose(bool disposing)
  {
    if (this._hooked)
    {
      try
      {
        Binding dataBinding = this.DataBindings["Text"];
        if (dataBinding != null)
          dataBinding.Format -= new ConvertEventHandler(this.DecimalToCurrencyString);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }
    base.Dispose(disposing);
  }
}
