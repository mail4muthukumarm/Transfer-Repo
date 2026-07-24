// Decompiled with JetBrains decompiler
// Type: MGASystems.BusinessObjects.UnbindClosedAccountingMonthException
// Assembly: MgaSystems.IMS.BusinessObjects, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: BAE231E6-4F60-443A-9930-E3F7CC50C186
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.BusinessObjects.dll

using System;
using System.Diagnostics.CodeAnalysis;

#nullable disable
namespace MGASystems.BusinessObjects;

[SuppressMessage("Microsoft.Usage", "CA2237:MarkISerializableTypesWithSerializable")]
[SuppressMessage("Microsoft.Design", "CA1032:ImplementStandardExceptionConstructors")]
public class UnbindClosedAccountingMonthException : Exception
{
  public override string Message
  {
    get
    {
      return "The policy can not be unbound, because one or more invoices were billed in a closed accounting month.";
    }
  }
}
