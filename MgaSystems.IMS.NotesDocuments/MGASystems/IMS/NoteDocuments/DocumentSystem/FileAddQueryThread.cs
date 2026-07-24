// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.NoteDocuments.DocumentSystem.FileAddQueryThread
// Assembly: MgaSystems.IMS.NotesDocuments, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 3F898CF7-066D-4B05-A9F1-D37DBC4FAA16
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.NotesDocuments.dll

using MGASystems.Common;
using MGASystems.Common.CustomExceptions;
using MGASystems.Common.DataAccess;
using MGASystems.Common.ErrorHandling;
using MGASystems.Common.Extensions;
using MGASystems.Common.NativeWindowMethods;
using MGASystems.Data;
using MGASystems.IMS.Logging;
using MGASystems.IMS.NoteDocuments.NoteDiarySystem;
using MGASystems.Tools;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.NoteDocuments.DocumentSystem;

internal sealed class FileAddQueryThread : QueryThread
{
  private string _fileName;
  private long _originalFileSize;
  private string _saveFileName;
  private string _path;
  private DocSupportCache _docSupport;
  private int _folderID;
  private string _description;
  private Guid _documentGuid;
  private byte[] _documentBytes;
  private DocumentManager.FileAddedAndBound _fileAdded;
  private byte[] _thumbImage;
  private string _context;
  private bool _attachNote;
  private bool _noteIsDiary;
  private string _metaXml;
  private bool _copyForwardOnRenewal;
  private string _additionalSaveData;
  private Guid _documentTypeGuid;
  private bool _copyToOtherQuotesOnSubmission;
  private bool _CopyAssociationForwardOnlyOnce;

  public FileAddQueryThread(
    DocumentManager.FileAddedAndBound fileAdded,
    bool deleteFileAfterUpload,
    string path,
    ISupportDocumentSystem docSupport,
    int folderID,
    string description,
    string context,
    bool attachNote,
    bool noteIsDiary,
    bool copyForwardOnRenewal,
    string additionalSaveData,
    bool copyToOtherQuotesOnSubmission,
    bool CopyAssociationForwardOnlyOnce)
    : base(MGASystems.IMS.NoteDocuments.Common.UIContext, (object) nameof (FileAddQueryThread), "")
  {
    this.Initialize(fileAdded, string.Empty, deleteFileAfterUpload, path, docSupport, folderID, description, context, attachNote, noteIsDiary, copyForwardOnRenewal, additionalSaveData, copyToOtherQuotesOnSubmission, CopyAssociationForwardOnlyOnce);
  }

  public FileAddQueryThread(
    DocumentManager.FileAddedAndBound fileAdded,
    bool deleteFileAfterUpload,
    string path,
    ISupportDocumentSystem docSupport,
    int folderID,
    string description,
    string context,
    bool attachNote,
    bool noteIsDiary,
    bool copyForwardOnRenewal,
    bool copyToOtherQuotesOnSubmission,
    bool CopyAssociationForwardOnlyOnce)
    : base(MGASystems.IMS.NoteDocuments.Common.UIContext, (object) nameof (FileAddQueryThread), "")
  {
    this.Initialize(fileAdded, string.Empty, deleteFileAfterUpload, path, docSupport, folderID, description, context, attachNote, noteIsDiary, copyForwardOnRenewal, "", copyToOtherQuotesOnSubmission, CopyAssociationForwardOnlyOnce);
  }

