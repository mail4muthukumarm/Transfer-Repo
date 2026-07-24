// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.BroadcastMessages
// Assembly: MgaSystems.IMS.Common, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 46CE8D79-2C19-419C-BC23-F8C69E623B17
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.dll

using System;
using System.Collections.Generic;

#nullable disable
namespace MGASystems.Common;

public sealed class BroadcastMessages
{
  public static readonly Guid AdmittedTypeForCoverageAdded = new Guid("{6FD89360-ADAC-4a37-827C-1E0486C52880}");
  public static readonly Guid CarrierAdded = new Guid("{5E2980D5-768C-4e51-9AE0-6D73A97DB0B1}");
  public static readonly Guid CarrierAddressUpdated = new Guid("{C0788461-9A0D-4da0-BE9F-CA95D685A62E}");
  public static readonly Guid CoverageAdded = new Guid("{CBE34A56-B7CF-4c1a-ABD5-DF3D9F9D0C55}");
  public static readonly Guid CoverageCarrierUpdated = new Guid("{69512E46-6FDC-491e-A3E8-986FDC38DCC8}");
  public static readonly Guid CoverageEffectiveDateUpdated = new Guid("{3BE352D8-5136-4850-BC31-4FBA058B59D6}");
  public static readonly Guid CoverageInfoUpdated = new Guid("{8D6AAF12-9698-497c-9687-A8B2F3A24257}");
  public static readonly Guid CoverageParentUpdated = new Guid("{32A95DED-1B15-4025-ABBB-B3352C84A2E1}");
  public static readonly Guid CoverageStatusUpdated = new Guid("{8DAB7549-8085-4f97-A34D-2B89D18DE85E}");
  public static readonly Guid DocumentBound = new Guid("{AAB74A3C-98D9-4622-B2ED-7016C8D29ACA}");
  public static readonly Guid DocumentDeleting = new Guid("{E3887841-F1E6-4f9e-9572-264F8C0508BF}");
  public static readonly Guid DocumentUnbinding = new Guid("{7AF26A1D-1707-4ed5-820D-0D000DDF48DE}");
  public static readonly Guid DocumentUploading = new Guid("{00D1D0D5-3A1A-43a1-A6B8-8742F57843FA}");
  public static readonly Guid EntityOfacSearch = new Guid("{4DD7D271-B017-4CFA-867B-B76D22DE114B}");
  public static readonly Guid EntityOfacClear = new Guid("{EA05A5E6-A341-49CF-AF12-4171A05E3807}");
  public static readonly Guid EntityOfacReinstated = new Guid("{56AC1971-0E7E-41DB-ABE0-3F31CAF03016}");
  public static readonly Guid EntityOfacReset = new Guid("{3BBCCC41-77BC-418D-BDB0-E2CB81B168AC}");
  public static readonly Guid LoginSuccessful = new Guid("{3BE00A18-8E56-468B-9EAB-F09A4AF6B010}");
  public static readonly Guid NoEventDocumentsCreated = new Guid("{CCD1505F-1FEB-4018-9AB0-0BECCD0445C8}");
  public static readonly Guid NonRenewed = new Guid("{AE85AE95-4D61-4572-B8C2-F0D166B7F036}");
  public static readonly Guid OutlookEmailSent = new Guid("{4AF10C13-C83D-4303-9DB6-64F26960B909}");
  public static readonly Guid PremiumChanged = new Guid("{2DE7951B-F17B-4759-9839-EF48C5D566DA}");
  public static readonly Guid ProducerAdded = new Guid("{1785FB4C-2DEA-456e-8D47-611DAEFA94D6}");
  public static readonly Guid ProducerContactAdded = new Guid("{8E419BB8-4C80-44d6-8A66-A7D73414E039}");
  public static readonly Guid ProducerContactUpdated = new Guid("{9D6D1BE3-2B44-4196-81D5-B766D46C9564}");
  public static readonly Guid ProducerFilingInfoCompleted = new Guid("{716BA48B-2B0B-44E6-9BFA-DF11E17FC625}");
  public static readonly Guid ProducerLocationAdded = new Guid("{689B8DA7-64CE-4755-9E0D-AF217DC54CAD}");
  public static readonly Guid ProducerLocationUpdated = new Guid("{2AAFADF1-5C64-4716-A6AB-7AB5538FA798}");
  public static readonly Guid ProducerUpdated = new Guid("{9FB430F3-9824-4ee8-9F58-50BE131B6CAE}");
  public static readonly Guid QuoteDuplicated = new Guid("{59174691-911B-496F-A0E6-BA0183A74A5E}");
  public static readonly Guid QuoteIsReadyForBind = new Guid("{B9C568EF-000C-4715-8B17-7083AD6426BB}");
  public static readonly Guid QuoteModified = new Guid("{35D3CFA8-0D94-4F24-A082-A2118B8FA028}");
  public static readonly Guid QuoteStatusChanged = new Guid("{76D7258D-2277-4281-B2B7-AC98FB86FC53}");
  public static readonly Guid RescindNotice = new Guid("{43F4193A-7E85-4b48-83AB-3654637D539E}");
  public static readonly Guid TemplateDocumentInstanceCreated = new Guid("{BB7DE789-20DB-48d2-8120-6B05B7B5EE17}");
  public static readonly Guid UserContactInfoUpdated = new Guid("{0536E070-5A1D-4926-8853-0D111E4BB172}");
  public static readonly Guid UserCredentialsUpdated = new Guid("{97BBD293-3441-4f10-B7FC-6E04BBEFF07A}");
  public static readonly Guid UserExpiryDateUpdated = new Guid("{ECA1CF74-2A6A-4e4c-A8A5-006DFD088A9B}");
  public static readonly Guid UserInfoAdded = new Guid("{A4670042-FD05-4256-BD0D-EEEF96D1EA84}");
  public static readonly Dictionary<Guid, string> EventDictionary = new Dictionary<Guid, string>()
  {
    {
      BroadcastMessages.AdmittedTypeForCoverageAdded,
      nameof (AdmittedTypeForCoverageAdded)
    },
    {
      BroadcastMessages.AuditBound,
      nameof (AuditBound)
    },
    {
      BroadcastMessages.AuditCreated,
      nameof (AuditCreated)
    },
    {
      BroadcastMessages.AuthorityLimitNoteSent,
      nameof (AuthorityLimitNoteSent)
    },
    {
      BroadcastMessages.BeginNewSubmission,
      nameof (BeginNewSubmission)
    },
    {
      BroadcastMessages.CarrierAdded,
      nameof (CarrierAdded)
    },
    {
      BroadcastMessages.CarrierAddressUpdated,
      nameof (CarrierAddressUpdated)
    },
    {
      BroadcastMessages.ClosefrmViewPrintEmail,
      nameof (ClosefrmViewPrintEmail)
    },
    {
      BroadcastMessages.CompanyBillingTypesUpdated,
      nameof (CompanyBillingTypesUpdated)
    },
    {
      BroadcastMessages.CoverageAdded,
      nameof (CoverageAdded)
    },
    {
      BroadcastMessages.CoverageCarrierUpdated,
      nameof (CoverageCarrierUpdated)
    },
    {
      BroadcastMessages.CoverageEffectiveDateUpdated,
      nameof (CoverageEffectiveDateUpdated)
    },
    {
      BroadcastMessages.CoverageInfoUpdated,
      nameof (CoverageInfoUpdated)
    },
    {
      BroadcastMessages.CoverageParentUpdated,
      nameof (CoverageParentUpdated)
    },
    {
      BroadcastMessages.CoverageStatusUpdated,
      nameof (CoverageStatusUpdated)
    },
    {
      BroadcastMessages.DiaryCompletionStatusChanged,
      nameof (DiaryCompletionStatusChanged)
    },
    {
      BroadcastMessages.DocumentBound,
      nameof (DocumentBound)
    },
    {
      BroadcastMessages.DocumentDeleting,
      nameof (DocumentDeleting)
    },
    {
      BroadcastMessages.DocumentUnbinding,
      nameof (DocumentUnbinding)
    },
    {
      BroadcastMessages.DocumentUploading,
      nameof (DocumentUploading)
    },
    {
      BroadcastMessages.DriverStatusChanged,
      "Driver Status Changed"
    },
    {
      BroadcastMessages.EndorsementBound,
      nameof (EndorsementBound)
    },
    {
      BroadcastMessages.EndorsementReprinted,
      nameof (EndorsementReprinted)
    },
    {
      BroadcastMessages.EntityOfacClear,
      nameof (EntityOfacClear)
    },
    {
      BroadcastMessages.EntityOfacSearch,
      nameof (EntityOfacSearch)
    },
    {
      BroadcastMessages.EntityOfacReinstated,
      nameof (EntityOfacReinstated)
    },
    {
      BroadcastMessages.EntityOfacReset,
      nameof (EntityOfacReset)
    },
    {
      BroadcastMessages.ExcludedDriverAdded,
      nameof (ExcludedDriverAdded)
    },
    {
      BroadcastMessages.FirstQuoteOnSubmission,
      "First Quote On Submission"
    },
    {
      BroadcastMessages.IndicationPrinted,
      nameof (IndicationPrinted)
    },
    {
      BroadcastMessages.InspectionRequested,
      nameof (InspectionRequested)
    },
    {
      BroadcastMessages.InsuredAdded,
      nameof (InsuredAdded)
    },
    {
      BroadcastMessages.InsuredDeleted,
      nameof (InsuredDeleted)
    },
    {
      BroadcastMessages.InvoicePrinted,
      nameof (InvoicePrinted)
    },
    {
      BroadcastMessages.LaunchOfficeScreen,
      nameof (LaunchOfficeScreen)
    },
    {
      BroadcastMessages.LaunchPolicyDetailScreen,
      nameof (LaunchPolicyDetailScreen)
    },
    {
      BroadcastMessages.LaunchUsersScreen,
      nameof (LaunchUsersScreen)
    },
    {
      BroadcastMessages.LoginSuccessful,
      nameof (LoginSuccessful)
    },
    {
      BroadcastMessages.Lost,
      nameof (Lost)
    },
    {
      BroadcastMessages.NewQuote,
      nameof (NewQuote)
    },
    {
      BroadcastMessages.NewRenewal,
      nameof (NewRenewal)
    },
    {
      BroadcastMessages.NOCIssued,
      nameof (NOCIssued)
    },
    {
      BroadcastMessages.NoEventDocumentsCreated,
      nameof (NoEventDocumentsCreated)
    },
    {
      BroadcastMessages.NonRenewed,
      nameof (NonRenewed)
    },
    {
      BroadcastMessages.NonRenewedRescindedNotice,
      "NonRenewedRescindNotice"
    },
    {
      BroadcastMessages.NoteTypesUpdated,
      nameof (NoteTypesUpdated)
    },
    {
      BroadcastMessages.NotTakenUp,
      nameof (NotTakenUp)
    },
    {
      BroadcastMessages.OutlookEmailSent,
      nameof (OutlookEmailSent)
    },
    {
      BroadcastMessages.PolicyBound,
      nameof (PolicyBound)
    },
    {
      BroadcastMessages.PolicyCancelled,
      nameof (PolicyCancelled)
    },
    {
      BroadcastMessages.PolicyDeclined,
      nameof (PolicyDeclined)
    },
    {
      BroadcastMessages.PolicyIssued,
      nameof (PolicyIssued)
    },
    {
      BroadcastMessages.PolicyIssuing,
      nameof (PolicyIssuing)
    },
    {
      BroadcastMessages.PolicyNumberChanged,
      nameof (PolicyNumberChanged)
    },
    {
      BroadcastMessages.PolicyPreviewed,
      nameof (PolicyPreviewed)
    },
    {
      BroadcastMessages.PolicyReinstated,
      nameof (PolicyReinstated)
    },
    {
      BroadcastMessages.PremiumChanged,
      nameof (PremiumChanged)
    },
    {
      BroadcastMessages.ProducerAdded,
      nameof (ProducerAdded)
    },
    {
      BroadcastMessages.ProducerContactAdded,
      nameof (ProducerContactAdded)
    },
    {
      BroadcastMessages.ProducerContactChanged,
      nameof (ProducerContactChanged)
    },
    {
      BroadcastMessages.ProducerContactUpdated,
      nameof (ProducerContactUpdated)
    },
    {
      BroadcastMessages.ProducerFilingInfoCompleted,
      nameof (ProducerFilingInfoCompleted)
    },
    {
      BroadcastMessages.ProducerLocationAdded,
      nameof (ProducerLocationAdded)
    },
    {
      BroadcastMessages.ProducerLocationUpdated,
      nameof (ProducerLocationUpdated)
    },
    {
      BroadcastMessages.ProducerUpdated,
      nameof (ProducerUpdated)
    },
    {
      BroadcastMessages.QuoteDeleted,
      nameof (QuoteDeleted)
    },
    {
      BroadcastMessages.QuoteDocumentCreated,
      nameof (QuoteDocumentCreated)
    },
    {
      BroadcastMessages.QuoteDuplicated,
      "Quote Duplicated"
    },
    {
      BroadcastMessages.QuoteIsReadyForBind,
      nameof (QuoteIsReadyForBind)
    },
    {
      BroadcastMessages.QuoteModified,
      "Quote Modified"
    },
    {
      BroadcastMessages.QuotePrinted,
      nameof (QuotePrinted)
    },
    {
      BroadcastMessages.QuoteStatusChanged,
      nameof (QuoteStatusChanged)
    },
    {
      BroadcastMessages.RefreshClearanceSearch,
      nameof (RefreshClearanceSearch)
    },
    {
      BroadcastMessages.RenewalBound,
      nameof (RenewalBound)
    },
    {
      BroadcastMessages.RenewalQuotePrinted,
      nameof (RenewalQuotePrinted)
    },
    {
      BroadcastMessages.ReprintBinder,
      nameof (ReprintBinder)
    },
    {
      BroadcastMessages.RescindNotice,
      nameof (RescindNotice)
    },
    {
      BroadcastMessages.TemplateDocumentInstanceCreated,
      nameof (TemplateDocumentInstanceCreated)
    },
    {
      BroadcastMessages.TransactionUnbound,
      "Transaction Unbound"
    },
    {
      BroadcastMessages.UnderwriterChanged,
      nameof (UnderwriterChanged)
    },
    {
      BroadcastMessages.UserContactInfoUpdated,
      nameof (UserContactInfoUpdated)
    },
    {
      BroadcastMessages.UserCredentialsUpdated,
      nameof (UserCredentialsUpdated)
    },
    {
      BroadcastMessages.UserExpiryDateUpdated,
      nameof (UserExpiryDateUpdated)
    },
    {
      BroadcastMessages.UserInfoAdded,
      nameof (UserInfoAdded)
    },
    {
      BroadcastMessages.ZeroPremiumBinder,
      nameof (ZeroPremiumBinder)
    }
  };

