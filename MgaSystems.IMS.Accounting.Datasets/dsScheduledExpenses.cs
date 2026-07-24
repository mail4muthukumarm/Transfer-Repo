// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.AccountingDatasets.dsScheduledExpenses
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
public class dsScheduledExpenses : DataSet
{
  private dsScheduledExpenses.ScheduledExpensesDataTable tableScheduledExpenses;

  public dsScheduledExpenses()
  {
    this.InitClass();
    CollectionChangeEventHandler changeEventHandler = new CollectionChangeEventHandler(this.SchemaChanged);
    this.Tables.CollectionChanged += changeEventHandler;
    this.Relations.CollectionChanged += changeEventHandler;
  }

  protected dsScheduledExpenses(SerializationInfo info, StreamingContext context)
  {
    string s = Conversions.ToString(info.GetValue("XmlSchema", typeof (string)));
    if (s != null)
    {
      DataSet dataSet = new DataSet();
      dataSet.ReadXmlSchema((XmlReader) new XmlTextReader((TextReader) new StringReader(s)));
      if (dataSet.Tables[nameof (ScheduledExpenses)] != null)
        this.Tables.Add((DataTable) new dsScheduledExpenses.ScheduledExpensesDataTable(dataSet.Tables[nameof (ScheduledExpenses)]));
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
  public dsScheduledExpenses.ScheduledExpensesDataTable ScheduledExpenses
  {
    get => this.tableScheduledExpenses;
  }

  public override DataSet Clone()
  {
    dsScheduledExpenses scheduledExpenses = (dsScheduledExpenses) base.Clone();
    scheduledExpenses.InitVars();
    return (DataSet) scheduledExpenses;
  }

  protected override bool ShouldSerializeTables() => false;

  protected override bool ShouldSerializeRelations() => false;

  protected override void ReadXmlSerializable(XmlReader reader)
  {
    this.Reset();
    DataSet dataSet = new DataSet();
    int num = (int) dataSet.ReadXml(reader);
    if (dataSet.Tables["ScheduledExpenses"] != null)
      this.Tables.Add((DataTable) new dsScheduledExpenses.ScheduledExpensesDataTable(dataSet.Tables["ScheduledExpenses"]));
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
    this.tableScheduledExpenses = (dsScheduledExpenses.ScheduledExpensesDataTable) this.Tables["ScheduledExpenses"];
    if (this.tableScheduledExpenses == null)
      return;
    this.tableScheduledExpenses.InitVars();
  }

  private void InitClass()
  {
    this.DataSetName = nameof (dsScheduledExpenses);
    this.Prefix = "";
    this.Namespace = "http://tempuri.org/dsScheduledExpenses.xsd";
    this.Locale = new CultureInfo("en-US");
    this.CaseSensitive = false;
    this.EnforceConstraints = true;
    this.tableScheduledExpenses = new dsScheduledExpenses.ScheduledExpensesDataTable();
    this.Tables.Add((DataTable) this.tableScheduledExpenses);
  }

  private bool ShouldSerializeScheduledExpenses() => false;

  private void SchemaChanged(object sender, CollectionChangeEventArgs e)
  {
    if (e.Action != CollectionChangeAction.Remove)
      return;
    this.InitVars();
  }

  public delegate void ScheduledExpensesRowChangeEventHandler(
    object sender,
    dsScheduledExpenses.ScheduledExpensesRowChangeEvent e);

  [DebuggerStepThrough]
  public class ScheduledExpensesDataTable : DataTable, IEnumerable
  {
    private DataColumn columnPODate;
    private DataColumn columnPONum;
    private DataColumn columnPayeeGuid;
    private DataColumn columnPayee;
    private DataColumn columnAmount;
    private DataColumn columnPaymentDueDate;
    private DataColumn columnPaymentDueDate2;

    internal ScheduledExpensesDataTable()
      : base("ScheduledExpenses")
    {
      this.InitClass();
    }

    internal ScheduledExpensesDataTable(DataTable table)
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

    internal DataColumn PODateColumn => this.columnPODate;

    internal DataColumn PONumColumn => this.columnPONum;

    internal DataColumn PayeeGuidColumn => this.columnPayeeGuid;

    internal DataColumn PayeeColumn => this.columnPayee;

    internal DataColumn AmountColumn => this.columnAmount;

    internal DataColumn PaymentDueDateColumn => this.columnPaymentDueDate;

    internal DataColumn PaymentDueDate2Column => this.columnPaymentDueDate2;

    public dsScheduledExpenses.ScheduledExpensesRow this[int index]
    {
      get => (dsScheduledExpenses.ScheduledExpensesRow) this.Rows[index];
    }

    public event dsScheduledExpenses.ScheduledExpensesRowChangeEventHandler ScheduledExpensesRowChanged;

    public event dsScheduledExpenses.ScheduledExpensesRowChangeEventHandler ScheduledExpensesRowChanging;

    public event dsScheduledExpenses.ScheduledExpensesRowChangeEventHandler ScheduledExpensesRowDeleted;

    public event dsScheduledExpenses.ScheduledExpensesRowChangeEventHandler ScheduledExpensesRowDeleting;

    public void AddScheduledExpensesRow(dsScheduledExpenses.ScheduledExpensesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    public dsScheduledExpenses.ScheduledExpensesRow AddScheduledExpensesRow(
      DateTime PODate,
      int PONum,
      string PayeeGuid,
      string Payee,
      Decimal Amount,
      DateTime PaymentDueDate,
      DateTime PaymentDueDate2)
    {
      dsScheduledExpenses.ScheduledExpensesRow row = (dsScheduledExpenses.ScheduledExpensesRow) this.NewRow();
      row.ItemArray = new object[7]
      {
        (object) PODate,
        (object) PONum,
        (object) PayeeGuid,
        (object) Payee,
        (object) Amount,
        (object) PaymentDueDate,
        (object) PaymentDueDate2
      };
      this.Rows.Add((DataRow) row);
      return row;
    }

    public IEnumerator GetEnumerator() => this.Rows.GetEnumerator();

    public override DataTable Clone()
    {
      dsScheduledExpenses.ScheduledExpensesDataTable expensesDataTable = (dsScheduledExpenses.ScheduledExpensesDataTable) base.Clone();
      expensesDataTable.InitVars();
      return (DataTable) expensesDataTable;
    }

    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsScheduledExpenses.ScheduledExpensesDataTable();
    }

    internal void InitVars()
    {
      this.columnPODate = this.Columns["PODate"];
      this.columnPONum = this.Columns["PONum"];
      this.columnPayeeGuid = this.Columns["PayeeGuid"];
      this.columnPayee = this.Columns["Payee"];
      this.columnAmount = this.Columns["Amount"];
      this.columnPaymentDueDate = this.Columns["PaymentDueDate"];
      this.columnPaymentDueDate2 = this.Columns["PaymentDueDate2"];
    }

    private void InitClass()
    {
      this.columnPODate = new DataColumn("PODate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPODate);
      this.columnPONum = new DataColumn("PONum", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPONum);
      this.columnPayeeGuid = new DataColumn("PayeeGuid", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPayeeGuid);
      this.columnPayee = new DataColumn("Payee", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPayee);
      this.columnAmount = new DataColumn("Amount", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAmount);
      this.columnPaymentDueDate = new DataColumn("PaymentDueDate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPaymentDueDate);
      this.columnPaymentDueDate2 = new DataColumn("PaymentDueDate2", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPaymentDueDate2);
    }

    public dsScheduledExpenses.ScheduledExpensesRow NewScheduledExpensesRow()
    {
      return (dsScheduledExpenses.ScheduledExpensesRow) this.NewRow();
    }

    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsScheduledExpenses.ScheduledExpensesRow(builder);
    }

    protected override Type GetRowType() => typeof (dsScheduledExpenses.ScheduledExpensesRow);

    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.ScheduledExpensesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsScheduledExpenses.ScheduledExpensesRowChangeEventHandler expensesRowChangedEvent = this.ScheduledExpensesRowChangedEvent;
      if (expensesRowChangedEvent == null)
        return;
      expensesRowChangedEvent((object) this, new dsScheduledExpenses.ScheduledExpensesRowChangeEvent((dsScheduledExpenses.ScheduledExpensesRow) e.Row, e.Action));
    }

    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.ScheduledExpensesRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsScheduledExpenses.ScheduledExpensesRowChangeEventHandler rowChangingEvent = this.ScheduledExpensesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsScheduledExpenses.ScheduledExpensesRowChangeEvent((dsScheduledExpenses.ScheduledExpensesRow) e.Row, e.Action));
    }

    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.ScheduledExpensesRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsScheduledExpenses.ScheduledExpensesRowChangeEventHandler expensesRowDeletedEvent = this.ScheduledExpensesRowDeletedEvent;
      if (expensesRowDeletedEvent == null)
        return;
      expensesRowDeletedEvent((object) this, new dsScheduledExpenses.ScheduledExpensesRowChangeEvent((dsScheduledExpenses.ScheduledExpensesRow) e.Row, e.Action));
    }

    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.ScheduledExpensesRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsScheduledExpenses.ScheduledExpensesRowChangeEventHandler rowDeletingEvent = this.ScheduledExpensesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsScheduledExpenses.ScheduledExpensesRowChangeEvent((dsScheduledExpenses.ScheduledExpensesRow) e.Row, e.Action));
    }

    public void RemoveScheduledExpensesRow(dsScheduledExpenses.ScheduledExpensesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }
  }

  [DebuggerStepThrough]
  public class ScheduledExpensesRow : DataRow
  {
    private dsScheduledExpenses.ScheduledExpensesDataTable tableScheduledExpenses;

    internal ScheduledExpensesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableScheduledExpenses = (dsScheduledExpenses.ScheduledExpensesDataTable) this.Table;
    }

    public DateTime PODate
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tableScheduledExpenses.PODateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableScheduledExpenses.PODateColumn] = (object) value;
    }

    public int PONum
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tableScheduledExpenses.PONumColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableScheduledExpenses.PONumColumn] = (object) value;
    }

    public string PayeeGuid
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableScheduledExpenses.PayeeGuidColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableScheduledExpenses.PayeeGuidColumn] = (object) value;
    }

    public string Payee
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableScheduledExpenses.PayeeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableScheduledExpenses.PayeeColumn] = (object) value;
    }

    public Decimal Amount
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tableScheduledExpenses.AmountColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableScheduledExpenses.AmountColumn] = (object) value;
    }

    public DateTime PaymentDueDate
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tableScheduledExpenses.PaymentDueDateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableScheduledExpenses.PaymentDueDateColumn] = (object) value;
    }

    public DateTime PaymentDueDate2
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tableScheduledExpenses.PaymentDueDate2Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableScheduledExpenses.PaymentDueDate2Column] = (object) value;
    }

    public bool IsPODateNull() => this.IsNull(this.tableScheduledExpenses.PODateColumn);

    public void SetPODateNull()
    {
      this[this.tableScheduledExpenses.PODateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsPONumNull() => this.IsNull(this.tableScheduledExpenses.PONumColumn);

    public void SetPONumNull()
    {
      this[this.tableScheduledExpenses.PONumColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsPayeeGuidNull() => this.IsNull(this.tableScheduledExpenses.PayeeGuidColumn);

    public void SetPayeeGuidNull()
    {
      this[this.tableScheduledExpenses.PayeeGuidColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsPayeeNull() => this.IsNull(this.tableScheduledExpenses.PayeeColumn);

    public void SetPayeeNull()
    {
      this[this.tableScheduledExpenses.PayeeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsAmountNull() => this.IsNull(this.tableScheduledExpenses.AmountColumn);

    public void SetAmountNull()
    {
      this[this.tableScheduledExpenses.AmountColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsPaymentDueDateNull()
    {
      return this.IsNull(this.tableScheduledExpenses.PaymentDueDateColumn);
    }

    public void SetPaymentDueDateNull()
    {
      this[this.tableScheduledExpenses.PaymentDueDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsPaymentDueDate2Null()
    {
      return this.IsNull(this.tableScheduledExpenses.PaymentDueDate2Column);
    }

    public void SetPaymentDueDate2Null()
    {
      this[this.tableScheduledExpenses.PaymentDueDate2Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  [DebuggerStepThrough]
  public class ScheduledExpensesRowChangeEvent : EventArgs
  {
    private dsScheduledExpenses.ScheduledExpensesRow eventRow;
    private DataRowAction eventAction;

    public ScheduledExpensesRowChangeEvent(
      dsScheduledExpenses.ScheduledExpensesRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    public dsScheduledExpenses.ScheduledExpensesRow Row => this.eventRow;

    public DataRowAction Action => this.eventAction;
  }
}
