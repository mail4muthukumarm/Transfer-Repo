// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.Policies.Misc.Lib.Extensions
// Assembly: MgaSystems.IMS.Policies.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 0490D932-1980-4BA9-8AB9-51DC95793BA0
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Policies.Cs.dll

using System.IO;
using System.Runtime.Serialization.Json;
using System.Text;

#nullable disable
namespace MgaSystems.IMS.Policies.Misc.Lib;

public static class Extensions
{
  public static T JsonStringToObject<T>(this string jsonString)
  {
    using (MemoryStream memoryStream = new MemoryStream(Encoding.UTF8.GetBytes(jsonString)))
      return (T) new DataContractJsonSerializer(typeof (T)).ReadObject((Stream) memoryStream);
  }
}
