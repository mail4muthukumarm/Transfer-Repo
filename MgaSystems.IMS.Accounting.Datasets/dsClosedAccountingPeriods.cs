// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.AccountingDatasets.dsClosedAccountingPeriods
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
public class dsClosedAccountingPeriods : DataSet
{
  private dsClosedAccountingPeriods.AccountingPeriodsDataTable tableAccountingPeriods;

  public dsClosedAccountingPeriods()
  {
    this.InitClass();
    CollectionChangeEventHandler changeEventHandler = new CollectionChangeEventHandler(this.SchemaChanged);
    this.Tables.CollectionChanged += changeEventHandler;
    this.Relations.CollectionChanged += changeEventHandler;
  }

  protected dsClosedAccountingPeriods(SerializationInfo info, StreamingContext context)
  {
    string s = Conversions.ToString(info.GetValue("XmlSchema", typeof (string)));
    if (s != null)
    {
      DataSet dataSet = new DataSet();
      dataSet.ReadXmlSchema((XmlReader) new XmlTextReader((TextReader) new StringReader(s)));
      if (dataSet.Tables[nameof (AccountingPeriods)] != null)
        this.Tables.Add((DataTable) new dsClosedAccountingPeriods.AccountingPeriodsDataTable(dataSet.Tables[nameof (AccountingPeriods)]));
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
  public dsClosedAccountingPeriods.AccountingPeriodsDataTable AccountingPeriods
  {
    get => this.tableAccountingPeriods;
  }

  public override DataSet Clone()
  {
    dsClosedAccountingPeriods accountingPeriods = (dsClosedAccountingPeriods) base.Clone();
    accountingPeriods.InitVars();
    return (DataSet) accountingPeriods;
  }

  protected override bool ShouldSerializeTables() => false;

  protected override bool ShouldSerializeRelations() => false;

  protected override void ReadXmlSerializable(XmlReader reader)
  {
    this.Reset();
    DataSet dataSet = new DataSet();
    int num = (int) dataSet.ReadXml(reader);
    if (dataSet.Tables["AccountingPeriods"] != null)
      this.Tables.Add((DataTable) new dsClosedAccountingPeriods.AccountingPeriodsDataTable(dataSet.Tables["AccountingPeriods"]));
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
    this.tableAccountingPeriods = (dsClosedAccountingPeriods.AccountingPeriodsDataTable) this.Tables["AccountingPeriods"];
    if (this.tableAccountingPeriods == null)
      return;
    this.tableAccountingPeriods.InitVars();
  }

  private void InitClass()
  {
    this.DataSetName = nameof (dsClosedAccountingPeriods);
    this.Prefix = "";
    this.Namespace = "http://tempuri.org/dsClosedAccountingPeriods.xsd";
    this.Locale = new CultureInfo("en-US");
    this.CaseSensitive = false;
    this.EnforceConstraints = true;
    this.tableAccountingPeriods = new dsClosedAccountingPeriods.AccountingPeriodsDataTable();
    this.Tables.Add((DataTable) this.tableAccountingPeriods);
  }

  private bool ShouldSerializeAccountingPeriods() => false;

  private void SchemaChanged(object sender, CollectionChangeEventArgs e)
  {
    if (e.Action != CollectionChangeAction.Remove)
      return;
    this.InitVars();
  }

  public delegate void AccountingPeriodsRowChangeEventHandler(
    object sender,
    dsClosedAccountingPeriods.AccountingPeriodsRowChangeEvent e);

  [DebuggerStepThrough]
  public class AccountingPeriodsDataTable : DataTable, IEnumerable
  {
    private DataColumn columnGlCompanyId;
    private DataColumn columnLocation;
    private DataColumn columnClosedBy;
    private DataColumn columnClosedOn;
    private DataColumn columnCloseDate;

    internal AccountingPeriodsDataTable()
      : base("AccountingPeriods")
    {
      this.InitClass();
    }

    internal AccountingPeriodsDataTable(DataTable table)
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

    internal DataColumn GlCompanyIdColumn => this.columnGlCompanyId;

    internal DataColumn LocationColumn => this.columnLocation;

    internal DataColumn ClosedByColumn => this.columnClosedBy;

    internal DataColumn ClosedOnColumn => this.columnClosedOn;

    internal DataColumn CloseDateColumn => this.columnCloseDate;

    public dsClosedAccountingPeriods.AccountingPeriodsRow this[int index]
    {
      get => (dsClosedAccountingPeriods.AccountingPeriodsRow) this.Rows[index];
    }

    public event dsClosedAccountingPeriods.AccountingPeriodsRowChangeEventHandler AccountingPeriodsRowChanged;

    public event dsClosedAccountingPeriods.AccountingPeriodsRowChangeEventHandler AccountingPeriodsRowChanging;

    public event dsClosedAccountingPeriods.AccountingPeriodsRowChangeEventHandler AccountingPeriodsRowDeleted;

    public event dsClosedAccountingPeriods.AccountingPeriodsRowChangeEventHandler AccountingPeriodsRowDeleting;

    public void AddAccountingPeriodsRow(dsClosedAccountingPeriods.AccountingPeriodsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    public dsClosedAccountingPeriods.AccountingPeriodsRow AddAccountingPeriodsRow(
      int GlCompanyId,
      string Location,
      string ClosedBy,
      DateTime ClosedOn,
      DateTime CloseDate)
    {
      dsClosedAccountingPeriods.AccountingPeriodsRow row = (dsClosedAccountingPeriods.AccountingPeriodsRow) this.NewRow();
      row.ItemArray = new object[5]
      {
        (object) GlCompanyId,
        (object) Location,
        (object) ClosedBy,
        (object) ClosedOn,
        (object) CloseDate
      };
      this.Rows.Add((DataRow) row);
      return row;
    }

    public IEnumerator GetEnumerator() => this.Rows.GetEnumerator();

    public override DataTable Clone()
    {
      dsClosedAccountingPeriods.AccountingPeriodsDataTable periodsDataTable = (dsClosedAccountingPeriods.AccountingPeriodsDataTable) base.Clone();
      periodsDataTable.InitVars();
      return (DataTable) periodsDataTable;
    }

    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsClosedAccountingPeriods.AccountingPeriodsDataTable();
    }

    internal void InitVars()
    {
      this.columnGlCompanyId = this.Columns["GlCompanyId"];
      this.columnLocation = this.Columns["Location"];
      this.columnClosedBy = this.Columns["ClosedBy"];
      this.columnClosedOn = this.Columns["ClosedOn"];
      this.columnCloseDate = this.Columns["CloseDate"];
    }

    private void InitClass()
    {
      this.columnGlCompanyId = new DataColumn("GlCompanyId", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnGlCompanyId);
      this.columnLocation = new DataColumn("Location", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLocation);
      this.columnClosedBy = new DataColumn("ClosedBy", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnClosedBy);
      this.columnClosedOn = new DataColumn("ClosedOn", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnClosedOn);
      this.columnCloseDate = new DataColumn("CloseDate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCloseDate);
    }

    public dsClosedAccountingPeriods.AccountingPeriodsRow NewAccountingPeriodsRow()
    {
      return (dsClosedAccountingPeriods.AccountingPeriodsRow) this.NewRow();
    }

    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsClosedAccountingPeriods.AccountingPeriodsRow(builder);
    }

    protected override Type GetRowType() => typeof (dsClosedAccountingPeriods.AccountingPeriodsRow);

    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.AccountingPeriodsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsClosedAccountingPeriods.AccountingPeriodsRowChangeEventHandler periodsRowChangedEvent = this.AccountingPeriodsRowChangedEvent;
      if (periodsRowChangedEvent == null)
        return;
      periodsRowChangedEvent((object) this, new dsClosedAccountingPeriods.AccountingPeriodsRowChangeEvent((dsClosedAccountingPeriods.AccountingPeriodsRow) e.Row, e.Action));
    }

    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.AccountingPeriodsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsClosedAccountingPeriods.AccountingPeriodsRowChangeEventHandler rowChangingEvent = this.AccountingPeriodsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsClosedAccountingPeriods.AccountingPeriodsRowChangeEvent((dsClosedAccountingPeriods.AccountingPeriodsRow) e.Row, e.Action));
    }

    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.AccountingPeriodsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsClosedAccountingPeriods.AccountingPeriodsRowChangeEventHandler periodsRowDeletedEvent = this.AccountingPeriodsRowDeletedEvent;
      if (periodsRowDeletedEvent == null)
        return;
      periodsRowDeletedEvent((object) this, new dsClosedAccountingPeriods.AccountingPeriodsRowChangeEvent((dsClosedAccountingPeriods.AccountingPeriodsRow) e.Row, e.Action));
    }

    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.AccountingPeriodsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsClosedAccountingPeriods.AccountingPeriodsRowChangeEventHandler rowDeletingEvent = this.AccountingPeriodsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsClosedAccountingPeriods.AccountingPeriodsRowChangeEvent((dsClosedAccountingPeriods.AccountingPeriodsRow) e.Row, e.Action));
    }

    public void RemoveAccountingPeriodsRow(dsClosedAccountingPeriods.AccountingPeriodsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }
  }

  [DebuggerStepThrough]
  public class AccountingPeriodsRow : DataRow
  {
    private dsClosedAccountingPeriods.AccountingPeriodsDataTable tableAccountingPeriods;

    internal AccountingPeriodsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableAccountingPeriods = (dsClosedAccountingPeriods.AccountingPeriodsDataTable) this.Table;
    }

    public int GlCompanyId
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tableAccountingPeriods.GlCompanyIdColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableAccountingPeriods.GlCompanyIdColumn] = (object) value;
    }

    public string Location
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableAccountingPeriods.LocationColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableAccountingPeriods.LocationColumn] = (object) value;
    }

    public string ClosedBy
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableAccountingPeriods.ClosedByColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableAccountingPeriods.ClosedByColumn] = (object) value;
    }

    public DateTime ClosedOn
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tableAccountingPeriods.ClosedOnColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableAccountingPeriods.ClosedOnColumn] = (object) value;
    }

    public DateTime CloseDate
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tableAccountingPeriods.CloseDateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableAccountingPeriods.CloseDateColumn] = (object) value;
    }

    public bool IsGlCompanyIdNull() => this.IsNull(this.tableAccountingPeriods.GlCompanyIdColumn);

    public void SetGlCompanyIdNull()
    {
      this[this.tableAccountingPeriods.GlCompanyIdColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsLocationNull() => this.IsNull(this.tableAccountingPeriods.LocationColumn);

    public void SetLocationNull()
    {
      this[this.tableAccountingPeriods.LocationColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsClosedByNull() => this.IsNull(this.tableAccountingPeriods.ClosedByColumn);

    public void SetClosedByNull()
    {
      this[this.tableAccountingPeriods.ClosedByColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsClosedOnNull() => this.IsNull(this.tableAccountingPeriods.ClosedOnColumn);

    public void SetClosedOnNull()
    {
      this[this.tableAccountingPeriods.ClosedOnColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsCloseDateNull() => this.IsNull(this.tableAccountingPeriods.CloseDateColumn);

    public void SetCloseDateNull()
    {
      this[this.tableAccountingPeriods.CloseDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  [DebuggerStepThrough]
  public class AccountingPeriodsRowChangeEvent : EventArgs
  {
    private dsClosedAccountingPeriods.AccountingPeriodsRow eventRow;
    private DataRowAction eventAction;

    public AccountingPeriodsRowChangeEvent(
      dsClosedAccountingPeriods.AccountingPeriodsRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    public dsClosedAccountingPeriods.AccountingPeriodsRow Row => this.eventRow;

    public DataRowAction Action => this.eventAction;
  }
}
