// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Utilities.Exceptions.DistributionsNotInBalanceException
// Assembly: MgaSystems.IMS.Accounting.Utilities, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 0980F864-5BDB-427E-98EE-09B90661DBB2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Utilities.dll

using System;

#nullable disable
namespace MGASystems.IMS.Accounting.Utilities.Exceptions;

public sealed class DistributionsNotInBalanceException : ApplicationException
{
  public override string Message => "Distributions are not in balance!";
}
