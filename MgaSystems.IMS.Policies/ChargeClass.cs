// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.ChargeClass
// Assembly: MgaSystems.IMS.Policies, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 2FF2C709-F7BF-41DA-82BD-FF6319CA235D
// Assembly location: C:\Users\muthu\Downloads\MgaSystems.IMS.Policies.dll

using Microsoft.VisualBasic.CompilerServices;
using System;

#nullable disable
namespace MGASystems.IMS.Policies;

public class ChargeClass
{
  private Guid QuoteOptionGuid;
  private string ChargeName;
  private int ChargeCode;
  private char ChargeType;
  private int RaterChargeId;
  private string LineName;
  private Guid LineGuid;
  private double Premium;
  private double OriginalPremium;
  private string StateInitials;
  private bool ChargeUpdated;
  private int OfficeId;

  public void SetQuoteOptionGuid(string s) => this.QuoteOptionGuid = new Guid(s);

  public Guid GetQuoteOptionGuid() => this.QuoteOptionGuid;

  public void SetLineGuid(string s) => this.LineGuid = new Guid(s);

  public Guid GetLineGuid() => this.LineGuid;

  public void SetChargeName(string s) => this.ChargeName = s;

  public string GetChargeName() => this.ChargeName;

  public void SetChargeCode(string s) => this.ChargeCode = int.Parse(s.ToString());

  public int GetChargeCode() => this.ChargeCode;

  public void SetChargeType(char s) => this.ChargeType = s;

  public char GetChargeType() => this.ChargeType;

  public void SetRaterChargeId(string s) => this.RaterChargeId = int.Parse(s.ToString());

  public int GetRaterChargeId() => this.RaterChargeId;

  public void SetLineName(string s) => this.LineName = s;

  public string GetLineName() => this.LineName;

  public void SetPremium(string d)
  {
    this.Premium = double.Parse($"{Conversions.ToDecimal(d.ToString()):f2}");
  }

  public double GetPremium() => this.Premium;

  public void SetOriginalPremium(string d)
  {
    this.OriginalPremium = double.Parse($"{Conversions.ToDecimal(d.ToString()):f2}");
  }

  public double GetOriginalPremium() => this.OriginalPremium;

  public void SetStateInitials(string s) => this.StateInitials = s;

  public string GetStateInitials() => this.StateInitials;

  public void SetChargeUpdated(bool b) => this.ChargeUpdated = b;

  public bool GetChargeUpdated() => this.ChargeUpdated;

  public void SetOfficeId(string s) => this.OfficeId = int.Parse(s.ToString());

  public int GetOfficeId() => this.OfficeId;
}
