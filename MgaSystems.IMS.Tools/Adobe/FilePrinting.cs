// Decompiled with JetBrains decompiler
// Type: MGASystems.Tools.Adobe.FilePrinting
// Assembly: MgaSystems.IMS.Tools, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 1287D1AD-C908-42E9-BE8F-4574B2D0AB9E
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Tools.dll

using MGASystems.AsposeFacade.PDF;
using Microsoft.VisualBasic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.IO;

#nullable disable
namespace MGASystems.Tools.Adobe;

public sealed class FilePrinting
{
  [SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
  public void PrintDoc(string filename, ISynchronizeInvoke synchronizer)
  {
    FilePrinting.ShellAdobePrint(filename, synchronizer);
  }

  [SuppressMessage("Microsoft.Security", "CA2122:DoNotIndirectlyExposeMethodsWithLinkDemands")]
  private static bool ShellAdobePrint(string adobeFile, ISynchronizeInvoke synchronizer)
  {
    if (File.Exists(adobeFile))
    {
      PDFViewer pdfViewer = new PDFViewer();
      bool flag = false;
      try
      {
        pdfViewer.OpenPdfFile(adobeFile);
        flag = true;
        pdfViewer.PrintDocument();
      }
      finally
      {
        if (pdfViewer != null && flag)
          pdfViewer.ClosePdfFile();
      }
    }
    bool flag1;
    return flag1;
  }

  private static bool PrintViaActiveX(string adobeFile)
  {
    Interaction.Shell(adobeFile + " FilePrintSilent", AppWinStyle.Hide, true);
    return false;
  }
}
