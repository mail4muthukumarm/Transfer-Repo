// Decompiled with JetBrains decompiler
// Type: MGASystems.Tools.ValidationException
// Assembly: MgaSystems.IMS.Tools, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 1287D1AD-C908-42E9-BE8F-4574B2D0AB9E
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Tools.dll

using System;
using System.Diagnostics.CodeAnalysis;

#nullable disable
namespace MGASystems.Tools;

[SuppressMessage("Microsoft.Design", "CA1032:ImplementStandardExceptionConstructors")]
public sealed class ValidationException(string message) : Exception(message)
{
}
