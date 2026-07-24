// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.AccountingDatasets.dsQuoteStatusReasons
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
public class dsQuoteStatusReasons : DataSet
{
  private dsQuoteStatusReasons.ReasonsDataTable tableReasons;

  public dsQuoteStatusReasons()
  {
    this.InitClass();
    CollectionChangeEventHandler changeEventHandler = new CollectionChangeEventHandler(this.SchemaChanged);
    this.Tables.CollectionChanged += changeEventHandler;
    this.Relations.CollectionChanged += changeEventHandler;
  }

  protected dsQuoteStatusReasons(SerializationInfo info, StreamingContext context)
  {
    string s = Conversions.ToString(info.GetValue("XmlSchema", typeof (string)));
    if (s != null)
    {
      DataSet dataSet = new DataSet();
      dataSet.ReadXmlSchema((XmlReader) new XmlTextReader((TextReader) new StringReader(s)));
      if (dataSet.Tables[nameof (Reasons)] != null)
        this.Tables.Add((DataTable) new dsQuoteStatusReasons.ReasonsDataTable(dataSet.Tables[nameof (Reasons)]));
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
  public dsQuoteStatusReasons.ReasonsDataTable Reasons => this.tableReasons;

  public override DataSet Clone()
  {
    dsQuoteStatusReasons quoteStatusReasons = (dsQuoteStatusReasons) base.Clone();
    quoteStatusReasons.InitVars();
    return (DataSet) quoteStatusReasons;
  }

  protected override bool ShouldSerializeTables() => false;

  protected override bool ShouldSerializeRelations() => false;

  protected override void ReadXmlSerializable(XmlReader reader)
  {
    this.Reset();
    DataSet dataSet = new DataSet();
    int num = (int) dataSet.ReadXml(reader);
    if (dataSet.Tables["Reasons"] != null)
      this.Tables.Add((DataTable) new dsQuoteStatusReasons.ReasonsDataTable(dataSet.Tables["Reasons"]));
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
    this.tableReasons = (dsQuoteStatusReasons.ReasonsDataTable) this.Tables["Reasons"];
    if (this.tableReasons == null)
      return;
    this.tableReasons.InitVars();
  }

  private void InitClass()
  {
    this.DataSetName = nameof (dsQuoteStatusReasons);
    this.Prefix = "";
    this.Namespace = "http://tempuri.org/dsQuoteStatusReasons.xsd";
    this.Locale = new CultureInfo("en-US");
    this.CaseSensitive = false;
    this.EnforceConstraints = true;
    this.tableReasons = new dsQuoteStatusReasons.ReasonsDataTable();
    this.Tables.Add((DataTable) this.tableReasons);
  }

  private bool ShouldSerializeReasons() => false;

  private void SchemaChanged(object sender, CollectionChangeEventArgs e)
  {
    if (e.Action != CollectionChangeAction.Remove)
      return;
    this.InitVars();
  }

  public delegate void ReasonsRowChangeEventHandler(
    object sender,
    dsQuoteStatusReasons.ReasonsRowChangeEvent e);

  [DebuggerStepThrough]
  public class ReasonsDataTable : DataTable, IEnumerable
  {
    private DataColumn columnID;
    private DataColumn columnReason;

    internal ReasonsDataTable()
      : base("Reasons")
    {
      this.InitClass();
    }

    internal ReasonsDataTable(DataTable table)
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

    internal DataColumn IDColumn => this.columnID;

    internal DataColumn ReasonColumn => this.columnReason;

    public dsQuoteStatusReasons.ReasonsRow this[int index]
    {
      get => (dsQuoteStatusReasons.ReasonsRow) this.Rows[index];
    }

    public event dsQuoteStatusReasons.ReasonsRowChangeEventHandler ReasonsRowChanged;

    public event dsQuoteStatusReasons.ReasonsRowChangeEventHandler ReasonsRowChanging;

    public event dsQuoteStatusReasons.ReasonsRowChangeEventHandler ReasonsRowDeleted;

    public event dsQuoteStatusReasons.ReasonsRowChangeEventHandler ReasonsRowDeleting;

    public void AddReasonsRow(dsQuoteStatusReasons.ReasonsRow row) => this.Rows.Add((DataRow) row);

    public dsQuoteStatusReasons.ReasonsRow AddReasonsRow(int ID, string Reason)
    {
      dsQuoteStatusReasons.ReasonsRow row = (dsQuoteStatusReasons.ReasonsRow) this.NewRow();
      row.ItemArray = new object[2]
      {
        (object) ID,
        (object) Reason
      };
      this.Rows.Add((DataRow) row);
      return row;
    }

    public IEnumerator GetEnumerator() => this.Rows.GetEnumerator();

    public override DataTable Clone()
    {
      dsQuoteStatusReasons.ReasonsDataTable reasonsDataTable = (dsQuoteStatusReasons.ReasonsDataTable) base.Clone();
      reasonsDataTable.InitVars();
      return (DataTable) reasonsDataTable;
    }

    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsQuoteStatusReasons.ReasonsDataTable();
    }

    internal void InitVars()
    {
      this.columnID = this.Columns["ID"];
      this.columnReason = this.Columns["Reason"];
    }

    private void InitClass()
    {
      this.columnID = new DataColumn("ID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnID);
      this.columnReason = new DataColumn("Reason", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnReason);
    }

    public dsQuoteStatusReasons.ReasonsRow NewReasonsRow()
    {
      return (dsQuoteStatusReasons.ReasonsRow) this.NewRow();
    }

    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsQuoteStatusReasons.ReasonsRow(builder);
    }

    protected override Type GetRowType() => typeof (dsQuoteStatusReasons.ReasonsRow);

    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.ReasonsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsQuoteStatusReasons.ReasonsRowChangeEventHandler reasonsRowChangedEvent = this.ReasonsRowChangedEvent;
      if (reasonsRowChangedEvent == null)
        return;
      reasonsRowChangedEvent((object) this, new dsQuoteStatusReasons.ReasonsRowChangeEvent((dsQuoteStatusReasons.ReasonsRow) e.Row, e.Action));
    }

    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.ReasonsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsQuoteStatusReasons.ReasonsRowChangeEventHandler rowChangingEvent = this.ReasonsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsQuoteStatusReasons.ReasonsRowChangeEvent((dsQuoteStatusReasons.ReasonsRow) e.Row, e.Action));
    }

    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.ReasonsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsQuoteStatusReasons.ReasonsRowChangeEventHandler reasonsRowDeletedEvent = this.ReasonsRowDeletedEvent;
      if (reasonsRowDeletedEvent == null)
        return;
      reasonsRowDeletedEvent((object) this, new dsQuoteStatusReasons.ReasonsRowChangeEvent((dsQuoteStatusReasons.ReasonsRow) e.Row, e.Action));
    }

    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.ReasonsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsQuoteStatusReasons.ReasonsRowChangeEventHandler rowDeletingEvent = this.ReasonsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsQuoteStatusReasons.ReasonsRowChangeEvent((dsQuoteStatusReasons.ReasonsRow) e.Row, e.Action));
    }

    public void RemoveReasonsRow(dsQuoteStatusReasons.ReasonsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }
  }

  [DebuggerStepThrough]
  public class ReasonsRow : DataRow
  {
    private dsQuoteStatusReasons.ReasonsDataTable tableReasons;

    internal ReasonsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableReasons = (dsQuoteStatusReasons.ReasonsDataTable) this.Table;
    }

    public int ID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tableReasons.IDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableReasons.IDColumn] = (object) value;
    }

    public string Reason
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableReasons.ReasonColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableReasons.ReasonColumn] = (object) value;
    }

    public bool IsIDNull() => this.IsNull(this.tableReasons.IDColumn);

    public void SetIDNull()
    {
      this[this.tableReasons.IDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsReasonNull() => this.IsNull(this.tableReasons.ReasonColumn);

    public void SetReasonNull()
    {
      this[this.tableReasons.ReasonColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  [DebuggerStepThrough]
  public class ReasonsRowChangeEvent : EventArgs
  {
    private dsQuoteStatusReasons.ReasonsRow eventRow;
    private DataRowAction eventAction;

    public ReasonsRowChangeEvent(dsQuoteStatusReasons.ReasonsRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    public dsQuoteStatusReasons.ReasonsRow Row => this.eventRow;

    public DataRowAction Action => this.eventAction;
  }
}
