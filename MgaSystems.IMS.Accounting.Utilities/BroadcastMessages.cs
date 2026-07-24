// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Utilities.BroadcastMessages
// Assembly: MgaSystems.IMS.Accounting.Utilities, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 0980F864-5BDB-427E-98EE-09B90661DBB2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Utilities.dll

using System;

#nullable disable
namespace MGASystems.IMS.Accounting.Utilities;

public sealed class BroadcastMessages
{
  public static Guid CloseAccounting => new Guid("{99170549-3A65-480f-AF04-4E2EF4FFCF8B}");

  public static Guid CloseAllForms => new Guid("{00AC599E-D170-4b2a-825C-69F797C5A9B9}");

  public static Guid RemittancePosted => new Guid("{5C44EFAB-A1D5-473f-B715-63CFD48713E8}");
}
