// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Rating.dsGenericMultiRater
// Assembly: MgaSystems.IMS.Rating, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 370B8F0A-FA1A-41D0-87BD-563CC23E9EA7
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Rating.dll

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
namespace MGASystems.IMS.Policies.Rating;

[DesignerCategory("code")]
[ToolboxItem(true)]
[XmlSchemaProvider("GetTypedDataSetSchema")]
[XmlRoot("dsGenericMultiRater")]
[HelpKeyword("vs.data.DataSet")]
[Serializable]
public class dsGenericMultiRater : DataSet
{
  private dsGenericMultiRater.dtPropertyInfoDataTable tabledtPropertyInfo;
  private dsGenericMultiRater.tblCarrierPremiumDataTable tabletblCarrierPremium;
  private dsGenericMultiRater.tblGenericLimitsDataTable tabletblGenericLimits;
  private dsGenericMultiRater.tblMultiCarrierRaterDataDataTable tabletblMultiCarrierRaterData;
  private SchemaSerializationMode _schemaSerializationMode;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public dsGenericMultiRater()
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
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  protected dsGenericMultiRater(SerializationInfo info, StreamingContext context)
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
        if (dataSet.Tables[nameof (dtPropertyInfo)] != null)
          base.Tables.Add((DataTable) new dsGenericMultiRater.dtPropertyInfoDataTable(dataSet.Tables[nameof (dtPropertyInfo)]));
        if (dataSet.Tables[nameof (tblCarrierPremium)] != null)
          base.Tables.Add((DataTable) new dsGenericMultiRater.tblCarrierPremiumDataTable(dataSet.Tables[nameof (tblCarrierPremium)]));
        if (dataSet.Tables[nameof (tblGenericLimits)] != null)
          base.Tables.Add((DataTable) new dsGenericMultiRater.tblGenericLimitsDataTable(dataSet.Tables[nameof (tblGenericLimits)]));
        if (dataSet.Tables[nameof (tblMultiCarrierRaterData)] != null)
          base.Tables.Add((DataTable) new dsGenericMultiRater.tblMultiCarrierRaterDataDataTable(dataSet.Tables[nameof (tblMultiCarrierRaterData)]));
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
  public dsGenericMultiRater.dtPropertyInfoDataTable dtPropertyInfo => this.tabledtPropertyInfo;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsGenericMultiRater.tblCarrierPremiumDataTable tblCarrierPremium
  {
    get => this.tabletblCarrierPremium;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsGenericMultiRater.tblGenericLimitsDataTable tblGenericLimits
  {
    get => this.tabletblGenericLimits;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsGenericMultiRater.tblMultiCarrierRaterDataDataTable tblMultiCarrierRaterData
  {
    get => this.tabletblMultiCarrierRaterData;
  }

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
    dsGenericMultiRater genericMultiRater = (dsGenericMultiRater) base.Clone();
    genericMultiRater.InitVars();
    genericMultiRater.SchemaSerializationMode = this.SchemaSerializationMode;
    return (DataSet) genericMultiRater;
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
      if (dataSet.Tables["dtPropertyInfo"] != null)
        base.Tables.Add((DataTable) new dsGenericMultiRater.dtPropertyInfoDataTable(dataSet.Tables["dtPropertyInfo"]));
      if (dataSet.Tables["tblCarrierPremium"] != null)
        base.Tables.Add((DataTable) new dsGenericMultiRater.tblCarrierPremiumDataTable(dataSet.Tables["tblCarrierPremium"]));
      if (dataSet.Tables["tblGenericLimits"] != null)
        base.Tables.Add((DataTable) new dsGenericMultiRater.tblGenericLimitsDataTable(dataSet.Tables["tblGenericLimits"]));
      if (dataSet.Tables["tblMultiCarrierRaterData"] != null)
        base.Tables.Add((DataTable) new dsGenericMultiRater.tblMultiCarrierRaterDataDataTable(dataSet.Tables["tblMultiCarrierRaterData"]));
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
    this.tabledtPropertyInfo = (dsGenericMultiRater.dtPropertyInfoDataTable) base.Tables["dtPropertyInfo"];
    if (initTable && this.tabledtPropertyInfo != null)
      this.tabledtPropertyInfo.InitVars();
    this.tabletblCarrierPremium = (dsGenericMultiRater.tblCarrierPremiumDataTable) base.Tables["tblCarrierPremium"];
    if (initTable && this.tabletblCarrierPremium != null)
      this.tabletblCarrierPremium.InitVars();
    this.tabletblGenericLimits = (dsGenericMultiRater.tblGenericLimitsDataTable) base.Tables["tblGenericLimits"];
    if (initTable && this.tabletblGenericLimits != null)
      this.tabletblGenericLimits.InitVars();
    this.tabletblMultiCarrierRaterData = (dsGenericMultiRater.tblMultiCarrierRaterDataDataTable) base.Tables["tblMultiCarrierRaterData"];
    if (!initTable || this.tabletblMultiCarrierRaterData == null)
      return;
    this.tabletblMultiCarrierRaterData.InitVars();
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private void InitClass()
  {
    this.DataSetName = nameof (dsGenericMultiRater);
    this.Prefix = "";
    this.Namespace = "http://tempuri.org/dsGenericMultiRater.xsd";
    this.EnforceConstraints = true;
    this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.tabledtPropertyInfo = new dsGenericMultiRater.dtPropertyInfoDataTable();
    base.Tables.Add((DataTable) this.tabledtPropertyInfo);
    this.tabletblCarrierPremium = new dsGenericMultiRater.tblCarrierPremiumDataTable();
    base.Tables.Add((DataTable) this.tabletblCarrierPremium);
    this.tabletblGenericLimits = new dsGenericMultiRater.tblGenericLimitsDataTable();
    base.Tables.Add((DataTable) this.tabletblGenericLimits);
    this.tabletblMultiCarrierRaterData = new dsGenericMultiRater.tblMultiCarrierRaterDataDataTable();
    base.Tables.Add((DataTable) this.tabletblMultiCarrierRaterData);
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializedtPropertyInfo() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializetblCarrierPremium() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializetblGenericLimits() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializetblMultiCarrierRaterData() => false;

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
    dsGenericMultiRater genericMultiRater = new dsGenericMultiRater();
    XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
    schemaComplexType.Particle = (XmlSchemaParticle) new XmlSchemaSequence()
    {
      Items = {
        (XmlSchemaObject) new XmlSchemaAny()
        {
          Namespace = genericMultiRater.Namespace
        }
      }
    };
    XmlSchema schemaSerializable = genericMultiRater.GetSchemaSerializable();
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

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void dtPropertyInfoRowChangeEventHandler(
    object sender,
    dsGenericMultiRater.dtPropertyInfoRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void tblCarrierPremiumRowChangeEventHandler(
    object sender,
    dsGenericMultiRater.tblCarrierPremiumRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void tblGenericLimitsRowChangeEventHandler(
    object sender,
    dsGenericMultiRater.tblGenericLimitsRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void tblMultiCarrierRaterDataRowChangeEventHandler(
    object sender,
    dsGenericMultiRater.tblMultiCarrierRaterDataRowChangeEvent e);

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class dtPropertyInfoDataTable : TypedTableBase<dsGenericMultiRater.dtPropertyInfoRow>
  {
    private DataColumn columnCarrier;
    private DataColumn columnPremium;
    private DataColumn columnTRIAPremium;
    private DataColumn columnCompanyLocationGuid;
    private DataColumn columnFeeAmount;
    private DataColumn columnLimit;
    private DataColumn columnParticipation;
    private DataColumn columnAddFees;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dtPropertyInfoDataTable()
    {
      this.ColumnChanging += new DataColumnChangeEventHandler(this.dtPropertyInfoDataTable_ColumnChanging);
      this.TableName = "dtPropertyInfo";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal dtPropertyInfoDataTable(DataTable table)
    {
      this.ColumnChanging += new DataColumnChangeEventHandler(this.dtPropertyInfoDataTable_ColumnChanging);
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected dtPropertyInfoDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.ColumnChanging += new DataColumnChangeEventHandler(this.dtPropertyInfoDataTable_ColumnChanging);
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn CarrierColumn => this.columnCarrier;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn PremiumColumn => this.columnPremium;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn TRIAPremiumColumn => this.columnTRIAPremium;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn CompanyLocationGuidColumn => this.columnCompanyLocationGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn FeeAmountColumn => this.columnFeeAmount;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn LimitColumn => this.columnLimit;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ParticipationColumn => this.columnParticipation;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn AddFeesColumn => this.columnAddFees;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsGenericMultiRater.dtPropertyInfoRow this[int index]
    {
      get => (dsGenericMultiRater.dtPropertyInfoRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsGenericMultiRater.dtPropertyInfoRowChangeEventHandler dtPropertyInfoRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsGenericMultiRater.dtPropertyInfoRowChangeEventHandler dtPropertyInfoRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsGenericMultiRater.dtPropertyInfoRowChangeEventHandler dtPropertyInfoRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsGenericMultiRater.dtPropertyInfoRowChangeEventHandler dtPropertyInfoRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AdddtPropertyInfoRow(dsGenericMultiRater.dtPropertyInfoRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsGenericMultiRater.dtPropertyInfoRow AdddtPropertyInfoRow(
      string Carrier,
      Decimal Premium,
      Decimal TRIAPremium,
      Guid CompanyLocationGuid,
      Decimal FeeAmount,
      Decimal Limit,
      Decimal Participation,
      string AddFees)
    {
      dsGenericMultiRater.dtPropertyInfoRow row = (dsGenericMultiRater.dtPropertyInfoRow) this.NewRow();
      object[] objArray = new object[8]
      {
        (object) Carrier,
        (object) Premium,
        (object) TRIAPremium,
        (object) CompanyLocationGuid,
        (object) FeeAmount,
        (object) Limit,
        (object) Participation,
        (object) AddFees
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsGenericMultiRater.dtPropertyInfoRow FindByCompanyLocationGuid(Guid CompanyLocationGuid)
    {
      return (dsGenericMultiRater.dtPropertyInfoRow) this.Rows.Find(new object[1]
      {
        (object) CompanyLocationGuid
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsGenericMultiRater.dtPropertyInfoDataTable propertyInfoDataTable = (dsGenericMultiRater.dtPropertyInfoDataTable) base.Clone();
      propertyInfoDataTable.InitVars();
      return (DataTable) propertyInfoDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsGenericMultiRater.dtPropertyInfoDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnCarrier = this.Columns["Carrier"];
      this.columnPremium = this.Columns["Premium"];
      this.columnTRIAPremium = this.Columns["TRIAPremium"];
      this.columnCompanyLocationGuid = this.Columns["CompanyLocationGuid"];
      this.columnFeeAmount = this.Columns["FeeAmount"];
      this.columnLimit = this.Columns["Limit"];
      this.columnParticipation = this.Columns["Participation"];
      this.columnAddFees = this.Columns["AddFees"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnCarrier = new DataColumn("Carrier", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCarrier);
      this.columnPremium = new DataColumn("Premium", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPremium);
      this.columnTRIAPremium = new DataColumn("TRIAPremium", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnTRIAPremium);
      this.columnCompanyLocationGuid = new DataColumn("CompanyLocationGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCompanyLocationGuid);
      this.columnFeeAmount = new DataColumn("FeeAmount", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFeeAmount);
      this.columnLimit = new DataColumn("Limit", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLimit);
      this.columnParticipation = new DataColumn("Participation", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnParticipation);
      this.columnAddFees = new DataColumn("AddFees", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAddFees);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnCompanyLocationGuid
      }, true));
      this.columnPremium.DefaultValue = (object) 0M;
      this.columnTRIAPremium.DefaultValue = (object) 0M;
      this.columnCompanyLocationGuid.AllowDBNull = false;
      this.columnCompanyLocationGuid.Unique = true;
      this.columnFeeAmount.DefaultValue = (object) 0M;
      this.columnAddFees.DefaultValue = (object) "Add Fees";
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsGenericMultiRater.dtPropertyInfoRow NewdtPropertyInfoRow()
    {
      return (dsGenericMultiRater.dtPropertyInfoRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsGenericMultiRater.dtPropertyInfoRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (dsGenericMultiRater.dtPropertyInfoRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.dtPropertyInfoRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsGenericMultiRater.dtPropertyInfoRowChangeEventHandler infoRowChangedEvent = this.dtPropertyInfoRowChangedEvent;
      if (infoRowChangedEvent == null)
        return;
      infoRowChangedEvent((object) this, new dsGenericMultiRater.dtPropertyInfoRowChangeEvent((dsGenericMultiRater.dtPropertyInfoRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.dtPropertyInfoRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsGenericMultiRater.dtPropertyInfoRowChangeEventHandler rowChangingEvent = this.dtPropertyInfoRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsGenericMultiRater.dtPropertyInfoRowChangeEvent((dsGenericMultiRater.dtPropertyInfoRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.dtPropertyInfoRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsGenericMultiRater.dtPropertyInfoRowChangeEventHandler infoRowDeletedEvent = this.dtPropertyInfoRowDeletedEvent;
      if (infoRowDeletedEvent == null)
        return;
      infoRowDeletedEvent((object) this, new dsGenericMultiRater.dtPropertyInfoRowChangeEvent((dsGenericMultiRater.dtPropertyInfoRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.dtPropertyInfoRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsGenericMultiRater.dtPropertyInfoRowChangeEventHandler rowDeletingEvent = this.dtPropertyInfoRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsGenericMultiRater.dtPropertyInfoRowChangeEvent((dsGenericMultiRater.dtPropertyInfoRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemovedtPropertyInfoRow(dsGenericMultiRater.dtPropertyInfoRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsGenericMultiRater genericMultiRater = new dsGenericMultiRater();
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
        FixedValue = genericMultiRater.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (dtPropertyInfoDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = genericMultiRater.GetSchemaSerializable();
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

    private void dtPropertyInfoDataTable_ColumnChanging(object sender, DataColumnChangeEventArgs e)
    {
      Microsoft.VisualBasic.CompilerServices.Operators.CompareString(e.Column.ColumnName, this.AddFeesColumn.ColumnName, false);
    }
  }

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class tblCarrierPremiumDataTable : TypedTableBase<dsGenericMultiRater.tblCarrierPremiumRow>
  {
    private DataColumn columnID;
    private DataColumn columnQuoteID;
    private DataColumn columnCompanyLocationGuid;
    private DataColumn columnPremium;
    private DataColumn columnTRIAPremium;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblCarrierPremiumDataTable()
    {
      this.tblCarrierPremiumRowChanging += new dsGenericMultiRater.tblCarrierPremiumRowChangeEventHandler(this.tblCarrierPremiumDataTable_tblCarrierPremiumRowChanging);
      this.TableName = "tblCarrierPremium";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblCarrierPremiumDataTable(DataTable table)
    {
      this.tblCarrierPremiumRowChanging += new dsGenericMultiRater.tblCarrierPremiumRowChangeEventHandler(this.tblCarrierPremiumDataTable_tblCarrierPremiumRowChanging);
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected tblCarrierPremiumDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.tblCarrierPremiumRowChanging += new dsGenericMultiRater.tblCarrierPremiumRowChangeEventHandler(this.tblCarrierPremiumDataTable_tblCarrierPremiumRowChanging);
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn IDColumn => this.columnID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn QuoteIDColumn => this.columnQuoteID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn CompanyLocationGuidColumn => this.columnCompanyLocationGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn PremiumColumn => this.columnPremium;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn TRIAPremiumColumn => this.columnTRIAPremium;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsGenericMultiRater.tblCarrierPremiumRow this[int index]
    {
      get => (dsGenericMultiRater.tblCarrierPremiumRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsGenericMultiRater.tblCarrierPremiumRowChangeEventHandler tblCarrierPremiumRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsGenericMultiRater.tblCarrierPremiumRowChangeEventHandler tblCarrierPremiumRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsGenericMultiRater.tblCarrierPremiumRowChangeEventHandler tblCarrierPremiumRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsGenericMultiRater.tblCarrierPremiumRowChangeEventHandler tblCarrierPremiumRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddtblCarrierPremiumRow(dsGenericMultiRater.tblCarrierPremiumRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsGenericMultiRater.tblCarrierPremiumRow AddtblCarrierPremiumRow(
      int QuoteID,
      Guid CompanyLocationGuid,
      Decimal Premium,
      Decimal TRIAPremium)
    {
      dsGenericMultiRater.tblCarrierPremiumRow row = (dsGenericMultiRater.tblCarrierPremiumRow) this.NewRow();
      object[] objArray = new object[5]
      {
        null,
        (object) QuoteID,
        (object) CompanyLocationGuid,
        (object) Premium,
        (object) TRIAPremium
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsGenericMultiRater.tblCarrierPremiumRow FindByID(int ID)
    {
      return (dsGenericMultiRater.tblCarrierPremiumRow) this.Rows.Find(new object[1]
      {
        (object) ID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsGenericMultiRater.tblCarrierPremiumDataTable premiumDataTable = (dsGenericMultiRater.tblCarrierPremiumDataTable) base.Clone();
      premiumDataTable.InitVars();
      return (DataTable) premiumDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsGenericMultiRater.tblCarrierPremiumDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnID = this.Columns["ID"];
      this.columnQuoteID = this.Columns["QuoteID"];
      this.columnCompanyLocationGuid = this.Columns["CompanyLocationGuid"];
      this.columnPremium = this.Columns["Premium"];
      this.columnTRIAPremium = this.Columns["TRIAPremium"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnID = new DataColumn("ID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnID);
      this.columnQuoteID = new DataColumn("QuoteID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnQuoteID);
      this.columnCompanyLocationGuid = new DataColumn("CompanyLocationGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCompanyLocationGuid);
      this.columnPremium = new DataColumn("Premium", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPremium);
      this.columnTRIAPremium = new DataColumn("TRIAPremium", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnTRIAPremium);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnID
      }, true));
      this.columnID.AutoIncrement = true;
      this.columnID.AutoIncrementSeed = -1L;
      this.columnID.AutoIncrementStep = -1L;
      this.columnID.AllowDBNull = false;
      this.columnID.ReadOnly = true;
      this.columnID.Unique = true;
      this.columnQuoteID.AllowDBNull = false;
      this.columnCompanyLocationGuid.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsGenericMultiRater.tblCarrierPremiumRow NewtblCarrierPremiumRow()
    {
      return (dsGenericMultiRater.tblCarrierPremiumRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsGenericMultiRater.tblCarrierPremiumRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (dsGenericMultiRater.tblCarrierPremiumRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCarrierPremiumRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsGenericMultiRater.tblCarrierPremiumRowChangeEventHandler premiumRowChangedEvent = this.tblCarrierPremiumRowChangedEvent;
      if (premiumRowChangedEvent == null)
        return;
      premiumRowChangedEvent((object) this, new dsGenericMultiRater.tblCarrierPremiumRowChangeEvent((dsGenericMultiRater.tblCarrierPremiumRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCarrierPremiumRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsGenericMultiRater.tblCarrierPremiumRowChangeEventHandler rowChangingEvent = this.tblCarrierPremiumRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsGenericMultiRater.tblCarrierPremiumRowChangeEvent((dsGenericMultiRater.tblCarrierPremiumRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCarrierPremiumRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsGenericMultiRater.tblCarrierPremiumRowChangeEventHandler premiumRowDeletedEvent = this.tblCarrierPremiumRowDeletedEvent;
      if (premiumRowDeletedEvent == null)
        return;
      premiumRowDeletedEvent((object) this, new dsGenericMultiRater.tblCarrierPremiumRowChangeEvent((dsGenericMultiRater.tblCarrierPremiumRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblCarrierPremiumRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsGenericMultiRater.tblCarrierPremiumRowChangeEventHandler rowDeletingEvent = this.tblCarrierPremiumRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsGenericMultiRater.tblCarrierPremiumRowChangeEvent((dsGenericMultiRater.tblCarrierPremiumRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemovetblCarrierPremiumRow(dsGenericMultiRater.tblCarrierPremiumRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsGenericMultiRater genericMultiRater = new dsGenericMultiRater();
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
        FixedValue = genericMultiRater.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblCarrierPremiumDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = genericMultiRater.GetSchemaSerializable();
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

    private void tblCarrierPremiumDataTable_tblCarrierPremiumRowChanging(
      object sender,
      dsGenericMultiRater.tblCarrierPremiumRowChangeEvent e)
    {
    }
  }

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class tblGenericLimitsDataTable : TypedTableBase<dsGenericMultiRater.tblGenericLimitsRow>
  {
    private DataColumn columnQuoteID;
    private DataColumn columnLimit;
    private DataColumn columnSubLimits;
    private DataColumn columnPerils;
    private DataColumn columnCovering;
    private DataColumn columnDeductible;
    private DataColumn columnValuation;
    private DataColumn columnExcluding;
    private DataColumn columnAdditionalComments;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblGenericLimitsDataTable()
    {
      this.TableName = "tblGenericLimits";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblGenericLimitsDataTable(DataTable table)
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected tblGenericLimitsDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn QuoteIDColumn => this.columnQuoteID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn LimitColumn => this.columnLimit;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn SubLimitsColumn => this.columnSubLimits;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn PerilsColumn => this.columnPerils;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn CoveringColumn => this.columnCovering;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn DeductibleColumn => this.columnDeductible;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ValuationColumn => this.columnValuation;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ExcludingColumn => this.columnExcluding;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn AdditionalCommentsColumn => this.columnAdditionalComments;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsGenericMultiRater.tblGenericLimitsRow this[int index]
    {
      get => (dsGenericMultiRater.tblGenericLimitsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsGenericMultiRater.tblGenericLimitsRowChangeEventHandler tblGenericLimitsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsGenericMultiRater.tblGenericLimitsRowChangeEventHandler tblGenericLimitsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsGenericMultiRater.tblGenericLimitsRowChangeEventHandler tblGenericLimitsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsGenericMultiRater.tblGenericLimitsRowChangeEventHandler tblGenericLimitsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddtblGenericLimitsRow(dsGenericMultiRater.tblGenericLimitsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsGenericMultiRater.tblGenericLimitsRow AddtblGenericLimitsRow(
      int QuoteID,
      string Limit,
      string SubLimits,
      string Perils,
      string Covering,
      string Deductible,
      string Valuation,
      string Excluding,
      string AdditionalComments)
    {
      dsGenericMultiRater.tblGenericLimitsRow row = (dsGenericMultiRater.tblGenericLimitsRow) this.NewRow();
      object[] objArray = new object[9]
      {
        (object) QuoteID,
        (object) Limit,
        (object) SubLimits,
        (object) Perils,
        (object) Covering,
        (object) Deductible,
        (object) Valuation,
        (object) Excluding,
        (object) AdditionalComments
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsGenericMultiRater.tblGenericLimitsRow FindByQuoteID(int QuoteID)
    {
      return (dsGenericMultiRater.tblGenericLimitsRow) this.Rows.Find(new object[1]
      {
        (object) QuoteID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsGenericMultiRater.tblGenericLimitsDataTable genericLimitsDataTable = (dsGenericMultiRater.tblGenericLimitsDataTable) base.Clone();
      genericLimitsDataTable.InitVars();
      return (DataTable) genericLimitsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsGenericMultiRater.tblGenericLimitsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnQuoteID = this.Columns["QuoteID"];
      this.columnLimit = this.Columns["Limit"];
      this.columnSubLimits = this.Columns["SubLimits"];
      this.columnPerils = this.Columns["Perils"];
      this.columnCovering = this.Columns["Covering"];
      this.columnDeductible = this.Columns["Deductible"];
      this.columnValuation = this.Columns["Valuation"];
      this.columnExcluding = this.Columns["Excluding"];
      this.columnAdditionalComments = this.Columns["AdditionalComments"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnQuoteID = new DataColumn("QuoteID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnQuoteID);
      this.columnLimit = new DataColumn("Limit", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLimit);
      this.columnSubLimits = new DataColumn("SubLimits", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSubLimits);
      this.columnPerils = new DataColumn("Perils", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPerils);
      this.columnCovering = new DataColumn("Covering", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCovering);
      this.columnDeductible = new DataColumn("Deductible", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDeductible);
      this.columnValuation = new DataColumn("Valuation", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnValuation);
      this.columnExcluding = new DataColumn("Excluding", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnExcluding);
      this.columnAdditionalComments = new DataColumn("AdditionalComments", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAdditionalComments);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsRaterGenericKey6", new DataColumn[1]
      {
        this.columnQuoteID
      }, true));
      this.columnQuoteID.AllowDBNull = false;
      this.columnQuoteID.Unique = true;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsGenericMultiRater.tblGenericLimitsRow NewtblGenericLimitsRow()
    {
      return (dsGenericMultiRater.tblGenericLimitsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsGenericMultiRater.tblGenericLimitsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (dsGenericMultiRater.tblGenericLimitsRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblGenericLimitsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsGenericMultiRater.tblGenericLimitsRowChangeEventHandler limitsRowChangedEvent = this.tblGenericLimitsRowChangedEvent;
      if (limitsRowChangedEvent == null)
        return;
      limitsRowChangedEvent((object) this, new dsGenericMultiRater.tblGenericLimitsRowChangeEvent((dsGenericMultiRater.tblGenericLimitsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblGenericLimitsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsGenericMultiRater.tblGenericLimitsRowChangeEventHandler rowChangingEvent = this.tblGenericLimitsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsGenericMultiRater.tblGenericLimitsRowChangeEvent((dsGenericMultiRater.tblGenericLimitsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblGenericLimitsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsGenericMultiRater.tblGenericLimitsRowChangeEventHandler limitsRowDeletedEvent = this.tblGenericLimitsRowDeletedEvent;
      if (limitsRowDeletedEvent == null)
        return;
      limitsRowDeletedEvent((object) this, new dsGenericMultiRater.tblGenericLimitsRowChangeEvent((dsGenericMultiRater.tblGenericLimitsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblGenericLimitsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsGenericMultiRater.tblGenericLimitsRowChangeEventHandler rowDeletingEvent = this.tblGenericLimitsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsGenericMultiRater.tblGenericLimitsRowChangeEvent((dsGenericMultiRater.tblGenericLimitsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemovetblGenericLimitsRow(dsGenericMultiRater.tblGenericLimitsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsGenericMultiRater genericMultiRater = new dsGenericMultiRater();
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
        FixedValue = genericMultiRater.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblGenericLimitsDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = genericMultiRater.GetSchemaSerializable();
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
  public class tblMultiCarrierRaterDataDataTable : 
    TypedTableBase<dsGenericMultiRater.tblMultiCarrierRaterDataRow>
  {
    private DataColumn columnQuoteID;
    private DataColumn columnLimit;
    private DataColumn columnParticipation;
    private DataColumn columnCompanyLocationGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblMultiCarrierRaterDataDataTable()
    {
      this.TableName = "tblMultiCarrierRaterData";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblMultiCarrierRaterDataDataTable(DataTable table)
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected tblMultiCarrierRaterDataDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn QuoteIDColumn => this.columnQuoteID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn LimitColumn => this.columnLimit;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ParticipationColumn => this.columnParticipation;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn CompanyLocationGuidColumn => this.columnCompanyLocationGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsGenericMultiRater.tblMultiCarrierRaterDataRow this[int index]
    {
      get => (dsGenericMultiRater.tblMultiCarrierRaterDataRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsGenericMultiRater.tblMultiCarrierRaterDataRowChangeEventHandler tblMultiCarrierRaterDataRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsGenericMultiRater.tblMultiCarrierRaterDataRowChangeEventHandler tblMultiCarrierRaterDataRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsGenericMultiRater.tblMultiCarrierRaterDataRowChangeEventHandler tblMultiCarrierRaterDataRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsGenericMultiRater.tblMultiCarrierRaterDataRowChangeEventHandler tblMultiCarrierRaterDataRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddtblMultiCarrierRaterDataRow(
      dsGenericMultiRater.tblMultiCarrierRaterDataRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsGenericMultiRater.tblMultiCarrierRaterDataRow AddtblMultiCarrierRaterDataRow(
      int QuoteID,
      Decimal Limit,
      Decimal Participation,
      Guid CompanyLocationGuid)
    {
      dsGenericMultiRater.tblMultiCarrierRaterDataRow row = (dsGenericMultiRater.tblMultiCarrierRaterDataRow) this.NewRow();
      object[] objArray = new object[4]
      {
        (object) QuoteID,
        (object) Limit,
        (object) Participation,
        (object) CompanyLocationGuid
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsGenericMultiRater.tblMultiCarrierRaterDataRow FindByCompanyLocationGuidQuoteID(
      Guid CompanyLocationGuid,
      int QuoteID)
    {
      return (dsGenericMultiRater.tblMultiCarrierRaterDataRow) this.Rows.Find(new object[2]
      {
        (object) CompanyLocationGuid,
        (object) QuoteID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsGenericMultiRater.tblMultiCarrierRaterDataDataTable raterDataDataTable = (dsGenericMultiRater.tblMultiCarrierRaterDataDataTable) base.Clone();
      raterDataDataTable.InitVars();
      return (DataTable) raterDataDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsGenericMultiRater.tblMultiCarrierRaterDataDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnQuoteID = this.Columns["QuoteID"];
      this.columnLimit = this.Columns["Limit"];
      this.columnParticipation = this.Columns["Participation"];
      this.columnCompanyLocationGuid = this.Columns["CompanyLocationGuid"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnQuoteID = new DataColumn("QuoteID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnQuoteID);
      this.columnLimit = new DataColumn("Limit", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLimit);
      this.columnParticipation = new DataColumn("Participation", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnParticipation);
      this.columnCompanyLocationGuid = new DataColumn("CompanyLocationGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCompanyLocationGuid);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[2]
      {
        this.columnCompanyLocationGuid,
        this.columnQuoteID
      }, true));
      this.columnQuoteID.AllowDBNull = false;
      this.columnCompanyLocationGuid.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsGenericMultiRater.tblMultiCarrierRaterDataRow NewtblMultiCarrierRaterDataRow()
    {
      return (dsGenericMultiRater.tblMultiCarrierRaterDataRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsGenericMultiRater.tblMultiCarrierRaterDataRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType()
    {
      return typeof (dsGenericMultiRater.tblMultiCarrierRaterDataRow);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblMultiCarrierRaterDataRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsGenericMultiRater.tblMultiCarrierRaterDataRowChangeEventHandler dataRowChangedEvent = this.tblMultiCarrierRaterDataRowChangedEvent;
      if (dataRowChangedEvent == null)
        return;
      dataRowChangedEvent((object) this, new dsGenericMultiRater.tblMultiCarrierRaterDataRowChangeEvent((dsGenericMultiRater.tblMultiCarrierRaterDataRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblMultiCarrierRaterDataRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsGenericMultiRater.tblMultiCarrierRaterDataRowChangeEventHandler rowChangingEvent = this.tblMultiCarrierRaterDataRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsGenericMultiRater.tblMultiCarrierRaterDataRowChangeEvent((dsGenericMultiRater.tblMultiCarrierRaterDataRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblMultiCarrierRaterDataRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsGenericMultiRater.tblMultiCarrierRaterDataRowChangeEventHandler dataRowDeletedEvent = this.tblMultiCarrierRaterDataRowDeletedEvent;
      if (dataRowDeletedEvent == null)
        return;
      dataRowDeletedEvent((object) this, new dsGenericMultiRater.tblMultiCarrierRaterDataRowChangeEvent((dsGenericMultiRater.tblMultiCarrierRaterDataRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblMultiCarrierRaterDataRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsGenericMultiRater.tblMultiCarrierRaterDataRowChangeEventHandler rowDeletingEvent = this.tblMultiCarrierRaterDataRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsGenericMultiRater.tblMultiCarrierRaterDataRowChangeEvent((dsGenericMultiRater.tblMultiCarrierRaterDataRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemovetblMultiCarrierRaterDataRow(
      dsGenericMultiRater.tblMultiCarrierRaterDataRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsGenericMultiRater genericMultiRater = new dsGenericMultiRater();
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
        FixedValue = genericMultiRater.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblMultiCarrierRaterDataDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = genericMultiRater.GetSchemaSerializable();
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

  public class dtPropertyInfoRow : DataRow
  {
    private dsGenericMultiRater.dtPropertyInfoDataTable tabledtPropertyInfo;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal dtPropertyInfoRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabledtPropertyInfo = (dsGenericMultiRater.dtPropertyInfoDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Carrier
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtPropertyInfo.CarrierColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Carrier' in table 'dtPropertyInfo' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtPropertyInfo.CarrierColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal Premium
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tabledtPropertyInfo.PremiumColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Premium' in table 'dtPropertyInfo' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtPropertyInfo.PremiumColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal TRIAPremium
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tabledtPropertyInfo.TRIAPremiumColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'TRIAPremium' in table 'dtPropertyInfo' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtPropertyInfo.TRIAPremiumColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Guid CompanyLocationGuid
    {
      get
      {
        object obj = this[this.tabledtPropertyInfo.CompanyLocationGuidColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tabledtPropertyInfo.CompanyLocationGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal FeeAmount
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tabledtPropertyInfo.FeeAmountColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'FeeAmount' in table 'dtPropertyInfo' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtPropertyInfo.FeeAmountColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal Limit
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tabledtPropertyInfo.LimitColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Limit' in table 'dtPropertyInfo' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtPropertyInfo.LimitColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal Participation
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tabledtPropertyInfo.ParticipationColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Participation' in table 'dtPropertyInfo' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtPropertyInfo.ParticipationColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string AddFees
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabledtPropertyInfo.AddFeesColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'AddFees' in table 'dtPropertyInfo' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabledtPropertyInfo.AddFeesColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsCarrierNull() => this.IsNull(this.tabledtPropertyInfo.CarrierColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetCarrierNull()
    {
      this[this.tabledtPropertyInfo.CarrierColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsPremiumNull() => this.IsNull(this.tabledtPropertyInfo.PremiumColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetPremiumNull()
    {
      this[this.tabledtPropertyInfo.PremiumColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsTRIAPremiumNull() => this.IsNull(this.tabledtPropertyInfo.TRIAPremiumColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetTRIAPremiumNull()
    {
      this[this.tabledtPropertyInfo.TRIAPremiumColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsFeeAmountNull() => this.IsNull(this.tabledtPropertyInfo.FeeAmountColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetFeeAmountNull()
    {
      this[this.tabledtPropertyInfo.FeeAmountColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsLimitNull() => this.IsNull(this.tabledtPropertyInfo.LimitColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetLimitNull()
    {
      this[this.tabledtPropertyInfo.LimitColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsParticipationNull() => this.IsNull(this.tabledtPropertyInfo.ParticipationColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetParticipationNull()
    {
      this[this.tabledtPropertyInfo.ParticipationColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsAddFeesNull() => this.IsNull(this.tabledtPropertyInfo.AddFeesColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetAddFeesNull()
    {
      this[this.tabledtPropertyInfo.AddFeesColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class tblCarrierPremiumRow : DataRow
  {
    private dsGenericMultiRater.tblCarrierPremiumDataTable tabletblCarrierPremium;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblCarrierPremiumRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblCarrierPremium = (dsGenericMultiRater.tblCarrierPremiumDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int ID
    {
      get => Conversions.ToInteger(this[this.tabletblCarrierPremium.IDColumn]);
      set => this[this.tabletblCarrierPremium.IDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int QuoteID
    {
      get => Conversions.ToInteger(this[this.tabletblCarrierPremium.QuoteIDColumn]);
      set => this[this.tabletblCarrierPremium.QuoteIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Guid CompanyLocationGuid
    {
      get
      {
        object obj = this[this.tabletblCarrierPremium.CompanyLocationGuidColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tabletblCarrierPremium.CompanyLocationGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal Premium
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tabletblCarrierPremium.PremiumColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Premium' in table 'tblCarrierPremium' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCarrierPremium.PremiumColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal TRIAPremium
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tabletblCarrierPremium.TRIAPremiumColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'TRIAPremium' in table 'tblCarrierPremium' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblCarrierPremium.TRIAPremiumColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsPremiumNull() => this.IsNull(this.tabletblCarrierPremium.PremiumColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetPremiumNull()
    {
      this[this.tabletblCarrierPremium.PremiumColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsTRIAPremiumNull() => this.IsNull(this.tabletblCarrierPremium.TRIAPremiumColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetTRIAPremiumNull()
    {
      this[this.tabletblCarrierPremium.TRIAPremiumColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class tblGenericLimitsRow : DataRow
  {
    private dsGenericMultiRater.tblGenericLimitsDataTable tabletblGenericLimits;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblGenericLimitsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblGenericLimits = (dsGenericMultiRater.tblGenericLimitsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int QuoteID
    {
      get => Conversions.ToInteger(this[this.tabletblGenericLimits.QuoteIDColumn]);
      set => this[this.tabletblGenericLimits.QuoteIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Limit
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblGenericLimits.LimitColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Limit' in table 'tblGenericLimits' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblGenericLimits.LimitColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string SubLimits
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblGenericLimits.SubLimitsColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'SubLimits' in table 'tblGenericLimits' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblGenericLimits.SubLimitsColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Perils
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblGenericLimits.PerilsColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Perils' in table 'tblGenericLimits' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblGenericLimits.PerilsColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Covering
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblGenericLimits.CoveringColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Covering' in table 'tblGenericLimits' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblGenericLimits.CoveringColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Deductible
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblGenericLimits.DeductibleColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Deductible' in table 'tblGenericLimits' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblGenericLimits.DeductibleColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Valuation
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblGenericLimits.ValuationColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Valuation' in table 'tblGenericLimits' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblGenericLimits.ValuationColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Excluding
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblGenericLimits.ExcludingColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Excluding' in table 'tblGenericLimits' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblGenericLimits.ExcludingColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string AdditionalComments
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblGenericLimits.AdditionalCommentsColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'AdditionalComments' in table 'tblGenericLimits' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblGenericLimits.AdditionalCommentsColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsLimitNull() => this.IsNull(this.tabletblGenericLimits.LimitColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetLimitNull()
    {
      this[this.tabletblGenericLimits.LimitColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsSubLimitsNull() => this.IsNull(this.tabletblGenericLimits.SubLimitsColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetSubLimitsNull()
    {
      this[this.tabletblGenericLimits.SubLimitsColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsPerilsNull() => this.IsNull(this.tabletblGenericLimits.PerilsColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetPerilsNull()
    {
      this[this.tabletblGenericLimits.PerilsColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsCoveringNull() => this.IsNull(this.tabletblGenericLimits.CoveringColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetCoveringNull()
    {
      this[this.tabletblGenericLimits.CoveringColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsDeductibleNull() => this.IsNull(this.tabletblGenericLimits.DeductibleColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetDeductibleNull()
    {
      this[this.tabletblGenericLimits.DeductibleColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsValuationNull() => this.IsNull(this.tabletblGenericLimits.ValuationColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetValuationNull()
    {
      this[this.tabletblGenericLimits.ValuationColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsExcludingNull() => this.IsNull(this.tabletblGenericLimits.ExcludingColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetExcludingNull()
    {
      this[this.tabletblGenericLimits.ExcludingColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsAdditionalCommentsNull()
    {
      return this.IsNull(this.tabletblGenericLimits.AdditionalCommentsColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetAdditionalCommentsNull()
    {
      this[this.tabletblGenericLimits.AdditionalCommentsColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class tblMultiCarrierRaterDataRow : DataRow
  {
    private dsGenericMultiRater.tblMultiCarrierRaterDataDataTable tabletblMultiCarrierRaterData;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblMultiCarrierRaterDataRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblMultiCarrierRaterData = (dsGenericMultiRater.tblMultiCarrierRaterDataDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int QuoteID
    {
      get => Conversions.ToInteger(this[this.tabletblMultiCarrierRaterData.QuoteIDColumn]);
      set => this[this.tabletblMultiCarrierRaterData.QuoteIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal Limit
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tabletblMultiCarrierRaterData.LimitColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Limit' in table 'tblMultiCarrierRaterData' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblMultiCarrierRaterData.LimitColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal Participation
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tabletblMultiCarrierRaterData.ParticipationColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Participation' in table 'tblMultiCarrierRaterData' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblMultiCarrierRaterData.ParticipationColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Guid CompanyLocationGuid
    {
      get
      {
        object obj = this[this.tabletblMultiCarrierRaterData.CompanyLocationGuidColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tabletblMultiCarrierRaterData.CompanyLocationGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsLimitNull() => this.IsNull(this.tabletblMultiCarrierRaterData.LimitColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetLimitNull()
    {
      this[this.tabletblMultiCarrierRaterData.LimitColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsParticipationNull()
    {
      return this.IsNull(this.tabletblMultiCarrierRaterData.ParticipationColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetParticipationNull()
    {
      this[this.tabletblMultiCarrierRaterData.ParticipationColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class dtPropertyInfoRowChangeEvent : EventArgs
  {
    private dsGenericMultiRater.dtPropertyInfoRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dtPropertyInfoRowChangeEvent(
      dsGenericMultiRater.dtPropertyInfoRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsGenericMultiRater.dtPropertyInfoRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class tblCarrierPremiumRowChangeEvent : EventArgs
  {
    private dsGenericMultiRater.tblCarrierPremiumRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblCarrierPremiumRowChangeEvent(
      dsGenericMultiRater.tblCarrierPremiumRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsGenericMultiRater.tblCarrierPremiumRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class tblGenericLimitsRowChangeEvent : EventArgs
  {
    private dsGenericMultiRater.tblGenericLimitsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblGenericLimitsRowChangeEvent(
      dsGenericMultiRater.tblGenericLimitsRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsGenericMultiRater.tblGenericLimitsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class tblMultiCarrierRaterDataRowChangeEvent : EventArgs
  {
    private dsGenericMultiRater.tblMultiCarrierRaterDataRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblMultiCarrierRaterDataRowChangeEvent(
      dsGenericMultiRater.tblMultiCarrierRaterDataRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsGenericMultiRater.tblMultiCarrierRaterDataRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }
}
