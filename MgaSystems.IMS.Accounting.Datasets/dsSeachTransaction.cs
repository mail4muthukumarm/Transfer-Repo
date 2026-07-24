// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.AccountingDatasets.dsSeachTransaction
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
public class dsSeachTransaction : DataSet
{
  private dsSeachTransaction.TransactionsDataTable tableTransactions;

  public dsSeachTransaction()
  {
    this.InitClass();
    CollectionChangeEventHandler changeEventHandler = new CollectionChangeEventHandler(this.SchemaChanged);
    this.Tables.CollectionChanged += changeEventHandler;
    this.Relations.CollectionChanged += changeEventHandler;
  }

  protected dsSeachTransaction(SerializationInfo info, StreamingContext context)
  {
    string s = Conversions.ToString(info.GetValue("XmlSchema", typeof (string)));
    if (s != null)
    {
      DataSet dataSet = new DataSet();
      dataSet.ReadXmlSchema((XmlReader) new XmlTextReader((TextReader) new StringReader(s)));
      if (dataSet.Tables[nameof (Transactions)] != null)
        this.Tables.Add((DataTable) new dsSeachTransaction.TransactionsDataTable(dataSet.Tables[nameof (Transactions)]));
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
  public dsSeachTransaction.TransactionsDataTable Transactions => this.tableTransactions;

  public override DataSet Clone()
  {
    dsSeachTransaction seachTransaction = (dsSeachTransaction) base.Clone();
    seachTransaction.InitVars();
    return (DataSet) seachTransaction;
  }

  protected override bool ShouldSerializeTables() => false;

  protected override bool ShouldSerializeRelations() => false;

  protected override void ReadXmlSerializable(XmlReader reader)
  {
    this.Reset();
    DataSet dataSet = new DataSet();
    int num = (int) dataSet.ReadXml(reader);
    if (dataSet.Tables["Transactions"] != null)
      this.Tables.Add((DataTable) new dsSeachTransaction.TransactionsDataTable(dataSet.Tables["Transactions"]));
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
    this.tableTransactions = (dsSeachTransaction.TransactionsDataTable) this.Tables["Transactions"];
    if (this.tableTransactions == null)
      return;
    this.tableTransactions.InitVars();
  }

  private void InitClass()
  {
    this.DataSetName = nameof (dsSeachTransaction);
    this.Prefix = "";
    this.Namespace = "http://tempuri.org/dsSeachTransaction.xsd";
    this.Locale = new CultureInfo("en-US");
    this.CaseSensitive = false;
    this.EnforceConstraints = true;
    this.tableTransactions = new dsSeachTransaction.TransactionsDataTable();
    this.Tables.Add((DataTable) this.tableTransactions);
  }

  private bool ShouldSerializeTransactions() => false;

  private void SchemaChanged(object sender, CollectionChangeEventArgs e)
  {
    if (e.Action != CollectionChangeAction.Remove)
      return;
    this.InitVars();
  }

  public delegate void TransactionsRowChangeEventHandler(
    object sender,
    dsSeachTransaction.TransactionsRowChangeEvent e);

  [DebuggerStepThrough]
  public class TransactionsDataTable : DataTable, IEnumerable
  {
    private DataColumn columntransactNum;
    private DataColumn columnpostDate;
    private DataColumn columnUser;
    private DataColumn columnCheckNumber;
    private DataColumn columnTransactionType;
    private DataColumn columnEntity;
    private DataColumn columnAmount;

    internal TransactionsDataTable()
      : base("Transactions")
    {
      this.InitClass();
    }

    internal TransactionsDataTable(DataTable table)
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

    internal DataColumn transactNumColumn => this.columntransactNum;

    internal DataColumn postDateColumn => this.columnpostDate;

    internal DataColumn UserColumn => this.columnUser;

    internal DataColumn CheckNumberColumn => this.columnCheckNumber;

    internal DataColumn TransactionTypeColumn => this.columnTransactionType;

    internal DataColumn EntityColumn => this.columnEntity;

    internal DataColumn AmountColumn => this.columnAmount;

    public dsSeachTransaction.TransactionsRow this[int index]
    {
      get => (dsSeachTransaction.TransactionsRow) this.Rows[index];
    }

    public event dsSeachTransaction.TransactionsRowChangeEventHandler TransactionsRowChanged;

    public event dsSeachTransaction.TransactionsRowChangeEventHandler TransactionsRowChanging;

    public event dsSeachTransaction.TransactionsRowChangeEventHandler TransactionsRowDeleted;

    public event dsSeachTransaction.TransactionsRowChangeEventHandler TransactionsRowDeleting;

    public void AddTransactionsRow(dsSeachTransaction.TransactionsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    public dsSeachTransaction.TransactionsRow AddTransactionsRow(
      int transactNum,
      DateTime postDate,
      string User,
      string CheckNumber,
      string TransactionType,
      string Entity,
      Decimal Amount)
    {
      dsSeachTransaction.TransactionsRow row = (dsSeachTransaction.TransactionsRow) this.NewRow();
      row.ItemArray = new object[7]
      {
        (object) transactNum,
        (object) postDate,
        (object) User,
        (object) CheckNumber,
        (object) TransactionType,
        (object) Entity,
        (object) Amount
      };
      this.Rows.Add((DataRow) row);
      return row;
    }

    public IEnumerator GetEnumerator() => this.Rows.GetEnumerator();

    public override DataTable Clone()
    {
      dsSeachTransaction.TransactionsDataTable transactionsDataTable = (dsSeachTransaction.TransactionsDataTable) base.Clone();
      transactionsDataTable.InitVars();
      return (DataTable) transactionsDataTable;
    }

    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsSeachTransaction.TransactionsDataTable();
    }

    internal void InitVars()
    {
      this.columntransactNum = this.Columns["transactNum"];
      this.columnpostDate = this.Columns["postDate"];
      this.columnUser = this.Columns["User"];
      this.columnCheckNumber = this.Columns["CheckNumber"];
      this.columnTransactionType = this.Columns["TransactionType"];
      this.columnEntity = this.Columns["Entity"];
      this.columnAmount = this.Columns["Amount"];
    }

    private void InitClass()
    {
      this.columntransactNum = new DataColumn("transactNum", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columntransactNum);
      this.columnpostDate = new DataColumn("postDate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnpostDate);
      this.columnUser = new DataColumn("User", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnUser);
      this.columnCheckNumber = new DataColumn("CheckNumber", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCheckNumber);
      this.columnTransactionType = new DataColumn("TransactionType", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnTransactionType);
      this.columnEntity = new DataColumn("Entity", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEntity);
      this.columnAmount = new DataColumn("Amount", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAmount);
    }

    public dsSeachTransaction.TransactionsRow NewTransactionsRow()
    {
      return (dsSeachTransaction.TransactionsRow) this.NewRow();
    }

    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsSeachTransaction.TransactionsRow(builder);
    }

    protected override Type GetRowType() => typeof (dsSeachTransaction.TransactionsRow);

    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.TransactionsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsSeachTransaction.TransactionsRowChangeEventHandler transactionsRowChangedEvent = this.TransactionsRowChangedEvent;
      if (transactionsRowChangedEvent == null)
        return;
      transactionsRowChangedEvent((object) this, new dsSeachTransaction.TransactionsRowChangeEvent((dsSeachTransaction.TransactionsRow) e.Row, e.Action));
    }

    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.TransactionsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsSeachTransaction.TransactionsRowChangeEventHandler rowChangingEvent = this.TransactionsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsSeachTransaction.TransactionsRowChangeEvent((dsSeachTransaction.TransactionsRow) e.Row, e.Action));
    }

    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.TransactionsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsSeachTransaction.TransactionsRowChangeEventHandler transactionsRowDeletedEvent = this.TransactionsRowDeletedEvent;
      if (transactionsRowDeletedEvent == null)
        return;
      transactionsRowDeletedEvent((object) this, new dsSeachTransaction.TransactionsRowChangeEvent((dsSeachTransaction.TransactionsRow) e.Row, e.Action));
    }

    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.TransactionsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsSeachTransaction.TransactionsRowChangeEventHandler rowDeletingEvent = this.TransactionsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsSeachTransaction.TransactionsRowChangeEvent((dsSeachTransaction.TransactionsRow) e.Row, e.Action));
    }

    public void RemoveTransactionsRow(dsSeachTransaction.TransactionsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }
  }

  [DebuggerStepThrough]
  public class TransactionsRow : DataRow
  {
    private dsSeachTransaction.TransactionsDataTable tableTransactions;

    internal TransactionsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableTransactions = (dsSeachTransaction.TransactionsDataTable) this.Table;
    }

    public int transactNum
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tableTransactions.transactNumColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableTransactions.transactNumColumn] = (object) value;
    }

    public DateTime postDate
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tableTransactions.postDateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableTransactions.postDateColumn] = (object) value;
    }

    public string User
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableTransactions.UserColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableTransactions.UserColumn] = (object) value;
    }

    public string CheckNumber
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableTransactions.CheckNumberColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableTransactions.CheckNumberColumn] = (object) value;
    }

    public string TransactionType
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableTransactions.TransactionTypeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableTransactions.TransactionTypeColumn] = (object) value;
    }

    public string Entity
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableTransactions.EntityColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableTransactions.EntityColumn] = (object) value;
    }

    public Decimal Amount
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tableTransactions.AmountColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableTransactions.AmountColumn] = (object) value;
    }

    public bool IstransactNumNull() => this.IsNull(this.tableTransactions.transactNumColumn);

    public void SettransactNumNull()
    {
      this[this.tableTransactions.transactNumColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IspostDateNull() => this.IsNull(this.tableTransactions.postDateColumn);

    public void SetpostDateNull()
    {
      this[this.tableTransactions.postDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsUserNull() => this.IsNull(this.tableTransactions.UserColumn);

    public void SetUserNull()
    {
      this[this.tableTransactions.UserColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsCheckNumberNull() => this.IsNull(this.tableTransactions.CheckNumberColumn);

    public void SetCheckNumberNull()
    {
      this[this.tableTransactions.CheckNumberColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsTransactionTypeNull()
    {
      return this.IsNull(this.tableTransactions.TransactionTypeColumn);
    }

    public void SetTransactionTypeNull()
    {
      this[this.tableTransactions.TransactionTypeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsEntityNull() => this.IsNull(this.tableTransactions.EntityColumn);

    public void SetEntityNull()
    {
      this[this.tableTransactions.EntityColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsAmountNull() => this.IsNull(this.tableTransactions.AmountColumn);

    public void SetAmountNull()
    {
      this[this.tableTransactions.AmountColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  [DebuggerStepThrough]
  public class TransactionsRowChangeEvent : EventArgs
  {
    private dsSeachTransaction.TransactionsRow eventRow;
    private DataRowAction eventAction;

    public TransactionsRowChangeEvent(dsSeachTransaction.TransactionsRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    public dsSeachTransaction.TransactionsRow Row => this.eventRow;

    public DataRowAction Action => this.eventAction;
  }
}
