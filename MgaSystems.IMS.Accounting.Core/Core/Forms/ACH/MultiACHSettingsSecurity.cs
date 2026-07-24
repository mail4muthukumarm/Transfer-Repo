// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Core.Forms.ACH.MultiACHSettingsSecurity
// Assembly: MgaSystems.IMS.Accounting.Core, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 923053EF-B70A-44B5-B8DA-B227263F4FD2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Core.dll

using MGASystems.Common;
using MGASystems.Data.DataEncryption;
using MGASystems.IMS.Accounting.Core.ClassObjects;
using MGASystems.IMS.Security;

#nullable disable
namespace MGASystems.IMS.Accounting.Core.Forms.ACH;

[SecureResource("{874EE530-D436-4FE2-84E1-19B88F2D1671}", "Create ACH Settings", "Controls the ability to create ACH Settings", "Accounting")]
[SecureResource("{A1D1B7AA-6A84-4EC7-9C3F-104CBDFA3D5A}", "Edit ACH Settings", "Controls the ability to edit ACH Settings", "Accounting")]
[SecureResource("{4F758F84-6A44-41F8-8341-02FE6B7708CF}", "Delete ACH Settings", "Controls the ability to delete ACH Settings", "Accounting")]
[SecureResource("{AD7318F4-708E-4AA7-B6A5-26AAE6265FC7}", "Approve ACH Settings", "Controls the ability to approve pending changes to ACH Settings", "Accounting")]
[SecureResource("{06028A54-624A-4E16-A12E-6EEDF77BD254}", "View Encrypted ACH Bank Data", "Determines whether user can view encrypted ACH bank information.", "Accounting")]
public static class MultiACHSettingsSecurity
{
  private const string CREATE_SETTINGS = "{874EE530-D436-4FE2-84E1-19B88F2D1671}";
  private const string EDIT_SETTINGS = "{A1D1B7AA-6A84-4EC7-9C3F-104CBDFA3D5A}";
  private const string DELETE_SETTINGS = "{4F758F84-6A44-41F8-8341-02FE6B7708CF}";
  private const string APPROVE_SETTINGS = "{AD7318F4-708E-4AA7-B6A5-26AAE6265FC7}";
  private const string VIEWENCRYPTEDRIGHTS = "{06028A54-624A-4E16-A12E-6EEDF77BD254}";
  private const string TripleDesKey = "c0feee41-3b76-4b22-8959-6b89ecc54a86";
  private static readonly TripleDesEncrypter _encryption = new TripleDesEncrypter("c0feee41-3b76-4b22-8959-6b89ecc54a86");

  public static string LogContext => "ACH Setting";

  public static bool CanCreateSettings
  {
    get => MultiACHSettingsSecurity.Assert("{874EE530-D436-4FE2-84E1-19B88F2D1671}");
  }

  public static bool CanEditSettings
  {
    get => MultiACHSettingsSecurity.Assert("{A1D1B7AA-6A84-4EC7-9C3F-104CBDFA3D5A}");
  }

  public static bool CanDeleteSettings
  {
    get => MultiACHSettingsSecurity.Assert("{4F758F84-6A44-41F8-8341-02FE6B7708CF}");
  }

  public static bool CanApproveSettings
  {
    get => MultiACHSettingsSecurity.Assert("{AD7318F4-708E-4AA7-B6A5-26AAE6265FC7}");
  }

  public static bool CanViewEncryptedSettings
  {
    get => MultiACHSettingsSecurity.Assert("{06028A54-624A-4E16-A12E-6EEDF77BD254}");
  }

  public static string Decrypt(string text)
  {
    return !Utility.IsBase64(text) ? string.Empty : MultiACHSettingsSecurity._encryption.Decrypt(text);
  }

  public static string Decrypt(object value)
  {
    return value != null ? MultiACHSettingsSecurity.Decrypt(value.ToString()) : string.Empty;
  }

  public static string Encrypt(string text)
  {
    return !string.IsNullOrWhiteSpace(text) ? MultiACHSettingsSecurity._encryption.Encrypt(text) : (string) null;
  }

  private static bool Assert(string resource)
  {
    return SecurityManager.Instance.AssertPermission(resource);
  }
}
