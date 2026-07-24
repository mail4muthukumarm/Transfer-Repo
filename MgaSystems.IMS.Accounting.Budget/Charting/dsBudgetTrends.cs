// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Budget.Charting.dsBudgetTrends
// Assembly: MgaSystems.IMS.Accounting.Budget, Version=2.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6BC25DF1-D5D5-4DAC-8821-336F88BA639E
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Budget.dll

using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

#nullable disable
namespace MGASystems.IMS.Accounting.Budget.Charting;

[DesignerCategory("code")]
[ToolboxItem(true)]
[XmlSchemaProvider("GetTypedDataSetSchema")]
[XmlRoot("dsBudgetTrends")]
[HelpKeyword("vs.data.DataSet")]
[Serializable]
public class dsBudgetTrends : DataSet
{
  private dsBudgetTrends.TrendsDataTable tableTrends;
  private SchemaSerializationMode _schemaSerializationMode = SchemaSerializationMode.IncludeSchema;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public dsBudgetTrends()
  {
    this.BeginInit();
    this.InitClass();
    CollectionChangeEventHandler changeEventHandler = new CollectionChangeEventHandler(this.SchemaChanged);
    base.Tables.CollectionChanged += changeEventHandler;
    base.Relations.CollectionChanged += changeEventHandler;
    this.EndInit();
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  protected dsBudgetTrends(SerializationInfo info, StreamingContext context)
    : base(info, context, false)
  {
    if (this.IsBinarySerialized(info, context))
    {
      this.InitVars(false);
      CollectionChangeEventHandler changeEventHandler = new CollectionChangeEventHandler(this.SchemaChanged);
      this.Tables.CollectionChanged += changeEventHandler;
      this.Relations.CollectionChanged += changeEventHandler;
    }
    else
    {
      string s = (string) info.GetValue("XmlSchema", typeof (string));
      if (this.DetermineSchemaSerializationMode(info, context) == SchemaSerializationMode.IncludeSchema)
      {
        DataSet dataSet = new DataSet();
        dataSet.ReadXmlSchema((XmlReader) new XmlTextReader((TextReader) new StringReader(s)));
        if (dataSet.Tables[nameof (Trends)] != null)
          base.Tables.Add((DataTable) new dsBudgetTrends.TrendsDataTable(dataSet.Tables[nameof (Trends)]));
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
  public dsBudgetTrends.TrendsDataTable Trends => this.tableTrends;

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
    dsBudgetTrends dsBudgetTrends = (dsBudgetTrends) base.Clone();
    dsBudgetTrends.InitVars();
    dsBudgetTrends.SchemaSerializationMode = this.SchemaSerializationMode;
    return (DataSet) dsBudgetTrends;
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
      if (dataSet.Tables["Trends"] != null)
        base.Tables.Add((DataTable) new dsBudgetTrends.TrendsDataTable(dataSet.Tables["Trends"]));
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
    this.tableTrends = (dsBudgetTrends.TrendsDataTable) base.Tables["Trends"];
    if (!initTable || this.tableTrends == null)
      return;
    this.tableTrends.InitVars();
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private void InitClass()
  {
    this.DataSetName = nameof (dsBudgetTrends);
    this.Prefix = "";
    this.Namespace = "http://tempuri.org/dsBudgetTrends.xsd";
    this.EnforceConstraints = true;
    this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.tableTrends = new dsBudgetTrends.TrendsDataTable();
    base.Tables.Add((DataTable) this.tableTrends);
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializeTrends() => false;

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
    dsBudgetTrends dsBudgetTrends = new dsBudgetTrends();
    XmlSchemaComplexType typedDataSetSchema = new XmlSchemaComplexType();
    XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
    xmlSchemaSequence.Items.Add((XmlSchemaObject) new XmlSchemaAny()
    {
      Namespace = dsBudgetTrends.Namespace
    });
    typedDataSetSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
    XmlSchema schemaSerializable = dsBudgetTrends.GetSchemaSerializable();
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
              return typedDataSetSchema;
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
    return typedDataSetSchema;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void TrendsRowChangeEventHandler(
    object sender,
    dsBudgetTrends.TrendsRowChangeEvent e);

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class TrendsDataTable : TypedTableBase<dsBudgetTrends.TrendsRow>
  {
    private DataColumn columnTrendType;
    private DataColumn columnF1;
    private DataColumn columnF2;
    private DataColumn columnF3;
    private DataColumn columnF4;
    private DataColumn columnF5;
    private DataColumn columnF6;
    private DataColumn columnF7;
    private DataColumn columnF8;
    private DataColumn columnF9;
    private DataColumn columnF10;
    private DataColumn columnF11;
    private DataColumn columnF12;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public TrendsDataTable()
    {
      this.TableName = "Trends";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal TrendsDataTable(DataTable table)
    {
      this.TableName = table.TableName;
      if (table.CaseSensitive != table.DataSet.CaseSensitive)
        this.CaseSensitive = table.CaseSensitive;
      if (table.Locale.ToString() != table.DataSet.Locale.ToString())
        this.Locale = table.Locale;
      if (table.Namespace != table.DataSet.Namespace)
        this.Namespace = table.Namespace;
      this.Prefix = table.Prefix;
      this.MinimumCapacity = table.MinimumCapacity;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected TrendsDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn TrendTypeColumn => this.columnTrendType;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn F1Column => this.columnF1;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn F2Column => this.columnF2;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn F3Column => this.columnF3;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn F4Column => this.columnF4;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn F5Column => this.columnF5;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn F6Column => this.columnF6;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn F7Column => this.columnF7;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn F8Column => this.columnF8;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn F9Column => this.columnF9;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn F10Column => this.columnF10;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn F11Column => this.columnF11;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn F12Column => this.columnF12;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsBudgetTrends.TrendsRow this[int index] => (dsBudgetTrends.TrendsRow) this.Rows[index];

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsBudgetTrends.TrendsRowChangeEventHandler TrendsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsBudgetTrends.TrendsRowChangeEventHandler TrendsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsBudgetTrends.TrendsRowChangeEventHandler TrendsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsBudgetTrends.TrendsRowChangeEventHandler TrendsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddTrendsRow(dsBudgetTrends.TrendsRow row) => this.Rows.Add((DataRow) row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsBudgetTrends.TrendsRow AddTrendsRow(
      string TrendType,
      Decimal F1,
      Decimal F2,
      Decimal F3,
      Decimal F4,
      Decimal F5,
      Decimal F6,
      Decimal F7,
      Decimal F8,
      Decimal F9,
      Decimal F10,
      Decimal F11,
      Decimal F12)
    {
      dsBudgetTrends.TrendsRow row = (dsBudgetTrends.TrendsRow) this.NewRow();
      object[] objArray = new object[13]
      {
        (object) TrendType,
        (object) F1,
        (object) F2,
        (object) F3,
        (object) F4,
        (object) F5,
        (object) F6,
        (object) F7,
        (object) F8,
        (object) F9,
        (object) F10,
        (object) F11,
        (object) F12
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsBudgetTrends.TrendsDataTable trendsDataTable = (dsBudgetTrends.TrendsDataTable) base.Clone();
      trendsDataTable.InitVars();
      return (DataTable) trendsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsBudgetTrends.TrendsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnTrendType = this.Columns["TrendType"];
      this.columnF1 = this.Columns["F1"];
      this.columnF2 = this.Columns["F2"];
      this.columnF3 = this.Columns["F3"];
      this.columnF4 = this.Columns["F4"];
      this.columnF5 = this.Columns["F5"];
      this.columnF6 = this.Columns["F6"];
      this.columnF7 = this.Columns["F7"];
      this.columnF8 = this.Columns["F8"];
      this.columnF9 = this.Columns["F9"];
      this.columnF10 = this.Columns["F10"];
      this.columnF11 = this.Columns["F11"];
      this.columnF12 = this.Columns["F12"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnTrendType = new DataColumn("TrendType", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnTrendType);
      this.columnF1 = new DataColumn("F1", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnF1);
      this.columnF2 = new DataColumn("F2", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnF2);
      this.columnF3 = new DataColumn("F3", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnF3);
      this.columnF4 = new DataColumn("F4", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnF4);
      this.columnF5 = new DataColumn("F5", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnF5);
      this.columnF6 = new DataColumn("F6", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnF6);
      this.columnF7 = new DataColumn("F7", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnF7);
      this.columnF8 = new DataColumn("F8", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnF8);
      this.columnF9 = new DataColumn("F9", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnF9);
      this.columnF10 = new DataColumn("F10", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnF10);
      this.columnF11 = new DataColumn("F11", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnF11);
      this.columnF12 = new DataColumn("F12", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnF12);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsBudgetTrends.TrendsRow NewTrendsRow() => (dsBudgetTrends.TrendsRow) this.NewRow();

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsBudgetTrends.TrendsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (dsBudgetTrends.TrendsRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      if (this.TrendsRowChanged == null)
        return;
      this.TrendsRowChanged((object) this, new dsBudgetTrends.TrendsRowChangeEvent((dsBudgetTrends.TrendsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      if (this.TrendsRowChanging == null)
        return;
      this.TrendsRowChanging((object) this, new dsBudgetTrends.TrendsRowChangeEvent((dsBudgetTrends.TrendsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      if (this.TrendsRowDeleted == null)
        return;
      this.TrendsRowDeleted((object) this, new dsBudgetTrends.TrendsRowChangeEvent((dsBudgetTrends.TrendsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      if (this.TrendsRowDeleting == null)
        return;
      this.TrendsRowDeleting((object) this, new dsBudgetTrends.TrendsRowChangeEvent((dsBudgetTrends.TrendsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemoveTrendsRow(dsBudgetTrends.TrendsRow row) => this.Rows.Remove((DataRow) row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType typedTableSchema = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsBudgetTrends dsBudgetTrends = new dsBudgetTrends();
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
      typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "namespace",
        FixedValue = dsBudgetTrends.Namespace
      });
      typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (TrendsDataTable)
      });
      typedTableSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsBudgetTrends.GetSchemaSerializable();
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
                return typedTableSchema;
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
      return typedTableSchema;
    }
  }

  public class TrendsRow : DataRow
  {
    private dsBudgetTrends.TrendsDataTable tableTrends;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal TrendsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableTrends = (dsBudgetTrends.TrendsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string TrendType
    {
      get
      {
        try
        {
          return (string) this[this.tableTrends.TrendTypeColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'TrendType' in table 'Trends' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableTrends.TrendTypeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal F1
    {
      get
      {
        try
        {
          return (Decimal) this[this.tableTrends.F1Column];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'F1' in table 'Trends' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableTrends.F1Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal F2
    {
      get
      {
        try
        {
          return (Decimal) this[this.tableTrends.F2Column];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'F2' in table 'Trends' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableTrends.F2Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal F3
    {
      get
      {
        try
        {
          return (Decimal) this[this.tableTrends.F3Column];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'F3' in table 'Trends' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableTrends.F3Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal F4
    {
      get
      {
        try
        {
          return (Decimal) this[this.tableTrends.F4Column];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'F4' in table 'Trends' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableTrends.F4Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal F5
    {
      get
      {
        try
        {
          return (Decimal) this[this.tableTrends.F5Column];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'F5' in table 'Trends' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableTrends.F5Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal F6
    {
      get
      {
        try
        {
          return (Decimal) this[this.tableTrends.F6Column];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'F6' in table 'Trends' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableTrends.F6Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal F7
    {
      get
      {
        try
        {
          return (Decimal) this[this.tableTrends.F7Column];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'F7' in table 'Trends' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableTrends.F7Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal F8
    {
      get
      {
        try
        {
          return (Decimal) this[this.tableTrends.F8Column];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'F8' in table 'Trends' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableTrends.F8Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal F9
    {
      get
      {
        try
        {
          return (Decimal) this[this.tableTrends.F9Column];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'F9' in table 'Trends' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableTrends.F9Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal F10
    {
      get
      {
        try
        {
          return (Decimal) this[this.tableTrends.F10Column];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'F10' in table 'Trends' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableTrends.F10Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal F11
    {
      get
      {
        try
        {
          return (Decimal) this[this.tableTrends.F11Column];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'F11' in table 'Trends' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableTrends.F11Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal F12
    {
      get
      {
        try
        {
          return (Decimal) this[this.tableTrends.F12Column];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'F12' in table 'Trends' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableTrends.F12Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsTrendTypeNull() => this.IsNull(this.tableTrends.TrendTypeColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetTrendTypeNull() => this[this.tableTrends.TrendTypeColumn] = Convert.DBNull;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsF1Null() => this.IsNull(this.tableTrends.F1Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetF1Null() => this[this.tableTrends.F1Column] = Convert.DBNull;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsF2Null() => this.IsNull(this.tableTrends.F2Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetF2Null() => this[this.tableTrends.F2Column] = Convert.DBNull;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsF3Null() => this.IsNull(this.tableTrends.F3Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetF3Null() => this[this.tableTrends.F3Column] = Convert.DBNull;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsF4Null() => this.IsNull(this.tableTrends.F4Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetF4Null() => this[this.tableTrends.F4Column] = Convert.DBNull;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsF5Null() => this.IsNull(this.tableTrends.F5Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetF5Null() => this[this.tableTrends.F5Column] = Convert.DBNull;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsF6Null() => this.IsNull(this.tableTrends.F6Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetF6Null() => this[this.tableTrends.F6Column] = Convert.DBNull;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsF7Null() => this.IsNull(this.tableTrends.F7Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetF7Null() => this[this.tableTrends.F7Column] = Convert.DBNull;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsF8Null() => this.IsNull(this.tableTrends.F8Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetF8Null() => this[this.tableTrends.F8Column] = Convert.DBNull;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsF9Null() => this.IsNull(this.tableTrends.F9Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetF9Null() => this[this.tableTrends.F9Column] = Convert.DBNull;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsF10Null() => this.IsNull(this.tableTrends.F10Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetF10Null() => this[this.tableTrends.F10Column] = Convert.DBNull;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsF11Null() => this.IsNull(this.tableTrends.F11Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetF11Null() => this[this.tableTrends.F11Column] = Convert.DBNull;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsF12Null() => this.IsNull(this.tableTrends.F12Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetF12Null() => this[this.tableTrends.F12Column] = Convert.DBNull;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class TrendsRowChangeEvent : EventArgs
  {
    private dsBudgetTrends.TrendsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public TrendsRowChangeEvent(dsBudgetTrends.TrendsRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsBudgetTrends.TrendsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }
}
