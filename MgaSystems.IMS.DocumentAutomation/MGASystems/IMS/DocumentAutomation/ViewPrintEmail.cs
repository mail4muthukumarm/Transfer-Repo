// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.DocumentAutomation.ViewPrintEmail
// Assembly: MgaSystems.IMS.DocumentAutomation, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: B33F9A76-E654-4386-A032-7A12D7CD66DE
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.DocumentAutomation.dll

using Infragistics.Shared;
using Infragistics.Win;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using MGASystems.BusinessObjects;
using MGASystems.Common;
using MGASystems.Common.Email;
using MGASystems.Common.Enums;
using MGASystems.Common.ErrorHandling;
using MGASystems.IMS.NoteDocuments;
using MGASystems.IMS.NoteDocuments.DocumentSystem;
using MGASystems.InfragisticsExtensions.Editors;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.DocumentAutomation;

public class ViewPrintEmail : UserControl
{
  private IContainer components;
  private UltraGrid ug;
  private dsViewPrintEmail ds;
  private SqlDataAdapter da;
  private SqlCommand SqlSelectCommand1;
  private SqlConnection cn;
  private Guid[] _documentStoreGuids;
  private string[] _emailAddresses;
  private HyperlinkEditor _lnkView;
  private HyperlinkEditor _lnkPrint;
  private HyperlinkEditor _lnkEmail;
  private Quote _quote;
  private ViewPrintEmail.Settings _settings;
  private bool _clearAttachment;
  private Lazy<bool> _enforceDeliveryMethod;
  private bool _copyMailToDocTab;
  private bool _usingOutlook;

