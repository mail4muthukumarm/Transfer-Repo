// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.Email.Settings
// Assembly: MgaSystems.IMS.Common, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 46CE8D79-2C19-419C-BC23-F8C69E623B17
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.dll

using Microsoft.VisualBasic.CompilerServices;

#nullable disable
namespace MGASystems.Common.Email;

[StandardModule]
public sealed class Settings
{
  static Settings()
  {
    Settings.SuppressExceptions = false;
    Settings.SuppressDialogs = false;
  }

  public static bool SuppressExceptions { get; set; }

  public static bool SuppressDialogs { get; set; }
}
