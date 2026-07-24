// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.AccountingDatasets.AccountingSearchEntity
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
public class AccountingSearchEntity : DataSet
{
  private AccountingSearchEntity.spFin_SearchEntityDataTable tablespFin_SearchEntity;
  private AccountingSearchEntity.Table1DataTable tableTable1;
  private AccountingSearchEntity.Table2DataTable tableTable2;
  private AccountingSearchEntity.Table3DataTable tableTable3;
  private AccountingSearchEntity.Table4DataTable tableTable4;
  private AccountingSearchEntity.Table5DataTable tableTable5;
  private AccountingSearchEntity.Table6DataTable tableTable6;
  private AccountingSearchEntity.Table7DataTable tableTable7;
  private AccountingSearchEntity.Table8DataTable tableTable8;
  private AccountingSearchEntity.Table9DataTable tableTable9;
  private AccountingSearchEntity.BankInfoDataTable tableBankInfo;
  private AccountingSearchEntity._TableDataTable table_Table;

  public AccountingSearchEntity()
  {
    this.InitClass();
    CollectionChangeEventHandler changeEventHandler = new CollectionChangeEventHandler(this.SchemaChanged);
    this.Tables.CollectionChanged += changeEventHandler;
    this.Relations.CollectionChanged += changeEventHandler;
  }

