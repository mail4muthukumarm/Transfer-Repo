// Decompiled with JetBrains decompiler
// Type: MGASystems.BusinessObjects.SubmissionGroup
// Assembly: MgaSystems.IMS.BusinessObjects, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: BAE231E6-4F60-443A-9930-E3F7CC50C186
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.BusinessObjects.dll

using MGASystems.Common;
using MGASystems.Data;
using MGASystems.Data.DataMapping;
using MGASystems.IMS.NoteDocuments;
using System;
using System.Data;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.BusinessObjects;

[TableMapping("dbo.tblSubmissionGroup")]
public sealed class SubmissionGroup : BaseDataObject, ISupportDocumentSystem
{
  private Guid _submissionGroupGuid;
  private Insured _insured;

  public SubmissionGroup(Guid submissionGroupGuid)
  {
    this.SubmissionGroupGuid = submissionGroupGuid;
  }

  [DataKey]
  public Guid SubmissionGroupGuid
  {
    get => this._submissionGroupGuid;
    set
    {
      this._submissionGroupGuid = this._submissionGroupGuid.Equals(Guid.Empty) ? value : throw new InvalidOperationException($"Specified SubmissionGroup {this._submissionGroupGuid} has already been initialized");
    }
  }

  [TableFieldMapping]
  public int SubmissionGroupID
  {
    get => this.GetField<int>(nameof (SubmissionGroupID), nameof (SubmissionGroupID));
  }

  [TableFieldMapping]
  public Guid InsuredGuid => this.GetField<Guid>(nameof (InsuredGuid), nameof (InsuredGuid));

  [TableFieldMapping]
  public Guid ProducerLocationGuid
  {
    get => this.GetField<Guid>(nameof (ProducerLocationGuid), nameof (ProducerLocationGuid));
  }

  [TableFieldMapping]
  public int ProducerContactID
  {
    get => this.GetField<int>(nameof (ProducerContactID), nameof (ProducerContactID));
  }

  [TableFieldMapping("SecProducerContactID")]
  public int? SecondaryProducerContactID
  {
    get => this.GetField<int?>("SecProducerContactID", nameof (SecondaryProducerContactID));
  }

  [TableFieldMapping]
  public Guid? UnderwriterUserGuid
  {
    get => this.GetField<Guid?>(nameof (UnderwriterUserGuid), nameof (UnderwriterUserGuid));
  }

  [TableFieldMapping]
  public Guid? TACSRUserGuid
  {
    get => this.GetField<Guid?>(nameof (TACSRUserGuid), nameof (TACSRUserGuid));
  }

  [TableFieldMapping]
  public Guid? InHouseProducerUserGuid
  {
    get => this.GetField<Guid?>(nameof (InHouseProducerUserGuid), nameof (InHouseProducerUserGuid));
  }

  [TableFieldMapping]
  public DateTime DateSubmitted
  {
    get => this.GetField<DateTime>(nameof (DateSubmitted), nameof (DateSubmitted));
  }

  public Guid InsuredLocationGuid
  {
    get
    {
      Guid? lazyField = this.GetLazyField<Guid?>(nameof (InsuredLocationGuid), "dbo.GetInsuredPrimaryLocation(InsuredGuid)");
      if (!lazyField.HasValue || lazyField.Equals((object) Guid.Empty))
        throw new InvalidOperationException("No primary location was found for this insured.");
      return lazyField.Value;
    }
  }

  public int QuoteCount
  {
    get => this.GetLazyField<int>(nameof (QuoteCount), $"dbo.QuoteCount({"SubmissionGroupGuid"})");
  }

  public Insured Insured
  {
    get
    {
      if (this._insured == null)
        this._insured = ObjectFactory.Instance.CreateObjectAs<Insured>((object) this.InsuredGuid);
      return this._insured;
    }
  }

  public InsuredLocation InsuredLocation
  {
    get
    {
      return this.CacheManualValue<InsuredLocation>(nameof (InsuredLocation), (Func<InsuredLocation>) ([SpecialName] () => ObjectFactory.Instance.CreateObjectAs<InsuredLocation>((object) this.InsuredLocationGuid)));
    }
  }

  public ProducerLocation ProducerLocation
  {
    get
    {
      return this.CacheManualValue<ProducerLocation>(nameof (ProducerLocation), (Func<ProducerLocation>) ([SpecialName] () => ObjectFactory.Instance.CreateObjectAs<ProducerLocation>((object) this.ProducerLocationGuid)));
    }
  }

