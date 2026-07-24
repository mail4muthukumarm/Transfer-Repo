// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.AccountingDatasets.dsBankAccountsDropDown
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
public class dsBankAccountsDropDown : DataSet
{
  private dsBankAccountsDropDown._TableDataTable table_Table;

  public dsBankAccountsDropDown()
  {
    this.InitClass();
    CollectionChangeEventHandler changeEventHandler = new CollectionChangeEventHandler(this.SchemaChanged);
    this.Tables.CollectionChanged += changeEventHandler;
    this.Relations.CollectionChanged += changeEventHandler;
  }

  protected dsBankAccountsDropDown(SerializationInfo info, StreamingContext context)
  {
    string s = Conversions.ToString(info.GetValue("XmlSchema", typeof (string)));
    if (s != null)
    {
      DataSet dataSet = new DataSet();
      dataSet.ReadXmlSchema((XmlReader) new XmlTextReader((TextReader) new StringReader(s)));
      if (dataSet.Tables["Table"] != null)
        this.Tables.Add((DataTable) new dsBankAccountsDropDown._TableDataTable(dataSet.Tables["Table"]));
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
  public dsBankAccountsDropDown._TableDataTable _Table => this.table_Table;

  public override DataSet Clone()
  {
    dsBankAccountsDropDown accountsDropDown = (dsBankAccountsDropDown) base.Clone();
    accountsDropDown.InitVars();
    return (DataSet) accountsDropDown;
  }

  protected override bool ShouldSerializeTables() => false;

  protected override bool ShouldSerializeRelations() => false;

  protected override void ReadXmlSerializable(XmlReader reader)
  {
    this.Reset();
    DataSet dataSet = new DataSet();
    int num = (int) dataSet.ReadXml(reader);
    if (dataSet.Tables["Table"] != null)
      this.Tables.Add((DataTable) new dsBankAccountsDropDown._TableDataTable(dataSet.Tables["Table"]));
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
    this.table_Table = (dsBankAccountsDropDown._TableDataTable) this.Tables["Table"];
    if (this.table_Table == null)
      return;
    this.table_Table.InitVars();
  }

  private void InitClass()
  {
    this.DataSetName = nameof (dsBankAccountsDropDown);
    this.Prefix = "";
    this.Namespace = "http://www.tempuri.org/dsBankAccountsDropDown.xsd";
    this.Locale = new CultureInfo("en-US");
    this.CaseSensitive = false;
    this.EnforceConstraints = true;
    this.table_Table = new dsBankAccountsDropDown._TableDataTable();
    this.Tables.Add((DataTable) this.table_Table);
  }

  private bool ShouldSerialize_Table() => false;

  private void SchemaChanged(object sender, CollectionChangeEventArgs e)
  {
    if (e.Action != CollectionChangeAction.Remove)
      return;
    this.InitVars();
  }

  public delegate void _TableRowChangeEventHandler(
    object sender,
    dsBankAccountsDropDown._TableRowChangeEvent e);

  [DebuggerStepThrough]
  public class _TableDataTable : DataTable, IEnumerable
  {
    private DataColumn columnbank;
    private DataColumn columnGLAcctID;

    internal _TableDataTable()
      : base("Table")
    {
      this.InitClass();
    }

    internal _TableDataTable(DataTable table)
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

    internal DataColumn bankColumn => this.columnbank;

    internal DataColumn GLAcctIDColumn => this.columnGLAcctID;

    public dsBankAccountsDropDown._TableRow this[int index]
    {
      get => (dsBankAccountsDropDown._TableRow) this.Rows[index];
    }

    public event dsBankAccountsDropDown._TableRowChangeEventHandler _TableRowChanged;

    public event dsBankAccountsDropDown._TableRowChangeEventHandler _TableRowChanging;

    public event dsBankAccountsDropDown._TableRowChangeEventHandler _TableRowDeleted;

    public event dsBankAccountsDropDown._TableRowChangeEventHandler _TableRowDeleting;

    public void Add_TableRow(dsBankAccountsDropDown._TableRow row) => this.Rows.Add((DataRow) row);

    public dsBankAccountsDropDown._TableRow Add_TableRow(string bank, int GLAcctID)
    {
      dsBankAccountsDropDown._TableRow row = (dsBankAccountsDropDown._TableRow) this.NewRow();
      row.ItemArray = new object[2]
      {
        (object) bank,
        (object) GLAcctID
      };
      this.Rows.Add((DataRow) row);
      return row;
    }

    public IEnumerator GetEnumerator() => this.Rows.GetEnumerator();

    public override DataTable Clone()
    {
      dsBankAccountsDropDown._TableDataTable tableDataTable = (dsBankAccountsDropDown._TableDataTable) base.Clone();
      tableDataTable.InitVars();
      return (DataTable) tableDataTable;
    }

    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsBankAccountsDropDown._TableDataTable();
    }

    internal void InitVars()
    {
      this.columnbank = this.Columns["bank"];
      this.columnGLAcctID = this.Columns["GLAcctID"];
    }

    private void InitClass()
    {
      this.columnbank = new DataColumn("bank", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnbank);
      this.columnGLAcctID = new DataColumn("GLAcctID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnGLAcctID);
      this.columnbank.ReadOnly = true;
      this.columnGLAcctID.ReadOnly = true;
    }

    public dsBankAccountsDropDown._TableRow New_TableRow()
    {
      return (dsBankAccountsDropDown._TableRow) this.NewRow();
    }

    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsBankAccountsDropDown._TableRow(builder);
    }

    protected override Type GetRowType() => typeof (dsBankAccountsDropDown._TableRow);

    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this._TableRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsBankAccountsDropDown._TableRowChangeEventHandler tableRowChangedEvent = this._TableRowChangedEvent;
      if (tableRowChangedEvent == null)
        return;
      tableRowChangedEvent((object) this, new dsBankAccountsDropDown._TableRowChangeEvent((dsBankAccountsDropDown._TableRow) e.Row, e.Action));
    }

    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this._TableRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsBankAccountsDropDown._TableRowChangeEventHandler rowChangingEvent = this._TableRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsBankAccountsDropDown._TableRowChangeEvent((dsBankAccountsDropDown._TableRow) e.Row, e.Action));
    }

    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this._TableRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsBankAccountsDropDown._TableRowChangeEventHandler tableRowDeletedEvent = this._TableRowDeletedEvent;
      if (tableRowDeletedEvent == null)
        return;
      tableRowDeletedEvent((object) this, new dsBankAccountsDropDown._TableRowChangeEvent((dsBankAccountsDropDown._TableRow) e.Row, e.Action));
    }

    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this._TableRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsBankAccountsDropDown._TableRowChangeEventHandler rowDeletingEvent = this._TableRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsBankAccountsDropDown._TableRowChangeEvent((dsBankAccountsDropDown._TableRow) e.Row, e.Action));
    }

    public void Remove_TableRow(dsBankAccountsDropDown._TableRow row)
    {
      this.Rows.Remove((DataRow) row);
    }
  }

  [DebuggerStepThrough]
  public class _TableRow : DataRow
  {
    private dsBankAccountsDropDown._TableDataTable table_Table;

    internal _TableRow(DataRowBuilder rb)
      : base(rb)
    {
      this.table_Table = (dsBankAccountsDropDown._TableDataTable) this.Table;
    }

    public string bank
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.table_Table.bankColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.table_Table.bankColumn] = (object) value;
    }

    public int GLAcctID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.table_Table.GLAcctIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.table_Table.GLAcctIDColumn] = (object) value;
    }

    public bool IsbankNull() => this.IsNull(this.table_Table.bankColumn);

    public void SetbankNull()
    {
      this[this.table_Table.bankColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsGLAcctIDNull() => this.IsNull(this.table_Table.GLAcctIDColumn);

    public void SetGLAcctIDNull()
    {
      this[this.table_Table.GLAcctIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  [DebuggerStepThrough]
  public class _TableRowChangeEvent : EventArgs
  {
    private dsBankAccountsDropDown._TableRow eventRow;
    private DataRowAction eventAction;

    public _TableRowChangeEvent(dsBankAccountsDropDown._TableRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    public dsBankAccountsDropDown._TableRow Row => this.eventRow;

    public DataRowAction Action => this.eventAction;
  }
}
