// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.NoteDocuments.DocumentSystem.Document
// Assembly: MgaSystems.IMS.NotesDocuments, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 3F898CF7-066D-4B05-A9F1-D37DBC4FAA16
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.NotesDocuments.dll

using MGASystems.Common;
using MGASystems.Common.DataAccess;
using MGASystems.Data;
using MGASystems.IMS.DocumentStorage;
using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.CodeAnalysis;

#nullable disable
namespace MGASystems.IMS.NoteDocuments.DocumentSystem;

public class Document : ISupportDocumentSystem
{
  private readonly Guid _documentStoreGuid;
  private Metadata _metadata;
  private dsDocument _dsDocument;

  public Metadata Metadata
  {
    get
    {
      if (Information.IsNothing((object) this._metadata))
        this._metadata = DocumentManager.GetDocumentMetadata(this._documentStoreGuid);
      return this._metadata;
    }
  }

  public Document(Guid documentStoreGuid) => this._documentStoreGuid = documentStoreGuid;

  public string Description => this.Metadata.Description;

  [SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate")]
  [SuppressMessage("Microsoft.Design", "CA1002:DoNotExposeGenericLists")]
  public List<Guid> GetAssociatedEntityGuids()
  {
    DataTable dataTable = Database.Instance.QueryText.PerformTableQuery("SELECT AssociatedEntityGuid FROM tblDocumentAssociations WHERE DocumentStoreGuid = @DSG", (object) "@DSG", (object) this._documentStoreGuid);
    List<Guid> associatedEntityGuids = new List<Guid>();
    try
    {
      foreach (DataRow row in dataTable.Rows)
        associatedEntityGuids.Add((Guid) row[0]);
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    return associatedEntityGuids;
  }

  public void LogForAllEntities(string logMessage)
  {
    List<Guid> associatedEntityGuids = this.GetAssociatedEntityGuids();
    try
    {
      foreach (Guid identifier in associatedEntityGuids)
        CurrentUser.Instance.LogAction(logMessage, identifier);
    }
    finally
    {
      List<Guid>.Enumerator enumerator;
      enumerator.Dispose();
    }
  }

  private dsDocument.tblDocumentAssociationsRow DocumentAssociationsRow
  {
    get
    {
      if (this._dsDocument == null)
      {
        this._dsDocument = new dsDocument();
        DefaultDatabase.LoadDataTable((DataTable) this._dsDocument.tblDocumentAssociations, CommandType.Text, "SELECT * FROM tblDocumentAssociations WHERE DocumentStoreGuid = @DSG", new object[2]
        {
          (object) "@DSG",
          (object) this._documentStoreGuid
        });
      }
      return this._dsDocument.tblDocumentAssociations.Count != 0 ? this._dsDocument.tblDocumentAssociations[0] : (dsDocument.tblDocumentAssociationsRow) null;
    }
  }

  bool IRecreatableEntity.CanReCreateEntity
  {
    get
    {
      return Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DocumentAssociationsRow.AssociatedEntityType, string.Empty, false) != 0;
    }
  }

  Guid IRecreatableEntity.ControlGUID
  {
    get
    {
      return !this.DocumentAssociationsRow.IsControlGuidNull() ? this.DocumentAssociationsRow.ControlGuid : Guid.Empty;
    }
  }

  Guid IRecreatableEntity.EntityGuid => this.DocumentAssociationsRow.AssociatedEntityGUID;

  string IRecreatableEntity.EntityName => this.DocumentAssociationsRow.AssociatedEntityName;

  string IRecreatableEntity.FriendlyEntityName
  {
    get => this.DocumentAssociationsRow.AssociatedEntityFormName;
  }

  bool IRecreatableEntity.HasControlGUID => !this.DocumentAssociationsRow.IsControlGuidNull();

  bool IRecreatableEntity.RecreateEntityInitialize(Guid entityGuid)
  {
    bool flag;
    return flag;
  }

  string IRecreatableEntity.RecreateTypeName => this.DocumentAssociationsRow.AssociatedEntityType;

  public bool AllowAddNewDocument => false;

  public event ISupportDocumentSystem.EntityInfoChangedEventHandler EntityInfoChanged;
}
