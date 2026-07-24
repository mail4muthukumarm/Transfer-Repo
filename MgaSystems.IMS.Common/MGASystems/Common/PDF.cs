// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.PDF
// Assembly: MgaSystems.IMS.Common, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 46CE8D79-2C19-419C-BC23-F8C69E623B17
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.dll

using MGASystems.AsposeFacade.Words;
using MGASystems.IMS.Logging;
using MGASystems.IMS.Logging.Administration;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.IO;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.Common;

[StandardModule]
[LogCategory("Aspose.PDF.Conversion", "Aspose.PDF.Conversion")]
public sealed class PDF
{
  internal const string AsposePDFConversionLogKey = "Aspose.PDF.Conversion";

  public static void LogAsposePDFAction(string source, string message)
  {
    if (!PDF.IsLogEnabled("Aspose.PDF.Conversion"))
      return;
    Log.Write($"{source}: {message}", "Aspose.PDF.Conversion");
  }

  private static void LogAsposePDFAction(string message)
  {
    PDF.LogAsposePDFAction("MGASystems.Common.PDF.ConvertWordDocToPDF", message);
  }

  private static bool IsLogEnabled(string logKey)
  {
    LogDestination logDestination;
    return Log.LogCategoryDestinations != null && Log.LogCategoryDestinations.TryGetValue(logKey, out logDestination) && logDestination != LogDestination.Disabled;
  }

  public static string ConvertWordDocToPDF(string wordDocFileName)
  {
    Document document;
    string pdf;
    try
    {
      PDF.LogAsposePDFAction($"Creating Aspose.Words.Document object for {wordDocFileName}");
      document = new Document(wordDocFileName);
      PDF.LogAsposePDFAction("Created Aspose.Words.Document object");
    }
    catch (IOException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      MGASystems.Common.ThreadingFunctions.MessageBox.Show($"The IMS was unable to convert the following file to PDF, because it is being used by another process:\n\n{wordDocFileName}\n\nPlease make sure that this document is not currently open in another application.", "Document In Use", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      pdf = string.Empty;
      ProjectData.ClearProjectError();
      goto label_6;
    }
    catch (InvalidOperationException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      if (ex.Message.IndexOf("Cannot find stream 'WordDocument' in the storage") != -1)
      {
        MGASystems.Common.ThreadingFunctions.MessageBox.Show($"The IMS was unable to convert the following file to PDF, because it may be a MS Works file type or another type other than MS Word:\n\n{wordDocFileName}\n\nPlease make sure that this document is of MS Word file type.", "Different Document File Type", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        pdf = string.Empty;
        ProjectData.ClearProjectError();
        goto label_6;
      }
      throw;
    }
    string oldValue = Path.GetExtension(wordDocFileName);
    string str = wordDocFileName.Replace(oldValue, ".pdf");
    Compatibility.SaveToPDF(document, str);
    pdf = str;
label_6:
    return pdf;
  }
}
