// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Services.AccountingNoteDocumentSupport
// Assembly: MgaSystems.IMS.Accounting.Services, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EEF87E2E-9738-4C33-AE03-5712A958CE99
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Services.dll

using MGASystems.Common;
using MGASystems.IMS.NoteDocuments;
using System;

#nullable disable
namespace MGASystems.IMS.Accounting.Services;

public class AccountingNoteDocumentSupport : 
  FormBase,
  ISupportDocumentSystem,
  IRecreatableEntity,
  ISupportNoteSystem
{
  public const string ACCOUNTING_ENTITY_GUID = "{F21DF59D-87D7-479e-8F59-6E9B4D776EE4}";
  public const string ACCOUNTING_ENTITY_NAME = "Accounting";

  public bool CanCreateNewNote => true;

  public event ISupportNoteSystem.EntityInfoChangedEventHandler EntityInfoChanged;

  public bool AllowAddNewDocument => true;

  event ISupportDocumentSystem.EntityInfoChangedEventHandler ISupportDocumentSystem.EntityInfoChanged
  {
    add
    {
    }
    remove
    {
    }
  }

  public bool CanReCreateEntity => false;

  public Guid ControlGUID => Guid.Empty;

  public Guid EntityGuid => new Guid("{F21DF59D-87D7-479e-8F59-6E9B4D776EE4}");

  public string EntityName => "Accounting";

  public string FriendlyEntityName => "Accounting";

  public bool HasControlGUID => false;

  public bool RecreateEntityInitialize(Guid entityGuid) => false;

  public string RecreateTypeName => string.Empty;
}
