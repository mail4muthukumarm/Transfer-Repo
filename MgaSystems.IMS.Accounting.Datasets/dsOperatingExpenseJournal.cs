// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.AccountingDatasets.dsOperatingExpenseJournal
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
public class dsOperatingExpenseJournal : DataSet
{
  private dsOperatingExpenseJournal.spFin_GetOperatingExpenseJournalDataTable tablespFin_GetOperatingExpenseJournal;

  public dsOperatingExpenseJournal()
  {
    this.InitClass();
    CollectionChangeEventHandler changeEventHandler = new CollectionChangeEventHandler(this.SchemaChanged);
    this.Tables.CollectionChanged += changeEventHandler;
    this.Relations.CollectionChanged += changeEventHandler;
  }

  protected dsOperatingExpenseJournal(SerializationInfo info, StreamingContext context)
  {
    string s = Conversions.ToString(info.GetValue("XmlSchema", typeof (string)));
    if (s != null)
    {
      DataSet dataSet = new DataSet();
      dataSet.ReadXmlSchema((XmlReader) new XmlTextReader((TextReader) new StringReader(s)));
      if (dataSet.Tables[nameof (spFin_GetOperatingExpenseJournal)] != null)
        this.Tables.Add((DataTable) new dsOperatingExpenseJournal.spFin_GetOperatingExpenseJournalDataTable(dataSet.Tables[nameof (spFin_GetOperatingExpenseJournal)]));
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
  public dsOperatingExpenseJournal.spFin_GetOperatingExpenseJournalDataTable spFin_GetOperatingExpenseJournal
  {
    get => this.tablespFin_GetOperatingExpenseJournal;
  }

  public override DataSet Clone()
  {
    dsOperatingExpenseJournal operatingExpenseJournal = (dsOperatingExpenseJournal) base.Clone();
    operatingExpenseJournal.InitVars();
    return (DataSet) operatingExpenseJournal;
  }

  protected override bool ShouldSerializeTables() => false;

  protected override bool ShouldSerializeRelations() => false;

  protected override void ReadXmlSerializable(XmlReader reader)
  {
    this.Reset();
    DataSet dataSet = new DataSet();
    int num = (int) dataSet.ReadXml(reader);
    if (dataSet.Tables["spFin_GetOperatingExpenseJournal"] != null)
      this.Tables.Add((DataTable) new dsOperatingExpenseJournal.spFin_GetOperatingExpenseJournalDataTable(dataSet.Tables["spFin_GetOperatingExpenseJournal"]));
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
    this.tablespFin_GetOperatingExpenseJournal = (dsOperatingExpenseJournal.spFin_GetOperatingExpenseJournalDataTable) this.Tables["spFin_GetOperatingExpenseJournal"];
    if (this.tablespFin_GetOperatingExpenseJournal == null)
      return;
    this.tablespFin_GetOperatingExpenseJournal.InitVars();
  }

  private void InitClass()
  {
    this.DataSetName = nameof (dsOperatingExpenseJournal);
    this.Prefix = "";
    this.Namespace = "http://www.tempuri.org/dsOperatingExpenseJournal.xsd";
    this.Locale = new CultureInfo("en-US");
    this.CaseSensitive = false;
    this.EnforceConstraints = true;
    this.tablespFin_GetOperatingExpenseJournal = new dsOperatingExpenseJournal.spFin_GetOperatingExpenseJournalDataTable();
    this.Tables.Add((DataTable) this.tablespFin_GetOperatingExpenseJournal);
  }

  private bool ShouldSerializespFin_GetOperatingExpenseJournal() => false;

  private void SchemaChanged(object sender, CollectionChangeEventArgs e)
  {
    if (e.Action != CollectionChangeAction.Remove)
      return;
    this.InitVars();
  }

  public delegate void spFin_GetOperatingExpenseJournalRowChangeEventHandler(
    object sender,
    dsOperatingExpenseJournal.spFin_GetOperatingExpenseJournalRowChangeEvent e);

  [DebuggerStepThrough]
  public class spFin_GetOperatingExpenseJournalDataTable : DataTable, IEnumerable
  {
    private DataColumn column_DATE;
    private DataColumn column_Purchase_Order__;
    private DataColumn column_Check__;
    private DataColumn columnPayee;
    private DataColumn columnExpense;
    private DataColumn columnAmount;
    private DataColumn column_Payee_Invoice__;
    private DataColumn columnBalance;

    internal spFin_GetOperatingExpenseJournalDataTable()
      : base("spFin_GetOperatingExpenseJournal")
    {
      this.InitClass();
    }

    internal spFin_GetOperatingExpenseJournalDataTable(DataTable table)
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

    internal DataColumn _DATEColumn => this.column_DATE;

    internal DataColumn _Purchase_Order__Column => this.column_Purchase_Order__;

    internal DataColumn _Check__Column => this.column_Check__;

    internal DataColumn PayeeColumn => this.columnPayee;

    internal DataColumn ExpenseColumn => this.columnExpense;

    internal DataColumn AmountColumn => this.columnAmount;

    internal DataColumn _Payee_Invoice__Column => this.column_Payee_Invoice__;

    internal DataColumn BalanceColumn => this.columnBalance;

    public dsOperatingExpenseJournal.spFin_GetOperatingExpenseJournalRow this[int index]
    {
      get => (dsOperatingExpenseJournal.spFin_GetOperatingExpenseJournalRow) this.Rows[index];
    }

    public event dsOperatingExpenseJournal.spFin_GetOperatingExpenseJournalRowChangeEventHandler spFin_GetOperatingExpenseJournalRowChanged;

    public event dsOperatingExpenseJournal.spFin_GetOperatingExpenseJournalRowChangeEventHandler spFin_GetOperatingExpenseJournalRowChanging;

    public event dsOperatingExpenseJournal.spFin_GetOperatingExpenseJournalRowChangeEventHandler spFin_GetOperatingExpenseJournalRowDeleted;

    public event dsOperatingExpenseJournal.spFin_GetOperatingExpenseJournalRowChangeEventHandler spFin_GetOperatingExpenseJournalRowDeleting;

    public void AddspFin_GetOperatingExpenseJournalRow(
      dsOperatingExpenseJournal.spFin_GetOperatingExpenseJournalRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    public dsOperatingExpenseJournal.spFin_GetOperatingExpenseJournalRow AddspFin_GetOperatingExpenseJournalRow(
      DateTime _DATE,
      string _Check__,
      string Payee,
      string Expense,
      Decimal Amount,
      string _Payee_Invoice__,
      Decimal Balance)
    {
      dsOperatingExpenseJournal.spFin_GetOperatingExpenseJournalRow row = (dsOperatingExpenseJournal.spFin_GetOperatingExpenseJournalRow) this.NewRow();
      row.ItemArray = new object[8]
      {
        (object) _DATE,
        null,
        (object) _Check__,
        (object) Payee,
        (object) Expense,
        (object) Amount,
        (object) _Payee_Invoice__,
        (object) Balance
      };
      this.Rows.Add((DataRow) row);
      return row;
    }

    public IEnumerator GetEnumerator() => this.Rows.GetEnumerator();

    public override DataTable Clone()
    {
      dsOperatingExpenseJournal.spFin_GetOperatingExpenseJournalDataTable journalDataTable = (dsOperatingExpenseJournal.spFin_GetOperatingExpenseJournalDataTable) base.Clone();
      journalDataTable.InitVars();
      return (DataTable) journalDataTable;
    }

    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsOperatingExpenseJournal.spFin_GetOperatingExpenseJournalDataTable();
    }

    internal void InitVars()
    {
      this.column_DATE = this.Columns["DATE"];
      this.column_Purchase_Order__ = this.Columns["Purchase Order #"];
      this.column_Check__ = this.Columns["Check #"];
      this.columnPayee = this.Columns["Payee"];
      this.columnExpense = this.Columns["Expense"];
      this.columnAmount = this.Columns["Amount"];
      this.column_Payee_Invoice__ = this.Columns["Payee Invoice #"];
      this.columnBalance = this.Columns["Balance"];
    }

    private void InitClass()
    {
      this.column_DATE = new DataColumn("DATE", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.column_DATE);
      this.column_Purchase_Order__ = new DataColumn("Purchase Order #", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.column_Purchase_Order__);
      this.column_Check__ = new DataColumn("Check #", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.column_Check__);
      this.columnPayee = new DataColumn("Payee", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPayee);
      this.columnExpense = new DataColumn("Expense", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnExpense);
      this.columnAmount = new DataColumn("Amount", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAmount);
      this.column_Payee_Invoice__ = new DataColumn("Payee Invoice #", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.column_Payee_Invoice__);
      this.columnBalance = new DataColumn("Balance", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnBalance);
      this.column_DATE.AllowDBNull = false;
      this.column_Purchase_Order__.AutoIncrement = true;
      this.column_Purchase_Order__.AllowDBNull = false;
      this.column_Purchase_Order__.ReadOnly = true;
      this.column_Check__.ReadOnly = true;
      this.columnPayee.ReadOnly = true;
      this.columnExpense.ReadOnly = true;
      this.columnAmount.ReadOnly = true;
      this.columnBalance.ReadOnly = true;
    }

    public dsOperatingExpenseJournal.spFin_GetOperatingExpenseJournalRow NewspFin_GetOperatingExpenseJournalRow()
    {
      return (dsOperatingExpenseJournal.spFin_GetOperatingExpenseJournalRow) this.NewRow();
    }

    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsOperatingExpenseJournal.spFin_GetOperatingExpenseJournalRow(builder);
    }

    protected override Type GetRowType()
    {
      return typeof (dsOperatingExpenseJournal.spFin_GetOperatingExpenseJournalRow);
    }

    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.spFin_GetOperatingExpenseJournalRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsOperatingExpenseJournal.spFin_GetOperatingExpenseJournalRowChangeEventHandler journalRowChangedEvent = this.spFin_GetOperatingExpenseJournalRowChangedEvent;
      if (journalRowChangedEvent == null)
        return;
      journalRowChangedEvent((object) this, new dsOperatingExpenseJournal.spFin_GetOperatingExpenseJournalRowChangeEvent((dsOperatingExpenseJournal.spFin_GetOperatingExpenseJournalRow) e.Row, e.Action));
    }

    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.spFin_GetOperatingExpenseJournalRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsOperatingExpenseJournal.spFin_GetOperatingExpenseJournalRowChangeEventHandler rowChangingEvent = this.spFin_GetOperatingExpenseJournalRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsOperatingExpenseJournal.spFin_GetOperatingExpenseJournalRowChangeEvent((dsOperatingExpenseJournal.spFin_GetOperatingExpenseJournalRow) e.Row, e.Action));
    }

    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.spFin_GetOperatingExpenseJournalRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsOperatingExpenseJournal.spFin_GetOperatingExpenseJournalRowChangeEventHandler journalRowDeletedEvent = this.spFin_GetOperatingExpenseJournalRowDeletedEvent;
      if (journalRowDeletedEvent == null)
        return;
      journalRowDeletedEvent((object) this, new dsOperatingExpenseJournal.spFin_GetOperatingExpenseJournalRowChangeEvent((dsOperatingExpenseJournal.spFin_GetOperatingExpenseJournalRow) e.Row, e.Action));
    }

    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.spFin_GetOperatingExpenseJournalRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsOperatingExpenseJournal.spFin_GetOperatingExpenseJournalRowChangeEventHandler rowDeletingEvent = this.spFin_GetOperatingExpenseJournalRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsOperatingExpenseJournal.spFin_GetOperatingExpenseJournalRowChangeEvent((dsOperatingExpenseJournal.spFin_GetOperatingExpenseJournalRow) e.Row, e.Action));
    }

    public void RemovespFin_GetOperatingExpenseJournalRow(
      dsOperatingExpenseJournal.spFin_GetOperatingExpenseJournalRow row)
    {
      this.Rows.Remove((DataRow) row);
    }
  }

  [DebuggerStepThrough]
  public class spFin_GetOperatingExpenseJournalRow : DataRow
  {
    private dsOperatingExpenseJournal.spFin_GetOperatingExpenseJournalDataTable tablespFin_GetOperatingExpenseJournal;

    internal spFin_GetOperatingExpenseJournalRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablespFin_GetOperatingExpenseJournal = (dsOperatingExpenseJournal.spFin_GetOperatingExpenseJournalDataTable) this.Table;
    }

    public DateTime _DATE
    {
      get => Conversions.ToDate(this[this.tablespFin_GetOperatingExpenseJournal._DATEColumn]);
      set => this[this.tablespFin_GetOperatingExpenseJournal._DATEColumn] = (object) value;
    }

    public int _Purchase_Order__
    {
      get
      {
        return Conversions.ToInteger(this[this.tablespFin_GetOperatingExpenseJournal._Purchase_Order__Column]);
      }
      set
      {
        this[this.tablespFin_GetOperatingExpenseJournal._Purchase_Order__Column] = (object) value;
      }
    }

    public string _Check__
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablespFin_GetOperatingExpenseJournal._Check__Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablespFin_GetOperatingExpenseJournal._Check__Column] = (object) value;
    }

    public string Payee
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablespFin_GetOperatingExpenseJournal.PayeeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablespFin_GetOperatingExpenseJournal.PayeeColumn] = (object) value;
    }

    public string Expense
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablespFin_GetOperatingExpenseJournal.ExpenseColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablespFin_GetOperatingExpenseJournal.ExpenseColumn] = (object) value;
    }

    public Decimal Amount
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tablespFin_GetOperatingExpenseJournal.AmountColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablespFin_GetOperatingExpenseJournal.AmountColumn] = (object) value;
    }

    public string _Payee_Invoice__
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablespFin_GetOperatingExpenseJournal._Payee_Invoice__Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set
      {
        this[this.tablespFin_GetOperatingExpenseJournal._Payee_Invoice__Column] = (object) value;
      }
    }

    public Decimal Balance
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tablespFin_GetOperatingExpenseJournal.BalanceColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablespFin_GetOperatingExpenseJournal.BalanceColumn] = (object) value;
    }

    public bool Is_Check__Null()
    {
      return this.IsNull(this.tablespFin_GetOperatingExpenseJournal._Check__Column);
    }

    public void Set_Check__Null()
    {
      this[this.tablespFin_GetOperatingExpenseJournal._Check__Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsPayeeNull()
    {
      return this.IsNull(this.tablespFin_GetOperatingExpenseJournal.PayeeColumn);
    }

    public void SetPayeeNull()
    {
      this[this.tablespFin_GetOperatingExpenseJournal.PayeeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsExpenseNull()
    {
      return this.IsNull(this.tablespFin_GetOperatingExpenseJournal.ExpenseColumn);
    }

    public void SetExpenseNull()
    {
      this[this.tablespFin_GetOperatingExpenseJournal.ExpenseColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsAmountNull()
    {
      return this.IsNull(this.tablespFin_GetOperatingExpenseJournal.AmountColumn);
    }

    public void SetAmountNull()
    {
      this[this.tablespFin_GetOperatingExpenseJournal.AmountColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool Is_Payee_Invoice__Null()
    {
      return this.IsNull(this.tablespFin_GetOperatingExpenseJournal._Payee_Invoice__Column);
    }

    public void Set_Payee_Invoice__Null()
    {
      this[this.tablespFin_GetOperatingExpenseJournal._Payee_Invoice__Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsBalanceNull()
    {
      return this.IsNull(this.tablespFin_GetOperatingExpenseJournal.BalanceColumn);
    }

    public void SetBalanceNull()
    {
      this[this.tablespFin_GetOperatingExpenseJournal.BalanceColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  [DebuggerStepThrough]
  public class spFin_GetOperatingExpenseJournalRowChangeEvent : EventArgs
  {
    private dsOperatingExpenseJournal.spFin_GetOperatingExpenseJournalRow eventRow;
    private DataRowAction eventAction;

    public spFin_GetOperatingExpenseJournalRowChangeEvent(
      dsOperatingExpenseJournal.spFin_GetOperatingExpenseJournalRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    public dsOperatingExpenseJournal.spFin_GetOperatingExpenseJournalRow Row => this.eventRow;

    public DataRowAction Action => this.eventAction;
  }
}
