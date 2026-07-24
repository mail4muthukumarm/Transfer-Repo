// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.AccountingDatasets.dsBankingReceivablesDue
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
public class dsBankingReceivablesDue : DataSet
{
  private dsBankingReceivablesDue.ReceivablesDueDataTable tableReceivablesDue;

  public dsBankingReceivablesDue()
  {
    this.InitClass();
    CollectionChangeEventHandler changeEventHandler = new CollectionChangeEventHandler(this.SchemaChanged);
    this.Tables.CollectionChanged += changeEventHandler;
    this.Relations.CollectionChanged += changeEventHandler;
  }

  protected dsBankingReceivablesDue(SerializationInfo info, StreamingContext context)
  {
    string s = Conversions.ToString(info.GetValue("XmlSchema", typeof (string)));
    if (s != null)
    {
      DataSet dataSet = new DataSet();
      dataSet.ReadXmlSchema((XmlReader) new XmlTextReader((TextReader) new StringReader(s)));
      if (dataSet.Tables[nameof (ReceivablesDue)] != null)
        this.Tables.Add((DataTable) new dsBankingReceivablesDue.ReceivablesDueDataTable(dataSet.Tables[nameof (ReceivablesDue)]));
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
  public dsBankingReceivablesDue.ReceivablesDueDataTable ReceivablesDue => this.tableReceivablesDue;

  public override DataSet Clone()
  {
    dsBankingReceivablesDue bankingReceivablesDue = (dsBankingReceivablesDue) base.Clone();
    bankingReceivablesDue.InitVars();
    return (DataSet) bankingReceivablesDue;
  }

  protected override bool ShouldSerializeTables() => false;

  protected override bool ShouldSerializeRelations() => false;

  protected override void ReadXmlSerializable(XmlReader reader)
  {
    this.Reset();
    DataSet dataSet = new DataSet();
    int num = (int) dataSet.ReadXml(reader);
    if (dataSet.Tables["ReceivablesDue"] != null)
      this.Tables.Add((DataTable) new dsBankingReceivablesDue.ReceivablesDueDataTable(dataSet.Tables["ReceivablesDue"]));
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
    this.tableReceivablesDue = (dsBankingReceivablesDue.ReceivablesDueDataTable) this.Tables["ReceivablesDue"];
    if (this.tableReceivablesDue == null)
      return;
    this.tableReceivablesDue.InitVars();
  }

  private void InitClass()
  {
    this.DataSetName = nameof (dsBankingReceivablesDue);
    this.Prefix = "";
    this.Namespace = "http://tempuri.org/dsBankingReceivablesDue.xsd";
    this.Locale = new CultureInfo("en-US");
    this.CaseSensitive = false;
    this.EnforceConstraints = true;
    this.tableReceivablesDue = new dsBankingReceivablesDue.ReceivablesDueDataTable();
    this.Tables.Add((DataTable) this.tableReceivablesDue);
  }

  private bool ShouldSerializeReceivablesDue() => false;

  private void SchemaChanged(object sender, CollectionChangeEventArgs e)
  {
    if (e.Action != CollectionChangeAction.Remove)
      return;
    this.InitVars();
  }

  public delegate void ReceivablesDueRowChangeEventHandler(
    object sender,
    dsBankingReceivablesDue.ReceivablesDueRowChangeEvent e);

  [DebuggerStepThrough]
  public class ReceivablesDueDataTable : DataTable, IEnumerable
  {
    private DataColumn columninvoicenum;
    private DataColumn columnofficeinvoicenum;
    private DataColumn columnentityname;
    private DataColumn columnamount;

    internal ReceivablesDueDataTable()
      : base("ReceivablesDue")
    {
      this.InitClass();
    }

    internal ReceivablesDueDataTable(DataTable table)
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

    internal DataColumn invoicenumColumn => this.columninvoicenum;

    internal DataColumn officeinvoicenumColumn => this.columnofficeinvoicenum;

    internal DataColumn entitynameColumn => this.columnentityname;

    internal DataColumn amountColumn => this.columnamount;

    public dsBankingReceivablesDue.ReceivablesDueRow this[int index]
    {
      get => (dsBankingReceivablesDue.ReceivablesDueRow) this.Rows[index];
    }

    public event dsBankingReceivablesDue.ReceivablesDueRowChangeEventHandler ReceivablesDueRowChanged;

    public event dsBankingReceivablesDue.ReceivablesDueRowChangeEventHandler ReceivablesDueRowChanging;

    public event dsBankingReceivablesDue.ReceivablesDueRowChangeEventHandler ReceivablesDueRowDeleted;

    public event dsBankingReceivablesDue.ReceivablesDueRowChangeEventHandler ReceivablesDueRowDeleting;

    public void AddReceivablesDueRow(dsBankingReceivablesDue.ReceivablesDueRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    public dsBankingReceivablesDue.ReceivablesDueRow AddReceivablesDueRow(
      int invoicenum,
      string officeinvoicenum,
      string entityname,
      Decimal amount)
    {
      dsBankingReceivablesDue.ReceivablesDueRow row = (dsBankingReceivablesDue.ReceivablesDueRow) this.NewRow();
      row.ItemArray = new object[4]
      {
        (object) invoicenum,
        (object) officeinvoicenum,
        (object) entityname,
        (object) amount
      };
      this.Rows.Add((DataRow) row);
      return row;
    }

    public IEnumerator GetEnumerator() => this.Rows.GetEnumerator();

    public override DataTable Clone()
    {
      dsBankingReceivablesDue.ReceivablesDueDataTable receivablesDueDataTable = (dsBankingReceivablesDue.ReceivablesDueDataTable) base.Clone();
      receivablesDueDataTable.InitVars();
      return (DataTable) receivablesDueDataTable;
    }

    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsBankingReceivablesDue.ReceivablesDueDataTable();
    }

    internal void InitVars()
    {
      this.columninvoicenum = this.Columns["invoicenum"];
      this.columnofficeinvoicenum = this.Columns["officeinvoicenum"];
      this.columnentityname = this.Columns["entityname"];
      this.columnamount = this.Columns["amount"];
    }

    private void InitClass()
    {
      this.columninvoicenum = new DataColumn("invoicenum", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columninvoicenum);
      this.columnofficeinvoicenum = new DataColumn("officeinvoicenum", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnofficeinvoicenum);
      this.columnentityname = new DataColumn("entityname", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnentityname);
      this.columnamount = new DataColumn("amount", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnamount);
    }

    public dsBankingReceivablesDue.ReceivablesDueRow NewReceivablesDueRow()
    {
      return (dsBankingReceivablesDue.ReceivablesDueRow) this.NewRow();
    }

    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsBankingReceivablesDue.ReceivablesDueRow(builder);
    }

    protected override Type GetRowType() => typeof (dsBankingReceivablesDue.ReceivablesDueRow);

    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.ReceivablesDueRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsBankingReceivablesDue.ReceivablesDueRowChangeEventHandler dueRowChangedEvent = this.ReceivablesDueRowChangedEvent;
      if (dueRowChangedEvent == null)
        return;
      dueRowChangedEvent((object) this, new dsBankingReceivablesDue.ReceivablesDueRowChangeEvent((dsBankingReceivablesDue.ReceivablesDueRow) e.Row, e.Action));
    }

    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.ReceivablesDueRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsBankingReceivablesDue.ReceivablesDueRowChangeEventHandler rowChangingEvent = this.ReceivablesDueRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsBankingReceivablesDue.ReceivablesDueRowChangeEvent((dsBankingReceivablesDue.ReceivablesDueRow) e.Row, e.Action));
    }

    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.ReceivablesDueRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsBankingReceivablesDue.ReceivablesDueRowChangeEventHandler dueRowDeletedEvent = this.ReceivablesDueRowDeletedEvent;
      if (dueRowDeletedEvent == null)
        return;
      dueRowDeletedEvent((object) this, new dsBankingReceivablesDue.ReceivablesDueRowChangeEvent((dsBankingReceivablesDue.ReceivablesDueRow) e.Row, e.Action));
    }

    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.ReceivablesDueRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsBankingReceivablesDue.ReceivablesDueRowChangeEventHandler rowDeletingEvent = this.ReceivablesDueRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsBankingReceivablesDue.ReceivablesDueRowChangeEvent((dsBankingReceivablesDue.ReceivablesDueRow) e.Row, e.Action));
    }

    public void RemoveReceivablesDueRow(dsBankingReceivablesDue.ReceivablesDueRow row)
    {
      this.Rows.Remove((DataRow) row);
    }
  }

  [DebuggerStepThrough]
  public class ReceivablesDueRow : DataRow
  {
    private dsBankingReceivablesDue.ReceivablesDueDataTable tableReceivablesDue;

    internal ReceivablesDueRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableReceivablesDue = (dsBankingReceivablesDue.ReceivablesDueDataTable) this.Table;
    }

    public int invoicenum
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tableReceivablesDue.invoicenumColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableReceivablesDue.invoicenumColumn] = (object) value;
    }

    public string officeinvoicenum
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableReceivablesDue.officeinvoicenumColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableReceivablesDue.officeinvoicenumColumn] = (object) value;
    }

    public string entityname
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableReceivablesDue.entitynameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableReceivablesDue.entitynameColumn] = (object) value;
    }

    public Decimal amount
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tableReceivablesDue.amountColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableReceivablesDue.amountColumn] = (object) value;
    }

    public bool IsinvoicenumNull() => this.IsNull(this.tableReceivablesDue.invoicenumColumn);

    public void SetinvoicenumNull()
    {
      this[this.tableReceivablesDue.invoicenumColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsofficeinvoicenumNull()
    {
      return this.IsNull(this.tableReceivablesDue.officeinvoicenumColumn);
    }

    public void SetofficeinvoicenumNull()
    {
      this[this.tableReceivablesDue.officeinvoicenumColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsentitynameNull() => this.IsNull(this.tableReceivablesDue.entitynameColumn);

    public void SetentitynameNull()
    {
      this[this.tableReceivablesDue.entitynameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsamountNull() => this.IsNull(this.tableReceivablesDue.amountColumn);

    public void SetamountNull()
    {
      this[this.tableReceivablesDue.amountColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  [DebuggerStepThrough]
  public class ReceivablesDueRowChangeEvent : EventArgs
  {
    private dsBankingReceivablesDue.ReceivablesDueRow eventRow;
    private DataRowAction eventAction;

    public ReceivablesDueRowChangeEvent(
      dsBankingReceivablesDue.ReceivablesDueRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    public dsBankingReceivablesDue.ReceivablesDueRow Row => this.eventRow;

    public DataRowAction Action => this.eventAction;
  }
}
