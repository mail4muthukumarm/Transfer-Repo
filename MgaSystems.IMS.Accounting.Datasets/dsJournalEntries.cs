// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.AccountingDatasets.dsJournalEntries
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
public class dsJournalEntries : DataSet
{
  private dsJournalEntries.LedgerEntriesDataTable tableLedgerEntries;

  public dsJournalEntries()
  {
    this.InitClass();
    CollectionChangeEventHandler changeEventHandler = new CollectionChangeEventHandler(this.SchemaChanged);
    this.Tables.CollectionChanged += changeEventHandler;
    this.Relations.CollectionChanged += changeEventHandler;
  }

  protected dsJournalEntries(SerializationInfo info, StreamingContext context)
  {
    string s = Conversions.ToString(info.GetValue("XmlSchema", typeof (string)));
    if (s != null)
    {
      DataSet dataSet = new DataSet();
      dataSet.ReadXmlSchema((XmlReader) new XmlTextReader((TextReader) new StringReader(s)));
      if (dataSet.Tables[nameof (LedgerEntries)] != null)
        this.Tables.Add((DataTable) new dsJournalEntries.LedgerEntriesDataTable(dataSet.Tables[nameof (LedgerEntries)]));
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
  public dsJournalEntries.LedgerEntriesDataTable LedgerEntries => this.tableLedgerEntries;

  public override DataSet Clone()
  {
    dsJournalEntries dsJournalEntries = (dsJournalEntries) base.Clone();
    dsJournalEntries.InitVars();
    return (DataSet) dsJournalEntries;
  }

  protected override bool ShouldSerializeTables() => false;

  protected override bool ShouldSerializeRelations() => false;

  protected override void ReadXmlSerializable(XmlReader reader)
  {
    this.Reset();
    DataSet dataSet = new DataSet();
    int num = (int) dataSet.ReadXml(reader);
    if (dataSet.Tables["LedgerEntries"] != null)
      this.Tables.Add((DataTable) new dsJournalEntries.LedgerEntriesDataTable(dataSet.Tables["LedgerEntries"]));
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
    this.tableLedgerEntries = (dsJournalEntries.LedgerEntriesDataTable) this.Tables["LedgerEntries"];
    if (this.tableLedgerEntries == null)
      return;
    this.tableLedgerEntries.InitVars();
  }

  private void InitClass()
  {
    this.DataSetName = nameof (dsJournalEntries);
    this.Prefix = "";
    this.Namespace = "http://tempuri.org/dsJournalEntries.xsd";
    this.Locale = new CultureInfo("en-US");
    this.CaseSensitive = false;
    this.EnforceConstraints = true;
    this.tableLedgerEntries = new dsJournalEntries.LedgerEntriesDataTable();
    this.Tables.Add((DataTable) this.tableLedgerEntries);
  }

  private bool ShouldSerializeLedgerEntries() => false;

  private void SchemaChanged(object sender, CollectionChangeEventArgs e)
  {
    if (e.Action != CollectionChangeAction.Remove)
      return;
    this.InitVars();
  }

  public delegate void LedgerEntriesRowChangeEventHandler(
    object sender,
    dsJournalEntries.LedgerEntriesRowChangeEvent e);

  [DebuggerStepThrough]
  public class LedgerEntriesDataTable : DataTable, IEnumerable
  {
    private DataColumn columnGLAcctId;
    private DataColumn columnAccountType;
    private DataColumn columnAccountFullName;
    private DataColumn columnAmount;

    internal LedgerEntriesDataTable()
      : base("LedgerEntries")
    {
      this.InitClass();
    }

    internal LedgerEntriesDataTable(DataTable table)
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

    internal DataColumn GLAcctIdColumn => this.columnGLAcctId;

    internal DataColumn AccountTypeColumn => this.columnAccountType;

    internal DataColumn AccountFullNameColumn => this.columnAccountFullName;

    internal DataColumn AmountColumn => this.columnAmount;

    public dsJournalEntries.LedgerEntriesRow this[int index]
    {
      get => (dsJournalEntries.LedgerEntriesRow) this.Rows[index];
    }

    public event dsJournalEntries.LedgerEntriesRowChangeEventHandler LedgerEntriesRowChanged;

    public event dsJournalEntries.LedgerEntriesRowChangeEventHandler LedgerEntriesRowChanging;

    public event dsJournalEntries.LedgerEntriesRowChangeEventHandler LedgerEntriesRowDeleted;

    public event dsJournalEntries.LedgerEntriesRowChangeEventHandler LedgerEntriesRowDeleting;

    public void AddLedgerEntriesRow(dsJournalEntries.LedgerEntriesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    public dsJournalEntries.LedgerEntriesRow AddLedgerEntriesRow(
      int GLAcctId,
      string AccountType,
      string AccountFullName,
      Decimal Amount)
    {
      dsJournalEntries.LedgerEntriesRow row = (dsJournalEntries.LedgerEntriesRow) this.NewRow();
      row.ItemArray = new object[4]
      {
        (object) GLAcctId,
        (object) AccountType,
        (object) AccountFullName,
        (object) Amount
      };
      this.Rows.Add((DataRow) row);
      return row;
    }

    public IEnumerator GetEnumerator() => this.Rows.GetEnumerator();

    public override DataTable Clone()
    {
      dsJournalEntries.LedgerEntriesDataTable entriesDataTable = (dsJournalEntries.LedgerEntriesDataTable) base.Clone();
      entriesDataTable.InitVars();
      return (DataTable) entriesDataTable;
    }

    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsJournalEntries.LedgerEntriesDataTable();
    }

    internal void InitVars()
    {
      this.columnGLAcctId = this.Columns["GLAcctId"];
      this.columnAccountType = this.Columns["AccountType"];
      this.columnAccountFullName = this.Columns["AccountFullName"];
      this.columnAmount = this.Columns["Amount"];
    }

    private void InitClass()
    {
      this.columnGLAcctId = new DataColumn("GLAcctId", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnGLAcctId);
      this.columnAccountType = new DataColumn("AccountType", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAccountType);
      this.columnAccountFullName = new DataColumn("AccountFullName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAccountFullName);
      this.columnAmount = new DataColumn("Amount", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAmount);
    }

    public dsJournalEntries.LedgerEntriesRow NewLedgerEntriesRow()
    {
      return (dsJournalEntries.LedgerEntriesRow) this.NewRow();
    }

    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsJournalEntries.LedgerEntriesRow(builder);
    }

    protected override Type GetRowType() => typeof (dsJournalEntries.LedgerEntriesRow);

    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.LedgerEntriesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsJournalEntries.LedgerEntriesRowChangeEventHandler entriesRowChangedEvent = this.LedgerEntriesRowChangedEvent;
      if (entriesRowChangedEvent == null)
        return;
      entriesRowChangedEvent((object) this, new dsJournalEntries.LedgerEntriesRowChangeEvent((dsJournalEntries.LedgerEntriesRow) e.Row, e.Action));
    }

    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.LedgerEntriesRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsJournalEntries.LedgerEntriesRowChangeEventHandler rowChangingEvent = this.LedgerEntriesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsJournalEntries.LedgerEntriesRowChangeEvent((dsJournalEntries.LedgerEntriesRow) e.Row, e.Action));
    }

    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.LedgerEntriesRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsJournalEntries.LedgerEntriesRowChangeEventHandler entriesRowDeletedEvent = this.LedgerEntriesRowDeletedEvent;
      if (entriesRowDeletedEvent == null)
        return;
      entriesRowDeletedEvent((object) this, new dsJournalEntries.LedgerEntriesRowChangeEvent((dsJournalEntries.LedgerEntriesRow) e.Row, e.Action));
    }

    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.LedgerEntriesRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsJournalEntries.LedgerEntriesRowChangeEventHandler rowDeletingEvent = this.LedgerEntriesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsJournalEntries.LedgerEntriesRowChangeEvent((dsJournalEntries.LedgerEntriesRow) e.Row, e.Action));
    }

    public void RemoveLedgerEntriesRow(dsJournalEntries.LedgerEntriesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }
  }

  [DebuggerStepThrough]
  public class LedgerEntriesRow : DataRow
  {
    private dsJournalEntries.LedgerEntriesDataTable tableLedgerEntries;

    internal LedgerEntriesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableLedgerEntries = (dsJournalEntries.LedgerEntriesDataTable) this.Table;
    }

    public int GLAcctId
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tableLedgerEntries.GLAcctIdColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableLedgerEntries.GLAcctIdColumn] = (object) value;
    }

    public string AccountType
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableLedgerEntries.AccountTypeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableLedgerEntries.AccountTypeColumn] = (object) value;
    }

    public string AccountFullName
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableLedgerEntries.AccountFullNameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableLedgerEntries.AccountFullNameColumn] = (object) value;
    }

    public Decimal Amount
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tableLedgerEntries.AmountColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableLedgerEntries.AmountColumn] = (object) value;
    }

    public bool IsGLAcctIdNull() => this.IsNull(this.tableLedgerEntries.GLAcctIdColumn);

    public void SetGLAcctIdNull()
    {
      this[this.tableLedgerEntries.GLAcctIdColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsAccountTypeNull() => this.IsNull(this.tableLedgerEntries.AccountTypeColumn);

    public void SetAccountTypeNull()
    {
      this[this.tableLedgerEntries.AccountTypeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsAccountFullNameNull()
    {
      return this.IsNull(this.tableLedgerEntries.AccountFullNameColumn);
    }

    public void SetAccountFullNameNull()
    {
      this[this.tableLedgerEntries.AccountFullNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsAmountNull() => this.IsNull(this.tableLedgerEntries.AmountColumn);

    public void SetAmountNull()
    {
      this[this.tableLedgerEntries.AmountColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  [DebuggerStepThrough]
  public class LedgerEntriesRowChangeEvent : EventArgs
  {
    private dsJournalEntries.LedgerEntriesRow eventRow;
    private DataRowAction eventAction;

    public LedgerEntriesRowChangeEvent(dsJournalEntries.LedgerEntriesRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    public dsJournalEntries.LedgerEntriesRow Row => this.eventRow;

    public DataRowAction Action => this.eventAction;
  }
}
