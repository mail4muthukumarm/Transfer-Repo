// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Services.ClassObjects.Utility
// Assembly: MgaSystems.IMS.Accounting.Services, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EEF87E2E-9738-4C33-AE03-5712A958CE99
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Services.dll

using MGASystems.Common;

#nullable disable
namespace MGASystems.IMS.Accounting.Services.ClassObjects;

[SecureResource("{FFF36592-F453-47D4-BA77-932263BC209F}", "Edit Cost Center Allocation Rights", "Determines whether or not the user can edit cost center allocations.", "Accounting")]
[SecureResource("{5918B7F5-4210-4E17-87D9-D9EC0CBDDDA3}", "Overdue Invoice Utility Rights", "Determines whether or not the user can access the overdue invoice utility screen.", "Accounting")]
[SecureResource("{0DFDA4A7-5C59-476F-ABD8-E143F22A6A2C}", "Web Service Bank Settings Rights", "Determines whether or not the user can access the web service bank settings screen.", "Accounting")]
public sealed class Utility
{
  public const string EDITCOSTCENTER_RIGHTS = "{FFF36592-F453-47D4-BA77-932263BC209F}";
  public const string OVERDUEINVOICEUTILITY_RIGHTS = "{5918B7F5-4210-4E17-87D9-D9EC0CBDDDA3}";
  public const string WEBSERVICEBANKSETTINGS_RIGHTS = "{0DFDA4A7-5C59-476F-ABD8-E143F22A6A2C}";

  private Utility()
  {
  }
}