  private BroadcastMessages()
  {
  }

  public static string Translate(Guid message)
  {
    return !BroadcastMessages.EventDictionary.ContainsKey(message) ? "Could Not Decipher Message" : BroadcastMessages.EventDictionary[message];
  }

  public static Guid Find(string name)
  {
    if (string.IsNullOrWhiteSpace(name))
      throw new ArgumentException("Message name cannot be null/empty.", nameof (name));
    Guid guid;
    try
    {
      foreach (KeyValuePair<Guid, string> keyValuePair in BroadcastMessages.EventDictionary)
      {
        if (keyValuePair.Value.EqualsNoCase(name))
        {
          guid = keyValuePair.Key;
          goto label_8;
        }
      }
    }
    finally
    {
      Dictionary<Guid, string>.Enumerator enumerator;
      enumerator.Dispose();
    }
    guid = Guid.Empty;
label_8:
    return guid;
  }

  public static Guid AuditBound { get; } = new Guid("{31D36ABE-E9BD-4AC1-AEDE-68F783FB4E20}");

  public static Guid AuditCreated { get; } = new Guid("{C8C7598E-8BC8-4230-8C6F-006D0B177D46}");

  public static Guid AuthorityLimitNoteSent { get; } = new Guid("{995C8988-3111-4DCA-A081-94A061A3E7B5}");

