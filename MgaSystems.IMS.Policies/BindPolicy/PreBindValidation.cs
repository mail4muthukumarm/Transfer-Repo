// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.BindPolicy.PreBindValidation
// Assembly: MgaSystems.IMS.Policies, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 2FF2C709-F7BF-41DA-82BD-FF6319CA235D
// Assembly location: C:\Users\muthu\Downloads\MgaSystems.IMS.Policies.dll

using MGASystems.BusinessObjects;
using MGASystems.Common;
using MGASystems.Data;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;

#nullable disable
namespace MGASystems.IMS.Policies.BindPolicy;

public class PreBindValidation
{
  private int _raterId;
  private Guid _lineGuid;
  private Quote _quote;

  public PreBindValidation(int raterId, Guid lineGuid, Guid quoteGuid)
  {
    int raterId1 = raterId;
    Guid lineGuid1 = lineGuid;
    Quote quote = new Quote(quoteGuid);
    ref Quote local = ref quote;
    // ISSUE: explicit constructor call
    this.\u002Ector(raterId1, lineGuid1, ref local);
  }

  public PreBindValidation(int raterId, Guid lineGuid, ref Quote curQuote)
  {
    this._raterId = raterId;
    this._lineGuid = lineGuid;
    this._quote = curQuote;
  }

  public static List<string> Validate(int raterId, Guid lineGuid, Guid quoteGuid)
  {
    return new PreBindValidation(raterId, lineGuid, quoteGuid).Validate();
  }

  public static List<string> Validate(int raterId, Guid lineGuid, ref Quote curQuote)
  {
    return new PreBindValidation(raterId, lineGuid, ref curQuote).Validate();
  }

  public List<string> Validate()
  {
    List<string> stringList = new List<string>();
    try
    {
      DataTable dataTable = DefaultDatabase.ExecuteDataTable("spGetBindValidationTags", new object[10]
      {
        (object) "@raterID",
        (object) this._raterId,
        (object) "@lineGuid",
        (object) this._lineGuid,
        (object) "@compLocGuid",
        (object) this._quote.CompanyLocationGuid,
        (object) "@userId",
        (object) CurrentUser.Instance.UserID,
        (object) "@stateId",
        (object) this._quote.StateID
      });
      try
      {
        foreach (DataRow row in dataTable.Rows)
          ;
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      ProjectData.ClearProjectError();
    }
    return stringList;
  }
}
