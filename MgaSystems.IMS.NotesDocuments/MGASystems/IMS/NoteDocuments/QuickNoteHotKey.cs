// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.NoteDocuments.QuickNoteHotKey
// Assembly: MgaSystems.IMS.NotesDocuments, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 3F898CF7-066D-4B05-A9F1-D37DBC4FAA16
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.NotesDocuments.dll

using MGASystems.Common;
using MGASystems.Common.HotKeyManagement;
using MGASystems.IMS.NoteDocuments.NoteDiarySystem;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.NoteDocuments;

[SecureHotkeyResource("{FABBB3A1-8BC3-4fb2-8595-D42DDEA2F4B5}", "Create quick note hot key button", "Determines if the user can create a quick note via the hot key bar", "Note System")]
[HotKeyInfo("QuickNoteButton", "Create Unbound Note", "Create a new note", Keys.Q | Keys.Control, "MGASystems.Tools.note_add.png", "Ctrl + Q")]
public sealed class QuickNoteHotKey : IHotKeyDisplayItem
{
  internal const string SecurityIDQuickNoteHotKey = "{FABBB3A1-8BC3-4fb2-8595-D42DDEA2F4B5}";

  public void ShowItem() => Note_System.Instance.UIInteractive.CreateQuickNote();
}
