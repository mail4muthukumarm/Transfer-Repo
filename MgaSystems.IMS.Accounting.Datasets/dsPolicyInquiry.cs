// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.AccountingDatasets.dsPolicyInquiry
// Assembly: MgaSystems.IMS.Accounting.Datasets, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 8706ECE1-02EE-4588-9B9D-A81462107C6A
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Accounting.Datasets.dll

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Text;
using System.Xml;
using System.Xml.Schema;

#nullable disable
namespace MGASystems.IMS.Accounting.AccountingDatasets;

[DesignerCategory("code")]
[DebuggerStepThrough]
[ToolboxItem(true)]
[Serializable]
public class dsPolicyInquiry : DataSet
{
  private dsPolicyInquiry.InvoiceTransactionsDataTable tableInvoiceTransactions;
  private dsPolicyInquiry.QuoteInvoicesDataTable tableQuoteInvoices;
  private DataRelation relationQuoteInvoicesInvoiceTransactions;

  public dsPolicyInquiry()
  {
    this.InitClass();
    CollectionChangeEventHandler changeEventHandler = new CollectionChangeEventHandler(this.SchemaChanged);
    this.Tables.CollectionChanged += changeEventHandler;
    this.Relations.CollectionChanged += changeEventHandler;
  }

  protected dsPolicyInquiry(SerializationInfo info, StreamingContext context)
  {
    string s = Conversions.ToString(info.GetValue("XmlSchema", typeof (string)));
    if (s != null)
    {
      DataSet dataSet = new DataSet();
      dataSet.ReadXmlSchema((XmlReader) new XmlTextReader((TextReader) new StringReader(s)));
      if (dataSet.Tables[nameof (InvoiceTransactions)] != null)
        this.Tables.Add((DataTable) new dsPolicyInquiry.InvoiceTransactionsDataTable(dataSet.Tables[nameof (InvoiceTransactions)]));
      if (dataSet.Tables[nameof (QuoteInvoices)] != null)
        this.Tables.Add((DataTable) new dsPolicyInquiry.QuoteInvoicesDataTable(dataSet.Tables[nameof (QuoteInvoices)]));
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
      this.InitClass();
    this.GetSerializationData(info, context);
    CollectionChangeEventHandler changeEventHandler = new CollectionChangeEventHandler(this.SchemaChanged);
    this.Tables.CollectionChanged += changeEventHandler;
    this.Relations.CollectionChanged += changeEventHandler;
  }

  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsPolicyInquiry.InvoiceTransactionsDataTable InvoiceTransactions
  {
    get => this.tableInvoiceTransactions;
  }

  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsPolicyInquiry.QuoteInvoicesDataTable QuoteInvoices => this.tableQuoteInvoices;

  public override DataSet Clone()
  {
    dsPolicyInquiry dsPolicyInquiry = (dsPolicyInquiry) base.Clone();
    dsPolicyInquiry.InitVars();
    return (DataSet) dsPolicyInquiry;
  }

  protected override bool ShouldSerializeTables() => false;

  protected override bool ShouldSerializeRelations() => false;

  protected override void ReadXmlSerializable(XmlReader reader)
  {
    this.Reset();
    DataSet dataSet = new DataSet();
    int num = (int) dataSet.ReadXml(reader);
    if (dataSet.Tables["InvoiceTransactions"] != null)
      this.Tables.Add((DataTable) new dsPolicyInquiry.InvoiceTransactionsDataTable(dataSet.Tables["InvoiceTransactions"]));
    if (dataSet.Tables["QuoteInvoices"] != null)
      this.Tables.Add((DataTable) new dsPolicyInquiry.QuoteInvoicesDataTable(dataSet.Tables["QuoteInvoices"]));
    this.DataSetName = dataSet.DataSetName;
    this.Prefix = dataSet.Prefix;
    this.Namespace = dataSet.Namespace;
    this.Locale = dataSet.Locale;
    this.CaseSensitive = dataSet.CaseSensitive;
    this.EnforceConstraints = dataSet.EnforceConstraints;
    this.Merge(dataSet, false, MissingSchemaAction.Add);
    this.InitVars();
  }

  protected override XmlSchema GetSchemaSerializable()
  {
    MemoryStream memoryStream = new MemoryStream();
    this.WriteXmlSchema((XmlWriter) new XmlTextWriter((Stream) memoryStream, (Encoding) null));
    memoryStream.Position = 0L;
    return XmlSchema.Read((XmlReader) new XmlTextReader((Stream) memoryStream), (ValidationEventHandler) null);
  }

  internal void InitVars()
  {
    this.tableInvoiceTransactions = (dsPolicyInquiry.InvoiceTransactionsDataTable) this.Tables["InvoiceTransactions"];
    if (this.tableInvoiceTransactions != null)
      this.tableInvoiceTransactions.InitVars();
    this.tableQuoteInvoices = (dsPolicyInquiry.QuoteInvoicesDataTable) this.Tables["QuoteInvoices"];
    if (this.tableQuoteInvoices != null)
      this.tableQuoteInvoices.InitVars();
    this.relationQuoteInvoicesInvoiceTransactions = this.Relations["QuoteInvoicesInvoiceTransactions"];
  }

  private void InitClass()
  {
    this.DataSetName = nameof (dsPolicyInquiry);
    this.Prefix = "";
    this.Namespace = "http://www.tempuri.org/dsPolicyInquiry.xsd";
    this.Locale = new CultureInfo("en-US");
    this.CaseSensitive = false;
    this.EnforceConstraints = true;
    this.tableInvoiceTransactions = new dsPolicyInquiry.InvoiceTransactionsDataTable();
    this.Tables.Add((DataTable) this.tableInvoiceTransactions);
    this.tableQuoteInvoices = new dsPolicyInquiry.QuoteInvoicesDataTable();
    this.Tables.Add((DataTable) this.tableQuoteInvoices);
    ForeignKeyConstraint foreignKeyConstraint = new ForeignKeyConstraint("QuoteInvoicesInvoiceTransactions", new DataColumn[1]
    {
      this.tableQuoteInvoices.InvoiceNumColumn
    }, new DataColumn[1]
    {
      this.tableInvoiceTransactions.InvoiceNumColumn
    });
    this.tableInvoiceTransactions.Constraints.Add((Constraint) foreignKeyConstraint);
    foreignKeyConstraint.AcceptRejectRule = AcceptRejectRule.None;
    foreignKeyConstraint.DeleteRule = Rule.Cascade;
    foreignKeyConstraint.UpdateRule = Rule.Cascade;
    this.relationQuoteInvoicesInvoiceTransactions = new DataRelation("QuoteInvoicesInvoiceTransactions", new DataColumn[1]
    {
      this.tableQuoteInvoices.InvoiceNumColumn
    }, new DataColumn[1]
    {
      this.tableInvoiceTransactions.InvoiceNumColumn
    }, false);
    this.Relations.Add(this.relationQuoteInvoicesInvoiceTransactions);
  }

  private bool ShouldSerializeInvoiceTransactions() => false;

  private bool ShouldSerializeQuoteInvoices() => false;

  private void SchemaChanged(object sender, CollectionChangeEventArgs e)
  {
    if (e.Action != CollectionChangeAction.Remove)
      return;
    this.InitVars();
  }

  public delegate void InvoiceTransactionsRowChangeEventHandler(
    object sender,
    dsPolicyInquiry.InvoiceTransactionsRowChangeEvent e);

  public delegate void QuoteInvoicesRowChangeEventHandler(
    object sender,
    dsPolicyInquiry.QuoteInvoicesRowChangeEvent e);

  [DebuggerStepThrough]
  public class InvoiceTransactionsDataTable : DataTable, IEnumerable
  {
    private DataColumn columnInvoiceNum;
    private DataColumn columnTransactNum;
    private DataColumn columnPostDate;
    private DataColumn columnTransDescription;
    private DataColumn columnUserName;
    private DataColumn columnAmount;

    internal InvoiceTransactionsDataTable()
      : base("InvoiceTransactions")
    {
      this.InitClass();
    }

    internal InvoiceTransactionsDataTable(DataTable table)
      : base(table.TableName)
    {
      if (table.CaseSensitive != table.DataSet.CaseSensitive)
        this.CaseSensitive = table.CaseSensitive;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(table.Locale.ToString(), table.DataSet.Locale.ToString(), false) != 0)
        this.Locale = table.Locale;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(table.Namespace, table.DataSet.Namespace, false) != 0)
        this.Namespace = table.Namespace;
      this.Prefix = table.Prefix;
      this.MinimumCapacity = table.MinimumCapacity;
      this.DisplayExpression = table.DisplayExpression;
    }

