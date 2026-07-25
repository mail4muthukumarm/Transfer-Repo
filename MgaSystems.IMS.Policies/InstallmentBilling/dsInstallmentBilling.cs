// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.InstallmentBilling.dsInstallmentBilling
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
[XmlRoot("dsInstallmentBilling")]
[HelpKeyword("vs.data.DataSet")]
[Serializable]
public class dsInstallmentBilling : DataSet
{
  private dsInstallmentBilling.InvoicesDataTable tableInvoices;
  private dsInstallmentBilling.InvoiceItemsDataTable tableInvoiceItems;
  private dsInstallmentBilling.FeesDataTable tableFees;
  private dsInstallmentBilling.OfficesDataTable tableOffices;
  private dsInstallmentBilling.tblInstallmentBillingDataTable tabletblInstallmentBilling;
  private dsInstallmentBilling.tblQuoteAdditionalInterestsDataTable tabletblQuoteAdditionalInterests;
  private DataRelation relationOfficesInvoices;
  private DataRelation relationPaymentsPaymentItems;
  private SchemaSerializationMode _schemaSerializationMode;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public dsInstallmentBilling()
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
  protected dsInstallmentBilling(SerializationInfo info, StreamingContext context)
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
        if (dataSet.Tables[nameof (Invoices)] != null)
          base.Tables.Add((DataTable) new dsInstallmentBilling.InvoicesDataTable(dataSet.Tables[nameof (Invoices)]));
        if (dataSet.Tables[nameof (InvoiceItems)] != null)
          base.Tables.Add((DataTable) new dsInstallmentBilling.InvoiceItemsDataTable(dataSet.Tables[nameof (InvoiceItems)]));
        if (dataSet.Tables[nameof (Fees)] != null)
          base.Tables.Add((DataTable) new dsInstallmentBilling.FeesDataTable(dataSet.Tables[nameof (Fees)]));
        if (dataSet.Tables[nameof (Offices)] != null)
          base.Tables.Add((DataTable) new dsInstallmentBilling.OfficesDataTable(dataSet.Tables[nameof (Offices)]));
        if (dataSet.Tables[nameof (tblInstallmentBilling)] != null)
          base.Tables.Add((DataTable) new dsInstallmentBilling.tblInstallmentBillingDataTable(dataSet.Tables[nameof (tblInstallmentBilling)]));
        if (dataSet.Tables[nameof (tblQuoteAdditionalInterests)] != null)
          base.Tables.Add((DataTable) new dsInstallmentBilling.tblQuoteAdditionalInterestsDataTable(dataSet.Tables[nameof (tblQuoteAdditionalInterests)]));
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
  public dsInstallmentBilling.InvoicesDataTable Invoices => this.tableInvoices;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsInstallmentBilling.InvoiceItemsDataTable InvoiceItems => this.tableInvoiceItems;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsInstallmentBilling.FeesDataTable Fees => this.tableFees;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsInstallmentBilling.OfficesDataTable Offices => this.tableOffices;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsInstallmentBilling.tblInstallmentBillingDataTable tblInstallmentBilling
  {
    get => this.tabletblInstallmentBilling;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsInstallmentBilling.tblQuoteAdditionalInterestsDataTable tblQuoteAdditionalInterests
  {
    get => this.tabletblQuoteAdditionalInterests;
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
    dsInstallmentBilling installmentBilling = (dsInstallmentBilling) base.Clone();
    installmentBilling.InitVars();
    installmentBilling.SchemaSerializationMode = this.SchemaSerializationMode;
    return (DataSet) installmentBilling;
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
      if (dataSet.Tables["Invoices"] != null)
        base.Tables.Add((DataTable) new dsInstallmentBilling.InvoicesDataTable(dataSet.Tables["Invoices"]));
      if (dataSet.Tables["InvoiceItems"] != null)
        base.Tables.Add((DataTable) new dsInstallmentBilling.InvoiceItemsDataTable(dataSet.Tables["InvoiceItems"]));
      if (dataSet.Tables["Fees"] != null)
        base.Tables.Add((DataTable) new dsInstallmentBilling.FeesDataTable(dataSet.Tables["Fees"]));
      if (dataSet.Tables["Offices"] != null)
        base.Tables.Add((DataTable) new dsInstallmentBilling.OfficesDataTable(dataSet.Tables["Offices"]));
      if (dataSet.Tables["tblInstallmentBilling"] != null)
        base.Tables.Add((DataTable) new dsInstallmentBilling.tblInstallmentBillingDataTable(dataSet.Tables["tblInstallmentBilling"]));
      if (dataSet.Tables["tblQuoteAdditionalInterests"] != null)
        base.Tables.Add((DataTable) new dsInstallmentBilling.tblQuoteAdditionalInterestsDataTable(dataSet.Tables["tblQuoteAdditionalInterests"]));
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
    this.tableInvoices = (dsInstallmentBilling.InvoicesDataTable) base.Tables["Invoices"];
    if (initTable && this.tableInvoices != null)
      this.tableInvoices.InitVars();
    this.tableInvoiceItems = (dsInstallmentBilling.InvoiceItemsDataTable) base.Tables["InvoiceItems"];
    if (initTable && this.tableInvoiceItems != null)
      this.tableInvoiceItems.InitVars();
    this.tableFees = (dsInstallmentBilling.FeesDataTable) base.Tables["Fees"];
    if (initTable && this.tableFees != null)
      this.tableFees.InitVars();
    this.tableOffices = (dsInstallmentBilling.OfficesDataTable) base.Tables["Offices"];
    if (initTable && this.tableOffices != null)
      this.tableOffices.InitVars();
    this.tabletblInstallmentBilling = (dsInstallmentBilling.tblInstallmentBillingDataTable) base.Tables["tblInstallmentBilling"];
    if (initTable && this.tabletblInstallmentBilling != null)
      this.tabletblInstallmentBilling.InitVars();
    this.tabletblQuoteAdditionalInterests = (dsInstallmentBilling.tblQuoteAdditionalInterestsDataTable) base.Tables["tblQuoteAdditionalInterests"];
    if (initTable && this.tabletblQuoteAdditionalInterests != null)
      this.tabletblQuoteAdditionalInterests.InitVars();
    this.relationOfficesInvoices = this.Relations["OfficesInvoices"];
    this.relationPaymentsPaymentItems = this.Relations["PaymentsPaymentItems"];
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private void InitClass()
  {
    this.DataSetName = nameof (dsInstallmentBilling);
    this.Prefix = "";
    this.Namespace = "http://www.tempuri.org/dsInstallmentBilling.xsd";
    this.EnforceConstraints = true;
    this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.tableInvoices = new dsInstallmentBilling.InvoicesDataTable();
    base.Tables.Add((DataTable) this.tableInvoices);
    this.tableInvoiceItems = new dsInstallmentBilling.InvoiceItemsDataTable();
    base.Tables.Add((DataTable) this.tableInvoiceItems);
    this.tableFees = new dsInstallmentBilling.FeesDataTable();
    base.Tables.Add((DataTable) this.tableFees);
    this.tableOffices = new dsInstallmentBilling.OfficesDataTable();
    base.Tables.Add((DataTable) this.tableOffices);
    this.tabletblInstallmentBilling = new dsInstallmentBilling.tblInstallmentBillingDataTable();
    base.Tables.Add((DataTable) this.tabletblInstallmentBilling);
    this.tabletblQuoteAdditionalInterests = new dsInstallmentBilling.tblQuoteAdditionalInterestsDataTable();
    base.Tables.Add((DataTable) this.tabletblQuoteAdditionalInterests);
    ForeignKeyConstraint foreignKeyConstraint1 = new ForeignKeyConstraint("OfficesInvoices", new DataColumn[1]
    {
      this.tableOffices.OfficeIDColumn
    }, new DataColumn[1]
    {
      this.tableInvoices.OfficeIDColumn
    });
    this.tableInvoices.Constraints.Add((Constraint) foreignKeyConstraint1);
    foreignKeyConstraint1.AcceptRejectRule = AcceptRejectRule.None;
    foreignKeyConstraint1.DeleteRule = Rule.Cascade;
    foreignKeyConstraint1.UpdateRule = Rule.Cascade;
    ForeignKeyConstraint foreignKeyConstraint2 = new ForeignKeyConstraint("PaymentsPaymentItems", new DataColumn[1]
    {
      this.tableInvoices.InvoiceNumColumn
    }, new DataColumn[1]
    {
      this.tableInvoiceItems.InvoiceNumColumn
    });
    this.tableInvoiceItems.Constraints.Add((Constraint) foreignKeyConstraint2);
    foreignKeyConstraint2.AcceptRejectRule = AcceptRejectRule.None;
    foreignKeyConstraint2.DeleteRule = Rule.Cascade;
    foreignKeyConstraint2.UpdateRule = Rule.Cascade;
    this.relationOfficesInvoices = new DataRelation("OfficesInvoices", new DataColumn[1]
    {
      this.tableOffices.OfficeIDColumn
    }, new DataColumn[1]
    {
      this.tableInvoices.OfficeIDColumn
    }, false);
    this.Relations.Add(this.relationOfficesInvoices);
    this.relationPaymentsPaymentItems = new DataRelation("PaymentsPaymentItems", new DataColumn[1]
    {
      this.tableInvoices.InvoiceNumColumn
    }, new DataColumn[1]
    {
      this.tableInvoiceItems.InvoiceNumColumn
    }, false);
    this.Relations.Add(this.relationPaymentsPaymentItems);
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializeInvoices() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializeInvoiceItems() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializeFees() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializeOffices() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializetblInstallmentBilling() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializetblQuoteAdditionalInterests() => false;

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
    dsInstallmentBilling installmentBilling = new dsInstallmentBilling();
    XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
    schemaComplexType.Particle = (XmlSchemaParticle) new XmlSchemaSequence()
    {
      Items = {
        (XmlSchemaObject) new XmlSchemaAny()
        {
          Namespace = installmentBilling.Namespace
        }
      }
    };
    XmlSchema schemaSerializable = installmentBilling.GetSchemaSerializable();
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
  public delegate void InvoicesRowChangeEventHandler(
    object sender,
    dsInstallmentBilling.InvoicesRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void InvoiceItemsRowChangeEventHandler(
    object sender,
    dsInstallmentBilling.InvoiceItemsRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void FeesRowChangeEventHandler(
    object sender,
    dsInstallmentBilling.FeesRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void OfficesRowChangeEventHandler(
    object sender,
    dsInstallmentBilling.OfficesRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void tblInstallmentBillingRowChangeEventHandler(
    object sender,
    dsInstallmentBilling.tblInstallmentBillingRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void tblQuoteAdditionalInterestsRowChangeEventHandler(
    object sender,
    dsInstallmentBilling.tblQuoteAdditionalInterestsRowChangeEvent e);

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class InvoicesDataTable : TypedTableBase<dsInstallmentBilling.InvoicesRow>
  {
    private DataColumn columnInvoiceNum;
    private DataColumn columnDateDue;
    private DataColumn columnDateBilled;
    private DataColumn columnOfficeID;
    private DataColumn columnComment;
    private DataColumn columnIsDownpayment;
    private DataColumn columnBillingType;
    private DataColumn columnModifiesInvoiceNum;
    private DataColumn columnBillTo;
    private DataColumn columnAdditionalInterestID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public InvoicesDataTable()
    {
      this.TableName = "Invoices";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal InvoicesDataTable(DataTable table)
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
    protected InvoicesDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn InvoiceNumColumn => this.columnInvoiceNum;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn DateDueColumn => this.columnDateDue;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn DateBilledColumn => this.columnDateBilled;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn OfficeIDColumn => this.columnOfficeID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn CommentColumn => this.columnComment;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn IsDownpaymentColumn => this.columnIsDownpayment;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn BillingTypeColumn => this.columnBillingType;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ModifiesInvoiceNumColumn => this.columnModifiesInvoiceNum;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn BillToColumn => this.columnBillTo;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn AdditionalInterestIDColumn => this.columnAdditionalInterestID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsInstallmentBilling.InvoicesRow this[int index]
    {
      get => (dsInstallmentBilling.InvoicesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsInstallmentBilling.InvoicesRowChangeEventHandler InvoicesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsInstallmentBilling.InvoicesRowChangeEventHandler InvoicesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsInstallmentBilling.InvoicesRowChangeEventHandler InvoicesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsInstallmentBilling.InvoicesRowChangeEventHandler InvoicesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddInvoicesRow(dsInstallmentBilling.InvoicesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsInstallmentBilling.InvoicesRow AddInvoicesRow(
      int InvoiceNum,
      DateTime DateDue,
      DateTime DateBilled,
      dsInstallmentBilling.OfficesRow parentOfficesRowByOfficesInvoices,
      string Comment,
      bool IsDownpayment,
      string BillingType,
      int ModifiesInvoiceNum,
      string BillTo,
      int AdditionalInterestID)
    {
      dsInstallmentBilling.InvoicesRow row = (dsInstallmentBilling.InvoicesRow) this.NewRow();
      object[] objArray = new object[10]
      {
        (object) InvoiceNum,
        (object) DateDue,
        (object) DateBilled,
        null,
        (object) Comment,
        (object) IsDownpayment,
        (object) BillingType,
        (object) ModifiesInvoiceNum,
        (object) BillTo,
        (object) AdditionalInterestID
      };
      if (parentOfficesRowByOfficesInvoices != null)
        objArray[3] = RuntimeHelpers.GetObjectValue(parentOfficesRowByOfficesInvoices[0]);
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsInstallmentBilling.InvoicesRow FindByInvoiceNum(int InvoiceNum)
    {
      return (dsInstallmentBilling.InvoicesRow) this.Rows.Find(new object[1]
      {
        (object) InvoiceNum
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsInstallmentBilling.InvoicesDataTable invoicesDataTable = (dsInstallmentBilling.InvoicesDataTable) base.Clone();
      invoicesDataTable.InitVars();
      return (DataTable) invoicesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsInstallmentBilling.InvoicesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnInvoiceNum = this.Columns["InvoiceNum"];
      this.columnDateDue = this.Columns["DateDue"];
      this.columnDateBilled = this.Columns["DateBilled"];
      this.columnOfficeID = this.Columns["OfficeID"];
      this.columnComment = this.Columns["Comment"];
      this.columnIsDownpayment = this.Columns["IsDownpayment"];
      this.columnBillingType = this.Columns["BillingType"];
      this.columnModifiesInvoiceNum = this.Columns["ModifiesInvoiceNum"];
      this.columnBillTo = this.Columns["BillTo"];
      this.columnAdditionalInterestID = this.Columns["AdditionalInterestID"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnInvoiceNum = new DataColumn("InvoiceNum", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInvoiceNum);
      this.columnDateDue = new DataColumn("DateDue", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDateDue);
      this.columnDateBilled = new DataColumn("DateBilled", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDateBilled);
      this.columnOfficeID = new DataColumn("OfficeID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnOfficeID);
      this.columnComment = new DataColumn("Comment", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnComment);
      this.columnIsDownpayment = new DataColumn("IsDownpayment", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnIsDownpayment);
      this.columnBillingType = new DataColumn("BillingType", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnBillingType);
      this.columnModifiesInvoiceNum = new DataColumn("ModifiesInvoiceNum", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnModifiesInvoiceNum);
      this.columnBillTo = new DataColumn("BillTo", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnBillTo);
      this.columnAdditionalInterestID = new DataColumn("AdditionalInterestID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAdditionalInterestID);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsInstallmentBillingKey1", new DataColumn[1]
      {
        this.columnInvoiceNum
      }, true));
      this.columnInvoiceNum.AllowDBNull = false;
      this.columnInvoiceNum.Unique = true;
      this.columnDateBilled.AllowDBNull = false;
      this.columnOfficeID.AllowDBNull = false;
      this.columnIsDownpayment.AllowDBNull = false;
      this.columnBillingType.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsInstallmentBilling.InvoicesRow NewInvoicesRow()
    {
      return (dsInstallmentBilling.InvoicesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsInstallmentBilling.InvoicesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (dsInstallmentBilling.InvoicesRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.InvoicesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInstallmentBilling.InvoicesRowChangeEventHandler invoicesRowChangedEvent = this.InvoicesRowChangedEvent;
      if (invoicesRowChangedEvent == null)
        return;
      invoicesRowChangedEvent((object) this, new dsInstallmentBilling.InvoicesRowChangeEvent((dsInstallmentBilling.InvoicesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.InvoicesRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInstallmentBilling.InvoicesRowChangeEventHandler rowChangingEvent = this.InvoicesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsInstallmentBilling.InvoicesRowChangeEvent((dsInstallmentBilling.InvoicesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.InvoicesRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInstallmentBilling.InvoicesRowChangeEventHandler invoicesRowDeletedEvent = this.InvoicesRowDeletedEvent;
      if (invoicesRowDeletedEvent == null)
        return;
      invoicesRowDeletedEvent((object) this, new dsInstallmentBilling.InvoicesRowChangeEvent((dsInstallmentBilling.InvoicesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.InvoicesRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInstallmentBilling.InvoicesRowChangeEventHandler rowDeletingEvent = this.InvoicesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsInstallmentBilling.InvoicesRowChangeEvent((dsInstallmentBilling.InvoicesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemoveInvoicesRow(dsInstallmentBilling.InvoicesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsInstallmentBilling installmentBilling = new dsInstallmentBilling();
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
        FixedValue = installmentBilling.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (InvoicesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = installmentBilling.GetSchemaSerializable();
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
  public class InvoiceItemsDataTable : TypedTableBase<dsInstallmentBilling.InvoiceItemsRow>
  {
    private DataColumn columnInvoiceNum;
    private DataColumn columnItemType;
    private DataColumn columnAmount;
    private DataColumn columnDescription;
    private DataColumn columnModFactor;
    private DataColumn columnOptionFeeID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public InvoiceItemsDataTable()
    {
      this.TableName = "InvoiceItems";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal InvoiceItemsDataTable(DataTable table)
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
    protected InvoiceItemsDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn InvoiceNumColumn => this.columnInvoiceNum;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ItemTypeColumn => this.columnItemType;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn AmountColumn => this.columnAmount;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn DescriptionColumn => this.columnDescription;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ModFactorColumn => this.columnModFactor;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn OptionFeeIDColumn => this.columnOptionFeeID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsInstallmentBilling.InvoiceItemsRow this[int index]
    {
      get => (dsInstallmentBilling.InvoiceItemsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsInstallmentBilling.InvoiceItemsRowChangeEventHandler InvoiceItemsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsInstallmentBilling.InvoiceItemsRowChangeEventHandler InvoiceItemsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsInstallmentBilling.InvoiceItemsRowChangeEventHandler InvoiceItemsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsInstallmentBilling.InvoiceItemsRowChangeEventHandler InvoiceItemsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddInvoiceItemsRow(dsInstallmentBilling.InvoiceItemsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsInstallmentBilling.InvoiceItemsRow AddInvoiceItemsRow(
      dsInstallmentBilling.InvoicesRow parentInvoicesRowByPaymentsPaymentItems,
      string ItemType,
      Decimal Amount,
      string Description,
      Decimal ModFactor,
      int OptionFeeID)
    {
      dsInstallmentBilling.InvoiceItemsRow row = (dsInstallmentBilling.InvoiceItemsRow) this.NewRow();
      object[] objArray = new object[6]
      {
        null,
        (object) ItemType,
        (object) Amount,
        (object) Description,
        (object) ModFactor,
        (object) OptionFeeID
      };
      if (parentInvoicesRowByPaymentsPaymentItems != null)
        objArray[0] = RuntimeHelpers.GetObjectValue(parentInvoicesRowByPaymentsPaymentItems[0]);
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsInstallmentBilling.InvoiceItemsDataTable invoiceItemsDataTable = (dsInstallmentBilling.InvoiceItemsDataTable) base.Clone();
      invoiceItemsDataTable.InitVars();
      return (DataTable) invoiceItemsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsInstallmentBilling.InvoiceItemsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnInvoiceNum = this.Columns["InvoiceNum"];
      this.columnItemType = this.Columns["ItemType"];
      this.columnAmount = this.Columns["Amount"];
      this.columnDescription = this.Columns["Description"];
      this.columnModFactor = this.Columns["ModFactor"];
      this.columnOptionFeeID = this.Columns["OptionFeeID"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnInvoiceNum = new DataColumn("InvoiceNum", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInvoiceNum);
      this.columnItemType = new DataColumn("ItemType", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnItemType);
      this.columnAmount = new DataColumn("Amount", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAmount);
      this.columnDescription = new DataColumn("Description", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDescription);
      this.columnModFactor = new DataColumn("ModFactor", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnModFactor);
      this.columnOptionFeeID = new DataColumn("OptionFeeID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnOptionFeeID);
      this.columnInvoiceNum.AllowDBNull = false;
      this.columnItemType.AllowDBNull = false;
      this.columnDescription.AllowDBNull = false;
      this.columnModFactor.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsInstallmentBilling.InvoiceItemsRow NewInvoiceItemsRow()
    {
      return (dsInstallmentBilling.InvoiceItemsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsInstallmentBilling.InvoiceItemsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (dsInstallmentBilling.InvoiceItemsRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.InvoiceItemsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInstallmentBilling.InvoiceItemsRowChangeEventHandler itemsRowChangedEvent = this.InvoiceItemsRowChangedEvent;
      if (itemsRowChangedEvent == null)
        return;
      itemsRowChangedEvent((object) this, new dsInstallmentBilling.InvoiceItemsRowChangeEvent((dsInstallmentBilling.InvoiceItemsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.InvoiceItemsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInstallmentBilling.InvoiceItemsRowChangeEventHandler rowChangingEvent = this.InvoiceItemsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsInstallmentBilling.InvoiceItemsRowChangeEvent((dsInstallmentBilling.InvoiceItemsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.InvoiceItemsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInstallmentBilling.InvoiceItemsRowChangeEventHandler itemsRowDeletedEvent = this.InvoiceItemsRowDeletedEvent;
      if (itemsRowDeletedEvent == null)
        return;
      itemsRowDeletedEvent((object) this, new dsInstallmentBilling.InvoiceItemsRowChangeEvent((dsInstallmentBilling.InvoiceItemsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.InvoiceItemsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInstallmentBilling.InvoiceItemsRowChangeEventHandler rowDeletingEvent = this.InvoiceItemsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsInstallmentBilling.InvoiceItemsRowChangeEvent((dsInstallmentBilling.InvoiceItemsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemoveInvoiceItemsRow(dsInstallmentBilling.InvoiceItemsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsInstallmentBilling installmentBilling = new dsInstallmentBilling();
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
        FixedValue = installmentBilling.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (InvoiceItemsDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = installmentBilling.GetSchemaSerializable();
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
  public class FeesDataTable : TypedTableBase<dsInstallmentBilling.FeesRow>
  {
    private DataColumn columnChargeName;
    private DataColumn columnAppliesToPaymentID;
    private DataColumn columnAmount;
    private DataColumn columnOptionFeeID;
    private DataColumn columnOfficeID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public FeesDataTable()
    {
      this.TableName = "Fees";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected FeesDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ChargeNameColumn => this.columnChargeName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn AppliesToPaymentIDColumn => this.columnAppliesToPaymentID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn AmountColumn => this.columnAmount;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn OptionFeeIDColumn => this.columnOptionFeeID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn OfficeIDColumn => this.columnOfficeID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsInstallmentBilling.FeesRow this[int index]
    {
      get => (dsInstallmentBilling.FeesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsInstallmentBilling.FeesRowChangeEventHandler FeesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsInstallmentBilling.FeesRowChangeEventHandler FeesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsInstallmentBilling.FeesRowChangeEventHandler FeesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsInstallmentBilling.FeesRowChangeEventHandler FeesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddFeesRow(dsInstallmentBilling.FeesRow row) => this.Rows.Add((DataRow) row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsInstallmentBilling.FeesRow AddFeesRow(
      string ChargeName,
      string AppliesToPaymentID,
      Decimal Amount,
      int OptionFeeID,
      int OfficeID)
    {
      dsInstallmentBilling.FeesRow row = (dsInstallmentBilling.FeesRow) this.NewRow();
      object[] objArray = new object[5]
      {
        (object) ChargeName,
        (object) AppliesToPaymentID,
        (object) Amount,
        (object) OptionFeeID,
        (object) OfficeID
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsInstallmentBilling.FeesRow FindByOptionFeeID(int OptionFeeID)
    {
      return (dsInstallmentBilling.FeesRow) this.Rows.Find(new object[1]
      {
        (object) OptionFeeID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsInstallmentBilling.FeesDataTable feesDataTable = (dsInstallmentBilling.FeesDataTable) base.Clone();
      feesDataTable.InitVars();
      return (DataTable) feesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsInstallmentBilling.FeesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnChargeName = this.Columns["ChargeName"];
      this.columnAppliesToPaymentID = this.Columns["AppliesToPaymentID"];
      this.columnAmount = this.Columns["Amount"];
      this.columnOptionFeeID = this.Columns["OptionFeeID"];
      this.columnOfficeID = this.Columns["OfficeID"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnChargeName = new DataColumn("ChargeName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnChargeName);
      this.columnAppliesToPaymentID = new DataColumn("AppliesToPaymentID", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAppliesToPaymentID);
      this.columnAmount = new DataColumn("Amount", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAmount);
      this.columnOptionFeeID = new DataColumn("OptionFeeID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnOptionFeeID);
      this.columnOfficeID = new DataColumn("OfficeID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnOfficeID);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsInstallmentBillingKey3", new DataColumn[1]
      {
        this.columnOptionFeeID
      }, true));
      this.columnChargeName.AllowDBNull = false;
      this.columnAppliesToPaymentID.AllowDBNull = false;
      this.columnAmount.AllowDBNull = false;
      this.columnOptionFeeID.AllowDBNull = false;
      this.columnOptionFeeID.Unique = true;
      this.columnOfficeID.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsInstallmentBilling.FeesRow NewFeesRow()
    {
      return (dsInstallmentBilling.FeesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsInstallmentBilling.FeesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (dsInstallmentBilling.FeesRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.FeesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInstallmentBilling.FeesRowChangeEventHandler feesRowChangedEvent = this.FeesRowChangedEvent;
      if (feesRowChangedEvent == null)
        return;
      feesRowChangedEvent((object) this, new dsInstallmentBilling.FeesRowChangeEvent((dsInstallmentBilling.FeesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.FeesRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInstallmentBilling.FeesRowChangeEventHandler rowChangingEvent = this.FeesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsInstallmentBilling.FeesRowChangeEvent((dsInstallmentBilling.FeesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.FeesRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInstallmentBilling.FeesRowChangeEventHandler feesRowDeletedEvent = this.FeesRowDeletedEvent;
      if (feesRowDeletedEvent == null)
        return;
      feesRowDeletedEvent((object) this, new dsInstallmentBilling.FeesRowChangeEvent((dsInstallmentBilling.FeesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.FeesRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInstallmentBilling.FeesRowChangeEventHandler rowDeletingEvent = this.FeesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsInstallmentBilling.FeesRowChangeEvent((dsInstallmentBilling.FeesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemoveFeesRow(dsInstallmentBilling.FeesRow row) => this.Rows.Remove((DataRow) row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsInstallmentBilling installmentBilling = new dsInstallmentBilling();
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
        FixedValue = installmentBilling.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (FeesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = installmentBilling.GetSchemaSerializable();
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
  public class OfficesDataTable : TypedTableBase<dsInstallmentBilling.OfficesRow>
  {
    private DataColumn columnOfficeID;
    private DataColumn columnLocation;
    private DataColumn columnTotalPremium;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public OfficesDataTable()
    {
      this.TableName = "Offices";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal OfficesDataTable(DataTable table)
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
    protected OfficesDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn OfficeIDColumn => this.columnOfficeID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn LocationColumn => this.columnLocation;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn TotalPremiumColumn => this.columnTotalPremium;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsInstallmentBilling.OfficesRow this[int index]
    {
      get => (dsInstallmentBilling.OfficesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsInstallmentBilling.OfficesRowChangeEventHandler OfficesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsInstallmentBilling.OfficesRowChangeEventHandler OfficesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsInstallmentBilling.OfficesRowChangeEventHandler OfficesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsInstallmentBilling.OfficesRowChangeEventHandler OfficesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddOfficesRow(dsInstallmentBilling.OfficesRow row) => this.Rows.Add((DataRow) row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsInstallmentBilling.OfficesRow AddOfficesRow(
      int OfficeID,
      string Location,
      Decimal TotalPremium)
    {
      dsInstallmentBilling.OfficesRow row = (dsInstallmentBilling.OfficesRow) this.NewRow();
      object[] objArray = new object[3]
      {
        (object) OfficeID,
        (object) Location,
        (object) TotalPremium
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsInstallmentBilling.OfficesRow FindByOfficeID(int OfficeID)
    {
      return (dsInstallmentBilling.OfficesRow) this.Rows.Find(new object[1]
      {
        (object) OfficeID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsInstallmentBilling.OfficesDataTable officesDataTable = (dsInstallmentBilling.OfficesDataTable) base.Clone();
      officesDataTable.InitVars();
      return (DataTable) officesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsInstallmentBilling.OfficesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnOfficeID = this.Columns["OfficeID"];
      this.columnLocation = this.Columns["Location"];
      this.columnTotalPremium = this.Columns["TotalPremium"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnOfficeID = new DataColumn("OfficeID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnOfficeID);
      this.columnLocation = new DataColumn("Location", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLocation);
      this.columnTotalPremium = new DataColumn("TotalPremium", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnTotalPremium);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsInstallmentBillingKey2", new DataColumn[1]
      {
        this.columnOfficeID
      }, true));
      this.columnOfficeID.AllowDBNull = false;
      this.columnOfficeID.Unique = true;
      this.columnLocation.AllowDBNull = false;
      this.columnTotalPremium.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsInstallmentBilling.OfficesRow NewOfficesRow()
    {
      return (dsInstallmentBilling.OfficesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsInstallmentBilling.OfficesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (dsInstallmentBilling.OfficesRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.OfficesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInstallmentBilling.OfficesRowChangeEventHandler officesRowChangedEvent = this.OfficesRowChangedEvent;
      if (officesRowChangedEvent == null)
        return;
      officesRowChangedEvent((object) this, new dsInstallmentBilling.OfficesRowChangeEvent((dsInstallmentBilling.OfficesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.OfficesRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInstallmentBilling.OfficesRowChangeEventHandler rowChangingEvent = this.OfficesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsInstallmentBilling.OfficesRowChangeEvent((dsInstallmentBilling.OfficesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.OfficesRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInstallmentBilling.OfficesRowChangeEventHandler officesRowDeletedEvent = this.OfficesRowDeletedEvent;
      if (officesRowDeletedEvent == null)
        return;
      officesRowDeletedEvent((object) this, new dsInstallmentBilling.OfficesRowChangeEvent((dsInstallmentBilling.OfficesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.OfficesRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInstallmentBilling.OfficesRowChangeEventHandler rowDeletingEvent = this.OfficesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsInstallmentBilling.OfficesRowChangeEvent((dsInstallmentBilling.OfficesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemoveOfficesRow(dsInstallmentBilling.OfficesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsInstallmentBilling installmentBilling = new dsInstallmentBilling();
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
        FixedValue = installmentBilling.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (OfficesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = installmentBilling.GetSchemaSerializable();
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
    TypedTableBase<dsInstallmentBilling.tblInstallmentBillingRow>
  {
    private DataColumn columnQuoteOptionID;
    private DataColumn columnOfficeID;
    private DataColumn columnNumPayments;
    private DataColumn columnDownpayment;
    private DataColumn columnDownpaymentBillingTypeID;
    private DataColumn columnSingleInvoice;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblInstallmentBillingDataTable()
    {
      this.TableName = "tblInstallmentBilling";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected tblInstallmentBillingDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn QuoteOptionIDColumn => this.columnQuoteOptionID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn OfficeIDColumn => this.columnOfficeID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn NumPaymentsColumn => this.columnNumPayments;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn DownpaymentColumn => this.columnDownpayment;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn DownpaymentBillingTypeIDColumn => this.columnDownpaymentBillingTypeID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn SingleInvoiceColumn => this.columnSingleInvoice;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsInstallmentBilling.tblInstallmentBillingRow this[int index]
    {
      get => (dsInstallmentBilling.tblInstallmentBillingRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsInstallmentBilling.tblInstallmentBillingRowChangeEventHandler tblInstallmentBillingRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsInstallmentBilling.tblInstallmentBillingRowChangeEventHandler tblInstallmentBillingRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsInstallmentBilling.tblInstallmentBillingRowChangeEventHandler tblInstallmentBillingRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsInstallmentBilling.tblInstallmentBillingRowChangeEventHandler tblInstallmentBillingRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddtblInstallmentBillingRow(dsInstallmentBilling.tblInstallmentBillingRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsInstallmentBilling.tblInstallmentBillingRow AddtblInstallmentBillingRow(
      int QuoteOptionID,
      int OfficeID,
      int NumPayments,
      Decimal Downpayment,
      int DownpaymentBillingTypeID,
      bool SingleInvoice)
    {
      dsInstallmentBilling.tblInstallmentBillingRow row = (dsInstallmentBilling.tblInstallmentBillingRow) this.NewRow();
      object[] objArray = new object[6]
      {
        (object) QuoteOptionID,
        (object) OfficeID,
        (object) NumPayments,
        (object) Downpayment,
        (object) DownpaymentBillingTypeID,
        (object) SingleInvoice
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsInstallmentBilling.tblInstallmentBillingRow FindByQuoteOptionIDOfficeID(
      int QuoteOptionID,
      int OfficeID)
    {
      return (dsInstallmentBilling.tblInstallmentBillingRow) this.Rows.Find(new object[2]
      {
        (object) QuoteOptionID,
        (object) OfficeID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsInstallmentBilling.tblInstallmentBillingDataTable billingDataTable = (dsInstallmentBilling.tblInstallmentBillingDataTable) base.Clone();
      billingDataTable.InitVars();
      return (DataTable) billingDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsInstallmentBilling.tblInstallmentBillingDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnQuoteOptionID = this.Columns["QuoteOptionID"];
      this.columnOfficeID = this.Columns["OfficeID"];
      this.columnNumPayments = this.Columns["NumPayments"];
      this.columnDownpayment = this.Columns["Downpayment"];
      this.columnDownpaymentBillingTypeID = this.Columns["DownpaymentBillingTypeID"];
      this.columnSingleInvoice = this.Columns["SingleInvoice"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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
      this.columnSingleInvoice = new DataColumn("SingleInvoice", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSingleInvoice);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsInstallmentBillingKey4", new DataColumn[2]
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsInstallmentBilling.tblInstallmentBillingRow NewtblInstallmentBillingRow()
    {
      return (dsInstallmentBilling.tblInstallmentBillingRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsInstallmentBilling.tblInstallmentBillingRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (dsInstallmentBilling.tblInstallmentBillingRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblInstallmentBillingRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInstallmentBilling.tblInstallmentBillingRowChangeEventHandler billingRowChangedEvent = this.tblInstallmentBillingRowChangedEvent;
      if (billingRowChangedEvent == null)
        return;
      billingRowChangedEvent((object) this, new dsInstallmentBilling.tblInstallmentBillingRowChangeEvent((dsInstallmentBilling.tblInstallmentBillingRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblInstallmentBillingRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInstallmentBilling.tblInstallmentBillingRowChangeEventHandler rowChangingEvent = this.tblInstallmentBillingRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsInstallmentBilling.tblInstallmentBillingRowChangeEvent((dsInstallmentBilling.tblInstallmentBillingRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblInstallmentBillingRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInstallmentBilling.tblInstallmentBillingRowChangeEventHandler billingRowDeletedEvent = this.tblInstallmentBillingRowDeletedEvent;
      if (billingRowDeletedEvent == null)
        return;
      billingRowDeletedEvent((object) this, new dsInstallmentBilling.tblInstallmentBillingRowChangeEvent((dsInstallmentBilling.tblInstallmentBillingRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblInstallmentBillingRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInstallmentBilling.tblInstallmentBillingRowChangeEventHandler rowDeletingEvent = this.tblInstallmentBillingRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsInstallmentBilling.tblInstallmentBillingRowChangeEvent((dsInstallmentBilling.tblInstallmentBillingRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemovetblInstallmentBillingRow(dsInstallmentBilling.tblInstallmentBillingRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsInstallmentBilling installmentBilling = new dsInstallmentBilling();
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
        FixedValue = installmentBilling.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblInstallmentBillingDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = installmentBilling.GetSchemaSerializable();
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
  public class tblQuoteAdditionalInterestsDataTable : 
    TypedTableBase<dsInstallmentBilling.tblQuoteAdditionalInterestsRow>
  {
    private DataColumn columnID;
    private DataColumn columnInterestName;
    private DataColumn columnBillableAmount;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblQuoteAdditionalInterestsDataTable()
    {
      this.TableName = "tblQuoteAdditionalInterests";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblQuoteAdditionalInterestsDataTable(DataTable table)
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
    protected tblQuoteAdditionalInterestsDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn IDColumn => this.columnID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn InterestNameColumn => this.columnInterestName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn BillableAmountColumn => this.columnBillableAmount;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsInstallmentBilling.tblQuoteAdditionalInterestsRow this[int index]
    {
      get => (dsInstallmentBilling.tblQuoteAdditionalInterestsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsInstallmentBilling.tblQuoteAdditionalInterestsRowChangeEventHandler tblQuoteAdditionalInterestsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsInstallmentBilling.tblQuoteAdditionalInterestsRowChangeEventHandler tblQuoteAdditionalInterestsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsInstallmentBilling.tblQuoteAdditionalInterestsRowChangeEventHandler tblQuoteAdditionalInterestsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsInstallmentBilling.tblQuoteAdditionalInterestsRowChangeEventHandler tblQuoteAdditionalInterestsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddtblQuoteAdditionalInterestsRow(
      dsInstallmentBilling.tblQuoteAdditionalInterestsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsInstallmentBilling.tblQuoteAdditionalInterestsRow AddtblQuoteAdditionalInterestsRow(
      string InterestName,
      Decimal BillableAmount)
    {
      dsInstallmentBilling.tblQuoteAdditionalInterestsRow row = (dsInstallmentBilling.tblQuoteAdditionalInterestsRow) this.NewRow();
      object[] objArray = new object[3]
      {
        null,
        (object) InterestName,
        (object) BillableAmount
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsInstallmentBilling.tblQuoteAdditionalInterestsRow FindByID(int ID)
    {
      return (dsInstallmentBilling.tblQuoteAdditionalInterestsRow) this.Rows.Find(new object[1]
      {
        (object) ID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsInstallmentBilling.tblQuoteAdditionalInterestsDataTable interestsDataTable = (dsInstallmentBilling.tblQuoteAdditionalInterestsDataTable) base.Clone();
      interestsDataTable.InitVars();
      return (DataTable) interestsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsInstallmentBilling.tblQuoteAdditionalInterestsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnID = this.Columns["ID"];
      this.columnInterestName = this.Columns["InterestName"];
      this.columnBillableAmount = this.Columns["BillableAmount"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnID = new DataColumn("ID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnID);
      this.columnInterestName = new DataColumn("InterestName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInterestName);
      this.columnBillableAmount = new DataColumn("BillableAmount", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnBillableAmount);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnID
      }, true));
      this.columnID.AutoIncrement = true;
      this.columnID.AutoIncrementSeed = -1L;
      this.columnID.AutoIncrementStep = -1L;
      this.columnID.AllowDBNull = false;
      this.columnID.ReadOnly = true;
      this.columnID.Unique = true;
      this.columnInterestName.AllowDBNull = false;
      this.columnInterestName.MaxLength = 1000;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsInstallmentBilling.tblQuoteAdditionalInterestsRow NewtblQuoteAdditionalInterestsRow()
    {
      return (dsInstallmentBilling.tblQuoteAdditionalInterestsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsInstallmentBilling.tblQuoteAdditionalInterestsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType()
    {
      return typeof (dsInstallmentBilling.tblQuoteAdditionalInterestsRow);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblQuoteAdditionalInterestsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInstallmentBilling.tblQuoteAdditionalInterestsRowChangeEventHandler interestsRowChangedEvent = this.tblQuoteAdditionalInterestsRowChangedEvent;
      if (interestsRowChangedEvent == null)
        return;
      interestsRowChangedEvent((object) this, new dsInstallmentBilling.tblQuoteAdditionalInterestsRowChangeEvent((dsInstallmentBilling.tblQuoteAdditionalInterestsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblQuoteAdditionalInterestsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInstallmentBilling.tblQuoteAdditionalInterestsRowChangeEventHandler rowChangingEvent = this.tblQuoteAdditionalInterestsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsInstallmentBilling.tblQuoteAdditionalInterestsRowChangeEvent((dsInstallmentBilling.tblQuoteAdditionalInterestsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblQuoteAdditionalInterestsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInstallmentBilling.tblQuoteAdditionalInterestsRowChangeEventHandler interestsRowDeletedEvent = this.tblQuoteAdditionalInterestsRowDeletedEvent;
      if (interestsRowDeletedEvent == null)
        return;
      interestsRowDeletedEvent((object) this, new dsInstallmentBilling.tblQuoteAdditionalInterestsRowChangeEvent((dsInstallmentBilling.tblQuoteAdditionalInterestsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblQuoteAdditionalInterestsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInstallmentBilling.tblQuoteAdditionalInterestsRowChangeEventHandler rowDeletingEvent = this.tblQuoteAdditionalInterestsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsInstallmentBilling.tblQuoteAdditionalInterestsRowChangeEvent((dsInstallmentBilling.tblQuoteAdditionalInterestsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemovetblQuoteAdditionalInterestsRow(
      dsInstallmentBilling.tblQuoteAdditionalInterestsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsInstallmentBilling installmentBilling = new dsInstallmentBilling();
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
        FixedValue = installmentBilling.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblQuoteAdditionalInterestsDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = installmentBilling.GetSchemaSerializable();
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

  public class InvoicesRow : DataRow
  {
    private dsInstallmentBilling.InvoicesDataTable tableInvoices;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal InvoicesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableInvoices = (dsInstallmentBilling.InvoicesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int InvoiceNum
    {
      get => Conversions.ToInteger(this[this.tableInvoices.InvoiceNumColumn]);
      set => this[this.tableInvoices.InvoiceNumColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DateTime DateDue
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tableInvoices.DateDueColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DateDue' in table 'Invoices' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableInvoices.DateDueColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DateTime DateBilled
    {
      get => Conversions.ToDate(this[this.tableInvoices.DateBilledColumn]);
      set => this[this.tableInvoices.DateBilledColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int OfficeID
    {
      get => Conversions.ToInteger(this[this.tableInvoices.OfficeIDColumn]);
      set => this[this.tableInvoices.OfficeIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Comment
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableInvoices.CommentColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Comment' in table 'Invoices' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableInvoices.CommentColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsDownpayment
    {
      get => Conversions.ToBoolean(this[this.tableInvoices.IsDownpaymentColumn]);
      set => this[this.tableInvoices.IsDownpaymentColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string BillingType
    {
      get => Conversions.ToString(this[this.tableInvoices.BillingTypeColumn]);
      set => this[this.tableInvoices.BillingTypeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int ModifiesInvoiceNum
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tableInvoices.ModifiesInvoiceNumColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ModifiesInvoiceNum' in table 'Invoices' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableInvoices.ModifiesInvoiceNumColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string BillTo
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableInvoices.BillToColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'BillTo' in table 'Invoices' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableInvoices.BillToColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int AdditionalInterestID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tableInvoices.AdditionalInterestIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'AdditionalInterestID' in table 'Invoices' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableInvoices.AdditionalInterestIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsInstallmentBilling.OfficesRow OfficesRow
    {
      get
      {
        return (dsInstallmentBilling.OfficesRow) this.GetParentRow(this.Table.ParentRelations["OfficesInvoices"]);
      }
      set => this.SetParentRow((DataRow) value, this.Table.ParentRelations["OfficesInvoices"]);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsDateDueNull() => this.IsNull(this.tableInvoices.DateDueColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetDateDueNull()
    {
      this[this.tableInvoices.DateDueColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsCommentNull() => this.IsNull(this.tableInvoices.CommentColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetCommentNull()
    {
      this[this.tableInvoices.CommentColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsModifiesInvoiceNumNull()
    {
      return this.IsNull(this.tableInvoices.ModifiesInvoiceNumColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetModifiesInvoiceNumNull()
    {
      this[this.tableInvoices.ModifiesInvoiceNumColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsBillToNull() => this.IsNull(this.tableInvoices.BillToColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetBillToNull()
    {
      this[this.tableInvoices.BillToColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsAdditionalInterestIDNull()
    {
      return this.IsNull(this.tableInvoices.AdditionalInterestIDColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetAdditionalInterestIDNull()
    {
      this[this.tableInvoices.AdditionalInterestIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsInstallmentBilling.InvoiceItemsRow[] GetInvoiceItemsRows()
    {
      return this.Table.ChildRelations["PaymentsPaymentItems"] != null ? (dsInstallmentBilling.InvoiceItemsRow[]) this.GetChildRows(this.Table.ChildRelations["PaymentsPaymentItems"]) : new dsInstallmentBilling.InvoiceItemsRow[0];
    }
  }

  public class InvoiceItemsRow : DataRow
  {
    private dsInstallmentBilling.InvoiceItemsDataTable tableInvoiceItems;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal InvoiceItemsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableInvoiceItems = (dsInstallmentBilling.InvoiceItemsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int InvoiceNum
    {
      get => Conversions.ToInteger(this[this.tableInvoiceItems.InvoiceNumColumn]);
      set => this[this.tableInvoiceItems.InvoiceNumColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string ItemType
    {
      get => Conversions.ToString(this[this.tableInvoiceItems.ItemTypeColumn]);
      set => this[this.tableInvoiceItems.ItemTypeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal Amount
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tableInvoiceItems.AmountColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Amount' in table 'InvoiceItems' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableInvoiceItems.AmountColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Description
    {
      get => Conversions.ToString(this[this.tableInvoiceItems.DescriptionColumn]);
      set => this[this.tableInvoiceItems.DescriptionColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal ModFactor
    {
      get => Conversions.ToDecimal(this[this.tableInvoiceItems.ModFactorColumn]);
      set => this[this.tableInvoiceItems.ModFactorColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int OptionFeeID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tableInvoiceItems.OptionFeeIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'OptionFeeID' in table 'InvoiceItems' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableInvoiceItems.OptionFeeIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsInstallmentBilling.InvoicesRow InvoicesRow
    {
      get
      {
        return (dsInstallmentBilling.InvoicesRow) this.GetParentRow(this.Table.ParentRelations["PaymentsPaymentItems"]);
      }
      set => this.SetParentRow((DataRow) value, this.Table.ParentRelations["PaymentsPaymentItems"]);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsAmountNull() => this.IsNull(this.tableInvoiceItems.AmountColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetAmountNull()
    {
      this[this.tableInvoiceItems.AmountColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsOptionFeeIDNull() => this.IsNull(this.tableInvoiceItems.OptionFeeIDColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetOptionFeeIDNull()
    {
      this[this.tableInvoiceItems.OptionFeeIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class FeesRow : DataRow
  {
    private dsInstallmentBilling.FeesDataTable tableFees;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal FeesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableFees = (dsInstallmentBilling.FeesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string ChargeName
    {
      get => Conversions.ToString(this[this.tableFees.ChargeNameColumn]);
      set => this[this.tableFees.ChargeNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string AppliesToPaymentID
    {
      get => Conversions.ToString(this[this.tableFees.AppliesToPaymentIDColumn]);
      set => this[this.tableFees.AppliesToPaymentIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal Amount
    {
      get => Conversions.ToDecimal(this[this.tableFees.AmountColumn]);
      set => this[this.tableFees.AmountColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int OptionFeeID
    {
      get => Conversions.ToInteger(this[this.tableFees.OptionFeeIDColumn]);
      set => this[this.tableFees.OptionFeeIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int OfficeID
    {
      get => Conversions.ToInteger(this[this.tableFees.OfficeIDColumn]);
      set => this[this.tableFees.OfficeIDColumn] = (object) value;
    }
  }

  public class OfficesRow : DataRow
  {
    private dsInstallmentBilling.OfficesDataTable tableOffices;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal OfficesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableOffices = (dsInstallmentBilling.OfficesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int OfficeID
    {
      get => Conversions.ToInteger(this[this.tableOffices.OfficeIDColumn]);
      set => this[this.tableOffices.OfficeIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Location
    {
      get => Conversions.ToString(this[this.tableOffices.LocationColumn]);
      set => this[this.tableOffices.LocationColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal TotalPremium
    {
      get => Conversions.ToDecimal(this[this.tableOffices.TotalPremiumColumn]);
      set => this[this.tableOffices.TotalPremiumColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsInstallmentBilling.InvoicesRow[] GetInvoicesRows()
    {
      return this.Table.ChildRelations["OfficesInvoices"] != null ? (dsInstallmentBilling.InvoicesRow[]) this.GetChildRows(this.Table.ChildRelations["OfficesInvoices"]) : new dsInstallmentBilling.InvoicesRow[0];
    }
  }

  public class tblInstallmentBillingRow : DataRow
  {
    private dsInstallmentBilling.tblInstallmentBillingDataTable tabletblInstallmentBilling;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblInstallmentBillingRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblInstallmentBilling = (dsInstallmentBilling.tblInstallmentBillingDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int QuoteOptionID
    {
      get => Conversions.ToInteger(this[this.tabletblInstallmentBilling.QuoteOptionIDColumn]);
      set => this[this.tabletblInstallmentBilling.QuoteOptionIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int OfficeID
    {
      get => Conversions.ToInteger(this[this.tabletblInstallmentBilling.OfficeIDColumn]);
      set => this[this.tabletblInstallmentBilling.OfficeIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int NumPayments
    {
      get => Conversions.ToInteger(this[this.tabletblInstallmentBilling.NumPaymentsColumn]);
      set => this[this.tabletblInstallmentBilling.NumPaymentsColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal Downpayment
    {
      get => Conversions.ToDecimal(this[this.tabletblInstallmentBilling.DownpaymentColumn]);
      set => this[this.tabletblInstallmentBilling.DownpaymentColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool SingleInvoice
    {
      get => Conversions.ToBoolean(this[this.tabletblInstallmentBilling.SingleInvoiceColumn]);
      set => this[this.tabletblInstallmentBilling.SingleInvoiceColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsDownpaymentBillingTypeIDNull()
    {
      return this.IsNull(this.tabletblInstallmentBilling.DownpaymentBillingTypeIDColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetDownpaymentBillingTypeIDNull()
    {
      this[this.tabletblInstallmentBilling.DownpaymentBillingTypeIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class tblQuoteAdditionalInterestsRow : DataRow
  {
    private dsInstallmentBilling.tblQuoteAdditionalInterestsDataTable tabletblQuoteAdditionalInterests;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblQuoteAdditionalInterestsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblQuoteAdditionalInterests = (dsInstallmentBilling.tblQuoteAdditionalInterestsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int ID
    {
      get => Conversions.ToInteger(this[this.tabletblQuoteAdditionalInterests.IDColumn]);
      set => this[this.tabletblQuoteAdditionalInterests.IDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string InterestName
    {
      get => Conversions.ToString(this[this.tabletblQuoteAdditionalInterests.InterestNameColumn]);
      set => this[this.tabletblQuoteAdditionalInterests.InterestNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal BillableAmount
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tabletblQuoteAdditionalInterests.BillableAmountColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'BillableAmount' in table 'tblQuoteAdditionalInterests' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuoteAdditionalInterests.BillableAmountColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsBillableAmountNull()
    {
      return this.IsNull(this.tabletblQuoteAdditionalInterests.BillableAmountColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetBillableAmountNull()
    {
      this[this.tabletblQuoteAdditionalInterests.BillableAmountColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class InvoicesRowChangeEvent : EventArgs
  {
    private dsInstallmentBilling.InvoicesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public InvoicesRowChangeEvent(dsInstallmentBilling.InvoicesRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsInstallmentBilling.InvoicesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class InvoiceItemsRowChangeEvent : EventArgs
  {
    private dsInstallmentBilling.InvoiceItemsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public InvoiceItemsRowChangeEvent(
      dsInstallmentBilling.InvoiceItemsRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsInstallmentBilling.InvoiceItemsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class FeesRowChangeEvent : EventArgs
  {
    private dsInstallmentBilling.FeesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public FeesRowChangeEvent(dsInstallmentBilling.FeesRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsInstallmentBilling.FeesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class OfficesRowChangeEvent : EventArgs
  {
    private dsInstallmentBilling.OfficesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public OfficesRowChangeEvent(dsInstallmentBilling.OfficesRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsInstallmentBilling.OfficesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class tblInstallmentBillingRowChangeEvent : EventArgs
  {
    private dsInstallmentBilling.tblInstallmentBillingRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblInstallmentBillingRowChangeEvent(
      dsInstallmentBilling.tblInstallmentBillingRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsInstallmentBilling.tblInstallmentBillingRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class tblQuoteAdditionalInterestsRowChangeEvent : EventArgs
  {
    private dsInstallmentBilling.tblQuoteAdditionalInterestsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblQuoteAdditionalInterestsRowChangeEvent(
      dsInstallmentBilling.tblQuoteAdditionalInterestsRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsInstallmentBilling.tblQuoteAdditionalInterestsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }
}
