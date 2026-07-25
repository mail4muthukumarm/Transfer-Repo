// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.UnderwritingServices.Verisk.ServiceObjects.Mvr.ReportXmlResponse
// Assembly: MgaSystems.IMS.UnderwritingServices, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 4E63F408-1B27-4004-B8D3-2C6361F8A9AF
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.UnderwritingServices.dll

using System;
using System.Diagnostics;
using System.IO;
using System.Xml.Serialization;

#nullable disable
namespace MgaSystems.IMS.UnderwritingServices.Verisk.ServiceObjects.Mvr;

public class ReportXmlResponse : BaseResponse
{
  internal ReportXmlResponse(string responseString)
    : base(responseString)
  {
    if (this.ResponseType != ReportType.Unknown)
      return;
    this.ResponseType = ReportType.Xml;
    try
    {
      using (StringReader stringReader = new StringReader(responseString))
      {
        XmlSerializer xmlSerializer = new XmlSerializer(typeof (MvrReport));
        if (Debugger.IsAttached)
        {
          xmlSerializer.UnknownAttribute += (XmlAttributeEventHandler) ((s, a) => { });
          xmlSerializer.UnknownElement += (XmlElementEventHandler) ((s, a) => { });
          xmlSerializer.UnknownNode += (XmlNodeEventHandler) ((s, a) => { });
          xmlSerializer.UnreferencedObject += (UnreferencedObjectEventHandler) ((s, a) => { });
        }
        this.Report = (MvrReport) xmlSerializer.Deserialize((TextReader) stringReader);
      }
    }
    catch (Exception ex)
    {
      this.CreateException = (Exception) new InvalidOperationException("Failed to deserialize response data to MvrReport class; " + ex.Message, ex);
    }
  }

  internal ReportXmlResponse(Exception responseException, string rawString)
    : base(responseException, rawString)
  {
    this.ResponseType = ReportType.Xml;
  }

  public bool IsValidXml => this.ResponseType == ReportType.Xml && this.Report != null;

  public MvrReport Report { get; }
}
