// Decompiled with JetBrains decompiler
// Type: MGASystems.ExtendedEditors.RichText.RichTextConverter
// Assembly: MgaSystems.IMS.Editors, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 28F8E80A-3F85-4456-A3F6-E45DC46DD2C0
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Editors.dll

using System;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.ExtendedEditors.RichText;

public static class RichTextConverter
{
  public static Image ToImage(string rtfText, int width)
  {
    using (PrintableRichTextBox printableRichTextBox = new PrintableRichTextBox())
    {
      printableRichTextBox.Width = width;
      printableRichTextBox.Rtf = rtfText;
      return printableRichTextBox.ToImage();
    }
  }

  public static Image ToImage(RichTextBox richTextBox)
  {
    if (richTextBox == null)
      throw new ArgumentNullException(nameof (richTextBox));
    return RichTextConverter.ToImage(richTextBox.Rtf, richTextBox.Width);
  }
}
