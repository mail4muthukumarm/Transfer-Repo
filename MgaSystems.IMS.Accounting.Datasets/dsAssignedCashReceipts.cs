// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.AccountingDatasets.dsAssignedCashReceipts
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
public class dsAssignedCashReceipts : DataSet
{
  private dsAssignedCashReceipts.AssignedCashReceiptsDataTable tableAssignedCashReceipts;

  public dsAssignedCashReceipts()
  {
    this.InitClass();
    CollectionChangeEventHandler changeEventHandler = new CollectionChangeEventHandler(this.SchemaChanged);
    this.Tables.CollectionChanged += changeEventHandler;
    this.Relations.CollectionChanged += changeEventHandler;
  }

  protected dsAssignedCashReceipts(SerializationInfo info, StreamingContext context)
  {
    string s = Conversions.ToString(info.GetValue("XmlSchema", typeof (string)));
    if (s != null)
    {
      DataSet dataSet = new DataSet();
      dataSet.ReadXmlSchema((XmlReader) new XmlTextReader((TextReader) new StringReader(s)));
      if (dataSet.Tables[nameof (AssignedCashReceipts)] != null)
        this.Tables.Add((DataTable) new dsAssignedCashReceipts.AssignedCashReceiptsDataTable(dataSet.Tables[nameof (AssignedCashReceipts)]));
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
  public dsAssignedCashReceipts.AssignedCashReceiptsDataTable AssignedCashReceipts
  {
    get => this.tableAssignedCashReceipts;
  }

  public override DataSet Clone()
  {
    dsAssignedCashReceipts assignedCashReceipts = (dsAssignedCashReceipts) base.Clone();
    assignedCashReceipts.InitVars();
    return (DataSet) assignedCashReceipts;
  }

  protected override bool ShouldSerializeTables() => false;

  protected override bool ShouldSerializeRelations() => false;

  protected override void ReadXmlSerializable(XmlReader reader)
  {
    this.Reset();
    DataSet dataSet = new DataSet();
    int num = (int) dataSet.ReadXml(reader);
    if (dataSet.Tables["AssignedCashReceipts"] != null)
      this.Tables.Add((DataTable) new dsAssignedCashReceipts.AssignedCashReceiptsDataTable(dataSet.Tables["AssignedCashReceipts"]));
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
    this.tableAssignedCashReceipts = (dsAssignedCashReceipts.AssignedCashReceiptsDataTable) this.Tables["AssignedCashReceipts"];
    if (this.tableAssignedCashReceipts == null)
      return;
    this.tableAssignedCashReceipts.InitVars();
  }

  private void InitClass()
  {
    this.DataSetName = nameof (dsAssignedCashReceipts);
    this.Prefix = "";
    this.Namespace = "http://tempuri.org/dsAssignedCashReceipts.xsd";
    this.Locale = new CultureInfo("en-US");
    this.CaseSensitive = false;
    this.EnforceConstraints = true;
    this.tableAssignedCashReceipts = new dsAssignedCashReceipts.AssignedCashReceiptsDataTable();
    this.Tables.Add((DataTable) this.tableAssignedCashReceipts);
  }

  private bool ShouldSerializeAssignedCashReceipts() => false;

  private void SchemaChanged(object sender, CollectionChangeEventArgs e)
  {
    if (e.Action != CollectionChangeAction.Remove)
      return;
    this.InitVars();
  }

  public delegate void AssignedCashReceiptsRowChangeEventHandler(
    object sender,
    dsAssignedCashReceipts.AssignedCashReceiptsRowChangeEvent e);

  [DebuggerStepThrough]
  public class AssignedCashReceiptsDataTable : DataTable, IEnumerable
  {
    private DataColumn columntransactNum;
    private DataColumn columnpostDate;
    private DataColumn columnremitterGuid;
    private DataColumn columnRemitter;
    private DataColumn columnCheckNumber;
    private DataColumn columnAmount;

    internal AssignedCashReceiptsDataTable()
      : base("AssignedCashReceipts")
    {
      this.InitClass();
    }

    internal AssignedCashReceiptsDataTable(DataTable table)
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

    internal DataColumn remitterGuidColumn => this.columnremitterGuid;

    internal DataColumn RemitterColumn => this.columnRemitter;

    internal DataColumn CheckNumberColumn => this.columnCheckNumber;

    internal DataColumn AmountColumn => this.columnAmount;

    public dsAssignedCashReceipts.AssignedCashReceiptsRow this[int index]
    {
      get => (dsAssignedCashReceipts.AssignedCashReceiptsRow) this.Rows[index];
    }

    public event dsAssignedCashReceipts.AssignedCashReceiptsRowChangeEventHandler AssignedCashReceiptsRowChanged;

    public event dsAssignedCashReceipts.AssignedCashReceiptsRowChangeEventHandler AssignedCashReceiptsRowChanging;

    public event dsAssignedCashReceipts.AssignedCashReceiptsRowChangeEventHandler AssignedCashReceiptsRowDeleted;

    public event dsAssignedCashReceipts.AssignedCashReceiptsRowChangeEventHandler AssignedCashReceiptsRowDeleting;

    public void AddAssignedCashReceiptsRow(dsAssignedCashReceipts.AssignedCashReceiptsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    public dsAssignedCashReceipts.AssignedCashReceiptsRow AddAssignedCashReceiptsRow(
      int transactNum,
      DateTime postDate,
      string remitterGuid,
      string Remitter,
      string CheckNumber,
      Decimal Amount)
    {
      dsAssignedCashReceipts.AssignedCashReceiptsRow row = (dsAssignedCashReceipts.AssignedCashReceiptsRow) this.NewRow();
      row.ItemArray = new object[6]
      {
        (object) transactNum,
        (object) postDate,
        (object) remitterGuid,
        (object) Remitter,
        (object) CheckNumber,
        (object) Amount
      };
      this.Rows.Add((DataRow) row);
      return row;
    }

    public IEnumerator GetEnumerator() => this.Rows.GetEnumerator();

    public override DataTable Clone()
    {
      dsAssignedCashReceipts.AssignedCashReceiptsDataTable receiptsDataTable = (dsAssignedCashReceipts.AssignedCashReceiptsDataTable) base.Clone();
      receiptsDataTable.InitVars();
      return (DataTable) receiptsDataTable;
    }

    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsAssignedCashReceipts.AssignedCashReceiptsDataTable();
    }

    internal void InitVars()
    {
      this.columntransactNum = this.Columns["transactNum"];
      this.columnpostDate = this.Columns["postDate"];
      this.columnremitterGuid = this.Columns["remitterGuid"];
      this.columnRemitter = this.Columns["Remitter"];
      this.columnCheckNumber = this.Columns["CheckNumber"];
      this.columnAmount = this.Columns["Amount"];
    }

    private void InitClass()
    {
      this.columntransactNum = new DataColumn("transactNum", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columntransactNum);
      this.columnpostDate = new DataColumn("postDate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnpostDate);
      this.columnremitterGuid = new DataColumn("remitterGuid", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnremitterGuid);
      this.columnRemitter = new DataColumn("Remitter", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnRemitter);
      this.columnCheckNumber = new DataColumn("CheckNumber", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCheckNumber);
      this.columnAmount = new DataColumn("Amount", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAmount);
    }

    public dsAssignedCashReceipts.AssignedCashReceiptsRow NewAssignedCashReceiptsRow()
    {
      return (dsAssignedCashReceipts.AssignedCashReceiptsRow) this.NewRow();
    }

    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsAssignedCashReceipts.AssignedCashReceiptsRow(builder);
    }

    protected override Type GetRowType() => typeof (dsAssignedCashReceipts.AssignedCashReceiptsRow);

    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.AssignedCashReceiptsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAssignedCashReceipts.AssignedCashReceiptsRowChangeEventHandler receiptsRowChangedEvent = this.AssignedCashReceiptsRowChangedEvent;
      if (receiptsRowChangedEvent == null)
        return;
      receiptsRowChangedEvent((object) this, new dsAssignedCashReceipts.AssignedCashReceiptsRowChangeEvent((dsAssignedCashReceipts.AssignedCashReceiptsRow) e.Row, e.Action));
    }

    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.AssignedCashReceiptsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAssignedCashReceipts.AssignedCashReceiptsRowChangeEventHandler rowChangingEvent = this.AssignedCashReceiptsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsAssignedCashReceipts.AssignedCashReceiptsRowChangeEvent((dsAssignedCashReceipts.AssignedCashReceiptsRow) e.Row, e.Action));
    }

    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.AssignedCashReceiptsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAssignedCashReceipts.AssignedCashReceiptsRowChangeEventHandler receiptsRowDeletedEvent = this.AssignedCashReceiptsRowDeletedEvent;
      if (receiptsRowDeletedEvent == null)
        return;
      receiptsRowDeletedEvent((object) this, new dsAssignedCashReceipts.AssignedCashReceiptsRowChangeEvent((dsAssignedCashReceipts.AssignedCashReceiptsRow) e.Row, e.Action));
    }

    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.AssignedCashReceiptsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsAssignedCashReceipts.AssignedCashReceiptsRowChangeEventHandler rowDeletingEvent = this.AssignedCashReceiptsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsAssignedCashReceipts.AssignedCashReceiptsRowChangeEvent((dsAssignedCashReceipts.AssignedCashReceiptsRow) e.Row, e.Action));
    }

    public void RemoveAssignedCashReceiptsRow(dsAssignedCashReceipts.AssignedCashReceiptsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }
  }

  [DebuggerStepThrough]
  public class AssignedCashReceiptsRow : DataRow
  {
    private dsAssignedCashReceipts.AssignedCashReceiptsDataTable tableAssignedCashReceipts;

    internal AssignedCashReceiptsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableAssignedCashReceipts = (dsAssignedCashReceipts.AssignedCashReceiptsDataTable) this.Table;
    }

    public int transactNum
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tableAssignedCashReceipts.transactNumColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableAssignedCashReceipts.transactNumColumn] = (object) value;
    }

    public DateTime postDate
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tableAssignedCashReceipts.postDateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableAssignedCashReceipts.postDateColumn] = (object) value;
    }

    public string remitterGuid
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableAssignedCashReceipts.remitterGuidColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableAssignedCashReceipts.remitterGuidColumn] = (object) value;
    }

    public string Remitter
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableAssignedCashReceipts.RemitterColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableAssignedCashReceipts.RemitterColumn] = (object) value;
    }

    public string CheckNumber
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableAssignedCashReceipts.CheckNumberColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableAssignedCashReceipts.CheckNumberColumn] = (object) value;
    }

    public Decimal Amount
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tableAssignedCashReceipts.AmountColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableAssignedCashReceipts.AmountColumn] = (object) value;
    }

    public bool IstransactNumNull()
    {
      return this.IsNull(this.tableAssignedCashReceipts.transactNumColumn);
    }

    public void SettransactNumNull()
    {
      this[this.tableAssignedCashReceipts.transactNumColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IspostDateNull() => this.IsNull(this.tableAssignedCashReceipts.postDateColumn);

    public void SetpostDateNull()
    {
      this[this.tableAssignedCashReceipts.postDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsremitterGuidNull()
    {
      return this.IsNull(this.tableAssignedCashReceipts.remitterGuidColumn);
    }

    public void SetremitterGuidNull()
    {
      this[this.tableAssignedCashReceipts.remitterGuidColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsRemitterNull() => this.IsNull(this.tableAssignedCashReceipts.RemitterColumn);

    public void SetRemitterNull()
    {
      this[this.tableAssignedCashReceipts.RemitterColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsCheckNumberNull()
    {
      return this.IsNull(this.tableAssignedCashReceipts.CheckNumberColumn);
    }

    public void SetCheckNumberNull()
    {
      this[this.tableAssignedCashReceipts.CheckNumberColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsAmountNull() => this.IsNull(this.tableAssignedCashReceipts.AmountColumn);

    public void SetAmountNull()
    {
      this[this.tableAssignedCashReceipts.AmountColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  [DebuggerStepThrough]
  public class AssignedCashReceiptsRowChangeEvent : EventArgs
  {
    private dsAssignedCashReceipts.AssignedCashReceiptsRow eventRow;
    private DataRowAction eventAction;

    public AssignedCashReceiptsRowChangeEvent(
      dsAssignedCashReceipts.AssignedCashReceiptsRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    public dsAssignedCashReceipts.AssignedCashReceiptsRow Row => this.eventRow;

    public DataRowAction Action => this.eventAction;
  }
}
