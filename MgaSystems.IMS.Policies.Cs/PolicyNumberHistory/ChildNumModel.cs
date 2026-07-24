// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.Policies.PolicyNumberHistory.ChildNumModel
// Assembly: MgaSystems.IMS.Policies.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 0490D932-1980-4BA9-8AB9-51DC95793BA0
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Policies.Cs.dll

using System.Collections.ObjectModel;

#nullable disable
namespace MgaSystems.IMS.Policies.PolicyNumberHistory;

public class ChildNumModel
{
  public ObservableCollection<ChildNumData> DetailPolicyNumList { get; private set; }

  public ChildNumModel() => this.DetailPolicyNumList = new ObservableCollection<ChildNumData>();
}
