// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.DocumentAutomation.PDFPackage
// Assembly: MgaSystems.IMS.DocumentAutomation, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: B33F9A76-E654-4386-A032-7A12D7CD66DE
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.DocumentAutomation.dll

using MGASystems.AsposeFacade.PDF;
using System;
using System.Collections.Generic;
using System.IO;

#nullable disable
namespace MGASystems.IMS.DocumentAutomation;

public sealed class PDFPackage
{
  private List<MemoryStream> _pdfStreams;
  private List<string> _brokenOutFileNames;
  private byte[] _resultBytes;

  public PDFPackage()
  {
    this._pdfStreams = new List<MemoryStream>();
    this._brokenOutFileNames = new List<string>();
  }

  public List<string> BrokenOutFileNames => this._brokenOutFileNames;

  public List<MemoryStream> PdfStreams => this._pdfStreams;

  public byte[] ResultBytes => this._resultBytes;

  public event PDFPackage.PDFMergeCompleteEventHandler PDFMergeComplete;

  public void AddPDF(MemoryStream stream) => this._pdfStreams.Add(stream);

  public void AddBrokenOutFileNames(string name) => this._brokenOutFileNames.Add(name);

  public bool CreatePackage(string outputFilename)
  {
    PdfFileEditor pdfFileEditor = new PdfFileEditor();
    bool package;
    using (MemoryStream memoryStream1 = new MemoryStream())
    {
      bool flag = true;
      if (this._pdfStreams.Count > 1)
        flag = pdfFileEditor.Concatenate((Stream[]) this.PdfStreams.ToArray(), (Stream) memoryStream1);
      // ISSUE: reference to a compiler-generated field
      PDFPackage.PDFMergeCompleteEventHandler mergeCompleteEvent = this.PDFMergeCompleteEvent;
      if (mergeCompleteEvent != null)
        mergeCompleteEvent((object) this, EventArgs.Empty);
      if (!flag)
      {
        package = false;
        goto label_21;
      }
      PdfContentEditor pdfContentEditor = new PdfContentEditor();
      pdfContentEditor.BindPdf((Stream) memoryStream1);
      pdfContentEditor.RemoveDocumentOpenAction();
      using (MemoryStream memoryStream2 = new MemoryStream())
      {
        pdfContentEditor.Save((Stream) memoryStream2);
        using (FileStream fileStream = new FileStream(outputFilename, FileMode.Create))
          fileStream.Write(memoryStream2.GetBuffer(), 0, (int) memoryStream2.Length);
        this._resultBytes = memoryStream2.ToArray();
      }
    }
    package = true;
label_21:
    return package;
  }

  public void DoCleanup()
  {
    try
    {
      foreach (MemoryStream pdfStream in this.PdfStreams)
      {
        pdfStream.Close();
        pdfStream.Dispose();
      }
    }
    finally
    {
      List<MemoryStream>.Enumerator enumerator;
      enumerator.Dispose();
    }
  }

  public delegate void PDFMergeCompleteEventHandler(object sender, EventArgs e);
}