  private void Initialize(
    DocumentManager.FileAddedAndBound fileAdded,
    string saveFileName,
    bool deleteFileAfterUpload,
    string path,
    ISupportDocumentSystem docSupport,
    int folderID,
    string description,
    string context,
    bool attachNote,
    bool noteIsDiary,
    bool copyForwardOnRenewal,
    string additionalSaveData,
    bool copyToOtherQuotesOnSubmission,
    bool CopyAssociationForwardOnlyOnce)
  {
    this._additionalSaveData = additionalSaveData;
    this._copyForwardOnRenewal = copyForwardOnRenewal;
    this._copyToOtherQuotesOnSubmission = copyToOtherQuotesOnSubmission;
    this._CopyAssociationForwardOnlyOnce = CopyAssociationForwardOnlyOnce;
    this._context = context.Length <= 250 ? context : throw new ArgumentException("Context must be less than 250 characters", nameof (context));
    this._attachNote = attachNote;
    this._noteIsDiary = noteIsDiary;
    if (string.IsNullOrEmpty(path))
      throw new ArgumentException("Path can not be empty", nameof (path));
    if (!File.Exists(path))
      throw new ArgumentException("File does not exist");
    if (docSupport != null)
      this._docSupport = new DocSupportCache(docSupport);
    this._fileAdded = fileAdded;
    this._path = path;
    this._folderID = folderID;
    this._description = description;
    this._saveFileName = saveFileName;
    FileInfo fileInfo = new FileInfo(this._path);
    this._fileName = fileInfo.Name;
    this._originalFileSize = fileInfo.Length;
    bool flag;
    if ((fileInfo.Attributes & FileAttributes.ReadOnly) != (FileAttributes) 0)
    {
      fileInfo.Attributes &= ~FileAttributes.ReadOnly;
      flag = true;
    }
    if (string.Compare(fileInfo.Extension, ".msg", true) == 0)
    {
      try
      {
        this._metaXml = OutlookMessageHandler.GetMailMetaData(this._path).ToXml();
      }
      catch (IOException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        this._metaXml = string.Empty;
        ProjectData.ClearProjectError();
      }
    }
    using (FileStream fileStream = new FileStream(this._path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
    {
      this._documentBytes = new byte[(int) fileStream.Length - 1 + 1];
      fileStream.Read(this._documentBytes, 0, (int) fileStream.Length);
      fileStream.Close();
    }
    Bitmap thumbnail = ThumbnailExtractor.ThumbnailExtractor.GenerateThumbnail(this._path, new Size(200, 200));
    if (thumbnail != null)
    {
      using (thumbnail)
      {
        using (MemoryStream memoryStream = new MemoryStream())
        {
          thumbnail.Save((Stream) memoryStream, ImageFormat.Jpeg);
          byte[] buffer = new byte[(int) (memoryStream.Length - 1L) + 1];
          this._thumbImage = buffer;
          memoryStream.Position = 0L;
          memoryStream.Read(buffer, 0, (int) memoryStream.Length);
        }
      }
    }
    if (!flag)
      return;
    fileInfo.Attributes |= FileAttributes.ReadOnly;
  }

  public Guid DocumentStoreGuid
  {
    get => this._documentGuid;
    set => this._documentGuid = value;
  }

  public Guid DocumentTypeGuid
  {
    get => this._documentTypeGuid;
    set => this._documentTypeGuid = value;
  }

  protected override void ThreadCompletedUI()
  {
    if (this._fileAdded != null)
      this._fileAdded(this._documentGuid);
    if (this._docSupport != null)
      DocumentManager.FireDocumentBound(this._documentGuid, this._docSupport, this._path, this._folderID);
    if (this._attachNote && this._docSupport != null)
    {
      DocSupportCache docSupport = this._docSupport;
      NoteSupportCache noteSupport1 = new NoteSupportCache(docSupport.EntityGUID, docSupport.EntityName, docSupport.FriendlyEntityName, docSupport.RecreateTypeName, docSupport.HasControlGUID, docSupport.ControlGUID);
      if (ObjectFactory.Instance.CreateObjectEX(typeof (NoteOverrideInformation), (object) "attaching note to file", (object) new object[4]
      {
        (object) noteSupport1,
        (object) this._noteIsDiary,
        (object) this._documentGuid,
        (object) this._fileName
      }) is NoteOverrideInformation objectEx && objectEx.CancelOperation)
      {
        objectEx.PerformOverrideAction();
      }
      else
      {
        Guid boundNote;
        if (this._noteIsDiary)
        {
          Note_System.NonInteractiveNoteManipulator nonInteractive = Note_System.Instance.NonInteractive;
          Guid userGuid = CurrentUser.Instance.UserGUID;
          Guid[] recipientGUIDs = new Guid[1]
          {
            CurrentUser.Instance.UserGUID
          };
          Guid[] diaryRecipientGUIDs = new Guid[1]
          {
            CurrentUser.Instance.UserGUID
          };
          NoteSupportCache noteSupport2 = noteSupport1;
          DateTime now = DateAndTime.Now;
          DateTime deadlineDate = now.AddDays(7.0);
          now = DateAndTime.Now;
          DateTime finalDeadline = now.AddDays(14.0);
          boundNote = nonInteractive.CreateBoundNote(-1, "", userGuid, "", false, recipientGUIDs, diaryRecipientGUIDs, (ISupportNoteSystem) noteSupport2, deadlineDate, finalDeadline);
        }
        else
          boundNote = Note_System.Instance.NonInteractive.CreateBoundNote(-1, "", CurrentUser.Instance.UserGUID, "", false, new Guid[1]
          {
            CurrentUser.Instance.UserGUID
          }, (ISupportNoteSystem) noteSupport1);
        Note_System.Instance.UIInteractive.ViewNote(boundNote, new Guid[1]
        {
          this._documentGuid
        }, (ISupportDocumentSystem) this._docSupport);
      }
    }
    DocumentManager.FireEntityDocumentCollectionChanged();
    DocumentManager.FireUserDocumentCollectionChanged();
  }

  protected override void ThreadProcBG()
  {
    if (this.DB == null)
      throw new InvalidOperationException("MyBase.DB is null in FileAddQueryThread.ThreadProcBG");
    try
    {
      if (!DefaultDatabase.HasTransaction)
        DefaultDatabase.ExecuteTransaction((EventHandler<ExecuteTransactionEventArgs>) ([SpecialName] (ignore, transactionArgs) =>
        {
          this.ThreadProcBG();
          transactionArgs.Transaction.Commit();
        }));
      else
        this.FileAdd_QuerySet((object) null, new ExecuteTransactionEventArgs(DefaultDatabase.Transaction, (object) null));
    }
    catch (ConnectionClosedDuringTransactionException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      MDIControls.Instance.MDIParent.BeginInvoke((Delegate) new FileAddQueryThread.ShowErrorMessageOnUIThreadHandler(this.ShowErrorMessageOnUIThread), (object) ex);
      ProjectData.ClearProjectError();
    }
  }

  private void ShowErrorMessageOnUIThread(Exception ex)
  {
    int num = (int) MessageBox.Show($"A connection to the database was lost while trying to add the following file to the document system:{"\n"}{"\n"}Filename: {this._fileName}{"\n"}Description: {this._description}{"\n"}{"\n"}The file has not been added.", "Error Storing File", MessageBoxButtons.OK, MessageBoxIcon.Hand);
  }

  private static void WriteLog(string methodName, string logMessage)
  {
    try
    {
      Log.Write($"FileAddQueryThread.{methodName} {logMessage}", "DocumentSystem.DocumentManager");
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      ErrorHandler.SilentHandleError(ex);
      ProjectData.ClearProjectError();
    }
  }

  private Guid FileAdd_QuerySet(object sender, ExecuteTransactionEventArgs e)
  {
    FileAddQueryThread.WriteLog(nameof (FileAdd_QuerySet), "Invoking");
    int num = 9;
    bool flag1 = false;
    string typeName = FileInfoEx.GetTypeName(this._fileName);
    byte[] numArray1 = (byte[]) null;
    if (this._documentGuid.Equals(Guid.Empty))
      this._documentGuid = Guid.NewGuid();
    byte[] numArray2 = this._documentBytes;
    try
    {
      FileAddQueryThread.WriteLog(nameof (FileAdd_QuerySet), "Testing whether or not we want to zip the document");
      numArray1 = new ZipUtility().CompressStreamToNewZipStream(numArray2, this._fileName);
      FileAddQueryThread.WriteLog(nameof (FileAdd_QuerySet), "Tested whether or not we want to zip the document");
    }
    catch (FileNotFoundException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      flag1 = true;
      ProjectData.ClearProjectError();
    }
    bool flag2;
    if (flag1 || numArray2.Length < numArray1.Length)
    {
      flag2 = false;
      num = 0;
    }
    else
    {
      flag2 = true;
      numArray2 = numArray1;
    }
    if (this._saveFileName.Length > 0)
      this._fileName = this._saveFileName;
    if (numArray2.Length == 0)
      throw new InvalidOperationException("Document image length cannot be 0");
    if (MGASystems.Common.Settings.SystemSettings.GetSetting<bool>("SaveDocument.UseDescription"))
      this._fileName = $"{this._description}{Path.GetExtension(this._fileName)}";
    this._fileName = DocumentManager.EnsureProperFileName(this._fileName);
    if (this._thumbImage == null)
      this._thumbImage = new byte[0];
    try
    {
      FileAddQueryThread.WriteLog(nameof (FileAdd_QuerySet), "Executing DocumentSystem_InsertDocument");
      DefaultDatabase.ExecuteNonQuery("dbo.DocumentSystem_InsertDocument", new object[32 /*0x20*/]
      {
        (object) "@DocumentGuid",
        (object) this._documentGuid,
        (object) "@Description",
        (object) this._description,
        (object) "@FileAssociation",
        (object) typeName,
        (object) "@DocumentImage",
        (object) new byte[0],
        (object) "@DateAdded",
        (object) DateTime.Now,
        (object) "@FileName",
        (object) this._fileName,
        (object) "@UserGuidOriginator",
        (object) MGASystems.IMS.NoteDocuments.Common.UserGUID,
        (object) "@CompressionLevel",
        (object) num,
        (object) "@Compressed",
        (object) flag2,
        (object) "@OriginalFileSize",
        (object) this._originalFileSize,
        (object) "@DocumentThumbnail",
        (object) this._thumbImage,
        (object) "@FolderID",
        Interaction.IIf(this._folderID == -1, (object) DBNull.Value, (object) this._folderID),
        (object) "@MetaXML",
        (object) Utility.IsNull<string>((object) this._metaXml, ""),
        (object) "@CopyAssociationsForwardOnRenewal",
        (object) this._copyForwardOnRenewal,
        (object) "@TypeGuid",
        Interaction.IIf(this._documentTypeGuid == Guid.Empty, (object) DBNull.Value, (object) this._documentTypeGuid),
        (object) "@CopyAssociationForwardOnlyOnce",
        (object) this._CopyAssociationForwardOnlyOnce
      });
      FileAddQueryThread.WriteLog(nameof (FileAdd_QuerySet), "Uploading Document To Database");
      FileAddQueryThread.SendDocumentToRepository(this._documentGuid, numArray2, this._description);
      FileAddQueryThread.WriteLog(nameof (FileAdd_QuerySet), "Uploaded Document To Database");
      DefaultDatabase.ExecuteNonQuery("DocumentSystem_UpdateDocumentActualSize", new object[2]
      {
        (object) "@DocumentGuid",
        (object) this._documentGuid
      });
      if (this._docSupport != null)
      {
        DocSupportCache docSupport = this._docSupport;
        FileAddQueryThread.WriteLog(nameof (FileAdd_QuerySet), "Adding Document Association");
        if (docSupport.CanReCreateEntity)
        {
          if (string.IsNullOrEmpty(docSupport.RecreateTypeName))
            throw new ArgumentException("RecreateTypeName can not be empty on an item that returns true for CanReCreateEntity");
          if (string.IsNullOrEmpty(docSupport.EntityName))
            throw new ArgumentException("EntityName can not be empty on an item that returns true for CanReCreateEntity");
          if (string.IsNullOrEmpty(docSupport.FriendlyEntityName))
            throw new ArgumentException("FriendlyEntityName can not be empty on an item that returns true for CanReCreateEntity");
          DefaultDatabase.ExecuteNonQuery("DocumentSystem_InsertDocumentAssociation", new object[14]
          {
            (object) "@DocumentStoreGuid",
            (object) this._documentGuid,
            (object) "@AssociatedEntityGuid",
            (object) docSupport.EntityGUID,
            (object) "@AssociatedEntityType",
            (object) docSupport.RecreateTypeName,
            (object) "@AssociatedEntityName",
            (object) docSupport.EntityName,
            (object) "@AssociatedEntityFormName",
            (object) docSupport.FriendlyEntityName,
            (object) "@ControlGuid",
            Interaction.IIf(docSupport.HasControlGUID, (object) docSupport.ControlGUID, (object) DBNull.Value),
            (object) "@Context",
            Interaction.IIf(this._context.Length == 0, (object) DBNull.Value, (object) this._context)
          });
          DocumentManager.SendDocumentBoundBroadcastMessage(this._documentGuid, docSupport.EntityGUID, docSupport.RecreateTypeName, docSupport.EntityName, docSupport.FriendlyEntityName, new Guid?(docSupport.HasControlGUID ? docSupport.ControlGUID : new Guid()));
        }
        else
        {
          DefaultDatabase.ExecuteNonQuery("DocumentSystem_InsertDocumentAssociation", new object[14]
          {
            (object) "@DocumentStoreGuid",
            (object) this._documentGuid,
            (object) "@AssociatedEntityGuid",
            (object) docSupport.EntityGUID,
            (object) "@AssociatedEntityType",
            (object) string.Empty,
            (object) "@AssociatedEntityName",
            (object) string.Empty,
            (object) "@AssociatedEntityFormName",
            (object) string.Empty,
            (object) "@ControlGuid",
            Interaction.IIf(docSupport.HasControlGUID, (object) docSupport.ControlGUID, (object) DBNull.Value),
            (object) "@Context",
            Interaction.IIf(this._context.Length == 0, (object) DBNull.Value, (object) this._context)
          });
          DocumentManager.SendDocumentBoundBroadcastMessage(this._documentGuid, docSupport.EntityGUID, string.Empty, string.Empty, string.Empty, new Guid?(docSupport.HasControlGUID ? docSupport.ControlGUID : new Guid()));
        }
        FileAddQueryThread.WriteLog(nameof (FileAdd_QuerySet), "Added Document Association");
        try
        {
          if (this._copyToOtherQuotesOnSubmission)
          {
            try
            {
              EnumerableRowCollection<DataRow> source = DefaultDatabase.ExecuteDataTable("DocumentSystem_FetchOtherQuotesOnSubmission", new object[2]
              {
                (object) "@ControlGuid",
                (object) this._docSupport.ControlGUID
              }).AsEnumerable();
              System.Func<DataRow, IRecreatableEntity> selector;
              // ISSUE: reference to a compiler-generated field
              if (FileAddQueryThread._Closure\u0024__.\u0024I34\u002D0 != null)
              {
                // ISSUE: reference to a compiler-generated field
                selector = FileAddQueryThread._Closure\u0024__.\u0024I34\u002D0;
              }
              else
              {
                // ISSUE: reference to a compiler-generated field
                FileAddQueryThread._Closure\u0024__.\u0024I34\u002D0 = selector = (System.Func<DataRow, IRecreatableEntity>) ([SpecialName] (row) => FileAddQueryThread.GetIRecreatableEntityFromQuote(row.Field<Guid>("QuoteGuid")));
              }
              foreach (IRecreatableEntity recreatableEntity in source.Select<DataRow, IRecreatableEntity>(selector))
              {
                DefaultDatabase.ExecuteNonQuery("DocumentSystem_InsertDocumentAssociation", new object[14]
                {
                  (object) "@DocumentStoreGuid",
                  (object) this._documentGuid,
                  (object) "@AssociatedEntityGuid",
                  (object) recreatableEntity.EntityGuid,
                  (object) "@AssociatedEntityType",
                  (object) recreatableEntity.RecreateTypeName,
                  (object) "@AssociatedEntityName",
                  (object) recreatableEntity.EntityName,
                  (object) "@AssociatedEntityFormName",
                  (object) recreatableEntity.FriendlyEntityName,
                  (object) "@ControlGuid",
                  Interaction.IIf(recreatableEntity.HasControlGUID, (object) recreatableEntity.ControlGUID, (object) DBNull.Value),
                  (object) "@Context",
                  Interaction.IIf(this._context.Length == 0, (object) DBNull.Value, (object) this._context)
                });
                DocumentManager.SendDocumentBoundBroadcastMessage(this._documentGuid, recreatableEntity.EntityGuid, recreatableEntity.RecreateTypeName, recreatableEntity.EntityName, recreatableEntity.FriendlyEntityName, new Guid?(recreatableEntity.HasControlGUID ? recreatableEntity.ControlGUID : new Guid()));
              }
            }
            finally
            {
              IEnumerator<IRecreatableEntity> enumerator;
              enumerator?.Dispose();
            }
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ErrorHandler.SilentHandleError(ex);
          ProjectData.ClearProjectError();
        }
      }
      FileAddQueryThread.WriteLog(nameof (FileAdd_QuerySet), "Done uploading Document");
      string action = $"Add Document: {this._fileName}{RuntimeHelpers.GetObjectValue(Interaction.IIf(Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this._description, string.Empty, false) == 0, (object) string.Empty, (object) $" - {this._description}"))}";
      FileAddQueryThread.WriteLog(nameof (FileAdd_QuerySet), "logging the upload action to the current user");
      if (this._docSupport == null)
        CurrentUser.Instance.LogAction(action);
      else
        CurrentUser.Instance.LogAction(action, this._docSupport.EntityGUID);
      if (!string.IsNullOrWhiteSpace(this._additionalSaveData))
        DocumentSystemFileAdditonalDataOverride.Create().OnDocumentSaved(this._documentGuid, this._additionalSaveData);
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      ErrorHandler.SilentHandleError(ex);
      throw;
    }
    return this._documentGuid;
  }

  private static IRecreatableEntity GetIRecreatableEntityFromQuote(Guid quoteGuid)
  {
    return (IRecreatableEntity) ObjectFactory.Instance.CreateObject(ObjectFactory.Instance.CreateTypeFromString("MGASystems.BusinessObjects.Quote"), new object[1]
    {
      (object) quoteGuid
    });
  }

  private static void SendDocumentToRepository(
    Guid documentStoreGuid,
    byte[] document,
    string description)
  {
    FileAddQueryThread.WriteLog("SendDocumentToDatabase", "Beginning upload to the database");
    bool flag = !MDIControls.Instance.BlackBoxMode && MDIControls.Instance?.MDIParent != null && !MDIControls.Instance.MDIParent.IsDisposed && !MDIControls.Instance.MDIParent.InvokeRequired;
    using (CancellationTokenSource cancellationTokenSource = new CancellationTokenSource())
    {
      CancellationToken token = cancellationTokenSource.Token;
      using (frmUploadDocument frmProgress = flag ? new frmUploadDocument(description) : (frmUploadDocument) null)
      {
        if (frmProgress != null)
        {
          frmUploadDocument frmUploadDocument = frmProgress;
          frmUploadDocument.MdiParent = MDIControls.Instance.MDIParent;
          frmUploadDocument.Show();
          frmUploadDocument.Refresh();
        }
        DocumentManager.PutDocument(documentStoreGuid, document, token, (Action<int>) ([SpecialName] (count) => FileAddQueryThread.UpdateProgress(frmProgress, count, closure_0)));
        token.ThrowIfCancellationRequested();
      }
    }
  }

  private static void UpdateProgress(
    frmUploadDocument frmProgress,
    int count,
    CancellationTokenSource tokenSource)
  {
    if (frmProgress == null)
      return;
    if (frmProgress.InvokeRequired)
    {
      frmProgress.BetterInvoke((Action) ([SpecialName] () => FileAddQueryThread.UpdateProgress(frmProgress, count, tokenSource)));
    }
    else
    {
      frmProgress.SetProgressBarValue(count);
      frmUploadDocument frmUploadDocument = frmProgress;
      if ((frmUploadDocument != null ? (frmUploadDocument.CancelRequested ? 1 : 0) : 0) == 0)
        return;
      tokenSource.Cancel();
    }
  }

  public Guid StartNonThreaded()
  {
    FileAddQueryThread fileAddQueryThread = this;
    Guid guid;
    if (!DefaultDatabase.HasTransaction)
    {
      DefaultDatabase.ExecuteTransaction((EventHandler<ExecuteTransactionEventArgs>) ([SpecialName] (ignore, transactionArgs) =>
      {
        guid = fileAddQueryThread.StartNonThreaded();
        transactionArgs.Transaction.Commit();
      }));
      guid = guid;
    }
    else
    {
      Guid guid1 = this.FileAdd_QuerySet((object) null, new ExecuteTransactionEventArgs(DefaultDatabase.Transaction, (object) null));
      this.ThreadCompletedUI();
      guid = guid1;
    }
    return guid;
  }

  private delegate void ShowErrorMessageOnUIThreadHandler(Exception ex);
}