  public static Guid BeginNewSubmission { get; } = new Guid("{E8018A92-FFD5-44fe-9A82-1A8218110EA0}");

  public static Guid BORonRenewal { get; } = new Guid("{9C14C897-EFF0-47B7-A2E5-CBB1D2B53F4D}");

  public static Guid ClosefrmViewPrintEmail { get; } = new Guid("{AE490303-9E91-4037-B2EF-76E0BFA59B8A}");

  public static Guid CompanyBillingTypesUpdated { get; } = new Guid("{4E23DF45-54DB-4880-A5D1-6E1E148BA9D2}");

  public static Guid DiaryCompletionStatusChanged { get; } = new Guid("{0BEA4EFC-02DB-4758-A667-659F3CA2C77D}");

  public static Guid DriverStatusChanged { get; } = new Guid("{AD50ADF2-B734-47C3-ADE7-376D63CC50D5}");

  public static Guid EndorsementBound { get; } = new Guid("{FFAEB9A2-ECBE-4039-8D51-D5527C4E0EA2}");

  public static Guid EndorsementReprinted { get; } = new Guid("{59ECC110-CC84-4f8f-8AC9-74B1F318425A}");

  public static Guid ExcludedDriverAdded { get; } = new Guid("{1D5AB3C5-7C88-4CE4-BE37-59A67E8EE7A8}");

