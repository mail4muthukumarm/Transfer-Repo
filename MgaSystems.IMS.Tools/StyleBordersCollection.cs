// Decompiled with JetBrains decompiler
// Type: MGASystems.Tools.StyleBordersCollection
// Assembly: MgaSystems.IMS.Tools, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 1287D1AD-C908-42E9-BE8F-4574B2D0AB9E
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Tools.dll

using MGASystems.AsposeFacade.Cells;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;

#nullable disable
namespace MGASystems.Tools;

[Serializable]
public class StyleBordersCollection : List<StyleBorder>
{
  public StyleBordersCollection()
  {
  }

  public StyleBordersCollection(Style stl)
  {
    try
    {
      foreach (object obj in Enum.GetValues(typeof (BorderType)))
      {
        BorderType integer = (BorderType) Conversions.ToInteger(obj);
        this.Add(new StyleBorder(stl, integer));
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  public StyleBorder GetStyleBorder(string BorderType)
  {
    StyleBorder styleBorder1 = new StyleBorder();
    try
    {
      foreach (StyleBorder styleBorder2 in (List<StyleBorder>) this)
      {
        if (Operators.CompareString(styleBorder2.BorderType, BorderType, false) == 0)
          styleBorder1 = styleBorder2;
      }
    }
    finally
    {
      List<StyleBorder>.Enumerator enumerator;
      enumerator.Dispose();
    }
    return styleBorder1;
  }
}
