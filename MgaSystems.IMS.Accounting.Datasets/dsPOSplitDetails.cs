// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.AccountingDatasets.dsPOSplitDetails
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
public class dsPOSplitDetails : DataSet
{
  private dsPOSplitDetails.spFin_GetPurchaseOrderDetailsDataTable tablespFin_GetPurchaseOrderDetails;

  public dsPOSplitDetails()
  {
    this.InitClass();
    CollectionChangeEventHandler changeEventHandler = new CollectionChangeEventHandler(this.SchemaChanged);
    this.Tables.CollectionChanged += changeEventHandler;
    this.Relations.CollectionChanged += changeEventHandler;
  }

  protected dsPOSplitDetails(SerializationInfo info, StreamingContext context)
  {
    string s = Conversions.ToString(info.GetValue("XmlSchema", typeof (string)));
    if (s != null)
    {
      DataSet dataSet = new DataSet();
      dataSet.ReadXmlSchema((XmlReader) new XmlTextReader((TextReader) new StringReader(s)));
      if (dataSet.Tables[nameof (spFin_GetPurchaseOrderDetails)] != null)
        this.Tables.Add((DataTable) new dsPOSplitDetails.spFin_GetPurchaseOrderDetailsDataTable(dataSet.Tables[nameof (spFin_GetPurchaseOrderDetails)]));
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
  public dsPOSplitDetails.spFin_GetPurchaseOrderDetailsDataTable spFin_GetPurchaseOrderDetails
  {
    get => this.tablespFin_GetPurchaseOrderDetails;
  }

  public override DataSet Clone()
  {
    dsPOSplitDetails dsPoSplitDetails = (dsPOSplitDetails) base.Clone();
    dsPoSplitDetails.InitVars();
    return (DataSet) dsPoSplitDetails;
  }

  protected override bool ShouldSerializeTables() => false;

  protected override bool ShouldSerializeRelations() => false;

  protected override void ReadXmlSerializable(XmlReader reader)
  {
    this.Reset();
    DataSet dataSet = new DataSet();
    int num = (int) dataSet.ReadXml(reader);
    if (dataSet.Tables["spFin_GetPurchaseOrderDetails"] != null)
      this.Tables.Add((DataTable) new dsPOSplitDetails.spFin_GetPurchaseOrderDetailsDataTable(dataSet.Tables["spFin_GetPurchaseOrderDetails"]));
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
    this.tablespFin_GetPurchaseOrderDetails = (dsPOSplitDetails.spFin_GetPurchaseOrderDetailsDataTable) this.Tables["spFin_GetPurchaseOrderDetails"];
    if (this.tablespFin_GetPurchaseOrderDetails == null)
      return;
    this.tablespFin_GetPurchaseOrderDetails.InitVars();
  }

  private void InitClass()
  {
    this.DataSetName = nameof (dsPOSplitDetails);
    this.Prefix = "";
    this.Namespace = "http://www.tempuri.org/dsPOSplitDetails.xsd";
    this.Locale = new CultureInfo("en-US");
    this.CaseSensitive = false;
    this.EnforceConstraints = true;
    this.tablespFin_GetPurchaseOrderDetails = new dsPOSplitDetails.spFin_GetPurchaseOrderDetailsDataTable();
    this.Tables.Add((DataTable) this.tablespFin_GetPurchaseOrderDetails);
  }

  private bool ShouldSerializespFin_GetPurchaseOrderDetails() => false;

  private void SchemaChanged(object sender, CollectionChangeEventArgs e)
  {
    if (e.Action != CollectionChangeAction.Remove)
      return;
    this.InitVars();
  }

  public delegate void spFin_GetPurchaseOrderDetailsRowChangeEventHandler(
    object sender,
    dsPOSplitDetails.spFin_GetPurchaseOrderDetailsRowChangeEvent e);

  [DebuggerStepThrough]
  public class spFin_GetPurchaseOrderDetailsDataTable : DataTable, IEnumerable
  {
    private DataColumn columnExpense;
    private DataColumn columnAmount;
    private DataColumn columnDiscount;
    private DataColumn columnTotal;

    internal spFin_GetPurchaseOrderDetailsDataTable()
      : base("spFin_GetPurchaseOrderDetails")
    {
      this.InitClass();
    }

    internal spFin_GetPurchaseOrderDetailsDataTable(DataTable table)
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

    internal DataColumn ExpenseColumn => this.columnExpense;

    internal DataColumn AmountColumn => this.columnAmount;

    internal DataColumn DiscountColumn => this.columnDiscount;

    internal DataColumn TotalColumn => this.columnTotal;

    public dsPOSplitDetails.spFin_GetPurchaseOrderDetailsRow this[int index]
    {
      get => (dsPOSplitDetails.spFin_GetPurchaseOrderDetailsRow) this.Rows[index];
    }

    public event dsPOSplitDetails.spFin_GetPurchaseOrderDetailsRowChangeEventHandler spFin_GetPurchaseOrderDetailsRowChanged;

    public event dsPOSplitDetails.spFin_GetPurchaseOrderDetailsRowChangeEventHandler spFin_GetPurchaseOrderDetailsRowChanging;

    public event dsPOSplitDetails.spFin_GetPurchaseOrderDetailsRowChangeEventHandler spFin_GetPurchaseOrderDetailsRowDeleted;

    public event dsPOSplitDetails.spFin_GetPurchaseOrderDetailsRowChangeEventHandler spFin_GetPurchaseOrderDetailsRowDeleting;

    public void AddspFin_GetPurchaseOrderDetailsRow(
      dsPOSplitDetails.spFin_GetPurchaseOrderDetailsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    public dsPOSplitDetails.spFin_GetPurchaseOrderDetailsRow AddspFin_GetPurchaseOrderDetailsRow(
      string Expense,
      Decimal Amount,
      Decimal Discount,
      Decimal Total)
    {
      dsPOSplitDetails.spFin_GetPurchaseOrderDetailsRow row = (dsPOSplitDetails.spFin_GetPurchaseOrderDetailsRow) this.NewRow();
      row.ItemArray = new object[4]
      {
        (object) Expense,
        (object) Amount,
        (object) Discount,
        (object) Total
      };
      this.Rows.Add((DataRow) row);
      return row;
    }

    public IEnumerator GetEnumerator() => this.Rows.GetEnumerator();

    public override DataTable Clone()
    {
      dsPOSplitDetails.spFin_GetPurchaseOrderDetailsDataTable detailsDataTable = (dsPOSplitDetails.spFin_GetPurchaseOrderDetailsDataTable) base.Clone();
      detailsDataTable.InitVars();
      return (DataTable) detailsDataTable;
    }

    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsPOSplitDetails.spFin_GetPurchaseOrderDetailsDataTable();
    }

    internal void InitVars()
    {
      this.columnExpense = this.Columns["Expense"];
      this.columnAmount = this.Columns["Amount"];
      this.columnDiscount = this.Columns["Discount"];
      this.columnTotal = this.Columns["Total"];
    }

    private void InitClass()
    {
      this.columnExpense = new DataColumn("Expense", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnExpense);
      this.columnAmount = new DataColumn("Amount", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAmount);
      this.columnDiscount = new DataColumn("Discount", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDiscount);
      this.columnTotal = new DataColumn("Total", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnTotal);
      this.columnExpense.ReadOnly = true;
      this.columnAmount.AllowDBNull = false;
      this.columnTotal.ReadOnly = true;
    }

    public dsPOSplitDetails.spFin_GetPurchaseOrderDetailsRow NewspFin_GetPurchaseOrderDetailsRow()
    {
      return (dsPOSplitDetails.spFin_GetPurchaseOrderDetailsRow) this.NewRow();
    }

    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsPOSplitDetails.spFin_GetPurchaseOrderDetailsRow(builder);
    }

    protected override Type GetRowType()
    {
      return typeof (dsPOSplitDetails.spFin_GetPurchaseOrderDetailsRow);
    }

    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.spFin_GetPurchaseOrderDetailsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPOSplitDetails.spFin_GetPurchaseOrderDetailsRowChangeEventHandler detailsRowChangedEvent = this.spFin_GetPurchaseOrderDetailsRowChangedEvent;
      if (detailsRowChangedEvent == null)
        return;
      detailsRowChangedEvent((object) this, new dsPOSplitDetails.spFin_GetPurchaseOrderDetailsRowChangeEvent((dsPOSplitDetails.spFin_GetPurchaseOrderDetailsRow) e.Row, e.Action));
    }

    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.spFin_GetPurchaseOrderDetailsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPOSplitDetails.spFin_GetPurchaseOrderDetailsRowChangeEventHandler rowChangingEvent = this.spFin_GetPurchaseOrderDetailsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsPOSplitDetails.spFin_GetPurchaseOrderDetailsRowChangeEvent((dsPOSplitDetails.spFin_GetPurchaseOrderDetailsRow) e.Row, e.Action));
    }

    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.spFin_GetPurchaseOrderDetailsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPOSplitDetails.spFin_GetPurchaseOrderDetailsRowChangeEventHandler detailsRowDeletedEvent = this.spFin_GetPurchaseOrderDetailsRowDeletedEvent;
      if (detailsRowDeletedEvent == null)
        return;
      detailsRowDeletedEvent((object) this, new dsPOSplitDetails.spFin_GetPurchaseOrderDetailsRowChangeEvent((dsPOSplitDetails.spFin_GetPurchaseOrderDetailsRow) e.Row, e.Action));
    }

    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.spFin_GetPurchaseOrderDetailsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPOSplitDetails.spFin_GetPurchaseOrderDetailsRowChangeEventHandler rowDeletingEvent = this.spFin_GetPurchaseOrderDetailsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsPOSplitDetails.spFin_GetPurchaseOrderDetailsRowChangeEvent((dsPOSplitDetails.spFin_GetPurchaseOrderDetailsRow) e.Row, e.Action));
    }

    public void RemovespFin_GetPurchaseOrderDetailsRow(
      dsPOSplitDetails.spFin_GetPurchaseOrderDetailsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }
  }

  [DebuggerStepThrough]
  public class spFin_GetPurchaseOrderDetailsRow : DataRow
  {
    private dsPOSplitDetails.spFin_GetPurchaseOrderDetailsDataTable tablespFin_GetPurchaseOrderDetails;

    internal spFin_GetPurchaseOrderDetailsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablespFin_GetPurchaseOrderDetails = (dsPOSplitDetails.spFin_GetPurchaseOrderDetailsDataTable) this.Table;
    }

    public string Expense
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablespFin_GetPurchaseOrderDetails.ExpenseColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablespFin_GetPurchaseOrderDetails.ExpenseColumn] = (object) value;
    }

    public Decimal Amount
    {
      get => Conversions.ToDecimal(this[this.tablespFin_GetPurchaseOrderDetails.AmountColumn]);
      set => this[this.tablespFin_GetPurchaseOrderDetails.AmountColumn] = (object) value;
    }

    public Decimal Discount
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tablespFin_GetPurchaseOrderDetails.DiscountColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablespFin_GetPurchaseOrderDetails.DiscountColumn] = (object) value;
    }

    public Decimal Total
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tablespFin_GetPurchaseOrderDetails.TotalColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablespFin_GetPurchaseOrderDetails.TotalColumn] = (object) value;
    }

    public bool IsExpenseNull()
    {
      return this.IsNull(this.tablespFin_GetPurchaseOrderDetails.ExpenseColumn);
    }

    public void SetExpenseNull()
    {
      this[this.tablespFin_GetPurchaseOrderDetails.ExpenseColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsDiscountNull()
    {
      return this.IsNull(this.tablespFin_GetPurchaseOrderDetails.DiscountColumn);
    }

    public void SetDiscountNull()
    {
      this[this.tablespFin_GetPurchaseOrderDetails.DiscountColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsTotalNull() => this.IsNull(this.tablespFin_GetPurchaseOrderDetails.TotalColumn);

    public void SetTotalNull()
    {
      this[this.tablespFin_GetPurchaseOrderDetails.TotalColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  [DebuggerStepThrough]
  public class spFin_GetPurchaseOrderDetailsRowChangeEvent : EventArgs
  {
    private dsPOSplitDetails.spFin_GetPurchaseOrderDetailsRow eventRow;
    private DataRowAction eventAction;

    public spFin_GetPurchaseOrderDetailsRowChangeEvent(
      dsPOSplitDetails.spFin_GetPurchaseOrderDetailsRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    public dsPOSplitDetails.spFin_GetPurchaseOrderDetailsRow Row => this.eventRow;

    public DataRowAction Action => this.eventAction;
  }
}
