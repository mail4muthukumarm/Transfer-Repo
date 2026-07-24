// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.NoteDocuments.DocumentFilterType
// Assembly: MgaSystems.IMS.NotesDocuments, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 3F898CF7-066D-4B05-A9F1-D37DBC4FAA16
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.NotesDocuments.dll

using MGASystems.Common;
using System;
using System.Collections.Generic;

#nullable disable
namespace MGASystems.IMS.NoteDocuments;

public class DocumentFilterType
{
  public static Dictionary<string, List<string>> GetDocumentFilterTypeList()
  {
    Dictionary<string, List<string>> documentFilterTypeList = new Dictionary<string, List<string>>();
    Type[] typeArray = ObjectFactory.Instance.QueryTypesWithAttribute((Attribute) new DocumentFolderFilterAttribute());
    int index = 0;
    while (index < typeArray.Length)
    {
      Type t = typeArray[index];
      object[] customAttributes = t.GetCustomAttributes(typeof (DocumentFolderFilterAttribute), false);
      if (customAttributes.Length == 1)
      {
        DocumentFilterType.DocumentTypeListItem documentTypeListItem = new DocumentFilterType.DocumentTypeListItem(((DocumentFolderFilterAttribute) customAttributes[0]).Name, t);
        if (documentFilterTypeList.ContainsKey(documentTypeListItem.Name))
        {
          List<string> stringList = new List<string>();
          if (documentFilterTypeList.TryGetValue(documentTypeListItem.Name, out stringList))
            stringList.Add(documentTypeListItem.TypeName);
        }
        else
          documentFilterTypeList.Add(documentTypeListItem.Name, new List<string>()
          {
            documentTypeListItem.TypeName
          });
      }
      checked { ++index; }
    }
    return documentFilterTypeList;
  }

  private class DocumentTypeListItem
  {
    public string Name { get; }

    public string TypeName { get; }

    public DocumentTypeListItem(string _name, Type t)
    {
      this.Name = _name;
      this.TypeName = t.FullName;
    }

    public override string ToString() => this.Name;
  }
}
