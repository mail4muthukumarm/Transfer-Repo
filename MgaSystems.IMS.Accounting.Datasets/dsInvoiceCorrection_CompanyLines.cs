// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.AccountingDatasets.dsInvoiceCorrection_CompanyLines
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
public class dsInvoiceCorrection_CompanyLines : DataSet
{
  private dsInvoiceCorrection_CompanyLines.CompanyLinesDataTable tableCompanyLines;

  public dsInvoiceCorrection_CompanyLines()
  {
    this.InitClass();
    CollectionChangeEventHandler changeEventHandler = new CollectionChangeEventHandler(this.SchemaChanged);
    this.Tables.CollectionChanged += changeEventHandler;
    this.Relations.CollectionChanged += changeEventHandler;
  }

  protected dsInvoiceCorrection_CompanyLines(SerializationInfo info, StreamingContext context)
  {
    string s = Conversions.ToString(info.GetValue("XmlSchema", typeof (string)));
    if (s != null)
    {
      DataSet dataSet = new DataSet();
      dataSet.ReadXmlSchema((XmlReader) new XmlTextReader((TextReader) new StringReader(s)));
      if (dataSet.Tables[nameof (CompanyLines)] != null)
        this.Tables.Add((DataTable) new dsInvoiceCorrection_CompanyLines.CompanyLinesDataTable(dataSet.Tables[nameof (CompanyLines)]));
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
  public dsInvoiceCorrection_CompanyLines.CompanyLinesDataTable CompanyLines
  {
    get => this.tableCompanyLines;
  }

  public override DataSet Clone()
  {
    dsInvoiceCorrection_CompanyLines correctionCompanyLines = (dsInvoiceCorrection_CompanyLines) base.Clone();
    correctionCompanyLines.InitVars();
    return (DataSet) correctionCompanyLines;
  }

  protected override bool ShouldSerializeTables() => false;

  protected override bool ShouldSerializeRelations() => false;

  protected override void ReadXmlSerializable(XmlReader reader)
  {
    this.Reset();
    DataSet dataSet = new DataSet();
    int num = (int) dataSet.ReadXml(reader);
    if (dataSet.Tables["CompanyLines"] != null)
      this.Tables.Add((DataTable) new dsInvoiceCorrection_CompanyLines.CompanyLinesDataTable(dataSet.Tables["CompanyLines"]));
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
    this.tableCompanyLines = (dsInvoiceCorrection_CompanyLines.CompanyLinesDataTable) this.Tables["CompanyLines"];
    if (this.tableCompanyLines == null)
      return;
    this.tableCompanyLines.InitVars();
  }

  private void InitClass()
  {
    this.DataSetName = nameof (dsInvoiceCorrection_CompanyLines);
    this.Prefix = "";
    this.Namespace = "http://tempuri.org/dsInvoiceCorrection_CompanyLines.xsd";
    this.Locale = new CultureInfo("en-US");
    this.CaseSensitive = false;
    this.EnforceConstraints = true;
    this.tableCompanyLines = new dsInvoiceCorrection_CompanyLines.CompanyLinesDataTable();
    this.Tables.Add((DataTable) this.tableCompanyLines);
  }

  private bool ShouldSerializeCompanyLines() => false;

  private void SchemaChanged(object sender, CollectionChangeEventArgs e)
  {
    if (e.Action != CollectionChangeAction.Remove)
      return;
    this.InitVars();
  }

  public delegate void CompanyLinesRowChangeEventHandler(
    object sender,
    dsInvoiceCorrection_CompanyLines.CompanyLinesRowChangeEvent e);

  [DebuggerStepThrough]
  public class CompanyLinesDataTable : DataTable, IEnumerable
  {
    private DataColumn columnCompanyLineGuid;
    private DataColumn columnCompanyLine;

    internal CompanyLinesDataTable()
      : base("CompanyLines")
    {
      this.InitClass();
    }

    internal CompanyLinesDataTable(DataTable table)
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

    internal DataColumn CompanyLineGuidColumn => this.columnCompanyLineGuid;

    internal DataColumn CompanyLineColumn => this.columnCompanyLine;

    public dsInvoiceCorrection_CompanyLines.CompanyLinesRow this[int index]
    {
      get => (dsInvoiceCorrection_CompanyLines.CompanyLinesRow) this.Rows[index];
    }

    public event dsInvoiceCorrection_CompanyLines.CompanyLinesRowChangeEventHandler CompanyLinesRowChanged;

    public event dsInvoiceCorrection_CompanyLines.CompanyLinesRowChangeEventHandler CompanyLinesRowChanging;

    public event dsInvoiceCorrection_CompanyLines.CompanyLinesRowChangeEventHandler CompanyLinesRowDeleted;

    public event dsInvoiceCorrection_CompanyLines.CompanyLinesRowChangeEventHandler CompanyLinesRowDeleting;

    public void AddCompanyLinesRow(
      dsInvoiceCorrection_CompanyLines.CompanyLinesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    public dsInvoiceCorrection_CompanyLines.CompanyLinesRow AddCompanyLinesRow(
      string CompanyLineGuid,
      string CompanyLine)
    {
      dsInvoiceCorrection_CompanyLines.CompanyLinesRow row = (dsInvoiceCorrection_CompanyLines.CompanyLinesRow) this.NewRow();
      row.ItemArray = new object[2]
      {
        (object) CompanyLineGuid,
        (object) CompanyLine
      };
      this.Rows.Add((DataRow) row);
      return row;
    }

    public IEnumerator GetEnumerator() => this.Rows.GetEnumerator();

    public override DataTable Clone()
    {
      dsInvoiceCorrection_CompanyLines.CompanyLinesDataTable companyLinesDataTable = (dsInvoiceCorrection_CompanyLines.CompanyLinesDataTable) base.Clone();
      companyLinesDataTable.InitVars();
      return (DataTable) companyLinesDataTable;
    }

    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsInvoiceCorrection_CompanyLines.CompanyLinesDataTable();
    }

    internal void InitVars()
    {
      this.columnCompanyLineGuid = this.Columns["CompanyLineGuid"];
      this.columnCompanyLine = this.Columns["CompanyLine"];
    }

    private void InitClass()
    {
      this.columnCompanyLineGuid = new DataColumn("CompanyLineGuid", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCompanyLineGuid);
      this.columnCompanyLine = new DataColumn("CompanyLine", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCompanyLine);
    }

    public dsInvoiceCorrection_CompanyLines.CompanyLinesRow NewCompanyLinesRow()
    {
      return (dsInvoiceCorrection_CompanyLines.CompanyLinesRow) this.NewRow();
    }

    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsInvoiceCorrection_CompanyLines.CompanyLinesRow(builder);
    }

    protected override Type GetRowType()
    {
      return typeof (dsInvoiceCorrection_CompanyLines.CompanyLinesRow);
    }

    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.CompanyLinesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInvoiceCorrection_CompanyLines.CompanyLinesRowChangeEventHandler linesRowChangedEvent = this.CompanyLinesRowChangedEvent;
      if (linesRowChangedEvent == null)
        return;
      linesRowChangedEvent((object) this, new dsInvoiceCorrection_CompanyLines.CompanyLinesRowChangeEvent((dsInvoiceCorrection_CompanyLines.CompanyLinesRow) e.Row, e.Action));
    }

    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.CompanyLinesRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInvoiceCorrection_CompanyLines.CompanyLinesRowChangeEventHandler rowChangingEvent = this.CompanyLinesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsInvoiceCorrection_CompanyLines.CompanyLinesRowChangeEvent((dsInvoiceCorrection_CompanyLines.CompanyLinesRow) e.Row, e.Action));
    }

    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.CompanyLinesRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInvoiceCorrection_CompanyLines.CompanyLinesRowChangeEventHandler linesRowDeletedEvent = this.CompanyLinesRowDeletedEvent;
      if (linesRowDeletedEvent == null)
        return;
      linesRowDeletedEvent((object) this, new dsInvoiceCorrection_CompanyLines.CompanyLinesRowChangeEvent((dsInvoiceCorrection_CompanyLines.CompanyLinesRow) e.Row, e.Action));
    }

    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.CompanyLinesRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsInvoiceCorrection_CompanyLines.CompanyLinesRowChangeEventHandler rowDeletingEvent = this.CompanyLinesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsInvoiceCorrection_CompanyLines.CompanyLinesRowChangeEvent((dsInvoiceCorrection_CompanyLines.CompanyLinesRow) e.Row, e.Action));
    }

    public void RemoveCompanyLinesRow(
      dsInvoiceCorrection_CompanyLines.CompanyLinesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }
  }

  [DebuggerStepThrough]
  public class CompanyLinesRow : DataRow
  {
    private dsInvoiceCorrection_CompanyLines.CompanyLinesDataTable tableCompanyLines;

    internal CompanyLinesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableCompanyLines = (dsInvoiceCorrection_CompanyLines.CompanyLinesDataTable) this.Table;
    }

    public string CompanyLineGuid
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableCompanyLines.CompanyLineGuidColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableCompanyLines.CompanyLineGuidColumn] = (object) value;
    }

    public string CompanyLine
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableCompanyLines.CompanyLineColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableCompanyLines.CompanyLineColumn] = (object) value;
    }

    public bool IsCompanyLineGuidNull()
    {
      return this.IsNull(this.tableCompanyLines.CompanyLineGuidColumn);
    }

    public void SetCompanyLineGuidNull()
    {
      this[this.tableCompanyLines.CompanyLineGuidColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsCompanyLineNull() => this.IsNull(this.tableCompanyLines.CompanyLineColumn);

    public void SetCompanyLineNull()
    {
      this[this.tableCompanyLines.CompanyLineColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  [DebuggerStepThrough]
  public class CompanyLinesRowChangeEvent : EventArgs
  {
    private dsInvoiceCorrection_CompanyLines.CompanyLinesRow eventRow;
    private DataRowAction eventAction;

    public CompanyLinesRowChangeEvent(
      dsInvoiceCorrection_CompanyLines.CompanyLinesRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    public dsInvoiceCorrection_CompanyLines.CompanyLinesRow Row => this.eventRow;

    public DataRowAction Action => this.eventAction;
  }
}
