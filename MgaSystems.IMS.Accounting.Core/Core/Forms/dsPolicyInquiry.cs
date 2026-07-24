// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Core.Forms.dsPolicyInquiry
// Assembly: MgaSystems.IMS.Accounting.Core, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 923053EF-B70A-44B5-B8DA-B227263F4FD2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Core.dll

using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

#nullable disable
namespace MGASystems.IMS.Accounting.Core.Forms;

[DesignerCategory("code")]
[ToolboxItem(true)]
[XmlSchemaProvider("GetTypedDataSetSchema")]
[XmlRoot("dsPolicyInquiry")]
[HelpKeyword("vs.data.DataSet")]
[Serializable]
public class dsPolicyInquiry : DataSet
{
  private dsPolicyInquiry.spFin_QuoteInvoicesDataTable tablespFin_QuoteInvoices;
  private dsPolicyInquiry.spFin_InvoiceTransactionsDataTable tablespFin_InvoiceTransactions;
  private DataRelation relationspFin_QuoteInvoices_spFin_InvoiceTransactions;
  private SchemaSerializationMode _schemaSerializationMode = SchemaSerializationMode.IncludeSchema;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public dsPolicyInquiry()
  {
    this.BeginInit();
    this.InitClass();
    CollectionChangeEventHandler changeEventHandler = new CollectionChangeEventHandler(this.SchemaChanged);
    base.Tables.CollectionChanged += changeEventHandler;
    base.Relations.CollectionChanged += changeEventHandler;
    this.EndInit();
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  protected dsPolicyInquiry(SerializationInfo info, StreamingContext context)
    : base(info, context, false)
  {
    if (this.IsBinarySerialized(info, context))
    {
      this.InitVars(false);
      CollectionChangeEventHandler changeEventHandler = new CollectionChangeEventHandler(this.SchemaChanged);
      this.Tables.CollectionChanged += changeEventHandler;
      this.Relations.CollectionChanged += changeEventHandler;
    }
    else
    {
      string s = (string) info.GetValue("XmlSchema", typeof (string));
      if (this.DetermineSchemaSerializationMode(info, context) == SchemaSerializationMode.IncludeSchema)
      {
        DataSet dataSet = new DataSet();
        dataSet.ReadXmlSchema((XmlReader) new XmlTextReader((TextReader) new StringReader(s)));
        if (dataSet.Tables[nameof (spFin_QuoteInvoices)] != null)
          base.Tables.Add((DataTable) new dsPolicyInquiry.spFin_QuoteInvoicesDataTable(dataSet.Tables[nameof (spFin_QuoteInvoices)]));
        if (dataSet.Tables[nameof (spFin_InvoiceTransactions)] != null)
          base.Tables.Add((DataTable) new dsPolicyInquiry.spFin_InvoiceTransactionsDataTable(dataSet.Tables[nameof (spFin_InvoiceTransactions)]));
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
  public dsPolicyInquiry.spFin_QuoteInvoicesDataTable spFin_QuoteInvoices
  {
    get => this.tablespFin_QuoteInvoices;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsPolicyInquiry.spFin_InvoiceTransactionsDataTable spFin_InvoiceTransactions
  {
    get => this.tablespFin_InvoiceTransactions;
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
    dsPolicyInquiry dsPolicyInquiry = (dsPolicyInquiry) base.Clone();
    dsPolicyInquiry.InitVars();
    dsPolicyInquiry.SchemaSerializationMode = this.SchemaSerializationMode;
    return (DataSet) dsPolicyInquiry;
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
      if (dataSet.Tables["spFin_QuoteInvoices"] != null)
        base.Tables.Add((DataTable) new dsPolicyInquiry.spFin_QuoteInvoicesDataTable(dataSet.Tables["spFin_QuoteInvoices"]));
      if (dataSet.Tables["spFin_InvoiceTransactions"] != null)
        base.Tables.Add((DataTable) new dsPolicyInquiry.spFin_InvoiceTransactionsDataTable(dataSet.Tables["spFin_InvoiceTransactions"]));
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
    this.tablespFin_QuoteInvoices = (dsPolicyInquiry.spFin_QuoteInvoicesDataTable) base.Tables["spFin_QuoteInvoices"];
    if (initTable && this.tablespFin_QuoteInvoices != null)
      this.tablespFin_QuoteInvoices.InitVars();
    this.tablespFin_InvoiceTransactions = (dsPolicyInquiry.spFin_InvoiceTransactionsDataTable) base.Tables["spFin_InvoiceTransactions"];
    if (initTable && this.tablespFin_InvoiceTransactions != null)
      this.tablespFin_InvoiceTransactions.InitVars();
    this.relationspFin_QuoteInvoices_spFin_InvoiceTransactions = this.Relations["spFin_QuoteInvoices_spFin_InvoiceTransactions"];
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private void InitClass()
  {
    this.DataSetName = nameof (dsPolicyInquiry);
    this.Prefix = "";
    this.Namespace = "http://tempuri.org/dsPolicyInquiry.xsd";
    this.EnforceConstraints = true;
    this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.tablespFin_QuoteInvoices = new dsPolicyInquiry.spFin_QuoteInvoicesDataTable();
    base.Tables.Add((DataTable) this.tablespFin_QuoteInvoices);
    this.tablespFin_InvoiceTransactions = new dsPolicyInquiry.spFin_InvoiceTransactionsDataTable();
    base.Tables.Add((DataTable) this.tablespFin_InvoiceTransactions);
    this.relationspFin_QuoteInvoices_spFin_InvoiceTransactions = new DataRelation("spFin_QuoteInvoices_spFin_InvoiceTransactions", new DataColumn[1]
    {
      this.tablespFin_QuoteInvoices.InvoiceNumColumn
    }, new DataColumn[1]
    {
      this.tablespFin_InvoiceTransactions.InvoiceNumColumn
    }, false);
    this.Relations.Add(this.relationspFin_QuoteInvoices_spFin_InvoiceTransactions);
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializespFin_QuoteInvoices() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializespFin_InvoiceTransactions() => false;

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
    dsPolicyInquiry dsPolicyInquiry = new dsPolicyInquiry();
    XmlSchemaComplexType typedDataSetSchema = new XmlSchemaComplexType();
    XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
    xmlSchemaSequence.Items.Add((XmlSchemaObject) new XmlSchemaAny()
    {
      Namespace = dsPolicyInquiry.Namespace
    });
    typedDataSetSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
    XmlSchema schemaSerializable = dsPolicyInquiry.GetSchemaSerializable();
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
          current.Write((Stream) memoryStream2);
          if (memoryStream1.Length == memoryStream2.Length)
          {
            memoryStream1.Position = 0L;
            memoryStream2.Position = 0L;
            do
              ;
            while (memoryStream1.Position != memoryStream1.Length && memoryStream1.ReadByte() == memoryStream2.ReadByte());
            if (memoryStream1.Position == memoryStream1.Length)
              return typedDataSetSchema;
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
    return typedDataSetSchema;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void spFin_QuoteInvoicesRowChangeEventHandler(
    object sender,
    dsPolicyInquiry.spFin_QuoteInvoicesRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void spFin_InvoiceTransactionsRowChangeEventHandler(
    object sender,
    dsPolicyInquiry.spFin_InvoiceTransactionsRowChangeEvent e);

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class spFin_QuoteInvoicesDataTable : TypedTableBase<dsPolicyInquiry.spFin_QuoteInvoicesRow>
  {
    private DataColumn columnInvoiceNum;
    private DataColumn columnOfficeInvoiceNum;
    private DataColumn columnInvoiceDate;
    private DataColumn columnDueDate;
    private DataColumn columnGrossPremium;
    private DataColumn columnFees;
    private DataColumn columnNetBilled;
    private DataColumn columnAmtPTD;
    private DataColumn columnSurplus;
    private DataColumn columnTransaction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public spFin_QuoteInvoicesDataTable()
    {
      this.TableName = "spFin_QuoteInvoices";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal spFin_QuoteInvoicesDataTable(DataTable table)
    {
      this.TableName = table.TableName;
      if (table.CaseSensitive != table.DataSet.CaseSensitive)
        this.CaseSensitive = table.CaseSensitive;
      if (table.Locale.ToString() != table.DataSet.Locale.ToString())
        this.Locale = table.Locale;
      if (table.Namespace != table.DataSet.Namespace)
        this.Namespace = table.Namespace;
      this.Prefix = table.Prefix;
      this.MinimumCapacity = table.MinimumCapacity;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected spFin_QuoteInvoicesDataTable(SerializationInfo info, StreamingContext context)
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
    public DataColumn InvoiceDateColumn => this.columnInvoiceDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn DueDateColumn => this.columnDueDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn GrossPremiumColumn => this.columnGrossPremium;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn FeesColumn => this.columnFees;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn NetBilledColumn => this.columnNetBilled;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn AmtPTDColumn => this.columnAmtPTD;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn SurplusColumn => this.columnSurplus;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn TransactionColumn => this.columnTransaction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsPolicyInquiry.spFin_QuoteInvoicesRow this[int index]
    {
      get => (dsPolicyInquiry.spFin_QuoteInvoicesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsPolicyInquiry.spFin_QuoteInvoicesRowChangeEventHandler spFin_QuoteInvoicesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsPolicyInquiry.spFin_QuoteInvoicesRowChangeEventHandler spFin_QuoteInvoicesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsPolicyInquiry.spFin_QuoteInvoicesRowChangeEventHandler spFin_QuoteInvoicesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsPolicyInquiry.spFin_QuoteInvoicesRowChangeEventHandler spFin_QuoteInvoicesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddspFin_QuoteInvoicesRow(dsPolicyInquiry.spFin_QuoteInvoicesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsPolicyInquiry.spFin_QuoteInvoicesRow AddspFin_QuoteInvoicesRow(
      int InvoiceNum,
      int OfficeInvoiceNum,
      DateTime InvoiceDate,
      DateTime DueDate,
      Decimal GrossPremium,
      Decimal Fees,
      Decimal NetBilled,
      Decimal AmtPTD,
      Decimal Surplus,
      string Transaction)
    {
      dsPolicyInquiry.spFin_QuoteInvoicesRow row = (dsPolicyInquiry.spFin_QuoteInvoicesRow) this.NewRow();
      object[] objArray = new object[10]
      {
        (object) InvoiceNum,
        (object) OfficeInvoiceNum,
        (object) InvoiceDate,
        (object) DueDate,
        (object) GrossPremium,
        (object) Fees,
        (object) NetBilled,
        (object) AmtPTD,
        (object) Surplus,
        (object) Transaction
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsPolicyInquiry.spFin_QuoteInvoicesRow FindByInvoiceNum(int InvoiceNum)
    {
      return (dsPolicyInquiry.spFin_QuoteInvoicesRow) this.Rows.Find(new object[1]
      {
        (object) InvoiceNum
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsPolicyInquiry.spFin_QuoteInvoicesDataTable invoicesDataTable = (dsPolicyInquiry.spFin_QuoteInvoicesDataTable) base.Clone();
      invoicesDataTable.InitVars();
      return (DataTable) invoicesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsPolicyInquiry.spFin_QuoteInvoicesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnInvoiceNum = this.Columns["InvoiceNum"];
      this.columnOfficeInvoiceNum = this.Columns["OfficeInvoiceNum"];
      this.columnInvoiceDate = this.Columns["InvoiceDate"];
      this.columnDueDate = this.Columns["DueDate"];
      this.columnGrossPremium = this.Columns["GrossPremium"];
      this.columnFees = this.Columns["Fees"];
      this.columnNetBilled = this.Columns["NetBilled"];
      this.columnAmtPTD = this.Columns["AmtPTD"];
      this.columnSurplus = this.Columns["Surplus"];
      this.columnTransaction = this.Columns["Transaction"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnInvoiceNum = new DataColumn("InvoiceNum", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInvoiceNum);
      this.columnOfficeInvoiceNum = new DataColumn("OfficeInvoiceNum", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnOfficeInvoiceNum);
      this.columnInvoiceDate = new DataColumn("InvoiceDate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInvoiceDate);
      this.columnDueDate = new DataColumn("DueDate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDueDate);
      this.columnGrossPremium = new DataColumn("GrossPremium", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnGrossPremium);
      this.columnFees = new DataColumn("Fees", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFees);
      this.columnNetBilled = new DataColumn("NetBilled", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnNetBilled);
      this.columnAmtPTD = new DataColumn("AmtPTD", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAmtPTD);
      this.columnSurplus = new DataColumn("Surplus", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSurplus);
      this.columnTransaction = new DataColumn("Transaction", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnTransaction);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsPolicyInquiryKey1", new DataColumn[1]
      {
        this.columnInvoiceNum
      }, true));
      this.columnInvoiceNum.AllowDBNull = false;
      this.columnInvoiceNum.Unique = true;
      this.columnAmtPTD.ReadOnly = true;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsPolicyInquiry.spFin_QuoteInvoicesRow NewspFin_QuoteInvoicesRow()
    {
      return (dsPolicyInquiry.spFin_QuoteInvoicesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsPolicyInquiry.spFin_QuoteInvoicesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (dsPolicyInquiry.spFin_QuoteInvoicesRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      if (this.spFin_QuoteInvoicesRowChanged == null)
        return;
      this.spFin_QuoteInvoicesRowChanged((object) this, new dsPolicyInquiry.spFin_QuoteInvoicesRowChangeEvent((dsPolicyInquiry.spFin_QuoteInvoicesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      if (this.spFin_QuoteInvoicesRowChanging == null)
        return;
      this.spFin_QuoteInvoicesRowChanging((object) this, new dsPolicyInquiry.spFin_QuoteInvoicesRowChangeEvent((dsPolicyInquiry.spFin_QuoteInvoicesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      if (this.spFin_QuoteInvoicesRowDeleted == null)
        return;
      this.spFin_QuoteInvoicesRowDeleted((object) this, new dsPolicyInquiry.spFin_QuoteInvoicesRowChangeEvent((dsPolicyInquiry.spFin_QuoteInvoicesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      if (this.spFin_QuoteInvoicesRowDeleting == null)
        return;
      this.spFin_QuoteInvoicesRowDeleting((object) this, new dsPolicyInquiry.spFin_QuoteInvoicesRowChangeEvent((dsPolicyInquiry.spFin_QuoteInvoicesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemovespFin_QuoteInvoicesRow(dsPolicyInquiry.spFin_QuoteInvoicesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType typedTableSchema = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsPolicyInquiry dsPolicyInquiry = new dsPolicyInquiry();
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
      typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "namespace",
        FixedValue = dsPolicyInquiry.Namespace
      });
      typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (spFin_QuoteInvoicesDataTable)
      });
      typedTableSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsPolicyInquiry.GetSchemaSerializable();
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
            current.Write((Stream) memoryStream2);
            if (memoryStream1.Length == memoryStream2.Length)
            {
              memoryStream1.Position = 0L;
              memoryStream2.Position = 0L;
              do
                ;
              while (memoryStream1.Position != memoryStream1.Length && memoryStream1.ReadByte() == memoryStream2.ReadByte());
              if (memoryStream1.Position == memoryStream1.Length)
                return typedTableSchema;
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
      return typedTableSchema;
    }
  }

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class spFin_InvoiceTransactionsDataTable : 
    TypedTableBase<dsPolicyInquiry.spFin_InvoiceTransactionsRow>
  {
    private DataColumn columnInvoiceNum;
    private DataColumn columnTransactNum;
    private DataColumn columnTransdescription;
    private DataColumn columnpostDate;
    private DataColumn columnuser;
    private DataColumn columnvoided;
    private DataColumn columnarapplied;
    private DataColumn columnapapplied;
    private DataColumn columnexchapplied;
    private DataColumn columnunacctapplied;
    private DataColumn columnincomeapplied;
    private DataColumn columncashapplied;
    private DataColumn columnCheck_Number;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public spFin_InvoiceTransactionsDataTable()
    {
      this.TableName = "spFin_InvoiceTransactions";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal spFin_InvoiceTransactionsDataTable(DataTable table)
    {
      this.TableName = table.TableName;
      if (table.CaseSensitive != table.DataSet.CaseSensitive)
        this.CaseSensitive = table.CaseSensitive;
      if (table.Locale.ToString() != table.DataSet.Locale.ToString())
        this.Locale = table.Locale;
      if (table.Namespace != table.DataSet.Namespace)
        this.Namespace = table.Namespace;
      this.Prefix = table.Prefix;
      this.MinimumCapacity = table.MinimumCapacity;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected spFin_InvoiceTransactionsDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn InvoiceNumColumn => this.columnInvoiceNum;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn TransactNumColumn => this.columnTransactNum;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn TransdescriptionColumn => this.columnTransdescription;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn postDateColumn => this.columnpostDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn userColumn => this.columnuser;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn voidedColumn => this.columnvoided;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn arappliedColumn => this.columnarapplied;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn apappliedColumn => this.columnapapplied;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn exchappliedColumn => this.columnexchapplied;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn unacctappliedColumn => this.columnunacctapplied;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn incomeappliedColumn => this.columnincomeapplied;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn cashappliedColumn => this.columncashapplied;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn Check_NumberColumn => this.columnCheck_Number;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsPolicyInquiry.spFin_InvoiceTransactionsRow this[int index]
    {
      get => (dsPolicyInquiry.spFin_InvoiceTransactionsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsPolicyInquiry.spFin_InvoiceTransactionsRowChangeEventHandler spFin_InvoiceTransactionsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsPolicyInquiry.spFin_InvoiceTransactionsRowChangeEventHandler spFin_InvoiceTransactionsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsPolicyInquiry.spFin_InvoiceTransactionsRowChangeEventHandler spFin_InvoiceTransactionsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsPolicyInquiry.spFin_InvoiceTransactionsRowChangeEventHandler spFin_InvoiceTransactionsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddspFin_InvoiceTransactionsRow(dsPolicyInquiry.spFin_InvoiceTransactionsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsPolicyInquiry.spFin_InvoiceTransactionsRow AddspFin_InvoiceTransactionsRow(
      dsPolicyInquiry.spFin_QuoteInvoicesRow parentspFin_QuoteInvoicesRowByspFin_QuoteInvoices_spFin_InvoiceTransactions,
      string Transdescription,
      DateTime postDate,
      string user,
      bool voided,
      Decimal arapplied,
      Decimal apapplied,
      Decimal exchapplied,
      Decimal unacctapplied,
      Decimal incomeapplied,
      Decimal cashapplied,
      string Check_Number)
    {
      dsPolicyInquiry.spFin_InvoiceTransactionsRow row = (dsPolicyInquiry.spFin_InvoiceTransactionsRow) this.NewRow();
      object[] objArray = new object[13]
      {
        null,
        null,
        (object) Transdescription,
        (object) postDate,
        (object) user,
        (object) voided,
        (object) arapplied,
        (object) apapplied,
        (object) exchapplied,
        (object) unacctapplied,
        (object) incomeapplied,
        (object) cashapplied,
        (object) Check_Number
      };
      if (parentspFin_QuoteInvoicesRowByspFin_QuoteInvoices_spFin_InvoiceTransactions != null)
        objArray[0] = parentspFin_QuoteInvoicesRowByspFin_QuoteInvoices_spFin_InvoiceTransactions[0];
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsPolicyInquiry.spFin_InvoiceTransactionsRow FindByInvoiceNumTransactNum(
      int InvoiceNum,
      int TransactNum)
    {
      return (dsPolicyInquiry.spFin_InvoiceTransactionsRow) this.Rows.Find(new object[2]
      {
        (object) InvoiceNum,
        (object) TransactNum
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsPolicyInquiry.spFin_InvoiceTransactionsDataTable transactionsDataTable = (dsPolicyInquiry.spFin_InvoiceTransactionsDataTable) base.Clone();
      transactionsDataTable.InitVars();
      return (DataTable) transactionsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsPolicyInquiry.spFin_InvoiceTransactionsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnInvoiceNum = this.Columns["InvoiceNum"];
      this.columnTransactNum = this.Columns["TransactNum"];
      this.columnTransdescription = this.Columns["Transdescription"];
      this.columnpostDate = this.Columns["postDate"];
      this.columnuser = this.Columns["user"];
      this.columnvoided = this.Columns["voided"];
      this.columnarapplied = this.Columns["arapplied"];
      this.columnapapplied = this.Columns["apapplied"];
      this.columnexchapplied = this.Columns["exchapplied"];
      this.columnunacctapplied = this.Columns["unacctapplied"];
      this.columnincomeapplied = this.Columns["incomeapplied"];
      this.columncashapplied = this.Columns["cashapplied"];
      this.columnCheck_Number = this.Columns["Check Number"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnInvoiceNum = new DataColumn("InvoiceNum", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInvoiceNum);
      this.columnTransactNum = new DataColumn("TransactNum", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnTransactNum);
      this.columnTransdescription = new DataColumn("Transdescription", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnTransdescription);
      this.columnpostDate = new DataColumn("postDate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnpostDate);
      this.columnuser = new DataColumn("user", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnuser);
      this.columnvoided = new DataColumn("voided", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnvoided);
      this.columnarapplied = new DataColumn("arapplied", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnarapplied);
      this.columnapapplied = new DataColumn("apapplied", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnapapplied);
      this.columnexchapplied = new DataColumn("exchapplied", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnexchapplied);
      this.columnunacctapplied = new DataColumn("unacctapplied", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnunacctapplied);
      this.columnincomeapplied = new DataColumn("incomeapplied", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnincomeapplied);
      this.columncashapplied = new DataColumn("cashapplied", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columncashapplied);
      this.columnCheck_Number = new DataColumn("Check Number", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCheck_Number);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsPolicyInquiryKey2", new DataColumn[2]
      {
        this.columnInvoiceNum,
        this.columnTransactNum
      }, true));
      this.columnInvoiceNum.AllowDBNull = false;
      this.columnTransactNum.AutoIncrement = true;
      this.columnTransactNum.AllowDBNull = false;
      this.columnTransactNum.ReadOnly = true;
      this.columnTransdescription.AllowDBNull = false;
      this.columnpostDate.AllowDBNull = false;
      this.columnuser.AllowDBNull = false;
      this.columnvoided.ReadOnly = true;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsPolicyInquiry.spFin_InvoiceTransactionsRow NewspFin_InvoiceTransactionsRow()
    {
      return (dsPolicyInquiry.spFin_InvoiceTransactionsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsPolicyInquiry.spFin_InvoiceTransactionsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (dsPolicyInquiry.spFin_InvoiceTransactionsRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      if (this.spFin_InvoiceTransactionsRowChanged == null)
        return;
      this.spFin_InvoiceTransactionsRowChanged((object) this, new dsPolicyInquiry.spFin_InvoiceTransactionsRowChangeEvent((dsPolicyInquiry.spFin_InvoiceTransactionsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      if (this.spFin_InvoiceTransactionsRowChanging == null)
        return;
      this.spFin_InvoiceTransactionsRowChanging((object) this, new dsPolicyInquiry.spFin_InvoiceTransactionsRowChangeEvent((dsPolicyInquiry.spFin_InvoiceTransactionsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      if (this.spFin_InvoiceTransactionsRowDeleted == null)
        return;
      this.spFin_InvoiceTransactionsRowDeleted((object) this, new dsPolicyInquiry.spFin_InvoiceTransactionsRowChangeEvent((dsPolicyInquiry.spFin_InvoiceTransactionsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      if (this.spFin_InvoiceTransactionsRowDeleting == null)
        return;
      this.spFin_InvoiceTransactionsRowDeleting((object) this, new dsPolicyInquiry.spFin_InvoiceTransactionsRowChangeEvent((dsPolicyInquiry.spFin_InvoiceTransactionsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemovespFin_InvoiceTransactionsRow(dsPolicyInquiry.spFin_InvoiceTransactionsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType typedTableSchema = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsPolicyInquiry dsPolicyInquiry = new dsPolicyInquiry();
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
      typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "namespace",
        FixedValue = dsPolicyInquiry.Namespace
      });
      typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (spFin_InvoiceTransactionsDataTable)
      });
      typedTableSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsPolicyInquiry.GetSchemaSerializable();
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
            current.Write((Stream) memoryStream2);
            if (memoryStream1.Length == memoryStream2.Length)
            {
              memoryStream1.Position = 0L;
              memoryStream2.Position = 0L;
              do
                ;
              while (memoryStream1.Position != memoryStream1.Length && memoryStream1.ReadByte() == memoryStream2.ReadByte());
              if (memoryStream1.Position == memoryStream1.Length)
                return typedTableSchema;
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
      return typedTableSchema;
    }
  }

  public class spFin_QuoteInvoicesRow : DataRow
  {
    private dsPolicyInquiry.spFin_QuoteInvoicesDataTable tablespFin_QuoteInvoices;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal spFin_QuoteInvoicesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablespFin_QuoteInvoices = (dsPolicyInquiry.spFin_QuoteInvoicesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int InvoiceNum
    {
      get => (int) this[this.tablespFin_QuoteInvoices.InvoiceNumColumn];
      set => this[this.tablespFin_QuoteInvoices.InvoiceNumColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int OfficeInvoiceNum
    {
      get
      {
        try
        {
          return (int) this[this.tablespFin_QuoteInvoices.OfficeInvoiceNumColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'OfficeInvoiceNum' in table 'spFin_QuoteInvoices' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablespFin_QuoteInvoices.OfficeInvoiceNumColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DateTime InvoiceDate
    {
      get
      {
        try
        {
          return (DateTime) this[this.tablespFin_QuoteInvoices.InvoiceDateColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'InvoiceDate' in table 'spFin_QuoteInvoices' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablespFin_QuoteInvoices.InvoiceDateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DateTime DueDate
    {
      get
      {
        try
        {
          return (DateTime) this[this.tablespFin_QuoteInvoices.DueDateColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'DueDate' in table 'spFin_QuoteInvoices' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablespFin_QuoteInvoices.DueDateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal GrossPremium
    {
      get
      {
        try
        {
          return (Decimal) this[this.tablespFin_QuoteInvoices.GrossPremiumColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'GrossPremium' in table 'spFin_QuoteInvoices' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablespFin_QuoteInvoices.GrossPremiumColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal Fees
    {
      get
      {
        try
        {
          return (Decimal) this[this.tablespFin_QuoteInvoices.FeesColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'Fees' in table 'spFin_QuoteInvoices' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablespFin_QuoteInvoices.FeesColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal NetBilled
    {
      get
      {
        try
        {
          return (Decimal) this[this.tablespFin_QuoteInvoices.NetBilledColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'NetBilled' in table 'spFin_QuoteInvoices' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablespFin_QuoteInvoices.NetBilledColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal AmtPTD
    {
      get
      {
        try
        {
          return (Decimal) this[this.tablespFin_QuoteInvoices.AmtPTDColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'AmtPTD' in table 'spFin_QuoteInvoices' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablespFin_QuoteInvoices.AmtPTDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal Surplus
    {
      get
      {
        try
        {
          return (Decimal) this[this.tablespFin_QuoteInvoices.SurplusColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'Surplus' in table 'spFin_QuoteInvoices' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablespFin_QuoteInvoices.SurplusColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Transaction
    {
      get
      {
        try
        {
          return (string) this[this.tablespFin_QuoteInvoices.TransactionColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'Transaction' in table 'spFin_QuoteInvoices' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablespFin_QuoteInvoices.TransactionColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsOfficeInvoiceNumNull()
    {
      return this.IsNull(this.tablespFin_QuoteInvoices.OfficeInvoiceNumColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetOfficeInvoiceNumNull()
    {
      this[this.tablespFin_QuoteInvoices.OfficeInvoiceNumColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsInvoiceDateNull() => this.IsNull(this.tablespFin_QuoteInvoices.InvoiceDateColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetInvoiceDateNull()
    {
      this[this.tablespFin_QuoteInvoices.InvoiceDateColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsDueDateNull() => this.IsNull(this.tablespFin_QuoteInvoices.DueDateColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetDueDateNull()
    {
      this[this.tablespFin_QuoteInvoices.DueDateColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsGrossPremiumNull()
    {
      return this.IsNull(this.tablespFin_QuoteInvoices.GrossPremiumColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetGrossPremiumNull()
    {
      this[this.tablespFin_QuoteInvoices.GrossPremiumColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsFeesNull() => this.IsNull(this.tablespFin_QuoteInvoices.FeesColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetFeesNull() => this[this.tablespFin_QuoteInvoices.FeesColumn] = Convert.DBNull;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsNetBilledNull() => this.IsNull(this.tablespFin_QuoteInvoices.NetBilledColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetNetBilledNull()
    {
      this[this.tablespFin_QuoteInvoices.NetBilledColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsAmtPTDNull() => this.IsNull(this.tablespFin_QuoteInvoices.AmtPTDColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetAmtPTDNull()
    {
      this[this.tablespFin_QuoteInvoices.AmtPTDColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsSurplusNull() => this.IsNull(this.tablespFin_QuoteInvoices.SurplusColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetSurplusNull()
    {
      this[this.tablespFin_QuoteInvoices.SurplusColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsTransactionNull() => this.IsNull(this.tablespFin_QuoteInvoices.TransactionColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetTransactionNull()
    {
      this[this.tablespFin_QuoteInvoices.TransactionColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsPolicyInquiry.spFin_InvoiceTransactionsRow[] GetspFin_InvoiceTransactionsRows()
    {
      return this.Table.ChildRelations["spFin_QuoteInvoices_spFin_InvoiceTransactions"] == null ? new dsPolicyInquiry.spFin_InvoiceTransactionsRow[0] : (dsPolicyInquiry.spFin_InvoiceTransactionsRow[]) this.GetChildRows(this.Table.ChildRelations["spFin_QuoteInvoices_spFin_InvoiceTransactions"]);
    }
  }

  public class spFin_InvoiceTransactionsRow : DataRow
  {
    private dsPolicyInquiry.spFin_InvoiceTransactionsDataTable tablespFin_InvoiceTransactions;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal spFin_InvoiceTransactionsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablespFin_InvoiceTransactions = (dsPolicyInquiry.spFin_InvoiceTransactionsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int InvoiceNum
    {
      get => (int) this[this.tablespFin_InvoiceTransactions.InvoiceNumColumn];
      set => this[this.tablespFin_InvoiceTransactions.InvoiceNumColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int TransactNum
    {
      get => (int) this[this.tablespFin_InvoiceTransactions.TransactNumColumn];
      set => this[this.tablespFin_InvoiceTransactions.TransactNumColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Transdescription
    {
      get => (string) this[this.tablespFin_InvoiceTransactions.TransdescriptionColumn];
      set => this[this.tablespFin_InvoiceTransactions.TransdescriptionColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DateTime postDate
    {
      get => (DateTime) this[this.tablespFin_InvoiceTransactions.postDateColumn];
      set => this[this.tablespFin_InvoiceTransactions.postDateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string user
    {
      get => (string) this[this.tablespFin_InvoiceTransactions.userColumn];
      set => this[this.tablespFin_InvoiceTransactions.userColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool voided
    {
      get
      {
        try
        {
          return (bool) this[this.tablespFin_InvoiceTransactions.voidedColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'voided' in table 'spFin_InvoiceTransactions' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablespFin_InvoiceTransactions.voidedColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal arapplied
    {
      get
      {
        try
        {
          return (Decimal) this[this.tablespFin_InvoiceTransactions.arappliedColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'arapplied' in table 'spFin_InvoiceTransactions' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablespFin_InvoiceTransactions.arappliedColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal apapplied
    {
      get
      {
        try
        {
          return (Decimal) this[this.tablespFin_InvoiceTransactions.apappliedColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'apapplied' in table 'spFin_InvoiceTransactions' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablespFin_InvoiceTransactions.apappliedColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal exchapplied
    {
      get
      {
        try
        {
          return (Decimal) this[this.tablespFin_InvoiceTransactions.exchappliedColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'exchapplied' in table 'spFin_InvoiceTransactions' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablespFin_InvoiceTransactions.exchappliedColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal unacctapplied
    {
      get
      {
        try
        {
          return (Decimal) this[this.tablespFin_InvoiceTransactions.unacctappliedColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'unacctapplied' in table 'spFin_InvoiceTransactions' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablespFin_InvoiceTransactions.unacctappliedColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal incomeapplied
    {
      get
      {
        try
        {
          return (Decimal) this[this.tablespFin_InvoiceTransactions.incomeappliedColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'incomeapplied' in table 'spFin_InvoiceTransactions' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablespFin_InvoiceTransactions.incomeappliedColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal cashapplied
    {
      get
      {
        try
        {
          return (Decimal) this[this.tablespFin_InvoiceTransactions.cashappliedColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'cashapplied' in table 'spFin_InvoiceTransactions' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablespFin_InvoiceTransactions.cashappliedColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Check_Number
    {
      get
      {
        try
        {
          return (string) this[this.tablespFin_InvoiceTransactions.Check_NumberColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'Check Number' in table 'spFin_InvoiceTransactions' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablespFin_InvoiceTransactions.Check_NumberColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsPolicyInquiry.spFin_QuoteInvoicesRow spFin_QuoteInvoicesRow
    {
      get
      {
        return (dsPolicyInquiry.spFin_QuoteInvoicesRow) this.GetParentRow(this.Table.ParentRelations["spFin_QuoteInvoices_spFin_InvoiceTransactions"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["spFin_QuoteInvoices_spFin_InvoiceTransactions"]);
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsvoidedNull() => this.IsNull(this.tablespFin_InvoiceTransactions.voidedColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetvoidedNull()
    {
      this[this.tablespFin_InvoiceTransactions.voidedColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsarappliedNull()
    {
      return this.IsNull(this.tablespFin_InvoiceTransactions.arappliedColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetarappliedNull()
    {
      this[this.tablespFin_InvoiceTransactions.arappliedColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsapappliedNull()
    {
      return this.IsNull(this.tablespFin_InvoiceTransactions.apappliedColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetapappliedNull()
    {
      this[this.tablespFin_InvoiceTransactions.apappliedColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsexchappliedNull()
    {
      return this.IsNull(this.tablespFin_InvoiceTransactions.exchappliedColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetexchappliedNull()
    {
      this[this.tablespFin_InvoiceTransactions.exchappliedColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsunacctappliedNull()
    {
      return this.IsNull(this.tablespFin_InvoiceTransactions.unacctappliedColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetunacctappliedNull()
    {
      this[this.tablespFin_InvoiceTransactions.unacctappliedColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsincomeappliedNull()
    {
      return this.IsNull(this.tablespFin_InvoiceTransactions.incomeappliedColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetincomeappliedNull()
    {
      this[this.tablespFin_InvoiceTransactions.incomeappliedColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IscashappliedNull()
    {
      return this.IsNull(this.tablespFin_InvoiceTransactions.cashappliedColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetcashappliedNull()
    {
      this[this.tablespFin_InvoiceTransactions.cashappliedColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsCheck_NumberNull()
    {
      return this.IsNull(this.tablespFin_InvoiceTransactions.Check_NumberColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetCheck_NumberNull()
    {
      this[this.tablespFin_InvoiceTransactions.Check_NumberColumn] = Convert.DBNull;
    }
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class spFin_QuoteInvoicesRowChangeEvent : EventArgs
  {
    private dsPolicyInquiry.spFin_QuoteInvoicesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public spFin_QuoteInvoicesRowChangeEvent(
      dsPolicyInquiry.spFin_QuoteInvoicesRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsPolicyInquiry.spFin_QuoteInvoicesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class spFin_InvoiceTransactionsRowChangeEvent : EventArgs
  {
    private dsPolicyInquiry.spFin_InvoiceTransactionsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public spFin_InvoiceTransactionsRowChangeEvent(
      dsPolicyInquiry.spFin_InvoiceTransactionsRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsPolicyInquiry.spFin_InvoiceTransactionsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }
}
