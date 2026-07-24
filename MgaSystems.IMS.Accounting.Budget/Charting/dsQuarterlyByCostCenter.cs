// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Budget.Charting.dsQuarterlyByCostCenter
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
[XmlRoot("dsQuarterlyByCostCenter")]
[HelpKeyword("vs.data.DataSet")]
[Serializable]
public class dsQuarterlyByCostCenter : DataSet
{
  private dsQuarterlyByCostCenter.QuarterlyByCostCenter_BudgetDataTable tableQuarterlyByCostCenter_Budget;
  private dsQuarterlyByCostCenter.QuarterlyByCostCenter_ActualDataTable tableQuarterlyByCostCenter_Actual;
  private SchemaSerializationMode _schemaSerializationMode = SchemaSerializationMode.IncludeSchema;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public dsQuarterlyByCostCenter()
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
  protected dsQuarterlyByCostCenter(SerializationInfo info, StreamingContext context)
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
        if (dataSet.Tables[nameof (QuarterlyByCostCenter_Budget)] != null)
          base.Tables.Add((DataTable) new dsQuarterlyByCostCenter.QuarterlyByCostCenter_BudgetDataTable(dataSet.Tables[nameof (QuarterlyByCostCenter_Budget)]));
        if (dataSet.Tables[nameof (QuarterlyByCostCenter_Actual)] != null)
          base.Tables.Add((DataTable) new dsQuarterlyByCostCenter.QuarterlyByCostCenter_ActualDataTable(dataSet.Tables[nameof (QuarterlyByCostCenter_Actual)]));
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
  public dsQuarterlyByCostCenter.QuarterlyByCostCenter_BudgetDataTable QuarterlyByCostCenter_Budget
  {
    get => this.tableQuarterlyByCostCenter_Budget;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsQuarterlyByCostCenter.QuarterlyByCostCenter_ActualDataTable QuarterlyByCostCenter_Actual
  {
    get => this.tableQuarterlyByCostCenter_Actual;
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
    dsQuarterlyByCostCenter quarterlyByCostCenter = (dsQuarterlyByCostCenter) base.Clone();
    quarterlyByCostCenter.InitVars();
    quarterlyByCostCenter.SchemaSerializationMode = this.SchemaSerializationMode;
    return (DataSet) quarterlyByCostCenter;
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
      if (dataSet.Tables["QuarterlyByCostCenter_Budget"] != null)
        base.Tables.Add((DataTable) new dsQuarterlyByCostCenter.QuarterlyByCostCenter_BudgetDataTable(dataSet.Tables["QuarterlyByCostCenter_Budget"]));
      if (dataSet.Tables["QuarterlyByCostCenter_Actual"] != null)
        base.Tables.Add((DataTable) new dsQuarterlyByCostCenter.QuarterlyByCostCenter_ActualDataTable(dataSet.Tables["QuarterlyByCostCenter_Actual"]));
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
    this.tableQuarterlyByCostCenter_Budget = (dsQuarterlyByCostCenter.QuarterlyByCostCenter_BudgetDataTable) base.Tables["QuarterlyByCostCenter_Budget"];
    if (initTable && this.tableQuarterlyByCostCenter_Budget != null)
      this.tableQuarterlyByCostCenter_Budget.InitVars();
    this.tableQuarterlyByCostCenter_Actual = (dsQuarterlyByCostCenter.QuarterlyByCostCenter_ActualDataTable) base.Tables["QuarterlyByCostCenter_Actual"];
    if (!initTable || this.tableQuarterlyByCostCenter_Actual == null)
      return;
    this.tableQuarterlyByCostCenter_Actual.InitVars();
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private void InitClass()
  {
    this.DataSetName = nameof (dsQuarterlyByCostCenter);
    this.Prefix = "";
    this.Namespace = "http://tempuri.org/dsQuarterlyByCostCenter.xsd";
    this.EnforceConstraints = true;
    this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.tableQuarterlyByCostCenter_Budget = new dsQuarterlyByCostCenter.QuarterlyByCostCenter_BudgetDataTable();
    base.Tables.Add((DataTable) this.tableQuarterlyByCostCenter_Budget);
    this.tableQuarterlyByCostCenter_Actual = new dsQuarterlyByCostCenter.QuarterlyByCostCenter_ActualDataTable();
    base.Tables.Add((DataTable) this.tableQuarterlyByCostCenter_Actual);
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializeQuarterlyByCostCenter_Budget() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializeQuarterlyByCostCenter_Actual() => false;

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
    dsQuarterlyByCostCenter quarterlyByCostCenter = new dsQuarterlyByCostCenter();
    XmlSchemaComplexType typedDataSetSchema = new XmlSchemaComplexType();
    XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
    xmlSchemaSequence.Items.Add((XmlSchemaObject) new XmlSchemaAny()
    {
      Namespace = quarterlyByCostCenter.Namespace
    });
    typedDataSetSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
    XmlSchema schemaSerializable = quarterlyByCostCenter.GetSchemaSerializable();
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
  public delegate void QuarterlyByCostCenter_BudgetRowChangeEventHandler(
    object sender,
    dsQuarterlyByCostCenter.QuarterlyByCostCenter_BudgetRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void QuarterlyByCostCenter_ActualRowChangeEventHandler(
    object sender,
    dsQuarterlyByCostCenter.QuarterlyByCostCenter_ActualRowChangeEvent e);

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class QuarterlyByCostCenter_BudgetDataTable : 
    TypedTableBase<dsQuarterlyByCostCenter.QuarterlyByCostCenter_BudgetRow>
  {
    private DataColumn columnQuarter;
    private DataColumn columnDefaultCostCenter;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public QuarterlyByCostCenter_BudgetDataTable()
    {
      this.TableName = "QuarterlyByCostCenter_Budget";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal QuarterlyByCostCenter_BudgetDataTable(DataTable table)
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
    protected QuarterlyByCostCenter_BudgetDataTable(
      SerializationInfo info,
      StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn QuarterColumn => this.columnQuarter;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn DefaultCostCenterColumn => this.columnDefaultCostCenter;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsQuarterlyByCostCenter.QuarterlyByCostCenter_BudgetRow this[int index]
    {
      get => (dsQuarterlyByCostCenter.QuarterlyByCostCenter_BudgetRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsQuarterlyByCostCenter.QuarterlyByCostCenter_BudgetRowChangeEventHandler QuarterlyByCostCenter_BudgetRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsQuarterlyByCostCenter.QuarterlyByCostCenter_BudgetRowChangeEventHandler QuarterlyByCostCenter_BudgetRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsQuarterlyByCostCenter.QuarterlyByCostCenter_BudgetRowChangeEventHandler QuarterlyByCostCenter_BudgetRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsQuarterlyByCostCenter.QuarterlyByCostCenter_BudgetRowChangeEventHandler QuarterlyByCostCenter_BudgetRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddQuarterlyByCostCenter_BudgetRow(
      dsQuarterlyByCostCenter.QuarterlyByCostCenter_BudgetRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsQuarterlyByCostCenter.QuarterlyByCostCenter_BudgetRow AddQuarterlyByCostCenter_BudgetRow(
      string Quarter,
      Decimal DefaultCostCenter)
    {
      dsQuarterlyByCostCenter.QuarterlyByCostCenter_BudgetRow row = (dsQuarterlyByCostCenter.QuarterlyByCostCenter_BudgetRow) this.NewRow();
      object[] objArray = new object[2]
      {
        (object) Quarter,
        (object) DefaultCostCenter
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsQuarterlyByCostCenter.QuarterlyByCostCenter_BudgetDataTable centerBudgetDataTable = (dsQuarterlyByCostCenter.QuarterlyByCostCenter_BudgetDataTable) base.Clone();
      centerBudgetDataTable.InitVars();
      return (DataTable) centerBudgetDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsQuarterlyByCostCenter.QuarterlyByCostCenter_BudgetDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnQuarter = this.Columns["Quarter"];
      this.columnDefaultCostCenter = this.Columns["DefaultCostCenter"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnQuarter = new DataColumn("Quarter", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnQuarter);
      this.columnDefaultCostCenter = new DataColumn("DefaultCostCenter", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDefaultCostCenter);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsQuarterlyByCostCenter.QuarterlyByCostCenter_BudgetRow NewQuarterlyByCostCenter_BudgetRow()
    {
      return (dsQuarterlyByCostCenter.QuarterlyByCostCenter_BudgetRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsQuarterlyByCostCenter.QuarterlyByCostCenter_BudgetRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType()
    {
      return typeof (dsQuarterlyByCostCenter.QuarterlyByCostCenter_BudgetRow);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      if (this.QuarterlyByCostCenter_BudgetRowChanged == null)
        return;
      this.QuarterlyByCostCenter_BudgetRowChanged((object) this, new dsQuarterlyByCostCenter.QuarterlyByCostCenter_BudgetRowChangeEvent((dsQuarterlyByCostCenter.QuarterlyByCostCenter_BudgetRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      if (this.QuarterlyByCostCenter_BudgetRowChanging == null)
        return;
      this.QuarterlyByCostCenter_BudgetRowChanging((object) this, new dsQuarterlyByCostCenter.QuarterlyByCostCenter_BudgetRowChangeEvent((dsQuarterlyByCostCenter.QuarterlyByCostCenter_BudgetRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      if (this.QuarterlyByCostCenter_BudgetRowDeleted == null)
        return;
      this.QuarterlyByCostCenter_BudgetRowDeleted((object) this, new dsQuarterlyByCostCenter.QuarterlyByCostCenter_BudgetRowChangeEvent((dsQuarterlyByCostCenter.QuarterlyByCostCenter_BudgetRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      if (this.QuarterlyByCostCenter_BudgetRowDeleting == null)
        return;
      this.QuarterlyByCostCenter_BudgetRowDeleting((object) this, new dsQuarterlyByCostCenter.QuarterlyByCostCenter_BudgetRowChangeEvent((dsQuarterlyByCostCenter.QuarterlyByCostCenter_BudgetRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemoveQuarterlyByCostCenter_BudgetRow(
      dsQuarterlyByCostCenter.QuarterlyByCostCenter_BudgetRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType typedTableSchema = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsQuarterlyByCostCenter quarterlyByCostCenter = new dsQuarterlyByCostCenter();
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
        FixedValue = quarterlyByCostCenter.Namespace
      });
      typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (QuarterlyByCostCenter_BudgetDataTable)
      });
      typedTableSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = quarterlyByCostCenter.GetSchemaSerializable();
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

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class QuarterlyByCostCenter_ActualDataTable : 
    TypedTableBase<dsQuarterlyByCostCenter.QuarterlyByCostCenter_ActualRow>
  {
    private DataColumn columnQuarter;
    private DataColumn columnDefaultCostCenter;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public QuarterlyByCostCenter_ActualDataTable()
    {
      this.TableName = "QuarterlyByCostCenter_Actual";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal QuarterlyByCostCenter_ActualDataTable(DataTable table)
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
    protected QuarterlyByCostCenter_ActualDataTable(
      SerializationInfo info,
      StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn QuarterColumn => this.columnQuarter;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn DefaultCostCenterColumn => this.columnDefaultCostCenter;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsQuarterlyByCostCenter.QuarterlyByCostCenter_ActualRow this[int index]
    {
      get => (dsQuarterlyByCostCenter.QuarterlyByCostCenter_ActualRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsQuarterlyByCostCenter.QuarterlyByCostCenter_ActualRowChangeEventHandler QuarterlyByCostCenter_ActualRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsQuarterlyByCostCenter.QuarterlyByCostCenter_ActualRowChangeEventHandler QuarterlyByCostCenter_ActualRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsQuarterlyByCostCenter.QuarterlyByCostCenter_ActualRowChangeEventHandler QuarterlyByCostCenter_ActualRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsQuarterlyByCostCenter.QuarterlyByCostCenter_ActualRowChangeEventHandler QuarterlyByCostCenter_ActualRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddQuarterlyByCostCenter_ActualRow(
      dsQuarterlyByCostCenter.QuarterlyByCostCenter_ActualRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsQuarterlyByCostCenter.QuarterlyByCostCenter_ActualRow AddQuarterlyByCostCenter_ActualRow(
      string Quarter,
      Decimal DefaultCostCenter)
    {
      dsQuarterlyByCostCenter.QuarterlyByCostCenter_ActualRow row = (dsQuarterlyByCostCenter.QuarterlyByCostCenter_ActualRow) this.NewRow();
      object[] objArray = new object[2]
      {
        (object) Quarter,
        (object) DefaultCostCenter
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsQuarterlyByCostCenter.QuarterlyByCostCenter_ActualDataTable centerActualDataTable = (dsQuarterlyByCostCenter.QuarterlyByCostCenter_ActualDataTable) base.Clone();
      centerActualDataTable.InitVars();
      return (DataTable) centerActualDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsQuarterlyByCostCenter.QuarterlyByCostCenter_ActualDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnQuarter = this.Columns["Quarter"];
      this.columnDefaultCostCenter = this.Columns["DefaultCostCenter"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnQuarter = new DataColumn("Quarter", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnQuarter);
      this.columnDefaultCostCenter = new DataColumn("DefaultCostCenter", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDefaultCostCenter);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsQuarterlyByCostCenter.QuarterlyByCostCenter_ActualRow NewQuarterlyByCostCenter_ActualRow()
    {
      return (dsQuarterlyByCostCenter.QuarterlyByCostCenter_ActualRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsQuarterlyByCostCenter.QuarterlyByCostCenter_ActualRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType()
    {
      return typeof (dsQuarterlyByCostCenter.QuarterlyByCostCenter_ActualRow);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      if (this.QuarterlyByCostCenter_ActualRowChanged == null)
        return;
      this.QuarterlyByCostCenter_ActualRowChanged((object) this, new dsQuarterlyByCostCenter.QuarterlyByCostCenter_ActualRowChangeEvent((dsQuarterlyByCostCenter.QuarterlyByCostCenter_ActualRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      if (this.QuarterlyByCostCenter_ActualRowChanging == null)
        return;
      this.QuarterlyByCostCenter_ActualRowChanging((object) this, new dsQuarterlyByCostCenter.QuarterlyByCostCenter_ActualRowChangeEvent((dsQuarterlyByCostCenter.QuarterlyByCostCenter_ActualRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      if (this.QuarterlyByCostCenter_ActualRowDeleted == null)
        return;
      this.QuarterlyByCostCenter_ActualRowDeleted((object) this, new dsQuarterlyByCostCenter.QuarterlyByCostCenter_ActualRowChangeEvent((dsQuarterlyByCostCenter.QuarterlyByCostCenter_ActualRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      if (this.QuarterlyByCostCenter_ActualRowDeleting == null)
        return;
      this.QuarterlyByCostCenter_ActualRowDeleting((object) this, new dsQuarterlyByCostCenter.QuarterlyByCostCenter_ActualRowChangeEvent((dsQuarterlyByCostCenter.QuarterlyByCostCenter_ActualRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemoveQuarterlyByCostCenter_ActualRow(
      dsQuarterlyByCostCenter.QuarterlyByCostCenter_ActualRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType typedTableSchema = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsQuarterlyByCostCenter quarterlyByCostCenter = new dsQuarterlyByCostCenter();
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
        FixedValue = quarterlyByCostCenter.Namespace
      });
      typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (QuarterlyByCostCenter_ActualDataTable)
      });
      typedTableSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = quarterlyByCostCenter.GetSchemaSerializable();
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

  public class QuarterlyByCostCenter_BudgetRow : DataRow
  {
    private dsQuarterlyByCostCenter.QuarterlyByCostCenter_BudgetDataTable tableQuarterlyByCostCenter_Budget;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal QuarterlyByCostCenter_BudgetRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableQuarterlyByCostCenter_Budget = (dsQuarterlyByCostCenter.QuarterlyByCostCenter_BudgetDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Quarter
    {
      get
      {
        try
        {
          return (string) this[this.tableQuarterlyByCostCenter_Budget.QuarterColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'Quarter' in table 'QuarterlyByCostCenter_Budget' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableQuarterlyByCostCenter_Budget.QuarterColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal DefaultCostCenter
    {
      get
      {
        try
        {
          return (Decimal) this[this.tableQuarterlyByCostCenter_Budget.DefaultCostCenterColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'DefaultCostCenter' in table 'QuarterlyByCostCenter_Budget' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableQuarterlyByCostCenter_Budget.DefaultCostCenterColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsQuarterNull()
    {
      return this.IsNull(this.tableQuarterlyByCostCenter_Budget.QuarterColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetQuarterNull()
    {
      this[this.tableQuarterlyByCostCenter_Budget.QuarterColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsDefaultCostCenterNull()
    {
      return this.IsNull(this.tableQuarterlyByCostCenter_Budget.DefaultCostCenterColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetDefaultCostCenterNull()
    {
      this[this.tableQuarterlyByCostCenter_Budget.DefaultCostCenterColumn] = Convert.DBNull;
    }
  }

  public class QuarterlyByCostCenter_ActualRow : DataRow
  {
    private dsQuarterlyByCostCenter.QuarterlyByCostCenter_ActualDataTable tableQuarterlyByCostCenter_Actual;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal QuarterlyByCostCenter_ActualRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableQuarterlyByCostCenter_Actual = (dsQuarterlyByCostCenter.QuarterlyByCostCenter_ActualDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Quarter
    {
      get
      {
        try
        {
          return (string) this[this.tableQuarterlyByCostCenter_Actual.QuarterColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'Quarter' in table 'QuarterlyByCostCenter_Actual' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableQuarterlyByCostCenter_Actual.QuarterColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal DefaultCostCenter
    {
      get
      {
        try
        {
          return (Decimal) this[this.tableQuarterlyByCostCenter_Actual.DefaultCostCenterColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'DefaultCostCenter' in table 'QuarterlyByCostCenter_Actual' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableQuarterlyByCostCenter_Actual.DefaultCostCenterColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsQuarterNull()
    {
      return this.IsNull(this.tableQuarterlyByCostCenter_Actual.QuarterColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetQuarterNull()
    {
      this[this.tableQuarterlyByCostCenter_Actual.QuarterColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsDefaultCostCenterNull()
    {
      return this.IsNull(this.tableQuarterlyByCostCenter_Actual.DefaultCostCenterColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetDefaultCostCenterNull()
    {
      this[this.tableQuarterlyByCostCenter_Actual.DefaultCostCenterColumn] = Convert.DBNull;
    }
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class QuarterlyByCostCenter_BudgetRowChangeEvent : EventArgs
  {
    private dsQuarterlyByCostCenter.QuarterlyByCostCenter_BudgetRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public QuarterlyByCostCenter_BudgetRowChangeEvent(
      dsQuarterlyByCostCenter.QuarterlyByCostCenter_BudgetRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsQuarterlyByCostCenter.QuarterlyByCostCenter_BudgetRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class QuarterlyByCostCenter_ActualRowChangeEvent : EventArgs
  {
    private dsQuarterlyByCostCenter.QuarterlyByCostCenter_ActualRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public QuarterlyByCostCenter_ActualRowChangeEvent(
      dsQuarterlyByCostCenter.QuarterlyByCostCenter_ActualRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsQuarterlyByCostCenter.QuarterlyByCostCenter_ActualRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }
}
