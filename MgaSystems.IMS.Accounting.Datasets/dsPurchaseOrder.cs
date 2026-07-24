// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.AccountingDatasets.dsPurchaseOrder
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
public class dsPurchaseOrder : DataSet
{
  private dsPurchaseOrder.PurchaseOrderHeaderDataTable tablePurchaseOrderHeader;

  public dsPurchaseOrder()
  {
    this.InitClass();
    CollectionChangeEventHandler changeEventHandler = new CollectionChangeEventHandler(this.SchemaChanged);
    this.Tables.CollectionChanged += changeEventHandler;
    this.Relations.CollectionChanged += changeEventHandler;
  }

  protected dsPurchaseOrder(SerializationInfo info, StreamingContext context)
  {
    string s = Conversions.ToString(info.GetValue("XmlSchema", typeof (string)));
    if (s != null)
    {
      DataSet dataSet = new DataSet();
      dataSet.ReadXmlSchema((XmlReader) new XmlTextReader((TextReader) new StringReader(s)));
      if (dataSet.Tables[nameof (PurchaseOrderHeader)] != null)
        this.Tables.Add((DataTable) new dsPurchaseOrder.PurchaseOrderHeaderDataTable(dataSet.Tables[nameof (PurchaseOrderHeader)]));
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
  public dsPurchaseOrder.PurchaseOrderHeaderDataTable PurchaseOrderHeader
  {
    get => this.tablePurchaseOrderHeader;
  }

  public override DataSet Clone()
  {
    dsPurchaseOrder dsPurchaseOrder = (dsPurchaseOrder) base.Clone();
    dsPurchaseOrder.InitVars();
    return (DataSet) dsPurchaseOrder;
  }

  protected override bool ShouldSerializeTables() => false;

  protected override bool ShouldSerializeRelations() => false;

  protected override void ReadXmlSerializable(XmlReader reader)
  {
    this.Reset();
    DataSet dataSet = new DataSet();
    int num = (int) dataSet.ReadXml(reader);
    if (dataSet.Tables["PurchaseOrderHeader"] != null)
      this.Tables.Add((DataTable) new dsPurchaseOrder.PurchaseOrderHeaderDataTable(dataSet.Tables["PurchaseOrderHeader"]));
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
    this.tablePurchaseOrderHeader = (dsPurchaseOrder.PurchaseOrderHeaderDataTable) this.Tables["PurchaseOrderHeader"];
    if (this.tablePurchaseOrderHeader == null)
      return;
    this.tablePurchaseOrderHeader.InitVars();
  }

  private void InitClass()
  {
    this.DataSetName = nameof (dsPurchaseOrder);
    this.Prefix = "";
    this.Namespace = "http://tempuri.org/dsPurchaseOrder.xsd";
    this.Locale = new CultureInfo("en-US");
    this.CaseSensitive = false;
    this.EnforceConstraints = true;
    this.tablePurchaseOrderHeader = new dsPurchaseOrder.PurchaseOrderHeaderDataTable();
    this.Tables.Add((DataTable) this.tablePurchaseOrderHeader);
  }

  private bool ShouldSerializePurchaseOrderHeader() => false;

  private void SchemaChanged(object sender, CollectionChangeEventArgs e)
  {
    if (e.Action != CollectionChangeAction.Remove)
      return;
    this.InitVars();
  }

  public delegate void PurchaseOrderHeaderRowChangeEventHandler(
    object sender,
    dsPurchaseOrder.PurchaseOrderHeaderRowChangeEvent e);

  [DebuggerStepThrough]
  public class PurchaseOrderHeaderDataTable : DataTable, IEnumerable
  {
    private DataColumn columnPurchaseOrderId;

    internal PurchaseOrderHeaderDataTable()
      : base("PurchaseOrderHeader")
    {
      this.InitClass();
    }

    internal PurchaseOrderHeaderDataTable(DataTable table)
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

    internal DataColumn PurchaseOrderIdColumn => this.columnPurchaseOrderId;

    public dsPurchaseOrder.PurchaseOrderHeaderRow this[int index]
    {
      get => (dsPurchaseOrder.PurchaseOrderHeaderRow) this.Rows[index];
    }

    public event dsPurchaseOrder.PurchaseOrderHeaderRowChangeEventHandler PurchaseOrderHeaderRowChanged;

    public event dsPurchaseOrder.PurchaseOrderHeaderRowChangeEventHandler PurchaseOrderHeaderRowChanging;

    public event dsPurchaseOrder.PurchaseOrderHeaderRowChangeEventHandler PurchaseOrderHeaderRowDeleted;

    public event dsPurchaseOrder.PurchaseOrderHeaderRowChangeEventHandler PurchaseOrderHeaderRowDeleting;

    public void AddPurchaseOrderHeaderRow(dsPurchaseOrder.PurchaseOrderHeaderRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    public dsPurchaseOrder.PurchaseOrderHeaderRow AddPurchaseOrderHeaderRow(int PurchaseOrderId)
    {
      dsPurchaseOrder.PurchaseOrderHeaderRow row = (dsPurchaseOrder.PurchaseOrderHeaderRow) this.NewRow();
      row.ItemArray = new object[1]
      {
        (object) PurchaseOrderId
      };
      this.Rows.Add((DataRow) row);
      return row;
    }

    public IEnumerator GetEnumerator() => this.Rows.GetEnumerator();

    public override DataTable Clone()
    {
      dsPurchaseOrder.PurchaseOrderHeaderDataTable orderHeaderDataTable = (dsPurchaseOrder.PurchaseOrderHeaderDataTable) base.Clone();
      orderHeaderDataTable.InitVars();
      return (DataTable) orderHeaderDataTable;
    }

    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsPurchaseOrder.PurchaseOrderHeaderDataTable();
    }

    internal void InitVars() => this.columnPurchaseOrderId = this.Columns["PurchaseOrderId"];

    private void InitClass()
    {
      this.columnPurchaseOrderId = new DataColumn("PurchaseOrderId", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPurchaseOrderId);
    }

    public dsPurchaseOrder.PurchaseOrderHeaderRow NewPurchaseOrderHeaderRow()
    {
      return (dsPurchaseOrder.PurchaseOrderHeaderRow) this.NewRow();
    }

    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsPurchaseOrder.PurchaseOrderHeaderRow(builder);
    }

    protected override Type GetRowType() => typeof (dsPurchaseOrder.PurchaseOrderHeaderRow);

    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.PurchaseOrderHeaderRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPurchaseOrder.PurchaseOrderHeaderRowChangeEventHandler headerRowChangedEvent = this.PurchaseOrderHeaderRowChangedEvent;
      if (headerRowChangedEvent == null)
        return;
      headerRowChangedEvent((object) this, new dsPurchaseOrder.PurchaseOrderHeaderRowChangeEvent((dsPurchaseOrder.PurchaseOrderHeaderRow) e.Row, e.Action));
    }

    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.PurchaseOrderHeaderRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPurchaseOrder.PurchaseOrderHeaderRowChangeEventHandler rowChangingEvent = this.PurchaseOrderHeaderRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsPurchaseOrder.PurchaseOrderHeaderRowChangeEvent((dsPurchaseOrder.PurchaseOrderHeaderRow) e.Row, e.Action));
    }

    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.PurchaseOrderHeaderRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPurchaseOrder.PurchaseOrderHeaderRowChangeEventHandler headerRowDeletedEvent = this.PurchaseOrderHeaderRowDeletedEvent;
      if (headerRowDeletedEvent == null)
        return;
      headerRowDeletedEvent((object) this, new dsPurchaseOrder.PurchaseOrderHeaderRowChangeEvent((dsPurchaseOrder.PurchaseOrderHeaderRow) e.Row, e.Action));
    }

    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.PurchaseOrderHeaderRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPurchaseOrder.PurchaseOrderHeaderRowChangeEventHandler rowDeletingEvent = this.PurchaseOrderHeaderRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsPurchaseOrder.PurchaseOrderHeaderRowChangeEvent((dsPurchaseOrder.PurchaseOrderHeaderRow) e.Row, e.Action));
    }

    public void RemovePurchaseOrderHeaderRow(dsPurchaseOrder.PurchaseOrderHeaderRow row)
    {
      this.Rows.Remove((DataRow) row);
    }
  }

  [DebuggerStepThrough]
  public class PurchaseOrderHeaderRow : DataRow
  {
    private dsPurchaseOrder.PurchaseOrderHeaderDataTable tablePurchaseOrderHeader;

    internal PurchaseOrderHeaderRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablePurchaseOrderHeader = (dsPurchaseOrder.PurchaseOrderHeaderDataTable) this.Table;
    }

    public int PurchaseOrderId
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tablePurchaseOrderHeader.PurchaseOrderIdColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePurchaseOrderHeader.PurchaseOrderIdColumn] = (object) value;
    }

    public bool IsPurchaseOrderIdNull()
    {
      return this.IsNull(this.tablePurchaseOrderHeader.PurchaseOrderIdColumn);
    }

    public void SetPurchaseOrderIdNull()
    {
      this[this.tablePurchaseOrderHeader.PurchaseOrderIdColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  [DebuggerStepThrough]
  public class PurchaseOrderHeaderRowChangeEvent : EventArgs
  {
    private dsPurchaseOrder.PurchaseOrderHeaderRow eventRow;
    private DataRowAction eventAction;

    public PurchaseOrderHeaderRowChangeEvent(
      dsPurchaseOrder.PurchaseOrderHeaderRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    public dsPurchaseOrder.PurchaseOrderHeaderRow Row => this.eventRow;

    public DataRowAction Action => this.eventAction;
  }
}
