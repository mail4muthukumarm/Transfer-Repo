// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.OperatingExpenses.ClassObjects.ExpensePayee
// Assembly: MgaSystems.IMS.Accounting.OperatingExpenses, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 77B4DED4-9019-44D3-8D52-4669B0CA70E1
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.OperatingExpenses.dll

#nullable disable
namespace MGASystems.IMS.Accounting.OperatingExpenses.ClassObjects;

public class ExpensePayee
{
  private string _payeeName;
  private string _address1;
  private string _address2;
  private string _city;
  private string _state;
  private string _zipCode;
  private string _zipExt;
  private string _phone1;
  private string _phone2;
  private string _fax;

  public string PayeeName
  {
    get => this._payeeName;
    set => this._payeeName = value;
  }

  public string Address1
  {
    get => this._address1;
    set => this._address1 = value;
  }

  public string Address2
  {
    get => this._address2;
    set => this._address2 = value;
  }

  public string City
  {
    get => this._city;
    set => this._city = value;
  }

  public string State
  {
    get => this._state;
    set => this._state = value;
  }

  public string ZipCode
  {
    get => this._zipCode;
    set => this._zipCode = value;
  }

  public string ZipExt
  {
    get => this._zipExt;
    set => this._zipExt = value;
  }

  public string Phone1
  {
    get => this._phone1;
    set => this._phone1 = value;
  }

  public string Phone2
  {
    get => this._phone2;
    set => this._phone2 = value;
  }

  public string Fax
  {
    get => this._fax;
    set => this._fax = value;
  }
}