  public static Guid FirstQuoteOnSubmission { get; } = new Guid("{3A952651-0B81-47DE-B604-02E2DA650303}");

  public static Guid IndicationPrinted { get; } = new Guid("{9f6d18b6-08f8-4ba8-8c51-3c0c87913c99}");

  public static Guid InspectionRequested { get; } = new Guid("{0EE9E96C-44F9-4590-BBBC-F346776CF879}");

  public static Guid InsuredAdded { get; } = new Guid("{91A44E5E-B82A-4cf4-832B-1AA56BA10130}");

  public static Guid InsuredDeleted { get; } = new Guid("{58BC1254-A2A4-4a79-A58B-263D8DCE954D}");

  public static Guid InvoicePrinted { get; } = new Guid("{A14CEEDF-1682-475f-BD0B-6E8ACE4DD8CF}");

  public static Guid LaunchOfficeScreen { get; } = new Guid("{BF36EF16-1874-40b0-863B-5FF8C08C4E9A}");

  public static Guid LaunchPolicyDetailScreen { get; } = new Guid("{C5D9E5A8-DFCA-4f27-9593-888EEFBD5489}");

  public static Guid LaunchUsersScreen { get; } = new Guid("{41BC2E74-F142-4029-BCD9-BCF9291A8586}");

