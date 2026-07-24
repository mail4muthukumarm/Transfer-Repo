// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.AccountingDatasets.dsExchangeAcctBreakout
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
public class dsExchangeAcctBreakout : DataSet
{
  private dsExchangeAcctBreakout.InterCompanyExchangeDataTable tableInterCompanyExchange;

  public dsExchangeAcctBreakout()
  {
    this.InitClass();
    CollectionChangeEventHandler changeEventHandler = new CollectionChangeEventHandler(this.SchemaChanged);
    this.Tables.CollectionChanged += changeEventHandler;
    this.Relations.CollectionChanged += changeEventHandler;
  }

  protected dsExchangeAcctBreakout(SerializationInfo info, StreamingContext context)
  {
    string s = Conversions.ToString(info.GetValue("XmlSchema", typeof (string)));
    if (s != null)
    {
      DataSet dataSet = new DataSet();
      dataSet.ReadXmlSchema((XmlReader) new XmlTextReader((TextReader) new StringReader(s)));
      if (dataSet.Tables[nameof (InterCompanyExchange)] != null)
        this.Tables.Add((DataTable) new dsExchangeAcctBreakout.InterCompanyExchangeDataTable(dataSet.Tables[nameof (InterCompanyExchange)]));
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
  public dsExchangeAcctBreakout.InterCompanyExchangeDataTable InterCompanyExchange
  {
    get => this.tableInterCompanyExchange;
  }

  public override DataSet Clone()
  {
    dsExchangeAcctBreakout exchangeAcctBreakout = (dsExchangeAcctBreakout) base.Clone();
    exchangeAcctBreakout.InitVars();
    return (DataSet) exchangeAcctBreakout;
  }

  protected override bool ShouldSerializeTables() => false;

  protected override bool ShouldSerializeRelations() => false;

  protected override void ReadXmlSerializable(XmlReader reader)
  {
    this.Reset();
    DataSet dataSet = new DataSet();
    int num = (int) dataSet.ReadXml(reader);
    if (dataSet.Tables["InterCompanyExchange"] != null)
      this.Tables.Add((DataTable) new dsExchangeAcctBreakout.InterCompanyExchangeDataTable(dataSet.Tables["InterCompanyExchange"]));
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
    this.tableInterCompanyExchange = (dsExchangeAcctBreakout.InterCompanyExchangeDataTable) this.Tables["InterCompanyExchange"];
    if (this.tableInterCompanyExchange == null)
      return;
    this.tableInterCompanyExchange.InitVars();
  }

  private void InitClass()
  {
    this.DataSetName = nameof (dsExchangeAcctBreakout);
    this.Prefix = "";
    this.Namespace = "http://tempuri.org/dsExchangeAcctBreakout.xsd";
    this.Locale = new CultureInfo("en-US");
    this.CaseSensitive = false;
    this.EnforceConstraints = true;
    this.tableInterCompanyExchange = new dsExchangeAcctBreakout.InterCompanyExchangeDataTable();
    this.Tables.Add((DataTable) this.tableInterCompanyExchange);
  }

  private bool ShouldSerializeInterCompanyExchange() => false;

  private void SchemaChanged(object sender, CollectionChangeEventArgs e)
  {
    if (e.Action != CollectionChangeAction.Remove)
      return;
    this.InitVars();
  }

  public delegate void InterCompanyExchangeRowChangeEventHandler(
    object sender,
    dsExchangeAcctBreakout.InterCompanyExchangeRowChangeEvent e);

  [DebuggerStepThrough]
  public class InterCompanyExchangeDataTable : DataTable, IEnumerable
  {
    private DataColumn column_Date;
    private DataColumn columnTransactnum;
    private DataColumn columnAmount;
    private DataColumn columnParentTransactionType;
    private DataColumn columnComments;

    internal InterCompanyExchangeDataTable()
      : base("InterCompanyExchange")
    {
      this.InitClass();
    }

    internal InterCompanyExchangeDataTable(DataTable table)
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

    internal DataColumn _DateColumn => this.column_Date;

    internal DataColumn TransactnumColumn => this.columnTransactnum;

    internal DataColumn AmountColumn => this.columnAmount;

    internal DataColumn ParentTransactionTypeColumn => this.columnParentTransactionType;

    internal DataColumn CommentsColumn => this.columnComments;

    public dsExchangeAcctBreakout.InterCompanyExchangeRow this[int index]
    {
      get => (dsExchangeAcctBreakout.InterCompanyExchangeRow) this.Rows[index];
    }

    public event dsExchangeAcctBreakout.InterCompanyExchangeRowChangeEventHandler InterCompanyExchangeRowChanged;

    public event dsExchangeAcctBreakout.InterCompanyExchangeRowChangeEventHandler InterCompanyExchangeRowChanging;

    public event dsExchangeAcctBreakout.InterCompanyExchangeRowChangeEventHandler InterCompanyExchangeRowDeleted;

    public event dsExchangeAcctBreakout.InterCompanyExchangeRowChangeEventHandler InterCompanyExchangeRowDeleting;

    public void AddInterCompanyExchangeRow(dsExchangeAcctBreakout.InterCompanyExchangeRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    public dsExchangeAcctBreakout.InterCompanyExchangeRow AddInterCompanyExchangeRow(
      DateTime _Date,
      int Transactnum,
      Decimal Amount,
      string ParentTransactionType,
      string Comments)
    {
      dsExchangeAcctBreakout.InterCompanyExchangeRow row = (dsExchangeAcctBreakout.InterCompanyExchangeRow) this.NewRow();
      row.ItemArray = new object[5]
      {
        (object) _Date,
        (object) Transactnum,
        (object) Amount,
        (object) ParentTransactionType,
        (object) Comments
      };
      this.Rows.Add((DataRow) row);
      return row;
    }

    public IEnumerator GetEnumerator() => this.Rows.GetEnumerator();

    public override DataTable Clone()
    {
      dsExchangeAcctBreakout.InterCompanyExchangeDataTable exchangeDataTable = (dsExchangeAcctBreakout.InterCompanyExchangeDataTable) base.Clone();
      exchangeDataTable.InitVars();
      return (DataTable) exchangeDataTable;
    }

    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsExchangeAcctBreakout.InterCompanyExchangeDataTable();
    }

    internal void InitVars()
    {
      this.column_Date = this.Columns["Date"];
      this.columnTransactnum = this.Columns["Transactnum"];
      this.columnAmount = this.Columns["Amount"];
      this.columnParentTransactionType = this.Columns["ParentTransactionType"];
      this.columnComments = this.Columns["Comments"];
    }

    private void InitClass()
    {
      this.column_Date = new DataColumn("Date", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.column_Date);
      this.columnTransactnum = new DataColumn("Transactnum", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnTransactnum);
      this.columnAmount = new DataColumn("Amount", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAmount);
      this.columnParentTransactionType = new DataColumn("ParentTransactionType", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnParentTransactionType);
      this.columnComments = new DataColumn("Comments", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnComments);
    }

    public dsExchangeAcctBreakout.InterCompanyExchangeRow NewInterCompanyExchangeRow()
    {
      return (dsExchangeAcctBreakout.InterCompanyExchangeRow) this.NewRow();
    }

    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsExchangeAcctBreakout.InterCompanyExchangeRow(builder);
    }

    protected override Type GetRowType() => typeof (dsExchangeAcctBreakout.InterCompanyExchangeRow);

    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.InterCompanyExchangeRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsExchangeAcctBreakout.InterCompanyExchangeRowChangeEventHandler exchangeRowChangedEvent = this.InterCompanyExchangeRowChangedEvent;
      if (exchangeRowChangedEvent == null)
        return;
      exchangeRowChangedEvent((object) this, new dsExchangeAcctBreakout.InterCompanyExchangeRowChangeEvent((dsExchangeAcctBreakout.InterCompanyExchangeRow) e.Row, e.Action));
    }

    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.InterCompanyExchangeRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsExchangeAcctBreakout.InterCompanyExchangeRowChangeEventHandler rowChangingEvent = this.InterCompanyExchangeRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsExchangeAcctBreakout.InterCompanyExchangeRowChangeEvent((dsExchangeAcctBreakout.InterCompanyExchangeRow) e.Row, e.Action));
    }

    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.InterCompanyExchangeRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsExchangeAcctBreakout.InterCompanyExchangeRowChangeEventHandler exchangeRowDeletedEvent = this.InterCompanyExchangeRowDeletedEvent;
      if (exchangeRowDeletedEvent == null)
        return;
      exchangeRowDeletedEvent((object) this, new dsExchangeAcctBreakout.InterCompanyExchangeRowChangeEvent((dsExchangeAcctBreakout.InterCompanyExchangeRow) e.Row, e.Action));
    }

    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.InterCompanyExchangeRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsExchangeAcctBreakout.InterCompanyExchangeRowChangeEventHandler rowDeletingEvent = this.InterCompanyExchangeRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsExchangeAcctBreakout.InterCompanyExchangeRowChangeEvent((dsExchangeAcctBreakout.InterCompanyExchangeRow) e.Row, e.Action));
    }

    public void RemoveInterCompanyExchangeRow(dsExchangeAcctBreakout.InterCompanyExchangeRow row)
    {
      this.Rows.Remove((DataRow) row);
    }
  }

  [DebuggerStepThrough]
  public class InterCompanyExchangeRow : DataRow
  {
    private dsExchangeAcctBreakout.InterCompanyExchangeDataTable tableInterCompanyExchange;

    internal InterCompanyExchangeRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableInterCompanyExchange = (dsExchangeAcctBreakout.InterCompanyExchangeDataTable) this.Table;
    }

    public DateTime _Date
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tableInterCompanyExchange._DateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableInterCompanyExchange._DateColumn] = (object) value;
    }

    public int Transactnum
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tableInterCompanyExchange.TransactnumColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableInterCompanyExchange.TransactnumColumn] = (object) value;
    }

    public Decimal Amount
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tableInterCompanyExchange.AmountColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableInterCompanyExchange.AmountColumn] = (object) value;
    }

    public string ParentTransactionType
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableInterCompanyExchange.ParentTransactionTypeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableInterCompanyExchange.ParentTransactionTypeColumn] = (object) value;
    }

    public string Comments
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableInterCompanyExchange.CommentsColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableInterCompanyExchange.CommentsColumn] = (object) value;
    }

    public bool Is_DateNull() => this.IsNull(this.tableInterCompanyExchange._DateColumn);

    public void Set_DateNull()
    {
      this[this.tableInterCompanyExchange._DateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsTransactnumNull()
    {
      return this.IsNull(this.tableInterCompanyExchange.TransactnumColumn);
    }

    public void SetTransactnumNull()
    {
      this[this.tableInterCompanyExchange.TransactnumColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsAmountNull() => this.IsNull(this.tableInterCompanyExchange.AmountColumn);

    public void SetAmountNull()
    {
      this[this.tableInterCompanyExchange.AmountColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsParentTransactionTypeNull()
    {
      return this.IsNull(this.tableInterCompanyExchange.ParentTransactionTypeColumn);
    }

    public void SetParentTransactionTypeNull()
    {
      this[this.tableInterCompanyExchange.ParentTransactionTypeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsCommentsNull() => this.IsNull(this.tableInterCompanyExchange.CommentsColumn);

    public void SetCommentsNull()
    {
      this[this.tableInterCompanyExchange.CommentsColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  [DebuggerStepThrough]
  public class InterCompanyExchangeRowChangeEvent : EventArgs
  {
    private dsExchangeAcctBreakout.InterCompanyExchangeRow eventRow;
    private DataRowAction eventAction;

    public InterCompanyExchangeRowChangeEvent(
      dsExchangeAcctBreakout.InterCompanyExchangeRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    public dsExchangeAcctBreakout.InterCompanyExchangeRow Row => this.eventRow;

    public DataRowAction Action => this.eventAction;
  }
}
