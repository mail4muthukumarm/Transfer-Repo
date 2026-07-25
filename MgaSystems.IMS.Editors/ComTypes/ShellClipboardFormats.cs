// Decompiled with JetBrains decompiler
// Type: MGASystems.ExtendedEditors.ComTypes.ShellClipboardFormats
// Assembly: MgaSystems.IMS.Editors, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 28F8E80A-3F85-4456-A3F6-E45DC46DD2C0
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Editors.dll

using System.Windows.Forms;

#nullable disable
namespace MGASystems.ExtendedEditors.ComTypes;

internal static class ShellClipboardFormats
{
  public static DataFormats.Format CFSTR_FILEDESCRIPTORA
  {
    get => DataFormats.GetFormat("FileGroupDescriptor");
  }

  public static DataFormats.Format CFSTR_FILEDESCRIPTORW
  {
    get => DataFormats.GetFormat("FileGroupDescriptorW");
  }

  public static DataFormats.Format CFSTR_FILECONTENTS => DataFormats.GetFormat("FileContents");

  public static DataFormats.Format CFSTR_FILENAMEW => DataFormats.GetFormat("FileNameW");
}
