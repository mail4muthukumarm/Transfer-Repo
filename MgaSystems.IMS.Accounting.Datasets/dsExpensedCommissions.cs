// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.AccountingDatasets.dsExpensedCommissions
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
public class dsExpensedCommissions : DataSet
{
  private dsExpensedCommissions.EntityListDataTable tableEntityList;
  private dsExpensedCommissions.DetailsListDataTable tableDetailsList;

  public dsExpensedCommissions()
  {
    this.InitClass();
    CollectionChangeEventHandler changeEventHandler = new CollectionChangeEventHandler(this.SchemaChanged);
    this.Tables.CollectionChanged += changeEventHandler;
    this.Relations.CollectionChanged += changeEventHandler;
  }

  protected dsExpensedCommissions(SerializationInfo info, StreamingContext context)
  {
    string s = Conversions.ToString(info.GetValue("XmlSchema", typeof (string)));
    if (s != null)
    {
      DataSet dataSet = new DataSet();
      dataSet.ReadXmlSchema((XmlReader) new XmlTextReader((TextReader) new StringReader(s)));
      if (dataSet.Tables[nameof (EntityList)] != null)
        this.Tables.Add((DataTable) new dsExpensedCommissions.EntityListDataTable(dataSet.Tables[nameof (EntityList)]));
      if (dataSet.Tables[nameof (DetailsList)] != null)
        this.Tables.Add((DataTable) new dsExpensedCommissions.DetailsListDataTable(dataSet.Tables[nameof (DetailsList)]));
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
  public dsExpensedCommissions.EntityListDataTable EntityList => this.tableEntityList;

  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsExpensedCommissions.DetailsListDataTable DetailsList => this.tableDetailsList;

  public override DataSet Clone()
  {
    dsExpensedCommissions expensedCommissions = (dsExpensedCommissions) base.Clone();
    expensedCommissions.InitVars();
    return (DataSet) expensedCommissions;
  }

  protected override bool ShouldSerializeTables() => false;

  protected override bool ShouldSerializeRelations() => false;

  protected override void ReadXmlSerializable(XmlReader reader)
  {
    this.Reset();
    DataSet dataSet = new DataSet();
    int num = (int) dataSet.ReadXml(reader);
    if (dataSet.Tables["EntityList"] != null)
      this.Tables.Add((DataTable) new dsExpensedCommissions.EntityListDataTable(dataSet.Tables["EntityList"]));
    if (dataSet.Tables["DetailsList"] != null)
      this.Tables.Add((DataTable) new dsExpensedCommissions.DetailsListDataTable(dataSet.Tables["DetailsList"]));
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
    this.tableEntityList = (dsExpensedCommissions.EntityListDataTable) this.Tables["EntityList"];
    if (this.tableEntityList != null)
      this.tableEntityList.InitVars();
    this.tableDetailsList = (dsExpensedCommissions.DetailsListDataTable) this.Tables["DetailsList"];
    if (this.tableDetailsList == null)
      return;
    this.tableDetailsList.InitVars();
  }

  private void InitClass()
  {
    this.DataSetName = nameof (dsExpensedCommissions);
    this.Prefix = "";
    this.Namespace = "http://tempuri.org/dsExpensedCommissions.xsd";
    this.Locale = new CultureInfo("en-US");
    this.CaseSensitive = false;
    this.EnforceConstraints = true;
    this.tableEntityList = new dsExpensedCommissions.EntityListDataTable();
    this.Tables.Add((DataTable) this.tableEntityList);
    this.tableDetailsList = new dsExpensedCommissions.DetailsListDataTable();
    this.Tables.Add((DataTable) this.tableDetailsList);
  }

  private bool ShouldSerializeEntityList() => false;

  private bool ShouldSerializeDetailsList() => false;

  private void SchemaChanged(object sender, CollectionChangeEventArgs e)
  {
    if (e.Action != CollectionChangeAction.Remove)
      return;
    this.InitVars();
  }

  public delegate void EntityListRowChangeEventHandler(
    object sender,
    dsExpensedCommissions.EntityListRowChangeEvent e);

  public delegate void DetailsListRowChangeEventHandler(
    object sender,
    dsExpensedCommissions.DetailsListRowChangeEvent e);

  [DebuggerStepThrough]
  public class EntityListDataTable : DataTable, IEnumerable
  {
    private DataColumn columnpayeeGuid;
    private DataColumn columnPayeeName;
    private DataColumn columnBalance;

    internal EntityListDataTable()
      : base("EntityList")
    {
      this.InitClass();
    }

    internal EntityListDataTable(DataTable table)
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

    internal DataColumn payeeGuidColumn => this.columnpayeeGuid;

    internal DataColumn PayeeNameColumn => this.columnPayeeName;

    internal DataColumn BalanceColumn => this.columnBalance;

    public dsExpensedCommissions.EntityListRow this[int index]
    {
      get => (dsExpensedCommissions.EntityListRow) this.Rows[index];
    }

    public event dsExpensedCommissions.EntityListRowChangeEventHandler EntityListRowChanged;

    public event dsExpensedCommissions.EntityListRowChangeEventHandler EntityListRowChanging;

    public event dsExpensedCommissions.EntityListRowChangeEventHandler EntityListRowDeleted;

    public event dsExpensedCommissions.EntityListRowChangeEventHandler EntityListRowDeleting;

    public void AddEntityListRow(dsExpensedCommissions.EntityListRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    public dsExpensedCommissions.EntityListRow AddEntityListRow(
      string payeeGuid,
      string PayeeName,
      Decimal Balance)
    {
      dsExpensedCommissions.EntityListRow row = (dsExpensedCommissions.EntityListRow) this.NewRow();
      row.ItemArray = new object[3]
      {
        (object) payeeGuid,
        (object) PayeeName,
        (object) Balance
      };
      this.Rows.Add((DataRow) row);
      return row;
    }

    public IEnumerator GetEnumerator() => this.Rows.GetEnumerator();

    public override DataTable Clone()
    {
      dsExpensedCommissions.EntityListDataTable entityListDataTable = (dsExpensedCommissions.EntityListDataTable) base.Clone();
      entityListDataTable.InitVars();
      return (DataTable) entityListDataTable;
    }

    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsExpensedCommissions.EntityListDataTable();
    }

    internal void InitVars()
    {
      this.columnpayeeGuid = this.Columns["payeeGuid"];
      this.columnPayeeName = this.Columns["PayeeName"];
      this.columnBalance = this.Columns["Balance"];
    }

    private void InitClass()
    {
      this.columnpayeeGuid = new DataColumn("payeeGuid", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnpayeeGuid);
      this.columnPayeeName = new DataColumn("PayeeName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPayeeName);
      this.columnBalance = new DataColumn("Balance", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnBalance);
    }

    public dsExpensedCommissions.EntityListRow NewEntityListRow()
    {
      return (dsExpensedCommissions.EntityListRow) this.NewRow();
    }

    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsExpensedCommissions.EntityListRow(builder);
    }

    protected override Type GetRowType() => typeof (dsExpensedCommissions.EntityListRow);

    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.EntityListRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsExpensedCommissions.EntityListRowChangeEventHandler listRowChangedEvent = this.EntityListRowChangedEvent;
      if (listRowChangedEvent == null)
        return;
      listRowChangedEvent((object) this, new dsExpensedCommissions.EntityListRowChangeEvent((dsExpensedCommissions.EntityListRow) e.Row, e.Action));
    }

    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.EntityListRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsExpensedCommissions.EntityListRowChangeEventHandler rowChangingEvent = this.EntityListRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsExpensedCommissions.EntityListRowChangeEvent((dsExpensedCommissions.EntityListRow) e.Row, e.Action));
    }

    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.EntityListRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsExpensedCommissions.EntityListRowChangeEventHandler listRowDeletedEvent = this.EntityListRowDeletedEvent;
      if (listRowDeletedEvent == null)
        return;
      listRowDeletedEvent((object) this, new dsExpensedCommissions.EntityListRowChangeEvent((dsExpensedCommissions.EntityListRow) e.Row, e.Action));
    }

    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.EntityListRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsExpensedCommissions.EntityListRowChangeEventHandler rowDeletingEvent = this.EntityListRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsExpensedCommissions.EntityListRowChangeEvent((dsExpensedCommissions.EntityListRow) e.Row, e.Action));
    }

    public void RemoveEntityListRow(dsExpensedCommissions.EntityListRow row)
    {
      this.Rows.Remove((DataRow) row);
    }
  }

  [DebuggerStepThrough]
  public class EntityListRow : DataRow
  {
    private dsExpensedCommissions.EntityListDataTable tableEntityList;

    internal EntityListRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableEntityList = (dsExpensedCommissions.EntityListDataTable) this.Table;
    }

    public string payeeGuid
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableEntityList.payeeGuidColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableEntityList.payeeGuidColumn] = (object) value;
    }

    public string PayeeName
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableEntityList.PayeeNameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableEntityList.PayeeNameColumn] = (object) value;
    }

    public Decimal Balance
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tableEntityList.BalanceColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableEntityList.BalanceColumn] = (object) value;
    }

    public bool IspayeeGuidNull() => this.IsNull(this.tableEntityList.payeeGuidColumn);

    public void SetpayeeGuidNull()
    {
      this[this.tableEntityList.payeeGuidColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsPayeeNameNull() => this.IsNull(this.tableEntityList.PayeeNameColumn);

    public void SetPayeeNameNull()
    {
      this[this.tableEntityList.PayeeNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsBalanceNull() => this.IsNull(this.tableEntityList.BalanceColumn);

    public void SetBalanceNull()
    {
      this[this.tableEntityList.BalanceColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  [DebuggerStepThrough]
  public class EntityListRowChangeEvent : EventArgs
  {
    private dsExpensedCommissions.EntityListRow eventRow;
    private DataRowAction eventAction;

    public EntityListRowChangeEvent(dsExpensedCommissions.EntityListRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    public dsExpensedCommissions.EntityListRow Row => this.eventRow;

    public DataRowAction Action => this.eventAction;
  }

  [DebuggerStepThrough]
  public class DetailsListDataTable : DataTable, IEnumerable
  {
    private DataColumn columnpayeeGuid;
    private DataColumn columnPolicyNumber;
    private DataColumn columnInsuredPolicyName;
    private DataColumn columnOfficeInvoiceNum;
    private DataColumn columninvoicenum;
    private DataColumn columnchargeCode;
    private DataColumn columncompanyLineGuid;
    private DataColumn columnAmountDue;

    internal DetailsListDataTable()
      : base("DetailsList")
    {
      this.InitClass();
    }

    internal DetailsListDataTable(DataTable table)
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

    internal DataColumn payeeGuidColumn => this.columnpayeeGuid;

    internal DataColumn PolicyNumberColumn => this.columnPolicyNumber;

    internal DataColumn InsuredPolicyNameColumn => this.columnInsuredPolicyName;

    internal DataColumn OfficeInvoiceNumColumn => this.columnOfficeInvoiceNum;

    internal DataColumn invoicenumColumn => this.columninvoicenum;

    internal DataColumn chargeCodeColumn => this.columnchargeCode;

    internal DataColumn companyLineGuidColumn => this.columncompanyLineGuid;

    internal DataColumn AmountDueColumn => this.columnAmountDue;

    public dsExpensedCommissions.DetailsListRow this[int index]
    {
      get => (dsExpensedCommissions.DetailsListRow) this.Rows[index];
    }

    public event dsExpensedCommissions.DetailsListRowChangeEventHandler DetailsListRowChanged;

    public event dsExpensedCommissions.DetailsListRowChangeEventHandler DetailsListRowChanging;

    public event dsExpensedCommissions.DetailsListRowChangeEventHandler DetailsListRowDeleted;

    public event dsExpensedCommissions.DetailsListRowChangeEventHandler DetailsListRowDeleting;

    public void AddDetailsListRow(dsExpensedCommissions.DetailsListRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    public dsExpensedCommissions.DetailsListRow AddDetailsListRow(
      string payeeGuid,
      string PolicyNumber,
      string InsuredPolicyName,
      string OfficeInvoiceNum,
      int invoicenum,
      int chargeCode,
      string companyLineGuid,
      Decimal AmountDue)
    {
      dsExpensedCommissions.DetailsListRow row = (dsExpensedCommissions.DetailsListRow) this.NewRow();
      row.ItemArray = new object[8]
      {
        (object) payeeGuid,
        (object) PolicyNumber,
        (object) InsuredPolicyName,
        (object) OfficeInvoiceNum,
        (object) invoicenum,
        (object) chargeCode,
        (object) companyLineGuid,
        (object) AmountDue
      };
      this.Rows.Add((DataRow) row);
      return row;
    }

    public IEnumerator GetEnumerator() => this.Rows.GetEnumerator();

    public override DataTable Clone()
    {
      dsExpensedCommissions.DetailsListDataTable detailsListDataTable = (dsExpensedCommissions.DetailsListDataTable) base.Clone();
      detailsListDataTable.InitVars();
      return (DataTable) detailsListDataTable;
    }

    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsExpensedCommissions.DetailsListDataTable();
    }

    internal void InitVars()
    {
      this.columnpayeeGuid = this.Columns["payeeGuid"];
      this.columnPolicyNumber = this.Columns["PolicyNumber"];
      this.columnInsuredPolicyName = this.Columns["InsuredPolicyName"];
      this.columnOfficeInvoiceNum = this.Columns["OfficeInvoiceNum"];
      this.columninvoicenum = this.Columns["invoicenum"];
      this.columnchargeCode = this.Columns["chargeCode"];
      this.columncompanyLineGuid = this.Columns["companyLineGuid"];
      this.columnAmountDue = this.Columns["AmountDue"];
    }

    private void InitClass()
    {
      this.columnpayeeGuid = new DataColumn("payeeGuid", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnpayeeGuid);
      this.columnPolicyNumber = new DataColumn("PolicyNumber", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPolicyNumber);
      this.columnInsuredPolicyName = new DataColumn("InsuredPolicyName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInsuredPolicyName);
      this.columnOfficeInvoiceNum = new DataColumn("OfficeInvoiceNum", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnOfficeInvoiceNum);
      this.columninvoicenum = new DataColumn("invoicenum", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columninvoicenum);
      this.columnchargeCode = new DataColumn("chargeCode", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnchargeCode);
      this.columncompanyLineGuid = new DataColumn("companyLineGuid", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columncompanyLineGuid);
      this.columnAmountDue = new DataColumn("AmountDue", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAmountDue);
    }

    public dsExpensedCommissions.DetailsListRow NewDetailsListRow()
    {
      return (dsExpensedCommissions.DetailsListRow) this.NewRow();
    }

    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsExpensedCommissions.DetailsListRow(builder);
    }

    protected override Type GetRowType() => typeof (dsExpensedCommissions.DetailsListRow);

    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.DetailsListRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsExpensedCommissions.DetailsListRowChangeEventHandler listRowChangedEvent = this.DetailsListRowChangedEvent;
      if (listRowChangedEvent == null)
        return;
      listRowChangedEvent((object) this, new dsExpensedCommissions.DetailsListRowChangeEvent((dsExpensedCommissions.DetailsListRow) e.Row, e.Action));
    }

    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.DetailsListRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsExpensedCommissions.DetailsListRowChangeEventHandler rowChangingEvent = this.DetailsListRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsExpensedCommissions.DetailsListRowChangeEvent((dsExpensedCommissions.DetailsListRow) e.Row, e.Action));
    }

    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.DetailsListRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsExpensedCommissions.DetailsListRowChangeEventHandler listRowDeletedEvent = this.DetailsListRowDeletedEvent;
      if (listRowDeletedEvent == null)
        return;
      listRowDeletedEvent((object) this, new dsExpensedCommissions.DetailsListRowChangeEvent((dsExpensedCommissions.DetailsListRow) e.Row, e.Action));
    }

    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.DetailsListRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsExpensedCommissions.DetailsListRowChangeEventHandler rowDeletingEvent = this.DetailsListRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsExpensedCommissions.DetailsListRowChangeEvent((dsExpensedCommissions.DetailsListRow) e.Row, e.Action));
    }

    public void RemoveDetailsListRow(dsExpensedCommissions.DetailsListRow row)
    {
      this.Rows.Remove((DataRow) row);
    }
  }

  [DebuggerStepThrough]
  public class DetailsListRow : DataRow
  {
    private dsExpensedCommissions.DetailsListDataTable tableDetailsList;

    internal DetailsListRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableDetailsList = (dsExpensedCommissions.DetailsListDataTable) this.Table;
    }

    public string payeeGuid
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableDetailsList.payeeGuidColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableDetailsList.payeeGuidColumn] = (object) value;
    }

    public string PolicyNumber
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableDetailsList.PolicyNumberColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableDetailsList.PolicyNumberColumn] = (object) value;
    }

    public string InsuredPolicyName
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableDetailsList.InsuredPolicyNameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableDetailsList.InsuredPolicyNameColumn] = (object) value;
    }

    public string OfficeInvoiceNum
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableDetailsList.OfficeInvoiceNumColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableDetailsList.OfficeInvoiceNumColumn] = (object) value;
    }

    public int invoicenum
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tableDetailsList.invoicenumColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableDetailsList.invoicenumColumn] = (object) value;
    }

    public int chargeCode
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tableDetailsList.chargeCodeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableDetailsList.chargeCodeColumn] = (object) value;
    }

    public string companyLineGuid
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableDetailsList.companyLineGuidColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableDetailsList.companyLineGuidColumn] = (object) value;
    }

    public Decimal AmountDue
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tableDetailsList.AmountDueColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableDetailsList.AmountDueColumn] = (object) value;
    }

    public bool IspayeeGuidNull() => this.IsNull(this.tableDetailsList.payeeGuidColumn);

    public void SetpayeeGuidNull()
    {
      this[this.tableDetailsList.payeeGuidColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsPolicyNumberNull() => this.IsNull(this.tableDetailsList.PolicyNumberColumn);

    public void SetPolicyNumberNull()
    {
      this[this.tableDetailsList.PolicyNumberColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsInsuredPolicyNameNull()
    {
      return this.IsNull(this.tableDetailsList.InsuredPolicyNameColumn);
    }

    public void SetInsuredPolicyNameNull()
    {
      this[this.tableDetailsList.InsuredPolicyNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsOfficeInvoiceNumNull()
    {
      return this.IsNull(this.tableDetailsList.OfficeInvoiceNumColumn);
    }

    public void SetOfficeInvoiceNumNull()
    {
      this[this.tableDetailsList.OfficeInvoiceNumColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsinvoicenumNull() => this.IsNull(this.tableDetailsList.invoicenumColumn);

    public void SetinvoicenumNull()
    {
      this[this.tableDetailsList.invoicenumColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IschargeCodeNull() => this.IsNull(this.tableDetailsList.chargeCodeColumn);

    public void SetchargeCodeNull()
    {
      this[this.tableDetailsList.chargeCodeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IscompanyLineGuidNull() => this.IsNull(this.tableDetailsList.companyLineGuidColumn);

    public void SetcompanyLineGuidNull()
    {
      this[this.tableDetailsList.companyLineGuidColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsAmountDueNull() => this.IsNull(this.tableDetailsList.AmountDueColumn);

    public void SetAmountDueNull()
    {
      this[this.tableDetailsList.AmountDueColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  [DebuggerStepThrough]
  public class DetailsListRowChangeEvent : EventArgs
  {
    private dsExpensedCommissions.DetailsListRow eventRow;
    private DataRowAction eventAction;

    public DetailsListRowChangeEvent(dsExpensedCommissions.DetailsListRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    public dsExpensedCommissions.DetailsListRow Row => this.eventRow;

    public DataRowAction Action => this.eventAction;
  }
}
