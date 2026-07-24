// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Controls.GLAccountSelectedEventArgs
// Assembly: MgaSystems.IMS.Accounting.Controls, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 69E8E7CF-F3E0-45A9-94CD-B8A0D33430C8
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Accounting.Controls.dll

using System;

#nullable disable
namespace MGASystems.IMS.Accounting.Controls;

public class GLAccountSelectedEventArgs : EventArgs
{
  public int GLAccountID;
  public string FullName;
  public string ShortName;

  public GLAccountSelectedEventArgs(int glAccountID, string fullName, string shortName)
  {
    this.GLAccountID = glAccountID;
    this.FullName = fullName;
    this.ShortName = shortName;
  }
}
