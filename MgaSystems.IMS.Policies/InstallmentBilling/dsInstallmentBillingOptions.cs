// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.InstallmentBilling.dsInstallmentBillingOptions
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
namespace MGASystems.IMS.Policies.InstallmentBilling;

[DesignerCategory("code")]
[ToolboxItem(true)]
[XmlSchemaProvider("GetTypedDataSetSchema")]
[XmlRoot("dsInstallmentBillingOptions")]
[HelpKeyword("vs.data.DataSet")]
[Serializable]
public class dsInstallmentBillingOptions : DataSet
{
  private dsInstallmentBillingOptions.lstBillingTypesDataTable tablelstBillingTypes;
  private dsInstallmentBillingOptions.FeesDataTable tableFees;
  private dsInstallmentBillingOptions.tblInstallmentBillingDataTable tabletblInstallmentBilling;
  private dsInstallmentBillingOptions.tblClientOfficesDataTable tabletblClientOffices;
  private dsInstallmentBillingOptions.tblCompanyLineInstallmentsDataTable tabletblCompanyLineInstallments;
  private dsInstallmentBillingOptions.lstFeeAppliesToPaymentDataTable tablelstFeeAppliesToPayment;
  private DataRelation relationlstFeeAppliesToPaymentFees;
  private DataRelation relationlstBillingTypestblInstallmentBilling;
  private DataRelation relationtblClientOfficestblInstallmentBilling;
  private SchemaSerializationMode _schemaSerializationMode;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public dsInstallmentBillingOptions()
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
  protected dsInstallmentBillingOptions(SerializationInfo info, StreamingContext context)
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
        if (dataSet.Tables[nameof (lstBillingTypes)] != null)
          base.Tables.Add((DataTable) new dsInstallmentBillingOptions.lstBillingTypesDataTable(dataSet.Tables[nameof (lstBillingTypes)]));
        if (dataSet.Tables[nameof (Fees)] != null)
          base.Tables.Add((DataTable) new dsInstallmentBillingOptions.FeesDataTable(dataSet.Tables[nameof (Fees)]));
        if (dataSet.Tables[nameof (tblInstallmentBilling)] != null)
          base.Tables.Add((DataTable) new dsInstallmentBillingOptions.tblInstallmentBillingDataTable(dataSet.Tables[nameof (tblInstallmentBilling)]));
        if (dataSet.Tables[nameof (tblClientOffices)] != null)
          base.Tables.Add((DataTable) new dsInstallmentBillingOptions.tblClientOfficesDataTable(dataSet.Tables[nameof (tblClientOffices)]));
        if (dataSet.Tables[nameof (tblCompanyLineInstallments)] != null)
          base.Tables.Add((DataTable) new dsInstallmentBillingOptions.tblCompanyLineInstallmentsDataTable(dataSet.Tables[nameof (tblCompanyLineInstallments)]));
        if (dataSet.Tables[nameof (lstFeeAppliesToPayment)] != null)
          base.Tables.Add((DataTable) new dsInstallmentBillingOptions.lstFeeAppliesToPaymentDataTable(dataSet.Tables[nameof (lstFeeAppliesToPayment)]));
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
  public dsInstallmentBillingOptions.lstBillingTypesDataTable lstBillingTypes
  {
    get => this.tablelstBillingTypes;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsInstallmentBillingOptions.FeesDataTable Fees => this.tableFees;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsInstallmentBillingOptions.tblInstallmentBillingDataTable tblInstallmentBilling
  {
    get => this.tabletblInstallmentBilling;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsInstallmentBillingOptions.tblClientOfficesDataTable tblClientOffices
  {
    get => this.tabletblClientOffices;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsInstallmentBillingOptions.tblCompanyLineInstallmentsDataTable tblCompanyLineInstallments
  {
    get => this.tabletblCompanyLineInstallments;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsInstallmentBillingOptions.lstFeeAppliesToPaymentDataTable lstFeeAppliesToPayment
  {
    get => this.tablelstFeeAppliesToPayment;
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
    dsInstallmentBillingOptions installmentBillingOptions = (dsInstallmentBillingOptions) base.Clone();
    installmentBillingOptions.InitVars();
    installmentBillingOptions.SchemaSerializationMode = this.SchemaSerializationMode;
    return (DataSet) installmentBillingOptions;
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
      if (dataSet.Tables["lstBillingTypes"] != null)
        base.Tables.Add((DataTable) new dsInstallmentBillingOptions.lstBillingTypesDataTable(dataSet.Tables["lstBillingTypes"]));
      if (dataSet.Tables["Fees"] != null)
        base.Tables.Add((DataTable) new dsInstallmentBillingOptions.FeesDataTable(dataSet.Tables["Fees"]));
      if (dataSet.Tables["tblInstallmentBilling"] != null)
        base.Tables.Add((DataTable) new dsInstallmentBillingOptions.tblInstallmentBillingDataTable(dataSet.Tables["tblInstallmentBilling"]));
      if (dataSet.Tables["tblClientOffices"] != null)
        base.Tables.Add((DataTable) new dsInstallmentBillingOptions.tblClientOfficesDataTable(dataSet.Tables["tblClientOffices"]));
      if (dataSet.Tables["tblCompanyLineInstallments"] != null)
        base.Tables.Add((DataTable) new dsInstallmentBillingOptions.tblCompanyLineInstallmentsDataTable(dataSet.Tables["tblCompanyLineInstallments"]));
      if (dataSet.Tables["lstFeeAppliesToPayment"] != null)
        base.Tables.Add((DataTable) new dsInstallmentBillingOptions.lstFeeAppliesToPaymentDataTable(dataSet.Tables["lstFeeAppliesToPayment"]));
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
    this.tablelstBillingTypes = (dsInstallmentBillingOptions.lstBillingTypesDataTable) base.Tables["lstBillingTypes"];
    if (initTable && this.tablelstBillingTypes != null)
      this.tablelstBillingTypes.InitVars();
    this.tableFees = (dsInstallmentBillingOptions.FeesDataTable) base.Tables["Fees"];
    if (initTable && this.tableFees != null)
      this.tableFees.InitVars();
    this.tabletblInstallmentBilling = (dsInstallmentBillingOptions.tblInstallmentBillingDataTable) base.Tables["tblInstallmentBilling"];
    if (initTable && this.tabletblInstallmentBilling != null)
      this.tabletblInstallmentBilling.InitVars();
    this.tabletblClientOffices = (dsInstallmentBillingOptions.tblClientOfficesDataTable) base.Tables["tblClientOffices"];
    if (initTable && this.tabletblClientOffices != null)
      this.tabletblClientOffices.InitVars();
    this.tabletblCompanyLineInstallments = (dsInstallmentBillingOptions.tblCompanyLineInstallmentsDataTable) base.Tables["tblCompanyLineInstallments"];
    if (initTable && this.tabletblCompanyLineInstallments != null)
      this.tabletblCompanyLineInstallments.InitVars();
    this.tablelstFeeAppliesToPayment = (dsInstallmentBillingOptions.lstFeeAppliesToPaymentDataTable) base.Tables["lstFeeAppliesToPayment"];
    if (initTable && this.tablelstFeeAppliesToPayment != null)
      this.tablelstFeeAppliesToPayment.InitVars();
    this.relationlstFeeAppliesToPaymentFees = this.Relations["lstFeeAppliesToPaymentFees"];
    this.relationlstBillingTypestblInstallmentBilling = this.Relations["lstBillingTypestblInstallmentBilling"];
    this.relationtblClientOfficestblInstallmentBilling = this.Relations["tblClientOfficestblInstallmentBilling"];
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private void InitClass()
  {
    this.DataSetName = nameof (dsInstallmentBillingOptions);
    this.Prefix = "";
    this.Namespace = "http://www.tempuri.org/dsInstallmentBillingOptions.xsd";
    this.EnforceConstraints = true;
    this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.tablelstBillingTypes = new dsInstallmentBillingOptions.lstBillingTypesDataTable();
    base.Tables.Add((DataTable) this.tablelstBillingTypes);
    this.tableFees = new dsInstallmentBillingOptions.FeesDataTable();
    base.Tables.Add((DataTable) this.tableFees);
    this.tabletblInstallmentBilling = new dsInstallmentBillingOptions.tblInstallmentBillingDataTable();
    base.Tables.Add((DataTable) this.tabletblInstallmentBilling);
    this.tabletblClientOffices = new dsInstallmentBillingOptions.tblClientOfficesDataTable();
    base.Tables.Add((DataTable) this.tabletblClientOffices);
    this.tabletblCompanyLineInstallments = new dsInstallmentBillingOptions.tblCompanyLineInstallmentsDataTable();
    base.Tables.Add((DataTable) this.tabletblCompanyLineInstallments);
    this.tablelstFeeAppliesToPayment = new dsInstallmentBillingOptions.lstFeeAppliesToPaymentDataTable();
    base.Tables.Add((DataTable) this.tablelstFeeAppliesToPayment);
    ForeignKeyConstraint foreignKeyConstraint1 = new ForeignKeyConstraint("lstFeeAppliesToPaymentFees", new DataColumn[1]
    {
      this.tablelstFeeAppliesToPayment.IDColumn
    }, new DataColumn[1]
    {
      this.tableFees.AppliesToPaymentIDColumn
    });
    this.tableFees.Constraints.Add((Constraint) foreignKeyConstraint1);
    foreignKeyConstraint1.AcceptRejectRule = AcceptRejectRule.None;
    foreignKeyConstraint1.DeleteRule = Rule.Cascade;
    foreignKeyConstraint1.UpdateRule = Rule.Cascade;
    ForeignKeyConstraint foreignKeyConstraint2 = new ForeignKeyConstraint("lstBillingTypestblInstallmentBilling", new DataColumn[1]
    {
      this.tablelstBillingTypes.BillingTypeIDColumn
    }, new DataColumn[1]
    {
      this.tabletblInstallmentBilling.DownpaymentBillingTypeIDColumn
    });
    this.tabletblInstallmentBilling.Constraints.Add((Constraint) foreignKeyConstraint2);
    foreignKeyConstraint2.AcceptRejectRule = AcceptRejectRule.None;
    foreignKeyConstraint2.DeleteRule = Rule.Cascade;
    foreignKeyConstraint2.UpdateRule = Rule.Cascade;
    ForeignKeyConstraint foreignKeyConstraint3 = new ForeignKeyConstraint("tblClientOfficestblInstallmentBilling", new DataColumn[1]
    {
      this.tabletblClientOffices.OfficeIDColumn
    }, new DataColumn[1]
    {
      this.tabletblInstallmentBilling.OfficeIDColumn
    });
    this.tabletblInstallmentBilling.Constraints.Add((Constraint) foreignKeyConstraint3);
    foreignKeyConstraint3.AcceptRejectRule = AcceptRejectRule.None;
    foreignKeyConstraint3.DeleteRule = Rule.Cascade;
    foreignKeyConstraint3.UpdateRule = Rule.Cascade;
    this.relationlstFeeAppliesToPaymentFees = new DataRelation("lstFeeAppliesToPaymentFees", new DataColumn[1]
    {
      this.tablelstFeeAppliesToPayment.IDColumn
    }, new DataColumn[1]
    {
      this.tableFees.AppliesToPaymentIDColumn
    }, false);
    this.Relations.Add(this.relationlstFeeAppliesToPaymentFees);
    this.relationlstBillingTypestblInstallmentBilling = new DataRelation("lstBillingTypestblInstallmentBilling", new DataColumn[1]
    {
      this.tablelstBillingTypes.BillingTypeIDColumn
    }, new DataColumn[1]
    {
      this.tabletblInstallmentBilling.DownpaymentBillingTypeIDColumn
    }, false);
    this.Relations.Add(this.relationlstBillingTypestblInstallmentBilling);
    this.relationtblClientOfficestblInstallmentBilling = new DataRelation("tblClientOfficestblInstallmentBilling", new DataColumn[1]
    {
      this.tabletblClientOffices.OfficeIDColumn
    }, new DataColumn[1]
    {
      this.tabletblInstallmentBilling.OfficeIDColumn
    }, false);
    this.Relations.Add(this.relationtblClientOfficestblInstallmentBilling);
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializelstBillingTypes() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializeFees() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializetblInstallmentBilling() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializetblClientOffices() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializetblCompanyLineInstallments() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializelstFeeAppliesToPayment() => false;

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
    dsInstallmentBillingOptions installmentBillingOptions = new dsInstallmentBillingOptions();
    XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
    schemaComplexType.Particle = (XmlSchemaParticle) new XmlSchemaSequence()
    {
      Items = {
        (XmlSchemaObject) new XmlSchemaAny()
        {
          Namespace = installmentBillingOptions.Namespace
        }
      }
    };
    XmlSchema schemaSerializable = installmentBillingOptions.GetSchemaSerializable();
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
  public delegate void lstBillingTypesRowChangeEventHandler(
    object sender,
    dsInstallmentBillingOptions.lstBillingTypesRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public delegate void FeesRowChangeEventHandler(
    object sender,
    dsInstallmentBillingOptions.FeesRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public delegate void tblInstallmentBillingRowChangeEventHandler(
    object sender,
    dsInstallmentBillingOptions.tblInstallmentBillingRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public delegate void tblClientOfficesRowChangeEventHandler(
    object sender,
    dsInstallmentBillingOptions.tblClientOfficesRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public delegate void tblCompanyLineInstallmentsRowChangeEventHandler(
    object sender,
    dsInstallmentBillingOptions.tblCompanyLineInstallmentsRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public delegate void lstFeeAppliesToPaymentRowChangeEventHandler(
    object sender,
    dsInstallmentBillingOptions.lstFeeAppliesToPaymentRowChangeEvent e);

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class lstBillingTypesDataTable : 
    TypedTableBase<dsInstallmentBillingOptions.lstBillingTypesRow>
  {
    private DataColumn columnBillingTypeID;
    private DataColumn columnBillingType;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public lstBillingTypesDataTable()
    {
      this.TableName = "lstBillingTypes";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal lstBillingTypesDataTable(DataTable table)
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
    protected lstBillingTypesDataTable(SerializationInfo info, StreamingContext context)
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
    public dsInstallmentBillingOptions.lstBillingTypesRow this[int index]
    {
      get => (dsInstallmentBillingOptions.lstBillingTypesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsInstallmentBillingOptions.lstBillingTypesRowChangeEventHandler lstBillingTypesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsInstallmentBillingOptions.lstBillingTypesRowChangeEventHandler lstBillingTypesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsInstallmentBillingOptions.lstBillingTypesRowChangeEventHandler lstBillingTypesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsInstallmentBillingOptions.lstBillingTypesRowChangeEventHandler lstBillingTypesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AddlstBillingTypesRow(dsInstallmentBillingOptions.lstBillingTypesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInstallmentBillingOptions.lstBillingTypesRow AddlstBillingTypesRow(
      int BillingTypeID,
      string BillingType)
    {
      dsInstallmentBillingOptions.lstBillingTypesRow row = (dsInstallmentBillingOptions.lstBillingTypesRow) this.NewRow();
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
    public dsInstallmentBillingOptions.lstBillingTypesRow FindByBillingTypeID(int BillingTypeID)
    {
      return (dsInstallmentBillingOptions.lstBillingTypesRow) this.Rows.Find(new object[1]
      {
        (object) BillingTypeID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsInstallmentBillingOptions.lstBillingTypesDataTable billingTypesDataTable = (dsInstallmentBillingOptions.lstBillingTypesDataTable) base.Clone();
      billingTypesDataTable.InitVars();
      return (DataTable) billingTypesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsInstallmentBillingOptions.lstBillingTypesDataTable();
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
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnBillingTypeID
      }, true));
      this.columnBillingTypeID.AllowDBNull = false;
      this.columnBillingTypeID.Unique = true;
      this.columnBillingType.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInstallmentBillingOptions.lstBillingTypesRow NewlstBillingTypesRow()
    {
      return (dsInstallmentBillingOptions.lstBillingTypesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsInstallmentBillingOptions.lstBillingTypesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType() => typeof (dsInstallmentBillingOptions.lstBillingTypesRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstBillingTypesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInstallmentBillingOptions.lstBillingTypesRowChangeEventHandler typesRowChangedEvent = this.lstBillingTypesRowChangedEvent;
      if (typesRowChangedEvent == null)
        return;
      typesRowChangedEvent((object) this, new dsInstallmentBillingOptions.lstBillingTypesRowChangeEvent((dsInstallmentBillingOptions.lstBillingTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstBillingTypesRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInstallmentBillingOptions.lstBillingTypesRowChangeEventHandler rowChangingEvent = this.lstBillingTypesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsInstallmentBillingOptions.lstBillingTypesRowChangeEvent((dsInstallmentBillingOptions.lstBillingTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstBillingTypesRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInstallmentBillingOptions.lstBillingTypesRowChangeEventHandler typesRowDeletedEvent = this.lstBillingTypesRowDeletedEvent;
      if (typesRowDeletedEvent == null)
        return;
      typesRowDeletedEvent((object) this, new dsInstallmentBillingOptions.lstBillingTypesRowChangeEvent((dsInstallmentBillingOptions.lstBillingTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstBillingTypesRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInstallmentBillingOptions.lstBillingTypesRowChangeEventHandler rowDeletingEvent = this.lstBillingTypesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsInstallmentBillingOptions.lstBillingTypesRowChangeEvent((dsInstallmentBillingOptions.lstBillingTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemovelstBillingTypesRow(dsInstallmentBillingOptions.lstBillingTypesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsInstallmentBillingOptions installmentBillingOptions = new dsInstallmentBillingOptions();
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
        FixedValue = installmentBillingOptions.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (lstBillingTypesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = installmentBillingOptions.GetSchemaSerializable();
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
  public class FeesDataTable : TypedTableBase<dsInstallmentBillingOptions.FeesRow>
  {
    private DataColumn columnCompanyLineGuid;
    private DataColumn columnQuoteOptionGuid;
    private DataColumn columnChargeCode;
    private DataColumn columnAppliesToPaymentID;
    private DataColumn columnChargeName;
    private DataColumn columnAmount;
    private DataColumn columnOfficeID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public FeesDataTable()
    {
      this.TableName = "Fees";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal FeesDataTable(DataTable table)
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
    protected FeesDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn CompanyLineGuidColumn => this.columnCompanyLineGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn QuoteOptionGuidColumn => this.columnQuoteOptionGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ChargeCodeColumn => this.columnChargeCode;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn AppliesToPaymentIDColumn => this.columnAppliesToPaymentID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ChargeNameColumn => this.columnChargeName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn AmountColumn => this.columnAmount;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn OfficeIDColumn => this.columnOfficeID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInstallmentBillingOptions.FeesRow this[int index]
    {
      get => (dsInstallmentBillingOptions.FeesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsInstallmentBillingOptions.FeesRowChangeEventHandler FeesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsInstallmentBillingOptions.FeesRowChangeEventHandler FeesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsInstallmentBillingOptions.FeesRowChangeEventHandler FeesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsInstallmentBillingOptions.FeesRowChangeEventHandler FeesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AddFeesRow(dsInstallmentBillingOptions.FeesRow row) => this.Rows.Add((DataRow) row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInstallmentBillingOptions.FeesRow AddFeesRow(
      Guid CompanyLineGuid,
      Guid QuoteOptionGuid,
      int ChargeCode,
      dsInstallmentBillingOptions.lstFeeAppliesToPaymentRow parentlstFeeAppliesToPaymentRowBylstFeeAppliesToPaymentFees,
      string ChargeName,
      Decimal Amount,
      int OfficeID)
    {
      dsInstallmentBillingOptions.FeesRow row = (dsInstallmentBillingOptions.FeesRow) this.NewRow();
      object[] objArray = new object[7]
      {
        (object) CompanyLineGuid,
        (object) QuoteOptionGuid,
        (object) ChargeCode,
        null,
        (object) ChargeName,
        (object) Amount,
        (object) OfficeID
      };
      if (parentlstFeeAppliesToPaymentRowBylstFeeAppliesToPaymentFees != null)
        objArray[3] = RuntimeHelpers.GetObjectValue(parentlstFeeAppliesToPaymentRowBylstFeeAppliesToPaymentFees[0]);
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInstallmentBillingOptions.FeesRow FindByCompanyLineGuidQuoteOptionGuidChargeCode(
      Guid CompanyLineGuid,
      Guid QuoteOptionGuid,
      int ChargeCode)
    {
      return (dsInstallmentBillingOptions.FeesRow) this.Rows.Find(new object[3]
      {
        (object) CompanyLineGuid,
        (object) QuoteOptionGuid,
        (object) ChargeCode
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsInstallmentBillingOptions.FeesDataTable feesDataTable = (dsInstallmentBillingOptions.FeesDataTable) base.Clone();
      feesDataTable.InitVars();
      return (DataTable) feesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsInstallmentBillingOptions.FeesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal void InitVars()
    {
      this.columnCompanyLineGuid = this.Columns["CompanyLineGuid"];
      this.columnQuoteOptionGuid = this.Columns["QuoteOptionGuid"];
      this.columnChargeCode = this.Columns["ChargeCode"];
      this.columnAppliesToPaymentID = this.Columns["AppliesToPaymentID"];
      this.columnChargeName = this.Columns["ChargeName"];
      this.columnAmount = this.Columns["Amount"];
      this.columnOfficeID = this.Columns["OfficeID"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.columnCompanyLineGuid = new DataColumn("CompanyLineGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCompanyLineGuid);
      this.columnQuoteOptionGuid = new DataColumn("QuoteOptionGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnQuoteOptionGuid);
      this.columnChargeCode = new DataColumn("ChargeCode", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnChargeCode);
      this.columnAppliesToPaymentID = new DataColumn("AppliesToPaymentID", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAppliesToPaymentID);
      this.columnChargeName = new DataColumn("ChargeName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnChargeName);
      this.columnAmount = new DataColumn("Amount", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAmount);
      this.columnOfficeID = new DataColumn("OfficeID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnOfficeID);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsInstallmentBillingOptionsKey1", new DataColumn[3]
      {
        this.columnCompanyLineGuid,
        this.columnQuoteOptionGuid,
        this.columnChargeCode
      }, true));
      this.columnCompanyLineGuid.AllowDBNull = false;
      this.columnQuoteOptionGuid.AllowDBNull = false;
      this.columnChargeCode.AllowDBNull = false;
      this.columnAppliesToPaymentID.AllowDBNull = false;
      this.columnChargeName.AllowDBNull = false;
      this.columnAmount.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInstallmentBillingOptions.FeesRow NewFeesRow()
    {
      return (dsInstallmentBillingOptions.FeesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsInstallmentBillingOptions.FeesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType() => typeof (dsInstallmentBillingOptions.FeesRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.FeesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInstallmentBillingOptions.FeesRowChangeEventHandler feesRowChangedEvent = this.FeesRowChangedEvent;
      if (feesRowChangedEvent == null)
        return;
      feesRowChangedEvent((object) this, new dsInstallmentBillingOptions.FeesRowChangeEvent((dsInstallmentBillingOptions.FeesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.FeesRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInstallmentBillingOptions.FeesRowChangeEventHandler rowChangingEvent = this.FeesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsInstallmentBillingOptions.FeesRowChangeEvent((dsInstallmentBillingOptions.FeesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.FeesRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInstallmentBillingOptions.FeesRowChangeEventHandler feesRowDeletedEvent = this.FeesRowDeletedEvent;
      if (feesRowDeletedEvent == null)
        return;
      feesRowDeletedEvent((object) this, new dsInstallmentBillingOptions.FeesRowChangeEvent((dsInstallmentBillingOptions.FeesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.FeesRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInstallmentBillingOptions.FeesRowChangeEventHandler rowDeletingEvent = this.FeesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsInstallmentBillingOptions.FeesRowChangeEvent((dsInstallmentBillingOptions.FeesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemoveFeesRow(dsInstallmentBillingOptions.FeesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsInstallmentBillingOptions installmentBillingOptions = new dsInstallmentBillingOptions();
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
        FixedValue = installmentBillingOptions.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (FeesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = installmentBillingOptions.GetSchemaSerializable();
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
  public class tblInstallmentBillingDataTable : 
    TypedTableBase<dsInstallmentBillingOptions.tblInstallmentBillingRow>
  {
    private DataColumn columnQuoteOptionID;
    private DataColumn columnOfficeID;
    private DataColumn columnNumPayments;
    private DataColumn columnDownpayment;
    private DataColumn columnDownpaymentBillingTypeID;
    private DataColumn columnPercentage;
    private DataColumn columnSingleInvoice;
    private DataColumn columnCompanyInstallmentID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public tblInstallmentBillingDataTable()
    {
      this.TableName = "tblInstallmentBilling";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal tblInstallmentBillingDataTable(DataTable table)
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
    protected tblInstallmentBillingDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn QuoteOptionIDColumn => this.columnQuoteOptionID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn OfficeIDColumn => this.columnOfficeID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn NumPaymentsColumn => this.columnNumPayments;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn DownpaymentColumn => this.columnDownpayment;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn DownpaymentBillingTypeIDColumn => this.columnDownpaymentBillingTypeID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn PercentageColumn => this.columnPercentage;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn SingleInvoiceColumn => this.columnSingleInvoice;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn CompanyInstallmentIDColumn => this.columnCompanyInstallmentID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInstallmentBillingOptions.tblInstallmentBillingRow this[int index]
    {
      get => (dsInstallmentBillingOptions.tblInstallmentBillingRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsInstallmentBillingOptions.tblInstallmentBillingRowChangeEventHandler tblInstallmentBillingRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsInstallmentBillingOptions.tblInstallmentBillingRowChangeEventHandler tblInstallmentBillingRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsInstallmentBillingOptions.tblInstallmentBillingRowChangeEventHandler tblInstallmentBillingRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsInstallmentBillingOptions.tblInstallmentBillingRowChangeEventHandler tblInstallmentBillingRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AddtblInstallmentBillingRow(
      dsInstallmentBillingOptions.tblInstallmentBillingRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInstallmentBillingOptions.tblInstallmentBillingRow AddtblInstallmentBillingRow(
      int QuoteOptionID,
      dsInstallmentBillingOptions.tblClientOfficesRow parenttblClientOfficesRowBytblClientOfficestblInstallmentBilling,
      int NumPayments,
      Decimal Downpayment,
      dsInstallmentBillingOptions.lstBillingTypesRow parentlstBillingTypesRowBylstBillingTypestblInstallmentBilling,
      Decimal Percentage,
      bool SingleInvoice,
      int CompanyInstallmentID)
    {
      dsInstallmentBillingOptions.tblInstallmentBillingRow row = (dsInstallmentBillingOptions.tblInstallmentBillingRow) this.NewRow();
      object[] objArray = new object[8]
      {
        (object) QuoteOptionID,
        null,
        (object) NumPayments,
        (object) Downpayment,
        null,
        (object) Percentage,
        (object) SingleInvoice,
        (object) CompanyInstallmentID
      };
      if (parenttblClientOfficesRowBytblClientOfficestblInstallmentBilling != null)
        objArray[1] = RuntimeHelpers.GetObjectValue(parenttblClientOfficesRowBytblClientOfficestblInstallmentBilling[0]);
      if (parentlstBillingTypesRowBylstBillingTypestblInstallmentBilling != null)
        objArray[4] = RuntimeHelpers.GetObjectValue(parentlstBillingTypesRowBylstBillingTypestblInstallmentBilling[0]);
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInstallmentBillingOptions.tblInstallmentBillingRow FindByQuoteOptionIDOfficeID(
      int QuoteOptionID,
      int OfficeID)
    {
      return (dsInstallmentBillingOptions.tblInstallmentBillingRow) this.Rows.Find(new object[2]
      {
        (object) QuoteOptionID,
        (object) OfficeID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsInstallmentBillingOptions.tblInstallmentBillingDataTable billingDataTable = (dsInstallmentBillingOptions.tblInstallmentBillingDataTable) base.Clone();
      billingDataTable.InitVars();
      return (DataTable) billingDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsInstallmentBillingOptions.tblInstallmentBillingDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal void InitVars()
    {
      this.columnQuoteOptionID = this.Columns["QuoteOptionID"];
      this.columnOfficeID = this.Columns["OfficeID"];
      this.columnNumPayments = this.Columns["NumPayments"];
      this.columnDownpayment = this.Columns["Downpayment"];
      this.columnDownpaymentBillingTypeID = this.Columns["DownpaymentBillingTypeID"];
      this.columnPercentage = this.Columns["Percentage"];
      this.columnSingleInvoice = this.Columns["SingleInvoice"];
      this.columnCompanyInstallmentID = this.Columns["CompanyInstallmentID"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.columnQuoteOptionID = new DataColumn("QuoteOptionID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnQuoteOptionID);
      this.columnOfficeID = new DataColumn("OfficeID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnOfficeID);
      this.columnNumPayments = new DataColumn("NumPayments", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnNumPayments);
      this.columnDownpayment = new DataColumn("Downpayment", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDownpayment);
      this.columnDownpaymentBillingTypeID = new DataColumn("DownpaymentBillingTypeID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDownpaymentBillingTypeID);
      this.columnPercentage = new DataColumn("Percentage", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPercentage);
      this.columnSingleInvoice = new DataColumn("SingleInvoice", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSingleInvoice);
      this.columnCompanyInstallmentID = new DataColumn("CompanyInstallmentID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCompanyInstallmentID);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsInstallmentBillingOptionsKey2", new DataColumn[2]
      {
        this.columnQuoteOptionID,
        this.columnOfficeID
      }, true));
      this.columnQuoteOptionID.AllowDBNull = false;
      this.columnOfficeID.AllowDBNull = false;
      this.columnNumPayments.AllowDBNull = false;
      this.columnDownpayment.AllowDBNull = false;
      this.columnSingleInvoice.AllowDBNull = false;
      this.columnSingleInvoice.DefaultValue = (object) false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInstallmentBillingOptions.tblInstallmentBillingRow NewtblInstallmentBillingRow()
    {
      return (dsInstallmentBillingOptions.tblInstallmentBillingRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsInstallmentBillingOptions.tblInstallmentBillingRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType()
    {
      return typeof (dsInstallmentBillingOptions.tblInstallmentBillingRow);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblInstallmentBillingRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInstallmentBillingOptions.tblInstallmentBillingRowChangeEventHandler billingRowChangedEvent = this.tblInstallmentBillingRowChangedEvent;
      if (billingRowChangedEvent == null)
        return;
      billingRowChangedEvent((object) this, new dsInstallmentBillingOptions.tblInstallmentBillingRowChangeEvent((dsInstallmentBillingOptions.tblInstallmentBillingRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblInstallmentBillingRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInstallmentBillingOptions.tblInstallmentBillingRowChangeEventHandler rowChangingEvent = this.tblInstallmentBillingRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsInstallmentBillingOptions.tblInstallmentBillingRowChangeEvent((dsInstallmentBillingOptions.tblInstallmentBillingRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblInstallmentBillingRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInstallmentBillingOptions.tblInstallmentBillingRowChangeEventHandler billingRowDeletedEvent = this.tblInstallmentBillingRowDeletedEvent;
      if (billingRowDeletedEvent == null)
        return;
      billingRowDeletedEvent((object) this, new dsInstallmentBillingOptions.tblInstallmentBillingRowChangeEvent((dsInstallmentBillingOptions.tblInstallmentBillingRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblInstallmentBillingRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInstallmentBillingOptions.tblInstallmentBillingRowChangeEventHandler rowDeletingEvent = this.tblInstallmentBillingRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsInstallmentBillingOptions.tblInstallmentBillingRowChangeEvent((dsInstallmentBillingOptions.tblInstallmentBillingRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemovetblInstallmentBillingRow(
      dsInstallmentBillingOptions.tblInstallmentBillingRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsInstallmentBillingOptions installmentBillingOptions = new dsInstallmentBillingOptions();
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
        FixedValue = installmentBillingOptions.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblInstallmentBillingDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = installmentBillingOptions.GetSchemaSerializable();
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
  public class tblClientOfficesDataTable : 
    TypedTableBase<dsInstallmentBillingOptions.tblClientOfficesRow>
  {
    private DataColumn columnOfficeID;
    private DataColumn columnLocation;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public tblClientOfficesDataTable()
    {
      this.TableName = "tblClientOffices";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal tblClientOfficesDataTable(DataTable table)
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
    protected tblClientOfficesDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn OfficeIDColumn => this.columnOfficeID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn LocationColumn => this.columnLocation;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInstallmentBillingOptions.tblClientOfficesRow this[int index]
    {
      get => (dsInstallmentBillingOptions.tblClientOfficesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsInstallmentBillingOptions.tblClientOfficesRowChangeEventHandler tblClientOfficesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsInstallmentBillingOptions.tblClientOfficesRowChangeEventHandler tblClientOfficesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsInstallmentBillingOptions.tblClientOfficesRowChangeEventHandler tblClientOfficesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsInstallmentBillingOptions.tblClientOfficesRowChangeEventHandler tblClientOfficesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AddtblClientOfficesRow(
      dsInstallmentBillingOptions.tblClientOfficesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInstallmentBillingOptions.tblClientOfficesRow AddtblClientOfficesRow(string Location)
    {
      dsInstallmentBillingOptions.tblClientOfficesRow row = (dsInstallmentBillingOptions.tblClientOfficesRow) this.NewRow();
      object[] objArray = new object[2]
      {
        null,
        (object) Location
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInstallmentBillingOptions.tblClientOfficesRow FindByOfficeID(int OfficeID)
    {
      return (dsInstallmentBillingOptions.tblClientOfficesRow) this.Rows.Find(new object[1]
      {
        (object) OfficeID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsInstallmentBillingOptions.tblClientOfficesDataTable officesDataTable = (dsInstallmentBillingOptions.tblClientOfficesDataTable) base.Clone();
      officesDataTable.InitVars();
      return (DataTable) officesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsInstallmentBillingOptions.tblClientOfficesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal void InitVars()
    {
      this.columnOfficeID = this.Columns["OfficeID"];
      this.columnLocation = this.Columns["Location"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.columnOfficeID = new DataColumn("OfficeID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnOfficeID);
      this.columnLocation = new DataColumn("Location", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLocation);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsInstallmentBillingOptionsKey3", new DataColumn[1]
      {
        this.columnOfficeID
      }, true));
      this.columnOfficeID.AutoIncrement = true;
      this.columnOfficeID.AllowDBNull = false;
      this.columnOfficeID.ReadOnly = true;
      this.columnOfficeID.Unique = true;
      this.columnLocation.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInstallmentBillingOptions.tblClientOfficesRow NewtblClientOfficesRow()
    {
      return (dsInstallmentBillingOptions.tblClientOfficesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsInstallmentBillingOptions.tblClientOfficesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType()
    {
      return typeof (dsInstallmentBillingOptions.tblClientOfficesRow);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblClientOfficesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInstallmentBillingOptions.tblClientOfficesRowChangeEventHandler officesRowChangedEvent = this.tblClientOfficesRowChangedEvent;
      if (officesRowChangedEvent == null)
        return;
      officesRowChangedEvent((object) this, new dsInstallmentBillingOptions.tblClientOfficesRowChangeEvent((dsInstallmentBillingOptions.tblClientOfficesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblClientOfficesRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInstallmentBillingOptions.tblClientOfficesRowChangeEventHandler rowChangingEvent = this.tblClientOfficesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsInstallmentBillingOptions.tblClientOfficesRowChangeEvent((dsInstallmentBillingOptions.tblClientOfficesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblClientOfficesRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInstallmentBillingOptions.tblClientOfficesRowChangeEventHandler officesRowDeletedEvent = this.tblClientOfficesRowDeletedEvent;
      if (officesRowDeletedEvent == null)
        return;
      officesRowDeletedEvent((object) this, new dsInstallmentBillingOptions.tblClientOfficesRowChangeEvent((dsInstallmentBillingOptions.tblClientOfficesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblClientOfficesRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInstallmentBillingOptions.tblClientOfficesRowChangeEventHandler rowDeletingEvent = this.tblClientOfficesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsInstallmentBillingOptions.tblClientOfficesRowChangeEvent((dsInstallmentBillingOptions.tblClientOfficesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemovetblClientOfficesRow(
      dsInstallmentBillingOptions.tblClientOfficesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsInstallmentBillingOptions installmentBillingOptions = new dsInstallmentBillingOptions();
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
        FixedValue = installmentBillingOptions.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblClientOfficesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = installmentBillingOptions.GetSchemaSerializable();
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
  public class tblCompanyLineInstallmentsDataTable : 
    TypedTableBase<dsInstallmentBillingOptions.tblCompanyLineInstallmentsRow>
  {
    private DataColumn columnID;
    private DataColumn columnOptionName;
    private DataColumn columnDownpaymentPercentage;
    private DataColumn columnDownpaymentTerm;
    private DataColumn columnDownpaymentBillingTypeID;
    private DataColumn columnNumPayments;
    private DataColumn columnInstallmentTerms;
    private DataColumn columnSinglePay;
    private DataColumn columnMinimumDownPayment;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public tblCompanyLineInstallmentsDataTable()
    {
      this.TableName = "tblCompanyLineInstallments";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected tblCompanyLineInstallmentsDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn IDColumn => this.columnID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn OptionNameColumn => this.columnOptionName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn DownpaymentPercentageColumn => this.columnDownpaymentPercentage;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn DownpaymentTermColumn => this.columnDownpaymentTerm;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn DownpaymentBillingTypeIDColumn => this.columnDownpaymentBillingTypeID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn NumPaymentsColumn => this.columnNumPayments;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn InstallmentTermsColumn => this.columnInstallmentTerms;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn SinglePayColumn => this.columnSinglePay;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn MinimumDownPaymentColumn => this.columnMinimumDownPayment;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInstallmentBillingOptions.tblCompanyLineInstallmentsRow this[int index]
    {
      get => (dsInstallmentBillingOptions.tblCompanyLineInstallmentsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsInstallmentBillingOptions.tblCompanyLineInstallmentsRowChangeEventHandler tblCompanyLineInstallmentsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsInstallmentBillingOptions.tblCompanyLineInstallmentsRowChangeEventHandler tblCompanyLineInstallmentsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsInstallmentBillingOptions.tblCompanyLineInstallmentsRowChangeEventHandler tblCompanyLineInstallmentsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsInstallmentBillingOptions.tblCompanyLineInstallmentsRowChangeEventHandler tblCompanyLineInstallmentsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AddtblCompanyLineInstallmentsRow(
      dsInstallmentBillingOptions.tblCompanyLineInstallmentsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInstallmentBillingOptions.tblCompanyLineInstallmentsRow AddtblCompanyLineInstallmentsRow(
      string OptionName,
      Decimal DownpaymentPercentage,
      int DownpaymentTerm,
      int DownpaymentBillingTypeID,
      int NumPayments,
      int InstallmentTerms,
      bool SinglePay,
      Decimal MinimumDownPayment)
    {
      dsInstallmentBillingOptions.tblCompanyLineInstallmentsRow row = (dsInstallmentBillingOptions.tblCompanyLineInstallmentsRow) this.NewRow();
      object[] objArray = new object[9]
      {
        null,
        (object) OptionName,
        (object) DownpaymentPercentage,
        (object) DownpaymentTerm,
        (object) DownpaymentBillingTypeID,
        (object) NumPayments,
        (object) InstallmentTerms,
        (object) SinglePay,
        (object) MinimumDownPayment
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInstallmentBillingOptions.tblCompanyLineInstallmentsRow FindByID(int ID)
    {
      return (dsInstallmentBillingOptions.tblCompanyLineInstallmentsRow) this.Rows.Find(new object[1]
      {
        (object) ID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsInstallmentBillingOptions.tblCompanyLineInstallmentsDataTable installmentsDataTable = (dsInstallmentBillingOptions.tblCompanyLineInstallmentsDataTable) base.Clone();
      installmentsDataTable.InitVars();
      return (DataTable) installmentsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsInstallmentBillingOptions.tblCompanyLineInstallmentsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal void InitVars()
    {
      this.columnID = this.Columns["ID"];
      this.columnOptionName = this.Columns["OptionName"];
      this.columnDownpaymentPercentage = this.Columns["DownpaymentPercentage"];
      this.columnDownpaymentTerm = this.Columns["DownpaymentTerm"];
      this.columnDownpaymentBillingTypeID = this.Columns["DownpaymentBillingTypeID"];
      this.columnNumPayments = this.Columns["NumPayments"];
      this.columnInstallmentTerms = this.Columns["InstallmentTerms"];
      this.columnSinglePay = this.Columns["SinglePay"];
      this.columnMinimumDownPayment = this.Columns["MinimumDownPayment"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.columnID = new DataColumn("ID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnID);
      this.columnOptionName = new DataColumn("OptionName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnOptionName);
      this.columnDownpaymentPercentage = new DataColumn("DownpaymentPercentage", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDownpaymentPercentage);
      this.columnDownpaymentTerm = new DataColumn("DownpaymentTerm", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDownpaymentTerm);
      this.columnDownpaymentBillingTypeID = new DataColumn("DownpaymentBillingTypeID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDownpaymentBillingTypeID);
      this.columnNumPayments = new DataColumn("NumPayments", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnNumPayments);
      this.columnInstallmentTerms = new DataColumn("InstallmentTerms", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInstallmentTerms);
      this.columnSinglePay = new DataColumn("SinglePay", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSinglePay);
      this.columnMinimumDownPayment = new DataColumn("MinimumDownPayment", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnMinimumDownPayment);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnID
      }, true));
      this.columnID.AutoIncrement = true;
      this.columnID.AllowDBNull = false;
      this.columnID.ReadOnly = true;
      this.columnID.Unique = true;
      this.columnOptionName.AllowDBNull = false;
      this.columnDownpaymentPercentage.AllowDBNull = false;
      this.columnDownpaymentTerm.AllowDBNull = false;
      this.columnNumPayments.AllowDBNull = false;
      this.columnSinglePay.DefaultValue = (object) false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInstallmentBillingOptions.tblCompanyLineInstallmentsRow NewtblCompanyLineInstallmentsRow()
    {
      return (dsInstallmentBillingOptions.tblCompanyLineInstallmentsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsInstallmentBillingOptions.tblCompanyLineInstallmentsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType()
    {
      return typeof (dsInstallmentBillingOptions.tblCompanyLineInstallmentsRow);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyLineInstallmentsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInstallmentBillingOptions.tblCompanyLineInstallmentsRowChangeEventHandler installmentsRowChangedEvent = this.tblCompanyLineInstallmentsRowChangedEvent;
      if (installmentsRowChangedEvent == null)
        return;
      installmentsRowChangedEvent((object) this, new dsInstallmentBillingOptions.tblCompanyLineInstallmentsRowChangeEvent((dsInstallmentBillingOptions.tblCompanyLineInstallmentsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyLineInstallmentsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInstallmentBillingOptions.tblCompanyLineInstallmentsRowChangeEventHandler rowChangingEvent = this.tblCompanyLineInstallmentsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsInstallmentBillingOptions.tblCompanyLineInstallmentsRowChangeEvent((dsInstallmentBillingOptions.tblCompanyLineInstallmentsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyLineInstallmentsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInstallmentBillingOptions.tblCompanyLineInstallmentsRowChangeEventHandler installmentsRowDeletedEvent = this.tblCompanyLineInstallmentsRowDeletedEvent;
      if (installmentsRowDeletedEvent == null)
        return;
      installmentsRowDeletedEvent((object) this, new dsInstallmentBillingOptions.tblCompanyLineInstallmentsRowChangeEvent((dsInstallmentBillingOptions.tblCompanyLineInstallmentsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCompanyLineInstallmentsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInstallmentBillingOptions.tblCompanyLineInstallmentsRowChangeEventHandler rowDeletingEvent = this.tblCompanyLineInstallmentsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsInstallmentBillingOptions.tblCompanyLineInstallmentsRowChangeEvent((dsInstallmentBillingOptions.tblCompanyLineInstallmentsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemovetblCompanyLineInstallmentsRow(
      dsInstallmentBillingOptions.tblCompanyLineInstallmentsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsInstallmentBillingOptions installmentBillingOptions = new dsInstallmentBillingOptions();
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
        FixedValue = installmentBillingOptions.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblCompanyLineInstallmentsDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = installmentBillingOptions.GetSchemaSerializable();
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
  public class lstFeeAppliesToPaymentDataTable : 
    TypedTableBase<dsInstallmentBillingOptions.lstFeeAppliesToPaymentRow>
  {
    private DataColumn columnID;
    private DataColumn columnDescription;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public lstFeeAppliesToPaymentDataTable()
    {
      this.TableName = "lstFeeAppliesToPayment";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal lstFeeAppliesToPaymentDataTable(DataTable table)
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
    protected lstFeeAppliesToPaymentDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn IDColumn => this.columnID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn DescriptionColumn => this.columnDescription;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInstallmentBillingOptions.lstFeeAppliesToPaymentRow this[int index]
    {
      get => (dsInstallmentBillingOptions.lstFeeAppliesToPaymentRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsInstallmentBillingOptions.lstFeeAppliesToPaymentRowChangeEventHandler lstFeeAppliesToPaymentRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsInstallmentBillingOptions.lstFeeAppliesToPaymentRowChangeEventHandler lstFeeAppliesToPaymentRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsInstallmentBillingOptions.lstFeeAppliesToPaymentRowChangeEventHandler lstFeeAppliesToPaymentRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsInstallmentBillingOptions.lstFeeAppliesToPaymentRowChangeEventHandler lstFeeAppliesToPaymentRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AddlstFeeAppliesToPaymentRow(
      dsInstallmentBillingOptions.lstFeeAppliesToPaymentRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInstallmentBillingOptions.lstFeeAppliesToPaymentRow AddlstFeeAppliesToPaymentRow(
      string ID,
      string Description)
    {
      dsInstallmentBillingOptions.lstFeeAppliesToPaymentRow row = (dsInstallmentBillingOptions.lstFeeAppliesToPaymentRow) this.NewRow();
      object[] objArray = new object[2]
      {
        (object) ID,
        (object) Description
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInstallmentBillingOptions.lstFeeAppliesToPaymentRow FindByID(string ID)
    {
      return (dsInstallmentBillingOptions.lstFeeAppliesToPaymentRow) this.Rows.Find(new object[1]
      {
        (object) ID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsInstallmentBillingOptions.lstFeeAppliesToPaymentDataTable paymentDataTable = (dsInstallmentBillingOptions.lstFeeAppliesToPaymentDataTable) base.Clone();
      paymentDataTable.InitVars();
      return (DataTable) paymentDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsInstallmentBillingOptions.lstFeeAppliesToPaymentDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal void InitVars()
    {
      this.columnID = this.Columns["ID"];
      this.columnDescription = this.Columns["Description"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.columnID = new DataColumn("ID", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnID);
      this.columnDescription = new DataColumn("Description", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDescription);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnID
      }, true));
      this.columnID.AllowDBNull = false;
      this.columnID.Unique = true;
      this.columnDescription.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInstallmentBillingOptions.lstFeeAppliesToPaymentRow NewlstFeeAppliesToPaymentRow()
    {
      return (dsInstallmentBillingOptions.lstFeeAppliesToPaymentRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsInstallmentBillingOptions.lstFeeAppliesToPaymentRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType()
    {
      return typeof (dsInstallmentBillingOptions.lstFeeAppliesToPaymentRow);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstFeeAppliesToPaymentRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInstallmentBillingOptions.lstFeeAppliesToPaymentRowChangeEventHandler paymentRowChangedEvent = this.lstFeeAppliesToPaymentRowChangedEvent;
      if (paymentRowChangedEvent == null)
        return;
      paymentRowChangedEvent((object) this, new dsInstallmentBillingOptions.lstFeeAppliesToPaymentRowChangeEvent((dsInstallmentBillingOptions.lstFeeAppliesToPaymentRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstFeeAppliesToPaymentRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInstallmentBillingOptions.lstFeeAppliesToPaymentRowChangeEventHandler rowChangingEvent = this.lstFeeAppliesToPaymentRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsInstallmentBillingOptions.lstFeeAppliesToPaymentRowChangeEvent((dsInstallmentBillingOptions.lstFeeAppliesToPaymentRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstFeeAppliesToPaymentRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInstallmentBillingOptions.lstFeeAppliesToPaymentRowChangeEventHandler paymentRowDeletedEvent = this.lstFeeAppliesToPaymentRowDeletedEvent;
      if (paymentRowDeletedEvent == null)
        return;
      paymentRowDeletedEvent((object) this, new dsInstallmentBillingOptions.lstFeeAppliesToPaymentRowChangeEvent((dsInstallmentBillingOptions.lstFeeAppliesToPaymentRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstFeeAppliesToPaymentRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInstallmentBillingOptions.lstFeeAppliesToPaymentRowChangeEventHandler rowDeletingEvent = this.lstFeeAppliesToPaymentRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsInstallmentBillingOptions.lstFeeAppliesToPaymentRowChangeEvent((dsInstallmentBillingOptions.lstFeeAppliesToPaymentRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemovelstFeeAppliesToPaymentRow(
      dsInstallmentBillingOptions.lstFeeAppliesToPaymentRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsInstallmentBillingOptions installmentBillingOptions = new dsInstallmentBillingOptions();
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
        FixedValue = installmentBillingOptions.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (lstFeeAppliesToPaymentDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = installmentBillingOptions.GetSchemaSerializable();
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

  public class lstBillingTypesRow : DataRow
  {
    private dsInstallmentBillingOptions.lstBillingTypesDataTable tablelstBillingTypes;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal lstBillingTypesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablelstBillingTypes = (dsInstallmentBillingOptions.lstBillingTypesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int BillingTypeID
    {
      get => Conversions.ToInteger(this[this.tablelstBillingTypes.BillingTypeIDColumn]);
      set => this[this.tablelstBillingTypes.BillingTypeIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string BillingType
    {
      get => Conversions.ToString(this[this.tablelstBillingTypes.BillingTypeColumn]);
      set => this[this.tablelstBillingTypes.BillingTypeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInstallmentBillingOptions.tblInstallmentBillingRow[] GettblInstallmentBillingRows()
    {
      return this.Table.ChildRelations["lstBillingTypestblInstallmentBilling"] != null ? (dsInstallmentBillingOptions.tblInstallmentBillingRow[]) this.GetChildRows(this.Table.ChildRelations["lstBillingTypestblInstallmentBilling"]) : new dsInstallmentBillingOptions.tblInstallmentBillingRow[0];
    }
  }

  public class FeesRow : DataRow
  {
    private dsInstallmentBillingOptions.FeesDataTable tableFees;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal FeesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableFees = (dsInstallmentBillingOptions.FeesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Guid CompanyLineGuid
    {
      get
      {
        object obj = this[this.tableFees.CompanyLineGuidColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tableFees.CompanyLineGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Guid QuoteOptionGuid
    {
      get
      {
        object obj = this[this.tableFees.QuoteOptionGuidColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tableFees.QuoteOptionGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int ChargeCode
    {
      get => Conversions.ToInteger(this[this.tableFees.ChargeCodeColumn]);
      set => this[this.tableFees.ChargeCodeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string AppliesToPaymentID
    {
      get => Conversions.ToString(this[this.tableFees.AppliesToPaymentIDColumn]);
      set => this[this.tableFees.AppliesToPaymentIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string ChargeName
    {
      get => Conversions.ToString(this[this.tableFees.ChargeNameColumn]);
      set => this[this.tableFees.ChargeNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Decimal Amount
    {
      get => Conversions.ToDecimal(this[this.tableFees.AmountColumn]);
      set => this[this.tableFees.AmountColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int OfficeID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tableFees.OfficeIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'OfficeID' in table 'Fees' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableFees.OfficeIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInstallmentBillingOptions.lstFeeAppliesToPaymentRow lstFeeAppliesToPaymentRow
    {
      get
      {
        return (dsInstallmentBillingOptions.lstFeeAppliesToPaymentRow) this.GetParentRow(this.Table.ParentRelations["lstFeeAppliesToPaymentFees"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["lstFeeAppliesToPaymentFees"]);
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsOfficeIDNull() => this.IsNull(this.tableFees.OfficeIDColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetOfficeIDNull()
    {
      this[this.tableFees.OfficeIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class tblInstallmentBillingRow : DataRow
  {
    private dsInstallmentBillingOptions.tblInstallmentBillingDataTable tabletblInstallmentBilling;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal tblInstallmentBillingRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblInstallmentBilling = (dsInstallmentBillingOptions.tblInstallmentBillingDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int QuoteOptionID
    {
      get => Conversions.ToInteger(this[this.tabletblInstallmentBilling.QuoteOptionIDColumn]);
      set => this[this.tabletblInstallmentBilling.QuoteOptionIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int OfficeID
    {
      get => Conversions.ToInteger(this[this.tabletblInstallmentBilling.OfficeIDColumn]);
      set => this[this.tabletblInstallmentBilling.OfficeIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int NumPayments
    {
      get => Conversions.ToInteger(this[this.tabletblInstallmentBilling.NumPaymentsColumn]);
      set => this[this.tabletblInstallmentBilling.NumPaymentsColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Decimal Downpayment
    {
      get => Conversions.ToDecimal(this[this.tabletblInstallmentBilling.DownpaymentColumn]);
      set => this[this.tabletblInstallmentBilling.DownpaymentColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int DownpaymentBillingTypeID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblInstallmentBilling.DownpaymentBillingTypeIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DownpaymentBillingTypeID' in table 'tblInstallmentBilling' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblInstallmentBilling.DownpaymentBillingTypeIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Decimal Percentage
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tabletblInstallmentBilling.PercentageColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Percentage' in table 'tblInstallmentBilling' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblInstallmentBilling.PercentageColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool SingleInvoice
    {
      get => Conversions.ToBoolean(this[this.tabletblInstallmentBilling.SingleInvoiceColumn]);
      set => this[this.tabletblInstallmentBilling.SingleInvoiceColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int CompanyInstallmentID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblInstallmentBilling.CompanyInstallmentIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'CompanyInstallmentID' in table 'tblInstallmentBilling' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblInstallmentBilling.CompanyInstallmentIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInstallmentBillingOptions.lstBillingTypesRow lstBillingTypesRow
    {
      get
      {
        return (dsInstallmentBillingOptions.lstBillingTypesRow) this.GetParentRow(this.Table.ParentRelations["lstBillingTypestblInstallmentBilling"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["lstBillingTypestblInstallmentBilling"]);
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInstallmentBillingOptions.tblClientOfficesRow tblClientOfficesRow
    {
      get
      {
        return (dsInstallmentBillingOptions.tblClientOfficesRow) this.GetParentRow(this.Table.ParentRelations["tblClientOfficestblInstallmentBilling"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["tblClientOfficestblInstallmentBilling"]);
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsDownpaymentBillingTypeIDNull()
    {
      return this.IsNull(this.tabletblInstallmentBilling.DownpaymentBillingTypeIDColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetDownpaymentBillingTypeIDNull()
    {
      this[this.tabletblInstallmentBilling.DownpaymentBillingTypeIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsPercentageNull() => this.IsNull(this.tabletblInstallmentBilling.PercentageColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetPercentageNull()
    {
      this[this.tabletblInstallmentBilling.PercentageColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsCompanyInstallmentIDNull()
    {
      return this.IsNull(this.tabletblInstallmentBilling.CompanyInstallmentIDColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetCompanyInstallmentIDNull()
    {
      this[this.tabletblInstallmentBilling.CompanyInstallmentIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class tblClientOfficesRow : DataRow
  {
    private dsInstallmentBillingOptions.tblClientOfficesDataTable tabletblClientOffices;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal tblClientOfficesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblClientOffices = (dsInstallmentBillingOptions.tblClientOfficesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int OfficeID
    {
      get => Conversions.ToInteger(this[this.tabletblClientOffices.OfficeIDColumn]);
      set => this[this.tabletblClientOffices.OfficeIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string Location
    {
      get => Conversions.ToString(this[this.tabletblClientOffices.LocationColumn]);
      set => this[this.tabletblClientOffices.LocationColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInstallmentBillingOptions.tblInstallmentBillingRow[] GettblInstallmentBillingRows()
    {
      return this.Table.ChildRelations["tblClientOfficestblInstallmentBilling"] != null ? (dsInstallmentBillingOptions.tblInstallmentBillingRow[]) this.GetChildRows(this.Table.ChildRelations["tblClientOfficestblInstallmentBilling"]) : new dsInstallmentBillingOptions.tblInstallmentBillingRow[0];
    }
  }

  public class tblCompanyLineInstallmentsRow : DataRow
  {
    private dsInstallmentBillingOptions.tblCompanyLineInstallmentsDataTable tabletblCompanyLineInstallments;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal tblCompanyLineInstallmentsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblCompanyLineInstallments = (dsInstallmentBillingOptions.tblCompanyLineInstallmentsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int ID
    {
      get => Conversions.ToInteger(this[this.tabletblCompanyLineInstallments.IDColumn]);
      set => this[this.tabletblCompanyLineInstallments.IDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string OptionName
    {
      get => Conversions.ToString(this[this.tabletblCompanyLineInstallments.OptionNameColumn]);
      set => this[this.tabletblCompanyLineInstallments.OptionNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int DownpaymentTerm
    {
      get
      {
        return Conversions.ToInteger(this[this.tabletblCompanyLineInstallments.DownpaymentTermColumn]);
      }
      set => this[this.tabletblCompanyLineInstallments.DownpaymentTermColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int NumPayments
    {
      get => Conversions.ToInteger(this[this.tabletblCompanyLineInstallments.NumPaymentsColumn]);
      set => this[this.tabletblCompanyLineInstallments.NumPaymentsColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsDownpaymentBillingTypeIDNull()
    {
      return this.IsNull(this.tabletblCompanyLineInstallments.DownpaymentBillingTypeIDColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetDownpaymentBillingTypeIDNull()
    {
      this[this.tabletblCompanyLineInstallments.DownpaymentBillingTypeIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsInstallmentTermsNull()
    {
      return this.IsNull(this.tabletblCompanyLineInstallments.InstallmentTermsColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetInstallmentTermsNull()
    {
      this[this.tabletblCompanyLineInstallments.InstallmentTermsColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsSinglePayNull()
    {
      return this.IsNull(this.tabletblCompanyLineInstallments.SinglePayColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetSinglePayNull()
    {
      this[this.tabletblCompanyLineInstallments.SinglePayColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsMinimumDownPaymentNull()
    {
      return this.IsNull(this.tabletblCompanyLineInstallments.MinimumDownPaymentColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetMinimumDownPaymentNull()
    {
      this[this.tabletblCompanyLineInstallments.MinimumDownPaymentColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class lstFeeAppliesToPaymentRow : DataRow
  {
    private dsInstallmentBillingOptions.lstFeeAppliesToPaymentDataTable tablelstFeeAppliesToPayment;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal lstFeeAppliesToPaymentRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablelstFeeAppliesToPayment = (dsInstallmentBillingOptions.lstFeeAppliesToPaymentDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string ID
    {
      get => Conversions.ToString(this[this.tablelstFeeAppliesToPayment.IDColumn]);
      set => this[this.tablelstFeeAppliesToPayment.IDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string Description
    {
      get => Conversions.ToString(this[this.tablelstFeeAppliesToPayment.DescriptionColumn]);
      set => this[this.tablelstFeeAppliesToPayment.DescriptionColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInstallmentBillingOptions.FeesRow[] GetFeesRows()
    {
      return this.Table.ChildRelations["lstFeeAppliesToPaymentFees"] != null ? (dsInstallmentBillingOptions.FeesRow[]) this.GetChildRows(this.Table.ChildRelations["lstFeeAppliesToPaymentFees"]) : new dsInstallmentBillingOptions.FeesRow[0];
    }
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class lstBillingTypesRowChangeEvent : EventArgs
  {
    private dsInstallmentBillingOptions.lstBillingTypesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public lstBillingTypesRowChangeEvent(
      dsInstallmentBillingOptions.lstBillingTypesRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInstallmentBillingOptions.lstBillingTypesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class FeesRowChangeEvent : EventArgs
  {
    private dsInstallmentBillingOptions.FeesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public FeesRowChangeEvent(dsInstallmentBillingOptions.FeesRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInstallmentBillingOptions.FeesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class tblInstallmentBillingRowChangeEvent : EventArgs
  {
    private dsInstallmentBillingOptions.tblInstallmentBillingRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public tblInstallmentBillingRowChangeEvent(
      dsInstallmentBillingOptions.tblInstallmentBillingRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInstallmentBillingOptions.tblInstallmentBillingRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class tblClientOfficesRowChangeEvent : EventArgs
  {
    private dsInstallmentBillingOptions.tblClientOfficesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public tblClientOfficesRowChangeEvent(
      dsInstallmentBillingOptions.tblClientOfficesRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInstallmentBillingOptions.tblClientOfficesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class tblCompanyLineInstallmentsRowChangeEvent : EventArgs
  {
    private dsInstallmentBillingOptions.tblCompanyLineInstallmentsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public tblCompanyLineInstallmentsRowChangeEvent(
      dsInstallmentBillingOptions.tblCompanyLineInstallmentsRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInstallmentBillingOptions.tblCompanyLineInstallmentsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class lstFeeAppliesToPaymentRowChangeEvent : EventArgs
  {
    private dsInstallmentBillingOptions.lstFeeAppliesToPaymentRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public lstFeeAppliesToPaymentRowChangeEvent(
      dsInstallmentBillingOptions.lstFeeAppliesToPaymentRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInstallmentBillingOptions.lstFeeAppliesToPaymentRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }
}
