// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.SirconProducerDataService.ProducerLifecycleServicePortType
// Assembly: MgaSystems.IMS.IPC.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 902BD8FA-9BAE-43A4-A4AA-C9585D23F16B
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.IPC.Cs.dll

using System.CodeDom.Compiler;
using System.ServiceModel;
using System.Threading.Tasks;

#nullable disable
namespace MGASystems.IMS.InsuredsProducersCompanies.SirconProducerDataService;

[GeneratedCode("System.ServiceModel", "4.0.0.0")]
[ServiceContract(Namespace = "http://sdb.sircon.com/webservice/2006/06/ProducerLifecycleService", ConfigurationName = "SirconProducerDataService.ProducerLifecycleServicePortType")]
public interface ProducerLifecycleServicePortType
{
  [OperationContract(Action = "availableAppointmentProfiles", ReplyAction = "*")]
  [XmlSerializerFormat(SupportFaults = true)]
  [ServiceKnownType(typeof (DocumentType))]
  [ServiceKnownType(typeof (RequiredItemType))]
  availableAppointmentProfilesResponse availableAppointmentProfiles(
    availableAppointmentProfilesRequest1 request);

  [OperationContract(Action = "availableAppointmentProfiles", ReplyAction = "*")]
  Task<availableAppointmentProfilesResponse> availableAppointmentProfilesAsync(
    availableAppointmentProfilesRequest1 request);

  [OperationContract(Action = "buildPotentialAppointments", ReplyAction = "*")]
  [XmlSerializerFormat(SupportFaults = true)]
  [ServiceKnownType(typeof (DocumentType))]
  [ServiceKnownType(typeof (RequiredItemType))]
  buildPotentialAppointmentsResponse buildPotentialAppointments(
    buildPotentialAppointmentsRequest1 request);

  [OperationContract(Action = "buildPotentialAppointments", ReplyAction = "*")]
  Task<buildPotentialAppointmentsResponse> buildPotentialAppointmentsAsync(
    buildPotentialAppointmentsRequest1 request);

  [OperationContract(Action = "requestStatusNotification", ReplyAction = "*")]
  [XmlSerializerFormat(SupportFaults = true)]
  [ServiceKnownType(typeof (DocumentType))]
  [ServiceKnownType(typeof (RequiredItemType))]
  requestStatusNotificationResponse1 requestStatusNotification(
    requestStatusNotificationRequest1 request);

  [OperationContract(Action = "requestStatusNotification", ReplyAction = "*")]
  Task<requestStatusNotificationResponse1> requestStatusNotificationAsync(
    requestStatusNotificationRequest1 request);

  [OperationContract(Action = "buildPotentialTerminations", ReplyAction = "*")]
  [XmlSerializerFormat(SupportFaults = true)]
  [ServiceKnownType(typeof (DocumentType))]
  [ServiceKnownType(typeof (RequiredItemType))]
  buildPotentialTerminationsResponse buildPotentialTerminations(
    buildPotentialTerminationsRequest1 request);

  [OperationContract(Action = "buildPotentialTerminations", ReplyAction = "*")]
  Task<buildPotentialTerminationsResponse> buildPotentialTerminationsAsync(
    buildPotentialTerminationsRequest1 request);

  [OperationContract(Action = "createAgreement", ReplyAction = "*")]
  [XmlSerializerFormat(SupportFaults = true)]
  [ServiceKnownType(typeof (DocumentType))]
  [ServiceKnownType(typeof (RequiredItemType))]
  createAgreementResponse createAgreement(createAgreementRequest request);

  [OperationContract(Action = "createAgreement", ReplyAction = "*")]
  Task<createAgreementResponse> createAgreementAsync(createAgreementRequest request);

  [OperationContract(Action = "createRelationship", ReplyAction = "*")]
  [XmlSerializerFormat(SupportFaults = true)]
  [ServiceKnownType(typeof (DocumentType))]
  [ServiceKnownType(typeof (RequiredItemType))]
  createRelationshipResponse createRelationship(createRelationshipRequest request);

  [OperationContract(Action = "createRelationship", ReplyAction = "*")]
  Task<createRelationshipResponse> createRelationshipAsync(createRelationshipRequest request);

  [OperationContract(Action = "inactivateLicenseState", ReplyAction = "*")]
  [XmlSerializerFormat(SupportFaults = true)]
  [ServiceKnownType(typeof (DocumentType))]
  [ServiceKnownType(typeof (RequiredItemType))]
  inactivateLicenseStateResponse1 inactivateLicenseState(inactivateLicenseStateRequest1 request);

  [OperationContract(Action = "inactivateLicenseState", ReplyAction = "*")]
  Task<inactivateLicenseStateResponse1> inactivateLicenseStateAsync(
    inactivateLicenseStateRequest1 request);

