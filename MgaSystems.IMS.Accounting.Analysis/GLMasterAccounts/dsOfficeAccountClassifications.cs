// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Analysis.GLMasterAccounts.dsOfficeAccountClassifications
// Assembly: MgaSystems.IMS.Accounting.Analysis, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 8E3A477E-E77B-44DA-B1A6-ED3671BCE2BE
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Analysis.dll

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
namespace MGASystems.IMS.Accounting.Analysis.GLMasterAccounts;

[DesignerCategory("code")]
[ToolboxItem(true)]
[XmlSchemaProvider("GetTypedDataSetSchema")]
[XmlRoot("dsOfficeAccountClassifications")]
[HelpKeyword("vs.data.DataSet")]
[Serializable]
public class dsOfficeAccountClassifications : DataSet
{
  private dsOfficeAccountClassifications.OfficeAccountClassificationsDataTable tableOfficeAccountClassifications;
  private dsOfficeAccountClassifications.OfficeLocationsDataTable tableOfficeLocations;
  private DataRelation relationOfficeLocations_OfficeAccountClassifications;
  private SchemaSerializationMode _schemaSerializationMode = SchemaSerializationMode.IncludeSchema;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public dsOfficeAccountClassifications()
  {
    this.BeginInit();
    this.InitClass();
    CollectionChangeEventHandler changeEventHandler = new CollectionChangeEventHandler(this.SchemaChanged);
    base.Tables.CollectionChanged += changeEventHandler;
    base.Relations.CollectionChanged += changeEventHandler;
    this.EndInit();
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  protected dsOfficeAccountClassifications(SerializationInfo info, StreamingContext context)
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
        if (dataSet.Tables[nameof (OfficeAccountClassifications)] != null)
          base.Tables.Add((DataTable) new dsOfficeAccountClassifications.OfficeAccountClassificationsDataTable(dataSet.Tables[nameof (OfficeAccountClassifications)]));
        if (dataSet.Tables[nameof (OfficeLocations)] != null)
          base.Tables.Add((DataTable) new dsOfficeAccountClassifications.OfficeLocationsDataTable(dataSet.Tables[nameof (OfficeLocations)]));
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
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsOfficeAccountClassifications.OfficeAccountClassificationsDataTable OfficeAccountClassifications
  {
    get => this.tableOfficeAccountClassifications;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsOfficeAccountClassifications.OfficeLocationsDataTable OfficeLocations
  {
    get => this.tableOfficeLocations;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [Browsable(true)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
  public override SchemaSerializationMode SchemaSerializationMode
  {
    get => this._schemaSerializationMode;
    set => this._schemaSerializationMode = value;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public new DataTableCollection Tables => base.Tables;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public new DataRelationCollection Relations => base.Relations;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  protected override void InitializeDerivedDataSet()
  {
    this.BeginInit();
    this.InitClass();
    this.EndInit();
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public override DataSet Clone()
  {
    dsOfficeAccountClassifications accountClassifications = (dsOfficeAccountClassifications) base.Clone();
    accountClassifications.InitVars();
    accountClassifications.SchemaSerializationMode = this.SchemaSerializationMode;
    return (DataSet) accountClassifications;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  protected override bool ShouldSerializeTables() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  protected override bool ShouldSerializeRelations() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  protected override void ReadXmlSerializable(XmlReader reader)
  {
    if (this.DetermineSchemaSerializationMode(reader) == SchemaSerializationMode.IncludeSchema)
    {
      this.Reset();
      DataSet dataSet = new DataSet();
      int num = (int) dataSet.ReadXml(reader);
      if (dataSet.Tables["OfficeAccountClassifications"] != null)
        base.Tables.Add((DataTable) new dsOfficeAccountClassifications.OfficeAccountClassificationsDataTable(dataSet.Tables["OfficeAccountClassifications"]));
      if (dataSet.Tables["OfficeLocations"] != null)
        base.Tables.Add((DataTable) new dsOfficeAccountClassifications.OfficeLocationsDataTable(dataSet.Tables["OfficeLocations"]));
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
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  protected override XmlSchema GetSchemaSerializable()
  {
    MemoryStream memoryStream = new MemoryStream();
    this.WriteXmlSchema((XmlWriter) new XmlTextWriter((Stream) memoryStream, (Encoding) null));
    memoryStream.Position = 0L;
    return XmlSchema.Read((XmlReader) new XmlTextReader((Stream) memoryStream), (ValidationEventHandler) null);
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  internal void InitVars() => this.InitVars(true);

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  internal void InitVars(bool initTable)
  {
    this.tableOfficeAccountClassifications = (dsOfficeAccountClassifications.OfficeAccountClassificationsDataTable) base.Tables["OfficeAccountClassifications"];
    if (initTable && this.tableOfficeAccountClassifications != null)
      this.tableOfficeAccountClassifications.InitVars();
    this.tableOfficeLocations = (dsOfficeAccountClassifications.OfficeLocationsDataTable) base.Tables["OfficeLocations"];
    if (initTable && this.tableOfficeLocations != null)
      this.tableOfficeLocations.InitVars();
    this.relationOfficeLocations_OfficeAccountClassifications = this.Relations["OfficeLocations_OfficeAccountClassifications"];
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private void InitClass()
  {
    this.DataSetName = nameof (dsOfficeAccountClassifications);
    this.Prefix = "";
    this.Namespace = "http://tempuri.org/dsOfficeAccountClassifications.xsd";
    this.EnforceConstraints = true;
    this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.tableOfficeAccountClassifications = new dsOfficeAccountClassifications.OfficeAccountClassificationsDataTable();
    base.Tables.Add((DataTable) this.tableOfficeAccountClassifications);
    this.tableOfficeLocations = new dsOfficeAccountClassifications.OfficeLocationsDataTable();
    base.Tables.Add((DataTable) this.tableOfficeLocations);
    this.relationOfficeLocations_OfficeAccountClassifications = new DataRelation("OfficeLocations_OfficeAccountClassifications", new DataColumn[1]
    {
      this.tableOfficeLocations.IdColumn
    }, new DataColumn[1]
    {
      this.tableOfficeAccountClassifications.OfficeIdColumn
    }, false);
    this.Relations.Add(this.relationOfficeLocations_OfficeAccountClassifications);
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializeOfficeAccountClassifications() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializeOfficeLocations() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private void SchemaChanged(object sender, CollectionChangeEventArgs e)
  {
    if (e.Action != CollectionChangeAction.Remove)
      return;
    this.InitVars();
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public static XmlSchemaComplexType GetTypedDataSetSchema(XmlSchemaSet xs)
  {
    dsOfficeAccountClassifications accountClassifications = new dsOfficeAccountClassifications();
    XmlSchemaComplexType typedDataSetSchema = new XmlSchemaComplexType();
    XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
    xmlSchemaSequence.Items.Add((XmlSchemaObject) new XmlSchemaAny()
    {
      Namespace = accountClassifications.Namespace
    });
    typedDataSetSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
    XmlSchema schemaSerializable = accountClassifications.GetSchemaSerializable();
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

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public delegate void OfficeAccountClassificationsRowChangeEventHandler(
    object sender,
    dsOfficeAccountClassifications.OfficeAccountClassificationsRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public delegate void OfficeLocationsRowChangeEventHandler(
    object sender,
    dsOfficeAccountClassifications.OfficeLocationsRowChangeEvent e);

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class OfficeAccountClassificationsDataTable : 
    TypedTableBase<dsOfficeAccountClassifications.OfficeAccountClassificationsRow>
  {
    private DataColumn columnOfficeId;
    private DataColumn columnOfficeLocation;
    private DataColumn columnAccountClass;
    private DataColumn columnClassLLimit;
    private DataColumn columnClassULimit;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public OfficeAccountClassificationsDataTable()
    {
      this.TableName = "OfficeAccountClassifications";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal OfficeAccountClassificationsDataTable(DataTable table)
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected OfficeAccountClassificationsDataTable(
      SerializationInfo info,
      StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn OfficeIdColumn => this.columnOfficeId;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn OfficeLocationColumn => this.columnOfficeLocation;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn AccountClassColumn => this.columnAccountClass;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ClassLLimitColumn => this.columnClassLLimit;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ClassULimitColumn => this.columnClassULimit;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsOfficeAccountClassifications.OfficeAccountClassificationsRow this[int index]
    {
      get => (dsOfficeAccountClassifications.OfficeAccountClassificationsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsOfficeAccountClassifications.OfficeAccountClassificationsRowChangeEventHandler OfficeAccountClassificationsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsOfficeAccountClassifications.OfficeAccountClassificationsRowChangeEventHandler OfficeAccountClassificationsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsOfficeAccountClassifications.OfficeAccountClassificationsRowChangeEventHandler OfficeAccountClassificationsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsOfficeAccountClassifications.OfficeAccountClassificationsRowChangeEventHandler OfficeAccountClassificationsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AddOfficeAccountClassificationsRow(
      dsOfficeAccountClassifications.OfficeAccountClassificationsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsOfficeAccountClassifications.OfficeAccountClassificationsRow AddOfficeAccountClassificationsRow(
      dsOfficeAccountClassifications.OfficeLocationsRow parentOfficeLocationsRowByOfficeLocations_OfficeAccountClassifications,
      string OfficeLocation,
      string AccountClass,
      int ClassLLimit,
      int ClassULimit)
    {
      dsOfficeAccountClassifications.OfficeAccountClassificationsRow row = (dsOfficeAccountClassifications.OfficeAccountClassificationsRow) this.NewRow();
      object[] objArray = new object[5]
      {
        null,
        (object) OfficeLocation,
        (object) AccountClass,
        (object) ClassLLimit,
        (object) ClassULimit
      };
      if (parentOfficeLocationsRowByOfficeLocations_OfficeAccountClassifications != null)
        objArray[0] = parentOfficeLocationsRowByOfficeLocations_OfficeAccountClassifications[0];
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsOfficeAccountClassifications.OfficeAccountClassificationsDataTable classificationsDataTable = (dsOfficeAccountClassifications.OfficeAccountClassificationsDataTable) base.Clone();
      classificationsDataTable.InitVars();
      return (DataTable) classificationsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsOfficeAccountClassifications.OfficeAccountClassificationsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal void InitVars()
    {
      this.columnOfficeId = this.Columns["OfficeId"];
      this.columnOfficeLocation = this.Columns["OfficeLocation"];
      this.columnAccountClass = this.Columns["AccountClass"];
      this.columnClassLLimit = this.Columns["ClassLLimit"];
      this.columnClassULimit = this.Columns["ClassULimit"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    private void InitClass()
    {
      this.columnOfficeId = new DataColumn("OfficeId", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnOfficeId);
      this.columnOfficeLocation = new DataColumn("OfficeLocation", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnOfficeLocation);
      this.columnAccountClass = new DataColumn("AccountClass", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAccountClass);
      this.columnClassLLimit = new DataColumn("ClassLLimit", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnClassLLimit);
      this.columnClassULimit = new DataColumn("ClassULimit", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnClassULimit);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsOfficeAccountClassifications.OfficeAccountClassificationsRow NewOfficeAccountClassificationsRow()
    {
      return (dsOfficeAccountClassifications.OfficeAccountClassificationsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsOfficeAccountClassifications.OfficeAccountClassificationsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType()
    {
      return typeof (dsOfficeAccountClassifications.OfficeAccountClassificationsRow);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      if (this.OfficeAccountClassificationsRowChanged == null)
        return;
      this.OfficeAccountClassificationsRowChanged((object) this, new dsOfficeAccountClassifications.OfficeAccountClassificationsRowChangeEvent((dsOfficeAccountClassifications.OfficeAccountClassificationsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      if (this.OfficeAccountClassificationsRowChanging == null)
        return;
      this.OfficeAccountClassificationsRowChanging((object) this, new dsOfficeAccountClassifications.OfficeAccountClassificationsRowChangeEvent((dsOfficeAccountClassifications.OfficeAccountClassificationsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      if (this.OfficeAccountClassificationsRowDeleted == null)
        return;
      this.OfficeAccountClassificationsRowDeleted((object) this, new dsOfficeAccountClassifications.OfficeAccountClassificationsRowChangeEvent((dsOfficeAccountClassifications.OfficeAccountClassificationsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      if (this.OfficeAccountClassificationsRowDeleting == null)
        return;
      this.OfficeAccountClassificationsRowDeleting((object) this, new dsOfficeAccountClassifications.OfficeAccountClassificationsRowChangeEvent((dsOfficeAccountClassifications.OfficeAccountClassificationsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemoveOfficeAccountClassificationsRow(
      dsOfficeAccountClassifications.OfficeAccountClassificationsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType typedTableSchema = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsOfficeAccountClassifications accountClassifications = new dsOfficeAccountClassifications();
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
        FixedValue = accountClassifications.Namespace
      });
      typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (OfficeAccountClassificationsDataTable)
      });
      typedTableSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = accountClassifications.GetSchemaSerializable();
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
  public class OfficeLocationsDataTable : 
    TypedTableBase<dsOfficeAccountClassifications.OfficeLocationsRow>
  {
    private DataColumn columnId;
    private DataColumn columnOffice_Location;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public OfficeLocationsDataTable()
    {
      this.TableName = "OfficeLocations";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal OfficeLocationsDataTable(DataTable table)
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected OfficeLocationsDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn IdColumn => this.columnId;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn Office_LocationColumn => this.columnOffice_Location;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsOfficeAccountClassifications.OfficeLocationsRow this[int index]
    {
      get => (dsOfficeAccountClassifications.OfficeLocationsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsOfficeAccountClassifications.OfficeLocationsRowChangeEventHandler OfficeLocationsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsOfficeAccountClassifications.OfficeLocationsRowChangeEventHandler OfficeLocationsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsOfficeAccountClassifications.OfficeLocationsRowChangeEventHandler OfficeLocationsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsOfficeAccountClassifications.OfficeLocationsRowChangeEventHandler OfficeLocationsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AddOfficeLocationsRow(
      dsOfficeAccountClassifications.OfficeLocationsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsOfficeAccountClassifications.OfficeLocationsRow AddOfficeLocationsRow(
      int Id,
      string Office_Location)
    {
      dsOfficeAccountClassifications.OfficeLocationsRow row = (dsOfficeAccountClassifications.OfficeLocationsRow) this.NewRow();
      object[] objArray = new object[2]
      {
        (object) Id,
        (object) Office_Location
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsOfficeAccountClassifications.OfficeLocationsRow FindById(int Id)
    {
      return (dsOfficeAccountClassifications.OfficeLocationsRow) this.Rows.Find(new object[1]
      {
        (object) Id
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsOfficeAccountClassifications.OfficeLocationsDataTable locationsDataTable = (dsOfficeAccountClassifications.OfficeLocationsDataTable) base.Clone();
      locationsDataTable.InitVars();
      return (DataTable) locationsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsOfficeAccountClassifications.OfficeLocationsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal void InitVars()
    {
      this.columnId = this.Columns["Id"];
      this.columnOffice_Location = this.Columns["Office Location"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    private void InitClass()
    {
      this.columnId = new DataColumn("Id", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnId);
      this.columnOffice_Location = new DataColumn("Office Location", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnOffice_Location);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnId
      }, true));
      this.columnId.AllowDBNull = false;
      this.columnId.Unique = true;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsOfficeAccountClassifications.OfficeLocationsRow NewOfficeLocationsRow()
    {
      return (dsOfficeAccountClassifications.OfficeLocationsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsOfficeAccountClassifications.OfficeLocationsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType()
    {
      return typeof (dsOfficeAccountClassifications.OfficeLocationsRow);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      if (this.OfficeLocationsRowChanged == null)
        return;
      this.OfficeLocationsRowChanged((object) this, new dsOfficeAccountClassifications.OfficeLocationsRowChangeEvent((dsOfficeAccountClassifications.OfficeLocationsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      if (this.OfficeLocationsRowChanging == null)
        return;
      this.OfficeLocationsRowChanging((object) this, new dsOfficeAccountClassifications.OfficeLocationsRowChangeEvent((dsOfficeAccountClassifications.OfficeLocationsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      if (this.OfficeLocationsRowDeleted == null)
        return;
      this.OfficeLocationsRowDeleted((object) this, new dsOfficeAccountClassifications.OfficeLocationsRowChangeEvent((dsOfficeAccountClassifications.OfficeLocationsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      if (this.OfficeLocationsRowDeleting == null)
        return;
      this.OfficeLocationsRowDeleting((object) this, new dsOfficeAccountClassifications.OfficeLocationsRowChangeEvent((dsOfficeAccountClassifications.OfficeLocationsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemoveOfficeLocationsRow(
      dsOfficeAccountClassifications.OfficeLocationsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType typedTableSchema = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsOfficeAccountClassifications accountClassifications = new dsOfficeAccountClassifications();
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
        FixedValue = accountClassifications.Namespace
      });
      typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (OfficeLocationsDataTable)
      });
      typedTableSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = accountClassifications.GetSchemaSerializable();
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

  public class OfficeAccountClassificationsRow : DataRow
  {
    private dsOfficeAccountClassifications.OfficeAccountClassificationsDataTable tableOfficeAccountClassifications;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal OfficeAccountClassificationsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableOfficeAccountClassifications = (dsOfficeAccountClassifications.OfficeAccountClassificationsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int OfficeId
    {
      get
      {
        try
        {
          return (int) this[this.tableOfficeAccountClassifications.OfficeIdColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'OfficeId' in table 'OfficeAccountClassifications' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableOfficeAccountClassifications.OfficeIdColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string OfficeLocation
    {
      get
      {
        try
        {
          return (string) this[this.tableOfficeAccountClassifications.OfficeLocationColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'OfficeLocation' in table 'OfficeAccountClassifications' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableOfficeAccountClassifications.OfficeLocationColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string AccountClass
    {
      get
      {
        try
        {
          return (string) this[this.tableOfficeAccountClassifications.AccountClassColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'AccountClass' in table 'OfficeAccountClassifications' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableOfficeAccountClassifications.AccountClassColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int ClassLLimit
    {
      get
      {
        try
        {
          return (int) this[this.tableOfficeAccountClassifications.ClassLLimitColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'ClassLLimit' in table 'OfficeAccountClassifications' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableOfficeAccountClassifications.ClassLLimitColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int ClassULimit
    {
      get
      {
        try
        {
          return (int) this[this.tableOfficeAccountClassifications.ClassULimitColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'ClassULimit' in table 'OfficeAccountClassifications' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableOfficeAccountClassifications.ClassULimitColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsOfficeAccountClassifications.OfficeLocationsRow OfficeLocationsRow
    {
      get
      {
        return (dsOfficeAccountClassifications.OfficeLocationsRow) this.GetParentRow(this.Table.ParentRelations["OfficeLocations_OfficeAccountClassifications"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["OfficeLocations_OfficeAccountClassifications"]);
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsOfficeIdNull()
    {
      return this.IsNull(this.tableOfficeAccountClassifications.OfficeIdColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetOfficeIdNull()
    {
      this[this.tableOfficeAccountClassifications.OfficeIdColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsOfficeLocationNull()
    {
      return this.IsNull(this.tableOfficeAccountClassifications.OfficeLocationColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetOfficeLocationNull()
    {
      this[this.tableOfficeAccountClassifications.OfficeLocationColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsAccountClassNull()
    {
      return this.IsNull(this.tableOfficeAccountClassifications.AccountClassColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetAccountClassNull()
    {
      this[this.tableOfficeAccountClassifications.AccountClassColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsClassLLimitNull()
    {
      return this.IsNull(this.tableOfficeAccountClassifications.ClassLLimitColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetClassLLimitNull()
    {
      this[this.tableOfficeAccountClassifications.ClassLLimitColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsClassULimitNull()
    {
      return this.IsNull(this.tableOfficeAccountClassifications.ClassULimitColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetClassULimitNull()
    {
      this[this.tableOfficeAccountClassifications.ClassULimitColumn] = Convert.DBNull;
    }
  }

  public class OfficeLocationsRow : DataRow
  {
    private dsOfficeAccountClassifications.OfficeLocationsDataTable tableOfficeLocations;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal OfficeLocationsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableOfficeLocations = (dsOfficeAccountClassifications.OfficeLocationsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int Id
    {
      get => (int) this[this.tableOfficeLocations.IdColumn];
      set => this[this.tableOfficeLocations.IdColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string Office_Location
    {
      get
      {
        try
        {
          return (string) this[this.tableOfficeLocations.Office_LocationColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'Office Location' in table 'OfficeLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableOfficeLocations.Office_LocationColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsOffice_LocationNull()
    {
      return this.IsNull(this.tableOfficeLocations.Office_LocationColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetOffice_LocationNull()
    {
      this[this.tableOfficeLocations.Office_LocationColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsOfficeAccountClassifications.OfficeAccountClassificationsRow[] GetOfficeAccountClassificationsRows()
    {
      return this.Table.ChildRelations["OfficeLocations_OfficeAccountClassifications"] == null ? new dsOfficeAccountClassifications.OfficeAccountClassificationsRow[0] : (dsOfficeAccountClassifications.OfficeAccountClassificationsRow[]) this.GetChildRows(this.Table.ChildRelations["OfficeLocations_OfficeAccountClassifications"]);
    }
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class OfficeAccountClassificationsRowChangeEvent : EventArgs
  {
    private dsOfficeAccountClassifications.OfficeAccountClassificationsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public OfficeAccountClassificationsRowChangeEvent(
      dsOfficeAccountClassifications.OfficeAccountClassificationsRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsOfficeAccountClassifications.OfficeAccountClassificationsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class OfficeLocationsRowChangeEvent : EventArgs
  {
    private dsOfficeAccountClassifications.OfficeLocationsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public OfficeLocationsRowChangeEvent(
      dsOfficeAccountClassifications.OfficeLocationsRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsOfficeAccountClassifications.OfficeLocationsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }
}
