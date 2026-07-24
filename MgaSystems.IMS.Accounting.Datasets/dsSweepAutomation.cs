// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.AccountingDatasets.dsSweepAutomation
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
public class dsSweepAutomation : DataSet
{
  private dsSweepAutomation.InvoiceListDataTable tableInvoiceList;

  public dsSweepAutomation()
  {
    this.InitClass();
    CollectionChangeEventHandler changeEventHandler = new CollectionChangeEventHandler(this.SchemaChanged);
    this.Tables.CollectionChanged += changeEventHandler;
    this.Relations.CollectionChanged += changeEventHandler;
  }

  protected dsSweepAutomation(SerializationInfo info, StreamingContext context)
  {
    string s = Conversions.ToString(info.GetValue("XmlSchema", typeof (string)));
    if (s != null)
    {
      DataSet dataSet = new DataSet();
      dataSet.ReadXmlSchema((XmlReader) new XmlTextReader((TextReader) new StringReader(s)));
      if (dataSet.Tables[nameof (InvoiceList)] != null)
        this.Tables.Add((DataTable) new dsSweepAutomation.InvoiceListDataTable(dataSet.Tables[nameof (InvoiceList)]));
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
  public dsSweepAutomation.InvoiceListDataTable InvoiceList => this.tableInvoiceList;

  public override DataSet Clone()
  {
    dsSweepAutomation dsSweepAutomation = (dsSweepAutomation) base.Clone();
    dsSweepAutomation.InitVars();
    return (DataSet) dsSweepAutomation;
  }

  protected override bool ShouldSerializeTables() => false;

  protected override bool ShouldSerializeRelations() => false;

  protected override void ReadXmlSerializable(XmlReader reader)
  {
    this.Reset();
    DataSet dataSet = new DataSet();
    int num = (int) dataSet.ReadXml(reader);
    if (dataSet.Tables["InvoiceList"] != null)
      this.Tables.Add((DataTable) new dsSweepAutomation.InvoiceListDataTable(dataSet.Tables["InvoiceList"]));
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
    this.tableInvoiceList = (dsSweepAutomation.InvoiceListDataTable) this.Tables["InvoiceList"];
    if (this.tableInvoiceList == null)
      return;
    this.tableInvoiceList.InitVars();
  }

  private void InitClass()
  {
    this.DataSetName = nameof (dsSweepAutomation);
    this.Prefix = "";
    this.Namespace = "http://tempuri.org/dsSweepAutomation.xsd";
    this.Locale = new CultureInfo("en-US");
    this.CaseSensitive = false;
    this.EnforceConstraints = true;
    this.tableInvoiceList = new dsSweepAutomation.InvoiceListDataTable();
    this.Tables.Add((DataTable) this.tableInvoiceList);
  }

  private bool ShouldSerializeInvoiceList() => false;

  private void SchemaChanged(object sender, CollectionChangeEventArgs e)
  {
    if (e.Action != CollectionChangeAction.Remove)
      return;
    this.InitVars();
  }

  public delegate void InvoiceListRowChangeEventHandler(
    object sender,
    dsSweepAutomation.InvoiceListRowChangeEvent e);

  [DebuggerStepThrough]
  public class InvoiceListDataTable : DataTable, IEnumerable
  {
    private DataColumn columnPostDate;
    private DataColumn columnOfficeInvoiceNumber;
    private DataColumn columnCompany;
    private DataColumn columnPolicyNumber;
    private DataColumn columnInsuredName;
    private DataColumn columnQuoteDescription;
    private DataColumn columnInvoiceTotal;
    private DataColumn columnAmtRcvd;
    private DataColumn columnGrossCommission;
    private DataColumn columnCompanyGross;
    private DataColumn columnPaidToDate;
    private DataColumn columnPercentReceived;
    private DataColumn columnInvoiceNumber;

    internal InvoiceListDataTable()
      : base("InvoiceList")
    {
      this.InitClass();
    }

    internal InvoiceListDataTable(DataTable table)
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

    internal DataColumn OfficeInvoiceNumberColumn => this.columnOfficeInvoiceNumber;

    internal DataColumn CompanyColumn => this.columnCompany;

    internal DataColumn PolicyNumberColumn => this.columnPolicyNumber;

    internal DataColumn InsuredNameColumn => this.columnInsuredName;

    internal DataColumn QuoteDescriptionColumn => this.columnQuoteDescription;

    internal DataColumn InvoiceTotalColumn => this.columnInvoiceTotal;

    internal DataColumn AmtRcvdColumn => this.columnAmtRcvd;

    internal DataColumn GrossCommissionColumn => this.columnGrossCommission;

    internal DataColumn CompanyGrossColumn => this.columnCompanyGross;

    internal DataColumn PaidToDateColumn => this.columnPaidToDate;

    internal DataColumn PercentReceivedColumn => this.columnPercentReceived;

    internal DataColumn InvoiceNumberColumn => this.columnInvoiceNumber;

    public dsSweepAutomation.InvoiceListRow this[int index]
    {
      get => (dsSweepAutomation.InvoiceListRow) this.Rows[index];
    }

    public event dsSweepAutomation.InvoiceListRowChangeEventHandler InvoiceListRowChanged;

    public event dsSweepAutomation.InvoiceListRowChangeEventHandler InvoiceListRowChanging;

    public event dsSweepAutomation.InvoiceListRowChangeEventHandler InvoiceListRowDeleted;

    public event dsSweepAutomation.InvoiceListRowChangeEventHandler InvoiceListRowDeleting;

    public void AddInvoiceListRow(dsSweepAutomation.InvoiceListRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    public dsSweepAutomation.InvoiceListRow AddInvoiceListRow(
      DateTime PostDate,
      int OfficeInvoiceNumber,
      string Company,
      string PolicyNumber,
      string InsuredName,
      string QuoteDescription,
      Decimal InvoiceTotal,
      Decimal AmtRcvd,
      Decimal GrossCommission,
      Decimal CompanyGross,
      Decimal PaidToDate,
      Decimal PercentReceived,
      int InvoiceNumber)
    {
      dsSweepAutomation.InvoiceListRow row = (dsSweepAutomation.InvoiceListRow) this.NewRow();
      row.ItemArray = new object[13]
      {
        (object) PostDate,
        (object) OfficeInvoiceNumber,
        (object) Company,
        (object) PolicyNumber,
        (object) InsuredName,
        (object) QuoteDescription,
        (object) InvoiceTotal,
        (object) AmtRcvd,
        (object) GrossCommission,
        (object) CompanyGross,
        (object) PaidToDate,
        (object) PercentReceived,
        (object) InvoiceNumber
      };
      this.Rows.Add((DataRow) row);
      return row;
    }

    public IEnumerator GetEnumerator() => this.Rows.GetEnumerator();

    public override DataTable Clone()
    {
      dsSweepAutomation.InvoiceListDataTable invoiceListDataTable = (dsSweepAutomation.InvoiceListDataTable) base.Clone();
      invoiceListDataTable.InitVars();
      return (DataTable) invoiceListDataTable;
    }

    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsSweepAutomation.InvoiceListDataTable();
    }

    internal void InitVars()
    {
      this.columnPostDate = this.Columns["PostDate"];
      this.columnOfficeInvoiceNumber = this.Columns["OfficeInvoiceNumber"];
      this.columnCompany = this.Columns["Company"];
      this.columnPolicyNumber = this.Columns["PolicyNumber"];
      this.columnInsuredName = this.Columns["InsuredName"];
      this.columnQuoteDescription = this.Columns["QuoteDescription"];
      this.columnInvoiceTotal = this.Columns["InvoiceTotal"];
      this.columnAmtRcvd = this.Columns["AmtRcvd"];
      this.columnGrossCommission = this.Columns["GrossCommission"];
      this.columnCompanyGross = this.Columns["CompanyGross"];
      this.columnPaidToDate = this.Columns["PaidToDate"];
      this.columnPercentReceived = this.Columns["PercentReceived"];
      this.columnInvoiceNumber = this.Columns["InvoiceNumber"];
    }

    private void InitClass()
    {
      this.columnPostDate = new DataColumn("PostDate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPostDate);
      this.columnOfficeInvoiceNumber = new DataColumn("OfficeInvoiceNumber", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnOfficeInvoiceNumber);
      this.columnCompany = new DataColumn("Company", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCompany);
      this.columnPolicyNumber = new DataColumn("PolicyNumber", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPolicyNumber);
      this.columnInsuredName = new DataColumn("InsuredName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInsuredName);
      this.columnQuoteDescription = new DataColumn("QuoteDescription", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnQuoteDescription);
      this.columnInvoiceTotal = new DataColumn("InvoiceTotal", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInvoiceTotal);
      this.columnAmtRcvd = new DataColumn("AmtRcvd", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAmtRcvd);
      this.columnGrossCommission = new DataColumn("GrossCommission", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnGrossCommission);
      this.columnCompanyGross = new DataColumn("CompanyGross", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCompanyGross);
      this.columnPaidToDate = new DataColumn("PaidToDate", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPaidToDate);
      this.columnPercentReceived = new DataColumn("PercentReceived", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPercentReceived);
      this.columnInvoiceNumber = new DataColumn("InvoiceNumber", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInvoiceNumber);
    }

    public dsSweepAutomation.InvoiceListRow NewInvoiceListRow()
    {
      return (dsSweepAutomation.InvoiceListRow) this.NewRow();
    }

    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsSweepAutomation.InvoiceListRow(builder);
    }

    protected override Type GetRowType() => typeof (dsSweepAutomation.InvoiceListRow);

    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.InvoiceListRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsSweepAutomation.InvoiceListRowChangeEventHandler listRowChangedEvent = this.InvoiceListRowChangedEvent;
      if (listRowChangedEvent == null)
        return;
      listRowChangedEvent((object) this, new dsSweepAutomation.InvoiceListRowChangeEvent((dsSweepAutomation.InvoiceListRow) e.Row, e.Action));
    }

    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.InvoiceListRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsSweepAutomation.InvoiceListRowChangeEventHandler rowChangingEvent = this.InvoiceListRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsSweepAutomation.InvoiceListRowChangeEvent((dsSweepAutomation.InvoiceListRow) e.Row, e.Action));
    }

    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.InvoiceListRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsSweepAutomation.InvoiceListRowChangeEventHandler listRowDeletedEvent = this.InvoiceListRowDeletedEvent;
      if (listRowDeletedEvent == null)
        return;
      listRowDeletedEvent((object) this, new dsSweepAutomation.InvoiceListRowChangeEvent((dsSweepAutomation.InvoiceListRow) e.Row, e.Action));
    }

    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.InvoiceListRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsSweepAutomation.InvoiceListRowChangeEventHandler rowDeletingEvent = this.InvoiceListRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsSweepAutomation.InvoiceListRowChangeEvent((dsSweepAutomation.InvoiceListRow) e.Row, e.Action));
    }

    public void RemoveInvoiceListRow(dsSweepAutomation.InvoiceListRow row)
    {
      this.Rows.Remove((DataRow) row);
    }
  }

  [DebuggerStepThrough]
  public class InvoiceListRow : DataRow
  {
    private dsSweepAutomation.InvoiceListDataTable tableInvoiceList;

    internal InvoiceListRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableInvoiceList = (dsSweepAutomation.InvoiceListDataTable) this.Table;
    }

    public DateTime PostDate
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tableInvoiceList.PostDateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableInvoiceList.PostDateColumn] = (object) value;
    }

    public int OfficeInvoiceNumber
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tableInvoiceList.OfficeInvoiceNumberColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableInvoiceList.OfficeInvoiceNumberColumn] = (object) value;
    }

    public string Company
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableInvoiceList.CompanyColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableInvoiceList.CompanyColumn] = (object) value;
    }

    public string PolicyNumber
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableInvoiceList.PolicyNumberColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableInvoiceList.PolicyNumberColumn] = (object) value;
    }

    public string InsuredName
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableInvoiceList.InsuredNameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableInvoiceList.InsuredNameColumn] = (object) value;
    }

    public string QuoteDescription
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableInvoiceList.QuoteDescriptionColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableInvoiceList.QuoteDescriptionColumn] = (object) value;
    }

    public Decimal InvoiceTotal
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tableInvoiceList.InvoiceTotalColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableInvoiceList.InvoiceTotalColumn] = (object) value;
    }

    public Decimal AmtRcvd
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tableInvoiceList.AmtRcvdColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableInvoiceList.AmtRcvdColumn] = (object) value;
    }

    public Decimal GrossCommission
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tableInvoiceList.GrossCommissionColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableInvoiceList.GrossCommissionColumn] = (object) value;
    }

    public Decimal CompanyGross
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tableInvoiceList.CompanyGrossColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableInvoiceList.CompanyGrossColumn] = (object) value;
    }

    public Decimal PaidToDate
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tableInvoiceList.PaidToDateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableInvoiceList.PaidToDateColumn] = (object) value;
    }

    public Decimal PercentReceived
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tableInvoiceList.PercentReceivedColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableInvoiceList.PercentReceivedColumn] = (object) value;
    }

    public int InvoiceNumber
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tableInvoiceList.InvoiceNumberColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableInvoiceList.InvoiceNumberColumn] = (object) value;
    }

    public bool IsPostDateNull() => this.IsNull(this.tableInvoiceList.PostDateColumn);

    public void SetPostDateNull()
    {
      this[this.tableInvoiceList.PostDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsOfficeInvoiceNumberNull()
    {
      return this.IsNull(this.tableInvoiceList.OfficeInvoiceNumberColumn);
    }

    public void SetOfficeInvoiceNumberNull()
    {
      this[this.tableInvoiceList.OfficeInvoiceNumberColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsCompanyNull() => this.IsNull(this.tableInvoiceList.CompanyColumn);

    public void SetCompanyNull()
    {
      this[this.tableInvoiceList.CompanyColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsPolicyNumberNull() => this.IsNull(this.tableInvoiceList.PolicyNumberColumn);

    public void SetPolicyNumberNull()
    {
      this[this.tableInvoiceList.PolicyNumberColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsInsuredNameNull() => this.IsNull(this.tableInvoiceList.InsuredNameColumn);

    public void SetInsuredNameNull()
    {
      this[this.tableInvoiceList.InsuredNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsQuoteDescriptionNull()
    {
      return this.IsNull(this.tableInvoiceList.QuoteDescriptionColumn);
    }

    public void SetQuoteDescriptionNull()
    {
      this[this.tableInvoiceList.QuoteDescriptionColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsInvoiceTotalNull() => this.IsNull(this.tableInvoiceList.InvoiceTotalColumn);

    public void SetInvoiceTotalNull()
    {
      this[this.tableInvoiceList.InvoiceTotalColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsAmtRcvdNull() => this.IsNull(this.tableInvoiceList.AmtRcvdColumn);

    public void SetAmtRcvdNull()
    {
      this[this.tableInvoiceList.AmtRcvdColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsGrossCommissionNull() => this.IsNull(this.tableInvoiceList.GrossCommissionColumn);

    public void SetGrossCommissionNull()
    {
      this[this.tableInvoiceList.GrossCommissionColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsCompanyGrossNull() => this.IsNull(this.tableInvoiceList.CompanyGrossColumn);

    public void SetCompanyGrossNull()
    {
      this[this.tableInvoiceList.CompanyGrossColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsPaidToDateNull() => this.IsNull(this.tableInvoiceList.PaidToDateColumn);

    public void SetPaidToDateNull()
    {
      this[this.tableInvoiceList.PaidToDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsPercentReceivedNull() => this.IsNull(this.tableInvoiceList.PercentReceivedColumn);

    public void SetPercentReceivedNull()
    {
      this[this.tableInvoiceList.PercentReceivedColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsInvoiceNumberNull() => this.IsNull(this.tableInvoiceList.InvoiceNumberColumn);

    public void SetInvoiceNumberNull()
    {
      this[this.tableInvoiceList.InvoiceNumberColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  [DebuggerStepThrough]
  public class InvoiceListRowChangeEvent : EventArgs
  {
    private dsSweepAutomation.InvoiceListRow eventRow;
    private DataRowAction eventAction;

    public InvoiceListRowChangeEvent(dsSweepAutomation.InvoiceListRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    public dsSweepAutomation.InvoiceListRow Row => this.eventRow;

    public DataRowAction Action => this.eventAction;
  }
}
