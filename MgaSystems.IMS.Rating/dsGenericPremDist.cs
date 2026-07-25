// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Rating.dsGenericPremDist
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
[XmlRoot("dsGenericPremDist")]
[HelpKeyword("vs.data.DataSet")]
[Serializable]
public class dsGenericPremDist : DataSet
{
  private dsGenericPremDist.tblGenericPremiumDistributionDataTable tabletblGenericPremiumDistribution;
  private dsGenericPremDist.lstEndorsementCalculationTypesDataTable tablelstEndorsementCalculationTypes;
  private dsGenericPremDist.tblFin_PolicyChargesDataTable tabletblFin_PolicyCharges;
  private SchemaSerializationMode _schemaSerializationMode;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public dsGenericPremDist()
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
  protected dsGenericPremDist(SerializationInfo info, StreamingContext context)
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
        if (dataSet.Tables[nameof (tblGenericPremiumDistribution)] != null)
          base.Tables.Add((DataTable) new dsGenericPremDist.tblGenericPremiumDistributionDataTable(dataSet.Tables[nameof (tblGenericPremiumDistribution)]));
        if (dataSet.Tables[nameof (lstEndorsementCalculationTypes)] != null)
          base.Tables.Add((DataTable) new dsGenericPremDist.lstEndorsementCalculationTypesDataTable(dataSet.Tables[nameof (lstEndorsementCalculationTypes)]));
        if (dataSet.Tables[nameof (tblFin_PolicyCharges)] != null)
          base.Tables.Add((DataTable) new dsGenericPremDist.tblFin_PolicyChargesDataTable(dataSet.Tables[nameof (tblFin_PolicyCharges)]));
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
  public dsGenericPremDist.tblGenericPremiumDistributionDataTable tblGenericPremiumDistribution
  {
    get => this.tabletblGenericPremiumDistribution;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsGenericPremDist.lstEndorsementCalculationTypesDataTable lstEndorsementCalculationTypes
  {
    get => this.tablelstEndorsementCalculationTypes;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsGenericPremDist.tblFin_PolicyChargesDataTable tblFin_PolicyCharges
  {
    get => this.tabletblFin_PolicyCharges;
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
    dsGenericPremDist dsGenericPremDist = (dsGenericPremDist) base.Clone();
    dsGenericPremDist.InitVars();
    dsGenericPremDist.SchemaSerializationMode = this.SchemaSerializationMode;
    return (DataSet) dsGenericPremDist;
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
      if (dataSet.Tables["tblGenericPremiumDistribution"] != null)
        base.Tables.Add((DataTable) new dsGenericPremDist.tblGenericPremiumDistributionDataTable(dataSet.Tables["tblGenericPremiumDistribution"]));
      if (dataSet.Tables["lstEndorsementCalculationTypes"] != null)
        base.Tables.Add((DataTable) new dsGenericPremDist.lstEndorsementCalculationTypesDataTable(dataSet.Tables["lstEndorsementCalculationTypes"]));
      if (dataSet.Tables["tblFin_PolicyCharges"] != null)
        base.Tables.Add((DataTable) new dsGenericPremDist.tblFin_PolicyChargesDataTable(dataSet.Tables["tblFin_PolicyCharges"]));
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
    this.tabletblGenericPremiumDistribution = (dsGenericPremDist.tblGenericPremiumDistributionDataTable) base.Tables["tblGenericPremiumDistribution"];
    if (initTable && this.tabletblGenericPremiumDistribution != null)
      this.tabletblGenericPremiumDistribution.InitVars();
    this.tablelstEndorsementCalculationTypes = (dsGenericPremDist.lstEndorsementCalculationTypesDataTable) base.Tables["lstEndorsementCalculationTypes"];
    if (initTable && this.tablelstEndorsementCalculationTypes != null)
      this.tablelstEndorsementCalculationTypes.InitVars();
    this.tabletblFin_PolicyCharges = (dsGenericPremDist.tblFin_PolicyChargesDataTable) base.Tables["tblFin_PolicyCharges"];
    if (!initTable || this.tabletblFin_PolicyCharges == null)
      return;
    this.tabletblFin_PolicyCharges.InitVars();
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private void InitClass()
  {
    this.DataSetName = nameof (dsGenericPremDist);
    this.Prefix = "";
    this.Namespace = "http://tempuri.org/dsGenericPremDist.xsd";
    this.EnforceConstraints = true;
    this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.tabletblGenericPremiumDistribution = new dsGenericPremDist.tblGenericPremiumDistributionDataTable();
    base.Tables.Add((DataTable) this.tabletblGenericPremiumDistribution);
    this.tablelstEndorsementCalculationTypes = new dsGenericPremDist.lstEndorsementCalculationTypesDataTable();
    base.Tables.Add((DataTable) this.tablelstEndorsementCalculationTypes);
    this.tabletblFin_PolicyCharges = new dsGenericPremDist.tblFin_PolicyChargesDataTable();
    base.Tables.Add((DataTable) this.tabletblFin_PolicyCharges);
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializetblGenericPremiumDistribution() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializelstEndorsementCalculationTypes() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializetblFin_PolicyCharges() => false;

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
    dsGenericPremDist dsGenericPremDist = new dsGenericPremDist();
    XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
    schemaComplexType.Particle = (XmlSchemaParticle) new XmlSchemaSequence()
    {
      Items = {
        (XmlSchemaObject) new XmlSchemaAny()
        {
          Namespace = dsGenericPremDist.Namespace
        }
      }
    };
    XmlSchema schemaSerializable = dsGenericPremDist.GetSchemaSerializable();
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
  public delegate void tblGenericPremiumDistributionRowChangeEventHandler(
    object sender,
    dsGenericPremDist.tblGenericPremiumDistributionRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void lstEndorsementCalculationTypesRowChangeEventHandler(
    object sender,
    dsGenericPremDist.lstEndorsementCalculationTypesRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void tblFin_PolicyChargesRowChangeEventHandler(
    object sender,
    dsGenericPremDist.tblFin_PolicyChargesRowChangeEvent e);

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class tblGenericPremiumDistributionDataTable : 
    TypedTableBase<dsGenericPremDist.tblGenericPremiumDistributionRow>
  {
    private DataColumn columnQuoteGuid;
    private DataColumn columnChargeCode;
    private DataColumn columnAnnualAmount;
    private DataColumn columnBillAmount;
    private DataColumn columnAdded;
    private DataColumn columnStateID;
    private DataColumn columnEndorsementCalcType;
    private DataColumn columnFactor;
    private DataColumn columnpdGuid;
    private DataColumn columnRoundToDollar;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblGenericPremiumDistributionDataTable()
    {
      this.TableName = "tblGenericPremiumDistribution";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblGenericPremiumDistributionDataTable(DataTable table)
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
    protected tblGenericPremiumDistributionDataTable(
      SerializationInfo info,
      StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn QuoteGuidColumn => this.columnQuoteGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ChargeCodeColumn => this.columnChargeCode;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn AnnualAmountColumn => this.columnAnnualAmount;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn BillAmountColumn => this.columnBillAmount;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn AddedColumn => this.columnAdded;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn StateIDColumn => this.columnStateID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn EndorsementCalcTypeColumn => this.columnEndorsementCalcType;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn FactorColumn => this.columnFactor;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn pdGuidColumn => this.columnpdGuid;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn RoundToDollarColumn => this.columnRoundToDollar;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsGenericPremDist.tblGenericPremiumDistributionRow this[int index]
    {
      get => (dsGenericPremDist.tblGenericPremiumDistributionRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsGenericPremDist.tblGenericPremiumDistributionRowChangeEventHandler tblGenericPremiumDistributionRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsGenericPremDist.tblGenericPremiumDistributionRowChangeEventHandler tblGenericPremiumDistributionRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsGenericPremDist.tblGenericPremiumDistributionRowChangeEventHandler tblGenericPremiumDistributionRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsGenericPremDist.tblGenericPremiumDistributionRowChangeEventHandler tblGenericPremiumDistributionRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddtblGenericPremiumDistributionRow(
      dsGenericPremDist.tblGenericPremiumDistributionRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsGenericPremDist.tblGenericPremiumDistributionRow AddtblGenericPremiumDistributionRow(
      Guid QuoteGuid,
      int ChargeCode,
      Decimal AnnualAmount,
      Decimal BillAmount,
      DateTime Added,
      string StateID,
      string EndorsementCalcType,
      Decimal Factor,
      Guid pdGuid,
      bool RoundToDollar)
    {
      dsGenericPremDist.tblGenericPremiumDistributionRow row = (dsGenericPremDist.tblGenericPremiumDistributionRow) this.NewRow();
      object[] objArray = new object[10]
      {
        (object) QuoteGuid,
        (object) ChargeCode,
        (object) AnnualAmount,
        (object) BillAmount,
        (object) Added,
        (object) StateID,
        (object) EndorsementCalcType,
        (object) Factor,
        (object) pdGuid,
        (object) RoundToDollar
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsGenericPremDist.tblGenericPremiumDistributionDataTable distributionDataTable = (dsGenericPremDist.tblGenericPremiumDistributionDataTable) base.Clone();
      distributionDataTable.InitVars();
      return (DataTable) distributionDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsGenericPremDist.tblGenericPremiumDistributionDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnQuoteGuid = this.Columns["QuoteGuid"];
      this.columnChargeCode = this.Columns["ChargeCode"];
      this.columnAnnualAmount = this.Columns["AnnualAmount"];
      this.columnBillAmount = this.Columns["BillAmount"];
      this.columnAdded = this.Columns["Added"];
      this.columnStateID = this.Columns["StateID"];
      this.columnEndorsementCalcType = this.Columns["EndorsementCalcType"];
      this.columnFactor = this.Columns["Factor"];
      this.columnpdGuid = this.Columns["pdGuid"];
      this.columnRoundToDollar = this.Columns["RoundToDollar"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnQuoteGuid = new DataColumn("QuoteGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnQuoteGuid);
      this.columnChargeCode = new DataColumn("ChargeCode", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnChargeCode);
      this.columnAnnualAmount = new DataColumn("AnnualAmount", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAnnualAmount);
      this.columnBillAmount = new DataColumn("BillAmount", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnBillAmount);
      this.columnAdded = new DataColumn("Added", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAdded);
      this.columnStateID = new DataColumn("StateID", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnStateID);
      this.columnEndorsementCalcType = new DataColumn("EndorsementCalcType", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEndorsementCalcType);
      this.columnFactor = new DataColumn("Factor", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFactor);
      this.columnpdGuid = new DataColumn("pdGuid", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnpdGuid);
      this.columnRoundToDollar = new DataColumn("RoundToDollar", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnRoundToDollar);
      this.columnQuoteGuid.AllowDBNull = false;
      this.columnRoundToDollar.DefaultValue = (object) true;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsGenericPremDist.tblGenericPremiumDistributionRow NewtblGenericPremiumDistributionRow()
    {
      return (dsGenericPremDist.tblGenericPremiumDistributionRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsGenericPremDist.tblGenericPremiumDistributionRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType()
    {
      return typeof (dsGenericPremDist.tblGenericPremiumDistributionRow);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblGenericPremiumDistributionRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsGenericPremDist.tblGenericPremiumDistributionRowChangeEventHandler distributionRowChangedEvent = this.tblGenericPremiumDistributionRowChangedEvent;
      if (distributionRowChangedEvent == null)
        return;
      distributionRowChangedEvent((object) this, new dsGenericPremDist.tblGenericPremiumDistributionRowChangeEvent((dsGenericPremDist.tblGenericPremiumDistributionRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblGenericPremiumDistributionRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsGenericPremDist.tblGenericPremiumDistributionRowChangeEventHandler rowChangingEvent = this.tblGenericPremiumDistributionRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsGenericPremDist.tblGenericPremiumDistributionRowChangeEvent((dsGenericPremDist.tblGenericPremiumDistributionRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblGenericPremiumDistributionRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsGenericPremDist.tblGenericPremiumDistributionRowChangeEventHandler distributionRowDeletedEvent = this.tblGenericPremiumDistributionRowDeletedEvent;
      if (distributionRowDeletedEvent == null)
        return;
      distributionRowDeletedEvent((object) this, new dsGenericPremDist.tblGenericPremiumDistributionRowChangeEvent((dsGenericPremDist.tblGenericPremiumDistributionRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblGenericPremiumDistributionRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsGenericPremDist.tblGenericPremiumDistributionRowChangeEventHandler rowDeletingEvent = this.tblGenericPremiumDistributionRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsGenericPremDist.tblGenericPremiumDistributionRowChangeEvent((dsGenericPremDist.tblGenericPremiumDistributionRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemovetblGenericPremiumDistributionRow(
      dsGenericPremDist.tblGenericPremiumDistributionRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsGenericPremDist dsGenericPremDist = new dsGenericPremDist();
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
        FixedValue = dsGenericPremDist.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblGenericPremiumDistributionDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsGenericPremDist.GetSchemaSerializable();
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
  public class lstEndorsementCalculationTypesDataTable : 
    TypedTableBase<dsGenericPremDist.lstEndorsementCalculationTypesRow>
  {
    private DataColumn columnID;
    private DataColumn columnEndorsementCalcType;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public lstEndorsementCalculationTypesDataTable()
    {
      this.TableName = "lstEndorsementCalculationTypes";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal lstEndorsementCalculationTypesDataTable(DataTable table)
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
    protected lstEndorsementCalculationTypesDataTable(
      SerializationInfo info,
      StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn IDColumn => this.columnID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn EndorsementCalcTypeColumn => this.columnEndorsementCalcType;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsGenericPremDist.lstEndorsementCalculationTypesRow this[int index]
    {
      get => (dsGenericPremDist.lstEndorsementCalculationTypesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsGenericPremDist.lstEndorsementCalculationTypesRowChangeEventHandler lstEndorsementCalculationTypesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsGenericPremDist.lstEndorsementCalculationTypesRowChangeEventHandler lstEndorsementCalculationTypesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsGenericPremDist.lstEndorsementCalculationTypesRowChangeEventHandler lstEndorsementCalculationTypesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsGenericPremDist.lstEndorsementCalculationTypesRowChangeEventHandler lstEndorsementCalculationTypesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddlstEndorsementCalculationTypesRow(
      dsGenericPremDist.lstEndorsementCalculationTypesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsGenericPremDist.lstEndorsementCalculationTypesRow AddlstEndorsementCalculationTypesRow(
      string ID,
      string EndorsementCalcType)
    {
      dsGenericPremDist.lstEndorsementCalculationTypesRow row = (dsGenericPremDist.lstEndorsementCalculationTypesRow) this.NewRow();
      object[] objArray = new object[2]
      {
        (object) ID,
        (object) EndorsementCalcType
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsGenericPremDist.lstEndorsementCalculationTypesRow FindByID(string ID)
    {
      return (dsGenericPremDist.lstEndorsementCalculationTypesRow) this.Rows.Find(new object[1]
      {
        (object) ID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsGenericPremDist.lstEndorsementCalculationTypesDataTable calculationTypesDataTable = (dsGenericPremDist.lstEndorsementCalculationTypesDataTable) base.Clone();
      calculationTypesDataTable.InitVars();
      return (DataTable) calculationTypesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsGenericPremDist.lstEndorsementCalculationTypesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnID = this.Columns["ID"];
      this.columnEndorsementCalcType = this.Columns["EndorsementCalcType"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnID = new DataColumn("ID", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnID);
      this.columnEndorsementCalcType = new DataColumn("EndorsementCalcType", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEndorsementCalcType);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnID
      }, true));
      this.columnID.AllowDBNull = false;
      this.columnID.Unique = true;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsGenericPremDist.lstEndorsementCalculationTypesRow NewlstEndorsementCalculationTypesRow()
    {
      return (dsGenericPremDist.lstEndorsementCalculationTypesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsGenericPremDist.lstEndorsementCalculationTypesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType()
    {
      return typeof (dsGenericPremDist.lstEndorsementCalculationTypesRow);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstEndorsementCalculationTypesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsGenericPremDist.lstEndorsementCalculationTypesRowChangeEventHandler typesRowChangedEvent = this.lstEndorsementCalculationTypesRowChangedEvent;
      if (typesRowChangedEvent == null)
        return;
      typesRowChangedEvent((object) this, new dsGenericPremDist.lstEndorsementCalculationTypesRowChangeEvent((dsGenericPremDist.lstEndorsementCalculationTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstEndorsementCalculationTypesRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsGenericPremDist.lstEndorsementCalculationTypesRowChangeEventHandler rowChangingEvent = this.lstEndorsementCalculationTypesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsGenericPremDist.lstEndorsementCalculationTypesRowChangeEvent((dsGenericPremDist.lstEndorsementCalculationTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstEndorsementCalculationTypesRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsGenericPremDist.lstEndorsementCalculationTypesRowChangeEventHandler typesRowDeletedEvent = this.lstEndorsementCalculationTypesRowDeletedEvent;
      if (typesRowDeletedEvent == null)
        return;
      typesRowDeletedEvent((object) this, new dsGenericPremDist.lstEndorsementCalculationTypesRowChangeEvent((dsGenericPremDist.lstEndorsementCalculationTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstEndorsementCalculationTypesRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsGenericPremDist.lstEndorsementCalculationTypesRowChangeEventHandler rowDeletingEvent = this.lstEndorsementCalculationTypesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsGenericPremDist.lstEndorsementCalculationTypesRowChangeEvent((dsGenericPremDist.lstEndorsementCalculationTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemovelstEndorsementCalculationTypesRow(
      dsGenericPremDist.lstEndorsementCalculationTypesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsGenericPremDist dsGenericPremDist = new dsGenericPremDist();
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
        FixedValue = dsGenericPremDist.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (lstEndorsementCalculationTypesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsGenericPremDist.GetSchemaSerializable();
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
  public class tblFin_PolicyChargesDataTable : 
    TypedTableBase<dsGenericPremDist.tblFin_PolicyChargesRow>
  {
    private DataColumn columnChargeCode;
    private DataColumn columnChargeName;
    private DataColumn columnStateID;
    private DataColumn columnChargeID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblFin_PolicyChargesDataTable()
    {
      this.TableName = "tblFin_PolicyCharges";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblFin_PolicyChargesDataTable(DataTable table)
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
    protected tblFin_PolicyChargesDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ChargeCodeColumn => this.columnChargeCode;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ChargeNameColumn => this.columnChargeName;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn StateIDColumn => this.columnStateID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ChargeIDColumn => this.columnChargeID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsGenericPremDist.tblFin_PolicyChargesRow this[int index]
    {
      get => (dsGenericPremDist.tblFin_PolicyChargesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsGenericPremDist.tblFin_PolicyChargesRowChangeEventHandler tblFin_PolicyChargesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsGenericPremDist.tblFin_PolicyChargesRowChangeEventHandler tblFin_PolicyChargesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsGenericPremDist.tblFin_PolicyChargesRowChangeEventHandler tblFin_PolicyChargesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsGenericPremDist.tblFin_PolicyChargesRowChangeEventHandler tblFin_PolicyChargesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddtblFin_PolicyChargesRow(dsGenericPremDist.tblFin_PolicyChargesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsGenericPremDist.tblFin_PolicyChargesRow AddtblFin_PolicyChargesRow(
      int ChargeCode,
      string ChargeName,
      string StateID,
      string ChargeID)
    {
      dsGenericPremDist.tblFin_PolicyChargesRow row = (dsGenericPremDist.tblFin_PolicyChargesRow) this.NewRow();
      object[] objArray = new object[4]
      {
        (object) ChargeCode,
        (object) ChargeName,
        (object) StateID,
        (object) ChargeID
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsGenericPremDist.tblFin_PolicyChargesRow FindByChargeCode(int ChargeCode)
    {
      return (dsGenericPremDist.tblFin_PolicyChargesRow) this.Rows.Find(new object[1]
      {
        (object) ChargeCode
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsGenericPremDist.tblFin_PolicyChargesDataTable chargesDataTable = (dsGenericPremDist.tblFin_PolicyChargesDataTable) base.Clone();
      chargesDataTable.InitVars();
      return (DataTable) chargesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsGenericPremDist.tblFin_PolicyChargesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnChargeCode = this.Columns["ChargeCode"];
      this.columnChargeName = this.Columns["ChargeName"];
      this.columnStateID = this.Columns["StateID"];
      this.columnChargeID = this.Columns["ChargeID"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnChargeCode = new DataColumn("ChargeCode", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnChargeCode);
      this.columnChargeName = new DataColumn("ChargeName", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnChargeName);
      this.columnStateID = new DataColumn("StateID", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnStateID);
      this.columnChargeID = new DataColumn("ChargeID", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnChargeID);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsRaterGenericKey2", new DataColumn[1]
      {
        this.columnChargeCode
      }, true));
      this.columnChargeCode.AllowDBNull = false;
      this.columnChargeCode.ReadOnly = true;
      this.columnChargeCode.Unique = true;
      this.columnChargeName.AllowDBNull = false;
      this.columnStateID.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsGenericPremDist.tblFin_PolicyChargesRow NewtblFin_PolicyChargesRow()
    {
      return (dsGenericPremDist.tblFin_PolicyChargesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsGenericPremDist.tblFin_PolicyChargesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (dsGenericPremDist.tblFin_PolicyChargesRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblFin_PolicyChargesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsGenericPremDist.tblFin_PolicyChargesRowChangeEventHandler chargesRowChangedEvent = this.tblFin_PolicyChargesRowChangedEvent;
      if (chargesRowChangedEvent == null)
        return;
      chargesRowChangedEvent((object) this, new dsGenericPremDist.tblFin_PolicyChargesRowChangeEvent((dsGenericPremDist.tblFin_PolicyChargesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblFin_PolicyChargesRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsGenericPremDist.tblFin_PolicyChargesRowChangeEventHandler rowChangingEvent = this.tblFin_PolicyChargesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsGenericPremDist.tblFin_PolicyChargesRowChangeEvent((dsGenericPremDist.tblFin_PolicyChargesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblFin_PolicyChargesRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsGenericPremDist.tblFin_PolicyChargesRowChangeEventHandler chargesRowDeletedEvent = this.tblFin_PolicyChargesRowDeletedEvent;
      if (chargesRowDeletedEvent == null)
        return;
      chargesRowDeletedEvent((object) this, new dsGenericPremDist.tblFin_PolicyChargesRowChangeEvent((dsGenericPremDist.tblFin_PolicyChargesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblFin_PolicyChargesRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsGenericPremDist.tblFin_PolicyChargesRowChangeEventHandler rowDeletingEvent = this.tblFin_PolicyChargesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsGenericPremDist.tblFin_PolicyChargesRowChangeEvent((dsGenericPremDist.tblFin_PolicyChargesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemovetblFin_PolicyChargesRow(dsGenericPremDist.tblFin_PolicyChargesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsGenericPremDist dsGenericPremDist = new dsGenericPremDist();
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
        FixedValue = dsGenericPremDist.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblFin_PolicyChargesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsGenericPremDist.GetSchemaSerializable();
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

  public class tblGenericPremiumDistributionRow : DataRow
  {
    private dsGenericPremDist.tblGenericPremiumDistributionDataTable tabletblGenericPremiumDistribution;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblGenericPremiumDistributionRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblGenericPremiumDistribution = (dsGenericPremDist.tblGenericPremiumDistributionDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Guid QuoteGuid
    {
      get
      {
        object obj = this[this.tabletblGenericPremiumDistribution.QuoteGuidColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tabletblGenericPremiumDistribution.QuoteGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int ChargeCode
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblGenericPremiumDistribution.ChargeCodeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ChargeCode' in table 'tblGenericPremiumDistribution' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblGenericPremiumDistribution.ChargeCodeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal AnnualAmount
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tabletblGenericPremiumDistribution.AnnualAmountColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'AnnualAmount' in table 'tblGenericPremiumDistribution' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblGenericPremiumDistribution.AnnualAmountColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal BillAmount
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tabletblGenericPremiumDistribution.BillAmountColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'BillAmount' in table 'tblGenericPremiumDistribution' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblGenericPremiumDistribution.BillAmountColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DateTime Added
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tabletblGenericPremiumDistribution.AddedColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Added' in table 'tblGenericPremiumDistribution' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblGenericPremiumDistribution.AddedColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string StateID
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblGenericPremiumDistribution.StateIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'StateID' in table 'tblGenericPremiumDistribution' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblGenericPremiumDistribution.StateIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string EndorsementCalcType
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblGenericPremiumDistribution.EndorsementCalcTypeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'EndorsementCalcType' in table 'tblGenericPremiumDistribution' is DBNull.", (Exception) ex);
        }
      }
      set
      {
        this[this.tabletblGenericPremiumDistribution.EndorsementCalcTypeColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal Factor
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tabletblGenericPremiumDistribution.FactorColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Factor' in table 'tblGenericPremiumDistribution' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblGenericPremiumDistribution.FactorColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Guid pdGuid
    {
      get
      {
        try
        {
          object obj = this[this.tabletblGenericPremiumDistribution.pdGuidColumn];
          return obj != null ? (Guid) obj : new Guid();
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'pdGuid' in table 'tblGenericPremiumDistribution' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblGenericPremiumDistribution.pdGuidColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool RoundToDollar
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tabletblGenericPremiumDistribution.RoundToDollarColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'RoundToDollar' in table 'tblGenericPremiumDistribution' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblGenericPremiumDistribution.RoundToDollarColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsChargeCodeNull()
    {
      return this.IsNull(this.tabletblGenericPremiumDistribution.ChargeCodeColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetChargeCodeNull()
    {
      this[this.tabletblGenericPremiumDistribution.ChargeCodeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsAnnualAmountNull()
    {
      return this.IsNull(this.tabletblGenericPremiumDistribution.AnnualAmountColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetAnnualAmountNull()
    {
      this[this.tabletblGenericPremiumDistribution.AnnualAmountColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsBillAmountNull()
    {
      return this.IsNull(this.tabletblGenericPremiumDistribution.BillAmountColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetBillAmountNull()
    {
      this[this.tabletblGenericPremiumDistribution.BillAmountColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsAddedNull() => this.IsNull(this.tabletblGenericPremiumDistribution.AddedColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetAddedNull()
    {
      this[this.tabletblGenericPremiumDistribution.AddedColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsStateIDNull()
    {
      return this.IsNull(this.tabletblGenericPremiumDistribution.StateIDColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetStateIDNull()
    {
      this[this.tabletblGenericPremiumDistribution.StateIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsEndorsementCalcTypeNull()
    {
      return this.IsNull(this.tabletblGenericPremiumDistribution.EndorsementCalcTypeColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetEndorsementCalcTypeNull()
    {
      this[this.tabletblGenericPremiumDistribution.EndorsementCalcTypeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsFactorNull() => this.IsNull(this.tabletblGenericPremiumDistribution.FactorColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetFactorNull()
    {
      this[this.tabletblGenericPremiumDistribution.FactorColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IspdGuidNull() => this.IsNull(this.tabletblGenericPremiumDistribution.pdGuidColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetpdGuidNull()
    {
      this[this.tabletblGenericPremiumDistribution.pdGuidColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsRoundToDollarNull()
    {
      return this.IsNull(this.tabletblGenericPremiumDistribution.RoundToDollarColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetRoundToDollarNull()
    {
      this[this.tabletblGenericPremiumDistribution.RoundToDollarColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class lstEndorsementCalculationTypesRow : DataRow
  {
    private dsGenericPremDist.lstEndorsementCalculationTypesDataTable tablelstEndorsementCalculationTypes;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal lstEndorsementCalculationTypesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablelstEndorsementCalculationTypes = (dsGenericPremDist.lstEndorsementCalculationTypesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string ID
    {
      get => Conversions.ToString(this[this.tablelstEndorsementCalculationTypes.IDColumn]);
      set => this[this.tablelstEndorsementCalculationTypes.IDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string EndorsementCalcType
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablelstEndorsementCalculationTypes.EndorsementCalcTypeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'EndorsementCalcType' in table 'lstEndorsementCalculationTypes' is DBNull.", (Exception) ex);
        }
      }
      set
      {
        this[this.tablelstEndorsementCalculationTypes.EndorsementCalcTypeColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsEndorsementCalcTypeNull()
    {
      return this.IsNull(this.tablelstEndorsementCalculationTypes.EndorsementCalcTypeColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetEndorsementCalcTypeNull()
    {
      this[this.tablelstEndorsementCalculationTypes.EndorsementCalcTypeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class tblFin_PolicyChargesRow : DataRow
  {
    private dsGenericPremDist.tblFin_PolicyChargesDataTable tabletblFin_PolicyCharges;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblFin_PolicyChargesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblFin_PolicyCharges = (dsGenericPremDist.tblFin_PolicyChargesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int ChargeCode
    {
      get => Conversions.ToInteger(this[this.tabletblFin_PolicyCharges.ChargeCodeColumn]);
      set => this[this.tabletblFin_PolicyCharges.ChargeCodeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string ChargeName
    {
      get => Conversions.ToString(this[this.tabletblFin_PolicyCharges.ChargeNameColumn]);
      set => this[this.tabletblFin_PolicyCharges.ChargeNameColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string StateID
    {
      get => Conversions.ToString(this[this.tabletblFin_PolicyCharges.StateIDColumn]);
      set => this[this.tabletblFin_PolicyCharges.StateIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string ChargeID
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblFin_PolicyCharges.ChargeIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ChargeID' in table 'tblFin_PolicyCharges' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblFin_PolicyCharges.ChargeIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsChargeIDNull() => this.IsNull(this.tabletblFin_PolicyCharges.ChargeIDColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetChargeIDNull()
    {
      this[this.tabletblFin_PolicyCharges.ChargeIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class tblGenericPremiumDistributionRowChangeEvent : EventArgs
  {
    private dsGenericPremDist.tblGenericPremiumDistributionRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblGenericPremiumDistributionRowChangeEvent(
      dsGenericPremDist.tblGenericPremiumDistributionRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsGenericPremDist.tblGenericPremiumDistributionRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class lstEndorsementCalculationTypesRowChangeEvent : EventArgs
  {
    private dsGenericPremDist.lstEndorsementCalculationTypesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public lstEndorsementCalculationTypesRowChangeEvent(
      dsGenericPremDist.lstEndorsementCalculationTypesRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsGenericPremDist.lstEndorsementCalculationTypesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class tblFin_PolicyChargesRowChangeEvent : EventArgs
  {
    private dsGenericPremDist.tblFin_PolicyChargesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblFin_PolicyChargesRowChangeEvent(
      dsGenericPremDist.tblFin_PolicyChargesRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsGenericPremDist.tblFin_PolicyChargesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }
}
