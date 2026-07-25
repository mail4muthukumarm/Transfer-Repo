// Decompiled with JetBrains decompiler
// Type: MGASystems.ExtendedEditors.RichText.PrintableRichTextBox
// Assembly: MgaSystems.IMS.Editors, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 28F8E80A-3F85-4456-A3F6-E45DC46DD2C0
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Editors.dll

using MGASystems.ExtendedEditors.ComTypes;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.ExtendedEditors.RichText;

internal class PrintableRichTextBox : RichTextBox
{
  private Size contentSize;
  private const double twip = 14.4;

  protected override void OnContentsResized(ContentsResizedEventArgs e)
  {
    base.OnContentsResized(e);
    this.contentSize = e.NewRectangle.Size;
  }

  public Image ToImage()
  {
    Image image = (Image) new Bitmap(this.contentSize.Width + 30, this.contentSize.Height);
    using (Graphics gr = Graphics.FromImage(image))
      PrintableRichTextBox.PrintToGraphics(0, this.Text.Length, gr, new Rectangle(this.Location, new Size(this.contentSize.Width + 30, this.contentSize.Height)), (RichTextBox) this);
    return image;
  }

  private static int PrintToGraphics(
    int charFrom,
    int charTo,
    Graphics gr,
    Rectangle bounds,
    RichTextBox richTextBox)
  {
    RECT rect = new RECT(bounds.Size);
    rect.Inflate(14.4);
    new RECT(gr.ClipBounds.Size.ToSize()).Inflate(14.4);
    IntPtr num1 = IntPtr.Zero;
    try
    {
      num1 = gr.GetHdc();
      FORMATRANGE structure = new FORMATRANGE(num1, num1, rect, rect, new CHARRANGE(charFrom, charTo));
      IntPtr num2 = IntPtr.Zero;
      IntPtr num3 = IntPtr.Zero;
      try
      {
        num3 = Marshal.AllocCoTaskMem(Marshal.SizeOf<FORMATRANGE>(structure));
        Marshal.StructureToPtr<FORMATRANGE>(structure, num3, false);
        num2 = UnsafeNativeMethods.SendMessage(new HandleRef((object) richTextBox, richTextBox.Handle), 1081, 1, num3);
      }
      finally
      {
        if (!num3.Equals((object) IntPtr.Zero))
          Marshal.FreeCoTaskMem(num3);
      }
      return num2.ToInt32();
    }
    finally
    {
      if (!num1.Equals((object) IntPtr.Zero))
        gr.ReleaseHdc(num1);
    }
  }
}
