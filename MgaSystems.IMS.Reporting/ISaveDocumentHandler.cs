// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Reporting.ISaveDocumentHandler
// Assembly: MgaSystems.IMS.Reporting, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D0217E27-C87B-4FD0-8041-819EA70A118B
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Reporting.dll

using System;

#nullable disable
namespace MGASystems.IMS.Reporting;

public interface ISaveDocumentHandler
{
  ISaveDocumentHandler.ReportDocHandlerProperties DocHandlerProperties { get; }

  struct ReportDocHandlerProperties
  {
    public bool SaveToDocHandler;
    public Guid QuoteGUID;
    public string DocHandlerDescription;
    public int DocHandlerFolderID;
    public bool AskForDocHandlerFolderID;
    public bool ShowMessageBox;
    public string MessageText;
  }
}
