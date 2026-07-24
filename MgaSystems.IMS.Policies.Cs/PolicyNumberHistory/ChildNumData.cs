// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.Policies.PolicyNumberHistory.ChildNumData
// Assembly: MgaSystems.IMS.Policies.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 0490D932-1980-4BA9-8AB9-51DC95793BA0
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Policies.Cs.dll

using System.ComponentModel;

#nullable disable
namespace MgaSystems.IMS.Policies.PolicyNumberHistory;

public class ChildNumData : INotifyPropertyChanged
{
  public event PropertyChangedEventHandler PropertyChanged;

  public int QuoteID { get; set; }

  public string LocationName { get; set; }

  public int EndorsementNum { get; set; }

  public string PolicyNumber { get; set; }

  public string RuleName { get; set; }
}
