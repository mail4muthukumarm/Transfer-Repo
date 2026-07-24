// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.NoteDocuments.NoteOverrideInformation
// Assembly: MgaSystems.IMS.NotesDocuments, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 3F898CF7-066D-4B05-A9F1-D37DBC4FAA16
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.NotesDocuments.dll

using System;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.NoteDocuments;

public class NoteOverrideInformation
{
  private string _reason;
  private bool _cancelOperation;
  private object _context;

  public NoteOverrideInformation(string reason)
    : this(reason, (object) null)
  {
  }

  public NoteOverrideInformation(string reason, object context)
  {
    this._reason = reason;
    this._cancelOperation = false;
    this._context = RuntimeHelpers.GetObjectValue(context);
  }

  public object Context => this._context;

  public string Reason => this._reason;

  public virtual bool CancelOperation => this._cancelOperation;

  public virtual void PerformOverrideAction() => throw new NotImplementedException();
}
