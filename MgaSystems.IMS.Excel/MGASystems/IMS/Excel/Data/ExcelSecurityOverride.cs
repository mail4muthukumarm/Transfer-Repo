// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Excel.Data.ExcelSecurityOverride
// Assembly: MgaSystems.IMS.Excel, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D783CE96-8BF7-4BCA-9997-5F16C01589C2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Excel.dll

using MGASystems.IMS.Excel.Rating;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Excel.Data;

public class ExcelSecurityOverride
{
  public virtual bool CanSaveSheetOnBoundQuote(ExcelRater excelRater)
  {
    if (Security.CanSaveSheetOnBoundQuote(excelRater.RaterID) || !excelRater.Quote.IsBound)
      return true;
    int num = (int) MessageBox.Show("Changes made to a spreadsheet on a bound quote cannot be saved back into the IMS.", "Unable to save to IMS", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    return false;
  }
}
