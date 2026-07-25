// Decompiled with JetBrains decompiler
// Type: MGASystems.ExtendedEditors.DragDrop.ByteData
// Assembly: MgaSystems.IMS.Editors, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 28F8E80A-3F85-4456-A3F6-E45DC46DD2C0
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Editors.dll

#nullable disable
namespace MGASystems.ExtendedEditors.DragDrop;

public sealed class ByteData
{
  private string fileName;
  private byte[] bytes;

  public ByteData(string fileName, byte[] bytes)
  {
    this.fileName = fileName;
    this.bytes = bytes;
  }

  public string FileName => this.fileName;

  public byte[] GetBytes() => this.bytes;
}
