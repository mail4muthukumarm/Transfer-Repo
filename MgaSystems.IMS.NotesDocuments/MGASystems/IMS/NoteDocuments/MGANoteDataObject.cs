// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.NoteDocuments.MGANoteDataObject
// Assembly: MgaSystems.IMS.NotesDocuments, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 3F898CF7-066D-4B05-A9F1-D37DBC4FAA16
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.NotesDocuments.dll

using Infragistics.Win.UltraWinTree;
using MGASystems.IMS.NoteDocuments.NoteDiarySystem;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.NoteDocuments;

public class MGANoteDataObject : IDataObject
{
  private DataObject _dataObject;
  private UltraTree _tree;
  private Dictionary<string, string> _downloadedNotes;
  private List<string> _droppedFileNames;

  public UltraTree Tree
  {
    get => this._tree;
    set => this._tree = value;
  }

  public object GetData(string format, bool autoConvert)
  {
    object data;
    if (Operators.CompareString(format, "FileDrop", false) == 0 && this.Tree != null && this.Tree.SelectedNodes != null)
    {
      int num = 0;
      foreach (UltraTreeNode selectedNode in this.Tree.SelectedNodes)
      {
        if (selectedNode is TabNotePanel.NoteTreeNode noteTreeNode && !this._downloadedNotes.ContainsKey(noteTreeNode.Key))
        {
          string sourceFileName = Note_System.Instance.NonInteractive.PdfSave(noteTreeNode.NoteGUID);
          string destFileName = sourceFileName.Replace(".pdf", $"{num.ToString()}.pdf");
          File.Move(sourceFileName, destFileName);
          ++num;
          this._downloadedNotes.Add(noteTreeNode.Key, destFileName);
          this._droppedFileNames.Add(destFileName);
        }
      }
      data = (object) this._droppedFileNames.ToArray();
    }
    else
      data = this._dataObject.GetData(format, autoConvert);
    return data;
  }

  public MGANoteDataObject()
  {
    this._downloadedNotes = new Dictionary<string, string>();
    this._droppedFileNames = new List<string>();
    this._dataObject = new DataObject();
  }

  public MGANoteDataObject(object data)
  {
    this._downloadedNotes = new Dictionary<string, string>();
    this._droppedFileNames = new List<string>();
    this._dataObject = new DataObject(RuntimeHelpers.GetObjectValue(data));
  }

  public MGANoteDataObject(string format, object data)
  {
    this._downloadedNotes = new Dictionary<string, string>();
    this._droppedFileNames = new List<string>();
    this._dataObject = new DataObject(format, RuntimeHelpers.GetObjectValue(data));
  }

  public object GetData(string format) => this._dataObject.GetData(format);

  public object GetData(Type format) => this._dataObject.GetData(format);

  public bool GetDataPresent(string format) => this._dataObject.GetDataPresent(format);

  public bool GetDataPresent(string format, bool autoConvert)
  {
    return this._dataObject.GetDataPresent(format, autoConvert);
  }

  public bool GetDataPresent(Type format) => this._dataObject.GetDataPresent(format);

  public string[] GetFormats() => this._dataObject.GetFormats();

  public string[] GetFormats(bool autoConvert) => this._dataObject.GetFormats(autoConvert);

  public void SetData(object data) => this._dataObject.SetData(RuntimeHelpers.GetObjectValue(data));

  public void SetData(string format, bool autoConvert, object data)
  {
    this._dataObject.SetData(format, autoConvert, RuntimeHelpers.GetObjectValue(data));
  }

  public void SetData(string format, object data)
  {
    this._dataObject.SetData(format, RuntimeHelpers.GetObjectValue(data));
  }

  public void SetData(Type format, object data)
  {
    this._dataObject.SetData(format, RuntimeHelpers.GetObjectValue(data));
  }
}
