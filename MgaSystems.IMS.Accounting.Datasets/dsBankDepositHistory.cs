// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.AccountingDatasets.dsBankDepositHistory
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
public class dsBankDepositHistory : DataSet
{
  private dsBankDepositHistory.DepositHeaderDataTable tableDepositHeader;

  public dsBankDepositHistory()
  {
    this.InitClass();
    CollectionChangeEventHandler changeEventHandler = new CollectionChangeEventHandler(this.SchemaChanged);
    this.Tables.CollectionChanged += changeEventHandler;
    this.Relations.CollectionChanged += changeEventHandler;
  }

  protected dsBankDepositHistory(SerializationInfo info, StreamingContext context)
  {
    string s = Conversions.ToString(info.GetValue("XmlSchema", typeof (string)));
    if (s != null)
    {
      DataSet dataSet = new DataSet();
      dataSet.ReadXmlSchema((XmlReader) new XmlTextReader((TextReader) new StringReader(s)));
      if (dataSet.Tables[nameof (DepositHeader)] != null)
        this.Tables.Add((DataTable) new dsBankDepositHistory.DepositHeaderDataTable(dataSet.Tables[nameof (DepositHeader)]));
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
  public dsBankDepositHistory.DepositHeaderDataTable DepositHeader => this.tableDepositHeader;

  public override DataSet Clone()
  {
    dsBankDepositHistory bankDepositHistory = (dsBankDepositHistory) base.Clone();
    bankDepositHistory.InitVars();
    return (DataSet) bankDepositHistory;
  }

  protected override bool ShouldSerializeTables() => false;

  protected override bool ShouldSerializeRelations() => false;

  protected override void ReadXmlSerializable(XmlReader reader)
  {
    this.Reset();
    DataSet dataSet = new DataSet();
    int num = (int) dataSet.ReadXml(reader);
    if (dataSet.Tables["DepositHeader"] != null)
      this.Tables.Add((DataTable) new dsBankDepositHistory.DepositHeaderDataTable(dataSet.Tables["DepositHeader"]));
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
    this.tableDepositHeader = (dsBankDepositHistory.DepositHeaderDataTable) this.Tables["DepositHeader"];
    if (this.tableDepositHeader == null)
      return;
    this.tableDepositHeader.InitVars();
  }

  private void InitClass()
  {
    this.DataSetName = nameof (dsBankDepositHistory);
    this.Prefix = "";
    this.Namespace = "http://tempuri.org/dsBankDepositHistory.xsd";
    this.Locale = new CultureInfo("en-US");
    this.CaseSensitive = false;
    this.EnforceConstraints = true;
    this.tableDepositHeader = new dsBankDepositHistory.DepositHeaderDataTable();
    this.Tables.Add((DataTable) this.tableDepositHeader);
  }

  private bool ShouldSerializeDepositHeader() => false;

  private void SchemaChanged(object sender, CollectionChangeEventArgs e)
  {
    if (e.Action != CollectionChangeAction.Remove)
      return;
    this.InitVars();
  }

  public delegate void DepositHeaderRowChangeEventHandler(
    object sender,
    dsBankDepositHistory.DepositHeaderRowChangeEvent e);

  [DebuggerStepThrough]
  public class DepositHeaderDataTable : DataTable, IEnumerable
  {
    private DataColumn columndepositId;
    private DataColumn columndepositDate;
    private DataColumn columnuserName;
    private DataColumn columnbankName;
    private DataColumn columndepositTotal;

    internal DepositHeaderDataTable()
      : base("DepositHeader")
    {
      this.InitClass();
    }

    internal DepositHeaderDataTable(DataTable table)
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

    internal DataColumn depositIdColumn => this.columndepositId;

    internal DataColumn depositDateColumn => this.columndepositDate;

    internal DataColumn userNameColumn => this.columnuserName;

    internal DataColumn bankNameColumn => this.columnbankName;

    internal DataColumn depositTotalColumn => this.columndepositTotal;

    public dsBankDepositHistory.DepositHeaderRow this[int index]
    {
      get => (dsBankDepositHistory.DepositHeaderRow) this.Rows[index];
    }

    public event dsBankDepositHistory.DepositHeaderRowChangeEventHandler DepositHeaderRowChanged;

    public event dsBankDepositHistory.DepositHeaderRowChangeEventHandler DepositHeaderRowChanging;

    public event dsBankDepositHistory.DepositHeaderRowChangeEventHandler DepositHeaderRowDeleted;

    public event dsBankDepositHistory.DepositHeaderRowChangeEventHandler DepositHeaderRowDeleting;

    public void AddDepositHeaderRow(dsBankDepositHistory.DepositHeaderRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    public dsBankDepositHistory.DepositHeaderRow AddDepositHeaderRow(
      long depositId,
      DateTime depositDate,
      string userName,
      string bankName,
      Decimal depositTotal)
    {
      dsBankDepositHistory.DepositHeaderRow row = (dsBankDepositHistory.DepositHeaderRow) this.NewRow();
      row.ItemArray = new object[5]
      {
        (object) depositId,
        (object) depositDate,
        (object) userName,
        (object) bankName,
        (object) depositTotal
      };
      this.Rows.Add((DataRow) row);
      return row;
    }

    public IEnumerator GetEnumerator() => this.Rows.GetEnumerator();

    public override DataTable Clone()
    {
      dsBankDepositHistory.DepositHeaderDataTable depositHeaderDataTable = (dsBankDepositHistory.DepositHeaderDataTable) base.Clone();
      depositHeaderDataTable.InitVars();
      return (DataTable) depositHeaderDataTable;
    }

    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsBankDepositHistory.DepositHeaderDataTable();
    }

    internal void InitVars()
    {
      this.columndepositId = this.Columns["depositId"];
      this.columndepositDate = this.Columns["depositDate"];
      this.columnuserName = this.Columns["userName"];
      this.columnbankName = this.Columns["bankName"];
      this.columndepositTotal = this.Columns["depositTotal"];
    }

    private void InitClass()
    {
      this.columndepositId = new DataColumn("depositId", typeof (long), (string) null, MappingType.Element);
      this.Columns.Add(this.columndepositId);
      this.columndepositDate = new DataColumn("depositDate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columndepositDate);
      this.columnuserName = new DataColumn("userName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnuserName);
      this.columnbankName = new DataColumn("bankName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnbankName);
      this.columndepositTotal = new DataColumn("depositTotal", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columndepositTotal);
    }

    public dsBankDepositHistory.DepositHeaderRow NewDepositHeaderRow()
    {
      return (dsBankDepositHistory.DepositHeaderRow) this.NewRow();
    }

    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsBankDepositHistory.DepositHeaderRow(builder);
    }

    protected override Type GetRowType() => typeof (dsBankDepositHistory.DepositHeaderRow);

    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.DepositHeaderRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsBankDepositHistory.DepositHeaderRowChangeEventHandler headerRowChangedEvent = this.DepositHeaderRowChangedEvent;
      if (headerRowChangedEvent == null)
        return;
      headerRowChangedEvent((object) this, new dsBankDepositHistory.DepositHeaderRowChangeEvent((dsBankDepositHistory.DepositHeaderRow) e.Row, e.Action));
    }

    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.DepositHeaderRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsBankDepositHistory.DepositHeaderRowChangeEventHandler rowChangingEvent = this.DepositHeaderRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsBankDepositHistory.DepositHeaderRowChangeEvent((dsBankDepositHistory.DepositHeaderRow) e.Row, e.Action));
    }

    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.DepositHeaderRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsBankDepositHistory.DepositHeaderRowChangeEventHandler headerRowDeletedEvent = this.DepositHeaderRowDeletedEvent;
      if (headerRowDeletedEvent == null)
        return;
      headerRowDeletedEvent((object) this, new dsBankDepositHistory.DepositHeaderRowChangeEvent((dsBankDepositHistory.DepositHeaderRow) e.Row, e.Action));
    }

    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.DepositHeaderRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsBankDepositHistory.DepositHeaderRowChangeEventHandler rowDeletingEvent = this.DepositHeaderRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsBankDepositHistory.DepositHeaderRowChangeEvent((dsBankDepositHistory.DepositHeaderRow) e.Row, e.Action));
    }

    public void RemoveDepositHeaderRow(dsBankDepositHistory.DepositHeaderRow row)
    {
      this.Rows.Remove((DataRow) row);
    }
  }

  [DebuggerStepThrough]
  public class DepositHeaderRow : DataRow
  {
    private dsBankDepositHistory.DepositHeaderDataTable tableDepositHeader;

    internal DepositHeaderRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableDepositHeader = (dsBankDepositHistory.DepositHeaderDataTable) this.Table;
    }

    public long depositId
    {
      get
      {
        try
        {
          return Conversions.ToLong(this[this.tableDepositHeader.depositIdColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableDepositHeader.depositIdColumn] = (object) value;
    }

    public DateTime depositDate
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tableDepositHeader.depositDateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableDepositHeader.depositDateColumn] = (object) value;
    }

    public string userName
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableDepositHeader.userNameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableDepositHeader.userNameColumn] = (object) value;
    }

    public string bankName
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableDepositHeader.bankNameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableDepositHeader.bankNameColumn] = (object) value;
    }

    public Decimal depositTotal
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tableDepositHeader.depositTotalColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableDepositHeader.depositTotalColumn] = (object) value;
    }

    public bool IsdepositIdNull() => this.IsNull(this.tableDepositHeader.depositIdColumn);

    public void SetdepositIdNull()
    {
      this[this.tableDepositHeader.depositIdColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsdepositDateNull() => this.IsNull(this.tableDepositHeader.depositDateColumn);

    public void SetdepositDateNull()
    {
      this[this.tableDepositHeader.depositDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsuserNameNull() => this.IsNull(this.tableDepositHeader.userNameColumn);

    public void SetuserNameNull()
    {
      this[this.tableDepositHeader.userNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsbankNameNull() => this.IsNull(this.tableDepositHeader.bankNameColumn);

    public void SetbankNameNull()
    {
      this[this.tableDepositHeader.bankNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsdepositTotalNull() => this.IsNull(this.tableDepositHeader.depositTotalColumn);

    public void SetdepositTotalNull()
    {
      this[this.tableDepositHeader.depositTotalColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  [DebuggerStepThrough]
  public class DepositHeaderRowChangeEvent : EventArgs
  {
    private dsBankDepositHistory.DepositHeaderRow eventRow;
    private DataRowAction eventAction;

    public DepositHeaderRowChangeEvent(
      dsBankDepositHistory.DepositHeaderRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    public dsBankDepositHistory.DepositHeaderRow Row => this.eventRow;

    public DataRowAction Action => this.eventAction;
  }
}
