// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Reporting.SaveReportDocuments
// Assembly: MgaSystems.IMS.Reporting, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D0217E27-C87B-4FD0-8041-819EA70A118B
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Reporting.dll

using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.Document;
using GrapeCity.ActiveReports.Export.Pdf.Section;
using MGASystems.BusinessObjects;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.IMS.NoteDocuments;
using MGASystems.IMS.NoteDocuments.DocumentSystem;
using MGASystems.IMS.Security;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Data;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Xml;

#nullable disable
namespace MGASystems.IMS.Reporting;

public class SaveReportDocuments
{
  private SectionReport _activeReport;
  private bool isISaveDocumentHandler;
  private int _folderId;
  private bool _ShouldSave;
  private Quote _quote;
  private string _reportGuid;
  private string _reportName;
  private bool _displayMessageBox;
  private string _messageText;
  private XmlNode xnReport;
  private bool _askForFolderId;

  public SaveReportDocuments(ref SectionReport ActiveReport)
  {
    this._folderId = -1;
    this._ShouldSave = false;
    this._displayMessageBox = false;
    this._askForFolderId = false;
    this._activeReport = ActiveReport;
    if (ActiveReport is MGAReport mgaReport)
    {
      SecureReportResourceAttribute attributeFromType = (SecureReportResourceAttribute) ObjectFactory.GetAttributeFromType(((object) mgaReport).GetType(), (Attribute) new SecureReportResourceAttribute());
      if (attributeFromType != null)
        this._reportGuid = attributeFromType.UniqueIdentifier.ToString().ToUpper();
    }
    this.SetSaveProperties();
  }

  public SaveReportDocuments(string reportGuid, string quoteGuid, SectionReport activeRptDocument)
  {
    this._folderId = -1;
    this._ShouldSave = false;
    this._displayMessageBox = false;
    this._askForFolderId = false;
    if (!string.IsNullOrEmpty(reportGuid))
    {
      Guid guid = new Guid(reportGuid);
      if (guid != Guid.Empty)
        this._reportGuid = guid.ToString().ToUpper();
    }
    if (!string.IsNullOrEmpty(quoteGuid))
    {
      Guid quoteGuid1 = new Guid(quoteGuid);
      if (quoteGuid1 != new Guid() && !quoteGuid1.Equals(Guid.Empty))
        this._quote = new Quote(quoteGuid1);
    }
    if (activeRptDocument != null)
      this._activeReport = activeRptDocument;
    this.SetSaveProperties();
  }

  public SaveReportDocuments(string reportGuid, Guid quoteGuid, SectionReport activeRptDocument)
  {
    this._folderId = -1;
    this._ShouldSave = false;
    this._displayMessageBox = false;
    this._askForFolderId = false;
    if (!string.IsNullOrEmpty(reportGuid))
    {
      Guid guid = new Guid(reportGuid);
      if (guid != Guid.Empty)
        this._reportGuid = guid.ToString().ToUpper();
    }
    if (quoteGuid != new Guid() && !quoteGuid.Equals(Guid.Empty))
      this._quote = new Quote(quoteGuid);
    if (activeRptDocument != null)
      this._activeReport = activeRptDocument;
    this.SetSaveProperties();
  }

  public SaveReportDocuments(
    string reportGuid,
    string quoteGuid,
    SectionDocument activeRptDocument)
  {
    this._folderId = -1;
    this._ShouldSave = false;
    this._displayMessageBox = false;
    this._askForFolderId = false;
  }

  public SaveReportDocuments(
    string reportGuid,
    Guid quoteGuid,
    int FolderID,
    SectionReport activeRptDocument)
  {
    this._folderId = -1;
    this._ShouldSave = false;
    this._displayMessageBox = false;
    this._askForFolderId = false;
    if (!string.IsNullOrEmpty(reportGuid))
    {
      Guid guid = new Guid(reportGuid);
      if (guid != Guid.Empty)
        this._reportGuid = guid.ToString().ToUpper();
    }
    if (quoteGuid != new Guid() && !quoteGuid.Equals(Guid.Empty))
      this._quote = new Quote(quoteGuid);
    if (activeRptDocument != null)
      this._activeReport = activeRptDocument;
    this.SetSaveProperties();
  }

  protected int FolderId
  {
    get => this._folderId;
    set => this._folderId = value;
  }

  protected string ReportGuid
  {
    get => this._reportGuid;
    set => this._reportGuid = value.ToUpper();
  }

  protected string ReportName
  {
    get => this._reportName;
    set => this._reportName = value;
  }

  protected SectionDocument ActiveRptDocument => this._activeReport.Document;

