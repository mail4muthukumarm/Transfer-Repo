// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Services.Forms.MVC.DataGridControl.View.UltragridViewAdapters.TextAlignmentExtensions
// Assembly: MgaSystems.IMS.Accounting.Services, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EEF87E2E-9738-4C33-AE03-5712A958CE99
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Services.dll

using Infragistics.Win;
using System;

#nullable disable
namespace MGASystems.IMS.Accounting.Services.Forms.MVC.DataGridControl.View.UltragridViewAdapters;

public static class TextAlignmentExtensions
{
  public static HAlign ToInfragisticsHAlign(this TextAlignment textAlignment)
  {
    switch (textAlignment)
    {
      case TextAlignment.Left:
        return (HAlign) 1;
      case TextAlignment.Center:
        return (HAlign) 2;
      case TextAlignment.Right:
        return (HAlign) 3;
      default:
        throw new InvalidOperationException($"Unknown {nameof (textAlignment)}: {textAlignment}");
    }
  }
}
