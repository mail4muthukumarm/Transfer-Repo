// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.AccountingDatasets.dsViewTransaction
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
[XmlRoot("dsViewTransaction")]
[HelpKeyword("vs.data.DataSet")]
[Serializable]
public class dsViewTransaction : DataSet
{
  private dsViewTransaction.TransactionHeaderDataTable tableTransactionHeader;
  private dsViewTransaction.DistributionsDataTable tableDistributions;
  private dsViewTransaction.AffectedInvoicesDataTable tableAffectedInvoices;
  private dsViewTransaction.VerbageDataTable tableVerbage;
  private dsViewTransaction.POExpenseDataTable tablePOExpense;
  private dsViewTransaction.CommissionsDataTable tableCommissions;
  private dsViewTransaction.SummaryDataTable tableSummary;
  private SchemaSerializationMode _schemaSerializationMode;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public dsViewTransaction()
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
  protected dsViewTransaction(SerializationInfo info, StreamingContext context)
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
        if (dataSet.Tables[nameof (TransactionHeader)] != null)
          base.Tables.Add((DataTable) new dsViewTransaction.TransactionHeaderDataTable(dataSet.Tables[nameof (TransactionHeader)]));
        if (dataSet.Tables[nameof (Distributions)] != null)
          base.Tables.Add((DataTable) new dsViewTransaction.DistributionsDataTable(dataSet.Tables[nameof (Distributions)]));
        if (dataSet.Tables[nameof (AffectedInvoices)] != null)
          base.Tables.Add((DataTable) new dsViewTransaction.AffectedInvoicesDataTable(dataSet.Tables[nameof (AffectedInvoices)]));
        if (dataSet.Tables[nameof (Verbage)] != null)
          base.Tables.Add((DataTable) new dsViewTransaction.VerbageDataTable(dataSet.Tables[nameof (Verbage)]));
        if (dataSet.Tables[nameof (POExpense)] != null)
          base.Tables.Add((DataTable) new dsViewTransaction.POExpenseDataTable(dataSet.Tables[nameof (POExpense)]));
        if (dataSet.Tables[nameof (Commissions)] != null)
          base.Tables.Add((DataTable) new dsViewTransaction.CommissionsDataTable(dataSet.Tables[nameof (Commissions)]));
        if (dataSet.Tables[nameof (Summary)] != null)
          base.Tables.Add((DataTable) new dsViewTransaction.SummaryDataTable(dataSet.Tables[nameof (Summary)]));
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
  public dsViewTransaction.TransactionHeaderDataTable TransactionHeader
  {
    get => this.tableTransactionHeader;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsViewTransaction.DistributionsDataTable Distributions => this.tableDistributions;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsViewTransaction.AffectedInvoicesDataTable AffectedInvoices => this.tableAffectedInvoices;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsViewTransaction.VerbageDataTable Verbage => this.tableVerbage;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsViewTransaction.POExpenseDataTable POExpense => this.tablePOExpense;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsViewTransaction.CommissionsDataTable Commissions => this.tableCommissions;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsViewTransaction.SummaryDataTable Summary => this.tableSummary;

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
    dsViewTransaction dsViewTransaction = (dsViewTransaction) base.Clone();
    dsViewTransaction.InitVars();
    dsViewTransaction.SchemaSerializationMode = this.SchemaSerializationMode;
    return (DataSet) dsViewTransaction;
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
      if (dataSet.Tables["TransactionHeader"] != null)
        base.Tables.Add((DataTable) new dsViewTransaction.TransactionHeaderDataTable(dataSet.Tables["TransactionHeader"]));
      if (dataSet.Tables["Distributions"] != null)
        base.Tables.Add((DataTable) new dsViewTransaction.DistributionsDataTable(dataSet.Tables["Distributions"]));
      if (dataSet.Tables["AffectedInvoices"] != null)
        base.Tables.Add((DataTable) new dsViewTransaction.AffectedInvoicesDataTable(dataSet.Tables["AffectedInvoices"]));
      if (dataSet.Tables["Verbage"] != null)
        base.Tables.Add((DataTable) new dsViewTransaction.VerbageDataTable(dataSet.Tables["Verbage"]));
      if (dataSet.Tables["POExpense"] != null)
        base.Tables.Add((DataTable) new dsViewTransaction.POExpenseDataTable(dataSet.Tables["POExpense"]));
      if (dataSet.Tables["Commissions"] != null)
        base.Tables.Add((DataTable) new dsViewTransaction.CommissionsDataTable(dataSet.Tables["Commissions"]));
      if (dataSet.Tables["Summary"] != null)
        base.Tables.Add((DataTable) new dsViewTransaction.SummaryDataTable(dataSet.Tables["Summary"]));
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
    this.tableTransactionHeader = (dsViewTransaction.TransactionHeaderDataTable) base.Tables["TransactionHeader"];
    if (initTable && this.tableTransactionHeader != null)
      this.tableTransactionHeader.InitVars();
    this.tableDistributions = (dsViewTransaction.DistributionsDataTable) base.Tables["Distributions"];
    if (initTable && this.tableDistributions != null)
      this.tableDistributions.InitVars();
    this.tableAffectedInvoices = (dsViewTransaction.AffectedInvoicesDataTable) base.Tables["AffectedInvoices"];
    if (initTable && this.tableAffectedInvoices != null)
      this.tableAffectedInvoices.InitVars();
    this.tableVerbage = (dsViewTransaction.VerbageDataTable) base.Tables["Verbage"];
    if (initTable && this.tableVerbage != null)
      this.tableVerbage.InitVars();
    this.tablePOExpense = (dsViewTransaction.POExpenseDataTable) base.Tables["POExpense"];
    if (initTable && this.tablePOExpense != null)
      this.tablePOExpense.InitVars();
    this.tableCommissions = (dsViewTransaction.CommissionsDataTable) base.Tables["Commissions"];
    if (initTable && this.tableCommissions != null)
      this.tableCommissions.InitVars();
    this.tableSummary = (dsViewTransaction.SummaryDataTable) base.Tables["Summary"];
    if (!initTable || this.tableSummary == null)
      return;
    this.tableSummary.InitVars();
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private void InitClass()
  {
    this.DataSetName = nameof (dsViewTransaction);
    this.Prefix = "";
    this.Namespace = "http://tempuri.org/dsViewTransaction.xsd";
    this.EnforceConstraints = true;
    this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.tableTransactionHeader = new dsViewTransaction.TransactionHeaderDataTable();
    base.Tables.Add((DataTable) this.tableTransactionHeader);
    this.tableDistributions = new dsViewTransaction.DistributionsDataTable();
    base.Tables.Add((DataTable) this.tableDistributions);
    this.tableAffectedInvoices = new dsViewTransaction.AffectedInvoicesDataTable();
    base.Tables.Add((DataTable) this.tableAffectedInvoices);
    this.tableVerbage = new dsViewTransaction.VerbageDataTable();
    base.Tables.Add((DataTable) this.tableVerbage);
    this.tablePOExpense = new dsViewTransaction.POExpenseDataTable();
    base.Tables.Add((DataTable) this.tablePOExpense);
    this.tableCommissions = new dsViewTransaction.CommissionsDataTable();
    base.Tables.Add((DataTable) this.tableCommissions);
    this.tableSummary = new dsViewTransaction.SummaryDataTable();
    base.Tables.Add((DataTable) this.tableSummary);
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializeTransactionHeader() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializeDistributions() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializeAffectedInvoices() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializeVerbage() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializePOExpense() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializeCommissions() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializeSummary() => false;

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
    dsViewTransaction dsViewTransaction = new dsViewTransaction();
    XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
    schemaComplexType.Particle = (XmlSchemaParticle) new XmlSchemaSequence()
    {
      Items = {
        (XmlSchemaObject) new XmlSchemaAny()
        {
          Namespace = dsViewTransaction.Namespace
        }
      }
    };
    XmlSchema schemaSerializable = dsViewTransaction.GetSchemaSerializable();
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
  public delegate void TransactionHeaderRowChangeEventHandler(
    object sender,
    dsViewTransaction.TransactionHeaderRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void DistributionsRowChangeEventHandler(
    object sender,
    dsViewTransaction.DistributionsRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void AffectedInvoicesRowChangeEventHandler(
    object sender,
    dsViewTransaction.AffectedInvoicesRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void VerbageRowChangeEventHandler(
    object sender,
    dsViewTransaction.VerbageRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void POExpenseRowChangeEventHandler(
    object sender,
    dsViewTransaction.POExpenseRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void CommissionsRowChangeEventHandler(
    object sender,
    dsViewTransaction.CommissionsRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void SummaryRowChangeEventHandler(
    object sender,
    dsViewTransaction.SummaryRowChangeEvent e);

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class TransactionHeaderDataTable : TypedTableBase<dsViewTransaction.TransactionHeaderRow>
  {
    private DataColumn columntransactNum;
    private DataColumn columnpostDate;
    private DataColumn columntransDescription;
    private DataColumn columnUser;
    private DataColumn columnComments;
    private DataColumn columnPayeeRemitter;
    private DataColumn columnVoidTransaction;
    private DataColumn columnReceivedDate;
    private DataColumn columnCheckNumber;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public TransactionHeaderDataTable()
    {
      this.TableName = "TransactionHeader";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal TransactionHeaderDataTable(DataTable table)
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
    protected TransactionHeaderDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn transactNumColumn => this.columntransactNum;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn postDateColumn => this.columnpostDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn transDescriptionColumn => this.columntransDescription;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn UserColumn => this.columnUser;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn CommentsColumn => this.columnComments;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn PayeeRemitterColumn => this.columnPayeeRemitter;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn VoidTransactionColumn => this.columnVoidTransaction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ReceivedDateColumn => this.columnReceivedDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn CheckNumberColumn => this.columnCheckNumber;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsViewTransaction.TransactionHeaderRow this[int index]
    {
      get => (dsViewTransaction.TransactionHeaderRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsViewTransaction.TransactionHeaderRowChangeEventHandler TransactionHeaderRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsViewTransaction.TransactionHeaderRowChangeEventHandler TransactionHeaderRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsViewTransaction.TransactionHeaderRowChangeEventHandler TransactionHeaderRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsViewTransaction.TransactionHeaderRowChangeEventHandler TransactionHeaderRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddTransactionHeaderRow(dsViewTransaction.TransactionHeaderRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsViewTransaction.TransactionHeaderRow AddTransactionHeaderRow(
      int transactNum,
      DateTime postDate,
      string transDescription,
      string User,
      string Comments,
      string PayeeRemitter,
      int VoidTransaction,
      string ReceivedDate,
      string CheckNumber)
    {
      dsViewTransaction.TransactionHeaderRow row = (dsViewTransaction.TransactionHeaderRow) this.NewRow();
      object[] objArray = new object[9]
      {
        (object) transactNum,
        (object) postDate,
        (object) transDescription,
        (object) User,
        (object) Comments,
        (object) PayeeRemitter,
        (object) VoidTransaction,
        (object) ReceivedDate,
        (object) CheckNumber
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsViewTransaction.TransactionHeaderDataTable transactionHeaderDataTable = (dsViewTransaction.TransactionHeaderDataTable) base.Clone();
      transactionHeaderDataTable.InitVars();
      return (DataTable) transactionHeaderDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsViewTransaction.TransactionHeaderDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columntransactNum = this.Columns["transactNum"];
      this.columnpostDate = this.Columns["postDate"];
      this.columntransDescription = this.Columns["transDescription"];
      this.columnUser = this.Columns["User"];
      this.columnComments = this.Columns["Comments"];
      this.columnPayeeRemitter = this.Columns["PayeeRemitter"];
      this.columnVoidTransaction = this.Columns["VoidTransaction"];
      this.columnReceivedDate = this.Columns["ReceivedDate"];
      this.columnCheckNumber = this.Columns["CheckNumber"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columntransactNum = new DataColumn("transactNum", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columntransactNum);
      this.columnpostDate = new DataColumn("postDate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnpostDate);
      this.columntransDescription = new DataColumn("transDescription", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columntransDescription);
      this.columnUser = new DataColumn("User", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnUser);
      this.columnComments = new DataColumn("Comments", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnComments);
      this.columnPayeeRemitter = new DataColumn("PayeeRemitter", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPayeeRemitter);
      this.columnVoidTransaction = new DataColumn("VoidTransaction", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnVoidTransaction);
      this.columnReceivedDate = new DataColumn("ReceivedDate", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnReceivedDate);
      this.columnCheckNumber = new DataColumn("CheckNumber", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCheckNumber);
      this.columnReceivedDate.DefaultValue = (object) "\"N/A\"";
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsViewTransaction.TransactionHeaderRow NewTransactionHeaderRow()
    {
      return (dsViewTransaction.TransactionHeaderRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsViewTransaction.TransactionHeaderRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (dsViewTransaction.TransactionHeaderRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.TransactionHeaderRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsViewTransaction.TransactionHeaderRowChangeEventHandler headerRowChangedEvent = this.TransactionHeaderRowChangedEvent;
      if (headerRowChangedEvent == null)
        return;
      headerRowChangedEvent((object) this, new dsViewTransaction.TransactionHeaderRowChangeEvent((dsViewTransaction.TransactionHeaderRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.TransactionHeaderRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsViewTransaction.TransactionHeaderRowChangeEventHandler rowChangingEvent = this.TransactionHeaderRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsViewTransaction.TransactionHeaderRowChangeEvent((dsViewTransaction.TransactionHeaderRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.TransactionHeaderRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsViewTransaction.TransactionHeaderRowChangeEventHandler headerRowDeletedEvent = this.TransactionHeaderRowDeletedEvent;
      if (headerRowDeletedEvent == null)
        return;
      headerRowDeletedEvent((object) this, new dsViewTransaction.TransactionHeaderRowChangeEvent((dsViewTransaction.TransactionHeaderRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.TransactionHeaderRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsViewTransaction.TransactionHeaderRowChangeEventHandler rowDeletingEvent = this.TransactionHeaderRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsViewTransaction.TransactionHeaderRowChangeEvent((dsViewTransaction.TransactionHeaderRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemoveTransactionHeaderRow(dsViewTransaction.TransactionHeaderRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsViewTransaction dsViewTransaction = new dsViewTransaction();
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
        FixedValue = dsViewTransaction.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (TransactionHeaderDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsViewTransaction.GetSchemaSerializable();
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
  public class DistributionsDataTable : TypedTableBase<dsViewTransaction.DistributionsRow>
  {
    private DataColumn columnglAccountId;
    private DataColumn columnfullName;
    private DataColumn columnEntity;
    private DataColumn columnaccountType;
    private DataColumn columndebitAmount;
    private DataColumn columncreditAmount;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DistributionsDataTable()
    {
      this.TableName = "Distributions";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal DistributionsDataTable(DataTable table)
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
    protected DistributionsDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn glAccountIdColumn => this.columnglAccountId;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn fullNameColumn => this.columnfullName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn EntityColumn => this.columnEntity;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn accountTypeColumn => this.columnaccountType;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn debitAmountColumn => this.columndebitAmount;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn creditAmountColumn => this.columncreditAmount;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsViewTransaction.DistributionsRow this[int index]
    {
      get => (dsViewTransaction.DistributionsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsViewTransaction.DistributionsRowChangeEventHandler DistributionsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsViewTransaction.DistributionsRowChangeEventHandler DistributionsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsViewTransaction.DistributionsRowChangeEventHandler DistributionsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsViewTransaction.DistributionsRowChangeEventHandler DistributionsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddDistributionsRow(dsViewTransaction.DistributionsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsViewTransaction.DistributionsRow AddDistributionsRow(
      int glAccountId,
      string fullName,
      string Entity,
      string accountType,
      Decimal debitAmount,
      Decimal creditAmount)
    {
      dsViewTransaction.DistributionsRow row = (dsViewTransaction.DistributionsRow) this.NewRow();
      object[] objArray = new object[6]
      {
        (object) glAccountId,
        (object) fullName,
        (object) Entity,
        (object) accountType,
        (object) debitAmount,
        (object) creditAmount
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsViewTransaction.DistributionsDataTable distributionsDataTable = (dsViewTransaction.DistributionsDataTable) base.Clone();
      distributionsDataTable.InitVars();
      return (DataTable) distributionsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsViewTransaction.DistributionsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnglAccountId = this.Columns["glAccountId"];
      this.columnfullName = this.Columns["fullName"];
      this.columnEntity = this.Columns["Entity"];
      this.columnaccountType = this.Columns["accountType"];
      this.columndebitAmount = this.Columns["debitAmount"];
      this.columncreditAmount = this.Columns["creditAmount"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnglAccountId = new DataColumn("glAccountId", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnglAccountId);
      this.columnfullName = new DataColumn("fullName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnfullName);
      this.columnEntity = new DataColumn("Entity", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEntity);
      this.columnaccountType = new DataColumn("accountType", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnaccountType);
      this.columndebitAmount = new DataColumn("debitAmount", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columndebitAmount);
      this.columncreditAmount = new DataColumn("creditAmount", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columncreditAmount);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsViewTransaction.DistributionsRow NewDistributionsRow()
    {
      return (dsViewTransaction.DistributionsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsViewTransaction.DistributionsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (dsViewTransaction.DistributionsRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.DistributionsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsViewTransaction.DistributionsRowChangeEventHandler distributionsRowChangedEvent = this.DistributionsRowChangedEvent;
      if (distributionsRowChangedEvent == null)
        return;
      distributionsRowChangedEvent((object) this, new dsViewTransaction.DistributionsRowChangeEvent((dsViewTransaction.DistributionsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.DistributionsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsViewTransaction.DistributionsRowChangeEventHandler rowChangingEvent = this.DistributionsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsViewTransaction.DistributionsRowChangeEvent((dsViewTransaction.DistributionsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.DistributionsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsViewTransaction.DistributionsRowChangeEventHandler distributionsRowDeletedEvent = this.DistributionsRowDeletedEvent;
      if (distributionsRowDeletedEvent == null)
        return;
      distributionsRowDeletedEvent((object) this, new dsViewTransaction.DistributionsRowChangeEvent((dsViewTransaction.DistributionsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.DistributionsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsViewTransaction.DistributionsRowChangeEventHandler rowDeletingEvent = this.DistributionsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsViewTransaction.DistributionsRowChangeEvent((dsViewTransaction.DistributionsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemoveDistributionsRow(dsViewTransaction.DistributionsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsViewTransaction dsViewTransaction = new dsViewTransaction();
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
        FixedValue = dsViewTransaction.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (DistributionsDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsViewTransaction.GetSchemaSerializable();
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
  public class AffectedInvoicesDataTable : TypedTableBase<dsViewTransaction.AffectedInvoicesRow>
  {
    private DataColumn columnpolicyNumber;
    private DataColumn columnofficeInvoiceNum;
    private DataColumn columncompany;
    private DataColumn columnproducerName;
    private DataColumn columninsuredName;
    private DataColumn columnamount;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public AffectedInvoicesDataTable()
    {
      this.TableName = "AffectedInvoices";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal AffectedInvoicesDataTable(DataTable table)
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
    protected AffectedInvoicesDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn policyNumberColumn => this.columnpolicyNumber;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn officeInvoiceNumColumn => this.columnofficeInvoiceNum;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn companyColumn => this.columncompany;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn producerNameColumn => this.columnproducerName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn insuredNameColumn => this.columninsuredName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn amountColumn => this.columnamount;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsViewTransaction.AffectedInvoicesRow this[int index]
    {
      get => (dsViewTransaction.AffectedInvoicesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsViewTransaction.AffectedInvoicesRowChangeEventHandler AffectedInvoicesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsViewTransaction.AffectedInvoicesRowChangeEventHandler AffectedInvoicesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsViewTransaction.AffectedInvoicesRowChangeEventHandler AffectedInvoicesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsViewTransaction.AffectedInvoicesRowChangeEventHandler AffectedInvoicesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddAffectedInvoicesRow(dsViewTransaction.AffectedInvoicesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsViewTransaction.AffectedInvoicesRow AddAffectedInvoicesRow(
      string policyNumber,
      string officeInvoiceNum,
      string company,
      string producerName,
      string insuredName,
      Decimal amount)
    {
      dsViewTransaction.AffectedInvoicesRow row = (dsViewTransaction.AffectedInvoicesRow) this.NewRow();
      object[] objArray = new object[6]
      {
        (object) policyNumber,
        (object) officeInvoiceNum,
        (object) company,
        (object) producerName,
        (object) insuredName,
        (object) amount
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsViewTransaction.AffectedInvoicesDataTable invoicesDataTable = (dsViewTransaction.AffectedInvoicesDataTable) base.Clone();
      invoicesDataTable.InitVars();
      return (DataTable) invoicesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsViewTransaction.AffectedInvoicesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnpolicyNumber = this.Columns["policyNumber"];
      this.columnofficeInvoiceNum = this.Columns["officeInvoiceNum"];
      this.columncompany = this.Columns["company"];
      this.columnproducerName = this.Columns["producerName"];
      this.columninsuredName = this.Columns["insuredName"];
      this.columnamount = this.Columns["amount"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnpolicyNumber = new DataColumn("policyNumber", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnpolicyNumber);
      this.columnofficeInvoiceNum = new DataColumn("officeInvoiceNum", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnofficeInvoiceNum);
      this.columncompany = new DataColumn("company", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columncompany);
      this.columnproducerName = new DataColumn("producerName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnproducerName);
      this.columninsuredName = new DataColumn("insuredName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columninsuredName);
      this.columnamount = new DataColumn("amount", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnamount);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsViewTransaction.AffectedInvoicesRow NewAffectedInvoicesRow()
    {
      return (dsViewTransaction.AffectedInvoicesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsViewTransaction.AffectedInvoicesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (dsViewTransaction.AffectedInvoicesRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.AffectedInvoicesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsViewTransaction.AffectedInvoicesRowChangeEventHandler invoicesRowChangedEvent = this.AffectedInvoicesRowChangedEvent;
      if (invoicesRowChangedEvent == null)
        return;
      invoicesRowChangedEvent((object) this, new dsViewTransaction.AffectedInvoicesRowChangeEvent((dsViewTransaction.AffectedInvoicesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.AffectedInvoicesRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsViewTransaction.AffectedInvoicesRowChangeEventHandler rowChangingEvent = this.AffectedInvoicesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsViewTransaction.AffectedInvoicesRowChangeEvent((dsViewTransaction.AffectedInvoicesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.AffectedInvoicesRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsViewTransaction.AffectedInvoicesRowChangeEventHandler invoicesRowDeletedEvent = this.AffectedInvoicesRowDeletedEvent;
      if (invoicesRowDeletedEvent == null)
        return;
      invoicesRowDeletedEvent((object) this, new dsViewTransaction.AffectedInvoicesRowChangeEvent((dsViewTransaction.AffectedInvoicesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.AffectedInvoicesRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsViewTransaction.AffectedInvoicesRowChangeEventHandler rowDeletingEvent = this.AffectedInvoicesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsViewTransaction.AffectedInvoicesRowChangeEvent((dsViewTransaction.AffectedInvoicesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemoveAffectedInvoicesRow(dsViewTransaction.AffectedInvoicesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsViewTransaction dsViewTransaction = new dsViewTransaction();
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
        FixedValue = dsViewTransaction.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (AffectedInvoicesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsViewTransaction.GetSchemaSerializable();
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
  public class VerbageDataTable : TypedTableBase<dsViewTransaction.VerbageRow>
  {
    private DataColumn columntransactionType;
    private DataColumn columnextendedTransactionType;
    private DataColumn columntransactionDateString;
    private DataColumn columntransactionAmont;
    private DataColumn columnentityName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public VerbageDataTable()
    {
      this.TableName = "Verbage";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal VerbageDataTable(DataTable table)
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
    protected VerbageDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn transactionTypeColumn => this.columntransactionType;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn extendedTransactionTypeColumn => this.columnextendedTransactionType;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn transactionDateStringColumn => this.columntransactionDateString;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn transactionAmontColumn => this.columntransactionAmont;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn entityNameColumn => this.columnentityName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsViewTransaction.VerbageRow this[int index]
    {
      get => (dsViewTransaction.VerbageRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsViewTransaction.VerbageRowChangeEventHandler VerbageRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsViewTransaction.VerbageRowChangeEventHandler VerbageRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsViewTransaction.VerbageRowChangeEventHandler VerbageRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsViewTransaction.VerbageRowChangeEventHandler VerbageRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddVerbageRow(dsViewTransaction.VerbageRow row) => this.Rows.Add((DataRow) row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsViewTransaction.VerbageRow AddVerbageRow(
      string transactionType,
      string extendedTransactionType,
      string transactionDateString,
      Decimal transactionAmont,
      string entityName)
    {
      dsViewTransaction.VerbageRow row = (dsViewTransaction.VerbageRow) this.NewRow();
      object[] objArray = new object[5]
      {
        (object) transactionType,
        (object) extendedTransactionType,
        (object) transactionDateString,
        (object) transactionAmont,
        (object) entityName
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsViewTransaction.VerbageDataTable verbageDataTable = (dsViewTransaction.VerbageDataTable) base.Clone();
      verbageDataTable.InitVars();
      return (DataTable) verbageDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsViewTransaction.VerbageDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columntransactionType = this.Columns["transactionType"];
      this.columnextendedTransactionType = this.Columns["extendedTransactionType"];
      this.columntransactionDateString = this.Columns["transactionDateString"];
      this.columntransactionAmont = this.Columns["transactionAmont"];
      this.columnentityName = this.Columns["entityName"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columntransactionType = new DataColumn("transactionType", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columntransactionType);
      this.columnextendedTransactionType = new DataColumn("extendedTransactionType", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnextendedTransactionType);
      this.columntransactionDateString = new DataColumn("transactionDateString", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columntransactionDateString);
      this.columntransactionAmont = new DataColumn("transactionAmont", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columntransactionAmont);
      this.columnentityName = new DataColumn("entityName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnentityName);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsViewTransaction.VerbageRow NewVerbageRow()
    {
      return (dsViewTransaction.VerbageRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsViewTransaction.VerbageRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (dsViewTransaction.VerbageRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.VerbageRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsViewTransaction.VerbageRowChangeEventHandler verbageRowChangedEvent = this.VerbageRowChangedEvent;
      if (verbageRowChangedEvent == null)
        return;
      verbageRowChangedEvent((object) this, new dsViewTransaction.VerbageRowChangeEvent((dsViewTransaction.VerbageRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.VerbageRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsViewTransaction.VerbageRowChangeEventHandler rowChangingEvent = this.VerbageRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsViewTransaction.VerbageRowChangeEvent((dsViewTransaction.VerbageRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.VerbageRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsViewTransaction.VerbageRowChangeEventHandler verbageRowDeletedEvent = this.VerbageRowDeletedEvent;
      if (verbageRowDeletedEvent == null)
        return;
      verbageRowDeletedEvent((object) this, new dsViewTransaction.VerbageRowChangeEvent((dsViewTransaction.VerbageRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.VerbageRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsViewTransaction.VerbageRowChangeEventHandler rowDeletingEvent = this.VerbageRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsViewTransaction.VerbageRowChangeEvent((dsViewTransaction.VerbageRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemoveVerbageRow(dsViewTransaction.VerbageRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsViewTransaction dsViewTransaction = new dsViewTransaction();
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
        FixedValue = dsViewTransaction.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (VerbageDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsViewTransaction.GetSchemaSerializable();
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
  public class POExpenseDataTable : TypedTableBase<dsViewTransaction.POExpenseRow>
  {
    private DataColumn columnPONum;
    private DataColumn columnGLAccount;
    private DataColumn columnComments;
    private DataColumn columnAmount;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public POExpenseDataTable()
    {
      this.TableName = "POExpense";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal POExpenseDataTable(DataTable table)
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
    protected POExpenseDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn PONumColumn => this.columnPONum;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn GLAccountColumn => this.columnGLAccount;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn CommentsColumn => this.columnComments;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn AmountColumn => this.columnAmount;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsViewTransaction.POExpenseRow this[int index]
    {
      get => (dsViewTransaction.POExpenseRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsViewTransaction.POExpenseRowChangeEventHandler POExpenseRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsViewTransaction.POExpenseRowChangeEventHandler POExpenseRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsViewTransaction.POExpenseRowChangeEventHandler POExpenseRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsViewTransaction.POExpenseRowChangeEventHandler POExpenseRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddPOExpenseRow(dsViewTransaction.POExpenseRow row) => this.Rows.Add((DataRow) row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsViewTransaction.POExpenseRow AddPOExpenseRow(
      int PONum,
      string GLAccount,
      string Comments,
      Decimal Amount)
    {
      dsViewTransaction.POExpenseRow row = (dsViewTransaction.POExpenseRow) this.NewRow();
      object[] objArray = new object[4]
      {
        (object) PONum,
        (object) GLAccount,
        (object) Comments,
        (object) Amount
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsViewTransaction.POExpenseDataTable expenseDataTable = (dsViewTransaction.POExpenseDataTable) base.Clone();
      expenseDataTable.InitVars();
      return (DataTable) expenseDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsViewTransaction.POExpenseDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnPONum = this.Columns["PONum"];
      this.columnGLAccount = this.Columns["GLAccount"];
      this.columnComments = this.Columns["Comments"];
      this.columnAmount = this.Columns["Amount"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnPONum = new DataColumn("PONum", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPONum);
      this.columnGLAccount = new DataColumn("GLAccount", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnGLAccount);
      this.columnComments = new DataColumn("Comments", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnComments);
      this.columnAmount = new DataColumn("Amount", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAmount);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsViewTransaction.POExpenseRow NewPOExpenseRow()
    {
      return (dsViewTransaction.POExpenseRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsViewTransaction.POExpenseRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (dsViewTransaction.POExpenseRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.POExpenseRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsViewTransaction.POExpenseRowChangeEventHandler expenseRowChangedEvent = this.POExpenseRowChangedEvent;
      if (expenseRowChangedEvent == null)
        return;
      expenseRowChangedEvent((object) this, new dsViewTransaction.POExpenseRowChangeEvent((dsViewTransaction.POExpenseRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.POExpenseRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsViewTransaction.POExpenseRowChangeEventHandler rowChangingEvent = this.POExpenseRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsViewTransaction.POExpenseRowChangeEvent((dsViewTransaction.POExpenseRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.POExpenseRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsViewTransaction.POExpenseRowChangeEventHandler expenseRowDeletedEvent = this.POExpenseRowDeletedEvent;
      if (expenseRowDeletedEvent == null)
        return;
      expenseRowDeletedEvent((object) this, new dsViewTransaction.POExpenseRowChangeEvent((dsViewTransaction.POExpenseRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.POExpenseRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsViewTransaction.POExpenseRowChangeEventHandler rowDeletingEvent = this.POExpenseRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsViewTransaction.POExpenseRowChangeEvent((dsViewTransaction.POExpenseRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemovePOExpenseRow(dsViewTransaction.POExpenseRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsViewTransaction dsViewTransaction = new dsViewTransaction();
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
        FixedValue = dsViewTransaction.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (POExpenseDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsViewTransaction.GetSchemaSerializable();
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
  public class CommissionsDataTable : TypedTableBase<dsViewTransaction.CommissionsRow>
  {
    private DataColumn columnofficeinvoicenum;
    private DataColumn columnDescription;
    private DataColumn columnAccount;
    private DataColumn columnAmount;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public CommissionsDataTable()
    {
      this.TableName = "Commissions";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal CommissionsDataTable(DataTable table)
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
    protected CommissionsDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn officeinvoicenumColumn => this.columnofficeinvoicenum;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn DescriptionColumn => this.columnDescription;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn AccountColumn => this.columnAccount;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn AmountColumn => this.columnAmount;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsViewTransaction.CommissionsRow this[int index]
    {
      get => (dsViewTransaction.CommissionsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsViewTransaction.CommissionsRowChangeEventHandler CommissionsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsViewTransaction.CommissionsRowChangeEventHandler CommissionsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsViewTransaction.CommissionsRowChangeEventHandler CommissionsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsViewTransaction.CommissionsRowChangeEventHandler CommissionsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddCommissionsRow(dsViewTransaction.CommissionsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsViewTransaction.CommissionsRow AddCommissionsRow(
      string officeinvoicenum,
      string Description,
      string Account,
      Decimal Amount)
    {
      dsViewTransaction.CommissionsRow row = (dsViewTransaction.CommissionsRow) this.NewRow();
      object[] objArray = new object[4]
      {
        (object) officeinvoicenum,
        (object) Description,
        (object) Account,
        (object) Amount
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsViewTransaction.CommissionsDataTable commissionsDataTable = (dsViewTransaction.CommissionsDataTable) base.Clone();
      commissionsDataTable.InitVars();
      return (DataTable) commissionsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsViewTransaction.CommissionsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnofficeinvoicenum = this.Columns["officeinvoicenum"];
      this.columnDescription = this.Columns["Description"];
      this.columnAccount = this.Columns["Account"];
      this.columnAmount = this.Columns["Amount"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnofficeinvoicenum = new DataColumn("officeinvoicenum", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnofficeinvoicenum);
      this.columnDescription = new DataColumn("Description", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDescription);
      this.columnAccount = new DataColumn("Account", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAccount);
      this.columnAmount = new DataColumn("Amount", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAmount);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsViewTransaction.CommissionsRow NewCommissionsRow()
    {
      return (dsViewTransaction.CommissionsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsViewTransaction.CommissionsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (dsViewTransaction.CommissionsRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.CommissionsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsViewTransaction.CommissionsRowChangeEventHandler commissionsRowChangedEvent = this.CommissionsRowChangedEvent;
      if (commissionsRowChangedEvent == null)
        return;
      commissionsRowChangedEvent((object) this, new dsViewTransaction.CommissionsRowChangeEvent((dsViewTransaction.CommissionsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.CommissionsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsViewTransaction.CommissionsRowChangeEventHandler rowChangingEvent = this.CommissionsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsViewTransaction.CommissionsRowChangeEvent((dsViewTransaction.CommissionsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.CommissionsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsViewTransaction.CommissionsRowChangeEventHandler commissionsRowDeletedEvent = this.CommissionsRowDeletedEvent;
      if (commissionsRowDeletedEvent == null)
        return;
      commissionsRowDeletedEvent((object) this, new dsViewTransaction.CommissionsRowChangeEvent((dsViewTransaction.CommissionsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.CommissionsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsViewTransaction.CommissionsRowChangeEventHandler rowDeletingEvent = this.CommissionsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsViewTransaction.CommissionsRowChangeEvent((dsViewTransaction.CommissionsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemoveCommissionsRow(dsViewTransaction.CommissionsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsViewTransaction dsViewTransaction = new dsViewTransaction();
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
        FixedValue = dsViewTransaction.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (CommissionsDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsViewTransaction.GetSchemaSerializable();
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
  public class SummaryDataTable : TypedTableBase<dsViewTransaction.SummaryRow>
  {
    private DataColumn columncash;
    private DataColumn columnreceivables;
    private DataColumn columnpayables;
    private DataColumn columnexchange;
    private DataColumn columnincome;
    private DataColumn columnunaccounted;
    private DataColumn columnexpenses;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public SummaryDataTable()
    {
      this.TableName = "Summary";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal SummaryDataTable(DataTable table)
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
    protected SummaryDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn cashColumn => this.columncash;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn receivablesColumn => this.columnreceivables;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn payablesColumn => this.columnpayables;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn exchangeColumn => this.columnexchange;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn incomeColumn => this.columnincome;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn unaccountedColumn => this.columnunaccounted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn expensesColumn => this.columnexpenses;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsViewTransaction.SummaryRow this[int index]
    {
      get => (dsViewTransaction.SummaryRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsViewTransaction.SummaryRowChangeEventHandler SummaryRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsViewTransaction.SummaryRowChangeEventHandler SummaryRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsViewTransaction.SummaryRowChangeEventHandler SummaryRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsViewTransaction.SummaryRowChangeEventHandler SummaryRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddSummaryRow(dsViewTransaction.SummaryRow row) => this.Rows.Add((DataRow) row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsViewTransaction.SummaryRow AddSummaryRow(
      Decimal cash,
      Decimal receivables,
      Decimal payables,
      Decimal exchange,
      Decimal income,
      Decimal unaccounted,
      Decimal expenses)
    {
      dsViewTransaction.SummaryRow row = (dsViewTransaction.SummaryRow) this.NewRow();
      object[] objArray = new object[7]
      {
        (object) cash,
        (object) receivables,
        (object) payables,
        (object) exchange,
        (object) income,
        (object) unaccounted,
        (object) expenses
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsViewTransaction.SummaryDataTable summaryDataTable = (dsViewTransaction.SummaryDataTable) base.Clone();
      summaryDataTable.InitVars();
      return (DataTable) summaryDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsViewTransaction.SummaryDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columncash = this.Columns["cash"];
      this.columnreceivables = this.Columns["receivables"];
      this.columnpayables = this.Columns["payables"];
      this.columnexchange = this.Columns["exchange"];
      this.columnincome = this.Columns["income"];
      this.columnunaccounted = this.Columns["unaccounted"];
      this.columnexpenses = this.Columns["expenses"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columncash = new DataColumn("cash", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columncash);
      this.columnreceivables = new DataColumn("receivables", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnreceivables);
      this.columnpayables = new DataColumn("payables", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnpayables);
      this.columnexchange = new DataColumn("exchange", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnexchange);
      this.columnincome = new DataColumn("income", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnincome);
      this.columnunaccounted = new DataColumn("unaccounted", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnunaccounted);
      this.columnexpenses = new DataColumn("expenses", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnexpenses);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsViewTransaction.SummaryRow NewSummaryRow()
    {
      return (dsViewTransaction.SummaryRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsViewTransaction.SummaryRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (dsViewTransaction.SummaryRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.SummaryRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsViewTransaction.SummaryRowChangeEventHandler summaryRowChangedEvent = this.SummaryRowChangedEvent;
      if (summaryRowChangedEvent == null)
        return;
      summaryRowChangedEvent((object) this, new dsViewTransaction.SummaryRowChangeEvent((dsViewTransaction.SummaryRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.SummaryRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsViewTransaction.SummaryRowChangeEventHandler rowChangingEvent = this.SummaryRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsViewTransaction.SummaryRowChangeEvent((dsViewTransaction.SummaryRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.SummaryRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsViewTransaction.SummaryRowChangeEventHandler summaryRowDeletedEvent = this.SummaryRowDeletedEvent;
      if (summaryRowDeletedEvent == null)
        return;
      summaryRowDeletedEvent((object) this, new dsViewTransaction.SummaryRowChangeEvent((dsViewTransaction.SummaryRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.SummaryRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsViewTransaction.SummaryRowChangeEventHandler rowDeletingEvent = this.SummaryRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsViewTransaction.SummaryRowChangeEvent((dsViewTransaction.SummaryRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemoveSummaryRow(dsViewTransaction.SummaryRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsViewTransaction dsViewTransaction = new dsViewTransaction();
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
        FixedValue = dsViewTransaction.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (SummaryDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsViewTransaction.GetSchemaSerializable();
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

  public class TransactionHeaderRow : DataRow
  {
    private dsViewTransaction.TransactionHeaderDataTable tableTransactionHeader;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal TransactionHeaderRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableTransactionHeader = (dsViewTransaction.TransactionHeaderDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int transactNum
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tableTransactionHeader.transactNumColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'transactNum' in table 'TransactionHeader' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableTransactionHeader.transactNumColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DateTime postDate
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tableTransactionHeader.postDateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'postDate' in table 'TransactionHeader' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableTransactionHeader.postDateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string transDescription
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableTransactionHeader.transDescriptionColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'transDescription' in table 'TransactionHeader' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableTransactionHeader.transDescriptionColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string User
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableTransactionHeader.UserColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'User' in table 'TransactionHeader' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableTransactionHeader.UserColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Comments
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableTransactionHeader.CommentsColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Comments' in table 'TransactionHeader' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableTransactionHeader.CommentsColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string PayeeRemitter
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableTransactionHeader.PayeeRemitterColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'PayeeRemitter' in table 'TransactionHeader' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableTransactionHeader.PayeeRemitterColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int VoidTransaction
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tableTransactionHeader.VoidTransactionColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'VoidTransaction' in table 'TransactionHeader' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableTransactionHeader.VoidTransactionColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string ReceivedDate
    {
      get
      {
        return !this.IsReceivedDateNull() ? Conversions.ToString(this[this.tableTransactionHeader.ReceivedDateColumn]) : string.Empty;
      }
      set => this[this.tableTransactionHeader.ReceivedDateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string CheckNumber
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableTransactionHeader.CheckNumberColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'CheckNumber' in table 'TransactionHeader' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableTransactionHeader.CheckNumberColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IstransactNumNull() => this.IsNull(this.tableTransactionHeader.transactNumColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SettransactNumNull()
    {
      this[this.tableTransactionHeader.transactNumColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IspostDateNull() => this.IsNull(this.tableTransactionHeader.postDateColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetpostDateNull()
    {
      this[this.tableTransactionHeader.postDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IstransDescriptionNull()
    {
      return this.IsNull(this.tableTransactionHeader.transDescriptionColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SettransDescriptionNull()
    {
      this[this.tableTransactionHeader.transDescriptionColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsUserNull() => this.IsNull(this.tableTransactionHeader.UserColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetUserNull()
    {
      this[this.tableTransactionHeader.UserColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsCommentsNull() => this.IsNull(this.tableTransactionHeader.CommentsColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetCommentsNull()
    {
      this[this.tableTransactionHeader.CommentsColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsPayeeRemitterNull()
    {
      return this.IsNull(this.tableTransactionHeader.PayeeRemitterColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetPayeeRemitterNull()
    {
      this[this.tableTransactionHeader.PayeeRemitterColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsVoidTransactionNull()
    {
      return this.IsNull(this.tableTransactionHeader.VoidTransactionColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetVoidTransactionNull()
    {
      this[this.tableTransactionHeader.VoidTransactionColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsReceivedDateNull() => this.IsNull(this.tableTransactionHeader.ReceivedDateColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetReceivedDateNull()
    {
      this[this.tableTransactionHeader.ReceivedDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsCheckNumberNull() => this.IsNull(this.tableTransactionHeader.CheckNumberColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetCheckNumberNull()
    {
      this[this.tableTransactionHeader.CheckNumberColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class DistributionsRow : DataRow
  {
    private dsViewTransaction.DistributionsDataTable tableDistributions;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal DistributionsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableDistributions = (dsViewTransaction.DistributionsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int glAccountId
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tableDistributions.glAccountIdColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'glAccountId' in table 'Distributions' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableDistributions.glAccountIdColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string fullName
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableDistributions.fullNameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'fullName' in table 'Distributions' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableDistributions.fullNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Entity
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableDistributions.EntityColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Entity' in table 'Distributions' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableDistributions.EntityColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string accountType
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableDistributions.accountTypeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'accountType' in table 'Distributions' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableDistributions.accountTypeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal debitAmount
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tableDistributions.debitAmountColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'debitAmount' in table 'Distributions' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableDistributions.debitAmountColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal creditAmount
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tableDistributions.creditAmountColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'creditAmount' in table 'Distributions' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableDistributions.creditAmountColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsglAccountIdNull() => this.IsNull(this.tableDistributions.glAccountIdColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetglAccountIdNull()
    {
      this[this.tableDistributions.glAccountIdColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsfullNameNull() => this.IsNull(this.tableDistributions.fullNameColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetfullNameNull()
    {
      this[this.tableDistributions.fullNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsEntityNull() => this.IsNull(this.tableDistributions.EntityColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetEntityNull()
    {
      this[this.tableDistributions.EntityColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsaccountTypeNull() => this.IsNull(this.tableDistributions.accountTypeColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetaccountTypeNull()
    {
      this[this.tableDistributions.accountTypeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsdebitAmountNull() => this.IsNull(this.tableDistributions.debitAmountColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetdebitAmountNull()
    {
      this[this.tableDistributions.debitAmountColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IscreditAmountNull() => this.IsNull(this.tableDistributions.creditAmountColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetcreditAmountNull()
    {
      this[this.tableDistributions.creditAmountColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class AffectedInvoicesRow : DataRow
  {
    private dsViewTransaction.AffectedInvoicesDataTable tableAffectedInvoices;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal AffectedInvoicesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableAffectedInvoices = (dsViewTransaction.AffectedInvoicesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string policyNumber
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableAffectedInvoices.policyNumberColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'policyNumber' in table 'AffectedInvoices' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableAffectedInvoices.policyNumberColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string officeInvoiceNum
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableAffectedInvoices.officeInvoiceNumColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'officeInvoiceNum' in table 'AffectedInvoices' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableAffectedInvoices.officeInvoiceNumColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string company
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableAffectedInvoices.companyColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'company' in table 'AffectedInvoices' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableAffectedInvoices.companyColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string producerName
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableAffectedInvoices.producerNameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'producerName' in table 'AffectedInvoices' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableAffectedInvoices.producerNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string insuredName
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableAffectedInvoices.insuredNameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'insuredName' in table 'AffectedInvoices' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableAffectedInvoices.insuredNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal amount
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tableAffectedInvoices.amountColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'amount' in table 'AffectedInvoices' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableAffectedInvoices.amountColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IspolicyNumberNull() => this.IsNull(this.tableAffectedInvoices.policyNumberColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetpolicyNumberNull()
    {
      this[this.tableAffectedInvoices.policyNumberColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsofficeInvoiceNumNull()
    {
      return this.IsNull(this.tableAffectedInvoices.officeInvoiceNumColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetofficeInvoiceNumNull()
    {
      this[this.tableAffectedInvoices.officeInvoiceNumColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IscompanyNull() => this.IsNull(this.tableAffectedInvoices.companyColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetcompanyNull()
    {
      this[this.tableAffectedInvoices.companyColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsproducerNameNull() => this.IsNull(this.tableAffectedInvoices.producerNameColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetproducerNameNull()
    {
      this[this.tableAffectedInvoices.producerNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsinsuredNameNull() => this.IsNull(this.tableAffectedInvoices.insuredNameColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetinsuredNameNull()
    {
      this[this.tableAffectedInvoices.insuredNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsamountNull() => this.IsNull(this.tableAffectedInvoices.amountColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetamountNull()
    {
      this[this.tableAffectedInvoices.amountColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class VerbageRow : DataRow
  {
    private dsViewTransaction.VerbageDataTable tableVerbage;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal VerbageRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableVerbage = (dsViewTransaction.VerbageDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string transactionType
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableVerbage.transactionTypeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'transactionType' in table 'Verbage' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableVerbage.transactionTypeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string extendedTransactionType
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableVerbage.extendedTransactionTypeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'extendedTransactionType' in table 'Verbage' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableVerbage.extendedTransactionTypeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string transactionDateString
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableVerbage.transactionDateStringColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'transactionDateString' in table 'Verbage' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableVerbage.transactionDateStringColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal transactionAmont
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tableVerbage.transactionAmontColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'transactionAmont' in table 'Verbage' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableVerbage.transactionAmontColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string entityName
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableVerbage.entityNameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'entityName' in table 'Verbage' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableVerbage.entityNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IstransactionTypeNull() => this.IsNull(this.tableVerbage.transactionTypeColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SettransactionTypeNull()
    {
      this[this.tableVerbage.transactionTypeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsextendedTransactionTypeNull()
    {
      return this.IsNull(this.tableVerbage.extendedTransactionTypeColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetextendedTransactionTypeNull()
    {
      this[this.tableVerbage.extendedTransactionTypeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IstransactionDateStringNull()
    {
      return this.IsNull(this.tableVerbage.transactionDateStringColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SettransactionDateStringNull()
    {
      this[this.tableVerbage.transactionDateStringColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IstransactionAmontNull() => this.IsNull(this.tableVerbage.transactionAmontColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SettransactionAmontNull()
    {
      this[this.tableVerbage.transactionAmontColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsentityNameNull() => this.IsNull(this.tableVerbage.entityNameColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetentityNameNull()
    {
      this[this.tableVerbage.entityNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class POExpenseRow : DataRow
  {
    private dsViewTransaction.POExpenseDataTable tablePOExpense;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal POExpenseRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablePOExpense = (dsViewTransaction.POExpenseDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int PONum
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tablePOExpense.PONumColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'PONum' in table 'POExpense' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePOExpense.PONumColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string GLAccount
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablePOExpense.GLAccountColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'GLAccount' in table 'POExpense' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePOExpense.GLAccountColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Comments
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablePOExpense.CommentsColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Comments' in table 'POExpense' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePOExpense.CommentsColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal Amount
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tablePOExpense.AmountColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Amount' in table 'POExpense' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePOExpense.AmountColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsPONumNull() => this.IsNull(this.tablePOExpense.PONumColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetPONumNull()
    {
      this[this.tablePOExpense.PONumColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsGLAccountNull() => this.IsNull(this.tablePOExpense.GLAccountColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetGLAccountNull()
    {
      this[this.tablePOExpense.GLAccountColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsCommentsNull() => this.IsNull(this.tablePOExpense.CommentsColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetCommentsNull()
    {
      this[this.tablePOExpense.CommentsColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsAmountNull() => this.IsNull(this.tablePOExpense.AmountColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetAmountNull()
    {
      this[this.tablePOExpense.AmountColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class CommissionsRow : DataRow
  {
    private dsViewTransaction.CommissionsDataTable tableCommissions;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal CommissionsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableCommissions = (dsViewTransaction.CommissionsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string officeinvoicenum
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableCommissions.officeinvoicenumColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'officeinvoicenum' in table 'Commissions' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableCommissions.officeinvoicenumColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Description
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableCommissions.DescriptionColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Description' in table 'Commissions' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableCommissions.DescriptionColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Account
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableCommissions.AccountColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Account' in table 'Commissions' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableCommissions.AccountColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal Amount
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tableCommissions.AmountColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Amount' in table 'Commissions' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableCommissions.AmountColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsofficeinvoicenumNull()
    {
      return this.IsNull(this.tableCommissions.officeinvoicenumColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetofficeinvoicenumNull()
    {
      this[this.tableCommissions.officeinvoicenumColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsDescriptionNull() => this.IsNull(this.tableCommissions.DescriptionColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetDescriptionNull()
    {
      this[this.tableCommissions.DescriptionColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsAccountNull() => this.IsNull(this.tableCommissions.AccountColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetAccountNull()
    {
      this[this.tableCommissions.AccountColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsAmountNull() => this.IsNull(this.tableCommissions.AmountColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetAmountNull()
    {
      this[this.tableCommissions.AmountColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class SummaryRow : DataRow
  {
    private dsViewTransaction.SummaryDataTable tableSummary;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal SummaryRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableSummary = (dsViewTransaction.SummaryDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal cash
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tableSummary.cashColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'cash' in table 'Summary' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableSummary.cashColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal receivables
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tableSummary.receivablesColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'receivables' in table 'Summary' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableSummary.receivablesColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal payables
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tableSummary.payablesColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'payables' in table 'Summary' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableSummary.payablesColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal exchange
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tableSummary.exchangeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'exchange' in table 'Summary' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableSummary.exchangeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal income
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tableSummary.incomeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'income' in table 'Summary' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableSummary.incomeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal unaccounted
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tableSummary.unaccountedColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'unaccounted' in table 'Summary' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableSummary.unaccountedColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal expenses
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tableSummary.expensesColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'expenses' in table 'Summary' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableSummary.expensesColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IscashNull() => this.IsNull(this.tableSummary.cashColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetcashNull()
    {
      this[this.tableSummary.cashColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsreceivablesNull() => this.IsNull(this.tableSummary.receivablesColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetreceivablesNull()
    {
      this[this.tableSummary.receivablesColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IspayablesNull() => this.IsNull(this.tableSummary.payablesColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetpayablesNull()
    {
      this[this.tableSummary.payablesColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsexchangeNull() => this.IsNull(this.tableSummary.exchangeColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetexchangeNull()
    {
      this[this.tableSummary.exchangeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsincomeNull() => this.IsNull(this.tableSummary.incomeColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetincomeNull()
    {
      this[this.tableSummary.incomeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsunaccountedNull() => this.IsNull(this.tableSummary.unaccountedColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetunaccountedNull()
    {
      this[this.tableSummary.unaccountedColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsexpensesNull() => this.IsNull(this.tableSummary.expensesColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetexpensesNull()
    {
      this[this.tableSummary.expensesColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class TransactionHeaderRowChangeEvent : EventArgs
  {
    private dsViewTransaction.TransactionHeaderRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public TransactionHeaderRowChangeEvent(
      dsViewTransaction.TransactionHeaderRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsViewTransaction.TransactionHeaderRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class DistributionsRowChangeEvent : EventArgs
  {
    private dsViewTransaction.DistributionsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DistributionsRowChangeEvent(dsViewTransaction.DistributionsRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsViewTransaction.DistributionsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class AffectedInvoicesRowChangeEvent : EventArgs
  {
    private dsViewTransaction.AffectedInvoicesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public AffectedInvoicesRowChangeEvent(
      dsViewTransaction.AffectedInvoicesRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsViewTransaction.AffectedInvoicesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class VerbageRowChangeEvent : EventArgs
  {
    private dsViewTransaction.VerbageRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public VerbageRowChangeEvent(dsViewTransaction.VerbageRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsViewTransaction.VerbageRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class POExpenseRowChangeEvent : EventArgs
  {
    private dsViewTransaction.POExpenseRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public POExpenseRowChangeEvent(dsViewTransaction.POExpenseRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsViewTransaction.POExpenseRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class CommissionsRowChangeEvent : EventArgs
  {
    private dsViewTransaction.CommissionsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public CommissionsRowChangeEvent(dsViewTransaction.CommissionsRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsViewTransaction.CommissionsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class SummaryRowChangeEvent : EventArgs
  {
    private dsViewTransaction.SummaryRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public SummaryRowChangeEvent(dsViewTransaction.SummaryRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsViewTransaction.SummaryRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }
}
