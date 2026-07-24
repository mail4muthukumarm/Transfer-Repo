// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.NoteDocuments.MGADataObject
// Assembly: MgaSystems.IMS.NotesDocuments, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 3F898CF7-066D-4B05-A9F1-D37DBC4FAA16
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.NotesDocuments.dll

using Infragistics.Win.UltraWinTree;
using MGASystems.IMS.NoteDocuments.DocumentSystem;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.NoteDocuments;

public class MGADataObject : IDataObject
{
  private DataObject _dataObject;

  protected DataObject DataObject => this._dataObject;

  protected virtual object OnGetData(string format, bool autoConvert)
  {
    if (Operators.CompareString(format, "FileDrop", false) == 0 && this._dataObject.GetData("MGASystems.IMS.NoteDocuments.TabDocumentPanel+FileNode") is TabDocumentPanel.FileNode data && data.Control != null && data.Control.SelectedNodes != null)
    {
      foreach (UltraTreeNode selectedNode in data.Control.SelectedNodes)
      {
        TabDocumentPanel.FileNode fileNode = selectedNode as TabDocumentPanel.FileNode;
        if (!File.Exists(fileNode.FileDropPath))
        {
          using (MGASystems.IMS.NoteDocuments.DocumentSystem.frmDownloadDocumentNonThreaded documentNonThreaded1 = new MGASystems.IMS.NoteDocuments.DocumentSystem.frmDownloadDocumentNonThreaded(fileNode.FileName))
          {
            MGASystems.IMS.NoteDocuments.DocumentSystem.frmDownloadDocumentNonThreaded documentNonThreaded2 = documentNonThreaded1;
            documentNonThreaded2.ShowInTaskbar = false;
            documentNonThreaded2.StartPosition = FormStartPosition.CenterScreen;
            documentNonThreaded2.Show();
            Application.DoEvents();
            File.Move(DocumentManager.SaveDocumentToFile(fileNode.DocumentGUID), fileNode.FileDropPath);
            documentNonThreaded1.Close();
          }
        }
      }
    }
    return this._dataObject.GetData(format, autoConvert);
  }

  public object GetData(string format, bool autoConvert) => this.OnGetData(format, autoConvert);

  public MGADataObject() => this._dataObject = new DataObject();

  public MGADataObject(object data)
  {
    this._dataObject = new DataObject(RuntimeHelpers.GetObjectValue(data));
  }

  public MGADataObject(string format, object data)
  {
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
