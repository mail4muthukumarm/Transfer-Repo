// Decompiled with JetBrains decompiler
// Type: MGASystems.Tools.WorkSheetProperties
// Assembly: MgaSystems.IMS.Tools, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 1287D1AD-C908-42E9-BE8F-4574B2D0AB9E
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Tools.dll

using System;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.Tools;

[Serializable]
public class WorkSheetProperties
{
  public string Name;
  public object Value;
  public string PropType;

  public WorkSheetProperties()
  {
  }

  public WorkSheetProperties(string Name, object Value, string PropertyType)
  {
    this.Name = Name;
    this.Value = RuntimeHelpers.GetObjectValue(Value);
    this.PropType = PropertyType;
  }
}
