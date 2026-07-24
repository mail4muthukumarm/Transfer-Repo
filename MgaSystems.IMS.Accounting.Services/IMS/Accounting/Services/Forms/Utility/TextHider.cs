// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Services.Forms.Utility.TextHider
// Assembly: MgaSystems.IMS.Accounting.Services, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EEF87E2E-9738-4C33-AE03-5712A958CE99
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Services.dll

using System.Collections.Generic;
using System.Linq;
using System.Text;

#nullable disable
namespace MGASystems.IMS.Accounting.Services.Forms.Utility;

public class TextHider
{
  public int VisibleSuffixCharacters { get; set; }

  public char HideCharacter { get; set; } = '*';

  public char[] IgnoreCharacters { get; set; }

  public string HideText(string text)
  {
    if (text.Length <= this.VisibleSuffixCharacters)
      return text;
    if (this.IgnoreCharacters == null)
      this.IgnoreCharacters = new char[0];
    int num = text.Length - this.VisibleSuffixCharacters;
    StringBuilder stringBuilder = new StringBuilder();
    for (int index = 0; index < text.Length; ++index)
    {
      char ch = text[index];
      if (((IEnumerable<char>) this.IgnoreCharacters).Contains<char>(ch) || index >= num)
        stringBuilder.Append(ch);
      else
        stringBuilder.Append(this.HideCharacter);
    }
    return stringBuilder.ToString();
  }
}
