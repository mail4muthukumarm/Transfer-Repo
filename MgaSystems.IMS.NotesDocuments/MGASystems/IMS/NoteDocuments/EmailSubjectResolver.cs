// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.NoteDocuments.EmailSubjectResolver
// Assembly: MgaSystems.IMS.NotesDocuments, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 3F898CF7-066D-4B05-A9F1-D37DBC4FAA16
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.NotesDocuments.dll

using MGASystems.Data;
using System.Data;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.NoteDocuments;

public class EmailSubjectResolver
{
  public virtual string ResolveSubjectText(IRecreatableEntity entity)
  {
    return Utility.IsNull<string>(RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, "select dbo.DocumentSystem_FetchEmailSubjectForControl(@controlGuid, @SetSubject)", new object[4]
    {
      (object) "@controlGuid",
      (object) entity.ControlGUID,
      (object) "@SetSubject",
      (object) false
    })), "Could not determine insured information");
  }
}