  private virtual LinkLabel lnkPrintAll
  {
    get => this._lnkPrintAll;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkPrintAll_LinkClicked);
      LinkLabel lnkPrintAll1 = this._lnkPrintAll;
      if (lnkPrintAll1 != null)
        lnkPrintAll1.LinkClicked -= clickedEventHandler;
      this._lnkPrintAll = value;
      LinkLabel lnkPrintAll2 = this._lnkPrintAll;
      if (lnkPrintAll2 == null)
        return;
      lnkPrintAll2.LinkClicked += clickedEventHandler;
    }
  }

  private virtual LinkLabel lnkEmailAll
  {
    get => this._lnkEmailAll;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkEmailAll_LinkClicked);
      LinkLabel lnkEmailAll1 = this._lnkEmailAll;
      if (lnkEmailAll1 != null)
        lnkEmailAll1.LinkClicked -= clickedEventHandler;
      this._lnkEmailAll = value;
      LinkLabel lnkEmailAll2 = this._lnkEmailAll;
      if (lnkEmailAll2 == null)
        return;
      lnkEmailAll2.LinkClicked += clickedEventHandler;
    }
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    Appearance appearance1 = new Appearance();
    UltraGridBand ultraGridBand = new UltraGridBand(nameof (ViewPrintEmail), -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("DocumentStoreGuid");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("Description");
    Appearance appearance2 = new Appearance();
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("View");
    Appearance appearance3 = new Appearance();
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("Print");
    Appearance appearance4 = new Appearance();
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("Email");
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    this.ug = new UltraGrid();
    this.ds = new dsViewPrintEmail();
    this.lnkPrintAll = new LinkLabel();
    this.lnkEmailAll = new LinkLabel();
    this.da = new SqlDataAdapter();
    this.SqlSelectCommand1 = new SqlCommand();
    this.cn = new SqlConnection();
    ((ISupportInitialize) this.ug).BeginInit();
    this.ds.BeginInit();
    this.SuspendLayout();
    ((Control) this.ug).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraGridBase) this.ug).DataSource = (object) this.ds.ViewPrintEmail;
    appearance1.BackColor = Color.White;
    appearance1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.ug).DisplayLayout.Appearance = (AppearanceBase) appearance1;
    ((UltraGridBase) this.ug).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn1.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn1.Width = 146;
    ultraGridColumn2.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn2.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance2).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn2.Header).Appearance = (AppearanceBase) appearance2;
    ultraGridColumn2.Header.VisiblePosition = 1;
    ultraGridColumn2.Width = 266;
    ultraGridColumn3.AutoCompleteMode = (AutoCompleteMode) 2;
    appearance3.FontData.UnderlineAsString = "True";
    appearance3.ForeColor = Color.Blue;
    ((AppearanceBase) appearance3).TextHAlignAsString = "Center";
    ultraGridColumn3.CellAppearance = (AppearanceBase) appearance3;
    ultraGridColumn3.Header.VisiblePosition = 2;
    ultraGridColumn3.Width = 94;
    ultraGridColumn4.AutoCompleteMode = (AutoCompleteMode) 2;
    appearance4.FontData.UnderlineAsString = "True";
    appearance4.ForeColor = Color.Blue;
    ((AppearanceBase) appearance4).TextHAlignAsString = "Center";
    ultraGridColumn4.CellAppearance = (AppearanceBase) appearance4;
    ultraGridColumn4.Header.VisiblePosition = 3;
    ultraGridColumn4.Width = 94;
    ultraGridColumn5.AutoCompleteMode = (AutoCompleteMode) 2;
    appearance5.FontData.UnderlineAsString = "True";
    appearance5.ForeColor = Color.Blue;
    ((AppearanceBase) appearance5).TextHAlignAsString = "Center";
    ultraGridColumn5.CellAppearance = (AppearanceBase) appearance5;
    ultraGridColumn5.Header.VisiblePosition = 4;
    ultraGridColumn5.Width = 96 /*0x60*/;
    ultraGridBand.Columns.AddRange(new object[5]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3,
      (object) ultraGridColumn4,
      (object) ultraGridColumn5
    });
    ((UltraGridBase) this.ug).DisplayLayout.BandsSerializer.Add((object) ultraGridBand);
    ((UltraGridBase) this.ug).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.ug).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.ug).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    appearance6.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ug).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance6;
    appearance7.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.ug).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance7;
    ((UltraGridBase) this.ug).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance8.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.ug).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance8;
    appearance9.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ug).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance9;
    ((UltraGridBase) this.ug).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance10.BackColor = Color.Transparent;
    appearance10.ForeColor = Color.Black;
    ((UltraGridBase) this.ug).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance10;
    scrollBarLook.ViewStyle = (ScrollBarViewStyle) 3;
    ((UltraGridBase) this.ug).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((Control) this.ug).Location = new Point(12, 8);
    ((Control) this.ug).Name = "ug";
    ((Control) this.ug).Size = new Size(552, 120);
    ((Control) this.ug).TabIndex = 0;
    ((UltraControlBase) this.ug).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.ug).UseOsThemes = (DefaultableBoolean) 2;
    this.ds.DataSetName = "dsViewPrintEmail";
    this.ds.Locale = new CultureInfo("en-US");
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.lnkPrintAll.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.lnkPrintAll.Location = new Point(440, 136);
    this.lnkPrintAll.Name = "lnkPrintAll";
    this.lnkPrintAll.Size = new Size(64 /*0x40*/, 16 /*0x10*/);
    this.lnkPrintAll.TabIndex = 1;
    this.lnkPrintAll.TabStop = true;
    this.lnkPrintAll.Text = "Print All";
    this.lnkPrintAll.TextAlign = ContentAlignment.MiddleCenter;
    this.lnkEmailAll.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.lnkEmailAll.Location = new Point(500, 136);
    this.lnkEmailAll.Name = "lnkEmailAll";
    this.lnkEmailAll.Size = new Size(64 /*0x40*/, 16 /*0x10*/);
    this.lnkEmailAll.TabIndex = 2;
    this.lnkEmailAll.TabStop = true;
    this.lnkEmailAll.Text = "Email All";
    this.lnkEmailAll.TextAlign = ContentAlignment.MiddleCenter;
    this.da.SelectCommand = this.SqlSelectCommand1;
    this.da.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblDocumentStore", new DataColumnMapping[1]
      {
        new DataColumnMapping("Description", "Description")
      })
    });
    this.SqlSelectCommand1.CommandText = "SELECT Description, DocumentStoreGUID FROM dbo.tblDocumentStore WHERE (DocumentStoreGUID = @DocumentStoreGuid)";
    this.SqlSelectCommand1.Connection = this.cn;
    this.SqlSelectCommand1.Parameters.AddRange(new SqlParameter[1]
    {
      new SqlParameter("@DocumentStoreGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "DocumentStoreGUID")
    });
    this.cn.ConnectionString = "workstation id=PSARNOWSKI;packet size=4096;integrated security=SSPI;data source=MGASYSTEMS;persist security info=False;initial catalog=IMS";
    this.cn.FireInfoMessageEventOnUserErrors = false;
    this.BackColor = Color.White;
    this.Controls.Add((Control) this.lnkEmailAll);
    this.Controls.Add((Control) this.lnkPrintAll);
    this.Controls.Add((Control) this.ug);
    this.Font = new Font("Tahoma", 8.25f);
    this.Name = nameof (ViewPrintEmail);
    this.Size = new Size(576, 160 /*0xA0*/);
    ((ISupportInitialize) this.ug).EndInit();
    this.ds.EndInit();
    this.ResumeLayout(false);
  }

  public ViewPrintEmail()
  {
    this.Load += new EventHandler(this.ViewPrintEmail_Load);
    this._lnkView = new HyperlinkEditor();
    this._lnkPrint = new HyperlinkEditor();
    this._lnkEmail = new HyperlinkEditor();
    this._settings = new ViewPrintEmail.Settings();
    this._clearAttachment = false;
    this._enforceDeliveryMethod = MGASystems.Common.Settings.SystemSettings.GetLazySetting<bool>("EnforceProducerDeliveryMethod", false, true);
    this._copyMailToDocTab = MGASystems.Common.Settings.SystemSettings.GetSetting<bool>("CopyMailToDocTab");
    this._usingOutlook = CurrentUser.UsingOutlook;
    this.InitializeComponent();
  }

  private void ViewPrintEmail_Load(object sender, EventArgs e)
  {
    if (this.DesignMode)
      return;
    this.cn.ConnectionString = CurrentUser.Instance.ConnectionString;
    this._lnkView.HyperLinkOpening += new CancelEventHandler(this.View);
    this._lnkPrint.HyperLinkOpening += new CancelEventHandler(this.Print);
    this._lnkEmail.HyperLinkOpening += new CancelEventHandler(this.Email);
    UltraGridBand band = ((UltraGridBase) this.ug).DisplayLayout.Bands[0];
    band.Columns["View"].Editor = (EmbeddableEditorBase) this._lnkView;
    band.Columns["Print"].Editor = (EmbeddableEditorBase) this._lnkPrint;
    band.Columns["Email"].Editor = (EmbeddableEditorBase) this._lnkEmail;
    Guid[] documentStoreGuids = this._documentStoreGuids;
    int index = 0;
    while (index < documentStoreGuids.Length)
    {
      this.da.SelectCommand.Parameters["@DocumentStoreGuid"].Value = (object) documentStoreGuids[index];
      this.da.Fill((DataTable) this.ds.ViewPrintEmail);
      checked { ++index; }
    }
    if (this._documentStoreGuids.Length != 0 || this._settings.EmailBodyHTML == null)
      return;
    this.EmailAll();
  }

  private Guid DocumentStoreGuid
  {
    get => (Guid) ((UltraGridBase) this.ug).ActiveRow.Cells[nameof (DocumentStoreGuid)].Value;
  }

  public void Initialize(
    Guid[] documentStoreGuids,
    string[] emailAddresses,
    Quote quote,
    ViewPrintEmail.Settings settings)
  {
    this._documentStoreGuids = documentStoreGuids;
    this._emailAddresses = emailAddresses;
    this._quote = quote;
    this._settings = settings ?? this._settings;
    this.ClearAttachment = false;
  }

  public Guid EventGuid
  {
    get => this._settings.EventGuid;
    set => this._settings.EventGuid = value;
  }

  public string[] CCList
  {
    get => this._settings.CCList;
    set => this._settings.CCList = value;
  }

  public string[] BCCList
  {
    get => this._settings.BCCList;
    set => this._settings.BCCList = value;
  }

  public MemoryStream EmailBodyHTML
  {
    get => this._settings.EmailBodyHTML;
    set => this._settings.EmailBodyHTML = value;
  }

  public Quote ViewPrintEmailQuote => this._quote;

  public bool ClearAttachment
  {
    get => this._clearAttachment;
    set => this._clearAttachment = value;
  }

  public Guid[] SelectedDocumentStoreGuid => this._documentStoreGuids;

  private void View(object sender, CancelEventArgs e)
  {
    try
    {
      e.Cancel = true;
      Cursor.Current = MgaCursors.WaitCursor;
      DocumentManager.BeginViewDocument(this.DocumentStoreGuid);
      Cursor.Current = MgaCursors.Default;
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      ErrorHandler.HandleError(ex);
      ProjectData.ClearProjectError();
    }
  }

  private bool RequirePreferredDelivery(DeliveryMethods method, string preferenceMethod)
  {
    return this._enforceDeliveryMethod.Value && this._quote.ProducerLocation.DeliveryMethod == method && MessageBox.Show($"The Prefered Delivery Method for this Producer is {preferenceMethod}.{"\n"}Do you want to use the Preferred Delivery Method?", $"{preferenceMethod} Preferred", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes;
  }

  private void Print(object sender, CancelEventArgs e)
  {
    try
    {
      e.Cancel = true;
      if (this.RequirePreferredDelivery(DeliveryMethods.Mail, "Email"))
        return;
      Cursor.Current = MgaCursors.WaitCursor;
      DocumentManager.BeginPrintDoc(this.DocumentStoreGuid);
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      ErrorHandler.HandleError(ex);
      ProjectData.ClearProjectError();
    }
    finally
    {
      Cursor.Current = MgaCursors.Default;
    }
  }

  private void Email(object sender, CancelEventArgs e)
  {
    try
    {
      e.Cancel = true;
      if (this.RequirePreferredDelivery(DeliveryMethods.Fax, "Print"))
        return;
      Guid documentStoreGuid = this.DocumentStoreGuid;
      Quote quote = this._quote;
      Form parentForm = this.ParentForm;
      if (parentForm != null)
        parentForm.Visible = false;
      try
      {
        List<Guid> guidList1 = new List<Guid>();
        ((IAddDocumentsService) new AddDocumentsService()).GetDocuments(this._quote, new List<Guid>(), (Action<List<Guid>>) ([SpecialName] (guidList) =>
        {
          if (guidList == null)
            return;
          guidList1 = guidList;
        }));
        guidList1.Add(documentStoreGuid);
        string subject = this.EmailSubject(quote);
        this._settings.CCList = SecondaryProducerContactEmail.SetSecondaryProducerCarbonCopyEmail(quote.QuoteGuid, this._settings.CCList);
        this._settings.BCCList = this.AddMoreBlindCopyAddresses(quote.QuoteGuid, this._settings.BCCList);
        this._settings.CCList = this.AddMoreCarbonCopyAddresses(quote.QuoteGuid, this._settings.CCList);
        this.MassageEmail(documentStoreGuid);
        if (this.ClearAttachment)
          guidList1.Clear();
        if (this._emailAddresses != null && this._emailAddresses.Length > 0)
        {
          if (this._settings.EmailBodyHTML != null)
            this.EmailGeneratedHtmlDocumentStream(guidList1.ToArray(), this._emailAddresses, subject, this._settings.EmailBodyHTML);
          else
            this.EmailGeneratedHtmlDocumentNoStream(guidList1.ToArray(), this._emailAddresses, subject, (MemoryStream) null);
        }
        else if (this._settings.EmailBodyHTML != null)
          DocumentManager.EmailDocumentsWithoutZipping((ISupportDocumentSystem) this._quote, guidList1.ToArray(), (string[]) null, subject, false, this._settings.EmailBodyHTML);
        else
          DocumentManager.EmailDocumentsWithoutZipping((ISupportDocumentSystem) this._quote, guidList1.ToArray(), (string[]) null, subject);
      }
      finally
      {
        parentForm?.Dispose();
      }
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      ErrorHandler.HandleError(ex);
      ProjectData.ClearProjectError();
    }
  }

  private void lnkPrintAll_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    try
    {
      if (this.RequirePreferredDelivery(DeliveryMethods.Mail, "Email"))
        return;
      try
      {
        Guid[] documentStoreGuids = this._documentStoreGuids;
        int index = 0;
        while (index < documentStoreGuids.Length)
        {
          DocumentManager.BeginPrintDoc(documentStoreGuids[index]);
          checked { ++index; }
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ErrorHandler.HandleError(ex);
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

  private void EmailAll()
  {
    try
    {
      if (this.RequirePreferredDelivery(DeliveryMethods.Fax, "Print"))
        return;
      Quote quote = this._quote;
      string subject = this.EmailSubject(quote);
      this._settings.CCList = SecondaryProducerContactEmail.SetSecondaryProducerCarbonCopyEmail(quote.QuoteGuid, this._settings.CCList);
      this._settings.BCCList = this.AddMoreBlindCopyAddresses(quote.QuoteGuid, this._settings.BCCList);
      this._settings.CCList = this.AddMoreCarbonCopyAddresses(quote.QuoteGuid, this._settings.CCList);
      try
      {
        if (this._emailAddresses != null && this._emailAddresses.Length > 0)
        {
          if (this._settings.EmailBodyHTML != null)
            this.EmailGeneratedHtmlDocument(this._documentStoreGuids, this._emailAddresses, subject, this._settings.EmailBodyHTML);
          else
            this.EmailGeneratedDocument(this._documentStoreGuids, this._emailAddresses, subject);
        }
        else if (this._settings.EmailBodyHTML != null)
          DocumentManager.EmailDocumentsWithoutZipping(this._documentStoreGuids, (string[]) null, subject, false, this._settings.EmailBodyHTML);
        else
          DocumentManager.EmailDocumentsWithoutZipping(this._documentStoreGuids);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ErrorHandler.HandleError(ex);
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

  private void lnkEmailAll_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    this.EmailAll();
  }

  protected virtual string EmailSubject(Quote tempQuote)
  {
    string str;
    if (!string.IsNullOrEmpty(this._settings.SubjectOverride))
    {
      str = this._settings.SubjectOverride;
    }
    else
    {
      if (MGASystems.IMS.NoteDocuments.SystemSettings.GetSetting<bool>("DocumentSystem.Email.Subject.Use.PolicyNumber", false) && tempQuote.HasPolicyNumber)
      {
        string policyNumber = tempQuote.PolicyNumber;
        if (!string.IsNullOrEmpty(policyNumber))
        {
          str = $"Policy # {policyNumber} - {tempQuote.InsuredPolicyName}";
          goto label_6;
        }
      }
      str = $"{tempQuote.InsuredPolicyName} - Control # {tempQuote.ControlNo}";
    }
label_6:
    return str;
  }

  protected virtual string[] AddMoreBlindCopyAddresses(Guid quoteGuid, string[] blindCopyList)
  {
    return blindCopyList;
  }

  protected virtual void MassageEmail(Guid tmpDocStoreGuid)
  {
  }

  protected bool CopyMailToDocTab() => this._usingOutlook & this._copyMailToDocTab;

  protected virtual string[] AddMoreCarbonCopyAddresses(Guid quoteGuid, string[] ccList) => ccList;

  protected virtual void EmailGeneratedHtmlDocument(
    Guid[] docStoredGuids,
    string[] toAddress,
    string subject,
    MemoryStream htmlBody)
  {
    if (this.CopyMailToDocTab())
      this.GenerateAndTrackOutlookEmails(docStoredGuids, toAddress, subject, htmlBody);
    else
      DocumentManager.EmailDocumentsWithoutZipping(this._documentStoreGuids, this._emailAddresses, subject, false, this._settings.EmailBodyHTML, this._settings.CCList, this._settings.BCCList);
  }

  protected virtual void EmailGeneratedDocument(
    Guid[] docStoredGuids,
    string[] toAddress,
    string subject)
  {
    if (this.CopyMailToDocTab())
      this.GenerateAndTrackOutlookEmails(docStoredGuids, toAddress, subject, (MemoryStream) null);
    else
      DocumentManager.EmailDocumentsWithoutZipping(this._documentStoreGuids, this._emailAddresses, subject, false, (MemoryStream) null, this._settings.CCList, this._settings.BCCList);
  }

  protected virtual void EmailGeneratedHtmlDocumentStream(
    Guid[] addDocs,
    string[] toAddress,
    string subject,
    MemoryStream htmlBody)
  {
    if (this.CopyMailToDocTab())
      this.GenerateAndTrackOutlookEmails(addDocs, toAddress, subject, htmlBody);
    else
      DocumentManager.EmailDocumentsWithoutZipping((ISupportDocumentSystem) this._quote, addDocs, this._emailAddresses, subject, false, this._settings.EmailBodyHTML, this._settings.CCList, this._settings.BCCList);
  }

  protected virtual void EmailGeneratedHtmlDocumentNoStream(
    Guid[] addDocs,
    string[] toAddress,
    string subject,
    MemoryStream htmlBody)
  {
    if (this.CopyMailToDocTab())
      this.GenerateAndTrackOutlookEmails(addDocs, toAddress, subject, (MemoryStream) null);
    else
      DocumentManager.EmailDocumentsWithoutZipping((ISupportDocumentSystem) this._quote, ((IEnumerable<Guid>) addDocs).ToArray<Guid>(), this._emailAddresses, subject, false, (MemoryStream) null, this._settings.CCList, this._settings.BCCList);
  }

  private void GenerateAndTrackOutlookEmails(
    Guid[] docStoredGuids,
    string[] toAddress,
    string subject,
    MemoryStream htmlBody)
  {
    MessageObject messageObject = new MessageObject();
    messageObject.Subject = subject;
    messageObject.SendOutlook = OutlookSendType.Show;
    string[] strArray = toAddress;
    int index1 = 0;
    while (index1 < strArray.Length)
    {
      string str = strArray[index1];
      messageObject.Recipients.Add(str);
      checked { ++index1; }
    }
    string[] ccList = this.CCList;
    int index2 = 0;
    while (index2 < ccList.Length)
    {
      string str = ccList[index2];
      messageObject.CCRecipients.Add(str);
      checked { ++index2; }
    }
    string[] bccList = this.BCCList;
    int index3 = 0;
    while (index3 < bccList.Length)
    {
      string str = bccList[index3];
      messageObject.BCCRecipients.Add(str);
      checked { ++index3; }
    }
    Guid[] guidArray = docStoredGuids;
    int index4 = 0;
    while (index4 < guidArray.Length)
    {
      Guid documentStoreGuid = guidArray[index4];
      messageObject.FileAttachments.Add(DocumentManager.FetchDocumentByGuid(documentStoreGuid, MGATempFolder.MGATempPath));
      checked { ++index4; }
    }
    string str1 = string.Empty;
    if (htmlBody != null)
    {
      using (MemoryStream memoryStream = new MemoryStream(htmlBody.ToArray()))
      {
        memoryStream.Position = 0L;
        using (StreamReader streamReader = new StreamReader((Stream) memoryStream))
          str1 = streamReader.ReadToEnd();
      }
      messageObject.HTMLBody = str1;
    }
    DocSupportCache docSupportCache = new DocSupportCache((ISupportDocumentSystem) this.ViewPrintEmailQuote);
    messageObject.UserProperties.Clear();
    messageObject.UserProperties.Add((object) "MGASystems.IMS.Email.DocSupport", (object) docSupportCache.ToString());
    int? setting = MGASystems.Common.Settings.SystemSettings.GetSetting<int?>("Outlook.CorrespondenceFolderID");
    if (setting.HasValue)
    {
      int? nullable = setting;
      if ((nullable.HasValue ? new bool?(nullable.GetValueOrDefault() != 0) : new bool?()).GetValueOrDefault())
        messageObject.UserProperties.Add((object) "MGASystems.IMS.Email.DocFolderID", (object) setting);
    }
    this.Client_BeforeSendingEmail(messageObject, docStoredGuids);
    Outlook.Send(messageObject, MGASystems.Common.Settings.SystemSettings.GetSetting<bool>("Outlook.TrackSentEmails", true));
  }

  protected virtual void Client_BeforeSendingEmail(
    MessageObject outlookMessage,
    Guid[] docStoredGuids)
  {
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing)
    {
      if (this.components != null)
        this.components.Dispose();
      this._lnkView.HyperLinkOpening -= new CancelEventHandler(this.View);
      this._lnkPrint.HyperLinkOpening -= new CancelEventHandler(this.Print);
      this._lnkEmail.HyperLinkOpening -= new CancelEventHandler(this.Email);
      ((DisposableObject) this._lnkView).Dispose();
      ((DisposableObject) this._lnkPrint).Dispose();
      ((DisposableObject) this._lnkEmail).Dispose();
      this._settings.EmailBodyHTML = (MemoryStream) null;
    }
    base.Dispose(disposing);
  }

  public class Settings
  {
    private MemoryStream _emailBodyHTML;
    private string[] _ccList;
    private string[] _bcList;
    private Guid _eventGuid;
    private string _subjectOverride;

    public Settings()
    {
      this._ccList = new string[0];
      this._bcList = new string[0];
      this._subjectOverride = (string) null;
    }

    public MemoryStream EmailBodyHTML
    {
      get => this._emailBodyHTML;
      set => this._emailBodyHTML = value;
    }

    public string[] CCList
    {
      get => this._ccList;
      set => this._ccList = value;
    }

    public string[] BCCList
    {
      get => this._bcList;
      set => this._bcList = value;
    }

    public Guid EventGuid
    {
      get => this._eventGuid;
      set => this._eventGuid = value;
    }

    public string SubjectOverride
    {
      get => this._subjectOverride;
      set => this._subjectOverride = value;
    }
  }
}
