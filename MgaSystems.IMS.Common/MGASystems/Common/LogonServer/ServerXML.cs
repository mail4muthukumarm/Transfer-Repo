// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.LogonServer.ServerXML
// Assembly: MgaSystems.IMS.Common, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 46CE8D79-2C19-419C-BC23-F8C69E623B17
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.dll

using MGASystems.Data;
using Microsoft.VisualBasic.CompilerServices;
using System.Configuration;
using System.Data;

#nullable disable
namespace MGASystems.Common.LogonServer;

[StandardModule]
public sealed class ServerXML
{
  private static string _logOnServerXMLVersion;

  public static string LogOnServerXMLVersion
  {
    get
    {
      if (string.IsNullOrEmpty(ServerXML._logOnServerXMLVersion))
      {
        ServerXML._logOnServerXMLVersion = ConfigurationManager.AppSettings[nameof (LogOnServerXMLVersion)];
        if (string.IsNullOrEmpty(ServerXML._logOnServerXMLVersion))
          ServerXML._logOnServerXMLVersion = "1.0";
      }
      return ServerXML._logOnServerXMLVersion;
    }
  }

  public static bool UseEncryptedPasswords
  {
    get
    {
      return DefaultDatabase.ExecuteScalar<bool>(CommandType.StoredProcedure, "dbo.spUsingEncryptedPasswords");
    }
  }
}
