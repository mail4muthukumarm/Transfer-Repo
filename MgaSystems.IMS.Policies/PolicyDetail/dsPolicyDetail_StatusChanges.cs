// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.PolicyDetail.dsPolicyDetail_StatusChanges
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
namespace MGASystems.IMS.Policies.PolicyDetail;

[DesignerCategory("code")]
[ToolboxItem(true)]
[XmlSchemaProvider("GetTypedDataSetSchema")]
[XmlRoot("dsPolicyDetail_StatusChanges")]
[HelpKeyword("vs.data.DataSet")]
[Serializable]
public class dsPolicyDetail_StatusChanges : DataSet
{
  private dsPolicyDetail_StatusChanges.tblQuoteStatusChangeLogDataTable tabletblQuoteStatusChangeLog;
  private SchemaSerializationMode _schemaSerializationMode;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public dsPolicyDetail_StatusChanges()
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
  protected dsPolicyDetail_StatusChanges(SerializationInfo info, StreamingContext context)
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
        if (dataSet.Tables[nameof (tblQuoteStatusChangeLog)] != null)
          base.Tables.Add((DataTable) new dsPolicyDetail_StatusChanges.tblQuoteStatusChangeLogDataTable(dataSet.Tables[nameof (tblQuoteStatusChangeLog)]));
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
  public dsPolicyDetail_StatusChanges.tblQuoteStatusChangeLogDataTable tblQuoteStatusChangeLog
  {
    get => this.tabletblQuoteStatusChangeLog;
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
    dsPolicyDetail_StatusChanges detailStatusChanges = (dsPolicyDetail_StatusChanges) base.Clone();
    detailStatusChanges.InitVars();
    detailStatusChanges.SchemaSerializationMode = this.SchemaSerializationMode;
    return (DataSet) detailStatusChanges;
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
      if (dataSet.Tables["tblQuoteStatusChangeLog"] != null)
        base.Tables.Add((DataTable) new dsPolicyDetail_StatusChanges.tblQuoteStatusChangeLogDataTable(dataSet.Tables["tblQuoteStatusChangeLog"]));
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
    this.tabletblQuoteStatusChangeLog = (dsPolicyDetail_StatusChanges.tblQuoteStatusChangeLogDataTable) base.Tables["tblQuoteStatusChangeLog"];
    if (!initTable || this.tabletblQuoteStatusChangeLog == null)
      return;
    this.tabletblQuoteStatusChangeLog.InitVars();
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private void InitClass()
  {
    this.DataSetName = nameof (dsPolicyDetail_StatusChanges);
    this.Prefix = "";
    this.Namespace = "http://tempuri.org/dsPolicyDetail_StatusChanges.xsd";
    this.EnforceConstraints = true;
    this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.tabletblQuoteStatusChangeLog = new dsPolicyDetail_StatusChanges.tblQuoteStatusChangeLogDataTable();
    base.Tables.Add((DataTable) this.tabletblQuoteStatusChangeLog);
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializetblQuoteStatusChangeLog() => false;

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
    dsPolicyDetail_StatusChanges detailStatusChanges = new dsPolicyDetail_StatusChanges();
    XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
    schemaComplexType.Particle = (XmlSchemaParticle) new XmlSchemaSequence()
    {
      Items = {
        (XmlSchemaObject) new XmlSchemaAny()
        {
          Namespace = detailStatusChanges.Namespace
        }
      }
    };
    XmlSchema schemaSerializable = detailStatusChanges.GetSchemaSerializable();
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
  public delegate void tblQuoteStatusChangeLogRowChangeEventHandler(
    object sender,
    dsPolicyDetail_StatusChanges.tblQuoteStatusChangeLogRowChangeEvent e);

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class tblQuoteStatusChangeLogDataTable : 
    TypedTableBase<dsPolicyDetail_StatusChanges.tblQuoteStatusChangeLogRow>
  {
    private DataColumn columnOriginal;
    private DataColumn columnNewDescription;
    private DataColumn columnReason;
    private DataColumn columnTimestamp;
    private DataColumn columnDisplay;
    private DataColumn columnComment;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public tblQuoteStatusChangeLogDataTable()
    {
      this.TableName = "tblQuoteStatusChangeLog";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal tblQuoteStatusChangeLogDataTable(DataTable table)
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
    protected tblQuoteStatusChangeLogDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn OriginalColumn => this.columnOriginal;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn NewDescriptionColumn => this.columnNewDescription;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ReasonColumn => this.columnReason;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn TimestampColumn => this.columnTimestamp;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn DisplayColumn => this.columnDisplay;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn CommentColumn => this.columnComment;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPolicyDetail_StatusChanges.tblQuoteStatusChangeLogRow this[int index]
    {
      get => (dsPolicyDetail_StatusChanges.tblQuoteStatusChangeLogRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsPolicyDetail_StatusChanges.tblQuoteStatusChangeLogRowChangeEventHandler tblQuoteStatusChangeLogRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsPolicyDetail_StatusChanges.tblQuoteStatusChangeLogRowChangeEventHandler tblQuoteStatusChangeLogRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsPolicyDetail_StatusChanges.tblQuoteStatusChangeLogRowChangeEventHandler tblQuoteStatusChangeLogRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsPolicyDetail_StatusChanges.tblQuoteStatusChangeLogRowChangeEventHandler tblQuoteStatusChangeLogRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AddtblQuoteStatusChangeLogRow(
      dsPolicyDetail_StatusChanges.tblQuoteStatusChangeLogRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPolicyDetail_StatusChanges.tblQuoteStatusChangeLogRow AddtblQuoteStatusChangeLogRow(
      string Original,
      string NewDescription,
      string Reason,
      DateTime Timestamp,
      string Display,
      string Comment)
    {
      dsPolicyDetail_StatusChanges.tblQuoteStatusChangeLogRow row = (dsPolicyDetail_StatusChanges.tblQuoteStatusChangeLogRow) this.NewRow();
      object[] objArray = new object[6]
      {
        (object) Original,
        (object) NewDescription,
        (object) Reason,
        (object) Timestamp,
        (object) Display,
        (object) Comment
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsPolicyDetail_StatusChanges.tblQuoteStatusChangeLogDataTable changeLogDataTable = (dsPolicyDetail_StatusChanges.tblQuoteStatusChangeLogDataTable) base.Clone();
      changeLogDataTable.InitVars();
      return (DataTable) changeLogDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsPolicyDetail_StatusChanges.tblQuoteStatusChangeLogDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal void InitVars()
    {
      this.columnOriginal = this.Columns["Original"];
      this.columnNewDescription = this.Columns["NewDescription"];
      this.columnReason = this.Columns["Reason"];
      this.columnTimestamp = this.Columns["Timestamp"];
      this.columnDisplay = this.Columns["Display"];
      this.columnComment = this.Columns["Comment"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.columnOriginal = new DataColumn("Original", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnOriginal);
      this.columnNewDescription = new DataColumn("NewDescription", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnNewDescription);
      this.columnReason = new DataColumn("Reason", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnReason);
      this.columnTimestamp = new DataColumn("Timestamp", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnTimestamp);
      this.columnDisplay = new DataColumn("Display", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDisplay);
      this.columnComment = new DataColumn("Comment", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnComment);
      this.columnOriginal.AllowDBNull = false;
      this.columnNewDescription.AllowDBNull = false;
      this.columnTimestamp.AllowDBNull = false;
      this.columnDisplay.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPolicyDetail_StatusChanges.tblQuoteStatusChangeLogRow NewtblQuoteStatusChangeLogRow()
    {
      return (dsPolicyDetail_StatusChanges.tblQuoteStatusChangeLogRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsPolicyDetail_StatusChanges.tblQuoteStatusChangeLogRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType()
    {
      return typeof (dsPolicyDetail_StatusChanges.tblQuoteStatusChangeLogRow);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblQuoteStatusChangeLogRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyDetail_StatusChanges.tblQuoteStatusChangeLogRowChangeEventHandler logRowChangedEvent = this.tblQuoteStatusChangeLogRowChangedEvent;
      if (logRowChangedEvent == null)
        return;
      logRowChangedEvent((object) this, new dsPolicyDetail_StatusChanges.tblQuoteStatusChangeLogRowChangeEvent((dsPolicyDetail_StatusChanges.tblQuoteStatusChangeLogRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblQuoteStatusChangeLogRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyDetail_StatusChanges.tblQuoteStatusChangeLogRowChangeEventHandler rowChangingEvent = this.tblQuoteStatusChangeLogRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsPolicyDetail_StatusChanges.tblQuoteStatusChangeLogRowChangeEvent((dsPolicyDetail_StatusChanges.tblQuoteStatusChangeLogRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblQuoteStatusChangeLogRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyDetail_StatusChanges.tblQuoteStatusChangeLogRowChangeEventHandler logRowDeletedEvent = this.tblQuoteStatusChangeLogRowDeletedEvent;
      if (logRowDeletedEvent == null)
        return;
      logRowDeletedEvent((object) this, new dsPolicyDetail_StatusChanges.tblQuoteStatusChangeLogRowChangeEvent((dsPolicyDetail_StatusChanges.tblQuoteStatusChangeLogRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblQuoteStatusChangeLogRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyDetail_StatusChanges.tblQuoteStatusChangeLogRowChangeEventHandler rowDeletingEvent = this.tblQuoteStatusChangeLogRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsPolicyDetail_StatusChanges.tblQuoteStatusChangeLogRowChangeEvent((dsPolicyDetail_StatusChanges.tblQuoteStatusChangeLogRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemovetblQuoteStatusChangeLogRow(
      dsPolicyDetail_StatusChanges.tblQuoteStatusChangeLogRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsPolicyDetail_StatusChanges detailStatusChanges = new dsPolicyDetail_StatusChanges();
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
        FixedValue = detailStatusChanges.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblQuoteStatusChangeLogDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = detailStatusChanges.GetSchemaSerializable();
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

  public class tblQuoteStatusChangeLogRow : DataRow
  {
    private dsPolicyDetail_StatusChanges.tblQuoteStatusChangeLogDataTable tabletblQuoteStatusChangeLog;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal tblQuoteStatusChangeLogRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblQuoteStatusChangeLog = (dsPolicyDetail_StatusChanges.tblQuoteStatusChangeLogDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string Original
    {
      get => Conversions.ToString(this[this.tabletblQuoteStatusChangeLog.OriginalColumn]);
      set => this[this.tabletblQuoteStatusChangeLog.OriginalColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string NewDescription
    {
      get => Conversions.ToString(this[this.tabletblQuoteStatusChangeLog.NewDescriptionColumn]);
      set => this[this.tabletblQuoteStatusChangeLog.NewDescriptionColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string Reason
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblQuoteStatusChangeLog.ReasonColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Reason' in table 'tblQuoteStatusChangeLog' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuoteStatusChangeLog.ReasonColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DateTime Timestamp
    {
      get => Conversions.ToDate(this[this.tabletblQuoteStatusChangeLog.TimestampColumn]);
      set => this[this.tabletblQuoteStatusChangeLog.TimestampColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string Display
    {
      get => Conversions.ToString(this[this.tabletblQuoteStatusChangeLog.DisplayColumn]);
      set => this[this.tabletblQuoteStatusChangeLog.DisplayColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string Comment
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblQuoteStatusChangeLog.CommentColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Comment' in table 'tblQuoteStatusChangeLog' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuoteStatusChangeLog.CommentColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsReasonNull() => this.IsNull(this.tabletblQuoteStatusChangeLog.ReasonColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetReasonNull()
    {
      this[this.tabletblQuoteStatusChangeLog.ReasonColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsCommentNull() => this.IsNull(this.tabletblQuoteStatusChangeLog.CommentColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetCommentNull()
    {
      this[this.tabletblQuoteStatusChangeLog.CommentColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class tblQuoteStatusChangeLogRowChangeEvent : EventArgs
  {
    private dsPolicyDetail_StatusChanges.tblQuoteStatusChangeLogRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public tblQuoteStatusChangeLogRowChangeEvent(
      dsPolicyDetail_StatusChanges.tblQuoteStatusChangeLogRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPolicyDetail_StatusChanges.tblQuoteStatusChangeLogRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }
}
