// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Claims.PhoneNumberManager
// Assembly: MgaSystems.IMS.Claims, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FCD9D0B7-28CF-40B9-8EB7-297871E1AF5F
// Assembly location: F:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims.dll

using System.Collections.Generic;

#nullable disable
namespace MGASystems.IMS.Claims;

public sealed class PhoneNumberManager
{
  private List<PhoneNumber> _addedNumbers;
  private List<PhoneNumber> _deletedNumbers;
  private List<PhoneNumber> _updatedNumbers;

  public List<PhoneNumber> Added
  {
    get
    {
      if (this._addedNumbers == null)
        this._addedNumbers = new List<PhoneNumber>();
      return this._addedNumbers;
    }
  }

  public List<PhoneNumber> Updated
  {
    get
    {
      if (this._updatedNumbers == null)
        this._updatedNumbers = new List<PhoneNumber>();
      return this._updatedNumbers;
    }
  }

  public List<PhoneNumber> Deleted
  {
    get
    {
      if (this._deletedNumbers == null)
        this._deletedNumbers = new List<PhoneNumber>();
      return this._deletedNumbers;
    }
  }

  public void SaveChanges()
  {
    if (this._addedNumbers != null)
    {
      foreach (PhoneNumber addedNumber in this._addedNumbers)
        addedNumber.Save();
    }
    if (this._deletedNumbers != null)
    {
      foreach (PhoneNumber deletedNumber in this._deletedNumbers)
        deletedNumber.Delete();
    }
    if (this._updatedNumbers == null)
      return;
    foreach (PhoneNumber updatedNumber in this._updatedNumbers)
      updatedNumber.Update();
  }

  public void SaveChanges(int addressId)
  {
    if (this._addedNumbers != null)
    {
      foreach (PhoneNumber addedNumber in this._addedNumbers)
        addedNumber.Save(addressId);
    }
    if (this._deletedNumbers != null)
    {
      foreach (PhoneNumber deletedNumber in this._deletedNumbers)
        deletedNumber.Delete();
    }
    if (this._updatedNumbers == null)
      return;
    foreach (PhoneNumber updatedNumber in this._updatedNumbers)
      updatedNumber.Update();
  }

  internal PhoneNumberManager Copy()
  {
    PhoneNumberManager phoneNumberManager = new PhoneNumberManager();
    this._addedNumbers.CopyTo(phoneNumberManager.Added.ToArray());
    this._updatedNumbers.CopyTo(phoneNumberManager.Updated.ToArray());
    this._deletedNumbers.CopyTo(phoneNumberManager.Deleted.ToArray());
    return phoneNumberManager;
  }

  internal void Copy(PhoneNumberManager pnm)
  {
    if (this._addedNumbers != null && this._addedNumbers.Count > 0)
    {
      foreach (PhoneNumber addedNumber in this._addedNumbers)
        pnm.Added.Add(addedNumber);
    }
    if (this._updatedNumbers != null && this._updatedNumbers.Count > 0)
    {
      foreach (PhoneNumber updatedNumber in this._updatedNumbers)
        pnm.Updated.Add(updatedNumber);
    }
    if (this._deletedNumbers == null || this._deletedNumbers.Count <= 0)
      return;
    foreach (PhoneNumber deletedNumber in this._deletedNumbers)
      pnm.Deleted.Add(deletedNumber);
  }
}
