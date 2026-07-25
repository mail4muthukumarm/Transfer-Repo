// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.UnderwritingServices.UrlExtensions
// Assembly: MgaSystems.IMS.UnderwritingServices, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 4E63F408-1B27-4004-B8D3-2C6361F8A9AF
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.UnderwritingServices.dll

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Web;

#nullable disable
namespace MgaSystems.IMS.UnderwritingServices;

public static class UrlExtensions
{
  private static readonly char[] PathSeparaters = new char[2]
  {
    '\\',
    '/'
  };

  public static Uri AppendUrlParts(this Uri baseUri, params string[] urlParts)
  {
    if (baseUri == (Uri) null)
      throw new ArgumentNullException(nameof (baseUri));
    return (urlParts != null ? (!((IEnumerable<string>) urlParts).Any<string>() ? 1 : 0) : 1) != 0 ? baseUri : new Uri(baseUri.ToString().AppendUrlParts(urlParts));
  }

  public static string AppendUrlParts(this string baseUrl, params string[] urlParts)
  {
    baseUrl = baseUrl ?? string.Empty;
    if (urlParts != null && urlParts.Length != 0)
    {
      StringBuilder stringBuilder = new StringBuilder(baseUrl);
      foreach (string urlPart in urlParts)
        baseUrl = $"{baseUrl.TrimEnd(UrlExtensions.PathSeparaters)}/{(urlPart ?? string.Empty).TrimStart(UrlExtensions.PathSeparaters)}";
    }
    return baseUrl;
  }

  public static Uri AddQueryParameter(this Uri url, string parameterName, string parameterValue)
  {
    return url.AddQueryParameters((parameterName, parameterValue));
  }

  public static Uri AddQueryParameters(
    this Uri url,
    params (string ParameterName, string ParameterValue)[] values)
  {
    return new Uri(url.ToString().AddQueryParameters(values), UriKind.RelativeOrAbsolute);
  }

  public static string AddQueryParameter(
    this string url,
    string parameterName,
    string parameterValue)
  {
    return url.AddQueryParameters((parameterName, parameterValue));
  }

  public static string AddQueryParameters(
    this string url,
    params (string ParameterName, string ParameterValue)[] values)
  {
    int startIndex = url.IndexOf("?");
    string str = startIndex != -1 ? url.Substring(startIndex) : "?";
    NameValueCollection queryString = HttpUtility.ParseQueryString(str);
    foreach ((string, string) tuple in ((IEnumerable<(string, string)>) values).Where<(string, string)>((Func<(string, string), bool>) (v => !string.IsNullOrEmpty(v.ParameterName))))
      queryString[tuple.Item1] = tuple.Item2;
    return $"{url.Replace(str, string.Empty)}?{queryString}";
  }
}
