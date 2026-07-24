// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.AccountingDatasets.dsRemittanceData
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
public class dsRemittanceData : DataSet
{
  private dsRemittanceData.PostedDetailsDataTable tablePostedDetails;
  private dsRemittanceData.OutstandingPoliciesDataTable tableOutstandingPolicies;
  private dsRemittanceData.OutstandingPolicyInvoicesDataTable tableOutstandingPolicyInvoices;
  private dsRemittanceData.OutstandingInvoiceDetailsDataTable tableOutstandingInvoiceDetails;
  private dsRemittanceData.PostedHeaderDataTable tablePostedHeader;
  private DataRelation relationOutstandingPolicyInvoicesOutstandingInvoiceDetails;
  private DataRelation relationOutstandingPoliciesOutstandingPolicyInvoices;
  private DataRelation relationPostedHeaderPostedDetails;

  public dsRemittanceData()
  {
    this.InitClass();
    CollectionChangeEventHandler changeEventHandler = new CollectionChangeEventHandler(this.SchemaChanged);
    this.Tables.CollectionChanged += changeEventHandler;
    this.Relations.CollectionChanged += changeEventHandler;
  }

  protected dsRemittanceData(SerializationInfo info, StreamingContext context)
  {
    string s = Conversions.ToString(info.GetValue("XmlSchema", typeof (string)));
    if (s != null)
    {
      DataSet dataSet = new DataSet();
      dataSet.ReadXmlSchema((XmlReader) new XmlTextReader((TextReader) new StringReader(s)));
      if (dataSet.Tables[nameof (PostedDetails)] != null)
        this.Tables.Add((DataTable) new dsRemittanceData.PostedDetailsDataTable(dataSet.Tables[nameof (PostedDetails)]));
      if (dataSet.Tables[nameof (OutstandingPolicies)] != null)
        this.Tables.Add((DataTable) new dsRemittanceData.OutstandingPoliciesDataTable(dataSet.Tables[nameof (OutstandingPolicies)]));
      if (dataSet.Tables[nameof (OutstandingPolicyInvoices)] != null)
        this.Tables.Add((DataTable) new dsRemittanceData.OutstandingPolicyInvoicesDataTable(dataSet.Tables[nameof (OutstandingPolicyInvoices)]));
      if (dataSet.Tables[nameof (OutstandingInvoiceDetails)] != null)
        this.Tables.Add((DataTable) new dsRemittanceData.OutstandingInvoiceDetailsDataTable(dataSet.Tables[nameof (OutstandingInvoiceDetails)]));
      if (dataSet.Tables[nameof (PostedHeader)] != null)
        this.Tables.Add((DataTable) new dsRemittanceData.PostedHeaderDataTable(dataSet.Tables[nameof (PostedHeader)]));
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
  public dsRemittanceData.PostedDetailsDataTable PostedDetails => this.tablePostedDetails;

  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsRemittanceData.OutstandingPoliciesDataTable OutstandingPolicies
  {
    get => this.tableOutstandingPolicies;
  }

  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsRemittanceData.OutstandingPolicyInvoicesDataTable OutstandingPolicyInvoices
  {
    get => this.tableOutstandingPolicyInvoices;
  }

  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsRemittanceData.OutstandingInvoiceDetailsDataTable OutstandingInvoiceDetails
  {
    get => this.tableOutstandingInvoiceDetails;
  }

  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsRemittanceData.PostedHeaderDataTable PostedHeader => this.tablePostedHeader;

  public override DataSet Clone()
  {
    dsRemittanceData dsRemittanceData = (dsRemittanceData) base.Clone();
    dsRemittanceData.InitVars();
    return (DataSet) dsRemittanceData;
  }

  protected override bool ShouldSerializeTables() => false;

  protected override bool ShouldSerializeRelations() => false;

  protected override void ReadXmlSerializable(XmlReader reader)
  {
    this.Reset();
    DataSet dataSet = new DataSet();
    int num = (int) dataSet.ReadXml(reader);
    if (dataSet.Tables["PostedDetails"] != null)
      this.Tables.Add((DataTable) new dsRemittanceData.PostedDetailsDataTable(dataSet.Tables["PostedDetails"]));
    if (dataSet.Tables["OutstandingPolicies"] != null)
      this.Tables.Add((DataTable) new dsRemittanceData.OutstandingPoliciesDataTable(dataSet.Tables["OutstandingPolicies"]));
    if (dataSet.Tables["OutstandingPolicyInvoices"] != null)
      this.Tables.Add((DataTable) new dsRemittanceData.OutstandingPolicyInvoicesDataTable(dataSet.Tables["OutstandingPolicyInvoices"]));
    if (dataSet.Tables["OutstandingInvoiceDetails"] != null)
      this.Tables.Add((DataTable) new dsRemittanceData.OutstandingInvoiceDetailsDataTable(dataSet.Tables["OutstandingInvoiceDetails"]));
    if (dataSet.Tables["PostedHeader"] != null)
      this.Tables.Add((DataTable) new dsRemittanceData.PostedHeaderDataTable(dataSet.Tables["PostedHeader"]));
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
    this.tablePostedDetails = (dsRemittanceData.PostedDetailsDataTable) this.Tables["PostedDetails"];
    if (this.tablePostedDetails != null)
      this.tablePostedDetails.InitVars();
    this.tableOutstandingPolicies = (dsRemittanceData.OutstandingPoliciesDataTable) this.Tables["OutstandingPolicies"];
    if (this.tableOutstandingPolicies != null)
      this.tableOutstandingPolicies.InitVars();
    this.tableOutstandingPolicyInvoices = (dsRemittanceData.OutstandingPolicyInvoicesDataTable) this.Tables["OutstandingPolicyInvoices"];
    if (this.tableOutstandingPolicyInvoices != null)
      this.tableOutstandingPolicyInvoices.InitVars();
    this.tableOutstandingInvoiceDetails = (dsRemittanceData.OutstandingInvoiceDetailsDataTable) this.Tables["OutstandingInvoiceDetails"];
    if (this.tableOutstandingInvoiceDetails != null)
      this.tableOutstandingInvoiceDetails.InitVars();
    this.tablePostedHeader = (dsRemittanceData.PostedHeaderDataTable) this.Tables["PostedHeader"];
    if (this.tablePostedHeader != null)
      this.tablePostedHeader.InitVars();
    this.relationOutstandingPolicyInvoicesOutstandingInvoiceDetails = this.Relations["OutstandingPolicyInvoicesOutstandingInvoiceDetails"];
    this.relationOutstandingPoliciesOutstandingPolicyInvoices = this.Relations["OutstandingPoliciesOutstandingPolicyInvoices"];
    this.relationPostedHeaderPostedDetails = this.Relations["PostedHeaderPostedDetails"];
  }

  private void InitClass()
  {
    this.DataSetName = nameof (dsRemittanceData);
    this.Prefix = "";
    this.Namespace = "http://www.tempuri.org/dsRemittanceData.xsd";
    this.Locale = new CultureInfo("en-US");
    this.CaseSensitive = false;
    this.EnforceConstraints = true;
    this.tablePostedDetails = new dsRemittanceData.PostedDetailsDataTable();
    this.Tables.Add((DataTable) this.tablePostedDetails);
    this.tableOutstandingPolicies = new dsRemittanceData.OutstandingPoliciesDataTable();
    this.Tables.Add((DataTable) this.tableOutstandingPolicies);
    this.tableOutstandingPolicyInvoices = new dsRemittanceData.OutstandingPolicyInvoicesDataTable();
    this.Tables.Add((DataTable) this.tableOutstandingPolicyInvoices);
    this.tableOutstandingInvoiceDetails = new dsRemittanceData.OutstandingInvoiceDetailsDataTable();
    this.Tables.Add((DataTable) this.tableOutstandingInvoiceDetails);
    this.tablePostedHeader = new dsRemittanceData.PostedHeaderDataTable();
    this.Tables.Add((DataTable) this.tablePostedHeader);
    ForeignKeyConstraint foreignKeyConstraint1 = new ForeignKeyConstraint("PostedHeaderPostedDetails", new DataColumn[1]
    {
      this.tablePostedHeader.TransactNumColumn
    }, new DataColumn[1]
    {
      this.tablePostedDetails.TransactNumColumn
    });
    this.tablePostedDetails.Constraints.Add((Constraint) foreignKeyConstraint1);
    foreignKeyConstraint1.AcceptRejectRule = AcceptRejectRule.None;
    foreignKeyConstraint1.DeleteRule = Rule.Cascade;
    foreignKeyConstraint1.UpdateRule = Rule.Cascade;
    ForeignKeyConstraint foreignKeyConstraint2 = new ForeignKeyConstraint("OutstandingPoliciesOutstandingPolicyInvoices", new DataColumn[2]
    {
      this.tableOutstandingPolicies.RemitterGUIDColumn,
      this.tableOutstandingPolicies.QuoteControlNumColumn
    }, new DataColumn[2]
    {
      this.tableOutstandingPolicyInvoices.RemitterGUIDColumn,
      this.tableOutstandingPolicyInvoices.QuoteControlNumColumn
    });
    this.tableOutstandingPolicyInvoices.Constraints.Add((Constraint) foreignKeyConstraint2);
    foreignKeyConstraint2.AcceptRejectRule = AcceptRejectRule.None;
    foreignKeyConstraint2.DeleteRule = Rule.Cascade;
    foreignKeyConstraint2.UpdateRule = Rule.Cascade;
    ForeignKeyConstraint foreignKeyConstraint3 = new ForeignKeyConstraint("OutstandingPolicyInvoicesOutstandingInvoiceDetails", new DataColumn[1]
    {
      this.tableOutstandingPolicyInvoices.InvoiceNumColumn
    }, new DataColumn[1]
    {
      this.tableOutstandingInvoiceDetails.InvoiceNumColumn
    });
    this.tableOutstandingInvoiceDetails.Constraints.Add((Constraint) foreignKeyConstraint3);
    foreignKeyConstraint3.AcceptRejectRule = AcceptRejectRule.None;
    foreignKeyConstraint3.DeleteRule = Rule.Cascade;
    foreignKeyConstraint3.UpdateRule = Rule.Cascade;
    this.relationOutstandingPolicyInvoicesOutstandingInvoiceDetails = new DataRelation("OutstandingPolicyInvoicesOutstandingInvoiceDetails", new DataColumn[1]
    {
      this.tableOutstandingPolicyInvoices.InvoiceNumColumn
    }, new DataColumn[1]
    {
      this.tableOutstandingInvoiceDetails.InvoiceNumColumn
    }, false);
    this.Relations.Add(this.relationOutstandingPolicyInvoicesOutstandingInvoiceDetails);
    this.relationOutstandingPoliciesOutstandingPolicyInvoices = new DataRelation("OutstandingPoliciesOutstandingPolicyInvoices", new DataColumn[2]
    {
      this.tableOutstandingPolicies.RemitterGUIDColumn,
      this.tableOutstandingPolicies.QuoteControlNumColumn
    }, new DataColumn[2]
    {
      this.tableOutstandingPolicyInvoices.RemitterGUIDColumn,
      this.tableOutstandingPolicyInvoices.QuoteControlNumColumn
    }, false);
    this.Relations.Add(this.relationOutstandingPoliciesOutstandingPolicyInvoices);
    this.relationPostedHeaderPostedDetails = new DataRelation("PostedHeaderPostedDetails", new DataColumn[1]
    {
      this.tablePostedHeader.TransactNumColumn
    }, new DataColumn[1]
    {
      this.tablePostedDetails.TransactNumColumn
    }, false);
    this.Relations.Add(this.relationPostedHeaderPostedDetails);
  }

  private bool ShouldSerializePostedDetails() => false;

  private bool ShouldSerializeOutstandingPolicies() => false;

  private bool ShouldSerializeOutstandingPolicyInvoices() => false;

  private bool ShouldSerializeOutstandingInvoiceDetails() => false;

  private bool ShouldSerializePostedHeader() => false;

  private void SchemaChanged(object sender, CollectionChangeEventArgs e)
  {
    if (e.Action != CollectionChangeAction.Remove)
      return;
    this.InitVars();
  }

  public delegate void PostedDetailsRowChangeEventHandler(
    object sender,
    dsRemittanceData.PostedDetailsRowChangeEvent e);

  public delegate void OutstandingPoliciesRowChangeEventHandler(
    object sender,
    dsRemittanceData.OutstandingPoliciesRowChangeEvent e);

  public delegate void OutstandingPolicyInvoicesRowChangeEventHandler(
    object sender,
    dsRemittanceData.OutstandingPolicyInvoicesRowChangeEvent e);

  public delegate void OutstandingInvoiceDetailsRowChangeEventHandler(
    object sender,
    dsRemittanceData.OutstandingInvoiceDetailsRowChangeEvent e);

  public delegate void PostedHeaderRowChangeEventHandler(
    object sender,
    dsRemittanceData.PostedHeaderRowChangeEvent e);

  [DebuggerStepThrough]
  public class PostedDetailsDataTable : DataTable, IEnumerable
  {
    private DataColumn columnTransactNum;
    private DataColumn columnPostingNum;
    private DataColumn columnInvoiceNum;
    private DataColumn columnOfficeInvoiceNum;
    private DataColumn columnLineItem;
    private DataColumn columnCreditAcct;
    private DataColumn columnAmount;
    private DataColumn columnComments;

    internal PostedDetailsDataTable()
      : base("PostedDetails")
    {
      this.InitClass();
    }

    internal PostedDetailsDataTable(DataTable table)
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

    internal DataColumn TransactNumColumn => this.columnTransactNum;

    internal DataColumn PostingNumColumn => this.columnPostingNum;

    internal DataColumn InvoiceNumColumn => this.columnInvoiceNum;

    internal DataColumn OfficeInvoiceNumColumn => this.columnOfficeInvoiceNum;

    internal DataColumn LineItemColumn => this.columnLineItem;

    internal DataColumn CreditAcctColumn => this.columnCreditAcct;

    internal DataColumn AmountColumn => this.columnAmount;

    internal DataColumn CommentsColumn => this.columnComments;

    public dsRemittanceData.PostedDetailsRow this[int index]
    {
      get => (dsRemittanceData.PostedDetailsRow) this.Rows[index];
    }

    public event dsRemittanceData.PostedDetailsRowChangeEventHandler PostedDetailsRowChanged;

    public event dsRemittanceData.PostedDetailsRowChangeEventHandler PostedDetailsRowChanging;

    public event dsRemittanceData.PostedDetailsRowChangeEventHandler PostedDetailsRowDeleted;

    public event dsRemittanceData.PostedDetailsRowChangeEventHandler PostedDetailsRowDeleting;

    public void AddPostedDetailsRow(dsRemittanceData.PostedDetailsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    public dsRemittanceData.PostedDetailsRow AddPostedDetailsRow(
      dsRemittanceData.PostedHeaderRow parentPostedHeaderRowByPostedHeaderPostedDetails,
      int PostingNum,
      int InvoiceNum,
      int OfficeInvoiceNum,
      string LineItem,
      string CreditAcct,
      Decimal Amount,
      string Comments)
    {
      dsRemittanceData.PostedDetailsRow row = (dsRemittanceData.PostedDetailsRow) this.NewRow();
      row.ItemArray = new object[8]
      {
        parentPostedHeaderRowByPostedHeaderPostedDetails[0],
        (object) PostingNum,
        (object) InvoiceNum,
        (object) OfficeInvoiceNum,
        (object) LineItem,
        (object) CreditAcct,
        (object) Amount,
        (object) Comments
      };
      this.Rows.Add((DataRow) row);
      return row;
    }

    public IEnumerator GetEnumerator() => this.Rows.GetEnumerator();

    public override DataTable Clone()
    {
      dsRemittanceData.PostedDetailsDataTable detailsDataTable = (dsRemittanceData.PostedDetailsDataTable) base.Clone();
      detailsDataTable.InitVars();
      return (DataTable) detailsDataTable;
    }

    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsRemittanceData.PostedDetailsDataTable();
    }

    internal void InitVars()
    {
      this.columnTransactNum = this.Columns["TransactNum"];
      this.columnPostingNum = this.Columns["PostingNum"];
      this.columnInvoiceNum = this.Columns["InvoiceNum"];
      this.columnOfficeInvoiceNum = this.Columns["OfficeInvoiceNum"];
      this.columnLineItem = this.Columns["LineItem"];
      this.columnCreditAcct = this.Columns["CreditAcct"];
      this.columnAmount = this.Columns["Amount"];
      this.columnComments = this.Columns["Comments"];
    }

    private void InitClass()
    {
      this.columnTransactNum = new DataColumn("TransactNum", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnTransactNum);
      this.columnPostingNum = new DataColumn("PostingNum", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPostingNum);
      this.columnInvoiceNum = new DataColumn("InvoiceNum", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInvoiceNum);
      this.columnOfficeInvoiceNum = new DataColumn("OfficeInvoiceNum", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnOfficeInvoiceNum);
      this.columnLineItem = new DataColumn("LineItem", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLineItem);
      this.columnCreditAcct = new DataColumn("CreditAcct", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCreditAcct);
      this.columnAmount = new DataColumn("Amount", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAmount);
      this.columnComments = new DataColumn("Comments", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnComments);
      this.columnLineItem.ReadOnly = true;
      this.columnAmount.AllowDBNull = false;
    }

    public dsRemittanceData.PostedDetailsRow NewPostedDetailsRow()
    {
      return (dsRemittanceData.PostedDetailsRow) this.NewRow();
    }

    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsRemittanceData.PostedDetailsRow(builder);
    }

    protected override Type GetRowType() => typeof (dsRemittanceData.PostedDetailsRow);

    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.PostedDetailsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsRemittanceData.PostedDetailsRowChangeEventHandler detailsRowChangedEvent = this.PostedDetailsRowChangedEvent;
      if (detailsRowChangedEvent == null)
        return;
      detailsRowChangedEvent((object) this, new dsRemittanceData.PostedDetailsRowChangeEvent((dsRemittanceData.PostedDetailsRow) e.Row, e.Action));
    }

    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.PostedDetailsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsRemittanceData.PostedDetailsRowChangeEventHandler rowChangingEvent = this.PostedDetailsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsRemittanceData.PostedDetailsRowChangeEvent((dsRemittanceData.PostedDetailsRow) e.Row, e.Action));
    }

    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.PostedDetailsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsRemittanceData.PostedDetailsRowChangeEventHandler detailsRowDeletedEvent = this.PostedDetailsRowDeletedEvent;
      if (detailsRowDeletedEvent == null)
        return;
      detailsRowDeletedEvent((object) this, new dsRemittanceData.PostedDetailsRowChangeEvent((dsRemittanceData.PostedDetailsRow) e.Row, e.Action));
    }

    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.PostedDetailsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsRemittanceData.PostedDetailsRowChangeEventHandler rowDeletingEvent = this.PostedDetailsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsRemittanceData.PostedDetailsRowChangeEvent((dsRemittanceData.PostedDetailsRow) e.Row, e.Action));
    }

    public void RemovePostedDetailsRow(dsRemittanceData.PostedDetailsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }
  }

  [DebuggerStepThrough]
  public class PostedDetailsRow : DataRow
  {
    private dsRemittanceData.PostedDetailsDataTable tablePostedDetails;

    internal PostedDetailsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablePostedDetails = (dsRemittanceData.PostedDetailsDataTable) this.Table;
    }

    public int TransactNum
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tablePostedDetails.TransactNumColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePostedDetails.TransactNumColumn] = (object) value;
    }

    public int PostingNum
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tablePostedDetails.PostingNumColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePostedDetails.PostingNumColumn] = (object) value;
    }

    public int InvoiceNum
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tablePostedDetails.InvoiceNumColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePostedDetails.InvoiceNumColumn] = (object) value;
    }

    public int OfficeInvoiceNum
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tablePostedDetails.OfficeInvoiceNumColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePostedDetails.OfficeInvoiceNumColumn] = (object) value;
    }

    public string LineItem
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablePostedDetails.LineItemColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePostedDetails.LineItemColumn] = (object) value;
    }

    public string CreditAcct
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablePostedDetails.CreditAcctColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePostedDetails.CreditAcctColumn] = (object) value;
    }

    public Decimal Amount
    {
      get => Conversions.ToDecimal(this[this.tablePostedDetails.AmountColumn]);
      set => this[this.tablePostedDetails.AmountColumn] = (object) value;
    }

    public string Comments
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablePostedDetails.CommentsColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePostedDetails.CommentsColumn] = (object) value;
    }

    public dsRemittanceData.PostedHeaderRow PostedHeaderRow
    {
      get
      {
        return (dsRemittanceData.PostedHeaderRow) this.GetParentRow(this.Table.ParentRelations["PostedHeaderPostedDetails"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["PostedHeaderPostedDetails"]);
      }
    }

    public bool IsTransactNumNull() => this.IsNull(this.tablePostedDetails.TransactNumColumn);

    public void SetTransactNumNull()
    {
      this[this.tablePostedDetails.TransactNumColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsPostingNumNull() => this.IsNull(this.tablePostedDetails.PostingNumColumn);

    public void SetPostingNumNull()
    {
      this[this.tablePostedDetails.PostingNumColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsInvoiceNumNull() => this.IsNull(this.tablePostedDetails.InvoiceNumColumn);

    public void SetInvoiceNumNull()
    {
      this[this.tablePostedDetails.InvoiceNumColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsOfficeInvoiceNumNull()
    {
      return this.IsNull(this.tablePostedDetails.OfficeInvoiceNumColumn);
    }

    public void SetOfficeInvoiceNumNull()
    {
      this[this.tablePostedDetails.OfficeInvoiceNumColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsLineItemNull() => this.IsNull(this.tablePostedDetails.LineItemColumn);

    public void SetLineItemNull()
    {
      this[this.tablePostedDetails.LineItemColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsCreditAcctNull() => this.IsNull(this.tablePostedDetails.CreditAcctColumn);

    public void SetCreditAcctNull()
    {
      this[this.tablePostedDetails.CreditAcctColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsCommentsNull() => this.IsNull(this.tablePostedDetails.CommentsColumn);

    public void SetCommentsNull()
    {
      this[this.tablePostedDetails.CommentsColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  [DebuggerStepThrough]
  public class PostedDetailsRowChangeEvent : EventArgs
  {
    private dsRemittanceData.PostedDetailsRow eventRow;
    private DataRowAction eventAction;

    public PostedDetailsRowChangeEvent(dsRemittanceData.PostedDetailsRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    public dsRemittanceData.PostedDetailsRow Row => this.eventRow;

    public DataRowAction Action => this.eventAction;
  }

  [DebuggerStepThrough]
  public class OutstandingPoliciesDataTable : DataTable, IEnumerable
  {
    private DataColumn columnQuoteControlNum;
    private DataColumn columnRemitterGUID;
    private DataColumn columnRemitterName;
    private DataColumn columnAddress;
    private DataColumn columnPolicyNumber;
    private DataColumn columnEffectiveDate;
    private DataColumn columnExpirationDate;
    private DataColumn columnInsuredName;
    private DataColumn columnBalanceDue;
    private DataColumn columnOverPaidBal;

    internal OutstandingPoliciesDataTable()
      : base("OutstandingPolicies")
    {
      this.InitClass();
    }

    internal OutstandingPoliciesDataTable(DataTable table)
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

    internal DataColumn QuoteControlNumColumn => this.columnQuoteControlNum;

    internal DataColumn RemitterGUIDColumn => this.columnRemitterGUID;

    internal DataColumn RemitterNameColumn => this.columnRemitterName;

    internal DataColumn AddressColumn => this.columnAddress;

    internal DataColumn PolicyNumberColumn => this.columnPolicyNumber;

    internal DataColumn EffectiveDateColumn => this.columnEffectiveDate;

    internal DataColumn ExpirationDateColumn => this.columnExpirationDate;

    internal DataColumn InsuredNameColumn => this.columnInsuredName;

    internal DataColumn BalanceDueColumn => this.columnBalanceDue;

    internal DataColumn OverPaidBalColumn => this.columnOverPaidBal;

    public dsRemittanceData.OutstandingPoliciesRow this[int index]
    {
      get => (dsRemittanceData.OutstandingPoliciesRow) this.Rows[index];
    }

    public event dsRemittanceData.OutstandingPoliciesRowChangeEventHandler OutstandingPoliciesRowChanged;

    public event dsRemittanceData.OutstandingPoliciesRowChangeEventHandler OutstandingPoliciesRowChanging;

    public event dsRemittanceData.OutstandingPoliciesRowChangeEventHandler OutstandingPoliciesRowDeleted;

    public event dsRemittanceData.OutstandingPoliciesRowChangeEventHandler OutstandingPoliciesRowDeleting;

    public void AddOutstandingPoliciesRow(dsRemittanceData.OutstandingPoliciesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    public dsRemittanceData.OutstandingPoliciesRow AddOutstandingPoliciesRow(
      int QuoteControlNum,
      Guid RemitterGUID,
      string RemitterName,
      string Address,
      string PolicyNumber,
      DateTime EffectiveDate,
      DateTime ExpirationDate,
      string InsuredName,
      Decimal BalanceDue,
      Decimal OverPaidBal)
    {
      dsRemittanceData.OutstandingPoliciesRow row = (dsRemittanceData.OutstandingPoliciesRow) this.NewRow();
      row.ItemArray = new object[10]
      {
        (object) QuoteControlNum,
        (object) RemitterGUID,
        (object) RemitterName,
        (object) Address,
        (object) PolicyNumber,
        (object) EffectiveDate,
        (object) ExpirationDate,
        (object) InsuredName,
        (object) BalanceDue,
        (object) OverPaidBal
      };
      this.Rows.Add((DataRow) row);
      return row;
    }

    public IEnumerator GetEnumerator() => this.Rows.GetEnumerator();

    public override DataTable Clone()
    {
      dsRemittanceData.OutstandingPoliciesDataTable policiesDataTable = (dsRemittanceData.OutstandingPoliciesDataTable) base.Clone();
      policiesDataTable.InitVars();
      return (DataTable) policiesDataTable;
    }

    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsRemittanceData.OutstandingPoliciesDataTable();
    }

    internal void InitVars()
    {
      this.columnQuoteControlNum = this.Columns["QuoteControlNum"];
      this.columnRemitterGUID = this.Columns["RemitterGUID"];
      this.columnRemitterName = this.Columns["RemitterName"];
      this.columnAddress = this.Columns["Address"];
      this.columnPolicyNumber = this.Columns["PolicyNumber"];
      this.columnEffectiveDate = this.Columns["EffectiveDate"];
      this.columnExpirationDate = this.Columns["ExpirationDate"];
      this.columnInsuredName = this.Columns["InsuredName"];
      this.columnBalanceDue = this.Columns["BalanceDue"];
      this.columnOverPaidBal = this.Columns["OverPaidBal"];
    }

    private void InitClass()
    {
      this.columnQuoteControlNum = new DataColumn("QuoteControlNum", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnQuoteControlNum);
      this.columnRemitterGUID = new DataColumn("RemitterGUID", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnRemitterGUID);
      this.columnRemitterName = new DataColumn("RemitterName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnRemitterName);
      this.columnAddress = new DataColumn("Address", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAddress);
      this.columnPolicyNumber = new DataColumn("PolicyNumber", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPolicyNumber);
      this.columnEffectiveDate = new DataColumn("EffectiveDate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEffectiveDate);
      this.columnExpirationDate = new DataColumn("ExpirationDate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnExpirationDate);
      this.columnInsuredName = new DataColumn("InsuredName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInsuredName);
      this.columnBalanceDue = new DataColumn("BalanceDue", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnBalanceDue);
      this.columnOverPaidBal = new DataColumn("OverPaidBal", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnOverPaidBal);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnQuoteControlNum
      }, false));
      this.Constraints.Add((Constraint) new UniqueConstraint("dsRemittanceDataKey1", new DataColumn[2]
      {
        this.columnRemitterGUID,
        this.columnQuoteControlNum
      }, false));
      this.columnQuoteControlNum.AllowDBNull = false;
      this.columnQuoteControlNum.Unique = true;
      this.columnRemitterGUID.AllowDBNull = false;
      this.columnRemitterGUID.ReadOnly = true;
      this.columnRemitterName.ReadOnly = true;
      this.columnAddress.ReadOnly = true;
      this.columnEffectiveDate.AllowDBNull = false;
      this.columnExpirationDate.AllowDBNull = false;
      this.columnInsuredName.ReadOnly = true;
    }

    public dsRemittanceData.OutstandingPoliciesRow NewOutstandingPoliciesRow()
    {
      return (dsRemittanceData.OutstandingPoliciesRow) this.NewRow();
    }

    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsRemittanceData.OutstandingPoliciesRow(builder);
    }

    protected override Type GetRowType() => typeof (dsRemittanceData.OutstandingPoliciesRow);

    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.OutstandingPoliciesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsRemittanceData.OutstandingPoliciesRowChangeEventHandler policiesRowChangedEvent = this.OutstandingPoliciesRowChangedEvent;
      if (policiesRowChangedEvent == null)
        return;
      policiesRowChangedEvent((object) this, new dsRemittanceData.OutstandingPoliciesRowChangeEvent((dsRemittanceData.OutstandingPoliciesRow) e.Row, e.Action));
    }

    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.OutstandingPoliciesRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsRemittanceData.OutstandingPoliciesRowChangeEventHandler rowChangingEvent = this.OutstandingPoliciesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsRemittanceData.OutstandingPoliciesRowChangeEvent((dsRemittanceData.OutstandingPoliciesRow) e.Row, e.Action));
    }

    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.OutstandingPoliciesRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsRemittanceData.OutstandingPoliciesRowChangeEventHandler policiesRowDeletedEvent = this.OutstandingPoliciesRowDeletedEvent;
      if (policiesRowDeletedEvent == null)
        return;
      policiesRowDeletedEvent((object) this, new dsRemittanceData.OutstandingPoliciesRowChangeEvent((dsRemittanceData.OutstandingPoliciesRow) e.Row, e.Action));
    }

    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.OutstandingPoliciesRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsRemittanceData.OutstandingPoliciesRowChangeEventHandler rowDeletingEvent = this.OutstandingPoliciesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsRemittanceData.OutstandingPoliciesRowChangeEvent((dsRemittanceData.OutstandingPoliciesRow) e.Row, e.Action));
    }

    public void RemoveOutstandingPoliciesRow(dsRemittanceData.OutstandingPoliciesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }
  }

  [DebuggerStepThrough]
  public class OutstandingPoliciesRow : DataRow
  {
    private dsRemittanceData.OutstandingPoliciesDataTable tableOutstandingPolicies;

    internal OutstandingPoliciesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableOutstandingPolicies = (dsRemittanceData.OutstandingPoliciesDataTable) this.Table;
    }

    public int QuoteControlNum
    {
      get => Conversions.ToInteger(this[this.tableOutstandingPolicies.QuoteControlNumColumn]);
      set => this[this.tableOutstandingPolicies.QuoteControlNumColumn] = (object) value;
    }

    public Guid RemitterGUID
    {
      get
      {
        object obj = this[this.tableOutstandingPolicies.RemitterGUIDColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tableOutstandingPolicies.RemitterGUIDColumn] = (object) value;
    }

    public string RemitterName
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableOutstandingPolicies.RemitterNameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableOutstandingPolicies.RemitterNameColumn] = (object) value;
    }

    public string Address
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableOutstandingPolicies.AddressColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableOutstandingPolicies.AddressColumn] = (object) value;
    }

    public string PolicyNumber
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableOutstandingPolicies.PolicyNumberColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableOutstandingPolicies.PolicyNumberColumn] = (object) value;
    }

    public DateTime EffectiveDate
    {
      get => Conversions.ToDate(this[this.tableOutstandingPolicies.EffectiveDateColumn]);
      set => this[this.tableOutstandingPolicies.EffectiveDateColumn] = (object) value;
    }

    public DateTime ExpirationDate
    {
      get => Conversions.ToDate(this[this.tableOutstandingPolicies.ExpirationDateColumn]);
      set => this[this.tableOutstandingPolicies.ExpirationDateColumn] = (object) value;
    }

    public string InsuredName
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableOutstandingPolicies.InsuredNameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableOutstandingPolicies.InsuredNameColumn] = (object) value;
    }

    public Decimal BalanceDue
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tableOutstandingPolicies.BalanceDueColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableOutstandingPolicies.BalanceDueColumn] = (object) value;
    }

    public Decimal OverPaidBal
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tableOutstandingPolicies.OverPaidBalColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableOutstandingPolicies.OverPaidBalColumn] = (object) value;
    }

    public bool IsRemitterNameNull()
    {
      return this.IsNull(this.tableOutstandingPolicies.RemitterNameColumn);
    }

    public void SetRemitterNameNull()
    {
      this[this.tableOutstandingPolicies.RemitterNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsAddressNull() => this.IsNull(this.tableOutstandingPolicies.AddressColumn);

    public void SetAddressNull()
    {
      this[this.tableOutstandingPolicies.AddressColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsPolicyNumberNull()
    {
      return this.IsNull(this.tableOutstandingPolicies.PolicyNumberColumn);
    }

    public void SetPolicyNumberNull()
    {
      this[this.tableOutstandingPolicies.PolicyNumberColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsInsuredNameNull() => this.IsNull(this.tableOutstandingPolicies.InsuredNameColumn);

    public void SetInsuredNameNull()
    {
      this[this.tableOutstandingPolicies.InsuredNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsBalanceDueNull() => this.IsNull(this.tableOutstandingPolicies.BalanceDueColumn);

    public void SetBalanceDueNull()
    {
      this[this.tableOutstandingPolicies.BalanceDueColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsOverPaidBalNull() => this.IsNull(this.tableOutstandingPolicies.OverPaidBalColumn);

    public void SetOverPaidBalNull()
    {
      this[this.tableOutstandingPolicies.OverPaidBalColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public dsRemittanceData.OutstandingPolicyInvoicesRow[] GetOutstandingPolicyInvoicesRows()
    {
      return (dsRemittanceData.OutstandingPolicyInvoicesRow[]) this.GetChildRows(this.Table.ChildRelations["OutstandingPoliciesOutstandingPolicyInvoices"]);
    }
  }

  [DebuggerStepThrough]
  public class OutstandingPoliciesRowChangeEvent : EventArgs
  {
    private dsRemittanceData.OutstandingPoliciesRow eventRow;
    private DataRowAction eventAction;

    public OutstandingPoliciesRowChangeEvent(
      dsRemittanceData.OutstandingPoliciesRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    public dsRemittanceData.OutstandingPoliciesRow Row => this.eventRow;

    public DataRowAction Action => this.eventAction;
  }

  [DebuggerStepThrough]
  public class OutstandingPolicyInvoicesDataTable : DataTable, IEnumerable
  {
    private DataColumn columnInvoiceNum;
    private DataColumn columnRemitterGUID;
    private DataColumn columnQuoteControlNum;
    private DataColumn columnOfficeInvoiceNum;
    private DataColumn columnGLOfficeId;
    private DataColumn columnGLOfficeLocation;
    private DataColumn columnInvoiceDate;
    private DataColumn columnDueDate;
    private DataColumn columnGrossPremium;
    private DataColumn columnFees;
    private DataColumn columnRemitterDeduction;
    private DataColumn columnNetBilled;
    private DataColumn columnAmtPTD;
    private DataColumn columnOverPaidBal;

    internal OutstandingPolicyInvoicesDataTable()
      : base("OutstandingPolicyInvoices")
    {
      this.InitClass();
    }

    internal OutstandingPolicyInvoicesDataTable(DataTable table)
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

    internal DataColumn RemitterGUIDColumn => this.columnRemitterGUID;

    internal DataColumn QuoteControlNumColumn => this.columnQuoteControlNum;

    internal DataColumn OfficeInvoiceNumColumn => this.columnOfficeInvoiceNum;

    internal DataColumn GLOfficeIdColumn => this.columnGLOfficeId;

    internal DataColumn GLOfficeLocationColumn => this.columnGLOfficeLocation;

    internal DataColumn InvoiceDateColumn => this.columnInvoiceDate;

    internal DataColumn DueDateColumn => this.columnDueDate;

    internal DataColumn GrossPremiumColumn => this.columnGrossPremium;

    internal DataColumn FeesColumn => this.columnFees;

    internal DataColumn RemitterDeductionColumn => this.columnRemitterDeduction;

    internal DataColumn NetBilledColumn => this.columnNetBilled;

    internal DataColumn AmtPTDColumn => this.columnAmtPTD;

    internal DataColumn OverPaidBalColumn => this.columnOverPaidBal;

    public dsRemittanceData.OutstandingPolicyInvoicesRow this[int index]
    {
      get => (dsRemittanceData.OutstandingPolicyInvoicesRow) this.Rows[index];
    }

    public event dsRemittanceData.OutstandingPolicyInvoicesRowChangeEventHandler OutstandingPolicyInvoicesRowChanged;

    public event dsRemittanceData.OutstandingPolicyInvoicesRowChangeEventHandler OutstandingPolicyInvoicesRowChanging;

    public event dsRemittanceData.OutstandingPolicyInvoicesRowChangeEventHandler OutstandingPolicyInvoicesRowDeleted;

    public event dsRemittanceData.OutstandingPolicyInvoicesRowChangeEventHandler OutstandingPolicyInvoicesRowDeleting;

    public void AddOutstandingPolicyInvoicesRow(dsRemittanceData.OutstandingPolicyInvoicesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    public dsRemittanceData.OutstandingPolicyInvoicesRow AddOutstandingPolicyInvoicesRow(
      Guid RemitterGUID,
      int QuoteControlNum,
      int OfficeInvoiceNum,
      int GLOfficeId,
      string GLOfficeLocation,
      DateTime InvoiceDate,
      DateTime DueDate,
      Decimal GrossPremium,
      Decimal Fees,
      Decimal RemitterDeduction,
      Decimal NetBilled,
      Decimal AmtPTD,
      Decimal OverPaidBal)
    {
      dsRemittanceData.OutstandingPolicyInvoicesRow row = (dsRemittanceData.OutstandingPolicyInvoicesRow) this.NewRow();
      row.ItemArray = new object[14]
      {
        null,
        (object) RemitterGUID,
        (object) QuoteControlNum,
        (object) OfficeInvoiceNum,
        (object) GLOfficeId,
        (object) GLOfficeLocation,
        (object) InvoiceDate,
        (object) DueDate,
        (object) GrossPremium,
        (object) Fees,
        (object) RemitterDeduction,
        (object) NetBilled,
        (object) AmtPTD,
        (object) OverPaidBal
      };
      this.Rows.Add((DataRow) row);
      return row;
    }

    public IEnumerator GetEnumerator() => this.Rows.GetEnumerator();

    public override DataTable Clone()
    {
      dsRemittanceData.OutstandingPolicyInvoicesDataTable invoicesDataTable = (dsRemittanceData.OutstandingPolicyInvoicesDataTable) base.Clone();
      invoicesDataTable.InitVars();
      return (DataTable) invoicesDataTable;
    }

    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsRemittanceData.OutstandingPolicyInvoicesDataTable();
    }

    internal void InitVars()
    {
      this.columnInvoiceNum = this.Columns["InvoiceNum"];
      this.columnRemitterGUID = this.Columns["RemitterGUID"];
      this.columnQuoteControlNum = this.Columns["QuoteControlNum"];
      this.columnOfficeInvoiceNum = this.Columns["OfficeInvoiceNum"];
      this.columnGLOfficeId = this.Columns["GLOfficeId"];
      this.columnGLOfficeLocation = this.Columns["GLOfficeLocation"];
      this.columnInvoiceDate = this.Columns["InvoiceDate"];
      this.columnDueDate = this.Columns["DueDate"];
      this.columnGrossPremium = this.Columns["GrossPremium"];
      this.columnFees = this.Columns["Fees"];
      this.columnRemitterDeduction = this.Columns["RemitterDeduction"];
      this.columnNetBilled = this.Columns["NetBilled"];
      this.columnAmtPTD = this.Columns["AmtPTD"];
      this.columnOverPaidBal = this.Columns["OverPaidBal"];
    }

    private void InitClass()
    {
      this.columnInvoiceNum = new DataColumn("InvoiceNum", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInvoiceNum);
      this.columnRemitterGUID = new DataColumn("RemitterGUID", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnRemitterGUID);
      this.columnQuoteControlNum = new DataColumn("QuoteControlNum", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnQuoteControlNum);
      this.columnOfficeInvoiceNum = new DataColumn("OfficeInvoiceNum", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnOfficeInvoiceNum);
      this.columnGLOfficeId = new DataColumn("GLOfficeId", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnGLOfficeId);
      this.columnGLOfficeLocation = new DataColumn("GLOfficeLocation", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnGLOfficeLocation);
      this.columnInvoiceDate = new DataColumn("InvoiceDate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInvoiceDate);
      this.columnDueDate = new DataColumn("DueDate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDueDate);
      this.columnGrossPremium = new DataColumn("GrossPremium", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnGrossPremium);
      this.columnFees = new DataColumn("Fees", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFees);
      this.columnRemitterDeduction = new DataColumn("RemitterDeduction", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnRemitterDeduction);
      this.columnNetBilled = new DataColumn("NetBilled", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnNetBilled);
      this.columnAmtPTD = new DataColumn("AmtPTD", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAmtPTD);
      this.columnOverPaidBal = new DataColumn("OverPaidBal", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnOverPaidBal);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnInvoiceNum
      }, false));
      this.columnInvoiceNum.AutoIncrement = true;
      this.columnInvoiceNum.AllowDBNull = false;
      this.columnInvoiceNum.ReadOnly = true;
      this.columnInvoiceNum.Unique = true;
      this.columnRemitterGUID.ReadOnly = true;
      this.columnQuoteControlNum.AllowDBNull = false;
      this.columnOfficeInvoiceNum.ReadOnly = true;
      this.columnGLOfficeId.ReadOnly = true;
      this.columnGLOfficeLocation.ReadOnly = true;
      this.columnInvoiceDate.ReadOnly = true;
      this.columnDueDate.ReadOnly = true;
      this.columnGrossPremium.ReadOnly = true;
      this.columnFees.ReadOnly = true;
      this.columnRemitterDeduction.ReadOnly = true;
      this.columnNetBilled.ReadOnly = true;
      this.columnAmtPTD.ReadOnly = true;
    }

    public dsRemittanceData.OutstandingPolicyInvoicesRow NewOutstandingPolicyInvoicesRow()
    {
      return (dsRemittanceData.OutstandingPolicyInvoicesRow) this.NewRow();
    }

    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsRemittanceData.OutstandingPolicyInvoicesRow(builder);
    }

    protected override Type GetRowType() => typeof (dsRemittanceData.OutstandingPolicyInvoicesRow);

    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.OutstandingPolicyInvoicesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsRemittanceData.OutstandingPolicyInvoicesRowChangeEventHandler invoicesRowChangedEvent = this.OutstandingPolicyInvoicesRowChangedEvent;
      if (invoicesRowChangedEvent == null)
        return;
      invoicesRowChangedEvent((object) this, new dsRemittanceData.OutstandingPolicyInvoicesRowChangeEvent((dsRemittanceData.OutstandingPolicyInvoicesRow) e.Row, e.Action));
    }

    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.OutstandingPolicyInvoicesRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsRemittanceData.OutstandingPolicyInvoicesRowChangeEventHandler rowChangingEvent = this.OutstandingPolicyInvoicesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsRemittanceData.OutstandingPolicyInvoicesRowChangeEvent((dsRemittanceData.OutstandingPolicyInvoicesRow) e.Row, e.Action));
    }

    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.OutstandingPolicyInvoicesRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsRemittanceData.OutstandingPolicyInvoicesRowChangeEventHandler invoicesRowDeletedEvent = this.OutstandingPolicyInvoicesRowDeletedEvent;
      if (invoicesRowDeletedEvent == null)
        return;
      invoicesRowDeletedEvent((object) this, new dsRemittanceData.OutstandingPolicyInvoicesRowChangeEvent((dsRemittanceData.OutstandingPolicyInvoicesRow) e.Row, e.Action));
    }

    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.OutstandingPolicyInvoicesRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsRemittanceData.OutstandingPolicyInvoicesRowChangeEventHandler rowDeletingEvent = this.OutstandingPolicyInvoicesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsRemittanceData.OutstandingPolicyInvoicesRowChangeEvent((dsRemittanceData.OutstandingPolicyInvoicesRow) e.Row, e.Action));
    }

    public void RemoveOutstandingPolicyInvoicesRow(dsRemittanceData.OutstandingPolicyInvoicesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }
  }

  [DebuggerStepThrough]
  public class OutstandingPolicyInvoicesRow : DataRow
  {
    private dsRemittanceData.OutstandingPolicyInvoicesDataTable tableOutstandingPolicyInvoices;

    internal OutstandingPolicyInvoicesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableOutstandingPolicyInvoices = (dsRemittanceData.OutstandingPolicyInvoicesDataTable) this.Table;
    }

    public int InvoiceNum
    {
      get => Conversions.ToInteger(this[this.tableOutstandingPolicyInvoices.InvoiceNumColumn]);
      set => this[this.tableOutstandingPolicyInvoices.InvoiceNumColumn] = (object) value;
    }

    public Guid RemitterGUID
    {
      get
      {
        try
        {
          object obj = this[this.tableOutstandingPolicyInvoices.RemitterGUIDColumn];
          return obj != null ? (Guid) obj : new Guid();
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableOutstandingPolicyInvoices.RemitterGUIDColumn] = (object) value;
    }

    public int QuoteControlNum
    {
      get => Conversions.ToInteger(this[this.tableOutstandingPolicyInvoices.QuoteControlNumColumn]);
      set => this[this.tableOutstandingPolicyInvoices.QuoteControlNumColumn] = (object) value;
    }

    public int OfficeInvoiceNum
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tableOutstandingPolicyInvoices.OfficeInvoiceNumColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableOutstandingPolicyInvoices.OfficeInvoiceNumColumn] = (object) value;
    }

    public int GLOfficeId
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tableOutstandingPolicyInvoices.GLOfficeIdColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableOutstandingPolicyInvoices.GLOfficeIdColumn] = (object) value;
    }

    public string GLOfficeLocation
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableOutstandingPolicyInvoices.GLOfficeLocationColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableOutstandingPolicyInvoices.GLOfficeLocationColumn] = (object) value;
    }

    public DateTime InvoiceDate
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tableOutstandingPolicyInvoices.InvoiceDateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableOutstandingPolicyInvoices.InvoiceDateColumn] = (object) value;
    }

    public DateTime DueDate
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tableOutstandingPolicyInvoices.DueDateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableOutstandingPolicyInvoices.DueDateColumn] = (object) value;
    }

    public Decimal GrossPremium
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tableOutstandingPolicyInvoices.GrossPremiumColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableOutstandingPolicyInvoices.GrossPremiumColumn] = (object) value;
    }

    public Decimal Fees
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tableOutstandingPolicyInvoices.FeesColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableOutstandingPolicyInvoices.FeesColumn] = (object) value;
    }

    public Decimal RemitterDeduction
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tableOutstandingPolicyInvoices.RemitterDeductionColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableOutstandingPolicyInvoices.RemitterDeductionColumn] = (object) value;
    }

    public Decimal NetBilled
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tableOutstandingPolicyInvoices.NetBilledColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableOutstandingPolicyInvoices.NetBilledColumn] = (object) value;
    }

    public Decimal AmtPTD
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tableOutstandingPolicyInvoices.AmtPTDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableOutstandingPolicyInvoices.AmtPTDColumn] = (object) value;
    }

    public Decimal OverPaidBal
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tableOutstandingPolicyInvoices.OverPaidBalColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableOutstandingPolicyInvoices.OverPaidBalColumn] = (object) value;
    }

    public dsRemittanceData.OutstandingPoliciesRow OutstandingPoliciesRowParent
    {
      get
      {
        return (dsRemittanceData.OutstandingPoliciesRow) this.GetParentRow(this.Table.ParentRelations["OutstandingPoliciesOutstandingPolicyInvoices"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["OutstandingPoliciesOutstandingPolicyInvoices"]);
      }
    }

    public bool IsRemitterGUIDNull()
    {
      return this.IsNull(this.tableOutstandingPolicyInvoices.RemitterGUIDColumn);
    }

    public void SetRemitterGUIDNull()
    {
      this[this.tableOutstandingPolicyInvoices.RemitterGUIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsOfficeInvoiceNumNull()
    {
      return this.IsNull(this.tableOutstandingPolicyInvoices.OfficeInvoiceNumColumn);
    }

    public void SetOfficeInvoiceNumNull()
    {
      this[this.tableOutstandingPolicyInvoices.OfficeInvoiceNumColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsGLOfficeIdNull()
    {
      return this.IsNull(this.tableOutstandingPolicyInvoices.GLOfficeIdColumn);
    }

    public void SetGLOfficeIdNull()
    {
      this[this.tableOutstandingPolicyInvoices.GLOfficeIdColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsGLOfficeLocationNull()
    {
      return this.IsNull(this.tableOutstandingPolicyInvoices.GLOfficeLocationColumn);
    }

    public void SetGLOfficeLocationNull()
    {
      this[this.tableOutstandingPolicyInvoices.GLOfficeLocationColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsInvoiceDateNull()
    {
      return this.IsNull(this.tableOutstandingPolicyInvoices.InvoiceDateColumn);
    }

    public void SetInvoiceDateNull()
    {
      this[this.tableOutstandingPolicyInvoices.InvoiceDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsDueDateNull() => this.IsNull(this.tableOutstandingPolicyInvoices.DueDateColumn);

    public void SetDueDateNull()
    {
      this[this.tableOutstandingPolicyInvoices.DueDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsGrossPremiumNull()
    {
      return this.IsNull(this.tableOutstandingPolicyInvoices.GrossPremiumColumn);
    }

    public void SetGrossPremiumNull()
    {
      this[this.tableOutstandingPolicyInvoices.GrossPremiumColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsFeesNull() => this.IsNull(this.tableOutstandingPolicyInvoices.FeesColumn);

    public void SetFeesNull()
    {
      this[this.tableOutstandingPolicyInvoices.FeesColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsRemitterDeductionNull()
    {
      return this.IsNull(this.tableOutstandingPolicyInvoices.RemitterDeductionColumn);
    }

    public void SetRemitterDeductionNull()
    {
      this[this.tableOutstandingPolicyInvoices.RemitterDeductionColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsNetBilledNull()
    {
      return this.IsNull(this.tableOutstandingPolicyInvoices.NetBilledColumn);
    }

    public void SetNetBilledNull()
    {
      this[this.tableOutstandingPolicyInvoices.NetBilledColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsAmtPTDNull() => this.IsNull(this.tableOutstandingPolicyInvoices.AmtPTDColumn);

    public void SetAmtPTDNull()
    {
      this[this.tableOutstandingPolicyInvoices.AmtPTDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsOverPaidBalNull()
    {
      return this.IsNull(this.tableOutstandingPolicyInvoices.OverPaidBalColumn);
    }

    public void SetOverPaidBalNull()
    {
      this[this.tableOutstandingPolicyInvoices.OverPaidBalColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public dsRemittanceData.OutstandingInvoiceDetailsRow[] GetOutstandingInvoiceDetailsRows()
    {
      return (dsRemittanceData.OutstandingInvoiceDetailsRow[]) this.GetChildRows(this.Table.ChildRelations["OutstandingPolicyInvoicesOutstandingInvoiceDetails"]);
    }
  }

  [DebuggerStepThrough]
  public class OutstandingPolicyInvoicesRowChangeEvent : EventArgs
  {
    private dsRemittanceData.OutstandingPolicyInvoicesRow eventRow;
    private DataRowAction eventAction;

    public OutstandingPolicyInvoicesRowChangeEvent(
      dsRemittanceData.OutstandingPolicyInvoicesRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    public dsRemittanceData.OutstandingPolicyInvoicesRow Row => this.eventRow;

    public DataRowAction Action => this.eventAction;
  }

  [DebuggerStepThrough]
  public class OutstandingInvoiceDetailsDataTable : DataTable, IEnumerable
  {
    private DataColumn columnInvoiceNum;
    private DataColumn columnCompanyLineGUID;
    private DataColumn columnChargeCode;
    private DataColumn columnChargeName;
    private DataColumn columnNetBilled;
    private DataColumn columnAmtPTD;
    private DataColumn columnNetDue;
    private DataColumn columnSurplusBal;
    private DataColumn columnExchangeBal;
    private DataColumn columnAmtPTC;

    internal OutstandingInvoiceDetailsDataTable()
      : base("OutstandingInvoiceDetails")
    {
      this.InitClass();
    }

    internal OutstandingInvoiceDetailsDataTable(DataTable table)
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

    internal DataColumn CompanyLineGUIDColumn => this.columnCompanyLineGUID;

    internal DataColumn ChargeCodeColumn => this.columnChargeCode;

    internal DataColumn ChargeNameColumn => this.columnChargeName;

    internal DataColumn NetBilledColumn => this.columnNetBilled;

    internal DataColumn AmtPTDColumn => this.columnAmtPTD;

    internal DataColumn NetDueColumn => this.columnNetDue;

    internal DataColumn SurplusBalColumn => this.columnSurplusBal;

    internal DataColumn ExchangeBalColumn => this.columnExchangeBal;

    internal DataColumn AmtPTCColumn => this.columnAmtPTC;

    public dsRemittanceData.OutstandingInvoiceDetailsRow this[int index]
    {
      get => (dsRemittanceData.OutstandingInvoiceDetailsRow) this.Rows[index];
    }

    public event dsRemittanceData.OutstandingInvoiceDetailsRowChangeEventHandler OutstandingInvoiceDetailsRowChanged;

    public event dsRemittanceData.OutstandingInvoiceDetailsRowChangeEventHandler OutstandingInvoiceDetailsRowChanging;

    public event dsRemittanceData.OutstandingInvoiceDetailsRowChangeEventHandler OutstandingInvoiceDetailsRowDeleted;

    public event dsRemittanceData.OutstandingInvoiceDetailsRowChangeEventHandler OutstandingInvoiceDetailsRowDeleting;

    public void AddOutstandingInvoiceDetailsRow(dsRemittanceData.OutstandingInvoiceDetailsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    public dsRemittanceData.OutstandingInvoiceDetailsRow AddOutstandingInvoiceDetailsRow(
      dsRemittanceData.OutstandingPolicyInvoicesRow parentOutstandingPolicyInvoicesRowByOutstandingPolicyInvoicesOutstandingInvoiceDetails,
      Guid CompanyLineGUID,
      int ChargeCode,
      string ChargeName,
      Decimal NetBilled,
      Decimal AmtPTD,
      Decimal NetDue,
      Decimal SurplusBal,
      Decimal ExchangeBal,
      Decimal AmtPTC)
    {
      dsRemittanceData.OutstandingInvoiceDetailsRow row = (dsRemittanceData.OutstandingInvoiceDetailsRow) this.NewRow();
      row.ItemArray = new object[10]
      {
        parentOutstandingPolicyInvoicesRowByOutstandingPolicyInvoicesOutstandingInvoiceDetails[0],
        (object) CompanyLineGUID,
        (object) ChargeCode,
        (object) ChargeName,
        (object) NetBilled,
        (object) AmtPTD,
        (object) NetDue,
        (object) SurplusBal,
        (object) ExchangeBal,
        (object) AmtPTC
      };
      this.Rows.Add((DataRow) row);
      return row;
    }

    public dsRemittanceData.OutstandingInvoiceDetailsRow FindByInvoiceNumCompanyLineGUIDChargeCode(
      int InvoiceNum,
      Guid CompanyLineGUID,
      int ChargeCode)
    {
      return (dsRemittanceData.OutstandingInvoiceDetailsRow) this.Rows.Find(new object[3]
      {
        (object) InvoiceNum,
        (object) CompanyLineGUID,
        (object) ChargeCode
      });
    }

    public IEnumerator GetEnumerator() => this.Rows.GetEnumerator();

    public override DataTable Clone()
    {
      dsRemittanceData.OutstandingInvoiceDetailsDataTable detailsDataTable = (dsRemittanceData.OutstandingInvoiceDetailsDataTable) base.Clone();
      detailsDataTable.InitVars();
      return (DataTable) detailsDataTable;
    }

    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsRemittanceData.OutstandingInvoiceDetailsDataTable();
    }

    internal void InitVars()
    {
      this.columnInvoiceNum = this.Columns["InvoiceNum"];
      this.columnCompanyLineGUID = this.Columns["CompanyLineGUID"];
      this.columnChargeCode = this.Columns["ChargeCode"];
      this.columnChargeName = this.Columns["ChargeName"];
      this.columnNetBilled = this.Columns["NetBilled"];
      this.columnAmtPTD = this.Columns["AmtPTD"];
      this.columnNetDue = this.Columns["NetDue"];
      this.columnSurplusBal = this.Columns["SurplusBal"];
      this.columnExchangeBal = this.Columns["ExchangeBal"];
      this.columnAmtPTC = this.Columns["AmtPTC"];
    }

    private void InitClass()
    {
      this.columnInvoiceNum = new DataColumn("InvoiceNum", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInvoiceNum);
      this.columnCompanyLineGUID = new DataColumn("CompanyLineGUID", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCompanyLineGUID);
      this.columnChargeCode = new DataColumn("ChargeCode", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnChargeCode);
      this.columnChargeName = new DataColumn("ChargeName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnChargeName);
      this.columnNetBilled = new DataColumn("NetBilled", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnNetBilled);
      this.columnAmtPTD = new DataColumn("AmtPTD", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAmtPTD);
      this.columnNetDue = new DataColumn("NetDue", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnNetDue);
      this.columnSurplusBal = new DataColumn("SurplusBal", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSurplusBal);
      this.columnExchangeBal = new DataColumn("ExchangeBal", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnExchangeBal);
      this.columnAmtPTC = new DataColumn("AmtPTC", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAmtPTC);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[3]
      {
        this.columnInvoiceNum,
        this.columnCompanyLineGUID,
        this.columnChargeCode
      }, true));
      this.columnInvoiceNum.AllowDBNull = false;
      this.columnCompanyLineGUID.AllowDBNull = false;
      this.columnChargeCode.AllowDBNull = false;
      this.columnChargeName.ReadOnly = true;
      this.columnNetBilled.ReadOnly = true;
      this.columnAmtPTD.ReadOnly = true;
      this.columnNetDue.ReadOnly = true;
    }

    public dsRemittanceData.OutstandingInvoiceDetailsRow NewOutstandingInvoiceDetailsRow()
    {
      return (dsRemittanceData.OutstandingInvoiceDetailsRow) this.NewRow();
    }

    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsRemittanceData.OutstandingInvoiceDetailsRow(builder);
    }

    protected override Type GetRowType() => typeof (dsRemittanceData.OutstandingInvoiceDetailsRow);

    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.OutstandingInvoiceDetailsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsRemittanceData.OutstandingInvoiceDetailsRowChangeEventHandler detailsRowChangedEvent = this.OutstandingInvoiceDetailsRowChangedEvent;
      if (detailsRowChangedEvent == null)
        return;
      detailsRowChangedEvent((object) this, new dsRemittanceData.OutstandingInvoiceDetailsRowChangeEvent((dsRemittanceData.OutstandingInvoiceDetailsRow) e.Row, e.Action));
    }

    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.OutstandingInvoiceDetailsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsRemittanceData.OutstandingInvoiceDetailsRowChangeEventHandler rowChangingEvent = this.OutstandingInvoiceDetailsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsRemittanceData.OutstandingInvoiceDetailsRowChangeEvent((dsRemittanceData.OutstandingInvoiceDetailsRow) e.Row, e.Action));
    }

    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.OutstandingInvoiceDetailsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsRemittanceData.OutstandingInvoiceDetailsRowChangeEventHandler detailsRowDeletedEvent = this.OutstandingInvoiceDetailsRowDeletedEvent;
      if (detailsRowDeletedEvent == null)
        return;
      detailsRowDeletedEvent((object) this, new dsRemittanceData.OutstandingInvoiceDetailsRowChangeEvent((dsRemittanceData.OutstandingInvoiceDetailsRow) e.Row, e.Action));
    }

    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.OutstandingInvoiceDetailsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsRemittanceData.OutstandingInvoiceDetailsRowChangeEventHandler rowDeletingEvent = this.OutstandingInvoiceDetailsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsRemittanceData.OutstandingInvoiceDetailsRowChangeEvent((dsRemittanceData.OutstandingInvoiceDetailsRow) e.Row, e.Action));
    }

    public void RemoveOutstandingInvoiceDetailsRow(dsRemittanceData.OutstandingInvoiceDetailsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }
  }

  [DebuggerStepThrough]
  public class OutstandingInvoiceDetailsRow : DataRow
  {
    private dsRemittanceData.OutstandingInvoiceDetailsDataTable tableOutstandingInvoiceDetails;

    internal OutstandingInvoiceDetailsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableOutstandingInvoiceDetails = (dsRemittanceData.OutstandingInvoiceDetailsDataTable) this.Table;
    }

    public int InvoiceNum
    {
      get => Conversions.ToInteger(this[this.tableOutstandingInvoiceDetails.InvoiceNumColumn]);
      set => this[this.tableOutstandingInvoiceDetails.InvoiceNumColumn] = (object) value;
    }

    public Guid CompanyLineGUID
    {
      get
      {
        object obj = this[this.tableOutstandingInvoiceDetails.CompanyLineGUIDColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tableOutstandingInvoiceDetails.CompanyLineGUIDColumn] = (object) value;
    }

    public int ChargeCode
    {
      get => Conversions.ToInteger(this[this.tableOutstandingInvoiceDetails.ChargeCodeColumn]);
      set => this[this.tableOutstandingInvoiceDetails.ChargeCodeColumn] = (object) value;
    }

    public string ChargeName
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableOutstandingInvoiceDetails.ChargeNameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableOutstandingInvoiceDetails.ChargeNameColumn] = (object) value;
    }

    public Decimal NetBilled
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tableOutstandingInvoiceDetails.NetBilledColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableOutstandingInvoiceDetails.NetBilledColumn] = (object) value;
    }

    public Decimal AmtPTD
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tableOutstandingInvoiceDetails.AmtPTDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableOutstandingInvoiceDetails.AmtPTDColumn] = (object) value;
    }

    public Decimal NetDue
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tableOutstandingInvoiceDetails.NetDueColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableOutstandingInvoiceDetails.NetDueColumn] = (object) value;
    }

    public Decimal SurplusBal
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tableOutstandingInvoiceDetails.SurplusBalColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableOutstandingInvoiceDetails.SurplusBalColumn] = (object) value;
    }

    public Decimal ExchangeBal
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tableOutstandingInvoiceDetails.ExchangeBalColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableOutstandingInvoiceDetails.ExchangeBalColumn] = (object) value;
    }

    public Decimal AmtPTC
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tableOutstandingInvoiceDetails.AmtPTCColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableOutstandingInvoiceDetails.AmtPTCColumn] = (object) value;
    }

    public dsRemittanceData.OutstandingPolicyInvoicesRow OutstandingPolicyInvoicesRow
    {
      get
      {
        return (dsRemittanceData.OutstandingPolicyInvoicesRow) this.GetParentRow(this.Table.ParentRelations["OutstandingPolicyInvoicesOutstandingInvoiceDetails"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["OutstandingPolicyInvoicesOutstandingInvoiceDetails"]);
      }
    }

    public bool IsChargeNameNull()
    {
      return this.IsNull(this.tableOutstandingInvoiceDetails.ChargeNameColumn);
    }

    public void SetChargeNameNull()
    {
      this[this.tableOutstandingInvoiceDetails.ChargeNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsNetBilledNull()
    {
      return this.IsNull(this.tableOutstandingInvoiceDetails.NetBilledColumn);
    }

    public void SetNetBilledNull()
    {
      this[this.tableOutstandingInvoiceDetails.NetBilledColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsAmtPTDNull() => this.IsNull(this.tableOutstandingInvoiceDetails.AmtPTDColumn);

    public void SetAmtPTDNull()
    {
      this[this.tableOutstandingInvoiceDetails.AmtPTDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsNetDueNull() => this.IsNull(this.tableOutstandingInvoiceDetails.NetDueColumn);

    public void SetNetDueNull()
    {
      this[this.tableOutstandingInvoiceDetails.NetDueColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsSurplusBalNull()
    {
      return this.IsNull(this.tableOutstandingInvoiceDetails.SurplusBalColumn);
    }

    public void SetSurplusBalNull()
    {
      this[this.tableOutstandingInvoiceDetails.SurplusBalColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsExchangeBalNull()
    {
      return this.IsNull(this.tableOutstandingInvoiceDetails.ExchangeBalColumn);
    }

    public void SetExchangeBalNull()
    {
      this[this.tableOutstandingInvoiceDetails.ExchangeBalColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsAmtPTCNull() => this.IsNull(this.tableOutstandingInvoiceDetails.AmtPTCColumn);

    public void SetAmtPTCNull()
    {
      this[this.tableOutstandingInvoiceDetails.AmtPTCColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  [DebuggerStepThrough]
  public class OutstandingInvoiceDetailsRowChangeEvent : EventArgs
  {
    private dsRemittanceData.OutstandingInvoiceDetailsRow eventRow;
    private DataRowAction eventAction;

    public OutstandingInvoiceDetailsRowChangeEvent(
      dsRemittanceData.OutstandingInvoiceDetailsRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    public dsRemittanceData.OutstandingInvoiceDetailsRow Row => this.eventRow;

    public DataRowAction Action => this.eventAction;
  }

  [DebuggerStepThrough]
  public class PostedHeaderDataTable : DataTable, IEnumerable
  {
    private DataColumn columnTransactNum;
    private DataColumn columnRemitterGUID;
    private DataColumn columnReceivedDate;
    private DataColumn columnDepositDate;
    private DataColumn columnCheckNumber;
    private DataColumn columnAmount;
    private DataColumn columnComments;
    private DataColumn columnRemitter;
    private DataColumn columnPostDate;
    private DataColumn columnVoided;
    private DataColumn columnPoster;

    internal PostedHeaderDataTable()
      : base("PostedHeader")
    {
      this.InitClass();
    }

    internal PostedHeaderDataTable(DataTable table)
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

    internal DataColumn TransactNumColumn => this.columnTransactNum;

    internal DataColumn RemitterGUIDColumn => this.columnRemitterGUID;

    internal DataColumn ReceivedDateColumn => this.columnReceivedDate;

    internal DataColumn DepositDateColumn => this.columnDepositDate;

    internal DataColumn CheckNumberColumn => this.columnCheckNumber;

    internal DataColumn AmountColumn => this.columnAmount;

    internal DataColumn CommentsColumn => this.columnComments;

    internal DataColumn RemitterColumn => this.columnRemitter;

    internal DataColumn PostDateColumn => this.columnPostDate;

    internal DataColumn VoidedColumn => this.columnVoided;

    internal DataColumn PosterColumn => this.columnPoster;

    public dsRemittanceData.PostedHeaderRow this[int index]
    {
      get => (dsRemittanceData.PostedHeaderRow) this.Rows[index];
    }

    public event dsRemittanceData.PostedHeaderRowChangeEventHandler PostedHeaderRowChanged;

    public event dsRemittanceData.PostedHeaderRowChangeEventHandler PostedHeaderRowChanging;

    public event dsRemittanceData.PostedHeaderRowChangeEventHandler PostedHeaderRowDeleted;

    public event dsRemittanceData.PostedHeaderRowChangeEventHandler PostedHeaderRowDeleting;

    public void AddPostedHeaderRow(dsRemittanceData.PostedHeaderRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    public dsRemittanceData.PostedHeaderRow AddPostedHeaderRow(
      int TransactNum,
      Guid RemitterGUID,
      DateTime ReceivedDate,
      DateTime DepositDate,
      string CheckNumber,
      Decimal Amount,
      string Comments,
      string Remitter,
      DateTime PostDate,
      bool Voided,
      string Poster)
    {
      dsRemittanceData.PostedHeaderRow row = (dsRemittanceData.PostedHeaderRow) this.NewRow();
      row.ItemArray = new object[11]
      {
        (object) TransactNum,
        (object) RemitterGUID,
        (object) ReceivedDate,
        (object) DepositDate,
        (object) CheckNumber,
        (object) Amount,
        (object) Comments,
        (object) Remitter,
        (object) PostDate,
        (object) Voided,
        (object) Poster
      };
      this.Rows.Add((DataRow) row);
      return row;
    }

    public IEnumerator GetEnumerator() => this.Rows.GetEnumerator();

    public override DataTable Clone()
    {
      dsRemittanceData.PostedHeaderDataTable postedHeaderDataTable = (dsRemittanceData.PostedHeaderDataTable) base.Clone();
      postedHeaderDataTable.InitVars();
      return (DataTable) postedHeaderDataTable;
    }

    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsRemittanceData.PostedHeaderDataTable();
    }

    internal void InitVars()
    {
      this.columnTransactNum = this.Columns["TransactNum"];
      this.columnRemitterGUID = this.Columns["RemitterGUID"];
      this.columnReceivedDate = this.Columns["ReceivedDate"];
      this.columnDepositDate = this.Columns["DepositDate"];
      this.columnCheckNumber = this.Columns["CheckNumber"];
      this.columnAmount = this.Columns["Amount"];
      this.columnComments = this.Columns["Comments"];
      this.columnRemitter = this.Columns["Remitter"];
      this.columnPostDate = this.Columns["PostDate"];
      this.columnVoided = this.Columns["Voided"];
      this.columnPoster = this.Columns["Poster"];
    }

    private void InitClass()
    {
      this.columnTransactNum = new DataColumn("TransactNum", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnTransactNum);
      this.columnRemitterGUID = new DataColumn("RemitterGUID", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnRemitterGUID);
      this.columnReceivedDate = new DataColumn("ReceivedDate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnReceivedDate);
      this.columnDepositDate = new DataColumn("DepositDate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDepositDate);
      this.columnCheckNumber = new DataColumn("CheckNumber", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCheckNumber);
      this.columnAmount = new DataColumn("Amount", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAmount);
      this.columnComments = new DataColumn("Comments", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnComments);
      this.columnRemitter = new DataColumn("Remitter", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnRemitter);
      this.columnPostDate = new DataColumn("PostDate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPostDate);
      this.columnVoided = new DataColumn("Voided", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnVoided);
      this.columnPoster = new DataColumn("Poster", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPoster);
      this.Constraints.Add((Constraint) new UniqueConstraint("key1", new DataColumn[1]
      {
        this.columnTransactNum
      }, false));
      this.columnTransactNum.AllowDBNull = false;
      this.columnTransactNum.Unique = true;
      this.columnRemitterGUID.AllowDBNull = false;
      this.columnReceivedDate.AllowDBNull = false;
      this.columnDepositDate.AllowDBNull = false;
      this.columnCheckNumber.AllowDBNull = false;
      this.columnAmount.AllowDBNull = false;
      this.columnRemitter.ReadOnly = true;
      this.columnPostDate.AllowDBNull = false;
      this.columnVoided.ReadOnly = true;
      this.columnPoster.ReadOnly = true;
    }

    public dsRemittanceData.PostedHeaderRow NewPostedHeaderRow()
    {
      return (dsRemittanceData.PostedHeaderRow) this.NewRow();
    }

    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsRemittanceData.PostedHeaderRow(builder);
    }

    protected override Type GetRowType() => typeof (dsRemittanceData.PostedHeaderRow);

    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.PostedHeaderRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsRemittanceData.PostedHeaderRowChangeEventHandler headerRowChangedEvent = this.PostedHeaderRowChangedEvent;
      if (headerRowChangedEvent == null)
        return;
      headerRowChangedEvent((object) this, new dsRemittanceData.PostedHeaderRowChangeEvent((dsRemittanceData.PostedHeaderRow) e.Row, e.Action));
    }

    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.PostedHeaderRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsRemittanceData.PostedHeaderRowChangeEventHandler rowChangingEvent = this.PostedHeaderRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsRemittanceData.PostedHeaderRowChangeEvent((dsRemittanceData.PostedHeaderRow) e.Row, e.Action));
    }

    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.PostedHeaderRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsRemittanceData.PostedHeaderRowChangeEventHandler headerRowDeletedEvent = this.PostedHeaderRowDeletedEvent;
      if (headerRowDeletedEvent == null)
        return;
      headerRowDeletedEvent((object) this, new dsRemittanceData.PostedHeaderRowChangeEvent((dsRemittanceData.PostedHeaderRow) e.Row, e.Action));
    }

    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.PostedHeaderRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsRemittanceData.PostedHeaderRowChangeEventHandler rowDeletingEvent = this.PostedHeaderRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsRemittanceData.PostedHeaderRowChangeEvent((dsRemittanceData.PostedHeaderRow) e.Row, e.Action));
    }

    public void RemovePostedHeaderRow(dsRemittanceData.PostedHeaderRow row)
    {
      this.Rows.Remove((DataRow) row);
    }
  }

  [DebuggerStepThrough]
  public class PostedHeaderRow : DataRow
  {
    private dsRemittanceData.PostedHeaderDataTable tablePostedHeader;

    internal PostedHeaderRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablePostedHeader = (dsRemittanceData.PostedHeaderDataTable) this.Table;
    }

    public int TransactNum
    {
      get => Conversions.ToInteger(this[this.tablePostedHeader.TransactNumColumn]);
      set => this[this.tablePostedHeader.TransactNumColumn] = (object) value;
    }

    public Guid RemitterGUID
    {
      get
      {
        object obj = this[this.tablePostedHeader.RemitterGUIDColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tablePostedHeader.RemitterGUIDColumn] = (object) value;
    }

    public DateTime ReceivedDate
    {
      get => Conversions.ToDate(this[this.tablePostedHeader.ReceivedDateColumn]);
      set => this[this.tablePostedHeader.ReceivedDateColumn] = (object) value;
    }

    public DateTime DepositDate
    {
      get => Conversions.ToDate(this[this.tablePostedHeader.DepositDateColumn]);
      set => this[this.tablePostedHeader.DepositDateColumn] = (object) value;
    }

    public string CheckNumber
    {
      get => Conversions.ToString(this[this.tablePostedHeader.CheckNumberColumn]);
      set => this[this.tablePostedHeader.CheckNumberColumn] = (object) value;
    }

    public Decimal Amount
    {
      get => Conversions.ToDecimal(this[this.tablePostedHeader.AmountColumn]);
      set => this[this.tablePostedHeader.AmountColumn] = (object) value;
    }

    public string Comments
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablePostedHeader.CommentsColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePostedHeader.CommentsColumn] = (object) value;
    }

    public string Remitter
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablePostedHeader.RemitterColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePostedHeader.RemitterColumn] = (object) value;
    }

    public DateTime PostDate
    {
      get => Conversions.ToDate(this[this.tablePostedHeader.PostDateColumn]);
      set => this[this.tablePostedHeader.PostDateColumn] = (object) value;
    }

    public bool Voided
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tablePostedHeader.VoidedColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePostedHeader.VoidedColumn] = (object) value;
    }

    public string Poster
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablePostedHeader.PosterColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePostedHeader.PosterColumn] = (object) value;
    }

    public bool IsCommentsNull() => this.IsNull(this.tablePostedHeader.CommentsColumn);

    public void SetCommentsNull()
    {
      this[this.tablePostedHeader.CommentsColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsRemitterNull() => this.IsNull(this.tablePostedHeader.RemitterColumn);

    public void SetRemitterNull()
    {
      this[this.tablePostedHeader.RemitterColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsVoidedNull() => this.IsNull(this.tablePostedHeader.VoidedColumn);

    public void SetVoidedNull()
    {
      this[this.tablePostedHeader.VoidedColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsPosterNull() => this.IsNull(this.tablePostedHeader.PosterColumn);

    public void SetPosterNull()
    {
      this[this.tablePostedHeader.PosterColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public dsRemittanceData.PostedDetailsRow[] GetPostedDetailsRows()
    {
      return (dsRemittanceData.PostedDetailsRow[]) this.GetChildRows(this.Table.ChildRelations["PostedHeaderPostedDetails"]);
    }
  }

  [DebuggerStepThrough]
  public class PostedHeaderRowChangeEvent : EventArgs
  {
    private dsRemittanceData.PostedHeaderRow eventRow;
    private DataRowAction eventAction;

    public PostedHeaderRowChangeEvent(dsRemittanceData.PostedHeaderRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    public dsRemittanceData.PostedHeaderRow Row => this.eventRow;

    public DataRowAction Action => this.eventAction;
  }
}
