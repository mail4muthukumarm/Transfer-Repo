// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Forms.CRMEmail_EmailBody
// Assembly: MgaSystems.IMS.Forms, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FB3F392E-40B6-486F-8F0B-A4A494A546D4
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Forms.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using MGASystems.AsposeFacade.Email.Exchange;
using MGASystems.AsposeFacade.Email.Mail;
using MGASystems.Common;
using MGASystems.Common.Email;
using MGASystems.Data;
using MGASystems.Tools;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Net.Mail;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Forms;

[DesignerGenerated]
public class CRMEmail_EmailBody : UserControl
{
  private IContainer components;
  private CRMEMail_RecipientList _crmEmailRecipients;
  private string _currentGraphicsFile;
  private FileTypeImageCollection _imageCollection;
  private object _attachments;
  private Hashtable _extensionHash;
  private object _eMail;
  private string _eBody;
  private string _eSubject;
  private string _mGATempDir;
  private long _attachmentSize;
  private string _optOutFooter;
  private string _replyTo;
  private SmtpClient _mailClientS;
  private ExchangeClient _mailClientE;
  private bool IsImageBody;
  private string _eSender;
  private string _eRecipient;
  private string _eProducerContactGUID;
  private List<string> _exchangeAttachmentList;
  private Attachment[] _smtpAttachmentList;
  private List<Attachment> _tempSMTPAttachementList;
  private List<string> _attachmentFileList;
  private string _mailServerAddress;
  private string _mailUserName;
  private string _mailPassword;
  private string _exchangeDomainName;
  public string MailSystemType;
  public const string canOpenCRMEmailForm = "{7CE6C129-F66C-4864-A860-DE3E9D7C1632}";

