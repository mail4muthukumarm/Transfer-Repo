// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.AccountingDatasets.dsGLAcctsFinancialReports
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
public class dsGLAcctsFinancialReports : DataSet
{
  private dsGLAcctsFinancialReports.AccountListDataTable tableAccountList;

  public dsGLAcctsFinancialReports()
  {
    this.InitClass();
    CollectionChangeEventHandler changeEventHandler = new CollectionChangeEventHandler(this.SchemaChanged);
    this.Tables.CollectionChanged += changeEventHandler;
    this.Relations.CollectionChanged += changeEventHandler;
  }

  protected dsGLAcctsFinancialReports(SerializationInfo info, StreamingContext context)
  {
    string s = Conversions.ToString(info.GetValue("XmlSchema", typeof (string)));
    if (s != null)
    {
      DataSet dataSet = new DataSet();
      dataSet.ReadXmlSchema((XmlReader) new XmlTextReader((TextReader) new StringReader(s)));
      if (dataSet.Tables[nameof (AccountList)] != null)
        this.Tables.Add((DataTable) new dsGLAcctsFinancialReports.AccountListDataTable(dataSet.Tables[nameof (AccountList)]));
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
  public dsGLAcctsFinancialReports.AccountListDataTable AccountList => this.tableAccountList;

  public override DataSet Clone()
  {
    dsGLAcctsFinancialReports financialReports = (dsGLAcctsFinancialReports) base.Clone();
    financialReports.InitVars();
    return (DataSet) financialReports;
  }

  protected override bool ShouldSerializeTables() => false;

  protected override bool ShouldSerializeRelations() => false;

  protected override void ReadXmlSerializable(XmlReader reader)
  {
    this.Reset();
    DataSet dataSet = new DataSet();
    int num = (int) dataSet.ReadXml(reader);
    if (dataSet.Tables["AccountList"] != null)
      this.Tables.Add((DataTable) new dsGLAcctsFinancialReports.AccountListDataTable(dataSet.Tables["AccountList"]));
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
    this.tableAccountList = (dsGLAcctsFinancialReports.AccountListDataTable) this.Tables["AccountList"];
    if (this.tableAccountList == null)
      return;
    this.tableAccountList.InitVars();
  }

  private void InitClass()
  {
    this.DataSetName = nameof (dsGLAcctsFinancialReports);
    this.Prefix = "";
    this.Namespace = "http://tempuri.org/dsGLAcctsFinancialReports.xsd";
    this.Locale = new CultureInfo("en-US");
    this.CaseSensitive = false;
    this.EnforceConstraints = true;
    this.tableAccountList = new dsGLAcctsFinancialReports.AccountListDataTable();
    this.Tables.Add((DataTable) this.tableAccountList);
  }

  private bool ShouldSerializeAccountList() => false;

  private void SchemaChanged(object sender, CollectionChangeEventArgs e)
  {
    if (e.Action != CollectionChangeAction.Remove)
      return;
    this.InitVars();
  }

  public delegate void AccountListRowChangeEventHandler(
    object sender,
    dsGLAcctsFinancialReports.AccountListRowChangeEvent e);

  [DebuggerStepThrough]
  public class AccountListDataTable : DataTable, IEnumerable
  {
    private DataColumn columnglacctid;
    private DataColumn columnaccountclass;
    private DataColumn columnacctNumber;
    private DataColumn columnfullname;
    private DataColumn columnaccttypeid;

    internal AccountListDataTable()
      : base("AccountList")
    {
      this.InitClass();
    }

    internal AccountListDataTable(DataTable table)
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

    internal DataColumn glacctidColumn => this.columnglacctid;

    internal DataColumn accountclassColumn => this.columnaccountclass;

    internal DataColumn acctNumberColumn => this.columnacctNumber;

    internal DataColumn fullnameColumn => this.columnfullname;

    internal DataColumn accttypeidColumn => this.columnaccttypeid;

    public dsGLAcctsFinancialReports.AccountListRow this[int index]
    {
      get => (dsGLAcctsFinancialReports.AccountListRow) this.Rows[index];
    }

    public event dsGLAcctsFinancialReports.AccountListRowChangeEventHandler AccountListRowChanged;

    public event dsGLAcctsFinancialReports.AccountListRowChangeEventHandler AccountListRowChanging;

    public event dsGLAcctsFinancialReports.AccountListRowChangeEventHandler AccountListRowDeleted;

    public event dsGLAcctsFinancialReports.AccountListRowChangeEventHandler AccountListRowDeleting;

    public void AddAccountListRow(dsGLAcctsFinancialReports.AccountListRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    public dsGLAcctsFinancialReports.AccountListRow AddAccountListRow(
      int glacctid,
      string accountclass,
      string acctNumber,
      string fullname,
      int accttypeid)
    {
      dsGLAcctsFinancialReports.AccountListRow row = (dsGLAcctsFinancialReports.AccountListRow) this.NewRow();
      row.ItemArray = new object[5]
      {
        (object) glacctid,
        (object) accountclass,
        (object) acctNumber,
        (object) fullname,
        (object) accttypeid
      };
      this.Rows.Add((DataRow) row);
      return row;
    }

    public IEnumerator GetEnumerator() => this.Rows.GetEnumerator();

    public override DataTable Clone()
    {
      dsGLAcctsFinancialReports.AccountListDataTable accountListDataTable = (dsGLAcctsFinancialReports.AccountListDataTable) base.Clone();
      accountListDataTable.InitVars();
      return (DataTable) accountListDataTable;
    }

    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsGLAcctsFinancialReports.AccountListDataTable();
    }

    internal void InitVars()
    {
      this.columnglacctid = this.Columns["glacctid"];
      this.columnaccountclass = this.Columns["accountclass"];
      this.columnacctNumber = this.Columns["acctNumber"];
      this.columnfullname = this.Columns["fullname"];
      this.columnaccttypeid = this.Columns["accttypeid"];
    }

    private void InitClass()
    {
      this.columnglacctid = new DataColumn("glacctid", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnglacctid);
      this.columnaccountclass = new DataColumn("accountclass", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnaccountclass);
      this.columnacctNumber = new DataColumn("acctNumber", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnacctNumber);
      this.columnfullname = new DataColumn("fullname", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnfullname);
      this.columnaccttypeid = new DataColumn("accttypeid", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnaccttypeid);
    }

    public dsGLAcctsFinancialReports.AccountListRow NewAccountListRow()
    {
      return (dsGLAcctsFinancialReports.AccountListRow) this.NewRow();
    }

    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsGLAcctsFinancialReports.AccountListRow(builder);
    }

    protected override Type GetRowType() => typeof (dsGLAcctsFinancialReports.AccountListRow);

    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.AccountListRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsGLAcctsFinancialReports.AccountListRowChangeEventHandler listRowChangedEvent = this.AccountListRowChangedEvent;
      if (listRowChangedEvent == null)
        return;
      listRowChangedEvent((object) this, new dsGLAcctsFinancialReports.AccountListRowChangeEvent((dsGLAcctsFinancialReports.AccountListRow) e.Row, e.Action));
    }

    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.AccountListRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsGLAcctsFinancialReports.AccountListRowChangeEventHandler rowChangingEvent = this.AccountListRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsGLAcctsFinancialReports.AccountListRowChangeEvent((dsGLAcctsFinancialReports.AccountListRow) e.Row, e.Action));
    }

    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.AccountListRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsGLAcctsFinancialReports.AccountListRowChangeEventHandler listRowDeletedEvent = this.AccountListRowDeletedEvent;
      if (listRowDeletedEvent == null)
        return;
      listRowDeletedEvent((object) this, new dsGLAcctsFinancialReports.AccountListRowChangeEvent((dsGLAcctsFinancialReports.AccountListRow) e.Row, e.Action));
    }

    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.AccountListRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsGLAcctsFinancialReports.AccountListRowChangeEventHandler rowDeletingEvent = this.AccountListRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsGLAcctsFinancialReports.AccountListRowChangeEvent((dsGLAcctsFinancialReports.AccountListRow) e.Row, e.Action));
    }

    public void RemoveAccountListRow(dsGLAcctsFinancialReports.AccountListRow row)
    {
      this.Rows.Remove((DataRow) row);
    }
  }

  [DebuggerStepThrough]
  public class AccountListRow : DataRow
  {
    private dsGLAcctsFinancialReports.AccountListDataTable tableAccountList;

    internal AccountListRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableAccountList = (dsGLAcctsFinancialReports.AccountListDataTable) this.Table;
    }

    public int glacctid
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tableAccountList.glacctidColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableAccountList.glacctidColumn] = (object) value;
    }

    public string accountclass
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableAccountList.accountclassColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableAccountList.accountclassColumn] = (object) value;
    }

    public string acctNumber
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableAccountList.acctNumberColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableAccountList.acctNumberColumn] = (object) value;
    }

    public string fullname
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableAccountList.fullnameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableAccountList.fullnameColumn] = (object) value;
    }

    public int accttypeid
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tableAccountList.accttypeidColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableAccountList.accttypeidColumn] = (object) value;
    }

    public bool IsglacctidNull() => this.IsNull(this.tableAccountList.glacctidColumn);

    public void SetglacctidNull()
    {
      this[this.tableAccountList.glacctidColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsaccountclassNull() => this.IsNull(this.tableAccountList.accountclassColumn);

    public void SetaccountclassNull()
    {
      this[this.tableAccountList.accountclassColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsacctNumberNull() => this.IsNull(this.tableAccountList.acctNumberColumn);

    public void SetacctNumberNull()
    {
      this[this.tableAccountList.acctNumberColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsfullnameNull() => this.IsNull(this.tableAccountList.fullnameColumn);

    public void SetfullnameNull()
    {
      this[this.tableAccountList.fullnameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsaccttypeidNull() => this.IsNull(this.tableAccountList.accttypeidColumn);

    public void SetaccttypeidNull()
    {
      this[this.tableAccountList.accttypeidColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  [DebuggerStepThrough]
  public class AccountListRowChangeEvent : EventArgs
  {
    private dsGLAcctsFinancialReports.AccountListRow eventRow;
    private DataRowAction eventAction;

    public AccountListRowChangeEvent(
      dsGLAcctsFinancialReports.AccountListRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    public dsGLAcctsFinancialReports.AccountListRow Row => this.eventRow;

    public DataRowAction Action => this.eventAction;
  }
}
