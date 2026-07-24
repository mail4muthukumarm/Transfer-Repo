// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.Policies.SimpleQuoteEntry.SharedModels.ProgramCode
// Assembly: MgaSystems.IMS.Policies.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 0490D932-1980-4BA9-8AB9-51DC95793BA0
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Policies.Cs.dll

using System;

#nullable disable
namespace MgaSystems.IMS.Policies.SimpleQuoteEntry.SharedModels;

public class ProgramCode
{
  public Guid CompanyLocationGuid { get; set; }

  public string StateID { get; set; }

  public DateTime ContractEffective { get; set; }

  public DateTime ContractExpiration { get; set; }

  public Guid LineGuid { get; set; }

  public Guid IssuingOfficeGuid { get; set; }

  public string ProgCode { get; set; }

  public int ProgramID { get; set; }

  public string GroupCode { get; set; }
}
