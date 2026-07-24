// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.AccountingDatasets.dsBankTransfers
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
public class dsBankTransfers : DataSet
{
  private dsBankTransfers.TransfersDataTable tableTransfers;

  public dsBankTransfers()
  {
    this.InitClass();
    CollectionChangeEventHandler changeEventHandler = new CollectionChangeEventHandler(this.SchemaChanged);
    this.Tables.CollectionChanged += changeEventHandler;
    this.Relations.CollectionChanged += changeEventHandler;
  }

  protected dsBankTransfers(SerializationInfo info, StreamingContext context)
  {
    string s = Conversions.ToString(info.GetValue("XmlSchema", typeof (string)));
    if (s != null)
    {
      DataSet dataSet = new DataSet();
      dataSet.ReadXmlSchema((XmlReader) new XmlTextReader((TextReader) new StringReader(s)));
      if (dataSet.Tables[nameof (Transfers)] != null)
        this.Tables.Add((DataTable) new dsBankTransfers.TransfersDataTable(dataSet.Tables[nameof (Transfers)]));
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
  public dsBankTransfers.TransfersDataTable Transfers => this.tableTransfers;

  public override DataSet Clone()
  {
    dsBankTransfers dsBankTransfers = (dsBankTransfers) base.Clone();
    dsBankTransfers.InitVars();
    return (DataSet) dsBankTransfers;
  }

  protected override bool ShouldSerializeTables() => false;

  protected override bool ShouldSerializeRelations() => false;

  protected override void ReadXmlSerializable(XmlReader reader)
  {
    this.Reset();
    DataSet dataSet = new DataSet();
    int num = (int) dataSet.ReadXml(reader);
    if (dataSet.Tables["Transfers"] != null)
      this.Tables.Add((DataTable) new dsBankTransfers.TransfersDataTable(dataSet.Tables["Transfers"]));
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
    this.tableTransfers = (dsBankTransfers.TransfersDataTable) this.Tables["Transfers"];
    if (this.tableTransfers == null)
      return;
    this.tableTransfers.InitVars();
  }

  private void InitClass()
  {
    this.DataSetName = nameof (dsBankTransfers);
    this.Prefix = "";
    this.Namespace = "http://tempuri.org/dsBankTransfers.xsd";
    this.Locale = new CultureInfo("en-US");
    this.CaseSensitive = false;
    this.EnforceConstraints = true;
    this.tableTransfers = new dsBankTransfers.TransfersDataTable();
    this.Tables.Add((DataTable) this.tableTransfers);
  }

  private bool ShouldSerializeTransfers() => false;

  private void SchemaChanged(object sender, CollectionChangeEventArgs e)
  {
    if (e.Action != CollectionChangeAction.Remove)
      return;
    this.InitVars();
  }

  public delegate void TransfersRowChangeEventHandler(
    object sender,
    dsBankTransfers.TransfersRowChangeEvent e);

  [DebuggerStepThrough]
  public class TransfersDataTable : DataTable, IEnumerable
  {
    private DataColumn columntransactNum;
    private DataColumn columntransferDate;
    private DataColumn columntransferDescription;
    private DataColumn columnamount;
    private DataColumn columnreconciled;

    internal TransfersDataTable()
      : base("Transfers")
    {
      this.InitClass();
    }

    internal TransfersDataTable(DataTable table)
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

    internal DataColumn transferDateColumn => this.columntransferDate;

    internal DataColumn transferDescriptionColumn => this.columntransferDescription;

    internal DataColumn amountColumn => this.columnamount;

    internal DataColumn reconciledColumn => this.columnreconciled;

    public dsBankTransfers.TransfersRow this[int index]
    {
      get => (dsBankTransfers.TransfersRow) this.Rows[index];
    }

    public event dsBankTransfers.TransfersRowChangeEventHandler TransfersRowChanged;

    public event dsBankTransfers.TransfersRowChangeEventHandler TransfersRowChanging;

    public event dsBankTransfers.TransfersRowChangeEventHandler TransfersRowDeleted;

    public event dsBankTransfers.TransfersRowChangeEventHandler TransfersRowDeleting;

    public void AddTransfersRow(dsBankTransfers.TransfersRow row) => this.Rows.Add((DataRow) row);

    public dsBankTransfers.TransfersRow AddTransfersRow(
      int transactNum,
      DateTime transferDate,
      string transferDescription,
      Decimal amount,
      string reconciled)
    {
      dsBankTransfers.TransfersRow row = (dsBankTransfers.TransfersRow) this.NewRow();
      row.ItemArray = new object[5]
      {
        (object) transactNum,
        (object) transferDate,
        (object) transferDescription,
        (object) amount,
        (object) reconciled
      };
      this.Rows.Add((DataRow) row);
      return row;
    }

    public IEnumerator GetEnumerator() => this.Rows.GetEnumerator();

    public override DataTable Clone()
    {
      dsBankTransfers.TransfersDataTable transfersDataTable = (dsBankTransfers.TransfersDataTable) base.Clone();
      transfersDataTable.InitVars();
      return (DataTable) transfersDataTable;
    }

    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsBankTransfers.TransfersDataTable();
    }

    internal void InitVars()
    {
      this.columntransactNum = this.Columns["transactNum"];
      this.columntransferDate = this.Columns["transferDate"];
      this.columntransferDescription = this.Columns["transferDescription"];
      this.columnamount = this.Columns["amount"];
      this.columnreconciled = this.Columns["reconciled"];
    }

    private void InitClass()
    {
      this.columntransactNum = new DataColumn("transactNum", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columntransactNum);
      this.columntransferDate = new DataColumn("transferDate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columntransferDate);
      this.columntransferDescription = new DataColumn("transferDescription", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columntransferDescription);
      this.columnamount = new DataColumn("amount", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnamount);
      this.columnreconciled = new DataColumn("reconciled", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnreconciled);
    }

    public dsBankTransfers.TransfersRow NewTransfersRow()
    {
      return (dsBankTransfers.TransfersRow) this.NewRow();
    }

    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsBankTransfers.TransfersRow(builder);
    }

    protected override Type GetRowType() => typeof (dsBankTransfers.TransfersRow);

    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.TransfersRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsBankTransfers.TransfersRowChangeEventHandler transfersRowChangedEvent = this.TransfersRowChangedEvent;
      if (transfersRowChangedEvent == null)
        return;
      transfersRowChangedEvent((object) this, new dsBankTransfers.TransfersRowChangeEvent((dsBankTransfers.TransfersRow) e.Row, e.Action));
    }

    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.TransfersRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsBankTransfers.TransfersRowChangeEventHandler rowChangingEvent = this.TransfersRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsBankTransfers.TransfersRowChangeEvent((dsBankTransfers.TransfersRow) e.Row, e.Action));
    }

    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.TransfersRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsBankTransfers.TransfersRowChangeEventHandler transfersRowDeletedEvent = this.TransfersRowDeletedEvent;
      if (transfersRowDeletedEvent == null)
        return;
      transfersRowDeletedEvent((object) this, new dsBankTransfers.TransfersRowChangeEvent((dsBankTransfers.TransfersRow) e.Row, e.Action));
    }

    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.TransfersRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsBankTransfers.TransfersRowChangeEventHandler rowDeletingEvent = this.TransfersRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsBankTransfers.TransfersRowChangeEvent((dsBankTransfers.TransfersRow) e.Row, e.Action));
    }

    public void RemoveTransfersRow(dsBankTransfers.TransfersRow row)
    {
      this.Rows.Remove((DataRow) row);
    }
  }

  [DebuggerStepThrough]
  public class TransfersRow : DataRow
  {
    private dsBankTransfers.TransfersDataTable tableTransfers;

    internal TransfersRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableTransfers = (dsBankTransfers.TransfersDataTable) this.Table;
    }

    public int transactNum
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tableTransfers.transactNumColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableTransfers.transactNumColumn] = (object) value;
    }

    public DateTime transferDate
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tableTransfers.transferDateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableTransfers.transferDateColumn] = (object) value;
    }

    public string transferDescription
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableTransfers.transferDescriptionColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableTransfers.transferDescriptionColumn] = (object) value;
    }

    public Decimal amount
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tableTransfers.amountColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableTransfers.amountColumn] = (object) value;
    }

    public string reconciled
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableTransfers.reconciledColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableTransfers.reconciledColumn] = (object) value;
    }

    public bool IstransactNumNull() => this.IsNull(this.tableTransfers.transactNumColumn);

    public void SettransactNumNull()
    {
      this[this.tableTransfers.transactNumColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IstransferDateNull() => this.IsNull(this.tableTransfers.transferDateColumn);

    public void SettransferDateNull()
    {
      this[this.tableTransfers.transferDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IstransferDescriptionNull()
    {
      return this.IsNull(this.tableTransfers.transferDescriptionColumn);
    }

    public void SettransferDescriptionNull()
    {
      this[this.tableTransfers.transferDescriptionColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsamountNull() => this.IsNull(this.tableTransfers.amountColumn);

    public void SetamountNull()
    {
      this[this.tableTransfers.amountColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsreconciledNull() => this.IsNull(this.tableTransfers.reconciledColumn);

    public void SetreconciledNull()
    {
      this[this.tableTransfers.reconciledColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  [DebuggerStepThrough]
  public class TransfersRowChangeEvent : EventArgs
  {
    private dsBankTransfers.TransfersRow eventRow;
    private DataRowAction eventAction;

    public TransfersRowChangeEvent(dsBankTransfers.TransfersRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    public dsBankTransfers.TransfersRow Row => this.eventRow;

    public DataRowAction Action => this.eventAction;
  }
}
