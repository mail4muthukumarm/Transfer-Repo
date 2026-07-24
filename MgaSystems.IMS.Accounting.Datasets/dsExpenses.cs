// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.AccountingDatasets.dsExpenses
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
public class dsExpenses : DataSet
{
  private dsExpenses.ExpensesDataTable tableExpenses;

  public dsExpenses()
  {
    this.InitClass();
    CollectionChangeEventHandler changeEventHandler = new CollectionChangeEventHandler(this.SchemaChanged);
    this.Tables.CollectionChanged += changeEventHandler;
    this.Relations.CollectionChanged += changeEventHandler;
  }

  protected dsExpenses(SerializationInfo info, StreamingContext context)
  {
    string s = Conversions.ToString(info.GetValue("XmlSchema", typeof (string)));
    if (s != null)
    {
      DataSet dataSet = new DataSet();
      dataSet.ReadXmlSchema((XmlReader) new XmlTextReader((TextReader) new StringReader(s)));
      if (dataSet.Tables[nameof (Expenses)] != null)
        this.Tables.Add((DataTable) new dsExpenses.ExpensesDataTable(dataSet.Tables[nameof (Expenses)]));
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
  public dsExpenses.ExpensesDataTable Expenses => this.tableExpenses;

  public override DataSet Clone()
  {
    dsExpenses dsExpenses = (dsExpenses) base.Clone();
    dsExpenses.InitVars();
    return (DataSet) dsExpenses;
  }

  protected override bool ShouldSerializeTables() => false;

  protected override bool ShouldSerializeRelations() => false;

  protected override void ReadXmlSerializable(XmlReader reader)
  {
    this.Reset();
    DataSet dataSet = new DataSet();
    int num = (int) dataSet.ReadXml(reader);
    if (dataSet.Tables["Expenses"] != null)
      this.Tables.Add((DataTable) new dsExpenses.ExpensesDataTable(dataSet.Tables["Expenses"]));
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
    this.tableExpenses = (dsExpenses.ExpensesDataTable) this.Tables["Expenses"];
    if (this.tableExpenses == null)
      return;
    this.tableExpenses.InitVars();
  }

  private void InitClass()
  {
    this.DataSetName = nameof (dsExpenses);
    this.Prefix = "";
    this.Namespace = "http://tempuri.org/dsExpenses.xsd";
    this.Locale = new CultureInfo("en-US");
    this.CaseSensitive = false;
    this.EnforceConstraints = true;
    this.tableExpenses = new dsExpenses.ExpensesDataTable();
    this.Tables.Add((DataTable) this.tableExpenses);
  }

  private bool ShouldSerializeExpenses() => false;

  private void SchemaChanged(object sender, CollectionChangeEventArgs e)
  {
    if (e.Action != CollectionChangeAction.Remove)
      return;
    this.InitVars();
  }

  public delegate void ExpensesRowChangeEventHandler(
    object sender,
    dsExpenses.ExpensesRowChangeEvent e);

  [DebuggerStepThrough]
  public class ExpensesDataTable : DataTable, IEnumerable
  {
    private DataColumn columnExpenseCode;
    private DataColumn columnExpenseCategoryId;
    private DataColumn columnCategoryName;
    private DataColumn columnExpenseName;
    private DataColumn columnDescription;
    private DataColumn columnSystemDefined;

    internal ExpensesDataTable()
      : base("Expenses")
    {
      this.InitClass();
    }

    internal ExpensesDataTable(DataTable table)
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

    internal DataColumn ExpenseCodeColumn => this.columnExpenseCode;

    internal DataColumn ExpenseCategoryIdColumn => this.columnExpenseCategoryId;

    internal DataColumn CategoryNameColumn => this.columnCategoryName;

    internal DataColumn ExpenseNameColumn => this.columnExpenseName;

    internal DataColumn DescriptionColumn => this.columnDescription;

    internal DataColumn SystemDefinedColumn => this.columnSystemDefined;

    public dsExpenses.ExpensesRow this[int index] => (dsExpenses.ExpensesRow) this.Rows[index];

    public event dsExpenses.ExpensesRowChangeEventHandler ExpensesRowChanged;

    public event dsExpenses.ExpensesRowChangeEventHandler ExpensesRowChanging;

    public event dsExpenses.ExpensesRowChangeEventHandler ExpensesRowDeleted;

    public event dsExpenses.ExpensesRowChangeEventHandler ExpensesRowDeleting;

    public void AddExpensesRow(dsExpenses.ExpensesRow row) => this.Rows.Add((DataRow) row);

    public dsExpenses.ExpensesRow AddExpensesRow(
      int ExpenseCode,
      int ExpenseCategoryId,
      string CategoryName,
      string ExpenseName,
      string Description,
      bool SystemDefined)
    {
      dsExpenses.ExpensesRow row = (dsExpenses.ExpensesRow) this.NewRow();
      row.ItemArray = new object[6]
      {
        (object) ExpenseCode,
        (object) ExpenseCategoryId,
        (object) CategoryName,
        (object) ExpenseName,
        (object) Description,
        (object) SystemDefined
      };
      this.Rows.Add((DataRow) row);
      return row;
    }

    public IEnumerator GetEnumerator() => this.Rows.GetEnumerator();

    public override DataTable Clone()
    {
      dsExpenses.ExpensesDataTable expensesDataTable = (dsExpenses.ExpensesDataTable) base.Clone();
      expensesDataTable.InitVars();
      return (DataTable) expensesDataTable;
    }

    protected override DataTable CreateInstance() => (DataTable) new dsExpenses.ExpensesDataTable();

    internal void InitVars()
    {
      this.columnExpenseCode = this.Columns["ExpenseCode"];
      this.columnExpenseCategoryId = this.Columns["ExpenseCategoryId"];
      this.columnCategoryName = this.Columns["CategoryName"];
      this.columnExpenseName = this.Columns["ExpenseName"];
      this.columnDescription = this.Columns["Description"];
      this.columnSystemDefined = this.Columns["SystemDefined"];
    }

    private void InitClass()
    {
      this.columnExpenseCode = new DataColumn("ExpenseCode", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnExpenseCode);
      this.columnExpenseCategoryId = new DataColumn("ExpenseCategoryId", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnExpenseCategoryId);
      this.columnCategoryName = new DataColumn("CategoryName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCategoryName);
      this.columnExpenseName = new DataColumn("ExpenseName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnExpenseName);
      this.columnDescription = new DataColumn("Description", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDescription);
      this.columnSystemDefined = new DataColumn("SystemDefined", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSystemDefined);
    }

    public dsExpenses.ExpensesRow NewExpensesRow() => (dsExpenses.ExpensesRow) this.NewRow();

    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsExpenses.ExpensesRow(builder);
    }

    protected override Type GetRowType() => typeof (dsExpenses.ExpensesRow);

    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.ExpensesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsExpenses.ExpensesRowChangeEventHandler expensesRowChangedEvent = this.ExpensesRowChangedEvent;
      if (expensesRowChangedEvent == null)
        return;
      expensesRowChangedEvent((object) this, new dsExpenses.ExpensesRowChangeEvent((dsExpenses.ExpensesRow) e.Row, e.Action));
    }

    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.ExpensesRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsExpenses.ExpensesRowChangeEventHandler rowChangingEvent = this.ExpensesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsExpenses.ExpensesRowChangeEvent((dsExpenses.ExpensesRow) e.Row, e.Action));
    }

    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.ExpensesRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsExpenses.ExpensesRowChangeEventHandler expensesRowDeletedEvent = this.ExpensesRowDeletedEvent;
      if (expensesRowDeletedEvent == null)
        return;
      expensesRowDeletedEvent((object) this, new dsExpenses.ExpensesRowChangeEvent((dsExpenses.ExpensesRow) e.Row, e.Action));
    }

    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.ExpensesRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsExpenses.ExpensesRowChangeEventHandler rowDeletingEvent = this.ExpensesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsExpenses.ExpensesRowChangeEvent((dsExpenses.ExpensesRow) e.Row, e.Action));
    }

    public void RemoveExpensesRow(dsExpenses.ExpensesRow row) => this.Rows.Remove((DataRow) row);
  }

  [DebuggerStepThrough]
  public class ExpensesRow : DataRow
  {
    private dsExpenses.ExpensesDataTable tableExpenses;

    internal ExpensesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableExpenses = (dsExpenses.ExpensesDataTable) this.Table;
    }

    public int ExpenseCode
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tableExpenses.ExpenseCodeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableExpenses.ExpenseCodeColumn] = (object) value;
    }

    public int ExpenseCategoryId
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tableExpenses.ExpenseCategoryIdColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableExpenses.ExpenseCategoryIdColumn] = (object) value;
    }

    public string CategoryName
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableExpenses.CategoryNameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableExpenses.CategoryNameColumn] = (object) value;
    }

    public string ExpenseName
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableExpenses.ExpenseNameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableExpenses.ExpenseNameColumn] = (object) value;
    }

    public string Description
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableExpenses.DescriptionColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableExpenses.DescriptionColumn] = (object) value;
    }

    public bool SystemDefined
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tableExpenses.SystemDefinedColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableExpenses.SystemDefinedColumn] = (object) value;
    }

    public bool IsExpenseCodeNull() => this.IsNull(this.tableExpenses.ExpenseCodeColumn);

    public void SetExpenseCodeNull()
    {
      this[this.tableExpenses.ExpenseCodeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsExpenseCategoryIdNull()
    {
      return this.IsNull(this.tableExpenses.ExpenseCategoryIdColumn);
    }

    public void SetExpenseCategoryIdNull()
    {
      this[this.tableExpenses.ExpenseCategoryIdColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsCategoryNameNull() => this.IsNull(this.tableExpenses.CategoryNameColumn);

    public void SetCategoryNameNull()
    {
      this[this.tableExpenses.CategoryNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsExpenseNameNull() => this.IsNull(this.tableExpenses.ExpenseNameColumn);

    public void SetExpenseNameNull()
    {
      this[this.tableExpenses.ExpenseNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsDescriptionNull() => this.IsNull(this.tableExpenses.DescriptionColumn);

    public void SetDescriptionNull()
    {
      this[this.tableExpenses.DescriptionColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsSystemDefinedNull() => this.IsNull(this.tableExpenses.SystemDefinedColumn);

    public void SetSystemDefinedNull()
    {
      this[this.tableExpenses.SystemDefinedColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  [DebuggerStepThrough]
  public class ExpensesRowChangeEvent : EventArgs
  {
    private dsExpenses.ExpensesRow eventRow;
    private DataRowAction eventAction;

    public ExpensesRowChangeEvent(dsExpenses.ExpensesRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    public dsExpenses.ExpensesRow Row => this.eventRow;

    public DataRowAction Action => this.eventAction;
  }
}
