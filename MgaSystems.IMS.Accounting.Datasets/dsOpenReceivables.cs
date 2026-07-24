// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.AccountingDatasets.dsOpenReceivables
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
[XmlRoot("dsOpenReceivables")]
[HelpKeyword("vs.data.DataSet")]
[Serializable]
public class dsOpenReceivables : DataSet
{
  private dsOpenReceivables.OpenReceivablesDataTable tableOpenReceivables;
  private SchemaSerializationMode _schemaSerializationMode;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public dsOpenReceivables()
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
  protected dsOpenReceivables(SerializationInfo info, StreamingContext context)
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
        if (dataSet.Tables[nameof (OpenReceivables)] != null)
          base.Tables.Add((DataTable) new dsOpenReceivables.OpenReceivablesDataTable(dataSet.Tables[nameof (OpenReceivables)]));
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
  public dsOpenReceivables.OpenReceivablesDataTable OpenReceivables => this.tableOpenReceivables;

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
    dsOpenReceivables dsOpenReceivables = (dsOpenReceivables) base.Clone();
    dsOpenReceivables.InitVars();
    dsOpenReceivables.SchemaSerializationMode = this.SchemaSerializationMode;
    return (DataSet) dsOpenReceivables;
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
      if (dataSet.Tables["OpenReceivables"] != null)
        base.Tables.Add((DataTable) new dsOpenReceivables.OpenReceivablesDataTable(dataSet.Tables["OpenReceivables"]));
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
    this.tableOpenReceivables = (dsOpenReceivables.OpenReceivablesDataTable) base.Tables["OpenReceivables"];
    if (!initTable || this.tableOpenReceivables == null)
      return;
    this.tableOpenReceivables.InitVars();
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private void InitClass()
  {
    this.DataSetName = nameof (dsOpenReceivables);
    this.Prefix = "";
    this.Namespace = "http://tempuri.org/dsOpenReceivables.xsd";
    this.EnforceConstraints = true;
    this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.tableOpenReceivables = new dsOpenReceivables.OpenReceivablesDataTable();
    base.Tables.Add((DataTable) this.tableOpenReceivables);
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializeOpenReceivables() => false;

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
    dsOpenReceivables dsOpenReceivables = new dsOpenReceivables();
    XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
    schemaComplexType.Particle = (XmlSchemaParticle) new XmlSchemaSequence()
    {
      Items = {
        (XmlSchemaObject) new XmlSchemaAny()
        {
          Namespace = dsOpenReceivables.Namespace
        }
      }
    };
    XmlSchema schemaSerializable = dsOpenReceivables.GetSchemaSerializable();
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
  public delegate void OpenReceivablesRowChangeEventHandler(
    object sender,
    dsOpenReceivables.OpenReceivablesRowChangeEvent e);

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class OpenReceivablesDataTable : TypedTableBase<dsOpenReceivables.OpenReceivablesRow>
  {
    private DataColumn columnInvoiceNum;
    private DataColumn columnOfficeInvoiceNum;
    private DataColumn columnQuoteId;
    private DataColumn columnQuoteControlNum;
    private DataColumn columnPolicyNumber;
    private DataColumn columnInsuredPolicyName;
    private DataColumn columnEffectiveDate;
    private DataColumn columnExpirationDate;
    private DataColumn columnInvoiceDate;
    private DataColumn columnDueDate;
    private DataColumn columnChargeName;
    private DataColumn columnChargeCode;
    private DataColumn columnCompanyLineGuid;
    private DataColumn columnAmtBilled;
    private DataColumn columnAmtRTD;
    private DataColumn columnNetDue;
    private DataColumn columnAmtPTC;
    private DataColumn columnUnacctBalance;
    private DataColumn columnExchBalance;
    private DataColumn columnARGL;
    private DataColumn columnEXGL;
    private DataColumn columnUAGL;
    private DataColumn columnAccountNumber;
    private DataColumn columnCurrentStatus;
    private DataColumn columnFinanceCompanyGuid;
    private DataColumn columnRemitterGuid;
    private DataColumn columnCostCenterId;
    private DataColumn columnARApplied;
    private DataColumn columnExchApplied;
    private DataColumn columnUnAcctApplied;
    private DataColumn columnLOB;
    private DataColumn columnEndorsement_Effective;
    private DataColumn columnCurrencyCode;
    private DataColumn columnCurrencyCode_Functional;
    private DataColumn columnCurrencyCode_Reporting;
    private DataColumn columnConvRate_Functional;
    private DataColumn columnConvRate_Reporting;
    private DataColumn columnProducer;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public OpenReceivablesDataTable()
    {
      this.TableName = "OpenReceivables";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal OpenReceivablesDataTable(DataTable table)
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
    protected OpenReceivablesDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn InvoiceNumColumn => this.columnInvoiceNum;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn OfficeInvoiceNumColumn => this.columnOfficeInvoiceNum;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn QuoteIdColumn => this.columnQuoteId;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn QuoteControlNumColumn => this.columnQuoteControlNum;

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
    public DataColumn InvoiceDateColumn => this.columnInvoiceDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn DueDateColumn => this.columnDueDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ChargeNameColumn => this.columnChargeName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ChargeCodeColumn => this.columnChargeCode;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn CompanyLineGuidColumn => this.columnCompanyLineGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn AmtBilledColumn => this.columnAmtBilled;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn AmtRTDColumn => this.columnAmtRTD;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn NetDueColumn => this.columnNetDue;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn AmtPTCColumn => this.columnAmtPTC;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn UnacctBalanceColumn => this.columnUnacctBalance;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ExchBalanceColumn => this.columnExchBalance;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ARGLColumn => this.columnARGL;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn EXGLColumn => this.columnEXGL;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn UAGLColumn => this.columnUAGL;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn AccountNumberColumn => this.columnAccountNumber;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn CurrentStatusColumn => this.columnCurrentStatus;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn FinanceCompanyGuidColumn => this.columnFinanceCompanyGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn RemitterGuidColumn => this.columnRemitterGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn CostCenterIdColumn => this.columnCostCenterId;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ARAppliedColumn => this.columnARApplied;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ExchAppliedColumn => this.columnExchApplied;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn UnAcctAppliedColumn => this.columnUnAcctApplied;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn LOBColumn => this.columnLOB;

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
    public dsOpenReceivables.OpenReceivablesRow this[int index]
    {
      get => (dsOpenReceivables.OpenReceivablesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsOpenReceivables.OpenReceivablesRowChangeEventHandler OpenReceivablesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsOpenReceivables.OpenReceivablesRowChangeEventHandler OpenReceivablesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsOpenReceivables.OpenReceivablesRowChangeEventHandler OpenReceivablesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsOpenReceivables.OpenReceivablesRowChangeEventHandler OpenReceivablesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddOpenReceivablesRow(dsOpenReceivables.OpenReceivablesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsOpenReceivables.OpenReceivablesRow AddOpenReceivablesRow(
      int InvoiceNum,
      int OfficeInvoiceNum,
      int QuoteId,
      int QuoteControlNum,
      string PolicyNumber,
      string InsuredPolicyName,
      DateTime EffectiveDate,
      DateTime ExpirationDate,
      DateTime InvoiceDate,
      DateTime DueDate,
      string ChargeName,
      int ChargeCode,
      string CompanyLineGuid,
      Decimal AmtBilled,
      Decimal AmtRTD,
      Decimal NetDue,
      Decimal AmtPTC,
      Decimal UnacctBalance,
      Decimal ExchBalance,
      int ARGL,
      int EXGL,
      int UAGL,
      string AccountNumber,
      string CurrentStatus,
      string FinanceCompanyGuid,
      string RemitterGuid,
      int CostCenterId,
      Decimal ARApplied,
      Decimal ExchApplied,
      Decimal UnAcctApplied,
      string LOB,
      DateTime Endorsement_Effective,
      string CurrencyCode,
      string CurrencyCode_Functional,
      string CurrencyCode_Reporting,
      Decimal ConvRate_Functional,
      Decimal ConvRate_Reporting,
      string Producer)
    {
      dsOpenReceivables.OpenReceivablesRow row = (dsOpenReceivables.OpenReceivablesRow) this.NewRow();
      object[] objArray = new object[38]
      {
        (object) InvoiceNum,
        (object) OfficeInvoiceNum,
        (object) QuoteId,
        (object) QuoteControlNum,
        (object) PolicyNumber,
        (object) InsuredPolicyName,
        (object) EffectiveDate,
        (object) ExpirationDate,
        (object) InvoiceDate,
        (object) DueDate,
        (object) ChargeName,
        (object) ChargeCode,
        (object) CompanyLineGuid,
        (object) AmtBilled,
        (object) AmtRTD,
        (object) NetDue,
        (object) AmtPTC,
        (object) UnacctBalance,
        (object) ExchBalance,
        (object) ARGL,
        (object) EXGL,
        (object) UAGL,
        (object) AccountNumber,
        (object) CurrentStatus,
        (object) FinanceCompanyGuid,
        (object) RemitterGuid,
        (object) CostCenterId,
        (object) ARApplied,
        (object) ExchApplied,
        (object) UnAcctApplied,
        (object) LOB,
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
      dsOpenReceivables.OpenReceivablesDataTable receivablesDataTable = (dsOpenReceivables.OpenReceivablesDataTable) base.Clone();
      receivablesDataTable.InitVars();
      return (DataTable) receivablesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsOpenReceivables.OpenReceivablesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnInvoiceNum = this.Columns["InvoiceNum"];
      this.columnOfficeInvoiceNum = this.Columns["OfficeInvoiceNum"];
      this.columnQuoteId = this.Columns["QuoteId"];
      this.columnQuoteControlNum = this.Columns["QuoteControlNum"];
      this.columnPolicyNumber = this.Columns["PolicyNumber"];
      this.columnInsuredPolicyName = this.Columns["InsuredPolicyName"];
      this.columnEffectiveDate = this.Columns["EffectiveDate"];
      this.columnExpirationDate = this.Columns["ExpirationDate"];
      this.columnInvoiceDate = this.Columns["InvoiceDate"];
      this.columnDueDate = this.Columns["DueDate"];
      this.columnChargeName = this.Columns["ChargeName"];
      this.columnChargeCode = this.Columns["ChargeCode"];
      this.columnCompanyLineGuid = this.Columns["CompanyLineGuid"];
      this.columnAmtBilled = this.Columns["AmtBilled"];
      this.columnAmtRTD = this.Columns["AmtRTD"];
      this.columnNetDue = this.Columns["NetDue"];
      this.columnAmtPTC = this.Columns["AmtPTC"];
      this.columnUnacctBalance = this.Columns["UnacctBalance"];
      this.columnExchBalance = this.Columns["ExchBalance"];
      this.columnARGL = this.Columns["ARGL"];
      this.columnEXGL = this.Columns["EXGL"];
      this.columnUAGL = this.Columns["UAGL"];
      this.columnAccountNumber = this.Columns["AccountNumber"];
      this.columnCurrentStatus = this.Columns["CurrentStatus"];
      this.columnFinanceCompanyGuid = this.Columns["FinanceCompanyGuid"];
      this.columnRemitterGuid = this.Columns["RemitterGuid"];
      this.columnCostCenterId = this.Columns["CostCenterId"];
      this.columnARApplied = this.Columns["ARApplied"];
      this.columnExchApplied = this.Columns["ExchApplied"];
      this.columnUnAcctApplied = this.Columns["UnAcctApplied"];
      this.columnLOB = this.Columns["LOB"];
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
      this.columnOfficeInvoiceNum = new DataColumn("OfficeInvoiceNum", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnOfficeInvoiceNum);
      this.columnQuoteId = new DataColumn("QuoteId", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnQuoteId);
      this.columnQuoteControlNum = new DataColumn("QuoteControlNum", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnQuoteControlNum);
      this.columnPolicyNumber = new DataColumn("PolicyNumber", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPolicyNumber);
      this.columnInsuredPolicyName = new DataColumn("InsuredPolicyName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInsuredPolicyName);
      this.columnEffectiveDate = new DataColumn("EffectiveDate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEffectiveDate);
      this.columnExpirationDate = new DataColumn("ExpirationDate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnExpirationDate);
      this.columnInvoiceDate = new DataColumn("InvoiceDate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInvoiceDate);
      this.columnDueDate = new DataColumn("DueDate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDueDate);
      this.columnChargeName = new DataColumn("ChargeName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnChargeName);
      this.columnChargeCode = new DataColumn("ChargeCode", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnChargeCode);
      this.columnCompanyLineGuid = new DataColumn("CompanyLineGuid", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCompanyLineGuid);
      this.columnAmtBilled = new DataColumn("AmtBilled", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAmtBilled);
      this.columnAmtRTD = new DataColumn("AmtRTD", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAmtRTD);
      this.columnNetDue = new DataColumn("NetDue", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnNetDue);
      this.columnAmtPTC = new DataColumn("AmtPTC", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAmtPTC);
      this.columnUnacctBalance = new DataColumn("UnacctBalance", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnUnacctBalance);
      this.columnExchBalance = new DataColumn("ExchBalance", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnExchBalance);
      this.columnARGL = new DataColumn("ARGL", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnARGL);
      this.columnEXGL = new DataColumn("EXGL", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEXGL);
      this.columnUAGL = new DataColumn("UAGL", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnUAGL);
      this.columnAccountNumber = new DataColumn("AccountNumber", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAccountNumber);
      this.columnCurrentStatus = new DataColumn("CurrentStatus", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCurrentStatus);
      this.columnFinanceCompanyGuid = new DataColumn("FinanceCompanyGuid", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFinanceCompanyGuid);
      this.columnRemitterGuid = new DataColumn("RemitterGuid", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnRemitterGuid);
      this.columnCostCenterId = new DataColumn("CostCenterId", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCostCenterId);
      this.columnARApplied = new DataColumn("ARApplied", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnARApplied);
      this.columnExchApplied = new DataColumn("ExchApplied", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnExchApplied);
      this.columnUnAcctApplied = new DataColumn("UnAcctApplied", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnUnAcctApplied);
      this.columnLOB = new DataColumn("LOB", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLOB);
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
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsOpenReceivables.OpenReceivablesRow NewOpenReceivablesRow()
    {
      return (dsOpenReceivables.OpenReceivablesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsOpenReceivables.OpenReceivablesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (dsOpenReceivables.OpenReceivablesRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.OpenReceivablesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsOpenReceivables.OpenReceivablesRowChangeEventHandler receivablesRowChangedEvent = this.OpenReceivablesRowChangedEvent;
      if (receivablesRowChangedEvent == null)
        return;
      receivablesRowChangedEvent((object) this, new dsOpenReceivables.OpenReceivablesRowChangeEvent((dsOpenReceivables.OpenReceivablesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.OpenReceivablesRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsOpenReceivables.OpenReceivablesRowChangeEventHandler rowChangingEvent = this.OpenReceivablesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsOpenReceivables.OpenReceivablesRowChangeEvent((dsOpenReceivables.OpenReceivablesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.OpenReceivablesRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsOpenReceivables.OpenReceivablesRowChangeEventHandler receivablesRowDeletedEvent = this.OpenReceivablesRowDeletedEvent;
      if (receivablesRowDeletedEvent == null)
        return;
      receivablesRowDeletedEvent((object) this, new dsOpenReceivables.OpenReceivablesRowChangeEvent((dsOpenReceivables.OpenReceivablesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.OpenReceivablesRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsOpenReceivables.OpenReceivablesRowChangeEventHandler rowDeletingEvent = this.OpenReceivablesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsOpenReceivables.OpenReceivablesRowChangeEvent((dsOpenReceivables.OpenReceivablesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemoveOpenReceivablesRow(dsOpenReceivables.OpenReceivablesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsOpenReceivables dsOpenReceivables = new dsOpenReceivables();
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
        FixedValue = dsOpenReceivables.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (OpenReceivablesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsOpenReceivables.GetSchemaSerializable();
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

  public class OpenReceivablesRow : DataRow
  {
    private dsOpenReceivables.OpenReceivablesDataTable tableOpenReceivables;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal OpenReceivablesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableOpenReceivables = (dsOpenReceivables.OpenReceivablesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int InvoiceNum
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tableOpenReceivables.InvoiceNumColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'InvoiceNum' in table 'OpenReceivables' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableOpenReceivables.InvoiceNumColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int OfficeInvoiceNum
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tableOpenReceivables.OfficeInvoiceNumColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'OfficeInvoiceNum' in table 'OpenReceivables' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableOpenReceivables.OfficeInvoiceNumColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int QuoteId
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tableOpenReceivables.QuoteIdColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'QuoteId' in table 'OpenReceivables' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableOpenReceivables.QuoteIdColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int QuoteControlNum
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tableOpenReceivables.QuoteControlNumColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'QuoteControlNum' in table 'OpenReceivables' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableOpenReceivables.QuoteControlNumColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string PolicyNumber
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableOpenReceivables.PolicyNumberColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'PolicyNumber' in table 'OpenReceivables' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableOpenReceivables.PolicyNumberColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string InsuredPolicyName
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableOpenReceivables.InsuredPolicyNameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'InsuredPolicyName' in table 'OpenReceivables' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableOpenReceivables.InsuredPolicyNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DateTime EffectiveDate
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tableOpenReceivables.EffectiveDateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'EffectiveDate' in table 'OpenReceivables' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableOpenReceivables.EffectiveDateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DateTime ExpirationDate
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tableOpenReceivables.ExpirationDateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ExpirationDate' in table 'OpenReceivables' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableOpenReceivables.ExpirationDateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DateTime InvoiceDate
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tableOpenReceivables.InvoiceDateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'InvoiceDate' in table 'OpenReceivables' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableOpenReceivables.InvoiceDateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DateTime DueDate
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tableOpenReceivables.DueDateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DueDate' in table 'OpenReceivables' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableOpenReceivables.DueDateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string ChargeName
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableOpenReceivables.ChargeNameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ChargeName' in table 'OpenReceivables' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableOpenReceivables.ChargeNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int ChargeCode
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tableOpenReceivables.ChargeCodeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ChargeCode' in table 'OpenReceivables' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableOpenReceivables.ChargeCodeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string CompanyLineGuid
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableOpenReceivables.CompanyLineGuidColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'CompanyLineGuid' in table 'OpenReceivables' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableOpenReceivables.CompanyLineGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal AmtBilled
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tableOpenReceivables.AmtBilledColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'AmtBilled' in table 'OpenReceivables' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableOpenReceivables.AmtBilledColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal AmtRTD
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tableOpenReceivables.AmtRTDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'AmtRTD' in table 'OpenReceivables' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableOpenReceivables.AmtRTDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal NetDue
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tableOpenReceivables.NetDueColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'NetDue' in table 'OpenReceivables' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableOpenReceivables.NetDueColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal AmtPTC
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tableOpenReceivables.AmtPTCColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'AmtPTC' in table 'OpenReceivables' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableOpenReceivables.AmtPTCColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal UnacctBalance
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tableOpenReceivables.UnacctBalanceColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'UnacctBalance' in table 'OpenReceivables' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableOpenReceivables.UnacctBalanceColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal ExchBalance
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tableOpenReceivables.ExchBalanceColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ExchBalance' in table 'OpenReceivables' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableOpenReceivables.ExchBalanceColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int ARGL
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tableOpenReceivables.ARGLColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ARGL' in table 'OpenReceivables' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableOpenReceivables.ARGLColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int EXGL
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tableOpenReceivables.EXGLColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'EXGL' in table 'OpenReceivables' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableOpenReceivables.EXGLColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int UAGL
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tableOpenReceivables.UAGLColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'UAGL' in table 'OpenReceivables' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableOpenReceivables.UAGLColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string AccountNumber
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableOpenReceivables.AccountNumberColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'AccountNumber' in table 'OpenReceivables' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableOpenReceivables.AccountNumberColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string CurrentStatus
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableOpenReceivables.CurrentStatusColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'CurrentStatus' in table 'OpenReceivables' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableOpenReceivables.CurrentStatusColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string FinanceCompanyGuid
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableOpenReceivables.FinanceCompanyGuidColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'FinanceCompanyGuid' in table 'OpenReceivables' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableOpenReceivables.FinanceCompanyGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string RemitterGuid
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableOpenReceivables.RemitterGuidColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'RemitterGuid' in table 'OpenReceivables' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableOpenReceivables.RemitterGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int CostCenterId
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tableOpenReceivables.CostCenterIdColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'CostCenterId' in table 'OpenReceivables' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableOpenReceivables.CostCenterIdColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal ARApplied
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tableOpenReceivables.ARAppliedColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ARApplied' in table 'OpenReceivables' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableOpenReceivables.ARAppliedColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal ExchApplied
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tableOpenReceivables.ExchAppliedColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ExchApplied' in table 'OpenReceivables' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableOpenReceivables.ExchAppliedColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal UnAcctApplied
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tableOpenReceivables.UnAcctAppliedColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'UnAcctApplied' in table 'OpenReceivables' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableOpenReceivables.UnAcctAppliedColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string LOB
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableOpenReceivables.LOBColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'LOB' in table 'OpenReceivables' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableOpenReceivables.LOBColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DateTime Endorsement_Effective
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tableOpenReceivables.Endorsement_EffectiveColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Endorsement Effective' in table 'OpenReceivables' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableOpenReceivables.Endorsement_EffectiveColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string CurrencyCode
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableOpenReceivables.CurrencyCodeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'CurrencyCode' in table 'OpenReceivables' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableOpenReceivables.CurrencyCodeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string CurrencyCode_Functional
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableOpenReceivables.CurrencyCode_FunctionalColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'CurrencyCode_Functional' in table 'OpenReceivables' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableOpenReceivables.CurrencyCode_FunctionalColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string CurrencyCode_Reporting
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableOpenReceivables.CurrencyCode_ReportingColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'CurrencyCode_Reporting' in table 'OpenReceivables' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableOpenReceivables.CurrencyCode_ReportingColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal ConvRate_Functional
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tableOpenReceivables.ConvRate_FunctionalColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ConvRate_Functional' in table 'OpenReceivables' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableOpenReceivables.ConvRate_FunctionalColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal ConvRate_Reporting
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tableOpenReceivables.ConvRate_ReportingColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ConvRate_Reporting' in table 'OpenReceivables' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableOpenReceivables.ConvRate_ReportingColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Producer
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableOpenReceivables.ProducerColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Producer' in table 'OpenReceivables' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableOpenReceivables.ProducerColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsInvoiceNumNull() => this.IsNull(this.tableOpenReceivables.InvoiceNumColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetInvoiceNumNull()
    {
      this[this.tableOpenReceivables.InvoiceNumColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsOfficeInvoiceNumNull()
    {
      return this.IsNull(this.tableOpenReceivables.OfficeInvoiceNumColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetOfficeInvoiceNumNull()
    {
      this[this.tableOpenReceivables.OfficeInvoiceNumColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsQuoteIdNull() => this.IsNull(this.tableOpenReceivables.QuoteIdColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetQuoteIdNull()
    {
      this[this.tableOpenReceivables.QuoteIdColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsQuoteControlNumNull()
    {
      return this.IsNull(this.tableOpenReceivables.QuoteControlNumColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetQuoteControlNumNull()
    {
      this[this.tableOpenReceivables.QuoteControlNumColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsPolicyNumberNull() => this.IsNull(this.tableOpenReceivables.PolicyNumberColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetPolicyNumberNull()
    {
      this[this.tableOpenReceivables.PolicyNumberColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsInsuredPolicyNameNull()
    {
      return this.IsNull(this.tableOpenReceivables.InsuredPolicyNameColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetInsuredPolicyNameNull()
    {
      this[this.tableOpenReceivables.InsuredPolicyNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsEffectiveDateNull() => this.IsNull(this.tableOpenReceivables.EffectiveDateColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetEffectiveDateNull()
    {
      this[this.tableOpenReceivables.EffectiveDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsExpirationDateNull()
    {
      return this.IsNull(this.tableOpenReceivables.ExpirationDateColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetExpirationDateNull()
    {
      this[this.tableOpenReceivables.ExpirationDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsInvoiceDateNull() => this.IsNull(this.tableOpenReceivables.InvoiceDateColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetInvoiceDateNull()
    {
      this[this.tableOpenReceivables.InvoiceDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsDueDateNull() => this.IsNull(this.tableOpenReceivables.DueDateColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetDueDateNull()
    {
      this[this.tableOpenReceivables.DueDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsChargeNameNull() => this.IsNull(this.tableOpenReceivables.ChargeNameColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetChargeNameNull()
    {
      this[this.tableOpenReceivables.ChargeNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsChargeCodeNull() => this.IsNull(this.tableOpenReceivables.ChargeCodeColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetChargeCodeNull()
    {
      this[this.tableOpenReceivables.ChargeCodeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsCompanyLineGuidNull()
    {
      return this.IsNull(this.tableOpenReceivables.CompanyLineGuidColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetCompanyLineGuidNull()
    {
      this[this.tableOpenReceivables.CompanyLineGuidColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsAmtBilledNull() => this.IsNull(this.tableOpenReceivables.AmtBilledColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetAmtBilledNull()
    {
      this[this.tableOpenReceivables.AmtBilledColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsAmtRTDNull() => this.IsNull(this.tableOpenReceivables.AmtRTDColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetAmtRTDNull()
    {
      this[this.tableOpenReceivables.AmtRTDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsNetDueNull() => this.IsNull(this.tableOpenReceivables.NetDueColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetNetDueNull()
    {
      this[this.tableOpenReceivables.NetDueColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsAmtPTCNull() => this.IsNull(this.tableOpenReceivables.AmtPTCColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetAmtPTCNull()
    {
      this[this.tableOpenReceivables.AmtPTCColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsUnacctBalanceNull() => this.IsNull(this.tableOpenReceivables.UnacctBalanceColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetUnacctBalanceNull()
    {
      this[this.tableOpenReceivables.UnacctBalanceColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsExchBalanceNull() => this.IsNull(this.tableOpenReceivables.ExchBalanceColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetExchBalanceNull()
    {
      this[this.tableOpenReceivables.ExchBalanceColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsARGLNull() => this.IsNull(this.tableOpenReceivables.ARGLColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetARGLNull()
    {
      this[this.tableOpenReceivables.ARGLColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsEXGLNull() => this.IsNull(this.tableOpenReceivables.EXGLColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetEXGLNull()
    {
      this[this.tableOpenReceivables.EXGLColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsUAGLNull() => this.IsNull(this.tableOpenReceivables.UAGLColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetUAGLNull()
    {
      this[this.tableOpenReceivables.UAGLColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsAccountNumberNull() => this.IsNull(this.tableOpenReceivables.AccountNumberColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetAccountNumberNull()
    {
      this[this.tableOpenReceivables.AccountNumberColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsCurrentStatusNull() => this.IsNull(this.tableOpenReceivables.CurrentStatusColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetCurrentStatusNull()
    {
      this[this.tableOpenReceivables.CurrentStatusColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsFinanceCompanyGuidNull()
    {
      return this.IsNull(this.tableOpenReceivables.FinanceCompanyGuidColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetFinanceCompanyGuidNull()
    {
      this[this.tableOpenReceivables.FinanceCompanyGuidColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsRemitterGuidNull() => this.IsNull(this.tableOpenReceivables.RemitterGuidColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetRemitterGuidNull()
    {
      this[this.tableOpenReceivables.RemitterGuidColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsCostCenterIdNull() => this.IsNull(this.tableOpenReceivables.CostCenterIdColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetCostCenterIdNull()
    {
      this[this.tableOpenReceivables.CostCenterIdColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsARAppliedNull() => this.IsNull(this.tableOpenReceivables.ARAppliedColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetARAppliedNull()
    {
      this[this.tableOpenReceivables.ARAppliedColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsExchAppliedNull() => this.IsNull(this.tableOpenReceivables.ExchAppliedColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetExchAppliedNull()
    {
      this[this.tableOpenReceivables.ExchAppliedColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsUnAcctAppliedNull() => this.IsNull(this.tableOpenReceivables.UnAcctAppliedColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetUnAcctAppliedNull()
    {
      this[this.tableOpenReceivables.UnAcctAppliedColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsLOBNull() => this.IsNull(this.tableOpenReceivables.LOBColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetLOBNull()
    {
      this[this.tableOpenReceivables.LOBColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsEndorsement_EffectiveNull()
    {
      return this.IsNull(this.tableOpenReceivables.Endorsement_EffectiveColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetEndorsement_EffectiveNull()
    {
      this[this.tableOpenReceivables.Endorsement_EffectiveColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsCurrencyCodeNull() => this.IsNull(this.tableOpenReceivables.CurrencyCodeColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetCurrencyCodeNull()
    {
      this[this.tableOpenReceivables.CurrencyCodeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsCurrencyCode_FunctionalNull()
    {
      return this.IsNull(this.tableOpenReceivables.CurrencyCode_FunctionalColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetCurrencyCode_FunctionalNull()
    {
      this[this.tableOpenReceivables.CurrencyCode_FunctionalColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsCurrencyCode_ReportingNull()
    {
      return this.IsNull(this.tableOpenReceivables.CurrencyCode_ReportingColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetCurrencyCode_ReportingNull()
    {
      this[this.tableOpenReceivables.CurrencyCode_ReportingColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsConvRate_FunctionalNull()
    {
      return this.IsNull(this.tableOpenReceivables.ConvRate_FunctionalColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetConvRate_FunctionalNull()
    {
      this[this.tableOpenReceivables.ConvRate_FunctionalColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsConvRate_ReportingNull()
    {
      return this.IsNull(this.tableOpenReceivables.ConvRate_ReportingColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetConvRate_ReportingNull()
    {
      this[this.tableOpenReceivables.ConvRate_ReportingColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsProducerNull() => this.IsNull(this.tableOpenReceivables.ProducerColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetProducerNull()
    {
      this[this.tableOpenReceivables.ProducerColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class OpenReceivablesRowChangeEvent : EventArgs
  {
    private dsOpenReceivables.OpenReceivablesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public OpenReceivablesRowChangeEvent(
      dsOpenReceivables.OpenReceivablesRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsOpenReceivables.OpenReceivablesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }
}