    [Browsable(false)]
    public int Count => this.Rows.Count;

    internal DataColumn InvoiceNumColumn => this.columnInvoiceNum;

    internal DataColumn TransactNumColumn => this.columnTransactNum;

    internal DataColumn PostDateColumn => this.columnPostDate;

    internal DataColumn TransDescriptionColumn => this.columnTransDescription;

    internal DataColumn UserNameColumn => this.columnUserName;

    internal DataColumn AmountColumn => this.columnAmount;

    public dsPolicyInquiry.InvoiceTransactionsRow this[int index]
    {
      get => (dsPolicyInquiry.InvoiceTransactionsRow) this.Rows[index];
    }

    public event dsPolicyInquiry.InvoiceTransactionsRowChangeEventHandler InvoiceTransactionsRowChanged;

    public event dsPolicyInquiry.InvoiceTransactionsRowChangeEventHandler InvoiceTransactionsRowChanging;

    public event dsPolicyInquiry.InvoiceTransactionsRowChangeEventHandler InvoiceTransactionsRowDeleted;

    public event dsPolicyInquiry.InvoiceTransactionsRowChangeEventHandler InvoiceTransactionsRowDeleting;

    public void AddInvoiceTransactionsRow(dsPolicyInquiry.InvoiceTransactionsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    public dsPolicyInquiry.InvoiceTransactionsRow AddInvoiceTransactionsRow(
      dsPolicyInquiry.QuoteInvoicesRow parentQuoteInvoicesRowByQuoteInvoicesInvoiceTransactions,
      DateTime PostDate,
      string TransDescription,
      string UserName,
      Decimal Amount)
    {
      dsPolicyInquiry.InvoiceTransactionsRow row = (dsPolicyInquiry.InvoiceTransactionsRow) this.NewRow();
      row.ItemArray = new object[6]
      {
        parentQuoteInvoicesRowByQuoteInvoicesInvoiceTransactions[0],
        null,
        (object) PostDate,
        (object) TransDescription,
        (object) UserName,
        (object) Amount
      };
      this.Rows.Add((DataRow) row);
      return row;
    }

    public IEnumerator GetEnumerator() => this.Rows.GetEnumerator();

    public override DataTable Clone()
    {
      dsPolicyInquiry.InvoiceTransactionsDataTable transactionsDataTable = (dsPolicyInquiry.InvoiceTransactionsDataTable) base.Clone();
      transactionsDataTable.InitVars();
      return (DataTable) transactionsDataTable;
    }

    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsPolicyInquiry.InvoiceTransactionsDataTable();
    }