  protected SectionReport ActiveReport => this._activeReport;

  protected Quote QuoteInfo
  {
    get => this._quote;
    set => this._quote = value;
  }

  protected bool DisplayMessageBox
  {
    get => this._displayMessageBox;
    set => this._displayMessageBox = value;
  }

  protected string MessageText
  {
    get => this._messageText;
    set => this._messageText = value;
  }

  public bool ShouldSave
  {
    get => this._ShouldSave;
    set => this._ShouldSave = value;
  }

  public bool CanSave
  {
    get
    {
      return this._quote != null && this._activeReport != null && !(this._folderId == -1 & !this._askForFolderId);
    }
  }

  public void SaveToFolder()
  {
    using (PdfExport pdfExport = new PdfExport())
    {
      using (MemoryStream memoryStream = new MemoryStream())
      {
        if (!this.CanSave)
          return;
        string str = this.ReportName + ".pdf";
        pdfExport.Export(this.ActiveRptDocument, (Stream) memoryStream);
        char[] invalidFileNameChars = Path.GetInvalidFileNameChars();
        int index = 0;
        while (index < invalidFileNameChars.Length)
        {
          char ch = invalidFileNameChars[index];
          str = str.Replace(Conversions.ToString(ch), string.Empty);
          checked { ++index; }
        }
        using (FileStream fileStream = new FileStream(MGATempFolder.MGATempPath + str, FileMode.Create))
        {
          memoryStream.WriteTo((Stream) fileStream);
          fileStream.Write(memoryStream.ToArray(), 0, (int) memoryStream.Position);
        }
        if (this.DisplayMessageBox && !string.IsNullOrEmpty(this.MessageText) && MessageBox.Show(this.MessageText, "Save PDF", MessageBoxButtons.YesNo) == DialogResult.No)
          return;
        bool flag = false;
        if (this._quote == null)
        {
          if (MessageBox.Show("Report did not provide Quote to be Bound to.\r\nDo you want to save document as Unbound?", "Report did not provide Quote to be Bound to.", MessageBoxButtons.YesNo) == DialogResult.No)
            return;
          flag = true;
        }
        if (this._folderId == -1 || this._askForFolderId)
        {
          frmFetchDoc frmFetchDoc = new frmFetchDoc(true, this._reportName, this._folderId, (ISupportDocumentSystem) null);
          int num = (int) frmFetchDoc.ShowDialog();
          if (frmFetchDoc.DialogResult != DialogResult.OK)
            return;
          this._folderId = frmFetchDoc.FolderId;
          this._reportName = frmFetchDoc.Description;
        }
        if (flag)
          DocumentManager.BeginFileAdd(MGATempFolder.MGATempPath + str, this._folderId, this.ReportName, true);
        else
          DocumentManager.BeginFileAddWithBind(MGATempFolder.MGATempPath + str, this._folderId, this.ReportName, (ISupportDocumentSystem) this._quote, true, false);
      }
    }
  }

  public bool SaveReportForDocHandler(string ReportName)
  {
    bool flag;
    return flag;
  }

  private void SetSaveProperties()
  {
    if (this._activeReport is ISaveDocumentHandler activeReport)
    {
      if (activeReport.DocHandlerProperties.SaveToDocHandler)
        this._ShouldSave = true;
      this._askForFolderId = activeReport.DocHandlerProperties.AskForDocHandlerFolderID;
      if (!activeReport.DocHandlerProperties.QuoteGUID.Equals(Guid.Empty))
        this._quote = new Quote(activeReport.DocHandlerProperties.QuoteGUID);
      this.isISaveDocumentHandler = true;
    }
    this.SetNode();
    this.SetMessage();
    this.SetReportName();
    this.SetFolderID();
    this.SetAskForFolder();
    this.SetQuote();
  }

  private void SetQuote()
  {
    if (this._quote != null)
      return;
    if (this.xnReport != null && this.xnReport.SelectSingleNode("QuoteGUIDColumn") != null && !string.IsNullOrEmpty(this.xnReport.SelectSingleNode("QuoteGUIDColumn").InnerText))
      this._quote = this.GetQuoteFromDatasource(this.xnReport.SelectSingleNode("QuoteGUIDColumn").InnerText);
    if (this._quote != null)
      return;
    if (this._activeReport != null && this._activeReport is ISaveDocumentHandler activeReport && !activeReport.DocHandlerProperties.QuoteGUID.Equals(Guid.Empty))
      this._quote = new Quote(activeReport.DocHandlerProperties.QuoteGUID);
    if (this._quote != null)
      return;
    this.LastTryToGetQuote();
  }

