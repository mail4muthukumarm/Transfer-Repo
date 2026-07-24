// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.AccountingDatasets.dsPOPaymentHistory
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
public class dsPOPaymentHistory : DataSet
{
  private dsPOPaymentHistory.PaymentsDataTable tablePayments;

  public dsPOPaymentHistory()
  {
    this.InitClass();
    CollectionChangeEventHandler changeEventHandler = new CollectionChangeEventHandler(this.SchemaChanged);
    this.Tables.CollectionChanged += changeEventHandler;
    this.Relations.CollectionChanged += changeEventHandler;
  }

  protected dsPOPaymentHistory(SerializationInfo info, StreamingContext context)
  {
    string s = Conversions.ToString(info.GetValue("XmlSchema", typeof (string)));
    if (s != null)
    {
      DataSet dataSet = new DataSet();
      dataSet.ReadXmlSchema((XmlReader) new XmlTextReader((TextReader) new StringReader(s)));
      if (dataSet.Tables[nameof (Payments)] != null)
        this.Tables.Add((DataTable) new dsPOPaymentHistory.PaymentsDataTable(dataSet.Tables[nameof (Payments)]));
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
  public dsPOPaymentHistory.PaymentsDataTable Payments => this.tablePayments;

  public override DataSet Clone()
  {
    dsPOPaymentHistory poPaymentHistory = (dsPOPaymentHistory) base.Clone();
    poPaymentHistory.InitVars();
    return (DataSet) poPaymentHistory;
  }

  protected override bool ShouldSerializeTables() => false;

  protected override bool ShouldSerializeRelations() => false;

  protected override void ReadXmlSerializable(XmlReader reader)
  {
    this.Reset();
    DataSet dataSet = new DataSet();
    int num = (int) dataSet.ReadXml(reader);
    if (dataSet.Tables["Payments"] != null)
      this.Tables.Add((DataTable) new dsPOPaymentHistory.PaymentsDataTable(dataSet.Tables["Payments"]));
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
    this.tablePayments = (dsPOPaymentHistory.PaymentsDataTable) this.Tables["Payments"];
    if (this.tablePayments == null)
      return;
    this.tablePayments.InitVars();
  }

  private void InitClass()
  {
    this.DataSetName = nameof (dsPOPaymentHistory);
    this.Prefix = "";
    this.Namespace = "http://tempuri.org/dsPOPaymentHistory.xsd";
    this.Locale = new CultureInfo("en-US");
    this.CaseSensitive = false;
    this.EnforceConstraints = true;
    this.tablePayments = new dsPOPaymentHistory.PaymentsDataTable();
    this.Tables.Add((DataTable) this.tablePayments);
  }

  private bool ShouldSerializePayments() => false;

  private void SchemaChanged(object sender, CollectionChangeEventArgs e)
  {
    if (e.Action != CollectionChangeAction.Remove)
      return;
    this.InitVars();
  }

  public delegate void PaymentsRowChangeEventHandler(
    object sender,
    dsPOPaymentHistory.PaymentsRowChangeEvent e);

  [DebuggerStepThrough]
  public class PaymentsDataTable : DataTable, IEnumerable
  {
    private DataColumn columnPostDate;
    private DataColumn columnCheckNumber;
    private DataColumn columnCheckAmount;
    private DataColumn columnEnteredBy;
    private DataColumn columnVoided;

    internal PaymentsDataTable()
      : base("Payments")
    {
      this.InitClass();
    }

    internal PaymentsDataTable(DataTable table)
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

    internal DataColumn PostDateColumn => this.columnPostDate;

    internal DataColumn CheckNumberColumn => this.columnCheckNumber;

    internal DataColumn CheckAmountColumn => this.columnCheckAmount;

    internal DataColumn EnteredByColumn => this.columnEnteredBy;

    internal DataColumn VoidedColumn => this.columnVoided;

    public dsPOPaymentHistory.PaymentsRow this[int index]
    {
      get => (dsPOPaymentHistory.PaymentsRow) this.Rows[index];
    }

    public event dsPOPaymentHistory.PaymentsRowChangeEventHandler PaymentsRowChanged;

    public event dsPOPaymentHistory.PaymentsRowChangeEventHandler PaymentsRowChanging;

    public event dsPOPaymentHistory.PaymentsRowChangeEventHandler PaymentsRowDeleted;

    public event dsPOPaymentHistory.PaymentsRowChangeEventHandler PaymentsRowDeleting;

    public void AddPaymentsRow(dsPOPaymentHistory.PaymentsRow row) => this.Rows.Add((DataRow) row);

    public dsPOPaymentHistory.PaymentsRow AddPaymentsRow(
      DateTime PostDate,
      string CheckNumber,
      Decimal CheckAmount,
      string EnteredBy,
      bool Voided)
    {
      dsPOPaymentHistory.PaymentsRow row = (dsPOPaymentHistory.PaymentsRow) this.NewRow();
      row.ItemArray = new object[5]
      {
        (object) PostDate,
        (object) CheckNumber,
        (object) CheckAmount,
        (object) EnteredBy,
        (object) Voided
      };
      this.Rows.Add((DataRow) row);
      return row;
    }

    public IEnumerator GetEnumerator() => this.Rows.GetEnumerator();

    public override DataTable Clone()
    {
      dsPOPaymentHistory.PaymentsDataTable paymentsDataTable = (dsPOPaymentHistory.PaymentsDataTable) base.Clone();
      paymentsDataTable.InitVars();
      return (DataTable) paymentsDataTable;
    }

    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsPOPaymentHistory.PaymentsDataTable();
    }

    internal void InitVars()
    {
      this.columnPostDate = this.Columns["PostDate"];
      this.columnCheckNumber = this.Columns["CheckNumber"];
      this.columnCheckAmount = this.Columns["CheckAmount"];
      this.columnEnteredBy = this.Columns["EnteredBy"];
      this.columnVoided = this.Columns["Voided"];
    }

    private void InitClass()
    {
      this.columnPostDate = new DataColumn("PostDate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPostDate);
      this.columnCheckNumber = new DataColumn("CheckNumber", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCheckNumber);
      this.columnCheckAmount = new DataColumn("CheckAmount", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCheckAmount);
      this.columnEnteredBy = new DataColumn("EnteredBy", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEnteredBy);
      this.columnVoided = new DataColumn("Voided", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnVoided);
    }

    public dsPOPaymentHistory.PaymentsRow NewPaymentsRow()
    {
      return (dsPOPaymentHistory.PaymentsRow) this.NewRow();
    }

    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsPOPaymentHistory.PaymentsRow(builder);
    }

    protected override Type GetRowType() => typeof (dsPOPaymentHistory.PaymentsRow);

    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.PaymentsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPOPaymentHistory.PaymentsRowChangeEventHandler paymentsRowChangedEvent = this.PaymentsRowChangedEvent;
      if (paymentsRowChangedEvent == null)
        return;
      paymentsRowChangedEvent((object) this, new dsPOPaymentHistory.PaymentsRowChangeEvent((dsPOPaymentHistory.PaymentsRow) e.Row, e.Action));
    }

    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.PaymentsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPOPaymentHistory.PaymentsRowChangeEventHandler rowChangingEvent = this.PaymentsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsPOPaymentHistory.PaymentsRowChangeEvent((dsPOPaymentHistory.PaymentsRow) e.Row, e.Action));
    }

    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.PaymentsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPOPaymentHistory.PaymentsRowChangeEventHandler paymentsRowDeletedEvent = this.PaymentsRowDeletedEvent;
      if (paymentsRowDeletedEvent == null)
        return;
      paymentsRowDeletedEvent((object) this, new dsPOPaymentHistory.PaymentsRowChangeEvent((dsPOPaymentHistory.PaymentsRow) e.Row, e.Action));
    }

    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.PaymentsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPOPaymentHistory.PaymentsRowChangeEventHandler rowDeletingEvent = this.PaymentsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsPOPaymentHistory.PaymentsRowChangeEvent((dsPOPaymentHistory.PaymentsRow) e.Row, e.Action));
    }

    public void RemovePaymentsRow(dsPOPaymentHistory.PaymentsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }
  }

  [DebuggerStepThrough]
  public class PaymentsRow : DataRow
  {
    private dsPOPaymentHistory.PaymentsDataTable tablePayments;

    internal PaymentsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablePayments = (dsPOPaymentHistory.PaymentsDataTable) this.Table;
    }

    public DateTime PostDate
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tablePayments.PostDateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePayments.PostDateColumn] = (object) value;
    }

    public string CheckNumber
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablePayments.CheckNumberColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePayments.CheckNumberColumn] = (object) value;
    }

    public Decimal CheckAmount
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tablePayments.CheckAmountColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePayments.CheckAmountColumn] = (object) value;
    }

    public string EnteredBy
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablePayments.EnteredByColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePayments.EnteredByColumn] = (object) value;
    }

    public bool Voided
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tablePayments.VoidedColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePayments.VoidedColumn] = (object) value;
    }

    public bool IsPostDateNull() => this.IsNull(this.tablePayments.PostDateColumn);

    public void SetPostDateNull()
    {
      this[this.tablePayments.PostDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsCheckNumberNull() => this.IsNull(this.tablePayments.CheckNumberColumn);

    public void SetCheckNumberNull()
    {
      this[this.tablePayments.CheckNumberColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsCheckAmountNull() => this.IsNull(this.tablePayments.CheckAmountColumn);

    public void SetCheckAmountNull()
    {
      this[this.tablePayments.CheckAmountColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsEnteredByNull() => this.IsNull(this.tablePayments.EnteredByColumn);

    public void SetEnteredByNull()
    {
      this[this.tablePayments.EnteredByColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsVoidedNull() => this.IsNull(this.tablePayments.VoidedColumn);

    public void SetVoidedNull()
    {
      this[this.tablePayments.VoidedColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  [DebuggerStepThrough]
  public class PaymentsRowChangeEvent : EventArgs
  {
    private dsPOPaymentHistory.PaymentsRow eventRow;
    private DataRowAction eventAction;

    public PaymentsRowChangeEvent(dsPOPaymentHistory.PaymentsRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    public dsPOPaymentHistory.PaymentsRow Row => this.eventRow;

    public DataRowAction Action => this.eventAction;
  }
}
