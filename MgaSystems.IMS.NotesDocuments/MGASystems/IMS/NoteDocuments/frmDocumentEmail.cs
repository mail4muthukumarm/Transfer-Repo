// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.NoteDocuments.frmDocumentEmail
// Assembly: MgaSystems.IMS.NotesDocuments, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 3F898CF7-066D-4B05-A9F1-D37DBC4FAA16
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.NotesDocuments.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using MGASystems.IMS.DocumentStorage;
using MGASystems.IMS.NoteDocuments.DocumentSystem;
using MGASystems.IMS.NoteDocuments.Email;
using MGASystems.Tools;
using MGASystems.Tools.BaseClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.NoteDocuments;

[SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly")]
public sealed class frmDocumentEmail : MGABaseForm
{
  private IContainer components;
  private SqlCommand SqlSelectCommand1;
  private SqlCommand SqlInsertCommand1;
  private SqlCommand SqlUpdateCommand1;
  private SqlCommand SqlDeleteCommand1;
  private SqlDataAdapter SqlDataAdapter1;
  private MGACheckedListBox CheckedListBox1;
  private Label Label1;
  private Guid _documentGuid;

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private virtual MGAButton btnCancel
  {
    get => this._btnCancel;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnCancel_Click);
      MGAButton btnCancel1 = this._btnCancel;
      if (btnCancel1 != null)
        ((Control) btnCancel1).Click -= eventHandler;
      this._btnCancel = value;
      MGAButton btnCancel2 = this._btnCancel;
      if (btnCancel2 == null)
        return;
      ((Control) btnCancel2).Click += eventHandler;
    }
  }

  private virtual MGAButton btnOK
  {
    get => this._btnOK;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnOK_Click);
      MGAButton btnOk1 = this._btnOK;
      if (btnOk1 != null)
        ((Control) btnOk1).Click -= eventHandler;
      this._btnOK = value;
      MGAButton btnOk2 = this._btnOK;
      if (btnOk2 == null)
        return;
      ((Control) btnOk2).Click += eventHandler;
    }
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    this.SqlSelectCommand1 = new SqlCommand();
    this.SqlInsertCommand1 = new SqlCommand();
    this.SqlUpdateCommand1 = new SqlCommand();
    this.SqlDeleteCommand1 = new SqlCommand();
    this.SqlDataAdapter1 = new SqlDataAdapter();
    this.CheckedListBox1 = new MGACheckedListBox();
    this.Label1 = new Label();
    this.btnCancel = new MGAButton();
    this.btnOK = new MGAButton();
    ((ISupportInitialize) this.CheckedListBox1).BeginInit();
    ((ISupportInitialize) this.btnCancel).BeginInit();
    ((ISupportInitialize) this.btnOK).BeginInit();
    this.SuspendLayout();
    this.SqlDataAdapter1.DeleteCommand = this.SqlDeleteCommand1;
    this.SqlDataAdapter1.InsertCommand = this.SqlInsertCommand1;
    this.SqlDataAdapter1.SelectCommand = this.SqlSelectCommand1;
    this.SqlDataAdapter1.UpdateCommand = this.SqlUpdateCommand1;
    this.CheckedListBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.CheckedListBox1.CheckOnClick = true;
    this.CheckedListBox1.ForeColor = Color.Black;
    this.CheckedListBox1.Location = new Point(8, 32 /*0x20*/);
    this.CheckedListBox1.MGAStyle = MGAStyles.Blue;
    this.CheckedListBox1.Name = "CheckedListBox1";
    this.CheckedListBox1.Size = new Size(288, 196);
    this.CheckedListBox1.TabIndex = 0;
    this.Label1.BackColor = Color.Transparent;
    this.Label1.Location = new Point(8, 8);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(230, 16 /*0x10*/);
    this.Label1.TabIndex = 1;
    this.Label1.Text = "Contacts associated with this item. (optional)";
    ((Control) this.btnCancel).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance1.BackColor = Color.FromArgb(248, 248, 248);
    appearance1.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance1.BackGradientStyle = (GradientStyle) 2;
    appearance1.BorderColor = Color.DarkGray;
    appearance1.ImageHAlign = (HAlign) 2;
    appearance1.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnCancel).Appearance = (AppearanceBase) appearance1;
    ((UltraButtonBase) this.btnCancel).DialogResult = DialogResult.Cancel;
    ((ControlBase) this.btnCancel).ImageSize = new Size(24, 24);
    ((ControlBase) this.btnCancel).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnCancel).Location = new Point(208 /*0xD0*/, 240 /*0xF0*/);
    ((Control) this.btnCancel).Name = "btnCancel";
    ((Control) this.btnCancel).Size = new Size(40, 40);
    ((Control) this.btnCancel).TabIndex = 3;
    this.btnCancel.UseOSThemes = (DefaultableBoolean) 2;
    ((Control) this.btnOK).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance2.BackColor = Color.FromArgb(248, 248, 248);
    appearance2.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance2.BackGradientStyle = (GradientStyle) 2;
    appearance2.BorderColor = Color.DarkGray;
    appearance2.ImageHAlign = (HAlign) 2;
    appearance2.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnOK).Appearance = (AppearanceBase) appearance2;
    ((ControlBase) this.btnOK).ImageSize = new Size(24, 24);
    ((ControlBase) this.btnOK).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnOK).Location = new Point(256 /*0x0100*/, 240 /*0xF0*/);
    ((Control) this.btnOK).Name = "btnOK";
    ((Control) this.btnOK).Size = new Size(40, 40);
    ((Control) this.btnOK).TabIndex = 4;
    this.btnOK.UseOSThemes = (DefaultableBoolean) 2;
    this.AcceptButton = (IButtonControl) this.btnOK;
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.White;
    this.CancelButton = (IButtonControl) this.btnCancel;
    this.ClientSize = new Size(306, 288);
    this.Controls.Add((Control) this.btnOK);
    this.Controls.Add((Control) this.btnCancel);
    this.Controls.Add((Control) this.Label1);
    this.Controls.Add((Control) this.CheckedListBox1);
    this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.ForeColor = Color.Black;
    this.FormBorderStyle = FormBorderStyle.FixedSingle;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmDocumentEmail);
    this.Text = "Zip and email XYZ.doc";
    ((ISupportInitialize) this.CheckedListBox1).EndInit();
    ((ISupportInitialize) this.btnCancel).EndInit();
    ((ISupportInitialize) this.btnOK).EndInit();
    this.ResumeLayout(false);
  }

  public frmDocumentEmail(Guid documentGuid)
  {
    this.Load += new EventHandler(this.frmDocumentEmail_Load);
    this.InitializeComponent();
    this._documentGuid = documentGuid;
  }

  public frmDocumentEmail()
  {
    this.Load += new EventHandler(this.frmDocumentEmail_Load);
    this.InitializeComponent();
  }

  private void frmDocumentEmail_Load(object sender, EventArgs e)
  {
    ((ControlBase) this.btnCancel).Appearance.Image = (object) ImageCache.Instance.Undo;
    ((ControlBase) this.btnOK).Appearance.Image = (object) ImageCache.Instance.Save;
  }

  public void SendZippedDocument() => this.SendMessage();

  private void SendMessage() => this.SendMessage((string[]) null);

  public static string CreateTempDirectory()
  {
    string path = $"{Path.GetTempPath()}{Guid.NewGuid()}\\";
    Directory.CreateDirectory(path);
    return path;
  }

  private void SendMessage(string[] recipients)
  {
    Metadata documentMetadata = DocumentManager.GetDocumentMetadata(this._documentGuid);
    string fileName = $"{Application.UserAppDataPath}\\{documentMetadata.FileName}";
    FileInfo fileInfo = new FileInfo(fileName);
    string str1 = fileName.Replace(fileInfo.Extension, ".zip");
    using (FileStream fileStream = new FileStream(str1, FileMode.Create))
    {
      byte[] documentBinary = DocumentManager.GetDocumentBinary(documentMetadata);
      fileStream.Write(documentBinary, 0, documentBinary.Length);
    }
    if (!documentMetadata.Compressed)
    {
      string str2 = $"{Application.UserAppDataPath}\\{documentMetadata.FileName}";
      if (File.Exists(str2))
        File.Delete(str2);
      File.Move(str1, str2);
      new ZipUtility().CompressFileToNewZipArchive(str2, str1);
      if (File.Exists(str2))
        File.Delete(str2);
    }
    UI.Send(new string[1]{ str1 }, recipients);
    File.Delete(str1);
  }

  private void btnCancel_Click(object sender, EventArgs e) => this.Close();

  private void btnOK_Click(object sender, EventArgs e)
  {
    this.SendMessage(new List<string>().ToArray());
    this.Close();
  }
}
