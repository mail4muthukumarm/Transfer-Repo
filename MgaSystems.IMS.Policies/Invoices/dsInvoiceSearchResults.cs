// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Invoices.dsInvoiceSearchResults
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
namespace MGASystems.IMS.Policies.Invoices;

[DesignerCategory("code")]
[ToolboxItem(true)]
[XmlSchemaProvider("GetTypedDataSetSchema")]
[XmlRoot("dsInvoiceSearchResults")]
[HelpKeyword("vs.data.DataSet")]
[Serializable]
public class dsInvoiceSearchResults : DataSet
{
  private dsInvoiceSearchResults.InvoiceLookupDataTable tableInvoiceLookup;
  private SchemaSerializationMode _schemaSerializationMode;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  public dsInvoiceSearchResults()
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
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  protected dsInvoiceSearchResults(SerializationInfo info, StreamingContext context)
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
        if (dataSet.Tables[nameof (InvoiceLookup)] != null)
          base.Tables.Add((DataTable) new dsInvoiceSearchResults.InvoiceLookupDataTable(dataSet.Tables[nameof (InvoiceLookup)]));
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
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsInvoiceSearchResults.InvoiceLookupDataTable InvoiceLookup => this.tableInvoiceLookup;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  [Browsable(true)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
  public override SchemaSerializationMode SchemaSerializationMode
  {
    get => this._schemaSerializationMode;
    set => this._schemaSerializationMode = value;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public new DataTableCollection Tables => base.Tables;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public new DataRelationCollection Relations => base.Relations;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  protected override void InitializeDerivedDataSet()
  {
    this.BeginInit();
    this.InitClass();
    this.EndInit();
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  public override DataSet Clone()
  {
    dsInvoiceSearchResults invoiceSearchResults = (dsInvoiceSearchResults) base.Clone();
    invoiceSearchResults.InitVars();
    invoiceSearchResults.SchemaSerializationMode = this.SchemaSerializationMode;
    return (DataSet) invoiceSearchResults;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  protected override bool ShouldSerializeTables() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  protected override bool ShouldSerializeRelations() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  protected override void ReadXmlSerializable(XmlReader reader)
  {
    if (this.DetermineSchemaSerializationMode(reader) == SchemaSerializationMode.IncludeSchema)
    {
      this.Reset();
      DataSet dataSet = new DataSet();
      int num = (int) dataSet.ReadXml(reader);
      if (dataSet.Tables["InvoiceLookup"] != null)
        base.Tables.Add((DataTable) new dsInvoiceSearchResults.InvoiceLookupDataTable(dataSet.Tables["InvoiceLookup"]));
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
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  protected override XmlSchema GetSchemaSerializable()
  {
    MemoryStream memoryStream = new MemoryStream();
    this.WriteXmlSchema((XmlWriter) new XmlTextWriter((Stream) memoryStream, (Encoding) null));
    memoryStream.Position = 0L;
    return XmlSchema.Read((XmlReader) new XmlTextReader((Stream) memoryStream), (ValidationEventHandler) null);
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  internal void InitVars() => this.InitVars(true);

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  internal void InitVars(bool initTable)
  {
    this.tableInvoiceLookup = (dsInvoiceSearchResults.InvoiceLookupDataTable) base.Tables["InvoiceLookup"];
    if (!initTable || this.tableInvoiceLookup == null)
      return;
    this.tableInvoiceLookup.InitVars();
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  private void InitClass()
  {
    this.DataSetName = nameof (dsInvoiceSearchResults);
    this.Prefix = "";
    this.Namespace = "http://www.tempuri.org/dsInvoiceSearchResults.xsd";
    this.EnforceConstraints = true;
    this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.tableInvoiceLookup = new dsInvoiceSearchResults.InvoiceLookupDataTable();
    base.Tables.Add((DataTable) this.tableInvoiceLookup);
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  private bool ShouldSerializeInvoiceLookup() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  private void SchemaChanged(object sender, CollectionChangeEventArgs e)
  {
    if (e.Action != CollectionChangeAction.Remove)
      return;
    this.InitVars();
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  public static XmlSchemaComplexType GetTypedDataSetSchema(XmlSchemaSet xs)
  {
    dsInvoiceSearchResults invoiceSearchResults = new dsInvoiceSearchResults();
    XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
    schemaComplexType.Particle = (XmlSchemaParticle) new XmlSchemaSequence()
    {
      Items = {
        (XmlSchemaObject) new XmlSchemaAny()
        {
          Namespace = invoiceSearchResults.Namespace
        }
      }
    };
    XmlSchema schemaSerializable = invoiceSearchResults.GetSchemaSerializable();
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

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  public delegate void InvoiceLookupRowChangeEventHandler(
    object sender,
    dsInvoiceSearchResults.InvoiceLookupRowChangeEvent e);

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class InvoiceLookupDataTable : TypedTableBase<dsInvoiceSearchResults.InvoiceLookupRow>
  {
    private DataColumn columnRecordNumber;
    private DataColumn columnOfficeInvoiceNumber;
    private DataColumn columnSystemInvoiceNumber;
    private DataColumn columnInvoiceDate;
    private DataColumn columnDatePrinted;
    private DataColumn columnQuoteControlNum;
    private DataColumn columnInsured;
    private DataColumn columnProducer;
    private DataColumn columnCompany;
    private DataColumn columnFailed;
    private DataColumn columnDueDate;
    private DataColumn columnPolicyNumber;
    private DataColumn columnPrint;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public InvoiceLookupDataTable()
    {
      this.TableName = "InvoiceLookup";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal InvoiceLookupDataTable(DataTable table)
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected InvoiceLookupDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn RecordNumberColumn => this.columnRecordNumber;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn OfficeInvoiceNumberColumn => this.columnOfficeInvoiceNumber;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn SystemInvoiceNumberColumn => this.columnSystemInvoiceNumber;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn InvoiceDateColumn => this.columnInvoiceDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn DatePrintedColumn => this.columnDatePrinted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn QuoteControlNumColumn => this.columnQuoteControlNum;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn InsuredColumn => this.columnInsured;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn ProducerColumn => this.columnProducer;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn CompanyColumn => this.columnCompany;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn FailedColumn => this.columnFailed;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn DueDateColumn => this.columnDueDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn PolicyNumberColumn => this.columnPolicyNumber;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn PrintColumn => this.columnPrint;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsInvoiceSearchResults.InvoiceLookupRow this[int index]
    {
      get => (dsInvoiceSearchResults.InvoiceLookupRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsInvoiceSearchResults.InvoiceLookupRowChangeEventHandler InvoiceLookupRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsInvoiceSearchResults.InvoiceLookupRowChangeEventHandler InvoiceLookupRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsInvoiceSearchResults.InvoiceLookupRowChangeEventHandler InvoiceLookupRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsInvoiceSearchResults.InvoiceLookupRowChangeEventHandler InvoiceLookupRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void AddInvoiceLookupRow(dsInvoiceSearchResults.InvoiceLookupRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsInvoiceSearchResults.InvoiceLookupRow AddInvoiceLookupRow(
      int OfficeInvoiceNumber,
      int SystemInvoiceNumber,
      DateTime InvoiceDate,
      DateTime DatePrinted,
      int QuoteControlNum,
      string Insured,
      string Producer,
      string Company,
      bool Failed,
      DateTime DueDate,
      string PolicyNumber,
      bool Print)
    {
      dsInvoiceSearchResults.InvoiceLookupRow row = (dsInvoiceSearchResults.InvoiceLookupRow) this.NewRow();
      object[] objArray = new object[13]
      {
        null,
        (object) OfficeInvoiceNumber,
        (object) SystemInvoiceNumber,
        (object) InvoiceDate,
        (object) DatePrinted,
        (object) QuoteControlNum,
        (object) Insured,
        (object) Producer,
        (object) Company,
        (object) Failed,
        (object) DueDate,
        (object) PolicyNumber,
        (object) Print
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsInvoiceSearchResults.InvoiceLookupRow FindBySystemInvoiceNumber(int SystemInvoiceNumber)
    {
      return (dsInvoiceSearchResults.InvoiceLookupRow) this.Rows.Find(new object[1]
      {
        (object) SystemInvoiceNumber
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public override DataTable Clone()
    {
      dsInvoiceSearchResults.InvoiceLookupDataTable invoiceLookupDataTable = (dsInvoiceSearchResults.InvoiceLookupDataTable) base.Clone();
      invoiceLookupDataTable.InitVars();
      return (DataTable) invoiceLookupDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsInvoiceSearchResults.InvoiceLookupDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal void InitVars()
    {
      this.columnRecordNumber = this.Columns["RecordNumber"];
      this.columnOfficeInvoiceNumber = this.Columns["OfficeInvoiceNumber"];
      this.columnSystemInvoiceNumber = this.Columns["SystemInvoiceNumber"];
      this.columnInvoiceDate = this.Columns["InvoiceDate"];
      this.columnDatePrinted = this.Columns["DatePrinted"];
      this.columnQuoteControlNum = this.Columns["QuoteControlNum"];
      this.columnInsured = this.Columns["Insured"];
      this.columnProducer = this.Columns["Producer"];
      this.columnCompany = this.Columns["Company"];
      this.columnFailed = this.Columns["Failed"];
      this.columnDueDate = this.Columns["DueDate"];
      this.columnPolicyNumber = this.Columns["PolicyNumber"];
      this.columnPrint = this.Columns["Print"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    private void InitClass()
    {
      this.columnRecordNumber = new DataColumn("RecordNumber", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnRecordNumber);
      this.columnOfficeInvoiceNumber = new DataColumn("OfficeInvoiceNumber", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnOfficeInvoiceNumber);
      this.columnSystemInvoiceNumber = new DataColumn("SystemInvoiceNumber", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSystemInvoiceNumber);
      this.columnInvoiceDate = new DataColumn("InvoiceDate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInvoiceDate);
      this.columnDatePrinted = new DataColumn("DatePrinted", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDatePrinted);
      this.columnQuoteControlNum = new DataColumn("QuoteControlNum", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnQuoteControlNum);
      this.columnInsured = new DataColumn("Insured", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInsured);
      this.columnProducer = new DataColumn("Producer", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnProducer);
      this.columnCompany = new DataColumn("Company", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCompany);
      this.columnFailed = new DataColumn("Failed", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFailed);
      this.columnDueDate = new DataColumn("DueDate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDueDate);
      this.columnPolicyNumber = new DataColumn("PolicyNumber", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPolicyNumber);
      this.columnPrint = new DataColumn("Print", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPrint);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsInvoiceSearchResultsKey1", new DataColumn[1]
      {
        this.columnSystemInvoiceNumber
      }, true));
      this.columnRecordNumber.AutoIncrement = true;
      this.columnRecordNumber.AllowDBNull = false;
      this.columnSystemInvoiceNumber.AllowDBNull = false;
      this.columnSystemInvoiceNumber.Unique = true;
      this.columnPrint.DefaultValue = (object) false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsInvoiceSearchResults.InvoiceLookupRow NewInvoiceLookupRow()
    {
      return (dsInvoiceSearchResults.InvoiceLookupRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsInvoiceSearchResults.InvoiceLookupRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override Type GetRowType() => typeof (dsInvoiceSearchResults.InvoiceLookupRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.InvoiceLookupRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInvoiceSearchResults.InvoiceLookupRowChangeEventHandler lookupRowChangedEvent = this.InvoiceLookupRowChangedEvent;
      if (lookupRowChangedEvent == null)
        return;
      lookupRowChangedEvent((object) this, new dsInvoiceSearchResults.InvoiceLookupRowChangeEvent((dsInvoiceSearchResults.InvoiceLookupRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.InvoiceLookupRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInvoiceSearchResults.InvoiceLookupRowChangeEventHandler rowChangingEvent = this.InvoiceLookupRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsInvoiceSearchResults.InvoiceLookupRowChangeEvent((dsInvoiceSearchResults.InvoiceLookupRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.InvoiceLookupRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInvoiceSearchResults.InvoiceLookupRowChangeEventHandler lookupRowDeletedEvent = this.InvoiceLookupRowDeletedEvent;
      if (lookupRowDeletedEvent == null)
        return;
      lookupRowDeletedEvent((object) this, new dsInvoiceSearchResults.InvoiceLookupRowChangeEvent((dsInvoiceSearchResults.InvoiceLookupRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.InvoiceLookupRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInvoiceSearchResults.InvoiceLookupRowChangeEventHandler rowDeletingEvent = this.InvoiceLookupRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsInvoiceSearchResults.InvoiceLookupRowChangeEvent((dsInvoiceSearchResults.InvoiceLookupRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void RemoveInvoiceLookupRow(dsInvoiceSearchResults.InvoiceLookupRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsInvoiceSearchResults invoiceSearchResults = new dsInvoiceSearchResults();
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
        FixedValue = invoiceSearchResults.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (InvoiceLookupDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = invoiceSearchResults.GetSchemaSerializable();
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

  public class InvoiceLookupRow : DataRow
  {
    private dsInvoiceSearchResults.InvoiceLookupDataTable tableInvoiceLookup;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal InvoiceLookupRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableInvoiceLookup = (dsInvoiceSearchResults.InvoiceLookupDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public int RecordNumber
    {
      get => Conversions.ToInteger(this[this.tableInvoiceLookup.RecordNumberColumn]);
      set => this[this.tableInvoiceLookup.RecordNumberColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public int OfficeInvoiceNumber
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tableInvoiceLookup.OfficeInvoiceNumberColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'OfficeInvoiceNumber' in table 'InvoiceLookup' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableInvoiceLookup.OfficeInvoiceNumberColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public int SystemInvoiceNumber
    {
      get => Conversions.ToInteger(this[this.tableInvoiceLookup.SystemInvoiceNumberColumn]);
      set => this[this.tableInvoiceLookup.SystemInvoiceNumberColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DateTime InvoiceDate
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tableInvoiceLookup.InvoiceDateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'InvoiceDate' in table 'InvoiceLookup' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableInvoiceLookup.InvoiceDateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DateTime DatePrinted
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tableInvoiceLookup.DatePrintedColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DatePrinted' in table 'InvoiceLookup' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableInvoiceLookup.DatePrintedColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public int QuoteControlNum
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tableInvoiceLookup.QuoteControlNumColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'QuoteControlNum' in table 'InvoiceLookup' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableInvoiceLookup.QuoteControlNumColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string Insured
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableInvoiceLookup.InsuredColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Insured' in table 'InvoiceLookup' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableInvoiceLookup.InsuredColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string Producer
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableInvoiceLookup.ProducerColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Producer' in table 'InvoiceLookup' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableInvoiceLookup.ProducerColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string Company
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableInvoiceLookup.CompanyColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Company' in table 'InvoiceLookup' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableInvoiceLookup.CompanyColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool Failed
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tableInvoiceLookup.FailedColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Failed' in table 'InvoiceLookup' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableInvoiceLookup.FailedColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DateTime DueDate
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tableInvoiceLookup.DueDateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DueDate' in table 'InvoiceLookup' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableInvoiceLookup.DueDateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string PolicyNumber
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableInvoiceLookup.PolicyNumberColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'PolicyNumber' in table 'InvoiceLookup' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableInvoiceLookup.PolicyNumberColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool Print
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tableInvoiceLookup.PrintColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Print' in table 'InvoiceLookup' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableInvoiceLookup.PrintColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsOfficeInvoiceNumberNull()
    {
      return this.IsNull(this.tableInvoiceLookup.OfficeInvoiceNumberColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetOfficeInvoiceNumberNull()
    {
      this[this.tableInvoiceLookup.OfficeInvoiceNumberColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsInvoiceDateNull() => this.IsNull(this.tableInvoiceLookup.InvoiceDateColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetInvoiceDateNull()
    {
      this[this.tableInvoiceLookup.InvoiceDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsDatePrintedNull() => this.IsNull(this.tableInvoiceLookup.DatePrintedColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetDatePrintedNull()
    {
      this[this.tableInvoiceLookup.DatePrintedColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsQuoteControlNumNull()
    {
      return this.IsNull(this.tableInvoiceLookup.QuoteControlNumColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetQuoteControlNumNull()
    {
      this[this.tableInvoiceLookup.QuoteControlNumColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsInsuredNull() => this.IsNull(this.tableInvoiceLookup.InsuredColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetInsuredNull()
    {
      this[this.tableInvoiceLookup.InsuredColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsProducerNull() => this.IsNull(this.tableInvoiceLookup.ProducerColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetProducerNull()
    {
      this[this.tableInvoiceLookup.ProducerColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsCompanyNull() => this.IsNull(this.tableInvoiceLookup.CompanyColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetCompanyNull()
    {
      this[this.tableInvoiceLookup.CompanyColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsFailedNull() => this.IsNull(this.tableInvoiceLookup.FailedColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetFailedNull()
    {
      this[this.tableInvoiceLookup.FailedColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsDueDateNull() => this.IsNull(this.tableInvoiceLookup.DueDateColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetDueDateNull()
    {
      this[this.tableInvoiceLookup.DueDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsPolicyNumberNull() => this.IsNull(this.tableInvoiceLookup.PolicyNumberColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetPolicyNumberNull()
    {
      this[this.tableInvoiceLookup.PolicyNumberColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsPrintNull() => this.IsNull(this.tableInvoiceLookup.PrintColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetPrintNull()
    {
      this[this.tableInvoiceLookup.PrintColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  public class InvoiceLookupRowChangeEvent : EventArgs
  {
    private dsInvoiceSearchResults.InvoiceLookupRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public InvoiceLookupRowChangeEvent(
      dsInvoiceSearchResults.InvoiceLookupRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsInvoiceSearchResults.InvoiceLookupRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }
}
