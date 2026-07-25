// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Excel.ImportFileUtil.CustomException
// Assembly: MgaSystems.IMS.Excel, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D783CE96-8BF7-4BCA-9997-5F16C01589C2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Excel.dll

using System;

#nullable disable
namespace MGASystems.IMS.Excel.ImportFileUtil;

public class CustomException : Exception
{
  public CustomException()
  {
  }

  public CustomException(string message)
    : base(message)
  {
  }

  public CustomException(string message, Exception innerException)
    : base(message, innerException)
  {
  }
}
