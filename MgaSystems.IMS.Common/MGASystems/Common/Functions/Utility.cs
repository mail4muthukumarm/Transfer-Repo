// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.Functions.Utility
// Assembly: MgaSystems.IMS.Common, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 46CE8D79-2C19-419C-BC23-F8C69E623B17
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.dll

using Microsoft.VisualBasic.CompilerServices;
using System;

#nullable disable
namespace MGASystems.Common.Functions;

[StandardModule]
public sealed class Utility
{
  public static bool IsCompletelyNumeric(string stringToValidate)
  {
    if (stringToValidate == null)
      throw new ArgumentNullException(nameof (stringToValidate));
    int num = stringToValidate.Length - 1;
    bool flag;
    for (int index = 0; index <= num; ++index)
    {
      if (!char.IsDigit(stringToValidate[index]))
      {
        flag = false;
        goto label_8;
      }
    }
    flag = true;
label_8:
    return flag;
  }
}
