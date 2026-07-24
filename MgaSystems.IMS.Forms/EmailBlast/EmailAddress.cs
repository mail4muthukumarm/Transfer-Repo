// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Forms.EmailBlast.EmailAddress
// Assembly: MgaSystems.IMS.Forms, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FB3F392E-40B6-486F-8F0B-A4A494A546D4
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Forms.dll

#nullable disable
namespace MGASystems.IMS.Forms.EmailBlast;

public sealed class EmailAddress
{
  private string _Name;
  private string _Address;
  private bool _IsCompany;

  public string Name
  {
    get => this._Name;
    set => this._Name = value;
  }

  public bool IsCompany
  {
    get => this._IsCompany;
    set => this._IsCompany = value;
  }

  public string Address
  {
    get => this._Address;
    set => this._Address = value;
  }

  public EmailAddress(string Name, string Address)
  {
    this._Name = Name;
    this._Address = Address;
  }

  public override string ToString() => this.Name;
}
