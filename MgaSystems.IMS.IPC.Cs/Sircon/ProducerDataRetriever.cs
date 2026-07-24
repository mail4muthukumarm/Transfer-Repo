// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.Sircon.ProducerDataRetriever
// Assembly: MgaSystems.IMS.IPC.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 902BD8FA-9BAE-43A4-A4AA-C9585D23F16B
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.IPC.Cs.dll

using MGASystems.Common;
using MGASystems.Common.Extensions;
using MGASystems.IMS.InsuredsProducersCompanies.SirconProducerDataService;
using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Text;

#nullable disable
namespace MGASystems.IMS.InsuredsProducersCompanies.Sircon;

public class ProducerDataRetriever
{
  private int SubscriberID = Utilities.SirconSubscriberID;
  private List<MGASystems.IMS.InsuredsProducersCompanies.SirconProducerDataService.SectionType> userSectionTypeList = new List<MGASystems.IMS.InsuredsProducersCompanies.SirconProducerDataService.SectionType>();
  private string _producerNameCriteria = string.Empty;
  private string _dataValueCriteria = string.Empty;
  private ItemChoiceType _dataTypeCriteria;
  private ProducerDataRetriever.ProducerType _producerType;
  private readonly SirconLog _sirconLog = new SirconLog();
  private const int ProducerNameSize = 155;
  private const int CustomerIdSize = 50;
  private const int NPNSize = 20;
  private const int ProducerIdSize = 9;
  private const int TINSize = 9;

  public void AddSectionTypes(ProducerDataRetriever.SectionType userEnteredType)
  {
    switch (userEnteredType)
    {
      case ProducerDataRetriever.SectionType.Addresses:
        this.userSectionTypeList.Add(MGASystems.IMS.InsuredsProducersCompanies.SirconProducerDataService.SectionType.Addresses);
        break;
      case ProducerDataRetriever.SectionType.Agreements:
        this.userSectionTypeList.Add(MGASystems.IMS.InsuredsProducersCompanies.SirconProducerDataService.SectionType.Agreements);
        break;
      case ProducerDataRetriever.SectionType.Appointments:
        this.userSectionTypeList.Add(MGASystems.IMS.InsuredsProducersCompanies.SirconProducerDataService.SectionType.Appointments);
        break;
      case ProducerDataRetriever.SectionType.BackgroundInvestigations:
        this.userSectionTypeList.Add(MGASystems.IMS.InsuredsProducersCompanies.SirconProducerDataService.SectionType.BackgroundInvestigations);
        break;
      case ProducerDataRetriever.SectionType.ContinuingEducation:
        this.userSectionTypeList.Add(MGASystems.IMS.InsuredsProducersCompanies.SirconProducerDataService.SectionType.ContinuingEducation);
        break;
      case ProducerDataRetriever.SectionType.EducationCredentials:
        this.userSectionTypeList.Add(MGASystems.IMS.InsuredsProducersCompanies.SirconProducerDataService.SectionType.EducationCredentials);
        break;
      case ProducerDataRetriever.SectionType.ExternalSystemIds:
        this.userSectionTypeList.Add(MGASystems.IMS.InsuredsProducersCompanies.SirconProducerDataService.SectionType.ExternalSystemIds);
        break;
      case ProducerDataRetriever.SectionType.Licenses:
        this.userSectionTypeList.Add(MGASystems.IMS.InsuredsProducersCompanies.SirconProducerDataService.SectionType.Licenses);
        break;
      case ProducerDataRetriever.SectionType.Loas:
        this.userSectionTypeList.Add(MGASystems.IMS.InsuredsProducersCompanies.SirconProducerDataService.SectionType.Loas);
        break;
      case ProducerDataRetriever.SectionType.BusinessRules:
        this.userSectionTypeList.Add(MGASystems.IMS.InsuredsProducersCompanies.SirconProducerDataService.SectionType.BusinessRules);
        break;
      case ProducerDataRetriever.SectionType.ResidentStates:
        this.userSectionTypeList.Add(MGASystems.IMS.InsuredsProducersCompanies.SirconProducerDataService.SectionType.ResidentStates);
        break;
      case ProducerDataRetriever.SectionType.Associations:
        this.userSectionTypeList.Add(MGASystems.IMS.InsuredsProducersCompanies.SirconProducerDataService.SectionType.Associations);
        break;
      case ProducerDataRetriever.SectionType.RequiredItems:
        this.userSectionTypeList.Add(MGASystems.IMS.InsuredsProducersCompanies.SirconProducerDataService.SectionType.RequiredItems);
        break;
      case ProducerDataRetriever.SectionType.IncompleteInformationErrors:
        this.userSectionTypeList.Add(MGASystems.IMS.InsuredsProducersCompanies.SirconProducerDataService.SectionType.IncompleteInformationErrors);
        break;
      case ProducerDataRetriever.SectionType.InvalidInformationErrors:
        this.userSectionTypeList.Add(MGASystems.IMS.InsuredsProducersCompanies.SirconProducerDataService.SectionType.InvalidInformationErrors);
        break;
      case ProducerDataRetriever.SectionType.PhoneNumbers:
        this.userSectionTypeList.Add(MGASystems.IMS.InsuredsProducersCompanies.SirconProducerDataService.SectionType.PhoneNumbers);
        break;
      case ProducerDataRetriever.SectionType.BusinessUnits:
        this.userSectionTypeList.Add(MGASystems.IMS.InsuredsProducersCompanies.SirconProducerDataService.SectionType.BusinessUnits);
        break;
      case ProducerDataRetriever.SectionType.Securities:
        this.userSectionTypeList.Add(MGASystems.IMS.InsuredsProducersCompanies.SirconProducerDataService.SectionType.Securities);
        break;
      case ProducerDataRetriever.SectionType.AuthorizationOverrides:
        this.userSectionTypeList.Add(MGASystems.IMS.InsuredsProducersCompanies.SirconProducerDataService.SectionType.AuthorizationOverrides);
        break;
    }
  }

