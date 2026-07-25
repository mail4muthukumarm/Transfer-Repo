// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.Companies.FormsConditionsWarranties.FCWItem
// Assembly: MgaSystems.IMS.IPC, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: F22CEF02-8C0F-420D-8344-A8A010CA7834
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.IPC.dll

#nullable disable
namespace MGASystems.IMS.InsuredsProducersCompanies.Companies.FormsConditionsWarranties;

internal class FCWItem
{
  private FCWItem.ItemTypes _itemType;
  private int _itemID;
  private string _itemName;
  private string _formNumber;

  internal string FormNumber
  {
    get => this._formNumber;
    set => this._formNumber = value;
  }

  internal string ItemName
  {
    get => this._itemName;
    set => this._itemName = value;
  }

  internal int ItemID
  {
    get => this._itemID;
    set => this._itemID = value;
  }

  internal FCWItem.ItemTypes ItemType
  {
    get => this._itemType;
    set => this._itemType = value;
  }

  internal string ItemTypeName
  {
    get
    {
      string itemTypeName;
      switch (this.ItemType)
      {
        case FCWItem.ItemTypes.Form:
          itemTypeName = "FORM";
          break;
        case FCWItem.ItemTypes.Condition:
          itemTypeName = "CONDITION";
          break;
        case FCWItem.ItemTypes.Warranty:
          itemTypeName = "WARRANTY";
          break;
        default:
          itemTypeName = string.Empty;
          break;
      }
      return itemTypeName;
    }
  }

  public override string ToString() => this.ItemName;

  internal enum ItemTypes
  {
    Form,
    Condition,
    Warranty,
  }
}
