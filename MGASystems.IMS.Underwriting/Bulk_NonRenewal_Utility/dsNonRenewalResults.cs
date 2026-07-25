// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Underwriting.Bulk_NonRenewal_Utility.dsNonRenewalResults
// Assembly: MGASystems.IMS.Underwriting, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 1057C5B8-8299-4767-8242-AF9F1EF932DB
// Assembly location: D:\augusta\fortegra\IMS Project\MGASystems.IMS.Underwriting.dll

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
namespace MGASystems.IMS.Underwriting.Bulk_NonRenewal_Utility;

[DesignerCategory("code")]
[ToolboxItem(true)]
[XmlSchemaProvider("GetTypedDataSetSchema")]
[XmlRoot("dsNonRenewalResults")]
[HelpKeyword("vs.data.DataSet")]
[Serializable]
public class dsNonRenewalResults : DataSet
{
  private dsNonRenewalResults.NonRenewalsResultsDataTable tableNonRenewalsResults;
  private dsNonRenewalResults.PolicyProcessedDataTable tablePolicyProcessed;
  private dsNonRenewalResults.lstQuoteStatusReasonsDataTable tablelstQuoteStatusReasons;
  private SchemaSerializationMode _schemaSerializationMode = SchemaSerializationMode.IncludeSchema;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public dsNonRenewalResults()
  {
    this.BeginInit();
    this.InitClass();
    CollectionChangeEventHandler changeEventHandler = new CollectionChangeEventHandler(this.SchemaChanged);
    base.Tables.CollectionChanged += changeEventHandler;
    base.Relations.CollectionChanged += changeEventHandler;
    this.EndInit();
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  protected dsNonRenewalResults(SerializationInfo info, StreamingContext context)
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
        if (dataSet.Tables[nameof (NonRenewalsResults)] != null)
          base.Tables.Add((DataTable) new dsNonRenewalResults.NonRenewalsResultsDataTable(dataSet.Tables[nameof (NonRenewalsResults)]));
        if (dataSet.Tables[nameof (PolicyProcessed)] != null)
          base.Tables.Add((DataTable) new dsNonRenewalResults.PolicyProcessedDataTable(dataSet.Tables[nameof (PolicyProcessed)]));
        if (dataSet.Tables[nameof (lstQuoteStatusReasons)] != null)
          base.Tables.Add((DataTable) new dsNonRenewalResults.lstQuoteStatusReasonsDataTable(dataSet.Tables[nameof (lstQuoteStatusReasons)]));
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
  public dsNonRenewalResults.NonRenewalsResultsDataTable NonRenewalsResults
  {
    get => this.tableNonRenewalsResults;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsNonRenewalResults.PolicyProcessedDataTable PolicyProcessed => this.tablePolicyProcessed;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsNonRenewalResults.lstQuoteStatusReasonsDataTable lstQuoteStatusReasons
  {
    get => this.tablelstQuoteStatusReasons;
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
    dsNonRenewalResults nonRenewalResults = (dsNonRenewalResults) base.Clone();
    nonRenewalResults.InitVars();
    nonRenewalResults.SchemaSerializationMode = this.SchemaSerializationMode;
    return (DataSet) nonRenewalResults;
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
      if (dataSet.Tables["NonRenewalsResults"] != null)
        base.Tables.Add((DataTable) new dsNonRenewalResults.NonRenewalsResultsDataTable(dataSet.Tables["NonRenewalsResults"]));
      if (dataSet.Tables["PolicyProcessed"] != null)
        base.Tables.Add((DataTable) new dsNonRenewalResults.PolicyProcessedDataTable(dataSet.Tables["PolicyProcessed"]));
      if (dataSet.Tables["lstQuoteStatusReasons"] != null)
        base.Tables.Add((DataTable) new dsNonRenewalResults.lstQuoteStatusReasonsDataTable(dataSet.Tables["lstQuoteStatusReasons"]));
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
    this.tableNonRenewalsResults = (dsNonRenewalResults.NonRenewalsResultsDataTable) base.Tables["NonRenewalsResults"];
    if (initTable && this.tableNonRenewalsResults != null)
      this.tableNonRenewalsResults.InitVars();
    this.tablePolicyProcessed = (dsNonRenewalResults.PolicyProcessedDataTable) base.Tables["PolicyProcessed"];
    if (initTable && this.tablePolicyProcessed != null)
      this.tablePolicyProcessed.InitVars();
    this.tablelstQuoteStatusReasons = (dsNonRenewalResults.lstQuoteStatusReasonsDataTable) base.Tables["lstQuoteStatusReasons"];
    if (!initTable || this.tablelstQuoteStatusReasons == null)
      return;
    this.tablelstQuoteStatusReasons.InitVars();
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private void InitClass()
  {
    this.DataSetName = nameof (dsNonRenewalResults);
    this.Prefix = "";
    this.Namespace = "http://tempuri.org/dsNonRenewalResults.xsd";
    this.EnforceConstraints = true;
    this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.tableNonRenewalsResults = new dsNonRenewalResults.NonRenewalsResultsDataTable();
    base.Tables.Add((DataTable) this.tableNonRenewalsResults);
    this.tablePolicyProcessed = new dsNonRenewalResults.PolicyProcessedDataTable();
    base.Tables.Add((DataTable) this.tablePolicyProcessed);
    this.tablelstQuoteStatusReasons = new dsNonRenewalResults.lstQuoteStatusReasonsDataTable();
    base.Tables.Add((DataTable) this.tablelstQuoteStatusReasons);
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializeNonRenewalsResults() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializePolicyProcessed() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializelstQuoteStatusReasons() => false;

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
    dsNonRenewalResults nonRenewalResults = new dsNonRenewalResults();
    XmlSchemaComplexType typedDataSetSchema = new XmlSchemaComplexType();
    XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
    xmlSchemaSequence.Items.Add((XmlSchemaObject) new XmlSchemaAny()
    {
      Namespace = nonRenewalResults.Namespace
    });
    typedDataSetSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
    XmlSchema schemaSerializable = nonRenewalResults.GetSchemaSerializable();
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

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public delegate void NonRenewalsResultsRowChangeEventHandler(
    object sender,
    dsNonRenewalResults.NonRenewalsResultsRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public delegate void PolicyProcessedRowChangeEventHandler(
    object sender,
    dsNonRenewalResults.PolicyProcessedRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public delegate void lstQuoteStatusReasonsRowChangeEventHandler(
    object sender,
    dsNonRenewalResults.lstQuoteStatusReasonsRowChangeEvent e);

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class NonRenewalsResultsDataTable : 
    TypedTableBase<dsNonRenewalResults.NonRenewalsResultsRow>
  {
    private DataColumn columnInsured;
    private DataColumn columnProducerLocationName;
    private DataColumn columnExpirationDate;
    private DataColumn columnControlNo;
    private DataColumn columnCompany;
    private DataColumn columnLines;
    private DataColumn columnPolicyNumber;
    private DataColumn columnStatus;
    private DataColumn columnStateID;
    private DataColumn columnSelected;
    private DataColumn columnquoteid;
    private DataColumn columnquotestatusreasonid;
    private DataColumn columnmailingDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public NonRenewalsResultsDataTable()
    {
      this.TableName = "NonRenewalsResults";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal NonRenewalsResultsDataTable(DataTable table)
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected NonRenewalsResultsDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn InsuredColumn => this.columnInsured;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ProducerLocationNameColumn => this.columnProducerLocationName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ExpirationDateColumn => this.columnExpirationDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ControlNoColumn => this.columnControlNo;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn CompanyColumn => this.columnCompany;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn LinesColumn => this.columnLines;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn PolicyNumberColumn => this.columnPolicyNumber;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn StatusColumn => this.columnStatus;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn StateIDColumn => this.columnStateID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn SelectedColumn => this.columnSelected;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn quoteidColumn => this.columnquoteid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn quotestatusreasonidColumn => this.columnquotestatusreasonid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn mailingDateColumn => this.columnmailingDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsNonRenewalResults.NonRenewalsResultsRow this[int index]
    {
      get => (dsNonRenewalResults.NonRenewalsResultsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsNonRenewalResults.NonRenewalsResultsRowChangeEventHandler NonRenewalsResultsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsNonRenewalResults.NonRenewalsResultsRowChangeEventHandler NonRenewalsResultsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsNonRenewalResults.NonRenewalsResultsRowChangeEventHandler NonRenewalsResultsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsNonRenewalResults.NonRenewalsResultsRowChangeEventHandler NonRenewalsResultsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AddNonRenewalsResultsRow(dsNonRenewalResults.NonRenewalsResultsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsNonRenewalResults.NonRenewalsResultsRow AddNonRenewalsResultsRow(
      string Insured,
      string ProducerLocationName,
      DateTime ExpirationDate,
      int ControlNo,
      string Company,
      string Lines,
      string PolicyNumber,
      string Status,
      string StateID,
      bool Selected,
      int quoteid,
      int quotestatusreasonid,
      DateTime mailingDate)
    {
      dsNonRenewalResults.NonRenewalsResultsRow row = (dsNonRenewalResults.NonRenewalsResultsRow) this.NewRow();
      object[] objArray = new object[13]
      {
        (object) Insured,
        (object) ProducerLocationName,
        (object) ExpirationDate,
        (object) ControlNo,
        (object) Company,
        (object) Lines,
        (object) PolicyNumber,
        (object) Status,
        (object) StateID,
        (object) Selected,
        (object) quoteid,
        (object) quotestatusreasonid,
        (object) mailingDate
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsNonRenewalResults.NonRenewalsResultsRow FindByControlNo(int ControlNo)
    {
      return (dsNonRenewalResults.NonRenewalsResultsRow) this.Rows.Find(new object[1]
      {
        (object) ControlNo
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsNonRenewalResults.NonRenewalsResultsDataTable resultsDataTable = (dsNonRenewalResults.NonRenewalsResultsDataTable) base.Clone();
      resultsDataTable.InitVars();
      return (DataTable) resultsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsNonRenewalResults.NonRenewalsResultsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal void InitVars()
    {
      this.columnInsured = this.Columns["Insured"];
      this.columnProducerLocationName = this.Columns["ProducerLocationName"];
      this.columnExpirationDate = this.Columns["ExpirationDate"];
      this.columnControlNo = this.Columns["ControlNo"];
      this.columnCompany = this.Columns["Company"];
      this.columnLines = this.Columns["Lines"];
      this.columnPolicyNumber = this.Columns["PolicyNumber"];
      this.columnStatus = this.Columns["Status"];
      this.columnStateID = this.Columns["StateID"];
      this.columnSelected = this.Columns["Selected"];
      this.columnquoteid = this.Columns["quoteid"];
      this.columnquotestatusreasonid = this.Columns["quotestatusreasonid"];
      this.columnmailingDate = this.Columns["mailingDate"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.columnInsured = new DataColumn("Insured", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInsured);
      this.columnProducerLocationName = new DataColumn("ProducerLocationName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnProducerLocationName);
      this.columnExpirationDate = new DataColumn("ExpirationDate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnExpirationDate);
      this.columnControlNo = new DataColumn("ControlNo", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnControlNo);
      this.columnCompany = new DataColumn("Company", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCompany);
      this.columnLines = new DataColumn("Lines", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLines);
      this.columnPolicyNumber = new DataColumn("PolicyNumber", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPolicyNumber);
      this.columnStatus = new DataColumn("Status", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnStatus);
      this.columnStateID = new DataColumn("StateID", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnStateID);
      this.columnSelected = new DataColumn("Selected", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSelected);
      this.columnquoteid = new DataColumn("quoteid", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnquoteid);
      this.columnquotestatusreasonid = new DataColumn("quotestatusreasonid", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnquotestatusreasonid);
      this.columnmailingDate = new DataColumn("mailingDate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnmailingDate);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnControlNo
      }, true));
      this.columnInsured.MaxLength = 1000;
      this.columnProducerLocationName.MaxLength = 1000;
      this.columnControlNo.AllowDBNull = false;
      this.columnControlNo.Unique = true;
      this.columnCompany.MaxLength = 1000;
      this.columnLines.MaxLength = 1000;
      this.columnPolicyNumber.MaxLength = 500;
      this.columnStateID.MaxLength = 20;
      this.columnSelected.DefaultValue = (object) false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsNonRenewalResults.NonRenewalsResultsRow NewNonRenewalsResultsRow()
    {
      return (dsNonRenewalResults.NonRenewalsResultsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsNonRenewalResults.NonRenewalsResultsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType() => typeof (dsNonRenewalResults.NonRenewalsResultsRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      if (this.NonRenewalsResultsRowChanged == null)
        return;
      this.NonRenewalsResultsRowChanged((object) this, new dsNonRenewalResults.NonRenewalsResultsRowChangeEvent((dsNonRenewalResults.NonRenewalsResultsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      if (this.NonRenewalsResultsRowChanging == null)
        return;
      this.NonRenewalsResultsRowChanging((object) this, new dsNonRenewalResults.NonRenewalsResultsRowChangeEvent((dsNonRenewalResults.NonRenewalsResultsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      if (this.NonRenewalsResultsRowDeleted == null)
        return;
      this.NonRenewalsResultsRowDeleted((object) this, new dsNonRenewalResults.NonRenewalsResultsRowChangeEvent((dsNonRenewalResults.NonRenewalsResultsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      if (this.NonRenewalsResultsRowDeleting == null)
        return;
      this.NonRenewalsResultsRowDeleting((object) this, new dsNonRenewalResults.NonRenewalsResultsRowChangeEvent((dsNonRenewalResults.NonRenewalsResultsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemoveNonRenewalsResultsRow(dsNonRenewalResults.NonRenewalsResultsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType typedTableSchema = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsNonRenewalResults nonRenewalResults = new dsNonRenewalResults();
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
        FixedValue = nonRenewalResults.Namespace
      });
      typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (NonRenewalsResultsDataTable)
      });
      typedTableSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = nonRenewalResults.GetSchemaSerializable();
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
  public class PolicyProcessedDataTable : TypedTableBase<dsNonRenewalResults.PolicyProcessedRow>
  {
    private DataColumn columnControlNo;
    private DataColumn columnPolicyNumber;
    private DataColumn columnInsured;
    private DataColumn columnStatus;
    private DataColumn columnSelected;
    private DataColumn columnquoteid;
    private DataColumn columnquotestatusreasonid;
    private DataColumn columnmailingDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public PolicyProcessedDataTable()
    {
      this.TableName = "PolicyProcessed";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal PolicyProcessedDataTable(DataTable table)
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected PolicyProcessedDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ControlNoColumn => this.columnControlNo;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn PolicyNumberColumn => this.columnPolicyNumber;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn InsuredColumn => this.columnInsured;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn StatusColumn => this.columnStatus;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn SelectedColumn => this.columnSelected;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn quoteidColumn => this.columnquoteid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn quotestatusreasonidColumn => this.columnquotestatusreasonid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn mailingDateColumn => this.columnmailingDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsNonRenewalResults.PolicyProcessedRow this[int index]
    {
      get => (dsNonRenewalResults.PolicyProcessedRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsNonRenewalResults.PolicyProcessedRowChangeEventHandler PolicyProcessedRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsNonRenewalResults.PolicyProcessedRowChangeEventHandler PolicyProcessedRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsNonRenewalResults.PolicyProcessedRowChangeEventHandler PolicyProcessedRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsNonRenewalResults.PolicyProcessedRowChangeEventHandler PolicyProcessedRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AddPolicyProcessedRow(dsNonRenewalResults.PolicyProcessedRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsNonRenewalResults.PolicyProcessedRow AddPolicyProcessedRow(
      int ControlNo,
      string PolicyNumber,
      string Insured,
      string Status,
      bool Selected,
      int quoteid,
      int quotestatusreasonid,
      DateTime mailingDate)
    {
      dsNonRenewalResults.PolicyProcessedRow row = (dsNonRenewalResults.PolicyProcessedRow) this.NewRow();
      object[] objArray = new object[8]
      {
        (object) ControlNo,
        (object) PolicyNumber,
        (object) Insured,
        (object) Status,
        (object) Selected,
        (object) quoteid,
        (object) quotestatusreasonid,
        (object) mailingDate
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsNonRenewalResults.PolicyProcessedRow FindByControlNo(int ControlNo)
    {
      return (dsNonRenewalResults.PolicyProcessedRow) this.Rows.Find(new object[1]
      {
        (object) ControlNo
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsNonRenewalResults.PolicyProcessedDataTable processedDataTable = (dsNonRenewalResults.PolicyProcessedDataTable) base.Clone();
      processedDataTable.InitVars();
      return (DataTable) processedDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsNonRenewalResults.PolicyProcessedDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal void InitVars()
    {
      this.columnControlNo = this.Columns["ControlNo"];
      this.columnPolicyNumber = this.Columns["PolicyNumber"];
      this.columnInsured = this.Columns["Insured"];
      this.columnStatus = this.Columns["Status"];
      this.columnSelected = this.Columns["Selected"];
      this.columnquoteid = this.Columns["quoteid"];
      this.columnquotestatusreasonid = this.Columns["quotestatusreasonid"];
      this.columnmailingDate = this.Columns["mailingDate"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.columnControlNo = new DataColumn("ControlNo", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnControlNo);
      this.columnPolicyNumber = new DataColumn("PolicyNumber", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPolicyNumber);
      this.columnInsured = new DataColumn("Insured", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInsured);
      this.columnStatus = new DataColumn("Status", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnStatus);
      this.columnSelected = new DataColumn("Selected", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSelected);
      this.columnquoteid = new DataColumn("quoteid", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnquoteid);
      this.columnquotestatusreasonid = new DataColumn("quotestatusreasonid", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnquotestatusreasonid);
      this.columnmailingDate = new DataColumn("mailingDate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnmailingDate);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnControlNo
      }, true));
      this.columnControlNo.AllowDBNull = false;
      this.columnControlNo.Unique = true;
      this.columnSelected.AllowDBNull = false;
      this.columnSelected.DefaultValue = (object) false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsNonRenewalResults.PolicyProcessedRow NewPolicyProcessedRow()
    {
      return (dsNonRenewalResults.PolicyProcessedRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsNonRenewalResults.PolicyProcessedRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType() => typeof (dsNonRenewalResults.PolicyProcessedRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      if (this.PolicyProcessedRowChanged == null)
        return;
      this.PolicyProcessedRowChanged((object) this, new dsNonRenewalResults.PolicyProcessedRowChangeEvent((dsNonRenewalResults.PolicyProcessedRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      if (this.PolicyProcessedRowChanging == null)
        return;
      this.PolicyProcessedRowChanging((object) this, new dsNonRenewalResults.PolicyProcessedRowChangeEvent((dsNonRenewalResults.PolicyProcessedRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      if (this.PolicyProcessedRowDeleted == null)
        return;
      this.PolicyProcessedRowDeleted((object) this, new dsNonRenewalResults.PolicyProcessedRowChangeEvent((dsNonRenewalResults.PolicyProcessedRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      if (this.PolicyProcessedRowDeleting == null)
        return;
      this.PolicyProcessedRowDeleting((object) this, new dsNonRenewalResults.PolicyProcessedRowChangeEvent((dsNonRenewalResults.PolicyProcessedRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemovePolicyProcessedRow(dsNonRenewalResults.PolicyProcessedRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType typedTableSchema = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsNonRenewalResults nonRenewalResults = new dsNonRenewalResults();
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
        FixedValue = nonRenewalResults.Namespace
      });
      typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (PolicyProcessedDataTable)
      });
      typedTableSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = nonRenewalResults.GetSchemaSerializable();
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
  public class lstQuoteStatusReasonsDataTable : 
    TypedTableBase<dsNonRenewalResults.lstQuoteStatusReasonsRow>
  {
    private DataColumn columnID;
    private DataColumn columnReason;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public lstQuoteStatusReasonsDataTable()
    {
      this.TableName = "lstQuoteStatusReasons";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal lstQuoteStatusReasonsDataTable(DataTable table)
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected lstQuoteStatusReasonsDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn IDColumn => this.columnID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ReasonColumn => this.columnReason;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsNonRenewalResults.lstQuoteStatusReasonsRow this[int index]
    {
      get => (dsNonRenewalResults.lstQuoteStatusReasonsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsNonRenewalResults.lstQuoteStatusReasonsRowChangeEventHandler lstQuoteStatusReasonsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsNonRenewalResults.lstQuoteStatusReasonsRowChangeEventHandler lstQuoteStatusReasonsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsNonRenewalResults.lstQuoteStatusReasonsRowChangeEventHandler lstQuoteStatusReasonsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsNonRenewalResults.lstQuoteStatusReasonsRowChangeEventHandler lstQuoteStatusReasonsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AddlstQuoteStatusReasonsRow(dsNonRenewalResults.lstQuoteStatusReasonsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsNonRenewalResults.lstQuoteStatusReasonsRow AddlstQuoteStatusReasonsRow(
      int ID,
      string Reason)
    {
      dsNonRenewalResults.lstQuoteStatusReasonsRow row = (dsNonRenewalResults.lstQuoteStatusReasonsRow) this.NewRow();
      object[] objArray = new object[2]
      {
        (object) ID,
        (object) Reason
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsNonRenewalResults.lstQuoteStatusReasonsRow FindByID(int ID)
    {
      return (dsNonRenewalResults.lstQuoteStatusReasonsRow) this.Rows.Find(new object[1]
      {
        (object) ID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsNonRenewalResults.lstQuoteStatusReasonsDataTable reasonsDataTable = (dsNonRenewalResults.lstQuoteStatusReasonsDataTable) base.Clone();
      reasonsDataTable.InitVars();
      return (DataTable) reasonsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsNonRenewalResults.lstQuoteStatusReasonsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal void InitVars()
    {
      this.columnID = this.Columns["ID"];
      this.columnReason = this.Columns["Reason"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.columnID = new DataColumn("ID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnID);
      this.columnReason = new DataColumn("Reason", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnReason);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnID
      }, true));
      this.columnID.AllowDBNull = false;
      this.columnID.Unique = true;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsNonRenewalResults.lstQuoteStatusReasonsRow NewlstQuoteStatusReasonsRow()
    {
      return (dsNonRenewalResults.lstQuoteStatusReasonsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsNonRenewalResults.lstQuoteStatusReasonsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType() => typeof (dsNonRenewalResults.lstQuoteStatusReasonsRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      if (this.lstQuoteStatusReasonsRowChanged == null)
        return;
      this.lstQuoteStatusReasonsRowChanged((object) this, new dsNonRenewalResults.lstQuoteStatusReasonsRowChangeEvent((dsNonRenewalResults.lstQuoteStatusReasonsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      if (this.lstQuoteStatusReasonsRowChanging == null)
        return;
      this.lstQuoteStatusReasonsRowChanging((object) this, new dsNonRenewalResults.lstQuoteStatusReasonsRowChangeEvent((dsNonRenewalResults.lstQuoteStatusReasonsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      if (this.lstQuoteStatusReasonsRowDeleted == null)
        return;
      this.lstQuoteStatusReasonsRowDeleted((object) this, new dsNonRenewalResults.lstQuoteStatusReasonsRowChangeEvent((dsNonRenewalResults.lstQuoteStatusReasonsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      if (this.lstQuoteStatusReasonsRowDeleting == null)
        return;
      this.lstQuoteStatusReasonsRowDeleting((object) this, new dsNonRenewalResults.lstQuoteStatusReasonsRowChangeEvent((dsNonRenewalResults.lstQuoteStatusReasonsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemovelstQuoteStatusReasonsRow(dsNonRenewalResults.lstQuoteStatusReasonsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType typedTableSchema = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsNonRenewalResults nonRenewalResults = new dsNonRenewalResults();
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
        FixedValue = nonRenewalResults.Namespace
      });
      typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (lstQuoteStatusReasonsDataTable)
      });
      typedTableSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = nonRenewalResults.GetSchemaSerializable();
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

  public class NonRenewalsResultsRow : DataRow
  {
    private dsNonRenewalResults.NonRenewalsResultsDataTable tableNonRenewalsResults;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal NonRenewalsResultsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableNonRenewalsResults = (dsNonRenewalResults.NonRenewalsResultsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string Insured
    {
      get
      {
        try
        {
          return (string) this[this.tableNonRenewalsResults.InsuredColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'Insured' in table 'NonRenewalsResults' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableNonRenewalsResults.InsuredColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string ProducerLocationName
    {
      get
      {
        try
        {
          return (string) this[this.tableNonRenewalsResults.ProducerLocationNameColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'ProducerLocationName' in table 'NonRenewalsResults' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableNonRenewalsResults.ProducerLocationNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DateTime ExpirationDate
    {
      get
      {
        try
        {
          return (DateTime) this[this.tableNonRenewalsResults.ExpirationDateColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'ExpirationDate' in table 'NonRenewalsResults' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableNonRenewalsResults.ExpirationDateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int ControlNo
    {
      get => (int) this[this.tableNonRenewalsResults.ControlNoColumn];
      set => this[this.tableNonRenewalsResults.ControlNoColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string Company
    {
      get
      {
        try
        {
          return (string) this[this.tableNonRenewalsResults.CompanyColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'Company' in table 'NonRenewalsResults' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableNonRenewalsResults.CompanyColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string Lines
    {
      get
      {
        try
        {
          return (string) this[this.tableNonRenewalsResults.LinesColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'Lines' in table 'NonRenewalsResults' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableNonRenewalsResults.LinesColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string PolicyNumber
    {
      get
      {
        try
        {
          return (string) this[this.tableNonRenewalsResults.PolicyNumberColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'PolicyNumber' in table 'NonRenewalsResults' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableNonRenewalsResults.PolicyNumberColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string Status
    {
      get
      {
        try
        {
          return (string) this[this.tableNonRenewalsResults.StatusColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'Status' in table 'NonRenewalsResults' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableNonRenewalsResults.StatusColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string StateID
    {
      get
      {
        try
        {
          return (string) this[this.tableNonRenewalsResults.StateIDColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'StateID' in table 'NonRenewalsResults' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableNonRenewalsResults.StateIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool Selected
    {
      get
      {
        try
        {
          return (bool) this[this.tableNonRenewalsResults.SelectedColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'Selected' in table 'NonRenewalsResults' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableNonRenewalsResults.SelectedColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int quoteid
    {
      get
      {
        try
        {
          return (int) this[this.tableNonRenewalsResults.quoteidColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'quoteid' in table 'NonRenewalsResults' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableNonRenewalsResults.quoteidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int quotestatusreasonid
    {
      get
      {
        try
        {
          return (int) this[this.tableNonRenewalsResults.quotestatusreasonidColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'quotestatusreasonid' in table 'NonRenewalsResults' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableNonRenewalsResults.quotestatusreasonidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DateTime mailingDate
    {
      get
      {
        try
        {
          return (DateTime) this[this.tableNonRenewalsResults.mailingDateColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'mailingDate' in table 'NonRenewalsResults' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableNonRenewalsResults.mailingDateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsInsuredNull() => this.IsNull(this.tableNonRenewalsResults.InsuredColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetInsuredNull()
    {
      this[this.tableNonRenewalsResults.InsuredColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsProducerLocationNameNull()
    {
      return this.IsNull(this.tableNonRenewalsResults.ProducerLocationNameColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetProducerLocationNameNull()
    {
      this[this.tableNonRenewalsResults.ProducerLocationNameColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsExpirationDateNull()
    {
      return this.IsNull(this.tableNonRenewalsResults.ExpirationDateColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetExpirationDateNull()
    {
      this[this.tableNonRenewalsResults.ExpirationDateColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsCompanyNull() => this.IsNull(this.tableNonRenewalsResults.CompanyColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetCompanyNull()
    {
      this[this.tableNonRenewalsResults.CompanyColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsLinesNull() => this.IsNull(this.tableNonRenewalsResults.LinesColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetLinesNull() => this[this.tableNonRenewalsResults.LinesColumn] = Convert.DBNull;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsPolicyNumberNull()
    {
      return this.IsNull(this.tableNonRenewalsResults.PolicyNumberColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetPolicyNumberNull()
    {
      this[this.tableNonRenewalsResults.PolicyNumberColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsStatusNull() => this.IsNull(this.tableNonRenewalsResults.StatusColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetStatusNull() => this[this.tableNonRenewalsResults.StatusColumn] = Convert.DBNull;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsStateIDNull() => this.IsNull(this.tableNonRenewalsResults.StateIDColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetStateIDNull()
    {
      this[this.tableNonRenewalsResults.StateIDColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsSelectedNull() => this.IsNull(this.tableNonRenewalsResults.SelectedColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetSelectedNull()
    {
      this[this.tableNonRenewalsResults.SelectedColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsquoteidNull() => this.IsNull(this.tableNonRenewalsResults.quoteidColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetquoteidNull()
    {
      this[this.tableNonRenewalsResults.quoteidColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsquotestatusreasonidNull()
    {
      return this.IsNull(this.tableNonRenewalsResults.quotestatusreasonidColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetquotestatusreasonidNull()
    {
      this[this.tableNonRenewalsResults.quotestatusreasonidColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsmailingDateNull() => this.IsNull(this.tableNonRenewalsResults.mailingDateColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetmailingDateNull()
    {
      this[this.tableNonRenewalsResults.mailingDateColumn] = Convert.DBNull;
    }
  }

  public class PolicyProcessedRow : DataRow
  {
    private dsNonRenewalResults.PolicyProcessedDataTable tablePolicyProcessed;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal PolicyProcessedRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablePolicyProcessed = (dsNonRenewalResults.PolicyProcessedDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int ControlNo
    {
      get => (int) this[this.tablePolicyProcessed.ControlNoColumn];
      set => this[this.tablePolicyProcessed.ControlNoColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string PolicyNumber
    {
      get
      {
        try
        {
          return (string) this[this.tablePolicyProcessed.PolicyNumberColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'PolicyNumber' in table 'PolicyProcessed' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePolicyProcessed.PolicyNumberColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string Insured
    {
      get
      {
        try
        {
          return (string) this[this.tablePolicyProcessed.InsuredColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'Insured' in table 'PolicyProcessed' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePolicyProcessed.InsuredColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string Status
    {
      get
      {
        try
        {
          return (string) this[this.tablePolicyProcessed.StatusColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'Status' in table 'PolicyProcessed' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePolicyProcessed.StatusColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool Selected
    {
      get => (bool) this[this.tablePolicyProcessed.SelectedColumn];
      set => this[this.tablePolicyProcessed.SelectedColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int quoteid
    {
      get
      {
        try
        {
          return (int) this[this.tablePolicyProcessed.quoteidColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'quoteid' in table 'PolicyProcessed' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePolicyProcessed.quoteidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int quotestatusreasonid
    {
      get
      {
        try
        {
          return (int) this[this.tablePolicyProcessed.quotestatusreasonidColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'quotestatusreasonid' in table 'PolicyProcessed' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePolicyProcessed.quotestatusreasonidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DateTime mailingDate
    {
      get
      {
        try
        {
          return (DateTime) this[this.tablePolicyProcessed.mailingDateColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'mailingDate' in table 'PolicyProcessed' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePolicyProcessed.mailingDateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsPolicyNumberNull() => this.IsNull(this.tablePolicyProcessed.PolicyNumberColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetPolicyNumberNull()
    {
      this[this.tablePolicyProcessed.PolicyNumberColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsInsuredNull() => this.IsNull(this.tablePolicyProcessed.InsuredColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetInsuredNull() => this[this.tablePolicyProcessed.InsuredColumn] = Convert.DBNull;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsStatusNull() => this.IsNull(this.tablePolicyProcessed.StatusColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetStatusNull() => this[this.tablePolicyProcessed.StatusColumn] = Convert.DBNull;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsquoteidNull() => this.IsNull(this.tablePolicyProcessed.quoteidColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetquoteidNull() => this[this.tablePolicyProcessed.quoteidColumn] = Convert.DBNull;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsquotestatusreasonidNull()
    {
      return this.IsNull(this.tablePolicyProcessed.quotestatusreasonidColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetquotestatusreasonidNull()
    {
      this[this.tablePolicyProcessed.quotestatusreasonidColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsmailingDateNull() => this.IsNull(this.tablePolicyProcessed.mailingDateColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetmailingDateNull()
    {
      this[this.tablePolicyProcessed.mailingDateColumn] = Convert.DBNull;
    }
  }

  public class lstQuoteStatusReasonsRow : DataRow
  {
    private dsNonRenewalResults.lstQuoteStatusReasonsDataTable tablelstQuoteStatusReasons;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal lstQuoteStatusReasonsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablelstQuoteStatusReasons = (dsNonRenewalResults.lstQuoteStatusReasonsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int ID
    {
      get => (int) this[this.tablelstQuoteStatusReasons.IDColumn];
      set => this[this.tablelstQuoteStatusReasons.IDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string Reason
    {
      get
      {
        try
        {
          return (string) this[this.tablelstQuoteStatusReasons.ReasonColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'Reason' in table 'lstQuoteStatusReasons' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablelstQuoteStatusReasons.ReasonColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsReasonNull() => this.IsNull(this.tablelstQuoteStatusReasons.ReasonColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetReasonNull()
    {
      this[this.tablelstQuoteStatusReasons.ReasonColumn] = Convert.DBNull;
    }
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class NonRenewalsResultsRowChangeEvent : EventArgs
  {
    private dsNonRenewalResults.NonRenewalsResultsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public NonRenewalsResultsRowChangeEvent(
      dsNonRenewalResults.NonRenewalsResultsRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsNonRenewalResults.NonRenewalsResultsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class PolicyProcessedRowChangeEvent : EventArgs
  {
    private dsNonRenewalResults.PolicyProcessedRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public PolicyProcessedRowChangeEvent(
      dsNonRenewalResults.PolicyProcessedRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsNonRenewalResults.PolicyProcessedRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class lstQuoteStatusReasonsRowChangeEvent : EventArgs
  {
    private dsNonRenewalResults.lstQuoteStatusReasonsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public lstQuoteStatusReasonsRowChangeEvent(
      dsNonRenewalResults.lstQuoteStatusReasonsRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsNonRenewalResults.lstQuoteStatusReasonsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }
}
