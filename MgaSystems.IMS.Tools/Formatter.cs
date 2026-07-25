// Decompiled with JetBrains decompiler
// Type: MGASystems.Tools.Formatter
// Assembly: MgaSystems.IMS.Tools, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 1287D1AD-C908-42E9-BE8F-4574B2D0AB9E
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Tools.dll

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.Tools;

[DefaultEvent("Format")]
[ToolboxBitmap(typeof (Label))]
public class Formatter : Component
{
  private IContainer components;
  private string _bindingName;
  private Control _control;
  private bool _eventsHooked;
  private FormatStyle _formatStyle;

  public Formatter(IContainer container)
    : this()
  {
    if (container == null)
      throw new ArgumentNullException(nameof (container));
    container.Add((IComponent) this);
  }

  public Formatter()
  {
    this._bindingName = "Text";
    this._formatStyle = FormatStyle.UserDefined;
    this.InitializeComponent();
  }

  [DebuggerStepThrough]
  private void InitializeComponent() => this.components = (IContainer) new System.ComponentModel.Container();

  public event ConvertEventHandler Format;

  public event ConvertEventHandler Parse;

  [SuppressMessage("Microsoft.Security", "CA2109:ReviewVisibleEventHandlers")]
  protected virtual void OnFormat(object sender, ConvertEventArgs e)
  {
    // ISSUE: reference to a compiler-generated field
    ConvertEventHandler formatEvent = this.FormatEvent;
    if (formatEvent == null)
      return;
    formatEvent(RuntimeHelpers.GetObjectValue(sender), e);
  }

  [SuppressMessage("Microsoft.Security", "CA2109:ReviewVisibleEventHandlers")]
  protected virtual void OnParse(object sender, ConvertEventArgs e)
  {
    // ISSUE: reference to a compiler-generated field
    ConvertEventHandler parseEvent = this.ParseEvent;
    if (parseEvent == null)
      return;
    parseEvent(RuntimeHelpers.GetObjectValue(sender), e);
  }

  [DefaultValue("Text")]
  [Category("Behavior")]
  [Description("The name of the databinding to format")]
  public string BindingName
  {
    get => this._bindingName;
    set
    {
      if (Operators.CompareString(this._bindingName, value, false) == 0)
        return;
      if (this._control != null && this._eventsHooked)
      {
        this.DisconnectEvents();
        this._bindingName = value;
        this.ConnectEvents();
      }
      else
        this._bindingName = value;
    }
  }

  [DefaultValue(typeof (FormatStyle), "UserDefined")]
  [Category("Behavior")]
  [Description("The style of format to use, if userdefined you must handle the format and parse events")]
  public FormatStyle FormatStyle
  {
    get => this._formatStyle;
    set => this._formatStyle = value;
  }

  private bool ShouldSerializeControl() => this._control != null;

  private void ResetControl() => this._control = (Control) null;

  [Category("Behavior")]
  [Description("Control to format")]
  public Control Control
  {
    get => this._control;
    set
    {
      if (this._control == value)
        return;
      this._control = value;
      if (this.DesignMode)
        return;
      if (this._control == null)
      {
        this.DisconnectEvents();
        this._eventsHooked = false;
      }
      else
      {
        this._eventsHooked = true;
        this.ConnectEvents();
      }
    }
  }

  private void ConnectEvents()
  {
    this._control.DataBindings[this.BindingName].Format += new ConvertEventHandler(this.InternalFormat);
    this._control.DataBindings[this.BindingName].Parse += new ConvertEventHandler(this.InternalParse);
  }

  private void DisconnectEvents()
  {
    this._control.DataBindings[this.BindingName].Format -= new ConvertEventHandler(this.InternalFormat);
    this._control.DataBindings[this.BindingName].Parse -= new ConvertEventHandler(this.InternalParse);
  }

  protected override void Dispose(bool disposing)
  {
    if (this._control != null)
    {
      if (this._eventsHooked)
        this.DisconnectEvents();
      this._control = (Control) null;
    }
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private void InternalFormat(object sender, ConvertEventArgs e)
  {
    switch (this._formatStyle)
    {
      case FormatStyle.Currency:
        if (e.Value == DBNull.Value || (object) e.DesiredType != (object) typeof (string))
          break;
        e.Value = (object) Conversions.ToDecimal(e.Value).ToString("c");
        break;
      case FormatStyle.Percent:
        if (e.Value == DBNull.Value || (object) e.DesiredType != (object) typeof (string))
          break;
        e.Value = (object) Conversions.ToDecimal(e.Value).ToString("%#,##0.00##");
        break;
      case FormatStyle.UserDefined:
        if (e.Value == DBNull.Value)
          break;
        this.OnFormat(RuntimeHelpers.GetObjectValue(sender), e);
        break;
    }
  }

  private void InternalParse(object sender, ConvertEventArgs e)
  {
    switch (this._formatStyle)
    {
      case FormatStyle.Currency:
        if (e.Value == DBNull.Value || (object) e.DesiredType != (object) typeof (Decimal))
          break;
        e.Value = (object) Conversions.ToDecimal(e.Value.ToString().Replace("$", ""));
        break;
      case FormatStyle.Percent:
        if (e.Value == DBNull.Value || (object) e.DesiredType != (object) typeof (Decimal))
          break;
        e.Value = (object) Conversions.ToDecimal(e.Value.ToString().Replace("%", ""));
        break;
      case FormatStyle.UserDefined:
        if (e.Value == DBNull.Value)
          break;
        this.OnParse(RuntimeHelpers.GetObjectValue(sender), e);
        break;
    }
  }
}
