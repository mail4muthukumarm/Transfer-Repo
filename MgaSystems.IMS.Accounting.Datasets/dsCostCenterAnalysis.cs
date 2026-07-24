// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.AccountingDatasets.dsCostCenterAnalysis
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
public class dsCostCenterAnalysis : DataSet
{
  private dsCostCenterAnalysis.CostCentersDataTable tableCostCenters;

  public dsCostCenterAnalysis()
  {
    this.InitClass();
    CollectionChangeEventHandler changeEventHandler = new CollectionChangeEventHandler(this.SchemaChanged);
    this.Tables.CollectionChanged += changeEventHandler;
    this.Relations.CollectionChanged += changeEventHandler;
  }

  protected dsCostCenterAnalysis(SerializationInfo info, StreamingContext context)
  {
    string s = Conversions.ToString(info.GetValue("XmlSchema", typeof (string)));
    if (s != null)
    {
      DataSet dataSet = new DataSet();
      dataSet.ReadXmlSchema((XmlReader) new XmlTextReader((TextReader) new StringReader(s)));
      if (dataSet.Tables[nameof (CostCenters)] != null)
        this.Tables.Add((DataTable) new dsCostCenterAnalysis.CostCentersDataTable(dataSet.Tables[nameof (CostCenters)]));
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
  public dsCostCenterAnalysis.CostCentersDataTable CostCenters => this.tableCostCenters;

  public override DataSet Clone()
  {
    dsCostCenterAnalysis costCenterAnalysis = (dsCostCenterAnalysis) base.Clone();
    costCenterAnalysis.InitVars();
    return (DataSet) costCenterAnalysis;
  }

  protected override bool ShouldSerializeTables() => false;

  protected override bool ShouldSerializeRelations() => false;

  protected override void ReadXmlSerializable(XmlReader reader)
  {
    this.Reset();
    DataSet dataSet = new DataSet();
    int num = (int) dataSet.ReadXml(reader);
    if (dataSet.Tables["CostCenters"] != null)
      this.Tables.Add((DataTable) new dsCostCenterAnalysis.CostCentersDataTable(dataSet.Tables["CostCenters"]));
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
    this.tableCostCenters = (dsCostCenterAnalysis.CostCentersDataTable) this.Tables["CostCenters"];
    if (this.tableCostCenters == null)
      return;
    this.tableCostCenters.InitVars();
  }

  private void InitClass()
  {
    this.DataSetName = nameof (dsCostCenterAnalysis);
    this.Prefix = "";
    this.Namespace = "http://tempuri.org/dsCostCenterAnalysis.xsd";
    this.Locale = new CultureInfo("en-US");
    this.CaseSensitive = false;
    this.EnforceConstraints = true;
    this.tableCostCenters = new dsCostCenterAnalysis.CostCentersDataTable();
    this.Tables.Add((DataTable) this.tableCostCenters);
  }

  private bool ShouldSerializeCostCenters() => false;

  private void SchemaChanged(object sender, CollectionChangeEventArgs e)
  {
    if (e.Action != CollectionChangeAction.Remove)
      return;
    this.InitVars();
  }

  public delegate void CostCentersRowChangeEventHandler(
    object sender,
    dsCostCenterAnalysis.CostCentersRowChangeEvent e);

  [DebuggerStepThrough]
  public class CostCentersDataTable : DataTable, IEnumerable
  {
    private DataColumn columnCostCenterId;
    private DataColumn columnCostCenterGuid;
    private DataColumn columnCostCenterName;
    private DataColumn columnCostCenterDescription;
    private DataColumn columnGlCompanyId;

    internal CostCentersDataTable()
      : base("CostCenters")
    {
      this.InitClass();
    }

    internal CostCentersDataTable(DataTable table)
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

    internal DataColumn CostCenterIdColumn => this.columnCostCenterId;

    internal DataColumn CostCenterGuidColumn => this.columnCostCenterGuid;

    internal DataColumn CostCenterNameColumn => this.columnCostCenterName;

    internal DataColumn CostCenterDescriptionColumn => this.columnCostCenterDescription;

    internal DataColumn GlCompanyIdColumn => this.columnGlCompanyId;

    public dsCostCenterAnalysis.CostCentersRow this[int index]
    {
      get => (dsCostCenterAnalysis.CostCentersRow) this.Rows[index];
    }

    public event dsCostCenterAnalysis.CostCentersRowChangeEventHandler CostCentersRowChanged;

    public event dsCostCenterAnalysis.CostCentersRowChangeEventHandler CostCentersRowChanging;

    public event dsCostCenterAnalysis.CostCentersRowChangeEventHandler CostCentersRowDeleted;

    public event dsCostCenterAnalysis.CostCentersRowChangeEventHandler CostCentersRowDeleting;

    public void AddCostCentersRow(dsCostCenterAnalysis.CostCentersRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    public dsCostCenterAnalysis.CostCentersRow AddCostCentersRow(
      int CostCenterId,
      string CostCenterGuid,
      string CostCenterName,
      string CostCenterDescription,
      int GlCompanyId)
    {
      dsCostCenterAnalysis.CostCentersRow row = (dsCostCenterAnalysis.CostCentersRow) this.NewRow();
      row.ItemArray = new object[5]
      {
        (object) CostCenterId,
        (object) CostCenterGuid,
        (object) CostCenterName,
        (object) CostCenterDescription,
        (object) GlCompanyId
      };
      this.Rows.Add((DataRow) row);
      return row;
    }

    public IEnumerator GetEnumerator() => this.Rows.GetEnumerator();

    public override DataTable Clone()
    {
      dsCostCenterAnalysis.CostCentersDataTable centersDataTable = (dsCostCenterAnalysis.CostCentersDataTable) base.Clone();
      centersDataTable.InitVars();
      return (DataTable) centersDataTable;
    }

    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsCostCenterAnalysis.CostCentersDataTable();
    }

    internal void InitVars()
    {
      this.columnCostCenterId = this.Columns["CostCenterId"];
      this.columnCostCenterGuid = this.Columns["CostCenterGuid"];
      this.columnCostCenterName = this.Columns["CostCenterName"];
      this.columnCostCenterDescription = this.Columns["CostCenterDescription"];
      this.columnGlCompanyId = this.Columns["GlCompanyId"];
    }

    private void InitClass()
    {
      this.columnCostCenterId = new DataColumn("CostCenterId", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCostCenterId);
      this.columnCostCenterGuid = new DataColumn("CostCenterGuid", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCostCenterGuid);
      this.columnCostCenterName = new DataColumn("CostCenterName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCostCenterName);
      this.columnCostCenterDescription = new DataColumn("CostCenterDescription", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCostCenterDescription);
      this.columnGlCompanyId = new DataColumn("GlCompanyId", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnGlCompanyId);
    }

    public dsCostCenterAnalysis.CostCentersRow NewCostCentersRow()
    {
      return (dsCostCenterAnalysis.CostCentersRow) this.NewRow();
    }

    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsCostCenterAnalysis.CostCentersRow(builder);
    }

    protected override Type GetRowType() => typeof (dsCostCenterAnalysis.CostCentersRow);

    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.CostCentersRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCostCenterAnalysis.CostCentersRowChangeEventHandler centersRowChangedEvent = this.CostCentersRowChangedEvent;
      if (centersRowChangedEvent == null)
        return;
      centersRowChangedEvent((object) this, new dsCostCenterAnalysis.CostCentersRowChangeEvent((dsCostCenterAnalysis.CostCentersRow) e.Row, e.Action));
    }

    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.CostCentersRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCostCenterAnalysis.CostCentersRowChangeEventHandler rowChangingEvent = this.CostCentersRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsCostCenterAnalysis.CostCentersRowChangeEvent((dsCostCenterAnalysis.CostCentersRow) e.Row, e.Action));
    }

    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.CostCentersRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCostCenterAnalysis.CostCentersRowChangeEventHandler centersRowDeletedEvent = this.CostCentersRowDeletedEvent;
      if (centersRowDeletedEvent == null)
        return;
      centersRowDeletedEvent((object) this, new dsCostCenterAnalysis.CostCentersRowChangeEvent((dsCostCenterAnalysis.CostCentersRow) e.Row, e.Action));
    }

    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.CostCentersRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsCostCenterAnalysis.CostCentersRowChangeEventHandler rowDeletingEvent = this.CostCentersRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsCostCenterAnalysis.CostCentersRowChangeEvent((dsCostCenterAnalysis.CostCentersRow) e.Row, e.Action));
    }

    public void RemoveCostCentersRow(dsCostCenterAnalysis.CostCentersRow row)
    {
      this.Rows.Remove((DataRow) row);
    }
  }

  [DebuggerStepThrough]
  public class CostCentersRow : DataRow
  {
    private dsCostCenterAnalysis.CostCentersDataTable tableCostCenters;

    internal CostCentersRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableCostCenters = (dsCostCenterAnalysis.CostCentersDataTable) this.Table;
    }

    public int CostCenterId
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tableCostCenters.CostCenterIdColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableCostCenters.CostCenterIdColumn] = (object) value;
    }

    public string CostCenterGuid
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableCostCenters.CostCenterGuidColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableCostCenters.CostCenterGuidColumn] = (object) value;
    }

    public string CostCenterName
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableCostCenters.CostCenterNameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableCostCenters.CostCenterNameColumn] = (object) value;
    }

    public string CostCenterDescription
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableCostCenters.CostCenterDescriptionColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableCostCenters.CostCenterDescriptionColumn] = (object) value;
    }

    public int GlCompanyId
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tableCostCenters.GlCompanyIdColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableCostCenters.GlCompanyIdColumn] = (object) value;
    }

    public bool IsCostCenterIdNull() => this.IsNull(this.tableCostCenters.CostCenterIdColumn);

    public void SetCostCenterIdNull()
    {
      this[this.tableCostCenters.CostCenterIdColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsCostCenterGuidNull() => this.IsNull(this.tableCostCenters.CostCenterGuidColumn);

    public void SetCostCenterGuidNull()
    {
      this[this.tableCostCenters.CostCenterGuidColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsCostCenterNameNull() => this.IsNull(this.tableCostCenters.CostCenterNameColumn);

    public void SetCostCenterNameNull()
    {
      this[this.tableCostCenters.CostCenterNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsCostCenterDescriptionNull()
    {
      return this.IsNull(this.tableCostCenters.CostCenterDescriptionColumn);
    }

    public void SetCostCenterDescriptionNull()
    {
      this[this.tableCostCenters.CostCenterDescriptionColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsGlCompanyIdNull() => this.IsNull(this.tableCostCenters.GlCompanyIdColumn);

    public void SetGlCompanyIdNull()
    {
      this[this.tableCostCenters.GlCompanyIdColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  [DebuggerStepThrough]
  public class CostCentersRowChangeEvent : EventArgs
  {
    private dsCostCenterAnalysis.CostCentersRow eventRow;
    private DataRowAction eventAction;

    public CostCentersRowChangeEvent(dsCostCenterAnalysis.CostCentersRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    public dsCostCenterAnalysis.CostCentersRow Row => this.eventRow;

    public DataRowAction Action => this.eventAction;
  }
}
