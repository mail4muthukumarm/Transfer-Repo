// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Forms.EmailBlast.EmailAttachment
// Assembly: MgaSystems.IMS.Forms, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FB3F392E-40B6-486F-8F0B-A4A494A546D4
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Forms.dll

using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Forms.EmailBlast;

public sealed class EmailAttachment : ListViewItem
{
  private string _FullPath;

  public EmailAttachment(string FileName, string FullPath, int ImageIndex)
    : base(FileName)
  {
    this._FullPath = FullPath;
    this.ImageIndex = ImageIndex;
  }

  public string FullPath
  {
    get => this._FullPath;
    set => this._FullPath = value;
  }

  public string FileName
  {
    get => this.Text;
    set => this.Text = value;
  }
}
