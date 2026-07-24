// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Forms.dsOfacHistory
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
[XmlRoot("dsOfacHistory")]
[HelpKeyword("vs.data.DataSet")]
[Serializable]
public class dsOfacHistory : DataSet
{
  private dsOfacHistory.tblEntityOFAC_LogDataTable tabletblEntityOFAC_Log;
  private dsOfacHistory.tblEntityOFACHits_LogDataTable tabletblEntityOFACHits_Log;
  private SchemaSerializationMode _schemaSerializationMode;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public dsOfacHistory()
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
  protected dsOfacHistory(SerializationInfo info, StreamingContext context)
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
        if (dataSet.Tables[nameof (tblEntityOFAC_Log)] != null)
          base.Tables.Add((DataTable) new dsOfacHistory.tblEntityOFAC_LogDataTable(dataSet.Tables[nameof (tblEntityOFAC_Log)]));
        if (dataSet.Tables[nameof (tblEntityOFACHits_Log)] != null)
          base.Tables.Add((DataTable) new dsOfacHistory.tblEntityOFACHits_LogDataTable(dataSet.Tables[nameof (tblEntityOFACHits_Log)]));
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
  public dsOfacHistory.tblEntityOFAC_LogDataTable tblEntityOFAC_Log => this.tabletblEntityOFAC_Log;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsOfacHistory.tblEntityOFACHits_LogDataTable tblEntityOFACHits_Log
  {
    get => this.tabletblEntityOFACHits_Log;
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
    dsOfacHistory dsOfacHistory = (dsOfacHistory) base.Clone();
    dsOfacHistory.InitVars();
    dsOfacHistory.SchemaSerializationMode = this.SchemaSerializationMode;
    return (DataSet) dsOfacHistory;
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
      if (dataSet.Tables["tblEntityOFAC_Log"] != null)
        base.Tables.Add((DataTable) new dsOfacHistory.tblEntityOFAC_LogDataTable(dataSet.Tables["tblEntityOFAC_Log"]));
      if (dataSet.Tables["tblEntityOFACHits_Log"] != null)
        base.Tables.Add((DataTable) new dsOfacHistory.tblEntityOFACHits_LogDataTable(dataSet.Tables["tblEntityOFACHits_Log"]));
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
    this.tabletblEntityOFAC_Log = (dsOfacHistory.tblEntityOFAC_LogDataTable) base.Tables["tblEntityOFAC_Log"];
    if (initTable && this.tabletblEntityOFAC_Log != null)
      this.tabletblEntityOFAC_Log.InitVars();
    this.tabletblEntityOFACHits_Log = (dsOfacHistory.tblEntityOFACHits_LogDataTable) base.Tables["tblEntityOFACHits_Log"];
    if (!initTable || this.tabletblEntityOFACHits_Log == null)
      return;
    this.tabletblEntityOFACHits_Log.InitVars();
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private void InitClass()
  {
    this.DataSetName = nameof (dsOfacHistory);
    this.Prefix = "";
    this.Namespace = "http://tempuri.org/dsOfacHistory.xsd";
    this.EnforceConstraints = true;
    this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.tabletblEntityOFAC_Log = new dsOfacHistory.tblEntityOFAC_LogDataTable();
    base.Tables.Add((DataTable) this.tabletblEntityOFAC_Log);
    this.tabletblEntityOFACHits_Log = new dsOfacHistory.tblEntityOFACHits_LogDataTable();
    base.Tables.Add((DataTable) this.tabletblEntityOFACHits_Log);
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializetblEntityOFAC_Log() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializetblEntityOFACHits_Log() => false;

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
    dsOfacHistory dsOfacHistory = new dsOfacHistory();
    XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
    schemaComplexType.Particle = (XmlSchemaParticle) new XmlSchemaSequence()
    {
      Items = {
        (XmlSchemaObject) new XmlSchemaAny()
        {
          Namespace = dsOfacHistory.Namespace
        }
      }
    };
    XmlSchema schemaSerializable = dsOfacHistory.GetSchemaSerializable();
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
  public delegate void tblEntityOFAC_LogRowChangeEventHandler(
    object sender,
    dsOfacHistory.tblEntityOFAC_LogRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public delegate void tblEntityOFACHits_LogRowChangeEventHandler(
    object sender,
    dsOfacHistory.tblEntityOFACHits_LogRowChangeEvent e);

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class tblEntityOFAC_LogDataTable : TypedTableBase<dsOfacHistory.tblEntityOFAC_LogRow>
  {
    private DataColumn columnOfacLogID;
    private DataColumn columnLogDate;
    private DataColumn columnEntityName;
    private DataColumn columnReturnScore;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public tblEntityOFAC_LogDataTable()
    {
      this.TableName = "tblEntityOFAC_Log";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal tblEntityOFAC_LogDataTable(DataTable table)
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
    protected tblEntityOFAC_LogDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn OfacLogIDColumn => this.columnOfacLogID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn LogDateColumn => this.columnLogDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn EntityNameColumn => this.columnEntityName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ReturnScoreColumn => this.columnReturnScore;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsOfacHistory.tblEntityOFAC_LogRow this[int index]
    {
      get => (dsOfacHistory.tblEntityOFAC_LogRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsOfacHistory.tblEntityOFAC_LogRowChangeEventHandler tblEntityOFAC_LogRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsOfacHistory.tblEntityOFAC_LogRowChangeEventHandler tblEntityOFAC_LogRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsOfacHistory.tblEntityOFAC_LogRowChangeEventHandler tblEntityOFAC_LogRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsOfacHistory.tblEntityOFAC_LogRowChangeEventHandler tblEntityOFAC_LogRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AddtblEntityOFAC_LogRow(dsOfacHistory.tblEntityOFAC_LogRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsOfacHistory.tblEntityOFAC_LogRow AddtblEntityOFAC_LogRow(
      int OfacLogID,
      DateTime LogDate,
      string EntityName,
      string ReturnScore)
    {
      dsOfacHistory.tblEntityOFAC_LogRow row = (dsOfacHistory.tblEntityOFAC_LogRow) this.NewRow();
      object[] objArray = new object[4]
      {
        (object) OfacLogID,
        (object) LogDate,
        (object) EntityName,
        (object) ReturnScore
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsOfacHistory.tblEntityOFAC_LogDataTable ofacLogDataTable = (dsOfacHistory.tblEntityOFAC_LogDataTable) base.Clone();
      ofacLogDataTable.InitVars();
      return (DataTable) ofacLogDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsOfacHistory.tblEntityOFAC_LogDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal void InitVars()
    {
      this.columnOfacLogID = this.Columns["OfacLogID"];
      this.columnLogDate = this.Columns["LogDate"];
      this.columnEntityName = this.Columns["EntityName"];
      this.columnReturnScore = this.Columns["ReturnScore"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.columnOfacLogID = new DataColumn("OfacLogID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnOfacLogID);
      this.columnLogDate = new DataColumn("LogDate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLogDate);
      this.columnEntityName = new DataColumn("EntityName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEntityName);
      this.columnReturnScore = new DataColumn("ReturnScore", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnReturnScore);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsOfacHistory.tblEntityOFAC_LogRow NewtblEntityOFAC_LogRow()
    {
      return (dsOfacHistory.tblEntityOFAC_LogRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsOfacHistory.tblEntityOFAC_LogRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType() => typeof (dsOfacHistory.tblEntityOFAC_LogRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblEntityOFAC_LogRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsOfacHistory.tblEntityOFAC_LogRowChangeEventHandler logRowChangedEvent = this.tblEntityOFAC_LogRowChangedEvent;
      if (logRowChangedEvent == null)
        return;
      logRowChangedEvent((object) this, new dsOfacHistory.tblEntityOFAC_LogRowChangeEvent((dsOfacHistory.tblEntityOFAC_LogRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblEntityOFAC_LogRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsOfacHistory.tblEntityOFAC_LogRowChangeEventHandler rowChangingEvent = this.tblEntityOFAC_LogRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsOfacHistory.tblEntityOFAC_LogRowChangeEvent((dsOfacHistory.tblEntityOFAC_LogRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblEntityOFAC_LogRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsOfacHistory.tblEntityOFAC_LogRowChangeEventHandler logRowDeletedEvent = this.tblEntityOFAC_LogRowDeletedEvent;
      if (logRowDeletedEvent == null)
        return;
      logRowDeletedEvent((object) this, new dsOfacHistory.tblEntityOFAC_LogRowChangeEvent((dsOfacHistory.tblEntityOFAC_LogRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblEntityOFAC_LogRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsOfacHistory.tblEntityOFAC_LogRowChangeEventHandler rowDeletingEvent = this.tblEntityOFAC_LogRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsOfacHistory.tblEntityOFAC_LogRowChangeEvent((dsOfacHistory.tblEntityOFAC_LogRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemovetblEntityOFAC_LogRow(dsOfacHistory.tblEntityOFAC_LogRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsOfacHistory dsOfacHistory = new dsOfacHistory();
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
        FixedValue = dsOfacHistory.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblEntityOFAC_LogDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsOfacHistory.GetSchemaSerializable();
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
  public class tblEntityOFACHits_LogDataTable : 
    TypedTableBase<dsOfacHistory.tblEntityOFACHits_LogRow>
  {
    private DataColumn columnClearLogID;
    private DataColumn columnLogDate;
    private DataColumn columnUserName;
    private DataColumn columnClearDate;
    private DataColumn columnClearReason;
    private DataColumn columnAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public tblEntityOFACHits_LogDataTable()
    {
      this.TableName = "tblEntityOFACHits_Log";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal tblEntityOFACHits_LogDataTable(DataTable table)
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
    protected tblEntityOFACHits_LogDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ClearLogIDColumn => this.columnClearLogID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn LogDateColumn => this.columnLogDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn UserNameColumn => this.columnUserName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ClearDateColumn => this.columnClearDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ClearReasonColumn => this.columnClearReason;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ActionColumn => this.columnAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsOfacHistory.tblEntityOFACHits_LogRow this[int index]
    {
      get => (dsOfacHistory.tblEntityOFACHits_LogRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsOfacHistory.tblEntityOFACHits_LogRowChangeEventHandler tblEntityOFACHits_LogRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsOfacHistory.tblEntityOFACHits_LogRowChangeEventHandler tblEntityOFACHits_LogRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsOfacHistory.tblEntityOFACHits_LogRowChangeEventHandler tblEntityOFACHits_LogRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsOfacHistory.tblEntityOFACHits_LogRowChangeEventHandler tblEntityOFACHits_LogRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AddtblEntityOFACHits_LogRow(dsOfacHistory.tblEntityOFACHits_LogRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsOfacHistory.tblEntityOFACHits_LogRow AddtblEntityOFACHits_LogRow(
      int ClearLogID,
      DateTime LogDate,
      string UserName,
      DateTime ClearDate,
      string ClearReason,
      string Action)
    {
      dsOfacHistory.tblEntityOFACHits_LogRow row = (dsOfacHistory.tblEntityOFACHits_LogRow) this.NewRow();
      object[] objArray = new object[6]
      {
        (object) ClearLogID,
        (object) LogDate,
        (object) UserName,
        (object) ClearDate,
        (object) ClearReason,
        (object) Action
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsOfacHistory.tblEntityOFACHits_LogDataTable hitsLogDataTable = (dsOfacHistory.tblEntityOFACHits_LogDataTable) base.Clone();
      hitsLogDataTable.InitVars();
      return (DataTable) hitsLogDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsOfacHistory.tblEntityOFACHits_LogDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal void InitVars()
    {
      this.columnClearLogID = this.Columns["ClearLogID"];
      this.columnLogDate = this.Columns["LogDate"];
      this.columnUserName = this.Columns["UserName"];
      this.columnClearDate = this.Columns["ClearDate"];
      this.columnClearReason = this.Columns["ClearReason"];
      this.columnAction = this.Columns["Action"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.columnClearLogID = new DataColumn("ClearLogID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnClearLogID);
      this.columnLogDate = new DataColumn("LogDate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLogDate);
      this.columnUserName = new DataColumn("UserName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnUserName);
      this.columnClearDate = new DataColumn("ClearDate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnClearDate);
      this.columnClearReason = new DataColumn("ClearReason", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnClearReason);
      this.columnAction = new DataColumn("Action", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAction);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsOfacHistory.tblEntityOFACHits_LogRow NewtblEntityOFACHits_LogRow()
    {
      return (dsOfacHistory.tblEntityOFACHits_LogRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsOfacHistory.tblEntityOFACHits_LogRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType() => typeof (dsOfacHistory.tblEntityOFACHits_LogRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblEntityOFACHits_LogRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsOfacHistory.tblEntityOFACHits_LogRowChangeEventHandler logRowChangedEvent = this.tblEntityOFACHits_LogRowChangedEvent;
      if (logRowChangedEvent == null)
        return;
      logRowChangedEvent((object) this, new dsOfacHistory.tblEntityOFACHits_LogRowChangeEvent((dsOfacHistory.tblEntityOFACHits_LogRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblEntityOFACHits_LogRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsOfacHistory.tblEntityOFACHits_LogRowChangeEventHandler rowChangingEvent = this.tblEntityOFACHits_LogRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsOfacHistory.tblEntityOFACHits_LogRowChangeEvent((dsOfacHistory.tblEntityOFACHits_LogRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblEntityOFACHits_LogRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsOfacHistory.tblEntityOFACHits_LogRowChangeEventHandler logRowDeletedEvent = this.tblEntityOFACHits_LogRowDeletedEvent;
      if (logRowDeletedEvent == null)
        return;
      logRowDeletedEvent((object) this, new dsOfacHistory.tblEntityOFACHits_LogRowChangeEvent((dsOfacHistory.tblEntityOFACHits_LogRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblEntityOFACHits_LogRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsOfacHistory.tblEntityOFACHits_LogRowChangeEventHandler rowDeletingEvent = this.tblEntityOFACHits_LogRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsOfacHistory.tblEntityOFACHits_LogRowChangeEvent((dsOfacHistory.tblEntityOFACHits_LogRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemovetblEntityOFACHits_LogRow(dsOfacHistory.tblEntityOFACHits_LogRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsOfacHistory dsOfacHistory = new dsOfacHistory();
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
        FixedValue = dsOfacHistory.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblEntityOFACHits_LogDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsOfacHistory.GetSchemaSerializable();
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

  public class tblEntityOFAC_LogRow : DataRow
  {
    private dsOfacHistory.tblEntityOFAC_LogDataTable tabletblEntityOFAC_Log;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal tblEntityOFAC_LogRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblEntityOFAC_Log = (dsOfacHistory.tblEntityOFAC_LogDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int OfacLogID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblEntityOFAC_Log.OfacLogIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'OfacLogID' in table 'tblEntityOFAC_Log' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblEntityOFAC_Log.OfacLogIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DateTime LogDate
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tabletblEntityOFAC_Log.LogDateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'LogDate' in table 'tblEntityOFAC_Log' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblEntityOFAC_Log.LogDateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string EntityName
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblEntityOFAC_Log.EntityNameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'EntityName' in table 'tblEntityOFAC_Log' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblEntityOFAC_Log.EntityNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string ReturnScore
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblEntityOFAC_Log.ReturnScoreColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ReturnScore' in table 'tblEntityOFAC_Log' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblEntityOFAC_Log.ReturnScoreColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsOfacLogIDNull() => this.IsNull(this.tabletblEntityOFAC_Log.OfacLogIDColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetOfacLogIDNull()
    {
      this[this.tabletblEntityOFAC_Log.OfacLogIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsLogDateNull() => this.IsNull(this.tabletblEntityOFAC_Log.LogDateColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetLogDateNull()
    {
      this[this.tabletblEntityOFAC_Log.LogDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsEntityNameNull() => this.IsNull(this.tabletblEntityOFAC_Log.EntityNameColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetEntityNameNull()
    {
      this[this.tabletblEntityOFAC_Log.EntityNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsReturnScoreNull() => this.IsNull(this.tabletblEntityOFAC_Log.ReturnScoreColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetReturnScoreNull()
    {
      this[this.tabletblEntityOFAC_Log.ReturnScoreColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class tblEntityOFACHits_LogRow : DataRow
  {
    private dsOfacHistory.tblEntityOFACHits_LogDataTable tabletblEntityOFACHits_Log;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal tblEntityOFACHits_LogRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblEntityOFACHits_Log = (dsOfacHistory.tblEntityOFACHits_LogDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int ClearLogID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblEntityOFACHits_Log.ClearLogIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ClearLogID' in table 'tblEntityOFACHits_Log' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblEntityOFACHits_Log.ClearLogIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DateTime LogDate
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tabletblEntityOFACHits_Log.LogDateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'LogDate' in table 'tblEntityOFACHits_Log' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblEntityOFACHits_Log.LogDateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string UserName
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblEntityOFACHits_Log.UserNameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'UserName' in table 'tblEntityOFACHits_Log' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblEntityOFACHits_Log.UserNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DateTime ClearDate
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tabletblEntityOFACHits_Log.ClearDateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ClearDate' in table 'tblEntityOFACHits_Log' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblEntityOFACHits_Log.ClearDateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string ClearReason
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblEntityOFACHits_Log.ClearReasonColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ClearReason' in table 'tblEntityOFACHits_Log' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblEntityOFACHits_Log.ClearReasonColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string Action
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblEntityOFACHits_Log.ActionColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Action' in table 'tblEntityOFACHits_Log' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblEntityOFACHits_Log.ActionColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsClearLogIDNull() => this.IsNull(this.tabletblEntityOFACHits_Log.ClearLogIDColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetClearLogIDNull()
    {
      this[this.tabletblEntityOFACHits_Log.ClearLogIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsLogDateNull() => this.IsNull(this.tabletblEntityOFACHits_Log.LogDateColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetLogDateNull()
    {
      this[this.tabletblEntityOFACHits_Log.LogDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsUserNameNull() => this.IsNull(this.tabletblEntityOFACHits_Log.UserNameColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetUserNameNull()
    {
      this[this.tabletblEntityOFACHits_Log.UserNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsClearDateNull() => this.IsNull(this.tabletblEntityOFACHits_Log.ClearDateColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetClearDateNull()
    {
      this[this.tabletblEntityOFACHits_Log.ClearDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsClearReasonNull()
    {
      return this.IsNull(this.tabletblEntityOFACHits_Log.ClearReasonColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetClearReasonNull()
    {
      this[this.tabletblEntityOFACHits_Log.ClearReasonColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsActionNull() => this.IsNull(this.tabletblEntityOFACHits_Log.ActionColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetActionNull()
    {
      this[this.tabletblEntityOFACHits_Log.ActionColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class tblEntityOFAC_LogRowChangeEvent : EventArgs
  {
    private dsOfacHistory.tblEntityOFAC_LogRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public tblEntityOFAC_LogRowChangeEvent(
      dsOfacHistory.tblEntityOFAC_LogRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsOfacHistory.tblEntityOFAC_LogRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class tblEntityOFACHits_LogRowChangeEvent : EventArgs
  {
    private dsOfacHistory.tblEntityOFACHits_LogRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public tblEntityOFACHits_LogRowChangeEvent(
      dsOfacHistory.tblEntityOFACHits_LogRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsOfacHistory.tblEntityOFACHits_LogRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }
}
