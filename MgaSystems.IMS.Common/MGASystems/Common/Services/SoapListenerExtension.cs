// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.Services.SoapListenerExtension
// Assembly: MgaSystems.IMS.Common, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 46CE8D79-2C19-419C-BC23-F8C69E623B17
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.dll

using MGASystems.Common.MgaReportingServices;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Web.Services.Protocols;
using System.Xml.Linq;

#nullable disable
namespace MGASystems.Common.Services;

public class SoapListenerExtension : SoapExtension
{
  private Stream _netStream;
  private Stream _appStream;

  static SoapListenerExtension()
  {
    SoapListenerExtension.RegisteredTypes = new ConcurrentDictionary<Assembly, HashSet<Type>>();
  }

  internal static ConcurrentDictionary<Assembly, HashSet<Type>> RegisteredTypes { get; set; }

  public static string LastRequestXML { get; set; }

  public static string LastRequestUrl { get; set; }

  public static string LastResponseXML { get; set; }

  public static Action<string> RequestAction { get; set; }

  public static Action<string> ResponseAction { get; set; }

  public override Stream ChainStream(Stream stream)
  {
    this._netStream = stream;
    this._appStream = (Stream) new MemoryStream();
    return this._appStream;
  }

  public override void ProcessMessage(SoapMessage message)
  {
    bool flag = this.IsListeningType(message is SoapClientMessage soapClientMessage ? soapClientMessage.Client?.GetType() : (Type) null);
    switch (message.Stage)
    {
      case SoapMessageStage.AfterSerialize:
        this._appStream.Position = 0L;
        if (flag)
        {
          SoapListenerExtension.LastRequestUrl = message.Url;
          SoapListenerExtension.LastRequestXML = this.GetSoapEnvelope(this._appStream);
          if (SoapListenerExtension.RequestAction != null)
            SoapListenerExtension.RequestAction(SoapListenerExtension.LastRequestXML);
        }
        this.CopyStream(this._appStream, this._netStream);
        break;
      case SoapMessageStage.BeforeDeserialize:
        this.CopyStream(this._netStream, this._appStream);
        this._appStream.Position = 0L;
        if (!flag)
          break;
        SoapListenerExtension.LastResponseXML = this.GetSoapEnvelope(this._appStream);
        if (SoapListenerExtension.ResponseAction == null)
          break;
        SoapListenerExtension.ResponseAction(SoapListenerExtension.LastResponseXML);
        break;
    }
  }

  private string GetSoapEnvelope(Stream stream)
  {
    string soapEnvelope;
    try
    {
      soapEnvelope = XDocument.Load(stream).ToString();
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      soapEnvelope = "";
      ProjectData.ClearProjectError();
    }
    finally
    {
      stream.Position = 0L;
    }
    return soapEnvelope;
  }

  private void CopyStream(Stream from, Stream to)
  {
    TextReader textReader = (TextReader) new StreamReader(from);
    StreamWriter streamWriter = new StreamWriter(to);
    streamWriter.WriteLine(textReader.ReadToEnd());
    streamWriter.Flush();
  }

  public override object GetInitializer(
    LogicalMethodInfo methodInfo,
    SoapExtensionAttribute attribute)
  {
    return (object) null;
  }

  public override object GetInitializer(Type WebServiceType) => (object) WebServiceType.FullName;

  public override void Initialize(object initializer)
  {
  }

  public static void RegisterListenerType(Type soapType)
  {
    if ((object) soapType == null)
      return;
    ConcurrentDictionary<Assembly, HashSet<Type>> registeredTypes = SoapListenerExtension.RegisteredTypes;
    Assembly assembly = soapType.Assembly;
    Func<Assembly, HashSet<Type>> valueFactory;
    // ISSUE: reference to a compiler-generated field
    if (SoapListenerExtension._Closure\u0024__.\u0024I35\u002D0 != null)
    {
      // ISSUE: reference to a compiler-generated field
      valueFactory = SoapListenerExtension._Closure\u0024__.\u0024I35\u002D0;
    }
    else
    {
      // ISSUE: reference to a compiler-generated field
      SoapListenerExtension._Closure\u0024__.\u0024I35\u002D0 = valueFactory = (Func<Assembly, HashSet<Type>>) ([SpecialName] (a) => new HashSet<Type>());
    }
    registeredTypes.GetOrAdd(assembly, valueFactory).Add(soapType);
  }

  private bool IsListeningType(Type clientType)
  {
    return (object) clientType != null && !clientType.Equals(typeof (CriticalErrorService)) && (!SoapListenerExtension.RegisteredTypes.ContainsKey(clientType.Assembly) || SoapListenerExtension.RegisteredTypes[clientType.Assembly].Contains(clientType));
  }
}
