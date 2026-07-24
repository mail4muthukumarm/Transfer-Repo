// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.FileTypeIconCollection
// Assembly: MgaSystems.IMS.Common, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 46CE8D79-2C19-419C-BC23-F8C69E623B17
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.dll

using MGASystems.Common.NativeWindowMethods;
using Microsoft.VisualBasic.CompilerServices;
using System.Collections.Generic;
using System.Drawing;

#nullable disable
namespace MGASystems.Common;

public sealed class FileTypeIconCollection : List<FileTypeIconCollection.FileTypeIcon>
{
  public Icon FindIcon(string fileExt)
  {
    int num = this.Count - 1;
    Icon icon;
    for (int index = 0; index <= num; ++index)
    {
      if (Operators.CompareString(this[index].FileExt, fileExt, false) == 0)
      {
        icon = this[index].FileIcon;
        goto label_6;
      }
    }
    this.Add(fileExt);
    icon = this.FindIcon(fileExt);
label_6:
    return icon;
  }

  private bool IsExtInCollection(string fileExt)
  {
    int num = this.Count - 1;
    bool flag;
    for (int index = 0; index <= num; ++index)
    {
      if (Operators.CompareString(this[index].FileExt, fileExt, false) == 0)
      {
        flag = true;
        goto label_6;
      }
    }
    flag = false;
label_6:
    return flag;
  }

  private int Add(string fileExt)
  {
    if (!this.IsExtInCollection(fileExt))
    {
      Icon smallIcon = FileInfoEx.GetSmallIcon("test" + fileExt);
      this.Add(new FileTypeIconCollection.FileTypeIcon(fileExt, smallIcon));
    }
    int num;
    return num;
  }

  public new FileTypeIconCollection.FileTypeIcon this[int index] => base[index];

  public sealed class FileTypeIcon
  {
    private string _fileExt;
    private Icon _fileIcon;

    public string FileExt => this._fileExt;

    public Icon FileIcon => this._fileIcon;

    public FileTypeIcon(string FileExt, Icon fileIcon)
    {
      this._fileExt = FileExt;
      this._fileIcon = fileIcon;
    }
  }
}
