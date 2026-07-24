// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.SirconProducerDataService.UsernameToken
// Assembly: MgaSystems.IMS.IPC.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 902BD8FA-9BAE-43A4-A4AA-C9585D23F16B
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.IPC.Cs.dll

using System;
using System.Xml.Serialization;

#nullable disable
namespace MGASystems.IMS.InsuredsProducersCompanies.SirconProducerDataService;

[Serializable]
public class UsernameToken
{
  public UsernameToken() => this.Password = new PasswordDigest(this);

  [XmlElement]
  public string Username { get; set; }

  [XmlElement]
  public PasswordDigest Password { get; set; }

  [XmlElement]
  public byte[] Nonce { get; set; }

  [XmlIgnore]
  public DateTime? Created { get; set; }

  [XmlElement("Created", Namespace = "http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-utility-1.0.xsd")]
  public string CreatedString
  {
    get => string.Format("{0:yyyy'-'MM'-'dd'T'HH:mm:ss'Z'}", (object) this.Created);
    set
    {
      DateTime result;
      if (!DateTime.TryParse(value, out result))
        return;
      this.Created = new DateTime?(result);
    }
  }
}
