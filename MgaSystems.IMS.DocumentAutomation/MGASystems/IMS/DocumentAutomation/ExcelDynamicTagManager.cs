// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.DocumentAutomation.ExcelDynamicTagManager
// Assembly: MgaSystems.IMS.DocumentAutomation, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: B33F9A76-E654-4386-A032-7A12D7CD66DE
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.DocumentAutomation.dll

using MGASystems.IMS.DocumentAutomation.TemplateDocuments;
using System;
using System.Collections.Generic;

#nullable disable
namespace MGASystems.IMS.DocumentAutomation;

public class ExcelDynamicTagManager
{
  public virtual void GetAvailableTagList(dsTemplateDocs.TagsDataTable dt)
  {
  }

  public virtual List<DocTag> ProcessTags(
    List<DocTag> tags,
    object entityId,
    int placedByCompanyLineID,
    Guid quoteGuid)
  {
    return tags;
  }
}
