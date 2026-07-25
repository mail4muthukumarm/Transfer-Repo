// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Reporting.Attributes.FinanceAgreementAttribute
// Assembly: MgaSystems.IMS.Reporting, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D0217E27-C87B-4FD0-8041-819EA70A118B
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Reporting.dll

using System;

#nullable disable
namespace MGASystems.IMS.Reporting.Attributes;

public class FinanceAgreementAttribute : Attribute
{
  private string[] _settingsKeys;

  public string[] SettingsKeys => this._settingsKeys;

  public FinanceAgreementAttribute() => this._settingsKeys = new string[0];

  public FinanceAgreementAttribute(params string[] settingKeys)
  {
    this._settingsKeys = settingKeys ?? new string[0];
  }

  public override bool Match(object obj) => obj is FinanceAgreementAttribute;
}
