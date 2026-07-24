// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.FileReader
// Assembly: MgaSystems.IMS.Common, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 46CE8D79-2C19-419C-BC23-F8C69E623B17
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.dll

using System.IO;

#nullable disable
namespace MGASystems.Common;

public class FileReader
{
  public static byte[] ReadAllBytes(string path, FileAccess fileAccess = FileAccess.Read, FileShare shareMode = FileShare.ReadWrite)
  {
    using (FileStream fileStream = new FileStream(path, FileMode.Open, fileAccess, shareMode))
    {
      using (MemoryStream destination = new MemoryStream())
      {
        fileStream.CopyTo((Stream) destination);
        return destination.ToArray();
      }
    }
  }
}
