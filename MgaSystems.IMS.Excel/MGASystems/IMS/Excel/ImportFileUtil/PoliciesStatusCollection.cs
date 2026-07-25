// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Excel.ImportFileUtil.PoliciesStatusCollection
// Assembly: MgaSystems.IMS.Excel, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D783CE96-8BF7-4BCA-9997-5F16C01589C2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Excel.dll

using System;
using System.Collections;
using System.Collections.Generic;

#nullable disable
namespace MGASystems.IMS.Excel.ImportFileUtil;

public class PoliciesStatusCollection : IEnumerable<PoliciesStatus>, IEnumerable
{
  private Dictionary<Tuple<string, int, Decimal>, PoliciesStatus> pst = new Dictionary<Tuple<string, int, Decimal>, PoliciesStatus>();

  public void Add(
    string PolicyNumber,
    int rowNumber,
    Decimal transactionAmount,
    PoliciesStatus ps)
  {
    if (this.pst.ContainsKey(Tuple.Create<string, int, Decimal>(PolicyNumber, rowNumber, transactionAmount)))
      return;
    this.pst.Add(Tuple.Create<string, int, Decimal>(PolicyNumber, rowNumber, transactionAmount), ps);
  }

  public IEnumerator<PoliciesStatus> GetEnumerator()
  {
    return (IEnumerator<PoliciesStatus>) this.pst.Values.GetEnumerator();
  }

  IEnumerator IEnumerable.GetEnumerator() => ((IEnumerable) this.pst.Values).GetEnumerator();
}
