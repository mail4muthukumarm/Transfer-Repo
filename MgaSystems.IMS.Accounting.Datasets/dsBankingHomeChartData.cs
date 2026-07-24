// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.AccountingDatasets.dsBankingHomeChartData
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
public class dsBankingHomeChartData : DataSet
{
  private dsBankingHomeChartData.BankingChartDataDataTable tableBankingChartData;
  private dsBankingHomeChartData.BankAccountsDataTable tableBankAccounts;

  public dsBankingHomeChartData()
  {
    this.InitClass();
    CollectionChangeEventHandler changeEventHandler = new CollectionChangeEventHandler(this.SchemaChanged);
    this.Tables.CollectionChanged += changeEventHandler;
    this.Relations.CollectionChanged += changeEventHandler;
  }

  protected dsBankingHomeChartData(SerializationInfo info, StreamingContext context)
  {
    string s = Conversions.ToString(info.GetValue("XmlSchema", typeof (string)));
    if (s != null)
    {
      DataSet dataSet = new DataSet();
      dataSet.ReadXmlSchema((XmlReader) new XmlTextReader((TextReader) new StringReader(s)));
      if (dataSet.Tables[nameof (BankingChartData)] != null)
        this.Tables.Add((DataTable) new dsBankingHomeChartData.BankingChartDataDataTable(dataSet.Tables[nameof (BankingChartData)]));
      if (dataSet.Tables[nameof (BankAccounts)] != null)
        this.Tables.Add((DataTable) new dsBankingHomeChartData.BankAccountsDataTable(dataSet.Tables[nameof (BankAccounts)]));
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
  public dsBankingHomeChartData.BankingChartDataDataTable BankingChartData
  {
    get => this.tableBankingChartData;
  }

  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsBankingHomeChartData.BankAccountsDataTable BankAccounts => this.tableBankAccounts;

  public override DataSet Clone()
  {
    dsBankingHomeChartData bankingHomeChartData = (dsBankingHomeChartData) base.Clone();
    bankingHomeChartData.InitVars();
    return (DataSet) bankingHomeChartData;
  }

  protected override bool ShouldSerializeTables() => false;

  protected override bool ShouldSerializeRelations() => false;

  protected override void ReadXmlSerializable(XmlReader reader)
  {
    this.Reset();
    DataSet dataSet = new DataSet();
    int num = (int) dataSet.ReadXml(reader);
    if (dataSet.Tables["BankingChartData"] != null)
      this.Tables.Add((DataTable) new dsBankingHomeChartData.BankingChartDataDataTable(dataSet.Tables["BankingChartData"]));
    if (dataSet.Tables["BankAccounts"] != null)
      this.Tables.Add((DataTable) new dsBankingHomeChartData.BankAccountsDataTable(dataSet.Tables["BankAccounts"]));
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
    this.tableBankingChartData = (dsBankingHomeChartData.BankingChartDataDataTable) this.Tables["BankingChartData"];
    if (this.tableBankingChartData != null)
      this.tableBankingChartData.InitVars();
    this.tableBankAccounts = (dsBankingHomeChartData.BankAccountsDataTable) this.Tables["BankAccounts"];
    if (this.tableBankAccounts == null)
      return;
    this.tableBankAccounts.InitVars();
  }

  private void InitClass()
  {
    this.DataSetName = nameof (dsBankingHomeChartData);
    this.Prefix = "";
    this.Namespace = "http://tempuri.org/dsBankingHomeChartData.xsd";
    this.Locale = new CultureInfo("en-US");
    this.CaseSensitive = false;
    this.EnforceConstraints = true;
    this.tableBankingChartData = new dsBankingHomeChartData.BankingChartDataDataTable();
    this.Tables.Add((DataTable) this.tableBankingChartData);
    this.tableBankAccounts = new dsBankingHomeChartData.BankAccountsDataTable();
    this.Tables.Add((DataTable) this.tableBankAccounts);
  }

  private bool ShouldSerializeBankingChartData() => false;

  private bool ShouldSerializeBankAccounts() => false;

  private void SchemaChanged(object sender, CollectionChangeEventArgs e)
  {
    if (e.Action != CollectionChangeAction.Remove)
      return;
    this.InitVars();
  }

  public delegate void BankingChartDataRowChangeEventHandler(
    object sender,
    dsBankingHomeChartData.BankingChartDataRowChangeEvent e);

  public delegate void BankAccountsRowChangeEventHandler(
    object sender,
    dsBankingHomeChartData.BankAccountsRowChangeEvent e);

  [DebuggerStepThrough]
  public class BankingChartDataDataTable : DataTable, IEnumerable
  {
    private DataColumn columnBank;
    private DataColumn columnBalance;

    internal BankingChartDataDataTable()
      : base("BankingChartData")
    {
      this.InitClass();
    }

    internal BankingChartDataDataTable(DataTable table)
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

    internal DataColumn BankColumn => this.columnBank;

    internal DataColumn BalanceColumn => this.columnBalance;

    public dsBankingHomeChartData.BankingChartDataRow this[int index]
    {
      get => (dsBankingHomeChartData.BankingChartDataRow) this.Rows[index];
    }

    public event dsBankingHomeChartData.BankingChartDataRowChangeEventHandler BankingChartDataRowChanged;

    public event dsBankingHomeChartData.BankingChartDataRowChangeEventHandler BankingChartDataRowChanging;

    public event dsBankingHomeChartData.BankingChartDataRowChangeEventHandler BankingChartDataRowDeleted;

    public event dsBankingHomeChartData.BankingChartDataRowChangeEventHandler BankingChartDataRowDeleting;

    public void AddBankingChartDataRow(dsBankingHomeChartData.BankingChartDataRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    public dsBankingHomeChartData.BankingChartDataRow AddBankingChartDataRow(
      string Bank,
      Decimal Balance)
    {
      dsBankingHomeChartData.BankingChartDataRow row = (dsBankingHomeChartData.BankingChartDataRow) this.NewRow();
      row.ItemArray = new object[2]
      {
        (object) Bank,
        (object) Balance
      };
      this.Rows.Add((DataRow) row);
      return row;
    }

    public IEnumerator GetEnumerator() => this.Rows.GetEnumerator();

    public override DataTable Clone()
    {
      dsBankingHomeChartData.BankingChartDataDataTable chartDataDataTable = (dsBankingHomeChartData.BankingChartDataDataTable) base.Clone();
      chartDataDataTable.InitVars();
      return (DataTable) chartDataDataTable;
    }

    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsBankingHomeChartData.BankingChartDataDataTable();
    }

    internal void InitVars()
    {
      this.columnBank = this.Columns["Bank"];
      this.columnBalance = this.Columns["Balance"];
    }

    private void InitClass()
    {
      this.columnBank = new DataColumn("Bank", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnBank);
      this.columnBalance = new DataColumn("Balance", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnBalance);
    }

    public dsBankingHomeChartData.BankingChartDataRow NewBankingChartDataRow()
    {
      return (dsBankingHomeChartData.BankingChartDataRow) this.NewRow();
    }

    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsBankingHomeChartData.BankingChartDataRow(builder);
    }

    protected override Type GetRowType() => typeof (dsBankingHomeChartData.BankingChartDataRow);

    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.BankingChartDataRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsBankingHomeChartData.BankingChartDataRowChangeEventHandler dataRowChangedEvent = this.BankingChartDataRowChangedEvent;
      if (dataRowChangedEvent == null)
        return;
      dataRowChangedEvent((object) this, new dsBankingHomeChartData.BankingChartDataRowChangeEvent((dsBankingHomeChartData.BankingChartDataRow) e.Row, e.Action));
    }

    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.BankingChartDataRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsBankingHomeChartData.BankingChartDataRowChangeEventHandler rowChangingEvent = this.BankingChartDataRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsBankingHomeChartData.BankingChartDataRowChangeEvent((dsBankingHomeChartData.BankingChartDataRow) e.Row, e.Action));
    }

    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.BankingChartDataRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsBankingHomeChartData.BankingChartDataRowChangeEventHandler dataRowDeletedEvent = this.BankingChartDataRowDeletedEvent;
      if (dataRowDeletedEvent == null)
        return;
      dataRowDeletedEvent((object) this, new dsBankingHomeChartData.BankingChartDataRowChangeEvent((dsBankingHomeChartData.BankingChartDataRow) e.Row, e.Action));
    }

    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.BankingChartDataRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsBankingHomeChartData.BankingChartDataRowChangeEventHandler rowDeletingEvent = this.BankingChartDataRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsBankingHomeChartData.BankingChartDataRowChangeEvent((dsBankingHomeChartData.BankingChartDataRow) e.Row, e.Action));
    }

    public void RemoveBankingChartDataRow(dsBankingHomeChartData.BankingChartDataRow row)
    {
      this.Rows.Remove((DataRow) row);
    }
  }

  [DebuggerStepThrough]
  public class BankingChartDataRow : DataRow
  {
    private dsBankingHomeChartData.BankingChartDataDataTable tableBankingChartData;

    internal BankingChartDataRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableBankingChartData = (dsBankingHomeChartData.BankingChartDataDataTable) this.Table;
    }

    public string Bank
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableBankingChartData.BankColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableBankingChartData.BankColumn] = (object) value;
    }

    public Decimal Balance
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tableBankingChartData.BalanceColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableBankingChartData.BalanceColumn] = (object) value;
    }

    public bool IsBankNull() => this.IsNull(this.tableBankingChartData.BankColumn);

    public void SetBankNull()
    {
      this[this.tableBankingChartData.BankColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsBalanceNull() => this.IsNull(this.tableBankingChartData.BalanceColumn);

    public void SetBalanceNull()
    {
      this[this.tableBankingChartData.BalanceColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  [DebuggerStepThrough]
  public class BankingChartDataRowChangeEvent : EventArgs
  {
    private dsBankingHomeChartData.BankingChartDataRow eventRow;
    private DataRowAction eventAction;

    public BankingChartDataRowChangeEvent(
      dsBankingHomeChartData.BankingChartDataRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    public dsBankingHomeChartData.BankingChartDataRow Row => this.eventRow;

    public DataRowAction Action => this.eventAction;
  }

  [DebuggerStepThrough]
  public class BankAccountsDataTable : DataTable, IEnumerable
  {
    private DataColumn columnglAcctId;
    private DataColumn columnLocation;
    private DataColumn columnBankAddress;
    private DataColumn columnAccountNumber;
    private DataColumn columnAccountType;
    private DataColumn columnBalance;

    internal BankAccountsDataTable()
      : base("BankAccounts")
    {
      this.InitClass();
    }

    internal BankAccountsDataTable(DataTable table)
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

    internal DataColumn glAcctIdColumn => this.columnglAcctId;

    internal DataColumn LocationColumn => this.columnLocation;

    internal DataColumn BankAddressColumn => this.columnBankAddress;

    internal DataColumn AccountNumberColumn => this.columnAccountNumber;

    internal DataColumn AccountTypeColumn => this.columnAccountType;

    internal DataColumn BalanceColumn => this.columnBalance;

    public dsBankingHomeChartData.BankAccountsRow this[int index]
    {
      get => (dsBankingHomeChartData.BankAccountsRow) this.Rows[index];
    }

    public event dsBankingHomeChartData.BankAccountsRowChangeEventHandler BankAccountsRowChanged;

    public event dsBankingHomeChartData.BankAccountsRowChangeEventHandler BankAccountsRowChanging;

    public event dsBankingHomeChartData.BankAccountsRowChangeEventHandler BankAccountsRowDeleted;

    public event dsBankingHomeChartData.BankAccountsRowChangeEventHandler BankAccountsRowDeleting;

    public void AddBankAccountsRow(dsBankingHomeChartData.BankAccountsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    public dsBankingHomeChartData.BankAccountsRow AddBankAccountsRow(
      int glAcctId,
      string Location,
      string BankAddress,
      string AccountNumber,
      string AccountType,
      Decimal Balance)
    {
      dsBankingHomeChartData.BankAccountsRow row = (dsBankingHomeChartData.BankAccountsRow) this.NewRow();
      row.ItemArray = new object[6]
      {
        (object) glAcctId,
        (object) Location,
        (object) BankAddress,
        (object) AccountNumber,
        (object) AccountType,
        (object) Balance
      };
      this.Rows.Add((DataRow) row);
      return row;
    }

    public IEnumerator GetEnumerator() => this.Rows.GetEnumerator();

    public override DataTable Clone()
    {
      dsBankingHomeChartData.BankAccountsDataTable accountsDataTable = (dsBankingHomeChartData.BankAccountsDataTable) base.Clone();
      accountsDataTable.InitVars();
      return (DataTable) accountsDataTable;
    }

    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsBankingHomeChartData.BankAccountsDataTable();
    }

    internal void InitVars()
    {
      this.columnglAcctId = this.Columns["glAcctId"];
      this.columnLocation = this.Columns["Location"];
      this.columnBankAddress = this.Columns["BankAddress"];
      this.columnAccountNumber = this.Columns["AccountNumber"];
      this.columnAccountType = this.Columns["AccountType"];
      this.columnBalance = this.Columns["Balance"];
    }

    private void InitClass()
    {
      this.columnglAcctId = new DataColumn("glAcctId", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnglAcctId);
      this.columnLocation = new DataColumn("Location", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLocation);
      this.columnBankAddress = new DataColumn("BankAddress", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnBankAddress);
      this.columnAccountNumber = new DataColumn("AccountNumber", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAccountNumber);
      this.columnAccountType = new DataColumn("AccountType", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAccountType);
      this.columnBalance = new DataColumn("Balance", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnBalance);
    }

    public dsBankingHomeChartData.BankAccountsRow NewBankAccountsRow()
    {
      return (dsBankingHomeChartData.BankAccountsRow) this.NewRow();
    }

    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsBankingHomeChartData.BankAccountsRow(builder);
    }

    protected override Type GetRowType() => typeof (dsBankingHomeChartData.BankAccountsRow);

    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.BankAccountsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsBankingHomeChartData.BankAccountsRowChangeEventHandler accountsRowChangedEvent = this.BankAccountsRowChangedEvent;
      if (accountsRowChangedEvent == null)
        return;
      accountsRowChangedEvent((object) this, new dsBankingHomeChartData.BankAccountsRowChangeEvent((dsBankingHomeChartData.BankAccountsRow) e.Row, e.Action));
    }

    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.BankAccountsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsBankingHomeChartData.BankAccountsRowChangeEventHandler rowChangingEvent = this.BankAccountsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsBankingHomeChartData.BankAccountsRowChangeEvent((dsBankingHomeChartData.BankAccountsRow) e.Row, e.Action));
    }

    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.BankAccountsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsBankingHomeChartData.BankAccountsRowChangeEventHandler accountsRowDeletedEvent = this.BankAccountsRowDeletedEvent;
      if (accountsRowDeletedEvent == null)
        return;
      accountsRowDeletedEvent((object) this, new dsBankingHomeChartData.BankAccountsRowChangeEvent((dsBankingHomeChartData.BankAccountsRow) e.Row, e.Action));
    }

    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.BankAccountsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsBankingHomeChartData.BankAccountsRowChangeEventHandler rowDeletingEvent = this.BankAccountsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsBankingHomeChartData.BankAccountsRowChangeEvent((dsBankingHomeChartData.BankAccountsRow) e.Row, e.Action));
    }

    public void RemoveBankAccountsRow(dsBankingHomeChartData.BankAccountsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }
  }

  [DebuggerStepThrough]
  public class BankAccountsRow : DataRow
  {
    private dsBankingHomeChartData.BankAccountsDataTable tableBankAccounts;

    internal BankAccountsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableBankAccounts = (dsBankingHomeChartData.BankAccountsDataTable) this.Table;
    }

    public int glAcctId
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tableBankAccounts.glAcctIdColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableBankAccounts.glAcctIdColumn] = (object) value;
    }

    public string Location
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableBankAccounts.LocationColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableBankAccounts.LocationColumn] = (object) value;
    }

    public string BankAddress
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableBankAccounts.BankAddressColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableBankAccounts.BankAddressColumn] = (object) value;
    }

    public string AccountNumber
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableBankAccounts.AccountNumberColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableBankAccounts.AccountNumberColumn] = (object) value;
    }

    public string AccountType
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableBankAccounts.AccountTypeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableBankAccounts.AccountTypeColumn] = (object) value;
    }

    public Decimal Balance
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tableBankAccounts.BalanceColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableBankAccounts.BalanceColumn] = (object) value;
    }

    public bool IsglAcctIdNull() => this.IsNull(this.tableBankAccounts.glAcctIdColumn);

    public void SetglAcctIdNull()
    {
      this[this.tableBankAccounts.glAcctIdColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsLocationNull() => this.IsNull(this.tableBankAccounts.LocationColumn);

    public void SetLocationNull()
    {
      this[this.tableBankAccounts.LocationColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsBankAddressNull() => this.IsNull(this.tableBankAccounts.BankAddressColumn);

    public void SetBankAddressNull()
    {
      this[this.tableBankAccounts.BankAddressColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsAccountNumberNull() => this.IsNull(this.tableBankAccounts.AccountNumberColumn);

    public void SetAccountNumberNull()
    {
      this[this.tableBankAccounts.AccountNumberColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsAccountTypeNull() => this.IsNull(this.tableBankAccounts.AccountTypeColumn);

    public void SetAccountTypeNull()
    {
      this[this.tableBankAccounts.AccountTypeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsBalanceNull() => this.IsNull(this.tableBankAccounts.BalanceColumn);

    public void SetBalanceNull()
    {
      this[this.tableBankAccounts.BalanceColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  [DebuggerStepThrough]
  public class BankAccountsRowChangeEvent : EventArgs
  {
    private dsBankingHomeChartData.BankAccountsRow eventRow;
    private DataRowAction eventAction;

    public BankAccountsRowChangeEvent(
      dsBankingHomeChartData.BankAccountsRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    public dsBankingHomeChartData.BankAccountsRow Row => this.eventRow;

    public DataRowAction Action => this.eventAction;
  }
}
