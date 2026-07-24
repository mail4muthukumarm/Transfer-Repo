// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.ExceptionExtensions
// Assembly: MgaSystems.IMS.Common, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 46CE8D79-2C19-419C-BC23-F8C69E623B17
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.dll

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Text;

#nullable disable
namespace MGASystems.Common;

[StandardModule]
public sealed class ExceptionExtensions
{
  public static string RecursiveMessage(this Exception currentException)
  {
    StringBuilder stringBuilder = new StringBuilder(currentException.Message);
    while (currentException.InnerException != null)
    {
      currentException = currentException.InnerException;
      stringBuilder.AppendLine();
      stringBuilder.Append(currentException.Message);
    }
    return stringBuilder.ToString();
  }
}
