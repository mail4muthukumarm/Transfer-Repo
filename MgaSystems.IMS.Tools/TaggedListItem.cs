// Decompiled with JetBrains decompiler
// Type: MGASystems.Tools.TaggedListItem
// Assembly: MgaSystems.IMS.Tools, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 1287D1AD-C908-42E9-BE8F-4574B2D0AB9E
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Tools.dll

using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.Tools;

public sealed class TaggedListItem
{
  private string _displayText;
  private object _tag;

  public TaggedListItem(string displayText, object tag)
  {
    this._displayText = displayText;
    this._tag = RuntimeHelpers.GetObjectValue(tag);
  }

  public object Tag => this._tag;

  public override string ToString() => this._displayText;
}
