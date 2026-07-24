// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.NoteDocuments.DocumentSystem.dsDocument
// Assembly: MgaSystems.IMS.NotesDocuments, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 3F898CF7-066D-4B05-A9F1-D37DBC4FAA16
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.NotesDocuments.dll

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
namespace MGASystems.IMS.NoteDocuments.DocumentSystem;

[DesignerCategory("code")]
[ToolboxItem(true)]
[XmlSchemaProvider("GetTypedDataSetSchema")]
[XmlRoot("dsDocument")]
[HelpKeyword("vs.data.DataSet")]
[Serializable]
public class dsDocument : DataSet
{
  private dsDocument.tblDocumentAssociationsDataTable tabletblDocumentAssociations;
  private dsDocument.tblDocumentStoreDataTable tabletblDocumentStore;
  private SchemaSerializationMode _schemaSerializationMode;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public dsDocument()
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
  protected dsDocument(SerializationInfo info, StreamingContext context)
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
        if (dataSet.Tables[nameof (tblDocumentAssociations)] != null)
          base.Tables.Add((DataTable) new dsDocument.tblDocumentAssociationsDataTable(dataSet.Tables[nameof (tblDocumentAssociations)]));
        if (dataSet.Tables[nameof (tblDocumentStore)] != null)
          base.Tables.Add((DataTable) new dsDocument.tblDocumentStoreDataTable(dataSet.Tables[nameof (tblDocumentStore)]));
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
  public dsDocument.tblDocumentAssociationsDataTable tblDocumentAssociations
  {
    get => this.tabletblDocumentAssociations;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsDocument.tblDocumentStoreDataTable tblDocumentStore => this.tabletblDocumentStore;

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
    dsDocument dsDocument = (dsDocument) base.Clone();
    dsDocument.InitVars();
    dsDocument.SchemaSerializationMode = this.SchemaSerializationMode;
    return (DataSet) dsDocument;
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
      if (dataSet.Tables["tblDocumentAssociations"] != null)
        base.Tables.Add((DataTable) new dsDocument.tblDocumentAssociationsDataTable(dataSet.Tables["tblDocumentAssociations"]));
      if (dataSet.Tables["tblDocumentStore"] != null)
        base.Tables.Add((DataTable) new dsDocument.tblDocumentStoreDataTable(dataSet.Tables["tblDocumentStore"]));
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
    this.tabletblDocumentAssociations = (dsDocument.tblDocumentAssociationsDataTable) base.Tables["tblDocumentAssociations"];
    if (initTable && this.tabletblDocumentAssociations != null)
      this.tabletblDocumentAssociations.InitVars();
    this.tabletblDocumentStore = (dsDocument.tblDocumentStoreDataTable) base.Tables["tblDocumentStore"];
    if (!initTable || this.tabletblDocumentStore == null)
      return;
    this.tabletblDocumentStore.InitVars();
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private void InitClass()
  {
    this.DataSetName = nameof (dsDocument);
    this.Prefix = "";
    this.Namespace = "http://tempuri.org/dsDocument.xsd";
    this.EnforceConstraints = true;
    this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.tabletblDocumentAssociations = new dsDocument.tblDocumentAssociationsDataTable();
    base.Tables.Add((DataTable) this.tabletblDocumentAssociations);
    this.tabletblDocumentStore = new dsDocument.tblDocumentStoreDataTable();
    base.Tables.Add((DataTable) this.tabletblDocumentStore);
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializetblDocumentAssociations() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializetblDocumentStore() => false;

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
    dsDocument dsDocument = new dsDocument();
    XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
    schemaComplexType.Particle = (XmlSchemaParticle) new XmlSchemaSequence()
    {
      Items = {
        (XmlSchemaObject) new XmlSchemaAny()
        {
          Namespace = dsDocument.Namespace
        }
      }
    };
    XmlSchema schemaSerializable = dsDocument.GetSchemaSerializable();
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
  public delegate void tblDocumentAssociationsRowChangeEventHandler(
    object sender,
    dsDocument.tblDocumentAssociationsRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void tblDocumentStoreRowChangeEventHandler(
    object sender,
    dsDocument.tblDocumentStoreRowChangeEvent e);

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class tblDocumentAssociationsDataTable : 
    TypedTableBase<dsDocument.tblDocumentAssociationsRow>
  {
    private DataColumn columnDocumentStoreGUID;
    private DataColumn columnAssociatedEntityGUID;
    private DataColumn columnAssociatedEntityType;
    private DataColumn columnAssociatedEntityName;
    private DataColumn columnAssociatedEntityFormName;
    private DataColumn columnControlGuid;
    private DataColumn columnContext;
    private DataColumn columnSubmissionGroupGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblDocumentAssociationsDataTable()
    {
      this.TableName = "tblDocumentAssociations";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblDocumentAssociationsDataTable(DataTable table)
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
    protected tblDocumentAssociationsDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn DocumentStoreGUIDColumn => this.columnDocumentStoreGUID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn AssociatedEntityGUIDColumn => this.columnAssociatedEntityGUID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn AssociatedEntityTypeColumn => this.columnAssociatedEntityType;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn AssociatedEntityNameColumn => this.columnAssociatedEntityName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn AssociatedEntityFormNameColumn => this.columnAssociatedEntityFormName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ControlGuidColumn => this.columnControlGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ContextColumn => this.columnContext;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn SubmissionGroupGuidColumn => this.columnSubmissionGroupGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsDocument.tblDocumentAssociationsRow this[int index]
    {
      get => (dsDocument.tblDocumentAssociationsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsDocument.tblDocumentAssociationsRowChangeEventHandler tblDocumentAssociationsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsDocument.tblDocumentAssociationsRowChangeEventHandler tblDocumentAssociationsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsDocument.tblDocumentAssociationsRowChangeEventHandler tblDocumentAssociationsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsDocument.tblDocumentAssociationsRowChangeEventHandler tblDocumentAssociationsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddtblDocumentAssociationsRow(dsDocument.tblDocumentAssociationsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsDocument.tblDocumentAssociationsRow AddtblDocumentAssociationsRow(
      Guid DocumentStoreGUID,
      Guid AssociatedEntityGUID,
      string AssociatedEntityType,
      string AssociatedEntityName,
      string AssociatedEntityFormName,
      Guid ControlGuid,
      string Context,
      Guid SubmissionGroupGuid)
    {
      dsDocument.tblDocumentAssociationsRow row = (dsDocument.tblDocumentAssociationsRow) this.NewRow();
      object[] objArray = new object[8]
      {
        (object) DocumentStoreGUID,
        (object) AssociatedEntityGUID,
        (object) AssociatedEntityType,
        (object) AssociatedEntityName,
        (object) AssociatedEntityFormName,
        (object) ControlGuid,
        (object) Context,
        (object) SubmissionGroupGuid
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsDocument.tblDocumentAssociationsRow FindByDocumentStoreGUIDAssociatedEntityGUID(
      Guid DocumentStoreGUID,
      Guid AssociatedEntityGUID)
    {
      return (dsDocument.tblDocumentAssociationsRow) this.Rows.Find(new object[2]
      {
        (object) DocumentStoreGUID,
        (object) AssociatedEntityGUID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsDocument.tblDocumentAssociationsDataTable associationsDataTable = (dsDocument.tblDocumentAssociationsDataTable) base.Clone();
      associationsDataTable.InitVars();
      return (DataTable) associationsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsDocument.tblDocumentAssociationsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnDocumentStoreGUID = this.Columns["DocumentStoreGUID"];
      this.columnAssociatedEntityGUID = this.Columns["AssociatedEntityGUID"];
      this.columnAssociatedEntityType = this.Columns["AssociatedEntityType"];
      this.columnAssociatedEntityName = this.Columns["AssociatedEntityName"];
      this.columnAssociatedEntityFormName = this.Columns["AssociatedEntityFormName"];
      this.columnControlGuid = this.Columns["ControlGuid"];
      this.columnContext = this.Columns["Context"];
      this.columnSubmissionGroupGuid = this.Columns["SubmissionGroupGuid"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnDocumentStoreGUID = new DataColumn("DocumentStoreGUID", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDocumentStoreGUID);
      this.columnAssociatedEntityGUID = new DataColumn("AssociatedEntityGUID", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAssociatedEntityGUID);
      this.columnAssociatedEntityType = new DataColumn("AssociatedEntityType", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAssociatedEntityType);
      this.columnAssociatedEntityName = new DataColumn("AssociatedEntityName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAssociatedEntityName);
      this.columnAssociatedEntityFormName = new DataColumn("AssociatedEntityFormName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAssociatedEntityFormName);
      this.columnControlGuid = new DataColumn("ControlGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnControlGuid);
      this.columnContext = new DataColumn("Context", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnContext);
      this.columnSubmissionGroupGuid = new DataColumn("SubmissionGroupGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSubmissionGroupGuid);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[2]
      {
        this.columnDocumentStoreGUID,
        this.columnAssociatedEntityGUID
      }, true));
      this.columnDocumentStoreGUID.AllowDBNull = false;
      this.columnAssociatedEntityGUID.AllowDBNull = false;
      this.columnAssociatedEntityType.AllowDBNull = false;
      this.columnAssociatedEntityType.MaxLength = 250;
      this.columnAssociatedEntityName.AllowDBNull = false;
      this.columnAssociatedEntityName.MaxLength = 350;
      this.columnAssociatedEntityFormName.AllowDBNull = false;
      this.columnAssociatedEntityFormName.MaxLength = 250;
      this.columnContext.MaxLength = 250;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsDocument.tblDocumentAssociationsRow NewtblDocumentAssociationsRow()
    {
      return (dsDocument.tblDocumentAssociationsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsDocument.tblDocumentAssociationsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (dsDocument.tblDocumentAssociationsRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblDocumentAssociationsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsDocument.tblDocumentAssociationsRowChangeEventHandler associationsRowChangedEvent = this.tblDocumentAssociationsRowChangedEvent;
      if (associationsRowChangedEvent == null)
        return;
      associationsRowChangedEvent((object) this, new dsDocument.tblDocumentAssociationsRowChangeEvent((dsDocument.tblDocumentAssociationsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblDocumentAssociationsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsDocument.tblDocumentAssociationsRowChangeEventHandler rowChangingEvent = this.tblDocumentAssociationsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsDocument.tblDocumentAssociationsRowChangeEvent((dsDocument.tblDocumentAssociationsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblDocumentAssociationsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsDocument.tblDocumentAssociationsRowChangeEventHandler associationsRowDeletedEvent = this.tblDocumentAssociationsRowDeletedEvent;
      if (associationsRowDeletedEvent == null)
        return;
      associationsRowDeletedEvent((object) this, new dsDocument.tblDocumentAssociationsRowChangeEvent((dsDocument.tblDocumentAssociationsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblDocumentAssociationsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsDocument.tblDocumentAssociationsRowChangeEventHandler rowDeletingEvent = this.tblDocumentAssociationsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsDocument.tblDocumentAssociationsRowChangeEvent((dsDocument.tblDocumentAssociationsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemovetblDocumentAssociationsRow(dsDocument.tblDocumentAssociationsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsDocument dsDocument = new dsDocument();
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
        FixedValue = dsDocument.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblDocumentAssociationsDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsDocument.GetSchemaSerializable();
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
  public class tblDocumentStoreDataTable : TypedTableBase<dsDocument.tblDocumentStoreRow>
  {
    private DataColumn columnDocumentStoreGUID;
    private DataColumn columnDescription;
    private DataColumn columnFileAssociation;
    private DataColumn columnDateAdded;
    private DataColumn columnFileName;
    private DataColumn columnUserGUIDOriginator;
    private DataColumn columnTypeGUID;
    private DataColumn columnCompressionLevel;
    private DataColumn columnCompressed;
    private DataColumn columnOriginalFileSize;
    private DataColumn columnDocumentThumbnail;
    private DataColumn columnFolderID;
    private DataColumn columnMetaXML;
    private DataColumn columnCopyAssociationsForwardOnRenewal;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblDocumentStoreDataTable()
    {
      this.TableName = "tblDocumentStore";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblDocumentStoreDataTable(DataTable table)
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
    protected tblDocumentStoreDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn DocumentStoreGUIDColumn => this.columnDocumentStoreGUID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn DescriptionColumn => this.columnDescription;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn FileAssociationColumn => this.columnFileAssociation;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn DateAddedColumn => this.columnDateAdded;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn FileNameColumn => this.columnFileName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn UserGUIDOriginatorColumn => this.columnUserGUIDOriginator;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn TypeGUIDColumn => this.columnTypeGUID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn CompressionLevelColumn => this.columnCompressionLevel;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn CompressedColumn => this.columnCompressed;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn OriginalFileSizeColumn => this.columnOriginalFileSize;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn DocumentThumbnailColumn => this.columnDocumentThumbnail;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn FolderIDColumn => this.columnFolderID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn MetaXMLColumn => this.columnMetaXML;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn CopyAssociationsForwardOnRenewalColumn
    {
      get => this.columnCopyAssociationsForwardOnRenewal;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsDocument.tblDocumentStoreRow this[int index]
    {
      get => (dsDocument.tblDocumentStoreRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsDocument.tblDocumentStoreRowChangeEventHandler tblDocumentStoreRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsDocument.tblDocumentStoreRowChangeEventHandler tblDocumentStoreRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsDocument.tblDocumentStoreRowChangeEventHandler tblDocumentStoreRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsDocument.tblDocumentStoreRowChangeEventHandler tblDocumentStoreRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddtblDocumentStoreRow(dsDocument.tblDocumentStoreRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsDocument.tblDocumentStoreRow AddtblDocumentStoreRow(
      Guid DocumentStoreGUID,
      string Description,
      string FileAssociation,
      DateTime DateAdded,
      string FileName,
      Guid UserGUIDOriginator,
      Guid TypeGUID,
      int CompressionLevel,
      bool Compressed,
      int OriginalFileSize,
      byte[] DocumentThumbnail,
      int FolderID,
      string MetaXML,
      bool CopyAssociationsForwardOnRenewal)
    {
      dsDocument.tblDocumentStoreRow row = (dsDocument.tblDocumentStoreRow) this.NewRow();
      object[] objArray = new object[14]
      {
        (object) DocumentStoreGUID,
        (object) Description,
        (object) FileAssociation,
        (object) DateAdded,
        (object) FileName,
        (object) UserGUIDOriginator,
        (object) TypeGUID,
        (object) CompressionLevel,
        (object) Compressed,
        (object) OriginalFileSize,
        (object) DocumentThumbnail,
        (object) FolderID,
        (object) MetaXML,
        (object) CopyAssociationsForwardOnRenewal
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsDocument.tblDocumentStoreRow FindByDocumentStoreGUID(Guid DocumentStoreGUID)
    {
      return (dsDocument.tblDocumentStoreRow) this.Rows.Find(new object[1]
      {
        (object) DocumentStoreGUID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsDocument.tblDocumentStoreDataTable documentStoreDataTable = (dsDocument.tblDocumentStoreDataTable) base.Clone();
      documentStoreDataTable.InitVars();
      return (DataTable) documentStoreDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsDocument.tblDocumentStoreDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnDocumentStoreGUID = this.Columns["DocumentStoreGUID"];
      this.columnDescription = this.Columns["Description"];
      this.columnFileAssociation = this.Columns["FileAssociation"];
      this.columnDateAdded = this.Columns["DateAdded"];
      this.columnFileName = this.Columns["FileName"];
      this.columnUserGUIDOriginator = this.Columns["UserGUIDOriginator"];
      this.columnTypeGUID = this.Columns["TypeGUID"];
      this.columnCompressionLevel = this.Columns["CompressionLevel"];
      this.columnCompressed = this.Columns["Compressed"];
      this.columnOriginalFileSize = this.Columns["OriginalFileSize"];
      this.columnDocumentThumbnail = this.Columns["DocumentThumbnail"];
      this.columnFolderID = this.Columns["FolderID"];
      this.columnMetaXML = this.Columns["MetaXML"];
      this.columnCopyAssociationsForwardOnRenewal = this.Columns["CopyAssociationsForwardOnRenewal"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnDocumentStoreGUID = new DataColumn("DocumentStoreGUID", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDocumentStoreGUID);
      this.columnDescription = new DataColumn("Description", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDescription);
      this.columnFileAssociation = new DataColumn("FileAssociation", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFileAssociation);
      this.columnDateAdded = new DataColumn("DateAdded", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDateAdded);
      this.columnFileName = new DataColumn("FileName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFileName);
      this.columnUserGUIDOriginator = new DataColumn("UserGUIDOriginator", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnUserGUIDOriginator);
      this.columnTypeGUID = new DataColumn("TypeGUID", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnTypeGUID);
      this.columnCompressionLevel = new DataColumn("CompressionLevel", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCompressionLevel);
      this.columnCompressed = new DataColumn("Compressed", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCompressed);
      this.columnOriginalFileSize = new DataColumn("OriginalFileSize", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnOriginalFileSize);
      this.columnDocumentThumbnail = new DataColumn("DocumentThumbnail", typeof (byte[]), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDocumentThumbnail);
      this.columnFolderID = new DataColumn("FolderID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFolderID);
      this.columnMetaXML = new DataColumn("MetaXML", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnMetaXML);
      this.columnCopyAssociationsForwardOnRenewal = new DataColumn("CopyAssociationsForwardOnRenewal", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCopyAssociationsForwardOnRenewal);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnDocumentStoreGUID
      }, true));
      this.columnDocumentStoreGUID.AllowDBNull = false;
      this.columnDocumentStoreGUID.Unique = true;
      this.columnDescription.MaxLength = 1000;
      this.columnFileAssociation.AllowDBNull = false;
      this.columnFileAssociation.MaxLength = 50;
      this.columnDateAdded.AllowDBNull = false;
      this.columnFileName.AllowDBNull = false;
      this.columnFileName.MaxLength = (int) byte.MaxValue;
      this.columnUserGUIDOriginator.AllowDBNull = false;
      this.columnCompressed.AllowDBNull = false;
      this.columnMetaXML.MaxLength = 8000;
      this.columnCopyAssociationsForwardOnRenewal.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsDocument.tblDocumentStoreRow NewtblDocumentStoreRow()
    {
      return (dsDocument.tblDocumentStoreRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsDocument.tblDocumentStoreRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (dsDocument.tblDocumentStoreRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblDocumentStoreRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsDocument.tblDocumentStoreRowChangeEventHandler storeRowChangedEvent = this.tblDocumentStoreRowChangedEvent;
      if (storeRowChangedEvent == null)
        return;
      storeRowChangedEvent((object) this, new dsDocument.tblDocumentStoreRowChangeEvent((dsDocument.tblDocumentStoreRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblDocumentStoreRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsDocument.tblDocumentStoreRowChangeEventHandler rowChangingEvent = this.tblDocumentStoreRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsDocument.tblDocumentStoreRowChangeEvent((dsDocument.tblDocumentStoreRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblDocumentStoreRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsDocument.tblDocumentStoreRowChangeEventHandler storeRowDeletedEvent = this.tblDocumentStoreRowDeletedEvent;
      if (storeRowDeletedEvent == null)
        return;
      storeRowDeletedEvent((object) this, new dsDocument.tblDocumentStoreRowChangeEvent((dsDocument.tblDocumentStoreRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblDocumentStoreRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsDocument.tblDocumentStoreRowChangeEventHandler rowDeletingEvent = this.tblDocumentStoreRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsDocument.tblDocumentStoreRowChangeEvent((dsDocument.tblDocumentStoreRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemovetblDocumentStoreRow(dsDocument.tblDocumentStoreRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsDocument dsDocument = new dsDocument();
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
        FixedValue = dsDocument.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblDocumentStoreDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsDocument.GetSchemaSerializable();
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

  public class tblDocumentAssociationsRow : DataRow
  {
    private dsDocument.tblDocumentAssociationsDataTable tabletblDocumentAssociations;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblDocumentAssociationsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblDocumentAssociations = (dsDocument.tblDocumentAssociationsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Guid DocumentStoreGUID
    {
      get
      {
        object obj = this[this.tabletblDocumentAssociations.DocumentStoreGUIDColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tabletblDocumentAssociations.DocumentStoreGUIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Guid AssociatedEntityGUID
    {
      get
      {
        object obj = this[this.tabletblDocumentAssociations.AssociatedEntityGUIDColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tabletblDocumentAssociations.AssociatedEntityGUIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string AssociatedEntityType
    {
      get
      {
        return Conversions.ToString(this[this.tabletblDocumentAssociations.AssociatedEntityTypeColumn]);
      }
      set => this[this.tabletblDocumentAssociations.AssociatedEntityTypeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string AssociatedEntityName
    {
      get
      {
        return Conversions.ToString(this[this.tabletblDocumentAssociations.AssociatedEntityNameColumn]);
      }
      set => this[this.tabletblDocumentAssociations.AssociatedEntityNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string AssociatedEntityFormName
    {
      get
      {
        return Conversions.ToString(this[this.tabletblDocumentAssociations.AssociatedEntityFormNameColumn]);
      }
      set
      {
        this[this.tabletblDocumentAssociations.AssociatedEntityFormNameColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Guid ControlGuid
    {
      get
      {
        try
        {
          object obj = this[this.tabletblDocumentAssociations.ControlGuidColumn];
          return obj != null ? (Guid) obj : new Guid();
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ControlGuid' in table 'tblDocumentAssociations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblDocumentAssociations.ControlGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Context
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblDocumentAssociations.ContextColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Context' in table 'tblDocumentAssociations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblDocumentAssociations.ContextColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Guid SubmissionGroupGuid
    {
      get
      {
        try
        {
          object obj = this[this.tabletblDocumentAssociations.SubmissionGroupGuidColumn];
          return obj != null ? (Guid) obj : new Guid();
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'SubmissionGroupGuid' in table 'tblDocumentAssociations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblDocumentAssociations.SubmissionGroupGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsControlGuidNull()
    {
      return this.IsNull(this.tabletblDocumentAssociations.ControlGuidColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetControlGuidNull()
    {
      this[this.tabletblDocumentAssociations.ControlGuidColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsContextNull() => this.IsNull(this.tabletblDocumentAssociations.ContextColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetContextNull()
    {
      this[this.tabletblDocumentAssociations.ContextColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsSubmissionGroupGuidNull()
    {
      return this.IsNull(this.tabletblDocumentAssociations.SubmissionGroupGuidColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetSubmissionGroupGuidNull()
    {
      this[this.tabletblDocumentAssociations.SubmissionGroupGuidColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class tblDocumentStoreRow : DataRow
  {
    private dsDocument.tblDocumentStoreDataTable tabletblDocumentStore;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblDocumentStoreRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblDocumentStore = (dsDocument.tblDocumentStoreDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Guid DocumentStoreGUID
    {
      get
      {
        object obj = this[this.tabletblDocumentStore.DocumentStoreGUIDColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tabletblDocumentStore.DocumentStoreGUIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Description
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblDocumentStore.DescriptionColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Description' in table 'tblDocumentStore' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblDocumentStore.DescriptionColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string FileAssociation
    {
      get => Conversions.ToString(this[this.tabletblDocumentStore.FileAssociationColumn]);
      set => this[this.tabletblDocumentStore.FileAssociationColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DateTime DateAdded
    {
      get => Conversions.ToDate(this[this.tabletblDocumentStore.DateAddedColumn]);
      set => this[this.tabletblDocumentStore.DateAddedColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string FileName
    {
      get => Conversions.ToString(this[this.tabletblDocumentStore.FileNameColumn]);
      set => this[this.tabletblDocumentStore.FileNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Guid UserGUIDOriginator
    {
      get
      {
        object obj = this[this.tabletblDocumentStore.UserGUIDOriginatorColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tabletblDocumentStore.UserGUIDOriginatorColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Guid TypeGUID
    {
      get
      {
        try
        {
          object obj = this[this.tabletblDocumentStore.TypeGUIDColumn];
          return obj != null ? (Guid) obj : new Guid();
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'TypeGUID' in table 'tblDocumentStore' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblDocumentStore.TypeGUIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int CompressionLevel
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblDocumentStore.CompressionLevelColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'CompressionLevel' in table 'tblDocumentStore' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblDocumentStore.CompressionLevelColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool Compressed
    {
      get => Conversions.ToBoolean(this[this.tabletblDocumentStore.CompressedColumn]);
      set => this[this.tabletblDocumentStore.CompressedColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int OriginalFileSize
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblDocumentStore.OriginalFileSizeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'OriginalFileSize' in table 'tblDocumentStore' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblDocumentStore.OriginalFileSizeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public byte[] DocumentThumbnail
    {
      get
      {
        try
        {
          return (byte[]) this[this.tabletblDocumentStore.DocumentThumbnailColumn];
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DocumentThumbnail' in table 'tblDocumentStore' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblDocumentStore.DocumentThumbnailColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int FolderID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblDocumentStore.FolderIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'FolderID' in table 'tblDocumentStore' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblDocumentStore.FolderIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string MetaXML
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblDocumentStore.MetaXMLColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'MetaXML' in table 'tblDocumentStore' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblDocumentStore.MetaXMLColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool CopyAssociationsForwardOnRenewal
    {
      get
      {
        return Conversions.ToBoolean(this[this.tabletblDocumentStore.CopyAssociationsForwardOnRenewalColumn]);
      }
      set
      {
        this[this.tabletblDocumentStore.CopyAssociationsForwardOnRenewalColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsDescriptionNull() => this.IsNull(this.tabletblDocumentStore.DescriptionColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetDescriptionNull()
    {
      this[this.tabletblDocumentStore.DescriptionColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsTypeGUIDNull() => this.IsNull(this.tabletblDocumentStore.TypeGUIDColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetTypeGUIDNull()
    {
      this[this.tabletblDocumentStore.TypeGUIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsCompressionLevelNull()
    {
      return this.IsNull(this.tabletblDocumentStore.CompressionLevelColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetCompressionLevelNull()
    {
      this[this.tabletblDocumentStore.CompressionLevelColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsOriginalFileSizeNull()
    {
      return this.IsNull(this.tabletblDocumentStore.OriginalFileSizeColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetOriginalFileSizeNull()
    {
      this[this.tabletblDocumentStore.OriginalFileSizeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsDocumentThumbnailNull()
    {
      return this.IsNull(this.tabletblDocumentStore.DocumentThumbnailColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetDocumentThumbnailNull()
    {
      this[this.tabletblDocumentStore.DocumentThumbnailColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsFolderIDNull() => this.IsNull(this.tabletblDocumentStore.FolderIDColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetFolderIDNull()
    {
      this[this.tabletblDocumentStore.FolderIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsMetaXMLNull() => this.IsNull(this.tabletblDocumentStore.MetaXMLColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetMetaXMLNull()
    {
      this[this.tabletblDocumentStore.MetaXMLColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class tblDocumentAssociationsRowChangeEvent : EventArgs
  {
    private dsDocument.tblDocumentAssociationsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblDocumentAssociationsRowChangeEvent(
      dsDocument.tblDocumentAssociationsRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsDocument.tblDocumentAssociationsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class tblDocumentStoreRowChangeEvent : EventArgs
  {
    private dsDocument.tblDocumentStoreRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblDocumentStoreRowChangeEvent(dsDocument.tblDocumentStoreRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsDocument.tblDocumentStoreRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }
}
