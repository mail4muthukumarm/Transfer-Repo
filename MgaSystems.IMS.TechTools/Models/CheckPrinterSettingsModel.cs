// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.TechTools.Models.CheckPrinterSettingsModel
// Assembly: MgaSystems.IMS.TechTools, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8FAAE26D-FF0E-4A40-9C29-0BA1B9D1C7D2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.TechTools.dll

using MGASystems.Data.DataMapping;
using System.Data;

#nullable disable
namespace MgaSystems.IMS.TechTools.Models;

[TableMapping("tblFin_AccountingPrinters")]
public class CheckPrinterSettingsModel
{
  [TableFieldMapping("PrinterId")]
  public int PrinterId { get; set; }

  [TableFieldMapping("PrinterFriendlyName")]
  public string PrinterFriendlyName { get; set; }

  [TableFieldMapping("CPN")]
  public string CheckPrinterName { get; set; }

  [TableFieldMapping("CPS")]
  public string CheckPrinterSettings { get; set; }

  [TableFieldMapping("CDPN")]
  public string CheckDetailName { get; set; }

  [TableFieldMapping("CDPS")]
  public string CheckDetailSettings { get; set; }

  public CheckPrinterSettingsModel(
    int printerId,
    string printerFriendlyName,
    string checkPrinterName,
    string checkPrinterSettings,
    string checkDetailName,
    string checkDetailSettings)
  {
    this.PrinterId = printerId;
    this.PrinterFriendlyName = printerFriendlyName;
    this.CheckPrinterName = checkPrinterName;
    this.CheckPrinterSettings = checkPrinterSettings;
    this.CheckDetailName = checkDetailName;
    this.CheckDetailSettings = checkDetailSettings;
  }

  public static CheckPrinterSettingsModel Create(DataRow dr)
  {
    return new CheckPrinterSettingsModel(dr.Field<int>("PrinterId"), dr.Field<string>("PrinterFriendlyName"), dr.Field<string>("CPN"), dr.Field<string>("CPS"), dr.Field<string>("CDPN"), dr.Field<string>("CDPS"));
  }
}
