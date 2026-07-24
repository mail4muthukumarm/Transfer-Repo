// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.AccountingCache
// Assembly: MgaSystems.IMS.Accounting.GeneralLedger, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: DC511D5D-5AA9-4B52-8578-E2A0BCB046C3
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Accounting.GeneralLedger.dll

using System;
using System.Collections;

#nullable disable
namespace MGASystems.IMS.Accounting;

public sealed class AccountingCache
{
  private static AccountingCache instance;
  private static Hashtable GLCompanies;

  private AccountingCache()
  {
  }

  public static AccountingCache Instance
  {
    get
    {
      if (AccountingCache.instance == null)
        AccountingCache.instance = new AccountingCache();
      return AccountingCache.instance;
    }
  }

  public MGASystems.IMS.Accounting.GlCompany GlCompany(int GlCompanyId)
  {
    if (AccountingCache.GLCompanies == null)
    {
      AccountingCache.GLCompanies = new Hashtable();
      WeakReference weakReference = new WeakReference((object) new MGASystems.IMS.Accounting.GlCompany(GlCompanyId), false);
      AccountingCache.GLCompanies.Add((object) ((MGASystems.IMS.Accounting.GlCompany) weakReference.Target).GlCompanyId, (object) weakReference);
      return (MGASystems.IMS.Accounting.GlCompany) weakReference.Target;
    }
    if (AccountingCache.GLCompanies.Count == 0)
    {
      WeakReference weakReference = new WeakReference((object) new MGASystems.IMS.Accounting.GlCompany(GlCompanyId), false);
      AccountingCache.GLCompanies.Add((object) ((MGASystems.IMS.Accounting.GlCompany) weakReference.Target).GlCompanyId, (object) weakReference);
      return (MGASystems.IMS.Accounting.GlCompany) weakReference.Target;
    }
    if (!AccountingCache.GLCompanies.ContainsKey((object) GlCompanyId))
    {
      WeakReference weakReference = new WeakReference((object) new MGASystems.IMS.Accounting.GlCompany(GlCompanyId), false);
      AccountingCache.GLCompanies.Add((object) ((MGASystems.IMS.Accounting.GlCompany) weakReference.Target).GlCompanyId, (object) weakReference);
      return (MGASystems.IMS.Accounting.GlCompany) weakReference.Target;
    }
    WeakReference glCompany = (WeakReference) AccountingCache.GLCompanies[(object) GlCompanyId];
    if (glCompany.Target != null)
      return (MGASystems.IMS.Accounting.GlCompany) glCompany.Target;
    glCompany.Target = (object) new MGASystems.IMS.Accounting.GlCompany(GlCompanyId);
    return (MGASystems.IMS.Accounting.GlCompany) glCompany.Target;
  }
}
