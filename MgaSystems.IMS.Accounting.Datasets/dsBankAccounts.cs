// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.AccountingDatasets.dsBankAccounts
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
public class dsBankAccounts : DataSet
{
  private dsBankAccounts.spFin_GetBankAccountsDataTable tablespFin_GetBankAccounts;

  public dsBankAccounts()
  {
    this.InitClass();
    CollectionChangeEventHandler changeEventHandler = new CollectionChangeEventHandler(this.SchemaChanged);
    this.Tables.CollectionChanged += changeEventHandler;
    this.Relations.CollectionChanged += changeEventHandler;
  }

  protected dsBankAccounts(SerializationInfo info, StreamingContext context)
  {
    string s = Conversions.ToString(info.GetValue("XmlSchema", typeof (string)));
    if (s != null)
    {
      DataSet dataSet = new DataSet();
      dataSet.ReadXmlSchema((XmlReader) new XmlTextReader((TextReader) new StringReader(s)));
      if (dataSet.Tables[nameof (spFin_GetBankAccounts)] != null)
        this.Tables.Add((DataTable) new dsBankAccounts.spFin_GetBankAccountsDataTable(dataSet.Tables[nameof (spFin_GetBankAccounts)]));
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
  public dsBankAccounts.spFin_GetBankAccountsDataTable spFin_GetBankAccounts
  {
    get => this.tablespFin_GetBankAccounts;
  }

  public override DataSet Clone()
  {
    dsBankAccounts dsBankAccounts = (dsBankAccounts) base.Clone();
    dsBankAccounts.InitVars();
    return (DataSet) dsBankAccounts;
  }

  protected override bool ShouldSerializeTables() => false;

  protected override bool ShouldSerializeRelations() => false;

  protected override void ReadXmlSerializable(XmlReader reader)
  {
    this.Reset();
    DataSet dataSet = new DataSet();
    int num = (int) dataSet.ReadXml(reader);
    if (dataSet.Tables["spFin_GetBankAccounts"] != null)
      this.Tables.Add((DataTable) new dsBankAccounts.spFin_GetBankAccountsDataTable(dataSet.Tables["spFin_GetBankAccounts"]));
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
    this.tablespFin_GetBankAccounts = (dsBankAccounts.spFin_GetBankAccountsDataTable) this.Tables["spFin_GetBankAccounts"];
    if (this.tablespFin_GetBankAccounts == null)
      return;
    this.tablespFin_GetBankAccounts.InitVars();
  }

  private void InitClass()
  {
    this.DataSetName = nameof (dsBankAccounts);
    this.Prefix = "";
    this.Namespace = "http://www.tempuri.org/dsBankAccounts.xsd";
    this.Locale = new CultureInfo("en-US");
    this.CaseSensitive = false;
    this.EnforceConstraints = true;
    this.tablespFin_GetBankAccounts = new dsBankAccounts.spFin_GetBankAccountsDataTable();
    this.Tables.Add((DataTable) this.tablespFin_GetBankAccounts);
  }

  private bool ShouldSerializespFin_GetBankAccounts() => false;

  private void SchemaChanged(object sender, CollectionChangeEventArgs e)
  {
    if (e.Action != CollectionChangeAction.Remove)
      return;
    this.InitVars();
  }

  public delegate void spFin_GetBankAccountsRowChangeEventHandler(
    object sender,
    dsBankAccounts.spFin_GetBankAccountsRowChangeEvent e);

  [DebuggerStepThrough]
  public class spFin_GetBankAccountsDataTable : DataTable, IEnumerable
  {
    private DataColumn columnGLACCTID;
    private DataColumn columnBANKNAME;
    private DataColumn columnCLOSED;

    internal spFin_GetBankAccountsDataTable()
      : base("spFin_GetBankAccounts")
    {
      this.InitClass();
    }

    internal spFin_GetBankAccountsDataTable(DataTable table)
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

    internal DataColumn GLACCTIDColumn => this.columnGLACCTID;

    internal DataColumn BANKNAMEColumn => this.columnBANKNAME;

    internal DataColumn CLOSEDColumn => this.columnCLOSED;

    public dsBankAccounts.spFin_GetBankAccountsRow this[int index]
    {
      get => (dsBankAccounts.spFin_GetBankAccountsRow) this.Rows[index];
    }

    public event dsBankAccounts.spFin_GetBankAccountsRowChangeEventHandler spFin_GetBankAccountsRowChanged;

    public event dsBankAccounts.spFin_GetBankAccountsRowChangeEventHandler spFin_GetBankAccountsRowChanging;

    public event dsBankAccounts.spFin_GetBankAccountsRowChangeEventHandler spFin_GetBankAccountsRowDeleted;

    public event dsBankAccounts.spFin_GetBankAccountsRowChangeEventHandler spFin_GetBankAccountsRowDeleting;

    public void AddspFin_GetBankAccountsRow(dsBankAccounts.spFin_GetBankAccountsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    public dsBankAccounts.spFin_GetBankAccountsRow AddspFin_GetBankAccountsRow(
      int GLACCTID,
      string BANKNAME,
      int CLOSED)
    {
      dsBankAccounts.spFin_GetBankAccountsRow row = (dsBankAccounts.spFin_GetBankAccountsRow) this.NewRow();
      row.ItemArray = new object[3]
      {
        (object) GLACCTID,
        (object) BANKNAME,
        (object) CLOSED
      };
      this.Rows.Add((DataRow) row);
      return row;
    }

    public IEnumerator GetEnumerator() => this.Rows.GetEnumerator();

    public override DataTable Clone()
    {
      dsBankAccounts.spFin_GetBankAccountsDataTable accountsDataTable = (dsBankAccounts.spFin_GetBankAccountsDataTable) base.Clone();
      accountsDataTable.InitVars();
      return (DataTable) accountsDataTable;
    }

    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsBankAccounts.spFin_GetBankAccountsDataTable();
    }

    internal void InitVars()
    {
      this.columnGLACCTID = this.Columns["GLACCTID"];
      this.columnBANKNAME = this.Columns["BANKNAME"];
      this.columnCLOSED = this.Columns["CLOSED"];
    }

    private void InitClass()
    {
      this.columnGLACCTID = new DataColumn("GLACCTID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnGLACCTID);
      this.columnBANKNAME = new DataColumn("BANKNAME", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnBANKNAME);
      this.columnCLOSED = new DataColumn("CLOSED", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCLOSED);
      this.columnGLACCTID.ReadOnly = true;
      this.columnBANKNAME.ReadOnly = true;
      this.columnCLOSED.ReadOnly = true;
    }

    public dsBankAccounts.spFin_GetBankAccountsRow NewspFin_GetBankAccountsRow()
    {
      return (dsBankAccounts.spFin_GetBankAccountsRow) this.NewRow();
    }

    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsBankAccounts.spFin_GetBankAccountsRow(builder);
    }

    protected override Type GetRowType() => typeof (dsBankAccounts.spFin_GetBankAccountsRow);

    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.spFin_GetBankAccountsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsBankAccounts.spFin_GetBankAccountsRowChangeEventHandler accountsRowChangedEvent = this.spFin_GetBankAccountsRowChangedEvent;
      if (accountsRowChangedEvent == null)
        return;
      accountsRowChangedEvent((object) this, new dsBankAccounts.spFin_GetBankAccountsRowChangeEvent((dsBankAccounts.spFin_GetBankAccountsRow) e.Row, e.Action));
    }

    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.spFin_GetBankAccountsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsBankAccounts.spFin_GetBankAccountsRowChangeEventHandler rowChangingEvent = this.spFin_GetBankAccountsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsBankAccounts.spFin_GetBankAccountsRowChangeEvent((dsBankAccounts.spFin_GetBankAccountsRow) e.Row, e.Action));
    }

    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.spFin_GetBankAccountsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsBankAccounts.spFin_GetBankAccountsRowChangeEventHandler accountsRowDeletedEvent = this.spFin_GetBankAccountsRowDeletedEvent;
      if (accountsRowDeletedEvent == null)
        return;
      accountsRowDeletedEvent((object) this, new dsBankAccounts.spFin_GetBankAccountsRowChangeEvent((dsBankAccounts.spFin_GetBankAccountsRow) e.Row, e.Action));
    }

    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.spFin_GetBankAccountsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsBankAccounts.spFin_GetBankAccountsRowChangeEventHandler rowDeletingEvent = this.spFin_GetBankAccountsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsBankAccounts.spFin_GetBankAccountsRowChangeEvent((dsBankAccounts.spFin_GetBankAccountsRow) e.Row, e.Action));
    }

    public void RemovespFin_GetBankAccountsRow(dsBankAccounts.spFin_GetBankAccountsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }
  }

  [DebuggerStepThrough]
  public class spFin_GetBankAccountsRow : DataRow
  {
    private dsBankAccounts.spFin_GetBankAccountsDataTable tablespFin_GetBankAccounts;

    internal spFin_GetBankAccountsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablespFin_GetBankAccounts = (dsBankAccounts.spFin_GetBankAccountsDataTable) this.Table;
    }

    public int GLACCTID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tablespFin_GetBankAccounts.GLACCTIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablespFin_GetBankAccounts.GLACCTIDColumn] = (object) value;
    }

    public string BANKNAME
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablespFin_GetBankAccounts.BANKNAMEColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablespFin_GetBankAccounts.BANKNAMEColumn] = (object) value;
    }

    public int CLOSED
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tablespFin_GetBankAccounts.CLOSEDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablespFin_GetBankAccounts.CLOSEDColumn] = (object) value;
    }

    public bool IsGLACCTIDNull() => this.IsNull(this.tablespFin_GetBankAccounts.GLACCTIDColumn);

    public void SetGLACCTIDNull()
    {
      this[this.tablespFin_GetBankAccounts.GLACCTIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsBANKNAMENull() => this.IsNull(this.tablespFin_GetBankAccounts.BANKNAMEColumn);

    public void SetBANKNAMENull()
    {
      this[this.tablespFin_GetBankAccounts.BANKNAMEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsCLOSEDNull() => this.IsNull(this.tablespFin_GetBankAccounts.CLOSEDColumn);

    public void SetCLOSEDNull()
    {
      this[this.tablespFin_GetBankAccounts.CLOSEDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  [DebuggerStepThrough]
  public class spFin_GetBankAccountsRowChangeEvent : EventArgs
  {
    private dsBankAccounts.spFin_GetBankAccountsRow eventRow;
    private DataRowAction eventAction;

    public spFin_GetBankAccountsRowChangeEvent(
      dsBankAccounts.spFin_GetBankAccountsRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    public dsBankAccounts.spFin_GetBankAccountsRow Row => this.eventRow;

    public DataRowAction Action => this.eventAction;
  }
}
