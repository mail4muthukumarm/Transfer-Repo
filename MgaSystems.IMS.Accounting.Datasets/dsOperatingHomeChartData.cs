// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.AccountingDatasets.dsOperatingHomeChartData
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
public class dsOperatingHomeChartData : DataSet
{
  private dsOperatingHomeChartData.CurrentYearlyDataTable tableCurrentYearly;

  public dsOperatingHomeChartData()
  {
    this.InitClass();
    CollectionChangeEventHandler changeEventHandler = new CollectionChangeEventHandler(this.SchemaChanged);
    this.Tables.CollectionChanged += changeEventHandler;
    this.Relations.CollectionChanged += changeEventHandler;
  }

  protected dsOperatingHomeChartData(SerializationInfo info, StreamingContext context)
  {
    string s = Conversions.ToString(info.GetValue("XmlSchema", typeof (string)));
    if (s != null)
    {
      DataSet dataSet = new DataSet();
      dataSet.ReadXmlSchema((XmlReader) new XmlTextReader((TextReader) new StringReader(s)));
      if (dataSet.Tables[nameof (CurrentYearly)] != null)
        this.Tables.Add((DataTable) new dsOperatingHomeChartData.CurrentYearlyDataTable(dataSet.Tables[nameof (CurrentYearly)]));
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
  public dsOperatingHomeChartData.CurrentYearlyDataTable CurrentYearly => this.tableCurrentYearly;

  public override DataSet Clone()
  {
    dsOperatingHomeChartData operatingHomeChartData = (dsOperatingHomeChartData) base.Clone();
    operatingHomeChartData.InitVars();
    return (DataSet) operatingHomeChartData;
  }

  protected override bool ShouldSerializeTables() => false;

  protected override bool ShouldSerializeRelations() => false;

  protected override void ReadXmlSerializable(XmlReader reader)
  {
    this.Reset();
    DataSet dataSet = new DataSet();
    int num = (int) dataSet.ReadXml(reader);
    if (dataSet.Tables["CurrentYearly"] != null)
      this.Tables.Add((DataTable) new dsOperatingHomeChartData.CurrentYearlyDataTable(dataSet.Tables["CurrentYearly"]));
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
    this.tableCurrentYearly = (dsOperatingHomeChartData.CurrentYearlyDataTable) this.Tables["CurrentYearly"];
    if (this.tableCurrentYearly == null)
      return;
    this.tableCurrentYearly.InitVars();
  }

  private void InitClass()
  {
    this.DataSetName = nameof (dsOperatingHomeChartData);
    this.Prefix = "";
    this.Namespace = "http://tempuri.org/dsOperatingHomeChartData.xsd";
    this.Locale = new CultureInfo("en-US");
    this.CaseSensitive = false;
    this.EnforceConstraints = true;
    this.tableCurrentYearly = new dsOperatingHomeChartData.CurrentYearlyDataTable();
    this.Tables.Add((DataTable) this.tableCurrentYearly);
  }

  private bool ShouldSerializeCurrentYearly() => false;

  private void SchemaChanged(object sender, CollectionChangeEventArgs e)
  {
    if (e.Action != CollectionChangeAction.Remove)
      return;
    this.InitVars();
  }

  public delegate void CurrentYearlyRowChangeEventHandler(
    object sender,
    dsOperatingHomeChartData.CurrentYearlyRowChangeEvent e);

  [DebuggerStepThrough]
  public class CurrentYearlyDataTable : DataTable, IEnumerable
  {
    private DataColumn columnJAN;
    private DataColumn columnFEB;
    private DataColumn columnMAR;
    private DataColumn columnAPR;
    private DataColumn columnMAY;
    private DataColumn columnJUN;
    private DataColumn columnJUL;
    private DataColumn columnAUG;
    private DataColumn columnSEP;
    private DataColumn columnOCT;
    private DataColumn columnNOV;
    private DataColumn columnDEC;

    internal CurrentYearlyDataTable()
      : base("CurrentYearly")
    {
      this.InitClass();
    }

    internal CurrentYearlyDataTable(DataTable table)
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

    internal DataColumn JANColumn => this.columnJAN;

    internal DataColumn FEBColumn => this.columnFEB;

    internal DataColumn MARColumn => this.columnMAR;

    internal DataColumn APRColumn => this.columnAPR;

    internal DataColumn MAYColumn => this.columnMAY;

    internal DataColumn JUNColumn => this.columnJUN;

    internal DataColumn JULColumn => this.columnJUL;

    internal DataColumn AUGColumn => this.columnAUG;

    internal DataColumn SEPColumn => this.columnSEP;

    internal DataColumn OCTColumn => this.columnOCT;

    internal DataColumn NOVColumn => this.columnNOV;

    internal DataColumn DECColumn => this.columnDEC;

    public dsOperatingHomeChartData.CurrentYearlyRow this[int index]
    {
      get => (dsOperatingHomeChartData.CurrentYearlyRow) this.Rows[index];
    }

    public event dsOperatingHomeChartData.CurrentYearlyRowChangeEventHandler CurrentYearlyRowChanged;

    public event dsOperatingHomeChartData.CurrentYearlyRowChangeEventHandler CurrentYearlyRowChanging;

    public event dsOperatingHomeChartData.CurrentYearlyRowChangeEventHandler CurrentYearlyRowDeleted;

    public event dsOperatingHomeChartData.CurrentYearlyRowChangeEventHandler CurrentYearlyRowDeleting;

    public void AddCurrentYearlyRow(dsOperatingHomeChartData.CurrentYearlyRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    public dsOperatingHomeChartData.CurrentYearlyRow AddCurrentYearlyRow(
      Decimal JAN,
      Decimal FEB,
      Decimal MAR,
      Decimal APR,
      Decimal MAY,
      Decimal JUN,
      Decimal JUL,
      Decimal AUG,
      Decimal SEP,
      Decimal OCT,
      Decimal NOV,
      Decimal DEC)
    {
      dsOperatingHomeChartData.CurrentYearlyRow row = (dsOperatingHomeChartData.CurrentYearlyRow) this.NewRow();
      row.ItemArray = new object[12]
      {
        (object) JAN,
        (object) FEB,
        (object) MAR,
        (object) APR,
        (object) MAY,
        (object) JUN,
        (object) JUL,
        (object) AUG,
        (object) SEP,
        (object) OCT,
        (object) NOV,
        (object) DEC
      };
      this.Rows.Add((DataRow) row);
      return row;
    }

    public IEnumerator GetEnumerator() => this.Rows.GetEnumerator();

    public override DataTable Clone()
    {
      dsOperatingHomeChartData.CurrentYearlyDataTable currentYearlyDataTable = (dsOperatingHomeChartData.CurrentYearlyDataTable) base.Clone();
      currentYearlyDataTable.InitVars();
      return (DataTable) currentYearlyDataTable;
    }

    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsOperatingHomeChartData.CurrentYearlyDataTable();
    }

    internal void InitVars()
    {
      this.columnJAN = this.Columns["JAN"];
      this.columnFEB = this.Columns["FEB"];
      this.columnMAR = this.Columns["MAR"];
      this.columnAPR = this.Columns["APR"];
      this.columnMAY = this.Columns["MAY"];
      this.columnJUN = this.Columns["JUN"];
      this.columnJUL = this.Columns["JUL"];
      this.columnAUG = this.Columns["AUG"];
      this.columnSEP = this.Columns["SEP"];
      this.columnOCT = this.Columns["OCT"];
      this.columnNOV = this.Columns["NOV"];
      this.columnDEC = this.Columns["DEC"];
    }

    private void InitClass()
    {
      this.columnJAN = new DataColumn("JAN", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnJAN);
      this.columnFEB = new DataColumn("FEB", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFEB);
      this.columnMAR = new DataColumn("MAR", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnMAR);
      this.columnAPR = new DataColumn("APR", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAPR);
      this.columnMAY = new DataColumn("MAY", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnMAY);
      this.columnJUN = new DataColumn("JUN", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnJUN);
      this.columnJUL = new DataColumn("JUL", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnJUL);
      this.columnAUG = new DataColumn("AUG", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAUG);
      this.columnSEP = new DataColumn("SEP", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSEP);
      this.columnOCT = new DataColumn("OCT", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnOCT);
      this.columnNOV = new DataColumn("NOV", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnNOV);
      this.columnDEC = new DataColumn("DEC", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDEC);
    }

    public dsOperatingHomeChartData.CurrentYearlyRow NewCurrentYearlyRow()
    {
      return (dsOperatingHomeChartData.CurrentYearlyRow) this.NewRow();
    }

    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsOperatingHomeChartData.CurrentYearlyRow(builder);
    }

    protected override Type GetRowType() => typeof (dsOperatingHomeChartData.CurrentYearlyRow);

    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.CurrentYearlyRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsOperatingHomeChartData.CurrentYearlyRowChangeEventHandler yearlyRowChangedEvent = this.CurrentYearlyRowChangedEvent;
      if (yearlyRowChangedEvent == null)
        return;
      yearlyRowChangedEvent((object) this, new dsOperatingHomeChartData.CurrentYearlyRowChangeEvent((dsOperatingHomeChartData.CurrentYearlyRow) e.Row, e.Action));
    }

    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.CurrentYearlyRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsOperatingHomeChartData.CurrentYearlyRowChangeEventHandler rowChangingEvent = this.CurrentYearlyRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsOperatingHomeChartData.CurrentYearlyRowChangeEvent((dsOperatingHomeChartData.CurrentYearlyRow) e.Row, e.Action));
    }

    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.CurrentYearlyRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsOperatingHomeChartData.CurrentYearlyRowChangeEventHandler yearlyRowDeletedEvent = this.CurrentYearlyRowDeletedEvent;
      if (yearlyRowDeletedEvent == null)
        return;
      yearlyRowDeletedEvent((object) this, new dsOperatingHomeChartData.CurrentYearlyRowChangeEvent((dsOperatingHomeChartData.CurrentYearlyRow) e.Row, e.Action));
    }

    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.CurrentYearlyRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsOperatingHomeChartData.CurrentYearlyRowChangeEventHandler rowDeletingEvent = this.CurrentYearlyRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsOperatingHomeChartData.CurrentYearlyRowChangeEvent((dsOperatingHomeChartData.CurrentYearlyRow) e.Row, e.Action));
    }

    public void RemoveCurrentYearlyRow(dsOperatingHomeChartData.CurrentYearlyRow row)
    {
      this.Rows.Remove((DataRow) row);
    }
  }

  [DebuggerStepThrough]
  public class CurrentYearlyRow : DataRow
  {
    private dsOperatingHomeChartData.CurrentYearlyDataTable tableCurrentYearly;

    internal CurrentYearlyRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableCurrentYearly = (dsOperatingHomeChartData.CurrentYearlyDataTable) this.Table;
    }

    public Decimal JAN
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tableCurrentYearly.JANColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableCurrentYearly.JANColumn] = (object) value;
    }

    public Decimal FEB
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tableCurrentYearly.FEBColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableCurrentYearly.FEBColumn] = (object) value;
    }

    public Decimal MAR
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tableCurrentYearly.MARColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableCurrentYearly.MARColumn] = (object) value;
    }

    public Decimal APR
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tableCurrentYearly.APRColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableCurrentYearly.APRColumn] = (object) value;
    }

    public Decimal MAY
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tableCurrentYearly.MAYColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableCurrentYearly.MAYColumn] = (object) value;
    }

    public Decimal JUN
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tableCurrentYearly.JUNColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableCurrentYearly.JUNColumn] = (object) value;
    }

    public Decimal JUL
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tableCurrentYearly.JULColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableCurrentYearly.JULColumn] = (object) value;
    }

    public Decimal AUG
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tableCurrentYearly.AUGColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableCurrentYearly.AUGColumn] = (object) value;
    }

    public Decimal SEP
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tableCurrentYearly.SEPColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableCurrentYearly.SEPColumn] = (object) value;
    }

    public Decimal OCT
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tableCurrentYearly.OCTColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableCurrentYearly.OCTColumn] = (object) value;
    }

    public Decimal NOV
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tableCurrentYearly.NOVColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableCurrentYearly.NOVColumn] = (object) value;
    }

    public Decimal DEC
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tableCurrentYearly.DECColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableCurrentYearly.DECColumn] = (object) value;
    }

    public bool IsJANNull() => this.IsNull(this.tableCurrentYearly.JANColumn);

    public void SetJANNull()
    {
      this[this.tableCurrentYearly.JANColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsFEBNull() => this.IsNull(this.tableCurrentYearly.FEBColumn);

    public void SetFEBNull()
    {
      this[this.tableCurrentYearly.FEBColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsMARNull() => this.IsNull(this.tableCurrentYearly.MARColumn);

    public void SetMARNull()
    {
      this[this.tableCurrentYearly.MARColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsAPRNull() => this.IsNull(this.tableCurrentYearly.APRColumn);

    public void SetAPRNull()
    {
      this[this.tableCurrentYearly.APRColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsMAYNull() => this.IsNull(this.tableCurrentYearly.MAYColumn);

    public void SetMAYNull()
    {
      this[this.tableCurrentYearly.MAYColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsJUNNull() => this.IsNull(this.tableCurrentYearly.JUNColumn);

    public void SetJUNNull()
    {
      this[this.tableCurrentYearly.JUNColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsJULNull() => this.IsNull(this.tableCurrentYearly.JULColumn);

    public void SetJULNull()
    {
      this[this.tableCurrentYearly.JULColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsAUGNull() => this.IsNull(this.tableCurrentYearly.AUGColumn);

    public void SetAUGNull()
    {
      this[this.tableCurrentYearly.AUGColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsSEPNull() => this.IsNull(this.tableCurrentYearly.SEPColumn);

    public void SetSEPNull()
    {
      this[this.tableCurrentYearly.SEPColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsOCTNull() => this.IsNull(this.tableCurrentYearly.OCTColumn);

    public void SetOCTNull()
    {
      this[this.tableCurrentYearly.OCTColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsNOVNull() => this.IsNull(this.tableCurrentYearly.NOVColumn);

    public void SetNOVNull()
    {
      this[this.tableCurrentYearly.NOVColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsDECNull() => this.IsNull(this.tableCurrentYearly.DECColumn);

    public void SetDECNull()
    {
      this[this.tableCurrentYearly.DECColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  [DebuggerStepThrough]
  public class CurrentYearlyRowChangeEvent : EventArgs
  {
    private dsOperatingHomeChartData.CurrentYearlyRow eventRow;
    private DataRowAction eventAction;

    public CurrentYearlyRowChangeEvent(
      dsOperatingHomeChartData.CurrentYearlyRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    public dsOperatingHomeChartData.CurrentYearlyRow Row => this.eventRow;

    public DataRowAction Action => this.eventAction;
  }
}
