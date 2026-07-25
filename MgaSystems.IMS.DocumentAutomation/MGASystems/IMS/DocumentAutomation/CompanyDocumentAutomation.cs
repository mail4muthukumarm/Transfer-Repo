// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.DocumentAutomation.CompanyDocumentAutomation
// Assembly: MgaSystems.IMS.DocumentAutomation, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: B33F9A76-E654-4386-A032-7A12D7CD66DE
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.DocumentAutomation.dll

using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.Export.Pdf.Section;
using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinProgressBar;
using MGASystems.AsposeFacade.Cells;
using MGASystems.AsposeFacade.PDF;
using MGASystems.AsposeFacade.Words;
using MGASystems.BusinessObjects;
using MGASystems.Common;
using MGASystems.Common.BroadcastMessaging;
using MGASystems.Common.Enums;
using MGASystems.Common.ErrorHandling;
using MGASystems.Common.FileIO;
using MGASystems.Data;
using MGASystems.IMS.DocumentAutomation.My;
using MGASystems.IMS.DocumentAutomation.TemplateDocuments;
using MGASystems.IMS.NoteDocuments;
using MGASystems.IMS.NoteDocuments.DocumentSystem;
using MGASystems.IMS.NoteDocuments.Email;
using MGASystems.IMS.Reporting;
using MGASystems.IMS.Reporting.AutomationReports;
using MGASystems.IMS.Reporting.GenericReport;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Threading;
using System.Web;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

#nullable disable
namespace MGASystems.IMS.DocumentAutomation;

public class CompanyDocumentAutomation : IDisposable
{
  private bool _carbonCopyInhouseProducer;
  private Messaging.MessageEventArgs _event;
  private Quote _quote;
  private Guid _quoteGuid;
  private object _eventContext;
  private Guid? _eventOverride;
  private Guid _companyLineGuid;
  private int _invoiceNum;
  private Guid _insuredLocationGuid;
  private Guid _submissionGroupGuid;
  private PDFPackage _package;
  private bool _includeFormsScheduleTemplates;
  protected string _documentName;
  private int _printTypeID;
  private List<AutomationDoc> _automationDocs;
  private Dictionary<int, CompanyDocumentAutomation.TemplateDoc> _tempDocs;
  private ViewPrintEmail.Settings _vpeSettings;
  private bool _policyPreview;
  private int _policyFormCount;
  private frmPleaseWaitNoProgress _frmInitialPleaseWait;
  private bool _emailBodySet;
  private int _policyFormId;
  private Guid _automationRptGuid;
  private string _FileName;
  private string _FileDescription;
  private bool _CloseAfterModifyTemplates;
  private Dictionary<int, (CompanyLine CompanyLine, int FormOrderIncrease)> _companyLineOrder;
  private List<Guid> _quoteOptionGuids;
  private Dictionary<int, Guid> _documentStoreGuids;
  private List<CompanyDocumentAutomation.NativeDocument> _nativeDocuments;
  private static frmPleaseWait _frmPleaseWait;
  private static Dictionary<int, string> _temporaryDocsCache = new Dictionary<int, string>();
  private static Dictionary<int, string> _templateNames = new Dictionary<int, string>();
  private string _resultingDocument;
  private byte[] _resultingBytes;
  private Guid? _resultingDocumentStoreGuid;
  private Exception _createPDFException;
  private static bool _viewPrintEmailFormEnabled = true;
  private static bool _blackBoxMode = false;
  private static bool _sendToDocumentSystem = true;
  private static Dictionary<int, bool> _sendToDocPrintTypes;
  private static Size _frmPleaseWaitOriginalSize;

  static CompanyDocumentAutomation() => CompanyDocumentAutomation.SortDocuments = true;

  protected List<AutomationDoc> AutomationDocs => this._automationDocs;

  protected Dictionary<int, (CompanyLine CompanyLine, int FormOrderIncrease)> CompanyLineOrder
  {
    get => this._companyLineOrder;
  }

  public ReadOnlyCollection<CompanyDocumentAutomation.NativeDocument> NativeDocuments
  {
    get => this._nativeDocuments.AsReadOnly();
  }

  protected object EventContext
  {
    get => this._eventContext;
    set => this._eventContext = RuntimeHelpers.GetObjectValue(value);
  }

  protected Messaging.MessageEventArgs MessageEvent => this._event;

  protected Guid? EventOverride
  {
    get => this._eventOverride;
    set => this._eventOverride = value;
  }

  protected bool CarbonCopyInhouseProducer
  {
    get => this._carbonCopyInhouseProducer;
    set => this._carbonCopyInhouseProducer = value;
  }

  public CompanyDocumentAutomation(byte[] pdf, string fileName)
  {
    this._carbonCopyInhouseProducer = false;
    this._invoiceNum = -1;
    this._package = new PDFPackage();
    this._documentName = string.Empty;
    this._printTypeID = -1;
    this._automationDocs = new List<AutomationDoc>();
    this._tempDocs = new Dictionary<int, CompanyDocumentAutomation.TemplateDoc>();
    this._vpeSettings = new ViewPrintEmail.Settings();
    this._emailBodySet = false;
    this._policyFormId = -1;
    this._FileName = string.Empty;
    this._FileDescription = string.Empty;
    this._CloseAfterModifyTemplates = false;
    this._companyLineOrder = new Dictionary<int, (CompanyLine, int)>();
    this._quoteOptionGuids = new List<Guid>();
    this._documentStoreGuids = new Dictionary<int, Guid>();
    this._nativeDocuments = new List<CompanyDocumentAutomation.NativeDocument>();
    this._createPDFException = (Exception) null;
    this._automationDocs.Add(AutomationDoc.Create((object) new MemoryStream(pdf), (object) 0, (object) -1));
  }

  public CompanyDocumentAutomation(Guid automationReportGuid)
    : this(automationReportGuid, -1)
  {
  }

  public CompanyDocumentAutomation(Guid automationReportGuid, int placedByCompanyLineID)
  {
    this._carbonCopyInhouseProducer = false;
    this._invoiceNum = -1;
    this._package = new PDFPackage();
    this._documentName = string.Empty;
    this._printTypeID = -1;
    this._automationDocs = new List<AutomationDoc>();
    this._tempDocs = new Dictionary<int, CompanyDocumentAutomation.TemplateDoc>();
    this._vpeSettings = new ViewPrintEmail.Settings();
    this._emailBodySet = false;
    this._policyFormId = -1;
    this._FileName = string.Empty;
    this._FileDescription = string.Empty;
    this._CloseAfterModifyTemplates = false;
    this._companyLineOrder = new Dictionary<int, (CompanyLine, int)>();
    this._quoteOptionGuids = new List<Guid>();
    this._documentStoreGuids = new Dictionary<int, Guid>();
    this._nativeDocuments = new List<CompanyDocumentAutomation.NativeDocument>();
    this._createPDFException = (Exception) null;
    this._automationDocs.Add(AutomationDoc.Create((object) automationReportGuid, (object) 0, (object) -1, (object) placedByCompanyLineID));
  }

  public CompanyDocumentAutomation(int templateID)
    : this(templateID, -1)
  {
  }

  public CompanyDocumentAutomation(int templateID, int placedByCompanyLineID)
  {
    this._carbonCopyInhouseProducer = false;
    this._invoiceNum = -1;
    this._package = new PDFPackage();
    this._documentName = string.Empty;
    this._printTypeID = -1;
    this._automationDocs = new List<AutomationDoc>();
    this._tempDocs = new Dictionary<int, CompanyDocumentAutomation.TemplateDoc>();
    this._vpeSettings = new ViewPrintEmail.Settings();
    this._emailBodySet = false;
    this._policyFormId = -1;
    this._FileName = string.Empty;
    this._FileDescription = string.Empty;
    this._CloseAfterModifyTemplates = false;
    this._companyLineOrder = new Dictionary<int, (CompanyLine, int)>();
    this._quoteOptionGuids = new List<Guid>();
    this._documentStoreGuids = new Dictionary<int, Guid>();
    this._nativeDocuments = new List<CompanyDocumentAutomation.NativeDocument>();
    this._createPDFException = (Exception) null;
    this._automationDocs.Add(AutomationDoc.Create((object) templateID, (object) 0, (object) -1, (object) placedByCompanyLineID));
  }

  public CompanyDocumentAutomation(int templateID, int placedByCompanyLineID, int policyFormID)
  {
    this._carbonCopyInhouseProducer = false;
    this._invoiceNum = -1;
    this._package = new PDFPackage();
    this._documentName = string.Empty;
    this._printTypeID = -1;
    this._automationDocs = new List<AutomationDoc>();
    this._tempDocs = new Dictionary<int, CompanyDocumentAutomation.TemplateDoc>();
    this._vpeSettings = new ViewPrintEmail.Settings();
    this._emailBodySet = false;
    this._policyFormId = -1;
    this._FileName = string.Empty;
    this._FileDescription = string.Empty;
    this._CloseAfterModifyTemplates = false;
    this._companyLineOrder = new Dictionary<int, (CompanyLine, int)>();
    this._quoteOptionGuids = new List<Guid>();
    this._documentStoreGuids = new Dictionary<int, Guid>();
    this._nativeDocuments = new List<CompanyDocumentAutomation.NativeDocument>();
    this._createPDFException = (Exception) null;
    this._automationDocs.Add(AutomationDoc.Create((object) templateID, (object) 0, (object) -1, (object) placedByCompanyLineID, (object) policyFormID));
  }

  public CompanyDocumentAutomation(
    int templateID,
    int placedByCompanyLineID,
    int policyFormID,
    string oncePer)
  {
    this._carbonCopyInhouseProducer = false;
    this._invoiceNum = -1;
    this._package = new PDFPackage();
    this._documentName = string.Empty;
    this._printTypeID = -1;
    this._automationDocs = new List<AutomationDoc>();
    this._tempDocs = new Dictionary<int, CompanyDocumentAutomation.TemplateDoc>();
    this._vpeSettings = new ViewPrintEmail.Settings();
    this._emailBodySet = false;
    this._policyFormId = -1;
    this._FileName = string.Empty;
    this._FileDescription = string.Empty;
    this._CloseAfterModifyTemplates = false;
    this._companyLineOrder = new Dictionary<int, (CompanyLine, int)>();
    this._quoteOptionGuids = new List<Guid>();
    this._documentStoreGuids = new Dictionary<int, Guid>();
    this._nativeDocuments = new List<CompanyDocumentAutomation.NativeDocument>();
    this._createPDFException = (Exception) null;
    this._automationDocs.Add(AutomationDoc.Create((object) templateID, (object) 0, (object) -1, (object) placedByCompanyLineID, (object) oncePer, (object) policyFormID));
  }

  public CompanyDocumentAutomation(Guid companyLineGuid, Messaging.MessageEventArgs e)
    : this(companyLineGuid, e, -1)
  {
  }

  public CompanyDocumentAutomation(
    Guid companyLineGuid,
    Messaging.MessageEventArgs e,
    int printTypeID)
  {
    this._carbonCopyInhouseProducer = false;
    this._invoiceNum = -1;
    this._package = new PDFPackage();
    this._documentName = string.Empty;
    this._printTypeID = -1;
    this._automationDocs = new List<AutomationDoc>();
    this._tempDocs = new Dictionary<int, CompanyDocumentAutomation.TemplateDoc>();
    this._vpeSettings = new ViewPrintEmail.Settings();
    this._emailBodySet = false;
    this._policyFormId = -1;
    this._FileName = string.Empty;
    this._FileDescription = string.Empty;
    this._CloseAfterModifyTemplates = false;
    this._companyLineOrder = new Dictionary<int, (CompanyLine, int)>();
    this._quoteOptionGuids = new List<Guid>();
    this._documentStoreGuids = new Dictionary<int, Guid>();
    this._nativeDocuments = new List<CompanyDocumentAutomation.NativeDocument>();
    this._createPDFException = (Exception) null;
    this._companyLineGuid = companyLineGuid;
    this._event = e;
    this._printTypeID = printTypeID;
  }

  public CompanyDocumentAutomation(AutomationDoc singleDoc)
  {
    this._carbonCopyInhouseProducer = false;
    this._invoiceNum = -1;
    this._package = new PDFPackage();
    this._documentName = string.Empty;
    this._printTypeID = -1;
    this._automationDocs = new List<AutomationDoc>();
    this._tempDocs = new Dictionary<int, CompanyDocumentAutomation.TemplateDoc>();
    this._vpeSettings = new ViewPrintEmail.Settings();
    this._emailBodySet = false;
    this._policyFormId = -1;
    this._FileName = string.Empty;
    this._FileDescription = string.Empty;
    this._CloseAfterModifyTemplates = false;
    this._companyLineOrder = new Dictionary<int, (CompanyLine, int)>();
    this._quoteOptionGuids = new List<Guid>();
    this._documentStoreGuids = new Dictionary<int, Guid>();
    this._nativeDocuments = new List<CompanyDocumentAutomation.NativeDocument>();
    this._createPDFException = (Exception) null;
    this._automationDocs.Add(singleDoc);
  }

  public string ResultingDocument => this._resultingDocument;

  public byte[] ResultingBytes => this._resultingBytes;

  public Guid? ResultingDocumentStoreGuid => this._resultingDocumentStoreGuid;

  public bool PolicyPreview
  {
    get => this._policyPreview;
    set
    {
      if (value && !this.EventGuid.Equals(BroadcastMessages.PolicyPreviewed))
        throw new InvalidOperationException("The PolicyPreview property can only be set for the PolicyPreviewed system event!");
      this._policyPreview = value;
    }
  }

  public Guid SubmissionGroupGuid
  {
    get => this._submissionGroupGuid;
    set => this._submissionGroupGuid = value;
  }

  public Guid InsuredLocationGuid
  {
    get => this._insuredLocationGuid;
    set => this._insuredLocationGuid = value;
  }

  public int InvoiceNum
  {
    get => this._invoiceNum;
    set => this._invoiceNum = value;
  }

  public Guid QuoteGuid
  {
    get => this._quoteGuid;
    set
    {
      this._quoteGuid = value;
      this._quote = new Quote(value);
    }
  }

  public Quote Quote
  {
    get
    {
      if (this._quote == null && !this._quoteGuid.Equals(Guid.Empty))
        this._quote = new Quote(this._quoteGuid);
      return this._quote;
    }
  }

  public Guid CompanyLineGuid => this._companyLineGuid;

  public int PolicyFormId
  {
    get => this._policyFormId;
    set => this._policyFormId = value;
  }

  public bool IncludeFormsScheduleTemplates
  {
    get => this._includeFormsScheduleTemplates;
    set => this._includeFormsScheduleTemplates = value;
  }

  public Guid EventGuid
  {
    get
    {
      Guid? eventOverride;
      return ((eventOverride = this.EventOverride).HasValue ? eventOverride : this._event?.EventGuid) ?? Guid.Empty;
    }
  }

  public ViewPrintEmail.Settings ViewPrintEmailSettings => this._vpeSettings;

  public Exception CreatePDFException => this._createPDFException;

  public Guid AutomationRptGuid
  {
    get => this._automationRptGuid;
    set => this._automationRptGuid = value;
  }

  public string FileNameSaveAs
  {
    get => this._FileName;
    set => this._FileName = value;
  }

  public string FileDescriptionSaveAs
  {
    get => this._FileDescription;
    set => this._FileDescription = value;
  }

  public bool CloseAfterModifyingTemplates
  {
    get => this._CloseAfterModifyTemplates;
    set => this._CloseAfterModifyTemplates = value;
  }

  protected Dictionary<int, Guid> DocumentStoreGuids => this._documentStoreGuids;

  protected int PolicyFormCount => this._policyFormCount;

  protected int AutomationDocCount => this._automationDocs.Count;

  protected string DocumentName => this._documentName;

  public static bool ViewPrintEmailFormEnabled
  {
    get => CompanyDocumentAutomation._viewPrintEmailFormEnabled;
    set => CompanyDocumentAutomation._viewPrintEmailFormEnabled = value;
  }

