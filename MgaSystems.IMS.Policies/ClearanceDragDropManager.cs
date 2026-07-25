// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.ClearanceDragDropManager
// Assembly: MgaSystems.IMS.Policies, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 2FF2C709-F7BF-41DA-82BD-FF6319CA235D
// Assembly location: C:\Users\muthu\Downloads\MgaSystems.IMS.Policies.dll

using Infragistics.Win;
using Infragistics.Win.UltraWinGrid;
using MGASystems.AsposeFacade.Email.Outlook;
using MGASystems.Common;
using MGASystems.ExtendedEditors.DragDrop;
using MGASystems.IMS.NoteDocuments;
using MGASystems.IMS.NoteDocuments.DocumentSystem;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Policies;

public class ClearanceDragDropManager : IDisposable
{
  private UltraGrid _clearanceGrid;
  private ISupportDocumentSystem _docSupport;
  private const string CONST_FILENODE = "MGASystems.IMS.NoteDocuments.TabDocumentPanel+FileNode";
  private const string CONST_FOLDERNODE = "MGASystems.IMS.NoteDocuments.TabDocumentPanel+FolderNode";
  private const string CONST_OUTLOOKMESSAGE = "Outlook.Message";
  private const string CONST_OUTLOOKATTACHMENT = "Outlook.Attachment";

  public ClearanceDragDropManager(UltraGrid clearanceGrid, ISupportDocumentSystem docSupport)
  {
    this._clearanceGrid = clearanceGrid != null ? clearanceGrid : throw new ArgumentNullException(nameof (clearanceGrid));
    this._docSupport = docSupport;
    ((Control) this._clearanceGrid).DragDrop += new DragEventHandler(this.clearanceGrid_DragDrop);
    ((Control) this._clearanceGrid).DragOver += new DragEventHandler(this.clearanceGrid_DragOver);
  }

  public void Dispose()
  {
    try
    {
      if (this._clearanceGrid != null)
      {
        ((Control) this._clearanceGrid).DragDrop -= new DragEventHandler(this.clearanceGrid_DragDrop);
        ((Control) this._clearanceGrid).DragOver -= new DragEventHandler(this.clearanceGrid_DragOver);
      }
      this._docSupport = (ISupportDocumentSystem) null;
      this._clearanceGrid = (UltraGrid) null;
    }
    catch (NullReferenceException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      ProjectData.ClearProjectError();
    }
  }

  private void clearanceGrid_DragDrop(object sender, DragEventArgs e)
  {
    if (!ClearanceDragDropManager.IsQuoteRow(this.GridRowUnderMouse))
      return;
    try
    {
      if (this._docSupport != null)
      {
        if (this._docSupport.AllowAddNewDocument)
        {
          if (e.Data.GetDataPresent(DataFormats.FileDrop, false))
          {
            string[] data = (string[]) e.Data.GetData(DataFormats.FileDrop);
            int index = 0;
            while (index < data.Length)
            {
              DocumentManager.FileAddWithBind(data[index], this._docSupport);
              checked { ++index; }
            }
          }
          else if (e.Data.GetDataPresent("ByteData", false))
          {
            if (e.Data.GetData("ByteData", false) is List<ByteData> data1)
            {
              try
              {
                foreach (ByteData byteData in data1)
                {
                  string str = this.ValidatePath(MGATempFolder.MGATempRandomFolderPath + byteData.FileName);
                  using (FileStream fileStream = new FileStream(str, FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite))
                  {
                    byte[] bytes = byteData.GetBytes();
                    fileStream.Write(bytes, 0, bytes.Length);
                  }
                  if (str.EndsWith(".msg", true, CultureInfo.InvariantCulture))
                  {
                    string[] email = ClearanceDragDropManager.ParseEmail(str);
                    int index = 0;
                    while (index < email.Length)
                    {
                      DocumentManager.FileAddWithBind(email[index], this._docSupport);
                      checked { ++index; }
                    }
                  }
                  else
                    DocumentManager.FileAddWithBind(str, this._docSupport);
                }
              }
              finally
              {
                List<ByteData>.Enumerator enumerator;
                enumerator.Dispose();
              }
            }
          }
        }
      }
    }
    finally
    {
      DocumentManager.ResetFolderIdToReuse();
    }
    DocumentManager.FireEntityDocumentCollectionChanged();
  }

  internal static string[] ParseEmail(string emailPath)
  {
    MapiMessage mapiMessage = MapiMessage.FromFile(emailPath);
    string[] email;
    if (mapiMessage.Attachments.Count > 0)
    {
      using (frmMessageDropOptions messageDropOptions = new frmMessageDropOptions())
      {
        if (((Form) messageDropOptions).ShowDialog() == DialogResult.OK)
        {
          switch (messageDropOptions.ImportOptions - 1)
          {
            case 0:
              email = new string[1]{ emailPath };
              goto label_26;
            case 1:
              MapiMessage.RemoveAttachments(emailPath);
              email = new string[1]{ emailPath };
              goto label_26;
            case 2:
              List<string> stringList1 = new List<string>();
              try
              {
                foreach (MapiAttachment attachment in (IEnumerable<MapiAttachment>) mapiMessage.Attachments)
                {
                  string str = $"{MGATempFolder.CreateTempSubdirectory()}{attachment.LongFileName}";
                  attachment.Save(str);
                  stringList1.Add(str);
                }
              }
              finally
              {
                IEnumerator<MapiAttachment> enumerator;
                enumerator?.Dispose();
              }
              email = stringList1.ToArray();
              goto label_26;
            case 3:
              List<string> stringList2 = new List<string>();
              try
              {
                foreach (MapiAttachment attachment in (IEnumerable<MapiAttachment>) mapiMessage.Attachments)
                {
                  string str = Path.Combine(MGATempFolder.CreateTempSubdirectory(), attachment.LongFileName);
                  attachment.Save(str);
                  stringList2.Add(str);
                }
              }
              finally
              {
                IEnumerator<MapiAttachment> enumerator;
                enumerator?.Dispose();
              }
              stringList2.Add(emailPath);
              email = stringList2.ToArray();
              goto label_26;
          }
        }
      }
    }
    email = new string[1]{ emailPath };
label_26:
    return email;
  }

