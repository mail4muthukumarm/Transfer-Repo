// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.DocumentAutomation.CompanyLineInfo
// Assembly: MgaSystems.IMS.DocumentAutomation, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: B33F9A76-E654-4386-A032-7A12D7CD66DE
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.DocumentAutomation.dll

using MGASystems.Data;
using MGASystems.Data.Binding;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.DocumentAutomation;

public abstract class CompanyLineInfo : BindingObject
{
  [NotificationProperty]
  public virtual Guid CompanyLineGuid { get; set; }

  [NotificationProperty]
  public virtual string LineName { get; set; }

  [NotificationProperty]
  public virtual string CompanyLocationName { get; set; }

  [NotificationProperty]
  public virtual Guid CompanyLocationGuid { get; set; }

  [NotificationProperty]
  public virtual string StateName { get; set; }

  [NotificationProperty]
  public virtual bool Copy { get; set; }

  [NotificationProperty]
  public virtual bool HasExistingConditional { get; set; }

  public CompanyLineInfo(
    Guid _companyLineGuid,
    string _lineName,
    string _companyLocationName,
    Guid _companyLocationGuid,
    string _stateName,
    bool _hasExisting)
  {
    this.CompanyLineGuid = _companyLineGuid;
    this.LineName = _lineName;
    this.CompanyLocationName = _companyLocationName;
    this.CompanyLocationGuid = _companyLocationGuid;
    this.StateName = _stateName;
    this.HasExistingConditional = _hasExisting;
  }

  public static CompanyLineInfo Create(
    Guid _companyLineGuid,
    string _lineName,
    string _companyLocationName,
    Guid _companyLocationGuid,
    string _stateName,
    bool _hasExisting)
  {
    return NotifyProxyTypeManager.Allocate<CompanyLineInfo>(new object[6]
    {
      (object) _companyLineGuid,
      (object) _lineName,
      (object) _companyLocationName,
      (object) _companyLocationGuid,
      (object) _stateName,
      (object) _hasExisting
    });
  }

  public static ObservableCollection<CompanyLineInfo> GetCompanyLine(
    Guid? _companyLocationGuid,
    Guid? _lineGuid,
    string _stateID,
    Guid? _currentCompanyLine,
    Guid? _systemEventGuid,
    int? _templateID,
    Guid? _automationReportGuid,
    int? _quoteStatusReasonID)
  {
    EnumerableRowCollection<DataRow> source = DefaultDatabase.ExecuteDataTable(CommandType.StoredProcedure, "spCopyConditionalList", new object[12]
    {
      (object) "@companyLocationGuid",
      (object) _companyLocationGuid,
      (object) "@lineGuid",
      (object) _lineGuid,
      (object) "@stateID",
      (object) _stateID,
      (object) "@currentCompanyLine",
      (object) _currentCompanyLine,
      (object) "@systemEventGuid",
      (object) _systemEventGuid,
      (object) "@templateID",
      (object) _templateID
    }).AsEnumerable();
    System.Func<DataRow, CompanyLineInfo> selector;
    // ISSUE: reference to a compiler-generated field
    if (CompanyLineInfo._Closure\u0024__.\u0024I30\u002D0 != null)
    {
      // ISSUE: reference to a compiler-generated field
      selector = CompanyLineInfo._Closure\u0024__.\u0024I30\u002D0;
    }
    else
    {
      // ISSUE: reference to a compiler-generated field
      CompanyLineInfo._Closure\u0024__.\u0024I30\u002D0 = selector = (System.Func<DataRow, CompanyLineInfo>) ([SpecialName] (row) => CompanyLineInfo.Create(row.Field<Guid>("CompanyLineGuid"), row.Field<string>("LineName"), row.Field<string>("Name"), row.Field<Guid>("CompanyLocationGuid"), row.Field<string>("State"), row.Field<bool>("HasConditional")));
    }
    return new ObservableCollection<CompanyLineInfo>((IEnumerable<CompanyLineInfo>) source.Select<DataRow, CompanyLineInfo>(selector));
  }
}
