// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.AccountingDatasets.dsGetGLAcctTypesFinancialReports
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
public class dsGetGLAcctTypesFinancialReports : DataSet
{
  private dsGetGLAcctTypesFinancialReports.AccountTypesDataTable tableAccountTypes;

  public dsGetGLAcctTypesFinancialReports()
  {
    this.InitClass();
    CollectionChangeEventHandler changeEventHandler = new CollectionChangeEventHandler(this.SchemaChanged);
    this.Tables.CollectionChanged += changeEventHandler;
    this.Relations.CollectionChanged += changeEventHandler;
  }

  protected dsGetGLAcctTypesFinancialReports(SerializationInfo info, StreamingContext context)
  {
    string s = Conversions.ToString(info.GetValue("XmlSchema", typeof (string)));
    if (s != null)
    {
      DataSet dataSet = new DataSet();
      dataSet.ReadXmlSchema((XmlReader) new XmlTextReader((TextReader) new StringReader(s)));
      if (dataSet.Tables[nameof (AccountTypes)] != null)
        this.Tables.Add((DataTable) new dsGetGLAcctTypesFinancialReports.AccountTypesDataTable(dataSet.Tables[nameof (AccountTypes)]));
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
  public dsGetGLAcctTypesFinancialReports.AccountTypesDataTable AccountTypes
  {
    get => this.tableAccountTypes;
  }

  public override DataSet Clone()
  {
    dsGetGLAcctTypesFinancialReports financialReports = (dsGetGLAcctTypesFinancialReports) base.Clone();
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
    if (dataSet.Tables["AccountTypes"] != null)
      this.Tables.Add((DataTable) new dsGetGLAcctTypesFinancialReports.AccountTypesDataTable(dataSet.Tables["AccountTypes"]));
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
    this.tableAccountTypes = (dsGetGLAcctTypesFinancialReports.AccountTypesDataTable) this.Tables["AccountTypes"];
    if (this.tableAccountTypes == null)
      return;
    this.tableAccountTypes.InitVars();
  }

  private void InitClass()
  {
    this.DataSetName = nameof (dsGetGLAcctTypesFinancialReports);
    this.Prefix = "";
    this.Namespace = "http://tempuri.org/dsGetGLAcctTypesFinancialReports.xsd";
    this.Locale = new CultureInfo("en-US");
    this.CaseSensitive = false;
    this.EnforceConstraints = true;
    this.tableAccountTypes = new dsGetGLAcctTypesFinancialReports.AccountTypesDataTable();
    this.Tables.Add((DataTable) this.tableAccountTypes);
  }

  private bool ShouldSerializeAccountTypes() => false;

  private void SchemaChanged(object sender, CollectionChangeEventArgs e)
  {
    if (e.Action != CollectionChangeAction.Remove)
      return;
    this.InitVars();
  }

  public delegate void AccountTypesRowChangeEventHandler(
    object sender,
    dsGetGLAcctTypesFinancialReports.AccountTypesRowChangeEvent e);

  [DebuggerStepThrough]
  public class AccountTypesDataTable : DataTable, IEnumerable
  {
    private DataColumn columnAcctTypeId;
    private DataColumn columnAcctTypeDescription;

    internal AccountTypesDataTable()
      : base("AccountTypes")
    {
      this.InitClass();
    }

    internal AccountTypesDataTable(DataTable table)
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

    internal DataColumn AcctTypeIdColumn => this.columnAcctTypeId;

    internal DataColumn AcctTypeDescriptionColumn => this.columnAcctTypeDescription;

    public dsGetGLAcctTypesFinancialReports.AccountTypesRow this[int index]
    {
      get => (dsGetGLAcctTypesFinancialReports.AccountTypesRow) this.Rows[index];
    }

    public event dsGetGLAcctTypesFinancialReports.AccountTypesRowChangeEventHandler AccountTypesRowChanged;

    public event dsGetGLAcctTypesFinancialReports.AccountTypesRowChangeEventHandler AccountTypesRowChanging;

    public event dsGetGLAcctTypesFinancialReports.AccountTypesRowChangeEventHandler AccountTypesRowDeleted;

    public event dsGetGLAcctTypesFinancialReports.AccountTypesRowChangeEventHandler AccountTypesRowDeleting;

    public void AddAccountTypesRow(
      dsGetGLAcctTypesFinancialReports.AccountTypesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    public dsGetGLAcctTypesFinancialReports.AccountTypesRow AddAccountTypesRow(
      int AcctTypeId,
      string AcctTypeDescription)
    {
      dsGetGLAcctTypesFinancialReports.AccountTypesRow row = (dsGetGLAcctTypesFinancialReports.AccountTypesRow) this.NewRow();
      row.ItemArray = new object[2]
      {
        (object) AcctTypeId,
        (object) AcctTypeDescription
      };
      this.Rows.Add((DataRow) row);
      return row;
    }

    public IEnumerator GetEnumerator() => this.Rows.GetEnumerator();

    public override DataTable Clone()
    {
      dsGetGLAcctTypesFinancialReports.AccountTypesDataTable accountTypesDataTable = (dsGetGLAcctTypesFinancialReports.AccountTypesDataTable) base.Clone();
      accountTypesDataTable.InitVars();
      return (DataTable) accountTypesDataTable;
    }

    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsGetGLAcctTypesFinancialReports.AccountTypesDataTable();
    }

    internal void InitVars()
    {
      this.columnAcctTypeId = this.Columns["AcctTypeId"];
      this.columnAcctTypeDescription = this.Columns["AcctTypeDescription"];
    }

    private void InitClass()
    {
      this.columnAcctTypeId = new DataColumn("AcctTypeId", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAcctTypeId);
      this.columnAcctTypeDescription = new DataColumn("AcctTypeDescription", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAcctTypeDescription);
    }

    public dsGetGLAcctTypesFinancialReports.AccountTypesRow NewAccountTypesRow()
    {
      return (dsGetGLAcctTypesFinancialReports.AccountTypesRow) this.NewRow();
    }

    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsGetGLAcctTypesFinancialReports.AccountTypesRow(builder);
    }

    protected override Type GetRowType()
    {
      return typeof (dsGetGLAcctTypesFinancialReports.AccountTypesRow);
    }

    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.AccountTypesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsGetGLAcctTypesFinancialReports.AccountTypesRowChangeEventHandler typesRowChangedEvent = this.AccountTypesRowChangedEvent;
      if (typesRowChangedEvent == null)
        return;
      typesRowChangedEvent((object) this, new dsGetGLAcctTypesFinancialReports.AccountTypesRowChangeEvent((dsGetGLAcctTypesFinancialReports.AccountTypesRow) e.Row, e.Action));
    }

    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.AccountTypesRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsGetGLAcctTypesFinancialReports.AccountTypesRowChangeEventHandler rowChangingEvent = this.AccountTypesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsGetGLAcctTypesFinancialReports.AccountTypesRowChangeEvent((dsGetGLAcctTypesFinancialReports.AccountTypesRow) e.Row, e.Action));
    }

    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.AccountTypesRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsGetGLAcctTypesFinancialReports.AccountTypesRowChangeEventHandler typesRowDeletedEvent = this.AccountTypesRowDeletedEvent;
      if (typesRowDeletedEvent == null)
        return;
      typesRowDeletedEvent((object) this, new dsGetGLAcctTypesFinancialReports.AccountTypesRowChangeEvent((dsGetGLAcctTypesFinancialReports.AccountTypesRow) e.Row, e.Action));
    }

    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.AccountTypesRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsGetGLAcctTypesFinancialReports.AccountTypesRowChangeEventHandler rowDeletingEvent = this.AccountTypesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsGetGLAcctTypesFinancialReports.AccountTypesRowChangeEvent((dsGetGLAcctTypesFinancialReports.AccountTypesRow) e.Row, e.Action));
    }

    public void RemoveAccountTypesRow(
      dsGetGLAcctTypesFinancialReports.AccountTypesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }
  }

  [DebuggerStepThrough]
  public class AccountTypesRow : DataRow
  {
    private dsGetGLAcctTypesFinancialReports.AccountTypesDataTable tableAccountTypes;

    internal AccountTypesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableAccountTypes = (dsGetGLAcctTypesFinancialReports.AccountTypesDataTable) this.Table;
    }

    public int AcctTypeId
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tableAccountTypes.AcctTypeIdColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableAccountTypes.AcctTypeIdColumn] = (object) value;
    }

    public string AcctTypeDescription
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableAccountTypes.AcctTypeDescriptionColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableAccountTypes.AcctTypeDescriptionColumn] = (object) value;
    }

    public bool IsAcctTypeIdNull() => this.IsNull(this.tableAccountTypes.AcctTypeIdColumn);

    public void SetAcctTypeIdNull()
    {
      this[this.tableAccountTypes.AcctTypeIdColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsAcctTypeDescriptionNull()
    {
      return this.IsNull(this.tableAccountTypes.AcctTypeDescriptionColumn);
    }

    public void SetAcctTypeDescriptionNull()
    {
      this[this.tableAccountTypes.AcctTypeDescriptionColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  [DebuggerStepThrough]
  public class AccountTypesRowChangeEvent : EventArgs
  {
    private dsGetGLAcctTypesFinancialReports.AccountTypesRow eventRow;
    private DataRowAction eventAction;

    public AccountTypesRowChangeEvent(
      dsGetGLAcctTypesFinancialReports.AccountTypesRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    public dsGetGLAcctTypesFinancialReports.AccountTypesRow Row => this.eventRow;

    public DataRowAction Action => this.eventAction;
  }
}
