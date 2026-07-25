// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.DocumentAutomation.DocumentConditional
// Assembly: MgaSystems.IMS.DocumentAutomation, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: B33F9A76-E654-4386-A032-7A12D7CD66DE
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.DocumentAutomation.dll

using Mga.Wpf.Ims.Commands;
using MGASystems.Data;
using MGASystems.Data.Binding;
using MGASystems.Data.ChangeTracking;
using MGASystems.Data.DataMapping;
using MGASystems.Data.Validation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.DocumentAutomation;

[TableMapping("cnCompanyAutomationDocumentsConditional")]
[Description("Document Automation Conditional")]
public abstract class DocumentConditional : BindingObject, IDataErrorInfo
{
  [DataKey]
  [TableFieldMapping]
  public int cnID { get; set; }

  [TrackChanges]
  [TableFieldMapping]
  public int CompanyAutomationDocumentsID { get; set; }

  [TrackChanges]
  [TableFieldMapping]
  [Required]
  [Description("Tag Name")]
  [NotificationProperty]
  public virtual string TagName { get; set; }

  [TrackChanges]
  [TableFieldMapping]
  [Required]
  [Description("Operator")]
  [NotificationProperty]
  public virtual string CheckOperator { get; set; }

  [TrackChanges]
  [TableFieldMapping]
  [Required]
  [Description("Value")]
  [NotificationProperty]
  public virtual string CheckValue { get; set; }

  [TrackChanges]
  [TableFieldMapping]
  [Required]
  [NotificationProperty]
  public virtual int DataStoreID { get; set; }

  [TrackChanges]
  public ObjectRowStateManager CollectionBroker { get; }

  public ChangeManager ChangeManager { get; }

  public bool HasChanges => this.ChangeManager.HasChanges;

  public string this[string columnName] => DataErrorInfoSupport.GetError((object) this, columnName);

  public string Error => DataErrorInfoSupport.GetError((object) this, "");

  public DocumentConditional()
  {
    this.CollectionBroker = new ObjectRowStateManager();
    this.ChangeManager = new ChangeManager();
  }

  public static DocumentConditional Create()
  {
    return NotifyProxyTypeManager.Allocate<DocumentConditional>();
  }

  public static DocumentConditional GetDocumentConditional(int companyAutomationDocID)
  {
    DocumentConditional documentConditional = DocumentConditional.Create();
    DataRow row = DefaultDatabase.ExecuteDataRow("spcnCompanyAutomationDocumentsConditionalGet", new object[2]
    {
      (object) "@CompanyAutomationDocumentsID",
      (object) companyAutomationDocID
    });
    if (row.Table.Rows.Count > 0)
    {
      documentConditional.cnID = row.Field<int>("cnID");
      documentConditional.CompanyAutomationDocumentsID = row.Field<int>("CompanyAutomationDocumentsID");
      documentConditional.TagName = row.Field<string>("TagName");
      documentConditional.CheckOperator = row.Field<string>("CheckOperator");
      documentConditional.CheckValue = row.Field<string>("CheckValue");
      documentConditional.DataStoreID = row.Field<int>("DataStoreID");
      documentConditional.ChangeManager.Initialize((INotifyPropertyChanged) documentConditional);
    }
    else
    {
      documentConditional.CompanyAutomationDocumentsID = companyAutomationDocID;
      documentConditional.ChangeManager.Initialize((INotifyPropertyChanged) documentConditional);
      documentConditional.CollectionBroker.MarkAdded((INotifyPropertyChanged) documentConditional);
    }
    return documentConditional;
  }

  public static DocumentConditional GetDocumentConditionalReadOnly(int companyAutomationDocID)
  {
    DocumentConditional conditionalReadOnly = DocumentConditional.Create();
    DataRow row = DefaultDatabase.ExecuteDataRow("spcnCompanyAutomationDocumentsConditionalGet", new object[2]
    {
      (object) "@CompanyAutomationDocumentsID",
      (object) companyAutomationDocID
    });
    if (row.Table.Rows.Count > 0)
    {
      conditionalReadOnly.cnID = row.Field<int>("cnID");
      conditionalReadOnly.CompanyAutomationDocumentsID = row.Field<int>("CompanyAutomationDocumentsID");
      conditionalReadOnly.TagName = row.Field<string>("TagName");
      conditionalReadOnly.CheckOperator = row.Field<string>("CheckOperator");
      conditionalReadOnly.CheckValue = row.Field<string>("CheckValue");
      conditionalReadOnly.DataStoreID = row.Field<int>("DataStoreID");
    }
    return conditionalReadOnly;
  }