  public static bool SendToDocumentSystem
  {
    get => CompanyDocumentAutomation._sendToDocumentSystem;
    set => CompanyDocumentAutomation._sendToDocumentSystem = value;
  }

  public static bool BlackBoxMode
  {
    get
    {
      bool flag = HttpContext.Current != null;
      return CompanyDocumentAutomation._blackBoxMode || flag;
    }
    set => CompanyDocumentAutomation._blackBoxMode = value;
  }

  public static bool SortDocuments { get; set; }

  public static Dictionary<int, bool> SendToDocumentHandlerPrintTypes
  {
    get
    {
      if (CompanyDocumentAutomation._sendToDocPrintTypes == null)
      {
        try
        {
          EnumerableRowCollection<DataRow> source = DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT PrintTypeID, SendToDocSystem FROM dbo.lstPolicyPrintTypes WITH(NOLOCK)").AsEnumerable();
          System.Func<DataRow, int> keySelector;
          if (CompanyDocumentAutomation._Closure\u0024__.\u0024I142\u002D0 != null)
            keySelector = CompanyDocumentAutomation._Closure\u0024__.\u0024I142\u002D0;
          else
            CompanyDocumentAutomation._Closure\u0024__.\u0024I142\u002D0 = keySelector = (System.Func<DataRow, int>) ([SpecialName] (ptdr) => (int) ptdr.Field<byte>("PrintTypeID"));
          System.Func<DataRow, bool> elementSelector;
          if (CompanyDocumentAutomation._Closure\u0024__.\u0024I142\u002D1 != null)
            elementSelector = CompanyDocumentAutomation._Closure\u0024__.\u0024I142\u002D1;
          else
            CompanyDocumentAutomation._Closure\u0024__.\u0024I142\u002D1 = elementSelector = (System.Func<DataRow, bool>) ([SpecialName] (ptdr) => ptdr.Field<bool>("SendToDocSystem"));
          CompanyDocumentAutomation._sendToDocPrintTypes = source.ToDictionary<DataRow, int, bool>(keySelector, elementSelector);
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ErrorHandler.SilentLogError(ex);
          CompanyDocumentAutomation._sendToDocPrintTypes = new Dictionary<int, bool>();
          ProjectData.ClearProjectError();
        }
      }
      return CompanyDocumentAutomation._sendToDocPrintTypes;
    }
  }

  public virtual void SetEventContext(object context)
  {
    this._eventContext = RuntimeHelpers.GetObjectValue(context);
  }

  private bool IsPrintingQuote()
  {
    return this.EventGuid.Equals(BroadcastMessages.QuotePrinted) || this.EventGuid.Equals(BroadcastMessages.RenewalQuotePrinted);
  }

  private void AddPdfSecurity(string fileName)
  {
    if (!MGASystems.IMS.NoteDocuments.SystemSettings.GetSetting<bool>("SecurePDFs", false))
      return;
    string path = $"{fileName}.orig";
    if (File.Exists(path))
      File.Delete(path);
    string str = path.Replace(";", string.Empty);
    if (MyProject.Computer.FileSystem.FileExists(str))
      MyProject.Computer.FileSystem.DeleteFile(str);
    MyProject.Computer.FileSystem.RenameFile(fileName, Path.GetFileName(str));
    new PdfFileSecurity(str, fileName).SetPrivilegeForbidAllButPrint(MGASystems.IMS.NoteDocuments.SystemSettings.GetSetting<string>("SecurePDFs", ""));
  }

  private void AddPageNumbers(string fileName)
  {
    if (!MGASystems.IMS.NoteDocuments.SystemSettings.GetSetting<bool>(nameof (AddPageNumbers), false))
      return;
    string path = $"{fileName}.orig";
    if (File.Exists(path))
      File.Delete(path);
    MyProject.Computer.FileSystem.RenameFile(fileName, Path.GetFileName(path));
    PdfFileStamp pdfFileStamp = new PdfFileStamp(path, fileName);
    pdfFileStamp.AddPageNumber(new FormattedText("Page #", Color.Black, (FontStyle) 14, (EncodingType) 5, false, 12));
    pdfFileStamp.Close();
  }

  public virtual void PackageCompleted(string fileName)
  {
    try
    {
      this._resultingDocument = fileName;
      this.AddPdfSecurity(fileName);
      this.AddPageNumbers(fileName);
      if (CompanyDocumentAutomation.BlackBoxMode)
      {
        if (!CompanyDocumentAutomation.IsQuoteLevelMessage(this.EventGuid))
          return;
        if (this.EventGuid.Equals(BroadcastMessages.PolicyPreviewed) && this.PolicyPreview)
          this.WatermarkPolicy(fileName);
        if (!CompanyDocumentAutomation.SendToDocumentSystem)
          return;
        this._resultingDocumentStoreGuid = new Guid?(this.SendQuoteDocToDocSystem(this._quote.QuoteGuid, fileName, this.EventGuid));
      }
      else
      {
        if (CompanyDocumentAutomation.IsQuoteLevelMessage(this.EventGuid))
        {
          if (this.EventGuid.Equals(BroadcastMessages.PolicyPreviewed) && this.PolicyPreview)
          {
            this.WatermarkPolicy(fileName);
            Process.Start(fileName);
          }
          else
          {
            this.SetProgressText("Sending document to document handler...");
            Guid docSystem;
            if (CompanyDocumentAutomation.SendToDocumentSystem)
              docSystem = this.SendQuoteDocToDocSystem(this._quote.QuoteGuid, fileName, this.EventGuid);
            this.EmailDocument(fileName);
            if (this.IsPrintingQuote())
            {
              if (this._quoteOptionGuids.Count > 0)
              {
                Guid guid = Guid.NewGuid();
                DateTime now = DateAndTime.Now;
                try
                {
                  foreach (Guid quoteOptionGuid in this._quoteOptionGuids)
                    DefaultDatabase.ExecuteNonQuery(CommandType.Text, "INSERT INTO dbo.tblQuotesPrinted(QuotePackageGuid, QuoteOptionGuid, DatePrinted, PrintedByUserID) VALUES(@quotePackageGuid, @quoteOptionGuid, @datePrinted, @printedByUserID)", new object[8]
                    {
                      (object) "@quotePackageGuid",
                      (object) guid,
                      (object) "@quoteOptionGuid",
                      (object) quoteOptionGuid,
                      (object) "@datePrinted",
                      (object) now,
                      (object) "@printedByUserID",
                      (object) CurrentUser.Instance.UserID
                    });
                }
                finally
                {
                  List<Guid>.Enumerator enumerator;
                  enumerator.Dispose();
                }
              }
              if (this.Quote.QuoteStatus == QuoteStatus.Submitted)
                this.Quote.QuoteStatus = QuoteStatus.Quoted;
              DefaultDatabase.ExecuteNonQuery("dbo.MarkMultiGenericRaterOptionsBoundAndQuote", new object[2]
              {
                (object) "@QuoteGuid",
                (object) this._quoteGuid
              });
            }
            if (!docSystem.Equals(Guid.Empty))
            {
              this._resultingDocumentStoreGuid = new Guid?(docSystem);
              if (this._printTypeID == -1 && this._documentStoreGuids.ContainsKey(this._printTypeID))
              {
                // ISSUE: variable of a reference type
                int& local;
                // ISSUE: explicit reference operation
                int num = ^(local = ref this._printTypeID) - 1;
                local = num;
              }
              if (!this._documentStoreGuids.ContainsKey(this._printTypeID))
                this._documentStoreGuids.Add(this._printTypeID, docSystem);
              if (this.IsPrintingQuote())
                this.SendQuoteDocumentCreatedBroadcast(fileName, docSystem);
              this.SaveCompletePackageClient(fileName);
            }
            else
            {
              this.SendQuoteDocumentCreatedBroadcast(fileName);
              if (CompanyDocumentAutomation.SendToDocumentSystem && File.Exists(fileName))
              {
                this.SetProgressText("Launching PDF viewer...");
                Process.Start(fileName);
                this.HidePleaseWaitForm();
              }
            }
          }
        }
        else
        {
          this.SetProgressText("Launching PDF viewer...");
          Process.Start(fileName);
          this.HidePleaseWaitForm();
        }
        MDIControls.Instance.MDIParent.Invoke((Delegate) new MethodInvoker(this.AllPDFsCreated));
      }
    }
    catch (Win32Exception ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      // ISSUE: variable of a compiler-generated type
      CompanyDocumentAutomation._Closure\u0024__147\u002D0 closure1470_1;
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      CompanyDocumentAutomation._Closure\u0024__147\u002D0 closure1470_2 = new CompanyDocumentAutomation._Closure\u0024__147\u002D0(closure1470_1);
      // ISSUE: reference to a compiler-generated field
      closure1470_2.\u0024VB\u0024Local_win32Exception = ex;
      if (!CompanyDocumentAutomation.BlackBoxMode)
      {
        // ISSUE: reference to a compiler-generated method
        MDIControls.Instance.MDIParent.Invoke((Delegate) new MethodInvoker(closure1470_2._Lambda\u0024__0));
      }
      // ISSUE: reference to a compiler-generated field
      ErrorHandler.SilentHandleError((Exception) closure1470_2.\u0024VB\u0024Local_win32Exception);
      ProjectData.ClearProjectError();
    }
    finally
    {
      if (!CompanyDocumentAutomation.BlackBoxMode)
        MDIControls.Instance.MDIParent.Invoke((Delegate) new MethodInvoker(this.ClosePleaseWaitForm));
      SMTP_Email.SuppressDialog = false;
    }
  }

  public virtual void SaveFileSeparateClient(
    Document nativeWordDocument,
    AutomationDoc automationDoc,
    MemoryStream pdfStrem)
  {
  }

  public virtual void SaveCompletePackageClient(string fileName)
  {
  }

  private void SendQuoteDocumentCreatedBroadcast(string fileName)
  {
    this.SendQuoteDocumentCreatedBroadcast(fileName, Guid.Empty);
  }

  private void SendQuoteDocumentCreatedBroadcast(string fileName, Guid documentStoreGuid)
  {
    Messaging.SendBroadcastMessage(BroadcastMessages.QuoteDocumentCreated, (object) new ArrayList()
    {
      (object) this.QuoteGuid,
      (object) fileName,
      (object) documentStoreGuid
    });
  }

  private void ClosePleaseWaitForm()
  {
    if (CompanyDocumentAutomation._frmPleaseWait == null || CompanyDocumentAutomation._frmPleaseWait.IsDisposed)
      return;
    CompanyDocumentAutomation._frmPleaseWait.Close();
    CompanyDocumentAutomation._frmPleaseWait.Dispose();
    CompanyDocumentAutomation._frmPleaseWait = (frmPleaseWait) null;
  }

