// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.WebRequestExtensions.WebRequestExtensions
// Assembly: MgaSystems.IMS.Common, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 46CE8D79-2C19-419C-BC23-F8C69E623B17
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.dll

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization.Json;
using System.Text;

#nullable disable
namespace MGASystems.Common.WebRequestExtensions;

[StandardModule]
public sealed class WebRequestExtensions
{
  public static string GetResponseString(this WebRequest webRequest)
  {
    using (Stream responseStream = webRequest.GetResponse().GetResponseStream())
    {
      using (StreamReader streamReader = new StreamReader(responseStream))
        return streamReader.ReadToEnd();
    }
  }

  public static void PostString(this WebRequest webRequest, string postData)
  {
    using (Stream requestStream = webRequest.GetRequestStream())
    {
      using (StreamWriter streamWriter = new StreamWriter(requestStream))
        streamWriter.Write(postData);
    }
  }

  public static T JsonStringToObject<T>(this string jsonString)
  {
    using (MemoryStream memoryStream = new MemoryStream(Encoding.UTF8.GetBytes(jsonString)))
      return (T) new DataContractJsonSerializer(typeof (T)).ReadObject((Stream) memoryStream);
  }

  public static string ToUTF8String(
    this DataContractJsonSerializer dataContractJsonSerializer,
    object objectToSerialize)
  {
    using (MemoryStream memoryStream = new MemoryStream())
    {
      dataContractJsonSerializer.WriteObject((Stream) memoryStream, RuntimeHelpers.GetObjectValue(objectToSerialize));
      return Encoding.UTF8.GetString(memoryStream.ToArray());
    }
  }

  public static string JsonPostObject(
    this WebRequest webRequest,
    object postObject,
    Action<string> onJsonCreated = null,
    Action<string> onJsonReceived = null)
  {
    string postData = postObject != null ? new DataContractJsonSerializer(postObject.GetType()).ToUTF8String(RuntimeHelpers.GetObjectValue(postObject)) : throw new ArgumentNullException(nameof (postObject));
    if (onJsonCreated != null)
      onJsonCreated(postData);
    webRequest.PostString(postData);
    string responseString = webRequest.GetResponseString();
    if (onJsonReceived != null)
      onJsonReceived(responseString);
    return responseString;
  }

  public static T JsonPostObject<T>(
    this WebRequest webRequest,
    object postObject,
    Action<string> onJsonCreated = null,
    Action<string> onJsonReceived = null)
    where T : class
  {
    DataContractJsonSerializer dataContractJsonSerializer = postObject != null ? new DataContractJsonSerializer(postObject.GetType()) : throw new ArgumentNullException(nameof (postObject));
    DataContractJsonSerializer contractJsonSerializer = new DataContractJsonSerializer(typeof (T));
    object objectValue = RuntimeHelpers.GetObjectValue(postObject);
    string utF8String = dataContractJsonSerializer.ToUTF8String(objectValue);
    if (onJsonCreated != null)
      onJsonCreated(utF8String);
    webRequest.PostString(utF8String);
    string responseString = webRequest.GetResponseString();
    if (onJsonReceived != null)
      onJsonReceived(responseString);
    using (MemoryStream memoryStream = new MemoryStream(Encoding.UTF8.GetBytes(responseString)))
      return (T) contractJsonSerializer.ReadObject((Stream) memoryStream);
  }
}
