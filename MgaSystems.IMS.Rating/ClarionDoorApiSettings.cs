// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Rating.ClarionDoorApiSettings
// Assembly: MgaSystems.IMS.Rating, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 370B8F0A-FA1A-41D0-87BD-563CC23E9EA7
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Rating.dll

using MGASystems.IMS.NoteDocuments;

#nullable disable
namespace MGASystems.IMS.Policies.Rating;

public class ClarionDoorApiSettings
{
  public static string Url { get; } = SystemSettings.GetSetting<string>("SelectSys.ClarionDoor.Url", "");

  public static string UserName { get; } = SystemSettings.GetSetting<string>("SelectSys.ClarionDoor.UserName", "");

  public static string EncryptedPassword { get; } = SystemSettings.GetSetting<string>("SelectSys.ClarionDoor.EncryptedPassword", "");

  public static string UserNameSSO { get; } = SystemSettings.GetSetting<string>("SelectSys.ClarionDoor.UserNameSSO", "");

  public static string EncryptedPasswordSSO { get; } = SystemSettings.GetSetting<string>("SelectSys.ClarionDoor.EncryptedPasswordSSO", "");

  public static bool UseClarionSSO { get; } = !string.IsNullOrEmpty(ClarionDoorApiSettings.UserNameSSO) && !string.IsNullOrEmpty(ClarionDoorApiSettings.EncryptedPasswordSSO);

  public static bool IsValid()
  {
    return !string.IsNullOrWhiteSpace(ClarionDoorApiSettings.Url) && !string.IsNullOrWhiteSpace(ClarionDoorApiSettings.UserName) && !string.IsNullOrWhiteSpace(ClarionDoorApiSettings.EncryptedPassword);
  }
}
