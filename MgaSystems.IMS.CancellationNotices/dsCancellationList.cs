// Decompiled with JetBrains decompiler
// Type: CancellationNotices.dsCancellationList
// Assembly: MgaSystems.IMS.CancellationNotices, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 212B4515-7BA8-45EF-B7D5-4974627BD234
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.CancellationNotices.dll

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
namespace CancellationNotices;

[DesignerCategory("code")]
[ToolboxItem(true)]
[XmlSchemaProvider("GetTypedDataSetSchema")]
[XmlRoot("dsCancellationList")]
[HelpKeyword("vs.data.DataSet")]
[Serializable]
public class dsCancellationList : DataSet
{
  private dsCancellationList.CancellationListDataTable tableCancellationList;
  private dsCancellationList.CertifiedMailListDataTable tableCertifiedMailList;
  private dsCancellationList.EnvelopeListDataTable tableEnvelopeList;
  private SchemaSerializationMode _schemaSerializationMode;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  public dsCancellationList()
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
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  protected dsCancellationList(SerializationInfo info, StreamingContext context)
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
        if (dataSet.Tables[nameof (CancellationList)] != null)
          base.Tables.Add((DataTable) new dsCancellationList.CancellationListDataTable(dataSet.Tables[nameof (CancellationList)]));
        if (dataSet.Tables[nameof (CertifiedMailList)] != null)
          base.Tables.Add((DataTable) new dsCancellationList.CertifiedMailListDataTable(dataSet.Tables[nameof (CertifiedMailList)]));
        if (dataSet.Tables[nameof (EnvelopeList)] != null)
          base.Tables.Add((DataTable) new dsCancellationList.EnvelopeListDataTable(dataSet.Tables[nameof (EnvelopeList)]));
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
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsCancellationList.CancellationListDataTable CancellationList
  {
    get => this.tableCancellationList;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsCancellationList.CertifiedMailListDataTable CertifiedMailList
  {
    get => this.tableCertifiedMailList;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsCancellationList.EnvelopeListDataTable EnvelopeList => this.tableEnvelopeList;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  [Browsable(true)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
  public override SchemaSerializationMode SchemaSerializationMode
  {
    get => this._schemaSerializationMode;
    set => this._schemaSerializationMode = value;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public new DataTableCollection Tables => base.Tables;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public new DataRelationCollection Relations => base.Relations;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  protected override void InitializeDerivedDataSet()
  {
    this.BeginInit();
    this.InitClass();
    this.EndInit();
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  public override DataSet Clone()
  {
    dsCancellationList cancellationList = (dsCancellationList) base.Clone();
    cancellationList.InitVars();
    cancellationList.SchemaSerializationMode = this.SchemaSerializationMode;
    return (DataSet) cancellationList;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  protected override bool ShouldSerializeTables() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  protected override bool ShouldSerializeRelations() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  protected override void ReadXmlSerializable(XmlReader reader)
  {
    if (this.DetermineSchemaSerializationMode(reader) == SchemaSerializationMode.IncludeSchema)
    {
      this.Reset();
      DataSet dataSet = new DataSet();
      int num = (int) dataSet.ReadXml(reader);
      if (dataSet.Tables["CancellationList"] != null)
        base.Tables.Add((DataTable) new dsCancellationList.CancellationListDataTable(dataSet.Tables["CancellationList"]));
      if (dataSet.Tables["CertifiedMailList"] != null)
        base.Tables.Add((DataTable) new dsCancellationList.CertifiedMailListDataTable(dataSet.Tables["CertifiedMailList"]));
      if (dataSet.Tables["EnvelopeList"] != null)
        base.Tables.Add((DataTable) new dsCancellationList.EnvelopeListDataTable(dataSet.Tables["EnvelopeList"]));
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
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  protected override XmlSchema GetSchemaSerializable()
  {
    MemoryStream memoryStream = new MemoryStream();
    this.WriteXmlSchema((XmlWriter) new XmlTextWriter((Stream) memoryStream, (Encoding) null));
    memoryStream.Position = 0L;
    return XmlSchema.Read((XmlReader) new XmlTextReader((Stream) memoryStream), (ValidationEventHandler) null);
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  internal void InitVars() => this.InitVars(true);

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  internal void InitVars(bool initTable)
  {
    this.tableCancellationList = (dsCancellationList.CancellationListDataTable) base.Tables["CancellationList"];
    if (initTable && this.tableCancellationList != null)
      this.tableCancellationList.InitVars();
    this.tableCertifiedMailList = (dsCancellationList.CertifiedMailListDataTable) base.Tables["CertifiedMailList"];
    if (initTable && this.tableCertifiedMailList != null)
      this.tableCertifiedMailList.InitVars();
    this.tableEnvelopeList = (dsCancellationList.EnvelopeListDataTable) base.Tables["EnvelopeList"];
    if (!initTable || this.tableEnvelopeList == null)
      return;
    this.tableEnvelopeList.InitVars();
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  private void InitClass()
  {
    this.DataSetName = nameof (dsCancellationList);
    this.Prefix = "";
    this.Namespace = "http://tempuri.org/dsCancellationList.xsd";
    this.EnforceConstraints = true;
    this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.tableCancellationList = new dsCancellationList.CancellationListDataTable();
    base.Tables.Add((DataTable) this.tableCancellationList);
    this.tableCertifiedMailList = new dsCancellationList.CertifiedMailListDataTable();
    base.Tables.Add((DataTable) this.tableCertifiedMailList);
    this.tableEnvelopeList = new dsCancellationList.EnvelopeListDataTable();
    base.Tables.Add((DataTable) this.tableEnvelopeList);
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  private bool ShouldSerializeCancellationList() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  private bool ShouldSerializeCertifiedMailList() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  private bool ShouldSerializeEnvelopeList() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  private void SchemaChanged(object sender, CollectionChangeEventArgs e)
  {
    if (e.Action != CollectionChangeAction.Remove)
      return;
    this.InitVars();
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  public static XmlSchemaComplexType GetTypedDataSetSchema(XmlSchemaSet xs)
  {
    dsCancellationList cancellationList = new dsCancellationList();
    XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
    schemaComplexType.Particle = (XmlSchemaParticle) new XmlSchemaSequence()
    {
      Items = {
        (XmlSchemaObject) new XmlSchemaAny()
        {
          Namespace = cancellationList.Namespace
        }
      }
    };
    XmlSchema schemaSerializable = cancellationList.GetSchemaSerializable();
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

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  public delegate void CancellationListRowChangeEventHandler(
    object sender,
    dsCancellationList.CancellationListRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  public delegate void CertifiedMailListRowChangeEventHandler(
    object sender,
    dsCancellationList.CertifiedMailListRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  public delegate void EnvelopeListRowChangeEventHandler(
    object sender,
    dsCancellationList.EnvelopeListRowChangeEvent e);

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class CancellationListDataTable : TypedTableBase<dsCancellationList.CancellationListRow>
  {
    private DataColumn columninvoicenum;
    private DataColumn columnduedate;
    private DataColumn columninsured;
    private DataColumn columnproducer;
    private DataColumn columnretailer;
    private DataColumn columncompany;
    private DataColumn columnofficelocation;
    private DataColumn columnpolicynumber;
    private DataColumn columnline;
    private DataColumn columncontrolno;
    private DataColumn columninitials;
    private DataColumn columnstateid;
    private DataColumn columnreceivablebalance;
    private DataColumn columnmortgagee;
    private DataColumn columnquoteid;
    private DataColumn columnprintfor;
    private DataColumn columneffectiveDate;
    private DataColumn columnexpirationDate;
    private DataColumn columncontrolGuid;
    private DataColumn columnminQuoteId;
    private DataColumn columnMailingDate;
    private DataColumn columnPolicyPeriod;
    private DataColumn columnPrintNOC;
    private DataColumn columnARDue;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public CancellationListDataTable()
    {
      this.TableName = "CancellationList";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal CancellationListDataTable(DataTable table)
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected CancellationListDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn invoicenumColumn => this.columninvoicenum;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn duedateColumn => this.columnduedate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn insuredColumn => this.columninsured;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn producerColumn => this.columnproducer;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn retailerColumn => this.columnretailer;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn companyColumn => this.columncompany;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn officelocationColumn => this.columnofficelocation;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn policynumberColumn => this.columnpolicynumber;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn lineColumn => this.columnline;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn controlnoColumn => this.columncontrolno;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn initialsColumn => this.columninitials;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn stateidColumn => this.columnstateid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn receivablebalanceColumn => this.columnreceivablebalance;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn mortgageeColumn => this.columnmortgagee;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn quoteidColumn => this.columnquoteid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn printforColumn => this.columnprintfor;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn effectiveDateColumn => this.columneffectiveDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn expirationDateColumn => this.columnexpirationDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn controlGuidColumn => this.columncontrolGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn minQuoteIdColumn => this.columnminQuoteId;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn MailingDateColumn => this.columnMailingDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn PolicyPeriodColumn => this.columnPolicyPeriod;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn PrintNOCColumn => this.columnPrintNOC;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn ARDueColumn => this.columnARDue;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsCancellationList.CancellationListRow this[int index]
    {
      get => (dsCancellationList.CancellationListRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsCancellationList.CancellationListRowChangeEventHandler CancellationListRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsCancellationList.CancellationListRowChangeEventHandler CancellationListRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsCancellationList.CancellationListRowChangeEventHandler CancellationListRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsCancellationList.CancellationListRowChangeEventHandler CancellationListRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void AddCancellationListRow(dsCancellationList.CancellationListRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsCancellationList.CancellationListRow AddCancellationListRow(
      int invoicenum,
      DateTime duedate,
      string insured,
      string producer,
      string retailer,
      string company,
      string officelocation,
      string policynumber,
      string line,
      long controlno,
      string initials,
      string stateid,
      Decimal receivablebalance,
      string mortgagee,
      long quoteid,
      string printfor,
      DateTime effectiveDate,
      DateTime expirationDate,
      string controlGuid,
      int minQuoteId,
      DateTime MailingDate,
      string PolicyPeriod,
      bool PrintNOC,
      Decimal ARDue)
    {
      dsCancellationList.CancellationListRow row = (dsCancellationList.CancellationListRow) this.NewRow();
      object[] objArray = new object[24]
      {
        (object) invoicenum,
        (object) duedate,
        (object) insured,
        (object) producer,
        (object) retailer,
        (object) company,
        (object) officelocation,
        (object) policynumber,
        (object) line,
        (object) controlno,
        (object) initials,
        (object) stateid,
        (object) receivablebalance,
        (object) mortgagee,
        (object) quoteid,
        (object) printfor,
        (object) effectiveDate,
        (object) expirationDate,
        (object) controlGuid,
        (object) minQuoteId,
        (object) MailingDate,
        (object) PolicyPeriod,
        (object) PrintNOC,
        (object) ARDue
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public override DataTable Clone()
    {
      dsCancellationList.CancellationListDataTable cancellationListDataTable = (dsCancellationList.CancellationListDataTable) base.Clone();
      cancellationListDataTable.InitVars();
      return (DataTable) cancellationListDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsCancellationList.CancellationListDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal void InitVars()
    {
      this.columninvoicenum = this.Columns["invoicenum"];
      this.columnduedate = this.Columns["duedate"];
      this.columninsured = this.Columns["insured"];
      this.columnproducer = this.Columns["producer"];
      this.columnretailer = this.Columns["retailer"];
      this.columncompany = this.Columns["company"];
      this.columnofficelocation = this.Columns["officelocation"];
      this.columnpolicynumber = this.Columns["policynumber"];
      this.columnline = this.Columns["line"];
      this.columncontrolno = this.Columns["controlno"];
      this.columninitials = this.Columns["initials"];
      this.columnstateid = this.Columns["stateid"];
      this.columnreceivablebalance = this.Columns["receivablebalance"];
      this.columnmortgagee = this.Columns["mortgagee"];
      this.columnquoteid = this.Columns["quoteid"];
      this.columnprintfor = this.Columns["printfor"];
      this.columneffectiveDate = this.Columns["effectiveDate"];
      this.columnexpirationDate = this.Columns["expirationDate"];
      this.columncontrolGuid = this.Columns["controlGuid"];
      this.columnminQuoteId = this.Columns["minQuoteId"];
      this.columnMailingDate = this.Columns["MailingDate"];
      this.columnPolicyPeriod = this.Columns["PolicyPeriod"];
      this.columnPrintNOC = this.Columns["PrintNOC"];
      this.columnARDue = this.Columns["ARDue"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    private void InitClass()
    {
      this.columninvoicenum = new DataColumn("invoicenum", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columninvoicenum);
      this.columnduedate = new DataColumn("duedate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnduedate);
      this.columninsured = new DataColumn("insured", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columninsured);
      this.columnproducer = new DataColumn("producer", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnproducer);
      this.columnretailer = new DataColumn("retailer", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnretailer);
      this.columncompany = new DataColumn("company", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columncompany);
      this.columnofficelocation = new DataColumn("officelocation", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnofficelocation);
      this.columnpolicynumber = new DataColumn("policynumber", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnpolicynumber);
      this.columnline = new DataColumn("line", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnline);
      this.columncontrolno = new DataColumn("controlno", typeof (long), (string) null, MappingType.Element);
      this.Columns.Add(this.columncontrolno);
      this.columninitials = new DataColumn("initials", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columninitials);
      this.columnstateid = new DataColumn("stateid", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnstateid);
      this.columnreceivablebalance = new DataColumn("receivablebalance", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnreceivablebalance);
      this.columnmortgagee = new DataColumn("mortgagee", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnmortgagee);
      this.columnquoteid = new DataColumn("quoteid", typeof (long), (string) null, MappingType.Element);
      this.Columns.Add(this.columnquoteid);
      this.columnprintfor = new DataColumn("printfor", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnprintfor);
      this.columneffectiveDate = new DataColumn("effectiveDate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columneffectiveDate);
      this.columnexpirationDate = new DataColumn("expirationDate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnexpirationDate);
      this.columncontrolGuid = new DataColumn("controlGuid", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columncontrolGuid);
      this.columnminQuoteId = new DataColumn("minQuoteId", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnminQuoteId);
      this.columnMailingDate = new DataColumn("MailingDate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnMailingDate);
      this.columnPolicyPeriod = new DataColumn("PolicyPeriod", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPolicyPeriod);
      this.columnPrintNOC = new DataColumn("PrintNOC", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPrintNOC);
      this.columnARDue = new DataColumn("ARDue", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnARDue);
      this.columnPrintNOC.DefaultValue = (object) true;
      this.columnARDue.DefaultValue = (object) 0M;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsCancellationList.CancellationListRow NewCancellationListRow()
    {
      return (dsCancellationList.CancellationListRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsCancellationList.CancellationListRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override Type GetRowType() => typeof (dsCancellationList.CancellationListRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.CancellationListRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCancellationList.CancellationListRowChangeEventHandler listRowChangedEvent = this.CancellationListRowChangedEvent;
      if (listRowChangedEvent == null)
        return;
      listRowChangedEvent((object) this, new dsCancellationList.CancellationListRowChangeEvent((dsCancellationList.CancellationListRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.CancellationListRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCancellationList.CancellationListRowChangeEventHandler rowChangingEvent = this.CancellationListRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsCancellationList.CancellationListRowChangeEvent((dsCancellationList.CancellationListRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.CancellationListRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCancellationList.CancellationListRowChangeEventHandler listRowDeletedEvent = this.CancellationListRowDeletedEvent;
      if (listRowDeletedEvent == null)
        return;
      listRowDeletedEvent((object) this, new dsCancellationList.CancellationListRowChangeEvent((dsCancellationList.CancellationListRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.CancellationListRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCancellationList.CancellationListRowChangeEventHandler rowDeletingEvent = this.CancellationListRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsCancellationList.CancellationListRowChangeEvent((dsCancellationList.CancellationListRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void RemoveCancellationListRow(dsCancellationList.CancellationListRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsCancellationList cancellationList = new dsCancellationList();
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
        FixedValue = cancellationList.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (CancellationListDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = cancellationList.GetSchemaSerializable();
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
  public class CertifiedMailListDataTable : TypedTableBase<dsCancellationList.CertifiedMailListRow>
  {
    private DataColumn columnarticlenum1;
    private DataColumn columnaddress1;
    private DataColumn columnarticlenum2;
    private DataColumn columnaddress2;
    private DataColumn columnarticlenum3;
    private DataColumn columnaddress3;
    private DataColumn columnarticlenum4;
    private DataColumn columnaddress4;
    private DataColumn columnarticlenum5;
    private DataColumn columnaddress5;
    private DataColumn columnarticlenum6;
    private DataColumn columnaddress6;
    private DataColumn columnarticlenum7;
    private DataColumn columnaddress7;
    private DataColumn columnarticlenum8;
    private DataColumn columnaddress8;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public CertifiedMailListDataTable()
    {
      this.TableName = "CertifiedMailList";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal CertifiedMailListDataTable(DataTable table)
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected CertifiedMailListDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn articlenum1Column => this.columnarticlenum1;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn address1Column => this.columnaddress1;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn articlenum2Column => this.columnarticlenum2;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn address2Column => this.columnaddress2;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn articlenum3Column => this.columnarticlenum3;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn address3Column => this.columnaddress3;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn articlenum4Column => this.columnarticlenum4;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn address4Column => this.columnaddress4;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn articlenum5Column => this.columnarticlenum5;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn address5Column => this.columnaddress5;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn articlenum6Column => this.columnarticlenum6;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn address6Column => this.columnaddress6;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn articlenum7Column => this.columnarticlenum7;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn address7Column => this.columnaddress7;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn articlenum8Column => this.columnarticlenum8;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn address8Column => this.columnaddress8;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsCancellationList.CertifiedMailListRow this[int index]
    {
      get => (dsCancellationList.CertifiedMailListRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsCancellationList.CertifiedMailListRowChangeEventHandler CertifiedMailListRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsCancellationList.CertifiedMailListRowChangeEventHandler CertifiedMailListRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsCancellationList.CertifiedMailListRowChangeEventHandler CertifiedMailListRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsCancellationList.CertifiedMailListRowChangeEventHandler CertifiedMailListRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void AddCertifiedMailListRow(dsCancellationList.CertifiedMailListRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsCancellationList.CertifiedMailListRow AddCertifiedMailListRow(
      string articlenum1,
      string address1,
      string articlenum2,
      string address2,
      string articlenum3,
      string address3,
      string articlenum4,
      string address4,
      string articlenum5,
      string address5,
      string articlenum6,
      string address6,
      string articlenum7,
      string address7,
      string articlenum8,
      string address8)
    {
      dsCancellationList.CertifiedMailListRow row = (dsCancellationList.CertifiedMailListRow) this.NewRow();
      object[] objArray = new object[16 /*0x10*/]
      {
        (object) articlenum1,
        (object) address1,
        (object) articlenum2,
        (object) address2,
        (object) articlenum3,
        (object) address3,
        (object) articlenum4,
        (object) address4,
        (object) articlenum5,
        (object) address5,
        (object) articlenum6,
        (object) address6,
        (object) articlenum7,
        (object) address7,
        (object) articlenum8,
        (object) address8
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public override DataTable Clone()
    {
      dsCancellationList.CertifiedMailListDataTable mailListDataTable = (dsCancellationList.CertifiedMailListDataTable) base.Clone();
      mailListDataTable.InitVars();
      return (DataTable) mailListDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsCancellationList.CertifiedMailListDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal void InitVars()
    {
      this.columnarticlenum1 = this.Columns["articlenum1"];
      this.columnaddress1 = this.Columns["address1"];
      this.columnarticlenum2 = this.Columns["articlenum2"];
      this.columnaddress2 = this.Columns["address2"];
      this.columnarticlenum3 = this.Columns["articlenum3"];
      this.columnaddress3 = this.Columns["address3"];
      this.columnarticlenum4 = this.Columns["articlenum4"];
      this.columnaddress4 = this.Columns["address4"];
      this.columnarticlenum5 = this.Columns["articlenum5"];
      this.columnaddress5 = this.Columns["address5"];
      this.columnarticlenum6 = this.Columns["articlenum6"];
      this.columnaddress6 = this.Columns["address6"];
      this.columnarticlenum7 = this.Columns["articlenum7"];
      this.columnaddress7 = this.Columns["address7"];
      this.columnarticlenum8 = this.Columns["articlenum8"];
      this.columnaddress8 = this.Columns["address8"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    private void InitClass()
    {
      this.columnarticlenum1 = new DataColumn("articlenum1", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnarticlenum1);
      this.columnaddress1 = new DataColumn("address1", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnaddress1);
      this.columnarticlenum2 = new DataColumn("articlenum2", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnarticlenum2);
      this.columnaddress2 = new DataColumn("address2", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnaddress2);
      this.columnarticlenum3 = new DataColumn("articlenum3", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnarticlenum3);
      this.columnaddress3 = new DataColumn("address3", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnaddress3);
      this.columnarticlenum4 = new DataColumn("articlenum4", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnarticlenum4);
      this.columnaddress4 = new DataColumn("address4", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnaddress4);
      this.columnarticlenum5 = new DataColumn("articlenum5", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnarticlenum5);
      this.columnaddress5 = new DataColumn("address5", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnaddress5);
      this.columnarticlenum6 = new DataColumn("articlenum6", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnarticlenum6);
      this.columnaddress6 = new DataColumn("address6", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnaddress6);
      this.columnarticlenum7 = new DataColumn("articlenum7", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnarticlenum7);
      this.columnaddress7 = new DataColumn("address7", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnaddress7);
      this.columnarticlenum8 = new DataColumn("articlenum8", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnarticlenum8);
      this.columnaddress8 = new DataColumn("address8", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnaddress8);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsCancellationList.CertifiedMailListRow NewCertifiedMailListRow()
    {
      return (dsCancellationList.CertifiedMailListRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsCancellationList.CertifiedMailListRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override Type GetRowType() => typeof (dsCancellationList.CertifiedMailListRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.CertifiedMailListRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCancellationList.CertifiedMailListRowChangeEventHandler listRowChangedEvent = this.CertifiedMailListRowChangedEvent;
      if (listRowChangedEvent == null)
        return;
      listRowChangedEvent((object) this, new dsCancellationList.CertifiedMailListRowChangeEvent((dsCancellationList.CertifiedMailListRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.CertifiedMailListRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCancellationList.CertifiedMailListRowChangeEventHandler rowChangingEvent = this.CertifiedMailListRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsCancellationList.CertifiedMailListRowChangeEvent((dsCancellationList.CertifiedMailListRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.CertifiedMailListRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCancellationList.CertifiedMailListRowChangeEventHandler listRowDeletedEvent = this.CertifiedMailListRowDeletedEvent;
      if (listRowDeletedEvent == null)
        return;
      listRowDeletedEvent((object) this, new dsCancellationList.CertifiedMailListRowChangeEvent((dsCancellationList.CertifiedMailListRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.CertifiedMailListRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCancellationList.CertifiedMailListRowChangeEventHandler rowDeletingEvent = this.CertifiedMailListRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsCancellationList.CertifiedMailListRowChangeEvent((dsCancellationList.CertifiedMailListRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void RemoveCertifiedMailListRow(dsCancellationList.CertifiedMailListRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsCancellationList cancellationList = new dsCancellationList();
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
        FixedValue = cancellationList.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (CertifiedMailListDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = cancellationList.GetSchemaSerializable();
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
  public class EnvelopeListDataTable : TypedTableBase<dsCancellationList.EnvelopeListRow>
  {
    private DataColumn columnAddress;
    private DataColumn columnPolicyNumber;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public EnvelopeListDataTable()
    {
      this.TableName = "EnvelopeList";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal EnvelopeListDataTable(DataTable table)
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected EnvelopeListDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn AddressColumn => this.columnAddress;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataColumn PolicyNumberColumn => this.columnPolicyNumber;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsCancellationList.EnvelopeListRow this[int index]
    {
      get => (dsCancellationList.EnvelopeListRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsCancellationList.EnvelopeListRowChangeEventHandler EnvelopeListRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsCancellationList.EnvelopeListRowChangeEventHandler EnvelopeListRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsCancellationList.EnvelopeListRowChangeEventHandler EnvelopeListRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public event dsCancellationList.EnvelopeListRowChangeEventHandler EnvelopeListRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void AddEnvelopeListRow(dsCancellationList.EnvelopeListRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsCancellationList.EnvelopeListRow AddEnvelopeListRow(
      string Address,
      string PolicyNumber)
    {
      dsCancellationList.EnvelopeListRow row = (dsCancellationList.EnvelopeListRow) this.NewRow();
      object[] objArray = new object[2]
      {
        (object) Address,
        (object) PolicyNumber
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public override DataTable Clone()
    {
      dsCancellationList.EnvelopeListDataTable envelopeListDataTable = (dsCancellationList.EnvelopeListDataTable) base.Clone();
      envelopeListDataTable.InitVars();
      return (DataTable) envelopeListDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsCancellationList.EnvelopeListDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal void InitVars()
    {
      this.columnAddress = this.Columns["Address"];
      this.columnPolicyNumber = this.Columns["PolicyNumber"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    private void InitClass()
    {
      this.columnAddress = new DataColumn("Address", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAddress);
      this.columnPolicyNumber = new DataColumn("PolicyNumber", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPolicyNumber);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsCancellationList.EnvelopeListRow NewEnvelopeListRow()
    {
      return (dsCancellationList.EnvelopeListRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsCancellationList.EnvelopeListRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override Type GetRowType() => typeof (dsCancellationList.EnvelopeListRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.EnvelopeListRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCancellationList.EnvelopeListRowChangeEventHandler listRowChangedEvent = this.EnvelopeListRowChangedEvent;
      if (listRowChangedEvent == null)
        return;
      listRowChangedEvent((object) this, new dsCancellationList.EnvelopeListRowChangeEvent((dsCancellationList.EnvelopeListRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.EnvelopeListRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCancellationList.EnvelopeListRowChangeEventHandler rowChangingEvent = this.EnvelopeListRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsCancellationList.EnvelopeListRowChangeEvent((dsCancellationList.EnvelopeListRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.EnvelopeListRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCancellationList.EnvelopeListRowChangeEventHandler listRowDeletedEvent = this.EnvelopeListRowDeletedEvent;
      if (listRowDeletedEvent == null)
        return;
      listRowDeletedEvent((object) this, new dsCancellationList.EnvelopeListRowChangeEvent((dsCancellationList.EnvelopeListRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.EnvelopeListRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCancellationList.EnvelopeListRowChangeEventHandler rowDeletingEvent = this.EnvelopeListRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsCancellationList.EnvelopeListRowChangeEvent((dsCancellationList.EnvelopeListRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void RemoveEnvelopeListRow(dsCancellationList.EnvelopeListRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsCancellationList cancellationList = new dsCancellationList();
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
        FixedValue = cancellationList.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (EnvelopeListDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = cancellationList.GetSchemaSerializable();
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

  public class CancellationListRow : DataRow
  {
    private dsCancellationList.CancellationListDataTable tableCancellationList;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal CancellationListRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableCancellationList = (dsCancellationList.CancellationListDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public int invoicenum
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tableCancellationList.invoicenumColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'invoicenum' in table 'CancellationList' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableCancellationList.invoicenumColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DateTime duedate
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tableCancellationList.duedateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'duedate' in table 'CancellationList' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableCancellationList.duedateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string insured
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableCancellationList.insuredColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'insured' in table 'CancellationList' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableCancellationList.insuredColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string producer
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableCancellationList.producerColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'producer' in table 'CancellationList' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableCancellationList.producerColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string retailer
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableCancellationList.retailerColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'retailer' in table 'CancellationList' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableCancellationList.retailerColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string company
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableCancellationList.companyColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'company' in table 'CancellationList' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableCancellationList.companyColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string officelocation
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableCancellationList.officelocationColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'officelocation' in table 'CancellationList' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableCancellationList.officelocationColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string policynumber
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableCancellationList.policynumberColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'policynumber' in table 'CancellationList' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableCancellationList.policynumberColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string line
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableCancellationList.lineColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'line' in table 'CancellationList' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableCancellationList.lineColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public long controlno
    {
      get
      {
        try
        {
          return Conversions.ToLong(this[this.tableCancellationList.controlnoColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'controlno' in table 'CancellationList' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableCancellationList.controlnoColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string initials
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableCancellationList.initialsColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'initials' in table 'CancellationList' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableCancellationList.initialsColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string stateid
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableCancellationList.stateidColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'stateid' in table 'CancellationList' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableCancellationList.stateidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public Decimal receivablebalance
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tableCancellationList.receivablebalanceColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'receivablebalance' in table 'CancellationList' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableCancellationList.receivablebalanceColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string mortgagee
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableCancellationList.mortgageeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'mortgagee' in table 'CancellationList' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableCancellationList.mortgageeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public long quoteid
    {
      get
      {
        try
        {
          return Conversions.ToLong(this[this.tableCancellationList.quoteidColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'quoteid' in table 'CancellationList' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableCancellationList.quoteidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string printfor
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableCancellationList.printforColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'printfor' in table 'CancellationList' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableCancellationList.printforColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DateTime effectiveDate
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tableCancellationList.effectiveDateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'effectiveDate' in table 'CancellationList' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableCancellationList.effectiveDateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DateTime expirationDate
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tableCancellationList.expirationDateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'expirationDate' in table 'CancellationList' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableCancellationList.expirationDateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string controlGuid
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableCancellationList.controlGuidColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'controlGuid' in table 'CancellationList' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableCancellationList.controlGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public int minQuoteId
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tableCancellationList.minQuoteIdColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'minQuoteId' in table 'CancellationList' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableCancellationList.minQuoteIdColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DateTime MailingDate
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tableCancellationList.MailingDateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'MailingDate' in table 'CancellationList' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableCancellationList.MailingDateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string PolicyPeriod
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableCancellationList.PolicyPeriodColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'PolicyPeriod' in table 'CancellationList' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableCancellationList.PolicyPeriodColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool PrintNOC
    {
      get
      {
        return this.IsPrintNOCNull() || Conversions.ToBoolean(this[this.tableCancellationList.PrintNOCColumn]);
      }
      set => this[this.tableCancellationList.PrintNOCColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public Decimal ARDue
    {
      get
      {
        return !this.IsARDueNull() ? Conversions.ToDecimal(this[this.tableCancellationList.ARDueColumn]) : 0M;
      }
      set => this[this.tableCancellationList.ARDueColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsinvoicenumNull() => this.IsNull(this.tableCancellationList.invoicenumColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetinvoicenumNull()
    {
      this[this.tableCancellationList.invoicenumColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsduedateNull() => this.IsNull(this.tableCancellationList.duedateColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetduedateNull()
    {
      this[this.tableCancellationList.duedateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsinsuredNull() => this.IsNull(this.tableCancellationList.insuredColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetinsuredNull()
    {
      this[this.tableCancellationList.insuredColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsproducerNull() => this.IsNull(this.tableCancellationList.producerColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetproducerNull()
    {
      this[this.tableCancellationList.producerColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsretailerNull() => this.IsNull(this.tableCancellationList.retailerColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetretailerNull()
    {
      this[this.tableCancellationList.retailerColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IscompanyNull() => this.IsNull(this.tableCancellationList.companyColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetcompanyNull()
    {
      this[this.tableCancellationList.companyColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsofficelocationNull()
    {
      return this.IsNull(this.tableCancellationList.officelocationColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetofficelocationNull()
    {
      this[this.tableCancellationList.officelocationColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IspolicynumberNull() => this.IsNull(this.tableCancellationList.policynumberColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetpolicynumberNull()
    {
      this[this.tableCancellationList.policynumberColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IslineNull() => this.IsNull(this.tableCancellationList.lineColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetlineNull()
    {
      this[this.tableCancellationList.lineColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IscontrolnoNull() => this.IsNull(this.tableCancellationList.controlnoColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetcontrolnoNull()
    {
      this[this.tableCancellationList.controlnoColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsinitialsNull() => this.IsNull(this.tableCancellationList.initialsColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetinitialsNull()
    {
      this[this.tableCancellationList.initialsColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsstateidNull() => this.IsNull(this.tableCancellationList.stateidColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetstateidNull()
    {
      this[this.tableCancellationList.stateidColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsreceivablebalanceNull()
    {
      return this.IsNull(this.tableCancellationList.receivablebalanceColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetreceivablebalanceNull()
    {
      this[this.tableCancellationList.receivablebalanceColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsmortgageeNull() => this.IsNull(this.tableCancellationList.mortgageeColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetmortgageeNull()
    {
      this[this.tableCancellationList.mortgageeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsquoteidNull() => this.IsNull(this.tableCancellationList.quoteidColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetquoteidNull()
    {
      this[this.tableCancellationList.quoteidColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsprintforNull() => this.IsNull(this.tableCancellationList.printforColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetprintforNull()
    {
      this[this.tableCancellationList.printforColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IseffectiveDateNull()
    {
      return this.IsNull(this.tableCancellationList.effectiveDateColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SeteffectiveDateNull()
    {
      this[this.tableCancellationList.effectiveDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsexpirationDateNull()
    {
      return this.IsNull(this.tableCancellationList.expirationDateColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetexpirationDateNull()
    {
      this[this.tableCancellationList.expirationDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IscontrolGuidNull() => this.IsNull(this.tableCancellationList.controlGuidColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetcontrolGuidNull()
    {
      this[this.tableCancellationList.controlGuidColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsminQuoteIdNull() => this.IsNull(this.tableCancellationList.minQuoteIdColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetminQuoteIdNull()
    {
      this[this.tableCancellationList.minQuoteIdColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsMailingDateNull() => this.IsNull(this.tableCancellationList.MailingDateColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetMailingDateNull()
    {
      this[this.tableCancellationList.MailingDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsPolicyPeriodNull() => this.IsNull(this.tableCancellationList.PolicyPeriodColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetPolicyPeriodNull()
    {
      this[this.tableCancellationList.PolicyPeriodColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsPrintNOCNull() => this.IsNull(this.tableCancellationList.PrintNOCColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetPrintNOCNull()
    {
      this[this.tableCancellationList.PrintNOCColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsARDueNull() => this.IsNull(this.tableCancellationList.ARDueColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetARDueNull()
    {
      this[this.tableCancellationList.ARDueColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class CertifiedMailListRow : DataRow
  {
    private dsCancellationList.CertifiedMailListDataTable tableCertifiedMailList;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal CertifiedMailListRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableCertifiedMailList = (dsCancellationList.CertifiedMailListDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string articlenum1
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableCertifiedMailList.articlenum1Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'articlenum1' in table 'CertifiedMailList' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableCertifiedMailList.articlenum1Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string address1
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableCertifiedMailList.address1Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'address1' in table 'CertifiedMailList' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableCertifiedMailList.address1Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string articlenum2
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableCertifiedMailList.articlenum2Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'articlenum2' in table 'CertifiedMailList' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableCertifiedMailList.articlenum2Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string address2
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableCertifiedMailList.address2Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'address2' in table 'CertifiedMailList' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableCertifiedMailList.address2Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string articlenum3
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableCertifiedMailList.articlenum3Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'articlenum3' in table 'CertifiedMailList' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableCertifiedMailList.articlenum3Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string address3
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableCertifiedMailList.address3Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'address3' in table 'CertifiedMailList' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableCertifiedMailList.address3Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string articlenum4
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableCertifiedMailList.articlenum4Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'articlenum4' in table 'CertifiedMailList' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableCertifiedMailList.articlenum4Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string address4
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableCertifiedMailList.address4Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'address4' in table 'CertifiedMailList' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableCertifiedMailList.address4Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string articlenum5
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableCertifiedMailList.articlenum5Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'articlenum5' in table 'CertifiedMailList' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableCertifiedMailList.articlenum5Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string address5
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableCertifiedMailList.address5Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'address5' in table 'CertifiedMailList' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableCertifiedMailList.address5Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string articlenum6
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableCertifiedMailList.articlenum6Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'articlenum6' in table 'CertifiedMailList' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableCertifiedMailList.articlenum6Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string address6
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableCertifiedMailList.address6Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'address6' in table 'CertifiedMailList' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableCertifiedMailList.address6Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string articlenum7
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableCertifiedMailList.articlenum7Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'articlenum7' in table 'CertifiedMailList' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableCertifiedMailList.articlenum7Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string address7
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableCertifiedMailList.address7Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'address7' in table 'CertifiedMailList' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableCertifiedMailList.address7Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string articlenum8
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableCertifiedMailList.articlenum8Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'articlenum8' in table 'CertifiedMailList' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableCertifiedMailList.articlenum8Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string address8
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableCertifiedMailList.address8Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'address8' in table 'CertifiedMailList' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableCertifiedMailList.address8Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool Isarticlenum1Null() => this.IsNull(this.tableCertifiedMailList.articlenum1Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void Setarticlenum1Null()
    {
      this[this.tableCertifiedMailList.articlenum1Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool Isaddress1Null() => this.IsNull(this.tableCertifiedMailList.address1Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void Setaddress1Null()
    {
      this[this.tableCertifiedMailList.address1Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool Isarticlenum2Null() => this.IsNull(this.tableCertifiedMailList.articlenum2Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void Setarticlenum2Null()
    {
      this[this.tableCertifiedMailList.articlenum2Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool Isaddress2Null() => this.IsNull(this.tableCertifiedMailList.address2Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void Setaddress2Null()
    {
      this[this.tableCertifiedMailList.address2Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool Isarticlenum3Null() => this.IsNull(this.tableCertifiedMailList.articlenum3Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void Setarticlenum3Null()
    {
      this[this.tableCertifiedMailList.articlenum3Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool Isaddress3Null() => this.IsNull(this.tableCertifiedMailList.address3Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void Setaddress3Null()
    {
      this[this.tableCertifiedMailList.address3Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool Isarticlenum4Null() => this.IsNull(this.tableCertifiedMailList.articlenum4Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void Setarticlenum4Null()
    {
      this[this.tableCertifiedMailList.articlenum4Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool Isaddress4Null() => this.IsNull(this.tableCertifiedMailList.address4Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void Setaddress4Null()
    {
      this[this.tableCertifiedMailList.address4Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool Isarticlenum5Null() => this.IsNull(this.tableCertifiedMailList.articlenum5Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void Setarticlenum5Null()
    {
      this[this.tableCertifiedMailList.articlenum5Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool Isaddress5Null() => this.IsNull(this.tableCertifiedMailList.address5Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void Setaddress5Null()
    {
      this[this.tableCertifiedMailList.address5Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool Isarticlenum6Null() => this.IsNull(this.tableCertifiedMailList.articlenum6Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void Setarticlenum6Null()
    {
      this[this.tableCertifiedMailList.articlenum6Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool Isaddress6Null() => this.IsNull(this.tableCertifiedMailList.address6Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void Setaddress6Null()
    {
      this[this.tableCertifiedMailList.address6Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool Isarticlenum7Null() => this.IsNull(this.tableCertifiedMailList.articlenum7Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void Setarticlenum7Null()
    {
      this[this.tableCertifiedMailList.articlenum7Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool Isaddress7Null() => this.IsNull(this.tableCertifiedMailList.address7Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void Setaddress7Null()
    {
      this[this.tableCertifiedMailList.address7Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool Isarticlenum8Null() => this.IsNull(this.tableCertifiedMailList.articlenum8Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void Setarticlenum8Null()
    {
      this[this.tableCertifiedMailList.articlenum8Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool Isaddress8Null() => this.IsNull(this.tableCertifiedMailList.address8Column);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void Setaddress8Null()
    {
      this[this.tableCertifiedMailList.address8Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class EnvelopeListRow : DataRow
  {
    private dsCancellationList.EnvelopeListDataTable tableEnvelopeList;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    internal EnvelopeListRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableEnvelopeList = (dsCancellationList.EnvelopeListDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string Address
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableEnvelopeList.AddressColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Address' in table 'EnvelopeList' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableEnvelopeList.AddressColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public string PolicyNumber
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableEnvelopeList.PolicyNumberColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'PolicyNumber' in table 'EnvelopeList' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableEnvelopeList.PolicyNumberColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsAddressNull() => this.IsNull(this.tableEnvelopeList.AddressColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetAddressNull()
    {
      this[this.tableEnvelopeList.AddressColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public bool IsPolicyNumberNull() => this.IsNull(this.tableEnvelopeList.PolicyNumberColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public void SetPolicyNumberNull()
    {
      this[this.tableEnvelopeList.PolicyNumberColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  public class CancellationListRowChangeEvent : EventArgs
  {
    private dsCancellationList.CancellationListRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public CancellationListRowChangeEvent(
      dsCancellationList.CancellationListRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsCancellationList.CancellationListRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  public class CertifiedMailListRowChangeEvent : EventArgs
  {
    private dsCancellationList.CertifiedMailListRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public CertifiedMailListRowChangeEvent(
      dsCancellationList.CertifiedMailListRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsCancellationList.CertifiedMailListRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
  public class EnvelopeListRowChangeEvent : EventArgs
  {
    private dsCancellationList.EnvelopeListRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public EnvelopeListRowChangeEvent(dsCancellationList.EnvelopeListRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public dsCancellationList.EnvelopeListRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }
}
