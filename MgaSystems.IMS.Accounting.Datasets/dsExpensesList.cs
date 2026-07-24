// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.AccountingDatasets.dsExpensesList
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
public class dsExpensesList : DataSet
{
  private dsExpensesList.spFin_GetExpensesListDataTable tablespFin_GetExpensesList;

  public dsExpensesList()
  {
    this.InitClass();
    CollectionChangeEventHandler changeEventHandler = new CollectionChangeEventHandler(this.SchemaChanged);
    this.Tables.CollectionChanged += changeEventHandler;
    this.Relations.CollectionChanged += changeEventHandler;
  }

  protected dsExpensesList(SerializationInfo info, StreamingContext context)
  {
    string s = Conversions.ToString(info.GetValue("XmlSchema", typeof (string)));
    if (s != null)
    {
      DataSet dataSet = new DataSet();
      dataSet.ReadXmlSchema((XmlReader) new XmlTextReader((TextReader) new StringReader(s)));
      if (dataSet.Tables[nameof (spFin_GetExpensesList)] != null)
        this.Tables.Add((DataTable) new dsExpensesList.spFin_GetExpensesListDataTable(dataSet.Tables[nameof (spFin_GetExpensesList)]));
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
  public dsExpensesList.spFin_GetExpensesListDataTable spFin_GetExpensesList
  {
    get => this.tablespFin_GetExpensesList;
  }

  public override DataSet Clone()
  {
    dsExpensesList dsExpensesList = (dsExpensesList) base.Clone();
    dsExpensesList.InitVars();
    return (DataSet) dsExpensesList;
  }

  protected override bool ShouldSerializeTables() => false;

  protected override bool ShouldSerializeRelations() => false;

  protected override void ReadXmlSerializable(XmlReader reader)
  {
    this.Reset();
    DataSet dataSet = new DataSet();
    int num = (int) dataSet.ReadXml(reader);
    if (dataSet.Tables["spFin_GetExpensesList"] != null)
      this.Tables.Add((DataTable) new dsExpensesList.spFin_GetExpensesListDataTable(dataSet.Tables["spFin_GetExpensesList"]));
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
    this.tablespFin_GetExpensesList = (dsExpensesList.spFin_GetExpensesListDataTable) this.Tables["spFin_GetExpensesList"];
    if (this.tablespFin_GetExpensesList == null)
      return;
    this.tablespFin_GetExpensesList.InitVars();
  }

  private void InitClass()
  {
    this.DataSetName = nameof (dsExpensesList);
    this.Prefix = "";
    this.Namespace = "http://www.tempuri.org/dsExpensesList.xsd";
    this.Locale = new CultureInfo("en-US");
    this.CaseSensitive = false;
    this.EnforceConstraints = true;
    this.tablespFin_GetExpensesList = new dsExpensesList.spFin_GetExpensesListDataTable();
    this.Tables.Add((DataTable) this.tablespFin_GetExpensesList);
  }

  private bool ShouldSerializespFin_GetExpensesList() => false;

  private void SchemaChanged(object sender, CollectionChangeEventArgs e)
  {
    if (e.Action != CollectionChangeAction.Remove)
      return;
    this.InitVars();
  }

  public delegate void spFin_GetExpensesListRowChangeEventHandler(
    object sender,
    dsExpensesList.spFin_GetExpensesListRowChangeEvent e);

  [DebuggerStepThrough]
  public class spFin_GetExpensesListDataTable : DataTable, IEnumerable
  {
    private DataColumn columnEXPENSECODE;
    private DataColumn columnEXPENSENAME;
    private DataColumn columnGLCOMPANYID;
    private DataColumn columnGLACCTID;
    private DataColumn columnGLACCTFULLNAME;

    internal spFin_GetExpensesListDataTable()
      : base("spFin_GetExpensesList")
    {
      this.InitClass();
    }

    internal spFin_GetExpensesListDataTable(DataTable table)
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

    internal DataColumn EXPENSECODEColumn => this.columnEXPENSECODE;

    internal DataColumn EXPENSENAMEColumn => this.columnEXPENSENAME;

    internal DataColumn GLCOMPANYIDColumn => this.columnGLCOMPANYID;

    internal DataColumn GLACCTIDColumn => this.columnGLACCTID;

    internal DataColumn GLACCTFULLNAMEColumn => this.columnGLACCTFULLNAME;

    public dsExpensesList.spFin_GetExpensesListRow this[int index]
    {
      get => (dsExpensesList.spFin_GetExpensesListRow) this.Rows[index];
    }

    public event dsExpensesList.spFin_GetExpensesListRowChangeEventHandler spFin_GetExpensesListRowChanged;

    public event dsExpensesList.spFin_GetExpensesListRowChangeEventHandler spFin_GetExpensesListRowChanging;

    public event dsExpensesList.spFin_GetExpensesListRowChangeEventHandler spFin_GetExpensesListRowDeleted;

    public event dsExpensesList.spFin_GetExpensesListRowChangeEventHandler spFin_GetExpensesListRowDeleting;

    public void AddspFin_GetExpensesListRow(dsExpensesList.spFin_GetExpensesListRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    public dsExpensesList.spFin_GetExpensesListRow AddspFin_GetExpensesListRow(
      string EXPENSENAME,
      int GLCOMPANYID,
      int GLACCTID,
      string GLACCTFULLNAME)
    {
      dsExpensesList.spFin_GetExpensesListRow row = (dsExpensesList.spFin_GetExpensesListRow) this.NewRow();
      row.ItemArray = new object[5]
      {
        null,
        (object) EXPENSENAME,
        (object) GLCOMPANYID,
        (object) GLACCTID,
        (object) GLACCTFULLNAME
      };
      this.Rows.Add((DataRow) row);
      return row;
    }

    public dsExpensesList.spFin_GetExpensesListRow FindByEXPENSECODE(int EXPENSECODE)
    {
      return (dsExpensesList.spFin_GetExpensesListRow) this.Rows.Find(new object[1]
      {
        (object) EXPENSECODE
      });
    }

    public IEnumerator GetEnumerator() => this.Rows.GetEnumerator();

    public override DataTable Clone()
    {
      dsExpensesList.spFin_GetExpensesListDataTable expensesListDataTable = (dsExpensesList.spFin_GetExpensesListDataTable) base.Clone();
      expensesListDataTable.InitVars();
      return (DataTable) expensesListDataTable;
    }

    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsExpensesList.spFin_GetExpensesListDataTable();
    }

    internal void InitVars()
    {
      this.columnEXPENSECODE = this.Columns["EXPENSECODE"];
      this.columnEXPENSENAME = this.Columns["EXPENSENAME"];
      this.columnGLCOMPANYID = this.Columns["GLCOMPANYID"];
      this.columnGLACCTID = this.Columns["GLACCTID"];
      this.columnGLACCTFULLNAME = this.Columns["GLACCTFULLNAME"];
    }

    private void InitClass()
    {
      this.columnEXPENSECODE = new DataColumn("EXPENSECODE", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEXPENSECODE);
      this.columnEXPENSENAME = new DataColumn("EXPENSENAME", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEXPENSENAME);
      this.columnGLCOMPANYID = new DataColumn("GLCOMPANYID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnGLCOMPANYID);
      this.columnGLACCTID = new DataColumn("GLACCTID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnGLACCTID);
      this.columnGLACCTFULLNAME = new DataColumn("GLACCTFULLNAME", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnGLACCTFULLNAME);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnEXPENSECODE
      }, true));
      this.columnEXPENSECODE.AutoIncrement = true;
      this.columnEXPENSECODE.AllowDBNull = false;
      this.columnEXPENSECODE.ReadOnly = true;
      this.columnEXPENSECODE.Unique = true;
      this.columnEXPENSENAME.AllowDBNull = false;
    }

    public dsExpensesList.spFin_GetExpensesListRow NewspFin_GetExpensesListRow()
    {
      return (dsExpensesList.spFin_GetExpensesListRow) this.NewRow();
    }

    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsExpensesList.spFin_GetExpensesListRow(builder);
    }

    protected override Type GetRowType() => typeof (dsExpensesList.spFin_GetExpensesListRow);

    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.spFin_GetExpensesListRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsExpensesList.spFin_GetExpensesListRowChangeEventHandler listRowChangedEvent = this.spFin_GetExpensesListRowChangedEvent;
      if (listRowChangedEvent == null)
        return;
      listRowChangedEvent((object) this, new dsExpensesList.spFin_GetExpensesListRowChangeEvent((dsExpensesList.spFin_GetExpensesListRow) e.Row, e.Action));
    }

    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.spFin_GetExpensesListRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsExpensesList.spFin_GetExpensesListRowChangeEventHandler rowChangingEvent = this.spFin_GetExpensesListRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsExpensesList.spFin_GetExpensesListRowChangeEvent((dsExpensesList.spFin_GetExpensesListRow) e.Row, e.Action));
    }

    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.spFin_GetExpensesListRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsExpensesList.spFin_GetExpensesListRowChangeEventHandler listRowDeletedEvent = this.spFin_GetExpensesListRowDeletedEvent;
      if (listRowDeletedEvent == null)
        return;
      listRowDeletedEvent((object) this, new dsExpensesList.spFin_GetExpensesListRowChangeEvent((dsExpensesList.spFin_GetExpensesListRow) e.Row, e.Action));
    }

    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.spFin_GetExpensesListRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsExpensesList.spFin_GetExpensesListRowChangeEventHandler rowDeletingEvent = this.spFin_GetExpensesListRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsExpensesList.spFin_GetExpensesListRowChangeEvent((dsExpensesList.spFin_GetExpensesListRow) e.Row, e.Action));
    }

    public void RemovespFin_GetExpensesListRow(dsExpensesList.spFin_GetExpensesListRow row)
    {
      this.Rows.Remove((DataRow) row);
    }
  }

  [DebuggerStepThrough]
  public class spFin_GetExpensesListRow : DataRow
  {
    private dsExpensesList.spFin_GetExpensesListDataTable tablespFin_GetExpensesList;

    internal spFin_GetExpensesListRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablespFin_GetExpensesList = (dsExpensesList.spFin_GetExpensesListDataTable) this.Table;
    }

    public int EXPENSECODE
    {
      get => Conversions.ToInteger(this[this.tablespFin_GetExpensesList.EXPENSECODEColumn]);
      set => this[this.tablespFin_GetExpensesList.EXPENSECODEColumn] = (object) value;
    }

    public string EXPENSENAME
    {
      get => Conversions.ToString(this[this.tablespFin_GetExpensesList.EXPENSENAMEColumn]);
      set => this[this.tablespFin_GetExpensesList.EXPENSENAMEColumn] = (object) value;
    }

    public int GLCOMPANYID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tablespFin_GetExpensesList.GLCOMPANYIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablespFin_GetExpensesList.GLCOMPANYIDColumn] = (object) value;
    }

    public int GLACCTID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tablespFin_GetExpensesList.GLACCTIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablespFin_GetExpensesList.GLACCTIDColumn] = (object) value;
    }

    public string GLACCTFULLNAME
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablespFin_GetExpensesList.GLACCTFULLNAMEColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablespFin_GetExpensesList.GLACCTFULLNAMEColumn] = (object) value;
    }

    public bool IsGLCOMPANYIDNull()
    {
      return this.IsNull(this.tablespFin_GetExpensesList.GLCOMPANYIDColumn);
    }

    public void SetGLCOMPANYIDNull()
    {
      this[this.tablespFin_GetExpensesList.GLCOMPANYIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsGLACCTIDNull() => this.IsNull(this.tablespFin_GetExpensesList.GLACCTIDColumn);

    public void SetGLACCTIDNull()
    {
      this[this.tablespFin_GetExpensesList.GLACCTIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsGLACCTFULLNAMENull()
    {
      return this.IsNull(this.tablespFin_GetExpensesList.GLACCTFULLNAMEColumn);
    }

    public void SetGLACCTFULLNAMENull()
    {
      this[this.tablespFin_GetExpensesList.GLACCTFULLNAMEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  [DebuggerStepThrough]
  public class spFin_GetExpensesListRowChangeEvent : EventArgs
  {
    private dsExpensesList.spFin_GetExpensesListRow eventRow;
    private DataRowAction eventAction;

    public spFin_GetExpensesListRowChangeEvent(
      dsExpensesList.spFin_GetExpensesListRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    public dsExpensesList.spFin_GetExpensesListRow Row => this.eventRow;

    public DataRowAction Action => this.eventAction;
  }
}
