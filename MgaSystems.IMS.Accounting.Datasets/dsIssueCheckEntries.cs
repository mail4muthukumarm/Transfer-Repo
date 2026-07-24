// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.AccountingDatasets.dsIssueCheckEntries
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
public class dsIssueCheckEntries : DataSet
{
  private dsIssueCheckEntries.EntriesDataTable tableEntries;

  public dsIssueCheckEntries()
  {
    this.InitClass();
    CollectionChangeEventHandler changeEventHandler = new CollectionChangeEventHandler(this.SchemaChanged);
    this.Tables.CollectionChanged += changeEventHandler;
    this.Relations.CollectionChanged += changeEventHandler;
  }

  protected dsIssueCheckEntries(SerializationInfo info, StreamingContext context)
  {
    string s = Conversions.ToString(info.GetValue("XmlSchema", typeof (string)));
    if (s != null)
    {
      DataSet dataSet = new DataSet();
      dataSet.ReadXmlSchema((XmlReader) new XmlTextReader((TextReader) new StringReader(s)));
      if (dataSet.Tables[nameof (Entries)] != null)
        this.Tables.Add((DataTable) new dsIssueCheckEntries.EntriesDataTable(dataSet.Tables[nameof (Entries)]));
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
  public dsIssueCheckEntries.EntriesDataTable Entries => this.tableEntries;

  public override DataSet Clone()
  {
    dsIssueCheckEntries issueCheckEntries = (dsIssueCheckEntries) base.Clone();
    issueCheckEntries.InitVars();
    return (DataSet) issueCheckEntries;
  }

  protected override bool ShouldSerializeTables() => false;

  protected override bool ShouldSerializeRelations() => false;

  protected override void ReadXmlSerializable(XmlReader reader)
  {
    this.Reset();
    DataSet dataSet = new DataSet();
    int num = (int) dataSet.ReadXml(reader);
    if (dataSet.Tables["Entries"] != null)
      this.Tables.Add((DataTable) new dsIssueCheckEntries.EntriesDataTable(dataSet.Tables["Entries"]));
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
    this.tableEntries = (dsIssueCheckEntries.EntriesDataTable) this.Tables["Entries"];
    if (this.tableEntries == null)
      return;
    this.tableEntries.InitVars();
  }

  private void InitClass()
  {
    this.DataSetName = nameof (dsIssueCheckEntries);
    this.Prefix = "";
    this.Namespace = "http://tempuri.org/dsIssueCheckEntries.xsd";
    this.Locale = new CultureInfo("en-US");
    this.CaseSensitive = false;
    this.EnforceConstraints = true;
    this.tableEntries = new dsIssueCheckEntries.EntriesDataTable();
    this.Tables.Add((DataTable) this.tableEntries);
  }

  private bool ShouldSerializeEntries() => false;

  private void SchemaChanged(object sender, CollectionChangeEventArgs e)
  {
    if (e.Action != CollectionChangeAction.Remove)
      return;
    this.InitVars();
  }

  public delegate void EntriesRowChangeEventHandler(
    object sender,
    dsIssueCheckEntries.EntriesRowChangeEvent e);

  [DebuggerStepThrough]
  public class EntriesDataTable : DataTable, IEnumerable
  {
    private DataColumn columnDescription;
    private DataColumn column_Debit_Amt_;
    private DataColumn column_Credit_Amt_;
    private DataColumn columninvoicenum;
    private DataColumn columnchargecode;
    private DataColumn columncompanylineguid;
    private DataColumn columnglacctid;

    internal EntriesDataTable()
      : base("Entries")
    {
      this.InitClass();
    }

    internal EntriesDataTable(DataTable table)
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

    internal DataColumn DescriptionColumn => this.columnDescription;

    internal DataColumn _Debit_Amt_Column => this.column_Debit_Amt_;

    internal DataColumn _Credit_Amt_Column => this.column_Credit_Amt_;

    internal DataColumn invoicenumColumn => this.columninvoicenum;

    internal DataColumn chargecodeColumn => this.columnchargecode;

    internal DataColumn companylineguidColumn => this.columncompanylineguid;

    internal DataColumn glacctidColumn => this.columnglacctid;

    public dsIssueCheckEntries.EntriesRow this[int index]
    {
      get => (dsIssueCheckEntries.EntriesRow) this.Rows[index];
    }

    public event dsIssueCheckEntries.EntriesRowChangeEventHandler EntriesRowChanged;

    public event dsIssueCheckEntries.EntriesRowChangeEventHandler EntriesRowChanging;

    public event dsIssueCheckEntries.EntriesRowChangeEventHandler EntriesRowDeleted;

    public event dsIssueCheckEntries.EntriesRowChangeEventHandler EntriesRowDeleting;

    public void AddEntriesRow(dsIssueCheckEntries.EntriesRow row) => this.Rows.Add((DataRow) row);

    public dsIssueCheckEntries.EntriesRow AddEntriesRow(
      string Description,
      Decimal _Debit_Amt_,
      Decimal _Credit_Amt_,
      int invoicenum,
      int chargecode,
      string companylineguid,
      int glacctid)
    {
      dsIssueCheckEntries.EntriesRow row = (dsIssueCheckEntries.EntriesRow) this.NewRow();
      row.ItemArray = new object[7]
      {
        (object) Description,
        (object) _Debit_Amt_,
        (object) _Credit_Amt_,
        (object) invoicenum,
        (object) chargecode,
        (object) companylineguid,
        (object) glacctid
      };
      this.Rows.Add((DataRow) row);
      return row;
    }

    public IEnumerator GetEnumerator() => this.Rows.GetEnumerator();

    public override DataTable Clone()
    {
      dsIssueCheckEntries.EntriesDataTable entriesDataTable = (dsIssueCheckEntries.EntriesDataTable) base.Clone();
      entriesDataTable.InitVars();
      return (DataTable) entriesDataTable;
    }

    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsIssueCheckEntries.EntriesDataTable();
    }

    internal void InitVars()
    {
      this.columnDescription = this.Columns["Description"];
      this.column_Debit_Amt_ = this.Columns["Debit Amt."];
      this.column_Credit_Amt_ = this.Columns["Credit Amt."];
      this.columninvoicenum = this.Columns["invoicenum"];
      this.columnchargecode = this.Columns["chargecode"];
      this.columncompanylineguid = this.Columns["companylineguid"];
      this.columnglacctid = this.Columns["glacctid"];
    }

    private void InitClass()
    {
      this.columnDescription = new DataColumn("Description", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDescription);
      this.column_Debit_Amt_ = new DataColumn("Debit Amt.", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.column_Debit_Amt_);
      this.column_Credit_Amt_ = new DataColumn("Credit Amt.", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.column_Credit_Amt_);
      this.columninvoicenum = new DataColumn("invoicenum", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columninvoicenum);
      this.columnchargecode = new DataColumn("chargecode", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnchargecode);
      this.columncompanylineguid = new DataColumn("companylineguid", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columncompanylineguid);
      this.columnglacctid = new DataColumn("glacctid", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnglacctid);
    }

    public dsIssueCheckEntries.EntriesRow NewEntriesRow()
    {
      return (dsIssueCheckEntries.EntriesRow) this.NewRow();
    }

    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsIssueCheckEntries.EntriesRow(builder);
    }

    protected override Type GetRowType() => typeof (dsIssueCheckEntries.EntriesRow);

    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.EntriesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsIssueCheckEntries.EntriesRowChangeEventHandler entriesRowChangedEvent = this.EntriesRowChangedEvent;
      if (entriesRowChangedEvent == null)
        return;
      entriesRowChangedEvent((object) this, new dsIssueCheckEntries.EntriesRowChangeEvent((dsIssueCheckEntries.EntriesRow) e.Row, e.Action));
    }

    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.EntriesRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsIssueCheckEntries.EntriesRowChangeEventHandler rowChangingEvent = this.EntriesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsIssueCheckEntries.EntriesRowChangeEvent((dsIssueCheckEntries.EntriesRow) e.Row, e.Action));
    }

    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.EntriesRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsIssueCheckEntries.EntriesRowChangeEventHandler entriesRowDeletedEvent = this.EntriesRowDeletedEvent;
      if (entriesRowDeletedEvent == null)
        return;
      entriesRowDeletedEvent((object) this, new dsIssueCheckEntries.EntriesRowChangeEvent((dsIssueCheckEntries.EntriesRow) e.Row, e.Action));
    }

    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.EntriesRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsIssueCheckEntries.EntriesRowChangeEventHandler rowDeletingEvent = this.EntriesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsIssueCheckEntries.EntriesRowChangeEvent((dsIssueCheckEntries.EntriesRow) e.Row, e.Action));
    }

    public void RemoveEntriesRow(dsIssueCheckEntries.EntriesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }
  }

  [DebuggerStepThrough]
  public class EntriesRow : DataRow
  {
    private dsIssueCheckEntries.EntriesDataTable tableEntries;

    internal EntriesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableEntries = (dsIssueCheckEntries.EntriesDataTable) this.Table;
    }

    public string Description
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableEntries.DescriptionColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableEntries.DescriptionColumn] = (object) value;
    }

    public Decimal _Debit_Amt_
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tableEntries._Debit_Amt_Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableEntries._Debit_Amt_Column] = (object) value;
    }

    public Decimal _Credit_Amt_
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tableEntries._Credit_Amt_Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableEntries._Credit_Amt_Column] = (object) value;
    }

    public int invoicenum
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tableEntries.invoicenumColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableEntries.invoicenumColumn] = (object) value;
    }

    public int chargecode
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tableEntries.chargecodeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableEntries.chargecodeColumn] = (object) value;
    }

    public string companylineguid
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableEntries.companylineguidColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableEntries.companylineguidColumn] = (object) value;
    }

    public int glacctid
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tableEntries.glacctidColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableEntries.glacctidColumn] = (object) value;
    }

    public bool IsDescriptionNull() => this.IsNull(this.tableEntries.DescriptionColumn);

    public void SetDescriptionNull()
    {
      this[this.tableEntries.DescriptionColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool Is_Debit_Amt_Null() => this.IsNull(this.tableEntries._Debit_Amt_Column);

    public void Set_Debit_Amt_Null()
    {
      this[this.tableEntries._Debit_Amt_Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool Is_Credit_Amt_Null() => this.IsNull(this.tableEntries._Credit_Amt_Column);

    public void Set_Credit_Amt_Null()
    {
      this[this.tableEntries._Credit_Amt_Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsinvoicenumNull() => this.IsNull(this.tableEntries.invoicenumColumn);

    public void SetinvoicenumNull()
    {
      this[this.tableEntries.invoicenumColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IschargecodeNull() => this.IsNull(this.tableEntries.chargecodeColumn);

    public void SetchargecodeNull()
    {
      this[this.tableEntries.chargecodeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IscompanylineguidNull() => this.IsNull(this.tableEntries.companylineguidColumn);

    public void SetcompanylineguidNull()
    {
      this[this.tableEntries.companylineguidColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsglacctidNull() => this.IsNull(this.tableEntries.glacctidColumn);

    public void SetglacctidNull()
    {
      this[this.tableEntries.glacctidColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  [DebuggerStepThrough]
  public class EntriesRowChangeEvent : EventArgs
  {
    private dsIssueCheckEntries.EntriesRow eventRow;
    private DataRowAction eventAction;

    public EntriesRowChangeEvent(dsIssueCheckEntries.EntriesRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    public dsIssueCheckEntries.EntriesRow Row => this.eventRow;

    public DataRowAction Action => this.eventAction;
  }
}
