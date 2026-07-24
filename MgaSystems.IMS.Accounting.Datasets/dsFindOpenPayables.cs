// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.AccountingDatasets.dsFindOpenPayables
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
public class dsFindOpenPayables : DataSet
{
  private dsFindOpenPayables.OpenPayablesDataTable tableOpenPayables;

  public dsFindOpenPayables()
  {
    this.InitClass();
    CollectionChangeEventHandler changeEventHandler = new CollectionChangeEventHandler(this.SchemaChanged);
    this.Tables.CollectionChanged += changeEventHandler;
    this.Relations.CollectionChanged += changeEventHandler;
  }

  protected dsFindOpenPayables(SerializationInfo info, StreamingContext context)
  {
    string s = Conversions.ToString(info.GetValue("XmlSchema", typeof (string)));
    if (s != null)
    {
      DataSet dataSet = new DataSet();
      dataSet.ReadXmlSchema((XmlReader) new XmlTextReader((TextReader) new StringReader(s)));
      if (dataSet.Tables[nameof (OpenPayables)] != null)
        this.Tables.Add((DataTable) new dsFindOpenPayables.OpenPayablesDataTable(dataSet.Tables[nameof (OpenPayables)]));
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
  public dsFindOpenPayables.OpenPayablesDataTable OpenPayables => this.tableOpenPayables;

  public override DataSet Clone()
  {
    dsFindOpenPayables findOpenPayables = (dsFindOpenPayables) base.Clone();
    findOpenPayables.InitVars();
    return (DataSet) findOpenPayables;
  }

  protected override bool ShouldSerializeTables() => false;

  protected override bool ShouldSerializeRelations() => false;

  protected override void ReadXmlSerializable(XmlReader reader)
  {
    this.Reset();
    DataSet dataSet = new DataSet();
    int num = (int) dataSet.ReadXml(reader);
    if (dataSet.Tables["OpenPayables"] != null)
      this.Tables.Add((DataTable) new dsFindOpenPayables.OpenPayablesDataTable(dataSet.Tables["OpenPayables"]));
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
    this.tableOpenPayables = (dsFindOpenPayables.OpenPayablesDataTable) this.Tables["OpenPayables"];
    if (this.tableOpenPayables == null)
      return;
    this.tableOpenPayables.InitVars();
  }

  private void InitClass()
  {
    this.DataSetName = nameof (dsFindOpenPayables);
    this.Prefix = "";
    this.Namespace = "http://tempuri.org/dsFindOpenPayables.xsd";
    this.Locale = new CultureInfo("en-US");
    this.CaseSensitive = false;
    this.EnforceConstraints = true;
    this.tableOpenPayables = new dsFindOpenPayables.OpenPayablesDataTable();
    this.Tables.Add((DataTable) this.tableOpenPayables);
  }

  private bool ShouldSerializeOpenPayables() => false;

  private void SchemaChanged(object sender, CollectionChangeEventArgs e)
  {
    if (e.Action != CollectionChangeAction.Remove)
      return;
    this.InitVars();
  }

  public delegate void OpenPayablesRowChangeEventHandler(
    object sender,
    dsFindOpenPayables.OpenPayablesRowChangeEvent e);

  [DebuggerStepThrough]
  public class OpenPayablesDataTable : DataTable, IEnumerable
  {
    private DataColumn columnPayeeGuid;
    private DataColumn columnPayee;
    private DataColumn columnPolicyNumber;
    private DataColumn columnBalance;

    internal OpenPayablesDataTable()
      : base("OpenPayables")
    {
      this.InitClass();
    }

    internal OpenPayablesDataTable(DataTable table)
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

    internal DataColumn PayeeGuidColumn => this.columnPayeeGuid;

    internal DataColumn PayeeColumn => this.columnPayee;

    internal DataColumn PolicyNumberColumn => this.columnPolicyNumber;

    internal DataColumn BalanceColumn => this.columnBalance;

    public dsFindOpenPayables.OpenPayablesRow this[int index]
    {
      get => (dsFindOpenPayables.OpenPayablesRow) this.Rows[index];
    }

    public event dsFindOpenPayables.OpenPayablesRowChangeEventHandler OpenPayablesRowChanged;

    public event dsFindOpenPayables.OpenPayablesRowChangeEventHandler OpenPayablesRowChanging;

    public event dsFindOpenPayables.OpenPayablesRowChangeEventHandler OpenPayablesRowDeleted;

    public event dsFindOpenPayables.OpenPayablesRowChangeEventHandler OpenPayablesRowDeleting;

    public void AddOpenPayablesRow(dsFindOpenPayables.OpenPayablesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    public dsFindOpenPayables.OpenPayablesRow AddOpenPayablesRow(
      string PayeeGuid,
      string Payee,
      string PolicyNumber,
      Decimal Balance)
    {
      dsFindOpenPayables.OpenPayablesRow row = (dsFindOpenPayables.OpenPayablesRow) this.NewRow();
      row.ItemArray = new object[4]
      {
        (object) PayeeGuid,
        (object) Payee,
        (object) PolicyNumber,
        (object) Balance
      };
      this.Rows.Add((DataRow) row);
      return row;
    }

    public IEnumerator GetEnumerator() => this.Rows.GetEnumerator();

    public override DataTable Clone()
    {
      dsFindOpenPayables.OpenPayablesDataTable payablesDataTable = (dsFindOpenPayables.OpenPayablesDataTable) base.Clone();
      payablesDataTable.InitVars();
      return (DataTable) payablesDataTable;
    }

    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsFindOpenPayables.OpenPayablesDataTable();
    }

    internal void InitVars()
    {
      this.columnPayeeGuid = this.Columns["PayeeGuid"];
      this.columnPayee = this.Columns["Payee"];
      this.columnPolicyNumber = this.Columns["PolicyNumber"];
      this.columnBalance = this.Columns["Balance"];
    }

    private void InitClass()
    {
      this.columnPayeeGuid = new DataColumn("PayeeGuid", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPayeeGuid);
      this.columnPayee = new DataColumn("Payee", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPayee);
      this.columnPolicyNumber = new DataColumn("PolicyNumber", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPolicyNumber);
      this.columnBalance = new DataColumn("Balance", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnBalance);
    }

    public dsFindOpenPayables.OpenPayablesRow NewOpenPayablesRow()
    {
      return (dsFindOpenPayables.OpenPayablesRow) this.NewRow();
    }

    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsFindOpenPayables.OpenPayablesRow(builder);
    }

    protected override Type GetRowType() => typeof (dsFindOpenPayables.OpenPayablesRow);

    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.OpenPayablesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsFindOpenPayables.OpenPayablesRowChangeEventHandler payablesRowChangedEvent = this.OpenPayablesRowChangedEvent;
      if (payablesRowChangedEvent == null)
        return;
      payablesRowChangedEvent((object) this, new dsFindOpenPayables.OpenPayablesRowChangeEvent((dsFindOpenPayables.OpenPayablesRow) e.Row, e.Action));
    }

    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.OpenPayablesRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsFindOpenPayables.OpenPayablesRowChangeEventHandler rowChangingEvent = this.OpenPayablesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsFindOpenPayables.OpenPayablesRowChangeEvent((dsFindOpenPayables.OpenPayablesRow) e.Row, e.Action));
    }

    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.OpenPayablesRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsFindOpenPayables.OpenPayablesRowChangeEventHandler payablesRowDeletedEvent = this.OpenPayablesRowDeletedEvent;
      if (payablesRowDeletedEvent == null)
        return;
      payablesRowDeletedEvent((object) this, new dsFindOpenPayables.OpenPayablesRowChangeEvent((dsFindOpenPayables.OpenPayablesRow) e.Row, e.Action));
    }

    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.OpenPayablesRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsFindOpenPayables.OpenPayablesRowChangeEventHandler rowDeletingEvent = this.OpenPayablesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsFindOpenPayables.OpenPayablesRowChangeEvent((dsFindOpenPayables.OpenPayablesRow) e.Row, e.Action));
    }

    public void RemoveOpenPayablesRow(dsFindOpenPayables.OpenPayablesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }
  }

  [DebuggerStepThrough]
  public class OpenPayablesRow : DataRow
  {
    private dsFindOpenPayables.OpenPayablesDataTable tableOpenPayables;

    internal OpenPayablesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableOpenPayables = (dsFindOpenPayables.OpenPayablesDataTable) this.Table;
    }

    public string PayeeGuid
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableOpenPayables.PayeeGuidColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableOpenPayables.PayeeGuidColumn] = (object) value;
    }

    public string Payee
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableOpenPayables.PayeeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableOpenPayables.PayeeColumn] = (object) value;
    }

    public string PolicyNumber
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableOpenPayables.PolicyNumberColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableOpenPayables.PolicyNumberColumn] = (object) value;
    }

    public Decimal Balance
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tableOpenPayables.BalanceColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableOpenPayables.BalanceColumn] = (object) value;
    }

    public bool IsPayeeGuidNull() => this.IsNull(this.tableOpenPayables.PayeeGuidColumn);

    public void SetPayeeGuidNull()
    {
      this[this.tableOpenPayables.PayeeGuidColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsPayeeNull() => this.IsNull(this.tableOpenPayables.PayeeColumn);

    public void SetPayeeNull()
    {
      this[this.tableOpenPayables.PayeeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsPolicyNumberNull() => this.IsNull(this.tableOpenPayables.PolicyNumberColumn);

    public void SetPolicyNumberNull()
    {
      this[this.tableOpenPayables.PolicyNumberColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsBalanceNull() => this.IsNull(this.tableOpenPayables.BalanceColumn);

    public void SetBalanceNull()
    {
      this[this.tableOpenPayables.BalanceColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  [DebuggerStepThrough]
  public class OpenPayablesRowChangeEvent : EventArgs
  {
    private dsFindOpenPayables.OpenPayablesRow eventRow;
    private DataRowAction eventAction;

    public OpenPayablesRowChangeEvent(dsFindOpenPayables.OpenPayablesRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    public dsFindOpenPayables.OpenPayablesRow Row => this.eventRow;

    public DataRowAction Action => this.eventAction;
  }
}
