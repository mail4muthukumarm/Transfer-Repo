// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Reporting.MGAReport
// Assembly: MgaSystems.IMS.Reporting, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D0217E27-C87B-4FD0-8041-819EA70A118B
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Reporting.dll

using DDCssLib;
using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.Document.Section;
using GrapeCity.ActiveReports.Export.Excel.Section;
using GrapeCity.ActiveReports.Export.Pdf.Section;
using GrapeCity.ActiveReports.Export.Word.Section;
using GrapeCity.ActiveReports.Viewer.Win;
using MGASystems.AsposeFacade.Words;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.IMS.NoteDocuments.DocumentSystem;
using MGASystems.IMS.Reporting.AutomationReports;
using MGASystems.IMS.Security;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Reporting;

public class MGAReport : SectionReport, ICancelSqlCommand
{
  private bool _showPageNumbers;
  private bool _showPrintDateAndTime;
  private Guid _currentUserGuid;
  private List<SqlCommand> _commands;
  private int _ReportLogID;
  private Guid _ReportQuoteGuid;
  private MGAReportData _reportData;
  private string _defaultFileName;

  public int ReportLogID
  {
    get => this._ReportLogID;
    set => this._ReportLogID = value;
  }

  public Guid CurrentUserGuid
  {
    get => this._currentUserGuid;
    set => this._currentUserGuid = value;
  }

  public virtual bool HasRecords
  {
    get
    {
      if (this.DataSource == null || (object) this.DataSource.GetType() == (object) typeof (DataTable) && ((DataTable) this.DataSource).Rows.Count == 0)
        return false;
      return (object) this.DataSource.GetType() != (object) typeof (DataView) || ((DataView) this.DataSource).Count != 0;
    }
  }

  public virtual bool ExcelOnly => false;

  public virtual bool IsThreaded => false;

  public virtual Guid ReportQuoteGuid
  {
    get => this._ReportQuoteGuid;
    set => this._ReportQuoteGuid = value;
  }

  public string DefaultFileName
  {
    get => this._defaultFileName;
    set => this._defaultFileName = DocumentManager.EnsureProperFileName(value);
  }

  public List<SqlCommand> CommandsToCancel
  {
    get
    {
      if (this._commands == null)
        this._commands = new List<SqlCommand>();
      return this._commands;
    }
  }

  public MGAReportData ReportData => this._reportData;

  public MGAReport()
  {
    this.ReportEnd += new EventHandler(this.MGAReport_ReportEnd);
    this._showPageNumbers = false;
    this._showPrintDateAndTime = true;
    this._ReportLogID = -1;
    this._reportData = new MGAReportData();
    this._defaultFileName = "";
    AppDomain.CurrentDomain.FirstChanceException += new EventHandler<FirstChanceExceptionEventArgs>(this.OnFirstChanceException);
  }