  public static Guid Lost { get; } = new Guid("{576470AE-40DE-408B-8410-551A536C3F57}");

  public static Guid NewQuote { get; } = new Guid("{6659CBFC-D84F-4beb-9777-6B7763820EC5}");

  public static Guid NewRenewal { get; } = new Guid("{9B9F064A-11BE-4970-80E8-84A869FDB50C}");

  public static Guid NOCIssued { get; } = new Guid("{77F27462-2053-4cbb-AF06-9F5900C1A7B4}");

  public static Guid NonRenewedRescindedNotice { get; } = new Guid("{259F71DD-F9DA-4EE6-BC83-EF2A8A3175DD}");

  public static Guid NoteTypesUpdated { get; } = new Guid("{6FE07560-6DCF-475d-9C0A-CA5EE64EB9F8}");

  public static Guid NotTakenUp { get; } = new Guid("{8C73C207-8016-46D9-ADF0-CED358F6A8BE}");

  public static Guid PolicyBound { get; } = new Guid("{9C0C6218-2D2B-4010-862F-2BACC73EE8E8}");

  public static Guid PolicyCancelled { get; } = new Guid("{758F49B7-03DC-462A-AF35-ABB18A24E0BA}");

  public static Guid PolicyDeclined { get; } = new Guid("{9661C561-6786-49EC-82AA-94C12114CCE3}");

