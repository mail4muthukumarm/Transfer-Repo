// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Services.DocumentHandlerAdder
// Assembly: MgaSystems.IMS.Accounting.Services, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EEF87E2E-9738-4C33-AE03-5712A958CE99
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Services.dll

using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.Export.Pdf.Section;
using MGASystems.BusinessObjects;
using MGASystems.Common;
using MGASystems.IMS.NoteDocuments;
using MGASystems.IMS.NoteDocuments.DocumentSystem;
using System.IO;

#nullable disable
namespace MGASystems.IMS.Accounting.Services;

public class DocumentHandlerAdder
{
  public virtual void AddDocument(int quoteId, SectionReport report, bool runThreaded)
  {
    this.AddDocumentHelper(quoteId, $"Policy_Reinstatement_{quoteId}", report, runThreaded);
  }

  public void AddDocumentHelper(
    int quoteId,
    string documentName,
    SectionReport report,
    bool runThreaded)
  {
    using (PdfExport pdfExport = new PdfExport())
    {
      string path = $"{MGATempFolder.MGATempPath}{documentName}.pdf";
      pdfExport.Export(report.Document, path);
      DocumentManager.BeginFileAddWithBind((DocumentManager.FileAddedAndBound) null, path, -1, documentName, (ISupportDocumentSystem) new Quote(quoteId), true, string.Empty, runThreaded);
      if (runThreaded)
        return;
      File.Delete(path);
    }
  }
}
