// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.AccountingDatasets.dsCostCenters
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
public class dsCostCenters : DataSet
{
  private dsCostCenters.spFin_GetCostCentersDataTable tablespFin_GetCostCenters;
  private dsCostCenters.Table1DataTable tableTable1;
  private DataRelation relationspFin_GetCostCentersTable1;

  public dsCostCenters()
  {
    this.InitClass();
    CollectionChangeEventHandler changeEventHandler = new CollectionChangeEventHandler(this.SchemaChanged);
    this.Tables.CollectionChanged += changeEventHandler;
    this.Relations.CollectionChanged += changeEventHandler;
  }

  protected dsCostCenters(SerializationInfo info, StreamingContext context)
  {
    string s = Conversions.ToString(info.GetValue("XmlSchema", typeof (string)));
    if (s != null)
    {
      DataSet dataSet = new DataSet();
      dataSet.ReadXmlSchema((XmlReader) new XmlTextReader((TextReader) new StringReader(s)));
      if (dataSet.Tables[nameof (spFin_GetCostCenters)] != null)
        this.Tables.Add((DataTable) new dsCostCenters.spFin_GetCostCentersDataTable(dataSet.Tables[nameof (spFin_GetCostCenters)]));
      if (dataSet.Tables[nameof (Table1)] != null)
        this.Tables.Add((DataTable) new dsCostCenters.Table1DataTable(dataSet.Tables[nameof (Table1)]));
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
  public dsCostCenters.spFin_GetCostCentersDataTable spFin_GetCostCenters
  {
    get => this.tablespFin_GetCostCenters;
  }

  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsCostCenters.Table1DataTable Table1 => this.tableTable1;

  public override DataSet Clone()
  {
    dsCostCenters dsCostCenters = (dsCostCenters) base.Clone();
    dsCostCenters.InitVars();
    return (DataSet) dsCostCenters;
  }

  protected override bool ShouldSerializeTables() => false;

  protected override bool ShouldSerializeRelations() => false;

  protected override void ReadXmlSerializable(XmlReader reader)
  {
    this.Reset();
    DataSet dataSet = new DataSet();
    int num = (int) dataSet.ReadXml(reader);
    if (dataSet.Tables["spFin_GetCostCenters"] != null)
      this.Tables.Add((DataTable) new dsCostCenters.spFin_GetCostCentersDataTable(dataSet.Tables["spFin_GetCostCenters"]));
    if (dataSet.Tables["Table1"] != null)
      this.Tables.Add((DataTable) new dsCostCenters.Table1DataTable(dataSet.Tables["Table1"]));
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
    this.tablespFin_GetCostCenters = (dsCostCenters.spFin_GetCostCentersDataTable) this.Tables["spFin_GetCostCenters"];
    if (this.tablespFin_GetCostCenters != null)
      this.tablespFin_GetCostCenters.InitVars();
    this.tableTable1 = (dsCostCenters.Table1DataTable) this.Tables["Table1"];
    if (this.tableTable1 != null)
      this.tableTable1.InitVars();
    this.relationspFin_GetCostCentersTable1 = this.Relations["spFin_GetCostCentersTable1"];
  }

  private void InitClass()
  {
    this.DataSetName = nameof (dsCostCenters);
    this.Prefix = "";
    this.Namespace = "http://www.tempuri.org/dsCostCenters.xsd";
    this.Locale = new CultureInfo("en-US");
    this.CaseSensitive = false;
    this.EnforceConstraints = true;
    this.tablespFin_GetCostCenters = new dsCostCenters.spFin_GetCostCentersDataTable();
    this.Tables.Add((DataTable) this.tablespFin_GetCostCenters);
    this.tableTable1 = new dsCostCenters.Table1DataTable();
    this.Tables.Add((DataTable) this.tableTable1);
    ForeignKeyConstraint foreignKeyConstraint = new ForeignKeyConstraint("spFin_GetCostCentersTable1", new DataColumn[1]
    {
      this.tablespFin_GetCostCenters.CostCenterIDColumn
    }, new DataColumn[1]
    {
      this.tableTable1.COSTCENTERIDColumn
    });
    this.tableTable1.Constraints.Add((Constraint) foreignKeyConstraint);
    foreignKeyConstraint.AcceptRejectRule = AcceptRejectRule.None;
    foreignKeyConstraint.DeleteRule = Rule.Cascade;
    foreignKeyConstraint.UpdateRule = Rule.Cascade;
    this.relationspFin_GetCostCentersTable1 = new DataRelation("spFin_GetCostCentersTable1", new DataColumn[1]
    {
      this.tablespFin_GetCostCenters.CostCenterIDColumn
    }, new DataColumn[1]
    {
      this.tableTable1.COSTCENTERIDColumn
    }, false);
    this.Relations.Add(this.relationspFin_GetCostCentersTable1);
  }

  private bool ShouldSerializespFin_GetCostCenters() => false;

  private bool ShouldSerializeTable1() => false;

  private void SchemaChanged(object sender, CollectionChangeEventArgs e)
  {
    if (e.Action != CollectionChangeAction.Remove)
      return;
    this.InitVars();
  }

  public delegate void spFin_GetCostCentersRowChangeEventHandler(
    object sender,
    dsCostCenters.spFin_GetCostCentersRowChangeEvent e);

  public delegate void Table1RowChangeEventHandler(
    object sender,
    dsCostCenters.Table1RowChangeEvent e);

  [DebuggerStepThrough]
  public class spFin_GetCostCentersDataTable : DataTable, IEnumerable
  {
    private DataColumn columnCostCenterID;
    private DataColumn columnName;
    private DataColumn columnDescription;
    private DataColumn columnGLCOMPANYID;

    internal spFin_GetCostCentersDataTable()
      : base("spFin_GetCostCenters")
    {
      this.InitClass();
    }

    internal spFin_GetCostCentersDataTable(DataTable table)
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

    internal DataColumn CostCenterIDColumn => this.columnCostCenterID;

    internal DataColumn NameColumn => this.columnName;

    internal DataColumn DescriptionColumn => this.columnDescription;

    internal DataColumn GLCOMPANYIDColumn => this.columnGLCOMPANYID;

    public dsCostCenters.spFin_GetCostCentersRow this[int index]
    {
      get => (dsCostCenters.spFin_GetCostCentersRow) this.Rows[index];
    }

    public event dsCostCenters.spFin_GetCostCentersRowChangeEventHandler spFin_GetCostCentersRowChanged;

    public event dsCostCenters.spFin_GetCostCentersRowChangeEventHandler spFin_GetCostCentersRowChanging;

    public event dsCostCenters.spFin_GetCostCentersRowChangeEventHandler spFin_GetCostCentersRowDeleted;

    public event dsCostCenters.spFin_GetCostCentersRowChangeEventHandler spFin_GetCostCentersRowDeleting;

    public void AddspFin_GetCostCentersRow(dsCostCenters.spFin_GetCostCentersRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    public dsCostCenters.spFin_GetCostCentersRow AddspFin_GetCostCentersRow(
      string Name,
      string Description,
      int GLCOMPANYID)
    {
      dsCostCenters.spFin_GetCostCentersRow row = (dsCostCenters.spFin_GetCostCentersRow) this.NewRow();
      row.ItemArray = new object[4]
      {
        null,
        (object) Name,
        (object) Description,
        (object) GLCOMPANYID
      };
      this.Rows.Add((DataRow) row);
      return row;
    }

    public dsCostCenters.spFin_GetCostCentersRow FindByCostCenterID(int CostCenterID)
    {
      return (dsCostCenters.spFin_GetCostCentersRow) this.Rows.Find(new object[1]
      {
        (object) CostCenterID
      });
    }

    public IEnumerator GetEnumerator() => this.Rows.GetEnumerator();

    public override DataTable Clone()
    {
      dsCostCenters.spFin_GetCostCentersDataTable centersDataTable = (dsCostCenters.spFin_GetCostCentersDataTable) base.Clone();
      centersDataTable.InitVars();
      return (DataTable) centersDataTable;
    }

    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsCostCenters.spFin_GetCostCentersDataTable();
    }

    internal void InitVars()
    {
      this.columnCostCenterID = this.Columns["CostCenterID"];
      this.columnName = this.Columns["Name"];
      this.columnDescription = this.Columns["Description"];
      this.columnGLCOMPANYID = this.Columns["GLCOMPANYID"];
    }

    private void InitClass()
    {
      this.columnCostCenterID = new DataColumn("CostCenterID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCostCenterID);
      this.columnName = new DataColumn("Name", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnName);
      this.columnDescription = new DataColumn("Description", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDescription);
      this.columnGLCOMPANYID = new DataColumn("GLCOMPANYID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnGLCOMPANYID);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnCostCenterID
      }, true));
      this.columnCostCenterID.AutoIncrement = true;
      this.columnCostCenterID.AllowDBNull = false;
      this.columnCostCenterID.ReadOnly = true;
      this.columnCostCenterID.Unique = true;
      this.columnName.AllowDBNull = false;
      this.columnGLCOMPANYID.AllowDBNull = false;
    }

    public dsCostCenters.spFin_GetCostCentersRow NewspFin_GetCostCentersRow()
    {
      return (dsCostCenters.spFin_GetCostCentersRow) this.NewRow();
    }

    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsCostCenters.spFin_GetCostCentersRow(builder);
    }

    protected override Type GetRowType() => typeof (dsCostCenters.spFin_GetCostCentersRow);

    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.spFin_GetCostCentersRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCostCenters.spFin_GetCostCentersRowChangeEventHandler centersRowChangedEvent = this.spFin_GetCostCentersRowChangedEvent;
      if (centersRowChangedEvent == null)
        return;
      centersRowChangedEvent((object) this, new dsCostCenters.spFin_GetCostCentersRowChangeEvent((dsCostCenters.spFin_GetCostCentersRow) e.Row, e.Action));
    }

    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.spFin_GetCostCentersRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCostCenters.spFin_GetCostCentersRowChangeEventHandler rowChangingEvent = this.spFin_GetCostCentersRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsCostCenters.spFin_GetCostCentersRowChangeEvent((dsCostCenters.spFin_GetCostCentersRow) e.Row, e.Action));
    }

    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.spFin_GetCostCentersRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCostCenters.spFin_GetCostCentersRowChangeEventHandler centersRowDeletedEvent = this.spFin_GetCostCentersRowDeletedEvent;
      if (centersRowDeletedEvent == null)
        return;
      centersRowDeletedEvent((object) this, new dsCostCenters.spFin_GetCostCentersRowChangeEvent((dsCostCenters.spFin_GetCostCentersRow) e.Row, e.Action));
    }

    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.spFin_GetCostCentersRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCostCenters.spFin_GetCostCentersRowChangeEventHandler rowDeletingEvent = this.spFin_GetCostCentersRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsCostCenters.spFin_GetCostCentersRowChangeEvent((dsCostCenters.spFin_GetCostCentersRow) e.Row, e.Action));
    }

    public void RemovespFin_GetCostCentersRow(dsCostCenters.spFin_GetCostCentersRow row)
    {
      this.Rows.Remove((DataRow) row);
    }
  }

  [DebuggerStepThrough]
  public class spFin_GetCostCentersRow : DataRow
  {
    private dsCostCenters.spFin_GetCostCentersDataTable tablespFin_GetCostCenters;

    internal spFin_GetCostCentersRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablespFin_GetCostCenters = (dsCostCenters.spFin_GetCostCentersDataTable) this.Table;
    }

    public int CostCenterID
    {
      get => Conversions.ToInteger(this[this.tablespFin_GetCostCenters.CostCenterIDColumn]);
      set => this[this.tablespFin_GetCostCenters.CostCenterIDColumn] = (object) value;
    }

    public string Name
    {
      get => Conversions.ToString(this[this.tablespFin_GetCostCenters.NameColumn]);
      set => this[this.tablespFin_GetCostCenters.NameColumn] = (object) value;
    }

    public string Description
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablespFin_GetCostCenters.DescriptionColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablespFin_GetCostCenters.DescriptionColumn] = (object) value;
    }

    public int GLCOMPANYID
    {
      get => Conversions.ToInteger(this[this.tablespFin_GetCostCenters.GLCOMPANYIDColumn]);
      set => this[this.tablespFin_GetCostCenters.GLCOMPANYIDColumn] = (object) value;
    }

    public bool IsDescriptionNull()
    {
      return this.IsNull(this.tablespFin_GetCostCenters.DescriptionColumn);
    }

    public void SetDescriptionNull()
    {
      this[this.tablespFin_GetCostCenters.DescriptionColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public dsCostCenters.Table1Row[] GetTable1Rows()
    {
      return (dsCostCenters.Table1Row[]) this.GetChildRows(this.Table.ChildRelations["spFin_GetCostCentersTable1"]);
    }
  }

  [DebuggerStepThrough]
  public class spFin_GetCostCentersRowChangeEvent : EventArgs
  {
    private dsCostCenters.spFin_GetCostCentersRow eventRow;
    private DataRowAction eventAction;

    public spFin_GetCostCentersRowChangeEvent(
      dsCostCenters.spFin_GetCostCentersRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    public dsCostCenters.spFin_GetCostCentersRow Row => this.eventRow;

    public DataRowAction Action => this.eventAction;
  }

  [DebuggerStepThrough]
  public class Table1DataTable : DataTable, IEnumerable
  {
    private DataColumn columnCOSTCENTERID;
    private DataColumn columnENTITYGUID;
    private DataColumn columnName;
    private DataColumn columnEntity_Type;
    private DataColumn columnisdefault;

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

    internal DataColumn COSTCENTERIDColumn => this.columnCOSTCENTERID;

    internal DataColumn ENTITYGUIDColumn => this.columnENTITYGUID;

    internal DataColumn NameColumn => this.columnName;

    internal DataColumn Entity_TypeColumn => this.columnEntity_Type;

    internal DataColumn isdefaultColumn => this.columnisdefault;

    public dsCostCenters.Table1Row this[int index] => (dsCostCenters.Table1Row) this.Rows[index];

    public event dsCostCenters.Table1RowChangeEventHandler Table1RowChanged;

    public event dsCostCenters.Table1RowChangeEventHandler Table1RowChanging;

    public event dsCostCenters.Table1RowChangeEventHandler Table1RowDeleted;

    public event dsCostCenters.Table1RowChangeEventHandler Table1RowDeleting;

    public void AddTable1Row(dsCostCenters.Table1Row row) => this.Rows.Add((DataRow) row);

    public dsCostCenters.Table1Row AddTable1Row(
      dsCostCenters.spFin_GetCostCentersRow parentspFin_GetCostCentersRowByspFin_GetCostCentersTable1,
      Guid ENTITYGUID,
      string Name,
      string Entity_Type,
      bool isdefault)
    {
      dsCostCenters.Table1Row row = (dsCostCenters.Table1Row) this.NewRow();
      row.ItemArray = new object[5]
      {
        parentspFin_GetCostCentersRowByspFin_GetCostCentersTable1[0],
        (object) ENTITYGUID,
        (object) Name,
        (object) Entity_Type,
        (object) isdefault
      };
      this.Rows.Add((DataRow) row);
      return row;
    }

    public IEnumerator GetEnumerator() => this.Rows.GetEnumerator();

    public override DataTable Clone()
    {
      dsCostCenters.Table1DataTable table1DataTable = (dsCostCenters.Table1DataTable) base.Clone();
      table1DataTable.InitVars();
      return (DataTable) table1DataTable;
    }

    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsCostCenters.Table1DataTable();
    }

    internal void InitVars()
    {
      this.columnCOSTCENTERID = this.Columns["COSTCENTERID"];
      this.columnENTITYGUID = this.Columns["ENTITYGUID"];
      this.columnName = this.Columns["Name"];
      this.columnEntity_Type = this.Columns["Entity Type"];
      this.columnisdefault = this.Columns["isdefault"];
    }

    private void InitClass()
    {
      this.columnCOSTCENTERID = new DataColumn("COSTCENTERID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCOSTCENTERID);
      this.columnENTITYGUID = new DataColumn("ENTITYGUID", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnENTITYGUID);
      this.columnName = new DataColumn("Name", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnName);
      this.columnEntity_Type = new DataColumn("Entity Type", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEntity_Type);
      this.columnisdefault = new DataColumn("isdefault", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnisdefault);
      this.columnCOSTCENTERID.AllowDBNull = false;
      this.columnENTITYGUID.AllowDBNull = false;
      this.columnName.ReadOnly = true;
      this.columnEntity_Type.ReadOnly = true;
    }

    public dsCostCenters.Table1Row NewTable1Row() => (dsCostCenters.Table1Row) this.NewRow();

    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsCostCenters.Table1Row(builder);
    }

    protected override Type GetRowType() => typeof (dsCostCenters.Table1Row);

    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.Table1RowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCostCenters.Table1RowChangeEventHandler table1RowChangedEvent = this.Table1RowChangedEvent;
      if (table1RowChangedEvent == null)
        return;
      table1RowChangedEvent((object) this, new dsCostCenters.Table1RowChangeEvent((dsCostCenters.Table1Row) e.Row, e.Action));
    }

    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.Table1RowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCostCenters.Table1RowChangeEventHandler rowChangingEvent = this.Table1RowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsCostCenters.Table1RowChangeEvent((dsCostCenters.Table1Row) e.Row, e.Action));
    }

    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.Table1RowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCostCenters.Table1RowChangeEventHandler table1RowDeletedEvent = this.Table1RowDeletedEvent;
      if (table1RowDeletedEvent == null)
        return;
      table1RowDeletedEvent((object) this, new dsCostCenters.Table1RowChangeEvent((dsCostCenters.Table1Row) e.Row, e.Action));
    }

    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.Table1RowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCostCenters.Table1RowChangeEventHandler rowDeletingEvent = this.Table1RowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsCostCenters.Table1RowChangeEvent((dsCostCenters.Table1Row) e.Row, e.Action));
    }

    public void RemoveTable1Row(dsCostCenters.Table1Row row) => this.Rows.Remove((DataRow) row);
  }

  [DebuggerStepThrough]
  public class Table1Row : DataRow
  {
    private dsCostCenters.Table1DataTable tableTable1;

    internal Table1Row(DataRowBuilder rb)
      : base(rb)
    {
      this.tableTable1 = (dsCostCenters.Table1DataTable) this.Table;
    }

    public int COSTCENTERID
    {
      get => Conversions.ToInteger(this[this.tableTable1.COSTCENTERIDColumn]);
      set => this[this.tableTable1.COSTCENTERIDColumn] = (object) value;
    }

    public Guid ENTITYGUID
    {
      get
      {
        object obj = this[this.tableTable1.ENTITYGUIDColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tableTable1.ENTITYGUIDColumn] = (object) value;
    }

    public string Name
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableTable1.NameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableTable1.NameColumn] = (object) value;
    }

    public string Entity_Type
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableTable1.Entity_TypeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableTable1.Entity_TypeColumn] = (object) value;
    }

    public bool isdefault
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tableTable1.isdefaultColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableTable1.isdefaultColumn] = (object) value;
    }

    public dsCostCenters.spFin_GetCostCentersRow spFin_GetCostCentersRow
    {
      get
      {
        return (dsCostCenters.spFin_GetCostCentersRow) this.GetParentRow(this.Table.ParentRelations["spFin_GetCostCentersTable1"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["spFin_GetCostCentersTable1"]);
      }
    }

    public bool IsNameNull() => this.IsNull(this.tableTable1.NameColumn);

    public void SetNameNull()
    {
      this[this.tableTable1.NameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsEntity_TypeNull() => this.IsNull(this.tableTable1.Entity_TypeColumn);

    public void SetEntity_TypeNull()
    {
      this[this.tableTable1.Entity_TypeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsisdefaultNull() => this.IsNull(this.tableTable1.isdefaultColumn);

    public void SetisdefaultNull()
    {
      this[this.tableTable1.isdefaultColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  [DebuggerStepThrough]
  public class Table1RowChangeEvent : EventArgs
  {
    private dsCostCenters.Table1Row eventRow;
    private DataRowAction eventAction;

    public Table1RowChangeEvent(dsCostCenters.Table1Row row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    public dsCostCenters.Table1Row Row => this.eventRow;

    public DataRowAction Action => this.eventAction;
  }
}
