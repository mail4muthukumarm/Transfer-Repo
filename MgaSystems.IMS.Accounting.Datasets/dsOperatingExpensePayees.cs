// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.AccountingDatasets.dsOperatingExpensePayees
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
public class dsOperatingExpensePayees : DataSet
{
  private dsOperatingExpensePayees.PayeesListDataTable tablePayeesList;

  public dsOperatingExpensePayees()
  {
    this.InitClass();
    CollectionChangeEventHandler changeEventHandler = new CollectionChangeEventHandler(this.SchemaChanged);
    this.Tables.CollectionChanged += changeEventHandler;
    this.Relations.CollectionChanged += changeEventHandler;
  }

  protected dsOperatingExpensePayees(SerializationInfo info, StreamingContext context)
  {
    string s = Conversions.ToString(info.GetValue("XmlSchema", typeof (string)));
    if (s != null)
    {
      DataSet dataSet = new DataSet();
      dataSet.ReadXmlSchema((XmlReader) new XmlTextReader((TextReader) new StringReader(s)));
      if (dataSet.Tables[nameof (PayeesList)] != null)
        this.Tables.Add((DataTable) new dsOperatingExpensePayees.PayeesListDataTable(dataSet.Tables[nameof (PayeesList)]));
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
  public dsOperatingExpensePayees.PayeesListDataTable PayeesList => this.tablePayeesList;

  public override DataSet Clone()
  {
    dsOperatingExpensePayees operatingExpensePayees = (dsOperatingExpensePayees) base.Clone();
    operatingExpensePayees.InitVars();
    return (DataSet) operatingExpensePayees;
  }

  protected override bool ShouldSerializeTables() => false;

  protected override bool ShouldSerializeRelations() => false;

  protected override void ReadXmlSerializable(XmlReader reader)
  {
    this.Reset();
    DataSet dataSet = new DataSet();
    int num = (int) dataSet.ReadXml(reader);
    if (dataSet.Tables["PayeesList"] != null)
      this.Tables.Add((DataTable) new dsOperatingExpensePayees.PayeesListDataTable(dataSet.Tables["PayeesList"]));
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
    this.tablePayeesList = (dsOperatingExpensePayees.PayeesListDataTable) this.Tables["PayeesList"];
    if (this.tablePayeesList == null)
      return;
    this.tablePayeesList.InitVars();
  }

  private void InitClass()
  {
    this.DataSetName = nameof (dsOperatingExpensePayees);
    this.Prefix = "";
    this.Namespace = "http://tempuri.org/dsOperatingExpensePayees.xsd";
    this.Locale = new CultureInfo("en-US");
    this.CaseSensitive = false;
    this.EnforceConstraints = true;
    this.tablePayeesList = new dsOperatingExpensePayees.PayeesListDataTable();
    this.Tables.Add((DataTable) this.tablePayeesList);
  }

  private bool ShouldSerializePayeesList() => false;

  private void SchemaChanged(object sender, CollectionChangeEventArgs e)
  {
    if (e.Action != CollectionChangeAction.Remove)
      return;
    this.InitVars();
  }

  public delegate void PayeesListRowChangeEventHandler(
    object sender,
    dsOperatingExpensePayees.PayeesListRowChangeEvent e);

  [DebuggerStepThrough]
  public class PayeesListDataTable : DataTable, IEnumerable
  {
    private DataColumn columnpayeeGuid;
    private DataColumn columnPayeeName;
    private DataColumn columnPayeeAcctNum;
    private DataColumn columnAddress1;
    private DataColumn columnAddress2;
    private DataColumn columnCity;
    private DataColumn columnState;
    private DataColumn columnZip;
    private DataColumn columnZipPlus;
    private DataColumn columnPhone1;
    private DataColumn columnPhone2;
    private DataColumn columnFax;
    private DataColumn columnEmail;

    internal PayeesListDataTable()
      : base("PayeesList")
    {
      this.InitClass();
    }

    internal PayeesListDataTable(DataTable table)
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

    internal DataColumn payeeGuidColumn => this.columnpayeeGuid;

    internal DataColumn PayeeNameColumn => this.columnPayeeName;

    internal DataColumn PayeeAcctNumColumn => this.columnPayeeAcctNum;

    internal DataColumn Address1Column => this.columnAddress1;

    internal DataColumn Address2Column => this.columnAddress2;

    internal DataColumn CityColumn => this.columnCity;

    internal DataColumn StateColumn => this.columnState;

    internal DataColumn ZipColumn => this.columnZip;

    internal DataColumn ZipPlusColumn => this.columnZipPlus;

    internal DataColumn Phone1Column => this.columnPhone1;

    internal DataColumn Phone2Column => this.columnPhone2;

    internal DataColumn FaxColumn => this.columnFax;

    internal DataColumn EmailColumn => this.columnEmail;

    public dsOperatingExpensePayees.PayeesListRow this[int index]
    {
      get => (dsOperatingExpensePayees.PayeesListRow) this.Rows[index];
    }

    public event dsOperatingExpensePayees.PayeesListRowChangeEventHandler PayeesListRowChanged;

    public event dsOperatingExpensePayees.PayeesListRowChangeEventHandler PayeesListRowChanging;

    public event dsOperatingExpensePayees.PayeesListRowChangeEventHandler PayeesListRowDeleted;

    public event dsOperatingExpensePayees.PayeesListRowChangeEventHandler PayeesListRowDeleting;

    public void AddPayeesListRow(dsOperatingExpensePayees.PayeesListRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    public dsOperatingExpensePayees.PayeesListRow AddPayeesListRow(
      string payeeGuid,
      string PayeeName,
      string PayeeAcctNum,
      string Address1,
      string Address2,
      string City,
      string State,
      string Zip,
      string ZipPlus,
      string Phone1,
      string Phone2,
      string Fax,
      string Email)
    {
      dsOperatingExpensePayees.PayeesListRow row = (dsOperatingExpensePayees.PayeesListRow) this.NewRow();
      row.ItemArray = new object[13]
      {
        (object) payeeGuid,
        (object) PayeeName,
        (object) PayeeAcctNum,
        (object) Address1,
        (object) Address2,
        (object) City,
        (object) State,
        (object) Zip,
        (object) ZipPlus,
        (object) Phone1,
        (object) Phone2,
        (object) Fax,
        (object) Email
      };
      this.Rows.Add((DataRow) row);
      return row;
    }

    public IEnumerator GetEnumerator() => this.Rows.GetEnumerator();

    public override DataTable Clone()
    {
      dsOperatingExpensePayees.PayeesListDataTable payeesListDataTable = (dsOperatingExpensePayees.PayeesListDataTable) base.Clone();
      payeesListDataTable.InitVars();
      return (DataTable) payeesListDataTable;
    }

    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsOperatingExpensePayees.PayeesListDataTable();
    }

    internal void InitVars()
    {
      this.columnpayeeGuid = this.Columns["payeeGuid"];
      this.columnPayeeName = this.Columns["PayeeName"];
      this.columnPayeeAcctNum = this.Columns["PayeeAcctNum"];
      this.columnAddress1 = this.Columns["Address1"];
      this.columnAddress2 = this.Columns["Address2"];
      this.columnCity = this.Columns["City"];
      this.columnState = this.Columns["State"];
      this.columnZip = this.Columns["Zip"];
      this.columnZipPlus = this.Columns["ZipPlus"];
      this.columnPhone1 = this.Columns["Phone1"];
      this.columnPhone2 = this.Columns["Phone2"];
      this.columnFax = this.Columns["Fax"];
      this.columnEmail = this.Columns["Email"];
    }

    private void InitClass()
    {
      this.columnpayeeGuid = new DataColumn("payeeGuid", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnpayeeGuid);
      this.columnPayeeName = new DataColumn("PayeeName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPayeeName);
      this.columnPayeeAcctNum = new DataColumn("PayeeAcctNum", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPayeeAcctNum);
      this.columnAddress1 = new DataColumn("Address1", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAddress1);
      this.columnAddress2 = new DataColumn("Address2", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAddress2);
      this.columnCity = new DataColumn("City", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCity);
      this.columnState = new DataColumn("State", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnState);
      this.columnZip = new DataColumn("Zip", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnZip);
      this.columnZipPlus = new DataColumn("ZipPlus", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnZipPlus);
      this.columnPhone1 = new DataColumn("Phone1", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPhone1);
      this.columnPhone2 = new DataColumn("Phone2", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPhone2);
      this.columnFax = new DataColumn("Fax", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFax);
      this.columnEmail = new DataColumn("Email", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEmail);
    }

    public dsOperatingExpensePayees.PayeesListRow NewPayeesListRow()
    {
      return (dsOperatingExpensePayees.PayeesListRow) this.NewRow();
    }

    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsOperatingExpensePayees.PayeesListRow(builder);
    }

    protected override Type GetRowType() => typeof (dsOperatingExpensePayees.PayeesListRow);

    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.PayeesListRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsOperatingExpensePayees.PayeesListRowChangeEventHandler listRowChangedEvent = this.PayeesListRowChangedEvent;
      if (listRowChangedEvent == null)
        return;
      listRowChangedEvent((object) this, new dsOperatingExpensePayees.PayeesListRowChangeEvent((dsOperatingExpensePayees.PayeesListRow) e.Row, e.Action));
    }

    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.PayeesListRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsOperatingExpensePayees.PayeesListRowChangeEventHandler rowChangingEvent = this.PayeesListRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsOperatingExpensePayees.PayeesListRowChangeEvent((dsOperatingExpensePayees.PayeesListRow) e.Row, e.Action));
    }

    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.PayeesListRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsOperatingExpensePayees.PayeesListRowChangeEventHandler listRowDeletedEvent = this.PayeesListRowDeletedEvent;
      if (listRowDeletedEvent == null)
        return;
      listRowDeletedEvent((object) this, new dsOperatingExpensePayees.PayeesListRowChangeEvent((dsOperatingExpensePayees.PayeesListRow) e.Row, e.Action));
    }

    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.PayeesListRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsOperatingExpensePayees.PayeesListRowChangeEventHandler rowDeletingEvent = this.PayeesListRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsOperatingExpensePayees.PayeesListRowChangeEvent((dsOperatingExpensePayees.PayeesListRow) e.Row, e.Action));
    }

    public void RemovePayeesListRow(dsOperatingExpensePayees.PayeesListRow row)
    {
      this.Rows.Remove((DataRow) row);
    }
  }

  [DebuggerStepThrough]
  public class PayeesListRow : DataRow
  {
    private dsOperatingExpensePayees.PayeesListDataTable tablePayeesList;

    public PayeesListRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablePayeesList = (dsOperatingExpensePayees.PayeesListDataTable) this.Table;
    }

    public string payeeGuid
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablePayeesList.payeeGuidColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePayeesList.payeeGuidColumn] = (object) value;
    }

    public string PayeeName
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablePayeesList.PayeeNameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePayeesList.PayeeNameColumn] = (object) value;
    }

    public string PayeeAcctNum
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablePayeesList.PayeeAcctNumColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePayeesList.PayeeAcctNumColumn] = (object) value;
    }

    public string Address1
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablePayeesList.Address1Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePayeesList.Address1Column] = (object) value;
    }

    public string Address2
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablePayeesList.Address2Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePayeesList.Address2Column] = (object) value;
    }

    public string City
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablePayeesList.CityColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePayeesList.CityColumn] = (object) value;
    }

    public string State
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablePayeesList.StateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePayeesList.StateColumn] = (object) value;
    }

    public string Zip
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablePayeesList.ZipColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePayeesList.ZipColumn] = (object) value;
    }

    public string ZipPlus
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablePayeesList.ZipPlusColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePayeesList.ZipPlusColumn] = (object) value;
    }

    public string Phone1
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablePayeesList.Phone1Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePayeesList.Phone1Column] = (object) value;
    }

    public string Phone2
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablePayeesList.Phone2Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePayeesList.Phone2Column] = (object) value;
    }

    public string Fax
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablePayeesList.FaxColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePayeesList.FaxColumn] = (object) value;
    }

    public string Email
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablePayeesList.EmailColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePayeesList.EmailColumn] = (object) value;
    }

    public bool IspayeeGuidNull() => this.IsNull(this.tablePayeesList.payeeGuidColumn);

    public void SetpayeeGuidNull()
    {
      this[this.tablePayeesList.payeeGuidColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsPayeeNameNull() => this.IsNull(this.tablePayeesList.PayeeNameColumn);

    public void SetPayeeNameNull()
    {
      this[this.tablePayeesList.PayeeNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsPayeeAcctNumNull() => this.IsNull(this.tablePayeesList.PayeeAcctNumColumn);

    public void SetPayeeAcctNumNull()
    {
      this[this.tablePayeesList.PayeeAcctNumColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsAddress1Null() => this.IsNull(this.tablePayeesList.Address1Column);

    public void SetAddress1Null()
    {
      this[this.tablePayeesList.Address1Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsAddress2Null() => this.IsNull(this.tablePayeesList.Address2Column);

    public void SetAddress2Null()
    {
      this[this.tablePayeesList.Address2Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsCityNull() => this.IsNull(this.tablePayeesList.CityColumn);

    public void SetCityNull()
    {
      this[this.tablePayeesList.CityColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsStateNull() => this.IsNull(this.tablePayeesList.StateColumn);

    public void SetStateNull()
    {
      this[this.tablePayeesList.StateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsZipNull() => this.IsNull(this.tablePayeesList.ZipColumn);

    public void SetZipNull()
    {
      this[this.tablePayeesList.ZipColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsZipPlusNull() => this.IsNull(this.tablePayeesList.ZipPlusColumn);

    public void SetZipPlusNull()
    {
      this[this.tablePayeesList.ZipPlusColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsPhone1Null() => this.IsNull(this.tablePayeesList.Phone1Column);

    public void SetPhone1Null()
    {
      this[this.tablePayeesList.Phone1Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsPhone2Null() => this.IsNull(this.tablePayeesList.Phone2Column);

    public void SetPhone2Null()
    {
      this[this.tablePayeesList.Phone2Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsFaxNull() => this.IsNull(this.tablePayeesList.FaxColumn);

    public void SetFaxNull()
    {
      this[this.tablePayeesList.FaxColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsEmailNull() => this.IsNull(this.tablePayeesList.EmailColumn);

    public void SetEmailNull()
    {
      this[this.tablePayeesList.EmailColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  [DebuggerStepThrough]
  public class PayeesListRowChangeEvent : EventArgs
  {
    private dsOperatingExpensePayees.PayeesListRow eventRow;
    private DataRowAction eventAction;

    public PayeesListRowChangeEvent(
      dsOperatingExpensePayees.PayeesListRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    public dsOperatingExpensePayees.PayeesListRow Row => this.eventRow;

    public DataRowAction Action => this.eventAction;
  }
}
