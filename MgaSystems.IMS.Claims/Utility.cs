// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Claims.Utility
// Assembly: MgaSystems.IMS.Claims, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FCD9D0B7-28CF-40B9-8EB7-297871E1AF5F
// Assembly location: F:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims.dll

using Infragistics.Shared;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using MGASystems.AddressResolver;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.IMS.BusinessClasses;
using MGASystems.IMS.Claims.Properties;
using MGASystems.IMS.Claims.Utility_Classes;
using MGASystems.IMS.Security;
using MGASystems.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.Layout;

#nullable disable
namespace MGASystems.IMS.Claims;

[SecureResource("{E0F4F16E-5F28-48df-9DA9-ACC8212F2F9C}", "Claim Deletion Rights", "Users with this right have the ability to delete claims if no reserves or payments exist.", "Claims")]
[SecureResource("{B613D8D3-7586-45c9-9427-A30F64F3155B}", "Claim Expense Deletion Rights", "Users with this right have the ability to delete claim expenses if the have not been transferred to the accounting system.", "Claims")]
[SecureResource("{1E64A478-D481-42a5-B888-90A0BA95547D}", "Add/Edit Claimant Rights", "Users with this permission will be granted access to add and edit claimants within the claims system.", "Claims")]
[SecureResource("{DF33CB2D-AE2B-4ee3-AA8C-24D08E14E090}", "Change Reserve/Payment Type Rights", "Users with this permission will be granted access to the change reserve payment/types menu on the claimants screen.", "Claims")]
[SecureResource("{8CE69C01-5E6B-4e34-A302-AC2525DB41BB}", "Delete Reserve/Payment Rights", "Users with this permission delete reserves and payments.", "Claims")]
[SecureResource("{D276F1BA-F310-4e36-B6D5-88A3628F1082}", "Enter Reserve Level 1", "Users with this permission can enter reserves at the limit specified in enter reserve level 1.", "Claims")]
[SecureResource("{3B739F4B-4D2A-45e6-B017-00389ABBAC8E}", "Enter Reserve Level 2", "Users with this permission can enter reserves at the limit specified in enter reserve level 2.", "Claims")]
[SecureResource("{82B2AE8C-3332-42ca-93E8-02B9525E90C7}", "Enter Reserve Level 3", "Users with this permission can enter reserves at the limit specified in enter reserve level 3.", "Claims")]
[SecureResource("{425C784D-8F13-4200-A559-D0F858D5B001}", "Enter Reserve Level 4", "Users with this permission can enter reserves at the limit specified in enter reserve level 4.", "Claims")]
[SecureResource("{A4A5CC1F-C53B-450d-886D-2135CB41BA19}", "Enter Reserve Level 5", "Users with this permission can enter reserves at the limit specified in enter reserve level 5.", "Claims")]
[SecureResource("{EFFB6D77-905E-4542-9A8E-22087814FCE8}", "Manage Reserve Level Security", "Users with this permission are granted the ability to manage the reserve security levels.", "Claims")]
[SecureResource("{A14CB5B5-4879-4BEE-92D9-8E7063728BB2}", "Claim Loss Date Override Rights", "Users with this permission are granted the ability to post claims with loss dates outside the effective and expiration dates of the policy.", "Claims")]
[SecureResource("{83FF52BD-9064-474C-8252-97406FF6C070}", "Loss Date Outside Policy Reserve/Payment Rights", "Users with this permission are granted the ability to post reserves/payments when the loss dates are outside the effective and expiration dates of the policy.", "Claims")]
[SecureResource("{DDD3A87E-425C-4f1f-BA8E-659AEE694792}", "Move Claim Rights", "Users with this permission are granted the ability to move a claim from one control numebr to another control number.", "Claims")]
[SecureResource("{274800B8-DFDB-41E1-83DE-84C9E18B8208}", "Claim Reserve Level 1", "Users with this permission can enter claim level reserves at the limit specified in enter reserve level 1.", "Claims")]
[SecureResource("{4F197F4D-E1B6-4AFD-9E6F-2B52C2977E91}", "Claim Reserve Level 2", "Users with this permission can enter claim level reserves at the limit specified in enter reserve level 2.", "Claims")]
[SecureResource("{E72454EC-5C6C-457C-9C19-ACE5077EF104}", "Claim Reserve Level 3", "Users with this permission can enter claim level reserves at the limit specified in enter reserve level 3.", "Claims")]
[SecureResource("{BB48491A-6794-463E-89B8-60AA47361BF0}", "Claim Reserve Level 4", "Users with this permission can enter claim level reserves at the limit specified in enter reserve level 4.", "Claims")]
[SecureResource("{7E33061B-EA6E-403D-A736-FA183B88CF1E}", "Claim Reserve Level 5", "Users with this permission can enter claim level reserves at the limit specified in enter reserve level 5.", "Claims")]
[SecureResource("{90947E33-50EE-441D-9A13-42A3ADE5E203}", "Manage Reserve Level Security", "Users with this permission are granted the ability to manage the claim reserve security levels.", "Claims")]
[SecureResource("{B688A03F-0A33-4D90-9EBF-D0A4247F38FB}", "Manage Locked Claims", "Users with this permission are granted the ability to manage the locked claims in the system.", "Claims")]
[SecureResource("{FC4B17CD-2531-4F3C-95DD-B3C3C17EF5C1}", "Transfer Payment Rights", "Users with this permission are granted the ability to transfer claim payments to accounting.", "Claims")]
[SecureResource("{68F0B71D-DB74-4048-9D6C-86379996CFB2}", "Claims View Policy", "Users with this permission are granted the ability to view the policy information via the claims link.", "Claims")]
[SecureResource("{DAD64904-6B99-4A8E-B959-23756D49B95F}", "Transfer Expense Rights", "Users with this permission are granted the ability to transfer claim expenses to accounting.", "Claims")]
[SecureResource("{EB460F2D-0BDA-4FA1-9931-D08994969163}", "Claim Edit Rights", "Users with this permission are granted the ability to edit claim and claimant information. Without this right, users will have only read-only access.", "Claims")]
[SecureResource("{FF0DD32C-D68B-4F90-8828-0B5B78BD321E}", "Claim Expense Automation Management", "Users with this permission are granted the ability to manage the claim expense automation settings.", "Claims")]
[SecureResource("{3311A9E3-78DC-4D13-96B4-D9B07B7F2C1D}", "Claim Expense Management", "Users with this permission are granted the ability add/edit/delete claim un-allocated expenses.", "Claims")]
[SecureResource("{5AE2F4B9-FC01-4132-B8C6-4D62592A4249}", "Claim Number Linking Management", "Users with this permission are granted the ability add/edit the claim number rule linking.", "Claims")]
[SecureResource("{DF7D3FDD-6348-4412-AE40-8988E4F2B7A6}", "Claim Number Management", "Users with this permission are granted the ability add/edit claim number rules.", "Claims")]
[SecureResource("{9C7C462E-7DDD-4511-A553-A65C1A2CACDF}", "Claim Settlement Type Management", "Users with this permission are granted the ability to add/edit/delete claim settlement types.", "Claims")]
[SecureResource("{E1192581-EB1A-4547-813F-4D4D8C35CE16}", "Claim Loss Type Management", "Users with this permission are granted the ability to add/edit/delete claims loss types.", "Claims")]
[SecureResource("{8817DA10-2383-4F7F-9B69-C16F74524E75}", "Claim Accident Type Management", "Users with this permission are granted the ability to manage the claims accident types.", "Claims")]
[SecureResource("{533D63A4-71F1-4ADA-878B-42887DCFE0BD}", "Claim Reserve Type Management", "Users with this permission are granted the ability to manage the claims reserve types.", "Claims")]
[SecureResource("{C70635DA-E735-4C8F-ABD3-AC52F9968F17}", "Claim Reserve Subtype Management", "Users with this permission are granted the ability to manage the claims reserve sub types.", "Claims")]
[SecureResource("{42DB54B5-FCAB-4445-9E7C-A74872F81D9E}", "Claim Outside Adjuster Management", "Users with this permission are granted the ability to manage the claim outside adjusters.", "Claims")]
[SecureResource("{F5A1950B-E3EF-471A-8D1E-B3E2A427E0F5}", "Claim Coverage Type Management", "Users with this permission are granted the ability to manage the claim coverage types.", "Claims")]
[SecureResource("{C22023E1-432B-4A5E-9198-748A7FD11A96}", "Claim Coverage Type Description", "Users with this permission are granted the ability to manage the claim coverage type descriptions.", "Claims")]
[SecureResource("{53E61D58-7820-4548-9272-7ED6EB68A181}", "Claim Managed Care Management", "Users with this permission are granted the ability to manage claim managed care facitlities.", "Claims")]
[SecureResource("{5238598C-FDE6-4530-A9CC-8502FC0A4375}", "Claim Location Settings Management", "Users with this permission are granted the ability to manage the claim location/account settings.", "Claims")]
[SecureResource("{4FC4C027-7466-4499-AEE4-E9160E605315}", "Add Claim Rights", "Users with this permission are granted the ability to add claims.", "Claims")]
[SecureResource("{2BB9808F-C73F-4986-A85F-27F6C82E9C5A}", "Audit User Management", "Users with this permission are granted the ability to add/edit/delete audit users claim access.", "Claims")]
[SecureResource("{FFB8BD7F-5A98-42CA-A3A5-60D224464949}", "Claims CAT Code Management", "Users with this permission are granted the ability add/edit/delete claim CAT codes.", "Claims")]
[SecureResource("{D01270EE-776B-4FE7-B85D-D6536230ECDA}", "Change Claim Number Rights", "Users with this permission are granted the ability to change the manually entered claim number after the claim has been saved.", "Claims")]
[SecureResource("{B69F645B-A06D-44FE-AFDD-4B2EFA97A5AE}", "Re-Open Claim Rights", "Users with this permission are granted the ability to re-open a closed claim.", "Claims")]
[SecureResource("{07F990AF-457C-49F1-9C65-75151047A1D1}", "Modify Reserve Rights", "Users with this permission are granted the right to modify the reserve types.", "Claims")]
[SecureResource("{B0F56AFA-36EB-404F-98A5-DE1120DB058E}", "Void Payment Rights", "Users with this permission are granted the ability to void or reverse payments on a claim.", "Claims")]
[SecureResource("{801A33DA-7B7E-4811-8643-691FB50CB203}", "Void Claim Payment Only Rights", "Users with this permission are granted the ability to void or reverse payments on claims that are not in accounting.", "Claims")]
public static class Utility
{
  internal const string COLORCODE_RESERVESETTING = "CLAIMS_SHOWRESPAYCOLORS";
  internal const string PAYMENTS_CHECKRESERVELEVEL = "CLAIMS_CHECKRESERVELEVEL";
  internal const string RESERVES_CHECKREMAINING = "CLAIMS_CHECKREMAININGRESERVE";
  internal const string VERISK_CLAIMOPTIONS = "Claims.ShowVeriskTab";
  private static readonly Lazy<UserReserveLevelProvider> _reserveLevelProvider = new Lazy<UserReserveLevelProvider>((Func<UserReserveLevelProvider>) (() => ObjectFactory.Instance.CreateObjectAs<UserReserveLevelProvider>()));
  public const string REOPENCLAIM_RIGHTS = "{B69F645B-A06D-44FE-AFDD-4B2EFA97A5AE}";
  public const string DELETECLAIM_RIGHTS = "{E0F4F16E-5F28-48df-9DA9-ACC8212F2F9C}";
  public const string CLAIM_RIGHTS = "{EA38AB9C-FD28-4499-AE11-3E0F01AA9E79}";
  public const string DELETECLAIMEXPENSE_RIGHTS = "{B613D8D3-7586-45c9-9427-A30F64F3155B}";
  public const string ADDEDITCLAIMANT_RIGHTS = "{1E64A478-D481-42a5-B888-90A0BA95547D}";
  public const string CHANGERESERVEPAYMENTTYPE_RIGHTS = "{DF33CB2D-AE2B-4ee3-AA8C-24D08E14E090}";
  public const string ENTERRESERVE_LEVEL1 = "{D276F1BA-F310-4e36-B6D5-88A3628F1082}";
  public const string ENTERRESERVE_LEVEL2 = "{3B739F4B-4D2A-45e6-B017-00389ABBAC8E}";
  public const string ENTERRESERVE_LEVEL3 = "{82B2AE8C-3332-42ca-93E8-02B9525E90C7}";
  public const string ENTERRESERVE_LEVEL4 = "{425C784D-8F13-4200-A559-D0F858D5B001}";
  public const string ENTERRESERVE_LEVEL5 = "{A4A5CC1F-C53B-450d-886D-2135CB41BA19}";
  public const string MANAGERESERVE_LEVELS = "{EFFB6D77-905E-4542-9A8E-22087814FCE8}";
  public const string DELETERESERVEPAYMENT_RIGHTS = "{8CE69C01-5E6B-4e34-A302-AC2525DB41BB}";
  public const string MOVECLAIM_RIGHTS = "{DDD3A87E-425C-4f1f-BA8E-659AEE694792}";
  public const string LOSSDATE_RIGHTS = "{A14CB5B5-4879-4BEE-92D9-8E7063728BB2}";
  public const string LOSSDATEPAYMENT_RIGHTS = "{83FF52BD-9064-474C-8252-97406FF6C070}";
  public const string VIEWPOLICY_CLAIMS = "{68F0B71D-DB74-4048-9D6C-86379996CFB2}";
  public const string CLAIMRESERVE_LEVEL1 = "{274800B8-DFDB-41E1-83DE-84C9E18B8208}";
  public const string CLAIMRESERVE_LEVEL2 = "{4F197F4D-E1B6-4AFD-9E6F-2B52C2977E91}";
  public const string CLAIMRESERVE_LEVEL3 = "{E72454EC-5C6C-457C-9C19-ACE5077EF104}";
  public const string CLAIMRESERVE_LEVEL4 = "{BB48491A-6794-463E-89B8-60AA47361BF0}";
  public const string CLAIMRESERVE_LEVEL5 = "{7E33061B-EA6E-403D-A736-FA183B88CF1E}";
  public const string MANAGECLAIMRESERVE_LEVELS = "{90947E33-50EE-441D-9A13-42A3ADE5E203}";
  public const string CLAIMLOCK_MANAGEMENTRIGHTS = "{B688A03F-0A33-4D90-9EBF-D0A4247F38FB}";
  public const string TRANSFERPAYMENT_RIGHTS = "{FC4B17CD-2531-4F3C-95DD-B3C3C17EF5C1}";
  public const string TRANSFEREXPENSE_RIGHTS = "{DAD64904-6B99-4A8E-B959-23756D49B95F}";
  public const string CLAIMEDITRIGHTS = "{EB460F2D-0BDA-4FA1-9931-D08994969163}";
  public const string MANAGEEXPENSE_AUTOMATION = "{FF0DD32C-D68B-4F90-8828-0B5B78BD321E}";
  public const string CLAIMEXPENSE_MANAGEMENT = "{3311A9E3-78DC-4D13-96B4-D9B07B7F2C1D}";
  public const string CLAIMNUMBERLINKING_MANAGEMENT = "{5AE2F4B9-FC01-4132-B8C6-4D62592A4249}";
  public const string CLAIMNUMBER_MANAGEMENT = "{DF7D3FDD-6348-4412-AE40-8988E4F2B7A6}";
  public const string SETTLEMENTTYPE_MANAGEMENT = "{9C7C462E-7DDD-4511-A553-A65C1A2CACDF}";
  public const string LOSSTYPE_MANAGEMENT = "{E1192581-EB1A-4547-813F-4D4D8C35CE16}";
  public const string CLAIMACCIDENTTYPE_MANAGEMENT = "{8817DA10-2383-4F7F-9B69-C16F74524E75}";
  public const string RESERVETYPE_MANAGEMENT = "{533D63A4-71F1-4ADA-878B-42887DCFE0BD}";
  public const string RESERVESUBTYPE_MANAGEMENT = "{C70635DA-E735-4C8F-ABD3-AC52F9968F17}";
  public const string OUTSIDEADJUSTER_MANAGEMENT = "{42DB54B5-FCAB-4445-9E7C-A74872F81D9E}";
  public const string CLAIMCOVERAGETYPE_MANAGEMENT = "{F5A1950B-E3EF-471A-8D1E-B3E2A427E0F5}";
  public const string COVERAGETYPEDESCRIPTION_MANAGEMENT = "{C22023E1-432B-4A5E-9198-748A7FD11A96}";
  public const string MANAGEDCARE_MANAGEMENT = "{53E61D58-7820-4548-9272-7ED6EB68A181}";
  public const string ACCOUNTINGSETTINGS_MANAGEMENT = "{5238598C-FDE6-4530-A9CC-8502FC0A4375}";
  public const string ADDCLAIM_RIGHTS = "{4FC4C027-7466-4499-AEE4-E9160E605315}";
  public const string CLAIMCATCODE_MANAGEMENT = "{FFB8BD7F-5A98-42CA-A3A5-60D224464949}";
  public const string AUDITUSER_MANAGEMENT = "{2BB9808F-C73F-4986-A85F-27F6C82E9C5A}";
  public const string CHANGECLAIMNUMBER_RIGHTS = "{D01270EE-776B-4FE7-B85D-D6536230ECDA}";
  public const string EDITRESPAYCOMMENT_RIGHTS = "{48E13963-BF89-4831-9E3A-44A3585B88B4}";
  public const string EDITUAEXPENSECOMMENT_RIGHTS = "{7924820D-3CB6-47AD-BD94-339AE336E10A}";
  public const string MODIFYRESERVE_RIGHTS = "{07F990AF-457C-49F1-9C65-75151047A1D1}";
  public const string ATTORNEYMANAGEMENT_RIGHTS = "{A7E673B7-B685-46DE-AFBA-3C24E660B2FE}";
  public const string VOIDPAYMENT_RIGHTS = "{B0F56AFA-36EB-404F-98A5-DE1120DB058E}";
  public const string VOIDPAYMENT_CLAIMSONLY_RIGHTS = "{801A33DA-7B7E-4811-8643-691FB50CB203}";
  public const string CLAIMEXPENSE_ALLOWNEGATIVE_RIGHTS = "{7DA51B1A-9A0D-4178-9BD7-2DA2A2A53C02}";
  public const string CLAIMS_LOCATIONSETTINGS_RIGHTS = "{4BCE65DD-4CAE-4852-90C9-483B0D1707BC}";
  public const string EVENT_CREATECLAIM = "{6300B08D-A940-46ed-9B86-03D27EF14C5C}";
  public const string EVENT_CREATECLAIMANT = "{C9573B52-04AF-47e7-AAED-62586FCB3576}";
  public const string EVENT_CREATERESERVE = "{395AB552-44F5-4ca6-AAAF-7D5E07A8F726}";
  public const string EVENT_CREATEPAYMENT = "{AE832DAE-49F6-4c57-BED9-3B19A0FBDCDC}";
  public const string EVENT_CLOSECLAIM = "{258FBE46-67CB-4059-8D07-E3E014CA210E}";
  public const string EVENT_REOPENCLAIM = "{2369F1BA-5534-4DF7-8A1D-E72C370BB90B}";
  private static DataTable _reserveLevels;
  private static DataTable _claimReserveLevels;
  public const string CLAIMS_ENTITY_GUID = "{171D6129-B1BD-4F1A-9132-C128983FABA9}";
  public const string CLAIMS_ENTITY_NAME = "Claims System";

