// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.AccountingDatasets.dsPaymentMethods
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
public class dsPaymentMethods : DataSet
{
  private dsPaymentMethods.PaymentMethodsDataTable tablePaymentMethods;

  public dsPaymentMethods()
  {
    this.InitClass();
    CollectionChangeEventHandler changeEventHandler = new CollectionChangeEventHandler(this.SchemaChanged);
    this.Tables.CollectionChanged += changeEventHandler;
    this.Relations.CollectionChanged += changeEventHandler;
  }

  protected dsPaymentMethods(SerializationInfo info, StreamingContext context)
  {
    string s = Conversions.ToString(info.GetValue("XmlSchema", typeof (string)));
    if (s != null)
    {
      DataSet dataSet = new DataSet();
      dataSet.ReadXmlSchema((XmlReader) new XmlTextReader((TextReader) new StringReader(s)));
      if (dataSet.Tables[nameof (PaymentMethods)] != null)
        this.Tables.Add((DataTable) new dsPaymentMethods.PaymentMethodsDataTable(dataSet.Tables[nameof (PaymentMethods)]));
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
  public dsPaymentMethods.PaymentMethodsDataTable PaymentMethods => this.tablePaymentMethods;

  public override DataSet Clone()
  {
    dsPaymentMethods dsPaymentMethods = (dsPaymentMethods) base.Clone();
    dsPaymentMethods.InitVars();
    return (DataSet) dsPaymentMethods;
  }

  protected override bool ShouldSerializeTables() => false;

  protected override bool ShouldSerializeRelations() => false;

  protected override void ReadXmlSerializable(XmlReader reader)
  {
    this.Reset();
    DataSet dataSet = new DataSet();
    int num = (int) dataSet.ReadXml(reader);
    if (dataSet.Tables["PaymentMethods"] != null)
      this.Tables.Add((DataTable) new dsPaymentMethods.PaymentMethodsDataTable(dataSet.Tables["PaymentMethods"]));
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
    this.tablePaymentMethods = (dsPaymentMethods.PaymentMethodsDataTable) this.Tables["PaymentMethods"];
    if (this.tablePaymentMethods == null)
      return;
    this.tablePaymentMethods.InitVars();
  }

  private void InitClass()
  {
    this.DataSetName = nameof (dsPaymentMethods);
    this.Prefix = "";
    this.Namespace = "http://tempuri.org/dsPaymentMethods.xsd";
    this.Locale = new CultureInfo("en-US");
    this.CaseSensitive = false;
    this.EnforceConstraints = true;
    this.tablePaymentMethods = new dsPaymentMethods.PaymentMethodsDataTable();
    this.Tables.Add((DataTable) this.tablePaymentMethods);
  }

  private bool ShouldSerializePaymentMethods() => false;

  private void SchemaChanged(object sender, CollectionChangeEventArgs e)
  {
    if (e.Action != CollectionChangeAction.Remove)
      return;
    this.InitVars();
  }

  public delegate void PaymentMethodsRowChangeEventHandler(
    object sender,
    dsPaymentMethods.PaymentMethodsRowChangeEvent e);

  [DebuggerStepThrough]
  public class PaymentMethodsDataTable : DataTable, IEnumerable
  {
    private DataColumn columnPayMethodID;
    private DataColumn columnMethodName;

    internal PaymentMethodsDataTable()
      : base("PaymentMethods")
    {
      this.InitClass();
    }

    internal PaymentMethodsDataTable(DataTable table)
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

    internal DataColumn PayMethodIDColumn => this.columnPayMethodID;

    internal DataColumn MethodNameColumn => this.columnMethodName;

    public dsPaymentMethods.PaymentMethodsRow this[int index]
    {
      get => (dsPaymentMethods.PaymentMethodsRow) this.Rows[index];
    }

    public event dsPaymentMethods.PaymentMethodsRowChangeEventHandler PaymentMethodsRowChanged;

    public event dsPaymentMethods.PaymentMethodsRowChangeEventHandler PaymentMethodsRowChanging;

    public event dsPaymentMethods.PaymentMethodsRowChangeEventHandler PaymentMethodsRowDeleted;

    public event dsPaymentMethods.PaymentMethodsRowChangeEventHandler PaymentMethodsRowDeleting;

    public void AddPaymentMethodsRow(dsPaymentMethods.PaymentMethodsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    public dsPaymentMethods.PaymentMethodsRow AddPaymentMethodsRow(
      string PayMethodID,
      string MethodName)
    {
      dsPaymentMethods.PaymentMethodsRow row = (dsPaymentMethods.PaymentMethodsRow) this.NewRow();
      row.ItemArray = new object[2]
      {
        (object) PayMethodID,
        (object) MethodName
      };
      this.Rows.Add((DataRow) row);
      return row;
    }

    public IEnumerator GetEnumerator() => this.Rows.GetEnumerator();

    public override DataTable Clone()
    {
      dsPaymentMethods.PaymentMethodsDataTable methodsDataTable = (dsPaymentMethods.PaymentMethodsDataTable) base.Clone();
      methodsDataTable.InitVars();
      return (DataTable) methodsDataTable;
    }

    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsPaymentMethods.PaymentMethodsDataTable();
    }

    internal void InitVars()
    {
      this.columnPayMethodID = this.Columns["PayMethodID"];
      this.columnMethodName = this.Columns["MethodName"];
    }

    private void InitClass()
    {
      this.columnPayMethodID = new DataColumn("PayMethodID", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPayMethodID);
      this.columnMethodName = new DataColumn("MethodName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnMethodName);
      this.columnPayMethodID.AllowDBNull = false;
      this.columnMethodName.AllowDBNull = false;
    }

    public dsPaymentMethods.PaymentMethodsRow NewPaymentMethodsRow()
    {
      return (dsPaymentMethods.PaymentMethodsRow) this.NewRow();
    }

    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsPaymentMethods.PaymentMethodsRow(builder);
    }

    protected override Type GetRowType() => typeof (dsPaymentMethods.PaymentMethodsRow);

    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.PaymentMethodsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPaymentMethods.PaymentMethodsRowChangeEventHandler methodsRowChangedEvent = this.PaymentMethodsRowChangedEvent;
      if (methodsRowChangedEvent == null)
        return;
      methodsRowChangedEvent((object) this, new dsPaymentMethods.PaymentMethodsRowChangeEvent((dsPaymentMethods.PaymentMethodsRow) e.Row, e.Action));
    }

    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.PaymentMethodsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPaymentMethods.PaymentMethodsRowChangeEventHandler rowChangingEvent = this.PaymentMethodsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsPaymentMethods.PaymentMethodsRowChangeEvent((dsPaymentMethods.PaymentMethodsRow) e.Row, e.Action));
    }

    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.PaymentMethodsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPaymentMethods.PaymentMethodsRowChangeEventHandler methodsRowDeletedEvent = this.PaymentMethodsRowDeletedEvent;
      if (methodsRowDeletedEvent == null)
        return;
      methodsRowDeletedEvent((object) this, new dsPaymentMethods.PaymentMethodsRowChangeEvent((dsPaymentMethods.PaymentMethodsRow) e.Row, e.Action));
    }

    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.PaymentMethodsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPaymentMethods.PaymentMethodsRowChangeEventHandler rowDeletingEvent = this.PaymentMethodsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsPaymentMethods.PaymentMethodsRowChangeEvent((dsPaymentMethods.PaymentMethodsRow) e.Row, e.Action));
    }

    public void RemovePaymentMethodsRow(dsPaymentMethods.PaymentMethodsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }
  }

  [DebuggerStepThrough]
  public class PaymentMethodsRow : DataRow
  {
    private dsPaymentMethods.PaymentMethodsDataTable tablePaymentMethods;

    internal PaymentMethodsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablePaymentMethods = (dsPaymentMethods.PaymentMethodsDataTable) this.Table;
    }

    public string PayMethodID
    {
      get => Conversions.ToString(this[this.tablePaymentMethods.PayMethodIDColumn]);
      set => this[this.tablePaymentMethods.PayMethodIDColumn] = (object) value;
    }

    public string MethodName
    {
      get => Conversions.ToString(this[this.tablePaymentMethods.MethodNameColumn]);
      set => this[this.tablePaymentMethods.MethodNameColumn] = (object) value;
    }
  }

  [DebuggerStepThrough]
  public class PaymentMethodsRowChangeEvent : EventArgs
  {
    private dsPaymentMethods.PaymentMethodsRow eventRow;
    private DataRowAction eventAction;

    public PaymentMethodsRowChangeEvent(
      dsPaymentMethods.PaymentMethodsRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    public dsPaymentMethods.PaymentMethodsRow Row => this.eventRow;

    public DataRowAction Action => this.eventAction;
  }
}