  [OperationContract(Action = "inactivateRelationship", ReplyAction = "*")]
  [XmlSerializerFormat(SupportFaults = true)]
  [ServiceKnownType(typeof (DocumentType))]
  [ServiceKnownType(typeof (RequiredItemType))]
  inactivateRelationshipResponse inactivateRelationship(createRelationshipRequest request);

  [OperationContract(Action = "inactivateRelationship", ReplyAction = "*")]
  Task<inactivateRelationshipResponse> inactivateRelationshipAsync(createRelationshipRequest request);

  [OperationContract(Action = "newProducer", ReplyAction = "*")]
  [XmlSerializerFormat(SupportFaults = true)]
  [ServiceKnownType(typeof (DocumentType))]
  [ServiceKnownType(typeof (RequiredItemType))]
  newProducerResponse newProducer(newProducerRequest request);

  [OperationContract(Action = "newProducer", ReplyAction = "*")]
  Task<newProducerResponse> newProducerAsync(newProducerRequest request);

  [OperationContract(Action = "producerQuery", ReplyAction = "*")]
  [XmlSerializerFormat(SupportFaults = true)]
  [ServiceKnownType(typeof (DocumentType))]
  [ServiceKnownType(typeof (RequiredItemType))]
  producerQueryResponse1 producerQuery(producerQueryRequest request);

  [OperationContract(Action = "producerQuery", ReplyAction = "*")]
  Task<producerQueryResponse1> producerQueryAsync(producerQueryRequest request);

  [OperationContract(Action = "retrieveRelationship", ReplyAction = "*")]
  [XmlSerializerFormat(SupportFaults = true)]
  [ServiceKnownType(typeof (DocumentType))]
  [ServiceKnownType(typeof (RequiredItemType))]
  retrieveRelationshipResponse retrieveRelationship(createRelationshipRequest request);

  [OperationContract(Action = "retrieveRelationship", ReplyAction = "*")]
  Task<retrieveRelationshipResponse> retrieveRelationshipAsync(createRelationshipRequest request);

  [OperationContract(Action = "selectHierarchyTemplate", ReplyAction = "*")]
  [XmlSerializerFormat(SupportFaults = true)]
  [ServiceKnownType(typeof (DocumentType))]
  [ServiceKnownType(typeof (RequiredItemType))]
  selectHierarchyTemplateResponse selectHierarchyTemplate(createAgreementRequest request);

  [OperationContract(Action = "selectHierarchyTemplate", ReplyAction = "*")]
  Task<selectHierarchyTemplateResponse> selectHierarchyTemplateAsync(createAgreementRequest request);

  [OperationContract(Action = "selectLooseHierarchyTemplate", ReplyAction = "*")]
  [XmlSerializerFormat(SupportFaults = true)]
  [ServiceKnownType(typeof (DocumentType))]
  [ServiceKnownType(typeof (RequiredItemType))]
  selectLooseHierarchyTemplateResponse selectLooseHierarchyTemplate(createAgreementRequest request);

  [OperationContract(Action = "selectLooseHierarchyTemplate", ReplyAction = "*")]
  Task<selectLooseHierarchyTemplateResponse> selectLooseHierarchyTemplateAsync(
    createAgreementRequest request);

  [OperationContract(Action = "submitAppointments", ReplyAction = "*")]
  [XmlSerializerFormat(SupportFaults = true)]
  [ServiceKnownType(typeof (DocumentType))]
  [ServiceKnownType(typeof (RequiredItemType))]
  submitAppointmentsResponse submitAppointments(submitAppointmentsRequest1 request);

  [OperationContract(Action = "submitAppointments", ReplyAction = "*")]
  Task<submitAppointmentsResponse> submitAppointmentsAsync(submitAppointmentsRequest1 request);

  [OperationContract(Action = "updateProducerRecord", ReplyAction = "*")]
  [XmlSerializerFormat(SupportFaults = true)]
  [ServiceKnownType(typeof (DocumentType))]
  [ServiceKnownType(typeof (RequiredItemType))]
  updateProducerRecordResponse1 updateProducerRecord(updateProducerRecordRequest1 request);

  [OperationContract(Action = "updateProducerRecord", ReplyAction = "*")]
  Task<updateProducerRecordResponse1> updateProducerRecordAsync(updateProducerRecordRequest1 request);

  [OperationContract(Action = "validateHierarchyTemplate", ReplyAction = "*")]
  [XmlSerializerFormat(SupportFaults = true)]
  [ServiceKnownType(typeof (DocumentType))]
  [ServiceKnownType(typeof (RequiredItemType))]
  validateHierarchyTemplateResponse validateHierarchyTemplate(createAgreementRequest request);

  [OperationContract(Action = "validateHierarchyTemplate", ReplyAction = "*")]
  Task<validateHierarchyTemplateResponse> validateHierarchyTemplateAsync(
    createAgreementRequest request);
}
