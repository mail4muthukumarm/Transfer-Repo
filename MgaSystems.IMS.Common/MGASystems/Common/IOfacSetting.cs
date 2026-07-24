// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.IOfacSetting
// Assembly: MgaSystems.IMS.Common, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 46CE8D79-2C19-419C-BC23-F8C69E623B17
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.dll

using System;
using System.Data;
using System.Net;

#nullable disable
namespace MGASystems.Common;

public interface IOfacSetting
{
  int SettingID { get; }

  bool IsValid { get; }

  int SortOrder { get; }

  OfacSystem.OfacResult CheckEntityOfac(IOfacEntity entity);

  OfacSystem.OfacResult CheckOfac(OfacSystem.OfacCriteria criteria);

  OfacSystem.OfacResult CheckOfac(
    Guid entityGuid,
    Guid? parentGuid,
    string entityType,
    string recreateTypeName,
    string lastName,
    string firstName = null,
    string address = null,
    string city = null,
    string state = null,
    string zipCode = null,
    string isoCountryCode = null,
    string dob = null);

  bool IsOfacSearchHit(OfacSystem.OfacStatus ofacSearch);

  bool IsOfacSearchCleared(OfacSystem.OfacStatus ofacSearch);

  bool IsOfacSearchValid(OfacSystem.OfacStatus ofacSearch);

  string OfacHitMessage(OfacSystem.OfacStatus ofacSearch);

  DataSet GetOfacDataset(OfacSystem.OfacStatus status);

  void HandleWebException(WebException webEx, Action<string, string> ofacSystemErrorHandler);

  void HandleException(Exception ex, Action<string, string> ofacSystemErrorHandler);
}
