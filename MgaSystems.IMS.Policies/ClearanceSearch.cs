// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.ClearanceSearch
// Assembly: MgaSystems.IMS.Policies, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 2FF2C709-F7BF-41DA-82BD-FF6319CA235D
// Assembly location: C:\Users\muthu\Downloads\MgaSystems.IMS.Policies.dll

using MGASystems.IMS.Policies.Clearance;
using Microsoft.VisualBasic.CompilerServices;

#nullable disable
namespace MGASystems.IMS.Policies;

[StandardModule]
public sealed class ClearanceSearch
{
  private static TabClearanceSearch _tabClearanceSearch;
  private static string _cityInfo;
  private static string _stateInfo;
  private static string _streetInfo;
  private static string _zipInfo;

  public static TabClearanceSearch TabClearance
  {
    get => ClearanceSearch._tabClearanceSearch;
    set => ClearanceSearch._tabClearanceSearch = value;
  }

  public static string CityInfo
  {
    get => ClearanceSearch._cityInfo;
    set => ClearanceSearch._cityInfo = value;
  }

  public static string StateInfo
  {
    get => ClearanceSearch._stateInfo;
    set => ClearanceSearch._stateInfo = value;
  }

  public static string StreetInfo
  {
    get => ClearanceSearch._streetInfo;
    set => ClearanceSearch._streetInfo = value;
  }

  public static string ZipInfo
  {
    get => ClearanceSearch._zipInfo;
    set => ClearanceSearch._zipInfo = value;
  }
}
