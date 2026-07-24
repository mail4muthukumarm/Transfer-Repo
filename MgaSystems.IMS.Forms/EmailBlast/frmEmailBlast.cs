// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Forms.EmailBlast.frmEmailBlast
// Assembly: MgaSystems.IMS.Forms, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FB3F392E-40B6-486F-8F0B-A4A494A546D4
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Forms.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.IMS.NoteDocuments;
using MGASystems.IMS.NoteDocuments.DocumentSystem;
using MGASystems.Tools;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Net.Mail;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Web;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Forms.EmailBlast;

[SecureResource("{4AF0ECFA-C082-486e-B9DC-71934BFA4F07}", "Access Bulk Email", "Controls access to Bulk Email.", "Users")]
public class frmEmailBlast : Form
{
  private IContainer components;
  public const string canOpenEmailBlastForm = "{4AF0ECFA-C082-486e-B9DC-71934BFA4F07}";
  private ArrayList _SendList;
  private FileTypeImageCollection _ImageCollection;
  private Hashtable _ExtensionHash;
  private readonly object _email;

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  internal virtual MGAButton btnTo
  {
    get => this._btnTo;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnTo_Click);
      MGAButton btnTo1 = this._btnTo;
      if (btnTo1 != null)
        ((Control) btnTo1).Click -= eventHandler;
      this._btnTo = value;
      MGAButton btnTo2 = this._btnTo;
      if (btnTo2 == null)
        return;
      ((Control) btnTo2).Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("txtTo")]
  internal virtual MGATextBox txtTo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtSubject")]
  internal virtual MGATextBox txtSubject { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblSubject")]
  internal virtual Label lblSubject { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("rtbMessage")]
  internal virtual RichTextBox rtbMessage { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual MGAButton btnSend
  {
    get => this._btnSend;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnSend_Click);
      MGAButton btnSend1 = this._btnSend;
      if (btnSend1 != null)
        ((Control) btnSend1).Click -= eventHandler;
      this._btnSend = value;
      MGAButton btnSend2 = this._btnSend;
      if (btnSend2 == null)
        return;
      ((Control) btnSend2).Click += eventHandler;
    }
  }

  internal virtual MGAButton btnAddAttachment
  {
    get => this._btnAddAttachment;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnAddAttachment_Click);
      MGAButton btnAddAttachment1 = this._btnAddAttachment;
      if (btnAddAttachment1 != null)
        ((Control) btnAddAttachment1).Click -= eventHandler;
      this._btnAddAttachment = value;
      MGAButton btnAddAttachment2 = this._btnAddAttachment;
      if (btnAddAttachment2 == null)
        return;
      ((Control) btnAddAttachment2).Click += eventHandler;
    }
  }

  internal virtual ListView lstAttachments
  {
    get => this._lstAttachments;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      MouseEventHandler mouseEventHandler = new MouseEventHandler(this.lstAttachments_MouseUp);
      DragEventHandler dragEventHandler1 = new DragEventHandler(this.lstAttachments_DragEnter);
      DragEventHandler dragEventHandler2 = new DragEventHandler(this.lstAttachments_DragDrop);
      ListView lstAttachments1 = this._lstAttachments;
      if (lstAttachments1 != null)
      {
        lstAttachments1.MouseUp -= mouseEventHandler;
        lstAttachments1.DragEnter -= dragEventHandler1;
        lstAttachments1.DragDrop -= dragEventHandler2;
      }
      this._lstAttachments = value;
      ListView lstAttachments2 = this._lstAttachments;
      if (lstAttachments2 == null)
        return;
      lstAttachments2.MouseUp += mouseEventHandler;
      lstAttachments2.DragEnter += dragEventHandler1;
      lstAttachments2.DragDrop += dragEventHandler2;
    }
  }

  [field: AccessedThroughProperty("AttachmentMenu")]
  internal virtual ContextMenu AttachmentMenu { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual MenuItem RemoveItem
  {
    get => this._RemoveItem;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.RemoveItem_Click);
      MenuItem removeItem1 = this._RemoveItem;
      if (removeItem1 != null)
        removeItem1.Click -= eventHandler;
      this._RemoveItem = value;
      MenuItem removeItem2 = this._RemoveItem;
      if (removeItem2 == null)
        return;
      removeItem2.Click += eventHandler;
    }
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    ResourceManager resourceManager = new ResourceManager(typeof (frmEmailBlast));
    this.btnTo = new MGAButton();
    this.txtTo = new MGATextBox();
    this.txtSubject = new MGATextBox();
    this.lblSubject = new Label();
    this.rtbMessage = new RichTextBox();
    this.btnSend = new MGAButton();
    this.lstAttachments = new ListView();
    this.AttachmentMenu = new ContextMenu();
    this.RemoveItem = new MenuItem();
    this.btnAddAttachment = new MGAButton();
    ((ISupportInitialize) this.btnTo).BeginInit();
    ((ISupportInitialize) this.txtTo).BeginInit();
    ((ISupportInitialize) this.txtSubject).BeginInit();
    ((ISupportInitialize) this.btnSend).BeginInit();
    ((ISupportInitialize) this.btnAddAttachment).BeginInit();
    this.SuspendLayout();
    appearance1.BackColor = Color.Gainsboro;
    appearance1.BackColor2 = Color.White;
    appearance1.BackGradientStyle = (GradientStyle) 2;
    ((ControlBase) this.btnTo).Appearance = (AppearanceBase) appearance1;
    ((Control) this.btnTo).Location = new Point(8, 8);
    ((Control) this.btnTo).Name = "btnTo";
    ((Control) this.btnTo).Size = new Size(56, 20);
    ((Control) this.btnTo).TabIndex = 0;
    ((ControlBase) this.btnTo).Text = "To&...";
    ((Control) this.txtTo).Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    appearance2.BorderColor = Color.Gray;
    ((TextEditorControlBase) this.txtTo).Appearance = (AppearanceBase) appearance2;
    ((Control) this.txtTo).Location = new Point(72, 8);
    this.txtTo.Multiline = true;
    ((Control) this.txtTo).Name = "txtTo";
    ((EditorButtonControlBase) this.txtTo).ReadOnly = true;
    this.txtTo.Scrollbars = ScrollBars.Vertical;
    ((Control) this.txtTo).Size = new Size(440, 19);
    ((Control) this.txtTo).TabIndex = 1;
    ((Control) this.txtSubject).Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    appearance3.BorderColor = Color.Gray;
    ((TextEditorControlBase) this.txtSubject).Appearance = (AppearanceBase) appearance3;
    ((Control) this.txtSubject).Location = new Point(72, 32 /*0x20*/);
    ((Control) this.txtSubject).Name = "txtSubject";
    ((Control) this.txtSubject).Size = new Size(440, 20);
    ((Control) this.txtSubject).TabIndex = 2;
    this.lblSubject.Location = new Point(8, 32 /*0x20*/);
    this.lblSubject.Name = "lblSubject";
    this.lblSubject.Size = new Size(56, 19);
    this.lblSubject.TabIndex = 3;
    this.lblSubject.Text = "Sub&ject:";
    this.lblSubject.TextAlign = ContentAlignment.MiddleLeft;
    this.rtbMessage.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.rtbMessage.BorderStyle = BorderStyle.FixedSingle;
    this.rtbMessage.Location = new Point(8, 104);
    this.rtbMessage.Name = "rtbMessage";
    this.rtbMessage.ScrollBars = RichTextBoxScrollBars.ForcedVertical;
    this.rtbMessage.Size = new Size(504, 224 /*0xE0*/);
    this.rtbMessage.TabIndex = 4;
    this.rtbMessage.Text = "";
    ((Control) this.btnSend).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance4.BackColor = Color.Gainsboro;
    appearance4.BackColor2 = Color.White;
    appearance4.BackGradientStyle = (GradientStyle) 2;
    ((ControlBase) this.btnSend).Appearance = (AppearanceBase) appearance4;
    ((Control) this.btnSend).Location = new Point(448, 336);
    ((Control) this.btnSend).Name = "btnSend";
    ((Control) this.btnSend).Size = new Size(64 /*0x40*/, 20);
    ((Control) this.btnSend).TabIndex = 5;
    ((ControlBase) this.btnSend).Text = "&Send";
    this.lstAttachments.AllowDrop = true;
    this.lstAttachments.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    this.lstAttachments.BorderStyle = BorderStyle.FixedSingle;
    this.lstAttachments.LabelWrap = false;
    this.lstAttachments.Location = new Point(72, 56);
    this.lstAttachments.Name = "lstAttachments";
    this.lstAttachments.Size = new Size(440, 40);
    this.lstAttachments.TabIndex = 7;
    this.lstAttachments.View = View.SmallIcon;
    this.AttachmentMenu.MenuItems.AddRange(new MenuItem[1]
    {
      this.RemoveItem
    });
    this.RemoveItem.Index = 0;
    this.RemoveItem.Text = "Remove";
    appearance5.BackColor = Color.Gainsboro;
    appearance5.BackColor2 = Color.White;
    appearance5.BackGradientStyle = (GradientStyle) 2;
    ((ControlBase) this.btnAddAttachment).Appearance = (AppearanceBase) appearance5;
    ((Control) this.btnAddAttachment).Location = new Point(8, 56);
    ((Control) this.btnAddAttachment).Name = "btnAddAttachment";
    ((Control) this.btnAddAttachment).Size = new Size(56, 20);
    ((Control) this.btnAddAttachment).TabIndex = 8;
    ((ControlBase) this.btnAddAttachment).Text = "Attach...";
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.WhiteSmoke;
    this.ClientSize = new Size(520, 365);
    this.Controls.Add((Control) this.btnAddAttachment);
    this.Controls.Add((Control) this.lstAttachments);
    this.Controls.Add((Control) this.btnSend);
    this.Controls.Add((Control) this.rtbMessage);
    this.Controls.Add((Control) this.lblSubject);
    this.Controls.Add((Control) this.txtSubject);
    this.Controls.Add((Control) this.txtTo);
    this.Controls.Add((Control) this.btnTo);
    this.Font = new Font("Tahoma", 8.25f);
    this.ForeColor = Color.Black;
    this.Icon = (Icon) resourceManager.GetObject("$this.Icon");
    this.MinimumSize = new Size(376, 248);
    this.Name = nameof (frmEmailBlast);
    this.Text = "E-mail Blast";
    ((ISupportInitialize) this.btnTo).EndInit();
    ((ISupportInitialize) this.txtTo).EndInit();
    ((ISupportInitialize) this.txtSubject).EndInit();
    ((ISupportInitialize) this.btnSend).EndInit();
    ((ISupportInitialize) this.btnAddAttachment).EndInit();
    this.ResumeLayout(false);
  }

  public frmEmailBlast()
  {
    this._SendList = new ArrayList();
    this.InitializeComponent();
    this._email = RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, "select EmailAddress from tblusers where userguid = @UG", new object[2]
    {
      (object) "@UG",
      (object) CurrentUser.Instance.UserGUID
    }));
  }

  public static string GetFileNameFromFullPath(string Path)
  {
    string nameFromFullPath = string.Empty;
    int num = Path.LastIndexOf('\\');
    if (Path.Length > 0 && num != -1 && Path.Length >= num + 1)
      nameFromFullPath = Path.Substring(num + 1, Path.Length - 1 - num);
    return nameFromFullPath;
  }

  private string ListToString(string Separator)
  {
    string str = "";
    EmailAddress[] array = (EmailAddress[]) this._SendList.ToArray(typeof (EmailAddress));
    int index = 0;
    while (index < array.Length)
    {
      EmailAddress emailAddress = array[index];
      str = $"{str}{RuntimeHelpers.GetObjectValue(Interaction.IIf(str.Length == 0, (object) "", (object) Separator))}{emailAddress.Address}";
      checked { ++index; }
    }
    return str;
  }

  public int GetFileImageIndex(string Path)
  {
    if (this._ImageCollection == null)
      this._ImageCollection = new FileTypeImageCollection();
    if (this._ExtensionHash == null)
      this._ExtensionHash = new Hashtable();
    int startIndex = Path.LastIndexOf('.');
    int fileImageIndex;
    if (Path.Length > 0 && startIndex != -1)
    {
      string str = Path.Substring(startIndex, Path.Length - startIndex);
      if (this._ExtensionHash.ContainsKey((object) str))
      {
        fileImageIndex = Conversions.ToInteger(this._ExtensionHash[(object) str]);
      }
      else
      {
        this._ExtensionHash.Add((object) str, (object) this._ExtensionHash.Count);
        if (this.lstAttachments.SmallImageList == null)
          this.lstAttachments.SmallImageList = new ImageList();
        this.lstAttachments.SmallImageList.Images.Add(this._ImageCollection.FindImage(str));
        fileImageIndex = this.lstAttachments.SmallImageList.Images.Count - 1;
      }
    }
    else
      fileImageIndex = -1;
    return fileImageIndex;
  }

  private void CloseWindow() => this.Close();

  private void SendMessage()
  {
    this.Visible = false;
    MailMessage message = new MailMessage();
    message.From = new MailAddress(this._email.ToString());
    message.Subject = ((TextEditorControlBase) this.txtSubject).Text;
    message.Body = this.rtbMessage.Text;
    string str = message.ReplyTo.ToString();
    int num1 = this.lstAttachments.Items.Count - 1;
    for (int index = 0; index <= num1; ++index)
      message.Attachments.Add(new Attachment(((EmailAttachment) this.lstAttachments.Items[index]).FullPath));
    SmtpClient smtpClient = new SmtpClient();
    smtpClient.UseDefaultCredentials = true;
    int num2 = this._SendList.Count - 1;
    for (int index = 0; index <= num2; ++index)
    {
      message.ReplyTo = new MailAddress(((EmailAddress) this._SendList[index]).Address);
      CurrentUser.Instance.LogAction("Send Bulk E-mail", message.ReplyTo.ToString());
      try
      {
        smtpClient.Send(message);
      }
      catch (HttpException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        HttpException httpException = ex;
        int num3 = (int) MessageBox.Show($"An email could not be sent to {str} due to the following reason:\n\n{httpException.Message}\n\nPlease contact technical support.", "Unable To Send Email", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        ProjectData.ClearProjectError();
        return;
      }
    }
    this.Invoke((Delegate) new frmEmailBlast.CloseWindowHandler(this.CloseWindow));
  }

  private void btnTo_Click(object sender, EventArgs e)
  {
    frmEmailBlast_AddressSelection addressSelection = new frmEmailBlast_AddressSelection(this._SendList);
    if (addressSelection.ShowDialog() != DialogResult.OK)
      return;
    this._SendList = addressSelection.SendList;
    ((TextEditorControlBase) this.txtTo).Text = this.ListToString(";");
  }

  private void btnAddAttachment_Click(object sender, EventArgs e)
  {
    OpenFileDialog openFileDialog = new OpenFileDialog();
    openFileDialog.Multiselect = true;
    if (openFileDialog.ShowDialog() != DialogResult.OK)
      return;
    int num = openFileDialog.FileNames.Length - 1;
    for (int index = 0; index <= num; ++index)
      this.lstAttachments.Items.Add((ListViewItem) new EmailAttachment(frmEmailBlast.GetFileNameFromFullPath(openFileDialog.FileNames[index]), openFileDialog.FileNames[index], this.GetFileImageIndex(openFileDialog.FileNames[index])));
  }

  private void RemoveItem_Click(object sender, EventArgs e)
  {
    if (this.lstAttachments.SelectedItems.Count <= 0)
      return;
    try
    {
      foreach (ListViewItem selectedItem in this.lstAttachments.SelectedItems)
        this.lstAttachments.Items.Remove(selectedItem);
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private void lstAttachments_MouseUp(object sender, MouseEventArgs e)
  {
    if (e.Button != MouseButtons.Right || this.lstAttachments.SelectedItems.Count <= 0)
      return;
    this.AttachmentMenu.Show((Control) this.lstAttachments, new Point(e.X, e.Y));
  }

  private void btnSend_Click(object sender, EventArgs e)
  {
    if (((TextEditorControlBase) this.txtTo).Text.Length == 0)
    {
      int num1 = (int) MessageBox.Show(MGASystems.IMS.Forms.SR.GetString("BULKEMAIL_NOEMAILSELECTED"), MGASystems.IMS.Forms.SR.GetString("BULKEMAIL_NOEMAILSELECTED_CAP"), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    else if (this._email == null)
    {
      int num2 = (int) MessageBox.Show(MGASystems.IMS.Forms.SR.GetString("BULKEMAIL_NOEMAILSPECIFIED"), MGASystems.IMS.Forms.SR.GetString("BULKEMAIL_NOEMAILSPECIFIED_CAP"), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    else
    {
      this.Hide();
      new Thread(new ThreadStart(this.SendMessage)).Start();
    }
  }

  private void lstAttachments_DragEnter(object sender, DragEventArgs e)
  {
    if (e.Data.GetDataPresent(DataFormats.FileDrop) || e.Data.GetDataPresent("MGASystems.IMS.NoteDocuments.TabDocumentPanel+FileNode"))
      e.Effect = DragDropEffects.Copy;
    else
      e.Effect = DragDropEffects.None;
  }

  private void lstAttachments_DragDrop(object sender, DragEventArgs e)
  {
    Cursor.Current = Cursors.WaitCursor;
    if (e.Data.GetDataPresent("MGASystems.IMS.NoteDocuments.TabDocumentPanel+FileNode"))
    {
      string file = DocumentManager.SaveDocumentToFile(((TabDocumentPanel.FileNode) e.Data.GetData("MGASystems.IMS.NoteDocuments.TabDocumentPanel+FileNode")).DocumentGUID);
      this.lstAttachments.Items.Add((ListViewItem) new EmailAttachment(frmEmailBlast.GetFileNameFromFullPath(file), file, this.GetFileImageIndex(file)));
    }
    if (e.Data.GetDataPresent(DataFormats.FileDrop))
    {
      string[] data = (string[]) e.Data.GetData(DataFormats.FileDrop);
      int index = 0;
      while (index < data.Length)
      {
        string str = data[index];
        this.lstAttachments.Items.Add((ListViewItem) new EmailAttachment(frmEmailBlast.GetFileNameFromFullPath(str), str, this.GetFileImageIndex(str)));
        checked { ++index; }
      }
    }
    Cursor.Current = Cursors.Default;
  }

  private delegate void CloseWindowHandler();
}
