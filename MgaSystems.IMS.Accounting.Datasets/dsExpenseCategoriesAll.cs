// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.AccountingDatasets.dsExpenseCategoriesAll
// Assembly: MgaSystems.IMS.Accounting.Datasets, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 8706ECE1-02EE-4588-9B9D-A81462107C6A
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Accounting.Datasets.dll

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Text;
using System.Xml;
using System.Xml.Schema;

#nullable disable
namespace MGASystems.IMS.Accounting.AccountingDatasets;

[DesignerCategory("code")]
[DebuggerStepThrough]
[ToolboxItem(true)]
[Serializable]
public class dsExpenseCategoriesAll : DataSet
{
  private dsExpenseCategoriesAll.ExpenseCategoriesDataTable tableExpenseCategories;

  public dsExpenseCategoriesAll()
  {
    this.InitClass();
    CollectionChangeEventHandler changeEventHandler = new CollectionChangeEventHandler(this.SchemaChanged);
    this.Tables.CollectionChanged += changeEventHandler;
    this.Relations.CollectionChanged += changeEventHandler;
  }

  protected dsExpenseCategoriesAll(SerializationInfo info, StreamingContext context)
  {
    string s = Conversions.ToString(info.GetValue("XmlSchema", typeof (string)));
    if (s != null)
    {
      DataSet dataSet = new DataSet();
      dataSet.ReadXmlSchema((XmlReader) new XmlTextReader((TextReader) new StringReader(s)));
      if (dataSet.Tables[nameof (ExpenseCategories)] != null)
        this.Tables.Add((DataTable) new dsExpenseCategoriesAll.ExpenseCategoriesDataTable(dataSet.Tables[nameof (ExpenseCategories)]));
      this.DataSetName = dataSet.DataSetName;
      this.Prefix = dataSet.Prefix;
      this.Namespace = dataSet.Namespace;
      this.Locale = dataSet.Locale;
      this.CaseSensitive = dataSet.CaseSensitive;
      this.EnforceConstraints = dataSet.EnforceConstraints;
      this.Merge(dataSet, false, MissingSchemaAction.Add);
      this.InitVars();
    }
    else
      this.InitClass();
    this.GetSerializationData(info, context);
    CollectionChangeEventHandler changeEventHandler = new CollectionChangeEventHandler(this.SchemaChanged);
    this.Tables.CollectionChanged += changeEventHandler;
    this.Relations.CollectionChanged += changeEventHandler;
  }

  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsExpenseCategoriesAll.ExpenseCategoriesDataTable ExpenseCategories
  {
    get => this.tableExpenseCategories;
  }

  public override DataSet Clone()
  {
    dsExpenseCategoriesAll expenseCategoriesAll = (dsExpenseCategoriesAll) base.Clone();
    expenseCategoriesAll.InitVars();
    return (DataSet) expenseCategoriesAll;
  }

  protected override bool ShouldSerializeTables() => false;

  protected override bool ShouldSerializeRelations() => false;

  protected override void ReadXmlSerializable(XmlReader reader)
  {
    this.Reset();
    DataSet dataSet = new DataSet();
    int num = (int) dataSet.ReadXml(reader);
    if (dataSet.Tables["ExpenseCategories"] != null)
      this.Tables.Add((DataTable) new dsExpenseCategoriesAll.ExpenseCategoriesDataTable(dataSet.Tables["ExpenseCategories"]));
    this.DataSetName = dataSet.DataSetName;
    this.Prefix = dataSet.Prefix;
    this.Namespace = dataSet.Namespace;
    this.Locale = dataSet.Locale;
    this.CaseSensitive = dataSet.CaseSensitive;
    this.EnforceConstraints = dataSet.EnforceConstraints;
    this.Merge(dataSet, false, MissingSchemaAction.Add);
    this.InitVars();
  }

  protected override XmlSchema GetSchemaSerializable()
  {
    MemoryStream memoryStream = new MemoryStream();
    this.WriteXmlSchema((XmlWriter) new XmlTextWriter((Stream) memoryStream, (Encoding) null));
    memoryStream.Position = 0L;
    return XmlSchema.Read((XmlReader) new XmlTextReader((Stream) memoryStream), (ValidationEventHandler) null);
  }

  internal void InitVars()
  {
    this.tableExpenseCategories = (dsExpenseCategoriesAll.ExpenseCategoriesDataTable) this.Tables["ExpenseCategories"];
    if (this.tableExpenseCategories == null)
      return;
    this.tableExpenseCategories.InitVars();
  }

