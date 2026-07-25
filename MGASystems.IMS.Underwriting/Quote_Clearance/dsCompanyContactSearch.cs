// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Underwriting.Quote_Clearance.dsCompanyContactSearch
// Assembly: MGASystems.IMS.Underwriting, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 1057C5B8-8299-4767-8242-AF9F1EF932DB
// Assembly location: D:\augusta\fortegra\IMS Project\MGASystems.IMS.Underwriting.dll

using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

#nullable disable
namespace MGASystems.IMS.Underwriting.Quote_Clearance;

[DesignerCategory("code")]
[ToolboxItem(true)]
[XmlSchemaProvider("GetTypedDataSetSchema")]
[XmlRoot("dsCompanyContactSearch")]
[HelpKeyword("vs.data.DataSet")]
[Serializable]
public class dsCompanyContactSearch : DataSet
{
  private dsCompanyContactSearch.CompanyLocationDataTable tableCompanyLocation;
  private dsCompanyContactSearch.CompanyContactDataTable tableCompanyContact;
  private SchemaSerializationMode _schemaSerializationMode = SchemaSerializationMode.IncludeSchema;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public dsCompanyContactSearch()
  {
    this.BeginInit();
    this.InitClass();
    CollectionChangeEventHandler changeEventHandler = new CollectionChangeEventHandler(this.SchemaChanged);
    base.Tables.CollectionChanged += changeEventHandler;
    base.Relations.CollectionChanged += changeEventHandler;
    this.EndInit();
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  protected dsCompanyContactSearch(SerializationInfo info, StreamingContext context)
    : base(info, context, false)
  {
    if (this.IsBinarySerialized(info, context))
    {
      this.InitVars(false);
      CollectionChangeEventHandler changeEventHandler = new CollectionChangeEventHandler(this.SchemaChanged);
      this.Tables.CollectionChanged += changeEventHandler;
      this.Relations.CollectionChanged += changeEventHandler;
    }
    else
    {
      string s = (string) info.GetValue("XmlSchema", typeof (string));
      if (this.DetermineSchemaSerializationMode(info, context) == SchemaSerializationMode.IncludeSchema)
      {
        DataSet dataSet = new DataSet();
        dataSet.ReadXmlSchema((XmlReader) new XmlTextReader((TextReader) new StringReader(s)));
        if (dataSet.Tables[nameof (CompanyLocation)] != null)
          base.Tables.Add((DataTable) new dsCompanyContactSearch.CompanyLocationDataTable(dataSet.Tables[nameof (CompanyLocation)]));
        if (dataSet.Tables[nameof (CompanyContact)] != null)
          base.Tables.Add((DataTable) new dsCompanyContactSearch.CompanyContactDataTable(dataSet.Tables[nameof (CompanyContact)]));
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
  public dsCompanyContactSearch.CompanyLocationDataTable CompanyLocation
  {
    get => this.tableCompanyLocation;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsCompanyContactSearch.CompanyContactDataTable CompanyContact => this.tableCompanyContact;

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
    dsCompanyContactSearch companyContactSearch = (dsCompanyContactSearch) base.Clone();
    companyContactSearch.InitVars();
    companyContactSearch.SchemaSerializationMode = this.SchemaSerializationMode;
    return (DataSet) companyContactSearch;
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
      if (dataSet.Tables["CompanyLocation"] != null)
        base.Tables.Add((DataTable) new dsCompanyContactSearch.CompanyLocationDataTable(dataSet.Tables["CompanyLocation"]));
      if (dataSet.Tables["CompanyContact"] != null)
        base.Tables.Add((DataTable) new dsCompanyContactSearch.CompanyContactDataTable(dataSet.Tables["CompanyContact"]));
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
    this.tableCompanyLocation = (dsCompanyContactSearch.CompanyLocationDataTable) base.Tables["CompanyLocation"];
    if (initTable && this.tableCompanyLocation != null)
      this.tableCompanyLocation.InitVars();
    this.tableCompanyContact = (dsCompanyContactSearch.CompanyContactDataTable) base.Tables["CompanyContact"];
    if (!initTable || this.tableCompanyContact == null)
      return;
    this.tableCompanyContact.InitVars();
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private void InitClass()
  {
    this.DataSetName = nameof (dsCompanyContactSearch);
    this.Prefix = "";
    this.Namespace = "http://tempuri.org/dsCompanyContactSearch.xsd";
    this.EnforceConstraints = true;
    this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.tableCompanyLocation = new dsCompanyContactSearch.CompanyLocationDataTable();
    base.Tables.Add((DataTable) this.tableCompanyLocation);
    this.tableCompanyContact = new dsCompanyContactSearch.CompanyContactDataTable();
    base.Tables.Add((DataTable) this.tableCompanyContact);
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializeCompanyLocation() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializeCompanyContact() => false;

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
    dsCompanyContactSearch companyContactSearch = new dsCompanyContactSearch();
    XmlSchemaComplexType typedDataSetSchema = new XmlSchemaComplexType();
    XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
    xmlSchemaSequence.Items.Add((XmlSchemaObject) new XmlSchemaAny()
    {
      Namespace = companyContactSearch.Namespace
    });
    typedDataSetSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
    XmlSchema schemaSerializable = companyContactSearch.GetSchemaSerializable();
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
              return typedDataSetSchema;
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
    return typedDataSetSchema;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void CompanyLocationRowChangeEventHandler(
    object sender,
    dsCompanyContactSearch.CompanyLocationRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void CompanyContactRowChangeEventHandler(
    object sender,
    dsCompanyContactSearch.CompanyContactRowChangeEvent e);

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class CompanyLocationDataTable : TypedTableBase<dsCompanyContactSearch.CompanyLocationRow>
  {
    private DataColumn columnCompanyLocationGUID;
    private DataColumn columnLocationName;
    private DataColumn columnCity;
    private DataColumn columnState;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public CompanyLocationDataTable()
    {
      this.TableName = "CompanyLocation";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal CompanyLocationDataTable(DataTable table)
    {
      this.TableName = table.TableName;
      if (table.CaseSensitive != table.DataSet.CaseSensitive)
        this.CaseSensitive = table.CaseSensitive;
      if (table.Locale.ToString() != table.DataSet.Locale.ToString())
        this.Locale = table.Locale;
      if (table.Namespace != table.DataSet.Namespace)
        this.Namespace = table.Namespace;
      this.Prefix = table.Prefix;
      this.MinimumCapacity = table.MinimumCapacity;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected CompanyLocationDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn CompanyLocationGUIDColumn => this.columnCompanyLocationGUID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn LocationNameColumn => this.columnLocationName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn CityColumn => this.columnCity;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn StateColumn => this.columnState;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompanyContactSearch.CompanyLocationRow this[int index]
    {
      get => (dsCompanyContactSearch.CompanyLocationRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsCompanyContactSearch.CompanyLocationRowChangeEventHandler CompanyLocationRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsCompanyContactSearch.CompanyLocationRowChangeEventHandler CompanyLocationRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsCompanyContactSearch.CompanyLocationRowChangeEventHandler CompanyLocationRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsCompanyContactSearch.CompanyLocationRowChangeEventHandler CompanyLocationRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddCompanyLocationRow(dsCompanyContactSearch.CompanyLocationRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompanyContactSearch.CompanyLocationRow AddCompanyLocationRow(
      Guid CompanyLocationGUID,
      string LocationName,
      string City,
      string State)
    {
      dsCompanyContactSearch.CompanyLocationRow row = (dsCompanyContactSearch.CompanyLocationRow) this.NewRow();
      object[] objArray = new object[4]
      {
        (object) CompanyLocationGUID,
        (object) LocationName,
        (object) City,
        (object) State
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsCompanyContactSearch.CompanyLocationDataTable locationDataTable = (dsCompanyContactSearch.CompanyLocationDataTable) base.Clone();
      locationDataTable.InitVars();
      return (DataTable) locationDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsCompanyContactSearch.CompanyLocationDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnCompanyLocationGUID = this.Columns["CompanyLocationGUID"];
      this.columnLocationName = this.Columns["LocationName"];
      this.columnCity = this.Columns["City"];
      this.columnState = this.Columns["State"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnCompanyLocationGUID = new DataColumn("CompanyLocationGUID", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCompanyLocationGUID);
      this.columnLocationName = new DataColumn("LocationName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLocationName);
      this.columnCity = new DataColumn("City", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCity);
      this.columnState = new DataColumn("State", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnState);
      this.columnCompanyLocationGUID.AllowDBNull = false;
      this.columnLocationName.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompanyContactSearch.CompanyLocationRow NewCompanyLocationRow()
    {
      return (dsCompanyContactSearch.CompanyLocationRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsCompanyContactSearch.CompanyLocationRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (dsCompanyContactSearch.CompanyLocationRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      if (this.CompanyLocationRowChanged == null)
        return;
      this.CompanyLocationRowChanged((object) this, new dsCompanyContactSearch.CompanyLocationRowChangeEvent((dsCompanyContactSearch.CompanyLocationRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      if (this.CompanyLocationRowChanging == null)
        return;
      this.CompanyLocationRowChanging((object) this, new dsCompanyContactSearch.CompanyLocationRowChangeEvent((dsCompanyContactSearch.CompanyLocationRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      if (this.CompanyLocationRowDeleted == null)
        return;
      this.CompanyLocationRowDeleted((object) this, new dsCompanyContactSearch.CompanyLocationRowChangeEvent((dsCompanyContactSearch.CompanyLocationRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      if (this.CompanyLocationRowDeleting == null)
        return;
      this.CompanyLocationRowDeleting((object) this, new dsCompanyContactSearch.CompanyLocationRowChangeEvent((dsCompanyContactSearch.CompanyLocationRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemoveCompanyLocationRow(dsCompanyContactSearch.CompanyLocationRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType typedTableSchema = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsCompanyContactSearch companyContactSearch = new dsCompanyContactSearch();
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
      typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "namespace",
        FixedValue = companyContactSearch.Namespace
      });
      typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (CompanyLocationDataTable)
      });
      typedTableSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = companyContactSearch.GetSchemaSerializable();
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
                return typedTableSchema;
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
      return typedTableSchema;
    }
  }

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class CompanyContactDataTable : TypedTableBase<dsCompanyContactSearch.CompanyContactRow>
  {
    private DataColumn columnCompanyLocationGUID;
    private DataColumn columnContact;
    private DataColumn columnCity;
    private DataColumn columnState;
    private DataColumn columnLocationName;
    private DataColumn columnContactGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public CompanyContactDataTable()
    {
      this.TableName = "CompanyContact";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal CompanyContactDataTable(DataTable table)
    {
      this.TableName = table.TableName;
      if (table.CaseSensitive != table.DataSet.CaseSensitive)
        this.CaseSensitive = table.CaseSensitive;
      if (table.Locale.ToString() != table.DataSet.Locale.ToString())
        this.Locale = table.Locale;
      if (table.Namespace != table.DataSet.Namespace)
        this.Namespace = table.Namespace;
      this.Prefix = table.Prefix;
      this.MinimumCapacity = table.MinimumCapacity;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected CompanyContactDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn CompanyLocationGUIDColumn => this.columnCompanyLocationGUID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ContactColumn => this.columnContact;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn CityColumn => this.columnCity;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn StateColumn => this.columnState;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn LocationNameColumn => this.columnLocationName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ContactGuidColumn => this.columnContactGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompanyContactSearch.CompanyContactRow this[int index]
    {
      get => (dsCompanyContactSearch.CompanyContactRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsCompanyContactSearch.CompanyContactRowChangeEventHandler CompanyContactRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsCompanyContactSearch.CompanyContactRowChangeEventHandler CompanyContactRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsCompanyContactSearch.CompanyContactRowChangeEventHandler CompanyContactRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsCompanyContactSearch.CompanyContactRowChangeEventHandler CompanyContactRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddCompanyContactRow(dsCompanyContactSearch.CompanyContactRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompanyContactSearch.CompanyContactRow AddCompanyContactRow(
      Guid CompanyLocationGUID,
      string Contact,
      string City,
      string State,
      string LocationName,
      Guid ContactGuid)
    {
      dsCompanyContactSearch.CompanyContactRow row = (dsCompanyContactSearch.CompanyContactRow) this.NewRow();
      object[] objArray = new object[6]
      {
        (object) CompanyLocationGUID,
        (object) Contact,
        (object) City,
        (object) State,
        (object) LocationName,
        (object) ContactGuid
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsCompanyContactSearch.CompanyContactDataTable contactDataTable = (dsCompanyContactSearch.CompanyContactDataTable) base.Clone();
      contactDataTable.InitVars();
      return (DataTable) contactDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsCompanyContactSearch.CompanyContactDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnCompanyLocationGUID = this.Columns["CompanyLocationGUID"];
      this.columnContact = this.Columns["Contact"];
      this.columnCity = this.Columns["City"];
      this.columnState = this.Columns["State"];
      this.columnLocationName = this.Columns["LocationName"];
      this.columnContactGuid = this.Columns["ContactGuid"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnCompanyLocationGUID = new DataColumn("CompanyLocationGUID", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCompanyLocationGUID);
      this.columnContact = new DataColumn("Contact", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnContact);
      this.columnCity = new DataColumn("City", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCity);
      this.columnState = new DataColumn("State", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnState);
      this.columnLocationName = new DataColumn("LocationName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLocationName);
      this.columnContactGuid = new DataColumn("ContactGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnContactGuid);
      this.columnCompanyLocationGUID.AllowDBNull = false;
      this.columnContactGuid.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompanyContactSearch.CompanyContactRow NewCompanyContactRow()
    {
      return (dsCompanyContactSearch.CompanyContactRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsCompanyContactSearch.CompanyContactRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (dsCompanyContactSearch.CompanyContactRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      if (this.CompanyContactRowChanged == null)
        return;
      this.CompanyContactRowChanged((object) this, new dsCompanyContactSearch.CompanyContactRowChangeEvent((dsCompanyContactSearch.CompanyContactRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      if (this.CompanyContactRowChanging == null)
        return;
      this.CompanyContactRowChanging((object) this, new dsCompanyContactSearch.CompanyContactRowChangeEvent((dsCompanyContactSearch.CompanyContactRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      if (this.CompanyContactRowDeleted == null)
        return;
      this.CompanyContactRowDeleted((object) this, new dsCompanyContactSearch.CompanyContactRowChangeEvent((dsCompanyContactSearch.CompanyContactRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      if (this.CompanyContactRowDeleting == null)
        return;
      this.CompanyContactRowDeleting((object) this, new dsCompanyContactSearch.CompanyContactRowChangeEvent((dsCompanyContactSearch.CompanyContactRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemoveCompanyContactRow(dsCompanyContactSearch.CompanyContactRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType typedTableSchema = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsCompanyContactSearch companyContactSearch = new dsCompanyContactSearch();
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
      typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "namespace",
        FixedValue = companyContactSearch.Namespace
      });
      typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (CompanyContactDataTable)
      });
      typedTableSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = companyContactSearch.GetSchemaSerializable();
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
                return typedTableSchema;
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
      return typedTableSchema;
    }
  }

  public class CompanyLocationRow : DataRow
  {
    private dsCompanyContactSearch.CompanyLocationDataTable tableCompanyLocation;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal CompanyLocationRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableCompanyLocation = (dsCompanyContactSearch.CompanyLocationDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Guid CompanyLocationGUID
    {
      get => (Guid) this[this.tableCompanyLocation.CompanyLocationGUIDColumn];
      set => this[this.tableCompanyLocation.CompanyLocationGUIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string LocationName
    {
      get => (string) this[this.tableCompanyLocation.LocationNameColumn];
      set => this[this.tableCompanyLocation.LocationNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string City
    {
      get
      {
        try
        {
          return (string) this[this.tableCompanyLocation.CityColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'City' in table 'CompanyLocation' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableCompanyLocation.CityColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string State
    {
      get
      {
        try
        {
          return (string) this[this.tableCompanyLocation.StateColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'State' in table 'CompanyLocation' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableCompanyLocation.StateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsCityNull() => this.IsNull(this.tableCompanyLocation.CityColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetCityNull() => this[this.tableCompanyLocation.CityColumn] = Convert.DBNull;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsStateNull() => this.IsNull(this.tableCompanyLocation.StateColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetStateNull() => this[this.tableCompanyLocation.StateColumn] = Convert.DBNull;
  }

  public class CompanyContactRow : DataRow
  {
    private dsCompanyContactSearch.CompanyContactDataTable tableCompanyContact;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal CompanyContactRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableCompanyContact = (dsCompanyContactSearch.CompanyContactDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Guid CompanyLocationGUID
    {
      get => (Guid) this[this.tableCompanyContact.CompanyLocationGUIDColumn];
      set => this[this.tableCompanyContact.CompanyLocationGUIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Contact
    {
      get
      {
        try
        {
          return (string) this[this.tableCompanyContact.ContactColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'Contact' in table 'CompanyContact' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableCompanyContact.ContactColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string City
    {
      get
      {
        try
        {
          return (string) this[this.tableCompanyContact.CityColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'City' in table 'CompanyContact' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableCompanyContact.CityColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string State
    {
      get
      {
        try
        {
          return (string) this[this.tableCompanyContact.StateColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'State' in table 'CompanyContact' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableCompanyContact.StateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string LocationName
    {
      get
      {
        try
        {
          return (string) this[this.tableCompanyContact.LocationNameColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'LocationName' in table 'CompanyContact' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableCompanyContact.LocationNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Guid ContactGuid
    {
      get => (Guid) this[this.tableCompanyContact.ContactGuidColumn];
      set => this[this.tableCompanyContact.ContactGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsContactNull() => this.IsNull(this.tableCompanyContact.ContactColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetContactNull() => this[this.tableCompanyContact.ContactColumn] = Convert.DBNull;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsCityNull() => this.IsNull(this.tableCompanyContact.CityColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetCityNull() => this[this.tableCompanyContact.CityColumn] = Convert.DBNull;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsStateNull() => this.IsNull(this.tableCompanyContact.StateColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetStateNull() => this[this.tableCompanyContact.StateColumn] = Convert.DBNull;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsLocationNameNull() => this.IsNull(this.tableCompanyContact.LocationNameColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetLocationNameNull()
    {
      this[this.tableCompanyContact.LocationNameColumn] = Convert.DBNull;
    }
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class CompanyLocationRowChangeEvent : EventArgs
  {
    private dsCompanyContactSearch.CompanyLocationRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public CompanyLocationRowChangeEvent(
      dsCompanyContactSearch.CompanyLocationRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompanyContactSearch.CompanyLocationRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class CompanyContactRowChangeEvent : EventArgs
  {
    private dsCompanyContactSearch.CompanyContactRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public CompanyContactRowChangeEvent(
      dsCompanyContactSearch.CompanyContactRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsCompanyContactSearch.CompanyContactRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }
}
