// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.NoteDocuments.DocumentSystem.DocumentSystemFileAdditonalDataOverride
// Assembly: MgaSystems.IMS.NotesDocuments, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 3F898CF7-066D-4B05-A9F1-D37DBC4FAA16
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.NotesDocuments.dll

using MGASystems.Common;
using System;

#nullable disable
namespace MGASystems.IMS.NoteDocuments.DocumentSystem;

public class DocumentSystemFileAdditonalDataOverride
{
  public virtual void OnDocumentSaved(Guid documentStoreGuid, string additionalSaveData)
  {
  }

  public static DocumentSystemFileAdditonalDataOverride Create()
  {
    return ObjectFactory.Instance.CreateObjectAs<DocumentSystemFileAdditonalDataOverride>();
  }
}