  [DebuggerNonUserCode]
  protected override void Dispose(bool disposing)
  {
    try
    {
      if (!disposing || this.components == null)
        return;
      this.components.Dispose();
    }
    finally
    {
      base.Dispose(disposing);
    }
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    this.GroupBox4 = new GroupBox();
    this.TextBox1 = new TextBox();
    this.lstAttachments = new ListView();
    this.btnAddAttachment = new MGAButton();
    this.GroupBox1 = new GroupBox();
    this.txtSubject = new MGATextBox();
    this.lblSubject = new Label();
    this.rtbMessage = new RichTextBox();
    this.GroupBox6 = new GroupBox();
    this.Label1 = new Label();
    this.buttonGraphicImage = new MGAButton();
    this.Label9 = new Label();
    this.GroupBox2 = new GroupBox();
    this.txtSender = new MGATextBox();
    this.Label2 = new Label();
    this.GroupBox4.SuspendLayout();
    ((ISupportInitialize) this.btnAddAttachment).BeginInit();
    this.GroupBox1.SuspendLayout();
    ((ISupportInitialize) this.txtSubject).BeginInit();
    this.GroupBox6.SuspendLayout();
    ((ISupportInitialize) this.buttonGraphicImage).BeginInit();
    this.GroupBox2.SuspendLayout();
    ((ISupportInitialize) this.txtSender).BeginInit();
    this.SuspendLayout();
    this.GroupBox4.Controls.Add((Control) this.TextBox1);
    this.GroupBox4.Controls.Add((Control) this.lstAttachments);
    this.GroupBox4.Controls.Add((Control) this.btnAddAttachment);
    this.GroupBox4.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.GroupBox4.Location = new Point(18, 93);
    this.GroupBox4.Name = "GroupBox4";
    this.GroupBox4.Size = new Size(629, 89);
    this.GroupBox4.TabIndex = 23;
    this.GroupBox4.TabStop = false;
    this.GroupBox4.Text = "Please Select Any Attachments ";
    this.TextBox1.BackColor = Color.Black;
    this.TextBox1.ForeColor = Color.White;
    this.TextBox1.Location = new Point(10, 49);
    this.TextBox1.Multiline = true;
    this.TextBox1.Name = "TextBox1";
    this.TextBox1.ReadOnly = true;
    this.TextBox1.Size = new Size(151, 34);
    this.TextBox1.TabIndex = 25;
    this.TextBox1.Text = "To remove an attachment, uncheck it";
    this.lstAttachments.CheckBoxes = true;
    this.lstAttachments.Location = new Point(168, 11);
    this.lstAttachments.Name = "lstAttachments";
    this.lstAttachments.Size = new Size(455, 78);
    this.lstAttachments.TabIndex = 24;
    this.lstAttachments.UseCompatibleStateImageBehavior = false;
    appearance1.BackColor = Color.FromArgb(248, 248, 248);
    appearance1.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance1.BackGradientStyle = (GradientStyle) 2;
    appearance1.BorderColor = Color.DarkGray;
    appearance1.ImageHAlign = (HAlign) 2;
    appearance1.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnAddAttachment).Appearance = (AppearanceBase) appearance1;
    ((Control) this.btnAddAttachment).Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.btnAddAttachment).Location = new Point(10, 19);
    ((Control) this.btnAddAttachment).Name = "btnAddAttachment";
    ((Control) this.btnAddAttachment).Size = new Size(151, 23);
    ((Control) this.btnAddAttachment).TabIndex = 23;
    ((ControlBase) this.btnAddAttachment).Text = "Select Attachment(s)";
    this.btnAddAttachment.UseOSThemes = (DefaultableBoolean) 2;
    this.GroupBox1.Controls.Add((Control) this.txtSubject);
    this.GroupBox1.Controls.Add((Control) this.lblSubject);
    this.GroupBox1.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.GroupBox1.Location = new Point(19, 48 /*0x30*/);
    this.GroupBox1.Name = "GroupBox1";
    this.GroupBox1.Size = new Size(627, 44);
    this.GroupBox1.TabIndex = 24;
    this.GroupBox1.TabStop = false;
    this.GroupBox1.Text = "Please Enter the Subject For Your Email";
    ((Control) this.txtSubject).Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    appearance2.BackColor = Color.White;
    appearance2.BorderColor = Color.Gray;
    appearance2.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtSubject).Appearance = (AppearanceBase) appearance2;
    ((TextEditorControlBase) this.txtSubject).BackColor = Color.White;
    ((Control) this.txtSubject).Location = new Point(63 /*0x3F*/, 19);
    ((Control) this.txtSubject).Name = "txtSubject";
    ((Control) this.txtSubject).Size = new Size(558, 20);
    ((Control) this.txtSubject).TabIndex = 20;
    ((UltraControlBase) this.txtSubject).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtSubject).UseOsThemes = (DefaultableBoolean) 2;
    this.lblSubject.Font = new Font("Tahoma", 9f);
    this.lblSubject.Location = new Point(5, 19);
    this.lblSubject.Name = "lblSubject";
    this.lblSubject.Size = new Size(56, 19);
    this.lblSubject.TabIndex = 21;
    this.lblSubject.Text = "Sub&ject:";
    this.lblSubject.TextAlign = ContentAlignment.MiddleLeft;
    this.rtbMessage.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.rtbMessage.BorderStyle = BorderStyle.FixedSingle;
    this.rtbMessage.EnableAutoDragDrop = true;
    this.rtbMessage.Location = new Point(18, 261);
    this.rtbMessage.Name = "rtbMessage";
    this.rtbMessage.ScrollBars = RichTextBoxScrollBars.ForcedVertical;
    this.rtbMessage.ShowSelectionMargin = true;
    this.rtbMessage.Size = new Size(628, 312);
    this.rtbMessage.TabIndex = 26;
    this.rtbMessage.Text = "";
    this.GroupBox6.Controls.Add((Control) this.Label1);
    this.GroupBox6.Controls.Add((Control) this.buttonGraphicImage);
    this.GroupBox6.Controls.Add((Control) this.Label9);
    this.GroupBox6.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.GroupBox6.Location = new Point(18, 188);
    this.GroupBox6.Name = "GroupBox6";
    this.GroupBox6.Size = new Size(627, 67);
    this.GroupBox6.TabIndex = 27;
    this.GroupBox6.TabStop = false;
    this.GroupBox6.Text = "Enter the Body of Your Email Below or Select Your Graphic Content";
    this.Label1.AutoSize = true;
    this.Label1.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label1.Location = new Point(7, 38);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(368, 14);
    this.Label1.TabIndex = 25;
    this.Label1.Text = "Click the button to use a graphic image as the Body of Your Email";
    appearance3.BackColor = Color.FromArgb(248, 248, 248);
    appearance3.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance3.BackGradientStyle = (GradientStyle) 2;
    appearance3.BorderColor = Color.DarkGray;
    appearance3.ImageHAlign = (HAlign) 2;
    appearance3.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonGraphicImage).Appearance = (AppearanceBase) appearance3;
    ((Control) this.buttonGraphicImage).Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.buttonGraphicImage).Location = new Point(424, 35);
    ((Control) this.buttonGraphicImage).Name = "buttonGraphicImage";
    ((Control) this.buttonGraphicImage).Size = new Size(179, 23);
    ((Control) this.buttonGraphicImage).TabIndex = 24;
    ((ControlBase) this.buttonGraphicImage).Text = "Select Graphic Image File";
    this.buttonGraphicImage.UseOSThemes = (DefaultableBoolean) 2;
    this.Label9.AutoSize = true;
    this.Label9.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label9.Location = new Point(6, 16 /*0x10*/);
    this.Label9.Name = "Label9";
    this.Label9.Size = new Size(353, 14);
    this.Label9.TabIndex = 16 /*0x10*/;
    this.Label9.Text = "PleaseType the Body of Your Email in the Text Box Below or...";
    this.GroupBox2.Controls.Add((Control) this.txtSender);
    this.GroupBox2.Controls.Add((Control) this.Label2);
    this.GroupBox2.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.GroupBox2.Location = new Point(18, 3);
    this.GroupBox2.Name = "GroupBox2";
    this.GroupBox2.Size = new Size(627, 44);
    this.GroupBox2.TabIndex = 28;
    this.GroupBox2.TabStop = false;
    this.GroupBox2.Text = "Please Enter the Email Address of the Sender of Your Email";
    ((Control) this.txtSender).Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    appearance4.BackColor = Color.White;
    appearance4.BorderColor = Color.Gray;
    appearance4.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtSender).Appearance = (AppearanceBase) appearance4;
    ((TextEditorControlBase) this.txtSender).BackColor = Color.White;
    ((Control) this.txtSender).Location = new Point(63 /*0x3F*/, 19);
    ((Control) this.txtSender).Name = "txtSender";
    ((Control) this.txtSender).Size = new Size(558, 20);
    ((Control) this.txtSender).TabIndex = 20;
    ((UltraControlBase) this.txtSender).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtSender).UseOsThemes = (DefaultableBoolean) 2;
    this.Label2.Font = new Font("Tahoma", 9f);
    this.Label2.Location = new Point(5, 19);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(56, 19);
    this.Label2.TabIndex = 21;
    this.Label2.Text = "Sender:";
    this.Label2.TextAlign = ContentAlignment.MiddleLeft;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.AutoSize = true;
    this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
    this.Controls.Add((Control) this.GroupBox2);
    this.Controls.Add((Control) this.GroupBox6);
    this.Controls.Add((Control) this.rtbMessage);
    this.Controls.Add((Control) this.GroupBox1);
    this.Controls.Add((Control) this.GroupBox4);
    this.Name = nameof (CRMEmail_EmailBody);
    this.Size = new Size(656, 590);
    this.GroupBox4.ResumeLayout(false);
    this.GroupBox4.PerformLayout();
    ((ISupportInitialize) this.btnAddAttachment).EndInit();
    this.GroupBox1.ResumeLayout(false);
    this.GroupBox1.PerformLayout();
    ((ISupportInitialize) this.txtSubject).EndInit();
    this.GroupBox6.ResumeLayout(false);
    this.GroupBox6.PerformLayout();
    ((ISupportInitialize) this.buttonGraphicImage).EndInit();
    this.GroupBox2.ResumeLayout(false);
    this.GroupBox2.PerformLayout();
    ((ISupportInitialize) this.txtSender).EndInit();
    this.ResumeLayout(false);
  }

  [field: AccessedThroughProperty("GroupBox4")]
  internal virtual GroupBox GroupBox4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("GroupBox1")]
  internal virtual GroupBox GroupBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtSubject")]
  internal virtual MGATextBox txtSubject { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblSubject")]
  internal virtual Label lblSubject { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual RichTextBox rtbMessage
  {
    get => this._rtbMessage;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.rtbMessage_TextChanged);
      RichTextBox rtbMessage1 = this._rtbMessage;
      if (rtbMessage1 != null)
        rtbMessage1.TextChanged -= eventHandler;
      this._rtbMessage = value;
      RichTextBox rtbMessage2 = this._rtbMessage;
      if (rtbMessage2 == null)
        return;
      rtbMessage2.TextChanged += eventHandler;
    }
  }

  [field: AccessedThroughProperty("GroupBox6")]
  internal virtual GroupBox GroupBox6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label9")]
  internal virtual Label Label9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual MGAButton btnAddAttachment
  {
    get => this._btnAddAttachment;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnAddAttachment_Click_1);
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

  internal virtual MGAButton buttonGraphicImage
  {
    get => this._buttonGraphicImage;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.rbGraphics_CheckedChanged);
      MGAButton buttonGraphicImage1 = this._buttonGraphicImage;
      if (buttonGraphicImage1 != null)
        ((Control) buttonGraphicImage1).Click -= eventHandler;
      this._buttonGraphicImage = value;
      MGAButton buttonGraphicImage2 = this._buttonGraphicImage;
      if (buttonGraphicImage2 == null)
        return;
      ((Control) buttonGraphicImage2).Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("Label1")]
  internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("GroupBox2")]
  internal virtual GroupBox GroupBox2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtSender")]
  internal virtual MGATextBox txtSender { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label2")]
  internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lstAttachments")]
  internal virtual ListView lstAttachments { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox1")]
  internal virtual TextBox TextBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private static string WriteLog(string method, string message, bool optional = false)
  {
    return ActionLog.Write(nameof (CRMEmail_EmailBody), method, message, optional);
  }

  public CRMEmail_EmailBody()
  {
    this.Load += new EventHandler(this.CRMEmail_EmailBody_Load);
    this._attachmentSize = 0L;
    this._exchangeAttachmentList = new List<string>();
    this._tempSMTPAttachementList = new List<Attachment>();
    this._attachmentFileList = new List<string>();
    this.InitializeComponent();
  }

  public CRMEmail_EmailBody(string sender)
  {
    this.Load += new EventHandler(this.CRMEmail_EmailBody_Load);
    this._attachmentSize = 0L;
    this._exchangeAttachmentList = new List<string>();
    this._tempSMTPAttachementList = new List<Attachment>();
    this._attachmentFileList = new List<string>();
    this.InitializeComponent();
    this._eSender = sender;
    ((TextEditorControlBase) this.txtSender).Text = this._eSender;
  }

  private int GetFileImageIndex(string Path)
  {
    if (this._imageCollection == null)
      this._imageCollection = new FileTypeImageCollection();
    if (this._extensionHash == null)
      this._extensionHash = new Hashtable();
    int startIndex = Path.LastIndexOf('.');
    int fileImageIndex;
    if (Path.Length > 0 && startIndex != -1)
    {
      string key = Path.Substring(startIndex, Path.Length - startIndex);
      if (this._extensionHash.ContainsKey((object) key))
      {
        fileImageIndex = Conversions.ToInteger(this._extensionHash[(object) key]);
        goto label_9;
      }
      this._extensionHash.Add((object) key, (object) this._extensionHash.Count);
    }
    fileImageIndex = -1;
label_9:
    return fileImageIndex;
  }

  private long CalculateFileLength(string Filename) => 0L + new FileInfo(Filename).Length;

  private Image ConvertToPNG(Image img)
  {
    CRMEmail_EmailBody.WriteLog(nameof (ConvertToPNG), "Invoking", true);
    string withoutExtension = Path.GetFileNameWithoutExtension(this._currentGraphicsFile);
    this._mGATempDir = MGATempFolder.CreateTempSubdirectory();
    string str = $"{this._mGATempDir}{withoutExtension}.png";
    Image png;
    try
    {
      FileStream fileStream = new FileInfo(this._currentGraphicsFile).OpenRead();
      long length = fileStream.Length;
      if (length > 0L)
      {
        byte[] numArray = new byte[(int) (length - 1L) + 1];
        fileStream.Read(numArray, 0, (int) length);
        fileStream.Close();
        File.WriteAllBytes(str, this.ResizeImageFile(numArray, 800));
        img = Image.FromFile(str);
      }
      this._currentGraphicsFile = str;
      png = img;
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      CRMEmail_EmailBody.WriteLog("ConvertToPNG FAILED", ex.Message);
      png = (Image) null;
      ProjectData.ClearProjectError();
    }
    return png;
  }

  private void rbGraphics_CheckedChanged(object sender, EventArgs e)
  {
    CRMEmail_EmailBody.WriteLog(nameof (rbGraphics_CheckedChanged), "Invoking", true);
    OpenFileDialog openFileDialog1 = new OpenFileDialog();
    OpenFileDialog openFileDialog2 = openFileDialog1;
    openFileDialog2.InitialDirectory = "c:\\My Documents";
    openFileDialog2.Filter = "Bitmap Files|*.bmp|Enhanced Windows MetaFile|*.emf|Exchangeable Image File|*.exif|Gif Files|*.gif|Icons|*.ico|JPEG Files|*.jpg|PNG Files|*.png|TIFF Files|*.tif|Windows MetaFile|*.wmf";
    openFileDialog2.Multiselect = false;
    openFileDialog2.AddExtension = true;
    bool flag;
    try
    {
      if (openFileDialog1.ShowDialog() == DialogResult.OK)
      {
        if (openFileDialog1.CheckFileExists & openFileDialog1.CheckPathExists & this.CalculateFileLength(openFileDialog1.FileName) < 2000000L)
        {
          this.rtbMessage.Clear();
          this._currentGraphicsFile = openFileDialog1.FileName;
          Clipboard.SetImage(this.ConvertToPNG(Image.FromFile(openFileDialog1.FileName)));
          this.rtbMessage.Paste();
        }
      }
    }
    catch (AccessViolationException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      AccessViolationException violationException = ex;
      CRMEmail_EmailBody.WriteLog("rbGraphics_CheckedChanged Failed (AccessViolationException)", violationException.Message);
      int num = (int) Interaction.MsgBox((object) violationException.StackTrace.ToString());
      flag = true;
      ProjectData.ClearProjectError();
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      Exception exception = ex;
      CRMEmail_EmailBody.WriteLog("rbGraphics_CheckedChanged Failed (Exception)", exception.Message);
      int num = (int) Interaction.MsgBox((object) exception.StackTrace.ToString());
      flag = true;
      ProjectData.ClearProjectError();
    }
    finally
    {
      if (flag)
      {
        int num = (int) Interaction.MsgBox((object) "Program executed with some errors!!!");
      }
    }
    CRMEmail_EmailBody.WriteLog(nameof (rbGraphics_CheckedChanged), "Invoked");
  }

  private byte[] ResizeImageFile(byte[] imageFile, int targetSize)
  {
    using (Image image = Image.FromStream((Stream) new MemoryStream(imageFile)))
    {
      Size dimensions = CRMEmail_EmailBody.CalculateDimensions(image.Size, targetSize);
      using (Bitmap bitmap = new Bitmap(dimensions.Width, dimensions.Height, PixelFormat.Format24bppRgb))
      {
        using (Graphics graphics = Graphics.FromImage((Image) bitmap))
        {
          graphics.SmoothingMode = SmoothingMode.AntiAlias;
          graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
          graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
          graphics.DrawImage(image, new Rectangle(new Point(0, 0), dimensions));
          MemoryStream memoryStream = new MemoryStream();
          bitmap.Save((Stream) memoryStream, ImageFormat.Png);
          return memoryStream.GetBuffer();
        }
      }
    }
  }

  private static Size CalculateDimensions(Size oldSize, int targetSize)
  {
    Size dimensions = new Size();
    if (oldSize.Height > oldSize.Width)
    {
      dimensions.Width = (int) Math.Round((double) oldSize.Width * ((double) targetSize / (double) oldSize.Height));
      dimensions.Height = targetSize;
    }
    else
    {
      dimensions.Width = targetSize;
      dimensions.Height = (int) Math.Round((double) oldSize.Height * ((double) targetSize / (double) oldSize.Width));
    }
    return dimensions;
  }

  private void btnAddAttachment_Click_1(object sender, EventArgs e)
  {
    using (OpenFileDialog openFileDialog = new OpenFileDialog())
    {
      openFileDialog.Multiselect = true;
      if (openFileDialog.ShowDialog() != DialogResult.OK)
        return;
      int num = openFileDialog.FileNames.Length - 1;
      for (int index = 0; index <= num; ++index)
      {
        string fileName = openFileDialog.FileNames[index];
        this.lstAttachments.Items.Add(new ListViewItem(Path.GetFileName(fileName))
        {
          Name = fileName
        }).Checked = true;
        this._attachmentSize += this.CalculateFileLength(openFileDialog.FileNames[index]);
        if (this._attachmentSize > 1500000L)
          new FormCRMEmailer().DisplayError("You Have Exceeded the Maximum Attachment Size of 1.5 Megabytes");
      }
    }
  }

  private void SendSMTPNoAttachmentNoImage(
    string msgTo,
    string msgFrom,
    string msgSubject,
    string msgBody)
  {
    SMTP_Email.SendMail(msgTo, msgFrom, msgSubject, msgBody, this._mailServerAddress, this._mailUserName, this._mailPassword, (Attachment[]) null);
  }

  private void SendSMTPNoAttachmentImage(
    string msgTo,
    string msgFrom,
    string msgSubject,
    string msgBody)
  {
    SMTP_Email.SendMail(msgTo, msgFrom, msgSubject, msgBody, this._mailServerAddress, this._mailUserName, this._mailPassword, (Attachment[]) null, (List<string>) null, (List<string>) null, true);
  }

  private void SendSMTPAttachmentNoImage(
    string msgTo,
    string msgFrom,
    string msgSubject,
    string msgBody)
  {
    SMTP_Email.SendMail(msgTo, msgFrom, msgSubject, msgBody, this._mailServerAddress, this._mailUserName, this._mailPassword, this._smtpAttachmentList, (List<string>) null, (List<string>) null, false);
  }

  private void SendSMTPAttachmentImage(
    string msgTo,
    string msgFrom,
    string msgSubject,
    string msgBody)
  {
    SMTP_Email.SendMail(msgTo, msgFrom, msgSubject, msgBody, this._mailServerAddress, this._mailUserName, this._mailPassword, this._smtpAttachmentList, (List<string>) null, (List<string>) null, true);
  }

  private ExchangeClient CreateExchangeClient()
  {
    return new ExchangeClient(this._mailServerAddress, this._mailUserName, this._mailPassword, this._exchangeDomainName);
  }

  private void SendExchangeNoAttachmentNoImage(
    string msgTo,
    string msgFrom,
    string msgSubject,
    string msgBody)
  {
    UsingExchange.SendMailUsingExchange(msgTo, msgFrom, msgSubject, msgBody);
  }

  private void SendExchangeNoAttachmentImage(
    string msgTo,
    string msgFrom,
    string msgSubject,
    string msgBody)
  {
    UsingExchange.SendMailUsingExchange(msgTo, msgFrom, msgSubject, msgBody, (string) null, (List<string>) null, (List<string>) null, (List<string>) null, string.Empty, string.Empty, string.Empty, true);
  }

  private void SendExchangeAttachmentNoImage(
    string msgTo,
    string msgFrom,
    string msgSubject,
    string msgBody)
  {
    UsingExchange.SendMailUsingExchange(msgTo, msgFrom, msgSubject, msgBody, this._exchangeDomainName, this._exchangeAttachmentList);
  }

  private void SendExchangeAttachmentImage(
    string msgTo,
    string msgFrom,
    string msgSubject,
    string msgBody)
  {
    UsingExchange.SendMailUsingExchange(msgTo, msgFrom, msgSubject, msgBody, this._exchangeDomainName, this._exchangeAttachmentList, (List<string>) null, (List<string>) null, string.Empty, string.Empty, string.Empty, true);
  }

  private bool CheckForSubject()
  {
    this._eSubject = ((TextEditorControlBase) this.txtSubject).Text;
    bool flag;
    if (string.IsNullOrEmpty(this._eSubject))
    {
      int num = (int) MessageBox.Show("Please Enter a Subject for Your Email");
      ((TextEditorControlBase) this.txtSubject).Focus();
      flag = false;
    }
    else
      flag = true;
    return flag;
  }

  private bool CheckForSender()
  {
    this._eSender = ((TextEditorControlBase) this.txtSender).Text;
    bool flag;
    if (string.IsNullOrEmpty(this._eSender))
    {
      int num = (int) MessageBox.Show("Please Enter a Valid Sender's Email Address for Your Email");
      ((TextEditorControlBase) this.txtSubject).Focus();
      flag = false;
    }
    else
      flag = true;
    return flag;
  }

  public void GetCurrentUserEmailCredentials()
  {
    CRMEmail_EmailBody.WriteLog(nameof (GetCurrentUserEmailCredentials), "Invoking", true);
    DataRow dataRow = DefaultDatabase.ExecuteDataRow(CommandType.Text, "SELECT ExchangeServerDomain, MailServerAddress, MailUserName, MailPassword, EmailAddress FROM tblUsers WHERE UserID = @UserID", new object[2]
    {
      (object) "@UserID",
      (object) CurrentUser.Instance.UserID
    });
    Encryption encryption = new Encryption();
    if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["ExchangeServerDomain"])) | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.MailSystemType, "SMTP", false) == 0)
    {
      this.MailSystemType = "SMTP";
    }
    else
    {
      this.MailSystemType = "Exchange";
      this._exchangeDomainName = (string) dataRow["ExchangeServerDomain"];
    }
    this._mailServerAddress = dataRow["MailServerAddress"] as string;
    if (Information.IsNothing((object) this._mailServerAddress))
    {
      int num = (int) MessageBox.Show("A mail server must be configured \r\nto allow you to send emails\r\nPlease consult your System Administrator", "Mail Server Required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
    else
    {
      this._mailUserName = dataRow["MailUserName"] as string;
      try
      {
        this._mailPassword = encryption.DecryptTripleDes(dataRow["MailPassword"] as string);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        CRMEmail_EmailBody.WriteLog("GetCurrentUserEmailCredentials Failed (Exception)", ex.Message);
        ProjectData.ClearProjectError();
      }
      CRMEmail_EmailBody.WriteLog(nameof (GetCurrentUserEmailCredentials), "Invoked");
    }
  }

  public void SendCRMEmail(string eRecipient, string _currentGraphicsFile, object _attachments)
  {
    CRMEmail_EmailBody.WriteLog(nameof (SendCRMEmail), $"Invoking {ActionLog.ToArgString((object) nameof (eRecipient), (object) eRecipient, (object) nameof (_currentGraphicsFile), (object) _currentGraphicsFile)}");
    UserEmail userEmail = CurrentUser.Instance.GetUserEmail();
    MessageObject message = new MessageObject();
    message.ToAddress = eRecipient;
    message.FromAddress = this._eSender;
    message.Subject = this._eSubject;
    message.TextBody = this._eBody;
    if (!string.IsNullOrEmpty(_currentGraphicsFile))
      message.ImageBody = _currentGraphicsFile;
    try
    {
      foreach (string attachmentFile in this._attachmentFileList)
        message.FileAttachments.Add(attachmentFile);
    }
    finally
    {
      List<string>.Enumerator enumerator;
      enumerator.Dispose();
    }
    userEmail.SendMail(message);
    CRMEmail_EmailBody.WriteLog(nameof (SendCRMEmail), "Invoked");
  }

  private void LoopThruEmailsBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
  {
    bool flag = true;
    CRMEmail_EmailBody.WriteLog(nameof (LoopThruEmailsBackgroundWorker_DoWork), "Invoking", true);
    DataTable dataTable = e.Argument as DataTable;
    string str = string.Empty;
    if (dataTable != null)
    {
      int num = dataTable.Rows.Count - 1;
      for (int index = 0; index <= num; ++index)
      {
        DataRow row = dataTable.Rows[index];
        try
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.MailSystemType, "SMTP", false) == 0)
            this.SendCRMEmail((string) row["EmailAddress"], Utility.IsNull<string>(RuntimeHelpers.GetObjectValue(row["GraphicsFilePath"]), ""), (object) (Attachment[]) row["Attachments"]);
          else
            this.SendCRMEmail((string) row["EmailAddress"], Utility.IsNull<string>(RuntimeHelpers.GetObjectValue(row["GraphicsFilePath"]), ""), (object) (List<string>) row["Attachments"]);
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          CRMEmail_EmailBody.WriteLog("LoopThruEmailsBackgroundWorker_DoWork Failed (Exception)", ex.Message);
          flag = false;
          str = str + Environment.NewLine + (string) row["EmailAddress"];
          ProjectData.ClearProjectError();
        }
      }
    }
    e.Result = !flag ? (object) ("Failed sending E-Mail to:" + str) : (object) (dataTable.Rows.Count.ToString() + " E-Mail(s) sent successfully");
    CRMEmail_EmailBody.WriteLog(nameof (LoopThruEmailsBackgroundWorker_DoWork), "Invoked");
  }

  private void LoopThruEmailsBackgroundWorker_RunWorkerCompleted(
    object sender,
    RunWorkerCompletedEventArgs e)
  {
    int num = (int) Interaction.MsgBox((object) e.Result.ToString(), Title: (object) "E-Mail Status");
    CRMEmail_EmailBody.WriteLog(nameof (LoopThruEmailsBackgroundWorker_RunWorkerCompleted), "Invoked");
    ((Component) sender).Dispose();
  }

  private void LoopThruEmailsBackgroundWorker_ProgressChanged(
    object sender,
    ProgressChangedEventArgs e)
  {
    if (!(e.UserState is object[] userState) || userState.Length != 2)
      return;
    CRMEmail_EmailBody.WriteLog(nameof (LoopThruEmailsBackgroundWorker_ProgressChanged), $"Row {(int) userState[0]} of {(int) userState[1]}");
  }

  public bool SendEmails(CRMEMail_RecipientList crmEmailRecipients)
  {
    bool flag;
    if (((UltraGridBase) crmEmailRecipients.grdEmailAddresses).DataSource != null)
    {
      this._eBody = this.rtbMessage.Text;
      if (!this.CheckForSender())
        ((TextEditorControlBase) this.txtSender).Focus();
      else if (!this.CheckForSubject())
      {
        ((TextEditorControlBase) this.txtSubject).Focus();
      }
      else
      {
        this.GetCurrentUserEmailCredentials();
        this.GetAttachments();
        BackgroundWorker backgroundWorker = new BackgroundWorker();
        backgroundWorker.DoWork += new DoWorkEventHandler(this.LoopThruEmailsBackgroundWorker_DoWork);
        backgroundWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(this.LoopThruEmailsBackgroundWorker_RunWorkerCompleted);
        DataTable dataTable = new DataTable();
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.MailSystemType, "SMTP", false) == 0)
        {
          dataTable.Columns.Add("EmailAddress", typeof (string));
          dataTable.Columns.Add("GraphicsFilePath", typeof (string));
          dataTable.Columns.Add("Attachments", typeof (Attachment[]));
        }
        else
        {
          dataTable.Columns.Add("EmailAddress", typeof (string));
          dataTable.Columns.Add("GraphicsFilePath", typeof (string));
          dataTable.Columns.Add("Attachments", typeof (object));
        }
        foreach (UltraGridRow row in ((UltraGridBase) crmEmailRecipients.grdEmailAddresses).Rows)
        {
          if (row.Cells["Select"].Value.Equals((object) true) && !string.IsNullOrEmpty(row.Cells["EmailAddress"].Value.ToString()))
          {
            this._eRecipient = row.Cells["EmailAddress"].Value.ToString();
            this._eProducerContactGUID = row.Cells["ProducerContactGUID"].Value.ToString();
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.MailSystemType, "SMTP", false) == 0)
              dataTable.Rows.Add((object) this._eRecipient, (object) this._currentGraphicsFile, (object) this._smtpAttachmentList);
            else
              dataTable.Rows.Add((object) this._eRecipient, (object) this._currentGraphicsFile, (object) this._exchangeAttachmentList);
          }
        }
        if (dataTable.Rows.Count == 0)
        {
          flag = false;
        }
        else
        {
          backgroundWorker.RunWorkerAsync((object) dataTable);
          flag = true;
        }
      }
    }
    else
    {
      this._eRecipient = ((TextEditorControlBase) this.txtSender).Text;
      this._eSender = ((TextEditorControlBase) this.txtSender).Text;
      this._eBody = this.rtbMessage.Text;
      if (!this.CheckForSender())
        ((TextEditorControlBase) this.txtSender).Focus();
      else if (!this.CheckForSubject())
      {
        ((TextEditorControlBase) this.txtSubject).Focus();
      }
      else
      {
        this.GetCurrentUserEmailCredentials();
        this.GetAttachments();
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.MailSystemType, "Exchange", false) == 0)
          this.SendCRMEmail(this._eRecipient, this._currentGraphicsFile, (object) this._exchangeAttachmentList);
        else
          this.SendCRMEmail(this._eRecipient, this._currentGraphicsFile, (object) this._smtpAttachmentList);
        flag = true;
      }
    }
    return flag;
  }

  private void GetAttachments()
  {
    this._attachmentFileList.Clear();
    try
    {
      foreach (ListViewItem listViewItem in this.lstAttachments.Items)
      {
        if (listViewItem.Checked)
          this._attachmentFileList.Add(listViewItem.Name);
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.MailSystemType, "Exchange", false) == 0)
    {
      this._exchangeAttachmentList.Clear();
      try
      {
        try
        {
          foreach (ListViewItem listViewItem in this.lstAttachments.Items)
          {
            if (listViewItem.Checked)
              this._exchangeAttachmentList.Add(listViewItem.Name);
          }
        }
        finally
        {
          IEnumerator enumerator;
          if (enumerator is IDisposable)
            (enumerator as IDisposable).Dispose();
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }
    else
    {
      this._tempSMTPAttachementList.Clear();
      try
      {
        foreach (ListViewItem listViewItem in this.lstAttachments.Items)
        {
          if (listViewItem.Checked)
            this._tempSMTPAttachementList.Add(new Attachment(listViewItem.Name, "application/octet-stream"));
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
      this._smtpAttachmentList = this._tempSMTPAttachementList.ToArray();
    }
  }

  private string GetFooter() => (string) null;

  private void rtbMessage_TextChanged(object sender, EventArgs e)
  {
    this._eBody = this.rtbMessage.Text;
  }

  private void CRMEmail_EmailBody_Load(object sender, EventArgs e)
  {
    ListView lstAttachments = this.lstAttachments;
    lstAttachments.Columns.Add("File Name", 250, HorizontalAlignment.Left);
    lstAttachments.View = View.Details;
    lstAttachments.CheckBoxes = true;
    lstAttachments.FullRowSelect = true;
    lstAttachments.GridLines = false;
    lstAttachments.Sorting = SortOrder.Ascending;
  }
}
