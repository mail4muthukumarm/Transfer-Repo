// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.NoteDocuments.DocumentSystem.DocumentManager
// Assembly: MgaSystems.IMS.NotesDocuments, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 3F898CF7-066D-4B05-A9F1-D37DBC4FAA16
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.NotesDocuments.dll

using MGASystems.AsposeFacade;
using MGASystems.AsposeFacade.PDF;
using MGASystems.Common;
using MGASystems.Common.BroadcastMessaging;
using MGASystems.Common.DataAccess;
using MGASystems.Common.ErrorHandling;
using MGASystems.Common.Extensions;
using MGASystems.Common.FileIO;
using MGASystems.Common.NativeWindowMethods;
using MGASystems.Data;
using MGASystems.ExtendedEditors.ShellLink;
using MGASystems.IMS.DocumentStorage;
using MGASystems.IMS.DocumentStorage.DocumentProviders;
using MGASystems.IMS.DocumentStorage.MetadataProviders;
using MGASystems.IMS.Logging.Administration;
using MGASystems.IMS.NoteDocuments.Email;
using MGASystems.IMS.NoteDocuments.Serialization;
using MGASystems.Tools;
using MGASystems.Tools.Adobe;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Permissions;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.NoteDocuments.DocumentSystem;

[StandardModule]
[LogCategory("DocumentSystem.DocumentManager", "DocumentSystem.DocumentManager")]
public sealed class DocumentManager
{
  internal const string LogKeyDocumentManager = "DocumentSystem.DocumentManager";
  private static Dictionary<Guid, string> documentAliasLookup = new Dictionary<Guid, string>();
  private static int _folderIdToReuse;
  private static IMetadataProvider _metadataProvider;
  private static IDocumentRepository _documentRepository;

  static DocumentManager()
  {
    DocumentManager.CurrentFolderID = string.Empty;
    DocumentManager._folderIdToReuse = -1;
  }

  public static void AddDocumentAlias(Guid documentStoreGuid, string aliasFileName)
  {
    DocumentManager.documentAliasLookup.Add(documentStoreGuid, aliasFileName);
  }

  public static event EventHandler EntityDocumentCollectionChanged;

  public static event EventHandler UserDocumentCollectionChanged;

  internal static string CurrentFolderID { get; set; }

  private static bool CopyForwardOnRenewal { get; set; }

  private static bool CopyForwardOnlyOnce { get; set; }

  public static int FolderIdToReuse
  {
    get => DocumentManager._folderIdToReuse;
    set => DocumentManager._folderIdToReuse = value;
  }

  public static void ResetFolderIdToReuse() => DocumentManager._folderIdToReuse = -1;

  public static bool FolderReuseEnabled => DocumentManager._folderIdToReuse != -1;

  public static event DocumentManager.DocumentBoundEventHandler DocumentBound;

  public static void FireDocumentBound(
    Guid documentGUID,
    DocSupportCache entity,
    string fileName,
    int folderId)
  {
    // ISSUE: reference to a compiler-generated field
    DocumentManager.DocumentBoundEventHandler documentBoundEvent = DocumentManager.DocumentBoundEvent;
    if (documentBoundEvent == null)
      return;
    documentBoundEvent((object) null, new DocumentManager.DocumentBoundEventArgs(documentGUID, entity, fileName, folderId));
  }

  internal static void RefreshAllUI()
  {
    DocumentManager.FireUserDocumentCollectionChanged();
    DocumentManager.FireEntityDocumentCollectionChanged();
  }

  public static void FireEntityDocumentCollectionChanged()
  {
    // ISSUE: reference to a compiler-generated field
    EventHandler collectionChangedEvent = DocumentManager.EntityDocumentCollectionChangedEvent;
    if (collectionChangedEvent == null)
      return;
    collectionChangedEvent((object) null, EventArgs.Empty);
  }

  public static void FireUserDocumentCollectionChanged()
  {
    // ISSUE: reference to a compiler-generated field
    EventHandler collectionChangedEvent = DocumentManager.UserDocumentCollectionChangedEvent;
    if (collectionChangedEvent == null)
      return;
    collectionChangedEvent((object) null, EventArgs.Empty);
  }

  public static int DocsOnEntityCount(Guid entityGuid)
  {
    return Utility.IsNull<int>((object) DefaultDatabase.ExecuteScalar<int?>(CommandType.Text, "SELECT COUNT(*) AS DocCount FROM tblDocumentAssociations (NOLOCK) WHERE AssociatedEntityGUID = @EntityGUID", new object[2]
    {
      (object) "@EntityGUID",
      (object) entityGuid
    }), 0);
  }

  public static void BeginFileAddWithBind(string path, ISupportDocumentSystem docSupport)
  {
    DocumentManager.BeginFileAddWithBind((DocumentManager.FileAddedAndBound) null, path, -1, string.Empty, docSupport, false);
  }

  public static void BeginFileAddWithBind(
    string path,
    int folderId,
    ISupportDocumentSystem docSupport)
  {
    DocumentManager.BeginFileAddWithBind((DocumentManager.FileAddedAndBound) null, path, folderId, string.Empty, docSupport, false);
  }

  public static void BeginFileAddWithBind(
    string path,
    int folderId,
    string description,
    ISupportDocumentSystem docSupport)
  {
    DocumentManager.BeginFileAddWithBind((DocumentManager.FileAddedAndBound) null, path, folderId, description, docSupport, false);
  }

  public static void BeginFileAddWithBind(
    DocumentManager.FileAddedAndBound fileAdded,
    string path,
    int folderId,
    string description,
    ISupportDocumentSystem docSupport)
  {
    DocumentManager.BeginFileAddWithBind(fileAdded, path, folderId, description, docSupport, false);
  }

  public static void BeginFileAddWithBind(
    string path,
    ISupportDocumentSystem docSupport,
    bool deleteFileAfterUpload)
  {
    DocumentManager.BeginFileAddWithBind((DocumentManager.FileAddedAndBound) null, path, -1, string.Empty, docSupport, deleteFileAfterUpload);
  }

  public static void BeginFileAddWithBind(
    string path,
    int folderId,
    ISupportDocumentSystem docSupport,
    bool deleteFileAfterUpload)
  {
    DocumentManager.BeginFileAddWithBind((DocumentManager.FileAddedAndBound) null, path, folderId, string.Empty, docSupport, deleteFileAfterUpload);
  }

  public static void BeginFileAddWithBind(
    string path,
    int folderId,
    string description,
    ISupportDocumentSystem docSupport,
    bool deleteFileAfterUpload)
  {
    DocumentManager.BeginFileAddWithBind((DocumentManager.FileAddedAndBound) null, path, folderId, description, docSupport, deleteFileAfterUpload);
  }

  public static void BeginFileAddWithBind(
    string path,
    int folderId,
    string description,
    ISupportDocumentSystem docSupport,
    bool deleteFileAfterUpload,
    bool ShowInfoForm)
  {
    DocumentManager.BeginFileAddWithBind((DocumentManager.FileAddedAndBound) null, path, folderId, description, docSupport, deleteFileAfterUpload, string.Empty, true, false, Guid.Empty, ShowInfoForm);
  }

  public static void BeginFileAddWithBind(
    string path,
    ISupportDocumentSystem docSupport,
    string context)
  {
    DocumentManager.BeginFileAddWithBind((DocumentManager.FileAddedAndBound) null, path, -1, string.Empty, docSupport, false, context);
  }

  public static void BeginFileAddWithBind(
    string path,
    int folderId,
    ISupportDocumentSystem docSupport,
    string context)
  {
    DocumentManager.BeginFileAddWithBind((DocumentManager.FileAddedAndBound) null, path, folderId, string.Empty, docSupport, false, context);
  }

  public static void BeginFileAddWithBind(
    string path,
    int folderId,
    string description,
    ISupportDocumentSystem docSupport,
    string context)
  {
    DocumentManager.BeginFileAddWithBind((DocumentManager.FileAddedAndBound) null, path, folderId, description, docSupport, false, context);
  }

  public static void BeginFileAddWithBind(
    DocumentManager.FileAddedAndBound fileAdded,
    string path,
    ISupportDocumentSystem docSupport,
    Guid documentStoreGuidToAssign)
  {
    DocumentManager.BeginFileAddWithBind(fileAdded, path, -1, string.Empty, docSupport, false, documentStoreGuidToAssign);
  }

  public static void BeginFileAddWithBind(
    DocumentManager.FileAddedAndBound fileAdded,
    string path,
    int folderId,
    string description,
    ISupportDocumentSystem docSupport,
    string context)
  {
    DocumentManager.BeginFileAddWithBind(fileAdded, path, folderId, description, docSupport, false, context);
  }

  public static void BeginFileAddWithBind(
    string path,
    ISupportDocumentSystem docSupport,
    bool deleteFileAfterUpload,
    string context)
  {
    DocumentManager.BeginFileAddWithBind((DocumentManager.FileAddedAndBound) null, path, -1, string.Empty, docSupport, deleteFileAfterUpload, context);
  }

  public static void BeginFileAddWithBind(
    string path,
    int folderId,
    ISupportDocumentSystem docSupport,
    bool deleteFileAfterUpload,
    string context)
  {
    DocumentManager.BeginFileAddWithBind((DocumentManager.FileAddedAndBound) null, path, folderId, string.Empty, docSupport, deleteFileAfterUpload, context);
  }

  public static void BeginFileAddWithBind(
    string path,
    int folderId,
    string description,
    ISupportDocumentSystem docSupport,
    bool deleteFileAfterUpload,
    string context)
  {
    DocumentManager.BeginFileAddWithBind((DocumentManager.FileAddedAndBound) null, path, folderId, description, docSupport, deleteFileAfterUpload, context);
  }

  public static void BeginFileAddWithBind(
    DocumentManager.FileAddedAndBound fileAdded,
    string path,
    int folderId,
    string description,
    ISupportDocumentSystem docSupport,
    bool deleteFileAfterUpload)
  {
    DocumentManager.BeginFileAddWithBind(fileAdded, path, folderId, description, docSupport, deleteFileAfterUpload, string.Empty);
  }

  public static void BeginFileAddWithBind(
    DocumentManager.FileAddedAndBound fileAdded,
    string path,
    int folderId,
    string description,
    ISupportDocumentSystem docSupport,
    bool deleteFileAfterUpload,
    Guid documentStoreGuidToAssign)
  {
    DocumentManager.BeginFileAddWithBind(fileAdded, path, folderId, description, docSupport, deleteFileAfterUpload, string.Empty, documentStoreGuidToAssign);
  }

  public static void BeginFileAddWithBind(
    DocumentManager.FileAddedAndBound fileAdded,
    string path,
    int folderId,
    string description,
    ISupportDocumentSystem docSupport,
    bool deleteFileAfterUpload,
    string context)
  {
    DocumentManager.BeginFileAddWithBind(fileAdded, path, folderId, description, docSupport, deleteFileAfterUpload, context, true);
  }

  public static void BeginFileAddWithBind(
    DocumentManager.FileAddedAndBound fileAdded,
    string path,
    int folderId,
    string description,
    ISupportDocumentSystem docSupport,
    bool deleteFileAfterUpload,
    string context,
    Guid documentStoreGuidToAssign)
  {
    DocumentManager.BeginFileAddWithBind(fileAdded, path, folderId, description, docSupport, deleteFileAfterUpload, context, true, documentStoreGuidToAssign);
  }

  public static Guid BeginFileAddWithBind(
    DocumentManager.FileAddedAndBound fileAdded,
    string path,
    int folderId,
    string description,
    ISupportDocumentSystem docSupport,
    bool deleteFileAfterUpload,
    string context,
    bool threaded)
  {
    return DocumentManager.BeginFileAddWithBind(fileAdded, path, folderId, description, docSupport, deleteFileAfterUpload, context, threaded, false, Guid.Empty);
  }

  public static Guid BeginFileAddWithBind(
    DocumentManager.FileAddedAndBound fileAdded,
    string path,
    int folderId,
    string description,
    ISupportDocumentSystem docSupport,
    bool deleteFileAfterUpload,
    string context,
    bool threaded,
    Guid documentStoreGuidToAssign)
  {
    return DocumentManager.BeginFileAddWithBind(fileAdded, path, folderId, description, docSupport, deleteFileAfterUpload, context, threaded, false, documentStoreGuidToAssign);
  }

  private static void SendUnbindMessage(Guid documentGuid, Guid entityGuid)
  {
    Messaging.SendBroadcastMessage(BroadcastMessages.DocumentUnbinding, (object) new object[2]
    {
      (object) documentGuid,
      (object) entityGuid
    });
  }

  private static void SendDeleteMessage(Guid documentGuid)
  {
    Messaging.SendBroadcastMessage(BroadcastMessages.DocumentDeleting, (object) documentGuid);
  }

  private static ShortcutResolutionMethod GetShortcutResolutionMethod()
  {
    return (ShortcutResolutionMethod) MGASystems.IMS.NoteDocuments.SystemSettings.GetSetting<int>("DocumentManager.ShortCutResolutionSetting", 0);
  }

