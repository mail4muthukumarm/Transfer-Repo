// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.HotKeyManagement.HotKeyInfoAttribute
// Assembly: MgaSystems.IMS.Common, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 46CE8D79-2C19-419C-BC23-F8C69E623B17
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.dll

using MGASystems.Tools;
using System;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.Common.HotKeyManagement;

[AttributeUsage(AttributeTargets.Class)]
public sealed class HotKeyInfoAttribute : Attribute
{
  private Keys _hotKey;
  private Image _image;
  private string _toolTip;
  private string _key;
  private string _text;
  private string _alternateKeyPressDisplayText;

  public HotKeyInfoAttribute(string key, string text, string toolTip, Keys hotKey)
  {
    this._key = string.Empty;
    this._text = string.Empty;
    this._alternateKeyPressDisplayText = string.Empty;
    this._hotKey = hotKey;
    this._toolTip = string.Empty;
    this._key = key;
    this._text = text;
  }

  public HotKeyInfoAttribute(
    string key,
    string text,
    string toolTip,
    Keys hotKey,
    string imageResName)
  {
    this._key = string.Empty;
    this._text = string.Empty;
    this._alternateKeyPressDisplayText = string.Empty;
    this._hotKey = hotKey;
    this._image = ImageCache.Instance.LoadImage(imageResName, false);
    this._toolTip = string.Empty;
    this._key = key;
    this._text = text;
  }

  public HotKeyInfoAttribute(
    string key,
    string text,
    string toolTip,
    Keys hotKey,
    string imageResName,
    string alternateKeyText)
  {
    this._key = string.Empty;
    this._text = string.Empty;
    this._alternateKeyPressDisplayText = string.Empty;
    this._hotKey = hotKey;
    this._image = ImageCache.Instance.LoadImage(imageResName, false);
    this._toolTip = string.Empty;
    this._key = key;
    this._text = text;
    this._alternateKeyPressDisplayText = alternateKeyText;
  }

  public HotKeyInfoAttribute(string key, string toolTip, Keys hotKey)
  {
    this._key = string.Empty;
    this._text = string.Empty;
    this._alternateKeyPressDisplayText = string.Empty;
    this._hotKey = hotKey;
    this._toolTip = string.Empty;
    this._key = key;
    this._text = this.Text;
  }

  public HotKeyInfoAttribute(string key, string toolTip, Keys hotKey, string imageResName)
  {
    this._key = string.Empty;
    this._text = string.Empty;
    this._alternateKeyPressDisplayText = string.Empty;
    this._hotKey = hotKey;
    this._image = ImageCache.Instance.LoadImage(imageResName, false);
    this._toolTip = string.Empty;
    this._key = key;
    this._text = this.Text;
  }

  public HotKeyInfoAttribute(string key, Keys hotKey)
  {
    this._key = string.Empty;
    this._text = string.Empty;
    this._alternateKeyPressDisplayText = string.Empty;
    this._hotKey = hotKey;
    this._toolTip = string.Empty;
    this._key = key;
    this._text = this.Text;
  }

  public HotKeyInfoAttribute(string key, Keys hotKey, string imageResName)
  {
    this._key = string.Empty;
    this._text = string.Empty;
    this._alternateKeyPressDisplayText = string.Empty;
    this._hotKey = hotKey;
    this._image = ImageCache.Instance.LoadImage(imageResName, false);
    this._toolTip = string.Empty;
    this._key = key;
    this._text = this.Text;
  }

  public HotKeyInfoAttribute()
  {
    this._key = string.Empty;
    this._text = string.Empty;
    this._alternateKeyPressDisplayText = string.Empty;
    this._hotKey = Keys.None;
  }

  public Keys HotKey => this._hotKey;

  public Image Image => this._image;

  public string KeyText
  {
    get
    {
      return this._alternateKeyPressDisplayText.Length != 0 ? this._alternateKeyPressDisplayText : this.HotKey.ToString();
    }
  }

  public string ToolTip => this._toolTip;

  public string Text => this._text;

  public string Key => this._key;

  public override bool Match(object obj) => obj is HotKeyInfoAttribute;

  public override string ToString() => this._hotKey.ToString();
}
