// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.AccountingDatasets.dsSearchOpenReceivables
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
public class dsSearchOpenReceivables : DataSet
{
  private dsSearchOpenReceivables.OpenReceivablesDataTable tableOpenReceivables;

  public dsSearchOpenReceivables()
  {
    this.InitClass();
    CollectionChangeEventHandler changeEventHandler = new CollectionChangeEventHandler(this.SchemaChanged);
    this.Tables.CollectionChanged += changeEventHandler;
    this.Relations.CollectionChanged += changeEventHandler;
  }

  protected dsSearchOpenReceivables(SerializationInfo info, StreamingContext context)
  {
    string s = Conversions.ToString(info.GetValue("XmlSchema", typeof (string)));
    if (s != null)
    {
      DataSet dataSet = new DataSet();
      dataSet.ReadXmlSchema((XmlReader) new XmlTextReader((TextReader) new StringReader(s)));
      if (dataSet.Tables[nameof (OpenReceivables)] != null)
        this.Tables.Add((DataTable) new dsSearchOpenReceivables.OpenReceivablesDataTable(dataSet.Tables[nameof (OpenReceivables)]));
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
  public dsSearchOpenReceivables.OpenReceivablesDataTable OpenReceivables
  {
    get => this.tableOpenReceivables;
  }

  public override DataSet Clone()
  {
    dsSearchOpenReceivables searchOpenReceivables = (dsSearchOpenReceivables) base.Clone();
    searchOpenReceivables.InitVars();
    return (DataSet) searchOpenReceivables;
  }

  protected override bool ShouldSerializeTables() => false;

  protected override bool ShouldSerializeRelations() => false;

  protected override void ReadXmlSerializable(XmlReader reader)
  {
    this.Reset();
    DataSet dataSet = new DataSet();
    int num = (int) dataSet.ReadXml(reader);
    if (dataSet.Tables["OpenReceivables"] != null)
      this.Tables.Add((DataTable) new dsSearchOpenReceivables.OpenReceivablesDataTable(dataSet.Tables["OpenReceivables"]));
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
    this.tableOpenReceivables = (dsSearchOpenReceivables.OpenReceivablesDataTable) this.Tables["OpenReceivables"];
    if (this.tableOpenReceivables == null)
      return;
    this.tableOpenReceivables.InitVars();
  }

  private void InitClass()
  {
    this.DataSetName = nameof (dsSearchOpenReceivables);
    this.Prefix = "";
    this.Namespace = "http://tempuri.org/dsSearchOpenReceivables.xsd";
    this.Locale = new CultureInfo("en-US");
    this.CaseSensitive = false;
    this.EnforceConstraints = true;
    this.tableOpenReceivables = new dsSearchOpenReceivables.OpenReceivablesDataTable();
    this.Tables.Add((DataTable) this.tableOpenReceivables);
  }

  private bool ShouldSerializeOpenReceivables() => false;

  private void SchemaChanged(object sender, CollectionChangeEventArgs e)
  {
    if (e.Action != CollectionChangeAction.Remove)
      return;
    this.InitVars();
  }

  public delegate void OpenReceivablesRowChangeEventHandler(
    object sender,
    dsSearchOpenReceivables.OpenReceivablesRowChangeEvent e);

  [DebuggerStepThrough]
  public class OpenReceivablesDataTable : DataTable, IEnumerable
  {
    private DataColumn columnRemitterGuid;
    private DataColumn columnRemitter;
    private DataColumn columnPolicyNumber;
    private DataColumn columnBalance;

    internal OpenReceivablesDataTable()
      : base("OpenReceivables")
    {
      this.InitClass();
    }

    internal OpenReceivablesDataTable(DataTable table)
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

    internal DataColumn RemitterGuidColumn => this.columnRemitterGuid;

    internal DataColumn RemitterColumn => this.columnRemitter;

    internal DataColumn PolicyNumberColumn => this.columnPolicyNumber;

    internal DataColumn BalanceColumn => this.columnBalance;

    public dsSearchOpenReceivables.OpenReceivablesRow this[int index]
    {
      get => (dsSearchOpenReceivables.OpenReceivablesRow) this.Rows[index];
    }

    public event dsSearchOpenReceivables.OpenReceivablesRowChangeEventHandler OpenReceivablesRowChanged;

    public event dsSearchOpenReceivables.OpenReceivablesRowChangeEventHandler OpenReceivablesRowChanging;

    public event dsSearchOpenReceivables.OpenReceivablesRowChangeEventHandler OpenReceivablesRowDeleted;

    public event dsSearchOpenReceivables.OpenReceivablesRowChangeEventHandler OpenReceivablesRowDeleting;

    public void AddOpenReceivablesRow(dsSearchOpenReceivables.OpenReceivablesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    public dsSearchOpenReceivables.OpenReceivablesRow AddOpenReceivablesRow(
      string RemitterGuid,
      string Remitter,
      string PolicyNumber,
      Decimal Balance)
    {
      dsSearchOpenReceivables.OpenReceivablesRow row = (dsSearchOpenReceivables.OpenReceivablesRow) this.NewRow();
      row.ItemArray = new object[4]
      {
        (object) RemitterGuid,
        (object) Remitter,
        (object) PolicyNumber,
        (object) Balance
      };
      this.Rows.Add((DataRow) row);
      return row;
    }

    public IEnumerator GetEnumerator() => this.Rows.GetEnumerator();

    public override DataTable Clone()
    {
      dsSearchOpenReceivables.OpenReceivablesDataTable receivablesDataTable = (dsSearchOpenReceivables.OpenReceivablesDataTable) base.Clone();
      receivablesDataTable.InitVars();
      return (DataTable) receivablesDataTable;
    }

    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsSearchOpenReceivables.OpenReceivablesDataTable();
    }

    internal void InitVars()
    {
      this.columnRemitterGuid = this.Columns["RemitterGuid"];
      this.columnRemitter = this.Columns["Remitter"];
      this.columnPolicyNumber = this.Columns["PolicyNumber"];
      this.columnBalance = this.Columns["Balance"];
    }

    private void InitClass()
    {
      this.columnRemitterGuid = new DataColumn("RemitterGuid", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnRemitterGuid);
      this.columnRemitter = new DataColumn("Remitter", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnRemitter);
      this.columnPolicyNumber = new DataColumn("PolicyNumber", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPolicyNumber);
      this.columnBalance = new DataColumn("Balance", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnBalance);
    }

    public dsSearchOpenReceivables.OpenReceivablesRow NewOpenReceivablesRow()
    {
      return (dsSearchOpenReceivables.OpenReceivablesRow) this.NewRow();
    }

    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsSearchOpenReceivables.OpenReceivablesRow(builder);
    }

    protected override Type GetRowType() => typeof (dsSearchOpenReceivables.OpenReceivablesRow);

    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.OpenReceivablesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsSearchOpenReceivables.OpenReceivablesRowChangeEventHandler receivablesRowChangedEvent = this.OpenReceivablesRowChangedEvent;
      if (receivablesRowChangedEvent == null)
        return;
      receivablesRowChangedEvent((object) this, new dsSearchOpenReceivables.OpenReceivablesRowChangeEvent((dsSearchOpenReceivables.OpenReceivablesRow) e.Row, e.Action));
    }

    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.OpenReceivablesRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsSearchOpenReceivables.OpenReceivablesRowChangeEventHandler rowChangingEvent = this.OpenReceivablesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsSearchOpenReceivables.OpenReceivablesRowChangeEvent((dsSearchOpenReceivables.OpenReceivablesRow) e.Row, e.Action));
    }

    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.OpenReceivablesRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsSearchOpenReceivables.OpenReceivablesRowChangeEventHandler receivablesRowDeletedEvent = this.OpenReceivablesRowDeletedEvent;
      if (receivablesRowDeletedEvent == null)
        return;
      receivablesRowDeletedEvent((object) this, new dsSearchOpenReceivables.OpenReceivablesRowChangeEvent((dsSearchOpenReceivables.OpenReceivablesRow) e.Row, e.Action));
    }

    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.OpenReceivablesRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsSearchOpenReceivables.OpenReceivablesRowChangeEventHandler rowDeletingEvent = this.OpenReceivablesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsSearchOpenReceivables.OpenReceivablesRowChangeEvent((dsSearchOpenReceivables.OpenReceivablesRow) e.Row, e.Action));
    }

    public void RemoveOpenReceivablesRow(dsSearchOpenReceivables.OpenReceivablesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }
  }

  [DebuggerStepThrough]
  public class OpenReceivablesRow : DataRow
  {
    private dsSearchOpenReceivables.OpenReceivablesDataTable tableOpenReceivables;

    internal OpenReceivablesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableOpenReceivables = (dsSearchOpenReceivables.OpenReceivablesDataTable) this.Table;
    }

    public string RemitterGuid
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableOpenReceivables.RemitterGuidColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableOpenReceivables.RemitterGuidColumn] = (object) value;
    }

    public string Remitter
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableOpenReceivables.RemitterColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableOpenReceivables.RemitterColumn] = (object) value;
    }

    public string PolicyNumber
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableOpenReceivables.PolicyNumberColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableOpenReceivables.PolicyNumberColumn] = (object) value;
    }

    public Decimal Balance
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tableOpenReceivables.BalanceColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableOpenReceivables.BalanceColumn] = (object) value;
    }

    public bool IsRemitterGuidNull() => this.IsNull(this.tableOpenReceivables.RemitterGuidColumn);

    public void SetRemitterGuidNull()
    {
      this[this.tableOpenReceivables.RemitterGuidColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsRemitterNull() => this.IsNull(this.tableOpenReceivables.RemitterColumn);

    public void SetRemitterNull()
    {
      this[this.tableOpenReceivables.RemitterColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsPolicyNumberNull() => this.IsNull(this.tableOpenReceivables.PolicyNumberColumn);

    public void SetPolicyNumberNull()
    {
      this[this.tableOpenReceivables.PolicyNumberColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsBalanceNull() => this.IsNull(this.tableOpenReceivables.BalanceColumn);

    public void SetBalanceNull()
    {
      this[this.tableOpenReceivables.BalanceColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  [DebuggerStepThrough]
  public class OpenReceivablesRowChangeEvent : EventArgs
  {
    private dsSearchOpenReceivables.OpenReceivablesRow eventRow;
    private DataRowAction eventAction;

    public OpenReceivablesRowChangeEvent(
      dsSearchOpenReceivables.OpenReceivablesRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    public dsSearchOpenReceivables.OpenReceivablesRow Row => this.eventRow;

    public DataRowAction Action => this.eventAction;
  }
}
