// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.NoteDocuments.DocumentType
// Assembly: MgaSystems.IMS.NotesDocuments, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 3F898CF7-066D-4B05-A9F1-D37DBC4FAA16
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.NotesDocuments.dll

using MGASystems.Data;
using MGASystems.Data.Binding;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.NoteDocuments;

public abstract class DocumentType : BindingObject
{
  public Guid TypeGuid { get; set; }

  public string TypeName { get; set; }

  public bool SystemDefined { get; set; }

  public DocumentType(Guid _typeguid, string _typename, bool _systemDefined)
  {
    this.TypeGuid = _typeguid;
    this.TypeName = _typename;
    this.SystemDefined = _systemDefined;
  }

  public static DocumentType Allocate(Guid _typeguid, string _typename, bool _systemDefined)
  {
    return NotifyProxyTypeManager.Allocate<DocumentType>(new object[3]
    {
      (object) _typeguid,
      (object) _typename,
      (object) _systemDefined
    });
  }

  public static ObservableCollection<DocumentType> GetDocumentTypeList()
  {
    EnumerableRowCollection<DataRow> source = DefaultDatabase.ExecuteDataTable("DocumentSystem_FetchSelectableDocumentTypes").AsEnumerable();
    System.Func<DataRow, DocumentType> selector;
    // ISSUE: reference to a compiler-generated field
    if (DocumentType._Closure\u0024__.\u0024I14\u002D0 != null)
    {
      // ISSUE: reference to a compiler-generated field
      selector = DocumentType._Closure\u0024__.\u0024I14\u002D0;
    }
    else
    {
      // ISSUE: reference to a compiler-generated field
      DocumentType._Closure\u0024__.\u0024I14\u002D0 = selector = (System.Func<DataRow, DocumentType>) ([SpecialName] (row) => DocumentType.Allocate(row.Field<Guid>("TypeGuid"), row.Field<string>("TypeName"), row.Field<bool>("SystemDefined")));
    }
    return new ObservableCollection<DocumentType>((IEnumerable<DocumentType>) source.Select<DataRow, DocumentType>(selector));
  }

  public static void DeleteDocumentType(Guid _typeGuid)
  {
    DefaultDatabase.ExecuteNonQuery(CommandType.Text, "DELETE FROM tblDocumentTypes WHERE TypeGuid = @TypeGuid", new object[2]
    {
      (object) "@TypeGuid",
      (object) _typeGuid
    });
  }

  public static void SaveDocumentType(Guid _typeGuid, string _typeName)
  {
    if (_typeGuid == Guid.Empty)
      DefaultDatabase.ExecuteNonQuery(CommandType.Text, "INSERT INTO tblDocumentTypes (TypeGuid, TypeName, SystemDefined) VALUES (@TypeGuid, @TypeName, @SystemDefined)", new object[6]
      {
        (object) "@TypeGuid",
        (object) Guid.NewGuid(),
        (object) "@TypeName",
        (object) _typeName,
        (object) "@SystemDefined",
        (object) false
      });
    else
      DefaultDatabase.ExecuteNonQuery(CommandType.Text, "UPDATE tblDocumentTypes SET TypeName = @TypeName WHERE TypeGuid = @TypeGuid", new object[4]
      {
        (object) "@TypeGuid",
        (object) _typeGuid,
        (object) "@TypeName",
        (object) _typeName
      });
  }
}
