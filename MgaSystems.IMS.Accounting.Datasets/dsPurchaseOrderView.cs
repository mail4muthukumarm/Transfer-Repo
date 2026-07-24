// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.AccountingDatasets.dsPurchaseOrderView
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
public class dsPurchaseOrderView : DataSet
{
  private dsPurchaseOrderView.ViewHeaderDataTable tableViewHeader;
  private dsPurchaseOrderView.ViewDetailDataTable tableViewDetail;

  public dsPurchaseOrderView()
  {
    this.InitClass();
    CollectionChangeEventHandler changeEventHandler = new CollectionChangeEventHandler(this.SchemaChanged);
    this.Tables.CollectionChanged += changeEventHandler;
    this.Relations.CollectionChanged += changeEventHandler;
  }

  protected dsPurchaseOrderView(SerializationInfo info, StreamingContext context)
  {
    string s = Conversions.ToString(info.GetValue("XmlSchema", typeof (string)));
    if (s != null)
    {
      DataSet dataSet = new DataSet();
      dataSet.ReadXmlSchema((XmlReader) new XmlTextReader((TextReader) new StringReader(s)));
      if (dataSet.Tables[nameof (ViewHeader)] != null)
        this.Tables.Add((DataTable) new dsPurchaseOrderView.ViewHeaderDataTable(dataSet.Tables[nameof (ViewHeader)]));
      if (dataSet.Tables[nameof (ViewDetail)] != null)
        this.Tables.Add((DataTable) new dsPurchaseOrderView.ViewDetailDataTable(dataSet.Tables[nameof (ViewDetail)]));
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
  public dsPurchaseOrderView.ViewHeaderDataTable ViewHeader => this.tableViewHeader;

  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsPurchaseOrderView.ViewDetailDataTable ViewDetail => this.tableViewDetail;

  public override DataSet Clone()
  {
    dsPurchaseOrderView purchaseOrderView = (dsPurchaseOrderView) base.Clone();
    purchaseOrderView.InitVars();
    return (DataSet) purchaseOrderView;
  }

  protected override bool ShouldSerializeTables() => false;

  protected override bool ShouldSerializeRelations() => false;

  protected override void ReadXmlSerializable(XmlReader reader)
  {
    this.Reset();
    DataSet dataSet = new DataSet();
    int num = (int) dataSet.ReadXml(reader);
    if (dataSet.Tables["ViewHeader"] != null)
      this.Tables.Add((DataTable) new dsPurchaseOrderView.ViewHeaderDataTable(dataSet.Tables["ViewHeader"]));
    if (dataSet.Tables["ViewDetail"] != null)
      this.Tables.Add((DataTable) new dsPurchaseOrderView.ViewDetailDataTable(dataSet.Tables["ViewDetail"]));
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
    this.tableViewHeader = (dsPurchaseOrderView.ViewHeaderDataTable) this.Tables["ViewHeader"];
    if (this.tableViewHeader != null)
      this.tableViewHeader.InitVars();
    this.tableViewDetail = (dsPurchaseOrderView.ViewDetailDataTable) this.Tables["ViewDetail"];
    if (this.tableViewDetail == null)
      return;
    this.tableViewDetail.InitVars();
  }

  private void InitClass()
  {
    this.DataSetName = nameof (dsPurchaseOrderView);
    this.Prefix = "";
    this.Namespace = "http://tempuri.org/dsPurchaseOrderView.xsd";
    this.Locale = new CultureInfo("en-US");
    this.CaseSensitive = false;
    this.EnforceConstraints = true;
    this.tableViewHeader = new dsPurchaseOrderView.ViewHeaderDataTable();
    this.Tables.Add((DataTable) this.tableViewHeader);
    this.tableViewDetail = new dsPurchaseOrderView.ViewDetailDataTable();
    this.Tables.Add((DataTable) this.tableViewDetail);
  }

  private bool ShouldSerializeViewHeader() => false;

  private bool ShouldSerializeViewDetail() => false;

  private void SchemaChanged(object sender, CollectionChangeEventArgs e)
  {
    if (e.Action != CollectionChangeAction.Remove)
      return;
    this.InitVars();
  }

  public delegate void ViewHeaderRowChangeEventHandler(
    object sender,
    dsPurchaseOrderView.ViewHeaderRowChangeEvent e);

  public delegate void ViewDetailRowChangeEventHandler(
    object sender,
    dsPurchaseOrderView.ViewDetailRowChangeEvent e);

  [DebuggerStepThrough]
  public class ViewHeaderDataTable : DataTable, IEnumerable
  {
    private DataColumn columnPayee;
    private DataColumn columnpoDate;
    private DataColumn columnpurchaseOrderTotal;

    internal ViewHeaderDataTable()
      : base("ViewHeader")
    {
      this.InitClass();
    }

    internal ViewHeaderDataTable(DataTable table)
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

    internal DataColumn PayeeColumn => this.columnPayee;

    internal DataColumn poDateColumn => this.columnpoDate;

    internal DataColumn purchaseOrderTotalColumn => this.columnpurchaseOrderTotal;

    public dsPurchaseOrderView.ViewHeaderRow this[int index]
    {
      get => (dsPurchaseOrderView.ViewHeaderRow) this.Rows[index];
    }

    public event dsPurchaseOrderView.ViewHeaderRowChangeEventHandler ViewHeaderRowChanged;

    public event dsPurchaseOrderView.ViewHeaderRowChangeEventHandler ViewHeaderRowChanging;

    public event dsPurchaseOrderView.ViewHeaderRowChangeEventHandler ViewHeaderRowDeleted;

    public event dsPurchaseOrderView.ViewHeaderRowChangeEventHandler ViewHeaderRowDeleting;

    public void AddViewHeaderRow(dsPurchaseOrderView.ViewHeaderRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    public dsPurchaseOrderView.ViewHeaderRow AddViewHeaderRow(
      string Payee,
      DateTime poDate,
      Decimal purchaseOrderTotal)
    {
      dsPurchaseOrderView.ViewHeaderRow row = (dsPurchaseOrderView.ViewHeaderRow) this.NewRow();
      row.ItemArray = new object[3]
      {
        (object) Payee,
        (object) poDate,
        (object) purchaseOrderTotal
      };
      this.Rows.Add((DataRow) row);
      return row;
    }

    public IEnumerator GetEnumerator() => this.Rows.GetEnumerator();

    public override DataTable Clone()
    {
      dsPurchaseOrderView.ViewHeaderDataTable viewHeaderDataTable = (dsPurchaseOrderView.ViewHeaderDataTable) base.Clone();
      viewHeaderDataTable.InitVars();
      return (DataTable) viewHeaderDataTable;
    }

    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsPurchaseOrderView.ViewHeaderDataTable();
    }

    internal void InitVars()
    {
      this.columnPayee = this.Columns["Payee"];
      this.columnpoDate = this.Columns["poDate"];
      this.columnpurchaseOrderTotal = this.Columns["purchaseOrderTotal"];
    }

    private void InitClass()
    {
      this.columnPayee = new DataColumn("Payee", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPayee);
      this.columnpoDate = new DataColumn("poDate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnpoDate);
      this.columnpurchaseOrderTotal = new DataColumn("purchaseOrderTotal", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnpurchaseOrderTotal);
    }

    public dsPurchaseOrderView.ViewHeaderRow NewViewHeaderRow()
    {
      return (dsPurchaseOrderView.ViewHeaderRow) this.NewRow();
    }

    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsPurchaseOrderView.ViewHeaderRow(builder);
    }

    protected override Type GetRowType() => typeof (dsPurchaseOrderView.ViewHeaderRow);

    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.ViewHeaderRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPurchaseOrderView.ViewHeaderRowChangeEventHandler headerRowChangedEvent = this.ViewHeaderRowChangedEvent;
      if (headerRowChangedEvent == null)
        return;
      headerRowChangedEvent((object) this, new dsPurchaseOrderView.ViewHeaderRowChangeEvent((dsPurchaseOrderView.ViewHeaderRow) e.Row, e.Action));
    }

    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.ViewHeaderRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPurchaseOrderView.ViewHeaderRowChangeEventHandler rowChangingEvent = this.ViewHeaderRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsPurchaseOrderView.ViewHeaderRowChangeEvent((dsPurchaseOrderView.ViewHeaderRow) e.Row, e.Action));
    }

    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.ViewHeaderRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPurchaseOrderView.ViewHeaderRowChangeEventHandler headerRowDeletedEvent = this.ViewHeaderRowDeletedEvent;
      if (headerRowDeletedEvent == null)
        return;
      headerRowDeletedEvent((object) this, new dsPurchaseOrderView.ViewHeaderRowChangeEvent((dsPurchaseOrderView.ViewHeaderRow) e.Row, e.Action));
    }

    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.ViewHeaderRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPurchaseOrderView.ViewHeaderRowChangeEventHandler rowDeletingEvent = this.ViewHeaderRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsPurchaseOrderView.ViewHeaderRowChangeEvent((dsPurchaseOrderView.ViewHeaderRow) e.Row, e.Action));
    }

    public void RemoveViewHeaderRow(dsPurchaseOrderView.ViewHeaderRow row)
    {
      this.Rows.Remove((DataRow) row);
    }
  }

  [DebuggerStepThrough]
  public class ViewHeaderRow : DataRow
  {
    private dsPurchaseOrderView.ViewHeaderDataTable tableViewHeader;

    internal ViewHeaderRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableViewHeader = (dsPurchaseOrderView.ViewHeaderDataTable) this.Table;
    }

    public string Payee
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableViewHeader.PayeeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableViewHeader.PayeeColumn] = (object) value;
    }

    public DateTime poDate
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tableViewHeader.poDateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableViewHeader.poDateColumn] = (object) value;
    }

    public Decimal purchaseOrderTotal
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tableViewHeader.purchaseOrderTotalColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableViewHeader.purchaseOrderTotalColumn] = (object) value;
    }

    public bool IsPayeeNull() => this.IsNull(this.tableViewHeader.PayeeColumn);

    public void SetPayeeNull()
    {
      this[this.tableViewHeader.PayeeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IspoDateNull() => this.IsNull(this.tableViewHeader.poDateColumn);

    public void SetpoDateNull()
    {
      this[this.tableViewHeader.poDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IspurchaseOrderTotalNull()
    {
      return this.IsNull(this.tableViewHeader.purchaseOrderTotalColumn);
    }

    public void SetpurchaseOrderTotalNull()
    {
      this[this.tableViewHeader.purchaseOrderTotalColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  [DebuggerStepThrough]
  public class ViewHeaderRowChangeEvent : EventArgs
  {
    private dsPurchaseOrderView.ViewHeaderRow eventRow;
    private DataRowAction eventAction;

    public ViewHeaderRowChangeEvent(dsPurchaseOrderView.ViewHeaderRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    public dsPurchaseOrderView.ViewHeaderRow Row => this.eventRow;

    public DataRowAction Action => this.eventAction;
  }

  [DebuggerStepThrough]
  public class ViewDetailDataTable : DataTable, IEnumerable
  {
    private DataColumn columnexpenseName;
    private DataColumn columndiscount;
    private DataColumn columnamount;
    private DataColumn columntotal;

    internal ViewDetailDataTable()
      : base("ViewDetail")
    {
      this.InitClass();
    }

    internal ViewDetailDataTable(DataTable table)
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

    internal DataColumn expenseNameColumn => this.columnexpenseName;

    internal DataColumn discountColumn => this.columndiscount;

    internal DataColumn amountColumn => this.columnamount;

    internal DataColumn totalColumn => this.columntotal;

    public dsPurchaseOrderView.ViewDetailRow this[int index]
    {
      get => (dsPurchaseOrderView.ViewDetailRow) this.Rows[index];
    }

    public event dsPurchaseOrderView.ViewDetailRowChangeEventHandler ViewDetailRowChanged;

    public event dsPurchaseOrderView.ViewDetailRowChangeEventHandler ViewDetailRowChanging;

    public event dsPurchaseOrderView.ViewDetailRowChangeEventHandler ViewDetailRowDeleted;

    public event dsPurchaseOrderView.ViewDetailRowChangeEventHandler ViewDetailRowDeleting;

    public void AddViewDetailRow(dsPurchaseOrderView.ViewDetailRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    public dsPurchaseOrderView.ViewDetailRow AddViewDetailRow(
      string expenseName,
      Decimal discount,
      Decimal amount,
      Decimal total)
    {
      dsPurchaseOrderView.ViewDetailRow row = (dsPurchaseOrderView.ViewDetailRow) this.NewRow();
      row.ItemArray = new object[4]
      {
        (object) expenseName,
        (object) discount,
        (object) amount,
        (object) total
      };
      this.Rows.Add((DataRow) row);
      return row;
    }

    public IEnumerator GetEnumerator() => this.Rows.GetEnumerator();

    public override DataTable Clone()
    {
      dsPurchaseOrderView.ViewDetailDataTable viewDetailDataTable = (dsPurchaseOrderView.ViewDetailDataTable) base.Clone();
      viewDetailDataTable.InitVars();
      return (DataTable) viewDetailDataTable;
    }

    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsPurchaseOrderView.ViewDetailDataTable();
    }

    internal void InitVars()
    {
      this.columnexpenseName = this.Columns["expenseName"];
      this.columndiscount = this.Columns["discount"];
      this.columnamount = this.Columns["amount"];
      this.columntotal = this.Columns["total"];
    }

    private void InitClass()
    {
      this.columnexpenseName = new DataColumn("expenseName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnexpenseName);
      this.columndiscount = new DataColumn("discount", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columndiscount);
      this.columnamount = new DataColumn("amount", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnamount);
      this.columntotal = new DataColumn("total", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columntotal);
    }

    public dsPurchaseOrderView.ViewDetailRow NewViewDetailRow()
    {
      return (dsPurchaseOrderView.ViewDetailRow) this.NewRow();
    }

    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsPurchaseOrderView.ViewDetailRow(builder);
    }

    protected override Type GetRowType() => typeof (dsPurchaseOrderView.ViewDetailRow);

    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.ViewDetailRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPurchaseOrderView.ViewDetailRowChangeEventHandler detailRowChangedEvent = this.ViewDetailRowChangedEvent;
      if (detailRowChangedEvent == null)
        return;
      detailRowChangedEvent((object) this, new dsPurchaseOrderView.ViewDetailRowChangeEvent((dsPurchaseOrderView.ViewDetailRow) e.Row, e.Action));
    }

    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.ViewDetailRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPurchaseOrderView.ViewDetailRowChangeEventHandler rowChangingEvent = this.ViewDetailRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsPurchaseOrderView.ViewDetailRowChangeEvent((dsPurchaseOrderView.ViewDetailRow) e.Row, e.Action));
    }

    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.ViewDetailRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPurchaseOrderView.ViewDetailRowChangeEventHandler detailRowDeletedEvent = this.ViewDetailRowDeletedEvent;
      if (detailRowDeletedEvent == null)
        return;
      detailRowDeletedEvent((object) this, new dsPurchaseOrderView.ViewDetailRowChangeEvent((dsPurchaseOrderView.ViewDetailRow) e.Row, e.Action));
    }

    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.ViewDetailRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPurchaseOrderView.ViewDetailRowChangeEventHandler rowDeletingEvent = this.ViewDetailRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsPurchaseOrderView.ViewDetailRowChangeEvent((dsPurchaseOrderView.ViewDetailRow) e.Row, e.Action));
    }

    public void RemoveViewDetailRow(dsPurchaseOrderView.ViewDetailRow row)
    {
      this.Rows.Remove((DataRow) row);
    }
  }

  [DebuggerStepThrough]
  public class ViewDetailRow : DataRow
  {
    private dsPurchaseOrderView.ViewDetailDataTable tableViewDetail;

    internal ViewDetailRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableViewDetail = (dsPurchaseOrderView.ViewDetailDataTable) this.Table;
    }

    public string expenseName
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableViewDetail.expenseNameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableViewDetail.expenseNameColumn] = (object) value;
    }

    public Decimal discount
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tableViewDetail.discountColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableViewDetail.discountColumn] = (object) value;
    }

    public Decimal amount
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tableViewDetail.amountColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableViewDetail.amountColumn] = (object) value;
    }

    public Decimal total
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tableViewDetail.totalColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableViewDetail.totalColumn] = (object) value;
    }

    public bool IsexpenseNameNull() => this.IsNull(this.tableViewDetail.expenseNameColumn);

    public void SetexpenseNameNull()
    {
      this[this.tableViewDetail.expenseNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsdiscountNull() => this.IsNull(this.tableViewDetail.discountColumn);

    public void SetdiscountNull()
    {
      this[this.tableViewDetail.discountColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsamountNull() => this.IsNull(this.tableViewDetail.amountColumn);

    public void SetamountNull()
    {
      this[this.tableViewDetail.amountColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IstotalNull() => this.IsNull(this.tableViewDetail.totalColumn);

    public void SettotalNull()
    {
      this[this.tableViewDetail.totalColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  [DebuggerStepThrough]
  public class ViewDetailRowChangeEvent : EventArgs
  {
    private dsPurchaseOrderView.ViewDetailRow eventRow;
    private DataRowAction eventAction;

    public ViewDetailRowChangeEvent(dsPurchaseOrderView.ViewDetailRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    public dsPurchaseOrderView.ViewDetailRow Row => this.eventRow;

    public DataRowAction Action => this.eventAction;
  }
}
