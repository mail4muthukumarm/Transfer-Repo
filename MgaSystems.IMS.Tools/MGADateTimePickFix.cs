// Decompiled with JetBrains decompiler
// Type: MGASystems.Tools.MGADateTimePickFix
// Assembly: MgaSystems.IMS.Tools, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 1287D1AD-C908-42E9-BE8F-4574B2D0AB9E
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Tools.dll

using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.Tools;

[ToolboxBitmap(typeof (DateTimePicker))]
public sealed class MGADateTimePickFix : DateTimePicker
{
  [SuppressMessage("Microsoft.Design", "CA1061:DoNotHideBaseClassMethods")]
  [Bindable(true)]
  [Browsable(false)]
  [Category("Behavior")]
  [Description("Custom value property")]
  public object Value
  {
    get => !this.ShowCheckBox || this.Checked ? (object) base.Value : (object) null;
    set
    {
      if (((this.ShowCheckBox ? 1 : 0) & (value == DBNull.Value ? 1 : (value == null ? 1 : 0))) != 0)
      {
        if (!this.Checked)
          return;
        this.Value = DateTime.Now;
        this.Checked = false;
      }
      else
      {
        this.Checked = true;
        this.Value = (DateTime) value;
      }
    }
  }

  [Bindable(true)]
  [Category("Behavior")]
  [Description("Custom formmat property")]
  public new DateTimePickerFormat Format
  {
    get
    {
      base.Format = DateTimePickerFormat.Custom;
      this.CustomFormat = "";
      return base.Format;
    }
    set
    {
      base.Format = DateTimePickerFormat.Custom;
      this.CustomFormat = "";
    }
  }

  public void ResetFormat() => this.Format = DateTimePickerFormat.Short;

  public bool ShouldSerializeFormat() => this.Format != DateTimePickerFormat.Short;

  [SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
  [Browsable(true)]
  [DefaultValue(true)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  private new bool ShowCheckBox
  {
    get => true;
    set => base.ShowCheckBox = true;
  }

  public MGADateTimePickFix()
  {
    base.ShowCheckBox = true;
    base.Format = DateTimePickerFormat.Custom;
    this.CustomFormat = "";
  }
}
