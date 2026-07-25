// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.dsPolicyLookup
// Assembly: MgaSystems.IMS.Policies, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 2FF2C709-F7BF-41DA-82BD-FF6319CA235D
// Assembly location: C:\Users\muthu\Downloads\MgaSystems.IMS.Policies.dll

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Text;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

#nullable disable
namespace MGASystems.IMS.Policies;

[DesignerCategory("code")]
[ToolboxItem(true)]
[XmlSchemaProvider("GetTypedDataSetSchema")]
[XmlRoot("dsPolicyLookup")]
[HelpKeyword("vs.data.DataSet")]
[Serializable]
public class dsPolicyLookup : DataSet
{
  private dsPolicyLookup.PoliciesDataTable tablePolicies;
  private dsPolicyLookup.SelectedPoliciesDataTable tableSelectedPolicies;
  private SchemaSerializationMode _schemaSerializationMode;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public dsPolicyLookup()
  {
    this._schemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.BeginInit();
    this.InitClass();
    CollectionChangeEventHandler changeEventHandler = new CollectionChangeEventHandler(this.SchemaChanged);
    base.Tables.CollectionChanged += changeEventHandler;
    base.Relations.CollectionChanged += changeEventHandler;
    this.EndInit();
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  protected dsPolicyLookup(SerializationInfo info, StreamingContext context)
    : base(info, context, false)
  {
    this._schemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    if (this.IsBinarySerialized(info, context))
    {
      this.InitVars(false);
      CollectionChangeEventHandler changeEventHandler = new CollectionChangeEventHandler(this.SchemaChanged);
      this.Tables.CollectionChanged += changeEventHandler;
      this.Relations.CollectionChanged += changeEventHandler;
    }
    else
    {
      string s = Conversions.ToString(info.GetValue("XmlSchema", typeof (string)));
      if (this.DetermineSchemaSerializationMode(info, context) == SchemaSerializationMode.IncludeSchema)
      {
        DataSet dataSet = new DataSet();
        dataSet.ReadXmlSchema((XmlReader) new XmlTextReader((TextReader) new StringReader(s)));
        if (dataSet.Tables[nameof (Policies)] != null)
          base.Tables.Add((DataTable) new dsPolicyLookup.PoliciesDataTable(dataSet.Tables[nameof (Policies)]));
        if (dataSet.Tables[nameof (SelectedPolicies)] != null)
          base.Tables.Add((DataTable) new dsPolicyLookup.SelectedPoliciesDataTable(dataSet.Tables[nameof (SelectedPolicies)]));
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
        this.ReadXmlSchema((XmlReader) new XmlTextReader((TextReader) new StringReader(s)));
      this.GetSerializationData(info, context);
      CollectionChangeEventHandler changeEventHandler = new CollectionChangeEventHandler(this.SchemaChanged);
      base.Tables.CollectionChanged += changeEventHandler;
      this.Relations.CollectionChanged += changeEventHandler;
    }
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsPolicyLookup.PoliciesDataTable Policies => this.tablePolicies;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsPolicyLookup.SelectedPoliciesDataTable SelectedPolicies => this.tableSelectedPolicies;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  [Browsable(true)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
  public override SchemaSerializationMode SchemaSerializationMode
  {
    get => this._schemaSerializationMode;
    set => this._schemaSerializationMode = value;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public new DataTableCollection Tables => base.Tables;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public new DataRelationCollection Relations => base.Relations;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  protected override void InitializeDerivedDataSet()
  {
    this.BeginInit();
    this.InitClass();
    this.EndInit();
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public override DataSet Clone()
  {
    dsPolicyLookup dsPolicyLookup = (dsPolicyLookup) base.Clone();
    dsPolicyLookup.InitVars();
    dsPolicyLookup.SchemaSerializationMode = this.SchemaSerializationMode;
    return (DataSet) dsPolicyLookup;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  protected override bool ShouldSerializeTables() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  protected override bool ShouldSerializeRelations() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  protected override void ReadXmlSerializable(XmlReader reader)
  {
    if (this.DetermineSchemaSerializationMode(reader) == SchemaSerializationMode.IncludeSchema)
    {
      this.Reset();
      DataSet dataSet = new DataSet();
      int num = (int) dataSet.ReadXml(reader);
      if (dataSet.Tables["Policies"] != null)
        base.Tables.Add((DataTable) new dsPolicyLookup.PoliciesDataTable(dataSet.Tables["Policies"]));
      if (dataSet.Tables["SelectedPolicies"] != null)
        base.Tables.Add((DataTable) new dsPolicyLookup.SelectedPoliciesDataTable(dataSet.Tables["SelectedPolicies"]));
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
    {
      int num = (int) this.ReadXml(reader);
      this.InitVars();
    }
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  protected override XmlSchema GetSchemaSerializable()
  {
    MemoryStream memoryStream = new MemoryStream();
    this.WriteXmlSchema((XmlWriter) new XmlTextWriter((Stream) memoryStream, (Encoding) null));
    memoryStream.Position = 0L;
    return XmlSchema.Read((XmlReader) new XmlTextReader((Stream) memoryStream), (ValidationEventHandler) null);
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  internal void InitVars() => this.InitVars(true);

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  internal void InitVars(bool initTable)
  {
    this.tablePolicies = (dsPolicyLookup.PoliciesDataTable) base.Tables["Policies"];
    if (initTable && this.tablePolicies != null)
      this.tablePolicies.InitVars();
    this.tableSelectedPolicies = (dsPolicyLookup.SelectedPoliciesDataTable) base.Tables["SelectedPolicies"];
    if (!initTable || this.tableSelectedPolicies == null)
      return;
    this.tableSelectedPolicies.InitVars();
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private void InitClass()
  {
    this.DataSetName = nameof (dsPolicyLookup);
    this.Prefix = "";
    this.Namespace = "http://tempuri.org/dsPolicyLookup.xsd";
    this.EnforceConstraints = true;
    this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.tablePolicies = new dsPolicyLookup.PoliciesDataTable();
    base.Tables.Add((DataTable) this.tablePolicies);
    this.tableSelectedPolicies = new dsPolicyLookup.SelectedPoliciesDataTable();
    base.Tables.Add((DataTable) this.tableSelectedPolicies);
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializePolicies() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializeSelectedPolicies() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private void SchemaChanged(object sender, CollectionChangeEventArgs e)
  {
    if (e.Action != CollectionChangeAction.Remove)
      return;
    this.InitVars();
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public static XmlSchemaComplexType GetTypedDataSetSchema(XmlSchemaSet xs)
  {
    dsPolicyLookup dsPolicyLookup = new dsPolicyLookup();
    XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
    schemaComplexType.Particle = (XmlSchemaParticle) new XmlSchemaSequence()
    {
      Items = {
        (XmlSchemaObject) new XmlSchemaAny()
        {
          Namespace = dsPolicyLookup.Namespace
        }
      }
    };
    XmlSchema schemaSerializable = dsPolicyLookup.GetSchemaSerializable();
    XmlSchemaComplexType typedDataSetSchema;
    if (xs.Contains(schemaSerializable.TargetNamespace))
    {
      MemoryStream memoryStream1 = new MemoryStream();
      MemoryStream memoryStream2 = new MemoryStream();
      try
      {
        schemaSerializable.Write((Stream) memoryStream1);
        IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
        while (enumerator.MoveNext())
        {
          XmlSchema current = (XmlSchema) enumerator.Current;
          memoryStream2.SetLength(0L);
          MemoryStream memoryStream3 = memoryStream2;
          current.Write((Stream) memoryStream3);
          if (memoryStream1.Length == memoryStream2.Length)
          {
            memoryStream1.Position = 0L;
            memoryStream2.Position = 0L;
            do
              ;
            while (memoryStream1.Position != memoryStream1.Length && memoryStream1.ReadByte() == memoryStream2.ReadByte());
            if (memoryStream1.Position == memoryStream1.Length)
            {
              typedDataSetSchema = schemaComplexType;
              goto label_15;
            }
          }
        }
      }
      finally
      {
        memoryStream1?.Close();
        memoryStream2?.Close();
      }
    }
    xs.Add(schemaSerializable);
    typedDataSetSchema = schemaComplexType;
label_15:
    return typedDataSetSchema;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public delegate void PoliciesRowChangeEventHandler(
    object sender,
    dsPolicyLookup.PoliciesRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public delegate void SelectedPoliciesRowChangeEventHandler(
    object sender,
    dsPolicyLookup.SelectedPoliciesRowChangeEvent e);

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class PoliciesDataTable : TypedTableBase<dsPolicyLookup.PoliciesRow>
  {
    private DataColumn columnRecordNumber;
    private DataColumn columnQuoteGuid;
    private DataColumn columnPolicyNumber;
    private DataColumn columnControlNo;
    private DataColumn columnInsuredName;
    private DataColumn columnCompanyName;
    private DataColumn columnEffectiveDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public PoliciesDataTable()
    {
      this.TableName = "Policies";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal PoliciesDataTable(DataTable table)
    {
      this.TableName = table.TableName;
      if (table.CaseSensitive != table.DataSet.CaseSensitive)
        this.CaseSensitive = table.CaseSensitive;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(table.Locale.ToString(), table.DataSet.Locale.ToString(), false) != 0)
        this.Locale = table.Locale;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(table.Namespace, table.DataSet.Namespace, false) != 0)
        this.Namespace = table.Namespace;
      this.Prefix = table.Prefix;
      this.MinimumCapacity = table.MinimumCapacity;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected PoliciesDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn RecordNumberColumn => this.columnRecordNumber;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn QuoteGuidColumn => this.columnQuoteGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn PolicyNumberColumn => this.columnPolicyNumber;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ControlNoColumn => this.columnControlNo;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn InsuredNameColumn => this.columnInsuredName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn CompanyNameColumn => this.columnCompanyName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn EffectiveDateColumn => this.columnEffectiveDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPolicyLookup.PoliciesRow this[int index]
    {
      get => (dsPolicyLookup.PoliciesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsPolicyLookup.PoliciesRowChangeEventHandler PoliciesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsPolicyLookup.PoliciesRowChangeEventHandler PoliciesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsPolicyLookup.PoliciesRowChangeEventHandler PoliciesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsPolicyLookup.PoliciesRowChangeEventHandler PoliciesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AddPoliciesRow(dsPolicyLookup.PoliciesRow row) => this.Rows.Add((DataRow) row);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPolicyLookup.PoliciesRow AddPoliciesRow(
      Guid QuoteGuid,
      string PolicyNumber,
      int ControlNo,
      string InsuredName,
      string CompanyName,
      DateTime EffectiveDate)
    {
      dsPolicyLookup.PoliciesRow row = (dsPolicyLookup.PoliciesRow) this.NewRow();
      object[] objArray = new object[7]
      {
        null,
        (object) QuoteGuid,
        (object) PolicyNumber,
        (object) ControlNo,
        (object) InsuredName,
        (object) CompanyName,
        (object) EffectiveDate
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsPolicyLookup.PoliciesDataTable policiesDataTable = (dsPolicyLookup.PoliciesDataTable) base.Clone();
      policiesDataTable.InitVars();
      return (DataTable) policiesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsPolicyLookup.PoliciesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal void InitVars()
    {
      this.columnRecordNumber = this.Columns["RecordNumber"];
      this.columnQuoteGuid = this.Columns["QuoteGuid"];
      this.columnPolicyNumber = this.Columns["PolicyNumber"];
      this.columnControlNo = this.Columns["ControlNo"];
      this.columnInsuredName = this.Columns["InsuredName"];
      this.columnCompanyName = this.Columns["CompanyName"];
      this.columnEffectiveDate = this.Columns["EffectiveDate"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.columnRecordNumber = new DataColumn("RecordNumber", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnRecordNumber);
      this.columnQuoteGuid = new DataColumn("QuoteGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnQuoteGuid);
      this.columnPolicyNumber = new DataColumn("PolicyNumber", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPolicyNumber);
      this.columnControlNo = new DataColumn("ControlNo", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnControlNo);
      this.columnInsuredName = new DataColumn("InsuredName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInsuredName);
      this.columnCompanyName = new DataColumn("CompanyName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCompanyName);
      this.columnEffectiveDate = new DataColumn("EffectiveDate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEffectiveDate);
      this.columnRecordNumber.AutoIncrement = true;
      this.columnRecordNumber.AllowDBNull = false;
      this.columnRecordNumber.ReadOnly = true;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPolicyLookup.PoliciesRow NewPoliciesRow()
    {
      return (dsPolicyLookup.PoliciesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsPolicyLookup.PoliciesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType() => typeof (dsPolicyLookup.PoliciesRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.PoliciesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyLookup.PoliciesRowChangeEventHandler policiesRowChangedEvent = this.PoliciesRowChangedEvent;
      if (policiesRowChangedEvent == null)
        return;
      policiesRowChangedEvent((object) this, new dsPolicyLookup.PoliciesRowChangeEvent((dsPolicyLookup.PoliciesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.PoliciesRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyLookup.PoliciesRowChangeEventHandler rowChangingEvent = this.PoliciesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsPolicyLookup.PoliciesRowChangeEvent((dsPolicyLookup.PoliciesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.PoliciesRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyLookup.PoliciesRowChangeEventHandler policiesRowDeletedEvent = this.PoliciesRowDeletedEvent;
      if (policiesRowDeletedEvent == null)
        return;
      policiesRowDeletedEvent((object) this, new dsPolicyLookup.PoliciesRowChangeEvent((dsPolicyLookup.PoliciesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.PoliciesRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyLookup.PoliciesRowChangeEventHandler rowDeletingEvent = this.PoliciesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsPolicyLookup.PoliciesRowChangeEvent((dsPolicyLookup.PoliciesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemovePoliciesRow(dsPolicyLookup.PoliciesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsPolicyLookup dsPolicyLookup = new dsPolicyLookup();
      XmlSchemaAny xmlSchemaAny1 = new XmlSchemaAny();
      xmlSchemaAny1.Namespace = "http://www.w3.org/2001/XMLSchema";
      xmlSchemaAny1.MinOccurs = 0M;
      xmlSchemaAny1.MaxOccurs = Decimal.MaxValue;
      xmlSchemaAny1.ProcessContents = XmlSchemaContentProcessing.Lax;
      xmlSchemaSequence.Items.Add((XmlSchemaObject) xmlSchemaAny1);
      XmlSchemaAny xmlSchemaAny2 = new XmlSchemaAny();
      xmlSchemaAny2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
      xmlSchemaAny2.MinOccurs = 1M;
      xmlSchemaAny2.ProcessContents = XmlSchemaContentProcessing.Lax;
      xmlSchemaSequence.Items.Add((XmlSchemaObject) xmlSchemaAny2);
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "namespace",
        FixedValue = dsPolicyLookup.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (PoliciesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsPolicyLookup.GetSchemaSerializable();
      XmlSchemaComplexType typedTableSchema;
      if (xs.Contains(schemaSerializable.TargetNamespace))
      {
        MemoryStream memoryStream1 = new MemoryStream();
        MemoryStream memoryStream2 = new MemoryStream();
        try
        {
          schemaSerializable.Write((Stream) memoryStream1);
          IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
          while (enumerator.MoveNext())
          {
            XmlSchema current = (XmlSchema) enumerator.Current;
            memoryStream2.SetLength(0L);
            MemoryStream memoryStream3 = memoryStream2;
            current.Write((Stream) memoryStream3);
            if (memoryStream1.Length == memoryStream2.Length)
            {
              memoryStream1.Position = 0L;
              memoryStream2.Position = 0L;
              do
                ;
              while (memoryStream1.Position != memoryStream1.Length && memoryStream1.ReadByte() == memoryStream2.ReadByte());
              if (memoryStream1.Position == memoryStream1.Length)
              {
                typedTableSchema = schemaComplexType;
                goto label_15;
              }
            }
          }
        }
        finally
        {
          memoryStream1?.Close();
          memoryStream2?.Close();
        }
      }
      xs.Add(schemaSerializable);
      typedTableSchema = schemaComplexType;
label_15:
      return typedTableSchema;
    }
  }

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class SelectedPoliciesDataTable : TypedTableBase<dsPolicyLookup.SelectedPoliciesRow>
  {
    private DataColumn columnQuoteGuid;
    private DataColumn columnPolicyNumber;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public SelectedPoliciesDataTable()
    {
      this.TableName = "SelectedPolicies";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal SelectedPoliciesDataTable(DataTable table)
    {
      this.TableName = table.TableName;
      if (table.CaseSensitive != table.DataSet.CaseSensitive)
        this.CaseSensitive = table.CaseSensitive;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(table.Locale.ToString(), table.DataSet.Locale.ToString(), false) != 0)
        this.Locale = table.Locale;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(table.Namespace, table.DataSet.Namespace, false) != 0)
        this.Namespace = table.Namespace;
      this.Prefix = table.Prefix;
      this.MinimumCapacity = table.MinimumCapacity;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected SelectedPoliciesDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn QuoteGuidColumn => this.columnQuoteGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn PolicyNumberColumn => this.columnPolicyNumber;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPolicyLookup.SelectedPoliciesRow this[int index]
    {
      get => (dsPolicyLookup.SelectedPoliciesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsPolicyLookup.SelectedPoliciesRowChangeEventHandler SelectedPoliciesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsPolicyLookup.SelectedPoliciesRowChangeEventHandler SelectedPoliciesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsPolicyLookup.SelectedPoliciesRowChangeEventHandler SelectedPoliciesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsPolicyLookup.SelectedPoliciesRowChangeEventHandler SelectedPoliciesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AddSelectedPoliciesRow(dsPolicyLookup.SelectedPoliciesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPolicyLookup.SelectedPoliciesRow AddSelectedPoliciesRow(
      Guid QuoteGuid,
      string PolicyNumber)
    {
      dsPolicyLookup.SelectedPoliciesRow row = (dsPolicyLookup.SelectedPoliciesRow) this.NewRow();
      object[] objArray = new object[2]
      {
        (object) QuoteGuid,
        (object) PolicyNumber
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPolicyLookup.SelectedPoliciesRow FindByQuoteGuid(Guid QuoteGuid)
    {
      return (dsPolicyLookup.SelectedPoliciesRow) this.Rows.Find(new object[1]
      {
        (object) QuoteGuid
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsPolicyLookup.SelectedPoliciesDataTable policiesDataTable = (dsPolicyLookup.SelectedPoliciesDataTable) base.Clone();
      policiesDataTable.InitVars();
      return (DataTable) policiesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsPolicyLookup.SelectedPoliciesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal void InitVars()
    {
      this.columnQuoteGuid = this.Columns["QuoteGuid"];
      this.columnPolicyNumber = this.Columns["PolicyNumber"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.columnQuoteGuid = new DataColumn("QuoteGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnQuoteGuid);
      this.columnPolicyNumber = new DataColumn("PolicyNumber", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPolicyNumber);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsPolicyLookupKey1", new DataColumn[1]
      {
        this.columnQuoteGuid
      }, true));
      this.columnQuoteGuid.AllowDBNull = false;
      this.columnQuoteGuid.Unique = true;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPolicyLookup.SelectedPoliciesRow NewSelectedPoliciesRow()
    {
      return (dsPolicyLookup.SelectedPoliciesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsPolicyLookup.SelectedPoliciesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType() => typeof (dsPolicyLookup.SelectedPoliciesRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.SelectedPoliciesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyLookup.SelectedPoliciesRowChangeEventHandler policiesRowChangedEvent = this.SelectedPoliciesRowChangedEvent;
      if (policiesRowChangedEvent == null)
        return;
      policiesRowChangedEvent((object) this, new dsPolicyLookup.SelectedPoliciesRowChangeEvent((dsPolicyLookup.SelectedPoliciesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.SelectedPoliciesRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyLookup.SelectedPoliciesRowChangeEventHandler rowChangingEvent = this.SelectedPoliciesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsPolicyLookup.SelectedPoliciesRowChangeEvent((dsPolicyLookup.SelectedPoliciesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.SelectedPoliciesRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyLookup.SelectedPoliciesRowChangeEventHandler policiesRowDeletedEvent = this.SelectedPoliciesRowDeletedEvent;
      if (policiesRowDeletedEvent == null)
        return;
      policiesRowDeletedEvent((object) this, new dsPolicyLookup.SelectedPoliciesRowChangeEvent((dsPolicyLookup.SelectedPoliciesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.SelectedPoliciesRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPolicyLookup.SelectedPoliciesRowChangeEventHandler rowDeletingEvent = this.SelectedPoliciesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsPolicyLookup.SelectedPoliciesRowChangeEvent((dsPolicyLookup.SelectedPoliciesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemoveSelectedPoliciesRow(dsPolicyLookup.SelectedPoliciesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsPolicyLookup dsPolicyLookup = new dsPolicyLookup();
      XmlSchemaAny xmlSchemaAny1 = new XmlSchemaAny();
      xmlSchemaAny1.Namespace = "http://www.w3.org/2001/XMLSchema";
      xmlSchemaAny1.MinOccurs = 0M;
      xmlSchemaAny1.MaxOccurs = Decimal.MaxValue;
      xmlSchemaAny1.ProcessContents = XmlSchemaContentProcessing.Lax;
      xmlSchemaSequence.Items.Add((XmlSchemaObject) xmlSchemaAny1);
      XmlSchemaAny xmlSchemaAny2 = new XmlSchemaAny();
      xmlSchemaAny2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
      xmlSchemaAny2.MinOccurs = 1M;
      xmlSchemaAny2.ProcessContents = XmlSchemaContentProcessing.Lax;
      xmlSchemaSequence.Items.Add((XmlSchemaObject) xmlSchemaAny2);
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "namespace",
        FixedValue = dsPolicyLookup.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (SelectedPoliciesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsPolicyLookup.GetSchemaSerializable();
      XmlSchemaComplexType typedTableSchema;
      if (xs.Contains(schemaSerializable.TargetNamespace))
      {
        MemoryStream memoryStream1 = new MemoryStream();
        MemoryStream memoryStream2 = new MemoryStream();
        try
        {
          schemaSerializable.Write((Stream) memoryStream1);
          IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
          while (enumerator.MoveNext())
          {
            XmlSchema current = (XmlSchema) enumerator.Current;
            memoryStream2.SetLength(0L);
            MemoryStream memoryStream3 = memoryStream2;
            current.Write((Stream) memoryStream3);
            if (memoryStream1.Length == memoryStream2.Length)
            {
              memoryStream1.Position = 0L;
              memoryStream2.Position = 0L;
              do
                ;
              while (memoryStream1.Position != memoryStream1.Length && memoryStream1.ReadByte() == memoryStream2.ReadByte());
              if (memoryStream1.Position == memoryStream1.Length)
              {
                typedTableSchema = schemaComplexType;
                goto label_15;
              }
            }
          }
        }
        finally
        {
          memoryStream1?.Close();
          memoryStream2?.Close();
        }
      }
      xs.Add(schemaSerializable);
      typedTableSchema = schemaComplexType;
label_15:
      return typedTableSchema;
    }
  }

  public class PoliciesRow : DataRow
  {
    private dsPolicyLookup.PoliciesDataTable tablePolicies;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal PoliciesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablePolicies = (dsPolicyLookup.PoliciesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int RecordNumber
    {
      get => Conversions.ToInteger(this[this.tablePolicies.RecordNumberColumn]);
      set => this[this.tablePolicies.RecordNumberColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Guid QuoteGuid
    {
      get
      {
        try
        {
          object obj = this[this.tablePolicies.QuoteGuidColumn];
          return obj != null ? (Guid) obj : new Guid();
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'QuoteGuid' in table 'Policies' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePolicies.QuoteGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string PolicyNumber
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablePolicies.PolicyNumberColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'PolicyNumber' in table 'Policies' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePolicies.PolicyNumberColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int ControlNo
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tablePolicies.ControlNoColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ControlNo' in table 'Policies' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePolicies.ControlNoColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string InsuredName
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablePolicies.InsuredNameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'InsuredName' in table 'Policies' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePolicies.InsuredNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string CompanyName
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablePolicies.CompanyNameColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'CompanyName' in table 'Policies' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePolicies.CompanyNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DateTime EffectiveDate
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tablePolicies.EffectiveDateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'EffectiveDate' in table 'Policies' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePolicies.EffectiveDateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsQuoteGuidNull() => this.IsNull(this.tablePolicies.QuoteGuidColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetQuoteGuidNull()
    {
      this[this.tablePolicies.QuoteGuidColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsPolicyNumberNull() => this.IsNull(this.tablePolicies.PolicyNumberColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetPolicyNumberNull()
    {
      this[this.tablePolicies.PolicyNumberColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsControlNoNull() => this.IsNull(this.tablePolicies.ControlNoColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetControlNoNull()
    {
      this[this.tablePolicies.ControlNoColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsInsuredNameNull() => this.IsNull(this.tablePolicies.InsuredNameColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetInsuredNameNull()
    {
      this[this.tablePolicies.InsuredNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsCompanyNameNull() => this.IsNull(this.tablePolicies.CompanyNameColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetCompanyNameNull()
    {
      this[this.tablePolicies.CompanyNameColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsEffectiveDateNull() => this.IsNull(this.tablePolicies.EffectiveDateColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetEffectiveDateNull()
    {
      this[this.tablePolicies.EffectiveDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class SelectedPoliciesRow : DataRow
  {
    private dsPolicyLookup.SelectedPoliciesDataTable tableSelectedPolicies;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal SelectedPoliciesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableSelectedPolicies = (dsPolicyLookup.SelectedPoliciesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Guid QuoteGuid
    {
      get
      {
        object obj = this[this.tableSelectedPolicies.QuoteGuidColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tableSelectedPolicies.QuoteGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string PolicyNumber
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableSelectedPolicies.PolicyNumberColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'PolicyNumber' in table 'SelectedPolicies' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableSelectedPolicies.PolicyNumberColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsPolicyNumberNull() => this.IsNull(this.tableSelectedPolicies.PolicyNumberColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetPolicyNumberNull()
    {
      this[this.tableSelectedPolicies.PolicyNumberColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class PoliciesRowChangeEvent : EventArgs
  {
    private dsPolicyLookup.PoliciesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public PoliciesRowChangeEvent(dsPolicyLookup.PoliciesRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPolicyLookup.PoliciesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class SelectedPoliciesRowChangeEvent : EventArgs
  {
    private dsPolicyLookup.SelectedPoliciesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public SelectedPoliciesRowChangeEvent(
      dsPolicyLookup.SelectedPoliciesRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPolicyLookup.SelectedPoliciesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }
}
