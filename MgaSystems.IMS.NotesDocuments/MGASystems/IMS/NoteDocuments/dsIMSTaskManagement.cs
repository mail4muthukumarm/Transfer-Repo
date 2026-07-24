// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.NoteDocuments.dsIMSTaskManagement
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
namespace MGASystems.IMS.NoteDocuments;

[DesignerCategory("code")]
[ToolboxItem(true)]
[XmlSchemaProvider("GetTypedDataSetSchema")]
[XmlRoot("dsIMSTaskManagement")]
[HelpKeyword("vs.data.DataSet")]
[Serializable]
public class dsIMSTaskManagement : DataSet
{
  private dsIMSTaskManagement.AllOpenTasksDataTable tableAllOpenTasks;
  private dsIMSTaskManagement.UserOpenTasksDataTable tableUserOpenTasks;
  private SchemaSerializationMode _schemaSerializationMode;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public dsIMSTaskManagement()
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
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  protected dsIMSTaskManagement(SerializationInfo info, StreamingContext context)
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
        if (dataSet.Tables[nameof (AllOpenTasks)] != null)
          base.Tables.Add((DataTable) new dsIMSTaskManagement.AllOpenTasksDataTable(dataSet.Tables[nameof (AllOpenTasks)]));
        if (dataSet.Tables[nameof (UserOpenTasks)] != null)
          base.Tables.Add((DataTable) new dsIMSTaskManagement.UserOpenTasksDataTable(dataSet.Tables[nameof (UserOpenTasks)]));
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
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsIMSTaskManagement.AllOpenTasksDataTable AllOpenTasks => this.tableAllOpenTasks;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsIMSTaskManagement.UserOpenTasksDataTable UserOpenTasks => this.tableUserOpenTasks;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  [Browsable(true)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
  public override SchemaSerializationMode SchemaSerializationMode
  {
    get => this._schemaSerializationMode;
    set => this._schemaSerializationMode = value;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public new DataTableCollection Tables => base.Tables;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public new DataRelationCollection Relations => base.Relations;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  protected override void InitializeDerivedDataSet()
  {
    this.BeginInit();
    this.InitClass();
    this.EndInit();
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public override DataSet Clone()
  {
    dsIMSTaskManagement imsTaskManagement = (dsIMSTaskManagement) base.Clone();
    imsTaskManagement.InitVars();
    imsTaskManagement.SchemaSerializationMode = this.SchemaSerializationMode;
    return (DataSet) imsTaskManagement;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  protected override bool ShouldSerializeTables() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  protected override bool ShouldSerializeRelations() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  protected override void ReadXmlSerializable(XmlReader reader)
  {
    if (this.DetermineSchemaSerializationMode(reader) == SchemaSerializationMode.IncludeSchema)
    {
      this.Reset();
      DataSet dataSet = new DataSet();
      int num = (int) dataSet.ReadXml(reader);
      if (dataSet.Tables["AllOpenTasks"] != null)
        base.Tables.Add((DataTable) new dsIMSTaskManagement.AllOpenTasksDataTable(dataSet.Tables["AllOpenTasks"]));
      if (dataSet.Tables["UserOpenTasks"] != null)
        base.Tables.Add((DataTable) new dsIMSTaskManagement.UserOpenTasksDataTable(dataSet.Tables["UserOpenTasks"]));
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
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  protected override XmlSchema GetSchemaSerializable()
  {
    MemoryStream memoryStream = new MemoryStream();
    this.WriteXmlSchema((XmlWriter) new XmlTextWriter((Stream) memoryStream, (Encoding) null));
    memoryStream.Position = 0L;
    return XmlSchema.Read((XmlReader) new XmlTextReader((Stream) memoryStream), (ValidationEventHandler) null);
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  internal void InitVars() => this.InitVars(true);

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  internal void InitVars(bool initTable)
  {
    this.tableAllOpenTasks = (dsIMSTaskManagement.AllOpenTasksDataTable) base.Tables["AllOpenTasks"];
    if (initTable && this.tableAllOpenTasks != null)
      this.tableAllOpenTasks.InitVars();
    this.tableUserOpenTasks = (dsIMSTaskManagement.UserOpenTasksDataTable) base.Tables["UserOpenTasks"];
    if (!initTable || this.tableUserOpenTasks == null)
      return;
    this.tableUserOpenTasks.InitVars();
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private void InitClass()
  {
    this.DataSetName = nameof (dsIMSTaskManagement);
    this.Prefix = "";
    this.Namespace = "http://tempuri.org/dsIMSTaskManagement.xsd";
    this.EnforceConstraints = true;
    this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.tableAllOpenTasks = new dsIMSTaskManagement.AllOpenTasksDataTable();
    base.Tables.Add((DataTable) this.tableAllOpenTasks);
    this.tableUserOpenTasks = new dsIMSTaskManagement.UserOpenTasksDataTable();
    base.Tables.Add((DataTable) this.tableUserOpenTasks);
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializeAllOpenTasks() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializeUserOpenTasks() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private void SchemaChanged(object sender, CollectionChangeEventArgs e)
  {
    if (e.Action != CollectionChangeAction.Remove)
      return;
    this.InitVars();
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public static XmlSchemaComplexType GetTypedDataSetSchema(XmlSchemaSet xs)
  {
    dsIMSTaskManagement imsTaskManagement = new dsIMSTaskManagement();
    XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
    schemaComplexType.Particle = (XmlSchemaParticle) new XmlSchemaSequence()
    {
      Items = {
        (XmlSchemaObject) new XmlSchemaAny()
        {
          Namespace = imsTaskManagement.Namespace
        }
      }
    };
    XmlSchema schemaSerializable = imsTaskManagement.GetSchemaSerializable();
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

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public delegate void AllOpenTasksRowChangeEventHandler(
    object sender,
    dsIMSTaskManagement.AllOpenTasksRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public delegate void UserOpenTasksRowChangeEventHandler(
    object sender,
    dsIMSTaskManagement.UserOpenTasksRowChangeEvent e);

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class AllOpenTasksDataTable : TypedTableBase<dsIMSTaskManagement.AllOpenTasksRow>
  {
    private DataColumn columnEntryGUID;
    private DataColumn columnNoteGUID;
    private DataColumn columnCreatedDate;
    private DataColumn columnDueDate;
    private DataColumn columnBody;
    private DataColumn columnType;
    private DataColumn columnSubject;
    private DataColumn columnPolicyNumber;
    private DataColumn columnInsuredPolicyName;
    private DataColumn columnUnderwriterName;
    private DataColumn columnProducer;
    private DataColumn columnNoteType;
    private DataColumn columnControlNo;
    private DataColumn columnEffectiveDate;
    private DataColumn columnStateID;
    private DataColumn columnDisplayStatus;
    private DataColumn columnClaimNumber;
    private DataColumn columnPolicyType;
    private DataColumn columnLOB;
    private DataColumn columnPremium;
    private DataColumn columnNeededByDate;
    private DataColumn columnExpirationDate;
    private DataColumn columnCarrier;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public AllOpenTasksDataTable()
    {
      this.TableName = "AllOpenTasks";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal AllOpenTasksDataTable(DataTable table)
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected AllOpenTasksDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn EntryGUIDColumn => this.columnEntryGUID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn NoteGUIDColumn => this.columnNoteGUID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn CreatedDateColumn => this.columnCreatedDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn DueDateColumn => this.columnDueDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn BodyColumn => this.columnBody;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn TypeColumn => this.columnType;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn SubjectColumn => this.columnSubject;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn PolicyNumberColumn => this.columnPolicyNumber;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn InsuredPolicyNameColumn => this.columnInsuredPolicyName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn UnderwriterNameColumn => this.columnUnderwriterName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ProducerColumn => this.columnProducer;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn NoteTypeColumn => this.columnNoteType;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ControlNoColumn => this.columnControlNo;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn EffectiveDateColumn => this.columnEffectiveDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn StateIDColumn => this.columnStateID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn DisplayStatusColumn => this.columnDisplayStatus;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ClaimNumberColumn => this.columnClaimNumber;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn PolicyTypeColumn => this.columnPolicyType;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn LOBColumn => this.columnLOB;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn PremiumColumn => this.columnPremium;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn NeededByDateColumn => this.columnNeededByDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ExpirationDateColumn => this.columnExpirationDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn CarrierColumn => this.columnCarrier;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsIMSTaskManagement.AllOpenTasksRow this[int index]
    {
      get => (dsIMSTaskManagement.AllOpenTasksRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsIMSTaskManagement.AllOpenTasksRowChangeEventHandler AllOpenTasksRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsIMSTaskManagement.AllOpenTasksRowChangeEventHandler AllOpenTasksRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsIMSTaskManagement.AllOpenTasksRowChangeEventHandler AllOpenTasksRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsIMSTaskManagement.AllOpenTasksRowChangeEventHandler AllOpenTasksRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AddAllOpenTasksRow(dsIMSTaskManagement.AllOpenTasksRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsIMSTaskManagement.AllOpenTasksRow AddAllOpenTasksRow(
      Guid EntryGUID,
      Guid NoteGUID,
      DateTime CreatedDate,
      DateTime DueDate,
      string Body,
      int Type,
      string Subject,
      string PolicyNumber,
      string InsuredPolicyName,
      string UnderwriterName,
      string Producer,
      string NoteType,
      int ControlNo,
      DateTime EffectiveDate,
      string StateID,
      string DisplayStatus,
      string ClaimNumber,
      string PolicyType,
      string LOB,
      Decimal Premium,
      DateTime NeededByDate,
      DateTime ExpirationDate,
      string Carrier)
    {
      dsIMSTaskManagement.AllOpenTasksRow row = (dsIMSTaskManagement.AllOpenTasksRow) this.NewRow();
      object[] objArray = new object[23]
      {
        (object) EntryGUID,
        (object) NoteGUID,
        (object) CreatedDate,
        (object) DueDate,
        (object) Body,
        (object) Type,
        (object) Subject,
        (object) PolicyNumber,
        (object) InsuredPolicyName,
        (object) UnderwriterName,
        (object) Producer,
        (object) NoteType,
        (object) ControlNo,
        (object) EffectiveDate,
        (object) StateID,
        (object) DisplayStatus,
        (object) ClaimNumber,
        (object) PolicyType,
        (object) LOB,
        (object) Premium,
        (object) NeededByDate,
        (object) ExpirationDate,
        (object) Carrier
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsIMSTaskManagement.AllOpenTasksRow FindByEntryGUID(Guid EntryGUID)
    {
      return (dsIMSTaskManagement.AllOpenTasksRow) this.Rows.Find(new object[1]
      {
        (object) EntryGUID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsIMSTaskManagement.AllOpenTasksDataTable openTasksDataTable = (dsIMSTaskManagement.AllOpenTasksDataTable) base.Clone();
      openTasksDataTable.InitVars();
      return (DataTable) openTasksDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsIMSTaskManagement.AllOpenTasksDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal void InitVars()
    {
      this.columnEntryGUID = this.Columns["EntryGUID"];
      this.columnNoteGUID = this.Columns["NoteGUID"];
      this.columnCreatedDate = this.Columns["CreatedDate"];
      this.columnDueDate = this.Columns["DueDate"];
      this.columnBody = this.Columns["Body"];
      this.columnType = this.Columns["Type"];
      this.columnSubject = this.Columns["Subject"];
      this.columnPolicyNumber = this.Columns["PolicyNumber"];
      this.columnInsuredPolicyName = this.Columns["InsuredPolicyName"];
      this.columnUnderwriterName = this.Columns["UnderwriterName"];
      this.columnProducer = this.Columns["Producer"];
      this.columnNoteType = this.Columns["NoteType"];
      this.columnControlNo = this.Columns["ControlNo"];
      this.columnEffectiveDate = this.Columns["EffectiveDate"];
      this.columnStateID = this.Columns["StateID"];
      this.columnDisplayStatus = this.Columns["DisplayStatus"];
      this.columnClaimNumber = this.Columns["ClaimNumber"];
      this.columnPolicyType = this.Columns["PolicyType"];
      this.columnLOB = this.Columns["LOB"];
      this.columnPremium = this.Columns["Premium"];
      this.columnNeededByDate = this.Columns["NeededByDate"];
      this.columnExpirationDate = this.Columns["ExpirationDate"];
      this.columnCarrier = this.Columns["Carrier"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.columnEntryGUID = new DataColumn("EntryGUID", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEntryGUID);
      this.columnNoteGUID = new DataColumn("NoteGUID", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnNoteGUID);
      this.columnCreatedDate = new DataColumn("CreatedDate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCreatedDate);
      this.columnDueDate = new DataColumn("DueDate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDueDate);
      this.columnBody = new DataColumn("Body", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnBody);
      this.columnType = new DataColumn("Type", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnType);
      this.columnSubject = new DataColumn("Subject", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSubject);
      this.columnPolicyNumber = new DataColumn("PolicyNumber", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPolicyNumber);
      this.columnInsuredPolicyName = new DataColumn("InsuredPolicyName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInsuredPolicyName);
      this.columnUnderwriterName = new DataColumn("UnderwriterName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnUnderwriterName);
      this.columnProducer = new DataColumn("Producer", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnProducer);
      this.columnNoteType = new DataColumn("NoteType", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnNoteType);
      this.columnControlNo = new DataColumn("ControlNo", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnControlNo);
      this.columnEffectiveDate = new DataColumn("EffectiveDate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEffectiveDate);
      this.columnStateID = new DataColumn("StateID", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnStateID);
      this.columnDisplayStatus = new DataColumn("DisplayStatus", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDisplayStatus);
      this.columnClaimNumber = new DataColumn("ClaimNumber", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnClaimNumber);
      this.columnPolicyType = new DataColumn("PolicyType", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPolicyType);
      this.columnLOB = new DataColumn("LOB", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLOB);
      this.columnPremium = new DataColumn("Premium", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPremium);
      this.columnNeededByDate = new DataColumn("NeededByDate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnNeededByDate);
      this.columnExpirationDate = new DataColumn("ExpirationDate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnExpirationDate);
      this.columnCarrier = new DataColumn("Carrier", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCarrier);
      this.Constraints.Add((Constraint) new UniqueConstraint("AllOpenTasksKey1", new DataColumn[1]
      {
        this.columnEntryGUID
      }, true));
      this.columnEntryGUID.AllowDBNull = false;
      this.columnEntryGUID.Unique = true;
      this.columnNoteGUID.AllowDBNull = false;
      this.columnCreatedDate.AllowDBNull = false;
      this.columnDueDate.AllowDBNull = false;
      this.columnBody.ReadOnly = true;
      this.columnBody.MaxLength = 100;
      this.columnType.AllowDBNull = false;
      this.columnSubject.AllowDBNull = false;
      this.columnSubject.MaxLength = 200;
      this.columnPolicyNumber.MaxLength = 50;
      this.columnInsuredPolicyName.MaxLength = 500;
      this.columnUnderwriterName.ReadOnly = true;
      this.columnUnderwriterName.MaxLength = 102;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsIMSTaskManagement.AllOpenTasksRow NewAllOpenTasksRow()
    {
      return (dsIMSTaskManagement.AllOpenTasksRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsIMSTaskManagement.AllOpenTasksRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType() => typeof (dsIMSTaskManagement.AllOpenTasksRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.AllOpenTasksRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsIMSTaskManagement.AllOpenTasksRowChangeEventHandler tasksRowChangedEvent = this.AllOpenTasksRowChangedEvent;
      if (tasksRowChangedEvent == null)
        return;
      tasksRowChangedEvent((object) this, new dsIMSTaskManagement.AllOpenTasksRowChangeEvent((dsIMSTaskManagement.AllOpenTasksRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.AllOpenTasksRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsIMSTaskManagement.AllOpenTasksRowChangeEventHandler rowChangingEvent = this.AllOpenTasksRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsIMSTaskManagement.AllOpenTasksRowChangeEvent((dsIMSTaskManagement.AllOpenTasksRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.AllOpenTasksRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsIMSTaskManagement.AllOpenTasksRowChangeEventHandler tasksRowDeletedEvent = this.AllOpenTasksRowDeletedEvent;
      if (tasksRowDeletedEvent == null)
        return;
      tasksRowDeletedEvent((object) this, new dsIMSTaskManagement.AllOpenTasksRowChangeEvent((dsIMSTaskManagement.AllOpenTasksRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.AllOpenTasksRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsIMSTaskManagement.AllOpenTasksRowChangeEventHandler rowDeletingEvent = this.AllOpenTasksRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsIMSTaskManagement.AllOpenTasksRowChangeEvent((dsIMSTaskManagement.AllOpenTasksRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemoveAllOpenTasksRow(dsIMSTaskManagement.AllOpenTasksRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsIMSTaskManagement imsTaskManagement = new dsIMSTaskManagement();
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
        FixedValue = imsTaskManagement.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (AllOpenTasksDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = imsTaskManagement.GetSchemaSerializable();
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
  public class UserOpenTasksDataTable : TypedTableBase<dsIMSTaskManagement.UserOpenTasksRow>
  {
    private DataColumn columnEntryGUID;
    private DataColumn columnNoteGUID;
    private DataColumn columnCreatedDate;
    private DataColumn columnDueDate;
    private DataColumn columnBody;
    private DataColumn columnType;
    private DataColumn columnSubject;
    private DataColumn columnPolicyNumber;
    private DataColumn columnInsuredPolicyName;
    private DataColumn columnUnderwriterName;
    private DataColumn columnProducer;
    private DataColumn columnNoteType;
    private DataColumn columnControlNo;
    private DataColumn columnEffectiveDate;
    private DataColumn columnStateID;
    private DataColumn columnDisplayStatus;
    private DataColumn columnClaimNumber;
    private DataColumn columnPolicyType;
    private DataColumn columnLOB;
    private DataColumn columnPremium;
    private DataColumn columnNeededByDate;
    private DataColumn columnExpirationDate;
    private DataColumn columnCarrier;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public UserOpenTasksDataTable()
    {
      this.TableName = "UserOpenTasks";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal UserOpenTasksDataTable(DataTable table)
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected UserOpenTasksDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn EntryGUIDColumn => this.columnEntryGUID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn NoteGUIDColumn => this.columnNoteGUID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn CreatedDateColumn => this.columnCreatedDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn DueDateColumn => this.columnDueDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn BodyColumn => this.columnBody;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn TypeColumn => this.columnType;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn SubjectColumn => this.columnSubject;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn PolicyNumberColumn => this.columnPolicyNumber;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn InsuredPolicyNameColumn => this.columnInsuredPolicyName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn UnderwriterNameColumn => this.columnUnderwriterName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ProducerColumn => this.columnProducer;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn NoteTypeColumn => this.columnNoteType;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ControlNoColumn => this.columnControlNo;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn EffectiveDateColumn => this.columnEffectiveDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn StateIDColumn => this.columnStateID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn DisplayStatusColumn => this.columnDisplayStatus;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ClaimNumberColumn => this.columnClaimNumber;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn PolicyTypeColumn => this.columnPolicyType;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn LOBColumn => this.columnLOB;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn PremiumColumn => this.columnPremium;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn NeededByDateColumn => this.columnNeededByDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ExpirationDateColumn => this.columnExpirationDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn CarrierColumn => this.columnCarrier;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsIMSTaskManagement.UserOpenTasksRow this[int index]
    {
      get => (dsIMSTaskManagement.UserOpenTasksRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsIMSTaskManagement.UserOpenTasksRowChangeEventHandler UserOpenTasksRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsIMSTaskManagement.UserOpenTasksRowChangeEventHandler UserOpenTasksRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsIMSTaskManagement.UserOpenTasksRowChangeEventHandler UserOpenTasksRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsIMSTaskManagement.UserOpenTasksRowChangeEventHandler UserOpenTasksRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AddUserOpenTasksRow(dsIMSTaskManagement.UserOpenTasksRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsIMSTaskManagement.UserOpenTasksRow AddUserOpenTasksRow(
      Guid EntryGUID,
      Guid NoteGUID,
      DateTime CreatedDate,
      DateTime DueDate,
      string Body,
      int Type,
      string Subject,
      string PolicyNumber,
      string InsuredPolicyName,
      string UnderwriterName,
      string Producer,
      string NoteType,
      int ControlNo,
      DateTime EffectiveDate,
      string StateID,
      string DisplayStatus,
      string ClaimNumber,
      string PolicyType,
      string LOB,
      Decimal Premium,
      DateTime NeededByDate,
      DateTime ExpirationDate,
      string Carrier)
    {
      dsIMSTaskManagement.UserOpenTasksRow row = (dsIMSTaskManagement.UserOpenTasksRow) this.NewRow();
      object[] objArray = new object[23]
      {
        (object) EntryGUID,
        (object) NoteGUID,
        (object) CreatedDate,
        (object) DueDate,
        (object) Body,
        (object) Type,
        (object) Subject,
        (object) PolicyNumber,
        (object) InsuredPolicyName,
        (object) UnderwriterName,
        (object) Producer,
        (object) NoteType,
        (object) ControlNo,
        (object) EffectiveDate,
        (object) StateID,
        (object) DisplayStatus,
        (object) ClaimNumber,
        (object) PolicyType,
        (object) LOB,
        (object) Premium,
        (object) NeededByDate,
        (object) ExpirationDate,
        (object) Carrier
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsIMSTaskManagement.UserOpenTasksRow FindByEntryGUID(Guid EntryGUID)
    {
      return (dsIMSTaskManagement.UserOpenTasksRow) this.Rows.Find(new object[1]
      {
        (object) EntryGUID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsIMSTaskManagement.UserOpenTasksDataTable openTasksDataTable = (dsIMSTaskManagement.UserOpenTasksDataTable) base.Clone();
      openTasksDataTable.InitVars();
      return (DataTable) openTasksDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsIMSTaskManagement.UserOpenTasksDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal void InitVars()
    {
      this.columnEntryGUID = this.Columns["EntryGUID"];
      this.columnNoteGUID = this.Columns["NoteGUID"];
      this.columnCreatedDate = this.Columns["CreatedDate"];
      this.columnDueDate = this.Columns["DueDate"];
      this.columnBody = this.Columns["Body"];
      this.columnType = this.Columns["Type"];
      this.columnSubject = this.Columns["Subject"];
      this.columnPolicyNumber = this.Columns["PolicyNumber"];
      this.columnInsuredPolicyName = this.Columns["InsuredPolicyName"];
      this.columnUnderwriterName = this.Columns["UnderwriterName"];
      this.columnProducer = this.Columns["Producer"];
      this.columnNoteType = this.Columns["NoteType"];
      this.columnControlNo = this.Columns["ControlNo"];
      this.columnEffectiveDate = this.Columns["EffectiveDate"];
      this.columnStateID = this.Columns["StateID"];
      this.columnDisplayStatus = this.Columns["DisplayStatus"];
      this.columnClaimNumber = this.Columns["ClaimNumber"];
      this.columnPolicyType = this.Columns["PolicyType"];
      this.columnLOB = this.Columns["LOB"];
      this.columnPremium = this.Columns["Premium"];
      this.columnNeededByDate = this.Columns["NeededByDate"];
      this.columnExpirationDate = this.Columns["ExpirationDate"];
      this.columnCarrier = this.Columns["Carrier"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.columnEntryGUID = new DataColumn("EntryGUID", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEntryGUID);
      this.columnNoteGUID = new DataColumn("NoteGUID", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnNoteGUID);
      this.columnCreatedDate = new DataColumn("CreatedDate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCreatedDate);
      this.columnDueDate = new DataColumn("DueDate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDueDate);
      this.columnBody = new DataColumn("Body", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnBody);
      this.columnType = new DataColumn("Type", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnType);
      this.columnSubject = new DataColumn("Subject", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSubject);
      this.columnPolicyNumber = new DataColumn("PolicyNumber", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPolicyNumber);
      this.columnInsuredPolicyName = new DataColumn("InsuredPolicyName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInsuredPolicyName);
      this.columnUnderwriterName = new DataColumn("UnderwriterName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnUnderwriterName);
      this.columnProducer = new DataColumn("Producer", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnProducer);
      this.columnNoteType = new DataColumn("NoteType", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnNoteType);
      this.columnControlNo = new DataColumn("ControlNo", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnControlNo);
      this.columnEffectiveDate = new DataColumn("EffectiveDate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEffectiveDate);
      this.columnStateID = new DataColumn("StateID", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnStateID);
      this.columnDisplayStatus = new DataColumn("DisplayStatus", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDisplayStatus);
      this.columnClaimNumber = new DataColumn("ClaimNumber", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnClaimNumber);
      this.columnPolicyType = new DataColumn("PolicyType", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPolicyType);
      this.columnLOB = new DataColumn("LOB", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLOB);
      this.columnPremium = new DataColumn("Premium", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPremium);
      this.columnNeededByDate = new DataColumn("NeededByDate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnNeededByDate);
      this.columnExpirationDate = new DataColumn("ExpirationDate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnExpirationDate);
      this.columnCarrier = new DataColumn("Carrier", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCarrier);
      this.Constraints.Add((Constraint) new UniqueConstraint("UserOpenTasksKey1", new DataColumn[1]
      {
        this.columnEntryGUID
      }, true));
      this.columnEntryGUID.AllowDBNull = false;
      this.columnEntryGUID.Unique = true;
      this.columnNoteGUID.AllowDBNull = false;
      this.columnCreatedDate.AllowDBNull = false;
      this.columnDueDate.AllowDBNull = false;
      this.columnBody.ReadOnly = true;
      this.columnBody.MaxLength = 100;
      this.columnType.AllowDBNull = false;
      this.columnSubject.AllowDBNull = false;
      this.columnSubject.MaxLength = 200;
      this.columnPolicyNumber.MaxLength = 50;
      this.columnInsuredPolicyName.MaxLength = 500;
      this.columnUnderwriterName.ReadOnly = true;
      this.columnUnderwriterName.MaxLength = 102;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsIMSTaskManagement.UserOpenTasksRow NewUserOpenTasksRow()
    {
      return (dsIMSTaskManagement.UserOpenTasksRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsIMSTaskManagement.UserOpenTasksRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType() => typeof (dsIMSTaskManagement.UserOpenTasksRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.UserOpenTasksRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsIMSTaskManagement.UserOpenTasksRowChangeEventHandler tasksRowChangedEvent = this.UserOpenTasksRowChangedEvent;
      if (tasksRowChangedEvent == null)
        return;
      tasksRowChangedEvent((object) this, new dsIMSTaskManagement.UserOpenTasksRowChangeEvent((dsIMSTaskManagement.UserOpenTasksRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.UserOpenTasksRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsIMSTaskManagement.UserOpenTasksRowChangeEventHandler rowChangingEvent = this.UserOpenTasksRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsIMSTaskManagement.UserOpenTasksRowChangeEvent((dsIMSTaskManagement.UserOpenTasksRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.UserOpenTasksRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsIMSTaskManagement.UserOpenTasksRowChangeEventHandler tasksRowDeletedEvent = this.UserOpenTasksRowDeletedEvent;
      if (tasksRowDeletedEvent == null)
        return;
      tasksRowDeletedEvent((object) this, new dsIMSTaskManagement.UserOpenTasksRowChangeEvent((dsIMSTaskManagement.UserOpenTasksRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.UserOpenTasksRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsIMSTaskManagement.UserOpenTasksRowChangeEventHandler rowDeletingEvent = this.UserOpenTasksRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsIMSTaskManagement.UserOpenTasksRowChangeEvent((dsIMSTaskManagement.UserOpenTasksRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemoveUserOpenTasksRow(dsIMSTaskManagement.UserOpenTasksRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsIMSTaskManagement imsTaskManagement = new dsIMSTaskManagement();
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
        FixedValue = imsTaskManagement.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (UserOpenTasksDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = imsTaskManagement.GetSchemaSerializable();
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

  public class AllOpenTasksRow : DataRow
  {
    private dsIMSTaskManagement.AllOpenTasksDataTable tableAllOpenTasks;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal AllOpenTasksRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableAllOpenTasks = (dsIMSTaskManagement.AllOpenTasksDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Guid EntryGUID
    {
      get
      {
        object obj = this[this.tableAllOpenTasks.EntryGUIDColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tableAllOpenTasks.EntryGUIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Guid NoteGUID
    {
      get
      {
        object obj = this[this.tableAllOpenTasks.NoteGUIDColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tableAllOpenTasks.NoteGUIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DateTime CreatedDate
    {
      get => Conversions.ToDate(this[this.tableAllOpenTasks.CreatedDateColumn]);
      set => this[this.tableAllOpenTasks.CreatedDateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DateTime DueDate
    {
      get => Conversions.ToDate(this[this.tableAllOpenTasks.DueDateColumn]);
      set => this[this.tableAllOpenTasks.DueDateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string Body
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableAllOpenTasks.BodyColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Body' in table 'AllOpenTasks' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableAllOpenTasks.BodyColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int Type
    {
      get => Conversions.ToInteger(this[this.tableAllOpenTasks.TypeColumn]);
      set => this[this.tableAllOpenTasks.TypeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string Subject
    {
      get => Conversions.ToString(this[this.tableAllOpenTasks.SubjectColumn]);
      set => this[this.tableAllOpenTasks.SubjectColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string PolicyNumber
    {
      get
      {
        return !this.IsPolicyNumberNull() ? Conversions.ToString(this[this.tableAllOpenTasks.PolicyNumberColumn]) : string.Empty;
      }
      set => this[this.tableAllOpenTasks.PolicyNumberColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string InsuredPolicyName
    {
      get
      {
        return !this.IsInsuredPolicyNameNull() ? Conversions.ToString(this[this.tableAllOpenTasks.InsuredPolicyNameColumn]) : string.Empty;
      }
      set => this[this.tableAllOpenTasks.InsuredPolicyNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string UnderwriterName
    {
      get
      {
        return !this.IsUnderwriterNameNull() ? Conversions.ToString(this[this.tableAllOpenTasks.UnderwriterNameColumn]) : string.Empty;
      }
      set => this[this.tableAllOpenTasks.UnderwriterNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string Producer
    {
      get
      {
        return !this.IsProducerNull() ? Conversions.ToString(this[this.tableAllOpenTasks.ProducerColumn]) : string.Empty;
      }
      set => this[this.tableAllOpenTasks.ProducerColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string NoteType
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableAllOpenTasks.NoteTypeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'NoteType' in table 'AllOpenTasks' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableAllOpenTasks.NoteTypeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int ControlNo
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tableAllOpenTasks.ControlNoColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ControlNo' in table 'AllOpenTasks' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableAllOpenTasks.ControlNoColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DateTime EffectiveDate
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tableAllOpenTasks.EffectiveDateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'EffectiveDate' in table 'AllOpenTasks' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableAllOpenTasks.EffectiveDateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string StateID
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableAllOpenTasks.StateIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'StateID' in table 'AllOpenTasks' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableAllOpenTasks.StateIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string DisplayStatus
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableAllOpenTasks.DisplayStatusColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DisplayStatus' in table 'AllOpenTasks' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableAllOpenTasks.DisplayStatusColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string ClaimNumber
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableAllOpenTasks.ClaimNumberColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ClaimNumber' in table 'AllOpenTasks' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableAllOpenTasks.ClaimNumberColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string PolicyType
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableAllOpenTasks.PolicyTypeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'PolicyType' in table 'AllOpenTasks' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableAllOpenTasks.PolicyTypeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string LOB
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableAllOpenTasks.LOBColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'LOB' in table 'AllOpenTasks' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableAllOpenTasks.LOBColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Decimal Premium
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tableAllOpenTasks.PremiumColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Premium' in table 'AllOpenTasks' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableAllOpenTasks.PremiumColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DateTime NeededByDate
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tableAllOpenTasks.NeededByDateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'NeededByDate' in table 'AllOpenTasks' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableAllOpenTasks.NeededByDateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DateTime ExpirationDate
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tableAllOpenTasks.ExpirationDateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ExpirationDate' in table 'AllOpenTasks' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableAllOpenTasks.ExpirationDateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string Carrier
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableAllOpenTasks.CarrierColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Carrier' in table 'AllOpenTasks' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableAllOpenTasks.CarrierColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsBodyNull() => this.IsNull(this.tableAllOpenTasks.BodyColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetBodyNull()
    {
      this[this.tableAllOpenTasks.BodyColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsPolicyNumberNull() => this.IsNull(this.tableAllOpenTasks.PolicyNumberColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetPolicyNumberNull()
    {
      this[this.tableAllOpenTasks.PolicyNumberColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsInsuredPolicyNameNull()
    {
      return this.IsNull(this.tableAllOpenTasks.InsuredPolicyNameColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetInsuredPolicyNameNull()
    {
      this[this.tableAllOpenTasks.InsuredPolicyNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsUnderwriterNameNull()
    {
      return this.IsNull(this.tableAllOpenTasks.UnderwriterNameColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetUnderwriterNameNull()
    {
      this[this.tableAllOpenTasks.UnderwriterNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsProducerNull() => this.IsNull(this.tableAllOpenTasks.ProducerColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetProducerNull()
    {
      this[this.tableAllOpenTasks.ProducerColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsNoteTypeNull() => this.IsNull(this.tableAllOpenTasks.NoteTypeColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetNoteTypeNull()
    {
      this[this.tableAllOpenTasks.NoteTypeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsControlNoNull() => this.IsNull(this.tableAllOpenTasks.ControlNoColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetControlNoNull()
    {
      this[this.tableAllOpenTasks.ControlNoColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsEffectiveDateNull() => this.IsNull(this.tableAllOpenTasks.EffectiveDateColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetEffectiveDateNull()
    {
      this[this.tableAllOpenTasks.EffectiveDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsStateIDNull() => this.IsNull(this.tableAllOpenTasks.StateIDColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetStateIDNull()
    {
      this[this.tableAllOpenTasks.StateIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsDisplayStatusNull() => this.IsNull(this.tableAllOpenTasks.DisplayStatusColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetDisplayStatusNull()
    {
      this[this.tableAllOpenTasks.DisplayStatusColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsClaimNumberNull() => this.IsNull(this.tableAllOpenTasks.ClaimNumberColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetClaimNumberNull()
    {
      this[this.tableAllOpenTasks.ClaimNumberColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsPolicyTypeNull() => this.IsNull(this.tableAllOpenTasks.PolicyTypeColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetPolicyTypeNull()
    {
      this[this.tableAllOpenTasks.PolicyTypeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsLOBNull() => this.IsNull(this.tableAllOpenTasks.LOBColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetLOBNull()
    {
      this[this.tableAllOpenTasks.LOBColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsPremiumNull() => this.IsNull(this.tableAllOpenTasks.PremiumColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetPremiumNull()
    {
      this[this.tableAllOpenTasks.PremiumColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsNeededByDateNull() => this.IsNull(this.tableAllOpenTasks.NeededByDateColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetNeededByDateNull()
    {
      this[this.tableAllOpenTasks.NeededByDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsExpirationDateNull() => this.IsNull(this.tableAllOpenTasks.ExpirationDateColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetExpirationDateNull()
    {
      this[this.tableAllOpenTasks.ExpirationDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsCarrierNull() => this.IsNull(this.tableAllOpenTasks.CarrierColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetCarrierNull()
    {
      this[this.tableAllOpenTasks.CarrierColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class UserOpenTasksRow : DataRow
  {
    private dsIMSTaskManagement.UserOpenTasksDataTable tableUserOpenTasks;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal UserOpenTasksRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableUserOpenTasks = (dsIMSTaskManagement.UserOpenTasksDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Guid EntryGUID
    {
      get
      {
        object obj = this[this.tableUserOpenTasks.EntryGUIDColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tableUserOpenTasks.EntryGUIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Guid NoteGUID
    {
      get
      {
        object obj = this[this.tableUserOpenTasks.NoteGUIDColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tableUserOpenTasks.NoteGUIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DateTime CreatedDate
    {
      get => Conversions.ToDate(this[this.tableUserOpenTasks.CreatedDateColumn]);
      set => this[this.tableUserOpenTasks.CreatedDateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DateTime DueDate
    {
      get => Conversions.ToDate(this[this.tableUserOpenTasks.DueDateColumn]);
      set => this[this.tableUserOpenTasks.DueDateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string Body
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableUserOpenTasks.BodyColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Body' in table 'UserOpenTasks' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableUserOpenTasks.BodyColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int Type
    {
      get => Conversions.ToInteger(this[this.tableUserOpenTasks.TypeColumn]);
      set => this[this.tableUserOpenTasks.TypeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string Subject
    {
      get => Conversions.ToString(this[this.tableUserOpenTasks.SubjectColumn]);
      set => this[this.tableUserOpenTasks.SubjectColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string PolicyNumber
    {
      get
      {
        return !this.IsPolicyNumberNull() ? Conversions.ToString(this[this.tableUserOpenTasks.PolicyNumberColumn]) : string.Empty;
      }
      set => this[this.tableUserOpenTasks.PolicyNumberColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string InsuredPolicyName
    {
      get
      {
        return !this.IsInsuredPolicyNameNull() ? Conversions.ToString(this[this.tableUserOpenTasks.InsuredPolicyNameColumn]) : string.Empty;
      }
      set => this[this.tableUserOpenTasks.InsuredPolicyNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string UnderwriterName
    {
      get
      {
        return !this.IsUnderwriterNameNull() ? Conversions.ToString(this[this.tableUserOpenTasks.UnderwriterNameColumn]) : string.Empty;
      }
      set => this[this.tableUserOpenTasks.UnderwriterNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string Producer
    {
      get
      {
        return !this.IsProducerNull() ? Conversions.ToString(this[this.tableUserOpenTasks.ProducerColumn]) : string.Empty;
      }
      set => this[this.tableUserOpenTasks.ProducerColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string NoteType
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableUserOpenTasks.NoteTypeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'NoteType' in table 'UserOpenTasks' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableUserOpenTasks.NoteTypeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int ControlNo
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tableUserOpenTasks.ControlNoColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ControlNo' in table 'UserOpenTasks' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableUserOpenTasks.ControlNoColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DateTime EffectiveDate
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tableUserOpenTasks.EffectiveDateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'EffectiveDate' in table 'UserOpenTasks' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableUserOpenTasks.EffectiveDateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string StateID
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableUserOpenTasks.StateIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'StateID' in table 'UserOpenTasks' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableUserOpenTasks.StateIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string DisplayStatus
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableUserOpenTasks.DisplayStatusColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DisplayStatus' in table 'UserOpenTasks' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableUserOpenTasks.DisplayStatusColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string ClaimNumber
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableUserOpenTasks.ClaimNumberColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ClaimNumber' in table 'UserOpenTasks' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableUserOpenTasks.ClaimNumberColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string PolicyType
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableUserOpenTasks.PolicyTypeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'PolicyType' in table 'UserOpenTasks' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableUserOpenTasks.PolicyTypeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string LOB
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableUserOpenTasks.LOBColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'LOB' in table 'UserOpenTasks' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableUserOpenTasks.LOBColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Decimal Premium
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tableUserOpenTasks.PremiumColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Premium' in table 'UserOpenTasks' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableUserOpenTasks.PremiumColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DateTime NeededByDate
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tableUserOpenTasks.NeededByDateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'NeededByDate' in table 'UserOpenTasks' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableUserOpenTasks.NeededByDateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DateTime ExpirationDate
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tableUserOpenTasks.ExpirationDateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ExpirationDate' in table 'UserOpenTasks' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableUserOpenTasks.ExpirationDateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string Carrier
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableUserOpenTasks.CarrierColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Carrier' in table 'UserOpenTasks' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableUserOpenTasks.CarrierColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsBodyNull() => this.IsNull(this.tableUserOpenTasks.BodyColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetBodyNull()
    {
      this[this.tableUserOpenTasks.BodyColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsPolicyNumberNull() => this.IsNull(this.tableUserOpenTasks.PolicyNumberColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetPolicyNumberNull()
    {
      this[this.tableUserOpenTasks.PolicyNumberColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsInsuredPolicyNameNull()
    {
      return this.IsNull(this.tableUserOpenTasks.InsuredPolicyNameColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetInsuredPolicyNameNull()
    {
      this[this.tableUserOpenTasks.InsuredPolicyNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsUnderwriterNameNull()
    {
      return this.IsNull(this.tableUserOpenTasks.UnderwriterNameColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetUnderwriterNameNull()
    {
      this[this.tableUserOpenTasks.UnderwriterNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsProducerNull() => this.IsNull(this.tableUserOpenTasks.ProducerColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetProducerNull()
    {
      this[this.tableUserOpenTasks.ProducerColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsNoteTypeNull() => this.IsNull(this.tableUserOpenTasks.NoteTypeColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetNoteTypeNull()
    {
      this[this.tableUserOpenTasks.NoteTypeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsControlNoNull() => this.IsNull(this.tableUserOpenTasks.ControlNoColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetControlNoNull()
    {
      this[this.tableUserOpenTasks.ControlNoColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsEffectiveDateNull() => this.IsNull(this.tableUserOpenTasks.EffectiveDateColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetEffectiveDateNull()
    {
      this[this.tableUserOpenTasks.EffectiveDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsStateIDNull() => this.IsNull(this.tableUserOpenTasks.StateIDColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetStateIDNull()
    {
      this[this.tableUserOpenTasks.StateIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsDisplayStatusNull() => this.IsNull(this.tableUserOpenTasks.DisplayStatusColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetDisplayStatusNull()
    {
      this[this.tableUserOpenTasks.DisplayStatusColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsClaimNumberNull() => this.IsNull(this.tableUserOpenTasks.ClaimNumberColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetClaimNumberNull()
    {
      this[this.tableUserOpenTasks.ClaimNumberColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsPolicyTypeNull() => this.IsNull(this.tableUserOpenTasks.PolicyTypeColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetPolicyTypeNull()
    {
      this[this.tableUserOpenTasks.PolicyTypeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsLOBNull() => this.IsNull(this.tableUserOpenTasks.LOBColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetLOBNull()
    {
      this[this.tableUserOpenTasks.LOBColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsPremiumNull() => this.IsNull(this.tableUserOpenTasks.PremiumColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetPremiumNull()
    {
      this[this.tableUserOpenTasks.PremiumColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsNeededByDateNull() => this.IsNull(this.tableUserOpenTasks.NeededByDateColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetNeededByDateNull()
    {
      this[this.tableUserOpenTasks.NeededByDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsExpirationDateNull() => this.IsNull(this.tableUserOpenTasks.ExpirationDateColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetExpirationDateNull()
    {
      this[this.tableUserOpenTasks.ExpirationDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsCarrierNull() => this.IsNull(this.tableUserOpenTasks.CarrierColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetCarrierNull()
    {
      this[this.tableUserOpenTasks.CarrierColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class AllOpenTasksRowChangeEvent : EventArgs
  {
    private dsIMSTaskManagement.AllOpenTasksRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public AllOpenTasksRowChangeEvent(dsIMSTaskManagement.AllOpenTasksRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsIMSTaskManagement.AllOpenTasksRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class UserOpenTasksRowChangeEvent : EventArgs
  {
    private dsIMSTaskManagement.UserOpenTasksRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public UserOpenTasksRowChangeEvent(
      dsIMSTaskManagement.UserOpenTasksRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsIMSTaskManagement.UserOpenTasksRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }
}
