// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.AccountingDatasets.dsGetAccountsReceivable
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
[XmlRoot("dsGetAccountsReceivable")]
[HelpKeyword("vs.data.DataSet")]
[Serializable]
public class dsGetAccountsReceivable : DataSet
{
  private dsGetAccountsReceivable.AccountsReceivableDataTable tableAccountsReceivable;
  private SchemaSerializationMode _schemaSerializationMode;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public dsGetAccountsReceivable()
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
  protected dsGetAccountsReceivable(SerializationInfo info, StreamingContext context)
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
        if (dataSet.Tables[nameof (AccountsReceivable)] != null)
          base.Tables.Add((DataTable) new dsGetAccountsReceivable.AccountsReceivableDataTable(dataSet.Tables[nameof (AccountsReceivable)]));
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
  public dsGetAccountsReceivable.AccountsReceivableDataTable AccountsReceivable
  {
    get => this.tableAccountsReceivable;
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
    dsGetAccountsReceivable accountsReceivable = (dsGetAccountsReceivable) base.Clone();
    accountsReceivable.InitVars();
    accountsReceivable.SchemaSerializationMode = this.SchemaSerializationMode;
    return (DataSet) accountsReceivable;
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
      if (dataSet.Tables["AccountsReceivable"] != null)
        base.Tables.Add((DataTable) new dsGetAccountsReceivable.AccountsReceivableDataTable(dataSet.Tables["AccountsReceivable"]));
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
    this.tableAccountsReceivable = (dsGetAccountsReceivable.AccountsReceivableDataTable) base.Tables["AccountsReceivable"];
    if (!initTable || this.tableAccountsReceivable == null)
      return;
    this.tableAccountsReceivable.InitVars();
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private void InitClass()
  {
    this.DataSetName = nameof (dsGetAccountsReceivable);
    this.Prefix = "";
    this.Namespace = "http://www.tempuri.org/dsGetAccountsReceivable.xsd";
    this.EnforceConstraints = true;
    this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.tableAccountsReceivable = new dsGetAccountsReceivable.AccountsReceivableDataTable();
    base.Tables.Add((DataTable) this.tableAccountsReceivable);
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializeAccountsReceivable() => false;

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
    dsGetAccountsReceivable accountsReceivable = new dsGetAccountsReceivable();
    XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
    schemaComplexType.Particle = (XmlSchemaParticle) new XmlSchemaSequence()
    {
      Items = {
        (XmlSchemaObject) new XmlSchemaAny()
        {
          Namespace = accountsReceivable.Namespace
        }
      }
    };
    XmlSchema schemaSerializable = accountsReceivable.GetSchemaSerializable();
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
  public delegate void AccountsReceivableRowChangeEventHandler(
    object sender,
    dsGetAccountsReceivable.AccountsReceivableRowChangeEvent e);

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class AccountsReceivableDataTable : 
    TypedTableBase<dsGetAccountsReceivable.AccountsReceivableRow>
  {
    private DataColumn columninvoicenum;
    private DataColumn columnofficeinvoicenum;
    private DataColumn columnquoteid;
    private DataColumn columnquotecontrolnum;
    private DataColumn columnpolicynumber;
    private DataColumn columninsuredpolicyname;
    private DataColumn columneffectivedate;
    private DataColumn columnexpirationdate;
    private DataColumn columninvoicedate;
    private DataColumn columnchargename;
    private DataColumn columnchargecode;
    private DataColumn columncompanylineguid;
    private DataColumn columnamtbilled;
    private DataColumn columnAmtPTD;
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
    private DataColumn columnARApplied;
    private DataColumn columnExchApplied;
    private DataColumn columnUnAcctApplied;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public AccountsReceivableDataTable()
    {
      this.TableName = "AccountsReceivable";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal AccountsReceivableDataTable(DataTable table)
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
    protected AccountsReceivableDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn invoicenumColumn => this.columninvoicenum;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn officeinvoicenumColumn => this.columnofficeinvoicenum;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn quoteidColumn => this.columnquoteid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn quotecontrolnumColumn => this.columnquotecontrolnum;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn policynumberColumn => this.columnpolicynumber;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn insuredpolicynameColumn => this.columninsuredpolicyname;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn effectivedateColumn => this.columneffectivedate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn expirationdateColumn => this.columnexpirationdate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn invoicedateColumn => this.columninvoicedate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn chargenameColumn => this.columnchargename;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn chargecodeColumn => this.columnchargecode;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn companylineguidColumn => this.columncompanylineguid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn amtbilledColumn => this.columnamtbilled;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn AmtPTDColumn => this.columnAmtPTD;

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
    public DataColumn ARAppliedColumn => this.columnARApplied;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ExchAppliedColumn => this.columnExchApplied;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn UnAcctAppliedColumn => this.columnUnAcctApplied;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsGetAccountsReceivable.AccountsReceivableRow this[int index]
    {
      get => (dsGetAccountsReceivable.AccountsReceivableRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsGetAccountsReceivable.AccountsReceivableRowChangeEventHandler AccountsReceivableRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsGetAccountsReceivable.AccountsReceivableRowChangeEventHandler AccountsReceivableRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsGetAccountsReceivable.AccountsReceivableRowChangeEventHandler AccountsReceivableRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsGetAccountsReceivable.AccountsReceivableRowChangeEventHandler AccountsReceivableRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddAccountsReceivableRow(dsGetAccountsReceivable.AccountsReceivableRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsGetAccountsReceivable.AccountsReceivableRow AddAccountsReceivableRow(
      int invoicenum,
      int officeinvoicenum,
      int quoteid,
      int quotecontrolnum,
      string policynumber,
      string insuredpolicyname,
      DateTime effectivedate,
      DateTime expirationdate,
      DateTime invoicedate,
      string chargename,
      int chargecode,
      Guid companylineguid,
      Decimal amtbilled,
      Decimal AmtPTD,
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
      Decimal ARApplied,
      Decimal ExchApplied,
      Decimal UnAcctApplied)
    {
      dsGetAccountsReceivable.AccountsReceivableRow row = (dsGetAccountsReceivable.AccountsReceivableRow) this.NewRow();
      object[] objArray = new object[27]
      {
        (object) invoicenum,
        (object) officeinvoicenum,
        (object) quoteid,
        (object) quotecontrolnum,
        (object) policynumber,
        (object) insuredpolicyname,
        (object) effectivedate,
        (object) expirationdate,
        (object) invoicedate,
        (object) chargename,
        (object) chargecode,
        (object) companylineguid,
        (object) amtbilled,
        (object) AmtPTD,
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
        (object) ARApplied,
        (object) ExchApplied,
        (object) UnAcctApplied
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsGetAccountsReceivable.AccountsReceivableDataTable receivableDataTable = (dsGetAccountsReceivable.AccountsReceivableDataTable) base.Clone();
      receivableDataTable.InitVars();
      return (DataTable) receivableDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsGetAccountsReceivable.AccountsReceivableDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columninvoicenum = this.Columns["invoicenum"];
      this.columnofficeinvoicenum = this.Columns["officeinvoicenum"];
      this.columnquoteid = this.Columns["quoteid"];
      this.columnquotecontrolnum = this.Columns["quotecontrolnum"];
      this.columnpolicynumber = this.Columns["policynumber"];
      this.columninsuredpolicyname = this.Columns["insuredpolicyname"];
      this.columneffectivedate = this.Columns["effectivedate"];
      this.columnexpirationdate = this.Columns["expirationdate"];
      this.columninvoicedate = this.Columns["invoicedate"];
      this.columnchargename = this.Columns["chargename"];
      this.columnchargecode = this.Columns["chargecode"];
      this.columncompanylineguid = this.Columns["companylineguid"];
      this.columnamtbilled = this.Columns["amtbilled"];
      this.columnAmtPTD = this.Columns["AmtPTD"];
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
      this.columnARApplied = this.Columns["ARApplied"];
      this.columnExchApplied = this.Columns["ExchApplied"];
      this.columnUnAcctApplied = this.Columns["UnAcctApplied"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columninvoicenum = new DataColumn("invoicenum", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columninvoicenum);
      this.columnofficeinvoicenum = new DataColumn("officeinvoicenum", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnofficeinvoicenum);
      this.columnquoteid = new DataColumn("quoteid", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnquoteid);
      this.columnquotecontrolnum = new DataColumn("quotecontrolnum", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnquotecontrolnum);
      this.columnpolicynumber = new DataColumn("policynumber", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnpolicynumber);
      this.columninsuredpolicyname = new DataColumn("insuredpolicyname", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columninsuredpolicyname);
      this.columneffectivedate = new DataColumn("effectivedate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columneffectivedate);
      this.columnexpirationdate = new DataColumn("expirationdate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnexpirationdate);
      this.columninvoicedate = new DataColumn("invoicedate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columninvoicedate);
      this.columnchargename = new DataColumn("chargename", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnchargename);
      this.columnchargecode = new DataColumn("chargecode", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnchargecode);
      this.columncompanylineguid = new DataColumn("companylineguid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columncompanylineguid);
      this.columnamtbilled = new DataColumn("amtbilled", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnamtbilled);
      this.columnAmtPTD = new DataColumn("AmtPTD", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAmtPTD);
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
      this.columnARApplied = new DataColumn("ARApplied", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnARApplied);
      this.columnExchApplied = new DataColumn("ExchApplied", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnExchApplied);
      this.columnUnAcctApplied = new DataColumn("UnAcctApplied", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnUnAcctApplied);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsGetAccountsReceivable.AccountsReceivableRow NewAccountsReceivableRow()
    {
      return (dsGetAccountsReceivable.AccountsReceivableRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsGetAccountsReceivable.AccountsReceivableRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (dsGetAccountsReceivable.AccountsReceivableRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.AccountsReceivableRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsGetAccountsReceivable.AccountsReceivableRowChangeEventHandler receivableRowChangedEvent = this.AccountsReceivableRowChangedEvent;
      if (receivableRowChangedEvent == null)
        return;
      receivableRowChangedEvent((object) this, new dsGetAccountsReceivable.AccountsReceivableRowChangeEvent((dsGetAccountsReceivable.AccountsReceivableRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.AccountsReceivableRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsGetAccountsReceivable.AccountsReceivableRowChangeEventHandler rowChangingEvent = this.AccountsReceivableRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsGetAccountsReceivable.AccountsReceivableRowChangeEvent((dsGetAccountsReceivable.AccountsReceivableRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.AccountsReceivableRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsGetAccountsReceivable.AccountsReceivableRowChangeEventHandler receivableRowDeletedEvent = this.AccountsReceivableRowDeletedEvent;
      if (receivableRowDeletedEvent == null)
        return;
      receivableRowDeletedEvent((object) this, new dsGetAccountsReceivable.AccountsReceivableRowChangeEvent((dsGetAccountsReceivable.AccountsReceivableRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.AccountsReceivableRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsGetAccountsReceivable.AccountsReceivableRowChangeEventHandler rowDeletingEvent = this.AccountsReceivableRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsGetAccountsReceivable.AccountsReceivableRowChangeEvent((dsGetAccountsReceivable.AccountsReceivableRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemoveAccountsReceivableRow(dsGetAccountsReceivable.AccountsReceivableRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsGetAccountsReceivable accountsReceivable = new dsGetAccountsReceivable();
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
        FixedValue = accountsReceivable.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (AccountsReceivableDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = accountsReceivable.GetSchemaSerializable();
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

  public class AccountsReceivableRow : DataRow
  {
    private dsGetAccountsReceivable.AccountsReceivableDataTable tableAccountsReceivable;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal AccountsReceivableRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableAccountsReceivable = (dsGetAccountsReceivable.AccountsReceivableDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int invoicenum
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tableAccountsReceivable.invoicenumColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'invoicenum' in table 'AccountsReceivable' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableAccountsReceivable.invoicenumColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int officeinvoicenum
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tableAccountsReceivable.officeinvoicenumColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'officeinvoicenum' in table 'AccountsReceivable' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableAccountsReceivable.officeinvoicenumColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int quoteid
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tableAccountsReceivable.quoteidColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'quoteid' in table 'AccountsReceivable' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableAccountsReceivable.quoteidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int quotecontrolnum
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tableAccountsReceivable.quotecontrolnumColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'quotecontrolnum' in table 'AccountsReceivable' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableAccountsReceivable.quotecontrolnumColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string policynumber
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableAccountsReceivable.policynumberColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'policynumber' in table 'AccountsReceivable' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableAccountsReceivable.policynumberColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string insuredpolicyname
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableAccountsReceivable.insuredpolicynameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'insuredpolicyname' in table 'AccountsReceivable' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableAccountsReceivable.insuredpolicynameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DateTime effectivedate
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tableAccountsReceivable.effectivedateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'effectivedate' in table 'AccountsReceivable' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableAccountsReceivable.effectivedateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DateTime expirationdate
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tableAccountsReceivable.expirationdateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'expirationdate' in table 'AccountsReceivable' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableAccountsReceivable.expirationdateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DateTime invoicedate
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tableAccountsReceivable.invoicedateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'invoicedate' in table 'AccountsReceivable' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableAccountsReceivable.invoicedateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string chargename
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableAccountsReceivable.chargenameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'chargename' in table 'AccountsReceivable' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableAccountsReceivable.chargenameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int chargecode
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tableAccountsReceivable.chargecodeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'chargecode' in table 'AccountsReceivable' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableAccountsReceivable.chargecodeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Guid companylineguid
    {
      get
      {
        try
        {
          object obj = this[this.tableAccountsReceivable.companylineguidColumn];
          return obj != null ? (Guid) obj : new Guid();
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'companylineguid' in table 'AccountsReceivable' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableAccountsReceivable.companylineguidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal amtbilled
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tableAccountsReceivable.amtbilledColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'amtbilled' in table 'AccountsReceivable' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableAccountsReceivable.amtbilledColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal AmtPTD
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tableAccountsReceivable.AmtPTDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'AmtPTD' in table 'AccountsReceivable' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableAccountsReceivable.AmtPTDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal NetDue
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tableAccountsReceivable.NetDueColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'NetDue' in table 'AccountsReceivable' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableAccountsReceivable.NetDueColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal AmtPTC
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tableAccountsReceivable.AmtPTCColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'AmtPTC' in table 'AccountsReceivable' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableAccountsReceivable.AmtPTCColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal UnacctBalance
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tableAccountsReceivable.UnacctBalanceColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'UnacctBalance' in table 'AccountsReceivable' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableAccountsReceivable.UnacctBalanceColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal ExchBalance
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tableAccountsReceivable.ExchBalanceColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ExchBalance' in table 'AccountsReceivable' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableAccountsReceivable.ExchBalanceColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int ARGL
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tableAccountsReceivable.ARGLColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ARGL' in table 'AccountsReceivable' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableAccountsReceivable.ARGLColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int EXGL
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tableAccountsReceivable.EXGLColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'EXGL' in table 'AccountsReceivable' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableAccountsReceivable.EXGLColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int UAGL
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tableAccountsReceivable.UAGLColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'UAGL' in table 'AccountsReceivable' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableAccountsReceivable.UAGLColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string AccountNumber
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableAccountsReceivable.AccountNumberColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'AccountNumber' in table 'AccountsReceivable' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableAccountsReceivable.AccountNumberColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string CurrentStatus
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableAccountsReceivable.CurrentStatusColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'CurrentStatus' in table 'AccountsReceivable' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableAccountsReceivable.CurrentStatusColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string FinanceCompanyGuid
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableAccountsReceivable.FinanceCompanyGuidColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'FinanceCompanyGuid' in table 'AccountsReceivable' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableAccountsReceivable.FinanceCompanyGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal ARApplied
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tableAccountsReceivable.ARAppliedColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ARApplied' in table 'AccountsReceivable' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableAccountsReceivable.ARAppliedColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal ExchApplied
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tableAccountsReceivable.ExchAppliedColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ExchApplied' in table 'AccountsReceivable' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableAccountsReceivable.ExchAppliedColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal UnAcctApplied
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tableAccountsReceivable.UnAcctAppliedColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'UnAcctApplied' in table 'AccountsReceivable' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableAccountsReceivable.UnAcctAppliedColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsinvoicenumNull() => this.IsNull(this.tableAccountsReceivable.invoicenumColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetinvoicenumNull()
    {
      this[this.tableAccountsReceivable.invoicenumColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsofficeinvoicenumNull()
    {
      return this.IsNull(this.tableAccountsReceivable.officeinvoicenumColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetofficeinvoicenumNull()
    {
      this[this.tableAccountsReceivable.officeinvoicenumColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsquoteidNull() => this.IsNull(this.tableAccountsReceivable.quoteidColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetquoteidNull()
    {
      this[this.tableAccountsReceivable.quoteidColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsquotecontrolnumNull()
    {
      return this.IsNull(this.tableAccountsReceivable.quotecontrolnumColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetquotecontrolnumNull()
    {
      this[this.tableAccountsReceivable.quotecontrolnumColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IspolicynumberNull()
    {
      return this.IsNull(this.tableAccountsReceivable.policynumberColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetpolicynumberNull()
    {
      this[this.tableAccountsReceivable.policynumberColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsinsuredpolicynameNull()
    {
      return this.IsNull(this.tableAccountsReceivable.insuredpolicynameColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetinsuredpolicynameNull()
    {
      this[this.tableAccountsReceivable.insuredpolicynameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IseffectivedateNull()
    {
      return this.IsNull(this.tableAccountsReceivable.effectivedateColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SeteffectivedateNull()
    {
      this[this.tableAccountsReceivable.effectivedateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsexpirationdateNull()
    {
      return this.IsNull(this.tableAccountsReceivable.expirationdateColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetexpirationdateNull()
    {
      this[this.tableAccountsReceivable.expirationdateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsinvoicedateNull() => this.IsNull(this.tableAccountsReceivable.invoicedateColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetinvoicedateNull()
    {
      this[this.tableAccountsReceivable.invoicedateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IschargenameNull() => this.IsNull(this.tableAccountsReceivable.chargenameColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetchargenameNull()
    {
      this[this.tableAccountsReceivable.chargenameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IschargecodeNull() => this.IsNull(this.tableAccountsReceivable.chargecodeColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetchargecodeNull()
    {
      this[this.tableAccountsReceivable.chargecodeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IscompanylineguidNull()
    {
      return this.IsNull(this.tableAccountsReceivable.companylineguidColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetcompanylineguidNull()
    {
      this[this.tableAccountsReceivable.companylineguidColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsamtbilledNull() => this.IsNull(this.tableAccountsReceivable.amtbilledColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetamtbilledNull()
    {
      this[this.tableAccountsReceivable.amtbilledColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsAmtPTDNull() => this.IsNull(this.tableAccountsReceivable.AmtPTDColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetAmtPTDNull()
    {
      this[this.tableAccountsReceivable.AmtPTDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsNetDueNull() => this.IsNull(this.tableAccountsReceivable.NetDueColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetNetDueNull()
    {
      this[this.tableAccountsReceivable.NetDueColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsAmtPTCNull() => this.IsNull(this.tableAccountsReceivable.AmtPTCColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetAmtPTCNull()
    {
      this[this.tableAccountsReceivable.AmtPTCColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsUnacctBalanceNull()
    {
      return this.IsNull(this.tableAccountsReceivable.UnacctBalanceColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetUnacctBalanceNull()
    {
      this[this.tableAccountsReceivable.UnacctBalanceColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsExchBalanceNull() => this.IsNull(this.tableAccountsReceivable.ExchBalanceColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetExchBalanceNull()
    {
      this[this.tableAccountsReceivable.ExchBalanceColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsARGLNull() => this.IsNull(this.tableAccountsReceivable.ARGLColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetARGLNull()
    {
      this[this.tableAccountsReceivable.ARGLColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsEXGLNull() => this.IsNull(this.tableAccountsReceivable.EXGLColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetEXGLNull()
    {
      this[this.tableAccountsReceivable.EXGLColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsUAGLNull() => this.IsNull(this.tableAccountsReceivable.UAGLColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetUAGLNull()
    {
      this[this.tableAccountsReceivable.UAGLColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsAccountNumberNull()
    {
      return this.IsNull(this.tableAccountsReceivable.AccountNumberColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetAccountNumberNull()
    {
      this[this.tableAccountsReceivable.AccountNumberColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsCurrentStatusNull()
    {
      return this.IsNull(this.tableAccountsReceivable.CurrentStatusColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetCurrentStatusNull()
    {
      this[this.tableAccountsReceivable.CurrentStatusColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsFinanceCompanyGuidNull()
    {
      return this.IsNull(this.tableAccountsReceivable.FinanceCompanyGuidColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetFinanceCompanyGuidNull()
    {
      this[this.tableAccountsReceivable.FinanceCompanyGuidColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsARAppliedNull() => this.IsNull(this.tableAccountsReceivable.ARAppliedColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetARAppliedNull()
    {
      this[this.tableAccountsReceivable.ARAppliedColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsExchAppliedNull() => this.IsNull(this.tableAccountsReceivable.ExchAppliedColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetExchAppliedNull()
    {
      this[this.tableAccountsReceivable.ExchAppliedColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsUnAcctAppliedNull()
    {
      return this.IsNull(this.tableAccountsReceivable.UnAcctAppliedColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetUnAcctAppliedNull()
    {
      this[this.tableAccountsReceivable.UnAcctAppliedColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class AccountsReceivableRowChangeEvent : EventArgs
  {
    private dsGetAccountsReceivable.AccountsReceivableRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public AccountsReceivableRowChangeEvent(
      dsGetAccountsReceivable.AccountsReceivableRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsGetAccountsReceivable.AccountsReceivableRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }
}