  private static bool CheckPath(ref string filePath)
  {
    bool flag;
    if (ShellFile.IsLink(filePath))
    {
      switch (DocumentManager.GetShortcutResolutionMethod())
      {
        case ShortcutResolutionMethod.DisallowShortcut:
          flag = false;
          break;
        case ShortcutResolutionMethod.AllowShortcut:
          flag = File.Exists(filePath);
          break;
        case ShortcutResolutionMethod.ResolveToRealFile:
          try
          {
            filePath = ShellFile.ResolveLink(filePath);
            if (!File.Exists(filePath))
              throw new InvalidOperationException();
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            if (System.Windows.Forms.MessageBox.Show("Press Yes if you'd like to manually find the file, or No to cancel the upload.", "You've attempted to import a shortcut .lnk that we could not resolve to a file.", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
            {
              using (OpenFileDialog openFileDialog1 = new OpenFileDialog())
              {
                OpenFileDialog openFileDialog2 = openFileDialog1;
                openFileDialog2.CheckFileExists = true;
                openFileDialog2.DereferenceLinks = true;
                openFileDialog2.Multiselect = false;
                openFileDialog2.Title = "Choose the file you would like to open";
                if (openFileDialog2.ShowDialog() == DialogResult.OK)
                {
                  filePath = openFileDialog2.FileName;
                  flag = File.Exists(filePath);
                  ProjectData.ClearProjectError();
                  break;
                }
                flag = false;
                ProjectData.ClearProjectError();
                break;
              }
            }
            flag = false;
            ProjectData.ClearProjectError();
            break;
          }
          flag = !ShellFile.IsLink(filePath) && File.Exists(filePath);
          break;
      }
    }
    else
      flag = File.Exists(filePath);
    return flag;
  }

  private static void WriteLog(string methodName, string logMessage)
  {
    try
    {
      MGASystems.IMS.Logging.Log.Write($"DocumentManager.{methodName} {logMessage}", "DocumentSystem.DocumentManager");
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      ProjectData.ClearProjectError();
    }
  }

  public static Guid BeginFileAddWithBind(
    DocumentManager.FileAddedAndBound fileAdded,
    string path,
    int folderId,
    string description,
    ISupportDocumentSystem docSupport,
    bool deleteFileAfterUpload,
    string context,
    bool threaded,
    bool attachNote,
    Guid documentStoreGuidToAssign,
    bool ShowInfoForm = false)
  {
    string additionalSaveData = "";
    Guid guid1 = Guid.Empty;
    DocumentManager.WriteLog(nameof (BeginFileAddWithBind), "Invoking");
    if (string.IsNullOrEmpty(path))
      throw new ArgumentNullException(nameof (path));
    Guid guid2;
    if (!DocumentManager.CheckPath(ref path))
    {
      int num = (int) System.Windows.Forms.MessageBox.Show("We could not locate the file that is referenced by this shortcut. Please try uploading it again", "Unable to upload this file", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      guid2 = Guid.Empty;
    }
    else
    {
      if (File.Exists(path))
      {
        DocumentManager.WriteLog(nameof (BeginFileAddWithBind), "File Exists");
        bool noteIsDiary = false;
        string[] strArray = path.Split(Path.DirectorySeparatorChar);
        string str = strArray[strArray.Length - 1];
        bool copyToOtherQuotesOnSubmission = false;
        bool forwardOnRenewal;
        bool copyForwardOnlyOnce;
        if (((folderId != -1 ? 0 : (string.IsNullOrEmpty(description) ? 1 : 0)) | (ShowInfoForm ? 1 : 0)) != 0)
        {
          bool? nullable = MDIControls.Instance?.BlackBoxMode;
          nullable = nullable.HasValue ? new bool?(!nullable.GetValueOrDefault()) : nullable;
          if (nullable.GetValueOrDefault())
          {
            frmFetchDoc frmFetchDoc1 = (frmFetchDoc) null;
            try
            {
              if (!DocumentManager.FolderReuseEnabled)
              {
                switch (docSupport)
                {
                  case null:
                  case frmNote _:
                    frmFetchDoc1 = frmFetchDoc.Create(docSupport);
                    break;
                  default:
                    frmFetchDoc1 = frmFetchDoc.Create(true, docSupport);
                    break;
                }
              }
              DocumentManager.WriteLog(nameof (BeginFileAddWithBind), "Showing Document Info Form");
              if (!DocumentManager.FolderReuseEnabled)
              {
                frmFetchDoc1.Description = string.IsNullOrEmpty(description) ? str : description;
                frmFetchDoc frmFetchDoc2 = frmFetchDoc1;
                MDIControls instance = MDIControls.Instance;
                Form mdiParent = (instance != null ? (instance.MDIParent.InvokeRequired ? 1 : 0) : 0) != 0 ? (Form) null : MDIControls.Instance.MDIParent;
                if (frmFetchDoc2.ShowDialog((IWin32Window) mdiParent) != DialogResult.OK)
                {
                  guid2 = Guid.Empty;
                  goto label_34;
                }
              }
              if (frmFetchDoc1 != null)
              {
                DocumentManager.CopyForwardOnRenewal = frmFetchDoc1.CopyForwardOnRenewal;
                DocumentManager.CopyForwardOnlyOnce = frmFetchDoc1.CopyForwardOnlyOnce;
                additionalSaveData = frmFetchDoc1.GetAdditionalSaveData();
                guid1 = frmFetchDoc1.TypeGuid;
                copyToOtherQuotesOnSubmission = frmFetchDoc1.CopyToOtherCardsOnSubmission;
              }
              if (DocumentManager.FolderReuseEnabled)
              {
                folderId = DocumentManager.FolderIdToReuse;
                description = string.Empty;
                forwardOnRenewal = DocumentManager.CopyForwardOnRenewal;
                copyForwardOnlyOnce = DocumentManager.CopyForwardOnlyOnce;
              }
              else
              {
                folderId = frmFetchDoc1.FolderId;
                description = frmFetchDoc1.Description;
                forwardOnRenewal = frmFetchDoc1.CopyForwardOnRenewal;
                copyForwardOnlyOnce = DocumentManager.CopyForwardOnlyOnce;
                if (frmFetchDoc1.NoteAttachment == frmFetchDoc.NoteAttachmentType.None)
                {
                  attachNote = false;
                }
                else
                {
                  attachNote = true;
                  if (frmFetchDoc1.NoteAttachment == frmFetchDoc.NoteAttachmentType.Diary)
                    noteIsDiary = true;
                }
              }
            }
            finally
            {
              DocumentManager.WriteLog(nameof (BeginFileAddWithBind), "Disposing Document Info Form");
              frmFetchDoc1?.Dispose();
            }
          }
        }
        if (string.IsNullOrEmpty(description))
          description = str;
        DocumentManager.WriteLog(nameof (BeginFileAddWithBind), "Firing Broadcast message");
        DocumentUploadingContext context1 = new DocumentUploadingContext(folderId, path, docSupport);
        Messaging.SendBroadcastMessage(BroadcastMessages.DocumentUploading, (object) context1);
        DocumentManager.WriteLog(nameof (BeginFileAddWithBind), "Fired Broadcast message");
        FileAddQueryThread fileAddQueryThread = new FileAddQueryThread(fileAdded, deleteFileAfterUpload, path, docSupport, folderId, description, context, attachNote, noteIsDiary, forwardOnRenewal, additionalSaveData, copyToOtherQuotesOnSubmission, copyForwardOnlyOnce);
        if (!documentStoreGuidToAssign.Equals(Guid.Empty))
          fileAddQueryThread.DocumentStoreGuid = documentStoreGuidToAssign;
        fileAddQueryThread.DocumentTypeGuid = guid1;
        if (threaded)
        {
          DocumentManager.WriteLog(nameof (BeginFileAddWithBind), "End of FileAddWithBind, We have all the info we need to send this document up, kicking off the upload thread");
          fileAddQueryThread.StartThread();
        }
        else
        {
          DocumentManager.WriteLog(nameof (BeginFileAddWithBind), "End of FileAddWithBind, We have all the info we need to send this document up, Sending up non threaded");
          guid2 = fileAddQueryThread.StartNonThreaded();
          goto label_34;
        }
      }
      guid2 = Guid.Empty;
    }
label_34:
    return guid2;
  }

  public static List<Guid> BeginDriverFileAddWithBind(
    List<(string, string)> files,
    int fldrID,
    string description,
    ISupportDocumentSystem docSupport,
    bool deleteFileAfterUpload,
    string saveAsType)
  {
    string additionalSaveData = "";
    Guid guid = Guid.Empty;
    List<Guid> guidList1 = new List<Guid>();
    DocumentManager.WriteLog(nameof (BeginDriverFileAddWithBind), "Invoking");
    int num1 = fldrID;
    int num2 = files.Count - 1;
    List<Guid> guidList2;
    for (int index = 0; index <= num2; ++index)
    {
      string str1 = files[index].Item2;
      if (File.Exists(str1))
        File.Delete(str1);
      int num3 = 0;
      do
      {
        try
        {
          File.Copy(files[index].Item1, str1);
          break;
        }
        catch (UnauthorizedAccessException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          UnauthorizedAccessException unauthorizedAccessException = ex;
          if (num3 == 3)
          {
            int num4 = (int) System.Windows.Forms.MessageBox.Show($"The system could not access {files[index].Item1}{"\n"}{"\n"}{unauthorizedAccessException.Message}", "Unauthorized Access", MessageBoxButtons.OK, MessageBoxIcon.Hand);
          }
          else
            Thread.Sleep(1000);
          ProjectData.ClearProjectError();
        }
        catch (IOException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          IOException ioException = ex;
          if (index == 3)
          {
            int num5 = (int) System.Windows.Forms.MessageBox.Show($"The system could not create a temporary copy of {files[index].Item1}{"\n"}{"\n"}{ioException.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
          }
          else
            Thread.Sleep(1000);
          ProjectData.ClearProjectError();
        }
        ++num3;
      }
      while (num3 <= 3);
      if (File.Exists(str1))
      {
        DocumentManager.WriteLog(nameof (BeginDriverFileAddWithBind), "File Exists");
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(saveAsType, "P", false) == 0)
          str1 = MGASystems.Common.PDF.ConvertWordDocToPDF(str1);
        bool noteIsDiary = false;
        string[] strArray = str1.Split(Path.DirectorySeparatorChar);
        string str2 = strArray[strArray.Length - 1];
        bool copyToOtherQuotesOnSubmission = false;
        bool forwardOnRenewal;
        bool copyForwardOnlyOnce;
        if (num1 == -1 && string.IsNullOrEmpty(description))
        {
          frmFetchDoc frmFetchDoc = (frmFetchDoc) null;
          try
          {
            if (!DocumentManager.FolderReuseEnabled)
            {
              switch (docSupport)
              {
                case null:
                case frmNote _:
                  frmFetchDoc = frmFetchDoc.Create(docSupport);
                  break;
                default:
                  frmFetchDoc = frmFetchDoc.Create(false, docSupport);
                  break;
              }
            }
            frmFetchDoc.DriverMode = true;
            DocumentManager.WriteLog(nameof (BeginDriverFileAddWithBind), "Showing Document Info Form");
            if (!DocumentManager.FolderReuseEnabled)
            {
              frmFetchDoc.Description = !string.IsNullOrEmpty(description) ? description : str2;
              if (MDIControls.Instance.MDIParent.InvokeRequired)
              {
                if (frmFetchDoc.ShowDialog() != DialogResult.OK)
                {
                  guidList2 = guidList1;
                  goto label_42;
                }
              }
              else if (frmFetchDoc.ShowDialog((IWin32Window) MDIControls.Instance.MDIParent) != DialogResult.OK)
              {
                guidList2 = guidList1;
                goto label_42;
              }
            }
            if (frmFetchDoc != null)
            {
              DocumentManager.CopyForwardOnRenewal = frmFetchDoc.CopyForwardOnRenewal;
              DocumentManager.CopyForwardOnlyOnce = frmFetchDoc.CopyForwardOnlyOnce;
              additionalSaveData = frmFetchDoc.GetAdditionalSaveData();
              guid = frmFetchDoc.TypeGuid;
              copyToOtherQuotesOnSubmission = frmFetchDoc.CopyToOtherCardsOnSubmission;
            }
            if (DocumentManager.FolderReuseEnabled)
            {
              num1 = DocumentManager.FolderIdToReuse;
              description = string.Empty;
              forwardOnRenewal = DocumentManager.CopyForwardOnRenewal;
              copyForwardOnlyOnce = DocumentManager.CopyForwardOnlyOnce;
            }
            else
            {
              num1 = frmFetchDoc.FolderId;
              description = frmFetchDoc.Description;
              forwardOnRenewal = frmFetchDoc.CopyForwardOnRenewal;
              copyForwardOnlyOnce = frmFetchDoc.CopyForwardOnlyOnce;
            }
          }
          finally
          {
            DocumentManager.WriteLog(nameof (BeginDriverFileAddWithBind), "Disposing Document Info Form");
            frmFetchDoc?.Dispose();
          }
        }
        description = str2;
        DocumentManager.WriteLog(nameof (BeginDriverFileAddWithBind), "Firing Broadcast message");
        DocumentUploadingContext context = new DocumentUploadingContext(num1, str1, docSupport);
        Messaging.SendBroadcastMessage(BroadcastMessages.DocumentUploading, (object) context);
        DocumentManager.WriteLog(nameof (BeginDriverFileAddWithBind), "Fired Broadcast message");
        FileAddQueryThread fileAddQueryThread = new FileAddQueryThread((DocumentManager.FileAddedAndBound) null, deleteFileAfterUpload, str1, docSupport, num1, description, "", false, noteIsDiary, forwardOnRenewal, additionalSaveData, copyToOtherQuotesOnSubmission, copyForwardOnlyOnce);
        fileAddQueryThread.DocumentTypeGuid = guid;
        DocumentManager.WriteLog(nameof (BeginDriverFileAddWithBind), "End of FileAddWithBind, We have all the info we need to send this document up, Sending up non threaded");
        guidList1.Add(fileAddQueryThread.StartNonThreaded());
      }
    }
    guidList2 = guidList1;
label_42:
    return guidList2;
  }

  public static void CopyAssociations(Guid originalDocumentStoreGuid, Guid newDocumentStoreGuid)
  {
    DefaultDatabase.ExecuteNonQuery("dbo.DocumentSystem_CopyAssociations", new object[4]
    {
      (object) "@DocumentStoreGuid",
      (object) originalDocumentStoreGuid,
      (object) "@newDocumentStoreGuid",
      (object) newDocumentStoreGuid
    });
  }

  private static IMetadataProvider MetadataProvider
  {
    get
    {
      if (DocumentManager._metadataProvider == null)
        DocumentManager._metadataProvider = (IMetadataProvider) new SqlMetadataProvider();
      return DocumentManager._metadataProvider;
    }
  }

  private static IDocumentRepository DocumentRepository
  {
    get
    {
      if (DocumentManager._documentRepository == null)
      {
        Dictionary<DocumentLocation, IDocumentRepository> providers = new Dictionary<DocumentLocation, IDocumentRepository>();
        if (MGASystems.IMS.NoteDocuments.SystemSettings.GetSetting<bool>("DocStore.Azure", false))
        {
          string setting1 = MGASystems.IMS.NoteDocuments.SystemSettings.GetSetting<string>("DocStore.Azure.AccountName", "DocStore.Azure.AccountName needs to be configured");
          string setting2 = MGASystems.IMS.NoteDocuments.SystemSettings.GetSetting<string>("DocStore.Azure.KeyValue", "DocStore.Azure.KeyValue needs to be configured");
          string setting3 = MGASystems.IMS.NoteDocuments.SystemSettings.GetSetting<string>("DocStore.Azure.PrimaryUri", "DocStore.Azure.PrimaryUri needs to be configured");
          string setting4 = MGASystems.IMS.NoteDocuments.SystemSettings.GetSetting<string>("DocStore.Azure.SecondaryUri", "DocStore.Azure.SecondaryUri needs to be configured");
          string setting5 = MGASystems.IMS.NoteDocuments.SystemSettings.GetSetting<string>("DocStore.Azure.ContainerName", "DocStore.Azure.ContainerName needs to be configured");
          try
          {
            Uri result = (Uri) null;
            AzureDocumentProvider documentProvider = !Uri.TryCreate(setting4, UriKind.Absolute, out result) ? new AzureDocumentProvider(new Uri(setting3), setting1, setting2, setting5) : new AzureDocumentProvider(new Uri(setting3), result, setting1, setting2, setting5);
            providers.Add(DocumentLocation.Azure, (IDocumentRepository) documentProvider);
          }
          catch (Exception ex1)
          {
            ProjectData.SetProjectError(ex1);
            Exception ex2 = ex1;
            ErrorHandler.SilentLogError(ex2);
            MGASystems.IMS.Logging.Log.Write($"Error creating AzureDocumentProvider: {ex2.Message}", "DocProvider");
            ProjectData.ClearProjectError();
          }
        }
        providers.Add(DocumentLocation.SQL, (IDocumentRepository) new SqlDocumentProvider());
        DocumentManager._documentRepository = (IDocumentRepository) new LocationAwareDocumentProvider(providers, (IMetadataProvider) new SqlMetadataProvider());
      }
      return DocumentManager._documentRepository;
    }
  }

  private static IDocumentReader DocumentReader
  {
    get => (IDocumentReader) DocumentManager.DocumentRepository;
  }

  private static IDocumentWriter DocumentWriter
  {
    get => (IDocumentWriter) DocumentManager.DocumentRepository;
  }

  public static byte[] GetDocumentBinary(
    Guid documentGuid,
    CancellationToken token,
    Action<int> callback = null)
  {
    return DocumentManager.DocumentReader.GetDocumentBinary(documentGuid, token, callback);
  }

  public static byte[] GetDocumentBinary(
    Metadata metadata,
    CancellationToken token,
    Action<int> callback = null)
  {
    return DocumentManager.DocumentReader.GetDocumentBinary(metadata, token, callback);
  }

  public static byte[] GetDocumentBinary(Guid documentGuid, Action<int> callback = null)
  {
    return DocumentManager.DocumentReader.GetDocumentBinary(documentGuid, callback: callback);
  }

  public static byte[] GetDocumentBinary(Metadata metadata, Action<int> callback = null)
  {
    return DocumentManager.DocumentReader.GetDocumentBinary(metadata, callback: callback);
  }

  public static Metadata GetDocumentMetadata(Guid documentGuid)
  {
    return DocumentManager.MetadataProvider.GetMetadata(documentGuid);
  }

  private static string InternalDownloadDoc(Guid documentGuid, ref int folderId)
  {
    Metadata documentMetadata = DocumentManager.GetDocumentMetadata(documentGuid);
    byte[] documentBinary = DocumentManager.GetDocumentBinary(documentMetadata);
    string str1;
    if (documentBinary != null)
    {
      string tempSubdirectory = MGATempFolder.CreateTempSubdirectory();
      string str2 = tempSubdirectory + documentMetadata.FileName;
      string str3 = tempSubdirectory + "TempZip.zip";
      if (documentMetadata.Compressed)
      {
        using (FileStream fileStream = new FileStream(str3, FileMode.Create))
          fileStream.Write(documentBinary, 0, documentBinary.Length);
        new ZipUtility().ExtractFilesFromZipArchive(str3, tempSubdirectory);
        File.Delete(str3);
        string[] files = Directory.GetFiles(tempSubdirectory);
        if (files.Length != 1)
          throw new InvalidOperationException("Should only have one file per zip");
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(files[0], str2, false) != 0)
          File.Move(files[0], str2);
      }
      else
      {
        try
        {
          using (FileStream fileStream = new FileStream(str2, FileMode.Create))
            fileStream.Write(documentBinary, 0, documentBinary.Length);
        }
        catch (IOException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          int num = (int) System.Windows.Forms.MessageBox.Show("This item is already open", "Cannot open two instances of the same document", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
          str1 = string.Empty;
          ProjectData.ClearProjectError();
          goto label_19;
        }
      }
      str1 = str2;
    }
    else
      str1 = string.Empty;
label_19:
    return str1;
  }

  public static void AbridgeDocument(Guid documentGuid)
  {
    int folderId = -1;
    string path = DocumentManager.InternalDownloadDoc(documentGuid, ref folderId);
    if (!string.IsNullOrEmpty(path) && File.Exists(path))
    {
      string fileName = path;
      FileInfo fileInfo = new FileInfo(fileName);
      DocumentManager.StartProcess(fileName);
      string str = $"{MGATempFolder.CreateTempSubdirectory()}{fileInfo.Name.Replace(fileInfo.Extension, "")}_Abridged{fileInfo.Extension}";
      using (frmAdobeSplitPages frmAdobeSplitPages = new frmAdobeSplitPages())
      {
        if (frmAdobeSplitPages.ShowDialog() == DialogResult.OK)
        {
          string[] strArray1 = frmAdobeSplitPages.AdobeSplitString.Split(",".ToCharArray());
          PdfFileEditor pdfFileEditor = new PdfFileEditor();
          List<int> intList = new List<int>();
          string[] strArray2 = strArray1;
          int index1 = 0;
          while (index1 < strArray2.Length)
          {
            string Expression = strArray2[index1];
            if (Versioned.IsNumeric((object) Expression))
              intList.Add(Conversions.ToInteger(Expression));
            else if (Expression.IndexOf("-") != -1)
            {
              string[] strArray3 = Expression.Split("-".ToCharArray());
              if (strArray3.Length == 2 && Versioned.IsNumeric((object) strArray3[0]) && Versioned.IsNumeric((object) strArray3[1]) && Conversions.ToInteger(strArray3[0]) < Conversions.ToInteger(strArray3[1]))
              {
                int integer1 = Conversions.ToInteger(strArray3[0]);
                int integer2 = Conversions.ToInteger(strArray3[1]);
                for (int index2 = integer1; index2 <= integer2; ++index2)
                  intList.Add(index2);
              }
            }
            else
            {
              int num = (int) System.Windows.Forms.MessageBox.Show($"Could not interpret {Expression}", "Unrecognized command", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            checked { ++index1; }
          }
          pdfFileEditor.Extract(fileName, intList.ToArray(), str);
          if (File.Exists(str))
          {
            if (new FileInfo(str).Length == 0L)
            {
              int num = (int) System.Windows.Forms.MessageBox.Show("The IMS is unable to add this document to the document handler, as it is either missing or empty.", "Unable to Add Document", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
              return;
            }
            Guid guid = DocumentManager.FileAdd(str);
            DefaultDatabase.ExecuteNonQuery("DocumentSystem_CopyAssociations", new object[4]
            {
              (object) "@DocumentStoreGuid",
              (object) documentGuid,
              (object) "@NewDocumentStoreGuid",
              (object) guid
            });
          }
          else
          {
            int num = (int) System.Windows.Forms.MessageBox.Show("The IMS is unable to add this document to the document handler, as it is either missing or empty.", "Unable to Add Document", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return;
          }
        }
      }
    }
    DocumentManager.FireEntityDocumentCollectionChanged();
    DocumentManager.FireUserDocumentCollectionChanged();
  }

  public static string InsertDocument(InsertPDFInfo insertInfo)
  {
    int folderId = -1;
    string str1 = DocumentManager.InternalDownloadDoc(insertInfo.InputFileGuid.Value, ref folderId);
    string str2 = insertInfo.OutsideFile;
    if (insertInfo.OutsideFileGuid.HasValue)
      str2 = DocumentManager.InternalDownloadDoc(insertInfo.OutsideFileGuid.Value, ref folderId);
    string str3 = "";
    if (str1.Length > 0 && File.Exists(str1))
    {
      FileInfo fileInfo = new FileInfo(str1);
      str3 = Path.Combine(MGATempFolder.CreateTempSubdirectory(), $"Insert{fileInfo.Name.Replace(fileInfo.Extension, "")}{fileInfo.Extension}");
      new PdfFileEditor().Insert(str1, insertInfo.InsertLocation, str2, insertInfo.StartPage, insertInfo.EndPage, str3);
    }
    return str3;
  }

  public static string ReplaceDocumentPages(ReplacePDFInfo replaceInfo)
  {
    int folderId = -1;
    string path = DocumentManager.InternalDownloadDoc(replaceInfo.SourceFileGuid.Value, ref folderId);
    string str1;
    if (replaceInfo.DocumentToInsertList.Count == 1)
    {
      str1 = replaceInfo.CanChooseLocalFiles ? replaceInfo.DocumentToInsertList[0].DocumentName : DocumentManager.InternalDownloadDoc(replaceInfo.DocumentToInsertList[0].DocumentGuid, ref folderId);
    }
    else
    {
      str1 = $"{MGATempFolder.MGATempPath}tmp{Guid.NewGuid().ToString().Substring(0, 8)}.pdf";
      List<string> stringList = new List<string>();
      try
      {
        foreach (SelectedDocInfo documentToInsert in (Collection<SelectedDocInfo>) replaceInfo.DocumentToInsertList)
        {
          if (replaceInfo.CanChooseLocalFiles)
            stringList.Add(documentToInsert.DocumentName);
          else
            stringList.Add(DocumentManager.InternalDownloadDoc(documentToInsert.DocumentGuid, ref folderId));
        }
      }
      finally
      {
        IEnumerator<SelectedDocInfo> enumerator;
        enumerator?.Dispose();
      }
      new PdfFileEditor().Concatenate(stringList.ToArray(), str1);
    }
    string str2 = "";
    if (path.Length > 0 && File.Exists(path))
    {
      string fileName = path;
      FileInfo fileInfo = new FileInfo(fileName);
      int num1 = 1;
      PdfFileEditor pdfFileEditor = new PdfFileEditor();
      List<string> stringList = new List<string>();
      try
      {
        foreach (string split in replaceInfo.GetSplitList())
        {
          string str3 = $"{MGATempFolder.CreateTempSubdirectory()}{fileInfo.Name.Replace(fileInfo.Extension, "")}_Part_{num1}{fileInfo.Extension}";
          int[] pages = DocumentManager.PageParser.ParsePages(split);
          if (pages.Length > 0)
          {
            try
            {
              pdfFileEditor.Extract(fileName, pages, str3);
            }
            catch (Exception ex)
            {
              ProjectData.SetProjectError(ex);
              if (ex.Message.Contains("count is 0"))
              {
                int num2 = (int) System.Windows.Forms.MessageBox.Show("After splitting this document, no pages were created.", "Unable to Split Document", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                ProjectData.ClearProjectError();
              }
              else
                throw;
            }
            stringList.Add(str3);
          }
          else
          {
            int num3 = (int) System.Windows.Forms.MessageBox.Show($"Could not interpret {split}", "Unrecognized command", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          }
          ++num1;
        }
      }
      finally
      {
        List<string>.Enumerator enumerator;
        enumerator.Dispose();
      }
      string[] array = stringList.ToArray();
      str2 = Path.Combine(MGATempFolder.CreateTempSubdirectory(), $"Replace{fileInfo.Name.Replace(fileInfo.Extension, "")}{fileInfo.Extension}");
      if (replaceInfo.ReplacePageStart == 1)
      {
        if (!pdfFileEditor.Concatenate(str1, array[1], str2))
          throw new InvalidOperationException();
      }
      else if (replaceInfo.ReplacePageEnd == replaceInfo.SourceFilePageCount)
      {
        if (!pdfFileEditor.Concatenate(array[0], str1, str2))
          throw new InvalidOperationException();
      }
      else
      {
        string str4 = Path.Combine(MGATempFolder.CreateTempSubdirectory(), $"ReplaceTemp{fileInfo.Name.Replace(fileInfo.Extension, "")}{fileInfo.Extension}");
        if (!pdfFileEditor.Concatenate(array[0], str1, str4))
          throw new InvalidOperationException();
        if (!pdfFileEditor.Concatenate(str4, array[2], str2))
          throw new InvalidOperationException();
      }
    }
    return str2;
  }

  public static int GetPageCount(Guid documentGuid)
  {
    int folderId = -1;
    return Utility.GetPDFPageCount(DocumentManager.InternalDownloadDoc(documentGuid, ref folderId));
  }

  public static void SplitDocument(Guid documentGuid)
  {
    int folderId = -1;
    string path = DocumentManager.InternalDownloadDoc(documentGuid, ref folderId);
    if (path.Length > 0 && File.Exists(path))
    {
      string fileName = path;
      FileInfo fileInfo = new FileInfo(fileName);
      new string[1][0] = fileName;
      DocumentManager.StartProcess(fileName);
      frmAdobeSplitPages frmAdobeSplitPages = (frmAdobeSplitPages) null;
      int num1 = 1;
      try
      {
        frmAdobeSplitPages = new frmAdobeSplitPages();
        if (frmAdobeSplitPages.ShowDialog() == DialogResult.OK)
        {
          string[] strArray1 = frmAdobeSplitPages.AdobeSplitString.Split(",".ToCharArray());
          PdfFileEditor pdfFileEditor = new PdfFileEditor();
          List<string> stringList = new List<string>();
          string[] strArray2 = strArray1;
          int index1 = 0;
          while (index1 < strArray2.Length)
          {
            string pages1 = strArray2[index1];
            string str = $"{MGATempFolder.CreateTempSubdirectory()}{fileInfo.Name.Replace(fileInfo.Extension, "")}_Part_{num1}{fileInfo.Extension}";
            int[] pages2 = DocumentManager.PageParser.ParsePages(pages1);
            if (pages2.Length > 0)
            {
              try
              {
                pdfFileEditor.Extract(fileName, pages2, str);
              }
              catch (Exception ex)
              {
                ProjectData.SetProjectError(ex);
                if (ex.Message.Contains("count is 0"))
                {
                  int num2 = (int) System.Windows.Forms.MessageBox.Show("After splitting this document, no pages were created.", "Unable to Split Document", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                  ProjectData.ClearProjectError();
                }
                else
                  throw;
              }
              stringList.Add(str);
            }
            else
            {
              int num3 = (int) System.Windows.Forms.MessageBox.Show($"Could not interpret {pages1}", "Unrecognized command", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            ++num1;
            checked { ++index1; }
          }
          string[] array = stringList.ToArray();
          int index2 = 0;
          while (index2 < array.Length)
          {
            Guid guid = DocumentManager.FileAdd(array[index2]);
            DefaultDatabase.ExecuteNonQuery("DocumentSystem_CopyAssociations", new object[4]
            {
              (object) "@DocumentStoreGuid",
              (object) documentGuid,
              (object) "@NewDocumentStoreGuid",
              (object) guid
            });
            checked { ++index2; }
          }
        }
      }
      finally
      {
        frmAdobeSplitPages?.Dispose();
      }
    }
    DocumentManager.FireEntityDocumentCollectionChanged();
    DocumentManager.FireUserDocumentCollectionChanged();
  }

  public static Guid FileAddWithBind(string path, ISupportDocumentSystem docSupport)
  {
    return DocumentManager.FileAddWithBind(path, -1, string.Empty, docSupport, false);
  }

  public static Guid FileAddWithBind(string path, int folderId, ISupportDocumentSystem docSupport)
  {
    return DocumentManager.FileAddWithBind(path, folderId, string.Empty, docSupport, false);
  }

  public static Guid FileAddWithBind(
    string path,
    int folderId,
    string description,
    ISupportDocumentSystem docSupport)
  {
    return DocumentManager.FileAddWithBind(path, folderId, description, docSupport, false);
  }

  public static Guid FileAddWithBind(
    string path,
    ISupportDocumentSystem docSupport,
    bool deleteFileAfterUpload)
  {
    return DocumentManager.FileAddWithBind(path, -1, string.Empty, docSupport, deleteFileAfterUpload);
  }

  public static Guid FileAddWithBind(
    string path,
    ISupportDocumentSystem docSupport,
    string context)
  {
    return DocumentManager.FileAddWithBind(path, -1, string.Empty, docSupport, false, context);
  }

  public static Guid FileAddWithBind(
    string path,
    int folderId,
    ISupportDocumentSystem docSupport,
    string context)
  {
    return DocumentManager.FileAddWithBind(path, folderId, string.Empty, docSupport, false, context);
  }

  public static Guid FileAddWithBind(
    string path,
    int folderId,
    string description,
    ISupportDocumentSystem docSupport,
    string context)
  {
    return DocumentManager.FileAddWithBind(path, folderId, description, docSupport, false, context);
  }

  public static Guid FileAddWithBind(
    string path,
    ISupportDocumentSystem docSupport,
    bool deleteFileAfterUpload,
    string context)
  {
    return DocumentManager.FileAddWithBind(path, -1, string.Empty, docSupport, deleteFileAfterUpload, context);
  }

  public static Guid FileAddWithBind(
    string path,
    int folderId,
    string description,
    ISupportDocumentSystem docSupport,
    bool deleteFileAfterUpload)
  {
    return DocumentManager.FileAddWithBind(path, folderId, description, docSupport, deleteFileAfterUpload, string.Empty);
  }

  public static Guid FileAddWithBind(
    string path,
    int folderId,
    string description,
    ISupportDocumentSystem docSupport,
    bool deleteFileAfterUpload,
    string context)
  {
    return DocumentManager.BeginFileAddWithBind((DocumentManager.FileAddedAndBound) null, path, folderId, description, docSupport, deleteFileAfterUpload, context, false);
  }

  public static Guid FileAdd(string path)
  {
    return DocumentManager.FileAddWithBind(path, -1, string.Empty, (ISupportDocumentSystem) null, false);
  }

  public static Guid FileAddWithBind(string path)
  {
    return DocumentManager.FileAddWithBind(path, -1, string.Empty, (ISupportDocumentSystem) null, false);
  }

  public static Guid FileAddWithBind(string path, int folderId)
  {
    return DocumentManager.FileAddWithBind(path, folderId, string.Empty, (ISupportDocumentSystem) null, false);
  }

  public static Guid FileAddWithBind(string path, int folderId, string description)
  {
    return DocumentManager.FileAddWithBind(path, folderId, description, (ISupportDocumentSystem) null, false);
  }

  public static Guid FileAddWithBind(string path, bool deleteFileAfterUpload)
  {
    return DocumentManager.FileAddWithBind(path, -1, string.Empty, (ISupportDocumentSystem) null, deleteFileAfterUpload);
  }

  public static Guid FileAddWithBind(
    string path,
    int folderId,
    string description,
    bool deleteFileAfterUpload)
  {
    return DocumentManager.FileAddWithBind(path, folderId, description, (ISupportDocumentSystem) null, deleteFileAfterUpload);
  }

  private static string[] DownloadFiles(Guid[] downloadGuids)
  {
    List<string> stringList = new List<string>();
    Guid[] guidArray = downloadGuids;
    int index = 0;
    while (index < guidArray.Length)
    {
      Guid documentGuid = guidArray[index];
      int num = -1;
      ref int local = ref num;
      string path = DocumentManager.InternalDownloadDoc(documentGuid, ref local);
      if (File.Exists(path))
        stringList.Add(path);
      checked { ++index; }
    }
    return stringList.ToArray();
  }

  internal static void ConcatenateAdobeDocuments(
    TabDocumentPanel.FileNode[] adobeFileNodes,
    ISupportDocumentSystem entity = null)
  {
    if (adobeFileNodes.Length < 2)
      return;
    adobeConcatenationForm concatenationForm = new adobeConcatenationForm(adobeFileNodes);
    try
    {
      if (concatenationForm.ShowDialog() != DialogResult.OK)
        return;
      TabDocumentPanel.FileNode[] fileNodesToDownload = concatenationForm.GetFileNodesToDownload();
      string newFileName = concatenationForm.NewFileName;
      if (!newFileName.ToUpper().EndsWith(".PDF"))
        newFileName += ".pdf";
      List<Guid> guidList = new List<Guid>();
      TabDocumentPanel.FileNode[] fileNodeArray = fileNodesToDownload;
      int index1 = 0;
      while (index1 < fileNodeArray.Length)
      {
        TabDocumentPanel.FileNode fileNode = fileNodeArray[index1];
        guidList.Add(fileNode.DocumentGUID);
        checked { ++index1; }
      }
      PdfFileEditor pdfFileEditor = new PdfFileEditor();
      string tempSubdirectory = MGATempFolder.CreateTempSubdirectory();
      string str1 = $"{tempSubdirectory}{newFileName}";
      string[] strArray = DocumentManager.DownloadFiles(guidList.ToArray());
      try
      {
        string sourceFileName = $"{tempSubdirectory}0.pdf";
        int num = strArray.Length - 1;
        for (int index2 = 1; index2 <= num; ++index2)
        {
          sourceFileName = $"{tempSubdirectory}{index2}.pdf";
          if (index2 == 1)
          {
            if (!pdfFileEditor.Concatenate(strArray[index2 - 1], strArray[index2], sourceFileName))
              throw new InvalidOperationException();
          }
          else
          {
            string str2 = $"{tempSubdirectory}{index2 - 1}.pdf";
            if (!pdfFileEditor.Concatenate(str2, strArray[index2], sourceFileName))
              throw new InvalidOperationException();
          }
        }
        File.Move(sourceFileName, str1);
        if (entity == null)
          DocumentManager.FileAdd(str1);
        else
          DocumentManager.FileAddWithBind(str1, entity);
        try
        {
          Directory.Delete(tempSubdirectory, true);
        }
        catch (IOException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          ProjectData.ClearProjectError();
        }
      }
      catch (InvalidOperationException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        if (ex.Message.Contains("Document image length cannot be 0"))
        {
          int num = (int) System.Windows.Forms.MessageBox.Show("The concatenation process resulted in an empty PDF.", "Zero-Length PDF", MessageBoxButtons.OK, MessageBoxIcon.Hand);
          ProjectData.ClearProjectError();
        }
        else
          throw;
      }
      DocumentManager.FireEntityDocumentCollectionChanged();
      DocumentManager.FireUserDocumentCollectionChanged();
    }
    finally
    {
      concatenationForm.Dispose();
    }
  }

  public static void BeginFileAdd(string path)
  {
    DocumentManager.BeginFileAdd((DocumentManager.FileAddedAndBound) null, path, -1, string.Empty, false);
  }

  public static void BeginFileAdd(string path, int folderId)
  {
    DocumentManager.BeginFileAdd((DocumentManager.FileAddedAndBound) null, path, folderId, string.Empty, false);
  }

  public static void BeginFileAdd(string path, int folderId, string description)
  {
    DocumentManager.BeginFileAdd((DocumentManager.FileAddedAndBound) null, path, folderId, description, false);
  }

  public static void BeginFileAdd(
    DocumentManager.FileAddedAndBound fileAdded,
    string path,
    int folderId,
    string description)
  {
    DocumentManager.BeginFileAdd(fileAdded, path, folderId, description, false);
  }

  public static void BeginFileAdd(string path, bool deleteFileAfterUpload)
  {
    DocumentManager.BeginFileAdd((DocumentManager.FileAddedAndBound) null, path, -1, string.Empty, deleteFileAfterUpload);
  }

  public static void BeginFileAdd(string path, int folderId, bool deleteFileAfterUpload)
  {
    DocumentManager.BeginFileAdd((DocumentManager.FileAddedAndBound) null, path, folderId, string.Empty, deleteFileAfterUpload);
  }

  public static void BeginFileAdd(
    string path,
    int folderId,
    string description,
    bool deleteFileAfterUpload)
  {
    DocumentManager.BeginFileAdd((DocumentManager.FileAddedAndBound) null, path, folderId, description, deleteFileAfterUpload);
  }

  public static void BeginFileAdd(
    DocumentManager.FileAddedAndBound fileAdded,
    string path,
    int folderId,
    string description,
    bool deleteFileAfterUpload)
  {
    DocumentManager.BeginFileAddWithBind(fileAdded, path, folderId, description, (ISupportDocumentSystem) null, deleteFileAfterUpload);
  }

  public static void BindDocument(Guid documentGuid, ISupportDocumentSystem docSupport)
  {
    DocumentManager.BindDocument(documentGuid, docSupport, false);
  }

  public static void BindDocument(
    Guid documentGuid,
    ISupportDocumentSystem docSupport,
    bool disableCollectionChangedEvent)
  {
    ISupportDocumentSystem supportDocumentSystem = docSupport;
    DocumentManager.BindDocument(documentGuid, supportDocumentSystem.AllowAddNewDocument, supportDocumentSystem.CanReCreateEntity, supportDocumentSystem.EntityGuid, supportDocumentSystem.EntityName, supportDocumentSystem.FriendlyEntityName, supportDocumentSystem.RecreateTypeName, supportDocumentSystem.HasControlGUID, supportDocumentSystem.ControlGUID, disableCollectionChangedEvent);
  }

  public static void BindDocument(
    Guid documentGuid,
    bool allowAddNewDocument,
    bool canReCreateEntity,
    Guid entityGuid,
    string entityName,
    string friendlyEntityName,
    string recreateTypeName,
    bool hasControlGUID,
    Guid controlGUID)
  {
    DocumentManager.BindDocument(documentGuid, allowAddNewDocument, canReCreateEntity, entityGuid, entityName, friendlyEntityName, recreateTypeName, hasControlGUID, controlGUID, false);
  }

  public static void BindDocument(
    Guid documentGuid,
    bool allowAddNewDocument,
    bool canReCreateEntity,
    Guid entityGuid,
    string entityName,
    string friendlyEntityName,
    string recreateTypeName,
    bool hasControlGUID,
    Guid controlGUID,
    bool disableCollectionChangedEvent)
  {
    if (DefaultDatabase.ExecuteScalar<int>(CommandType.Text, "SELECT COUNT(*) FROM tblDocumentAssociations (NOLOCK) WHERE DocumentStoreGuid = @DocumentStoreGuid AND AssociatedEntityGuid = @AssociatedEntityGuid", new object[4]
    {
      (object) "@DocumentStoreGuid",
      (object) documentGuid,
      (object) "@AssociatedEntityGuid",
      (object) entityGuid
    }) != 0)
      return;
    if (canReCreateEntity)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(recreateTypeName, string.Empty, false) == 0)
        throw new ArgumentException("RecreateTypeName can not be empty on an item that returns true for CanReCreateEntity");
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(entityName, string.Empty, false) == 0)
        throw new ArgumentException("EntityName can not be empty on an item that returns true for CanReCreateEntity");
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(friendlyEntityName, string.Empty, false) == 0)
        throw new ArgumentException("FriendlyEntityName can not be empty on an item that returns true for CanReCreateEntity");
    }
    DefaultDatabase.ExecuteNonQuery("DocumentSystem_InsertDocumentAssociation", new object[12]
    {
      (object) "@DocumentStoreGuid",
      (object) documentGuid,
      (object) "@AssociatedEntityGuid",
      (object) entityGuid,
      (object) "@AssociatedEntityType",
      (object) recreateTypeName,
      (object) "@AssociatedEntityName",
      (object) entityName,
      (object) "@AssociatedEntityFormName",
      (object) friendlyEntityName,
      (object) "@ControlGUID",
      Interaction.IIf(hasControlGUID, (object) controlGUID, (object) DBNull.Value)
    });
    DocumentManager.SendDocumentBoundBroadcastMessage(documentGuid, entityGuid, recreateTypeName, entityName, friendlyEntityName, new Guid?(hasControlGUID ? controlGUID : new Guid()));
    if (disableCollectionChangedEvent)
      return;
    DocumentManager.FireEntityDocumentCollectionChanged();
    DocumentManager.FireUserDocumentCollectionChanged();
  }

  internal static void SendDocumentBoundBroadcastMessage(
    Guid documentGuid,
    Guid entityGuid,
    string recreateTypeName,
    string entityName,
    string friendlyEntityName,
    Guid? controlGuid)
  {
    DocumentBoundContext context = new DocumentBoundContext(documentGuid, entityGuid, recreateTypeName, entityName, friendlyEntityName, controlGuid);
    Messaging.SendBroadcastMessage(BroadcastMessages.DocumentBound, (object) context);
  }

  public static void BeginBindDocument(
    Guid documentGuid,
    bool allowAddNewDocument,
    bool canReCreateEntity,
    Guid entityGuid,
    string entityName,
    string friendlyEntityName,
    string recreateTypeName,
    bool hasControlGUID,
    Guid controlGUID)
  {
    if (DefaultDatabase.ExecuteScalar<int>(CommandType.Text, "SELECT COUNT(*) FROM tblDocumentAssociations (NOLOCK) WHERE DocumentStoreGuid = @DocumentStoreGuid AND AssociatedEntityGuid = @AssociatedEntityGuid", new object[4]
    {
      (object) "@DocumentStoreGuid",
      (object) documentGuid,
      (object) "@AssociatedEntityGuid",
      (object) entityGuid
    }) != 0)
      return;
    if (canReCreateEntity)
    {
      if (string.IsNullOrEmpty(recreateTypeName))
        throw new ArgumentException("RecreateTypeName can not be empty on an item that returns true for CanReCreateEntity");
      if (string.IsNullOrEmpty(entityName))
        throw new ArgumentException("EntityName can not be empty on an item that returns true for CanReCreateEntity");
      if (string.IsNullOrEmpty(friendlyEntityName))
        throw new ArgumentException("FriendlyEntityName can not be empty on an item that returns true for CanReCreateEntity");
    }
    Database.Instance.QueryMultithreadedSP.PerformNonQuery(MGASystems.IMS.NoteDocuments.Common.UIContext, (object) new object[2]
    {
      (object) documentGuid,
      (object) entityGuid
    }, "DocumentSystem_InsertDocumentAssociation", new NonQueryMultithreadEventHandler(DocumentManager.BeginBindDocument_NonQueryCompleted), (object) "@DocumentStoreGuid", (object) documentGuid, (object) "@AssociatedEntityGuid", (object) entityGuid, (object) "@AssociatedEntityType", (object) recreateTypeName, (object) "@AssociatedEntityName", (object) entityName, (object) "@AssociatedEntityFormName", (object) friendlyEntityName, (object) "@ControlGUID", Interaction.IIf(hasControlGUID, (object) controlGUID, (object) DBNull.Value));
    DocumentManager.SendDocumentBoundBroadcastMessage(documentGuid, entityGuid, recreateTypeName, entityName, friendlyEntityName, new Guid?(hasControlGUID ? controlGUID : new Guid()));
    CurrentUser.Instance.LogAction($"Bind \"{new Document(documentGuid).Description}\" to {entityName}.", entityGuid);
  }

  public static void BeginBindDocument(Guid documentGuid, ISupportDocumentSystem docSupport)
  {
    ISupportDocumentSystem supportDocumentSystem = docSupport;
    if (docSupport.HasControlGUID)
      DocumentManager.BeginBindDocument(documentGuid, supportDocumentSystem.AllowAddNewDocument, supportDocumentSystem.CanReCreateEntity, supportDocumentSystem.EntityGuid, supportDocumentSystem.EntityName, supportDocumentSystem.FriendlyEntityName, supportDocumentSystem.RecreateTypeName, supportDocumentSystem.HasControlGUID, supportDocumentSystem.ControlGUID);
    else
      DocumentManager.BeginBindDocument(documentGuid, supportDocumentSystem.AllowAddNewDocument, supportDocumentSystem.CanReCreateEntity, supportDocumentSystem.EntityGuid, supportDocumentSystem.EntityName, supportDocumentSystem.FriendlyEntityName, supportDocumentSystem.RecreateTypeName, supportDocumentSystem.HasControlGUID, new Guid());
  }

  private static void BeginBindDocument_NonQueryCompleted(
    object sender,
    NonQueryMultithreadEventArgs e)
  {
    DocumentManager.FireEntityDocumentCollectionChanged();
    DocumentManager.FireUserDocumentCollectionChanged();
  }

  public static void ReassignDocument(Guid docGUID, Guid newOwnerUser)
  {
    DefaultDatabase.ExecuteNonQuery(CommandType.Text, "UPDATE tblDocumentStore SET UserGUIDOriginator = @UserGUID WHERE DocumentStoreGUID = @DocumentStoreGUID", new object[4]
    {
      (object) "@UserGUID",
      (object) newOwnerUser,
      (object) "@DocumentStoreGUID",
      (object) docGUID
    });
    Document document = new Document(docGUID);
    CurrentUser.Instance.LogAction($"Reassign document to {DefaultDatabase.ExecuteScalar<string>(CommandType.StoredProcedure, "spGetReassignUser", new object[2]
    {
      (object) "@UserGuid",
      (object) newOwnerUser
    })} -{document.Description}");
  }

  public static void UnbindDocument(Guid documentGuid, Guid entityGuid)
  {
    if (!DefaultDatabase.ExecuteScalar<bool>(CommandType.Text, "SELECT dbo.DocumentExists(@DocumentStoreGuid, @AssociatedEntityGuid, NULL)", new object[4]
    {
      (object) "@DocumentStoreGuid",
      (object) documentGuid,
      (object) "@AssociatedEntityGuid",
      (object) entityGuid
    }))
      return;
    if (!DocumentManager.DisassocatedAllDocuments(documentGuid, (IRecreatableEntity) null, new Guid?(entityGuid)))
    {
      DefaultDatabase.ExecuteNonQuery(CommandType.Text, "DELETE FROM tblDocumentAssociations WHERE DocumentStoreGuid = @DocumentStoreGuid AND AssociatedEntityGuid = @AssociatedEntityGuid", new object[4]
      {
        (object) "@DocumentStoreGuid",
        (object) documentGuid,
        (object) "@AssociatedEntityGuid",
        (object) entityGuid
      });
      DocumentManager.ReassignOrPinDocumentToCurrentUser(documentGuid);
    }
    DocumentManager.SendUnbindMessage(documentGuid, entityGuid);
    CurrentUser.Instance.LogAction($"Dissasociate Document: \"{new Document(documentGuid).Description}\"", entityGuid);
  }

  internal static void UnbindDocument(
    Guid documentGuid,
    IRecreatableEntity docSupport,
    bool disableTreeRefresh)
  {
    if (DefaultDatabase.ExecuteScalar<int>(CommandType.Text, "SELECT COUNT(*) FROM tblDocumentAssociations (NOLOCK) WHERE DocumentStoreGuid = @DocumentStoreGuid AND AssociatedEntityGuid = @AssociatedEntityGuid", new object[4]
    {
      (object) "@DocumentStoreGuid",
      (object) documentGuid,
      (object) "@AssociatedEntityGuid",
      (object) docSupport.EntityGuid
    }) > 0)
    {
      if (!DocumentManager.DisassocatedAllDocuments(documentGuid, docSupport, new Guid?()))
        DefaultDatabase.ExecuteNonQuery(CommandType.Text, "DELETE FROM tblDocumentAssociations WHERE DocumentStoreGuid = @DocumentStoreGuid AND AssociatedEntityGuid = @AssociatedEntityGuid", new object[4]
        {
          (object) "@DocumentStoreGuid",
          (object) documentGuid,
          (object) "@AssociatedEntityGuid",
          (object) docSupport.EntityGuid
        });
      DocumentManager.SendUnbindMessage(documentGuid, docSupport.EntityGuid);
      CurrentUser.Instance.LogAction($"Unbind Document - \"{new Document(documentGuid).Description}\"", docSupport.EntityGuid);
      if (DefaultDatabase.ExecuteScalar<int>(CommandType.Text, "SELECT COUNT(*) FROM tblDocumentAssociations (NOLOCK) WHERE DocumentStoreGUID = @DocumentStoreGUID", new object[2]
      {
        (object) "@DocumentStoreGUID",
        (object) documentGuid
      }) == 0)
      {
        if (!DocumentManager.GetDocumentMetadata(documentGuid).UserGuidOriginator.Equals(MGASystems.IMS.NoteDocuments.Common.UserGUID))
          DocumentManager.ReassignDocument(documentGuid, MGASystems.IMS.NoteDocuments.Common.UserGUID);
      }
      else
      {
        int num = (int) System.Windows.Forms.MessageBox.Show("This document still has other associations, it will be 'pinned' into your disassociated documents.", "Remaining Associations", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        DocumentManager.PinDocument(documentGuid);
      }
    }
    if (DefaultDatabase.ExecuteScalar<bool>(CommandType.Text, "SELECT dbo.DocumentExists(@DocumentStoreGuid, @AssociatedEntityGuid, NULL)", new object[4]
    {
      (object) "@DocumentStoreGuid",
      (object) documentGuid,
      (object) "@AssociatedEntityGuid",
      (object) docSupport.EntityGuid
    }))
    {
      if (!DocumentManager.DisassocatedAllDocuments(documentGuid, (IRecreatableEntity) null, new Guid?(docSupport.EntityGuid)))
        Database.Instance.QueryMultithreadedText.PerformNonQuery(MGASystems.IMS.NoteDocuments.Common.UIContext, (object) documentGuid, "DELETE FROM tblDocumentAssociations WHERE DocumentStoreGuid = @DocumentStoreGuid AND AssociatedEntityGuid = @AssociatedEntityGuid", new NonQueryMultithreadEventHandler(DocumentManager.UnbindDocument_NonQueryCompleted), (object) "@DocumentStoreGuid", (object) documentGuid, (object) "@AssociatedEntityGuid", (object) docSupport.EntityGuid);
      DocumentManager.SendUnbindMessage(documentGuid, docSupport.EntityGuid);
      CurrentUser.Instance.LogAction($"Unbind Document - \"{new Document(documentGuid).Description}\"", docSupport.EntityGuid);
    }
    if (docSupport.HasControlGUID)
    {
      if (DefaultDatabase.ExecuteScalar<bool>(CommandType.Text, "SELECT dbo.DocumentExists(@DocumentStoreGuid, NULL, @ControlGuid)", new object[4]
      {
        (object) "@DocumentStoreGuid",
        (object) documentGuid,
        (object) "@ControlGuid",
        (object) docSupport.ControlGUID
      }))
      {
        if (!DocumentManager.DisassocatedAllDocuments(documentGuid, docSupport, new Guid?()))
          Database.Instance.QueryMultithreadedText.PerformNonQuery(MGASystems.IMS.NoteDocuments.Common.UIContext, (object) documentGuid, "DELETE FROM tblDocumentAssociations WHERE DocumentStoreGuid = @DocumentStoreGuid AND ControlGuid = @ControlGuid", new NonQueryMultithreadEventHandler(DocumentManager.UnbindDocument_NonQueryCompleted), (object) "@DocumentStoreGuid", (object) documentGuid, (object) "@ControlGuid", (object) docSupport.ControlGUID);
        DocumentManager.SendUnbindMessage(documentGuid, docSupport.ControlGUID);
        CurrentUser.Instance.LogAction($"Unbind Document - \"{new Document(documentGuid).Description}\"", docSupport.EntityGuid);
      }
    }
    if (disableTreeRefresh)
      return;
    DocumentManager.FireUserDocumentCollectionChanged();
    DocumentManager.FireEntityDocumentCollectionChanged();
  }

  public static void BeginUnbindDocument(Guid documentGuid, IRecreatableEntity docSupport)
  {
    if (docSupport == null)
      throw new ArgumentNullException(nameof (docSupport));
    if (Utility.IsNull<int>((object) DefaultDatabase.ExecuteScalar<int?>(CommandType.Text, "SELECT COUNT(*) FROM tblDocumentAssociations (NOLOCK) WHERE DocumentStoreGuid = @DocumentStoreGuid AND AssociatedEntityGuid = @AssociatedEntityGuid", new object[4]
    {
      (object) "@DocumentStoreGuid",
      (object) documentGuid,
      (object) "@AssociatedEntityGuid",
      (object) docSupport.EntityGuid
    }), 0) > 0)
    {
      if (!DocumentManager.DisassocatedAllDocuments(documentGuid, docSupport, new Guid?()))
        Database.Instance.QueryMultithreadedText.PerformNonQuery(MGASystems.IMS.NoteDocuments.Common.UIContext, (object) documentGuid, "DELETE FROM tblDocumentAssociations WHERE DocumentStoreGuid = @DocumentStoreGuid AND AssociatedEntityGuid = @AssociatedEntityGuid", new NonQueryMultithreadEventHandler(DocumentManager.UnbindDocument_NonQueryCompleted), (object) "@DocumentStoreGuid", (object) documentGuid, (object) "@AssociatedEntityGuid", (object) docSupport.EntityGuid);
      DocumentManager.SendUnbindMessage(documentGuid, docSupport.EntityGuid);
    }
    if (DefaultDatabase.ExecuteScalar<bool>(CommandType.Text, "SELECT dbo.DocumentExists(@DocumentStoreGuid, @AssociatedEntityGuid, NULL)", new object[4]
    {
      (object) "@DocumentStoreGuid",
      (object) documentGuid,
      (object) "@AssociatedEntityGuid",
      (object) docSupport.EntityGuid
    }))
    {
      if (!DocumentManager.DisassocatedAllDocuments(documentGuid, (IRecreatableEntity) null, new Guid?(docSupport.EntityGuid)))
        Database.Instance.QueryMultithreadedText.PerformNonQuery(MGASystems.IMS.NoteDocuments.Common.UIContext, (object) documentGuid, "DELETE FROM tblDocumentAssociations WHERE DocumentStoreGuid = @DocumentStoreGuid AND AssociatedEntityGuid = @AssociatedEntityGuid", new NonQueryMultithreadEventHandler(DocumentManager.UnbindDocument_NonQueryCompleted), (object) "@DocumentStoreGuid", (object) documentGuid, (object) "@AssociatedEntityGuid", (object) docSupport.EntityGuid);
      DocumentManager.SendUnbindMessage(documentGuid, docSupport.EntityGuid);
      CurrentUser.Instance.LogAction($"Unbind Document - \"{new Document(documentGuid).Description}\"", docSupport.EntityGuid);
    }
    if (!docSupport.HasControlGUID)
      return;
    if (!Database.Instance.QueryText.PerformScalarQueryBool("SELECT dbo.DocumentExists(@DocumentStoreGuid, NULL, @ControlGuid)", (object) "@DocumentStoreGuid", (object) documentGuid, (object) "@ControlGuid", (object) docSupport.ControlGUID))
      return;
    if (!DocumentManager.DisassocatedAllDocuments(documentGuid, docSupport, new Guid?()))
      Database.Instance.QueryMultithreadedText.PerformNonQuery(MGASystems.IMS.NoteDocuments.Common.UIContext, (object) documentGuid, "DELETE FROM tblDocumentAssociations WHERE DocumentStoreGuid = @DocumentStoreGuid AND ControlGuid = @ControlGuid", new NonQueryMultithreadEventHandler(DocumentManager.UnbindDocument_NonQueryCompleted), (object) "@DocumentStoreGuid", (object) documentGuid, (object) "@ControlGuid", (object) docSupport.ControlGUID);
    DocumentManager.SendUnbindMessage(documentGuid, docSupport.ControlGUID);
    CurrentUser.Instance.LogAction($"Unbind Document - \"{new Document(documentGuid).Description}\"", docSupport.EntityGuid);
  }

  public static void BeginUnbindDocument(Guid documentGuid, Guid entityGuid)
  {
    if (!DefaultDatabase.ExecuteScalar<bool>(CommandType.Text, "SELECT dbo.DocumentExists(@DocumentStoreGuid, @AssociatedEntityGuid, NULL)", new object[4]
    {
      (object) "@DocumentStoreGuid",
      (object) documentGuid,
      (object) "@AssociatedEntityGuid",
      (object) entityGuid
    }))
      return;
    if (!DocumentManager.DisassocatedAllDocuments(documentGuid, (IRecreatableEntity) null, new Guid?(entityGuid)))
      Database.Instance.QueryMultithreadedText.PerformNonQuery(MGASystems.IMS.NoteDocuments.Common.UIContext, (object) documentGuid, "DELETE FROM tblDocumentAssociations WHERE DocumentStoreGuid = @DocumentStoreGuid AND AssociatedEntityGuid = @AssociatedEntityGuid", new NonQueryMultithreadEventHandler(DocumentManager.UnbindDocument_NonQueryCompleted), (object) "@DocumentStoreGuid", (object) documentGuid, (object) "@AssociatedEntityGuid", (object) entityGuid);
    DocumentManager.SendUnbindMessage(documentGuid, entityGuid);
    CurrentUser.Instance.LogAction($"Dissasociate Document: \"{new Document(documentGuid).Description}\"", entityGuid);
  }

  private static void UnbindDocument_NonQueryCompleted(
    object sender,
    NonQueryMultithreadEventArgs e)
  {
    DocumentManager.ReassignOrPinDocumentToCurrentUser((Guid) e.Key);
  }

  private static void ReassignOrPinDocumentToCurrentUser(Guid documentGuid)
  {
    if (!DefaultDatabase.ExecuteScalar<bool>(CommandType.Text, "SELECT dbo.DocumentExists(@DocumentStoreGUID,NULL,NULL)", new object[2]
    {
      (object) "@DocumentStoreGUID",
      (object) documentGuid
    }))
    {
      if (!DocumentManager.GetDocumentMetadata(documentGuid).UserGuidOriginator.Equals(MGASystems.IMS.NoteDocuments.Common.UserGUID))
        DocumentManager.ReassignDocument(documentGuid, MGASystems.IMS.NoteDocuments.Common.UserGUID);
    }
    else
    {
      int num = (int) System.Windows.Forms.MessageBox.Show("This document still has other associations, it will be 'pinned' into your disassociated documents.", "Remaining Associations", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      DocumentManager.PinDocument(documentGuid);
    }
    DocumentManager.FireUserDocumentCollectionChanged();
    DocumentManager.FireEntityDocumentCollectionChanged();
  }

  private static bool DisassocatedAllDocuments(
    Guid documentGuid,
    IRecreatableEntity docSupport,
    Guid? entityGuid)
  {
    bool flag = false;
    Guid? nullable = new Guid?();
    if (MGASystems.IMS.NoteDocuments.SystemSettings.GetSetting<bool>("DocumentSystem.ShowCopyToOtherCards", false))
    {
      if (docSupport != null)
      {
        if (docSupport.HasControlGUID && docSupport != null)
          nullable = new Guid?(DefaultDatabase.ExecuteScalar<Guid>(CommandType.Text, "SELECT TOP 1 SubmissionGroupGuid FROM tblQuotes WITH (nolock) WHERE ControlGuid = @ControlGuid", new object[2]
          {
            (object) "@ControlGuid",
            (object) docSupport.ControlGUID
          }));
      }
      else
        nullable = new Guid?(DefaultDatabase.ExecuteScalar<Guid>(CommandType.Text, "SELECT TOP 1 SubmissionGroupGuid FROM tblDocumentAssociations WITH (nolock) WHERE AssociatedEntityGuid = @entityGuid OR ControlGuid = @entityGuid", new object[2]
        {
          (object) "@entityGuid",
          (object) entityGuid
        }));
      if (nullable.HasValue)
      {
        Guid empty = Guid.Empty;
        if ((nullable.HasValue ? new bool?(nullable.GetValueOrDefault() != empty) : new bool?()).GetValueOrDefault())
        {
          if (DefaultDatabase.ExecuteScalar<int>(CommandType.Text, "SELECT COUNT(*) FROM tblDocumentAssociations WHERE DocumentStoreGuid = @docGuid AND SubmissionGroupGuid = @SubmissionGroupGuid", new object[4]
          {
            (object) "@docGuid",
            (object) documentGuid,
            (object) "@SubmissionGroupGuid",
            (object) nullable
          }) > 1)
          {
            Metadata documentMetadata = DocumentManager.GetDocumentMetadata(documentGuid);
            if (System.Windows.Forms.MessageBox.Show($"The document '{(string.IsNullOrEmpty(documentMetadata.Description) ? (object) documentMetadata.FileName : (object) documentMetadata.Description)}' is associated to other policies on this submission.  Would you like to disassociate from all policies under this submission?", "Disassociate All", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
            {
              DefaultDatabase.ExecuteNonQuery(CommandType.Text, "DELETE FROM tblDocumentAssociations WHERE DocumentStoreGuid = @DocumentStoreGuid AND SubmissionGroupGuid = @SubmissionGroupGuid", new object[4]
              {
                (object) "@DocumentStoreGuid",
                (object) documentGuid,
                (object) "@SubmissionGroupGuid",
                (object) nullable
              });
              DocumentManager.FireUserDocumentCollectionChanged();
              DocumentManager.FireEntityDocumentCollectionChanged();
              flag = true;
            }
          }
        }
      }
    }
    return flag;
  }

  public static bool ProcessDragDrop(DragEventArgs e)
  {
    if (e == null)
      throw new ArgumentNullException(nameof (e));
    bool flag;
    if (e.Data.GetDataPresent("Outlook.Message", false))
    {
      FileInfo[] data = (FileInfo[]) e.Data.GetData("Outlook.Message");
      int index = 0;
      while (index < data.Length)
      {
        DocumentManager.BeginFileAdd(data[index].FullName);
        checked { ++index; }
      }
      flag = true;
    }
    else if (e.Data.GetDataPresent("Outlook.Attachment", false))
    {
      FileInfo[] data = (FileInfo[]) e.Data.GetData("Outlook.Attachment");
      int index = 0;
      while (index < data.Length)
      {
        DocumentManager.BeginFileAdd(data[index].FullName);
        checked { ++index; }
      }
      flag = true;
    }
    else if (e.Data.GetDataPresent(DataFormats.FileDrop, false))
    {
      string[] data = (string[]) e.Data.GetData(DataFormats.FileDrop);
      int index = 0;
      while (index < data.Length)
      {
        DocumentManager.BeginFileAdd(data[index]);
        checked { ++index; }
      }
      flag = true;
    }
    else
      flag = false;
    return flag;
  }

  public static DragDropEffects ProcessDragOver(DragEventArgs e)
  {
    if (e == null)
      throw new ArgumentNullException(nameof (e));
    e.Effect = e.Data.GetDataPresent("Outlook.Attachment", false) || e.Data.GetDataPresent("Outlook.Message", false) || e.Data.GetDataPresent("System.Guid", false) || e.Data.GetDataPresent(DataFormats.FileDrop, false) ? DragDropEffects.All : DragDropEffects.None;
    return e.Effect;
  }

  public static void BeginRenameDocument(Guid documentGuid, string newFileName)
  {
    if (string.IsNullOrEmpty(newFileName))
      throw new ArgumentNullException(nameof (newFileName));
    if (newFileName.Length <= 0)
      return;
    DefaultDatabase.ExecuteNonQuery(CommandType.Text, "UPDATE tblDocumentStore SET FileName = @FileName WHERE DocumentStoreGuid = @DocumentStoreGuid", new object[4]
    {
      (object) "@DocumentStoreGuid",
      (object) documentGuid,
      (object) "@FileName",
      (object) newFileName
    });
    DocumentManager.FireUserDocumentCollectionChanged();
    DocumentManager.FireEntityDocumentCollectionChanged();
  }

  public static void BeginDeleteDocuments(Guid[] documentGuids)
  {
    Guid[] guidArray = documentGuids;
    int index = 0;
    while (index < guidArray.Length)
    {
      Guid guid = guidArray[index];
      if (Utility.IsNull<int>((object) DefaultDatabase.ExecuteScalar<int?>(CommandType.Text, "SELECT COUNT(*) FROM tblDocumentAssociations (NOLOCK) WHERE DocumentStoreGuid = @DocumentStoreGuid", new object[2]
      {
        (object) "@DocumentStoreGuid",
        (object) guid
      }), 0) == 0)
      {
        try
        {
          string description = new Document(guid).Description;
          DefaultDatabase.ExecuteNonQuery(CommandType.Text, "delete      from          tblNotesDocuments      where          DocumentStoreGuid = @DocumentStoreGuid ", new object[2]
          {
            (object) "@DocumentStoreGuid",
            (object) guid
          });
          DefaultDatabase.ExecuteNonQuery(CommandType.Text, "delete      from          tblPinnedDocuments      where          DocumentStoreGuid = @DocumentStoreGuid ", new object[2]
          {
            (object) "@DocumentStoreGuid",
            (object) guid
          });
          DefaultDatabase.ExecuteNonQuery(CommandType.Text, "DELETE FROM tblDocumentStore WHERE DocumentStoreGuid = @DocumentStoreGuid", new object[2]
          {
            (object) "@DocumentStoreGuid",
            (object) guid
          });
          DocumentManager.SendDeleteMessage(guid);
          CurrentUser.Instance.LogAction($"Delete Disassociated Document - \"{description}\"");
        }
        catch (SqlException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          if (ex.Message.Contains("FK_tblPinnedDocuments_tblDocumentStore"))
          {
            int num = (int) System.Windows.Forms.MessageBox.Show("An association(Pinned-DocumentStore) exists with this document.It cannot be deleted.", "Cannot Delete Document", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            ProjectData.ClearProjectError();
            return;
          }
          ProjectData.ClearProjectError();
        }
      }
      checked { ++index; }
    }
    DocumentManager.FireUserDocumentCollectionChanged();
  }

  public static bool BeginDeleteDocument(Guid documentGuid)
  {
    bool flag;
    if (Utility.IsNull<int>((object) DefaultDatabase.ExecuteScalar<int?>(CommandType.Text, "SELECT COUNT(*) FROM tblDocumentAssociations (NOLOCK) WHERE DocumentStoreGuid = @DocumentStoreGuid", new object[2]
    {
      (object) "@DocumentStoreGuid",
      (object) documentGuid
    }), 0) == 0)
    {
      Database.Instance.QueryMultithreadedText.PerformNonQuery(MGASystems.IMS.NoteDocuments.Common.UIContext, (object) nameof (BeginDeleteDocument), "DELETE FROM tblDocumentStore WHERE DocumentStoreGuid = @DocumentStoreGuid", new NonQueryMultithreadEventHandler(DocumentManager.DeleteDocument_NonQueryCompleted), (object) "@DocumentStoreGuid", (object) documentGuid);
      DocumentManager.SendDeleteMessage(documentGuid);
      flag = true;
    }
    else
      flag = false;
    return flag;
  }

  private static void DeleteDocument_NonQueryCompleted(
    object sender,
    NonQueryMultithreadEventArgs e)
  {
    DocumentManager.FireUserDocumentCollectionChanged();
  }

  public static bool DeleteDocumentAssociation(Guid documentGuid)
  {
    DefaultDatabase.ExecuteNonQuery("DELETE FROM tblDocumentAssociations WHERE DocumentStoreGuid = @DocumentStoreGuid", new object[2]
    {
      (object) "@DocumentStoreGuid",
      (object) documentGuid
    });
    DocumentManager.SendDeleteMessage(documentGuid);
    bool flag;
    return flag;
  }

  public static void StartProcess(string fileName)
  {
    NamedPermissionSet namedPermissionSet = new NamedPermissionSet("FullTrust", PermissionState.Unrestricted);
    try
    {
      namedPermissionSet.Demand();
      namedPermissionSet.Assert();
      using (Process process = Process.Start(fileName))
      {
        if (Screen.AllScreens.Length > 1)
        {
          if (process != null)
          {
            try
            {
              if (!process.HasExited)
                process.WaitForInputIdle(10000);
            }
            catch (InvalidOperationException ex)
            {
              ProjectData.SetProjectError((Exception) ex);
              Thread.Sleep(10000);
              ProjectData.ClearProjectError();
            }
            if (Preferences.GetPreferenceBool("DockingTabs.Documents.OpenOnSecondMonitor"))
            {
              Thread.Sleep(1500);
              SystemInfo.MoveWindowToSecondaryMonitorRestored(process.Handle.ToInt32());
            }
          }
        }
      }
      CodeAccessPermission.RevertAssert();
    }
    catch (System.Security.SecurityException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      ProjectData.ClearProjectError();
    }
  }

  public static void BeginViewDocument(
    Guid documentstoreGuid,
    bool trackRevisions,
    bool useOpenWithDialog)
  {
    try
    {
      FormSettings.ShowForm(typeof (frmDownloadDocument), (object) documentstoreGuid, (object) trackRevisions, (object) useOpenWithDialog);
    }
    catch (TargetInvocationException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      DocumentManager.CheckTargetInvocationException(ex);
      ProjectData.ClearProjectError();
    }
  }

  public static void BeginViewDocument(Guid documentstoreGuid)
  {
    try
    {
      DocumentManager.BeginViewDocument(documentstoreGuid, false, false);
    }
    catch (TargetInvocationException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      DocumentManager.CheckTargetInvocationException(ex);
      ProjectData.ClearProjectError();
    }
  }

  private static void CheckTargetInvocationException(TargetInvocationException ex)
  {
    if (!ex.Message.Contains("access to the path") || !ex.Message.Contains("is denied"))
      return;
    int num = (int) System.Windows.Forms.MessageBox.Show("The IMS was denied access when attempting to create a local folder to place the document in.\n\nIf this problem persists, please contact technical support.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Hand);
  }

  public static void BeginSaveDocumentToFile(
    Guid documentStoreGuid,
    DocumentManager.SaveDocumentToFileEventHandler completedHandler)
  {
    new DocumentManager.SaveDocumentThread(documentStoreGuid, completedHandler).StartThread();
  }

  private static string GetSafeFilePath(string fileName)
  {
    if (string.IsNullOrEmpty(fileName))
      throw new ArgumentNullException(nameof (fileName));
    string safeFilePath;
    if (File.Exists(fileName))
    {
      FileInfo fileInfo = new FileInfo(fileName);
      fileName = fileName.Replace(fileInfo.Name, "A" + fileInfo.Name);
      safeFilePath = DocumentManager.GetSafeFilePath(fileName);
    }
    else
      safeFilePath = fileName;
    return safeFilePath;
  }

  public static char[] GetInvalidFileNameChars()
  {
    return (new string(Path.GetInvalidFileNameChars()) + ":" + "#").ToCharArray();
  }

  public static string EnsureProperFileName(string fileName)
  {
    string str1 = new string(DocumentManager.GetInvalidFileNameChars());
    string str2 = new string(DocumentManager.GetInvalidFileNameChars());
    StringBuilder stringBuilder = new StringBuilder(fileName.Length);
    int num = fileName.Length - 1;
    for (int index = 0; index <= num; ++index)
    {
      if (str1.IndexOf(fileName[index]) == -1 && str2.IndexOf(fileName[index]) == -1)
        stringBuilder.Append(fileName[index]);
    }
    return Regex.Replace(Path.GetFileName(stringBuilder.ToString()), "\\u200B", "");
  }

  public static void UpdateDocumentProperties(
    Guid documentStoreGuid,
    string fileName,
    string description,
    string fileAssociation,
    bool copyAssociationsForwardOnRenewal,
    Guid typeGuid,
    bool CopyAssociationForwardOnlyOnce)
  {
    fileName = DocumentManager.EnsureProperFileName(fileName);
    DefaultDatabase.ExecuteNonQuery("DocumentSystem_UpdateDocumentProperties", new object[14]
    {
      (object) "@DocumentStoreGuid",
      (object) documentStoreGuid,
      (object) "@FileName",
      (object) fileName,
      (object) "@Description",
      (object) description,
      (object) "@FileAssociation",
      (object) fileAssociation,
      (object) "@CopyAssociationsForwardOnRenewal",
      (object) copyAssociationsForwardOnRenewal,
      (object) "@TypeGuid",
      typeGuid.Equals(Guid.Empty) ? (object) DBNull.Value : (object) typeGuid,
      (object) "@CopyAssociationForwardOnlyOnce",
      (object) CopyAssociationForwardOnlyOnce
    });
    CurrentUser.Instance.LogAction($"Modify Document Properties on \"{description}\"");
  }

  public static void UpdateCopyForwardOnRenewal(Guid documentStoreGuid, bool copyForward)
  {
    DefaultDatabase.ExecuteNonQuery("DocumentSystem_UpdateCopyForwardOnRenewal", new object[4]
    {
      (object) "@DocumentStoreGuid",
      (object) documentStoreGuid,
      (object) "@ShouldCopyForward",
      (object) copyForward
    });
  }

  [Obsolete]
  public static string SaveDocumentToFile(Guid documentStoreGuid)
  {
    return DocumentManager.InternalSaveDocumentToFile(documentStoreGuid, -999);
  }

  [Obsolete]
  public static string SaveDocumentToFile(int documentStoreId)
  {
    return DocumentManager.InternalSaveDocumentToFile(Guid.NewGuid(), documentStoreId);
  }

  public static string FetchDocumentByGuid(Guid documentStoreGuid, string targetDirectory)
  {
    string str1 = targetDirectory;
    if (documentStoreGuid == Guid.Empty)
      throw new ArgumentNullException(nameof (documentStoreGuid));
    if (string.IsNullOrWhiteSpace(str1))
      throw new ArgumentNullException(nameof (targetDirectory));
    string str2 = str1.EndsWith("\\") ? str1 : str1 + "\\";
    if (!Directory.Exists(str2))
      Directory.CreateDirectory(str2);
    string tempFileName = Path.GetTempFileName();
    byte[] documentBinary = DocumentManager.GetDocumentBinary(documentStoreGuid);
    Metadata documentMetadata = DocumentManager.GetDocumentMetadata(documentStoreGuid);
    File.WriteAllBytes(tempFileName, documentBinary);
    string str3 = FilePath.Resolve(str2, documentMetadata.FileName);
    if (!documentMetadata.Compressed)
      File.Move(tempFileName, str3);
    else
      FilePath.ExtractAndMoveFile(tempFileName, str3);
    return str3;
  }

  private static string InternalSaveDocumentToFile(Guid documentStoreGuid, int documentStoreId)
  {
    string file;
    try
    {
      byte[] documentBinary = DocumentManager.GetDocumentBinary(documentStoreGuid);
      Metadata documentMetadata = DocumentManager.GetDocumentMetadata(documentStoreGuid);
      string fileName = documentMetadata.FileName;
      string description = documentMetadata.Description;
      string str1 = "";
      if (DocumentManager.documentAliasLookup.TryGetValue(documentStoreGuid, out str1))
      {
        DocumentManager.documentAliasLookup.Remove(documentStoreGuid);
        if (!string.IsNullOrWhiteSpace(str1))
          fileName = str1;
      }
      string path = DocumentManager.EnsureProperFileName(frmDownloadDocument.FixLongFilename(fileName));
      string tempSubdirectory = MGATempFolder.CreateTempSubdirectory();
      if (Preferences.GetPreferenceBool("DockingTabs.Documents.Email.Subject.UseFileDescriptions"))
        path = DocumentManager.EnsureProperFileName(frmDownloadDocument.FixLongFilename(description)).Replace(Path.GetExtension(path), "") + Path.GetExtension(path);
      string safeFilePath = DocumentManager.GetSafeFilePath($"{tempSubdirectory}{path}");
      string str2 = $"{tempSubdirectory}{"TempZip.zip"}";
      if (documentMetadata.Compressed)
      {
        using (FileStream fileStream = new FileStream(str2, FileMode.Create))
        {
          if (documentBinary.Length > 0)
            fileStream.Write(documentBinary, 0, documentBinary.Length);
        }
        new ZipUtility().ExtractFilesFromZipArchive(str2, $"{tempSubdirectory}");
      }
      else
      {
        using (FileStream fileStream = new FileStream(safeFilePath, FileMode.Create))
        {
          if (documentBinary.Length > 0)
            fileStream.Write(documentBinary, 0, documentBinary.Length);
        }
      }
      string[] files = Directory.GetFiles(tempSubdirectory);
      int index = 0;
      while (index < files.Length)
      {
        string str3 = files[index];
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Strings.Right(str3, 3).ToUpper(), "ZIP", false) != 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str3, safeFilePath, false) != 0)
          File.Move(str3, safeFilePath);
        checked { ++index; }
      }
      CurrentUser.Instance.LogAction($"Downloaded Document - \"{documentMetadata.Description}\"", documentMetadata.DocumentStoreGuid);
      file = safeFilePath;
    }
    catch (Win32Exception ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      Win32Exception win32Exception = ex;
      if (win32Exception.ErrorCode == -2147467259 /*0x80004005*/)
      {
        int num = (int) System.Windows.Forms.MessageBox.Show(win32Exception.Message, "Windows Cannot Open File", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      }
      file = string.Empty;
      ProjectData.ClearProjectError();
    }
    return file;
  }

  public static void BeginPrintEntityDocs(Guid entityGuid, string entityName)
  {
    new DocumentManager.PrintEntityDocsThread(entityGuid, entityName).StartThread();
  }

  public static void BeginPrintDoc(Guid docGUID)
  {
    new DocumentManager.PrintEntityDocsThread(docGUID).StartThread();
  }

  public static void BeginImportDocumentsFromFolder()
  {
    DocumentManager.BeginImportDocumentsFromFolderWithBind((ISupportDocumentSystem) null);
  }

  public static void BeginImportDocumentsFromFolderWithBind(ISupportDocumentSystem binding)
  {
    using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
    {
      DocSupportCache docSupport = (DocSupportCache) null;
      if (binding != null)
        docSupport = new DocSupportCache(binding);
      if (folderBrowserDialog.ShowDialog() != DialogResult.OK)
        return;
      string selectedPath = folderBrowserDialog.SelectedPath;
      if (!Directory.Exists(selectedPath))
        return;
      string[] files = Directory.GetFiles(selectedPath);
      int index = 0;
      while (index < files.Length)
      {
        string path = files[index];
        if (docSupport == null)
          DocumentManager.BeginFileAdd(path, false);
        else
          DocumentManager.BeginFileAddWithBind(path, (ISupportDocumentSystem) docSupport, false);
        checked { ++index; }
      }
    }
  }

  public static void BeginExportFilesToFolder(IRecreatableEntity docSupport)
  {
    DataTable dataTable = DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT DocumentStoreGUID FROM tblDocumentAssociations WHERE AssociatedEntityGUID = @AssociatedEntityGUID", new object[2]
    {
      (object) "@AssociatedEntityGUID",
      (object) docSupport.EntityGuid
    });
    List<Guid> guidList = new List<Guid>();
    try
    {
      foreach (DataRow row in dataTable.Rows)
        guidList.Add((Guid) row["DocumentStoreGUID"]);
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    if (guidList.Count <= 0)
      return;
    DocumentManager.BeginExportFilesToFolder(guidList.ToArray());
  }

  public static void BeginExportFilesToFolder()
  {
    DataTable dataTable = DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT tblDocumentStore.DocumentStoreGuid FROM tblDocumentStore LEFT OUTER JOIN tblDocumentAssociations ON tblDocumentStore.DocumentStoreGuid = tblDocumentAssociations.DocumentStoreGuid WHERE (tblDocumentAssociations.AssociatedEntityGuid IS NULL) AND (tblDocumentStore.UserGuidOriginator = @UserGuid)", new object[2]
    {
      (object) "@UserGuid",
      (object) MGASystems.IMS.NoteDocuments.Common.UserGUID
    });
    List<Guid> guidList = new List<Guid>();
    try
    {
      foreach (DataRow row in dataTable.Rows)
        guidList.Add((Guid) row["DocumentStoreGUID"]);
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    if (guidList.Count <= 0)
      return;
    DocumentManager.BeginExportFilesToFolder(guidList.ToArray());
  }

  public static void BeginExportFilesToFolder(Guid docGUIDToExport)
  {
    new DocumentManager.FileExporter(docGUIDToExport).BeginExport();
  }

  public static void BeginExportFilesToFolder(Guid[] docGUIDsToExport)
  {
    new DocumentManager.FileExporter(docGUIDsToExport).BeginExport();
  }

  public static void BeginExportFilesToZipFile(Guid[] docGUIDsToExport, string targetZipFileName)
  {
    if (string.IsNullOrWhiteSpace(targetZipFileName))
      return;
    new DocumentManager.FileExporter(docGUIDsToExport).BeginExport(MGATempFolder.MGATempRandomFolderPath, (Action<string>) ([SpecialName] (exportDirectory) => new ZipUtility().CompressFilesToNewZipArchive(exportDirectory, targetZipFileName)));
  }

  public static void BeginExportFilesToFolderWithStructure(
    Guid[] docGUIDsToExport,
    string targetFolder)
  {
    if (string.IsNullOrWhiteSpace(targetFolder))
      return;
    new DocumentManager.FileExporter(docGUIDsToExport, true).BeginExport(MGATempFolder.MGATempRandomFolderPath, (Action<string>) ([SpecialName] (exportDirectory) =>
    {
      if (Directory.Exists(targetFolder))
        Directory.Delete(targetFolder, true);
      DocumentManager.CopyDirectory(exportDirectory, targetFolder);
      try
      {
        Directory.Delete(exportDirectory, true);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }));
  }

  public static void ExportFilesToFolderWithStructure(
    DocumentManager.DownloadComplete callback,
    Guid[] docGUIDsToExport,
    string targetFolder)
  {
    if (string.IsNullOrWhiteSpace(targetFolder))
      return;
    DocumentManager.FileExporter fileExporter = new DocumentManager.FileExporter(docGUIDsToExport, true);
    string randomFolderPath = MGATempFolder.MGATempRandomFolderPath;
    DocumentManager.DownloadComplete callback1 = callback;
    string targetDirectory = randomFolderPath;
    Action<string> exportCompleted;
    // ISSUE: reference to a compiler-generated field
    if (DocumentManager._Closure\u0024__.\u0024I173\u002D0 != null)
    {
      // ISSUE: reference to a compiler-generated field
      exportCompleted = DocumentManager._Closure\u0024__.\u0024I173\u002D0;
    }
    else
    {
      // ISSUE: reference to a compiler-generated field
      DocumentManager._Closure\u0024__.\u0024I173\u002D0 = exportCompleted = (Action<string>) ([SpecialName] (exportDirectory) =>
      {
        try
        {
          Directory.Delete(exportDirectory, true);
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
      });
    }
    fileExporter.BeginExportSingleThread(callback1, targetDirectory, exportCompleted);
  }

  public static void BeginExportFilesToFolderWithStructure(
    Guid quoteGuid,
    string filterProc,
    string targetFolder)
  {
    if (string.IsNullOrWhiteSpace(filterProc))
      throw new ArgumentNullException(nameof (filterProc));
    if (string.IsNullOrWhiteSpace(targetFolder))
      throw new ArgumentNullException(nameof (targetFolder));
    EnumerableRowCollection<DataRow> source = !(quoteGuid == Guid.Empty) ? DefaultDatabase.ExecuteDataTable(filterProc, new object[2]
    {
      (object) "@quoteGuid",
      (object) quoteGuid
    }).AsEnumerable() : throw new ArgumentNullException(nameof (quoteGuid));
    System.Func<DataRow, Guid> selector;
    // ISSUE: reference to a compiler-generated field
    if (DocumentManager._Closure\u0024__.\u0024I174\u002D0 != null)
    {
      // ISSUE: reference to a compiler-generated field
      selector = DocumentManager._Closure\u0024__.\u0024I174\u002D0;
    }
    else
    {
      // ISSUE: reference to a compiler-generated field
      DocumentManager._Closure\u0024__.\u0024I174\u002D0 = selector = (System.Func<DataRow, Guid>) ([SpecialName] (row) => row.Field<Guid>("DocumentStoreGuid"));
    }
    Guid[] array = source.Select<DataRow, Guid>(selector).ToArray<Guid>();
    if (array == null || ((IEnumerable<Guid>) array).Count<Guid>() <= 0)
      return;
    if (!Directory.Exists(targetFolder))
      Directory.CreateDirectory(targetFolder);
    DocumentManager.BeginExportFilesToFolderWithStructure(array, targetFolder);
  }

  public static bool CopyDirectory(string Src, string Dest)
  {
    if (!Directory.Exists(Src))
      throw new DirectoryNotFoundException($"The directory {Src} does not exists");
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Dest.Substring(Dest.Length - 1, 1), Conversions.ToString(Path.DirectorySeparatorChar), false) != 0)
      Dest += Conversions.ToString(Path.DirectorySeparatorChar);
    if (!Directory.Exists(Dest))
      Directory.CreateDirectory(Dest);
    string[] fileSystemEntries = Directory.GetFileSystemEntries(Src);
    int index = 0;
    while (index < fileSystemEntries.Length)
    {
      string str = fileSystemEntries[index];
      if (Directory.Exists(str))
        DocumentManager.CopyDirectory(str, $"{Dest}{Path.GetFileName(str)}");
      else
        File.Copy(str, $"{Dest}{Path.GetFileName(str)}", true);
      checked { ++index; }
    }
    return true;
  }

  public static string ToControlNoWithTimeStamp(Guid quoteGuid)
  {
    int num = DefaultDatabase.ExecuteScalar<int>(CommandType.Text, "select top 1 tq.ControlNo from tblQuotes tq where tq.ControlGuid = @entityGuid or tq.QuoteGuid = @entityGuid", new object[2]
    {
      (object) "@entityGuid",
      (object) quoteGuid
    });
    return $"{DateTime.Now.ToShortDateString().Replace("/", "-")}\\{num}\\";
  }

  public static bool CanConvertToPdf(string fileName)
  {
    bool pdf;
    if (!string.IsNullOrEmpty(fileName))
      pdf = ((IEnumerable<string>) new string[2]
      {
        ".doc",
        ".docx"
      }).Any<string>((System.Func<string, bool>) ([SpecialName] (e) => fileName.EndsWith(e, true, CultureInfo.InvariantCulture)));
    else
      pdf = false;
    return pdf;
  }

  public static string ConvertToPdf(string fileName)
  {
    return !DocumentManager.CanConvertToPdf(fileName) ? string.Empty : MGASystems.Common.PDF.ConvertWordDocToPDF(fileName);
  }

  public static void EmailDocumentsWithoutZipping(Guid[] documentGuids)
  {
    DocumentManager.EmailDocumentsWithoutZipping(documentGuids, (string[]) null);
  }

  public static void EmailDocumentsWithoutZipping(
    Guid[] documentGuids,
    string[] toRecipients,
    MemoryStream htmlEmailBody)
  {
    DocumentManager.EmailDocumentsWithoutZipping(documentGuids, (string[]) null, (string) null, false, htmlEmailBody);
  }

  public static void EmailDocumentsWithoutZipping(Guid[] documentGuids, string[] toRecipients)
  {
    DocumentManager.EmailDocumentsWithoutZipping(documentGuids, toRecipients, string.Empty, false);
  }

  public static void EmailDocumentsWithoutZipping(
    Guid[] documentGuids,
    string[] toRecipients,
    bool convertToPdf)
  {
    DocumentManager.EmailDocumentsWithoutZipping(documentGuids, toRecipients, string.Empty, convertToPdf);
  }

  public static void EmailDocumentsWithoutZipping(
    Guid[] documentGuids,
    string[] toRecipients,
    string subject,
    bool convertToPdf)
  {
    ThreadPool.QueueUserWorkItem(new WaitCallback(DocumentManager.EmailDocumentsWithoutZippingThread), (object) new DocumentEmailsContext((ISupportDocumentSystem) null, documentGuids, toRecipients, subject, convertToPdf));
  }

  public static void EmailDocumentsWithoutZipping(
    Guid[] documentGuids,
    string[] toRecipients,
    string subject,
    bool convertToPdf,
    MemoryStream htmlEmailBody)
  {
    ThreadPool.QueueUserWorkItem(new WaitCallback(DocumentManager.EmailDocumentsWithoutZippingThread), (object) new DocumentEmailsContext((ISupportDocumentSystem) null, documentGuids, toRecipients, subject, convertToPdf, htmlEmailBody));
  }

  public static void EmailDocumentsWithoutZipping(
    Guid[] documentGuids,
    string[] toRecipients,
    string subject)
  {
    DocumentManager.EmailDocumentsWithoutZipping(documentGuids, toRecipients, subject, false);
  }

  public static void EmailDocumentsWithoutZipping(
    ISupportDocumentSystem docSupport,
    Guid[] documentGuids)
  {
    DocumentManager.EmailDocumentsWithoutZipping(docSupport, documentGuids, (string[]) null);
  }

  public static void EmailDocumentsWithoutZipping(
    ISupportDocumentSystem docSupport,
    Guid[] documentGuids,
    string[] toRecipients,
    MemoryStream htmlEmailBody)
  {
    DocumentManager.EmailDocumentsWithoutZipping(docSupport, documentGuids, (string[]) null, (string) null, false, htmlEmailBody);
  }

  public static void EmailDocumentsWithoutZipping(
    ISupportDocumentSystem docSupport,
    Guid[] documentGuids,
    string[] toRecipients)
  {
    DocumentManager.EmailDocumentsWithoutZipping(docSupport, documentGuids, toRecipients, string.Empty, false);
  }

  public static void EmailDocumentsWithoutZipping(
    ISupportDocumentSystem docSupport,
    Guid[] documentGuids,
    string[] toRecipients,
    bool convertToPdf)
  {
    DocumentManager.EmailDocumentsWithoutZipping(docSupport, documentGuids, toRecipients, string.Empty, convertToPdf);
  }

  public static void EmailDocumentsWithoutZipping(
    ISupportDocumentSystem docSupport,
    Guid[] documentGuids,
    string[] toRecipients,
    string subject,
    bool convertToPdf)
  {
    ThreadPool.QueueUserWorkItem(new WaitCallback(DocumentManager.EmailDocumentsWithoutZippingThread), (object) new DocumentEmailsContext(docSupport, documentGuids, toRecipients, subject, convertToPdf));
  }

  public static void EmailDocumentsWithoutZipping(
    ISupportDocumentSystem docSupport,
    Guid[] documentGuids,
    string[] toRecipients,
    string subject,
    bool convertToPdf,
    MemoryStream htmlEmailBody)
  {
    ThreadPool.QueueUserWorkItem(new WaitCallback(DocumentManager.EmailDocumentsWithoutZippingThread), (object) new DocumentEmailsContext(docSupport, documentGuids, toRecipients, subject, convertToPdf, htmlEmailBody));
  }

  public static void EmailDocumentsWithoutZipping(
    ISupportDocumentSystem docSupport,
    Guid[] documentGuids,
    string[] toRecipients,
    string subject)
  {
    DocumentManager.EmailDocumentsWithoutZipping(docSupport, documentGuids, toRecipients, subject, false);
  }

  public static void EmailDocumentsWithoutZipping(
    Guid[] documentGuids,
    string[] toRecipients,
    string subject,
    bool convertToPdf,
    MemoryStream htmlEmailBody,
    string[] ccList)
  {
    ThreadPool.QueueUserWorkItem(new WaitCallback(DocumentManager.EmailDocumentsWithoutZippingThread), (object) new DocumentEmailsContext((ISupportDocumentSystem) null, documentGuids, toRecipients, subject, convertToPdf, htmlEmailBody, ccList));
  }

  public static void EmailDocumentsWithoutZipping(
    Guid[] documentGuids,
    string[] toRecipients,
    string subject,
    bool convertToPdf,
    MemoryStream htmlEmailBody,
    string[] ccList,
    string[] bcList)
  {
    ThreadPool.QueueUserWorkItem(new WaitCallback(DocumentManager.EmailDocumentsWithoutZippingThread), (object) new DocumentEmailsContext((ISupportDocumentSystem) null, documentGuids, toRecipients, subject, convertToPdf, htmlEmailBody, ccList, bcList));
  }

  public static void EmailDocumentsWithoutZipping(
    ISupportDocumentSystem docSupport,
    Guid[] documentGuids,
    string[] toRecipients,
    string subject,
    bool convertToPdf,
    MemoryStream htmlEmailBody,
    string[] ccList,
    string[] bcList)
  {
    ThreadPool.QueueUserWorkItem(new WaitCallback(DocumentManager.EmailDocumentsWithoutZippingThread), (object) new DocumentEmailsContext(docSupport, documentGuids, toRecipients, subject, convertToPdf, htmlEmailBody, ccList, bcList));
  }

  public static void EmailDocumentsWithoutZipping(
    ISupportDocumentSystem docSupport,
    Guid[] documentGuids,
    string[] toRecipients,
    string subject,
    bool convertToPdf,
    MemoryStream htmlEmailBody,
    string[] ccList)
  {
    ThreadPool.QueueUserWorkItem(new WaitCallback(DocumentManager.EmailDocumentsWithoutZippingThread), (object) new DocumentEmailsContext(docSupport, documentGuids, toRecipients, subject, convertToPdf, htmlEmailBody, ccList));
  }

  private static void EmailDocumentsWithoutZippingThread(object state)
  {
    if (MDIControls.Instance.MDIParent.InvokeRequired)
    {
      MDIControls.Instance.MDIParent.BetterInvoke((Delegate) new DocumentManager.EmailDocumentsWithoutZippingThreadHandler(DocumentManager.EmailDocumentsWithoutZippingThread), state);
    }
    else
    {
      try
      {
        if (state == null || !(state is DocumentEmailsContext context))
          return;
        List<string> fileNames = new List<string>();
        Guid[] documentGuids = context.GetDocumentGuids();
        string[] toRecipients = context.GetToRecipients();
        string[] getCarbonCopyList = context.GetCarbonCopyList;
        string[] getBcarbonCopyList = context.GetBCarbonCopyList;
        MemoryStream htmlEmailBody = context.htmlEmailBody;
        Guid[] guidArray1 = documentGuids;
        int index1 = 0;
        while (index1 < guidArray1.Length)
        {
          Guid documentStoreGuid = guidArray1[index1];
          fileNames.Add(DocumentManager.SaveDocumentToFile(documentStoreGuid));
          checked { ++index1; }
        }
        try
        {
          if (htmlEmailBody == null)
          {
            UI.Send(context.DocumentSupport, DocumentManager.PreProcessFiles(context, fileNames), toRecipients, context.Subject, getCarbonCopyList, getBcarbonCopyList, (string) null);
          }
          else
          {
            string fromMemoryStream = DocumentManager.GetStringFromMemoryStream(context.htmlEmailBody);
            UI.Send(context.DocumentSupport, DocumentManager.PreProcessFiles(context, fileNames), toRecipients, context.Subject, getCarbonCopyList, getBcarbonCopyList, fromMemoryStream);
          }
          Guid[] guidArray2 = documentGuids;
          int index2 = 0;
          while (index2 < guidArray2.Length)
          {
            Guid documentStoreGuid = guidArray2[index2];
            fileNames.Add(DocumentManager.SaveDocumentToFile(documentStoreGuid));
            checked { ++index2; }
          }
        }
        catch (COMException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          MGASystems.Common.ThreadingFunctions.MessageBox.Show("The IMS was unable to send emails.\n\nPlease contact your system administrator and verify your email settings are correct.", "Unable to Send Emails", MessageBoxButtons.OK, MessageBoxIcon.Hand);
          ProjectData.ClearProjectError();
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ErrorHandler.HandleError(ex);
        ProjectData.ClearProjectError();
      }
    }
  }

  public static void EmailDocuments(Guid[] documentGuids, string[] toRecipients)
  {
    DocumentManager.EmailDocuments(documentGuids, toRecipients, false);
  }

  public static void EmailDocuments(Guid[] documentGuids, string[] toRecipients, bool convertToPdf)
  {
    if (documentGuids.Length == 0)
      return;
    ThreadPool.QueueUserWorkItem(new WaitCallback(DocumentManager.EmailDocumentsThread), (object) new DocumentEmailsContext(documentGuids, toRecipients, string.Empty, convertToPdf));
  }

  private static void EmailDocumentsThread(object state)
  {
    if (state == null || !(state is DocumentEmailsContext context))
      return;
    Guid[] documentGuids = context.GetDocumentGuids();
    string[] toRecipients = context.GetToRecipients();
    ZipUtility zipUtility = new ZipUtility();
    StringBuilder stringBuilder = new StringBuilder();
    List<string> stringList = new List<string>();
    List<byte[]> numArrayList = new List<byte[]>();
    Guid[] guidArray = documentGuids;
    int index1 = 0;
    while (index1 < guidArray.Length)
    {
      Guid documentGuid = guidArray[index1];
      byte[] documentBinary = DocumentManager.GetDocumentBinary(documentGuid);
      Metadata documentMetadata = DocumentManager.GetDocumentMetadata(documentGuid);
      if (documentMetadata.Compressed)
      {
        byte[][] fileStreams = (byte[][]) null;
        string[] fileNames = (string[]) null;
        zipUtility.ExtractFilesFromZipArchive(documentBinary, out fileNames, out fileStreams);
        if (fileStreams.Length == fileNames.Length)
        {
          int num = fileStreams.Length - 1;
          for (int index2 = 0; index2 <= num; ++index2)
          {
            numArrayList.Add(fileStreams[index2]);
            stringList.Add(fileNames[index2]);
          }
        }
        else
        {
          numArrayList.Add(documentBinary);
          stringList.Add(documentMetadata.FileName);
        }
      }
      checked { ++index1; }
    }
    byte[][] array1 = numArrayList.ToArray();
    string[] array2 = stringList.ToArray();
    byte[] newZipStream = zipUtility.CompressStreamsToNewZipStream(array1, array2);
    string tempSubdirectory = MGATempFolder.CreateTempSubdirectory();
    string path = $"{tempSubdirectory}Documents.zip";
    using (FileStream fileStream = new FileStream(path, FileMode.CreateNew))
    {
      fileStream.Write(newZipStream, 0, newZipStream.Length);
      fileStream.Close();
    }
    UI.Send(DocumentManager.PreProcessFiles(context, new List<string>()
    {
      path
    }), toRecipients);
    if (!Directory.Exists(tempSubdirectory))
      return;
    Directory.Delete(tempSubdirectory, true);
  }

  public static void EmailNativeDocuments(Guid[] documentGuids)
  {
    DocumentManager.EmailNativeDocuments(documentGuids, false);
  }

  public static void EmailNativeDocuments(Guid[] documentGuids, bool convertToPdf)
  {
    if (documentGuids.Length == 0)
      return;
    ThreadPool.QueueUserWorkItem(new WaitCallback(DocumentManager.EmailNativeDocumentsThread), (object) new DocumentEmailsContext(documentGuids, (string[]) null, string.Empty, convertToPdf));
  }

  private static void EmailNativeDocumentsThread(object state)
  {
    try
    {
      Cursor.Current = MgaCursors.WaitCursor;
      if (state == null || !(state is DocumentEmailsContext documentEmailsContext))
        return;
      Guid[] documentGuids = documentEmailsContext.GetDocumentGuids();
      string tempDirectory = frmDocumentEmail.CreateTempDirectory();
      $"{tempDirectory}Documents.zip";
      List<string> stringList = new List<string>();
      Guid[] guidArray = documentGuids;
      int index = 0;
      while (index < guidArray.Length)
      {
        Guid documentStoreGuid = guidArray[index];
        stringList.Add(DocumentManager.SaveDocumentToFile(documentStoreGuid));
        checked { ++index; }
      }
      MDIControls.Instance.MDIParent.BetterInvoke((Delegate) new DocumentManager.SendEmailOnUIThreadHandler(DocumentManager.SendEmailOnUIThread), (object) documentEmailsContext, (object) stringList);
      if (!Directory.Exists(tempDirectory))
        return;
      Directory.Delete(tempDirectory, true);
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      Exception exception = ex;
      Cursor.Current = MgaCursors.Default;
      MDIControls.Instance.MDIParent.BetterInvoke((Delegate) new DocumentManager.ErrorOnThreadHandler(DocumentManager.ErrorOnThread), (object) exception);
      ProjectData.ClearProjectError();
    }
  }

  private static void SendEmailOnUIThread(DocumentEmailsContext context, List<string> documentPaths)
  {
    try
    {
      Cursor.Current = MgaCursors.WaitCursor;
      UI.Send(DocumentManager.PreProcessFiles(context, documentPaths));
    }
    finally
    {
      Cursor.Current = MgaCursors.Default;
    }
  }

  private static void ErrorOnThread(Exception ex) => Utility.ErrorHandling.HandleError(ex);

  private static string[] PreProcessFiles(DocumentEmailsContext context, List<string> fileNames)
  {
    string[] array;
    try
    {
      if (context.ConvertToPdf)
      {
        List<string> stringList = new List<string>();
        try
        {
          foreach (string fileName in fileNames)
          {
            if (DocumentManager.CanConvertToPdf(fileName))
              stringList.Add(MGASystems.Common.PDF.ConvertWordDocToPDF(fileName));
            else
              stringList.Add(fileName);
          }
        }
        finally
        {
          List<string>.Enumerator enumerator;
          enumerator.Dispose();
        }
        array = stringList.ToArray();
      }
      else
        array = fileNames.ToArray();
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      array = fileNames.ToArray();
      ProjectData.ClearProjectError();
    }
    return array;
  }

  public static void EmailDocuments(params Guid[] documentGUIDs)
  {
    DocumentManager.EmailDocuments(false, documentGUIDs);
  }

  public static void EmailDocuments(bool convertToPdf, params Guid[] documentGUIDs)
  {
    if (documentGUIDs.Length == 0)
      return;
    DocumentManager.EmailNativeDocuments(documentGUIDs, convertToPdf);
  }

  public static string GetStringFromMemoryStream(MemoryStream m)
  {
    string fromMemoryStream;
    if (Information.IsNothing((object) m))
    {
      fromMemoryStream = (string) null;
    }
    else
    {
      m.Flush();
      m.Position = 0L;
      fromMemoryStream = new StreamReader((Stream) m).ReadToEnd();
    }
    return fromMemoryStream;
  }

  public static void UpdateMetaXml(Guid documentStoreGuid, string filePath)
  {
    if (string.IsNullOrEmpty(filePath) || !File.Exists(filePath))
      return;
    if (string.Compare(Path.GetExtension(filePath), ".msg", true) != 0)
      return;
    try
    {
      MailMetaData mailMetaData = OutlookMessageHandler.GetMailMetaData(filePath);
      DefaultDatabase.ExecuteNonQuery("DocumentSystem_UpdateDocumentMetaData", new object[4]
      {
        (object) "@documentStoreGuid",
        (object) documentStoreGuid,
        (object) "@metaXml",
        (object) mailMetaData.ToXml()
      });
    }
    catch (IOException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      ProjectData.ClearProjectError();
    }
  }

  public static void PinDocument(Guid documentGuid)
  {
    DocumentManager.PinDocument(documentGuid, CurrentUser.Instance.UserGUID);
  }

  public static void PinDocument(Guid documentGuid, Guid toUserGuid)
  {
    DefaultDatabase.ExecuteNonQuery("PinDocumentToUser", new object[4]
    {
      (object) "@UserGuid",
      (object) toUserGuid,
      (object) "@DocumentStoreGuid",
      (object) documentGuid
    });
    DocumentManager.FireEntityDocumentCollectionChanged();
    DocumentManager.FireUserDocumentCollectionChanged();
  }

  public static void PinDocuments(Guid[] documentGuids)
  {
    DocumentManager.PinDocuments(documentGuids, CurrentUser.Instance.UserGUID);
  }

  public static void PinDocuments(Guid[] documentGuids, Guid toUserGuid)
  {
    DefaultDatabase.ExecuteNonQuery("PinDocumentsToUsers", new object[4]
    {
      (object) "@UserGuid",
      (object) toUserGuid,
      (object) "@DocumentStoreGuid",
      (object) DocumentManager.GuidsToXML(documentGuids, "DocumentGuid", "DocumentGuids")
    });
    DocumentManager.FireEntityDocumentCollectionChanged();
    DocumentManager.FireUserDocumentCollectionChanged();
  }

  public static string GuidsToXML(Guid[] guids, string elementName, string rootXml)
  {
    StringBuilder stringBuilder = new StringBuilder();
    Guid[] guidArray = guids;
    int index = 0;
    while (index < guidArray.Length)
    {
      Guid guid = guidArray[index];
      stringBuilder.Append($"<{elementName} GUID=\"{guid}\"/>");
      checked { ++index; }
    }
    return $"<{rootXml}>{stringBuilder}</{rootXml}>";
  }

  public static void MoveDocument(Guid documentStoreGuid, int folderId)
  {
    DefaultDatabase.ExecuteNonQuery("DocumentSystem_MoveDocument", new object[4]
    {
      (object) "@DocumentStoreGUID",
      (object) documentStoreGuid,
      (object) "@folderId",
      (object) folderId
    });
  }

  public static void MoveDocumentToRoot(Guid documentStoreGuid)
  {
    DefaultDatabase.ExecuteNonQuery("DocumentSystem_MoveDocument", new object[2]
    {
      (object) "@DocumentStoreGUID",
      (object) documentStoreGuid
    });
  }

  public static Guid CopyDocumentToFolder(Guid documentStoreGuid, int folderId)
  {
    return DefaultDatabase.ExecuteScalar<Guid>("DocumentSystem_CopyDocument", new object[4]
    {
      (object) "@DocumentStoreGUID",
      (object) documentStoreGuid,
      (object) "@folderId",
      (object) folderId
    });
  }

  public static Guid CopyDocumentToRootFolder(Guid documentStoreGuid)
  {
    return DefaultDatabase.ExecuteScalar<Guid>("DocumentSystem_CopyDocument", new object[2]
    {
      (object) "@DocumentStoreGUID",
      (object) documentStoreGuid
    });
  }

  public static void UnPinDocument(Guid documentGuid)
  {
    DefaultDatabase.ExecuteNonQuery("UnPinDocumentFromUser", new object[4]
    {
      (object) "@UserGuid",
      (object) CurrentUser.Instance.UserGUID,
      (object) "@DocumentStoreGuid",
      (object) documentGuid
    });
    DocumentManager.FireEntityDocumentCollectionChanged();
    DocumentManager.FireUserDocumentCollectionChanged();
  }

  [Obsolete("Use UnPinDocument passing only the documentGuid instead")]
  public static void UnPinDocument(Guid documentGuid, bool refreshTrees)
  {
    DocumentManager.UnPinDocument(documentGuid);
  }

  public static void ClearAllPinnedDocuments()
  {
    DefaultDatabase.ExecuteNonQuery("UnPinAllDocumentsFromUser", new object[2]
    {
      (object) "@UserGuid",
      (object) CurrentUser.Instance.UserGUID
    });
    DocumentManager.FireEntityDocumentCollectionChanged();
    DocumentManager.FireUserDocumentCollectionChanged();
  }

  public static Guid[] GetDocumentsAssociatedToEntity(Guid entityGuid)
  {
    List<Guid> guidList = new List<Guid>();
    DataTable dataTable = DefaultDatabase.ExecuteDataTable(nameof (GetDocumentsAssociatedToEntity), new object[2]
    {
      (object) "@EntityGuid",
      (object) entityGuid
    });
    try
    {
      foreach (DataRow row in dataTable.Rows)
        guidList.Add((Guid) row["DocumentStoreGuid"]);
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    return guidList.ToArray();
  }

  public static Guid[] GetDocumentsAssociatedToControl(Guid controlGuid)
  {
    List<Guid> guidList = new List<Guid>();
    DataTable dataTable = DefaultDatabase.ExecuteDataTable("GetDocumentsAssociatedToControlGuid", new object[2]
    {
      (object) "@ControlGuid",
      (object) controlGuid
    });
    try
    {
      foreach (DataRow row in dataTable.Rows)
        guidList.Add((Guid) row["DocumentStoreGuid"]);
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    return guidList.ToArray();
  }

  public static Guid[] GetDocumentsAssociatedToControl(int controlNo)
  {
    List<Guid> guidList = new List<Guid>();
    DataTable dataTable = DefaultDatabase.ExecuteDataTable("GetDocumentsAssociatedToControlNo", new object[2]
    {
      (object) "@ControlNo",
      (object) controlNo
    });
    try
    {
      foreach (DataRow row in dataTable.Rows)
        guidList.Add((Guid) row["DocumentStoreGuid"]);
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    return guidList.ToArray();
  }

  public static List<Guid> GetDocGuidsSpecified(Guid controlGuid, int folderid, string findname)
  {
    List<Guid> docGuidsSpecified = new List<Guid>();
    DataTable dataTable = DefaultDatabase.ExecuteDataTable("GetDocumentsAssociatedWithParams", new object[6]
    {
      (object) "@ControlGuid",
      (object) controlGuid,
      (object) "@FolderId",
      (object) folderid,
      (object) "@NameStartsWith",
      (object) findname
    });
    try
    {
      foreach (DataRow row in dataTable.Rows)
        docGuidsSpecified.Add(row.Field<Guid>("DocumentStoreGuid"));
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    return docGuidsSpecified;
  }

  public static bool AreDocumentsAssociatedToControl(int controlNo)
  {
    return DefaultDatabase.ExecuteScalar<bool>("dbo.AreDocumentsAssociatedToControlNo", new object[2]
    {
      (object) "@ControlNo",
      (object) controlNo
    });
  }

  public static bool AreDocumentsAssociatedToControl(Guid controlGuid)
  {
    return DefaultDatabase.ExecuteScalar<bool>("dbo.AreDocumentsAssociatedToControlGuid", new object[2]
    {
      (object) "@ControlGuid",
      (object) controlGuid
    });
  }

  public static bool AreDocumentsAssociatedToEntity(Guid entityGuid)
  {
    return DefaultDatabase.ExecuteScalar<bool>("dbo.AreDocumentsAssociatedToEntityGuid", new object[2]
    {
      (object) "@EntityGuid",
      (object) entityGuid
    });
  }

  public static void ClearDocumentAssociations(Guid documentGuid)
  {
    DefaultDatabase.ExecuteNonQuery(nameof (ClearDocumentAssociations), new object[2]
    {
      (object) "@DocumentStoreGuid",
      (object) documentGuid
    });
    DocumentManager.FireEntityDocumentCollectionChanged();
    DocumentManager.FireUserDocumentCollectionChanged();
  }

  public static void DeleteDocumentAssociationsByEntity(Guid entityGuid)
  {
    DefaultDatabase.ExecuteNonQuery(nameof (DeleteDocumentAssociationsByEntity), new object[2]
    {
      (object) "@EntityGuid",
      (object) entityGuid
    });
    DocumentManager.FireEntityDocumentCollectionChanged();
    DocumentManager.FireUserDocumentCollectionChanged();
  }

  public static void DeleteDocumentAssociationsByControl(int controlNo)
  {
    DefaultDatabase.ExecuteNonQuery("DeleteDocumentAssociationsByControlNo", new object[2]
    {
      (object) "@ControlNo",
      (object) controlNo
    });
    DocumentManager.FireEntityDocumentCollectionChanged();
    DocumentManager.FireUserDocumentCollectionChanged();
  }

  public static void DeleteDocumentAssociationsByControl(Guid controlGuid)
  {
    DefaultDatabase.ExecuteNonQuery("DeleteDocumentAssociationsByControlGuid", new object[2]
    {
      (object) "@ControlGuid",
      (object) controlGuid
    });
    DocumentManager.FireEntityDocumentCollectionChanged();
    DocumentManager.FireUserDocumentCollectionChanged();
  }

  public static void TransferDocumentAssociationByEntity(Guid fromEntityGuid, Guid toEntityGuid)
  {
    DefaultDatabase.ExecuteNonQuery(nameof (TransferDocumentAssociationByEntity), new object[4]
    {
      (object) "@FromEntityGuid",
      (object) fromEntityGuid,
      (object) "@ToEntityGuid",
      (object) toEntityGuid
    });
    DocumentManager.FireEntityDocumentCollectionChanged();
  }

  public static void TransferDocumentAssociationsByControl(Guid fromControlGuid, Guid toControlGuid)
  {
    DefaultDatabase.ExecuteNonQuery("TransferDocumentAssociationByControlGuid", new object[4]
    {
      (object) "@FromControlGuid",
      (object) fromControlGuid,
      (object) "@ToControlGuid",
      (object) toControlGuid
    });
    DocumentManager.FireEntityDocumentCollectionChanged();
  }

  internal static void PutDocument(
    Guid documentStoreGuid,
    byte[] document,
    CancellationToken token,
    Action<int> progressCallback)
  {
    int num = (int) DocumentManager.DocumentWriter.PutDocumentBinary(documentStoreGuid, document, token, progressCallback);
  }

  public delegate void FileAddedAndBound(Guid docGuid);

  public delegate void DownloadComplete(Guid docGuid, string tempFolder, string fileName);

  public delegate void DocumentBoundEventHandler(
    object sender,
    DocumentManager.DocumentBoundEventArgs e);

  public class DocumentBoundEventArgs
  {
    public Guid DocumentGuid { get; }

    public DocSupportCache Entity { get; }

    public string FileName { get; }

    public int FolderId { get; }

    public DocumentBoundEventArgs(
      Guid documentGUID,
      DocSupportCache entity,
      string fileName,
      int folderId)
    {
      this.DocumentGuid = documentGUID;
      this.Entity = entity;
      this.FileName = fileName;
      this.FolderId = folderId;
    }

    public Guid EntityGUID => this._Entity.EntityGUID;
  }

  private class PageParser
  {
    private PageParser()
    {
    }

    public static int[] ParsePages(string pages)
    {
      List<int> intList = new List<int>();
      List<string> stringList = new List<string>();
      if (pages.Length > 0)
      {
        StringBuilder stringBuilder = new StringBuilder();
        char[] charArray = pages.ToCharArray();
        int index1 = 0;
        while (index1 < charArray.Length)
        {
          char Expression = charArray[index1];
          if (Versioned.IsNumeric((object) Expression))
          {
            stringBuilder.Append(Expression);
          }
          else
          {
            if (stringBuilder.Length > 0)
            {
              stringList.Add(stringBuilder.ToString());
              stringBuilder = new StringBuilder();
            }
            stringList.Add(Expression.ToString());
          }
          checked { ++index1; }
        }
        if (stringBuilder.Length > 0)
          stringList.Add(stringBuilder.ToString());
        string Left = string.Empty;
        try
        {
          foreach (string Expression in stringList)
          {
            if (Versioned.IsNumeric((object) Expression))
            {
              int integer;
              int num1 = integer;
              integer = Conversions.ToInteger(Expression);
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "-", false) == 0)
              {
                int num2 = num1 + 1;
                int num3 = integer;
                for (int index2 = num2; index2 <= num3; ++index2)
                  intList.Add(index2);
              }
              else
                intList.Add(integer);
            }
            Left = Expression;
          }
        }
        finally
        {
          List<string>.Enumerator enumerator;
          enumerator.Dispose();
        }
      }
      return intList.ToArray();
    }
  }

  public class SaveDocumentToFileEventArgs : EventArgs
  {
    private string _fileName;

    public SaveDocumentToFileEventArgs(string fileName) => this._fileName = fileName;

    public string FileName => this._fileName;
  }

  public delegate void SaveDocumentToFileEventHandler(
    object sender,
    DocumentManager.SaveDocumentToFileEventArgs e);

  private sealed class SaveDocumentThread : QueryThread
  {
    private DocumentManager.SaveDocumentToFileEventHandler _completedHandler;
    private Guid _documentStoreGuid;
    private string _writtenOutFileName;

    public SaveDocumentThread(
      Guid documentStoreGuid,
      DocumentManager.SaveDocumentToFileEventHandler completedHandler)
      : base(MGASystems.IMS.NoteDocuments.Common.UIContext, (object) nameof (SaveDocumentThread), string.Empty)
    {
      this._completedHandler = completedHandler;
      this._documentStoreGuid = documentStoreGuid;
    }

    protected override void ThreadCompletedUI()
    {
      this._completedHandler((object) this, new DocumentManager.SaveDocumentToFileEventArgs(this._writtenOutFileName));
    }

    protected override void ThreadProcBG()
    {
      try
      {
        byte[] documentBinary = DocumentManager.GetDocumentBinary(this._documentStoreGuid);
        Metadata documentMetadata = DocumentManager.GetDocumentMetadata(this._documentStoreGuid);
        string tempSubdirectory = MGATempFolder.CreateTempSubdirectory();
        this._writtenOutFileName = $"{tempSubdirectory}{documentMetadata.FileName}";
        string str = $"{tempSubdirectory}{"TempZip.zip"}";
        if (documentMetadata.Compressed)
        {
          using (FileStream fileStream = new FileStream(str, FileMode.Create))
          {
            fileStream.Write(documentBinary, 0, documentBinary.Length);
            fileStream.Close();
          }
          new ZipUtility().ExtractFilesFromZipArchive(str, $"{tempSubdirectory}");
        }
        else
        {
          using (FileStream fileStream = new FileStream(this._writtenOutFileName, FileMode.Create))
          {
            fileStream.Write(documentBinary, 0, documentBinary.Length);
            fileStream.Close();
          }
        }
        this._writtenOutFileName = this._writtenOutFileName;
      }
      catch (Win32Exception ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        Win32Exception win32Exception = ex;
        if (win32Exception.ErrorCode == -2147467259 /*0x80004005*/)
        {
          int num = (int) System.Windows.Forms.MessageBox.Show(win32Exception.Message, "Windows Cannot Open File", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        this._writtenOutFileName = string.Empty;
        ProjectData.ClearProjectError();
      }
    }
  }

  private sealed class PrintEntityDocsThread : QueryThread
  {
    private Guid _entityGuid;
    private Guid _docGuid;
    private List<string> _filesUnableToPrint;

    public PrintEntityDocsThread(Guid entityGuid, string entityName)
      : base(MGASystems.IMS.NoteDocuments.Common.UIContext, (object) entityName, string.Empty)
    {
      this._docGuid = Guid.Empty;
      this._filesUnableToPrint = new List<string>();
      this._entityGuid = entityGuid;
    }

    public PrintEntityDocsThread(Guid docGUID)
      : base(MGASystems.IMS.NoteDocuments.Common.UIContext, (object) "Document Print", string.Empty)
    {
      this._docGuid = Guid.Empty;
      this._filesUnableToPrint = new List<string>();
      this._docGuid = docGUID;
    }

    protected override void ThreadCompletedUI()
    {
      if (this._filesUnableToPrint.Count <= 0)
        return;
      StringBuilder stringBuilder = new StringBuilder();
      try
      {
        foreach (string str in this._filesUnableToPrint)
        {
          stringBuilder.Append("\r\n");
          stringBuilder.Append(str);
        }
      }
      finally
      {
        List<string>.Enumerator enumerator;
        enumerator.Dispose();
      }
      int num = (int) System.Windows.Forms.MessageBox.Show($"The following files were unable to print because either the file format is unsupported, or your machine did not have capability to print the file. {stringBuilder}", Conversions.ToString(this.Key), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }

    protected override void ThreadProcBG()
    {
      if (!this._docGuid.Equals(Guid.Empty))
      {
        string file = DocumentManager.SaveDocumentToFile(this._docGuid);
        try
        {
          Metadata documentMetadata = DocumentManager.GetDocumentMetadata(this._docGuid);
          if (string.IsNullOrEmpty(file))
            return;
          if (DocumentManager.PrintEntityDocsThread.IsPDFDocument(documentMetadata.FileAssociation))
          {
            new FilePrinting().PrintDoc(file, (ISynchronizeInvoke) MGASystems.IMS.NoteDocuments.Common.UIContext);
          }
          else
          {
            if (!DocumentManager.PrintEntityDocsThread.VerifyPrintingWhiteList(documentMetadata.FileAssociation) || API.ShellExecute(new IntPtr(), "print", file, string.Empty, string.Empty, 0).ToInt32() > 32 /*0x20*/ || DocumentManager.PrintEntityDocsThread.VerifyImageWhiteList(documentMetadata.FileAssociation) && DocumentManager.PrintEntityDocsThread.PrintImage(file))
              return;
            this._filesUnableToPrint.Add(new FileInfo(file).Name);
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          if (ex.Message.Contains("No printers are installed"))
          {
            this._filesUnableToPrint.Add(new FileInfo(file).Name);
            ProjectData.ClearProjectError();
          }
          else
            throw;
        }
      }
      else
      {
        DataTable dataTable = this.DB.QueryText.PerformTableQuery("SELECT dbo.tblDocumentStore.DocumentStoreGuid, dbo.tblDocumentStore.FileAssociation  FROM dbo.tblDocumentStore INNER JOIN dbo.tblDocumentAssociations ON dbo.tblDocumentStore.DocumentStoreGuid = dbo.tblDocumentAssociations.DocumentStoreGuid WHERE (dbo.tblDocumentAssociations.AssociatedEntityGuid = @EntityGuid) ", (object) "@EntityGuid", (object) this._entityGuid);
        try
        {
          foreach (DataRow row in dataTable.Rows)
          {
            Guid documentStoreGuid = (Guid) row["DocumentStoreGuid"];
            string fileAssociation = row["FileAssociation"].ToString();
            string file = DocumentManager.SaveDocumentToFile(documentStoreGuid);
            try
            {
              if (!string.IsNullOrEmpty(file))
              {
                if (DocumentManager.PrintEntityDocsThread.IsPDFDocument(fileAssociation))
                {
                  new FilePrinting().PrintDoc(file, (ISynchronizeInvoke) MGASystems.IMS.NoteDocuments.Common.UIContext);
                }
                else
                {
                  if (DocumentManager.PrintEntityDocsThread.VerifyPrintingWhiteList(fileAssociation))
                  {
                    if (API.ShellExecute(new IntPtr(), "print", file, string.Empty, string.Empty, 0).ToInt32() > 32 /*0x20*/)
                      continue;
                  }
                  if (DocumentManager.PrintEntityDocsThread.VerifyImageWhiteList(fileAssociation))
                  {
                    if (DocumentManager.PrintEntityDocsThread.PrintImage(file))
                      continue;
                  }
                  this._filesUnableToPrint.Add(new FileInfo(file).Name);
                }
              }
            }
            catch (Exception ex)
            {
              ProjectData.SetProjectError(ex);
              if (ex.Message.Contains("No printers are installed"))
              {
                this._filesUnableToPrint.Add(new FileInfo(file).Name);
                ProjectData.ClearProjectError();
              }
              else
                throw;
            }
          }
        }
        finally
        {
          IEnumerator enumerator;
          if (enumerator is IDisposable)
            (enumerator as IDisposable).Dispose();
        }
      }
    }

    private static bool PrintImage(string fileName)
    {
      DocumentManager.PrintEntityDocsThread.ImagePrintDocument imagePrintDocument = (DocumentManager.PrintEntityDocsThread.ImagePrintDocument) null;
      bool flag;
      try
      {
        imagePrintDocument = new DocumentManager.PrintEntityDocsThread.ImagePrintDocument(fileName);
        imagePrintDocument.Print();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        flag = false;
        ProjectData.ClearProjectError();
        goto label_5;
      }
      finally
      {
        imagePrintDocument.Dispose();
      }
      flag = true;
label_5:
      return flag;
    }

    private static bool IsPDFDocument(string fileAssociation)
    {
      return Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fileAssociation, "Adobe Acrobat Document", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fileAssociation, "Microsoft Edge PDF Document", false) == 0;
    }

    private static bool VerifyPrintingWhiteList(string fileAssociation)
    {
      string str = fileAssociation;
      bool flag;
      // ISSUE: reference to a compiler-generated method
      switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(str))
      {
        case 926704087:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "Adobe Acrobat Document", false) == 0)
            break;
          goto default;
        case 1147999619:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "Outlook Item", false) == 0)
            break;
          goto default;
        case 1851788851:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "Microsoft Edge PDF Document", false) != 0)
            goto default;
          break;
        case 1998692537:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "Rich Text Format", false) == 0)
            break;
          goto default;
        case 2987034690:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "Microsoft Word Document", false) == 0)
            break;
          goto default;
        case 3368779431:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "Text Document", false) == 0)
            break;
          goto default;
        case 3538116992:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "Microsoft Excel Worksheet", false) == 0)
            break;
          goto default;
        case 3730193563:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "Microsoft Visio Drawing", false) == 0)
            break;
          goto default;
        default:
          flag = false;
          goto label_11;
      }
      flag = true;
label_11:
      return flag;
    }

    private static bool VerifyImageWhiteList(string fileAssociation)
    {
      string Left = fileAssociation;
      return Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "Bitmap Image", false) == 0 || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "JPEG Image", false) == 0 || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "TIF Image", false) == 0 || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "PNG Image", false) == 0 || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "GIF Image", false) == 0;
    }

    private class ImagePrintDocument : PrintDocument
    {
      private Image _image;

      public ImagePrintDocument(string fileName)
      {
        this.PrintPage += new PrintPageEventHandler(this.Printer_PrintPage);
        this._image = Image.FromFile(fileName);
      }

      protected override void Dispose(bool disposing)
      {
        this.PrintPage -= new PrintPageEventHandler(this.Printer_PrintPage);
        if (this._image != null)
          this._image.Dispose();
        base.Dispose(disposing);
      }

      private void Printer_PrintPage(object sender, PrintPageEventArgs e)
      {
        Rectangle pageBounds = e.PageBounds;
        int num1 = 15;
        int num2 = this._image.Width - (pageBounds.Width - num1 * 2);
        int num3 = this._image.Height - (pageBounds.Height - num1 * 2);
        Rectangle rect;
        if (num2 > 0 || num3 > 0)
        {
          float num4 = num2 <= num3 ? DocumentManager.PrintEntityDocsThread.ImagePrintDocument.GetAspectRatio((float) (pageBounds.Height - num1 * 2), (float) this._image.Height) : DocumentManager.PrintEntityDocsThread.ImagePrintDocument.GetAspectRatio((float) (pageBounds.Width - num1 * 2), (float) this._image.Width);
          rect = new Rectangle(0, 0, (int) Math.Round((double) this._image.Width * (double) num4), (int) Math.Round((double) this._image.Height * (double) num4));
        }
        else
          rect = new Rectangle(0, 0, this._image.Width, this._image.Height);
        int x = (int) Math.Round((double) (pageBounds.Width - rect.Width) / 2.0);
        int y = (int) Math.Round((double) (pageBounds.Height - rect.Height) / 2.0);
        rect.Location = new Point(x, y);
        e.Graphics.DrawImage(this._image, rect);
      }

      private static float GetAspectRatio(float pageExtent, float imageExtent)
      {
        return (float) (0.01 * (double) pageExtent * (100.0 / (double) imageExtent));
      }
    }
  }

  private sealed class FileExporter
  {
    private Queue _docGUIDsToExport;
    private string _destinationFolder;
    private frmDocumentMoveProgress _progressForm;
    private int _max;
    private Action<string> _exportCompletedHandler;
    private Dictionary<int, string> _folderLookup;
    private bool _preserverFolderStructure;

    public FileExporter(Guid docGUIDToExport)
    {
      this._docGUIDsToExport = new Queue();
      this._docGUIDsToExport.Enqueue((object) docGUIDToExport);
    }

    public FileExporter(Guid[] docGUIDsToExport)
    {
      this._docGUIDsToExport = new Queue();
      Guid[] guidArray = docGUIDsToExport;
      int index = 0;
      while (index < guidArray.Length)
      {
        Guid documentGuid = guidArray[index];
        this._docGUIDsToExport.Enqueue((object) documentGuid);
        Metadata documentMetadata = DocumentManager.GetDocumentMetadata(documentGuid);
        CurrentUser.Instance.LogAction($"Downloaded Document - \"{documentMetadata.Description}\"", documentMetadata.DocumentStoreGuid);
        checked { ++index; }
      }
    }

    public FileExporter(Guid[] docGUIDsToExport, bool preserverFolderStructure)
    {
      this._docGUIDsToExport = new Queue();
      this._preserverFolderStructure = preserverFolderStructure;
      Guid[] guidArray = docGUIDsToExport;
      int index = 0;
      while (index < guidArray.Length)
      {
        this._docGUIDsToExport.Enqueue((object) guidArray[index]);
        checked { ++index; }
      }
    }

    public void BeginExport()
    {
      using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
      {
        if (folderBrowserDialog.ShowDialog() != DialogResult.OK || !Directory.Exists(folderBrowserDialog.SelectedPath))
          return;
        this._destinationFolder = folderBrowserDialog.SelectedPath;
        if (this._docGUIDsToExport.Count <= 0)
          return;
        Guid documentStoreGuid = (Guid) this._docGUIDsToExport.Dequeue();
        this._progressForm = new frmDocumentMoveProgress($"Exporting to {this._destinationFolder}");
        this._progressForm.Show();
        this._progressForm.TopMost = true;
        this._progressForm.SetProgress("Calculating download time", 0, this._docGUIDsToExport.Count);
        DocumentManager.SaveDocumentToFileEventHandler completedHandler = new DocumentManager.SaveDocumentToFileEventHandler(this.DocSaved);
        DocumentManager.BeginSaveDocumentToFile(documentStoreGuid, completedHandler);
        this._max = this._docGUIDsToExport.Count;
      }
    }

    public void BeginExport(string targetDirectory, Action<string> exportCompleted)
    {
      if (!Directory.Exists(targetDirectory))
        return;
      this._destinationFolder = targetDirectory;
      if (this._docGUIDsToExport.Count <= 0)
        return;
      this._exportCompletedHandler = exportCompleted;
      Guid docGuid = (Guid) this._docGUIDsToExport.Dequeue();
      this._progressForm = new frmDocumentMoveProgress("Exporting Files");
      this._progressForm.Show();
      this._progressForm.TopMost = true;
      this._progressForm.SetProgress("Calculating download time", 0, this._docGUIDsToExport.Count);
      this.SaveFileWithRename(docGuid);
      this._max = this._docGUIDsToExport.Count;
    }

    public void BeginExportSingleThread(
      DocumentManager.DownloadComplete callback,
      string targetDirectory,
      Action<string> exportCompleted)
    {
      if (!Directory.Exists(targetDirectory))
        return;
      this._destinationFolder = targetDirectory;
      if (this._docGUIDsToExport.Count <= 0)
        return;
      this._exportCompletedHandler = exportCompleted;
      this._progressForm = new frmDocumentMoveProgress("Exporting Files");
      this._progressForm.Show();
      this._progressForm.TopMost = true;
      this._progressForm.SetProgress("Calculating download time", 0, this._docGUIDsToExport.Count);
      this.SaveFileWithRenameSingleThread(callback);
      this._max = this._docGUIDsToExport.Count;
    }

    private void SaveFileWithRename(Guid docGuid)
    {
      DocumentManager.FileExporter fileExporter = this;
      Guid guid = docGuid;
      Utility.ExecuteThread((DoWorkEventHandler) ([SpecialName] (s, e) =>
      {
        string destinationFolder = fileExporter.DestinationFolder;
        try
        {
          if (fileExporter._preserverFolderStructure && fileExporter._folderLookup == null)
            fileExporter._folderLookup = DocumentManager.FileExporter.GenerateFolderLookup(fileExporter.DestinationFolder);
          if (fileExporter._folderLookup != null)
          {
            int folderId = DocumentManager.GetDocumentMetadata(guid).FolderId;
            if (folderId != -1)
            {
              destinationFolder = fileExporter._folderLookup[folderId];
              if (!Directory.Exists(destinationFolder))
                Directory.CreateDirectory(destinationFolder);
            }
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          fileExporter._preserverFolderStructure = false;
          ProjectData.ClearProjectError();
        }
        string path = DocumentManager.FetchDocumentByGuid(guid, destinationFolder);
        e.Result = (object) Path.GetFileName(path);
      }), (RunWorkerCompletedEventHandler) ([SpecialName] (s, e) => this.DocSaved((object) this, new DocumentManager.SaveDocumentToFileEventArgs(e.Result.ToString()))), (ProgressChangedEventHandler) null);
    }

    private void SaveFileWithRenameSingleThread(DocumentManager.DownloadComplete callback)
    {
      // ISSUE: variable of a compiler-generated type
      DocumentManager.FileExporter._Closure\u0024__14\u002D0 closure140;
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: reference to a compiler-generated method
      Utility.ExecuteThread(new DoWorkEventHandler(new DocumentManager.FileExporter._Closure\u0024__14\u002D0(closure140)
      {
        \u0024VB\u0024Me = this,
        \u0024VB\u0024Local_callback = callback
      }._Lambda\u0024__0), (RunWorkerCompletedEventHandler) ([SpecialName] (s, e) => this.DocSaved((object) this, new DocumentManager.SaveDocumentToFileEventArgs(e.Result.ToString()))), (ProgressChangedEventHandler) ([SpecialName] (s, e) => this._progressForm.SetProgress("Downloading...", e.ProgressPercentage, this._max)));
    }

    private static Dictionary<int, string> GenerateFolderLookup(string rootPath)
    {
      // ISSUE: variable of a compiler-generated type
      DocumentManager.FileExporter._Closure\u0024__15\u002D0 closure150_1;
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      DocumentManager.FileExporter._Closure\u0024__15\u002D0 closure150_2 = new DocumentManager.FileExporter._Closure\u0024__15\u002D0(closure150_1);
      // ISSUE: reference to a compiler-generated field
      closure150_2.\u0024VB\u0024Local_str = rootPath;
      // ISSUE: reference to a compiler-generated field
      if (string.IsNullOrWhiteSpace(closure150_2.\u0024VB\u0024Local_str))
        throw new ArgumentNullException(nameof (rootPath));
      // ISSUE: reference to a compiler-generated field
      if (!closure150_2.\u0024VB\u0024Local_str.EndsWith("\\"))
      {
        // ISSUE: reference to a compiler-generated field
        closure150_2.\u0024VB\u0024Local_str += "\\";
      }
      DataTable source = DefaultDatabase.ExecuteDataTable("DocumentSystem_FetchResolvedFolders");
      Dictionary<int, string> folderLookup = new Dictionary<int, string>();
      try
      {
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated field
        foreach (var data in source.AsEnumerable().Select(closure150_2.\u0024I0 == null ? (closure150_2.\u0024I0 = new System.Func<DataRow, VB\u0024AnonymousType_0<int, string>>(closure150_2._Lambda\u0024__0)) : closure150_2.\u0024I0))
        {
          string str = data.Path;
          foreach (char invalidPathChar in Path.GetInvalidPathChars())
            str = str.Replace(invalidPathChar.ToString(), "");
          folderLookup.Add(data.FolderID, str);
        }
      }
      finally
      {
        IEnumerator<VB\u0024AnonymousType_0<int, string>> enumerator;
        enumerator?.Dispose();
      }
      return folderLookup;
    }

    private int CurrentPlace => this._max - this._docGUIDsToExport.Count;

    private void DocSaved(object sender, DocumentManager.SaveDocumentToFileEventArgs e)
    {
      FileInfo fileInfo = new FileInfo(e.FileName);
      string path = $"{this.DestinationFolder}{fileInfo.Name.Replace("~", "")}";
      if (this._progressForm != null)
        this._progressForm.SetProgress($"Downloading {fileInfo.Name}", this.CurrentPlace, this._max);
      if (this._docGUIDsToExport.Count > 0)
      {
        Guid guid = (Guid) this._docGUIDsToExport.Dequeue();
        if (this._exportCompletedHandler == null)
          DocumentManager.BeginSaveDocumentToFile(guid, new DocumentManager.SaveDocumentToFileEventHandler(this.DocSaved));
        else
          this.SaveFileWithRename(guid);
      }
      else
      {
        this._progressForm.Close();
        this._progressForm.Dispose();
        this._progressForm = (frmDocumentMoveProgress) null;
        if (this._exportCompletedHandler != null)
        {
          this._exportCompletedHandler(this.DestinationFolder);
          this._exportCompletedHandler = (Action<string>) null;
        }
      }
      if (!File.Exists(e.FileName))
        return;
      if (File.Exists(path))
        return;
      try
      {
        File.Move(e.FileName, this.DestinationFolder + fileInfo.Name);
      }
      catch (IOException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        int num = (int) System.Windows.Forms.MessageBox.Show($"The system was unable to save {e.FileName}.", "File in use", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        ProjectData.ClearProjectError();
      }
    }

    private string DestinationFolder
    {
      get
      {
        if (!this._destinationFolder.EndsWith("\\"))
        {
          string& local;
          string str = ^(local = ref this._destinationFolder) + "\\";
          local = str;
        }
        return this._destinationFolder;
      }
    }
  }

  private delegate void EmailDocumentsWithoutZippingThreadHandler(object state);

  private delegate void SendEmailOnUIThreadHandler(
    DocumentEmailsContext context,
    List<string> documentPaths);

  private delegate void ErrorOnThreadHandler(Exception ex);
}