  internal static void Initialize()
  {
    if (!string.IsNullOrEmpty(DefaultDatabase.ConnectionString))
      return;
    DefaultDatabase.ConnectionString = CurrentUser.Instance.ConnectionString;
  }

  internal static ClaimAddress CreateAddress(AddressResolver_MULTI addRes)
  {
    return new ClaimAddress(addRes.Address1, addRes.Address2, addRes.City, addRes.State, addRes.ZipCode, addRes.ZipCodeExtension, addRes.ISOCountryCode != "USA", addRes.ISOCountryCode);
  }

  internal static ClaimAddress CreateAddress(
    AddressResolver_MULTI addRes,
    MgaPhoneNumberEntry phEntry)
  {
    ClaimAddress address = new ClaimAddress(addRes.Address1, addRes.Address2, addRes.City, addRes.State, addRes.ZipCode, addRes.ZipCodeExtension, addRes.ISOCountryCode != "USA", addRes.ISOCountryCode);
    if (phEntry.NumberManager != null)
      phEntry.NumberManager.Copy(address.NumberManager);
    return address;
  }

  internal static void CreateAddress(
    ClaimAddress address,
    AddressResolver_MULTI addressResolver,
    MgaPhoneNumberEntry phEntry)
  {
    address.Address1 = addressResolver.Address1;
    address.Address2 = addressResolver.Address2;
    address.City = addressResolver.City;
    address.State = addressResolver.State;
    address.ZipCode = addressResolver.ZipCode;
    address.IsoCountryCode = addressResolver.ISOCountryCode;
    address.IsInternational = addressResolver.ISOCountryCode != "USA";
    address.ZipCode = addressResolver.ZipCode;
    address.ZipCodeExtension = addressResolver.ZipCodeExtension;
    address.County = addressResolver.County;
    if (phEntry.NumberManager == null)
      return;
    phEntry.NumberManager.Copy(address.NumberManager);
  }

