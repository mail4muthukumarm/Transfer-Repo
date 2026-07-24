// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.Policies.SimpleQuoteEntry.Lib.QuoteEditCode
// Assembly: MgaSystems.IMS.Policies.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 0490D932-1980-4BA9-8AB9-51DC95793BA0
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Policies.Cs.dll

using MGASystems.Data;
using MgaSystems.IMS.Policies.SimpleQuoteEntry.SharedModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;

#nullable disable
namespace MgaSystems.IMS.Policies.SimpleQuoteEntry.Lib;

public class QuoteEditCode
{
  public ObservableCollection<ClientOffice> QuotingOffices { get; set; }

  public ObservableCollection<Line> Lines { get; set; }

  public ObservableCollection<IssuingOffice> IssuingOffices { get; set; }

  public ObservableCollection<PolicyType> PolicyTypes { get; set; }

  public ObservableCollection<ProgramCode> ProgramCodes { get; set; }

  public List<LineGroup> LineGroups { get; set; }

  public QuoteEditCode()
  {
    this.Lines = new ObservableCollection<Line>();
    this.LineGroups = new List<LineGroup>((IEnumerable<LineGroup>) DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT l.GroupCode AS GroupCode, l.LineGUID AS LineGuid FROM lstLines l INNER JOIN lstLineGroups g ON g.GroupCode = l.GroupCode").AsEnumerable().Select<DataRow, LineGroup>((System.Func<DataRow, LineGroup>) (row => new LineGroup()
    {
      GroupCode = row.Field<string>("GroupCode"),
      LineGuid = row.Field<Guid>("LineGuid")
    })));
  }

  public string GetLineGroupProgramCode(Guid lineGuid)
  {
    IEnumerable<string> source = this.LineGroups.Where<LineGroup>((System.Func<LineGroup, bool>) (l => l.LineGuid == lineGuid)).Select<LineGroup, string>((System.Func<LineGroup, string>) (c => c.GroupCode));
    return source.FirstOrDefault<string>() == null ? "##" : source.FirstOrDefault<string>();
  }
}
