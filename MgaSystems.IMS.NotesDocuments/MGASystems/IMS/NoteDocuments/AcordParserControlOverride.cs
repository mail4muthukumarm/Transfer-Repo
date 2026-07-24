// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.NoteDocuments.AcordParserControlOverride
// Assembly: MgaSystems.IMS.NotesDocuments, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 3F898CF7-066D-4B05-A9F1-D37DBC4FAA16
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.NotesDocuments.dll

#nullable disable
namespace MGASystems.IMS.NoteDocuments;

public class AcordParserControlOverride
{
  public const string ToolKey = "Parse Acord App and View in NetRate";

  public virtual bool ShouldDisplayParseTool(
    IRecreatableEntity activeEntity,
    TabDocumentPanel.FileNode file)
  {
    return false;
  }

  public virtual void HandleClick(IRecreatableEntity activeEntity, TabDocumentPanel.FileNode file)
  {
  }
}
