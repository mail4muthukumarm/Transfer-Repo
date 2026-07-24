// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.NoteDocuments.dsTabUserNotePanelMT
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
[XmlRoot("dsTabUserNotePanelMT")]
[HelpKeyword("vs.data.DataSet")]
[Serializable]
public class dsTabUserNotePanelMT : DataSet
{
  private dsTabUserNotePanelMT.tblNotesEntityDataTable tabletblNotesEntity;
  private dsTabUserNotePanelMT.tblNotesUnboundDataTable tabletblNotesUnbound;
  private dsTabUserNotePanelMT.lstNoteTypesDataTable tablelstNoteTypes;
  private SchemaSerializationMode _schemaSerializationMode;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public dsTabUserNotePanelMT()
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
  protected dsTabUserNotePanelMT(SerializationInfo info, StreamingContext context)
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
        if (dataSet.Tables[nameof (tblNotesEntity)] != null)
          base.Tables.Add((DataTable) new dsTabUserNotePanelMT.tblNotesEntityDataTable(dataSet.Tables[nameof (tblNotesEntity)]));
        if (dataSet.Tables[nameof (tblNotesUnbound)] != null)
          base.Tables.Add((DataTable) new dsTabUserNotePanelMT.tblNotesUnboundDataTable(dataSet.Tables[nameof (tblNotesUnbound)]));
        if (dataSet.Tables[nameof (lstNoteTypes)] != null)
          base.Tables.Add((DataTable) new dsTabUserNotePanelMT.lstNoteTypesDataTable(dataSet.Tables[nameof (lstNoteTypes)]));
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
  public dsTabUserNotePanelMT.tblNotesEntityDataTable tblNotesEntity => this.tabletblNotesEntity;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsTabUserNotePanelMT.tblNotesUnboundDataTable tblNotesUnbound => this.tabletblNotesUnbound;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsTabUserNotePanelMT.lstNoteTypesDataTable lstNoteTypes => this.tablelstNoteTypes;

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
    dsTabUserNotePanelMT tabUserNotePanelMt = (dsTabUserNotePanelMT) base.Clone();
    tabUserNotePanelMt.InitVars();
    tabUserNotePanelMt.SchemaSerializationMode = this.SchemaSerializationMode;
    return (DataSet) tabUserNotePanelMt;
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
      if (dataSet.Tables["tblNotesEntity"] != null)
        base.Tables.Add((DataTable) new dsTabUserNotePanelMT.tblNotesEntityDataTable(dataSet.Tables["tblNotesEntity"]));
      if (dataSet.Tables["tblNotesUnbound"] != null)
        base.Tables.Add((DataTable) new dsTabUserNotePanelMT.tblNotesUnboundDataTable(dataSet.Tables["tblNotesUnbound"]));
      if (dataSet.Tables["lstNoteTypes"] != null)
        base.Tables.Add((DataTable) new dsTabUserNotePanelMT.lstNoteTypesDataTable(dataSet.Tables["lstNoteTypes"]));
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
    this.tabletblNotesEntity = (dsTabUserNotePanelMT.tblNotesEntityDataTable) base.Tables["tblNotesEntity"];
    if (initTable && this.tabletblNotesEntity != null)
      this.tabletblNotesEntity.InitVars();
    this.tabletblNotesUnbound = (dsTabUserNotePanelMT.tblNotesUnboundDataTable) base.Tables["tblNotesUnbound"];
    if (initTable && this.tabletblNotesUnbound != null)
      this.tabletblNotesUnbound.InitVars();
    this.tablelstNoteTypes = (dsTabUserNotePanelMT.lstNoteTypesDataTable) base.Tables["lstNoteTypes"];
    if (!initTable || this.tablelstNoteTypes == null)
      return;
    this.tablelstNoteTypes.InitVars();
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private void InitClass()
  {
    this.DataSetName = nameof (dsTabUserNotePanelMT);
    this.Prefix = "";
    this.Namespace = "http://www.tempuri.org/dsTabUserNotePanelMT.xsd";
    this.EnforceConstraints = true;
    this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.tabletblNotesEntity = new dsTabUserNotePanelMT.tblNotesEntityDataTable();
    base.Tables.Add((DataTable) this.tabletblNotesEntity);
    this.tabletblNotesUnbound = new dsTabUserNotePanelMT.tblNotesUnboundDataTable();
    base.Tables.Add((DataTable) this.tabletblNotesUnbound);
    this.tablelstNoteTypes = new dsTabUserNotePanelMT.lstNoteTypesDataTable();
    base.Tables.Add((DataTable) this.tablelstNoteTypes);
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializetblNotesEntity() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializetblNotesUnbound() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializelstNoteTypes() => false;

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
    dsTabUserNotePanelMT tabUserNotePanelMt = new dsTabUserNotePanelMT();
    XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
    schemaComplexType.Particle = (XmlSchemaParticle) new XmlSchemaSequence()
    {
      Items = {
        (XmlSchemaObject) new XmlSchemaAny()
        {
          Namespace = tabUserNotePanelMt.Namespace
        }
      }
    };
    XmlSchema schemaSerializable = tabUserNotePanelMt.GetSchemaSerializable();
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
  public delegate void tblNotesEntityRowChangeEventHandler(
    object sender,
    dsTabUserNotePanelMT.tblNotesEntityRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void tblNotesUnboundRowChangeEventHandler(
    object sender,
    dsTabUserNotePanelMT.tblNotesUnboundRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void lstNoteTypesRowChangeEventHandler(
    object sender,
    dsTabUserNotePanelMT.lstNoteTypesRowChangeEvent e);

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class tblNotesEntityDataTable : TypedTableBase<dsTabUserNotePanelMT.tblNotesEntityRow>
  {
    private DataColumn columnNoteGUID;
    private DataColumn columnNoteTypeID;
    private DataColumn columnUserGUIDNoteOriginator;
    private DataColumn columnDateEntered;
    private DataColumn columnDeadlineDate;
    private DataColumn columnDateDue;
    private DataColumn columnContent;
    private DataColumn columnInternal;
    private DataColumn columnParentNoteGUID;
    private DataColumn columnSubject;
    private DataColumn columnDepth;
    private DataColumn columnActive;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblNotesEntityDataTable()
    {
      this.TableName = "tblNotesEntity";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblNotesEntityDataTable(DataTable table)
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
    protected tblNotesEntityDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn NoteGUIDColumn => this.columnNoteGUID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn NoteTypeIDColumn => this.columnNoteTypeID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn UserGUIDNoteOriginatorColumn => this.columnUserGUIDNoteOriginator;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn DateEnteredColumn => this.columnDateEntered;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn DeadlineDateColumn => this.columnDeadlineDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn DateDueColumn => this.columnDateDue;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ContentColumn => this.columnContent;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn InternalColumn => this.columnInternal;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ParentNoteGUIDColumn => this.columnParentNoteGUID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn SubjectColumn => this.columnSubject;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn DepthColumn => this.columnDepth;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ActiveColumn => this.columnActive;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsTabUserNotePanelMT.tblNotesEntityRow this[int index]
    {
      get => (dsTabUserNotePanelMT.tblNotesEntityRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsTabUserNotePanelMT.tblNotesEntityRowChangeEventHandler tblNotesEntityRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsTabUserNotePanelMT.tblNotesEntityRowChangeEventHandler tblNotesEntityRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsTabUserNotePanelMT.tblNotesEntityRowChangeEventHandler tblNotesEntityRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsTabUserNotePanelMT.tblNotesEntityRowChangeEventHandler tblNotesEntityRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddtblNotesEntityRow(dsTabUserNotePanelMT.tblNotesEntityRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsTabUserNotePanelMT.tblNotesEntityRow AddtblNotesEntityRow(
      Guid NoteGUID,
      int NoteTypeID,
      Guid UserGUIDNoteOriginator,
      DateTime DateEntered,
      DateTime DeadlineDate,
      DateTime DateDue,
      string Content,
      bool Internal,
      Guid ParentNoteGUID,
      string Subject,
      int Depth,
      int Active)
    {
      dsTabUserNotePanelMT.tblNotesEntityRow row = (dsTabUserNotePanelMT.tblNotesEntityRow) this.NewRow();
      object[] objArray = new object[12]
      {
        (object) NoteGUID,
        (object) NoteTypeID,
        (object) UserGUIDNoteOriginator,
        (object) DateEntered,
        (object) DeadlineDate,
        (object) DateDue,
        (object) Content,
        (object) Internal,
        (object) ParentNoteGUID,
        (object) Subject,
        (object) Depth,
        (object) Active
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsTabUserNotePanelMT.tblNotesEntityDataTable notesEntityDataTable = (dsTabUserNotePanelMT.tblNotesEntityDataTable) base.Clone();
      notesEntityDataTable.InitVars();
      return (DataTable) notesEntityDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsTabUserNotePanelMT.tblNotesEntityDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnNoteGUID = this.Columns["NoteGUID"];
      this.columnNoteTypeID = this.Columns["NoteTypeID"];
      this.columnUserGUIDNoteOriginator = this.Columns["UserGUIDNoteOriginator"];
      this.columnDateEntered = this.Columns["DateEntered"];
      this.columnDeadlineDate = this.Columns["DeadlineDate"];
      this.columnDateDue = this.Columns["DateDue"];
      this.columnContent = this.Columns["Content"];
      this.columnInternal = this.Columns["Internal"];
      this.columnParentNoteGUID = this.Columns["ParentNoteGUID"];
      this.columnSubject = this.Columns["Subject"];
      this.columnDepth = this.Columns["Depth"];
      this.columnActive = this.Columns["Active"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnNoteGUID = new DataColumn("NoteGUID", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnNoteGUID);
      this.columnNoteTypeID = new DataColumn("NoteTypeID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnNoteTypeID);
      this.columnUserGUIDNoteOriginator = new DataColumn("UserGUIDNoteOriginator", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnUserGUIDNoteOriginator);
      this.columnDateEntered = new DataColumn("DateEntered", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDateEntered);
      this.columnDeadlineDate = new DataColumn("DeadlineDate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDeadlineDate);
      this.columnDateDue = new DataColumn("DateDue", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDateDue);
      this.columnContent = new DataColumn("Content", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnContent);
      this.columnInternal = new DataColumn("Internal", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInternal);
      this.columnParentNoteGUID = new DataColumn("ParentNoteGUID", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnParentNoteGUID);
      this.columnSubject = new DataColumn("Subject", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSubject);
      this.columnDepth = new DataColumn("Depth", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDepth);
      this.columnActive = new DataColumn("Active", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnActive);
      this.columnNoteGUID.AllowDBNull = false;
      this.columnDateEntered.AllowDBNull = false;
      this.columnContent.AllowDBNull = false;
      this.columnInternal.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsTabUserNotePanelMT.tblNotesEntityRow NewtblNotesEntityRow()
    {
      return (dsTabUserNotePanelMT.tblNotesEntityRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsTabUserNotePanelMT.tblNotesEntityRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (dsTabUserNotePanelMT.tblNotesEntityRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblNotesEntityRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsTabUserNotePanelMT.tblNotesEntityRowChangeEventHandler entityRowChangedEvent = this.tblNotesEntityRowChangedEvent;
      if (entityRowChangedEvent == null)
        return;
      entityRowChangedEvent((object) this, new dsTabUserNotePanelMT.tblNotesEntityRowChangeEvent((dsTabUserNotePanelMT.tblNotesEntityRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblNotesEntityRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsTabUserNotePanelMT.tblNotesEntityRowChangeEventHandler rowChangingEvent = this.tblNotesEntityRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsTabUserNotePanelMT.tblNotesEntityRowChangeEvent((dsTabUserNotePanelMT.tblNotesEntityRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblNotesEntityRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsTabUserNotePanelMT.tblNotesEntityRowChangeEventHandler entityRowDeletedEvent = this.tblNotesEntityRowDeletedEvent;
      if (entityRowDeletedEvent == null)
        return;
      entityRowDeletedEvent((object) this, new dsTabUserNotePanelMT.tblNotesEntityRowChangeEvent((dsTabUserNotePanelMT.tblNotesEntityRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblNotesEntityRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsTabUserNotePanelMT.tblNotesEntityRowChangeEventHandler rowDeletingEvent = this.tblNotesEntityRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsTabUserNotePanelMT.tblNotesEntityRowChangeEvent((dsTabUserNotePanelMT.tblNotesEntityRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemovetblNotesEntityRow(dsTabUserNotePanelMT.tblNotesEntityRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsTabUserNotePanelMT tabUserNotePanelMt = new dsTabUserNotePanelMT();
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
        FixedValue = tabUserNotePanelMt.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblNotesEntityDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = tabUserNotePanelMt.GetSchemaSerializable();
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
  public class tblNotesUnboundDataTable : TypedTableBase<dsTabUserNotePanelMT.tblNotesUnboundRow>
  {
    private DataColumn columnNoteGUID;
    private DataColumn columnNoteTypeID;
    private DataColumn columnUserGUIDNoteOriginator;
    private DataColumn columnDateEntered;
    private DataColumn columnDeadlineDate;
    private DataColumn columnDateDue;
    private DataColumn columnContent;
    private DataColumn columnInternal;
    private DataColumn columnParentNoteGUID;
    private DataColumn columnSubject;
    private DataColumn columnDepth;
    private DataColumn columnActive;

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
    public DataColumn NoteGUIDColumn => this.columnNoteGUID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn NoteTypeIDColumn => this.columnNoteTypeID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn UserGUIDNoteOriginatorColumn => this.columnUserGUIDNoteOriginator;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn DateEnteredColumn => this.columnDateEntered;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn DeadlineDateColumn => this.columnDeadlineDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn DateDueColumn => this.columnDateDue;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ContentColumn => this.columnContent;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn InternalColumn => this.columnInternal;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ParentNoteGUIDColumn => this.columnParentNoteGUID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn SubjectColumn => this.columnSubject;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn DepthColumn => this.columnDepth;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ActiveColumn => this.columnActive;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsTabUserNotePanelMT.tblNotesUnboundRow this[int index]
    {
      get => (dsTabUserNotePanelMT.tblNotesUnboundRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsTabUserNotePanelMT.tblNotesUnboundRowChangeEventHandler tblNotesUnboundRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsTabUserNotePanelMT.tblNotesUnboundRowChangeEventHandler tblNotesUnboundRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsTabUserNotePanelMT.tblNotesUnboundRowChangeEventHandler tblNotesUnboundRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsTabUserNotePanelMT.tblNotesUnboundRowChangeEventHandler tblNotesUnboundRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddtblNotesUnboundRow(dsTabUserNotePanelMT.tblNotesUnboundRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsTabUserNotePanelMT.tblNotesUnboundRow AddtblNotesUnboundRow(
      Guid NoteGUID,
      int NoteTypeID,
      Guid UserGUIDNoteOriginator,
      DateTime DateEntered,
      DateTime DeadlineDate,
      DateTime DateDue,
      string Content,
      bool Internal,
      Guid ParentNoteGUID,
      string Subject,
      int Depth,
      int Active)
    {
      dsTabUserNotePanelMT.tblNotesUnboundRow row = (dsTabUserNotePanelMT.tblNotesUnboundRow) this.NewRow();
      object[] objArray = new object[12]
      {
        (object) NoteGUID,
        (object) NoteTypeID,
        (object) UserGUIDNoteOriginator,
        (object) DateEntered,
        (object) DeadlineDate,
        (object) DateDue,
        (object) Content,
        (object) Internal,
        (object) ParentNoteGUID,
        (object) Subject,
        (object) Depth,
        (object) Active
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsTabUserNotePanelMT.tblNotesUnboundRow FindByNoteGUID(Guid NoteGUID)
    {
      return (dsTabUserNotePanelMT.tblNotesUnboundRow) this.Rows.Find(new object[1]
      {
        (object) NoteGUID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsTabUserNotePanelMT.tblNotesUnboundDataTable unboundDataTable = (dsTabUserNotePanelMT.tblNotesUnboundDataTable) base.Clone();
      unboundDataTable.InitVars();
      return (DataTable) unboundDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsTabUserNotePanelMT.tblNotesUnboundDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnNoteGUID = this.Columns["NoteGUID"];
      this.columnNoteTypeID = this.Columns["NoteTypeID"];
      this.columnUserGUIDNoteOriginator = this.Columns["UserGUIDNoteOriginator"];
      this.columnDateEntered = this.Columns["DateEntered"];
      this.columnDeadlineDate = this.Columns["DeadlineDate"];
      this.columnDateDue = this.Columns["DateDue"];
      this.columnContent = this.Columns["Content"];
      this.columnInternal = this.Columns["Internal"];
      this.columnParentNoteGUID = this.Columns["ParentNoteGUID"];
      this.columnSubject = this.Columns["Subject"];
      this.columnDepth = this.Columns["Depth"];
      this.columnActive = this.Columns["Active"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnNoteGUID = new DataColumn("NoteGUID", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnNoteGUID);
      this.columnNoteTypeID = new DataColumn("NoteTypeID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnNoteTypeID);
      this.columnUserGUIDNoteOriginator = new DataColumn("UserGUIDNoteOriginator", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnUserGUIDNoteOriginator);
      this.columnDateEntered = new DataColumn("DateEntered", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDateEntered);
      this.columnDeadlineDate = new DataColumn("DeadlineDate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDeadlineDate);
      this.columnDateDue = new DataColumn("DateDue", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDateDue);
      this.columnContent = new DataColumn("Content", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnContent);
      this.columnInternal = new DataColumn("Internal", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInternal);
      this.columnParentNoteGUID = new DataColumn("ParentNoteGUID", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnParentNoteGUID);
      this.columnSubject = new DataColumn("Subject", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSubject);
      this.columnDepth = new DataColumn("Depth", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDepth);
      this.columnActive = new DataColumn("Active", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnActive);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnNoteGUID
      }, true));
      this.columnNoteGUID.AllowDBNull = false;
      this.columnNoteGUID.Unique = true;
      this.columnDateEntered.AllowDBNull = false;
      this.columnContent.AllowDBNull = false;
      this.columnInternal.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsTabUserNotePanelMT.tblNotesUnboundRow NewtblNotesUnboundRow()
    {
      return (dsTabUserNotePanelMT.tblNotesUnboundRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsTabUserNotePanelMT.tblNotesUnboundRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (dsTabUserNotePanelMT.tblNotesUnboundRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblNotesUnboundRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsTabUserNotePanelMT.tblNotesUnboundRowChangeEventHandler unboundRowChangedEvent = this.tblNotesUnboundRowChangedEvent;
      if (unboundRowChangedEvent == null)
        return;
      unboundRowChangedEvent((object) this, new dsTabUserNotePanelMT.tblNotesUnboundRowChangeEvent((dsTabUserNotePanelMT.tblNotesUnboundRow) e.Row, e.Action));
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
      dsTabUserNotePanelMT.tblNotesUnboundRowChangeEventHandler rowChangingEvent = this.tblNotesUnboundRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsTabUserNotePanelMT.tblNotesUnboundRowChangeEvent((dsTabUserNotePanelMT.tblNotesUnboundRow) e.Row, e.Action));
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
      dsTabUserNotePanelMT.tblNotesUnboundRowChangeEventHandler unboundRowDeletedEvent = this.tblNotesUnboundRowDeletedEvent;
      if (unboundRowDeletedEvent == null)
        return;
      unboundRowDeletedEvent((object) this, new dsTabUserNotePanelMT.tblNotesUnboundRowChangeEvent((dsTabUserNotePanelMT.tblNotesUnboundRow) e.Row, e.Action));
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
      dsTabUserNotePanelMT.tblNotesUnboundRowChangeEventHandler rowDeletingEvent = this.tblNotesUnboundRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsTabUserNotePanelMT.tblNotesUnboundRowChangeEvent((dsTabUserNotePanelMT.tblNotesUnboundRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemovetblNotesUnboundRow(dsTabUserNotePanelMT.tblNotesUnboundRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsTabUserNotePanelMT tabUserNotePanelMt = new dsTabUserNotePanelMT();
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
        FixedValue = tabUserNotePanelMt.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblNotesUnboundDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = tabUserNotePanelMt.GetSchemaSerializable();
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
  public class lstNoteTypesDataTable : TypedTableBase<dsTabUserNotePanelMT.lstNoteTypesRow>
  {
    private DataColumn columnNoteTypeID;
    private DataColumn columnDescription;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public lstNoteTypesDataTable()
    {
      this.TableName = "lstNoteTypes";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected lstNoteTypesDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn NoteTypeIDColumn => this.columnNoteTypeID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn DescriptionColumn => this.columnDescription;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsTabUserNotePanelMT.lstNoteTypesRow this[int index]
    {
      get => (dsTabUserNotePanelMT.lstNoteTypesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsTabUserNotePanelMT.lstNoteTypesRowChangeEventHandler lstNoteTypesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsTabUserNotePanelMT.lstNoteTypesRowChangeEventHandler lstNoteTypesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsTabUserNotePanelMT.lstNoteTypesRowChangeEventHandler lstNoteTypesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsTabUserNotePanelMT.lstNoteTypesRowChangeEventHandler lstNoteTypesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddlstNoteTypesRow(dsTabUserNotePanelMT.lstNoteTypesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsTabUserNotePanelMT.lstNoteTypesRow AddlstNoteTypesRow(string Description)
    {
      dsTabUserNotePanelMT.lstNoteTypesRow row = (dsTabUserNotePanelMT.lstNoteTypesRow) this.NewRow();
      object[] objArray = new object[2]
      {
        null,
        (object) Description
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsTabUserNotePanelMT.lstNoteTypesRow FindByNoteTypeID(int NoteTypeID)
    {
      return (dsTabUserNotePanelMT.lstNoteTypesRow) this.Rows.Find(new object[1]
      {
        (object) NoteTypeID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsTabUserNotePanelMT.lstNoteTypesDataTable noteTypesDataTable = (dsTabUserNotePanelMT.lstNoteTypesDataTable) base.Clone();
      noteTypesDataTable.InitVars();
      return (DataTable) noteTypesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsTabUserNotePanelMT.lstNoteTypesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnNoteTypeID = this.Columns["NoteTypeID"];
      this.columnDescription = this.Columns["Description"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnNoteTypeID = new DataColumn("NoteTypeID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnNoteTypeID);
      this.columnDescription = new DataColumn("Description", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDescription);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnNoteTypeID
      }, true));
      this.columnNoteTypeID.AutoIncrement = true;
      this.columnNoteTypeID.AllowDBNull = false;
      this.columnNoteTypeID.ReadOnly = true;
      this.columnNoteTypeID.Unique = true;
      this.columnDescription.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsTabUserNotePanelMT.lstNoteTypesRow NewlstNoteTypesRow()
    {
      return (dsTabUserNotePanelMT.lstNoteTypesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsTabUserNotePanelMT.lstNoteTypesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (dsTabUserNotePanelMT.lstNoteTypesRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstNoteTypesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsTabUserNotePanelMT.lstNoteTypesRowChangeEventHandler typesRowChangedEvent = this.lstNoteTypesRowChangedEvent;
      if (typesRowChangedEvent == null)
        return;
      typesRowChangedEvent((object) this, new dsTabUserNotePanelMT.lstNoteTypesRowChangeEvent((dsTabUserNotePanelMT.lstNoteTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstNoteTypesRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsTabUserNotePanelMT.lstNoteTypesRowChangeEventHandler rowChangingEvent = this.lstNoteTypesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsTabUserNotePanelMT.lstNoteTypesRowChangeEvent((dsTabUserNotePanelMT.lstNoteTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstNoteTypesRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsTabUserNotePanelMT.lstNoteTypesRowChangeEventHandler typesRowDeletedEvent = this.lstNoteTypesRowDeletedEvent;
      if (typesRowDeletedEvent == null)
        return;
      typesRowDeletedEvent((object) this, new dsTabUserNotePanelMT.lstNoteTypesRowChangeEvent((dsTabUserNotePanelMT.lstNoteTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstNoteTypesRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsTabUserNotePanelMT.lstNoteTypesRowChangeEventHandler rowDeletingEvent = this.lstNoteTypesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsTabUserNotePanelMT.lstNoteTypesRowChangeEvent((dsTabUserNotePanelMT.lstNoteTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemovelstNoteTypesRow(dsTabUserNotePanelMT.lstNoteTypesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsTabUserNotePanelMT tabUserNotePanelMt = new dsTabUserNotePanelMT();
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
        FixedValue = tabUserNotePanelMt.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (lstNoteTypesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = tabUserNotePanelMt.GetSchemaSerializable();
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

  public class tblNotesEntityRow : DataRow
  {
    private dsTabUserNotePanelMT.tblNotesEntityDataTable tabletblNotesEntity;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblNotesEntityRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblNotesEntity = (dsTabUserNotePanelMT.tblNotesEntityDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Guid NoteGUID
    {
      get
      {
        object obj = this[this.tabletblNotesEntity.NoteGUIDColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tabletblNotesEntity.NoteGUIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int NoteTypeID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblNotesEntity.NoteTypeIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'NoteTypeID' in table 'tblNotesEntity' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblNotesEntity.NoteTypeIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Guid UserGUIDNoteOriginator
    {
      get
      {
        try
        {
          object obj = this[this.tabletblNotesEntity.UserGUIDNoteOriginatorColumn];
          return obj != null ? (Guid) obj : new Guid();
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'UserGUIDNoteOriginator' in table 'tblNotesEntity' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblNotesEntity.UserGUIDNoteOriginatorColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DateTime DateEntered
    {
      get => Conversions.ToDate(this[this.tabletblNotesEntity.DateEnteredColumn]);
      set => this[this.tabletblNotesEntity.DateEnteredColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DateTime DeadlineDate
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tabletblNotesEntity.DeadlineDateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DeadlineDate' in table 'tblNotesEntity' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblNotesEntity.DeadlineDateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DateTime DateDue
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tabletblNotesEntity.DateDueColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DateDue' in table 'tblNotesEntity' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblNotesEntity.DateDueColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Content
    {
      get => Conversions.ToString(this[this.tabletblNotesEntity.ContentColumn]);
      set => this[this.tabletblNotesEntity.ContentColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool Internal
    {
      get => Conversions.ToBoolean(this[this.tabletblNotesEntity.InternalColumn]);
      set => this[this.tabletblNotesEntity.InternalColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Guid ParentNoteGUID
    {
      get
      {
        try
        {
          object obj = this[this.tabletblNotesEntity.ParentNoteGUIDColumn];
          return obj != null ? (Guid) obj : new Guid();
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ParentNoteGUID' in table 'tblNotesEntity' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblNotesEntity.ParentNoteGUIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Subject
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblNotesEntity.SubjectColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Subject' in table 'tblNotesEntity' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblNotesEntity.SubjectColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int Depth
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblNotesEntity.DepthColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Depth' in table 'tblNotesEntity' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblNotesEntity.DepthColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int Active
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblNotesEntity.ActiveColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Active' in table 'tblNotesEntity' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblNotesEntity.ActiveColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsNoteTypeIDNull() => this.IsNull(this.tabletblNotesEntity.NoteTypeIDColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetNoteTypeIDNull()
    {
      this[this.tabletblNotesEntity.NoteTypeIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsUserGUIDNoteOriginatorNull()
    {
      return this.IsNull(this.tabletblNotesEntity.UserGUIDNoteOriginatorColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetUserGUIDNoteOriginatorNull()
    {
      this[this.tabletblNotesEntity.UserGUIDNoteOriginatorColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsDeadlineDateNull() => this.IsNull(this.tabletblNotesEntity.DeadlineDateColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetDeadlineDateNull()
    {
      this[this.tabletblNotesEntity.DeadlineDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsDateDueNull() => this.IsNull(this.tabletblNotesEntity.DateDueColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetDateDueNull()
    {
      this[this.tabletblNotesEntity.DateDueColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsParentNoteGUIDNull()
    {
      return this.IsNull(this.tabletblNotesEntity.ParentNoteGUIDColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetParentNoteGUIDNull()
    {
      this[this.tabletblNotesEntity.ParentNoteGUIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsSubjectNull() => this.IsNull(this.tabletblNotesEntity.SubjectColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetSubjectNull()
    {
      this[this.tabletblNotesEntity.SubjectColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsDepthNull() => this.IsNull(this.tabletblNotesEntity.DepthColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetDepthNull()
    {
      this[this.tabletblNotesEntity.DepthColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsActiveNull() => this.IsNull(this.tabletblNotesEntity.ActiveColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetActiveNull()
    {
      this[this.tabletblNotesEntity.ActiveColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class tblNotesUnboundRow : DataRow
  {
    private dsTabUserNotePanelMT.tblNotesUnboundDataTable tabletblNotesUnbound;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblNotesUnboundRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblNotesUnbound = (dsTabUserNotePanelMT.tblNotesUnboundDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Guid NoteGUID
    {
      get
      {
        object obj = this[this.tabletblNotesUnbound.NoteGUIDColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tabletblNotesUnbound.NoteGUIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int NoteTypeID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblNotesUnbound.NoteTypeIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'NoteTypeID' in table 'tblNotesUnbound' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblNotesUnbound.NoteTypeIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Guid UserGUIDNoteOriginator
    {
      get
      {
        try
        {
          object obj = this[this.tabletblNotesUnbound.UserGUIDNoteOriginatorColumn];
          return obj != null ? (Guid) obj : new Guid();
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'UserGUIDNoteOriginator' in table 'tblNotesUnbound' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblNotesUnbound.UserGUIDNoteOriginatorColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DateTime DateEntered
    {
      get => Conversions.ToDate(this[this.tabletblNotesUnbound.DateEnteredColumn]);
      set => this[this.tabletblNotesUnbound.DateEnteredColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DateTime DeadlineDate
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tabletblNotesUnbound.DeadlineDateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DeadlineDate' in table 'tblNotesUnbound' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblNotesUnbound.DeadlineDateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DateTime DateDue
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tabletblNotesUnbound.DateDueColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DateDue' in table 'tblNotesUnbound' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblNotesUnbound.DateDueColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Content
    {
      get => Conversions.ToString(this[this.tabletblNotesUnbound.ContentColumn]);
      set => this[this.tabletblNotesUnbound.ContentColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool Internal
    {
      get => Conversions.ToBoolean(this[this.tabletblNotesUnbound.InternalColumn]);
      set => this[this.tabletblNotesUnbound.InternalColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Guid ParentNoteGUID
    {
      get
      {
        try
        {
          object obj = this[this.tabletblNotesUnbound.ParentNoteGUIDColumn];
          return obj != null ? (Guid) obj : new Guid();
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ParentNoteGUID' in table 'tblNotesUnbound' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblNotesUnbound.ParentNoteGUIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Subject
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblNotesUnbound.SubjectColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Subject' in table 'tblNotesUnbound' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblNotesUnbound.SubjectColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int Depth
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblNotesUnbound.DepthColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Depth' in table 'tblNotesUnbound' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblNotesUnbound.DepthColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int Active
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblNotesUnbound.ActiveColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Active' in table 'tblNotesUnbound' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblNotesUnbound.ActiveColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsNoteTypeIDNull() => this.IsNull(this.tabletblNotesUnbound.NoteTypeIDColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetNoteTypeIDNull()
    {
      this[this.tabletblNotesUnbound.NoteTypeIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsUserGUIDNoteOriginatorNull()
    {
      return this.IsNull(this.tabletblNotesUnbound.UserGUIDNoteOriginatorColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetUserGUIDNoteOriginatorNull()
    {
      this[this.tabletblNotesUnbound.UserGUIDNoteOriginatorColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsDeadlineDateNull() => this.IsNull(this.tabletblNotesUnbound.DeadlineDateColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetDeadlineDateNull()
    {
      this[this.tabletblNotesUnbound.DeadlineDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsDateDueNull() => this.IsNull(this.tabletblNotesUnbound.DateDueColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetDateDueNull()
    {
      this[this.tabletblNotesUnbound.DateDueColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsParentNoteGUIDNull()
    {
      return this.IsNull(this.tabletblNotesUnbound.ParentNoteGUIDColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetParentNoteGUIDNull()
    {
      this[this.tabletblNotesUnbound.ParentNoteGUIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsSubjectNull() => this.IsNull(this.tabletblNotesUnbound.SubjectColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetSubjectNull()
    {
      this[this.tabletblNotesUnbound.SubjectColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsDepthNull() => this.IsNull(this.tabletblNotesUnbound.DepthColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetDepthNull()
    {
      this[this.tabletblNotesUnbound.DepthColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsActiveNull() => this.IsNull(this.tabletblNotesUnbound.ActiveColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetActiveNull()
    {
      this[this.tabletblNotesUnbound.ActiveColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class lstNoteTypesRow : DataRow
  {
    private dsTabUserNotePanelMT.lstNoteTypesDataTable tablelstNoteTypes;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal lstNoteTypesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablelstNoteTypes = (dsTabUserNotePanelMT.lstNoteTypesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int NoteTypeID
    {
      get => Conversions.ToInteger(this[this.tablelstNoteTypes.NoteTypeIDColumn]);
      set => this[this.tablelstNoteTypes.NoteTypeIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Description
    {
      get => Conversions.ToString(this[this.tablelstNoteTypes.DescriptionColumn]);
      set => this[this.tablelstNoteTypes.DescriptionColumn] = (object) value;
    }
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class tblNotesEntityRowChangeEvent : EventArgs
  {
    private dsTabUserNotePanelMT.tblNotesEntityRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblNotesEntityRowChangeEvent(
      dsTabUserNotePanelMT.tblNotesEntityRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsTabUserNotePanelMT.tblNotesEntityRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class tblNotesUnboundRowChangeEvent : EventArgs
  {
    private dsTabUserNotePanelMT.tblNotesUnboundRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblNotesUnboundRowChangeEvent(
      dsTabUserNotePanelMT.tblNotesUnboundRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsTabUserNotePanelMT.tblNotesUnboundRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class lstNoteTypesRowChangeEvent : EventArgs
  {
    private dsTabUserNotePanelMT.lstNoteTypesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public lstNoteTypesRowChangeEvent(
      dsTabUserNotePanelMT.lstNoteTypesRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsTabUserNotePanelMT.lstNoteTypesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }
}
