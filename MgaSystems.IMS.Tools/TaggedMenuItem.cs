// Decompiled with JetBrains decompiler
// Type: MGASystems.Tools.TaggedMenuItem
// Assembly: MgaSystems.IMS.Tools, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 1287D1AD-C908-42E9-BE8F-4574B2D0AB9E
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Tools.dll

using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.Tools;

public sealed class TaggedMenuItem : MenuItem
{
  private object _Tag;

  public new object Tag
  {
    get => this._Tag;
    set => this._Tag = RuntimeHelpers.GetObjectValue(value);
  }
}
