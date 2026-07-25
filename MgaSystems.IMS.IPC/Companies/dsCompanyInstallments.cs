// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.Companies.dsCompanyInstallments
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
namespace MGASystems.IMS.InsuredsProducersCompanies.Companies;

[DesignerCategory("code")]
[ToolboxItem(true)]
[XmlSchemaProvider("GetTypedDataSetSchema")]
[XmlRoot("dsCompanyInstallments")]
[HelpKeyword("vs.data.DataSet")]
[Serializable]
public class dsCompanyInstallments : DataSet
{
  private dsCompanyInstallments.tblCompanyLineInstallmentsDataTable tabletblCompanyLineInstallments;
  private dsCompanyInstallments.tblCompanyBillingTypesDataTable tabletblCompanyBillingTypes;
  private DataRelation relationtblCompanyBillingTypestblCompanyLineInstallments;
  private SchemaSerializationMode _schemaSerializationMode;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public dsCompanyInstallments()
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
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  protected dsCompanyInstallments(SerializationInfo info, StreamingContext context)
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
        if (dataSet.Tables[nameof (tblCompanyLineInstallments)] != null)
          base.Tables.Add((DataTable) new dsCompanyInstallments.tblCompanyLineInstallmentsDataTable(dataSet.Tables[nameof (tblCompanyLineInstallments)]));
        if (dataSet.Tables[nameof (tblCompanyBillingTypes)] != null)
          base.Tables.Add((DataTable) new dsCompanyInstallments.tblCompanyBillingTypesDataTable(dataSet.Tables[nameof (tblCompanyBillingTypes)]));
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
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsCompanyInstallments.tblCompanyLineInstallmentsDataTable tblCompanyLineInstallments
  {
    get => this.tabletblCompanyLineInstallments;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsCompanyInstallments.tblCompanyBillingTypesDataTable tblCompanyBillingTypes
  {
    get => this.tabletblCompanyBillingTypes;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [Browsable(true)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
  public override SchemaSerializationMode SchemaSerializationMode
  {
    get => this._schemaSerializationMode;
    set => this._schemaSerializationMode = value;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public new DataTableCollection Tables => base.Tables;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public new DataRelationCollection Relations => base.Relations;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  protected override void InitializeDerivedDataSet()
  {
    this.BeginInit();
    this.InitClass();
    this.EndInit();
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public override DataSet Clone()
  {
    dsCompanyInstallments companyInstallments = (dsCompanyInstallments) base.Clone();
    companyInstallments.InitVars();
    companyInstallments.SchemaSerializationMode = this.SchemaSerializationMode;
    return (DataSet) companyInstallments;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  protected override bool ShouldSerializeTables() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  protected override bool ShouldSerializeRelations() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  protected override void ReadXmlSerializable(XmlReader reader)
  {
    if (this.DetermineSchemaSerializationMode(reader) == SchemaSerializationMode.IncludeSchema)
    {
      this.Reset();
      DataSet dataSet = new DataSet();
      int num = (int) dataSet.ReadXml(reader);
      if (dataSet.Tables["tblCompanyLineInstallments"] != null)
        base.Tables.Add((DataTable) new dsCompanyInstallments.tblCompanyLineInstallmentsDataTable(dataSet.Tables["tblCompanyLineInstallments"]));
      if (dataSet.Tables["tblCompanyBillingTypes"] != null)
        base.Tables.Add((DataTable) new dsCompanyInstallments.tblCompanyBillingTypesDataTable(dataSet.Tables["tblCompanyBillingTypes"]));
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
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  protected override XmlSchema GetSchemaSerializable()
  {
    MemoryStream memoryStream = new MemoryStream();
    this.WriteXmlSchema((XmlWriter) new XmlTextWriter((Stream) memoryStream, (Encoding) null));
    memoryStream.Position = 0L;
    return XmlSchema.Read((XmlReader) new XmlTextReader((Stream) memoryStream), (ValidationEventHandler) null);
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  internal void InitVars() => this.InitVars(true);

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  internal void InitVars(bool initTable)
  {
    this.tabletblCompanyLineInstallments = (dsCompanyInstallments.tblCompanyLineInstallmentsDataTable) base.Tables["tblCompanyLineInstallments"];
    if (initTable && this.tabletblCompanyLineInstallments != null)
      this.tabletblCompanyLineInstallments.InitVars();
    this.tabletblCompanyBillingTypes = (dsCompanyInstallments.tblCompanyBillingTypesDataTable) base.Tables["tblCompanyBillingTypes"];
    if (initTable && this.tabletblCompanyBillingTypes != null)
      this.tabletblCompanyBillingTypes.InitVars();
    this.relationtblCompanyBillingTypestblCompanyLineInstallments = this.Relations["tblCompanyBillingTypestblCompanyLineInstallments"];
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private void InitClass()
  {
    this.DataSetName = nameof (dsCompanyInstallments);
    this.Prefix = "";
    this.Namespace = "http://www.tempuri.org/dsCompanyInstallments.xsd";
    this.EnforceConstraints = true;
    this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.tabletblCompanyLineInstallments = new dsCompanyInstallments.tblCompanyLineInstallmentsDataTable();
    base.Tables.Add((DataTable) this.tabletblCompanyLineInstallments);
    this.tabletblCompanyBillingTypes = new dsCompanyInstallments.tblCompanyBillingTypesDataTable();
    base.Tables.Add((DataTable) this.tabletblCompanyBillingTypes);
    ForeignKeyConstraint foreignKeyConstraint = new ForeignKeyConstraint("tblCompanyBillingTypestblCompanyLineInstallments", new DataColumn[1]
    {
      this.tabletblCompanyBillingTypes.BillingTypeIDColumn
    }, new DataColumn[1]
    {
      this.tabletblCompanyLineInstallments.DownpaymentBillingTypeIDColumn
    });
    this.tabletblCompanyLineInstallments.Constraints.Add((Constraint) foreignKeyConstraint);
    foreignKeyConstraint.AcceptRejectRule = AcceptRejectRule.None;
    foreignKeyConstraint.DeleteRule = Rule.Cascade;
    foreignKeyConstraint.UpdateRule = Rule.Cascade;
    this.relationtblCompanyBillingTypestblCompanyLineInstallments = new DataRelation("tblCompanyBillingTypestblCompanyLineInstallments", new DataColumn[1]
    {
      this.tabletblCompanyBillingTypes.BillingTypeIDColumn
    }, new DataColumn[1]
    {
      this.tabletblCompanyLineInstallments.DownpaymentBillingTypeIDColumn
    }, false);
    this.Relations.Add(this.relationtblCompanyBillingTypestblCompanyLineInstallments);
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializetblCompanyLineInstallments() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private bool ShouldSerializetblCompanyBillingTypes() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  private void SchemaChanged(object sender, CollectionChangeEventArgs e)
  {
    if (e.Action != CollectionChangeAction.Remove)
      return;
    this.InitVars();
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public static XmlSchemaComplexType GetTypedDataSetSchema(XmlSchemaSet xs)
  {
    dsCompanyInstallments companyInstallments = new dsCompanyInstallments();
    XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
    schemaComplexType.Particle = (XmlSchemaParticle) new XmlSchemaSequence()
    {
      Items = {
        (XmlSchemaObject) new XmlSchemaAny()
        {
          Namespace = companyInstallments.Namespace
        }
      }
    };
    XmlSchema schemaSerializable = companyInstallments.GetSchemaSerializable();
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

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public delegate void tblCompanyLineInstallmentsRowChangeEventHandler(
    object sender,
    dsCompanyInstallments.tblCompanyLineInstallmentsRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public delegate void tblCompanyBillingTypesRowChangeEventHandler(
    object sender,
    dsCompanyInstallments.tblCompanyBillingTypesRowChangeEvent e);

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class tblCompanyLineInstallmentsDataTable : 
    TypedTableBase<dsCompanyInstallments.tblCompanyLineInstallmentsRow>
  {
    private DataColumn columnID;
    private DataColumn columnCompanyLineID;
    private DataColumn columnOptionName;
    private DataColumn columnDownpaymentPercentage;
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
    private DataColumn columnMinimumDownPayment;
    private DataColumn columnDownPaymentFromEffEndMonth;
    private DataColumn columnDownPaymentDayofMonth;
    private DataColumn columnMinimumPremium;
    private DataColumn columnMaximumPremium;
    private DataColumn columnEffDateBilledAltFinalInstallDays;
    private DataColumn columnEffectiveAltFinalInstallDays;
    private DataColumn columnExpirationAltFinalInstallDays;
    private DataColumn columnDayOfMonthAltFinalInstallDays;
    private DataColumn columnUseMonthFinalInstallment;
    private DataColumn columnAssignRemainderFinalInstallment;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public tblCompanyLineInstallmentsDataTable()
    {
      this.TableName = "tblCompanyLineInstallments";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal tblCompanyLineInstallmentsDataTable(DataTable table)
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected tblCompanyLineInstallmentsDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn IDColumn => this.columnID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn CompanyLineIDColumn => this.columnCompanyLineID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn OptionNameColumn => this.columnOptionName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn DownpaymentPercentageColumn => this.columnDownpaymentPercentage;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn DownpaymentTermColumn => this.columnDownpaymentTerm;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn NumPaymentsColumn => this.columnNumPayments;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn InstallmentTermsColumn => this.columnInstallmentTerms;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn DownpaymentBillingTypeIDColumn => this.columnDownpaymentBillingTypeID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn DownpaymentFromEffectiveDateColumn => this.columnDownpaymentFromEffectiveDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn DownpaymentFromDateBilledColumn => this.columnDownpaymentFromDateBilled;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn InstallmentFromEffectiveDateColumn => this.columnInstallmentFromEffectiveDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn InstallmentFromDateBilledColumn => this.columnInstallmentFromDateBilled;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn FinancedColumn => this.columnFinanced;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn DisallowAutomatedPrintingColumn => this.columnDisallowAutomatedPrinting;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn DisallowAutomatedNOCColumn => this.columnDisallowAutomatedNOC;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn DisabledColumn => this.columnDisabled;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn DateBilledEqualToDueDateColumn => this.columnDateBilledEqualToDueDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn EffectiveDateBilledColumn => this.columnEffectiveDateBilled;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn PolicyEffectiveColumn => this.columnPolicyEffective;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn DayOfMonthColumn => this.columnDayOfMonth;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn DayOfMonthNumberColumn => this.columnDayOfMonthNumber;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn PolicyEffectiveInstallmentTermColumn
    {
      get => this.columnPolicyEffectiveInstallmentTerm;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn DayOfMonthInstallmentTermColumn => this.columnDayOfMonthInstallmentTerm;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn MonthFollowingDownPaymentColumn => this.columnMonthFollowingDownPayment;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn MonthFollowingDownPayment_EffColumn
    {
      get => this.columnMonthFollowingDownPayment_Eff;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn MonthFollowingDownPayment_Eff_DateBilledColumn
    {
      get => this.columnMonthFollowingDownPayment_Eff_DateBilled;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn EffectiveAltFirstInstallDaysColumn => this.columnEffectiveAltFirstInstallDays;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn EffDateBilledAltFirstInstallDaysColumn
    {
      get => this.columnEffDateBilledAltFirstInstallDays;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn UseMonthColumn => this.columnUseMonth;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn DayOfMonthAltFirstInstallDaysColumn
    {
      get => this.columnDayOfMonthAltFirstInstallDays;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn SinglePayColumn => this.columnSinglePay;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn BillingDateDaysFromDueDateColumn => this.columnBillingDateDaysFromDueDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn UseEffectiveDateForBillingColumn => this.columnUseEffectiveDateForBilling;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn DownPaymentGAAPColumn => this.columnDownPaymentGAAP;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn UseMonthForAltFirstInstallmentColumn
    {
      get => this.columnUseMonthForAltFirstInstallment;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn DownPaymentUsingBusinessDaysColumn => this.columnDownPaymentUsingBusinessDays;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn PolicyExpirationColumn => this.columnPolicyExpiration;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ExpirationAltFirstInstallDaysColumn
    {
      get => this.columnExpirationAltFirstInstallDays;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn MonthFollowingDownPayment_ExpColumn
    {
      get => this.columnMonthFollowingDownPayment_Exp;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn PolicyExpirationInstallmentTermColumn
    {
      get => this.columnPolicyExpirationInstallmentTerm;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn DownpaymentFromExpirationDateColumn
    {
      get => this.columnDownpaymentFromExpirationDate;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn MinimumDownPaymentColumn => this.columnMinimumDownPayment;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn DownPaymentFromEffEndMonthColumn => this.columnDownPaymentFromEffEndMonth;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn DownPaymentDayofMonthColumn => this.columnDownPaymentDayofMonth;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn MinimumPremiumColumn => this.columnMinimumPremium;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn MaximumPremiumColumn => this.columnMaximumPremium;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn EffDateBilledAltFinalInstallDaysColumn
    {
      get => this.columnEffDateBilledAltFinalInstallDays;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn EffectiveAltFinalInstallDaysColumn => this.columnEffectiveAltFinalInstallDays;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn ExpirationAltFinalInstallDaysColumn
    {
      get => this.columnExpirationAltFinalInstallDays;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn DayOfMonthAltFinalInstallDaysColumn
    {
      get => this.columnDayOfMonthAltFinalInstallDays;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn UseMonthFinalInstallmentColumn => this.columnUseMonthFinalInstallment;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn AssignRemainderFinalInstallmentColumn
    {
      get => this.columnAssignRemainderFinalInstallment;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCompanyInstallments.tblCompanyLineInstallmentsRow this[int index]
    {
      get => (dsCompanyInstallments.tblCompanyLineInstallmentsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsCompanyInstallments.tblCompanyLineInstallmentsRowChangeEventHandler tblCompanyLineInstallmentsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsCompanyInstallments.tblCompanyLineInstallmentsRowChangeEventHandler tblCompanyLineInstallmentsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsCompanyInstallments.tblCompanyLineInstallmentsRowChangeEventHandler tblCompanyLineInstallmentsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsCompanyInstallments.tblCompanyLineInstallmentsRowChangeEventHandler tblCompanyLineInstallmentsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AddtblCompanyLineInstallmentsRow(
      dsCompanyInstallments.tblCompanyLineInstallmentsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCompanyInstallments.tblCompanyLineInstallmentsRow AddtblCompanyLineInstallmentsRow(
      int CompanyLineID,
      string OptionName,
      Decimal DownpaymentPercentage,
      int DownpaymentTerm,
      int NumPayments,
      int InstallmentTerms,
      dsCompanyInstallments.tblCompanyBillingTypesRow parenttblCompanyBillingTypesRowBytblCompanyBillingTypestblCompanyLineInstallments,
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
      Decimal MinimumDownPayment,
      bool DownPaymentFromEffEndMonth,
      int DownPaymentDayofMonth,
      Decimal MinimumPremium,
      Decimal MaximumPremium,
      int EffDateBilledAltFinalInstallDays,
      int EffectiveAltFinalInstallDays,
      int ExpirationAltFinalInstallDays,
      int DayOfMonthAltFinalInstallDays,
      bool UseMonthFinalInstallment,
      bool AssignRemainderFinalInstallment)
    {
      dsCompanyInstallments.tblCompanyLineInstallmentsRow row = (dsCompanyInstallments.tblCompanyLineInstallmentsRow) this.NewRow();
      object[] objArray = new object[52]
      {
        null,
        (object) CompanyLineID,
        (object) OptionName,
        (object) DownpaymentPercentage,
        (object) DownpaymentTerm,
        (object) NumPayments,
        (object) InstallmentTerms,
        null,
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
        (object) MinimumDownPayment,
        (object) DownPaymentFromEffEndMonth,
        (object) DownPaymentDayofMonth,
        (object) MinimumPremium,
        (object) MaximumPremium,
        (object) EffDateBilledAltFinalInstallDays,
        (object) EffectiveAltFinalInstallDays,
        (object) ExpirationAltFinalInstallDays,
        (object) DayOfMonthAltFinalInstallDays,
        (object) UseMonthFinalInstallment,
        (object) AssignRemainderFinalInstallment
      };
      if (parenttblCompanyBillingTypesRowBytblCompanyBillingTypestblCompanyLineInstallments != null)
        objArray[7] = RuntimeHelpers.GetObjectValue(parenttblCompanyBillingTypesRowBytblCompanyBillingTypestblCompanyLineInstallments[0]);
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCompanyInstallments.tblCompanyLineInstallmentsRow FindByID(int ID)
    {
      return (dsCompanyInstallments.tblCompanyLineInstallmentsRow) this.Rows.Find(new object[1]
      {
        (object) ID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsCompanyInstallments.tblCompanyLineInstallmentsDataTable installmentsDataTable = (dsCompanyInstallments.tblCompanyLineInstallmentsDataTable) base.Clone();
      installmentsDataTable.InitVars();
      return (DataTable) installmentsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsCompanyInstallments.tblCompanyLineInstallmentsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal void InitVars()
    {
      this.columnID = this.Columns["ID"];
      this.columnCompanyLineID = this.Columns["CompanyLineID"];
      this.columnOptionName = this.Columns["OptionName"];
      this.columnDownpaymentPercentage = this.Columns["DownpaymentPercentage"];
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
      this.columnMinimumDownPayment = this.Columns["MinimumDownPayment"];
      this.columnDownPaymentFromEffEndMonth = this.Columns["DownPaymentFromEffEndMonth"];
      this.columnDownPaymentDayofMonth = this.Columns["DownPaymentDayofMonth"];
      this.columnMinimumPremium = this.Columns["MinimumPremium"];
      this.columnMaximumPremium = this.Columns["MaximumPremium"];
      this.columnEffDateBilledAltFinalInstallDays = this.Columns["EffDateBilledAltFinalInstallDays"];
      this.columnEffectiveAltFinalInstallDays = this.Columns["EffectiveAltFinalInstallDays"];
      this.columnExpirationAltFinalInstallDays = this.Columns["ExpirationAltFinalInstallDays"];
      this.columnDayOfMonthAltFinalInstallDays = this.Columns["DayOfMonthAltFinalInstallDays"];
      this.columnUseMonthFinalInstallment = this.Columns["UseMonthFinalInstallment"];
      this.columnAssignRemainderFinalInstallment = this.Columns["AssignRemainderFinalInstallment"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    private void InitClass()
    {
      this.columnID = new DataColumn("ID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnID);
      this.columnCompanyLineID = new DataColumn("CompanyLineID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCompanyLineID);
      this.columnOptionName = new DataColumn("OptionName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnOptionName);
      this.columnDownpaymentPercentage = new DataColumn("DownpaymentPercentage", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDownpaymentPercentage);
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
      this.columnMinimumDownPayment = new DataColumn("MinimumDownPayment", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnMinimumDownPayment);
      this.columnDownPaymentFromEffEndMonth = new DataColumn("DownPaymentFromEffEndMonth", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDownPaymentFromEffEndMonth);
      this.columnDownPaymentDayofMonth = new DataColumn("DownPaymentDayofMonth", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDownPaymentDayofMonth);
      this.columnMinimumPremium = new DataColumn("MinimumPremium", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnMinimumPremium);
      this.columnMaximumPremium = new DataColumn("MaximumPremium", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnMaximumPremium);
      this.columnEffDateBilledAltFinalInstallDays = new DataColumn("EffDateBilledAltFinalInstallDays", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEffDateBilledAltFinalInstallDays);
      this.columnEffectiveAltFinalInstallDays = new DataColumn("EffectiveAltFinalInstallDays", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEffectiveAltFinalInstallDays);
      this.columnExpirationAltFinalInstallDays = new DataColumn("ExpirationAltFinalInstallDays", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnExpirationAltFinalInstallDays);
      this.columnDayOfMonthAltFinalInstallDays = new DataColumn("DayOfMonthAltFinalInstallDays", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDayOfMonthAltFinalInstallDays);
      this.columnUseMonthFinalInstallment = new DataColumn("UseMonthFinalInstallment", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnUseMonthFinalInstallment);
      this.columnAssignRemainderFinalInstallment = new DataColumn("AssignRemainderFinalInstallment", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAssignRemainderFinalInstallment);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnID
      }, true));
      this.columnID.AutoIncrement = true;
      this.columnID.AllowDBNull = false;
      this.columnID.ReadOnly = true;
      this.columnID.Unique = true;
      this.columnCompanyLineID.AllowDBNull = false;
      this.columnDownpaymentPercentage.AllowDBNull = false;
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
      this.columnUseMonthFinalInstallment.DefaultValue = (object) false;
      this.columnAssignRemainderFinalInstallment.DefaultValue = (object) false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCompanyInstallments.tblCompanyLineInstallmentsRow NewtblCompanyLineInstallmentsRow()
    {
      return (dsCompanyInstallments.tblCompanyLineInstallmentsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsCompanyInstallments.tblCompanyLineInstallmentsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType()
    {
      return typeof (dsCompanyInstallments.tblCompanyLineInstallmentsRow);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyLineInstallmentsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyInstallments.tblCompanyLineInstallmentsRowChangeEventHandler installmentsRowChangedEvent = this.tblCompanyLineInstallmentsRowChangedEvent;
      if (installmentsRowChangedEvent == null)
        return;
      installmentsRowChangedEvent((object) this, new dsCompanyInstallments.tblCompanyLineInstallmentsRowChangeEvent((dsCompanyInstallments.tblCompanyLineInstallmentsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyLineInstallmentsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyInstallments.tblCompanyLineInstallmentsRowChangeEventHandler rowChangingEvent = this.tblCompanyLineInstallmentsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsCompanyInstallments.tblCompanyLineInstallmentsRowChangeEvent((dsCompanyInstallments.tblCompanyLineInstallmentsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyLineInstallmentsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyInstallments.tblCompanyLineInstallmentsRowChangeEventHandler installmentsRowDeletedEvent = this.tblCompanyLineInstallmentsRowDeletedEvent;
      if (installmentsRowDeletedEvent == null)
        return;
      installmentsRowDeletedEvent((object) this, new dsCompanyInstallments.tblCompanyLineInstallmentsRowChangeEvent((dsCompanyInstallments.tblCompanyLineInstallmentsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyLineInstallmentsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyInstallments.tblCompanyLineInstallmentsRowChangeEventHandler rowDeletingEvent = this.tblCompanyLineInstallmentsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsCompanyInstallments.tblCompanyLineInstallmentsRowChangeEvent((dsCompanyInstallments.tblCompanyLineInstallmentsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemovetblCompanyLineInstallmentsRow(
      dsCompanyInstallments.tblCompanyLineInstallmentsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsCompanyInstallments companyInstallments = new dsCompanyInstallments();
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
        FixedValue = companyInstallments.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblCompanyLineInstallmentsDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = companyInstallments.GetSchemaSerializable();
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
    TypedTableBase<dsCompanyInstallments.tblCompanyBillingTypesRow>
  {
    private DataColumn columnBillingTypeID;
    private DataColumn columnBillingType;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public tblCompanyBillingTypesDataTable()
    {
      this.TableName = "tblCompanyBillingTypes";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected tblCompanyBillingTypesDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn BillingTypeIDColumn => this.columnBillingTypeID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataColumn BillingTypeColumn => this.columnBillingType;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCompanyInstallments.tblCompanyBillingTypesRow this[int index]
    {
      get => (dsCompanyInstallments.tblCompanyBillingTypesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsCompanyInstallments.tblCompanyBillingTypesRowChangeEventHandler tblCompanyBillingTypesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsCompanyInstallments.tblCompanyBillingTypesRowChangeEventHandler tblCompanyBillingTypesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsCompanyInstallments.tblCompanyBillingTypesRowChangeEventHandler tblCompanyBillingTypesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public event dsCompanyInstallments.tblCompanyBillingTypesRowChangeEventHandler tblCompanyBillingTypesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void AddtblCompanyBillingTypesRow(
      dsCompanyInstallments.tblCompanyBillingTypesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCompanyInstallments.tblCompanyBillingTypesRow AddtblCompanyBillingTypesRow(
      int BillingTypeID,
      string BillingType)
    {
      dsCompanyInstallments.tblCompanyBillingTypesRow row = (dsCompanyInstallments.tblCompanyBillingTypesRow) this.NewRow();
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCompanyInstallments.tblCompanyBillingTypesRow FindByBillingTypeID(int BillingTypeID)
    {
      return (dsCompanyInstallments.tblCompanyBillingTypesRow) this.Rows.Find(new object[1]
      {
        (object) BillingTypeID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public override DataTable Clone()
    {
      dsCompanyInstallments.tblCompanyBillingTypesDataTable billingTypesDataTable = (dsCompanyInstallments.tblCompanyBillingTypesDataTable) base.Clone();
      billingTypesDataTable.InitVars();
      return (DataTable) billingTypesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsCompanyInstallments.tblCompanyBillingTypesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal void InitVars()
    {
      this.columnBillingTypeID = this.Columns["BillingTypeID"];
      this.columnBillingType = this.Columns["BillingType"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCompanyInstallments.tblCompanyBillingTypesRow NewtblCompanyBillingTypesRow()
    {
      return (dsCompanyInstallments.tblCompanyBillingTypesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsCompanyInstallments.tblCompanyBillingTypesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override Type GetRowType()
    {
      return typeof (dsCompanyInstallments.tblCompanyBillingTypesRow);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyBillingTypesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyInstallments.tblCompanyBillingTypesRowChangeEventHandler typesRowChangedEvent = this.tblCompanyBillingTypesRowChangedEvent;
      if (typesRowChangedEvent == null)
        return;
      typesRowChangedEvent((object) this, new dsCompanyInstallments.tblCompanyBillingTypesRowChangeEvent((dsCompanyInstallments.tblCompanyBillingTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyBillingTypesRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyInstallments.tblCompanyBillingTypesRowChangeEventHandler rowChangingEvent = this.tblCompanyBillingTypesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsCompanyInstallments.tblCompanyBillingTypesRowChangeEvent((dsCompanyInstallments.tblCompanyBillingTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyBillingTypesRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyInstallments.tblCompanyBillingTypesRowChangeEventHandler typesRowDeletedEvent = this.tblCompanyBillingTypesRowDeletedEvent;
      if (typesRowDeletedEvent == null)
        return;
      typesRowDeletedEvent((object) this, new dsCompanyInstallments.tblCompanyBillingTypesRowChangeEvent((dsCompanyInstallments.tblCompanyBillingTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyBillingTypesRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCompanyInstallments.tblCompanyBillingTypesRowChangeEventHandler rowDeletingEvent = this.tblCompanyBillingTypesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsCompanyInstallments.tblCompanyBillingTypesRowChangeEvent((dsCompanyInstallments.tblCompanyBillingTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void RemovetblCompanyBillingTypesRow(
      dsCompanyInstallments.tblCompanyBillingTypesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsCompanyInstallments companyInstallments = new dsCompanyInstallments();
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
        FixedValue = companyInstallments.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblCompanyBillingTypesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = companyInstallments.GetSchemaSerializable();
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

  public class tblCompanyLineInstallmentsRow : DataRow
  {
    private dsCompanyInstallments.tblCompanyLineInstallmentsDataTable tabletblCompanyLineInstallments;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal tblCompanyLineInstallmentsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblCompanyLineInstallments = (dsCompanyInstallments.tblCompanyLineInstallmentsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int ID
    {
      get => Conversions.ToInteger(this[this.tabletblCompanyLineInstallments.IDColumn]);
      set => this[this.tabletblCompanyLineInstallments.IDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int CompanyLineID
    {
      get => Conversions.ToInteger(this[this.tabletblCompanyLineInstallments.CompanyLineIDColumn]);
      set => this[this.tabletblCompanyLineInstallments.CompanyLineIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string OptionName
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblCompanyLineInstallments.OptionNameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'OptionName' in table 'tblCompanyLineInstallments' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanyLineInstallments.OptionNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Decimal DownpaymentPercentage
    {
      get
      {
        return Conversions.ToDecimal(this[this.tabletblCompanyLineInstallments.DownpaymentPercentageColumn]);
      }
      set
      {
        this[this.tabletblCompanyLineInstallments.DownpaymentPercentageColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int DownpaymentTerm
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblCompanyLineInstallments.DownpaymentTermColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DownpaymentTerm' in table 'tblCompanyLineInstallments' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanyLineInstallments.DownpaymentTermColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int NumPayments
    {
      get => Conversions.ToInteger(this[this.tabletblCompanyLineInstallments.NumPaymentsColumn]);
      set => this[this.tabletblCompanyLineInstallments.NumPaymentsColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int InstallmentTerms
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblCompanyLineInstallments.InstallmentTermsColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'InstallmentTerms' in table 'tblCompanyLineInstallments' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanyLineInstallments.InstallmentTermsColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int DownpaymentBillingTypeID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblCompanyLineInstallments.DownpaymentBillingTypeIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DownpaymentBillingTypeID' in table 'tblCompanyLineInstallments' is DBNull.", (Exception) ex);
        }
      }
      set
      {
        this[this.tabletblCompanyLineInstallments.DownpaymentBillingTypeIDColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool DownpaymentFromEffectiveDate
    {
      get
      {
        return Conversions.ToBoolean(this[this.tabletblCompanyLineInstallments.DownpaymentFromEffectiveDateColumn]);
      }
      set
      {
        this[this.tabletblCompanyLineInstallments.DownpaymentFromEffectiveDateColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool DownpaymentFromDateBilled
    {
      get
      {
        return Conversions.ToBoolean(this[this.tabletblCompanyLineInstallments.DownpaymentFromDateBilledColumn]);
      }
      set
      {
        this[this.tabletblCompanyLineInstallments.DownpaymentFromDateBilledColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool InstallmentFromEffectiveDate
    {
      get
      {
        return Conversions.ToBoolean(this[this.tabletblCompanyLineInstallments.InstallmentFromEffectiveDateColumn]);
      }
      set
      {
        this[this.tabletblCompanyLineInstallments.InstallmentFromEffectiveDateColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool InstallmentFromDateBilled
    {
      get
      {
        return Conversions.ToBoolean(this[this.tabletblCompanyLineInstallments.InstallmentFromDateBilledColumn]);
      }
      set
      {
        this[this.tabletblCompanyLineInstallments.InstallmentFromDateBilledColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool Financed
    {
      get => Conversions.ToBoolean(this[this.tabletblCompanyLineInstallments.FinancedColumn]);
      set => this[this.tabletblCompanyLineInstallments.FinancedColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool DisallowAutomatedPrinting
    {
      get
      {
        return Conversions.ToBoolean(this[this.tabletblCompanyLineInstallments.DisallowAutomatedPrintingColumn]);
      }
      set
      {
        this[this.tabletblCompanyLineInstallments.DisallowAutomatedPrintingColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool DisallowAutomatedNOC
    {
      get
      {
        return Conversions.ToBoolean(this[this.tabletblCompanyLineInstallments.DisallowAutomatedNOCColumn]);
      }
      set => this[this.tabletblCompanyLineInstallments.DisallowAutomatedNOCColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool Disabled
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tabletblCompanyLineInstallments.DisabledColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Disabled' in table 'tblCompanyLineInstallments' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanyLineInstallments.DisabledColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool DateBilledEqualToDueDate
    {
      get
      {
        return Conversions.ToBoolean(this[this.tabletblCompanyLineInstallments.DateBilledEqualToDueDateColumn]);
      }
      set
      {
        this[this.tabletblCompanyLineInstallments.DateBilledEqualToDueDateColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool EffectiveDateBilled
    {
      get
      {
        return Conversions.ToBoolean(this[this.tabletblCompanyLineInstallments.EffectiveDateBilledColumn]);
      }
      set => this[this.tabletblCompanyLineInstallments.EffectiveDateBilledColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool PolicyEffective
    {
      get
      {
        return Conversions.ToBoolean(this[this.tabletblCompanyLineInstallments.PolicyEffectiveColumn]);
      }
      set => this[this.tabletblCompanyLineInstallments.PolicyEffectiveColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool DayOfMonth
    {
      get => Conversions.ToBoolean(this[this.tabletblCompanyLineInstallments.DayOfMonthColumn]);
      set => this[this.tabletblCompanyLineInstallments.DayOfMonthColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public byte DayOfMonthNumber
    {
      get
      {
        try
        {
          return Conversions.ToByte(this[this.tabletblCompanyLineInstallments.DayOfMonthNumberColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DayOfMonthNumber' in table 'tblCompanyLineInstallments' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanyLineInstallments.DayOfMonthNumberColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int PolicyEffectiveInstallmentTerm
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblCompanyLineInstallments.PolicyEffectiveInstallmentTermColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'PolicyEffectiveInstallmentTerm' in table 'tblCompanyLineInstallments' is DBNull.", (Exception) ex);
        }
      }
      set
      {
        this[this.tabletblCompanyLineInstallments.PolicyEffectiveInstallmentTermColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int DayOfMonthInstallmentTerm
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblCompanyLineInstallments.DayOfMonthInstallmentTermColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DayOfMonthInstallmentTerm' in table 'tblCompanyLineInstallments' is DBNull.", (Exception) ex);
        }
      }
      set
      {
        this[this.tabletblCompanyLineInstallments.DayOfMonthInstallmentTermColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool MonthFollowingDownPayment
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tabletblCompanyLineInstallments.MonthFollowingDownPaymentColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'MonthFollowingDownPayment' in table 'tblCompanyLineInstallments' is DBNull.", (Exception) ex);
        }
      }
      set
      {
        this[this.tabletblCompanyLineInstallments.MonthFollowingDownPaymentColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool MonthFollowingDownPayment_Eff
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tabletblCompanyLineInstallments.MonthFollowingDownPayment_EffColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'MonthFollowingDownPayment_Eff' in table 'tblCompanyLineInstallments' is DBNull.", (Exception) ex);
        }
      }
      set
      {
        this[this.tabletblCompanyLineInstallments.MonthFollowingDownPayment_EffColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool MonthFollowingDownPayment_Eff_DateBilled
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tabletblCompanyLineInstallments.MonthFollowingDownPayment_Eff_DateBilledColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'MonthFollowingDownPayment_Eff_DateBilled' in table 'tblCompanyLineInstallments' is DBNull.", (Exception) ex);
        }
      }
      set
      {
        this[this.tabletblCompanyLineInstallments.MonthFollowingDownPayment_Eff_DateBilledColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int EffectiveAltFirstInstallDays
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblCompanyLineInstallments.EffectiveAltFirstInstallDaysColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'EffectiveAltFirstInstallDays' in table 'tblCompanyLineInstallments' is DBNull.", (Exception) ex);
        }
      }
      set
      {
        this[this.tabletblCompanyLineInstallments.EffectiveAltFirstInstallDaysColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int EffDateBilledAltFirstInstallDays
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblCompanyLineInstallments.EffDateBilledAltFirstInstallDaysColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'EffDateBilledAltFirstInstallDays' in table 'tblCompanyLineInstallments' is DBNull.", (Exception) ex);
        }
      }
      set
      {
        this[this.tabletblCompanyLineInstallments.EffDateBilledAltFirstInstallDaysColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool UseMonth
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tabletblCompanyLineInstallments.UseMonthColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'UseMonth' in table 'tblCompanyLineInstallments' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanyLineInstallments.UseMonthColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int DayOfMonthAltFirstInstallDays
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblCompanyLineInstallments.DayOfMonthAltFirstInstallDaysColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DayOfMonthAltFirstInstallDays' in table 'tblCompanyLineInstallments' is DBNull.", (Exception) ex);
        }
      }
      set
      {
        this[this.tabletblCompanyLineInstallments.DayOfMonthAltFirstInstallDaysColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool SinglePay
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tabletblCompanyLineInstallments.SinglePayColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'SinglePay' in table 'tblCompanyLineInstallments' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanyLineInstallments.SinglePayColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int BillingDateDaysFromDueDate
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblCompanyLineInstallments.BillingDateDaysFromDueDateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'BillingDateDaysFromDueDate' in table 'tblCompanyLineInstallments' is DBNull.", (Exception) ex);
        }
      }
      set
      {
        this[this.tabletblCompanyLineInstallments.BillingDateDaysFromDueDateColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool UseEffectiveDateForBilling
    {
      get
      {
        return Conversions.ToBoolean(this[this.tabletblCompanyLineInstallments.UseEffectiveDateForBillingColumn]);
      }
      set
      {
        this[this.tabletblCompanyLineInstallments.UseEffectiveDateForBillingColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool DownPaymentGAAP
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tabletblCompanyLineInstallments.DownPaymentGAAPColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DownPaymentGAAP' in table 'tblCompanyLineInstallments' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanyLineInstallments.DownPaymentGAAPColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool UseMonthForAltFirstInstallment
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tabletblCompanyLineInstallments.UseMonthForAltFirstInstallmentColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'UseMonthForAltFirstInstallment' in table 'tblCompanyLineInstallments' is DBNull.", (Exception) ex);
        }
      }
      set
      {
        this[this.tabletblCompanyLineInstallments.UseMonthForAltFirstInstallmentColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool DownPaymentUsingBusinessDays
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tabletblCompanyLineInstallments.DownPaymentUsingBusinessDaysColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DownPaymentUsingBusinessDays' in table 'tblCompanyLineInstallments' is DBNull.", (Exception) ex);
        }
      }
      set
      {
        this[this.tabletblCompanyLineInstallments.DownPaymentUsingBusinessDaysColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool PolicyExpiration
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tabletblCompanyLineInstallments.PolicyExpirationColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'PolicyExpiration' in table 'tblCompanyLineInstallments' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanyLineInstallments.PolicyExpirationColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int ExpirationAltFirstInstallDays
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblCompanyLineInstallments.ExpirationAltFirstInstallDaysColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ExpirationAltFirstInstallDays' in table 'tblCompanyLineInstallments' is DBNull.", (Exception) ex);
        }
      }
      set
      {
        this[this.tabletblCompanyLineInstallments.ExpirationAltFirstInstallDaysColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool MonthFollowingDownPayment_Exp
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tabletblCompanyLineInstallments.MonthFollowingDownPayment_ExpColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'MonthFollowingDownPayment_Exp' in table 'tblCompanyLineInstallments' is DBNull.", (Exception) ex);
        }
      }
      set
      {
        this[this.tabletblCompanyLineInstallments.MonthFollowingDownPayment_ExpColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int PolicyExpirationInstallmentTerm
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblCompanyLineInstallments.PolicyExpirationInstallmentTermColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'PolicyExpirationInstallmentTerm' in table 'tblCompanyLineInstallments' is DBNull.", (Exception) ex);
        }
      }
      set
      {
        this[this.tabletblCompanyLineInstallments.PolicyExpirationInstallmentTermColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool DownpaymentFromExpirationDate
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tabletblCompanyLineInstallments.DownpaymentFromExpirationDateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DownpaymentFromExpirationDate' in table 'tblCompanyLineInstallments' is DBNull.", (Exception) ex);
        }
      }
      set
      {
        this[this.tabletblCompanyLineInstallments.DownpaymentFromExpirationDateColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Decimal MinimumDownPayment
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tabletblCompanyLineInstallments.MinimumDownPaymentColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'MinimumDownPayment' in table 'tblCompanyLineInstallments' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanyLineInstallments.MinimumDownPaymentColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool DownPaymentFromEffEndMonth
    {
      get
      {
        return Conversions.ToBoolean(this[this.tabletblCompanyLineInstallments.DownPaymentFromEffEndMonthColumn]);
      }
      set
      {
        this[this.tabletblCompanyLineInstallments.DownPaymentFromEffEndMonthColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int DownPaymentDayofMonth
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblCompanyLineInstallments.DownPaymentDayofMonthColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DownPaymentDayofMonth' in table 'tblCompanyLineInstallments' is DBNull.", (Exception) ex);
        }
      }
      set
      {
        this[this.tabletblCompanyLineInstallments.DownPaymentDayofMonthColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Decimal MinimumPremium
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tabletblCompanyLineInstallments.MinimumPremiumColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'MinimumPremium' in table 'tblCompanyLineInstallments' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanyLineInstallments.MinimumPremiumColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public Decimal MaximumPremium
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tabletblCompanyLineInstallments.MaximumPremiumColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'MaximumPremium' in table 'tblCompanyLineInstallments' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCompanyLineInstallments.MaximumPremiumColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int EffDateBilledAltFinalInstallDays
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblCompanyLineInstallments.EffDateBilledAltFinalInstallDaysColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'EffDateBilledAltFinalInstallDays' in table 'tblCompanyLineInstallments' is DBNull.", (Exception) ex);
        }
      }
      set
      {
        this[this.tabletblCompanyLineInstallments.EffDateBilledAltFinalInstallDaysColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int EffectiveAltFinalInstallDays
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblCompanyLineInstallments.EffectiveAltFinalInstallDaysColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'EffectiveAltFinalInstallDays' in table 'tblCompanyLineInstallments' is DBNull.", (Exception) ex);
        }
      }
      set
      {
        this[this.tabletblCompanyLineInstallments.EffectiveAltFinalInstallDaysColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int ExpirationAltFinalInstallDays
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblCompanyLineInstallments.ExpirationAltFinalInstallDaysColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ExpirationAltFinalInstallDays' in table 'tblCompanyLineInstallments' is DBNull.", (Exception) ex);
        }
      }
      set
      {
        this[this.tabletblCompanyLineInstallments.ExpirationAltFinalInstallDaysColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int DayOfMonthAltFinalInstallDays
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblCompanyLineInstallments.DayOfMonthAltFinalInstallDaysColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DayOfMonthAltFinalInstallDays' in table 'tblCompanyLineInstallments' is DBNull.", (Exception) ex);
        }
      }
      set
      {
        this[this.tabletblCompanyLineInstallments.DayOfMonthAltFinalInstallDaysColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool UseMonthFinalInstallment
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tabletblCompanyLineInstallments.UseMonthFinalInstallmentColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'UseMonthFinalInstallment' in table 'tblCompanyLineInstallments' is DBNull.", (Exception) ex);
        }
      }
      set
      {
        this[this.tabletblCompanyLineInstallments.UseMonthFinalInstallmentColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool AssignRemainderFinalInstallment
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tabletblCompanyLineInstallments.AssignRemainderFinalInstallmentColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'AssignRemainderFinalInstallment' in table 'tblCompanyLineInstallments' is DBNull.", (Exception) ex);
        }
      }
      set
      {
        this[this.tabletblCompanyLineInstallments.AssignRemainderFinalInstallmentColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCompanyInstallments.tblCompanyBillingTypesRow tblCompanyBillingTypesRow
    {
      get
      {
        return (dsCompanyInstallments.tblCompanyBillingTypesRow) this.GetParentRow(this.Table.ParentRelations["tblCompanyBillingTypestblCompanyLineInstallments"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["tblCompanyBillingTypestblCompanyLineInstallments"]);
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsOptionNameNull()
    {
      return this.IsNull(this.tabletblCompanyLineInstallments.OptionNameColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetOptionNameNull()
    {
      this[this.tabletblCompanyLineInstallments.OptionNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsDownpaymentTermNull()
    {
      return this.IsNull(this.tabletblCompanyLineInstallments.DownpaymentTermColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetDownpaymentTermNull()
    {
      this[this.tabletblCompanyLineInstallments.DownpaymentTermColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsInstallmentTermsNull()
    {
      return this.IsNull(this.tabletblCompanyLineInstallments.InstallmentTermsColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetInstallmentTermsNull()
    {
      this[this.tabletblCompanyLineInstallments.InstallmentTermsColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsDownpaymentBillingTypeIDNull()
    {
      return this.IsNull(this.tabletblCompanyLineInstallments.DownpaymentBillingTypeIDColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetDownpaymentBillingTypeIDNull()
    {
      this[this.tabletblCompanyLineInstallments.DownpaymentBillingTypeIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsDisabledNull()
    {
      return this.IsNull(this.tabletblCompanyLineInstallments.DisabledColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetDisabledNull()
    {
      this[this.tabletblCompanyLineInstallments.DisabledColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsDayOfMonthNumberNull()
    {
      return this.IsNull(this.tabletblCompanyLineInstallments.DayOfMonthNumberColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetDayOfMonthNumberNull()
    {
      this[this.tabletblCompanyLineInstallments.DayOfMonthNumberColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsPolicyEffectiveInstallmentTermNull()
    {
      return this.IsNull(this.tabletblCompanyLineInstallments.PolicyEffectiveInstallmentTermColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetPolicyEffectiveInstallmentTermNull()
    {
      this[this.tabletblCompanyLineInstallments.PolicyEffectiveInstallmentTermColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsDayOfMonthInstallmentTermNull()
    {
      return this.IsNull(this.tabletblCompanyLineInstallments.DayOfMonthInstallmentTermColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetDayOfMonthInstallmentTermNull()
    {
      this[this.tabletblCompanyLineInstallments.DayOfMonthInstallmentTermColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsMonthFollowingDownPaymentNull()
    {
      return this.IsNull(this.tabletblCompanyLineInstallments.MonthFollowingDownPaymentColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetMonthFollowingDownPaymentNull()
    {
      this[this.tabletblCompanyLineInstallments.MonthFollowingDownPaymentColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsMonthFollowingDownPayment_EffNull()
    {
      return this.IsNull(this.tabletblCompanyLineInstallments.MonthFollowingDownPayment_EffColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetMonthFollowingDownPayment_EffNull()
    {
      this[this.tabletblCompanyLineInstallments.MonthFollowingDownPayment_EffColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsMonthFollowingDownPayment_Eff_DateBilledNull()
    {
      return this.IsNull(this.tabletblCompanyLineInstallments.MonthFollowingDownPayment_Eff_DateBilledColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetMonthFollowingDownPayment_Eff_DateBilledNull()
    {
      this[this.tabletblCompanyLineInstallments.MonthFollowingDownPayment_Eff_DateBilledColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsEffectiveAltFirstInstallDaysNull()
    {
      return this.IsNull(this.tabletblCompanyLineInstallments.EffectiveAltFirstInstallDaysColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetEffectiveAltFirstInstallDaysNull()
    {
      this[this.tabletblCompanyLineInstallments.EffectiveAltFirstInstallDaysColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsEffDateBilledAltFirstInstallDaysNull()
    {
      return this.IsNull(this.tabletblCompanyLineInstallments.EffDateBilledAltFirstInstallDaysColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetEffDateBilledAltFirstInstallDaysNull()
    {
      this[this.tabletblCompanyLineInstallments.EffDateBilledAltFirstInstallDaysColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsUseMonthNull()
    {
      return this.IsNull(this.tabletblCompanyLineInstallments.UseMonthColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetUseMonthNull()
    {
      this[this.tabletblCompanyLineInstallments.UseMonthColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsDayOfMonthAltFirstInstallDaysNull()
    {
      return this.IsNull(this.tabletblCompanyLineInstallments.DayOfMonthAltFirstInstallDaysColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetDayOfMonthAltFirstInstallDaysNull()
    {
      this[this.tabletblCompanyLineInstallments.DayOfMonthAltFirstInstallDaysColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsSinglePayNull()
    {
      return this.IsNull(this.tabletblCompanyLineInstallments.SinglePayColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetSinglePayNull()
    {
      this[this.tabletblCompanyLineInstallments.SinglePayColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsBillingDateDaysFromDueDateNull()
    {
      return this.IsNull(this.tabletblCompanyLineInstallments.BillingDateDaysFromDueDateColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetBillingDateDaysFromDueDateNull()
    {
      this[this.tabletblCompanyLineInstallments.BillingDateDaysFromDueDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsDownPaymentGAAPNull()
    {
      return this.IsNull(this.tabletblCompanyLineInstallments.DownPaymentGAAPColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetDownPaymentGAAPNull()
    {
      this[this.tabletblCompanyLineInstallments.DownPaymentGAAPColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsUseMonthForAltFirstInstallmentNull()
    {
      return this.IsNull(this.tabletblCompanyLineInstallments.UseMonthForAltFirstInstallmentColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetUseMonthForAltFirstInstallmentNull()
    {
      this[this.tabletblCompanyLineInstallments.UseMonthForAltFirstInstallmentColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsDownPaymentUsingBusinessDaysNull()
    {
      return this.IsNull(this.tabletblCompanyLineInstallments.DownPaymentUsingBusinessDaysColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetDownPaymentUsingBusinessDaysNull()
    {
      this[this.tabletblCompanyLineInstallments.DownPaymentUsingBusinessDaysColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsPolicyExpirationNull()
    {
      return this.IsNull(this.tabletblCompanyLineInstallments.PolicyExpirationColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetPolicyExpirationNull()
    {
      this[this.tabletblCompanyLineInstallments.PolicyExpirationColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsExpirationAltFirstInstallDaysNull()
    {
      return this.IsNull(this.tabletblCompanyLineInstallments.ExpirationAltFirstInstallDaysColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetExpirationAltFirstInstallDaysNull()
    {
      this[this.tabletblCompanyLineInstallments.ExpirationAltFirstInstallDaysColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsMonthFollowingDownPayment_ExpNull()
    {
      return this.IsNull(this.tabletblCompanyLineInstallments.MonthFollowingDownPayment_ExpColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetMonthFollowingDownPayment_ExpNull()
    {
      this[this.tabletblCompanyLineInstallments.MonthFollowingDownPayment_ExpColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsPolicyExpirationInstallmentTermNull()
    {
      return this.IsNull(this.tabletblCompanyLineInstallments.PolicyExpirationInstallmentTermColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetPolicyExpirationInstallmentTermNull()
    {
      this[this.tabletblCompanyLineInstallments.PolicyExpirationInstallmentTermColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsDownpaymentFromExpirationDateNull()
    {
      return this.IsNull(this.tabletblCompanyLineInstallments.DownpaymentFromExpirationDateColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetDownpaymentFromExpirationDateNull()
    {
      this[this.tabletblCompanyLineInstallments.DownpaymentFromExpirationDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsMinimumDownPaymentNull()
    {
      return this.IsNull(this.tabletblCompanyLineInstallments.MinimumDownPaymentColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetMinimumDownPaymentNull()
    {
      this[this.tabletblCompanyLineInstallments.MinimumDownPaymentColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsDownPaymentDayofMonthNull()
    {
      return this.IsNull(this.tabletblCompanyLineInstallments.DownPaymentDayofMonthColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetDownPaymentDayofMonthNull()
    {
      this[this.tabletblCompanyLineInstallments.DownPaymentDayofMonthColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsMinimumPremiumNull()
    {
      return this.IsNull(this.tabletblCompanyLineInstallments.MinimumPremiumColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetMinimumPremiumNull()
    {
      this[this.tabletblCompanyLineInstallments.MinimumPremiumColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsMaximumPremiumNull()
    {
      return this.IsNull(this.tabletblCompanyLineInstallments.MaximumPremiumColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetMaximumPremiumNull()
    {
      this[this.tabletblCompanyLineInstallments.MaximumPremiumColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsEffDateBilledAltFinalInstallDaysNull()
    {
      return this.IsNull(this.tabletblCompanyLineInstallments.EffDateBilledAltFinalInstallDaysColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetEffDateBilledAltFinalInstallDaysNull()
    {
      this[this.tabletblCompanyLineInstallments.EffDateBilledAltFinalInstallDaysColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsEffectiveAltFinalInstallDaysNull()
    {
      return this.IsNull(this.tabletblCompanyLineInstallments.EffectiveAltFinalInstallDaysColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetEffectiveAltFinalInstallDaysNull()
    {
      this[this.tabletblCompanyLineInstallments.EffectiveAltFinalInstallDaysColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsExpirationAltFinalInstallDaysNull()
    {
      return this.IsNull(this.tabletblCompanyLineInstallments.ExpirationAltFinalInstallDaysColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetExpirationAltFinalInstallDaysNull()
    {
      this[this.tabletblCompanyLineInstallments.ExpirationAltFinalInstallDaysColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsDayOfMonthAltFinalInstallDaysNull()
    {
      return this.IsNull(this.tabletblCompanyLineInstallments.DayOfMonthAltFinalInstallDaysColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetDayOfMonthAltFinalInstallDaysNull()
    {
      this[this.tabletblCompanyLineInstallments.DayOfMonthAltFinalInstallDaysColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsUseMonthFinalInstallmentNull()
    {
      return this.IsNull(this.tabletblCompanyLineInstallments.UseMonthFinalInstallmentColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetUseMonthFinalInstallmentNull()
    {
      this[this.tabletblCompanyLineInstallments.UseMonthFinalInstallmentColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public bool IsAssignRemainderFinalInstallmentNull()
    {
      return this.IsNull(this.tabletblCompanyLineInstallments.AssignRemainderFinalInstallmentColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public void SetAssignRemainderFinalInstallmentNull()
    {
      this[this.tabletblCompanyLineInstallments.AssignRemainderFinalInstallmentColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class tblCompanyBillingTypesRow : DataRow
  {
    private dsCompanyInstallments.tblCompanyBillingTypesDataTable tabletblCompanyBillingTypes;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    internal tblCompanyBillingTypesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblCompanyBillingTypes = (dsCompanyInstallments.tblCompanyBillingTypesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public int BillingTypeID
    {
      get => Conversions.ToInteger(this[this.tabletblCompanyBillingTypes.BillingTypeIDColumn]);
      set => this[this.tabletblCompanyBillingTypes.BillingTypeIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public string BillingType
    {
      get => Conversions.ToString(this[this.tabletblCompanyBillingTypes.BillingTypeColumn]);
      set => this[this.tabletblCompanyBillingTypes.BillingTypeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCompanyInstallments.tblCompanyLineInstallmentsRow[] GettblCompanyLineInstallmentsRows()
    {
      return this.Table.ChildRelations["tblCompanyBillingTypestblCompanyLineInstallments"] != null ? (dsCompanyInstallments.tblCompanyLineInstallmentsRow[]) this.GetChildRows(this.Table.ChildRelations["tblCompanyBillingTypestblCompanyLineInstallments"]) : new dsCompanyInstallments.tblCompanyLineInstallmentsRow[0];
    }
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class tblCompanyLineInstallmentsRowChangeEvent : EventArgs
  {
    private dsCompanyInstallments.tblCompanyLineInstallmentsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public tblCompanyLineInstallmentsRowChangeEvent(
      dsCompanyInstallments.tblCompanyLineInstallmentsRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCompanyInstallments.tblCompanyLineInstallmentsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
  public class tblCompanyBillingTypesRowChangeEvent : EventArgs
  {
    private dsCompanyInstallments.tblCompanyBillingTypesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public tblCompanyBillingTypesRowChangeEvent(
      dsCompanyInstallments.tblCompanyBillingTypesRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public dsCompanyInstallments.tblCompanyBillingTypesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }
}
