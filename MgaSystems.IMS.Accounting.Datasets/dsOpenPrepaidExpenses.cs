// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.AccountingDatasets.dsOpenPrepaidExpenses
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
public class dsOpenPrepaidExpenses : DataSet
{
  private dsOpenPrepaidExpenses.OpenPrePaidDataTable tableOpenPrePaid;

  public dsOpenPrepaidExpenses()
  {
    this.InitClass();
    CollectionChangeEventHandler changeEventHandler = new CollectionChangeEventHandler(this.SchemaChanged);
    this.Tables.CollectionChanged += changeEventHandler;
    this.Relations.CollectionChanged += changeEventHandler;
  }

  protected dsOpenPrepaidExpenses(SerializationInfo info, StreamingContext context)
  {
    string s = Conversions.ToString(info.GetValue("XmlSchema", typeof (string)));
    if (s != null)
    {
      DataSet dataSet = new DataSet();
      dataSet.ReadXmlSchema((XmlReader) new XmlTextReader((TextReader) new StringReader(s)));
      if (dataSet.Tables[nameof (OpenPrePaid)] != null)
        this.Tables.Add((DataTable) new dsOpenPrepaidExpenses.OpenPrePaidDataTable(dataSet.Tables[nameof (OpenPrePaid)]));
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
  public dsOpenPrepaidExpenses.OpenPrePaidDataTable OpenPrePaid => this.tableOpenPrePaid;

  public override DataSet Clone()
  {
    dsOpenPrepaidExpenses openPrepaidExpenses = (dsOpenPrepaidExpenses) base.Clone();
    openPrepaidExpenses.InitVars();
    return (DataSet) openPrepaidExpenses;
  }

  protected override bool ShouldSerializeTables() => false;

  protected override bool ShouldSerializeRelations() => false;

  protected override void ReadXmlSerializable(XmlReader reader)
  {
    this.Reset();
    DataSet dataSet = new DataSet();
    int num = (int) dataSet.ReadXml(reader);
    if (dataSet.Tables["OpenPrePaid"] != null)
      this.Tables.Add((DataTable) new dsOpenPrepaidExpenses.OpenPrePaidDataTable(dataSet.Tables["OpenPrePaid"]));
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
    this.tableOpenPrePaid = (dsOpenPrepaidExpenses.OpenPrePaidDataTable) this.Tables["OpenPrePaid"];
    if (this.tableOpenPrePaid == null)
      return;
    this.tableOpenPrePaid.InitVars();
  }

  private void InitClass()
  {
    this.DataSetName = nameof (dsOpenPrepaidExpenses);
    this.Prefix = "";
    this.Namespace = "http://tempuri.org/dsOpenPrepaidExpenses.xsd";
    this.Locale = new CultureInfo("en-US");
    this.CaseSensitive = false;
    this.EnforceConstraints = true;
    this.tableOpenPrePaid = new dsOpenPrepaidExpenses.OpenPrePaidDataTable();
    this.Tables.Add((DataTable) this.tableOpenPrePaid);
  }

  private bool ShouldSerializeOpenPrePaid() => false;

  private void SchemaChanged(object sender, CollectionChangeEventArgs e)
  {
    if (e.Action != CollectionChangeAction.Remove)
      return;
    this.InitVars();
  }

  public delegate void OpenPrePaidRowChangeEventHandler(
    object sender,
    dsOpenPrepaidExpenses.OpenPrePaidRowChangeEvent e);

  [DebuggerStepThrough]
  public class OpenPrePaidDataTable : DataTable, IEnumerable
  {
    private DataColumn columnPoNum;
    private DataColumn columnPoDate;
    private DataColumn columnPayee;
    private DataColumn columnPaymentDueDate;
    private DataColumn columnGlCompanyId;
    private DataColumn columnLocation;

    internal OpenPrePaidDataTable()
      : base("OpenPrePaid")
    {
      this.InitClass();
    }

    internal OpenPrePaidDataTable(DataTable table)
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

    internal DataColumn PoNumColumn => this.columnPoNum;

    internal DataColumn PoDateColumn => this.columnPoDate;

    internal DataColumn PayeeColumn => this.columnPayee;

    internal DataColumn PaymentDueDateColumn => this.columnPaymentDueDate;

    internal DataColumn GlCompanyIdColumn => this.columnGlCompanyId;

    internal DataColumn LocationColumn => this.columnLocation;

    public dsOpenPrepaidExpenses.OpenPrePaidRow this[int index]
    {
      get => (dsOpenPrepaidExpenses.OpenPrePaidRow) this.Rows[index];
    }

    public event dsOpenPrepaidExpenses.OpenPrePaidRowChangeEventHandler OpenPrePaidRowChanged;

    public event dsOpenPrepaidExpenses.OpenPrePaidRowChangeEventHandler OpenPrePaidRowChanging;

    public event dsOpenPrepaidExpenses.OpenPrePaidRowChangeEventHandler OpenPrePaidRowDeleted;

    public event dsOpenPrepaidExpenses.OpenPrePaidRowChangeEventHandler OpenPrePaidRowDeleting;

    public void AddOpenPrePaidRow(dsOpenPrepaidExpenses.OpenPrePaidRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    public dsOpenPrepaidExpenses.OpenPrePaidRow AddOpenPrePaidRow(
      int PoNum,
      DateTime PoDate,
      string Payee,
      DateTime PaymentDueDate,
      int GlCompanyId,
      string Location)
    {
      dsOpenPrepaidExpenses.OpenPrePaidRow row = (dsOpenPrepaidExpenses.OpenPrePaidRow) this.NewRow();
      row.ItemArray = new object[6]
      {
        (object) PoNum,
        (object) PoDate,
        (object) Payee,
        (object) PaymentDueDate,
        (object) GlCompanyId,
        (object) Location
      };
      this.Rows.Add((DataRow) row);
      return row;
    }

    public IEnumerator GetEnumerator() => this.Rows.GetEnumerator();

    public override DataTable Clone()
    {
      dsOpenPrepaidExpenses.OpenPrePaidDataTable prePaidDataTable = (dsOpenPrepaidExpenses.OpenPrePaidDataTable) base.Clone();
      prePaidDataTable.InitVars();
      return (DataTable) prePaidDataTable;
    }

    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsOpenPrepaidExpenses.OpenPrePaidDataTable();
    }

    internal void InitVars()
    {
      this.columnPoNum = this.Columns["PoNum"];
      this.columnPoDate = this.Columns["PoDate"];
      this.columnPayee = this.Columns["Payee"];
      this.columnPaymentDueDate = this.Columns["PaymentDueDate"];
      this.columnGlCompanyId = this.Columns["GlCompanyId"];
      this.columnLocation = this.Columns["Location"];
    }

    private void InitClass()
    {
      this.columnPoNum = new DataColumn("PoNum", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPoNum);
      this.columnPoDate = new DataColumn("PoDate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPoDate);
      this.columnPayee = new DataColumn("Payee", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPayee);
      this.columnPaymentDueDate = new DataColumn("PaymentDueDate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPaymentDueDate);
      this.columnGlCompanyId = new DataColumn("GlCompanyId", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnGlCompanyId);
      this.columnLocation = new DataColumn("Location", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLocation);
    }

    public dsOpenPrepaidExpenses.OpenPrePaidRow NewOpenPrePaidRow()
    {
      return (dsOpenPrepaidExpenses.OpenPrePaidRow) this.NewRow();
    }

    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsOpenPrepaidExpenses.OpenPrePaidRow(builder);
    }

    protected override Type GetRowType() => typeof (dsOpenPrepaidExpenses.OpenPrePaidRow);

    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.OpenPrePaidRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsOpenPrepaidExpenses.OpenPrePaidRowChangeEventHandler paidRowChangedEvent = this.OpenPrePaidRowChangedEvent;
      if (paidRowChangedEvent == null)
        return;
      paidRowChangedEvent((object) this, new dsOpenPrepaidExpenses.OpenPrePaidRowChangeEvent((dsOpenPrepaidExpenses.OpenPrePaidRow) e.Row, e.Action));
    }

    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.OpenPrePaidRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsOpenPrepaidExpenses.OpenPrePaidRowChangeEventHandler rowChangingEvent = this.OpenPrePaidRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsOpenPrepaidExpenses.OpenPrePaidRowChangeEvent((dsOpenPrepaidExpenses.OpenPrePaidRow) e.Row, e.Action));
    }

    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.OpenPrePaidRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsOpenPrepaidExpenses.OpenPrePaidRowChangeEventHandler paidRowDeletedEvent = this.OpenPrePaidRowDeletedEvent;
      if (paidRowDeletedEvent == null)
        return;
      paidRowDeletedEvent((object) this, new dsOpenPrepaidExpenses.OpenPrePaidRowChangeEvent((dsOpenPrepaidExpenses.OpenPrePaidRow) e.Row, e.Action));
    }

    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.OpenPrePaidRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsOpenPrepaidExpenses.OpenPrePaidRowChangeEventHandler rowDeletingEvent = this.OpenPrePaidRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsOpenPrepaidExpenses.OpenPrePaidRowChangeEvent((dsOpenPrepaidExpenses.OpenPrePaidRow) e.Row, e.Action));
    }

    public void RemoveOpenPrePaidRow(dsOpenPrepaidExpenses.OpenPrePaidRow row)
    {
      this.Rows.Remove((DataRow) row);
    }
  }

  [DebuggerStepThrough]
  public class OpenPrePaidRow : DataRow
  {
    private dsOpenPrepaidExpenses.OpenPrePaidDataTable tableOpenPrePaid;

    internal OpenPrePaidRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableOpenPrePaid = (dsOpenPrepaidExpenses.OpenPrePaidDataTable) this.Table;
    }

    public int PoNum
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tableOpenPrePaid.PoNumColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableOpenPrePaid.PoNumColumn] = (object) value;
    }

    public DateTime PoDate
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tableOpenPrePaid.PoDateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableOpenPrePaid.PoDateColumn] = (object) value;
    }

    public string Payee
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableOpenPrePaid.PayeeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableOpenPrePaid.PayeeColumn] = (object) value;
    }

    public DateTime PaymentDueDate
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tableOpenPrePaid.PaymentDueDateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableOpenPrePaid.PaymentDueDateColumn] = (object) value;
    }

    public int GlCompanyId
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tableOpenPrePaid.GlCompanyIdColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableOpenPrePaid.GlCompanyIdColumn] = (object) value;
    }

    public string Location
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableOpenPrePaid.LocationColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableOpenPrePaid.LocationColumn] = (object) value;
    }

    public bool IsPoNumNull() => this.IsNull(this.tableOpenPrePaid.PoNumColumn);

    public void SetPoNumNull()
    {
      this[this.tableOpenPrePaid.PoNumColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsPoDateNull() => this.IsNull(this.tableOpenPrePaid.PoDateColumn);

    public void SetPoDateNull()
    {
      this[this.tableOpenPrePaid.PoDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsPayeeNull() => this.IsNull(this.tableOpenPrePaid.PayeeColumn);

    public void SetPayeeNull()
    {
      this[this.tableOpenPrePaid.PayeeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsPaymentDueDateNull() => this.IsNull(this.tableOpenPrePaid.PaymentDueDateColumn);

    public void SetPaymentDueDateNull()
    {
      this[this.tableOpenPrePaid.PaymentDueDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsGlCompanyIdNull() => this.IsNull(this.tableOpenPrePaid.GlCompanyIdColumn);

    public void SetGlCompanyIdNull()
    {
      this[this.tableOpenPrePaid.GlCompanyIdColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsLocationNull() => this.IsNull(this.tableOpenPrePaid.LocationColumn);

    public void SetLocationNull()
    {
      this[this.tableOpenPrePaid.LocationColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  [DebuggerStepThrough]
  public class OpenPrePaidRowChangeEvent : EventArgs
  {
    private dsOpenPrepaidExpenses.OpenPrePaidRow eventRow;
    private DataRowAction eventAction;

    public OpenPrePaidRowChangeEvent(dsOpenPrepaidExpenses.OpenPrePaidRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    public dsOpenPrepaidExpenses.OpenPrePaidRow Row => this.eventRow;

    public DataRowAction Action => this.eventAction;
  }
}