  private Quote GetQuoteFromDatasource(string columnName)
  {
    Quote quoteFromDatasource;
    if (Information.IsNothing((object) this._activeReport))
    {
      quoteFromDatasource = (Quote) null;
    }
    else
    {
      DataSet dataSet = this._activeReport.DataSource as DataSet;
      DataTable dataSource1 = this._activeReport.DataSource as DataTable;
      DataView dataSource2 = this._activeReport.DataSource as DataView;
      bool flag = false;
      if (dataSet == null)
        dataSet = new DataSet();
      else
        flag = true;
      if (!flag && dataSource1 != null)
      {
        dataSet.Tables.Add(dataSource1.Copy());
        flag = true;
      }
      if (!flag && dataSource2 != null)
      {
        dataSet.Tables.Add(dataSource2.ToTable().Copy());
        flag = true;
      }
      if (!flag)
      {
        quoteFromDatasource = (Quote) null;
      }
      else
      {
        object obj;
        try
        {
          int result;
          obj = !int.TryParse(columnName, out result) ? RuntimeHelpers.GetObjectValue(dataSet.Tables[0].Rows[0][columnName]) : RuntimeHelpers.GetObjectValue(dataSet.Tables[0].Rows[0][result]);
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        Guid result1;
        if (obj != null && Guid.TryParse(obj.ToString(), out result1))
          this._quote = new Quote(result1);
        quoteFromDatasource = this._quote;
      }
    }
    return quoteFromDatasource;
  }

  private bool LastTryToGetQuote()
  {
    bool getQuote;
    if (Information.IsNothing((object) this._activeReport))
    {
      getQuote = false;
    }
    else
    {
      DataSet dataSet = this._activeReport.DataSource as DataSet;
      DataTable dataSource1 = this._activeReport.DataSource as DataTable;
      DataView dataSource2 = this._activeReport.DataSource as DataView;
      bool flag = false;
      if (dataSet == null)
        dataSet = new DataSet();
      else
        flag = true;
      if (!flag && dataSource1 != null)
      {
        dataSet.Tables.Add(dataSource1.Copy());
        flag = true;
      }
      if (!flag && dataSource2 != null)
      {
        dataSet.Tables.Add(dataSource2.ToTable().Copy());
        flag = true;
      }
      if (!flag)
      {
        getQuote = false;
      }
      else
      {
        try
        {
          if (dataSet != null)
          {
            try
            {
              foreach (DataTable table in (InternalDataCollectionBase) dataSet.Tables)
              {
                if (table != null)
                {
                  try
                  {
                    foreach (DataColumn column in (InternalDataCollectionBase) table.Columns)
                    {
                      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(column.ColumnName.ToUpper(), "QUOTEGUID", false) == 0)
                      {
                        Guid quoteGuid = new Guid(table.Rows[0][column].ToString());
                        if (!quoteGuid.Equals(Guid.Empty))
                        {
                          this._quote = new Quote(quoteGuid);
                          getQuote = true;
                          goto label_28;
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
        getQuote = true;
      }
    }
label_28:
    return getQuote;
  }

  private void SetNode()
  {
    if (!MGASystems.Common.SystemSettings.KeyExists("SaveQuoteDocs"))
      return;
    if (!MGASystems.Common.SystemSettings.GetBoolSetting("SaveQuoteDocs"))
      return;
    try
    {
      XmlDocument xmlDocument = new XmlDocument();
      xmlDocument.LoadXml(MGASystems.Common.SystemSettings.GetStringSetting("SaveQuoteDocs"));
      XmlNodeList xmlNodeList = xmlDocument.SelectNodes("ReportList/Report");
      try
      {
        foreach (XmlNode xmlNode in xmlNodeList)
        {
          if (xmlNode.SelectSingleNode("@ReportGuid") != null && !string.IsNullOrEmpty(xmlNode.SelectSingleNode("@ReportGuid").InnerText) && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.ReportGuid.ToUpper(), xmlNode.SelectSingleNode("@ReportGuid").InnerText.ToUpper(), false) == 0)
          {
            this.xnReport = xmlNode;
            this._ShouldSave = true;
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
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      ProjectData.ClearProjectError();
    }
  }

  private void SetMessage()
  {
    if (this.xnReport != null && this.xnReport.SelectSingleNode("@MessageBox") != null && !string.IsNullOrEmpty(this.xnReport.SelectSingleNode("@MessageBox").InnerText))
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.xnReport.SelectSingleNode("@MessageBox").InnerText, "1", false) == 0)
      {
        if (!string.IsNullOrEmpty(this.xnReport.SelectSingleNode("@MessageText").InnerText))
        {
          this.DisplayMessageBox = true;
          this.MessageText = this.xnReport.SelectSingleNode("@MessageText").InnerText;
        }
        else
          this.DisplayMessageBox = false;
      }
      else
        this.DisplayMessageBox = false;
    }
    else
    {
      if (this.DisplayMessageBox || this._activeReport == null || !(this._activeReport is ISaveDocumentHandler activeReport))
        return;
      this.DisplayMessageBox = activeReport.DocHandlerProperties.ShowMessageBox;
      this.MessageText = activeReport.DocHandlerProperties.MessageText;
    }
  }

  private void SetAskForFolder()
  {
    if (this.xnReport != null && this.xnReport.SelectSingleNode("@AskForFolderID") != null && !string.IsNullOrEmpty(this.xnReport.SelectSingleNode("@AskForFolderID").InnerText))
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.xnReport.SelectSingleNode("@AskForFolderID").InnerText, "1", false) == 0)
        this._askForFolderId = true;
      else
        this._askForFolderId = false;
    }
    else
    {
      if (this._activeReport == null || !(this._activeReport is ISaveDocumentHandler activeReport))
        return;
      this._askForFolderId = activeReport.DocHandlerProperties.AskForDocHandlerFolderID;
    }
  }

  private void SetReportName()
  {
    string Left = "";
    if (!Information.IsNothing((object) this._activeReport))
      Left = this._activeReport.GetType().Name;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "", false) == 0 && !Information.IsNothing((object) this.ReportGuid) && !string.IsNullOrEmpty(this.ReportGuid))
      Left = this.ReportGuid.ToUpper();
    if (this.xnReport != null)
    {
      if (this.xnReport.SelectSingleNode("@Name") != null && !string.IsNullOrEmpty(this.xnReport.SelectSingleNode("@Name").InnerText))
        this.ReportName = this.xnReport.SelectSingleNode("@Name").InnerText;
      int num = this.xnReport.ChildNodes.Count - 1;
      for (int index = 0; index <= num; ++index)
      {
        if (this.xnReport.SelectSingleNode("UpdateName") != null && this.xnReport.SelectSingleNode($"UpdateName[@Index='{index.ToString()}']") != null)
        {
          XmlNode xn = this.xnReport.SelectSingleNode($"UpdateName[@Index='{index.ToString()}']");
          this.ReportName += this.CheckSpaces(xn);
          this.ReportName += this.CheckDBColumn(xn);
          this.ReportName += this.GetNodeValue(xn);
        }
      }
      if (!string.IsNullOrEmpty(this.ReportName))
        return;
    }
    if (string.IsNullOrEmpty(this.ReportName) && this._activeReport != null && this._activeReport is ISaveDocumentHandler activeReport1)
      this.ReportName = activeReport1.DocHandlerProperties.DocHandlerDescription;
    if (string.IsNullOrEmpty(this.ReportName) && this._activeReport != null && this._activeReport is MGAReport activeReport2)
    {
      SecureReportResourceAttribute attributeFromType = (SecureReportResourceAttribute) ObjectFactory.GetAttributeFromType(((object) activeReport2).GetType(), (Attribute) new SecureReportResourceAttribute());
      if (attributeFromType != null)
        this.ReportName = attributeFromType.Name;
    }
    if (!string.IsNullOrEmpty(this.ReportName))
      return;
    this.ReportName = Left;
  }

  private void SetFolderID()
  {
    if (this.xnReport != null)
    {
      string innerText = this.xnReport.SelectSingleNode("@FolderId").InnerText;
      int folderId = this.FolderId;
      ref int local = ref folderId;
      int num = int.TryParse(innerText, out local) ? 1 : 0;
      this.FolderId = folderId;
      if (num != 0)
        return;
    }
    if (this._activeReport != null && this._folderId == -1 && this._activeReport is ISaveDocumentHandler activeReport)
      this._folderId = activeReport.DocHandlerProperties.DocHandlerFolderID;
    if (this._folderId == -1 && !Information.IsNothing((object) this._activeReport))
    {
      object objectValue = RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT TOP 1 FolderID FROM tblDocumentFolderTypes WHERE AssociatedEntityType = @EntityType", new object[2]
      {
        (object) "@EntityType",
        (object) this._activeReport.ToString()
      }));
      if (objectValue != null)
        int.TryParse(objectValue.ToString(), out this._folderId);
    }
    if (this._folderId == -1)
    {
      this._askForFolderId = true;
    }
    else
    {
      if (this.CheckFolderID())
        return;
      this._askForFolderId = true;
    }
  }

  private bool CheckFolderID()
  {
    int result;
    return int.TryParse(RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT Count(FolderID) Folders  FROM tblDocumentFolders WHERE FolderID=@FolderID", new object[2]
    {
      (object) "@FolderID",
      (object) this._folderId
    })).ToString(), out result) && result > 0;
  }

  private string CheckSpaces(XmlNode xn)
  {
    string str = "";
    if (xn.SelectSingleNode("./@SpaceCount") != null)
    {
      int result;
      int.TryParse(xn.SelectSingleNode("./@SpaceCount").Value, out result);
      int num = result - 1;
      for (int index = 0; index <= num; ++index)
        str += " ";
    }
    return str;
  }

  private string GetNodeValue(XmlNode xn)
  {
    return xn.SelectSingleNode("./@UseDBColumn") == null || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(xn.SelectSingleNode("./@UseDBColumn").Value, "1", false) != 0 ? xn.SelectSingleNode(".").InnerXml : "";
  }

  private string CheckDBColumn(XmlNode xn)
  {
    string str1 = "";
    if (xn.SelectSingleNode("./@UseDBColumn") != null && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(xn.SelectSingleNode("./@UseDBColumn").Value, "1", false) == 0)
    {
      string str2 = xn.SelectSingleNode(".").InnerText.ToLower().Replace(" ", "");
      // ISSUE: reference to a compiler-generated method
      switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(str2))
      {
        case 167528514:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "expirationdatemonth", false) == 0)
          {
            str1 = this.QuoteInfo.ExpirationDate.Month.ToString();
            break;
          }
          break;
        case 223257228:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "currentdateday", false) == 0)
          {
            str1 = DateTime.Today.Day.ToString();
            break;
          }
          break;
        case 376213213:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "expirationdateyear", false) == 0)
          {
            str1 = this.QuoteInfo.ExpirationDate.Year.ToString();
            break;
          }
          break;
        case 1103553550:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "currentdated", false) == 0)
          {
            str1 = DateTime.Today.ToShortDateString();
            break;
          }
          break;
        case 1108168339:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "currentdateyear", false) == 0)
          {
            str1 = DateTime.Today.Year.ToString();
            break;
          }
          break;
        case 1317445814:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "expirationdateday", false) == 0)
          {
            str1 = this.QuoteInfo.ExpirationDate.Day.ToString();
            break;
          }
          break;
        case 1467678140:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "expirationdate", false) == 0)
          {
            str1 = this.QuoteInfo.ExpirationDate.ToShortDateString();
            break;
          }
          break;
        case 1646821860:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "effectivedateday", false) == 0)
          {
            str1 = this.QuoteInfo.EffectiveDate.Day.ToString();
            break;
          }
          break;
        case 1918487091:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "datecreatedday", false) == 0)
          {
            str1 = this.QuoteInfo.DateCreated.Day.ToString();
            break;
          }
          break;
        case 2323400318:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "policynumber", false) == 0)
          {
            str1 = this.QuoteInfo.PolicyNumber.ToString();
            break;
          }
          break;
        case 2398236663:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "datecreated", false) == 0)
          {
            str1 = this.QuoteInfo.DateCreated.ToShortDateString();
            break;
          }
          break;
        case 3050192452:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "insuredpolicyname", false) == 0)
          {
            str1 = this.QuoteInfo.InsuredPolicyName.ToString();
            break;
          }
          break;
        case 3487587832:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "currentdatemonth", false) == 0)
          {
            str1 = DateTime.Today.Month.ToString();
            break;
          }
          break;
        case 3564104282:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "quoteid", false) == 0)
          {
            str1 = this.QuoteInfo.QuoteID.ToString();
            break;
          }
          break;
        case 3708488032:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "effectivedatemonth", false) == 0)
          {
            str1 = this.QuoteInfo.EffectiveDate.Month.ToString();
            break;
          }
          break;
        case 3783418194:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "datecreatedyear", false) == 0)
          {
            str1 = this.QuoteInfo.DateCreated.Year.ToString();
            break;
          }
          break;
        case 4071342765:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "controlno", false) == 0)
          {
            str1 = this.QuoteInfo.ControlNo.ToString();
            break;
          }
          break;
        case 4147507963:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "effectivedateyear", false) == 0)
          {
            str1 = this.QuoteInfo.EffectiveDate.Year.ToString();
            break;
          }
          break;
        case 4177867094:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "effectivedate", false) == 0)
          {
            str1 = this.QuoteInfo.EffectiveDate.ToShortDateString();
            break;
          }
          break;
        case 4288777203:
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "datecreatedmonth", false) == 0)
          {
            str1 = this.QuoteInfo.DateCreated.Month.ToString();
            break;
          }
          break;
      }
    }
    return str1;
  }
}