    internal void InitVars()
    {
      this.columnInvoiceNum = this.Columns["InvoiceNum"];
      this.columnTransactNum = this.Columns["TransactNum"];
      this.columnPostDate = this.Columns["PostDate"];
      this.columnTransDescription = this.Columns["TransDescription"];
      this.columnUserName = this.Columns["UserName"];
      this.columnAmount = this.Columns["Amount"];
    }

    private void InitClass()
    {
      this.columnInvoiceNum = new DataColumn("InvoiceNum", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInvoiceNum);
      this.columnTransactNum = new DataColumn("TransactNum", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnTransactNum);
      this.columnPostDate = new DataColumn("PostDate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPostDate);
      this.columnTransDescription = new DataColumn("TransDescription", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnTransDescription);
      this.columnUserName = new DataColumn("UserName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnUserName);
      this.columnAmount = new DataColumn("Amount", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAmount);
      this.columnTransactNum.AutoIncrement = true;
      this.columnTransactNum.AllowDBNull = false;
      this.columnTransactNum.ReadOnly = true;
      this.columnPostDate.AllowDBNull = false;
      this.columnTransDescription.AllowDBNull = false;
      this.columnUserName.AllowDBNull = false;
      this.columnAmount.ReadOnly = true;
    }

    public dsPolicyInquiry.InvoiceTransactionsRow NewInvoiceTransactionsRow()
    {
      return (dsPolicyInquiry.InvoiceTransactionsRow) this.NewRow();
    }

    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsPolicyInquiry.InvoiceTransactionsRow(builder);
    }

    protected override Type GetRowType() => typeof (dsPolicyInquiry.InvoiceTransactionsRow);

    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.InvoiceTransactionsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyInquiry.InvoiceTransactionsRowChangeEventHandler transactionsRowChangedEvent = this.InvoiceTransactionsRowChangedEvent;
      if (transactionsRowChangedEvent == null)
        return;
      transactionsRowChangedEvent((object) this, new dsPolicyInquiry.InvoiceTransactionsRowChangeEvent((dsPolicyInquiry.InvoiceTransactionsRow) e.Row, e.Action));
    }

    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.InvoiceTransactionsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyInquiry.InvoiceTransactionsRowChangeEventHandler rowChangingEvent = this.InvoiceTransactionsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsPolicyInquiry.InvoiceTransactionsRowChangeEvent((dsPolicyInquiry.InvoiceTransactionsRow) e.Row, e.Action));
    }

    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.InvoiceTransactionsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyInquiry.InvoiceTransactionsRowChangeEventHandler transactionsRowDeletedEvent = this.InvoiceTransactionsRowDeletedEvent;
      if (transactionsRowDeletedEvent == null)
        return;
      transactionsRowDeletedEvent((object) this, new dsPolicyInquiry.InvoiceTransactionsRowChangeEvent((dsPolicyInquiry.InvoiceTransactionsRow) e.Row, e.Action));
    }

    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.InvoiceTransactionsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyInquiry.InvoiceTransactionsRowChangeEventHandler rowDeletingEvent = this.InvoiceTransactionsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsPolicyInquiry.InvoiceTransactionsRowChangeEvent((dsPolicyInquiry.InvoiceTransactionsRow) e.Row, e.Action));
    }

    public void RemoveInvoiceTransactionsRow(dsPolicyInquiry.InvoiceTransactionsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }
  }

  [DebuggerStepThrough]
  public class InvoiceTransactionsRow : DataRow
  {
    private dsPolicyInquiry.InvoiceTransactionsDataTable tableInvoiceTransactions;

    internal InvoiceTransactionsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableInvoiceTransactions = (dsPolicyInquiry.InvoiceTransactionsDataTable) this.Table;
    }

    public int InvoiceNum
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tableInvoiceTransactions.InvoiceNumColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableInvoiceTransactions.InvoiceNumColumn] = (object) value;
    }

    public int TransactNum
    {
      get => Conversions.ToInteger(this[this.tableInvoiceTransactions.TransactNumColumn]);
      set => this[this.tableInvoiceTransactions.TransactNumColumn] = (object) value;
    }

    public DateTime PostDate
    {
      get => Conversions.ToDate(this[this.tableInvoiceTransactions.PostDateColumn]);
      set => this[this.tableInvoiceTransactions.PostDateColumn] = (object) value;
    }

    public string TransDescription
    {
      get => Conversions.ToString(this[this.tableInvoiceTransactions.TransDescriptionColumn]);
      set => this[this.tableInvoiceTransactions.TransDescriptionColumn] = (object) value;
    }

    public string UserName
    {
      get => Conversions.ToString(this[this.tableInvoiceTransactions.UserNameColumn]);
      set => this[this.tableInvoiceTransactions.UserNameColumn] = (object) value;
    }

    public Decimal Amount
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tableInvoiceTransactions.AmountColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableInvoiceTransactions.AmountColumn] = (object) value;
    }

    public dsPolicyInquiry.QuoteInvoicesRow QuoteInvoicesRow
    {
      get
      {
        return (dsPolicyInquiry.QuoteInvoicesRow) this.GetParentRow(this.Table.ParentRelations["QuoteInvoicesInvoiceTransactions"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["QuoteInvoicesInvoiceTransactions"]);
      }
    }

    public bool IsInvoiceNumNull() => this.IsNull(this.tableInvoiceTransactions.InvoiceNumColumn);

    public void SetInvoiceNumNull()
    {
      this[this.tableInvoiceTransactions.InvoiceNumColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsAmountNull() => this.IsNull(this.tableInvoiceTransactions.AmountColumn);

    public void SetAmountNull()
    {
      this[this.tableInvoiceTransactions.AmountColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  [DebuggerStepThrough]
  public class InvoiceTransactionsRowChangeEvent : EventArgs
  {
    private dsPolicyInquiry.InvoiceTransactionsRow eventRow;
    private DataRowAction eventAction;

    public InvoiceTransactionsRowChangeEvent(
      dsPolicyInquiry.InvoiceTransactionsRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    public dsPolicyInquiry.InvoiceTransactionsRow Row => this.eventRow;

    public DataRowAction Action => this.eventAction;
  }

  [DebuggerStepThrough]
  public class QuoteInvoicesDataTable : DataTable, IEnumerable
  {
    private DataColumn columnInvoiceNum;
    private DataColumn columnOfficeInvoiceNum;
    private DataColumn columnGLOfficeLocation;
    private DataColumn columnInvoiceDate;
    private DataColumn columnDueDate;
    private DataColumn columnPayeeDate;
    private DataColumn columnGrossPremium;
    private DataColumn columnRemitterPremAmt;
    private DataColumn columnPayeePremAmt;
    private DataColumn columnMGAPremCommission;
    private DataColumn columnFees;
    private DataColumn columnRemitterFeeAmt;
    private DataColumn columnPayeeFeeAmt;
    private DataColumn columnMGAFeeCommissions;
    private DataColumn columnNetBilled;
    private DataColumn columnAmtPTD;
    private DataColumn columnSurplus;
    private DataColumn columnTransaction;

    internal QuoteInvoicesDataTable()
      : base("QuoteInvoices")
    {
      this.InitClass();
    }

    internal QuoteInvoicesDataTable(DataTable table)
      : base(table.TableName)
    {
      if (table.CaseSensitive != table.DataSet.CaseSensitive)
        this.CaseSensitive = table.CaseSensitive;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(table.Locale.ToString(), table.DataSet.Locale.ToString(), false) != 0)
        this.Locale = table.Locale;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(table.Namespace, table.DataSet.Namespace, false) != 0)
        this.Namespace = table.Namespace;
      this.Prefix = table.Prefix;
      this.MinimumCapacity = table.MinimumCapacity;
      this.DisplayExpression = table.DisplayExpression;
    }

    [Browsable(false)]
    public int Count => this.Rows.Count;

    internal DataColumn InvoiceNumColumn => this.columnInvoiceNum;

    internal DataColumn OfficeInvoiceNumColumn => this.columnOfficeInvoiceNum;

    internal DataColumn GLOfficeLocationColumn => this.columnGLOfficeLocation;

    internal DataColumn InvoiceDateColumn => this.columnInvoiceDate;

    internal DataColumn DueDateColumn => this.columnDueDate;

    internal DataColumn PayeeDateColumn => this.columnPayeeDate;

    internal DataColumn GrossPremiumColumn => this.columnGrossPremium;

    internal DataColumn RemitterPremAmtColumn => this.columnRemitterPremAmt;

    internal DataColumn PayeePremAmtColumn => this.columnPayeePremAmt;

    internal DataColumn MGAPremCommissionColumn => this.columnMGAPremCommission;

    internal DataColumn FeesColumn => this.columnFees;

    internal DataColumn RemitterFeeAmtColumn => this.columnRemitterFeeAmt;

    internal DataColumn PayeeFeeAmtColumn => this.columnPayeeFeeAmt;

    internal DataColumn MGAFeeCommissionsColumn => this.columnMGAFeeCommissions;

    internal DataColumn NetBilledColumn => this.columnNetBilled;

    internal DataColumn AmtPTDColumn => this.columnAmtPTD;

    internal DataColumn SurplusColumn => this.columnSurplus;

    internal DataColumn TransactionColumn => this.columnTransaction;

    public dsPolicyInquiry.QuoteInvoicesRow this[int index]
    {
      get => (dsPolicyInquiry.QuoteInvoicesRow) this.Rows[index];
    }

    public event dsPolicyInquiry.QuoteInvoicesRowChangeEventHandler QuoteInvoicesRowChanged;

    public event dsPolicyInquiry.QuoteInvoicesRowChangeEventHandler QuoteInvoicesRowChanging;

    public event dsPolicyInquiry.QuoteInvoicesRowChangeEventHandler QuoteInvoicesRowDeleted;

    public event dsPolicyInquiry.QuoteInvoicesRowChangeEventHandler QuoteInvoicesRowDeleting;

    public void AddQuoteInvoicesRow(dsPolicyInquiry.QuoteInvoicesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    public dsPolicyInquiry.QuoteInvoicesRow AddQuoteInvoicesRow(
      int InvoiceNum,
      int OfficeInvoiceNum,
      string GLOfficeLocation,
      DateTime InvoiceDate,
      DateTime DueDate,
      DateTime PayeeDate,
      Decimal GrossPremium,
      Decimal RemitterPremAmt,
      Decimal PayeePremAmt,
      Decimal MGAPremCommission,
      Decimal Fees,
      Decimal RemitterFeeAmt,
      Decimal PayeeFeeAmt,
      Decimal MGAFeeCommissions,
      Decimal NetBilled,
      Decimal AmtPTD,
      Decimal Surplus,
      string Transaction)
    {
      dsPolicyInquiry.QuoteInvoicesRow row = (dsPolicyInquiry.QuoteInvoicesRow) this.NewRow();
      row.ItemArray = new object[18]
      {
        (object) InvoiceNum,
        (object) OfficeInvoiceNum,
        (object) GLOfficeLocation,
        (object) InvoiceDate,
        (object) DueDate,
        (object) PayeeDate,
        (object) GrossPremium,
        (object) RemitterPremAmt,
        (object) PayeePremAmt,
        (object) MGAPremCommission,
        (object) Fees,
        (object) RemitterFeeAmt,
        (object) PayeeFeeAmt,
        (object) MGAFeeCommissions,
        (object) NetBilled,
        (object) AmtPTD,
        (object) Surplus,
        (object) Transaction
      };
      this.Rows.Add((DataRow) row);
      return row;
    }

    public IEnumerator GetEnumerator() => this.Rows.GetEnumerator();

    public override DataTable Clone()
    {
      dsPolicyInquiry.QuoteInvoicesDataTable invoicesDataTable = (dsPolicyInquiry.QuoteInvoicesDataTable) base.Clone();
      invoicesDataTable.InitVars();
      return (DataTable) invoicesDataTable;
    }

    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsPolicyInquiry.QuoteInvoicesDataTable();
    }

    internal void InitVars()
    {
      this.columnInvoiceNum = this.Columns["InvoiceNum"];
      this.columnOfficeInvoiceNum = this.Columns["OfficeInvoiceNum"];
      this.columnGLOfficeLocation = this.Columns["GLOfficeLocation"];
      this.columnInvoiceDate = this.Columns["InvoiceDate"];
      this.columnDueDate = this.Columns["DueDate"];
      this.columnPayeeDate = this.Columns["PayeeDate"];
      this.columnGrossPremium = this.Columns["GrossPremium"];
      this.columnRemitterPremAmt = this.Columns["RemitterPremAmt"];
      this.columnPayeePremAmt = this.Columns["PayeePremAmt"];
      this.columnMGAPremCommission = this.Columns["MGAPremCommission"];
      this.columnFees = this.Columns["Fees"];
      this.columnRemitterFeeAmt = this.Columns["RemitterFeeAmt"];
      this.columnPayeeFeeAmt = this.Columns["PayeeFeeAmt"];
      this.columnMGAFeeCommissions = this.Columns["MGAFeeCommissions"];
      this.columnNetBilled = this.Columns["NetBilled"];
      this.columnAmtPTD = this.Columns["AmtPTD"];
      this.columnSurplus = this.Columns["Surplus"];
      this.columnTransaction = this.Columns["Transaction"];
    }

    private void InitClass()
    {
      this.columnInvoiceNum = new DataColumn("InvoiceNum", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInvoiceNum);
      this.columnOfficeInvoiceNum = new DataColumn("OfficeInvoiceNum", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnOfficeInvoiceNum);
      this.columnGLOfficeLocation = new DataColumn("GLOfficeLocation", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnGLOfficeLocation);
      this.columnInvoiceDate = new DataColumn("InvoiceDate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInvoiceDate);
      this.columnDueDate = new DataColumn("DueDate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDueDate);
      this.columnPayeeDate = new DataColumn("PayeeDate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPayeeDate);
      this.columnGrossPremium = new DataColumn("GrossPremium", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnGrossPremium);
      this.columnRemitterPremAmt = new DataColumn("RemitterPremAmt", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnRemitterPremAmt);
      this.columnPayeePremAmt = new DataColumn("PayeePremAmt", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPayeePremAmt);
      this.columnMGAPremCommission = new DataColumn("MGAPremCommission", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnMGAPremCommission);
      this.columnFees = new DataColumn("Fees", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFees);
      this.columnRemitterFeeAmt = new DataColumn("RemitterFeeAmt", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnRemitterFeeAmt);
      this.columnPayeeFeeAmt = new DataColumn("PayeeFeeAmt", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPayeeFeeAmt);
      this.columnMGAFeeCommissions = new DataColumn("MGAFeeCommissions", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnMGAFeeCommissions);
      this.columnNetBilled = new DataColumn("NetBilled", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnNetBilled);
      this.columnAmtPTD = new DataColumn("AmtPTD", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAmtPTD);
      this.columnSurplus = new DataColumn("Surplus", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSurplus);
      this.columnTransaction = new DataColumn("Transaction", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnTransaction);
      this.Constraints.Add((Constraint) new UniqueConstraint("key1", new DataColumn[1]
      {
        this.columnInvoiceNum
      }, false));
      this.columnInvoiceNum.AllowDBNull = false;
      this.columnInvoiceNum.Unique = true;
    }

    public dsPolicyInquiry.QuoteInvoicesRow NewQuoteInvoicesRow()
    {
      return (dsPolicyInquiry.QuoteInvoicesRow) this.NewRow();
    }

    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsPolicyInquiry.QuoteInvoicesRow(builder);
    }

    protected override Type GetRowType() => typeof (dsPolicyInquiry.QuoteInvoicesRow);

    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.QuoteInvoicesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyInquiry.QuoteInvoicesRowChangeEventHandler invoicesRowChangedEvent = this.QuoteInvoicesRowChangedEvent;
      if (invoicesRowChangedEvent == null)
        return;
      invoicesRowChangedEvent((object) this, new dsPolicyInquiry.QuoteInvoicesRowChangeEvent((dsPolicyInquiry.QuoteInvoicesRow) e.Row, e.Action));
    }

    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.QuoteInvoicesRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyInquiry.QuoteInvoicesRowChangeEventHandler rowChangingEvent = this.QuoteInvoicesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsPolicyInquiry.QuoteInvoicesRowChangeEvent((dsPolicyInquiry.QuoteInvoicesRow) e.Row, e.Action));
    }

    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.QuoteInvoicesRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyInquiry.QuoteInvoicesRowChangeEventHandler invoicesRowDeletedEvent = this.QuoteInvoicesRowDeletedEvent;
      if (invoicesRowDeletedEvent == null)
        return;
      invoicesRowDeletedEvent((object) this, new dsPolicyInquiry.QuoteInvoicesRowChangeEvent((dsPolicyInquiry.QuoteInvoicesRow) e.Row, e.Action));
    }

    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.QuoteInvoicesRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyInquiry.QuoteInvoicesRowChangeEventHandler rowDeletingEvent = this.QuoteInvoicesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsPolicyInquiry.QuoteInvoicesRowChangeEvent((dsPolicyInquiry.QuoteInvoicesRow) e.Row, e.Action));
    }

    public void RemoveQuoteInvoicesRow(dsPolicyInquiry.QuoteInvoicesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }
  }

  [DebuggerStepThrough]
  public class QuoteInvoicesRow : DataRow
  {
    private dsPolicyInquiry.QuoteInvoicesDataTable tableQuoteInvoices;

    internal QuoteInvoicesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableQuoteInvoices = (dsPolicyInquiry.QuoteInvoicesDataTable) this.Table;
    }

    public int InvoiceNum
    {
      get => Conversions.ToInteger(this[this.tableQuoteInvoices.InvoiceNumColumn]);
      set => this[this.tableQuoteInvoices.InvoiceNumColumn] = (object) value;
    }

    public int OfficeInvoiceNum
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tableQuoteInvoices.OfficeInvoiceNumColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableQuoteInvoices.OfficeInvoiceNumColumn] = (object) value;
    }

    public string GLOfficeLocation
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableQuoteInvoices.GLOfficeLocationColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableQuoteInvoices.GLOfficeLocationColumn] = (object) value;
    }

    public DateTime InvoiceDate
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tableQuoteInvoices.InvoiceDateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableQuoteInvoices.InvoiceDateColumn] = (object) value;
    }

    public DateTime DueDate
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tableQuoteInvoices.DueDateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableQuoteInvoices.DueDateColumn] = (object) value;
    }

    public DateTime PayeeDate
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tableQuoteInvoices.PayeeDateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableQuoteInvoices.PayeeDateColumn] = (object) value;
    }

    public Decimal GrossPremium
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tableQuoteInvoices.GrossPremiumColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableQuoteInvoices.GrossPremiumColumn] = (object) value;
    }

    public Decimal RemitterPremAmt
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tableQuoteInvoices.RemitterPremAmtColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableQuoteInvoices.RemitterPremAmtColumn] = (object) value;
    }

    public Decimal PayeePremAmt
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tableQuoteInvoices.PayeePremAmtColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableQuoteInvoices.PayeePremAmtColumn] = (object) value;
    }

    public Decimal MGAPremCommission
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tableQuoteInvoices.MGAPremCommissionColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableQuoteInvoices.MGAPremCommissionColumn] = (object) value;
    }

    public Decimal Fees
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tableQuoteInvoices.FeesColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableQuoteInvoices.FeesColumn] = (object) value;
    }

    public Decimal RemitterFeeAmt
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tableQuoteInvoices.RemitterFeeAmtColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableQuoteInvoices.RemitterFeeAmtColumn] = (object) value;
    }

    public Decimal PayeeFeeAmt
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tableQuoteInvoices.PayeeFeeAmtColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableQuoteInvoices.PayeeFeeAmtColumn] = (object) value;
    }

    public Decimal MGAFeeCommissions
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tableQuoteInvoices.MGAFeeCommissionsColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableQuoteInvoices.MGAFeeCommissionsColumn] = (object) value;
    }

    public Decimal NetBilled
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tableQuoteInvoices.NetBilledColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableQuoteInvoices.NetBilledColumn] = (object) value;
    }

    public Decimal AmtPTD
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tableQuoteInvoices.AmtPTDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableQuoteInvoices.AmtPTDColumn] = (object) value;
    }

    public Decimal Surplus
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tableQuoteInvoices.SurplusColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableQuoteInvoices.SurplusColumn] = (object) value;
    }

    public string Transaction
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableQuoteInvoices.TransactionColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableQuoteInvoices.TransactionColumn] = (object) value;
    }

    public bool IsOfficeInvoiceNumNull()
    {
      return this.IsNull(this.tableQuoteInvoices.OfficeInvoiceNumColumn);
    }

    public void SetOfficeInvoiceNumNull()
    {
      this[this.tableQuoteInvoices.OfficeInvoiceNumColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsGLOfficeLocationNull()
    {
      return this.IsNull(this.tableQuoteInvoices.GLOfficeLocationColumn);
    }

    public void SetGLOfficeLocationNull()
    {
      this[this.tableQuoteInvoices.GLOfficeLocationColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsInvoiceDateNull() => this.IsNull(this.tableQuoteInvoices.InvoiceDateColumn);

    public void SetInvoiceDateNull()
    {
      this[this.tableQuoteInvoices.InvoiceDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsDueDateNull() => this.IsNull(this.tableQuoteInvoices.DueDateColumn);

    public void SetDueDateNull()
    {
      this[this.tableQuoteInvoices.DueDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsPayeeDateNull() => this.IsNull(this.tableQuoteInvoices.PayeeDateColumn);

    public void SetPayeeDateNull()
    {
      this[this.tableQuoteInvoices.PayeeDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsGrossPremiumNull() => this.IsNull(this.tableQuoteInvoices.GrossPremiumColumn);

    public void SetGrossPremiumNull()
    {
      this[this.tableQuoteInvoices.GrossPremiumColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsRemitterPremAmtNull()
    {
      return this.IsNull(this.tableQuoteInvoices.RemitterPremAmtColumn);
    }

    public void SetRemitterPremAmtNull()
    {
      this[this.tableQuoteInvoices.RemitterPremAmtColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsPayeePremAmtNull() => this.IsNull(this.tableQuoteInvoices.PayeePremAmtColumn);

    public void SetPayeePremAmtNull()
    {
      this[this.tableQuoteInvoices.PayeePremAmtColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsMGAPremCommissionNull()
    {
      return this.IsNull(this.tableQuoteInvoices.MGAPremCommissionColumn);
    }

    public void SetMGAPremCommissionNull()
    {
      this[this.tableQuoteInvoices.MGAPremCommissionColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsFeesNull() => this.IsNull(this.tableQuoteInvoices.FeesColumn);

    public void SetFeesNull()
    {
      this[this.tableQuoteInvoices.FeesColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsRemitterFeeAmtNull() => this.IsNull(this.tableQuoteInvoices.RemitterFeeAmtColumn);

    public void SetRemitterFeeAmtNull()
    {
      this[this.tableQuoteInvoices.RemitterFeeAmtColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsPayeeFeeAmtNull() => this.IsNull(this.tableQuoteInvoices.PayeeFeeAmtColumn);

    public void SetPayeeFeeAmtNull()
    {
      this[this.tableQuoteInvoices.PayeeFeeAmtColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsMGAFeeCommissionsNull()
    {
      return this.IsNull(this.tableQuoteInvoices.MGAFeeCommissionsColumn);
    }

    public void SetMGAFeeCommissionsNull()
    {
      this[this.tableQuoteInvoices.MGAFeeCommissionsColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsNetBilledNull() => this.IsNull(this.tableQuoteInvoices.NetBilledColumn);

    public void SetNetBilledNull()
    {
      this[this.tableQuoteInvoices.NetBilledColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsAmtPTDNull() => this.IsNull(this.tableQuoteInvoices.AmtPTDColumn);

    public void SetAmtPTDNull()
    {
      this[this.tableQuoteInvoices.AmtPTDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsSurplusNull() => this.IsNull(this.tableQuoteInvoices.SurplusColumn);

    public void SetSurplusNull()
    {
      this[this.tableQuoteInvoices.SurplusColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsTransactionNull() => this.IsNull(this.tableQuoteInvoices.TransactionColumn);

    public void SetTransactionNull()
    {
      this[this.tableQuoteInvoices.TransactionColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public dsPolicyInquiry.InvoiceTransactionsRow[] GetInvoiceTransactionsRows()
    {
      return (dsPolicyInquiry.InvoiceTransactionsRow[]) this.GetChildRows(this.Table.ChildRelations["QuoteInvoicesInvoiceTransactions"]);
    }
  }

  [DebuggerStepThrough]
  public class QuoteInvoicesRowChangeEvent : EventArgs
  {
    private dsPolicyInquiry.QuoteInvoicesRow eventRow;
    private DataRowAction eventAction;

    public QuoteInvoicesRowChangeEvent(dsPolicyInquiry.QuoteInvoicesRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    public dsPolicyInquiry.QuoteInvoicesRow Row => this.eventRow;

    public DataRowAction Action => this.eventAction;
  }
}