  protected AccountingSearchEntity(SerializationInfo info, StreamingContext context)
  {
    string s = Conversions.ToString(info.GetValue("XmlSchema", typeof (string)));
    if (s != null)
    {
      DataSet dataSet = new DataSet();
      dataSet.ReadXmlSchema((XmlReader) new XmlTextReader((TextReader) new StringReader(s)));
      if (dataSet.Tables[nameof (spFin_SearchEntity)] != null)
        this.Tables.Add((DataTable) new AccountingSearchEntity.spFin_SearchEntityDataTable(dataSet.Tables[nameof (spFin_SearchEntity)]));
      if (dataSet.Tables[nameof (Table1)] != null)
        this.Tables.Add((DataTable) new AccountingSearchEntity.Table1DataTable(dataSet.Tables[nameof (Table1)]));
      if (dataSet.Tables[nameof (Table2)] != null)
        this.Tables.Add((DataTable) new AccountingSearchEntity.Table2DataTable(dataSet.Tables[nameof (Table2)]));
      if (dataSet.Tables[nameof (Table3)] != null)
        this.Tables.Add((DataTable) new AccountingSearchEntity.Table3DataTable(dataSet.Tables[nameof (Table3)]));
      if (dataSet.Tables[nameof (Table4)] != null)
        this.Tables.Add((DataTable) new AccountingSearchEntity.Table4DataTable(dataSet.Tables[nameof (Table4)]));
      if (dataSet.Tables[nameof (Table5)] != null)
        this.Tables.Add((DataTable) new AccountingSearchEntity.Table5DataTable(dataSet.Tables[nameof (Table5)]));
      if (dataSet.Tables[nameof (Table6)] != null)
        this.Tables.Add((DataTable) new AccountingSearchEntity.Table6DataTable(dataSet.Tables[nameof (Table6)]));
      if (dataSet.Tables[nameof (Table7)] != null)
        this.Tables.Add((DataTable) new AccountingSearchEntity.Table7DataTable(dataSet.Tables[nameof (Table7)]));
      if (dataSet.Tables[nameof (Table8)] != null)
        this.Tables.Add((DataTable) new AccountingSearchEntity.Table8DataTable(dataSet.Tables[nameof (Table8)]));
      if (dataSet.Tables[nameof (Table9)] != null)
        this.Tables.Add((DataTable) new AccountingSearchEntity.Table9DataTable(dataSet.Tables[nameof (Table9)]));
      if (dataSet.Tables[nameof (BankInfo)] != null)
        this.Tables.Add((DataTable) new AccountingSearchEntity.BankInfoDataTable(dataSet.Tables[nameof (BankInfo)]));
      if (dataSet.Tables["Table"] != null)
        this.Tables.Add((DataTable) new AccountingSearchEntity._TableDataTable(dataSet.Tables["Table"]));
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
  public AccountingSearchEntity.spFin_SearchEntityDataTable spFin_SearchEntity
  {
    get => this.tablespFin_SearchEntity;
  }

  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public AccountingSearchEntity.Table1DataTable Table1 => this.tableTable1;

  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public AccountingSearchEntity.Table2DataTable Table2 => this.tableTable2;

  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public AccountingSearchEntity.Table3DataTable Table3 => this.tableTable3;

  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public AccountingSearchEntity.Table4DataTable Table4 => this.tableTable4;

  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public AccountingSearchEntity.Table5DataTable Table5 => this.tableTable5;

  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public AccountingSearchEntity.Table6DataTable Table6 => this.tableTable6;

  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public AccountingSearchEntity.Table7DataTable Table7 => this.tableTable7;

  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public AccountingSearchEntity.Table8DataTable Table8 => this.tableTable8;

  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public AccountingSearchEntity.Table9DataTable Table9 => this.tableTable9;

  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public AccountingSearchEntity.BankInfoDataTable BankInfo => this.tableBankInfo;

  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public AccountingSearchEntity._TableDataTable _Table => this.table_Table;

  public override DataSet Clone()
  {
    AccountingSearchEntity accountingSearchEntity = (AccountingSearchEntity) base.Clone();
    accountingSearchEntity.InitVars();
    return (DataSet) accountingSearchEntity;
  }

  protected override bool ShouldSerializeTables() => false;

  protected override bool ShouldSerializeRelations() => false;

  protected override void ReadXmlSerializable(XmlReader reader)
  {
    this.Reset();
    DataSet dataSet = new DataSet();
    int num = (int) dataSet.ReadXml(reader);
    if (dataSet.Tables["spFin_SearchEntity"] != null)
      this.Tables.Add((DataTable) new AccountingSearchEntity.spFin_SearchEntityDataTable(dataSet.Tables["spFin_SearchEntity"]));
    if (dataSet.Tables["Table1"] != null)
      this.Tables.Add((DataTable) new AccountingSearchEntity.Table1DataTable(dataSet.Tables["Table1"]));
    if (dataSet.Tables["Table2"] != null)
      this.Tables.Add((DataTable) new AccountingSearchEntity.Table2DataTable(dataSet.Tables["Table2"]));
    if (dataSet.Tables["Table3"] != null)
      this.Tables.Add((DataTable) new AccountingSearchEntity.Table3DataTable(dataSet.Tables["Table3"]));
    if (dataSet.Tables["Table4"] != null)
      this.Tables.Add((DataTable) new AccountingSearchEntity.Table4DataTable(dataSet.Tables["Table4"]));
    if (dataSet.Tables["Table5"] != null)
      this.Tables.Add((DataTable) new AccountingSearchEntity.Table5DataTable(dataSet.Tables["Table5"]));
    if (dataSet.Tables["Table6"] != null)
      this.Tables.Add((DataTable) new AccountingSearchEntity.Table6DataTable(dataSet.Tables["Table6"]));
    if (dataSet.Tables["Table7"] != null)
      this.Tables.Add((DataTable) new AccountingSearchEntity.Table7DataTable(dataSet.Tables["Table7"]));
    if (dataSet.Tables["Table8"] != null)
      this.Tables.Add((DataTable) new AccountingSearchEntity.Table8DataTable(dataSet.Tables["Table8"]));
    if (dataSet.Tables["Table9"] != null)
      this.Tables.Add((DataTable) new AccountingSearchEntity.Table9DataTable(dataSet.Tables["Table9"]));
    if (dataSet.Tables["BankInfo"] != null)
      this.Tables.Add((DataTable) new AccountingSearchEntity.BankInfoDataTable(dataSet.Tables["BankInfo"]));
    if (dataSet.Tables["Table"] != null)
      this.Tables.Add((DataTable) new AccountingSearchEntity._TableDataTable(dataSet.Tables["Table"]));
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
    this.tablespFin_SearchEntity = (AccountingSearchEntity.spFin_SearchEntityDataTable) this.Tables["spFin_SearchEntity"];
    if (this.tablespFin_SearchEntity != null)
      this.tablespFin_SearchEntity.InitVars();
    this.tableTable1 = (AccountingSearchEntity.Table1DataTable) this.Tables["Table1"];
    if (this.tableTable1 != null)
      this.tableTable1.InitVars();
    this.tableTable2 = (AccountingSearchEntity.Table2DataTable) this.Tables["Table2"];
    if (this.tableTable2 != null)
      this.tableTable2.InitVars();
    this.tableTable3 = (AccountingSearchEntity.Table3DataTable) this.Tables["Table3"];
    if (this.tableTable3 != null)
      this.tableTable3.InitVars();
    this.tableTable4 = (AccountingSearchEntity.Table4DataTable) this.Tables["Table4"];
    if (this.tableTable4 != null)
      this.tableTable4.InitVars();
    this.tableTable5 = (AccountingSearchEntity.Table5DataTable) this.Tables["Table5"];
    if (this.tableTable5 != null)
      this.tableTable5.InitVars();
    this.tableTable6 = (AccountingSearchEntity.Table6DataTable) this.Tables["Table6"];
    if (this.tableTable6 != null)
      this.tableTable6.InitVars();
    this.tableTable7 = (AccountingSearchEntity.Table7DataTable) this.Tables["Table7"];
    if (this.tableTable7 != null)
      this.tableTable7.InitVars();
    this.tableTable8 = (AccountingSearchEntity.Table8DataTable) this.Tables["Table8"];
    if (this.tableTable8 != null)
      this.tableTable8.InitVars();
    this.tableTable9 = (AccountingSearchEntity.Table9DataTable) this.Tables["Table9"];
    if (this.tableTable9 != null)
      this.tableTable9.InitVars();
    this.tableBankInfo = (AccountingSearchEntity.BankInfoDataTable) this.Tables["BankInfo"];
    if (this.tableBankInfo != null)
      this.tableBankInfo.InitVars();
    this.table_Table = (AccountingSearchEntity._TableDataTable) this.Tables["Table"];
    if (this.table_Table == null)
      return;
    this.table_Table.InitVars();
  }

  private void InitClass()
  {
    this.DataSetName = nameof (AccountingSearchEntity);
    this.Prefix = "";
    this.Namespace = "http://www.tempuri.org/AccountingSearchEntity.xsd";
    this.Locale = new CultureInfo("en-US");
    this.CaseSensitive = false;
    this.EnforceConstraints = true;
    this.tablespFin_SearchEntity = new AccountingSearchEntity.spFin_SearchEntityDataTable();
    this.Tables.Add((DataTable) this.tablespFin_SearchEntity);
    this.tableTable1 = new AccountingSearchEntity.Table1DataTable();
    this.Tables.Add((DataTable) this.tableTable1);
    this.tableTable2 = new AccountingSearchEntity.Table2DataTable();
    this.Tables.Add((DataTable) this.tableTable2);
    this.tableTable3 = new AccountingSearchEntity.Table3DataTable();
    this.Tables.Add((DataTable) this.tableTable3);
    this.tableTable4 = new AccountingSearchEntity.Table4DataTable();
    this.Tables.Add((DataTable) this.tableTable4);
    this.tableTable5 = new AccountingSearchEntity.Table5DataTable();
    this.Tables.Add((DataTable) this.tableTable5);
    this.tableTable6 = new AccountingSearchEntity.Table6DataTable();
    this.Tables.Add((DataTable) this.tableTable6);
    this.tableTable7 = new AccountingSearchEntity.Table7DataTable();
    this.Tables.Add((DataTable) this.tableTable7);
    this.tableTable8 = new AccountingSearchEntity.Table8DataTable();
    this.Tables.Add((DataTable) this.tableTable8);
    this.tableTable9 = new AccountingSearchEntity.Table9DataTable();
    this.Tables.Add((DataTable) this.tableTable9);
    this.tableBankInfo = new AccountingSearchEntity.BankInfoDataTable();
    this.Tables.Add((DataTable) this.tableBankInfo);
    this.table_Table = new AccountingSearchEntity._TableDataTable();
    this.Tables.Add((DataTable) this.table_Table);
  }

  private bool ShouldSerializespFin_SearchEntity() => false;

  private bool ShouldSerializeTable1() => false;

  private bool ShouldSerializeTable2() => false;

  private bool ShouldSerializeTable3() => false;

  private bool ShouldSerializeTable4() => false;

  private bool ShouldSerializeTable5() => false;

  private bool ShouldSerializeTable6() => false;

  private bool ShouldSerializeTable7() => false;

  private bool ShouldSerializeTable8() => false;

  private bool ShouldSerializeTable9() => false;

  private bool ShouldSerializeBankInfo() => false;

  private bool ShouldSerialize_Table() => false;

  private void SchemaChanged(object sender, CollectionChangeEventArgs e)
  {
    if (e.Action != CollectionChangeAction.Remove)
      return;
    this.InitVars();
  }

  public delegate void spFin_SearchEntityRowChangeEventHandler(
    object sender,
    AccountingSearchEntity.spFin_SearchEntityRowChangeEvent e);

  public delegate void Table1RowChangeEventHandler(
    object sender,
    AccountingSearchEntity.Table1RowChangeEvent e);

  public delegate void Table2RowChangeEventHandler(
    object sender,
    AccountingSearchEntity.Table2RowChangeEvent e);

  public delegate void Table3RowChangeEventHandler(
    object sender,
    AccountingSearchEntity.Table3RowChangeEvent e);

  public delegate void Table4RowChangeEventHandler(
    object sender,
    AccountingSearchEntity.Table4RowChangeEvent e);

  public delegate void Table5RowChangeEventHandler(
    object sender,
    AccountingSearchEntity.Table5RowChangeEvent e);

  public delegate void Table6RowChangeEventHandler(
    object sender,
    AccountingSearchEntity.Table6RowChangeEvent e);

  public delegate void Table7RowChangeEventHandler(
    object sender,
    AccountingSearchEntity.Table7RowChangeEvent e);

  public delegate void Table8RowChangeEventHandler(
    object sender,
    AccountingSearchEntity.Table8RowChangeEvent e);

  public delegate void Table9RowChangeEventHandler(
    object sender,
    AccountingSearchEntity.Table9RowChangeEvent e);

  public delegate void BankInfoRowChangeEventHandler(
    object sender,
    AccountingSearchEntity.BankInfoRowChangeEvent e);

  public delegate void _TableRowChangeEventHandler(
    object sender,
    AccountingSearchEntity._TableRowChangeEvent e);

  [DebuggerStepThrough]
  public class spFin_SearchEntityDataTable : DataTable, IEnumerable
  {
    private DataColumn columnEntity_Name;
    private DataColumn columnEntityGUID;

    internal spFin_SearchEntityDataTable()
      : base("spFin_SearchEntity")
    {
      this.InitClass();
    }

    internal spFin_SearchEntityDataTable(DataTable table)
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

    internal DataColumn Entity_NameColumn => this.columnEntity_Name;

    internal DataColumn EntityGUIDColumn => this.columnEntityGUID;

    public AccountingSearchEntity.spFin_SearchEntityRow this[int index]
    {
      get => (AccountingSearchEntity.spFin_SearchEntityRow) this.Rows[index];
    }

    public event AccountingSearchEntity.spFin_SearchEntityRowChangeEventHandler spFin_SearchEntityRowChanged;

    public event AccountingSearchEntity.spFin_SearchEntityRowChangeEventHandler spFin_SearchEntityRowChanging;

    public event AccountingSearchEntity.spFin_SearchEntityRowChangeEventHandler spFin_SearchEntityRowDeleted;

    public event AccountingSearchEntity.spFin_SearchEntityRowChangeEventHandler spFin_SearchEntityRowDeleting;

    public void AddspFin_SearchEntityRow(AccountingSearchEntity.spFin_SearchEntityRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    public AccountingSearchEntity.spFin_SearchEntityRow AddspFin_SearchEntityRow(
      string Entity_Name,
      Guid EntityGUID)
    {
      AccountingSearchEntity.spFin_SearchEntityRow row = (AccountingSearchEntity.spFin_SearchEntityRow) this.NewRow();
      row.ItemArray = new object[2]
      {
        (object) Entity_Name,
        (object) EntityGUID
      };
      this.Rows.Add((DataRow) row);
      return row;
    }

    public IEnumerator GetEnumerator() => this.Rows.GetEnumerator();

    public override DataTable Clone()
    {
      AccountingSearchEntity.spFin_SearchEntityDataTable searchEntityDataTable = (AccountingSearchEntity.spFin_SearchEntityDataTable) base.Clone();
      searchEntityDataTable.InitVars();
      return (DataTable) searchEntityDataTable;
    }

    protected override DataTable CreateInstance()
    {
      return (DataTable) new AccountingSearchEntity.spFin_SearchEntityDataTable();
    }

    internal void InitVars()
    {
      this.columnEntity_Name = this.Columns["Entity Name"];
      this.columnEntityGUID = this.Columns["EntityGUID"];
    }

    private void InitClass()
    {
      this.columnEntity_Name = new DataColumn("Entity Name", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEntity_Name);
      this.columnEntityGUID = new DataColumn("EntityGUID", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEntityGUID);
      this.columnEntity_Name.ReadOnly = true;
      this.columnEntityGUID.AllowDBNull = false;
    }

    public AccountingSearchEntity.spFin_SearchEntityRow NewspFin_SearchEntityRow()
    {
      return (AccountingSearchEntity.spFin_SearchEntityRow) this.NewRow();
    }

    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new AccountingSearchEntity.spFin_SearchEntityRow(builder);
    }

    protected override Type GetRowType() => typeof (AccountingSearchEntity.spFin_SearchEntityRow);

    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.spFin_SearchEntityRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      AccountingSearchEntity.spFin_SearchEntityRowChangeEventHandler entityRowChangedEvent = this.spFin_SearchEntityRowChangedEvent;
      if (entityRowChangedEvent == null)
        return;
      entityRowChangedEvent((object) this, new AccountingSearchEntity.spFin_SearchEntityRowChangeEvent((AccountingSearchEntity.spFin_SearchEntityRow) e.Row, e.Action));
    }

    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.spFin_SearchEntityRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      AccountingSearchEntity.spFin_SearchEntityRowChangeEventHandler rowChangingEvent = this.spFin_SearchEntityRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new AccountingSearchEntity.spFin_SearchEntityRowChangeEvent((AccountingSearchEntity.spFin_SearchEntityRow) e.Row, e.Action));
    }

    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.spFin_SearchEntityRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      AccountingSearchEntity.spFin_SearchEntityRowChangeEventHandler entityRowDeletedEvent = this.spFin_SearchEntityRowDeletedEvent;
      if (entityRowDeletedEvent == null)
        return;
      entityRowDeletedEvent((object) this, new AccountingSearchEntity.spFin_SearchEntityRowChangeEvent((AccountingSearchEntity.spFin_SearchEntityRow) e.Row, e.Action));
    }

    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.spFin_SearchEntityRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      AccountingSearchEntity.spFin_SearchEntityRowChangeEventHandler rowDeletingEvent = this.spFin_SearchEntityRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new AccountingSearchEntity.spFin_SearchEntityRowChangeEvent((AccountingSearchEntity.spFin_SearchEntityRow) e.Row, e.Action));
    }

    public void RemovespFin_SearchEntityRow(AccountingSearchEntity.spFin_SearchEntityRow row)
    {
      this.Rows.Remove((DataRow) row);
    }
  }

  [DebuggerStepThrough]
  public class spFin_SearchEntityRow : DataRow
  {
    private AccountingSearchEntity.spFin_SearchEntityDataTable tablespFin_SearchEntity;

    internal spFin_SearchEntityRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablespFin_SearchEntity = (AccountingSearchEntity.spFin_SearchEntityDataTable) this.Table;
    }

    public string Entity_Name
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablespFin_SearchEntity.Entity_NameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablespFin_SearchEntity.Entity_NameColumn] = (object) value;
    }

    public Guid EntityGUID
    {
      get
      {
        object obj = this[this.tablespFin_SearchEntity.EntityGUIDColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tablespFin_SearchEntity.EntityGUIDColumn] = (object) value;
    }

    public bool IsEntity_NameNull() => this.IsNull(this.tablespFin_SearchEntity.Entity_NameColumn);

    public void SetEntity_NameNull()
    {
      this[this.tablespFin_SearchEntity.Entity_NameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  [DebuggerStepThrough]
  public class spFin_SearchEntityRowChangeEvent : EventArgs
  {
    private AccountingSearchEntity.spFin_SearchEntityRow eventRow;
    private DataRowAction eventAction;

    public spFin_SearchEntityRowChangeEvent(
      AccountingSearchEntity.spFin_SearchEntityRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    public AccountingSearchEntity.spFin_SearchEntityRow Row => this.eventRow;

    public DataRowAction Action => this.eventAction;
  }

  [DebuggerStepThrough]
  public class Table1DataTable : DataTable, IEnumerable
  {
    private DataColumn columnEntity_Name;
    private DataColumn columnEntityGUID;

    internal Table1DataTable()
      : base("Table1")
    {
      this.InitClass();
    }

    internal Table1DataTable(DataTable table)
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

    internal DataColumn Entity_NameColumn => this.columnEntity_Name;

    internal DataColumn EntityGUIDColumn => this.columnEntityGUID;

    public AccountingSearchEntity.Table1Row this[int index]
    {
      get => (AccountingSearchEntity.Table1Row) this.Rows[index];
    }

    public event AccountingSearchEntity.Table1RowChangeEventHandler Table1RowChanged;

    public event AccountingSearchEntity.Table1RowChangeEventHandler Table1RowChanging;

    public event AccountingSearchEntity.Table1RowChangeEventHandler Table1RowDeleted;

    public event AccountingSearchEntity.Table1RowChangeEventHandler Table1RowDeleting;

    public void AddTable1Row(AccountingSearchEntity.Table1Row row) => this.Rows.Add((DataRow) row);

    public AccountingSearchEntity.Table1Row AddTable1Row(string Entity_Name, Guid EntityGUID)
    {
      AccountingSearchEntity.Table1Row row = (AccountingSearchEntity.Table1Row) this.NewRow();
      row.ItemArray = new object[2]
      {
        (object) Entity_Name,
        (object) EntityGUID
      };
      this.Rows.Add((DataRow) row);
      return row;
    }

    public IEnumerator GetEnumerator() => this.Rows.GetEnumerator();

    public override DataTable Clone()
    {
      AccountingSearchEntity.Table1DataTable table1DataTable = (AccountingSearchEntity.Table1DataTable) base.Clone();
      table1DataTable.InitVars();
      return (DataTable) table1DataTable;
    }

    protected override DataTable CreateInstance()
    {
      return (DataTable) new AccountingSearchEntity.Table1DataTable();
    }

    internal void InitVars()
    {
      this.columnEntity_Name = this.Columns["Entity Name"];
      this.columnEntityGUID = this.Columns["EntityGUID"];
    }

    private void InitClass()
    {
      this.columnEntity_Name = new DataColumn("Entity Name", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEntity_Name);
      this.columnEntityGUID = new DataColumn("EntityGUID", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEntityGUID);
      this.columnEntity_Name.ReadOnly = true;
      this.columnEntityGUID.AllowDBNull = false;
    }

    public AccountingSearchEntity.Table1Row NewTable1Row()
    {
      return (AccountingSearchEntity.Table1Row) this.NewRow();
    }

    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new AccountingSearchEntity.Table1Row(builder);
    }

    protected override Type GetRowType() => typeof (AccountingSearchEntity.Table1Row);

    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.Table1RowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      AccountingSearchEntity.Table1RowChangeEventHandler table1RowChangedEvent = this.Table1RowChangedEvent;
      if (table1RowChangedEvent == null)
        return;
      table1RowChangedEvent((object) this, new AccountingSearchEntity.Table1RowChangeEvent((AccountingSearchEntity.Table1Row) e.Row, e.Action));
    }

    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.Table1RowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      AccountingSearchEntity.Table1RowChangeEventHandler rowChangingEvent = this.Table1RowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new AccountingSearchEntity.Table1RowChangeEvent((AccountingSearchEntity.Table1Row) e.Row, e.Action));
    }

    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.Table1RowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      AccountingSearchEntity.Table1RowChangeEventHandler table1RowDeletedEvent = this.Table1RowDeletedEvent;
      if (table1RowDeletedEvent == null)
        return;
      table1RowDeletedEvent((object) this, new AccountingSearchEntity.Table1RowChangeEvent((AccountingSearchEntity.Table1Row) e.Row, e.Action));
    }

    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.Table1RowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      AccountingSearchEntity.Table1RowChangeEventHandler rowDeletingEvent = this.Table1RowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new AccountingSearchEntity.Table1RowChangeEvent((AccountingSearchEntity.Table1Row) e.Row, e.Action));
    }

    public void RemoveTable1Row(AccountingSearchEntity.Table1Row row)
    {
      this.Rows.Remove((DataRow) row);
    }
  }

  [DebuggerStepThrough]
  public class Table1Row : DataRow
  {
    private AccountingSearchEntity.Table1DataTable tableTable1;

    internal Table1Row(DataRowBuilder rb)
      : base(rb)
    {
      this.tableTable1 = (AccountingSearchEntity.Table1DataTable) this.Table;
    }

    public string Entity_Name
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableTable1.Entity_NameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableTable1.Entity_NameColumn] = (object) value;
    }

    public Guid EntityGUID
    {
      get
      {
        object obj = this[this.tableTable1.EntityGUIDColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tableTable1.EntityGUIDColumn] = (object) value;
    }

    public bool IsEntity_NameNull() => this.IsNull(this.tableTable1.Entity_NameColumn);

    public void SetEntity_NameNull()
    {
      this[this.tableTable1.Entity_NameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  [DebuggerStepThrough]
  public class Table1RowChangeEvent : EventArgs
  {
    private AccountingSearchEntity.Table1Row eventRow;
    private DataRowAction eventAction;

    public Table1RowChangeEvent(AccountingSearchEntity.Table1Row row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    public AccountingSearchEntity.Table1Row Row => this.eventRow;

    public DataRowAction Action => this.eventAction;
  }

  [DebuggerStepThrough]
  public class Table2DataTable : DataTable, IEnumerable
  {
    private DataColumn columnEntity_Name;
    private DataColumn columnEntityGUID;

    internal Table2DataTable()
      : base("Table2")
    {
      this.InitClass();
    }

    internal Table2DataTable(DataTable table)
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

    internal DataColumn Entity_NameColumn => this.columnEntity_Name;

    internal DataColumn EntityGUIDColumn => this.columnEntityGUID;

    public AccountingSearchEntity.Table2Row this[int index]
    {
      get => (AccountingSearchEntity.Table2Row) this.Rows[index];
    }

    public event AccountingSearchEntity.Table2RowChangeEventHandler Table2RowChanged;

    public event AccountingSearchEntity.Table2RowChangeEventHandler Table2RowChanging;

    public event AccountingSearchEntity.Table2RowChangeEventHandler Table2RowDeleted;

    public event AccountingSearchEntity.Table2RowChangeEventHandler Table2RowDeleting;

    public void AddTable2Row(AccountingSearchEntity.Table2Row row) => this.Rows.Add((DataRow) row);

    public AccountingSearchEntity.Table2Row AddTable2Row(string Entity_Name, Guid EntityGUID)
    {
      AccountingSearchEntity.Table2Row row = (AccountingSearchEntity.Table2Row) this.NewRow();
      row.ItemArray = new object[2]
      {
        (object) Entity_Name,
        (object) EntityGUID
      };
      this.Rows.Add((DataRow) row);
      return row;
    }

    public AccountingSearchEntity.Table2Row FindByEntityGUID(Guid EntityGUID)
    {
      return (AccountingSearchEntity.Table2Row) this.Rows.Find(new object[1]
      {
        (object) EntityGUID
      });
    }

    public IEnumerator GetEnumerator() => this.Rows.GetEnumerator();

    public override DataTable Clone()
    {
      AccountingSearchEntity.Table2DataTable table2DataTable = (AccountingSearchEntity.Table2DataTable) base.Clone();
      table2DataTable.InitVars();
      return (DataTable) table2DataTable;
    }

    protected override DataTable CreateInstance()
    {
      return (DataTable) new AccountingSearchEntity.Table2DataTable();
    }

    internal void InitVars()
    {
      this.columnEntity_Name = this.Columns["Entity Name"];
      this.columnEntityGUID = this.Columns["EntityGUID"];
    }

    private void InitClass()
    {
      this.columnEntity_Name = new DataColumn("Entity Name", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEntity_Name);
      this.columnEntityGUID = new DataColumn("EntityGUID", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEntityGUID);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnEntityGUID
      }, true));
      this.columnEntity_Name.AllowDBNull = false;
      this.columnEntityGUID.AllowDBNull = false;
      this.columnEntityGUID.Unique = true;
    }

    public AccountingSearchEntity.Table2Row NewTable2Row()
    {
      return (AccountingSearchEntity.Table2Row) this.NewRow();
    }

    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new AccountingSearchEntity.Table2Row(builder);
    }

    protected override Type GetRowType() => typeof (AccountingSearchEntity.Table2Row);

    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.Table2RowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      AccountingSearchEntity.Table2RowChangeEventHandler table2RowChangedEvent = this.Table2RowChangedEvent;
      if (table2RowChangedEvent == null)
        return;
      table2RowChangedEvent((object) this, new AccountingSearchEntity.Table2RowChangeEvent((AccountingSearchEntity.Table2Row) e.Row, e.Action));
    }

    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.Table2RowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      AccountingSearchEntity.Table2RowChangeEventHandler rowChangingEvent = this.Table2RowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new AccountingSearchEntity.Table2RowChangeEvent((AccountingSearchEntity.Table2Row) e.Row, e.Action));
    }

    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.Table2RowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      AccountingSearchEntity.Table2RowChangeEventHandler table2RowDeletedEvent = this.Table2RowDeletedEvent;
      if (table2RowDeletedEvent == null)
        return;
      table2RowDeletedEvent((object) this, new AccountingSearchEntity.Table2RowChangeEvent((AccountingSearchEntity.Table2Row) e.Row, e.Action));
    }

    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.Table2RowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      AccountingSearchEntity.Table2RowChangeEventHandler rowDeletingEvent = this.Table2RowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new AccountingSearchEntity.Table2RowChangeEvent((AccountingSearchEntity.Table2Row) e.Row, e.Action));
    }

    public void RemoveTable2Row(AccountingSearchEntity.Table2Row row)
    {
      this.Rows.Remove((DataRow) row);
    }
  }

  [DebuggerStepThrough]
  public class Table2Row : DataRow
  {
    private AccountingSearchEntity.Table2DataTable tableTable2;

    internal Table2Row(DataRowBuilder rb)
      : base(rb)
    {
      this.tableTable2 = (AccountingSearchEntity.Table2DataTable) this.Table;
    }

    public string Entity_Name
    {
      get => Conversions.ToString(this[this.tableTable2.Entity_NameColumn]);
      set => this[this.tableTable2.Entity_NameColumn] = (object) value;
    }

    public Guid EntityGUID
    {
      get
      {
        object obj = this[this.tableTable2.EntityGUIDColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tableTable2.EntityGUIDColumn] = (object) value;
    }
  }

  [DebuggerStepThrough]
  public class Table2RowChangeEvent : EventArgs
  {
    private AccountingSearchEntity.Table2Row eventRow;
    private DataRowAction eventAction;

    public Table2RowChangeEvent(AccountingSearchEntity.Table2Row row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    public AccountingSearchEntity.Table2Row Row => this.eventRow;

    public DataRowAction Action => this.eventAction;
  }

  [DebuggerStepThrough]
  public class Table3DataTable : DataTable, IEnumerable
  {
    private DataColumn columnEntity_Name;
    private DataColumn columnEntityGUID;

    internal Table3DataTable()
      : base("Table3")
    {
      this.InitClass();
    }

    internal Table3DataTable(DataTable table)
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

    internal DataColumn Entity_NameColumn => this.columnEntity_Name;

    internal DataColumn EntityGUIDColumn => this.columnEntityGUID;

    public AccountingSearchEntity.Table3Row this[int index]
    {
      get => (AccountingSearchEntity.Table3Row) this.Rows[index];
    }

    public event AccountingSearchEntity.Table3RowChangeEventHandler Table3RowChanged;

    public event AccountingSearchEntity.Table3RowChangeEventHandler Table3RowChanging;

    public event AccountingSearchEntity.Table3RowChangeEventHandler Table3RowDeleted;

    public event AccountingSearchEntity.Table3RowChangeEventHandler Table3RowDeleting;

    public void AddTable3Row(AccountingSearchEntity.Table3Row row) => this.Rows.Add((DataRow) row);

    public AccountingSearchEntity.Table3Row AddTable3Row(string Entity_Name, Guid EntityGUID)
    {
      AccountingSearchEntity.Table3Row row = (AccountingSearchEntity.Table3Row) this.NewRow();
      row.ItemArray = new object[2]
      {
        (object) Entity_Name,
        (object) EntityGUID
      };
      this.Rows.Add((DataRow) row);
      return row;
    }

    public AccountingSearchEntity.Table3Row FindByEntityGUID(Guid EntityGUID)
    {
      return (AccountingSearchEntity.Table3Row) this.Rows.Find(new object[1]
      {
        (object) EntityGUID
      });
    }

    public IEnumerator GetEnumerator() => this.Rows.GetEnumerator();

    public override DataTable Clone()
    {
      AccountingSearchEntity.Table3DataTable table3DataTable = (AccountingSearchEntity.Table3DataTable) base.Clone();
      table3DataTable.InitVars();
      return (DataTable) table3DataTable;
    }

    protected override DataTable CreateInstance()
    {
      return (DataTable) new AccountingSearchEntity.Table3DataTable();
    }

    internal void InitVars()
    {
      this.columnEntity_Name = this.Columns["Entity Name"];
      this.columnEntityGUID = this.Columns["EntityGUID"];
    }

    private void InitClass()
    {
      this.columnEntity_Name = new DataColumn("Entity Name", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEntity_Name);
      this.columnEntityGUID = new DataColumn("EntityGUID", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEntityGUID);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnEntityGUID
      }, true));
      this.columnEntity_Name.AllowDBNull = false;
      this.columnEntityGUID.AllowDBNull = false;
      this.columnEntityGUID.Unique = true;
    }

    public AccountingSearchEntity.Table3Row NewTable3Row()
    {
      return (AccountingSearchEntity.Table3Row) this.NewRow();
    }

    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new AccountingSearchEntity.Table3Row(builder);
    }

    protected override Type GetRowType() => typeof (AccountingSearchEntity.Table3Row);

    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.Table3RowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      AccountingSearchEntity.Table3RowChangeEventHandler table3RowChangedEvent = this.Table3RowChangedEvent;
      if (table3RowChangedEvent == null)
        return;
      table3RowChangedEvent((object) this, new AccountingSearchEntity.Table3RowChangeEvent((AccountingSearchEntity.Table3Row) e.Row, e.Action));
    }

    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.Table3RowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      AccountingSearchEntity.Table3RowChangeEventHandler rowChangingEvent = this.Table3RowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new AccountingSearchEntity.Table3RowChangeEvent((AccountingSearchEntity.Table3Row) e.Row, e.Action));
    }

    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.Table3RowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      AccountingSearchEntity.Table3RowChangeEventHandler table3RowDeletedEvent = this.Table3RowDeletedEvent;
      if (table3RowDeletedEvent == null)
        return;
      table3RowDeletedEvent((object) this, new AccountingSearchEntity.Table3RowChangeEvent((AccountingSearchEntity.Table3Row) e.Row, e.Action));
    }

    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.Table3RowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      AccountingSearchEntity.Table3RowChangeEventHandler rowDeletingEvent = this.Table3RowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new AccountingSearchEntity.Table3RowChangeEvent((AccountingSearchEntity.Table3Row) e.Row, e.Action));
    }

    public void RemoveTable3Row(AccountingSearchEntity.Table3Row row)
    {
      this.Rows.Remove((DataRow) row);
    }
  }

  [DebuggerStepThrough]
  public class Table3Row : DataRow
  {
    private AccountingSearchEntity.Table3DataTable tableTable3;

    internal Table3Row(DataRowBuilder rb)
      : base(rb)
    {
      this.tableTable3 = (AccountingSearchEntity.Table3DataTable) this.Table;
    }

    public string Entity_Name
    {
      get => Conversions.ToString(this[this.tableTable3.Entity_NameColumn]);
      set => this[this.tableTable3.Entity_NameColumn] = (object) value;
    }

    public Guid EntityGUID
    {
      get
      {
        object obj = this[this.tableTable3.EntityGUIDColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tableTable3.EntityGUIDColumn] = (object) value;
    }
  }

  [DebuggerStepThrough]
  public class Table3RowChangeEvent : EventArgs
  {
    private AccountingSearchEntity.Table3Row eventRow;
    private DataRowAction eventAction;

    public Table3RowChangeEvent(AccountingSearchEntity.Table3Row row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    public AccountingSearchEntity.Table3Row Row => this.eventRow;

    public DataRowAction Action => this.eventAction;
  }

  [DebuggerStepThrough]
  public class Table4DataTable : DataTable, IEnumerable
  {
    private DataColumn columnEntity_Name;
    private DataColumn columnEntityGUID;

    internal Table4DataTable()
      : base("Table4")
    {
      this.InitClass();
    }

    internal Table4DataTable(DataTable table)
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

    internal DataColumn Entity_NameColumn => this.columnEntity_Name;

    internal DataColumn EntityGUIDColumn => this.columnEntityGUID;

    public AccountingSearchEntity.Table4Row this[int index]
    {
      get => (AccountingSearchEntity.Table4Row) this.Rows[index];
    }

    public event AccountingSearchEntity.Table4RowChangeEventHandler Table4RowChanged;

    public event AccountingSearchEntity.Table4RowChangeEventHandler Table4RowChanging;

    public event AccountingSearchEntity.Table4RowChangeEventHandler Table4RowDeleted;

    public event AccountingSearchEntity.Table4RowChangeEventHandler Table4RowDeleting;

    public void AddTable4Row(AccountingSearchEntity.Table4Row row) => this.Rows.Add((DataRow) row);

    public AccountingSearchEntity.Table4Row AddTable4Row(string Entity_Name, Guid EntityGUID)
    {
      AccountingSearchEntity.Table4Row row = (AccountingSearchEntity.Table4Row) this.NewRow();
      row.ItemArray = new object[2]
      {
        (object) Entity_Name,
        (object) EntityGUID
      };
      this.Rows.Add((DataRow) row);
      return row;
    }

    public AccountingSearchEntity.Table4Row FindByEntityGUID(Guid EntityGUID)
    {
      return (AccountingSearchEntity.Table4Row) this.Rows.Find(new object[1]
      {
        (object) EntityGUID
      });
    }

    public IEnumerator GetEnumerator() => this.Rows.GetEnumerator();

    public override DataTable Clone()
    {
      AccountingSearchEntity.Table4DataTable table4DataTable = (AccountingSearchEntity.Table4DataTable) base.Clone();
      table4DataTable.InitVars();
      return (DataTable) table4DataTable;
    }

    protected override DataTable CreateInstance()
    {
      return (DataTable) new AccountingSearchEntity.Table4DataTable();
    }

    internal void InitVars()
    {
      this.columnEntity_Name = this.Columns["Entity Name"];
      this.columnEntityGUID = this.Columns["EntityGUID"];
    }

    private void InitClass()
    {
      this.columnEntity_Name = new DataColumn("Entity Name", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEntity_Name);
      this.columnEntityGUID = new DataColumn("EntityGUID", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEntityGUID);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnEntityGUID
      }, true));
      this.columnEntity_Name.AllowDBNull = false;
      this.columnEntityGUID.AllowDBNull = false;
      this.columnEntityGUID.Unique = true;
    }

    public AccountingSearchEntity.Table4Row NewTable4Row()
    {
      return (AccountingSearchEntity.Table4Row) this.NewRow();
    }

    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new AccountingSearchEntity.Table4Row(builder);
    }

    protected override Type GetRowType() => typeof (AccountingSearchEntity.Table4Row);

    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.Table4RowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      AccountingSearchEntity.Table4RowChangeEventHandler table4RowChangedEvent = this.Table4RowChangedEvent;
      if (table4RowChangedEvent == null)
        return;
      table4RowChangedEvent((object) this, new AccountingSearchEntity.Table4RowChangeEvent((AccountingSearchEntity.Table4Row) e.Row, e.Action));
    }

    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.Table4RowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      AccountingSearchEntity.Table4RowChangeEventHandler rowChangingEvent = this.Table4RowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new AccountingSearchEntity.Table4RowChangeEvent((AccountingSearchEntity.Table4Row) e.Row, e.Action));
    }

    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.Table4RowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      AccountingSearchEntity.Table4RowChangeEventHandler table4RowDeletedEvent = this.Table4RowDeletedEvent;
      if (table4RowDeletedEvent == null)
        return;
      table4RowDeletedEvent((object) this, new AccountingSearchEntity.Table4RowChangeEvent((AccountingSearchEntity.Table4Row) e.Row, e.Action));
    }

    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.Table4RowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      AccountingSearchEntity.Table4RowChangeEventHandler rowDeletingEvent = this.Table4RowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new AccountingSearchEntity.Table4RowChangeEvent((AccountingSearchEntity.Table4Row) e.Row, e.Action));
    }

    public void RemoveTable4Row(AccountingSearchEntity.Table4Row row)
    {
      this.Rows.Remove((DataRow) row);
    }
  }

  [DebuggerStepThrough]
  public class Table4Row : DataRow
  {
    private AccountingSearchEntity.Table4DataTable tableTable4;

    internal Table4Row(DataRowBuilder rb)
      : base(rb)
    {
      this.tableTable4 = (AccountingSearchEntity.Table4DataTable) this.Table;
    }

    public string Entity_Name
    {
      get => Conversions.ToString(this[this.tableTable4.Entity_NameColumn]);
      set => this[this.tableTable4.Entity_NameColumn] = (object) value;
    }

    public Guid EntityGUID
    {
      get
      {
        object obj = this[this.tableTable4.EntityGUIDColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tableTable4.EntityGUIDColumn] = (object) value;
    }
  }

  [DebuggerStepThrough]
  public class Table4RowChangeEvent : EventArgs
  {
    private AccountingSearchEntity.Table4Row eventRow;
    private DataRowAction eventAction;

    public Table4RowChangeEvent(AccountingSearchEntity.Table4Row row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    public AccountingSearchEntity.Table4Row Row => this.eventRow;

    public DataRowAction Action => this.eventAction;
  }

  [DebuggerStepThrough]
  public class Table5DataTable : DataTable, IEnumerable
  {
    private DataColumn columnEntity_Name;
    private DataColumn columnEntityGUID;

    internal Table5DataTable()
      : base("Table5")
    {
      this.InitClass();
    }

    internal Table5DataTable(DataTable table)
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

    internal DataColumn Entity_NameColumn => this.columnEntity_Name;

    internal DataColumn EntityGUIDColumn => this.columnEntityGUID;

    public AccountingSearchEntity.Table5Row this[int index]
    {
      get => (AccountingSearchEntity.Table5Row) this.Rows[index];
    }

    public event AccountingSearchEntity.Table5RowChangeEventHandler Table5RowChanged;

    public event AccountingSearchEntity.Table5RowChangeEventHandler Table5RowChanging;

    public event AccountingSearchEntity.Table5RowChangeEventHandler Table5RowDeleted;

    public event AccountingSearchEntity.Table5RowChangeEventHandler Table5RowDeleting;

    public void AddTable5Row(AccountingSearchEntity.Table5Row row) => this.Rows.Add((DataRow) row);

    public AccountingSearchEntity.Table5Row AddTable5Row(string Entity_Name, Guid EntityGUID)
    {
      AccountingSearchEntity.Table5Row row = (AccountingSearchEntity.Table5Row) this.NewRow();
      row.ItemArray = new object[2]
      {
        (object) Entity_Name,
        (object) EntityGUID
      };
      this.Rows.Add((DataRow) row);
      return row;
    }

    public AccountingSearchEntity.Table5Row FindByEntityGUID(Guid EntityGUID)
    {
      return (AccountingSearchEntity.Table5Row) this.Rows.Find(new object[1]
      {
        (object) EntityGUID
      });
    }

    public IEnumerator GetEnumerator() => this.Rows.GetEnumerator();

    public override DataTable Clone()
    {
      AccountingSearchEntity.Table5DataTable table5DataTable = (AccountingSearchEntity.Table5DataTable) base.Clone();
      table5DataTable.InitVars();
      return (DataTable) table5DataTable;
    }

    protected override DataTable CreateInstance()
    {
      return (DataTable) new AccountingSearchEntity.Table5DataTable();
    }

    internal void InitVars()
    {
      this.columnEntity_Name = this.Columns["Entity Name"];
      this.columnEntityGUID = this.Columns["EntityGUID"];
    }

    private void InitClass()
    {
      this.columnEntity_Name = new DataColumn("Entity Name", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEntity_Name);
      this.columnEntityGUID = new DataColumn("EntityGUID", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEntityGUID);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnEntityGUID
      }, true));
      this.columnEntity_Name.AllowDBNull = false;
      this.columnEntityGUID.AllowDBNull = false;
      this.columnEntityGUID.Unique = true;
    }

    public AccountingSearchEntity.Table5Row NewTable5Row()
    {
      return (AccountingSearchEntity.Table5Row) this.NewRow();
    }

    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new AccountingSearchEntity.Table5Row(builder);
    }

    protected override Type GetRowType() => typeof (AccountingSearchEntity.Table5Row);

    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.Table5RowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      AccountingSearchEntity.Table5RowChangeEventHandler table5RowChangedEvent = this.Table5RowChangedEvent;
      if (table5RowChangedEvent == null)
        return;
      table5RowChangedEvent((object) this, new AccountingSearchEntity.Table5RowChangeEvent((AccountingSearchEntity.Table5Row) e.Row, e.Action));
    }

    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.Table5RowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      AccountingSearchEntity.Table5RowChangeEventHandler rowChangingEvent = this.Table5RowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new AccountingSearchEntity.Table5RowChangeEvent((AccountingSearchEntity.Table5Row) e.Row, e.Action));
    }

    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.Table5RowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      AccountingSearchEntity.Table5RowChangeEventHandler table5RowDeletedEvent = this.Table5RowDeletedEvent;
      if (table5RowDeletedEvent == null)
        return;
      table5RowDeletedEvent((object) this, new AccountingSearchEntity.Table5RowChangeEvent((AccountingSearchEntity.Table5Row) e.Row, e.Action));
    }

    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.Table5RowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      AccountingSearchEntity.Table5RowChangeEventHandler rowDeletingEvent = this.Table5RowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new AccountingSearchEntity.Table5RowChangeEvent((AccountingSearchEntity.Table5Row) e.Row, e.Action));
    }

    public void RemoveTable5Row(AccountingSearchEntity.Table5Row row)
    {
      this.Rows.Remove((DataRow) row);
    }
  }

  [DebuggerStepThrough]
  public class Table5Row : DataRow
  {
    private AccountingSearchEntity.Table5DataTable tableTable5;

    internal Table5Row(DataRowBuilder rb)
      : base(rb)
    {
      this.tableTable5 = (AccountingSearchEntity.Table5DataTable) this.Table;
    }

    public string Entity_Name
    {
      get => Conversions.ToString(this[this.tableTable5.Entity_NameColumn]);
      set => this[this.tableTable5.Entity_NameColumn] = (object) value;
    }

    public Guid EntityGUID
    {
      get
      {
        object obj = this[this.tableTable5.EntityGUIDColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tableTable5.EntityGUIDColumn] = (object) value;
    }
  }

  [DebuggerStepThrough]
  public class Table5RowChangeEvent : EventArgs
  {
    private AccountingSearchEntity.Table5Row eventRow;
    private DataRowAction eventAction;

    public Table5RowChangeEvent(AccountingSearchEntity.Table5Row row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    public AccountingSearchEntity.Table5Row Row => this.eventRow;

    public DataRowAction Action => this.eventAction;
  }

  [DebuggerStepThrough]
  public class Table6DataTable : DataTable, IEnumerable
  {
    private DataColumn columnEntity_Name;
    private DataColumn columnEntityGUID;

    internal Table6DataTable()
      : base("Table6")
    {
      this.InitClass();
    }

    internal Table6DataTable(DataTable table)
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

    internal DataColumn Entity_NameColumn => this.columnEntity_Name;

    internal DataColumn EntityGUIDColumn => this.columnEntityGUID;

    public AccountingSearchEntity.Table6Row this[int index]
    {
      get => (AccountingSearchEntity.Table6Row) this.Rows[index];
    }

    public event AccountingSearchEntity.Table6RowChangeEventHandler Table6RowChanged;

    public event AccountingSearchEntity.Table6RowChangeEventHandler Table6RowChanging;

    public event AccountingSearchEntity.Table6RowChangeEventHandler Table6RowDeleted;

    public event AccountingSearchEntity.Table6RowChangeEventHandler Table6RowDeleting;

    public void AddTable6Row(AccountingSearchEntity.Table6Row row) => this.Rows.Add((DataRow) row);

    public AccountingSearchEntity.Table6Row AddTable6Row(string Entity_Name, Guid EntityGUID)
    {
      AccountingSearchEntity.Table6Row row = (AccountingSearchEntity.Table6Row) this.NewRow();
      row.ItemArray = new object[2]
      {
        (object) Entity_Name,
        (object) EntityGUID
      };
      this.Rows.Add((DataRow) row);
      return row;
    }

    public AccountingSearchEntity.Table6Row FindByEntityGUID(Guid EntityGUID)
    {
      return (AccountingSearchEntity.Table6Row) this.Rows.Find(new object[1]
      {
        (object) EntityGUID
      });
    }

    public IEnumerator GetEnumerator() => this.Rows.GetEnumerator();

    public override DataTable Clone()
    {
      AccountingSearchEntity.Table6DataTable table6DataTable = (AccountingSearchEntity.Table6DataTable) base.Clone();
      table6DataTable.InitVars();
      return (DataTable) table6DataTable;
    }

    protected override DataTable CreateInstance()
    {
      return (DataTable) new AccountingSearchEntity.Table6DataTable();
    }

    internal void InitVars()
    {
      this.columnEntity_Name = this.Columns["Entity Name"];
      this.columnEntityGUID = this.Columns["EntityGUID"];
    }

    private void InitClass()
    {
      this.columnEntity_Name = new DataColumn("Entity Name", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEntity_Name);
      this.columnEntityGUID = new DataColumn("EntityGUID", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEntityGUID);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnEntityGUID
      }, true));
      this.columnEntity_Name.AllowDBNull = false;
      this.columnEntityGUID.AllowDBNull = false;
      this.columnEntityGUID.Unique = true;
    }

    public AccountingSearchEntity.Table6Row NewTable6Row()
    {
      return (AccountingSearchEntity.Table6Row) this.NewRow();
    }

    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new AccountingSearchEntity.Table6Row(builder);
    }

    protected override Type GetRowType() => typeof (AccountingSearchEntity.Table6Row);

    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.Table6RowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      AccountingSearchEntity.Table6RowChangeEventHandler table6RowChangedEvent = this.Table6RowChangedEvent;
      if (table6RowChangedEvent == null)
        return;
      table6RowChangedEvent((object) this, new AccountingSearchEntity.Table6RowChangeEvent((AccountingSearchEntity.Table6Row) e.Row, e.Action));
    }

    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.Table6RowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      AccountingSearchEntity.Table6RowChangeEventHandler rowChangingEvent = this.Table6RowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new AccountingSearchEntity.Table6RowChangeEvent((AccountingSearchEntity.Table6Row) e.Row, e.Action));
    }

    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.Table6RowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      AccountingSearchEntity.Table6RowChangeEventHandler table6RowDeletedEvent = this.Table6RowDeletedEvent;
      if (table6RowDeletedEvent == null)
        return;
      table6RowDeletedEvent((object) this, new AccountingSearchEntity.Table6RowChangeEvent((AccountingSearchEntity.Table6Row) e.Row, e.Action));
    }

    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.Table6RowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      AccountingSearchEntity.Table6RowChangeEventHandler rowDeletingEvent = this.Table6RowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new AccountingSearchEntity.Table6RowChangeEvent((AccountingSearchEntity.Table6Row) e.Row, e.Action));
    }

    public void RemoveTable6Row(AccountingSearchEntity.Table6Row row)
    {
      this.Rows.Remove((DataRow) row);
    }
  }

  [DebuggerStepThrough]
  public class Table6Row : DataRow
  {
    private AccountingSearchEntity.Table6DataTable tableTable6;

    internal Table6Row(DataRowBuilder rb)
      : base(rb)
    {
      this.tableTable6 = (AccountingSearchEntity.Table6DataTable) this.Table;
    }

    public string Entity_Name
    {
      get => Conversions.ToString(this[this.tableTable6.Entity_NameColumn]);
      set => this[this.tableTable6.Entity_NameColumn] = (object) value;
    }

    public Guid EntityGUID
    {
      get
      {
        object obj = this[this.tableTable6.EntityGUIDColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tableTable6.EntityGUIDColumn] = (object) value;
    }
  }

  [DebuggerStepThrough]
  public class Table6RowChangeEvent : EventArgs
  {
    private AccountingSearchEntity.Table6Row eventRow;
    private DataRowAction eventAction;

    public Table6RowChangeEvent(AccountingSearchEntity.Table6Row row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    public AccountingSearchEntity.Table6Row Row => this.eventRow;

    public DataRowAction Action => this.eventAction;
  }

  [DebuggerStepThrough]
  public class Table7DataTable : DataTable, IEnumerable
  {
    private DataColumn columnEntity_Name;
    private DataColumn columnEntityGUID;

    internal Table7DataTable()
      : base("Table7")
    {
      this.InitClass();
    }

    internal Table7DataTable(DataTable table)
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

    internal DataColumn Entity_NameColumn => this.columnEntity_Name;

    internal DataColumn EntityGUIDColumn => this.columnEntityGUID;

    public AccountingSearchEntity.Table7Row this[int index]
    {
      get => (AccountingSearchEntity.Table7Row) this.Rows[index];
    }

    public event AccountingSearchEntity.Table7RowChangeEventHandler Table7RowChanged;

    public event AccountingSearchEntity.Table7RowChangeEventHandler Table7RowChanging;

    public event AccountingSearchEntity.Table7RowChangeEventHandler Table7RowDeleted;

    public event AccountingSearchEntity.Table7RowChangeEventHandler Table7RowDeleting;

    public void AddTable7Row(AccountingSearchEntity.Table7Row row) => this.Rows.Add((DataRow) row);

    public AccountingSearchEntity.Table7Row AddTable7Row(string Entity_Name, Guid EntityGUID)
    {
      AccountingSearchEntity.Table7Row row = (AccountingSearchEntity.Table7Row) this.NewRow();
      row.ItemArray = new object[2]
      {
        (object) Entity_Name,
        (object) EntityGUID
      };
      this.Rows.Add((DataRow) row);
      return row;
    }

    public AccountingSearchEntity.Table7Row FindByEntityGUID(Guid EntityGUID)
    {
      return (AccountingSearchEntity.Table7Row) this.Rows.Find(new object[1]
      {
        (object) EntityGUID
      });
    }

    public IEnumerator GetEnumerator() => this.Rows.GetEnumerator();

    public override DataTable Clone()
    {
      AccountingSearchEntity.Table7DataTable table7DataTable = (AccountingSearchEntity.Table7DataTable) base.Clone();
      table7DataTable.InitVars();
      return (DataTable) table7DataTable;
    }

    protected override DataTable CreateInstance()
    {
      return (DataTable) new AccountingSearchEntity.Table7DataTable();
    }

    internal void InitVars()
    {
      this.columnEntity_Name = this.Columns["Entity Name"];
      this.columnEntityGUID = this.Columns["EntityGUID"];
    }

    private void InitClass()
    {
      this.columnEntity_Name = new DataColumn("Entity Name", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEntity_Name);
      this.columnEntityGUID = new DataColumn("EntityGUID", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEntityGUID);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnEntityGUID
      }, true));
      this.columnEntity_Name.AllowDBNull = false;
      this.columnEntityGUID.AllowDBNull = false;
      this.columnEntityGUID.Unique = true;
    }

    public AccountingSearchEntity.Table7Row NewTable7Row()
    {
      return (AccountingSearchEntity.Table7Row) this.NewRow();
    }

    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new AccountingSearchEntity.Table7Row(builder);
    }

    protected override Type GetRowType() => typeof (AccountingSearchEntity.Table7Row);

    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.Table7RowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      AccountingSearchEntity.Table7RowChangeEventHandler table7RowChangedEvent = this.Table7RowChangedEvent;
      if (table7RowChangedEvent == null)
        return;
      table7RowChangedEvent((object) this, new AccountingSearchEntity.Table7RowChangeEvent((AccountingSearchEntity.Table7Row) e.Row, e.Action));
    }

    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.Table7RowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      AccountingSearchEntity.Table7RowChangeEventHandler rowChangingEvent = this.Table7RowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new AccountingSearchEntity.Table7RowChangeEvent((AccountingSearchEntity.Table7Row) e.Row, e.Action));
    }

    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.Table7RowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      AccountingSearchEntity.Table7RowChangeEventHandler table7RowDeletedEvent = this.Table7RowDeletedEvent;
      if (table7RowDeletedEvent == null)
        return;
      table7RowDeletedEvent((object) this, new AccountingSearchEntity.Table7RowChangeEvent((AccountingSearchEntity.Table7Row) e.Row, e.Action));
    }

    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.Table7RowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      AccountingSearchEntity.Table7RowChangeEventHandler rowDeletingEvent = this.Table7RowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new AccountingSearchEntity.Table7RowChangeEvent((AccountingSearchEntity.Table7Row) e.Row, e.Action));
    }

    public void RemoveTable7Row(AccountingSearchEntity.Table7Row row)
    {
      this.Rows.Remove((DataRow) row);
    }
  }

  [DebuggerStepThrough]
  public class Table7Row : DataRow
  {
    private AccountingSearchEntity.Table7DataTable tableTable7;

    internal Table7Row(DataRowBuilder rb)
      : base(rb)
    {
      this.tableTable7 = (AccountingSearchEntity.Table7DataTable) this.Table;
    }

    public string Entity_Name
    {
      get => Conversions.ToString(this[this.tableTable7.Entity_NameColumn]);
      set => this[this.tableTable7.Entity_NameColumn] = (object) value;
    }

    public Guid EntityGUID
    {
      get
      {
        object obj = this[this.tableTable7.EntityGUIDColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tableTable7.EntityGUIDColumn] = (object) value;
    }
  }

  [DebuggerStepThrough]
  public class Table7RowChangeEvent : EventArgs
  {
    private AccountingSearchEntity.Table7Row eventRow;
    private DataRowAction eventAction;

    public Table7RowChangeEvent(AccountingSearchEntity.Table7Row row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    public AccountingSearchEntity.Table7Row Row => this.eventRow;

    public DataRowAction Action => this.eventAction;
  }

  [DebuggerStepThrough]
  public class Table8DataTable : DataTable, IEnumerable
  {
    private DataColumn columnEntity_Name;
    private DataColumn columnEntityGUID;

    internal Table8DataTable()
      : base("Table8")
    {
      this.InitClass();
    }

    internal Table8DataTable(DataTable table)
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

    internal DataColumn Entity_NameColumn => this.columnEntity_Name;

    internal DataColumn EntityGUIDColumn => this.columnEntityGUID;

    public AccountingSearchEntity.Table8Row this[int index]
    {
      get => (AccountingSearchEntity.Table8Row) this.Rows[index];
    }

    public event AccountingSearchEntity.Table8RowChangeEventHandler Table8RowChanged;

    public event AccountingSearchEntity.Table8RowChangeEventHandler Table8RowChanging;

    public event AccountingSearchEntity.Table8RowChangeEventHandler Table8RowDeleted;

    public event AccountingSearchEntity.Table8RowChangeEventHandler Table8RowDeleting;

    public void AddTable8Row(AccountingSearchEntity.Table8Row row) => this.Rows.Add((DataRow) row);

    public AccountingSearchEntity.Table8Row AddTable8Row(string Entity_Name, Guid EntityGUID)
    {
      AccountingSearchEntity.Table8Row row = (AccountingSearchEntity.Table8Row) this.NewRow();
      row.ItemArray = new object[2]
      {
        (object) Entity_Name,
        (object) EntityGUID
      };
      this.Rows.Add((DataRow) row);
      return row;
    }

    public IEnumerator GetEnumerator() => this.Rows.GetEnumerator();

    public override DataTable Clone()
    {
      AccountingSearchEntity.Table8DataTable table8DataTable = (AccountingSearchEntity.Table8DataTable) base.Clone();
      table8DataTable.InitVars();
      return (DataTable) table8DataTable;
    }

    protected override DataTable CreateInstance()
    {
      return (DataTable) new AccountingSearchEntity.Table8DataTable();
    }

    internal void InitVars()
    {
      this.columnEntity_Name = this.Columns["Entity Name"];
      this.columnEntityGUID = this.Columns["EntityGUID"];
    }

    private void InitClass()
    {
      this.columnEntity_Name = new DataColumn("Entity Name", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEntity_Name);
      this.columnEntityGUID = new DataColumn("EntityGUID", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEntityGUID);
      this.columnEntity_Name.AllowDBNull = false;
      this.columnEntityGUID.AllowDBNull = false;
    }

    public AccountingSearchEntity.Table8Row NewTable8Row()
    {
      return (AccountingSearchEntity.Table8Row) this.NewRow();
    }

    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new AccountingSearchEntity.Table8Row(builder);
    }

    protected override Type GetRowType() => typeof (AccountingSearchEntity.Table8Row);

    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.Table8RowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      AccountingSearchEntity.Table8RowChangeEventHandler table8RowChangedEvent = this.Table8RowChangedEvent;
      if (table8RowChangedEvent == null)
        return;
      table8RowChangedEvent((object) this, new AccountingSearchEntity.Table8RowChangeEvent((AccountingSearchEntity.Table8Row) e.Row, e.Action));
    }

    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.Table8RowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      AccountingSearchEntity.Table8RowChangeEventHandler rowChangingEvent = this.Table8RowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new AccountingSearchEntity.Table8RowChangeEvent((AccountingSearchEntity.Table8Row) e.Row, e.Action));
    }

    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.Table8RowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      AccountingSearchEntity.Table8RowChangeEventHandler table8RowDeletedEvent = this.Table8RowDeletedEvent;
      if (table8RowDeletedEvent == null)
        return;
      table8RowDeletedEvent((object) this, new AccountingSearchEntity.Table8RowChangeEvent((AccountingSearchEntity.Table8Row) e.Row, e.Action));
    }

    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.Table8RowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      AccountingSearchEntity.Table8RowChangeEventHandler rowDeletingEvent = this.Table8RowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new AccountingSearchEntity.Table8RowChangeEvent((AccountingSearchEntity.Table8Row) e.Row, e.Action));
    }

    public void RemoveTable8Row(AccountingSearchEntity.Table8Row row)
    {
      this.Rows.Remove((DataRow) row);
    }
  }

  [DebuggerStepThrough]
  public class Table8Row : DataRow
  {
    private AccountingSearchEntity.Table8DataTable tableTable8;

    internal Table8Row(DataRowBuilder rb)
      : base(rb)
    {
      this.tableTable8 = (AccountingSearchEntity.Table8DataTable) this.Table;
    }

    public string Entity_Name
    {
      get => Conversions.ToString(this[this.tableTable8.Entity_NameColumn]);
      set => this[this.tableTable8.Entity_NameColumn] = (object) value;
    }

    public Guid EntityGUID
    {
      get
      {
        object obj = this[this.tableTable8.EntityGUIDColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tableTable8.EntityGUIDColumn] = (object) value;
    }
  }

  [DebuggerStepThrough]
  public class Table8RowChangeEvent : EventArgs
  {
    private AccountingSearchEntity.Table8Row eventRow;
    private DataRowAction eventAction;

    public Table8RowChangeEvent(AccountingSearchEntity.Table8Row row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    public AccountingSearchEntity.Table8Row Row => this.eventRow;

    public DataRowAction Action => this.eventAction;
  }

  [DebuggerStepThrough]
  public class Table9DataTable : DataTable, IEnumerable
  {
    private DataColumn columnEntity_Name;
    private DataColumn columnEntityGUID;

    internal Table9DataTable()
      : base("Table9")
    {
      this.InitClass();
    }

    internal Table9DataTable(DataTable table)
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

    internal DataColumn Entity_NameColumn => this.columnEntity_Name;

    internal DataColumn EntityGUIDColumn => this.columnEntityGUID;

    public AccountingSearchEntity.Table9Row this[int index]
    {
      get => (AccountingSearchEntity.Table9Row) this.Rows[index];
    }

    public event AccountingSearchEntity.Table9RowChangeEventHandler Table9RowChanged;

    public event AccountingSearchEntity.Table9RowChangeEventHandler Table9RowChanging;

    public event AccountingSearchEntity.Table9RowChangeEventHandler Table9RowDeleted;

    public event AccountingSearchEntity.Table9RowChangeEventHandler Table9RowDeleting;

    public void AddTable9Row(AccountingSearchEntity.Table9Row row) => this.Rows.Add((DataRow) row);

    public AccountingSearchEntity.Table9Row AddTable9Row(string Entity_Name, Guid EntityGUID)
    {
      AccountingSearchEntity.Table9Row row = (AccountingSearchEntity.Table9Row) this.NewRow();
      row.ItemArray = new object[2]
      {
        (object) Entity_Name,
        (object) EntityGUID
      };
      this.Rows.Add((DataRow) row);
      return row;
    }

    public IEnumerator GetEnumerator() => this.Rows.GetEnumerator();

    public override DataTable Clone()
    {
      AccountingSearchEntity.Table9DataTable table9DataTable = (AccountingSearchEntity.Table9DataTable) base.Clone();
      table9DataTable.InitVars();
      return (DataTable) table9DataTable;
    }

    protected override DataTable CreateInstance()
    {
      return (DataTable) new AccountingSearchEntity.Table9DataTable();
    }

    internal void InitVars()
    {
      this.columnEntity_Name = this.Columns["Entity Name"];
      this.columnEntityGUID = this.Columns["EntityGUID"];
    }

    private void InitClass()
    {
      this.columnEntity_Name = new DataColumn("Entity Name", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEntity_Name);
      this.columnEntityGUID = new DataColumn("EntityGUID", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEntityGUID);
      this.columnEntity_Name.AllowDBNull = false;
      this.columnEntityGUID.AllowDBNull = false;
    }

    public AccountingSearchEntity.Table9Row NewTable9Row()
    {
      return (AccountingSearchEntity.Table9Row) this.NewRow();
    }

    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new AccountingSearchEntity.Table9Row(builder);
    }

    protected override Type GetRowType() => typeof (AccountingSearchEntity.Table9Row);

    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.Table9RowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      AccountingSearchEntity.Table9RowChangeEventHandler table9RowChangedEvent = this.Table9RowChangedEvent;
      if (table9RowChangedEvent == null)
        return;
      table9RowChangedEvent((object) this, new AccountingSearchEntity.Table9RowChangeEvent((AccountingSearchEntity.Table9Row) e.Row, e.Action));
    }

    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.Table9RowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      AccountingSearchEntity.Table9RowChangeEventHandler rowChangingEvent = this.Table9RowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new AccountingSearchEntity.Table9RowChangeEvent((AccountingSearchEntity.Table9Row) e.Row, e.Action));
    }

    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.Table9RowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      AccountingSearchEntity.Table9RowChangeEventHandler table9RowDeletedEvent = this.Table9RowDeletedEvent;
      if (table9RowDeletedEvent == null)
        return;
      table9RowDeletedEvent((object) this, new AccountingSearchEntity.Table9RowChangeEvent((AccountingSearchEntity.Table9Row) e.Row, e.Action));
    }

    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.Table9RowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      AccountingSearchEntity.Table9RowChangeEventHandler rowDeletingEvent = this.Table9RowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new AccountingSearchEntity.Table9RowChangeEvent((AccountingSearchEntity.Table9Row) e.Row, e.Action));
    }

    public void RemoveTable9Row(AccountingSearchEntity.Table9Row row)
    {
      this.Rows.Remove((DataRow) row);
    }
  }

  [DebuggerStepThrough]
  public class Table9Row : DataRow
  {
    private AccountingSearchEntity.Table9DataTable tableTable9;

    internal Table9Row(DataRowBuilder rb)
      : base(rb)
    {
      this.tableTable9 = (AccountingSearchEntity.Table9DataTable) this.Table;
    }

    public string Entity_Name
    {
      get => Conversions.ToString(this[this.tableTable9.Entity_NameColumn]);
      set => this[this.tableTable9.Entity_NameColumn] = (object) value;
    }

    public Guid EntityGUID
    {
      get
      {
        object obj = this[this.tableTable9.EntityGUIDColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tableTable9.EntityGUIDColumn] = (object) value;
    }
  }

  [DebuggerStepThrough]
  public class Table9RowChangeEvent : EventArgs
  {
    private AccountingSearchEntity.Table9Row eventRow;
    private DataRowAction eventAction;

    public Table9RowChangeEvent(AccountingSearchEntity.Table9Row row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    public AccountingSearchEntity.Table9Row Row => this.eventRow;

    public DataRowAction Action => this.eventAction;
  }

  [DebuggerStepThrough]
  public class BankInfoDataTable : DataTable, IEnumerable
  {
    private DataColumn columnBankAcctTypeID;
    private DataColumn columnBankAcctNum;
    private DataColumn columnABARouteNum;
    private DataColumn columnGLAcctID;
    private DataColumn columnNextCheckNum;
    private DataColumn columnBankName;
    private DataColumn columnAddr1;
    private DataColumn columnAddr2;
    private DataColumn columnCity;
    private DataColumn columnState;
    private DataColumn columnZip;
    private DataColumn columnZipExt;
    private DataColumn columnContactName;
    private DataColumn columnContactFax;
    private DataColumn columnContactPhone;
    private DataColumn columnContactEmail;
    private DataColumn columnUpdated;
    private DataColumn columnUserGUID;

    internal BankInfoDataTable()
      : base("BankInfo")
    {
      this.InitClass();
    }

    internal BankInfoDataTable(DataTable table)
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

    internal DataColumn BankAcctTypeIDColumn => this.columnBankAcctTypeID;

    internal DataColumn BankAcctNumColumn => this.columnBankAcctNum;

    internal DataColumn ABARouteNumColumn => this.columnABARouteNum;

    internal DataColumn GLAcctIDColumn => this.columnGLAcctID;

    internal DataColumn NextCheckNumColumn => this.columnNextCheckNum;

    internal DataColumn BankNameColumn => this.columnBankName;

    internal DataColumn Addr1Column => this.columnAddr1;

    internal DataColumn Addr2Column => this.columnAddr2;

    internal DataColumn CityColumn => this.columnCity;

    internal DataColumn StateColumn => this.columnState;

    internal DataColumn ZipColumn => this.columnZip;

    internal DataColumn ZipExtColumn => this.columnZipExt;

    internal DataColumn ContactNameColumn => this.columnContactName;

    internal DataColumn ContactFaxColumn => this.columnContactFax;

    internal DataColumn ContactPhoneColumn => this.columnContactPhone;

    internal DataColumn ContactEmailColumn => this.columnContactEmail;

    internal DataColumn UpdatedColumn => this.columnUpdated;

    internal DataColumn UserGUIDColumn => this.columnUserGUID;

    public AccountingSearchEntity.BankInfoRow this[int index]
    {
      get => (AccountingSearchEntity.BankInfoRow) this.Rows[index];
    }

    public event AccountingSearchEntity.BankInfoRowChangeEventHandler BankInfoRowChanged;

    public event AccountingSearchEntity.BankInfoRowChangeEventHandler BankInfoRowChanging;

    public event AccountingSearchEntity.BankInfoRowChangeEventHandler BankInfoRowDeleted;

    public event AccountingSearchEntity.BankInfoRowChangeEventHandler BankInfoRowDeleting;

    public void AddBankInfoRow(AccountingSearchEntity.BankInfoRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    public AccountingSearchEntity.BankInfoRow AddBankInfoRow(
      string BankAcctTypeID,
      string BankAcctNum,
      string ABARouteNum,
      int GLAcctID,
      int NextCheckNum,
      string BankName,
      string Addr1,
      string Addr2,
      string City,
      string State,
      string Zip,
      string ZipExt,
      string ContactName,
      string ContactFax,
      string ContactPhone,
      string ContactEmail,
      DateTime Updated,
      Guid UserGUID)
    {
      AccountingSearchEntity.BankInfoRow row = (AccountingSearchEntity.BankInfoRow) this.NewRow();
      row.ItemArray = new object[18]
      {
        (object) BankAcctTypeID,
        (object) BankAcctNum,
        (object) ABARouteNum,
        (object) GLAcctID,
        (object) NextCheckNum,
        (object) BankName,
        (object) Addr1,
        (object) Addr2,
        (object) City,
        (object) State,
        (object) Zip,
        (object) ZipExt,
        (object) ContactName,
        (object) ContactFax,
        (object) ContactPhone,
        (object) ContactEmail,
        (object) Updated,
        (object) UserGUID
      };
      this.Rows.Add((DataRow) row);
      return row;
    }

    public AccountingSearchEntity.BankInfoRow FindByBankAcctTypeIDBankAcctNum(
      string BankAcctTypeID,
      string BankAcctNum)
    {
      return (AccountingSearchEntity.BankInfoRow) this.Rows.Find(new object[2]
      {
        (object) BankAcctTypeID,
        (object) BankAcctNum
      });
    }

    public IEnumerator GetEnumerator() => this.Rows.GetEnumerator();

    public override DataTable Clone()
    {
      AccountingSearchEntity.BankInfoDataTable bankInfoDataTable = (AccountingSearchEntity.BankInfoDataTable) base.Clone();
      bankInfoDataTable.InitVars();
      return (DataTable) bankInfoDataTable;
    }

    protected override DataTable CreateInstance()
    {
      return (DataTable) new AccountingSearchEntity.BankInfoDataTable();
    }

    internal void InitVars()
    {
      this.columnBankAcctTypeID = this.Columns["BankAcctTypeID"];
      this.columnBankAcctNum = this.Columns["BankAcctNum"];
      this.columnABARouteNum = this.Columns["ABARouteNum"];
      this.columnGLAcctID = this.Columns["GLAcctID"];
      this.columnNextCheckNum = this.Columns["NextCheckNum"];
      this.columnBankName = this.Columns["BankName"];
      this.columnAddr1 = this.Columns["Addr1"];
      this.columnAddr2 = this.Columns["Addr2"];
      this.columnCity = this.Columns["City"];
      this.columnState = this.Columns["State"];
      this.columnZip = this.Columns["Zip"];
      this.columnZipExt = this.Columns["ZipExt"];
      this.columnContactName = this.Columns["ContactName"];
      this.columnContactFax = this.Columns["ContactFax"];
      this.columnContactPhone = this.Columns["ContactPhone"];
      this.columnContactEmail = this.Columns["ContactEmail"];
      this.columnUpdated = this.Columns["Updated"];
      this.columnUserGUID = this.Columns["UserGUID"];
    }

    private void InitClass()
    {
      this.columnBankAcctTypeID = new DataColumn("BankAcctTypeID", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnBankAcctTypeID);
      this.columnBankAcctNum = new DataColumn("BankAcctNum", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnBankAcctNum);
      this.columnABARouteNum = new DataColumn("ABARouteNum", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnABARouteNum);
      this.columnGLAcctID = new DataColumn("GLAcctID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnGLAcctID);
      this.columnNextCheckNum = new DataColumn("NextCheckNum", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnNextCheckNum);
      this.columnBankName = new DataColumn("BankName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnBankName);
      this.columnAddr1 = new DataColumn("Addr1", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAddr1);
      this.columnAddr2 = new DataColumn("Addr2", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAddr2);
      this.columnCity = new DataColumn("City", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCity);
      this.columnState = new DataColumn("State", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnState);
      this.columnZip = new DataColumn("Zip", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnZip);
      this.columnZipExt = new DataColumn("ZipExt", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnZipExt);
      this.columnContactName = new DataColumn("ContactName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnContactName);
      this.columnContactFax = new DataColumn("ContactFax", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnContactFax);
      this.columnContactPhone = new DataColumn("ContactPhone", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnContactPhone);
      this.columnContactEmail = new DataColumn("ContactEmail", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnContactEmail);
      this.columnUpdated = new DataColumn("Updated", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnUpdated);
      this.columnUserGUID = new DataColumn("UserGUID", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnUserGUID);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[2]
      {
        this.columnBankAcctTypeID,
        this.columnBankAcctNum
      }, true));
      this.columnBankAcctTypeID.AllowDBNull = false;
      this.columnBankAcctNum.AllowDBNull = false;
      this.columnGLAcctID.AllowDBNull = false;
      this.columnBankName.AllowDBNull = false;
      this.columnAddr1.AllowDBNull = false;
      this.columnCity.AllowDBNull = false;
      this.columnState.AllowDBNull = false;
      this.columnZip.AllowDBNull = false;
      this.columnUpdated.AllowDBNull = false;
      this.columnUserGUID.AllowDBNull = false;
    }

    public AccountingSearchEntity.BankInfoRow NewBankInfoRow()
    {
      return (AccountingSearchEntity.BankInfoRow) this.NewRow();
    }

    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new AccountingSearchEntity.BankInfoRow(builder);
    }

    protected override Type GetRowType() => typeof (AccountingSearchEntity.BankInfoRow);

    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.BankInfoRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      AccountingSearchEntity.BankInfoRowChangeEventHandler infoRowChangedEvent = this.BankInfoRowChangedEvent;
      if (infoRowChangedEvent == null)
        return;
      infoRowChangedEvent((object) this, new AccountingSearchEntity.BankInfoRowChangeEvent((AccountingSearchEntity.BankInfoRow) e.Row, e.Action));
    }

    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.BankInfoRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      AccountingSearchEntity.BankInfoRowChangeEventHandler rowChangingEvent = this.BankInfoRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new AccountingSearchEntity.BankInfoRowChangeEvent((AccountingSearchEntity.BankInfoRow) e.Row, e.Action));
    }

    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.BankInfoRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      AccountingSearchEntity.BankInfoRowChangeEventHandler infoRowDeletedEvent = this.BankInfoRowDeletedEvent;
      if (infoRowDeletedEvent == null)
        return;
      infoRowDeletedEvent((object) this, new AccountingSearchEntity.BankInfoRowChangeEvent((AccountingSearchEntity.BankInfoRow) e.Row, e.Action));
    }

    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.BankInfoRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      AccountingSearchEntity.BankInfoRowChangeEventHandler rowDeletingEvent = this.BankInfoRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new AccountingSearchEntity.BankInfoRowChangeEvent((AccountingSearchEntity.BankInfoRow) e.Row, e.Action));
    }

    public void RemoveBankInfoRow(AccountingSearchEntity.BankInfoRow row)
    {
      this.Rows.Remove((DataRow) row);
    }
  }

  [DebuggerStepThrough]
  public class BankInfoRow : DataRow
  {
    private AccountingSearchEntity.BankInfoDataTable tableBankInfo;

    internal BankInfoRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableBankInfo = (AccountingSearchEntity.BankInfoDataTable) this.Table;
    }

    public string BankAcctTypeID
    {
      get => Conversions.ToString(this[this.tableBankInfo.BankAcctTypeIDColumn]);
      set => this[this.tableBankInfo.BankAcctTypeIDColumn] = (object) value;
    }

    public string BankAcctNum
    {
      get => Conversions.ToString(this[this.tableBankInfo.BankAcctNumColumn]);
      set => this[this.tableBankInfo.BankAcctNumColumn] = (object) value;
    }

    public string ABARouteNum
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableBankInfo.ABARouteNumColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableBankInfo.ABARouteNumColumn] = (object) value;
    }

    public int GLAcctID
    {
      get => Conversions.ToInteger(this[this.tableBankInfo.GLAcctIDColumn]);
      set => this[this.tableBankInfo.GLAcctIDColumn] = (object) value;
    }

    public int NextCheckNum
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tableBankInfo.NextCheckNumColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableBankInfo.NextCheckNumColumn] = (object) value;
    }

    public string BankName
    {
      get => Conversions.ToString(this[this.tableBankInfo.BankNameColumn]);
      set => this[this.tableBankInfo.BankNameColumn] = (object) value;
    }

    public string Addr1
    {
      get => Conversions.ToString(this[this.tableBankInfo.Addr1Column]);
      set => this[this.tableBankInfo.Addr1Column] = (object) value;
    }

    public string Addr2
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableBankInfo.Addr2Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableBankInfo.Addr2Column] = (object) value;
    }

    public string City
    {
      get => Conversions.ToString(this[this.tableBankInfo.CityColumn]);
      set => this[this.tableBankInfo.CityColumn] = (object) value;
    }

    public string State
    {
      get => Conversions.ToString(this[this.tableBankInfo.StateColumn]);
      set => this[this.tableBankInfo.StateColumn] = (object) value;
    }

    public string Zip
    {
      get => Conversions.ToString(this[this.tableBankInfo.ZipColumn]);
      set => this[this.tableBankInfo.ZipColumn] = (object) value;
    }

    public string ZipExt
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableBankInfo.ZipExtColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableBankInfo.ZipExtColumn] = (object) value;
    }

    public string ContactName
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableBankInfo.ContactNameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableBankInfo.ContactNameColumn] = (object) value;
    }

    public string ContactFax
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableBankInfo.ContactFaxColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableBankInfo.ContactFaxColumn] = (object) value;
    }

    public string ContactPhone
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableBankInfo.ContactPhoneColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableBankInfo.ContactPhoneColumn] = (object) value;
    }

    public string ContactEmail
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableBankInfo.ContactEmailColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableBankInfo.ContactEmailColumn] = (object) value;
    }

    public DateTime Updated
    {
      get => Conversions.ToDate(this[this.tableBankInfo.UpdatedColumn]);
      set => this[this.tableBankInfo.UpdatedColumn] = (object) value;
    }

    public Guid UserGUID
    {
      get
      {
        object obj = this[this.tableBankInfo.UserGUIDColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tableBankInfo.UserGUIDColumn] = (object) value;
    }

    public bool IsABARouteNumNull() => this.IsNull(this.tableBankInfo.ABARouteNumColumn);

    public void SetABARouteNumNull()
    {
      this[this.tableBankInfo.ABARouteNumColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsNextCheckNumNull() => this.IsNull(this.tableBankInfo.NextCheckNumColumn);

    public void SetNextCheckNumNull()
    {
      this[this.tableBankInfo.NextCheckNumColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsAddr2Null() => this.IsNull(this.tableBankInfo.Addr2Column);

    public void SetAddr2Null()
    {
      this[this.tableBankInfo.Addr2Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsZipExtNull() => this.IsNull(this.tableBankInfo.ZipExtColumn);

    public void SetZipExtNull()
    {
      this[this.tableBankInfo.ZipExtColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsContactNameNull() => this.IsNull(this.tableBankInfo.ContactNameColumn);

    public void SetContactNameNull()
    {
      this[this.tableBankInfo.ContactNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsContactFaxNull() => this.IsNull(this.tableBankInfo.ContactFaxColumn);

    public void SetContactFaxNull()
    {
      this[this.tableBankInfo.ContactFaxColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsContactPhoneNull() => this.IsNull(this.tableBankInfo.ContactPhoneColumn);

    public void SetContactPhoneNull()
    {
      this[this.tableBankInfo.ContactPhoneColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsContactEmailNull() => this.IsNull(this.tableBankInfo.ContactEmailColumn);

    public void SetContactEmailNull()
    {
      this[this.tableBankInfo.ContactEmailColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  [DebuggerStepThrough]
  public class BankInfoRowChangeEvent : EventArgs
  {
    private AccountingSearchEntity.BankInfoRow eventRow;
    private DataRowAction eventAction;

    public BankInfoRowChangeEvent(AccountingSearchEntity.BankInfoRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    public AccountingSearchEntity.BankInfoRow Row => this.eventRow;

    public DataRowAction Action => this.eventAction;
  }

  [DebuggerStepThrough]
  public class _TableDataTable : DataTable, IEnumerable
  {
    private DataColumn columnBankAcctTypeID;
    private DataColumn columnBankAcctType;

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

    internal DataColumn BankAcctTypeIDColumn => this.columnBankAcctTypeID;

    internal DataColumn BankAcctTypeColumn => this.columnBankAcctType;

    public AccountingSearchEntity._TableRow this[int index]
    {
      get => (AccountingSearchEntity._TableRow) this.Rows[index];
    }

    public event AccountingSearchEntity._TableRowChangeEventHandler _TableRowChanged;

    public event AccountingSearchEntity._TableRowChangeEventHandler _TableRowChanging;

    public event AccountingSearchEntity._TableRowChangeEventHandler _TableRowDeleted;

    public event AccountingSearchEntity._TableRowChangeEventHandler _TableRowDeleting;

    public void Add_TableRow(AccountingSearchEntity._TableRow row) => this.Rows.Add((DataRow) row);

    public AccountingSearchEntity._TableRow Add_TableRow(string BankAcctTypeID, string BankAcctType)
    {
      AccountingSearchEntity._TableRow row = (AccountingSearchEntity._TableRow) this.NewRow();
      row.ItemArray = new object[2]
      {
        (object) BankAcctTypeID,
        (object) BankAcctType
      };
      this.Rows.Add((DataRow) row);
      return row;
    }

    public AccountingSearchEntity._TableRow FindByBankAcctTypeID(string BankAcctTypeID)
    {
      return (AccountingSearchEntity._TableRow) this.Rows.Find(new object[1]
      {
        (object) BankAcctTypeID
      });
    }

    public IEnumerator GetEnumerator() => this.Rows.GetEnumerator();

    public override DataTable Clone()
    {
      AccountingSearchEntity._TableDataTable tableDataTable = (AccountingSearchEntity._TableDataTable) base.Clone();
      tableDataTable.InitVars();
      return (DataTable) tableDataTable;
    }

    protected override DataTable CreateInstance()
    {
      return (DataTable) new AccountingSearchEntity._TableDataTable();
    }

    internal void InitVars()
    {
      this.columnBankAcctTypeID = this.Columns["BankAcctTypeID"];
      this.columnBankAcctType = this.Columns["BankAcctType"];
    }

    private void InitClass()
    {
      this.columnBankAcctTypeID = new DataColumn("BankAcctTypeID", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnBankAcctTypeID);
      this.columnBankAcctType = new DataColumn("BankAcctType", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnBankAcctType);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnBankAcctTypeID
      }, true));
      this.columnBankAcctTypeID.AllowDBNull = false;
      this.columnBankAcctTypeID.Unique = true;
      this.columnBankAcctType.AllowDBNull = false;
    }

    public AccountingSearchEntity._TableRow New_TableRow()
    {
      return (AccountingSearchEntity._TableRow) this.NewRow();
    }

    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new AccountingSearchEntity._TableRow(builder);
    }

    protected override Type GetRowType() => typeof (AccountingSearchEntity._TableRow);

    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this._TableRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      AccountingSearchEntity._TableRowChangeEventHandler tableRowChangedEvent = this._TableRowChangedEvent;
      if (tableRowChangedEvent == null)
        return;
      tableRowChangedEvent((object) this, new AccountingSearchEntity._TableRowChangeEvent((AccountingSearchEntity._TableRow) e.Row, e.Action));
    }

    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this._TableRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      AccountingSearchEntity._TableRowChangeEventHandler rowChangingEvent = this._TableRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new AccountingSearchEntity._TableRowChangeEvent((AccountingSearchEntity._TableRow) e.Row, e.Action));
    }

    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this._TableRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      AccountingSearchEntity._TableRowChangeEventHandler tableRowDeletedEvent = this._TableRowDeletedEvent;
      if (tableRowDeletedEvent == null)
        return;
      tableRowDeletedEvent((object) this, new AccountingSearchEntity._TableRowChangeEvent((AccountingSearchEntity._TableRow) e.Row, e.Action));
    }

    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this._TableRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      AccountingSearchEntity._TableRowChangeEventHandler rowDeletingEvent = this._TableRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new AccountingSearchEntity._TableRowChangeEvent((AccountingSearchEntity._TableRow) e.Row, e.Action));
    }

    public void Remove_TableRow(AccountingSearchEntity._TableRow row)
    {
      this.Rows.Remove((DataRow) row);
    }
  }

  [DebuggerStepThrough]
  public class _TableRow : DataRow
  {
    private AccountingSearchEntity._TableDataTable table_Table;

    internal _TableRow(DataRowBuilder rb)
      : base(rb)
    {
      this.table_Table = (AccountingSearchEntity._TableDataTable) this.Table;
    }

    public string BankAcctTypeID
    {
      get => Conversions.ToString(this[this.table_Table.BankAcctTypeIDColumn]);
      set => this[this.table_Table.BankAcctTypeIDColumn] = (object) value;
    }

    public string BankAcctType
    {
      get => Conversions.ToString(this[this.table_Table.BankAcctTypeColumn]);
      set => this[this.table_Table.BankAcctTypeColumn] = (object) value;
    }
  }

  [DebuggerStepThrough]
  public class _TableRowChangeEvent : EventArgs
  {
    private AccountingSearchEntity._TableRow eventRow;
    private DataRowAction eventAction;

    public _TableRowChangeEvent(AccountingSearchEntity._TableRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    public AccountingSearchEntity._TableRow Row => this.eventRow;

    public DataRowAction Action => this.eventAction;
  }
}
