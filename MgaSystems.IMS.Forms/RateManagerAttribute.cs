// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Forms.RateManagerAttribute
// Assembly: MgaSystems.IMS.Forms, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FB3F392E-40B6-486F-8F0B-A4A494A546D4
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Forms.dll

using System;

#nullable disable
namespace MGASystems.IMS.Forms;

[AttributeUsage(AttributeTargets.Class)]
public sealed class RateManagerAttribute : Attribute
{
  public override bool Match(object obj) => obj is RateManagerAttribute;
}
