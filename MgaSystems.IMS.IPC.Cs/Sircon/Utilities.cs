// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.Sircon.Utilities
// Assembly: MgaSystems.IMS.IPC.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 902BD8FA-9BAE-43A4-A4AA-C9585D23F16B
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.IPC.Cs.dll

using MGASystems.Common;
using MGASystems.IMS.Security;
using System;

#nullable disable
namespace MGASystems.IMS.InsuredsProducersCompanies.Sircon;

[SecureResource("1f8fd4dc-dbc0-4e80-8788-07cd0fbef905", "SirconAccess", "Allows user to access Sircon functions", "Producers")]
public static class Utilities
{
  private const string _SirconResource = "1f8fd4dc-dbc0-4e80-8788-07cd0fbef905";
  private static string _SirconEncryptedUsername_Test = "9bpZpBU2rBU=";
  private static string _SirconEncryptedPassword_Test = "lauQEMCWi/VzjiZ2HwTkHQ==";
  private static string _SirconEndPoint_Test = "https://sdbuat.sircon.com/webservice/services/2006/06/ProducerLifecycleService";
  private static string _SirconEncryptedUsername_Production = Utilities.getSirconStringSystemSettings("SirconEncryptedID");
  private static string _SirconEncryptedPassword_Production = Utilities.getSirconStringSystemSettings("SirconEncryptedPW");
  private static string _SirconEndPoint_Production = Utilities.getSirconStringSystemSettings(nameof (SirconEndPoint));
  private static string _SirconEncryptedUsername = Utilities._SirconEncryptedUsername_Production;
  private static string _SirconEncryptedPassword = Utilities._SirconEncryptedPassword_Production;
  private static string _SirconEndPoint = Utilities._SirconEndPoint_Production;
  private static Encryption encryptionService = new Encryption();

  private static string getSirconStringSystemSettings(string sysSetting)
  {
    try
    {
      if (SystemSettings.KeyExists(sysSetting))
        return SystemSettings.GetStringSetting(sysSetting);
    }
    catch
    {
    }
    return string.Empty;
  }

  public static bool SirconEnabled
  {
    get
    {
      return !string.IsNullOrEmpty(Utilities._SirconEncryptedUsername) && !string.IsNullOrEmpty(Utilities._SirconEncryptedPassword) && !string.IsNullOrEmpty(Utilities._SirconEndPoint) && SecurityManager.Instance.AssertPermission("1f8fd4dc-dbc0-4e80-8788-07cd0fbef905");
    }
  }

  public static string limitStringLength(string input, int maxLength)
  {
    return input != null && input.Length > maxLength ? input.Substring(0, maxLength) : input;
  }

  public static int SirconSubscriberID
  {
    get
    {
      int result;
      int.TryParse(Utilities.SirconUsername, out result);
      return result;
    }
  }

  public static int SirconCarrierID => Utilities.SirconSubscriberID;

  public static string SirconUsername
  {
    get => Utilities.encryptionService.DecryptTripleDes(Utilities._SirconEncryptedUsername);
  }

  public static string SirconPassword
  {
    get => Utilities.encryptionService.DecryptTripleDes(Utilities._SirconEncryptedPassword);
  }

  public static string SirconEndPoint => Utilities._SirconEndPoint;

  public static DateTime defaultInvalidDate(DateTime date)
  {
    return date.Year < 1900 || date.Year > 2200 ? new DateTime(1900, 1, 1) : date;
  }
}
