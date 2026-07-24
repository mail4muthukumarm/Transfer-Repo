// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Forms.TestQuoteDocsData
// Assembly: MgaSystems.IMS.Forms, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FB3F392E-40B6-486F-8F0B-A4A494A546D4
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Forms.dll

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
namespace MGASystems.IMS.Forms;

[DesignerCategory("code")]
[ToolboxItem(true)]
[XmlSchemaProvider("GetTypedDataSetSchema")]
[XmlRoot("TestQuoteDocsData")]
[HelpKeyword("vs.data.DataSet")]
[Serializable]
public class TestQuoteDocsData : DataSet
{
  private TestQuoteDocsData.AutomationDocumentsDataTable tableAutomationDocuments;
  private TestQuoteDocsData.PropertiesDataTable tableProperties;
  private TestQuoteDocsData.LookUpStringsDataTable tableLookUpStrings;
  private SchemaSerializationMode _schemaSerializationMode;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  public TestQuoteDocsData()
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
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  protected TestQuoteDocsData(SerializationInfo info, StreamingContext context)
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
        if (dataSet.Tables[nameof (AutomationDocuments)] != null)
          base.Tables.Add((DataTable) new TestQuoteDocsData.AutomationDocumentsDataTable(dataSet.Tables[nameof (AutomationDocuments)]));
        if (dataSet.Tables[nameof (Properties)] != null)
          base.Tables.Add((DataTable) new TestQuoteDocsData.PropertiesDataTable(dataSet.Tables[nameof (Properties)]));
        if (dataSet.Tables[nameof (LookUpStrings)] != null)
          base.Tables.Add((DataTable) new TestQuoteDocsData.LookUpStringsDataTable(dataSet.Tables[nameof (LookUpStrings)]));
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
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public TestQuoteDocsData.AutomationDocumentsDataTable AutomationDocuments
  {
    get => this.tableAutomationDocuments;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public TestQuoteDocsData.PropertiesDataTable Properties => this.tableProperties;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public TestQuoteDocsData.LookUpStringsDataTable LookUpStrings => this.tableLookUpStrings;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  [Browsable(true)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
  public override SchemaSerializationMode SchemaSerializationMode
  {
    get => this._schemaSerializationMode;
    set => this._schemaSerializationMode = value;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public new DataTableCollection Tables => base.Tables;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public new DataRelationCollection Relations => base.Relations;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  protected override void InitializeDerivedDataSet()
  {
    this.BeginInit();
    this.InitClass();
    this.EndInit();
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  public override DataSet Clone()
  {
    TestQuoteDocsData testQuoteDocsData = (TestQuoteDocsData) base.Clone();
    testQuoteDocsData.InitVars();
    testQuoteDocsData.SchemaSerializationMode = this.SchemaSerializationMode;
    return (DataSet) testQuoteDocsData;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  protected override bool ShouldSerializeTables() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  protected override bool ShouldSerializeRelations() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  protected override void ReadXmlSerializable(XmlReader reader)
  {
    if (this.DetermineSchemaSerializationMode(reader) == SchemaSerializationMode.IncludeSchema)
    {
      this.Reset();
      DataSet dataSet = new DataSet();
      int num = (int) dataSet.ReadXml(reader);
      if (dataSet.Tables["AutomationDocuments"] != null)
        base.Tables.Add((DataTable) new TestQuoteDocsData.AutomationDocumentsDataTable(dataSet.Tables["AutomationDocuments"]));
      if (dataSet.Tables["Properties"] != null)
        base.Tables.Add((DataTable) new TestQuoteDocsData.PropertiesDataTable(dataSet.Tables["Properties"]));
      if (dataSet.Tables["LookUpStrings"] != null)
        base.Tables.Add((DataTable) new TestQuoteDocsData.LookUpStringsDataTable(dataSet.Tables["LookUpStrings"]));
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
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  protected override XmlSchema GetSchemaSerializable()
  {
    MemoryStream memoryStream = new MemoryStream();
    this.WriteXmlSchema((XmlWriter) new XmlTextWriter((Stream) memoryStream, (Encoding) null));
    memoryStream.Position = 0L;
    return XmlSchema.Read((XmlReader) new XmlTextReader((Stream) memoryStream), (ValidationEventHandler) null);
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  internal void InitVars() => this.InitVars(true);

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  internal void InitVars(bool initTable)
  {
    this.tableAutomationDocuments = (TestQuoteDocsData.AutomationDocumentsDataTable) base.Tables["AutomationDocuments"];
    if (initTable && this.tableAutomationDocuments != null)
      this.tableAutomationDocuments.InitVars();
    this.tableProperties = (TestQuoteDocsData.PropertiesDataTable) base.Tables["Properties"];
    if (initTable && this.tableProperties != null)
      this.tableProperties.InitVars();
    this.tableLookUpStrings = (TestQuoteDocsData.LookUpStringsDataTable) base.Tables["LookUpStrings"];
    if (!initTable || this.tableLookUpStrings == null)
      return;
    this.tableLookUpStrings.InitVars();
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  private void InitClass()
  {
    this.DataSetName = nameof (TestQuoteDocsData);
    this.Prefix = "";
    this.Namespace = "http://tempuri.org/TestQuoteDocs.xsd";
    this.EnforceConstraints = true;
    this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.tableAutomationDocuments = new TestQuoteDocsData.AutomationDocumentsDataTable();
    base.Tables.Add((DataTable) this.tableAutomationDocuments);
    this.tableProperties = new TestQuoteDocsData.PropertiesDataTable();
    base.Tables.Add((DataTable) this.tableProperties);
    this.tableLookUpStrings = new TestQuoteDocsData.LookUpStringsDataTable();
    base.Tables.Add((DataTable) this.tableLookUpStrings);
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  private bool ShouldSerializeAutomationDocuments() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  private bool ShouldSerializeProperties() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  private bool ShouldSerializeLookUpStrings() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  private void SchemaChanged(object sender, CollectionChangeEventArgs e)
  {
    if (e.Action != CollectionChangeAction.Remove)
      return;
    this.InitVars();
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  public static XmlSchemaComplexType GetTypedDataSetSchema(XmlSchemaSet xs)
  {
    TestQuoteDocsData testQuoteDocsData = new TestQuoteDocsData();
    XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
    schemaComplexType.Particle = (XmlSchemaParticle) new XmlSchemaSequence()
    {
      Items = {
        (XmlSchemaObject) new XmlSchemaAny()
        {
          Namespace = testQuoteDocsData.Namespace
        }
      }
    };
    XmlSchema schemaSerializable = testQuoteDocsData.GetSchemaSerializable();
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

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  public delegate void AutomationDocumentsRowChangeEventHandler(
    object sender,
    TestQuoteDocsData.AutomationDocumentsRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  public delegate void PropertiesRowChangeEventHandler(
    object sender,
    TestQuoteDocsData.PropertiesRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  public delegate void LookUpStringsRowChangeEventHandler(
    object sender,
    TestQuoteDocsData.LookUpStringsRowChangeEvent e);

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class AutomationDocumentsDataTable : 
    TypedTableBase<TestQuoteDocsData.AutomationDocumentsRow>
  {
    private DataColumn columnAutomationDocumentID;
    private DataColumn columnName;
    private DataColumn columnTypeName;
    private DataColumn columnDescription;
    private DataColumn columnType;
    private DataColumn columnDocumentType;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public AutomationDocumentsDataTable()
    {
      this.TableName = "AutomationDocuments";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal AutomationDocumentsDataTable(DataTable table)
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected AutomationDocumentsDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn AutomationDocumentIDColumn => this.columnAutomationDocumentID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn NameColumn => this.columnName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn TypeNameColumn => this.columnTypeName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn DescriptionColumn => this.columnDescription;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn TypeColumn => this.columnType;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn DocumentTypeColumn => this.columnDocumentType;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public TestQuoteDocsData.AutomationDocumentsRow this[int index]
    {
      get => (TestQuoteDocsData.AutomationDocumentsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event TestQuoteDocsData.AutomationDocumentsRowChangeEventHandler AutomationDocumentsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event TestQuoteDocsData.AutomationDocumentsRowChangeEventHandler AutomationDocumentsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event TestQuoteDocsData.AutomationDocumentsRowChangeEventHandler AutomationDocumentsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event TestQuoteDocsData.AutomationDocumentsRowChangeEventHandler AutomationDocumentsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void AddAutomationDocumentsRow(TestQuoteDocsData.AutomationDocumentsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public TestQuoteDocsData.AutomationDocumentsRow AddAutomationDocumentsRow(
      string AutomationDocumentID,
      string Name,
      string TypeName,
      string Description,
      object Type,
      string DocumentType)
    {
      TestQuoteDocsData.AutomationDocumentsRow row = (TestQuoteDocsData.AutomationDocumentsRow) this.NewRow();
      object[] objArray = new object[6]
      {
        (object) AutomationDocumentID,
        (object) Name,
        (object) TypeName,
        (object) Description,
        Type,
        (object) DocumentType
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public override DataTable Clone()
    {
      TestQuoteDocsData.AutomationDocumentsDataTable documentsDataTable = (TestQuoteDocsData.AutomationDocumentsDataTable) base.Clone();
      documentsDataTable.InitVars();
      return (DataTable) documentsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new TestQuoteDocsData.AutomationDocumentsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal void InitVars()
    {
      this.columnAutomationDocumentID = this.Columns["AutomationDocumentID"];
      this.columnName = this.Columns["Name"];
      this.columnTypeName = this.Columns["TypeName"];
      this.columnDescription = this.Columns["Description"];
      this.columnType = this.Columns["Type"];
      this.columnDocumentType = this.Columns["DocumentType"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    private void InitClass()
    {
      this.columnAutomationDocumentID = new DataColumn("AutomationDocumentID", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAutomationDocumentID);
      this.columnName = new DataColumn("Name", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnName);
      this.columnTypeName = new DataColumn("TypeName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnTypeName);
      this.columnDescription = new DataColumn("Description", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDescription);
      this.columnType = new DataColumn("Type", typeof (object), (string) null, MappingType.Element);
      this.Columns.Add(this.columnType);
      this.columnDocumentType = new DataColumn("DocumentType", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDocumentType);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public TestQuoteDocsData.AutomationDocumentsRow NewAutomationDocumentsRow()
    {
      return (TestQuoteDocsData.AutomationDocumentsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new TestQuoteDocsData.AutomationDocumentsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override Type GetRowType() => typeof (TestQuoteDocsData.AutomationDocumentsRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.AutomationDocumentsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      TestQuoteDocsData.AutomationDocumentsRowChangeEventHandler documentsRowChangedEvent = this.AutomationDocumentsRowChangedEvent;
      if (documentsRowChangedEvent == null)
        return;
      documentsRowChangedEvent((object) this, new TestQuoteDocsData.AutomationDocumentsRowChangeEvent((TestQuoteDocsData.AutomationDocumentsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.AutomationDocumentsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      TestQuoteDocsData.AutomationDocumentsRowChangeEventHandler rowChangingEvent = this.AutomationDocumentsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new TestQuoteDocsData.AutomationDocumentsRowChangeEvent((TestQuoteDocsData.AutomationDocumentsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.AutomationDocumentsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      TestQuoteDocsData.AutomationDocumentsRowChangeEventHandler documentsRowDeletedEvent = this.AutomationDocumentsRowDeletedEvent;
      if (documentsRowDeletedEvent == null)
        return;
      documentsRowDeletedEvent((object) this, new TestQuoteDocsData.AutomationDocumentsRowChangeEvent((TestQuoteDocsData.AutomationDocumentsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.AutomationDocumentsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      TestQuoteDocsData.AutomationDocumentsRowChangeEventHandler rowDeletingEvent = this.AutomationDocumentsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new TestQuoteDocsData.AutomationDocumentsRowChangeEvent((TestQuoteDocsData.AutomationDocumentsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void RemoveAutomationDocumentsRow(TestQuoteDocsData.AutomationDocumentsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      TestQuoteDocsData testQuoteDocsData = new TestQuoteDocsData();
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
        FixedValue = testQuoteDocsData.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (AutomationDocumentsDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = testQuoteDocsData.GetSchemaSerializable();
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
  public class PropertiesDataTable : TypedTableBase<TestQuoteDocsData.PropertiesRow>
  {
    private DataColumn columnAutomationDocumentID;
    private DataColumn columnPropertyName;
    private DataColumn columnPropertyValue;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public PropertiesDataTable()
    {
      this.TableName = "Properties";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal PropertiesDataTable(DataTable table)
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected PropertiesDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn AutomationDocumentIDColumn => this.columnAutomationDocumentID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn PropertyNameColumn => this.columnPropertyName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn PropertyValueColumn => this.columnPropertyValue;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public TestQuoteDocsData.PropertiesRow this[int index]
    {
      get => (TestQuoteDocsData.PropertiesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event TestQuoteDocsData.PropertiesRowChangeEventHandler PropertiesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event TestQuoteDocsData.PropertiesRowChangeEventHandler PropertiesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event TestQuoteDocsData.PropertiesRowChangeEventHandler PropertiesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event TestQuoteDocsData.PropertiesRowChangeEventHandler PropertiesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void AddPropertiesRow(TestQuoteDocsData.PropertiesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public TestQuoteDocsData.PropertiesRow AddPropertiesRow(
      string AutomationDocumentID,
      string PropertyName,
      string PropertyValue)
    {
      TestQuoteDocsData.PropertiesRow row = (TestQuoteDocsData.PropertiesRow) this.NewRow();
      object[] objArray = new object[3]
      {
        (object) AutomationDocumentID,
        (object) PropertyName,
        (object) PropertyValue
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public override DataTable Clone()
    {
      TestQuoteDocsData.PropertiesDataTable propertiesDataTable = (TestQuoteDocsData.PropertiesDataTable) base.Clone();
      propertiesDataTable.InitVars();
      return (DataTable) propertiesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new TestQuoteDocsData.PropertiesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal void InitVars()
    {
      this.columnAutomationDocumentID = this.Columns["AutomationDocumentID"];
      this.columnPropertyName = this.Columns["PropertyName"];
      this.columnPropertyValue = this.Columns["PropertyValue"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    private void InitClass()
    {
      this.columnAutomationDocumentID = new DataColumn("AutomationDocumentID", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAutomationDocumentID);
      this.columnPropertyName = new DataColumn("PropertyName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPropertyName);
      this.columnPropertyValue = new DataColumn("PropertyValue", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPropertyValue);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public TestQuoteDocsData.PropertiesRow NewPropertiesRow()
    {
      return (TestQuoteDocsData.PropertiesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new TestQuoteDocsData.PropertiesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override Type GetRowType() => typeof (TestQuoteDocsData.PropertiesRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.PropertiesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      TestQuoteDocsData.PropertiesRowChangeEventHandler propertiesRowChangedEvent = this.PropertiesRowChangedEvent;
      if (propertiesRowChangedEvent == null)
        return;
      propertiesRowChangedEvent((object) this, new TestQuoteDocsData.PropertiesRowChangeEvent((TestQuoteDocsData.PropertiesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.PropertiesRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      TestQuoteDocsData.PropertiesRowChangeEventHandler rowChangingEvent = this.PropertiesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new TestQuoteDocsData.PropertiesRowChangeEvent((TestQuoteDocsData.PropertiesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.PropertiesRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      TestQuoteDocsData.PropertiesRowChangeEventHandler propertiesRowDeletedEvent = this.PropertiesRowDeletedEvent;
      if (propertiesRowDeletedEvent == null)
        return;
      propertiesRowDeletedEvent((object) this, new TestQuoteDocsData.PropertiesRowChangeEvent((TestQuoteDocsData.PropertiesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.PropertiesRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      TestQuoteDocsData.PropertiesRowChangeEventHandler rowDeletingEvent = this.PropertiesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new TestQuoteDocsData.PropertiesRowChangeEvent((TestQuoteDocsData.PropertiesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void RemovePropertiesRow(TestQuoteDocsData.PropertiesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      TestQuoteDocsData testQuoteDocsData = new TestQuoteDocsData();
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
        FixedValue = testQuoteDocsData.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (PropertiesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = testQuoteDocsData.GetSchemaSerializable();
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
  public class LookUpStringsDataTable : TypedTableBase<TestQuoteDocsData.LookUpStringsRow>
  {
    private DataColumn columnAutomationDocumentID;
    private DataColumn columnSearchString;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public LookUpStringsDataTable()
    {
      this.TableName = "LookUpStrings";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal LookUpStringsDataTable(DataTable table)
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected LookUpStringsDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn AutomationDocumentIDColumn => this.columnAutomationDocumentID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn SearchStringColumn => this.columnSearchString;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public TestQuoteDocsData.LookUpStringsRow this[int index]
    {
      get => (TestQuoteDocsData.LookUpStringsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event TestQuoteDocsData.LookUpStringsRowChangeEventHandler LookUpStringsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event TestQuoteDocsData.LookUpStringsRowChangeEventHandler LookUpStringsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event TestQuoteDocsData.LookUpStringsRowChangeEventHandler LookUpStringsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event TestQuoteDocsData.LookUpStringsRowChangeEventHandler LookUpStringsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void AddLookUpStringsRow(TestQuoteDocsData.LookUpStringsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public TestQuoteDocsData.LookUpStringsRow AddLookUpStringsRow(
      string AutomationDocumentID,
      string SearchString)
    {
      TestQuoteDocsData.LookUpStringsRow row = (TestQuoteDocsData.LookUpStringsRow) this.NewRow();
      object[] objArray = new object[2]
      {
        (object) AutomationDocumentID,
        (object) SearchString
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public override DataTable Clone()
    {
      TestQuoteDocsData.LookUpStringsDataTable stringsDataTable = (TestQuoteDocsData.LookUpStringsDataTable) base.Clone();
      stringsDataTable.InitVars();
      return (DataTable) stringsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new TestQuoteDocsData.LookUpStringsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal void InitVars()
    {
      this.columnAutomationDocumentID = this.Columns["AutomationDocumentID"];
      this.columnSearchString = this.Columns["SearchString"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    private void InitClass()
    {
      this.columnAutomationDocumentID = new DataColumn("AutomationDocumentID", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAutomationDocumentID);
      this.columnSearchString = new DataColumn("SearchString", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSearchString);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public TestQuoteDocsData.LookUpStringsRow NewLookUpStringsRow()
    {
      return (TestQuoteDocsData.LookUpStringsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new TestQuoteDocsData.LookUpStringsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override Type GetRowType() => typeof (TestQuoteDocsData.LookUpStringsRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.LookUpStringsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      TestQuoteDocsData.LookUpStringsRowChangeEventHandler stringsRowChangedEvent = this.LookUpStringsRowChangedEvent;
      if (stringsRowChangedEvent == null)
        return;
      stringsRowChangedEvent((object) this, new TestQuoteDocsData.LookUpStringsRowChangeEvent((TestQuoteDocsData.LookUpStringsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.LookUpStringsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      TestQuoteDocsData.LookUpStringsRowChangeEventHandler rowChangingEvent = this.LookUpStringsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new TestQuoteDocsData.LookUpStringsRowChangeEvent((TestQuoteDocsData.LookUpStringsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.LookUpStringsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      TestQuoteDocsData.LookUpStringsRowChangeEventHandler stringsRowDeletedEvent = this.LookUpStringsRowDeletedEvent;
      if (stringsRowDeletedEvent == null)
        return;
      stringsRowDeletedEvent((object) this, new TestQuoteDocsData.LookUpStringsRowChangeEvent((TestQuoteDocsData.LookUpStringsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.LookUpStringsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      TestQuoteDocsData.LookUpStringsRowChangeEventHandler rowDeletingEvent = this.LookUpStringsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new TestQuoteDocsData.LookUpStringsRowChangeEvent((TestQuoteDocsData.LookUpStringsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void RemoveLookUpStringsRow(TestQuoteDocsData.LookUpStringsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      TestQuoteDocsData testQuoteDocsData = new TestQuoteDocsData();
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
        FixedValue = testQuoteDocsData.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (LookUpStringsDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = testQuoteDocsData.GetSchemaSerializable();
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

  public class AutomationDocumentsRow : DataRow
  {
    private TestQuoteDocsData.AutomationDocumentsDataTable tableAutomationDocuments;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal AutomationDocumentsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableAutomationDocuments = (TestQuoteDocsData.AutomationDocumentsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string AutomationDocumentID
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableAutomationDocuments.AutomationDocumentIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'AutomationDocumentID' in table 'AutomationDocuments' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableAutomationDocuments.AutomationDocumentIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string Name
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableAutomationDocuments.NameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Name' in table 'AutomationDocuments' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableAutomationDocuments.NameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string TypeName
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableAutomationDocuments.TypeNameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'TypeName' in table 'AutomationDocuments' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableAutomationDocuments.TypeNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string Description
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableAutomationDocuments.DescriptionColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Description' in table 'AutomationDocuments' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableAutomationDocuments.DescriptionColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public object Type
    {
      get
      {
        try
        {
          return this[this.tableAutomationDocuments.TypeColumn];
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Type' in table 'AutomationDocuments' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableAutomationDocuments.TypeColumn] = RuntimeHelpers.GetObjectValue(value);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string DocumentType
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableAutomationDocuments.DocumentTypeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DocumentType' in table 'AutomationDocuments' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableAutomationDocuments.DocumentTypeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsAutomationDocumentIDNull()
    {
      return this.IsNull(this.tableAutomationDocuments.AutomationDocumentIDColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetAutomationDocumentIDNull()
    {
      this[this.tableAutomationDocuments.AutomationDocumentIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsNameNull() => this.IsNull(this.tableAutomationDocuments.NameColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetNameNull()
    {
      this[this.tableAutomationDocuments.NameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsTypeNameNull() => this.IsNull(this.tableAutomationDocuments.TypeNameColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetTypeNameNull()
    {
      this[this.tableAutomationDocuments.TypeNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsDescriptionNull() => this.IsNull(this.tableAutomationDocuments.DescriptionColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetDescriptionNull()
    {
      this[this.tableAutomationDocuments.DescriptionColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsTypeNull() => this.IsNull(this.tableAutomationDocuments.TypeColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetTypeNull()
    {
      this[this.tableAutomationDocuments.TypeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsDocumentTypeNull()
    {
      return this.IsNull(this.tableAutomationDocuments.DocumentTypeColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetDocumentTypeNull()
    {
      this[this.tableAutomationDocuments.DocumentTypeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class PropertiesRow : DataRow
  {
    private TestQuoteDocsData.PropertiesDataTable tableProperties;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal PropertiesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableProperties = (TestQuoteDocsData.PropertiesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string AutomationDocumentID
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableProperties.AutomationDocumentIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'AutomationDocumentID' in table 'Properties' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableProperties.AutomationDocumentIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string PropertyName
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableProperties.PropertyNameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'PropertyName' in table 'Properties' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableProperties.PropertyNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string PropertyValue
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableProperties.PropertyValueColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'PropertyValue' in table 'Properties' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableProperties.PropertyValueColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsAutomationDocumentIDNull()
    {
      return this.IsNull(this.tableProperties.AutomationDocumentIDColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetAutomationDocumentIDNull()
    {
      this[this.tableProperties.AutomationDocumentIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsPropertyNameNull() => this.IsNull(this.tableProperties.PropertyNameColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetPropertyNameNull()
    {
      this[this.tableProperties.PropertyNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsPropertyValueNull() => this.IsNull(this.tableProperties.PropertyValueColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetPropertyValueNull()
    {
      this[this.tableProperties.PropertyValueColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class LookUpStringsRow : DataRow
  {
    private TestQuoteDocsData.LookUpStringsDataTable tableLookUpStrings;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal LookUpStringsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableLookUpStrings = (TestQuoteDocsData.LookUpStringsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string AutomationDocumentID
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableLookUpStrings.AutomationDocumentIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'AutomationDocumentID' in table 'LookUpStrings' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableLookUpStrings.AutomationDocumentIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string SearchString
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableLookUpStrings.SearchStringColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'SearchString' in table 'LookUpStrings' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableLookUpStrings.SearchStringColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsAutomationDocumentIDNull()
    {
      return this.IsNull(this.tableLookUpStrings.AutomationDocumentIDColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetAutomationDocumentIDNull()
    {
      this[this.tableLookUpStrings.AutomationDocumentIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsSearchStringNull() => this.IsNull(this.tableLookUpStrings.SearchStringColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetSearchStringNull()
    {
      this[this.tableLookUpStrings.SearchStringColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  public class AutomationDocumentsRowChangeEvent : EventArgs
  {
    private TestQuoteDocsData.AutomationDocumentsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public AutomationDocumentsRowChangeEvent(
      TestQuoteDocsData.AutomationDocumentsRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public TestQuoteDocsData.AutomationDocumentsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  public class PropertiesRowChangeEvent : EventArgs
  {
    private TestQuoteDocsData.PropertiesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public PropertiesRowChangeEvent(TestQuoteDocsData.PropertiesRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public TestQuoteDocsData.PropertiesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  public class LookUpStringsRowChangeEvent : EventArgs
  {
    private TestQuoteDocsData.LookUpStringsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public LookUpStringsRowChangeEvent(TestQuoteDocsData.LookUpStringsRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public TestQuoteDocsData.LookUpStringsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }
}
