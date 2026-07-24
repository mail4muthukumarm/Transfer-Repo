// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Core.MessageBoxProperties
// Assembly: MgaSystems.IMS.Accounting.Core, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 923053EF-B70A-44B5-B8DA-B227263F4FD2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Core.dll

using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Core;

public class MessageBoxProperties
{
  public string Caption { get; set; }

  public string Message { get; set; }

  public MessageBoxButtons Button { get; set; }

  public MessageBoxIcon Icon { get; set; }
}