  public Producer InHouseProducer
  {
    get
    {
      return this.CacheManualValue<Producer>(nameof (InHouseProducer), (Func<Producer>) ([SpecialName] () =>
      {
        if (!this.InHouseProducerUserGuid.HasValue)
          return (Producer) null;
        return ObjectFactory.Instance.CreateObjectAs<Producer>((object) this.InHouseProducerUserGuid.Value);
      }));
    }
  }

  public User Underwriter
  {
    get
    {
      return this.CacheManualValue<User>(nameof (Underwriter), (Func<User>) ([SpecialName] () =>
      {
        if (!this.UnderwriterUserGuid.HasValue)
          return (User) null;
        return ObjectFactory.Instance.CreateObjectAs<User>((object) this.UnderwriterUserGuid.Value);
      }));
    }
  }

  public User TACSR
  {
    get
    {
      return this.CacheManualValue<User>(nameof (TACSR), (Func<User>) ([SpecialName] () =>
      {
        if (!this.TACSRUserGuid.HasValue)
          return (User) null;
        return ObjectFactory.Instance.CreateObjectAs<User>((object) this.TACSRUserGuid.Value);
      }));
    }
  }

  public ProducerContact ProducerContact
  {
    get
    {
      return this.CacheManualValue<ProducerContact>(nameof (ProducerContact), (Func<ProducerContact>) ([SpecialName] () => ObjectFactory.Instance.CreateObjectAs<ProducerContact>((object) this.ProducerContactID)));
    }
  }

  public ProducerContact SecondaryProducerContact
  {
    get
    {
      return this.CacheManualValue<ProducerContact>(nameof (SecondaryProducerContact), (Func<ProducerContact>) ([SpecialName] () =>
      {
        if (!this.SecondaryProducerContactID.HasValue)
          return (ProducerContact) null;
        return ObjectFactory.Instance.CreateObjectAs<ProducerContact>((object) this.SecondaryProducerContactID.Value);
      }));
    }
  }

  public string TACSRFirst => this.TACSR?.FirstName ?? string.Empty;

  public string TACSRLast => this.TACSR?.LastName ?? string.Empty;

  public string ProducerAddress1 => this.ProducerLocation?.Address1;

  public string ProducerAddress2 => this.ProducerLocation?.Address2;

  public string ProducerCity => this.ProducerLocation?.City;

  public string ProducerCounty => this.ProducerLocation?.County;

  public string ProducerState => this.ProducerLocation?.State;

  public string ProducerZipCode => this.ProducerLocation?.Zip ?? string.Empty;

  public string ProducerZipPlus4 => this.ProducerLocation?.ZipPlus ?? string.Empty;

  public string ProducerPhone => this.ProducerLocation?.Phone ?? string.Empty;

  public string ProducerFax => this.ProducerLocation?.Fax ?? string.Empty;

  public string ProducerLocationName => this.ProducerLocation?.LocationName;

  public string ProducerName
  {
    get
    {
      return this.CacheManualValue<string>(nameof (ProducerName), (Func<string>) ([SpecialName] () => DefaultDatabase.ExecuteScalar<string>(CommandType.Text, "SELECT p.ProducerName FROM dbo.tblSubmissionGroup sg WITH(NOLOCK) JOIN dbo.tblProducerLocations pl WITH(NOLOCK) ON pl.ProducerLocationGUID = sg.ProducerLocationGuid JOIN dbo.tblProducers p WITH(NOLOCK) ON p.ProducerGUID = pl.ProducerGUID WHERE sg.SubmissionGroupGuid = @SG", new object[2]
      {
        (object) "@SG",
        (object) this.SubmissionGroupGuid
      }) ?? string.Empty));
    }
  }

  bool IRecreatableEntity.CanReCreateEntity => true;

  Guid IRecreatableEntity.ControlGUID => new Guid();

  Guid IRecreatableEntity.EntityGuid => this.SubmissionGroupGuid;

  string IRecreatableEntity.EntityName
  {
    get
    {
      return $"SubmissionGroupID - {this.SubmissionGroupID} Insured - {this.InsuredLocation.LocationName}";
    }
  }

  string IRecreatableEntity.FriendlyEntityName => "Submission Group";

  bool IRecreatableEntity.HasControlGUID => false;

  bool IRecreatableEntity.RecreateEntityInitialize(Guid entityGuid)
  {
    throw new InvalidOperationException("The Quote object does not directly support RecreateEntityInitialize");
  }

  string IRecreatableEntity.RecreateTypeName
  {
    get => "MGASystems.IMS.Policies.Submissions.frmSubmissionGroup ";
  }

  public bool AllowAddNewDocument => true;

  public event ISupportDocumentSystem.EntityInfoChangedEventHandler EntityInfoChanged;
}
