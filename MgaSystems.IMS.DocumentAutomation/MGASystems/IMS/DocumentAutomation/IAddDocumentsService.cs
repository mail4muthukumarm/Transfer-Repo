// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.DocumentAutomation.IAddDocumentsService
// Assembly: MgaSystems.IMS.DocumentAutomation, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: B33F9A76-E654-4386-A032-7A12D7CD66DE
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.DocumentAutomation.dll

using MGASystems.BusinessObjects;
using System;
using System.Collections.Generic;

#nullable disable
namespace MGASystems.IMS.DocumentAutomation;

public interface IAddDocumentsService
{
  void GetDocuments(Quote quote, List<Guid> newQuoteGuids, Action<List<Guid>> response);

  void GetAdditionalDocuments(
    Quote quote,
    List<Guid> newQuoteGuids,
    Action<AdditionalDocumentInfo> response);
}
