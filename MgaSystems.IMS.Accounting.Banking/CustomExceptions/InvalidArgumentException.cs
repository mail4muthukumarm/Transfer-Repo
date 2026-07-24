// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Banking.CustomExceptions.InvalidArgumentException
// Assembly: MgaSystems.IMS.Accounting.Banking, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: ED5B99DC-3DD2-44AB-BA36-49A11A94937D
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Banking.dll

using System;

#nullable disable
namespace MGASystems.IMS.Accounting.Banking.CustomExceptions;

public sealed class InvalidArgumentException(string Message) : Exception(Message)
{
}
