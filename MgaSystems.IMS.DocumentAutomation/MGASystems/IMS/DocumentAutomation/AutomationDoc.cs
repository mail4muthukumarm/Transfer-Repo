// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.DocumentAutomation.AutomationDoc
// Assembly: MgaSystems.IMS.DocumentAutomation, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: B33F9A76-E654-4386-A032-7A12D7CD66DE
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.DocumentAutomation.dll

using MGASystems.Common;
using MGASystems.Data;
using System;
using System.Data;
using System.IO;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.DocumentAutomation;

public class AutomationDoc : IComparable, IComparable<AutomationDoc>
{
  private object _documentID;
  private int _sortOrder;
  private int _endorsementNumber;
  private int _placedByCompanyLineID;
  private int _policyFormID;
  private bool _includeWithQuotation;
  private bool _fileOnly;
  private bool _separateDocument;
  private string _fileOnlyName;
  private string _separateDocumentName;
  private int _companyAutomationDocumentID;
  private string _oncePer;

  public bool EventDocument { get; set; }

  public int PlacedByCompanyLineID => this._placedByCompanyLineID;

  public int PolicyFormID => this._policyFormID;

  public string OncePer => this._oncePer;

  public int EndorsementNumber => this._endorsementNumber;

  public bool HasEndorsementNumber => this._endorsementNumber != -1;

  public AutomationDoc.DocType DocumentType
  {
    get
    {
      return !(this._documentID is Guid) ? (!(this._documentID is int) ? (!(this._documentID is MemoryStream) ? AutomationDoc.DocType.None : AutomationDoc.DocType.PDF) : AutomationDoc.DocType.TemplateDocument) : AutomationDoc.DocType.AutomationReport;
    }
  }

  public int SortOrder => this._sortOrder;

  public Guid AutomationReportGuid => (Guid) this._documentID;

  public int TemplateID => (int) this._documentID;

  public bool FileOnly
  {
    get
    {
      if (this.DocumentType == AutomationDoc.DocType.TemplateDocument)
        return this._fileOnly;
      throw new InvalidOperationException("FileOnly property is only valid for template documents");
    }
  }

  public string FileOnlyName
  {
    get
    {
      if (this.DocumentType == AutomationDoc.DocType.TemplateDocument)
        return this._fileOnlyName;
      throw new InvalidOperationException("FileOnly property is only valid for template documents");
    }
  }

  public bool SeparateDocument
  {
    get
    {
      if (this.DocumentType == AutomationDoc.DocType.TemplateDocument)
        return this._separateDocument;
      throw new InvalidOperationException("SeparateDoc property is only valid for template documents");
    }
  }

  public string SeparateDocumentName
  {
    get
    {
      if (this.DocumentType == AutomationDoc.DocType.TemplateDocument)
        return this._separateDocumentName;
      throw new InvalidOperationException("SeparateDocumentName property is only valid for template documents");
    }
  }

  public MemoryStream PDF => (MemoryStream) this._documentID;

  public bool IncludeWithQuotation
  {
    get => this._includeWithQuotation;
    set => this._includeWithQuotation = value;
  }

  public int CompanyAutomationDocumentID
  {
    get => this._companyAutomationDocumentID;
    set => this._companyAutomationDocumentID = value;
  }

  public string TemplateType { get; }

  public string OriginalTemplateName { get; }

  public string SaveAsType { get; }

  public string TemplateName { get; }

  public int? GroupOrder { get; }

  public AutomationDoc(object documentID, int sortOrder, int endorsementNumber)
  {
    this._placedByCompanyLineID = -1;
    this._policyFormID = -1;
    this._oncePer = string.Empty;
    this.EventDocument = false;
    this._documentID = RuntimeHelpers.GetObjectValue(documentID);
    this._sortOrder = sortOrder;
    this._endorsementNumber = endorsementNumber;
    if (this.DocumentType != AutomationDoc.DocType.TemplateDocument)
      return;
    DataRow row = DefaultDatabase.ExecuteDataRow(CommandType.Text, "SELECT TemplateType, OriginalFileName, SaveAsType, TemplateName, FileOnly, FileOnlyName, SeparateDoc, SeparateDocName FROM tblDocumentTemplates WHERE TemplateID = @TemplateID", new object[2]
    {
      (object) "@TemplateID",
      (object) this.TemplateID
    });
    this.TemplateType = row.Field<string>(nameof (TemplateType));
    this.OriginalTemplateName = row.Field<string>("OriginalFileName");
    this.SaveAsType = row.Field<string>(nameof (SaveAsType));
    this.TemplateName = row.Field<string>(nameof (TemplateName));
    this._fileOnly = row.Field<bool>(nameof (FileOnly));
    this._fileOnlyName = row.Field<string>(nameof (FileOnlyName)) ?? string.Empty;
    this._separateDocument = row.Field<bool>("SeparateDoc");
    this._separateDocumentName = row.Field<string>("SeparateDocName") ?? string.Empty;
  }

  public AutomationDoc(
    object documentID,
    int sortOrder,
    int endorsementNumber,
    int placedByCompanyLineID)
    : this(RuntimeHelpers.GetObjectValue(documentID), sortOrder, endorsementNumber)
  {
    this._placedByCompanyLineID = placedByCompanyLineID;
  }

  public AutomationDoc(
    object documentID,
    int sortOrder,
    int endorsementNumber,
    int placedByCompanyLineID,
    string oncePer)
    : this(RuntimeHelpers.GetObjectValue(documentID), sortOrder, endorsementNumber, placedByCompanyLineID)
  {
    this._oncePer = oncePer;
  }

  public AutomationDoc(
    object documentID,
    int sortOrder,
    int endorsementNumber,
    int placedByCompanyLineID,
    int policyFormID)
    : this(RuntimeHelpers.GetObjectValue(documentID), sortOrder, endorsementNumber, placedByCompanyLineID)
  {
    this._policyFormID = policyFormID;
  }

  public AutomationDoc(
    object documentID,
    int sortOrder,
    int endorsementNumber,
    int placedByCompanyLineID,
    string oncePer,
    int policyFormID)
    : this(RuntimeHelpers.GetObjectValue(documentID), sortOrder, endorsementNumber, placedByCompanyLineID, policyFormID)
  {
    this._oncePer = oncePer;
  }

  public virtual int CompareTo(AutomationDoc doc)
  {
    int num = -this.EventDocument.CompareTo(doc.EventDocument);
    if (num == 0)
      num = this._endorsementNumber.CompareTo(doc._endorsementNumber);
    if (num == 0)
      num = Nullable.Compare<int>(this.GroupOrder, doc.GroupOrder);
    if (num == 0)
      num = this._sortOrder.CompareTo(doc._sortOrder);
    if (num == 0)
      num = this._policyFormID.CompareTo(doc._policyFormID);
    return num;
  }

  public virtual int CompareTo(object obj) => this.CompareTo((AutomationDoc) obj);

  public byte[] GetTemplateByteArray(int quoteID)
  {
    return DefaultDatabase.ExecuteScalar<byte[]>("dbo.GetExcelTemplate", new object[4]
    {
      (object) "@QuoteID",
      (object) quoteID,
      (object) "@TemplateID",
      (object) this.TemplateID
    });
  }

  public static AutomationDoc Create(params object[] @params)
  {
    return ObjectFactory.Instance.CreateObjectAs<AutomationDoc>(@params);
  }

  public enum DocType
  {
    None,
    TemplateDocument,
    AutomationReport,
    PDF,
  }
}
