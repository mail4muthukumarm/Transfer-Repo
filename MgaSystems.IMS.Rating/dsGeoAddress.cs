// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Rating.dsGeoAddress
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
namespace MGASystems.IMS.Policies.Rating;

[DesignerCategory("code")]
[ToolboxItem(true)]
[XmlSchemaProvider("GetTypedDataSetSchema")]
[XmlRoot("dsGeoAddress")]
[HelpKeyword("vs.data.DataSet")]
[Serializable]
public class dsGeoAddress : DataSet
{
  private dsGeoAddress.dtAddressDataTable tabledtAddress;
  private SchemaSerializationMode _schemaSerializationMode;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public dsGeoAddress()
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
  protected dsGeoAddress(SerializationInfo info, StreamingContext context)
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
        if (dataSet.Tables[nameof (dtAddress)] != null)
          base.Tables.Add((DataTable) new dsGeoAddress.dtAddressDataTable(dataSet.Tables[nameof (dtAddress)]));
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
  public dsGeoAddress.dtAddressDataTable dtAddress => this.tabledtAddress;

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
    dsGeoAddress dsGeoAddress = (dsGeoAddress) base.Clone();
    dsGeoAddress.InitVars();
    dsGeoAddress.SchemaSerializationMode = this.SchemaSerializationMode;
    return (DataSet) dsGeoAddress;
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
      if (dataSet.Tables["dtAddress"] != null)
        base.Tables.Add((DataTable) new dsGeoAddress.dtAddressDataTable(dataSet.Tables["dtAddress"]));
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
    this.tabledtAddress = (dsGeoAddress.dtAddressDataTable) base.Tables["dtAddress"];
    if (!initTable || this.tabledtAddress == null)
      return;
    this.tabledtAddress.InitVars();
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private void InitClass()
  {
    this.DataSetName = nameof (dsGeoAddress);
    this.Prefix = "";
    this.Namespace = "http://tempuri.org/dsGeoAddress.xsd";
    this.EnforceConstraints = true;
    this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.tabledtAddress = new dsGeoAddress.dtAddressDataTable();
    base.Tables.Add((DataTable) this.tabledtAddress);
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializedtAddress() => false;

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
    dsGeoAddress dsGeoAddress = new dsGeoAddress();
    XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
    schemaComplexType.Particle = (XmlSchemaParticle) new XmlSchemaSequence()
    {
      Items = {
        (XmlSchemaObject) new XmlSchemaAny()
        {
          Namespace = dsGeoAddress.Namespace
        }
      }
    };
    XmlSchema schemaSerializable = dsGeoAddress.GetSchemaSerializable();
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
  public delegate void dtAddressRowChangeEventHandler(
    object sender,
    dsGeoAddress.dtAddressRowChangeEvent e);

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class dtAddressDataTable : TypedTableBase<dsGeoAddress.dtAddressRow>
  {
    private DataColumn columnState;
    private DataColumn columnCity;
    private DataColumn columnCounty;
    private DataColumn columnZipCode;
    private DataColumn columnIndex;
    private DataColumn columnLongitude;
    private DataColumn columnLatitude;
    private DataColumn columnGeoStatus;
    private DataColumn columnMapURL;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dtAddressDataTable()
    {
      this.TableName = "dtAddress";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal dtAddressDataTable(DataTable table)
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
    protected dtAddressDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn StateColumn => this.columnState;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn CityColumn => this.columnCity;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn CountyColumn => this.columnCounty;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ZipCodeColumn => this.columnZipCode;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn IndexColumn => this.columnIndex;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn LongitudeColumn => this.columnLongitude;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn LatitudeColumn => this.columnLatitude;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn GeoStatusColumn => this.columnGeoStatus;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn MapURLColumn => this.columnMapURL;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsGeoAddress.dtAddressRow this[int index]
    {
      get => (dsGeoAddress.dtAddressRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsGeoAddress.dtAddressRowChangeEventHandler dtAddressRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsGeoAddress.dtAddressRowChangeEventHandler dtAddressRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsGeoAddress.dtAddressRowChangeEventHandler dtAddressRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsGeoAddress.dtAddressRowChangeEventHandler dtAddressRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AdddtAddressRow(dsGeoAddress.dtAddressRow row) => this.Rows.Add((DataRow) row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsGeoAddress.dtAddressRow AdddtAddressRow(
      string State,
      string City,
      string County,
      string ZipCode,
      int Index,
      string Longitude,
      string Latitude,
      string GeoStatus,
      string MapURL)
    {
      dsGeoAddress.dtAddressRow row = (dsGeoAddress.dtAddressRow) this.NewRow();
      object[] objArray = new object[9]
      {
        (object) State,
        (object) City,
        (object) County,
        (object) ZipCode,
        (object) Index,
        (object) Longitude,
        (object) Latitude,
        (object) GeoStatus,
        (object) MapURL
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsGeoAddress.dtAddressRow FindByIndex(int Index)
    {
      return (dsGeoAddress.dtAddressRow) this.Rows.Find(new object[1]
      {
        (object) Index
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsGeoAddress.dtAddressDataTable addressDataTable = (dsGeoAddress.dtAddressDataTable) base.Clone();
      addressDataTable.InitVars();
      return (DataTable) addressDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsGeoAddress.dtAddressDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnState = this.Columns["State"];
      this.columnCity = this.Columns["City"];
      this.columnCounty = this.Columns["County"];
      this.columnZipCode = this.Columns["ZipCode"];
      this.columnIndex = this.Columns["Index"];
      this.columnLongitude = this.Columns["Longitude"];
      this.columnLatitude = this.Columns["Latitude"];
      this.columnGeoStatus = this.Columns["GeoStatus"];
      this.columnMapURL = this.Columns["MapURL"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnState = new DataColumn("State", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnState);
      this.columnCity = new DataColumn("City", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCity);
      this.columnCounty = new DataColumn("County", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCounty);
      this.columnZipCode = new DataColumn("ZipCode", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnZipCode);
      this.columnIndex = new DataColumn("Index", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnIndex);
      this.columnLongitude = new DataColumn("Longitude", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLongitude);
      this.columnLatitude = new DataColumn("Latitude", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLatitude);
      this.columnGeoStatus = new DataColumn("GeoStatus", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnGeoStatus);
      this.columnMapURL = new DataColumn("MapURL", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnMapURL);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsMultiLocalesKey1", new DataColumn[1]
      {
        this.columnIndex
      }, true));
      this.columnCity.AllowDBNull = false;
      this.columnCounty.AllowDBNull = false;
      this.columnIndex.AllowDBNull = false;
      this.columnIndex.Unique = true;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsGeoAddress.dtAddressRow NewdtAddressRow() => (dsGeoAddress.dtAddressRow) this.NewRow();

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsGeoAddress.dtAddressRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (dsGeoAddress.dtAddressRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.dtAddressRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsGeoAddress.dtAddressRowChangeEventHandler addressRowChangedEvent = this.dtAddressRowChangedEvent;
      if (addressRowChangedEvent == null)
        return;
      addressRowChangedEvent((object) this, new dsGeoAddress.dtAddressRowChangeEvent((dsGeoAddress.dtAddressRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.dtAddressRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsGeoAddress.dtAddressRowChangeEventHandler rowChangingEvent = this.dtAddressRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsGeoAddress.dtAddressRowChangeEvent((dsGeoAddress.dtAddressRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.dtAddressRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsGeoAddress.dtAddressRowChangeEventHandler addressRowDeletedEvent = this.dtAddressRowDeletedEvent;
      if (addressRowDeletedEvent == null)
        return;
      addressRowDeletedEvent((object) this, new dsGeoAddress.dtAddressRowChangeEvent((dsGeoAddress.dtAddressRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.dtAddressRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsGeoAddress.dtAddressRowChangeEventHandler rowDeletingEvent = this.dtAddressRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsGeoAddress.dtAddressRowChangeEvent((dsGeoAddress.dtAddressRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemovedtAddressRow(dsGeoAddress.dtAddressRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsGeoAddress dsGeoAddress = new dsGeoAddress();
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
        FixedValue = dsGeoAddress.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (dtAddressDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsGeoAddress.GetSchemaSerializable();
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

  public class dtAddressRow : DataRow
  {
    private dsGeoAddress.dtAddressDataTable tabledtAddress;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal dtAddressRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabledtAddress = (dsGeoAddress.dtAddressDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string State
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtAddress.StateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'State' in table 'dtAddress' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtAddress.StateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string City
    {
      get => Conversions.ToString(this[this.tabledtAddress.CityColumn]);
      set => this[this.tabledtAddress.CityColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string County
    {
      get => Conversions.ToString(this[this.tabledtAddress.CountyColumn]);
      set => this[this.tabledtAddress.CountyColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string ZipCode
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtAddress.ZipCodeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ZipCode' in table 'dtAddress' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtAddress.ZipCodeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int Index
    {
      get => Conversions.ToInteger(this[this.tabledtAddress.IndexColumn]);
      set => this[this.tabledtAddress.IndexColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Longitude
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtAddress.LongitudeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Longitude' in table 'dtAddress' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtAddress.LongitudeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Latitude
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtAddress.LatitudeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Latitude' in table 'dtAddress' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtAddress.LatitudeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string GeoStatus
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtAddress.GeoStatusColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'GeoStatus' in table 'dtAddress' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtAddress.GeoStatusColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string MapURL
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtAddress.MapURLColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'MapURL' in table 'dtAddress' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtAddress.MapURLColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsStateNull() => this.IsNull(this.tabledtAddress.StateColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetStateNull()
    {
      this[this.tabledtAddress.StateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsZipCodeNull() => this.IsNull(this.tabledtAddress.ZipCodeColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetZipCodeNull()
    {
      this[this.tabledtAddress.ZipCodeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsLongitudeNull() => this.IsNull(this.tabledtAddress.LongitudeColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetLongitudeNull()
    {
      this[this.tabledtAddress.LongitudeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsLatitudeNull() => this.IsNull(this.tabledtAddress.LatitudeColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetLatitudeNull()
    {
      this[this.tabledtAddress.LatitudeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsGeoStatusNull() => this.IsNull(this.tabledtAddress.GeoStatusColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetGeoStatusNull()
    {
      this[this.tabledtAddress.GeoStatusColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsMapURLNull() => this.IsNull(this.tabledtAddress.MapURLColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetMapURLNull()
    {
      this[this.tabledtAddress.MapURLColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class dtAddressRowChangeEvent : EventArgs
  {
    private dsGeoAddress.dtAddressRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dtAddressRowChangeEvent(dsGeoAddress.dtAddressRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsGeoAddress.dtAddressRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }
}
