// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.AccountingDatasets.dsCashFlow
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
public class dsCashFlow : DataSet
{
  private dsCashFlow.CashFlowDataTable tableCashFlow;

  public dsCashFlow()
  {
    this.InitClass();
    CollectionChangeEventHandler changeEventHandler = new CollectionChangeEventHandler(this.SchemaChanged);
    this.Tables.CollectionChanged += changeEventHandler;
    this.Relations.CollectionChanged += changeEventHandler;
  }

  protected dsCashFlow(SerializationInfo info, StreamingContext context)
  {
    string s = Conversions.ToString(info.GetValue("XmlSchema", typeof (string)));
    if (s != null)
    {
      DataSet dataSet = new DataSet();
      dataSet.ReadXmlSchema((XmlReader) new XmlTextReader((TextReader) new StringReader(s)));
      if (dataSet.Tables[nameof (CashFlow)] != null)
        this.Tables.Add((DataTable) new dsCashFlow.CashFlowDataTable(dataSet.Tables[nameof (CashFlow)]));
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
  public dsCashFlow.CashFlowDataTable CashFlow => this.tableCashFlow;

  public override DataSet Clone()
  {
    dsCashFlow dsCashFlow = (dsCashFlow) base.Clone();
    dsCashFlow.InitVars();
    return (DataSet) dsCashFlow;
  }

  protected override bool ShouldSerializeTables() => false;

  protected override bool ShouldSerializeRelations() => false;

  protected override void ReadXmlSerializable(XmlReader reader)
  {
    this.Reset();
    DataSet dataSet = new DataSet();
    int num = (int) dataSet.ReadXml(reader);
    if (dataSet.Tables["CashFlow"] != null)
      this.Tables.Add((DataTable) new dsCashFlow.CashFlowDataTable(dataSet.Tables["CashFlow"]));
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
    this.tableCashFlow = (dsCashFlow.CashFlowDataTable) this.Tables["CashFlow"];
    if (this.tableCashFlow == null)
      return;
    this.tableCashFlow.InitVars();
  }

  private void InitClass()
  {
    this.DataSetName = nameof (dsCashFlow);
    this.Prefix = "";
    this.Namespace = "http://tempuri.org/dsCashFlow.xsd";
    this.Locale = new CultureInfo("en-US");
    this.CaseSensitive = false;
    this.EnforceConstraints = true;
    this.tableCashFlow = new dsCashFlow.CashFlowDataTable();
    this.Tables.Add((DataTable) this.tableCashFlow);
  }

  private bool ShouldSerializeCashFlow() => false;

  private void SchemaChanged(object sender, CollectionChangeEventArgs e)
  {
    if (e.Action != CollectionChangeAction.Remove)
      return;
    this.InitVars();
  }

  public delegate void CashFlowRowChangeEventHandler(
    object sender,
    dsCashFlow.CashFlowRowChangeEvent e);

  [DebuggerStepThrough]
  public class CashFlowDataTable : DataTable, IEnumerable
  {
    private DataColumn columnpostDate;
    private DataColumn columnamount;

    internal CashFlowDataTable()
      : base("CashFlow")
    {
      this.InitClass();
    }

    internal CashFlowDataTable(DataTable table)
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

    internal DataColumn postDateColumn => this.columnpostDate;

    internal DataColumn amountColumn => this.columnamount;

    public dsCashFlow.CashFlowRow this[int index] => (dsCashFlow.CashFlowRow) this.Rows[index];

    public event dsCashFlow.CashFlowRowChangeEventHandler CashFlowRowChanged;

    public event dsCashFlow.CashFlowRowChangeEventHandler CashFlowRowChanging;

    public event dsCashFlow.CashFlowRowChangeEventHandler CashFlowRowDeleted;

    public event dsCashFlow.CashFlowRowChangeEventHandler CashFlowRowDeleting;

    public void AddCashFlowRow(dsCashFlow.CashFlowRow row) => this.Rows.Add((DataRow) row);

    public dsCashFlow.CashFlowRow AddCashFlowRow(Decimal postDate, Decimal amount)
    {
      dsCashFlow.CashFlowRow row = (dsCashFlow.CashFlowRow) this.NewRow();
      row.ItemArray = new object[2]
      {
        (object) postDate,
        (object) amount
      };
      this.Rows.Add((DataRow) row);
      return row;
    }

    public IEnumerator GetEnumerator() => this.Rows.GetEnumerator();

    public override DataTable Clone()
    {
      dsCashFlow.CashFlowDataTable cashFlowDataTable = (dsCashFlow.CashFlowDataTable) base.Clone();
      cashFlowDataTable.InitVars();
      return (DataTable) cashFlowDataTable;
    }

    protected override DataTable CreateInstance() => (DataTable) new dsCashFlow.CashFlowDataTable();

    internal void InitVars()
    {
      this.columnpostDate = this.Columns["postDate"];
      this.columnamount = this.Columns["amount"];
    }

    private void InitClass()
    {
      this.columnpostDate = new DataColumn("postDate", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnpostDate);
      this.columnamount = new DataColumn("amount", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnamount);
    }

    public dsCashFlow.CashFlowRow NewCashFlowRow() => (dsCashFlow.CashFlowRow) this.NewRow();

    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsCashFlow.CashFlowRow(builder);
    }

    protected override Type GetRowType() => typeof (dsCashFlow.CashFlowRow);

    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.CashFlowRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCashFlow.CashFlowRowChangeEventHandler flowRowChangedEvent = this.CashFlowRowChangedEvent;
      if (flowRowChangedEvent == null)
        return;
      flowRowChangedEvent((object) this, new dsCashFlow.CashFlowRowChangeEvent((dsCashFlow.CashFlowRow) e.Row, e.Action));
    }

    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.CashFlowRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCashFlow.CashFlowRowChangeEventHandler rowChangingEvent = this.CashFlowRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsCashFlow.CashFlowRowChangeEvent((dsCashFlow.CashFlowRow) e.Row, e.Action));
    }

    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.CashFlowRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCashFlow.CashFlowRowChangeEventHandler flowRowDeletedEvent = this.CashFlowRowDeletedEvent;
      if (flowRowDeletedEvent == null)
        return;
      flowRowDeletedEvent((object) this, new dsCashFlow.CashFlowRowChangeEvent((dsCashFlow.CashFlowRow) e.Row, e.Action));
    }

    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.CashFlowRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCashFlow.CashFlowRowChangeEventHandler rowDeletingEvent = this.CashFlowRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsCashFlow.CashFlowRowChangeEvent((dsCashFlow.CashFlowRow) e.Row, e.Action));
    }

    public void RemoveCashFlowRow(dsCashFlow.CashFlowRow row) => this.Rows.Remove((DataRow) row);
  }

  [DebuggerStepThrough]
  public class CashFlowRow : DataRow
  {
    private dsCashFlow.CashFlowDataTable tableCashFlow;

    internal CashFlowRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableCashFlow = (dsCashFlow.CashFlowDataTable) this.Table;
    }

    public Decimal postDate
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tableCashFlow.postDateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableCashFlow.postDateColumn] = (object) value;
    }

    public Decimal amount
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tableCashFlow.amountColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableCashFlow.amountColumn] = (object) value;
    }

    public bool IspostDateNull() => this.IsNull(this.tableCashFlow.postDateColumn);

    public void SetpostDateNull()
    {
      this[this.tableCashFlow.postDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsamountNull() => this.IsNull(this.tableCashFlow.amountColumn);

    public void SetamountNull()
    {
      this[this.tableCashFlow.amountColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  [DebuggerStepThrough]
  public class CashFlowRowChangeEvent : EventArgs
  {
    private dsCashFlow.CashFlowRow eventRow;
    private DataRowAction eventAction;

    public CashFlowRowChangeEvent(dsCashFlow.CashFlowRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    public dsCashFlow.CashFlowRow Row => this.eventRow;

    public DataRowAction Action => this.eventAction;
  }
}
