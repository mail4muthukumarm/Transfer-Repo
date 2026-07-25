// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.FixedUltraGrid
// Assembly: MgaSystems.IMS.Policies, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 2FF2C709-F7BF-41DA-82BD-FF6319CA235D
// Assembly location: C:\Users\muthu\Downloads\MgaSystems.IMS.Policies.dll

using Infragistics.Win;
using Infragistics.Win.UltraWinGrid;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Policies;

public sealed class FixedUltraGrid : UltraGrid
{
  protected virtual void OnPaint(PaintEventArgs pe)
  {
    try
    {
      base.OnPaint(pe);
    }
    catch (NullReferenceException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      ((UltraControlBase) this).Invalidate();
      ProjectData.ClearProjectError();
    }
  }
}
