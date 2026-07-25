// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.AccountingTransfer.Fees
// Assembly: MgaSystems.IMS.Policies, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 2FF2C709-F7BF-41DA-82BD-FF6319CA235D
// Assembly location: C:\Users\muthu\Downloads\MgaSystems.IMS.Policies.dll

using System.Collections.Generic;

#nullable disable
namespace MGASystems.IMS.Policies.AccountingTransfer;

public sealed class Fees : List<Fee>
{
  public void AddFee(Fee f) => this.Add(f);

  public Fee FindFee(int OptionFeeID)
  {
    Fee fee1;
    try
    {
      foreach (Fee fee2 in (List<Fee>) this)
      {
        if (fee2.OptionFeeID == OptionFeeID)
        {
          fee1 = fee2;
          goto label_6;
        }
      }
    }
    finally
    {
      List<Fee>.Enumerator enumerator;
      enumerator.Dispose();
    }
    fee1 = (Fee) null;
label_6:
    return fee1;
  }
}
