// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.AccountingDatasets.dsOpenExpenses
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
public class dsOpenExpenses : DataSet
{
  private dsOpenExpenses.OpenExpensesDataTable tableOpenExpenses;

  public dsOpenExpenses()
  {
    this.InitClass();
    CollectionChangeEventHandler changeEventHandler = new CollectionChangeEventHandler(this.SchemaChanged);
    this.Tables.CollectionChanged += changeEventHandler;
    this.Relations.CollectionChanged += changeEventHandler;
  }

  protected dsOpenExpenses(SerializationInfo info, StreamingContext context)
  {
    string s = Conversions.ToString(info.GetValue("XmlSchema", typeof (string)));
    if (s != null)
    {
      DataSet dataSet = new DataSet();
      dataSet.ReadXmlSchema((XmlReader) new XmlTextReader((TextReader) new StringReader(s)));
      if (dataSet.Tables[nameof (OpenExpenses)] != null)
        this.Tables.Add((DataTable) new dsOpenExpenses.OpenExpensesDataTable(dataSet.Tables[nameof (OpenExpenses)]));
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
  public dsOpenExpenses.OpenExpensesDataTable OpenExpenses => this.tableOpenExpenses;

  public override DataSet Clone()
  {
    dsOpenExpenses dsOpenExpenses = (dsOpenExpenses) base.Clone();
    dsOpenExpenses.InitVars();
    return (DataSet) dsOpenExpenses;
  }

  protected override bool ShouldSerializeTables() => false;

  protected override bool ShouldSerializeRelations() => false;

  protected override void ReadXmlSerializable(XmlReader reader)
  {
    this.Reset();
    DataSet dataSet = new DataSet();
    int num = (int) dataSet.ReadXml(reader);
    if (dataSet.Tables["OpenExpenses"] != null)
      this.Tables.Add((DataTable) new dsOpenExpenses.OpenExpensesDataTable(dataSet.Tables["OpenExpenses"]));
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
    this.tableOpenExpenses = (dsOpenExpenses.OpenExpensesDataTable) this.Tables["OpenExpenses"];
    if (this.tableOpenExpenses == null)
      return;
    this.tableOpenExpenses.InitVars();
  }

  private void InitClass()
  {
    this.DataSetName = nameof (dsOpenExpenses);
    this.Prefix = "";
    this.Namespace = "http://tempuri.org/dsOpenExpenses.xsd";
    this.Locale = new CultureInfo("en-US");
    this.CaseSensitive = false;
    this.EnforceConstraints = true;
    this.tableOpenExpenses = new dsOpenExpenses.OpenExpensesDataTable();
    this.Tables.Add((DataTable) this.tableOpenExpenses);
  }

  private bool ShouldSerializeOpenExpenses() => false;

  private void SchemaChanged(object sender, CollectionChangeEventArgs e)
  {
    if (e.Action != CollectionChangeAction.Remove)
      return;
    this.InitVars();
  }

  public delegate void OpenExpensesRowChangeEventHandler(
    object sender,
    dsOpenExpenses.OpenExpensesRowChangeEvent e);

  [DebuggerStepThrough]
  public class OpenExpensesDataTable : DataTable, IEnumerable
  {
    private DataColumn columnpoNum;
    private DataColumn columnpayeeGuid;
    private DataColumn columnPayee;
    private DataColumn columnPODate;
    private DataColumn columnenteredBy;
    private DataColumn columnExpenseTotal;
    private DataColumn columnAmountRemaining;

    internal OpenExpensesDataTable()
      : base("OpenExpenses")
    {
      this.InitClass();
    }

    internal OpenExpensesDataTable(DataTable table)
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

    internal DataColumn poNumColumn => this.columnpoNum;

    internal DataColumn payeeGuidColumn => this.columnpayeeGuid;

    internal DataColumn PayeeColumn => this.columnPayee;

    internal DataColumn PODateColumn => this.columnPODate;

    internal DataColumn enteredByColumn => this.columnenteredBy;

    internal DataColumn ExpenseTotalColumn => this.columnExpenseTotal;

    internal DataColumn AmountRemainingColumn => this.columnAmountRemaining;

    public dsOpenExpenses.OpenExpensesRow this[int index]
    {
      get => (dsOpenExpenses.OpenExpensesRow) this.Rows[index];
    }

    public event dsOpenExpenses.OpenExpensesRowChangeEventHandler OpenExpensesRowChanged;

    public event dsOpenExpenses.OpenExpensesRowChangeEventHandler OpenExpensesRowChanging;

    public event dsOpenExpenses.OpenExpensesRowChangeEventHandler OpenExpensesRowDeleted;

    public event dsOpenExpenses.OpenExpensesRowChangeEventHandler OpenExpensesRowDeleting;

    public void AddOpenExpensesRow(dsOpenExpenses.OpenExpensesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    public dsOpenExpenses.OpenExpensesRow AddOpenExpensesRow(
      int poNum,
      string payeeGuid,
      string Payee,
      DateTime PODate,
      string enteredBy,
      Decimal ExpenseTotal,
      Decimal AmountRemaining)
    {
      dsOpenExpenses.OpenExpensesRow row = (dsOpenExpenses.OpenExpensesRow) this.NewRow();
      row.ItemArray = new object[7]
      {
        (object) poNum,
        (object) payeeGuid,
        (object) Payee,
        (object) PODate,
        (object) enteredBy,
        (object) ExpenseTotal,
        (object) AmountRemaining
      };
      this.Rows.Add((DataRow) row);
      return row;
    }

    public IEnumerator GetEnumerator() => this.Rows.GetEnumerator();

    public override DataTable Clone()
    {
      dsOpenExpenses.OpenExpensesDataTable expensesDataTable = (dsOpenExpenses.OpenExpensesDataTable) base.Clone();
      expensesDataTable.InitVars();
      return (DataTable) expensesDataTable;
    }

    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsOpenExpenses.OpenExpensesDataTable();
    }

    internal void InitVars()
    {
      this.columnpoNum = this.Columns["poNum"];
      this.columnpayeeGuid = this.Columns["payeeGuid"];
      this.columnPayee = this.Columns["Payee"];
      this.columnPODate = this.Columns["PODate"];
      this.columnenteredBy = this.Columns["enteredBy"];
      this.columnExpenseTotal = this.Columns["ExpenseTotal"];
      this.columnAmountRemaining = this.Columns["AmountRemaining"];
    }

    private void InitClass()
    {
      this.columnpoNum = new DataColumn("poNum", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnpoNum);
      this.columnpayeeGuid = new DataColumn("payeeGuid", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnpayeeGuid);
      this.columnPayee = new DataColumn("Payee", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPayee);
      this.columnPODate = new DataColumn("PODate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPODate);
      this.columnenteredBy = new DataColumn("enteredBy", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnenteredBy);
      this.columnExpenseTotal = new DataColumn("ExpenseTotal", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnExpenseTotal);
      this.columnAmountRemaining = new DataColumn("AmountRemaining", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAmountRemaining);
    }

    public dsOpenExpenses.OpenExpensesRow NewOpenExpensesRow()
    {
      return (dsOpenExpenses.OpenExpensesRow) this.NewRow();
    }

    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsOpenExpenses.OpenExpensesRow(builder);
    }

    protected override Type GetRowType() => typeof (dsOpenExpenses.OpenExpensesRow);

    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.OpenExpensesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsOpenExpenses.OpenExpensesRowChangeEventHandler expensesRowChangedEvent = this.OpenExpensesRowChangedEvent;
      if (expensesRowChangedEvent == null)
        return;
      expensesRowChangedEvent((object) this, new dsOpenExpenses.OpenExpensesRowChangeEvent((dsOpenExpenses.OpenExpensesRow) e.Row, e.Action));
    }

    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.OpenExpensesRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsOpenExpenses.OpenExpensesRowChangeEventHandler rowChangingEvent = this.OpenExpensesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsOpenExpenses.OpenExpensesRowChangeEvent((dsOpenExpenses.OpenExpensesRow) e.Row, e.Action));
    }

    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.OpenExpensesRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsOpenExpenses.OpenExpensesRowChangeEventHandler expensesRowDeletedEvent = this.OpenExpensesRowDeletedEvent;
      if (expensesRowDeletedEvent == null)
        return;
      expensesRowDeletedEvent((object) this, new dsOpenExpenses.OpenExpensesRowChangeEvent((dsOpenExpenses.OpenExpensesRow) e.Row, e.Action));
    }

    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.OpenExpensesRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsOpenExpenses.OpenExpensesRowChangeEventHandler rowDeletingEvent = this.OpenExpensesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsOpenExpenses.OpenExpensesRowChangeEvent((dsOpenExpenses.OpenExpensesRow) e.Row, e.Action));
    }

    public void RemoveOpenExpensesRow(dsOpenExpenses.OpenExpensesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }
  }

  [DebuggerStepThrough]
  public class OpenExpensesRow : DataRow
  {
    private dsOpenExpenses.OpenExpensesDataTable tableOpenExpenses;

    internal OpenExpensesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableOpenExpenses = (dsOpenExpenses.OpenExpensesDataTable) this.Table;
    }

    public int poNum
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tableOpenExpenses.poNumColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableOpenExpenses.poNumColumn] = (object) value;
    }

    public string payeeGuid
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableOpenExpenses.payeeGuidColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableOpenExpenses.payeeGuidColumn] = (object) value;
    }

    public string Payee
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableOpenExpenses.PayeeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableOpenExpenses.PayeeColumn] = (object) value;
    }

    public DateTime PODate
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tableOpenExpenses.PODateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableOpenExpenses.PODateColumn] = (object) value;
    }

    public string enteredBy
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableOpenExpenses.enteredByColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableOpenExpenses.enteredByColumn] = (object) value;
    }

    public Decimal ExpenseTotal
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tableOpenExpenses.ExpenseTotalColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableOpenExpenses.ExpenseTotalColumn] = (object) value;
    }

    public Decimal AmountRemaining
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tableOpenExpenses.AmountRemainingColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableOpenExpenses.AmountRemainingColumn] = (object) value;
    }

    public bool IspoNumNull() => this.IsNull(this.tableOpenExpenses.poNumColumn);

    public void SetpoNumNull()
    {
      this[this.tableOpenExpenses.poNumColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IspayeeGuidNull() => this.IsNull(this.tableOpenExpenses.payeeGuidColumn);

    public void SetpayeeGuidNull()
    {
      this[this.tableOpenExpenses.payeeGuidColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsPayeeNull() => this.IsNull(this.tableOpenExpenses.PayeeColumn);

    public void SetPayeeNull()
    {
      this[this.tableOpenExpenses.PayeeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsPODateNull() => this.IsNull(this.tableOpenExpenses.PODateColumn);

    public void SetPODateNull()
    {
      this[this.tableOpenExpenses.PODateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsenteredByNull() => this.IsNull(this.tableOpenExpenses.enteredByColumn);

    public void SetenteredByNull()
    {
      this[this.tableOpenExpenses.enteredByColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsExpenseTotalNull() => this.IsNull(this.tableOpenExpenses.ExpenseTotalColumn);

    public void SetExpenseTotalNull()
    {
      this[this.tableOpenExpenses.ExpenseTotalColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsAmountRemainingNull()
    {
      return this.IsNull(this.tableOpenExpenses.AmountRemainingColumn);
    }

    public void SetAmountRemainingNull()
    {
      this[this.tableOpenExpenses.AmountRemainingColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  [DebuggerStepThrough]
  public class OpenExpensesRowChangeEvent : EventArgs
  {
    private dsOpenExpenses.OpenExpensesRow eventRow;
    private DataRowAction eventAction;

    public OpenExpensesRowChangeEvent(dsOpenExpenses.OpenExpensesRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    public dsOpenExpenses.OpenExpensesRow Row => this.eventRow;

    public DataRowAction Action => this.eventAction;
  }
}
