// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.AccountingDatasets.dsGetBankDepositDetail
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
public class dsGetBankDepositDetail : DataSet
{
  private dsGetBankDepositDetail.CashReceiptsDataTable tableCashReceipts;

  public dsGetBankDepositDetail()
  {
    this.InitClass();
    CollectionChangeEventHandler changeEventHandler = new CollectionChangeEventHandler(this.SchemaChanged);
    this.Tables.CollectionChanged += changeEventHandler;
    this.Relations.CollectionChanged += changeEventHandler;
  }

  protected dsGetBankDepositDetail(SerializationInfo info, StreamingContext context)
  {
    string s = Conversions.ToString(info.GetValue("XmlSchema", typeof (string)));
    if (s != null)
    {
      DataSet dataSet = new DataSet();
      dataSet.ReadXmlSchema((XmlReader) new XmlTextReader((TextReader) new StringReader(s)));
      if (dataSet.Tables[nameof (CashReceipts)] != null)
        this.Tables.Add((DataTable) new dsGetBankDepositDetail.CashReceiptsDataTable(dataSet.Tables[nameof (CashReceipts)]));
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
  public dsGetBankDepositDetail.CashReceiptsDataTable CashReceipts => this.tableCashReceipts;

  public override DataSet Clone()
  {
    dsGetBankDepositDetail bankDepositDetail = (dsGetBankDepositDetail) base.Clone();
    bankDepositDetail.InitVars();
    return (DataSet) bankDepositDetail;
  }

  protected override bool ShouldSerializeTables() => false;

  protected override bool ShouldSerializeRelations() => false;

  protected override void ReadXmlSerializable(XmlReader reader)
  {
    this.Reset();
    DataSet dataSet = new DataSet();
    int num = (int) dataSet.ReadXml(reader);
    if (dataSet.Tables["CashReceipts"] != null)
      this.Tables.Add((DataTable) new dsGetBankDepositDetail.CashReceiptsDataTable(dataSet.Tables["CashReceipts"]));
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
    this.tableCashReceipts = (dsGetBankDepositDetail.CashReceiptsDataTable) this.Tables["CashReceipts"];
    if (this.tableCashReceipts == null)
      return;
    this.tableCashReceipts.InitVars();
  }

  private void InitClass()
  {
    this.DataSetName = nameof (dsGetBankDepositDetail);
    this.Prefix = "";
    this.Namespace = "http://www.tempuri.org/dsGetBankDepositDetail.xsd";
    this.Locale = new CultureInfo("en-US");
    this.CaseSensitive = false;
    this.EnforceConstraints = true;
    this.tableCashReceipts = new dsGetBankDepositDetail.CashReceiptsDataTable();
    this.Tables.Add((DataTable) this.tableCashReceipts);
  }

  private bool ShouldSerializeCashReceipts() => false;

  private void SchemaChanged(object sender, CollectionChangeEventArgs e)
  {
    if (e.Action != CollectionChangeAction.Remove)
      return;
    this.InitVars();
  }

  public delegate void CashReceiptsRowChangeEventHandler(
    object sender,
    dsGetBankDepositDetail.CashReceiptsRowChangeEvent e);

  [DebuggerStepThrough]
  public class CashReceiptsDataTable : DataTable, IEnumerable
  {
    private DataColumn columntransactnum;
    private DataColumn columnpostDate;
    private DataColumn columncheckNumber;
    private DataColumn columnRemitter;
    private DataColumn columnAmount;

    internal CashReceiptsDataTable()
      : base("CashReceipts")
    {
      this.InitClass();
    }

    internal CashReceiptsDataTable(DataTable table)
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

    internal DataColumn transactnumColumn => this.columntransactnum;

    internal DataColumn postDateColumn => this.columnpostDate;

    internal DataColumn checkNumberColumn => this.columncheckNumber;

    internal DataColumn RemitterColumn => this.columnRemitter;

    internal DataColumn AmountColumn => this.columnAmount;

    public dsGetBankDepositDetail.CashReceiptsRow this[int index]
    {
      get => (dsGetBankDepositDetail.CashReceiptsRow) this.Rows[index];
    }

    public event dsGetBankDepositDetail.CashReceiptsRowChangeEventHandler CashReceiptsRowChanged;

    public event dsGetBankDepositDetail.CashReceiptsRowChangeEventHandler CashReceiptsRowChanging;

    public event dsGetBankDepositDetail.CashReceiptsRowChangeEventHandler CashReceiptsRowDeleted;

    public event dsGetBankDepositDetail.CashReceiptsRowChangeEventHandler CashReceiptsRowDeleting;

    public void AddCashReceiptsRow(dsGetBankDepositDetail.CashReceiptsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    public dsGetBankDepositDetail.CashReceiptsRow AddCashReceiptsRow(
      int transactnum,
      DateTime postDate,
      string checkNumber,
      string Remitter,
      Decimal Amount)
    {
      dsGetBankDepositDetail.CashReceiptsRow row = (dsGetBankDepositDetail.CashReceiptsRow) this.NewRow();
      row.ItemArray = new object[5]
      {
        (object) transactnum,
        (object) postDate,
        (object) checkNumber,
        (object) Remitter,
        (object) Amount
      };
      this.Rows.Add((DataRow) row);
      return row;
    }

    public IEnumerator GetEnumerator() => this.Rows.GetEnumerator();

    public override DataTable Clone()
    {
      dsGetBankDepositDetail.CashReceiptsDataTable receiptsDataTable = (dsGetBankDepositDetail.CashReceiptsDataTable) base.Clone();
      receiptsDataTable.InitVars();
      return (DataTable) receiptsDataTable;
    }

    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsGetBankDepositDetail.CashReceiptsDataTable();
    }

    internal void InitVars()
    {
      this.columntransactnum = this.Columns["transactnum"];
      this.columnpostDate = this.Columns["postDate"];
      this.columncheckNumber = this.Columns["checkNumber"];
      this.columnRemitter = this.Columns["Remitter"];
      this.columnAmount = this.Columns["Amount"];
    }

    private void InitClass()
    {
      this.columntransactnum = new DataColumn("transactnum", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columntransactnum);
      this.columnpostDate = new DataColumn("postDate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnpostDate);
      this.columncheckNumber = new DataColumn("checkNumber", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columncheckNumber);
      this.columnRemitter = new DataColumn("Remitter", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnRemitter);
      this.columnAmount = new DataColumn("Amount", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAmount);
      this.columntransactnum.AllowDBNull = false;
      this.columnpostDate.AllowDBNull = false;
      this.columncheckNumber.AllowDBNull = false;
      this.columnRemitter.ReadOnly = true;
      this.columnAmount.ReadOnly = true;
    }

    public dsGetBankDepositDetail.CashReceiptsRow NewCashReceiptsRow()
    {
      return (dsGetBankDepositDetail.CashReceiptsRow) this.NewRow();
    }

    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsGetBankDepositDetail.CashReceiptsRow(builder);
    }

    protected override Type GetRowType() => typeof (dsGetBankDepositDetail.CashReceiptsRow);

    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.CashReceiptsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsGetBankDepositDetail.CashReceiptsRowChangeEventHandler receiptsRowChangedEvent = this.CashReceiptsRowChangedEvent;
      if (receiptsRowChangedEvent == null)
        return;
      receiptsRowChangedEvent((object) this, new dsGetBankDepositDetail.CashReceiptsRowChangeEvent((dsGetBankDepositDetail.CashReceiptsRow) e.Row, e.Action));
    }

    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.CashReceiptsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsGetBankDepositDetail.CashReceiptsRowChangeEventHandler rowChangingEvent = this.CashReceiptsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsGetBankDepositDetail.CashReceiptsRowChangeEvent((dsGetBankDepositDetail.CashReceiptsRow) e.Row, e.Action));
    }

    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.CashReceiptsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsGetBankDepositDetail.CashReceiptsRowChangeEventHandler receiptsRowDeletedEvent = this.CashReceiptsRowDeletedEvent;
      if (receiptsRowDeletedEvent == null)
        return;
      receiptsRowDeletedEvent((object) this, new dsGetBankDepositDetail.CashReceiptsRowChangeEvent((dsGetBankDepositDetail.CashReceiptsRow) e.Row, e.Action));
    }

    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.CashReceiptsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsGetBankDepositDetail.CashReceiptsRowChangeEventHandler rowDeletingEvent = this.CashReceiptsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsGetBankDepositDetail.CashReceiptsRowChangeEvent((dsGetBankDepositDetail.CashReceiptsRow) e.Row, e.Action));
    }

    public void RemoveCashReceiptsRow(dsGetBankDepositDetail.CashReceiptsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }
  }

  [DebuggerStepThrough]
  public class CashReceiptsRow : DataRow
  {
    private dsGetBankDepositDetail.CashReceiptsDataTable tableCashReceipts;

    internal CashReceiptsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableCashReceipts = (dsGetBankDepositDetail.CashReceiptsDataTable) this.Table;
    }

    public int transactnum
    {
      get => Conversions.ToInteger(this[this.tableCashReceipts.transactnumColumn]);
      set => this[this.tableCashReceipts.transactnumColumn] = (object) value;
    }

    public DateTime postDate
    {
      get => Conversions.ToDate(this[this.tableCashReceipts.postDateColumn]);
      set => this[this.tableCashReceipts.postDateColumn] = (object) value;
    }

    public string checkNumber
    {
      get => Conversions.ToString(this[this.tableCashReceipts.checkNumberColumn]);
      set => this[this.tableCashReceipts.checkNumberColumn] = (object) value;
    }

    public string Remitter
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableCashReceipts.RemitterColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableCashReceipts.RemitterColumn] = (object) value;
    }

    public Decimal Amount
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tableCashReceipts.AmountColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableCashReceipts.AmountColumn] = (object) value;
    }

    public bool IsRemitterNull() => this.IsNull(this.tableCashReceipts.RemitterColumn);

    public void SetRemitterNull()
    {
      this[this.tableCashReceipts.RemitterColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsAmountNull() => this.IsNull(this.tableCashReceipts.AmountColumn);

    public void SetAmountNull()
    {
      this[this.tableCashReceipts.AmountColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  [DebuggerStepThrough]
  public class CashReceiptsRowChangeEvent : EventArgs
  {
    private dsGetBankDepositDetail.CashReceiptsRow eventRow;
    private DataRowAction eventAction;

    public CashReceiptsRowChangeEvent(
      dsGetBankDepositDetail.CashReceiptsRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    public dsGetBankDepositDetail.CashReceiptsRow Row => this.eventRow;

    public DataRowAction Action => this.eventAction;
  }
}
