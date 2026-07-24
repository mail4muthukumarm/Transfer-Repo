// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.Functions.Imaging
// Assembly: MgaSystems.IMS.Common, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 46CE8D79-2C19-419C-BC23-F8C69E623B17
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.dll

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.Common.Functions;

[StandardModule]
public sealed class Imaging
{
  public static Bitmap MakeTransparent(Bitmap bitmap, Color maskColor)
  {
    if (bitmap == null)
      throw new ArgumentNullException(nameof (bitmap));
    bitmap.MakeTransparent(maskColor);
    return bitmap;
  }

  public static Bitmap MakeTransparent(Bitmap bitmap)
  {
    return bitmap != null ? Imaging.MakeTransparent(bitmap, bitmap.GetPixel(0, 0)) : throw new ArgumentNullException(nameof (bitmap));
  }

  public static Image MakeTransparent(Image Image, Color maskColor)
  {
    return !(Image is Bitmap bitmap) ? Image : (Image) Imaging.MakeTransparent(bitmap, maskColor);
  }

  public static Image MakeTransparent(Image Image)
  {
    return !(Image is Bitmap bitmap) ? Image : (Image) Imaging.MakeTransparent(bitmap);
  }

  public static void MakeTransparent(Button btn)
  {
    if (btn == null)
      throw new ArgumentNullException(nameof (btn));
    if (btn.Image is Bitmap image1)
    {
      btn.Image = (Image) Imaging.MakeTransparent(image1);
    }
    else
    {
      Image image = btn.Image;
      if (image == null)
        return;
      btn.Image = Imaging.MakeTransparent(image);
    }
  }

  public static void MakeFormButtonsTransparent(Form form)
  {
    if (form == null)
      throw new ArgumentNullException(nameof (form));
    try
    {
      foreach (Control control in form.Controls)
      {
        if (control is Button btn)
          Imaging.MakeTransparent(btn);
        if (form.Controls.Count > 0)
          Imaging.MakeControlButtonsTransparent(control);
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  public static void MakeControlButtonsTransparent(Control control)
  {
    if (control == null)
      throw new ArgumentNullException(nameof (control));
    try
    {
      foreach (Control control1 in control.Controls)
      {
        if (control1 is Button btn)
          Imaging.MakeTransparent(btn);
        if (control1.Controls.Count > 0)
          Imaging.MakeControlButtonsTransparent(control1);
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  public static Image BytesToImage(byte[] bytes)
  {
    Bitmap image = (Bitmap) null;
    if (bytes.Length > 0)
    {
      MemoryStream memoryStream = new MemoryStream(bytes);
      Image original = Image.FromStream((Stream) memoryStream);
      image = new Bitmap(original, original.Width, original.Height);
      memoryStream.Close();
    }
    return (Image) image;
  }
}
