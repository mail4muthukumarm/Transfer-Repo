// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.AccountingDatasets.dsBankDeposits
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
public class dsBankDeposits : DataSet
{
  private dsBankDeposits.BankDepositsDataTable tableBankDeposits;

  public dsBankDeposits()
  {
    this.InitClass();
    CollectionChangeEventHandler changeEventHandler = new CollectionChangeEventHandler(this.SchemaChanged);
    this.Tables.CollectionChanged += changeEventHandler;
    this.Relations.CollectionChanged += changeEventHandler;
  }

  protected dsBankDeposits(SerializationInfo info, StreamingContext context)
  {
    string s = Conversions.ToString(info.GetValue("XmlSchema", typeof (string)));
    if (s != null)
    {
      DataSet dataSet = new DataSet();
      dataSet.ReadXmlSchema((XmlReader) new XmlTextReader((TextReader) new StringReader(s)));
      if (dataSet.Tables[nameof (BankDeposits)] != null)
        this.Tables.Add((DataTable) new dsBankDeposits.BankDepositsDataTable(dataSet.Tables[nameof (BankDeposits)]));
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
  public dsBankDeposits.BankDepositsDataTable BankDeposits => this.tableBankDeposits;

  public override DataSet Clone()
  {
    dsBankDeposits dsBankDeposits = (dsBankDeposits) base.Clone();
    dsBankDeposits.InitVars();
    return (DataSet) dsBankDeposits;
  }

  protected override bool ShouldSerializeTables() => false;

  protected override bool ShouldSerializeRelations() => false;

  protected override void ReadXmlSerializable(XmlReader reader)
  {
    this.Reset();
    DataSet dataSet = new DataSet();
    int num = (int) dataSet.ReadXml(reader);
    if (dataSet.Tables["BankDeposits"] != null)
      this.Tables.Add((DataTable) new dsBankDeposits.BankDepositsDataTable(dataSet.Tables["BankDeposits"]));
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
    this.tableBankDeposits = (dsBankDeposits.BankDepositsDataTable) this.Tables["BankDeposits"];
    if (this.tableBankDeposits == null)
      return;
    this.tableBankDeposits.InitVars();
  }

  private void InitClass()
  {
    this.DataSetName = nameof (dsBankDeposits);
    this.Prefix = "";
    this.Namespace = "http://tempuri.org/dsBankDeposits.xsd";
    this.Locale = new CultureInfo("en-US");
    this.CaseSensitive = false;
    this.EnforceConstraints = true;
    this.tableBankDeposits = new dsBankDeposits.BankDepositsDataTable();
    this.Tables.Add((DataTable) this.tableBankDeposits);
  }

  private bool ShouldSerializeBankDeposits() => false;

  private void SchemaChanged(object sender, CollectionChangeEventArgs e)
  {
    if (e.Action != CollectionChangeAction.Remove)
      return;
    this.InitVars();
  }

  public delegate void BankDepositsRowChangeEventHandler(
    object sender,
    dsBankDeposits.BankDepositsRowChangeEvent e);

  [DebuggerStepThrough]
  public class BankDepositsDataTable : DataTable, IEnumerable
  {
    private DataColumn columnRemitter;
    private DataColumn columnPostDate;
    private DataColumn columnReceivedDate;
    private DataColumn columnDepositDate;
    private DataColumn columnCheckNumber;
    private DataColumn columnAmount;
    private DataColumn columnComments;
    private DataColumn columnBank;
    private DataColumn columnOffsetAccount;

    internal BankDepositsDataTable()
      : base("BankDeposits")
    {
      this.InitClass();
    }

    internal BankDepositsDataTable(DataTable table)
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

    internal DataColumn RemitterColumn => this.columnRemitter;

    internal DataColumn PostDateColumn => this.columnPostDate;

    internal DataColumn ReceivedDateColumn => this.columnReceivedDate;

    internal DataColumn DepositDateColumn => this.columnDepositDate;

    internal DataColumn CheckNumberColumn => this.columnCheckNumber;

    internal DataColumn AmountColumn => this.columnAmount;

    internal DataColumn CommentsColumn => this.columnComments;

    internal DataColumn BankColumn => this.columnBank;

    internal DataColumn OffsetAccountColumn => this.columnOffsetAccount;

    public dsBankDeposits.BankDepositsRow this[int index]
    {
      get => (dsBankDeposits.BankDepositsRow) this.Rows[index];
    }

    public event dsBankDeposits.BankDepositsRowChangeEventHandler BankDepositsRowChanged;

    public event dsBankDeposits.BankDepositsRowChangeEventHandler BankDepositsRowChanging;

    public event dsBankDeposits.BankDepositsRowChangeEventHandler BankDepositsRowDeleted;

    public event dsBankDeposits.BankDepositsRowChangeEventHandler BankDepositsRowDeleting;

    public void AddBankDepositsRow(dsBankDeposits.BankDepositsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    public dsBankDeposits.BankDepositsRow AddBankDepositsRow(
      string Remitter,
      DateTime PostDate,
      DateTime ReceivedDate,
      DateTime DepositDate,
      string CheckNumber,
      Decimal Amount,
      string Comments,
      string Bank,
      string OffsetAccount)
    {
      dsBankDeposits.BankDepositsRow row = (dsBankDeposits.BankDepositsRow) this.NewRow();
      row.ItemArray = new object[9]
      {
        (object) Remitter,
        (object) PostDate,
        (object) ReceivedDate,
        (object) DepositDate,
        (object) CheckNumber,
        (object) Amount,
        (object) Comments,
        (object) Bank,
        (object) OffsetAccount
      };
      this.Rows.Add((DataRow) row);
      return row;
    }

    public IEnumerator GetEnumerator() => this.Rows.GetEnumerator();

    public override DataTable Clone()
    {
      dsBankDeposits.BankDepositsDataTable depositsDataTable = (dsBankDeposits.BankDepositsDataTable) base.Clone();
      depositsDataTable.InitVars();
      return (DataTable) depositsDataTable;
    }

    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsBankDeposits.BankDepositsDataTable();
    }

    internal void InitVars()
    {
      this.columnRemitter = this.Columns["Remitter"];
      this.columnPostDate = this.Columns["PostDate"];
      this.columnReceivedDate = this.Columns["ReceivedDate"];
      this.columnDepositDate = this.Columns["DepositDate"];
      this.columnCheckNumber = this.Columns["CheckNumber"];
      this.columnAmount = this.Columns["Amount"];
      this.columnComments = this.Columns["Comments"];
      this.columnBank = this.Columns["Bank"];
      this.columnOffsetAccount = this.Columns["OffsetAccount"];
    }

    private void InitClass()
    {
      this.columnRemitter = new DataColumn("Remitter", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnRemitter);
      this.columnPostDate = new DataColumn("PostDate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPostDate);
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
      this.columnBank = new DataColumn("Bank", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnBank);
      this.columnOffsetAccount = new DataColumn("OffsetAccount", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnOffsetAccount);
    }

    public dsBankDeposits.BankDepositsRow NewBankDepositsRow()
    {
      return (dsBankDeposits.BankDepositsRow) this.NewRow();
    }

    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsBankDeposits.BankDepositsRow(builder);
    }

    protected override Type GetRowType() => typeof (dsBankDeposits.BankDepositsRow);

    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.BankDepositsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsBankDeposits.BankDepositsRowChangeEventHandler depositsRowChangedEvent = this.BankDepositsRowChangedEvent;
      if (depositsRowChangedEvent == null)
        return;
      depositsRowChangedEvent((object) this, new dsBankDeposits.BankDepositsRowChangeEvent((dsBankDeposits.BankDepositsRow) e.Row, e.Action));
    }

    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.BankDepositsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsBankDeposits.BankDepositsRowChangeEventHandler rowChangingEvent = this.BankDepositsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsBankDeposits.BankDepositsRowChangeEvent((dsBankDeposits.BankDepositsRow) e.Row, e.Action));
    }

    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.BankDepositsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsBankDeposits.BankDepositsRowChangeEventHandler depositsRowDeletedEvent = this.BankDepositsRowDeletedEvent;
      if (depositsRowDeletedEvent == null)
        return;
      depositsRowDeletedEvent((object) this, new dsBankDeposits.BankDepositsRowChangeEvent((dsBankDeposits.BankDepositsRow) e.Row, e.Action));
    }

    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.BankDepositsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsBankDeposits.BankDepositsRowChangeEventHandler rowDeletingEvent = this.BankDepositsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsBankDeposits.BankDepositsRowChangeEvent((dsBankDeposits.BankDepositsRow) e.Row, e.Action));
    }

    public void RemoveBankDepositsRow(dsBankDeposits.BankDepositsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }
  }

  [DebuggerStepThrough]
  public class BankDepositsRow : DataRow
  {
    private dsBankDeposits.BankDepositsDataTable tableBankDeposits;

    internal BankDepositsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableBankDeposits = (dsBankDeposits.BankDepositsDataTable) this.Table;
    }

    public string Remitter
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableBankDeposits.RemitterColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableBankDeposits.RemitterColumn] = (object) value;
    }

    public DateTime PostDate
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tableBankDeposits.PostDateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableBankDeposits.PostDateColumn] = (object) value;
    }

    public DateTime ReceivedDate
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tableBankDeposits.ReceivedDateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableBankDeposits.ReceivedDateColumn] = (object) value;
    }

    public DateTime DepositDate
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tableBankDeposits.DepositDateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableBankDeposits.DepositDateColumn] = (object) value;
    }

    public string CheckNumber
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableBankDeposits.CheckNumberColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableBankDeposits.CheckNumberColumn] = (object) value;
    }

    public Decimal Amount
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tableBankDeposits.AmountColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableBankDeposits.AmountColumn] = (object) value;
    }

    public string Comments
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableBankDeposits.CommentsColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableBankDeposits.CommentsColumn] = (object) value;
    }

    public string Bank
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableBankDeposits.BankColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableBankDeposits.BankColumn] = (object) value;
    }

    public string OffsetAccount
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableBankDeposits.OffsetAccountColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableBankDeposits.OffsetAccountColumn] = (object) value;
    }

    public bool IsRemitterNull() => this.IsNull(this.tableBankDeposits.RemitterColumn);

    public void SetRemitterNull()
    {
      this[this.tableBankDeposits.RemitterColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsPostDateNull() => this.IsNull(this.tableBankDeposits.PostDateColumn);

    public void SetPostDateNull()
    {
      this[this.tableBankDeposits.PostDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsReceivedDateNull() => this.IsNull(this.tableBankDeposits.ReceivedDateColumn);

    public void SetReceivedDateNull()
    {
      this[this.tableBankDeposits.ReceivedDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsDepositDateNull() => this.IsNull(this.tableBankDeposits.DepositDateColumn);

    public void SetDepositDateNull()
    {
      this[this.tableBankDeposits.DepositDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsCheckNumberNull() => this.IsNull(this.tableBankDeposits.CheckNumberColumn);

    public void SetCheckNumberNull()
    {
      this[this.tableBankDeposits.CheckNumberColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsAmountNull() => this.IsNull(this.tableBankDeposits.AmountColumn);

    public void SetAmountNull()
    {
      this[this.tableBankDeposits.AmountColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsCommentsNull() => this.IsNull(this.tableBankDeposits.CommentsColumn);

    public void SetCommentsNull()
    {
      this[this.tableBankDeposits.CommentsColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsBankNull() => this.IsNull(this.tableBankDeposits.BankColumn);

    public void SetBankNull()
    {
      this[this.tableBankDeposits.BankColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsOffsetAccountNull() => this.IsNull(this.tableBankDeposits.OffsetAccountColumn);

    public void SetOffsetAccountNull()
    {
      this[this.tableBankDeposits.OffsetAccountColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  [DebuggerStepThrough]
  public class BankDepositsRowChangeEvent : EventArgs
  {
    private dsBankDeposits.BankDepositsRow eventRow;
    private DataRowAction eventAction;

    public BankDepositsRowChangeEvent(dsBankDeposits.BankDepositsRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    public dsBankDeposits.BankDepositsRow Row => this.eventRow;

    public DataRowAction Action => this.eventAction;
  }
}
