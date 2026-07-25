// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.dsInsuredSummary
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
namespace MGASystems.IMS.Policies;

[DesignerCategory("code")]
[ToolboxItem(true)]
[XmlSchemaProvider("GetTypedDataSetSchema")]
[XmlRoot("dsInsuredSummary")]
[HelpKeyword("vs.data.DataSet")]
[Serializable]
public class dsInsuredSummary : DataSet
{
  private dsInsuredSummary.InsuredSummaryDataTable tableInsuredSummary;
  private SchemaSerializationMode _schemaSerializationMode;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public dsInsuredSummary()
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
  protected dsInsuredSummary(SerializationInfo info, StreamingContext context)
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
        if (dataSet.Tables[nameof (InsuredSummary)] != null)
          base.Tables.Add((DataTable) new dsInsuredSummary.InsuredSummaryDataTable(dataSet.Tables[nameof (InsuredSummary)]));
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
  public dsInsuredSummary.InsuredSummaryDataTable InsuredSummary => this.tableInsuredSummary;

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
    dsInsuredSummary dsInsuredSummary = (dsInsuredSummary) base.Clone();
    dsInsuredSummary.InitVars();
    dsInsuredSummary.SchemaSerializationMode = this.SchemaSerializationMode;
    return (DataSet) dsInsuredSummary;
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
      if (dataSet.Tables["InsuredSummary"] != null)
        base.Tables.Add((DataTable) new dsInsuredSummary.InsuredSummaryDataTable(dataSet.Tables["InsuredSummary"]));
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
    this.tableInsuredSummary = (dsInsuredSummary.InsuredSummaryDataTable) base.Tables["InsuredSummary"];
    if (!initTable || this.tableInsuredSummary == null)
      return;
    this.tableInsuredSummary.InitVars();
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private void InitClass()
  {
    this.DataSetName = nameof (dsInsuredSummary);
    this.Prefix = "";
    this.Namespace = "http://tempuri.org/dsInsuredSummary.xsd";
    this.EnforceConstraints = true;
    this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.tableInsuredSummary = new dsInsuredSummary.InsuredSummaryDataTable();
    base.Tables.Add((DataTable) this.tableInsuredSummary);
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializeInsuredSummary() => false;

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
    dsInsuredSummary dsInsuredSummary = new dsInsuredSummary();
    XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
    schemaComplexType.Particle = (XmlSchemaParticle) new XmlSchemaSequence()
    {
      Items = {
        (XmlSchemaObject) new XmlSchemaAny()
        {
          Namespace = dsInsuredSummary.Namespace
        }
      }
    };
    XmlSchema schemaSerializable = dsInsuredSummary.GetSchemaSerializable();
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
  public delegate void InsuredSummaryRowChangeEventHandler(
    object sender,
    dsInsuredSummary.InsuredSummaryRowChangeEvent e);

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class InsuredSummaryDataTable : TypedTableBase<dsInsuredSummary.InsuredSummaryRow>
  {
    private DataColumn columnInsuredName;
    private DataColumn columnInsuredAddress;
    private DataColumn columnProducer;
    private DataColumn columnUnderwriter;
    private DataColumn columnEffectiveDate;
    private DataColumn columnControlNo;
    private DataColumn columnQuoteStatus;
    private DataColumn columnQuoteStatusReason;
    private DataColumn columnCarrier;
    private DataColumn columnLine;
    private DataColumn columnPolicyNumber;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public InsuredSummaryDataTable()
    {
      this.TableName = "InsuredSummary";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal InsuredSummaryDataTable(DataTable table)
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
    protected InsuredSummaryDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn InsuredNameColumn => this.columnInsuredName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn InsuredAddressColumn => this.columnInsuredAddress;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ProducerColumn => this.columnProducer;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn UnderwriterColumn => this.columnUnderwriter;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn EffectiveDateColumn => this.columnEffectiveDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ControlNoColumn => this.columnControlNo;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn QuoteStatusColumn => this.columnQuoteStatus;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn QuoteStatusReasonColumn => this.columnQuoteStatusReason;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn CarrierColumn => this.columnCarrier;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn LineColumn => this.columnLine;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn PolicyNumberColumn => this.columnPolicyNumber;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsInsuredSummary.InsuredSummaryRow this[int index]
    {
      get => (dsInsuredSummary.InsuredSummaryRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsInsuredSummary.InsuredSummaryRowChangeEventHandler InsuredSummaryRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsInsuredSummary.InsuredSummaryRowChangeEventHandler InsuredSummaryRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsInsuredSummary.InsuredSummaryRowChangeEventHandler InsuredSummaryRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsInsuredSummary.InsuredSummaryRowChangeEventHandler InsuredSummaryRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddInsuredSummaryRow(dsInsuredSummary.InsuredSummaryRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsInsuredSummary.InsuredSummaryRow AddInsuredSummaryRow(
      string InsuredName,
      string InsuredAddress,
      string Producer,
      string Underwriter,
      DateTime EffectiveDate,
      int ControlNo,
      string QuoteStatus,
      string QuoteStatusReason,
      string Carrier,
      string Line,
      string PolicyNumber)
    {
      dsInsuredSummary.InsuredSummaryRow row = (dsInsuredSummary.InsuredSummaryRow) this.NewRow();
      object[] objArray = new object[11]
      {
        (object) InsuredName,
        (object) InsuredAddress,
        (object) Producer,
        (object) Underwriter,
        (object) EffectiveDate,
        (object) ControlNo,
        (object) QuoteStatus,
        (object) QuoteStatusReason,
        (object) Carrier,
        (object) Line,
        (object) PolicyNumber
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsInsuredSummary.InsuredSummaryDataTable summaryDataTable = (dsInsuredSummary.InsuredSummaryDataTable) base.Clone();
      summaryDataTable.InitVars();
      return (DataTable) summaryDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsInsuredSummary.InsuredSummaryDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnInsuredName = this.Columns["InsuredName"];
      this.columnInsuredAddress = this.Columns["InsuredAddress"];
      this.columnProducer = this.Columns["Producer"];
      this.columnUnderwriter = this.Columns["Underwriter"];
      this.columnEffectiveDate = this.Columns["EffectiveDate"];
      this.columnControlNo = this.Columns["ControlNo"];
      this.columnQuoteStatus = this.Columns["QuoteStatus"];
      this.columnQuoteStatusReason = this.Columns["QuoteStatusReason"];
      this.columnCarrier = this.Columns["Carrier"];
      this.columnLine = this.Columns["Line"];
      this.columnPolicyNumber = this.Columns["PolicyNumber"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnInsuredName = new DataColumn("InsuredName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInsuredName);
      this.columnInsuredAddress = new DataColumn("InsuredAddress", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInsuredAddress);
      this.columnProducer = new DataColumn("Producer", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnProducer);
      this.columnUnderwriter = new DataColumn("Underwriter", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnUnderwriter);
      this.columnEffectiveDate = new DataColumn("EffectiveDate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEffectiveDate);
      this.columnControlNo = new DataColumn("ControlNo", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnControlNo);
      this.columnQuoteStatus = new DataColumn("QuoteStatus", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnQuoteStatus);
      this.columnQuoteStatusReason = new DataColumn("QuoteStatusReason", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnQuoteStatusReason);
      this.columnCarrier = new DataColumn("Carrier", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCarrier);
      this.columnLine = new DataColumn("Line", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLine);
      this.columnPolicyNumber = new DataColumn("PolicyNumber", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPolicyNumber);
      this.columnInsuredName.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsInsuredSummary.InsuredSummaryRow NewInsuredSummaryRow()
    {
      return (dsInsuredSummary.InsuredSummaryRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsInsuredSummary.InsuredSummaryRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (dsInsuredSummary.InsuredSummaryRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.InsuredSummaryRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInsuredSummary.InsuredSummaryRowChangeEventHandler summaryRowChangedEvent = this.InsuredSummaryRowChangedEvent;
      if (summaryRowChangedEvent == null)
        return;
      summaryRowChangedEvent((object) this, new dsInsuredSummary.InsuredSummaryRowChangeEvent((dsInsuredSummary.InsuredSummaryRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.InsuredSummaryRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInsuredSummary.InsuredSummaryRowChangeEventHandler rowChangingEvent = this.InsuredSummaryRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsInsuredSummary.InsuredSummaryRowChangeEvent((dsInsuredSummary.InsuredSummaryRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.InsuredSummaryRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInsuredSummary.InsuredSummaryRowChangeEventHandler summaryRowDeletedEvent = this.InsuredSummaryRowDeletedEvent;
      if (summaryRowDeletedEvent == null)
        return;
      summaryRowDeletedEvent((object) this, new dsInsuredSummary.InsuredSummaryRowChangeEvent((dsInsuredSummary.InsuredSummaryRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.InsuredSummaryRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInsuredSummary.InsuredSummaryRowChangeEventHandler rowDeletingEvent = this.InsuredSummaryRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsInsuredSummary.InsuredSummaryRowChangeEvent((dsInsuredSummary.InsuredSummaryRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemoveInsuredSummaryRow(dsInsuredSummary.InsuredSummaryRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsInsuredSummary dsInsuredSummary = new dsInsuredSummary();
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
        FixedValue = dsInsuredSummary.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (InsuredSummaryDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsInsuredSummary.GetSchemaSerializable();
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

  public class InsuredSummaryRow : DataRow
  {
    private dsInsuredSummary.InsuredSummaryDataTable tableInsuredSummary;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal InsuredSummaryRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableInsuredSummary = (dsInsuredSummary.InsuredSummaryDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string InsuredName
    {
      get => Conversions.ToString(this[this.tableInsuredSummary.InsuredNameColumn]);
      set => this[this.tableInsuredSummary.InsuredNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string InsuredAddress
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableInsuredSummary.InsuredAddressColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'InsuredAddress' in table 'InsuredSummary' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableInsuredSummary.InsuredAddressColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Producer
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableInsuredSummary.ProducerColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Producer' in table 'InsuredSummary' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableInsuredSummary.ProducerColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Underwriter
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableInsuredSummary.UnderwriterColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Underwriter' in table 'InsuredSummary' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableInsuredSummary.UnderwriterColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DateTime EffectiveDate
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tableInsuredSummary.EffectiveDateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'EffectiveDate' in table 'InsuredSummary' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableInsuredSummary.EffectiveDateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int ControlNo
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tableInsuredSummary.ControlNoColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ControlNo' in table 'InsuredSummary' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableInsuredSummary.ControlNoColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string QuoteStatus
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableInsuredSummary.QuoteStatusColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'QuoteStatus' in table 'InsuredSummary' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableInsuredSummary.QuoteStatusColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string QuoteStatusReason
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableInsuredSummary.QuoteStatusReasonColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'QuoteStatusReason' in table 'InsuredSummary' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableInsuredSummary.QuoteStatusReasonColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Carrier
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableInsuredSummary.CarrierColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Carrier' in table 'InsuredSummary' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableInsuredSummary.CarrierColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Line
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableInsuredSummary.LineColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Line' in table 'InsuredSummary' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableInsuredSummary.LineColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string PolicyNumber
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableInsuredSummary.PolicyNumberColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'PolicyNumber' in table 'InsuredSummary' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableInsuredSummary.PolicyNumberColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsInsuredAddressNull()
    {
      return this.IsNull(this.tableInsuredSummary.InsuredAddressColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetInsuredAddressNull()
    {
      this[this.tableInsuredSummary.InsuredAddressColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsProducerNull() => this.IsNull(this.tableInsuredSummary.ProducerColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetProducerNull()
    {
      this[this.tableInsuredSummary.ProducerColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsUnderwriterNull() => this.IsNull(this.tableInsuredSummary.UnderwriterColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetUnderwriterNull()
    {
      this[this.tableInsuredSummary.UnderwriterColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsEffectiveDateNull() => this.IsNull(this.tableInsuredSummary.EffectiveDateColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetEffectiveDateNull()
    {
      this[this.tableInsuredSummary.EffectiveDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsControlNoNull() => this.IsNull(this.tableInsuredSummary.ControlNoColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetControlNoNull()
    {
      this[this.tableInsuredSummary.ControlNoColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsQuoteStatusNull() => this.IsNull(this.tableInsuredSummary.QuoteStatusColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetQuoteStatusNull()
    {
      this[this.tableInsuredSummary.QuoteStatusColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsQuoteStatusReasonNull()
    {
      return this.IsNull(this.tableInsuredSummary.QuoteStatusReasonColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetQuoteStatusReasonNull()
    {
      this[this.tableInsuredSummary.QuoteStatusReasonColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsCarrierNull() => this.IsNull(this.tableInsuredSummary.CarrierColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetCarrierNull()
    {
      this[this.tableInsuredSummary.CarrierColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsLineNull() => this.IsNull(this.tableInsuredSummary.LineColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetLineNull()
    {
      this[this.tableInsuredSummary.LineColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsPolicyNumberNull() => this.IsNull(this.tableInsuredSummary.PolicyNumberColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetPolicyNumberNull()
    {
      this[this.tableInsuredSummary.PolicyNumberColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class InsuredSummaryRowChangeEvent : EventArgs
  {
    private dsInsuredSummary.InsuredSummaryRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public InsuredSummaryRowChangeEvent(
      dsInsuredSummary.InsuredSummaryRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsInsuredSummary.InsuredSummaryRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }
}