  internal static int SaveAddress(ClaimAddress address)
  {
    int addressId = (int) DefaultDatabase.ExecuteScalar("spClaims_InsertAddress", new object[22]
    {
      (object) "@UserGuid",
      (object) CurrentUser.Instance.UserGUID,
      (object) "@Address1",
      (object) address.Address1,
      (object) "@Address2",
      (object) address.Address2,
      (object) "@City",
      (object) address.City,
      (object) "@State",
      (object) address.State,
      (object) "@ZipCode",
      (object) (!address.IsInternational ? (SqlString) address.ZipCode : SqlString.Null),
      (object) "@ZipCodeExtension",
      (object) (!address.IsInternational ? (SqlString) address.ZipCodeExtension : SqlString.Null),
      (object) "@IsInternational",
      (object) address.IsInternational,
      (object) "@InternationalZipCode",
      (object) (address.IsInternational ? (SqlString) address.ZipCode : SqlString.Null),
      (object) "@ISOCountryCode",
      (object) address.IsoCountryCode,
      (object) "@County",
      (object) address.County
    });
    if (address.NumberManager != null)
      address.NumberManager.SaveChanges(addressId);
    return addressId;
  }

  internal static void UpdateClaimantAddress(
    ClaimAddress address,
    string storedProcedure,
    Guid claimantGuid)
  {
    if (storedProcedure == "spClaims_UpdateClaimantPrimaryAddress")
      DefaultDatabase.ExecuteNonQuery(storedProcedure, new object[24]
      {
        (object) "@ClaimantGuid",
        (object) claimantGuid,
        (object) "@UserGuid",
        (object) CurrentUser.Instance.UserGUID,
        (object) "@Primary_ISOCountryCode",
        (object) address.IsoCountryCode,
        (object) "@Primary_Address1",
        (object) address.Address1,
        (object) "@Primary_Address2",
        (object) address.Address2,
        (object) "@Primary_City",
        (object) address.City,
        (object) "@Primary_State",
        (object) address.State,
        (object) "@Primary_ZipCode",
        (object) (!address.IsInternational ? (SqlString) address.ZipCode : SqlString.Null),
        (object) "@Primary_ZipCodeExtension",
        (object) (!address.IsInternational ? (SqlString) address.ZipCodeExtension : SqlString.Null),
        (object) "@Primary_IsInternational",
        (object) address.IsInternational,
        (object) "@Primary_InternationalZipCode",
        (object) (address.IsInternational ? (SqlString) address.ZipCode : SqlString.Null),
        (object) "@Primary_County",
        (object) address.County
      });
    else
      DefaultDatabase.ExecuteNonQuery(storedProcedure, new object[24]
      {
        (object) "@ClaimantGuid",
        (object) claimantGuid,
        (object) "@UserGuid",
        (object) CurrentUser.Instance.UserGUID,
        (object) "@Mailing_ISOCountryCode",
        (object) address.IsoCountryCode,
        (object) "@Mailing_Address1",
        (object) address.Address1,
        (object) "@Mailing_Address2",
        (object) address.Address2,
        (object) "@Mailing_City",
        (object) address.City,
        (object) "@Mailing_State",
        (object) address.State,
        (object) "@Mailing_ZipCode",
        (object) (!address.IsInternational ? (SqlString) address.ZipCode : SqlString.Null),
        (object) "@Mailing_ZipCodeExtension",
        (object) (!address.IsInternational ? (SqlString) address.ZipCodeExtension : SqlString.Null),
        (object) "@Mailing_IsInternational",
        (object) address.IsInternational,
        (object) "@Mailing_InternationalZipCode",
        (object) (address.IsInternational ? (SqlString) address.ZipCode : SqlString.Null),
        (object) "@Mailing_County",
        (object) address.County
      });
    if (address.NumberManager == null)
      return;
    int? addressId1 = address.AddressId;
    if (!addressId1.HasValue)
      return;
    PhoneNumberManager numberManager = address.NumberManager;
    addressId1 = address.AddressId;
    int addressId2 = addressId1.Value;
    numberManager.SaveChanges(addressId2);
  }

