// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Rating.ClarionDoorRater
// Assembly: MgaSystems.IMS.Rating, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 370B8F0A-FA1A-41D0-87BD-563CC23E9EA7
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Rating.dll

using Mga.Wpf.Ims.Interop;
using MGASystems.BusinessObjects.Rating;
using MGASystems.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Policies.Rating;

[RaterInformation(211027, "Clarion Door Rater")]
public class ClarionDoorRater : RaterWithUIBase
{
  private DataTable _notReadyToBindReasons;

  public override string GetOptionDescription(Guid quoteOptionGuid) => "";

  public override bool HasUI => true;

  protected override Form CreateUI()
  {
    return (Form) MgaMdiChild.CreateForm<ClarionDoorRaterBrowserHost>(new object[1]
    {
      (object) this
    });
  }

  protected override void OnCopyBoundOption(SqlCommand cmd, OnCopyBoundOptionArgs e)
  {
  }

  public override bool IsReadyForBind
  {
    get
    {
      return this.Quote.IsBound & this.Quote.IsOriginalQuoteRecord || this.NotReadyToBindReasons.Rows.Count == 0;
    }
  }

  protected virtual string NotReadyToBindReasonsProcName() => "SpNotReadyToBindReasons";

  private DataTable NotReadyToBindReasons
  {
    get
    {
      if (this._notReadyToBindReasons == null)
        this._notReadyToBindReasons = DefaultDatabase.ExecuteDataTable(this.NotReadyToBindReasonsProcName(), new object[2]
        {
          (object) "@quoteGuid",
          (object) this.Quote.QuoteGuid
        });
      return this._notReadyToBindReasons;
    }
  }

  public override List<string> NotReadyToBindReason
  {
    get
    {
      EnumerableRowCollection<DataRow> source = this.NotReadyToBindReasons.AsEnumerable();
      System.Func<DataRow, string> selector;
      if (ClarionDoorRater._Closure\u0024__.\u0024I13\u002D0 != null)
        selector = ClarionDoorRater._Closure\u0024__.\u0024I13\u002D0;
      else
        ClarionDoorRater._Closure\u0024__.\u0024I13\u002D0 = selector = (System.Func<DataRow, string>) ([SpecialName] (r) => r.Field<string>("Reason").Replace("NetRate", "ClarionDoor"));
      return source.Select<DataRow, string>(selector).ToList<string>();
    }
  }
}
