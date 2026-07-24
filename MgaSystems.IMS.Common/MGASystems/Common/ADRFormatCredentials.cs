// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.ADRFormatCredentials
// Assembly: MgaSystems.IMS.Common, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 46CE8D79-2C19-419C-BC23-F8C69E623B17
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.dll

#nullable disable
namespace MGASystems.Common;

public class ADRFormatCredentials
{
  private string _encryptedPassword;
  private string _plainPassword;

  public ADRFormatCredentials(string password)
  {
    this._encryptedPassword = string.Empty;
    this._plainPassword = string.Empty;
    this._plainPassword = password;
  }

  public virtual string EncryptedPassword() => string.Empty;

  public virtual string EncryptedDeviceID() => string.Empty;
}
