// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.AccountingDatasets.dsFindPolicy
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
public class dsFindPolicy : DataSet
{
  private dsFindPolicy.FindPolicyDataTable tableFindPolicy;

  public dsFindPolicy()
  {
    this.InitClass();
    CollectionChangeEventHandler changeEventHandler = new CollectionChangeEventHandler(this.SchemaChanged);
    this.Tables.CollectionChanged += changeEventHandler;
    this.Relations.CollectionChanged += changeEventHandler;
  }

  protected dsFindPolicy(SerializationInfo info, StreamingContext context)
  {
    string s = Conversions.ToString(info.GetValue("XmlSchema", typeof (string)));
    if (s != null)
    {
      DataSet dataSet = new DataSet();
      dataSet.ReadXmlSchema((XmlReader) new XmlTextReader((TextReader) new StringReader(s)));
      if (dataSet.Tables[nameof (FindPolicy)] != null)
        this.Tables.Add((DataTable) new dsFindPolicy.FindPolicyDataTable(dataSet.Tables[nameof (FindPolicy)]));
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
  public dsFindPolicy.FindPolicyDataTable FindPolicy => this.tableFindPolicy;

  public override DataSet Clone()
  {
    dsFindPolicy dsFindPolicy = (dsFindPolicy) base.Clone();
    dsFindPolicy.InitVars();
    return (DataSet) dsFindPolicy;
  }

  protected override bool ShouldSerializeTables() => false;

  protected override bool ShouldSerializeRelations() => false;

  protected override void ReadXmlSerializable(XmlReader reader)
  {
    this.Reset();
    DataSet dataSet = new DataSet();
    int num = (int) dataSet.ReadXml(reader);
    if (dataSet.Tables["FindPolicy"] != null)
      this.Tables.Add((DataTable) new dsFindPolicy.FindPolicyDataTable(dataSet.Tables["FindPolicy"]));
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
    this.tableFindPolicy = (dsFindPolicy.FindPolicyDataTable) this.Tables["FindPolicy"];
    if (this.tableFindPolicy == null)
      return;
    this.tableFindPolicy.InitVars();
  }

  private void InitClass()
  {
    this.DataSetName = nameof (dsFindPolicy);
    this.Prefix = "";
    this.Namespace = "http://tempuri.org/dsFindPolicy.xsd";
    this.Locale = new CultureInfo("en-US");
    this.CaseSensitive = false;
    this.EnforceConstraints = true;
    this.tableFindPolicy = new dsFindPolicy.FindPolicyDataTable();
    this.Tables.Add((DataTable) this.tableFindPolicy);
  }

  private bool ShouldSerializeFindPolicy() => false;

  private void SchemaChanged(object sender, CollectionChangeEventArgs e)
  {
    if (e.Action != CollectionChangeAction.Remove)
      return;
    this.InitVars();
  }

  public delegate void FindPolicyRowChangeEventHandler(
    object sender,
    dsFindPolicy.FindPolicyRowChangeEvent e);

  [DebuggerStepThrough]
  public class FindPolicyDataTable : DataTable, IEnumerable
  {
    private DataColumn columnPolicyNumber;
    private DataColumn columnInsured;
    private DataColumn columnEffectiveDate;
    private DataColumn columnExpirationDate;
    private DataColumn columnProducer;
    private DataColumn columnControlNumber;

    internal FindPolicyDataTable()
      : base("FindPolicy")
    {
      this.InitClass();
    }

    internal FindPolicyDataTable(DataTable table)
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

    internal DataColumn PolicyNumberColumn => this.columnPolicyNumber;

    internal DataColumn InsuredColumn => this.columnInsured;

    internal DataColumn EffectiveDateColumn => this.columnEffectiveDate;

    internal DataColumn ExpirationDateColumn => this.columnExpirationDate;

    internal DataColumn ProducerColumn => this.columnProducer;

    internal DataColumn ControlNumberColumn => this.columnControlNumber;

    public dsFindPolicy.FindPolicyRow this[int index]
    {
      get => (dsFindPolicy.FindPolicyRow) this.Rows[index];
    }

    public event dsFindPolicy.FindPolicyRowChangeEventHandler FindPolicyRowChanged;

    public event dsFindPolicy.FindPolicyRowChangeEventHandler FindPolicyRowChanging;

    public event dsFindPolicy.FindPolicyRowChangeEventHandler FindPolicyRowDeleted;

    public event dsFindPolicy.FindPolicyRowChangeEventHandler FindPolicyRowDeleting;

    public void AddFindPolicyRow(dsFindPolicy.FindPolicyRow row) => this.Rows.Add((DataRow) row);

    public dsFindPolicy.FindPolicyRow AddFindPolicyRow(
      string PolicyNumber,
      string Insured,
      DateTime EffectiveDate,
      DateTime ExpirationDate,
      string Producer,
      int ControlNumber)
    {
      dsFindPolicy.FindPolicyRow row = (dsFindPolicy.FindPolicyRow) this.NewRow();
      row.ItemArray = new object[6]
      {
        (object) PolicyNumber,
        (object) Insured,
        (object) EffectiveDate,
        (object) ExpirationDate,
        (object) Producer,
        (object) ControlNumber
      };
      this.Rows.Add((DataRow) row);
      return row;
    }

    public IEnumerator GetEnumerator() => this.Rows.GetEnumerator();

    public override DataTable Clone()
    {
      dsFindPolicy.FindPolicyDataTable findPolicyDataTable = (dsFindPolicy.FindPolicyDataTable) base.Clone();
      findPolicyDataTable.InitVars();
      return (DataTable) findPolicyDataTable;
    }

    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsFindPolicy.FindPolicyDataTable();
    }

    internal void InitVars()
    {
      this.columnPolicyNumber = this.Columns["PolicyNumber"];
      this.columnInsured = this.Columns["Insured"];
      this.columnEffectiveDate = this.Columns["EffectiveDate"];
      this.columnExpirationDate = this.Columns["ExpirationDate"];
      this.columnProducer = this.Columns["Producer"];
      this.columnControlNumber = this.Columns["ControlNumber"];
    }

    private void InitClass()
    {
      this.columnPolicyNumber = new DataColumn("PolicyNumber", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPolicyNumber);
      this.columnInsured = new DataColumn("Insured", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInsured);
      this.columnEffectiveDate = new DataColumn("EffectiveDate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEffectiveDate);
      this.columnExpirationDate = new DataColumn("ExpirationDate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnExpirationDate);
      this.columnProducer = new DataColumn("Producer", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnProducer);
      this.columnControlNumber = new DataColumn("ControlNumber", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnControlNumber);
    }

    public dsFindPolicy.FindPolicyRow NewFindPolicyRow()
    {
      return (dsFindPolicy.FindPolicyRow) this.NewRow();
    }

    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsFindPolicy.FindPolicyRow(builder);
    }

    protected override Type GetRowType() => typeof (dsFindPolicy.FindPolicyRow);

    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.FindPolicyRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsFindPolicy.FindPolicyRowChangeEventHandler policyRowChangedEvent = this.FindPolicyRowChangedEvent;
      if (policyRowChangedEvent == null)
        return;
      policyRowChangedEvent((object) this, new dsFindPolicy.FindPolicyRowChangeEvent((dsFindPolicy.FindPolicyRow) e.Row, e.Action));
    }

    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.FindPolicyRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsFindPolicy.FindPolicyRowChangeEventHandler rowChangingEvent = this.FindPolicyRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsFindPolicy.FindPolicyRowChangeEvent((dsFindPolicy.FindPolicyRow) e.Row, e.Action));
    }

    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.FindPolicyRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsFindPolicy.FindPolicyRowChangeEventHandler policyRowDeletedEvent = this.FindPolicyRowDeletedEvent;
      if (policyRowDeletedEvent == null)
        return;
      policyRowDeletedEvent((object) this, new dsFindPolicy.FindPolicyRowChangeEvent((dsFindPolicy.FindPolicyRow) e.Row, e.Action));
    }

    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.FindPolicyRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsFindPolicy.FindPolicyRowChangeEventHandler rowDeletingEvent = this.FindPolicyRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsFindPolicy.FindPolicyRowChangeEvent((dsFindPolicy.FindPolicyRow) e.Row, e.Action));
    }

    public void RemoveFindPolicyRow(dsFindPolicy.FindPolicyRow row)
    {
      this.Rows.Remove((DataRow) row);
    }
  }

  [DebuggerStepThrough]
  public class FindPolicyRow : DataRow
  {
    private dsFindPolicy.FindPolicyDataTable tableFindPolicy;

    internal FindPolicyRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableFindPolicy = (dsFindPolicy.FindPolicyDataTable) this.Table;
    }

    public string PolicyNumber
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableFindPolicy.PolicyNumberColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableFindPolicy.PolicyNumberColumn] = (object) value;
    }

    public string Insured
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableFindPolicy.InsuredColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableFindPolicy.InsuredColumn] = (object) value;
    }

    public DateTime EffectiveDate
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tableFindPolicy.EffectiveDateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableFindPolicy.EffectiveDateColumn] = (object) value;
    }

    public DateTime ExpirationDate
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tableFindPolicy.ExpirationDateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableFindPolicy.ExpirationDateColumn] = (object) value;
    }

    public string Producer
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableFindPolicy.ProducerColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableFindPolicy.ProducerColumn] = (object) value;
    }

    public int ControlNumber
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tableFindPolicy.ControlNumberColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableFindPolicy.ControlNumberColumn] = (object) value;
    }

    public bool IsPolicyNumberNull() => this.IsNull(this.tableFindPolicy.PolicyNumberColumn);

    public void SetPolicyNumberNull()
    {
      this[this.tableFindPolicy.PolicyNumberColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsInsuredNull() => this.IsNull(this.tableFindPolicy.InsuredColumn);

    public void SetInsuredNull()
    {
      this[this.tableFindPolicy.InsuredColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsEffectiveDateNull() => this.IsNull(this.tableFindPolicy.EffectiveDateColumn);

    public void SetEffectiveDateNull()
    {
      this[this.tableFindPolicy.EffectiveDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsExpirationDateNull() => this.IsNull(this.tableFindPolicy.ExpirationDateColumn);

    public void SetExpirationDateNull()
    {
      this[this.tableFindPolicy.ExpirationDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsProducerNull() => this.IsNull(this.tableFindPolicy.ProducerColumn);

    public void SetProducerNull()
    {
      this[this.tableFindPolicy.ProducerColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    public bool IsControlNumberNull() => this.IsNull(this.tableFindPolicy.ControlNumberColumn);

    public void SetControlNumberNull()
    {
      this[this.tableFindPolicy.ControlNumberColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  [DebuggerStepThrough]
  public class FindPolicyRowChangeEvent : EventArgs
  {
    private dsFindPolicy.FindPolicyRow eventRow;
    private DataRowAction eventAction;

    public FindPolicyRowChangeEvent(dsFindPolicy.FindPolicyRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    public dsFindPolicy.FindPolicyRow Row => this.eventRow;

    public DataRowAction Action => this.eventAction;
  }
}
