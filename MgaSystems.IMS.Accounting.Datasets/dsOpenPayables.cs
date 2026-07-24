// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.AccountingDatasets.dsOpenPayables
// Assembly: MgaSystems.IMS.Accounting.Datasets, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 8706ECE1-02EE-4588-9B9D-A81462107C6A
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Accounting.Datasets.dll

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
namespace MGASystems.IMS.Accounting.AccountingDatasets;

[DesignerCategory("code")]
[ToolboxItem(true)]
[XmlSchemaProvider("GetTypedDataSetSchema")]
[XmlRoot("dsOpenPayables")]
[HelpKeyword("vs.data.DataSet")]
[Serializable]
public class dsOpenPayables : DataSet
{
  private dsOpenPayables.OpenPayablesDataTable tableOpenPayables;
  private SchemaSerializationMode _schemaSerializationMode;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public dsOpenPayables()
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
  protected dsOpenPayables(SerializationInfo info, StreamingContext context)
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
        if (dataSet.Tables[nameof (OpenPayables)] != null)
          base.Tables.Add((DataTable) new dsOpenPayables.OpenPayablesDataTable(dataSet.Tables[nameof (OpenPayables)]));
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
  public dsOpenPayables.OpenPayablesDataTable OpenPayables => this.tableOpenPayables;

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
    dsOpenPayables dsOpenPayables = (dsOpenPayables) base.Clone();
    dsOpenPayables.InitVars();
    dsOpenPayables.SchemaSerializationMode = this.SchemaSerializationMode;
    return (DataSet) dsOpenPayables;
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
      if (dataSet.Tables["OpenPayables"] != null)
        base.Tables.Add((DataTable) new dsOpenPayables.OpenPayablesDataTable(dataSet.Tables["OpenPayables"]));
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
    this.tableOpenPayables = (dsOpenPayables.OpenPayablesDataTable) base.Tables["OpenPayables"];
    if (!initTable || this.tableOpenPayables == null)
      return;
    this.tableOpenPayables.InitVars();
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private void InitClass()
  {
    this.DataSetName = nameof (dsOpenPayables);
    this.Prefix = "";
    this.Namespace = "http://tempuri.org/dsOpenPayables.xsd";
    this.EnforceConstraints = true;
    this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.tableOpenPayables = new dsOpenPayables.OpenPayablesDataTable();
    base.Tables.Add((DataTable) this.tableOpenPayables);
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializeOpenPayables() => false;

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
    dsOpenPayables dsOpenPayables = new dsOpenPayables();
    XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
    schemaComplexType.Particle = (XmlSchemaParticle) new XmlSchemaSequence()
    {
      Items = {
        (XmlSchemaObject) new XmlSchemaAny()
        {
          Namespace = dsOpenPayables.Namespace
        }
      }
    };
    XmlSchema schemaSerializable = dsOpenPayables.GetSchemaSerializable();
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
  public delegate void OpenPayablesRowChangeEventHandler(
    object sender,
    dsOpenPayables.OpenPayablesRowChangeEvent e);

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class OpenPayablesDataTable : TypedTableBase<dsOpenPayables.OpenPayablesRow>
  {
    private DataColumn columnInvoiceNum;
    private DataColumn columnGLCompanyId;
    private DataColumn columnPayeeGuid;
    private DataColumn columnCompanyLineGuid;
    private DataColumn columnChargeCode;
    private DataColumn columnPolicyNumber;
    private DataColumn columnInsuredPolicyName;
    private DataColumn columnEffectiveDate;
    private DataColumn columnExpirationDate;
    private DataColumn columnDueDate;
    private DataColumn columnOfficeInvoiceNum;
    private DataColumn columnPayee;
    private DataColumn columnChargeName;
    private DataColumn columnGross_Payable;
    private DataColumn columnAmtPtd;
    private DataColumn columnNet_Payable;
    private DataColumn columnAmt_Rcvd;
    private DataColumn columnExch_Balance;
    private DataColumn columnUnAcct_Balance;
    private DataColumn columnAccountNumber;
    private DataColumn columnQuoteControlNum;
    private DataColumn columnInvoiceDate;
    private DataColumn columnAPGL;
    private DataColumn columnEXGL;
    private DataColumn columnUAGL;
    private DataColumn columnPropAmt;
    private DataColumn columnCostCenterId;
    private DataColumn columnpayeePercentRate;
    private DataColumn columnmgaPercentrate;
    private DataColumn columnapapplied;
    private DataColumn columnCheckRequested;
    private DataColumn columnFees_Due_Date;
    private DataColumn columnLOB;
    private DataColumn columnTransactionDate;
    private DataColumn columnEndorsement_Effective;
    private DataColumn columnCurrencyCode;
    private DataColumn columnCurrencyCode_Functional;
    private DataColumn columnCurrencyCode_Reporting;
    private DataColumn columnConvRate_Functional;
    private DataColumn columnConvRate_Reporting;
    private DataColumn columnProducer;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public OpenPayablesDataTable()
    {
      this.TableName = "OpenPayables";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal OpenPayablesDataTable(DataTable table)
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
    protected OpenPayablesDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn InvoiceNumColumn => this.columnInvoiceNum;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn GLCompanyIdColumn => this.columnGLCompanyId;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn PayeeGuidColumn => this.columnPayeeGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn CompanyLineGuidColumn => this.columnCompanyLineGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ChargeCodeColumn => this.columnChargeCode;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn PolicyNumberColumn => this.columnPolicyNumber;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn InsuredPolicyNameColumn => this.columnInsuredPolicyName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn EffectiveDateColumn => this.columnEffectiveDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ExpirationDateColumn => this.columnExpirationDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn DueDateColumn => this.columnDueDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn OfficeInvoiceNumColumn => this.columnOfficeInvoiceNum;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn PayeeColumn => this.columnPayee;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ChargeNameColumn => this.columnChargeName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn Gross_PayableColumn => this.columnGross_Payable;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn AmtPtdColumn => this.columnAmtPtd;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn Net_PayableColumn => this.columnNet_Payable;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn Amt_RcvdColumn => this.columnAmt_Rcvd;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn Exch_BalanceColumn => this.columnExch_Balance;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn UnAcct_BalanceColumn => this.columnUnAcct_Balance;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn AccountNumberColumn => this.columnAccountNumber;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn QuoteControlNumColumn => this.columnQuoteControlNum;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn InvoiceDateColumn => this.columnInvoiceDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn APGLColumn => this.columnAPGL;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn EXGLColumn => this.columnEXGL;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn UAGLColumn => this.columnUAGL;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn PropAmtColumn => this.columnPropAmt;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn CostCenterIdColumn => this.columnCostCenterId;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn payeePercentRateColumn => this.columnpayeePercentRate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn mgaPercentrateColumn => this.columnmgaPercentrate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn apappliedColumn => this.columnapapplied;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn CheckRequestedColumn => this.columnCheckRequested;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn Fees_Due_DateColumn => this.columnFees_Due_Date;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn LOBColumn => this.columnLOB;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn TransactionDateColumn => this.columnTransactionDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn Endorsement_EffectiveColumn => this.columnEndorsement_Effective;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn CurrencyCodeColumn => this.columnCurrencyCode;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn CurrencyCode_FunctionalColumn => this.columnCurrencyCode_Functional;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn CurrencyCode_ReportingColumn => this.columnCurrencyCode_Reporting;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ConvRate_FunctionalColumn => this.columnConvRate_Functional;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ConvRate_ReportingColumn => this.columnConvRate_Reporting;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ProducerColumn => this.columnProducer;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsOpenPayables.OpenPayablesRow this[int index]
    {
      get => (dsOpenPayables.OpenPayablesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsOpenPayables.OpenPayablesRowChangeEventHandler OpenPayablesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsOpenPayables.OpenPayablesRowChangeEventHandler OpenPayablesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsOpenPayables.OpenPayablesRowChangeEventHandler OpenPayablesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsOpenPayables.OpenPayablesRowChangeEventHandler OpenPayablesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddOpenPayablesRow(dsOpenPayables.OpenPayablesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsOpenPayables.OpenPayablesRow AddOpenPayablesRow(
      int InvoiceNum,
      int GLCompanyId,
      string PayeeGuid,
      string CompanyLineGuid,
      int ChargeCode,
      string PolicyNumber,
      string InsuredPolicyName,
      DateTime EffectiveDate,
      DateTime ExpirationDate,
      DateTime DueDate,
      int OfficeInvoiceNum,
      string Payee,
      string ChargeName,
      Decimal Gross_Payable,
      Decimal AmtPtd,
      Decimal Net_Payable,
      Decimal Amt_Rcvd,
      Decimal Exch_Balance,
      Decimal UnAcct_Balance,
      string AccountNumber,
      int QuoteControlNum,
      DateTime InvoiceDate,
      int APGL,
      int EXGL,
      int UAGL,
      Decimal PropAmt,
      int CostCenterId,
      Decimal payeePercentRate,
      Decimal mgaPercentrate,
      Decimal apapplied,
      DateTime CheckRequested,
      DateTime Fees_Due_Date,
      string LOB,
      DateTime TransactionDate,
      DateTime Endorsement_Effective,
      string CurrencyCode,
      string CurrencyCode_Functional,
      string CurrencyCode_Reporting,
      Decimal ConvRate_Functional,
      Decimal ConvRate_Reporting,
      string Producer)
    {
      dsOpenPayables.OpenPayablesRow row = (dsOpenPayables.OpenPayablesRow) this.NewRow();
      object[] objArray = new object[41]
      {
        (object) InvoiceNum,
        (object) GLCompanyId,
        (object) PayeeGuid,
        (object) CompanyLineGuid,
        (object) ChargeCode,
        (object) PolicyNumber,
        (object) InsuredPolicyName,
        (object) EffectiveDate,
        (object) ExpirationDate,
        (object) DueDate,
        (object) OfficeInvoiceNum,
        (object) Payee,
        (object) ChargeName,
        (object) Gross_Payable,
        (object) AmtPtd,
        (object) Net_Payable,
        (object) Amt_Rcvd,
        (object) Exch_Balance,
        (object) UnAcct_Balance,
        (object) AccountNumber,
        (object) QuoteControlNum,
        (object) InvoiceDate,
        (object) APGL,
        (object) EXGL,
        (object) UAGL,
        (object) PropAmt,
        (object) CostCenterId,
        (object) payeePercentRate,
        (object) mgaPercentrate,
        (object) apapplied,
        (object) CheckRequested,
        (object) Fees_Due_Date,
        (object) LOB,
        (object) TransactionDate,
        (object) Endorsement_Effective,
        (object) CurrencyCode,
        (object) CurrencyCode_Functional,
        (object) CurrencyCode_Reporting,
        (object) ConvRate_Functional,
        (object) ConvRate_Reporting,
        (object) Producer
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsOpenPayables.OpenPayablesDataTable payablesDataTable = (dsOpenPayables.OpenPayablesDataTable) base.Clone();
      payablesDataTable.InitVars();
      return (DataTable) payablesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsOpenPayables.OpenPayablesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnInvoiceNum = this.Columns["InvoiceNum"];
      this.columnGLCompanyId = this.Columns["GLCompanyId"];
      this.columnPayeeGuid = this.Columns["PayeeGuid"];
      this.columnCompanyLineGuid = this.Columns["CompanyLineGuid"];
      this.columnChargeCode = this.Columns["ChargeCode"];
      this.columnPolicyNumber = this.Columns["PolicyNumber"];
      this.columnInsuredPolicyName = this.Columns["InsuredPolicyName"];
      this.columnEffectiveDate = this.Columns["EffectiveDate"];
      this.columnExpirationDate = this.Columns["ExpirationDate"];
      this.columnDueDate = this.Columns["DueDate"];
      this.columnOfficeInvoiceNum = this.Columns["OfficeInvoiceNum"];
      this.columnPayee = this.Columns["Payee"];
      this.columnChargeName = this.Columns["ChargeName"];
      this.columnGross_Payable = this.Columns["Gross Payable"];
      this.columnAmtPtd = this.Columns["AmtPtd"];
      this.columnNet_Payable = this.Columns["Net Payable"];
      this.columnAmt_Rcvd = this.Columns["Amt Rcvd"];
      this.columnExch_Balance = this.Columns["Exch Balance"];
      this.columnUnAcct_Balance = this.Columns["UnAcct Balance"];
      this.columnAccountNumber = this.Columns["AccountNumber"];
      this.columnQuoteControlNum = this.Columns["QuoteControlNum"];
      this.columnInvoiceDate = this.Columns["InvoiceDate"];
      this.columnAPGL = this.Columns["APGL"];
      this.columnEXGL = this.Columns["EXGL"];
      this.columnUAGL = this.Columns["UAGL"];
      this.columnPropAmt = this.Columns["PropAmt"];
      this.columnCostCenterId = this.Columns["CostCenterId"];
      this.columnpayeePercentRate = this.Columns["payeePercentRate"];
      this.columnmgaPercentrate = this.Columns["mgaPercentrate"];
      this.columnapapplied = this.Columns["apapplied"];
      this.columnCheckRequested = this.Columns["CheckRequested"];
      this.columnFees_Due_Date = this.Columns["Fees Due Date"];
      this.columnLOB = this.Columns["LOB"];
      this.columnTransactionDate = this.Columns["TransactionDate"];
      this.columnEndorsement_Effective = this.Columns["Endorsement Effective"];
      this.columnCurrencyCode = this.Columns["CurrencyCode"];
      this.columnCurrencyCode_Functional = this.Columns["CurrencyCode_Functional"];
      this.columnCurrencyCode_Reporting = this.Columns["CurrencyCode_Reporting"];
      this.columnConvRate_Functional = this.Columns["ConvRate_Functional"];
      this.columnConvRate_Reporting = this.Columns["ConvRate_Reporting"];
      this.columnProducer = this.Columns["Producer"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnInvoiceNum = new DataColumn("InvoiceNum", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInvoiceNum);
      this.columnGLCompanyId = new DataColumn("GLCompanyId", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnGLCompanyId);
      this.columnPayeeGuid = new DataColumn("PayeeGuid", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPayeeGuid);
      this.columnCompanyLineGuid = new DataColumn("CompanyLineGuid", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCompanyLineGuid);
      this.columnChargeCode = new DataColumn("ChargeCode", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnChargeCode);
      this.columnPolicyNumber = new DataColumn("PolicyNumber", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPolicyNumber);
      this.columnInsuredPolicyName = new DataColumn("InsuredPolicyName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInsuredPolicyName);
      this.columnEffectiveDate = new DataColumn("EffectiveDate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEffectiveDate);
      this.columnExpirationDate = new DataColumn("ExpirationDate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnExpirationDate);
      this.columnDueDate = new DataColumn("DueDate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDueDate);
      this.columnOfficeInvoiceNum = new DataColumn("OfficeInvoiceNum", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnOfficeInvoiceNum);
      this.columnPayee = new DataColumn("Payee", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPayee);
      this.columnChargeName = new DataColumn("ChargeName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnChargeName);
      this.columnGross_Payable = new DataColumn("Gross Payable", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnGross_Payable);
      this.columnAmtPtd = new DataColumn("AmtPtd", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAmtPtd);
      this.columnNet_Payable = new DataColumn("Net Payable", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnNet_Payable);
      this.columnAmt_Rcvd = new DataColumn("Amt Rcvd", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAmt_Rcvd);
      this.columnExch_Balance = new DataColumn("Exch Balance", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnExch_Balance);
      this.columnUnAcct_Balance = new DataColumn("UnAcct Balance", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnUnAcct_Balance);
      this.columnAccountNumber = new DataColumn("AccountNumber", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAccountNumber);
      this.columnQuoteControlNum = new DataColumn("QuoteControlNum", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnQuoteControlNum);
      this.columnInvoiceDate = new DataColumn("InvoiceDate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInvoiceDate);
      this.columnAPGL = new DataColumn("APGL", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAPGL);
      this.columnEXGL = new DataColumn("EXGL", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEXGL);
      this.columnUAGL = new DataColumn("UAGL", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnUAGL);
      this.columnPropAmt = new DataColumn("PropAmt", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPropAmt);
      this.columnCostCenterId = new DataColumn("CostCenterId", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCostCenterId);
      this.columnpayeePercentRate = new DataColumn("payeePercentRate", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnpayeePercentRate);
      this.columnmgaPercentrate = new DataColumn("mgaPercentrate", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnmgaPercentrate);
      this.columnapapplied = new DataColumn("apapplied", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnapapplied);
      this.columnCheckRequested = new DataColumn("CheckRequested", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCheckRequested);
      this.columnFees_Due_Date = new DataColumn("Fees Due Date", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFees_Due_Date);
      this.columnLOB = new DataColumn("LOB", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLOB);
      this.columnTransactionDate = new DataColumn("TransactionDate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnTransactionDate);
      this.columnEndorsement_Effective = new DataColumn("Endorsement Effective", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEndorsement_Effective);
      this.columnCurrencyCode = new DataColumn("CurrencyCode", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCurrencyCode);
      this.columnCurrencyCode_Functional = new DataColumn("CurrencyCode_Functional", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCurrencyCode_Functional);
      this.columnCurrencyCode_Reporting = new DataColumn("CurrencyCode_Reporting", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCurrencyCode_Reporting);
      this.columnConvRate_Functional = new DataColumn("ConvRate_Functional", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnConvRate_Functional);
      this.columnConvRate_Reporting = new DataColumn("ConvRate_Reporting", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnConvRate_Reporting);
      this.columnProducer = new DataColumn("Producer", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnProducer);
      this.columnCurrencyCode.DefaultValue = (object) "USD";
      this.columnCurrencyCode_Functional.DefaultValue = (object) "USD";
      this.columnCurrencyCode_Reporting.DefaultValue = (object) "USD";
      this.columnConvRate_Functional.DefaultValue = (object) 1M;
      this.columnConvRate_Reporting.DefaultValue = (object) 1M;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsOpenPayables.OpenPayablesRow NewOpenPayablesRow()
    {
      return (dsOpenPayables.OpenPayablesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsOpenPayables.OpenPayablesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (dsOpenPayables.OpenPayablesRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.OpenPayablesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsOpenPayables.OpenPayablesRowChangeEventHandler payablesRowChangedEvent = this.OpenPayablesRowChangedEvent;
      if (payablesRowChangedEvent == null)
        return;
      payablesRowChangedEvent((object) this, new dsOpenPayables.OpenPayablesRowChangeEvent((dsOpenPayables.OpenPayablesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.OpenPayablesRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsOpenPayables.OpenPayablesRowChangeEventHandler rowChangingEvent = this.OpenPayablesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsOpenPayables.OpenPayablesRowChangeEvent((dsOpenPayables.OpenPayablesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.OpenPayablesRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsOpenPayables.OpenPayablesRowChangeEventHandler payablesRowDeletedEvent = this.OpenPayablesRowDeletedEvent;
      if (payablesRowDeletedEvent == null)
        return;
      payablesRowDeletedEvent((object) this, new dsOpenPayables.OpenPayablesRowChangeEvent((dsOpenPayables.OpenPayablesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.OpenPayablesRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsOpenPayables.OpenPayablesRowChangeEventHandler rowDeletingEvent = this.OpenPayablesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsOpenPayables.OpenPayablesRowChangeEvent((dsOpenPayables.OpenPayablesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemoveOpenPayablesRow(dsOpenPayables.OpenPayablesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsOpenPayables dsOpenPayables = new dsOpenPayables();
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
        FixedValue = dsOpenPayables.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (OpenPayablesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsOpenPayables.GetSchemaSerializable();
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

  public class OpenPayablesRow : DataRow
  {
    private dsOpenPayables.OpenPayablesDataTable tableOpenPayables;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal OpenPayablesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableOpenPayables = (dsOpenPayables.OpenPayablesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int InvoiceNum
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tableOpenPayables.InvoiceNumColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'InvoiceNum' in table 'OpenPayables' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableOpenPayables.InvoiceNumColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int GLCompanyId
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tableOpenPayables.GLCompanyIdColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'GLCompanyId' in table 'OpenPayables' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableOpenPayables.GLCompanyIdColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string PayeeGuid
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableOpenPayables.PayeeGuidColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'PayeeGuid' in table 'OpenPayables' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableOpenPayables.PayeeGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string CompanyLineGuid
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableOpenPayables.CompanyLineGuidColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'CompanyLineGuid' in table 'OpenPayables' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableOpenPayables.CompanyLineGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int ChargeCode
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tableOpenPayables.ChargeCodeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ChargeCode' in table 'OpenPayables' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableOpenPayables.ChargeCodeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string PolicyNumber
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableOpenPayables.PolicyNumberColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'PolicyNumber' in table 'OpenPayables' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableOpenPayables.PolicyNumberColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string InsuredPolicyName
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableOpenPayables.InsuredPolicyNameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'InsuredPolicyName' in table 'OpenPayables' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableOpenPayables.InsuredPolicyNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DateTime EffectiveDate
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tableOpenPayables.EffectiveDateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'EffectiveDate' in table 'OpenPayables' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableOpenPayables.EffectiveDateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DateTime ExpirationDate
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tableOpenPayables.ExpirationDateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ExpirationDate' in table 'OpenPayables' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableOpenPayables.ExpirationDateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DateTime DueDate
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tableOpenPayables.DueDateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DueDate' in table 'OpenPayables' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableOpenPayables.DueDateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int OfficeInvoiceNum
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tableOpenPayables.OfficeInvoiceNumColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'OfficeInvoiceNum' in table 'OpenPayables' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableOpenPayables.OfficeInvoiceNumColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Payee
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableOpenPayables.PayeeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Payee' in table 'OpenPayables' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableOpenPayables.PayeeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string ChargeName
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableOpenPayables.ChargeNameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ChargeName' in table 'OpenPayables' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableOpenPayables.ChargeNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal Gross_Payable
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tableOpenPayables.Gross_PayableColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Gross Payable' in table 'OpenPayables' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableOpenPayables.Gross_PayableColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal AmtPtd
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tableOpenPayables.AmtPtdColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'AmtPtd' in table 'OpenPayables' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableOpenPayables.AmtPtdColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal Net_Payable
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tableOpenPayables.Net_PayableColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Net Payable' in table 'OpenPayables' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableOpenPayables.Net_PayableColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal Amt_Rcvd
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tableOpenPayables.Amt_RcvdColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Amt Rcvd' in table 'OpenPayables' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableOpenPayables.Amt_RcvdColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal Exch_Balance
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tableOpenPayables.Exch_BalanceColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Exch Balance' in table 'OpenPayables' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableOpenPayables.Exch_BalanceColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal UnAcct_Balance
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tableOpenPayables.UnAcct_BalanceColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'UnAcct Balance' in table 'OpenPayables' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableOpenPayables.UnAcct_BalanceColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string AccountNumber
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableOpenPayables.AccountNumberColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'AccountNumber' in table 'OpenPayables' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableOpenPayables.AccountNumberColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int QuoteControlNum
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tableOpenPayables.QuoteControlNumColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'QuoteControlNum' in table 'OpenPayables' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableOpenPayables.QuoteControlNumColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DateTime InvoiceDate
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tableOpenPayables.InvoiceDateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'InvoiceDate' in table 'OpenPayables' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableOpenPayables.InvoiceDateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int APGL
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tableOpenPayables.APGLColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'APGL' in table 'OpenPayables' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableOpenPayables.APGLColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int EXGL
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tableOpenPayables.EXGLColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'EXGL' in table 'OpenPayables' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableOpenPayables.EXGLColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int UAGL
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tableOpenPayables.UAGLColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'UAGL' in table 'OpenPayables' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableOpenPayables.UAGLColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal PropAmt
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tableOpenPayables.PropAmtColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'PropAmt' in table 'OpenPayables' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableOpenPayables.PropAmtColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int CostCenterId
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tableOpenPayables.CostCenterIdColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'CostCenterId' in table 'OpenPayables' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableOpenPayables.CostCenterIdColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal payeePercentRate
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tableOpenPayables.payeePercentRateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'payeePercentRate' in table 'OpenPayables' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableOpenPayables.payeePercentRateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal mgaPercentrate
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tableOpenPayables.mgaPercentrateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'mgaPercentrate' in table 'OpenPayables' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableOpenPayables.mgaPercentrateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal apapplied
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tableOpenPayables.apappliedColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'apapplied' in table 'OpenPayables' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableOpenPayables.apappliedColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DateTime CheckRequested
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tableOpenPayables.CheckRequestedColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'CheckRequested' in table 'OpenPayables' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableOpenPayables.CheckRequestedColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DateTime Fees_Due_Date
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tableOpenPayables.Fees_Due_DateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Fees Due Date' in table 'OpenPayables' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableOpenPayables.Fees_Due_DateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string LOB
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableOpenPayables.LOBColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'LOB' in table 'OpenPayables' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableOpenPayables.LOBColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DateTime TransactionDate
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tableOpenPayables.TransactionDateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'TransactionDate' in table 'OpenPayables' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableOpenPayables.TransactionDateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DateTime Endorsement_Effective
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tableOpenPayables.Endorsement_EffectiveColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Endorsement Effective' in table 'OpenPayables' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableOpenPayables.Endorsement_EffectiveColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string CurrencyCode
    {
      get
      {
        return !this.IsCurrencyCodeNull() ? Conversions.ToString(this[this.tableOpenPayables.CurrencyCodeColumn]) : "USD";
      }
      set => this[this.tableOpenPayables.CurrencyCodeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string CurrencyCode_Functional
    {
      get
      {
        return !this.IsCurrencyCode_FunctionalNull() ? Conversions.ToString(this[this.tableOpenPayables.CurrencyCode_FunctionalColumn]) : "USD";
      }
      set => this[this.tableOpenPayables.CurrencyCode_FunctionalColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string CurrencyCode_Reporting
    {
      get
      {
        return !this.IsCurrencyCode_ReportingNull() ? Conversions.ToString(this[this.tableOpenPayables.CurrencyCode_ReportingColumn]) : "USD";
      }
      set => this[this.tableOpenPayables.CurrencyCode_ReportingColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal ConvRate_Functional
    {
      get
      {
        return !this.IsConvRate_FunctionalNull() ? Conversions.ToDecimal(this[this.tableOpenPayables.ConvRate_FunctionalColumn]) : 1M;
      }
      set => this[this.tableOpenPayables.ConvRate_FunctionalColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal ConvRate_Reporting
    {
      get
      {
        return !this.IsConvRate_ReportingNull() ? Conversions.ToDecimal(this[this.tableOpenPayables.ConvRate_ReportingColumn]) : 1M;
      }
      set => this[this.tableOpenPayables.ConvRate_ReportingColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Producer
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableOpenPayables.ProducerColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Producer' in table 'OpenPayables' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableOpenPayables.ProducerColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsInvoiceNumNull() => this.IsNull(this.tableOpenPayables.InvoiceNumColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetInvoiceNumNull()
    {
      this[this.tableOpenPayables.InvoiceNumColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsGLCompanyIdNull() => this.IsNull(this.tableOpenPayables.GLCompanyIdColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetGLCompanyIdNull()
    {
      this[this.tableOpenPayables.GLCompanyIdColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsPayeeGuidNull() => this.IsNull(this.tableOpenPayables.PayeeGuidColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetPayeeGuidNull()
    {
      this[this.tableOpenPayables.PayeeGuidColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsCompanyLineGuidNull()
    {
      return this.IsNull(this.tableOpenPayables.CompanyLineGuidColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetCompanyLineGuidNull()
    {
      this[this.tableOpenPayables.CompanyLineGuidColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsChargeCodeNull() => this.IsNull(this.tableOpenPayables.ChargeCodeColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetChargeCodeNull()
    {
      this[this.tableOpenPayables.ChargeCodeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsPolicyNumberNull() => this.IsNull(this.tableOpenPayables.PolicyNumberColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetPolicyNumberNull()
    {
      this[this.tableOpenPayables.PolicyNumberColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsInsuredPolicyNameNull()
    {
      return this.IsNull(this.tableOpenPayables.InsuredPolicyNameColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetInsuredPolicyNameNull()
    {
      this[this.tableOpenPayables.InsuredPolicyNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsEffectiveDateNull() => this.IsNull(this.tableOpenPayables.EffectiveDateColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetEffectiveDateNull()
    {
      this[this.tableOpenPayables.EffectiveDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsExpirationDateNull() => this.IsNull(this.tableOpenPayables.ExpirationDateColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetExpirationDateNull()
    {
      this[this.tableOpenPayables.ExpirationDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsDueDateNull() => this.IsNull(this.tableOpenPayables.DueDateColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetDueDateNull()
    {
      this[this.tableOpenPayables.DueDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsOfficeInvoiceNumNull()
    {
      return this.IsNull(this.tableOpenPayables.OfficeInvoiceNumColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetOfficeInvoiceNumNull()
    {
      this[this.tableOpenPayables.OfficeInvoiceNumColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsPayeeNull() => this.IsNull(this.tableOpenPayables.PayeeColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetPayeeNull()
    {
      this[this.tableOpenPayables.PayeeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsChargeNameNull() => this.IsNull(this.tableOpenPayables.ChargeNameColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetChargeNameNull()
    {
      this[this.tableOpenPayables.ChargeNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsGross_PayableNull() => this.IsNull(this.tableOpenPayables.Gross_PayableColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetGross_PayableNull()
    {
      this[this.tableOpenPayables.Gross_PayableColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsAmtPtdNull() => this.IsNull(this.tableOpenPayables.AmtPtdColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetAmtPtdNull()
    {
      this[this.tableOpenPayables.AmtPtdColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsNet_PayableNull() => this.IsNull(this.tableOpenPayables.Net_PayableColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetNet_PayableNull()
    {
      this[this.tableOpenPayables.Net_PayableColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsAmt_RcvdNull() => this.IsNull(this.tableOpenPayables.Amt_RcvdColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetAmt_RcvdNull()
    {
      this[this.tableOpenPayables.Amt_RcvdColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsExch_BalanceNull() => this.IsNull(this.tableOpenPayables.Exch_BalanceColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetExch_BalanceNull()
    {
      this[this.tableOpenPayables.Exch_BalanceColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsUnAcct_BalanceNull() => this.IsNull(this.tableOpenPayables.UnAcct_BalanceColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetUnAcct_BalanceNull()
    {
      this[this.tableOpenPayables.UnAcct_BalanceColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsAccountNumberNull() => this.IsNull(this.tableOpenPayables.AccountNumberColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetAccountNumberNull()
    {
      this[this.tableOpenPayables.AccountNumberColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsQuoteControlNumNull()
    {
      return this.IsNull(this.tableOpenPayables.QuoteControlNumColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetQuoteControlNumNull()
    {
      this[this.tableOpenPayables.QuoteControlNumColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsInvoiceDateNull() => this.IsNull(this.tableOpenPayables.InvoiceDateColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetInvoiceDateNull()
    {
      this[this.tableOpenPayables.InvoiceDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsAPGLNull() => this.IsNull(this.tableOpenPayables.APGLColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetAPGLNull()
    {
      this[this.tableOpenPayables.APGLColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsEXGLNull() => this.IsNull(this.tableOpenPayables.EXGLColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetEXGLNull()
    {
      this[this.tableOpenPayables.EXGLColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsUAGLNull() => this.IsNull(this.tableOpenPayables.UAGLColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetUAGLNull()
    {
      this[this.tableOpenPayables.UAGLColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsPropAmtNull() => this.IsNull(this.tableOpenPayables.PropAmtColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetPropAmtNull()
    {
      this[this.tableOpenPayables.PropAmtColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsCostCenterIdNull() => this.IsNull(this.tableOpenPayables.CostCenterIdColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetCostCenterIdNull()
    {
      this[this.tableOpenPayables.CostCenterIdColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IspayeePercentRateNull()
    {
      return this.IsNull(this.tableOpenPayables.payeePercentRateColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetpayeePercentRateNull()
    {
      this[this.tableOpenPayables.payeePercentRateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsmgaPercentrateNull() => this.IsNull(this.tableOpenPayables.mgaPercentrateColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetmgaPercentrateNull()
    {
      this[this.tableOpenPayables.mgaPercentrateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsapappliedNull() => this.IsNull(this.tableOpenPayables.apappliedColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetapappliedNull()
    {
      this[this.tableOpenPayables.apappliedColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsCheckRequestedNull() => this.IsNull(this.tableOpenPayables.CheckRequestedColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetCheckRequestedNull()
    {
      this[this.tableOpenPayables.CheckRequestedColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsFees_Due_DateNull() => this.IsNull(this.tableOpenPayables.Fees_Due_DateColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetFees_Due_DateNull()
    {
      this[this.tableOpenPayables.Fees_Due_DateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsLOBNull() => this.IsNull(this.tableOpenPayables.LOBColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetLOBNull()
    {
      this[this.tableOpenPayables.LOBColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsTransactionDateNull()
    {
      return this.IsNull(this.tableOpenPayables.TransactionDateColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetTransactionDateNull()
    {
      this[this.tableOpenPayables.TransactionDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsEndorsement_EffectiveNull()
    {
      return this.IsNull(this.tableOpenPayables.Endorsement_EffectiveColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetEndorsement_EffectiveNull()
    {
      this[this.tableOpenPayables.Endorsement_EffectiveColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsCurrencyCodeNull() => this.IsNull(this.tableOpenPayables.CurrencyCodeColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetCurrencyCodeNull()
    {
      this[this.tableOpenPayables.CurrencyCodeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsCurrencyCode_FunctionalNull()
    {
      return this.IsNull(this.tableOpenPayables.CurrencyCode_FunctionalColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetCurrencyCode_FunctionalNull()
    {
      this[this.tableOpenPayables.CurrencyCode_FunctionalColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsCurrencyCode_ReportingNull()
    {
      return this.IsNull(this.tableOpenPayables.CurrencyCode_ReportingColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetCurrencyCode_ReportingNull()
    {
      this[this.tableOpenPayables.CurrencyCode_ReportingColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsConvRate_FunctionalNull()
    {
      return this.IsNull(this.tableOpenPayables.ConvRate_FunctionalColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetConvRate_FunctionalNull()
    {
      this[this.tableOpenPayables.ConvRate_FunctionalColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsConvRate_ReportingNull()
    {
      return this.IsNull(this.tableOpenPayables.ConvRate_ReportingColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetConvRate_ReportingNull()
    {
      this[this.tableOpenPayables.ConvRate_ReportingColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsProducerNull() => this.IsNull(this.tableOpenPayables.ProducerColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetProducerNull()
    {
      this[this.tableOpenPayables.ProducerColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class OpenPayablesRowChangeEvent : EventArgs
  {
    private dsOpenPayables.OpenPayablesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public OpenPayablesRowChangeEvent(dsOpenPayables.OpenPayablesRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsOpenPayables.OpenPayablesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }
}
