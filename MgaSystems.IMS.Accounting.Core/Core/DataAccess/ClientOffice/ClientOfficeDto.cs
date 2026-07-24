// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Core.DataAccess.ClientOffice.ClientOfficeDto
// Assembly: MgaSystems.IMS.Accounting.Core, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 923053EF-B70A-44B5-B8DA-B227263F4FD2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Core.dll

using MGASystems.Data.DataMapping;
using MGASystems.Data.Dto;
using System;

#nullable disable
namespace MGASystems.IMS.Accounting.Core.DataAccess.ClientOffice;

public class ClientOfficeDto : DtoBase<int>
{
  [TableFieldMapping("OfficeID")]
  public int OfficeId { get; set; }

  [TableFieldMapping("OfficeGUID")]
  public Guid OfficeGuid { get; set; }

  [TableFieldMapping("NextInvoiceNum")]
  public int? NextInvoiceNumber { get; set; }

  [TableFieldMapping("Location")]
  public string Location { get; set; }

  [TableFieldMapping("Address1")]
  public string Address1 { get; set; }

  [TableFieldMapping("Address2")]
  public string Address2 { get; set; }

  [TableFieldMapping("City")]
  public string City { get; set; }

  [TableFieldMapping("County")]
  public string County { get; set; }

  [TableFieldMapping("State")]
  public string State { get; set; }

  [TableFieldMapping("Region")]
  public string Region { get; set; }

  [TableFieldMapping("ISOCountryCode")]
  public string IsoCountryCode { get; set; }

  [TableFieldMapping("Phone")]
  public string Phone { get; set; }

  [TableFieldMapping("Fax")]
  public string Fax { get; set; }

  [TableFieldMapping("FEIN")]
  public string FEIN { get; set; }

  [TableFieldMapping("ZipCode")]
  public string ZipCode { get; set; }

  [TableFieldMapping("ZipPlus")]
  public string ZipPlus { get; set; }

  [TableFieldMapping("StatusID")]
  public int StatusId { get; set; }

  [TableFieldMapping("AccountingOffice")]
  public bool AccountingOffice { get; set; }

  [TableFieldMapping("ParentOfficeGuid")]
  public Guid? ParentOfficeGuid { get; set; }

  [TableFieldMapping("DBA")]
  public string DoingBusinessAs { get; set; }

  [TableFieldMapping("CurrencyCode")]
  public string CurrencyCode { get; set; }

  [TableFieldMapping("Email")]
  public string Email { get; set; }

  [TableFieldMapping("SortOrder")]
  public int? SortOrder { get; set; }

  public override int UniqueIdentifier => this.OfficeId;
}
