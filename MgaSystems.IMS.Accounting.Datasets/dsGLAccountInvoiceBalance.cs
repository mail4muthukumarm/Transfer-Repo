// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.AccountingDatasets.dsGLAccountInvoiceBalance
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
public class dsGLAccountInvoiceBalance : DataSet
{
  private dsGLAccountInvoiceBalance.InvoiceBalancesDataTable tableInvoiceBalances;

  public dsGLAccountInvoiceBalance()
  {
    this.InitClass();
    CollectionChangeEventHandler changeEventHandler = new CollectionChangeEventHandler(this.SchemaChanged);
    this.Tables.CollectionChanged += changeEventHandler;
    this.Relations.CollectionChanged += changeEventHandler;
  }

  protected dsGLAccountInvoiceBalance(SerializationInfo info, StreamingContext context)
  {
    string s = Conversions.ToString(info.GetValue("XmlSchema", typeof (string)));
    if (s != null)
    {
      DataSet dataSet = new DataSet();
      dataSet.ReadXmlSchema((XmlReader) new XmlTextReader((TextReader) new StringReader(s)));
      if (dataSet.Tables[nameof (InvoiceBalances)] != null)
        this.Tables.Add((DataTable) new dsGLAccountInvoiceBalance.InvoiceBalancesDataTable(dataSet.Tables[nameof (InvoiceBalances)]));
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
  public dsGLAccountInvoiceBalance.InvoiceBalancesDataTable InvoiceBalances
  {
    get => this.tableInvoiceBalances;
  }

  public override DataSet Clone()
  {
    dsGLAccountInvoiceBalance accountInvoiceBalance = (dsGLAccountInvoiceBalance) base.Clone();
    accountInvoiceBalance.InitVars();
    return (DataSet) accountInvoiceBalance;
  }

  protected override bool ShouldSerializeTables() => false;

  protected override bool ShouldSerializeRelations() => false;

  protected override void ReadXmlSerializable(XmlReader reader)
  {
    this.Reset();
    DataSet dataSet = new DataSet();
    int num = (int) dataSet.ReadXml(reader);
    if (dataSet.Tables["InvoiceBalances"] != null)
      this.Tables.Add((DataTable) new dsGLAccountInvoiceBalance.InvoiceBalancesDataTable(dataSet.Tables["InvoiceBalances"]));
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
    this.tableInvoiceBalances = (dsGLAccountInvoiceBalance.InvoiceBalancesDataTable) this.Tables["InvoiceBalances"];
    if (this.tableInvoiceBalances == null)
      return;
    this.tableInvoiceBalances.InitVars();
  }

  private void InitClass()
  {
    this.DataSetName = nameof (dsGLAccountInvoiceBalance);
    this.Prefix = "";
    this.Namespace = "http://tempuri.org/dsGLAccountInvoiceBalance.xsd";
    this.Locale = new CultureInfo("en-US");
    this.CaseSensitive = false;
    this.EnforceConstraints = true;
    this.tableInvoiceBalances = new dsGLAccountInvoiceBalance.InvoiceBalancesDataTable();
    this.Tables.Add((DataTable) this.tableInvoiceBalances);
  }

  private bool ShouldSerializeInvoiceBalances() => false;

  private void SchemaChanged(object sender, CollectionChangeEventArgs e)
  {
    if (e.Action != CollectionChangeAction.Remove)
      return;
    this.InitVars();
  }

  public delegate void InvoiceBalancesRowChangeEventHandler(
    object sender,
    dsGLAccountInvoiceBalance.InvoiceBalancesRowChangeEvent e);

  [DebuggerStepThrough]
  public class InvoiceBalancesDataTable : DataTable, IEnumerable
  {
    private DataColumn columnofficeInvoiceNum;
    private DataColumn columninsuredName;
    private DataColumn columnpolicyNumber;
    private DataColumn columnamount;
    private DataColumn columninvoiceNum;
    private DataColumn columnchargeCode;
    private DataColumn columncompanyLineGuid;
    private DataColumn columnchargeName;

    internal InvoiceBalancesDataTable()
      : base("InvoiceBalances")
    {
      this.InitClass();
    }

    internal InvoiceBalancesDataTable(DataTable table)
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

    internal DataColumn officeInvoiceNumColumn => this.columnofficeInvoiceNum;

    internal DataColumn insuredNameColumn => this.columninsuredName;

    internal DataColumn policyNumberColumn => this.columnpolicyNumber;

    internal DataColumn amountColumn => this.columnamount;

    internal DataColumn invoiceNumColumn => this.columninvoiceNum;

    internal DataColumn chargeCodeColumn => this.columnchargeCode;

    internal DataColumn companyLineGuidColumn => this.columncompanyLineGuid;

    internal DataColumn chargeNameColumn => this.columnchargeName;

    public dsGLAccountInvoiceBalance.InvoiceBalancesRow this[int index]
    {
      get => (dsGLAccountInvoiceBalance.InvoiceBalancesRow) this.Rows[index];
    }

    public event dsGLAccountInvoiceBalance.InvoiceBalancesRowChangeEventHandler InvoiceBalancesRowChanged;

    public event dsGLAccountInvoiceBalance.InvoiceBalancesRowChangeEventHandler InvoiceBalancesRowChanging;

    public event dsGLAccountInvoiceBalance.InvoiceBalancesRowChangeEventHandler InvoiceBalancesRowDeleted;

    public event dsGLAccountInvoiceBalance.InvoiceBalancesRowChangeEventHandler InvoiceBalancesRowDeleting;

    public void AddInvoiceBalancesRow(dsGLAccountInvoiceBalance.InvoiceBalancesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    public dsGLAccountInvoiceBalance.InvoiceBalancesRow AddInvoiceBalancesRow(
      string officeInvoiceNum,
      string insuredName,
      string policyNumber,
      Decimal amount,
      int invoiceNum,
      int chargeCode,
      string companyLineGuid,
      string chargeName)
    {
      dsGLAccountInvoiceBalance.InvoiceBalancesRow row = (dsGLAccountInvoiceBalance.InvoiceBalancesRow) this.NewRow();
      row.ItemArray = new object[8]
      {
        (object) officeInvoiceNum,
        (object) insuredName,
        (object) policyNumber,
        (object) amount,
        (object) invoiceNum,
        (object) chargeCode,
        (object) companyLineGuid,
        (object) chargeName
      };
      this.Rows.Add((DataRow) row);
      return row;
    }

    public IEnumerator GetEnumerator() => this.Rows.GetEnumerator();

    public override DataTable Clone()
    {
      dsGLAccountInvoiceBalance.InvoiceBalancesDataTable balancesDataTable = (dsGLAccountInvoiceBalance.InvoiceBalancesDataTable) base.Clone();
      balancesDataTable.InitVars();
      return (DataTable) balancesDataTable;
    }

    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsGLAccountInvoiceBalance.InvoiceBalancesDataTable();
    }

    internal void InitVars()
    {
      this.columnofficeInvoiceNum = this.Columns["officeInvoiceNum"];
      this.columninsuredName = this.Columns["insuredName"];
      this.columnpolicyNumber = this.Columns["policyNumber"];
      this.columnamount = this.Columns["amount"];
      this.columninvoiceNum = this.Columns["invoiceNum"];
      this.columnchargeCode = this.Columns["chargeCode"];
      this.columncompanyLineGuid = this.Columns["companyLineGuid"];
      this.columnchargeName = this.Columns["chargeName"];
    }

    private void InitClass()
    {
      this.columnofficeInvoiceNum = new DataColumn("officeInvoiceNum", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnofficeInvoiceNum);
      this.columninsuredName = new DataColumn("insuredName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columninsuredName);
      this.columnpolicyNumber = new DataColumn("policyNumber", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnpolicyNumber);
      this.columnamount = new DataColumn("amount", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnamount);
      this.columninvoiceNum = new DataColumn("invoiceNum", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columninvoiceNum);
      this.columnchargeCode = new DataColumn("chargeCode", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnchargeCode);
      this.columncompanyLineGuid = new DataColumn("companyLineGuid", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columncompanyLineGuid);
      this.columnchargeName = new DataColumn("chargeName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnchargeName);
    }

    public dsGLAccountInvoiceBalance.InvoiceBalancesRow NewInvoiceBalancesRow()
    {
      return (dsGLAccountInvoiceBalance.InvoiceBalancesRow) this.NewRow();
    }

    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsGLAccountInvoiceBalance.InvoiceBalancesRow(builder);
    }

    protected override Type GetRowType() => typeof (dsGLAccountInvoiceBalance.InvoiceBalancesRow);

    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.InvoiceBalancesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsGLAccountInvoiceBalance.InvoiceBalancesRowChangeEventHandler balancesRowChangedEvent = this.InvoiceBalancesRowChangedEvent;
      if (balancesRowChangedEvent == null)
        return;
      balancesRowChangedEvent((object) this, new dsGLAccountInvoiceBalance.InvoiceBalancesRowChangeEvent((dsGLAccountInvoiceBalance.InvoiceBalancesRow) e.Row, e.Action));
    }

    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.InvoiceBalancesRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsGLAccountInvoiceBalance.InvoiceBalancesRowChangeEventHandler rowChangingEvent = this.InvoiceBalancesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsGLAccountInvoiceBalance.InvoiceBalancesRowChangeEvent((dsGLAccountInvoiceBalance.InvoiceBalancesRow) e.Row, e.Action));
    }

    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.InvoiceBalancesRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsGLAccountInvoiceBalance.InvoiceBalancesRowChangeEventHandler balancesRowDeletedEvent = this.InvoiceBalancesRowDeletedEvent;
      if (balancesRowDeletedEvent == null)
        return;
      balancesRowDeletedEvent((object) this, new dsGLAccountInvoiceBalance.InvoiceBalancesRowChangeEvent((dsGLAccountInvoiceBalance.InvoiceBalancesRow) e.Row, e.Action));
    }

    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.InvoiceBalancesRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsGLAccountInvoiceBalance.InvoiceBalancesRowChangeEventHandler rowDeletingEvent = this.InvoiceBalancesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsGLAccountInvoiceBalance.InvoiceBalancesRowChangeEvent((dsGLAccountInvoiceBalance.InvoiceBalancesRow) e.Row, e.Action));
    }

    public void RemoveInvoiceBalancesRow(dsGLAccountInvoiceBalance.InvoiceBalancesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }
  }

  [DebuggerStepThrough]
  public class InvoiceBalancesRow : DataRow
  {
    private dsGLAccountInvoiceBalance.InvoiceBalancesDataTable tableInvoiceBalances;

    internal InvoiceBalancesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableInvoiceBalances = (dsGLAccountInvoiceBalance.InvoiceBalancesDataTable) this.Table;
    }

    public string officeInvoiceNum
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableInvoiceBalances.officeInvoiceNumColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableInvoiceBalances.officeInvoiceNumColumn] = (object) value;
    }

    public string insuredName
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableInvoiceBalances.insuredNameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableInvoiceBalances.insuredNameColumn] = (object) value;
    }

    public string policyNumber
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableInvoiceBalances.policyNumberColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableInvoiceBalances.policyNumberColumn] = (object) value;
    }

    public Decimal amount
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tableInvoiceBalances.amountColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableInvoiceBalances.amountColumn] = (object) value;
    }

    public int invoiceNum
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tableInvoiceBalances.invoiceNumColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableInvoiceBalances.invoiceNumColumn] = (object) value;
    }

    public int chargeCode
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tableInvoiceBalances.chargeCodeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableInvoiceBalances.chargeCodeColumn] = (object) value;
    }

    public string companyLineGuid
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableInvoiceBalances.companyLineGuidColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableInvoiceBalances.companyLineGuidColumn] = (object) value;
    }

    public string chargeName
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableInvoiceBalances.chargeNameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableInvoiceBalances.chargeNameColumn] = (object) value;
    }

    public bool IsofficeInvoiceNumNull()
    {
      return this.IsNull(this.tableInvoiceBalances.officeInvoiceNumColumn);
    }

    public void SetofficeInvoiceNumNull()
    {
      this[this.tableInvoiceBalances.officeInvoiceNumColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsinsuredNameNull() => this.IsNull(this.tableInvoiceBalances.insuredNameColumn);

    public void SetinsuredNameNull()
    {
      this[this.tableInvoiceBalances.insuredNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IspolicyNumberNull() => this.IsNull(this.tableInvoiceBalances.policyNumberColumn);

    public void SetpolicyNumberNull()
    {
      this[this.tableInvoiceBalances.policyNumberColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsamountNull() => this.IsNull(this.tableInvoiceBalances.amountColumn);

    public void SetamountNull()
    {
      this[this.tableInvoiceBalances.amountColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsinvoiceNumNull() => this.IsNull(this.tableInvoiceBalances.invoiceNumColumn);

    public void SetinvoiceNumNull()
    {
      this[this.tableInvoiceBalances.invoiceNumColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IschargeCodeNull() => this.IsNull(this.tableInvoiceBalances.chargeCodeColumn);

    public void SetchargeCodeNull()
    {
      this[this.tableInvoiceBalances.chargeCodeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IscompanyLineGuidNull()
    {
      return this.IsNull(this.tableInvoiceBalances.companyLineGuidColumn);
    }

    public void SetcompanyLineGuidNull()
    {
      this[this.tableInvoiceBalances.companyLineGuidColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IschargeNameNull() => this.IsNull(this.tableInvoiceBalances.chargeNameColumn);

    public void SetchargeNameNull()
    {
      this[this.tableInvoiceBalances.chargeNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  [DebuggerStepThrough]
  public class InvoiceBalancesRowChangeEvent : EventArgs
  {
    private dsGLAccountInvoiceBalance.InvoiceBalancesRow eventRow;
    private DataRowAction eventAction;

    public InvoiceBalancesRowChangeEvent(
      dsGLAccountInvoiceBalance.InvoiceBalancesRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    public dsGLAccountInvoiceBalance.InvoiceBalancesRow Row => this.eventRow;

    public DataRowAction Action => this.eventAction;
  }
}
