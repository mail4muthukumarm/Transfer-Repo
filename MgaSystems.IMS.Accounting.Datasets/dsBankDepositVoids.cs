// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.AccountingDatasets.dsBankDepositVoids
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
public class dsBankDepositVoids : DataSet
{
  private dsBankDepositVoids.CashReceiptsDataTable tableCashReceipts;

  public dsBankDepositVoids()
  {
    this.InitClass();
    CollectionChangeEventHandler changeEventHandler = new CollectionChangeEventHandler(this.SchemaChanged);
    this.Tables.CollectionChanged += changeEventHandler;
    this.Relations.CollectionChanged += changeEventHandler;
  }

  protected dsBankDepositVoids(SerializationInfo info, StreamingContext context)
  {
    string s = Conversions.ToString(info.GetValue("XmlSchema", typeof (string)));
    if (s != null)
    {
      DataSet dataSet = new DataSet();
      dataSet.ReadXmlSchema((XmlReader) new XmlTextReader((TextReader) new StringReader(s)));
      if (dataSet.Tables[nameof (CashReceipts)] != null)
        this.Tables.Add((DataTable) new dsBankDepositVoids.CashReceiptsDataTable(dataSet.Tables[nameof (CashReceipts)]));
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
  public dsBankDepositVoids.CashReceiptsDataTable CashReceipts => this.tableCashReceipts;

  public override DataSet Clone()
  {
    dsBankDepositVoids bankDepositVoids = (dsBankDepositVoids) base.Clone();
    bankDepositVoids.InitVars();
    return (DataSet) bankDepositVoids;
  }

  protected override bool ShouldSerializeTables() => false;

  protected override bool ShouldSerializeRelations() => false;

  protected override void ReadXmlSerializable(XmlReader reader)
  {
    this.Reset();
    DataSet dataSet = new DataSet();
    int num = (int) dataSet.ReadXml(reader);
    if (dataSet.Tables["CashReceipts"] != null)
      this.Tables.Add((DataTable) new dsBankDepositVoids.CashReceiptsDataTable(dataSet.Tables["CashReceipts"]));
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
    this.tableCashReceipts = (dsBankDepositVoids.CashReceiptsDataTable) this.Tables["CashReceipts"];
    if (this.tableCashReceipts == null)
      return;
    this.tableCashReceipts.InitVars();
  }

  private void InitClass()
  {
    this.DataSetName = nameof (dsBankDepositVoids);
    this.Prefix = "";
    this.Namespace = "http://tempuri.org/dsBankDepositVoids.xsd";
    this.Locale = new CultureInfo("en-US");
    this.CaseSensitive = false;
    this.EnforceConstraints = true;
    this.tableCashReceipts = new dsBankDepositVoids.CashReceiptsDataTable();
    this.Tables.Add((DataTable) this.tableCashReceipts);
  }

  private bool ShouldSerializeCashReceipts() => false;

  private void SchemaChanged(object sender, CollectionChangeEventArgs e)
  {
    if (e.Action != CollectionChangeAction.Remove)
      return;
    this.InitVars();
  }

  public delegate void CashReceiptsRowChangeEventHandler(
    object sender,
    dsBankDepositVoids.CashReceiptsRowChangeEvent e);

  [DebuggerStepThrough]
  public class CashReceiptsDataTable : DataTable, IEnumerable
  {
    private DataColumn columntransactnum;
    private DataColumn columnpostDate;
    private DataColumn columnRemitter;
    private DataColumn columnCheckNumber;
    private DataColumn columnAmount;

    internal CashReceiptsDataTable()
      : base("CashReceipts")
    {
      this.InitClass();
    }

    internal CashReceiptsDataTable(DataTable table)
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

    internal DataColumn transactnumColumn => this.columntransactnum;

    internal DataColumn postDateColumn => this.columnpostDate;

    internal DataColumn RemitterColumn => this.columnRemitter;

    internal DataColumn CheckNumberColumn => this.columnCheckNumber;

    internal DataColumn AmountColumn => this.columnAmount;

    public dsBankDepositVoids.CashReceiptsRow this[int index]
    {
      get => (dsBankDepositVoids.CashReceiptsRow) this.Rows[index];
    }

    public event dsBankDepositVoids.CashReceiptsRowChangeEventHandler CashReceiptsRowChanged;

    public event dsBankDepositVoids.CashReceiptsRowChangeEventHandler CashReceiptsRowChanging;

    public event dsBankDepositVoids.CashReceiptsRowChangeEventHandler CashReceiptsRowDeleted;

    public event dsBankDepositVoids.CashReceiptsRowChangeEventHandler CashReceiptsRowDeleting;

    public void AddCashReceiptsRow(dsBankDepositVoids.CashReceiptsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    public dsBankDepositVoids.CashReceiptsRow AddCashReceiptsRow(
      int transactnum,
      DateTime postDate,
      string Remitter,
      string CheckNumber,
      Decimal Amount)
    {
      dsBankDepositVoids.CashReceiptsRow row = (dsBankDepositVoids.CashReceiptsRow) this.NewRow();
      row.ItemArray = new object[5]
      {
        (object) transactnum,
        (object) postDate,
        (object) Remitter,
        (object) CheckNumber,
        (object) Amount
      };
      this.Rows.Add((DataRow) row);
      return row;
    }

    public IEnumerator GetEnumerator() => this.Rows.GetEnumerator();

    public override DataTable Clone()
    {
      dsBankDepositVoids.CashReceiptsDataTable receiptsDataTable = (dsBankDepositVoids.CashReceiptsDataTable) base.Clone();
      receiptsDataTable.InitVars();
      return (DataTable) receiptsDataTable;
    }

    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsBankDepositVoids.CashReceiptsDataTable();
    }

    internal void InitVars()
    {
      this.columntransactnum = this.Columns["transactnum"];
      this.columnpostDate = this.Columns["postDate"];
      this.columnRemitter = this.Columns["Remitter"];
      this.columnCheckNumber = this.Columns["CheckNumber"];
      this.columnAmount = this.Columns["Amount"];
    }

    private void InitClass()
    {
      this.columntransactnum = new DataColumn("transactnum", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columntransactnum);
      this.columnpostDate = new DataColumn("postDate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnpostDate);
      this.columnRemitter = new DataColumn("Remitter", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnRemitter);
      this.columnCheckNumber = new DataColumn("CheckNumber", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCheckNumber);
      this.columnAmount = new DataColumn("Amount", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAmount);
    }

    public dsBankDepositVoids.CashReceiptsRow NewCashReceiptsRow()
    {
      return (dsBankDepositVoids.CashReceiptsRow) this.NewRow();
    }

    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsBankDepositVoids.CashReceiptsRow(builder);
    }

    protected override Type GetRowType() => typeof (dsBankDepositVoids.CashReceiptsRow);

    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.CashReceiptsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsBankDepositVoids.CashReceiptsRowChangeEventHandler receiptsRowChangedEvent = this.CashReceiptsRowChangedEvent;
      if (receiptsRowChangedEvent == null)
        return;
      receiptsRowChangedEvent((object) this, new dsBankDepositVoids.CashReceiptsRowChangeEvent((dsBankDepositVoids.CashReceiptsRow) e.Row, e.Action));
    }

    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.CashReceiptsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsBankDepositVoids.CashReceiptsRowChangeEventHandler rowChangingEvent = this.CashReceiptsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsBankDepositVoids.CashReceiptsRowChangeEvent((dsBankDepositVoids.CashReceiptsRow) e.Row, e.Action));
    }

    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.CashReceiptsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsBankDepositVoids.CashReceiptsRowChangeEventHandler receiptsRowDeletedEvent = this.CashReceiptsRowDeletedEvent;
      if (receiptsRowDeletedEvent == null)
        return;
      receiptsRowDeletedEvent((object) this, new dsBankDepositVoids.CashReceiptsRowChangeEvent((dsBankDepositVoids.CashReceiptsRow) e.Row, e.Action));
    }

    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.CashReceiptsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsBankDepositVoids.CashReceiptsRowChangeEventHandler rowDeletingEvent = this.CashReceiptsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsBankDepositVoids.CashReceiptsRowChangeEvent((dsBankDepositVoids.CashReceiptsRow) e.Row, e.Action));
    }

    public void RemoveCashReceiptsRow(dsBankDepositVoids.CashReceiptsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }
  }

  [DebuggerStepThrough]
  public class CashReceiptsRow : DataRow
  {
    private dsBankDepositVoids.CashReceiptsDataTable tableCashReceipts;

    internal CashReceiptsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableCashReceipts = (dsBankDepositVoids.CashReceiptsDataTable) this.Table;
    }

    public int transactnum
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tableCashReceipts.transactnumColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableCashReceipts.transactnumColumn] = (object) value;
    }

    public DateTime postDate
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tableCashReceipts.postDateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableCashReceipts.postDateColumn] = (object) value;
    }

    public string Remitter
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableCashReceipts.RemitterColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableCashReceipts.RemitterColumn] = (object) value;
    }

    public string CheckNumber
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableCashReceipts.CheckNumberColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableCashReceipts.CheckNumberColumn] = (object) value;
    }

    public Decimal Amount
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tableCashReceipts.AmountColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableCashReceipts.AmountColumn] = (object) value;
    }

    public bool IstransactnumNull() => this.IsNull(this.tableCashReceipts.transactnumColumn);

    public void SettransactnumNull()
    {
      this[this.tableCashReceipts.transactnumColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IspostDateNull() => this.IsNull(this.tableCashReceipts.postDateColumn);

    public void SetpostDateNull()
    {
      this[this.tableCashReceipts.postDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsRemitterNull() => this.IsNull(this.tableCashReceipts.RemitterColumn);

    public void SetRemitterNull()
    {
      this[this.tableCashReceipts.RemitterColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsCheckNumberNull() => this.IsNull(this.tableCashReceipts.CheckNumberColumn);

    public void SetCheckNumberNull()
    {
      this[this.tableCashReceipts.CheckNumberColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsAmountNull() => this.IsNull(this.tableCashReceipts.AmountColumn);

    public void SetAmountNull()
    {
      this[this.tableCashReceipts.AmountColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  [DebuggerStepThrough]
  public class CashReceiptsRowChangeEvent : EventArgs
  {
    private dsBankDepositVoids.CashReceiptsRow eventRow;
    private DataRowAction eventAction;

    public CashReceiptsRowChangeEvent(dsBankDepositVoids.CashReceiptsRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    public dsBankDepositVoids.CashReceiptsRow Row => this.eventRow;

    public DataRowAction Action => this.eventAction;
  }
}
