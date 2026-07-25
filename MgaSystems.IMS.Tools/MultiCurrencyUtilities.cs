// Decompiled with JetBrains decompiler
// Type: MGASystems.Tools.MultiCurrencyUtilities
// Assembly: MgaSystems.IMS.Tools, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 1287D1AD-C908-42E9-BE8F-4574B2D0AB9E
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Tools.dll

using MGASystems.Data;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Data;
using System.Globalization;
using System.Threading;

#nullable disable
namespace MGASystems.Tools;

public class MultiCurrencyUtilities
{
  private static bool? MultiCurrencyActive;

  public static CultureInfo GetCultureInfo(string currencyCode)
  {
    CultureInfo cultureInfo1;
    try
    {
      cultureInfo1 = new CultureInfo(Thread.CurrentThread.CurrentCulture.LCID);
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      Exception exception = ex;
      exception.Data.Add((object) "CurrentCulture.DisplayName", (object) Thread.CurrentThread.CurrentCulture.DisplayName);
      exception.Data.Add((object) "CurrentCulture.Name", (object) Thread.CurrentThread.CurrentCulture.Name);
      throw;
    }
    if (!MultiCurrencyUtilities.MultiCurrencyActive.HasValue)
      MultiCurrencyUtilities.MultiCurrencyActive = new bool?(Conversions.ToBoolean(DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT SettingValueBool FROM tblSystemSettings WHERE Setting = @MC_Setting", new object[2]
      {
        (object) "@MC_Setting",
        (object) "MultiCurrencyActive"
      })));
    bool? multiCurrencyActive = MultiCurrencyUtilities.MultiCurrencyActive;
    CultureInfo cultureInfo2;
    if ((multiCurrencyActive.HasValue ? new bool?(!multiCurrencyActive.GetValueOrDefault()) : multiCurrencyActive).GetValueOrDefault())
    {
      cultureInfo2 = cultureInfo1;
    }
    else
    {
      CultureInfo[] cultures = CultureInfo.GetCultures(CultureTypes.SpecificCultures);
      int index = 0;
      while (index < cultures.Length)
      {
        CultureInfo cultureInfo3 = cultures[index];
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(new RegionInfo(cultureInfo3.LCID).ISOCurrencySymbol, currencyCode, false) == 0)
        {
          cultureInfo1.NumberFormat.CurrencySymbol = cultureInfo3.NumberFormat.CurrencySymbol;
          break;
        }
        checked { ++index; }
      }
      cultureInfo2 = cultureInfo1;
    }
    return cultureInfo2;
  }

  public static bool IsMultiCurrencyActive()
  {
    if (!MultiCurrencyUtilities.MultiCurrencyActive.HasValue)
      MultiCurrencyUtilities.MultiCurrencyActive = new bool?(Conversions.ToBoolean(DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT SettingValueBool FROM tblSystemSettings WHERE Setting = @MC_Setting", new object[2]
      {
        (object) "@MC_Setting",
        (object) "MultiCurrencyActive"
      })));
    return MultiCurrencyUtilities.MultiCurrencyActive.Value;
  }
}
