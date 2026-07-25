// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.DocumentAutomation.TemplateDocuments.ISupportTemplateDocs
// Assembly: MgaSystems.IMS.DocumentAutomation, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: B33F9A76-E654-4386-A032-7A12D7CD66DE
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.DocumentAutomation.dll

using System.Collections.Generic;

#nullable disable
namespace MGASystems.IMS.DocumentAutomation.TemplateDocuments;

public interface ISupportTemplateDocs
{
  List<int> SupportedTemplateGroupIDs { get; }

  object[] TagParserConstructorArgs(int automationDocGroupID);
}
