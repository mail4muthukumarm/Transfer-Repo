// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.CompanyContext
// Assembly: MgaSystems.IMS.IPC, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: F22CEF02-8C0F-420D-8344-A8A010CA7834
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.IPC.dll

using System;

#nullable disable
namespace MGASystems.IMS.InsuredsProducersCompanies;

public class CompanyContext
{
  private Guid _companyGuid;
  private string _companyName;

  internal CompanyContext(Guid companyGuid, string companyName)
  {
    this._companyGuid = companyGuid;
    this._companyName = companyName;
  }

  public string CompanyName => this._companyName;

  public Guid CompanyGuid => this._companyGuid;
}
