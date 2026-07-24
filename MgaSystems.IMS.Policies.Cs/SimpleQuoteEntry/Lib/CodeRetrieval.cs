// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.Policies.SimpleQuoteEntry.Lib.CodeRetrieval
// Assembly: MgaSystems.IMS.Policies.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 0490D932-1980-4BA9-8AB9-51DC95793BA0
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Policies.Cs.dll

using MGASystems.Common;
using MGASystems.Data;
using MgaSystems.IMS.Policies.SimpleQuoteEntry.SharedModels;
using MGASystems.IMS.Security;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;

#nullable disable
namespace MgaSystems.IMS.Policies.SimpleQuoteEntry.Lib;

public static class CodeRetrieval
{
  public static ObservableCollection<BusinessTypes> GetBusinessTypes()
  {
    return new ObservableCollection<BusinessTypes>((IEnumerable<BusinessTypes>) DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT * FROM lstBusinessTypes WHERE Hidden = 0").AsEnumerable().Select<DataRow, BusinessTypes>((System.Func<DataRow, BusinessTypes>) (row => new BusinessTypes()
    {
      BusinessTypeID = row.Field<byte>("BusinessTypeID"),
      BusinessType = row.Field<string>("BusinessType"),
      Hidden = row.Field<bool>("Hidden"),
      Individual = row.Field<bool>("Individual")
    })));
  }

  public static ObservableCollection<Statuses> GetStatuses()
  {
    return new ObservableCollection<Statuses>((IEnumerable<Statuses>) DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT StatusID, Status FROM lstStatus WHERE Disable = 0").AsEnumerable().Select<DataRow, Statuses>((System.Func<DataRow, Statuses>) (row => new Statuses()
    {
      StatusID = row.Field<byte>("StatusID"),
      Status = row.Field<string>("Status")
    })));
  }

  public static ObservableCollection<Title> GetTitles()
  {
    return new ObservableCollection<Title>((IEnumerable<Title>) DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT Salutation FROM lstSalutations").AsEnumerable().Select<DataRow, Title>((System.Func<DataRow, Title>) (row => new Title()
    {
      Salutation = row.Field<string>("Salutation")
    })));
  }

  public static ObservableCollection<ISOCountry> GetCountries()
  {
    return new ObservableCollection<ISOCountry>((IEnumerable<ISOCountry>) DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT * FROM tblAddressResolver_Countries").AsEnumerable().Select<DataRow, ISOCountry>((System.Func<DataRow, ISOCountry>) (row => new ISOCountry()
    {
      Country = row.Field<string>("Country"),
      ISOCode = row.Field<string>("ISOCode")
    })));
  }

  public static QuoteEditCode QuoteEditDataRetrieval(Guid producerLocationGuid)
  {
    QuoteEditCode quoteEditCode = new QuoteEditCode();
    DataSet dataSet = DefaultDatabase.ExecuteDataSet(MGASystems.IMS.NoteDocuments.SystemSettings.GetSetting<string>("DataOverride_QuoteEditData", "dbo.QuoteEditData"), new object[4]
    {
      (object) "@ProducerLocationGuid",
      (object) producerLocationGuid,
      (object) "@CurrentUserGuid",
      (object) CurrentUser.Instance.UserGUID
    });
    quoteEditCode.QuotingOffices = !CurrentUser.Instance.IsAccountingPackageActive ? new ObservableCollection<ClientOffice>((IEnumerable<ClientOffice>) dataSet.Tables[3].AsEnumerable().Select<DataRow, ClientOffice>((System.Func<DataRow, ClientOffice>) (row => new ClientOffice()
    {
      Location = row.Field<string>("Location"),
      OfficeGuid = row.Field<Guid>("OfficeGuid"),
      HasChartOfAccounts = row.Field<bool>("HasChartOfAccounts")
    }))) : new ObservableCollection<ClientOffice>((IEnumerable<ClientOffice>) dataSet.Tables[3].AsEnumerable().Select<DataRow, ClientOffice>((System.Func<DataRow, ClientOffice>) (row => new ClientOffice()
    {
      Location = row.Field<string>("Location"),
      OfficeGuid = row.Field<Guid>("OfficeGuid"),
      HasChartOfAccounts = row.Field<bool>("HasChartOfAccounts")
    })).Where<ClientOffice>((System.Func<ClientOffice, bool>) (a => a.HasChartOfAccounts)));
    quoteEditCode.Lines = new ObservableCollection<Line>((IEnumerable<Line>) dataSet.Tables[1].AsEnumerable().Select<DataRow, Line>((System.Func<DataRow, Line>) (row => new Line()
    {
      LineGuid = row.Field<Guid>("LineGuid"),
      OfficeGuid = row.Field<Guid>("OfficeGuid"),
      LineName = row.Field<string>("LineName")
    })));
    quoteEditCode.IssuingOffices = new ObservableCollection<IssuingOffice>((IEnumerable<IssuingOffice>) dataSet.Tables[13].AsEnumerable().Select<DataRow, IssuingOffice>((System.Func<DataRow, IssuingOffice>) (row => new IssuingOffice()
    {
      Location = row.Field<string>("Location"),
      OfficeGuid = row.Field<Guid>("OfficeGuid")
    })));
    quoteEditCode.PolicyTypes = new ObservableCollection<PolicyType>((IEnumerable<PolicyType>) dataSet.Tables[2].AsEnumerable().Select<DataRow, PolicyType>((System.Func<DataRow, PolicyType>) (row => new PolicyType()
    {
      PolicyTypeID = row.Field<byte>("PolicyTypeID"),
      Description = row.Field<string>("Description")
    })));
    quoteEditCode.ProgramCodes = new ObservableCollection<ProgramCode>((IEnumerable<ProgramCode>) dataSet.Tables[11].AsEnumerable().Select<DataRow, ProgramCode>((System.Func<DataRow, ProgramCode>) (row => new ProgramCode()
    {
      CompanyLocationGuid = row.Field<Guid>("CompanyLocationGUID"),
      StateID = row.Field<string>("StateID"),
      ContractEffective = row.Field<DateTime>("ContractEffective"),
      ContractExpiration = row.Field<DateTime>("ContractExpiration"),
      LineGuid = row.Field<Guid>("LineGUID"),
      IssuingOfficeGuid = row.Field<Guid>("IssuingOfficeGUID"),
      ProgCode = row.Field<string>("ProgCode"),
      ProgramID = row.Field<int>("ProgramID"),
      GroupCode = row.Field<string>("GroupCode")
    })));
    return quoteEditCode;
  }

  public static ObservableCollection<States> GetStates(Guid lineGuid, Guid producerLocationGuid)
  {
    return new ObservableCollection<States>((IEnumerable<States>) DefaultDatabase.ExecuteDataTable(CommandType.StoredProcedure, MGASystems.IMS.NoteDocuments.SystemSettings.GetSetting<string>("DataOverride_QuoteEditData_GetStates", "dbo.QuoteEditData_GetStates"), new object[4]
    {
      (object) "@lineGuid",
      (object) lineGuid,
      (object) "@producerLocationGuid",
      (object) producerLocationGuid
    }).AsEnumerable().Select<DataRow, States>((System.Func<DataRow, States>) (row => new States()
    {
      State = row.Field<string>("State"),
      StateID = row.Field<string>("StateID")
    })));
  }

  public static ObservableCollection<Underwriter> GetUnderwriters(Guid lineGuid)
  {
    bool flag = SecurityManager.Instance.AssertPermission(new Guid("0FA0118C-D65D-49da-8330-220B26A5B652"));
    return new ObservableCollection<Underwriter>((IEnumerable<Underwriter>) DefaultDatabase.ExecuteDataTable(CommandType.StoredProcedure, "QuoteEditData_GetUnderwriters", new object[6]
    {
      (object) "@lineGuid",
      (object) lineGuid,
      (object) "@selectAllOffices",
      (object) flag,
      (object) "@issuingOffice",
      null
    }).AsEnumerable().Select<DataRow, Underwriter>((System.Func<DataRow, Underwriter>) (row => new Underwriter()
    {
      FullName = row.Field<string>("FullName"),
      UserGuid = row.Field<Guid>("UserGuid")
    })));
  }

  public static ObservableCollection<CompanyLocation> GetCompanyLocations(
    string stateID,
    Guid producerLocationGuid,
    Guid lineGuid,
    Guid? quotingOfficeGuid)
  {
    return new ObservableCollection<CompanyLocation>((IEnumerable<CompanyLocation>) DefaultDatabase.ExecuteDataTable(CommandType.StoredProcedure, "GetQuoteEditCompanyLocations", new object[10]
    {
      (object) "@StateID",
      (object) stateID,
      (object) "@ProducerLocationGuid",
      (object) producerLocationGuid,
      (object) "@LineGuid",
      (object) lineGuid,
      (object) "@OfficeGuid",
      (object) quotingOfficeGuid,
      (object) "@quoteGuid",
      null
    }).AsEnumerable().Select<DataRow, CompanyLocation>((System.Func<DataRow, CompanyLocation>) (row => new CompanyLocation()
    {
      Name = row.Field<string>("Name"),
      CompanyLocationGuid = row.Field<Guid>("CompanyLocationGuid")
    })));
  }

  public static ObservableCollection<BillingTypes> GetBillingTypes(Guid companyLineGuid)
  {
    return new ObservableCollection<BillingTypes>((IEnumerable<BillingTypes>) DefaultDatabase.ExecuteDataTable(CommandType.StoredProcedure, "QuoteEditData_GetBillingTypes", new object[2]
    {
      (object) "@companyLineGuid",
      (object) companyLineGuid
    }).AsEnumerable().Select<DataRow, BillingTypes>((System.Func<DataRow, BillingTypes>) (row => new BillingTypes()
    {
      BillingTypeID = row.Field<int>("BillingTypeID"),
      BillingType = row.Field<string>("BillingType"),
      BillingCode = row.Field<string>("BillingCode"),
      OnCompanyLine = row.Field<bool>("OnCompanyLine")
    })));
  }

  public static Guid GetCompanyLineGuid(Guid companyLocationGuid, Guid lineGuid, string stateID)
  {
    try
    {
      return DefaultDatabase.ExecuteScalar<Guid>(CommandType.Text, "SELECT CompanyLineGuid FROM tblCompanyLines WITH (NOLOCK) WHERE CompanyLocationGuid=@CompanyLocationGuid AND StateID=@StateID AND LineGuid=@LineGuid AND ParentCompanyLineGuid IS NULL", new object[6]
      {
        (object) "@CompanyLocationGuid",
        (object) companyLocationGuid,
        (object) "@StateID",
        (object) stateID,
        (object) "@LineGuid",
        (object) lineGuid
      });
    }
    catch (InvalidCastException ex)
    {
      throw new InvalidCastException("Could not determine the CompanyLineGuid", (Exception) ex);
    }
  }

  public static ObservableCollection<DeliveryMethod> GetDeliveryMethods()
  {
    return new ObservableCollection<DeliveryMethod>((IEnumerable<DeliveryMethod>) DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT * FROM lstDeliveryMethod").AsEnumerable().Select<DataRow, DeliveryMethod>((System.Func<DataRow, DeliveryMethod>) (row => new DeliveryMethod()
    {
      DeliveryMethodID = row.Field<byte>("DeliveryMethodID"),
      Description = row.Field<string>("Description")
    })));
  }

  public static ObservableCollection<OfficeType> GetOfficeTypes()
  {
    return new ObservableCollection<OfficeType>((IEnumerable<OfficeType>) DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT * FROM lstLocationType ORDER BY SortOrder").AsEnumerable().Select<DataRow, OfficeType>((System.Func<DataRow, OfficeType>) (row => new OfficeType()
    {
      LocationTypeID = row.Field<short>("LocationTypeID"),
      LocationType = row.Field<string>("LocationType")
    })));
  }

  public static ObservableCollection<Gender> GetGenders()
  {
    return new ObservableCollection<Gender>((IEnumerable<Gender>) DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT * FROM lstClaims_Gender").AsEnumerable().Select<DataRow, Gender>((System.Func<DataRow, Gender>) (row => new Gender()
    {
      GenderID = row.Field<int>("GenderID"),
      GenderName = row.Field<string>("Gender")
    })));
  }

  public static ObservableCollection<MgaSystems.IMS.Policies.SimpleQuoteEntry.SharedModels.Currency> GetCurrencies(
    Guid quotingOfficeGuid)
  {
    return new ObservableCollection<MgaSystems.IMS.Policies.SimpleQuoteEntry.SharedModels.Currency>((IEnumerable<MgaSystems.IMS.Policies.SimpleQuoteEntry.SharedModels.Currency>) DefaultDatabase.ExecuteDataTable(CommandType.StoredProcedure, "spFin_GetAuthorizedCurrencies", new object[2]
    {
      (object) "@OfficeGuid",
      (object) quotingOfficeGuid
    }).AsEnumerable().Select<DataRow, MgaSystems.IMS.Policies.SimpleQuoteEntry.SharedModels.Currency>((System.Func<DataRow, MgaSystems.IMS.Policies.SimpleQuoteEntry.SharedModels.Currency>) (row => new MgaSystems.IMS.Policies.SimpleQuoteEntry.SharedModels.Currency()
    {
      CurrencyCode = row.Field<string>("CurrencyCode")
    })));
  }

  public static ObservableCollection<CostCenter> GetCostCenters(
    Guid quotingOfficeGuid,
    Guid underwriterGuid,
    Guid companyLineGuid,
    DateTime effectiveDate)
  {
    return new ObservableCollection<CostCenter>((IEnumerable<CostCenter>) DefaultDatabase.ExecuteDataTable(CommandType.StoredProcedure, "spGetCostCenters", new object[8]
    {
      (object) "@quotingOfficeGuid",
      (object) quotingOfficeGuid,
      (object) "@underwriterGuid",
      (object) underwriterGuid,
      (object) "@companyLineGuid",
      (object) companyLineGuid,
      (object) "@effectiveDate",
      (object) effectiveDate
    }).AsEnumerable().Where<DataRow>((System.Func<DataRow, bool>) (row => !row.Field<bool>("SystemDefined"))).Select<DataRow, CostCenter>((System.Func<DataRow, CostCenter>) (row => new CostCenter()
    {
      GroupId = row.Field<int>("GroupID"),
      GroupName = row.Field<string>("GroupName"),
      IsDefault = row.Field<bool>("IsDefault"),
      SystemDefined = row.Field<bool>("SystemDefined"),
      EffectiveDate = row.Field<DateTime?>("EffectiveDate")
    })));
  }
}
