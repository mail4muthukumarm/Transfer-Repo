// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.AccountingDatasets.dsOpenExpenseDetails
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
public class dsOpenExpenseDetails : DataSet
{
  private dsOpenExpenseDetails.OpenExpenseDetailDataTable tableOpenExpenseDetail;

  public dsOpenExpenseDetails()
  {
    this.InitClass();
    CollectionChangeEventHandler changeEventHandler = new CollectionChangeEventHandler(this.SchemaChanged);
    this.Tables.CollectionChanged += changeEventHandler;
    this.Relations.CollectionChanged += changeEventHandler;
  }

  protected dsOpenExpenseDetails(SerializationInfo info, StreamingContext context)
  {
    string s = Conversions.ToString(info.GetValue("XmlSchema", typeof (string)));
    if (s != null)
    {
      DataSet dataSet = new DataSet();
      dataSet.ReadXmlSchema((XmlReader) new XmlTextReader((TextReader) new StringReader(s)));
      if (dataSet.Tables[nameof (OpenExpenseDetail)] != null)
        this.Tables.Add((DataTable) new dsOpenExpenseDetails.OpenExpenseDetailDataTable(dataSet.Tables[nameof (OpenExpenseDetail)]));
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
  public dsOpenExpenseDetails.OpenExpenseDetailDataTable OpenExpenseDetail
  {
    get => this.tableOpenExpenseDetail;
  }

  public override DataSet Clone()
  {
    dsOpenExpenseDetails openExpenseDetails = (dsOpenExpenseDetails) base.Clone();
    openExpenseDetails.InitVars();
    return (DataSet) openExpenseDetails;
  }

  protected override bool ShouldSerializeTables() => false;

  protected override bool ShouldSerializeRelations() => false;

  protected override void ReadXmlSerializable(XmlReader reader)
  {
    this.Reset();
    DataSet dataSet = new DataSet();
    int num = (int) dataSet.ReadXml(reader);
    if (dataSet.Tables["OpenExpenseDetail"] != null)
      this.Tables.Add((DataTable) new dsOpenExpenseDetails.OpenExpenseDetailDataTable(dataSet.Tables["OpenExpenseDetail"]));
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
    this.tableOpenExpenseDetail = (dsOpenExpenseDetails.OpenExpenseDetailDataTable) this.Tables["OpenExpenseDetail"];
    if (this.tableOpenExpenseDetail == null)
      return;
    this.tableOpenExpenseDetail.InitVars();
  }

  private void InitClass()
  {
    this.DataSetName = nameof (dsOpenExpenseDetails);
    this.Prefix = "";
    this.Namespace = "http://tempuri.org/dsOpenExpenseDetails.xsd";
    this.Locale = new CultureInfo("en-US");
    this.CaseSensitive = false;
    this.EnforceConstraints = true;
    this.tableOpenExpenseDetail = new dsOpenExpenseDetails.OpenExpenseDetailDataTable();
    this.Tables.Add((DataTable) this.tableOpenExpenseDetail);
  }

  private bool ShouldSerializeOpenExpenseDetail() => false;

  private void SchemaChanged(object sender, CollectionChangeEventArgs e)
  {
    if (e.Action != CollectionChangeAction.Remove)
      return;
    this.InitVars();
  }

  public delegate void OpenExpenseDetailRowChangeEventHandler(
    object sender,
    dsOpenExpenseDetails.OpenExpenseDetailRowChangeEvent e);

  [DebuggerStepThrough]
  public class OpenExpenseDetailDataTable : DataTable, IEnumerable
  {
    private DataColumn columnExpenseCode;
    private DataColumn columnGlAcctId;
    private DataColumn columnExpenseName;
    private DataColumn columnBalance;
    private DataColumn columnPayAmt;
    private DataColumn columnCostCenterId;

    internal OpenExpenseDetailDataTable()
      : base("OpenExpenseDetail")
    {
      this.InitClass();
    }

    internal OpenExpenseDetailDataTable(DataTable table)
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

    internal DataColumn GlAcctIdColumn => this.columnGlAcctId;

    internal DataColumn ExpenseNameColumn => this.columnExpenseName;

    internal DataColumn BalanceColumn => this.columnBalance;

    internal DataColumn PayAmtColumn => this.columnPayAmt;

    internal DataColumn CostCenterIdColumn => this.columnCostCenterId;

    public dsOpenExpenseDetails.OpenExpenseDetailRow this[int index]
    {
      get => (dsOpenExpenseDetails.OpenExpenseDetailRow) this.Rows[index];
    }

    public event dsOpenExpenseDetails.OpenExpenseDetailRowChangeEventHandler OpenExpenseDetailRowChanged;

    public event dsOpenExpenseDetails.OpenExpenseDetailRowChangeEventHandler OpenExpenseDetailRowChanging;

    public event dsOpenExpenseDetails.OpenExpenseDetailRowChangeEventHandler OpenExpenseDetailRowDeleted;

    public event dsOpenExpenseDetails.OpenExpenseDetailRowChangeEventHandler OpenExpenseDetailRowDeleting;

    public void AddOpenExpenseDetailRow(dsOpenExpenseDetails.OpenExpenseDetailRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    public dsOpenExpenseDetails.OpenExpenseDetailRow AddOpenExpenseDetailRow(
      int ExpenseCode,
      int GlAcctId,
      string ExpenseName,
      Decimal Balance,
      Decimal PayAmt,
      int CostCenterId)
    {
      dsOpenExpenseDetails.OpenExpenseDetailRow row = (dsOpenExpenseDetails.OpenExpenseDetailRow) this.NewRow();
      row.ItemArray = new object[6]
      {
        (object) ExpenseCode,
        (object) GlAcctId,
        (object) ExpenseName,
        (object) Balance,
        (object) PayAmt,
        (object) CostCenterId
      };
      this.Rows.Add((DataRow) row);
      return row;
    }

    public IEnumerator GetEnumerator() => this.Rows.GetEnumerator();

    public override DataTable Clone()
    {
      dsOpenExpenseDetails.OpenExpenseDetailDataTable expenseDetailDataTable = (dsOpenExpenseDetails.OpenExpenseDetailDataTable) base.Clone();
      expenseDetailDataTable.InitVars();
      return (DataTable) expenseDetailDataTable;
    }

    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsOpenExpenseDetails.OpenExpenseDetailDataTable();
    }

    internal void InitVars()
    {
      this.columnExpenseCode = this.Columns["ExpenseCode"];
      this.columnGlAcctId = this.Columns["GlAcctId"];
      this.columnExpenseName = this.Columns["ExpenseName"];
      this.columnBalance = this.Columns["Balance"];
      this.columnPayAmt = this.Columns["PayAmt"];
      this.columnCostCenterId = this.Columns["CostCenterId"];
    }

    private void InitClass()
    {
      this.columnExpenseCode = new DataColumn("ExpenseCode", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnExpenseCode);
      this.columnGlAcctId = new DataColumn("GlAcctId", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnGlAcctId);
      this.columnExpenseName = new DataColumn("ExpenseName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnExpenseName);
      this.columnBalance = new DataColumn("Balance", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnBalance);
      this.columnPayAmt = new DataColumn("PayAmt", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPayAmt);
      this.columnCostCenterId = new DataColumn("CostCenterId", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCostCenterId);
    }

    public dsOpenExpenseDetails.OpenExpenseDetailRow NewOpenExpenseDetailRow()
    {
      return (dsOpenExpenseDetails.OpenExpenseDetailRow) this.NewRow();
    }

    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsOpenExpenseDetails.OpenExpenseDetailRow(builder);
    }

    protected override Type GetRowType() => typeof (dsOpenExpenseDetails.OpenExpenseDetailRow);

    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.OpenExpenseDetailRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsOpenExpenseDetails.OpenExpenseDetailRowChangeEventHandler detailRowChangedEvent = this.OpenExpenseDetailRowChangedEvent;
      if (detailRowChangedEvent == null)
        return;
      detailRowChangedEvent((object) this, new dsOpenExpenseDetails.OpenExpenseDetailRowChangeEvent((dsOpenExpenseDetails.OpenExpenseDetailRow) e.Row, e.Action));
    }

    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.OpenExpenseDetailRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsOpenExpenseDetails.OpenExpenseDetailRowChangeEventHandler rowChangingEvent = this.OpenExpenseDetailRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsOpenExpenseDetails.OpenExpenseDetailRowChangeEvent((dsOpenExpenseDetails.OpenExpenseDetailRow) e.Row, e.Action));
    }

    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.OpenExpenseDetailRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsOpenExpenseDetails.OpenExpenseDetailRowChangeEventHandler detailRowDeletedEvent = this.OpenExpenseDetailRowDeletedEvent;
      if (detailRowDeletedEvent == null)
        return;
      detailRowDeletedEvent((object) this, new dsOpenExpenseDetails.OpenExpenseDetailRowChangeEvent((dsOpenExpenseDetails.OpenExpenseDetailRow) e.Row, e.Action));
    }

    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.OpenExpenseDetailRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsOpenExpenseDetails.OpenExpenseDetailRowChangeEventHandler rowDeletingEvent = this.OpenExpenseDetailRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsOpenExpenseDetails.OpenExpenseDetailRowChangeEvent((dsOpenExpenseDetails.OpenExpenseDetailRow) e.Row, e.Action));
    }

    public void RemoveOpenExpenseDetailRow(dsOpenExpenseDetails.OpenExpenseDetailRow row)
    {
      this.Rows.Remove((DataRow) row);
    }
  }

  [DebuggerStepThrough]
  public class OpenExpenseDetailRow : DataRow
  {
    private dsOpenExpenseDetails.OpenExpenseDetailDataTable tableOpenExpenseDetail;

    internal OpenExpenseDetailRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableOpenExpenseDetail = (dsOpenExpenseDetails.OpenExpenseDetailDataTable) this.Table;
    }

    public int ExpenseCode
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tableOpenExpenseDetail.ExpenseCodeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableOpenExpenseDetail.ExpenseCodeColumn] = (object) value;
    }

    public int GlAcctId
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tableOpenExpenseDetail.GlAcctIdColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableOpenExpenseDetail.GlAcctIdColumn] = (object) value;
    }

    public string ExpenseName
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableOpenExpenseDetail.ExpenseNameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableOpenExpenseDetail.ExpenseNameColumn] = (object) value;
    }

    public Decimal Balance
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tableOpenExpenseDetail.BalanceColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableOpenExpenseDetail.BalanceColumn] = (object) value;
    }

    public Decimal PayAmt
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tableOpenExpenseDetail.PayAmtColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableOpenExpenseDetail.PayAmtColumn] = (object) value;
    }

    public int CostCenterId
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tableOpenExpenseDetail.CostCenterIdColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableOpenExpenseDetail.CostCenterIdColumn] = (object) value;
    }

    public bool IsExpenseCodeNull() => this.IsNull(this.tableOpenExpenseDetail.ExpenseCodeColumn);

    public void SetExpenseCodeNull()
    {
      this[this.tableOpenExpenseDetail.ExpenseCodeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsGlAcctIdNull() => this.IsNull(this.tableOpenExpenseDetail.GlAcctIdColumn);

    public void SetGlAcctIdNull()
    {
      this[this.tableOpenExpenseDetail.GlAcctIdColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsExpenseNameNull() => this.IsNull(this.tableOpenExpenseDetail.ExpenseNameColumn);

    public void SetExpenseNameNull()
    {
      this[this.tableOpenExpenseDetail.ExpenseNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsBalanceNull() => this.IsNull(this.tableOpenExpenseDetail.BalanceColumn);

    public void SetBalanceNull()
    {
      this[this.tableOpenExpenseDetail.BalanceColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsPayAmtNull() => this.IsNull(this.tableOpenExpenseDetail.PayAmtColumn);

    public void SetPayAmtNull()
    {
      this[this.tableOpenExpenseDetail.PayAmtColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsCostCenterIdNull() => this.IsNull(this.tableOpenExpenseDetail.CostCenterIdColumn);

    public void SetCostCenterIdNull()
    {
      this[this.tableOpenExpenseDetail.CostCenterIdColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  [DebuggerStepThrough]
  public class OpenExpenseDetailRowChangeEvent : EventArgs
  {
    private dsOpenExpenseDetails.OpenExpenseDetailRow eventRow;
    private DataRowAction eventAction;

    public OpenExpenseDetailRowChangeEvent(
      dsOpenExpenseDetails.OpenExpenseDetailRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    public dsOpenExpenseDetails.OpenExpenseDetailRow Row => this.eventRow;

    public DataRowAction Action => this.eventAction;
  }
}
