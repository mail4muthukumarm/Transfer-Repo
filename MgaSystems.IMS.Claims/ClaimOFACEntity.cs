// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Claims.ClaimOFACEntity
// Assembly: MgaSystems.IMS.Claims, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FCD9D0B7-28CF-40B9-8EB7-297871E1AF5F
// Assembly location: F:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims.dll

using MGASystems.BusinessObjects;
using MGASystems.Common;
using MGASystems.Data;
using System;
using System.Data;
using System.Text;

#nullable disable
namespace MGASystems.IMS.Claims;

public class ClaimOFACEntity : IOfacEntity
{
  public string CorporationName { get; set; }

  public string DBAName { get; set; }

  public string FirstName { get; set; }

  public string MiddleName { get; set; }

  public string LastName { get; set; }

  public string ISOCountryCode { get; set; }

  public string Address1 { get; set; }

  public string Address2 { get; set; }

  public string City { get; set; }

  public string State { get; set; }

  public string ZipCode { get; set; }

  public string FEINSSN { get; set; }

  public Guid EntityGuid { get; private set; }

  public Guid? ParentEntityGuid { get; set; }

  private string DisplayName
  {
    get
    {
      if (!string.IsNullOrEmpty(this.CorporationName))
        return this.CorporationName;
      StringBuilder stringBuilder = new StringBuilder();
      if (!string.IsNullOrEmpty(this.FirstName))
        stringBuilder.Append(this.FirstName);
      if (!string.IsNullOrEmpty(this.MiddleName))
      {
        if (!string.IsNullOrEmpty(stringBuilder.ToString()))
        {
          stringBuilder.Append(" ");
          stringBuilder.Append(this.MiddleName);
        }
        else
          stringBuilder.Append(this.MiddleName);
      }
      if (!string.IsNullOrEmpty(this.LastName))
      {
        if (!string.IsNullOrEmpty(stringBuilder.ToString()))
        {
          stringBuilder.Append(" ");
          stringBuilder.Append(this.LastName);
        }
        else
          stringBuilder.Append(this.LastName);
      }
      return stringBuilder.ToString();
    }
  }

  public string RecreateData { get; private set; }

  public ClaimOFACEntity(Guid entityGuid, string recreateData)
  {
    this.EntityGuid = entityGuid;
    this.RecreateData = recreateData;
  }

  Guid IOfacEntity.EntityGuid => this.EntityGuid;

  Guid? IOfacEntity.ParentEntityGuid => new Guid?();

  OfacSystem.OfacCriteria IOfacEntity.GetSearchCriteria(IOfacSetting ofacSetting)
  {
    OfacSystem.OfacCriteria searchCriteria = new OfacSystem.OfacCriteria((IOfacEntity) this);
    searchCriteria.EntityType = nameof (ClaimOFACEntity);
    searchCriteria.RecreateTypeName = this.RecreateData;
    searchCriteria.LastName = this.DisplayName;
    if (!(ofacSetting is IntelligentSearch))
    {
      searchCriteria.Address = this.Address1;
      searchCriteria.City = this.City;
      searchCriteria.State = this.State;
      searchCriteria.ZipCode = this.ZipCode;
      searchCriteria.IsoCountryCode = this.ISOCountryCode;
      if (ofacSetting is PublicWebServices)
      {
        string str = DefaultDatabase.ExecuteScalar<string>(CommandType.Text, "SELECT Country FROM tblAddressResolver_Countries WITH (NOLOCK) WHERE ISOCode = @ISO", new object[2]
        {
          (object) "@ISO",
          (object) this.ISOCountryCode
        });
        searchCriteria.IsoCountryCode = str;
      }
    }
    return searchCriteria;
  }
}