  internal static void DisplayAddress(AddressResolver_MULTI addressResolver, ClaimAddress address)
  {
    if (address == null)
      return;
    addressResolver.ISOCountryCode = address.IsoCountryCode;
    addressResolver.Address1 = address.Address1;
    addressResolver.Address2 = address.Address2;
    addressResolver.City = address.City;
    addressResolver.State = address.State;
    addressResolver.ZipCode = address.ZipCode;
    addressResolver.ZipCodeExtension = address.ZipCodeExtension;
    addressResolver.County = address.County;
  }

  public static void DisplayAddress(
    AddressResolver_MULTI addressResolver,
    MgaPhoneNumberEntry phoneEntry,
    ClaimAddress address)
  {
    if (address == null)
      return;
    addressResolver.ISOCountryCode = address.IsoCountryCode;
    addressResolver.Address1 = address.Address1;
    addressResolver.Address2 = address.Address2;
    addressResolver.City = address.City;
    addressResolver.State = address.State;
    addressResolver.ZipCode = address.ZipCode;
    addressResolver.ZipCodeExtension = address.ZipCodeExtension;
    addressResolver.County = address.County;
    phoneEntry.DataSource = (object) address.PhoneNumberDataset.PhoneNumbers;
    phoneEntry.InitializePhoneGrid("AddressId", "PhoneTypeId", "PhoneNumberId", "CountryCode", "InputMask");
  }

