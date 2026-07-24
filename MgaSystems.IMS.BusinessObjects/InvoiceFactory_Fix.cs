// Decompiled with JetBrains decompiler
// Type: MGASystems.BusinessObjects.InvoiceFactory_Fix
// Assembly: MgaSystems.IMS.BusinessObjects, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: BAE231E6-4F60-443A-9930-E3F7CC50C186
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.BusinessObjects.dll

using MGASystems.BusinessObjects.MGAInvoiceFactory;
using System;
using System.Diagnostics.CodeAnalysis;
using System.Net;

#nullable disable
namespace MGASystems.BusinessObjects;

[SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores")]
public class InvoiceFactory_Fix : InvoiceFactory
{
  protected override WebRequest GetWebRequest(Uri uri)
  {
    HttpWebRequest webRequest = (HttpWebRequest) base.GetWebRequest(uri);
    webRequest.KeepAlive = false;
    return (WebRequest) webRequest;
  }
}
