// Decompiled with JetBrains decompiler
// Type: MGASystems.BusinessObjects.IntermediaryContact
// Assembly: MgaSystems.IMS.BusinessObjects, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: BAE231E6-4F60-443A-9930-E3F7CC50C186
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.BusinessObjects.dll

using MGASystems.Common;
using MGASystems.Common.Enums;
using MGASystems.Data.DataMapping;
using System;

#nullable disable
namespace MGASystems.BusinessObjects;

[TableMapping("dbo.tblIntermediaryContacts")]
public class IntermediaryContact : BaseDataObject
{
  private Guid _intermediaryContactGuid;

  public IntermediaryContact(Guid intermediaryContactGuid)
  {
    this._intermediaryContactGuid = intermediaryContactGuid;
  }

  [DataKey]
  public Guid IntermediaryContactGuid
  {
    get => this._intermediaryContactGuid;
    protected set
    {
      this._intermediaryContactGuid = this._intermediaryContactGuid.Equals(Guid.Empty) ? value : throw new InvalidOperationException($"Specified IntermediaryContact {this._intermediaryContactGuid} has already been initialized");
    }
  }

  [TableFieldMapping]
  public int IntermediaryID => this.GetField<int>(nameof (IntermediaryID), nameof (IntermediaryID));

  [TableFieldMapping]
  public string Salutation
  {
    get => this.GetField<string>(nameof (Salutation), nameof (Salutation)) ?? string.Empty;
  }

  [TableFieldMapping]
  public string FName => this.GetField<string>(nameof (FName), nameof (FName)) ?? string.Empty;

  [TableFieldMapping]
  public string LName => this.GetField<string>(nameof (LName), nameof (LName));

  [TableFieldMapping]
  public string Title => this.GetField<string>(nameof (Title), nameof (Title)) ?? string.Empty;

  [TableFieldMapping]
  public string Phone => this.GetField<string>(nameof (Phone), nameof (Phone)) ?? string.Empty;

  [TableFieldMapping]
  public string Extension
  {
    get => this.GetField<string>(nameof (Extension), nameof (Extension)) ?? string.Empty;
  }

  [TableFieldMapping]
  public string Cell => this.GetField<string>(nameof (Cell), nameof (Cell)) ?? string.Empty;

  [TableFieldMapping]
  public string Fax => this.GetField<string>(nameof (Fax), nameof (Fax)) ?? string.Empty;

  [TableFieldMapping]
  public string Email => this.GetField<string>(nameof (Email), nameof (Email)) ?? string.Empty;

  [TableFieldMapping]
  public int StatusID => (int) this.GetField<byte>(nameof (StatusID), nameof (StatusID));

  [TableFieldMapping]
  public int DeliveryMethodID
  {
    get => (int) this.GetField<byte>(nameof (DeliveryMethodID), nameof (DeliveryMethodID));
  }

  public DeliveryMethods DeliveryMethod => (DeliveryMethods) this.DeliveryMethodID;

  public IntermediaryContact FromContactGuid(Guid intermediaryContactGuid)
  {
    IntermediaryContact intermediaryContact;
    if (this.IntermediaryContactGuid.Equals(intermediaryContactGuid))
      intermediaryContact = this;
    else
      intermediaryContact = ObjectFactory.Instance.CreateObjectAs<IntermediaryContact>((object) intermediaryContactGuid);
    return intermediaryContact;
  }
}
