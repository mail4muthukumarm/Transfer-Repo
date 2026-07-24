// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.Policies.E2Value.RequestMaker
// Assembly: MgaSystems.IMS.Policies.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 0490D932-1980-4BA9-8AB9-51DC95793BA0
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Policies.Cs.dll

using MgaSystems.IMS.Policies.E2Value.Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

#nullable disable
namespace MgaSystems.IMS.Policies.E2Value;

public class RequestMaker
{
  private const string ProntoLiteCommercialEndpoint = "https://evs.e2value.com/evs/xml/1_0/p3c/default.aspx";
  private static readonly XmlSerializer EstimateSerializer = new XmlSerializer(typeof (Estimate), new Type[1]
  {
    typeof (Property)
  });
  private static readonly XmlSerializer ResponseSerializer = new XmlSerializer(typeof (Response), new XmlRootAttribute("response"));
  private readonly string username;
  private readonly string password;

  public RequestMaker(string username, string password)
  {
    this.username = username;
    this.password = password;
  }

  public async Task<Response> prontoLiteCommercialAsync(EstimateProperty property)
  {
    return await this.prontoLiteCommercialAsync(new Estimate()
    {
      property = property,
      username = this.username,
      password = this.password,
      type = EstType.New
    });
  }

  public async Task<Response> prontoLiteCommercialAsync(Estimate input)
  {
    StringBuilder output = new StringBuilder();
    Response response1;
    using (XmlWriter xw = XmlWriter.Create(output))
    {
      XmlSerializer xmlSerializer = new XmlSerializer(typeof (Estimate), new Type[1]
      {
        typeof (Property)
      });
      RequestMaker.EstimateSerializer.Serialize(xw, (object) input);
      string str = await (await new HttpClient().PostAsync("https://evs.e2value.com/evs/xml/1_0/p3c/default.aspx", (HttpContent) new FormUrlEncodedContent((IEnumerable<KeyValuePair<string, string>>) new KeyValuePair<string, string>[1]
      {
        new KeyValuePair<string, string>("xml", output.ToString())
      })).ConfigureAwait(false)).Content.ReadAsStringAsync();
      Response response2 = (Response) RequestMaker.ResponseSerializer.Deserialize((Stream) new MemoryStream(Encoding.UTF8.GetBytes(str)));
      response2.RawResponse = XDocument.Parse(str).ToString();
      response1 = response2;
    }
    return response1;
  }
}
