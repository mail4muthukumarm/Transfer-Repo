// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.SirconProducerDataService.ProducerLifecycleServicePortTypeClient
// Assembly: MgaSystems.IMS.IPC.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 902BD8FA-9BAE-43A4-A4AA-C9585D23F16B
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.IPC.Cs.dll

using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Threading.Tasks;

#nullable disable
namespace MGASystems.IMS.InsuredsProducersCompanies.SirconProducerDataService;

[DebuggerStepThrough]
[GeneratedCode("System.ServiceModel", "4.0.0.0")]
public class ProducerLifecycleServicePortTypeClient : 
  ClientBase<ProducerLifecycleServicePortType>,
  ProducerLifecycleServicePortType
{
  public ProducerLifecycleServicePortTypeClient()
  {
  }

  public ProducerLifecycleServicePortTypeClient(string endpointConfigurationName)
    : base(endpointConfigurationName)
  {
  }

  public ProducerLifecycleServicePortTypeClient(
    string endpointConfigurationName,
    string remoteAddress)
    : base(endpointConfigurationName, remoteAddress)
  {
  }

  public ProducerLifecycleServicePortTypeClient(
    string endpointConfigurationName,
    EndpointAddress remoteAddress)
    : base(endpointConfigurationName, remoteAddress)
  {
  }

  public ProducerLifecycleServicePortTypeClient(Binding binding, EndpointAddress remoteAddress)
    : base(binding, remoteAddress)
  {
  }

  [EditorBrowsable(EditorBrowsableState.Advanced)]
  availableAppointmentProfilesResponse ProducerLifecycleServicePortType.availableAppointmentProfiles(
    availableAppointmentProfilesRequest1 request)
  {
    return this.Channel.availableAppointmentProfiles(request);
  }

  public AppointmentProfileType[] availableAppointmentProfiles(
    int SubscriberId,
    AvailableAppointmentProfilesRequest AvailableAppointmentProfilesRequest)
  {
    return ((ProducerLifecycleServicePortType) this).availableAppointmentProfiles(new availableAppointmentProfilesRequest1()
    {
      SubscriberId = SubscriberId,
      AvailableAppointmentProfilesRequest = AvailableAppointmentProfilesRequest
    }).AppointmentProfilesResponse;
  }

  [EditorBrowsable(EditorBrowsableState.Advanced)]
  Task<availableAppointmentProfilesResponse> ProducerLifecycleServicePortType.availableAppointmentProfilesAsync(
    availableAppointmentProfilesRequest1 request)
  {
    return this.Channel.availableAppointmentProfilesAsync(request);
  }

  public Task<availableAppointmentProfilesResponse> availableAppointmentProfilesAsync(
    int SubscriberId,
    AvailableAppointmentProfilesRequest AvailableAppointmentProfilesRequest)
  {
    return ((ProducerLifecycleServicePortType) this).availableAppointmentProfilesAsync(new availableAppointmentProfilesRequest1()
    {
      SubscriberId = SubscriberId,
      AvailableAppointmentProfilesRequest = AvailableAppointmentProfilesRequest
    });
  }

  [EditorBrowsable(EditorBrowsableState.Advanced)]
  buildPotentialAppointmentsResponse ProducerLifecycleServicePortType.buildPotentialAppointments(
    buildPotentialAppointmentsRequest1 request)
  {
    return this.Channel.buildPotentialAppointments(request);
  }

  public PotentialAppointingTransactionType[] buildPotentialAppointments(
    int SubscriberId,
    BuildPotentialAppointmentsRequest BuildPotentialAppointmentsRequest)
  {
    return ((ProducerLifecycleServicePortType) this).buildPotentialAppointments(new buildPotentialAppointmentsRequest1()
    {
      SubscriberId = SubscriberId,
      BuildPotentialAppointmentsRequest = BuildPotentialAppointmentsRequest
    }).PotentialAppointmentsResponse;
  }

  [EditorBrowsable(EditorBrowsableState.Advanced)]
  Task<buildPotentialAppointmentsResponse> ProducerLifecycleServicePortType.buildPotentialAppointmentsAsync(
    buildPotentialAppointmentsRequest1 request)
  {
    return this.Channel.buildPotentialAppointmentsAsync(request);
  }

  public Task<buildPotentialAppointmentsResponse> buildPotentialAppointmentsAsync(
    int SubscriberId,
    BuildPotentialAppointmentsRequest BuildPotentialAppointmentsRequest)
  {
    return ((ProducerLifecycleServicePortType) this).buildPotentialAppointmentsAsync(new buildPotentialAppointmentsRequest1()
    {
      SubscriberId = SubscriberId,
      BuildPotentialAppointmentsRequest = BuildPotentialAppointmentsRequest
    });
  }

  [EditorBrowsable(EditorBrowsableState.Advanced)]
  requestStatusNotificationResponse1 ProducerLifecycleServicePortType.requestStatusNotification(
    requestStatusNotificationRequest1 request)
  {
    return this.Channel.requestStatusNotification(request);
  }

  public RequestStatusNotificationResponse requestStatusNotification(
    int SubscriberId,
    RequestStatusNotificationRequest RequestStatusNotificationRequest)
  {
    return ((ProducerLifecycleServicePortType) this).requestStatusNotification(new requestStatusNotificationRequest1()
    {
      SubscriberId = SubscriberId,
      RequestStatusNotificationRequest = RequestStatusNotificationRequest
    }).RequestStatusNotificationResponse;
  }

  [EditorBrowsable(EditorBrowsableState.Advanced)]
  Task<requestStatusNotificationResponse1> ProducerLifecycleServicePortType.requestStatusNotificationAsync(
    requestStatusNotificationRequest1 request)
  {
    return this.Channel.requestStatusNotificationAsync(request);
  }

  public Task<requestStatusNotificationResponse1> requestStatusNotificationAsync(
    int SubscriberId,
    RequestStatusNotificationRequest RequestStatusNotificationRequest)
  {
    return ((ProducerLifecycleServicePortType) this).requestStatusNotificationAsync(new requestStatusNotificationRequest1()
    {
      SubscriberId = SubscriberId,
      RequestStatusNotificationRequest = RequestStatusNotificationRequest
    });
  }

  [EditorBrowsable(EditorBrowsableState.Advanced)]
  buildPotentialTerminationsResponse ProducerLifecycleServicePortType.buildPotentialTerminations(
    buildPotentialTerminationsRequest1 request)
  {
    return this.Channel.buildPotentialTerminations(request);
  }

  public PotentialAppointingTransactionType[] buildPotentialTerminations(
    int SubscriberId,
    BuildPotentialTerminationsRequest BuildPotentialTerminationsRequest)
  {
    return ((ProducerLifecycleServicePortType) this).buildPotentialTerminations(new buildPotentialTerminationsRequest1()
    {
      SubscriberId = SubscriberId,
      BuildPotentialTerminationsRequest = BuildPotentialTerminationsRequest
    }).PotentialTerminationsResponse;
  }

  [EditorBrowsable(EditorBrowsableState.Advanced)]
  Task<buildPotentialTerminationsResponse> ProducerLifecycleServicePortType.buildPotentialTerminationsAsync(
    buildPotentialTerminationsRequest1 request)
  {
    return this.Channel.buildPotentialTerminationsAsync(request);
  }

  public Task<buildPotentialTerminationsResponse> buildPotentialTerminationsAsync(
    int SubscriberId,
    BuildPotentialTerminationsRequest BuildPotentialTerminationsRequest)
  {
    return ((ProducerLifecycleServicePortType) this).buildPotentialTerminationsAsync(new buildPotentialTerminationsRequest1()
    {
      SubscriberId = SubscriberId,
      BuildPotentialTerminationsRequest = BuildPotentialTerminationsRequest
    });
  }

  [EditorBrowsable(EditorBrowsableState.Advanced)]
  createAgreementResponse ProducerLifecycleServicePortType.createAgreement(
    createAgreementRequest request)
  {
    return this.Channel.createAgreement(request);
  }

  public HierarchyTemplateResponse createAgreement(
    int SubscriberId,
    HierarchyTemplateRequest HierarchyTemplateRequest)
  {
    return ((ProducerLifecycleServicePortType) this).createAgreement(new createAgreementRequest()
    {
      SubscriberId = SubscriberId,
      HierarchyTemplateRequest = HierarchyTemplateRequest
    }).HierarchyTemplateResponse;
  }

  [EditorBrowsable(EditorBrowsableState.Advanced)]
  Task<createAgreementResponse> ProducerLifecycleServicePortType.createAgreementAsync(
    createAgreementRequest request)
  {
    return this.Channel.createAgreementAsync(request);
  }

  public Task<createAgreementResponse> createAgreementAsync(
    int SubscriberId,
    HierarchyTemplateRequest HierarchyTemplateRequest)
  {
    return ((ProducerLifecycleServicePortType) this).createAgreementAsync(new createAgreementRequest()
    {
      SubscriberId = SubscriberId,
      HierarchyTemplateRequest = HierarchyTemplateRequest
    });
  }

  [EditorBrowsable(EditorBrowsableState.Advanced)]
  createRelationshipResponse ProducerLifecycleServicePortType.createRelationship(
    createRelationshipRequest request)
  {
    return this.Channel.createRelationship(request);
  }

  public RelationshipResponse createRelationship(
    SecurityHeaderType Security,
    VersionType Version,
    ref int SubscriberId,
    RelationshipCriteria RelationshipCriteria)
  {
    createRelationshipResponse relationship = ((ProducerLifecycleServicePortType) this).createRelationship(new createRelationshipRequest()
    {
      Security = Security,
      Version = Version,
      SubscriberId = SubscriberId,
      RelationshipCriteria = RelationshipCriteria
    });
    SubscriberId = relationship.SubscriberId;
    return relationship.RelationshipResponse;
  }

  [EditorBrowsable(EditorBrowsableState.Advanced)]
  Task<createRelationshipResponse> ProducerLifecycleServicePortType.createRelationshipAsync(
    createRelationshipRequest request)
  {
    return this.Channel.createRelationshipAsync(request);
  }

  public Task<createRelationshipResponse> createRelationshipAsync(
    SecurityHeaderType Security,
    VersionType Version,
    int SubscriberId,
    RelationshipCriteria RelationshipCriteria)
  {
    return ((ProducerLifecycleServicePortType) this).createRelationshipAsync(new createRelationshipRequest()
    {
      Security = Security,
      Version = Version,
      SubscriberId = SubscriberId,
      RelationshipCriteria = RelationshipCriteria
    });
  }

  [EditorBrowsable(EditorBrowsableState.Advanced)]
  inactivateLicenseStateResponse1 ProducerLifecycleServicePortType.inactivateLicenseState(
    inactivateLicenseStateRequest1 request)
  {
    return this.Channel.inactivateLicenseState(request);
  }

  public InactivateLicenseStateResponse inactivateLicenseState(
    SecurityHeaderType Security,
    ref int SubscriberId,
    InactivateLicenseStateRequest InactivateLicenseStateRequest)
  {
    inactivateLicenseStateResponse1 licenseStateResponse1 = ((ProducerLifecycleServicePortType) this).inactivateLicenseState(new inactivateLicenseStateRequest1()
    {
      Security = Security,
      SubscriberId = SubscriberId,
      InactivateLicenseStateRequest = InactivateLicenseStateRequest
    });
    SubscriberId = licenseStateResponse1.SubscriberId;
    return licenseStateResponse1.InactivateLicenseStateResponse;
  }

  [EditorBrowsable(EditorBrowsableState.Advanced)]
  Task<inactivateLicenseStateResponse1> ProducerLifecycleServicePortType.inactivateLicenseStateAsync(
    inactivateLicenseStateRequest1 request)
  {
    return this.Channel.inactivateLicenseStateAsync(request);
  }

  public Task<inactivateLicenseStateResponse1> inactivateLicenseStateAsync(
    SecurityHeaderType Security,
    int SubscriberId,
    InactivateLicenseStateRequest InactivateLicenseStateRequest)
  {
    return ((ProducerLifecycleServicePortType) this).inactivateLicenseStateAsync(new inactivateLicenseStateRequest1()
    {
      Security = Security,
      SubscriberId = SubscriberId,
      InactivateLicenseStateRequest = InactivateLicenseStateRequest
    });
  }

  [EditorBrowsable(EditorBrowsableState.Advanced)]
  inactivateRelationshipResponse ProducerLifecycleServicePortType.inactivateRelationship(
    createRelationshipRequest request)
  {
    return this.Channel.inactivateRelationship(request);
  }

  public RelationshipResponse inactivateRelationship(
    SecurityHeaderType Security,
    VersionType Version,
    ref int SubscriberId,
    RelationshipCriteria RelationshipCriteria)
  {
    inactivateRelationshipResponse relationshipResponse = ((ProducerLifecycleServicePortType) this).inactivateRelationship(new createRelationshipRequest()
    {
      Security = Security,
      Version = Version,
      SubscriberId = SubscriberId,
      RelationshipCriteria = RelationshipCriteria
    });
    SubscriberId = relationshipResponse.SubscriberId;
    return relationshipResponse.RelationshipResponse;
  }

  [EditorBrowsable(EditorBrowsableState.Advanced)]
  Task<inactivateRelationshipResponse> ProducerLifecycleServicePortType.inactivateRelationshipAsync(
    createRelationshipRequest request)
  {
    return this.Channel.inactivateRelationshipAsync(request);
  }

  public Task<inactivateRelationshipResponse> inactivateRelationshipAsync(
    SecurityHeaderType Security,
    VersionType Version,
    int SubscriberId,
    RelationshipCriteria RelationshipCriteria)
  {
    return ((ProducerLifecycleServicePortType) this).inactivateRelationshipAsync(new createRelationshipRequest()
    {
      Security = Security,
      Version = Version,
      SubscriberId = SubscriberId,
      RelationshipCriteria = RelationshipCriteria
    });
  }

  [EditorBrowsable(EditorBrowsableState.Advanced)]
  newProducerResponse ProducerLifecycleServicePortType.newProducer(newProducerRequest request)
  {
    return this.Channel.newProducer(request);
  }

  public TransactionResponses newProducer(
    SecurityHeaderType Security,
    VersionType Version,
    ref int SubscriberId,
    Transactions Transactions)
  {
    newProducerResponse producerResponse = ((ProducerLifecycleServicePortType) this).newProducer(new newProducerRequest()
    {
      Security = Security,
      Version = Version,
      SubscriberId = SubscriberId,
      Transactions = Transactions
    });
    SubscriberId = producerResponse.SubscriberId;
    return producerResponse.TransactionResponses;
  }

  [EditorBrowsable(EditorBrowsableState.Advanced)]
  Task<newProducerResponse> ProducerLifecycleServicePortType.newProducerAsync(
    newProducerRequest request)
  {
    return this.Channel.newProducerAsync(request);
  }

  public Task<newProducerResponse> newProducerAsync(
    SecurityHeaderType Security,
    VersionType Version,
    int SubscriberId,
    Transactions Transactions)
  {
    return ((ProducerLifecycleServicePortType) this).newProducerAsync(new newProducerRequest()
    {
      Security = Security,
      Version = Version,
      SubscriberId = SubscriberId,
      Transactions = Transactions
    });
  }

  [EditorBrowsable(EditorBrowsableState.Advanced)]
  producerQueryResponse1 ProducerLifecycleServicePortType.producerQuery(producerQueryRequest request)
  {
    return this.Channel.producerQuery(request);
  }

  public ProducerQueryResponse producerQuery(
    SecurityHeaderType Security,
    VersionType Version,
    ref int SubscriberId,
    ProducerQuery ProducerQuery1)
  {
    producerQueryResponse1 producerQueryResponse1 = ((ProducerLifecycleServicePortType) this).producerQuery(new producerQueryRequest()
    {
      Security = Security,
      Version = Version,
      SubscriberId = SubscriberId,
      ProducerQuery = ProducerQuery1
    });
    SubscriberId = producerQueryResponse1.SubscriberId;
    return producerQueryResponse1.ProducerQueryResponse;
  }

  [EditorBrowsable(EditorBrowsableState.Advanced)]
  Task<producerQueryResponse1> ProducerLifecycleServicePortType.producerQueryAsync(
    producerQueryRequest request)
  {
    return this.Channel.producerQueryAsync(request);
  }

  public Task<producerQueryResponse1> producerQueryAsync(
    SecurityHeaderType Security,
    VersionType Version,
    int SubscriberId,
    ProducerQuery ProducerQuery)
  {
    return ((ProducerLifecycleServicePortType) this).producerQueryAsync(new producerQueryRequest()
    {
      Security = Security,
      Version = Version,
      SubscriberId = SubscriberId,
      ProducerQuery = ProducerQuery
    });
  }

  [EditorBrowsable(EditorBrowsableState.Advanced)]
  retrieveRelationshipResponse ProducerLifecycleServicePortType.retrieveRelationship(
    createRelationshipRequest request)
  {
    return this.Channel.retrieveRelationship(request);
  }

  public RetrieveRelationshipsResponse retrieveRelationship(
    SecurityHeaderType Security,
    VersionType Version,
    ref int SubscriberId,
    RelationshipCriteria RelationshipCriteria)
  {
    retrieveRelationshipResponse relationshipResponse = ((ProducerLifecycleServicePortType) this).retrieveRelationship(new createRelationshipRequest()
    {
      Security = Security,
      Version = Version,
      SubscriberId = SubscriberId,
      RelationshipCriteria = RelationshipCriteria
    });
    SubscriberId = relationshipResponse.SubscriberId;
    return relationshipResponse.RetrieveRelationshipsResponse;
  }

  [EditorBrowsable(EditorBrowsableState.Advanced)]
  Task<retrieveRelationshipResponse> ProducerLifecycleServicePortType.retrieveRelationshipAsync(
    createRelationshipRequest request)
  {
    return this.Channel.retrieveRelationshipAsync(request);
  }

  public Task<retrieveRelationshipResponse> retrieveRelationshipAsync(
    SecurityHeaderType Security,
    VersionType Version,
    int SubscriberId,
    RelationshipCriteria RelationshipCriteria)
  {
    return ((ProducerLifecycleServicePortType) this).retrieveRelationshipAsync(new createRelationshipRequest()
    {
      Security = Security,
      Version = Version,
      SubscriberId = SubscriberId,
      RelationshipCriteria = RelationshipCriteria
    });
  }

  [EditorBrowsable(EditorBrowsableState.Advanced)]
  selectHierarchyTemplateResponse ProducerLifecycleServicePortType.selectHierarchyTemplate(
    createAgreementRequest request)
  {
    return this.Channel.selectHierarchyTemplate(request);
  }

  public HierarchyTemplateResponse selectHierarchyTemplate(
    int SubscriberId,
    HierarchyTemplateRequest HierarchyTemplateRequest)
  {
    return ((ProducerLifecycleServicePortType) this).selectHierarchyTemplate(new createAgreementRequest()
    {
      SubscriberId = SubscriberId,
      HierarchyTemplateRequest = HierarchyTemplateRequest
    }).HierarchyTemplateResponse;
  }

  [EditorBrowsable(EditorBrowsableState.Advanced)]
  Task<selectHierarchyTemplateResponse> ProducerLifecycleServicePortType.selectHierarchyTemplateAsync(
    createAgreementRequest request)
  {
    return this.Channel.selectHierarchyTemplateAsync(request);
  }

  public Task<selectHierarchyTemplateResponse> selectHierarchyTemplateAsync(
    int SubscriberId,
    HierarchyTemplateRequest HierarchyTemplateRequest)
  {
    return ((ProducerLifecycleServicePortType) this).selectHierarchyTemplateAsync(new createAgreementRequest()
    {
      SubscriberId = SubscriberId,
      HierarchyTemplateRequest = HierarchyTemplateRequest
    });
  }

  [EditorBrowsable(EditorBrowsableState.Advanced)]
  selectLooseHierarchyTemplateResponse ProducerLifecycleServicePortType.selectLooseHierarchyTemplate(
    createAgreementRequest request)
  {
    return this.Channel.selectLooseHierarchyTemplate(request);
  }

  public HierarchyTemplateResponse selectLooseHierarchyTemplate(
    int SubscriberId,
    HierarchyTemplateRequest HierarchyTemplateRequest)
  {
    return ((ProducerLifecycleServicePortType) this).selectLooseHierarchyTemplate(new createAgreementRequest()
    {
      SubscriberId = SubscriberId,
      HierarchyTemplateRequest = HierarchyTemplateRequest
    }).HierarchyTemplateResponse;
  }

  [EditorBrowsable(EditorBrowsableState.Advanced)]
  Task<selectLooseHierarchyTemplateResponse> ProducerLifecycleServicePortType.selectLooseHierarchyTemplateAsync(
    createAgreementRequest request)
  {
    return this.Channel.selectLooseHierarchyTemplateAsync(request);
  }

  public Task<selectLooseHierarchyTemplateResponse> selectLooseHierarchyTemplateAsync(
    int SubscriberId,
    HierarchyTemplateRequest HierarchyTemplateRequest)
  {
    return ((ProducerLifecycleServicePortType) this).selectLooseHierarchyTemplateAsync(new createAgreementRequest()
    {
      SubscriberId = SubscriberId,
      HierarchyTemplateRequest = HierarchyTemplateRequest
    });
  }

  [EditorBrowsable(EditorBrowsableState.Advanced)]
  submitAppointmentsResponse ProducerLifecycleServicePortType.submitAppointments(
    submitAppointmentsRequest1 request)
  {
    return this.Channel.submitAppointments(request);
  }

  public SentAppointmentsResponse submitAppointments(
    int SubscriberId,
    string ProducerRequestId,
    string UserName,
    SubmitAppointmentsRequest SubmitAppointmentsRequest)
  {
    return ((ProducerLifecycleServicePortType) this).submitAppointments(new submitAppointmentsRequest1()
    {
      SubscriberId = SubscriberId,
      ProducerRequestId = ProducerRequestId,
      UserName = UserName,
      SubmitAppointmentsRequest = SubmitAppointmentsRequest
    }).SentAppointmentsResponse;
  }

  [EditorBrowsable(EditorBrowsableState.Advanced)]
  Task<submitAppointmentsResponse> ProducerLifecycleServicePortType.submitAppointmentsAsync(
    submitAppointmentsRequest1 request)
  {
    return this.Channel.submitAppointmentsAsync(request);
  }

  public Task<submitAppointmentsResponse> submitAppointmentsAsync(
    int SubscriberId,
    string ProducerRequestId,
    string UserName,
    SubmitAppointmentsRequest SubmitAppointmentsRequest)
  {
    return ((ProducerLifecycleServicePortType) this).submitAppointmentsAsync(new submitAppointmentsRequest1()
    {
      SubscriberId = SubscriberId,
      ProducerRequestId = ProducerRequestId,
      UserName = UserName,
      SubmitAppointmentsRequest = SubmitAppointmentsRequest
    });
  }

  [EditorBrowsable(EditorBrowsableState.Advanced)]
  updateProducerRecordResponse1 ProducerLifecycleServicePortType.updateProducerRecord(
    updateProducerRecordRequest1 request)
  {
    return this.Channel.updateProducerRecord(request);
  }

  public UpdateProducerRecordResponse updateProducerRecord(
    int SubscriberId,
    UpdateProducerRecordRequest UpdateProducerRecordRequest)
  {
    return ((ProducerLifecycleServicePortType) this).updateProducerRecord(new updateProducerRecordRequest1()
    {
      SubscriberId = SubscriberId,
      UpdateProducerRecordRequest = UpdateProducerRecordRequest
    }).UpdateProducerRecordResponse;
  }

  [EditorBrowsable(EditorBrowsableState.Advanced)]
  Task<updateProducerRecordResponse1> ProducerLifecycleServicePortType.updateProducerRecordAsync(
    updateProducerRecordRequest1 request)
  {
    return this.Channel.updateProducerRecordAsync(request);
  }

  public Task<updateProducerRecordResponse1> updateProducerRecordAsync(
    int SubscriberId,
    UpdateProducerRecordRequest UpdateProducerRecordRequest)
  {
    return ((ProducerLifecycleServicePortType) this).updateProducerRecordAsync(new updateProducerRecordRequest1()
    {
      SubscriberId = SubscriberId,
      UpdateProducerRecordRequest = UpdateProducerRecordRequest
    });
  }

  [EditorBrowsable(EditorBrowsableState.Advanced)]
  validateHierarchyTemplateResponse ProducerLifecycleServicePortType.validateHierarchyTemplate(
    createAgreementRequest request)
  {
    return this.Channel.validateHierarchyTemplate(request);
  }

  public HierarchyTemplateResponse validateHierarchyTemplate(
    int SubscriberId,
    HierarchyTemplateRequest HierarchyTemplateRequest)
  {
    return ((ProducerLifecycleServicePortType) this).validateHierarchyTemplate(new createAgreementRequest()
    {
      SubscriberId = SubscriberId,
      HierarchyTemplateRequest = HierarchyTemplateRequest
    }).HierarchyTemplateResponse;
  }

  [EditorBrowsable(EditorBrowsableState.Advanced)]
  Task<validateHierarchyTemplateResponse> ProducerLifecycleServicePortType.validateHierarchyTemplateAsync(
    createAgreementRequest request)
  {
    return this.Channel.validateHierarchyTemplateAsync(request);
  }

  public Task<validateHierarchyTemplateResponse> validateHierarchyTemplateAsync(
    int SubscriberId,
    HierarchyTemplateRequest HierarchyTemplateRequest)
  {
    return ((ProducerLifecycleServicePortType) this).validateHierarchyTemplateAsync(new createAgreementRequest()
    {
      SubscriberId = SubscriberId,
      HierarchyTemplateRequest = HierarchyTemplateRequest
    });
  }
}
