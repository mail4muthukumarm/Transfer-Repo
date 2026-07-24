// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.NoteDocuments.dsGlobalNotePrefillingOptions
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
[XmlRoot("dsGlobalNotePrefillingOptions")]
[HelpKeyword("vs.data.DataSet")]
[Serializable]
public class dsGlobalNotePrefillingOptions : DataSet
{
  private dsGlobalNotePrefillingOptions.lstNoteTypesDataTable tablelstNoteTypes;
  private dsGlobalNotePrefillingOptions.lstNoteAutomationRecipientsDataTable tablelstNoteAutomationRecipients;
  private dsGlobalNotePrefillingOptions.lstDiaryStartTypesDataTable tablelstDiaryStartTypes;
  private SchemaSerializationMode _schemaSerializationMode;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public dsGlobalNotePrefillingOptions()
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
  protected dsGlobalNotePrefillingOptions(SerializationInfo info, StreamingContext context)
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
        if (dataSet.Tables[nameof (lstNoteTypes)] != null)
          base.Tables.Add((DataTable) new dsGlobalNotePrefillingOptions.lstNoteTypesDataTable(dataSet.Tables[nameof (lstNoteTypes)]));
        if (dataSet.Tables[nameof (lstNoteAutomationRecipients)] != null)
          base.Tables.Add((DataTable) new dsGlobalNotePrefillingOptions.lstNoteAutomationRecipientsDataTable(dataSet.Tables[nameof (lstNoteAutomationRecipients)]));
        if (dataSet.Tables[nameof (lstDiaryStartTypes)] != null)
          base.Tables.Add((DataTable) new dsGlobalNotePrefillingOptions.lstDiaryStartTypesDataTable(dataSet.Tables[nameof (lstDiaryStartTypes)]));
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
  public dsGlobalNotePrefillingOptions.lstNoteTypesDataTable lstNoteTypes => this.tablelstNoteTypes;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsGlobalNotePrefillingOptions.lstNoteAutomationRecipientsDataTable lstNoteAutomationRecipients
  {
    get => this.tablelstNoteAutomationRecipients;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsGlobalNotePrefillingOptions.lstDiaryStartTypesDataTable lstDiaryStartTypes
  {
    get => this.tablelstDiaryStartTypes;
  }

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
    dsGlobalNotePrefillingOptions prefillingOptions = (dsGlobalNotePrefillingOptions) base.Clone();
    prefillingOptions.InitVars();
    prefillingOptions.SchemaSerializationMode = this.SchemaSerializationMode;
    return (DataSet) prefillingOptions;
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
      if (dataSet.Tables["lstNoteTypes"] != null)
        base.Tables.Add((DataTable) new dsGlobalNotePrefillingOptions.lstNoteTypesDataTable(dataSet.Tables["lstNoteTypes"]));
      if (dataSet.Tables["lstNoteAutomationRecipients"] != null)
        base.Tables.Add((DataTable) new dsGlobalNotePrefillingOptions.lstNoteAutomationRecipientsDataTable(dataSet.Tables["lstNoteAutomationRecipients"]));
      if (dataSet.Tables["lstDiaryStartTypes"] != null)
        base.Tables.Add((DataTable) new dsGlobalNotePrefillingOptions.lstDiaryStartTypesDataTable(dataSet.Tables["lstDiaryStartTypes"]));
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
    this.tablelstNoteTypes = (dsGlobalNotePrefillingOptions.lstNoteTypesDataTable) base.Tables["lstNoteTypes"];
    if (initTable && this.tablelstNoteTypes != null)
      this.tablelstNoteTypes.InitVars();
    this.tablelstNoteAutomationRecipients = (dsGlobalNotePrefillingOptions.lstNoteAutomationRecipientsDataTable) base.Tables["lstNoteAutomationRecipients"];
    if (initTable && this.tablelstNoteAutomationRecipients != null)
      this.tablelstNoteAutomationRecipients.InitVars();
    this.tablelstDiaryStartTypes = (dsGlobalNotePrefillingOptions.lstDiaryStartTypesDataTable) base.Tables["lstDiaryStartTypes"];
    if (!initTable || this.tablelstDiaryStartTypes == null)
      return;
    this.tablelstDiaryStartTypes.InitVars();
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private void InitClass()
  {
    this.DataSetName = nameof (dsGlobalNotePrefillingOptions);
    this.Prefix = "";
    this.Namespace = "http://tempuri.org/dsGlobalNotePrefillingOptions.xsd";
    this.EnforceConstraints = true;
    this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.tablelstNoteTypes = new dsGlobalNotePrefillingOptions.lstNoteTypesDataTable();
    base.Tables.Add((DataTable) this.tablelstNoteTypes);
    this.tablelstNoteAutomationRecipients = new dsGlobalNotePrefillingOptions.lstNoteAutomationRecipientsDataTable();
    base.Tables.Add((DataTable) this.tablelstNoteAutomationRecipients);
    this.tablelstDiaryStartTypes = new dsGlobalNotePrefillingOptions.lstDiaryStartTypesDataTable();
    base.Tables.Add((DataTable) this.tablelstDiaryStartTypes);
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializelstNoteTypes() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializelstNoteAutomationRecipients() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializelstDiaryStartTypes() => false;

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
    dsGlobalNotePrefillingOptions prefillingOptions = new dsGlobalNotePrefillingOptions();
    XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
    schemaComplexType.Particle = (XmlSchemaParticle) new XmlSchemaSequence()
    {
      Items = {
        (XmlSchemaObject) new XmlSchemaAny()
        {
          Namespace = prefillingOptions.Namespace
        }
      }
    };
    XmlSchema schemaSerializable = prefillingOptions.GetSchemaSerializable();
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
  public delegate void lstNoteTypesRowChangeEventHandler(
    object sender,
    dsGlobalNotePrefillingOptions.lstNoteTypesRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public delegate void lstNoteAutomationRecipientsRowChangeEventHandler(
    object sender,
    dsGlobalNotePrefillingOptions.lstNoteAutomationRecipientsRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public delegate void lstDiaryStartTypesRowChangeEventHandler(
    object sender,
    dsGlobalNotePrefillingOptions.lstDiaryStartTypesRowChangeEvent e);

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class lstNoteTypesDataTable : TypedTableBase<dsGlobalNotePrefillingOptions.lstNoteTypesRow>
  {
    private DataColumn columnNoteTypeID;
    private DataColumn columnDescription;
    private DataColumn columnDefaultNoteSubject;
    private DataColumn columnDefaultNoteBody;
    private DataColumn columnDefaultNoteDueInDays;
    private DataColumn columnDefaultNoteIsPopup;
    private DataColumn columnDefaultNoteDiaryStartId;
    private DataColumn columnDefaultNoteDiaryRecipientId;
    private DataColumn columnRequiredToQuote;
    private DataColumn columnRequiredToBind;
    private DataColumn columnAllowTagData;
    private DataColumn columnTagDataType;
    private DataColumn columnTagDataLabel;
    private DataColumn columnAllowTagDataUpdate;
    private DataColumn columnAutomationCode;
    private DataColumn columnDefaultCopyForwardOnRenewal;
    private DataColumn columnDisabled;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public lstNoteTypesDataTable()
    {
      this.TableName = "lstNoteTypes";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal lstNoteTypesDataTable(DataTable table)
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
    protected lstNoteTypesDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn NoteTypeIDColumn => this.columnNoteTypeID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn DescriptionColumn => this.columnDescription;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn DefaultNoteSubjectColumn => this.columnDefaultNoteSubject;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn DefaultNoteBodyColumn => this.columnDefaultNoteBody;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn DefaultNoteDueInDaysColumn => this.columnDefaultNoteDueInDays;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn DefaultNoteIsPopupColumn => this.columnDefaultNoteIsPopup;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn DefaultNoteDiaryStartIdColumn => this.columnDefaultNoteDiaryStartId;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn DefaultNoteDiaryRecipientIdColumn => this.columnDefaultNoteDiaryRecipientId;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn RequiredToQuoteColumn => this.columnRequiredToQuote;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn RequiredToBindColumn => this.columnRequiredToBind;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn AllowTagDataColumn => this.columnAllowTagData;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn TagDataTypeColumn => this.columnTagDataType;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn TagDataLabelColumn => this.columnTagDataLabel;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn AllowTagDataUpdateColumn => this.columnAllowTagDataUpdate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn AutomationCodeColumn => this.columnAutomationCode;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn DefaultCopyForwardOnRenewalColumn => this.columnDefaultCopyForwardOnRenewal;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn DisabledColumn => this.columnDisabled;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsGlobalNotePrefillingOptions.lstNoteTypesRow this[int index]
    {
      get => (dsGlobalNotePrefillingOptions.lstNoteTypesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsGlobalNotePrefillingOptions.lstNoteTypesRowChangeEventHandler lstNoteTypesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsGlobalNotePrefillingOptions.lstNoteTypesRowChangeEventHandler lstNoteTypesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsGlobalNotePrefillingOptions.lstNoteTypesRowChangeEventHandler lstNoteTypesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsGlobalNotePrefillingOptions.lstNoteTypesRowChangeEventHandler lstNoteTypesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AddlstNoteTypesRow(dsGlobalNotePrefillingOptions.lstNoteTypesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsGlobalNotePrefillingOptions.lstNoteTypesRow AddlstNoteTypesRow(
      string Description,
      string DefaultNoteSubject,
      string DefaultNoteBody,
      int DefaultNoteDueInDays,
      bool DefaultNoteIsPopup,
      int DefaultNoteDiaryStartId,
      int DefaultNoteDiaryRecipientId,
      bool RequiredToQuote,
      bool RequiredToBind,
      bool AllowTagData,
      string TagDataType,
      string TagDataLabel,
      bool AllowTagDataUpdate,
      string AutomationCode,
      bool DefaultCopyForwardOnRenewal,
      bool Disabled)
    {
      dsGlobalNotePrefillingOptions.lstNoteTypesRow row = (dsGlobalNotePrefillingOptions.lstNoteTypesRow) this.NewRow();
      object[] objArray = new object[17]
      {
        null,
        (object) Description,
        (object) DefaultNoteSubject,
        (object) DefaultNoteBody,
        (object) DefaultNoteDueInDays,
        (object) DefaultNoteIsPopup,
        (object) DefaultNoteDiaryStartId,
        (object) DefaultNoteDiaryRecipientId,
        (object) RequiredToQuote,
        (object) RequiredToBind,
        (object) AllowTagData,
        (object) TagDataType,
        (object) TagDataLabel,
        (object) AllowTagDataUpdate,
        (object) AutomationCode,
        (object) DefaultCopyForwardOnRenewal,
        (object) Disabled
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsGlobalNotePrefillingOptions.lstNoteTypesRow FindByNoteTypeID(int NoteTypeID)
    {
      return (dsGlobalNotePrefillingOptions.lstNoteTypesRow) this.Rows.Find(new object[1]
      {
        (object) NoteTypeID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsGlobalNotePrefillingOptions.lstNoteTypesDataTable noteTypesDataTable = (dsGlobalNotePrefillingOptions.lstNoteTypesDataTable) base.Clone();
      noteTypesDataTable.InitVars();
      return (DataTable) noteTypesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsGlobalNotePrefillingOptions.lstNoteTypesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal void InitVars()
    {
      this.columnNoteTypeID = this.Columns["NoteTypeID"];
      this.columnDescription = this.Columns["Description"];
      this.columnDefaultNoteSubject = this.Columns["DefaultNoteSubject"];
      this.columnDefaultNoteBody = this.Columns["DefaultNoteBody"];
      this.columnDefaultNoteDueInDays = this.Columns["DefaultNoteDueInDays"];
      this.columnDefaultNoteIsPopup = this.Columns["DefaultNoteIsPopup"];
      this.columnDefaultNoteDiaryStartId = this.Columns["DefaultNoteDiaryStartId"];
      this.columnDefaultNoteDiaryRecipientId = this.Columns["DefaultNoteDiaryRecipientId"];
      this.columnRequiredToQuote = this.Columns["RequiredToQuote"];
      this.columnRequiredToBind = this.Columns["RequiredToBind"];
      this.columnAllowTagData = this.Columns["AllowTagData"];
      this.columnTagDataType = this.Columns["TagDataType"];
      this.columnTagDataLabel = this.Columns["TagDataLabel"];
      this.columnAllowTagDataUpdate = this.Columns["AllowTagDataUpdate"];
      this.columnAutomationCode = this.Columns["AutomationCode"];
      this.columnDefaultCopyForwardOnRenewal = this.Columns["DefaultCopyForwardOnRenewal"];
      this.columnDisabled = this.Columns["Disabled"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.columnNoteTypeID = new DataColumn("NoteTypeID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnNoteTypeID);
      this.columnDescription = new DataColumn("Description", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDescription);
      this.columnDefaultNoteSubject = new DataColumn("DefaultNoteSubject", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDefaultNoteSubject);
      this.columnDefaultNoteBody = new DataColumn("DefaultNoteBody", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDefaultNoteBody);
      this.columnDefaultNoteDueInDays = new DataColumn("DefaultNoteDueInDays", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDefaultNoteDueInDays);
      this.columnDefaultNoteIsPopup = new DataColumn("DefaultNoteIsPopup", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDefaultNoteIsPopup);
      this.columnDefaultNoteDiaryStartId = new DataColumn("DefaultNoteDiaryStartId", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDefaultNoteDiaryStartId);
      this.columnDefaultNoteDiaryRecipientId = new DataColumn("DefaultNoteDiaryRecipientId", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDefaultNoteDiaryRecipientId);
      this.columnRequiredToQuote = new DataColumn("RequiredToQuote", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnRequiredToQuote);
      this.columnRequiredToBind = new DataColumn("RequiredToBind", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnRequiredToBind);
      this.columnAllowTagData = new DataColumn("AllowTagData", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAllowTagData);
      this.columnTagDataType = new DataColumn("TagDataType", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnTagDataType);
      this.columnTagDataLabel = new DataColumn("TagDataLabel", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnTagDataLabel);
      this.columnAllowTagDataUpdate = new DataColumn("AllowTagDataUpdate", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAllowTagDataUpdate);
      this.columnAutomationCode = new DataColumn("AutomationCode", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAutomationCode);
      this.columnDefaultCopyForwardOnRenewal = new DataColumn("DefaultCopyForwardOnRenewal", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDefaultCopyForwardOnRenewal);
      this.columnDisabled = new DataColumn("Disabled", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDisabled);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnNoteTypeID
      }, true));
      this.columnNoteTypeID.AutoIncrement = true;
      this.columnNoteTypeID.AllowDBNull = false;
      this.columnNoteTypeID.Unique = true;
      this.columnDescription.AllowDBNull = false;
      this.columnDescription.DefaultValue = (object) "";
      this.columnDescription.MaxLength = 50;
      this.columnDefaultNoteSubject.MaxLength = 200;
      this.columnTagDataType.MaxLength = 20;
      this.columnTagDataLabel.MaxLength = 50;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsGlobalNotePrefillingOptions.lstNoteTypesRow NewlstNoteTypesRow()
    {
      return (dsGlobalNotePrefillingOptions.lstNoteTypesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsGlobalNotePrefillingOptions.lstNoteTypesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType() => typeof (dsGlobalNotePrefillingOptions.lstNoteTypesRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstNoteTypesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsGlobalNotePrefillingOptions.lstNoteTypesRowChangeEventHandler typesRowChangedEvent = this.lstNoteTypesRowChangedEvent;
      if (typesRowChangedEvent == null)
        return;
      typesRowChangedEvent((object) this, new dsGlobalNotePrefillingOptions.lstNoteTypesRowChangeEvent((dsGlobalNotePrefillingOptions.lstNoteTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstNoteTypesRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsGlobalNotePrefillingOptions.lstNoteTypesRowChangeEventHandler rowChangingEvent = this.lstNoteTypesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsGlobalNotePrefillingOptions.lstNoteTypesRowChangeEvent((dsGlobalNotePrefillingOptions.lstNoteTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstNoteTypesRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsGlobalNotePrefillingOptions.lstNoteTypesRowChangeEventHandler typesRowDeletedEvent = this.lstNoteTypesRowDeletedEvent;
      if (typesRowDeletedEvent == null)
        return;
      typesRowDeletedEvent((object) this, new dsGlobalNotePrefillingOptions.lstNoteTypesRowChangeEvent((dsGlobalNotePrefillingOptions.lstNoteTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstNoteTypesRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsGlobalNotePrefillingOptions.lstNoteTypesRowChangeEventHandler rowDeletingEvent = this.lstNoteTypesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsGlobalNotePrefillingOptions.lstNoteTypesRowChangeEvent((dsGlobalNotePrefillingOptions.lstNoteTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemovelstNoteTypesRow(dsGlobalNotePrefillingOptions.lstNoteTypesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsGlobalNotePrefillingOptions prefillingOptions = new dsGlobalNotePrefillingOptions();
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
        FixedValue = prefillingOptions.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (lstNoteTypesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = prefillingOptions.GetSchemaSerializable();
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
  public class lstNoteAutomationRecipientsDataTable : 
    TypedTableBase<dsGlobalNotePrefillingOptions.lstNoteAutomationRecipientsRow>
  {
    private DataColumn columnNoteAutomationRecipientID;
    private DataColumn columnRecipientName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public lstNoteAutomationRecipientsDataTable()
    {
      this.TableName = "lstNoteAutomationRecipients";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal lstNoteAutomationRecipientsDataTable(DataTable table)
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
    protected lstNoteAutomationRecipientsDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn NoteAutomationRecipientIDColumn => this.columnNoteAutomationRecipientID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn RecipientNameColumn => this.columnRecipientName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsGlobalNotePrefillingOptions.lstNoteAutomationRecipientsRow this[int index]
    {
      get => (dsGlobalNotePrefillingOptions.lstNoteAutomationRecipientsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsGlobalNotePrefillingOptions.lstNoteAutomationRecipientsRowChangeEventHandler lstNoteAutomationRecipientsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsGlobalNotePrefillingOptions.lstNoteAutomationRecipientsRowChangeEventHandler lstNoteAutomationRecipientsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsGlobalNotePrefillingOptions.lstNoteAutomationRecipientsRowChangeEventHandler lstNoteAutomationRecipientsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsGlobalNotePrefillingOptions.lstNoteAutomationRecipientsRowChangeEventHandler lstNoteAutomationRecipientsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AddlstNoteAutomationRecipientsRow(
      dsGlobalNotePrefillingOptions.lstNoteAutomationRecipientsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsGlobalNotePrefillingOptions.lstNoteAutomationRecipientsRow AddlstNoteAutomationRecipientsRow(
      int NoteAutomationRecipientID,
      string RecipientName)
    {
      dsGlobalNotePrefillingOptions.lstNoteAutomationRecipientsRow row = (dsGlobalNotePrefillingOptions.lstNoteAutomationRecipientsRow) this.NewRow();
      object[] objArray = new object[2]
      {
        (object) NoteAutomationRecipientID,
        (object) RecipientName
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsGlobalNotePrefillingOptions.lstNoteAutomationRecipientsRow FindByNoteAutomationRecipientID(
      int NoteAutomationRecipientID)
    {
      return (dsGlobalNotePrefillingOptions.lstNoteAutomationRecipientsRow) this.Rows.Find(new object[1]
      {
        (object) NoteAutomationRecipientID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsGlobalNotePrefillingOptions.lstNoteAutomationRecipientsDataTable recipientsDataTable = (dsGlobalNotePrefillingOptions.lstNoteAutomationRecipientsDataTable) base.Clone();
      recipientsDataTable.InitVars();
      return (DataTable) recipientsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsGlobalNotePrefillingOptions.lstNoteAutomationRecipientsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal void InitVars()
    {
      this.columnNoteAutomationRecipientID = this.Columns["NoteAutomationRecipientID"];
      this.columnRecipientName = this.Columns["RecipientName"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.columnNoteAutomationRecipientID = new DataColumn("NoteAutomationRecipientID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnNoteAutomationRecipientID);
      this.columnRecipientName = new DataColumn("RecipientName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnRecipientName);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnNoteAutomationRecipientID
      }, true));
      this.columnNoteAutomationRecipientID.AllowDBNull = false;
      this.columnNoteAutomationRecipientID.Unique = true;
      this.columnRecipientName.MaxLength = 200;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsGlobalNotePrefillingOptions.lstNoteAutomationRecipientsRow NewlstNoteAutomationRecipientsRow()
    {
      return (dsGlobalNotePrefillingOptions.lstNoteAutomationRecipientsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsGlobalNotePrefillingOptions.lstNoteAutomationRecipientsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType()
    {
      return typeof (dsGlobalNotePrefillingOptions.lstNoteAutomationRecipientsRow);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstNoteAutomationRecipientsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsGlobalNotePrefillingOptions.lstNoteAutomationRecipientsRowChangeEventHandler recipientsRowChangedEvent = this.lstNoteAutomationRecipientsRowChangedEvent;
      if (recipientsRowChangedEvent == null)
        return;
      recipientsRowChangedEvent((object) this, new dsGlobalNotePrefillingOptions.lstNoteAutomationRecipientsRowChangeEvent((dsGlobalNotePrefillingOptions.lstNoteAutomationRecipientsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstNoteAutomationRecipientsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsGlobalNotePrefillingOptions.lstNoteAutomationRecipientsRowChangeEventHandler rowChangingEvent = this.lstNoteAutomationRecipientsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsGlobalNotePrefillingOptions.lstNoteAutomationRecipientsRowChangeEvent((dsGlobalNotePrefillingOptions.lstNoteAutomationRecipientsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstNoteAutomationRecipientsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsGlobalNotePrefillingOptions.lstNoteAutomationRecipientsRowChangeEventHandler recipientsRowDeletedEvent = this.lstNoteAutomationRecipientsRowDeletedEvent;
      if (recipientsRowDeletedEvent == null)
        return;
      recipientsRowDeletedEvent((object) this, new dsGlobalNotePrefillingOptions.lstNoteAutomationRecipientsRowChangeEvent((dsGlobalNotePrefillingOptions.lstNoteAutomationRecipientsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstNoteAutomationRecipientsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsGlobalNotePrefillingOptions.lstNoteAutomationRecipientsRowChangeEventHandler rowDeletingEvent = this.lstNoteAutomationRecipientsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsGlobalNotePrefillingOptions.lstNoteAutomationRecipientsRowChangeEvent((dsGlobalNotePrefillingOptions.lstNoteAutomationRecipientsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemovelstNoteAutomationRecipientsRow(
      dsGlobalNotePrefillingOptions.lstNoteAutomationRecipientsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsGlobalNotePrefillingOptions prefillingOptions = new dsGlobalNotePrefillingOptions();
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
        FixedValue = prefillingOptions.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (lstNoteAutomationRecipientsDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = prefillingOptions.GetSchemaSerializable();
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
  public class lstDiaryStartTypesDataTable : 
    TypedTableBase<dsGlobalNotePrefillingOptions.lstDiaryStartTypesRow>
  {
    private DataColumn columnDiaryStartTypeID;
    private DataColumn columnDescription;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public lstDiaryStartTypesDataTable()
    {
      this.TableName = "lstDiaryStartTypes";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal lstDiaryStartTypesDataTable(DataTable table)
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
    protected lstDiaryStartTypesDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn DiaryStartTypeIDColumn => this.columnDiaryStartTypeID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn DescriptionColumn => this.columnDescription;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsGlobalNotePrefillingOptions.lstDiaryStartTypesRow this[int index]
    {
      get => (dsGlobalNotePrefillingOptions.lstDiaryStartTypesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsGlobalNotePrefillingOptions.lstDiaryStartTypesRowChangeEventHandler lstDiaryStartTypesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsGlobalNotePrefillingOptions.lstDiaryStartTypesRowChangeEventHandler lstDiaryStartTypesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsGlobalNotePrefillingOptions.lstDiaryStartTypesRowChangeEventHandler lstDiaryStartTypesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsGlobalNotePrefillingOptions.lstDiaryStartTypesRowChangeEventHandler lstDiaryStartTypesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AddlstDiaryStartTypesRow(
      dsGlobalNotePrefillingOptions.lstDiaryStartTypesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsGlobalNotePrefillingOptions.lstDiaryStartTypesRow AddlstDiaryStartTypesRow(
      int DiaryStartTypeID,
      string Description)
    {
      dsGlobalNotePrefillingOptions.lstDiaryStartTypesRow row = (dsGlobalNotePrefillingOptions.lstDiaryStartTypesRow) this.NewRow();
      object[] objArray = new object[2]
      {
        (object) DiaryStartTypeID,
        (object) Description
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsGlobalNotePrefillingOptions.lstDiaryStartTypesRow FindByDiaryStartTypeID(
      int DiaryStartTypeID)
    {
      return (dsGlobalNotePrefillingOptions.lstDiaryStartTypesRow) this.Rows.Find(new object[1]
      {
        (object) DiaryStartTypeID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsGlobalNotePrefillingOptions.lstDiaryStartTypesDataTable startTypesDataTable = (dsGlobalNotePrefillingOptions.lstDiaryStartTypesDataTable) base.Clone();
      startTypesDataTable.InitVars();
      return (DataTable) startTypesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsGlobalNotePrefillingOptions.lstDiaryStartTypesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal void InitVars()
    {
      this.columnDiaryStartTypeID = this.Columns["DiaryStartTypeID"];
      this.columnDescription = this.Columns["Description"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.columnDiaryStartTypeID = new DataColumn("DiaryStartTypeID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDiaryStartTypeID);
      this.columnDescription = new DataColumn("Description", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDescription);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnDiaryStartTypeID
      }, true));
      this.columnDiaryStartTypeID.AllowDBNull = false;
      this.columnDiaryStartTypeID.Unique = true;
      this.columnDescription.AllowDBNull = false;
      this.columnDescription.MaxLength = 50;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsGlobalNotePrefillingOptions.lstDiaryStartTypesRow NewlstDiaryStartTypesRow()
    {
      return (dsGlobalNotePrefillingOptions.lstDiaryStartTypesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsGlobalNotePrefillingOptions.lstDiaryStartTypesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType()
    {
      return typeof (dsGlobalNotePrefillingOptions.lstDiaryStartTypesRow);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstDiaryStartTypesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsGlobalNotePrefillingOptions.lstDiaryStartTypesRowChangeEventHandler typesRowChangedEvent = this.lstDiaryStartTypesRowChangedEvent;
      if (typesRowChangedEvent == null)
        return;
      typesRowChangedEvent((object) this, new dsGlobalNotePrefillingOptions.lstDiaryStartTypesRowChangeEvent((dsGlobalNotePrefillingOptions.lstDiaryStartTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstDiaryStartTypesRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsGlobalNotePrefillingOptions.lstDiaryStartTypesRowChangeEventHandler rowChangingEvent = this.lstDiaryStartTypesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsGlobalNotePrefillingOptions.lstDiaryStartTypesRowChangeEvent((dsGlobalNotePrefillingOptions.lstDiaryStartTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstDiaryStartTypesRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsGlobalNotePrefillingOptions.lstDiaryStartTypesRowChangeEventHandler typesRowDeletedEvent = this.lstDiaryStartTypesRowDeletedEvent;
      if (typesRowDeletedEvent == null)
        return;
      typesRowDeletedEvent((object) this, new dsGlobalNotePrefillingOptions.lstDiaryStartTypesRowChangeEvent((dsGlobalNotePrefillingOptions.lstDiaryStartTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstDiaryStartTypesRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsGlobalNotePrefillingOptions.lstDiaryStartTypesRowChangeEventHandler rowDeletingEvent = this.lstDiaryStartTypesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsGlobalNotePrefillingOptions.lstDiaryStartTypesRowChangeEvent((dsGlobalNotePrefillingOptions.lstDiaryStartTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemovelstDiaryStartTypesRow(
      dsGlobalNotePrefillingOptions.lstDiaryStartTypesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsGlobalNotePrefillingOptions prefillingOptions = new dsGlobalNotePrefillingOptions();
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
        FixedValue = prefillingOptions.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (lstDiaryStartTypesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = prefillingOptions.GetSchemaSerializable();
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

  public class lstNoteTypesRow : DataRow
  {
    private dsGlobalNotePrefillingOptions.lstNoteTypesDataTable tablelstNoteTypes;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal lstNoteTypesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablelstNoteTypes = (dsGlobalNotePrefillingOptions.lstNoteTypesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int NoteTypeID
    {
      get => Conversions.ToInteger(this[this.tablelstNoteTypes.NoteTypeIDColumn]);
      set => this[this.tablelstNoteTypes.NoteTypeIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string Description
    {
      get => Conversions.ToString(this[this.tablelstNoteTypes.DescriptionColumn]);
      set => this[this.tablelstNoteTypes.DescriptionColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string DefaultNoteSubject
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablelstNoteTypes.DefaultNoteSubjectColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DefaultNoteSubject' in table 'lstNoteTypes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablelstNoteTypes.DefaultNoteSubjectColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string DefaultNoteBody
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablelstNoteTypes.DefaultNoteBodyColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DefaultNoteBody' in table 'lstNoteTypes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablelstNoteTypes.DefaultNoteBodyColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int DefaultNoteDueInDays
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tablelstNoteTypes.DefaultNoteDueInDaysColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DefaultNoteDueInDays' in table 'lstNoteTypes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablelstNoteTypes.DefaultNoteDueInDaysColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool DefaultNoteIsPopup
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tablelstNoteTypes.DefaultNoteIsPopupColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DefaultNoteIsPopup' in table 'lstNoteTypes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablelstNoteTypes.DefaultNoteIsPopupColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int DefaultNoteDiaryStartId
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tablelstNoteTypes.DefaultNoteDiaryStartIdColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DefaultNoteDiaryStartId' in table 'lstNoteTypes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablelstNoteTypes.DefaultNoteDiaryStartIdColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int DefaultNoteDiaryRecipientId
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tablelstNoteTypes.DefaultNoteDiaryRecipientIdColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DefaultNoteDiaryRecipientId' in table 'lstNoteTypes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablelstNoteTypes.DefaultNoteDiaryRecipientIdColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool RequiredToQuote
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tablelstNoteTypes.RequiredToQuoteColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'RequiredToQuote' in table 'lstNoteTypes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablelstNoteTypes.RequiredToQuoteColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool RequiredToBind
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tablelstNoteTypes.RequiredToBindColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'RequiredToBind' in table 'lstNoteTypes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablelstNoteTypes.RequiredToBindColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool AllowTagData
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tablelstNoteTypes.AllowTagDataColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'AllowTagData' in table 'lstNoteTypes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablelstNoteTypes.AllowTagDataColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string TagDataType
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablelstNoteTypes.TagDataTypeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'TagDataType' in table 'lstNoteTypes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablelstNoteTypes.TagDataTypeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string TagDataLabel
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablelstNoteTypes.TagDataLabelColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'TagDataLabel' in table 'lstNoteTypes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablelstNoteTypes.TagDataLabelColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool AllowTagDataUpdate
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tablelstNoteTypes.AllowTagDataUpdateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'AllowTagDataUpdate' in table 'lstNoteTypes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablelstNoteTypes.AllowTagDataUpdateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string AutomationCode
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablelstNoteTypes.AutomationCodeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'AutomationCode' in table 'lstNoteTypes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablelstNoteTypes.AutomationCodeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool DefaultCopyForwardOnRenewal
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tablelstNoteTypes.DefaultCopyForwardOnRenewalColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DefaultCopyForwardOnRenewal' in table 'lstNoteTypes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablelstNoteTypes.DefaultCopyForwardOnRenewalColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool Disabled
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tablelstNoteTypes.DisabledColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Disabled' in table 'lstNoteTypes' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablelstNoteTypes.DisabledColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsDefaultNoteSubjectNull()
    {
      return this.IsNull(this.tablelstNoteTypes.DefaultNoteSubjectColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetDefaultNoteSubjectNull()
    {
      this[this.tablelstNoteTypes.DefaultNoteSubjectColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsDefaultNoteBodyNull()
    {
      return this.IsNull(this.tablelstNoteTypes.DefaultNoteBodyColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetDefaultNoteBodyNull()
    {
      this[this.tablelstNoteTypes.DefaultNoteBodyColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsDefaultNoteDueInDaysNull()
    {
      return this.IsNull(this.tablelstNoteTypes.DefaultNoteDueInDaysColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetDefaultNoteDueInDaysNull()
    {
      this[this.tablelstNoteTypes.DefaultNoteDueInDaysColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsDefaultNoteIsPopupNull()
    {
      return this.IsNull(this.tablelstNoteTypes.DefaultNoteIsPopupColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetDefaultNoteIsPopupNull()
    {
      this[this.tablelstNoteTypes.DefaultNoteIsPopupColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsDefaultNoteDiaryStartIdNull()
    {
      return this.IsNull(this.tablelstNoteTypes.DefaultNoteDiaryStartIdColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetDefaultNoteDiaryStartIdNull()
    {
      this[this.tablelstNoteTypes.DefaultNoteDiaryStartIdColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsDefaultNoteDiaryRecipientIdNull()
    {
      return this.IsNull(this.tablelstNoteTypes.DefaultNoteDiaryRecipientIdColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetDefaultNoteDiaryRecipientIdNull()
    {
      this[this.tablelstNoteTypes.DefaultNoteDiaryRecipientIdColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsRequiredToQuoteNull()
    {
      return this.IsNull(this.tablelstNoteTypes.RequiredToQuoteColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetRequiredToQuoteNull()
    {
      this[this.tablelstNoteTypes.RequiredToQuoteColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsRequiredToBindNull() => this.IsNull(this.tablelstNoteTypes.RequiredToBindColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetRequiredToBindNull()
    {
      this[this.tablelstNoteTypes.RequiredToBindColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsAllowTagDataNull() => this.IsNull(this.tablelstNoteTypes.AllowTagDataColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetAllowTagDataNull()
    {
      this[this.tablelstNoteTypes.AllowTagDataColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsTagDataTypeNull() => this.IsNull(this.tablelstNoteTypes.TagDataTypeColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetTagDataTypeNull()
    {
      this[this.tablelstNoteTypes.TagDataTypeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsTagDataLabelNull() => this.IsNull(this.tablelstNoteTypes.TagDataLabelColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetTagDataLabelNull()
    {
      this[this.tablelstNoteTypes.TagDataLabelColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsAllowTagDataUpdateNull()
    {
      return this.IsNull(this.tablelstNoteTypes.AllowTagDataUpdateColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetAllowTagDataUpdateNull()
    {
      this[this.tablelstNoteTypes.AllowTagDataUpdateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsAutomationCodeNull() => this.IsNull(this.tablelstNoteTypes.AutomationCodeColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetAutomationCodeNull()
    {
      this[this.tablelstNoteTypes.AutomationCodeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsDefaultCopyForwardOnRenewalNull()
    {
      return this.IsNull(this.tablelstNoteTypes.DefaultCopyForwardOnRenewalColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetDefaultCopyForwardOnRenewalNull()
    {
      this[this.tablelstNoteTypes.DefaultCopyForwardOnRenewalColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsDisabledNull() => this.IsNull(this.tablelstNoteTypes.DisabledColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetDisabledNull()
    {
      this[this.tablelstNoteTypes.DisabledColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class lstNoteAutomationRecipientsRow : DataRow
  {
    private dsGlobalNotePrefillingOptions.lstNoteAutomationRecipientsDataTable tablelstNoteAutomationRecipients;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal lstNoteAutomationRecipientsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablelstNoteAutomationRecipients = (dsGlobalNotePrefillingOptions.lstNoteAutomationRecipientsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int NoteAutomationRecipientID
    {
      get
      {
        return Conversions.ToInteger(this[this.tablelstNoteAutomationRecipients.NoteAutomationRecipientIDColumn]);
      }
      set
      {
        this[this.tablelstNoteAutomationRecipients.NoteAutomationRecipientIDColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string RecipientName
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablelstNoteAutomationRecipients.RecipientNameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'RecipientName' in table 'lstNoteAutomationRecipients' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablelstNoteAutomationRecipients.RecipientNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsRecipientNameNull()
    {
      return this.IsNull(this.tablelstNoteAutomationRecipients.RecipientNameColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetRecipientNameNull()
    {
      this[this.tablelstNoteAutomationRecipients.RecipientNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class lstDiaryStartTypesRow : DataRow
  {
    private dsGlobalNotePrefillingOptions.lstDiaryStartTypesDataTable tablelstDiaryStartTypes;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal lstDiaryStartTypesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablelstDiaryStartTypes = (dsGlobalNotePrefillingOptions.lstDiaryStartTypesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int DiaryStartTypeID
    {
      get => Conversions.ToInteger(this[this.tablelstDiaryStartTypes.DiaryStartTypeIDColumn]);
      set => this[this.tablelstDiaryStartTypes.DiaryStartTypeIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string Description
    {
      get => Conversions.ToString(this[this.tablelstDiaryStartTypes.DescriptionColumn]);
      set => this[this.tablelstDiaryStartTypes.DescriptionColumn] = (object) value;
    }
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class lstNoteTypesRowChangeEvent : EventArgs
  {
    private dsGlobalNotePrefillingOptions.lstNoteTypesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public lstNoteTypesRowChangeEvent(
      dsGlobalNotePrefillingOptions.lstNoteTypesRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsGlobalNotePrefillingOptions.lstNoteTypesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class lstNoteAutomationRecipientsRowChangeEvent : EventArgs
  {
    private dsGlobalNotePrefillingOptions.lstNoteAutomationRecipientsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public lstNoteAutomationRecipientsRowChangeEvent(
      dsGlobalNotePrefillingOptions.lstNoteAutomationRecipientsRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsGlobalNotePrefillingOptions.lstNoteAutomationRecipientsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class lstDiaryStartTypesRowChangeEvent : EventArgs
  {
    private dsGlobalNotePrefillingOptions.lstDiaryStartTypesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public lstDiaryStartTypesRowChangeEvent(
      dsGlobalNotePrefillingOptions.lstDiaryStartTypesRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsGlobalNotePrefillingOptions.lstDiaryStartTypesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }
}
