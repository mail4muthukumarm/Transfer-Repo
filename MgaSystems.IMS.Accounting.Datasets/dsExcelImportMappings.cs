// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.AccountingDatasets.dsExcelImportMappings
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
public class dsExcelImportMappings : DataSet
{
  private dsExcelImportMappings.FieldMappingsDataTable tableFieldMappings;

  public dsExcelImportMappings()
  {
    this.InitClass();
    CollectionChangeEventHandler changeEventHandler = new CollectionChangeEventHandler(this.SchemaChanged);
    this.Tables.CollectionChanged += changeEventHandler;
    this.Relations.CollectionChanged += changeEventHandler;
  }

  protected dsExcelImportMappings(SerializationInfo info, StreamingContext context)
  {
    string s = Conversions.ToString(info.GetValue("XmlSchema", typeof (string)));
    if (s != null)
    {
      DataSet dataSet = new DataSet();
      dataSet.ReadXmlSchema((XmlReader) new XmlTextReader((TextReader) new StringReader(s)));
      if (dataSet.Tables[nameof (FieldMappings)] != null)
        this.Tables.Add((DataTable) new dsExcelImportMappings.FieldMappingsDataTable(dataSet.Tables[nameof (FieldMappings)]));
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
  public dsExcelImportMappings.FieldMappingsDataTable FieldMappings => this.tableFieldMappings;

  public override DataSet Clone()
  {
    dsExcelImportMappings excelImportMappings = (dsExcelImportMappings) base.Clone();
    excelImportMappings.InitVars();
    return (DataSet) excelImportMappings;
  }

  protected override bool ShouldSerializeTables() => false;

  protected override bool ShouldSerializeRelations() => false;

  protected override void ReadXmlSerializable(XmlReader reader)
  {
    this.Reset();
    DataSet dataSet = new DataSet();
    int num = (int) dataSet.ReadXml(reader);
    if (dataSet.Tables["FieldMappings"] != null)
      this.Tables.Add((DataTable) new dsExcelImportMappings.FieldMappingsDataTable(dataSet.Tables["FieldMappings"]));
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
    this.tableFieldMappings = (dsExcelImportMappings.FieldMappingsDataTable) this.Tables["FieldMappings"];
    if (this.tableFieldMappings == null)
      return;
    this.tableFieldMappings.InitVars();
  }

  private void InitClass()
  {
    this.DataSetName = nameof (dsExcelImportMappings);
    this.Prefix = "";
    this.Namespace = "http://tempuri.org/dsExcelImportMappings.xsd";
    this.Locale = new CultureInfo("en-US");
    this.CaseSensitive = false;
    this.EnforceConstraints = true;
    this.tableFieldMappings = new dsExcelImportMappings.FieldMappingsDataTable();
    this.Tables.Add((DataTable) this.tableFieldMappings);
  }

  private bool ShouldSerializeFieldMappings() => false;

  private void SchemaChanged(object sender, CollectionChangeEventArgs e)
  {
    if (e.Action != CollectionChangeAction.Remove)
      return;
    this.InitVars();
  }

  public delegate void FieldMappingsRowChangeEventHandler(
    object sender,
    dsExcelImportMappings.FieldMappingsRowChangeEvent e);

  [DebuggerStepThrough]
  public class FieldMappingsDataTable : DataTable, IEnumerable
  {
    private DataColumn columnIMSField;
    private DataColumn columnExcelField;

    internal FieldMappingsDataTable()
      : base("FieldMappings")
    {
      this.InitClass();
    }

    internal FieldMappingsDataTable(DataTable table)
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

    internal DataColumn IMSFieldColumn => this.columnIMSField;

    internal DataColumn ExcelFieldColumn => this.columnExcelField;

    public dsExcelImportMappings.FieldMappingsRow this[int index]
    {
      get => (dsExcelImportMappings.FieldMappingsRow) this.Rows[index];
    }

    public event dsExcelImportMappings.FieldMappingsRowChangeEventHandler FieldMappingsRowChanged;

    public event dsExcelImportMappings.FieldMappingsRowChangeEventHandler FieldMappingsRowChanging;

    public event dsExcelImportMappings.FieldMappingsRowChangeEventHandler FieldMappingsRowDeleted;

    public event dsExcelImportMappings.FieldMappingsRowChangeEventHandler FieldMappingsRowDeleting;

    public void AddFieldMappingsRow(dsExcelImportMappings.FieldMappingsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    public dsExcelImportMappings.FieldMappingsRow AddFieldMappingsRow(
      string IMSField,
      string ExcelField)
    {
      dsExcelImportMappings.FieldMappingsRow row = (dsExcelImportMappings.FieldMappingsRow) this.NewRow();
      row.ItemArray = new object[2]
      {
        (object) IMSField,
        (object) ExcelField
      };
      this.Rows.Add((DataRow) row);
      return row;
    }

    public IEnumerator GetEnumerator() => this.Rows.GetEnumerator();

    public override DataTable Clone()
    {
      dsExcelImportMappings.FieldMappingsDataTable mappingsDataTable = (dsExcelImportMappings.FieldMappingsDataTable) base.Clone();
      mappingsDataTable.InitVars();
      return (DataTable) mappingsDataTable;
    }

    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsExcelImportMappings.FieldMappingsDataTable();
    }

    internal void InitVars()
    {
      this.columnIMSField = this.Columns["IMSField"];
      this.columnExcelField = this.Columns["ExcelField"];
    }

    private void InitClass()
    {
      this.columnIMSField = new DataColumn("IMSField", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnIMSField);
      this.columnExcelField = new DataColumn("ExcelField", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnExcelField);
    }

    public dsExcelImportMappings.FieldMappingsRow NewFieldMappingsRow()
    {
      return (dsExcelImportMappings.FieldMappingsRow) this.NewRow();
    }

    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsExcelImportMappings.FieldMappingsRow(builder);
    }

    protected override Type GetRowType() => typeof (dsExcelImportMappings.FieldMappingsRow);

    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.FieldMappingsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsExcelImportMappings.FieldMappingsRowChangeEventHandler mappingsRowChangedEvent = this.FieldMappingsRowChangedEvent;
      if (mappingsRowChangedEvent == null)
        return;
      mappingsRowChangedEvent((object) this, new dsExcelImportMappings.FieldMappingsRowChangeEvent((dsExcelImportMappings.FieldMappingsRow) e.Row, e.Action));
    }

    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.FieldMappingsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsExcelImportMappings.FieldMappingsRowChangeEventHandler rowChangingEvent = this.FieldMappingsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsExcelImportMappings.FieldMappingsRowChangeEvent((dsExcelImportMappings.FieldMappingsRow) e.Row, e.Action));
    }

    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.FieldMappingsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsExcelImportMappings.FieldMappingsRowChangeEventHandler mappingsRowDeletedEvent = this.FieldMappingsRowDeletedEvent;
      if (mappingsRowDeletedEvent == null)
        return;
      mappingsRowDeletedEvent((object) this, new dsExcelImportMappings.FieldMappingsRowChangeEvent((dsExcelImportMappings.FieldMappingsRow) e.Row, e.Action));
    }

    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.FieldMappingsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsExcelImportMappings.FieldMappingsRowChangeEventHandler rowDeletingEvent = this.FieldMappingsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsExcelImportMappings.FieldMappingsRowChangeEvent((dsExcelImportMappings.FieldMappingsRow) e.Row, e.Action));
    }

    public void RemoveFieldMappingsRow(dsExcelImportMappings.FieldMappingsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }
  }

  [DebuggerStepThrough]
  public class FieldMappingsRow : DataRow
  {
    private dsExcelImportMappings.FieldMappingsDataTable tableFieldMappings;

    internal FieldMappingsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableFieldMappings = (dsExcelImportMappings.FieldMappingsDataTable) this.Table;
    }

    public string IMSField
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableFieldMappings.IMSFieldColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableFieldMappings.IMSFieldColumn] = (object) value;
    }

    public string ExcelField
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableFieldMappings.ExcelFieldColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableFieldMappings.ExcelFieldColumn] = (object) value;
    }

    public bool IsIMSFieldNull() => this.IsNull(this.tableFieldMappings.IMSFieldColumn);

    public void SetIMSFieldNull()
    {
      this[this.tableFieldMappings.IMSFieldColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsExcelFieldNull() => this.IsNull(this.tableFieldMappings.ExcelFieldColumn);

    public void SetExcelFieldNull()
    {
      this[this.tableFieldMappings.ExcelFieldColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  [DebuggerStepThrough]
  public class FieldMappingsRowChangeEvent : EventArgs
  {
    private dsExcelImportMappings.FieldMappingsRow eventRow;
    private DataRowAction eventAction;

    public FieldMappingsRowChangeEvent(
      dsExcelImportMappings.FieldMappingsRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    public dsExcelImportMappings.FieldMappingsRow Row => this.eventRow;

    public DataRowAction Action => this.eventAction;
  }
}
