// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.PreferenceAttribute
// Assembly: MgaSystems.IMS.Common, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 46CE8D79-2C19-419C-BC23-F8C69E623B17
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.dll

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;

#nullable disable
namespace MGASystems.Common;

[AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
public sealed class PreferenceAttribute : Attribute
{
  private object _defaultValue;
  private bool _local;
  private string _name;

  public bool Local => this._local;

  [EditorBrowsable(EditorBrowsableState.Never)]
  public PreferenceAttribute()
  {
  }

  public PreferenceAttribute(string name, int defaultValue)
  {
    this._defaultValue = (object) defaultValue;
    this._name = name;
  }

  public PreferenceAttribute(string name, long defaultValue)
  {
    this._defaultValue = (object) defaultValue;
    this._name = name;
  }

  public PreferenceAttribute(string name, float defaultValue)
  {
    this._defaultValue = (object) defaultValue;
    this._name = name;
  }

  public PreferenceAttribute(string name, double defaultValue)
  {
    this._defaultValue = (object) defaultValue;
    this._name = name;
  }

  public PreferenceAttribute(string name, Decimal defaultValue)
  {
    this._defaultValue = (object) defaultValue;
    this._name = name;
  }

  public PreferenceAttribute(string name, string defaultValue)
  {
    this._defaultValue = (object) defaultValue;
    this._name = name;
  }

  public PreferenceAttribute(string name, Type enumType, string defaultEnumValue)
  {
    this._name = name;
    this._defaultValue = (object) Conversions.ToInteger(Enum.Parse(enumType, defaultEnumValue));
  }

  public PreferenceAttribute(string name, bool defaultValue)
  {
    this._defaultValue = (object) defaultValue;
    this._name = name;
  }

  public PreferenceAttribute(string name, int defaultValue, bool local)
  {
    this._defaultValue = (object) defaultValue;
    this._name = name;
    this._local = local;
  }

  public PreferenceAttribute(string name, long defaultValue, bool local)
  {
    this._defaultValue = (object) defaultValue;
    this._name = name;
    this._local = local;
  }

  public PreferenceAttribute(string name, float defaultValue, bool local)
  {
    this._defaultValue = (object) defaultValue;
    this._name = name;
    this._local = local;
  }

  public PreferenceAttribute(string name, double defaultValue, bool local)
  {
    this._defaultValue = (object) defaultValue;
    this._name = name;
    this._local = local;
  }

  public PreferenceAttribute(string name, Decimal defaultValue, bool local)
  {
    this._defaultValue = (object) defaultValue;
    this._name = name;
    this._local = local;
  }

  public PreferenceAttribute(string name, string defaultValue, bool local)
  {
    this._defaultValue = (object) defaultValue;
    this._name = name;
    this._local = local;
  }

  public PreferenceAttribute(string name, Type enumType, string defaultEnumValue, bool local)
  {
    this._name = name;
    this._defaultValue = (object) Conversions.ToInteger(Enum.Parse(enumType, defaultEnumValue));
    this._local = local;
  }

  public PreferenceAttribute(string name, bool defaultValue, bool local)
  {
    this._defaultValue = (object) defaultValue;
    this._name = name;
    this._local = local;
  }

  public object DefaultValue => this._defaultValue;

  public override bool Match(object obj) => obj is PreferenceAttribute;

  public string Name => this._name;
}