  internal static bool VerifyAddress(Address address)
  {
    if (string.IsNullOrEmpty(address.Address1) && string.IsNullOrEmpty(address.Address2))
    {
      int num = (int) MessageBox.Show(Resources.ADDRESSERROR_ADDRESSMISSING, Resources.ERROR_REQUIREDFIELD_HEADER, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    if (!address.IsInternational)
    {
      if (string.IsNullOrEmpty(address.City))
      {
        int num = (int) MessageBox.Show(Resources.ADDRESSERROR_CITYMISSING, Resources.ERROR_REQUIREDFIELD_HEADER, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return false;
      }
      if (string.IsNullOrEmpty(address.State))
      {
        int num = (int) MessageBox.Show(Resources.ADDRESSERROR_STATEMISSING, Resources.ERROR_REQUIREDFIELD_HEADER, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return false;
      }
      if (string.IsNullOrEmpty(address.ZipCode))
      {
        int num = (int) MessageBox.Show(Resources.ADDRESSERROR_ZIPCODEMISSING, Resources.ERROR_REQUIREDFIELD_HEADER, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return false;
      }
    }
    return true;
  }

  internal static string GetEntityAddressToolTip(int controlNumber, Guid entityGuid)
  {
    StringBuilder stringBuilder = new StringBuilder();
    DataRow dataRow = DefaultDatabase.ExecuteDataRow("Claims_GetEntityAddress", new object[4]
    {
      (object) "@ControlNumber",
      (object) controlNumber,
      (object) "@EntityGuid",
      (object) entityGuid
    });
    if (!string.IsNullOrEmpty(dataRow["Address1"].ToString()))
      stringBuilder.AppendLine(dataRow["Address1"].ToString());
    if (!string.IsNullOrEmpty(dataRow["Address2"].ToString()))
      stringBuilder.AppendLine(dataRow["Address2"].ToString());
    if (!string.IsNullOrEmpty(dataRow["City"].ToString()))
    {
      stringBuilder.Append(dataRow["City"].ToString());
      stringBuilder.Append(", ");
    }
    if (!string.IsNullOrEmpty(dataRow["State"].ToString()))
    {
      stringBuilder.Append(dataRow["State"].ToString());
      stringBuilder.Append(" ");
    }
    if (!string.IsNullOrEmpty(dataRow["Zip"].ToString()))
      stringBuilder.Append(dataRow["Zip"].ToString());
    if (!string.IsNullOrEmpty(dataRow["ZipPlus"].ToString().Trim()))
    {
      stringBuilder.Append("-");
      stringBuilder.AppendLine(dataRow["ZipPlus"].ToString());
    }
    else
      stringBuilder.AppendLine("");
    if (!string.IsNullOrEmpty(dataRow["Phone"].ToString()))
    {
      stringBuilder.Append("Phone: ");
      stringBuilder.AppendLine(string.Format(dataRow["Phone"].ToString(), (object) "###-###-####"));
    }
    if (!string.IsNullOrEmpty(dataRow["Fax"].ToString()))
    {
      stringBuilder.Append("Fax: ");
      stringBuilder.AppendLine(string.Format(dataRow["Fax"].ToString(), (object) "###-###-####"));
    }
    return stringBuilder.ToString();
  }

  public static void LinkPhoneNumberManager(ClaimAddress address, MgaPhoneNumberEntry phoneEntry)
  {
    phoneEntry.DataSource = (object) address.PhoneNumberDataset.PhoneNumbers;
    phoneEntry.InitializePhoneGrid("AddressId", "PhoneTypeId", "PhoneNumberId", "CountryCode", "InputMask");
  }

  internal static void BindDropDown(UltraDropDown dropDown, DataTable dataSource)
  {
    ((UltraGridBase) dropDown).DataSource = (object) dataSource;
    if (((DisposableObjectCollectionBase) ((UltraGridBase) dropDown).Layouts).Count == 0)
      return;
    ((UltraGridBase) dropDown).DisplayLayout.Load(((UltraGridBase) dropDown).Layouts[0], (PropertyCategories) -1);
  }

  public static void BindSimpleCombo(MGASimpleComboBox combo, DataTable dataSource)
  {
    ((UltraGridBase) combo).DataSource = (object) dataSource;
    if (((DisposableObjectCollectionBase) ((UltraGridBase) combo).Layouts).Count == 0)
      return;
    combo.DisplayLayout.Load(((UltraGridBase) combo).Layouts[0], (PropertyCategories) -1);
  }

  public static void DeleteClaim(int claimId)
  {
    if (!SecurityManager.Instance.AssertPermission("{E0F4F16E-5F28-48df-9DA9-ACC8212F2F9C}"))
      return;
    DefaultDatabase.ExecuteTransaction((EventHandler<ExecuteTransactionEventArgs>) ((sender, e) =>
    {
      Claim claim = (Claim) ObjectFactory.Instance.CreateObject(typeof (Claim), new object[1]
      {
        (object) claimId
      });
      string claimNumber = claim.ClaimNumber;
      string policyNumber = claim.PolicyInformation.PolicyNumber;
      claim.Dispose();
      DefaultDatabase.ExecuteNonQuery("spClaims_DeleteClaim", new object[2]
      {
        (object) "@ClaimId",
        (object) claimId
      });
      CurrentUser.Instance.LogAction($"User deleted claim #{claimNumber} for policy number {policyNumber}.");
      e.Transaction.Commit();
    }));
  }

  public static void DeleteClaimExpense(int uaExpenseId)
  {
    if (!SecurityManager.Instance.AssertPermission("{B613D8D3-7586-45c9-9427-A30F64F3155B}"))
      return;
    DefaultDatabase.ExecuteTransaction((EventHandler<ExecuteTransactionEventArgs>) ((sender, e) =>
    {
      try
      {
        DefaultDatabase.ExecuteNonQuery("spClaims_DeleteUAExpense", new object[2]
        {
          (object) "@UAExpenseID",
          (object) uaExpenseId
        });
        CurrentUser.Instance.LogAction("Deleted claim expense.", "Claims Actions");
        e.Transaction.Commit();
      }
      catch (Exception ex)
      {
        e.Transaction.Rollback();
        throw;
      }
    }));
  }

  internal static void GetPhoneNumbers(int addressId, dsClaims_PhoneNumbers ds)
  {
  }

  public static DataRow GetClaimantInsuredInformation(int controlNumber)
  {
    return DefaultDatabase.ExecuteDataRow("spClaims_GetInsuredInformation", new object[2]
    {
      (object) "@ControlNo",
      (object) controlNumber
    });
  }

  internal static ExpenseAutomationSetting GetExpenseAutomationSetting(string automationCode)
  {
    return new ExpenseAutomationSetting(automationCode);
  }

  public static int GetSetting(string settingAutomationCode)
  {
    object obj = DefaultDatabase.ExecuteScalar("spClaims_GetSetting", new object[2]
    {
      (object) "@SettingAutomationCode",
      (object) settingAutomationCode
    });
    return obj != null ? (int) obj : -1;
  }

  public static int GetSetting(string settingAutomationCode, int glCompanyId)
  {
    object obj = DefaultDatabase.ExecuteScalar("spClaims_GetSetting", new object[2]
    {
      (object) "@SettingAutomationCode",
      (object) settingAutomationCode
    });
    return obj != null ? (int) obj : -1;
  }

  internal static string GetOfficeLocation(int glCompanyId)
  {
    return DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT dbo.GetOfficeLocation(@glcompanyid)", new object[2]
    {
      (object) "@glcompanyid",
      (object) glCompanyId
    }).ToString();
  }

  internal static Address GetEntityAddress(Guid entityGuid)
  {
    DataTable dataTable = DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT * FROM dbo.Claims_GetEntityAddress_Table(@entityGuid)", new object[2]
    {
      (object) "@entityGuid",
      (object) entityGuid
    });
    Address entityAddress = new Address()
    {
      Address1 = dataTable.Rows[0]["Address1"].ToString(),
      Address2 = dataTable.Rows[0]["Address2"].ToString(),
      City = dataTable.Rows[0]["City"].ToString(),
      State = dataTable.Rows[0]["State"].ToString(),
      ZipCode = dataTable.Rows[0]["Zip"].ToString(),
      ZipCodeExtension = dataTable.Rows[0]["ZipPlus"].ToString(),
      IsoCountryCode = dataTable.Rows[0]["ISOCountryCode"].ToString()
    };
    entityAddress.IsInternational = entityAddress.IsoCountryCode != "USA";
    return entityAddress;
  }

  internal static int GetPaymentTransactionNumber(int reservePaymentId)
  {
    object obj = DefaultDatabase.ExecuteScalar("spClaims_GetPaymentTransactionNumber", new object[2]
    {
      (object) "@resPayId",
      (object) reservePaymentId
    });
    return obj != null ? (int) obj : -1;
  }

  public static bool IsPaymentTransactionVoided(int transactionNumber)
  {
    return DefaultDatabase.ExecuteScalar<bool>("dbo.spClaims_IsPaymentTransactionVoided", new object[2]
    {
      (object) "@transactNum",
      (object) transactionNumber
    });
  }

  public static bool HasManualClaimNumberRule(
    Guid companyGuid,
    Guid companyLocationGuid,
    Guid lineGuid,
    DateTime effectiveDate)
  {
    return (bool) DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT dbo.HasManualClaimNumberRule(@CompanyGuid, @CompanyLocationGuid, @LineGuid, @EffectiveDate)", new object[8]
    {
      (object) "@CompanyGuid",
      (object) companyGuid,
      (object) "@CompanyLocationGuid",
      (object) companyLocationGuid,
      (object) "@lineGuid",
      (object) lineGuid,
      (object) "@EffectiveDate",
      (object) effectiveDate
    });
  }

  public static int GetValueHash(object obj)
  {
    int valueHash = 0;
    if (obj is Control && (obj as Control).HasChildren)
    {
      foreach (object control in (ArrangedElementCollection) (obj as Control).Controls)
      {
        if ((control as Control).HasChildren)
        {
          switch (control)
          {
            case MGATextBox _:
            case MGASimpleComboBox _:
            case MGADateTimePicker _:
              break;
            default:
              valueHash += Utility.GetValueHash(control);
              continue;
          }
        }
        switch (control)
        {
          case MGATextBox _:
            valueHash += ((Control) (control as MGATextBox)).Text.GetHashCode();
            continue;
          case MGASimpleComboBox _:
            if (((UltraDropDownBase) (control as MGASimpleComboBox)).SelectedRow != null)
            {
              valueHash += ((UltraDropDownBase) (control as MGASimpleComboBox)).SelectedRow.Cells[0].Value.GetHashCode();
              continue;
            }
            continue;
          case MGADateTimePicker _:
            if (((UltraDateTimeEditor) (control as MGADateTimePicker)).Value != null)
            {
              valueHash += ((UltraDateTimeEditor) (control as MGADateTimePicker)).Value.GetHashCode();
              continue;
            }
            continue;
          case UltraGrid _:
            valueHash += ((DisposableObjectCollectionBase) ((UltraGridBase) (control as UltraGrid)).Rows).Count;
            continue;
          default:
            continue;
        }
      }
    }
    return valueHash;
  }

  internal static void ChangeReservePaymentType(string claimNumber, int resPayId, int resPayTypeId)
  {
    DefaultDatabase.ExecuteTransaction((EventHandler<ExecuteTransactionEventArgs>) ((sender, e) =>
    {
      try
      {
        DefaultDatabase.ExecuteNonQuery("spClaims_ChangeReservePaymentType", new object[6]
        {
          (object) "@ResPayid",
          (object) resPayId,
          (object) "ResPayTypeId",
          (object) resPayTypeId,
          (object) "@UserGuid",
          (object) CurrentUser.Instance.UserGUID
        });
        CurrentUser.Instance.LogAction("Changed the reserve payment type on claim.-" + claimNumber, "Claims Actions");
        e.Transaction.Commit();
      }
      catch (Exception ex)
      {
        e.Transaction.Rollback();
        throw;
      }
    }));
  }

  internal static bool IsDesignMode()
  {
    return LicenseManager.CurrentContext.UsageMode == LicenseUsageMode.Designtime;
  }

  public static Guid GetQuoteGuidFromClaimGuid(Guid claimGuid)
  {
    return new Guid(DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT dbo.GetQuoteGuidFromClaimGuid(@claimGuid)", new object[2]
    {
      (object) "@ClaimGuid",
      (object) claimGuid
    }).ToString());
  }

  public static Guid GetClaimGuid(int claimId)
  {
    return new Guid(DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT dbo.GetClaimGuid(@ClaimId)", new object[2]
    {
      (object) "@ClaimId",
      (object) claimId
    }).ToString());
  }

