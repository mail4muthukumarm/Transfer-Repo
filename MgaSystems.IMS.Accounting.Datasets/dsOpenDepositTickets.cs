// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.AccountingDatasets.dsOpenDepositTickets
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
public class dsOpenDepositTickets : DataSet
{
  private dsOpenDepositTickets.DepositTicketsDataTable tableDepositTickets;

  public dsOpenDepositTickets()
  {
    this.InitClass();
    CollectionChangeEventHandler changeEventHandler = new CollectionChangeEventHandler(this.SchemaChanged);
    this.Tables.CollectionChanged += changeEventHandler;
    this.Relations.CollectionChanged += changeEventHandler;
  }

  protected dsOpenDepositTickets(SerializationInfo info, StreamingContext context)
  {
    string s = Conversions.ToString(info.GetValue("XmlSchema", typeof (string)));
    if (s != null)
    {
      DataSet dataSet = new DataSet();
      dataSet.ReadXmlSchema((XmlReader) new XmlTextReader((TextReader) new StringReader(s)));
      if (dataSet.Tables[nameof (DepositTickets)] != null)
        this.Tables.Add((DataTable) new dsOpenDepositTickets.DepositTicketsDataTable(dataSet.Tables[nameof (DepositTickets)]));
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
  public dsOpenDepositTickets.DepositTicketsDataTable DepositTickets => this.tableDepositTickets;

  public override DataSet Clone()
  {
    dsOpenDepositTickets openDepositTickets = (dsOpenDepositTickets) base.Clone();
    openDepositTickets.InitVars();
    return (DataSet) openDepositTickets;
  }

  protected override bool ShouldSerializeTables() => false;

  protected override bool ShouldSerializeRelations() => false;

  protected override void ReadXmlSerializable(XmlReader reader)
  {
    this.Reset();
    DataSet dataSet = new DataSet();
    int num = (int) dataSet.ReadXml(reader);
    if (dataSet.Tables["DepositTickets"] != null)
      this.Tables.Add((DataTable) new dsOpenDepositTickets.DepositTicketsDataTable(dataSet.Tables["DepositTickets"]));
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
    this.tableDepositTickets = (dsOpenDepositTickets.DepositTicketsDataTable) this.Tables["DepositTickets"];
    if (this.tableDepositTickets == null)
      return;
    this.tableDepositTickets.InitVars();
  }

  private void InitClass()
  {
    this.DataSetName = nameof (dsOpenDepositTickets);
    this.Prefix = "";
    this.Namespace = "http://tempuri.org/dsOpenDepositTickets.xsd";
    this.Locale = new CultureInfo("en-US");
    this.CaseSensitive = false;
    this.EnforceConstraints = true;
    this.tableDepositTickets = new dsOpenDepositTickets.DepositTicketsDataTable();
    this.Tables.Add((DataTable) this.tableDepositTickets);
  }

  private bool ShouldSerializeDepositTickets() => false;

  private void SchemaChanged(object sender, CollectionChangeEventArgs e)
  {
    if (e.Action != CollectionChangeAction.Remove)
      return;
    this.InitVars();
  }

  public delegate void DepositTicketsRowChangeEventHandler(
    object sender,
    dsOpenDepositTickets.DepositTicketsRowChangeEvent e);

  [DebuggerStepThrough]
  public class DepositTicketsDataTable : DataTable, IEnumerable
  {
    private DataColumn columnDepositId;
    private DataColumn columnDepositDate;
    private DataColumn columnUserGuid;
    private DataColumn columnUserName;
    private DataColumn columnDepositReference;
    private DataColumn columnCurrentAmount;
    private DataColumn columnBankGL;

    internal DepositTicketsDataTable()
      : base("DepositTickets")
    {
      this.InitClass();
    }

    internal DepositTicketsDataTable(DataTable table)
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

    internal DataColumn DepositIdColumn => this.columnDepositId;

    internal DataColumn DepositDateColumn => this.columnDepositDate;

    internal DataColumn UserGuidColumn => this.columnUserGuid;

    internal DataColumn UserNameColumn => this.columnUserName;

    internal DataColumn DepositReferenceColumn => this.columnDepositReference;

    internal DataColumn CurrentAmountColumn => this.columnCurrentAmount;

    internal DataColumn BankGLColumn => this.columnBankGL;

    public dsOpenDepositTickets.DepositTicketsRow this[int index]
    {
      get => (dsOpenDepositTickets.DepositTicketsRow) this.Rows[index];
    }

    public event dsOpenDepositTickets.DepositTicketsRowChangeEventHandler DepositTicketsRowChanged;

    public event dsOpenDepositTickets.DepositTicketsRowChangeEventHandler DepositTicketsRowChanging;

    public event dsOpenDepositTickets.DepositTicketsRowChangeEventHandler DepositTicketsRowDeleted;

    public event dsOpenDepositTickets.DepositTicketsRowChangeEventHandler DepositTicketsRowDeleting;

    public void AddDepositTicketsRow(dsOpenDepositTickets.DepositTicketsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    public dsOpenDepositTickets.DepositTicketsRow AddDepositTicketsRow(
      int DepositId,
      DateTime DepositDate,
      string UserGuid,
      string UserName,
      string DepositReference,
      Decimal CurrentAmount,
      int BankGL)
    {
      dsOpenDepositTickets.DepositTicketsRow row = (dsOpenDepositTickets.DepositTicketsRow) this.NewRow();
      row.ItemArray = new object[7]
      {
        (object) DepositId,
        (object) DepositDate,
        (object) UserGuid,
        (object) UserName,
        (object) DepositReference,
        (object) CurrentAmount,
        (object) BankGL
      };
      this.Rows.Add((DataRow) row);
      return row;
    }

    public IEnumerator GetEnumerator() => this.Rows.GetEnumerator();

    public override DataTable Clone()
    {
      dsOpenDepositTickets.DepositTicketsDataTable ticketsDataTable = (dsOpenDepositTickets.DepositTicketsDataTable) base.Clone();
      ticketsDataTable.InitVars();
      return (DataTable) ticketsDataTable;
    }

    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsOpenDepositTickets.DepositTicketsDataTable();
    }

    internal void InitVars()
    {
      this.columnDepositId = this.Columns["DepositId"];
      this.columnDepositDate = this.Columns["DepositDate"];
      this.columnUserGuid = this.Columns["UserGuid"];
      this.columnUserName = this.Columns["UserName"];
      this.columnDepositReference = this.Columns["DepositReference"];
      this.columnCurrentAmount = this.Columns["CurrentAmount"];
      this.columnBankGL = this.Columns["BankGL"];
    }

    private void InitClass()
    {
      this.columnDepositId = new DataColumn("DepositId", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDepositId);
      this.columnDepositDate = new DataColumn("DepositDate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDepositDate);
      this.columnUserGuid = new DataColumn("UserGuid", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnUserGuid);
      this.columnUserName = new DataColumn("UserName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnUserName);
      this.columnDepositReference = new DataColumn("DepositReference", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDepositReference);
      this.columnCurrentAmount = new DataColumn("CurrentAmount", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCurrentAmount);
      this.columnBankGL = new DataColumn("BankGL", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnBankGL);
    }

    public dsOpenDepositTickets.DepositTicketsRow NewDepositTicketsRow()
    {
      return (dsOpenDepositTickets.DepositTicketsRow) this.NewRow();
    }

    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsOpenDepositTickets.DepositTicketsRow(builder);
    }

    protected override Type GetRowType() => typeof (dsOpenDepositTickets.DepositTicketsRow);

    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.DepositTicketsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsOpenDepositTickets.DepositTicketsRowChangeEventHandler ticketsRowChangedEvent = this.DepositTicketsRowChangedEvent;
      if (ticketsRowChangedEvent == null)
        return;
      ticketsRowChangedEvent((object) this, new dsOpenDepositTickets.DepositTicketsRowChangeEvent((dsOpenDepositTickets.DepositTicketsRow) e.Row, e.Action));
    }

    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.DepositTicketsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsOpenDepositTickets.DepositTicketsRowChangeEventHandler rowChangingEvent = this.DepositTicketsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsOpenDepositTickets.DepositTicketsRowChangeEvent((dsOpenDepositTickets.DepositTicketsRow) e.Row, e.Action));
    }

    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.DepositTicketsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsOpenDepositTickets.DepositTicketsRowChangeEventHandler ticketsRowDeletedEvent = this.DepositTicketsRowDeletedEvent;
      if (ticketsRowDeletedEvent == null)
        return;
      ticketsRowDeletedEvent((object) this, new dsOpenDepositTickets.DepositTicketsRowChangeEvent((dsOpenDepositTickets.DepositTicketsRow) e.Row, e.Action));
    }

    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.DepositTicketsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsOpenDepositTickets.DepositTicketsRowChangeEventHandler rowDeletingEvent = this.DepositTicketsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsOpenDepositTickets.DepositTicketsRowChangeEvent((dsOpenDepositTickets.DepositTicketsRow) e.Row, e.Action));
    }

    public void RemoveDepositTicketsRow(dsOpenDepositTickets.DepositTicketsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }
  }

  [DebuggerStepThrough]
  public class DepositTicketsRow : DataRow
  {
    private dsOpenDepositTickets.DepositTicketsDataTable tableDepositTickets;

    internal DepositTicketsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableDepositTickets = (dsOpenDepositTickets.DepositTicketsDataTable) this.Table;
    }

    public int DepositId
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tableDepositTickets.DepositIdColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableDepositTickets.DepositIdColumn] = (object) value;
    }

    public DateTime DepositDate
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tableDepositTickets.DepositDateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableDepositTickets.DepositDateColumn] = (object) value;
    }

    public string UserGuid
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableDepositTickets.UserGuidColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableDepositTickets.UserGuidColumn] = (object) value;
    }

    public string UserName
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableDepositTickets.UserNameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableDepositTickets.UserNameColumn] = (object) value;
    }

    public string DepositReference
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableDepositTickets.DepositReferenceColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableDepositTickets.DepositReferenceColumn] = (object) value;
    }

    public Decimal CurrentAmount
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tableDepositTickets.CurrentAmountColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableDepositTickets.CurrentAmountColumn] = (object) value;
    }

    public int BankGL
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tableDepositTickets.BankGLColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableDepositTickets.BankGLColumn] = (object) value;
    }

    public bool IsDepositIdNull() => this.IsNull(this.tableDepositTickets.DepositIdColumn);

    public void SetDepositIdNull()
    {
      this[this.tableDepositTickets.DepositIdColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsDepositDateNull() => this.IsNull(this.tableDepositTickets.DepositDateColumn);

    public void SetDepositDateNull()
    {
      this[this.tableDepositTickets.DepositDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsUserGuidNull() => this.IsNull(this.tableDepositTickets.UserGuidColumn);

    public void SetUserGuidNull()
    {
      this[this.tableDepositTickets.UserGuidColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsUserNameNull() => this.IsNull(this.tableDepositTickets.UserNameColumn);

    public void SetUserNameNull()
    {
      this[this.tableDepositTickets.UserNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsDepositReferenceNull()
    {
      return this.IsNull(this.tableDepositTickets.DepositReferenceColumn);
    }

    public void SetDepositReferenceNull()
    {
      this[this.tableDepositTickets.DepositReferenceColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsCurrentAmountNull() => this.IsNull(this.tableDepositTickets.CurrentAmountColumn);

    public void SetCurrentAmountNull()
    {
      this[this.tableDepositTickets.CurrentAmountColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsBankGLNull() => this.IsNull(this.tableDepositTickets.BankGLColumn);

    public void SetBankGLNull()
    {
      this[this.tableDepositTickets.BankGLColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  [DebuggerStepThrough]
  public class DepositTicketsRowChangeEvent : EventArgs
  {
    private dsOpenDepositTickets.DepositTicketsRow eventRow;
    private DataRowAction eventAction;

    public DepositTicketsRowChangeEvent(
      dsOpenDepositTickets.DepositTicketsRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    public dsOpenDepositTickets.DepositTicketsRow Row => this.eventRow;

    public DataRowAction Action => this.eventAction;
  }
}
