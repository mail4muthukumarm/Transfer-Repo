// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Rating.GL.dsGLRater
// Assembly: MgaSystems.IMS.Rating, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 370B8F0A-FA1A-41D0-87BD-563CC23E9EA7
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Rating.dll

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
namespace MGASystems.IMS.Policies.Rating.GL;

[DesignerCategory("code")]
[ToolboxItem(true)]
[XmlSchemaProvider("GetTypedDataSetSchema")]
[XmlRoot("dsGLRater")]
[HelpKeyword("vs.data.DataSet")]
[Serializable]
public class dsGLRater : DataSet
{
  private dsGLRater.tblGLLimitsDataTable tabletblGLLimits;
  private dsGLRater.lstGLDeductibleDescriptionsDataTable tablelstGLDeductibleDescriptions;
  private dsGLRater.tblQuoteOptionsDataTable tabletblQuoteOptions;
  private dsGLRater.tblQuoteOptionGLDataTable tabletblQuoteOptionGL;
  private DataRelation relationtblQuoteOptionstblQuoteOptionGL;
  private SchemaSerializationMode _schemaSerializationMode;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public dsGLRater()
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
  protected dsGLRater(SerializationInfo info, StreamingContext context)
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
        if (dataSet.Tables[nameof (tblGLLimits)] != null)
          base.Tables.Add((DataTable) new dsGLRater.tblGLLimitsDataTable(dataSet.Tables[nameof (tblGLLimits)]));
        if (dataSet.Tables[nameof (lstGLDeductibleDescriptions)] != null)
          base.Tables.Add((DataTable) new dsGLRater.lstGLDeductibleDescriptionsDataTable(dataSet.Tables[nameof (lstGLDeductibleDescriptions)]));
        if (dataSet.Tables[nameof (tblQuoteOptions)] != null)
          base.Tables.Add((DataTable) new dsGLRater.tblQuoteOptionsDataTable(dataSet.Tables[nameof (tblQuoteOptions)]));
        if (dataSet.Tables[nameof (tblQuoteOptionGL)] != null)
          base.Tables.Add((DataTable) new dsGLRater.tblQuoteOptionGLDataTable(dataSet.Tables[nameof (tblQuoteOptionGL)]));
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
  public dsGLRater.tblGLLimitsDataTable tblGLLimits => this.tabletblGLLimits;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsGLRater.lstGLDeductibleDescriptionsDataTable lstGLDeductibleDescriptions
  {
    get => this.tablelstGLDeductibleDescriptions;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsGLRater.tblQuoteOptionsDataTable tblQuoteOptions => this.tabletblQuoteOptions;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsGLRater.tblQuoteOptionGLDataTable tblQuoteOptionGL => this.tabletblQuoteOptionGL;

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
    dsGLRater dsGlRater = (dsGLRater) base.Clone();
    dsGlRater.InitVars();
    dsGlRater.SchemaSerializationMode = this.SchemaSerializationMode;
    return (DataSet) dsGlRater;
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
      if (dataSet.Tables["tblGLLimits"] != null)
        base.Tables.Add((DataTable) new dsGLRater.tblGLLimitsDataTable(dataSet.Tables["tblGLLimits"]));
      if (dataSet.Tables["lstGLDeductibleDescriptions"] != null)
        base.Tables.Add((DataTable) new dsGLRater.lstGLDeductibleDescriptionsDataTable(dataSet.Tables["lstGLDeductibleDescriptions"]));
      if (dataSet.Tables["tblQuoteOptions"] != null)
        base.Tables.Add((DataTable) new dsGLRater.tblQuoteOptionsDataTable(dataSet.Tables["tblQuoteOptions"]));
      if (dataSet.Tables["tblQuoteOptionGL"] != null)
        base.Tables.Add((DataTable) new dsGLRater.tblQuoteOptionGLDataTable(dataSet.Tables["tblQuoteOptionGL"]));
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
    this.tabletblGLLimits = (dsGLRater.tblGLLimitsDataTable) base.Tables["tblGLLimits"];
    if (initTable && this.tabletblGLLimits != null)
      this.tabletblGLLimits.InitVars();
    this.tablelstGLDeductibleDescriptions = (dsGLRater.lstGLDeductibleDescriptionsDataTable) base.Tables["lstGLDeductibleDescriptions"];
    if (initTable && this.tablelstGLDeductibleDescriptions != null)
      this.tablelstGLDeductibleDescriptions.InitVars();
    this.tabletblQuoteOptions = (dsGLRater.tblQuoteOptionsDataTable) base.Tables["tblQuoteOptions"];
    if (initTable && this.tabletblQuoteOptions != null)
      this.tabletblQuoteOptions.InitVars();
    this.tabletblQuoteOptionGL = (dsGLRater.tblQuoteOptionGLDataTable) base.Tables["tblQuoteOptionGL"];
    if (initTable && this.tabletblQuoteOptionGL != null)
      this.tabletblQuoteOptionGL.InitVars();
    this.relationtblQuoteOptionstblQuoteOptionGL = this.Relations["tblQuoteOptionstblQuoteOptionGL"];
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private void InitClass()
  {
    this.DataSetName = nameof (dsGLRater);
    this.Prefix = "";
    this.Namespace = "http://www.tempuri.org/dsGLRater.xsd";
    this.EnforceConstraints = true;
    this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.tabletblGLLimits = new dsGLRater.tblGLLimitsDataTable();
    base.Tables.Add((DataTable) this.tabletblGLLimits);
    this.tablelstGLDeductibleDescriptions = new dsGLRater.lstGLDeductibleDescriptionsDataTable();
    base.Tables.Add((DataTable) this.tablelstGLDeductibleDescriptions);
    this.tabletblQuoteOptions = new dsGLRater.tblQuoteOptionsDataTable();
    base.Tables.Add((DataTable) this.tabletblQuoteOptions);
    this.tabletblQuoteOptionGL = new dsGLRater.tblQuoteOptionGLDataTable();
    base.Tables.Add((DataTable) this.tabletblQuoteOptionGL);
    ForeignKeyConstraint foreignKeyConstraint = new ForeignKeyConstraint("tblQuoteOptionstblQuoteOptionGL", new DataColumn[1]
    {
      this.tabletblQuoteOptions.QuoteOptionIDColumn
    }, new DataColumn[1]
    {
      this.tabletblQuoteOptionGL.QuoteOptionIDColumn
    });
    this.tabletblQuoteOptionGL.Constraints.Add((Constraint) foreignKeyConstraint);
    foreignKeyConstraint.AcceptRejectRule = AcceptRejectRule.None;
    foreignKeyConstraint.DeleteRule = Rule.Cascade;
    foreignKeyConstraint.UpdateRule = Rule.Cascade;
    this.relationtblQuoteOptionstblQuoteOptionGL = new DataRelation("tblQuoteOptionstblQuoteOptionGL", new DataColumn[1]
    {
      this.tabletblQuoteOptions.QuoteOptionIDColumn
    }, new DataColumn[1]
    {
      this.tabletblQuoteOptionGL.QuoteOptionIDColumn
    }, false);
    this.Relations.Add(this.relationtblQuoteOptionstblQuoteOptionGL);
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializetblGLLimits() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializelstGLDeductibleDescriptions() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializetblQuoteOptions() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializetblQuoteOptionGL() => false;

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
    dsGLRater dsGlRater = new dsGLRater();
    XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
    schemaComplexType.Particle = (XmlSchemaParticle) new XmlSchemaSequence()
    {
      Items = {
        (XmlSchemaObject) new XmlSchemaAny()
        {
          Namespace = dsGlRater.Namespace
        }
      }
    };
    XmlSchema schemaSerializable = dsGlRater.GetSchemaSerializable();
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
  public delegate void tblGLLimitsRowChangeEventHandler(
    object sender,
    dsGLRater.tblGLLimitsRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void lstGLDeductibleDescriptionsRowChangeEventHandler(
    object sender,
    dsGLRater.lstGLDeductibleDescriptionsRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void tblQuoteOptionsRowChangeEventHandler(
    object sender,
    dsGLRater.tblQuoteOptionsRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void tblQuoteOptionGLRowChangeEventHandler(
    object sender,
    dsGLRater.tblQuoteOptionGLRowChangeEvent e);

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class tblGLLimitsDataTable : TypedTableBase<dsGLRater.tblGLLimitsRow>
  {
    private DataColumn columnID;
    private DataColumn columnLimitCode;
    private DataColumn columnLimit;
    private DataColumn columnLimitDisplay;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblGLLimitsDataTable()
    {
      this.TableName = "tblGLLimits";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblGLLimitsDataTable(DataTable table)
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
    protected tblGLLimitsDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn IDColumn => this.columnID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn LimitCodeColumn => this.columnLimitCode;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn LimitColumn => this.columnLimit;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn LimitDisplayColumn => this.columnLimitDisplay;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsGLRater.tblGLLimitsRow this[int index] => (dsGLRater.tblGLLimitsRow) this.Rows[index];

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsGLRater.tblGLLimitsRowChangeEventHandler tblGLLimitsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsGLRater.tblGLLimitsRowChangeEventHandler tblGLLimitsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsGLRater.tblGLLimitsRowChangeEventHandler tblGLLimitsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsGLRater.tblGLLimitsRowChangeEventHandler tblGLLimitsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddtblGLLimitsRow(dsGLRater.tblGLLimitsRow row) => this.Rows.Add((DataRow) row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsGLRater.tblGLLimitsRow AddtblGLLimitsRow(
      string LimitCode,
      int Limit,
      string LimitDisplay)
    {
      dsGLRater.tblGLLimitsRow row = (dsGLRater.tblGLLimitsRow) this.NewRow();
      object[] objArray = new object[4]
      {
        null,
        (object) LimitCode,
        (object) Limit,
        (object) LimitDisplay
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsGLRater.tblGLLimitsDataTable glLimitsDataTable = (dsGLRater.tblGLLimitsDataTable) base.Clone();
      glLimitsDataTable.InitVars();
      return (DataTable) glLimitsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsGLRater.tblGLLimitsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnID = this.Columns["ID"];
      this.columnLimitCode = this.Columns["LimitCode"];
      this.columnLimit = this.Columns["Limit"];
      this.columnLimitDisplay = this.Columns["LimitDisplay"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnID = new DataColumn("ID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnID);
      this.columnLimitCode = new DataColumn("LimitCode", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLimitCode);
      this.columnLimit = new DataColumn("Limit", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLimit);
      this.columnLimitDisplay = new DataColumn("LimitDisplay", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLimitDisplay);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnID
      }, false));
      this.columnID.AutoIncrement = true;
      this.columnID.ReadOnly = true;
      this.columnID.Unique = true;
      this.columnLimitCode.AllowDBNull = false;
      this.columnLimit.AllowDBNull = false;
      this.columnLimitDisplay.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsGLRater.tblGLLimitsRow NewtblGLLimitsRow() => (dsGLRater.tblGLLimitsRow) this.NewRow();

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsGLRater.tblGLLimitsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (dsGLRater.tblGLLimitsRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblGLLimitsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsGLRater.tblGLLimitsRowChangeEventHandler limitsRowChangedEvent = this.tblGLLimitsRowChangedEvent;
      if (limitsRowChangedEvent == null)
        return;
      limitsRowChangedEvent((object) this, new dsGLRater.tblGLLimitsRowChangeEvent((dsGLRater.tblGLLimitsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblGLLimitsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsGLRater.tblGLLimitsRowChangeEventHandler rowChangingEvent = this.tblGLLimitsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsGLRater.tblGLLimitsRowChangeEvent((dsGLRater.tblGLLimitsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblGLLimitsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsGLRater.tblGLLimitsRowChangeEventHandler limitsRowDeletedEvent = this.tblGLLimitsRowDeletedEvent;
      if (limitsRowDeletedEvent == null)
        return;
      limitsRowDeletedEvent((object) this, new dsGLRater.tblGLLimitsRowChangeEvent((dsGLRater.tblGLLimitsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblGLLimitsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsGLRater.tblGLLimitsRowChangeEventHandler rowDeletingEvent = this.tblGLLimitsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsGLRater.tblGLLimitsRowChangeEvent((dsGLRater.tblGLLimitsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemovetblGLLimitsRow(dsGLRater.tblGLLimitsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsGLRater dsGlRater = new dsGLRater();
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
        FixedValue = dsGlRater.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblGLLimitsDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsGlRater.GetSchemaSerializable();
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
  public class lstGLDeductibleDescriptionsDataTable : 
    TypedTableBase<dsGLRater.lstGLDeductibleDescriptionsRow>
  {
    private DataColumn columnID;
    private DataColumn columnDeductibleDescription;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public lstGLDeductibleDescriptionsDataTable()
    {
      this.TableName = "lstGLDeductibleDescriptions";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal lstGLDeductibleDescriptionsDataTable(DataTable table)
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
    protected lstGLDeductibleDescriptionsDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn IDColumn => this.columnID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn DeductibleDescriptionColumn => this.columnDeductibleDescription;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsGLRater.lstGLDeductibleDescriptionsRow this[int index]
    {
      get => (dsGLRater.lstGLDeductibleDescriptionsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsGLRater.lstGLDeductibleDescriptionsRowChangeEventHandler lstGLDeductibleDescriptionsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsGLRater.lstGLDeductibleDescriptionsRowChangeEventHandler lstGLDeductibleDescriptionsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsGLRater.lstGLDeductibleDescriptionsRowChangeEventHandler lstGLDeductibleDescriptionsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsGLRater.lstGLDeductibleDescriptionsRowChangeEventHandler lstGLDeductibleDescriptionsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddlstGLDeductibleDescriptionsRow(dsGLRater.lstGLDeductibleDescriptionsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsGLRater.lstGLDeductibleDescriptionsRow AddlstGLDeductibleDescriptionsRow(
      int ID,
      string DeductibleDescription)
    {
      dsGLRater.lstGLDeductibleDescriptionsRow row = (dsGLRater.lstGLDeductibleDescriptionsRow) this.NewRow();
      object[] objArray = new object[2]
      {
        (object) ID,
        (object) DeductibleDescription
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsGLRater.lstGLDeductibleDescriptionsRow FindByID(int ID)
    {
      return (dsGLRater.lstGLDeductibleDescriptionsRow) this.Rows.Find(new object[1]
      {
        (object) ID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsGLRater.lstGLDeductibleDescriptionsDataTable descriptionsDataTable = (dsGLRater.lstGLDeductibleDescriptionsDataTable) base.Clone();
      descriptionsDataTable.InitVars();
      return (DataTable) descriptionsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsGLRater.lstGLDeductibleDescriptionsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnID = this.Columns["ID"];
      this.columnDeductibleDescription = this.Columns["DeductibleDescription"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnID = new DataColumn("ID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnID);
      this.columnDeductibleDescription = new DataColumn("DeductibleDescription", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDeductibleDescription);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnID
      }, true));
      this.columnID.AllowDBNull = false;
      this.columnID.ReadOnly = true;
      this.columnID.Unique = true;
      this.columnDeductibleDescription.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsGLRater.lstGLDeductibleDescriptionsRow NewlstGLDeductibleDescriptionsRow()
    {
      return (dsGLRater.lstGLDeductibleDescriptionsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsGLRater.lstGLDeductibleDescriptionsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (dsGLRater.lstGLDeductibleDescriptionsRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstGLDeductibleDescriptionsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsGLRater.lstGLDeductibleDescriptionsRowChangeEventHandler descriptionsRowChangedEvent = this.lstGLDeductibleDescriptionsRowChangedEvent;
      if (descriptionsRowChangedEvent == null)
        return;
      descriptionsRowChangedEvent((object) this, new dsGLRater.lstGLDeductibleDescriptionsRowChangeEvent((dsGLRater.lstGLDeductibleDescriptionsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstGLDeductibleDescriptionsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsGLRater.lstGLDeductibleDescriptionsRowChangeEventHandler rowChangingEvent = this.lstGLDeductibleDescriptionsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsGLRater.lstGLDeductibleDescriptionsRowChangeEvent((dsGLRater.lstGLDeductibleDescriptionsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstGLDeductibleDescriptionsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsGLRater.lstGLDeductibleDescriptionsRowChangeEventHandler descriptionsRowDeletedEvent = this.lstGLDeductibleDescriptionsRowDeletedEvent;
      if (descriptionsRowDeletedEvent == null)
        return;
      descriptionsRowDeletedEvent((object) this, new dsGLRater.lstGLDeductibleDescriptionsRowChangeEvent((dsGLRater.lstGLDeductibleDescriptionsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstGLDeductibleDescriptionsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsGLRater.lstGLDeductibleDescriptionsRowChangeEventHandler rowDeletingEvent = this.lstGLDeductibleDescriptionsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsGLRater.lstGLDeductibleDescriptionsRowChangeEvent((dsGLRater.lstGLDeductibleDescriptionsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemovelstGLDeductibleDescriptionsRow(dsGLRater.lstGLDeductibleDescriptionsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsGLRater dsGlRater = new dsGLRater();
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
        FixedValue = dsGlRater.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (lstGLDeductibleDescriptionsDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsGlRater.GetSchemaSerializable();
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
  public class tblQuoteOptionsDataTable : TypedTableBase<dsGLRater.tblQuoteOptionsRow>
  {
    private DataColumn columnQuoteOptionID;
    private DataColumn columnQuoteOptionGUID;
    private DataColumn columnQuoteGUID;
    private DataColumn columnLineGUID;
    private DataColumn columnPremium;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblQuoteOptionsDataTable()
    {
      this.TableName = "tblQuoteOptions";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblQuoteOptionsDataTable(DataTable table)
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
    protected tblQuoteOptionsDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn QuoteOptionIDColumn => this.columnQuoteOptionID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn QuoteOptionGUIDColumn => this.columnQuoteOptionGUID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn QuoteGUIDColumn => this.columnQuoteGUID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn LineGUIDColumn => this.columnLineGUID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn PremiumColumn => this.columnPremium;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsGLRater.tblQuoteOptionsRow this[int index]
    {
      get => (dsGLRater.tblQuoteOptionsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsGLRater.tblQuoteOptionsRowChangeEventHandler tblQuoteOptionsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsGLRater.tblQuoteOptionsRowChangeEventHandler tblQuoteOptionsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsGLRater.tblQuoteOptionsRowChangeEventHandler tblQuoteOptionsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsGLRater.tblQuoteOptionsRowChangeEventHandler tblQuoteOptionsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddtblQuoteOptionsRow(dsGLRater.tblQuoteOptionsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsGLRater.tblQuoteOptionsRow AddtblQuoteOptionsRow(
      Guid QuoteOptionGUID,
      Guid QuoteGUID,
      Guid LineGUID,
      Decimal Premium)
    {
      dsGLRater.tblQuoteOptionsRow row = (dsGLRater.tblQuoteOptionsRow) this.NewRow();
      object[] objArray = new object[5]
      {
        null,
        (object) QuoteOptionGUID,
        (object) QuoteGUID,
        (object) LineGUID,
        (object) Premium
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsGLRater.tblQuoteOptionsRow FindByQuoteOptionID(int QuoteOptionID)
    {
      return (dsGLRater.tblQuoteOptionsRow) this.Rows.Find(new object[1]
      {
        (object) QuoteOptionID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsGLRater.tblQuoteOptionsDataTable optionsDataTable = (dsGLRater.tblQuoteOptionsDataTable) base.Clone();
      optionsDataTable.InitVars();
      return (DataTable) optionsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsGLRater.tblQuoteOptionsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnQuoteOptionID = this.Columns["QuoteOptionID"];
      this.columnQuoteOptionGUID = this.Columns["QuoteOptionGUID"];
      this.columnQuoteGUID = this.Columns["QuoteGUID"];
      this.columnLineGUID = this.Columns["LineGUID"];
      this.columnPremium = this.Columns["Premium"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnQuoteOptionID = new DataColumn("QuoteOptionID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnQuoteOptionID);
      this.columnQuoteOptionGUID = new DataColumn("QuoteOptionGUID", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnQuoteOptionGUID);
      this.columnQuoteGUID = new DataColumn("QuoteGUID", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnQuoteGUID);
      this.columnLineGUID = new DataColumn("LineGUID", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLineGUID);
      this.columnPremium = new DataColumn("Premium", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPremium);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsGLRaterKey3", new DataColumn[1]
      {
        this.columnQuoteOptionID
      }, true));
      this.columnQuoteOptionID.AutoIncrement = true;
      this.columnQuoteOptionID.AllowDBNull = false;
      this.columnQuoteOptionID.ReadOnly = true;
      this.columnQuoteOptionID.Unique = true;
      this.columnQuoteOptionGUID.AllowDBNull = false;
      this.columnQuoteGUID.AllowDBNull = false;
      this.columnLineGUID.AllowDBNull = false;
      this.columnPremium.AllowDBNull = false;
      this.columnPremium.DefaultValue = (object) 0M;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsGLRater.tblQuoteOptionsRow NewtblQuoteOptionsRow()
    {
      return (dsGLRater.tblQuoteOptionsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsGLRater.tblQuoteOptionsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (dsGLRater.tblQuoteOptionsRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblQuoteOptionsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsGLRater.tblQuoteOptionsRowChangeEventHandler optionsRowChangedEvent = this.tblQuoteOptionsRowChangedEvent;
      if (optionsRowChangedEvent == null)
        return;
      optionsRowChangedEvent((object) this, new dsGLRater.tblQuoteOptionsRowChangeEvent((dsGLRater.tblQuoteOptionsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblQuoteOptionsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsGLRater.tblQuoteOptionsRowChangeEventHandler rowChangingEvent = this.tblQuoteOptionsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsGLRater.tblQuoteOptionsRowChangeEvent((dsGLRater.tblQuoteOptionsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblQuoteOptionsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsGLRater.tblQuoteOptionsRowChangeEventHandler optionsRowDeletedEvent = this.tblQuoteOptionsRowDeletedEvent;
      if (optionsRowDeletedEvent == null)
        return;
      optionsRowDeletedEvent((object) this, new dsGLRater.tblQuoteOptionsRowChangeEvent((dsGLRater.tblQuoteOptionsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblQuoteOptionsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsGLRater.tblQuoteOptionsRowChangeEventHandler rowDeletingEvent = this.tblQuoteOptionsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsGLRater.tblQuoteOptionsRowChangeEvent((dsGLRater.tblQuoteOptionsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemovetblQuoteOptionsRow(dsGLRater.tblQuoteOptionsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsGLRater dsGlRater = new dsGLRater();
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
        FixedValue = dsGlRater.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblQuoteOptionsDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsGlRater.GetSchemaSerializable();
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
  public class tblQuoteOptionGLDataTable : TypedTableBase<dsGLRater.tblQuoteOptionGLRow>
  {
    private DataColumn columnID;
    private DataColumn columnQuoteOptionID;
    private DataColumn columnOCC_ID;
    private DataColumn columnAGG_ID;
    private DataColumn columnPCO_ID;
    private DataColumn columnPAI_ID;
    private DataColumn columnFDL_ID;
    private DataColumn columnMED_ID;
    private DataColumn columnLLL_ID;
    private DataColumn columnNOH_ID;
    private DataColumn columnPDL_ID;
    private DataColumn columnDeductible;
    private DataColumn columnDeductibleDescriptionID;
    private DataColumn columnAggPerLocation;
    private DataColumn columnTerrorismDeclined;
    private DataColumn columnAdditionalComments;
    private DataColumn columnPremPremium;
    private DataColumn columnProdPremium;
    private DataColumn columnTerrPremium;
    private DataColumn columnClaimsMade;
    private DataColumn columnOccurrence;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblQuoteOptionGLDataTable()
    {
      this.TableName = "tblQuoteOptionGL";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblQuoteOptionGLDataTable(DataTable table)
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
    protected tblQuoteOptionGLDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn IDColumn => this.columnID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn QuoteOptionIDColumn => this.columnQuoteOptionID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn OCC_IDColumn => this.columnOCC_ID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn AGG_IDColumn => this.columnAGG_ID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn PCO_IDColumn => this.columnPCO_ID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn PAI_IDColumn => this.columnPAI_ID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn FDL_IDColumn => this.columnFDL_ID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn MED_IDColumn => this.columnMED_ID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn LLL_IDColumn => this.columnLLL_ID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn NOH_IDColumn => this.columnNOH_ID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn PDL_IDColumn => this.columnPDL_ID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn DeductibleColumn => this.columnDeductible;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn DeductibleDescriptionIDColumn => this.columnDeductibleDescriptionID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn AggPerLocationColumn => this.columnAggPerLocation;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn TerrorismDeclinedColumn => this.columnTerrorismDeclined;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn AdditionalCommentsColumn => this.columnAdditionalComments;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn PremPremiumColumn => this.columnPremPremium;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ProdPremiumColumn => this.columnProdPremium;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn TerrPremiumColumn => this.columnTerrPremium;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ClaimsMadeColumn => this.columnClaimsMade;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn OccurrenceColumn => this.columnOccurrence;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsGLRater.tblQuoteOptionGLRow this[int index]
    {
      get => (dsGLRater.tblQuoteOptionGLRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsGLRater.tblQuoteOptionGLRowChangeEventHandler tblQuoteOptionGLRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsGLRater.tblQuoteOptionGLRowChangeEventHandler tblQuoteOptionGLRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsGLRater.tblQuoteOptionGLRowChangeEventHandler tblQuoteOptionGLRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsGLRater.tblQuoteOptionGLRowChangeEventHandler tblQuoteOptionGLRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddtblQuoteOptionGLRow(dsGLRater.tblQuoteOptionGLRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsGLRater.tblQuoteOptionGLRow AddtblQuoteOptionGLRow(
      dsGLRater.tblQuoteOptionsRow parenttblQuoteOptionsRowBytblQuoteOptionstblQuoteOptionGL,
      int OCC_ID,
      int AGG_ID,
      int PCO_ID,
      int PAI_ID,
      int FDL_ID,
      int MED_ID,
      int LLL_ID,
      int NOH_ID,
      int PDL_ID,
      int Deductible,
      int DeductibleDescriptionID,
      bool AggPerLocation,
      bool TerrorismDeclined,
      string AdditionalComments,
      Decimal PremPremium,
      Decimal ProdPremium,
      Decimal TerrPremium,
      bool ClaimsMade,
      bool Occurrence)
    {
      dsGLRater.tblQuoteOptionGLRow row = (dsGLRater.tblQuoteOptionGLRow) this.NewRow();
      object[] objArray = new object[21]
      {
        null,
        null,
        (object) OCC_ID,
        (object) AGG_ID,
        (object) PCO_ID,
        (object) PAI_ID,
        (object) FDL_ID,
        (object) MED_ID,
        (object) LLL_ID,
        (object) NOH_ID,
        (object) PDL_ID,
        (object) Deductible,
        (object) DeductibleDescriptionID,
        (object) AggPerLocation,
        (object) TerrorismDeclined,
        (object) AdditionalComments,
        (object) PremPremium,
        (object) ProdPremium,
        (object) TerrPremium,
        (object) ClaimsMade,
        (object) Occurrence
      };
      if (parenttblQuoteOptionsRowBytblQuoteOptionstblQuoteOptionGL != null)
        objArray[1] = RuntimeHelpers.GetObjectValue(parenttblQuoteOptionsRowBytblQuoteOptionstblQuoteOptionGL[0]);
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsGLRater.tblQuoteOptionGLRow FindByID(int ID)
    {
      return (dsGLRater.tblQuoteOptionGLRow) this.Rows.Find(new object[1]
      {
        (object) ID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsGLRater.tblQuoteOptionGLDataTable optionGlDataTable = (dsGLRater.tblQuoteOptionGLDataTable) base.Clone();
      optionGlDataTable.InitVars();
      return (DataTable) optionGlDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsGLRater.tblQuoteOptionGLDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnID = this.Columns["ID"];
      this.columnQuoteOptionID = this.Columns["QuoteOptionID"];
      this.columnOCC_ID = this.Columns["OCC_ID"];
      this.columnAGG_ID = this.Columns["AGG_ID"];
      this.columnPCO_ID = this.Columns["PCO_ID"];
      this.columnPAI_ID = this.Columns["PAI_ID"];
      this.columnFDL_ID = this.Columns["FDL_ID"];
      this.columnMED_ID = this.Columns["MED_ID"];
      this.columnLLL_ID = this.Columns["LLL_ID"];
      this.columnNOH_ID = this.Columns["NOH_ID"];
      this.columnPDL_ID = this.Columns["PDL_ID"];
      this.columnDeductible = this.Columns["Deductible"];
      this.columnDeductibleDescriptionID = this.Columns["DeductibleDescriptionID"];
      this.columnAggPerLocation = this.Columns["AggPerLocation"];
      this.columnTerrorismDeclined = this.Columns["TerrorismDeclined"];
      this.columnAdditionalComments = this.Columns["AdditionalComments"];
      this.columnPremPremium = this.Columns["PremPremium"];
      this.columnProdPremium = this.Columns["ProdPremium"];
      this.columnTerrPremium = this.Columns["TerrPremium"];
      this.columnClaimsMade = this.Columns["ClaimsMade"];
      this.columnOccurrence = this.Columns["Occurrence"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnID = new DataColumn("ID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnID);
      this.columnQuoteOptionID = new DataColumn("QuoteOptionID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnQuoteOptionID);
      this.columnOCC_ID = new DataColumn("OCC_ID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnOCC_ID);
      this.columnAGG_ID = new DataColumn("AGG_ID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAGG_ID);
      this.columnPCO_ID = new DataColumn("PCO_ID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPCO_ID);
      this.columnPAI_ID = new DataColumn("PAI_ID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPAI_ID);
      this.columnFDL_ID = new DataColumn("FDL_ID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFDL_ID);
      this.columnMED_ID = new DataColumn("MED_ID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnMED_ID);
      this.columnLLL_ID = new DataColumn("LLL_ID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLLL_ID);
      this.columnNOH_ID = new DataColumn("NOH_ID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnNOH_ID);
      this.columnPDL_ID = new DataColumn("PDL_ID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPDL_ID);
      this.columnDeductible = new DataColumn("Deductible", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDeductible);
      this.columnDeductibleDescriptionID = new DataColumn("DeductibleDescriptionID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDeductibleDescriptionID);
      this.columnAggPerLocation = new DataColumn("AggPerLocation", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAggPerLocation);
      this.columnTerrorismDeclined = new DataColumn("TerrorismDeclined", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnTerrorismDeclined);
      this.columnAdditionalComments = new DataColumn("AdditionalComments", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAdditionalComments);
      this.columnPremPremium = new DataColumn("PremPremium", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPremPremium);
      this.columnProdPremium = new DataColumn("ProdPremium", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnProdPremium);
      this.columnTerrPremium = new DataColumn("TerrPremium", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnTerrPremium);
      this.columnClaimsMade = new DataColumn("ClaimsMade", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnClaimsMade);
      this.columnOccurrence = new DataColumn("Occurrence", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnOccurrence);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsGLRaterKey1", new DataColumn[1]
      {
        this.columnID
      }, true));
      this.columnID.AutoIncrement = true;
      this.columnID.AllowDBNull = false;
      this.columnID.ReadOnly = true;
      this.columnID.Unique = true;
      this.columnQuoteOptionID.AllowDBNull = false;
      this.columnDeductible.AllowDBNull = false;
      this.columnDeductible.DefaultValue = (object) 0;
      this.columnAggPerLocation.AllowDBNull = false;
      this.columnAggPerLocation.DefaultValue = (object) false;
      this.columnTerrorismDeclined.AllowDBNull = false;
      this.columnTerrorismDeclined.DefaultValue = (object) false;
      this.columnClaimsMade.AllowDBNull = false;
      this.columnClaimsMade.DefaultValue = (object) false;
      this.columnOccurrence.AllowDBNull = false;
      this.columnOccurrence.DefaultValue = (object) true;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsGLRater.tblQuoteOptionGLRow NewtblQuoteOptionGLRow()
    {
      return (dsGLRater.tblQuoteOptionGLRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsGLRater.tblQuoteOptionGLRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (dsGLRater.tblQuoteOptionGLRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblQuoteOptionGLRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsGLRater.tblQuoteOptionGLRowChangeEventHandler glRowChangedEvent = this.tblQuoteOptionGLRowChangedEvent;
      if (glRowChangedEvent == null)
        return;
      glRowChangedEvent((object) this, new dsGLRater.tblQuoteOptionGLRowChangeEvent((dsGLRater.tblQuoteOptionGLRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblQuoteOptionGLRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsGLRater.tblQuoteOptionGLRowChangeEventHandler rowChangingEvent = this.tblQuoteOptionGLRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsGLRater.tblQuoteOptionGLRowChangeEvent((dsGLRater.tblQuoteOptionGLRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblQuoteOptionGLRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsGLRater.tblQuoteOptionGLRowChangeEventHandler glRowDeletedEvent = this.tblQuoteOptionGLRowDeletedEvent;
      if (glRowDeletedEvent == null)
        return;
      glRowDeletedEvent((object) this, new dsGLRater.tblQuoteOptionGLRowChangeEvent((dsGLRater.tblQuoteOptionGLRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblQuoteOptionGLRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsGLRater.tblQuoteOptionGLRowChangeEventHandler rowDeletingEvent = this.tblQuoteOptionGLRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsGLRater.tblQuoteOptionGLRowChangeEvent((dsGLRater.tblQuoteOptionGLRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemovetblQuoteOptionGLRow(dsGLRater.tblQuoteOptionGLRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsGLRater dsGlRater = new dsGLRater();
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
        FixedValue = dsGlRater.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblQuoteOptionGLDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsGlRater.GetSchemaSerializable();
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

  public class tblGLLimitsRow : DataRow
  {
    private dsGLRater.tblGLLimitsDataTable tabletblGLLimits;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblGLLimitsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblGLLimits = (dsGLRater.tblGLLimitsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int ID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblGLLimits.IDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ID' in table 'tblGLLimits' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblGLLimits.IDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string LimitCode
    {
      get => Conversions.ToString(this[this.tabletblGLLimits.LimitCodeColumn]);
      set => this[this.tabletblGLLimits.LimitCodeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int Limit
    {
      get => Conversions.ToInteger(this[this.tabletblGLLimits.LimitColumn]);
      set => this[this.tabletblGLLimits.LimitColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string LimitDisplay
    {
      get => Conversions.ToString(this[this.tabletblGLLimits.LimitDisplayColumn]);
      set => this[this.tabletblGLLimits.LimitDisplayColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsIDNull() => this.IsNull(this.tabletblGLLimits.IDColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetIDNull()
    {
      this[this.tabletblGLLimits.IDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class lstGLDeductibleDescriptionsRow : DataRow
  {
    private dsGLRater.lstGLDeductibleDescriptionsDataTable tablelstGLDeductibleDescriptions;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal lstGLDeductibleDescriptionsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablelstGLDeductibleDescriptions = (dsGLRater.lstGLDeductibleDescriptionsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int ID
    {
      get => Conversions.ToInteger(this[this.tablelstGLDeductibleDescriptions.IDColumn]);
      set => this[this.tablelstGLDeductibleDescriptions.IDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string DeductibleDescription
    {
      get
      {
        return Conversions.ToString(this[this.tablelstGLDeductibleDescriptions.DeductibleDescriptionColumn]);
      }
      set
      {
        this[this.tablelstGLDeductibleDescriptions.DeductibleDescriptionColumn] = (object) value;
      }
    }
  }

  public class tblQuoteOptionsRow : DataRow
  {
    private dsGLRater.tblQuoteOptionsDataTable tabletblQuoteOptions;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblQuoteOptionsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblQuoteOptions = (dsGLRater.tblQuoteOptionsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int QuoteOptionID
    {
      get => Conversions.ToInteger(this[this.tabletblQuoteOptions.QuoteOptionIDColumn]);
      set => this[this.tabletblQuoteOptions.QuoteOptionIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Guid QuoteOptionGUID
    {
      get
      {
        object obj = this[this.tabletblQuoteOptions.QuoteOptionGUIDColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tabletblQuoteOptions.QuoteOptionGUIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Guid QuoteGUID
    {
      get
      {
        object obj = this[this.tabletblQuoteOptions.QuoteGUIDColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tabletblQuoteOptions.QuoteGUIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Guid LineGUID
    {
      get
      {
        object obj = this[this.tabletblQuoteOptions.LineGUIDColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tabletblQuoteOptions.LineGUIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal Premium
    {
      get => Conversions.ToDecimal(this[this.tabletblQuoteOptions.PremiumColumn]);
      set => this[this.tabletblQuoteOptions.PremiumColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsGLRater.tblQuoteOptionGLRow[] GettblQuoteOptionGLRows()
    {
      return this.Table.ChildRelations["tblQuoteOptionstblQuoteOptionGL"] != null ? (dsGLRater.tblQuoteOptionGLRow[]) this.GetChildRows(this.Table.ChildRelations["tblQuoteOptionstblQuoteOptionGL"]) : new dsGLRater.tblQuoteOptionGLRow[0];
    }
  }

  public class tblQuoteOptionGLRow : DataRow
  {
    private dsGLRater.tblQuoteOptionGLDataTable tabletblQuoteOptionGL;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblQuoteOptionGLRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblQuoteOptionGL = (dsGLRater.tblQuoteOptionGLDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int ID
    {
      get => Conversions.ToInteger(this[this.tabletblQuoteOptionGL.IDColumn]);
      set => this[this.tabletblQuoteOptionGL.IDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int QuoteOptionID
    {
      get => Conversions.ToInteger(this[this.tabletblQuoteOptionGL.QuoteOptionIDColumn]);
      set => this[this.tabletblQuoteOptionGL.QuoteOptionIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int OCC_ID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblQuoteOptionGL.OCC_IDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'OCC_ID' in table 'tblQuoteOptionGL' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuoteOptionGL.OCC_IDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int AGG_ID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblQuoteOptionGL.AGG_IDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'AGG_ID' in table 'tblQuoteOptionGL' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuoteOptionGL.AGG_IDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int PCO_ID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblQuoteOptionGL.PCO_IDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'PCO_ID' in table 'tblQuoteOptionGL' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuoteOptionGL.PCO_IDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int PAI_ID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblQuoteOptionGL.PAI_IDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'PAI_ID' in table 'tblQuoteOptionGL' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuoteOptionGL.PAI_IDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int FDL_ID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblQuoteOptionGL.FDL_IDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'FDL_ID' in table 'tblQuoteOptionGL' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuoteOptionGL.FDL_IDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int MED_ID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblQuoteOptionGL.MED_IDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'MED_ID' in table 'tblQuoteOptionGL' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuoteOptionGL.MED_IDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int LLL_ID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblQuoteOptionGL.LLL_IDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'LLL_ID' in table 'tblQuoteOptionGL' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuoteOptionGL.LLL_IDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int NOH_ID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblQuoteOptionGL.NOH_IDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'NOH_ID' in table 'tblQuoteOptionGL' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuoteOptionGL.NOH_IDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int PDL_ID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblQuoteOptionGL.PDL_IDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'PDL_ID' in table 'tblQuoteOptionGL' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuoteOptionGL.PDL_IDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int Deductible
    {
      get => Conversions.ToInteger(this[this.tabletblQuoteOptionGL.DeductibleColumn]);
      set => this[this.tabletblQuoteOptionGL.DeductibleColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int DeductibleDescriptionID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblQuoteOptionGL.DeductibleDescriptionIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DeductibleDescriptionID' in table 'tblQuoteOptionGL' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuoteOptionGL.DeductibleDescriptionIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool AggPerLocation
    {
      get => Conversions.ToBoolean(this[this.tabletblQuoteOptionGL.AggPerLocationColumn]);
      set => this[this.tabletblQuoteOptionGL.AggPerLocationColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool TerrorismDeclined
    {
      get => Conversions.ToBoolean(this[this.tabletblQuoteOptionGL.TerrorismDeclinedColumn]);
      set => this[this.tabletblQuoteOptionGL.TerrorismDeclinedColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string AdditionalComments
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblQuoteOptionGL.AdditionalCommentsColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'AdditionalComments' in table 'tblQuoteOptionGL' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuoteOptionGL.AdditionalCommentsColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal PremPremium
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tabletblQuoteOptionGL.PremPremiumColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'PremPremium' in table 'tblQuoteOptionGL' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuoteOptionGL.PremPremiumColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal ProdPremium
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tabletblQuoteOptionGL.ProdPremiumColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ProdPremium' in table 'tblQuoteOptionGL' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuoteOptionGL.ProdPremiumColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal TerrPremium
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tabletblQuoteOptionGL.TerrPremiumColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'TerrPremium' in table 'tblQuoteOptionGL' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuoteOptionGL.TerrPremiumColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool ClaimsMade
    {
      get => Conversions.ToBoolean(this[this.tabletblQuoteOptionGL.ClaimsMadeColumn]);
      set => this[this.tabletblQuoteOptionGL.ClaimsMadeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool Occurrence
    {
      get => Conversions.ToBoolean(this[this.tabletblQuoteOptionGL.OccurrenceColumn]);
      set => this[this.tabletblQuoteOptionGL.OccurrenceColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsGLRater.tblQuoteOptionsRow tblQuoteOptionsRow
    {
      get
      {
        return (dsGLRater.tblQuoteOptionsRow) this.GetParentRow(this.Table.ParentRelations["tblQuoteOptionstblQuoteOptionGL"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["tblQuoteOptionstblQuoteOptionGL"]);
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsOCC_IDNull() => this.IsNull(this.tabletblQuoteOptionGL.OCC_IDColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetOCC_IDNull()
    {
      this[this.tabletblQuoteOptionGL.OCC_IDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsAGG_IDNull() => this.IsNull(this.tabletblQuoteOptionGL.AGG_IDColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetAGG_IDNull()
    {
      this[this.tabletblQuoteOptionGL.AGG_IDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsPCO_IDNull() => this.IsNull(this.tabletblQuoteOptionGL.PCO_IDColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetPCO_IDNull()
    {
      this[this.tabletblQuoteOptionGL.PCO_IDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsPAI_IDNull() => this.IsNull(this.tabletblQuoteOptionGL.PAI_IDColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetPAI_IDNull()
    {
      this[this.tabletblQuoteOptionGL.PAI_IDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsFDL_IDNull() => this.IsNull(this.tabletblQuoteOptionGL.FDL_IDColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetFDL_IDNull()
    {
      this[this.tabletblQuoteOptionGL.FDL_IDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsMED_IDNull() => this.IsNull(this.tabletblQuoteOptionGL.MED_IDColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetMED_IDNull()
    {
      this[this.tabletblQuoteOptionGL.MED_IDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsLLL_IDNull() => this.IsNull(this.tabletblQuoteOptionGL.LLL_IDColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetLLL_IDNull()
    {
      this[this.tabletblQuoteOptionGL.LLL_IDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsNOH_IDNull() => this.IsNull(this.tabletblQuoteOptionGL.NOH_IDColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetNOH_IDNull()
    {
      this[this.tabletblQuoteOptionGL.NOH_IDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsPDL_IDNull() => this.IsNull(this.tabletblQuoteOptionGL.PDL_IDColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetPDL_IDNull()
    {
      this[this.tabletblQuoteOptionGL.PDL_IDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsDeductibleDescriptionIDNull()
    {
      return this.IsNull(this.tabletblQuoteOptionGL.DeductibleDescriptionIDColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetDeductibleDescriptionIDNull()
    {
      this[this.tabletblQuoteOptionGL.DeductibleDescriptionIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsAdditionalCommentsNull()
    {
      return this.IsNull(this.tabletblQuoteOptionGL.AdditionalCommentsColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetAdditionalCommentsNull()
    {
      this[this.tabletblQuoteOptionGL.AdditionalCommentsColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsPremPremiumNull() => this.IsNull(this.tabletblQuoteOptionGL.PremPremiumColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetPremPremiumNull()
    {
      this[this.tabletblQuoteOptionGL.PremPremiumColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsProdPremiumNull() => this.IsNull(this.tabletblQuoteOptionGL.ProdPremiumColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetProdPremiumNull()
    {
      this[this.tabletblQuoteOptionGL.ProdPremiumColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsTerrPremiumNull() => this.IsNull(this.tabletblQuoteOptionGL.TerrPremiumColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetTerrPremiumNull()
    {
      this[this.tabletblQuoteOptionGL.TerrPremiumColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class tblGLLimitsRowChangeEvent : EventArgs
  {
    private dsGLRater.tblGLLimitsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblGLLimitsRowChangeEvent(dsGLRater.tblGLLimitsRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsGLRater.tblGLLimitsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class lstGLDeductibleDescriptionsRowChangeEvent : EventArgs
  {
    private dsGLRater.lstGLDeductibleDescriptionsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public lstGLDeductibleDescriptionsRowChangeEvent(
      dsGLRater.lstGLDeductibleDescriptionsRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsGLRater.lstGLDeductibleDescriptionsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class tblQuoteOptionsRowChangeEvent : EventArgs
  {
    private dsGLRater.tblQuoteOptionsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblQuoteOptionsRowChangeEvent(dsGLRater.tblQuoteOptionsRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsGLRater.tblQuoteOptionsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class tblQuoteOptionGLRowChangeEvent : EventArgs
  {
    private dsGLRater.tblQuoteOptionGLRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblQuoteOptionGLRowChangeEvent(dsGLRater.tblQuoteOptionGLRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsGLRater.tblQuoteOptionGLRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }
}
