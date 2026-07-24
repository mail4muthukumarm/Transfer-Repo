// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.NoteDocuments.DocuSign.DocuSignUtil
// Assembly: MgaSystems.IMS.NotesDocuments, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 3F898CF7-066D-4B05-A9F1-D37DBC4FAA16
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.NotesDocuments.dll

using MGASystems.Common.FileIO;
using MGASystems.IMS.DocumentStorage;
using MGASystems.IMS.NoteDocuments.DocumentSystem;
using MGASystems.Tools;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.IO;

#nullable disable
namespace MGASystems.IMS.NoteDocuments.DocuSign;

[StandardModule]
public sealed class DocuSignUtil
{
  public static List<string> SupportedTypes = new List<string>()
  {
    ".doc",
    ".docm",
    ".docx",
    ".dot",
    ".dotm",
    ".dotx",
    ".htm",
    ".html",
    ".msg",
    ".pdf",
    ".rtf",
    ".txt",
    ".wpd",
    ".xps",
    ".bmp",
    ".gif",
    ".jpg",
    ".jpeg",
    ".png",
    ".tif",
    ".tiff",
    ".pot",
    ".potx",
    ".pps",
    ".ppt",
    ".pptm",
    ".pptx",
    ".csv",
    ".xls",
    ".xlsm",
    ".xlsx"
  };
  private static ZipUtility ZipUtility1 = new ZipUtility();

  public static bool IsSupportedFileType(string ext) => DocuSignUtil.SupportedTypes.Contains(ext);

  public static string SaveDocumentToDisk(Guid documentGuid, string savetodirectory)
  {
    Metadata documentMetadata = DocumentManager.GetDocumentMetadata(documentGuid);
    byte[] documentBinary = DocumentManager.GetDocumentBinary(documentGuid);
    string path = FilePath.Resolve(savetodirectory, documentMetadata.FileName);
    string str = Path.Combine(savetodirectory, $"{documentMetadata.DocumentStoreGuid}.zip");
    string disk;
    if (documentMetadata.Compressed)
    {
      using (FileStream fileStream = new FileStream(str, FileMode.Create))
      {
        fileStream.Write(documentBinary, 0, documentBinary.Length);
        fileStream.Close();
      }
      DocuSignUtil.ZipUtility1.ExtractFilesFromZipArchive(str, savetodirectory);
      File.Delete(str);
    }
    else
    {
      try
      {
        using (FileStream fileStream = new FileStream(path, FileMode.Create))
        {
          fileStream.Write(documentBinary, 0, documentBinary.Length);
          fileStream.Close();
        }
      }
      catch (IOException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        disk = "This item is already open.  Cannot open two instances of the same document.";
        ProjectData.ClearProjectError();
        goto label_14;
      }
    }
    disk = "";
label_14:
    return disk;
  }
}
