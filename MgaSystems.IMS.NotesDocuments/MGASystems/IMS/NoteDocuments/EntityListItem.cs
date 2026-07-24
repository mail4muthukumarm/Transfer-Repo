// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.NoteDocuments.EntityListItem
// Assembly: MgaSystems.IMS.NotesDocuments, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 3F898CF7-066D-4B05-A9F1-D37DBC4FAA16
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.NotesDocuments.dll

using MGASystems.Common;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Diagnostics.CodeAnalysis;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.NoteDocuments;

[SuppressMessage("Microsoft.Usage", "CA2229:ImplementSerializationConstructors")]
[Serializable]
public class EntityListItem : ListViewItem
{
  private string _entityFormName;
  private Guid _entityGUID;
  private string _entityType;
  private bool _isPlaceHolder;
  private string _entityName;

  public EntityListItem(
    string entityName,
    string entityFormName,
    Guid entityGUID,
    string entityType)
    : base(entityName, 0)
  {
    this._entityType = entityType;
    this._entityFormName = entityFormName;
    this._entityGUID = entityGUID;
    this._entityName = entityName;
  }

  public EntityListItem(
    string entityName,
    string entityFormName,
    Guid entityGUID,
    string entityType,
    bool isPlaceHolder)
    : base(entityName, 0)
  {
    this._entityType = entityType;
    this._entityFormName = entityFormName;
    this._entityGUID = entityGUID;
    this._isPlaceHolder = isPlaceHolder;
  }

  public bool IsPlaceHolder => this._isPlaceHolder;

  public string EntityFormName => this._entityFormName;

  public string EntityName => this._entityName;

  [SuppressMessage("Microsoft.Naming", "CA1705:LongAcronymsShouldBePascalCased", MessageId = "Member")]
  public Guid EntityGUID => this._entityGUID;

  public Type EntityType => ObjectFactory.Instance.CreateTypeFromString(this._entityType);

  public bool IsEdited => Operators.CompareString(this.Text, this._entityName, false) != 0;
}