  protected virtual void EmailDocument(string fileName)
  {
    try
    {
      DataRow row1 = DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT * FROM dbo.tblDocumentEmailAutomation WITH(NOLOCK) WHERE CompanyLineGuid = @companyLineGuid AND AutomationEventGuid = @AutomationEventGuid", new object[4]
      {
        (object) "@companyLineGuid",
        (object) this._companyLineGuid,
        (object) "@AutomationEventGuid",
        (object) this.EventGuid
      }).AsEnumerable().FirstOrDefault<DataRow>();
      if (row1 == null)
        return;
      List<string> ccList = new List<string>();
      string address = CurrentUser.Instance.Email.Address;
      if (string.IsNullOrEmpty(address))
      {
        if (CompanyDocumentAutomation.BlackBoxMode || SMTP_Email.SuppressDialog)
          return;
        MGASystems.Common.ThreadingFunctions.MessageBox.Show("An email could not be sent at this time.\n\nPlease make sure that you have set up a valid email address.", "Missing Email Address", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      }
      else
      {
        try
        {
          if (row1.Field<bool>("ProducerContact"))
          {
            string str = DefaultDatabase.ExecuteScalar<string>("dbo.spProducerContactEmailGet", new object[2]
            {
              (object) "@QuoteGuid",
              (object) this.QuoteGuid
            });
            if (!string.IsNullOrEmpty(str))
              ccList.Add(str);
          }
          if (row1.Field<bool>("CompanyContact"))
          {
            DataTable dataTable = DefaultDatabase.ExecuteDataTable("dbo.spCompanyContactEmailGet", new object[2]
            {
              (object) "@QuoteGuid",
              (object) this.QuoteGuid
            });
            try
            {
              foreach (DataRow row2 in dataTable.Rows)
              {
                if (!string.IsNullOrEmpty(row2.Field<string>("Email")))
                  ccList.Add(row2.Field<string>("Email"));
              }
            }
            finally
            {
              IEnumerator enumerator;
              if (enumerator is IDisposable)
                (enumerator as IDisposable).Dispose();
            }
          }
          if (row1.Field<bool>("InsuredContact"))
          {
            DataTable dataTable = DefaultDatabase.ExecuteDataTable("dbo.spInsuredContactEmailGet", new object[2]
            {
              (object) "@SubmissionGroupGUID",
              (object) this.Quote.SubmissionGroupGuid
            });
            try
            {
              foreach (DataRow row3 in dataTable.Rows)
              {
                if (!string.IsNullOrEmpty(row3.Field<string>("Email")))
                  ccList.Add(row3.Field<string>("Email"));
              }
            }
            finally
            {
              IEnumerator enumerator;
              if (enumerator is IDisposable)
                (enumerator as IDisposable).Dispose();
            }
          }
          if (row1.Field<bool>("ProducerCSR") || MGASystems.IMS.NoteDocuments.SystemSettings.GetSetting<bool>("ccGlobalSecondaryProducerContact", false))
          {
            string str = DefaultDatabase.ExecuteScalar<string>("dbo.spGetSecProducerContactEmail_CC", new object[2]
            {
              (object) "@QuoteGuid",
              (object) this.QuoteGuid
            });
            if (!string.IsNullOrEmpty(str))
              ccList.Add(str);
          }
          string subject = this.DocumentAutomationEmailSubject();
          string empty = string.Empty;
          if (row1["Body"] != DBNull.Value)
            empty = (string) row1["Body"];
          Attachment[] attachments = new Attachment[1]
          {
            new Attachment(fileName)
          };
          if (MGASystems.IMS.NoteDocuments.SystemSettings.GetSetting<bool>("PromptDocumentEmailAutomation", false))
            UI.Send(new string[1]{ fileName }, ccList.ToArray(), subject, (string[]) null, empty);
          else
            SMTP_Email.SendMail(address, address, ccList, subject, empty, attachments, false);
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          if (!CompanyDocumentAutomation.BlackBoxMode && !SMTP_Email.SuppressDialog)
            MGASystems.Common.ThreadingFunctions.MessageBox.Show("An email could not be sent at this time.\n\nYou do not have valid mail server settings.", "Missing Mail Server Settings", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
          ProjectData.ClearProjectError();
        }
      }
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      ErrorHandler.HandleError(ex);
      ProjectData.ClearProjectError();
    }
  }

  protected virtual string DocumentAutomationEmailSubject()
  {
    return $"{this._quote.InsuredPolicyName} - Policy# {this._quote.PolicyNumber}";
  }

  public virtual object GetConstructorArgument(int automationDocGroup)
  {
    object constructorArgument;
    switch ((MGASystems.IMS.Reporting.AutomationReports.Enums.AutomationDocGroups) Enum.Parse(typeof (MGASystems.IMS.Reporting.AutomationReports.Enums.AutomationDocGroups), automationDocGroup.ToString()))
    {
      case MGASystems.IMS.Reporting.AutomationReports.Enums.AutomationDocGroups.PolicyDoc:
        constructorArgument = !this.QuoteGuid.Equals(Guid.Empty) ? (object) this.QuoteGuid : throw new InvalidOperationException("Could not instantiate the automation report because the QuoteGuid property was not set.");
        break;
      case MGASystems.IMS.Reporting.AutomationReports.Enums.AutomationDocGroups.InvoiceDoc:
        constructorArgument = this.InvoiceNum != -1 ? (object) this.InvoiceNum : throw new InvalidOperationException("Could not instantiate the automation report because the InvoiceNum property was not set.");
        break;
      case MGASystems.IMS.Reporting.AutomationReports.Enums.AutomationDocGroups.SubmissionDoc:
        if (this.SubmissionGroupGuid.Equals(Guid.Empty))
        {
          if (!this.QuoteGuid.Equals(Guid.Empty))
          {
            this.SubmissionGroupGuid = new Quote(this.QuoteGuid).SubmissionGroupGuid;
          }
          else
          {
            if (this.InvoiceNum == -1)
              throw new InvalidOperationException("Could not instantiate the automation report because the SubmissionGroupGuid property was not set.");
            this.SubmissionGroupGuid = new Invoice(this.InvoiceNum).Quote.SubmissionGroupGuid;
          }
        }
        constructorArgument = (object) this.SubmissionGroupGuid;
        break;
      case MGASystems.IMS.Reporting.AutomationReports.Enums.AutomationDocGroups.InsuredLocationDoc:
        if (this.InsuredLocationGuid.Equals(Guid.Empty))
        {
          if (!this.QuoteGuid.Equals(Guid.Empty))
            this.InsuredLocationGuid = new Quote(this.QuoteGuid).SubmissionGroup.InsuredLocationGuid;
          else
            this.InsuredLocationGuid = !this.SubmissionGroupGuid.Equals(Guid.Empty) ? new SubmissionGroup(this.SubmissionGroupGuid).InsuredLocationGuid : throw new InvalidOperationException("Could not instantiate the automation report because the InsuredLocationGuid property was not set.");
        }
        constructorArgument = (object) this.InsuredLocationGuid;
        break;
      default:
        constructorArgument = (object) null;
        break;
    }
    return constructorArgument;
  }

  public void ShowInitialPleaseWaitForm()
  {
    if (CompanyDocumentAutomation.BlackBoxMode || MDIControls.Instance.MDIParent.InvokeRequired)
      return;
    if (this._frmInitialPleaseWait == null)
    {
      frmPleaseWaitNoProgress pleaseWaitNoProgress = new frmPleaseWaitNoProgress();
      pleaseWaitNoProgress.StartPosition = FormStartPosition.CenterScreen;
      this._frmInitialPleaseWait = pleaseWaitNoProgress;
    }
    this._frmInitialPleaseWait.TopMost = true;
    this._frmInitialPleaseWait.Show();
  }

  public void CreatePDFPackage()
  {
    if (this.ShowModifiedTemplatesDocs())
    {
      if (CompanyDocumentAutomation._frmPleaseWait == null && !CompanyDocumentAutomation.BlackBoxMode)
        throw new InvalidOperationException("Must call the Initialize method prior to calling CreatePDFPackage.");
      if (this._printTypeID != -1)
        this._documentName = DefaultDatabase.ExecuteScalar<string>(CommandType.Text, "SELECT PrintType FROM dbo.lstPolicyPrintTypes WITH(NOLOCK) WHERE PrintTypeID=@PrintTypeID", new object[2]
        {
          (object) "@PrintTypeID",
          (object) this._printTypeID
        });
      if (!CompanyDocumentAutomation.BlackBoxMode)
        new Thread(new ParameterizedThreadStart(this.CreatePDFPackageThread))
        {
          Name = "CreatePDFPackageThread",
          Priority = ThreadPriority.AboveNormal
        }.Start();
      else
        this.CreatePDFPackageThread((object) null);
    }
    else
    {
      this.HideInitialPleaseWaitForm();
      this.SubmitEmails();
    }
  }

  protected virtual void SubmitEmails()
  {
  }

  public static bool IsQuoteLevelMessage(Guid broadcastMessage)
  {
    return (DefaultDatabase.ExecuteScalar<byte?>(CommandType.Text, "SELECT AG.HierarchyNumber FROM dbo.lstDocumentAutomationGroups AG WITH(NOLOCK) JOIN dbo.lstAutomationDocumentEvents DE WITH(NOLOCK) ON AG.ID = DE.DocumentAutomationGroupID WHERE DE.EventGuid=@EG", new object[2]
    {
      (object) "@EG",
      (object) broadcastMessage
    }) ?? (byte) 0) == (byte) 3;
  }

  public static void Initialize()
  {
    if (CompanyDocumentAutomation._frmPleaseWait == null && !CompanyDocumentAutomation.BlackBoxMode)
    {
      CompanyDocumentAutomation._frmPleaseWait = new frmPleaseWait();
      CompanyDocumentAutomation._frmPleaseWaitOriginalSize = CompanyDocumentAutomation._frmPleaseWait.Size;
    }
    if (!CompanyDocumentAutomation.BlackBoxMode)
    {
      frmPleaseWait frmPleaseWait = CompanyDocumentAutomation._frmPleaseWait;
      frmPleaseWait.progress.Maximum = 0;
      frmPleaseWait.progress.Maximum = 0;
    }
    CompanyDocumentAutomation._temporaryDocsCache.Clear();
    CompanyDocumentAutomation._templateNames.Clear();
  }

  public static void CleanupTempFiles()
  {
    if (!Directory.Exists(MGATempFolder.MGATempPath))
      return;
    string[] files = Directory.GetFiles(MGATempFolder.MGATempPath);
    int index = 0;
    while (index < files.Length)
    {
      string path = files[index];
      try
      {
        File.Delete(path);
      }
      catch (IOException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        ProjectData.ClearProjectError();
      }
      catch (UnauthorizedAccessException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        ProjectData.ClearProjectError();
      }
      checked { ++index; }
    }
  }

  public static string ConvertImageToPDF(string imageFileName)
  {
    MGASystems.AsposeFacade.PDF.Section section = new MGASystems.AsposeFacade.PDF.PDF().AddSection();
    section.PageInfo.Margin.Left = 30f;
    section.PageInfo.Margin.Top = 30f;
    Image image = new Image();
    image.ImageInfo.File = imageFileName;
    FileInfo fileInfo = new FileInfo(imageFileName);
    string upper = fileInfo.Extension.ToUpper();
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(upper, "GIF", false) != 0)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(upper, "TIF", false) != 0)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(upper, "BMP", false) == 0)
          image.ImageInfo.ImageFileType = (ImageFileType) 5;
      }
      else
        image.ImageInfo.ImageFileType = (ImageFileType) 4;
    }
    else
      image.ImageInfo.ImageFileType = (ImageFileType) 1;
    section.AddParagraph(image);
    string wordDocFileName = imageFileName.Replace(fileInfo.Extension, ".pdf");
    MGASystems.Common.PDF.ConvertWordDocToPDF(wordDocFileName);
    return wordDocFileName;
  }

  public static string ConvertWordDocToPDF(string wordDocFileName)
  {
    FileInfo fileInfo = wordDocFileName != null ? new FileInfo(wordDocFileName) : throw new ArgumentNullException(nameof (wordDocFileName));
    string path = wordDocFileName.Replace(fileInfo.Extension, ".pdf");
    string pdf;
    if (!File.Exists(path))
    {
      Document document;
      try
      {
        CompanyDocumentAutomation.LogAsposePDFAction(nameof (ConvertWordDocToPDF), $"Creating AsposeFacade.Words.Document object for {wordDocFileName}");
        document = new Document(wordDocFileName);
        CompanyDocumentAutomation.LogAsposePDFAction(nameof (ConvertWordDocToPDF), "Created AsposeFacade.Words.Document object");
      }
      catch (IOException ex1)
      {
        ProjectData.SetProjectError((Exception) ex1);
        IOException ex2 = ex1;
        ErrorHandler.SilentHandleError((Exception) ex2);
        MGASystems.Common.ThreadingFunctions.MessageBox.Show($"The IMS was unable to convert the following file ({wordDocFileName}) to PDF, because of an error: '{ex2.Message}' \r\n                    Please make sure that this document is not currently open in another application.", "Document In Use", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        pdf = string.Empty;
        ProjectData.ClearProjectError();
        goto label_7;
      }
      Compatibility.SaveToPDF(document, path);
    }
    pdf = path;
label_7:
    return pdf;
  }

  private static void LogAsposePDFAction(string method, string message)
  {
    MGASystems.Common.PDF.LogAsposePDFAction($"MGA.DocumentAutomation.CompanyDocumentAutomation.{method}", message);
  }

  private void WatermarkPolicy(string fileName)
  {
    if (MGASystems.IMS.NoteDocuments.SystemSettings.GetSetting<bool>("DisablePolicyPreviewWatermark", false))
      return;
    string tempFileName = Path.GetTempFileName();
    PdfFileStamp pdfFileStamp = new PdfFileStamp(fileName, tempFileName);
    Stamp stamp = new Stamp();
    Stream watermarkImage = this.GetWatermarkImage();
    try
    {
      stamp.BindImage(watermarkImage);
      stamp.SetOrigin(200f, 200f);
      stamp.IsBackground = true;
      stamp.CenterStamp = this.CenterPreviewWatermark;
      pdfFileStamp.AddStamp(stamp);
    }
    finally
    {
      pdfFileStamp.Close();
    }
    File.Delete(fileName);
    File.Move(tempFileName, fileName);
  }

  private void ShowViewPrintEmailForm(List<string> emails)
  {
    if (!CompanyDocumentAutomation.ViewPrintEmailFormEnabled)
      return;
    this.AddClientEmailAddress(emails);
    List<Guid> guidList = new List<Guid>();
    try
    {
      foreach (KeyValuePair<int, Guid> documentStoreGuid in this._documentStoreGuids)
        guidList.Add(documentStoreGuid.Value);
    }
    finally
    {
      Dictionary<int, Guid>.Enumerator enumerator;
      enumerator.Dispose();
    }
    try
    {
      List<CompanyDocumentAutomation.NativeDocument> nativeDocuments = this._nativeDocuments;
      System.Func<CompanyDocumentAutomation.NativeDocument, bool> predicate;
      // ISSUE: reference to a compiler-generated field
      if (CompanyDocumentAutomation._Closure\u0024__.\u0024I168\u002D0 != null)
      {
        // ISSUE: reference to a compiler-generated field
        predicate = CompanyDocumentAutomation._Closure\u0024__.\u0024I168\u002D0;
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        CompanyDocumentAutomation._Closure\u0024__.\u0024I168\u002D0 = predicate = (System.Func<CompanyDocumentAutomation.NativeDocument, bool>) ([SpecialName] (n) => !n.IsExcelTempalte | n.IsExcelTempalte & !n.FileOnly);
      }
      foreach (CompanyDocumentAutomation.NativeDocument nativeDocument in nativeDocuments.Where<CompanyDocumentAutomation.NativeDocument>(predicate))
        guidList.Add(nativeDocument.DocumentStoreGuid);
    }
    finally
    {
      IEnumerator<CompanyDocumentAutomation.NativeDocument> enumerator;
      enumerator?.Dispose();
    }
    try
    {
      frmViewPrintEmail frmViewPrintEmail = new frmViewPrintEmail(guidList.ToArray(), emails.ToArray(), this.Quote, this._vpeSettings);
      frmViewPrintEmail.MdiParent = MDIControls.Instance.MDIParent;
      frmViewPrintEmail.ShowInTaskbar = false;
      frmViewPrintEmail.Show();
    }
    catch (InvalidCastException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      ProjectData.ClearProjectError();
    }
  }

  protected virtual void AddClientEmailAddress(List<string> emails)
  {
  }

  protected virtual void ShowVPEForm(List<string> emails)
  {
    if (CompanyDocumentAutomation.BlackBoxMode)
      return;
    MDIControls.Instance.MDIParent.Invoke((Delegate) new CompanyDocumentAutomation.ShowViewPrintEmailFormHandler(this.ShowViewPrintEmailForm), (object) emails);
  }

  protected virtual DataTable GetContactEmails(Guid currQuoteGuid, Messaging.MessageEventArgs e)
  {
    return DefaultDatabase.ExecuteDataTable("dbo.GetViewPrintEmailAddresses", new object[2]
    {
      (object) "QuoteGuid",
      (object) currQuoteGuid
    });
  }

  private void AllPDFsCreated()
  {
    try
    {
      if (this._documentStoreGuids.Count <= 0 && !this._emailBodySet)
      {
        if (this._nativeDocuments.Count <= 0)
          goto label_21;
      }
      if (CompanyDocumentAutomation.IsQuoteLevelMessage(this.EventGuid) && !this.PolicyPreview)
      {
        List<string> emails = new List<string>();
        DataTable dataTable;
        if (this.EventGuid.Equals(BroadcastMessages.InspectionRequested))
          dataTable = DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT Email FROM dbo.tblFin_ExpensePayees WITH (NOLOCK) WHERE Email IS NOT NULL AND PayeeID = @PayeeID", new object[2]
          {
            (object) "@PayeeID",
            (object) ((InspectionRequestedEventArgs) this._event.Context).InspectionCompanyID
          });
        else
          dataTable = this.GetContactEmails(new Quote(this._quote.QuoteGuid).QuoteGuid, this._event);
        try
        {
          foreach (DataRow row in dataTable.Rows)
            emails.Add(row["email"].ToString());
        }
        finally
        {
          IEnumerator enumerator;
          if (enumerator is IDisposable)
            (enumerator as IDisposable).Dispose();
        }
        this.HidePleaseWaitForm();
        this.ShowVPEForm(emails);
      }
      if (this._printTypeID > 0)
      {
        try
        {
          foreach (KeyValuePair<int, Guid> documentStoreGuid in this._documentStoreGuids)
          {
            bool flag;
            if (CompanyDocumentAutomation.SendToDocumentHandlerPrintTypes.TryGetValue(documentStoreGuid.Key, out flag) && !flag)
              DocumentManager.BeginDeleteDocument(documentStoreGuid.Value);
          }
        }
        finally
        {
          Dictionary<int, Guid>.Enumerator enumerator;
          enumerator.Dispose();
        }
      }
    }
    catch (InvalidCastException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      ErrorHandler.HandleError((Exception) ex);
      ProjectData.ClearProjectError();
    }
label_21:
    this.HidePleaseWaitForm();
    this.Dispose();
  }

  protected virtual bool ProcessClientQuoteEvents(Guid eventGuid, ref string tempDescription)
  {
    return false;
  }

  protected virtual string ProcessQuoteEventFileName(Guid eventGuid)
  {
    string str = string.Empty;
    Guid guid = eventGuid;
    if (guid == BroadcastMessages.PolicyBound || guid == BroadcastMessages.RenewalBound)
      str = $"Binder_{this._quote.ControlNo}.pdf";
    else if (guid == BroadcastMessages.NewQuote)
      str = $"{this._quote.ControlNo}.pdf";
    else if (guid == BroadcastMessages.QuotePrinted || guid == BroadcastMessages.RenewalQuotePrinted)
      str = $"Quote_{this._quote.ControlNo}.pdf";
    else if (guid == BroadcastMessages.NOCIssued)
      str = $"NOC_{this._quote.ControlNo}.pdf";
    else if (guid == BroadcastMessages.PolicyIssued)
      str = $"Policy_{this._quote.ControlNo}.pdf";
    else if (guid == BroadcastMessages.EndorsementBound)
      str = $"End_{this._quote.ControlNo}.pdf";
    else if (guid == BroadcastMessages.PolicyReinstated)
      str = $"Reinstatement_{this._quote.ControlNo}.pdf";
    else if (guid == BroadcastMessages.PolicyCancelled)
      str = $"Cancellation_{this._quote.ControlNo}.pdf";
    else if (guid == BroadcastMessages.PolicyDeclined)
      str = $"Declination_{this._quote.ControlNo}.pdf";
    else if (guid == BroadcastMessages.InspectionRequested)
      str = $"Inspection_{this._quote.ControlNo}.pdf";
    return str;
  }

  protected virtual string ProcessQuoteEventDescription(Guid eventGuid)
  {
    string str = string.Empty;
    Guid guid = eventGuid;
    if (guid == BroadcastMessages.PolicyBound || guid == BroadcastMessages.RenewalBound)
      str = $"Binder - Policy #{this._quote.PolicyNumber}";
    else if (guid == BroadcastMessages.NewQuote)
      str = "New Quote";
    else if (guid == BroadcastMessages.QuotePrinted || guid == BroadcastMessages.RenewalQuotePrinted)
      str = "Quotation";
    else if (guid == BroadcastMessages.NOCIssued)
      str = $"NOC - Policy #{this._quote.PolicyNumber}";
    else if (guid == BroadcastMessages.PolicyIssued)
      str = $"Policy #{this._quote.PolicyNumber} ({this._documentName})";
    else if (guid == BroadcastMessages.EndorsementBound)
      str = $"Endorsement - Policy #{this._quote.PolicyNumber} Endorsement #{this._quote.EndorsementNum} Endt Description - {this._quote.EndorsementComment}";
    else if (guid == BroadcastMessages.PolicyReinstated)
      str = "Reinstatement";
    else if (guid == BroadcastMessages.PolicyCancelled)
      str = "Cancellation";
    else if (guid == BroadcastMessages.PolicyDeclined)
      str = "Declination";
    else if (guid == BroadcastMessages.InspectionRequested)
      str = "Inspection Request";
    return str;
  }

  protected virtual Guid SendQuoteDocToDocSystem(Guid quoteGuid, string fileName, Guid eventGuid)
  {
    if (string.IsNullOrEmpty(fileName))
      throw new ArgumentNullException(nameof (fileName));
    string description = string.Empty;
    string fileName1 = string.Empty;
    int folderID = -1;
    string tempDescription = DefaultDatabase.ExecuteScalar<string>(CommandType.Text, "SELECT EventName FROM lstAutomationDocumentEvents (NOLOCK) WHERE EventGuid = @eGuid AND SendtoDocHandler = 1", new object[2]
    {
      (object) "@eGuid",
      (object) eventGuid
    });
    if (MGASystems.IMS.NoteDocuments.SystemSettings.GetSetting<bool>("EnableCustomDocumentNaming", false))
    {
      try
      {
        DataTable source = DefaultDatabase.ExecuteDataTable("dbo.spDocumentNaming_ResolveQuote", new object[4]
        {
          (object) "@eventGuid",
          (object) eventGuid,
          (object) "@quoteGuid",
          (object) this._quote.QuoteGuid
        });
        if (source.Rows.Count > 0)
        {
          DataRow dr = DefaultDatabase.ExecuteDataRow(frmDocumentNaming.GetSetting.QuoteDataProcedure, new object[2]
          {
            (object) "@quoteGuid",
            (object) quoteGuid
          });
          if (!string.IsNullOrEmpty(source.AsEnumerable().ElementAtOrDefault<DataRow>(0).Field<string>("FilenameFormatString")))
            fileName1 = frmDocumentNaming.ResolveString(source.AsEnumerable().ElementAtOrDefault<DataRow>(0).Field<string>("FilenameFormatString"), dr);
          if (!string.IsNullOrEmpty(source.AsEnumerable().ElementAtOrDefault<DataRow>(0).Field<string>("FilenameDescriptionString")))
            description = frmDocumentNaming.ResolveString(source.AsEnumerable().ElementAtOrDefault<DataRow>(0).Field<string>("FilenameDescriptionString"), dr);
          int? nullable;
          folderID = (nullable = source.AsEnumerable().ElementAtOrDefault<DataRow>(0).Field<int?>("FolderOverride")).HasValue ? nullable.GetValueOrDefault() : -1;
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }
    if (string.IsNullOrEmpty(fileName1))
      fileName1 = this.ProcessQuoteEventFileName(eventGuid);
    if (string.IsNullOrEmpty(description))
      description = this.ProcessQuoteEventDescription(eventGuid);
    Guid docSystem;
    if (string.IsNullOrEmpty(fileName1) || string.IsNullOrEmpty(description))
    {
      if (string.IsNullOrEmpty(tempDescription) && !this.ProcessClientQuoteEvents(eventGuid, ref tempDescription))
      {
        docSystem = Guid.Empty;
        goto label_23;
      }
      description = string.IsNullOrEmpty(description) ? tempDescription : description;
      fileName1 = string.IsNullOrEmpty(fileName1) ? $"{tempDescription}_{this._quote.ControlNo}.pdf" : fileName1;
    }
    string str = FilePath.Resolve(Path.Combine(MGATempFolder.MGATempPath, this.ScrubFileName(fileName1)));
    if (string.IsNullOrEmpty(str))
      throw new InvalidOperationException("saveAsFileName is empty for event " + eventGuid.ToString());
    if (File.Exists(str))
      File.Delete(str);
    File.Copy(fileName, str);
    docSystem = this.SendFileToDocumentSystem(eventGuid, str, description, folderID);
label_23:
    return docSystem;
  }

  private Guid SendFileToDocumentSystem(
    Guid eventGuid,
    string fileName,
    string description,
    int folderID = -1)
  {
    CompanyDocumentAutomation documentAutomation = this;
    Guid guid = eventGuid;
    this.FileNameSaveAs = fileName;
    this.FileDescriptionSaveAs = description;
    if (folderID == -1)
      folderID = DefaultDatabase.ExecuteScalar<int?>(CommandType.Text, "SELECT dbo.GetDocumentFolder(@CompanyLineGuid,@AutomationEventGuid,@QuoteGuid)", new object[6]
      {
        (object) "@CompanyLineGuid",
        (object) this._quote.CompanyLineGuid,
        (object) "@AutomationEventGuid",
        (object) guid,
        (object) "@QuoteGuid",
        (object) this._quote.QuoteGuid
      }) ?? -1;
    folderID = this.SaveToFolder(guid, folderID, fileName, description);
    Guid documentStoreGuidToAssign = Guid.NewGuid();
    DocumentManager.BeginFileAddWithBind((DocumentManager.FileAddedAndBound) ([SpecialName] (docGuid) => documentAutomation.OnDocumentAdded(docGuid, guid)), this.FileNameSaveAs, folderID, this.FileDescriptionSaveAs, (ISupportDocumentSystem) this._quote, false, "", false, documentStoreGuidToAssign);
    File.Delete(fileName);
    return documentStoreGuidToAssign;
  }

  private void OnDocumentAdded(Guid addedDocumentGuid, Guid automationEventGuid)
  {
    try
    {
      XElement xelement1 = new XElement(XName.Get("AutomationEventInfo", ""));
      // ISSUE: reference to a compiler-generated method
      xelement1.Add((object) MGASystems.IMS.DocumentAutomation.My.InternalXmlHelper.CreateAttribute(XName.Get("EventGuid", ""), (object) automationEventGuid));
      XElement xelement2 = xelement1;
      DefaultDatabase.ExecuteNonQuery("DocumentSystem_UpdateDocumentMetaData", new object[4]
      {
        (object) "@DocumentStoreGuid",
        (object) addedDocumentGuid,
        (object) "@metaXml",
        (object) xelement2.ToString()
      });
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      ErrorHandler.SilentHandleError(ex);
      ProjectData.ClearProjectError();
    }
  }

  private string ScrubFileName(string fileName)
  {
    char[] invalidFileNameChars = Path.GetInvalidFileNameChars();
    int index = 0;
    while (index < invalidFileNameChars.Length)
    {
      char ch = invalidFileNameChars[index];
      fileName = fileName.Replace(Conversions.ToString(ch), string.Empty);
      checked { ++index; }
    }
    return fileName;
  }

  private void AttachPolicyForms() => this.AttachPolicyForms(-1);

  private void AttachPolicyForms(int printTypeID)
  {
    if (this._quoteGuid.Equals(Guid.Empty))
      throw new InvalidOperationException("Must set QuoteGuid before calling AttachPolicyForms");
    // ISSUE: variable of a compiler-generated type
    CompanyDocumentAutomation._Closure\u0024__181\u002D0 closure1810_1;
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    CompanyDocumentAutomation._Closure\u0024__181\u002D0 closure1810_2 = new CompanyDocumentAutomation._Closure\u0024__181\u002D0(closure1810_1);
    // ISSUE: reference to a compiler-generated field
    closure1810_2.\u0024VB\u0024Me = this;
    DataTable dataTable = DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT CompanyLineID, FormOrderIncrease FROM dbo.GetPolicyFormCompanyLines_New(@QuoteGuid)", new object[2]
    {
      (object) "@QuoteGuid",
      (object) this.QuoteGuid
    });
    try
    {
      foreach (DataRow row in dataTable.Rows)
        this.CompanyLineOrder[row.Field<int>("CompanyLineID")] = (new CompanyLine(row.Field<int>("CompanyLineID")), row.Field<int>("FormOrderIncrease"));
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    // ISSUE: variable of a compiler-generated type
    CompanyDocumentAutomation._Closure\u0024__181\u002D0 closure1810_3 = closure1810_2;
    Dictionary<int, (CompanyLine, int)> companyLineOrder = this.CompanyLineOrder;
    System.Func<KeyValuePair<int, (CompanyLine, int)>, int> selector;
    // ISSUE: reference to a compiler-generated field
    if (CompanyDocumentAutomation._Closure\u0024__.\u0024I181\u002D0 != null)
    {
      // ISSUE: reference to a compiler-generated field
      selector = CompanyDocumentAutomation._Closure\u0024__.\u0024I181\u002D0;
    }
    else
    {
      // ISSUE: reference to a compiler-generated field
      CompanyDocumentAutomation._Closure\u0024__.\u0024I181\u002D0 = selector = (System.Func<KeyValuePair<int, (CompanyLine, int)>, int>) ([SpecialName] (clo) => clo.Value.FormOrderIncrease);
    }
    int num = Math.Max(companyLineOrder.Max<KeyValuePair<int, (CompanyLine, int)>>(selector), 1000) + 1000;
    // ISSUE: reference to a compiler-generated field
    closure1810_3.\u0024VB\u0024Local_nextCLOrder = num;
    // ISSUE: reference to a compiler-generated field
    closure1810_2.\u0024VB\u0024Local_preserveAppliedCL = MGASystems.IMS.NoteDocuments.SystemSettings.GetSetting<bool>("DocumentAutomation.FCW.PreserveAppliedCompanyLines", true);
    this._policyFormCount = this._automationDocs.Count;
    // ISSUE: reference to a compiler-generated field
    closure1810_2.\u0024VB\u0024Local_quoteCompanyLineID = this.Quote.CompanyLine.CompanyLineID;
    // ISSUE: reference to a compiler-generated method
    DefaultDatabase.ExecuteReader((object) null, new EventHandler<ExecuteReaderArgs>(closure1810_2._Lambda\u0024__1), CommandType.StoredProcedure, "dbo.GetPolicyForms_New", 300, (CommandArgumentType) 0, new object[6]
    {
      (object) "@quoteGuid",
      (object) this._quoteGuid,
      (object) "@printTypeID",
      printTypeID != -1 ? (object) printTypeID : (object) null,
      (object) "@companyLineGuid",
      (object) this._companyLineGuid
    });
    this._policyFormCount = this._automationDocs.Count - this._policyFormCount;
  }

  private int PreparePolicyForms()
  {
    if (this.EventGuid.Equals(BroadcastMessages.PolicyIssued) || this.EventGuid.Equals(BroadcastMessages.PolicyPreviewed))
    {
      if (this._printTypeID == -1)
        throw new InvalidOperationException("printTypeID required for PolicyIssued event.");
      this.AttachPolicyForms(this._printTypeID);
    }
    else if (this.EventGuid.Equals(BroadcastMessages.EndorsementBound) || this.EventGuid.Equals(BroadcastMessages.PolicyCancelled) || this.EventGuid.Equals(BroadcastMessages.PolicyReinstated))
      this.AttachPolicyForms();
    int num;
    try
    {
      foreach (AutomationDoc automationDoc in this._automationDocs)
      {
        if (automationDoc.DocumentType == AutomationDoc.DocType.TemplateDocument)
          ++num;
      }
    }
    finally
    {
      List<AutomationDoc>.Enumerator enumerator;
      enumerator.Dispose();
    }
    return num;
  }

  protected virtual bool ShowModifiedTemplatesDocs() => true;

  protected virtual void CreatePackageClientInit()
  {
  }

  private void CreatePDFPackageThread(object state)
  {
    this.CreatePackageClientInit();
    if (this._event == null)
      this._event = new Messaging.MessageEventArgs();
    int max;
    try
    {
      max = this.PreparePolicyForms();
      this.HideInitialPleaseWaitForm();
    }
    catch (Exception ex1)
    {
      ProjectData.SetProjectError(ex1);
      Exception ex2 = ex1;
      this._createPDFException = ex2;
      this.DisposePleaseWaitForm();
      this.ShowError(ex2);
      ProjectData.ClearProjectError();
      return;
    }
    if (!this.EventGuid.Equals(Guid.Empty) && !this._companyLineGuid.Equals(Guid.Empty))
    {
      dsCompanyDocumentAutomation.EventDocumentsDataTable dt = new dsCompanyDocumentAutomation.EventDocumentsDataTable();
      DefaultDatabase.LoadDataTable((DataTable) dt, MGASystems.IMS.NoteDocuments.SystemSettings.GetSetting<string>("Automation.GetEventDocuments", "dbo.GetEventDocuments"), new object[6]
      {
        (object) "@quoteGuid",
        (object) this.QuoteGuid,
        (object) "@CompanyLineGuid",
        (object) this._companyLineGuid,
        (object) "@AutomationEventGuid",
        (object) this.EventGuid
      });
      this.GetAdditionalDocuments(dt, this.EventGuid);
      if (this._automationDocs.Count + DefaultDatabase.ExecuteScalar<int>(CommandType.Text, "SELECT COUNT(1) FROM dbo.tblCompanyAutomationDocuments WITH(NOLOCK) WHERE CompanyLineGuid=@CompanyLineGuid AND AutomationEventGuid=@AutomationEventGuid", new object[4]
      {
        (object) "@CompanyLineGuid",
        (object) this._companyLineGuid,
        (object) "@AutomationEventGuid",
        (object) this.EventGuid
      }) + dt.Count == 0)
      {
        if (!CompanyDocumentAutomation.BlackBoxMode)
        {
          MDIControls.Instance.MDIParent.Invoke((Delegate) new MethodInvoker(this.NoDocumentsCreated));
          return;
        }
        this.NoDocumentsCreated();
        return;
      }
      this.ShowPleaseWaitForm();
      MGASystems.IMS.NoteDocuments.SystemSettings.GetSetting<bool>("DocumentAutomation.EventOncePer", false);
      try
      {
        foreach (dsCompanyDocumentAutomation.EventDocumentsRow row in dt.Rows)
        {
          bool flag = true;
          if (row.HasConditionalID)
          {
            DocumentConditional conditionalReadOnly = DocumentConditional.GetDocumentConditionalReadOnly(row.ID);
            if (conditionalReadOnly.cnID > 0)
            {
              Tag userTag = Tag.GetUserTag(conditionalReadOnly.TagName, conditionalReadOnly.DataStoreID);
              object objectValue = RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteDataRow(userTag.StoredProcedure, new object[2]
              {
                (object) "@QuoteGuid",
                (object) this.QuoteGuid
              }).Field<object>(userTag.Field));
              if (!conditionalReadOnly.CheckConditional(RuntimeHelpers.GetObjectValue(objectValue)))
                continue;
            }
          }
          if (flag)
          {
            AutomationDoc automationDoc = AutomationDoc.Create(row.AutomationDocumentID, (object) row.DocumentOrder, (object) row.SafeEndorsementNum, (object) row.SafeCompanyLineID, (object) row.SafeOncePer, (object) row.SafePolicyFormID);
            if (automationDoc != null)
            {
              automationDoc.CompanyAutomationDocumentID = row.Field<int?>("ID") ?? 0;
              automationDoc.IncludeWithQuotation = row.Field<bool?>("IncludeWithQuotation") ?? false;
              automationDoc.EventDocument = true;
              this._automationDocs.Add(automationDoc);
            }
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
    else
      this.ShowPleaseWaitForm();
    if (max > 0)
    {
      try
      {
        this.SetProgressBarMax(max);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }
    this.GetTemplatesFromDatabase();
    if (CompanyDocumentAutomation._temporaryDocsCache.Count > 0 && !CompanyDocumentAutomation.BlackBoxMode)
    {
      bool flag1 = (bool) MDIControls.Instance.MDIParent.Invoke((Delegate) new CompanyDocumentAutomation.ModifyTemplateDocsHandler(this.ModifyTemplateDocs));
      bool flag2 = false;
      if (!flag1 || this._automationDocs.Count == 0)
        flag2 = true;
      if (flag2)
      {
        this.DisposePleaseWaitForm();
        if (!flag1 || this._automationDocs.Count != 0)
          return;
        this.SubmitEmails();
        Messaging.SendBroadcastMessage(BroadcastMessages.NoEventDocumentsCreated);
        return;
      }
    }
    if (this.CloseAfterModifyingTemplates)
    {
      this.DisposePleaseWaitForm();
    }
    else
    {
      this.PerformPrePackagingOperations();
      try
      {
        this.FinalizePackage();
      }
      catch (NotImplementedException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        NotImplementedException implementedException = ex;
        this._createPDFException = (Exception) implementedException;
        this.DisposePleaseWaitForm();
        MGASystems.Common.ThreadingFunctions.MessageBox.Show(implementedException.Message, "Unsupported Word Version", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        ProjectData.ClearProjectError();
      }
      catch (PlatformNotSupportedException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        this._createPDFException = (Exception) ex;
        this.DisposePleaseWaitForm();
        MGASystems.Common.ThreadingFunctions.MessageBox.Show("Windows NT or later is required to create PDF documents in the IMS.\n\nThis machine is not capable of creating PDFs.", "Unable to Create PDF", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        ProjectData.ClearProjectError();
      }
      catch (InvalidOperationException ex3)
      {
        ProjectData.SetProjectError((Exception) ex3);
        InvalidOperationException ex4 = ex3;
        this._createPDFException = (Exception) ex4;
        if (ex4.Message.Contains("Client found response content type"))
        {
          MGASystems.Common.ThreadingFunctions.MessageBox.Show("The invoice web service returned an unexpected content type.\n\nPlease contact technical support.", "Unable to Create PDF", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        else
        {
          this.DisposePleaseWaitForm();
          this.ShowError((Exception) ex4);
        }
        ProjectData.ClearProjectError();
      }
      catch (IOException ex5)
      {
        ProjectData.SetProjectError((Exception) ex5);
        IOException ex6 = ex5;
        this._createPDFException = (Exception) ex6;
        if (ex6.Message.Contains("Invalid pdf format"))
        {
          MGASystems.Common.ThreadingFunctions.MessageBox.Show("A PDF is in an invalid format.\n\nTry opening the PDF in Adobe to verify its validity and re-upload the document.", "Unable to Create PDF", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        else
        {
          this.DisposePleaseWaitForm();
          this.ShowError((Exception) ex6);
        }
        ProjectData.ClearProjectError();
      }
      catch (Exception ex7)
      {
        ProjectData.SetProjectError(ex7);
        Exception ex8 = ex7;
        this._createPDFException = ex8;
        this.DisposePleaseWaitForm();
        this.ShowError(ex8);
        ProjectData.ClearProjectError();
      }
    }
  }

  protected virtual void GetAdditionalDocuments(
    dsCompanyDocumentAutomation.EventDocumentsDataTable dt,
    Guid eventGuid)
  {
  }

  protected virtual void PerformPrePackagingOperations()
  {
  }

  protected virtual void NoDocumentsCreated()
  {
  }

  private void HideInitialPleaseWaitForm()
  {
    if (this._frmInitialPleaseWait == null || CompanyDocumentAutomation.BlackBoxMode)
      return;
    if (MDIControls.Instance.MDIParent.InvokeRequired)
      MDIControls.Instance.MDIParent.Invoke((Delegate) new MethodInvoker(this.HideInitialPleaseWaitForm));
    else
      this._frmInitialPleaseWait.Hide();
  }

  private void DisposePleaseWaitForm()
  {
    if (CompanyDocumentAutomation.BlackBoxMode)
      return;
    if (MDIControls.Instance.MDIParent.InvokeRequired)
    {
      MDIControls.Instance.MDIParent.Invoke((Delegate) new MethodInvoker(this.DisposePleaseWaitForm));
    }
    else
    {
      if (!this.IsPleaseWaitFormAvailable())
        return;
      CompanyDocumentAutomation._frmPleaseWait.Close();
      CompanyDocumentAutomation._frmPleaseWait.Dispose();
      CompanyDocumentAutomation._frmPleaseWait = (frmPleaseWait) null;
    }
  }

  private void ShowError(Exception ex)
  {
    if (CompanyDocumentAutomation.BlackBoxMode)
      ErrorHandler.SilentHandleError(ex);
    else if (MDIControls.Instance.MDIParent.InvokeRequired)
      MDIControls.Instance.MDIParent.Invoke((Delegate) new CompanyDocumentAutomation.ShowErrorHandler(this.ShowError), (object) ex);
    else
      ErrorHandler.HandleError(ex);
  }

  private bool ModifyTemplateDocs()
  {
    bool flag1;
    try
    {
      Quote quote = new Quote(this._quoteGuid);
      Dictionary<int, CompanyDocumentAutomation.TemplateDoc> dictionary = new Dictionary<int, CompanyDocumentAutomation.TemplateDoc>();
      try
      {
        foreach (KeyValuePair<int, string> keyValuePair in CompanyDocumentAutomation._temporaryDocsCache)
        {
          CompanyDocumentAutomation.TemplateDoc templateDoc = new CompanyDocumentAutomation.TemplateDoc()
          {
            TemplateID = keyValuePair.Key,
            Filename = keyValuePair.Value
          };
          dictionary.Add(templateDoc.TemplateID, templateDoc);
        }
      }
      finally
      {
        Dictionary<int, string>.Enumerator enumerator;
        enumerator.Dispose();
      }
      this.HidePleaseWaitForm();
      bool flag2 = false;
      this.ModifyTemplateDocs(this._automationDocs);
      using (frmModifyTemplateDocs modifyTemplateDocs = (frmModifyTemplateDocs) FormSettings.ShowFormDialog(typeof (frmModifyTemplateDocs), (object) quote.QuoteID, (object) dictionary, (object) CompanyDocumentAutomation._templateNames, (object) this._automationDocs, (object) this._event))
      {
        this.ShowPleaseWaitForm();
        flag2 = modifyTemplateDocs.Saved;
      }
      flag1 = flag2;
    }
    catch (DirectoryNotFoundException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      ErrorHandler.HandleError((Exception) ex);
      ProjectData.ClearProjectError();
    }
    return flag1;
  }

  protected virtual void ModifyTemplateDocs(List<AutomationDoc> automationDocs)
  {
  }

  private void SetProgressBarMax(int max)
  {
    if (CompanyDocumentAutomation.BlackBoxMode)
      return;
    if (MDIControls.Instance.MDIParent.InvokeRequired)
    {
      MDIControls.Instance.MDIParent.Invoke((Delegate) new CompanyDocumentAutomation.BumpProgressBarMaxHandler(this.SetProgressBarMax), (object) max);
    }
    else
    {
      if (!this.IsPleaseWaitFormAvailable() || CompanyDocumentAutomation._frmPleaseWait.progress == null || CompanyDocumentAutomation._frmPleaseWait.progress.Value != 0)
        return;
      CompanyDocumentAutomation._frmPleaseWait.progress.Maximum = max;
    }
  }

  private void BumpProgressBarMax(int amount)
  {
    if (CompanyDocumentAutomation.BlackBoxMode)
      return;
    if (MDIControls.Instance.MDIParent.InvokeRequired)
    {
      MDIControls.Instance.MDIParent.Invoke((Delegate) new CompanyDocumentAutomation.BumpProgressBarMaxHandler(this.BumpProgressBarMax), (object) amount);
    }
    else
    {
      if (!this.IsPleaseWaitFormAvailable() || CompanyDocumentAutomation._frmPleaseWait.progress == null || CompanyDocumentAutomation._frmPleaseWait.progress.Value != 0)
        return;
      UltraProgressBar progress;
      int num = (progress = CompanyDocumentAutomation._frmPleaseWait.progress).Maximum + amount;
      progress.Maximum = num;
    }
  }

  private void ShowPleaseWaitForm()
  {
    if (CompanyDocumentAutomation.BlackBoxMode)
      return;
    if (MDIControls.Instance.MDIParent.InvokeRequired)
    {
      MDIControls.Instance.MDIParent.BeginInvoke((Delegate) new MethodInvoker(this.ShowPleaseWaitForm));
    }
    else
    {
      if (!this.IsPleaseWaitFormAvailable())
        return;
      if (!CompanyDocumentAutomation._frmPleaseWait.Visible)
      {
        CompanyDocumentAutomation._frmPleaseWait.ShowInTaskbar = false;
        int num = (int) CompanyDocumentAutomation._frmPleaseWait.ShowDialog();
      }
      else
      {
        CompanyDocumentAutomation._frmPleaseWait.Size = CompanyDocumentAutomation._frmPleaseWaitOriginalSize;
        CompanyDocumentAutomation._frmPleaseWait.Refresh();
      }
    }
  }

  private bool IsPleaseWaitFormAvailable()
  {
    return CompanyDocumentAutomation._frmPleaseWait != null && !CompanyDocumentAutomation._frmPleaseWait.IsDisposed && !CompanyDocumentAutomation._frmPleaseWait.Disposing;
  }

  private void SetProgressText(string text)
  {
    if (CompanyDocumentAutomation.BlackBoxMode)
      return;
    if (MDIControls.Instance.MDIParent.InvokeRequired)
    {
      MDIControls.Instance.MDIParent.BeginInvoke((Delegate) new CompanyDocumentAutomation.SetProgressTextHandler(this.SetProgressText), (object) text);
    }
    else
    {
      if (!this.IsPleaseWaitFormAvailable())
        return;
      ((ControlBase) CompanyDocumentAutomation._frmPleaseWait.lblStatus).Text = text;
      ((UltraControlBase) CompanyDocumentAutomation._frmPleaseWait.lblStatus).Refresh();
    }
  }

  private void ResetProgressBar()
  {
    if (CompanyDocumentAutomation.BlackBoxMode)
      return;
    if (MDIControls.Instance.MDIParent.InvokeRequired)
    {
      MDIControls.Instance.MDIParent.Invoke((Delegate) new MethodInvoker(this.ResetProgressBar));
    }
    else
    {
      try
      {
        if (!this.IsPleaseWaitFormAvailable())
          return;
        CompanyDocumentAutomation._frmPleaseWait.progress.Value = 0;
      }
      catch (NullReferenceException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        ProjectData.ClearProjectError();
      }
    }
  }

  private void BumpProgressBarProgress(int steps = 1)
  {
    if (CompanyDocumentAutomation.BlackBoxMode)
      return;
    if (MDIControls.Instance.MDIParent.InvokeRequired)
    {
      MDIControls.Instance.MDIParent.Invoke((Delegate) ([SpecialName] () => this.BumpProgressBarProgress()), (object) steps);
    }
    else
    {
      if (!this.IsPleaseWaitFormAvailable() || CompanyDocumentAutomation._frmPleaseWait.progress.Value + steps > CompanyDocumentAutomation._frmPleaseWait.progress.Maximum)
        return;
      UltraProgressBar progress;
      int num = (progress = CompanyDocumentAutomation._frmPleaseWait.progress).Value + steps;
      progress.Value = num;
      ((UltraControlBase) CompanyDocumentAutomation._frmPleaseWait.progress).Refresh();
    }
  }

  private void HidePleaseWaitForm()
  {
    if (CompanyDocumentAutomation.BlackBoxMode)
      return;
    if (MDIControls.Instance.MDIParent.InvokeRequired)
    {
      MDIControls.Instance.MDIParent.BeginInvoke((Delegate) new MethodInvoker(this.HidePleaseWaitForm));
    }
    else
    {
      if (!this.IsPleaseWaitFormAvailable())
        return;
      CompanyDocumentAutomation._frmPleaseWait.Size = new Size(0, 0);
    }
  }

  protected virtual bool CenterPreviewWatermark => false;

  protected virtual MemoryStream WaterMarkStreams(MemoryStream ms)
  {
    MemoryStream memoryStream = new MemoryStream();
    ms.Seek(0L, SeekOrigin.Begin);
    PdfFileInfo pdfFileInfo = new PdfFileInfo((Stream) ms);
    Stamp stamp = new Stamp();
    stamp.BindImage(this.GetWatermarkImage());
    stamp.IsBackground = true;
    stamp.SetOrigin(200f, 200f);
    stamp.CenterStamp = this.CenterPreviewWatermark;
    PdfFileStamp pdfFileStamp = new PdfFileStamp((Stream) ms, (Stream) memoryStream);
    pdfFileStamp.AddStamp(stamp);
    pdfFileStamp.Close();
    memoryStream.Position = 0L;
    return memoryStream;
  }

  protected virtual Stream GetWatermarkImage()
  {
    Stream watermarkImage;
    if (MGASystems.IMS.NoteDocuments.SystemSettings.GetSetting<bool>("DocumentAutomation.Override.IssuingOfficeLogoWatermark", false) && this._quote != null)
    {
      DataRow dataRow = DefaultDatabase.ExecuteDataRow(CommandType.Text, "SELECT PreviewWatermark, Logo FROM dbo.tblClientOffices WITH(NOLOCK) WHERE OfficeGUID = @officeGuid", new object[2]
      {
        (object) "@officeGuid",
        (object) this._quote.IssuingLocationGuid
      });
      if (dataRow != null)
      {
        object[] itemArray = dataRow.ItemArray;
        int index = 0;
        while (index < itemArray.Length)
        {
          if (RuntimeHelpers.GetObjectValue(itemArray[index]) is byte[] objectValue && objectValue.Length > 0)
          {
            watermarkImage = (Stream) new MemoryStream(objectValue);
            goto label_8;
          }
          checked { ++index; }
        }
      }
    }
    watermarkImage = Assembly.GetExecutingAssembly().GetManifestResourceStream("MGASystems.IMS.DocumentAutomation.Preview.bmp");
label_8:
    return watermarkImage;
  }

  private void FinalizePackage()
  {
    this.ResetProgressBar();
    this.SetProgressBarMax(0);
    try
    {
      foreach (AutomationDoc automationDoc in this._automationDocs)
      {
        if (automationDoc.DocumentType == AutomationDoc.DocType.AutomationReport)
          this.BumpProgressBarMax(1);
        else if (automationDoc.DocumentType == AutomationDoc.DocType.TemplateDocument)
          this.BumpProgressBarMax(2);
        else if (automationDoc.DocumentType == AutomationDoc.DocType.PDF)
          this.BumpProgressBarMax(2);
      }
    }
    finally
    {
      List<AutomationDoc>.Enumerator enumerator;
      enumerator.Dispose();
    }
    this.BumpProgressBarMax(1);
    this.ShowPleaseWaitForm();
    if (CompanyDocumentAutomation.SortDocuments)
      this._automationDocs.Sort();
    for (int index = this._automationDocs.Count - 1; index >= 0; index += -1)
    {
      AutomationDoc automationDoc = this._automationDocs[this._automationDocs.Count - 1 - index];
      if (automationDoc.DocumentType == AutomationDoc.DocType.AutomationReport)
      {
        this.SetProgressText("Converting system report to PDF...");
        MemoryStream pdf = this.ConvertAutomationReportToPDF(automationDoc.AutomationReportGuid, automationDoc.PlacedByCompanyLineID);
        if (pdf != null)
        {
          this.SaveFileSeparateClient((Document) null, automationDoc, pdf);
          if (!automationDoc.IncludeWithQuotation)
          {
            this._package.AddPDF(pdf);
          }
          else
          {
            MemoryStream memoryStream = new MemoryStream();
            this._package.AddPDF(this.WaterMarkStreams(pdf));
          }
        }
        else
          this._automationDocs.Remove(automationDoc);
        this.BumpProgressBarProgress();
      }
      else if (automationDoc.DocumentType == AutomationDoc.DocType.TemplateDocument)
      {
        Document mergedNativeWordDocument = (Document) null;
        try
        {
          foreach (KeyValuePair<int, CompanyDocumentAutomation.TemplateDoc> tempDoc in this._tempDocs)
          {
            CompanyDocumentAutomation.TemplateDoc docTemplate = tempDoc.Value;
            if (docTemplate.TemplateID == automationDoc.TemplateID)
            {
              if (!string.IsNullOrEmpty(docTemplate.Filename) && !File.Exists(docTemplate.Filename))
                docTemplate.Filename = Path.ChangeExtension(docTemplate.Filename, Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Path.GetExtension(docTemplate.Filename), "doc", false) == 0 ? "docx" : "doc");
              MemoryStream memoryStream1 = string.IsNullOrEmpty(automationDoc.OncePer) ? this.ConvertTemplateDocToPDF(docTemplate, string.Empty, automationDoc.PlacedByCompanyLineID, automationDoc.PolicyFormID, ref mergedNativeWordDocument) : this.ConvertTemplateDocToPDF(docTemplate, automationDoc.OncePer, automationDoc.PlacedByCompanyLineID, -1, ref mergedNativeWordDocument);
              this.SaveFileSeparateClient(mergedNativeWordDocument, automationDoc, memoryStream1);
              if (automationDoc.SeparateDocument && mergedNativeWordDocument != null)
              {
                if ((!MGASystems.IMS.NoteDocuments.SystemSettings.GetSetting<bool>("DocAutomation.SaveSeparateAsType", false) ? 0 : (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(automationDoc.SaveAsType, "P", false) == 0 ? 1 : 0)) != 0)
                  this.AttachSeparatePDFDocument(automationDoc, mergedNativeWordDocument, this.EventGuid, memoryStream1);
                else
                  this.AttachSeparateNativeDocument(automationDoc, mergedNativeWordDocument, this.EventGuid);
                this._package.AddBrokenOutFileNames(automationDoc.TemplateName);
                memoryStream1 = (MemoryStream) null;
              }
              else if (automationDoc.SeparateDocument && mergedNativeWordDocument == null && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(automationDoc.TemplateType, "E", false) == 0)
              {
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(automationDoc.SaveAsType, "P", false) == 0)
                  this.AttachSeparateExcelAsPDFDocument(automationDoc, this.EventGuid);
                else
                  this.AttachSeparateExcelDocument(automationDoc, this.EventGuid);
                this._package.AddBrokenOutFileNames(automationDoc.TemplateName);
                memoryStream1 = (MemoryStream) null;
              }
              if (memoryStream1 != null)
              {
                if (!automationDoc.FileOnly)
                {
                  if (!automationDoc.IncludeWithQuotation)
                  {
                    this._package.AddPDF(memoryStream1);
                    break;
                  }
                  MemoryStream memoryStream2 = new MemoryStream();
                  this._package.AddPDF(this.WaterMarkStreams(memoryStream1));
                  break;
                }
                string fileOnlyFilename = this.GetFileOnlyFilename(automationDoc);
                MyProject.Computer.FileSystem.WriteAllBytes(fileOnlyFilename, memoryStream1.ToArray(), false);
                if (CompanyDocumentAutomation.IsQuoteLevelMessage(this.EventGuid))
                {
                  if (CompanyDocumentAutomation.SendToDocumentSystem)
                  {
                    this.SendFileToDocumentSystem(this.EventGuid, fileOnlyFilename, string.Empty);
                    break;
                  }
                  break;
                }
                break;
              }
              break;
            }
          }
        }
        finally
        {
          Dictionary<int, CompanyDocumentAutomation.TemplateDoc>.Enumerator enumerator;
          enumerator.Dispose();
        }
      }
      else if (automationDoc.DocumentType == AutomationDoc.DocType.PDF)
      {
        this.BumpProgressBarProgress();
        if (!automationDoc.IncludeWithQuotation)
        {
          this._package.AddPDF(automationDoc.PDF);
        }
        else
        {
          MemoryStream memoryStream = new MemoryStream();
          this._package.AddPDF(this.WaterMarkStreams(automationDoc.PDF));
        }
        this.BumpProgressBarProgress();
      }
    }
    if (this._package.PdfStreams.Count > 0)
    {
      string friendlyFilename = this.GetFriendlyFilename();
      if (this._automationDocs.Count == 1)
      {
        this._resultingBytes = this._package.PdfStreams[0].ToArray();
        MyProject.Computer.FileSystem.WriteAllBytes(friendlyFilename, this._resultingBytes, false);
        this.PackageCompleted(friendlyFilename);
      }
      else if (this._package.PdfStreams.Count > 0)
      {
        this.SetProgressText("Merging PDF documents...");
        this._package.PDFMergeComplete += new PDFPackage.PDFMergeCompleteEventHandler(this.PDFMergeComplete);
        try
        {
          bool flag = true;
          if (this._package.PdfStreams.Count == 1)
          {
            this._resultingBytes = this._package.PdfStreams[0].ToArray();
            MyProject.Computer.FileSystem.WriteAllBytes(friendlyFilename, this._resultingBytes, false);
          }
          else
          {
            flag = this._package.CreatePackage(friendlyFilename);
            this._resultingBytes = this._package.ResultBytes;
          }
          if (!flag)
            throw new InvalidOperationException($"PDF Merge failed. Please verify all documents are valid PDFs. These seem to be the policy form ids that are corrupt {this.IdentifyCorruptFiles(this._package.PdfStreams)}");
          this.PackageCompleted(friendlyFilename);
        }
        finally
        {
          this._package.PDFMergeComplete -= new PDFPackage.PDFMergeCompleteEventHandler(this.PDFMergeComplete);
          if (!CompanyDocumentAutomation.BlackBoxMode)
            Cursor.Current = MgaCursors.Default;
        }
      }
    }
    if (this._package.PdfStreams.Count == 0)
    {
      if (this._emailBodySet || this._package.BrokenOutFileNames.Count > 0)
      {
        this.AllPDFsCreated();
      }
      else
      {
        if (CompanyDocumentAutomation.BlackBoxMode)
          throw new InvalidOperationException("Unable to create PDF package.");
        MDIControls.Instance.MDIParent.Invoke((Delegate) new MethodInvoker(this.ClosePleaseWaitForm));
        MGASystems.Common.ThreadingFunctions.MessageBox.Show("Unable to create PDF package.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
    }
    else
    {
      this._package.DoCleanup();
      GC.Collect();
    }
  }

  private string IdentifyCorruptFiles(List<MemoryStream> pdfStreams)
  {
    List<MemoryStream> memoryStreamList = new List<MemoryStream>();
    PdfFileEditor pdfFileEditor = new PdfFileEditor();
    MemoryStream memoryStream = new MemoryStream();
    List<int> intList = new List<int>();
    List<int> values = new List<int>();
    int num = pdfStreams.Count - 1;
    for (int index = 0; index <= num; ++index)
    {
      memoryStreamList.Add(pdfStreams[index]);
      if (!pdfFileEditor.Concatenate((Stream[]) memoryStreamList.ToArray(), (Stream) memoryStream))
      {
        intList.Add(index);
        AutomationDoc automationDoc = this._automationDocs[index];
        values.Add(automationDoc.PolicyFormID);
      }
      memoryStreamList.Remove(pdfStreams[index]);
    }
    return string.Join<int>(",", (IEnumerable<int>) values);
  }

  private void AttachSeparateNativeDocument(
    AutomationDoc doc,
    Document nativeWordDocument,
    Guid eventGuid)
  {
    string path = FilePath.Resolve(this.GetSeparateDocumentFilename(doc));
    nativeWordDocument.Save(path);
    int separateDocument = this.GetFolderIDForSeparateDocument(eventGuid, doc);
    Guid guid = DocumentManager.FileAddWithBind(path, separateDocument, Path.GetFileNameWithoutExtension(path), (ISupportDocumentSystem) this._quote, false);
    if (!(guid != Guid.Empty))
      return;
    this._nativeDocuments.Add(new CompanyDocumentAutomation.NativeDocument()
    {
      DocumentStoreGuid = guid,
      Filename = path,
      FileOnly = doc.FileOnly,
      IsExcelTempalte = false
    });
  }

  private void AttachSeparatePDFDocument(
    AutomationDoc doc,
    Document nativeWordDocument,
    Guid eventGuid,
    MemoryStream pdfStrem)
  {
    string fileName = FilePath.Resolve(this.GetSeparateDocumentFilename(doc));
    FileInfo fileInfo = new FileInfo(fileName);
    string path = fileName.Replace(fileInfo.Extension, ".pdf");
    File.WriteAllBytes(path, pdfStrem.ToArray());
    int separateDocument = this.GetFolderIDForSeparateDocument(eventGuid, doc);
    Guid guid = DocumentManager.FileAddWithBind(path, separateDocument, Path.GetFileNameWithoutExtension(path), (ISupportDocumentSystem) this._quote, false);
    if (!(guid != Guid.Empty))
      return;
    this._nativeDocuments.Add(new CompanyDocumentAutomation.NativeDocument()
    {
      DocumentStoreGuid = guid,
      Filename = path,
      FileOnly = doc.FileOnly,
      IsExcelTempalte = false
    });
  }

  private void AttachSeparateExcelAsPDFDocument(AutomationDoc doc, Guid eventGuid)
  {
    string path1 = FilePath.Resolve(Path.ChangeExtension(this.GetSeparateDocumentFilename(doc), ".pdf"));
    int separateDocument = this.GetFolderIDForSeparateDocument(eventGuid, doc);
    string path2 = doc.OriginalTemplateName;
    char[] invalidPathChars = Path.GetInvalidPathChars();
    int index = 0;
    while (index < invalidPathChars.Length)
    {
      char ch = invalidPathChars[index];
      path2 = path2.Replace(Conversions.ToString(ch), string.Empty);
      checked { ++index; }
    }
    string path3 = $"{MGATempFolder.MGATempPath}tmp{Guid.NewGuid().ToString().Substring(0, 8)}{Path.GetExtension(path2)}";
    File.WriteAllBytes(path3, doc.GetTemplateByteArray(this._quote.QuoteID));
    new Workbook(path3).Save(path1, (SaveFormat) 13);
    Guid guid = DocumentManager.FileAddWithBind(path1, separateDocument, Path.GetFileNameWithoutExtension(path1), (ISupportDocumentSystem) this._quote, false);
    if (!(guid != Guid.Empty))
      return;
    this._nativeDocuments.Add(new CompanyDocumentAutomation.NativeDocument()
    {
      DocumentStoreGuid = guid,
      Filename = path1,
      FileOnly = doc.FileOnly,
      IsExcelTempalte = false
    });
  }

  private void AttachSeparateExcelDocument(AutomationDoc doc, Guid eventGuid)
  {
    string path = FilePath.Resolve(this.GetSeparateDocumentFilename(doc));
    int separateDocument = this.GetFolderIDForSeparateDocument(eventGuid, doc);
    File.WriteAllBytes(path, doc.GetTemplateByteArray(this._quote.QuoteID));
    Guid guid = DocumentManager.FileAddWithBind(path, separateDocument, Path.GetFileNameWithoutExtension(path), (ISupportDocumentSystem) this._quote, false);
    if (!(guid != Guid.Empty))
      return;
    this._nativeDocuments.Add(new CompanyDocumentAutomation.NativeDocument()
    {
      DocumentStoreGuid = guid,
      Filename = path,
      FileOnly = doc.FileOnly,
      IsExcelTempalte = true
    });
  }

  private int GetFolderIDForSeparateDocument(Guid eventGuid, AutomationDoc doc)
  {
    int separateDocument;
    if (MGASystems.IMS.NoteDocuments.SystemSettings.GetSetting<bool>("DocumentAutomation.UseTemplateFolder", false))
      separateDocument = Utility.IsNull<int>(RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT FolderID FROM dbo.tblDocumentTemplates WITH(NOLOCK) WHERE TemplateID = @TemplateID", new object[2]
      {
        (object) "@TemplateID",
        (object) doc.TemplateID
      })), -1);
    else
      separateDocument = Utility.IsNull<int>(RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT dbo.GetDocumentFolder(@CompanyLineGuid,@AutomationEventGuid,@QuoteGuid)", new object[6]
      {
        (object) "@CompanyLineGuid",
        (object) this._quote.CompanyLineGuid,
        (object) "@AutomationEventGuid",
        (object) eventGuid,
        (object) "@QuoteGuid",
        (object) this._quote.QuoteGuid
      })), -1);
    return separateDocument;
  }

  private void PDFMergeComplete(object sender, EventArgs e) => this.BumpProgressBarProgress();

  private void GetTemplatesFromDatabase()
  {
    try
    {
      foreach (AutomationDoc automationDoc in this._automationDocs)
      {
        if (automationDoc.DocumentType == AutomationDoc.DocType.TemplateDocument)
        {
          CompanyDocumentAutomation.TemplateDoc templateDoc = new CompanyDocumentAutomation.TemplateDoc();
          string outputFileName = (string) null;
          if (!CompanyDocumentAutomation._temporaryDocsCache.TryGetValue(automationDoc.TemplateID, out outputFileName))
          {
            string path = automationDoc.OriginalTemplateName;
            char[] invalidPathChars = Path.GetInvalidPathChars();
            int index = 0;
            while (index < invalidPathChars.Length)
            {
              char ch = invalidPathChars[index];
              path = path.Replace(Conversions.ToString(ch), string.Empty);
              checked { ++index; }
            }
            outputFileName = $"{MGATempFolder.MGATempPath}tmp{Guid.NewGuid().ToString().Substring(0, 8)}{Path.GetExtension(path)}";
            this.SetProgressText($"Getting \"{CompanyDocumentAutomation.GetTemplateName(automationDoc.TemplateID)}\" template...");
            DocumentHandling documentHandling = new DocumentHandling(automationDoc.TemplateID);
            if (documentHandling.CompletedTemplateExists(this._quote.QuoteID))
              documentHandling.WriteCompletedTemplateToDisk(this._quote.QuoteID, outputFileName);
            else
              documentHandling.WriteTemplateToDisk(outputFileName);
            if (!CompanyDocumentAutomation._temporaryDocsCache.ContainsKey(automationDoc.TemplateID))
              CompanyDocumentAutomation._temporaryDocsCache.Add(automationDoc.TemplateID, outputFileName);
          }
          templateDoc.Filename = outputFileName;
          templateDoc.TemplateID = automationDoc.TemplateID;
          if (!this._tempDocs.ContainsKey(automationDoc.TemplateID))
            this._tempDocs.Add(automationDoc.TemplateID, templateDoc);
        }
        this.BumpProgressBarProgress();
      }
    }
    finally
    {
      List<AutomationDoc>.Enumerator enumerator;
      enumerator.Dispose();
    }
  }

  internal MemoryStream ConvertTemplateDocToPDF(CompanyDocumentAutomation.TemplateDoc docTemplate)
  {
    return this.ConvertTemplateDocToPDF(docTemplate, string.Empty, -1);
  }

  internal MemoryStream ConvertTemplateDocToPDF(
    CompanyDocumentAutomation.TemplateDoc docTemplate,
    int placedByCompanyLineID)
  {
    return this.ConvertTemplateDocToPDF(docTemplate, string.Empty, placedByCompanyLineID);
  }

  internal MemoryStream ConvertTemplateDocToPDF(
    CompanyDocumentAutomation.TemplateDoc docTemplate,
    int placedByCompanyLineID,
    int policyFormID)
  {
    return this.ConvertTemplateDocToPDF(docTemplate, string.Empty, placedByCompanyLineID, policyFormID);
  }

  internal MemoryStream ConvertTemplateDocToPDF(
    CompanyDocumentAutomation.TemplateDoc docTemplate,
    string oncePer,
    int placedByCompanyLineID)
  {
    return this.ConvertTemplateDocToPDF(docTemplate, oncePer, placedByCompanyLineID, -1);
  }

  internal MemoryStream ConvertTemplateDocToPDF(
    CompanyDocumentAutomation.TemplateDoc docTemplate,
    string oncePer)
  {
    return this.ConvertTemplateDocToPDF(docTemplate, oncePer, -1);
  }

  internal MemoryStream ConvertTemplateDocToPDF(
    CompanyDocumentAutomation.TemplateDoc docTemplate,
    string oncePer,
    int placedByCompanyLineID,
    int policyFormID)
  {
    CompanyDocumentAutomation.TemplateDoc docTemplate1 = docTemplate;
    string oncePer1 = oncePer;
    int placedByCompanyLineID1 = placedByCompanyLineID;
    int policyFormID1 = policyFormID;
    Document document = (Document) null;
    ref Document local = ref document;
    return this.ConvertTemplateDocToPDF(docTemplate1, oncePer1, placedByCompanyLineID1, policyFormID1, ref local);
  }

  internal MemoryStream ConvertTemplateDocToPDF(
    CompanyDocumentAutomation.TemplateDoc docTemplate,
    string oncePer,
    int placedByCompanyLineID,
    int policyFormID,
    ref Document mergedNativeWordDocument)
  {
    mergedNativeWordDocument = (Document) null;
    DataRow dataRow = DefaultDatabase.ExecuteDataRow(CommandType.Text, "SELECT AutomationGroupID, TemplateType, IsEmail FROM dbo.tblDocumentTemplates WITH(NOLOCK) WHERE TemplateID=@TID", new object[2]
    {
      (object) "@TID",
      (object) docTemplate.TemplateID
    });
    int integer = Conversions.ToInteger(dataRow[0]);
    string Left = (string) dataRow[1];
    bool isEmail = (bool) dataRow[2];
    MemoryStream pdf1;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "W", false) == 0)
    {
      object[] constructorArgs = new object[1]
      {
        this.GetConstructorArgument((int) Enum.Parse(typeof (MGASystems.IMS.Reporting.AutomationReports.Enums.AutomationDocGroups), integer.ToString()))
      };
      this.SetProgressText("Performing template merge...");
      Document doc;
      try
      {
        doc = new Document(docTemplate.Filename);
      }
      catch (IOException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        MGASystems.Common.ThreadingFunctions.MessageBox.Show($"The IMS was unable to convert the following file to PDF, because it is being used by another process:\n\n{docTemplate.Filename}\n\nPlease make sure that this document is not currently open in another application.", "Document In Use", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        pdf1 = (MemoryStream) null;
        ProjectData.ClearProjectError();
        goto label_37;
      }
      catch (UnsupportedFileFormatException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        MGASystems.Common.ThreadingFunctions.MessageBox.Show($"This Word document format is unsupported.\n\n{docTemplate.Filename}\n\nPlease make sure that this document is not in a pre-Word 97 format.", "Invalid Word Format", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        pdf1 = (MemoryStream) null;
        ProjectData.ClearProjectError();
        goto label_37;
      }
      catch (NullReferenceException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        MGASystems.Common.ThreadingFunctions.MessageBox.Show($"The IMS was unable to convert the following file to PDF:\n\n{docTemplate.Filename}\n\nPlease make sure that this document is not corrupt and can be opened by Microsoft Word.\n\nIf this problem persists, please send a copy of this document to technical support.", "Unable to Open Document", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        pdf1 = (MemoryStream) null;
        ProjectData.ClearProjectError();
        goto label_37;
      }
      DocumentHandling objectEx = (DocumentHandling) ObjectFactory.Instance.CreateObjectEX(typeof (DocumentHandling), (object) docTemplate.TemplateID);
      ArrayList arrayList = (ArrayList) null;
      if (!string.IsNullOrEmpty(oncePer))
        arrayList = CompanyDocumentAutomation.GetOncePerEntityIDs(oncePer, this.Quote.QuoteID);
      if (string.IsNullOrEmpty(oncePer) || arrayList.Count == 1)
      {
        if (string.IsNullOrEmpty(oncePer))
          objectEx.DoMerge(doc, constructorArgs, (object) null, placedByCompanyLineID, policyFormID);
        else
          objectEx.DoMerge(doc, constructorArgs, RuntimeHelpers.GetObjectValue(arrayList[0]), placedByCompanyLineID, policyFormID);
        mergedNativeWordDocument = doc;
      }
      else
      {
        Document destinationDocument = (Document) null;
        PdfFileEditor pdfFileEditor = new PdfFileEditor();
        try
        {
          foreach (object obj in arrayList)
          {
            object objectValue = RuntimeHelpers.GetObjectValue(obj);
            Document document = doc.Clone();
            objectEx.DoMerge(document, constructorArgs, RuntimeHelpers.GetObjectValue(objectValue), placedByCompanyLineID, policyFormID);
            if (destinationDocument == null)
              destinationDocument = document;
            else
              this.AppendDoc(destinationDocument, document);
          }
        }
        finally
        {
          IEnumerator enumerator;
          if (enumerator is IDisposable)
            (enumerator as IDisposable).Dispose();
        }
        if (destinationDocument != null)
        {
          doc = destinationDocument;
          mergedNativeWordDocument = destinationDocument;
        }
      }
      if (objectEx.GetQuoteOptionGuids() != null)
        this.AddQuoteOptionGuids(objectEx.GetQuoteOptionGuids());
      this._carbonCopyInhouseProducer = MGASystems.IMS.NoteDocuments.SystemSettings.GetSetting<bool>("CarbonCopySubmissionInhouseProducer", false);
      if (this._event != null)
        this._vpeSettings.EventGuid = this.EventGuid;
      this.AddCarbonCopyList(isEmail);
      if (isEmail)
      {
        this.ConvertTemplateToEmailBody(doc);
        pdf1 = (MemoryStream) null;
      }
      else
      {
        MemoryStream pdf2 = this.ConvertToPDF(docTemplate.TemplateID, doc);
        this.BumpProgressBarProgress();
        pdf1 = pdf2;
      }
    }
    else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "E", false) == 0)
    {
      string path1 = docTemplate.Filename;
      char[] invalidPathChars = Path.GetInvalidPathChars();
      int index = 0;
      while (index < invalidPathChars.Length)
      {
        char ch = invalidPathChars[index];
        path1 = path1.Replace(Conversions.ToString(ch), string.Empty);
        checked { ++index; }
      }
      string path2 = $"{MGATempFolder.MGATempPath}tmp{Guid.NewGuid().ToString().Substring(0, 8)}{Path.GetExtension(path1)}";
      string path3 = Path.ChangeExtension(path2, ".pdf");
      File.WriteAllBytes(path2, DefaultDatabase.ExecuteScalar<byte[]>("dbo.GetExcelTemplate", new object[4]
      {
        (object) "@QuoteID",
        (object) this.Quote.QuoteID,
        (object) "@TemplateID",
        (object) docTemplate.TemplateID
      }));
      new Workbook(path2).Save(path3, (SaveFormat) 13);
      pdf1 = new MemoryStream(File.ReadAllBytes(path3));
    }
    else
    {
      this.BumpProgressBarProgress(2);
      pdf1 = new MemoryStream(MyProject.Computer.FileSystem.ReadAllBytes(docTemplate.Filename));
    }
label_37:
    return pdf1;
  }

  private void ConvertTemplateToEmailBody(Document doc)
  {
    doc.ImagesSaveFolder = MGATempFolder.MGATempRandomFolderPath;
    MemoryStream memoryStream = new MemoryStream();
    doc.Save((Stream) memoryStream, (SaveFormat) 4);
    memoryStream.Position = memoryStream.Length;
    this._vpeSettings.EmailBodyHTML = memoryStream;
    this._emailBodySet = true;
  }

  public void AppendDoc(Document destinationDocument, Document sourceDocument)
  {
    sourceDocument.FirstSection.PageSetup.SectionStart = (SectionStart) 2;
    try
    {
      foreach (MGASystems.AsposeFacade.Words.Section section in (IEnumerable<MGASystems.AsposeFacade.Words.Section>) sourceDocument.Sections)
      {
        MGASystems.AsposeFacade.Words.Node node = destinationDocument.ImportNode(MGASystems.AsposeFacade.Words.Section.op_Implicit(section), true, (ImportFormatMode) 1);
        destinationDocument.AppendChild(node);
      }
    }
    finally
    {
      IEnumerator<MGASystems.AsposeFacade.Words.Section> enumerator;
      enumerator?.Dispose();
    }
  }

  private static ArrayList GetOncePerEntityIDs(string oncePer, int quoteId)
  {
    DataTable dataTable = DefaultDatabase.ExecuteDataTable("dbo.DocumentAutomation_GetInterestIDs", new object[6]
    {
      (object) "@quoteID",
      (object) quoteId,
      (object) "@interestType",
      (object) oncePer,
      (object) "@includeUnchanged",
      (object) MGASystems.IMS.NoteDocuments.SystemSettings.GetSetting<bool>("GetInterestInformation.IncludeUnchanged", false)
    });
    ArrayList oncePerEntityIds = new ArrayList();
    if (dataTable != null)
    {
      try
      {
        foreach (DataRow row in dataTable.Rows)
          oncePerEntityIds.Add(RuntimeHelpers.GetObjectValue(row[0]));
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
    }
    return oncePerEntityIds;
  }

  private MemoryStream ConvertToPDF(int templateId, Document doc)
  {
    this.BumpProgressBarProgress();
    this.SetProgressText($"Converting \"{CompanyDocumentAutomation.GetTemplateName(templateId)}\" to PDF...");
    MemoryStream pdf = (MemoryStream) null;
    try
    {
      pdf = Compatibility.SaveToPDF(doc);
    }
    catch (ApplicationException ex1)
    {
      ProjectData.SetProjectError((Exception) ex1);
      ApplicationException ex2 = ex1;
      CompanyDocumentAutomation.LogAsposePDFAction(nameof (ConvertToPDF), $"Exception Occurred: {ex2.Message}");
      if (!CompanyDocumentAutomation.BlackBoxMode)
      {
        this.ShowError((Exception) ex2);
      }
      else
      {
        ErrorHandler.SilentHandleError((Exception) ex2);
        if (ex2.InnerException != null)
          ErrorHandler.SilentHandleError(ex2.InnerException);
      }
      ProjectData.ClearProjectError();
    }
    return pdf;
  }

  private static string GetTemplateName(int templateID)
  {
    string templateName = (string) null;
    if (!CompanyDocumentAutomation._templateNames.TryGetValue(templateID, out templateName))
    {
      templateName = DefaultDatabase.ExecuteScalar<string>(CommandType.Text, "SELECT TemplateName FROM dbo.tblDocumentTemplates WITH(NOLOCK) WHERE TemplateID=@TID", new object[2]
      {
        (object) "@TID",
        (object) templateID
      });
      CompanyDocumentAutomation._templateNames[templateID] = templateName;
    }
    return templateName;
  }

  private MemoryStream ConvertAutomationReportToPDF(Guid automationReportGuid)
  {
    return this.ConvertAutomationReportToPDF(automationReportGuid, -1);
  }

  private MemoryStream ConvertAutomationReportToPDF(
    Guid automationReportGuid,
    int placedByCompanyLineID)
  {
    object objectValue = RuntimeHelpers.GetObjectValue(this.GetAutomationReport(automationReportGuid, placedByCompanyLineID));
    MemoryStream pdf;
    if (objectValue != null)
    {
      this.AutomationRptGuid = automationReportGuid;
      if (objectValue is IIssuancePrintType issuancePrintType)
        issuancePrintType.SetPrintType(this._printTypeID);
      SectionReport sectionReport = this.GetAutomationReport(automationReportGuid, placedByCompanyLineID) as SectionReport;
      if (this.GetAutomationReport(automationReportGuid, placedByCompanyLineID) is IGenericReport automationReport)
      {
        RunCompletedResult runCompletedResult = automationReport.Run((object) null);
        switch (runCompletedResult.ResultType)
        {
          case GenericReportResultType.PDFByteArray:
            byte[] result = (byte[]) runCompletedResult.Result;
            if (!(runCompletedResult.Result is MemoryStream) && result != null)
            {
              pdf = new MemoryStream(result);
              goto label_18;
            }
            break;
          case GenericReportResultType.ActiveReport:
            if (sectionReport == null)
            {
              sectionReport = runCompletedResult.Result as SectionReport;
              break;
            }
            break;
        }
      }
      if (sectionReport != null)
      {
        sectionReport.Run();
        using (PdfExport pdfExport = new PdfExport())
        {
          MemoryStream memoryStream = new MemoryStream();
          string setting = MGASystems.IMS.NoteDocuments.SystemSettings.GetSetting<string>("DocumentAutomation.NeverEmbedFonts");
          if (!string.IsNullOrEmpty(setting))
            pdfExport.NeverEmbedFonts = setting;
          pdfExport.Export(sectionReport.Document, (Stream) memoryStream);
          pdf = memoryStream.Length != 0L ? memoryStream : (MemoryStream) null;
          goto label_18;
        }
      }
    }
    pdf = (MemoryStream) null;
label_18:
    return pdf;
  }

  protected virtual Guid[] SelectOneOptionPerLine()
  {
    Guid[] guidArray1;
    if (!CompanyDocumentAutomation.BlackBoxMode && MDIControls.Instance.MDIParent.InvokeRequired)
    {
      ErrorHandler.HandleErrorOnThread((Control) MDIControls.Instance.MDIParent, (Exception) new InvalidOperationException("Must be called on the UI thread"));
      guidArray1 = (Guid[]) null;
    }
    else
    {
      Guid[] guidArray2 = (Guid[]) null;
      using (frmSelectOneOptionPerLine formEx = (frmSelectOneOptionPerLine) ObjectFactory.Instance.CreateFormEX(typeof (frmSelectOneOptionPerLine), (object) this.QuoteGuid))
      {
        formEx.ShowInTaskbar = false;
        if (formEx.IsOnlyOneOptionPerLine)
        {
          formEx.AutoSave();
        }
        else
        {
          CompanyDocumentAutomation._frmPleaseWait.Visible = false;
          int num = (int) formEx.ShowDialog();
          CompanyDocumentAutomation._frmPleaseWait.Visible = true;
          CompanyDocumentAutomation._frmPleaseWait.Refresh();
        }
        guidArray2 = formEx.QuoteOptionGuids;
      }
      guidArray1 = guidArray2;
    }
    return guidArray1;
  }

  private Guid[] GetQuoteOptionGuids(Guid quoteGuid)
  {
    Guid[] quoteOptionGuids;
    if (!CompanyDocumentAutomation.BlackBoxMode && !MDIControls.Instance.BlackBoxMode && MDIControls.Instance != null && MDIControls.Instance.MDIParent != null && MDIControls.Instance.MDIParent.InvokeRequired)
    {
      quoteOptionGuids = (Guid[]) MDIControls.Instance.MDIParent.Invoke((Delegate) new CompanyDocumentAutomation.GetQuoteOptionGuidsHandler(this.GetQuoteOptionGuids), (object) quoteGuid);
    }
    else
    {
      Quote quote = new Quote(quoteGuid);
      if (quote.IsBound)
        quoteOptionGuids = quote.GetBoundOptionGuids();
      else if (quote.OptionCount == 0)
        quoteOptionGuids = (Guid[]) null;
      else if (quote.OptionCount == 1)
        quoteOptionGuids = new Guid[1]
        {
          DefaultDatabase.ExecuteScalar<Guid>(CommandType.Text, "SELECT TOP 1 QuoteOptionGuid FROM dbo.tblQuoteOptions WITH(NOLOCK) WHERE QuoteGuid = @QuoteGuid", new object[2]
          {
            (object) "@QuoteGuid",
            (object) quoteGuid
          })
        };
      else
        quoteOptionGuids = this.SelectOneOptionPerLine();
    }
    return quoteOptionGuids;
  }

  private Guid[] QuoteOptionGuids
  {
    get => this._quoteOptionGuids.Count <= 0 ? (Guid[]) null : this._quoteOptionGuids.ToArray();
  }

  private object GetAutomationReport(Guid automationReportGuid)
  {
    return this.GetAutomationReport(automationReportGuid, -1);
  }

  private object GetAutomationReport(Guid automationReportGuid, int companyLineID)
  {
    Type baseType = (Type) null;
    if (Cache.AutomationReportMap.TryGetValue(automationReportGuid, out baseType))
    {
      AutomationReportAttribute automationReportAttribute = baseType.GetCustomAttributes(typeof (AutomationReportAttribute), false).Cast<AutomationReportAttribute>().FirstOrDefault<AutomationReportAttribute>((System.Func<AutomationReportAttribute, bool>) ([SpecialName] (r) => r.AutomationReportGuid.Equals(automationReportGuid)));
      if (automationReportAttribute != null)
      {
        object objectValue1 = RuntimeHelpers.GetObjectValue(this.GetConstructorArgument((int) automationReportAttribute.Group));
        object objectValue2 = RuntimeHelpers.GetObjectValue(ObjectFactory.Instance.CreateObjectEX(baseType, objectValue1));
        if (objectValue2 is IStateSpecific stateSpecific)
          stateSpecific.PlacedByCompanyLineID(companyLineID);
        if (objectValue2 is IQuoteDocument quoteDocument)
        {
          Guid quoteGuid = (Guid) objectValue1;
          if (!quoteDocument.RequiresQuoteOptionGuids())
            return objectValue2;
          this.AddQuoteOptionGuids(this.GetQuoteOptionGuids(quoteGuid));
          if (this._quoteOptionGuids.Count <= 0)
            return (object) null;
          quoteDocument.SetQuoteOptionGuids(this.QuoteOptionGuids);
          return objectValue2;
        }
      }
      throw new InvalidOperationException($"No automation report was found for this guid ({automationReportGuid.ToString()})");
    }
    AdHocQuoteDocumentDisplay automationReport;
    try
    {
      automationReport = new AdHocQuoteDocumentDisplay(new object[2]
      {
        (object) automationReportGuid,
        (object) this.QuoteGuid
      });
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      throw new InvalidOperationException($"No automation report was found for this guid ({automationReportGuid.ToString()})");
    }
    if (automationReport.AdHocReport.CompanyLineIDRequirement)
      automationReport.PlacedByCompanyLineID(companyLineID);
    if (automationReport.AdHocReport.QuoteOptionRequirement)
      automationReport.SetQuoteOptionGuids(this.GetQuoteOptionGuids(this.QuoteGuid));
    return (object) automationReport;
  }

  private void AddQuoteOptionGuids(Guid[] quoteOptionGuids)
  {
    if (quoteOptionGuids == null)
      return;
    Guid[] guidArray = quoteOptionGuids;
    int index = 0;
    while (index < guidArray.Length)
    {
      Guid guid = guidArray[index];
      if (!this._quoteOptionGuids.Contains(guid))
        this._quoteOptionGuids.Add(guid);
      checked { ++index; }
    }
  }

  protected virtual string GetClientSpecificFriendlyFileName(Quote q)
  {
    string str = q.InsuredPolicyName;
    if (str.Length > 100)
      str = str.Substring(0, 99);
    return str.Replace(" ", string.Empty).Replace("/", string.Empty).Replace("\\", string.Empty);
  }

  private string GetSeparateDocumentFilename(AutomationDoc doc)
  {
    if (doc.DocumentType != AutomationDoc.DocType.TemplateDocument)
      throw new ArgumentException("Parameter must be a template document", nameof (doc));
    string str1 = string.IsNullOrEmpty(doc.SeparateDocumentName) || doc.SeparateDocumentName.Trim().Length == 0 ? doc.TemplateName : doc.SeparateDocumentName;
    char[] invalidPathChars = Path.GetInvalidPathChars();
    int index = 0;
    while (index < invalidPathChars.Length)
    {
      char ch = invalidPathChars[index];
      str1 = str1.Replace(Conversions.ToString(ch), string.Empty);
      checked { ++index; }
    }
    string path1 = str1.Replace(":", string.Empty);
    int num = 1;
    string str2 = path1;
    string str3 = Path.GetExtension(doc.OriginalTemplateName);
    if (Path.HasExtension(path1))
      str3 = Path.GetExtension(path1);
    string path2 = MGATempFolder.MGATempPath + path1 + str3;
    bool flag;
    while (!flag)
    {
      if (File.Exists(path2))
      {
        try
        {
          File.Delete(path2);
          flag = true;
        }
        catch (IOException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          path2 = MGATempFolder.MGATempPath + str2 + num.ToString() + str3;
          ++num;
          ProjectData.ClearProjectError();
        }
        catch (UnauthorizedAccessException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          path2 = MGATempFolder.MGATempPath + str2 + num.ToString() + str3;
          ++num;
          ProjectData.ClearProjectError();
        }
      }
      else
        flag = true;
    }
    return path2;
  }

  private string GetFileOnlyFilename(AutomationDoc doc)
  {
    if (doc.DocumentType != AutomationDoc.DocType.TemplateDocument)
      throw new ArgumentException("Parameter must be a template document", nameof (doc));
    string str1 = string.IsNullOrEmpty(doc.FileOnlyName) || doc.FileOnlyName.Trim().Length == 0 ? "FileOnly_" + doc.TemplateName : doc.FileOnlyName;
    char[] invalidPathChars = Path.GetInvalidPathChars();
    int index = 0;
    while (index < invalidPathChars.Length)
    {
      char ch = invalidPathChars[index];
      str1 = str1.Replace(Conversions.ToString(ch), string.Empty);
      checked { ++index; }
    }
    string str2 = str1.Replace(":", string.Empty);
    int num = 1;
    string str3 = str2;
    string path = $"{MGATempFolder.MGATempPath}{str2}.pdf";
    bool flag;
    while (!flag)
    {
      if (File.Exists(path))
      {
        try
        {
          File.Delete(path);
          flag = true;
        }
        catch (IOException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          path = $"{MGATempFolder.MGATempPath}{str3}{num.ToString()}.pdf";
          ++num;
          ProjectData.ClearProjectError();
        }
        catch (UnauthorizedAccessException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          path = $"{MGATempFolder.MGATempPath}{str3}{num.ToString()}.pdf";
          ++num;
          ProjectData.ClearProjectError();
        }
      }
      else
        flag = true;
    }
    return path;
  }

  public string GetFriendlyFilename()
  {
    string friendlyFilename;
    if (!this.QuoteGuid.Equals(Guid.Empty))
    {
      string str1 = this.GetClientSpecificFriendlyFileName(new Quote(this.QuoteGuid));
      char[] invalidPathChars = Path.GetInvalidPathChars();
      int index1 = 0;
      while (index1 < invalidPathChars.Length)
      {
        char ch = invalidPathChars[index1];
        str1 = str1.Replace(Conversions.ToString(ch), string.Empty);
        checked { ++index1; }
      }
      char[] invalidFileNameChars = Path.GetInvalidFileNameChars();
      int index2 = 0;
      while (index2 < invalidFileNameChars.Length)
      {
        char ch = invalidFileNameChars[index2];
        str1 = str1.Replace(Conversions.ToString(ch), string.Empty);
        checked { ++index2; }
      }
      string str2 = Regex.Replace(str1.Replace(":", string.Empty), "(^|\\\\\\\\)(AUX|CLOCK[$]|COM1|COM2|COM3|COM4|COM5|COM6|COM7|COM8|COM9|CON|LPT1|LPT2|LPT3|LPT4|LPT5|LPT6|LPT7|LPT8|LPT9|NUL|PRN)(\\\\\\\\|[.])?", "$1$2_$3");
      int num = 1;
      string str3 = str2;
      string path = $"{MGATempFolder.MGATempPath}{str2}.pdf";
      while (CompanyDocumentAutomation.BlackBoxMode && File.Exists(path))
      {
        path = $"{MGATempFolder.MGATempPath}{str3}{num:00}.pdf";
        ++num;
      }
      bool flag;
      while (!flag)
      {
        if (File.Exists(path))
        {
          try
          {
            File.Delete(path);
            flag = true;
          }
          catch (IOException ex)
          {
            ProjectData.SetProjectError((Exception) ex);
            path = $"{MGATempFolder.MGATempPath}{str3}{num:00}.pdf";
            ++num;
            ProjectData.ClearProjectError();
          }
          catch (UnauthorizedAccessException ex)
          {
            ProjectData.SetProjectError((Exception) ex);
            path = $"{MGATempFolder.MGATempPath}{str3}{num:00}.pdf";
            ++num;
            ProjectData.ClearProjectError();
          }
        }
        else
          flag = true;
      }
      friendlyFilename = path;
    }
    else
      friendlyFilename = $"{MGATempFolder.MGATempPath}IMS_Package_{Guid.NewGuid().ToString().Substring(0, 8)}.pdf";
    return friendlyFilename;
  }

  public int SaveToFolder(Guid eventGuid, int folderId, string fileName, string description)
  {
    int folder;
    try
    {
      if (MGASystems.IMS.NoteDocuments.SystemSettings.GetSetting<bool>("SaveAutomationReport", false))
      {
        string setting = MGASystems.IMS.NoteDocuments.SystemSettings.GetSetting<string>("SaveAutomationReport");
        if (string.IsNullOrEmpty(setting))
        {
          folder = folderId;
          goto label_22;
        }
        XmlDocument xmlDocument = new XmlDocument();
        xmlDocument.LoadXml(setting);
        XmlNodeList xmlNodeList = xmlDocument.SelectNodes("ReportList/Report");
        try
        {
          foreach (XmlNode xnReport in xmlNodeList)
          {
            string Right1 = string.Empty;
            string Right2 = string.Empty;
            if (xnReport.SelectSingleNode("@AutomationReportGuid") != null)
              Right1 = xnReport.SelectSingleNode("@AutomationReportGuid").InnerText;
            if (string.IsNullOrEmpty(Right1) || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.AutomationRptGuid.ToString(), Right1, false) == 0)
            {
              if (xnReport.SelectSingleNode("@EventGuid") != null)
                Right2 = xnReport.SelectSingleNode("@EventGuid").InnerText;
              if (string.IsNullOrEmpty(Right2) | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(eventGuid.ToString(), Right2, false) == 0)
              {
                bool result = false;
                if (folderId == -1 || xnReport.SelectSingleNode("@OverrideFolder") != null && bool.TryParse(xnReport.SelectSingleNode("@OverrideFolder").InnerText, out result) && result)
                {
                  int.TryParse(xnReport.SelectSingleNode("@FolderId").InnerText, out folderId);
                  if (this.OverrideFileName(fileName, xnReport) && !fileName.Equals(this.FileNameSaveAs, StringComparison.OrdinalIgnoreCase))
                  {
                    if (File.Exists(this.FileNameSaveAs))
                      File.Delete(this.FileNameSaveAs);
                    File.Copy(fileName, this.FileNameSaveAs);
                    File.Delete(fileName);
                  }
                }
              }
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
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      ProjectData.ClearProjectError();
    }
    folder = folderId;
label_22:
    return folder;
  }

  private bool OverrideFileName(string fileName, XmlNode xnReport)
  {
    bool flag;
    try
    {
      string empty = string.Empty;
      XmlNodeList xmlNodeList = xnReport.SelectNodes("NamingConvention/Name");
      if (xmlNodeList.Count > 0)
      {
        DataSet dataSet = DefaultDatabase.ExecuteDataSet("dbo.GetPolicyInfoForRptSave", new object[2]
        {
          (object) "@QuoteGuid",
          (object) this.QuoteGuid
        });
        if (dataSet.Tables[0].Rows.Count > 0)
        {
          int count = xmlNodeList.Count;
          for (int index = 1; index <= count; ++index)
          {
            if (xnReport.SelectSingleNode($"NamingConvention/Name[@index='{Conversions.ToString(index)}']") != null)
            {
              XmlNode xn = xnReport.SelectSingleNode($"NamingConvention/Name[@index='{Conversions.ToString(index)}']");
              string input = string.Empty;
              if (xn.Attributes["fieldName"] != null)
              {
                string innerText = xn.Attributes["fieldName"].InnerText;
                if (!string.IsNullOrEmpty(innerText) && dataSet.Tables[0].Rows[0] != null)
                {
                  DataRow row = dataSet.Tables[0].Rows[0];
                  if (dataSet.Tables[0].Columns.Contains(innerText))
                    input = dataSet.Tables[0].Rows[0][innerText].ToString();
                }
              }
              else
                input = xnReport.SelectSingleNode($"NamingConvention/Name[@index='{Conversions.ToString(index)}']").InnerText.Replace("@", " ");
              string str = new Regex(" *[\\\\~#%&*{}/:<>?|\\']+ *").Replace(input, " ");
              empty += this.MaxStringLength(str, xn);
            }
          }
        }
      }
      if (!string.IsNullOrEmpty(empty))
      {
        this.FileDescriptionSaveAs = empty;
        this.FileNameSaveAs = $"{MGATempFolder.MGATempPath}{empty.Replace("-", " ")}.pdf";
        flag = true;
        goto label_16;
      }
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      ProjectData.ClearProjectError();
    }
    flag = false;
label_16:
    return flag;
  }

  private string MaxStringLength(string value, XmlNode xn)
  {
    if (xn.Attributes["maxlength"] != null)
    {
      int result = 50;
      int.TryParse(xn.Attributes["maxlength"].InnerText, out result);
      if (value.Length > result)
        value = value.Substring(0, result);
    }
    return value;
  }

  protected virtual void AddCarbonCopyList(bool isEmail)
  {
    if (isEmail || this._carbonCopyInhouseProducer)
      this._vpeSettings.CCList = this.GetClientCarbonCopyList(this._quoteGuid, this._event);
    this._vpeSettings.CCList = SecondaryProducerContactEmail.SetSecondaryProducerCarbonCopyEmail(this._quoteGuid, this._vpeSettings.CCList);
  }

  protected virtual string[] GetClientCarbonCopyList(
    Guid quoteGuid,
    Messaging.MessageEventArgs eventArgs)
  {
    string[] ccList = this._vpeSettings.CCList;
    string[] clientCarbonCopyList;
    if (this._carbonCopyInhouseProducer)
    {
      DataTable dataTable = DefaultDatabase.ExecuteDataTable("dbo.spGetSubmissionInhouseProducerEmail", new object[2]
      {
        (object) "@QuoteGuid",
        (object) this._quoteGuid
      });
      if (dataTable.Rows.Count == 0)
      {
        clientCarbonCopyList = ccList;
      }
      else
      {
        HashSet<string> source = new HashSet<string>((IEnumerable<string>) ccList, (IEqualityComparer<string>) StringComparer.InvariantCultureIgnoreCase);
        try
        {
          foreach (DataRow row in dataTable.Rows)
          {
            if (row[0] != DBNull.Value)
              source.Add(row[0].ToString());
          }
        }
        finally
        {
          IEnumerator enumerator;
          if (enumerator is IDisposable)
            (enumerator as IDisposable).Dispose();
        }
        clientCarbonCopyList = source.ToArray<string>();
      }
    }
    else
      clientCarbonCopyList = ccList;
    return clientCarbonCopyList;
  }

  public void Dispose()
  {
    this.DisposePleaseWaitForm();
    if (this._frmInitialPleaseWait == null || this._frmInitialPleaseWait.Disposing)
      return;
    if (this._frmInitialPleaseWait.IsDisposed)
      return;
    try
    {
      this._frmInitialPleaseWait.Close();
      this._frmInitialPleaseWait.Dispose();
      this._frmInitialPleaseWait = (frmPleaseWaitNoProgress) null;
    }
    catch (InvalidOperationException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      ProjectData.ClearProjectError();
    }
  }

  public class TemplateDoc
  {
    public string Filename;
    public int TemplateID;
  }

  public class NativeDocument
  {
    public string Filename;
    public Guid DocumentStoreGuid;
    public bool FileOnly;
    public bool IsExcelTempalte;
  }

  private delegate void ShowViewPrintEmailFormHandler(List<string> emails);

  private delegate void ShowErrorHandler(Exception ex);

  private delegate bool ModifyTemplateDocsHandler();

  private delegate void SetProgressBarMaxHandler(int max);

  private delegate void BumpProgressBarMaxHandler(int amount);

  private delegate void SetProgressTextHandler(string text);

  private delegate Guid[] GetQuoteOptionGuidsHandler(Guid quoteGuid);
}
