// Decompiled with JetBrains decompiler
// Type: MGASystems.BusinessObjects.Common
// Assembly: MgaSystems.IMS.BusinessObjects, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: BAE231E6-4F60-443A-9930-E3F7CC50C186
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.BusinessObjects.dll

using MGASystems.Data;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Configuration;
using System.Diagnostics.CodeAnalysis;

#nullable disable
namespace MGASystems.BusinessObjects;

[StandardModule]
public sealed class Common
{
  private static string _connectionString;
  private static string _webServicesLogonUrl;
  private static string _webServicesInvoicingUrl;
  private static Guid _webServicesToken;
  private static string _userPassword;
  private static string _userName;

  public static string ConnectionString
  {
    get
    {
      if (string.IsNullOrEmpty(Common._connectionString))
        Common._connectionString = string.IsNullOrEmpty(DefaultDatabase.ConnectionString) ? new AppSettingsReader().GetValue(nameof (ConnectionString), typeof (string)).ToString() : DefaultDatabase.ConnectionString;
      return Common._connectionString;
    }
    set => Common._connectionString = value;
  }

  [SuppressMessage("Microsoft.Design", "CA1056:UriPropertiesShouldNotBeStrings")]
  public static string WebServicesLogonUrl
  {
    get
    {
      if (string.IsNullOrEmpty(Common._webServicesLogonUrl))
        Common._webServicesLogonUrl = new AppSettingsReader().GetValue(nameof (WebServicesLogonUrl), typeof (string)).ToString();
      return Common._webServicesLogonUrl;
    }
    set => Common._webServicesLogonUrl = value;
  }

  [SuppressMessage("Microsoft.Design", "CA1056:UriPropertiesShouldNotBeStrings")]
  public static string WebServicesInvoicingUrl
  {
    get
    {
      if (string.IsNullOrEmpty(Common._webServicesInvoicingUrl))
        Common._webServicesInvoicingUrl = new AppSettingsReader().GetValue(nameof (WebServicesInvoicingUrl), typeof (string)).ToString();
      return Common._webServicesInvoicingUrl;
    }
    set => Common._webServicesInvoicingUrl = value;
  }

  public static Guid WebServicesToken
  {
    get => Common._webServicesToken;
    set => Common._webServicesToken = value;
  }

  public static string UserPassword
  {
    get => Common._userPassword;
    set => Common._userPassword = value;
  }

  public static string UserName
  {
    get => Common._userName;
    set => Common._userName = value;
  }
}
