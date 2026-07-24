// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.AccountingDatasets.dsGetAccountsPayable
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
[XmlRoot("dsGetAccountsPayable")]
[HelpKeyword("vs.data.DataSet")]
[Serializable]
public class dsGetAccountsPayable : DataSet
{
  private dsGetAccountsPayable.AcctsPayableDataTable tableAcctsPayable;
  private SchemaSerializationMode _schemaSerializationMode;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public dsGetAccountsPayable()
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
  protected dsGetAccountsPayable(SerializationInfo info, StreamingContext context)
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
        if (dataSet.Tables[nameof (AcctsPayable)] != null)
          base.Tables.Add((DataTable) new dsGetAccountsPayable.AcctsPayableDataTable(dataSet.Tables[nameof (AcctsPayable)]));
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
  public dsGetAccountsPayable.AcctsPayableDataTable AcctsPayable => this.tableAcctsPayable;

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
    dsGetAccountsPayable getAccountsPayable = (dsGetAccountsPayable) base.Clone();
    getAccountsPayable.InitVars();
    getAccountsPayable.SchemaSerializationMode = this.SchemaSerializationMode;
    return (DataSet) getAccountsPayable;
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
      if (dataSet.Tables["AcctsPayable"] != null)
        base.Tables.Add((DataTable) new dsGetAccountsPayable.AcctsPayableDataTable(dataSet.Tables["AcctsPayable"]));
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
    this.tableAcctsPayable = (dsGetAccountsPayable.AcctsPayableDataTable) base.Tables["AcctsPayable"];
    if (!initTable || this.tableAcctsPayable == null)
      return;
    this.tableAcctsPayable.InitVars();
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private void InitClass()
  {
    this.DataSetName = nameof (dsGetAccountsPayable);
    this.Prefix = "";
    this.Namespace = "http://www.tempuri.org/dsGetAccountsPayable.xsd";
    this.EnforceConstraints = true;
    this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.tableAcctsPayable = new dsGetAccountsPayable.AcctsPayableDataTable();
    base.Tables.Add((DataTable) this.tableAcctsPayable);
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializeAcctsPayable() => false;

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
    dsGetAccountsPayable getAccountsPayable = new dsGetAccountsPayable();
    XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
    schemaComplexType.Particle = (XmlSchemaParticle) new XmlSchemaSequence()
    {
      Items = {
        (XmlSchemaObject) new XmlSchemaAny()
        {
          Namespace = getAccountsPayable.Namespace
        }
      }
    };
    XmlSchema schemaSerializable = getAccountsPayable.GetSchemaSerializable();
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
  public delegate void AcctsPayableRowChangeEventHandler(
    object sender,
    dsGetAccountsPayable.AcctsPayableRowChangeEvent e);

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class AcctsPayableDataTable : TypedTableBase<dsGetAccountsPayable.AcctsPayableRow>
  {
    private DataColumn columninvoicenum;
    private DataColumn columnglcompanyid;
    private DataColumn columnpayeeguid;
    private DataColumn columncompanylineguid;
    private DataColumn columnchargecode;
    private DataColumn columnpolicynumber;
    private DataColumn columninsuredpolicyname;
    private DataColumn columneffectivedate;
    private DataColumn columnexpirationdate;
    private DataColumn columnofficeinvoicenum;
    private DataColumn columnpayee;
    private DataColumn columnchargename;
    private DataColumn columngross_payable;
    private DataColumn columnamtptd;
    private DataColumn columnnet_payable;
    private DataColumn columnamt_rcvd;
    private DataColumn columnexch_balance;
    private DataColumn columnunacct_balance;
    private DataColumn columnapgl;
    private DataColumn columnexgl;
    private DataColumn columnuagl;
    private DataColumn columnpropamt;
    private DataColumn columnaccountnumber;
    private DataColumn columnquotecontrolnum;
    private DataColumn columnInvoiceDate;
    private DataColumn columnapapplied;
    private DataColumn columnCurrencyCode;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public AcctsPayableDataTable()
    {
      this.TableName = "AcctsPayable";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal AcctsPayableDataTable(DataTable table)
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
    protected AcctsPayableDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn invoicenumColumn => this.columninvoicenum;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn glcompanyidColumn => this.columnglcompanyid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn payeeguidColumn => this.columnpayeeguid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn companylineguidColumn => this.columncompanylineguid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn chargecodeColumn => this.columnchargecode;

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
    public DataColumn officeinvoicenumColumn => this.columnofficeinvoicenum;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn payeeColumn => this.columnpayee;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn chargenameColumn => this.columnchargename;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn gross_payableColumn => this.columngross_payable;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn amtptdColumn => this.columnamtptd;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn net_payableColumn => this.columnnet_payable;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn amt_rcvdColumn => this.columnamt_rcvd;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn exch_balanceColumn => this.columnexch_balance;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn unacct_balanceColumn => this.columnunacct_balance;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn apglColumn => this.columnapgl;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn exglColumn => this.columnexgl;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn uaglColumn => this.columnuagl;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn propamtColumn => this.columnpropamt;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn accountnumberColumn => this.columnaccountnumber;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn quotecontrolnumColumn => this.columnquotecontrolnum;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn InvoiceDateColumn => this.columnInvoiceDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn apappliedColumn => this.columnapapplied;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn CurrencyCodeColumn => this.columnCurrencyCode;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsGetAccountsPayable.AcctsPayableRow this[int index]
    {
      get => (dsGetAccountsPayable.AcctsPayableRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsGetAccountsPayable.AcctsPayableRowChangeEventHandler AcctsPayableRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsGetAccountsPayable.AcctsPayableRowChangeEventHandler AcctsPayableRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsGetAccountsPayable.AcctsPayableRowChangeEventHandler AcctsPayableRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsGetAccountsPayable.AcctsPayableRowChangeEventHandler AcctsPayableRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddAcctsPayableRow(dsGetAccountsPayable.AcctsPayableRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsGetAccountsPayable.AcctsPayableRow AddAcctsPayableRow(
      int invoicenum,
      int glcompanyid,
      string payeeguid,
      string companylineguid,
      int chargecode,
      string policynumber,
      string insuredpolicyname,
      DateTime effectivedate,
      DateTime expirationdate,
      int officeinvoicenum,
      string payee,
      string chargename,
      Decimal gross_payable,
      Decimal amtptd,
      Decimal net_payable,
      Decimal amt_rcvd,
      Decimal exch_balance,
      Decimal unacct_balance,
      int apgl,
      int exgl,
      int uagl,
      Decimal propamt,
      string accountnumber,
      int quotecontrolnum,
      DateTime InvoiceDate,
      Decimal apapplied,
      string CurrencyCode)
    {
      dsGetAccountsPayable.AcctsPayableRow row = (dsGetAccountsPayable.AcctsPayableRow) this.NewRow();
      object[] objArray = new object[27]
      {
        (object) invoicenum,
        (object) glcompanyid,
        (object) payeeguid,
        (object) companylineguid,
        (object) chargecode,
        (object) policynumber,
        (object) insuredpolicyname,
        (object) effectivedate,
        (object) expirationdate,
        (object) officeinvoicenum,
        (object) payee,
        (object) chargename,
        (object) gross_payable,
        (object) amtptd,
        (object) net_payable,
        (object) amt_rcvd,
        (object) exch_balance,
        (object) unacct_balance,
        (object) apgl,
        (object) exgl,
        (object) uagl,
        (object) propamt,
        (object) accountnumber,
        (object) quotecontrolnum,
        (object) InvoiceDate,
        (object) apapplied,
        (object) CurrencyCode
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsGetAccountsPayable.AcctsPayableDataTable payableDataTable = (dsGetAccountsPayable.AcctsPayableDataTable) base.Clone();
      payableDataTable.InitVars();
      return (DataTable) payableDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsGetAccountsPayable.AcctsPayableDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columninvoicenum = this.Columns["invoicenum"];
      this.columnglcompanyid = this.Columns["glcompanyid"];
      this.columnpayeeguid = this.Columns["payeeguid"];
      this.columncompanylineguid = this.Columns["companylineguid"];
      this.columnchargecode = this.Columns["chargecode"];
      this.columnpolicynumber = this.Columns["policynumber"];
      this.columninsuredpolicyname = this.Columns["insuredpolicyname"];
      this.columneffectivedate = this.Columns["effectivedate"];
      this.columnexpirationdate = this.Columns["expirationdate"];
      this.columnofficeinvoicenum = this.Columns["officeinvoicenum"];
      this.columnpayee = this.Columns["payee"];
      this.columnchargename = this.Columns["chargename"];
      this.columngross_payable = this.Columns["gross payable"];
      this.columnamtptd = this.Columns["amtptd"];
      this.columnnet_payable = this.Columns["net payable"];
      this.columnamt_rcvd = this.Columns["amt rcvd"];
      this.columnexch_balance = this.Columns["exch balance"];
      this.columnunacct_balance = this.Columns["unacct balance"];
      this.columnapgl = this.Columns["apgl"];
      this.columnexgl = this.Columns["exgl"];
      this.columnuagl = this.Columns["uagl"];
      this.columnpropamt = this.Columns["propamt"];
      this.columnaccountnumber = this.Columns["accountnumber"];
      this.columnquotecontrolnum = this.Columns["quotecontrolnum"];
      this.columnInvoiceDate = this.Columns["InvoiceDate"];
      this.columnapapplied = this.Columns["apapplied"];
      this.columnCurrencyCode = this.Columns["CurrencyCode"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columninvoicenum = new DataColumn("invoicenum", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columninvoicenum);
      this.columnglcompanyid = new DataColumn("glcompanyid", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnglcompanyid);
      this.columnpayeeguid = new DataColumn("payeeguid", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnpayeeguid);
      this.columncompanylineguid = new DataColumn("companylineguid", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columncompanylineguid);
      this.columnchargecode = new DataColumn("chargecode", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnchargecode);
      this.columnpolicynumber = new DataColumn("policynumber", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnpolicynumber);
      this.columninsuredpolicyname = new DataColumn("insuredpolicyname", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columninsuredpolicyname);
      this.columneffectivedate = new DataColumn("effectivedate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columneffectivedate);
      this.columnexpirationdate = new DataColumn("expirationdate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnexpirationdate);
      this.columnofficeinvoicenum = new DataColumn("officeinvoicenum", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnofficeinvoicenum);
      this.columnpayee = new DataColumn("payee", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnpayee);
      this.columnchargename = new DataColumn("chargename", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnchargename);
      this.columngross_payable = new DataColumn("gross payable", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columngross_payable);
      this.columnamtptd = new DataColumn("amtptd", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnamtptd);
      this.columnnet_payable = new DataColumn("net payable", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnnet_payable);
      this.columnamt_rcvd = new DataColumn("amt rcvd", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnamt_rcvd);
      this.columnexch_balance = new DataColumn("exch balance", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnexch_balance);
      this.columnunacct_balance = new DataColumn("unacct balance", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnunacct_balance);
      this.columnapgl = new DataColumn("apgl", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnapgl);
      this.columnexgl = new DataColumn("exgl", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnexgl);
      this.columnuagl = new DataColumn("uagl", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnuagl);
      this.columnpropamt = new DataColumn("propamt", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnpropamt);
      this.columnaccountnumber = new DataColumn("accountnumber", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnaccountnumber);
      this.columnquotecontrolnum = new DataColumn("quotecontrolnum", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnquotecontrolnum);
      this.columnInvoiceDate = new DataColumn("InvoiceDate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInvoiceDate);
      this.columnapapplied = new DataColumn("apapplied", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnapapplied);
      this.columnCurrencyCode = new DataColumn("CurrencyCode", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCurrencyCode);
      this.columnCurrencyCode.DefaultValue = (object) "USD";
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsGetAccountsPayable.AcctsPayableRow NewAcctsPayableRow()
    {
      return (dsGetAccountsPayable.AcctsPayableRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsGetAccountsPayable.AcctsPayableRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (dsGetAccountsPayable.AcctsPayableRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.AcctsPayableRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsGetAccountsPayable.AcctsPayableRowChangeEventHandler payableRowChangedEvent = this.AcctsPayableRowChangedEvent;
      if (payableRowChangedEvent == null)
        return;
      payableRowChangedEvent((object) this, new dsGetAccountsPayable.AcctsPayableRowChangeEvent((dsGetAccountsPayable.AcctsPayableRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.AcctsPayableRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsGetAccountsPayable.AcctsPayableRowChangeEventHandler rowChangingEvent = this.AcctsPayableRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsGetAccountsPayable.AcctsPayableRowChangeEvent((dsGetAccountsPayable.AcctsPayableRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.AcctsPayableRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsGetAccountsPayable.AcctsPayableRowChangeEventHandler payableRowDeletedEvent = this.AcctsPayableRowDeletedEvent;
      if (payableRowDeletedEvent == null)
        return;
      payableRowDeletedEvent((object) this, new dsGetAccountsPayable.AcctsPayableRowChangeEvent((dsGetAccountsPayable.AcctsPayableRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.AcctsPayableRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsGetAccountsPayable.AcctsPayableRowChangeEventHandler rowDeletingEvent = this.AcctsPayableRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsGetAccountsPayable.AcctsPayableRowChangeEvent((dsGetAccountsPayable.AcctsPayableRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemoveAcctsPayableRow(dsGetAccountsPayable.AcctsPayableRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsGetAccountsPayable getAccountsPayable = new dsGetAccountsPayable();
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
        FixedValue = getAccountsPayable.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (AcctsPayableDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = getAccountsPayable.GetSchemaSerializable();
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

  public class AcctsPayableRow : DataRow
  {
    private dsGetAccountsPayable.AcctsPayableDataTable tableAcctsPayable;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal AcctsPayableRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableAcctsPayable = (dsGetAccountsPayable.AcctsPayableDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int invoicenum
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tableAcctsPayable.invoicenumColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'invoicenum' in table 'AcctsPayable' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableAcctsPayable.invoicenumColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int glcompanyid
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tableAcctsPayable.glcompanyidColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'glcompanyid' in table 'AcctsPayable' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableAcctsPayable.glcompanyidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string payeeguid
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableAcctsPayable.payeeguidColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'payeeguid' in table 'AcctsPayable' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableAcctsPayable.payeeguidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string companylineguid
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableAcctsPayable.companylineguidColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'companylineguid' in table 'AcctsPayable' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableAcctsPayable.companylineguidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int chargecode
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tableAcctsPayable.chargecodeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'chargecode' in table 'AcctsPayable' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableAcctsPayable.chargecodeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string policynumber
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableAcctsPayable.policynumberColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'policynumber' in table 'AcctsPayable' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableAcctsPayable.policynumberColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string insuredpolicyname
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableAcctsPayable.insuredpolicynameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'insuredpolicyname' in table 'AcctsPayable' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableAcctsPayable.insuredpolicynameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DateTime effectivedate
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tableAcctsPayable.effectivedateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'effectivedate' in table 'AcctsPayable' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableAcctsPayable.effectivedateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DateTime expirationdate
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tableAcctsPayable.expirationdateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'expirationdate' in table 'AcctsPayable' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableAcctsPayable.expirationdateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int officeinvoicenum
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tableAcctsPayable.officeinvoicenumColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'officeinvoicenum' in table 'AcctsPayable' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableAcctsPayable.officeinvoicenumColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string payee
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableAcctsPayable.payeeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'payee' in table 'AcctsPayable' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableAcctsPayable.payeeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string chargename
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableAcctsPayable.chargenameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'chargename' in table 'AcctsPayable' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableAcctsPayable.chargenameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal gross_payable
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tableAcctsPayable.gross_payableColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'gross payable' in table 'AcctsPayable' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableAcctsPayable.gross_payableColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal amtptd
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tableAcctsPayable.amtptdColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'amtptd' in table 'AcctsPayable' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableAcctsPayable.amtptdColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal net_payable
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tableAcctsPayable.net_payableColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'net payable' in table 'AcctsPayable' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableAcctsPayable.net_payableColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal amt_rcvd
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tableAcctsPayable.amt_rcvdColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'amt rcvd' in table 'AcctsPayable' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableAcctsPayable.amt_rcvdColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal exch_balance
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tableAcctsPayable.exch_balanceColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'exch balance' in table 'AcctsPayable' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableAcctsPayable.exch_balanceColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal unacct_balance
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tableAcctsPayable.unacct_balanceColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'unacct balance' in table 'AcctsPayable' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableAcctsPayable.unacct_balanceColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int apgl
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tableAcctsPayable.apglColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'apgl' in table 'AcctsPayable' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableAcctsPayable.apglColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int exgl
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tableAcctsPayable.exglColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'exgl' in table 'AcctsPayable' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableAcctsPayable.exglColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int uagl
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tableAcctsPayable.uaglColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'uagl' in table 'AcctsPayable' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableAcctsPayable.uaglColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal propamt
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tableAcctsPayable.propamtColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'propamt' in table 'AcctsPayable' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableAcctsPayable.propamtColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string accountnumber
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableAcctsPayable.accountnumberColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'accountnumber' in table 'AcctsPayable' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableAcctsPayable.accountnumberColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int quotecontrolnum
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tableAcctsPayable.quotecontrolnumColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'quotecontrolnum' in table 'AcctsPayable' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableAcctsPayable.quotecontrolnumColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DateTime InvoiceDate
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tableAcctsPayable.InvoiceDateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'InvoiceDate' in table 'AcctsPayable' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableAcctsPayable.InvoiceDateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal apapplied
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tableAcctsPayable.apappliedColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'apapplied' in table 'AcctsPayable' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableAcctsPayable.apappliedColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string CurrencyCode
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableAcctsPayable.CurrencyCodeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'CurrencyCode' in table 'AcctsPayable' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableAcctsPayable.CurrencyCodeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsinvoicenumNull() => this.IsNull(this.tableAcctsPayable.invoicenumColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetinvoicenumNull()
    {
      this[this.tableAcctsPayable.invoicenumColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsglcompanyidNull() => this.IsNull(this.tableAcctsPayable.glcompanyidColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetglcompanyidNull()
    {
      this[this.tableAcctsPayable.glcompanyidColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IspayeeguidNull() => this.IsNull(this.tableAcctsPayable.payeeguidColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetpayeeguidNull()
    {
      this[this.tableAcctsPayable.payeeguidColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IscompanylineguidNull()
    {
      return this.IsNull(this.tableAcctsPayable.companylineguidColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetcompanylineguidNull()
    {
      this[this.tableAcctsPayable.companylineguidColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IschargecodeNull() => this.IsNull(this.tableAcctsPayable.chargecodeColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetchargecodeNull()
    {
      this[this.tableAcctsPayable.chargecodeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IspolicynumberNull() => this.IsNull(this.tableAcctsPayable.policynumberColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetpolicynumberNull()
    {
      this[this.tableAcctsPayable.policynumberColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsinsuredpolicynameNull()
    {
      return this.IsNull(this.tableAcctsPayable.insuredpolicynameColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetinsuredpolicynameNull()
    {
      this[this.tableAcctsPayable.insuredpolicynameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IseffectivedateNull() => this.IsNull(this.tableAcctsPayable.effectivedateColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SeteffectivedateNull()
    {
      this[this.tableAcctsPayable.effectivedateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsexpirationdateNull() => this.IsNull(this.tableAcctsPayable.expirationdateColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetexpirationdateNull()
    {
      this[this.tableAcctsPayable.expirationdateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsofficeinvoicenumNull()
    {
      return this.IsNull(this.tableAcctsPayable.officeinvoicenumColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetofficeinvoicenumNull()
    {
      this[this.tableAcctsPayable.officeinvoicenumColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IspayeeNull() => this.IsNull(this.tableAcctsPayable.payeeColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetpayeeNull()
    {
      this[this.tableAcctsPayable.payeeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IschargenameNull() => this.IsNull(this.tableAcctsPayable.chargenameColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetchargenameNull()
    {
      this[this.tableAcctsPayable.chargenameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool Isgross_payableNull() => this.IsNull(this.tableAcctsPayable.gross_payableColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void Setgross_payableNull()
    {
      this[this.tableAcctsPayable.gross_payableColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsamtptdNull() => this.IsNull(this.tableAcctsPayable.amtptdColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetamtptdNull()
    {
      this[this.tableAcctsPayable.amtptdColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool Isnet_payableNull() => this.IsNull(this.tableAcctsPayable.net_payableColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void Setnet_payableNull()
    {
      this[this.tableAcctsPayable.net_payableColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool Isamt_rcvdNull() => this.IsNull(this.tableAcctsPayable.amt_rcvdColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void Setamt_rcvdNull()
    {
      this[this.tableAcctsPayable.amt_rcvdColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool Isexch_balanceNull() => this.IsNull(this.tableAcctsPayable.exch_balanceColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void Setexch_balanceNull()
    {
      this[this.tableAcctsPayable.exch_balanceColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool Isunacct_balanceNull() => this.IsNull(this.tableAcctsPayable.unacct_balanceColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void Setunacct_balanceNull()
    {
      this[this.tableAcctsPayable.unacct_balanceColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsapglNull() => this.IsNull(this.tableAcctsPayable.apglColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetapglNull()
    {
      this[this.tableAcctsPayable.apglColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsexglNull() => this.IsNull(this.tableAcctsPayable.exglColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetexglNull()
    {
      this[this.tableAcctsPayable.exglColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsuaglNull() => this.IsNull(this.tableAcctsPayable.uaglColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetuaglNull()
    {
      this[this.tableAcctsPayable.uaglColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IspropamtNull() => this.IsNull(this.tableAcctsPayable.propamtColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetpropamtNull()
    {
      this[this.tableAcctsPayable.propamtColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsaccountnumberNull() => this.IsNull(this.tableAcctsPayable.accountnumberColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetaccountnumberNull()
    {
      this[this.tableAcctsPayable.accountnumberColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsquotecontrolnumNull()
    {
      return this.IsNull(this.tableAcctsPayable.quotecontrolnumColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetquotecontrolnumNull()
    {
      this[this.tableAcctsPayable.quotecontrolnumColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsInvoiceDateNull() => this.IsNull(this.tableAcctsPayable.InvoiceDateColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetInvoiceDateNull()
    {
      this[this.tableAcctsPayable.InvoiceDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsapappliedNull() => this.IsNull(this.tableAcctsPayable.apappliedColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetapappliedNull()
    {
      this[this.tableAcctsPayable.apappliedColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsCurrencyCodeNull() => this.IsNull(this.tableAcctsPayable.CurrencyCodeColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetCurrencyCodeNull()
    {
      this[this.tableAcctsPayable.CurrencyCodeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class AcctsPayableRowChangeEvent : EventArgs
  {
    private dsGetAccountsPayable.AcctsPayableRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public AcctsPayableRowChangeEvent(
      dsGetAccountsPayable.AcctsPayableRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsGetAccountsPayable.AcctsPayableRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }
}
