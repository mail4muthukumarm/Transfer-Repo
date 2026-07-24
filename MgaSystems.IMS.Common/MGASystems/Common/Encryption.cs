// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.Encryption
// Assembly: MgaSystems.IMS.Common, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 46CE8D79-2C19-419C-BC23-F8C69E623B17
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.dll

using MGASystems.Data.DataEncryption;
using System;

#nullable disable
namespace MGASystems.Common;

public sealed class Encryption
{
  private static IEncrypt _tripleDesEncrypter = (IEncrypt) new CoffeeTripleDesEncrypter();

  [Obsolete("This method is deprecated, use MGASystems.Data.Encryption.TripleDesEncrypter instead.")]
  public string EncryptTripleDes(string plaintext)
  {
    return Encryption._tripleDesEncrypter.Encrypt(plaintext);
  }

  [Obsolete("This method is deprecated, use MGASystems.Data.Encryption.TripleDesEncrypter instead.")]
  public string DecryptTripleDes(string base64Text)
  {
    return Encryption._tripleDesEncrypter.Decrypt(base64Text);
  }
}