  public static Guid GetClaimGuid(Guid claimantGuid)
  {
    return new Guid(DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT dbo.GetClaimGuidClaimant(@ClaimantGuid)", new object[2]
    {
      (object) "@ClaimantGuid",
      (object) claimantGuid
    }).ToString());
  }

  public static int GetLossQuoteId(int controlNumber, DateTime lossDate)
  {
    return (int) DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT dbo.Claims_GetLossQuoteId(@ControlNo, @LossDate)", new object[4]
    {
      (object) "@ControlNo",
      (object) controlNumber,
      (object) "@lossDate",
      (object) lossDate
    });
  }

  public static bool GetReserveLevelGuid(Decimal amount)
  {
    string userReserveLevel = Utility._reserveLevelProvider.Value.GetUserReserveLevel().ToString();
    if (string.IsNullOrEmpty(userReserveLevel))
      return true;
    Utility._reserveLevels = Utility._reserveLevels ?? DefaultDatabase.ExecuteDataTable("spClaims_GetReserveLevels");
    return Utility.CheckReserveLevelPermission(amount, userReserveLevel, Utility._reserveLevels);
  }

  public static bool GetClaimReserveLevelGuid(Decimal amount)
  {
    string userReserveLevel = Utility._reserveLevelProvider.Value.GetUserClaimReserveLevel().ToString();
    if (string.IsNullOrEmpty(userReserveLevel))
      return true;
    Utility._claimReserveLevels = Utility._claimReserveLevels ?? DefaultDatabase.ExecuteDataTable("spClaims_GetClaimLevelReserveLimits");
    return Utility.CheckReserveLevelPermission(amount, userReserveLevel, Utility._claimReserveLevels);
  }

  private static bool CheckReserveLevelPermission(
    Decimal amount,
    string userReserveLevel,
    DataTable levels)
  {
    foreach (DataRow row in (InternalDataCollectionBase) levels.Rows)
    {
      if (row["SecurityGuid"].ToString() == userReserveLevel && amount > (Decimal) row["ReserveLevelValue"])
        return false;
    }
    return true;
  }

  public static bool PerformOFACCheck(ClaimOFACEntity claimEntity, bool forceCheck = false)
  {
    OfacSystem.OfacStatus entityStatus = OfacSystem.Instance.GetEntityStatus(claimEntity.EntityGuid, claimEntity.ParentEntityGuid);
    if (((entityStatus == null ? 1 : (!entityStatus.IsValid ? 1 : 0)) | (forceCheck ? 1 : 0)) != 0)
    {
      OfacSystem.OfacResult ofacResult = OfacSystem.Instance.CheckOfacResult<ClaimOFACEntity>(claimEntity);
      return ofacResult != null && ofacResult.OfacHit;
    }
    return entityStatus.IsHit && !entityStatus.OFACCleared;
  }

  public static Form GetParentClaimForm(Claim claim)
  {
    Form parentClaimForm = new Form();
    foreach (Form mdiChild in MDIControls.Instance.MDIParent.MdiChildren)
    {
      if (mdiChild is FormClaims && ((FormClaims) mdiChild).CurrentClaim == claim)
        return mdiChild;
    }
    return parentClaimForm;
  }

  public static Form GetParentClaimForm_ByClaimantGuid(Guid claimantGuid)
  {
    Form formByClaimantGuid = new Form();
    foreach (Form mdiChild1 in MDIControls.Instance.MDIParent.MdiChildren)
    {
      if (mdiChild1 is FormClaimant && ((FormClaimant) mdiChild1).CurrentClaimant.ClaimantGuid.Equals(claimantGuid))
      {
        foreach (Form mdiChild2 in MDIControls.Instance.MDIParent.MdiChildren)
        {
          if (mdiChild1 is FormClaims && ((FormClaims) mdiChild1).CurrentClaim == ((FormClaimant) mdiChild1).CurrentClaimant.Owner)
            return mdiChild2;
        }
      }
    }
    return formByClaimantGuid;
  }

  public static Form GetParentClaimForm_ByClaimId(int claimId)
  {
    Form claimFormByClaimId = new Form();
    foreach (Form mdiChild in MDIControls.Instance.MDIParent.MdiChildren)
    {
      if (mdiChild is FormClaims)
      {
        int? claimId1 = ((FormClaims) mdiChild).CurrentClaim.ClaimId;
        int num = claimId;
        if (claimId1.GetValueOrDefault() == num & claimId1.HasValue)
          return mdiChild;
      }
    }
    return claimFormByClaimId;
  }

  public static void LogAction(string action, int identifier)
  {
    CurrentUser.Instance.LogAction(action, identifier, "Claims Action");
  }

  internal static void SaveLoggedActions(List<string> logList, int claimId)
  {
    if (logList.Count == 0)
      return;
    foreach (string log in logList)
      Utility.LogAction(log, claimId);
    logList.Clear();
  }

  internal static void SetClaimLock(int claimId)
  {
    DefaultDatabase.ExecuteNonQuery("spClaims_InsertClaimLock", new object[4]
    {
      (object) "@claimId",
      (object) claimId,
      (object) "@userGuid",
      (object) CurrentUser.Instance.UserGUID
    });
  }

  internal static void DeleteClaimLock(int claimId)
  {
    DefaultDatabase.ExecuteNonQuery("spClaims_DeleteClaimLock", new object[2]
    {
      (object) "@claimId",
      (object) claimId
    });
  }

  internal static bool IsClaimLocked(int claimId)
  {
    return DefaultDatabase.ExecuteScalar<bool>(CommandType.Text, "Select dbo.IsClaimLocked(@claimId)", new object[2]
    {
      (object) "@claimId",
      (object) claimId
    });
  }

  public static Assembly LoadComponentAssembly(object sender, ResolveEventArgs args)
  {
    return Assembly.GetExecutingAssembly();
  }

  public static bool IsAuditUser(Guid userGuid)
  {
    return DefaultDatabase.ExecuteScalar<bool>(CommandType.Text, "select dbo.Claims_IsAuditUser(@userGuid)", new object[2]
    {
      (object) "@userGuid",
      (object) userGuid
    });
  }

  public enum ClaimActivityType
  {
    ClaimCreated,
    ClaimantCreated,
    ClaimModified,
    ClaimantModified,
    ReserveCreated,
    ReserveAdjusted,
    PaymentCreated,
    PaymentAdjusted,
    ClaimClosed,
    ClaimReopened,
    PaymentVoided,
  }

  public enum ClaimStatus
  {
    Open,
    Closed,
  }

  [Flags]
  internal enum SearchEntityTypes
  {
    None = 1,
    ShowCompanyGroup = 2,
    ShowCompany = 4,
    ShowCompanyLocations = 8,
    ShowCompanyLines = 16, // 0x00000010
    ShowInsured = 32, // 0x00000020
    ShowIntermediary = 64, // 0x00000040
    ShowProducer = 128, // 0x00000080
    ShowProducerLocation = 256, // 0x00000100
    ShowUsers = 512, // 0x00000200
    ShowUserGroups = 1024, // 0x00000400
    ShowExpensePayees = 2048, // 0x00000800
    Show3rdParty = 4096, // 0x00001000
    ShowFinanceCompanies = 8192, // 0x00002000
    ShowInspectionCompanies = 16384, // 0x00004000
    ShowOutsideAdjusters = 32768, // 0x00008000
    ShowManagedCareFacilities = 65536, // 0x00010000
    ShowClaimEntities = 131072, // 0x00020000
    All = ShowManagedCareFacilities | ShowOutsideAdjusters | ShowInspectionCompanies | ShowFinanceCompanies | Show3rdParty | ShowExpensePayees | ShowUserGroups | ShowUsers | ShowProducerLocation | ShowProducer | ShowIntermediary | ShowInsured | ShowCompanyLines | ShowCompanyLocations | ShowCompany | ShowCompanyGroup, // 0x0001FFFE
  }

  public enum CollectionItemStatus
  {
    Unchanged,
    New,
    Updated,
    Deleted,
  }

  internal enum AutomatedExpenseTypes
  {
    CreateClaim,
    CreateClaimant,
    CreateReserve,
    CreatePayment,
    CloseClaim,
  }

  public enum AutomationDocumentGroups
  {
    Claim = 10, // 0x0000000A
    Claimant = 11, // 0x0000000B
  }
}
