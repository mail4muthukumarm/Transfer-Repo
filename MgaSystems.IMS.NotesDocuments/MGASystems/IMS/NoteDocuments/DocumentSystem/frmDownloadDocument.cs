// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.NoteDocuments.DocumentSystem.frmDownloadDocument
// Assembly: MgaSystems.IMS.NotesDocuments, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 3F898CF7-066D-4B05-A9F1-D37DBC4FAA16
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.NotesDocuments.dll

using Infragistics.Win;
using Infragistics.Win.Misc.CommonControls;
using Infragistics.Win.UltraWinProgressBar;
using MGASystems.Common;
using MGASystems.Common.Extensions;
using MGASystems.Common.FileIO;
using MGASystems.Data;
using MGASystems.ExtendedEditors.ShellLink;
using MGASystems.IMS.DocumentStorage;
using MGASystems.Tools;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.NoteDocuments.DocumentSystem;

[SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly")]
public class frmDownloadDocument : Form
{
  private IContainer components;
  private string _localFilename;
  private Metadata _metadata;
  private bool _exitDownload;
  private bool _trackRevisions;
  private bool _useOpenWithDialog;
  private bool _launchFileWhenDone;
  private frmDownloadDocument.DownloadComplete _callback;
  private bool _cancel;
  private Guid _documentStoreGuid;
  private string _tempPath;
  private bool _disposing;
  private readonly CancellationTokenSource _cancellationSource;

  protected override void Dispose(bool disposing)
  {
    this._disposing = disposing;
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  [field: AccessedThroughProperty("AnimationControl1")]
  internal virtual AnimationControl AnimationControl1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label1")]
  internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("progress")]
  internal virtual UltraProgressBar progress { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual LinkLabel lnkCancel
  {
    get => this._lnkCancel;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkCancel_LinkClicked);
      LinkLabel lnkCancel1 = this._lnkCancel;
      if (lnkCancel1 != null)
        lnkCancel1.LinkClicked -= clickedEventHandler;
      this._lnkCancel = value;
      LinkLabel lnkCancel2 = this._lnkCancel;
      if (lnkCancel2 == null)
        return;
      lnkCancel2.LinkClicked += clickedEventHandler;
    }
  }

  [field: AccessedThroughProperty("lblLaunchingFile")]
  internal virtual Label lblLaunchingFile { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.AnimationControl1 = new AnimationControl();
    this.Label1 = new Label();
    this.progress = new UltraProgressBar();
    this.lnkCancel = new LinkLabel();
    this.lblLaunchingFile = new Label();
    this.SuspendLayout();
    this.AnimationControl1.AnimationSource = (AnimationType) 160 /*0xA0*/;
    this.AnimationControl1.BorderStyle = BorderStyle.None;
    ((Control) this.AnimationControl1).Location = new Point(141, 55);
    ((Control) this.AnimationControl1).Name = "AnimationControl1";
    ((Control) this.AnimationControl1).Size = new Size(272, 60);
    ((Control) this.AnimationControl1).TabIndex = 0;
    this.Label1.AutoSize = true;
    this.Label1.Font = new Font("Tahoma", 12f);
    this.Label1.Location = new Point(89, 20);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(376, 23);
    this.Label1.TabIndex = 1;
    this.Label1.Text = "Please wait while the system downloads your file...";
    ((Control) this.progress).Location = new Point(15, 130);
    ((Control) this.progress).Name = "progress";
    ((Control) this.progress).Size = new Size(525, 15);
    ((Control) this.progress).TabIndex = 2;
    this.progress.Text = "[Formatted]";
    this.lnkCancel.Location = new Point(227, 150);
    this.lnkCancel.Name = "lnkCancel";
    this.lnkCancel.TabIndex = 3;
    this.lnkCancel.TabStop = true;
    this.lnkCancel.Text = "Cancel Download";
    this.lnkCancel.TextAlign = ContentAlignment.MiddleCenter;
    this.lblLaunchingFile.AutoSize = true;
    this.lblLaunchingFile.Font = new Font("Tahoma", 10f);
    this.lblLaunchingFile.Location = new Point(160 /*0xA0*/, 130);
    this.lblLaunchingFile.Name = "lblLaunchingFile";
    this.lblLaunchingFile.Size = new Size(234, 20);
    this.lblLaunchingFile.TabIndex = 4;
    this.lblLaunchingFile.Text = "Download complete... launching file...";
    this.lblLaunchingFile.Visible = false;
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.White;
    this.ClientSize = new Size(554, 230);
    this.Controls.Add((Control) this.lblLaunchingFile);
    this.Controls.Add((Control) this.lnkCancel);
    this.Controls.Add((Control) this.progress);
    this.Controls.Add((Control) this.Label1);
    this.Controls.Add((Control) this.AnimationControl1);
    this.Font = new Font("Tahoma", 8.25f);
    this.ForeColor = Color.Black;
    this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
    this.Name = nameof (frmDownloadDocument);
    this.Text = "Downloading \"{0}\"..";
    this.ResumeLayout(false);
  }

  internal bool DownloadAborted => this._cancel;

  internal string TempPath
  {
    get => this._tempPath;
    set => this._tempPath = value;
  }

  internal bool LaunchFileWhenDone
  {
    get => this._launchFileWhenDone;
    set => this._launchFileWhenDone = value;
  }

  public static string FixLongFilename(string fileName)
  {
    if (string.IsNullOrEmpty(fileName))
      throw new ArgumentNullException(nameof (fileName));
    int length = (int) byte.MaxValue - Path.GetTempPath().Length;
    if (length > 220)
      length = (int) Math.Round((double) length / 2.0);
    if (fileName.Length > length)
      fileName = fileName.Substring(fileName.Length - length, length);
    return fileName;
  }

  public static string RemoveInvalidCharsFromFileName(string fileName)
  {
    if (string.IsNullOrEmpty(fileName))
      throw new ArgumentNullException(nameof (fileName));
    char[] invalidFileNameChars = DocumentManager.GetInvalidFileNameChars();
    int index = 0;
    while (index < invalidFileNameChars.Length)
    {
      char ch = invalidFileNameChars[index];
      fileName = fileName.Replace(ch.ToString(), string.Empty);
      checked { ++index; }
    }
    return fileName;
  }

  public frmDownloadDocument(Guid documentStoreGuid, frmDownloadDocument.DownloadComplete callback)
    : this(documentStoreGuid, false, false)
  {
    this._callback = callback;
  }

  public frmDownloadDocument(Guid documentStoreGuid)
    : this(documentStoreGuid, false, false)
  {
  }

  public frmDownloadDocument(Guid documentStoreGuid, bool trackRevisions, bool useOpenWithDialog)
  {
    this.Load += new EventHandler(this.frmDownloadDocument_Load);
    this.Closing += new CancelEventHandler(this.frmDownloadDocument_Closing);
    this._launchFileWhenDone = true;
    this._tempPath = MGATempFolder.MGATempRandomWatchedFilesPath;
    this._disposing = false;
    this._cancellationSource = new CancellationTokenSource();
    this.InitializeComponent();
    this._metadata = DocumentManager.GetDocumentMetadata(documentStoreGuid);
    this._trackRevisions = trackRevisions;
    this._useOpenWithDialog = useOpenWithDialog;
    this.Text = string.Format(this.Text, (object) this._metadata.FileName);
    this._documentStoreGuid = documentStoreGuid;
    CurrentUser.Instance.LogAction($"Downloaded Document - \"{this._metadata.Description}\"", this._metadata.DocumentStoreGuid);
  }

  private void frmDownloadDocument_Load(object sender, EventArgs e)
  {
    Cursor.Current = MgaCursors.WaitCursor;
    this.AnimationControl1.Play();
    ThreadPool.QueueUserWorkItem(new WaitCallback(this.GetDocumentThread));
    this.Cursor = MgaCursors.Working;
  }

  [SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes")]
  private void GetDocumentThread(object state)
  {
    try
    {
      this._localFilename = this.FixLocalizeLongFilename(this._metadata.FileName);
      this._localFilename = frmDownloadDocument.RemoveInvalidCharsFromFileName(this._localFilename);
      using (FileStream output = new FileStream(this._tempPath + this._localFilename, FileMode.OpenOrCreate, FileAccess.Write))
      {
        using (BinaryWriter binaryWriter = new BinaryWriter((Stream) output))
          binaryWriter.Write(DocumentManager.GetDocumentBinary(this._metadata.DocumentStoreGuid, this._cancellationSource.Token, (Action<int>) ([SpecialName] (i) => this.MoveProgress(i))));
      }
      if (!this._exitDownload)
        this.LaunchFile();
      else
        File.Delete(this._tempPath + this._localFilename);
    }
    catch (OperationCanceledException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      ProjectData.ClearProjectError();
    }
    catch (IOException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      if (!ex.Message.Contains("There is not enough space on the disk.", StringComparison.InvariantCultureIgnoreCase))
        throw;
      int num = (int) MessageBox.Show("There is not enough disk space available. Please free up space and try again.", "Out of disk space!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      ProjectData.ClearProjectError();
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      this.HandleErrorOnUIThread(ex);
      ProjectData.ClearProjectError();
    }
    this._cancel = true;
    MDIControls.Instance.MDIParent.BetterInvoke(new Action(this.CloseForm));
  }

  private void HandleErrorOnUIThread(Exception ex)
  {
    if (MDIControls.Instance.MDIParent.InvokeRequired)
      MDIControls.Instance.MDIParent.BetterInvoke((Delegate) new frmDownloadDocument.HandleErrorOnUIThreadHandler(this.HandleErrorOnUIThread), (object) ex);
    else
      Utility.ErrorHandling.HandleError(ex);
  }

  private void SetProgressMax(int max) => this.progress.Maximum = max;

  private void MoveProgress(int value)
  {
    frmDownloadDocument downloadDocument = this;
    int num = value;
    if (this.progress == null | this._disposing)
      return;
    if (((Control) this.progress).InvokeRequired)
    {
      try
      {
        ((ISynchronizeInvoke) this.progress).BetterInvoke((Delegate) ([SpecialName] () => downloadDocument.MoveProgress(num)));
      }
      catch (ObjectDisposedException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        ProjectData.ClearProjectError();
      }
    }
    else
    {
      this.progress.Value = num;
      ((UltraControlBase) this.progress).Refresh();
    }
  }

  private void LaunchFile()
  {
    if (MDIControls.Instance.MDIParent.InvokeRequired)
    {
      MDIControls.Instance.MDIParent.BetterInvoke(new Action(this.LaunchFile));
    }
    else
    {
      MDIControls.Instance.MDIParent.Refresh();
      ((Control) this.progress).Visible = false;
      if (!this._launchFileWhenDone)
        this.lblLaunchingFile.Text = "Download complete ... please wait ...";
      this.lblLaunchingFile.Visible = true;
      this.Refresh();
      string str = this._tempPath + this._localFilename;
      try
      {
        if (this._metadata.Compressed)
        {
          try
          {
            FilePath.Extract(str);
          }
          catch (InvalidDataException ex) when (
          {
            // ISSUE: unable to correctly present filter
            ProjectData.SetProjectError((Exception) ex);
            if (ZipUtility.CanTryRepairArchive((Exception) ex) && ZipUtility.CheckWinRarInstalled() && CurrentUser.IsMGADeveloper)
            {
              SuccessfulFiltering;
            }
            else
              throw;
          }
          )
          {
            if (MessageBox.Show("Press Yes to attempt to repair the file.", "Compressed File Error", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.Yes)
            {
              frmDownloadDocument downloadDocument = this;
              ZipUtility.RepairArchive(str);
              byte[] numArray = File.ReadAllBytes(str);
              // ISSUE: reference to a compiler-generated method
              Utility.ExecuteThread((DoWorkEventHandler) ([SpecialName] (a0, a1) => this._Lambda\u0024__0()), (RunWorkerCompletedEventHandler) null, (ProgressChangedEventHandler) null);
              FilePath.Extract(str);
            }
            ProjectData.ClearProjectError();
          }
        }
        if (this._callback != null)
          this._callback(str);
        Win32Exception win32Exception;
        try
        {
          DocumentManager.UpdateMetaXml(this._metadata.DocumentStoreGuid, str);
          if (this._useOpenWithDialog)
            ShellOperations.OpenWith(str);
          else if (this._launchFileWhenDone)
            DocumentManager.StartProcess(str);
          if (this._trackRevisions)
            TabDocumentPanel.AddFileWatch(str, this._metadata.DocumentStoreGuid);
        }
        catch (InvalidOperationException ex) when (
        {
          // ISSUE: unable to correctly present filter
          ProjectData.SetProjectError((Exception) ex);
          InvalidOperationException operationException = ex;
          if (Operators.CompareString(operationException.Source, "Aspose.Email", false) == 0 && Operators.CompareString(operationException.Message, "This is not a structured storage file.", false) == 0 && this._metadata.Compressed && ZipUtility.IsArchive(str))
          {
            SuccessfulFiltering;
          }
          else
            throw;
        }
        )
        {
          this.LaunchFile();
          ProjectData.ClearProjectError();
        }
        catch (Win32Exception ex1) when (
        {
          // ISSUE: unable to correctly present filter
          ProjectData.SetProjectError((Exception) ex1);
          win32Exception = ex1;
          if (win32Exception.ErrorCode == -2147467259 /*0x80004005*/)
          {
            SuccessfulFiltering;
          }
          else
            throw;
        }
        )
        {
          if (ShellFile.IsLink(str))
          {
            try
            {
              int num = (int) MessageBox.Show($"You're trying to open shortcut points to {ShellFile.ResolveLink(str)} which cannot be resolved from your machine. {win32Exception.Message}", "Windows Cannot Open File", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex2)
            {
              ProjectData.SetProjectError(ex2);
              int num = (int) MessageBox.Show($"You're trying to open shortcut which cannot be resolved from your machine. {win32Exception.Message}", "Windows Cannot Open File", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
              ProjectData.ClearProjectError();
            }
          }
          else
          {
            int num1 = (int) MessageBox.Show(win32Exception.Message, "Windows Cannot Open File", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
          }
          ProjectData.ClearProjectError();
        }
      }
      catch (IOException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        Utility.ErrorHandling.HandleError((Exception) ex);
        ProjectData.ClearProjectError();
      }
      this.Close();
    }
  }

  private void CloseForm()
  {
    if (MDIControls.Instance.MDIParent.InvokeRequired)
      MDIControls.Instance.MDIParent.BetterInvoke(new Action(this.CloseForm));
    else
      this.Close();
  }

  private void lnkCancel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    this.lnkCancel.Text = "Cancelling...";
    this.lnkCancel.Enabled = false;
    this._exitDownload = true;
    this._cancel = true;
    this._cancellationSource.Cancel();
    this.Close();
  }

  private void frmDownloadDocument_Closing(object sender, CancelEventArgs e)
  {
    if (this.WindowState == FormWindowState.Maximized && this.MdiParent != null && this.MdiParent.MdiChildren.Length > 1)
      this.MdiParent.MdiChildren[this.MdiParent.MdiChildren.Length - 2].WindowState = FormWindowState.Maximized;
    this._cancellationSource.Cancel();
    this._exitDownload = true;
  }

  private string FixLocalizeLongFilename(string fileName)
  {
    if (string.IsNullOrEmpty(fileName))
      throw new ArgumentNullException(nameof (fileName));
    int length = (int) byte.MaxValue - this.TempPath.Length;
    if (length > 200)
      length = (int) Math.Round((double) length / 2.0);
    if (fileName.Length > length)
      fileName = fileName.Substring(fileName.Length - length, length);
    return fileName;
  }

  public delegate void DownloadComplete(string fullPath);

  private delegate void HandleErrorOnUIThreadHandler(Exception ex);

  private delegate void SetProgressMaxHandler(int max);
}
