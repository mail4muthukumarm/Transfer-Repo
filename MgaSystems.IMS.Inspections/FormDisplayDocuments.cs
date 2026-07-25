// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Inspections.FormDisplayDocuments
// Assembly: MgaSystems.IMS.Inspections, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 07B8D1F3-634C-445B-ABFB-027DE209A43D
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Inspections.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using MGASystems.BusinessObjects;
using MGASystems.Common.ErrorHandling;
using MGASystems.Common.Settings;
using MGASystems.IMS.DocumentAutomation;
using MGASystems.IMS.NoteDocuments.DocumentSystem;
using MGASystems.Tools;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

#nullable disable
namespace MGASystems.IMS.Policies.Inspections;

[DesignerGenerated]
public class FormDisplayDocuments : Form
{
  private IContainer components;
  private readonly Quote _quote;
  private readonly string _UserName;
  private readonly string _Password;
  private readonly string _Url;
  private readonly int _controlNo;
  private bool _clickSave;

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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (FormDisplayDocuments));
    Appearance appearance2 = new Appearance();
    this.lstDocuments = new MGACheckedListBox();
    this.btnSave = new MGAButton();
    this.Label1 = new Label();
    this.panelSearch = new UltraGroupBox();
    this.spinner = new PictureBox();
    this.labelSearchText = new Label();
    Label label = new Label();
    ((ISupportInitialize) this.lstDocuments).BeginInit();
    ((ISupportInitialize) this.btnSave).BeginInit();
    ((ISupportInitialize) this.panelSearch).BeginInit();
    ((Control) this.panelSearch).SuspendLayout();
    ((ISupportInitialize) this.spinner).BeginInit();
    this.SuspendLayout();
    this.lstDocuments.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.lstDocuments.BackColor = Color.White;
    this.lstDocuments.CheckOnClick = true;
    this.lstDocuments.ForeColor = Color.Black;
    this.lstDocuments.Location = new Point(12, 57);
    this.lstDocuments.MGAStyle = MGAStyles.Blue;
    this.lstDocuments.Name = "lstDocuments";
    this.lstDocuments.Size = new Size(540, 529);
    this.lstDocuments.TabIndex = 10;
    ((Control) this.btnSave).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance1.BackColor = Color.FromArgb(248, 248, 248);
    appearance1.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance1.BackGradientStyle = (GradientStyle) 2;
    appearance1.BorderColor = Color.DarkGray;
    appearance1.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance1.Image"));
    appearance1.ImageHAlign = (HAlign) 1;
    appearance1.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnSave).Appearance = (AppearanceBase) appearance1;
    ((Control) this.btnSave).Font = new Font("Tahoma", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.btnSave).Location = new Point(482, 623);
    ((Control) this.btnSave).Name = "btnSave";
    ((ControlBase) this.btnSave).Padding = new Size(5, 0);
    ((Control) this.btnSave).Size = new Size(70, 34);
    ((Control) this.btnSave).TabIndex = 35;
    ((ControlBase) this.btnSave).Text = "Save";
    this.btnSave.UseOSThemes = (DefaultableBoolean) 2;
    this.Label1.AutoSize = true;
    this.Label1.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label1.Location = new Point(107, 23);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(263, 15);
    this.Label1.TabIndex = 36;
    this.Label1.Text = "Select files to send to Preferred Reports";
    this.panelSearch.BackColorInternal = Color.White;
    appearance2.BorderColor = Color.Gray;
    this.panelSearch.ContentAreaAppearance = (AppearanceBase) appearance2;
    ((Control) this.panelSearch).Controls.Add((Control) this.spinner);
    ((Control) this.panelSearch).Controls.Add((Control) this.labelSearchText);
    ((Control) this.panelSearch).Controls.Add((Control) label);
    ((Control) this.panelSearch).ForeColor = Color.Black;
    ((Control) this.panelSearch).Location = new Point(29, 203);
    ((Control) this.panelSearch).Name = "panelSearch";
    ((Control) this.panelSearch).Size = new Size(501, 148);
    ((Control) this.panelSearch).TabIndex = 116;
    ((Control) this.panelSearch).Visible = false;
    this.spinner.Image = (Image) componentResourceManager.GetObject("spinner.Image");
    this.spinner.Location = new Point(177, 98);
    this.spinner.Name = "spinner";
    this.spinner.Size = new Size(60, 44);
    this.spinner.SizeMode = PictureBoxSizeMode.Zoom;
    this.spinner.TabIndex = 116;
    this.spinner.TabStop = false;
    this.labelSearchText.Font = new Font("Tahoma", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.labelSearchText.Location = new Point(6, 45);
    this.labelSearchText.Name = "labelSearchText";
    this.labelSearchText.Size = new Size(489, 40);
    this.labelSearchText.TabIndex = 3;
    this.labelSearchText.Text = "Gathering files to upload ...";
    this.labelSearchText.TextAlign = ContentAlignment.MiddleCenter;
    label.AutoSize = true;
    label.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    label.Location = new Point(103, 16 /*0x10*/);
    label.Name = "Label27";
    label.Size = new Size(224 /*0xE0*/, 19);
    label.TabIndex = 1;
    label.Text = "Uploading files ... Please Wait.";
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    this.ClientSize = new Size(564, 665);
    this.Controls.Add((Control) this.panelSearch);
    this.Controls.Add((Control) this.Label1);
    this.Controls.Add((Control) this.btnSave);
    this.Controls.Add((Control) this.lstDocuments);
    this.Name = nameof (FormDisplayDocuments);
    this.Text = "Available Documents";
    ((ISupportInitialize) this.lstDocuments).EndInit();
    ((ISupportInitialize) this.btnSave).EndInit();
    ((ISupportInitialize) this.panelSearch).EndInit();
    ((Control) this.panelSearch).ResumeLayout(false);
    ((Control) this.panelSearch).PerformLayout();
    ((ISupportInitialize) this.spinner).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  [field: AccessedThroughProperty("lstDocuments")]
  private virtual MGACheckedListBox lstDocuments { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual MGAButton btnSave
  {
    get => this._btnSave;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnSave_Click);
      MGAButton btnSave1 = this._btnSave;
      if (btnSave1 != null)
        ((Control) btnSave1).Click -= eventHandler;
      this._btnSave = value;
      MGAButton btnSave2 = this._btnSave;
      if (btnSave2 == null)
        return;
      ((Control) btnSave2).Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("Label1")]
  internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("panelSearch")]
  private virtual UltraGroupBox panelSearch { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("spinner")]
  public virtual PictureBox spinner { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("labelSearchText")]
  private virtual Label labelSearchText { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  public FormDisplayDocuments(Quote q, string un, string pw, string url)
  {
    this.Load += new EventHandler(this.FormDisplayDocuments_Load);
    this._UserName = string.Empty;
    this._Password = string.Empty;
    this._Url = string.Empty;
    this.InitializeComponent();
    this._quote = q;
    this._UserName = un;
    this._Password = pw;
    this._Url = url;
    this._controlNo = this._quote.ControlNo;
  }

  public FormDisplayDocuments(Quote q)
  {
    this.Load += new EventHandler(this.FormDisplayDocuments_Load);
    this._UserName = string.Empty;
    this._Password = string.Empty;
    this._Url = string.Empty;
    this.InitializeComponent();
    this._quote = q;
    this._controlNo = this._quote.ControlNo;
  }

  public bool ClickedSave => this._clickSave;

  public List<Guid> CheckDocuments
  {
    get
    {
      List<Guid> checkDocuments = new List<Guid>();
      try
      {
        foreach (DocListItem checkedItem in this.lstDocuments.CheckedItems)
          checkDocuments.Add(checkedItem.DocumentStoreGuid);
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
      return checkDocuments;
    }
  }

  public bool UsingLossControlFileUpload { get; set; }

  private void FormDisplayDocuments_Load(object sender, EventArgs e)
  {
    this._clickSave = false;
    List<DocListItem> docItemList = AdditionalDoc.GetDocItemList(this._quote.ControlGuid);
    try
    {
      foreach (object obj in docItemList)
        this.lstDocuments.Items.Add(obj);
    }
    finally
    {
      List<DocListItem>.Enumerator enumerator;
      enumerator.Dispose();
    }
  }

  private void btnSave_Click(object sender, EventArgs e)
  {
    this._clickSave = true;
    if (this.UploadDocuments())
    {
      try
      {
        ((Control) this.panelSearch).Visible = true;
        if (this.UsingLossControlFileUpload)
          this.LossControlFileUpload();
        else
          this.OtherService();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception innerException = ex;
        ErrorHandler.SilentHandleError(new Exception($"Failed to upload file to \"{this._Url}\"", innerException));
        int num = (int) MessageBox.Show($"Could not transfer file at this moment because of the following reasons:{Environment.NewLine}{Environment.NewLine}{innerException.Message}", "Could Not Complete Transfer", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        ProjectData.ClearProjectError();
      }
      finally
      {
        ((Control) this.panelSearch).Visible = false;
      }
    }
    this.Close();
  }

  private void RefreshPanel(string searchText)
  {
    this.labelSearchText.Text = searchText;
    ((UltraControlBase) this.panelSearch).Refresh();
  }

  private bool UploadDocuments()
  {
    return !string.IsNullOrEmpty(this._UserName) && !string.IsNullOrEmpty(this._Password) && !string.IsNullOrEmpty(this._Url);
  }

  private void OtherService()
  {
    try
    {
      foreach (DocListItem checkedItem in this.lstDocuments.CheckedItems)
      {
        string file = DocumentManager.SaveDocumentToFile(checkedItem.DocumentStoreGuid);
        string[] strArray = file.Split("\\".ToCharArray());
        string str = $"ControlNo{this._controlNo}-{strArray[strArray.Length - 1]}";
        Uri requestUri = new Uri($"{this._Url}/{str}");
        this.RefreshPanel("Uploading " + str);
        byte[] buffer = System.IO.File.ReadAllBytes(file);
        FtpWebRequest ftpWebRequest = (FtpWebRequest) WebRequest.Create(requestUri);
        ftpWebRequest.Method = "STOR";
        ftpWebRequest.Credentials = (ICredentials) new NetworkCredential(this._UserName, this._Password);
        ftpWebRequest.Proxy = (IWebProxy) null;
        ftpWebRequest.KeepAlive = true;
        ftpWebRequest.UseBinary = true;
        ftpWebRequest.ContentLength = (long) buffer.Length;
        ftpWebRequest.Timeout = 5000;
        using (Stream requestStream = ftpWebRequest.GetRequestStream())
          requestStream.Write(buffer, 0, buffer.Length);
        this.RefreshPanel("Please wait. Uploading " + str);
        Thread.Sleep(1000);
        this.RefreshPanel("Please wait. Uploading " + str);
        Thread.Sleep(1000);
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private void LossControlFileUpload()
  {
    string str1 = string.Empty;
    string setting1 = SystemSettings.GetSetting<string>("Inspections.Preferred.LossControl.AttachFileURL", "https://preferred.losscontrol360.com/API/Carrier/V3/AttachFileToCase");
    string setting2 = SystemSettings.GetSetting<string>("Inspections.Preferred.LossControl.AttachFileNameSpace", "http://schemas.datacontract.org/2004/07/LC360API.Carrier_V3");
    if (this._quote.HasPolicyNumber)
      str1 = this._quote.PolicyNumber;
    try
    {
      foreach (DocListItem checkedItem in this.lstDocuments.CheckedItems)
      {
        string file = DocumentManager.SaveDocumentToFile(checkedItem.DocumentStoreGuid);
        string[] strArray = file.Split("\\".ToCharArray());
        string str2 = $"ControlNo {this._controlNo}-{strArray[strArray.Length - 1]}";
        AttachCaseFileRequest o = new AttachCaseFileRequest()
        {
          Password = this._Password,
          UserName = this._UserName,
          CaseNumber = int.MaxValue,
          CollateIntoReport = true,
          FileData = Convert.ToBase64String(System.IO.File.ReadAllBytes(file)),
          FileName = file,
          PolicyNumber = str1,
          ShowToCustomer = true
        };
        this.RefreshPanel($"Uploading file to loss control - {str2}");
        XmlSerializer xmlSerializer = new XmlSerializer(o.GetType(), setting2);
        string str3;
        using (MemoryStream w = new MemoryStream())
        {
          using (XmlTextWriter xmlTextWriter = new XmlTextWriter((Stream) w, Encoding.UTF8))
          {
            xmlTextWriter.Namespaces = true;
            xmlSerializer.Serialize((XmlWriter) xmlTextWriter, (object) o, InspectionRequest.GetNamespaces());
          }
          w.Close();
          str3 = Encoding.UTF8.GetString(w.GetBuffer());
          str3 = str3.Substring(str3.IndexOf(Convert.ToChar(60)));
          str3 = str3.Substring(0, str3.LastIndexOf(Convert.ToChar(62)) + 1);
        }
        HttpWebRequest httpWebRequest = (HttpWebRequest) WebRequest.Create(new Uri(setting1));
        httpWebRequest.Method = "POST";
        httpWebRequest.ContentType = "application/xml; charset=utf-8";
        string empty = string.Empty;
        using (StreamWriter streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
        {
          streamWriter.Write(str3);
          streamWriter.Close();
          using (StreamReader streamReader = new StreamReader(httpWebRequest.GetResponse().GetResponseStream()))
          {
            while (!streamReader.EndOfStream)
              empty += streamReader.ReadLine();
            streamReader.Close();
          }
        }
        this.RefreshPanel("Please wait. Uploading " + str2);
        Thread.Sleep(2000);
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
