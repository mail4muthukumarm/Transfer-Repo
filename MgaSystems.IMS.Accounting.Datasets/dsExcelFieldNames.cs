// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.AccountingDatasets.dsExcelFieldNames
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
public class dsExcelFieldNames : DataSet
{
  private dsExcelFieldNames.FieldNamesDataTable tableFieldNames;

  public dsExcelFieldNames()
  {
    this.InitClass();
    CollectionChangeEventHandler changeEventHandler = new CollectionChangeEventHandler(this.SchemaChanged);
    this.Tables.CollectionChanged += changeEventHandler;
    this.Relations.CollectionChanged += changeEventHandler;
  }

  protected dsExcelFieldNames(SerializationInfo info, StreamingContext context)
  {
    string s = Conversions.ToString(info.GetValue("XmlSchema", typeof (string)));
    if (s != null)
    {
      DataSet dataSet = new DataSet();
      dataSet.ReadXmlSchema((XmlReader) new XmlTextReader((TextReader) new StringReader(s)));
      if (dataSet.Tables[nameof (FieldNames)] != null)
        this.Tables.Add((DataTable) new dsExcelFieldNames.FieldNamesDataTable(dataSet.Tables[nameof (FieldNames)]));
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
  public dsExcelFieldNames.FieldNamesDataTable FieldNames => this.tableFieldNames;

  public override DataSet Clone()
  {
    dsExcelFieldNames dsExcelFieldNames = (dsExcelFieldNames) base.Clone();
    dsExcelFieldNames.InitVars();
    return (DataSet) dsExcelFieldNames;
  }

  protected override bool ShouldSerializeTables() => false;

  protected override bool ShouldSerializeRelations() => false;

  protected override void ReadXmlSerializable(XmlReader reader)
  {
    this.Reset();
    DataSet dataSet = new DataSet();
    int num = (int) dataSet.ReadXml(reader);
    if (dataSet.Tables["FieldNames"] != null)
      this.Tables.Add((DataTable) new dsExcelFieldNames.FieldNamesDataTable(dataSet.Tables["FieldNames"]));
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
    this.tableFieldNames = (dsExcelFieldNames.FieldNamesDataTable) this.Tables["FieldNames"];
    if (this.tableFieldNames == null)
      return;
    this.tableFieldNames.InitVars();
  }

  private void InitClass()
  {
    this.DataSetName = nameof (dsExcelFieldNames);
    this.Prefix = "";
    this.Namespace = "http://tempuri.org/dsExcelFieldNames.xsd";
    this.Locale = new CultureInfo("en-US");
    this.CaseSensitive = false;
    this.EnforceConstraints = true;
    this.tableFieldNames = new dsExcelFieldNames.FieldNamesDataTable();
    this.Tables.Add((DataTable) this.tableFieldNames);
  }

  private bool ShouldSerializeFieldNames() => false;

  private void SchemaChanged(object sender, CollectionChangeEventArgs e)
  {
    if (e.Action != CollectionChangeAction.Remove)
      return;
    this.InitVars();
  }

  public delegate void FieldNamesRowChangeEventHandler(
    object sender,
    dsExcelFieldNames.FieldNamesRowChangeEvent e);

  [DebuggerStepThrough]
  public class FieldNamesDataTable : DataTable, IEnumerable
  {
    private DataColumn columnFieldName;

    internal FieldNamesDataTable()
      : base("FieldNames")
    {
      this.InitClass();
    }

    internal FieldNamesDataTable(DataTable table)
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

    internal DataColumn FieldNameColumn => this.columnFieldName;

    public dsExcelFieldNames.FieldNamesRow this[int index]
    {
      get => (dsExcelFieldNames.FieldNamesRow) this.Rows[index];
    }

    public event dsExcelFieldNames.FieldNamesRowChangeEventHandler FieldNamesRowChanged;

    public event dsExcelFieldNames.FieldNamesRowChangeEventHandler FieldNamesRowChanging;

    public event dsExcelFieldNames.FieldNamesRowChangeEventHandler FieldNamesRowDeleted;

    public event dsExcelFieldNames.FieldNamesRowChangeEventHandler FieldNamesRowDeleting;

    public void AddFieldNamesRow(dsExcelFieldNames.FieldNamesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    public dsExcelFieldNames.FieldNamesRow AddFieldNamesRow(string FieldName)
    {
      dsExcelFieldNames.FieldNamesRow row = (dsExcelFieldNames.FieldNamesRow) this.NewRow();
      row.ItemArray = new object[1]{ (object) FieldName };
      this.Rows.Add((DataRow) row);
      return row;
    }

    public IEnumerator GetEnumerator() => this.Rows.GetEnumerator();

    public override DataTable Clone()
    {
      dsExcelFieldNames.FieldNamesDataTable fieldNamesDataTable = (dsExcelFieldNames.FieldNamesDataTable) base.Clone();
      fieldNamesDataTable.InitVars();
      return (DataTable) fieldNamesDataTable;
    }

    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsExcelFieldNames.FieldNamesDataTable();
    }

    internal void InitVars() => this.columnFieldName = this.Columns["FieldName"];

    private void InitClass()
    {
      this.columnFieldName = new DataColumn("FieldName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFieldName);
    }

    public dsExcelFieldNames.FieldNamesRow NewFieldNamesRow()
    {
      return (dsExcelFieldNames.FieldNamesRow) this.NewRow();
    }

    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsExcelFieldNames.FieldNamesRow(builder);
    }

    protected override Type GetRowType() => typeof (dsExcelFieldNames.FieldNamesRow);

    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.FieldNamesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsExcelFieldNames.FieldNamesRowChangeEventHandler namesRowChangedEvent = this.FieldNamesRowChangedEvent;
      if (namesRowChangedEvent == null)
        return;
      namesRowChangedEvent((object) this, new dsExcelFieldNames.FieldNamesRowChangeEvent((dsExcelFieldNames.FieldNamesRow) e.Row, e.Action));
    }

    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.FieldNamesRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsExcelFieldNames.FieldNamesRowChangeEventHandler rowChangingEvent = this.FieldNamesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsExcelFieldNames.FieldNamesRowChangeEvent((dsExcelFieldNames.FieldNamesRow) e.Row, e.Action));
    }

    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.FieldNamesRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsExcelFieldNames.FieldNamesRowChangeEventHandler namesRowDeletedEvent = this.FieldNamesRowDeletedEvent;
      if (namesRowDeletedEvent == null)
        return;
      namesRowDeletedEvent((object) this, new dsExcelFieldNames.FieldNamesRowChangeEvent((dsExcelFieldNames.FieldNamesRow) e.Row, e.Action));
    }

    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.FieldNamesRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsExcelFieldNames.FieldNamesRowChangeEventHandler rowDeletingEvent = this.FieldNamesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsExcelFieldNames.FieldNamesRowChangeEvent((dsExcelFieldNames.FieldNamesRow) e.Row, e.Action));
    }

    public void RemoveFieldNamesRow(dsExcelFieldNames.FieldNamesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }
  }

  [DebuggerStepThrough]
  public class FieldNamesRow : DataRow
  {
    private dsExcelFieldNames.FieldNamesDataTable tableFieldNames;

    internal FieldNamesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableFieldNames = (dsExcelFieldNames.FieldNamesDataTable) this.Table;
    }

    public string FieldName
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableFieldNames.FieldNameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableFieldNames.FieldNameColumn] = (object) value;
    }

    public bool IsFieldNameNull() => this.IsNull(this.tableFieldNames.FieldNameColumn);

    public void SetFieldNameNull()
    {
      this[this.tableFieldNames.FieldNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  [DebuggerStepThrough]
  public class FieldNamesRowChangeEvent : EventArgs
  {
    private dsExcelFieldNames.FieldNamesRow eventRow;
    private DataRowAction eventAction;

    public FieldNamesRowChangeEvent(dsExcelFieldNames.FieldNamesRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    public dsExcelFieldNames.FieldNamesRow Row => this.eventRow;

    public DataRowAction Action => this.eventAction;
  }
}
