// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.dsProducerExcelImport
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
[XmlRoot("dsProducerExcelImport")]
[HelpKeyword("vs.data.DataSet")]
[Serializable]
public class dsProducerExcelImport : DataSet
{
  private dsProducerExcelImport.dtProducersImporterDataTable tabledtProducersImporter;
  private dsProducerExcelImport.dtProducerLocationsImporterDataTable tabledtProducerLocationsImporter;
  private SchemaSerializationMode _schemaSerializationMode;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public dsProducerExcelImport()
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
  protected dsProducerExcelImport(SerializationInfo info, StreamingContext context)
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
        if (dataSet.Tables[nameof (dtProducersImporter)] != null)
          base.Tables.Add((DataTable) new dsProducerExcelImport.dtProducersImporterDataTable(dataSet.Tables[nameof (dtProducersImporter)]));
        if (dataSet.Tables[nameof (dtProducerLocationsImporter)] != null)
          base.Tables.Add((DataTable) new dsProducerExcelImport.dtProducerLocationsImporterDataTable(dataSet.Tables[nameof (dtProducerLocationsImporter)]));
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
  public dsProducerExcelImport.dtProducersImporterDataTable dtProducersImporter
  {
    get => this.tabledtProducersImporter;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsProducerExcelImport.dtProducerLocationsImporterDataTable dtProducerLocationsImporter
  {
    get => this.tabledtProducerLocationsImporter;
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
    dsProducerExcelImport producerExcelImport = (dsProducerExcelImport) base.Clone();
    producerExcelImport.InitVars();
    producerExcelImport.SchemaSerializationMode = this.SchemaSerializationMode;
    return (DataSet) producerExcelImport;
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
      if (dataSet.Tables["dtProducersImporter"] != null)
        base.Tables.Add((DataTable) new dsProducerExcelImport.dtProducersImporterDataTable(dataSet.Tables["dtProducersImporter"]));
      if (dataSet.Tables["dtProducerLocationsImporter"] != null)
        base.Tables.Add((DataTable) new dsProducerExcelImport.dtProducerLocationsImporterDataTable(dataSet.Tables["dtProducerLocationsImporter"]));
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
    this.tabledtProducersImporter = (dsProducerExcelImport.dtProducersImporterDataTable) base.Tables["dtProducersImporter"];
    if (initTable && this.tabledtProducersImporter != null)
      this.tabledtProducersImporter.InitVars();
    this.tabledtProducerLocationsImporter = (dsProducerExcelImport.dtProducerLocationsImporterDataTable) base.Tables["dtProducerLocationsImporter"];
    if (!initTable || this.tabledtProducerLocationsImporter == null)
      return;
    this.tabledtProducerLocationsImporter.InitVars();
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private void InitClass()
  {
    this.DataSetName = nameof (dsProducerExcelImport);
    this.Prefix = "";
    this.Namespace = "http://tempuri.org/dsProducerExcelImport.xsd";
    this.EnforceConstraints = true;
    this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.tabledtProducersImporter = new dsProducerExcelImport.dtProducersImporterDataTable();
    base.Tables.Add((DataTable) this.tabledtProducersImporter);
    this.tabledtProducerLocationsImporter = new dsProducerExcelImport.dtProducerLocationsImporterDataTable();
    base.Tables.Add((DataTable) this.tabledtProducerLocationsImporter);
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializedtProducersImporter() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializedtProducerLocationsImporter() => false;

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
    dsProducerExcelImport producerExcelImport = new dsProducerExcelImport();
    XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
    schemaComplexType.Particle = (XmlSchemaParticle) new XmlSchemaSequence()
    {
      Items = {
        (XmlSchemaObject) new XmlSchemaAny()
        {
          Namespace = producerExcelImport.Namespace
        }
      }
    };
    XmlSchema schemaSerializable = producerExcelImport.GetSchemaSerializable();
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
  public delegate void dtProducersImporterRowChangeEventHandler(
    object sender,
    dsProducerExcelImport.dtProducersImporterRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void dtProducerLocationsImporterRowChangeEventHandler(
    object sender,
    dsProducerExcelImport.dtProducerLocationsImporterRowChangeEvent e);

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class dtProducersImporterDataTable : 
    TypedTableBase<dsProducerExcelImport.dtProducersImporterRow>
  {
    private DataColumn columnProducerGUID;
    private DataColumn columnProducerCode;
    private DataColumn columnProducerName;
    private DataColumn columnClosed;
    private DataColumn columnProducerBusinessTypeID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dtProducersImporterDataTable()
    {
      this.TableName = "dtProducersImporter";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal dtProducersImporterDataTable(DataTable table)
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
    protected dtProducersImporterDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ProducerGUIDColumn => this.columnProducerGUID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ProducerCodeColumn => this.columnProducerCode;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ProducerNameColumn => this.columnProducerName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ClosedColumn => this.columnClosed;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ProducerBusinessTypeIDColumn => this.columnProducerBusinessTypeID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsProducerExcelImport.dtProducersImporterRow this[int index]
    {
      get => (dsProducerExcelImport.dtProducersImporterRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsProducerExcelImport.dtProducersImporterRowChangeEventHandler dtProducersImporterRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsProducerExcelImport.dtProducersImporterRowChangeEventHandler dtProducersImporterRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsProducerExcelImport.dtProducersImporterRowChangeEventHandler dtProducersImporterRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsProducerExcelImport.dtProducersImporterRowChangeEventHandler dtProducersImporterRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AdddtProducersImporterRow(dsProducerExcelImport.dtProducersImporterRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsProducerExcelImport.dtProducersImporterRow AdddtProducersImporterRow(
      string ProducerGUID,
      string ProducerCode,
      string ProducerName,
      string Closed,
      string ProducerBusinessTypeID)
    {
      dsProducerExcelImport.dtProducersImporterRow row = (dsProducerExcelImport.dtProducersImporterRow) this.NewRow();
      object[] objArray = new object[5]
      {
        (object) ProducerGUID,
        (object) ProducerCode,
        (object) ProducerName,
        (object) Closed,
        (object) ProducerBusinessTypeID
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsProducerExcelImport.dtProducersImporterDataTable importerDataTable = (dsProducerExcelImport.dtProducersImporterDataTable) base.Clone();
      importerDataTable.InitVars();
      return (DataTable) importerDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsProducerExcelImport.dtProducersImporterDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnProducerGUID = this.Columns["ProducerGUID"];
      this.columnProducerCode = this.Columns["ProducerCode"];
      this.columnProducerName = this.Columns["ProducerName"];
      this.columnClosed = this.Columns["Closed"];
      this.columnProducerBusinessTypeID = this.Columns["ProducerBusinessTypeID"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnProducerGUID = new DataColumn("ProducerGUID", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnProducerGUID);
      this.columnProducerCode = new DataColumn("ProducerCode", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnProducerCode);
      this.columnProducerName = new DataColumn("ProducerName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnProducerName);
      this.columnClosed = new DataColumn("Closed", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnClosed);
      this.columnProducerBusinessTypeID = new DataColumn("ProducerBusinessTypeID", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnProducerBusinessTypeID);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsProducerExcelImport.dtProducersImporterRow NewdtProducersImporterRow()
    {
      return (dsProducerExcelImport.dtProducersImporterRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsProducerExcelImport.dtProducersImporterRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (dsProducerExcelImport.dtProducersImporterRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.dtProducersImporterRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProducerExcelImport.dtProducersImporterRowChangeEventHandler importerRowChangedEvent = this.dtProducersImporterRowChangedEvent;
      if (importerRowChangedEvent == null)
        return;
      importerRowChangedEvent((object) this, new dsProducerExcelImport.dtProducersImporterRowChangeEvent((dsProducerExcelImport.dtProducersImporterRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.dtProducersImporterRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProducerExcelImport.dtProducersImporterRowChangeEventHandler rowChangingEvent = this.dtProducersImporterRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsProducerExcelImport.dtProducersImporterRowChangeEvent((dsProducerExcelImport.dtProducersImporterRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.dtProducersImporterRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProducerExcelImport.dtProducersImporterRowChangeEventHandler importerRowDeletedEvent = this.dtProducersImporterRowDeletedEvent;
      if (importerRowDeletedEvent == null)
        return;
      importerRowDeletedEvent((object) this, new dsProducerExcelImport.dtProducersImporterRowChangeEvent((dsProducerExcelImport.dtProducersImporterRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.dtProducersImporterRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProducerExcelImport.dtProducersImporterRowChangeEventHandler rowDeletingEvent = this.dtProducersImporterRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsProducerExcelImport.dtProducersImporterRowChangeEvent((dsProducerExcelImport.dtProducersImporterRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemovedtProducersImporterRow(dsProducerExcelImport.dtProducersImporterRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsProducerExcelImport producerExcelImport = new dsProducerExcelImport();
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
        FixedValue = producerExcelImport.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (dtProducersImporterDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = producerExcelImport.GetSchemaSerializable();
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
  public class dtProducerLocationsImporterDataTable : 
    TypedTableBase<dsProducerExcelImport.dtProducerLocationsImporterRow>
  {
    private DataColumn columnProducerLocationID;
    private DataColumn columnProducerLocationGUID;
    private DataColumn columnLocationCode;
    private DataColumn columnProducerGUID;
    private DataColumn columnProducerTypeID;
    private DataColumn columnLocationTypeID;
    private DataColumn columnName;
    private DataColumn columnAddress1;
    private DataColumn columnAddress2;
    private DataColumn columnCity;
    private DataColumn columnCounty;
    private DataColumn columnState;
    private DataColumn columnRegion;
    private DataColumn columnISOCountryCode;
    private DataColumn columnZipCode;
    private DataColumn columnZipPlus;
    private DataColumn columnPhone;
    private DataColumn columnFax;
    private DataColumn columnFEIN;
    private DataColumn columnWebSite;
    private DataColumn columnEmail;
    private DataColumn columnDeliveryMethodID;
    private DataColumn columnDateAdded;
    private DataColumn columnStatusID;
    private DataColumn columnAllowAutomaticNOC;
    private DataColumn columnEmailReminders;
    private DataColumn columnBillToProducerLocationGuid;
    private DataColumn columnMailToProducerLocationGuid;
    private DataColumn columnProducerLocationRegion;
    private DataColumn columnStripFax;
    private DataColumn columnNumEmployees;
    private DataColumn columnGrossWrittenPremium;
    private DataColumn columnOptOut;
    private DataColumn columnProductionPotential;
    private DataColumn columnLocationSource;
    private DataColumn columnOwner;
    private DataColumn columnNumWholesaleRelationship;
    private DataColumn columnWholesaleRelationships;
    private DataColumn columnExpertise;
    private DataColumn columnSetProcedureToEnage;
    private DataColumn columnApproveWholesalersList;
    private DataColumn columnSpecFocusDept;
    private DataColumn columnAgreementEffectiveDate;
    private DataColumn columnProducerRankingID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dtProducerLocationsImporterDataTable()
    {
      this.TableName = "dtProducerLocationsImporter";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal dtProducerLocationsImporterDataTable(DataTable table)
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
    protected dtProducerLocationsImporterDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ProducerLocationIDColumn => this.columnProducerLocationID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ProducerLocationGUIDColumn => this.columnProducerLocationGUID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn LocationCodeColumn => this.columnLocationCode;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ProducerGUIDColumn => this.columnProducerGUID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ProducerTypeIDColumn => this.columnProducerTypeID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn LocationTypeIDColumn => this.columnLocationTypeID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn NameColumn => this.columnName;

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
    public DataColumn CountyColumn => this.columnCounty;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn StateColumn => this.columnState;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn RegionColumn => this.columnRegion;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ISOCountryCodeColumn => this.columnISOCountryCode;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ZipCodeColumn => this.columnZipCode;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ZipPlusColumn => this.columnZipPlus;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn PhoneColumn => this.columnPhone;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn FaxColumn => this.columnFax;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn FEINColumn => this.columnFEIN;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn WebSiteColumn => this.columnWebSite;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn EmailColumn => this.columnEmail;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn DeliveryMethodIDColumn => this.columnDeliveryMethodID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn DateAddedColumn => this.columnDateAdded;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn StatusIDColumn => this.columnStatusID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn AllowAutomaticNOCColumn => this.columnAllowAutomaticNOC;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn EmailRemindersColumn => this.columnEmailReminders;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn BillToProducerLocationGuidColumn => this.columnBillToProducerLocationGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn MailToProducerLocationGuidColumn => this.columnMailToProducerLocationGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ProducerLocationRegionColumn => this.columnProducerLocationRegion;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn StripFaxColumn => this.columnStripFax;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn NumEmployeesColumn => this.columnNumEmployees;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn GrossWrittenPremiumColumn => this.columnGrossWrittenPremium;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn OptOutColumn => this.columnOptOut;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ProductionPotentialColumn => this.columnProductionPotential;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn LocationSourceColumn => this.columnLocationSource;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn OwnerColumn => this.columnOwner;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn NumWholesaleRelationshipColumn => this.columnNumWholesaleRelationship;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn WholesaleRelationshipsColumn => this.columnWholesaleRelationships;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ExpertiseColumn => this.columnExpertise;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn SetProcedureToEnageColumn => this.columnSetProcedureToEnage;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ApproveWholesalersListColumn => this.columnApproveWholesalersList;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn SpecFocusDeptColumn => this.columnSpecFocusDept;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn AgreementEffectiveDateColumn => this.columnAgreementEffectiveDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ProducerRankingIDColumn => this.columnProducerRankingID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsProducerExcelImport.dtProducerLocationsImporterRow this[int index]
    {
      get => (dsProducerExcelImport.dtProducerLocationsImporterRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsProducerExcelImport.dtProducerLocationsImporterRowChangeEventHandler dtProducerLocationsImporterRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsProducerExcelImport.dtProducerLocationsImporterRowChangeEventHandler dtProducerLocationsImporterRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsProducerExcelImport.dtProducerLocationsImporterRowChangeEventHandler dtProducerLocationsImporterRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsProducerExcelImport.dtProducerLocationsImporterRowChangeEventHandler dtProducerLocationsImporterRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AdddtProducerLocationsImporterRow(
      dsProducerExcelImport.dtProducerLocationsImporterRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsProducerExcelImport.dtProducerLocationsImporterRow AdddtProducerLocationsImporterRow(
      string ProducerLocationID,
      string ProducerLocationGUID,
      string LocationCode,
      string ProducerGUID,
      string ProducerTypeID,
      string LocationTypeID,
      string Name,
      string Address1,
      string Address2,
      string City,
      string County,
      string State,
      string _Region,
      string ISOCountryCode,
      string ZipCode,
      string ZipPlus,
      string Phone,
      string Fax,
      string FEIN,
      string WebSite,
      string Email,
      string DeliveryMethodID,
      string DateAdded,
      string StatusID,
      string AllowAutomaticNOC,
      string EmailReminders,
      string BillToProducerLocationGuid,
      string MailToProducerLocationGuid,
      string ProducerLocationRegion,
      string StripFax,
      string NumEmployees,
      string GrossWrittenPremium,
      string OptOut,
      string ProductionPotential,
      string LocationSource,
      string Owner,
      string NumWholesaleRelationship,
      string WholesaleRelationships,
      string Expertise,
      string SetProcedureToEnage,
      string ApproveWholesalersList,
      string SpecFocusDept,
      string AgreementEffectiveDate,
      string ProducerRankingID)
    {
      dsProducerExcelImport.dtProducerLocationsImporterRow row = (dsProducerExcelImport.dtProducerLocationsImporterRow) this.NewRow();
      object[] objArray = new object[44]
      {
        (object) ProducerLocationID,
        (object) ProducerLocationGUID,
        (object) LocationCode,
        (object) ProducerGUID,
        (object) ProducerTypeID,
        (object) LocationTypeID,
        (object) Name,
        (object) Address1,
        (object) Address2,
        (object) City,
        (object) County,
        (object) State,
        (object) _Region,
        (object) ISOCountryCode,
        (object) ZipCode,
        (object) ZipPlus,
        (object) Phone,
        (object) Fax,
        (object) FEIN,
        (object) WebSite,
        (object) Email,
        (object) DeliveryMethodID,
        (object) DateAdded,
        (object) StatusID,
        (object) AllowAutomaticNOC,
        (object) EmailReminders,
        (object) BillToProducerLocationGuid,
        (object) MailToProducerLocationGuid,
        (object) ProducerLocationRegion,
        (object) StripFax,
        (object) NumEmployees,
        (object) GrossWrittenPremium,
        (object) OptOut,
        (object) ProductionPotential,
        (object) LocationSource,
        (object) Owner,
        (object) NumWholesaleRelationship,
        (object) WholesaleRelationships,
        (object) Expertise,
        (object) SetProcedureToEnage,
        (object) ApproveWholesalersList,
        (object) SpecFocusDept,
        (object) AgreementEffectiveDate,
        (object) ProducerRankingID
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsProducerExcelImport.dtProducerLocationsImporterDataTable importerDataTable = (dsProducerExcelImport.dtProducerLocationsImporterDataTable) base.Clone();
      importerDataTable.InitVars();
      return (DataTable) importerDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsProducerExcelImport.dtProducerLocationsImporterDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnProducerLocationID = this.Columns["ProducerLocationID"];
      this.columnProducerLocationGUID = this.Columns["ProducerLocationGUID"];
      this.columnLocationCode = this.Columns["LocationCode"];
      this.columnProducerGUID = this.Columns["ProducerGUID"];
      this.columnProducerTypeID = this.Columns["ProducerTypeID"];
      this.columnLocationTypeID = this.Columns["LocationTypeID"];
      this.columnName = this.Columns["Name"];
      this.columnAddress1 = this.Columns["Address1"];
      this.columnAddress2 = this.Columns["Address2"];
      this.columnCity = this.Columns["City"];
      this.columnCounty = this.Columns["County"];
      this.columnState = this.Columns["State"];
      this.columnRegion = this.Columns["Region"];
      this.columnISOCountryCode = this.Columns["ISOCountryCode"];
      this.columnZipCode = this.Columns["ZipCode"];
      this.columnZipPlus = this.Columns["ZipPlus"];
      this.columnPhone = this.Columns["Phone"];
      this.columnFax = this.Columns["Fax"];
      this.columnFEIN = this.Columns["FEIN"];
      this.columnWebSite = this.Columns["WebSite"];
      this.columnEmail = this.Columns["Email"];
      this.columnDeliveryMethodID = this.Columns["DeliveryMethodID"];
      this.columnDateAdded = this.Columns["DateAdded"];
      this.columnStatusID = this.Columns["StatusID"];
      this.columnAllowAutomaticNOC = this.Columns["AllowAutomaticNOC"];
      this.columnEmailReminders = this.Columns["EmailReminders"];
      this.columnBillToProducerLocationGuid = this.Columns["BillToProducerLocationGuid"];
      this.columnMailToProducerLocationGuid = this.Columns["MailToProducerLocationGuid"];
      this.columnProducerLocationRegion = this.Columns["ProducerLocationRegion"];
      this.columnStripFax = this.Columns["StripFax"];
      this.columnNumEmployees = this.Columns["NumEmployees"];
      this.columnGrossWrittenPremium = this.Columns["GrossWrittenPremium"];
      this.columnOptOut = this.Columns["OptOut"];
      this.columnProductionPotential = this.Columns["ProductionPotential"];
      this.columnLocationSource = this.Columns["LocationSource"];
      this.columnOwner = this.Columns["Owner"];
      this.columnNumWholesaleRelationship = this.Columns["NumWholesaleRelationship"];
      this.columnWholesaleRelationships = this.Columns["WholesaleRelationships"];
      this.columnExpertise = this.Columns["Expertise"];
      this.columnSetProcedureToEnage = this.Columns["SetProcedureToEnage"];
      this.columnApproveWholesalersList = this.Columns["ApproveWholesalersList"];
      this.columnSpecFocusDept = this.Columns["SpecFocusDept"];
      this.columnAgreementEffectiveDate = this.Columns["AgreementEffectiveDate"];
      this.columnProducerRankingID = this.Columns["ProducerRankingID"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnProducerLocationID = new DataColumn("ProducerLocationID", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnProducerLocationID);
      this.columnProducerLocationGUID = new DataColumn("ProducerLocationGUID", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnProducerLocationGUID);
      this.columnLocationCode = new DataColumn("LocationCode", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLocationCode);
      this.columnProducerGUID = new DataColumn("ProducerGUID", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnProducerGUID);
      this.columnProducerTypeID = new DataColumn("ProducerTypeID", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnProducerTypeID);
      this.columnLocationTypeID = new DataColumn("LocationTypeID", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLocationTypeID);
      this.columnName = new DataColumn("Name", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnName);
      this.columnAddress1 = new DataColumn("Address1", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAddress1);
      this.columnAddress2 = new DataColumn("Address2", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAddress2);
      this.columnCity = new DataColumn("City", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCity);
      this.columnCounty = new DataColumn("County", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCounty);
      this.columnState = new DataColumn("State", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnState);
      this.columnRegion = new DataColumn("Region", typeof (string), (string) null, MappingType.Element);
      this.columnRegion.ExtendedProperties.Add((object) "Generator_ColumnPropNameInTable", (object) "RegionColumn");
      this.columnRegion.ExtendedProperties.Add((object) "Generator_ColumnVarNameInTable", (object) "columnRegion");
      this.columnRegion.ExtendedProperties.Add((object) "Generator_UserColumnName", (object) "Region");
      this.Columns.Add(this.columnRegion);
      this.columnISOCountryCode = new DataColumn("ISOCountryCode", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnISOCountryCode);
      this.columnZipCode = new DataColumn("ZipCode", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnZipCode);
      this.columnZipPlus = new DataColumn("ZipPlus", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnZipPlus);
      this.columnPhone = new DataColumn("Phone", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPhone);
      this.columnFax = new DataColumn("Fax", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFax);
      this.columnFEIN = new DataColumn("FEIN", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFEIN);
      this.columnWebSite = new DataColumn("WebSite", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnWebSite);
      this.columnEmail = new DataColumn("Email", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEmail);
      this.columnDeliveryMethodID = new DataColumn("DeliveryMethodID", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDeliveryMethodID);
      this.columnDateAdded = new DataColumn("DateAdded", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDateAdded);
      this.columnStatusID = new DataColumn("StatusID", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnStatusID);
      this.columnAllowAutomaticNOC = new DataColumn("AllowAutomaticNOC", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAllowAutomaticNOC);
      this.columnEmailReminders = new DataColumn("EmailReminders", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEmailReminders);
      this.columnBillToProducerLocationGuid = new DataColumn("BillToProducerLocationGuid", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnBillToProducerLocationGuid);
      this.columnMailToProducerLocationGuid = new DataColumn("MailToProducerLocationGuid", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnMailToProducerLocationGuid);
      this.columnProducerLocationRegion = new DataColumn("ProducerLocationRegion", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnProducerLocationRegion);
      this.columnStripFax = new DataColumn("StripFax", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnStripFax);
      this.columnNumEmployees = new DataColumn("NumEmployees", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnNumEmployees);
      this.columnGrossWrittenPremium = new DataColumn("GrossWrittenPremium", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnGrossWrittenPremium);
      this.columnOptOut = new DataColumn("OptOut", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnOptOut);
      this.columnProductionPotential = new DataColumn("ProductionPotential", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnProductionPotential);
      this.columnLocationSource = new DataColumn("LocationSource", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLocationSource);
      this.columnOwner = new DataColumn("Owner", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnOwner);
      this.columnNumWholesaleRelationship = new DataColumn("NumWholesaleRelationship", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnNumWholesaleRelationship);
      this.columnWholesaleRelationships = new DataColumn("WholesaleRelationships", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnWholesaleRelationships);
      this.columnExpertise = new DataColumn("Expertise", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnExpertise);
      this.columnSetProcedureToEnage = new DataColumn("SetProcedureToEnage", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSetProcedureToEnage);
      this.columnApproveWholesalersList = new DataColumn("ApproveWholesalersList", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnApproveWholesalersList);
      this.columnSpecFocusDept = new DataColumn("SpecFocusDept", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSpecFocusDept);
      this.columnAgreementEffectiveDate = new DataColumn("AgreementEffectiveDate", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAgreementEffectiveDate);
      this.columnProducerRankingID = new DataColumn("ProducerRankingID", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnProducerRankingID);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsProducerExcelImport.dtProducerLocationsImporterRow NewdtProducerLocationsImporterRow()
    {
      return (dsProducerExcelImport.dtProducerLocationsImporterRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsProducerExcelImport.dtProducerLocationsImporterRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType()
    {
      return typeof (dsProducerExcelImport.dtProducerLocationsImporterRow);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.dtProducerLocationsImporterRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProducerExcelImport.dtProducerLocationsImporterRowChangeEventHandler importerRowChangedEvent = this.dtProducerLocationsImporterRowChangedEvent;
      if (importerRowChangedEvent == null)
        return;
      importerRowChangedEvent((object) this, new dsProducerExcelImport.dtProducerLocationsImporterRowChangeEvent((dsProducerExcelImport.dtProducerLocationsImporterRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.dtProducerLocationsImporterRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProducerExcelImport.dtProducerLocationsImporterRowChangeEventHandler rowChangingEvent = this.dtProducerLocationsImporterRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsProducerExcelImport.dtProducerLocationsImporterRowChangeEvent((dsProducerExcelImport.dtProducerLocationsImporterRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.dtProducerLocationsImporterRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProducerExcelImport.dtProducerLocationsImporterRowChangeEventHandler importerRowDeletedEvent = this.dtProducerLocationsImporterRowDeletedEvent;
      if (importerRowDeletedEvent == null)
        return;
      importerRowDeletedEvent((object) this, new dsProducerExcelImport.dtProducerLocationsImporterRowChangeEvent((dsProducerExcelImport.dtProducerLocationsImporterRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.dtProducerLocationsImporterRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsProducerExcelImport.dtProducerLocationsImporterRowChangeEventHandler rowDeletingEvent = this.dtProducerLocationsImporterRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsProducerExcelImport.dtProducerLocationsImporterRowChangeEvent((dsProducerExcelImport.dtProducerLocationsImporterRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemovedtProducerLocationsImporterRow(
      dsProducerExcelImport.dtProducerLocationsImporterRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsProducerExcelImport producerExcelImport = new dsProducerExcelImport();
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
        FixedValue = producerExcelImport.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (dtProducerLocationsImporterDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = producerExcelImport.GetSchemaSerializable();
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

  public class dtProducersImporterRow : DataRow
  {
    private dsProducerExcelImport.dtProducersImporterDataTable tabledtProducersImporter;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal dtProducersImporterRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabledtProducersImporter = (dsProducerExcelImport.dtProducersImporterDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string ProducerGUID
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtProducersImporter.ProducerGUIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ProducerGUID' in table 'dtProducersImporter' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtProducersImporter.ProducerGUIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string ProducerCode
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtProducersImporter.ProducerCodeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ProducerCode' in table 'dtProducersImporter' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtProducersImporter.ProducerCodeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string ProducerName
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtProducersImporter.ProducerNameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ProducerName' in table 'dtProducersImporter' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtProducersImporter.ProducerNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Closed
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtProducersImporter.ClosedColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Closed' in table 'dtProducersImporter' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtProducersImporter.ClosedColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string ProducerBusinessTypeID
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtProducersImporter.ProducerBusinessTypeIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ProducerBusinessTypeID' in table 'dtProducersImporter' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtProducersImporter.ProducerBusinessTypeIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsProducerGUIDNull()
    {
      return this.IsNull(this.tabledtProducersImporter.ProducerGUIDColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetProducerGUIDNull()
    {
      this[this.tabledtProducersImporter.ProducerGUIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsProducerCodeNull()
    {
      return this.IsNull(this.tabledtProducersImporter.ProducerCodeColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetProducerCodeNull()
    {
      this[this.tabledtProducersImporter.ProducerCodeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsProducerNameNull()
    {
      return this.IsNull(this.tabledtProducersImporter.ProducerNameColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetProducerNameNull()
    {
      this[this.tabledtProducersImporter.ProducerNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsClosedNull() => this.IsNull(this.tabledtProducersImporter.ClosedColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetClosedNull()
    {
      this[this.tabledtProducersImporter.ClosedColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsProducerBusinessTypeIDNull()
    {
      return this.IsNull(this.tabledtProducersImporter.ProducerBusinessTypeIDColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetProducerBusinessTypeIDNull()
    {
      this[this.tabledtProducersImporter.ProducerBusinessTypeIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class dtProducerLocationsImporterRow : DataRow
  {
    private dsProducerExcelImport.dtProducerLocationsImporterDataTable tabledtProducerLocationsImporter;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal dtProducerLocationsImporterRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabledtProducerLocationsImporter = (dsProducerExcelImport.dtProducerLocationsImporterDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string ProducerLocationID
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtProducerLocationsImporter.ProducerLocationIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ProducerLocationID' in table 'dtProducerLocationsImporter' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtProducerLocationsImporter.ProducerLocationIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string ProducerLocationGUID
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtProducerLocationsImporter.ProducerLocationGUIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ProducerLocationGUID' in table 'dtProducerLocationsImporter' is DBNull.", (Exception) ex);
        }
      }
      set
      {
        this[this.tabledtProducerLocationsImporter.ProducerLocationGUIDColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string LocationCode
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtProducerLocationsImporter.LocationCodeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'LocationCode' in table 'dtProducerLocationsImporter' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtProducerLocationsImporter.LocationCodeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string ProducerGUID
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtProducerLocationsImporter.ProducerGUIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ProducerGUID' in table 'dtProducerLocationsImporter' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtProducerLocationsImporter.ProducerGUIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string ProducerTypeID
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtProducerLocationsImporter.ProducerTypeIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ProducerTypeID' in table 'dtProducerLocationsImporter' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtProducerLocationsImporter.ProducerTypeIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string LocationTypeID
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtProducerLocationsImporter.LocationTypeIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'LocationTypeID' in table 'dtProducerLocationsImporter' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtProducerLocationsImporter.LocationTypeIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Name
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtProducerLocationsImporter.NameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Name' in table 'dtProducerLocationsImporter' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtProducerLocationsImporter.NameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Address1
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtProducerLocationsImporter.Address1Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Address1' in table 'dtProducerLocationsImporter' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtProducerLocationsImporter.Address1Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Address2
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtProducerLocationsImporter.Address2Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Address2' in table 'dtProducerLocationsImporter' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtProducerLocationsImporter.Address2Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string City
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtProducerLocationsImporter.CityColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'City' in table 'dtProducerLocationsImporter' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtProducerLocationsImporter.CityColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string County
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtProducerLocationsImporter.CountyColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'County' in table 'dtProducerLocationsImporter' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtProducerLocationsImporter.CountyColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string State
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtProducerLocationsImporter.StateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'State' in table 'dtProducerLocationsImporter' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtProducerLocationsImporter.StateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string _Region
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtProducerLocationsImporter.RegionColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Region' in table 'dtProducerLocationsImporter' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtProducerLocationsImporter.RegionColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string ISOCountryCode
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtProducerLocationsImporter.ISOCountryCodeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ISOCountryCode' in table 'dtProducerLocationsImporter' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtProducerLocationsImporter.ISOCountryCodeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string ZipCode
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtProducerLocationsImporter.ZipCodeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ZipCode' in table 'dtProducerLocationsImporter' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtProducerLocationsImporter.ZipCodeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string ZipPlus
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtProducerLocationsImporter.ZipPlusColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ZipPlus' in table 'dtProducerLocationsImporter' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtProducerLocationsImporter.ZipPlusColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Phone
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtProducerLocationsImporter.PhoneColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Phone' in table 'dtProducerLocationsImporter' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtProducerLocationsImporter.PhoneColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Fax
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtProducerLocationsImporter.FaxColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Fax' in table 'dtProducerLocationsImporter' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtProducerLocationsImporter.FaxColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string FEIN
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtProducerLocationsImporter.FEINColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'FEIN' in table 'dtProducerLocationsImporter' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtProducerLocationsImporter.FEINColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string WebSite
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtProducerLocationsImporter.WebSiteColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'WebSite' in table 'dtProducerLocationsImporter' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtProducerLocationsImporter.WebSiteColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Email
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtProducerLocationsImporter.EmailColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Email' in table 'dtProducerLocationsImporter' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtProducerLocationsImporter.EmailColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string DeliveryMethodID
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtProducerLocationsImporter.DeliveryMethodIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DeliveryMethodID' in table 'dtProducerLocationsImporter' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtProducerLocationsImporter.DeliveryMethodIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string DateAdded
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtProducerLocationsImporter.DateAddedColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DateAdded' in table 'dtProducerLocationsImporter' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtProducerLocationsImporter.DateAddedColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string StatusID
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtProducerLocationsImporter.StatusIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'StatusID' in table 'dtProducerLocationsImporter' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtProducerLocationsImporter.StatusIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string AllowAutomaticNOC
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtProducerLocationsImporter.AllowAutomaticNOCColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'AllowAutomaticNOC' in table 'dtProducerLocationsImporter' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtProducerLocationsImporter.AllowAutomaticNOCColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string EmailReminders
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtProducerLocationsImporter.EmailRemindersColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'EmailReminders' in table 'dtProducerLocationsImporter' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtProducerLocationsImporter.EmailRemindersColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string BillToProducerLocationGuid
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtProducerLocationsImporter.BillToProducerLocationGuidColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'BillToProducerLocationGuid' in table 'dtProducerLocationsImporter' is DBNull.", (Exception) ex);
        }
      }
      set
      {
        this[this.tabledtProducerLocationsImporter.BillToProducerLocationGuidColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string MailToProducerLocationGuid
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtProducerLocationsImporter.MailToProducerLocationGuidColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'MailToProducerLocationGuid' in table 'dtProducerLocationsImporter' is DBNull.", (Exception) ex);
        }
      }
      set
      {
        this[this.tabledtProducerLocationsImporter.MailToProducerLocationGuidColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string ProducerLocationRegion
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtProducerLocationsImporter.ProducerLocationRegionColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ProducerLocationRegion' in table 'dtProducerLocationsImporter' is DBNull.", (Exception) ex);
        }
      }
      set
      {
        this[this.tabledtProducerLocationsImporter.ProducerLocationRegionColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string StripFax
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtProducerLocationsImporter.StripFaxColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'StripFax' in table 'dtProducerLocationsImporter' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtProducerLocationsImporter.StripFaxColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string NumEmployees
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtProducerLocationsImporter.NumEmployeesColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'NumEmployees' in table 'dtProducerLocationsImporter' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtProducerLocationsImporter.NumEmployeesColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string GrossWrittenPremium
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtProducerLocationsImporter.GrossWrittenPremiumColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'GrossWrittenPremium' in table 'dtProducerLocationsImporter' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtProducerLocationsImporter.GrossWrittenPremiumColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string OptOut
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtProducerLocationsImporter.OptOutColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'OptOut' in table 'dtProducerLocationsImporter' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtProducerLocationsImporter.OptOutColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string ProductionPotential
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtProducerLocationsImporter.ProductionPotentialColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ProductionPotential' in table 'dtProducerLocationsImporter' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtProducerLocationsImporter.ProductionPotentialColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string LocationSource
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtProducerLocationsImporter.LocationSourceColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'LocationSource' in table 'dtProducerLocationsImporter' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtProducerLocationsImporter.LocationSourceColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Owner
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtProducerLocationsImporter.OwnerColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Owner' in table 'dtProducerLocationsImporter' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtProducerLocationsImporter.OwnerColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string NumWholesaleRelationship
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtProducerLocationsImporter.NumWholesaleRelationshipColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'NumWholesaleRelationship' in table 'dtProducerLocationsImporter' is DBNull.", (Exception) ex);
        }
      }
      set
      {
        this[this.tabledtProducerLocationsImporter.NumWholesaleRelationshipColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string WholesaleRelationships
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtProducerLocationsImporter.WholesaleRelationshipsColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'WholesaleRelationships' in table 'dtProducerLocationsImporter' is DBNull.", (Exception) ex);
        }
      }
      set
      {
        this[this.tabledtProducerLocationsImporter.WholesaleRelationshipsColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Expertise
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtProducerLocationsImporter.ExpertiseColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Expertise' in table 'dtProducerLocationsImporter' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtProducerLocationsImporter.ExpertiseColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string SetProcedureToEnage
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtProducerLocationsImporter.SetProcedureToEnageColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'SetProcedureToEnage' in table 'dtProducerLocationsImporter' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtProducerLocationsImporter.SetProcedureToEnageColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string ApproveWholesalersList
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtProducerLocationsImporter.ApproveWholesalersListColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ApproveWholesalersList' in table 'dtProducerLocationsImporter' is DBNull.", (Exception) ex);
        }
      }
      set
      {
        this[this.tabledtProducerLocationsImporter.ApproveWholesalersListColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string SpecFocusDept
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtProducerLocationsImporter.SpecFocusDeptColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'SpecFocusDept' in table 'dtProducerLocationsImporter' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtProducerLocationsImporter.SpecFocusDeptColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string AgreementEffectiveDate
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtProducerLocationsImporter.AgreementEffectiveDateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'AgreementEffectiveDate' in table 'dtProducerLocationsImporter' is DBNull.", (Exception) ex);
        }
      }
      set
      {
        this[this.tabledtProducerLocationsImporter.AgreementEffectiveDateColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string ProducerRankingID
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtProducerLocationsImporter.ProducerRankingIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ProducerRankingID' in table 'dtProducerLocationsImporter' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtProducerLocationsImporter.ProducerRankingIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsProducerLocationIDNull()
    {
      return this.IsNull(this.tabledtProducerLocationsImporter.ProducerLocationIDColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetProducerLocationIDNull()
    {
      this[this.tabledtProducerLocationsImporter.ProducerLocationIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsProducerLocationGUIDNull()
    {
      return this.IsNull(this.tabledtProducerLocationsImporter.ProducerLocationGUIDColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetProducerLocationGUIDNull()
    {
      this[this.tabledtProducerLocationsImporter.ProducerLocationGUIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsLocationCodeNull()
    {
      return this.IsNull(this.tabledtProducerLocationsImporter.LocationCodeColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetLocationCodeNull()
    {
      this[this.tabledtProducerLocationsImporter.LocationCodeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsProducerGUIDNull()
    {
      return this.IsNull(this.tabledtProducerLocationsImporter.ProducerGUIDColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetProducerGUIDNull()
    {
      this[this.tabledtProducerLocationsImporter.ProducerGUIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsProducerTypeIDNull()
    {
      return this.IsNull(this.tabledtProducerLocationsImporter.ProducerTypeIDColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetProducerTypeIDNull()
    {
      this[this.tabledtProducerLocationsImporter.ProducerTypeIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsLocationTypeIDNull()
    {
      return this.IsNull(this.tabledtProducerLocationsImporter.LocationTypeIDColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetLocationTypeIDNull()
    {
      this[this.tabledtProducerLocationsImporter.LocationTypeIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsNameNull() => this.IsNull(this.tabledtProducerLocationsImporter.NameColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetNameNull()
    {
      this[this.tabledtProducerLocationsImporter.NameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsAddress1Null()
    {
      return this.IsNull(this.tabledtProducerLocationsImporter.Address1Column);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetAddress1Null()
    {
      this[this.tabledtProducerLocationsImporter.Address1Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsAddress2Null()
    {
      return this.IsNull(this.tabledtProducerLocationsImporter.Address2Column);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetAddress2Null()
    {
      this[this.tabledtProducerLocationsImporter.Address2Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsCityNull() => this.IsNull(this.tabledtProducerLocationsImporter.CityColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetCityNull()
    {
      this[this.tabledtProducerLocationsImporter.CityColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsCountyNull() => this.IsNull(this.tabledtProducerLocationsImporter.CountyColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetCountyNull()
    {
      this[this.tabledtProducerLocationsImporter.CountyColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsStateNull() => this.IsNull(this.tabledtProducerLocationsImporter.StateColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetStateNull()
    {
      this[this.tabledtProducerLocationsImporter.StateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool Is_RegionNull() => this.IsNull(this.tabledtProducerLocationsImporter.RegionColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void Set_RegionNull()
    {
      this[this.tabledtProducerLocationsImporter.RegionColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsISOCountryCodeNull()
    {
      return this.IsNull(this.tabledtProducerLocationsImporter.ISOCountryCodeColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetISOCountryCodeNull()
    {
      this[this.tabledtProducerLocationsImporter.ISOCountryCodeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsZipCodeNull() => this.IsNull(this.tabledtProducerLocationsImporter.ZipCodeColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetZipCodeNull()
    {
      this[this.tabledtProducerLocationsImporter.ZipCodeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsZipPlusNull() => this.IsNull(this.tabledtProducerLocationsImporter.ZipPlusColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetZipPlusNull()
    {
      this[this.tabledtProducerLocationsImporter.ZipPlusColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsPhoneNull() => this.IsNull(this.tabledtProducerLocationsImporter.PhoneColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetPhoneNull()
    {
      this[this.tabledtProducerLocationsImporter.PhoneColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsFaxNull() => this.IsNull(this.tabledtProducerLocationsImporter.FaxColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetFaxNull()
    {
      this[this.tabledtProducerLocationsImporter.FaxColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsFEINNull() => this.IsNull(this.tabledtProducerLocationsImporter.FEINColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetFEINNull()
    {
      this[this.tabledtProducerLocationsImporter.FEINColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsWebSiteNull() => this.IsNull(this.tabledtProducerLocationsImporter.WebSiteColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetWebSiteNull()
    {
      this[this.tabledtProducerLocationsImporter.WebSiteColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsEmailNull() => this.IsNull(this.tabledtProducerLocationsImporter.EmailColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetEmailNull()
    {
      this[this.tabledtProducerLocationsImporter.EmailColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsDeliveryMethodIDNull()
    {
      return this.IsNull(this.tabledtProducerLocationsImporter.DeliveryMethodIDColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetDeliveryMethodIDNull()
    {
      this[this.tabledtProducerLocationsImporter.DeliveryMethodIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsDateAddedNull()
    {
      return this.IsNull(this.tabledtProducerLocationsImporter.DateAddedColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetDateAddedNull()
    {
      this[this.tabledtProducerLocationsImporter.DateAddedColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsStatusIDNull()
    {
      return this.IsNull(this.tabledtProducerLocationsImporter.StatusIDColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetStatusIDNull()
    {
      this[this.tabledtProducerLocationsImporter.StatusIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsAllowAutomaticNOCNull()
    {
      return this.IsNull(this.tabledtProducerLocationsImporter.AllowAutomaticNOCColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetAllowAutomaticNOCNull()
    {
      this[this.tabledtProducerLocationsImporter.AllowAutomaticNOCColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsEmailRemindersNull()
    {
      return this.IsNull(this.tabledtProducerLocationsImporter.EmailRemindersColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetEmailRemindersNull()
    {
      this[this.tabledtProducerLocationsImporter.EmailRemindersColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsBillToProducerLocationGuidNull()
    {
      return this.IsNull(this.tabledtProducerLocationsImporter.BillToProducerLocationGuidColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetBillToProducerLocationGuidNull()
    {
      this[this.tabledtProducerLocationsImporter.BillToProducerLocationGuidColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsMailToProducerLocationGuidNull()
    {
      return this.IsNull(this.tabledtProducerLocationsImporter.MailToProducerLocationGuidColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetMailToProducerLocationGuidNull()
    {
      this[this.tabledtProducerLocationsImporter.MailToProducerLocationGuidColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsProducerLocationRegionNull()
    {
      return this.IsNull(this.tabledtProducerLocationsImporter.ProducerLocationRegionColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetProducerLocationRegionNull()
    {
      this[this.tabledtProducerLocationsImporter.ProducerLocationRegionColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsStripFaxNull()
    {
      return this.IsNull(this.tabledtProducerLocationsImporter.StripFaxColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetStripFaxNull()
    {
      this[this.tabledtProducerLocationsImporter.StripFaxColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsNumEmployeesNull()
    {
      return this.IsNull(this.tabledtProducerLocationsImporter.NumEmployeesColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetNumEmployeesNull()
    {
      this[this.tabledtProducerLocationsImporter.NumEmployeesColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsGrossWrittenPremiumNull()
    {
      return this.IsNull(this.tabledtProducerLocationsImporter.GrossWrittenPremiumColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetGrossWrittenPremiumNull()
    {
      this[this.tabledtProducerLocationsImporter.GrossWrittenPremiumColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsOptOutNull() => this.IsNull(this.tabledtProducerLocationsImporter.OptOutColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetOptOutNull()
    {
      this[this.tabledtProducerLocationsImporter.OptOutColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsProductionPotentialNull()
    {
      return this.IsNull(this.tabledtProducerLocationsImporter.ProductionPotentialColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetProductionPotentialNull()
    {
      this[this.tabledtProducerLocationsImporter.ProductionPotentialColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsLocationSourceNull()
    {
      return this.IsNull(this.tabledtProducerLocationsImporter.LocationSourceColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetLocationSourceNull()
    {
      this[this.tabledtProducerLocationsImporter.LocationSourceColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsOwnerNull() => this.IsNull(this.tabledtProducerLocationsImporter.OwnerColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetOwnerNull()
    {
      this[this.tabledtProducerLocationsImporter.OwnerColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsNumWholesaleRelationshipNull()
    {
      return this.IsNull(this.tabledtProducerLocationsImporter.NumWholesaleRelationshipColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetNumWholesaleRelationshipNull()
    {
      this[this.tabledtProducerLocationsImporter.NumWholesaleRelationshipColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsWholesaleRelationshipsNull()
    {
      return this.IsNull(this.tabledtProducerLocationsImporter.WholesaleRelationshipsColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetWholesaleRelationshipsNull()
    {
      this[this.tabledtProducerLocationsImporter.WholesaleRelationshipsColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsExpertiseNull()
    {
      return this.IsNull(this.tabledtProducerLocationsImporter.ExpertiseColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetExpertiseNull()
    {
      this[this.tabledtProducerLocationsImporter.ExpertiseColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsSetProcedureToEnageNull()
    {
      return this.IsNull(this.tabledtProducerLocationsImporter.SetProcedureToEnageColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetSetProcedureToEnageNull()
    {
      this[this.tabledtProducerLocationsImporter.SetProcedureToEnageColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsApproveWholesalersListNull()
    {
      return this.IsNull(this.tabledtProducerLocationsImporter.ApproveWholesalersListColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetApproveWholesalersListNull()
    {
      this[this.tabledtProducerLocationsImporter.ApproveWholesalersListColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsSpecFocusDeptNull()
    {
      return this.IsNull(this.tabledtProducerLocationsImporter.SpecFocusDeptColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetSpecFocusDeptNull()
    {
      this[this.tabledtProducerLocationsImporter.SpecFocusDeptColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsAgreementEffectiveDateNull()
    {
      return this.IsNull(this.tabledtProducerLocationsImporter.AgreementEffectiveDateColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetAgreementEffectiveDateNull()
    {
      this[this.tabledtProducerLocationsImporter.AgreementEffectiveDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsProducerRankingIDNull()
    {
      return this.IsNull(this.tabledtProducerLocationsImporter.ProducerRankingIDColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetProducerRankingIDNull()
    {
      this[this.tabledtProducerLocationsImporter.ProducerRankingIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class dtProducersImporterRowChangeEvent : EventArgs
  {
    private dsProducerExcelImport.dtProducersImporterRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dtProducersImporterRowChangeEvent(
      dsProducerExcelImport.dtProducersImporterRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsProducerExcelImport.dtProducersImporterRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class dtProducerLocationsImporterRowChangeEvent : EventArgs
  {
    private dsProducerExcelImport.dtProducerLocationsImporterRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dtProducerLocationsImporterRowChangeEvent(
      dsProducerExcelImport.dtProducerLocationsImporterRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsProducerExcelImport.dtProducerLocationsImporterRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }
}
