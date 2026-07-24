// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.AccountingDatasets.dsExpenseCategories
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
public class dsExpenseCategories : DataSet
{
  private dsExpenseCategories.spFin_ExpenseSearchDataTable tablespFin_ExpenseSearch;

  public dsExpenseCategories()
  {
    this.InitClass();
    CollectionChangeEventHandler changeEventHandler = new CollectionChangeEventHandler(this.SchemaChanged);
    this.Tables.CollectionChanged += changeEventHandler;
    this.Relations.CollectionChanged += changeEventHandler;
  }

  protected dsExpenseCategories(SerializationInfo info, StreamingContext context)
  {
    string s = Conversions.ToString(info.GetValue("XmlSchema", typeof (string)));
    if (s != null)
    {
      DataSet dataSet = new DataSet();
      dataSet.ReadXmlSchema((XmlReader) new XmlTextReader((TextReader) new StringReader(s)));
      if (dataSet.Tables[nameof (spFin_ExpenseSearch)] != null)
        this.Tables.Add((DataTable) new dsExpenseCategories.spFin_ExpenseSearchDataTable(dataSet.Tables[nameof (spFin_ExpenseSearch)]));
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
  public dsExpenseCategories.spFin_ExpenseSearchDataTable spFin_ExpenseSearch
  {
    get => this.tablespFin_ExpenseSearch;
  }

  public override DataSet Clone()
  {
    dsExpenseCategories expenseCategories = (dsExpenseCategories) base.Clone();
    expenseCategories.InitVars();
    return (DataSet) expenseCategories;
  }

  protected override bool ShouldSerializeTables() => false;

  protected override bool ShouldSerializeRelations() => false;

  protected override void ReadXmlSerializable(XmlReader reader)
  {
    this.Reset();
    DataSet dataSet = new DataSet();
    int num = (int) dataSet.ReadXml(reader);
    if (dataSet.Tables["spFin_ExpenseSearch"] != null)
      this.Tables.Add((DataTable) new dsExpenseCategories.spFin_ExpenseSearchDataTable(dataSet.Tables["spFin_ExpenseSearch"]));
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
    this.tablespFin_ExpenseSearch = (dsExpenseCategories.spFin_ExpenseSearchDataTable) this.Tables["spFin_ExpenseSearch"];
    if (this.tablespFin_ExpenseSearch == null)
      return;
    this.tablespFin_ExpenseSearch.InitVars();
  }

  private void InitClass()
  {
    this.DataSetName = nameof (dsExpenseCategories);
    this.Prefix = "";
    this.Namespace = "http://www.tempuri.org/dsExpenseCategories.xsd";
    this.Locale = new CultureInfo("en-US");
    this.CaseSensitive = false;
    this.EnforceConstraints = true;
    this.tablespFin_ExpenseSearch = new dsExpenseCategories.spFin_ExpenseSearchDataTable();
    this.Tables.Add((DataTable) this.tablespFin_ExpenseSearch);
  }

  private bool ShouldSerializespFin_ExpenseSearch() => false;

  private void SchemaChanged(object sender, CollectionChangeEventArgs e)
  {
    if (e.Action != CollectionChangeAction.Remove)
      return;
    this.InitVars();
  }

  public delegate void spFin_ExpenseSearchRowChangeEventHandler(
    object sender,
    dsExpenseCategories.spFin_ExpenseSearchRowChangeEvent e);

  [DebuggerStepThrough]
  public class spFin_ExpenseSearchDataTable : DataTable, IEnumerable
  {
    private DataColumn columnExpenseCategoryID;
    private DataColumn columnCategoryName;

    internal spFin_ExpenseSearchDataTable()
      : base("spFin_ExpenseSearch")
    {
      this.InitClass();
    }

    internal spFin_ExpenseSearchDataTable(DataTable table)
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

    public dsExpenseCategories.spFin_ExpenseSearchRow this[int index]
    {
      get => (dsExpenseCategories.spFin_ExpenseSearchRow) this.Rows[index];
    }

    public event dsExpenseCategories.spFin_ExpenseSearchRowChangeEventHandler spFin_ExpenseSearchRowChanged;

    public event dsExpenseCategories.spFin_ExpenseSearchRowChangeEventHandler spFin_ExpenseSearchRowChanging;

    public event dsExpenseCategories.spFin_ExpenseSearchRowChangeEventHandler spFin_ExpenseSearchRowDeleted;

    public event dsExpenseCategories.spFin_ExpenseSearchRowChangeEventHandler spFin_ExpenseSearchRowDeleting;

    public void AddspFin_ExpenseSearchRow(dsExpenseCategories.spFin_ExpenseSearchRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    public dsExpenseCategories.spFin_ExpenseSearchRow AddspFin_ExpenseSearchRow(string CategoryName)
    {
      dsExpenseCategories.spFin_ExpenseSearchRow row = (dsExpenseCategories.spFin_ExpenseSearchRow) this.NewRow();
      row.ItemArray = new object[2]
      {
        null,
        (object) CategoryName
      };
      this.Rows.Add((DataRow) row);
      return row;
    }

    public dsExpenseCategories.spFin_ExpenseSearchRow FindByExpenseCategoryID(int ExpenseCategoryID)
    {
      return (dsExpenseCategories.spFin_ExpenseSearchRow) this.Rows.Find(new object[1]
      {
        (object) ExpenseCategoryID
      });
    }

    public IEnumerator GetEnumerator() => this.Rows.GetEnumerator();

    public override DataTable Clone()
    {
      dsExpenseCategories.spFin_ExpenseSearchDataTable expenseSearchDataTable = (dsExpenseCategories.spFin_ExpenseSearchDataTable) base.Clone();
      expenseSearchDataTable.InitVars();
      return (DataTable) expenseSearchDataTable;
    }

    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsExpenseCategories.spFin_ExpenseSearchDataTable();
    }

    internal void InitVars()
    {
      this.columnExpenseCategoryID = this.Columns["ExpenseCategoryID"];
      this.columnCategoryName = this.Columns["CategoryName"];
    }

    private void InitClass()
    {
      this.columnExpenseCategoryID = new DataColumn("ExpenseCategoryID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnExpenseCategoryID);
      this.columnCategoryName = new DataColumn("CategoryName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCategoryName);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnExpenseCategoryID
      }, true));
      this.columnExpenseCategoryID.AutoIncrement = true;
      this.columnExpenseCategoryID.AllowDBNull = false;
      this.columnExpenseCategoryID.ReadOnly = true;
      this.columnExpenseCategoryID.Unique = true;
      this.columnCategoryName.AllowDBNull = false;
    }

    public dsExpenseCategories.spFin_ExpenseSearchRow NewspFin_ExpenseSearchRow()
    {
      return (dsExpenseCategories.spFin_ExpenseSearchRow) this.NewRow();
    }

    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsExpenseCategories.spFin_ExpenseSearchRow(builder);
    }

    protected override Type GetRowType() => typeof (dsExpenseCategories.spFin_ExpenseSearchRow);

    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.spFin_ExpenseSearchRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsExpenseCategories.spFin_ExpenseSearchRowChangeEventHandler searchRowChangedEvent = this.spFin_ExpenseSearchRowChangedEvent;
      if (searchRowChangedEvent == null)
        return;
      searchRowChangedEvent((object) this, new dsExpenseCategories.spFin_ExpenseSearchRowChangeEvent((dsExpenseCategories.spFin_ExpenseSearchRow) e.Row, e.Action));
    }

    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.spFin_ExpenseSearchRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsExpenseCategories.spFin_ExpenseSearchRowChangeEventHandler rowChangingEvent = this.spFin_ExpenseSearchRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsExpenseCategories.spFin_ExpenseSearchRowChangeEvent((dsExpenseCategories.spFin_ExpenseSearchRow) e.Row, e.Action));
    }

    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.spFin_ExpenseSearchRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsExpenseCategories.spFin_ExpenseSearchRowChangeEventHandler searchRowDeletedEvent = this.spFin_ExpenseSearchRowDeletedEvent;
      if (searchRowDeletedEvent == null)
        return;
      searchRowDeletedEvent((object) this, new dsExpenseCategories.spFin_ExpenseSearchRowChangeEvent((dsExpenseCategories.spFin_ExpenseSearchRow) e.Row, e.Action));
    }

    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.spFin_ExpenseSearchRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsExpenseCategories.spFin_ExpenseSearchRowChangeEventHandler rowDeletingEvent = this.spFin_ExpenseSearchRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsExpenseCategories.spFin_ExpenseSearchRowChangeEvent((dsExpenseCategories.spFin_ExpenseSearchRow) e.Row, e.Action));
    }

    public void RemovespFin_ExpenseSearchRow(dsExpenseCategories.spFin_ExpenseSearchRow row)
    {
      this.Rows.Remove((DataRow) row);
    }
  }

  [DebuggerStepThrough]
  public class spFin_ExpenseSearchRow : DataRow
  {
    private dsExpenseCategories.spFin_ExpenseSearchDataTable tablespFin_ExpenseSearch;

    internal spFin_ExpenseSearchRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablespFin_ExpenseSearch = (dsExpenseCategories.spFin_ExpenseSearchDataTable) this.Table;
    }

    public int ExpenseCategoryID
    {
      get => Conversions.ToInteger(this[this.tablespFin_ExpenseSearch.ExpenseCategoryIDColumn]);
      set => this[this.tablespFin_ExpenseSearch.ExpenseCategoryIDColumn] = (object) value;
    }

    public string CategoryName
    {
      get => Conversions.ToString(this[this.tablespFin_ExpenseSearch.CategoryNameColumn]);
      set => this[this.tablespFin_ExpenseSearch.CategoryNameColumn] = (object) value;
    }
  }

  [DebuggerStepThrough]
  public class spFin_ExpenseSearchRowChangeEvent : EventArgs
  {
    private dsExpenseCategories.spFin_ExpenseSearchRow eventRow;
    private DataRowAction eventAction;

    public spFin_ExpenseSearchRowChangeEvent(
      dsExpenseCategories.spFin_ExpenseSearchRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    public dsExpenseCategories.spFin_ExpenseSearchRow Row => this.eventRow;

    public DataRowAction Action => this.eventAction;
  }
}
