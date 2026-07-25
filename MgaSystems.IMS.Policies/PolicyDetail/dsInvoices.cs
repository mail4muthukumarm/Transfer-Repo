// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.PolicyDetail.dsInvoices
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
namespace MGASystems.IMS.Policies.PolicyDetail;

[DesignerCategory("code")]
[ToolboxItem(true)]
[XmlSchemaProvider("GetTypedDataSetSchema")]
[XmlRoot("dsInvoices")]
[HelpKeyword("vs.data.DataSet")]
[Serializable]
public class dsInvoices : DataSet
{
  private dsInvoices.InvoicesDataTable tableInvoices;
  private SchemaSerializationMode _schemaSerializationMode;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public dsInvoices()
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
  protected dsInvoices(SerializationInfo info, StreamingContext context)
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
          base.Tables.Add((DataTable) new dsInvoices.InvoicesDataTable(dataSet.Tables[nameof (Invoices)]));
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
  public dsInvoices.InvoicesDataTable Invoices => this.tableInvoices;

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
    dsInvoices dsInvoices = (dsInvoices) base.Clone();
    dsInvoices.InitVars();
    dsInvoices.SchemaSerializationMode = this.SchemaSerializationMode;
    return (DataSet) dsInvoices;
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
      if (dataSet.Tables["Invoices"] != null)
        base.Tables.Add((DataTable) new dsInvoices.InvoicesDataTable(dataSet.Tables["Invoices"]));
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
    this.tableInvoices = (dsInvoices.InvoicesDataTable) base.Tables["Invoices"];
    if (!initTable || this.tableInvoices == null)
      return;
    this.tableInvoices.InitVars();
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private void InitClass()
  {
    this.DataSetName = nameof (dsInvoices);
    this.Prefix = "";
    this.Namespace = "http://tempuri.org/dsInvoices.xsd";
    this.EnforceConstraints = true;
    this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.tableInvoices = new dsInvoices.InvoicesDataTable();
    base.Tables.Add((DataTable) this.tableInvoices);
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializeInvoices() => false;

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
    dsInvoices dsInvoices = new dsInvoices();
    XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
    schemaComplexType.Particle = (XmlSchemaParticle) new XmlSchemaSequence()
    {
      Items = {
        (XmlSchemaObject) new XmlSchemaAny()
        {
          Namespace = dsInvoices.Namespace
        }
      }
    };
    XmlSchema schemaSerializable = dsInvoices.GetSchemaSerializable();
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
  public delegate void InvoicesRowChangeEventHandler(
    object sender,
    dsInvoices.InvoicesRowChangeEvent e);

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class InvoicesDataTable : TypedTableBase<dsInvoices.InvoicesRow>
  {
    private DataColumn columnInvoiceNum;
    private DataColumn columnInvoiceDate;
    private DataColumn columnDueDate;
    private DataColumn columnAmount;
    private DataColumn columnOfficeInvoiceNum;
    private DataColumn columnFailed;
    private DataColumn columnUser;
    private DataColumn columnQuoteID;
    private DataColumn columnOfficeID;
    private DataColumn columnDetail;
    private DataColumn columnGrossPremium;
    private DataColumn columnEmail;
    private DataColumn columnRemitter;
    private DataColumn columnPayee;
    private DataColumn columnInvoiceTypeID;
    private DataColumn columnEndorsementComment;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public InvoicesDataTable()
    {
      this.TableName = "Invoices";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected InvoicesDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn InvoiceNumColumn => this.columnInvoiceNum;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn InvoiceDateColumn => this.columnInvoiceDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn DueDateColumn => this.columnDueDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn AmountColumn => this.columnAmount;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn OfficeInvoiceNumColumn => this.columnOfficeInvoiceNum;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn FailedColumn => this.columnFailed;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn UserColumn => this.columnUser;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn QuoteIDColumn => this.columnQuoteID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn OfficeIDColumn => this.columnOfficeID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn DetailColumn => this.columnDetail;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn GrossPremiumColumn => this.columnGrossPremium;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn EmailColumn => this.columnEmail;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn RemitterColumn => this.columnRemitter;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn PayeeColumn => this.columnPayee;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn InvoiceTypeIDColumn => this.columnInvoiceTypeID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn EndorsementCommentColumn => this.columnEndorsementComment;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInvoices.InvoicesRow this[int index] => (dsInvoices.InvoicesRow) this.Rows[index];

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsInvoices.InvoicesRowChangeEventHandler InvoicesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsInvoices.InvoicesRowChangeEventHandler InvoicesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsInvoices.InvoicesRowChangeEventHandler InvoicesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsInvoices.InvoicesRowChangeEventHandler InvoicesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AddInvoicesRow(dsInvoices.InvoicesRow row) => this.Rows.Add((DataRow) row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInvoices.InvoicesRow AddInvoicesRow(
      DateTime InvoiceDate,
      DateTime DueDate,
      double Amount,
      int OfficeInvoiceNum,
      bool Failed,
      string User,
      int QuoteID,
      int OfficeID,
      string Detail,
      double GrossPremium,
      string Email,
      string Remitter,
      string Payee,
      string InvoiceTypeID,
      string EndorsementComment)
    {
      dsInvoices.InvoicesRow row = (dsInvoices.InvoicesRow) this.NewRow();
      object[] objArray = new object[16 /*0x10*/]
      {
        null,
        (object) InvoiceDate,
        (object) DueDate,
        (object) Amount,
        (object) OfficeInvoiceNum,
        (object) Failed,
        (object) User,
        (object) QuoteID,
        (object) OfficeID,
        (object) Detail,
        (object) GrossPremium,
        (object) Email,
        (object) Remitter,
        (object) Payee,
        (object) InvoiceTypeID,
        (object) EndorsementComment
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInvoices.InvoicesRow FindByInvoiceNum(int InvoiceNum)
    {
      return (dsInvoices.InvoicesRow) this.Rows.Find(new object[1]
      {
        (object) InvoiceNum
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsInvoices.InvoicesDataTable invoicesDataTable = (dsInvoices.InvoicesDataTable) base.Clone();
      invoicesDataTable.InitVars();
      return (DataTable) invoicesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance() => (DataTable) new dsInvoices.InvoicesDataTable();

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal void InitVars()
    {
      this.columnInvoiceNum = this.Columns["InvoiceNum"];
      this.columnInvoiceDate = this.Columns["InvoiceDate"];
      this.columnDueDate = this.Columns["DueDate"];
      this.columnAmount = this.Columns["Amount"];
      this.columnOfficeInvoiceNum = this.Columns["OfficeInvoiceNum"];
      this.columnFailed = this.Columns["Failed"];
      this.columnUser = this.Columns["User"];
      this.columnQuoteID = this.Columns["QuoteID"];
      this.columnOfficeID = this.Columns["OfficeID"];
      this.columnDetail = this.Columns["Detail"];
      this.columnGrossPremium = this.Columns["GrossPremium"];
      this.columnEmail = this.Columns["Email"];
      this.columnRemitter = this.Columns["Remitter"];
      this.columnPayee = this.Columns["Payee"];
      this.columnInvoiceTypeID = this.Columns["InvoiceTypeID"];
      this.columnEndorsementComment = this.Columns["EndorsementComment"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.columnInvoiceNum = new DataColumn("InvoiceNum", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInvoiceNum);
      this.columnInvoiceDate = new DataColumn("InvoiceDate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInvoiceDate);
      this.columnDueDate = new DataColumn("DueDate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDueDate);
      this.columnAmount = new DataColumn("Amount", typeof (double), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAmount);
      this.columnOfficeInvoiceNum = new DataColumn("OfficeInvoiceNum", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnOfficeInvoiceNum);
      this.columnFailed = new DataColumn("Failed", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFailed);
      this.columnUser = new DataColumn("User", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnUser);
      this.columnQuoteID = new DataColumn("QuoteID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnQuoteID);
      this.columnOfficeID = new DataColumn("OfficeID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnOfficeID);
      this.columnDetail = new DataColumn("Detail", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDetail);
      this.columnGrossPremium = new DataColumn("GrossPremium", typeof (double), (string) null, MappingType.Element);
      this.Columns.Add(this.columnGrossPremium);
      this.columnEmail = new DataColumn("Email", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEmail);
      this.columnRemitter = new DataColumn("Remitter", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnRemitter);
      this.columnPayee = new DataColumn("Payee", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPayee);
      this.columnInvoiceTypeID = new DataColumn("InvoiceTypeID", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInvoiceTypeID);
      this.columnEndorsementComment = new DataColumn("EndorsementComment", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEndorsementComment);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsInvoicesKey1", new DataColumn[1]
      {
        this.columnInvoiceNum
      }, true));
      this.columnInvoiceNum.AutoIncrement = true;
      this.columnInvoiceNum.AllowDBNull = false;
      this.columnInvoiceNum.ReadOnly = true;
      this.columnInvoiceNum.Unique = true;
      this.columnInvoiceDate.AllowDBNull = false;
      this.columnInvoiceDate.ReadOnly = true;
      this.columnDueDate.AllowDBNull = false;
      this.columnAmount.AllowDBNull = false;
      this.columnAmount.ReadOnly = true;
      this.columnOfficeInvoiceNum.AllowDBNull = false;
      this.columnFailed.AllowDBNull = false;
      this.columnUser.AllowDBNull = false;
      this.columnQuoteID.AllowDBNull = false;
      this.columnOfficeID.AllowDBNull = false;
      this.columnDetail.AllowDBNull = false;
      this.columnDetail.DefaultValue = (object) "Detail";
      this.columnEmail.AllowDBNull = false;
      this.columnEmail.DefaultValue = (object) "Email";
      this.columnEndorsementComment.MaxLength = 250;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInvoices.InvoicesRow NewInvoicesRow() => (dsInvoices.InvoicesRow) this.NewRow();

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsInvoices.InvoicesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType() => typeof (dsInvoices.InvoicesRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.InvoicesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInvoices.InvoicesRowChangeEventHandler invoicesRowChangedEvent = this.InvoicesRowChangedEvent;
      if (invoicesRowChangedEvent == null)
        return;
      invoicesRowChangedEvent((object) this, new dsInvoices.InvoicesRowChangeEvent((dsInvoices.InvoicesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.InvoicesRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInvoices.InvoicesRowChangeEventHandler rowChangingEvent = this.InvoicesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsInvoices.InvoicesRowChangeEvent((dsInvoices.InvoicesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.InvoicesRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInvoices.InvoicesRowChangeEventHandler invoicesRowDeletedEvent = this.InvoicesRowDeletedEvent;
      if (invoicesRowDeletedEvent == null)
        return;
      invoicesRowDeletedEvent((object) this, new dsInvoices.InvoicesRowChangeEvent((dsInvoices.InvoicesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.InvoicesRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInvoices.InvoicesRowChangeEventHandler rowDeletingEvent = this.InvoicesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsInvoices.InvoicesRowChangeEvent((dsInvoices.InvoicesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemoveInvoicesRow(dsInvoices.InvoicesRow row) => this.Rows.Remove((DataRow) row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsInvoices dsInvoices = new dsInvoices();
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
        FixedValue = dsInvoices.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (InvoicesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsInvoices.GetSchemaSerializable();
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
    private dsInvoices.InvoicesDataTable tableInvoices;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal InvoicesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableInvoices = (dsInvoices.InvoicesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int InvoiceNum
    {
      get => Conversions.ToInteger(this[this.tableInvoices.InvoiceNumColumn]);
      set => this[this.tableInvoices.InvoiceNumColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DateTime InvoiceDate
    {
      get => Conversions.ToDate(this[this.tableInvoices.InvoiceDateColumn]);
      set => this[this.tableInvoices.InvoiceDateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DateTime DueDate
    {
      get => Conversions.ToDate(this[this.tableInvoices.DueDateColumn]);
      set => this[this.tableInvoices.DueDateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public double Amount
    {
      get => Conversions.ToDouble(this[this.tableInvoices.AmountColumn]);
      set => this[this.tableInvoices.AmountColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int OfficeInvoiceNum
    {
      get => Conversions.ToInteger(this[this.tableInvoices.OfficeInvoiceNumColumn]);
      set => this[this.tableInvoices.OfficeInvoiceNumColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool Failed
    {
      get => Conversions.ToBoolean(this[this.tableInvoices.FailedColumn]);
      set => this[this.tableInvoices.FailedColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string User
    {
      get => Conversions.ToString(this[this.tableInvoices.UserColumn]);
      set => this[this.tableInvoices.UserColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int QuoteID
    {
      get => Conversions.ToInteger(this[this.tableInvoices.QuoteIDColumn]);
      set => this[this.tableInvoices.QuoteIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int OfficeID
    {
      get => Conversions.ToInteger(this[this.tableInvoices.OfficeIDColumn]);
      set => this[this.tableInvoices.OfficeIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string Detail
    {
      get => Conversions.ToString(this[this.tableInvoices.DetailColumn]);
      set => this[this.tableInvoices.DetailColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public double GrossPremium
    {
      get
      {
        try
        {
          return Conversions.ToDouble(this[this.tableInvoices.GrossPremiumColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'GrossPremium' in table 'Invoices' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableInvoices.GrossPremiumColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string Email
    {
      get => Conversions.ToString(this[this.tableInvoices.EmailColumn]);
      set => this[this.tableInvoices.EmailColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string Remitter
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableInvoices.RemitterColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Remitter' in table 'Invoices' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableInvoices.RemitterColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string Payee
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableInvoices.PayeeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Payee' in table 'Invoices' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableInvoices.PayeeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string InvoiceTypeID
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableInvoices.InvoiceTypeIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'InvoiceTypeID' in table 'Invoices' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableInvoices.InvoiceTypeIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string EndorsementComment
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableInvoices.EndorsementCommentColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'EndorsementComment' in table 'Invoices' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableInvoices.EndorsementCommentColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsGrossPremiumNull() => this.IsNull(this.tableInvoices.GrossPremiumColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetGrossPremiumNull()
    {
      this[this.tableInvoices.GrossPremiumColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsRemitterNull() => this.IsNull(this.tableInvoices.RemitterColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetRemitterNull()
    {
      this[this.tableInvoices.RemitterColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsPayeeNull() => this.IsNull(this.tableInvoices.PayeeColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetPayeeNull()
    {
      this[this.tableInvoices.PayeeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsInvoiceTypeIDNull() => this.IsNull(this.tableInvoices.InvoiceTypeIDColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetInvoiceTypeIDNull()
    {
      this[this.tableInvoices.InvoiceTypeIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsEndorsementCommentNull()
    {
      return this.IsNull(this.tableInvoices.EndorsementCommentColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetEndorsementCommentNull()
    {
      this[this.tableInvoices.EndorsementCommentColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class InvoicesRowChangeEvent : EventArgs
  {
    private dsInvoices.InvoicesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public InvoicesRowChangeEvent(dsInvoices.InvoicesRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsInvoices.InvoicesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }
}
