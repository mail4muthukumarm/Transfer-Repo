// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.InspectionsLogging
// Assembly: MgaSystems.IMS.Common, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 46CE8D79-2C19-419C-BC23-F8C69E623B17
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.dll

using MGASystems.Data;
using Microsoft.VisualBasic.CompilerServices;
using System;

#nullable disable
namespace MGASystems.Common;

[StandardModule]
public sealed class InspectionsLogging
{
  public static void LogInspectionRequest(
    Guid quoteGuid,
    int inspectionCompanyID,
    int locationID,
    bool usingNetRate,
    Guid userGuid,
    Guid locationGuid,
    bool roof,
    string inspectionXml)
  {
    DefaultDatabase.ExecuteNonQuery("LogInspectionInfo", new object[16 /*0x10*/]
    {
      (object) "@QuoteGuid",
      (object) quoteGuid,
      (object) "@InspectionCompanyID",
      (object) inspectionCompanyID,
      (object) "@LocationID",
      (object) locationID,
      (object) "@UsingNetRate",
      (object) usingNetRate,
      (object) "@UserGuid",
      (object) userGuid,
      (object) "@LocationGuid",
      (object) locationGuid,
      (object) "@Roof",
      (object) roof,
      (object) "@InspectionXml",
      (object) inspectionXml
    });
  }
}
