// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Excel.Data.Administration2.ExcelMapping
// Assembly: MgaSystems.IMS.Excel, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D783CE96-8BF7-4BCA-9997-5F16C01589C2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Excel.dll

using MGASystems.Common;
using MGASystems.Data;
using MGASystems.Data.Binding;
using MGASystems.Data.ChangeTracking;
using MGASystems.Data.DataMapping;
using MGASystems.Data.Validation;
using MGASystems.IMS.Excel.TagParsing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.SqlTypes;
using System.Globalization;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Excel.Data.Administration2;

[Description("Excel Mapping")]
[TableMapping("tblExcelRating_Mappings")]
public abstract class ExcelMapping : 
  DependentBindingObject,
  IEditableObject,
  IDataErrorInfo,
  IDataTransferFilter
{
  private bool isCopy;
  private string raterNameOverride;

  public string TagParserTagNameOverride { get; set; }

  [DataKey]
  [TableFieldMapping]
  public int? Id { get; set; }

  [System.ComponentModel.DataAnnotations.Required]
  [StringLength(35)]
  [RegularExpression("^[a-zA-Z0-9_' '!.-]*$")]
  [TrackChanges]
  [TableFieldMapping]
  [NotificationProperty]
  public virtual string Cell { get; set; }

  [System.ComponentModel.DataAnnotations.Required]
  [StringLength(50)]
  [RegularExpression("^[a-zA-Z0-9_]*$")]
  [TrackChanges]
  [TableFieldMapping]
  [NotificationProperty]
  public virtual string DatabaseField { get; set; }

  [System.ComponentModel.DataAnnotations.Required]
  [TrackChanges]
  [NotificationProperty]
  public virtual bool Required { get; set; }

  [System.ComponentModel.DataAnnotations.Required]
  [StringLength(25)]
  [TrackChanges]
  [TableFieldMapping("DatabaseFieldType")]
  [NotificationProperty]
  public virtual string DatabaseType { get; set; }

  [TrackChanges]
  [TableFieldMapping]
  [NotificationProperty]
  public virtual string PremiumOption { get; set; }

  [TableFieldMapping]
  public Guid? ExcelFactorSetId => this.Parent.FactorSetGuid;

  public bool ConvertableToString
  {
    get
    {
      return this.DatabaseType != "System.String" && this.Id.HasValue && this.Parent.FactorSetGuid.HasValue;
    }
  }

  public bool ConvertableToDecimal
  {
    get
    {
      return this.DatabaseType == "System.String" && this.Id.HasValue && this.Parent.FactorSetGuid.HasValue;
    }
  }

  public bool ConvertableToDate
  {
    get
    {
      return this.DatabaseType == "System.String" && this.Id.HasValue && this.Parent.FactorSetGuid.HasValue;
    }
  }

  public bool IsUIEditable => !this.Id.HasValue && !this.isCopy;

  public bool IsPremiumMarkerUIEditable
  {
    get => !this.Id.HasValue && !this.isCopy || CurrentUser.IsMGADeveloper;
  }

  [DependsOn("DatabaseField")]
  [DependsOn("Parent.Parent", "Name")]
  public string ResolvedTagName
  {
    get
    {
      return string.IsNullOrEmpty(this.TagParserTagNameOverride) ? ExcelUserTagParser.CreateTagName(this.Parent.Parent.Name, this.DatabaseField) : ExcelUserTagParser.CreateTagName(this.Parent.Parent.Name, this.TagParserTagNameOverride);
    }
  }

  public ExcelRaterFactorSet Parent { get; private set; }

  public ExcelMapping(ExcelRaterFactorSet parent)
    : this(parent, string.Empty)
  {
  }

  public ExcelMapping(ExcelRaterFactorSet parent, string cell)
  {
    this.Parent = parent;
    this.Cell = cell;
    this.DatabaseType = "System.String";
    this.Required = false;
  }

  public ExcelMapping(ExcelRaterFactorSet parent, ExcelMapping copyMapping)
    : this(parent)
  {
    this.Parent = parent;
    this.Cell = copyMapping.Cell;
    this.DatabaseField = copyMapping.DatabaseField;
    this.TagParserTagNameOverride = copyMapping.TagParserTagNameOverride;
    this.DatabaseType = copyMapping.DatabaseType;
    this.PremiumOption = copyMapping.PremiumOption;
    this.Required = copyMapping.Required;
    this.isCopy = true;
  }

  public ExcelMapping(
    ExcelRaterFactorSet parent,
    int id,
    string cell,
    string databaseField,
    string databaseType,
    string premiumOption,
    string tagParserTagName,
    bool? allowNull)
  {
    this.Parent = parent;
    this.Id = new int?(id);
    this.Cell = cell;
    this.DatabaseField = databaseField;
    this.TagParserTagNameOverride = tagParserTagName;
    this.DatabaseType = databaseType;
    this.PremiumOption = premiumOption;
    this.Required = ((int) allowNull ?? 1) == 0;
  }

  public ExcelMapping(
    string parentRaterName,
    int id,
    string cell,
    string databaseField,
    string databaseType,
    string premiumOption,
    string tagParserTagName,
    bool? allowNull)
  {
    this.Parent = (ExcelRaterFactorSet) null;
    this.raterNameOverride = parentRaterName;
    this.Id = new int?(id);
    this.Cell = cell;
    this.DatabaseField = databaseField;
    this.TagParserTagNameOverride = tagParserTagName;
    this.DatabaseType = databaseType;
    this.PremiumOption = premiumOption;
    this.Required = ((int) allowNull ?? 1) == 0;
  }

  public static ExcelMapping Create(ExcelRaterFactorSet parent, ExcelMapping copyMapping)
  {
    return NotifyProxyTypeManager.Allocate<ExcelMapping>(new object[2]
    {
      (object) parent,
      (object) copyMapping
    });
  }

  public static ExcelMapping Create(ExcelRaterFactorSet parent, string cell)
  {
    return NotifyProxyTypeManager.Allocate<ExcelMapping>(new object[2]
    {
      (object) parent,
      (object) cell
    });
  }

  public static ExcelMapping Create(ExcelRaterFactorSet parent)
  {
    return NotifyProxyTypeManager.Allocate<ExcelMapping>(new object[1]
    {
      (object) parent
    });
  }

  public static ExcelMapping Create(
    ExcelRaterFactorSet parent,
    int id,
    string cell,
    string databaseField,
    string databaseType,
    string premiumOption,
    string tagParserTagName,
    bool? allowNull)
  {
    return NotifyProxyTypeManager.Allocate<ExcelMapping>(new object[8]
    {
      (object) parent,
      (object) id,
      (object) cell,
      (object) databaseField,
      (object) databaseType,
      (object) premiumOption,
      (object) tagParserTagName,
      (object) allowNull
    });
  }

  public static ExcelMapping Create(
    string parentRaterName,
    int id,
    string cell,
    string databaseField,
    string databaseType,
    string premiumOption,
    string tagParserTagName,
    bool? allowNull)
  {
    return NotifyProxyTypeManager.Allocate<ExcelMapping>(new object[8]
    {
      (object) parentRaterName,
      (object) id,
      (object) cell,
      (object) databaseField,
      (object) databaseType,
      (object) premiumOption,
      (object) tagParserTagName,
      (object) allowNull
    });
  }

  void IEditableObject.BeginEdit()
  {
    this.Parent.Parent.Parent.ChangeManager.BeginEdit((IEditableObject) this);
  }

  void IEditableObject.CancelEdit()
  {
    this.Parent.Parent.Parent.ChangeManager.CancelEdit((IEditableObject) this);
  }

  void IEditableObject.EndEdit()
  {
    this.Parent.Parent.Parent.ChangeManager.EndEdit((IEditableObject) this);
  }

  string IDataErrorInfo.Error => DataErrorInfoSupport.GetError((object) this, "");

  string IDataErrorInfo.this[string memberName]
  {
    get => DataErrorInfoSupport.GetError((object) this, memberName);
  }

  public void OnWriteAdditionalValuesToSource(Dictionary<string, object> values)
  {
    values.Add("DatabaseFieldAllowNull", (object) !this.Required);
    if (string.IsNullOrWhiteSpace(this.TagParserTagNameOverride))
      values.Add("TagParserTagName", (object) this.DatabaseField);
    else
      values.Add("TagParserTagName", (object) this.TagParserTagNameOverride);
  }

  public void OnWriteToDestination(DataTransferFilterEventArgs e)
  {
  }

  public void OnWriteToSource(DataTransferFilterEventArgs e)
  {
  }

  public bool TranslateValue(object value, out object translatedValue, out string error)
  {
    error = "";
    translatedValue = value == null ? (object) "" : (object) value.ToString().TrimEnd();
    if (value == null || string.IsNullOrEmpty((string) translatedValue))
      translatedValue = (object) string.Empty;
    try
    {
      if ((string) translatedValue == string.Empty && this.DatabaseType != "System.String")
      {
        translatedValue = (object) DBNull.Value;
      }
      else
      {
        switch (this.DatabaseType)
        {
          case "System.String":
            break;
          case "System.Decimal":
            Decimal result1;
            translatedValue = !Decimal.TryParse((string) translatedValue, out result1) ? (object) 0 : (object) result1;
            break;
          case "System.Int32":
            string s1 = (string) translatedValue;
            if (s1.Contains("."))
            {
              double a = double.Parse(s1);
              translatedValue = (object) (int) Math.Round(a);
              break;
            }
            translatedValue = (object) int.Parse((string) translatedValue);
            break;
          case "System.Int64":
            string s2 = (string) translatedValue;
            if (s2.Contains("."))
            {
              double a = double.Parse(s2);
              translatedValue = (object) (long) Math.Round(a);
              break;
            }
            translatedValue = (object) long.Parse((string) translatedValue);
            break;
          case "System.DateTime":
            DateTime result2;
            if (DateTime.TryParse((string) translatedValue, out result2))
            {
              translatedValue = (object) DateTime.Parse((string) translatedValue);
            }
            else
            {
              double result3 = 0.0;
              translatedValue = !double.TryParse((string) translatedValue, out result3) ? (object) DateTime.Parse((string) translatedValue) : (object) DateTime.FromOADate(result3);
            }
            if (translatedValue != null)
            {
              result2 = (DateTime) translatedValue;
              DateTime dateTime1 = result2;
              SqlDateTime sqlDateTime = SqlDateTime.MaxValue;
              DateTime dateTime2 = sqlDateTime.Value;
              if (!(dateTime1 > dateTime2))
              {
                DateTime dateTime3 = result2;
                sqlDateTime = SqlDateTime.MinValue;
                DateTime dateTime4 = sqlDateTime.Value;
                if (!(dateTime3 < dateTime4))
                  break;
              }
              error = string.Format((IFormatProvider) CultureInfo.InvariantCulture, "Error Translating {0} Value [{1}], {2}", (object) this.Cell, translatedValue, (object) "Acceptable date values must be between 1/1/1753 and 12/31/9999");
              return false;
            }
            break;
          case "System.Boolean":
            bool result4 = false;
            if (bool.TryParse((string) translatedValue, out result4))
            {
              translatedValue = (object) bool.Parse((string) translatedValue);
              break;
            }
            switch (((string) translatedValue).ToLower())
            {
              case "yes":
                translatedValue = (object) true;
                break;
              case "no":
                translatedValue = (object) false;
                break;
              case "1":
                translatedValue = (object) true;
                break;
              case "0":
                translatedValue = (object) false;
                break;
              case "#n/a":
                translatedValue = (object) null;
                break;
              default:
                translatedValue = (object) bool.Parse((string) translatedValue);
                break;
            }
            break;
          default:
            MGASystems.Common.ThreadingFunctions.MessageBox.Show("unable to translate this type", this.DatabaseType, MessageBoxButtons.OK, MessageBoxIcon.Hand);
            throw new InvalidOperationException("unable to translate this type");
        }
      }
    }
    catch (Exception ex)
    {
      error = string.Format((IFormatProvider) CultureInfo.InvariantCulture, "Error Translating {0} Value [{1}], {2}", (object) this.Cell, translatedValue, (object) ex.Message);
      return false;
    }
    return true;
  }

  public static (bool canDelete, string message, bool columnExists) CanDeleteMapping(
    string raterName,
    string columnName)
  {
    DataRow dataRow = DefaultDatabase.ExecuteDataRow("ExcelRating_CanDeleteMapping", new object[4]
    {
      (object) "@RaterName",
      (object) raterName,
      (object) "@ColumnName",
      (object) columnName
    });
    bool flag1 = ExtensionsMethods.FieldOrDefault<bool>(dataRow, "ColumnExists", false);
    bool flag2 = ExtensionsMethods.FieldOrDefault<bool>(dataRow, "RowsExist", false);
    bool flag3 = !flag1 || flag1 && !flag2;
    string str;
    if (!flag1)
      str = $"Are you sure you want to delete mapping for field '{columnName}'?";
    else if (!flag3)
      str = $"Cannot delete mapping.  Data exists for field '{columnName}'.";
    else
      str = $"Are you sure you want to delete mapping for field '{columnName}'?{Environment.NewLine}All changes will be saved after mapping is deleted.{Environment.NewLine}{Environment.NewLine}This action is permanent and cannot be undone.";
    return (flag3, str, flag1);
  }

  public static void DeleteMapping(
    Guid factorSetID,
    string tableName,
    string databaseField,
    string raterName)
  {
    DefaultDatabase.ExecuteNonQuery("ExcelRating_DeleteRaterMapping", new object[6]
    {
      (object) "@raterName",
      (object) raterName,
      (object) "@fieldName",
      (object) databaseField,
      (object) "@forceDeleteMapping",
      (object) false
    });
  }
}
