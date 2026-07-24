// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.AccountingDatasets.dsFiscalConfigurations
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
public class dsFiscalConfigurations : DataSet
{
  private dsFiscalConfigurations.SettingsDataTable tableSettings;

  public dsFiscalConfigurations()
  {
    this.InitClass();
    CollectionChangeEventHandler changeEventHandler = new CollectionChangeEventHandler(this.SchemaChanged);
    this.Tables.CollectionChanged += changeEventHandler;
    this.Relations.CollectionChanged += changeEventHandler;
  }

  protected dsFiscalConfigurations(SerializationInfo info, StreamingContext context)
  {
    string s = Conversions.ToString(info.GetValue("XmlSchema", typeof (string)));
    if (s != null)
    {
      DataSet dataSet = new DataSet();
      dataSet.ReadXmlSchema((XmlReader) new XmlTextReader((TextReader) new StringReader(s)));
      if (dataSet.Tables[nameof (Settings)] != null)
        this.Tables.Add((DataTable) new dsFiscalConfigurations.SettingsDataTable(dataSet.Tables[nameof (Settings)]));
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
  public dsFiscalConfigurations.SettingsDataTable Settings => this.tableSettings;

  public override DataSet Clone()
  {
    dsFiscalConfigurations fiscalConfigurations = (dsFiscalConfigurations) base.Clone();
    fiscalConfigurations.InitVars();
    return (DataSet) fiscalConfigurations;
  }

  protected override bool ShouldSerializeTables() => false;

  protected override bool ShouldSerializeRelations() => false;

  protected override void ReadXmlSerializable(XmlReader reader)
  {
    this.Reset();
    DataSet dataSet = new DataSet();
    int num = (int) dataSet.ReadXml(reader);
    if (dataSet.Tables["Settings"] != null)
      this.Tables.Add((DataTable) new dsFiscalConfigurations.SettingsDataTable(dataSet.Tables["Settings"]));
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
    this.tableSettings = (dsFiscalConfigurations.SettingsDataTable) this.Tables["Settings"];
    if (this.tableSettings == null)
      return;
    this.tableSettings.InitVars();
  }

  private void InitClass()
  {
    this.DataSetName = nameof (dsFiscalConfigurations);
    this.Prefix = "";
    this.Namespace = "http://tempuri.org/dsFiscalConfigurations.xsd";
    this.Locale = new CultureInfo("en-US");
    this.CaseSensitive = false;
    this.EnforceConstraints = true;
    this.tableSettings = new dsFiscalConfigurations.SettingsDataTable();
    this.Tables.Add((DataTable) this.tableSettings);
  }

  private bool ShouldSerializeSettings() => false;

  private void SchemaChanged(object sender, CollectionChangeEventArgs e)
  {
    if (e.Action != CollectionChangeAction.Remove)
      return;
    this.InitVars();
  }

  public delegate void SettingsRowChangeEventHandler(
    object sender,
    dsFiscalConfigurations.SettingsRowChangeEvent e);

  [DebuggerStepThrough]
  public class SettingsDataTable : DataTable, IEnumerable
  {
    private DataColumn columnFiscalSettingId;
    private DataColumn columnGLCompanyId;
    private DataColumn columnLocation;
    private DataColumn columnCurrent;

    internal SettingsDataTable()
      : base("Settings")
    {
      this.InitClass();
    }

    internal SettingsDataTable(DataTable table)
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

    internal DataColumn FiscalSettingIdColumn => this.columnFiscalSettingId;

    internal DataColumn GLCompanyIdColumn => this.columnGLCompanyId;

    internal DataColumn LocationColumn => this.columnLocation;

    internal DataColumn CurrentColumn => this.columnCurrent;

    public dsFiscalConfigurations.SettingsRow this[int index]
    {
      get => (dsFiscalConfigurations.SettingsRow) this.Rows[index];
    }

    public event dsFiscalConfigurations.SettingsRowChangeEventHandler SettingsRowChanged;

    public event dsFiscalConfigurations.SettingsRowChangeEventHandler SettingsRowChanging;

    public event dsFiscalConfigurations.SettingsRowChangeEventHandler SettingsRowDeleted;

    public event dsFiscalConfigurations.SettingsRowChangeEventHandler SettingsRowDeleting;

    public void AddSettingsRow(dsFiscalConfigurations.SettingsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    public dsFiscalConfigurations.SettingsRow AddSettingsRow(
      int FiscalSettingId,
      int GLCompanyId,
      string Location,
      string Current)
    {
      dsFiscalConfigurations.SettingsRow row = (dsFiscalConfigurations.SettingsRow) this.NewRow();
      row.ItemArray = new object[4]
      {
        (object) FiscalSettingId,
        (object) GLCompanyId,
        (object) Location,
        (object) Current
      };
      this.Rows.Add((DataRow) row);
      return row;
    }

    public IEnumerator GetEnumerator() => this.Rows.GetEnumerator();

    public override DataTable Clone()
    {
      dsFiscalConfigurations.SettingsDataTable settingsDataTable = (dsFiscalConfigurations.SettingsDataTable) base.Clone();
      settingsDataTable.InitVars();
      return (DataTable) settingsDataTable;
    }

    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsFiscalConfigurations.SettingsDataTable();
    }

    internal void InitVars()
    {
      this.columnFiscalSettingId = this.Columns["FiscalSettingId"];
      this.columnGLCompanyId = this.Columns["GLCompanyId"];
      this.columnLocation = this.Columns["Location"];
      this.columnCurrent = this.Columns["Current"];
    }

    private void InitClass()
    {
      this.columnFiscalSettingId = new DataColumn("FiscalSettingId", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFiscalSettingId);
      this.columnGLCompanyId = new DataColumn("GLCompanyId", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnGLCompanyId);
      this.columnLocation = new DataColumn("Location", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLocation);
      this.columnCurrent = new DataColumn("Current", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCurrent);
    }

    public dsFiscalConfigurations.SettingsRow NewSettingsRow()
    {
      return (dsFiscalConfigurations.SettingsRow) this.NewRow();
    }

    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsFiscalConfigurations.SettingsRow(builder);
    }

    protected override Type GetRowType() => typeof (dsFiscalConfigurations.SettingsRow);

    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.SettingsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsFiscalConfigurations.SettingsRowChangeEventHandler settingsRowChangedEvent = this.SettingsRowChangedEvent;
      if (settingsRowChangedEvent == null)
        return;
      settingsRowChangedEvent((object) this, new dsFiscalConfigurations.SettingsRowChangeEvent((dsFiscalConfigurations.SettingsRow) e.Row, e.Action));
    }

    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.SettingsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsFiscalConfigurations.SettingsRowChangeEventHandler rowChangingEvent = this.SettingsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsFiscalConfigurations.SettingsRowChangeEvent((dsFiscalConfigurations.SettingsRow) e.Row, e.Action));
    }

    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.SettingsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsFiscalConfigurations.SettingsRowChangeEventHandler settingsRowDeletedEvent = this.SettingsRowDeletedEvent;
      if (settingsRowDeletedEvent == null)
        return;
      settingsRowDeletedEvent((object) this, new dsFiscalConfigurations.SettingsRowChangeEvent((dsFiscalConfigurations.SettingsRow) e.Row, e.Action));
    }

    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.SettingsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsFiscalConfigurations.SettingsRowChangeEventHandler rowDeletingEvent = this.SettingsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsFiscalConfigurations.SettingsRowChangeEvent((dsFiscalConfigurations.SettingsRow) e.Row, e.Action));
    }

    public void RemoveSettingsRow(dsFiscalConfigurations.SettingsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }
  }

  [DebuggerStepThrough]
  public class SettingsRow : DataRow
  {
    private dsFiscalConfigurations.SettingsDataTable tableSettings;

    internal SettingsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableSettings = (dsFiscalConfigurations.SettingsDataTable) this.Table;
    }

    public int FiscalSettingId
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tableSettings.FiscalSettingIdColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableSettings.FiscalSettingIdColumn] = (object) value;
    }

    public int GLCompanyId
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tableSettings.GLCompanyIdColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableSettings.GLCompanyIdColumn] = (object) value;
    }

    public string Location
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableSettings.LocationColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableSettings.LocationColumn] = (object) value;
    }

    public string Current
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableSettings.CurrentColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableSettings.CurrentColumn] = (object) value;
    }

    public bool IsFiscalSettingIdNull() => this.IsNull(this.tableSettings.FiscalSettingIdColumn);

    public void SetFiscalSettingIdNull()
    {
      this[this.tableSettings.FiscalSettingIdColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsGLCompanyIdNull() => this.IsNull(this.tableSettings.GLCompanyIdColumn);

    public void SetGLCompanyIdNull()
    {
      this[this.tableSettings.GLCompanyIdColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsLocationNull() => this.IsNull(this.tableSettings.LocationColumn);

    public void SetLocationNull()
    {
      this[this.tableSettings.LocationColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsCurrentNull() => this.IsNull(this.tableSettings.CurrentColumn);

    public void SetCurrentNull()
    {
      this[this.tableSettings.CurrentColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  [DebuggerStepThrough]
  public class SettingsRowChangeEvent : EventArgs
  {
    private dsFiscalConfigurations.SettingsRow eventRow;
    private DataRowAction eventAction;

    public SettingsRowChangeEvent(dsFiscalConfigurations.SettingsRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    public dsFiscalConfigurations.SettingsRow Row => this.eventRow;

    public DataRowAction Action => this.eventAction;
  }
}
