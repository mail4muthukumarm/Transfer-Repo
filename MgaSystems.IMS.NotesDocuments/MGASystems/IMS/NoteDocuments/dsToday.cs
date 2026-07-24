// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.NoteDocuments.dsToday
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
[XmlRoot("dsToday")]
[HelpKeyword("vs.data.DataSet")]
[Serializable]
public class dsToday : DataSet
{
  private dsToday.tblUrgentDiariesDataTable tabletblUrgentDiaries;
  private dsToday.tblNotesDataTable tabletblNotes;
  private SchemaSerializationMode _schemaSerializationMode;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public dsToday()
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
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  protected dsToday(SerializationInfo info, StreamingContext context)
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
        if (dataSet.Tables[nameof (tblUrgentDiaries)] != null)
          base.Tables.Add((DataTable) new dsToday.tblUrgentDiariesDataTable(dataSet.Tables[nameof (tblUrgentDiaries)]));
        if (dataSet.Tables[nameof (tblNotes)] != null)
          base.Tables.Add((DataTable) new dsToday.tblNotesDataTable(dataSet.Tables[nameof (tblNotes)]));
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
  public dsToday.tblUrgentDiariesDataTable tblUrgentDiaries => this.tabletblUrgentDiaries;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsToday.tblNotesDataTable tblNotes => this.tabletblNotes;

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
    dsToday dsToday = (dsToday) base.Clone();
    dsToday.InitVars();
    dsToday.SchemaSerializationMode = this.SchemaSerializationMode;
    return (DataSet) dsToday;
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
      if (dataSet.Tables["tblUrgentDiaries"] != null)
        base.Tables.Add((DataTable) new dsToday.tblUrgentDiariesDataTable(dataSet.Tables["tblUrgentDiaries"]));
      if (dataSet.Tables["tblNotes"] != null)
        base.Tables.Add((DataTable) new dsToday.tblNotesDataTable(dataSet.Tables["tblNotes"]));
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
    this.tabletblUrgentDiaries = (dsToday.tblUrgentDiariesDataTable) base.Tables["tblUrgentDiaries"];
    if (initTable && this.tabletblUrgentDiaries != null)
      this.tabletblUrgentDiaries.InitVars();
    this.tabletblNotes = (dsToday.tblNotesDataTable) base.Tables["tblNotes"];
    if (!initTable || this.tabletblNotes == null)
      return;
    this.tabletblNotes.InitVars();
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private void InitClass()
  {
    this.DataSetName = nameof (dsToday);
    this.Prefix = "";
    this.Namespace = "http://tempuri.org/dsToday.xsd";
    this.EnforceConstraints = true;
    this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.tabletblUrgentDiaries = new dsToday.tblUrgentDiariesDataTable();
    base.Tables.Add((DataTable) this.tabletblUrgentDiaries);
    this.tabletblNotes = new dsToday.tblNotesDataTable();
    base.Tables.Add((DataTable) this.tabletblNotes);
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializetblUrgentDiaries() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializetblNotes() => false;

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
    dsToday dsToday = new dsToday();
    XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
    schemaComplexType.Particle = (XmlSchemaParticle) new XmlSchemaSequence()
    {
      Items = {
        (XmlSchemaObject) new XmlSchemaAny()
        {
          Namespace = dsToday.Namespace
        }
      }
    };
    XmlSchema schemaSerializable = dsToday.GetSchemaSerializable();
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

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public delegate void tblUrgentDiariesRowChangeEventHandler(
    object sender,
    dsToday.tblUrgentDiariesRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public delegate void tblNotesRowChangeEventHandler(
    object sender,
    dsToday.tblNotesRowChangeEvent e);

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class tblUrgentDiariesDataTable : TypedTableBase<dsToday.tblUrgentDiariesRow>
  {
    private DataColumn columnEntryGUID;
    private DataColumn columnCompleted;
    private DataColumn columnBody;
    private DataColumn columnDueDate;
    private DataColumn columnPolicyNumber;
    private DataColumn columnInsuredPolicyName;
    private DataColumn columnNoteType;
    private DataColumn columnEffectiveDate;
    private DataColumn columnCreatedDate;
    private DataColumn columnControlNo;
    private DataColumn columnSubject;
    private DataColumn columnProducerContact;
    private DataColumn columnLineOfBusiness;
    private DataColumn columnQuoteStatus;
    private DataColumn columnPolicyType;
    private DataColumn columnStateID;
    private DataColumn columnUnderwriterName;
    private DataColumn columnPremium;
    private DataColumn columnFrom;
    private DataColumn columnNeededByDate;
    private DataColumn columnClaimNumber;
    private DataColumn columnExpirationDate;
    private DataColumn columnProducerLocationName;
    private DataColumn columnDBA;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public tblUrgentDiariesDataTable()
    {
      this.TableName = "tblUrgentDiaries";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal tblUrgentDiariesDataTable(DataTable table)
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected tblUrgentDiariesDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn EntryGUIDColumn => this.columnEntryGUID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn CompletedColumn => this.columnCompleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn BodyColumn => this.columnBody;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn DueDateColumn => this.columnDueDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn PolicyNumberColumn => this.columnPolicyNumber;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn InsuredPolicyNameColumn => this.columnInsuredPolicyName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn NoteTypeColumn => this.columnNoteType;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn EffectiveDateColumn => this.columnEffectiveDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn CreatedDateColumn => this.columnCreatedDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ControlNoColumn => this.columnControlNo;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn SubjectColumn => this.columnSubject;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ProducerContactColumn => this.columnProducerContact;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn LineOfBusinessColumn => this.columnLineOfBusiness;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn QuoteStatusColumn => this.columnQuoteStatus;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn PolicyTypeColumn => this.columnPolicyType;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn StateIDColumn => this.columnStateID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn UnderwriterNameColumn => this.columnUnderwriterName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn PremiumColumn => this.columnPremium;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn FromColumn => this.columnFrom;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn NeededByDateColumn => this.columnNeededByDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ClaimNumberColumn => this.columnClaimNumber;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ExpirationDateColumn => this.columnExpirationDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ProducerLocationNameColumn => this.columnProducerLocationName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn DBAColumn => this.columnDBA;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsToday.tblUrgentDiariesRow this[int index]
    {
      get => (dsToday.tblUrgentDiariesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsToday.tblUrgentDiariesRowChangeEventHandler tblUrgentDiariesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsToday.tblUrgentDiariesRowChangeEventHandler tblUrgentDiariesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsToday.tblUrgentDiariesRowChangeEventHandler tblUrgentDiariesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsToday.tblUrgentDiariesRowChangeEventHandler tblUrgentDiariesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AddtblUrgentDiariesRow(dsToday.tblUrgentDiariesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsToday.tblUrgentDiariesRow AddtblUrgentDiariesRow(
      Guid EntryGUID,
      bool Completed,
      string Body,
      DateTime DueDate,
      string PolicyNumber,
      string InsuredPolicyName,
      string NoteType,
      DateTime EffectiveDate,
      DateTime CreatedDate,
      int ControlNo,
      string Subject,
      string ProducerContact,
      string LineOfBusiness,
      string QuoteStatus,
      string PolicyType,
      string StateID,
      string UnderwriterName,
      Decimal Premium,
      string From,
      DateTime NeededByDate,
      string ClaimNumber,
      DateTime ExpirationDate,
      string ProducerLocationName,
      string DBA)
    {
      dsToday.tblUrgentDiariesRow row = (dsToday.tblUrgentDiariesRow) this.NewRow();
      object[] objArray = new object[24]
      {
        (object) EntryGUID,
        (object) Completed,
        (object) Body,
        (object) DueDate,
        (object) PolicyNumber,
        (object) InsuredPolicyName,
        (object) NoteType,
        (object) EffectiveDate,
        (object) CreatedDate,
        (object) ControlNo,
        (object) Subject,
        (object) ProducerContact,
        (object) LineOfBusiness,
        (object) QuoteStatus,
        (object) PolicyType,
        (object) StateID,
        (object) UnderwriterName,
        (object) Premium,
        (object) From,
        (object) NeededByDate,
        (object) ClaimNumber,
        (object) ExpirationDate,
        (object) ProducerLocationName,
        (object) DBA
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsToday.tblUrgentDiariesDataTable diariesDataTable = (dsToday.tblUrgentDiariesDataTable) base.Clone();
      diariesDataTable.InitVars();
      return (DataTable) diariesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsToday.tblUrgentDiariesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal void InitVars()
    {
      this.columnEntryGUID = this.Columns["EntryGUID"];
      this.columnCompleted = this.Columns["Completed"];
      this.columnBody = this.Columns["Body"];
      this.columnDueDate = this.Columns["DueDate"];
      this.columnPolicyNumber = this.Columns["PolicyNumber"];
      this.columnInsuredPolicyName = this.Columns["InsuredPolicyName"];
      this.columnNoteType = this.Columns["NoteType"];
      this.columnEffectiveDate = this.Columns["EffectiveDate"];
      this.columnCreatedDate = this.Columns["CreatedDate"];
      this.columnControlNo = this.Columns["ControlNo"];
      this.columnSubject = this.Columns["Subject"];
      this.columnProducerContact = this.Columns["ProducerContact"];
      this.columnLineOfBusiness = this.Columns["LineOfBusiness"];
      this.columnQuoteStatus = this.Columns["QuoteStatus"];
      this.columnPolicyType = this.Columns["PolicyType"];
      this.columnStateID = this.Columns["StateID"];
      this.columnUnderwriterName = this.Columns["UnderwriterName"];
      this.columnPremium = this.Columns["Premium"];
      this.columnFrom = this.Columns["From"];
      this.columnNeededByDate = this.Columns["NeededByDate"];
      this.columnClaimNumber = this.Columns["ClaimNumber"];
      this.columnExpirationDate = this.Columns["ExpirationDate"];
      this.columnProducerLocationName = this.Columns["ProducerLocationName"];
      this.columnDBA = this.Columns["DBA"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    private void InitClass()
    {
      this.columnEntryGUID = new DataColumn("EntryGUID", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEntryGUID);
      this.columnCompleted = new DataColumn("Completed", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCompleted);
      this.columnBody = new DataColumn("Body", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnBody);
      this.columnDueDate = new DataColumn("DueDate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDueDate);
      this.columnPolicyNumber = new DataColumn("PolicyNumber", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPolicyNumber);
      this.columnInsuredPolicyName = new DataColumn("InsuredPolicyName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInsuredPolicyName);
      this.columnNoteType = new DataColumn("NoteType", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnNoteType);
      this.columnEffectiveDate = new DataColumn("EffectiveDate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEffectiveDate);
      this.columnCreatedDate = new DataColumn("CreatedDate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCreatedDate);
      this.columnControlNo = new DataColumn("ControlNo", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnControlNo);
      this.columnSubject = new DataColumn("Subject", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSubject);
      this.columnProducerContact = new DataColumn("ProducerContact", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnProducerContact);
      this.columnLineOfBusiness = new DataColumn("LineOfBusiness", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLineOfBusiness);
      this.columnQuoteStatus = new DataColumn("QuoteStatus", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnQuoteStatus);
      this.columnPolicyType = new DataColumn("PolicyType", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPolicyType);
      this.columnStateID = new DataColumn("StateID", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnStateID);
      this.columnUnderwriterName = new DataColumn("UnderwriterName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnUnderwriterName);
      this.columnPremium = new DataColumn("Premium", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPremium);
      this.columnFrom = new DataColumn("From", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFrom);
      this.columnNeededByDate = new DataColumn("NeededByDate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnNeededByDate);
      this.columnClaimNumber = new DataColumn("ClaimNumber", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnClaimNumber);
      this.columnExpirationDate = new DataColumn("ExpirationDate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnExpirationDate);
      this.columnProducerLocationName = new DataColumn("ProducerLocationName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnProducerLocationName);
      this.columnDBA = new DataColumn("DBA", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDBA);
      this.columnEntryGUID.AllowDBNull = false;
      this.columnBody.AllowDBNull = false;
      this.columnDueDate.AllowDBNull = false;
      this.columnPolicyNumber.AllowDBNull = false;
      this.columnInsuredPolicyName.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsToday.tblUrgentDiariesRow NewtblUrgentDiariesRow()
    {
      return (dsToday.tblUrgentDiariesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsToday.tblUrgentDiariesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType() => typeof (dsToday.tblUrgentDiariesRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblUrgentDiariesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsToday.tblUrgentDiariesRowChangeEventHandler diariesRowChangedEvent = this.tblUrgentDiariesRowChangedEvent;
      if (diariesRowChangedEvent == null)
        return;
      diariesRowChangedEvent((object) this, new dsToday.tblUrgentDiariesRowChangeEvent((dsToday.tblUrgentDiariesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblUrgentDiariesRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsToday.tblUrgentDiariesRowChangeEventHandler rowChangingEvent = this.tblUrgentDiariesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsToday.tblUrgentDiariesRowChangeEvent((dsToday.tblUrgentDiariesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblUrgentDiariesRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsToday.tblUrgentDiariesRowChangeEventHandler diariesRowDeletedEvent = this.tblUrgentDiariesRowDeletedEvent;
      if (diariesRowDeletedEvent == null)
        return;
      diariesRowDeletedEvent((object) this, new dsToday.tblUrgentDiariesRowChangeEvent((dsToday.tblUrgentDiariesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblUrgentDiariesRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsToday.tblUrgentDiariesRowChangeEventHandler rowDeletingEvent = this.tblUrgentDiariesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsToday.tblUrgentDiariesRowChangeEvent((dsToday.tblUrgentDiariesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemovetblUrgentDiariesRow(dsToday.tblUrgentDiariesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsToday dsToday = new dsToday();
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
        FixedValue = dsToday.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblUrgentDiariesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsToday.GetSchemaSerializable();
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
  public class tblNotesDataTable : TypedTableBase<dsToday.tblNotesRow>
  {
    private DataColumn columnEntryGUID;
    private DataColumn columnCompleted;
    private DataColumn columnBody;
    private DataColumn columnPolicyNumber;
    private DataColumn columnInsuredPolicyName;
    private DataColumn columnCreatedDate;
    private DataColumn columnNoteType;
    private DataColumn columnEffectiveDate;
    private DataColumn columnControlNo;
    private DataColumn columnSubject;
    private DataColumn columnProducerContact;
    private DataColumn columnLineOfBusiness;
    private DataColumn columnQuoteStatus;
    private DataColumn columnPolicyType;
    private DataColumn columnStateID;
    private DataColumn columnUnderwriterName;
    private DataColumn columnIsRead;
    private DataColumn columnPremium;
    private DataColumn columnFrom;
    private DataColumn columnNeededByDate;
    private DataColumn columnClaimNumber;
    private DataColumn columnExpirationDate;
    private DataColumn columnProducerLocationName;
    private DataColumn columnDBA;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public tblNotesDataTable()
    {
      this.TableName = "tblNotes";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal tblNotesDataTable(DataTable table)
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected tblNotesDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn EntryGUIDColumn => this.columnEntryGUID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn CompletedColumn => this.columnCompleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn BodyColumn => this.columnBody;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn PolicyNumberColumn => this.columnPolicyNumber;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn InsuredPolicyNameColumn => this.columnInsuredPolicyName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn CreatedDateColumn => this.columnCreatedDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn NoteTypeColumn => this.columnNoteType;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn EffectiveDateColumn => this.columnEffectiveDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ControlNoColumn => this.columnControlNo;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn SubjectColumn => this.columnSubject;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ProducerContactColumn => this.columnProducerContact;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn LineOfBusinessColumn => this.columnLineOfBusiness;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn QuoteStatusColumn => this.columnQuoteStatus;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn PolicyTypeColumn => this.columnPolicyType;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn StateIDColumn => this.columnStateID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn UnderwriterNameColumn => this.columnUnderwriterName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn IsReadColumn => this.columnIsRead;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn PremiumColumn => this.columnPremium;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn FromColumn => this.columnFrom;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn NeededByDateColumn => this.columnNeededByDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ClaimNumberColumn => this.columnClaimNumber;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ExpirationDateColumn => this.columnExpirationDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ProducerLocationNameColumn => this.columnProducerLocationName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn DBAColumn => this.columnDBA;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsToday.tblNotesRow this[int index] => (dsToday.tblNotesRow) this.Rows[index];

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsToday.tblNotesRowChangeEventHandler tblNotesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsToday.tblNotesRowChangeEventHandler tblNotesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsToday.tblNotesRowChangeEventHandler tblNotesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsToday.tblNotesRowChangeEventHandler tblNotesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AddtblNotesRow(dsToday.tblNotesRow row) => this.Rows.Add((DataRow) row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsToday.tblNotesRow AddtblNotesRow(
      Guid EntryGUID,
      bool Completed,
      string Body,
      string PolicyNumber,
      string InsuredPolicyName,
      DateTime CreatedDate,
      string NoteType,
      DateTime EffectiveDate,
      int ControlNo,
      string Subject,
      string ProducerContact,
      string LineOfBusiness,
      string QuoteStatus,
      string PolicyType,
      string StateID,
      string UnderwriterName,
      bool IsRead,
      Decimal Premium,
      string From,
      DateTime NeededByDate,
      string ClaimNumber,
      DateTime ExpirationDate,
      string ProducerLocationName,
      string DBA)
    {
      dsToday.tblNotesRow row = (dsToday.tblNotesRow) this.NewRow();
      object[] objArray = new object[24]
      {
        (object) EntryGUID,
        (object) Completed,
        (object) Body,
        (object) PolicyNumber,
        (object) InsuredPolicyName,
        (object) CreatedDate,
        (object) NoteType,
        (object) EffectiveDate,
        (object) ControlNo,
        (object) Subject,
        (object) ProducerContact,
        (object) LineOfBusiness,
        (object) QuoteStatus,
        (object) PolicyType,
        (object) StateID,
        (object) UnderwriterName,
        (object) IsRead,
        (object) Premium,
        (object) From,
        (object) NeededByDate,
        (object) ClaimNumber,
        (object) ExpirationDate,
        (object) ProducerLocationName,
        (object) DBA
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsToday.tblNotesDataTable tblNotesDataTable = (dsToday.tblNotesDataTable) base.Clone();
      tblNotesDataTable.InitVars();
      return (DataTable) tblNotesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance() => (DataTable) new dsToday.tblNotesDataTable();

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal void InitVars()
    {
      this.columnEntryGUID = this.Columns["EntryGUID"];
      this.columnCompleted = this.Columns["Completed"];
      this.columnBody = this.Columns["Body"];
      this.columnPolicyNumber = this.Columns["PolicyNumber"];
      this.columnInsuredPolicyName = this.Columns["InsuredPolicyName"];
      this.columnCreatedDate = this.Columns["CreatedDate"];
      this.columnNoteType = this.Columns["NoteType"];
      this.columnEffectiveDate = this.Columns["EffectiveDate"];
      this.columnControlNo = this.Columns["ControlNo"];
      this.columnSubject = this.Columns["Subject"];
      this.columnProducerContact = this.Columns["ProducerContact"];
      this.columnLineOfBusiness = this.Columns["LineOfBusiness"];
      this.columnQuoteStatus = this.Columns["QuoteStatus"];
      this.columnPolicyType = this.Columns["PolicyType"];
      this.columnStateID = this.Columns["StateID"];
      this.columnUnderwriterName = this.Columns["UnderwriterName"];
      this.columnIsRead = this.Columns["IsRead"];
      this.columnPremium = this.Columns["Premium"];
      this.columnFrom = this.Columns["From"];
      this.columnNeededByDate = this.Columns["NeededByDate"];
      this.columnClaimNumber = this.Columns["ClaimNumber"];
      this.columnExpirationDate = this.Columns["ExpirationDate"];
      this.columnProducerLocationName = this.Columns["ProducerLocationName"];
      this.columnDBA = this.Columns["DBA"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    private void InitClass()
    {
      this.columnEntryGUID = new DataColumn("EntryGUID", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEntryGUID);
      this.columnCompleted = new DataColumn("Completed", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCompleted);
      this.columnBody = new DataColumn("Body", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnBody);
      this.columnPolicyNumber = new DataColumn("PolicyNumber", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPolicyNumber);
      this.columnInsuredPolicyName = new DataColumn("InsuredPolicyName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInsuredPolicyName);
      this.columnCreatedDate = new DataColumn("CreatedDate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCreatedDate);
      this.columnNoteType = new DataColumn("NoteType", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnNoteType);
      this.columnEffectiveDate = new DataColumn("EffectiveDate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEffectiveDate);
      this.columnControlNo = new DataColumn("ControlNo", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnControlNo);
      this.columnSubject = new DataColumn("Subject", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSubject);
      this.columnProducerContact = new DataColumn("ProducerContact", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnProducerContact);
      this.columnLineOfBusiness = new DataColumn("LineOfBusiness", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLineOfBusiness);
      this.columnQuoteStatus = new DataColumn("QuoteStatus", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnQuoteStatus);
      this.columnPolicyType = new DataColumn("PolicyType", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPolicyType);
      this.columnStateID = new DataColumn("StateID", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnStateID);
      this.columnUnderwriterName = new DataColumn("UnderwriterName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnUnderwriterName);
      this.columnIsRead = new DataColumn("IsRead", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnIsRead);
      this.columnPremium = new DataColumn("Premium", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPremium);
      this.columnFrom = new DataColumn("From", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFrom);
      this.columnNeededByDate = new DataColumn("NeededByDate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnNeededByDate);
      this.columnClaimNumber = new DataColumn("ClaimNumber", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnClaimNumber);
      this.columnExpirationDate = new DataColumn("ExpirationDate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnExpirationDate);
      this.columnProducerLocationName = new DataColumn("ProducerLocationName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnProducerLocationName);
      this.columnDBA = new DataColumn("DBA", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDBA);
      this.columnEntryGUID.AllowDBNull = false;
      this.columnBody.AllowDBNull = false;
      this.columnPolicyNumber.AllowDBNull = false;
      this.columnInsuredPolicyName.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsToday.tblNotesRow NewtblNotesRow() => (dsToday.tblNotesRow) this.NewRow();

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsToday.tblNotesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType() => typeof (dsToday.tblNotesRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblNotesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsToday.tblNotesRowChangeEventHandler notesRowChangedEvent = this.tblNotesRowChangedEvent;
      if (notesRowChangedEvent == null)
        return;
      notesRowChangedEvent((object) this, new dsToday.tblNotesRowChangeEvent((dsToday.tblNotesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblNotesRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsToday.tblNotesRowChangeEventHandler rowChangingEvent = this.tblNotesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsToday.tblNotesRowChangeEvent((dsToday.tblNotesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblNotesRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsToday.tblNotesRowChangeEventHandler notesRowDeletedEvent = this.tblNotesRowDeletedEvent;
      if (notesRowDeletedEvent == null)
        return;
      notesRowDeletedEvent((object) this, new dsToday.tblNotesRowChangeEvent((dsToday.tblNotesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblNotesRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsToday.tblNotesRowChangeEventHandler rowDeletingEvent = this.tblNotesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsToday.tblNotesRowChangeEvent((dsToday.tblNotesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemovetblNotesRow(dsToday.tblNotesRow row) => this.Rows.Remove((DataRow) row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsToday dsToday = new dsToday();
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
        FixedValue = dsToday.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblNotesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsToday.GetSchemaSerializable();
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

  public class tblUrgentDiariesRow : DataRow
  {
    private dsToday.tblUrgentDiariesDataTable tabletblUrgentDiaries;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal tblUrgentDiariesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblUrgentDiaries = (dsToday.tblUrgentDiariesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Guid EntryGUID
    {
      get
      {
        object obj = this[this.tabletblUrgentDiaries.EntryGUIDColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tabletblUrgentDiaries.EntryGUIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool Completed
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tabletblUrgentDiaries.CompletedColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Completed' in table 'tblUrgentDiaries' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblUrgentDiaries.CompletedColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string Body
    {
      get => Conversions.ToString(this[this.tabletblUrgentDiaries.BodyColumn]);
      set => this[this.tabletblUrgentDiaries.BodyColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DateTime DueDate
    {
      get => Conversions.ToDate(this[this.tabletblUrgentDiaries.DueDateColumn]);
      set => this[this.tabletblUrgentDiaries.DueDateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string PolicyNumber
    {
      get => Conversions.ToString(this[this.tabletblUrgentDiaries.PolicyNumberColumn]);
      set => this[this.tabletblUrgentDiaries.PolicyNumberColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string InsuredPolicyName
    {
      get => Conversions.ToString(this[this.tabletblUrgentDiaries.InsuredPolicyNameColumn]);
      set => this[this.tabletblUrgentDiaries.InsuredPolicyNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string NoteType
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblUrgentDiaries.NoteTypeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'NoteType' in table 'tblUrgentDiaries' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblUrgentDiaries.NoteTypeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DateTime EffectiveDate
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tabletblUrgentDiaries.EffectiveDateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'EffectiveDate' in table 'tblUrgentDiaries' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblUrgentDiaries.EffectiveDateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DateTime CreatedDate
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tabletblUrgentDiaries.CreatedDateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'CreatedDate' in table 'tblUrgentDiaries' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblUrgentDiaries.CreatedDateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int ControlNo
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblUrgentDiaries.ControlNoColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ControlNo' in table 'tblUrgentDiaries' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblUrgentDiaries.ControlNoColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string Subject
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblUrgentDiaries.SubjectColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Subject' in table 'tblUrgentDiaries' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblUrgentDiaries.SubjectColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string ProducerContact
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblUrgentDiaries.ProducerContactColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ProducerContact' in table 'tblUrgentDiaries' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblUrgentDiaries.ProducerContactColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string LineOfBusiness
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblUrgentDiaries.LineOfBusinessColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'LineOfBusiness' in table 'tblUrgentDiaries' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblUrgentDiaries.LineOfBusinessColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string QuoteStatus
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblUrgentDiaries.QuoteStatusColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'QuoteStatus' in table 'tblUrgentDiaries' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblUrgentDiaries.QuoteStatusColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string PolicyType
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblUrgentDiaries.PolicyTypeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'PolicyType' in table 'tblUrgentDiaries' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblUrgentDiaries.PolicyTypeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string StateID
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblUrgentDiaries.StateIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'StateID' in table 'tblUrgentDiaries' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblUrgentDiaries.StateIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string UnderwriterName
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblUrgentDiaries.UnderwriterNameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'UnderwriterName' in table 'tblUrgentDiaries' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblUrgentDiaries.UnderwriterNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Decimal Premium
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tabletblUrgentDiaries.PremiumColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Premium' in table 'tblUrgentDiaries' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblUrgentDiaries.PremiumColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string From
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblUrgentDiaries.FromColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'From' in table 'tblUrgentDiaries' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblUrgentDiaries.FromColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DateTime NeededByDate
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tabletblUrgentDiaries.NeededByDateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'NeededByDate' in table 'tblUrgentDiaries' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblUrgentDiaries.NeededByDateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string ClaimNumber
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblUrgentDiaries.ClaimNumberColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ClaimNumber' in table 'tblUrgentDiaries' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblUrgentDiaries.ClaimNumberColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DateTime ExpirationDate
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tabletblUrgentDiaries.ExpirationDateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ExpirationDate' in table 'tblUrgentDiaries' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblUrgentDiaries.ExpirationDateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string ProducerLocationName
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblUrgentDiaries.ProducerLocationNameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ProducerLocationName' in table 'tblUrgentDiaries' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblUrgentDiaries.ProducerLocationNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string DBA
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblUrgentDiaries.DBAColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DBA' in table 'tblUrgentDiaries' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblUrgentDiaries.DBAColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsCompletedNull() => this.IsNull(this.tabletblUrgentDiaries.CompletedColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetCompletedNull()
    {
      this[this.tabletblUrgentDiaries.CompletedColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsNoteTypeNull() => this.IsNull(this.tabletblUrgentDiaries.NoteTypeColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetNoteTypeNull()
    {
      this[this.tabletblUrgentDiaries.NoteTypeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsEffectiveDateNull()
    {
      return this.IsNull(this.tabletblUrgentDiaries.EffectiveDateColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetEffectiveDateNull()
    {
      this[this.tabletblUrgentDiaries.EffectiveDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsCreatedDateNull() => this.IsNull(this.tabletblUrgentDiaries.CreatedDateColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetCreatedDateNull()
    {
      this[this.tabletblUrgentDiaries.CreatedDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsControlNoNull() => this.IsNull(this.tabletblUrgentDiaries.ControlNoColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetControlNoNull()
    {
      this[this.tabletblUrgentDiaries.ControlNoColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsSubjectNull() => this.IsNull(this.tabletblUrgentDiaries.SubjectColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetSubjectNull()
    {
      this[this.tabletblUrgentDiaries.SubjectColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsProducerContactNull()
    {
      return this.IsNull(this.tabletblUrgentDiaries.ProducerContactColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetProducerContactNull()
    {
      this[this.tabletblUrgentDiaries.ProducerContactColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsLineOfBusinessNull()
    {
      return this.IsNull(this.tabletblUrgentDiaries.LineOfBusinessColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetLineOfBusinessNull()
    {
      this[this.tabletblUrgentDiaries.LineOfBusinessColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsQuoteStatusNull() => this.IsNull(this.tabletblUrgentDiaries.QuoteStatusColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetQuoteStatusNull()
    {
      this[this.tabletblUrgentDiaries.QuoteStatusColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsPolicyTypeNull() => this.IsNull(this.tabletblUrgentDiaries.PolicyTypeColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetPolicyTypeNull()
    {
      this[this.tabletblUrgentDiaries.PolicyTypeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsStateIDNull() => this.IsNull(this.tabletblUrgentDiaries.StateIDColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetStateIDNull()
    {
      this[this.tabletblUrgentDiaries.StateIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsUnderwriterNameNull()
    {
      return this.IsNull(this.tabletblUrgentDiaries.UnderwriterNameColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetUnderwriterNameNull()
    {
      this[this.tabletblUrgentDiaries.UnderwriterNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsPremiumNull() => this.IsNull(this.tabletblUrgentDiaries.PremiumColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetPremiumNull()
    {
      this[this.tabletblUrgentDiaries.PremiumColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsFromNull() => this.IsNull(this.tabletblUrgentDiaries.FromColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetFromNull()
    {
      this[this.tabletblUrgentDiaries.FromColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsNeededByDateNull() => this.IsNull(this.tabletblUrgentDiaries.NeededByDateColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetNeededByDateNull()
    {
      this[this.tabletblUrgentDiaries.NeededByDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsClaimNumberNull() => this.IsNull(this.tabletblUrgentDiaries.ClaimNumberColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetClaimNumberNull()
    {
      this[this.tabletblUrgentDiaries.ClaimNumberColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsExpirationDateNull()
    {
      return this.IsNull(this.tabletblUrgentDiaries.ExpirationDateColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetExpirationDateNull()
    {
      this[this.tabletblUrgentDiaries.ExpirationDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsProducerLocationNameNull()
    {
      return this.IsNull(this.tabletblUrgentDiaries.ProducerLocationNameColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetProducerLocationNameNull()
    {
      this[this.tabletblUrgentDiaries.ProducerLocationNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsDBANull() => this.IsNull(this.tabletblUrgentDiaries.DBAColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetDBANull()
    {
      this[this.tabletblUrgentDiaries.DBAColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class tblNotesRow : DataRow
  {
    private dsToday.tblNotesDataTable tabletblNotes;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal tblNotesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblNotes = (dsToday.tblNotesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Guid EntryGUID
    {
      get
      {
        object obj = this[this.tabletblNotes.EntryGUIDColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tabletblNotes.EntryGUIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool Completed
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tabletblNotes.CompletedColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Completed' in table 'tblNotes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblNotes.CompletedColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string Body
    {
      get => Conversions.ToString(this[this.tabletblNotes.BodyColumn]);
      set => this[this.tabletblNotes.BodyColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string PolicyNumber
    {
      get => Conversions.ToString(this[this.tabletblNotes.PolicyNumberColumn]);
      set => this[this.tabletblNotes.PolicyNumberColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string InsuredPolicyName
    {
      get => Conversions.ToString(this[this.tabletblNotes.InsuredPolicyNameColumn]);
      set => this[this.tabletblNotes.InsuredPolicyNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DateTime CreatedDate
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tabletblNotes.CreatedDateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'CreatedDate' in table 'tblNotes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblNotes.CreatedDateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string NoteType
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblNotes.NoteTypeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'NoteType' in table 'tblNotes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblNotes.NoteTypeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DateTime EffectiveDate
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tabletblNotes.EffectiveDateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'EffectiveDate' in table 'tblNotes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblNotes.EffectiveDateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int ControlNo
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblNotes.ControlNoColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ControlNo' in table 'tblNotes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblNotes.ControlNoColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string Subject
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblNotes.SubjectColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Subject' in table 'tblNotes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblNotes.SubjectColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string ProducerContact
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblNotes.ProducerContactColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ProducerContact' in table 'tblNotes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblNotes.ProducerContactColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string LineOfBusiness
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblNotes.LineOfBusinessColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'LineOfBusiness' in table 'tblNotes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblNotes.LineOfBusinessColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string QuoteStatus
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblNotes.QuoteStatusColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'QuoteStatus' in table 'tblNotes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblNotes.QuoteStatusColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string PolicyType
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblNotes.PolicyTypeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'PolicyType' in table 'tblNotes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblNotes.PolicyTypeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string StateID
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblNotes.StateIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'StateID' in table 'tblNotes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblNotes.StateIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string UnderwriterName
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblNotes.UnderwriterNameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'UnderwriterName' in table 'tblNotes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblNotes.UnderwriterNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsRead
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tabletblNotes.IsReadColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'IsRead' in table 'tblNotes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblNotes.IsReadColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Decimal Premium
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tabletblNotes.PremiumColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Premium' in table 'tblNotes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblNotes.PremiumColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string From
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblNotes.FromColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'From' in table 'tblNotes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblNotes.FromColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DateTime NeededByDate
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tabletblNotes.NeededByDateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'NeededByDate' in table 'tblNotes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblNotes.NeededByDateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string ClaimNumber
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblNotes.ClaimNumberColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ClaimNumber' in table 'tblNotes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblNotes.ClaimNumberColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DateTime ExpirationDate
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tabletblNotes.ExpirationDateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ExpirationDate' in table 'tblNotes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblNotes.ExpirationDateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string ProducerLocationName
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblNotes.ProducerLocationNameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ProducerLocationName' in table 'tblNotes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblNotes.ProducerLocationNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string DBA
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblNotes.DBAColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DBA' in table 'tblNotes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblNotes.DBAColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsCompletedNull() => this.IsNull(this.tabletblNotes.CompletedColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetCompletedNull()
    {
      this[this.tabletblNotes.CompletedColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsCreatedDateNull() => this.IsNull(this.tabletblNotes.CreatedDateColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetCreatedDateNull()
    {
      this[this.tabletblNotes.CreatedDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsNoteTypeNull() => this.IsNull(this.tabletblNotes.NoteTypeColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetNoteTypeNull()
    {
      this[this.tabletblNotes.NoteTypeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsEffectiveDateNull() => this.IsNull(this.tabletblNotes.EffectiveDateColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetEffectiveDateNull()
    {
      this[this.tabletblNotes.EffectiveDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsControlNoNull() => this.IsNull(this.tabletblNotes.ControlNoColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetControlNoNull()
    {
      this[this.tabletblNotes.ControlNoColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsSubjectNull() => this.IsNull(this.tabletblNotes.SubjectColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetSubjectNull()
    {
      this[this.tabletblNotes.SubjectColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsProducerContactNull() => this.IsNull(this.tabletblNotes.ProducerContactColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetProducerContactNull()
    {
      this[this.tabletblNotes.ProducerContactColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsLineOfBusinessNull() => this.IsNull(this.tabletblNotes.LineOfBusinessColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetLineOfBusinessNull()
    {
      this[this.tabletblNotes.LineOfBusinessColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsQuoteStatusNull() => this.IsNull(this.tabletblNotes.QuoteStatusColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetQuoteStatusNull()
    {
      this[this.tabletblNotes.QuoteStatusColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsPolicyTypeNull() => this.IsNull(this.tabletblNotes.PolicyTypeColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetPolicyTypeNull()
    {
      this[this.tabletblNotes.PolicyTypeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsStateIDNull() => this.IsNull(this.tabletblNotes.StateIDColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetStateIDNull()
    {
      this[this.tabletblNotes.StateIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsUnderwriterNameNull() => this.IsNull(this.tabletblNotes.UnderwriterNameColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetUnderwriterNameNull()
    {
      this[this.tabletblNotes.UnderwriterNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsIsReadNull() => this.IsNull(this.tabletblNotes.IsReadColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetIsReadNull()
    {
      this[this.tabletblNotes.IsReadColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsPremiumNull() => this.IsNull(this.tabletblNotes.PremiumColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetPremiumNull()
    {
      this[this.tabletblNotes.PremiumColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsFromNull() => this.IsNull(this.tabletblNotes.FromColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetFromNull()
    {
      this[this.tabletblNotes.FromColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsNeededByDateNull() => this.IsNull(this.tabletblNotes.NeededByDateColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetNeededByDateNull()
    {
      this[this.tabletblNotes.NeededByDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsClaimNumberNull() => this.IsNull(this.tabletblNotes.ClaimNumberColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetClaimNumberNull()
    {
      this[this.tabletblNotes.ClaimNumberColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsExpirationDateNull() => this.IsNull(this.tabletblNotes.ExpirationDateColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetExpirationDateNull()
    {
      this[this.tabletblNotes.ExpirationDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsProducerLocationNameNull()
    {
      return this.IsNull(this.tabletblNotes.ProducerLocationNameColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetProducerLocationNameNull()
    {
      this[this.tabletblNotes.ProducerLocationNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsDBANull() => this.IsNull(this.tabletblNotes.DBAColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetDBANull()
    {
      this[this.tabletblNotes.DBAColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class tblUrgentDiariesRowChangeEvent : EventArgs
  {
    private dsToday.tblUrgentDiariesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public tblUrgentDiariesRowChangeEvent(dsToday.tblUrgentDiariesRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsToday.tblUrgentDiariesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class tblNotesRowChangeEvent : EventArgs
  {
    private dsToday.tblNotesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public tblNotesRowChangeEvent(dsToday.tblNotesRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsToday.tblNotesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }
}
