// Decompiled with JetBrains decompiler
// Type: MgaSystems.Ims.Fortegra.Overrides.Claims.Fortegra_UserReserveLevelProvider
// Assembly: MgaSystems.Ims.Fortegra, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 27007E94-85B4-4A1A-9444-255CCA5487B0
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Fortegra.dll

using MGASystems.Common;
using MGASystems.IMS.Claims.Utility_Classes;
using System;

#nullable disable
namespace MgaSystems.Ims.Fortegra.Overrides.Claims;

[SecureResource("{87BED911-7232-44ED-A167-712A1C715EDC}", "Claim Reserve Level 6", "Users with this permission can enter claim level reserves at the limit specified in enter reserve level 6.", "Claims")]
[SecureResource("{8C0A36B6-FD1D-4D39-BB11-FD7F2EE86553}", "Claim Reserve Level 7", "Users with this permission can enter claim level reserves at the limit specified in enter reserve level 7.", "Claims")]
[SecureResource("{BE7089A4-2936-4A20-953D-9174E894A8A5}", "Claim Reserve Level 8", "Users with this permission can enter claim level reserves at the limit specified in enter reserve level 8.", "Claims")]
[SecureResource("{401AFA5C-2177-4577-BA24-3FC3BD5B4BA5}", "Claim Reserve Level 9", "Users with this permission can enter claim level reserves at the limit specified in enter reserve level 9.", "Claims")]
[SecureResource("{15AC47F0-88BE-4E2C-B922-F77D9B79A0B1}", "Claim Reserve Level 10", "Users with this permission can enter claim level reserves at the limit specified in enter reserve level 10.", "Claims")]
[SecureResource("{B186DEF5-2463-4875-BC75-C763A275F017}", "Enter Reserve Level 6", "Users with this permission can enter reserves at the limit specified in enter reserve level 6.", "Claims")]
[SecureResource("{0ECD085F-18CF-4474-9E50-8CE529A6E93C}", "Enter Reserve Level 7", "Users with this permission can enter reserves at the limit specified in enter reserve level 7.", "Claims")]
[SecureResource("{0DA0957F-C851-4903-BB13-A66AC53D3D6E}", "Enter Reserve Level 8", "Users with this permission can enter reserves at the limit specified in enter reserve level 8.", "Claims")]
[SecureResource("{587271D2-EF42-47CA-A581-45699781A26E}", "Enter Reserve Level 9", "Users with this permission can enter reserves at the limit specified in enter reserve level 9.", "Claims")]
[SecureResource("{63E4AF00-613D-4164-B955-76DCF3874407}", "Enter Reserve Level 10", "Users with this permission can enter reserves at the limit specified in enter reserve level 10.", "Claims")]
[Override(typeof (UserReserveLevelProvider))]
public class Fortegra_UserReserveLevelProvider : UserReserveLevelProvider
{
  public const string CLAIMRESERVE_LEVEL6 = "{87BED911-7232-44ED-A167-712A1C715EDC}";
  public const string CLAIMRESERVE_LEVEL7 = "{8C0A36B6-FD1D-4D39-BB11-FD7F2EE86553}";
  public const string CLAIMRESERVE_LEVEL8 = "{BE7089A4-2936-4A20-953D-9174E894A8A5}";
  public const string CLAIMRESERVE_LEVEL9 = "{401AFA5C-2177-4577-BA24-3FC3BD5B4BA5}";
  public const string CLAIMRESERVE_LEVEL10 = "{15AC47F0-88BE-4E2C-B922-F77D9B79A0B1}";
  public const string ENTERRESERVE_LEVEL6 = "{B186DEF5-2463-4875-BC75-C763A275F017}";
  public const string ENTERRESERVE_LEVEL7 = "{0ECD085F-18CF-4474-9E50-8CE529A6E93C}";
  public const string ENTERRESERVE_LEVEL8 = "{0DA0957F-C851-4903-BB13-A66AC53D3D6E}";
  public const string ENTERRESERVE_LEVEL9 = "{587271D2-EF42-47CA-A581-45699781A26E}";
  public const string ENTERRESERVE_LEVEL10 = "{63E4AF00-613D-4164-B955-76DCF3874407}";

  protected override string[] ReservePermissions
  {
    get
    {
      return this.ConcatArrays(new string[5]
      {
        "{63E4AF00-613D-4164-B955-76DCF3874407}",
        "{587271D2-EF42-47CA-A581-45699781A26E}",
        "{0DA0957F-C851-4903-BB13-A66AC53D3D6E}",
        "{0ECD085F-18CF-4474-9E50-8CE529A6E93C}",
        "{B186DEF5-2463-4875-BC75-C763A275F017}"
      }, base.ReservePermissions);
    }
  }

  protected override string[] ClaimPermissions
  {
    get
    {
      return this.ConcatArrays(new string[5]
      {
        "{15AC47F0-88BE-4E2C-B922-F77D9B79A0B1}",
        "{401AFA5C-2177-4577-BA24-3FC3BD5B4BA5}",
        "{BE7089A4-2936-4A20-953D-9174E894A8A5}",
        "{8C0A36B6-FD1D-4D39-BB11-FD7F2EE86553}",
        "{87BED911-7232-44ED-A167-712A1C715EDC}"
      }, base.ClaimPermissions);
    }
  }

  private string[] ConcatArrays(string[] array, string[] otherArray)
  {
    string[] strArray = new string[array.Length + otherArray.Length];
    array.CopyTo((Array) strArray, 0);
    otherArray.CopyTo((Array) strArray, array.Length);
    return strArray;
  }
}
