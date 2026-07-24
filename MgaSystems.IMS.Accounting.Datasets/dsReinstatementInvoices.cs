// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.AccountingDatasets.dsReinstatementInvoices
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
public class dsReinstatementInvoices : DataSet
{
  private dsReinstatementInvoices.ReinStatementInvoicesDataTable tableReinStatementInvoices;

  public dsReinstatementInvoices()
  {
    this.InitClass();
    CollectionChangeEventHandler changeEventHandler = new CollectionChangeEventHandler(this.SchemaChanged);
    this.Tables.CollectionChanged += changeEventHandler;
    this.Relations.CollectionChanged += changeEventHandler;
  }

  protected dsReinstatementInvoices(SerializationInfo info, StreamingContext context)
  {
    string s = Conversions.ToString(info.GetValue("XmlSchema", typeof (string)));
    if (s != null)
    {
      DataSet dataSet = new DataSet();
      dataSet.ReadXmlSchema((XmlReader) new XmlTextReader((TextReader) new StringReader(s)));
      if (dataSet.Tables[nameof (ReinStatementInvoices)] != null)
        this.Tables.Add((DataTable) new dsReinstatementInvoices.ReinStatementInvoicesDataTable(dataSet.Tables[nameof (ReinStatementInvoices)]));
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
  public dsReinstatementInvoices.ReinStatementInvoicesDataTable ReinStatementInvoices
  {
    get => this.tableReinStatementInvoices;
  }

  public override DataSet Clone()
  {
    dsReinstatementInvoices reinstatementInvoices = (dsReinstatementInvoices) base.Clone();
    reinstatementInvoices.InitVars();
    return (DataSet) reinstatementInvoices;
  }

  protected override bool ShouldSerializeTables() => false;

  protected override bool ShouldSerializeRelations() => false;

  protected override void ReadXmlSerializable(XmlReader reader)
  {
    this.Reset();
    DataSet dataSet = new DataSet();
    int num = (int) dataSet.ReadXml(reader);
    if (dataSet.Tables["ReinStatementInvoices"] != null)
      this.Tables.Add((DataTable) new dsReinstatementInvoices.ReinStatementInvoicesDataTable(dataSet.Tables["ReinStatementInvoices"]));
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
    this.tableReinStatementInvoices = (dsReinstatementInvoices.ReinStatementInvoicesDataTable) this.Tables["ReinStatementInvoices"];
    if (this.tableReinStatementInvoices == null)
      return;
    this.tableReinStatementInvoices.InitVars();
  }

  private void InitClass()
  {
    this.DataSetName = nameof (dsReinstatementInvoices);
    this.Prefix = "";
    this.Namespace = "http://tempuri.org/dsReinstatementInvoices.xsd";
    this.Locale = new CultureInfo("en-US");
    this.CaseSensitive = false;
    this.EnforceConstraints = true;
    this.tableReinStatementInvoices = new dsReinstatementInvoices.ReinStatementInvoicesDataTable();
    this.Tables.Add((DataTable) this.tableReinStatementInvoices);
  }

  private bool ShouldSerializeReinStatementInvoices() => false;

  private void SchemaChanged(object sender, CollectionChangeEventArgs e)
  {
    if (e.Action != CollectionChangeAction.Remove)
      return;
    this.InitVars();
  }

  public delegate void ReinStatementInvoicesRowChangeEventHandler(
    object sender,
    dsReinstatementInvoices.ReinStatementInvoicesRowChangeEvent e);

  [DebuggerStepThrough]
  public class ReinStatementInvoicesDataTable : DataTable, IEnumerable
  {
    private DataColumn columninvoiceNum;
    private DataColumn columnofficeInvoiceNum;
    private DataColumn columnDueDate;
    private DataColumn columnAmtDue;
    private DataColumn columnAmtPaidNow;
    private DataColumn columnStatus;

    internal ReinStatementInvoicesDataTable()
      : base("ReinStatementInvoices")
    {
      this.InitClass();
    }

    internal ReinStatementInvoicesDataTable(DataTable table)
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

    internal DataColumn invoiceNumColumn => this.columninvoiceNum;

    internal DataColumn officeInvoiceNumColumn => this.columnofficeInvoiceNum;

    internal DataColumn DueDateColumn => this.columnDueDate;

    internal DataColumn AmtDueColumn => this.columnAmtDue;

    internal DataColumn AmtPaidNowColumn => this.columnAmtPaidNow;

    internal DataColumn StatusColumn => this.columnStatus;

    public dsReinstatementInvoices.ReinStatementInvoicesRow this[int index]
    {
      get => (dsReinstatementInvoices.ReinStatementInvoicesRow) this.Rows[index];
    }

    public event dsReinstatementInvoices.ReinStatementInvoicesRowChangeEventHandler ReinStatementInvoicesRowChanged;

    public event dsReinstatementInvoices.ReinStatementInvoicesRowChangeEventHandler ReinStatementInvoicesRowChanging;

    public event dsReinstatementInvoices.ReinStatementInvoicesRowChangeEventHandler ReinStatementInvoicesRowDeleted;

    public event dsReinstatementInvoices.ReinStatementInvoicesRowChangeEventHandler ReinStatementInvoicesRowDeleting;

    public void AddReinStatementInvoicesRow(
      dsReinstatementInvoices.ReinStatementInvoicesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    public dsReinstatementInvoices.ReinStatementInvoicesRow AddReinStatementInvoicesRow(
      int invoiceNum,
      string officeInvoiceNum,
      DateTime DueDate,
      Decimal AmtDue,
      Decimal AmtPaidNow,
      string Status)
    {
      dsReinstatementInvoices.ReinStatementInvoicesRow row = (dsReinstatementInvoices.ReinStatementInvoicesRow) this.NewRow();
      row.ItemArray = new object[6]
      {
        (object) invoiceNum,
        (object) officeInvoiceNum,
        (object) DueDate,
        (object) AmtDue,
        (object) AmtPaidNow,
        (object) Status
      };
      this.Rows.Add((DataRow) row);
      return row;
    }

    public IEnumerator GetEnumerator() => this.Rows.GetEnumerator();

    public override DataTable Clone()
    {
      dsReinstatementInvoices.ReinStatementInvoicesDataTable invoicesDataTable = (dsReinstatementInvoices.ReinStatementInvoicesDataTable) base.Clone();
      invoicesDataTable.InitVars();
      return (DataTable) invoicesDataTable;
    }

    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsReinstatementInvoices.ReinStatementInvoicesDataTable();
    }

    internal void InitVars()
    {
      this.columninvoiceNum = this.Columns["invoiceNum"];
      this.columnofficeInvoiceNum = this.Columns["officeInvoiceNum"];
      this.columnDueDate = this.Columns["DueDate"];
      this.columnAmtDue = this.Columns["AmtDue"];
      this.columnAmtPaidNow = this.Columns["AmtPaidNow"];
      this.columnStatus = this.Columns["Status"];
    }

    private void InitClass()
    {
      this.columninvoiceNum = new DataColumn("invoiceNum", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columninvoiceNum);
      this.columnofficeInvoiceNum = new DataColumn("officeInvoiceNum", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnofficeInvoiceNum);
      this.columnDueDate = new DataColumn("DueDate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDueDate);
      this.columnAmtDue = new DataColumn("AmtDue", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAmtDue);
      this.columnAmtPaidNow = new DataColumn("AmtPaidNow", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAmtPaidNow);
      this.columnStatus = new DataColumn("Status", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnStatus);
    }

    public dsReinstatementInvoices.ReinStatementInvoicesRow NewReinStatementInvoicesRow()
    {
      return (dsReinstatementInvoices.ReinStatementInvoicesRow) this.NewRow();
    }

    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsReinstatementInvoices.ReinStatementInvoicesRow(builder);
    }

    protected override Type GetRowType()
    {
      return typeof (dsReinstatementInvoices.ReinStatementInvoicesRow);
    }

    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.ReinStatementInvoicesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsReinstatementInvoices.ReinStatementInvoicesRowChangeEventHandler invoicesRowChangedEvent = this.ReinStatementInvoicesRowChangedEvent;
      if (invoicesRowChangedEvent == null)
        return;
      invoicesRowChangedEvent((object) this, new dsReinstatementInvoices.ReinStatementInvoicesRowChangeEvent((dsReinstatementInvoices.ReinStatementInvoicesRow) e.Row, e.Action));
    }

    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.ReinStatementInvoicesRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsReinstatementInvoices.ReinStatementInvoicesRowChangeEventHandler rowChangingEvent = this.ReinStatementInvoicesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsReinstatementInvoices.ReinStatementInvoicesRowChangeEvent((dsReinstatementInvoices.ReinStatementInvoicesRow) e.Row, e.Action));
    }

    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.ReinStatementInvoicesRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsReinstatementInvoices.ReinStatementInvoicesRowChangeEventHandler invoicesRowDeletedEvent = this.ReinStatementInvoicesRowDeletedEvent;
      if (invoicesRowDeletedEvent == null)
        return;
      invoicesRowDeletedEvent((object) this, new dsReinstatementInvoices.ReinStatementInvoicesRowChangeEvent((dsReinstatementInvoices.ReinStatementInvoicesRow) e.Row, e.Action));
    }

    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.ReinStatementInvoicesRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsReinstatementInvoices.ReinStatementInvoicesRowChangeEventHandler rowDeletingEvent = this.ReinStatementInvoicesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsReinstatementInvoices.ReinStatementInvoicesRowChangeEvent((dsReinstatementInvoices.ReinStatementInvoicesRow) e.Row, e.Action));
    }

    public void RemoveReinStatementInvoicesRow(
      dsReinstatementInvoices.ReinStatementInvoicesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }
  }

  [DebuggerStepThrough]
  public class ReinStatementInvoicesRow : DataRow
  {
    private dsReinstatementInvoices.ReinStatementInvoicesDataTable tableReinStatementInvoices;

    internal ReinStatementInvoicesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableReinStatementInvoices = (dsReinstatementInvoices.ReinStatementInvoicesDataTable) this.Table;
    }

    public int invoiceNum
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tableReinStatementInvoices.invoiceNumColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableReinStatementInvoices.invoiceNumColumn] = (object) value;
    }

    public string officeInvoiceNum
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableReinStatementInvoices.officeInvoiceNumColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableReinStatementInvoices.officeInvoiceNumColumn] = (object) value;
    }

    public DateTime DueDate
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tableReinStatementInvoices.DueDateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableReinStatementInvoices.DueDateColumn] = (object) value;
    }

    public Decimal AmtDue
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tableReinStatementInvoices.AmtDueColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableReinStatementInvoices.AmtDueColumn] = (object) value;
    }

    public Decimal AmtPaidNow
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tableReinStatementInvoices.AmtPaidNowColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableReinStatementInvoices.AmtPaidNowColumn] = (object) value;
    }

    public string Status
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableReinStatementInvoices.StatusColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableReinStatementInvoices.StatusColumn] = (object) value;
    }

    public bool IsinvoiceNumNull() => this.IsNull(this.tableReinStatementInvoices.invoiceNumColumn);

    public void SetinvoiceNumNull()
    {
      this[this.tableReinStatementInvoices.invoiceNumColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsofficeInvoiceNumNull()
    {
      return this.IsNull(this.tableReinStatementInvoices.officeInvoiceNumColumn);
    }

    public void SetofficeInvoiceNumNull()
    {
      this[this.tableReinStatementInvoices.officeInvoiceNumColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsDueDateNull() => this.IsNull(this.tableReinStatementInvoices.DueDateColumn);

    public void SetDueDateNull()
    {
      this[this.tableReinStatementInvoices.DueDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsAmtDueNull() => this.IsNull(this.tableReinStatementInvoices.AmtDueColumn);

    public void SetAmtDueNull()
    {
      this[this.tableReinStatementInvoices.AmtDueColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsAmtPaidNowNull() => this.IsNull(this.tableReinStatementInvoices.AmtPaidNowColumn);

    public void SetAmtPaidNowNull()
    {
      this[this.tableReinStatementInvoices.AmtPaidNowColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsStatusNull() => this.IsNull(this.tableReinStatementInvoices.StatusColumn);

    public void SetStatusNull()
    {
      this[this.tableReinStatementInvoices.StatusColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  [DebuggerStepThrough]
  public class ReinStatementInvoicesRowChangeEvent : EventArgs
  {
    private dsReinstatementInvoices.ReinStatementInvoicesRow eventRow;
    private DataRowAction eventAction;

    public ReinStatementInvoicesRowChangeEvent(
      dsReinstatementInvoices.ReinStatementInvoicesRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    public dsReinstatementInvoices.ReinStatementInvoicesRow Row => this.eventRow;

    public DataRowAction Action => this.eventAction;
  }
}
