// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.AccountingDatasets.dsFinancials_UnAssignedGLAccounts
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
public class dsFinancials_UnAssignedGLAccounts : DataSet
{
  private dsFinancials_UnAssignedGLAccounts.UnAssignedGLAccountsDataTable tableUnAssignedGLAccounts;

  public dsFinancials_UnAssignedGLAccounts()
  {
    this.InitClass();
    CollectionChangeEventHandler changeEventHandler = new CollectionChangeEventHandler(this.SchemaChanged);
    this.Tables.CollectionChanged += changeEventHandler;
    this.Relations.CollectionChanged += changeEventHandler;
  }

  protected dsFinancials_UnAssignedGLAccounts(SerializationInfo info, StreamingContext context)
  {
    string s = Conversions.ToString(info.GetValue("XmlSchema", typeof (string)));
    if (s != null)
    {
      DataSet dataSet = new DataSet();
      dataSet.ReadXmlSchema((XmlReader) new XmlTextReader((TextReader) new StringReader(s)));
      if (dataSet.Tables[nameof (UnAssignedGLAccounts)] != null)
        this.Tables.Add((DataTable) new dsFinancials_UnAssignedGLAccounts.UnAssignedGLAccountsDataTable(dataSet.Tables[nameof (UnAssignedGLAccounts)]));
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
  public dsFinancials_UnAssignedGLAccounts.UnAssignedGLAccountsDataTable UnAssignedGLAccounts
  {
    get => this.tableUnAssignedGLAccounts;
  }

  public override DataSet Clone()
  {
    dsFinancials_UnAssignedGLAccounts assignedGlAccounts = (dsFinancials_UnAssignedGLAccounts) base.Clone();
    assignedGlAccounts.InitVars();
    return (DataSet) assignedGlAccounts;
  }

  protected override bool ShouldSerializeTables() => false;

  protected override bool ShouldSerializeRelations() => false;

  protected override void ReadXmlSerializable(XmlReader reader)
  {
    this.Reset();
    DataSet dataSet = new DataSet();
    int num = (int) dataSet.ReadXml(reader);
    if (dataSet.Tables["UnAssignedGLAccounts"] != null)
      this.Tables.Add((DataTable) new dsFinancials_UnAssignedGLAccounts.UnAssignedGLAccountsDataTable(dataSet.Tables["UnAssignedGLAccounts"]));
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
    this.tableUnAssignedGLAccounts = (dsFinancials_UnAssignedGLAccounts.UnAssignedGLAccountsDataTable) this.Tables["UnAssignedGLAccounts"];
    if (this.tableUnAssignedGLAccounts == null)
      return;
    this.tableUnAssignedGLAccounts.InitVars();
  }

  private void InitClass()
  {
    this.DataSetName = nameof (dsFinancials_UnAssignedGLAccounts);
    this.Prefix = "";
    this.Namespace = "http://tempuri.org/dsFinancials_UnAssignedGLAccounts.xsd";
    this.Locale = new CultureInfo("en-US");
    this.CaseSensitive = false;
    this.EnforceConstraints = true;
    this.tableUnAssignedGLAccounts = new dsFinancials_UnAssignedGLAccounts.UnAssignedGLAccountsDataTable();
    this.Tables.Add((DataTable) this.tableUnAssignedGLAccounts);
  }

  private bool ShouldSerializeUnAssignedGLAccounts() => false;

  private void SchemaChanged(object sender, CollectionChangeEventArgs e)
  {
    if (e.Action != CollectionChangeAction.Remove)
      return;
    this.InitVars();
  }

  public delegate void UnAssignedGLAccountsRowChangeEventHandler(
    object sender,
    dsFinancials_UnAssignedGLAccounts.UnAssignedGLAccountsRowChangeEvent e);

  [DebuggerStepThrough]
  public class UnAssignedGLAccountsDataTable : DataTable, IEnumerable
  {
    private DataColumn columnGlAcctId;
    private DataColumn columnAccountClass;
    private DataColumn columnAcctNumber;
    private DataColumn columnFullName;

    internal UnAssignedGLAccountsDataTable()
      : base("UnAssignedGLAccounts")
    {
      this.InitClass();
    }

    internal UnAssignedGLAccountsDataTable(DataTable table)
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

    internal DataColumn GlAcctIdColumn => this.columnGlAcctId;

    internal DataColumn AccountClassColumn => this.columnAccountClass;

    internal DataColumn AcctNumberColumn => this.columnAcctNumber;

    internal DataColumn FullNameColumn => this.columnFullName;

    public dsFinancials_UnAssignedGLAccounts.UnAssignedGLAccountsRow this[int index]
    {
      get => (dsFinancials_UnAssignedGLAccounts.UnAssignedGLAccountsRow) this.Rows[index];
    }

    public event dsFinancials_UnAssignedGLAccounts.UnAssignedGLAccountsRowChangeEventHandler UnAssignedGLAccountsRowChanged;

    public event dsFinancials_UnAssignedGLAccounts.UnAssignedGLAccountsRowChangeEventHandler UnAssignedGLAccountsRowChanging;

    public event dsFinancials_UnAssignedGLAccounts.UnAssignedGLAccountsRowChangeEventHandler UnAssignedGLAccountsRowDeleted;

    public event dsFinancials_UnAssignedGLAccounts.UnAssignedGLAccountsRowChangeEventHandler UnAssignedGLAccountsRowDeleting;

    public void AddUnAssignedGLAccountsRow(
      dsFinancials_UnAssignedGLAccounts.UnAssignedGLAccountsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    public dsFinancials_UnAssignedGLAccounts.UnAssignedGLAccountsRow AddUnAssignedGLAccountsRow(
      int GlAcctId,
      string AccountClass,
      int AcctNumber,
      string FullName)
    {
      dsFinancials_UnAssignedGLAccounts.UnAssignedGLAccountsRow row = (dsFinancials_UnAssignedGLAccounts.UnAssignedGLAccountsRow) this.NewRow();
      row.ItemArray = new object[4]
      {
        (object) GlAcctId,
        (object) AccountClass,
        (object) AcctNumber,
        (object) FullName
      };
      this.Rows.Add((DataRow) row);
      return row;
    }

    public IEnumerator GetEnumerator() => this.Rows.GetEnumerator();

    public override DataTable Clone()
    {
      dsFinancials_UnAssignedGLAccounts.UnAssignedGLAccountsDataTable accountsDataTable = (dsFinancials_UnAssignedGLAccounts.UnAssignedGLAccountsDataTable) base.Clone();
      accountsDataTable.InitVars();
      return (DataTable) accountsDataTable;
    }

    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsFinancials_UnAssignedGLAccounts.UnAssignedGLAccountsDataTable();
    }

    internal void InitVars()
    {
      this.columnGlAcctId = this.Columns["GlAcctId"];
      this.columnAccountClass = this.Columns["AccountClass"];
      this.columnAcctNumber = this.Columns["AcctNumber"];
      this.columnFullName = this.Columns["FullName"];
    }

    private void InitClass()
    {
      this.columnGlAcctId = new DataColumn("GlAcctId", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnGlAcctId);
      this.columnAccountClass = new DataColumn("AccountClass", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAccountClass);
      this.columnAcctNumber = new DataColumn("AcctNumber", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAcctNumber);
      this.columnFullName = new DataColumn("FullName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFullName);
    }

    public dsFinancials_UnAssignedGLAccounts.UnAssignedGLAccountsRow NewUnAssignedGLAccountsRow()
    {
      return (dsFinancials_UnAssignedGLAccounts.UnAssignedGLAccountsRow) this.NewRow();
    }

    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsFinancials_UnAssignedGLAccounts.UnAssignedGLAccountsRow(builder);
    }

    protected override Type GetRowType()
    {
      return typeof (dsFinancials_UnAssignedGLAccounts.UnAssignedGLAccountsRow);
    }

    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.UnAssignedGLAccountsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsFinancials_UnAssignedGLAccounts.UnAssignedGLAccountsRowChangeEventHandler accountsRowChangedEvent = this.UnAssignedGLAccountsRowChangedEvent;
      if (accountsRowChangedEvent == null)
        return;
      accountsRowChangedEvent((object) this, new dsFinancials_UnAssignedGLAccounts.UnAssignedGLAccountsRowChangeEvent((dsFinancials_UnAssignedGLAccounts.UnAssignedGLAccountsRow) e.Row, e.Action));
    }

    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.UnAssignedGLAccountsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsFinancials_UnAssignedGLAccounts.UnAssignedGLAccountsRowChangeEventHandler rowChangingEvent = this.UnAssignedGLAccountsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsFinancials_UnAssignedGLAccounts.UnAssignedGLAccountsRowChangeEvent((dsFinancials_UnAssignedGLAccounts.UnAssignedGLAccountsRow) e.Row, e.Action));
    }

    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.UnAssignedGLAccountsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsFinancials_UnAssignedGLAccounts.UnAssignedGLAccountsRowChangeEventHandler accountsRowDeletedEvent = this.UnAssignedGLAccountsRowDeletedEvent;
      if (accountsRowDeletedEvent == null)
        return;
      accountsRowDeletedEvent((object) this, new dsFinancials_UnAssignedGLAccounts.UnAssignedGLAccountsRowChangeEvent((dsFinancials_UnAssignedGLAccounts.UnAssignedGLAccountsRow) e.Row, e.Action));
    }

    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.UnAssignedGLAccountsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsFinancials_UnAssignedGLAccounts.UnAssignedGLAccountsRowChangeEventHandler rowDeletingEvent = this.UnAssignedGLAccountsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsFinancials_UnAssignedGLAccounts.UnAssignedGLAccountsRowChangeEvent((dsFinancials_UnAssignedGLAccounts.UnAssignedGLAccountsRow) e.Row, e.Action));
    }

    public void RemoveUnAssignedGLAccountsRow(
      dsFinancials_UnAssignedGLAccounts.UnAssignedGLAccountsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }
  }

  [DebuggerStepThrough]
  public class UnAssignedGLAccountsRow : DataRow
  {
    private dsFinancials_UnAssignedGLAccounts.UnAssignedGLAccountsDataTable tableUnAssignedGLAccounts;

    internal UnAssignedGLAccountsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableUnAssignedGLAccounts = (dsFinancials_UnAssignedGLAccounts.UnAssignedGLAccountsDataTable) this.Table;
    }

    public int GlAcctId
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tableUnAssignedGLAccounts.GlAcctIdColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableUnAssignedGLAccounts.GlAcctIdColumn] = (object) value;
    }

    public string AccountClass
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableUnAssignedGLAccounts.AccountClassColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableUnAssignedGLAccounts.AccountClassColumn] = (object) value;
    }

    public int AcctNumber
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tableUnAssignedGLAccounts.AcctNumberColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableUnAssignedGLAccounts.AcctNumberColumn] = (object) value;
    }

    public string FullName
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableUnAssignedGLAccounts.FullNameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableUnAssignedGLAccounts.FullNameColumn] = (object) value;
    }

    public bool IsGlAcctIdNull() => this.IsNull(this.tableUnAssignedGLAccounts.GlAcctIdColumn);

    public void SetGlAcctIdNull()
    {
      this[this.tableUnAssignedGLAccounts.GlAcctIdColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsAccountClassNull()
    {
      return this.IsNull(this.tableUnAssignedGLAccounts.AccountClassColumn);
    }

    public void SetAccountClassNull()
    {
      this[this.tableUnAssignedGLAccounts.AccountClassColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsAcctNumberNull() => this.IsNull(this.tableUnAssignedGLAccounts.AcctNumberColumn);

    public void SetAcctNumberNull()
    {
      this[this.tableUnAssignedGLAccounts.AcctNumberColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsFullNameNull() => this.IsNull(this.tableUnAssignedGLAccounts.FullNameColumn);

    public void SetFullNameNull()
    {
      this[this.tableUnAssignedGLAccounts.FullNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  [DebuggerStepThrough]
  public class UnAssignedGLAccountsRowChangeEvent : EventArgs
  {
    private dsFinancials_UnAssignedGLAccounts.UnAssignedGLAccountsRow eventRow;
    private DataRowAction eventAction;

    public UnAssignedGLAccountsRowChangeEvent(
      dsFinancials_UnAssignedGLAccounts.UnAssignedGLAccountsRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    public dsFinancials_UnAssignedGLAccounts.UnAssignedGLAccountsRow Row => this.eventRow;

    public DataRowAction Action => this.eventAction;
  }
}
