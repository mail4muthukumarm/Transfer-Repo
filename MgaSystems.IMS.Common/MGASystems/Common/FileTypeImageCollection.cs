// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.FileTypeImageCollection
// Assembly: MgaSystems.IMS.Common, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 46CE8D79-2C19-419C-BC23-F8C69E623B17
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.dll

using MGASystems.Common.NativeWindowMethods;
using Microsoft.VisualBasic.CompilerServices;
using System.Collections.Generic;
using System.Drawing;

#nullable disable
namespace MGASystems.Common;

public sealed class FileTypeImageCollection : List<FileTypeImageCollection.FileTypeImage>
{
  public Image FindImage(string fileExt)
  {
    int num = this.Count - 1;
    Image image;
    for (int index = 0; index <= num; ++index)
    {
      if (Operators.CompareString(this[index].FileExt, fileExt, false) == 0)
      {
        image = this[index].FileImage;
        goto label_6;
      }
    }
    this.Add(fileExt);
    image = this.FindImage(fileExt);
label_6:
    return image;
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
      Image bitmap = (Image) FileInfoEx.GetSmallIcon("test" + fileExt).ToBitmap();
      this.Add(new FileTypeImageCollection.FileTypeImage(fileExt, bitmap));
    }
    int num;
    return num;
  }

  public new FileTypeImageCollection.FileTypeImage this[int index] => base[index];

  public sealed class FileTypeImage
  {
    private string _fileExt;
    private Image _fileImage;

    public string FileExt => this._fileExt;

    public Image FileImage => this._fileImage;

    public FileTypeImage(string FileExt, Image fileImage)
    {
      this._fileExt = FileExt;
      this._fileImage = fileImage;
    }
  }
}
