// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.AccountingDatasets.dsPayeeAddressSelections
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
public class dsPayeeAddressSelections : DataSet
{
  private dsPayeeAddressSelections.spFin_GetPayeeAddressSelectionsDataTable tablespFin_GetPayeeAddressSelections;
  private dsPayeeAddressSelections.Table1DataTable tableTable1;
  private dsPayeeAddressSelections.Table2DataTable tableTable2;

  public dsPayeeAddressSelections()
  {
    this.InitClass();
    CollectionChangeEventHandler changeEventHandler = new CollectionChangeEventHandler(this.SchemaChanged);
    this.Tables.CollectionChanged += changeEventHandler;
    this.Relations.CollectionChanged += changeEventHandler;
  }

  protected dsPayeeAddressSelections(SerializationInfo info, StreamingContext context)
  {
    string s = Conversions.ToString(info.GetValue("XmlSchema", typeof (string)));
    if (s != null)
    {
      DataSet dataSet = new DataSet();
      dataSet.ReadXmlSchema((XmlReader) new XmlTextReader((TextReader) new StringReader(s)));
      if (dataSet.Tables[nameof (spFin_GetPayeeAddressSelections)] != null)
        this.Tables.Add((DataTable) new dsPayeeAddressSelections.spFin_GetPayeeAddressSelectionsDataTable(dataSet.Tables[nameof (spFin_GetPayeeAddressSelections)]));
      if (dataSet.Tables[nameof (Table1)] != null)
        this.Tables.Add((DataTable) new dsPayeeAddressSelections.Table1DataTable(dataSet.Tables[nameof (Table1)]));
      if (dataSet.Tables[nameof (Table2)] != null)
        this.Tables.Add((DataTable) new dsPayeeAddressSelections.Table2DataTable(dataSet.Tables[nameof (Table2)]));
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
  public dsPayeeAddressSelections.spFin_GetPayeeAddressSelectionsDataTable spFin_GetPayeeAddressSelections
  {
    get => this.tablespFin_GetPayeeAddressSelections;
  }

  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsPayeeAddressSelections.Table1DataTable Table1 => this.tableTable1;

  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsPayeeAddressSelections.Table2DataTable Table2 => this.tableTable2;

  public override DataSet Clone()
  {
    dsPayeeAddressSelections addressSelections = (dsPayeeAddressSelections) base.Clone();
    addressSelections.InitVars();
    return (DataSet) addressSelections;
  }

  protected override bool ShouldSerializeTables() => false;

  protected override bool ShouldSerializeRelations() => false;

  protected override void ReadXmlSerializable(XmlReader reader)
  {
    this.Reset();
    DataSet dataSet = new DataSet();
    int num = (int) dataSet.ReadXml(reader);
    if (dataSet.Tables["spFin_GetPayeeAddressSelections"] != null)
      this.Tables.Add((DataTable) new dsPayeeAddressSelections.spFin_GetPayeeAddressSelectionsDataTable(dataSet.Tables["spFin_GetPayeeAddressSelections"]));
    if (dataSet.Tables["Table1"] != null)
      this.Tables.Add((DataTable) new dsPayeeAddressSelections.Table1DataTable(dataSet.Tables["Table1"]));
    if (dataSet.Tables["Table2"] != null)
      this.Tables.Add((DataTable) new dsPayeeAddressSelections.Table2DataTable(dataSet.Tables["Table2"]));
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
    this.tablespFin_GetPayeeAddressSelections = (dsPayeeAddressSelections.spFin_GetPayeeAddressSelectionsDataTable) this.Tables["spFin_GetPayeeAddressSelections"];
    if (this.tablespFin_GetPayeeAddressSelections != null)
      this.tablespFin_GetPayeeAddressSelections.InitVars();
    this.tableTable1 = (dsPayeeAddressSelections.Table1DataTable) this.Tables["Table1"];
    if (this.tableTable1 != null)
      this.tableTable1.InitVars();
    this.tableTable2 = (dsPayeeAddressSelections.Table2DataTable) this.Tables["Table2"];
    if (this.tableTable2 == null)
      return;
    this.tableTable2.InitVars();
  }

  private void InitClass()
  {
    this.DataSetName = nameof (dsPayeeAddressSelections);
    this.Prefix = "";
    this.Namespace = "http://www.tempuri.org/dsPayeeAddressSelections.xsd";
    this.Locale = new CultureInfo("en-US");
    this.CaseSensitive = false;
    this.EnforceConstraints = true;
    this.tablespFin_GetPayeeAddressSelections = new dsPayeeAddressSelections.spFin_GetPayeeAddressSelectionsDataTable();
    this.Tables.Add((DataTable) this.tablespFin_GetPayeeAddressSelections);
    this.tableTable1 = new dsPayeeAddressSelections.Table1DataTable();
    this.Tables.Add((DataTable) this.tableTable1);
    this.tableTable2 = new dsPayeeAddressSelections.Table2DataTable();
    this.Tables.Add((DataTable) this.tableTable2);
  }

  private bool ShouldSerializespFin_GetPayeeAddressSelections() => false;

  private bool ShouldSerializeTable1() => false;

  private bool ShouldSerializeTable2() => false;

  private void SchemaChanged(object sender, CollectionChangeEventArgs e)
  {
    if (e.Action != CollectionChangeAction.Remove)
      return;
    this.InitVars();
  }

  public delegate void spFin_GetPayeeAddressSelectionsRowChangeEventHandler(
    object sender,
    dsPayeeAddressSelections.spFin_GetPayeeAddressSelectionsRowChangeEvent e);

  public delegate void Table1RowChangeEventHandler(
    object sender,
    dsPayeeAddressSelections.Table1RowChangeEvent e);

  public delegate void Table2RowChangeEventHandler(
    object sender,
    dsPayeeAddressSelections.Table2RowChangeEvent e);

  [DebuggerStepThrough]
  public class spFin_GetPayeeAddressSelectionsDataTable : DataTable, IEnumerable
  {
    private DataColumn columnAlternate_Address;
    private DataColumn columnADDRESS1;
    private DataColumn columnADDRESS2;
    private DataColumn columnCITY;
    private DataColumn columnSTATE;
    private DataColumn columnZIPCODE;
    private DataColumn columnZIPPLUS;
    private DataColumn columnNAME;

    internal spFin_GetPayeeAddressSelectionsDataTable()
      : base("spFin_GetPayeeAddressSelections")
    {
      this.InitClass();
    }

    internal spFin_GetPayeeAddressSelectionsDataTable(DataTable table)
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

    internal DataColumn Alternate_AddressColumn => this.columnAlternate_Address;

    internal DataColumn ADDRESS1Column => this.columnADDRESS1;

    internal DataColumn ADDRESS2Column => this.columnADDRESS2;

    internal DataColumn CITYColumn => this.columnCITY;

    internal DataColumn STATEColumn => this.columnSTATE;

    internal DataColumn ZIPCODEColumn => this.columnZIPCODE;

    internal DataColumn ZIPPLUSColumn => this.columnZIPPLUS;

    internal DataColumn NAMEColumn => this.columnNAME;

    public dsPayeeAddressSelections.spFin_GetPayeeAddressSelectionsRow this[int index]
    {
      get => (dsPayeeAddressSelections.spFin_GetPayeeAddressSelectionsRow) this.Rows[index];
    }

    public event dsPayeeAddressSelections.spFin_GetPayeeAddressSelectionsRowChangeEventHandler spFin_GetPayeeAddressSelectionsRowChanged;

    public event dsPayeeAddressSelections.spFin_GetPayeeAddressSelectionsRowChangeEventHandler spFin_GetPayeeAddressSelectionsRowChanging;

    public event dsPayeeAddressSelections.spFin_GetPayeeAddressSelectionsRowChangeEventHandler spFin_GetPayeeAddressSelectionsRowDeleted;

    public event dsPayeeAddressSelections.spFin_GetPayeeAddressSelectionsRowChangeEventHandler spFin_GetPayeeAddressSelectionsRowDeleting;

    public void AddspFin_GetPayeeAddressSelectionsRow(
      dsPayeeAddressSelections.spFin_GetPayeeAddressSelectionsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    public dsPayeeAddressSelections.spFin_GetPayeeAddressSelectionsRow AddspFin_GetPayeeAddressSelectionsRow(
      string Alternate_Address,
      string ADDRESS1,
      string ADDRESS2,
      string CITY,
      string STATE,
      string ZIPCODE,
      string ZIPPLUS,
      string NAME)
    {
      dsPayeeAddressSelections.spFin_GetPayeeAddressSelectionsRow row = (dsPayeeAddressSelections.spFin_GetPayeeAddressSelectionsRow) this.NewRow();
      row.ItemArray = new object[8]
      {
        (object) Alternate_Address,
        (object) ADDRESS1,
        (object) ADDRESS2,
        (object) CITY,
        (object) STATE,
        (object) ZIPCODE,
        (object) ZIPPLUS,
        (object) NAME
      };
      this.Rows.Add((DataRow) row);
      return row;
    }

    public IEnumerator GetEnumerator() => this.Rows.GetEnumerator();

    public override DataTable Clone()
    {
      dsPayeeAddressSelections.spFin_GetPayeeAddressSelectionsDataTable selectionsDataTable = (dsPayeeAddressSelections.spFin_GetPayeeAddressSelectionsDataTable) base.Clone();
      selectionsDataTable.InitVars();
      return (DataTable) selectionsDataTable;
    }

    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsPayeeAddressSelections.spFin_GetPayeeAddressSelectionsDataTable();
    }

    internal void InitVars()
    {
      this.columnAlternate_Address = this.Columns["Alternate Address"];
      this.columnADDRESS1 = this.Columns["ADDRESS1"];
      this.columnADDRESS2 = this.Columns["ADDRESS2"];
      this.columnCITY = this.Columns["CITY"];
      this.columnSTATE = this.Columns["STATE"];
      this.columnZIPCODE = this.Columns["ZIPCODE"];
      this.columnZIPPLUS = this.Columns["ZIPPLUS"];
      this.columnNAME = this.Columns["NAME"];
    }

    private void InitClass()
    {
      this.columnAlternate_Address = new DataColumn("Alternate Address", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAlternate_Address);
      this.columnADDRESS1 = new DataColumn("ADDRESS1", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnADDRESS1);
      this.columnADDRESS2 = new DataColumn("ADDRESS2", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnADDRESS2);
      this.columnCITY = new DataColumn("CITY", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCITY);
      this.columnSTATE = new DataColumn("STATE", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSTATE);
      this.columnZIPCODE = new DataColumn("ZIPCODE", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnZIPCODE);
      this.columnZIPPLUS = new DataColumn("ZIPPLUS", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnZIPPLUS);
      this.columnNAME = new DataColumn("NAME", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnNAME);
      this.columnAlternate_Address.ReadOnly = true;
      this.columnADDRESS1.AllowDBNull = false;
      this.columnCITY.AllowDBNull = false;
    }

    public dsPayeeAddressSelections.spFin_GetPayeeAddressSelectionsRow NewspFin_GetPayeeAddressSelectionsRow()
    {
      return (dsPayeeAddressSelections.spFin_GetPayeeAddressSelectionsRow) this.NewRow();
    }

    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsPayeeAddressSelections.spFin_GetPayeeAddressSelectionsRow(builder);
    }

    protected override Type GetRowType()
    {
      return typeof (dsPayeeAddressSelections.spFin_GetPayeeAddressSelectionsRow);
    }

    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.spFin_GetPayeeAddressSelectionsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPayeeAddressSelections.spFin_GetPayeeAddressSelectionsRowChangeEventHandler selectionsRowChangedEvent = this.spFin_GetPayeeAddressSelectionsRowChangedEvent;
      if (selectionsRowChangedEvent == null)
        return;
      selectionsRowChangedEvent((object) this, new dsPayeeAddressSelections.spFin_GetPayeeAddressSelectionsRowChangeEvent((dsPayeeAddressSelections.spFin_GetPayeeAddressSelectionsRow) e.Row, e.Action));
    }

    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.spFin_GetPayeeAddressSelectionsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPayeeAddressSelections.spFin_GetPayeeAddressSelectionsRowChangeEventHandler rowChangingEvent = this.spFin_GetPayeeAddressSelectionsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsPayeeAddressSelections.spFin_GetPayeeAddressSelectionsRowChangeEvent((dsPayeeAddressSelections.spFin_GetPayeeAddressSelectionsRow) e.Row, e.Action));
    }

    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.spFin_GetPayeeAddressSelectionsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPayeeAddressSelections.spFin_GetPayeeAddressSelectionsRowChangeEventHandler selectionsRowDeletedEvent = this.spFin_GetPayeeAddressSelectionsRowDeletedEvent;
      if (selectionsRowDeletedEvent == null)
        return;
      selectionsRowDeletedEvent((object) this, new dsPayeeAddressSelections.spFin_GetPayeeAddressSelectionsRowChangeEvent((dsPayeeAddressSelections.spFin_GetPayeeAddressSelectionsRow) e.Row, e.Action));
    }

    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.spFin_GetPayeeAddressSelectionsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPayeeAddressSelections.spFin_GetPayeeAddressSelectionsRowChangeEventHandler rowDeletingEvent = this.spFin_GetPayeeAddressSelectionsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsPayeeAddressSelections.spFin_GetPayeeAddressSelectionsRowChangeEvent((dsPayeeAddressSelections.spFin_GetPayeeAddressSelectionsRow) e.Row, e.Action));
    }

    public void RemovespFin_GetPayeeAddressSelectionsRow(
      dsPayeeAddressSelections.spFin_GetPayeeAddressSelectionsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }
  }

  [DebuggerStepThrough]
  public class spFin_GetPayeeAddressSelectionsRow : DataRow
  {
    private dsPayeeAddressSelections.spFin_GetPayeeAddressSelectionsDataTable tablespFin_GetPayeeAddressSelections;

    internal spFin_GetPayeeAddressSelectionsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablespFin_GetPayeeAddressSelections = (dsPayeeAddressSelections.spFin_GetPayeeAddressSelectionsDataTable) this.Table;
    }

    public string Alternate_Address
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablespFin_GetPayeeAddressSelections.Alternate_AddressColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set
      {
        this[this.tablespFin_GetPayeeAddressSelections.Alternate_AddressColumn] = (object) value;
      }
    }

    public string ADDRESS1
    {
      get => Conversions.ToString(this[this.tablespFin_GetPayeeAddressSelections.ADDRESS1Column]);
      set => this[this.tablespFin_GetPayeeAddressSelections.ADDRESS1Column] = (object) value;
    }

    public string ADDRESS2
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablespFin_GetPayeeAddressSelections.ADDRESS2Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablespFin_GetPayeeAddressSelections.ADDRESS2Column] = (object) value;
    }

    public string CITY
    {
      get => Conversions.ToString(this[this.tablespFin_GetPayeeAddressSelections.CITYColumn]);
      set => this[this.tablespFin_GetPayeeAddressSelections.CITYColumn] = (object) value;
    }

    public string STATE
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablespFin_GetPayeeAddressSelections.STATEColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablespFin_GetPayeeAddressSelections.STATEColumn] = (object) value;
    }

    public string ZIPCODE
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablespFin_GetPayeeAddressSelections.ZIPCODEColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablespFin_GetPayeeAddressSelections.ZIPCODEColumn] = (object) value;
    }

    public string ZIPPLUS
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablespFin_GetPayeeAddressSelections.ZIPPLUSColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablespFin_GetPayeeAddressSelections.ZIPPLUSColumn] = (object) value;
    }

    public string NAME
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablespFin_GetPayeeAddressSelections.NAMEColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablespFin_GetPayeeAddressSelections.NAMEColumn] = (object) value;
    }

    public bool IsAlternate_AddressNull()
    {
      return this.IsNull(this.tablespFin_GetPayeeAddressSelections.Alternate_AddressColumn);
    }

    public void SetAlternate_AddressNull()
    {
      this[this.tablespFin_GetPayeeAddressSelections.Alternate_AddressColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsADDRESS2Null()
    {
      return this.IsNull(this.tablespFin_GetPayeeAddressSelections.ADDRESS2Column);
    }

    public void SetADDRESS2Null()
    {
      this[this.tablespFin_GetPayeeAddressSelections.ADDRESS2Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsSTATENull() => this.IsNull(this.tablespFin_GetPayeeAddressSelections.STATEColumn);

    public void SetSTATENull()
    {
      this[this.tablespFin_GetPayeeAddressSelections.STATEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsZIPCODENull()
    {
      return this.IsNull(this.tablespFin_GetPayeeAddressSelections.ZIPCODEColumn);
    }

    public void SetZIPCODENull()
    {
      this[this.tablespFin_GetPayeeAddressSelections.ZIPCODEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsZIPPLUSNull()
    {
      return this.IsNull(this.tablespFin_GetPayeeAddressSelections.ZIPPLUSColumn);
    }

    public void SetZIPPLUSNull()
    {
      this[this.tablespFin_GetPayeeAddressSelections.ZIPPLUSColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsNAMENull() => this.IsNull(this.tablespFin_GetPayeeAddressSelections.NAMEColumn);

    public void SetNAMENull()
    {
      this[this.tablespFin_GetPayeeAddressSelections.NAMEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  [DebuggerStepThrough]
  public class spFin_GetPayeeAddressSelectionsRowChangeEvent : EventArgs
  {
    private dsPayeeAddressSelections.spFin_GetPayeeAddressSelectionsRow eventRow;
    private DataRowAction eventAction;

    public spFin_GetPayeeAddressSelectionsRowChangeEvent(
      dsPayeeAddressSelections.spFin_GetPayeeAddressSelectionsRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    public dsPayeeAddressSelections.spFin_GetPayeeAddressSelectionsRow Row => this.eventRow;

    public DataRowAction Action => this.eventAction;
  }

  [DebuggerStepThrough]
  public class Table1DataTable : DataTable, IEnumerable
  {
    private DataColumn columnAlternate_Address;
    private DataColumn columnADDRESS1;
    private DataColumn columnADDRESS2;
    private DataColumn columnCITY;
    private DataColumn columnSTATE;
    private DataColumn columnZIPCODE;
    private DataColumn columnZIPPLUS;
    private DataColumn columnNAME;

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

    internal DataColumn Alternate_AddressColumn => this.columnAlternate_Address;

    internal DataColumn ADDRESS1Column => this.columnADDRESS1;

    internal DataColumn ADDRESS2Column => this.columnADDRESS2;

    internal DataColumn CITYColumn => this.columnCITY;

    internal DataColumn STATEColumn => this.columnSTATE;

    internal DataColumn ZIPCODEColumn => this.columnZIPCODE;

    internal DataColumn ZIPPLUSColumn => this.columnZIPPLUS;

    internal DataColumn NAMEColumn => this.columnNAME;

    public dsPayeeAddressSelections.Table1Row this[int index]
    {
      get => (dsPayeeAddressSelections.Table1Row) this.Rows[index];
    }

    public event dsPayeeAddressSelections.Table1RowChangeEventHandler Table1RowChanged;

    public event dsPayeeAddressSelections.Table1RowChangeEventHandler Table1RowChanging;

    public event dsPayeeAddressSelections.Table1RowChangeEventHandler Table1RowDeleted;

    public event dsPayeeAddressSelections.Table1RowChangeEventHandler Table1RowDeleting;

    public void AddTable1Row(dsPayeeAddressSelections.Table1Row row)
    {
      this.Rows.Add((DataRow) row);
    }

    public dsPayeeAddressSelections.Table1Row AddTable1Row(
      string Alternate_Address,
      string ADDRESS1,
      string ADDRESS2,
      string CITY,
      string STATE,
      string ZIPCODE,
      string ZIPPLUS,
      string NAME)
    {
      dsPayeeAddressSelections.Table1Row row = (dsPayeeAddressSelections.Table1Row) this.NewRow();
      row.ItemArray = new object[8]
      {
        (object) Alternate_Address,
        (object) ADDRESS1,
        (object) ADDRESS2,
        (object) CITY,
        (object) STATE,
        (object) ZIPCODE,
        (object) ZIPPLUS,
        (object) NAME
      };
      this.Rows.Add((DataRow) row);
      return row;
    }

    public IEnumerator GetEnumerator() => this.Rows.GetEnumerator();

    public override DataTable Clone()
    {
      dsPayeeAddressSelections.Table1DataTable table1DataTable = (dsPayeeAddressSelections.Table1DataTable) base.Clone();
      table1DataTable.InitVars();
      return (DataTable) table1DataTable;
    }

    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsPayeeAddressSelections.Table1DataTable();
    }

    internal void InitVars()
    {
      this.columnAlternate_Address = this.Columns["Alternate Address"];
      this.columnADDRESS1 = this.Columns["ADDRESS1"];
      this.columnADDRESS2 = this.Columns["ADDRESS2"];
      this.columnCITY = this.Columns["CITY"];
      this.columnSTATE = this.Columns["STATE"];
      this.columnZIPCODE = this.Columns["ZIPCODE"];
      this.columnZIPPLUS = this.Columns["ZIPPLUS"];
      this.columnNAME = this.Columns["NAME"];
    }

    private void InitClass()
    {
      this.columnAlternate_Address = new DataColumn("Alternate Address", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAlternate_Address);
      this.columnADDRESS1 = new DataColumn("ADDRESS1", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnADDRESS1);
      this.columnADDRESS2 = new DataColumn("ADDRESS2", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnADDRESS2);
      this.columnCITY = new DataColumn("CITY", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCITY);
      this.columnSTATE = new DataColumn("STATE", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSTATE);
      this.columnZIPCODE = new DataColumn("ZIPCODE", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnZIPCODE);
      this.columnZIPPLUS = new DataColumn("ZIPPLUS", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnZIPPLUS);
      this.columnNAME = new DataColumn("NAME", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnNAME);
      this.columnAlternate_Address.ReadOnly = true;
      this.columnADDRESS1.AllowDBNull = false;
      this.columnCITY.AllowDBNull = false;
    }

    public dsPayeeAddressSelections.Table1Row NewTable1Row()
    {
      return (dsPayeeAddressSelections.Table1Row) this.NewRow();
    }

    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsPayeeAddressSelections.Table1Row(builder);
    }

    protected override Type GetRowType() => typeof (dsPayeeAddressSelections.Table1Row);

    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.Table1RowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPayeeAddressSelections.Table1RowChangeEventHandler table1RowChangedEvent = this.Table1RowChangedEvent;
      if (table1RowChangedEvent == null)
        return;
      table1RowChangedEvent((object) this, new dsPayeeAddressSelections.Table1RowChangeEvent((dsPayeeAddressSelections.Table1Row) e.Row, e.Action));
    }

    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.Table1RowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPayeeAddressSelections.Table1RowChangeEventHandler rowChangingEvent = this.Table1RowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsPayeeAddressSelections.Table1RowChangeEvent((dsPayeeAddressSelections.Table1Row) e.Row, e.Action));
    }

    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.Table1RowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPayeeAddressSelections.Table1RowChangeEventHandler table1RowDeletedEvent = this.Table1RowDeletedEvent;
      if (table1RowDeletedEvent == null)
        return;
      table1RowDeletedEvent((object) this, new dsPayeeAddressSelections.Table1RowChangeEvent((dsPayeeAddressSelections.Table1Row) e.Row, e.Action));
    }

    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.Table1RowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPayeeAddressSelections.Table1RowChangeEventHandler rowDeletingEvent = this.Table1RowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsPayeeAddressSelections.Table1RowChangeEvent((dsPayeeAddressSelections.Table1Row) e.Row, e.Action));
    }

    public void RemoveTable1Row(dsPayeeAddressSelections.Table1Row row)
    {
      this.Rows.Remove((DataRow) row);
    }
  }

  [DebuggerStepThrough]
  public class Table1Row : DataRow
  {
    private dsPayeeAddressSelections.Table1DataTable tableTable1;

    internal Table1Row(DataRowBuilder rb)
      : base(rb)
    {
      this.tableTable1 = (dsPayeeAddressSelections.Table1DataTable) this.Table;
    }

    public string Alternate_Address
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableTable1.Alternate_AddressColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableTable1.Alternate_AddressColumn] = (object) value;
    }

    public string ADDRESS1
    {
      get => Conversions.ToString(this[this.tableTable1.ADDRESS1Column]);
      set => this[this.tableTable1.ADDRESS1Column] = (object) value;
    }

    public string ADDRESS2
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableTable1.ADDRESS2Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableTable1.ADDRESS2Column] = (object) value;
    }

    public string CITY
    {
      get => Conversions.ToString(this[this.tableTable1.CITYColumn]);
      set => this[this.tableTable1.CITYColumn] = (object) value;
    }

    public string STATE
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableTable1.STATEColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableTable1.STATEColumn] = (object) value;
    }

    public string ZIPCODE
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableTable1.ZIPCODEColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableTable1.ZIPCODEColumn] = (object) value;
    }

    public string ZIPPLUS
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableTable1.ZIPPLUSColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableTable1.ZIPPLUSColumn] = (object) value;
    }

    public string NAME
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableTable1.NAMEColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableTable1.NAMEColumn] = (object) value;
    }

    public bool IsAlternate_AddressNull() => this.IsNull(this.tableTable1.Alternate_AddressColumn);

    public void SetAlternate_AddressNull()
    {
      this[this.tableTable1.Alternate_AddressColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsADDRESS2Null() => this.IsNull(this.tableTable1.ADDRESS2Column);

    public void SetADDRESS2Null()
    {
      this[this.tableTable1.ADDRESS2Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsSTATENull() => this.IsNull(this.tableTable1.STATEColumn);

    public void SetSTATENull()
    {
      this[this.tableTable1.STATEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsZIPCODENull() => this.IsNull(this.tableTable1.ZIPCODEColumn);

    public void SetZIPCODENull()
    {
      this[this.tableTable1.ZIPCODEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsZIPPLUSNull() => this.IsNull(this.tableTable1.ZIPPLUSColumn);

    public void SetZIPPLUSNull()
    {
      this[this.tableTable1.ZIPPLUSColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsNAMENull() => this.IsNull(this.tableTable1.NAMEColumn);

    public void SetNAMENull()
    {
      this[this.tableTable1.NAMEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  [DebuggerStepThrough]
  public class Table1RowChangeEvent : EventArgs
  {
    private dsPayeeAddressSelections.Table1Row eventRow;
    private DataRowAction eventAction;

    public Table1RowChangeEvent(dsPayeeAddressSelections.Table1Row row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    public dsPayeeAddressSelections.Table1Row Row => this.eventRow;

    public DataRowAction Action => this.eventAction;
  }

  [DebuggerStepThrough]
  public class Table2DataTable : DataTable, IEnumerable
  {
    private DataColumn columnAlternate_Address;
    private DataColumn columnADDRESS1;
    private DataColumn columnADDRESS2;
    private DataColumn columnCITY;
    private DataColumn columnSTATE;
    private DataColumn columnZIPCODE;
    private DataColumn columnZIPPLUS;
    private DataColumn columnNAME;

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

    internal DataColumn Alternate_AddressColumn => this.columnAlternate_Address;

    internal DataColumn ADDRESS1Column => this.columnADDRESS1;

    internal DataColumn ADDRESS2Column => this.columnADDRESS2;

    internal DataColumn CITYColumn => this.columnCITY;

    internal DataColumn STATEColumn => this.columnSTATE;

    internal DataColumn ZIPCODEColumn => this.columnZIPCODE;

    internal DataColumn ZIPPLUSColumn => this.columnZIPPLUS;

    internal DataColumn NAMEColumn => this.columnNAME;

    public dsPayeeAddressSelections.Table2Row this[int index]
    {
      get => (dsPayeeAddressSelections.Table2Row) this.Rows[index];
    }

    public event dsPayeeAddressSelections.Table2RowChangeEventHandler Table2RowChanged;

    public event dsPayeeAddressSelections.Table2RowChangeEventHandler Table2RowChanging;

    public event dsPayeeAddressSelections.Table2RowChangeEventHandler Table2RowDeleted;

    public event dsPayeeAddressSelections.Table2RowChangeEventHandler Table2RowDeleting;

    public void AddTable2Row(dsPayeeAddressSelections.Table2Row row)
    {
      this.Rows.Add((DataRow) row);
    }

    public dsPayeeAddressSelections.Table2Row AddTable2Row(
      string Alternate_Address,
      string ADDRESS1,
      string ADDRESS2,
      string CITY,
      string STATE,
      string ZIPCODE,
      string ZIPPLUS,
      string NAME)
    {
      dsPayeeAddressSelections.Table2Row row = (dsPayeeAddressSelections.Table2Row) this.NewRow();
      row.ItemArray = new object[8]
      {
        (object) Alternate_Address,
        (object) ADDRESS1,
        (object) ADDRESS2,
        (object) CITY,
        (object) STATE,
        (object) ZIPCODE,
        (object) ZIPPLUS,
        (object) NAME
      };
      this.Rows.Add((DataRow) row);
      return row;
    }

    public IEnumerator GetEnumerator() => this.Rows.GetEnumerator();

    public override DataTable Clone()
    {
      dsPayeeAddressSelections.Table2DataTable table2DataTable = (dsPayeeAddressSelections.Table2DataTable) base.Clone();
      table2DataTable.InitVars();
      return (DataTable) table2DataTable;
    }

    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsPayeeAddressSelections.Table2DataTable();
    }

    internal void InitVars()
    {
      this.columnAlternate_Address = this.Columns["Alternate Address"];
      this.columnADDRESS1 = this.Columns["ADDRESS1"];
      this.columnADDRESS2 = this.Columns["ADDRESS2"];
      this.columnCITY = this.Columns["CITY"];
      this.columnSTATE = this.Columns["STATE"];
      this.columnZIPCODE = this.Columns["ZIPCODE"];
      this.columnZIPPLUS = this.Columns["ZIPPLUS"];
      this.columnNAME = this.Columns["NAME"];
    }

    private void InitClass()
    {
      this.columnAlternate_Address = new DataColumn("Alternate Address", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAlternate_Address);
      this.columnADDRESS1 = new DataColumn("ADDRESS1", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnADDRESS1);
      this.columnADDRESS2 = new DataColumn("ADDRESS2", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnADDRESS2);
      this.columnCITY = new DataColumn("CITY", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCITY);
      this.columnSTATE = new DataColumn("STATE", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSTATE);
      this.columnZIPCODE = new DataColumn("ZIPCODE", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnZIPCODE);
      this.columnZIPPLUS = new DataColumn("ZIPPLUS", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnZIPPLUS);
      this.columnNAME = new DataColumn("NAME", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnNAME);
      this.columnAlternate_Address.ReadOnly = true;
      this.columnADDRESS1.AllowDBNull = false;
      this.columnCITY.AllowDBNull = false;
    }

    public dsPayeeAddressSelections.Table2Row NewTable2Row()
    {
      return (dsPayeeAddressSelections.Table2Row) this.NewRow();
    }

    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsPayeeAddressSelections.Table2Row(builder);
    }

    protected override Type GetRowType() => typeof (dsPayeeAddressSelections.Table2Row);

    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.Table2RowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPayeeAddressSelections.Table2RowChangeEventHandler table2RowChangedEvent = this.Table2RowChangedEvent;
      if (table2RowChangedEvent == null)
        return;
      table2RowChangedEvent((object) this, new dsPayeeAddressSelections.Table2RowChangeEvent((dsPayeeAddressSelections.Table2Row) e.Row, e.Action));
    }

    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.Table2RowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPayeeAddressSelections.Table2RowChangeEventHandler rowChangingEvent = this.Table2RowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsPayeeAddressSelections.Table2RowChangeEvent((dsPayeeAddressSelections.Table2Row) e.Row, e.Action));
    }

    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.Table2RowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPayeeAddressSelections.Table2RowChangeEventHandler table2RowDeletedEvent = this.Table2RowDeletedEvent;
      if (table2RowDeletedEvent == null)
        return;
      table2RowDeletedEvent((object) this, new dsPayeeAddressSelections.Table2RowChangeEvent((dsPayeeAddressSelections.Table2Row) e.Row, e.Action));
    }

    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.Table2RowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPayeeAddressSelections.Table2RowChangeEventHandler rowDeletingEvent = this.Table2RowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsPayeeAddressSelections.Table2RowChangeEvent((dsPayeeAddressSelections.Table2Row) e.Row, e.Action));
    }

    public void RemoveTable2Row(dsPayeeAddressSelections.Table2Row row)
    {
      this.Rows.Remove((DataRow) row);
    }
  }

  [DebuggerStepThrough]
  public class Table2Row : DataRow
  {
    private dsPayeeAddressSelections.Table2DataTable tableTable2;

    internal Table2Row(DataRowBuilder rb)
      : base(rb)
    {
      this.tableTable2 = (dsPayeeAddressSelections.Table2DataTable) this.Table;
    }

    public string Alternate_Address
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableTable2.Alternate_AddressColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableTable2.Alternate_AddressColumn] = (object) value;
    }

    public string ADDRESS1
    {
      get => Conversions.ToString(this[this.tableTable2.ADDRESS1Column]);
      set => this[this.tableTable2.ADDRESS1Column] = (object) value;
    }

    public string ADDRESS2
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableTable2.ADDRESS2Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableTable2.ADDRESS2Column] = (object) value;
    }

    public string CITY
    {
      get => Conversions.ToString(this[this.tableTable2.CITYColumn]);
      set => this[this.tableTable2.CITYColumn] = (object) value;
    }

    public string STATE
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableTable2.STATEColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableTable2.STATEColumn] = (object) value;
    }

    public string ZIPCODE
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableTable2.ZIPCODEColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableTable2.ZIPCODEColumn] = (object) value;
    }

    public string ZIPPLUS
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableTable2.ZIPPLUSColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableTable2.ZIPPLUSColumn] = (object) value;
    }

    public string NAME
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableTable2.NAMEColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableTable2.NAMEColumn] = (object) value;
    }

    public bool IsAlternate_AddressNull() => this.IsNull(this.tableTable2.Alternate_AddressColumn);

    public void SetAlternate_AddressNull()
    {
      this[this.tableTable2.Alternate_AddressColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsADDRESS2Null() => this.IsNull(this.tableTable2.ADDRESS2Column);

    public void SetADDRESS2Null()
    {
      this[this.tableTable2.ADDRESS2Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsSTATENull() => this.IsNull(this.tableTable2.STATEColumn);

    public void SetSTATENull()
    {
      this[this.tableTable2.STATEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsZIPCODENull() => this.IsNull(this.tableTable2.ZIPCODEColumn);

    public void SetZIPCODENull()
    {
      this[this.tableTable2.ZIPCODEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsZIPPLUSNull() => this.IsNull(this.tableTable2.ZIPPLUSColumn);

    public void SetZIPPLUSNull()
    {
      this[this.tableTable2.ZIPPLUSColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsNAMENull() => this.IsNull(this.tableTable2.NAMEColumn);

    public void SetNAMENull()
    {
      this[this.tableTable2.NAMEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  [DebuggerStepThrough]
  public class Table2RowChangeEvent : EventArgs
  {
    private dsPayeeAddressSelections.Table2Row eventRow;
    private DataRowAction eventAction;

    public Table2RowChangeEvent(dsPayeeAddressSelections.Table2Row row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    public dsPayeeAddressSelections.Table2Row Row => this.eventRow;

    public DataRowAction Action => this.eventAction;
  }
}