  public void SetSearchCriteria(
    string producerName,
    ProducerDataRetriever.ProducerIdentifiers dataType,
    string dataValue,
    ProducerDataRetriever.ProducerType producerType)
  {
    this._producerNameCriteria = Utilities.limitStringLength(producerName, 155);
    this._producerType = producerType;
    switch (dataType)
    {
      case ProducerDataRetriever.ProducerIdentifiers.CustomerId:
        this._dataTypeCriteria = ItemChoiceType.CustomerId;
        this._dataValueCriteria = Utilities.limitStringLength(dataValue, 50);
        break;
      case ProducerDataRetriever.ProducerIdentifiers.NPN:
        this._dataTypeCriteria = ItemChoiceType.NPN;
        this._dataValueCriteria = Utilities.limitStringLength(dataValue, 20);
        break;
      case ProducerDataRetriever.ProducerIdentifiers.ProducerId:
        this._dataTypeCriteria = ItemChoiceType.ProducerId;
        this._dataValueCriteria = Utilities.limitStringLength(dataValue, 9);
        break;
      case ProducerDataRetriever.ProducerIdentifiers.TIN:
        this._dataTypeCriteria = ItemChoiceType.TIN;
        this._dataValueCriteria = Utilities.limitStringLength(dataValue, 9);
        break;
    }
  }

