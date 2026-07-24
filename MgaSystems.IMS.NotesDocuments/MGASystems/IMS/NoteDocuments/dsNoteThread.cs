// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.NoteDocuments.dsNoteThread
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
[XmlRoot("dsNoteThread")]
[HelpKeyword("vs.data.DataSet")]
[Serializable]
public class dsNoteThread : DataSet
{
  private dsNoteThread.tblGetNoteThreadDataTable tabletblGetNoteThread;
  private SchemaSerializationMode _schemaSerializationMode;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public dsNoteThread()
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
  protected dsNoteThread(SerializationInfo info, StreamingContext context)
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
        if (dataSet.Tables[nameof (tblGetNoteThread)] != null)
          base.Tables.Add((DataTable) new dsNoteThread.tblGetNoteThreadDataTable(dataSet.Tables[nameof (tblGetNoteThread)]));
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
  public dsNoteThread.tblGetNoteThreadDataTable tblGetNoteThread => this.tabletblGetNoteThread;

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
    dsNoteThread dsNoteThread = (dsNoteThread) base.Clone();
    dsNoteThread.InitVars();
    dsNoteThread.SchemaSerializationMode = this.SchemaSerializationMode;
    return (DataSet) dsNoteThread;
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
      if (dataSet.Tables["tblGetNoteThread"] != null)
        base.Tables.Add((DataTable) new dsNoteThread.tblGetNoteThreadDataTable(dataSet.Tables["tblGetNoteThread"]));
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
    this.tabletblGetNoteThread = (dsNoteThread.tblGetNoteThreadDataTable) base.Tables["tblGetNoteThread"];
    if (!initTable || this.tabletblGetNoteThread == null)
      return;
    this.tabletblGetNoteThread.InitVars();
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private void InitClass()
  {
    this.DataSetName = nameof (dsNoteThread);
    this.Prefix = "";
    this.Namespace = "http://www.tempuri.org/dsNoteThread.xsd";
    this.EnforceConstraints = true;
    this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.tabletblGetNoteThread = new dsNoteThread.tblGetNoteThreadDataTable();
    base.Tables.Add((DataTable) this.tabletblGetNoteThread);
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializetblGetNoteThread() => false;

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
    dsNoteThread dsNoteThread = new dsNoteThread();
    XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
    schemaComplexType.Particle = (XmlSchemaParticle) new XmlSchemaSequence()
    {
      Items = {
        (XmlSchemaObject) new XmlSchemaAny()
        {
          Namespace = dsNoteThread.Namespace
        }
      }
    };
    XmlSchema schemaSerializable = dsNoteThread.GetSchemaSerializable();
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
  public delegate void tblGetNoteThreadRowChangeEventHandler(
    object sender,
    dsNoteThread.tblGetNoteThreadRowChangeEvent e);

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class tblGetNoteThreadDataTable : TypedTableBase<dsNoteThread.tblGetNoteThreadRow>
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

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblGetNoteThreadDataTable()
    {
      this.TableName = "tblGetNoteThread";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblGetNoteThreadDataTable(DataTable table)
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
    protected tblGetNoteThreadDataTable(SerializationInfo info, StreamingContext context)
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
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsNoteThread.tblGetNoteThreadRow this[int index]
    {
      get => (dsNoteThread.tblGetNoteThreadRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsNoteThread.tblGetNoteThreadRowChangeEventHandler tblGetNoteThreadRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsNoteThread.tblGetNoteThreadRowChangeEventHandler tblGetNoteThreadRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsNoteThread.tblGetNoteThreadRowChangeEventHandler tblGetNoteThreadRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsNoteThread.tblGetNoteThreadRowChangeEventHandler tblGetNoteThreadRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddtblGetNoteThreadRow(dsNoteThread.tblGetNoteThreadRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsNoteThread.tblGetNoteThreadRow AddtblGetNoteThreadRow(
      Guid NoteGUID,
      Decimal NoteTypeID,
      Guid UserGUIDNoteOriginator,
      DateTime DateEntered,
      DateTime DeadlineDate,
      DateTime DateDue,
      string Content,
      bool Internal,
      Guid ParentNoteGUID,
      string Subject)
    {
      dsNoteThread.tblGetNoteThreadRow row = (dsNoteThread.tblGetNoteThreadRow) this.NewRow();
      object[] objArray = new object[10]
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
      dsNoteThread.tblGetNoteThreadDataTable noteThreadDataTable = (dsNoteThread.tblGetNoteThreadDataTable) base.Clone();
      noteThreadDataTable.InitVars();
      return (DataTable) noteThreadDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsNoteThread.tblGetNoteThreadDataTable();
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
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnNoteGUID = new DataColumn("NoteGUID", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnNoteGUID);
      this.columnNoteTypeID = new DataColumn("NoteTypeID", typeof (Decimal), (string) null, MappingType.Element);
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
      this.columnNoteGUID.AllowDBNull = false;
      this.columnUserGUIDNoteOriginator.AllowDBNull = false;
      this.columnDateEntered.AllowDBNull = false;
      this.columnContent.ReadOnly = true;
      this.columnInternal.AllowDBNull = false;
      this.columnSubject.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsNoteThread.tblGetNoteThreadRow NewtblGetNoteThreadRow()
    {
      return (dsNoteThread.tblGetNoteThreadRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsNoteThread.tblGetNoteThreadRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (dsNoteThread.tblGetNoteThreadRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblGetNoteThreadRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsNoteThread.tblGetNoteThreadRowChangeEventHandler threadRowChangedEvent = this.tblGetNoteThreadRowChangedEvent;
      if (threadRowChangedEvent == null)
        return;
      threadRowChangedEvent((object) this, new dsNoteThread.tblGetNoteThreadRowChangeEvent((dsNoteThread.tblGetNoteThreadRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblGetNoteThreadRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsNoteThread.tblGetNoteThreadRowChangeEventHandler rowChangingEvent = this.tblGetNoteThreadRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsNoteThread.tblGetNoteThreadRowChangeEvent((dsNoteThread.tblGetNoteThreadRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblGetNoteThreadRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsNoteThread.tblGetNoteThreadRowChangeEventHandler threadRowDeletedEvent = this.tblGetNoteThreadRowDeletedEvent;
      if (threadRowDeletedEvent == null)
        return;
      threadRowDeletedEvent((object) this, new dsNoteThread.tblGetNoteThreadRowChangeEvent((dsNoteThread.tblGetNoteThreadRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblGetNoteThreadRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsNoteThread.tblGetNoteThreadRowChangeEventHandler rowDeletingEvent = this.tblGetNoteThreadRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsNoteThread.tblGetNoteThreadRowChangeEvent((dsNoteThread.tblGetNoteThreadRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemovetblGetNoteThreadRow(dsNoteThread.tblGetNoteThreadRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsNoteThread dsNoteThread = new dsNoteThread();
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
        FixedValue = dsNoteThread.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblGetNoteThreadDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsNoteThread.GetSchemaSerializable();
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

  public class tblGetNoteThreadRow : DataRow
  {
    private dsNoteThread.tblGetNoteThreadDataTable tabletblGetNoteThread;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblGetNoteThreadRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblGetNoteThread = (dsNoteThread.tblGetNoteThreadDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Guid NoteGUID
    {
      get
      {
        object obj = this[this.tabletblGetNoteThread.NoteGUIDColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tabletblGetNoteThread.NoteGUIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal NoteTypeID
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tabletblGetNoteThread.NoteTypeIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'NoteTypeID' in table 'tblGetNoteThread' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblGetNoteThread.NoteTypeIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Guid UserGUIDNoteOriginator
    {
      get
      {
        object obj = this[this.tabletblGetNoteThread.UserGUIDNoteOriginatorColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tabletblGetNoteThread.UserGUIDNoteOriginatorColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DateTime DateEntered
    {
      get => Conversions.ToDate(this[this.tabletblGetNoteThread.DateEnteredColumn]);
      set => this[this.tabletblGetNoteThread.DateEnteredColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DateTime DeadlineDate
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tabletblGetNoteThread.DeadlineDateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DeadlineDate' in table 'tblGetNoteThread' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblGetNoteThread.DeadlineDateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DateTime DateDue
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tabletblGetNoteThread.DateDueColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DateDue' in table 'tblGetNoteThread' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblGetNoteThread.DateDueColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Content
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblGetNoteThread.ContentColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Content' in table 'tblGetNoteThread' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblGetNoteThread.ContentColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool Internal
    {
      get => Conversions.ToBoolean(this[this.tabletblGetNoteThread.InternalColumn]);
      set => this[this.tabletblGetNoteThread.InternalColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Guid ParentNoteGUID
    {
      get
      {
        try
        {
          object obj = this[this.tabletblGetNoteThread.ParentNoteGUIDColumn];
          return obj != null ? (Guid) obj : new Guid();
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ParentNoteGUID' in table 'tblGetNoteThread' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblGetNoteThread.ParentNoteGUIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Subject
    {
      get => Conversions.ToString(this[this.tabletblGetNoteThread.SubjectColumn]);
      set => this[this.tabletblGetNoteThread.SubjectColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsNoteTypeIDNull() => this.IsNull(this.tabletblGetNoteThread.NoteTypeIDColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetNoteTypeIDNull()
    {
      this[this.tabletblGetNoteThread.NoteTypeIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsDeadlineDateNull() => this.IsNull(this.tabletblGetNoteThread.DeadlineDateColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetDeadlineDateNull()
    {
      this[this.tabletblGetNoteThread.DeadlineDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsDateDueNull() => this.IsNull(this.tabletblGetNoteThread.DateDueColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetDateDueNull()
    {
      this[this.tabletblGetNoteThread.DateDueColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsContentNull() => this.IsNull(this.tabletblGetNoteThread.ContentColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetContentNull()
    {
      this[this.tabletblGetNoteThread.ContentColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsParentNoteGUIDNull()
    {
      return this.IsNull(this.tabletblGetNoteThread.ParentNoteGUIDColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetParentNoteGUIDNull()
    {
      this[this.tabletblGetNoteThread.ParentNoteGUIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class tblGetNoteThreadRowChangeEvent : EventArgs
  {
    private dsNoteThread.tblGetNoteThreadRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblGetNoteThreadRowChangeEvent(
      dsNoteThread.tblGetNoteThreadRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsNoteThread.tblGetNoteThreadRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }
}
