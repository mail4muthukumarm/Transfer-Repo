// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.AccountingDatasets.dsGLAccount_RecentTransactions
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
public class dsGLAccount_RecentTransactions : DataSet
{
  private dsGLAccount_RecentTransactions.TransactionListDataTable tableTransactionList;

  public dsGLAccount_RecentTransactions()
  {
    this.InitClass();
    CollectionChangeEventHandler changeEventHandler = new CollectionChangeEventHandler(this.SchemaChanged);
    this.Tables.CollectionChanged += changeEventHandler;
    this.Relations.CollectionChanged += changeEventHandler;
  }

  protected dsGLAccount_RecentTransactions(SerializationInfo info, StreamingContext context)
  {
    string s = Conversions.ToString(info.GetValue("XmlSchema", typeof (string)));
    if (s != null)
    {
      DataSet dataSet = new DataSet();
      dataSet.ReadXmlSchema((XmlReader) new XmlTextReader((TextReader) new StringReader(s)));
      if (dataSet.Tables[nameof (TransactionList)] != null)
        this.Tables.Add((DataTable) new dsGLAccount_RecentTransactions.TransactionListDataTable(dataSet.Tables[nameof (TransactionList)]));
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
  public dsGLAccount_RecentTransactions.TransactionListDataTable TransactionList
  {
    get => this.tableTransactionList;
  }

  public override DataSet Clone()
  {
    dsGLAccount_RecentTransactions recentTransactions = (dsGLAccount_RecentTransactions) base.Clone();
    recentTransactions.InitVars();
    return (DataSet) recentTransactions;
  }

  protected override bool ShouldSerializeTables() => false;

  protected override bool ShouldSerializeRelations() => false;

  protected override void ReadXmlSerializable(XmlReader reader)
  {
    this.Reset();
    DataSet dataSet = new DataSet();
    int num = (int) dataSet.ReadXml(reader);
    if (dataSet.Tables["TransactionList"] != null)
      this.Tables.Add((DataTable) new dsGLAccount_RecentTransactions.TransactionListDataTable(dataSet.Tables["TransactionList"]));
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
    this.tableTransactionList = (dsGLAccount_RecentTransactions.TransactionListDataTable) this.Tables["TransactionList"];
    if (this.tableTransactionList == null)
      return;
    this.tableTransactionList.InitVars();
  }

  private void InitClass()
  {
    this.DataSetName = nameof (dsGLAccount_RecentTransactions);
    this.Prefix = "";
    this.Namespace = "http://tempuri.org/dsGLAccount_RecentTransactions.xsd";
    this.Locale = new CultureInfo("en-US");
    this.CaseSensitive = false;
    this.EnforceConstraints = true;
    this.tableTransactionList = new dsGLAccount_RecentTransactions.TransactionListDataTable();
    this.Tables.Add((DataTable) this.tableTransactionList);
  }

  private bool ShouldSerializeTransactionList() => false;

  private void SchemaChanged(object sender, CollectionChangeEventArgs e)
  {
    if (e.Action != CollectionChangeAction.Remove)
      return;
    this.InitVars();
  }

  public delegate void TransactionListRowChangeEventHandler(
    object sender,
    dsGLAccount_RecentTransactions.TransactionListRowChangeEvent e);

  [DebuggerStepThrough]
  public class TransactionListDataTable : DataTable, IEnumerable
  {
    private DataColumn columnTransactNum;
    private DataColumn columnPostDate;
    private DataColumn columnTransDescription;
    private DataColumn columnVoided;

    internal TransactionListDataTable()
      : base("TransactionList")
    {
      this.InitClass();
    }

    internal TransactionListDataTable(DataTable table)
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

    internal DataColumn TransactNumColumn => this.columnTransactNum;

    internal DataColumn PostDateColumn => this.columnPostDate;

    internal DataColumn TransDescriptionColumn => this.columnTransDescription;

    internal DataColumn VoidedColumn => this.columnVoided;

    public dsGLAccount_RecentTransactions.TransactionListRow this[int index]
    {
      get => (dsGLAccount_RecentTransactions.TransactionListRow) this.Rows[index];
    }

    public event dsGLAccount_RecentTransactions.TransactionListRowChangeEventHandler TransactionListRowChanged;

    public event dsGLAccount_RecentTransactions.TransactionListRowChangeEventHandler TransactionListRowChanging;

    public event dsGLAccount_RecentTransactions.TransactionListRowChangeEventHandler TransactionListRowDeleted;

    public event dsGLAccount_RecentTransactions.TransactionListRowChangeEventHandler TransactionListRowDeleting;

    public void AddTransactionListRow(
      dsGLAccount_RecentTransactions.TransactionListRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    public dsGLAccount_RecentTransactions.TransactionListRow AddTransactionListRow(
      int TransactNum,
      DateTime PostDate,
      string TransDescription,
      bool Voided)
    {
      dsGLAccount_RecentTransactions.TransactionListRow row = (dsGLAccount_RecentTransactions.TransactionListRow) this.NewRow();
      row.ItemArray = new object[4]
      {
        (object) TransactNum,
        (object) PostDate,
        (object) TransDescription,
        (object) Voided
      };
      this.Rows.Add((DataRow) row);
      return row;
    }

    public IEnumerator GetEnumerator() => this.Rows.GetEnumerator();

    public override DataTable Clone()
    {
      dsGLAccount_RecentTransactions.TransactionListDataTable transactionListDataTable = (dsGLAccount_RecentTransactions.TransactionListDataTable) base.Clone();
      transactionListDataTable.InitVars();
      return (DataTable) transactionListDataTable;
    }

    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsGLAccount_RecentTransactions.TransactionListDataTable();
    }

    internal void InitVars()
    {
      this.columnTransactNum = this.Columns["TransactNum"];
      this.columnPostDate = this.Columns["PostDate"];
      this.columnTransDescription = this.Columns["TransDescription"];
      this.columnVoided = this.Columns["Voided"];
    }

    private void InitClass()
    {
      this.columnTransactNum = new DataColumn("TransactNum", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnTransactNum);
      this.columnPostDate = new DataColumn("PostDate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPostDate);
      this.columnTransDescription = new DataColumn("TransDescription", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnTransDescription);
      this.columnVoided = new DataColumn("Voided", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnVoided);
    }

    public dsGLAccount_RecentTransactions.TransactionListRow NewTransactionListRow()
    {
      return (dsGLAccount_RecentTransactions.TransactionListRow) this.NewRow();
    }

    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsGLAccount_RecentTransactions.TransactionListRow(builder);
    }

    protected override Type GetRowType()
    {
      return typeof (dsGLAccount_RecentTransactions.TransactionListRow);
    }

    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.TransactionListRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsGLAccount_RecentTransactions.TransactionListRowChangeEventHandler listRowChangedEvent = this.TransactionListRowChangedEvent;
      if (listRowChangedEvent == null)
        return;
      listRowChangedEvent((object) this, new dsGLAccount_RecentTransactions.TransactionListRowChangeEvent((dsGLAccount_RecentTransactions.TransactionListRow) e.Row, e.Action));
    }

    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.TransactionListRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsGLAccount_RecentTransactions.TransactionListRowChangeEventHandler rowChangingEvent = this.TransactionListRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsGLAccount_RecentTransactions.TransactionListRowChangeEvent((dsGLAccount_RecentTransactions.TransactionListRow) e.Row, e.Action));
    }

    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.TransactionListRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsGLAccount_RecentTransactions.TransactionListRowChangeEventHandler listRowDeletedEvent = this.TransactionListRowDeletedEvent;
      if (listRowDeletedEvent == null)
        return;
      listRowDeletedEvent((object) this, new dsGLAccount_RecentTransactions.TransactionListRowChangeEvent((dsGLAccount_RecentTransactions.TransactionListRow) e.Row, e.Action));
    }

    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.TransactionListRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsGLAccount_RecentTransactions.TransactionListRowChangeEventHandler rowDeletingEvent = this.TransactionListRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsGLAccount_RecentTransactions.TransactionListRowChangeEvent((dsGLAccount_RecentTransactions.TransactionListRow) e.Row, e.Action));
    }

    public void RemoveTransactionListRow(
      dsGLAccount_RecentTransactions.TransactionListRow row)
    {
      this.Rows.Remove((DataRow) row);
    }
  }

  [DebuggerStepThrough]
  public class TransactionListRow : DataRow
  {
    private dsGLAccount_RecentTransactions.TransactionListDataTable tableTransactionList;

    internal TransactionListRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableTransactionList = (dsGLAccount_RecentTransactions.TransactionListDataTable) this.Table;
    }

    public int TransactNum
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tableTransactionList.TransactNumColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableTransactionList.TransactNumColumn] = (object) value;
    }

    public DateTime PostDate
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tableTransactionList.PostDateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableTransactionList.PostDateColumn] = (object) value;
    }

    public string TransDescription
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableTransactionList.TransDescriptionColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableTransactionList.TransDescriptionColumn] = (object) value;
    }

    public bool Voided
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tableTransactionList.VoidedColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableTransactionList.VoidedColumn] = (object) value;
    }

    public bool IsTransactNumNull() => this.IsNull(this.tableTransactionList.TransactNumColumn);

    public void SetTransactNumNull()
    {
      this[this.tableTransactionList.TransactNumColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsPostDateNull() => this.IsNull(this.tableTransactionList.PostDateColumn);

    public void SetPostDateNull()
    {
      this[this.tableTransactionList.PostDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsTransDescriptionNull()
    {
      return this.IsNull(this.tableTransactionList.TransDescriptionColumn);
    }

    public void SetTransDescriptionNull()
    {
      this[this.tableTransactionList.TransDescriptionColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsVoidedNull() => this.IsNull(this.tableTransactionList.VoidedColumn);

    public void SetVoidedNull()
    {
      this[this.tableTransactionList.VoidedColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  [DebuggerStepThrough]
  public class TransactionListRowChangeEvent : EventArgs
  {
    private dsGLAccount_RecentTransactions.TransactionListRow eventRow;
    private DataRowAction eventAction;

    public TransactionListRowChangeEvent(
      dsGLAccount_RecentTransactions.TransactionListRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    public dsGLAccount_RecentTransactions.TransactionListRow Row => this.eventRow;

    public DataRowAction Action => this.eventAction;
  }
}