  public ProducerData RetrieveData()
  {
    try
    {
      ProducerQuery producerQuery = new ProducerQuery();
      producerQuery.Carrier = new CarrierType()
      {
        id = Utilities.SirconCarrierID,
        idSpecified = true
      };
      ProducerCriteriaType producerCriteriaType = new ProducerCriteriaType()
      {
        Name = this._producerNameCriteria,
        ItemElementName = this._dataTypeCriteria,
        Item = (object) this._dataValueCriteria
      };
      switch (this._producerType)
      {
        case ProducerDataRetriever.ProducerType.Agency:
          producerCriteriaType.EntityType = EntityType.Agency;
          producerCriteriaType.EntityTypeSpecified = true;
          break;
        case ProducerDataRetriever.ProducerType.Individual:
          producerCriteriaType.EntityType = EntityType.Individual;
          producerCriteriaType.EntityTypeSpecified = true;
          break;
        default:
          producerCriteriaType.EntityTypeSpecified = false;
          break;
      }
      producerQuery.ProducerCriteria = producerCriteriaType;
      int index = 0;
      ProducerQuerySectionType[] querySectionTypeArray = new ProducerQuerySectionType[this.userSectionTypeList.Count];
      foreach (int userSectionType in this.userSectionTypeList)
        querySectionTypeArray[index] = new ProducerQuerySectionType()
        {
          Value = this.userSectionTypeList[index++]
        };
      producerQuery.SectionConfiguration = querySectionTypeArray;
      SecurityHeaderType securityHeader = this.getSecurityHeader();
      ProducerLifecycleServicePortTypeClient servicePortTypeClient = new ProducerLifecycleServicePortTypeClient((Binding) new BasicHttpBinding(BasicHttpSecurityMode.Transport), new EndpointAddress(Utilities.SirconEndPoint));
      if (this._sirconLog.IsEnabled)
      {
        Encryption encryption = new Encryption();
        this._sirconLog.WriteSeparator("Encrypted SecurityHeader");
        this._sirconLog.WriteMsg(encryption.EncryptTripleDes(securityHeader.SerializeToXml()));
        this._sirconLog.WriteSeparator("Encrypted Carrier");
        this._sirconLog.WriteMsg(encryption.EncryptTripleDes(producerQuery.Carrier.SerializeToXml()));
        this._sirconLog.WriteSeparator("Encrypted ProducerQuery");
        this._sirconLog.WriteMsg(encryption.EncryptTripleDes(producerQuery.SerializeToXml()));
        this._sirconLog.WriteSeparator("SirconProducerCriteria");
        this._sirconLog.WriteMsg(producerQuery.ProducerCriteria.SerializeToXml());
        this._sirconLog.WriteSeparator("SirconSectionType");
        this._sirconLog.WriteMsg(producerQuery.SectionConfiguration.SerializeToXml());
        this._sirconLog.WriteSeparator("VersionType.Item10");
        this._sirconLog.WriteMsg(VersionType.Item10.ToString());
        this._sirconLog.WriteSeparator("Encrypted SubscriberID");
        this._sirconLog.WriteMsg(encryption.EncryptTripleDes(this.SubscriberID.ToString()));
        this._sirconLog.WriteSeparator("Sircon API Call");
        this._sirconLog.WriteMsg("Start");
      }
      SecurityHeaderType Security = securityHeader;
      ref int local = ref this.SubscriberID;
      ProducerQuery ProducerQuery1 = producerQuery;
      ProducerQueryResponse SirconResponse = servicePortTypeClient.producerQuery(Security, VersionType.Item10, ref local, ProducerQuery1);
      this._sirconLog.WriteMsg("End Successful");
      return new ProducerResponse().ProcessSirconResponse(SirconResponse);
    }
    catch (Exception ex)
    {
      this._sirconLog.WriteMsg("End Failure - " + ex.Message);
      ProducerData producerData = new ProducerData();
      producerData.isValid = false;
      string str1;
      string str2 = str1 = "Exception Thrown - " + ex.Message;
      producerData.SirconStatus = str1;
      producerData.statusMessage = str2;
      return producerData;
    }
  }

  private SecurityHeaderType getSecurityHeader()
  {
    string sirconUsername = Utilities.SirconUsername;
    string sirconPassword = Utilities.SirconPassword;
    DateTime now = DateTime.Now;
    DateTime dateTime = TimeZoneInfo.ConvertTimeBySystemTimeZoneId(now, "GMT Standard Time");
    UsernameToken token = new UsernameToken()
    {
      Username = sirconUsername,
      Nonce = Encoding.UTF8.GetBytes(dateTime.ToString("HH:mm:ss MM/dd/yyyy")),
      Created = new DateTime?(dateTime)
    };
    token.Password = new PasswordDigest(token)
    {
      Password = sirconPassword
    };
    SecurityHeaderType securityHeader = new SecurityHeaderType();
    securityHeader.UsernameToken = token;
    if (!this._sirconLog.IsEnabled)
      return securityHeader;
    Encryption encryption = new Encryption();
    this._sirconLog.WriteSeparator("securityHeader Details");
    this._sirconLog.WriteMsg("Encrypted Username - " + encryption.EncryptTripleDes(sirconUsername));
    this._sirconLog.WriteMsg("Encrypted Password - " + encryption.EncryptTripleDes(sirconPassword));
    this._sirconLog.WriteMsg("timeNow - " + now.ToString("HH:mm:ss MM/dd/yyyy"));
    this._sirconLog.WriteMsg("timeGMT - " + dateTime.ToString("HH:mm:ss MM/dd/yyyy"));
    this._sirconLog.WriteMsg("Nonce - " + Encoding.UTF8.GetString(token.Nonce, 0, token.Nonce.Length));
    return securityHeader;
  }

  public enum ProducerIdentifiers
  {
    CustomerId,
    NPN,
    ProducerId,
    TIN,
  }

  public enum SectionType
  {
    Addresses,
    Agreements,
    Appointments,
    BackgroundInvestigations,
    ContinuingEducation,
    EducationCredentials,
    ExternalSystemIds,
    Licenses,
    Loas,
    BusinessRules,
    ResidentStates,
    Associations,
    RequiredItems,
    IncompleteInformationErrors,
    InvalidInformationErrors,
    PhoneNumbers,
    BusinessUnits,
    Securities,
    AuthorizationOverrides,
  }

  public enum ProducerType
  {
    Agency,
    Individual,
    NotSpecified,
  }
}
