// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.dsITVCalculator
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
[XmlRoot("dsITVCalculator")]
[HelpKeyword("vs.data.DataSet")]
[Serializable]
public class dsITVCalculator : DataSet
{
  private dsITVCalculator.tblITVCalculatorBaseValuationDataTable tabletblITVCalculatorBaseValuation;
  private dsITVCalculator.tblITVCalculatorBuildingStoriesDataTable tabletblITVCalculatorBuildingStories;
  private dsITVCalculator.tblITVCalculatorMiscFactorsDataTable tabletblITVCalculatorMiscFactors;
  private dsITVCalculator.tblUnderwritingLocationsDataTable tabletblUnderwritingLocations;
  private dsITVCalculator.lstConstructionTypesDataTable tablelstConstructionTypes;
  private dsITVCalculator.lstClassCodesDataTable tablelstClassCodes;
  private dsITVCalculator.tblITVCalculatorTerritoriesDataTable tabletblITVCalculatorTerritories;
  private dsITVCalculator.tblITVCalculatorDepreciationDataTable tabletblITVCalculatorDepreciation;
  private dsITVCalculator.NetRateUnderwritingLocationsDataTable tableNetRateUnderwritingLocations;
  private SchemaSerializationMode _schemaSerializationMode;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public dsITVCalculator()
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
  protected dsITVCalculator(SerializationInfo info, StreamingContext context)
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
        if (dataSet.Tables[nameof (tblITVCalculatorBaseValuation)] != null)
          base.Tables.Add((DataTable) new dsITVCalculator.tblITVCalculatorBaseValuationDataTable(dataSet.Tables[nameof (tblITVCalculatorBaseValuation)]));
        if (dataSet.Tables[nameof (tblITVCalculatorBuildingStories)] != null)
          base.Tables.Add((DataTable) new dsITVCalculator.tblITVCalculatorBuildingStoriesDataTable(dataSet.Tables[nameof (tblITVCalculatorBuildingStories)]));
        if (dataSet.Tables[nameof (tblITVCalculatorMiscFactors)] != null)
          base.Tables.Add((DataTable) new dsITVCalculator.tblITVCalculatorMiscFactorsDataTable(dataSet.Tables[nameof (tblITVCalculatorMiscFactors)]));
        if (dataSet.Tables[nameof (tblUnderwritingLocations)] != null)
          base.Tables.Add((DataTable) new dsITVCalculator.tblUnderwritingLocationsDataTable(dataSet.Tables[nameof (tblUnderwritingLocations)]));
        if (dataSet.Tables[nameof (lstConstructionTypes)] != null)
          base.Tables.Add((DataTable) new dsITVCalculator.lstConstructionTypesDataTable(dataSet.Tables[nameof (lstConstructionTypes)]));
        if (dataSet.Tables[nameof (lstClassCodes)] != null)
          base.Tables.Add((DataTable) new dsITVCalculator.lstClassCodesDataTable(dataSet.Tables[nameof (lstClassCodes)]));
        if (dataSet.Tables[nameof (tblITVCalculatorTerritories)] != null)
          base.Tables.Add((DataTable) new dsITVCalculator.tblITVCalculatorTerritoriesDataTable(dataSet.Tables[nameof (tblITVCalculatorTerritories)]));
        if (dataSet.Tables[nameof (tblITVCalculatorDepreciation)] != null)
          base.Tables.Add((DataTable) new dsITVCalculator.tblITVCalculatorDepreciationDataTable(dataSet.Tables[nameof (tblITVCalculatorDepreciation)]));
        if (dataSet.Tables[nameof (NetRateUnderwritingLocations)] != null)
          base.Tables.Add((DataTable) new dsITVCalculator.NetRateUnderwritingLocationsDataTable(dataSet.Tables[nameof (NetRateUnderwritingLocations)]));
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
  public dsITVCalculator.tblITVCalculatorBaseValuationDataTable tblITVCalculatorBaseValuation
  {
    get => this.tabletblITVCalculatorBaseValuation;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsITVCalculator.tblITVCalculatorBuildingStoriesDataTable tblITVCalculatorBuildingStories
  {
    get => this.tabletblITVCalculatorBuildingStories;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsITVCalculator.tblITVCalculatorMiscFactorsDataTable tblITVCalculatorMiscFactors
  {
    get => this.tabletblITVCalculatorMiscFactors;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsITVCalculator.tblUnderwritingLocationsDataTable tblUnderwritingLocations
  {
    get => this.tabletblUnderwritingLocations;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsITVCalculator.lstConstructionTypesDataTable lstConstructionTypes
  {
    get => this.tablelstConstructionTypes;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsITVCalculator.lstClassCodesDataTable lstClassCodes => this.tablelstClassCodes;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsITVCalculator.tblITVCalculatorTerritoriesDataTable tblITVCalculatorTerritories
  {
    get => this.tabletblITVCalculatorTerritories;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsITVCalculator.tblITVCalculatorDepreciationDataTable tblITVCalculatorDepreciation
  {
    get => this.tabletblITVCalculatorDepreciation;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsITVCalculator.NetRateUnderwritingLocationsDataTable NetRateUnderwritingLocations
  {
    get => this.tableNetRateUnderwritingLocations;
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
    dsITVCalculator dsItvCalculator = (dsITVCalculator) base.Clone();
    dsItvCalculator.InitVars();
    dsItvCalculator.SchemaSerializationMode = this.SchemaSerializationMode;
    return (DataSet) dsItvCalculator;
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
      if (dataSet.Tables["tblITVCalculatorBaseValuation"] != null)
        base.Tables.Add((DataTable) new dsITVCalculator.tblITVCalculatorBaseValuationDataTable(dataSet.Tables["tblITVCalculatorBaseValuation"]));
      if (dataSet.Tables["tblITVCalculatorBuildingStories"] != null)
        base.Tables.Add((DataTable) new dsITVCalculator.tblITVCalculatorBuildingStoriesDataTable(dataSet.Tables["tblITVCalculatorBuildingStories"]));
      if (dataSet.Tables["tblITVCalculatorMiscFactors"] != null)
        base.Tables.Add((DataTable) new dsITVCalculator.tblITVCalculatorMiscFactorsDataTable(dataSet.Tables["tblITVCalculatorMiscFactors"]));
      if (dataSet.Tables["tblUnderwritingLocations"] != null)
        base.Tables.Add((DataTable) new dsITVCalculator.tblUnderwritingLocationsDataTable(dataSet.Tables["tblUnderwritingLocations"]));
      if (dataSet.Tables["lstConstructionTypes"] != null)
        base.Tables.Add((DataTable) new dsITVCalculator.lstConstructionTypesDataTable(dataSet.Tables["lstConstructionTypes"]));
      if (dataSet.Tables["lstClassCodes"] != null)
        base.Tables.Add((DataTable) new dsITVCalculator.lstClassCodesDataTable(dataSet.Tables["lstClassCodes"]));
      if (dataSet.Tables["tblITVCalculatorTerritories"] != null)
        base.Tables.Add((DataTable) new dsITVCalculator.tblITVCalculatorTerritoriesDataTable(dataSet.Tables["tblITVCalculatorTerritories"]));
      if (dataSet.Tables["tblITVCalculatorDepreciation"] != null)
        base.Tables.Add((DataTable) new dsITVCalculator.tblITVCalculatorDepreciationDataTable(dataSet.Tables["tblITVCalculatorDepreciation"]));
      if (dataSet.Tables["NetRateUnderwritingLocations"] != null)
        base.Tables.Add((DataTable) new dsITVCalculator.NetRateUnderwritingLocationsDataTable(dataSet.Tables["NetRateUnderwritingLocations"]));
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
    this.tabletblITVCalculatorBaseValuation = (dsITVCalculator.tblITVCalculatorBaseValuationDataTable) base.Tables["tblITVCalculatorBaseValuation"];
    if (initTable && this.tabletblITVCalculatorBaseValuation != null)
      this.tabletblITVCalculatorBaseValuation.InitVars();
    this.tabletblITVCalculatorBuildingStories = (dsITVCalculator.tblITVCalculatorBuildingStoriesDataTable) base.Tables["tblITVCalculatorBuildingStories"];
    if (initTable && this.tabletblITVCalculatorBuildingStories != null)
      this.tabletblITVCalculatorBuildingStories.InitVars();
    this.tabletblITVCalculatorMiscFactors = (dsITVCalculator.tblITVCalculatorMiscFactorsDataTable) base.Tables["tblITVCalculatorMiscFactors"];
    if (initTable && this.tabletblITVCalculatorMiscFactors != null)
      this.tabletblITVCalculatorMiscFactors.InitVars();
    this.tabletblUnderwritingLocations = (dsITVCalculator.tblUnderwritingLocationsDataTable) base.Tables["tblUnderwritingLocations"];
    if (initTable && this.tabletblUnderwritingLocations != null)
      this.tabletblUnderwritingLocations.InitVars();
    this.tablelstConstructionTypes = (dsITVCalculator.lstConstructionTypesDataTable) base.Tables["lstConstructionTypes"];
    if (initTable && this.tablelstConstructionTypes != null)
      this.tablelstConstructionTypes.InitVars();
    this.tablelstClassCodes = (dsITVCalculator.lstClassCodesDataTable) base.Tables["lstClassCodes"];
    if (initTable && this.tablelstClassCodes != null)
      this.tablelstClassCodes.InitVars();
    this.tabletblITVCalculatorTerritories = (dsITVCalculator.tblITVCalculatorTerritoriesDataTable) base.Tables["tblITVCalculatorTerritories"];
    if (initTable && this.tabletblITVCalculatorTerritories != null)
      this.tabletblITVCalculatorTerritories.InitVars();
    this.tabletblITVCalculatorDepreciation = (dsITVCalculator.tblITVCalculatorDepreciationDataTable) base.Tables["tblITVCalculatorDepreciation"];
    if (initTable && this.tabletblITVCalculatorDepreciation != null)
      this.tabletblITVCalculatorDepreciation.InitVars();
    this.tableNetRateUnderwritingLocations = (dsITVCalculator.NetRateUnderwritingLocationsDataTable) base.Tables["NetRateUnderwritingLocations"];
    if (!initTable || this.tableNetRateUnderwritingLocations == null)
      return;
    this.tableNetRateUnderwritingLocations.InitVars();
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private void InitClass()
  {
    this.DataSetName = nameof (dsITVCalculator);
    this.Prefix = "";
    this.Namespace = "http://tempuri.org/dsITVCalculator.xsd";
    this.EnforceConstraints = true;
    this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.tabletblITVCalculatorBaseValuation = new dsITVCalculator.tblITVCalculatorBaseValuationDataTable();
    base.Tables.Add((DataTable) this.tabletblITVCalculatorBaseValuation);
    this.tabletblITVCalculatorBuildingStories = new dsITVCalculator.tblITVCalculatorBuildingStoriesDataTable();
    base.Tables.Add((DataTable) this.tabletblITVCalculatorBuildingStories);
    this.tabletblITVCalculatorMiscFactors = new dsITVCalculator.tblITVCalculatorMiscFactorsDataTable();
    base.Tables.Add((DataTable) this.tabletblITVCalculatorMiscFactors);
    this.tabletblUnderwritingLocations = new dsITVCalculator.tblUnderwritingLocationsDataTable();
    base.Tables.Add((DataTable) this.tabletblUnderwritingLocations);
    this.tablelstConstructionTypes = new dsITVCalculator.lstConstructionTypesDataTable();
    base.Tables.Add((DataTable) this.tablelstConstructionTypes);
    this.tablelstClassCodes = new dsITVCalculator.lstClassCodesDataTable();
    base.Tables.Add((DataTable) this.tablelstClassCodes);
    this.tabletblITVCalculatorTerritories = new dsITVCalculator.tblITVCalculatorTerritoriesDataTable();
    base.Tables.Add((DataTable) this.tabletblITVCalculatorTerritories);
    this.tabletblITVCalculatorDepreciation = new dsITVCalculator.tblITVCalculatorDepreciationDataTable();
    base.Tables.Add((DataTable) this.tabletblITVCalculatorDepreciation);
    this.tableNetRateUnderwritingLocations = new dsITVCalculator.NetRateUnderwritingLocationsDataTable();
    base.Tables.Add((DataTable) this.tableNetRateUnderwritingLocations);
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializetblITVCalculatorBaseValuation() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializetblITVCalculatorBuildingStories() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializetblITVCalculatorMiscFactors() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializetblUnderwritingLocations() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializelstConstructionTypes() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializelstClassCodes() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializetblITVCalculatorTerritories() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializetblITVCalculatorDepreciation() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  private bool ShouldSerializeNetRateUnderwritingLocations() => false;

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
    dsITVCalculator dsItvCalculator = new dsITVCalculator();
    XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
    schemaComplexType.Particle = (XmlSchemaParticle) new XmlSchemaSequence()
    {
      Items = {
        (XmlSchemaObject) new XmlSchemaAny()
        {
          Namespace = dsItvCalculator.Namespace
        }
      }
    };
    XmlSchema schemaSerializable = dsItvCalculator.GetSchemaSerializable();
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
  public delegate void tblITVCalculatorBaseValuationRowChangeEventHandler(
    object sender,
    dsITVCalculator.tblITVCalculatorBaseValuationRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void tblITVCalculatorBuildingStoriesRowChangeEventHandler(
    object sender,
    dsITVCalculator.tblITVCalculatorBuildingStoriesRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void tblITVCalculatorMiscFactorsRowChangeEventHandler(
    object sender,
    dsITVCalculator.tblITVCalculatorMiscFactorsRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void tblUnderwritingLocationsRowChangeEventHandler(
    object sender,
    dsITVCalculator.tblUnderwritingLocationsRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void lstConstructionTypesRowChangeEventHandler(
    object sender,
    dsITVCalculator.lstConstructionTypesRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void lstClassCodesRowChangeEventHandler(
    object sender,
    dsITVCalculator.lstClassCodesRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void tblITVCalculatorTerritoriesRowChangeEventHandler(
    object sender,
    dsITVCalculator.tblITVCalculatorTerritoriesRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void tblITVCalculatorDepreciationRowChangeEventHandler(
    object sender,
    dsITVCalculator.tblITVCalculatorDepreciationRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public delegate void NetRateUnderwritingLocationsRowChangeEventHandler(
    object sender,
    dsITVCalculator.NetRateUnderwritingLocationsRowChangeEvent e);

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class tblITVCalculatorBaseValuationDataTable : 
    TypedTableBase<dsITVCalculator.tblITVCalculatorBaseValuationRow>
  {
    private DataColumn columnID;
    private DataColumn columnClassCode;
    private DataColumn columnConstCode;
    private DataColumn columnBaseValuation;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblITVCalculatorBaseValuationDataTable()
    {
      this.TableName = "tblITVCalculatorBaseValuation";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblITVCalculatorBaseValuationDataTable(DataTable table)
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
    protected tblITVCalculatorBaseValuationDataTable(
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
    public DataColumn ClassCodeColumn => this.columnClassCode;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ConstCodeColumn => this.columnConstCode;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn BaseValuationColumn => this.columnBaseValuation;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsITVCalculator.tblITVCalculatorBaseValuationRow this[int index]
    {
      get => (dsITVCalculator.tblITVCalculatorBaseValuationRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsITVCalculator.tblITVCalculatorBaseValuationRowChangeEventHandler tblITVCalculatorBaseValuationRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsITVCalculator.tblITVCalculatorBaseValuationRowChangeEventHandler tblITVCalculatorBaseValuationRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsITVCalculator.tblITVCalculatorBaseValuationRowChangeEventHandler tblITVCalculatorBaseValuationRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsITVCalculator.tblITVCalculatorBaseValuationRowChangeEventHandler tblITVCalculatorBaseValuationRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddtblITVCalculatorBaseValuationRow(
      dsITVCalculator.tblITVCalculatorBaseValuationRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsITVCalculator.tblITVCalculatorBaseValuationRow AddtblITVCalculatorBaseValuationRow(
      string ClassCode,
      string ConstCode,
      Decimal BaseValuation)
    {
      dsITVCalculator.tblITVCalculatorBaseValuationRow row = (dsITVCalculator.tblITVCalculatorBaseValuationRow) this.NewRow();
      object[] objArray = new object[4]
      {
        null,
        (object) ClassCode,
        (object) ConstCode,
        (object) BaseValuation
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsITVCalculator.tblITVCalculatorBaseValuationRow FindByID(Decimal ID)
    {
      return (dsITVCalculator.tblITVCalculatorBaseValuationRow) this.Rows.Find(new object[1]
      {
        (object) ID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsITVCalculator.tblITVCalculatorBaseValuationDataTable valuationDataTable = (dsITVCalculator.tblITVCalculatorBaseValuationDataTable) base.Clone();
      valuationDataTable.InitVars();
      return (DataTable) valuationDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsITVCalculator.tblITVCalculatorBaseValuationDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnID = this.Columns["ID"];
      this.columnClassCode = this.Columns["ClassCode"];
      this.columnConstCode = this.Columns["ConstCode"];
      this.columnBaseValuation = this.Columns["BaseValuation"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnID = new DataColumn("ID", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnID);
      this.columnClassCode = new DataColumn("ClassCode", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnClassCode);
      this.columnConstCode = new DataColumn("ConstCode", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnConstCode);
      this.columnBaseValuation = new DataColumn("BaseValuation", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnBaseValuation);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnID
      }, true));
      this.columnID.AutoIncrement = true;
      this.columnID.AllowDBNull = false;
      this.columnID.ReadOnly = true;
      this.columnID.Unique = true;
      this.columnConstCode.MaxLength = 1;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsITVCalculator.tblITVCalculatorBaseValuationRow NewtblITVCalculatorBaseValuationRow()
    {
      return (dsITVCalculator.tblITVCalculatorBaseValuationRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsITVCalculator.tblITVCalculatorBaseValuationRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType()
    {
      return typeof (dsITVCalculator.tblITVCalculatorBaseValuationRow);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblITVCalculatorBaseValuationRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsITVCalculator.tblITVCalculatorBaseValuationRowChangeEventHandler valuationRowChangedEvent = this.tblITVCalculatorBaseValuationRowChangedEvent;
      if (valuationRowChangedEvent == null)
        return;
      valuationRowChangedEvent((object) this, new dsITVCalculator.tblITVCalculatorBaseValuationRowChangeEvent((dsITVCalculator.tblITVCalculatorBaseValuationRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblITVCalculatorBaseValuationRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsITVCalculator.tblITVCalculatorBaseValuationRowChangeEventHandler rowChangingEvent = this.tblITVCalculatorBaseValuationRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsITVCalculator.tblITVCalculatorBaseValuationRowChangeEvent((dsITVCalculator.tblITVCalculatorBaseValuationRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblITVCalculatorBaseValuationRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsITVCalculator.tblITVCalculatorBaseValuationRowChangeEventHandler valuationRowDeletedEvent = this.tblITVCalculatorBaseValuationRowDeletedEvent;
      if (valuationRowDeletedEvent == null)
        return;
      valuationRowDeletedEvent((object) this, new dsITVCalculator.tblITVCalculatorBaseValuationRowChangeEvent((dsITVCalculator.tblITVCalculatorBaseValuationRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblITVCalculatorBaseValuationRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsITVCalculator.tblITVCalculatorBaseValuationRowChangeEventHandler rowDeletingEvent = this.tblITVCalculatorBaseValuationRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsITVCalculator.tblITVCalculatorBaseValuationRowChangeEvent((dsITVCalculator.tblITVCalculatorBaseValuationRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemovetblITVCalculatorBaseValuationRow(
      dsITVCalculator.tblITVCalculatorBaseValuationRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsITVCalculator dsItvCalculator = new dsITVCalculator();
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
        FixedValue = dsItvCalculator.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblITVCalculatorBaseValuationDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsItvCalculator.GetSchemaSerializable();
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
  public class tblITVCalculatorBuildingStoriesDataTable : 
    TypedTableBase<dsITVCalculator.tblITVCalculatorBuildingStoriesRow>
  {
    private DataColumn columnID;
    private DataColumn columnNumberofStories;
    private DataColumn columnFactor;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblITVCalculatorBuildingStoriesDataTable()
    {
      this.TableName = "tblITVCalculatorBuildingStories";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblITVCalculatorBuildingStoriesDataTable(DataTable table)
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
    protected tblITVCalculatorBuildingStoriesDataTable(
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
    public DataColumn NumberofStoriesColumn => this.columnNumberofStories;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn FactorColumn => this.columnFactor;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsITVCalculator.tblITVCalculatorBuildingStoriesRow this[int index]
    {
      get => (dsITVCalculator.tblITVCalculatorBuildingStoriesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsITVCalculator.tblITVCalculatorBuildingStoriesRowChangeEventHandler tblITVCalculatorBuildingStoriesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsITVCalculator.tblITVCalculatorBuildingStoriesRowChangeEventHandler tblITVCalculatorBuildingStoriesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsITVCalculator.tblITVCalculatorBuildingStoriesRowChangeEventHandler tblITVCalculatorBuildingStoriesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsITVCalculator.tblITVCalculatorBuildingStoriesRowChangeEventHandler tblITVCalculatorBuildingStoriesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddtblITVCalculatorBuildingStoriesRow(
      dsITVCalculator.tblITVCalculatorBuildingStoriesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsITVCalculator.tblITVCalculatorBuildingStoriesRow AddtblITVCalculatorBuildingStoriesRow(
      Decimal NumberofStories,
      Decimal Factor)
    {
      dsITVCalculator.tblITVCalculatorBuildingStoriesRow row = (dsITVCalculator.tblITVCalculatorBuildingStoriesRow) this.NewRow();
      object[] objArray = new object[3]
      {
        null,
        (object) NumberofStories,
        (object) Factor
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsITVCalculator.tblITVCalculatorBuildingStoriesRow FindByID(Decimal ID)
    {
      return (dsITVCalculator.tblITVCalculatorBuildingStoriesRow) this.Rows.Find(new object[1]
      {
        (object) ID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsITVCalculator.tblITVCalculatorBuildingStoriesDataTable storiesDataTable = (dsITVCalculator.tblITVCalculatorBuildingStoriesDataTable) base.Clone();
      storiesDataTable.InitVars();
      return (DataTable) storiesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsITVCalculator.tblITVCalculatorBuildingStoriesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnID = this.Columns["ID"];
      this.columnNumberofStories = this.Columns["NumberofStories"];
      this.columnFactor = this.Columns["Factor"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnID = new DataColumn("ID", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnID);
      this.columnNumberofStories = new DataColumn("NumberofStories", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnNumberofStories);
      this.columnFactor = new DataColumn("Factor", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFactor);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnID
      }, true));
      this.columnID.AutoIncrement = true;
      this.columnID.AllowDBNull = false;
      this.columnID.ReadOnly = true;
      this.columnID.Unique = true;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsITVCalculator.tblITVCalculatorBuildingStoriesRow NewtblITVCalculatorBuildingStoriesRow()
    {
      return (dsITVCalculator.tblITVCalculatorBuildingStoriesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsITVCalculator.tblITVCalculatorBuildingStoriesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType()
    {
      return typeof (dsITVCalculator.tblITVCalculatorBuildingStoriesRow);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblITVCalculatorBuildingStoriesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsITVCalculator.tblITVCalculatorBuildingStoriesRowChangeEventHandler storiesRowChangedEvent = this.tblITVCalculatorBuildingStoriesRowChangedEvent;
      if (storiesRowChangedEvent == null)
        return;
      storiesRowChangedEvent((object) this, new dsITVCalculator.tblITVCalculatorBuildingStoriesRowChangeEvent((dsITVCalculator.tblITVCalculatorBuildingStoriesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblITVCalculatorBuildingStoriesRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsITVCalculator.tblITVCalculatorBuildingStoriesRowChangeEventHandler rowChangingEvent = this.tblITVCalculatorBuildingStoriesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsITVCalculator.tblITVCalculatorBuildingStoriesRowChangeEvent((dsITVCalculator.tblITVCalculatorBuildingStoriesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblITVCalculatorBuildingStoriesRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsITVCalculator.tblITVCalculatorBuildingStoriesRowChangeEventHandler storiesRowDeletedEvent = this.tblITVCalculatorBuildingStoriesRowDeletedEvent;
      if (storiesRowDeletedEvent == null)
        return;
      storiesRowDeletedEvent((object) this, new dsITVCalculator.tblITVCalculatorBuildingStoriesRowChangeEvent((dsITVCalculator.tblITVCalculatorBuildingStoriesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblITVCalculatorBuildingStoriesRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsITVCalculator.tblITVCalculatorBuildingStoriesRowChangeEventHandler rowDeletingEvent = this.tblITVCalculatorBuildingStoriesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsITVCalculator.tblITVCalculatorBuildingStoriesRowChangeEvent((dsITVCalculator.tblITVCalculatorBuildingStoriesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemovetblITVCalculatorBuildingStoriesRow(
      dsITVCalculator.tblITVCalculatorBuildingStoriesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsITVCalculator dsItvCalculator = new dsITVCalculator();
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
        FixedValue = dsItvCalculator.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblITVCalculatorBuildingStoriesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsItvCalculator.GetSchemaSerializable();
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
  public class tblITVCalculatorMiscFactorsDataTable : 
    TypedTableBase<dsITVCalculator.tblITVCalculatorMiscFactorsRow>
  {
    private DataColumn columnID;
    private DataColumn columnFactorType;
    private DataColumn columnFactor;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblITVCalculatorMiscFactorsDataTable()
    {
      this.TableName = "tblITVCalculatorMiscFactors";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblITVCalculatorMiscFactorsDataTable(DataTable table)
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
    protected tblITVCalculatorMiscFactorsDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn IDColumn => this.columnID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn FactorTypeColumn => this.columnFactorType;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn FactorColumn => this.columnFactor;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsITVCalculator.tblITVCalculatorMiscFactorsRow this[int index]
    {
      get => (dsITVCalculator.tblITVCalculatorMiscFactorsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsITVCalculator.tblITVCalculatorMiscFactorsRowChangeEventHandler tblITVCalculatorMiscFactorsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsITVCalculator.tblITVCalculatorMiscFactorsRowChangeEventHandler tblITVCalculatorMiscFactorsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsITVCalculator.tblITVCalculatorMiscFactorsRowChangeEventHandler tblITVCalculatorMiscFactorsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsITVCalculator.tblITVCalculatorMiscFactorsRowChangeEventHandler tblITVCalculatorMiscFactorsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddtblITVCalculatorMiscFactorsRow(dsITVCalculator.tblITVCalculatorMiscFactorsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsITVCalculator.tblITVCalculatorMiscFactorsRow AddtblITVCalculatorMiscFactorsRow(
      string FactorType,
      Decimal Factor)
    {
      dsITVCalculator.tblITVCalculatorMiscFactorsRow row = (dsITVCalculator.tblITVCalculatorMiscFactorsRow) this.NewRow();
      object[] objArray = new object[3]
      {
        null,
        (object) FactorType,
        (object) Factor
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsITVCalculator.tblITVCalculatorMiscFactorsRow FindByID(Decimal ID)
    {
      return (dsITVCalculator.tblITVCalculatorMiscFactorsRow) this.Rows.Find(new object[1]
      {
        (object) ID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsITVCalculator.tblITVCalculatorMiscFactorsDataTable factorsDataTable = (dsITVCalculator.tblITVCalculatorMiscFactorsDataTable) base.Clone();
      factorsDataTable.InitVars();
      return (DataTable) factorsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsITVCalculator.tblITVCalculatorMiscFactorsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnID = this.Columns["ID"];
      this.columnFactorType = this.Columns["FactorType"];
      this.columnFactor = this.Columns["Factor"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnID = new DataColumn("ID", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnID);
      this.columnFactorType = new DataColumn("FactorType", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFactorType);
      this.columnFactor = new DataColumn("Factor", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFactor);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnID
      }, true));
      this.columnID.AutoIncrement = true;
      this.columnID.AllowDBNull = false;
      this.columnID.ReadOnly = true;
      this.columnID.Unique = true;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsITVCalculator.tblITVCalculatorMiscFactorsRow NewtblITVCalculatorMiscFactorsRow()
    {
      return (dsITVCalculator.tblITVCalculatorMiscFactorsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsITVCalculator.tblITVCalculatorMiscFactorsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (dsITVCalculator.tblITVCalculatorMiscFactorsRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblITVCalculatorMiscFactorsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsITVCalculator.tblITVCalculatorMiscFactorsRowChangeEventHandler factorsRowChangedEvent = this.tblITVCalculatorMiscFactorsRowChangedEvent;
      if (factorsRowChangedEvent == null)
        return;
      factorsRowChangedEvent((object) this, new dsITVCalculator.tblITVCalculatorMiscFactorsRowChangeEvent((dsITVCalculator.tblITVCalculatorMiscFactorsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblITVCalculatorMiscFactorsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsITVCalculator.tblITVCalculatorMiscFactorsRowChangeEventHandler rowChangingEvent = this.tblITVCalculatorMiscFactorsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsITVCalculator.tblITVCalculatorMiscFactorsRowChangeEvent((dsITVCalculator.tblITVCalculatorMiscFactorsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblITVCalculatorMiscFactorsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsITVCalculator.tblITVCalculatorMiscFactorsRowChangeEventHandler factorsRowDeletedEvent = this.tblITVCalculatorMiscFactorsRowDeletedEvent;
      if (factorsRowDeletedEvent == null)
        return;
      factorsRowDeletedEvent((object) this, new dsITVCalculator.tblITVCalculatorMiscFactorsRowChangeEvent((dsITVCalculator.tblITVCalculatorMiscFactorsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblITVCalculatorMiscFactorsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsITVCalculator.tblITVCalculatorMiscFactorsRowChangeEventHandler rowDeletingEvent = this.tblITVCalculatorMiscFactorsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsITVCalculator.tblITVCalculatorMiscFactorsRowChangeEvent((dsITVCalculator.tblITVCalculatorMiscFactorsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemovetblITVCalculatorMiscFactorsRow(
      dsITVCalculator.tblITVCalculatorMiscFactorsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsITVCalculator dsItvCalculator = new dsITVCalculator();
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
        FixedValue = dsItvCalculator.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblITVCalculatorMiscFactorsDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsItvCalculator.GetSchemaSerializable();
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
  public class tblUnderwritingLocationsDataTable : 
    TypedTableBase<dsITVCalculator.tblUnderwritingLocationsRow>
  {
    private DataColumn columnAddress1;
    private DataColumn columnCity;
    private DataColumn columnState;
    private DataColumn columnZip;
    private DataColumn columnClassCodeID;
    private DataColumn columnSqFootage;
    private DataColumn columnStories;
    private DataColumn columnYearBuilt;
    private DataColumn columnConstructionID;
    private DataColumn columnRepLCost;
    private DataColumn columnACV;
    private DataColumn columnSprinklerTypeID;
    private DataColumn columnElevators;
    private DataColumn columnLocationID;
    private DataColumn columnBaseRate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblUnderwritingLocationsDataTable()
    {
      this.tblUnderwritingLocationsRowChanging += new dsITVCalculator.tblUnderwritingLocationsRowChangeEventHandler(this.tblUnderwritingLocationsDataTable_tblUnderwritingLocationsRowChanging);
      this.TableName = "tblUnderwritingLocations";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblUnderwritingLocationsDataTable(DataTable table)
    {
      this.tblUnderwritingLocationsRowChanging += new dsITVCalculator.tblUnderwritingLocationsRowChangeEventHandler(this.tblUnderwritingLocationsDataTable_tblUnderwritingLocationsRowChanging);
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
    protected tblUnderwritingLocationsDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.tblUnderwritingLocationsRowChanging += new dsITVCalculator.tblUnderwritingLocationsRowChangeEventHandler(this.tblUnderwritingLocationsDataTable_tblUnderwritingLocationsRowChanging);
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn Address1Column => this.columnAddress1;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn CityColumn => this.columnCity;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn StateColumn => this.columnState;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ZipColumn => this.columnZip;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ClassCodeIDColumn => this.columnClassCodeID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn SqFootageColumn => this.columnSqFootage;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn StoriesColumn => this.columnStories;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn YearBuiltColumn => this.columnYearBuilt;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ConstructionIDColumn => this.columnConstructionID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn RepLCostColumn => this.columnRepLCost;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ACVColumn => this.columnACV;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn SprinklerTypeIDColumn => this.columnSprinklerTypeID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ElevatorsColumn => this.columnElevators;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn LocationIDColumn => this.columnLocationID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn BaseRateColumn => this.columnBaseRate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsITVCalculator.tblUnderwritingLocationsRow this[int index]
    {
      get => (dsITVCalculator.tblUnderwritingLocationsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsITVCalculator.tblUnderwritingLocationsRowChangeEventHandler tblUnderwritingLocationsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsITVCalculator.tblUnderwritingLocationsRowChangeEventHandler tblUnderwritingLocationsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsITVCalculator.tblUnderwritingLocationsRowChangeEventHandler tblUnderwritingLocationsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsITVCalculator.tblUnderwritingLocationsRowChangeEventHandler tblUnderwritingLocationsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddtblUnderwritingLocationsRow(dsITVCalculator.tblUnderwritingLocationsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsITVCalculator.tblUnderwritingLocationsRow AddtblUnderwritingLocationsRow(
      string Address1,
      string City,
      string State,
      string Zip,
      short ClassCodeID,
      int SqFootage,
      byte Stories,
      short YearBuilt,
      byte ConstructionID,
      string RepLCost,
      string ACV,
      byte SprinklerTypeID,
      byte Elevators,
      int LocationID,
      string BaseRate)
    {
      dsITVCalculator.tblUnderwritingLocationsRow row = (dsITVCalculator.tblUnderwritingLocationsRow) this.NewRow();
      object[] objArray = new object[15]
      {
        (object) Address1,
        (object) City,
        (object) State,
        (object) Zip,
        (object) ClassCodeID,
        (object) SqFootage,
        (object) Stories,
        (object) YearBuilt,
        (object) ConstructionID,
        (object) RepLCost,
        (object) ACV,
        (object) SprinklerTypeID,
        (object) Elevators,
        (object) LocationID,
        (object) BaseRate
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsITVCalculator.tblUnderwritingLocationsRow FindByLocationID(int LocationID)
    {
      return (dsITVCalculator.tblUnderwritingLocationsRow) this.Rows.Find(new object[1]
      {
        (object) LocationID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsITVCalculator.tblUnderwritingLocationsDataTable locationsDataTable = (dsITVCalculator.tblUnderwritingLocationsDataTable) base.Clone();
      locationsDataTable.InitVars();
      return (DataTable) locationsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsITVCalculator.tblUnderwritingLocationsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnAddress1 = this.Columns["Address1"];
      this.columnCity = this.Columns["City"];
      this.columnState = this.Columns["State"];
      this.columnZip = this.Columns["Zip"];
      this.columnClassCodeID = this.Columns["ClassCodeID"];
      this.columnSqFootage = this.Columns["SqFootage"];
      this.columnStories = this.Columns["Stories"];
      this.columnYearBuilt = this.Columns["YearBuilt"];
      this.columnConstructionID = this.Columns["ConstructionID"];
      this.columnRepLCost = this.Columns["RepLCost"];
      this.columnACV = this.Columns["ACV"];
      this.columnSprinklerTypeID = this.Columns["SprinklerTypeID"];
      this.columnElevators = this.Columns["Elevators"];
      this.columnLocationID = this.Columns["LocationID"];
      this.columnBaseRate = this.Columns["BaseRate"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnAddress1 = new DataColumn("Address1", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAddress1);
      this.columnCity = new DataColumn("City", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCity);
      this.columnState = new DataColumn("State", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnState);
      this.columnZip = new DataColumn("Zip", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnZip);
      this.columnClassCodeID = new DataColumn("ClassCodeID", typeof (short), (string) null, MappingType.Element);
      this.Columns.Add(this.columnClassCodeID);
      this.columnSqFootage = new DataColumn("SqFootage", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSqFootage);
      this.columnStories = new DataColumn("Stories", typeof (byte), (string) null, MappingType.Element);
      this.Columns.Add(this.columnStories);
      this.columnYearBuilt = new DataColumn("YearBuilt", typeof (short), (string) null, MappingType.Element);
      this.Columns.Add(this.columnYearBuilt);
      this.columnConstructionID = new DataColumn("ConstructionID", typeof (byte), (string) null, MappingType.Element);
      this.Columns.Add(this.columnConstructionID);
      this.columnRepLCost = new DataColumn("RepLCost", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnRepLCost);
      this.columnACV = new DataColumn("ACV", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnACV);
      this.columnSprinklerTypeID = new DataColumn("SprinklerTypeID", typeof (byte), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSprinklerTypeID);
      this.columnElevators = new DataColumn("Elevators", typeof (byte), (string) null, MappingType.Element);
      this.Columns.Add(this.columnElevators);
      this.columnLocationID = new DataColumn("LocationID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLocationID);
      this.columnBaseRate = new DataColumn("BaseRate", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnBaseRate);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnLocationID
      }, true));
      this.columnAddress1.AllowDBNull = false;
      this.columnAddress1.MaxLength = 200;
      this.columnCity.AllowDBNull = false;
      this.columnCity.MaxLength = 50;
      this.columnState.AllowDBNull = false;
      this.columnState.MaxLength = 2;
      this.columnZip.AllowDBNull = false;
      this.columnZip.MaxLength = 15;
      this.columnLocationID.AllowDBNull = false;
      this.columnLocationID.Unique = true;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsITVCalculator.tblUnderwritingLocationsRow NewtblUnderwritingLocationsRow()
    {
      return (dsITVCalculator.tblUnderwritingLocationsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsITVCalculator.tblUnderwritingLocationsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (dsITVCalculator.tblUnderwritingLocationsRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblUnderwritingLocationsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsITVCalculator.tblUnderwritingLocationsRowChangeEventHandler locationsRowChangedEvent = this.tblUnderwritingLocationsRowChangedEvent;
      if (locationsRowChangedEvent == null)
        return;
      locationsRowChangedEvent((object) this, new dsITVCalculator.tblUnderwritingLocationsRowChangeEvent((dsITVCalculator.tblUnderwritingLocationsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblUnderwritingLocationsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsITVCalculator.tblUnderwritingLocationsRowChangeEventHandler rowChangingEvent = this.tblUnderwritingLocationsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsITVCalculator.tblUnderwritingLocationsRowChangeEvent((dsITVCalculator.tblUnderwritingLocationsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblUnderwritingLocationsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsITVCalculator.tblUnderwritingLocationsRowChangeEventHandler locationsRowDeletedEvent = this.tblUnderwritingLocationsRowDeletedEvent;
      if (locationsRowDeletedEvent == null)
        return;
      locationsRowDeletedEvent((object) this, new dsITVCalculator.tblUnderwritingLocationsRowChangeEvent((dsITVCalculator.tblUnderwritingLocationsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblUnderwritingLocationsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsITVCalculator.tblUnderwritingLocationsRowChangeEventHandler rowDeletingEvent = this.tblUnderwritingLocationsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsITVCalculator.tblUnderwritingLocationsRowChangeEvent((dsITVCalculator.tblUnderwritingLocationsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemovetblUnderwritingLocationsRow(dsITVCalculator.tblUnderwritingLocationsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsITVCalculator dsItvCalculator = new dsITVCalculator();
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
        FixedValue = dsItvCalculator.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblUnderwritingLocationsDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsItvCalculator.GetSchemaSerializable();
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

    private void tblUnderwritingLocationsDataTable_tblUnderwritingLocationsRowChanging(
      object sender,
      dsITVCalculator.tblUnderwritingLocationsRowChangeEvent e)
    {
    }
  }

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class lstConstructionTypesDataTable : 
    TypedTableBase<dsITVCalculator.lstConstructionTypesRow>
  {
    private DataColumn columnConstructionTypeID;
    private DataColumn columnType;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public lstConstructionTypesDataTable()
    {
      this.TableName = "lstConstructionTypes";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal lstConstructionTypesDataTable(DataTable table)
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
    protected lstConstructionTypesDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ConstructionTypeIDColumn => this.columnConstructionTypeID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn TypeColumn => this.columnType;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsITVCalculator.lstConstructionTypesRow this[int index]
    {
      get => (dsITVCalculator.lstConstructionTypesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsITVCalculator.lstConstructionTypesRowChangeEventHandler lstConstructionTypesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsITVCalculator.lstConstructionTypesRowChangeEventHandler lstConstructionTypesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsITVCalculator.lstConstructionTypesRowChangeEventHandler lstConstructionTypesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsITVCalculator.lstConstructionTypesRowChangeEventHandler lstConstructionTypesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddlstConstructionTypesRow(dsITVCalculator.lstConstructionTypesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsITVCalculator.lstConstructionTypesRow AddlstConstructionTypesRow(
      byte ConstructionTypeID,
      string Type)
    {
      dsITVCalculator.lstConstructionTypesRow row = (dsITVCalculator.lstConstructionTypesRow) this.NewRow();
      object[] objArray = new object[2]
      {
        (object) ConstructionTypeID,
        (object) Type
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsITVCalculator.lstConstructionTypesRow FindByConstructionTypeID(byte ConstructionTypeID)
    {
      return (dsITVCalculator.lstConstructionTypesRow) this.Rows.Find(new object[1]
      {
        (object) ConstructionTypeID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsITVCalculator.lstConstructionTypesDataTable constructionTypesDataTable = (dsITVCalculator.lstConstructionTypesDataTable) base.Clone();
      constructionTypesDataTable.InitVars();
      return (DataTable) constructionTypesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsITVCalculator.lstConstructionTypesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnConstructionTypeID = this.Columns["ConstructionTypeID"];
      this.columnType = this.Columns["Type"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnConstructionTypeID = new DataColumn("ConstructionTypeID", typeof (byte), (string) null, MappingType.Element);
      this.Columns.Add(this.columnConstructionTypeID);
      this.columnType = new DataColumn("Type", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnType);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnConstructionTypeID
      }, true));
      this.columnConstructionTypeID.AllowDBNull = false;
      this.columnConstructionTypeID.Unique = true;
      this.columnType.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsITVCalculator.lstConstructionTypesRow NewlstConstructionTypesRow()
    {
      return (dsITVCalculator.lstConstructionTypesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsITVCalculator.lstConstructionTypesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (dsITVCalculator.lstConstructionTypesRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstConstructionTypesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsITVCalculator.lstConstructionTypesRowChangeEventHandler typesRowChangedEvent = this.lstConstructionTypesRowChangedEvent;
      if (typesRowChangedEvent == null)
        return;
      typesRowChangedEvent((object) this, new dsITVCalculator.lstConstructionTypesRowChangeEvent((dsITVCalculator.lstConstructionTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstConstructionTypesRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsITVCalculator.lstConstructionTypesRowChangeEventHandler rowChangingEvent = this.lstConstructionTypesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsITVCalculator.lstConstructionTypesRowChangeEvent((dsITVCalculator.lstConstructionTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstConstructionTypesRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsITVCalculator.lstConstructionTypesRowChangeEventHandler typesRowDeletedEvent = this.lstConstructionTypesRowDeletedEvent;
      if (typesRowDeletedEvent == null)
        return;
      typesRowDeletedEvent((object) this, new dsITVCalculator.lstConstructionTypesRowChangeEvent((dsITVCalculator.lstConstructionTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstConstructionTypesRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsITVCalculator.lstConstructionTypesRowChangeEventHandler rowDeletingEvent = this.lstConstructionTypesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsITVCalculator.lstConstructionTypesRowChangeEvent((dsITVCalculator.lstConstructionTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemovelstConstructionTypesRow(dsITVCalculator.lstConstructionTypesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsITVCalculator dsItvCalculator = new dsITVCalculator();
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
        FixedValue = dsItvCalculator.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (lstConstructionTypesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsItvCalculator.GetSchemaSerializable();
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
  public class lstClassCodesDataTable : TypedTableBase<dsITVCalculator.lstClassCodesRow>
  {
    private DataColumn columnClassCodeID;
    private DataColumn columnClassCodeDescription;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public lstClassCodesDataTable()
    {
      this.TableName = "lstClassCodes";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal lstClassCodesDataTable(DataTable table)
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
    protected lstClassCodesDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ClassCodeIDColumn => this.columnClassCodeID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ClassCodeDescriptionColumn => this.columnClassCodeDescription;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsITVCalculator.lstClassCodesRow this[int index]
    {
      get => (dsITVCalculator.lstClassCodesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsITVCalculator.lstClassCodesRowChangeEventHandler lstClassCodesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsITVCalculator.lstClassCodesRowChangeEventHandler lstClassCodesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsITVCalculator.lstClassCodesRowChangeEventHandler lstClassCodesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsITVCalculator.lstClassCodesRowChangeEventHandler lstClassCodesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddlstClassCodesRow(dsITVCalculator.lstClassCodesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsITVCalculator.lstClassCodesRow AddlstClassCodesRow(string ClassCodeDescription)
    {
      dsITVCalculator.lstClassCodesRow row = (dsITVCalculator.lstClassCodesRow) this.NewRow();
      object[] objArray = new object[2]
      {
        null,
        (object) ClassCodeDescription
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsITVCalculator.lstClassCodesRow FindByClassCodeID(short ClassCodeID)
    {
      return (dsITVCalculator.lstClassCodesRow) this.Rows.Find(new object[1]
      {
        (object) ClassCodeID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsITVCalculator.lstClassCodesDataTable classCodesDataTable = (dsITVCalculator.lstClassCodesDataTable) base.Clone();
      classCodesDataTable.InitVars();
      return (DataTable) classCodesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsITVCalculator.lstClassCodesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnClassCodeID = this.Columns["ClassCodeID"];
      this.columnClassCodeDescription = this.Columns["ClassCodeDescription"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnClassCodeID = new DataColumn("ClassCodeID", typeof (short), (string) null, MappingType.Element);
      this.Columns.Add(this.columnClassCodeID);
      this.columnClassCodeDescription = new DataColumn("ClassCodeDescription", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnClassCodeDescription);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnClassCodeID
      }, true));
      this.columnClassCodeID.AutoIncrement = true;
      this.columnClassCodeID.AllowDBNull = false;
      this.columnClassCodeID.ReadOnly = true;
      this.columnClassCodeID.Unique = true;
      this.columnClassCodeDescription.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsITVCalculator.lstClassCodesRow NewlstClassCodesRow()
    {
      return (dsITVCalculator.lstClassCodesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsITVCalculator.lstClassCodesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (dsITVCalculator.lstClassCodesRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstClassCodesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsITVCalculator.lstClassCodesRowChangeEventHandler codesRowChangedEvent = this.lstClassCodesRowChangedEvent;
      if (codesRowChangedEvent == null)
        return;
      codesRowChangedEvent((object) this, new dsITVCalculator.lstClassCodesRowChangeEvent((dsITVCalculator.lstClassCodesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstClassCodesRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsITVCalculator.lstClassCodesRowChangeEventHandler rowChangingEvent = this.lstClassCodesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsITVCalculator.lstClassCodesRowChangeEvent((dsITVCalculator.lstClassCodesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstClassCodesRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsITVCalculator.lstClassCodesRowChangeEventHandler codesRowDeletedEvent = this.lstClassCodesRowDeletedEvent;
      if (codesRowDeletedEvent == null)
        return;
      codesRowDeletedEvent((object) this, new dsITVCalculator.lstClassCodesRowChangeEvent((dsITVCalculator.lstClassCodesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstClassCodesRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsITVCalculator.lstClassCodesRowChangeEventHandler rowDeletingEvent = this.lstClassCodesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsITVCalculator.lstClassCodesRowChangeEvent((dsITVCalculator.lstClassCodesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemovelstClassCodesRow(dsITVCalculator.lstClassCodesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsITVCalculator dsItvCalculator = new dsITVCalculator();
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
        FixedValue = dsItvCalculator.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (lstClassCodesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsItvCalculator.GetSchemaSerializable();
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
  public class tblITVCalculatorTerritoriesDataTable : 
    TypedTableBase<dsITVCalculator.tblITVCalculatorTerritoriesRow>
  {
    private DataColumn columnID;
    private DataColumn columnZipCode;
    private DataColumn columnFactor;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblITVCalculatorTerritoriesDataTable()
    {
      this.TableName = "tblITVCalculatorTerritories";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblITVCalculatorTerritoriesDataTable(DataTable table)
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
    protected tblITVCalculatorTerritoriesDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn IDColumn => this.columnID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ZipCodeColumn => this.columnZipCode;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn FactorColumn => this.columnFactor;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsITVCalculator.tblITVCalculatorTerritoriesRow this[int index]
    {
      get => (dsITVCalculator.tblITVCalculatorTerritoriesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsITVCalculator.tblITVCalculatorTerritoriesRowChangeEventHandler tblITVCalculatorTerritoriesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsITVCalculator.tblITVCalculatorTerritoriesRowChangeEventHandler tblITVCalculatorTerritoriesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsITVCalculator.tblITVCalculatorTerritoriesRowChangeEventHandler tblITVCalculatorTerritoriesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsITVCalculator.tblITVCalculatorTerritoriesRowChangeEventHandler tblITVCalculatorTerritoriesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddtblITVCalculatorTerritoriesRow(dsITVCalculator.tblITVCalculatorTerritoriesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsITVCalculator.tblITVCalculatorTerritoriesRow AddtblITVCalculatorTerritoriesRow(
      string ZipCode,
      Decimal Factor)
    {
      dsITVCalculator.tblITVCalculatorTerritoriesRow row = (dsITVCalculator.tblITVCalculatorTerritoriesRow) this.NewRow();
      object[] objArray = new object[3]
      {
        null,
        (object) ZipCode,
        (object) Factor
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsITVCalculator.tblITVCalculatorTerritoriesRow FindByID(Decimal ID)
    {
      return (dsITVCalculator.tblITVCalculatorTerritoriesRow) this.Rows.Find(new object[1]
      {
        (object) ID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsITVCalculator.tblITVCalculatorTerritoriesDataTable territoriesDataTable = (dsITVCalculator.tblITVCalculatorTerritoriesDataTable) base.Clone();
      territoriesDataTable.InitVars();
      return (DataTable) territoriesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsITVCalculator.tblITVCalculatorTerritoriesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnID = this.Columns["ID"];
      this.columnZipCode = this.Columns["ZipCode"];
      this.columnFactor = this.Columns["Factor"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnID = new DataColumn("ID", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnID);
      this.columnZipCode = new DataColumn("ZipCode", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnZipCode);
      this.columnFactor = new DataColumn("Factor", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFactor);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnID
      }, true));
      this.columnID.AutoIncrement = true;
      this.columnID.AllowDBNull = false;
      this.columnID.ReadOnly = true;
      this.columnID.Unique = true;
      this.columnZipCode.MaxLength = 3;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsITVCalculator.tblITVCalculatorTerritoriesRow NewtblITVCalculatorTerritoriesRow()
    {
      return (dsITVCalculator.tblITVCalculatorTerritoriesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsITVCalculator.tblITVCalculatorTerritoriesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType() => typeof (dsITVCalculator.tblITVCalculatorTerritoriesRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblITVCalculatorTerritoriesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsITVCalculator.tblITVCalculatorTerritoriesRowChangeEventHandler territoriesRowChangedEvent = this.tblITVCalculatorTerritoriesRowChangedEvent;
      if (territoriesRowChangedEvent == null)
        return;
      territoriesRowChangedEvent((object) this, new dsITVCalculator.tblITVCalculatorTerritoriesRowChangeEvent((dsITVCalculator.tblITVCalculatorTerritoriesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblITVCalculatorTerritoriesRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsITVCalculator.tblITVCalculatorTerritoriesRowChangeEventHandler rowChangingEvent = this.tblITVCalculatorTerritoriesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsITVCalculator.tblITVCalculatorTerritoriesRowChangeEvent((dsITVCalculator.tblITVCalculatorTerritoriesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblITVCalculatorTerritoriesRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsITVCalculator.tblITVCalculatorTerritoriesRowChangeEventHandler territoriesRowDeletedEvent = this.tblITVCalculatorTerritoriesRowDeletedEvent;
      if (territoriesRowDeletedEvent == null)
        return;
      territoriesRowDeletedEvent((object) this, new dsITVCalculator.tblITVCalculatorTerritoriesRowChangeEvent((dsITVCalculator.tblITVCalculatorTerritoriesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblITVCalculatorTerritoriesRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsITVCalculator.tblITVCalculatorTerritoriesRowChangeEventHandler rowDeletingEvent = this.tblITVCalculatorTerritoriesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsITVCalculator.tblITVCalculatorTerritoriesRowChangeEvent((dsITVCalculator.tblITVCalculatorTerritoriesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemovetblITVCalculatorTerritoriesRow(
      dsITVCalculator.tblITVCalculatorTerritoriesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsITVCalculator dsItvCalculator = new dsITVCalculator();
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
        FixedValue = dsItvCalculator.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblITVCalculatorTerritoriesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsItvCalculator.GetSchemaSerializable();
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
  public class tblITVCalculatorDepreciationDataTable : 
    TypedTableBase<dsITVCalculator.tblITVCalculatorDepreciationRow>
  {
    private DataColumn columnID;
    private DataColumn columnYearBuilt;
    private DataColumn columnFactor;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblITVCalculatorDepreciationDataTable()
    {
      this.TableName = "tblITVCalculatorDepreciation";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblITVCalculatorDepreciationDataTable(DataTable table)
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
    protected tblITVCalculatorDepreciationDataTable(
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
    public DataColumn YearBuiltColumn => this.columnYearBuilt;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn FactorColumn => this.columnFactor;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsITVCalculator.tblITVCalculatorDepreciationRow this[int index]
    {
      get => (dsITVCalculator.tblITVCalculatorDepreciationRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsITVCalculator.tblITVCalculatorDepreciationRowChangeEventHandler tblITVCalculatorDepreciationRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsITVCalculator.tblITVCalculatorDepreciationRowChangeEventHandler tblITVCalculatorDepreciationRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsITVCalculator.tblITVCalculatorDepreciationRowChangeEventHandler tblITVCalculatorDepreciationRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsITVCalculator.tblITVCalculatorDepreciationRowChangeEventHandler tblITVCalculatorDepreciationRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddtblITVCalculatorDepreciationRow(
      dsITVCalculator.tblITVCalculatorDepreciationRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsITVCalculator.tblITVCalculatorDepreciationRow AddtblITVCalculatorDepreciationRow(
      Decimal YearBuilt,
      Decimal Factor)
    {
      dsITVCalculator.tblITVCalculatorDepreciationRow row = (dsITVCalculator.tblITVCalculatorDepreciationRow) this.NewRow();
      object[] objArray = new object[3]
      {
        null,
        (object) YearBuilt,
        (object) Factor
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsITVCalculator.tblITVCalculatorDepreciationRow FindByID(Decimal ID)
    {
      return (dsITVCalculator.tblITVCalculatorDepreciationRow) this.Rows.Find(new object[1]
      {
        (object) ID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsITVCalculator.tblITVCalculatorDepreciationDataTable depreciationDataTable = (dsITVCalculator.tblITVCalculatorDepreciationDataTable) base.Clone();
      depreciationDataTable.InitVars();
      return (DataTable) depreciationDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsITVCalculator.tblITVCalculatorDepreciationDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnID = this.Columns["ID"];
      this.columnYearBuilt = this.Columns["YearBuilt"];
      this.columnFactor = this.Columns["Factor"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnID = new DataColumn("ID", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnID);
      this.columnYearBuilt = new DataColumn("YearBuilt", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnYearBuilt);
      this.columnFactor = new DataColumn("Factor", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFactor);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnID
      }, true));
      this.columnID.AutoIncrement = true;
      this.columnID.AllowDBNull = false;
      this.columnID.ReadOnly = true;
      this.columnID.Unique = true;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsITVCalculator.tblITVCalculatorDepreciationRow NewtblITVCalculatorDepreciationRow()
    {
      return (dsITVCalculator.tblITVCalculatorDepreciationRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsITVCalculator.tblITVCalculatorDepreciationRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType()
    {
      return typeof (dsITVCalculator.tblITVCalculatorDepreciationRow);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblITVCalculatorDepreciationRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsITVCalculator.tblITVCalculatorDepreciationRowChangeEventHandler depreciationRowChangedEvent = this.tblITVCalculatorDepreciationRowChangedEvent;
      if (depreciationRowChangedEvent == null)
        return;
      depreciationRowChangedEvent((object) this, new dsITVCalculator.tblITVCalculatorDepreciationRowChangeEvent((dsITVCalculator.tblITVCalculatorDepreciationRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblITVCalculatorDepreciationRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsITVCalculator.tblITVCalculatorDepreciationRowChangeEventHandler rowChangingEvent = this.tblITVCalculatorDepreciationRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsITVCalculator.tblITVCalculatorDepreciationRowChangeEvent((dsITVCalculator.tblITVCalculatorDepreciationRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblITVCalculatorDepreciationRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsITVCalculator.tblITVCalculatorDepreciationRowChangeEventHandler depreciationRowDeletedEvent = this.tblITVCalculatorDepreciationRowDeletedEvent;
      if (depreciationRowDeletedEvent == null)
        return;
      depreciationRowDeletedEvent((object) this, new dsITVCalculator.tblITVCalculatorDepreciationRowChangeEvent((dsITVCalculator.tblITVCalculatorDepreciationRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblITVCalculatorDepreciationRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsITVCalculator.tblITVCalculatorDepreciationRowChangeEventHandler rowDeletingEvent = this.tblITVCalculatorDepreciationRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsITVCalculator.tblITVCalculatorDepreciationRowChangeEvent((dsITVCalculator.tblITVCalculatorDepreciationRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemovetblITVCalculatorDepreciationRow(
      dsITVCalculator.tblITVCalculatorDepreciationRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsITVCalculator dsItvCalculator = new dsITVCalculator();
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
        FixedValue = dsItvCalculator.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblITVCalculatorDepreciationDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsItvCalculator.GetSchemaSerializable();
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
  public class NetRateUnderwritingLocationsDataTable : 
    TypedTableBase<dsITVCalculator.NetRateUnderwritingLocationsRow>
  {
    private DataColumn columnAddress1;
    private DataColumn columnCity;
    private DataColumn columnState;
    private DataColumn columnZip;
    private DataColumn columnClassCodeID;
    private DataColumn columnSqFootage;
    private DataColumn columnStories;
    private DataColumn columnYearBuilt;
    private DataColumn columnConstructionID;
    private DataColumn columnRepLCost;
    private DataColumn columnACV;
    private DataColumn columnSprinklerTypeID;
    private DataColumn columnElevators;
    private DataColumn columnLocationID;
    private DataColumn columnClassCode;
    private DataColumn columnBaseRate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public NetRateUnderwritingLocationsDataTable()
    {
      this.NetRateUnderwritingLocationsRowChanging += new dsITVCalculator.NetRateUnderwritingLocationsRowChangeEventHandler(this.NetRateUnderwritingLocationsDataTable_NetRateUnderwritingLocationsRowChanging);
      this.TableName = "NetRateUnderwritingLocations";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal NetRateUnderwritingLocationsDataTable(DataTable table)
    {
      this.NetRateUnderwritingLocationsRowChanging += new dsITVCalculator.NetRateUnderwritingLocationsRowChangeEventHandler(this.NetRateUnderwritingLocationsDataTable_NetRateUnderwritingLocationsRowChanging);
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
    protected NetRateUnderwritingLocationsDataTable(
      SerializationInfo info,
      StreamingContext context)
      : base(info, context)
    {
      this.NetRateUnderwritingLocationsRowChanging += new dsITVCalculator.NetRateUnderwritingLocationsRowChangeEventHandler(this.NetRateUnderwritingLocationsDataTable_NetRateUnderwritingLocationsRowChanging);
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn Address1Column => this.columnAddress1;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn CityColumn => this.columnCity;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn StateColumn => this.columnState;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ZipColumn => this.columnZip;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ClassCodeIDColumn => this.columnClassCodeID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn SqFootageColumn => this.columnSqFootage;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn StoriesColumn => this.columnStories;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn YearBuiltColumn => this.columnYearBuilt;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ConstructionIDColumn => this.columnConstructionID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn RepLCostColumn => this.columnRepLCost;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ACVColumn => this.columnACV;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn SprinklerTypeIDColumn => this.columnSprinklerTypeID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ElevatorsColumn => this.columnElevators;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn LocationIDColumn => this.columnLocationID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn ClassCodeColumn => this.columnClassCode;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataColumn BaseRateColumn => this.columnBaseRate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsITVCalculator.NetRateUnderwritingLocationsRow this[int index]
    {
      get => (dsITVCalculator.NetRateUnderwritingLocationsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsITVCalculator.NetRateUnderwritingLocationsRowChangeEventHandler NetRateUnderwritingLocationsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsITVCalculator.NetRateUnderwritingLocationsRowChangeEventHandler NetRateUnderwritingLocationsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsITVCalculator.NetRateUnderwritingLocationsRowChangeEventHandler NetRateUnderwritingLocationsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public event dsITVCalculator.NetRateUnderwritingLocationsRowChangeEventHandler NetRateUnderwritingLocationsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void AddNetRateUnderwritingLocationsRow(
      dsITVCalculator.NetRateUnderwritingLocationsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsITVCalculator.NetRateUnderwritingLocationsRow AddNetRateUnderwritingLocationsRow(
      string Address1,
      string City,
      string State,
      string Zip,
      string ClassCodeID,
      string SqFootage,
      string Stories,
      short YearBuilt,
      byte ConstructionID,
      string RepLCost,
      string ACV,
      byte SprinklerTypeID,
      byte Elevators,
      int LocationID,
      string ClassCode,
      string BaseRate)
    {
      dsITVCalculator.NetRateUnderwritingLocationsRow row = (dsITVCalculator.NetRateUnderwritingLocationsRow) this.NewRow();
      object[] objArray = new object[16 /*0x10*/]
      {
        (object) Address1,
        (object) City,
        (object) State,
        (object) Zip,
        (object) ClassCodeID,
        (object) SqFootage,
        (object) Stories,
        (object) YearBuilt,
        (object) ConstructionID,
        (object) RepLCost,
        (object) ACV,
        (object) SprinklerTypeID,
        (object) Elevators,
        (object) LocationID,
        (object) ClassCode,
        (object) BaseRate
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataTable Clone()
    {
      dsITVCalculator.NetRateUnderwritingLocationsDataTable locationsDataTable = (dsITVCalculator.NetRateUnderwritingLocationsDataTable) base.Clone();
      locationsDataTable.InitVars();
      return (DataTable) locationsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsITVCalculator.NetRateUnderwritingLocationsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.columnAddress1 = this.Columns["Address1"];
      this.columnCity = this.Columns["City"];
      this.columnState = this.Columns["State"];
      this.columnZip = this.Columns["Zip"];
      this.columnClassCodeID = this.Columns["ClassCodeID"];
      this.columnSqFootage = this.Columns["SqFootage"];
      this.columnStories = this.Columns["Stories"];
      this.columnYearBuilt = this.Columns["YearBuilt"];
      this.columnConstructionID = this.Columns["ConstructionID"];
      this.columnRepLCost = this.Columns["RepLCost"];
      this.columnACV = this.Columns["ACV"];
      this.columnSprinklerTypeID = this.Columns["SprinklerTypeID"];
      this.columnElevators = this.Columns["Elevators"];
      this.columnLocationID = this.Columns["LocationID"];
      this.columnClassCode = this.Columns["ClassCode"];
      this.columnBaseRate = this.Columns["BaseRate"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.columnAddress1 = new DataColumn("Address1", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAddress1);
      this.columnCity = new DataColumn("City", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCity);
      this.columnState = new DataColumn("State", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnState);
      this.columnZip = new DataColumn("Zip", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnZip);
      this.columnClassCodeID = new DataColumn("ClassCodeID", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnClassCodeID);
      this.columnSqFootage = new DataColumn("SqFootage", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSqFootage);
      this.columnStories = new DataColumn("Stories", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnStories);
      this.columnYearBuilt = new DataColumn("YearBuilt", typeof (short), (string) null, MappingType.Element);
      this.Columns.Add(this.columnYearBuilt);
      this.columnConstructionID = new DataColumn("ConstructionID", typeof (byte), (string) null, MappingType.Element);
      this.Columns.Add(this.columnConstructionID);
      this.columnRepLCost = new DataColumn("RepLCost", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnRepLCost);
      this.columnACV = new DataColumn("ACV", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnACV);
      this.columnSprinklerTypeID = new DataColumn("SprinklerTypeID", typeof (byte), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSprinklerTypeID);
      this.columnElevators = new DataColumn("Elevators", typeof (byte), (string) null, MappingType.Element);
      this.Columns.Add(this.columnElevators);
      this.columnLocationID = new DataColumn("LocationID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLocationID);
      this.columnClassCode = new DataColumn("ClassCode", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnClassCode);
      this.columnBaseRate = new DataColumn("BaseRate", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnBaseRate);
      this.columnAddress1.AllowDBNull = false;
      this.columnAddress1.MaxLength = 200;
      this.columnCity.AllowDBNull = false;
      this.columnCity.MaxLength = 50;
      this.columnState.AllowDBNull = false;
      this.columnState.MaxLength = 2;
      this.columnZip.AllowDBNull = false;
      this.columnZip.MaxLength = 15;
      this.columnLocationID.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsITVCalculator.NetRateUnderwritingLocationsRow NewNetRateUnderwritingLocationsRow()
    {
      return (dsITVCalculator.NetRateUnderwritingLocationsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsITVCalculator.NetRateUnderwritingLocationsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override Type GetRowType()
    {
      return typeof (dsITVCalculator.NetRateUnderwritingLocationsRow);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.NetRateUnderwritingLocationsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsITVCalculator.NetRateUnderwritingLocationsRowChangeEventHandler locationsRowChangedEvent = this.NetRateUnderwritingLocationsRowChangedEvent;
      if (locationsRowChangedEvent == null)
        return;
      locationsRowChangedEvent((object) this, new dsITVCalculator.NetRateUnderwritingLocationsRowChangeEvent((dsITVCalculator.NetRateUnderwritingLocationsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.NetRateUnderwritingLocationsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsITVCalculator.NetRateUnderwritingLocationsRowChangeEventHandler rowChangingEvent = this.NetRateUnderwritingLocationsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsITVCalculator.NetRateUnderwritingLocationsRowChangeEvent((dsITVCalculator.NetRateUnderwritingLocationsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.NetRateUnderwritingLocationsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsITVCalculator.NetRateUnderwritingLocationsRowChangeEventHandler locationsRowDeletedEvent = this.NetRateUnderwritingLocationsRowDeletedEvent;
      if (locationsRowDeletedEvent == null)
        return;
      locationsRowDeletedEvent((object) this, new dsITVCalculator.NetRateUnderwritingLocationsRowChangeEvent((dsITVCalculator.NetRateUnderwritingLocationsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.NetRateUnderwritingLocationsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsITVCalculator.NetRateUnderwritingLocationsRowChangeEventHandler rowDeletingEvent = this.NetRateUnderwritingLocationsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsITVCalculator.NetRateUnderwritingLocationsRowChangeEvent((dsITVCalculator.NetRateUnderwritingLocationsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void RemoveNetRateUnderwritingLocationsRow(
      dsITVCalculator.NetRateUnderwritingLocationsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsITVCalculator dsItvCalculator = new dsITVCalculator();
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
        FixedValue = dsItvCalculator.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (NetRateUnderwritingLocationsDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsItvCalculator.GetSchemaSerializable();
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

    private void NetRateUnderwritingLocationsDataTable_NetRateUnderwritingLocationsRowChanging(
      object sender,
      dsITVCalculator.NetRateUnderwritingLocationsRowChangeEvent e)
    {
    }
  }

  public class tblITVCalculatorBaseValuationRow : DataRow
  {
    private dsITVCalculator.tblITVCalculatorBaseValuationDataTable tabletblITVCalculatorBaseValuation;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblITVCalculatorBaseValuationRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblITVCalculatorBaseValuation = (dsITVCalculator.tblITVCalculatorBaseValuationDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal ID
    {
      get => Conversions.ToDecimal(this[this.tabletblITVCalculatorBaseValuation.IDColumn]);
      set => this[this.tabletblITVCalculatorBaseValuation.IDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string ClassCode
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblITVCalculatorBaseValuation.ClassCodeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ClassCode' in table 'tblITVCalculatorBaseValuation' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblITVCalculatorBaseValuation.ClassCodeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string ConstCode
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblITVCalculatorBaseValuation.ConstCodeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ConstCode' in table 'tblITVCalculatorBaseValuation' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblITVCalculatorBaseValuation.ConstCodeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal BaseValuation
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tabletblITVCalculatorBaseValuation.BaseValuationColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'BaseValuation' in table 'tblITVCalculatorBaseValuation' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblITVCalculatorBaseValuation.BaseValuationColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsClassCodeNull()
    {
      return this.IsNull(this.tabletblITVCalculatorBaseValuation.ClassCodeColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetClassCodeNull()
    {
      this[this.tabletblITVCalculatorBaseValuation.ClassCodeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsConstCodeNull()
    {
      return this.IsNull(this.tabletblITVCalculatorBaseValuation.ConstCodeColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetConstCodeNull()
    {
      this[this.tabletblITVCalculatorBaseValuation.ConstCodeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsBaseValuationNull()
    {
      return this.IsNull(this.tabletblITVCalculatorBaseValuation.BaseValuationColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetBaseValuationNull()
    {
      this[this.tabletblITVCalculatorBaseValuation.BaseValuationColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class tblITVCalculatorBuildingStoriesRow : DataRow
  {
    private dsITVCalculator.tblITVCalculatorBuildingStoriesDataTable tabletblITVCalculatorBuildingStories;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblITVCalculatorBuildingStoriesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblITVCalculatorBuildingStories = (dsITVCalculator.tblITVCalculatorBuildingStoriesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal ID
    {
      get => Conversions.ToDecimal(this[this.tabletblITVCalculatorBuildingStories.IDColumn]);
      set => this[this.tabletblITVCalculatorBuildingStories.IDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal NumberofStories
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tabletblITVCalculatorBuildingStories.NumberofStoriesColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'NumberofStories' in table 'tblITVCalculatorBuildingStories' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblITVCalculatorBuildingStories.NumberofStoriesColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal Factor
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tabletblITVCalculatorBuildingStories.FactorColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Factor' in table 'tblITVCalculatorBuildingStories' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblITVCalculatorBuildingStories.FactorColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsNumberofStoriesNull()
    {
      return this.IsNull(this.tabletblITVCalculatorBuildingStories.NumberofStoriesColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetNumberofStoriesNull()
    {
      this[this.tabletblITVCalculatorBuildingStories.NumberofStoriesColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsFactorNull()
    {
      return this.IsNull(this.tabletblITVCalculatorBuildingStories.FactorColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetFactorNull()
    {
      this[this.tabletblITVCalculatorBuildingStories.FactorColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class tblITVCalculatorMiscFactorsRow : DataRow
  {
    private dsITVCalculator.tblITVCalculatorMiscFactorsDataTable tabletblITVCalculatorMiscFactors;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblITVCalculatorMiscFactorsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblITVCalculatorMiscFactors = (dsITVCalculator.tblITVCalculatorMiscFactorsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal ID
    {
      get => Conversions.ToDecimal(this[this.tabletblITVCalculatorMiscFactors.IDColumn]);
      set => this[this.tabletblITVCalculatorMiscFactors.IDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string FactorType
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblITVCalculatorMiscFactors.FactorTypeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'FactorType' in table 'tblITVCalculatorMiscFactors' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblITVCalculatorMiscFactors.FactorTypeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal Factor
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tabletblITVCalculatorMiscFactors.FactorColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Factor' in table 'tblITVCalculatorMiscFactors' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblITVCalculatorMiscFactors.FactorColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsFactorTypeNull()
    {
      return this.IsNull(this.tabletblITVCalculatorMiscFactors.FactorTypeColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetFactorTypeNull()
    {
      this[this.tabletblITVCalculatorMiscFactors.FactorTypeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsFactorNull() => this.IsNull(this.tabletblITVCalculatorMiscFactors.FactorColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetFactorNull()
    {
      this[this.tabletblITVCalculatorMiscFactors.FactorColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class tblUnderwritingLocationsRow : DataRow
  {
    private dsITVCalculator.tblUnderwritingLocationsDataTable tabletblUnderwritingLocations;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblUnderwritingLocationsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblUnderwritingLocations = (dsITVCalculator.tblUnderwritingLocationsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Address1
    {
      get => Conversions.ToString(this[this.tabletblUnderwritingLocations.Address1Column]);
      set => this[this.tabletblUnderwritingLocations.Address1Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string City
    {
      get => Conversions.ToString(this[this.tabletblUnderwritingLocations.CityColumn]);
      set => this[this.tabletblUnderwritingLocations.CityColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string State
    {
      get => Conversions.ToString(this[this.tabletblUnderwritingLocations.StateColumn]);
      set => this[this.tabletblUnderwritingLocations.StateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Zip
    {
      get => Conversions.ToString(this[this.tabletblUnderwritingLocations.ZipColumn]);
      set => this[this.tabletblUnderwritingLocations.ZipColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public short ClassCodeID
    {
      get
      {
        try
        {
          return Conversions.ToShort(this[this.tabletblUnderwritingLocations.ClassCodeIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ClassCodeID' in table 'tblUnderwritingLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblUnderwritingLocations.ClassCodeIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int SqFootage
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblUnderwritingLocations.SqFootageColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'SqFootage' in table 'tblUnderwritingLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblUnderwritingLocations.SqFootageColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public byte Stories
    {
      get
      {
        try
        {
          return Conversions.ToByte(this[this.tabletblUnderwritingLocations.StoriesColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Stories' in table 'tblUnderwritingLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblUnderwritingLocations.StoriesColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public short YearBuilt
    {
      get
      {
        try
        {
          return Conversions.ToShort(this[this.tabletblUnderwritingLocations.YearBuiltColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'YearBuilt' in table 'tblUnderwritingLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblUnderwritingLocations.YearBuiltColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public byte ConstructionID
    {
      get
      {
        try
        {
          return Conversions.ToByte(this[this.tabletblUnderwritingLocations.ConstructionIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ConstructionID' in table 'tblUnderwritingLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblUnderwritingLocations.ConstructionIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string RepLCost
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblUnderwritingLocations.RepLCostColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'RepLCost' in table 'tblUnderwritingLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblUnderwritingLocations.RepLCostColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string ACV
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblUnderwritingLocations.ACVColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ACV' in table 'tblUnderwritingLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblUnderwritingLocations.ACVColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public byte SprinklerTypeID
    {
      get
      {
        try
        {
          return Conversions.ToByte(this[this.tabletblUnderwritingLocations.SprinklerTypeIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'SprinklerTypeID' in table 'tblUnderwritingLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblUnderwritingLocations.SprinklerTypeIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public byte Elevators
    {
      get
      {
        try
        {
          return Conversions.ToByte(this[this.tabletblUnderwritingLocations.ElevatorsColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Elevators' in table 'tblUnderwritingLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblUnderwritingLocations.ElevatorsColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int LocationID
    {
      get => Conversions.ToInteger(this[this.tabletblUnderwritingLocations.LocationIDColumn]);
      set => this[this.tabletblUnderwritingLocations.LocationIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string BaseRate
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblUnderwritingLocations.BaseRateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'BaseRate' in table 'tblUnderwritingLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblUnderwritingLocations.BaseRateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsClassCodeIDNull()
    {
      return this.IsNull(this.tabletblUnderwritingLocations.ClassCodeIDColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetClassCodeIDNull()
    {
      this[this.tabletblUnderwritingLocations.ClassCodeIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsSqFootageNull()
    {
      return this.IsNull(this.tabletblUnderwritingLocations.SqFootageColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetSqFootageNull()
    {
      this[this.tabletblUnderwritingLocations.SqFootageColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsStoriesNull() => this.IsNull(this.tabletblUnderwritingLocations.StoriesColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetStoriesNull()
    {
      this[this.tabletblUnderwritingLocations.StoriesColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsYearBuiltNull()
    {
      return this.IsNull(this.tabletblUnderwritingLocations.YearBuiltColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetYearBuiltNull()
    {
      this[this.tabletblUnderwritingLocations.YearBuiltColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsConstructionIDNull()
    {
      return this.IsNull(this.tabletblUnderwritingLocations.ConstructionIDColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetConstructionIDNull()
    {
      this[this.tabletblUnderwritingLocations.ConstructionIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsRepLCostNull() => this.IsNull(this.tabletblUnderwritingLocations.RepLCostColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetRepLCostNull()
    {
      this[this.tabletblUnderwritingLocations.RepLCostColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsACVNull() => this.IsNull(this.tabletblUnderwritingLocations.ACVColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetACVNull()
    {
      this[this.tabletblUnderwritingLocations.ACVColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsSprinklerTypeIDNull()
    {
      return this.IsNull(this.tabletblUnderwritingLocations.SprinklerTypeIDColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetSprinklerTypeIDNull()
    {
      this[this.tabletblUnderwritingLocations.SprinklerTypeIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsElevatorsNull()
    {
      return this.IsNull(this.tabletblUnderwritingLocations.ElevatorsColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetElevatorsNull()
    {
      this[this.tabletblUnderwritingLocations.ElevatorsColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsBaseRateNull() => this.IsNull(this.tabletblUnderwritingLocations.BaseRateColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetBaseRateNull()
    {
      this[this.tabletblUnderwritingLocations.BaseRateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class lstConstructionTypesRow : DataRow
  {
    private dsITVCalculator.lstConstructionTypesDataTable tablelstConstructionTypes;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal lstConstructionTypesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablelstConstructionTypes = (dsITVCalculator.lstConstructionTypesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public byte ConstructionTypeID
    {
      get => Conversions.ToByte(this[this.tablelstConstructionTypes.ConstructionTypeIDColumn]);
      set => this[this.tablelstConstructionTypes.ConstructionTypeIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Type
    {
      get => Conversions.ToString(this[this.tablelstConstructionTypes.TypeColumn]);
      set => this[this.tablelstConstructionTypes.TypeColumn] = (object) value;
    }
  }

  public class lstClassCodesRow : DataRow
  {
    private dsITVCalculator.lstClassCodesDataTable tablelstClassCodes;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal lstClassCodesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablelstClassCodes = (dsITVCalculator.lstClassCodesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public short ClassCodeID
    {
      get => Conversions.ToShort(this[this.tablelstClassCodes.ClassCodeIDColumn]);
      set => this[this.tablelstClassCodes.ClassCodeIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string ClassCodeDescription
    {
      get => Conversions.ToString(this[this.tablelstClassCodes.ClassCodeDescriptionColumn]);
      set => this[this.tablelstClassCodes.ClassCodeDescriptionColumn] = (object) value;
    }
  }

  public class tblITVCalculatorTerritoriesRow : DataRow
  {
    private dsITVCalculator.tblITVCalculatorTerritoriesDataTable tabletblITVCalculatorTerritories;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblITVCalculatorTerritoriesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblITVCalculatorTerritories = (dsITVCalculator.tblITVCalculatorTerritoriesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal ID
    {
      get => Conversions.ToDecimal(this[this.tabletblITVCalculatorTerritories.IDColumn]);
      set => this[this.tabletblITVCalculatorTerritories.IDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string ZipCode
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblITVCalculatorTerritories.ZipCodeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ZipCode' in table 'tblITVCalculatorTerritories' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblITVCalculatorTerritories.ZipCodeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal Factor
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tabletblITVCalculatorTerritories.FactorColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Factor' in table 'tblITVCalculatorTerritories' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblITVCalculatorTerritories.FactorColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsZipCodeNull() => this.IsNull(this.tabletblITVCalculatorTerritories.ZipCodeColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetZipCodeNull()
    {
      this[this.tabletblITVCalculatorTerritories.ZipCodeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsFactorNull() => this.IsNull(this.tabletblITVCalculatorTerritories.FactorColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetFactorNull()
    {
      this[this.tabletblITVCalculatorTerritories.FactorColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class tblITVCalculatorDepreciationRow : DataRow
  {
    private dsITVCalculator.tblITVCalculatorDepreciationDataTable tabletblITVCalculatorDepreciation;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal tblITVCalculatorDepreciationRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblITVCalculatorDepreciation = (dsITVCalculator.tblITVCalculatorDepreciationDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal ID
    {
      get => Conversions.ToDecimal(this[this.tabletblITVCalculatorDepreciation.IDColumn]);
      set => this[this.tabletblITVCalculatorDepreciation.IDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal YearBuilt
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tabletblITVCalculatorDepreciation.YearBuiltColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'YearBuilt' in table 'tblITVCalculatorDepreciation' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblITVCalculatorDepreciation.YearBuiltColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Decimal Factor
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tabletblITVCalculatorDepreciation.FactorColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Factor' in table 'tblITVCalculatorDepreciation' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblITVCalculatorDepreciation.FactorColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsYearBuiltNull()
    {
      return this.IsNull(this.tabletblITVCalculatorDepreciation.YearBuiltColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetYearBuiltNull()
    {
      this[this.tabletblITVCalculatorDepreciation.YearBuiltColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsFactorNull() => this.IsNull(this.tabletblITVCalculatorDepreciation.FactorColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetFactorNull()
    {
      this[this.tabletblITVCalculatorDepreciation.FactorColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class NetRateUnderwritingLocationsRow : DataRow
  {
    private dsITVCalculator.NetRateUnderwritingLocationsDataTable tableNetRateUnderwritingLocations;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal NetRateUnderwritingLocationsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tableNetRateUnderwritingLocations = (dsITVCalculator.NetRateUnderwritingLocationsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Address1
    {
      get => Conversions.ToString(this[this.tableNetRateUnderwritingLocations.Address1Column]);
      set => this[this.tableNetRateUnderwritingLocations.Address1Column] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string City
    {
      get => Conversions.ToString(this[this.tableNetRateUnderwritingLocations.CityColumn]);
      set => this[this.tableNetRateUnderwritingLocations.CityColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string State
    {
      get => Conversions.ToString(this[this.tableNetRateUnderwritingLocations.StateColumn]);
      set => this[this.tableNetRateUnderwritingLocations.StateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Zip
    {
      get => Conversions.ToString(this[this.tableNetRateUnderwritingLocations.ZipColumn]);
      set => this[this.tableNetRateUnderwritingLocations.ZipColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string ClassCodeID
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableNetRateUnderwritingLocations.ClassCodeIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ClassCodeID' in table 'NetRateUnderwritingLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableNetRateUnderwritingLocations.ClassCodeIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string SqFootage
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableNetRateUnderwritingLocations.SqFootageColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'SqFootage' in table 'NetRateUnderwritingLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableNetRateUnderwritingLocations.SqFootageColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string Stories
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableNetRateUnderwritingLocations.StoriesColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Stories' in table 'NetRateUnderwritingLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableNetRateUnderwritingLocations.StoriesColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public short YearBuilt
    {
      get
      {
        try
        {
          return Conversions.ToShort(this[this.tableNetRateUnderwritingLocations.YearBuiltColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'YearBuilt' in table 'NetRateUnderwritingLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableNetRateUnderwritingLocations.YearBuiltColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public byte ConstructionID
    {
      get
      {
        try
        {
          return Conversions.ToByte(this[this.tableNetRateUnderwritingLocations.ConstructionIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ConstructionID' in table 'NetRateUnderwritingLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableNetRateUnderwritingLocations.ConstructionIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string RepLCost
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableNetRateUnderwritingLocations.RepLCostColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'RepLCost' in table 'NetRateUnderwritingLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableNetRateUnderwritingLocations.RepLCostColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string ACV
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableNetRateUnderwritingLocations.ACVColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ACV' in table 'NetRateUnderwritingLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableNetRateUnderwritingLocations.ACVColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public byte SprinklerTypeID
    {
      get
      {
        try
        {
          return Conversions.ToByte(this[this.tableNetRateUnderwritingLocations.SprinklerTypeIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'SprinklerTypeID' in table 'NetRateUnderwritingLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableNetRateUnderwritingLocations.SprinklerTypeIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public byte Elevators
    {
      get
      {
        try
        {
          return Conversions.ToByte(this[this.tableNetRateUnderwritingLocations.ElevatorsColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Elevators' in table 'NetRateUnderwritingLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableNetRateUnderwritingLocations.ElevatorsColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public int LocationID
    {
      get => Conversions.ToInteger(this[this.tableNetRateUnderwritingLocations.LocationIDColumn]);
      set => this[this.tableNetRateUnderwritingLocations.LocationIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string ClassCode
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableNetRateUnderwritingLocations.ClassCodeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ClassCode' in table 'NetRateUnderwritingLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableNetRateUnderwritingLocations.ClassCodeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public string BaseRate
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tableNetRateUnderwritingLocations.BaseRateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'BaseRate' in table 'NetRateUnderwritingLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tableNetRateUnderwritingLocations.BaseRateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsClassCodeIDNull()
    {
      return this.IsNull(this.tableNetRateUnderwritingLocations.ClassCodeIDColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetClassCodeIDNull()
    {
      this[this.tableNetRateUnderwritingLocations.ClassCodeIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsSqFootageNull()
    {
      return this.IsNull(this.tableNetRateUnderwritingLocations.SqFootageColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetSqFootageNull()
    {
      this[this.tableNetRateUnderwritingLocations.SqFootageColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsStoriesNull()
    {
      return this.IsNull(this.tableNetRateUnderwritingLocations.StoriesColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetStoriesNull()
    {
      this[this.tableNetRateUnderwritingLocations.StoriesColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsYearBuiltNull()
    {
      return this.IsNull(this.tableNetRateUnderwritingLocations.YearBuiltColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetYearBuiltNull()
    {
      this[this.tableNetRateUnderwritingLocations.YearBuiltColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsConstructionIDNull()
    {
      return this.IsNull(this.tableNetRateUnderwritingLocations.ConstructionIDColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetConstructionIDNull()
    {
      this[this.tableNetRateUnderwritingLocations.ConstructionIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsRepLCostNull()
    {
      return this.IsNull(this.tableNetRateUnderwritingLocations.RepLCostColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetRepLCostNull()
    {
      this[this.tableNetRateUnderwritingLocations.RepLCostColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsACVNull() => this.IsNull(this.tableNetRateUnderwritingLocations.ACVColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetACVNull()
    {
      this[this.tableNetRateUnderwritingLocations.ACVColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsSprinklerTypeIDNull()
    {
      return this.IsNull(this.tableNetRateUnderwritingLocations.SprinklerTypeIDColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetSprinklerTypeIDNull()
    {
      this[this.tableNetRateUnderwritingLocations.SprinklerTypeIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsElevatorsNull()
    {
      return this.IsNull(this.tableNetRateUnderwritingLocations.ElevatorsColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetElevatorsNull()
    {
      this[this.tableNetRateUnderwritingLocations.ElevatorsColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsClassCodeNull()
    {
      return this.IsNull(this.tableNetRateUnderwritingLocations.ClassCodeColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetClassCodeNull()
    {
      this[this.tableNetRateUnderwritingLocations.ClassCodeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool IsBaseRateNull()
    {
      return this.IsNull(this.tableNetRateUnderwritingLocations.BaseRateColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public void SetBaseRateNull()
    {
      this[this.tableNetRateUnderwritingLocations.BaseRateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class tblITVCalculatorBaseValuationRowChangeEvent : EventArgs
  {
    private dsITVCalculator.tblITVCalculatorBaseValuationRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblITVCalculatorBaseValuationRowChangeEvent(
      dsITVCalculator.tblITVCalculatorBaseValuationRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsITVCalculator.tblITVCalculatorBaseValuationRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class tblITVCalculatorBuildingStoriesRowChangeEvent : EventArgs
  {
    private dsITVCalculator.tblITVCalculatorBuildingStoriesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblITVCalculatorBuildingStoriesRowChangeEvent(
      dsITVCalculator.tblITVCalculatorBuildingStoriesRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsITVCalculator.tblITVCalculatorBuildingStoriesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class tblITVCalculatorMiscFactorsRowChangeEvent : EventArgs
  {
    private dsITVCalculator.tblITVCalculatorMiscFactorsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblITVCalculatorMiscFactorsRowChangeEvent(
      dsITVCalculator.tblITVCalculatorMiscFactorsRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsITVCalculator.tblITVCalculatorMiscFactorsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class tblUnderwritingLocationsRowChangeEvent : EventArgs
  {
    private dsITVCalculator.tblUnderwritingLocationsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblUnderwritingLocationsRowChangeEvent(
      dsITVCalculator.tblUnderwritingLocationsRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsITVCalculator.tblUnderwritingLocationsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class lstConstructionTypesRowChangeEvent : EventArgs
  {
    private dsITVCalculator.lstConstructionTypesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public lstConstructionTypesRowChangeEvent(
      dsITVCalculator.lstConstructionTypesRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsITVCalculator.lstConstructionTypesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class lstClassCodesRowChangeEvent : EventArgs
  {
    private dsITVCalculator.lstClassCodesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public lstClassCodesRowChangeEvent(dsITVCalculator.lstClassCodesRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsITVCalculator.lstClassCodesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class tblITVCalculatorTerritoriesRowChangeEvent : EventArgs
  {
    private dsITVCalculator.tblITVCalculatorTerritoriesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblITVCalculatorTerritoriesRowChangeEvent(
      dsITVCalculator.tblITVCalculatorTerritoriesRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsITVCalculator.tblITVCalculatorTerritoriesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class tblITVCalculatorDepreciationRowChangeEvent : EventArgs
  {
    private dsITVCalculator.tblITVCalculatorDepreciationRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public tblITVCalculatorDepreciationRowChangeEvent(
      dsITVCalculator.tblITVCalculatorDepreciationRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsITVCalculator.tblITVCalculatorDepreciationRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
  public class NetRateUnderwritingLocationsRowChangeEvent : EventArgs
  {
    private dsITVCalculator.NetRateUnderwritingLocationsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public NetRateUnderwritingLocationsRowChangeEvent(
      dsITVCalculator.NetRateUnderwritingLocationsRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public dsITVCalculator.NetRateUnderwritingLocationsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }
}
