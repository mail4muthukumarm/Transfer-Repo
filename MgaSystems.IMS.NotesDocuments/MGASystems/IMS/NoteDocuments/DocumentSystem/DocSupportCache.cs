// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.NoteDocuments.DocumentSystem.DocSupportCache
// Assembly: MgaSystems.IMS.NotesDocuments, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 3F898CF7-066D-4B05-A9F1-D37DBC4FAA16
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.NotesDocuments.dll

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Xml.Linq;

#nullable disable
namespace MGASystems.IMS.NoteDocuments.DocumentSystem;

public class DocSupportCache : ISupportDocumentSystem
{
  private Guid _entityGUID;

  public static DocSupportCache FromString(string docSupportXml)
  {
    DocSupportCache docSupportCache;
    try
    {
      XElement xelement = XElement.Parse(docSupportXml);
      docSupportCache = new DocSupportCache(Conversions.ToBoolean(xelement.Attribute((XName) "AllowAddNewDocument").Value), Conversions.ToBoolean(xelement.Attribute((XName) "CanReCreateEntity").Value), new Guid(xelement.Attribute((XName) "EntityGUID").Value), xelement.Attribute((XName) "EntityName").Value, xelement.Attribute((XName) "FriendlyEntityName").Value, xelement.Attribute((XName) "RecreateTypeName").Value, Conversions.ToBoolean(xelement.Attribute((XName) "HasControlGuid").Value), new Guid(xelement.Attribute((XName) "ControlGuid").Value));
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      docSupportCache = (DocSupportCache) null;
      ProjectData.ClearProjectError();
    }
    return docSupportCache;
  }

  public override string ToString()
  {
    string str;
    try
    {
      XElement xelement = new XElement(XName.Get(nameof (DocSupportCache), ""));
      // ISSUE: reference to a compiler-generated method
      xelement.Add((object) MGASystems.IMS.NoteDocuments.My.InternalXmlHelper.CreateAttribute(XName.Get("AllowAddNewDocument", ""), (object) this.AllowAddNewDocument.ToString()));
      // ISSUE: reference to a compiler-generated method
      xelement.Add((object) MGASystems.IMS.NoteDocuments.My.InternalXmlHelper.CreateAttribute(XName.Get("CanReCreateEntity", ""), (object) this.CanReCreateEntity.ToString()));
      // ISSUE: reference to a compiler-generated method
      xelement.Add((object) MGASystems.IMS.NoteDocuments.My.InternalXmlHelper.CreateAttribute(XName.Get("EntityGUID", ""), (object) this.EntityGUID.ToString()));
      // ISSUE: reference to a compiler-generated method
      xelement.Add((object) MGASystems.IMS.NoteDocuments.My.InternalXmlHelper.CreateAttribute(XName.Get("EntityName", ""), (object) this.EntityName));
      // ISSUE: reference to a compiler-generated method
      xelement.Add((object) MGASystems.IMS.NoteDocuments.My.InternalXmlHelper.CreateAttribute(XName.Get("FriendlyEntityName", ""), (object) this.FriendlyEntityName));
      // ISSUE: reference to a compiler-generated method
      xelement.Add((object) MGASystems.IMS.NoteDocuments.My.InternalXmlHelper.CreateAttribute(XName.Get("RecreateTypeName", ""), (object) this.RecreateTypeName));
      // ISSUE: reference to a compiler-generated method
      xelement.Add((object) MGASystems.IMS.NoteDocuments.My.InternalXmlHelper.CreateAttribute(XName.Get("HasControlGuid", ""), (object) this.HasControlGUID.ToString()));
      // ISSUE: reference to a compiler-generated method
      xelement.Add((object) MGASystems.IMS.NoteDocuments.My.InternalXmlHelper.CreateAttribute(XName.Get("ControlGuid", ""), this.HasControlGUID ? (object) this.ControlGUID.ToString() : (object) Guid.Empty.ToString()));
      str = xelement.ToString();
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      str = "";
      ProjectData.ClearProjectError();
    }
    return str;
  }

  public DocSupportCache(ISupportDocumentSystem docSupport)
  {
    ISupportDocumentSystem supportDocumentSystem = docSupport;
    this.AllowAddNewDocument = supportDocumentSystem.AllowAddNewDocument;
    this.CanReCreateEntity = supportDocumentSystem.CanReCreateEntity;
    this._entityGUID = supportDocumentSystem.EntityGuid;
    this.EntityName = supportDocumentSystem.EntityName;
    this.FriendlyEntityName = supportDocumentSystem.FriendlyEntityName;
    this.RecreateTypeName = supportDocumentSystem.RecreateTypeName;
    this.HasControlGUID = supportDocumentSystem.HasControlGUID;
    if (supportDocumentSystem.HasControlGUID)
      this.ControlGUID = supportDocumentSystem.ControlGUID;
  }

  public DocSupportCache(
    bool allowAddNewDocument,
    bool canReCreateEntity,
    Guid entityGUID,
    string entityName,
    string friendlyEntityName,
    string recreateTypeName,
    bool hasControlGuid,
    Guid controlGuid)
  {
    this.AllowAddNewDocument = allowAddNewDocument;
    this.CanReCreateEntity = canReCreateEntity;
    this._entityGUID = entityGUID;
    this.EntityName = entityName;
    this.FriendlyEntityName = friendlyEntityName;
    this.RecreateTypeName = recreateTypeName;
    this.HasControlGUID = hasControlGuid;
    this.ControlGUID = controlGuid;
  }

  [Obsolete("hasQuoteGuid and quoteGuid are now ignored")]
  public DocSupportCache(
    bool allowAddNewDocument,
    bool canReCreateEntity,
    Guid entityGUID,
    string entityName,
    string friendlyEntityName,
    string recreateTypeName,
    bool hasControlGuid,
    Guid controlGuid,
    bool hasQuoteGuid,
    Guid quoteGuid)
  {
    this.AllowAddNewDocument = allowAddNewDocument;
    this.CanReCreateEntity = canReCreateEntity;
    this._entityGUID = entityGUID;
    this.EntityName = entityName;
    this.FriendlyEntityName = friendlyEntityName;
    this.RecreateTypeName = recreateTypeName;
    this.HasControlGUID = hasControlGuid;
    this.ControlGUID = controlGuid;
  }

  string IRecreatableEntity.EntityName { get; }

  string IRecreatableEntity.FriendlyEntityName { get; }

  string IRecreatableEntity.RecreateTypeName { get; }

  Guid IRecreatableEntity.EntityGUID => this._entityGUID;

  public void SetEntityGUID(Guid entityGUID) => this._entityGUID = entityGUID;

  public bool AllowAddNewDocument { get; }

  bool IRecreatableEntity.CanReCreateEntity { get; }

  [EditorBrowsable(EditorBrowsableState.Never)]
  bool IRecreatableEntity.RecreateEntityInitialize(Guid entityGuid)
  {
    bool flag;
    return flag;
  }

  [EditorBrowsable(EditorBrowsableState.Never)]
  public event ISupportDocumentSystem.EntityInfoChangedEventHandler EntityInfoChanged;

  Guid IRecreatableEntity.ControlGUID { get; }

  bool IRecreatableEntity.HasControlGUID { get; }
}
