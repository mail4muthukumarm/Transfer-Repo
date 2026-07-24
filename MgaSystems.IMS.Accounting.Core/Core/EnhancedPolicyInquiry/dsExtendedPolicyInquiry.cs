// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Core.EnhancedPolicyInquiry.dsExtendedPolicyInquiry
// Assembly: MgaSystems.IMS.Accounting.Core, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 923053EF-B70A-44B5-B8DA-B227263F4FD2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Core.dll

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
namespace MGASystems.IMS.Accounting.Core.EnhancedPolicyInquiry;

[DesignerCategory("code")]
[ToolboxItem(true)]
[XmlSchemaProvider("GetTypedDataSetSchema")]
[XmlRoot("dsExtendedPolicyInquiry")]
[HelpKeyword("vs.data.DataSet")]
[Serializable]
public class dsExtendedPolicyInquiry : DataSet
{
  private dsExtendedPolicyInquiry.PolicyHeaderDataTable tablePolicyHeader;
  private dsExtendedPolicyInquiry.PolicyInvoicesDataTable tablePolicyInvoices;
  private dsExtendedPolicyInquiry.InvoiceActivityDataTable tableInvoiceActivity;
  private dsExtendedPolicyInquiry.InvoicePayeesDataTable tableInvoicePayees;
  private DataRelation relationPolicyInvoices_InvoiceActivity;
  private DataRelation relationPolicyInvoices_PolicyHeader;
  private DataRelation relationPolicyInvoices_InvoicePayees;
  private SchemaSerializationMode _schemaSerializationMode = SchemaSerializationMode.IncludeSchema;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public dsExtendedPolicyInquiry()
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
  protected dsExtendedPolicyInquiry(SerializationInfo info, StreamingContext context)
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
        if (dataSet.Tables[nameof (PolicyHeader)] != null)
          base.Tables.Add((DataTable) new dsExtendedPolicyInquiry.PolicyHeaderDataTable(dataSet.Tables[nameof (PolicyHeader)]));
        if (dataSet.Tables[nameof (PolicyInvoices)] != null)
          base.Tables.Add((DataTable) new dsExtendedPolicyInquiry.PolicyInvoicesDataTable(dataSet.Tables[nameof (PolicyInvoices)]));
        if (dataSet.Tables[nameof (InvoiceActivity)] != null)
          base.Tables.Add((DataTable) new dsExtendedPolicyInquiry.InvoiceActivityDataTable(dataSet.Tables[nameof (InvoiceActivity)]));
        if (dataSet.Tables[nameof (InvoicePayees)] != null)
          base.Tables.Add((DataTable) new dsExtendedPolicyInquiry.InvoicePayeesDataTable(dataSet.Tables[nameof (InvoicePayees)]));
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
  public dsExtendedPolicyInquiry.PolicyHeaderDataTable PolicyHeader => this.tablePolicyHeader;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsExtendedPolicyInquiry.PolicyInvoicesDataTable PolicyInvoices => this.tablePolicyInvoices;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsExtendedPolicyInquiry.InvoiceActivityDataTable InvoiceActivity
  {
    get => this.tableInvoiceActivity;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsExtendedPolicyInquiry.InvoicePayeesDataTable InvoicePayees => this.tableInvoicePayees;

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
    dsExtendedPolicyInquiry extendedPolicyInquiry = (dsExtendedPolicyInquiry) base.Clone();
    extendedPolicyInquiry.InitVars();
    extendedPolicyInquiry.SchemaSerializationMode = this.SchemaSerializationMode;
    return (DataSet) extendedPolicyInquiry;
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
      if (dataSet.Tables["PolicyHeader"] != null)
        base.Tables.Add((DataTable) new dsExtendedPolicyInquiry.PolicyHeaderDataTable(dataSet.Tables["PolicyHeader"]));
      if (dataSet.Tables["PolicyInvoices"] != null)
        base.Tables.Add((DataTable) new dsExtendedPolicyInquiry.PolicyInvoicesDataTable(dataSet.Tables["PolicyInvoices"]));
      if (dataSet.Tables["InvoiceActivity"] != null)
        base.Tables.Add((DataTable) new dsExtendedPolicyInquiry.InvoiceActivityDataTable(dataSet.Tables["InvoiceActivity"]));
      if (dataSet.Tables["InvoicePayees"] != null)
        base.Tables.Add((DataTable) new dsExtendedPolicyInquiry.InvoicePayeesDataTable(dataSet.Tables["InvoicePayees"]));
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
    this.tablePolicyHeader = (dsExtendedPolicyInquiry.PolicyHeaderDataTable) base.Tables["PolicyHeader"];
    if (initTable && this.tablePolicyHeader != null)
      this.tablePolicyHeader.InitVars();
    this.tablePolicyInvoices = (dsExtendedPolicyInquiry.PolicyInvoicesDataTable) base.Tables["PolicyInvoices"];
    if (initTable && this.tablePolicyInvoices != null)
      this.tablePolicyInvoices.InitVars();
    this.tableInvoiceActivity = (dsExtendedPolicyInquiry.InvoiceActivityDataTable) base.Tables["InvoiceActivity"];
    if (initTable && this.tableInvoiceActivity != null)
      this.tableInvoiceActivity.InitVars();
    this.tableInvoicePayees = (dsExtendedPolicyInquiry.InvoicePayeesDataTable) base.Tables["InvoicePayees"];
    if (initTable && this.tableInvoicePayees != null)
      this.tableInvoicePayees.InitVars();
    this.relationPolicyInvoices_InvoiceActivity = this.Relations["PolicyInvoices_InvoiceActivity"];
    this.relationPolicyInvoices_PolicyHeader = this.Relations["PolicyInvoices_PolicyHeader"];
    this.relationPolicyInvoices_InvoicePayees = this.Relations["PolicyInvoices_InvoicePayees"];
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private void InitClass()
  {
    this.DataSetName = nameof (dsExtendedPolicyInquiry);
    this.Prefix = "";
    this.Namespace = "http://tempuri.org/dsExtendedPolicyInquiry.xsd";
    this.EnforceConstraints = true;
    this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.tablePolicyHeader = new dsExtendedPolicyInquiry.PolicyHeaderDataTable();
    base.Tables.Add((DataTable) this.tablePolicyHeader);
    this.tablePolicyInvoices = new dsExtendedPolicyInquiry.PolicyInvoicesDataTable();
    base.Tables.Add((DataTable) this.tablePolicyInvoices);
    this.tableInvoiceActivity = new dsExtendedPolicyInquiry.InvoiceActivityDataTable();
    base.Tables.Add((DataTable) this.tableInvoiceActivity);
    this.tableInvoicePayees = new dsExtendedPolicyInquiry.InvoicePayeesDataTable();
    base.Tables.Add((DataTable) this.tableInvoicePayees);
    this.relationPolicyInvoices_InvoiceActivity = new DataRelation("PolicyInvoices_InvoiceActivity", new DataColumn[1]
    {
      this.tablePolicyInvoices.InvoiceNumColumn
    }, new DataColumn[1]
    {
      this.tableInvoiceActivity.InvoiceNumColumn
    }, false);
    this.Relations.Add(this.relationPolicyInvoices_InvoiceActivity);
    this.relationPolicyInvoices_PolicyHeader = new DataRelation("PolicyInvoices_PolicyHeader", new DataColumn[1]
    {
      this.tablePolicyHeader.QuoteIdColumn
    }, new DataColumn[1]
    {
      this.tablePolicyInvoices.QuoteIdColumn
    }, false);
    this.Relations.Add(this.relationPolicyInvoices_PolicyHeader);
    this.relationPolicyInvoices_InvoicePayees = new DataRelation("PolicyInvoices_InvoicePayees", new DataColumn[1]
    {
      this.tablePolicyInvoices.InvoiceNumColumn
    }, new DataColumn[1]
    {
      this.tableInvoicePayees.InvoiceNumColumn
    }, false);
    this.Relations.Add(this.relationPolicyInvoices_InvoicePayees);
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializePolicyHeader() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializePolicyInvoices() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializeInvoiceActivity() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializeInvoicePayees() => false;

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
    dsExtendedPolicyInquiry extendedPolicyInquiry = new dsExtendedPolicyInquiry();
    XmlSchemaComplexType typedDataSetSchema = new XmlSchemaComplexType();
    XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
    xmlSchemaSequence.Items.Add((XmlSchemaObject) new XmlSchemaAny()
    {
      Namespace = extendedPolicyInquiry.Namespace
    });
    typedDataSetSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
    XmlSchema schemaSerializable = extendedPolicyInquiry.GetSchemaSerializable();
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
          current.Write((Stream) memoryStream2);
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
  public delegate void PolicyHeaderRowChangeEventHandler(
    object sender,
    dsExtendedPolicyInquiry.PolicyHeaderRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void PolicyInvoicesRowChangeEventHandler(
    object sender,
    dsExtendedPolicyInquiry.PolicyInvoicesRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void InvoiceActivityRowChangeEventHandler(
    object sender,
    dsExtendedPolicyInquiry.InvoiceActivityRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void InvoicePayeesRowChangeEventHandler(
    object sender,
    dsExtendedPolicyInquiry.InvoicePayeesRowChangeEvent e);

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class PolicyHeaderDataTable : TypedTableBase<dsExtendedPolicyInquiry.PolicyHeaderRow>
  {
    private DataColumn columnQuoteId;
    private DataColumn columnControl_Number;
    private DataColumn columnPolicy_Number;
    private DataColumn columnInsured;
    private DataColumn columnProducer;
    private DataColumn columnCompany;
    private DataColumn columnLine;
    private DataColumn columnStatus;
    private DataColumn columnEffective_Date;
    private DataColumn columnExpiration_Date;
    private DataColumn columnUnderwriter;
    private DataColumn columnGross_Premium;
    private DataColumn columnFees;
    private DataColumn columnOutstanding_AR;
    private DataColumn columnOutstanding_AP;
    private DataColumn columnInsuredGuid;
    private DataColumn columnProducerGuid;
    private DataColumn columnProducerLocationGuid;
    private DataColumn columnCompanyLineGuid;
    private DataColumn columnCompanyLocationGuid;
    private DataColumn columnCompanyGuid;
    private DataColumn columnGLCompanyId;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public PolicyHeaderDataTable()
    {
      this.TableName = "PolicyHeader";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal PolicyHeaderDataTable(DataTable table)
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
    protected PolicyHeaderDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn QuoteIdColumn => this.columnQuoteId;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn Control_NumberColumn => this.columnControl_Number;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn Policy_NumberColumn => this.columnPolicy_Number;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn InsuredColumn => this.columnInsured;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ProducerColumn => this.columnProducer;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn CompanyColumn => this.columnCompany;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn LineColumn => this.columnLine;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn StatusColumn => this.columnStatus;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn Effective_DateColumn => this.columnEffective_Date;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn Expiration_DateColumn => this.columnExpiration_Date;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn UnderwriterColumn => this.columnUnderwriter;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn Gross_PremiumColumn => this.columnGross_Premium;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn FeesColumn => this.columnFees;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn Outstanding_ARColumn => this.columnOutstanding_AR;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn Outstanding_APColumn => this.columnOutstanding_AP;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn InsuredGuidColumn => this.columnInsuredGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ProducerGuidColumn => this.columnProducerGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ProducerLocationGuidColumn => this.columnProducerLocationGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn CompanyLineGuidColumn => this.columnCompanyLineGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn CompanyLocationGuidColumn => this.columnCompanyLocationGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn CompanyGuidColumn => this.columnCompanyGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn GLCompanyIdColumn => this.columnGLCompanyId;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsExtendedPolicyInquiry.PolicyHeaderRow this[int index]
    {
      get => (dsExtendedPolicyInquiry.PolicyHeaderRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsExtendedPolicyInquiry.PolicyHeaderRowChangeEventHandler PolicyHeaderRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsExtendedPolicyInquiry.PolicyHeaderRowChangeEventHandler PolicyHeaderRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsExtendedPolicyInquiry.PolicyHeaderRowChangeEventHandler PolicyHeaderRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsExtendedPolicyInquiry.PolicyHeaderRowChangeEventHandler PolicyHeaderRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddPolicyHeaderRow(dsExtendedPolicyInquiry.PolicyHeaderRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsExtendedPolicyInquiry.PolicyHeaderRow AddPolicyHeaderRow(
      int QuoteId,
      int Control_Number,
      string Policy_Number,
      string Insured,
      string Producer,
      string Company,
      string Line,
      string Status,
      DateTime Effective_Date,
      DateTime Expiration_Date,
      string Underwriter,
      Decimal Gross_Premium,
      Decimal Fees,
      Decimal Outstanding_AR,
      Decimal Outstanding_AP,
      Guid InsuredGuid,
      Guid ProducerGuid,
      Guid ProducerLocationGuid,
      Guid CompanyLineGuid,
      Guid CompanyLocationGuid,
      Guid CompanyGuid,
      int GLCompanyId)
    {
      dsExtendedPolicyInquiry.PolicyHeaderRow row = (dsExtendedPolicyInquiry.PolicyHeaderRow) this.NewRow();
      object[] objArray = new object[22]
      {
        (object) QuoteId,
        (object) Control_Number,
        (object) Policy_Number,
        (object) Insured,
        (object) Producer,
        (object) Company,
        (object) Line,
        (object) Status,
        (object) Effective_Date,
        (object) Expiration_Date,
        (object) Underwriter,
        (object) Gross_Premium,
        (object) Fees,
        (object) Outstanding_AR,
        (object) Outstanding_AP,
        (object) InsuredGuid,
        (object) ProducerGuid,
        (object) ProducerLocationGuid,
        (object) CompanyLineGuid,
        (object) CompanyLocationGuid,
        (object) CompanyGuid,
        (object) GLCompanyId
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsExtendedPolicyInquiry.PolicyHeaderDataTable policyHeaderDataTable = (dsExtendedPolicyInquiry.PolicyHeaderDataTable) base.Clone();
      policyHeaderDataTable.InitVars();
      return (DataTable) policyHeaderDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsExtendedPolicyInquiry.PolicyHeaderDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnQuoteId = this.Columns["QuoteId"];
      this.columnControl_Number = this.Columns["Control Number"];
      this.columnPolicy_Number = this.Columns["Policy Number"];
      this.columnInsured = this.Columns["Insured"];
      this.columnProducer = this.Columns["Producer"];
      this.columnCompany = this.Columns["Company"];
      this.columnLine = this.Columns["Line"];
      this.columnStatus = this.Columns["Status"];
      this.columnEffective_Date = this.Columns["Effective Date"];
      this.columnExpiration_Date = this.Columns["Expiration Date"];
      this.columnUnderwriter = this.Columns["Underwriter"];
      this.columnGross_Premium = this.Columns["Gross Premium"];
      this.columnFees = this.Columns["Fees"];
      this.columnOutstanding_AR = this.Columns["Outstanding AR"];
      this.columnOutstanding_AP = this.Columns["Outstanding AP"];
      this.columnInsuredGuid = this.Columns["InsuredGuid"];
      this.columnProducerGuid = this.Columns["ProducerGuid"];
      this.columnProducerLocationGuid = this.Columns["ProducerLocationGuid"];
      this.columnCompanyLineGuid = this.Columns["CompanyLineGuid"];
      this.columnCompanyLocationGuid = this.Columns["CompanyLocationGuid"];
      this.columnCompanyGuid = this.Columns["CompanyGuid"];
      this.columnGLCompanyId = this.Columns["GLCompanyId"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnQuoteId = new DataColumn("QuoteId", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnQuoteId);
      this.columnControl_Number = new DataColumn("Control Number", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnControl_Number);
      this.columnPolicy_Number = new DataColumn("Policy Number", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPolicy_Number);
      this.columnInsured = new DataColumn("Insured", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInsured);
      this.columnProducer = new DataColumn("Producer", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnProducer);
      this.columnCompany = new DataColumn("Company", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCompany);
      this.columnLine = new DataColumn("Line", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLine);
      this.columnStatus = new DataColumn("Status", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnStatus);
      this.columnEffective_Date = new DataColumn("Effective Date", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEffective_Date);
      this.columnExpiration_Date = new DataColumn("Expiration Date", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnExpiration_Date);
      this.columnUnderwriter = new DataColumn("Underwriter", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnUnderwriter);
      this.columnGross_Premium = new DataColumn("Gross Premium", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnGross_Premium);
      this.columnFees = new DataColumn("Fees", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFees);
      this.columnOutstanding_AR = new DataColumn("Outstanding AR", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnOutstanding_AR);
      this.columnOutstanding_AP = new DataColumn("Outstanding AP", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnOutstanding_AP);
      this.columnInsuredGuid = new DataColumn("InsuredGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInsuredGuid);
      this.columnProducerGuid = new DataColumn("ProducerGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnProducerGuid);
      this.columnProducerLocationGuid = new DataColumn("ProducerLocationGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnProducerLocationGuid);
      this.columnCompanyLineGuid = new DataColumn("CompanyLineGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCompanyLineGuid);
      this.columnCompanyLocationGuid = new DataColumn("CompanyLocationGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCompanyLocationGuid);
      this.columnCompanyGuid = new DataColumn("CompanyGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCompanyGuid);
      this.columnGLCompanyId = new DataColumn("GLCompanyId", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnGLCompanyId);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsExtendedPolicyInquiry.PolicyHeaderRow NewPolicyHeaderRow()
    {
      return (dsExtendedPolicyInquiry.PolicyHeaderRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsExtendedPolicyInquiry.PolicyHeaderRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (dsExtendedPolicyInquiry.PolicyHeaderRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      if (this.PolicyHeaderRowChanged == null)
        return;
      this.PolicyHeaderRowChanged((object) this, new dsExtendedPolicyInquiry.PolicyHeaderRowChangeEvent((dsExtendedPolicyInquiry.PolicyHeaderRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      if (this.PolicyHeaderRowChanging == null)
        return;
      this.PolicyHeaderRowChanging((object) this, new dsExtendedPolicyInquiry.PolicyHeaderRowChangeEvent((dsExtendedPolicyInquiry.PolicyHeaderRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      if (this.PolicyHeaderRowDeleted == null)
        return;
      this.PolicyHeaderRowDeleted((object) this, new dsExtendedPolicyInquiry.PolicyHeaderRowChangeEvent((dsExtendedPolicyInquiry.PolicyHeaderRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      if (this.PolicyHeaderRowDeleting == null)
        return;
      this.PolicyHeaderRowDeleting((object) this, new dsExtendedPolicyInquiry.PolicyHeaderRowChangeEvent((dsExtendedPolicyInquiry.PolicyHeaderRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemovePolicyHeaderRow(dsExtendedPolicyInquiry.PolicyHeaderRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType typedTableSchema = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsExtendedPolicyInquiry extendedPolicyInquiry = new dsExtendedPolicyInquiry();
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
        FixedValue = extendedPolicyInquiry.Namespace
      });
      typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (PolicyHeaderDataTable)
      });
      typedTableSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = extendedPolicyInquiry.GetSchemaSerializable();
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
            current.Write((Stream) memoryStream2);
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
  public class PolicyInvoicesDataTable : TypedTableBase<dsExtendedPolicyInquiry.PolicyInvoicesRow>
  {
    private DataColumn columnInvoiceNum;
    private DataColumn columnControl_Number;
    private DataColumn columnInvoice_Number;
    private DataColumn columnPremium;
    private DataColumn columnFees;
    private DataColumn columnAR;
    private DataColumn columnAR_Rcvd;
    private DataColumn columnAP;
    private DataColumn columnAP_PTD;
    private DataColumn columnBilling_Type;
    private DataColumn columnFailed;
    private DataColumn columnQuoteId;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public PolicyInvoicesDataTable()
    {
      this.TableName = "PolicyInvoices";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal PolicyInvoicesDataTable(DataTable table)
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
    protected PolicyInvoicesDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn InvoiceNumColumn => this.columnInvoiceNum;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn Control_NumberColumn => this.columnControl_Number;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn Invoice_NumberColumn => this.columnInvoice_Number;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn PremiumColumn => this.columnPremium;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn FeesColumn => this.columnFees;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ARColumn => this.columnAR;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn AR_RcvdColumn => this.columnAR_Rcvd;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn APColumn => this.columnAP;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn AP_PTDColumn => this.columnAP_PTD;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn Billing_TypeColumn => this.columnBilling_Type;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn FailedColumn => this.columnFailed;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn QuoteIdColumn => this.columnQuoteId;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsExtendedPolicyInquiry.PolicyInvoicesRow this[int index]
    {
      get => (dsExtendedPolicyInquiry.PolicyInvoicesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsExtendedPolicyInquiry.PolicyInvoicesRowChangeEventHandler PolicyInvoicesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsExtendedPolicyInquiry.PolicyInvoicesRowChangeEventHandler PolicyInvoicesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsExtendedPolicyInquiry.PolicyInvoicesRowChangeEventHandler PolicyInvoicesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsExtendedPolicyInquiry.PolicyInvoicesRowChangeEventHandler PolicyInvoicesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddPolicyInvoicesRow(dsExtendedPolicyInquiry.PolicyInvoicesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsExtendedPolicyInquiry.PolicyInvoicesRow AddPolicyInvoicesRow(
      int InvoiceNum,
      int Control_Number,
      int Invoice_Number,
      Decimal Premium,
      Decimal Fees,
      Decimal AR,
      Decimal AR_Rcvd,
      Decimal AP,
      Decimal AP_PTD,
      string Billing_Type,
      bool Failed,
      dsExtendedPolicyInquiry.PolicyHeaderRow parentPolicyHeaderRowByPolicyInvoices_PolicyHeader)
    {
      dsExtendedPolicyInquiry.PolicyInvoicesRow row = (dsExtendedPolicyInquiry.PolicyInvoicesRow) this.NewRow();
      object[] objArray = new object[12]
      {
        (object) InvoiceNum,
        (object) Control_Number,
        (object) Invoice_Number,
        (object) Premium,
        (object) Fees,
        (object) AR,
        (object) AR_Rcvd,
        (object) AP,
        (object) AP_PTD,
        (object) Billing_Type,
        (object) Failed,
        null
      };
      if (parentPolicyHeaderRowByPolicyInvoices_PolicyHeader != null)
        objArray[11] = parentPolicyHeaderRowByPolicyInvoices_PolicyHeader[0];
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsExtendedPolicyInquiry.PolicyInvoicesDataTable invoicesDataTable = (dsExtendedPolicyInquiry.PolicyInvoicesDataTable) base.Clone();
      invoicesDataTable.InitVars();
      return (DataTable) invoicesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsExtendedPolicyInquiry.PolicyInvoicesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnInvoiceNum = this.Columns["InvoiceNum"];
      this.columnControl_Number = this.Columns["Control Number"];
      this.columnInvoice_Number = this.Columns["Invoice Number"];
      this.columnPremium = this.Columns["Premium"];
      this.columnFees = this.Columns["Fees"];
      this.columnAR = this.Columns["AR"];
      this.columnAR_Rcvd = this.Columns["AR Rcvd"];
      this.columnAP = this.Columns["AP"];
      this.columnAP_PTD = this.Columns["AP PTD"];
      this.columnBilling_Type = this.Columns["Billing Type"];
      this.columnFailed = this.Columns["Failed"];
      this.columnQuoteId = this.Columns["QuoteId"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnInvoiceNum = new DataColumn("InvoiceNum", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInvoiceNum);
      this.columnControl_Number = new DataColumn("Control Number", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnControl_Number);
      this.columnInvoice_Number = new DataColumn("Invoice Number", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInvoice_Number);
      this.columnPremium = new DataColumn("Premium", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPremium);
      this.columnFees = new DataColumn("Fees", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFees);
      this.columnAR = new DataColumn("AR", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAR);
      this.columnAR_Rcvd = new DataColumn("AR Rcvd", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAR_Rcvd);
      this.columnAP = new DataColumn("AP", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAP);
      this.columnAP_PTD = new DataColumn("AP PTD", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAP_PTD);
      this.columnBilling_Type = new DataColumn("Billing Type", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnBilling_Type);
      this.columnFailed = new DataColumn("Failed", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFailed);
      this.columnQuoteId = new DataColumn("QuoteId", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnQuoteId);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsExtendedPolicyInquiry.PolicyInvoicesRow NewPolicyInvoicesRow()
    {
      return (dsExtendedPolicyInquiry.PolicyInvoicesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsExtendedPolicyInquiry.PolicyInvoicesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (dsExtendedPolicyInquiry.PolicyInvoicesRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      if (this.PolicyInvoicesRowChanged == null)
        return;
      this.PolicyInvoicesRowChanged((object) this, new dsExtendedPolicyInquiry.PolicyInvoicesRowChangeEvent((dsExtendedPolicyInquiry.PolicyInvoicesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      if (this.PolicyInvoicesRowChanging == null)
        return;
      this.PolicyInvoicesRowChanging((object) this, new dsExtendedPolicyInquiry.PolicyInvoicesRowChangeEvent((dsExtendedPolicyInquiry.PolicyInvoicesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      if (this.PolicyInvoicesRowDeleted == null)
        return;
      this.PolicyInvoicesRowDeleted((object) this, new dsExtendedPolicyInquiry.PolicyInvoicesRowChangeEvent((dsExtendedPolicyInquiry.PolicyInvoicesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      if (this.PolicyInvoicesRowDeleting == null)
        return;
      this.PolicyInvoicesRowDeleting((object) this, new dsExtendedPolicyInquiry.PolicyInvoicesRowChangeEvent((dsExtendedPolicyInquiry.PolicyInvoicesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemovePolicyInvoicesRow(dsExtendedPolicyInquiry.PolicyInvoicesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType typedTableSchema = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsExtendedPolicyInquiry extendedPolicyInquiry = new dsExtendedPolicyInquiry();
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
        FixedValue = extendedPolicyInquiry.Namespace
      });
      typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (PolicyInvoicesDataTable)
      });
      typedTableSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = extendedPolicyInquiry.GetSchemaSerializable();
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
            current.Write((Stream) memoryStream2);
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
  public class InvoiceActivityDataTable : TypedTableBase<dsExtendedPolicyInquiry.InvoiceActivityRow>
  {
    private DataColumn columnInvoiceNum;
    private DataColumn columnTransaction_Number;
    private DataColumn columnTransaction_Type;
    private DataColumn columnTransaction_Date;
    private DataColumn columnUser;
    private DataColumn columnCash_Amount;
    private DataColumn columnAP_Amount;
    private DataColumn columnAR_Amount;
    private DataColumn _columnUn_Acct_Amount;
    private DataColumn columnExch_Amount;
    private DataColumn columnCheck_Number;
    private DataColumn columnComments;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public InvoiceActivityDataTable()
    {
      this.TableName = "InvoiceActivity";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal InvoiceActivityDataTable(DataTable table)
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
    protected InvoiceActivityDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn InvoiceNumColumn => this.columnInvoiceNum;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn Transaction_NumberColumn => this.columnTransaction_Number;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn Transaction_TypeColumn => this.columnTransaction_Type;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn Transaction_DateColumn => this.columnTransaction_Date;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn UserColumn => this.columnUser;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn Cash_AmountColumn => this.columnCash_Amount;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn AP_AmountColumn => this.columnAP_Amount;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn AR_AmountColumn => this.columnAR_Amount;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn _Un_Acct_AmountColumn => this._columnUn_Acct_Amount;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn Exch_AmountColumn => this.columnExch_Amount;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn Check_NumberColumn => this.columnCheck_Number;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn CommentsColumn => this.columnComments;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsExtendedPolicyInquiry.InvoiceActivityRow this[int index]
    {
      get => (dsExtendedPolicyInquiry.InvoiceActivityRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsExtendedPolicyInquiry.InvoiceActivityRowChangeEventHandler InvoiceActivityRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsExtendedPolicyInquiry.InvoiceActivityRowChangeEventHandler InvoiceActivityRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsExtendedPolicyInquiry.InvoiceActivityRowChangeEventHandler InvoiceActivityRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsExtendedPolicyInquiry.InvoiceActivityRowChangeEventHandler InvoiceActivityRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddInvoiceActivityRow(dsExtendedPolicyInquiry.InvoiceActivityRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsExtendedPolicyInquiry.InvoiceActivityRow AddInvoiceActivityRow(
      dsExtendedPolicyInquiry.PolicyInvoicesRow parentPolicyInvoicesRowByPolicyInvoices_InvoiceActivity,
      int Transaction_Number,
      string Transaction_Type,
      DateTime Transaction_Date,
      string User,
      Decimal Cash_Amount,
      Decimal AP_Amount,
      Decimal AR_Amount,
      Decimal _Un_Acct_Amount,
      Decimal Exch_Amount,
      string Check_Number,
      string Comments)
    {
      dsExtendedPolicyInquiry.InvoiceActivityRow row = (dsExtendedPolicyInquiry.InvoiceActivityRow) this.NewRow();
      object[] objArray = new object[12]
      {
        null,
        (object) Transaction_Number,
        (object) Transaction_Type,
        (object) Transaction_Date,
        (object) User,
        (object) Cash_Amount,
        (object) AP_Amount,
        (object) AR_Amount,
        (object) _Un_Acct_Amount,
        (object) Exch_Amount,
        (object) Check_Number,
        (object) Comments
      };
      if (parentPolicyInvoicesRowByPolicyInvoices_InvoiceActivity != null)
        objArray[0] = parentPolicyInvoicesRowByPolicyInvoices_InvoiceActivity[0];
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsExtendedPolicyInquiry.InvoiceActivityDataTable activityDataTable = (dsExtendedPolicyInquiry.InvoiceActivityDataTable) base.Clone();
      activityDataTable.InitVars();
      return (DataTable) activityDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsExtendedPolicyInquiry.InvoiceActivityDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnInvoiceNum = this.Columns["InvoiceNum"];
      this.columnTransaction_Number = this.Columns["Transaction Number"];
      this.columnTransaction_Type = this.Columns["Transaction Type"];
      this.columnTransaction_Date = this.Columns["Transaction Date"];
      this.columnUser = this.Columns["User"];
      this.columnCash_Amount = this.Columns["Cash Amount"];
      this.columnAP_Amount = this.Columns["AP Amount"];
      this.columnAR_Amount = this.Columns["AR Amount"];
      this._columnUn_Acct_Amount = this.Columns["Un-Acct Amount"];
      this.columnExch_Amount = this.Columns["Exch Amount"];
      this.columnCheck_Number = this.Columns["Check Number"];
      this.columnComments = this.Columns["Comments"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnInvoiceNum = new DataColumn("InvoiceNum", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInvoiceNum);
      this.columnTransaction_Number = new DataColumn("Transaction Number", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnTransaction_Number);
      this.columnTransaction_Type = new DataColumn("Transaction Type", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnTransaction_Type);
      this.columnTransaction_Date = new DataColumn("Transaction Date", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnTransaction_Date);
      this.columnUser = new DataColumn("User", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnUser);
      this.columnCash_Amount = new DataColumn("Cash Amount", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCash_Amount);
      this.columnAP_Amount = new DataColumn("AP Amount", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAP_Amount);
      this.columnAR_Amount = new DataColumn("AR Amount", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAR_Amount);
      this._columnUn_Acct_Amount = new DataColumn("Un-Acct Amount", typeof (Decimal), (string) null, MappingType.Element);
      this._columnUn_Acct_Amount.ExtendedProperties.Add((object) "Generator_ColumnVarNameInTable", (object) "_columnUn_Acct_Amount");
      this._columnUn_Acct_Amount.ExtendedProperties.Add((object) "Generator_UserColumnName", (object) "Un-Acct Amount");
      this.Columns.Add(this._columnUn_Acct_Amount);
      this.columnExch_Amount = new DataColumn("Exch Amount", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnExch_Amount);
      this.columnCheck_Number = new DataColumn("Check Number", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCheck_Number);
      this.columnComments = new DataColumn("Comments", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnComments);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsExtendedPolicyInquiry.InvoiceActivityRow NewInvoiceActivityRow()
    {
      return (dsExtendedPolicyInquiry.InvoiceActivityRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsExtendedPolicyInquiry.InvoiceActivityRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (dsExtendedPolicyInquiry.InvoiceActivityRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      if (this.InvoiceActivityRowChanged == null)
        return;
      this.InvoiceActivityRowChanged((object) this, new dsExtendedPolicyInquiry.InvoiceActivityRowChangeEvent((dsExtendedPolicyInquiry.InvoiceActivityRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      if (this.InvoiceActivityRowChanging == null)
        return;
      this.InvoiceActivityRowChanging((object) this, new dsExtendedPolicyInquiry.InvoiceActivityRowChangeEvent((dsExtendedPolicyInquiry.InvoiceActivityRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      if (this.InvoiceActivityRowDeleted == null)
        return;
      this.InvoiceActivityRowDeleted((object) this, new dsExtendedPolicyInquiry.InvoiceActivityRowChangeEvent((dsExtendedPolicyInquiry.InvoiceActivityRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      if (this.InvoiceActivityRowDeleting == null)
        return;
      this.InvoiceActivityRowDeleting((object) this, new dsExtendedPolicyInquiry.InvoiceActivityRowChangeEvent((dsExtendedPolicyInquiry.InvoiceActivityRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemoveInvoiceActivityRow(dsExtendedPolicyInquiry.InvoiceActivityRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType typedTableSchema = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsExtendedPolicyInquiry extendedPolicyInquiry = new dsExtendedPolicyInquiry();
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
        FixedValue = extendedPolicyInquiry.Namespace
      });
      typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (InvoiceActivityDataTable)
      });
      typedTableSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = extendedPolicyInquiry.GetSchemaSerializable();
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
            current.Write((Stream) memoryStream2);
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
  public class InvoicePayeesDataTable : TypedTableBase<dsExtendedPolicyInquiry.InvoicePayeesRow>
  {
    private DataColumn columnInvoiceNum;
    private DataColumn columnControlNumber;
    private DataColumn columnPayeeGuid;
    private DataColumn columnPayeeName;
    private DataColumn columnPayeeAmt;
    private DataColumn columnOutstanding_AP;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public InvoicePayeesDataTable()
    {
      this.TableName = "InvoicePayees";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal InvoicePayeesDataTable(DataTable table)
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
    protected InvoicePayeesDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn InvoiceNumColumn => this.columnInvoiceNum;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ControlNumberColumn => this.columnControlNumber;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn PayeeGuidColumn => this.columnPayeeGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn PayeeNameColumn => this.columnPayeeName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn PayeeAmtColumn => this.columnPayeeAmt;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn Outstanding_APColumn => this.columnOutstanding_AP;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsExtendedPolicyInquiry.InvoicePayeesRow this[int index]
    {
      get => (dsExtendedPolicyInquiry.InvoicePayeesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsExtendedPolicyInquiry.InvoicePayeesRowChangeEventHandler InvoicePayeesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsExtendedPolicyInquiry.InvoicePayeesRowChangeEventHandler InvoicePayeesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsExtendedPolicyInquiry.InvoicePayeesRowChangeEventHandler InvoicePayeesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsExtendedPolicyInquiry.InvoicePayeesRowChangeEventHandler InvoicePayeesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddInvoicePayeesRow(dsExtendedPolicyInquiry.InvoicePayeesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsExtendedPolicyInquiry.InvoicePayeesRow AddInvoicePayeesRow(
      dsExtendedPolicyInquiry.PolicyInvoicesRow parentPolicyInvoicesRowByPolicyInvoices_InvoicePayees,
      int ControlNumber,
      Guid PayeeGuid,
      string PayeeName,
      Decimal PayeeAmt,
      Decimal Outstanding_AP)
    {
      dsExtendedPolicyInquiry.InvoicePayeesRow row = (dsExtendedPolicyInquiry.InvoicePayeesRow) this.NewRow();
      object[] objArray = new object[6]
      {
        null,
        (object) ControlNumber,
        (object) PayeeGuid,
        (object) PayeeName,
        (object) PayeeAmt,
        (object) Outstanding_AP
      };
      if (parentPolicyInvoicesRowByPolicyInvoices_InvoicePayees != null)
        objArray[0] = parentPolicyInvoicesRowByPolicyInvoices_InvoicePayees[0];
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsExtendedPolicyInquiry.InvoicePayeesDataTable invoicePayeesDataTable = (dsExtendedPolicyInquiry.InvoicePayeesDataTable) base.Clone();
      invoicePayeesDataTable.InitVars();
      return (DataTable) invoicePayeesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsExtendedPolicyInquiry.InvoicePayeesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnInvoiceNum = this.Columns["InvoiceNum"];
      this.columnControlNumber = this.Columns["ControlNumber"];
      this.columnPayeeGuid = this.Columns["PayeeGuid"];
      this.columnPayeeName = this.Columns["PayeeName"];
      this.columnPayeeAmt = this.Columns["PayeeAmt"];
      this.columnOutstanding_AP = this.Columns["Outstanding AP"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnInvoiceNum = new DataColumn("InvoiceNum", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInvoiceNum);
      this.columnControlNumber = new DataColumn("ControlNumber", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnControlNumber);
      this.columnPayeeGuid = new DataColumn("PayeeGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPayeeGuid);
      this.columnPayeeName = new DataColumn("PayeeName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPayeeName);
      this.columnPayeeAmt = new DataColumn("PayeeAmt", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPayeeAmt);
      this.columnOutstanding_AP = new DataColumn("Outstanding AP", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnOutstanding_AP);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsExtendedPolicyInquiry.InvoicePayeesRow NewInvoicePayeesRow()
    {
      return (dsExtendedPolicyInquiry.InvoicePayeesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsExtendedPolicyInquiry.InvoicePayeesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (dsExtendedPolicyInquiry.InvoicePayeesRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      if (this.InvoicePayeesRowChanged == null)
        return;
      this.InvoicePayeesRowChanged((object) this, new dsExtendedPolicyInquiry.InvoicePayeesRowChangeEvent((dsExtendedPolicyInquiry.InvoicePayeesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      if (this.InvoicePayeesRowChanging == null)
        return;
      this.InvoicePayeesRowChanging((object) this, new dsExtendedPolicyInquiry.InvoicePayeesRowChangeEvent((dsExtendedPolicyInquiry.InvoicePayeesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      if (this.InvoicePayeesRowDeleted == null)
        return;
      this.InvoicePayeesRowDeleted((object) this, new dsExtendedPolicyInquiry.InvoicePayeesRowChangeEvent((dsExtendedPolicyInquiry.InvoicePayeesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      if (this.InvoicePayeesRowDeleting == null)
        return;
      this.InvoicePayeesRowDeleting((object) this, new dsExtendedPolicyInquiry.InvoicePayeesRowChangeEvent((dsExtendedPolicyInquiry.InvoicePayeesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemoveInvoicePayeesRow(dsExtendedPolicyInquiry.InvoicePayeesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType typedTableSchema = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsExtendedPolicyInquiry extendedPolicyInquiry = new dsExtendedPolicyInquiry();
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
        FixedValue = extendedPolicyInquiry.Namespace
      });
      typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (InvoicePayeesDataTable)
      });
      typedTableSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = extendedPolicyInquiry.GetSchemaSerializable();
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
            current.Write((Stream) memoryStream2);
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

  public class PolicyHeaderRow : DataRow
  {
    private dsExtendedPolicyInquiry.PolicyHeaderDataTable tablePolicyHeader;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal PolicyHeaderRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablePolicyHeader = (dsExtendedPolicyInquiry.PolicyHeaderDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int QuoteId
    {
      get
      {
        try
        {
          return (int) this[this.tablePolicyHeader.QuoteIdColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'QuoteId' in table 'PolicyHeader' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePolicyHeader.QuoteIdColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int Control_Number
    {
      get
      {
        try
        {
          return (int) this[this.tablePolicyHeader.Control_NumberColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'Control Number' in table 'PolicyHeader' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePolicyHeader.Control_NumberColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Policy_Number
    {
      get
      {
        try
        {
          return (string) this[this.tablePolicyHeader.Policy_NumberColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'Policy Number' in table 'PolicyHeader' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePolicyHeader.Policy_NumberColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Insured
    {
      get
      {
        try
        {
          return (string) this[this.tablePolicyHeader.InsuredColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'Insured' in table 'PolicyHeader' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePolicyHeader.InsuredColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Producer
    {
      get
      {
        try
        {
          return (string) this[this.tablePolicyHeader.ProducerColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'Producer' in table 'PolicyHeader' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePolicyHeader.ProducerColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Company
    {
      get
      {
        try
        {
          return (string) this[this.tablePolicyHeader.CompanyColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'Company' in table 'PolicyHeader' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePolicyHeader.CompanyColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Line
    {
      get
      {
        try
        {
          return (string) this[this.tablePolicyHeader.LineColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'Line' in table 'PolicyHeader' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePolicyHeader.LineColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Status
    {
      get
      {
        try
        {
          return (string) this[this.tablePolicyHeader.StatusColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'Status' in table 'PolicyHeader' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePolicyHeader.StatusColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DateTime Effective_Date
    {
      get
      {
        try
        {
          return (DateTime) this[this.tablePolicyHeader.Effective_DateColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'Effective Date' in table 'PolicyHeader' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePolicyHeader.Effective_DateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DateTime Expiration_Date
    {
      get
      {
        try
        {
          return (DateTime) this[this.tablePolicyHeader.Expiration_DateColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'Expiration Date' in table 'PolicyHeader' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePolicyHeader.Expiration_DateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Underwriter
    {
      get
      {
        try
        {
          return (string) this[this.tablePolicyHeader.UnderwriterColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'Underwriter' in table 'PolicyHeader' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePolicyHeader.UnderwriterColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal Gross_Premium
    {
      get
      {
        try
        {
          return (Decimal) this[this.tablePolicyHeader.Gross_PremiumColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'Gross Premium' in table 'PolicyHeader' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePolicyHeader.Gross_PremiumColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal Fees
    {
      get
      {
        try
        {
          return (Decimal) this[this.tablePolicyHeader.FeesColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'Fees' in table 'PolicyHeader' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePolicyHeader.FeesColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal Outstanding_AR
    {
      get
      {
        try
        {
          return (Decimal) this[this.tablePolicyHeader.Outstanding_ARColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'Outstanding AR' in table 'PolicyHeader' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePolicyHeader.Outstanding_ARColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal Outstanding_AP
    {
      get
      {
        try
        {
          return (Decimal) this[this.tablePolicyHeader.Outstanding_APColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'Outstanding AP' in table 'PolicyHeader' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePolicyHeader.Outstanding_APColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Guid InsuredGuid
    {
      get
      {
        try
        {
          return (Guid) this[this.tablePolicyHeader.InsuredGuidColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'InsuredGuid' in table 'PolicyHeader' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePolicyHeader.InsuredGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Guid ProducerGuid
    {
      get
      {
        try
        {
          return (Guid) this[this.tablePolicyHeader.ProducerGuidColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'ProducerGuid' in table 'PolicyHeader' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePolicyHeader.ProducerGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Guid ProducerLocationGuid
    {
      get
      {
        try
        {
          return (Guid) this[this.tablePolicyHeader.ProducerLocationGuidColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'ProducerLocationGuid' in table 'PolicyHeader' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePolicyHeader.ProducerLocationGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Guid CompanyLineGuid
    {
      get
      {
        try
        {
          return (Guid) this[this.tablePolicyHeader.CompanyLineGuidColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'CompanyLineGuid' in table 'PolicyHeader' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePolicyHeader.CompanyLineGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Guid CompanyLocationGuid
    {
      get
      {
        try
        {
          return (Guid) this[this.tablePolicyHeader.CompanyLocationGuidColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'CompanyLocationGuid' in table 'PolicyHeader' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePolicyHeader.CompanyLocationGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Guid CompanyGuid
    {
      get
      {
        try
        {
          return (Guid) this[this.tablePolicyHeader.CompanyGuidColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'CompanyGuid' in table 'PolicyHeader' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePolicyHeader.CompanyGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int GLCompanyId
    {
      get
      {
        try
        {
          return (int) this[this.tablePolicyHeader.GLCompanyIdColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'GLCompanyId' in table 'PolicyHeader' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePolicyHeader.GLCompanyIdColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsQuoteIdNull() => this.IsNull(this.tablePolicyHeader.QuoteIdColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetQuoteIdNull() => this[this.tablePolicyHeader.QuoteIdColumn] = Convert.DBNull;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsControl_NumberNull() => this.IsNull(this.tablePolicyHeader.Control_NumberColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetControl_NumberNull()
    {
      this[this.tablePolicyHeader.Control_NumberColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsPolicy_NumberNull() => this.IsNull(this.tablePolicyHeader.Policy_NumberColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetPolicy_NumberNull()
    {
      this[this.tablePolicyHeader.Policy_NumberColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsInsuredNull() => this.IsNull(this.tablePolicyHeader.InsuredColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetInsuredNull() => this[this.tablePolicyHeader.InsuredColumn] = Convert.DBNull;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsProducerNull() => this.IsNull(this.tablePolicyHeader.ProducerColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetProducerNull() => this[this.tablePolicyHeader.ProducerColumn] = Convert.DBNull;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsCompanyNull() => this.IsNull(this.tablePolicyHeader.CompanyColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetCompanyNull() => this[this.tablePolicyHeader.CompanyColumn] = Convert.DBNull;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsLineNull() => this.IsNull(this.tablePolicyHeader.LineColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetLineNull() => this[this.tablePolicyHeader.LineColumn] = Convert.DBNull;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsStatusNull() => this.IsNull(this.tablePolicyHeader.StatusColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetStatusNull() => this[this.tablePolicyHeader.StatusColumn] = Convert.DBNull;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsEffective_DateNull() => this.IsNull(this.tablePolicyHeader.Effective_DateColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetEffective_DateNull()
    {
      this[this.tablePolicyHeader.Effective_DateColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsExpiration_DateNull()
    {
      return this.IsNull(this.tablePolicyHeader.Expiration_DateColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetExpiration_DateNull()
    {
      this[this.tablePolicyHeader.Expiration_DateColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsUnderwriterNull() => this.IsNull(this.tablePolicyHeader.UnderwriterColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetUnderwriterNull()
    {
      this[this.tablePolicyHeader.UnderwriterColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsGross_PremiumNull() => this.IsNull(this.tablePolicyHeader.Gross_PremiumColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetGross_PremiumNull()
    {
      this[this.tablePolicyHeader.Gross_PremiumColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsFeesNull() => this.IsNull(this.tablePolicyHeader.FeesColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetFeesNull() => this[this.tablePolicyHeader.FeesColumn] = Convert.DBNull;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsOutstanding_ARNull() => this.IsNull(this.tablePolicyHeader.Outstanding_ARColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetOutstanding_ARNull()
    {
      this[this.tablePolicyHeader.Outstanding_ARColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsOutstanding_APNull() => this.IsNull(this.tablePolicyHeader.Outstanding_APColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetOutstanding_APNull()
    {
      this[this.tablePolicyHeader.Outstanding_APColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsInsuredGuidNull() => this.IsNull(this.tablePolicyHeader.InsuredGuidColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetInsuredGuidNull()
    {
      this[this.tablePolicyHeader.InsuredGuidColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsProducerGuidNull() => this.IsNull(this.tablePolicyHeader.ProducerGuidColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetProducerGuidNull()
    {
      this[this.tablePolicyHeader.ProducerGuidColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsProducerLocationGuidNull()
    {
      return this.IsNull(this.tablePolicyHeader.ProducerLocationGuidColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetProducerLocationGuidNull()
    {
      this[this.tablePolicyHeader.ProducerLocationGuidColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsCompanyLineGuidNull()
    {
      return this.IsNull(this.tablePolicyHeader.CompanyLineGuidColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetCompanyLineGuidNull()
    {
      this[this.tablePolicyHeader.CompanyLineGuidColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsCompanyLocationGuidNull()
    {
      return this.IsNull(this.tablePolicyHeader.CompanyLocationGuidColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetCompanyLocationGuidNull()
    {
      this[this.tablePolicyHeader.CompanyLocationGuidColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsCompanyGuidNull() => this.IsNull(this.tablePolicyHeader.CompanyGuidColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetCompanyGuidNull()
    {
      this[this.tablePolicyHeader.CompanyGuidColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsGLCompanyIdNull() => this.IsNull(this.tablePolicyHeader.GLCompanyIdColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetGLCompanyIdNull()
    {
      this[this.tablePolicyHeader.GLCompanyIdColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsExtendedPolicyInquiry.PolicyInvoicesRow[] GetPolicyInvoicesRows()
    {
      return this.Table.ChildRelations["PolicyInvoices_PolicyHeader"] == null ? new dsExtendedPolicyInquiry.PolicyInvoicesRow[0] : (dsExtendedPolicyInquiry.PolicyInvoicesRow[]) this.GetChildRows(this.Table.ChildRelations["PolicyInvoices_PolicyHeader"]);
    }
  }

  public class PolicyInvoicesRow : DataRow
  {
    private dsExtendedPolicyInquiry.PolicyInvoicesDataTable tablePolicyInvoices;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal PolicyInvoicesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablePolicyInvoices = (dsExtendedPolicyInquiry.PolicyInvoicesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int InvoiceNum
    {
      get
      {
        try
        {
          return (int) this[this.tablePolicyInvoices.InvoiceNumColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'InvoiceNum' in table 'PolicyInvoices' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePolicyInvoices.InvoiceNumColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int Control_Number
    {
      get
      {
        try
        {
          return (int) this[this.tablePolicyInvoices.Control_NumberColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'Control Number' in table 'PolicyInvoices' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePolicyInvoices.Control_NumberColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int Invoice_Number
    {
      get
      {
        try
        {
          return (int) this[this.tablePolicyInvoices.Invoice_NumberColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'Invoice Number' in table 'PolicyInvoices' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePolicyInvoices.Invoice_NumberColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal Premium
    {
      get
      {
        try
        {
          return (Decimal) this[this.tablePolicyInvoices.PremiumColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'Premium' in table 'PolicyInvoices' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePolicyInvoices.PremiumColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal Fees
    {
      get
      {
        try
        {
          return (Decimal) this[this.tablePolicyInvoices.FeesColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'Fees' in table 'PolicyInvoices' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePolicyInvoices.FeesColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal AR
    {
      get
      {
        try
        {
          return (Decimal) this[this.tablePolicyInvoices.ARColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'AR' in table 'PolicyInvoices' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePolicyInvoices.ARColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal AR_Rcvd
    {
      get
      {
        try
        {
          return (Decimal) this[this.tablePolicyInvoices.AR_RcvdColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'AR Rcvd' in table 'PolicyInvoices' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePolicyInvoices.AR_RcvdColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal AP
    {
      get
      {
        try
        {
          return (Decimal) this[this.tablePolicyInvoices.APColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'AP' in table 'PolicyInvoices' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePolicyInvoices.APColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal AP_PTD
    {
      get
      {
        try
        {
          return (Decimal) this[this.tablePolicyInvoices.AP_PTDColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'AP PTD' in table 'PolicyInvoices' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePolicyInvoices.AP_PTDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Billing_Type
    {
      get
      {
        try
        {
          return (string) this[this.tablePolicyInvoices.Billing_TypeColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'Billing Type' in table 'PolicyInvoices' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePolicyInvoices.Billing_TypeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool Failed
    {
      get
      {
        try
        {
          return (bool) this[this.tablePolicyInvoices.FailedColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'Failed' in table 'PolicyInvoices' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePolicyInvoices.FailedColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int QuoteId
    {
      get
      {
        try
        {
          return (int) this[this.tablePolicyInvoices.QuoteIdColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'QuoteId' in table 'PolicyInvoices' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePolicyInvoices.QuoteIdColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsExtendedPolicyInquiry.PolicyHeaderRow PolicyHeaderRow
    {
      get
      {
        return (dsExtendedPolicyInquiry.PolicyHeaderRow) this.GetParentRow(this.Table.ParentRelations["PolicyInvoices_PolicyHeader"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["PolicyInvoices_PolicyHeader"]);
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsInvoiceNumNull() => this.IsNull(this.tablePolicyInvoices.InvoiceNumColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetInvoiceNumNull()
    {
      this[this.tablePolicyInvoices.InvoiceNumColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsControl_NumberNull()
    {
      return this.IsNull(this.tablePolicyInvoices.Control_NumberColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetControl_NumberNull()
    {
      this[this.tablePolicyInvoices.Control_NumberColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsInvoice_NumberNull()
    {
      return this.IsNull(this.tablePolicyInvoices.Invoice_NumberColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetInvoice_NumberNull()
    {
      this[this.tablePolicyInvoices.Invoice_NumberColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsPremiumNull() => this.IsNull(this.tablePolicyInvoices.PremiumColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetPremiumNull() => this[this.tablePolicyInvoices.PremiumColumn] = Convert.DBNull;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsFeesNull() => this.IsNull(this.tablePolicyInvoices.FeesColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetFeesNull() => this[this.tablePolicyInvoices.FeesColumn] = Convert.DBNull;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsARNull() => this.IsNull(this.tablePolicyInvoices.ARColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetARNull() => this[this.tablePolicyInvoices.ARColumn] = Convert.DBNull;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsAR_RcvdNull() => this.IsNull(this.tablePolicyInvoices.AR_RcvdColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetAR_RcvdNull() => this[this.tablePolicyInvoices.AR_RcvdColumn] = Convert.DBNull;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsAPNull() => this.IsNull(this.tablePolicyInvoices.APColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetAPNull() => this[this.tablePolicyInvoices.APColumn] = Convert.DBNull;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsAP_PTDNull() => this.IsNull(this.tablePolicyInvoices.AP_PTDColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetAP_PTDNull() => this[this.tablePolicyInvoices.AP_PTDColumn] = Convert.DBNull;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsBilling_TypeNull() => this.IsNull(this.tablePolicyInvoices.Billing_TypeColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetBilling_TypeNull()
    {
      this[this.tablePolicyInvoices.Billing_TypeColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsFailedNull() => this.IsNull(this.tablePolicyInvoices.FailedColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetFailedNull() => this[this.tablePolicyInvoices.FailedColumn] = Convert.DBNull;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsQuoteIdNull() => this.IsNull(this.tablePolicyInvoices.QuoteIdColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetQuoteIdNull() => this[this.tablePolicyInvoices.QuoteIdColumn] = Convert.DBNull;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsExtendedPolicyInquiry.InvoiceActivityRow[] GetInvoiceActivityRows()
    {
      return this.Table.ChildRelations["PolicyInvoices_InvoiceActivity"] == null ? new dsExtendedPolicyInquiry.InvoiceActivityRow[0] : (dsExtendedPolicyInquiry.InvoiceActivityRow[]) this.GetChildRows(this.Table.ChildRelations["PolicyInvoices_InvoiceActivity"]);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsExtendedPolicyInquiry.InvoicePayeesRow[] GetInvoicePayeesRows()
    {
      return this.Table.ChildRelations["PolicyInvoices_InvoicePayees"] == null ? new dsExtendedPolicyInquiry.InvoicePayeesRow[0] : (dsExtendedPolicyInquiry.InvoicePayeesRow[]) this.GetChildRows(this.Table.ChildRelations["PolicyInvoices_InvoicePayees"]);
    }
  }

  public class InvoiceActivityRow : DataRow
  {
    private dsExtendedPolicyInquiry.InvoiceActivityDataTable tableInvoiceActivity;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal InvoiceActivityRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableInvoiceActivity = (dsExtendedPolicyInquiry.InvoiceActivityDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int InvoiceNum
    {
      get
      {
        try
        {
          return (int) this[this.tableInvoiceActivity.InvoiceNumColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'InvoiceNum' in table 'InvoiceActivity' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableInvoiceActivity.InvoiceNumColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int Transaction_Number
    {
      get
      {
        try
        {
          return (int) this[this.tableInvoiceActivity.Transaction_NumberColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'Transaction Number' in table 'InvoiceActivity' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableInvoiceActivity.Transaction_NumberColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Transaction_Type
    {
      get
      {
        try
        {
          return (string) this[this.tableInvoiceActivity.Transaction_TypeColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'Transaction Type' in table 'InvoiceActivity' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableInvoiceActivity.Transaction_TypeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DateTime Transaction_Date
    {
      get
      {
        try
        {
          return (DateTime) this[this.tableInvoiceActivity.Transaction_DateColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'Transaction Date' in table 'InvoiceActivity' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableInvoiceActivity.Transaction_DateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string User
    {
      get
      {
        try
        {
          return (string) this[this.tableInvoiceActivity.UserColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'User' in table 'InvoiceActivity' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableInvoiceActivity.UserColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal Cash_Amount
    {
      get
      {
        try
        {
          return (Decimal) this[this.tableInvoiceActivity.Cash_AmountColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'Cash Amount' in table 'InvoiceActivity' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableInvoiceActivity.Cash_AmountColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal AP_Amount
    {
      get
      {
        try
        {
          return (Decimal) this[this.tableInvoiceActivity.AP_AmountColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'AP Amount' in table 'InvoiceActivity' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableInvoiceActivity.AP_AmountColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal AR_Amount
    {
      get
      {
        try
        {
          return (Decimal) this[this.tableInvoiceActivity.AR_AmountColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'AR Amount' in table 'InvoiceActivity' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableInvoiceActivity.AR_AmountColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal _Un_Acct_Amount
    {
      get
      {
        try
        {
          return (Decimal) this[this.tableInvoiceActivity._Un_Acct_AmountColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'Un-Acct Amount' in table 'InvoiceActivity' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableInvoiceActivity._Un_Acct_AmountColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal Exch_Amount
    {
      get
      {
        try
        {
          return (Decimal) this[this.tableInvoiceActivity.Exch_AmountColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'Exch Amount' in table 'InvoiceActivity' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableInvoiceActivity.Exch_AmountColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Check_Number
    {
      get
      {
        try
        {
          return (string) this[this.tableInvoiceActivity.Check_NumberColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'Check Number' in table 'InvoiceActivity' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableInvoiceActivity.Check_NumberColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Comments
    {
      get
      {
        try
        {
          return (string) this[this.tableInvoiceActivity.CommentsColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'Comments' in table 'InvoiceActivity' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableInvoiceActivity.CommentsColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsExtendedPolicyInquiry.PolicyInvoicesRow PolicyInvoicesRow
    {
      get
      {
        return (dsExtendedPolicyInquiry.PolicyInvoicesRow) this.GetParentRow(this.Table.ParentRelations["PolicyInvoices_InvoiceActivity"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["PolicyInvoices_InvoiceActivity"]);
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsInvoiceNumNull() => this.IsNull(this.tableInvoiceActivity.InvoiceNumColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetInvoiceNumNull()
    {
      this[this.tableInvoiceActivity.InvoiceNumColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsTransaction_NumberNull()
    {
      return this.IsNull(this.tableInvoiceActivity.Transaction_NumberColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetTransaction_NumberNull()
    {
      this[this.tableInvoiceActivity.Transaction_NumberColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsTransaction_TypeNull()
    {
      return this.IsNull(this.tableInvoiceActivity.Transaction_TypeColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetTransaction_TypeNull()
    {
      this[this.tableInvoiceActivity.Transaction_TypeColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsTransaction_DateNull()
    {
      return this.IsNull(this.tableInvoiceActivity.Transaction_DateColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetTransaction_DateNull()
    {
      this[this.tableInvoiceActivity.Transaction_DateColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsUserNull() => this.IsNull(this.tableInvoiceActivity.UserColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetUserNull() => this[this.tableInvoiceActivity.UserColumn] = Convert.DBNull;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsCash_AmountNull() => this.IsNull(this.tableInvoiceActivity.Cash_AmountColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetCash_AmountNull()
    {
      this[this.tableInvoiceActivity.Cash_AmountColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsAP_AmountNull() => this.IsNull(this.tableInvoiceActivity.AP_AmountColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetAP_AmountNull()
    {
      this[this.tableInvoiceActivity.AP_AmountColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsAR_AmountNull() => this.IsNull(this.tableInvoiceActivity.AR_AmountColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetAR_AmountNull()
    {
      this[this.tableInvoiceActivity.AR_AmountColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool Is_Un_Acct_AmountNull()
    {
      return this.IsNull(this.tableInvoiceActivity._Un_Acct_AmountColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void Set_Un_Acct_AmountNull()
    {
      this[this.tableInvoiceActivity._Un_Acct_AmountColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsExch_AmountNull() => this.IsNull(this.tableInvoiceActivity.Exch_AmountColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetExch_AmountNull()
    {
      this[this.tableInvoiceActivity.Exch_AmountColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsCheck_NumberNull() => this.IsNull(this.tableInvoiceActivity.Check_NumberColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetCheck_NumberNull()
    {
      this[this.tableInvoiceActivity.Check_NumberColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsCommentsNull() => this.IsNull(this.tableInvoiceActivity.CommentsColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetCommentsNull()
    {
      this[this.tableInvoiceActivity.CommentsColumn] = Convert.DBNull;
    }
  }

  public class InvoicePayeesRow : DataRow
  {
    private dsExtendedPolicyInquiry.InvoicePayeesDataTable tableInvoicePayees;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal InvoicePayeesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableInvoicePayees = (dsExtendedPolicyInquiry.InvoicePayeesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int InvoiceNum
    {
      get
      {
        try
        {
          return (int) this[this.tableInvoicePayees.InvoiceNumColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'InvoiceNum' in table 'InvoicePayees' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableInvoicePayees.InvoiceNumColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int ControlNumber
    {
      get
      {
        try
        {
          return (int) this[this.tableInvoicePayees.ControlNumberColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'ControlNumber' in table 'InvoicePayees' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableInvoicePayees.ControlNumberColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Guid PayeeGuid
    {
      get
      {
        try
        {
          return (Guid) this[this.tableInvoicePayees.PayeeGuidColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'PayeeGuid' in table 'InvoicePayees' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableInvoicePayees.PayeeGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string PayeeName
    {
      get
      {
        try
        {
          return (string) this[this.tableInvoicePayees.PayeeNameColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'PayeeName' in table 'InvoicePayees' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableInvoicePayees.PayeeNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal PayeeAmt
    {
      get
      {
        try
        {
          return (Decimal) this[this.tableInvoicePayees.PayeeAmtColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'PayeeAmt' in table 'InvoicePayees' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableInvoicePayees.PayeeAmtColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal Outstanding_AP
    {
      get
      {
        try
        {
          return (Decimal) this[this.tableInvoicePayees.Outstanding_APColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'Outstanding AP' in table 'InvoicePayees' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableInvoicePayees.Outstanding_APColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsExtendedPolicyInquiry.PolicyInvoicesRow PolicyInvoicesRow
    {
      get
      {
        return (dsExtendedPolicyInquiry.PolicyInvoicesRow) this.GetParentRow(this.Table.ParentRelations["PolicyInvoices_InvoicePayees"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["PolicyInvoices_InvoicePayees"]);
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsInvoiceNumNull() => this.IsNull(this.tableInvoicePayees.InvoiceNumColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetInvoiceNumNull()
    {
      this[this.tableInvoicePayees.InvoiceNumColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsControlNumberNull() => this.IsNull(this.tableInvoicePayees.ControlNumberColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetControlNumberNull()
    {
      this[this.tableInvoicePayees.ControlNumberColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsPayeeGuidNull() => this.IsNull(this.tableInvoicePayees.PayeeGuidColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetPayeeGuidNull()
    {
      this[this.tableInvoicePayees.PayeeGuidColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsPayeeNameNull() => this.IsNull(this.tableInvoicePayees.PayeeNameColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetPayeeNameNull()
    {
      this[this.tableInvoicePayees.PayeeNameColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsPayeeAmtNull() => this.IsNull(this.tableInvoicePayees.PayeeAmtColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetPayeeAmtNull() => this[this.tableInvoicePayees.PayeeAmtColumn] = Convert.DBNull;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsOutstanding_APNull() => this.IsNull(this.tableInvoicePayees.Outstanding_APColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetOutstanding_APNull()
    {
      this[this.tableInvoicePayees.Outstanding_APColumn] = Convert.DBNull;
    }
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class PolicyHeaderRowChangeEvent : EventArgs
  {
    private dsExtendedPolicyInquiry.PolicyHeaderRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public PolicyHeaderRowChangeEvent(
      dsExtendedPolicyInquiry.PolicyHeaderRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsExtendedPolicyInquiry.PolicyHeaderRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class PolicyInvoicesRowChangeEvent : EventArgs
  {
    private dsExtendedPolicyInquiry.PolicyInvoicesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public PolicyInvoicesRowChangeEvent(
      dsExtendedPolicyInquiry.PolicyInvoicesRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsExtendedPolicyInquiry.PolicyInvoicesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class InvoiceActivityRowChangeEvent : EventArgs
  {
    private dsExtendedPolicyInquiry.InvoiceActivityRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public InvoiceActivityRowChangeEvent(
      dsExtendedPolicyInquiry.InvoiceActivityRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsExtendedPolicyInquiry.InvoiceActivityRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class InvoicePayeesRowChangeEvent : EventArgs
  {
    private dsExtendedPolicyInquiry.InvoicePayeesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public InvoicePayeesRowChangeEvent(
      dsExtendedPolicyInquiry.InvoicePayeesRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsExtendedPolicyInquiry.InvoicePayeesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }
}
