// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.NoteDocuments.dsTabNotePanel
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
[XmlRoot("dsTabNotePanel")]
[HelpKeyword("vs.data.DataSet")]
[Serializable]
public class dsTabNotePanel : DataSet
{
  private dsTabNotePanel.tblDiaryEntriesUpcomingDataTable tabletblDiaryEntriesUpcoming;
  private dsTabNotePanel.tblEntriesUnreadDataTable tabletblEntriesUnread;
  private dsTabNotePanel.tblNotesBoundDataTable tabletblNotesBound;
  private dsTabNotePanel.tblNotesUnboundDataTable tabletblNotesUnbound;
  private dsTabNotePanel.tblDiaryEntriesOpenDataTable tabletblDiaryEntriesOpen;
  private dsTabNotePanel.tblDiaryEntriesUrgentDataTable tabletblDiaryEntriesUrgent;
  private SchemaSerializationMode _schemaSerializationMode;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public dsTabNotePanel()
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
  protected dsTabNotePanel(SerializationInfo info, StreamingContext context)
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
        if (dataSet.Tables[nameof (tblDiaryEntriesUpcoming)] != null)
          base.Tables.Add((DataTable) new dsTabNotePanel.tblDiaryEntriesUpcomingDataTable(dataSet.Tables[nameof (tblDiaryEntriesUpcoming)]));
        if (dataSet.Tables[nameof (tblEntriesUnread)] != null)
          base.Tables.Add((DataTable) new dsTabNotePanel.tblEntriesUnreadDataTable(dataSet.Tables[nameof (tblEntriesUnread)]));
        if (dataSet.Tables[nameof (tblNotesBound)] != null)
          base.Tables.Add((DataTable) new dsTabNotePanel.tblNotesBoundDataTable(dataSet.Tables[nameof (tblNotesBound)]));
        if (dataSet.Tables[nameof (tblNotesUnbound)] != null)
          base.Tables.Add((DataTable) new dsTabNotePanel.tblNotesUnboundDataTable(dataSet.Tables[nameof (tblNotesUnbound)]));
        if (dataSet.Tables[nameof (tblDiaryEntriesOpen)] != null)
          base.Tables.Add((DataTable) new dsTabNotePanel.tblDiaryEntriesOpenDataTable(dataSet.Tables[nameof (tblDiaryEntriesOpen)]));
        if (dataSet.Tables[nameof (tblDiaryEntriesUrgent)] != null)
          base.Tables.Add((DataTable) new dsTabNotePanel.tblDiaryEntriesUrgentDataTable(dataSet.Tables[nameof (tblDiaryEntriesUrgent)]));
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
  public dsTabNotePanel.tblDiaryEntriesUpcomingDataTable tblDiaryEntriesUpcoming
  {
    get => this.tabletblDiaryEntriesUpcoming;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsTabNotePanel.tblEntriesUnreadDataTable tblEntriesUnread => this.tabletblEntriesUnread;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsTabNotePanel.tblNotesBoundDataTable tblNotesBound => this.tabletblNotesBound;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsTabNotePanel.tblNotesUnboundDataTable tblNotesUnbound => this.tabletblNotesUnbound;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsTabNotePanel.tblDiaryEntriesOpenDataTable tblDiaryEntriesOpen
  {
    get => this.tabletblDiaryEntriesOpen;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsTabNotePanel.tblDiaryEntriesUrgentDataTable tblDiaryEntriesUrgent
  {
    get => this.tabletblDiaryEntriesUrgent;
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
    dsTabNotePanel dsTabNotePanel = (dsTabNotePanel) base.Clone();
    dsTabNotePanel.InitVars();
    dsTabNotePanel.SchemaSerializationMode = this.SchemaSerializationMode;
    return (DataSet) dsTabNotePanel;
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
      if (dataSet.Tables["tblDiaryEntriesUpcoming"] != null)
        base.Tables.Add((DataTable) new dsTabNotePanel.tblDiaryEntriesUpcomingDataTable(dataSet.Tables["tblDiaryEntriesUpcoming"]));
      if (dataSet.Tables["tblEntriesUnread"] != null)
        base.Tables.Add((DataTable) new dsTabNotePanel.tblEntriesUnreadDataTable(dataSet.Tables["tblEntriesUnread"]));
      if (dataSet.Tables["tblNotesBound"] != null)
        base.Tables.Add((DataTable) new dsTabNotePanel.tblNotesBoundDataTable(dataSet.Tables["tblNotesBound"]));
      if (dataSet.Tables["tblNotesUnbound"] != null)
        base.Tables.Add((DataTable) new dsTabNotePanel.tblNotesUnboundDataTable(dataSet.Tables["tblNotesUnbound"]));
      if (dataSet.Tables["tblDiaryEntriesOpen"] != null)
        base.Tables.Add((DataTable) new dsTabNotePanel.tblDiaryEntriesOpenDataTable(dataSet.Tables["tblDiaryEntriesOpen"]));
      if (dataSet.Tables["tblDiaryEntriesUrgent"] != null)
        base.Tables.Add((DataTable) new dsTabNotePanel.tblDiaryEntriesUrgentDataTable(dataSet.Tables["tblDiaryEntriesUrgent"]));
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
    this.tabletblDiaryEntriesUpcoming = (dsTabNotePanel.tblDiaryEntriesUpcomingDataTable) base.Tables["tblDiaryEntriesUpcoming"];
    if (initTable && this.tabletblDiaryEntriesUpcoming != null)
      this.tabletblDiaryEntriesUpcoming.InitVars();
    this.tabletblEntriesUnread = (dsTabNotePanel.tblEntriesUnreadDataTable) base.Tables["tblEntriesUnread"];
    if (initTable && this.tabletblEntriesUnread != null)
      this.tabletblEntriesUnread.InitVars();
    this.tabletblNotesBound = (dsTabNotePanel.tblNotesBoundDataTable) base.Tables["tblNotesBound"];
    if (initTable && this.tabletblNotesBound != null)
      this.tabletblNotesBound.InitVars();
    this.tabletblNotesUnbound = (dsTabNotePanel.tblNotesUnboundDataTable) base.Tables["tblNotesUnbound"];
    if (initTable && this.tabletblNotesUnbound != null)
      this.tabletblNotesUnbound.InitVars();
    this.tabletblDiaryEntriesOpen = (dsTabNotePanel.tblDiaryEntriesOpenDataTable) base.Tables["tblDiaryEntriesOpen"];
    if (initTable && this.tabletblDiaryEntriesOpen != null)
      this.tabletblDiaryEntriesOpen.InitVars();
    this.tabletblDiaryEntriesUrgent = (dsTabNotePanel.tblDiaryEntriesUrgentDataTable) base.Tables["tblDiaryEntriesUrgent"];
    if (!initTable || this.tabletblDiaryEntriesUrgent == null)
      return;
    this.tabletblDiaryEntriesUrgent.InitVars();
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private void InitClass()
  {
    this.DataSetName = nameof (dsTabNotePanel);
    this.Prefix = "";
    this.Namespace = "http://www.tempuri.org/dsTabNotePanel.xsd";
    this.EnforceConstraints = true;
    this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.tabletblDiaryEntriesUpcoming = new dsTabNotePanel.tblDiaryEntriesUpcomingDataTable();
    base.Tables.Add((DataTable) this.tabletblDiaryEntriesUpcoming);
    this.tabletblEntriesUnread = new dsTabNotePanel.tblEntriesUnreadDataTable();
    base.Tables.Add((DataTable) this.tabletblEntriesUnread);
    this.tabletblNotesBound = new dsTabNotePanel.tblNotesBoundDataTable();
    base.Tables.Add((DataTable) this.tabletblNotesBound);
    this.tabletblNotesUnbound = new dsTabNotePanel.tblNotesUnboundDataTable();
    base.Tables.Add((DataTable) this.tabletblNotesUnbound);
    this.tabletblDiaryEntriesOpen = new dsTabNotePanel.tblDiaryEntriesOpenDataTable();
    base.Tables.Add((DataTable) this.tabletblDiaryEntriesOpen);
    this.tabletblDiaryEntriesUrgent = new dsTabNotePanel.tblDiaryEntriesUrgentDataTable();
    base.Tables.Add((DataTable) this.tabletblDiaryEntriesUrgent);
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializetblDiaryEntriesUpcoming() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializetblEntriesUnread() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializetblNotesBound() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializetblNotesUnbound() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializetblDiaryEntriesOpen() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializetblDiaryEntriesUrgent() => false;

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
    dsTabNotePanel dsTabNotePanel = new dsTabNotePanel();
    XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
    schemaComplexType.Particle = (XmlSchemaParticle) new XmlSchemaSequence()
    {
      Items = {
        (XmlSchemaObject) new XmlSchemaAny()
        {
          Namespace = dsTabNotePanel.Namespace
        }
      }
    };
    XmlSchema schemaSerializable = dsTabNotePanel.GetSchemaSerializable();
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
  public delegate void tblDiaryEntriesUpcomingRowChangeEventHandler(
    object sender,
    dsTabNotePanel.tblDiaryEntriesUpcomingRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void tblEntriesUnreadRowChangeEventHandler(
    object sender,
    dsTabNotePanel.tblEntriesUnreadRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void tblNotesBoundRowChangeEventHandler(
    object sender,
    dsTabNotePanel.tblNotesBoundRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void tblNotesUnboundRowChangeEventHandler(
    object sender,
    dsTabNotePanel.tblNotesUnboundRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void tblDiaryEntriesOpenRowChangeEventHandler(
    object sender,
    dsTabNotePanel.tblDiaryEntriesOpenRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void tblDiaryEntriesUrgentRowChangeEventHandler(
    object sender,
    dsTabNotePanel.tblDiaryEntriesUrgentRowChangeEvent e);

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class tblDiaryEntriesUpcomingDataTable : 
    TypedTableBase<dsTabNotePanel.tblDiaryEntriesUpcomingRow>
  {
    private DataColumn columnEntryGUID;
    private DataColumn columnNoteGUID;
    private DataColumn columnIsDiary;
    private DataColumn columnCreatedDate;
    private DataColumn columnDueDate;
    private DataColumn columnBody;
    private DataColumn columnType;
    private DataColumn columnSubject;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblDiaryEntriesUpcomingDataTable()
    {
      this.TableName = "tblDiaryEntriesUpcoming";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblDiaryEntriesUpcomingDataTable(DataTable table)
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
    protected tblDiaryEntriesUpcomingDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn EntryGUIDColumn => this.columnEntryGUID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn NoteGUIDColumn => this.columnNoteGUID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn IsDiaryColumn => this.columnIsDiary;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn CreatedDateColumn => this.columnCreatedDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn DueDateColumn => this.columnDueDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn BodyColumn => this.columnBody;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn TypeColumn => this.columnType;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn SubjectColumn => this.columnSubject;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsTabNotePanel.tblDiaryEntriesUpcomingRow this[int index]
    {
      get => (dsTabNotePanel.tblDiaryEntriesUpcomingRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsTabNotePanel.tblDiaryEntriesUpcomingRowChangeEventHandler tblDiaryEntriesUpcomingRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsTabNotePanel.tblDiaryEntriesUpcomingRowChangeEventHandler tblDiaryEntriesUpcomingRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsTabNotePanel.tblDiaryEntriesUpcomingRowChangeEventHandler tblDiaryEntriesUpcomingRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsTabNotePanel.tblDiaryEntriesUpcomingRowChangeEventHandler tblDiaryEntriesUpcomingRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddtblDiaryEntriesUpcomingRow(dsTabNotePanel.tblDiaryEntriesUpcomingRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsTabNotePanel.tblDiaryEntriesUpcomingRow AddtblDiaryEntriesUpcomingRow(
      Guid EntryGUID,
      Guid NoteGUID,
      bool IsDiary,
      DateTime CreatedDate,
      DateTime DueDate,
      string Body,
      int Type,
      string Subject)
    {
      dsTabNotePanel.tblDiaryEntriesUpcomingRow row = (dsTabNotePanel.tblDiaryEntriesUpcomingRow) this.NewRow();
      object[] objArray = new object[8]
      {
        (object) EntryGUID,
        (object) NoteGUID,
        (object) IsDiary,
        (object) CreatedDate,
        (object) DueDate,
        (object) Body,
        (object) Type,
        (object) Subject
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsTabNotePanel.tblDiaryEntriesUpcomingDataTable upcomingDataTable = (dsTabNotePanel.tblDiaryEntriesUpcomingDataTable) base.Clone();
      upcomingDataTable.InitVars();
      return (DataTable) upcomingDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsTabNotePanel.tblDiaryEntriesUpcomingDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnEntryGUID = this.Columns["EntryGUID"];
      this.columnNoteGUID = this.Columns["NoteGUID"];
      this.columnIsDiary = this.Columns["IsDiary"];
      this.columnCreatedDate = this.Columns["CreatedDate"];
      this.columnDueDate = this.Columns["DueDate"];
      this.columnBody = this.Columns["Body"];
      this.columnType = this.Columns["Type"];
      this.columnSubject = this.Columns["Subject"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnEntryGUID = new DataColumn("EntryGUID", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEntryGUID);
      this.columnNoteGUID = new DataColumn("NoteGUID", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnNoteGUID);
      this.columnIsDiary = new DataColumn("IsDiary", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnIsDiary);
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
      this.columnEntryGUID.AllowDBNull = false;
      this.columnNoteGUID.AllowDBNull = false;
      this.columnIsDiary.AllowDBNull = false;
      this.columnCreatedDate.AllowDBNull = false;
      this.columnDueDate.AllowDBNull = false;
      this.columnBody.ReadOnly = true;
      this.columnType.AllowDBNull = false;
      this.columnSubject.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsTabNotePanel.tblDiaryEntriesUpcomingRow NewtblDiaryEntriesUpcomingRow()
    {
      return (dsTabNotePanel.tblDiaryEntriesUpcomingRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsTabNotePanel.tblDiaryEntriesUpcomingRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (dsTabNotePanel.tblDiaryEntriesUpcomingRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblDiaryEntriesUpcomingRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsTabNotePanel.tblDiaryEntriesUpcomingRowChangeEventHandler upcomingRowChangedEvent = this.tblDiaryEntriesUpcomingRowChangedEvent;
      if (upcomingRowChangedEvent == null)
        return;
      upcomingRowChangedEvent((object) this, new dsTabNotePanel.tblDiaryEntriesUpcomingRowChangeEvent((dsTabNotePanel.tblDiaryEntriesUpcomingRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblDiaryEntriesUpcomingRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsTabNotePanel.tblDiaryEntriesUpcomingRowChangeEventHandler rowChangingEvent = this.tblDiaryEntriesUpcomingRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsTabNotePanel.tblDiaryEntriesUpcomingRowChangeEvent((dsTabNotePanel.tblDiaryEntriesUpcomingRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblDiaryEntriesUpcomingRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsTabNotePanel.tblDiaryEntriesUpcomingRowChangeEventHandler upcomingRowDeletedEvent = this.tblDiaryEntriesUpcomingRowDeletedEvent;
      if (upcomingRowDeletedEvent == null)
        return;
      upcomingRowDeletedEvent((object) this, new dsTabNotePanel.tblDiaryEntriesUpcomingRowChangeEvent((dsTabNotePanel.tblDiaryEntriesUpcomingRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblDiaryEntriesUpcomingRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsTabNotePanel.tblDiaryEntriesUpcomingRowChangeEventHandler rowDeletingEvent = this.tblDiaryEntriesUpcomingRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsTabNotePanel.tblDiaryEntriesUpcomingRowChangeEvent((dsTabNotePanel.tblDiaryEntriesUpcomingRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemovetblDiaryEntriesUpcomingRow(dsTabNotePanel.tblDiaryEntriesUpcomingRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsTabNotePanel dsTabNotePanel = new dsTabNotePanel();
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
        FixedValue = dsTabNotePanel.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblDiaryEntriesUpcomingDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsTabNotePanel.GetSchemaSerializable();
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
  public class tblEntriesUnreadDataTable : TypedTableBase<dsTabNotePanel.tblEntriesUnreadRow>
  {
    private DataColumn columnEntryGUID;
    private DataColumn columnNoteGUID;
    private DataColumn columnCreatedDate;
    private DataColumn columnBODY;
    private DataColumn columnUserName;
    private DataColumn columnSubject;
    private DataColumn columnType;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblEntriesUnreadDataTable()
    {
      this.TableName = "tblEntriesUnread";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblEntriesUnreadDataTable(DataTable table)
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
    protected tblEntriesUnreadDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn EntryGUIDColumn => this.columnEntryGUID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn NoteGUIDColumn => this.columnNoteGUID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn CreatedDateColumn => this.columnCreatedDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn BODYColumn => this.columnBODY;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn UserNameColumn => this.columnUserName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn SubjectColumn => this.columnSubject;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn TypeColumn => this.columnType;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsTabNotePanel.tblEntriesUnreadRow this[int index]
    {
      get => (dsTabNotePanel.tblEntriesUnreadRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsTabNotePanel.tblEntriesUnreadRowChangeEventHandler tblEntriesUnreadRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsTabNotePanel.tblEntriesUnreadRowChangeEventHandler tblEntriesUnreadRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsTabNotePanel.tblEntriesUnreadRowChangeEventHandler tblEntriesUnreadRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsTabNotePanel.tblEntriesUnreadRowChangeEventHandler tblEntriesUnreadRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddtblEntriesUnreadRow(dsTabNotePanel.tblEntriesUnreadRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsTabNotePanel.tblEntriesUnreadRow AddtblEntriesUnreadRow(
      Guid EntryGUID,
      Guid NoteGUID,
      DateTime CreatedDate,
      string BODY,
      string UserName,
      string Subject,
      int Type)
    {
      dsTabNotePanel.tblEntriesUnreadRow row = (dsTabNotePanel.tblEntriesUnreadRow) this.NewRow();
      object[] objArray = new object[7]
      {
        (object) EntryGUID,
        (object) NoteGUID,
        (object) CreatedDate,
        (object) BODY,
        (object) UserName,
        (object) Subject,
        (object) Type
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsTabNotePanel.tblEntriesUnreadDataTable entriesUnreadDataTable = (dsTabNotePanel.tblEntriesUnreadDataTable) base.Clone();
      entriesUnreadDataTable.InitVars();
      return (DataTable) entriesUnreadDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsTabNotePanel.tblEntriesUnreadDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnEntryGUID = this.Columns["EntryGUID"];
      this.columnNoteGUID = this.Columns["NoteGUID"];
      this.columnCreatedDate = this.Columns["CreatedDate"];
      this.columnBODY = this.Columns["BODY"];
      this.columnUserName = this.Columns["UserName"];
      this.columnSubject = this.Columns["Subject"];
      this.columnType = this.Columns["Type"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnEntryGUID = new DataColumn("EntryGUID", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEntryGUID);
      this.columnNoteGUID = new DataColumn("NoteGUID", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnNoteGUID);
      this.columnCreatedDate = new DataColumn("CreatedDate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCreatedDate);
      this.columnBODY = new DataColumn("BODY", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnBODY);
      this.columnUserName = new DataColumn("UserName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnUserName);
      this.columnSubject = new DataColumn("Subject", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSubject);
      this.columnType = new DataColumn("Type", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnType);
      this.columnEntryGUID.AllowDBNull = false;
      this.columnNoteGUID.AllowDBNull = false;
      this.columnCreatedDate.AllowDBNull = false;
      this.columnBODY.ReadOnly = true;
      this.columnUserName.AllowDBNull = false;
      this.columnSubject.AllowDBNull = false;
      this.columnType.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsTabNotePanel.tblEntriesUnreadRow NewtblEntriesUnreadRow()
    {
      return (dsTabNotePanel.tblEntriesUnreadRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsTabNotePanel.tblEntriesUnreadRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (dsTabNotePanel.tblEntriesUnreadRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblEntriesUnreadRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsTabNotePanel.tblEntriesUnreadRowChangeEventHandler unreadRowChangedEvent = this.tblEntriesUnreadRowChangedEvent;
      if (unreadRowChangedEvent == null)
        return;
      unreadRowChangedEvent((object) this, new dsTabNotePanel.tblEntriesUnreadRowChangeEvent((dsTabNotePanel.tblEntriesUnreadRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblEntriesUnreadRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsTabNotePanel.tblEntriesUnreadRowChangeEventHandler rowChangingEvent = this.tblEntriesUnreadRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsTabNotePanel.tblEntriesUnreadRowChangeEvent((dsTabNotePanel.tblEntriesUnreadRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblEntriesUnreadRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsTabNotePanel.tblEntriesUnreadRowChangeEventHandler unreadRowDeletedEvent = this.tblEntriesUnreadRowDeletedEvent;
      if (unreadRowDeletedEvent == null)
        return;
      unreadRowDeletedEvent((object) this, new dsTabNotePanel.tblEntriesUnreadRowChangeEvent((dsTabNotePanel.tblEntriesUnreadRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblEntriesUnreadRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsTabNotePanel.tblEntriesUnreadRowChangeEventHandler rowDeletingEvent = this.tblEntriesUnreadRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsTabNotePanel.tblEntriesUnreadRowChangeEvent((dsTabNotePanel.tblEntriesUnreadRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemovetblEntriesUnreadRow(dsTabNotePanel.tblEntriesUnreadRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsTabNotePanel dsTabNotePanel = new dsTabNotePanel();
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
        FixedValue = dsTabNotePanel.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblEntriesUnreadDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsTabNotePanel.GetSchemaSerializable();
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
  public class tblNotesBoundDataTable : TypedTableBase<dsTabNotePanel.tblNotesBoundRow>
  {
    private DataColumn columnID;
    private DataColumn columnCreatedDate;
    private DataColumn columnType;
    private DataColumn columnSubject;
    private DataColumn columnUserName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblNotesBoundDataTable()
    {
      this.TableName = "tblNotesBound";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblNotesBoundDataTable(DataTable table)
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
    protected tblNotesBoundDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn IDColumn => this.columnID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn CreatedDateColumn => this.columnCreatedDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn TypeColumn => this.columnType;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn SubjectColumn => this.columnSubject;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn UserNameColumn => this.columnUserName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsTabNotePanel.tblNotesBoundRow this[int index]
    {
      get => (dsTabNotePanel.tblNotesBoundRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsTabNotePanel.tblNotesBoundRowChangeEventHandler tblNotesBoundRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsTabNotePanel.tblNotesBoundRowChangeEventHandler tblNotesBoundRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsTabNotePanel.tblNotesBoundRowChangeEventHandler tblNotesBoundRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsTabNotePanel.tblNotesBoundRowChangeEventHandler tblNotesBoundRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddtblNotesBoundRow(dsTabNotePanel.tblNotesBoundRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsTabNotePanel.tblNotesBoundRow AddtblNotesBoundRow(
      Guid ID,
      DateTime CreatedDate,
      int Type,
      string Subject,
      string UserName)
    {
      dsTabNotePanel.tblNotesBoundRow row = (dsTabNotePanel.tblNotesBoundRow) this.NewRow();
      object[] objArray = new object[5]
      {
        (object) ID,
        (object) CreatedDate,
        (object) Type,
        (object) Subject,
        (object) UserName
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsTabNotePanel.tblNotesBoundDataTable notesBoundDataTable = (dsTabNotePanel.tblNotesBoundDataTable) base.Clone();
      notesBoundDataTable.InitVars();
      return (DataTable) notesBoundDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsTabNotePanel.tblNotesBoundDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnID = this.Columns["ID"];
      this.columnCreatedDate = this.Columns["CreatedDate"];
      this.columnType = this.Columns["Type"];
      this.columnSubject = this.Columns["Subject"];
      this.columnUserName = this.Columns["UserName"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnID = new DataColumn("ID", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnID);
      this.columnCreatedDate = new DataColumn("CreatedDate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCreatedDate);
      this.columnType = new DataColumn("Type", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnType);
      this.columnSubject = new DataColumn("Subject", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSubject);
      this.columnUserName = new DataColumn("UserName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnUserName);
      this.columnID.AllowDBNull = false;
      this.columnCreatedDate.AllowDBNull = false;
      this.columnType.AllowDBNull = false;
      this.columnSubject.AllowDBNull = false;
      this.columnUserName.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsTabNotePanel.tblNotesBoundRow NewtblNotesBoundRow()
    {
      return (dsTabNotePanel.tblNotesBoundRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsTabNotePanel.tblNotesBoundRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (dsTabNotePanel.tblNotesBoundRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblNotesBoundRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsTabNotePanel.tblNotesBoundRowChangeEventHandler boundRowChangedEvent = this.tblNotesBoundRowChangedEvent;
      if (boundRowChangedEvent == null)
        return;
      boundRowChangedEvent((object) this, new dsTabNotePanel.tblNotesBoundRowChangeEvent((dsTabNotePanel.tblNotesBoundRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblNotesBoundRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsTabNotePanel.tblNotesBoundRowChangeEventHandler rowChangingEvent = this.tblNotesBoundRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsTabNotePanel.tblNotesBoundRowChangeEvent((dsTabNotePanel.tblNotesBoundRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblNotesBoundRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsTabNotePanel.tblNotesBoundRowChangeEventHandler boundRowDeletedEvent = this.tblNotesBoundRowDeletedEvent;
      if (boundRowDeletedEvent == null)
        return;
      boundRowDeletedEvent((object) this, new dsTabNotePanel.tblNotesBoundRowChangeEvent((dsTabNotePanel.tblNotesBoundRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblNotesBoundRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsTabNotePanel.tblNotesBoundRowChangeEventHandler rowDeletingEvent = this.tblNotesBoundRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsTabNotePanel.tblNotesBoundRowChangeEvent((dsTabNotePanel.tblNotesBoundRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemovetblNotesBoundRow(dsTabNotePanel.tblNotesBoundRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsTabNotePanel dsTabNotePanel = new dsTabNotePanel();
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
        FixedValue = dsTabNotePanel.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblNotesBoundDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsTabNotePanel.GetSchemaSerializable();
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
  public class tblNotesUnboundDataTable : TypedTableBase<dsTabNotePanel.tblNotesUnboundRow>
  {
    private DataColumn columnID;
    private DataColumn columnCreatedDate;
    private DataColumn columnType;
    private DataColumn columnSubject;
    private DataColumn columnUserName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblNotesUnboundDataTable()
    {
      this.TableName = "tblNotesUnbound";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblNotesUnboundDataTable(DataTable table)
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
    protected tblNotesUnboundDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn IDColumn => this.columnID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn CreatedDateColumn => this.columnCreatedDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn TypeColumn => this.columnType;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn SubjectColumn => this.columnSubject;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn UserNameColumn => this.columnUserName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsTabNotePanel.tblNotesUnboundRow this[int index]
    {
      get => (dsTabNotePanel.tblNotesUnboundRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsTabNotePanel.tblNotesUnboundRowChangeEventHandler tblNotesUnboundRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsTabNotePanel.tblNotesUnboundRowChangeEventHandler tblNotesUnboundRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsTabNotePanel.tblNotesUnboundRowChangeEventHandler tblNotesUnboundRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsTabNotePanel.tblNotesUnboundRowChangeEventHandler tblNotesUnboundRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddtblNotesUnboundRow(dsTabNotePanel.tblNotesUnboundRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsTabNotePanel.tblNotesUnboundRow AddtblNotesUnboundRow(
      Guid ID,
      DateTime CreatedDate,
      int Type,
      string Subject,
      string UserName)
    {
      dsTabNotePanel.tblNotesUnboundRow row = (dsTabNotePanel.tblNotesUnboundRow) this.NewRow();
      object[] objArray = new object[5]
      {
        (object) ID,
        (object) CreatedDate,
        (object) Type,
        (object) Subject,
        (object) UserName
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsTabNotePanel.tblNotesUnboundDataTable unboundDataTable = (dsTabNotePanel.tblNotesUnboundDataTable) base.Clone();
      unboundDataTable.InitVars();
      return (DataTable) unboundDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsTabNotePanel.tblNotesUnboundDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnID = this.Columns["ID"];
      this.columnCreatedDate = this.Columns["CreatedDate"];
      this.columnType = this.Columns["Type"];
      this.columnSubject = this.Columns["Subject"];
      this.columnUserName = this.Columns["UserName"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnID = new DataColumn("ID", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnID);
      this.columnCreatedDate = new DataColumn("CreatedDate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCreatedDate);
      this.columnType = new DataColumn("Type", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnType);
      this.columnSubject = new DataColumn("Subject", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSubject);
      this.columnUserName = new DataColumn("UserName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnUserName);
      this.columnID.AllowDBNull = false;
      this.columnCreatedDate.AllowDBNull = false;
      this.columnType.AllowDBNull = false;
      this.columnSubject.AllowDBNull = false;
      this.columnUserName.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsTabNotePanel.tblNotesUnboundRow NewtblNotesUnboundRow()
    {
      return (dsTabNotePanel.tblNotesUnboundRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsTabNotePanel.tblNotesUnboundRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (dsTabNotePanel.tblNotesUnboundRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblNotesUnboundRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsTabNotePanel.tblNotesUnboundRowChangeEventHandler unboundRowChangedEvent = this.tblNotesUnboundRowChangedEvent;
      if (unboundRowChangedEvent == null)
        return;
      unboundRowChangedEvent((object) this, new dsTabNotePanel.tblNotesUnboundRowChangeEvent((dsTabNotePanel.tblNotesUnboundRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblNotesUnboundRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsTabNotePanel.tblNotesUnboundRowChangeEventHandler rowChangingEvent = this.tblNotesUnboundRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsTabNotePanel.tblNotesUnboundRowChangeEvent((dsTabNotePanel.tblNotesUnboundRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblNotesUnboundRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsTabNotePanel.tblNotesUnboundRowChangeEventHandler unboundRowDeletedEvent = this.tblNotesUnboundRowDeletedEvent;
      if (unboundRowDeletedEvent == null)
        return;
      unboundRowDeletedEvent((object) this, new dsTabNotePanel.tblNotesUnboundRowChangeEvent((dsTabNotePanel.tblNotesUnboundRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblNotesUnboundRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsTabNotePanel.tblNotesUnboundRowChangeEventHandler rowDeletingEvent = this.tblNotesUnboundRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsTabNotePanel.tblNotesUnboundRowChangeEvent((dsTabNotePanel.tblNotesUnboundRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemovetblNotesUnboundRow(dsTabNotePanel.tblNotesUnboundRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsTabNotePanel dsTabNotePanel = new dsTabNotePanel();
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
        FixedValue = dsTabNotePanel.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblNotesUnboundDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsTabNotePanel.GetSchemaSerializable();
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
  public class tblDiaryEntriesOpenDataTable : TypedTableBase<dsTabNotePanel.tblDiaryEntriesOpenRow>
  {
    private DataColumn columnEntryGUID;
    private DataColumn columnNoteGUID;
    private DataColumn columnIsDiary;
    private DataColumn columnCreatedDate;
    private DataColumn columnDueDate;
    private DataColumn columnBody;
    private DataColumn columnType;
    private DataColumn columnSubject;
    private DataColumn columnUserName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblDiaryEntriesOpenDataTable()
    {
      this.TableName = "tblDiaryEntriesOpen";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblDiaryEntriesOpenDataTable(DataTable table)
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
    protected tblDiaryEntriesOpenDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn EntryGUIDColumn => this.columnEntryGUID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn NoteGUIDColumn => this.columnNoteGUID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn IsDiaryColumn => this.columnIsDiary;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn CreatedDateColumn => this.columnCreatedDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn DueDateColumn => this.columnDueDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn BodyColumn => this.columnBody;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn TypeColumn => this.columnType;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn SubjectColumn => this.columnSubject;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn UserNameColumn => this.columnUserName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsTabNotePanel.tblDiaryEntriesOpenRow this[int index]
    {
      get => (dsTabNotePanel.tblDiaryEntriesOpenRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsTabNotePanel.tblDiaryEntriesOpenRowChangeEventHandler tblDiaryEntriesOpenRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsTabNotePanel.tblDiaryEntriesOpenRowChangeEventHandler tblDiaryEntriesOpenRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsTabNotePanel.tblDiaryEntriesOpenRowChangeEventHandler tblDiaryEntriesOpenRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsTabNotePanel.tblDiaryEntriesOpenRowChangeEventHandler tblDiaryEntriesOpenRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddtblDiaryEntriesOpenRow(dsTabNotePanel.tblDiaryEntriesOpenRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsTabNotePanel.tblDiaryEntriesOpenRow AddtblDiaryEntriesOpenRow(
      Guid EntryGUID,
      Guid NoteGUID,
      bool IsDiary,
      DateTime CreatedDate,
      DateTime DueDate,
      string Body,
      int Type,
      string Subject,
      string UserName)
    {
      dsTabNotePanel.tblDiaryEntriesOpenRow row = (dsTabNotePanel.tblDiaryEntriesOpenRow) this.NewRow();
      object[] objArray = new object[9]
      {
        (object) EntryGUID,
        (object) NoteGUID,
        (object) IsDiary,
        (object) CreatedDate,
        (object) DueDate,
        (object) Body,
        (object) Type,
        (object) Subject,
        (object) UserName
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsTabNotePanel.tblDiaryEntriesOpenDataTable entriesOpenDataTable = (dsTabNotePanel.tblDiaryEntriesOpenDataTable) base.Clone();
      entriesOpenDataTable.InitVars();
      return (DataTable) entriesOpenDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsTabNotePanel.tblDiaryEntriesOpenDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnEntryGUID = this.Columns["EntryGUID"];
      this.columnNoteGUID = this.Columns["NoteGUID"];
      this.columnIsDiary = this.Columns["IsDiary"];
      this.columnCreatedDate = this.Columns["CreatedDate"];
      this.columnDueDate = this.Columns["DueDate"];
      this.columnBody = this.Columns["Body"];
      this.columnType = this.Columns["Type"];
      this.columnSubject = this.Columns["Subject"];
      this.columnUserName = this.Columns["UserName"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnEntryGUID = new DataColumn("EntryGUID", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEntryGUID);
      this.columnNoteGUID = new DataColumn("NoteGUID", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnNoteGUID);
      this.columnIsDiary = new DataColumn("IsDiary", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnIsDiary);
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
      this.columnUserName = new DataColumn("UserName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnUserName);
      this.columnEntryGUID.AllowDBNull = false;
      this.columnNoteGUID.AllowDBNull = false;
      this.columnIsDiary.AllowDBNull = false;
      this.columnCreatedDate.AllowDBNull = false;
      this.columnDueDate.AllowDBNull = false;
      this.columnBody.ReadOnly = true;
      this.columnType.AllowDBNull = false;
      this.columnSubject.AllowDBNull = false;
      this.columnUserName.ReadOnly = true;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsTabNotePanel.tblDiaryEntriesOpenRow NewtblDiaryEntriesOpenRow()
    {
      return (dsTabNotePanel.tblDiaryEntriesOpenRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsTabNotePanel.tblDiaryEntriesOpenRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (dsTabNotePanel.tblDiaryEntriesOpenRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblDiaryEntriesOpenRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsTabNotePanel.tblDiaryEntriesOpenRowChangeEventHandler openRowChangedEvent = this.tblDiaryEntriesOpenRowChangedEvent;
      if (openRowChangedEvent == null)
        return;
      openRowChangedEvent((object) this, new dsTabNotePanel.tblDiaryEntriesOpenRowChangeEvent((dsTabNotePanel.tblDiaryEntriesOpenRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblDiaryEntriesOpenRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsTabNotePanel.tblDiaryEntriesOpenRowChangeEventHandler rowChangingEvent = this.tblDiaryEntriesOpenRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsTabNotePanel.tblDiaryEntriesOpenRowChangeEvent((dsTabNotePanel.tblDiaryEntriesOpenRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblDiaryEntriesOpenRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsTabNotePanel.tblDiaryEntriesOpenRowChangeEventHandler openRowDeletedEvent = this.tblDiaryEntriesOpenRowDeletedEvent;
      if (openRowDeletedEvent == null)
        return;
      openRowDeletedEvent((object) this, new dsTabNotePanel.tblDiaryEntriesOpenRowChangeEvent((dsTabNotePanel.tblDiaryEntriesOpenRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblDiaryEntriesOpenRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsTabNotePanel.tblDiaryEntriesOpenRowChangeEventHandler rowDeletingEvent = this.tblDiaryEntriesOpenRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsTabNotePanel.tblDiaryEntriesOpenRowChangeEvent((dsTabNotePanel.tblDiaryEntriesOpenRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemovetblDiaryEntriesOpenRow(dsTabNotePanel.tblDiaryEntriesOpenRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsTabNotePanel dsTabNotePanel = new dsTabNotePanel();
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
        FixedValue = dsTabNotePanel.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblDiaryEntriesOpenDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsTabNotePanel.GetSchemaSerializable();
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
  public class tblDiaryEntriesUrgentDataTable : 
    TypedTableBase<dsTabNotePanel.tblDiaryEntriesUrgentRow>
  {
    private DataColumn columnEntryGUID;
    private DataColumn columnNoteGUID;
    private DataColumn columnIsDiary;
    private DataColumn columnCreatedDate;
    private DataColumn columnDueDate;
    private DataColumn columnBody;
    private DataColumn columnType;
    private DataColumn columnSubject;
    private DataColumn columnUserName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblDiaryEntriesUrgentDataTable()
    {
      this.TableName = "tblDiaryEntriesUrgent";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblDiaryEntriesUrgentDataTable(DataTable table)
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
    protected tblDiaryEntriesUrgentDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn EntryGUIDColumn => this.columnEntryGUID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn NoteGUIDColumn => this.columnNoteGUID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn IsDiaryColumn => this.columnIsDiary;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn CreatedDateColumn => this.columnCreatedDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn DueDateColumn => this.columnDueDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn BodyColumn => this.columnBody;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn TypeColumn => this.columnType;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn SubjectColumn => this.columnSubject;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn UserNameColumn => this.columnUserName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsTabNotePanel.tblDiaryEntriesUrgentRow this[int index]
    {
      get => (dsTabNotePanel.tblDiaryEntriesUrgentRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsTabNotePanel.tblDiaryEntriesUrgentRowChangeEventHandler tblDiaryEntriesUrgentRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsTabNotePanel.tblDiaryEntriesUrgentRowChangeEventHandler tblDiaryEntriesUrgentRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsTabNotePanel.tblDiaryEntriesUrgentRowChangeEventHandler tblDiaryEntriesUrgentRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsTabNotePanel.tblDiaryEntriesUrgentRowChangeEventHandler tblDiaryEntriesUrgentRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddtblDiaryEntriesUrgentRow(dsTabNotePanel.tblDiaryEntriesUrgentRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsTabNotePanel.tblDiaryEntriesUrgentRow AddtblDiaryEntriesUrgentRow(
      Guid EntryGUID,
      Guid NoteGUID,
      bool IsDiary,
      DateTime CreatedDate,
      DateTime DueDate,
      string Body,
      int Type,
      string Subject,
      string UserName)
    {
      dsTabNotePanel.tblDiaryEntriesUrgentRow row = (dsTabNotePanel.tblDiaryEntriesUrgentRow) this.NewRow();
      object[] objArray = new object[9]
      {
        (object) EntryGUID,
        (object) NoteGUID,
        (object) IsDiary,
        (object) CreatedDate,
        (object) DueDate,
        (object) Body,
        (object) Type,
        (object) Subject,
        (object) UserName
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsTabNotePanel.tblDiaryEntriesUrgentDataTable entriesUrgentDataTable = (dsTabNotePanel.tblDiaryEntriesUrgentDataTable) base.Clone();
      entriesUrgentDataTable.InitVars();
      return (DataTable) entriesUrgentDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsTabNotePanel.tblDiaryEntriesUrgentDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnEntryGUID = this.Columns["EntryGUID"];
      this.columnNoteGUID = this.Columns["NoteGUID"];
      this.columnIsDiary = this.Columns["IsDiary"];
      this.columnCreatedDate = this.Columns["CreatedDate"];
      this.columnDueDate = this.Columns["DueDate"];
      this.columnBody = this.Columns["Body"];
      this.columnType = this.Columns["Type"];
      this.columnSubject = this.Columns["Subject"];
      this.columnUserName = this.Columns["UserName"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnEntryGUID = new DataColumn("EntryGUID", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEntryGUID);
      this.columnNoteGUID = new DataColumn("NoteGUID", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnNoteGUID);
      this.columnIsDiary = new DataColumn("IsDiary", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnIsDiary);
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
      this.columnUserName = new DataColumn("UserName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnUserName);
      this.columnEntryGUID.AllowDBNull = false;
      this.columnNoteGUID.AllowDBNull = false;
      this.columnIsDiary.AllowDBNull = false;
      this.columnCreatedDate.AllowDBNull = false;
      this.columnDueDate.AllowDBNull = false;
      this.columnBody.ReadOnly = true;
      this.columnType.AllowDBNull = false;
      this.columnSubject.AllowDBNull = false;
      this.columnUserName.ReadOnly = true;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsTabNotePanel.tblDiaryEntriesUrgentRow NewtblDiaryEntriesUrgentRow()
    {
      return (dsTabNotePanel.tblDiaryEntriesUrgentRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsTabNotePanel.tblDiaryEntriesUrgentRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (dsTabNotePanel.tblDiaryEntriesUrgentRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblDiaryEntriesUrgentRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsTabNotePanel.tblDiaryEntriesUrgentRowChangeEventHandler urgentRowChangedEvent = this.tblDiaryEntriesUrgentRowChangedEvent;
      if (urgentRowChangedEvent == null)
        return;
      urgentRowChangedEvent((object) this, new dsTabNotePanel.tblDiaryEntriesUrgentRowChangeEvent((dsTabNotePanel.tblDiaryEntriesUrgentRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblDiaryEntriesUrgentRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsTabNotePanel.tblDiaryEntriesUrgentRowChangeEventHandler rowChangingEvent = this.tblDiaryEntriesUrgentRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsTabNotePanel.tblDiaryEntriesUrgentRowChangeEvent((dsTabNotePanel.tblDiaryEntriesUrgentRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblDiaryEntriesUrgentRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsTabNotePanel.tblDiaryEntriesUrgentRowChangeEventHandler urgentRowDeletedEvent = this.tblDiaryEntriesUrgentRowDeletedEvent;
      if (urgentRowDeletedEvent == null)
        return;
      urgentRowDeletedEvent((object) this, new dsTabNotePanel.tblDiaryEntriesUrgentRowChangeEvent((dsTabNotePanel.tblDiaryEntriesUrgentRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblDiaryEntriesUrgentRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsTabNotePanel.tblDiaryEntriesUrgentRowChangeEventHandler rowDeletingEvent = this.tblDiaryEntriesUrgentRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsTabNotePanel.tblDiaryEntriesUrgentRowChangeEvent((dsTabNotePanel.tblDiaryEntriesUrgentRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemovetblDiaryEntriesUrgentRow(dsTabNotePanel.tblDiaryEntriesUrgentRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsTabNotePanel dsTabNotePanel = new dsTabNotePanel();
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
        FixedValue = dsTabNotePanel.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblDiaryEntriesUrgentDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsTabNotePanel.GetSchemaSerializable();
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

  public class tblDiaryEntriesUpcomingRow : DataRow
  {
    private dsTabNotePanel.tblDiaryEntriesUpcomingDataTable tabletblDiaryEntriesUpcoming;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblDiaryEntriesUpcomingRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblDiaryEntriesUpcoming = (dsTabNotePanel.tblDiaryEntriesUpcomingDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Guid EntryGUID
    {
      get
      {
        object obj = this[this.tabletblDiaryEntriesUpcoming.EntryGUIDColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tabletblDiaryEntriesUpcoming.EntryGUIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Guid NoteGUID
    {
      get
      {
        object obj = this[this.tabletblDiaryEntriesUpcoming.NoteGUIDColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tabletblDiaryEntriesUpcoming.NoteGUIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsDiary
    {
      get => Conversions.ToBoolean(this[this.tabletblDiaryEntriesUpcoming.IsDiaryColumn]);
      set => this[this.tabletblDiaryEntriesUpcoming.IsDiaryColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DateTime CreatedDate
    {
      get => Conversions.ToDate(this[this.tabletblDiaryEntriesUpcoming.CreatedDateColumn]);
      set => this[this.tabletblDiaryEntriesUpcoming.CreatedDateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DateTime DueDate
    {
      get => Conversions.ToDate(this[this.tabletblDiaryEntriesUpcoming.DueDateColumn]);
      set => this[this.tabletblDiaryEntriesUpcoming.DueDateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Body
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblDiaryEntriesUpcoming.BodyColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Body' in table 'tblDiaryEntriesUpcoming' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblDiaryEntriesUpcoming.BodyColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int Type
    {
      get => Conversions.ToInteger(this[this.tabletblDiaryEntriesUpcoming.TypeColumn]);
      set => this[this.tabletblDiaryEntriesUpcoming.TypeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Subject
    {
      get => Conversions.ToString(this[this.tabletblDiaryEntriesUpcoming.SubjectColumn]);
      set => this[this.tabletblDiaryEntriesUpcoming.SubjectColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsBodyNull() => this.IsNull(this.tabletblDiaryEntriesUpcoming.BodyColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetBodyNull()
    {
      this[this.tabletblDiaryEntriesUpcoming.BodyColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class tblEntriesUnreadRow : DataRow
  {
    private dsTabNotePanel.tblEntriesUnreadDataTable tabletblEntriesUnread;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblEntriesUnreadRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblEntriesUnread = (dsTabNotePanel.tblEntriesUnreadDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Guid EntryGUID
    {
      get
      {
        object obj = this[this.tabletblEntriesUnread.EntryGUIDColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tabletblEntriesUnread.EntryGUIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Guid NoteGUID
    {
      get
      {
        object obj = this[this.tabletblEntriesUnread.NoteGUIDColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tabletblEntriesUnread.NoteGUIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DateTime CreatedDate
    {
      get => Conversions.ToDate(this[this.tabletblEntriesUnread.CreatedDateColumn]);
      set => this[this.tabletblEntriesUnread.CreatedDateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string BODY
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblEntriesUnread.BODYColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'BODY' in table 'tblEntriesUnread' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblEntriesUnread.BODYColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string UserName
    {
      get => Conversions.ToString(this[this.tabletblEntriesUnread.UserNameColumn]);
      set => this[this.tabletblEntriesUnread.UserNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Subject
    {
      get => Conversions.ToString(this[this.tabletblEntriesUnread.SubjectColumn]);
      set => this[this.tabletblEntriesUnread.SubjectColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int Type
    {
      get => Conversions.ToInteger(this[this.tabletblEntriesUnread.TypeColumn]);
      set => this[this.tabletblEntriesUnread.TypeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsBODYNull() => this.IsNull(this.tabletblEntriesUnread.BODYColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetBODYNull()
    {
      this[this.tabletblEntriesUnread.BODYColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class tblNotesBoundRow : DataRow
  {
    private dsTabNotePanel.tblNotesBoundDataTable tabletblNotesBound;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblNotesBoundRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblNotesBound = (dsTabNotePanel.tblNotesBoundDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Guid ID
    {
      get
      {
        object obj = this[this.tabletblNotesBound.IDColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tabletblNotesBound.IDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DateTime CreatedDate
    {
      get => Conversions.ToDate(this[this.tabletblNotesBound.CreatedDateColumn]);
      set => this[this.tabletblNotesBound.CreatedDateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int Type
    {
      get => Conversions.ToInteger(this[this.tabletblNotesBound.TypeColumn]);
      set => this[this.tabletblNotesBound.TypeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Subject
    {
      get => Conversions.ToString(this[this.tabletblNotesBound.SubjectColumn]);
      set => this[this.tabletblNotesBound.SubjectColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string UserName
    {
      get => Conversions.ToString(this[this.tabletblNotesBound.UserNameColumn]);
      set => this[this.tabletblNotesBound.UserNameColumn] = (object) value;
    }
  }

  public class tblNotesUnboundRow : DataRow
  {
    private dsTabNotePanel.tblNotesUnboundDataTable tabletblNotesUnbound;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblNotesUnboundRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblNotesUnbound = (dsTabNotePanel.tblNotesUnboundDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Guid ID
    {
      get
      {
        object obj = this[this.tabletblNotesUnbound.IDColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tabletblNotesUnbound.IDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DateTime CreatedDate
    {
      get => Conversions.ToDate(this[this.tabletblNotesUnbound.CreatedDateColumn]);
      set => this[this.tabletblNotesUnbound.CreatedDateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int Type
    {
      get => Conversions.ToInteger(this[this.tabletblNotesUnbound.TypeColumn]);
      set => this[this.tabletblNotesUnbound.TypeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Subject
    {
      get => Conversions.ToString(this[this.tabletblNotesUnbound.SubjectColumn]);
      set => this[this.tabletblNotesUnbound.SubjectColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string UserName
    {
      get => Conversions.ToString(this[this.tabletblNotesUnbound.UserNameColumn]);
      set => this[this.tabletblNotesUnbound.UserNameColumn] = (object) value;
    }
  }

  public class tblDiaryEntriesOpenRow : DataRow
  {
    private dsTabNotePanel.tblDiaryEntriesOpenDataTable tabletblDiaryEntriesOpen;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblDiaryEntriesOpenRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblDiaryEntriesOpen = (dsTabNotePanel.tblDiaryEntriesOpenDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Guid EntryGUID
    {
      get
      {
        object obj = this[this.tabletblDiaryEntriesOpen.EntryGUIDColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tabletblDiaryEntriesOpen.EntryGUIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Guid NoteGUID
    {
      get
      {
        object obj = this[this.tabletblDiaryEntriesOpen.NoteGUIDColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tabletblDiaryEntriesOpen.NoteGUIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsDiary
    {
      get => Conversions.ToBoolean(this[this.tabletblDiaryEntriesOpen.IsDiaryColumn]);
      set => this[this.tabletblDiaryEntriesOpen.IsDiaryColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DateTime CreatedDate
    {
      get => Conversions.ToDate(this[this.tabletblDiaryEntriesOpen.CreatedDateColumn]);
      set => this[this.tabletblDiaryEntriesOpen.CreatedDateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DateTime DueDate
    {
      get => Conversions.ToDate(this[this.tabletblDiaryEntriesOpen.DueDateColumn]);
      set => this[this.tabletblDiaryEntriesOpen.DueDateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Body
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblDiaryEntriesOpen.BodyColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Body' in table 'tblDiaryEntriesOpen' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblDiaryEntriesOpen.BodyColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int Type
    {
      get => Conversions.ToInteger(this[this.tabletblDiaryEntriesOpen.TypeColumn]);
      set => this[this.tabletblDiaryEntriesOpen.TypeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Subject
    {
      get => Conversions.ToString(this[this.tabletblDiaryEntriesOpen.SubjectColumn]);
      set => this[this.tabletblDiaryEntriesOpen.SubjectColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string UserName
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblDiaryEntriesOpen.UserNameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'UserName' in table 'tblDiaryEntriesOpen' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblDiaryEntriesOpen.UserNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsBodyNull() => this.IsNull(this.tabletblDiaryEntriesOpen.BodyColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetBodyNull()
    {
      this[this.tabletblDiaryEntriesOpen.BodyColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsUserNameNull() => this.IsNull(this.tabletblDiaryEntriesOpen.UserNameColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetUserNameNull()
    {
      this[this.tabletblDiaryEntriesOpen.UserNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class tblDiaryEntriesUrgentRow : DataRow
  {
    private dsTabNotePanel.tblDiaryEntriesUrgentDataTable tabletblDiaryEntriesUrgent;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblDiaryEntriesUrgentRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblDiaryEntriesUrgent = (dsTabNotePanel.tblDiaryEntriesUrgentDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Guid EntryGUID
    {
      get
      {
        object obj = this[this.tabletblDiaryEntriesUrgent.EntryGUIDColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tabletblDiaryEntriesUrgent.EntryGUIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Guid NoteGUID
    {
      get
      {
        object obj = this[this.tabletblDiaryEntriesUrgent.NoteGUIDColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tabletblDiaryEntriesUrgent.NoteGUIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsDiary
    {
      get => Conversions.ToBoolean(this[this.tabletblDiaryEntriesUrgent.IsDiaryColumn]);
      set => this[this.tabletblDiaryEntriesUrgent.IsDiaryColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DateTime CreatedDate
    {
      get => Conversions.ToDate(this[this.tabletblDiaryEntriesUrgent.CreatedDateColumn]);
      set => this[this.tabletblDiaryEntriesUrgent.CreatedDateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DateTime DueDate
    {
      get => Conversions.ToDate(this[this.tabletblDiaryEntriesUrgent.DueDateColumn]);
      set => this[this.tabletblDiaryEntriesUrgent.DueDateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Body
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblDiaryEntriesUrgent.BodyColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Body' in table 'tblDiaryEntriesUrgent' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblDiaryEntriesUrgent.BodyColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int Type
    {
      get => Conversions.ToInteger(this[this.tabletblDiaryEntriesUrgent.TypeColumn]);
      set => this[this.tabletblDiaryEntriesUrgent.TypeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Subject
    {
      get => Conversions.ToString(this[this.tabletblDiaryEntriesUrgent.SubjectColumn]);
      set => this[this.tabletblDiaryEntriesUrgent.SubjectColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string UserName
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblDiaryEntriesUrgent.UserNameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'UserName' in table 'tblDiaryEntriesUrgent' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblDiaryEntriesUrgent.UserNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsBodyNull() => this.IsNull(this.tabletblDiaryEntriesUrgent.BodyColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetBodyNull()
    {
      this[this.tabletblDiaryEntriesUrgent.BodyColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsUserNameNull() => this.IsNull(this.tabletblDiaryEntriesUrgent.UserNameColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetUserNameNull()
    {
      this[this.tabletblDiaryEntriesUrgent.UserNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class tblDiaryEntriesUpcomingRowChangeEvent : EventArgs
  {
    private dsTabNotePanel.tblDiaryEntriesUpcomingRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblDiaryEntriesUpcomingRowChangeEvent(
      dsTabNotePanel.tblDiaryEntriesUpcomingRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsTabNotePanel.tblDiaryEntriesUpcomingRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class tblEntriesUnreadRowChangeEvent : EventArgs
  {
    private dsTabNotePanel.tblEntriesUnreadRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblEntriesUnreadRowChangeEvent(
      dsTabNotePanel.tblEntriesUnreadRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsTabNotePanel.tblEntriesUnreadRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class tblNotesBoundRowChangeEvent : EventArgs
  {
    private dsTabNotePanel.tblNotesBoundRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblNotesBoundRowChangeEvent(dsTabNotePanel.tblNotesBoundRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsTabNotePanel.tblNotesBoundRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class tblNotesUnboundRowChangeEvent : EventArgs
  {
    private dsTabNotePanel.tblNotesUnboundRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblNotesUnboundRowChangeEvent(
      dsTabNotePanel.tblNotesUnboundRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsTabNotePanel.tblNotesUnboundRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class tblDiaryEntriesOpenRowChangeEvent : EventArgs
  {
    private dsTabNotePanel.tblDiaryEntriesOpenRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblDiaryEntriesOpenRowChangeEvent(
      dsTabNotePanel.tblDiaryEntriesOpenRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsTabNotePanel.tblDiaryEntriesOpenRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class tblDiaryEntriesUrgentRowChangeEvent : EventArgs
  {
    private dsTabNotePanel.tblDiaryEntriesUrgentRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblDiaryEntriesUrgentRowChangeEvent(
      dsTabNotePanel.tblDiaryEntriesUrgentRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsTabNotePanel.tblDiaryEntriesUrgentRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }
}