  private string ValidatePath(string fullPath, bool displayUserNotifications = true)
  {
    string str1 = fullPath;
    bool flag1 = false;
    while (!flag1)
    {
      try
      {
        str1 = Path.GetFileName(str1);
        flag1 = true;
      }
      catch (ArgumentException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        string str2 = new string(Path.GetInvalidFileNameChars());
        StringBuilder stringBuilder = new StringBuilder(str1.Length);
        int num = str1.Length - 1;
        for (int index = 0; index <= num; ++index)
        {
          if (str2.IndexOf(str1[index]) == -1)
            stringBuilder.Append(str1[index]);
        }
        str1 = stringBuilder.ToString();
        ProjectData.ClearProjectError();
      }
    }
    string path = fullPath.Replace(str1, "");
    bool flag2 = false;
    while (!flag2)
    {
      try
      {
        path = Path.GetDirectoryName(path);
        flag2 = true;
      }
      catch (ArgumentException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        string str3 = new string(Path.GetInvalidPathChars());
        StringBuilder stringBuilder = new StringBuilder(path.Length);
        int num = path.Length - 1;
        for (int index = 0; index <= num; ++index)
        {
          if (str3.IndexOf(path[index]) == -1)
            stringBuilder.Append(path[index]);
        }
        path = stringBuilder.ToString();
        ProjectData.ClearProjectError();
      }
      catch (PathTooLongException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        path.LastIndexOf(Path.GetExtension(path));
        int num = path.LastIndexOf(Path.DirectorySeparatorChar);
        path = num != -1 ? path.Substring(0, num + 1) : throw new InvalidOperationException("could not extract a directory from this filename");
        ProjectData.ClearProjectError();
      }
    }
    bool flag3 = false;
    int num1 = 259;
    while (!flag3)
    {
      try
      {
        fullPath = Path.GetFullPath($"{path}\\{str1}");
        flag3 = true;
      }
      catch (PathTooLongException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        --num1;
        int num2 = num1 - path.Length;
        str1 = str1.Substring(str1.Length - num2);
        if (displayUserNotifications)
        {
          int num3 = (int) MessageBox.Show($"The filename generated from the email subject has been shortened to '{str1}'.", "The specified path, file name, or both exceed the system-defined maximum length.", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        ProjectData.ClearProjectError();
      }
    }
    return fullPath;
  }

  private void clearanceGrid_DragOver(object sender, DragEventArgs e)
  {
    UltraGridRow gridRowUnderMouse = this.GridRowUnderMouse;
    if (e.Data.GetDataPresent("MGASystems.IMS.NoteDocuments.TabDocumentPanel+FileNode", false) || e.Data.GetDataPresent("ByteData", false) || e.Data.GetDataPresent(DataFormats.FileDrop, false))
    {
      e.Effect = DragDropEffects.Copy;
      if (ClearanceDragDropManager.IsQuoteRow(gridRowUnderMouse))
      {
        e.Effect = DragDropEffects.Copy;
        if (((UltraGridBase) this._clearanceGrid).ActiveRow != gridRowUnderMouse)
          ((UltraGridBase) this._clearanceGrid).ActiveRow = gridRowUnderMouse;
        if (gridRowUnderMouse.Selected)
          return;
        gridRowUnderMouse.Selected = true;
        return;
      }
    }
    e.Effect = DragDropEffects.None;
  }

  private UltraGridRow GridRowUnderMouse
  {
    get
    {
      UltraGridRow gridRowUnderMouse = (UltraGridRow) null;
      UIElement uiElement = ((UIElement) ((UltraGridBase) this._clearanceGrid).DisplayLayout.UIElement).ElementFromPoint(((Control) this._clearanceGrid).PointToClient(Cursor.Position));
      rowUiElement = (RowUIElement) null;
      switch (uiElement)
      {
        case null:
        case RowUIElement rowUiElement:
          if (rowUiElement != null)
            gridRowUnderMouse = (UltraGridRow) ((UIElement) rowUiElement).GetContext(typeof (UltraGridRow));
          return gridRowUnderMouse;
        default:
          rowUiElement = uiElement.GetAncestor(typeof (RowUIElement)) as RowUIElement;
          goto case null;
      }
    }
  }

  private static bool IsQuoteRow(UltraGridRow row)
  {
    bool flag = false;
    return row == null ? flag : row.Band.Index == 2;
  }
}
