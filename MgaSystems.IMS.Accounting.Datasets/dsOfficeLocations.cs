// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.AccountingDatasets.dsOfficeLocations
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
public class dsOfficeLocations : DataSet
{
  private dsOfficeLocations.spFin_GetOfficeLocationsDataTable tablespFin_GetOfficeLocations;

  public dsOfficeLocations()
  {
    this.InitClass();
    CollectionChangeEventHandler changeEventHandler = new CollectionChangeEventHandler(this.SchemaChanged);
    this.Tables.CollectionChanged += changeEventHandler;
    this.Relations.CollectionChanged += changeEventHandler;
  }

  protected dsOfficeLocations(SerializationInfo info, StreamingContext context)
  {
    string s = Conversions.ToString(info.GetValue("XmlSchema", typeof (string)));
    if (s != null)
    {
      DataSet dataSet = new DataSet();
      dataSet.ReadXmlSchema((XmlReader) new XmlTextReader((TextReader) new StringReader(s)));
      if (dataSet.Tables[nameof (spFin_GetOfficeLocations)] != null)
        this.Tables.Add((DataTable) new dsOfficeLocations.spFin_GetOfficeLocationsDataTable(dataSet.Tables[nameof (spFin_GetOfficeLocations)]));
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
  public dsOfficeLocations.spFin_GetOfficeLocationsDataTable spFin_GetOfficeLocations
  {
    get => this.tablespFin_GetOfficeLocations;
  }

  public override DataSet Clone()
  {
    dsOfficeLocations dsOfficeLocations = (dsOfficeLocations) base.Clone();
    dsOfficeLocations.InitVars();
    return (DataSet) dsOfficeLocations;
  }

  protected override bool ShouldSerializeTables() => false;

  protected override bool ShouldSerializeRelations() => false;

  protected override void ReadXmlSerializable(XmlReader reader)
  {
    this.Reset();
    DataSet dataSet = new DataSet();
    int num = (int) dataSet.ReadXml(reader);
    if (dataSet.Tables["spFin_GetOfficeLocations"] != null)
      this.Tables.Add((DataTable) new dsOfficeLocations.spFin_GetOfficeLocationsDataTable(dataSet.Tables["spFin_GetOfficeLocations"]));
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
    this.tablespFin_GetOfficeLocations = (dsOfficeLocations.spFin_GetOfficeLocationsDataTable) this.Tables["spFin_GetOfficeLocations"];
    if (this.tablespFin_GetOfficeLocations == null)
      return;
    this.tablespFin_GetOfficeLocations.InitVars();
  }

  private void InitClass()
  {
    this.DataSetName = nameof (dsOfficeLocations);
    this.Prefix = "";
    this.Namespace = "http://www.tempuri.org/dsOfficeLocations.xsd";
    this.Locale = new CultureInfo("en-US");
    this.CaseSensitive = false;
    this.EnforceConstraints = true;
    this.tablespFin_GetOfficeLocations = new dsOfficeLocations.spFin_GetOfficeLocationsDataTable();
    this.Tables.Add((DataTable) this.tablespFin_GetOfficeLocations);
  }

  private bool ShouldSerializespFin_GetOfficeLocations() => false;

  private void SchemaChanged(object sender, CollectionChangeEventArgs e)
  {
    if (e.Action != CollectionChangeAction.Remove)
      return;
    this.InitVars();
  }

  public delegate void spFin_GetOfficeLocationsRowChangeEventHandler(
    object sender,
    dsOfficeLocations.spFin_GetOfficeLocationsRowChangeEvent e);

  [DebuggerStepThrough]
  public class spFin_GetOfficeLocationsDataTable : DataTable, IEnumerable
  {
    private DataColumn columnID;
    private DataColumn columnOffice_Location;

    internal spFin_GetOfficeLocationsDataTable()
      : base("spFin_GetOfficeLocations")
    {
      this.InitClass();
    }

    internal spFin_GetOfficeLocationsDataTable(DataTable table)
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

    internal DataColumn Office_LocationColumn => this.columnOffice_Location;

    public dsOfficeLocations.spFin_GetOfficeLocationsRow this[int index]
    {
      get => (dsOfficeLocations.spFin_GetOfficeLocationsRow) this.Rows[index];
    }

    public event dsOfficeLocations.spFin_GetOfficeLocationsRowChangeEventHandler spFin_GetOfficeLocationsRowChanged;

    public event dsOfficeLocations.spFin_GetOfficeLocationsRowChangeEventHandler spFin_GetOfficeLocationsRowChanging;

    public event dsOfficeLocations.spFin_GetOfficeLocationsRowChangeEventHandler spFin_GetOfficeLocationsRowDeleted;

    public event dsOfficeLocations.spFin_GetOfficeLocationsRowChangeEventHandler spFin_GetOfficeLocationsRowDeleting;

    public void AddspFin_GetOfficeLocationsRow(dsOfficeLocations.spFin_GetOfficeLocationsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    public dsOfficeLocations.spFin_GetOfficeLocationsRow AddspFin_GetOfficeLocationsRow(
      string Office_Location)
    {
      dsOfficeLocations.spFin_GetOfficeLocationsRow row = (dsOfficeLocations.spFin_GetOfficeLocationsRow) this.NewRow();
      row.ItemArray = new object[2]
      {
        null,
        (object) Office_Location
      };
      this.Rows.Add((DataRow) row);
      return row;
    }

    public IEnumerator GetEnumerator() => this.Rows.GetEnumerator();

    public override DataTable Clone()
    {
      dsOfficeLocations.spFin_GetOfficeLocationsDataTable locationsDataTable = (dsOfficeLocations.spFin_GetOfficeLocationsDataTable) base.Clone();
      locationsDataTable.InitVars();
      return (DataTable) locationsDataTable;
    }

    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsOfficeLocations.spFin_GetOfficeLocationsDataTable();
    }

    internal void InitVars()
    {
      this.columnID = this.Columns["ID"];
      this.columnOffice_Location = this.Columns["Office Location"];
    }

    private void InitClass()
    {
      this.columnID = new DataColumn("ID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnID);
      this.columnOffice_Location = new DataColumn("Office Location", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnOffice_Location);
      this.columnID.AutoIncrement = true;
      this.columnID.AllowDBNull = false;
      this.columnID.ReadOnly = true;
      this.columnOffice_Location.AllowDBNull = false;
    }

    public dsOfficeLocations.spFin_GetOfficeLocationsRow NewspFin_GetOfficeLocationsRow()
    {
      return (dsOfficeLocations.spFin_GetOfficeLocationsRow) this.NewRow();
    }

    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsOfficeLocations.spFin_GetOfficeLocationsRow(builder);
    }

    protected override Type GetRowType() => typeof (dsOfficeLocations.spFin_GetOfficeLocationsRow);

    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.spFin_GetOfficeLocationsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsOfficeLocations.spFin_GetOfficeLocationsRowChangeEventHandler locationsRowChangedEvent = this.spFin_GetOfficeLocationsRowChangedEvent;
      if (locationsRowChangedEvent == null)
        return;
      locationsRowChangedEvent((object) this, new dsOfficeLocations.spFin_GetOfficeLocationsRowChangeEvent((dsOfficeLocations.spFin_GetOfficeLocationsRow) e.Row, e.Action));
    }

    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.spFin_GetOfficeLocationsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsOfficeLocations.spFin_GetOfficeLocationsRowChangeEventHandler rowChangingEvent = this.spFin_GetOfficeLocationsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsOfficeLocations.spFin_GetOfficeLocationsRowChangeEvent((dsOfficeLocations.spFin_GetOfficeLocationsRow) e.Row, e.Action));
    }

    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.spFin_GetOfficeLocationsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsOfficeLocations.spFin_GetOfficeLocationsRowChangeEventHandler locationsRowDeletedEvent = this.spFin_GetOfficeLocationsRowDeletedEvent;
      if (locationsRowDeletedEvent == null)
        return;
      locationsRowDeletedEvent((object) this, new dsOfficeLocations.spFin_GetOfficeLocationsRowChangeEvent((dsOfficeLocations.spFin_GetOfficeLocationsRow) e.Row, e.Action));
    }

    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.spFin_GetOfficeLocationsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsOfficeLocations.spFin_GetOfficeLocationsRowChangeEventHandler rowDeletingEvent = this.spFin_GetOfficeLocationsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsOfficeLocations.spFin_GetOfficeLocationsRowChangeEvent((dsOfficeLocations.spFin_GetOfficeLocationsRow) e.Row, e.Action));
    }

    public void RemovespFin_GetOfficeLocationsRow(dsOfficeLocations.spFin_GetOfficeLocationsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }
  }

  [DebuggerStepThrough]
  public class spFin_GetOfficeLocationsRow : DataRow
  {
    private dsOfficeLocations.spFin_GetOfficeLocationsDataTable tablespFin_GetOfficeLocations;

    internal spFin_GetOfficeLocationsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablespFin_GetOfficeLocations = (dsOfficeLocations.spFin_GetOfficeLocationsDataTable) this.Table;
    }

    public int ID
    {
      get => Conversions.ToInteger(this[this.tablespFin_GetOfficeLocations.IDColumn]);
      set => this[this.tablespFin_GetOfficeLocations.IDColumn] = (object) value;
    }

    public string Office_Location
    {
      get => Conversions.ToString(this[this.tablespFin_GetOfficeLocations.Office_LocationColumn]);
      set => this[this.tablespFin_GetOfficeLocations.Office_LocationColumn] = (object) value;
    }
  }

  [DebuggerStepThrough]
  public class spFin_GetOfficeLocationsRowChangeEvent : EventArgs
  {
    private dsOfficeLocations.spFin_GetOfficeLocationsRow eventRow;
    private DataRowAction eventAction;

    public spFin_GetOfficeLocationsRowChangeEvent(
      dsOfficeLocations.spFin_GetOfficeLocationsRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    public dsOfficeLocations.spFin_GetOfficeLocationsRow Row => this.eventRow;

    public DataRowAction Action => this.eventAction;
  }
}
