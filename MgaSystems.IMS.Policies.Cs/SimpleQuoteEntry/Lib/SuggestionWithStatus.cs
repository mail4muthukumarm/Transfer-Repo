// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.Policies.SimpleQuoteEntry.Lib.SuggestionWithStatus
// Assembly: MgaSystems.IMS.Policies.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 0490D932-1980-4BA9-8AB9-51DC95793BA0
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Policies.Cs.dll

using System;

#nullable disable
namespace MgaSystems.IMS.Policies.SimpleQuoteEntry.Lib;

public class SuggestionWithStatus
{
  public string DisplayValue { get; set; }

  public object SelectedObject { get; set; }

  public string Code { get; set; }

  public string SearchString1 { get; set; }

  public string SubString1 { get; set; }

  public string SubString2 { get; set; }

  public byte StatusID { get; set; }

  private SuggestionWithStatus()
  {
  }

  public static SuggestionWithStatus GetSuggestionCodeDescription(
    object resultObj,
    object searchObj)
  {
    SuggestionWithStatus suggestionCodeDescription = new SuggestionWithStatus();
    suggestionCodeDescription.ParseCodeDescription(resultObj.ToString(), searchObj.ToString());
    return suggestionCodeDescription;
  }

  private void ParseCodeDescription(string resultCode, string searchCode)
  {
    int num = resultCode.IndexOf(searchCode, StringComparison.CurrentCultureIgnoreCase);
    if (num > -1)
    {
      this.SubString1 = resultCode.Substring(0, num);
      this.SearchString1 = resultCode.Substring(num, searchCode.Length);
      this.SubString2 = resultCode.Substring(num + searchCode.Length);
    }
    else
    {
      this.SubString1 = resultCode;
      this.SearchString1 = string.Empty;
      this.SubString2 = string.Empty;
    }
  }
}
