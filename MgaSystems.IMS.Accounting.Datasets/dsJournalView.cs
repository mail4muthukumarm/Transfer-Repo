// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.AccountingDatasets.dsJournalView
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
public class dsJournalView : DataSet
{
  private dsJournalView.spFin_JournalViewDataTable tablespFin_JournalView;

  public dsJournalView()
  {
    this.InitClass();
    CollectionChangeEventHandler changeEventHandler = new CollectionChangeEventHandler(this.SchemaChanged);
    this.Tables.CollectionChanged += changeEventHandler;
    this.Relations.CollectionChanged += changeEventHandler;
  }

  protected dsJournalView(SerializationInfo info, StreamingContext context)
  {
    string s = Conversions.ToString(info.GetValue("XmlSchema", typeof (string)));
    if (s != null)
    {
      DataSet dataSet = new DataSet();
      dataSet.ReadXmlSchema((XmlReader) new XmlTextReader((TextReader) new StringReader(s)));
      if (dataSet.Tables[nameof (spFin_JournalView)] != null)
        this.Tables.Add((DataTable) new dsJournalView.spFin_JournalViewDataTable(dataSet.Tables[nameof (spFin_JournalView)]));
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
  public dsJournalView.spFin_JournalViewDataTable spFin_JournalView => this.tablespFin_JournalView;

  public override DataSet Clone()
  {
    dsJournalView dsJournalView = (dsJournalView) base.Clone();
    dsJournalView.InitVars();
    return (DataSet) dsJournalView;
  }

  protected override bool ShouldSerializeTables() => false;

  protected override bool ShouldSerializeRelations() => false;

  protected override void ReadXmlSerializable(XmlReader reader)
  {
    this.Reset();
    DataSet dataSet = new DataSet();
    int num = (int) dataSet.ReadXml(reader);
    if (dataSet.Tables["spFin_JournalView"] != null)
      this.Tables.Add((DataTable) new dsJournalView.spFin_JournalViewDataTable(dataSet.Tables["spFin_JournalView"]));
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
    this.tablespFin_JournalView = (dsJournalView.spFin_JournalViewDataTable) this.Tables["spFin_JournalView"];
    if (this.tablespFin_JournalView == null)
      return;
    this.tablespFin_JournalView.InitVars();
  }

  private void InitClass()
  {
    this.DataSetName = nameof (dsJournalView);
    this.Prefix = "";
    this.Namespace = "http://tempuri.org/dsJournalView.xsd";
    this.Locale = new CultureInfo("en-US");
    this.CaseSensitive = false;
    this.EnforceConstraints = true;
    this.tablespFin_JournalView = new dsJournalView.spFin_JournalViewDataTable();
    this.Tables.Add((DataTable) this.tablespFin_JournalView);
  }

  private bool ShouldSerializespFin_JournalView() => false;

  private void SchemaChanged(object sender, CollectionChangeEventArgs e)
  {
    if (e.Action != CollectionChangeAction.Remove)
      return;
    this.InitVars();
  }

  public delegate void spFin_JournalViewRowChangeEventHandler(
    object sender,
    dsJournalView.spFin_JournalViewRowChangeEvent e);

  [DebuggerStepThrough]
  public class spFin_JournalViewDataTable : DataTable, IEnumerable
  {
    private DataColumn column_TRANSACTION__;
    private DataColumn columnTRANSACTION_DATE;
    private DataColumn columnDATE_STUB;
    private DataColumn columnDAY_STUB;
    private DataColumn columnGL_ACCT_NAME;
    private DataColumn columnDEBIT;
    private DataColumn columnCREDIT;
    private DataColumn columnVOID;

    internal spFin_JournalViewDataTable()
      : base("spFin_JournalView")
    {
      this.InitClass();
    }

    internal spFin_JournalViewDataTable(DataTable table)
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

    internal DataColumn _TRANSACTION__Column => this.column_TRANSACTION__;

    internal DataColumn TRANSACTION_DATEColumn => this.columnTRANSACTION_DATE;

    internal DataColumn DATE_STUBColumn => this.columnDATE_STUB;

    internal DataColumn DAY_STUBColumn => this.columnDAY_STUB;

    internal DataColumn GL_ACCT_NAMEColumn => this.columnGL_ACCT_NAME;

    internal DataColumn DEBITColumn => this.columnDEBIT;

    internal DataColumn CREDITColumn => this.columnCREDIT;

    internal DataColumn VOIDColumn => this.columnVOID;

    public dsJournalView.spFin_JournalViewRow this[int index]
    {
      get => (dsJournalView.spFin_JournalViewRow) this.Rows[index];
    }

    public event dsJournalView.spFin_JournalViewRowChangeEventHandler spFin_JournalViewRowChanged;

    public event dsJournalView.spFin_JournalViewRowChangeEventHandler spFin_JournalViewRowChanging;

    public event dsJournalView.spFin_JournalViewRowChangeEventHandler spFin_JournalViewRowDeleted;

    public event dsJournalView.spFin_JournalViewRowChangeEventHandler spFin_JournalViewRowDeleting;

    public void AddspFin_JournalViewRow(dsJournalView.spFin_JournalViewRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    public dsJournalView.spFin_JournalViewRow AddspFin_JournalViewRow(
      int _TRANSACTION__,
      DateTime TRANSACTION_DATE,
      string DATE_STUB,
      int DAY_STUB,
      string GL_ACCT_NAME,
      Decimal DEBIT,
      Decimal CREDIT,
      bool VOID)
    {
      dsJournalView.spFin_JournalViewRow row = (dsJournalView.spFin_JournalViewRow) this.NewRow();
      row.ItemArray = new object[8]
      {
        (object) _TRANSACTION__,
        (object) TRANSACTION_DATE,
        (object) DATE_STUB,
        (object) DAY_STUB,
        (object) GL_ACCT_NAME,
        (object) DEBIT,
        (object) CREDIT,
        (object) VOID
      };
      this.Rows.Add((DataRow) row);
      return row;
    }

    public IEnumerator GetEnumerator() => this.Rows.GetEnumerator();

    public override DataTable Clone()
    {
      dsJournalView.spFin_JournalViewDataTable journalViewDataTable = (dsJournalView.spFin_JournalViewDataTable) base.Clone();
      journalViewDataTable.InitVars();
      return (DataTable) journalViewDataTable;
    }

    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsJournalView.spFin_JournalViewDataTable();
    }

    internal void InitVars()
    {
      this.column_TRANSACTION__ = this.Columns["TRANSACTION #"];
      this.columnTRANSACTION_DATE = this.Columns["TRANSACTION DATE"];
      this.columnDATE_STUB = this.Columns["DATE STUB"];
      this.columnDAY_STUB = this.Columns["DAY STUB"];
      this.columnGL_ACCT_NAME = this.Columns["GL ACCT NAME"];
      this.columnDEBIT = this.Columns["DEBIT"];
      this.columnCREDIT = this.Columns["CREDIT"];
      this.columnVOID = this.Columns["VOID"];
    }

    private void InitClass()
    {
      this.column_TRANSACTION__ = new DataColumn("TRANSACTION #", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.column_TRANSACTION__);
      this.columnTRANSACTION_DATE = new DataColumn("TRANSACTION DATE", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnTRANSACTION_DATE);
      this.columnDATE_STUB = new DataColumn("DATE STUB", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDATE_STUB);
      this.columnDAY_STUB = new DataColumn("DAY STUB", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDAY_STUB);
      this.columnGL_ACCT_NAME = new DataColumn("GL ACCT NAME", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnGL_ACCT_NAME);
      this.columnDEBIT = new DataColumn("DEBIT", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDEBIT);
      this.columnCREDIT = new DataColumn("CREDIT", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCREDIT);
      this.columnVOID = new DataColumn("VOID", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnVOID);
    }

    public dsJournalView.spFin_JournalViewRow NewspFin_JournalViewRow()
    {
      return (dsJournalView.spFin_JournalViewRow) this.NewRow();
    }

    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsJournalView.spFin_JournalViewRow(builder);
    }

    protected override Type GetRowType() => typeof (dsJournalView.spFin_JournalViewRow);

    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.spFin_JournalViewRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsJournalView.spFin_JournalViewRowChangeEventHandler viewRowChangedEvent = this.spFin_JournalViewRowChangedEvent;
      if (viewRowChangedEvent == null)
        return;
      viewRowChangedEvent((object) this, new dsJournalView.spFin_JournalViewRowChangeEvent((dsJournalView.spFin_JournalViewRow) e.Row, e.Action));
    }

    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.spFin_JournalViewRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsJournalView.spFin_JournalViewRowChangeEventHandler rowChangingEvent = this.spFin_JournalViewRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsJournalView.spFin_JournalViewRowChangeEvent((dsJournalView.spFin_JournalViewRow) e.Row, e.Action));
    }

    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.spFin_JournalViewRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsJournalView.spFin_JournalViewRowChangeEventHandler viewRowDeletedEvent = this.spFin_JournalViewRowDeletedEvent;
      if (viewRowDeletedEvent == null)
        return;
      viewRowDeletedEvent((object) this, new dsJournalView.spFin_JournalViewRowChangeEvent((dsJournalView.spFin_JournalViewRow) e.Row, e.Action));
    }

    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.spFin_JournalViewRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsJournalView.spFin_JournalViewRowChangeEventHandler rowDeletingEvent = this.spFin_JournalViewRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsJournalView.spFin_JournalViewRowChangeEvent((dsJournalView.spFin_JournalViewRow) e.Row, e.Action));
    }

    public void RemovespFin_JournalViewRow(dsJournalView.spFin_JournalViewRow row)
    {
      this.Rows.Remove((DataRow) row);
    }
  }

  [DebuggerStepThrough]
  public class spFin_JournalViewRow : DataRow
  {
    private dsJournalView.spFin_JournalViewDataTable tablespFin_JournalView;

    internal spFin_JournalViewRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablespFin_JournalView = (dsJournalView.spFin_JournalViewDataTable) this.Table;
    }

    public int _TRANSACTION__
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tablespFin_JournalView._TRANSACTION__Column]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablespFin_JournalView._TRANSACTION__Column] = (object) value;
    }

    public DateTime TRANSACTION_DATE
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tablespFin_JournalView.TRANSACTION_DATEColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablespFin_JournalView.TRANSACTION_DATEColumn] = (object) value;
    }

    public string DATE_STUB
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablespFin_JournalView.DATE_STUBColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablespFin_JournalView.DATE_STUBColumn] = (object) value;
    }

    public int DAY_STUB
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tablespFin_JournalView.DAY_STUBColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablespFin_JournalView.DAY_STUBColumn] = (object) value;
    }

    public string GL_ACCT_NAME
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablespFin_JournalView.GL_ACCT_NAMEColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablespFin_JournalView.GL_ACCT_NAMEColumn] = (object) value;
    }

    public Decimal DEBIT
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tablespFin_JournalView.DEBITColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablespFin_JournalView.DEBITColumn] = (object) value;
    }

    public Decimal CREDIT
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tablespFin_JournalView.CREDITColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablespFin_JournalView.CREDITColumn] = (object) value;
    }

    public bool VOID
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tablespFin_JournalView.VOIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablespFin_JournalView.VOIDColumn] = (object) value;
    }

    public bool Is_TRANSACTION__Null()
    {
      return this.IsNull(this.tablespFin_JournalView._TRANSACTION__Column);
    }

    public void Set_TRANSACTION__Null()
    {
      this[this.tablespFin_JournalView._TRANSACTION__Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsTRANSACTION_DATENull()
    {
      return this.IsNull(this.tablespFin_JournalView.TRANSACTION_DATEColumn);
    }

    public void SetTRANSACTION_DATENull()
    {
      this[this.tablespFin_JournalView.TRANSACTION_DATEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsDATE_STUBNull() => this.IsNull(this.tablespFin_JournalView.DATE_STUBColumn);

    public void SetDATE_STUBNull()
    {
      this[this.tablespFin_JournalView.DATE_STUBColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsDAY_STUBNull() => this.IsNull(this.tablespFin_JournalView.DAY_STUBColumn);

    public void SetDAY_STUBNull()
    {
      this[this.tablespFin_JournalView.DAY_STUBColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsGL_ACCT_NAMENull() => this.IsNull(this.tablespFin_JournalView.GL_ACCT_NAMEColumn);

    public void SetGL_ACCT_NAMENull()
    {
      this[this.tablespFin_JournalView.GL_ACCT_NAMEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsDEBITNull() => this.IsNull(this.tablespFin_JournalView.DEBITColumn);

    public void SetDEBITNull()
    {
      this[this.tablespFin_JournalView.DEBITColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsCREDITNull() => this.IsNull(this.tablespFin_JournalView.CREDITColumn);

    public void SetCREDITNull()
    {
      this[this.tablespFin_JournalView.CREDITColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsVOIDNull() => this.IsNull(this.tablespFin_JournalView.VOIDColumn);

    public void SetVOIDNull()
    {
      this[this.tablespFin_JournalView.VOIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  [DebuggerStepThrough]
  public class spFin_JournalViewRowChangeEvent : EventArgs
  {
    private dsJournalView.spFin_JournalViewRow eventRow;
    private DataRowAction eventAction;

    public spFin_JournalViewRowChangeEvent(
      dsJournalView.spFin_JournalViewRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    public dsJournalView.spFin_JournalViewRow Row => this.eventRow;

    public DataRowAction Action => this.eventAction;
  }
}