  public static Guid PolicyIssued { get; } = new Guid("{ED3C18B2-7AF3-4204-8370-50DCCA808A1D}");

  public static Guid PolicyIssuing { get; } = new Guid("{96C454B0-F525-484A-A6AF-CF998DF8C733}");

  public static Guid PolicyPreviewed { get; } = new Guid("{7AD16B08-4B7C-40cf-BCB1-0ACBD01E9E56}");

  public static Guid PolicyReinstated { get; } = new Guid("{DF36BDD9-8801-459C-B788-CE2651BCA609}");

  public static Guid ProducerContactChanged { get; } = new Guid("{0890B9B9-3F8B-45cf-8830-85500FB2B2FD}");

  public static Guid QuoteDeleted { get; } = new Guid("{F9C51B06-C55F-4ba1-958E-17AB533F6267}");

  public static Guid QuoteDocumentCreated { get; } = new Guid("{AD4AE36A-C7E5-4903-BC62-8B0C9EE920DD}");

  public static Guid QuotePrinted { get; } = new Guid("{A01419B0-AD22-4f9f-8E51-DE6395BCE167}");

  public static Guid RefreshClearanceSearch { get; } = new Guid("{767A8329-FBAD-4c44-BDFD-0867AE87AA0C}");

  public static Guid RenewalBound { get; } = new Guid("{189F9F11-2F02-4900-BAA3-3B50567E052E}");

  public static Guid RenewalQuotePrinted { get; } = new Guid("{A6E48213-18B8-4f67-A4EE-CA5FBEC9ACBA}");

  public static Guid ReprintBinder { get; } = new Guid("{09BCCCA9-CF8E-4514-ADAD-E0DD464E62A9}");

  public static Guid TransactionUnbound { get; } = new Guid("{B723BFD3-E569-4FDA-8ACF-87860F329CF7}");

  public static Guid UnderwriterChanged { get; } = new Guid("{49E7BA40-BE50-4dfb-A786-ED7C1494A224}");

  public static Guid ZeroPremiumBinder { get; } = new Guid("{03367553-EC0F-45EF-9CF1-0BDC8FA531DD}");

  public static Guid PolicyNumberChanged { get; } = new Guid("{50DDB416-458A-4A5B-8ABC-3BF5989AB8E6}");

  public class Types
  {
    public class DriverStatusChangedContext
    {
      private Guid _quoteGuid;
      private int _originalStatus;
      private int _newStatus;
      private long _driverID;

      public Guid QuoteGuid => this._quoteGuid;

      public int OldStatusID => this._originalStatus;

      public int NewStatusID => this._newStatus;

      public long DriverID => this._driverID;

      public DriverStatusChangedContext(Guid quoteGuid, int oldstatus, int newStatus)
      {
        this._driverID = long.MinValue;
        this._quoteGuid = quoteGuid;
        this._originalStatus = oldstatus;
        this._newStatus = newStatus;
      }

      public DriverStatusChangedContext(
        Guid quoteGuid,
        int oldstatus,
        int newStatus,
        long driverID)
      {
        this._driverID = long.MinValue;
        this._quoteGuid = quoteGuid;
        this._originalStatus = oldstatus;
        this._newStatus = newStatus;
        this._driverID = driverID;
      }
    }
  }
}