  private void InitClass()
  {
    this.DataSetName = nameof (dsExpenseCategoriesAll);
    this.Prefix = "";
    this.Namespace = "http://tempuri.org/dsExpenseCategoriesAll.xsd";
    this.Locale = new CultureInfo("en-US");
    this.CaseSensitive = false;
    this.EnforceConstraints = true;
    this.tableExpenseCategories = new dsExpenseCategoriesAll.ExpenseCategoriesDataTable();
    this.Tables.Add((DataTable) this.tableExpenseCategories);
  }

  private bool ShouldSerializeExpenseCategories() => false;

  private void SchemaChanged(object sender, CollectionChangeEventArgs e)
  {
    if (e.Action != CollectionChangeAction.Remove)
      return;
    this.InitVars();
  }

  public delegate void ExpenseCategoriesRowChangeEventHandler(
    object sender,
    dsExpenseCategoriesAll.ExpenseCategoriesRowChangeEvent e);

  [DebuggerStepThrough]
  public class ExpenseCategoriesDataTable : DataTable, IEnumerable
  {
    private DataColumn columnExpenseCategoryID;
    private DataColumn columnCategoryName;
    private DataColumn columnDescription;
    private DataColumn columnSystemDefined;

    internal ExpenseCategoriesDataTable()
      : base("ExpenseCategories")
    {
      this.InitClass();
    }

