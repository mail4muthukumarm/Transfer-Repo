// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.DocumentAutomation.TemplateDocuments.DocumentHandling
// Assembly: MgaSystems.IMS.DocumentAutomation, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: B33F9A76-E654-4386-A032-7A12D7CD66DE
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.DocumentAutomation.dll

using Infragistics.Win.UltraWinProgressBar;
using Mga.Wpf.Ims.Interop;
using MGASystems.AsposeFacade.Words;
using MGASystems.AsposeFacade.Words.Drawing;
using MGASystems.AsposeFacade.Words.Fields;
using MGASystems.AsposeFacade.Words.Reporting;
using MGASystems.AsposeFacade.Words.Tables;
using MGASystems.BusinessObjects;
using MGASystems.Common;
using MGASystems.Common.BroadcastMessaging;
using MGASystems.Common.DataAccess;
using MGASystems.Common.ErrorHandling;
using MGASystems.Common.OfficeInterop;
using MGASystems.Common.OfficeInterop.Word;
using MGASystems.Data;
using MGASystems.IMS.NoteDocuments;
using MGASystems.IMS.NoteDocuments.DocumentSystem;
using MGASystems.IMS.Reporting.AutomationReports;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.DocumentAutomation.TemplateDocuments;

public class DocumentHandling
{
  private int _templateID;
  private Enums.AutomationDocGroups _automationGroup;
  private object[] _args;
  private string _tempFilename;
  private string _templateName;
  private Guid[] _quoteOptionGuids;
  private bool _isAdditionalInterestDocType;
  private string _originalFileName;
  public static int AdditionalInterestID = 0;
  private static DataSet currentRegion = (DataSet) null;
  private static Dictionary<string, int> TableIndices = new Dictionary<string, int>();
  private static Dictionary<char, DocumentHandling.FormatState> _formatDictionary;

