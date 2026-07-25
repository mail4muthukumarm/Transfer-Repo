// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.dsLocationSearch
// Assembly: MgaSystems.IMS.Policies, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 2FF2C709-F7BF-41DA-82BD-FF6319CA235D
// Assembly location: C:\Users\muthu\Downloads\MgaSystems.IMS.Policies.dll

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Text;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

#nullable disable
namespace MGASystems.IMS.Policies;

[DesignerCategory("code")]
[ToolboxItem(true)]
[XmlSchemaProvider("GetTypedDataSetSchema")]
[XmlRoot("dsLocationSearch")]
[HelpKeyword("vs.data.DataSet")]
[Serializable]
public class dsLocationSearch : DataSet
{
  private dsLocationSearch.dtLocationSearchDataTable tabledtLocationSearch;
  private SchemaSerializationMode _schemaSerializationMode;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public dsLocationSearch()
  {
    this._schemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.BeginInit();
    this.InitClass();
    CollectionChangeEventHandler changeEventHandler = new CollectionChangeEventHandler(this.SchemaChanged);
    base.Tables.CollectionChanged += changeEventHandler;
    base.Relations.CollectionChanged += changeEventHandler;
    this.EndInit();
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  protected dsLocationSearch(SerializationInfo info, StreamingContext context)
    : base(info, context, false)
  {
    this._schemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    if (this.IsBinarySerialized(info, context))
    {
      this.InitVars(false);
      CollectionChangeEventHandler changeEventHandler = new CollectionChangeEventHandler(this.SchemaChanged);
      this.Tables.CollectionChanged += changeEventHandler;
      this.Relations.CollectionChanged += changeEventHandler;
    }
    else
    {
      string s = Conversions.ToString(info.GetValue("XmlSchema", typeof (string)));
      if (this.DetermineSchemaSerializationMode(info, context) == SchemaSerializationMode.IncludeSchema)
      {
        DataSet dataSet = new DataSet();
        dataSet.ReadXmlSchema((XmlReader) new XmlTextReader((TextReader) new StringReader(s)));
        if (dataSet.Tables[nameof (dtLocationSearch)] != null)
          base.Tables.Add((DataTable) new dsLocationSearch.dtLocationSearchDataTable(dataSet.Tables[nameof (dtLocationSearch)]));
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
        this.ReadXmlSchema((XmlReader) new XmlTextReader((TextReader) new StringReader(s)));
      this.GetSerializationData(info, context);
      CollectionChangeEventHandler changeEventHandler = new CollectionChangeEventHandler(this.SchemaChanged);
      base.Tables.CollectionChanged += changeEventHandler;
      this.Relations.CollectionChanged += changeEventHandler;
    }
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsLocationSearch.dtLocationSearchDataTable dtLocationSearch => this.tabledtLocationSearch;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [Browsable(true)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
  public override SchemaSerializationMode SchemaSerializationMode
  {
    get => this._schemaSerializationMode;
    set => this._schemaSerializationMode = value;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public new DataTableCollection Tables => base.Tables;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public new DataRelationCollection Relations => base.Relations;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  protected override void InitializeDerivedDataSet()
  {
    this.BeginInit();
    this.InitClass();
    this.EndInit();
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public override DataSet Clone()
  {
    dsLocationSearch dsLocationSearch = (dsLocationSearch) base.Clone();
    dsLocationSearch.InitVars();
    dsLocationSearch.SchemaSerializationMode = this.SchemaSerializationMode;
    return (DataSet) dsLocationSearch;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  protected override bool ShouldSerializeTables() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  protected override bool ShouldSerializeRelations() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  protected override void ReadXmlSerializable(XmlReader reader)
  {
    if (this.DetermineSchemaSerializationMode(reader) == SchemaSerializationMode.IncludeSchema)
    {
      this.Reset();
      DataSet dataSet = new DataSet();
      int num = (int) dataSet.ReadXml(reader);
      if (dataSet.Tables["dtLocationSearch"] != null)
        base.Tables.Add((DataTable) new dsLocationSearch.dtLocationSearchDataTable(dataSet.Tables["dtLocationSearch"]));
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
    {
      int num = (int) this.ReadXml(reader);
      this.InitVars();
    }
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  protected override XmlSchema GetSchemaSerializable()
  {
    MemoryStream memoryStream = new MemoryStream();
    this.WriteXmlSchema((XmlWriter) new XmlTextWriter((Stream) memoryStream, (Encoding) null));
    memoryStream.Position = 0L;
    return XmlSchema.Read((XmlReader) new XmlTextReader((Stream) memoryStream), (ValidationEventHandler) null);
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  internal void InitVars() => this.InitVars(true);

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  internal void InitVars(bool initTable)
  {
    this.tabledtLocationSearch = (dsLocationSearch.dtLocationSearchDataTable) base.Tables["dtLocationSearch"];
    if (!initTable || this.tabledtLocationSearch == null)
      return;
    this.tabledtLocationSearch.InitVars();
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private void InitClass()
  {
    this.DataSetName = nameof (dsLocationSearch);
    this.Prefix = "";
    this.Namespace = "http://tempuri.org/dsLocationSearch.xsd";
    this.EnforceConstraints = true;
    this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.tabledtLocationSearch = new dsLocationSearch.dtLocationSearchDataTable();
    base.Tables.Add((DataTable) this.tabledtLocationSearch);
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializedtLocationSearch() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private void SchemaChanged(object sender, CollectionChangeEventArgs e)
  {
    if (e.Action != CollectionChangeAction.Remove)
      return;
    this.InitVars();
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public static XmlSchemaComplexType GetTypedDataSetSchema(XmlSchemaSet xs)
  {
    dsLocationSearch dsLocationSearch = new dsLocationSearch();
    XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
    schemaComplexType.Particle = (XmlSchemaParticle) new XmlSchemaSequence()
    {
      Items = {
        (XmlSchemaObject) new XmlSchemaAny()
        {
          Namespace = dsLocationSearch.Namespace
        }
      }
    };
    XmlSchema schemaSerializable = dsLocationSearch.GetSchemaSerializable();
    XmlSchemaComplexType typedDataSetSchema;
    if (xs.Contains(schemaSerializable.TargetNamespace))
    {
      MemoryStream memoryStream1 = new MemoryStream();
      MemoryStream memoryStream2 = new MemoryStream();
      try
      {
        schemaSerializable.Write((Stream) memoryStream1);
        IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
        while (enumerator.MoveNext())
        {
          XmlSchema current = (XmlSchema) enumerator.Current;
          memoryStream2.SetLength(0L);
          MemoryStream memoryStream3 = memoryStream2;
          current.Write((Stream) memoryStream3);
          if (memoryStream1.Length == memoryStream2.Length)
          {
            memoryStream1.Position = 0L;
            memoryStream2.Position = 0L;
            do
              ;
            while (memoryStream1.Position != memoryStream1.Length && memoryStream1.ReadByte() == memoryStream2.ReadByte());
            if (memoryStream1.Position == memoryStream1.Length)
            {
              typedDataSetSchema = schemaComplexType;
              goto label_15;
            }
          }
        }
      }
      finally
      {
        memoryStream1?.Close();
        memoryStream2?.Close();
      }
    }
    xs.Add(schemaSerializable);
    typedDataSetSchema = schemaComplexType;
label_15:
    return typedDataSetSchema;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void dtLocationSearchRowChangeEventHandler(
    object sender,
    dsLocationSearch.dtLocationSearchRowChangeEvent e);

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class dtLocationSearchDataTable : TypedTableBase<dsLocationSearch.dtLocationSearchRow>
  {
    private DataColumn columnControlNo;
    private DataColumn columnPolicyNumber;
    private DataColumn columnLine;
    private DataColumn columnEffectiveDate;
    private DataColumn columnExpirationDate;
    private DataColumn columnLocationNo;
    private DataColumn columnBuildingNo;
    private DataColumn columnAddress;
    private DataColumn columnCity;
    private DataColumn columnState;
    private DataColumn columnZip;
    private DataColumn columnProducerLocationName;
    private DataColumn columnInsuredPolicyName;
    private DataColumn columnLocStatus;
    private DataColumn columnTransAdded;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dtLocationSearchDataTable()
    {
      this.TableName = "dtLocationSearch";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal dtLocationSearchDataTable(DataTable table)
    {
      this.TableName = table.TableName;
      if (table.CaseSensitive != table.DataSet.CaseSensitive)
        this.CaseSensitive = table.CaseSensitive;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(table.Locale.ToString(), table.DataSet.Locale.ToString(), false) != 0)
        this.Locale = table.Locale;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(table.Namespace, table.DataSet.Namespace, false) != 0)
        this.Namespace = table.Namespace;
      this.Prefix = table.Prefix;
      this.MinimumCapacity = table.MinimumCapacity;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected dtLocationSearchDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ControlNoColumn => this.columnControlNo;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn PolicyNumberColumn => this.columnPolicyNumber;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn LineColumn => this.columnLine;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn EffectiveDateColumn => this.columnEffectiveDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ExpirationDateColumn => this.columnExpirationDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn LocationNoColumn => this.columnLocationNo;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn BuildingNoColumn => this.columnBuildingNo;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn AddressColumn => this.columnAddress;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn CityColumn => this.columnCity;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn StateColumn => this.columnState;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ZipColumn => this.columnZip;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ProducerLocationNameColumn => this.columnProducerLocationName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn InsuredPolicyNameColumn => this.columnInsuredPolicyName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn LocStatusColumn => this.columnLocStatus;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn TransAddedColumn => this.columnTransAdded;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsLocationSearch.dtLocationSearchRow this[int index]
    {
      get => (dsLocationSearch.dtLocationSearchRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsLocationSearch.dtLocationSearchRowChangeEventHandler dtLocationSearchRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsLocationSearch.dtLocationSearchRowChangeEventHandler dtLocationSearchRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsLocationSearch.dtLocationSearchRowChangeEventHandler dtLocationSearchRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsLocationSearch.dtLocationSearchRowChangeEventHandler dtLocationSearchRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AdddtLocationSearchRow(dsLocationSearch.dtLocationSearchRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsLocationSearch.dtLocationSearchRow AdddtLocationSearchRow(
      int ControlNo,
      string PolicyNumber,
      string Line,
      DateTime EffectiveDate,
      DateTime ExpirationDate,
      string LocationNo,
      string BuildingNo,
      string Address,
      string City,
      string State,
      string Zip,
      string ProducerLocationName,
      string InsuredPolicyName,
      string LocStatus,
      DateTime TransAdded)
    {
      dsLocationSearch.dtLocationSearchRow row = (dsLocationSearch.dtLocationSearchRow) this.NewRow();
      object[] objArray = new object[15]
      {
        (object) ControlNo,
        (object) PolicyNumber,
        (object) Line,
        (object) EffectiveDate,
        (object) ExpirationDate,
        (object) LocationNo,
        (object) BuildingNo,
        (object) Address,
        (object) City,
        (object) State,
        (object) Zip,
        (object) ProducerLocationName,
        (object) InsuredPolicyName,
        (object) LocStatus,
        (object) TransAdded
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsLocationSearch.dtLocationSearchDataTable locationSearchDataTable = (dsLocationSearch.dtLocationSearchDataTable) base.Clone();
      locationSearchDataTable.InitVars();
      return (DataTable) locationSearchDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsLocationSearch.dtLocationSearchDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnControlNo = this.Columns["ControlNo"];
      this.columnPolicyNumber = this.Columns["PolicyNumber"];
      this.columnLine = this.Columns["Line"];
      this.columnEffectiveDate = this.Columns["EffectiveDate"];
      this.columnExpirationDate = this.Columns["ExpirationDate"];
      this.columnLocationNo = this.Columns["LocationNo"];
      this.columnBuildingNo = this.Columns["BuildingNo"];
      this.columnAddress = this.Columns["Address"];
      this.columnCity = this.Columns["City"];
      this.columnState = this.Columns["State"];
      this.columnZip = this.Columns["Zip"];
      this.columnProducerLocationName = this.Columns["ProducerLocationName"];
      this.columnInsuredPolicyName = this.Columns["InsuredPolicyName"];
      this.columnLocStatus = this.Columns["LocStatus"];
      this.columnTransAdded = this.Columns["TransAdded"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnControlNo = new DataColumn("ControlNo", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnControlNo);
      this.columnPolicyNumber = new DataColumn("PolicyNumber", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPolicyNumber);
      this.columnLine = new DataColumn("Line", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLine);
      this.columnEffectiveDate = new DataColumn("EffectiveDate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEffectiveDate);
      this.columnExpirationDate = new DataColumn("ExpirationDate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnExpirationDate);
      this.columnLocationNo = new DataColumn("LocationNo", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLocationNo);
      this.columnBuildingNo = new DataColumn("BuildingNo", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnBuildingNo);
      this.columnAddress = new DataColumn("Address", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAddress);
      this.columnCity = new DataColumn("City", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCity);
      this.columnState = new DataColumn("State", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnState);
      this.columnZip = new DataColumn("Zip", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnZip);
      this.columnProducerLocationName = new DataColumn("ProducerLocationName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnProducerLocationName);
      this.columnInsuredPolicyName = new DataColumn("InsuredPolicyName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInsuredPolicyName);
      this.columnLocStatus = new DataColumn("LocStatus", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLocStatus);
      this.columnTransAdded = new DataColumn("TransAdded", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnTransAdded);
      this.columnControlNo.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsLocationSearch.dtLocationSearchRow NewdtLocationSearchRow()
    {
      return (dsLocationSearch.dtLocationSearchRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsLocationSearch.dtLocationSearchRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (dsLocationSearch.dtLocationSearchRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.dtLocationSearchRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsLocationSearch.dtLocationSearchRowChangeEventHandler searchRowChangedEvent = this.dtLocationSearchRowChangedEvent;
      if (searchRowChangedEvent == null)
        return;
      searchRowChangedEvent((object) this, new dsLocationSearch.dtLocationSearchRowChangeEvent((dsLocationSearch.dtLocationSearchRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.dtLocationSearchRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsLocationSearch.dtLocationSearchRowChangeEventHandler rowChangingEvent = this.dtLocationSearchRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsLocationSearch.dtLocationSearchRowChangeEvent((dsLocationSearch.dtLocationSearchRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.dtLocationSearchRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsLocationSearch.dtLocationSearchRowChangeEventHandler searchRowDeletedEvent = this.dtLocationSearchRowDeletedEvent;
      if (searchRowDeletedEvent == null)
        return;
      searchRowDeletedEvent((object) this, new dsLocationSearch.dtLocationSearchRowChangeEvent((dsLocationSearch.dtLocationSearchRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.dtLocationSearchRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsLocationSearch.dtLocationSearchRowChangeEventHandler rowDeletingEvent = this.dtLocationSearchRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsLocationSearch.dtLocationSearchRowChangeEvent((dsLocationSearch.dtLocationSearchRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemovedtLocationSearchRow(dsLocationSearch.dtLocationSearchRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsLocationSearch dsLocationSearch = new dsLocationSearch();
      XmlSchemaAny xmlSchemaAny1 = new XmlSchemaAny();
      xmlSchemaAny1.Namespace = "http://www.w3.org/2001/XMLSchema";
      xmlSchemaAny1.MinOccurs = 0M;
      xmlSchemaAny1.MaxOccurs = Decimal.MaxValue;
      xmlSchemaAny1.ProcessContents = XmlSchemaContentProcessing.Lax;
      xmlSchemaSequence.Items.Add((XmlSchemaObject) xmlSchemaAny1);
      XmlSchemaAny xmlSchemaAny2 = new XmlSchemaAny();
      xmlSchemaAny2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
      xmlSchemaAny2.MinOccurs = 1M;
      xmlSchemaAny2.ProcessContents = XmlSchemaContentProcessing.Lax;
      xmlSchemaSequence.Items.Add((XmlSchemaObject) xmlSchemaAny2);
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "namespace",
        FixedValue = dsLocationSearch.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (dtLocationSearchDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsLocationSearch.GetSchemaSerializable();
      XmlSchemaComplexType typedTableSchema;
      if (xs.Contains(schemaSerializable.TargetNamespace))
      {
        MemoryStream memoryStream1 = new MemoryStream();
        MemoryStream memoryStream2 = new MemoryStream();
        try
        {
          schemaSerializable.Write((Stream) memoryStream1);
          IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
          while (enumerator.MoveNext())
          {
            XmlSchema current = (XmlSchema) enumerator.Current;
            memoryStream2.SetLength(0L);
            MemoryStream memoryStream3 = memoryStream2;
            current.Write((Stream) memoryStream3);
            if (memoryStream1.Length == memoryStream2.Length)
            {
              memoryStream1.Position = 0L;
              memoryStream2.Position = 0L;
              do
                ;
              while (memoryStream1.Position != memoryStream1.Length && memoryStream1.ReadByte() == memoryStream2.ReadByte());
              if (memoryStream1.Position == memoryStream1.Length)
              {
                typedTableSchema = schemaComplexType;
                goto label_15;
              }
            }
          }
        }
        finally
        {
          memoryStream1?.Close();
          memoryStream2?.Close();
        }
      }
      xs.Add(schemaSerializable);
      typedTableSchema = schemaComplexType;
label_15:
      return typedTableSchema;
    }
  }

  public class dtLocationSearchRow : DataRow
  {
    private dsLocationSearch.dtLocationSearchDataTable tabledtLocationSearch;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal dtLocationSearchRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabledtLocationSearch = (dsLocationSearch.dtLocationSearchDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int ControlNo
    {
      get => Conversions.ToInteger(this[this.tabledtLocationSearch.ControlNoColumn]);
      set => this[this.tabledtLocationSearch.ControlNoColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string PolicyNumber
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtLocationSearch.PolicyNumberColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'PolicyNumber' in table 'dtLocationSearch' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtLocationSearch.PolicyNumberColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Line
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtLocationSearch.LineColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Line' in table 'dtLocationSearch' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtLocationSearch.LineColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DateTime EffectiveDate
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tabledtLocationSearch.EffectiveDateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'EffectiveDate' in table 'dtLocationSearch' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtLocationSearch.EffectiveDateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DateTime ExpirationDate
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tabledtLocationSearch.ExpirationDateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ExpirationDate' in table 'dtLocationSearch' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtLocationSearch.ExpirationDateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string LocationNo
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtLocationSearch.LocationNoColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'LocationNo' in table 'dtLocationSearch' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtLocationSearch.LocationNoColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string BuildingNo
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtLocationSearch.BuildingNoColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'BuildingNo' in table 'dtLocationSearch' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtLocationSearch.BuildingNoColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Address
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtLocationSearch.AddressColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Address' in table 'dtLocationSearch' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtLocationSearch.AddressColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string City
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtLocationSearch.CityColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'City' in table 'dtLocationSearch' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtLocationSearch.CityColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string State
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtLocationSearch.StateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'State' in table 'dtLocationSearch' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtLocationSearch.StateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Zip
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtLocationSearch.ZipColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Zip' in table 'dtLocationSearch' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtLocationSearch.ZipColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string ProducerLocationName
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtLocationSearch.ProducerLocationNameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ProducerLocationName' in table 'dtLocationSearch' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtLocationSearch.ProducerLocationNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string InsuredPolicyName
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtLocationSearch.InsuredPolicyNameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'InsuredPolicyName' in table 'dtLocationSearch' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtLocationSearch.InsuredPolicyNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string LocStatus
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtLocationSearch.LocStatusColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'LocStatus' in table 'dtLocationSearch' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtLocationSearch.LocStatusColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DateTime TransAdded
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tabledtLocationSearch.TransAddedColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'TransAdded' in table 'dtLocationSearch' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtLocationSearch.TransAddedColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsPolicyNumberNull() => this.IsNull(this.tabledtLocationSearch.PolicyNumberColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetPolicyNumberNull()
    {
      this[this.tabledtLocationSearch.PolicyNumberColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsLineNull() => this.IsNull(this.tabledtLocationSearch.LineColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetLineNull()
    {
      this[this.tabledtLocationSearch.LineColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsEffectiveDateNull()
    {
      return this.IsNull(this.tabledtLocationSearch.EffectiveDateColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetEffectiveDateNull()
    {
      this[this.tabledtLocationSearch.EffectiveDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsExpirationDateNull()
    {
      return this.IsNull(this.tabledtLocationSearch.ExpirationDateColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetExpirationDateNull()
    {
      this[this.tabledtLocationSearch.ExpirationDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsLocationNoNull() => this.IsNull(this.tabledtLocationSearch.LocationNoColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetLocationNoNull()
    {
      this[this.tabledtLocationSearch.LocationNoColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsBuildingNoNull() => this.IsNull(this.tabledtLocationSearch.BuildingNoColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetBuildingNoNull()
    {
      this[this.tabledtLocationSearch.BuildingNoColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsAddressNull() => this.IsNull(this.tabledtLocationSearch.AddressColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetAddressNull()
    {
      this[this.tabledtLocationSearch.AddressColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsCityNull() => this.IsNull(this.tabledtLocationSearch.CityColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetCityNull()
    {
      this[this.tabledtLocationSearch.CityColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsStateNull() => this.IsNull(this.tabledtLocationSearch.StateColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetStateNull()
    {
      this[this.tabledtLocationSearch.StateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsZipNull() => this.IsNull(this.tabledtLocationSearch.ZipColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetZipNull()
    {
      this[this.tabledtLocationSearch.ZipColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsProducerLocationNameNull()
    {
      return this.IsNull(this.tabledtLocationSearch.ProducerLocationNameColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetProducerLocationNameNull()
    {
      this[this.tabledtLocationSearch.ProducerLocationNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsInsuredPolicyNameNull()
    {
      return this.IsNull(this.tabledtLocationSearch.InsuredPolicyNameColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetInsuredPolicyNameNull()
    {
      this[this.tabledtLocationSearch.InsuredPolicyNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsLocStatusNull() => this.IsNull(this.tabledtLocationSearch.LocStatusColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetLocStatusNull()
    {
      this[this.tabledtLocationSearch.LocStatusColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsTransAddedNull() => this.IsNull(this.tabledtLocationSearch.TransAddedColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetTransAddedNull()
    {
      this[this.tabledtLocationSearch.TransAddedColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class dtLocationSearchRowChangeEvent : EventArgs
  {
    private dsLocationSearch.dtLocationSearchRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dtLocationSearchRowChangeEvent(
      dsLocationSearch.dtLocationSearchRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsLocationSearch.dtLocationSearchRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }
}