    internal ExpenseCategoriesDataTable(DataTable table)
      : base(table.TableName)
    {
      if (table.CaseSensitive != table.DataSet.CaseSensitive)
        this.CaseSensitive = table.CaseSensitive;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(table.Locale.ToString(), table.DataSet.Locale.ToString(), false) != 0)
        this.Locale = table.Locale;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(table.Namespace, table.DataSet.Namespace, false) != 0)
        this.Namespace = table.Namespace;
      this.Prefix = table.Prefix;
      this.MinimumCapacity = table.MinimumCapacity;
      this.DisplayExpression = table.DisplayExpression;
    }

    [Browsable(false)]
    public int Count => this.Rows.Count;

    internal DataColumn ExpenseCategoryIDColumn => this.columnExpenseCategoryID;

    internal DataColumn CategoryNameColumn => this.columnCategoryName;

    internal DataColumn DescriptionColumn => this.columnDescription;

    internal DataColumn SystemDefinedColumn => this.columnSystemDefined;

    public dsExpenseCategoriesAll.ExpenseCategoriesRow this[int index]
    {
      get => (dsExpenseCategoriesAll.ExpenseCategoriesRow) this.Rows[index];
    }

    public event dsExpenseCategoriesAll.ExpenseCategoriesRowChangeEventHandler ExpenseCategoriesRowChanged;

    public event dsExpenseCategoriesAll.ExpenseCategoriesRowChangeEventHandler ExpenseCategoriesRowChanging;

    public event dsExpenseCategoriesAll.ExpenseCategoriesRowChangeEventHandler ExpenseCategoriesRowDeleted;

    public event dsExpenseCategoriesAll.ExpenseCategoriesRowChangeEventHandler ExpenseCategoriesRowDeleting;

    public void AddExpenseCategoriesRow(dsExpenseCategoriesAll.ExpenseCategoriesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    public dsExpenseCategoriesAll.ExpenseCategoriesRow AddExpenseCategoriesRow(
      long ExpenseCategoryID,
      string CategoryName,
      string Description,
      bool SystemDefined)
    {
      dsExpenseCategoriesAll.ExpenseCategoriesRow row = (dsExpenseCategoriesAll.ExpenseCategoriesRow) this.NewRow();
      row.ItemArray = new object[4]
      {
        (object) ExpenseCategoryID,
        (object) CategoryName,
        (object) Description,
        (object) SystemDefined
      };
      this.Rows.Add((DataRow) row);
      return row;
    }

    public IEnumerator GetEnumerator() => this.Rows.GetEnumerator();

    public override DataTable Clone()
    {
      dsExpenseCategoriesAll.ExpenseCategoriesDataTable categoriesDataTable = (dsExpenseCategoriesAll.ExpenseCategoriesDataTable) base.Clone();
      categoriesDataTable.InitVars();
      return (DataTable) categoriesDataTable;
    }

    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsExpenseCategoriesAll.ExpenseCategoriesDataTable();
    }

    internal void InitVars()
    {
      this.columnExpenseCategoryID = this.Columns["ExpenseCategoryID"];
      this.columnCategoryName = this.Columns["CategoryName"];
      this.columnDescription = this.Columns["Description"];
      this.columnSystemDefined = this.Columns["SystemDefined"];
    }

    private void InitClass()
    {
      this.columnExpenseCategoryID = new DataColumn("ExpenseCategoryID", typeof (long), (string) null, MappingType.Element);
      this.Columns.Add(this.columnExpenseCategoryID);
      this.columnCategoryName = new DataColumn("CategoryName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCategoryName);
      this.columnDescription = new DataColumn("Description", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDescription);
      this.columnSystemDefined = new DataColumn("SystemDefined", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSystemDefined);
    }

    public dsExpenseCategoriesAll.ExpenseCategoriesRow NewExpenseCategoriesRow()
    {
      return (dsExpenseCategoriesAll.ExpenseCategoriesRow) this.NewRow();
    }

    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsExpenseCategoriesAll.ExpenseCategoriesRow(builder);
    }

    protected override Type GetRowType() => typeof (dsExpenseCategoriesAll.ExpenseCategoriesRow);

    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.ExpenseCategoriesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsExpenseCategoriesAll.ExpenseCategoriesRowChangeEventHandler categoriesRowChangedEvent = this.ExpenseCategoriesRowChangedEvent;
      if (categoriesRowChangedEvent == null)
        return;
      categoriesRowChangedEvent((object) this, new dsExpenseCategoriesAll.ExpenseCategoriesRowChangeEvent((dsExpenseCategoriesAll.ExpenseCategoriesRow) e.Row, e.Action));
    }

    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.ExpenseCategoriesRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsExpenseCategoriesAll.ExpenseCategoriesRowChangeEventHandler rowChangingEvent = this.ExpenseCategoriesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsExpenseCategoriesAll.ExpenseCategoriesRowChangeEvent((dsExpenseCategoriesAll.ExpenseCategoriesRow) e.Row, e.Action));
    }

    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.ExpenseCategoriesRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsExpenseCategoriesAll.ExpenseCategoriesRowChangeEventHandler categoriesRowDeletedEvent = this.ExpenseCategoriesRowDeletedEvent;
      if (categoriesRowDeletedEvent == null)
        return;
      categoriesRowDeletedEvent((object) this, new dsExpenseCategoriesAll.ExpenseCategoriesRowChangeEvent((dsExpenseCategoriesAll.ExpenseCategoriesRow) e.Row, e.Action));
    }

    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.ExpenseCategoriesRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsExpenseCategoriesAll.ExpenseCategoriesRowChangeEventHandler rowDeletingEvent = this.ExpenseCategoriesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsExpenseCategoriesAll.ExpenseCategoriesRowChangeEvent((dsExpenseCategoriesAll.ExpenseCategoriesRow) e.Row, e.Action));
    }

    public void RemoveExpenseCategoriesRow(dsExpenseCategoriesAll.ExpenseCategoriesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }
  }

  [DebuggerStepThrough]
  public class ExpenseCategoriesRow : DataRow
  {
    private dsExpenseCategoriesAll.ExpenseCategoriesDataTable tableExpenseCategories;

    internal ExpenseCategoriesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableExpenseCategories = (dsExpenseCategoriesAll.ExpenseCategoriesDataTable) this.Table;
    }

    public long ExpenseCategoryID
    {
      get
      {
        try
        {
          return Conversions.ToLong(this[this.tableExpenseCategories.ExpenseCategoryIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableExpenseCategories.ExpenseCategoryIDColumn] = (object) value;
    }

    public string CategoryName
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableExpenseCategories.CategoryNameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableExpenseCategories.CategoryNameColumn] = (object) value;
    }

    public string Description
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableExpenseCategories.DescriptionColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableExpenseCategories.DescriptionColumn] = (object) value;
    }

    public bool SystemDefined
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tableExpenseCategories.SystemDefinedColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableExpenseCategories.SystemDefinedColumn] = (object) value;
    }

    public bool IsExpenseCategoryIDNull()
    {
      return this.IsNull(this.tableExpenseCategories.ExpenseCategoryIDColumn);
    }

    public void SetExpenseCategoryIDNull()
    {
      this[this.tableExpenseCategories.ExpenseCategoryIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsCategoryNameNull() => this.IsNull(this.tableExpenseCategories.CategoryNameColumn);

    public void SetCategoryNameNull()
    {
      this[this.tableExpenseCategories.CategoryNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsDescriptionNull() => this.IsNull(this.tableExpenseCategories.DescriptionColumn);

    public void SetDescriptionNull()
    {
      this[this.tableExpenseCategories.DescriptionColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsSystemDefinedNull()
    {
      return this.IsNull(this.tableExpenseCategories.SystemDefinedColumn);
    }

    public void SetSystemDefinedNull()
    {
      this[this.tableExpenseCategories.SystemDefinedColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  [DebuggerStepThrough]
  public class ExpenseCategoriesRowChangeEvent : EventArgs
  {
    private dsExpenseCategoriesAll.ExpenseCategoriesRow eventRow;
    private DataRowAction eventAction;

    public ExpenseCategoriesRowChangeEvent(
      dsExpenseCategoriesAll.ExpenseCategoriesRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    public dsExpenseCategoriesAll.ExpenseCategoriesRow Row => this.eventRow;

    public DataRowAction Action => this.eventAction;
  }
}
