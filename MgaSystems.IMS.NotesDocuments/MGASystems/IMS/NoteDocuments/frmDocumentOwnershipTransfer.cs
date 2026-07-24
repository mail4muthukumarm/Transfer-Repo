// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.NoteDocuments.frmDocumentOwnershipTransfer
// Assembly: MgaSystems.IMS.NotesDocuments, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 3F898CF7-066D-4B05-A9F1-D37DBC4FAA16
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.NotesDocuments.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using MGASystems.Common;
using MGASystems.Common.DataAccess;
using MGASystems.Data;
using MGASystems.IMS.DocumentStorage;
using MGASystems.IMS.NoteDocuments.DocumentSystem;
using MGASystems.IMS.NoteDocuments.NoteDiarySystem;
using MGASystems.Tools;
using MGASystems.Tools.BaseClasses;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.NoteDocuments;

[SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly")]
[SecureResource("{70010C9D-E3EB-4541-8D49-91D96DC07A5D}", "Document Ownership Transfer", "Controls whether or not a user can transfer document ownership from one IMS user to another", "Document System")]
public class frmDocumentOwnershipTransfer : MGABaseForm
{
  private IContainer components;
  private MGASimpleComboBox cboUserFrom;
  private MGASimpleComboBox cboUserTo;
  private Label Label1;
  private Label Label2;
  private Label Label3;
  private ErrorProvider ErrorProvider1;
  private DbCommand DbSelectCommand1;
  private dsDocumentOwnershipTransfer DsDocumentOwnershipTransfer;
  private DbDataAdapter daUsers;
  private DbConnection cnSQL;
  private DataView dvUsers;
  private MGACheckBox chkUnboundOnly;
  public const string SecurityIdDocOwnershipTransfer = "{70010C9D-E3EB-4541-8D49-91D96DC07A5D}";
  private bool _singleDoc;
  private Guid _docGuid;

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

  [field: AccessedThroughProperty("chkDiaryUser")]
  internal virtual MGACheckBox chkDiaryUser { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    Appearance appearance1 = new Appearance();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmDocumentOwnershipTransfer));
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    this.cboUserFrom = new MGASimpleComboBox();
    this.DsDocumentOwnershipTransfer = new dsDocumentOwnershipTransfer();
    this.cboUserTo = new MGASimpleComboBox();
    this.dvUsers = new DataView();
    this.Label1 = new Label();
    this.btnCancel = new MGAButton();
    this.btnOK = new MGAButton();
    this.Label2 = new Label();
    this.Label3 = new Label();
    this.ErrorProvider1 = new ErrorProvider(this.components);
    this.daUsers = DefaultDatabase.CreateDataAdapter();
    this.DbSelectCommand1 = DefaultDatabase.CreateCommand();
    this.cnSQL = DefaultDatabase.CreateDbConnection();
    this.chkUnboundOnly = new MGACheckBox();
    this.chkDiaryUser = new MGACheckBox();
    ((ISupportInitialize) this.cboUserFrom).BeginInit();
    this.DsDocumentOwnershipTransfer.BeginInit();
    ((ISupportInitialize) this.cboUserTo).BeginInit();
    this.dvUsers.BeginInit();
    ((ISupportInitialize) this.btnCancel).BeginInit();
    ((ISupportInitialize) this.btnOK).BeginInit();
    ((ISupportInitialize) this.ErrorProvider1).BeginInit();
    ((ISupportInitialize) this.chkUnboundOnly).BeginInit();
    ((ISupportInitialize) this.chkDiaryUser).BeginInit();
    this.SuspendLayout();
    ((Control) this.cboUserFrom).Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.cboUserFrom.BorderStyle = (UIElementBorderStyle) 4;
    this.cboUserFrom.CharacterCasing = CharacterCasing.Normal;
    ((UltraGridBase) this.cboUserFrom).DataSource = (object) this.DsDocumentOwnershipTransfer.tblUsers;
    ((UltraDropDownBase) this.cboUserFrom).DisplayMember = "FullName";
    this.cboUserFrom.DisplayStyle = (EmbeddableElementDisplayStyle) 0;
    this.cboUserFrom.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboUserFrom).Location = new Point(8, 55);
    this.cboUserFrom.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboUserFrom).Name = "cboUserFrom";
    ((Control) this.cboUserFrom).Size = new Size(168, 21);
    ((Control) this.cboUserFrom).TabIndex = 0;
    ((UltraControlBase) this.cboUserFrom).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboUserFrom).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboUserFrom).ValueMember = "UserGUID";
    this.DsDocumentOwnershipTransfer.DataSetName = "dsDocumentOwnershipTransfer";
    this.DsDocumentOwnershipTransfer.Locale = new CultureInfo("en-US");
    this.DsDocumentOwnershipTransfer.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    ((Control) this.cboUserTo).Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.cboUserTo.BorderStyle = (UIElementBorderStyle) 4;
    this.cboUserTo.CharacterCasing = CharacterCasing.Normal;
    ((UltraGridBase) this.cboUserTo).DataSource = (object) this.dvUsers;
    ((UltraDropDownBase) this.cboUserTo).DisplayMember = "FullName";
    this.cboUserTo.DisplayStyle = (EmbeddableElementDisplayStyle) 0;
    this.cboUserTo.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboUserTo).Location = new Point(200, 55);
    this.cboUserTo.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboUserTo).Name = "cboUserTo";
    ((Control) this.cboUserTo).Size = new Size(168, 21);
    ((Control) this.cboUserTo).TabIndex = 1;
    ((UltraControlBase) this.cboUserTo).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboUserTo).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboUserTo).ValueMember = "UserGUID";
    this.dvUsers.Table = (DataTable) this.DsDocumentOwnershipTransfer.tblUsers;
    this.Label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.Label1.AutoSize = true;
    this.Label1.BackColor = Color.Transparent;
    this.Label1.Location = new Point(200, 37);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(19, 13);
    this.Label1.TabIndex = 2;
    this.Label1.Text = "To";
    ((Control) this.btnCancel).Anchor = AnchorStyles.Top | AnchorStyles.Right;
    appearance1.BackColor = Color.FromArgb(248, 248, 248);
    appearance1.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance1.BackGradientStyle = (GradientStyle) 2;
    appearance1.BorderColor = Color.DarkGray;
    appearance1.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance1.Image"));
    appearance1.ImageHAlign = (HAlign) 1;
    appearance1.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnCancel).Appearance = (AppearanceBase) appearance1;
    ((UltraButtonBase) this.btnCancel).DialogResult = DialogResult.Cancel;
    ((Control) this.btnCancel).Location = new Point(191, 112 /*0x70*/);
    ((Control) this.btnCancel).Name = "btnCancel";
    ((Control) this.btnCancel).Size = new Size(85, 24);
    ((Control) this.btnCancel).TabIndex = 3;
    ((ControlBase) this.btnCancel).Text = "&Cancel";
    this.btnCancel.UseOSThemes = (DefaultableBoolean) 2;
    ((Control) this.btnOK).Anchor = AnchorStyles.Top | AnchorStyles.Right;
    appearance2.BackColor = Color.FromArgb(248, 248, 248);
    appearance2.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance2.BackGradientStyle = (GradientStyle) 2;
    appearance2.BorderColor = Color.DarkGray;
    appearance2.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance2.Image"));
    appearance2.ImageHAlign = (HAlign) 1;
    appearance2.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnOK).Appearance = (AppearanceBase) appearance2;
    ((Control) this.btnOK).Location = new Point(283, 112 /*0x70*/);
    ((Control) this.btnOK).Name = "btnOK";
    ((Control) this.btnOK).Size = new Size(85, 24);
    ((Control) this.btnOK).TabIndex = 4;
    ((ControlBase) this.btnOK).Text = "&OK";
    this.btnOK.UseOSThemes = (DefaultableBoolean) 2;
    this.Label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.Label2.AutoSize = true;
    this.Label2.BackColor = Color.Transparent;
    this.Label2.Location = new Point(8, 37);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(31 /*0x1F*/, 13);
    this.Label2.TabIndex = 5;
    this.Label2.Text = "From";
    this.Label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.Label3.AutoSize = true;
    this.Label3.BackColor = Color.Transparent;
    this.Label3.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label3.Location = new Point(5, 10);
    this.Label3.Name = "Label3";
    this.Label3.Size = new Size(118, 14);
    this.Label3.TabIndex = 6;
    this.Label3.Text = "Transfer Documents";
    this.ErrorProvider1.ContainerControl = (ContainerControl) this;
    this.daUsers.SelectCommand = this.DbSelectCommand1;
    this.daUsers.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblUsers", new DataColumnMapping[2]
      {
        new DataColumnMapping("UserGUID", "UserGUID"),
        new DataColumnMapping("FullName", "FullName")
      })
    });
    this.DbSelectCommand1.CommandText = "SELECT UserGUID, LastName + ', ' + FirstName AS FullName FROM tblUsers (NOLOCK) ORDER BY FullName";
    this.DbSelectCommand1.Connection = this.cnSQL;
    ((Control) this.chkUnboundOnly).Anchor = AnchorStyles.Top | AnchorStyles.Right;
    appearance3.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance3.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkUnboundOnly).Appearance = (AppearanceBase) appearance3;
    ((UltraToggleEditorBase) this.chkUnboundOnly).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkUnboundOnly).BackColorInternal = Color.Transparent;
    ((UltraToggleEditorBase) this.chkUnboundOnly).Checked = true;
    ((UltraToggleEditorBase) this.chkUnboundOnly).CheckState = CheckState.Checked;
    ((UltraToggleEditorBase) this.chkUnboundOnly).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkUnboundOnly).Location = new Point(8, 97);
    this.chkUnboundOnly.MGAStyle = MGAStyles.Blue;
    ((Control) this.chkUnboundOnly).Name = "chkUnboundOnly";
    ((Control) this.chkUnboundOnly).Size = new Size(168, 16 /*0x10*/);
    ((Control) this.chkUnboundOnly).TabIndex = 7;
    ((UltraToggleEditorBase) this.chkUnboundOnly).Text = "Unbound documents only";
    ((Control) this.chkDiaryUser).Anchor = AnchorStyles.Top | AnchorStyles.Right;
    appearance4.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance4.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkDiaryUser).Appearance = (AppearanceBase) appearance4;
    ((UltraToggleEditorBase) this.chkDiaryUser).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkDiaryUser).BackColorInternal = Color.Transparent;
    ((UltraToggleEditorBase) this.chkDiaryUser).Checked = true;
    ((UltraToggleEditorBase) this.chkDiaryUser).CheckState = CheckState.Checked;
    ((UltraToggleEditorBase) this.chkDiaryUser).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkDiaryUser).Location = new Point(8, 120);
    this.chkDiaryUser.MGAStyle = MGAStyles.Blue;
    ((Control) this.chkDiaryUser).Name = "chkDiaryUser";
    ((Control) this.chkDiaryUser).Size = new Size(120, 16 /*0x10*/);
    ((Control) this.chkDiaryUser).TabIndex = 8;
    ((UltraToggleEditorBase) this.chkDiaryUser).Text = "Send diary to user";
    ((Control) this.chkDiaryUser).Visible = false;
    this.AcceptButton = (IButtonControl) this.btnOK;
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.White;
    this.CancelButton = (IButtonControl) this.btnCancel;
    this.ClientSize = new Size(392, 146);
    this.Controls.Add((Control) this.chkDiaryUser);
    this.Controls.Add((Control) this.chkUnboundOnly);
    this.Controls.Add((Control) this.Label3);
    this.Controls.Add((Control) this.Label2);
    this.Controls.Add((Control) this.Label1);
    this.Controls.Add((Control) this.btnOK);
    this.Controls.Add((Control) this.btnCancel);
    this.Controls.Add((Control) this.cboUserTo);
    this.Controls.Add((Control) this.cboUserFrom);
    this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.ForeColor = Color.Black;
    this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
    this.Name = nameof (frmDocumentOwnershipTransfer);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Document Ownership Transfer";
    ((ISupportInitialize) this.cboUserFrom).EndInit();
    this.DsDocumentOwnershipTransfer.EndInit();
    ((ISupportInitialize) this.cboUserTo).EndInit();
    this.dvUsers.EndInit();
    ((ISupportInitialize) this.btnCancel).EndInit();
    ((ISupportInitialize) this.btnOK).EndInit();
    ((ISupportInitialize) this.ErrorProvider1).EndInit();
    ((ISupportInitialize) this.chkUnboundOnly).EndInit();
    ((ISupportInitialize) this.chkDiaryUser).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  public frmDocumentOwnershipTransfer()
  {
    this.Load += new EventHandler(this.frmDocumentOwnershipTransfer_Load);
    this.InitializeComponent();
  }

  public frmDocumentOwnershipTransfer(bool singleDoc, Guid docGuid)
  {
    this.Load += new EventHandler(this.frmDocumentOwnershipTransfer_Load);
    this.InitializeComponent();
    this._singleDoc = singleDoc;
    this._docGuid = docGuid;
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private void btnOK_Click(object sender, EventArgs e)
  {
    if (!this.ValidateForm())
      return;
    if (this._singleDoc)
    {
      if (MessageBox.Show("Transfer is permanent and cannot be undone. Continue?", "Begin Transfer?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.Yes)
        return;
      this.StartCopy();
    }
    else
    {
      if (MessageBox.Show($"Are you sure you want to transfer all documents from {this.cboUserFrom.Text} to {this.cboUserTo.Text}?", "Preparing Transfer", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes || MessageBox.Show("Transfer is permanent and cannot be undone. Continue?", "Begin Transfer?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.Yes)
        return;
      this.StartCopy();
    }
  }

  private static void DiaryDocumentToUser(Guid docGuid, Guid recipientGuid)
  {
    Metadata documentMetadata = DocumentManager.GetDocumentMetadata(docGuid);
    Guid noteGUID = Guid.NewGuid();
    Note_System.NonInteractiveNoteManipulator nonInteractive = Note_System.Instance.NonInteractive;
    Guid noteguid = noteGUID;
    Guid userGuid = CurrentUser.Instance.UserGUID;
    string body = $"See attached [{documentMetadata.FileName}]";
    Guid[] recipientGUIDs = new Guid[0];
    Guid[] diaryRecipientGUIDs = new Guid[1]
    {
      recipientGuid
    };
    DateTime now = DateAndTime.Now;
    DateTime deadlineDate = now.AddDays(7.0);
    now = DateAndTime.Now;
    DateTime finalDeadline = now.AddDays(14.0);
    nonInteractive.CreateNote(noteguid, -1, "New Document has been assigned to you", userGuid, body, false, recipientGUIDs, diaryRecipientGUIDs, deadlineDate, finalDeadline);
    Database.Instance.QueryText.PerformNonQuery("insert into          dbo.tblNotesDocuments              (DocumentStoreGuid, NoteGuid)          values              (@DocumentStoreGuid, @NoteGuid) ", (object) "@DocumentStoreGuid", (object) docGuid, (object) "@NoteGuid", (object) noteGUID);
    Note_System.Instance.UIInteractive.ViewNote(noteGUID, true);
  }

  private void StartCopy()
  {
    if (this._singleDoc)
    {
      Database.Instance.QueryText.PerformNonQuery("Update dbo.tblDocumentStore SET UserGUIDOriginator = @NewUserGUIDOriginator WHERE DocumentStoreGUID = @DocumentStoreGUID", (object) "@NewUserGUIDOriginator", (object) (Guid) this.cboUserTo.Value, (object) "@DocumentStoreGUID", (object) this._docGuid);
      DocumentManager.PinDocument(this._docGuid, (Guid) this.cboUserTo.Value);
      if (((UltraToggleEditorBase) this.chkDiaryUser).Checked)
        frmDocumentOwnershipTransfer.DiaryDocumentToUser(this._docGuid, (Guid) this.cboUserTo.Value);
    }
    else
      Database.Instance.QueryText.PerformNonQuery(!((UltraToggleEditorBase) this.chkUnboundOnly).Checked ? "UPDATE dbo.tblDocumentStore SET UserGUIDOriginator = @NewUserGUIDOriginator WHERE UserGUIDOriginator = @OldUserGUIDOriginator" : "UPDATE dbo.tblDocumentStore SET UserGUIDOriginator = @NewUserGUIDOriginator WHERE UserGUIDOriginator = @OldUserGUIDOriginator AND DocumentStoreGUID IN(SELECT dbo.tblDocumentStore.DocumentStoreGUID FROM dbo.tblDocumentAssociations RIGHT OUTER JOIN dbo.tblDocumentStore ON dbo.tblDocumentAssociations.DocumentStoreGUID = dbo.tblDocumentStore.DocumentStoreGUID WHERE (dbo.tblDocumentAssociations.DocumentStoreGUID IS NULL))", (object) "@NewUserGUIDOriginator", (object) (Guid) this.cboUserTo.Value, (object) "@OldUserGUIDOriginator", (object) (Guid) this.cboUserFrom.Value);
    int num = (int) MessageBox.Show("Transfer Complete", "Document Ownership Transfer", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    DocumentManager.FireEntityDocumentCollectionChanged();
    DocumentManager.FireUserDocumentCollectionChanged();
    this.Close();
  }

  private bool ValidateForm()
  {
    bool flag = true;
    if (this.cboUserTo.Value == null)
    {
      flag = false;
      this.ErrorProvider1.SetError((Control) this.cboUserTo, "You must select a user");
    }
    else
      this.ErrorProvider1.SetError((Control) this.cboUserTo, string.Empty);
    if (this.cboUserTo.Value == null)
    {
      flag = false;
      this.ErrorProvider1.SetError((Control) this.cboUserFrom, "You must select a user");
    }
    else
      this.ErrorProvider1.SetError((Control) this.cboUserFrom, string.Empty);
    return flag;
  }

  private void btnCancel_Click(object sender, EventArgs e) => this.Close();

  [SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes")]
  private void frmDocumentOwnershipTransfer_Load(object sender, EventArgs e)
  {
    DefaultDatabase.DataAdapterFill(this.daUsers, (DataTable) this.DsDocumentOwnershipTransfer.tblUsers);
    try
    {
      this.cboUserFrom.SelectedIndex = 0;
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      ProjectData.ClearProjectError();
    }
    try
    {
      this.cboUserTo.SelectedIndex = 0;
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      ProjectData.ClearProjectError();
    }
    if (!this._singleDoc)
      return;
    this.Size = new Size(216, 168);
    ((Control) this.chkDiaryUser).Visible = true;
  }
}
