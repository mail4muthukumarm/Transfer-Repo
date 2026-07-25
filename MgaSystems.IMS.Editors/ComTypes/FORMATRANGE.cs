// Decompiled with JetBrains decompiler
// Type: MGASystems.ExtendedEditors.ComTypes.FORMATRANGE
// Assembly: MgaSystems.IMS.Editors, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 28F8E80A-3F85-4456-A3F6-E45DC46DD2C0
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Editors.dll

using System;

#nullable disable
namespace MGASystems.ExtendedEditors.ComTypes;

internal struct FORMATRANGE(IntPtr hdc, IntPtr hdcTarget, RECT rc, RECT rcPage, CHARRANGE chrg)
{
  public IntPtr hdc = hdc;
  public IntPtr hdcTarget = hdcTarget;
  public RECT rc = rc;
  public RECT rcPage = rcPage;
  public CHARRANGE chrg = chrg;
}
