// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.dsTransDateInstallment
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
[XmlRoot("dsTransDateInstallment")]
[HelpKeyword("vs.data.DataSet")]
[Serializable]
public class dsTransDateInstallment : DataSet
{
  private dsTransDateInstallment.tblCompanyLineInstallmentsTransDateDataTable tabletblCompanyLineInstallmentsTransDate;
  private dsTransDateInstallment.tblCompanyBillingTypesDataTable tabletblCompanyBillingTypes;
  private SchemaSerializationMode _schemaSerializationMode;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public dsTransDateInstallment()
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
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  protected dsTransDateInstallment(SerializationInfo info, StreamingContext context)
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
        if (dataSet.Tables[nameof (tblCompanyLineInstallmentsTransDate)] != null)
          base.Tables.Add((DataTable) new dsTransDateInstallment.tblCompanyLineInstallmentsTransDateDataTable(dataSet.Tables[nameof (tblCompanyLineInstallmentsTransDate)]));
        if (dataSet.Tables[nameof (tblCompanyBillingTypes)] != null)
          base.Tables.Add((DataTable) new dsTransDateInstallment.tblCompanyBillingTypesDataTable(dataSet.Tables[nameof (tblCompanyBillingTypes)]));
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
  public dsTransDateInstallment.tblCompanyLineInstallmentsTransDateDataTable tblCompanyLineInstallmentsTransDate
  {
    get => this.tabletblCompanyLineInstallmentsTransDate;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsTransDateInstallment.tblCompanyBillingTypesDataTable tblCompanyBillingTypes
  {
    get => this.tabletblCompanyBillingTypes;
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
    dsTransDateInstallment transDateInstallment = (dsTransDateInstallment) base.Clone();
    transDateInstallment.InitVars();
    transDateInstallment.SchemaSerializationMode = this.SchemaSerializationMode;
    return (DataSet) transDateInstallment;
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
      if (dataSet.Tables["tblCompanyLineInstallmentsTransDate"] != null)
        base.Tables.Add((DataTable) new dsTransDateInstallment.tblCompanyLineInstallmentsTransDateDataTable(dataSet.Tables["tblCompanyLineInstallmentsTransDate"]));
      if (dataSet.Tables["tblCompanyBillingTypes"] != null)
        base.Tables.Add((DataTable) new dsTransDateInstallment.tblCompanyBillingTypesDataTable(dataSet.Tables["tblCompanyBillingTypes"]));
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
    this.tabletblCompanyLineInstallmentsTransDate = (dsTransDateInstallment.tblCompanyLineInstallmentsTransDateDataTable) base.Tables["tblCompanyLineInstallmentsTransDate"];
    if (initTable && this.tabletblCompanyLineInstallmentsTransDate != null)
      this.tabletblCompanyLineInstallmentsTransDate.InitVars();
    this.tabletblCompanyBillingTypes = (dsTransDateInstallment.tblCompanyBillingTypesDataTable) base.Tables["tblCompanyBillingTypes"];
    if (!initTable || this.tabletblCompanyBillingTypes == null)
      return;
    this.tabletblCompanyBillingTypes.InitVars();
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private void InitClass()
  {
    this.DataSetName = nameof (dsTransDateInstallment);
    this.Prefix = "";
    this.Namespace = "http://tempuri.org/dsTransDateInstallment.xsd";
    this.EnforceConstraints = true;
    this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.tabletblCompanyLineInstallmentsTransDate = new dsTransDateInstallment.tblCompanyLineInstallmentsTransDateDataTable();
    base.Tables.Add((DataTable) this.tabletblCompanyLineInstallmentsTransDate);
    this.tabletblCompanyBillingTypes = new dsTransDateInstallment.tblCompanyBillingTypesDataTable();
    base.Tables.Add((DataTable) this.tabletblCompanyBillingTypes);
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializetblCompanyLineInstallmentsTransDate() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializetblCompanyBillingTypes() => false;

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
    dsTransDateInstallment transDateInstallment = new dsTransDateInstallment();
    XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
    schemaComplexType.Particle = (XmlSchemaParticle) new XmlSchemaSequence()
    {
      Items = {
        (XmlSchemaObject) new XmlSchemaAny()
        {
          Namespace = transDateInstallment.Namespace
        }
      }
    };
    XmlSchema schemaSerializable = transDateInstallment.GetSchemaSerializable();
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

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public delegate void tblCompanyLineInstallmentsTransDateRowChangeEventHandler(
    object sender,
    dsTransDateInstallment.tblCompanyLineInstallmentsTransDateRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public delegate void tblCompanyBillingTypesRowChangeEventHandler(
    object sender,
    dsTransDateInstallment.tblCompanyBillingTypesRowChangeEvent e);

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class tblCompanyLineInstallmentsTransDateDataTable : 
    TypedTableBase<dsTransDateInstallment.tblCompanyLineInstallmentsTransDateRow>
  {
    private DataColumn columnID;
    private DataColumn columnInstallmentID;
    private DataColumn columnOptionName;
    private DataColumn columnDownpaymentTerm;
    private DataColumn columnNumPayments;
    private DataColumn columnInstallmentTerms;
    private DataColumn columnDownpaymentBillingTypeID;
    private DataColumn columnDownpaymentFromEffectiveDate;
    private DataColumn columnDownpaymentFromDateBilled;
    private DataColumn columnInstallmentFromEffectiveDate;
    private DataColumn columnInstallmentFromDateBilled;
    private DataColumn columnFinanced;
    private DataColumn columnDisallowAutomatedPrinting;
    private DataColumn columnDisallowAutomatedNOC;
    private DataColumn columnDisabled;
    private DataColumn columnDateBilledEqualToDueDate;
    private DataColumn columnEffectiveDateBilled;
    private DataColumn columnPolicyEffective;
    private DataColumn columnDayOfMonth;
    private DataColumn columnDayOfMonthNumber;
    private DataColumn columnPolicyEffectiveInstallmentTerm;
    private DataColumn columnDayOfMonthInstallmentTerm;
    private DataColumn columnMonthFollowingDownPayment;
    private DataColumn columnMonthFollowingDownPayment_Eff;
    private DataColumn columnMonthFollowingDownPayment_Eff_DateBilled;
    private DataColumn columnEffectiveAltFirstInstallDays;
    private DataColumn columnEffDateBilledAltFirstInstallDays;
    private DataColumn columnUseMonth;
    private DataColumn columnDayOfMonthAltFirstInstallDays;
    private DataColumn columnSinglePay;
    private DataColumn columnBillingDateDaysFromDueDate;
    private DataColumn columnUseEffectiveDateForBilling;
    private DataColumn columnDownPaymentGAAP;
    private DataColumn columnUseMonthForAltFirstInstallment;
    private DataColumn columnDownPaymentUsingBusinessDays;
    private DataColumn columnPolicyExpiration;
    private DataColumn columnExpirationAltFirstInstallDays;
    private DataColumn columnMonthFollowingDownPayment_Exp;
    private DataColumn columnPolicyExpirationInstallmentTerm;
    private DataColumn columnDownpaymentFromExpirationDate;
    private DataColumn columnDownPaymentFromEffEndMonth;
    private DataColumn columnDownPaymentDayofMonth;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public tblCompanyLineInstallmentsTransDateDataTable()
    {
      this.TableName = "tblCompanyLineInstallmentsTransDate";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal tblCompanyLineInstallmentsTransDateDataTable(DataTable table)
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected tblCompanyLineInstallmentsTransDateDataTable(
      SerializationInfo info,
      StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn IDColumn => this.columnID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn InstallmentIDColumn => this.columnInstallmentID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn OptionNameColumn => this.columnOptionName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn DownpaymentTermColumn => this.columnDownpaymentTerm;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn NumPaymentsColumn => this.columnNumPayments;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn InstallmentTermsColumn => this.columnInstallmentTerms;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn DownpaymentBillingTypeIDColumn => this.columnDownpaymentBillingTypeID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn DownpaymentFromEffectiveDateColumn => this.columnDownpaymentFromEffectiveDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn DownpaymentFromDateBilledColumn => this.columnDownpaymentFromDateBilled;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn InstallmentFromEffectiveDateColumn => this.columnInstallmentFromEffectiveDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn InstallmentFromDateBilledColumn => this.columnInstallmentFromDateBilled;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn FinancedColumn => this.columnFinanced;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn DisallowAutomatedPrintingColumn => this.columnDisallowAutomatedPrinting;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn DisallowAutomatedNOCColumn => this.columnDisallowAutomatedNOC;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn DisabledColumn => this.columnDisabled;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn DateBilledEqualToDueDateColumn => this.columnDateBilledEqualToDueDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn EffectiveDateBilledColumn => this.columnEffectiveDateBilled;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn PolicyEffectiveColumn => this.columnPolicyEffective;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn DayOfMonthColumn => this.columnDayOfMonth;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn DayOfMonthNumberColumn => this.columnDayOfMonthNumber;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn PolicyEffectiveInstallmentTermColumn
    {
      get => this.columnPolicyEffectiveInstallmentTerm;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn DayOfMonthInstallmentTermColumn => this.columnDayOfMonthInstallmentTerm;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn MonthFollowingDownPaymentColumn => this.columnMonthFollowingDownPayment;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn MonthFollowingDownPayment_EffColumn
    {
      get => this.columnMonthFollowingDownPayment_Eff;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn MonthFollowingDownPayment_Eff_DateBilledColumn
    {
      get => this.columnMonthFollowingDownPayment_Eff_DateBilled;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn EffectiveAltFirstInstallDaysColumn => this.columnEffectiveAltFirstInstallDays;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn EffDateBilledAltFirstInstallDaysColumn
    {
      get => this.columnEffDateBilledAltFirstInstallDays;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn UseMonthColumn => this.columnUseMonth;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn DayOfMonthAltFirstInstallDaysColumn
    {
      get => this.columnDayOfMonthAltFirstInstallDays;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn SinglePayColumn => this.columnSinglePay;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn BillingDateDaysFromDueDateColumn => this.columnBillingDateDaysFromDueDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn UseEffectiveDateForBillingColumn => this.columnUseEffectiveDateForBilling;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn DownPaymentGAAPColumn => this.columnDownPaymentGAAP;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn UseMonthForAltFirstInstallmentColumn
    {
      get => this.columnUseMonthForAltFirstInstallment;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn DownPaymentUsingBusinessDaysColumn => this.columnDownPaymentUsingBusinessDays;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn PolicyExpirationColumn => this.columnPolicyExpiration;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ExpirationAltFirstInstallDaysColumn
    {
      get => this.columnExpirationAltFirstInstallDays;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn MonthFollowingDownPayment_ExpColumn
    {
      get => this.columnMonthFollowingDownPayment_Exp;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn PolicyExpirationInstallmentTermColumn
    {
      get => this.columnPolicyExpirationInstallmentTerm;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn DownpaymentFromExpirationDateColumn
    {
      get => this.columnDownpaymentFromExpirationDate;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn DownPaymentFromEffEndMonthColumn => this.columnDownPaymentFromEffEndMonth;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn DownPaymentDayofMonthColumn => this.columnDownPaymentDayofMonth;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsTransDateInstallment.tblCompanyLineInstallmentsTransDateRow this[int index]
    {
      get => (dsTransDateInstallment.tblCompanyLineInstallmentsTransDateRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsTransDateInstallment.tblCompanyLineInstallmentsTransDateRowChangeEventHandler tblCompanyLineInstallmentsTransDateRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsTransDateInstallment.tblCompanyLineInstallmentsTransDateRowChangeEventHandler tblCompanyLineInstallmentsTransDateRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsTransDateInstallment.tblCompanyLineInstallmentsTransDateRowChangeEventHandler tblCompanyLineInstallmentsTransDateRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsTransDateInstallment.tblCompanyLineInstallmentsTransDateRowChangeEventHandler tblCompanyLineInstallmentsTransDateRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AddtblCompanyLineInstallmentsTransDateRow(
      dsTransDateInstallment.tblCompanyLineInstallmentsTransDateRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsTransDateInstallment.tblCompanyLineInstallmentsTransDateRow AddtblCompanyLineInstallmentsTransDateRow(
      int InstallmentID,
      string OptionName,
      int DownpaymentTerm,
      int NumPayments,
      int InstallmentTerms,
      int DownpaymentBillingTypeID,
      bool DownpaymentFromEffectiveDate,
      bool DownpaymentFromDateBilled,
      bool InstallmentFromEffectiveDate,
      bool InstallmentFromDateBilled,
      bool Financed,
      bool DisallowAutomatedPrinting,
      bool DisallowAutomatedNOC,
      bool Disabled,
      bool DateBilledEqualToDueDate,
      bool EffectiveDateBilled,
      bool PolicyEffective,
      bool DayOfMonth,
      byte DayOfMonthNumber,
      int PolicyEffectiveInstallmentTerm,
      int DayOfMonthInstallmentTerm,
      bool MonthFollowingDownPayment,
      bool MonthFollowingDownPayment_Eff,
      bool MonthFollowingDownPayment_Eff_DateBilled,
      int EffectiveAltFirstInstallDays,
      int EffDateBilledAltFirstInstallDays,
      bool UseMonth,
      int DayOfMonthAltFirstInstallDays,
      bool SinglePay,
      int BillingDateDaysFromDueDate,
      bool UseEffectiveDateForBilling,
      bool DownPaymentGAAP,
      bool UseMonthForAltFirstInstallment,
      bool DownPaymentUsingBusinessDays,
      bool PolicyExpiration,
      int ExpirationAltFirstInstallDays,
      bool MonthFollowingDownPayment_Exp,
      int PolicyExpirationInstallmentTerm,
      bool DownpaymentFromExpirationDate,
      bool DownPaymentFromEffEndMonth,
      int DownPaymentDayofMonth)
    {
      dsTransDateInstallment.tblCompanyLineInstallmentsTransDateRow row = (dsTransDateInstallment.tblCompanyLineInstallmentsTransDateRow) this.NewRow();
      object[] objArray = new object[42]
      {
        null,
        (object) InstallmentID,
        (object) OptionName,
        (object) DownpaymentTerm,
        (object) NumPayments,
        (object) InstallmentTerms,
        (object) DownpaymentBillingTypeID,
        (object) DownpaymentFromEffectiveDate,
        (object) DownpaymentFromDateBilled,
        (object) InstallmentFromEffectiveDate,
        (object) InstallmentFromDateBilled,
        (object) Financed,
        (object) DisallowAutomatedPrinting,
        (object) DisallowAutomatedNOC,
        (object) Disabled,
        (object) DateBilledEqualToDueDate,
        (object) EffectiveDateBilled,
        (object) PolicyEffective,
        (object) DayOfMonth,
        (object) DayOfMonthNumber,
        (object) PolicyEffectiveInstallmentTerm,
        (object) DayOfMonthInstallmentTerm,
        (object) MonthFollowingDownPayment,
        (object) MonthFollowingDownPayment_Eff,
        (object) MonthFollowingDownPayment_Eff_DateBilled,
        (object) EffectiveAltFirstInstallDays,
        (object) EffDateBilledAltFirstInstallDays,
        (object) UseMonth,
        (object) DayOfMonthAltFirstInstallDays,
        (object) SinglePay,
        (object) BillingDateDaysFromDueDate,
        (object) UseEffectiveDateForBilling,
        (object) DownPaymentGAAP,
        (object) UseMonthForAltFirstInstallment,
        (object) DownPaymentUsingBusinessDays,
        (object) PolicyExpiration,
        (object) ExpirationAltFirstInstallDays,
        (object) MonthFollowingDownPayment_Exp,
        (object) PolicyExpirationInstallmentTerm,
        (object) DownpaymentFromExpirationDate,
        (object) DownPaymentFromEffEndMonth,
        (object) DownPaymentDayofMonth
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsTransDateInstallment.tblCompanyLineInstallmentsTransDateRow FindByID(int ID)
    {
      return (dsTransDateInstallment.tblCompanyLineInstallmentsTransDateRow) this.Rows.Find(new object[1]
      {
        (object) ID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsTransDateInstallment.tblCompanyLineInstallmentsTransDateDataTable transDateDataTable = (dsTransDateInstallment.tblCompanyLineInstallmentsTransDateDataTable) base.Clone();
      transDateDataTable.InitVars();
      return (DataTable) transDateDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsTransDateInstallment.tblCompanyLineInstallmentsTransDateDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal void InitVars()
    {
      this.columnID = this.Columns["ID"];
      this.columnInstallmentID = this.Columns["InstallmentID"];
      this.columnOptionName = this.Columns["OptionName"];
      this.columnDownpaymentTerm = this.Columns["DownpaymentTerm"];
      this.columnNumPayments = this.Columns["NumPayments"];
      this.columnInstallmentTerms = this.Columns["InstallmentTerms"];
      this.columnDownpaymentBillingTypeID = this.Columns["DownpaymentBillingTypeID"];
      this.columnDownpaymentFromEffectiveDate = this.Columns["DownpaymentFromEffectiveDate"];
      this.columnDownpaymentFromDateBilled = this.Columns["DownpaymentFromDateBilled"];
      this.columnInstallmentFromEffectiveDate = this.Columns["InstallmentFromEffectiveDate"];
      this.columnInstallmentFromDateBilled = this.Columns["InstallmentFromDateBilled"];
      this.columnFinanced = this.Columns["Financed"];
      this.columnDisallowAutomatedPrinting = this.Columns["DisallowAutomatedPrinting"];
      this.columnDisallowAutomatedNOC = this.Columns["DisallowAutomatedNOC"];
      this.columnDisabled = this.Columns["Disabled"];
      this.columnDateBilledEqualToDueDate = this.Columns["DateBilledEqualToDueDate"];
      this.columnEffectiveDateBilled = this.Columns["EffectiveDateBilled"];
      this.columnPolicyEffective = this.Columns["PolicyEffective"];
      this.columnDayOfMonth = this.Columns["DayOfMonth"];
      this.columnDayOfMonthNumber = this.Columns["DayOfMonthNumber"];
      this.columnPolicyEffectiveInstallmentTerm = this.Columns["PolicyEffectiveInstallmentTerm"];
      this.columnDayOfMonthInstallmentTerm = this.Columns["DayOfMonthInstallmentTerm"];
      this.columnMonthFollowingDownPayment = this.Columns["MonthFollowingDownPayment"];
      this.columnMonthFollowingDownPayment_Eff = this.Columns["MonthFollowingDownPayment_Eff"];
      this.columnMonthFollowingDownPayment_Eff_DateBilled = this.Columns["MonthFollowingDownPayment_Eff_DateBilled"];
      this.columnEffectiveAltFirstInstallDays = this.Columns["EffectiveAltFirstInstallDays"];
      this.columnEffDateBilledAltFirstInstallDays = this.Columns["EffDateBilledAltFirstInstallDays"];
      this.columnUseMonth = this.Columns["UseMonth"];
      this.columnDayOfMonthAltFirstInstallDays = this.Columns["DayOfMonthAltFirstInstallDays"];
      this.columnSinglePay = this.Columns["SinglePay"];
      this.columnBillingDateDaysFromDueDate = this.Columns["BillingDateDaysFromDueDate"];
      this.columnUseEffectiveDateForBilling = this.Columns["UseEffectiveDateForBilling"];
      this.columnDownPaymentGAAP = this.Columns["DownPaymentGAAP"];
      this.columnUseMonthForAltFirstInstallment = this.Columns["UseMonthForAltFirstInstallment"];
      this.columnDownPaymentUsingBusinessDays = this.Columns["DownPaymentUsingBusinessDays"];
      this.columnPolicyExpiration = this.Columns["PolicyExpiration"];
      this.columnExpirationAltFirstInstallDays = this.Columns["ExpirationAltFirstInstallDays"];
      this.columnMonthFollowingDownPayment_Exp = this.Columns["MonthFollowingDownPayment_Exp"];
      this.columnPolicyExpirationInstallmentTerm = this.Columns["PolicyExpirationInstallmentTerm"];
      this.columnDownpaymentFromExpirationDate = this.Columns["DownpaymentFromExpirationDate"];
      this.columnDownPaymentFromEffEndMonth = this.Columns["DownPaymentFromEffEndMonth"];
      this.columnDownPaymentDayofMonth = this.Columns["DownPaymentDayofMonth"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.columnID = new DataColumn("ID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnID);
      this.columnInstallmentID = new DataColumn("InstallmentID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInstallmentID);
      this.columnOptionName = new DataColumn("OptionName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnOptionName);
      this.columnDownpaymentTerm = new DataColumn("DownpaymentTerm", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDownpaymentTerm);
      this.columnNumPayments = new DataColumn("NumPayments", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnNumPayments);
      this.columnInstallmentTerms = new DataColumn("InstallmentTerms", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInstallmentTerms);
      this.columnDownpaymentBillingTypeID = new DataColumn("DownpaymentBillingTypeID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDownpaymentBillingTypeID);
      this.columnDownpaymentFromEffectiveDate = new DataColumn("DownpaymentFromEffectiveDate", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDownpaymentFromEffectiveDate);
      this.columnDownpaymentFromDateBilled = new DataColumn("DownpaymentFromDateBilled", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDownpaymentFromDateBilled);
      this.columnInstallmentFromEffectiveDate = new DataColumn("InstallmentFromEffectiveDate", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInstallmentFromEffectiveDate);
      this.columnInstallmentFromDateBilled = new DataColumn("InstallmentFromDateBilled", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInstallmentFromDateBilled);
      this.columnFinanced = new DataColumn("Financed", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFinanced);
      this.columnDisallowAutomatedPrinting = new DataColumn("DisallowAutomatedPrinting", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDisallowAutomatedPrinting);
      this.columnDisallowAutomatedNOC = new DataColumn("DisallowAutomatedNOC", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDisallowAutomatedNOC);
      this.columnDisabled = new DataColumn("Disabled", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDisabled);
      this.columnDateBilledEqualToDueDate = new DataColumn("DateBilledEqualToDueDate", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDateBilledEqualToDueDate);
      this.columnEffectiveDateBilled = new DataColumn("EffectiveDateBilled", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEffectiveDateBilled);
      this.columnPolicyEffective = new DataColumn("PolicyEffective", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPolicyEffective);
      this.columnDayOfMonth = new DataColumn("DayOfMonth", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDayOfMonth);
      this.columnDayOfMonthNumber = new DataColumn("DayOfMonthNumber", typeof (byte), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDayOfMonthNumber);
      this.columnPolicyEffectiveInstallmentTerm = new DataColumn("PolicyEffectiveInstallmentTerm", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPolicyEffectiveInstallmentTerm);
      this.columnDayOfMonthInstallmentTerm = new DataColumn("DayOfMonthInstallmentTerm", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDayOfMonthInstallmentTerm);
      this.columnMonthFollowingDownPayment = new DataColumn("MonthFollowingDownPayment", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnMonthFollowingDownPayment);
      this.columnMonthFollowingDownPayment_Eff = new DataColumn("MonthFollowingDownPayment_Eff", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnMonthFollowingDownPayment_Eff);
      this.columnMonthFollowingDownPayment_Eff_DateBilled = new DataColumn("MonthFollowingDownPayment_Eff_DateBilled", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnMonthFollowingDownPayment_Eff_DateBilled);
      this.columnEffectiveAltFirstInstallDays = new DataColumn("EffectiveAltFirstInstallDays", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEffectiveAltFirstInstallDays);
      this.columnEffDateBilledAltFirstInstallDays = new DataColumn("EffDateBilledAltFirstInstallDays", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEffDateBilledAltFirstInstallDays);
      this.columnUseMonth = new DataColumn("UseMonth", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnUseMonth);
      this.columnDayOfMonthAltFirstInstallDays = new DataColumn("DayOfMonthAltFirstInstallDays", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDayOfMonthAltFirstInstallDays);
      this.columnSinglePay = new DataColumn("SinglePay", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSinglePay);
      this.columnBillingDateDaysFromDueDate = new DataColumn("BillingDateDaysFromDueDate", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnBillingDateDaysFromDueDate);
      this.columnUseEffectiveDateForBilling = new DataColumn("UseEffectiveDateForBilling", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnUseEffectiveDateForBilling);
      this.columnDownPaymentGAAP = new DataColumn("DownPaymentGAAP", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDownPaymentGAAP);
      this.columnUseMonthForAltFirstInstallment = new DataColumn("UseMonthForAltFirstInstallment", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnUseMonthForAltFirstInstallment);
      this.columnDownPaymentUsingBusinessDays = new DataColumn("DownPaymentUsingBusinessDays", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDownPaymentUsingBusinessDays);
      this.columnPolicyExpiration = new DataColumn("PolicyExpiration", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPolicyExpiration);
      this.columnExpirationAltFirstInstallDays = new DataColumn("ExpirationAltFirstInstallDays", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnExpirationAltFirstInstallDays);
      this.columnMonthFollowingDownPayment_Exp = new DataColumn("MonthFollowingDownPayment_Exp", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnMonthFollowingDownPayment_Exp);
      this.columnPolicyExpirationInstallmentTerm = new DataColumn("PolicyExpirationInstallmentTerm", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPolicyExpirationInstallmentTerm);
      this.columnDownpaymentFromExpirationDate = new DataColumn("DownpaymentFromExpirationDate", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDownpaymentFromExpirationDate);
      this.columnDownPaymentFromEffEndMonth = new DataColumn("DownPaymentFromEffEndMonth", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDownPaymentFromEffEndMonth);
      this.columnDownPaymentDayofMonth = new DataColumn("DownPaymentDayofMonth", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDownPaymentDayofMonth);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnID
      }, true));
      this.columnID.AutoIncrement = true;
      this.columnID.AllowDBNull = false;
      this.columnID.ReadOnly = true;
      this.columnID.Unique = true;
      this.columnInstallmentID.AllowDBNull = false;
      this.columnNumPayments.AllowDBNull = false;
      this.columnDownpaymentFromEffectiveDate.AllowDBNull = false;
      this.columnDownpaymentFromEffectiveDate.DefaultValue = (object) true;
      this.columnDownpaymentFromDateBilled.AllowDBNull = false;
      this.columnDownpaymentFromDateBilled.DefaultValue = (object) false;
      this.columnInstallmentFromEffectiveDate.AllowDBNull = false;
      this.columnInstallmentFromEffectiveDate.DefaultValue = (object) true;
      this.columnInstallmentFromDateBilled.AllowDBNull = false;
      this.columnInstallmentFromDateBilled.DefaultValue = (object) false;
      this.columnFinanced.AllowDBNull = false;
      this.columnFinanced.DefaultValue = (object) false;
      this.columnDisallowAutomatedPrinting.AllowDBNull = false;
      this.columnDisallowAutomatedPrinting.DefaultValue = (object) false;
      this.columnDisallowAutomatedNOC.AllowDBNull = false;
      this.columnDisallowAutomatedNOC.DefaultValue = (object) false;
      this.columnDisabled.DefaultValue = (object) false;
      this.columnDateBilledEqualToDueDate.AllowDBNull = false;
      this.columnDateBilledEqualToDueDate.DefaultValue = (object) false;
      this.columnEffectiveDateBilled.AllowDBNull = false;
      this.columnEffectiveDateBilled.DefaultValue = (object) false;
      this.columnPolicyEffective.AllowDBNull = false;
      this.columnPolicyEffective.DefaultValue = (object) false;
      this.columnDayOfMonth.AllowDBNull = false;
      this.columnDayOfMonth.DefaultValue = (object) false;
      this.columnMonthFollowingDownPayment.DefaultValue = (object) false;
      this.columnMonthFollowingDownPayment_Eff.DefaultValue = (object) false;
      this.columnMonthFollowingDownPayment_Eff_DateBilled.DefaultValue = (object) false;
      this.columnSinglePay.DefaultValue = (object) false;
      this.columnUseEffectiveDateForBilling.AllowDBNull = false;
      this.columnUseEffectiveDateForBilling.DefaultValue = (object) false;
      this.columnDownPaymentGAAP.DefaultValue = (object) false;
      this.columnUseMonthForAltFirstInstallment.DefaultValue = (object) false;
      this.columnDownPaymentUsingBusinessDays.DefaultValue = (object) false;
      this.columnPolicyExpiration.DefaultValue = (object) false;
      this.columnMonthFollowingDownPayment_Exp.DefaultValue = (object) false;
      this.columnDownpaymentFromExpirationDate.DefaultValue = (object) false;
      this.columnDownPaymentFromEffEndMonth.AllowDBNull = false;
      this.columnDownPaymentFromEffEndMonth.DefaultValue = (object) false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsTransDateInstallment.tblCompanyLineInstallmentsTransDateRow NewtblCompanyLineInstallmentsTransDateRow()
    {
      return (dsTransDateInstallment.tblCompanyLineInstallmentsTransDateRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsTransDateInstallment.tblCompanyLineInstallmentsTransDateRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType()
    {
      return typeof (dsTransDateInstallment.tblCompanyLineInstallmentsTransDateRow);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyLineInstallmentsTransDateRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsTransDateInstallment.tblCompanyLineInstallmentsTransDateRowChangeEventHandler dateRowChangedEvent = this.tblCompanyLineInstallmentsTransDateRowChangedEvent;
      if (dateRowChangedEvent == null)
        return;
      dateRowChangedEvent((object) this, new dsTransDateInstallment.tblCompanyLineInstallmentsTransDateRowChangeEvent((dsTransDateInstallment.tblCompanyLineInstallmentsTransDateRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyLineInstallmentsTransDateRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsTransDateInstallment.tblCompanyLineInstallmentsTransDateRowChangeEventHandler rowChangingEvent = this.tblCompanyLineInstallmentsTransDateRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsTransDateInstallment.tblCompanyLineInstallmentsTransDateRowChangeEvent((dsTransDateInstallment.tblCompanyLineInstallmentsTransDateRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyLineInstallmentsTransDateRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsTransDateInstallment.tblCompanyLineInstallmentsTransDateRowChangeEventHandler dateRowDeletedEvent = this.tblCompanyLineInstallmentsTransDateRowDeletedEvent;
      if (dateRowDeletedEvent == null)
        return;
      dateRowDeletedEvent((object) this, new dsTransDateInstallment.tblCompanyLineInstallmentsTransDateRowChangeEvent((dsTransDateInstallment.tblCompanyLineInstallmentsTransDateRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyLineInstallmentsTransDateRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsTransDateInstallment.tblCompanyLineInstallmentsTransDateRowChangeEventHandler rowDeletingEvent = this.tblCompanyLineInstallmentsTransDateRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsTransDateInstallment.tblCompanyLineInstallmentsTransDateRowChangeEvent((dsTransDateInstallment.tblCompanyLineInstallmentsTransDateRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemovetblCompanyLineInstallmentsTransDateRow(
      dsTransDateInstallment.tblCompanyLineInstallmentsTransDateRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsTransDateInstallment transDateInstallment = new dsTransDateInstallment();
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
        FixedValue = transDateInstallment.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblCompanyLineInstallmentsTransDateDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = transDateInstallment.GetSchemaSerializable();
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
  public class tblCompanyBillingTypesDataTable : 
    TypedTableBase<dsTransDateInstallment.tblCompanyBillingTypesRow>
  {
    private DataColumn columnBillingTypeID;
    private DataColumn columnBillingType;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public tblCompanyBillingTypesDataTable()
    {
      this.TableName = "tblCompanyBillingTypes";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal tblCompanyBillingTypesDataTable(DataTable table)
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected tblCompanyBillingTypesDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn BillingTypeIDColumn => this.columnBillingTypeID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn BillingTypeColumn => this.columnBillingType;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsTransDateInstallment.tblCompanyBillingTypesRow this[int index]
    {
      get => (dsTransDateInstallment.tblCompanyBillingTypesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsTransDateInstallment.tblCompanyBillingTypesRowChangeEventHandler tblCompanyBillingTypesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsTransDateInstallment.tblCompanyBillingTypesRowChangeEventHandler tblCompanyBillingTypesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsTransDateInstallment.tblCompanyBillingTypesRowChangeEventHandler tblCompanyBillingTypesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsTransDateInstallment.tblCompanyBillingTypesRowChangeEventHandler tblCompanyBillingTypesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AddtblCompanyBillingTypesRow(
      dsTransDateInstallment.tblCompanyBillingTypesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsTransDateInstallment.tblCompanyBillingTypesRow AddtblCompanyBillingTypesRow(
      int BillingTypeID,
      string BillingType)
    {
      dsTransDateInstallment.tblCompanyBillingTypesRow row = (dsTransDateInstallment.tblCompanyBillingTypesRow) this.NewRow();
      object[] objArray = new object[2]
      {
        (object) BillingTypeID,
        (object) BillingType
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsTransDateInstallment.tblCompanyBillingTypesRow FindByBillingTypeID(int BillingTypeID)
    {
      return (dsTransDateInstallment.tblCompanyBillingTypesRow) this.Rows.Find(new object[1]
      {
        (object) BillingTypeID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsTransDateInstallment.tblCompanyBillingTypesDataTable billingTypesDataTable = (dsTransDateInstallment.tblCompanyBillingTypesDataTable) base.Clone();
      billingTypesDataTable.InitVars();
      return (DataTable) billingTypesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsTransDateInstallment.tblCompanyBillingTypesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal void InitVars()
    {
      this.columnBillingTypeID = this.Columns["BillingTypeID"];
      this.columnBillingType = this.Columns["BillingType"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.columnBillingTypeID = new DataColumn("BillingTypeID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnBillingTypeID);
      this.columnBillingType = new DataColumn("BillingType", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnBillingType);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsCompanyInstallmentsKey1", new DataColumn[1]
      {
        this.columnBillingTypeID
      }, true));
      this.columnBillingTypeID.AllowDBNull = false;
      this.columnBillingTypeID.Unique = true;
      this.columnBillingType.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsTransDateInstallment.tblCompanyBillingTypesRow NewtblCompanyBillingTypesRow()
    {
      return (dsTransDateInstallment.tblCompanyBillingTypesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsTransDateInstallment.tblCompanyBillingTypesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType()
    {
      return typeof (dsTransDateInstallment.tblCompanyBillingTypesRow);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyBillingTypesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsTransDateInstallment.tblCompanyBillingTypesRowChangeEventHandler typesRowChangedEvent = this.tblCompanyBillingTypesRowChangedEvent;
      if (typesRowChangedEvent == null)
        return;
      typesRowChangedEvent((object) this, new dsTransDateInstallment.tblCompanyBillingTypesRowChangeEvent((dsTransDateInstallment.tblCompanyBillingTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyBillingTypesRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsTransDateInstallment.tblCompanyBillingTypesRowChangeEventHandler rowChangingEvent = this.tblCompanyBillingTypesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsTransDateInstallment.tblCompanyBillingTypesRowChangeEvent((dsTransDateInstallment.tblCompanyBillingTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyBillingTypesRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsTransDateInstallment.tblCompanyBillingTypesRowChangeEventHandler typesRowDeletedEvent = this.tblCompanyBillingTypesRowDeletedEvent;
      if (typesRowDeletedEvent == null)
        return;
      typesRowDeletedEvent((object) this, new dsTransDateInstallment.tblCompanyBillingTypesRowChangeEvent((dsTransDateInstallment.tblCompanyBillingTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyBillingTypesRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsTransDateInstallment.tblCompanyBillingTypesRowChangeEventHandler rowDeletingEvent = this.tblCompanyBillingTypesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsTransDateInstallment.tblCompanyBillingTypesRowChangeEvent((dsTransDateInstallment.tblCompanyBillingTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemovetblCompanyBillingTypesRow(
      dsTransDateInstallment.tblCompanyBillingTypesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsTransDateInstallment transDateInstallment = new dsTransDateInstallment();
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
        FixedValue = transDateInstallment.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblCompanyBillingTypesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = transDateInstallment.GetSchemaSerializable();
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

  public class tblCompanyLineInstallmentsTransDateRow : DataRow
  {
    private dsTransDateInstallment.tblCompanyLineInstallmentsTransDateDataTable tabletblCompanyLineInstallmentsTransDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal tblCompanyLineInstallmentsTransDateRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblCompanyLineInstallmentsTransDate = (dsTransDateInstallment.tblCompanyLineInstallmentsTransDateDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int ID
    {
      get => Conversions.ToInteger(this[this.tabletblCompanyLineInstallmentsTransDate.IDColumn]);
      set => this[this.tabletblCompanyLineInstallmentsTransDate.IDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int InstallmentID
    {
      get
      {
        return Conversions.ToInteger(this[this.tabletblCompanyLineInstallmentsTransDate.InstallmentIDColumn]);
      }
      set
      {
        this[this.tabletblCompanyLineInstallmentsTransDate.InstallmentIDColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string OptionName
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblCompanyLineInstallmentsTransDate.OptionNameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'OptionName' in table 'tblCompanyLineInstallmentsTransDate' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanyLineInstallmentsTransDate.OptionNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int DownpaymentTerm
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblCompanyLineInstallmentsTransDate.DownpaymentTermColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DownpaymentTerm' in table 'tblCompanyLineInstallmentsTransDate' is DBNull.", (Exception) ex);
        }
      }
      set
      {
        this[this.tabletblCompanyLineInstallmentsTransDate.DownpaymentTermColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int NumPayments
    {
      get
      {
        return Conversions.ToInteger(this[this.tabletblCompanyLineInstallmentsTransDate.NumPaymentsColumn]);
      }
      set => this[this.tabletblCompanyLineInstallmentsTransDate.NumPaymentsColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int InstallmentTerms
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblCompanyLineInstallmentsTransDate.InstallmentTermsColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'InstallmentTerms' in table 'tblCompanyLineInstallmentsTransDate' is DBNull.", (Exception) ex);
        }
      }
      set
      {
        this[this.tabletblCompanyLineInstallmentsTransDate.InstallmentTermsColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int DownpaymentBillingTypeID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblCompanyLineInstallmentsTransDate.DownpaymentBillingTypeIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DownpaymentBillingTypeID' in table 'tblCompanyLineInstallmentsTransDate' is DBNull.", (Exception) ex);
        }
      }
      set
      {
        this[this.tabletblCompanyLineInstallmentsTransDate.DownpaymentBillingTypeIDColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool DownpaymentFromEffectiveDate
    {
      get
      {
        return Conversions.ToBoolean(this[this.tabletblCompanyLineInstallmentsTransDate.DownpaymentFromEffectiveDateColumn]);
      }
      set
      {
        this[this.tabletblCompanyLineInstallmentsTransDate.DownpaymentFromEffectiveDateColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool DownpaymentFromDateBilled
    {
      get
      {
        return Conversions.ToBoolean(this[this.tabletblCompanyLineInstallmentsTransDate.DownpaymentFromDateBilledColumn]);
      }
      set
      {
        this[this.tabletblCompanyLineInstallmentsTransDate.DownpaymentFromDateBilledColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool InstallmentFromEffectiveDate
    {
      get
      {
        return Conversions.ToBoolean(this[this.tabletblCompanyLineInstallmentsTransDate.InstallmentFromEffectiveDateColumn]);
      }
      set
      {
        this[this.tabletblCompanyLineInstallmentsTransDate.InstallmentFromEffectiveDateColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool InstallmentFromDateBilled
    {
      get
      {
        return Conversions.ToBoolean(this[this.tabletblCompanyLineInstallmentsTransDate.InstallmentFromDateBilledColumn]);
      }
      set
      {
        this[this.tabletblCompanyLineInstallmentsTransDate.InstallmentFromDateBilledColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool Financed
    {
      get
      {
        return Conversions.ToBoolean(this[this.tabletblCompanyLineInstallmentsTransDate.FinancedColumn]);
      }
      set => this[this.tabletblCompanyLineInstallmentsTransDate.FinancedColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool DisallowAutomatedPrinting
    {
      get
      {
        return Conversions.ToBoolean(this[this.tabletblCompanyLineInstallmentsTransDate.DisallowAutomatedPrintingColumn]);
      }
      set
      {
        this[this.tabletblCompanyLineInstallmentsTransDate.DisallowAutomatedPrintingColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool DisallowAutomatedNOC
    {
      get
      {
        return Conversions.ToBoolean(this[this.tabletblCompanyLineInstallmentsTransDate.DisallowAutomatedNOCColumn]);
      }
      set
      {
        this[this.tabletblCompanyLineInstallmentsTransDate.DisallowAutomatedNOCColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool Disabled
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tabletblCompanyLineInstallmentsTransDate.DisabledColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Disabled' in table 'tblCompanyLineInstallmentsTransDate' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanyLineInstallmentsTransDate.DisabledColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool DateBilledEqualToDueDate
    {
      get
      {
        return Conversions.ToBoolean(this[this.tabletblCompanyLineInstallmentsTransDate.DateBilledEqualToDueDateColumn]);
      }
      set
      {
        this[this.tabletblCompanyLineInstallmentsTransDate.DateBilledEqualToDueDateColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool EffectiveDateBilled
    {
      get
      {
        return Conversions.ToBoolean(this[this.tabletblCompanyLineInstallmentsTransDate.EffectiveDateBilledColumn]);
      }
      set
      {
        this[this.tabletblCompanyLineInstallmentsTransDate.EffectiveDateBilledColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool PolicyEffective
    {
      get
      {
        return Conversions.ToBoolean(this[this.tabletblCompanyLineInstallmentsTransDate.PolicyEffectiveColumn]);
      }
      set
      {
        this[this.tabletblCompanyLineInstallmentsTransDate.PolicyEffectiveColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool DayOfMonth
    {
      get
      {
        return Conversions.ToBoolean(this[this.tabletblCompanyLineInstallmentsTransDate.DayOfMonthColumn]);
      }
      set => this[this.tabletblCompanyLineInstallmentsTransDate.DayOfMonthColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public byte DayOfMonthNumber
    {
      get
      {
        try
        {
          return Conversions.ToByte(this[this.tabletblCompanyLineInstallmentsTransDate.DayOfMonthNumberColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DayOfMonthNumber' in table 'tblCompanyLineInstallmentsTransDate' is DBNull.", (Exception) ex);
        }
      }
      set
      {
        this[this.tabletblCompanyLineInstallmentsTransDate.DayOfMonthNumberColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int PolicyEffectiveInstallmentTerm
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblCompanyLineInstallmentsTransDate.PolicyEffectiveInstallmentTermColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'PolicyEffectiveInstallmentTerm' in table 'tblCompanyLineInstallmentsTransDate' is DBNull.", (Exception) ex);
        }
      }
      set
      {
        this[this.tabletblCompanyLineInstallmentsTransDate.PolicyEffectiveInstallmentTermColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int DayOfMonthInstallmentTerm
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblCompanyLineInstallmentsTransDate.DayOfMonthInstallmentTermColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DayOfMonthInstallmentTerm' in table 'tblCompanyLineInstallmentsTransDate' is DBNull.", (Exception) ex);
        }
      }
      set
      {
        this[this.tabletblCompanyLineInstallmentsTransDate.DayOfMonthInstallmentTermColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool MonthFollowingDownPayment
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tabletblCompanyLineInstallmentsTransDate.MonthFollowingDownPaymentColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'MonthFollowingDownPayment' in table 'tblCompanyLineInstallmentsTransDate' is DBNull.", (Exception) ex);
        }
      }
      set
      {
        this[this.tabletblCompanyLineInstallmentsTransDate.MonthFollowingDownPaymentColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool MonthFollowingDownPayment_Eff
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tabletblCompanyLineInstallmentsTransDate.MonthFollowingDownPayment_EffColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'MonthFollowingDownPayment_Eff' in table 'tblCompanyLineInstallmentsTransDate' is DBNull.", (Exception) ex);
        }
      }
      set
      {
        this[this.tabletblCompanyLineInstallmentsTransDate.MonthFollowingDownPayment_EffColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool MonthFollowingDownPayment_Eff_DateBilled
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tabletblCompanyLineInstallmentsTransDate.MonthFollowingDownPayment_Eff_DateBilledColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'MonthFollowingDownPayment_Eff_DateBilled' in table 'tblCompanyLineInstallmentsTransDate' is DBNull.", (Exception) ex);
        }
      }
      set
      {
        this[this.tabletblCompanyLineInstallmentsTransDate.MonthFollowingDownPayment_Eff_DateBilledColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int EffectiveAltFirstInstallDays
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblCompanyLineInstallmentsTransDate.EffectiveAltFirstInstallDaysColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'EffectiveAltFirstInstallDays' in table 'tblCompanyLineInstallmentsTransDate' is DBNull.", (Exception) ex);
        }
      }
      set
      {
        this[this.tabletblCompanyLineInstallmentsTransDate.EffectiveAltFirstInstallDaysColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int EffDateBilledAltFirstInstallDays
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblCompanyLineInstallmentsTransDate.EffDateBilledAltFirstInstallDaysColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'EffDateBilledAltFirstInstallDays' in table 'tblCompanyLineInstallmentsTransDate' is DBNull.", (Exception) ex);
        }
      }
      set
      {
        this[this.tabletblCompanyLineInstallmentsTransDate.EffDateBilledAltFirstInstallDaysColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool UseMonth
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tabletblCompanyLineInstallmentsTransDate.UseMonthColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'UseMonth' in table 'tblCompanyLineInstallmentsTransDate' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanyLineInstallmentsTransDate.UseMonthColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int DayOfMonthAltFirstInstallDays
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblCompanyLineInstallmentsTransDate.DayOfMonthAltFirstInstallDaysColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DayOfMonthAltFirstInstallDays' in table 'tblCompanyLineInstallmentsTransDate' is DBNull.", (Exception) ex);
        }
      }
      set
      {
        this[this.tabletblCompanyLineInstallmentsTransDate.DayOfMonthAltFirstInstallDaysColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool SinglePay
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tabletblCompanyLineInstallmentsTransDate.SinglePayColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'SinglePay' in table 'tblCompanyLineInstallmentsTransDate' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanyLineInstallmentsTransDate.SinglePayColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int BillingDateDaysFromDueDate
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblCompanyLineInstallmentsTransDate.BillingDateDaysFromDueDateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'BillingDateDaysFromDueDate' in table 'tblCompanyLineInstallmentsTransDate' is DBNull.", (Exception) ex);
        }
      }
      set
      {
        this[this.tabletblCompanyLineInstallmentsTransDate.BillingDateDaysFromDueDateColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool UseEffectiveDateForBilling
    {
      get
      {
        return Conversions.ToBoolean(this[this.tabletblCompanyLineInstallmentsTransDate.UseEffectiveDateForBillingColumn]);
      }
      set
      {
        this[this.tabletblCompanyLineInstallmentsTransDate.UseEffectiveDateForBillingColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool DownPaymentGAAP
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tabletblCompanyLineInstallmentsTransDate.DownPaymentGAAPColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DownPaymentGAAP' in table 'tblCompanyLineInstallmentsTransDate' is DBNull.", (Exception) ex);
        }
      }
      set
      {
        this[this.tabletblCompanyLineInstallmentsTransDate.DownPaymentGAAPColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool UseMonthForAltFirstInstallment
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tabletblCompanyLineInstallmentsTransDate.UseMonthForAltFirstInstallmentColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'UseMonthForAltFirstInstallment' in table 'tblCompanyLineInstallmentsTransDate' is DBNull.", (Exception) ex);
        }
      }
      set
      {
        this[this.tabletblCompanyLineInstallmentsTransDate.UseMonthForAltFirstInstallmentColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool DownPaymentUsingBusinessDays
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tabletblCompanyLineInstallmentsTransDate.DownPaymentUsingBusinessDaysColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DownPaymentUsingBusinessDays' in table 'tblCompanyLineInstallmentsTransDate' is DBNull.", (Exception) ex);
        }
      }
      set
      {
        this[this.tabletblCompanyLineInstallmentsTransDate.DownPaymentUsingBusinessDaysColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool PolicyExpiration
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tabletblCompanyLineInstallmentsTransDate.PolicyExpirationColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'PolicyExpiration' in table 'tblCompanyLineInstallmentsTransDate' is DBNull.", (Exception) ex);
        }
      }
      set
      {
        this[this.tabletblCompanyLineInstallmentsTransDate.PolicyExpirationColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int ExpirationAltFirstInstallDays
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblCompanyLineInstallmentsTransDate.ExpirationAltFirstInstallDaysColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ExpirationAltFirstInstallDays' in table 'tblCompanyLineInstallmentsTransDate' is DBNull.", (Exception) ex);
        }
      }
      set
      {
        this[this.tabletblCompanyLineInstallmentsTransDate.ExpirationAltFirstInstallDaysColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool MonthFollowingDownPayment_Exp
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tabletblCompanyLineInstallmentsTransDate.MonthFollowingDownPayment_ExpColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'MonthFollowingDownPayment_Exp' in table 'tblCompanyLineInstallmentsTransDate' is DBNull.", (Exception) ex);
        }
      }
      set
      {
        this[this.tabletblCompanyLineInstallmentsTransDate.MonthFollowingDownPayment_ExpColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int PolicyExpirationInstallmentTerm
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblCompanyLineInstallmentsTransDate.PolicyExpirationInstallmentTermColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'PolicyExpirationInstallmentTerm' in table 'tblCompanyLineInstallmentsTransDate' is DBNull.", (Exception) ex);
        }
      }
      set
      {
        this[this.tabletblCompanyLineInstallmentsTransDate.PolicyExpirationInstallmentTermColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool DownpaymentFromExpirationDate
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tabletblCompanyLineInstallmentsTransDate.DownpaymentFromExpirationDateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DownpaymentFromExpirationDate' in table 'tblCompanyLineInstallmentsTransDate' is DBNull.", (Exception) ex);
        }
      }
      set
      {
        this[this.tabletblCompanyLineInstallmentsTransDate.DownpaymentFromExpirationDateColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool DownPaymentFromEffEndMonth
    {
      get
      {
        return Conversions.ToBoolean(this[this.tabletblCompanyLineInstallmentsTransDate.DownPaymentFromEffEndMonthColumn]);
      }
      set
      {
        this[this.tabletblCompanyLineInstallmentsTransDate.DownPaymentFromEffEndMonthColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int DownPaymentDayofMonth
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblCompanyLineInstallmentsTransDate.DownPaymentDayofMonthColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DownPaymentDayofMonth' in table 'tblCompanyLineInstallmentsTransDate' is DBNull.", (Exception) ex);
        }
      }
      set
      {
        this[this.tabletblCompanyLineInstallmentsTransDate.DownPaymentDayofMonthColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsOptionNameNull()
    {
      return this.IsNull(this.tabletblCompanyLineInstallmentsTransDate.OptionNameColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetOptionNameNull()
    {
      this[this.tabletblCompanyLineInstallmentsTransDate.OptionNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsDownpaymentTermNull()
    {
      return this.IsNull(this.tabletblCompanyLineInstallmentsTransDate.DownpaymentTermColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetDownpaymentTermNull()
    {
      this[this.tabletblCompanyLineInstallmentsTransDate.DownpaymentTermColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsInstallmentTermsNull()
    {
      return this.IsNull(this.tabletblCompanyLineInstallmentsTransDate.InstallmentTermsColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetInstallmentTermsNull()
    {
      this[this.tabletblCompanyLineInstallmentsTransDate.InstallmentTermsColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsDownpaymentBillingTypeIDNull()
    {
      return this.IsNull(this.tabletblCompanyLineInstallmentsTransDate.DownpaymentBillingTypeIDColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetDownpaymentBillingTypeIDNull()
    {
      this[this.tabletblCompanyLineInstallmentsTransDate.DownpaymentBillingTypeIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsDisabledNull()
    {
      return this.IsNull(this.tabletblCompanyLineInstallmentsTransDate.DisabledColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetDisabledNull()
    {
      this[this.tabletblCompanyLineInstallmentsTransDate.DisabledColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsDayOfMonthNumberNull()
    {
      return this.IsNull(this.tabletblCompanyLineInstallmentsTransDate.DayOfMonthNumberColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetDayOfMonthNumberNull()
    {
      this[this.tabletblCompanyLineInstallmentsTransDate.DayOfMonthNumberColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsPolicyEffectiveInstallmentTermNull()
    {
      return this.IsNull(this.tabletblCompanyLineInstallmentsTransDate.PolicyEffectiveInstallmentTermColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetPolicyEffectiveInstallmentTermNull()
    {
      this[this.tabletblCompanyLineInstallmentsTransDate.PolicyEffectiveInstallmentTermColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsDayOfMonthInstallmentTermNull()
    {
      return this.IsNull(this.tabletblCompanyLineInstallmentsTransDate.DayOfMonthInstallmentTermColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetDayOfMonthInstallmentTermNull()
    {
      this[this.tabletblCompanyLineInstallmentsTransDate.DayOfMonthInstallmentTermColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsMonthFollowingDownPaymentNull()
    {
      return this.IsNull(this.tabletblCompanyLineInstallmentsTransDate.MonthFollowingDownPaymentColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetMonthFollowingDownPaymentNull()
    {
      this[this.tabletblCompanyLineInstallmentsTransDate.MonthFollowingDownPaymentColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsMonthFollowingDownPayment_EffNull()
    {
      return this.IsNull(this.tabletblCompanyLineInstallmentsTransDate.MonthFollowingDownPayment_EffColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetMonthFollowingDownPayment_EffNull()
    {
      this[this.tabletblCompanyLineInstallmentsTransDate.MonthFollowingDownPayment_EffColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsMonthFollowingDownPayment_Eff_DateBilledNull()
    {
      return this.IsNull(this.tabletblCompanyLineInstallmentsTransDate.MonthFollowingDownPayment_Eff_DateBilledColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetMonthFollowingDownPayment_Eff_DateBilledNull()
    {
      this[this.tabletblCompanyLineInstallmentsTransDate.MonthFollowingDownPayment_Eff_DateBilledColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsEffectiveAltFirstInstallDaysNull()
    {
      return this.IsNull(this.tabletblCompanyLineInstallmentsTransDate.EffectiveAltFirstInstallDaysColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetEffectiveAltFirstInstallDaysNull()
    {
      this[this.tabletblCompanyLineInstallmentsTransDate.EffectiveAltFirstInstallDaysColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsEffDateBilledAltFirstInstallDaysNull()
    {
      return this.IsNull(this.tabletblCompanyLineInstallmentsTransDate.EffDateBilledAltFirstInstallDaysColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetEffDateBilledAltFirstInstallDaysNull()
    {
      this[this.tabletblCompanyLineInstallmentsTransDate.EffDateBilledAltFirstInstallDaysColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsUseMonthNull()
    {
      return this.IsNull(this.tabletblCompanyLineInstallmentsTransDate.UseMonthColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetUseMonthNull()
    {
      this[this.tabletblCompanyLineInstallmentsTransDate.UseMonthColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsDayOfMonthAltFirstInstallDaysNull()
    {
      return this.IsNull(this.tabletblCompanyLineInstallmentsTransDate.DayOfMonthAltFirstInstallDaysColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetDayOfMonthAltFirstInstallDaysNull()
    {
      this[this.tabletblCompanyLineInstallmentsTransDate.DayOfMonthAltFirstInstallDaysColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsSinglePayNull()
    {
      return this.IsNull(this.tabletblCompanyLineInstallmentsTransDate.SinglePayColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetSinglePayNull()
    {
      this[this.tabletblCompanyLineInstallmentsTransDate.SinglePayColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsBillingDateDaysFromDueDateNull()
    {
      return this.IsNull(this.tabletblCompanyLineInstallmentsTransDate.BillingDateDaysFromDueDateColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetBillingDateDaysFromDueDateNull()
    {
      this[this.tabletblCompanyLineInstallmentsTransDate.BillingDateDaysFromDueDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsDownPaymentGAAPNull()
    {
      return this.IsNull(this.tabletblCompanyLineInstallmentsTransDate.DownPaymentGAAPColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetDownPaymentGAAPNull()
    {
      this[this.tabletblCompanyLineInstallmentsTransDate.DownPaymentGAAPColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsUseMonthForAltFirstInstallmentNull()
    {
      return this.IsNull(this.tabletblCompanyLineInstallmentsTransDate.UseMonthForAltFirstInstallmentColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetUseMonthForAltFirstInstallmentNull()
    {
      this[this.tabletblCompanyLineInstallmentsTransDate.UseMonthForAltFirstInstallmentColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsDownPaymentUsingBusinessDaysNull()
    {
      return this.IsNull(this.tabletblCompanyLineInstallmentsTransDate.DownPaymentUsingBusinessDaysColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetDownPaymentUsingBusinessDaysNull()
    {
      this[this.tabletblCompanyLineInstallmentsTransDate.DownPaymentUsingBusinessDaysColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsPolicyExpirationNull()
    {
      return this.IsNull(this.tabletblCompanyLineInstallmentsTransDate.PolicyExpirationColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetPolicyExpirationNull()
    {
      this[this.tabletblCompanyLineInstallmentsTransDate.PolicyExpirationColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsExpirationAltFirstInstallDaysNull()
    {
      return this.IsNull(this.tabletblCompanyLineInstallmentsTransDate.ExpirationAltFirstInstallDaysColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetExpirationAltFirstInstallDaysNull()
    {
      this[this.tabletblCompanyLineInstallmentsTransDate.ExpirationAltFirstInstallDaysColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsMonthFollowingDownPayment_ExpNull()
    {
      return this.IsNull(this.tabletblCompanyLineInstallmentsTransDate.MonthFollowingDownPayment_ExpColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetMonthFollowingDownPayment_ExpNull()
    {
      this[this.tabletblCompanyLineInstallmentsTransDate.MonthFollowingDownPayment_ExpColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsPolicyExpirationInstallmentTermNull()
    {
      return this.IsNull(this.tabletblCompanyLineInstallmentsTransDate.PolicyExpirationInstallmentTermColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetPolicyExpirationInstallmentTermNull()
    {
      this[this.tabletblCompanyLineInstallmentsTransDate.PolicyExpirationInstallmentTermColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsDownpaymentFromExpirationDateNull()
    {
      return this.IsNull(this.tabletblCompanyLineInstallmentsTransDate.DownpaymentFromExpirationDateColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetDownpaymentFromExpirationDateNull()
    {
      this[this.tabletblCompanyLineInstallmentsTransDate.DownpaymentFromExpirationDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsDownPaymentDayofMonthNull()
    {
      return this.IsNull(this.tabletblCompanyLineInstallmentsTransDate.DownPaymentDayofMonthColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetDownPaymentDayofMonthNull()
    {
      this[this.tabletblCompanyLineInstallmentsTransDate.DownPaymentDayofMonthColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class tblCompanyBillingTypesRow : DataRow
  {
    private dsTransDateInstallment.tblCompanyBillingTypesDataTable tabletblCompanyBillingTypes;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal tblCompanyBillingTypesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblCompanyBillingTypes = (dsTransDateInstallment.tblCompanyBillingTypesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int BillingTypeID
    {
      get => Conversions.ToInteger(this[this.tabletblCompanyBillingTypes.BillingTypeIDColumn]);
      set => this[this.tabletblCompanyBillingTypes.BillingTypeIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string BillingType
    {
      get => Conversions.ToString(this[this.tabletblCompanyBillingTypes.BillingTypeColumn]);
      set => this[this.tabletblCompanyBillingTypes.BillingTypeColumn] = (object) value;
    }
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class tblCompanyLineInstallmentsTransDateRowChangeEvent : EventArgs
  {
    private dsTransDateInstallment.tblCompanyLineInstallmentsTransDateRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public tblCompanyLineInstallmentsTransDateRowChangeEvent(
      dsTransDateInstallment.tblCompanyLineInstallmentsTransDateRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsTransDateInstallment.tblCompanyLineInstallmentsTransDateRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class tblCompanyBillingTypesRowChangeEvent : EventArgs
  {
    private dsTransDateInstallment.tblCompanyBillingTypesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public tblCompanyBillingTypesRowChangeEvent(
      dsTransDateInstallment.tblCompanyBillingTypesRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsTransDateInstallment.tblCompanyBillingTypesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }
}