  private virtual WordTemplate wordTmpl
  {
    get => this._wordTmpl;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler1 = new EventHandler(this.wordTmpl_WordAppClosed);
      EventHandler eventHandler2 = new EventHandler(this.wordTmpl_WordAppSaving);
      WordTemplate wordTmpl1 = this._wordTmpl;
      if (wordTmpl1 != null)
      {
        wordTmpl1.WordAppClosed -= eventHandler1;
        wordTmpl1.WordAppSaving -= eventHandler2;
      }
      this._wordTmpl = value;
      WordTemplate wordTmpl2 = this._wordTmpl;
      if (wordTmpl2 == null)
        return;
      wordTmpl2.WordAppClosed += eventHandler1;
      wordTmpl2.WordAppSaving += eventHandler2;
    }
  }

  public DocumentHandling(int templateID)
  {
    this._isAdditionalInterestDocType = false;
    this._templateID = templateID;
    DataRow row = DefaultDatabase.ExecuteDataRow(CommandType.Text, "SELECT AutomationGroupID, TemplateName, OriginalFileName FROM tblDocumentTemplates WHERE TemplateID=@TemplateID", new object[2]
    {
      (object) "@TemplateID",
      (object) templateID
    });
    this._templateName = row.Field<string>("TemplateName");
    this._originalFileName = row.Field<string>("OriginalFileName");
    this._automationGroup = (Enums.AutomationDocGroups) Enum.Parse(typeof (Enums.AutomationDocGroups), row.Field<byte>("AutomationGroupID").ToString());
  }

  public object[] Args => this._args;

  public Enums.AutomationDocGroups AutomationGroup => this._automationGroup;

  public Guid[] GetQuoteOptionGuids() => this._quoteOptionGuids;

  public static bool HasCompatibleOfficeVersion()
  {
    return DocumentHandling.HasCompatibleOfficeVersion(false);
  }

  public static bool HasCompatibleOfficeVersion(bool informUser) => true;

  public static string IsValidWordDocument(string fileName)
  {
    string str;
    try
    {
      Document document = new Document(fileName);
    }
    catch (NotImplementedException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      str = "This Word document is in an older, unsupported format.\n\nThe document must be created with Word 97 or later.";
      ProjectData.ClearProjectError();
      goto label_8;
    }
    catch (NotSupportedException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      str = "This Word document is in an older, unsupported format.\n\nThe document must be created with Word 97 or later.";
      ProjectData.ClearProjectError();
      goto label_8;
    }
    catch (IOException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      str = $"The IMS was unable to open the following file\n\n{fileName}\n\nPlease ensure it is not currently open by another application.";
      ProjectData.ClearProjectError();
      goto label_8;
    }
    catch (UnsupportedFileFormatException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      str = ((Exception) ex).Message;
      ProjectData.ClearProjectError();
      goto label_8;
    }
    catch (OverflowException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      str = "The IMS was unable to open this document.\n\nIf this is a valid Microsoft Word document, please contact technical supoport.";
      ProjectData.ClearProjectError();
      goto label_8;
    }
    catch (InvalidOperationException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      str = "This file is in the wrong format...It Should be a valid Word document File";
      ProjectData.ClearProjectError();
      goto label_8;
    }
    str = "";
label_8:
    return str;
  }

  public bool CompletedTemplateExists(int quoteID)
  {
    return Conversions.ToBoolean(Database.Instance.QueryText.PerformScalarQuery("SELECT CASE WHEN EXISTS (SELECT * FROM tblDocumentTemplates_Completed WHERE QuoteID=@QuoteID AND TemplateID=@TemplateID) THEN 1 ELSE 0 END", (object) "@QuoteID", (object) quoteID, (object) "@TemplateID", (object) this._templateID));
  }

  public void WriteCompletedTemplateToDisk(int quoteID, string outputFileName)
  {
    byte[] array = (byte[]) Database.Instance.QueryText.PerformScalarQuery("SELECT WordDocTemplate FROM tblDocumentTemplates_Completed (NOLOCK) WHERE QuoteID=@QuoteID AND TemplateID=@TemplateID", (object) "@QuoteID", (object) quoteID, (object) "@TemplateID", (object) this._templateID);
    FileStream fileStream = new FileStream(outputFileName, FileMode.Create);
    try
    {
      fileStream.Write(array, 0, array.Length);
    }
    finally
    {
      fileStream.Close();
    }
  }

  public void WriteTemplateToDisk(string outputFileName)
  {
    byte[] array = (byte[]) Database.Instance.QueryText.PerformScalarQuery("SELECT Template FROM tblDocumentTemplates (NOLOCK) WHERE TemplateID=@TID", (object) "@TID", (object) this._templateID);
    using (FileStream fileStream = new FileStream(outputFileName, FileMode.Create))
    {
      fileStream.Write(array, 0, array.Length);
      fileStream.Close();
    }
  }

  public string CreateMergeDocument(params object[] args)
  {
    return this.CreateMergedDocument((string) null, args);
  }

  public string CreateMergeDocument(string wordDocumentFileName, params object[] args)
  {
    return this.CreateMergedDocument(wordDocumentFileName, args);
  }

  public string CreateMergedDocument(
    string wordDocumentFileName,
    object[] constructorArgs,
    object entityId = null,
    int placedByCompanyLineId = -1,
    int policyFormId = -1)
  {
    if (string.IsNullOrEmpty(wordDocumentFileName))
    {
      string str = ".doc";
      if (!string.IsNullOrEmpty(this._originalFileName))
      {
        string path = this._originalFileName;
        char[] invalidFileNameChars = Path.GetInvalidFileNameChars();
        int index = 0;
        while (index < invalidFileNameChars.Length)
        {
          char ch = invalidFileNameChars[index];
          path = path.Replace(Conversions.ToString(ch), string.Empty);
          checked { ++index; }
        }
        str = Path.GetExtension(path);
      }
      wordDocumentFileName = Path.GetTempFileName() + str;
      this.WriteTemplateToDisk(wordDocumentFileName);
    }
    Document doc;
    string mergedDocument;
    try
    {
      doc = new Document(wordDocumentFileName);
    }
    catch (NotImplementedException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      int num = (int) MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      mergedDocument = string.Empty;
      ProjectData.ClearProjectError();
      goto label_11;
    }
    this.DoMerge(doc, constructorArgs, RuntimeHelpers.GetObjectValue(entityId), placedByCompanyLineId, policyFormId);
    doc.Save(wordDocumentFileName);
    mergedDocument = wordDocumentFileName;
label_11:
    return mergedDocument;
  }

  public void DoMerge(Document doc, object[] constructorArgs)
  {
    if (DocumentHandling.AdditionalInterestID > 0 && !this._isAdditionalInterestDocType)
      this.DoMerge(doc, constructorArgs, (object) DocumentHandling.AdditionalInterestID);
    else
      this.DoMerge(doc, constructorArgs, (object) null);
  }

  public void DoMerge(Document doc, object[] constructorArgs, object entityID)
  {
    this.DoMerge(doc, constructorArgs, RuntimeHelpers.GetObjectValue(entityID), -1);
  }

  public void DoMerge(
    Document doc,
    object[] constructorArgs,
    object entityID,
    int placedByCompanyLineID)
  {
    this.DoMerge(doc, constructorArgs, RuntimeHelpers.GetObjectValue(entityID), placedByCompanyLineID, -1);
  }

  public void DoMerge(
    Document doc,
    object[] constructorArgs,
    object entityID,
    int placedByCompanyLineID,
    int policyFormID)
  {
    try
    {
      List<DocTag> tags1 = DocumentHandling.ExtractTags(doc);
      int integer = Conversions.ToInteger(Database.Instance.QueryText.PerformScalarQuery("SELECT AutomationGroupID FROM tblDocumentTemplates WHERE TemplateID=@TID", (object) "@TID", (object) this._templateID));
      TagParserBase tagParser = ((TagParserFactory) ObjectFactory.Instance.CreateObject(typeof (TagParserFactory))).GetTagParser(integer, constructorArgs);
      List<DocTag> tags2 = tagParser.ProcessTags(tags1, RuntimeHelpers.GetObjectValue(entityID), placedByCompanyLineID);
      List<DocTag> tags3 = tagParser.ProcessPolicyFormTags(tags2, RuntimeHelpers.GetObjectValue(entityID), placedByCompanyLineID, this._templateID, policyFormID);
      if (tagParser.SupportsQuoteOptionGuids())
        this._quoteOptionGuids = tagParser.GetQuoteOptionGuids();
      DocumentHandling.MergeDoc(doc, tags3);
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      Exception exception = ex;
      exception.Data.Add((object) "TemplateName", (object) this._templateName);
      exception.Data.Add((object) "TemplateID", (object) this._templateID);
      throw;
    }
  }

  public static List<DocTag> ExtractTags(int templateID)
  {
    string path = Path.GetTempFileName() + ".doc";
    object obj = (object) DefaultDatabase.ExecuteScalar<byte[]>(CommandType.Text, "SELECT Template FROM tblDocumentTemplates (NOLOCK) WHERE TemplateID=@TID", new object[2]
    {
      (object) "@TID",
      (object) templateID
    });
    using (FileStream fileStream = new FileStream(path, FileMode.Create))
    {
      fileStream.Write((byte[]) obj, 0, Conversions.ToInteger(NewLateBinding.LateGet(obj, (Type) null, "Length", new object[0], (string[]) null, (Type[]) null, (bool[]) null)));
      fileStream.Close();
    }
    return DocumentHandling.ExtractTags(new Document(path));
  }

  public static List<DocTag> ExtractTags(Document doc)
  {
    if (doc == null)
      throw new ArgumentNullException(nameof (doc));
    List<DocTag> tags = new List<DocTag>();
    string[] fieldNames = doc.MailMerge.GetFieldNames();
    int index = 0;
    while (index < fieldNames.Length)
    {
      string str = fieldNames[index];
      tags.Add(new DocTag() { TagName = str });
      checked { ++index; }
    }
    try
    {
      foreach (FormField formField in (IEnumerable<FormField>) doc.Range.FormFields)
      {
        if (formField.Type == 71)
          tags.Add(new DocTag() { TagName = formField.Name });
      }
    }
    finally
    {
      IEnumerator<FormField> enumerator;
      enumerator?.Dispose();
    }
    return tags;
  }

  public static void MergeDoc(Document doc, List<DocTag> tags)
  {
    if (tags == null || tags.Count == 0)
      return;
    List<DocTag> source1 = tags;
    System.Func<DocTag, bool> predicate;
    // ISSUE: reference to a compiler-generated field
    if (DocumentHandling._Closure\u0024__.\u0024I37\u002D0 != null)
    {
      // ISSUE: reference to a compiler-generated field
      predicate = DocumentHandling._Closure\u0024__.\u0024I37\u002D0;
    }
    else
    {
      // ISSUE: reference to a compiler-generated field
      DocumentHandling._Closure\u0024__.\u0024I37\u002D0 = predicate = (System.Func<DocTag, bool>) ([SpecialName] (x) => x.IsRepeatableTag);
    }
    IEnumerable<DocTag> source2 = source1.Where<DocTag>(predicate);
    System.Func<DocTag, DataSet> selector;
    // ISSUE: reference to a compiler-generated field
    if (DocumentHandling._Closure\u0024__.\u0024I37\u002D1 != null)
    {
      // ISSUE: reference to a compiler-generated field
      selector = DocumentHandling._Closure\u0024__.\u0024I37\u002D1;
    }
    else
    {
      // ISSUE: reference to a compiler-generated field
      DocumentHandling._Closure\u0024__.\u0024I37\u002D1 = selector = (System.Func<DocTag, DataSet>) ([SpecialName] (x) => x.TagDataset);
    }
    List<DataSet> list = source2.Select<DocTag, DataSet>(selector).Distinct<DataSet>().ToList<DataSet>();
    doc.MailMerge.RemoveEmptyParagraphs = true;
    try
    {
      foreach (DataSet dataSet in list)
      {
        doc.MailMerge.RemoveEmptyRegions = dataSet == list.Last<DataSet>();
        DocumentHandling.currentRegion = dataSet;
        try
        {
          doc.MailMerge.ExecuteWithRegions(new EventHandler<MergeFieldEventArgs>(DocumentHandling.RegionMerging_FieldMerging), dataSet);
        }
        catch (FormatException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          ErrorHandler.HandleError((Exception) ex);
          ProjectData.ClearProjectError();
        }
        DocumentHandling.TableIndices.Clear();
        DocumentHandling.currentRegion = (DataSet) null;
      }
    }
    finally
    {
      List<DataSet>.Enumerator enumerator;
      enumerator.Dispose();
    }
    List<string> stringList = new List<string>();
    List<object> objectList = new List<object>();
    try
    {
      foreach (DocTag tag in tags)
      {
        if (!tag.IsTableTag && !tag.IsImageTag && !tag.IsCheckBoxTag)
        {
          stringList.Add(tag.TagName);
          objectList.Add((object) tag.TagValue);
        }
      }
    }
    finally
    {
      List<DocTag>.Enumerator enumerator;
      enumerator.Dispose();
    }
    if (stringList.Count > 0)
    {
      try
      {
        doc.MailMerge.Execute(new EventHandler<MergeFieldEventArgs>(DocumentHandling.RegionMerging_FieldMerging), stringList.ToArray(), objectList.ToArray());
      }
      catch (FormatException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        ErrorHandler.HandleError((Exception) ex);
        ProjectData.ClearProjectError();
      }
    }
    DocumentBuilder documentBuilder = new DocumentBuilder(doc);
    if (!(documentBuilder.Document.MailMerge.GetFieldNames().Length > 0 | ((IEnumerable<FormField>) doc.Range.FormFields).Count<FormField>() > 0))
      return;
    try
    {
      foreach (DocTag tag in tags)
      {
        if (tag.IsTableTag || tag.IsImageTag)
        {
          while (Array.IndexOf<string>(documentBuilder.Document.MailMerge.GetFieldNames(), tag.TagName) >= 0)
          {
            if (Array.IndexOf<string>(documentBuilder.Document.MailMerge.GetFieldNames(), tag.TagName) != 0)
              documentBuilder.MoveToMergeField(documentBuilder.Document.MailMerge.GetFieldNames().GetValue(0).ToString());
            if (tag.IsTableTag)
            {
              documentBuilder.MoveToMergeField(tag.TagName);
              Paragraph currentParagraph = documentBuilder.CurrentParagraph;
              currentParagraph.ParagraphFormat.LineSpacing = 0.0;
              MGASystems.AsposeFacade.Words.Node node = doc.ImportNode(Table.op_Implicit(tag.TagTable), true);
              currentParagraph.ParentNode.InsertBefore(node, Paragraph.op_Implicit(currentParagraph));
            }
            else if (tag.IsImageTag)
            {
              documentBuilder.MoveToMergeField(tag.TagName);
              Shape shape = documentBuilder.InsertImage(tag.TagImage);
              shape.WrapType = (WrapType) 3;
              shape.BehindText = true;
            }
          }
        }
        if (tag.IsCheckBoxTag)
        {
          try
          {
            foreach (FormField formField in (IEnumerable<FormField>) doc.Range.FormFields)
            {
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(formField.Name, tag.TagName, false) == 0 && formField.Type == 71)
                formField.Checked = tag.TagCheckbox;
            }
          }
          finally
          {
            IEnumerator<FormField> enumerator;
            enumerator?.Dispose();
          }
        }
      }
    }
    finally
    {
      List<DocTag>.Enumerator enumerator;
      enumerator.Dispose();
    }
  }

  public void PrintTemplateDoc(object[] tagParserConstructorArgs, bool showUI)
  {
    frmPleaseWait frmPleaseWait1 = (frmPleaseWait) null;
    if (showUI)
    {
      frmPleaseWait1 = (frmPleaseWait) ObjectFactory.Instance.CreateForm(typeof (frmPleaseWait));
      frmPleaseWait frmPleaseWait2 = frmPleaseWait1;
      frmPleaseWait2.progress.Maximum = 5;
      frmPleaseWait2.progress.Value = 0;
      frmPleaseWait2.ShowInTaskbar = false;
      frmPleaseWait2.Show();
      frmPleaseWait2.BringToFront();
      frmPleaseWait2.Refresh();
    }
    string tempFileName = Path.GetTempFileName();
    DocumentHandling documentHandling = new DocumentHandling(this._templateID);
    this.WriteTemplateToDisk(tempFileName);
    UltraProgressBar progress1;
    int num1 = (progress1 = frmPleaseWait1.progress).Value + 1;
    progress1.Value = num1;
    frmPleaseWait1.Refresh();
    object objectValue1 = RuntimeHelpers.GetObjectValue(WordApplication.Create());
    NewLateBinding.LateSet(objectValue1, (Type) null, "WindowState", new object[1]
    {
      (object) WdWindowState.wdWindowStateMinimize
    }, (string[]) null, (Type[]) null);
    NewLateBinding.LateSet(objectValue1, (Type) null, "Visible", new object[1]
    {
      (object) false
    }, (string[]) null, (Type[]) null);
    UltraProgressBar progress2;
    int num2 = (progress2 = frmPleaseWait1.progress).Value + 1;
    progress2.Value = num2;
    frmPleaseWait1.Refresh();
    Document doc = new Document(tempFileName);
    documentHandling.DoMerge(doc, tagParserConstructorArgs);
    UltraProgressBar progress3;
    int num3 = (progress3 = frmPleaseWait1.progress).Value + 1;
    progress3.Value = num3;
    object obj1 = (object) tempFileName;
    object[] objArray;
    bool[] flagArray;
    object obj2 = NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue1, (Type) null, "Documents", new object[0], (string[]) null, (Type[]) null, (bool[]) null), (Type) null, "Open", objArray = new object[1]
    {
      obj1
    }, (string[]) null, (Type[]) null, flagArray = new bool[1]
    {
      true
    });
    if (flagArray[0])
      RuntimeHelpers.GetObjectValue(objArray[0]);
    object objectValue2 = RuntimeHelpers.GetObjectValue(obj2);
    UltraProgressBar progress4;
    int num4 = (progress4 = frmPleaseWait1.progress).Value + 1;
    progress4.Value = num4;
    frmPleaseWait1.Refresh();
    try
    {
      NewLateBinding.LateCall(objectValue2, (Type) null, "PrintOut", new object[1]
      {
        (object) false
      }, new string[1]{ "Background" }, (Type[]) null, (bool[]) null, true);
      UltraProgressBar progress5;
      int num5 = (progress5 = frmPleaseWait1.progress).Value + 1;
      progress5.Value = num5;
      frmPleaseWait1.Refresh();
    }
    finally
    {
      NewLateBinding.LateCall(objectValue2, (Type) null, "Close", new object[0], (string[]) null, (Type[]) null, (bool[]) null, true);
      NewLateBinding.LateCall(objectValue1, (Type) null, "Quit", new object[1]
      {
        (object) false
      }, (string[]) null, (Type[]) null, (bool[]) null, true);
      Marshal.FinalReleaseComObject(RuntimeHelpers.GetObjectValue(objectValue2));
      Marshal.FinalReleaseComObject(RuntimeHelpers.GetObjectValue(objectValue1));
      frmPleaseWait1?.Close();
    }
  }

  public void ShowMergedDocument(params object[] args)
  {
    this._args = args;
    this._tempFilename = this.CreateMergeDocument(args);
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this._tempFilename, string.Empty, false) == 0)
      return;
    byte[] origHash = (byte[]) null;
    using (FileStream inputStream = new FileStream(this._tempFilename, FileMode.Open, FileAccess.Read, FileShare.Read))
    {
      origHash = new MD5CryptoServiceProvider().ComputeHash((Stream) inputStream);
      inputStream.Close();
    }
    this.wordTmpl = new WordTemplate(this._tempFilename, (Form) null, (object) new TemplateHash(0, origHash));
  }

  public void CreateAdditionalDocument(params object[] args)
  {
    this._args = args;
    this._tempFilename = this.CreateMergeDocument(args);
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this._tempFilename, string.Empty, false) == 0)
      return;
    DocumentHandling.SaveTemplateToDocumentHandler(this._templateID, new WordDocumentSavedEventArgs(this._tempFilename), (ISupportDocumentSystem) new Quote(new Guid(args[0].ToString())));
  }

  public void CreateDriverDocuments(List<object> driverIDs, Guid quoteGuid)
  {
    Dictionary<string, DataRow> tmpFiles = new Dictionary<string, DataRow>();
    int num = driverIDs.Count - 1;
    for (int index = 0; index <= num; ++index)
    {
      DataRow driverId = (DataRow) driverIDs[index];
      this._args = new object[1]
      {
        (object) driverId.Field<long>("DriverID")
      };
      this._tempFilename = this.CreateMergeDocument(this._args);
      if (!string.IsNullOrEmpty(this._tempFilename))
        tmpFiles.Add(this._tempFilename, driverId);
    }
    DocumentHandling.SaveDriverTemplateToDocumentHandler(this._templateID, (ISupportDocumentSystem) new Quote(quoteGuid), tmpFiles);
  }

  public void CreateAddlInterestDocuments(List<object> interestIDs)
  {
    this._isAdditionalInterestDocType = true;
    Dictionary<string, DataRow> tmpFiles = new Dictionary<string, DataRow>();
    Guid quoteGuid = Guid.Empty;
    int num1 = interestIDs.Count - 1;
    for (int index = 0; index <= num1; ++index)
    {
      DataRow interestId = (DataRow) interestIDs[index];
      this._args = new object[1]
      {
        (object) interestId.Field<int>("ID")
      };
      int num2 = interestId.Field<int>("QuoteID");
      if (quoteGuid == Guid.Empty)
      {
        object obj = DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT QuoteGuid FROM tblQuotes (NOLOCK) WHERE QuoteID = @QuoteID", new object[2]
        {
          (object) "@QuoteID",
          (object) num2
        });
        quoteGuid = obj != null ? (Guid) obj : new Guid();
      }
      this._tempFilename = this.CreateMergeDocument(this._args);
      if (!string.IsNullOrEmpty(this._tempFilename))
        tmpFiles.Add(this._tempFilename, interestId);
    }
    DocumentHandling.SaveAddlInterestTemplateToDocumentHandler(this._templateID, (ISupportDocumentSystem) new Quote(quoteGuid), tmpFiles);
  }

  public static void RegionMerging_FieldMerging(object sender, MergeFieldEventArgs e)
  {
    int index1 = e.RecordIndex;
    if (DocumentHandling.currentRegion != null && !string.IsNullOrEmpty(e.TableName) && index1 > -1 && DocumentHandling.currentRegion.Tables.Contains(e.TableName))
    {
      DataTable table = DocumentHandling.currentRegion.Tables[e.TableName];
      if (table.ParentRelations.Count > 0)
      {
        DataTable parentTable = table.ParentRelations[0].ParentTable;
        int index2 = 0;
        if (DocumentHandling.TableIndices.TryGetValue(parentTable.TableName, out index2))
        {
          DataRow[] childRows = parentTable.Rows[index2].GetChildRows(table.ParentRelations[0]);
          if (childRows != null && childRows.Length > e.RecordIndex)
          {
            DataRow row = childRows[e.RecordIndex];
            index1 = table.Rows.IndexOf(row);
          }
        }
      }
      if (table.ChildRelations.Count > 0)
        DocumentHandling.TableIndices[table.TableName] = index1;
    }
    DocTag tag = new DocTag();
    tag.TagName = e.FieldName;
    if (DocumentHandling.currentRegion != null && e.FieldValue == null && e.FieldName.IndexOf("(") != -1 && !string.IsNullOrEmpty(e.TableName) && index1 > -1)
    {
      DataRow row = DocumentHandling.currentRegion.Tables[e.TableName].Rows[index1];
      if (DocumentHandling.currentRegion.Tables[e.TableName].Columns.Contains(tag.InnerTagName))
      {
        if (!row.IsNull(tag.InnerTagName))
        {
          tag.TagValue = row[tag.InnerTagName].ToString();
          string functionName = tag.FunctionName;
          if ((Microsoft.VisualBasic.CompilerServices.Operators.CompareString(functionName, "IMG", false) == 0 || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(functionName, "R270", false) == 0 || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(functionName, "R180", false) == 0 || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(functionName, "R90", false) == 0) && row[tag.InnerTagName] is byte[] buffer)
            tag.TagImage = (Image) new Bitmap((Stream) new MemoryStream(buffer));
          TagParserBase.PostProcess(tag);
          e.Text = e.Field.Result.Replace($"«{Strings.Left(e.FieldName, 40)}»", tag.TagValue);
        }
        else
          e.Text = string.Empty;
      }
    }
    if ((e.FieldValue == null || string.IsNullOrEmpty(e.FieldValue.ToString())) && string.IsNullOrEmpty(e.Text))
      return;
    string str1 = e.Field.Result.Replace($"«{Strings.Left(e.FieldName, 40)}»", string.IsNullOrEmpty(e.Text) ? e.FieldValue.ToString() : e.Text);
    try
    {
      switch (str1)
      {
        case "__delete_table":
          MGASystems.AsposeFacade.Words.Node ancestor1 = e.Field.Start.GetAncestor((NodeType) 5);
          if (ancestor1 != null)
          {
            ancestor1.Remove();
            return;
          }
          break;
        case "__delete_row":
          MGASystems.AsposeFacade.Words.Node ancestor2 = e.Field.Start.GetAncestor((NodeType) 6);
          if (ancestor2 != null)
          {
            ancestor2.Remove();
            return;
          }
          break;
        case "__delete_column":
          MGASystems.AsposeFacade.Words.Node ancestor3 = e.Field.Start.GetAncestor((NodeType) 7);
          if (ancestor3 != null)
          {
            ancestor3.Remove();
            return;
          }
          break;
      }
    }
    catch (InvalidOperationException ex1)
    {
      ProjectData.SetProjectError((Exception) ex1);
      InvalidOperationException ex2 = ex1;
      if (ex2.Message.Equals("Cannot remove because there is no parent."))
      {
        ErrorHandler.SilentHandleError((Exception) ex2);
        ProjectData.ClearProjectError();
      }
      else
        throw;
    }
    List<KeyValuePair<string, DocumentHandling.FormatState>> keyValuePairList = (List<KeyValuePair<string, DocumentHandling.FormatState>>) null;
    if (Regex.IsMatch(str1, "<(@|~|_)(.*)(\\1)>", RegexOptions.Singleline))
    {
      try
      {
        keyValuePairList = DocumentHandling.ParseStyleFormats(str1);
      }
      catch (FormatException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        ErrorHandler.SilentHandleError((Exception) ex);
        ProjectData.ClearProjectError();
        return;
      }
    }
    else if (!tag.IsHtmlTag && !tag.IsImageTag)
      return;
    if (keyValuePairList != null && keyValuePairList.Count > 0 || tag.IsHtmlTag)
    {
      DocumentBuilder documentBuilder = new DocumentBuilder(e.Document);
      documentBuilder.MoveToField(e.Field, false);
      if (tag.IsHtmlTag)
      {
        documentBuilder.InsertHtml(str1);
      }
      else
      {
        object[] objArray = new object[3]
        {
          (object) documentBuilder.Font.Italic,
          (object) documentBuilder.Font.Bold,
          (object) documentBuilder.Font.Underline
        };
        try
        {
          foreach (KeyValuePair<string, DocumentHandling.FormatState> keyValuePair in keyValuePairList)
          {
            documentBuilder.Font.Italic = (keyValuePair.Value & DocumentHandling.FormatState.Italic) == DocumentHandling.FormatState.Italic;
            documentBuilder.Font.Bold = (keyValuePair.Value & DocumentHandling.FormatState.Bold) == DocumentHandling.FormatState.Bold;
            documentBuilder.Font.Underline = (keyValuePair.Value & DocumentHandling.FormatState.Underline) == DocumentHandling.FormatState.Underline ? (Underline) 1 : (Underline) 0;
            documentBuilder.Write(keyValuePair.Key);
          }
        }
        finally
        {
          List<KeyValuePair<string, DocumentHandling.FormatState>>.Enumerator enumerator;
          enumerator.Dispose();
        }
        documentBuilder.Font.Italic = Conversions.ToBoolean(objArray[0]);
        documentBuilder.Font.Bold = Conversions.ToBoolean(objArray[1]);
        documentBuilder.Font.Underline = (Underline) objArray[2];
      }
      e.Text = string.Empty;
    }
    if (!tag.IsImageTag)
      return;
    DocumentBuilder documentBuilder1 = new DocumentBuilder(e.Document);
    documentBuilder1.MoveToField(e.Field, false);
    Shape shape = documentBuilder1.InsertImage(tag.TagImage);
    shape.WrapType = (WrapType) 3;
    shape.BehindText = true;
    e.Text = string.Empty;
    double num1 = 72.0;
    double num2 = 96.0;
    double a = (documentBuilder1.Font.Size + documentBuilder1.ParagraphFormat.LineSpacing) / num1 * num2;
    int num3 = (int) Math.Round(a + a);
    int height = tag.TagImage.Height;
    int num4 = (int) Math.Round(a);
    for (int index3 = num3; (num4 >> 31 /*0x1F*/ ^ index3) <= (num4 >> 31 /*0x1F*/ ^ height); index3 += num4)
    {
      MergeFieldEventArgs mergeFieldEventArgs;
      string str2 = (mergeFieldEventArgs = e).Text + Environment.NewLine;
      mergeFieldEventArgs.Text = str2;
    }
  }

  private static List<KeyValuePair<string, DocumentHandling.FormatState>> ParseStyleFormats(
    string fieldString)
  {
    List<KeyValuePair<string, DocumentHandling.FormatState>> styleFormats = new List<KeyValuePair<string, DocumentHandling.FormatState>>();
    StringBuilder stringBuilder1 = new StringBuilder();
    DocumentHandling.FormatState formatState = DocumentHandling.FormatState.None;
    DocumentHandling.ParseState parseState = DocumentHandling.ParseState.Outside;
    using (StringReader stringReader = new StringReader(fieldString))
    {
      do
      {
        int CharCode = stringReader.Read();
        switch (parseState)
        {
          case DocumentHandling.ParseState.Outside:
            switch (CharCode)
            {
              case -1:
                parseState = DocumentHandling.ParseState.Finish;
                break;
              case 60:
                parseState = DocumentHandling.ParseState.StartFormat;
                break;
              default:
                stringBuilder1.Append(Strings.Chr(CharCode));
                break;
            }
            break;
          case DocumentHandling.ParseState.Inside:
            switch (CharCode)
            {
              case -1:
                throw new FormatException(string.Format("Invalid styling format specified. Unexpectedly reached end of field.{1}'{0}'", (object) fieldString, (object) Environment.NewLine));
              case 60:
                parseState = DocumentHandling.ParseState.StartFormat;
                break;
              case 64 /*0x40*/:
              case 95:
              case 126:
                parseState = DocumentHandling.ParseState.EndFormat;
                stringBuilder1.Append(Strings.Chr(CharCode));
                break;
              default:
                stringBuilder1.Append(Strings.Chr(CharCode));
                break;
            }
            break;
          case DocumentHandling.ParseState.StartFormat:
            switch (CharCode)
            {
              case -1:
                stringBuilder1.Append('<');
                parseState = DocumentHandling.ParseState.Finish;
                break;
              case 64 /*0x40*/:
              case 95:
              case 126:
                if (stringBuilder1.Length > 0)
                  styleFormats.Add(new KeyValuePair<string, DocumentHandling.FormatState>(stringBuilder1.ToString(), formatState));
                stringBuilder1 = new StringBuilder();
                DocumentHandling.FormatState format1 = DocumentHandling.FormatDictionary[Strings.Chr(CharCode)];
                if ((formatState & format1) == format1)
                {
                  stringBuilder1.Append(stringReader.ReadToEnd());
                  throw new FormatException(string.Format("Invalid styling format specified.{1}Open tag for {2} style found at position {3} is already applied.{1}{0}", (object) fieldString, (object) Environment.NewLine, (object) format1.ToString(), (object) (fieldString.LastIndexOf(stringBuilder1.ToString()) - 1)));
                }
                formatState |= DocumentHandling.FormatDictionary[Strings.Chr(CharCode)];
                parseState = DocumentHandling.ParseState.Inside;
                break;
              default:
                parseState = formatState == DocumentHandling.FormatState.None ? DocumentHandling.ParseState.Outside : DocumentHandling.ParseState.Inside;
                stringBuilder1.Append('<');
                stringBuilder1.Append(Strings.Chr(CharCode));
                break;
            }
            break;
          case DocumentHandling.ParseState.EndFormat:
            if (CharCode == -1)
              throw new FormatException(string.Format("Invalid styling format specified.{1}Unexpectedly reached end of field.{1}{0}", (object) fieldString, (object) Environment.NewLine));
            if (CharCode == 62)
            {
              DocumentHandling.FormatState format2 = DocumentHandling.FormatDictionary[stringBuilder1[stringBuilder1.Length - 1]];
              StringBuilder stringBuilder2;
              int num = (stringBuilder2 = stringBuilder1).Length - 1;
              stringBuilder2.Length = num;
              if (stringBuilder1.Length > 0)
                styleFormats.Add(new KeyValuePair<string, DocumentHandling.FormatState>(stringBuilder1.ToString(), formatState));
              stringBuilder1 = new StringBuilder();
              if ((formatState & format2) != format2)
              {
                stringBuilder1.Append(stringReader.ReadToEnd());
                throw new FormatException(string.Format("Invalid styling format specified.{1}Closing tag for {2} style at index {3} does not have corresponding open tag.{1}{0}", (object) fieldString, (object) Environment.NewLine, (object) format2.ToString(), (object) (fieldString.LastIndexOf(stringBuilder1.ToString()) - 2)));
              }
              formatState &= ~format2;
              parseState = formatState == DocumentHandling.FormatState.None ? DocumentHandling.ParseState.Outside : DocumentHandling.ParseState.Inside;
              break;
            }
            stringBuilder1.Append(Strings.Chr(CharCode));
            parseState = DocumentHandling.ParseState.Inside;
            break;
        }
      }
      while (parseState != DocumentHandling.ParseState.Finish);
      if (stringBuilder1.Length > 0)
        styleFormats.Add(new KeyValuePair<string, DocumentHandling.FormatState>(stringBuilder1.ToString(), formatState));
    }
    return styleFormats;
  }

  private static Dictionary<char, DocumentHandling.FormatState> FormatDictionary
  {
    get
    {
      if (DocumentHandling._formatDictionary == null)
      {
        DocumentHandling._formatDictionary = new Dictionary<char, DocumentHandling.FormatState>();
        DocumentHandling._formatDictionary['~'] = DocumentHandling.FormatState.Italic;
        DocumentHandling._formatDictionary['@'] = DocumentHandling.FormatState.Bold;
        DocumentHandling._formatDictionary['_'] = DocumentHandling.FormatState.Underline;
      }
      return DocumentHandling._formatDictionary;
    }
  }

  protected void SaveFileToDocumentHandler(
    WordDocumentSavedEventArgs e,
    ISupportDocumentSystem ObjectToBindTo)
  {
    if (e == null)
      throw new ArgumentNullException(nameof (e));
    object objectValue = RuntimeHelpers.GetObjectValue(Database.Instance.QueryText.PerformScalarQuery("SELECT Description FROM tblDocumentTemplates WHERE TemplateID=@ID", (object) "@ID", (object) this._templateID));
    string empty = string.Empty;
    string str = (objectValue == null ? this._templateName.Replace(" ", "_") : $"{this._templateName} - {objectValue.ToString()}").Replace("/", "_") + ".doc";
    if (File.Exists(str))
      File.Delete(str);
    int num1 = 0;
    do
    {
      try
      {
        File.Copy(e.FileName, str);
        break;
      }
      catch (UnauthorizedAccessException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        UnauthorizedAccessException unauthorizedAccessException = ex;
        if (num1 == 3)
        {
          int num2 = (int) MessageBox.Show($"The system could not access {e.FileName}\n\n{unauthorizedAccessException.Message}", "Unauthorized Access", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }
        else
          Thread.Sleep(1000);
        ProjectData.ClearProjectError();
      }
      catch (IOException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        IOException ioException = ex;
        if (num1 == 3)
        {
          int num3 = (int) MessageBox.Show($"The system could not create a temporary copy of {e.FileName}\n\n{ioException.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }
        else
          Thread.Sleep(1000);
        ProjectData.ClearProjectError();
      }
      ++num1;
    }
    while (num1 <= 3);
    int folderId = Database.IsNull(RuntimeHelpers.GetObjectValue(Database.Instance.QueryText.PerformScalarQuery("SELECT FolderID FROM tblDocumentTemplates WHERE TemplateID=@TemplateID", (object) "@TemplateID", (object) this._templateID)), -1);
    if (MGASystems.Common.SystemSettings.KeyExists("AutoConvertWordDocsToPDF") && MGASystems.Common.SystemSettings.GetBoolSetting("AutoConvertWordDocsToPDF"))
      str = PDF.ConvertWordDocToPDF(str);
    DocumentManager.BeginFileAddWithBind(str, folderId, string.Empty, ObjectToBindTo, false);
  }

  public static void SaveTemplateToDocumentHandler(
    int templateID,
    WordDocumentSavedEventArgs e,
    ISupportDocumentSystem objectToBindTo,
    Guid quoteGuid)
  {
    DocumentHandling.SaveTemplateToDocumentHandler(templateID, e, objectToBindTo);
    Messaging.SendBroadcastMessage(BroadcastMessages.TemplateDocumentInstanceCreated, (object) new TemplateDocumentInstanceCreatedInfo(templateID, quoteGuid));
  }

  public static void SaveTemplateToDocumentHandler(
    int templateID,
    WordDocumentSavedEventArgs e,
    ISupportDocumentSystem objectToBindTo)
  {
    if (e == null)
      throw new ArgumentNullException(nameof (e));
    DataRow row1 = Database.Instance.QueryText.PerformRowQuery("SELECT TemplateName, Description, OriginalFileName FROM tblDocumentTemplates WHERE TemplateID=@ID", (object) "@ID", (object) templateID);
    string str1 = ".doc";
    string str2 = Conversions.ToString(row1["OriginalFileName"]);
    if (!string.IsNullOrEmpty(str2))
    {
      string path = str2;
      char[] invalidFileNameChars = Path.GetInvalidFileNameChars();
      int index = 0;
      while (index < invalidFileNameChars.Length)
      {
        char ch = invalidFileNameChars[index];
        path = path.Replace(Conversions.ToString(ch), string.Empty);
        checked { ++index; }
      }
      str1 = Path.GetExtension(path);
    }
    string str3 = string.Empty;
    if (!row1.IsNull("Description"))
    {
      str3 = row1.Field<string>("Description");
      if (!string.IsNullOrEmpty(str3))
        str3 = $" - {str3}";
    }
    string str4 = $"{RuntimeHelpers.GetObjectValue(row1["TemplateName"])}{str3}{str1}";
    char[] invalidFileNameChars1 = Path.GetInvalidFileNameChars();
    int index1 = 0;
    while (index1 < invalidFileNameChars1.Length)
    {
      char ch = invalidFileNameChars1[index1];
      str4 = str4.Replace(Conversions.ToString(ch), string.Empty);
      checked { ++index1; }
    }
    if (File.Exists(str4))
      File.Delete(str4);
    int num1 = 0;
    do
    {
      try
      {
        File.Copy(e.FileName, str4);
        break;
      }
      catch (UnauthorizedAccessException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        UnauthorizedAccessException unauthorizedAccessException = ex;
        if (num1 == 3)
        {
          int num2 = (int) MessageBox.Show($"The system could not access {e.FileName}\n\n{unauthorizedAccessException.Message}", "Unauthorized Access", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }
        else
          Thread.Sleep(1000);
        ProjectData.ClearProjectError();
      }
      catch (IOException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        IOException ioException = ex;
        if (num1 == 3)
        {
          int num3 = (int) MessageBox.Show($"The system could not create a temporary copy of {e.FileName}\n\n{ioException.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }
        else
          Thread.Sleep(1000);
        ProjectData.ClearProjectError();
      }
      ++num1;
    }
    while (num1 <= 3);
    int folderId = Database.IsNull(RuntimeHelpers.GetObjectValue(Database.Instance.QueryText.PerformScalarQuery("SELECT FolderID FROM tblDocumentTemplates WHERE TemplateID=@TemplateID", (object) "@TemplateID", (object) templateID)), -1);
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString((string) DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT SaveAsType FROM tblDocumentTemplates WHERE TemplateID=@TID", new object[2]
    {
      (object) "@TID",
      (object) templateID
    }), "P", false) == 0)
      str4 = PDF.ConvertWordDocToPDF(str4);
    Guid guid = DocumentManager.FileAddWithBind(str4, folderId, string.Empty, (ISupportDocumentSystem) new DocSupportCache(objectToBindTo), false);
    if (MDIControls.Instance.MDIParent.InvokeRequired)
      return;
    Quote quote = !objectToBindTo.ControlGUID.Equals(Guid.Empty) ? Quote.FromControlGuid(objectToBindTo.ControlGUID) : objectToBindTo as Quote;
    if (quote == null)
      return;
    List<string> stringList = new List<string>();
    DataTable dataTable = DefaultDatabase.ExecuteDataTable("GetViewPrintEmailAddresses", new object[2]
    {
      (object) "@QuoteGuid",
      (object) quote.QuoteGuid
    });
    try
    {
      foreach (DataRow row2 in dataTable.Rows)
        stringList.Add(row2["email"].ToString());
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    frmViewPrintEmail frmViewPrintEmail = new frmViewPrintEmail(new List<Guid>()
    {
      guid
    }.ToArray(), stringList.ToArray(), quote);
    frmViewPrintEmail.MdiParent = MDIControls.Instance.MDIParent;
    frmViewPrintEmail.ShowInTaskbar = false;
    frmViewPrintEmail.Show();
  }

  public static void SaveDriverTemplateToDocumentHandler(
    int templateID,
    ISupportDocumentSystem objectToBindTo,
    Dictionary<string, DataRow> tmpFiles)
  {
    DataRow dataRow = DefaultDatabase.ExecuteDataRow(CommandType.Text, "SELECT TemplateName, Description FROM tblDocumentTemplates WHERE TemplateID=@ID", new object[2]
    {
      (object) "@ID",
      (object) templateID
    });
    int fldrID = Database.IsNull(RuntimeHelpers.GetObjectValue(Database.Instance.QueryText.PerformScalarQuery("SELECT FolderID FROM tblDocumentTemplates WHERE TemplateID=@TemplateID", (object) "@TemplateID", (object) templateID)), -1);
    string saveAsType = (string) DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT SaveAsType FROM tblDocumentTemplates WHERE TemplateID=@TID", new object[2]
    {
      (object) "@TID",
      (object) templateID
    });
    List<(string, string)> files = new List<(string, string)>();
    string setting = MGASystems.IMS.NoteDocuments.SystemSettings.GetSetting<string>("DriverDocumentNameFormat", "{FirstName} {LastName}");
    try
    {
      foreach (KeyValuePair<string, DataRow> tmpFile in tmpFiles)
      {
        string str = frmDocumentNaming.ResolveString(setting, tmpFile.Value) + ".doc";
        char[] invalidFileNameChars = Path.GetInvalidFileNameChars();
        int index = 0;
        while (index < invalidFileNameChars.Length)
        {
          char ch = invalidFileNameChars[index];
          str = str.Replace(Conversions.ToString(ch), string.Empty);
          checked { ++index; }
        }
        files.Add((tmpFile.Key, str));
      }
    }
    finally
    {
      Dictionary<string, DataRow>.Enumerator enumerator;
      enumerator.Dispose();
    }
    List<Guid> guidList = DocumentManager.BeginDriverFileAddWithBind(files, fldrID, Conversions.ToString(dataRow["Description"]), (ISupportDocumentSystem) new DocSupportCache(objectToBindTo), false, saveAsType);
    if (MDIControls.Instance.MDIParent.InvokeRequired)
      return;
    Quote quote = !objectToBindTo.ControlGUID.Equals(Guid.Empty) ? Quote.FromControlGuid(objectToBindTo.ControlGUID) : objectToBindTo as Quote;
    if (quote == null)
      return;
    List<string> stringList = new List<string>();
    DataTable dataTable = DefaultDatabase.ExecuteDataTable("GetViewPrintEmailAddresses", new object[2]
    {
      (object) "@QuoteGuid",
      (object) quote.QuoteGuid
    });
    try
    {
      foreach (DataRow row in dataTable.Rows)
        stringList.Add(row["email"].ToString());
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    frmViewPrintEmail frmViewPrintEmail = new frmViewPrintEmail(guidList.ToArray(), stringList.ToArray(), quote);
    frmViewPrintEmail.MdiParent = MDIControls.Instance.MDIParent;
    frmViewPrintEmail.ShowInTaskbar = false;
    frmViewPrintEmail.Show();
  }

  public static void SaveAddlInterestTemplateToDocumentHandler(
    int templateID,
    ISupportDocumentSystem objectToBindTo,
    Dictionary<string, DataRow> tmpFiles)
  {
    DataRow dataRow = DefaultDatabase.ExecuteDataRow(CommandType.Text, "SELECT TemplateName, Description FROM tblDocumentTemplates WHERE TemplateID=@ID", new object[2]
    {
      (object) "@ID",
      (object) templateID
    });
    int fldrID = Database.IsNull(RuntimeHelpers.GetObjectValue(Database.Instance.QueryText.PerformScalarQuery("SELECT FolderID FROM tblDocumentTemplates WHERE TemplateID=@TemplateID", (object) "@TemplateID", (object) templateID)), -1);
    string saveAsType = (string) DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT SaveAsType FROM tblDocumentTemplates WHERE TemplateID=@TID", new object[2]
    {
      (object) "@TID",
      (object) templateID
    });
    List<(string, string)> files = new List<(string, string)>();
    string setting = MGASystems.IMS.NoteDocuments.SystemSettings.GetSetting<string>("AddlInterestDocumentNameFormat", "{InterestName}");
    try
    {
      foreach (KeyValuePair<string, DataRow> tmpFile in tmpFiles)
      {
        string str = frmDocumentNaming.ResolveString(setting, tmpFile.Value) + ".doc";
        char[] invalidFileNameChars = Path.GetInvalidFileNameChars();
        int index = 0;
        while (index < invalidFileNameChars.Length)
        {
          char ch = invalidFileNameChars[index];
          str = str.Replace(Conversions.ToString(ch), string.Empty);
          checked { ++index; }
        }
        files.Add((tmpFile.Key, str));
      }
    }
    finally
    {
      Dictionary<string, DataRow>.Enumerator enumerator;
      enumerator.Dispose();
    }
    List<Guid> guidList = DocumentManager.BeginDriverFileAddWithBind(files, fldrID, Conversions.ToString(dataRow["Description"]), (ISupportDocumentSystem) new DocSupportCache(objectToBindTo), false, saveAsType);
    if (MDIControls.Instance.MDIParent.InvokeRequired)
      return;
    Quote quote = !objectToBindTo.ControlGUID.Equals(Guid.Empty) ? Quote.FromControlGuid(objectToBindTo.ControlGUID) : objectToBindTo as Quote;
    if (quote == null)
      return;
    List<string> stringList = new List<string>();
    DataTable dataTable = DefaultDatabase.ExecuteDataTable("GetViewPrintEmailAddresses", new object[2]
    {
      (object) "@QuoteGuid",
      (object) quote.QuoteGuid
    });
    try
    {
      foreach (DataRow row in dataTable.Rows)
        stringList.Add(row["email"].ToString());
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    frmViewPrintEmail frmViewPrintEmail = new frmViewPrintEmail(guidList.ToArray(), stringList.ToArray(), quote);
    frmViewPrintEmail.MdiParent = MDIControls.Instance.MDIParent;
    frmViewPrintEmail.ShowInTaskbar = false;
    frmViewPrintEmail.Show();
  }

  protected virtual void WordDocumentSaved(object sender, WordDocumentSavedEventArgs e)
  {
    try
    {
      if (e == null)
        throw new ArgumentNullException(nameof (e));
      if (string.IsNullOrEmpty(e.FileName))
        throw new InvalidOperationException("FileName is null in WordDocumentSaved");
      if (!File.Exists(e.FileName))
        throw new InvalidOperationException("Word document does not exist in WordDocumentSaved");
      if (this._automationGroup == Enums.AutomationDocGroups.PolicyDoc || this._automationGroup == Enums.AutomationDocGroups.InvoiceDoc)
      {
        Guid quoteGuid;
        if (this._automationGroup == Enums.AutomationDocGroups.PolicyDoc)
          quoteGuid = (Guid) this._args[0];
        else
          quoteGuid = (Guid) Database.Instance.QueryText.PerformScalarQuery("SELECT QuoteGuid FROM tblQuotes Q INNER JOIN tblFin_Invoices I ON Q.QuoteID=I.QuoteID WHERE InvoiceNum=@IVN", (object) "@IVN", (object) (int) this._args[0]);
        DocumentHandling.SaveTemplateToDocumentHandler(this._templateID, e, (ISupportDocumentSystem) new Quote(quoteGuid), quoteGuid);
      }
      else if (this._automationGroup == Enums.AutomationDocGroups.SubmissionDoc)
      {
        Guid submissionGroupGuid = (Guid) this._args[0];
        DocumentHandling.SaveTemplateToDocumentHandler(this._templateID, e, (ISupportDocumentSystem) new SubmissionGroup(submissionGroupGuid));
      }
      else if (this._automationGroup == Enums.AutomationDocGroups.DriverDoc)
      {
        object obj = DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT QuoteGuid FROM tblDriverInfo (NOLOCK) WHERE DriverID = @DriverID", new object[2]
        {
          (object) "@DriverID",
          (object) (long) this._args[0]
        });
        Guid quoteGuid = obj != null ? (Guid) obj : new Guid();
        DocumentHandling.SaveTemplateToDocumentHandler(this._templateID, e, (ISupportDocumentSystem) new Quote(quoteGuid), quoteGuid);
      }
      else
        this.SendToCurrentEntity((int) this._automationGroup, this._templateID, e, this._args);
    }
    finally
    {
      Cursor.Current = MgaCursors.Default;
    }
  }

  public virtual void SendToCurrentEntity(
    int automationGroup,
    int templateId,
    WordDocumentSavedEventArgs e,
    object[] args)
  {
  }

  private void wordTmpl_WordAppClosed(object sender, EventArgs e)
  {
    if (this.wordTmpl.FileChanged)
    {
      bool flag = true;
      if (!WordTemplate.UseWordWithEvents() && MessageBox.Show("Save changes to template?", "Save changes?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
      {
        flag = false;
        this.wordTmpl.RevertToOriginalFile();
      }
      if (flag)
        MDIControls.Instance.MDIParent.Invoke((Delegate) new DocumentHandling.SaveDocumentWordAppHandler(this.WordDocumentSaved), (object) this, (object) new WordDocumentSavedEventArgs(this.wordTmpl.FileName));
    }
    Cursor.Current = MgaCursors.Default;
  }

  private void wordTmpl_WordAppSaving(object sender, EventArgs e)
  {
    if (MDIControls.Instance.MDIParent.InvokeRequired)
      MDIControls.Instance.MDIParent.Invoke((Delegate) ([SpecialName] (a0) => this.WordAppSaving()), new object());
    else
      Cursor.Current = MgaCursors.WaitCursor;
  }

  private void WordAppSaving() => Cursor.Current = MgaCursors.WaitCursor;

  public string GenerateEmailBody(Guid quoteGuid)
  {
    string empty = string.Empty;
    using (MemoryStream memoryStream = new MemoryStream())
    {
      new Document(this.CreateMergeDocument((object) quoteGuid)).Save((Stream) memoryStream, (SaveFormat) 4);
      memoryStream.Position = 0L;
      using (StreamReader streamReader = new StreamReader((Stream) memoryStream))
        return streamReader.ReadToEnd();
    }
  }

  public enum DocumentTypes
  {
    PolicyDoc = 1,
  }

  public enum ParseState
  {
    Outside,
    Inside,
    StartFormat,
    EndFormat,
    Finish,
  }

  [Flags]
  public enum FormatState
  {
    None = 0,
    Italic = 1,
    Bold = 2,
    Underline = 4,
  }

  private delegate void SaveDocumentWordAppHandler(object sender, WordDocumentSavedEventArgs e);

  private delegate void WordAppSavingHandler(object obj);
}
