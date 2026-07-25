// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.dsCompareInspect
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
[XmlRoot("dsCompareInspect")]
[HelpKeyword("vs.data.DataSet")]
[Serializable]
public class dsCompareInspect : DataSet
{
  private dsCompareInspect.dtLocationsDataTable tabledtLocations;
  private dsCompareInspect.tblInspectionsDataDataTable tabletblInspectionsData;
  private dsCompareInspect.tblNetRateInspectionInfoDataTable tabletblNetRateInspectionInfo;
  private dsCompareInspect.lstConstructionTypesDataTable tablelstConstructionTypes;
  private dsCompareInspect.tblUnderwritingLocationsDataTable tabletblUnderwritingLocations;
  private SchemaSerializationMode _schemaSerializationMode;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public dsCompareInspect()
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
  protected dsCompareInspect(SerializationInfo info, StreamingContext context)
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
        if (dataSet.Tables[nameof (dtLocations)] != null)
          base.Tables.Add((DataTable) new dsCompareInspect.dtLocationsDataTable(dataSet.Tables[nameof (dtLocations)]));
        if (dataSet.Tables[nameof (tblInspectionsData)] != null)
          base.Tables.Add((DataTable) new dsCompareInspect.tblInspectionsDataDataTable(dataSet.Tables[nameof (tblInspectionsData)]));
        if (dataSet.Tables[nameof (tblNetRateInspectionInfo)] != null)
          base.Tables.Add((DataTable) new dsCompareInspect.tblNetRateInspectionInfoDataTable(dataSet.Tables[nameof (tblNetRateInspectionInfo)]));
        if (dataSet.Tables[nameof (lstConstructionTypes)] != null)
          base.Tables.Add((DataTable) new dsCompareInspect.lstConstructionTypesDataTable(dataSet.Tables[nameof (lstConstructionTypes)]));
        if (dataSet.Tables[nameof (tblUnderwritingLocations)] != null)
          base.Tables.Add((DataTable) new dsCompareInspect.tblUnderwritingLocationsDataTable(dataSet.Tables[nameof (tblUnderwritingLocations)]));
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
  public dsCompareInspect.dtLocationsDataTable dtLocations => this.tabledtLocations;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsCompareInspect.tblInspectionsDataDataTable tblInspectionsData
  {
    get => this.tabletblInspectionsData;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsCompareInspect.tblNetRateInspectionInfoDataTable tblNetRateInspectionInfo
  {
    get => this.tabletblNetRateInspectionInfo;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsCompareInspect.lstConstructionTypesDataTable lstConstructionTypes
  {
    get => this.tablelstConstructionTypes;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsCompareInspect.tblUnderwritingLocationsDataTable tblUnderwritingLocations
  {
    get => this.tabletblUnderwritingLocations;
  }

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
    dsCompareInspect dsCompareInspect = (dsCompareInspect) base.Clone();
    dsCompareInspect.InitVars();
    dsCompareInspect.SchemaSerializationMode = this.SchemaSerializationMode;
    return (DataSet) dsCompareInspect;
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
      if (dataSet.Tables["dtLocations"] != null)
        base.Tables.Add((DataTable) new dsCompareInspect.dtLocationsDataTable(dataSet.Tables["dtLocations"]));
      if (dataSet.Tables["tblInspectionsData"] != null)
        base.Tables.Add((DataTable) new dsCompareInspect.tblInspectionsDataDataTable(dataSet.Tables["tblInspectionsData"]));
      if (dataSet.Tables["tblNetRateInspectionInfo"] != null)
        base.Tables.Add((DataTable) new dsCompareInspect.tblNetRateInspectionInfoDataTable(dataSet.Tables["tblNetRateInspectionInfo"]));
      if (dataSet.Tables["lstConstructionTypes"] != null)
        base.Tables.Add((DataTable) new dsCompareInspect.lstConstructionTypesDataTable(dataSet.Tables["lstConstructionTypes"]));
      if (dataSet.Tables["tblUnderwritingLocations"] != null)
        base.Tables.Add((DataTable) new dsCompareInspect.tblUnderwritingLocationsDataTable(dataSet.Tables["tblUnderwritingLocations"]));
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
    this.tabledtLocations = (dsCompareInspect.dtLocationsDataTable) base.Tables["dtLocations"];
    if (initTable && this.tabledtLocations != null)
      this.tabledtLocations.InitVars();
    this.tabletblInspectionsData = (dsCompareInspect.tblInspectionsDataDataTable) base.Tables["tblInspectionsData"];
    if (initTable && this.tabletblInspectionsData != null)
      this.tabletblInspectionsData.InitVars();
    this.tabletblNetRateInspectionInfo = (dsCompareInspect.tblNetRateInspectionInfoDataTable) base.Tables["tblNetRateInspectionInfo"];
    if (initTable && this.tabletblNetRateInspectionInfo != null)
      this.tabletblNetRateInspectionInfo.InitVars();
    this.tablelstConstructionTypes = (dsCompareInspect.lstConstructionTypesDataTable) base.Tables["lstConstructionTypes"];
    if (initTable && this.tablelstConstructionTypes != null)
      this.tablelstConstructionTypes.InitVars();
    this.tabletblUnderwritingLocations = (dsCompareInspect.tblUnderwritingLocationsDataTable) base.Tables["tblUnderwritingLocations"];
    if (!initTable || this.tabletblUnderwritingLocations == null)
      return;
    this.tabletblUnderwritingLocations.InitVars();
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private void InitClass()
  {
    this.DataSetName = nameof (dsCompareInspect);
    this.Prefix = "";
    this.Namespace = "http://tempuri.org/dsCompareInspect.xsd";
    this.EnforceConstraints = true;
    this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.tabledtLocations = new dsCompareInspect.dtLocationsDataTable();
    base.Tables.Add((DataTable) this.tabledtLocations);
    this.tabletblInspectionsData = new dsCompareInspect.tblInspectionsDataDataTable();
    base.Tables.Add((DataTable) this.tabletblInspectionsData);
    this.tabletblNetRateInspectionInfo = new dsCompareInspect.tblNetRateInspectionInfoDataTable();
    base.Tables.Add((DataTable) this.tabletblNetRateInspectionInfo);
    this.tablelstConstructionTypes = new dsCompareInspect.lstConstructionTypesDataTable();
    base.Tables.Add((DataTable) this.tablelstConstructionTypes);
    this.tabletblUnderwritingLocations = new dsCompareInspect.tblUnderwritingLocationsDataTable();
    base.Tables.Add((DataTable) this.tabletblUnderwritingLocations);
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializedtLocations() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializetblInspectionsData() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializetblNetRateInspectionInfo() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializelstConstructionTypes() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializetblUnderwritingLocations() => false;

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
    dsCompareInspect dsCompareInspect = new dsCompareInspect();
    XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
    schemaComplexType.Particle = (XmlSchemaParticle) new XmlSchemaSequence()
    {
      Items = {
        (XmlSchemaObject) new XmlSchemaAny()
        {
          Namespace = dsCompareInspect.Namespace
        }
      }
    };
    XmlSchema schemaSerializable = dsCompareInspect.GetSchemaSerializable();
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
  public delegate void dtLocationsRowChangeEventHandler(
    object sender,
    dsCompareInspect.dtLocationsRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void tblInspectionsDataRowChangeEventHandler(
    object sender,
    dsCompareInspect.tblInspectionsDataRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void tblNetRateInspectionInfoRowChangeEventHandler(
    object sender,
    dsCompareInspect.tblNetRateInspectionInfoRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void lstConstructionTypesRowChangeEventHandler(
    object sender,
    dsCompareInspect.lstConstructionTypesRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void tblUnderwritingLocationsRowChangeEventHandler(
    object sender,
    dsCompareInspect.tblUnderwritingLocationsRowChangeEvent e);

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class dtLocationsDataTable : TypedTableBase<dsCompareInspect.dtLocationsRow>
  {
    private DataColumn columnLocation;
    private DataColumn columnAddress1;
    private DataColumn columnAddress2;
    private DataColumn columnCity;
    private DataColumn columnState;
    private DataColumn columnZip;
    private DataColumn columnConstruction;
    private DataColumn columnSqFootage;
    private DataColumn columnYearBuilt;
    private DataColumn columnLocationID;
    private DataColumn columnNumberOfStories;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dtLocationsDataTable()
    {
      this.TableName = "dtLocations";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal dtLocationsDataTable(DataTable table)
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
    protected dtLocationsDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn LocationColumn => this.columnLocation;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn Address1Column => this.columnAddress1;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn Address2Column => this.columnAddress2;

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
    public DataColumn ConstructionColumn => this.columnConstruction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn SqFootageColumn => this.columnSqFootage;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn YearBuiltColumn => this.columnYearBuilt;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn LocationIDColumn => this.columnLocationID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn NumberOfStoriesColumn => this.columnNumberOfStories;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompareInspect.dtLocationsRow this[int index]
    {
      get => (dsCompareInspect.dtLocationsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsCompareInspect.dtLocationsRowChangeEventHandler dtLocationsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsCompareInspect.dtLocationsRowChangeEventHandler dtLocationsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsCompareInspect.dtLocationsRowChangeEventHandler dtLocationsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsCompareInspect.dtLocationsRowChangeEventHandler dtLocationsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AdddtLocationsRow(dsCompareInspect.dtLocationsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompareInspect.dtLocationsRow AdddtLocationsRow(
      string Location,
      string Address1,
      string Address2,
      string City,
      string State,
      string Zip,
      string Construction,
      string SqFootage,
      string YearBuilt,
      int LocationID,
      string NumberOfStories)
    {
      dsCompareInspect.dtLocationsRow row = (dsCompareInspect.dtLocationsRow) this.NewRow();
      object[] objArray = new object[11]
      {
        (object) Location,
        (object) Address1,
        (object) Address2,
        (object) City,
        (object) State,
        (object) Zip,
        (object) Construction,
        (object) SqFootage,
        (object) YearBuilt,
        (object) LocationID,
        (object) NumberOfStories
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsCompareInspect.dtLocationsDataTable locationsDataTable = (dsCompareInspect.dtLocationsDataTable) base.Clone();
      locationsDataTable.InitVars();
      return (DataTable) locationsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsCompareInspect.dtLocationsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnLocation = this.Columns["Location"];
      this.columnAddress1 = this.Columns["Address1"];
      this.columnAddress2 = this.Columns["Address2"];
      this.columnCity = this.Columns["City"];
      this.columnState = this.Columns["State"];
      this.columnZip = this.Columns["Zip"];
      this.columnConstruction = this.Columns["Construction"];
      this.columnSqFootage = this.Columns["SqFootage"];
      this.columnYearBuilt = this.Columns["YearBuilt"];
      this.columnLocationID = this.Columns["LocationID"];
      this.columnNumberOfStories = this.Columns["NumberOfStories"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnLocation = new DataColumn("Location", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLocation);
      this.columnAddress1 = new DataColumn("Address1", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAddress1);
      this.columnAddress2 = new DataColumn("Address2", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAddress2);
      this.columnCity = new DataColumn("City", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCity);
      this.columnState = new DataColumn("State", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnState);
      this.columnZip = new DataColumn("Zip", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnZip);
      this.columnConstruction = new DataColumn("Construction", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnConstruction);
      this.columnSqFootage = new DataColumn("SqFootage", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSqFootage);
      this.columnYearBuilt = new DataColumn("YearBuilt", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnYearBuilt);
      this.columnLocationID = new DataColumn("LocationID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLocationID);
      this.columnNumberOfStories = new DataColumn("NumberOfStories", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnNumberOfStories);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompareInspect.dtLocationsRow NewdtLocationsRow()
    {
      return (dsCompareInspect.dtLocationsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsCompareInspect.dtLocationsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (dsCompareInspect.dtLocationsRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.dtLocationsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompareInspect.dtLocationsRowChangeEventHandler locationsRowChangedEvent = this.dtLocationsRowChangedEvent;
      if (locationsRowChangedEvent == null)
        return;
      locationsRowChangedEvent((object) this, new dsCompareInspect.dtLocationsRowChangeEvent((dsCompareInspect.dtLocationsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.dtLocationsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompareInspect.dtLocationsRowChangeEventHandler rowChangingEvent = this.dtLocationsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsCompareInspect.dtLocationsRowChangeEvent((dsCompareInspect.dtLocationsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.dtLocationsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompareInspect.dtLocationsRowChangeEventHandler locationsRowDeletedEvent = this.dtLocationsRowDeletedEvent;
      if (locationsRowDeletedEvent == null)
        return;
      locationsRowDeletedEvent((object) this, new dsCompareInspect.dtLocationsRowChangeEvent((dsCompareInspect.dtLocationsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.dtLocationsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompareInspect.dtLocationsRowChangeEventHandler rowDeletingEvent = this.dtLocationsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsCompareInspect.dtLocationsRowChangeEvent((dsCompareInspect.dtLocationsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemovedtLocationsRow(dsCompareInspect.dtLocationsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsCompareInspect dsCompareInspect = new dsCompareInspect();
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
        FixedValue = dsCompareInspect.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (dtLocationsDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsCompareInspect.GetSchemaSerializable();
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

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class tblInspectionsDataDataTable : TypedTableBase<dsCompareInspect.tblInspectionsDataRow>
  {
    private DataColumn columnCustTraceID;
    private DataColumn columnYearBuilt;
    private DataColumn columnRoofCover;
    private DataColumn columnElectricalDate;
    private DataColumn columnRoofDate;
    private DataColumn columnHeatingDate;
    private DataColumn columnPlumbingDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblInspectionsDataDataTable()
    {
      this.TableName = "tblInspectionsData";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblInspectionsDataDataTable(DataTable table)
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
    protected tblInspectionsDataDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn CustTraceIDColumn => this.columnCustTraceID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn YearBuiltColumn => this.columnYearBuilt;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn RoofCoverColumn => this.columnRoofCover;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ElectricalDateColumn => this.columnElectricalDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn RoofDateColumn => this.columnRoofDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn HeatingDateColumn => this.columnHeatingDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn PlumbingDateColumn => this.columnPlumbingDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompareInspect.tblInspectionsDataRow this[int index]
    {
      get => (dsCompareInspect.tblInspectionsDataRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsCompareInspect.tblInspectionsDataRowChangeEventHandler tblInspectionsDataRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsCompareInspect.tblInspectionsDataRowChangeEventHandler tblInspectionsDataRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsCompareInspect.tblInspectionsDataRowChangeEventHandler tblInspectionsDataRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsCompareInspect.tblInspectionsDataRowChangeEventHandler tblInspectionsDataRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddtblInspectionsDataRow(dsCompareInspect.tblInspectionsDataRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompareInspect.tblInspectionsDataRow AddtblInspectionsDataRow(
      string CustTraceID,
      int YearBuilt,
      string RoofCover,
      int ElectricalDate,
      int RoofDate,
      int HeatingDate,
      int PlumbingDate)
    {
      dsCompareInspect.tblInspectionsDataRow row = (dsCompareInspect.tblInspectionsDataRow) this.NewRow();
      object[] objArray = new object[7]
      {
        (object) CustTraceID,
        (object) YearBuilt,
        (object) RoofCover,
        (object) ElectricalDate,
        (object) RoofDate,
        (object) HeatingDate,
        (object) PlumbingDate
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsCompareInspect.tblInspectionsDataDataTable inspectionsDataDataTable = (dsCompareInspect.tblInspectionsDataDataTable) base.Clone();
      inspectionsDataDataTable.InitVars();
      return (DataTable) inspectionsDataDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsCompareInspect.tblInspectionsDataDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnCustTraceID = this.Columns["CustTraceID"];
      this.columnYearBuilt = this.Columns["YearBuilt"];
      this.columnRoofCover = this.Columns["RoofCover"];
      this.columnElectricalDate = this.Columns["ElectricalDate"];
      this.columnRoofDate = this.Columns["RoofDate"];
      this.columnHeatingDate = this.Columns["HeatingDate"];
      this.columnPlumbingDate = this.Columns["PlumbingDate"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnCustTraceID = new DataColumn("CustTraceID", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCustTraceID);
      this.columnYearBuilt = new DataColumn("YearBuilt", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnYearBuilt);
      this.columnRoofCover = new DataColumn("RoofCover", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnRoofCover);
      this.columnElectricalDate = new DataColumn("ElectricalDate", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnElectricalDate);
      this.columnRoofDate = new DataColumn("RoofDate", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnRoofDate);
      this.columnHeatingDate = new DataColumn("HeatingDate", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnHeatingDate);
      this.columnPlumbingDate = new DataColumn("PlumbingDate", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPlumbingDate);
      this.columnCustTraceID.AllowDBNull = false;
      this.columnCustTraceID.MaxLength = 30;
      this.columnRoofCover.MaxLength = 25;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompareInspect.tblInspectionsDataRow NewtblInspectionsDataRow()
    {
      return (dsCompareInspect.tblInspectionsDataRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsCompareInspect.tblInspectionsDataRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (dsCompareInspect.tblInspectionsDataRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblInspectionsDataRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompareInspect.tblInspectionsDataRowChangeEventHandler dataRowChangedEvent = this.tblInspectionsDataRowChangedEvent;
      if (dataRowChangedEvent == null)
        return;
      dataRowChangedEvent((object) this, new dsCompareInspect.tblInspectionsDataRowChangeEvent((dsCompareInspect.tblInspectionsDataRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblInspectionsDataRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompareInspect.tblInspectionsDataRowChangeEventHandler rowChangingEvent = this.tblInspectionsDataRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsCompareInspect.tblInspectionsDataRowChangeEvent((dsCompareInspect.tblInspectionsDataRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblInspectionsDataRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompareInspect.tblInspectionsDataRowChangeEventHandler dataRowDeletedEvent = this.tblInspectionsDataRowDeletedEvent;
      if (dataRowDeletedEvent == null)
        return;
      dataRowDeletedEvent((object) this, new dsCompareInspect.tblInspectionsDataRowChangeEvent((dsCompareInspect.tblInspectionsDataRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblInspectionsDataRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompareInspect.tblInspectionsDataRowChangeEventHandler rowDeletingEvent = this.tblInspectionsDataRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsCompareInspect.tblInspectionsDataRowChangeEvent((dsCompareInspect.tblInspectionsDataRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemovetblInspectionsDataRow(dsCompareInspect.tblInspectionsDataRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsCompareInspect dsCompareInspect = new dsCompareInspect();
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
        FixedValue = dsCompareInspect.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblInspectionsDataDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsCompareInspect.GetSchemaSerializable();
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

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class tblNetRateInspectionInfoDataTable : 
    TypedTableBase<dsCompareInspect.tblNetRateInspectionInfoRow>
  {
    private DataColumn columnLocationID;
    private DataColumn columnPremesisID;
    private DataColumn columnExposureID;
    private DataColumn columnQuoteID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblNetRateInspectionInfoDataTable()
    {
      this.TableName = "tblNetRateInspectionInfo";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblNetRateInspectionInfoDataTable(DataTable table)
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
    protected tblNetRateInspectionInfoDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn LocationIDColumn => this.columnLocationID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn PremesisIDColumn => this.columnPremesisID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ExposureIDColumn => this.columnExposureID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn QuoteIDColumn => this.columnQuoteID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompareInspect.tblNetRateInspectionInfoRow this[int index]
    {
      get => (dsCompareInspect.tblNetRateInspectionInfoRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsCompareInspect.tblNetRateInspectionInfoRowChangeEventHandler tblNetRateInspectionInfoRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsCompareInspect.tblNetRateInspectionInfoRowChangeEventHandler tblNetRateInspectionInfoRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsCompareInspect.tblNetRateInspectionInfoRowChangeEventHandler tblNetRateInspectionInfoRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsCompareInspect.tblNetRateInspectionInfoRowChangeEventHandler tblNetRateInspectionInfoRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddtblNetRateInspectionInfoRow(dsCompareInspect.tblNetRateInspectionInfoRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompareInspect.tblNetRateInspectionInfoRow AddtblNetRateInspectionInfoRow(
      int LocationID,
      int PremesisID,
      int ExposureID,
      int QuoteID)
    {
      dsCompareInspect.tblNetRateInspectionInfoRow row = (dsCompareInspect.tblNetRateInspectionInfoRow) this.NewRow();
      object[] objArray = new object[4]
      {
        (object) LocationID,
        (object) PremesisID,
        (object) ExposureID,
        (object) QuoteID
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsCompareInspect.tblNetRateInspectionInfoDataTable inspectionInfoDataTable = (dsCompareInspect.tblNetRateInspectionInfoDataTable) base.Clone();
      inspectionInfoDataTable.InitVars();
      return (DataTable) inspectionInfoDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsCompareInspect.tblNetRateInspectionInfoDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnLocationID = this.Columns["LocationID"];
      this.columnPremesisID = this.Columns["PremesisID"];
      this.columnExposureID = this.Columns["ExposureID"];
      this.columnQuoteID = this.Columns["QuoteID"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnLocationID = new DataColumn("LocationID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLocationID);
      this.columnPremesisID = new DataColumn("PremesisID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPremesisID);
      this.columnExposureID = new DataColumn("ExposureID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnExposureID);
      this.columnQuoteID = new DataColumn("QuoteID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnQuoteID);
      this.columnLocationID.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompareInspect.tblNetRateInspectionInfoRow NewtblNetRateInspectionInfoRow()
    {
      return (dsCompareInspect.tblNetRateInspectionInfoRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsCompareInspect.tblNetRateInspectionInfoRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (dsCompareInspect.tblNetRateInspectionInfoRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblNetRateInspectionInfoRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompareInspect.tblNetRateInspectionInfoRowChangeEventHandler infoRowChangedEvent = this.tblNetRateInspectionInfoRowChangedEvent;
      if (infoRowChangedEvent == null)
        return;
      infoRowChangedEvent((object) this, new dsCompareInspect.tblNetRateInspectionInfoRowChangeEvent((dsCompareInspect.tblNetRateInspectionInfoRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblNetRateInspectionInfoRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompareInspect.tblNetRateInspectionInfoRowChangeEventHandler rowChangingEvent = this.tblNetRateInspectionInfoRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsCompareInspect.tblNetRateInspectionInfoRowChangeEvent((dsCompareInspect.tblNetRateInspectionInfoRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblNetRateInspectionInfoRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompareInspect.tblNetRateInspectionInfoRowChangeEventHandler infoRowDeletedEvent = this.tblNetRateInspectionInfoRowDeletedEvent;
      if (infoRowDeletedEvent == null)
        return;
      infoRowDeletedEvent((object) this, new dsCompareInspect.tblNetRateInspectionInfoRowChangeEvent((dsCompareInspect.tblNetRateInspectionInfoRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblNetRateInspectionInfoRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompareInspect.tblNetRateInspectionInfoRowChangeEventHandler rowDeletingEvent = this.tblNetRateInspectionInfoRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsCompareInspect.tblNetRateInspectionInfoRowChangeEvent((dsCompareInspect.tblNetRateInspectionInfoRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemovetblNetRateInspectionInfoRow(dsCompareInspect.tblNetRateInspectionInfoRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsCompareInspect dsCompareInspect = new dsCompareInspect();
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
        FixedValue = dsCompareInspect.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblNetRateInspectionInfoDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsCompareInspect.GetSchemaSerializable();
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

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class lstConstructionTypesDataTable : 
    TypedTableBase<dsCompareInspect.lstConstructionTypesRow>
  {
    private DataColumn columnConstructionTypeID;
    private DataColumn columnType;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public lstConstructionTypesDataTable()
    {
      this.TableName = "lstConstructionTypes";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal lstConstructionTypesDataTable(DataTable table)
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
    protected lstConstructionTypesDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ConstructionTypeIDColumn => this.columnConstructionTypeID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn TypeColumn => this.columnType;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompareInspect.lstConstructionTypesRow this[int index]
    {
      get => (dsCompareInspect.lstConstructionTypesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsCompareInspect.lstConstructionTypesRowChangeEventHandler lstConstructionTypesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsCompareInspect.lstConstructionTypesRowChangeEventHandler lstConstructionTypesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsCompareInspect.lstConstructionTypesRowChangeEventHandler lstConstructionTypesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsCompareInspect.lstConstructionTypesRowChangeEventHandler lstConstructionTypesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddlstConstructionTypesRow(dsCompareInspect.lstConstructionTypesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompareInspect.lstConstructionTypesRow AddlstConstructionTypesRow(
      byte ConstructionTypeID,
      string Type)
    {
      dsCompareInspect.lstConstructionTypesRow row = (dsCompareInspect.lstConstructionTypesRow) this.NewRow();
      object[] objArray = new object[2]
      {
        (object) ConstructionTypeID,
        (object) Type
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompareInspect.lstConstructionTypesRow FindByConstructionTypeID(byte ConstructionTypeID)
    {
      return (dsCompareInspect.lstConstructionTypesRow) this.Rows.Find(new object[1]
      {
        (object) ConstructionTypeID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsCompareInspect.lstConstructionTypesDataTable constructionTypesDataTable = (dsCompareInspect.lstConstructionTypesDataTable) base.Clone();
      constructionTypesDataTable.InitVars();
      return (DataTable) constructionTypesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsCompareInspect.lstConstructionTypesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnConstructionTypeID = this.Columns["ConstructionTypeID"];
      this.columnType = this.Columns["Type"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnConstructionTypeID = new DataColumn("ConstructionTypeID", typeof (byte), (string) null, MappingType.Element);
      this.Columns.Add(this.columnConstructionTypeID);
      this.columnType = new DataColumn("Type", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnType);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnConstructionTypeID
      }, true));
      this.columnConstructionTypeID.AllowDBNull = false;
      this.columnConstructionTypeID.Unique = true;
      this.columnType.AllowDBNull = false;
      this.columnType.MaxLength = 50;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompareInspect.lstConstructionTypesRow NewlstConstructionTypesRow()
    {
      return (dsCompareInspect.lstConstructionTypesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsCompareInspect.lstConstructionTypesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (dsCompareInspect.lstConstructionTypesRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstConstructionTypesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompareInspect.lstConstructionTypesRowChangeEventHandler typesRowChangedEvent = this.lstConstructionTypesRowChangedEvent;
      if (typesRowChangedEvent == null)
        return;
      typesRowChangedEvent((object) this, new dsCompareInspect.lstConstructionTypesRowChangeEvent((dsCompareInspect.lstConstructionTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstConstructionTypesRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompareInspect.lstConstructionTypesRowChangeEventHandler rowChangingEvent = this.lstConstructionTypesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsCompareInspect.lstConstructionTypesRowChangeEvent((dsCompareInspect.lstConstructionTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstConstructionTypesRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompareInspect.lstConstructionTypesRowChangeEventHandler typesRowDeletedEvent = this.lstConstructionTypesRowDeletedEvent;
      if (typesRowDeletedEvent == null)
        return;
      typesRowDeletedEvent((object) this, new dsCompareInspect.lstConstructionTypesRowChangeEvent((dsCompareInspect.lstConstructionTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstConstructionTypesRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompareInspect.lstConstructionTypesRowChangeEventHandler rowDeletingEvent = this.lstConstructionTypesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsCompareInspect.lstConstructionTypesRowChangeEvent((dsCompareInspect.lstConstructionTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemovelstConstructionTypesRow(dsCompareInspect.lstConstructionTypesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsCompareInspect dsCompareInspect = new dsCompareInspect();
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
        FixedValue = dsCompareInspect.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (lstConstructionTypesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsCompareInspect.GetSchemaSerializable();
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

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class tblUnderwritingLocationsDataTable : 
    TypedTableBase<dsCompareInspect.tblUnderwritingLocationsRow>
  {
    private DataColumn columnLocationID;
    private DataColumn columnRoofingYear;
    private DataColumn columnStories;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblUnderwritingLocationsDataTable()
    {
      this.TableName = "tblUnderwritingLocations";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblUnderwritingLocationsDataTable(DataTable table)
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
    protected tblUnderwritingLocationsDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn LocationIDColumn => this.columnLocationID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn RoofingYearColumn => this.columnRoofingYear;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn StoriesColumn => this.columnStories;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompareInspect.tblUnderwritingLocationsRow this[int index]
    {
      get => (dsCompareInspect.tblUnderwritingLocationsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsCompareInspect.tblUnderwritingLocationsRowChangeEventHandler tblUnderwritingLocationsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsCompareInspect.tblUnderwritingLocationsRowChangeEventHandler tblUnderwritingLocationsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsCompareInspect.tblUnderwritingLocationsRowChangeEventHandler tblUnderwritingLocationsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsCompareInspect.tblUnderwritingLocationsRowChangeEventHandler tblUnderwritingLocationsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddtblUnderwritingLocationsRow(dsCompareInspect.tblUnderwritingLocationsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompareInspect.tblUnderwritingLocationsRow AddtblUnderwritingLocationsRow(
      int LocationID,
      string RoofingYear,
      string Stories)
    {
      dsCompareInspect.tblUnderwritingLocationsRow row = (dsCompareInspect.tblUnderwritingLocationsRow) this.NewRow();
      object[] objArray = new object[3]
      {
        (object) LocationID,
        (object) RoofingYear,
        (object) Stories
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompareInspect.tblUnderwritingLocationsRow FindByLocationID(int LocationID)
    {
      return (dsCompareInspect.tblUnderwritingLocationsRow) this.Rows.Find(new object[1]
      {
        (object) LocationID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsCompareInspect.tblUnderwritingLocationsDataTable locationsDataTable = (dsCompareInspect.tblUnderwritingLocationsDataTable) base.Clone();
      locationsDataTable.InitVars();
      return (DataTable) locationsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsCompareInspect.tblUnderwritingLocationsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnLocationID = this.Columns["LocationID"];
      this.columnRoofingYear = this.Columns["RoofingYear"];
      this.columnStories = this.Columns["Stories"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnLocationID = new DataColumn("LocationID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLocationID);
      this.columnRoofingYear = new DataColumn("RoofingYear", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnRoofingYear);
      this.columnStories = new DataColumn("Stories", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnStories);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnLocationID
      }, true));
      this.columnLocationID.AllowDBNull = false;
      this.columnLocationID.Unique = true;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompareInspect.tblUnderwritingLocationsRow NewtblUnderwritingLocationsRow()
    {
      return (dsCompareInspect.tblUnderwritingLocationsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsCompareInspect.tblUnderwritingLocationsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (dsCompareInspect.tblUnderwritingLocationsRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblUnderwritingLocationsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompareInspect.tblUnderwritingLocationsRowChangeEventHandler locationsRowChangedEvent = this.tblUnderwritingLocationsRowChangedEvent;
      if (locationsRowChangedEvent == null)
        return;
      locationsRowChangedEvent((object) this, new dsCompareInspect.tblUnderwritingLocationsRowChangeEvent((dsCompareInspect.tblUnderwritingLocationsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblUnderwritingLocationsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompareInspect.tblUnderwritingLocationsRowChangeEventHandler rowChangingEvent = this.tblUnderwritingLocationsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsCompareInspect.tblUnderwritingLocationsRowChangeEvent((dsCompareInspect.tblUnderwritingLocationsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblUnderwritingLocationsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompareInspect.tblUnderwritingLocationsRowChangeEventHandler locationsRowDeletedEvent = this.tblUnderwritingLocationsRowDeletedEvent;
      if (locationsRowDeletedEvent == null)
        return;
      locationsRowDeletedEvent((object) this, new dsCompareInspect.tblUnderwritingLocationsRowChangeEvent((dsCompareInspect.tblUnderwritingLocationsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblUnderwritingLocationsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompareInspect.tblUnderwritingLocationsRowChangeEventHandler rowDeletingEvent = this.tblUnderwritingLocationsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsCompareInspect.tblUnderwritingLocationsRowChangeEvent((dsCompareInspect.tblUnderwritingLocationsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemovetblUnderwritingLocationsRow(dsCompareInspect.tblUnderwritingLocationsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsCompareInspect dsCompareInspect = new dsCompareInspect();
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
        FixedValue = dsCompareInspect.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblUnderwritingLocationsDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsCompareInspect.GetSchemaSerializable();
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

  public class dtLocationsRow : DataRow
  {
    private dsCompareInspect.dtLocationsDataTable tabledtLocations;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal dtLocationsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabledtLocations = (dsCompareInspect.dtLocationsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Location
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtLocations.LocationColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Location' in table 'dtLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtLocations.LocationColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Address1
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtLocations.Address1Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Address1' in table 'dtLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtLocations.Address1Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Address2
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtLocations.Address2Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Address2' in table 'dtLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtLocations.Address2Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string City
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtLocations.CityColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'City' in table 'dtLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtLocations.CityColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string State
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtLocations.StateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'State' in table 'dtLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtLocations.StateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Zip
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtLocations.ZipColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Zip' in table 'dtLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtLocations.ZipColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Construction
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtLocations.ConstructionColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Construction' in table 'dtLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtLocations.ConstructionColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string SqFootage
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtLocations.SqFootageColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'SqFootage' in table 'dtLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtLocations.SqFootageColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string YearBuilt
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtLocations.YearBuiltColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'YearBuilt' in table 'dtLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtLocations.YearBuiltColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int LocationID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabledtLocations.LocationIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'LocationID' in table 'dtLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtLocations.LocationIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string NumberOfStories
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtLocations.NumberOfStoriesColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'NumberOfStories' in table 'dtLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtLocations.NumberOfStoriesColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsLocationNull() => this.IsNull(this.tabledtLocations.LocationColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetLocationNull()
    {
      this[this.tabledtLocations.LocationColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsAddress1Null() => this.IsNull(this.tabledtLocations.Address1Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetAddress1Null()
    {
      this[this.tabledtLocations.Address1Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsAddress2Null() => this.IsNull(this.tabledtLocations.Address2Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetAddress2Null()
    {
      this[this.tabledtLocations.Address2Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsCityNull() => this.IsNull(this.tabledtLocations.CityColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetCityNull()
    {
      this[this.tabledtLocations.CityColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsStateNull() => this.IsNull(this.tabledtLocations.StateColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetStateNull()
    {
      this[this.tabledtLocations.StateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsZipNull() => this.IsNull(this.tabledtLocations.ZipColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetZipNull()
    {
      this[this.tabledtLocations.ZipColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsConstructionNull() => this.IsNull(this.tabledtLocations.ConstructionColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetConstructionNull()
    {
      this[this.tabledtLocations.ConstructionColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsSqFootageNull() => this.IsNull(this.tabledtLocations.SqFootageColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetSqFootageNull()
    {
      this[this.tabledtLocations.SqFootageColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsYearBuiltNull() => this.IsNull(this.tabledtLocations.YearBuiltColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetYearBuiltNull()
    {
      this[this.tabledtLocations.YearBuiltColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsLocationIDNull() => this.IsNull(this.tabledtLocations.LocationIDColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetLocationIDNull()
    {
      this[this.tabledtLocations.LocationIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsNumberOfStoriesNull() => this.IsNull(this.tabledtLocations.NumberOfStoriesColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetNumberOfStoriesNull()
    {
      this[this.tabledtLocations.NumberOfStoriesColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class tblInspectionsDataRow : DataRow
  {
    private dsCompareInspect.tblInspectionsDataDataTable tabletblInspectionsData;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblInspectionsDataRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblInspectionsData = (dsCompareInspect.tblInspectionsDataDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string CustTraceID
    {
      get => Conversions.ToString(this[this.tabletblInspectionsData.CustTraceIDColumn]);
      set => this[this.tabletblInspectionsData.CustTraceIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int YearBuilt
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblInspectionsData.YearBuiltColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'YearBuilt' in table 'tblInspectionsData' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblInspectionsData.YearBuiltColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string RoofCover
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblInspectionsData.RoofCoverColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'RoofCover' in table 'tblInspectionsData' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblInspectionsData.RoofCoverColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int ElectricalDate
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblInspectionsData.ElectricalDateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ElectricalDate' in table 'tblInspectionsData' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblInspectionsData.ElectricalDateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int RoofDate
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblInspectionsData.RoofDateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'RoofDate' in table 'tblInspectionsData' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblInspectionsData.RoofDateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int HeatingDate
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblInspectionsData.HeatingDateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'HeatingDate' in table 'tblInspectionsData' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblInspectionsData.HeatingDateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int PlumbingDate
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblInspectionsData.PlumbingDateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'PlumbingDate' in table 'tblInspectionsData' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblInspectionsData.PlumbingDateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsYearBuiltNull() => this.IsNull(this.tabletblInspectionsData.YearBuiltColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetYearBuiltNull()
    {
      this[this.tabletblInspectionsData.YearBuiltColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsRoofCoverNull() => this.IsNull(this.tabletblInspectionsData.RoofCoverColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetRoofCoverNull()
    {
      this[this.tabletblInspectionsData.RoofCoverColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsElectricalDateNull()
    {
      return this.IsNull(this.tabletblInspectionsData.ElectricalDateColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetElectricalDateNull()
    {
      this[this.tabletblInspectionsData.ElectricalDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsRoofDateNull() => this.IsNull(this.tabletblInspectionsData.RoofDateColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetRoofDateNull()
    {
      this[this.tabletblInspectionsData.RoofDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsHeatingDateNull() => this.IsNull(this.tabletblInspectionsData.HeatingDateColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetHeatingDateNull()
    {
      this[this.tabletblInspectionsData.HeatingDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsPlumbingDateNull()
    {
      return this.IsNull(this.tabletblInspectionsData.PlumbingDateColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetPlumbingDateNull()
    {
      this[this.tabletblInspectionsData.PlumbingDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class tblNetRateInspectionInfoRow : DataRow
  {
    private dsCompareInspect.tblNetRateInspectionInfoDataTable tabletblNetRateInspectionInfo;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblNetRateInspectionInfoRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblNetRateInspectionInfo = (dsCompareInspect.tblNetRateInspectionInfoDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int LocationID
    {
      get => Conversions.ToInteger(this[this.tabletblNetRateInspectionInfo.LocationIDColumn]);
      set => this[this.tabletblNetRateInspectionInfo.LocationIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int PremesisID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblNetRateInspectionInfo.PremesisIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'PremesisID' in table 'tblNetRateInspectionInfo' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblNetRateInspectionInfo.PremesisIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int ExposureID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblNetRateInspectionInfo.ExposureIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ExposureID' in table 'tblNetRateInspectionInfo' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblNetRateInspectionInfo.ExposureIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int QuoteID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblNetRateInspectionInfo.QuoteIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'QuoteID' in table 'tblNetRateInspectionInfo' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblNetRateInspectionInfo.QuoteIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsPremesisIDNull()
    {
      return this.IsNull(this.tabletblNetRateInspectionInfo.PremesisIDColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetPremesisIDNull()
    {
      this[this.tabletblNetRateInspectionInfo.PremesisIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsExposureIDNull()
    {
      return this.IsNull(this.tabletblNetRateInspectionInfo.ExposureIDColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetExposureIDNull()
    {
      this[this.tabletblNetRateInspectionInfo.ExposureIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsQuoteIDNull() => this.IsNull(this.tabletblNetRateInspectionInfo.QuoteIDColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetQuoteIDNull()
    {
      this[this.tabletblNetRateInspectionInfo.QuoteIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class lstConstructionTypesRow : DataRow
  {
    private dsCompareInspect.lstConstructionTypesDataTable tablelstConstructionTypes;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal lstConstructionTypesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablelstConstructionTypes = (dsCompareInspect.lstConstructionTypesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public byte ConstructionTypeID
    {
      get => Conversions.ToByte(this[this.tablelstConstructionTypes.ConstructionTypeIDColumn]);
      set => this[this.tablelstConstructionTypes.ConstructionTypeIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Type
    {
      get => Conversions.ToString(this[this.tablelstConstructionTypes.TypeColumn]);
      set => this[this.tablelstConstructionTypes.TypeColumn] = (object) value;
    }
  }

  public class tblUnderwritingLocationsRow : DataRow
  {
    private dsCompareInspect.tblUnderwritingLocationsDataTable tabletblUnderwritingLocations;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblUnderwritingLocationsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblUnderwritingLocations = (dsCompareInspect.tblUnderwritingLocationsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int LocationID
    {
      get => Conversions.ToInteger(this[this.tabletblUnderwritingLocations.LocationIDColumn]);
      set => this[this.tabletblUnderwritingLocations.LocationIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string RoofingYear
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblUnderwritingLocations.RoofingYearColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'RoofingYear' in table 'tblUnderwritingLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblUnderwritingLocations.RoofingYearColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Stories
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblUnderwritingLocations.StoriesColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Stories' in table 'tblUnderwritingLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblUnderwritingLocations.StoriesColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsRoofingYearNull()
    {
      return this.IsNull(this.tabletblUnderwritingLocations.RoofingYearColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetRoofingYearNull()
    {
      this[this.tabletblUnderwritingLocations.RoofingYearColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsStoriesNull() => this.IsNull(this.tabletblUnderwritingLocations.StoriesColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetStoriesNull()
    {
      this[this.tabletblUnderwritingLocations.StoriesColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class dtLocationsRowChangeEvent : EventArgs
  {
    private dsCompareInspect.dtLocationsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dtLocationsRowChangeEvent(dsCompareInspect.dtLocationsRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompareInspect.dtLocationsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class tblInspectionsDataRowChangeEvent : EventArgs
  {
    private dsCompareInspect.tblInspectionsDataRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblInspectionsDataRowChangeEvent(
      dsCompareInspect.tblInspectionsDataRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompareInspect.tblInspectionsDataRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class tblNetRateInspectionInfoRowChangeEvent : EventArgs
  {
    private dsCompareInspect.tblNetRateInspectionInfoRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblNetRateInspectionInfoRowChangeEvent(
      dsCompareInspect.tblNetRateInspectionInfoRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompareInspect.tblNetRateInspectionInfoRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class lstConstructionTypesRowChangeEvent : EventArgs
  {
    private dsCompareInspect.lstConstructionTypesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public lstConstructionTypesRowChangeEvent(
      dsCompareInspect.lstConstructionTypesRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompareInspect.lstConstructionTypesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class tblUnderwritingLocationsRowChangeEvent : EventArgs
  {
    private dsCompareInspect.tblUnderwritingLocationsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblUnderwritingLocationsRowChangeEvent(
      dsCompareInspect.tblUnderwritingLocationsRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompareInspect.tblUnderwritingLocationsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }
}
