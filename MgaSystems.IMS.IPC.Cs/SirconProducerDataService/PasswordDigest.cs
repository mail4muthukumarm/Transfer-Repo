// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.SirconProducerDataService.PasswordDigest
// Assembly: MgaSystems.IMS.IPC.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 902BD8FA-9BAE-43A4-A4AA-C9585D23F16B
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.IPC.Cs.dll

using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Xml.Serialization;

#nullable disable
namespace MGASystems.IMS.InsuredsProducersCompanies.SirconProducerDataService;

[Serializable]
public class PasswordDigest
{
  private UsernameToken _token;

  public PasswordDigest()
  {
  }

  public PasswordDigest(UsernameToken token) => this._token = token;

  [XmlAttribute("Type")]
  public string Type { get; set; } = nameof (PasswordDigest);

  [XmlIgnore]
  public string Password
  {
    get => this.Value;
    set
    {
      if (string.IsNullOrEmpty(value))
        this.Value = (string) null;
      else if (this._token?.Nonce?.Length.GetValueOrDefault() == 0 || string.IsNullOrEmpty(this._token?.CreatedString) || string.IsNullOrEmpty(value))
      {
        this.Value = (string) null;
      }
      else
      {
        using (MemoryStream output = new MemoryStream())
        {
          using (BinaryWriter binaryWriter = new BinaryWriter((Stream) output))
          {
            binaryWriter.Write(this._token.Nonce);
            binaryWriter.Write(Encoding.UTF8.GetBytes(this._token.CreatedString));
            binaryWriter.Write(Encoding.UTF8.GetBytes(value));
            binaryWriter.Flush();
            this.Value = Convert.ToBase64String(new SHA1CryptoServiceProvider().ComputeHash(output.ToArray()));
          }
        }
      }
    }
  }

  [XmlText]
  public string Value { get; set; }
}
