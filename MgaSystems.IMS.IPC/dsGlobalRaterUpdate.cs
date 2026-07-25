// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.dsGlobalRaterUpdate
// Assembly: MgaSystems.IMS.IPC, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: F22CEF02-8C0F-420D-8344-A8A010CA7834
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.IPC.dll

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
namespace MGASystems.IMS.InsuredsProducersCompanies;

[DesignerCategory("code")]
[ToolboxItem(true)]
[XmlSchemaProvider("GetTypedDataSetSchema")]
[XmlRoot("dsGlobalRaterUpdate")]
[HelpKeyword("vs.data.DataSet")]
[Serializable]
public class dsGlobalRaterUpdate : DataSet
{
  private dsGlobalRaterUpdate.tblCompanyLinesDataTable tabletblCompanyLines;
  private dsGlobalRaterUpdate.dtRatersDataTable tabledtRaters;
  private SchemaSerializationMode _schemaSerializationMode;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public dsGlobalRaterUpdate()
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
  protected dsGlobalRaterUpdate(SerializationInfo info, StreamingContext context)
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
        if (dataSet.Tables[nameof (tblCompanyLines)] != null)
          base.Tables.Add((DataTable) new dsGlobalRaterUpdate.tblCompanyLinesDataTable(dataSet.Tables[nameof (tblCompanyLines)]));
        if (dataSet.Tables[nameof (dtRaters)] != null)
          base.Tables.Add((DataTable) new dsGlobalRaterUpdate.dtRatersDataTable(dataSet.Tables[nameof (dtRaters)]));
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
  public dsGlobalRaterUpdate.tblCompanyLinesDataTable tblCompanyLines => this.tabletblCompanyLines;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsGlobalRaterUpdate.dtRatersDataTable dtRaters => this.tabledtRaters;

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
    dsGlobalRaterUpdate globalRaterUpdate = (dsGlobalRaterUpdate) base.Clone();
    globalRaterUpdate.InitVars();
    globalRaterUpdate.SchemaSerializationMode = this.SchemaSerializationMode;
    return (DataSet) globalRaterUpdate;
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
      if (dataSet.Tables["tblCompanyLines"] != null)
        base.Tables.Add((DataTable) new dsGlobalRaterUpdate.tblCompanyLinesDataTable(dataSet.Tables["tblCompanyLines"]));
      if (dataSet.Tables["dtRaters"] != null)
        base.Tables.Add((DataTable) new dsGlobalRaterUpdate.dtRatersDataTable(dataSet.Tables["dtRaters"]));
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
    this.tabletblCompanyLines = (dsGlobalRaterUpdate.tblCompanyLinesDataTable) base.Tables["tblCompanyLines"];
    if (initTable && this.tabletblCompanyLines != null)
      this.tabletblCompanyLines.InitVars();
    this.tabledtRaters = (dsGlobalRaterUpdate.dtRatersDataTable) base.Tables["dtRaters"];
    if (!initTable || this.tabledtRaters == null)
      return;
    this.tabledtRaters.InitVars();
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private void InitClass()
  {
    this.DataSetName = nameof (dsGlobalRaterUpdate);
    this.Prefix = "";
    this.Namespace = "http://tempuri.org/dsGlobalRaterUpdate.xsd";
    this.EnforceConstraints = true;
    this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.tabletblCompanyLines = new dsGlobalRaterUpdate.tblCompanyLinesDataTable();
    base.Tables.Add((DataTable) this.tabletblCompanyLines);
    this.tabledtRaters = new dsGlobalRaterUpdate.dtRatersDataTable();
    base.Tables.Add((DataTable) this.tabledtRaters);
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializetblCompanyLines() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializedtRaters() => false;

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
    dsGlobalRaterUpdate globalRaterUpdate = new dsGlobalRaterUpdate();
    XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
    schemaComplexType.Particle = (XmlSchemaParticle) new XmlSchemaSequence()
    {
      Items = {
        (XmlSchemaObject) new XmlSchemaAny()
        {
          Namespace = globalRaterUpdate.Namespace
        }
      }
    };
    XmlSchema schemaSerializable = globalRaterUpdate.GetSchemaSerializable();
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
  public delegate void tblCompanyLinesRowChangeEventHandler(
    object sender,
    dsGlobalRaterUpdate.tblCompanyLinesRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void dtRatersRowChangeEventHandler(
    object sender,
    dsGlobalRaterUpdate.dtRatersRowChangeEvent e);

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class tblCompanyLinesDataTable : TypedTableBase<dsGlobalRaterUpdate.tblCompanyLinesRow>
  {
    private DataColumn columnUpdateRater;
    private DataColumn columnCompanyLineGUID;
    private DataColumn columnCompanyLine;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblCompanyLinesDataTable()
    {
      this.TableName = "tblCompanyLines";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblCompanyLinesDataTable(DataTable table)
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
    protected tblCompanyLinesDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn UpdateRaterColumn => this.columnUpdateRater;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn CompanyLineGUIDColumn => this.columnCompanyLineGUID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn CompanyLineColumn => this.columnCompanyLine;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsGlobalRaterUpdate.tblCompanyLinesRow this[int index]
    {
      get => (dsGlobalRaterUpdate.tblCompanyLinesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsGlobalRaterUpdate.tblCompanyLinesRowChangeEventHandler tblCompanyLinesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsGlobalRaterUpdate.tblCompanyLinesRowChangeEventHandler tblCompanyLinesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsGlobalRaterUpdate.tblCompanyLinesRowChangeEventHandler tblCompanyLinesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsGlobalRaterUpdate.tblCompanyLinesRowChangeEventHandler tblCompanyLinesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddtblCompanyLinesRow(dsGlobalRaterUpdate.tblCompanyLinesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsGlobalRaterUpdate.tblCompanyLinesRow AddtblCompanyLinesRow(
      bool UpdateRater,
      Guid CompanyLineGUID,
      string CompanyLine)
    {
      dsGlobalRaterUpdate.tblCompanyLinesRow row = (dsGlobalRaterUpdate.tblCompanyLinesRow) this.NewRow();
      object[] objArray = new object[3]
      {
        (object) UpdateRater,
        (object) CompanyLineGUID,
        (object) CompanyLine
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsGlobalRaterUpdate.tblCompanyLinesRow FindByCompanyLineGUID(Guid CompanyLineGUID)
    {
      return (dsGlobalRaterUpdate.tblCompanyLinesRow) this.Rows.Find(new object[1]
      {
        (object) CompanyLineGUID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsGlobalRaterUpdate.tblCompanyLinesDataTable companyLinesDataTable = (dsGlobalRaterUpdate.tblCompanyLinesDataTable) base.Clone();
      companyLinesDataTable.InitVars();
      return (DataTable) companyLinesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsGlobalRaterUpdate.tblCompanyLinesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnUpdateRater = this.Columns["UpdateRater"];
      this.columnCompanyLineGUID = this.Columns["CompanyLineGUID"];
      this.columnCompanyLine = this.Columns["CompanyLine"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnUpdateRater = new DataColumn("UpdateRater", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnUpdateRater);
      this.columnCompanyLineGUID = new DataColumn("CompanyLineGUID", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCompanyLineGUID);
      this.columnCompanyLine = new DataColumn("CompanyLine", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCompanyLine);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnCompanyLineGUID
      }, true));
      this.columnUpdateRater.DefaultValue = (object) false;
      this.columnCompanyLineGUID.AllowDBNull = false;
      this.columnCompanyLineGUID.Unique = true;
      this.columnCompanyLine.ReadOnly = true;
      this.columnCompanyLine.MaxLength = 500;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsGlobalRaterUpdate.tblCompanyLinesRow NewtblCompanyLinesRow()
    {
      return (dsGlobalRaterUpdate.tblCompanyLinesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsGlobalRaterUpdate.tblCompanyLinesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (dsGlobalRaterUpdate.tblCompanyLinesRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyLinesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsGlobalRaterUpdate.tblCompanyLinesRowChangeEventHandler linesRowChangedEvent = this.tblCompanyLinesRowChangedEvent;
      if (linesRowChangedEvent == null)
        return;
      linesRowChangedEvent((object) this, new dsGlobalRaterUpdate.tblCompanyLinesRowChangeEvent((dsGlobalRaterUpdate.tblCompanyLinesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyLinesRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsGlobalRaterUpdate.tblCompanyLinesRowChangeEventHandler rowChangingEvent = this.tblCompanyLinesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsGlobalRaterUpdate.tblCompanyLinesRowChangeEvent((dsGlobalRaterUpdate.tblCompanyLinesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyLinesRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsGlobalRaterUpdate.tblCompanyLinesRowChangeEventHandler linesRowDeletedEvent = this.tblCompanyLinesRowDeletedEvent;
      if (linesRowDeletedEvent == null)
        return;
      linesRowDeletedEvent((object) this, new dsGlobalRaterUpdate.tblCompanyLinesRowChangeEvent((dsGlobalRaterUpdate.tblCompanyLinesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyLinesRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsGlobalRaterUpdate.tblCompanyLinesRowChangeEventHandler rowDeletingEvent = this.tblCompanyLinesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsGlobalRaterUpdate.tblCompanyLinesRowChangeEvent((dsGlobalRaterUpdate.tblCompanyLinesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemovetblCompanyLinesRow(dsGlobalRaterUpdate.tblCompanyLinesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsGlobalRaterUpdate globalRaterUpdate = new dsGlobalRaterUpdate();
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
        FixedValue = globalRaterUpdate.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblCompanyLinesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = globalRaterUpdate.GetSchemaSerializable();
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
  public class dtRatersDataTable : TypedTableBase<dsGlobalRaterUpdate.dtRatersRow>
  {
    private DataColumn columnRatingTypeID;
    private DataColumn columnRatingType;
    private DataColumn columnSelectRater;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dtRatersDataTable()
    {
      this.TableName = "dtRaters";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal dtRatersDataTable(DataTable table)
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
    protected dtRatersDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn RatingTypeIDColumn => this.columnRatingTypeID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn RatingTypeColumn => this.columnRatingType;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn SelectRaterColumn => this.columnSelectRater;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsGlobalRaterUpdate.dtRatersRow this[int index]
    {
      get => (dsGlobalRaterUpdate.dtRatersRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsGlobalRaterUpdate.dtRatersRowChangeEventHandler dtRatersRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsGlobalRaterUpdate.dtRatersRowChangeEventHandler dtRatersRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsGlobalRaterUpdate.dtRatersRowChangeEventHandler dtRatersRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsGlobalRaterUpdate.dtRatersRowChangeEventHandler dtRatersRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AdddtRatersRow(dsGlobalRaterUpdate.dtRatersRow row) => this.Rows.Add((DataRow) row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsGlobalRaterUpdate.dtRatersRow AdddtRatersRow(
      int RatingTypeID,
      string RatingType,
      bool SelectRater)
    {
      dsGlobalRaterUpdate.dtRatersRow row = (dsGlobalRaterUpdate.dtRatersRow) this.NewRow();
      object[] objArray = new object[3]
      {
        (object) RatingTypeID,
        (object) RatingType,
        (object) SelectRater
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsGlobalRaterUpdate.dtRatersRow FindByRatingTypeID(int RatingTypeID)
    {
      return (dsGlobalRaterUpdate.dtRatersRow) this.Rows.Find(new object[1]
      {
        (object) RatingTypeID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsGlobalRaterUpdate.dtRatersDataTable dtRatersDataTable = (dsGlobalRaterUpdate.dtRatersDataTable) base.Clone();
      dtRatersDataTable.InitVars();
      return (DataTable) dtRatersDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsGlobalRaterUpdate.dtRatersDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnRatingTypeID = this.Columns["RatingTypeID"];
      this.columnRatingType = this.Columns["RatingType"];
      this.columnSelectRater = this.Columns["SelectRater"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnRatingTypeID = new DataColumn("RatingTypeID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnRatingTypeID);
      this.columnRatingType = new DataColumn("RatingType", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnRatingType);
      this.columnSelectRater = new DataColumn("SelectRater", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSelectRater);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnRatingTypeID
      }, true));
      this.columnRatingTypeID.AllowDBNull = false;
      this.columnRatingTypeID.Unique = true;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsGlobalRaterUpdate.dtRatersRow NewdtRatersRow()
    {
      return (dsGlobalRaterUpdate.dtRatersRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsGlobalRaterUpdate.dtRatersRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (dsGlobalRaterUpdate.dtRatersRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.dtRatersRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsGlobalRaterUpdate.dtRatersRowChangeEventHandler ratersRowChangedEvent = this.dtRatersRowChangedEvent;
      if (ratersRowChangedEvent == null)
        return;
      ratersRowChangedEvent((object) this, new dsGlobalRaterUpdate.dtRatersRowChangeEvent((dsGlobalRaterUpdate.dtRatersRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.dtRatersRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsGlobalRaterUpdate.dtRatersRowChangeEventHandler rowChangingEvent = this.dtRatersRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsGlobalRaterUpdate.dtRatersRowChangeEvent((dsGlobalRaterUpdate.dtRatersRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.dtRatersRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsGlobalRaterUpdate.dtRatersRowChangeEventHandler ratersRowDeletedEvent = this.dtRatersRowDeletedEvent;
      if (ratersRowDeletedEvent == null)
        return;
      ratersRowDeletedEvent((object) this, new dsGlobalRaterUpdate.dtRatersRowChangeEvent((dsGlobalRaterUpdate.dtRatersRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.dtRatersRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsGlobalRaterUpdate.dtRatersRowChangeEventHandler rowDeletingEvent = this.dtRatersRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsGlobalRaterUpdate.dtRatersRowChangeEvent((dsGlobalRaterUpdate.dtRatersRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemovedtRatersRow(dsGlobalRaterUpdate.dtRatersRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsGlobalRaterUpdate globalRaterUpdate = new dsGlobalRaterUpdate();
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
        FixedValue = globalRaterUpdate.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (dtRatersDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = globalRaterUpdate.GetSchemaSerializable();
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

  public class tblCompanyLinesRow : DataRow
  {
    private dsGlobalRaterUpdate.tblCompanyLinesDataTable tabletblCompanyLines;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblCompanyLinesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblCompanyLines = (dsGlobalRaterUpdate.tblCompanyLinesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool UpdateRater
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tabletblCompanyLines.UpdateRaterColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'UpdateRater' in table 'tblCompanyLines' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanyLines.UpdateRaterColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Guid CompanyLineGUID
    {
      get
      {
        object obj = this[this.tabletblCompanyLines.CompanyLineGUIDColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tabletblCompanyLines.CompanyLineGUIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string CompanyLine
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblCompanyLines.CompanyLineColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'CompanyLine' in table 'tblCompanyLines' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanyLines.CompanyLineColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsUpdateRaterNull() => this.IsNull(this.tabletblCompanyLines.UpdateRaterColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetUpdateRaterNull()
    {
      this[this.tabletblCompanyLines.UpdateRaterColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsCompanyLineNull() => this.IsNull(this.tabletblCompanyLines.CompanyLineColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetCompanyLineNull()
    {
      this[this.tabletblCompanyLines.CompanyLineColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class dtRatersRow : DataRow
  {
    private dsGlobalRaterUpdate.dtRatersDataTable tabledtRaters;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal dtRatersRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabledtRaters = (dsGlobalRaterUpdate.dtRatersDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int RatingTypeID
    {
      get => Conversions.ToInteger(this[this.tabledtRaters.RatingTypeIDColumn]);
      set => this[this.tabledtRaters.RatingTypeIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string RatingType
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtRaters.RatingTypeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'RatingType' in table 'dtRaters' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtRaters.RatingTypeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool SelectRater
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tabledtRaters.SelectRaterColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'SelectRater' in table 'dtRaters' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtRaters.SelectRaterColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsRatingTypeNull() => this.IsNull(this.tabledtRaters.RatingTypeColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetRatingTypeNull()
    {
      this[this.tabledtRaters.RatingTypeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsSelectRaterNull() => this.IsNull(this.tabledtRaters.SelectRaterColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetSelectRaterNull()
    {
      this[this.tabledtRaters.SelectRaterColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class tblCompanyLinesRowChangeEvent : EventArgs
  {
    private dsGlobalRaterUpdate.tblCompanyLinesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblCompanyLinesRowChangeEvent(
      dsGlobalRaterUpdate.tblCompanyLinesRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsGlobalRaterUpdate.tblCompanyLinesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class dtRatersRowChangeEvent : EventArgs
  {
    private dsGlobalRaterUpdate.dtRatersRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dtRatersRowChangeEvent(dsGlobalRaterUpdate.dtRatersRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsGlobalRaterUpdate.dtRatersRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }
}
