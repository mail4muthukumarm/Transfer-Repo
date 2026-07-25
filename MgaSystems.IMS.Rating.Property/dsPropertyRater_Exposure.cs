// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.Rating.Property.dsPropertyRater_Exposure
// Assembly: MgaSystems.IMS.Rating.Property, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B6A893CA-828D-4C72-A3E1-997D4DDF80FA
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Rating.Property.dll

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
namespace MgaSystems.IMS.Rating.Property;

[DesignerCategory("code")]
[ToolboxItem(true)]
[XmlSchemaProvider("GetTypedDataSetSchema")]
[XmlRoot("dsPropertyRater_Exposure")]
[HelpKeyword("vs.data.DataSet")]
[Serializable]
public class dsPropertyRater_Exposure : DataSet
{
  private dsPropertyRater_Exposure.tblUnderwritingLocationsDataTable tabletblUnderwritingLocations;
  private dsPropertyRater_Exposure.lstPropRater_CoinsuranceDataTable tablelstPropRater_Coinsurance;
  private dsPropertyRater_Exposure.lstPropRater_CoverageTypesDataTable tablelstPropRater_CoverageTypes;
  private dsPropertyRater_Exposure.lstPropRater_CauseOfLossDataTable tablelstPropRater_CauseOfLoss;
  private dsPropertyRater_Exposure.lstPropRater_ValuationDataTable tablelstPropRater_Valuation;
  private dsPropertyRater_Exposure.tblPropertyExposureDataTable tabletblPropertyExposure;
  private dsPropertyRater_Exposure.lstEndorsementCalculationTypesDataTable tablelstEndorsementCalculationTypes;
  private dsPropertyRater_Exposure.tblClientOfficesDataTable tabletblClientOffices;
  private dsPropertyRater_Exposure.lstDeductiblePerDataTable tablelstDeductiblePer;
  private DataRelation relationtblClientOfficestblPropertyExposure;
  private DataRelation relationtblUnderwritingLocationstblPropertyExposure;
  private DataRelation relationlstDeductiblePertblPropertyExposure;
  private SchemaSerializationMode _schemaSerializationMode;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public dsPropertyRater_Exposure()
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
  protected dsPropertyRater_Exposure(SerializationInfo info, StreamingContext context)
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
        if (dataSet.Tables[nameof (tblUnderwritingLocations)] != null)
          base.Tables.Add((DataTable) new dsPropertyRater_Exposure.tblUnderwritingLocationsDataTable(dataSet.Tables[nameof (tblUnderwritingLocations)]));
        if (dataSet.Tables[nameof (lstPropRater_Coinsurance)] != null)
          base.Tables.Add((DataTable) new dsPropertyRater_Exposure.lstPropRater_CoinsuranceDataTable(dataSet.Tables[nameof (lstPropRater_Coinsurance)]));
        if (dataSet.Tables[nameof (lstPropRater_CoverageTypes)] != null)
          base.Tables.Add((DataTable) new dsPropertyRater_Exposure.lstPropRater_CoverageTypesDataTable(dataSet.Tables[nameof (lstPropRater_CoverageTypes)]));
        if (dataSet.Tables[nameof (lstPropRater_CauseOfLoss)] != null)
          base.Tables.Add((DataTable) new dsPropertyRater_Exposure.lstPropRater_CauseOfLossDataTable(dataSet.Tables[nameof (lstPropRater_CauseOfLoss)]));
        if (dataSet.Tables[nameof (lstPropRater_Valuation)] != null)
          base.Tables.Add((DataTable) new dsPropertyRater_Exposure.lstPropRater_ValuationDataTable(dataSet.Tables[nameof (lstPropRater_Valuation)]));
        if (dataSet.Tables[nameof (tblPropertyExposure)] != null)
          base.Tables.Add((DataTable) new dsPropertyRater_Exposure.tblPropertyExposureDataTable(dataSet.Tables[nameof (tblPropertyExposure)]));
        if (dataSet.Tables[nameof (lstEndorsementCalculationTypes)] != null)
          base.Tables.Add((DataTable) new dsPropertyRater_Exposure.lstEndorsementCalculationTypesDataTable(dataSet.Tables[nameof (lstEndorsementCalculationTypes)]));
        if (dataSet.Tables[nameof (tblClientOffices)] != null)
          base.Tables.Add((DataTable) new dsPropertyRater_Exposure.tblClientOfficesDataTable(dataSet.Tables[nameof (tblClientOffices)]));
        if (dataSet.Tables[nameof (lstDeductiblePer)] != null)
          base.Tables.Add((DataTable) new dsPropertyRater_Exposure.lstDeductiblePerDataTable(dataSet.Tables[nameof (lstDeductiblePer)]));
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
  public dsPropertyRater_Exposure.tblUnderwritingLocationsDataTable tblUnderwritingLocations
  {
    get => this.tabletblUnderwritingLocations;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsPropertyRater_Exposure.lstPropRater_CoinsuranceDataTable lstPropRater_Coinsurance
  {
    get => this.tablelstPropRater_Coinsurance;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsPropertyRater_Exposure.lstPropRater_CoverageTypesDataTable lstPropRater_CoverageTypes
  {
    get => this.tablelstPropRater_CoverageTypes;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsPropertyRater_Exposure.lstPropRater_CauseOfLossDataTable lstPropRater_CauseOfLoss
  {
    get => this.tablelstPropRater_CauseOfLoss;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsPropertyRater_Exposure.lstPropRater_ValuationDataTable lstPropRater_Valuation
  {
    get => this.tablelstPropRater_Valuation;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsPropertyRater_Exposure.tblPropertyExposureDataTable tblPropertyExposure
  {
    get => this.tabletblPropertyExposure;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsPropertyRater_Exposure.lstEndorsementCalculationTypesDataTable lstEndorsementCalculationTypes
  {
    get => this.tablelstEndorsementCalculationTypes;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsPropertyRater_Exposure.tblClientOfficesDataTable tblClientOffices
  {
    get => this.tabletblClientOffices;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsPropertyRater_Exposure.lstDeductiblePerDataTable lstDeductiblePer
  {
    get => this.tablelstDeductiblePer;
  }

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
    dsPropertyRater_Exposure propertyRaterExposure = (dsPropertyRater_Exposure) base.Clone();
    propertyRaterExposure.InitVars();
    propertyRaterExposure.SchemaSerializationMode = this.SchemaSerializationMode;
    return (DataSet) propertyRaterExposure;
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
      if (dataSet.Tables["tblUnderwritingLocations"] != null)
        base.Tables.Add((DataTable) new dsPropertyRater_Exposure.tblUnderwritingLocationsDataTable(dataSet.Tables["tblUnderwritingLocations"]));
      if (dataSet.Tables["lstPropRater_Coinsurance"] != null)
        base.Tables.Add((DataTable) new dsPropertyRater_Exposure.lstPropRater_CoinsuranceDataTable(dataSet.Tables["lstPropRater_Coinsurance"]));
      if (dataSet.Tables["lstPropRater_CoverageTypes"] != null)
        base.Tables.Add((DataTable) new dsPropertyRater_Exposure.lstPropRater_CoverageTypesDataTable(dataSet.Tables["lstPropRater_CoverageTypes"]));
      if (dataSet.Tables["lstPropRater_CauseOfLoss"] != null)
        base.Tables.Add((DataTable) new dsPropertyRater_Exposure.lstPropRater_CauseOfLossDataTable(dataSet.Tables["lstPropRater_CauseOfLoss"]));
      if (dataSet.Tables["lstPropRater_Valuation"] != null)
        base.Tables.Add((DataTable) new dsPropertyRater_Exposure.lstPropRater_ValuationDataTable(dataSet.Tables["lstPropRater_Valuation"]));
      if (dataSet.Tables["tblPropertyExposure"] != null)
        base.Tables.Add((DataTable) new dsPropertyRater_Exposure.tblPropertyExposureDataTable(dataSet.Tables["tblPropertyExposure"]));
      if (dataSet.Tables["lstEndorsementCalculationTypes"] != null)
        base.Tables.Add((DataTable) new dsPropertyRater_Exposure.lstEndorsementCalculationTypesDataTable(dataSet.Tables["lstEndorsementCalculationTypes"]));
      if (dataSet.Tables["tblClientOffices"] != null)
        base.Tables.Add((DataTable) new dsPropertyRater_Exposure.tblClientOfficesDataTable(dataSet.Tables["tblClientOffices"]));
      if (dataSet.Tables["lstDeductiblePer"] != null)
        base.Tables.Add((DataTable) new dsPropertyRater_Exposure.lstDeductiblePerDataTable(dataSet.Tables["lstDeductiblePer"]));
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
    this.tabletblUnderwritingLocations = (dsPropertyRater_Exposure.tblUnderwritingLocationsDataTable) base.Tables["tblUnderwritingLocations"];
    if (initTable && this.tabletblUnderwritingLocations != null)
      this.tabletblUnderwritingLocations.InitVars();
    this.tablelstPropRater_Coinsurance = (dsPropertyRater_Exposure.lstPropRater_CoinsuranceDataTable) base.Tables["lstPropRater_Coinsurance"];
    if (initTable && this.tablelstPropRater_Coinsurance != null)
      this.tablelstPropRater_Coinsurance.InitVars();
    this.tablelstPropRater_CoverageTypes = (dsPropertyRater_Exposure.lstPropRater_CoverageTypesDataTable) base.Tables["lstPropRater_CoverageTypes"];
    if (initTable && this.tablelstPropRater_CoverageTypes != null)
      this.tablelstPropRater_CoverageTypes.InitVars();
    this.tablelstPropRater_CauseOfLoss = (dsPropertyRater_Exposure.lstPropRater_CauseOfLossDataTable) base.Tables["lstPropRater_CauseOfLoss"];
    if (initTable && this.tablelstPropRater_CauseOfLoss != null)
      this.tablelstPropRater_CauseOfLoss.InitVars();
    this.tablelstPropRater_Valuation = (dsPropertyRater_Exposure.lstPropRater_ValuationDataTable) base.Tables["lstPropRater_Valuation"];
    if (initTable && this.tablelstPropRater_Valuation != null)
      this.tablelstPropRater_Valuation.InitVars();
    this.tabletblPropertyExposure = (dsPropertyRater_Exposure.tblPropertyExposureDataTable) base.Tables["tblPropertyExposure"];
    if (initTable && this.tabletblPropertyExposure != null)
      this.tabletblPropertyExposure.InitVars();
    this.tablelstEndorsementCalculationTypes = (dsPropertyRater_Exposure.lstEndorsementCalculationTypesDataTable) base.Tables["lstEndorsementCalculationTypes"];
    if (initTable && this.tablelstEndorsementCalculationTypes != null)
      this.tablelstEndorsementCalculationTypes.InitVars();
    this.tabletblClientOffices = (dsPropertyRater_Exposure.tblClientOfficesDataTable) base.Tables["tblClientOffices"];
    if (initTable && this.tabletblClientOffices != null)
      this.tabletblClientOffices.InitVars();
    this.tablelstDeductiblePer = (dsPropertyRater_Exposure.lstDeductiblePerDataTable) base.Tables["lstDeductiblePer"];
    if (initTable && this.tablelstDeductiblePer != null)
      this.tablelstDeductiblePer.InitVars();
    this.relationtblClientOfficestblPropertyExposure = this.Relations["tblClientOfficestblPropertyExposure"];
    this.relationtblUnderwritingLocationstblPropertyExposure = this.Relations["tblUnderwritingLocationstblPropertyExposure"];
    this.relationlstDeductiblePertblPropertyExposure = this.Relations["lstDeductiblePertblPropertyExposure"];
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private void InitClass()
  {
    this.DataSetName = nameof (dsPropertyRater_Exposure);
    this.Prefix = "";
    this.Namespace = "http://tempuri.org/dsPropertyRater_Exposure.xsd";
    this.EnforceConstraints = true;
    this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.tabletblUnderwritingLocations = new dsPropertyRater_Exposure.tblUnderwritingLocationsDataTable();
    base.Tables.Add((DataTable) this.tabletblUnderwritingLocations);
    this.tablelstPropRater_Coinsurance = new dsPropertyRater_Exposure.lstPropRater_CoinsuranceDataTable();
    base.Tables.Add((DataTable) this.tablelstPropRater_Coinsurance);
    this.tablelstPropRater_CoverageTypes = new dsPropertyRater_Exposure.lstPropRater_CoverageTypesDataTable();
    base.Tables.Add((DataTable) this.tablelstPropRater_CoverageTypes);
    this.tablelstPropRater_CauseOfLoss = new dsPropertyRater_Exposure.lstPropRater_CauseOfLossDataTable();
    base.Tables.Add((DataTable) this.tablelstPropRater_CauseOfLoss);
    this.tablelstPropRater_Valuation = new dsPropertyRater_Exposure.lstPropRater_ValuationDataTable();
    base.Tables.Add((DataTable) this.tablelstPropRater_Valuation);
    this.tabletblPropertyExposure = new dsPropertyRater_Exposure.tblPropertyExposureDataTable();
    base.Tables.Add((DataTable) this.tabletblPropertyExposure);
    this.tablelstEndorsementCalculationTypes = new dsPropertyRater_Exposure.lstEndorsementCalculationTypesDataTable();
    base.Tables.Add((DataTable) this.tablelstEndorsementCalculationTypes);
    this.tabletblClientOffices = new dsPropertyRater_Exposure.tblClientOfficesDataTable();
    base.Tables.Add((DataTable) this.tabletblClientOffices);
    this.tablelstDeductiblePer = new dsPropertyRater_Exposure.lstDeductiblePerDataTable();
    base.Tables.Add((DataTable) this.tablelstDeductiblePer);
    ForeignKeyConstraint foreignKeyConstraint1 = new ForeignKeyConstraint("tblClientOfficestblPropertyExposure", new DataColumn[1]
    {
      this.tabletblClientOffices.OfficeIDColumn
    }, new DataColumn[1]
    {
      this.tabletblPropertyExposure.OfficeIDColumn
    });
    this.tabletblPropertyExposure.Constraints.Add((Constraint) foreignKeyConstraint1);
    foreignKeyConstraint1.AcceptRejectRule = AcceptRejectRule.None;
    foreignKeyConstraint1.DeleteRule = Rule.Cascade;
    foreignKeyConstraint1.UpdateRule = Rule.Cascade;
    ForeignKeyConstraint foreignKeyConstraint2 = new ForeignKeyConstraint("tblUnderwritingLocationstblPropertyExposure", new DataColumn[1]
    {
      this.tabletblUnderwritingLocations.LocationIDColumn
    }, new DataColumn[1]
    {
      this.tabletblPropertyExposure.LocationIDColumn
    });
    this.tabletblPropertyExposure.Constraints.Add((Constraint) foreignKeyConstraint2);
    foreignKeyConstraint2.AcceptRejectRule = AcceptRejectRule.None;
    foreignKeyConstraint2.DeleteRule = Rule.Cascade;
    foreignKeyConstraint2.UpdateRule = Rule.Cascade;
    ForeignKeyConstraint foreignKeyConstraint3 = new ForeignKeyConstraint("lstDeductiblePertblPropertyExposure", new DataColumn[1]
    {
      this.tablelstDeductiblePer.PerIDColumn
    }, new DataColumn[1]
    {
      this.tabletblPropertyExposure.DeductiblePerIDColumn
    });
    this.tabletblPropertyExposure.Constraints.Add((Constraint) foreignKeyConstraint3);
    foreignKeyConstraint3.AcceptRejectRule = AcceptRejectRule.None;
    foreignKeyConstraint3.DeleteRule = Rule.Cascade;
    foreignKeyConstraint3.UpdateRule = Rule.Cascade;
    this.relationtblClientOfficestblPropertyExposure = new DataRelation("tblClientOfficestblPropertyExposure", new DataColumn[1]
    {
      this.tabletblClientOffices.OfficeIDColumn
    }, new DataColumn[1]
    {
      this.tabletblPropertyExposure.OfficeIDColumn
    }, false);
    this.Relations.Add(this.relationtblClientOfficestblPropertyExposure);
    this.relationtblUnderwritingLocationstblPropertyExposure = new DataRelation("tblUnderwritingLocationstblPropertyExposure", new DataColumn[1]
    {
      this.tabletblUnderwritingLocations.LocationIDColumn
    }, new DataColumn[1]
    {
      this.tabletblPropertyExposure.LocationIDColumn
    }, false);
    this.Relations.Add(this.relationtblUnderwritingLocationstblPropertyExposure);
    this.relationlstDeductiblePertblPropertyExposure = new DataRelation("lstDeductiblePertblPropertyExposure", new DataColumn[1]
    {
      this.tablelstDeductiblePer.PerIDColumn
    }, new DataColumn[1]
    {
      this.tabletblPropertyExposure.DeductiblePerIDColumn
    }, false);
    this.Relations.Add(this.relationlstDeductiblePertblPropertyExposure);
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializetblUnderwritingLocations() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializelstPropRater_Coinsurance() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializelstPropRater_CoverageTypes() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializelstPropRater_CauseOfLoss() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializelstPropRater_Valuation() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializetblPropertyExposure() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializelstEndorsementCalculationTypes() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializetblClientOffices() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializelstDeductiblePer() => false;

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
    dsPropertyRater_Exposure propertyRaterExposure = new dsPropertyRater_Exposure();
    XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
    schemaComplexType.Particle = (XmlSchemaParticle) new XmlSchemaSequence()
    {
      Items = {
        (XmlSchemaObject) new XmlSchemaAny()
        {
          Namespace = propertyRaterExposure.Namespace
        }
      }
    };
    XmlSchema schemaSerializable = propertyRaterExposure.GetSchemaSerializable();
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
  public delegate void tblUnderwritingLocationsRowChangeEventHandler(
    object sender,
    dsPropertyRater_Exposure.tblUnderwritingLocationsRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public delegate void lstPropRater_CoinsuranceRowChangeEventHandler(
    object sender,
    dsPropertyRater_Exposure.lstPropRater_CoinsuranceRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public delegate void lstPropRater_CoverageTypesRowChangeEventHandler(
    object sender,
    dsPropertyRater_Exposure.lstPropRater_CoverageTypesRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public delegate void lstPropRater_CauseOfLossRowChangeEventHandler(
    object sender,
    dsPropertyRater_Exposure.lstPropRater_CauseOfLossRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public delegate void lstPropRater_ValuationRowChangeEventHandler(
    object sender,
    dsPropertyRater_Exposure.lstPropRater_ValuationRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public delegate void tblPropertyExposureRowChangeEventHandler(
    object sender,
    dsPropertyRater_Exposure.tblPropertyExposureRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public delegate void lstEndorsementCalculationTypesRowChangeEventHandler(
    object sender,
    dsPropertyRater_Exposure.lstEndorsementCalculationTypesRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public delegate void tblClientOfficesRowChangeEventHandler(
    object sender,
    dsPropertyRater_Exposure.tblClientOfficesRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public delegate void lstDeductiblePerRowChangeEventHandler(
    object sender,
    dsPropertyRater_Exposure.lstDeductiblePerRowChangeEvent e);

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class tblUnderwritingLocationsDataTable : 
    TypedTableBase<dsPropertyRater_Exposure.tblUnderwritingLocationsRow>
  {
    private DataColumn columnLocationID;
    private DataColumn columnLocationNo;
    private DataColumn columnBuildingNo;
    private DataColumn columnPhysicalBuildingNo;
    private DataColumn columnAddress;
    private DataColumn columnCity;
    private DataColumn columnState;
    private DataColumn columnZip;
    private DataColumn columnTotalPremium;
    private DataColumn columnTerrPremium;
    private DataColumn columnModificationCode;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public tblUnderwritingLocationsDataTable()
    {
      this.TableName = "tblUnderwritingLocations";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal tblUnderwritingLocationsDataTable(DataTable table)
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
    protected tblUnderwritingLocationsDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn LocationIDColumn => this.columnLocationID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn LocationNoColumn => this.columnLocationNo;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn BuildingNoColumn => this.columnBuildingNo;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn PhysicalBuildingNoColumn => this.columnPhysicalBuildingNo;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn AddressColumn => this.columnAddress;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn CityColumn => this.columnCity;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn StateColumn => this.columnState;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ZipColumn => this.columnZip;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn TotalPremiumColumn => this.columnTotalPremium;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn TerrPremiumColumn => this.columnTerrPremium;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ModificationCodeColumn => this.columnModificationCode;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPropertyRater_Exposure.tblUnderwritingLocationsRow this[int index]
    {
      get => (dsPropertyRater_Exposure.tblUnderwritingLocationsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsPropertyRater_Exposure.tblUnderwritingLocationsRowChangeEventHandler tblUnderwritingLocationsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsPropertyRater_Exposure.tblUnderwritingLocationsRowChangeEventHandler tblUnderwritingLocationsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsPropertyRater_Exposure.tblUnderwritingLocationsRowChangeEventHandler tblUnderwritingLocationsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsPropertyRater_Exposure.tblUnderwritingLocationsRowChangeEventHandler tblUnderwritingLocationsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AddtblUnderwritingLocationsRow(
      dsPropertyRater_Exposure.tblUnderwritingLocationsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPropertyRater_Exposure.tblUnderwritingLocationsRow AddtblUnderwritingLocationsRow(
      int LocationNo,
      string BuildingNo,
      string PhysicalBuildingNo,
      string Address,
      string City,
      string State,
      string Zip,
      Decimal TotalPremium,
      Decimal TerrPremium,
      string ModificationCode)
    {
      dsPropertyRater_Exposure.tblUnderwritingLocationsRow row = (dsPropertyRater_Exposure.tblUnderwritingLocationsRow) this.NewRow();
      object[] objArray = new object[11]
      {
        null,
        (object) LocationNo,
        (object) BuildingNo,
        (object) PhysicalBuildingNo,
        (object) Address,
        (object) City,
        (object) State,
        (object) Zip,
        (object) TotalPremium,
        (object) TerrPremium,
        (object) ModificationCode
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPropertyRater_Exposure.tblUnderwritingLocationsRow FindByLocationID(int LocationID)
    {
      return (dsPropertyRater_Exposure.tblUnderwritingLocationsRow) this.Rows.Find(new object[1]
      {
        (object) LocationID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsPropertyRater_Exposure.tblUnderwritingLocationsDataTable locationsDataTable = (dsPropertyRater_Exposure.tblUnderwritingLocationsDataTable) base.Clone();
      locationsDataTable.InitVars();
      return (DataTable) locationsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsPropertyRater_Exposure.tblUnderwritingLocationsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal void InitVars()
    {
      this.columnLocationID = this.Columns["LocationID"];
      this.columnLocationNo = this.Columns["LocationNo"];
      this.columnBuildingNo = this.Columns["BuildingNo"];
      this.columnPhysicalBuildingNo = this.Columns["PhysicalBuildingNo"];
      this.columnAddress = this.Columns["Address"];
      this.columnCity = this.Columns["City"];
      this.columnState = this.Columns["State"];
      this.columnZip = this.Columns["Zip"];
      this.columnTotalPremium = this.Columns["TotalPremium"];
      this.columnTerrPremium = this.Columns["TerrPremium"];
      this.columnModificationCode = this.Columns["ModificationCode"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.columnLocationID = new DataColumn("LocationID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLocationID);
      this.columnLocationNo = new DataColumn("LocationNo", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLocationNo);
      this.columnBuildingNo = new DataColumn("BuildingNo", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnBuildingNo);
      this.columnPhysicalBuildingNo = new DataColumn("PhysicalBuildingNo", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPhysicalBuildingNo);
      this.columnAddress = new DataColumn("Address", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAddress);
      this.columnCity = new DataColumn("City", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCity);
      this.columnState = new DataColumn("State", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnState);
      this.columnZip = new DataColumn("Zip", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnZip);
      this.columnTotalPremium = new DataColumn("TotalPremium", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnTotalPremium);
      this.columnTerrPremium = new DataColumn("TerrPremium", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnTerrPremium);
      this.columnModificationCode = new DataColumn("ModificationCode", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnModificationCode);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsPropertyRater_ExposureKey1", new DataColumn[1]
      {
        this.columnLocationID
      }, true));
      this.columnLocationID.AutoIncrement = true;
      this.columnLocationID.AllowDBNull = false;
      this.columnLocationID.ReadOnly = true;
      this.columnLocationID.Unique = true;
      this.columnLocationNo.AllowDBNull = false;
      this.columnBuildingNo.AllowDBNull = false;
      this.columnPhysicalBuildingNo.AllowDBNull = false;
      this.columnAddress.ReadOnly = true;
      this.columnCity.AllowDBNull = false;
      this.columnState.AllowDBNull = false;
      this.columnZip.AllowDBNull = false;
      this.columnTotalPremium.AllowDBNull = false;
      this.columnTotalPremium.DefaultValue = (object) 0M;
      this.columnTerrPremium.AllowDBNull = false;
      this.columnTerrPremium.DefaultValue = (object) 0M;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPropertyRater_Exposure.tblUnderwritingLocationsRow NewtblUnderwritingLocationsRow()
    {
      return (dsPropertyRater_Exposure.tblUnderwritingLocationsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsPropertyRater_Exposure.tblUnderwritingLocationsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType()
    {
      return typeof (dsPropertyRater_Exposure.tblUnderwritingLocationsRow);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblUnderwritingLocationsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPropertyRater_Exposure.tblUnderwritingLocationsRowChangeEventHandler locationsRowChangedEvent = this.tblUnderwritingLocationsRowChangedEvent;
      if (locationsRowChangedEvent == null)
        return;
      locationsRowChangedEvent((object) this, new dsPropertyRater_Exposure.tblUnderwritingLocationsRowChangeEvent((dsPropertyRater_Exposure.tblUnderwritingLocationsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblUnderwritingLocationsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPropertyRater_Exposure.tblUnderwritingLocationsRowChangeEventHandler rowChangingEvent = this.tblUnderwritingLocationsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsPropertyRater_Exposure.tblUnderwritingLocationsRowChangeEvent((dsPropertyRater_Exposure.tblUnderwritingLocationsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblUnderwritingLocationsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPropertyRater_Exposure.tblUnderwritingLocationsRowChangeEventHandler locationsRowDeletedEvent = this.tblUnderwritingLocationsRowDeletedEvent;
      if (locationsRowDeletedEvent == null)
        return;
      locationsRowDeletedEvent((object) this, new dsPropertyRater_Exposure.tblUnderwritingLocationsRowChangeEvent((dsPropertyRater_Exposure.tblUnderwritingLocationsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblUnderwritingLocationsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPropertyRater_Exposure.tblUnderwritingLocationsRowChangeEventHandler rowDeletingEvent = this.tblUnderwritingLocationsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsPropertyRater_Exposure.tblUnderwritingLocationsRowChangeEvent((dsPropertyRater_Exposure.tblUnderwritingLocationsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemovetblUnderwritingLocationsRow(
      dsPropertyRater_Exposure.tblUnderwritingLocationsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsPropertyRater_Exposure propertyRaterExposure = new dsPropertyRater_Exposure();
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
        FixedValue = propertyRaterExposure.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblUnderwritingLocationsDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = propertyRaterExposure.GetSchemaSerializable();
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
  public class lstPropRater_CoinsuranceDataTable : 
    TypedTableBase<dsPropertyRater_Exposure.lstPropRater_CoinsuranceRow>
  {
    private DataColumn columnID;
    private DataColumn columnCoIns;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public lstPropRater_CoinsuranceDataTable()
    {
      this.TableName = "lstPropRater_Coinsurance";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal lstPropRater_CoinsuranceDataTable(DataTable table)
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
    protected lstPropRater_CoinsuranceDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn IDColumn => this.columnID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn CoInsColumn => this.columnCoIns;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPropertyRater_Exposure.lstPropRater_CoinsuranceRow this[int index]
    {
      get => (dsPropertyRater_Exposure.lstPropRater_CoinsuranceRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsPropertyRater_Exposure.lstPropRater_CoinsuranceRowChangeEventHandler lstPropRater_CoinsuranceRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsPropertyRater_Exposure.lstPropRater_CoinsuranceRowChangeEventHandler lstPropRater_CoinsuranceRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsPropertyRater_Exposure.lstPropRater_CoinsuranceRowChangeEventHandler lstPropRater_CoinsuranceRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsPropertyRater_Exposure.lstPropRater_CoinsuranceRowChangeEventHandler lstPropRater_CoinsuranceRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AddlstPropRater_CoinsuranceRow(
      dsPropertyRater_Exposure.lstPropRater_CoinsuranceRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPropertyRater_Exposure.lstPropRater_CoinsuranceRow AddlstPropRater_CoinsuranceRow(
      int ID,
      string CoIns)
    {
      dsPropertyRater_Exposure.lstPropRater_CoinsuranceRow row = (dsPropertyRater_Exposure.lstPropRater_CoinsuranceRow) this.NewRow();
      object[] objArray = new object[2]
      {
        (object) ID,
        (object) CoIns
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPropertyRater_Exposure.lstPropRater_CoinsuranceRow FindByID(int ID)
    {
      return (dsPropertyRater_Exposure.lstPropRater_CoinsuranceRow) this.Rows.Find(new object[1]
      {
        (object) ID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsPropertyRater_Exposure.lstPropRater_CoinsuranceDataTable coinsuranceDataTable = (dsPropertyRater_Exposure.lstPropRater_CoinsuranceDataTable) base.Clone();
      coinsuranceDataTable.InitVars();
      return (DataTable) coinsuranceDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsPropertyRater_Exposure.lstPropRater_CoinsuranceDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal void InitVars()
    {
      this.columnID = this.Columns["ID"];
      this.columnCoIns = this.Columns["CoIns"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.columnID = new DataColumn("ID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnID);
      this.columnCoIns = new DataColumn("CoIns", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCoIns);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsPropertyRater_ExposureKey2", new DataColumn[1]
      {
        this.columnID
      }, true));
      this.columnID.AllowDBNull = false;
      this.columnID.ReadOnly = true;
      this.columnID.Unique = true;
      this.columnCoIns.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPropertyRater_Exposure.lstPropRater_CoinsuranceRow NewlstPropRater_CoinsuranceRow()
    {
      return (dsPropertyRater_Exposure.lstPropRater_CoinsuranceRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsPropertyRater_Exposure.lstPropRater_CoinsuranceRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType()
    {
      return typeof (dsPropertyRater_Exposure.lstPropRater_CoinsuranceRow);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstPropRater_CoinsuranceRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPropertyRater_Exposure.lstPropRater_CoinsuranceRowChangeEventHandler coinsuranceRowChangedEvent = this.lstPropRater_CoinsuranceRowChangedEvent;
      if (coinsuranceRowChangedEvent == null)
        return;
      coinsuranceRowChangedEvent((object) this, new dsPropertyRater_Exposure.lstPropRater_CoinsuranceRowChangeEvent((dsPropertyRater_Exposure.lstPropRater_CoinsuranceRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstPropRater_CoinsuranceRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPropertyRater_Exposure.lstPropRater_CoinsuranceRowChangeEventHandler rowChangingEvent = this.lstPropRater_CoinsuranceRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsPropertyRater_Exposure.lstPropRater_CoinsuranceRowChangeEvent((dsPropertyRater_Exposure.lstPropRater_CoinsuranceRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstPropRater_CoinsuranceRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPropertyRater_Exposure.lstPropRater_CoinsuranceRowChangeEventHandler coinsuranceRowDeletedEvent = this.lstPropRater_CoinsuranceRowDeletedEvent;
      if (coinsuranceRowDeletedEvent == null)
        return;
      coinsuranceRowDeletedEvent((object) this, new dsPropertyRater_Exposure.lstPropRater_CoinsuranceRowChangeEvent((dsPropertyRater_Exposure.lstPropRater_CoinsuranceRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstPropRater_CoinsuranceRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPropertyRater_Exposure.lstPropRater_CoinsuranceRowChangeEventHandler rowDeletingEvent = this.lstPropRater_CoinsuranceRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsPropertyRater_Exposure.lstPropRater_CoinsuranceRowChangeEvent((dsPropertyRater_Exposure.lstPropRater_CoinsuranceRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemovelstPropRater_CoinsuranceRow(
      dsPropertyRater_Exposure.lstPropRater_CoinsuranceRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsPropertyRater_Exposure propertyRaterExposure = new dsPropertyRater_Exposure();
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
        FixedValue = propertyRaterExposure.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (lstPropRater_CoinsuranceDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = propertyRaterExposure.GetSchemaSerializable();
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
  public class lstPropRater_CoverageTypesDataTable : 
    TypedTableBase<dsPropertyRater_Exposure.lstPropRater_CoverageTypesRow>
  {
    private DataColumn columnID;
    private DataColumn columnCoverage;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public lstPropRater_CoverageTypesDataTable()
    {
      this.TableName = "lstPropRater_CoverageTypes";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal lstPropRater_CoverageTypesDataTable(DataTable table)
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
    protected lstPropRater_CoverageTypesDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn IDColumn => this.columnID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn CoverageColumn => this.columnCoverage;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPropertyRater_Exposure.lstPropRater_CoverageTypesRow this[int index]
    {
      get => (dsPropertyRater_Exposure.lstPropRater_CoverageTypesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsPropertyRater_Exposure.lstPropRater_CoverageTypesRowChangeEventHandler lstPropRater_CoverageTypesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsPropertyRater_Exposure.lstPropRater_CoverageTypesRowChangeEventHandler lstPropRater_CoverageTypesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsPropertyRater_Exposure.lstPropRater_CoverageTypesRowChangeEventHandler lstPropRater_CoverageTypesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsPropertyRater_Exposure.lstPropRater_CoverageTypesRowChangeEventHandler lstPropRater_CoverageTypesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AddlstPropRater_CoverageTypesRow(
      dsPropertyRater_Exposure.lstPropRater_CoverageTypesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPropertyRater_Exposure.lstPropRater_CoverageTypesRow AddlstPropRater_CoverageTypesRow(
      int ID,
      string Coverage)
    {
      dsPropertyRater_Exposure.lstPropRater_CoverageTypesRow row = (dsPropertyRater_Exposure.lstPropRater_CoverageTypesRow) this.NewRow();
      object[] objArray = new object[2]
      {
        (object) ID,
        (object) Coverage
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPropertyRater_Exposure.lstPropRater_CoverageTypesRow FindByID(int ID)
    {
      return (dsPropertyRater_Exposure.lstPropRater_CoverageTypesRow) this.Rows.Find(new object[1]
      {
        (object) ID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsPropertyRater_Exposure.lstPropRater_CoverageTypesDataTable coverageTypesDataTable = (dsPropertyRater_Exposure.lstPropRater_CoverageTypesDataTable) base.Clone();
      coverageTypesDataTable.InitVars();
      return (DataTable) coverageTypesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsPropertyRater_Exposure.lstPropRater_CoverageTypesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal void InitVars()
    {
      this.columnID = this.Columns["ID"];
      this.columnCoverage = this.Columns["Coverage"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.columnID = new DataColumn("ID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnID);
      this.columnCoverage = new DataColumn("Coverage", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCoverage);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsPropertyRater_ExposureKey3", new DataColumn[1]
      {
        this.columnID
      }, true));
      this.columnID.AllowDBNull = false;
      this.columnID.ReadOnly = true;
      this.columnID.Unique = true;
      this.columnCoverage.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPropertyRater_Exposure.lstPropRater_CoverageTypesRow NewlstPropRater_CoverageTypesRow()
    {
      return (dsPropertyRater_Exposure.lstPropRater_CoverageTypesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsPropertyRater_Exposure.lstPropRater_CoverageTypesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType()
    {
      return typeof (dsPropertyRater_Exposure.lstPropRater_CoverageTypesRow);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstPropRater_CoverageTypesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPropertyRater_Exposure.lstPropRater_CoverageTypesRowChangeEventHandler typesRowChangedEvent = this.lstPropRater_CoverageTypesRowChangedEvent;
      if (typesRowChangedEvent == null)
        return;
      typesRowChangedEvent((object) this, new dsPropertyRater_Exposure.lstPropRater_CoverageTypesRowChangeEvent((dsPropertyRater_Exposure.lstPropRater_CoverageTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstPropRater_CoverageTypesRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPropertyRater_Exposure.lstPropRater_CoverageTypesRowChangeEventHandler rowChangingEvent = this.lstPropRater_CoverageTypesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsPropertyRater_Exposure.lstPropRater_CoverageTypesRowChangeEvent((dsPropertyRater_Exposure.lstPropRater_CoverageTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstPropRater_CoverageTypesRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPropertyRater_Exposure.lstPropRater_CoverageTypesRowChangeEventHandler typesRowDeletedEvent = this.lstPropRater_CoverageTypesRowDeletedEvent;
      if (typesRowDeletedEvent == null)
        return;
      typesRowDeletedEvent((object) this, new dsPropertyRater_Exposure.lstPropRater_CoverageTypesRowChangeEvent((dsPropertyRater_Exposure.lstPropRater_CoverageTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstPropRater_CoverageTypesRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPropertyRater_Exposure.lstPropRater_CoverageTypesRowChangeEventHandler rowDeletingEvent = this.lstPropRater_CoverageTypesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsPropertyRater_Exposure.lstPropRater_CoverageTypesRowChangeEvent((dsPropertyRater_Exposure.lstPropRater_CoverageTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemovelstPropRater_CoverageTypesRow(
      dsPropertyRater_Exposure.lstPropRater_CoverageTypesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsPropertyRater_Exposure propertyRaterExposure = new dsPropertyRater_Exposure();
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
        FixedValue = propertyRaterExposure.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (lstPropRater_CoverageTypesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = propertyRaterExposure.GetSchemaSerializable();
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
  public class lstPropRater_CauseOfLossDataTable : 
    TypedTableBase<dsPropertyRater_Exposure.lstPropRater_CauseOfLossRow>
  {
    private DataColumn columnID;
    private DataColumn columnPeril;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public lstPropRater_CauseOfLossDataTable()
    {
      this.TableName = "lstPropRater_CauseOfLoss";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal lstPropRater_CauseOfLossDataTable(DataTable table)
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
    protected lstPropRater_CauseOfLossDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn IDColumn => this.columnID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn PerilColumn => this.columnPeril;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPropertyRater_Exposure.lstPropRater_CauseOfLossRow this[int index]
    {
      get => (dsPropertyRater_Exposure.lstPropRater_CauseOfLossRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsPropertyRater_Exposure.lstPropRater_CauseOfLossRowChangeEventHandler lstPropRater_CauseOfLossRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsPropertyRater_Exposure.lstPropRater_CauseOfLossRowChangeEventHandler lstPropRater_CauseOfLossRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsPropertyRater_Exposure.lstPropRater_CauseOfLossRowChangeEventHandler lstPropRater_CauseOfLossRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsPropertyRater_Exposure.lstPropRater_CauseOfLossRowChangeEventHandler lstPropRater_CauseOfLossRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AddlstPropRater_CauseOfLossRow(
      dsPropertyRater_Exposure.lstPropRater_CauseOfLossRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPropertyRater_Exposure.lstPropRater_CauseOfLossRow AddlstPropRater_CauseOfLossRow(
      int ID,
      string Peril)
    {
      dsPropertyRater_Exposure.lstPropRater_CauseOfLossRow row = (dsPropertyRater_Exposure.lstPropRater_CauseOfLossRow) this.NewRow();
      object[] objArray = new object[2]
      {
        (object) ID,
        (object) Peril
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPropertyRater_Exposure.lstPropRater_CauseOfLossRow FindByID(int ID)
    {
      return (dsPropertyRater_Exposure.lstPropRater_CauseOfLossRow) this.Rows.Find(new object[1]
      {
        (object) ID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsPropertyRater_Exposure.lstPropRater_CauseOfLossDataTable causeOfLossDataTable = (dsPropertyRater_Exposure.lstPropRater_CauseOfLossDataTable) base.Clone();
      causeOfLossDataTable.InitVars();
      return (DataTable) causeOfLossDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsPropertyRater_Exposure.lstPropRater_CauseOfLossDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal void InitVars()
    {
      this.columnID = this.Columns["ID"];
      this.columnPeril = this.Columns["Peril"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.columnID = new DataColumn("ID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnID);
      this.columnPeril = new DataColumn("Peril", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPeril);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsPropertyRater_ExposureKey4", new DataColumn[1]
      {
        this.columnID
      }, true));
      this.columnID.AllowDBNull = false;
      this.columnID.ReadOnly = true;
      this.columnID.Unique = true;
      this.columnPeril.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPropertyRater_Exposure.lstPropRater_CauseOfLossRow NewlstPropRater_CauseOfLossRow()
    {
      return (dsPropertyRater_Exposure.lstPropRater_CauseOfLossRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsPropertyRater_Exposure.lstPropRater_CauseOfLossRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType()
    {
      return typeof (dsPropertyRater_Exposure.lstPropRater_CauseOfLossRow);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstPropRater_CauseOfLossRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPropertyRater_Exposure.lstPropRater_CauseOfLossRowChangeEventHandler lossRowChangedEvent = this.lstPropRater_CauseOfLossRowChangedEvent;
      if (lossRowChangedEvent == null)
        return;
      lossRowChangedEvent((object) this, new dsPropertyRater_Exposure.lstPropRater_CauseOfLossRowChangeEvent((dsPropertyRater_Exposure.lstPropRater_CauseOfLossRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstPropRater_CauseOfLossRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPropertyRater_Exposure.lstPropRater_CauseOfLossRowChangeEventHandler rowChangingEvent = this.lstPropRater_CauseOfLossRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsPropertyRater_Exposure.lstPropRater_CauseOfLossRowChangeEvent((dsPropertyRater_Exposure.lstPropRater_CauseOfLossRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstPropRater_CauseOfLossRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPropertyRater_Exposure.lstPropRater_CauseOfLossRowChangeEventHandler lossRowDeletedEvent = this.lstPropRater_CauseOfLossRowDeletedEvent;
      if (lossRowDeletedEvent == null)
        return;
      lossRowDeletedEvent((object) this, new dsPropertyRater_Exposure.lstPropRater_CauseOfLossRowChangeEvent((dsPropertyRater_Exposure.lstPropRater_CauseOfLossRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstPropRater_CauseOfLossRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPropertyRater_Exposure.lstPropRater_CauseOfLossRowChangeEventHandler rowDeletingEvent = this.lstPropRater_CauseOfLossRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsPropertyRater_Exposure.lstPropRater_CauseOfLossRowChangeEvent((dsPropertyRater_Exposure.lstPropRater_CauseOfLossRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemovelstPropRater_CauseOfLossRow(
      dsPropertyRater_Exposure.lstPropRater_CauseOfLossRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsPropertyRater_Exposure propertyRaterExposure = new dsPropertyRater_Exposure();
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
        FixedValue = propertyRaterExposure.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (lstPropRater_CauseOfLossDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = propertyRaterExposure.GetSchemaSerializable();
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
  public class lstPropRater_ValuationDataTable : 
    TypedTableBase<dsPropertyRater_Exposure.lstPropRater_ValuationRow>
  {
    private DataColumn columnID;
    private DataColumn columnValuation;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public lstPropRater_ValuationDataTable()
    {
      this.TableName = "lstPropRater_Valuation";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal lstPropRater_ValuationDataTable(DataTable table)
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
    protected lstPropRater_ValuationDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn IDColumn => this.columnID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ValuationColumn => this.columnValuation;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPropertyRater_Exposure.lstPropRater_ValuationRow this[int index]
    {
      get => (dsPropertyRater_Exposure.lstPropRater_ValuationRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsPropertyRater_Exposure.lstPropRater_ValuationRowChangeEventHandler lstPropRater_ValuationRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsPropertyRater_Exposure.lstPropRater_ValuationRowChangeEventHandler lstPropRater_ValuationRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsPropertyRater_Exposure.lstPropRater_ValuationRowChangeEventHandler lstPropRater_ValuationRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsPropertyRater_Exposure.lstPropRater_ValuationRowChangeEventHandler lstPropRater_ValuationRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AddlstPropRater_ValuationRow(
      dsPropertyRater_Exposure.lstPropRater_ValuationRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPropertyRater_Exposure.lstPropRater_ValuationRow AddlstPropRater_ValuationRow(
      int ID,
      string Valuation)
    {
      dsPropertyRater_Exposure.lstPropRater_ValuationRow row = (dsPropertyRater_Exposure.lstPropRater_ValuationRow) this.NewRow();
      object[] objArray = new object[2]
      {
        (object) ID,
        (object) Valuation
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPropertyRater_Exposure.lstPropRater_ValuationRow FindByID(int ID)
    {
      return (dsPropertyRater_Exposure.lstPropRater_ValuationRow) this.Rows.Find(new object[1]
      {
        (object) ID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsPropertyRater_Exposure.lstPropRater_ValuationDataTable valuationDataTable = (dsPropertyRater_Exposure.lstPropRater_ValuationDataTable) base.Clone();
      valuationDataTable.InitVars();
      return (DataTable) valuationDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsPropertyRater_Exposure.lstPropRater_ValuationDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal void InitVars()
    {
      this.columnID = this.Columns["ID"];
      this.columnValuation = this.Columns["Valuation"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.columnID = new DataColumn("ID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnID);
      this.columnValuation = new DataColumn("Valuation", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnValuation);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsPropertyRater_ExposureKey5", new DataColumn[1]
      {
        this.columnID
      }, true));
      this.columnID.AllowDBNull = false;
      this.columnID.ReadOnly = true;
      this.columnID.Unique = true;
      this.columnValuation.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPropertyRater_Exposure.lstPropRater_ValuationRow NewlstPropRater_ValuationRow()
    {
      return (dsPropertyRater_Exposure.lstPropRater_ValuationRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsPropertyRater_Exposure.lstPropRater_ValuationRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType()
    {
      return typeof (dsPropertyRater_Exposure.lstPropRater_ValuationRow);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstPropRater_ValuationRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPropertyRater_Exposure.lstPropRater_ValuationRowChangeEventHandler valuationRowChangedEvent = this.lstPropRater_ValuationRowChangedEvent;
      if (valuationRowChangedEvent == null)
        return;
      valuationRowChangedEvent((object) this, new dsPropertyRater_Exposure.lstPropRater_ValuationRowChangeEvent((dsPropertyRater_Exposure.lstPropRater_ValuationRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstPropRater_ValuationRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPropertyRater_Exposure.lstPropRater_ValuationRowChangeEventHandler rowChangingEvent = this.lstPropRater_ValuationRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsPropertyRater_Exposure.lstPropRater_ValuationRowChangeEvent((dsPropertyRater_Exposure.lstPropRater_ValuationRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstPropRater_ValuationRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPropertyRater_Exposure.lstPropRater_ValuationRowChangeEventHandler valuationRowDeletedEvent = this.lstPropRater_ValuationRowDeletedEvent;
      if (valuationRowDeletedEvent == null)
        return;
      valuationRowDeletedEvent((object) this, new dsPropertyRater_Exposure.lstPropRater_ValuationRowChangeEvent((dsPropertyRater_Exposure.lstPropRater_ValuationRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstPropRater_ValuationRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPropertyRater_Exposure.lstPropRater_ValuationRowChangeEventHandler rowDeletingEvent = this.lstPropRater_ValuationRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsPropertyRater_Exposure.lstPropRater_ValuationRowChangeEvent((dsPropertyRater_Exposure.lstPropRater_ValuationRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemovelstPropRater_ValuationRow(
      dsPropertyRater_Exposure.lstPropRater_ValuationRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsPropertyRater_Exposure propertyRaterExposure = new dsPropertyRater_Exposure();
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
        FixedValue = propertyRaterExposure.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (lstPropRater_ValuationDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = propertyRaterExposure.GetSchemaSerializable();
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
  public class tblPropertyExposureDataTable : 
    TypedTableBase<dsPropertyRater_Exposure.tblPropertyExposureRow>
  {
    private DataColumn columnExposureID;
    private DataColumn columnOriginalExposureID;
    private DataColumn columnLocationID;
    private DataColumn columnQuoteOptionID;
    private DataColumn columnTotalNonTerrorPremium;
    private DataColumn columnPrimaryPremium;
    private DataColumn columnExcessPremium;
    private DataColumn columnTerrPremium;
    private DataColumn columnTerrorPrimary;
    private DataColumn columnTerrorExcess;
    private DataColumn columnModificationCode;
    private DataColumn columnEndorsementCalcType;
    private DataColumn columnFactor;
    private DataColumn columnEffectiveDate;
    private DataColumn columnUserAdded;
    private DataColumn columnOfficeID;
    private DataColumn columnCoverageID;
    private DataColumn columnCoInsuranceID;
    private DataColumn columnValuationID;
    private DataColumn columnCauseOfLossID;
    private DataColumn columnDeductible;
    private DataColumn columnDeductiblePerID;
    private DataColumn columnLimit;
    private DataColumn columnCoInsurance;
    private DataColumn columnAccountRate;
    private DataColumn columnPrimaryRate;
    private DataColumn columnExcessRate;
    private DataColumn columnTerrRate;
    private DataColumn columnUserOverrideFactor;
    private DataColumn columnOtherDeductibles;
    private DataColumn columnPremiumsWaived;
    private DataColumn columnSelected;
    private DataColumn columnAdditionalInfo;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public tblPropertyExposureDataTable()
    {
      this.TableName = "tblPropertyExposure";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal tblPropertyExposureDataTable(DataTable table)
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
    protected tblPropertyExposureDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ExposureIDColumn => this.columnExposureID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn OriginalExposureIDColumn => this.columnOriginalExposureID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn LocationIDColumn => this.columnLocationID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn QuoteOptionIDColumn => this.columnQuoteOptionID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn TotalNonTerrorPremiumColumn => this.columnTotalNonTerrorPremium;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn PrimaryPremiumColumn => this.columnPrimaryPremium;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ExcessPremiumColumn => this.columnExcessPremium;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn TerrPremiumColumn => this.columnTerrPremium;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn TerrorPrimaryColumn => this.columnTerrorPrimary;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn TerrorExcessColumn => this.columnTerrorExcess;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ModificationCodeColumn => this.columnModificationCode;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn EndorsementCalcTypeColumn => this.columnEndorsementCalcType;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn FactorColumn => this.columnFactor;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn EffectiveDateColumn => this.columnEffectiveDate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn UserAddedColumn => this.columnUserAdded;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn OfficeIDColumn => this.columnOfficeID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn CoverageIDColumn => this.columnCoverageID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn CoInsuranceIDColumn => this.columnCoInsuranceID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ValuationIDColumn => this.columnValuationID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn CauseOfLossIDColumn => this.columnCauseOfLossID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn DeductibleColumn => this.columnDeductible;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn DeductiblePerIDColumn => this.columnDeductiblePerID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn LimitColumn => this.columnLimit;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn CoInsuranceColumn => this.columnCoInsurance;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn AccountRateColumn => this.columnAccountRate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn PrimaryRateColumn => this.columnPrimaryRate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ExcessRateColumn => this.columnExcessRate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn TerrRateColumn => this.columnTerrRate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn UserOverrideFactorColumn => this.columnUserOverrideFactor;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn OtherDeductiblesColumn => this.columnOtherDeductibles;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn PremiumsWaivedColumn => this.columnPremiumsWaived;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn SelectedColumn => this.columnSelected;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn AdditionalInfoColumn => this.columnAdditionalInfo;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPropertyRater_Exposure.tblPropertyExposureRow this[int index]
    {
      get => (dsPropertyRater_Exposure.tblPropertyExposureRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsPropertyRater_Exposure.tblPropertyExposureRowChangeEventHandler tblPropertyExposureRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsPropertyRater_Exposure.tblPropertyExposureRowChangeEventHandler tblPropertyExposureRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsPropertyRater_Exposure.tblPropertyExposureRowChangeEventHandler tblPropertyExposureRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsPropertyRater_Exposure.tblPropertyExposureRowChangeEventHandler tblPropertyExposureRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AddtblPropertyExposureRow(
      dsPropertyRater_Exposure.tblPropertyExposureRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPropertyRater_Exposure.tblPropertyExposureRow AddtblPropertyExposureRow(
      int OriginalExposureID,
      dsPropertyRater_Exposure.tblUnderwritingLocationsRow parenttblUnderwritingLocationsRowBytblUnderwritingLocationstblPropertyExposure,
      int QuoteOptionID,
      Decimal TotalNonTerrorPremium,
      Decimal PrimaryPremium,
      Decimal ExcessPremium,
      Decimal TerrPremium,
      Decimal TerrorPrimary,
      Decimal TerrorExcess,
      string ModificationCode,
      string EndorsementCalcType,
      Decimal Factor,
      DateTime EffectiveDate,
      Guid UserAdded,
      dsPropertyRater_Exposure.tblClientOfficesRow parenttblClientOfficesRowBytblClientOfficestblPropertyExposure,
      int CoverageID,
      int CoInsuranceID,
      int ValuationID,
      int CauseOfLossID,
      int Deductible,
      dsPropertyRater_Exposure.lstDeductiblePerRow parentlstDeductiblePerRowBylstDeductiblePertblPropertyExposure,
      Decimal Limit,
      string CoInsurance,
      Decimal AccountRate,
      Decimal PrimaryRate,
      Decimal ExcessRate,
      Decimal TerrRate,
      Decimal UserOverrideFactor,
      string OtherDeductibles,
      bool PremiumsWaived,
      bool Selected,
      string AdditionalInfo)
    {
      dsPropertyRater_Exposure.tblPropertyExposureRow row = (dsPropertyRater_Exposure.tblPropertyExposureRow) this.NewRow();
      object[] objArray = new object[33]
      {
        null,
        (object) OriginalExposureID,
        null,
        (object) QuoteOptionID,
        (object) TotalNonTerrorPremium,
        (object) PrimaryPremium,
        (object) ExcessPremium,
        (object) TerrPremium,
        (object) TerrorPrimary,
        (object) TerrorExcess,
        (object) ModificationCode,
        (object) EndorsementCalcType,
        (object) Factor,
        (object) EffectiveDate,
        (object) UserAdded,
        null,
        (object) CoverageID,
        (object) CoInsuranceID,
        (object) ValuationID,
        (object) CauseOfLossID,
        (object) Deductible,
        null,
        (object) Limit,
        (object) CoInsurance,
        (object) AccountRate,
        (object) PrimaryRate,
        (object) ExcessRate,
        (object) TerrRate,
        (object) UserOverrideFactor,
        (object) OtherDeductibles,
        (object) PremiumsWaived,
        (object) Selected,
        (object) AdditionalInfo
      };
      if (parenttblUnderwritingLocationsRowBytblUnderwritingLocationstblPropertyExposure != null)
        objArray[2] = RuntimeHelpers.GetObjectValue(parenttblUnderwritingLocationsRowBytblUnderwritingLocationstblPropertyExposure[0]);
      if (parenttblClientOfficesRowBytblClientOfficestblPropertyExposure != null)
        objArray[15] = RuntimeHelpers.GetObjectValue(parenttblClientOfficesRowBytblClientOfficestblPropertyExposure[0]);
      if (parentlstDeductiblePerRowBylstDeductiblePertblPropertyExposure != null)
        objArray[21] = RuntimeHelpers.GetObjectValue(parentlstDeductiblePerRowBylstDeductiblePertblPropertyExposure[0]);
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPropertyRater_Exposure.tblPropertyExposureRow FindByExposureID(int ExposureID)
    {
      return (dsPropertyRater_Exposure.tblPropertyExposureRow) this.Rows.Find(new object[1]
      {
        (object) ExposureID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsPropertyRater_Exposure.tblPropertyExposureDataTable exposureDataTable = (dsPropertyRater_Exposure.tblPropertyExposureDataTable) base.Clone();
      exposureDataTable.InitVars();
      return (DataTable) exposureDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsPropertyRater_Exposure.tblPropertyExposureDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal void InitVars()
    {
      this.columnExposureID = this.Columns["ExposureID"];
      this.columnOriginalExposureID = this.Columns["OriginalExposureID"];
      this.columnLocationID = this.Columns["LocationID"];
      this.columnQuoteOptionID = this.Columns["QuoteOptionID"];
      this.columnTotalNonTerrorPremium = this.Columns["TotalNonTerrorPremium"];
      this.columnPrimaryPremium = this.Columns["PrimaryPremium"];
      this.columnExcessPremium = this.Columns["ExcessPremium"];
      this.columnTerrPremium = this.Columns["TerrPremium"];
      this.columnTerrorPrimary = this.Columns["TerrorPrimary"];
      this.columnTerrorExcess = this.Columns["TerrorExcess"];
      this.columnModificationCode = this.Columns["ModificationCode"];
      this.columnEndorsementCalcType = this.Columns["EndorsementCalcType"];
      this.columnFactor = this.Columns["Factor"];
      this.columnEffectiveDate = this.Columns["EffectiveDate"];
      this.columnUserAdded = this.Columns["UserAdded"];
      this.columnOfficeID = this.Columns["OfficeID"];
      this.columnCoverageID = this.Columns["CoverageID"];
      this.columnCoInsuranceID = this.Columns["CoInsuranceID"];
      this.columnValuationID = this.Columns["ValuationID"];
      this.columnCauseOfLossID = this.Columns["CauseOfLossID"];
      this.columnDeductible = this.Columns["Deductible"];
      this.columnDeductiblePerID = this.Columns["DeductiblePerID"];
      this.columnLimit = this.Columns["Limit"];
      this.columnCoInsurance = this.Columns["CoInsurance"];
      this.columnAccountRate = this.Columns["AccountRate"];
      this.columnPrimaryRate = this.Columns["PrimaryRate"];
      this.columnExcessRate = this.Columns["ExcessRate"];
      this.columnTerrRate = this.Columns["TerrRate"];
      this.columnUserOverrideFactor = this.Columns["UserOverrideFactor"];
      this.columnOtherDeductibles = this.Columns["OtherDeductibles"];
      this.columnPremiumsWaived = this.Columns["PremiumsWaived"];
      this.columnSelected = this.Columns["Selected"];
      this.columnAdditionalInfo = this.Columns["AdditionalInfo"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.columnExposureID = new DataColumn("ExposureID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnExposureID);
      this.columnOriginalExposureID = new DataColumn("OriginalExposureID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnOriginalExposureID);
      this.columnLocationID = new DataColumn("LocationID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLocationID);
      this.columnQuoteOptionID = new DataColumn("QuoteOptionID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnQuoteOptionID);
      this.columnTotalNonTerrorPremium = new DataColumn("TotalNonTerrorPremium", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnTotalNonTerrorPremium);
      this.columnPrimaryPremium = new DataColumn("PrimaryPremium", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPrimaryPremium);
      this.columnExcessPremium = new DataColumn("ExcessPremium", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnExcessPremium);
      this.columnTerrPremium = new DataColumn("TerrPremium", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnTerrPremium);
      this.columnTerrorPrimary = new DataColumn("TerrorPrimary", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnTerrorPrimary);
      this.columnTerrorExcess = new DataColumn("TerrorExcess", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnTerrorExcess);
      this.columnModificationCode = new DataColumn("ModificationCode", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnModificationCode);
      this.columnEndorsementCalcType = new DataColumn("EndorsementCalcType", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEndorsementCalcType);
      this.columnFactor = new DataColumn("Factor", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnFactor);
      this.columnEffectiveDate = new DataColumn("EffectiveDate", typeof (DateTime), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEffectiveDate);
      this.columnUserAdded = new DataColumn("UserAdded", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnUserAdded);
      this.columnOfficeID = new DataColumn("OfficeID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnOfficeID);
      this.columnCoverageID = new DataColumn("CoverageID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCoverageID);
      this.columnCoInsuranceID = new DataColumn("CoInsuranceID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCoInsuranceID);
      this.columnValuationID = new DataColumn("ValuationID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnValuationID);
      this.columnCauseOfLossID = new DataColumn("CauseOfLossID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCauseOfLossID);
      this.columnDeductible = new DataColumn("Deductible", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDeductible);
      this.columnDeductiblePerID = new DataColumn("DeductiblePerID", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDeductiblePerID);
      this.columnLimit = new DataColumn("Limit", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLimit);
      this.columnCoInsurance = new DataColumn("CoInsurance", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCoInsurance);
      this.columnAccountRate = new DataColumn("AccountRate", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAccountRate);
      this.columnPrimaryRate = new DataColumn("PrimaryRate", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPrimaryRate);
      this.columnExcessRate = new DataColumn("ExcessRate", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnExcessRate);
      this.columnTerrRate = new DataColumn("TerrRate", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnTerrRate);
      this.columnUserOverrideFactor = new DataColumn("UserOverrideFactor", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnUserOverrideFactor);
      this.columnOtherDeductibles = new DataColumn("OtherDeductibles", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnOtherDeductibles);
      this.columnPremiumsWaived = new DataColumn("PremiumsWaived", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPremiumsWaived);
      this.columnSelected = new DataColumn("Selected", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSelected);
      this.columnAdditionalInfo = new DataColumn("AdditionalInfo", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAdditionalInfo);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsPropertyRater_ExposureKey7", new DataColumn[1]
      {
        this.columnExposureID
      }, true));
      this.columnExposureID.AutoIncrement = true;
      this.columnExposureID.AllowDBNull = false;
      this.columnExposureID.ReadOnly = true;
      this.columnExposureID.Unique = true;
      this.columnLocationID.AllowDBNull = false;
      this.columnQuoteOptionID.AllowDBNull = false;
      this.columnTotalNonTerrorPremium.AllowDBNull = false;
      this.columnTotalNonTerrorPremium.DefaultValue = (object) 0M;
      this.columnPrimaryPremium.AllowDBNull = false;
      this.columnPrimaryPremium.DefaultValue = (object) 0M;
      this.columnExcessPremium.AllowDBNull = false;
      this.columnExcessPremium.DefaultValue = (object) 0M;
      this.columnTerrPremium.AllowDBNull = false;
      this.columnTerrPremium.DefaultValue = (object) 0M;
      this.columnTerrorPrimary.AllowDBNull = false;
      this.columnTerrorPrimary.DefaultValue = (object) 0M;
      this.columnTerrorExcess.AllowDBNull = false;
      this.columnTerrorExcess.DefaultValue = (object) 0M;
      this.columnDeductiblePerID.AllowDBNull = false;
      this.columnLimit.AllowDBNull = false;
      this.columnLimit.DefaultValue = (object) 0M;
      this.columnPrimaryRate.AllowDBNull = false;
      this.columnPrimaryRate.DefaultValue = (object) 0M;
      this.columnPremiumsWaived.AllowDBNull = false;
      this.columnPremiumsWaived.DefaultValue = (object) false;
      this.columnSelected.AllowDBNull = false;
      this.columnSelected.DefaultValue = (object) false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPropertyRater_Exposure.tblPropertyExposureRow NewtblPropertyExposureRow()
    {
      return (dsPropertyRater_Exposure.tblPropertyExposureRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsPropertyRater_Exposure.tblPropertyExposureRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType()
    {
      return typeof (dsPropertyRater_Exposure.tblPropertyExposureRow);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblPropertyExposureRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPropertyRater_Exposure.tblPropertyExposureRowChangeEventHandler exposureRowChangedEvent = this.tblPropertyExposureRowChangedEvent;
      if (exposureRowChangedEvent == null)
        return;
      exposureRowChangedEvent((object) this, new dsPropertyRater_Exposure.tblPropertyExposureRowChangeEvent((dsPropertyRater_Exposure.tblPropertyExposureRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblPropertyExposureRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPropertyRater_Exposure.tblPropertyExposureRowChangeEventHandler rowChangingEvent = this.tblPropertyExposureRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsPropertyRater_Exposure.tblPropertyExposureRowChangeEvent((dsPropertyRater_Exposure.tblPropertyExposureRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblPropertyExposureRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPropertyRater_Exposure.tblPropertyExposureRowChangeEventHandler exposureRowDeletedEvent = this.tblPropertyExposureRowDeletedEvent;
      if (exposureRowDeletedEvent == null)
        return;
      exposureRowDeletedEvent((object) this, new dsPropertyRater_Exposure.tblPropertyExposureRowChangeEvent((dsPropertyRater_Exposure.tblPropertyExposureRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblPropertyExposureRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPropertyRater_Exposure.tblPropertyExposureRowChangeEventHandler rowDeletingEvent = this.tblPropertyExposureRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsPropertyRater_Exposure.tblPropertyExposureRowChangeEvent((dsPropertyRater_Exposure.tblPropertyExposureRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemovetblPropertyExposureRow(
      dsPropertyRater_Exposure.tblPropertyExposureRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsPropertyRater_Exposure propertyRaterExposure = new dsPropertyRater_Exposure();
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
        FixedValue = propertyRaterExposure.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblPropertyExposureDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = propertyRaterExposure.GetSchemaSerializable();
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
    TypedTableBase<dsPropertyRater_Exposure.lstEndorsementCalculationTypesRow>
  {
    private DataColumn columnID;
    private DataColumn columnEndorsementCalcType;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public lstEndorsementCalculationTypesDataTable()
    {
      this.TableName = "lstEndorsementCalculationTypes";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected lstEndorsementCalculationTypesDataTable(
      SerializationInfo info,
      StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn IDColumn => this.columnID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn EndorsementCalcTypeColumn => this.columnEndorsementCalcType;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPropertyRater_Exposure.lstEndorsementCalculationTypesRow this[int index]
    {
      get => (dsPropertyRater_Exposure.lstEndorsementCalculationTypesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsPropertyRater_Exposure.lstEndorsementCalculationTypesRowChangeEventHandler lstEndorsementCalculationTypesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsPropertyRater_Exposure.lstEndorsementCalculationTypesRowChangeEventHandler lstEndorsementCalculationTypesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsPropertyRater_Exposure.lstEndorsementCalculationTypesRowChangeEventHandler lstEndorsementCalculationTypesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsPropertyRater_Exposure.lstEndorsementCalculationTypesRowChangeEventHandler lstEndorsementCalculationTypesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AddlstEndorsementCalculationTypesRow(
      dsPropertyRater_Exposure.lstEndorsementCalculationTypesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPropertyRater_Exposure.lstEndorsementCalculationTypesRow AddlstEndorsementCalculationTypesRow(
      string ID,
      string EndorsementCalcType)
    {
      dsPropertyRater_Exposure.lstEndorsementCalculationTypesRow row = (dsPropertyRater_Exposure.lstEndorsementCalculationTypesRow) this.NewRow();
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
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPropertyRater_Exposure.lstEndorsementCalculationTypesRow FindByID(string ID)
    {
      return (dsPropertyRater_Exposure.lstEndorsementCalculationTypesRow) this.Rows.Find(new object[1]
      {
        (object) ID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsPropertyRater_Exposure.lstEndorsementCalculationTypesDataTable calculationTypesDataTable = (dsPropertyRater_Exposure.lstEndorsementCalculationTypesDataTable) base.Clone();
      calculationTypesDataTable.InitVars();
      return (DataTable) calculationTypesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsPropertyRater_Exposure.lstEndorsementCalculationTypesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal void InitVars()
    {
      this.columnID = this.Columns["ID"];
      this.columnEndorsementCalcType = this.Columns["EndorsementCalcType"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.columnID = new DataColumn("ID", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnID);
      this.columnEndorsementCalcType = new DataColumn("EndorsementCalcType", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnEndorsementCalcType);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsPropertyRater_ExposureKey8", new DataColumn[1]
      {
        this.columnID
      }, true));
      this.columnID.AllowDBNull = false;
      this.columnID.Unique = true;
      this.columnEndorsementCalcType.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPropertyRater_Exposure.lstEndorsementCalculationTypesRow NewlstEndorsementCalculationTypesRow()
    {
      return (dsPropertyRater_Exposure.lstEndorsementCalculationTypesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsPropertyRater_Exposure.lstEndorsementCalculationTypesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType()
    {
      return typeof (dsPropertyRater_Exposure.lstEndorsementCalculationTypesRow);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstEndorsementCalculationTypesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPropertyRater_Exposure.lstEndorsementCalculationTypesRowChangeEventHandler typesRowChangedEvent = this.lstEndorsementCalculationTypesRowChangedEvent;
      if (typesRowChangedEvent == null)
        return;
      typesRowChangedEvent((object) this, new dsPropertyRater_Exposure.lstEndorsementCalculationTypesRowChangeEvent((dsPropertyRater_Exposure.lstEndorsementCalculationTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstEndorsementCalculationTypesRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPropertyRater_Exposure.lstEndorsementCalculationTypesRowChangeEventHandler rowChangingEvent = this.lstEndorsementCalculationTypesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsPropertyRater_Exposure.lstEndorsementCalculationTypesRowChangeEvent((dsPropertyRater_Exposure.lstEndorsementCalculationTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstEndorsementCalculationTypesRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPropertyRater_Exposure.lstEndorsementCalculationTypesRowChangeEventHandler typesRowDeletedEvent = this.lstEndorsementCalculationTypesRowDeletedEvent;
      if (typesRowDeletedEvent == null)
        return;
      typesRowDeletedEvent((object) this, new dsPropertyRater_Exposure.lstEndorsementCalculationTypesRowChangeEvent((dsPropertyRater_Exposure.lstEndorsementCalculationTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstEndorsementCalculationTypesRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPropertyRater_Exposure.lstEndorsementCalculationTypesRowChangeEventHandler rowDeletingEvent = this.lstEndorsementCalculationTypesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsPropertyRater_Exposure.lstEndorsementCalculationTypesRowChangeEvent((dsPropertyRater_Exposure.lstEndorsementCalculationTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemovelstEndorsementCalculationTypesRow(
      dsPropertyRater_Exposure.lstEndorsementCalculationTypesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsPropertyRater_Exposure propertyRaterExposure = new dsPropertyRater_Exposure();
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
        FixedValue = propertyRaterExposure.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (lstEndorsementCalculationTypesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = propertyRaterExposure.GetSchemaSerializable();
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
  public class tblClientOfficesDataTable : 
    TypedTableBase<dsPropertyRater_Exposure.tblClientOfficesRow>
  {
    private DataColumn columnOfficeID;
    private DataColumn columnLocation;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public tblClientOfficesDataTable()
    {
      this.TableName = "tblClientOffices";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal tblClientOfficesDataTable(DataTable table)
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
    protected tblClientOfficesDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn OfficeIDColumn => this.columnOfficeID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn LocationColumn => this.columnLocation;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPropertyRater_Exposure.tblClientOfficesRow this[int index]
    {
      get => (dsPropertyRater_Exposure.tblClientOfficesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsPropertyRater_Exposure.tblClientOfficesRowChangeEventHandler tblClientOfficesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsPropertyRater_Exposure.tblClientOfficesRowChangeEventHandler tblClientOfficesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsPropertyRater_Exposure.tblClientOfficesRowChangeEventHandler tblClientOfficesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsPropertyRater_Exposure.tblClientOfficesRowChangeEventHandler tblClientOfficesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AddtblClientOfficesRow(dsPropertyRater_Exposure.tblClientOfficesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPropertyRater_Exposure.tblClientOfficesRow AddtblClientOfficesRow(string Location)
    {
      dsPropertyRater_Exposure.tblClientOfficesRow row = (dsPropertyRater_Exposure.tblClientOfficesRow) this.NewRow();
      object[] objArray = new object[2]
      {
        null,
        (object) Location
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPropertyRater_Exposure.tblClientOfficesRow FindByOfficeID(int OfficeID)
    {
      return (dsPropertyRater_Exposure.tblClientOfficesRow) this.Rows.Find(new object[1]
      {
        (object) OfficeID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsPropertyRater_Exposure.tblClientOfficesDataTable officesDataTable = (dsPropertyRater_Exposure.tblClientOfficesDataTable) base.Clone();
      officesDataTable.InitVars();
      return (DataTable) officesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsPropertyRater_Exposure.tblClientOfficesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal void InitVars()
    {
      this.columnOfficeID = this.Columns["OfficeID"];
      this.columnLocation = this.Columns["Location"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.columnOfficeID = new DataColumn("OfficeID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnOfficeID);
      this.columnLocation = new DataColumn("Location", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLocation);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsPropertyRater_ExposureKey9", new DataColumn[1]
      {
        this.columnOfficeID
      }, true));
      this.columnOfficeID.AutoIncrement = true;
      this.columnOfficeID.AllowDBNull = false;
      this.columnOfficeID.ReadOnly = true;
      this.columnOfficeID.Unique = true;
      this.columnLocation.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPropertyRater_Exposure.tblClientOfficesRow NewtblClientOfficesRow()
    {
      return (dsPropertyRater_Exposure.tblClientOfficesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsPropertyRater_Exposure.tblClientOfficesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType() => typeof (dsPropertyRater_Exposure.tblClientOfficesRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblClientOfficesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPropertyRater_Exposure.tblClientOfficesRowChangeEventHandler officesRowChangedEvent = this.tblClientOfficesRowChangedEvent;
      if (officesRowChangedEvent == null)
        return;
      officesRowChangedEvent((object) this, new dsPropertyRater_Exposure.tblClientOfficesRowChangeEvent((dsPropertyRater_Exposure.tblClientOfficesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblClientOfficesRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPropertyRater_Exposure.tblClientOfficesRowChangeEventHandler rowChangingEvent = this.tblClientOfficesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsPropertyRater_Exposure.tblClientOfficesRowChangeEvent((dsPropertyRater_Exposure.tblClientOfficesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblClientOfficesRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPropertyRater_Exposure.tblClientOfficesRowChangeEventHandler officesRowDeletedEvent = this.tblClientOfficesRowDeletedEvent;
      if (officesRowDeletedEvent == null)
        return;
      officesRowDeletedEvent((object) this, new dsPropertyRater_Exposure.tblClientOfficesRowChangeEvent((dsPropertyRater_Exposure.tblClientOfficesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblClientOfficesRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPropertyRater_Exposure.tblClientOfficesRowChangeEventHandler rowDeletingEvent = this.tblClientOfficesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsPropertyRater_Exposure.tblClientOfficesRowChangeEvent((dsPropertyRater_Exposure.tblClientOfficesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemovetblClientOfficesRow(dsPropertyRater_Exposure.tblClientOfficesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsPropertyRater_Exposure propertyRaterExposure = new dsPropertyRater_Exposure();
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
        FixedValue = propertyRaterExposure.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblClientOfficesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = propertyRaterExposure.GetSchemaSerializable();
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
  public class lstDeductiblePerDataTable : 
    TypedTableBase<dsPropertyRater_Exposure.lstDeductiblePerRow>
  {
    private DataColumn columnPerID;
    private DataColumn columnDeductiblePer;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public lstDeductiblePerDataTable()
    {
      this.TableName = "lstDeductiblePer";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal lstDeductiblePerDataTable(DataTable table)
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
    protected lstDeductiblePerDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn PerIDColumn => this.columnPerID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn DeductiblePerColumn => this.columnDeductiblePer;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPropertyRater_Exposure.lstDeductiblePerRow this[int index]
    {
      get => (dsPropertyRater_Exposure.lstDeductiblePerRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsPropertyRater_Exposure.lstDeductiblePerRowChangeEventHandler lstDeductiblePerRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsPropertyRater_Exposure.lstDeductiblePerRowChangeEventHandler lstDeductiblePerRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsPropertyRater_Exposure.lstDeductiblePerRowChangeEventHandler lstDeductiblePerRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsPropertyRater_Exposure.lstDeductiblePerRowChangeEventHandler lstDeductiblePerRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AddlstDeductiblePerRow(dsPropertyRater_Exposure.lstDeductiblePerRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPropertyRater_Exposure.lstDeductiblePerRow AddlstDeductiblePerRow(
      string PerID,
      string DeductiblePer)
    {
      dsPropertyRater_Exposure.lstDeductiblePerRow row = (dsPropertyRater_Exposure.lstDeductiblePerRow) this.NewRow();
      object[] objArray = new object[2]
      {
        (object) PerID,
        (object) DeductiblePer
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPropertyRater_Exposure.lstDeductiblePerRow FindByPerID(string PerID)
    {
      return (dsPropertyRater_Exposure.lstDeductiblePerRow) this.Rows.Find(new object[1]
      {
        (object) PerID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsPropertyRater_Exposure.lstDeductiblePerDataTable deductiblePerDataTable = (dsPropertyRater_Exposure.lstDeductiblePerDataTable) base.Clone();
      deductiblePerDataTable.InitVars();
      return (DataTable) deductiblePerDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsPropertyRater_Exposure.lstDeductiblePerDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal void InitVars()
    {
      this.columnPerID = this.Columns["PerID"];
      this.columnDeductiblePer = this.Columns["DeductiblePer"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.columnPerID = new DataColumn("PerID", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPerID);
      this.columnDeductiblePer = new DataColumn("DeductiblePer", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDeductiblePer);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsPropertyRater_ExposureKey6", new DataColumn[1]
      {
        this.columnPerID
      }, true));
      this.columnPerID.AllowDBNull = false;
      this.columnPerID.Unique = true;
      this.columnDeductiblePer.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPropertyRater_Exposure.lstDeductiblePerRow NewlstDeductiblePerRow()
    {
      return (dsPropertyRater_Exposure.lstDeductiblePerRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsPropertyRater_Exposure.lstDeductiblePerRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType() => typeof (dsPropertyRater_Exposure.lstDeductiblePerRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstDeductiblePerRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPropertyRater_Exposure.lstDeductiblePerRowChangeEventHandler perRowChangedEvent = this.lstDeductiblePerRowChangedEvent;
      if (perRowChangedEvent == null)
        return;
      perRowChangedEvent((object) this, new dsPropertyRater_Exposure.lstDeductiblePerRowChangeEvent((dsPropertyRater_Exposure.lstDeductiblePerRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstDeductiblePerRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPropertyRater_Exposure.lstDeductiblePerRowChangeEventHandler rowChangingEvent = this.lstDeductiblePerRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsPropertyRater_Exposure.lstDeductiblePerRowChangeEvent((dsPropertyRater_Exposure.lstDeductiblePerRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstDeductiblePerRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPropertyRater_Exposure.lstDeductiblePerRowChangeEventHandler perRowDeletedEvent = this.lstDeductiblePerRowDeletedEvent;
      if (perRowDeletedEvent == null)
        return;
      perRowDeletedEvent((object) this, new dsPropertyRater_Exposure.lstDeductiblePerRowChangeEvent((dsPropertyRater_Exposure.lstDeductiblePerRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstDeductiblePerRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPropertyRater_Exposure.lstDeductiblePerRowChangeEventHandler rowDeletingEvent = this.lstDeductiblePerRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsPropertyRater_Exposure.lstDeductiblePerRowChangeEvent((dsPropertyRater_Exposure.lstDeductiblePerRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemovelstDeductiblePerRow(dsPropertyRater_Exposure.lstDeductiblePerRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsPropertyRater_Exposure propertyRaterExposure = new dsPropertyRater_Exposure();
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
        FixedValue = propertyRaterExposure.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (lstDeductiblePerDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = propertyRaterExposure.GetSchemaSerializable();
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

  public class tblUnderwritingLocationsRow : DataRow
  {
    private dsPropertyRater_Exposure.tblUnderwritingLocationsDataTable tabletblUnderwritingLocations;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal tblUnderwritingLocationsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblUnderwritingLocations = (dsPropertyRater_Exposure.tblUnderwritingLocationsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int LocationID
    {
      get => Conversions.ToInteger(this[this.tabletblUnderwritingLocations.LocationIDColumn]);
      set => this[this.tabletblUnderwritingLocations.LocationIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int LocationNo
    {
      get => Conversions.ToInteger(this[this.tabletblUnderwritingLocations.LocationNoColumn]);
      set => this[this.tabletblUnderwritingLocations.LocationNoColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string BuildingNo
    {
      get => Conversions.ToString(this[this.tabletblUnderwritingLocations.BuildingNoColumn]);
      set => this[this.tabletblUnderwritingLocations.BuildingNoColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string PhysicalBuildingNo
    {
      get
      {
        return Conversions.ToString(this[this.tabletblUnderwritingLocations.PhysicalBuildingNoColumn]);
      }
      set => this[this.tabletblUnderwritingLocations.PhysicalBuildingNoColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string Address
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblUnderwritingLocations.AddressColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Address' in table 'tblUnderwritingLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblUnderwritingLocations.AddressColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string City
    {
      get => Conversions.ToString(this[this.tabletblUnderwritingLocations.CityColumn]);
      set => this[this.tabletblUnderwritingLocations.CityColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string State
    {
      get => Conversions.ToString(this[this.tabletblUnderwritingLocations.StateColumn]);
      set => this[this.tabletblUnderwritingLocations.StateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string Zip
    {
      get => Conversions.ToString(this[this.tabletblUnderwritingLocations.ZipColumn]);
      set => this[this.tabletblUnderwritingLocations.ZipColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Decimal TotalPremium
    {
      get => Conversions.ToDecimal(this[this.tabletblUnderwritingLocations.TotalPremiumColumn]);
      set => this[this.tabletblUnderwritingLocations.TotalPremiumColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Decimal TerrPremium
    {
      get => Conversions.ToDecimal(this[this.tabletblUnderwritingLocations.TerrPremiumColumn]);
      set => this[this.tabletblUnderwritingLocations.TerrPremiumColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string ModificationCode
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblUnderwritingLocations.ModificationCodeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ModificationCode' in table 'tblUnderwritingLocations' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblUnderwritingLocations.ModificationCodeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsAddressNull() => this.IsNull(this.tabletblUnderwritingLocations.AddressColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetAddressNull()
    {
      this[this.tabletblUnderwritingLocations.AddressColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsModificationCodeNull()
    {
      return this.IsNull(this.tabletblUnderwritingLocations.ModificationCodeColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetModificationCodeNull()
    {
      this[this.tabletblUnderwritingLocations.ModificationCodeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPropertyRater_Exposure.tblPropertyExposureRow[] GettblPropertyExposureRows()
    {
      return this.Table.ChildRelations["tblUnderwritingLocationstblPropertyExposure"] != null ? (dsPropertyRater_Exposure.tblPropertyExposureRow[]) this.GetChildRows(this.Table.ChildRelations["tblUnderwritingLocationstblPropertyExposure"]) : new dsPropertyRater_Exposure.tblPropertyExposureRow[0];
    }
  }

  public class lstPropRater_CoinsuranceRow : DataRow
  {
    private dsPropertyRater_Exposure.lstPropRater_CoinsuranceDataTable tablelstPropRater_Coinsurance;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal lstPropRater_CoinsuranceRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablelstPropRater_Coinsurance = (dsPropertyRater_Exposure.lstPropRater_CoinsuranceDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int ID
    {
      get => Conversions.ToInteger(this[this.tablelstPropRater_Coinsurance.IDColumn]);
      set => this[this.tablelstPropRater_Coinsurance.IDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string CoIns
    {
      get => Conversions.ToString(this[this.tablelstPropRater_Coinsurance.CoInsColumn]);
      set => this[this.tablelstPropRater_Coinsurance.CoInsColumn] = (object) value;
    }
  }

  public class lstPropRater_CoverageTypesRow : DataRow
  {
    private dsPropertyRater_Exposure.lstPropRater_CoverageTypesDataTable tablelstPropRater_CoverageTypes;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal lstPropRater_CoverageTypesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablelstPropRater_CoverageTypes = (dsPropertyRater_Exposure.lstPropRater_CoverageTypesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int ID
    {
      get => Conversions.ToInteger(this[this.tablelstPropRater_CoverageTypes.IDColumn]);
      set => this[this.tablelstPropRater_CoverageTypes.IDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string Coverage
    {
      get => Conversions.ToString(this[this.tablelstPropRater_CoverageTypes.CoverageColumn]);
      set => this[this.tablelstPropRater_CoverageTypes.CoverageColumn] = (object) value;
    }
  }

  public class lstPropRater_CauseOfLossRow : DataRow
  {
    private dsPropertyRater_Exposure.lstPropRater_CauseOfLossDataTable tablelstPropRater_CauseOfLoss;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal lstPropRater_CauseOfLossRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablelstPropRater_CauseOfLoss = (dsPropertyRater_Exposure.lstPropRater_CauseOfLossDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int ID
    {
      get => Conversions.ToInteger(this[this.tablelstPropRater_CauseOfLoss.IDColumn]);
      set => this[this.tablelstPropRater_CauseOfLoss.IDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string Peril
    {
      get => Conversions.ToString(this[this.tablelstPropRater_CauseOfLoss.PerilColumn]);
      set => this[this.tablelstPropRater_CauseOfLoss.PerilColumn] = (object) value;
    }
  }

  public class lstPropRater_ValuationRow : DataRow
  {
    private dsPropertyRater_Exposure.lstPropRater_ValuationDataTable tablelstPropRater_Valuation;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal lstPropRater_ValuationRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablelstPropRater_Valuation = (dsPropertyRater_Exposure.lstPropRater_ValuationDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int ID
    {
      get => Conversions.ToInteger(this[this.tablelstPropRater_Valuation.IDColumn]);
      set => this[this.tablelstPropRater_Valuation.IDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string Valuation
    {
      get => Conversions.ToString(this[this.tablelstPropRater_Valuation.ValuationColumn]);
      set => this[this.tablelstPropRater_Valuation.ValuationColumn] = (object) value;
    }
  }

  public class tblPropertyExposureRow : DataRow
  {
    private dsPropertyRater_Exposure.tblPropertyExposureDataTable tabletblPropertyExposure;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal tblPropertyExposureRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblPropertyExposure = (dsPropertyRater_Exposure.tblPropertyExposureDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int ExposureID
    {
      get => Conversions.ToInteger(this[this.tabletblPropertyExposure.ExposureIDColumn]);
      set => this[this.tabletblPropertyExposure.ExposureIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int OriginalExposureID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblPropertyExposure.OriginalExposureIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'OriginalExposureID' in table 'tblPropertyExposure' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblPropertyExposure.OriginalExposureIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int LocationID
    {
      get => Conversions.ToInteger(this[this.tabletblPropertyExposure.LocationIDColumn]);
      set => this[this.tabletblPropertyExposure.LocationIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int QuoteOptionID
    {
      get => Conversions.ToInteger(this[this.tabletblPropertyExposure.QuoteOptionIDColumn]);
      set => this[this.tabletblPropertyExposure.QuoteOptionIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Decimal TotalNonTerrorPremium
    {
      get => Conversions.ToDecimal(this[this.tabletblPropertyExposure.TotalNonTerrorPremiumColumn]);
      set => this[this.tabletblPropertyExposure.TotalNonTerrorPremiumColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Decimal PrimaryPremium
    {
      get => Conversions.ToDecimal(this[this.tabletblPropertyExposure.PrimaryPremiumColumn]);
      set => this[this.tabletblPropertyExposure.PrimaryPremiumColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Decimal ExcessPremium
    {
      get => Conversions.ToDecimal(this[this.tabletblPropertyExposure.ExcessPremiumColumn]);
      set => this[this.tabletblPropertyExposure.ExcessPremiumColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Decimal TerrPremium
    {
      get => Conversions.ToDecimal(this[this.tabletblPropertyExposure.TerrPremiumColumn]);
      set => this[this.tabletblPropertyExposure.TerrPremiumColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Decimal TerrorPrimary
    {
      get => Conversions.ToDecimal(this[this.tabletblPropertyExposure.TerrorPrimaryColumn]);
      set => this[this.tabletblPropertyExposure.TerrorPrimaryColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Decimal TerrorExcess
    {
      get => Conversions.ToDecimal(this[this.tabletblPropertyExposure.TerrorExcessColumn]);
      set => this[this.tabletblPropertyExposure.TerrorExcessColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string ModificationCode
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblPropertyExposure.ModificationCodeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ModificationCode' in table 'tblPropertyExposure' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblPropertyExposure.ModificationCodeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string EndorsementCalcType
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblPropertyExposure.EndorsementCalcTypeColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'EndorsementCalcType' in table 'tblPropertyExposure' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblPropertyExposure.EndorsementCalcTypeColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Decimal Factor
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tabletblPropertyExposure.FactorColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Factor' in table 'tblPropertyExposure' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblPropertyExposure.FactorColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DateTime EffectiveDate
    {
      get
      {
        try
        {
          return Conversions.ToDate(this[this.tabletblPropertyExposure.EffectiveDateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'EffectiveDate' in table 'tblPropertyExposure' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblPropertyExposure.EffectiveDateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Guid UserAdded
    {
      get
      {
        try
        {
          object obj = this[this.tabletblPropertyExposure.UserAddedColumn];
          return obj != null ? (Guid) obj : new Guid();
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'UserAdded' in table 'tblPropertyExposure' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblPropertyExposure.UserAddedColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int OfficeID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblPropertyExposure.OfficeIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'OfficeID' in table 'tblPropertyExposure' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblPropertyExposure.OfficeIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int CoverageID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblPropertyExposure.CoverageIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'CoverageID' in table 'tblPropertyExposure' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblPropertyExposure.CoverageIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int CoInsuranceID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblPropertyExposure.CoInsuranceIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'CoInsuranceID' in table 'tblPropertyExposure' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblPropertyExposure.CoInsuranceIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int ValuationID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblPropertyExposure.ValuationIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ValuationID' in table 'tblPropertyExposure' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblPropertyExposure.ValuationIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int CauseOfLossID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblPropertyExposure.CauseOfLossIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'CauseOfLossID' in table 'tblPropertyExposure' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblPropertyExposure.CauseOfLossIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int Deductible
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblPropertyExposure.DeductibleColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Deductible' in table 'tblPropertyExposure' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblPropertyExposure.DeductibleColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string DeductiblePerID
    {
      get => Conversions.ToString(this[this.tabletblPropertyExposure.DeductiblePerIDColumn]);
      set => this[this.tabletblPropertyExposure.DeductiblePerIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Decimal Limit
    {
      get => Conversions.ToDecimal(this[this.tabletblPropertyExposure.LimitColumn]);
      set => this[this.tabletblPropertyExposure.LimitColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string CoInsurance
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblPropertyExposure.CoInsuranceColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'CoInsurance' in table 'tblPropertyExposure' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblPropertyExposure.CoInsuranceColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Decimal AccountRate
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tabletblPropertyExposure.AccountRateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'AccountRate' in table 'tblPropertyExposure' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblPropertyExposure.AccountRateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Decimal PrimaryRate
    {
      get => Conversions.ToDecimal(this[this.tabletblPropertyExposure.PrimaryRateColumn]);
      set => this[this.tabletblPropertyExposure.PrimaryRateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Decimal ExcessRate
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tabletblPropertyExposure.ExcessRateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ExcessRate' in table 'tblPropertyExposure' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblPropertyExposure.ExcessRateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Decimal TerrRate
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tabletblPropertyExposure.TerrRateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'TerrRate' in table 'tblPropertyExposure' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblPropertyExposure.TerrRateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Decimal UserOverrideFactor
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tabletblPropertyExposure.UserOverrideFactorColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'UserOverrideFactor' in table 'tblPropertyExposure' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblPropertyExposure.UserOverrideFactorColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string OtherDeductibles
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblPropertyExposure.OtherDeductiblesColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'OtherDeductibles' in table 'tblPropertyExposure' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblPropertyExposure.OtherDeductiblesColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool PremiumsWaived
    {
      get => Conversions.ToBoolean(this[this.tabletblPropertyExposure.PremiumsWaivedColumn]);
      set => this[this.tabletblPropertyExposure.PremiumsWaivedColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool Selected
    {
      get => Conversions.ToBoolean(this[this.tabletblPropertyExposure.SelectedColumn]);
      set => this[this.tabletblPropertyExposure.SelectedColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string AdditionalInfo
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblPropertyExposure.AdditionalInfoColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'AdditionalInfo' in table 'tblPropertyExposure' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblPropertyExposure.AdditionalInfoColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPropertyRater_Exposure.tblClientOfficesRow tblClientOfficesRow
    {
      get
      {
        return (dsPropertyRater_Exposure.tblClientOfficesRow) this.GetParentRow(this.Table.ParentRelations["tblClientOfficestblPropertyExposure"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["tblClientOfficestblPropertyExposure"]);
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPropertyRater_Exposure.tblUnderwritingLocationsRow tblUnderwritingLocationsRow
    {
      get
      {
        return (dsPropertyRater_Exposure.tblUnderwritingLocationsRow) this.GetParentRow(this.Table.ParentRelations["tblUnderwritingLocationstblPropertyExposure"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["tblUnderwritingLocationstblPropertyExposure"]);
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPropertyRater_Exposure.lstDeductiblePerRow lstDeductiblePerRow
    {
      get
      {
        return (dsPropertyRater_Exposure.lstDeductiblePerRow) this.GetParentRow(this.Table.ParentRelations["lstDeductiblePertblPropertyExposure"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["lstDeductiblePertblPropertyExposure"]);
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsOriginalExposureIDNull()
    {
      return this.IsNull(this.tabletblPropertyExposure.OriginalExposureIDColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetOriginalExposureIDNull()
    {
      this[this.tabletblPropertyExposure.OriginalExposureIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsModificationCodeNull()
    {
      return this.IsNull(this.tabletblPropertyExposure.ModificationCodeColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetModificationCodeNull()
    {
      this[this.tabletblPropertyExposure.ModificationCodeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsEndorsementCalcTypeNull()
    {
      return this.IsNull(this.tabletblPropertyExposure.EndorsementCalcTypeColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetEndorsementCalcTypeNull()
    {
      this[this.tabletblPropertyExposure.EndorsementCalcTypeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsFactorNull() => this.IsNull(this.tabletblPropertyExposure.FactorColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetFactorNull()
    {
      this[this.tabletblPropertyExposure.FactorColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsEffectiveDateNull()
    {
      return this.IsNull(this.tabletblPropertyExposure.EffectiveDateColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetEffectiveDateNull()
    {
      this[this.tabletblPropertyExposure.EffectiveDateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsUserAddedNull() => this.IsNull(this.tabletblPropertyExposure.UserAddedColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetUserAddedNull()
    {
      this[this.tabletblPropertyExposure.UserAddedColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsOfficeIDNull() => this.IsNull(this.tabletblPropertyExposure.OfficeIDColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetOfficeIDNull()
    {
      this[this.tabletblPropertyExposure.OfficeIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsCoverageIDNull() => this.IsNull(this.tabletblPropertyExposure.CoverageIDColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetCoverageIDNull()
    {
      this[this.tabletblPropertyExposure.CoverageIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsCoInsuranceIDNull()
    {
      return this.IsNull(this.tabletblPropertyExposure.CoInsuranceIDColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetCoInsuranceIDNull()
    {
      this[this.tabletblPropertyExposure.CoInsuranceIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsValuationIDNull() => this.IsNull(this.tabletblPropertyExposure.ValuationIDColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetValuationIDNull()
    {
      this[this.tabletblPropertyExposure.ValuationIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsCauseOfLossIDNull()
    {
      return this.IsNull(this.tabletblPropertyExposure.CauseOfLossIDColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetCauseOfLossIDNull()
    {
      this[this.tabletblPropertyExposure.CauseOfLossIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsDeductibleNull() => this.IsNull(this.tabletblPropertyExposure.DeductibleColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetDeductibleNull()
    {
      this[this.tabletblPropertyExposure.DeductibleColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsCoInsuranceNull() => this.IsNull(this.tabletblPropertyExposure.CoInsuranceColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetCoInsuranceNull()
    {
      this[this.tabletblPropertyExposure.CoInsuranceColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsAccountRateNull() => this.IsNull(this.tabletblPropertyExposure.AccountRateColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetAccountRateNull()
    {
      this[this.tabletblPropertyExposure.AccountRateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsExcessRateNull() => this.IsNull(this.tabletblPropertyExposure.ExcessRateColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetExcessRateNull()
    {
      this[this.tabletblPropertyExposure.ExcessRateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsTerrRateNull() => this.IsNull(this.tabletblPropertyExposure.TerrRateColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetTerrRateNull()
    {
      this[this.tabletblPropertyExposure.TerrRateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsUserOverrideFactorNull()
    {
      return this.IsNull(this.tabletblPropertyExposure.UserOverrideFactorColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetUserOverrideFactorNull()
    {
      this[this.tabletblPropertyExposure.UserOverrideFactorColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsOtherDeductiblesNull()
    {
      return this.IsNull(this.tabletblPropertyExposure.OtherDeductiblesColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetOtherDeductiblesNull()
    {
      this[this.tabletblPropertyExposure.OtherDeductiblesColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsAdditionalInfoNull()
    {
      return this.IsNull(this.tabletblPropertyExposure.AdditionalInfoColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetAdditionalInfoNull()
    {
      this[this.tabletblPropertyExposure.AdditionalInfoColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class lstEndorsementCalculationTypesRow : DataRow
  {
    private dsPropertyRater_Exposure.lstEndorsementCalculationTypesDataTable tablelstEndorsementCalculationTypes;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal lstEndorsementCalculationTypesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablelstEndorsementCalculationTypes = (dsPropertyRater_Exposure.lstEndorsementCalculationTypesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string ID
    {
      get => Conversions.ToString(this[this.tablelstEndorsementCalculationTypes.IDColumn]);
      set => this[this.tablelstEndorsementCalculationTypes.IDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string EndorsementCalcType
    {
      get
      {
        return Conversions.ToString(this[this.tablelstEndorsementCalculationTypes.EndorsementCalcTypeColumn]);
      }
      set
      {
        this[this.tablelstEndorsementCalculationTypes.EndorsementCalcTypeColumn] = (object) value;
      }
    }
  }

  public class tblClientOfficesRow : DataRow
  {
    private dsPropertyRater_Exposure.tblClientOfficesDataTable tabletblClientOffices;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal tblClientOfficesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblClientOffices = (dsPropertyRater_Exposure.tblClientOfficesDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int OfficeID
    {
      get => Conversions.ToInteger(this[this.tabletblClientOffices.OfficeIDColumn]);
      set => this[this.tabletblClientOffices.OfficeIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string Location
    {
      get => Conversions.ToString(this[this.tabletblClientOffices.LocationColumn]);
      set => this[this.tabletblClientOffices.LocationColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPropertyRater_Exposure.tblPropertyExposureRow[] GettblPropertyExposureRows()
    {
      return this.Table.ChildRelations["tblClientOfficestblPropertyExposure"] != null ? (dsPropertyRater_Exposure.tblPropertyExposureRow[]) this.GetChildRows(this.Table.ChildRelations["tblClientOfficestblPropertyExposure"]) : new dsPropertyRater_Exposure.tblPropertyExposureRow[0];
    }
  }

  public class lstDeductiblePerRow : DataRow
  {
    private dsPropertyRater_Exposure.lstDeductiblePerDataTable tablelstDeductiblePer;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal lstDeductiblePerRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablelstDeductiblePer = (dsPropertyRater_Exposure.lstDeductiblePerDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string PerID
    {
      get => Conversions.ToString(this[this.tablelstDeductiblePer.PerIDColumn]);
      set => this[this.tablelstDeductiblePer.PerIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string DeductiblePer
    {
      get => Conversions.ToString(this[this.tablelstDeductiblePer.DeductiblePerColumn]);
      set => this[this.tablelstDeductiblePer.DeductiblePerColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPropertyRater_Exposure.tblPropertyExposureRow[] GettblPropertyExposureRows()
    {
      return this.Table.ChildRelations["lstDeductiblePertblPropertyExposure"] != null ? (dsPropertyRater_Exposure.tblPropertyExposureRow[]) this.GetChildRows(this.Table.ChildRelations["lstDeductiblePertblPropertyExposure"]) : new dsPropertyRater_Exposure.tblPropertyExposureRow[0];
    }
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class tblUnderwritingLocationsRowChangeEvent : EventArgs
  {
    private dsPropertyRater_Exposure.tblUnderwritingLocationsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public tblUnderwritingLocationsRowChangeEvent(
      dsPropertyRater_Exposure.tblUnderwritingLocationsRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPropertyRater_Exposure.tblUnderwritingLocationsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class lstPropRater_CoinsuranceRowChangeEvent : EventArgs
  {
    private dsPropertyRater_Exposure.lstPropRater_CoinsuranceRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public lstPropRater_CoinsuranceRowChangeEvent(
      dsPropertyRater_Exposure.lstPropRater_CoinsuranceRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPropertyRater_Exposure.lstPropRater_CoinsuranceRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class lstPropRater_CoverageTypesRowChangeEvent : EventArgs
  {
    private dsPropertyRater_Exposure.lstPropRater_CoverageTypesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public lstPropRater_CoverageTypesRowChangeEvent(
      dsPropertyRater_Exposure.lstPropRater_CoverageTypesRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPropertyRater_Exposure.lstPropRater_CoverageTypesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class lstPropRater_CauseOfLossRowChangeEvent : EventArgs
  {
    private dsPropertyRater_Exposure.lstPropRater_CauseOfLossRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public lstPropRater_CauseOfLossRowChangeEvent(
      dsPropertyRater_Exposure.lstPropRater_CauseOfLossRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPropertyRater_Exposure.lstPropRater_CauseOfLossRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class lstPropRater_ValuationRowChangeEvent : EventArgs
  {
    private dsPropertyRater_Exposure.lstPropRater_ValuationRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public lstPropRater_ValuationRowChangeEvent(
      dsPropertyRater_Exposure.lstPropRater_ValuationRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPropertyRater_Exposure.lstPropRater_ValuationRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class tblPropertyExposureRowChangeEvent : EventArgs
  {
    private dsPropertyRater_Exposure.tblPropertyExposureRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public tblPropertyExposureRowChangeEvent(
      dsPropertyRater_Exposure.tblPropertyExposureRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPropertyRater_Exposure.tblPropertyExposureRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class lstEndorsementCalculationTypesRowChangeEvent : EventArgs
  {
    private dsPropertyRater_Exposure.lstEndorsementCalculationTypesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public lstEndorsementCalculationTypesRowChangeEvent(
      dsPropertyRater_Exposure.lstEndorsementCalculationTypesRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPropertyRater_Exposure.lstEndorsementCalculationTypesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class tblClientOfficesRowChangeEvent : EventArgs
  {
    private dsPropertyRater_Exposure.tblClientOfficesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public tblClientOfficesRowChangeEvent(
      dsPropertyRater_Exposure.tblClientOfficesRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPropertyRater_Exposure.tblClientOfficesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class lstDeductiblePerRowChangeEvent : EventArgs
  {
    private dsPropertyRater_Exposure.lstDeductiblePerRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public lstDeductiblePerRowChangeEvent(
      dsPropertyRater_Exposure.lstDeductiblePerRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPropertyRater_Exposure.lstDeductiblePerRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }
}
