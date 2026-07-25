// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.TechTools.SharedModel.DocumentAutomationGroup
// Assembly: MgaSystems.IMS.TechTools, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8FAAE26D-FF0E-4A40-9C29-0BA1B9D1C7D2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.TechTools.dll

using MGASystems.Data;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;

#nullable disable
namespace MgaSystems.IMS.TechTools.SharedModel;

public class DocumentAutomationGroup
{
  public byte ID { get; set; }

  public string TemplateGroup { get; set; }

  public static ObservableCollection<DocumentAutomationGroup> GetDocumentAutomationGroups()
  {
    return new ObservableCollection<DocumentAutomationGroup>((IEnumerable<DocumentAutomationGroup>) DefaultDatabase.ExecuteDataTable(CommandType.StoredProcedure, "dbo.spGetAutomationGroups").AsEnumerable().Select<DataRow, DocumentAutomationGroup>((System.Func<DataRow, DocumentAutomationGroup>) (row => new DocumentAutomationGroup()
    {
      ID = row.Field<byte>("ID"),
      TemplateGroup = row.Field<string>("TemplateGroup")
    })));
  }
}
