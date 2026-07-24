// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Claims.LoadedPolicyInformationEventArgs
// Assembly: MgaSystems.IMS.Claims, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FCD9D0B7-28CF-40B9-8EB7-297871E1AF5F
// Assembly location: F:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims.dll

using System;
using System.Collections.ObjectModel;

#nullable disable
namespace MGASystems.IMS.Claims;

public class LoadedPolicyInformationEventArgs : EventArgs
{
  private string _policyNumber;
  private string _insured;
  private string _producer;
  private string _company;
  private Collection<ClaimEntity> _lines;

  public LoadedPolicyInformationEventArgs()
  {
  }

  public LoadedPolicyInformationEventArgs(
    string policyNumber,
    string insured,
    string producer,
    string company,
    Collection<ClaimEntity> lines)
  {
    this._policyNumber = policyNumber;
    this._insured = insured;
    this._company = company;
    this._producer = producer;
    this._lines = lines;
  }

  public string PolicyNumber => this._policyNumber;

  public string Insured => this._insured;

  public string Producer => this._producer;

  public string Company => this._company;

  public Collection<ClaimEntity> Lines => this._lines;
}
