// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Rating.ExposureCapture.dsPropertyExposureCapture
// Assembly: MgaSystems.IMS.Rating, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 370B8F0A-FA1A-41D0-87BD-563CC23E9EA7
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Rating.dll

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
namespace MGASystems.IMS.Policies.Rating.ExposureCapture;

[DesignerCategory("code")]
[ToolboxItem(true)]
[XmlSchemaProvider("GetTypedDataSetSchema")]
[XmlRoot("dsPropertyExposureCapture")]
[HelpKeyword("vs.data.DataSet")]
[Serializable]
public class dsPropertyExposureCapture : DataSet
{
  private dsPropertyExposureCapture.tblUnderwritingLocationsDataTable tabletblUnderwritingLocations;
  private dsPropertyExposureCapture.tblGenericPropertyExposuresDataTable tabletblGenericPropertyExposures;
  private dsPropertyExposureCapture.lstPropRater_CoverageTypesDataTable tablelstPropRater_CoverageTypes;
  private DataRelation relationlstPropRater_CoverageTypestblGenericPropertyExposures;
  private DataRelation relationtblGenericPropertyExposures_tblUnderwritingLocations;
  private SchemaSerializationMode _schemaSerializationMode;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public dsPropertyExposureCapture()
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
  protected dsPropertyExposureCapture(SerializationInfo info, StreamingContext context)
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
        if (dataSet.Tables[nameof (tblUnderwritingLocations)] != null)
          base.Tables.Add((DataTable) new dsPropertyExposureCapture.tblUnderwritingLocationsDataTable(dataSet.Tables[nameof (tblUnderwritingLocations)]));
        if (dataSet.Tables[nameof (tblGenericPropertyExposures)] != null)
          base.Tables.Add((DataTable) new dsPropertyExposureCapture.tblGenericPropertyExposuresDataTable(dataSet.Tables[nameof (tblGenericPropertyExposures)]));
        if (dataSet.Tables[nameof (lstPropRater_CoverageTypes)] != null)
          base.Tables.Add((DataTable) new dsPropertyExposureCapture.lstPropRater_CoverageTypesDataTable(dataSet.Tables[nameof (lstPropRater_CoverageTypes)]));
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
  public dsPropertyExposureCapture.tblUnderwritingLocationsDataTable tblUnderwritingLocations
  {
    get => this.tabletblUnderwritingLocations;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsPropertyExposureCapture.tblGenericPropertyExposuresDataTable tblGenericPropertyExposures
  {
    get => this.tabletblGenericPropertyExposures;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsPropertyExposureCapture.lstPropRater_CoverageTypesDataTable lstPropRater_CoverageTypes
  {
    get => this.tablelstPropRater_CoverageTypes;
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
    dsPropertyExposureCapture propertyExposureCapture = (dsPropertyExposureCapture) base.Clone();
    propertyExposureCapture.InitVars();
    propertyExposureCapture.SchemaSerializationMode = this.SchemaSerializationMode;
    return (DataSet) propertyExposureCapture;
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
      if (dataSet.Tables["tblUnderwritingLocations"] != null)
        base.Tables.Add((DataTable) new dsPropertyExposureCapture.tblUnderwritingLocationsDataTable(dataSet.Tables["tblUnderwritingLocations"]));
      if (dataSet.Tables["tblGenericPropertyExposures"] != null)
        base.Tables.Add((DataTable) new dsPropertyExposureCapture.tblGenericPropertyExposuresDataTable(dataSet.Tables["tblGenericPropertyExposures"]));
      if (dataSet.Tables["lstPropRater_CoverageTypes"] != null)
        base.Tables.Add((DataTable) new dsPropertyExposureCapture.lstPropRater_CoverageTypesDataTable(dataSet.Tables["lstPropRater_CoverageTypes"]));
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
    this.tabletblUnderwritingLocations = (dsPropertyExposureCapture.tblUnderwritingLocationsDataTable) base.Tables["tblUnderwritingLocations"];
    if (initTable && this.tabletblUnderwritingLocations != null)
      this.tabletblUnderwritingLocations.InitVars();
    this.tabletblGenericPropertyExposures = (dsPropertyExposureCapture.tblGenericPropertyExposuresDataTable) base.Tables["tblGenericPropertyExposures"];
    if (initTable && this.tabletblGenericPropertyExposures != null)
      this.tabletblGenericPropertyExposures.InitVars();
    this.tablelstPropRater_CoverageTypes = (dsPropertyExposureCapture.lstPropRater_CoverageTypesDataTable) base.Tables["lstPropRater_CoverageTypes"];
    if (initTable && this.tablelstPropRater_CoverageTypes != null)
      this.tablelstPropRater_CoverageTypes.InitVars();
    this.relationlstPropRater_CoverageTypestblGenericPropertyExposures = this.Relations["lstPropRater_CoverageTypestblGenericPropertyExposures"];
    this.relationtblGenericPropertyExposures_tblUnderwritingLocations = this.Relations["tblGenericPropertyExposures_tblUnderwritingLocations"];
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private void InitClass()
  {
    this.DataSetName = nameof (dsPropertyExposureCapture);
    this.Prefix = "";
    this.Namespace = "http://www.tempuri.org/dsPropertyExposureCapture.xsd";
    this.EnforceConstraints = true;
    this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.tabletblUnderwritingLocations = new dsPropertyExposureCapture.tblUnderwritingLocationsDataTable();
    base.Tables.Add((DataTable) this.tabletblUnderwritingLocations);
    this.tabletblGenericPropertyExposures = new dsPropertyExposureCapture.tblGenericPropertyExposuresDataTable();
    base.Tables.Add((DataTable) this.tabletblGenericPropertyExposures);
    this.tablelstPropRater_CoverageTypes = new dsPropertyExposureCapture.lstPropRater_CoverageTypesDataTable();
    base.Tables.Add((DataTable) this.tablelstPropRater_CoverageTypes);
    ForeignKeyConstraint foreignKeyConstraint = new ForeignKeyConstraint("lstPropRater_CoverageTypestblGenericPropertyExposures", new DataColumn[1]
    {
      this.tablelstPropRater_CoverageTypes.IDColumn
    }, new DataColumn[1]
    {
      this.tabletblGenericPropertyExposures.CoverageIDColumn
    });
    this.tabletblGenericPropertyExposures.Constraints.Add((Constraint) foreignKeyConstraint);
    foreignKeyConstraint.AcceptRejectRule = AcceptRejectRule.None;
    foreignKeyConstraint.DeleteRule = Rule.Cascade;
    foreignKeyConstraint.UpdateRule = Rule.Cascade;
    this.relationlstPropRater_CoverageTypestblGenericPropertyExposures = new DataRelation("lstPropRater_CoverageTypestblGenericPropertyExposures", new DataColumn[1]
    {
      this.tablelstPropRater_CoverageTypes.IDColumn
    }, new DataColumn[1]
    {
      this.tabletblGenericPropertyExposures.CoverageIDColumn
    }, false);
    this.Relations.Add(this.relationlstPropRater_CoverageTypestblGenericPropertyExposures);
    this.relationtblGenericPropertyExposures_tblUnderwritingLocations = new DataRelation("tblGenericPropertyExposures_tblUnderwritingLocations", new DataColumn[1]
    {
      this.tabletblUnderwritingLocations.LocationIDColumn
    }, new DataColumn[1]
    {
      this.tabletblGenericPropertyExposures.LocationIDColumn
    }, false);
    this.Relations.Add(this.relationtblGenericPropertyExposures_tblUnderwritingLocations);
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializetblUnderwritingLocations() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializetblGenericPropertyExposures() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializelstPropRater_CoverageTypes() => false;

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
    dsPropertyExposureCapture propertyExposureCapture = new dsPropertyExposureCapture();
    XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
    schemaComplexType.Particle = (XmlSchemaParticle) new XmlSchemaSequence()
    {
      Items = {
        (XmlSchemaObject) new XmlSchemaAny()
        {
          Namespace = propertyExposureCapture.Namespace
        }
      }
    };
    XmlSchema schemaSerializable = propertyExposureCapture.GetSchemaSerializable();
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
  public delegate void tblUnderwritingLocationsRowChangeEventHandler(
    object sender,
    dsPropertyExposureCapture.tblUnderwritingLocationsRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void tblGenericPropertyExposuresRowChangeEventHandler(
    object sender,
    dsPropertyExposureCapture.tblGenericPropertyExposuresRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void lstPropRater_CoverageTypesRowChangeEventHandler(
    object sender,
    dsPropertyExposureCapture.lstPropRater_CoverageTypesRowChangeEvent e);

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class tblUnderwritingLocationsDataTable : 
    TypedTableBase<dsPropertyExposureCapture.tblUnderwritingLocationsRow>
  {
    private DataColumn columnLocationID;
    private DataColumn columnLocationNo;
    private DataColumn columnBuildingNo;
    private DataColumn columnPhysicalBuildingNo;
    private DataColumn columnAddress;
    private DataColumn columnCity;
    private DataColumn columnState;
    private DataColumn columnZip;

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
    public DataColumn LocationNoColumn => this.columnLocationNo;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn BuildingNoColumn => this.columnBuildingNo;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn PhysicalBuildingNoColumn => this.columnPhysicalBuildingNo;

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
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsPropertyExposureCapture.tblUnderwritingLocationsRow this[int index]
    {
      get => (dsPropertyExposureCapture.tblUnderwritingLocationsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsPropertyExposureCapture.tblUnderwritingLocationsRowChangeEventHandler tblUnderwritingLocationsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsPropertyExposureCapture.tblUnderwritingLocationsRowChangeEventHandler tblUnderwritingLocationsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsPropertyExposureCapture.tblUnderwritingLocationsRowChangeEventHandler tblUnderwritingLocationsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsPropertyExposureCapture.tblUnderwritingLocationsRowChangeEventHandler tblUnderwritingLocationsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddtblUnderwritingLocationsRow(
      dsPropertyExposureCapture.tblUnderwritingLocationsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsPropertyExposureCapture.tblUnderwritingLocationsRow AddtblUnderwritingLocationsRow(
      int LocationNo,
      string BuildingNo,
      string PhysicalBuildingNo,
      string Address,
      string City,
      string State,
      string Zip)
    {
      dsPropertyExposureCapture.tblUnderwritingLocationsRow row = (dsPropertyExposureCapture.tblUnderwritingLocationsRow) this.NewRow();
      object[] objArray = new object[8]
      {
        null,
        (object) LocationNo,
        (object) BuildingNo,
        (object) PhysicalBuildingNo,
        (object) Address,
        (object) City,
        (object) State,
        (object) Zip
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsPropertyExposureCapture.tblUnderwritingLocationsRow FindByLocationID(int LocationID)
    {
      return (dsPropertyExposureCapture.tblUnderwritingLocationsRow) this.Rows.Find(new object[1]
      {
        (object) LocationID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsPropertyExposureCapture.tblUnderwritingLocationsDataTable locationsDataTable = (dsPropertyExposureCapture.tblUnderwritingLocationsDataTable) base.Clone();
      locationsDataTable.InitVars();
      return (DataTable) locationsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsPropertyExposureCapture.tblUnderwritingLocationsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnLocationID = this.Columns["LocationID"];
      this.columnLocationNo = this.Columns["LocationNo"];
      this.columnBuildingNo = this.Columns["BuildingNo"];
      this.columnPhysicalBuildingNo = this.Columns["PhysicalBuildingNo"];
      this.columnAddress = this.Columns["Address"];
      this.columnCity = this.Columns["City"];
      this.columnState = this.Columns["State"];
      this.columnZip = this.Columns["Zip"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnLocationID = new DataColumn("LocationID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLocationID);
      this.columnLocationNo = new DataColumn("LocationNo", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLocationNo);
      this.columnBuildingNo = new DataColumn("BuildingNo", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnBuildingNo);
      this.columnPhysicalBuildingNo = new DataColumn("PhysicalBuildingNo", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPhysicalBuildingNo);
      this.columnAddress = new DataColumn("Address", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAddress);
      this.columnCity = new DataColumn("City", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCity);
      this.columnState = new DataColumn("State", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnState);
      this.columnZip = new DataColumn("Zip", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnZip);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsGLExposureCaptureKey1", new DataColumn[1]
      {
        this.columnLocationID
      }, true));
      this.columnLocationID.AutoIncrement = true;
      this.columnLocationID.AllowDBNull = false;
      this.columnLocationID.ReadOnly = true;
      this.columnLocationID.Unique = true;
      this.columnLocationNo.AllowDBNull = false;
      this.columnPhysicalBuildingNo.AllowDBNull = false;
      this.columnAddress.ReadOnly = true;
      this.columnCity.AllowDBNull = false;
      this.columnState.AllowDBNull = false;
      this.columnZip.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsPropertyExposureCapture.tblUnderwritingLocationsRow NewtblUnderwritingLocationsRow()
    {
      return (dsPropertyExposureCapture.tblUnderwritingLocationsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsPropertyExposureCapture.tblUnderwritingLocationsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType()
    {
      return typeof (dsPropertyExposureCapture.tblUnderwritingLocationsRow);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblUnderwritingLocationsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPropertyExposureCapture.tblUnderwritingLocationsRowChangeEventHandler locationsRowChangedEvent = this.tblUnderwritingLocationsRowChangedEvent;
      if (locationsRowChangedEvent == null)
        return;
      locationsRowChangedEvent((object) this, new dsPropertyExposureCapture.tblUnderwritingLocationsRowChangeEvent((dsPropertyExposureCapture.tblUnderwritingLocationsRow) e.Row, e.Action));
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
      dsPropertyExposureCapture.tblUnderwritingLocationsRowChangeEventHandler rowChangingEvent = this.tblUnderwritingLocationsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsPropertyExposureCapture.tblUnderwritingLocationsRowChangeEvent((dsPropertyExposureCapture.tblUnderwritingLocationsRow) e.Row, e.Action));
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
      dsPropertyExposureCapture.tblUnderwritingLocationsRowChangeEventHandler locationsRowDeletedEvent = this.tblUnderwritingLocationsRowDeletedEvent;
      if (locationsRowDeletedEvent == null)
        return;
      locationsRowDeletedEvent((object) this, new dsPropertyExposureCapture.tblUnderwritingLocationsRowChangeEvent((dsPropertyExposureCapture.tblUnderwritingLocationsRow) e.Row, e.Action));
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
      dsPropertyExposureCapture.tblUnderwritingLocationsRowChangeEventHandler rowDeletingEvent = this.tblUnderwritingLocationsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsPropertyExposureCapture.tblUnderwritingLocationsRowChangeEvent((dsPropertyExposureCapture.tblUnderwritingLocationsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemovetblUnderwritingLocationsRow(
      dsPropertyExposureCapture.tblUnderwritingLocationsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsPropertyExposureCapture propertyExposureCapture = new dsPropertyExposureCapture();
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
        FixedValue = propertyExposureCapture.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblUnderwritingLocationsDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = propertyExposureCapture.GetSchemaSerializable();
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
  public class tblGenericPropertyExposuresDataTable : 
    TypedTableBase<dsPropertyExposureCapture.tblGenericPropertyExposuresRow>
  {
    private DataColumn columnExposureID;
    private DataColumn columnLocationID;
    private DataColumn columnCoverageID;
    private DataColumn columnLimit;
    private DataColumn columnDeductible;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblGenericPropertyExposuresDataTable()
    {
      this.TableName = "tblGenericPropertyExposures";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblGenericPropertyExposuresDataTable(DataTable table)
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
    protected tblGenericPropertyExposuresDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ExposureIDColumn => this.columnExposureID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn LocationIDColumn => this.columnLocationID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn CoverageIDColumn => this.columnCoverageID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn LimitColumn => this.columnLimit;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn DeductibleColumn => this.columnDeductible;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsPropertyExposureCapture.tblGenericPropertyExposuresRow this[int index]
    {
      get => (dsPropertyExposureCapture.tblGenericPropertyExposuresRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsPropertyExposureCapture.tblGenericPropertyExposuresRowChangeEventHandler tblGenericPropertyExposuresRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsPropertyExposureCapture.tblGenericPropertyExposuresRowChangeEventHandler tblGenericPropertyExposuresRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsPropertyExposureCapture.tblGenericPropertyExposuresRowChangeEventHandler tblGenericPropertyExposuresRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsPropertyExposureCapture.tblGenericPropertyExposuresRowChangeEventHandler tblGenericPropertyExposuresRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddtblGenericPropertyExposuresRow(
      dsPropertyExposureCapture.tblGenericPropertyExposuresRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsPropertyExposureCapture.tblGenericPropertyExposuresRow AddtblGenericPropertyExposuresRow(
      dsPropertyExposureCapture.tblUnderwritingLocationsRow parenttblUnderwritingLocationsRowBytblGenericPropertyExposures_tblUnderwritingLocations,
      dsPropertyExposureCapture.lstPropRater_CoverageTypesRow parentlstPropRater_CoverageTypesRowBylstPropRater_CoverageTypestblGenericPropertyExposures,
      int Limit,
      string Deductible)
    {
      dsPropertyExposureCapture.tblGenericPropertyExposuresRow row = (dsPropertyExposureCapture.tblGenericPropertyExposuresRow) this.NewRow();
      object[] objArray = new object[5]
      {
        null,
        null,
        null,
        (object) Limit,
        (object) Deductible
      };
      if (parenttblUnderwritingLocationsRowBytblGenericPropertyExposures_tblUnderwritingLocations != null)
        objArray[1] = RuntimeHelpers.GetObjectValue(parenttblUnderwritingLocationsRowBytblGenericPropertyExposures_tblUnderwritingLocations[0]);
      if (parentlstPropRater_CoverageTypesRowBylstPropRater_CoverageTypestblGenericPropertyExposures != null)
        objArray[2] = RuntimeHelpers.GetObjectValue(parentlstPropRater_CoverageTypesRowBylstPropRater_CoverageTypestblGenericPropertyExposures[0]);
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsPropertyExposureCapture.tblGenericPropertyExposuresRow FindByExposureID(int ExposureID)
    {
      return (dsPropertyExposureCapture.tblGenericPropertyExposuresRow) this.Rows.Find(new object[1]
      {
        (object) ExposureID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsPropertyExposureCapture.tblGenericPropertyExposuresDataTable exposuresDataTable = (dsPropertyExposureCapture.tblGenericPropertyExposuresDataTable) base.Clone();
      exposuresDataTable.InitVars();
      return (DataTable) exposuresDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsPropertyExposureCapture.tblGenericPropertyExposuresDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnExposureID = this.Columns["ExposureID"];
      this.columnLocationID = this.Columns["LocationID"];
      this.columnCoverageID = this.Columns["CoverageID"];
      this.columnLimit = this.Columns["Limit"];
      this.columnDeductible = this.Columns["Deductible"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnExposureID = new DataColumn("ExposureID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnExposureID);
      this.columnLocationID = new DataColumn("LocationID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLocationID);
      this.columnCoverageID = new DataColumn("CoverageID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCoverageID);
      this.columnLimit = new DataColumn("Limit", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLimit);
      this.columnDeductible = new DataColumn("Deductible", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDeductible);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsGLExposureCaptureKey2", new DataColumn[1]
      {
        this.columnExposureID
      }, true));
      this.columnExposureID.AutoIncrement = true;
      this.columnExposureID.AutoIncrementSeed = -1L;
      this.columnExposureID.AutoIncrementStep = -1L;
      this.columnExposureID.AllowDBNull = false;
      this.columnExposureID.ReadOnly = true;
      this.columnExposureID.Unique = true;
      this.columnLocationID.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsPropertyExposureCapture.tblGenericPropertyExposuresRow NewtblGenericPropertyExposuresRow()
    {
      return (dsPropertyExposureCapture.tblGenericPropertyExposuresRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsPropertyExposureCapture.tblGenericPropertyExposuresRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType()
    {
      return typeof (dsPropertyExposureCapture.tblGenericPropertyExposuresRow);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblGenericPropertyExposuresRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPropertyExposureCapture.tblGenericPropertyExposuresRowChangeEventHandler exposuresRowChangedEvent = this.tblGenericPropertyExposuresRowChangedEvent;
      if (exposuresRowChangedEvent == null)
        return;
      exposuresRowChangedEvent((object) this, new dsPropertyExposureCapture.tblGenericPropertyExposuresRowChangeEvent((dsPropertyExposureCapture.tblGenericPropertyExposuresRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblGenericPropertyExposuresRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPropertyExposureCapture.tblGenericPropertyExposuresRowChangeEventHandler rowChangingEvent = this.tblGenericPropertyExposuresRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsPropertyExposureCapture.tblGenericPropertyExposuresRowChangeEvent((dsPropertyExposureCapture.tblGenericPropertyExposuresRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblGenericPropertyExposuresRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPropertyExposureCapture.tblGenericPropertyExposuresRowChangeEventHandler exposuresRowDeletedEvent = this.tblGenericPropertyExposuresRowDeletedEvent;
      if (exposuresRowDeletedEvent == null)
        return;
      exposuresRowDeletedEvent((object) this, new dsPropertyExposureCapture.tblGenericPropertyExposuresRowChangeEvent((dsPropertyExposureCapture.tblGenericPropertyExposuresRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblGenericPropertyExposuresRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPropertyExposureCapture.tblGenericPropertyExposuresRowChangeEventHandler rowDeletingEvent = this.tblGenericPropertyExposuresRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsPropertyExposureCapture.tblGenericPropertyExposuresRowChangeEvent((dsPropertyExposureCapture.tblGenericPropertyExposuresRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemovetblGenericPropertyExposuresRow(
      dsPropertyExposureCapture.tblGenericPropertyExposuresRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsPropertyExposureCapture propertyExposureCapture = new dsPropertyExposureCapture();
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
        FixedValue = propertyExposureCapture.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblGenericPropertyExposuresDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = propertyExposureCapture.GetSchemaSerializable();
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
  public class lstPropRater_CoverageTypesDataTable : 
    TypedTableBase<dsPropertyExposureCapture.lstPropRater_CoverageTypesRow>
  {
    private DataColumn columnID;
    private DataColumn columnCoverage;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public lstPropRater_CoverageTypesDataTable()
    {
      this.TableName = "lstPropRater_CoverageTypes";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal lstPropRater_CoverageTypesDataTable(DataTable table)
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
    protected lstPropRater_CoverageTypesDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn IDColumn => this.columnID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn CoverageColumn => this.columnCoverage;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsPropertyExposureCapture.lstPropRater_CoverageTypesRow this[int index]
    {
      get => (dsPropertyExposureCapture.lstPropRater_CoverageTypesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsPropertyExposureCapture.lstPropRater_CoverageTypesRowChangeEventHandler lstPropRater_CoverageTypesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsPropertyExposureCapture.lstPropRater_CoverageTypesRowChangeEventHandler lstPropRater_CoverageTypesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsPropertyExposureCapture.lstPropRater_CoverageTypesRowChangeEventHandler lstPropRater_CoverageTypesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsPropertyExposureCapture.lstPropRater_CoverageTypesRowChangeEventHandler lstPropRater_CoverageTypesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddlstPropRater_CoverageTypesRow(
      dsPropertyExposureCapture.lstPropRater_CoverageTypesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsPropertyExposureCapture.lstPropRater_CoverageTypesRow AddlstPropRater_CoverageTypesRow(
      int ID,
      string Coverage)
    {
      dsPropertyExposureCapture.lstPropRater_CoverageTypesRow row = (dsPropertyExposureCapture.lstPropRater_CoverageTypesRow) this.NewRow();
      object[] objArray = new object[2]
      {
        (object) ID,
        (object) Coverage
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsPropertyExposureCapture.lstPropRater_CoverageTypesRow FindByID(int ID)
    {
      return (dsPropertyExposureCapture.lstPropRater_CoverageTypesRow) this.Rows.Find(new object[1]
      {
        (object) ID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsPropertyExposureCapture.lstPropRater_CoverageTypesDataTable coverageTypesDataTable = (dsPropertyExposureCapture.lstPropRater_CoverageTypesDataTable) base.Clone();
      coverageTypesDataTable.InitVars();
      return (DataTable) coverageTypesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsPropertyExposureCapture.lstPropRater_CoverageTypesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnID = this.Columns["ID"];
      this.columnCoverage = this.Columns["Coverage"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnID = new DataColumn("ID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnID);
      this.columnCoverage = new DataColumn("Coverage", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCoverage);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsPropertyExposureCaptureKey1", new DataColumn[1]
      {
        this.columnID
      }, true));
      this.columnID.AllowDBNull = false;
      this.columnID.ReadOnly = true;
      this.columnID.Unique = true;
      this.columnCoverage.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsPropertyExposureCapture.lstPropRater_CoverageTypesRow NewlstPropRater_CoverageTypesRow()
    {
      return (dsPropertyExposureCapture.lstPropRater_CoverageTypesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsPropertyExposureCapture.lstPropRater_CoverageTypesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType()
    {
      return typeof (dsPropertyExposureCapture.lstPropRater_CoverageTypesRow);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstPropRater_CoverageTypesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPropertyExposureCapture.lstPropRater_CoverageTypesRowChangeEventHandler typesRowChangedEvent = this.lstPropRater_CoverageTypesRowChangedEvent;
      if (typesRowChangedEvent == null)
        return;
      typesRowChangedEvent((object) this, new dsPropertyExposureCapture.lstPropRater_CoverageTypesRowChangeEvent((dsPropertyExposureCapture.lstPropRater_CoverageTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstPropRater_CoverageTypesRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPropertyExposureCapture.lstPropRater_CoverageTypesRowChangeEventHandler rowChangingEvent = this.lstPropRater_CoverageTypesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsPropertyExposureCapture.lstPropRater_CoverageTypesRowChangeEvent((dsPropertyExposureCapture.lstPropRater_CoverageTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstPropRater_CoverageTypesRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPropertyExposureCapture.lstPropRater_CoverageTypesRowChangeEventHandler typesRowDeletedEvent = this.lstPropRater_CoverageTypesRowDeletedEvent;
      if (typesRowDeletedEvent == null)
        return;
      typesRowDeletedEvent((object) this, new dsPropertyExposureCapture.lstPropRater_CoverageTypesRowChangeEvent((dsPropertyExposureCapture.lstPropRater_CoverageTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstPropRater_CoverageTypesRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPropertyExposureCapture.lstPropRater_CoverageTypesRowChangeEventHandler rowDeletingEvent = this.lstPropRater_CoverageTypesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsPropertyExposureCapture.lstPropRater_CoverageTypesRowChangeEvent((dsPropertyExposureCapture.lstPropRater_CoverageTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemovelstPropRater_CoverageTypesRow(
      dsPropertyExposureCapture.lstPropRater_CoverageTypesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsPropertyExposureCapture propertyExposureCapture = new dsPropertyExposureCapture();
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
        FixedValue = propertyExposureCapture.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (lstPropRater_CoverageTypesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = propertyExposureCapture.GetSchemaSerializable();
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

  public class tblUnderwritingLocationsRow : DataRow
  {
    private dsPropertyExposureCapture.tblUnderwritingLocationsDataTable tabletblUnderwritingLocations;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblUnderwritingLocationsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblUnderwritingLocations = (dsPropertyExposureCapture.tblUnderwritingLocationsDataTable) this.Table;
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
    public int LocationNo
    {
      get => Conversions.ToInteger(this[this.tabletblUnderwritingLocations.LocationNoColumn]);
      set => this[this.tabletblUnderwritingLocations.LocationNoColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string BuildingNo
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblUnderwritingLocations.BuildingNoColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'BuildingNo' in table 'tblUnderwritingLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblUnderwritingLocations.BuildingNoColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string PhysicalBuildingNo
    {
      get
      {
        return Conversions.ToString(this[this.tabletblUnderwritingLocations.PhysicalBuildingNoColumn]);
      }
      set => this[this.tabletblUnderwritingLocations.PhysicalBuildingNoColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Address
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblUnderwritingLocations.AddressColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Address' in table 'tblUnderwritingLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblUnderwritingLocations.AddressColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string City
    {
      get => Conversions.ToString(this[this.tabletblUnderwritingLocations.CityColumn]);
      set => this[this.tabletblUnderwritingLocations.CityColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string State
    {
      get => Conversions.ToString(this[this.tabletblUnderwritingLocations.StateColumn]);
      set => this[this.tabletblUnderwritingLocations.StateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Zip
    {
      get => Conversions.ToString(this[this.tabletblUnderwritingLocations.ZipColumn]);
      set => this[this.tabletblUnderwritingLocations.ZipColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsBuildingNoNull()
    {
      return this.IsNull(this.tabletblUnderwritingLocations.BuildingNoColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetBuildingNoNull()
    {
      this[this.tabletblUnderwritingLocations.BuildingNoColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsAddressNull() => this.IsNull(this.tabletblUnderwritingLocations.AddressColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetAddressNull()
    {
      this[this.tabletblUnderwritingLocations.AddressColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsPropertyExposureCapture.tblGenericPropertyExposuresRow[] GettblGenericPropertyExposuresRows()
    {
      return this.Table.ChildRelations["tblGenericPropertyExposures_tblUnderwritingLocations"] != null ? (dsPropertyExposureCapture.tblGenericPropertyExposuresRow[]) this.GetChildRows(this.Table.ChildRelations["tblGenericPropertyExposures_tblUnderwritingLocations"]) : new dsPropertyExposureCapture.tblGenericPropertyExposuresRow[0];
    }
  }

  public class tblGenericPropertyExposuresRow : DataRow
  {
    private dsPropertyExposureCapture.tblGenericPropertyExposuresDataTable tabletblGenericPropertyExposures;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblGenericPropertyExposuresRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblGenericPropertyExposures = (dsPropertyExposureCapture.tblGenericPropertyExposuresDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int ExposureID
    {
      get => Conversions.ToInteger(this[this.tabletblGenericPropertyExposures.ExposureIDColumn]);
      set => this[this.tabletblGenericPropertyExposures.ExposureIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int LocationID
    {
      get => Conversions.ToInteger(this[this.tabletblGenericPropertyExposures.LocationIDColumn]);
      set => this[this.tabletblGenericPropertyExposures.LocationIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int CoverageID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblGenericPropertyExposures.CoverageIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'CoverageID' in table 'tblGenericPropertyExposures' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblGenericPropertyExposures.CoverageIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int Limit
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblGenericPropertyExposures.LimitColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Limit' in table 'tblGenericPropertyExposures' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblGenericPropertyExposures.LimitColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Deductible
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblGenericPropertyExposures.DeductibleColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Deductible' in table 'tblGenericPropertyExposures' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblGenericPropertyExposures.DeductibleColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsPropertyExposureCapture.lstPropRater_CoverageTypesRow lstPropRater_CoverageTypesRow
    {
      get
      {
        return (dsPropertyExposureCapture.lstPropRater_CoverageTypesRow) this.GetParentRow(this.Table.ParentRelations["lstPropRater_CoverageTypestblGenericPropertyExposures"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["lstPropRater_CoverageTypestblGenericPropertyExposures"]);
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsPropertyExposureCapture.tblUnderwritingLocationsRow tblUnderwritingLocationsRow
    {
      get
      {
        return (dsPropertyExposureCapture.tblUnderwritingLocationsRow) this.GetParentRow(this.Table.ParentRelations["tblGenericPropertyExposures_tblUnderwritingLocations"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["tblGenericPropertyExposures_tblUnderwritingLocations"]);
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsCoverageIDNull()
    {
      return this.IsNull(this.tabletblGenericPropertyExposures.CoverageIDColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetCoverageIDNull()
    {
      this[this.tabletblGenericPropertyExposures.CoverageIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsLimitNull() => this.IsNull(this.tabletblGenericPropertyExposures.LimitColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetLimitNull()
    {
      this[this.tabletblGenericPropertyExposures.LimitColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsDeductibleNull()
    {
      return this.IsNull(this.tabletblGenericPropertyExposures.DeductibleColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetDeductibleNull()
    {
      this[this.tabletblGenericPropertyExposures.DeductibleColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class lstPropRater_CoverageTypesRow : DataRow
  {
    private dsPropertyExposureCapture.lstPropRater_CoverageTypesDataTable tablelstPropRater_CoverageTypes;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal lstPropRater_CoverageTypesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablelstPropRater_CoverageTypes = (dsPropertyExposureCapture.lstPropRater_CoverageTypesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int ID
    {
      get => Conversions.ToInteger(this[this.tablelstPropRater_CoverageTypes.IDColumn]);
      set => this[this.tablelstPropRater_CoverageTypes.IDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Coverage
    {
      get => Conversions.ToString(this[this.tablelstPropRater_CoverageTypes.CoverageColumn]);
      set => this[this.tablelstPropRater_CoverageTypes.CoverageColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsPropertyExposureCapture.tblGenericPropertyExposuresRow[] GettblGenericPropertyExposuresRows()
    {
      return this.Table.ChildRelations["lstPropRater_CoverageTypestblGenericPropertyExposures"] != null ? (dsPropertyExposureCapture.tblGenericPropertyExposuresRow[]) this.GetChildRows(this.Table.ChildRelations["lstPropRater_CoverageTypestblGenericPropertyExposures"]) : new dsPropertyExposureCapture.tblGenericPropertyExposuresRow[0];
    }
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class tblUnderwritingLocationsRowChangeEvent : EventArgs
  {
    private dsPropertyExposureCapture.tblUnderwritingLocationsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblUnderwritingLocationsRowChangeEvent(
      dsPropertyExposureCapture.tblUnderwritingLocationsRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsPropertyExposureCapture.tblUnderwritingLocationsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class tblGenericPropertyExposuresRowChangeEvent : EventArgs
  {
    private dsPropertyExposureCapture.tblGenericPropertyExposuresRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblGenericPropertyExposuresRowChangeEvent(
      dsPropertyExposureCapture.tblGenericPropertyExposuresRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsPropertyExposureCapture.tblGenericPropertyExposuresRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class lstPropRater_CoverageTypesRowChangeEvent : EventArgs
  {
    private dsPropertyExposureCapture.lstPropRater_CoverageTypesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public lstPropRater_CoverageTypesRowChangeEvent(
      dsPropertyExposureCapture.lstPropRater_CoverageTypesRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsPropertyExposureCapture.lstPropRater_CoverageTypesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }
}
