// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.Companies.FormsConditionsWarranties.AssociatedFormsWarranties
// Assembly: MgaSystems.IMS.IPC, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: F22CEF02-8C0F-420D-8344-A8A010CA7834
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.IPC.dll

#nullable disable
namespace MGASystems.IMS.InsuredsProducersCompanies.Companies.FormsConditionsWarranties;

internal class AssociatedFormsWarranties
{
  private readonly int _Company_FCW_ID;
  private readonly string _FormName;
  private int _WarrantyID;

  public string FormName => this._FormName;

  public int Company_FCW_ID => this._Company_FCW_ID;

  public int WarrantyID
  {
    get => this._WarrantyID;
    set => this._WarrantyID = value;
  }

  public AssociatedFormsWarranties(int Company_FCW_ID, string FormName, int warrantyID)
  {
    this._FormName = FormName;
    this._Company_FCW_ID = Company_FCW_ID;
    this._WarrantyID = warrantyID;
  }

  public override string ToString() => this.FormName;
}
