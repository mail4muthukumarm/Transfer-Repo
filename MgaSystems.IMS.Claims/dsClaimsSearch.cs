// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Claims.dsClaimsSearch
// Assembly: MgaSystems.IMS.Claims, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FCD9D0B7-28CF-40B9-8EB7-297871E1AF5F
// Assembly location: F:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims.dll

using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

#nullable disable
namespace MGASystems.IMS.Claims;

[DesignerCategory("code")]
[ToolboxItem(true)]
[XmlSchemaProvider("GetTypedDataSetSchema")]
[XmlRoot("dsClaimsSearch")]
[HelpKeyword("vs.data.DataSet")]
[Serializable]
public class dsClaimsSearch : DataSet
{
  private dsClaimsSearch.PolicyInformationDataTable tablePolicyInformation;
  private dsClaimsSearch.ClaimsInformationDataTable tableClaimsInformation;
  private DataRelation relationFK_PolicyInformation_ClaimsInformation;
  private SchemaSerializationMode _schemaSerializationMode = SchemaSerializationMode.IncludeSchema;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public dsClaimsSearch()
  {
    this.BeginInit();
    this.InitClass();
    CollectionChangeEventHandler changeEventHandler = new CollectionChangeEventHandler(this.SchemaChanged);
    base.Tables.CollectionChanged += changeEventHandler;
    base.Relations.CollectionChanged += changeEventHandler;
    this.EndInit();
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  protected dsClaimsSearch(SerializationInfo info, StreamingContext context)
    : base(info, context, false)
  {
    if (this.IsBinarySerialized(info, context))
    {
      this.InitVars(false);
      CollectionChangeEventHandler changeEventHandler = new CollectionChangeEventHandler(this.SchemaChanged);
      this.Tables.CollectionChanged += changeEventHandler;
      this.Relations.CollectionChanged += changeEventHandler;
    }
    else
    {
      string s = (string) info.GetValue("XmlSchema", typeof (string));
      if (this.DetermineSchemaSerializationMode(info, context) == SchemaSerializationMode.IncludeSchema)
      {
        DataSet dataSet = new DataSet();
        dataSet.ReadXmlSchema((XmlReader) new XmlTextReader((TextReader) new StringReader(s)));
        if (dataSet.Tables[nameof (PolicyInformation)] != null)
          base.Tables.Add((DataTable) new dsClaimsSearch.PolicyInformationDataTable(dataSet.Tables[nameof (PolicyInformation)]));
        if (dataSet.Tables[nameof (ClaimsInformation)] != null)
          base.Tables.Add((DataTable) new dsClaimsSearch.ClaimsInformationDataTable(dataSet.Tables[nameof (ClaimsInformation)]));
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
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsClaimsSearch.PolicyInformationDataTable PolicyInformation => this.tablePolicyInformation;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsClaimsSearch.ClaimsInformationDataTable ClaimsInformation => this.tableClaimsInformation;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [Browsable(true)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
  public override SchemaSerializationMode SchemaSerializationMode
  {
    get => this._schemaSerializationMode;
    set => this._schemaSerializationMode = value;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public new DataTableCollection Tables => base.Tables;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public new DataRelationCollection Relations => base.Relations;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  protected override void InitializeDerivedDataSet()
  {
    this.BeginInit();
    this.InitClass();
    this.EndInit();
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public override DataSet Clone()
  {
    dsClaimsSearch dsClaimsSearch = (dsClaimsSearch) base.Clone();
    dsClaimsSearch.InitVars();
    dsClaimsSearch.SchemaSerializationMode = this.SchemaSerializationMode;
    return (DataSet) dsClaimsSearch;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  protected override bool ShouldSerializeTables() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  protected override bool ShouldSerializeRelations() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  protected override void ReadXmlSerializable(XmlReader reader)
  {
    if (this.DetermineSchemaSerializationMode(reader) == SchemaSerializationMode.IncludeSchema)
    {
      this.Reset();
      DataSet dataSet = new DataSet();
      int num = (int) dataSet.ReadXml(reader);
      if (dataSet.Tables["PolicyInformation"] != null)
        base.Tables.Add((DataTable) new dsClaimsSearch.PolicyInformationDataTable(dataSet.Tables["PolicyInformation"]));
      if (dataSet.Tables["ClaimsInformation"] != null)
        base.Tables.Add((DataTable) new dsClaimsSearch.ClaimsInformationDataTable(dataSet.Tables["ClaimsInformation"]));
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
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  protected override XmlSchema GetSchemaSerializable()
  {
    MemoryStream memoryStream = new MemoryStream();
    this.WriteXmlSchema((XmlWriter) new XmlTextWriter((Stream) memoryStream, (Encoding) null));
    memoryStream.Position = 0L;
    return XmlSchema.Read((XmlReader) new XmlTextReader((Stream) memoryStream), (ValidationEventHandler) null);
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  internal void InitVars() => this.InitVars(true);

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  internal void InitVars(bool initTable)
  {
    this.tablePolicyInformation = (dsClaimsSearch.PolicyInformationDataTable) base.Tables["PolicyInformation"];
    if (initTable && this.tablePolicyInformation != null)
      this.tablePolicyInformation.InitVars();
    this.tableClaimsInformation = (dsClaimsSearch.ClaimsInformationDataTable) base.Tables["ClaimsInformation"];
    if (initTable && this.tableClaimsInformation != null)
      this.tableClaimsInformation.InitVars();
    this.relationFK_PolicyInformation_ClaimsInformation = this.Relations["FK_PolicyInformation_ClaimsInformation"];
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private void InitClass()
  {
    this.DataSetName = nameof (dsClaimsSearch);
    this.Prefix = "";
    this.Namespace = "http://tempuri.org/dsClaimsSearch.xsd";
    this.EnforceConstraints = true;
    this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.tablePolicyInformation = new dsClaimsSearch.PolicyInformationDataTable();
    base.Tables.Add((DataTable) this.tablePolicyInformation);
    this.tableClaimsInformation = new dsClaimsSearch.ClaimsInformationDataTable();
    base.Tables.Add((DataTable) this.tableClaimsInformation);
    this.relationFK_PolicyInformation_ClaimsInformation = new DataRelation("FK_PolicyInformation_ClaimsInformation", new DataColumn[1]
    {
      this.tablePolicyInformation.ControlNumberColumn
    }, new DataColumn[1]
    {
      this.tableClaimsInformation.ControlNumberColumn
    }, false);
    this.Relations.Add(this.relationFK_PolicyInformation_ClaimsInformation);
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializePolicyInformation() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializeClaimsInformation() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private void SchemaChanged(object sender, CollectionChangeEventArgs e)
  {
    if (e.Action != CollectionChangeAction.Remove)
      return;
    this.InitVars();
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public static XmlSchemaComplexType GetTypedDataSetSchema(XmlSchemaSet xs)
  {
    dsClaimsSearch dsClaimsSearch = new dsClaimsSearch();
    XmlSchemaComplexType typedDataSetSchema = new XmlSchemaComplexType();
    XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
    xmlSchemaSequence.Items.Add((XmlSchemaObject) new XmlSchemaAny()
    {
      Namespace = dsClaimsSearch.Namespace
    });
    typedDataSetSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
    XmlSchema schemaSerializable = dsClaimsSearch.GetSchemaSerializable();
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
              return typedDataSetSchema;
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
    return typedDataSetSchema;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void PolicyInformationRowChangeEventHandler(
    object sender,
    dsClaimsSearch.PolicyInformationRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void ClaimsInformationRowChangeEventHandler(
    object sender,
    dsClaimsSearch.ClaimsInformationRowChangeEvent e);

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class PolicyInformationDataTable : TypedTableBase<dsClaimsSearch.PolicyInformationRow>
  {
    private DataColumn columnControlNumber;
    private DataColumn columnPolicyNumber;
    private DataColumn columnInsured;
    private DataColumn columnProducer;
    private DataColumn columnCompany;
    private DataColumn columnLine;
    private DataColumn columnViewClaims;
    private DataColumn columnNumberOfClaims;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public PolicyInformationDataTable()
    {
      this.TableName = "PolicyInformation";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal PolicyInformationDataTable(DataTable table)
    {
      this.TableName = table.TableName;
      if (table.CaseSensitive != table.DataSet.CaseSensitive)
        this.CaseSensitive = table.CaseSensitive;
      if (table.Locale.ToString() != table.DataSet.Locale.ToString())
        this.Locale = table.Locale;
      if (table.Namespace != table.DataSet.Namespace)
        this.Namespace = table.Namespace;
      this.Prefix = table.Prefix;
      this.MinimumCapacity = table.MinimumCapacity;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected PolicyInformationDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ControlNumberColumn => this.columnControlNumber;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn PolicyNumberColumn => this.columnPolicyNumber;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn InsuredColumn => this.columnInsured;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ProducerColumn => this.columnProducer;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn CompanyColumn => this.columnCompany;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn LineColumn => this.columnLine;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ViewClaimsColumn => this.columnViewClaims;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn NumberOfClaimsColumn => this.columnNumberOfClaims;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsClaimsSearch.PolicyInformationRow this[int index]
    {
      get => (dsClaimsSearch.PolicyInformationRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsClaimsSearch.PolicyInformationRowChangeEventHandler PolicyInformationRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsClaimsSearch.PolicyInformationRowChangeEventHandler PolicyInformationRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsClaimsSearch.PolicyInformationRowChangeEventHandler PolicyInformationRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsClaimsSearch.PolicyInformationRowChangeEventHandler PolicyInformationRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddPolicyInformationRow(dsClaimsSearch.PolicyInformationRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsClaimsSearch.PolicyInformationRow AddPolicyInformationRow(
      int ControlNumber,
      string PolicyNumber,
      string Insured,
      string Producer,
      string Company,
      string Line,
      string ViewClaims,
      int NumberOfClaims)
    {
      dsClaimsSearch.PolicyInformationRow row = (dsClaimsSearch.PolicyInformationRow) this.NewRow();
      object[] objArray = new object[8]
      {
        (object) ControlNumber,
        (object) PolicyNumber,
        (object) Insured,
        (object) Producer,
        (object) Company,
        (object) Line,
        (object) ViewClaims,
        (object) NumberOfClaims
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsClaimsSearch.PolicyInformationRow FindByControlNumber(int ControlNumber)
    {
      return (dsClaimsSearch.PolicyInformationRow) this.Rows.Find(new object[1]
      {
        (object) ControlNumber
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsClaimsSearch.PolicyInformationDataTable informationDataTable = (dsClaimsSearch.PolicyInformationDataTable) base.Clone();
      informationDataTable.InitVars();
      return (DataTable) informationDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsClaimsSearch.PolicyInformationDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnControlNumber = this.Columns["ControlNumber"];
      this.columnPolicyNumber = this.Columns["PolicyNumber"];
      this.columnInsured = this.Columns["Insured"];
      this.columnProducer = this.Columns["Producer"];
      this.columnCompany = this.Columns["Company"];
      this.columnLine = this.Columns["Line"];
      this.columnViewClaims = this.Columns["ViewClaims"];
      this.columnNumberOfClaims = this.Columns["NumberOfClaims"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnControlNumber = new DataColumn("ControlNumber", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnControlNumber);
      this.columnPolicyNumber = new DataColumn("PolicyNumber", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPolicyNumber);
      this.columnInsured = new DataColumn("Insured", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnInsured);
      this.columnProducer = new DataColumn("Producer", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnProducer);
      this.columnCompany = new DataColumn("Company", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCompany);
      this.columnLine = new DataColumn("Line", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLine);
      this.columnViewClaims = new DataColumn("ViewClaims", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnViewClaims);
      this.columnNumberOfClaims = new DataColumn("NumberOfClaims", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnNumberOfClaims);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnControlNumber
      }, true));
      this.columnControlNumber.AllowDBNull = false;
      this.columnControlNumber.Unique = true;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsClaimsSearch.PolicyInformationRow NewPolicyInformationRow()
    {
      return (dsClaimsSearch.PolicyInformationRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsClaimsSearch.PolicyInformationRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (dsClaimsSearch.PolicyInformationRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      if (this.PolicyInformationRowChanged == null)
        return;
      this.PolicyInformationRowChanged((object) this, new dsClaimsSearch.PolicyInformationRowChangeEvent((dsClaimsSearch.PolicyInformationRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      if (this.PolicyInformationRowChanging == null)
        return;
      this.PolicyInformationRowChanging((object) this, new dsClaimsSearch.PolicyInformationRowChangeEvent((dsClaimsSearch.PolicyInformationRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      if (this.PolicyInformationRowDeleted == null)
        return;
      this.PolicyInformationRowDeleted((object) this, new dsClaimsSearch.PolicyInformationRowChangeEvent((dsClaimsSearch.PolicyInformationRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      if (this.PolicyInformationRowDeleting == null)
        return;
      this.PolicyInformationRowDeleting((object) this, new dsClaimsSearch.PolicyInformationRowChangeEvent((dsClaimsSearch.PolicyInformationRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemovePolicyInformationRow(dsClaimsSearch.PolicyInformationRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType typedTableSchema = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsClaimsSearch dsClaimsSearch = new dsClaimsSearch();
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
      typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "namespace",
        FixedValue = dsClaimsSearch.Namespace
      });
      typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (PolicyInformationDataTable)
      });
      typedTableSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsClaimsSearch.GetSchemaSerializable();
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
                return typedTableSchema;
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
      return typedTableSchema;
    }
  }

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class ClaimsInformationDataTable : TypedTableBase<dsClaimsSearch.ClaimsInformationRow>
  {
    private DataColumn columnControlNumber;
    private DataColumn columnClaimId;
    private DataColumn columnClaimNumber;
    private DataColumn columnLossDate;
    private DataColumn columnEnteredBy;
    private DataColumn columnDateEntered;
    private DataColumn columnClaimants;
    private DataColumn columnAdjuster;
    private DataColumn columnLocked;
    private DataColumn columnLockImage;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public ClaimsInformationDataTable()
    {
      this.TableName = "ClaimsInformation";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal ClaimsInformationDataTable(DataTable table)
    {
      this.TableName = table.TableName;
      if (table.CaseSensitive != table.DataSet.CaseSensitive)
        this.CaseSensitive = table.CaseSensitive;
      if (table.Locale.ToString() != table.DataSet.Locale.ToString())
        this.Locale = table.Locale;
      if (table.Namespace != table.DataSet.Namespace)
        this.Namespace = table.Namespace;
      this.Prefix = table.Prefix;
      this.MinimumCapacity = table.MinimumCapacity;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected ClaimsInformationDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ControlNumberColumn => this.columnControlNumber;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ClaimIdColumn => this.columnClaimId;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ClaimNumberColumn => this.columnClaimNumber;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn LossDateColumn => this.columnLossDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn EnteredByColumn => this.columnEnteredBy;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn DateEnteredColumn => this.columnDateEntered;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ClaimantsColumn => this.columnClaimants;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn AdjusterColumn => this.columnAdjuster;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn LockedColumn => this.columnLocked;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn LockImageColumn => this.columnLockImage;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsClaimsSearch.ClaimsInformationRow this[int index]
    {
      get => (dsClaimsSearch.ClaimsInformationRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsClaimsSearch.ClaimsInformationRowChangeEventHandler ClaimsInformationRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsClaimsSearch.ClaimsInformationRowChangeEventHandler ClaimsInformationRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsClaimsSearch.ClaimsInformationRowChangeEventHandler ClaimsInformationRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsClaimsSearch.ClaimsInformationRowChangeEventHandler ClaimsInformationRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddClaimsInformationRow(dsClaimsSearch.ClaimsInformationRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsClaimsSearch.ClaimsInformationRow AddClaimsInformationRow(
      dsClaimsSearch.PolicyInformationRow parentPolicyInformationRowByFK_PolicyInformation_ClaimsInformation,
      int ClaimId,
      string ClaimNumber,
      DateTime LossDate,
      string EnteredBy,
      DateTime DateEntered,
      int Claimants,
      string Adjuster,
      bool Locked,
      object LockImage)
    {
      dsClaimsSearch.ClaimsInformationRow row = (dsClaimsSearch.ClaimsInformationRow) this.NewRow();
      object[] objArray = new object[10]
      {
        null,
        (object) ClaimId,
        (object) ClaimNumber,
        (object) LossDate,
        (object) EnteredBy,
        (object) DateEntered,
        (object) Claimants,
        (object) Adjuster,
        (object) Locked,
        LockImage
      };
      if (parentPolicyInformationRowByFK_PolicyInformation_ClaimsInformation != null)
        objArray[0] = parentPolicyInformationRowByFK_PolicyInformation_ClaimsInformation[0];
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsClaimsSearch.ClaimsInformationRow FindByControlNumberClaimId(
      int ControlNumber,
      int ClaimId)
    {
      return (dsClaimsSearch.ClaimsInformationRow) this.Rows.Find(new object[2]
      {
        (object) ControlNumber,
        (object) ClaimId
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsClaimsSearch.ClaimsInformationDataTable informationDataTable = (dsClaimsSearch.ClaimsInformationDataTable) base.Clone();
      informationDataTable.InitVars();
      return (DataTable) informationDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsClaimsSearch.ClaimsInformationDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnControlNumber = this.Columns["ControlNumber"];
      this.columnClaimId = this.Columns["ClaimId"];
      this.columnClaimNumber = this.Columns["ClaimNumber"];
      this.columnLossDate = this.Columns["LossDate"];
      this.columnEnteredBy = this.Columns["EnteredBy"];
      this.columnDateEntered = this.Columns["DateEntered"];
      this.columnClaimants = this.Columns["Claimants"];
      this.columnAdjuster = this.Columns["Adjuster"];
      this.columnLocked = this.Columns["Locked"];
      this.columnLockImage = this.Columns["LockImage"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnControlNumber = new DataColumn("ControlNumber", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnControlNumber);
      this.columnClaimId = new DataColumn("ClaimId", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnClaimId);
      this.columnClaimNumber = new DataColumn("ClaimNumber", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnClaimNumber);
      this.columnLossDate = new DataColumn("LossDate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLossDate);
      this.columnEnteredBy = new DataColumn("EnteredBy", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEnteredBy);
      this.columnDateEntered = new DataColumn("DateEntered", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDateEntered);
      this.columnClaimants = new DataColumn("Claimants", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnClaimants);
      this.columnAdjuster = new DataColumn("Adjuster", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAdjuster);
      this.columnLocked = new DataColumn("Locked", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLocked);
      this.columnLockImage = new DataColumn("LockImage", typeof (object), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLockImage);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[2]
      {
        this.columnControlNumber,
        this.columnClaimId
      }, true));
      this.columnControlNumber.AllowDBNull = false;
      this.columnClaimId.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsClaimsSearch.ClaimsInformationRow NewClaimsInformationRow()
    {
      return (dsClaimsSearch.ClaimsInformationRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsClaimsSearch.ClaimsInformationRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (dsClaimsSearch.ClaimsInformationRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      if (this.ClaimsInformationRowChanged == null)
        return;
      this.ClaimsInformationRowChanged((object) this, new dsClaimsSearch.ClaimsInformationRowChangeEvent((dsClaimsSearch.ClaimsInformationRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      if (this.ClaimsInformationRowChanging == null)
        return;
      this.ClaimsInformationRowChanging((object) this, new dsClaimsSearch.ClaimsInformationRowChangeEvent((dsClaimsSearch.ClaimsInformationRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      if (this.ClaimsInformationRowDeleted == null)
        return;
      this.ClaimsInformationRowDeleted((object) this, new dsClaimsSearch.ClaimsInformationRowChangeEvent((dsClaimsSearch.ClaimsInformationRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      if (this.ClaimsInformationRowDeleting == null)
        return;
      this.ClaimsInformationRowDeleting((object) this, new dsClaimsSearch.ClaimsInformationRowChangeEvent((dsClaimsSearch.ClaimsInformationRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemoveClaimsInformationRow(dsClaimsSearch.ClaimsInformationRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType typedTableSchema = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsClaimsSearch dsClaimsSearch = new dsClaimsSearch();
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
      typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "namespace",
        FixedValue = dsClaimsSearch.Namespace
      });
      typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (ClaimsInformationDataTable)
      });
      typedTableSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsClaimsSearch.GetSchemaSerializable();
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
                return typedTableSchema;
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
      return typedTableSchema;
    }
  }

  public class PolicyInformationRow : DataRow
  {
    private dsClaimsSearch.PolicyInformationDataTable tablePolicyInformation;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal PolicyInformationRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablePolicyInformation = (dsClaimsSearch.PolicyInformationDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int ControlNumber
    {
      get => (int) this[this.tablePolicyInformation.ControlNumberColumn];
      set => this[this.tablePolicyInformation.ControlNumberColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string PolicyNumber
    {
      get
      {
        try
        {
          return (string) this[this.tablePolicyInformation.PolicyNumberColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'PolicyNumber' in table 'PolicyInformation' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePolicyInformation.PolicyNumberColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Insured
    {
      get
      {
        try
        {
          return (string) this[this.tablePolicyInformation.InsuredColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'Insured' in table 'PolicyInformation' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePolicyInformation.InsuredColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Producer
    {
      get
      {
        try
        {
          return (string) this[this.tablePolicyInformation.ProducerColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'Producer' in table 'PolicyInformation' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePolicyInformation.ProducerColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Company
    {
      get
      {
        try
        {
          return (string) this[this.tablePolicyInformation.CompanyColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'Company' in table 'PolicyInformation' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePolicyInformation.CompanyColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Line
    {
      get
      {
        try
        {
          return (string) this[this.tablePolicyInformation.LineColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'Line' in table 'PolicyInformation' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePolicyInformation.LineColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string ViewClaims
    {
      get
      {
        try
        {
          return (string) this[this.tablePolicyInformation.ViewClaimsColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'ViewClaims' in table 'PolicyInformation' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePolicyInformation.ViewClaimsColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int NumberOfClaims
    {
      get
      {
        try
        {
          return (int) this[this.tablePolicyInformation.NumberOfClaimsColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'NumberOfClaims' in table 'PolicyInformation' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablePolicyInformation.NumberOfClaimsColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsPolicyNumberNull() => this.IsNull(this.tablePolicyInformation.PolicyNumberColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetPolicyNumberNull()
    {
      this[this.tablePolicyInformation.PolicyNumberColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsInsuredNull() => this.IsNull(this.tablePolicyInformation.InsuredColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetInsuredNull()
    {
      this[this.tablePolicyInformation.InsuredColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsProducerNull() => this.IsNull(this.tablePolicyInformation.ProducerColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetProducerNull()
    {
      this[this.tablePolicyInformation.ProducerColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsCompanyNull() => this.IsNull(this.tablePolicyInformation.CompanyColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetCompanyNull()
    {
      this[this.tablePolicyInformation.CompanyColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsLineNull() => this.IsNull(this.tablePolicyInformation.LineColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetLineNull() => this[this.tablePolicyInformation.LineColumn] = Convert.DBNull;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsViewClaimsNull() => this.IsNull(this.tablePolicyInformation.ViewClaimsColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetViewClaimsNull()
    {
      this[this.tablePolicyInformation.ViewClaimsColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsNumberOfClaimsNull()
    {
      return this.IsNull(this.tablePolicyInformation.NumberOfClaimsColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetNumberOfClaimsNull()
    {
      this[this.tablePolicyInformation.NumberOfClaimsColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsClaimsSearch.ClaimsInformationRow[] GetClaimsInformationRows()
    {
      return this.Table.ChildRelations["FK_PolicyInformation_ClaimsInformation"] == null ? new dsClaimsSearch.ClaimsInformationRow[0] : (dsClaimsSearch.ClaimsInformationRow[]) this.GetChildRows(this.Table.ChildRelations["FK_PolicyInformation_ClaimsInformation"]);
    }
  }

  public class ClaimsInformationRow : DataRow
  {
    private dsClaimsSearch.ClaimsInformationDataTable tableClaimsInformation;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal ClaimsInformationRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableClaimsInformation = (dsClaimsSearch.ClaimsInformationDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int ControlNumber
    {
      get => (int) this[this.tableClaimsInformation.ControlNumberColumn];
      set => this[this.tableClaimsInformation.ControlNumberColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int ClaimId
    {
      get => (int) this[this.tableClaimsInformation.ClaimIdColumn];
      set => this[this.tableClaimsInformation.ClaimIdColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string ClaimNumber
    {
      get
      {
        try
        {
          return (string) this[this.tableClaimsInformation.ClaimNumberColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'ClaimNumber' in table 'ClaimsInformation' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableClaimsInformation.ClaimNumberColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DateTime LossDate
    {
      get
      {
        try
        {
          return (DateTime) this[this.tableClaimsInformation.LossDateColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'LossDate' in table 'ClaimsInformation' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableClaimsInformation.LossDateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string EnteredBy
    {
      get
      {
        try
        {
          return (string) this[this.tableClaimsInformation.EnteredByColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'EnteredBy' in table 'ClaimsInformation' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableClaimsInformation.EnteredByColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DateTime DateEntered
    {
      get
      {
        try
        {
          return (DateTime) this[this.tableClaimsInformation.DateEnteredColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'DateEntered' in table 'ClaimsInformation' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableClaimsInformation.DateEnteredColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int Claimants
    {
      get
      {
        try
        {
          return (int) this[this.tableClaimsInformation.ClaimantsColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'Claimants' in table 'ClaimsInformation' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableClaimsInformation.ClaimantsColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Adjuster
    {
      get
      {
        try
        {
          return (string) this[this.tableClaimsInformation.AdjusterColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'Adjuster' in table 'ClaimsInformation' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableClaimsInformation.AdjusterColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool Locked
    {
      get
      {
        try
        {
          return (bool) this[this.tableClaimsInformation.LockedColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'Locked' in table 'ClaimsInformation' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableClaimsInformation.LockedColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public object LockImage
    {
      get
      {
        try
        {
          return this[this.tableClaimsInformation.LockImageColumn];
        }
        catch (InvalidCastException ex)
        {
          throw new StrongTypingException("The value for column 'LockImage' in table 'ClaimsInformation' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableClaimsInformation.LockImageColumn] = value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsClaimsSearch.PolicyInformationRow PolicyInformationRow
    {
      get
      {
        return (dsClaimsSearch.PolicyInformationRow) this.GetParentRow(this.Table.ParentRelations["FK_PolicyInformation_ClaimsInformation"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["FK_PolicyInformation_ClaimsInformation"]);
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsClaimNumberNull() => this.IsNull(this.tableClaimsInformation.ClaimNumberColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetClaimNumberNull()
    {
      this[this.tableClaimsInformation.ClaimNumberColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsLossDateNull() => this.IsNull(this.tableClaimsInformation.LossDateColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetLossDateNull()
    {
      this[this.tableClaimsInformation.LossDateColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsEnteredByNull() => this.IsNull(this.tableClaimsInformation.EnteredByColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetEnteredByNull()
    {
      this[this.tableClaimsInformation.EnteredByColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsDateEnteredNull() => this.IsNull(this.tableClaimsInformation.DateEnteredColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetDateEnteredNull()
    {
      this[this.tableClaimsInformation.DateEnteredColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsClaimantsNull() => this.IsNull(this.tableClaimsInformation.ClaimantsColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetClaimantsNull()
    {
      this[this.tableClaimsInformation.ClaimantsColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsAdjusterNull() => this.IsNull(this.tableClaimsInformation.AdjusterColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetAdjusterNull()
    {
      this[this.tableClaimsInformation.AdjusterColumn] = Convert.DBNull;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsLockedNull() => this.IsNull(this.tableClaimsInformation.LockedColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetLockedNull() => this[this.tableClaimsInformation.LockedColumn] = Convert.DBNull;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsLockImageNull() => this.IsNull(this.tableClaimsInformation.LockImageColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetLockImageNull()
    {
      this[this.tableClaimsInformation.LockImageColumn] = Convert.DBNull;
    }
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class PolicyInformationRowChangeEvent : EventArgs
  {
    private dsClaimsSearch.PolicyInformationRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public PolicyInformationRowChangeEvent(
      dsClaimsSearch.PolicyInformationRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsClaimsSearch.PolicyInformationRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class ClaimsInformationRowChangeEvent : EventArgs
  {
    private dsClaimsSearch.ClaimsInformationRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public ClaimsInformationRowChangeEvent(
      dsClaimsSearch.ClaimsInformationRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsClaimsSearch.ClaimsInformationRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }
}