  public List<ValidationResult> SubmitChanges()
  {
    List<ValidationResult> validationResultList = new List<ValidationResult>();
    if (DataErrorInfoSupport.ValidateModel((IDataErrorInfo) this, validationResultList))
      DatabaseCommands.SubmitAndLogChanges(this.ChangeManager);
    return validationResultList;
  }

  public bool CheckConditional(object tagValue)
  {
    bool flag1;
    if (this.CheckValue.Contains("|"))
    {
      string[] strArray1 = this.CheckValue.Split("|".ToCharArray());
      bool flag2;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.CheckOperator, "=", false) == 0)
      {
        string[] strArray2 = strArray1;
        int index = 0;
        while (index < strArray2.Length)
        {
          flag2 = !this.Compare<string>(strArray2[index], tagValue?.ToString());
          if (!flag2)
            checked { ++index; }
          else
            break;
        }
      }
      else
      {
        string[] strArray3 = strArray1;
        int index = 0;
        while (index < strArray3.Length)
        {
          flag2 = this.Compare<string>(strArray3[index], tagValue?.ToString());
          if (flag2)
            checked { ++index; }
          else
            break;
        }
      }
      flag1 = flag2;
    }
    else
    {
      bool flag3 = this.Compare<string>(this.CheckValue, tagValue?.ToString());
      flag1 = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.CheckOperator, "=", false) != 0 ? flag3 : !flag3;
    }
    return flag1;
  }

  private bool Compare<T>(T currentValue, T value)
  {
    bool flag;
    if ((object) currentValue == null && (object) value == null)
    {
      flag = false;
    }
    else
    {
      if ((object) currentValue is IEquatable<T> || (object) value is IEquatable<T>)
      {
        if (EqualityComparer<T>.Default.Equals(currentValue, value))
        {
          flag = false;
          goto label_8;
        }
      }
      else if (value is IComparable comparable && comparable.CompareTo((object) currentValue) == 0)
      {
        flag = false;
        goto label_8;
      }
      flag = true;
    }
label_8:
    return flag;
  }

  public static void CopyConditional(
    ref ObservableCollection<CompanyLineInfo> copyList,
    int templateID,
    Guid automationEventGuid,
    DocumentConditional conditionToCopy)
  {
    try
    {
      ObservableCollection<CompanyLineInfo> source = copyList;
      System.Func<CompanyLineInfo, bool> predicate;
      // ISSUE: reference to a compiler-generated field
      if (DocumentConditional._Closure\u0024__.\u0024I43\u002D0 != null)
      {
        // ISSUE: reference to a compiler-generated field
        predicate = DocumentConditional._Closure\u0024__.\u0024I43\u002D0;
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        DocumentConditional._Closure\u0024__.\u0024I43\u002D0 = predicate = (System.Func<CompanyLineInfo, bool>) ([SpecialName] (s) => s.Copy);
      }
      foreach (CompanyLineInfo companyLineInfo in source.Where<CompanyLineInfo>(predicate))
      {
        DataTable dataTable = DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT ID FROM tblCompanyAutomationDocuments WHERE TemplateID = @TemplateID AND CompanyLineGuid = @CompanyLineGuid AND AutomationEventGuid = @AutomationEventGuid", new object[6]
        {
          (object) "@TemplateID",
          (object) templateID,
          (object) "@CompanyLineGuid",
          (object) companyLineInfo.CompanyLineGuid,
          (object) "@AutomationEventGuid",
          (object) automationEventGuid
        });
        if (dataTable.Rows.Count == 1)
        {
          int companyAutomationDocID = dataTable.Rows[0].Field<int>("ID");
          DocumentConditional documentConditional = DocumentConditional.GetDocumentConditional(companyAutomationDocID);
          documentConditional.CompanyAutomationDocumentsID = companyAutomationDocID;
          documentConditional.TagName = conditionToCopy.TagName;
          documentConditional.CheckOperator = conditionToCopy.CheckOperator;
          documentConditional.CheckValue = conditionToCopy.CheckValue;
          documentConditional.DataStoreID = conditionToCopy.DataStoreID;
          documentConditional.SubmitChanges();
        }
      }
    }
    finally
    {
      IEnumerator<CompanyLineInfo> enumerator;
      enumerator?.Dispose();
    }
  }
}