  private void OnFirstChanceException(object sender, FirstChanceExceptionEventArgs e)
  {
    MGAReport mgaReport = this;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(e.Exception.GetType().Name, "FileNotFoundException", false) == 0)
      return;
    AppDomain.CurrentDomain.FirstChanceException -= new EventHandler<FirstChanceExceptionEventArgs>(this.OnFirstChanceException);
    string str = e.Exception.Message + "\r\n";
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(e.Exception.GetType().Name, "SqlException", false) == 0)
    {
      SqlException exception = (SqlException) e.Exception;
      str = $"{str}LineNumber:{exception.LineNumber.ToString()}\r\n";
      str = $"{str}Procedure:{exception.Procedure.ToString()}\r\n";
      str = $"{str}Server:{exception.Server.ToString()}";
    }
    if (this._ReportLogID <= 0)
      return;
    DefaultDatabase.ExecuteTransaction((EventHandler<ExecuteTransactionEventArgs>) ([SpecialName] (tmpObject, transArgs) =>
    {
      DefaultDatabase.ExecuteNonQuery("LogReportActionUpdate", new object[4]
      {
        (object) "@LogID",
        (object) mgaReport._ReportLogID,
        (object) "@ErrorMessage",
        (object) str
      });
      transArgs.Transaction.Commit();
    }));
  }

  public virtual void Hyperlink(object sender, HyperLinkEventArgs e)
  {
  }

  public virtual void ExportToExcel(string SaveFileTo)
  {
    XlsExport xlsExport = (XlsExport) null;
    try
    {
      xlsExport = new XlsExport();
      xlsExport.FileFormat = !(SaveFileTo.Contains(".xls") & SaveFileTo.LastIndexOf(".xls") == SaveFileTo.Length - 4) ? (FileFormat) 2 : (FileFormat) 0;
      xlsExport.Export(this.Document, SaveFileTo);
    }
    finally
    {
      ((Component) xlsExport)?.Dispose();
    }
  }

  public virtual void Email() => this.Email(MGAReport.EmailAttachmentFormat.PDF);

  public void Email(MGAReport.EmailAttachmentFormat AttachmentFormat)
  {
    this.Email(AttachmentFormat, "");
  }

  public void Email(MGAReport.EmailAttachmentFormat AttachmentFormat, string EmailTo)
  {
    string Subject = "report";
    SecureReportResourceAttribute searchAttribute = new SecureReportResourceAttribute();
    SecureReportResourceAttribute attributeFromType = (SecureReportResourceAttribute) ObjectFactory.GetAttributeFromType(((object) this).GetType(), (Attribute) searchAttribute);
    if (Information.IsNothing((object) attributeFromType))
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((object) this).GetType().Name, "AdHocReportDisplay", false) == 0)
        Subject = DefaultDatabase.ExecuteScalar<string>(CommandType.Text, "SELECT ReportName FROM tblAdHocReports WHERE ReportGUID=@R", new object[2]
        {
          (object) "@R",
          (object) ((AdHocReportDisplay) this).ReportGuid
        });
    }
    else
      Subject = attributeFromType.Name;
    if (Strings.InStr(Strings.UCase(Subject), "REPORT") == 0)
      Subject += " report";
    this.Email(AttachmentFormat, EmailTo, Subject);
  }

  public void Email(
    MGAReport.EmailAttachmentFormat AttachmentFormat,
    string EmailTo,
    string Subject)
  {
    string Body = "Attached please find the " + Subject;
    this.Email(AttachmentFormat, EmailTo, Subject, Body);
  }

  public void Email(
    MGAReport.EmailAttachmentFormat AttachmentFormat,
    string EmailTo,
    string Subject,
    string Body)
  {
    this.Email(AttachmentFormat, EmailTo, Subject, Body, "");
  }

  public void Email(
    MGAReport.EmailAttachmentFormat AttachmentFormat,
    string EmailTo,
    string Subject,
    string Body,
    string EmailCc)
  {
    this.Email(AttachmentFormat, EmailTo, Subject, Body, EmailCc, "", false, false);
  }

  public void Email(
    MGAReport.EmailAttachmentFormat AttachmentFormat,
    string EmailTo,
    string Subject,
    string Body,
    string EmailCc,
    string AttachmentFileName)
  {
    this.Email(AttachmentFormat, EmailTo, Subject, Body, EmailCc, AttachmentFileName, false, false);
  }

  public void Email(
    MGAReport.EmailAttachmentFormat AttachmentFormat,
    string EmailTo,
    string Subject,
    string Body,
    string EmailCc,
    string AttachmentFileName,
    bool SendImmedeatly,
    bool HTMLBody)
  {
    string tempPath = Path.GetTempPath();
    char[] invalidFileNameChars = Path.GetInvalidFileNameChars();
    List<string> attachmentPaths = new List<string>();
    List<string> recipients = new List<string>();
    List<string> ccList = new List<string>();
    string str1 = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DefaultFileName.Trim(), "", false) == 0 ? Subject : this.DefaultFileName.Trim();
    bool flag1 = false;
    Guid guid;
    if (((object) this).GetType().GetMethod(nameof (Email), Type.EmptyTypes).DeclaringType != typeof (MGAReport))
      flag1 = true;
    else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((object) this).GetType().Name, "AdHocReportDisplay", false) == 0)
    {
      guid = ((AdHocReportDisplay) this).ReportGuid;
    }
    else
    {
      Attribute attributeFromType = ObjectFactory.GetAttributeFromType(((object) this).GetType(), (Attribute) new SecureReportResourceAttribute());
      if (attributeFromType != null)
        guid = ((SecureResourceAttribute) attributeFromType).UniqueIdentifier;
    }
    char[] chArray = invalidFileNameChars;
    int index1 = 0;
    while (index1 < chArray.Length)
    {
      char ch = chArray[index1];
      if (Strings.InStr(str1, Conversions.ToString(ch)) > 0)
        str1 = Strings.Replace(str1, Conversions.ToString(ch), "_");
      checked { ++index1; }
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(AttachmentFileName, "", false) == 0)
    {
      switch (AttachmentFormat)
      {
        case MGAReport.EmailAttachmentFormat.XLS:
          str1 += ".xls";
          this.ExportToExcel(tempPath + str1);
          break;
        case MGAReport.EmailAttachmentFormat.PDF:
          str1 += ".pdf";
          new PdfExport().Export(this.Document, tempPath + str1);
          break;
        case MGAReport.EmailAttachmentFormat.RTF:
          str1 += ".rtf";
          new RtfExport().Export(this.Document, tempPath + str1);
          break;
      }
      attachmentPaths.Add(tempPath + str1);
    }
    else
    {
      string str2 = AttachmentFileName;
      attachmentPaths.Add(str2);
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Strings.Trim(EmailCc), "", false) != 0)
    {
      if (Strings.InStr(EmailCc, ";") == 0)
      {
        ccList.Add(EmailCc);
      }
      else
      {
        string[] strArray = EmailCc.Split(';');
        int index2 = 0;
        while (index2 < strArray.Length)
        {
          string str3 = strArray[index2];
          ccList.Add(EmailCc);
          checked { ++index2; }
        }
      }
      if (Strings.InStr(EmailCc, ",") > 0)
      {
        ccList.Clear();
        string[] strArray = EmailCc.Split(',');
        int index3 = 0;
        while (index3 < strArray.Length)
        {
          string str4 = strArray[index3];
          ccList.Add(str4);
          checked { ++index3; }
        }
      }
    }
    else
      ccList.Add("");
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Strings.Trim(EmailTo), "", false) != 0)
    {
      if (Strings.InStr(EmailTo, ";") == 0)
      {
        recipients.Add(EmailTo);
      }
      else
      {
        string[] strArray = EmailTo.Split(';');
        int index4 = 0;
        while (index4 < strArray.Length)
        {
          string str5 = strArray[index4];
          recipients.Add(EmailTo);
          checked { ++index4; }
        }
      }
      if (Strings.InStr(EmailTo, ",") > 0)
      {
        recipients.Clear();
        string[] strArray = EmailTo.Split(',');
        int index5 = 0;
        while (index5 < strArray.Length)
        {
          string str6 = strArray[index5];
          recipients.Add(str6);
          checked { ++index5; }
        }
      }
    }
    else
    {
      recipients.Add("");
      SendImmedeatly = false;
    }
    if (!flag1)
    {
      DataRow dataRow = DefaultDatabase.ExecuteDataRow(CommandType.Text, "SELECT TOP 1 TemplateID, SubjectLine  FROM tblEmailTemplatesForReports WHERE ReportGUID = @ReportGUID", new object[2]
      {
        (object) "@ReportGUID",
        (object) guid
      });
      int result;
      bool flag2;
      if (!dataRow.IsNull("TemplateID"))
        flag2 = int.TryParse(dataRow["TemplateID"].ToString(), out result);
      if (flag2)
      {
        Subject = dataRow["SubjectLine"].ToString();
        Guid QuoteGuid = !this._ReportQuoteGuid.Equals(Guid.Empty) ? this._ReportQuoteGuid : DefaultDatabase.ExecuteScalar<Guid>(CommandType.Text, "SELECT TOP 1 tblQuotes.QuoteGUID FROM tblQuotes INNER JOIN tblMaxQuoteIDs ON tblQuotes.QuoteID = tblMaxQuoteIDs.MaxBoundQuoteID ORDER BY tblQuotes.QuoteID DESC");
        Body = this.GetEmailBodyFromTemplate(result, QuoteGuid);
        HTMLBody = true;
      }
    }
    if (SendImmedeatly)
      SMTP_Email.SendUsingOutlook(attachmentPaths, recipients, Subject, Body, ccList, SMTP_Email.ShowOrSend.Send, false, HTMLBody);
    else
      SMTP_Email.SendUsingOutlook(attachmentPaths, recipients, Subject, Body, ccList, SMTP_Email.ShowOrSend.Show, false, HTMLBody);
  }

  private string GetEmailBodyFromTemplate(int templateID, Guid QuoteGuid)
  {
    string bodyFromTemplate = "";
    MemoryStream memoryStream = new MemoryStream();
    StreamReader streamReader = new StreamReader((Stream) memoryStream);
    try
    {
      int num = (int) Enum.Parse(typeof (Enums.AutomationDocGroups), DefaultDatabase.ExecuteScalar<int>(CommandType.Text, "SELECT automationGroupID FROM tblDocumentTemplates WHERE TemplateID=@TID", new object[2]
      {
        (object) "@TID",
        (object) templateID
      }).ToString());
      object[] parameters = new object[1]
      {
        (object) new object[1]{ (object) QuoteGuid }
      };
      object[] objArray = new object[1]
      {
        (object) templateID
      };
      if (parameters != null)
      {
        Type typeFromString = ObjectFactory.Instance.CreateTypeFromString("MGASystems.IMS.DocumentAutomation.TemplateDocuments.DocumentHandling");
        object objectValue = RuntimeHelpers.GetObjectValue(Activator.CreateInstance(typeFromString, objArray));
        new MGASystems.AsposeFacade.Words.Document(typeFromString.GetMethod("CreateMergeDocument", new Type[1]
        {
          objArray.GetType()
        }).Invoke(RuntimeHelpers.GetObjectValue(objectValue), parameters).ToString()).Save((Stream) memoryStream, (SaveFormat) 4);
        memoryStream.Position = 0L;
        streamReader = new StreamReader((Stream) memoryStream);
        bodyFromTemplate = streamReader.ReadToEnd();
      }
    }
    finally
    {
      memoryStream.Dispose();
      streamReader.Dispose();
      GC.Collect();
      GC.WaitForPendingFinalizers();
    }
    return bodyFromTemplate;
  }

  protected void SetStandardMargins()
  {
    Margins margins = this.PageSettings.Margins;
    margins.Top = 0.7f;
    margins.Bottom = 0.7f;
    margins.Left = 0.7f;
    margins.Right = 0.7f;
  }

  protected void ShowPageNumbers() => this._showPageNumbers = true;

  protected void HidePageNumbers() => this._showPageNumbers = false;

  protected void ShowPrintDateAndTime() => this._showPrintDateAndTime = true;

  protected void HidePrintDateAndTime() => this._showPrintDateAndTime = false;

  protected void SetDetailControlsHeight()
  {
    try
    {
      foreach (GrapeCity.ActiveReports.SectionReportModel.Section section in this.Sections)
      {
        if (section.Type == 3)
        {
          int num = ((CollectionBase) section.Controls).Count - 1;
          for (int index = 0; index <= num; ++index)
            section.Controls[index].Height = section.Height;
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

  public void AddCommandToCancelList(SqlCommand command)
  {
    this.CommandsToCancel.Add(command);
    command.StatementCompleted += new StatementCompletedEventHandler(this.RemoveCommandFromCancelList);
  }

  public void RemoveCommandFromCancelList(object sender, StatementCompletedEventArgs args)
  {
    if (!(sender is SqlCommand sqlCommand))
      return;
    this.CommandsToCancel.Remove(sqlCommand);
    sqlCommand.StatementCompleted -= new StatementCompletedEventHandler(this.RemoveCommandFromCancelList);
  }

  protected override void Dispose(bool disposing)
  {
    try
    {
      foreach (SqlCommand sqlCommand in this.CommandsToCancel)
      {
        sqlCommand.StatementCompleted -= new StatementCompletedEventHandler(this.RemoveCommandFromCancelList);
        sqlCommand.Cancel();
      }
    }
    finally
    {
      List<SqlCommand>.Enumerator enumerator;
      enumerator.Dispose();
    }
    AppDomain.CurrentDomain.FirstChanceException -= new EventHandler<FirstChanceExceptionEventArgs>(this.OnFirstChanceException);
    base.Dispose(disposing);
  }

  private void MGAReport_ReportEnd(object sender, EventArgs e)
  {
    Font font = new Font("Courier New", 8f, FontStyle.Regular);
    string empty = string.Empty;
    string format = string.Empty;
    int num;
    if (this._showPageNumbers)
    {
      num = this.Document.Pages.Count;
      format = "Page {0} of " + num.ToString();
    }
    if (this._showPrintDateAndTime)
      empty = DefaultDatabase.ExecuteScalar<DateTime>(CommandType.Text, "SELECT { fn NOW() }").ToString("MM/dd/yyyy HH:mm:ss");
    num = this.Document.Pages.Count - 1;
    for (int index = 0; index <= num; ++index)
    {
      this.Document.Pages[index].Font = font;
      this.Document.Pages[index].TextAlignment = (TextAlignment) 0;
      if (this._showPageNumbers)
        this.Document.Pages[index].DrawText(string.Format(format, (object) (index + 1)), 0.25f, this.Document.Pages[index].Height - this.Document.Pages[index].Margins.Bottom, 3f, 0.2f);
      this.Document.Pages[index].TextAlignment = (TextAlignment) 2;
      if (this._showPrintDateAndTime)
        this.Document.Pages[index].DrawText(empty, this.Document.Pages[index].Width - 2f, this.Document.Pages[index].Height - this.Document.Pages[index].Margins.Bottom, 1.625f, 0.2f);
    }
    AppDomain.CurrentDomain.FirstChanceException -= new EventHandler<FirstChanceExceptionEventArgs>(this.OnFirstChanceException);
  }

  public event MGAReport.SetStatusTextEventEventHandler SetStatusTextEvent;

  public event MGAReport.IncreaseProgressbarEventEventHandler IncreaseProgressbarEvent;

  public event MGAReport.SetProgressbarMaximumEventEventHandler SetProgressbarMaximumEvent;

  public event MGAReport.SetProgressbarStyleEventEventHandler SetProgressbarStyleEvent;

  public event MGAReport.BouncingProgressEventEventHandler BouncingProgressEvent;

  protected void SetStatusText(string Text)
  {
    // ISSUE: reference to a compiler-generated field
    MGAReport.SetStatusTextEventEventHandler statusTextEventEvent = this.SetStatusTextEventEvent;
    if (statusTextEventEvent == null)
      return;
    statusTextEventEvent(Text);
  }

  protected void IncreaseProgressbar(int Amount)
  {
    // ISSUE: reference to a compiler-generated field
    MGAReport.IncreaseProgressbarEventEventHandler progressbarEventEvent = this.IncreaseProgressbarEventEvent;
    if (progressbarEventEvent == null)
      return;
    progressbarEventEvent(Amount);
  }

  protected void SetProgressbarMaximum(int Max)
  {
    // ISSUE: reference to a compiler-generated field
    MGAReport.SetProgressbarMaximumEventEventHandler maximumEventEvent = this.SetProgressbarMaximumEventEvent;
    if (maximumEventEvent == null)
      return;
    maximumEventEvent(Max);
  }

  protected void SetProgressbarStyle(ProgressBarStyle Style)
  {
    // ISSUE: reference to a compiler-generated field
    MGAReport.SetProgressbarStyleEventEventHandler progressbarStyleEventEvent = this.SetProgressbarStyleEventEvent;
    if (progressbarStyleEventEvent == null)
      return;
    progressbarStyleEventEvent(Style);
  }

  protected void BouncingProgress(bool Show)
  {
    // ISSUE: reference to a compiler-generated field
    MGAReport.BouncingProgressEventEventHandler progressEventEvent = this.BouncingProgressEventEvent;
    if (progressEventEvent == null)
      return;
    progressEventEvent(Show);
  }

  private void InitializeComponent()
  {
    ResourceManager resourceManager = new ResourceManager(typeof (MGAReport));
    ((ISupportInitialize) this).BeginInit();
    this.MasterReport = false;
    this.PageSettings.PaperHeight = 11f;
    this.PageSettings.PaperWidth = 8.5f;
    this.StyleSheet.Add(new StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: normal; font-size: 10pt; color: Black; text-align: left; vertical-align: top; ddo-char-set: 1", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-family: Arial; font-size: 16pt; font-style: normal; font-weight: bold", "Heading1", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-style: italic; font-weight: bold", "Heading2", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-family: Arial; font-size: 13pt; font-style: normal; font-weight: bold", "Heading3", "Normal"));
    ((ISupportInitialize) this).EndInit();
  }

  public enum EmailAttachmentFormat
  {
    XLS,
    PDF,
    RTF,
  }

  public delegate void SetStatusTextEventEventHandler(string Text);

  public delegate void IncreaseProgressbarEventEventHandler(int Amount);

  public delegate void SetProgressbarMaximumEventEventHandler(int Maximum);

  public delegate void SetProgressbarStyleEventEventHandler(ProgressBarStyle Style);

  public delegate void BouncingProgressEventEventHandler(bool Show);
}
