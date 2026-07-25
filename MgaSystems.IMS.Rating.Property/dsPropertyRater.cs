// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.Rating.Property.dsPropertyRater
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
[XmlRoot("dsPropertyRater")]
[HelpKeyword("vs.data.DataSet")]
[Serializable]
public class dsPropertyRater : DataSet
{
  private dsPropertyRater.lstPropRater_CoinsuranceDataTable tablelstPropRater_Coinsurance;
  private dsPropertyRater.lstPropRater_CoverageTypesDataTable tablelstPropRater_CoverageTypes;
  private dsPropertyRater.lstPropRater_ValuationDataTable tablelstPropRater_Valuation;
  private dsPropertyRater.lstPropRater_LimitDescriptionDataTable tablelstPropRater_LimitDescription;
  private dsPropertyRater.lstPolicyFormDataTable tablelstPolicyForm;
  private dsPropertyRater.lstPropRater_CauseOfLossDataTable tablelstPropRater_CauseOfLoss;
  private dsPropertyRater.tblQuoteOptionsDataTable tabletblQuoteOptions;
  private dsPropertyRater.tblQuoteOptionPropertyDataTable tabletblQuoteOptionProperty;
  private dsPropertyRater.tblQuoteOptionProperty_SubLimitsDataTable tabletblQuoteOptionProperty_SubLimits;
  private dsPropertyRater.lstSubLimitsDataTable tablelstSubLimits;
  private dsPropertyRater.lstDeductiblePerDataTable tablelstDeductiblePer;
  private dsPropertyRater.tblPropertyExposuresPriorYearsDataTable tabletblPropertyExposuresPriorYears;
  private DataRelation relationtblQuoteOptionstblQuoteOptionProperty;
  private DataRelation relationlstSubLimitstblQuoteOptionProperty_SubLimits;
  private DataRelation relationtblQuoteOptionPropertytblQuoteOptionProperty_SubLimits;
  private SchemaSerializationMode _schemaSerializationMode;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public dsPropertyRater()
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
  protected dsPropertyRater(SerializationInfo info, StreamingContext context)
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
        if (dataSet.Tables[nameof (lstPropRater_Coinsurance)] != null)
          base.Tables.Add((DataTable) new dsPropertyRater.lstPropRater_CoinsuranceDataTable(dataSet.Tables[nameof (lstPropRater_Coinsurance)]));
        if (dataSet.Tables[nameof (lstPropRater_CoverageTypes)] != null)
          base.Tables.Add((DataTable) new dsPropertyRater.lstPropRater_CoverageTypesDataTable(dataSet.Tables[nameof (lstPropRater_CoverageTypes)]));
        if (dataSet.Tables[nameof (lstPropRater_Valuation)] != null)
          base.Tables.Add((DataTable) new dsPropertyRater.lstPropRater_ValuationDataTable(dataSet.Tables[nameof (lstPropRater_Valuation)]));
        if (dataSet.Tables[nameof (lstPropRater_LimitDescription)] != null)
          base.Tables.Add((DataTable) new dsPropertyRater.lstPropRater_LimitDescriptionDataTable(dataSet.Tables[nameof (lstPropRater_LimitDescription)]));
        if (dataSet.Tables[nameof (lstPolicyForm)] != null)
          base.Tables.Add((DataTable) new dsPropertyRater.lstPolicyFormDataTable(dataSet.Tables[nameof (lstPolicyForm)]));
        if (dataSet.Tables[nameof (lstPropRater_CauseOfLoss)] != null)
          base.Tables.Add((DataTable) new dsPropertyRater.lstPropRater_CauseOfLossDataTable(dataSet.Tables[nameof (lstPropRater_CauseOfLoss)]));
        if (dataSet.Tables[nameof (tblQuoteOptions)] != null)
          base.Tables.Add((DataTable) new dsPropertyRater.tblQuoteOptionsDataTable(dataSet.Tables[nameof (tblQuoteOptions)]));
        if (dataSet.Tables[nameof (tblQuoteOptionProperty)] != null)
          base.Tables.Add((DataTable) new dsPropertyRater.tblQuoteOptionPropertyDataTable(dataSet.Tables[nameof (tblQuoteOptionProperty)]));
        if (dataSet.Tables[nameof (tblQuoteOptionProperty_SubLimits)] != null)
          base.Tables.Add((DataTable) new dsPropertyRater.tblQuoteOptionProperty_SubLimitsDataTable(dataSet.Tables[nameof (tblQuoteOptionProperty_SubLimits)]));
        if (dataSet.Tables[nameof (lstSubLimits)] != null)
          base.Tables.Add((DataTable) new dsPropertyRater.lstSubLimitsDataTable(dataSet.Tables[nameof (lstSubLimits)]));
        if (dataSet.Tables[nameof (lstDeductiblePer)] != null)
          base.Tables.Add((DataTable) new dsPropertyRater.lstDeductiblePerDataTable(dataSet.Tables[nameof (lstDeductiblePer)]));
        if (dataSet.Tables[nameof (tblPropertyExposuresPriorYears)] != null)
          base.Tables.Add((DataTable) new dsPropertyRater.tblPropertyExposuresPriorYearsDataTable(dataSet.Tables[nameof (tblPropertyExposuresPriorYears)]));
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
  public dsPropertyRater.lstPropRater_CoinsuranceDataTable lstPropRater_Coinsurance
  {
    get => this.tablelstPropRater_Coinsurance;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsPropertyRater.lstPropRater_CoverageTypesDataTable lstPropRater_CoverageTypes
  {
    get => this.tablelstPropRater_CoverageTypes;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsPropertyRater.lstPropRater_ValuationDataTable lstPropRater_Valuation
  {
    get => this.tablelstPropRater_Valuation;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsPropertyRater.lstPropRater_LimitDescriptionDataTable lstPropRater_LimitDescription
  {
    get => this.tablelstPropRater_LimitDescription;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsPropertyRater.lstPolicyFormDataTable lstPolicyForm => this.tablelstPolicyForm;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsPropertyRater.lstPropRater_CauseOfLossDataTable lstPropRater_CauseOfLoss
  {
    get => this.tablelstPropRater_CauseOfLoss;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsPropertyRater.tblQuoteOptionsDataTable tblQuoteOptions => this.tabletblQuoteOptions;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsPropertyRater.tblQuoteOptionPropertyDataTable tblQuoteOptionProperty
  {
    get => this.tabletblQuoteOptionProperty;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsPropertyRater.tblQuoteOptionProperty_SubLimitsDataTable tblQuoteOptionProperty_SubLimits
  {
    get => this.tabletblQuoteOptionProperty_SubLimits;
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsPropertyRater.lstSubLimitsDataTable lstSubLimits => this.tablelstSubLimits;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsPropertyRater.lstDeductiblePerDataTable lstDeductiblePer => this.tablelstDeductiblePer;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  public dsPropertyRater.tblPropertyExposuresPriorYearsDataTable tblPropertyExposuresPriorYears
  {
    get => this.tabletblPropertyExposuresPriorYears;
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
    dsPropertyRater dsPropertyRater = (dsPropertyRater) base.Clone();
    dsPropertyRater.InitVars();
    dsPropertyRater.SchemaSerializationMode = this.SchemaSerializationMode;
    return (DataSet) dsPropertyRater;
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
      if (dataSet.Tables["lstPropRater_Coinsurance"] != null)
        base.Tables.Add((DataTable) new dsPropertyRater.lstPropRater_CoinsuranceDataTable(dataSet.Tables["lstPropRater_Coinsurance"]));
      if (dataSet.Tables["lstPropRater_CoverageTypes"] != null)
        base.Tables.Add((DataTable) new dsPropertyRater.lstPropRater_CoverageTypesDataTable(dataSet.Tables["lstPropRater_CoverageTypes"]));
      if (dataSet.Tables["lstPropRater_Valuation"] != null)
        base.Tables.Add((DataTable) new dsPropertyRater.lstPropRater_ValuationDataTable(dataSet.Tables["lstPropRater_Valuation"]));
      if (dataSet.Tables["lstPropRater_LimitDescription"] != null)
        base.Tables.Add((DataTable) new dsPropertyRater.lstPropRater_LimitDescriptionDataTable(dataSet.Tables["lstPropRater_LimitDescription"]));
      if (dataSet.Tables["lstPolicyForm"] != null)
        base.Tables.Add((DataTable) new dsPropertyRater.lstPolicyFormDataTable(dataSet.Tables["lstPolicyForm"]));
      if (dataSet.Tables["lstPropRater_CauseOfLoss"] != null)
        base.Tables.Add((DataTable) new dsPropertyRater.lstPropRater_CauseOfLossDataTable(dataSet.Tables["lstPropRater_CauseOfLoss"]));
      if (dataSet.Tables["tblQuoteOptions"] != null)
        base.Tables.Add((DataTable) new dsPropertyRater.tblQuoteOptionsDataTable(dataSet.Tables["tblQuoteOptions"]));
      if (dataSet.Tables["tblQuoteOptionProperty"] != null)
        base.Tables.Add((DataTable) new dsPropertyRater.tblQuoteOptionPropertyDataTable(dataSet.Tables["tblQuoteOptionProperty"]));
      if (dataSet.Tables["tblQuoteOptionProperty_SubLimits"] != null)
        base.Tables.Add((DataTable) new dsPropertyRater.tblQuoteOptionProperty_SubLimitsDataTable(dataSet.Tables["tblQuoteOptionProperty_SubLimits"]));
      if (dataSet.Tables["lstSubLimits"] != null)
        base.Tables.Add((DataTable) new dsPropertyRater.lstSubLimitsDataTable(dataSet.Tables["lstSubLimits"]));
      if (dataSet.Tables["lstDeductiblePer"] != null)
        base.Tables.Add((DataTable) new dsPropertyRater.lstDeductiblePerDataTable(dataSet.Tables["lstDeductiblePer"]));
      if (dataSet.Tables["tblPropertyExposuresPriorYears"] != null)
        base.Tables.Add((DataTable) new dsPropertyRater.tblPropertyExposuresPriorYearsDataTable(dataSet.Tables["tblPropertyExposuresPriorYears"]));
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
    this.tablelstPropRater_Coinsurance = (dsPropertyRater.lstPropRater_CoinsuranceDataTable) base.Tables["lstPropRater_Coinsurance"];
    if (initTable && this.tablelstPropRater_Coinsurance != null)
      this.tablelstPropRater_Coinsurance.InitVars();
    this.tablelstPropRater_CoverageTypes = (dsPropertyRater.lstPropRater_CoverageTypesDataTable) base.Tables["lstPropRater_CoverageTypes"];
    if (initTable && this.tablelstPropRater_CoverageTypes != null)
      this.tablelstPropRater_CoverageTypes.InitVars();
    this.tablelstPropRater_Valuation = (dsPropertyRater.lstPropRater_ValuationDataTable) base.Tables["lstPropRater_Valuation"];
    if (initTable && this.tablelstPropRater_Valuation != null)
      this.tablelstPropRater_Valuation.InitVars();
    this.tablelstPropRater_LimitDescription = (dsPropertyRater.lstPropRater_LimitDescriptionDataTable) base.Tables["lstPropRater_LimitDescription"];
    if (initTable && this.tablelstPropRater_LimitDescription != null)
      this.tablelstPropRater_LimitDescription.InitVars();
    this.tablelstPolicyForm = (dsPropertyRater.lstPolicyFormDataTable) base.Tables["lstPolicyForm"];
    if (initTable && this.tablelstPolicyForm != null)
      this.tablelstPolicyForm.InitVars();
    this.tablelstPropRater_CauseOfLoss = (dsPropertyRater.lstPropRater_CauseOfLossDataTable) base.Tables["lstPropRater_CauseOfLoss"];
    if (initTable && this.tablelstPropRater_CauseOfLoss != null)
      this.tablelstPropRater_CauseOfLoss.InitVars();
    this.tabletblQuoteOptions = (dsPropertyRater.tblQuoteOptionsDataTable) base.Tables["tblQuoteOptions"];
    if (initTable && this.tabletblQuoteOptions != null)
      this.tabletblQuoteOptions.InitVars();
    this.tabletblQuoteOptionProperty = (dsPropertyRater.tblQuoteOptionPropertyDataTable) base.Tables["tblQuoteOptionProperty"];
    if (initTable && this.tabletblQuoteOptionProperty != null)
      this.tabletblQuoteOptionProperty.InitVars();
    this.tabletblQuoteOptionProperty_SubLimits = (dsPropertyRater.tblQuoteOptionProperty_SubLimitsDataTable) base.Tables["tblQuoteOptionProperty_SubLimits"];
    if (initTable && this.tabletblQuoteOptionProperty_SubLimits != null)
      this.tabletblQuoteOptionProperty_SubLimits.InitVars();
    this.tablelstSubLimits = (dsPropertyRater.lstSubLimitsDataTable) base.Tables["lstSubLimits"];
    if (initTable && this.tablelstSubLimits != null)
      this.tablelstSubLimits.InitVars();
    this.tablelstDeductiblePer = (dsPropertyRater.lstDeductiblePerDataTable) base.Tables["lstDeductiblePer"];
    if (initTable && this.tablelstDeductiblePer != null)
      this.tablelstDeductiblePer.InitVars();
    this.tabletblPropertyExposuresPriorYears = (dsPropertyRater.tblPropertyExposuresPriorYearsDataTable) base.Tables["tblPropertyExposuresPriorYears"];
    if (initTable && this.tabletblPropertyExposuresPriorYears != null)
      this.tabletblPropertyExposuresPriorYears.InitVars();
    this.relationtblQuoteOptionstblQuoteOptionProperty = this.Relations["tblQuoteOptionstblQuoteOptionProperty"];
    this.relationlstSubLimitstblQuoteOptionProperty_SubLimits = this.Relations["lstSubLimitstblQuoteOptionProperty_SubLimits"];
    this.relationtblQuoteOptionPropertytblQuoteOptionProperty_SubLimits = this.Relations["tblQuoteOptionPropertytblQuoteOptionProperty_SubLimits"];
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private void InitClass()
  {
    this.DataSetName = nameof (dsPropertyRater);
    this.Prefix = "";
    this.Namespace = "http://tempuri.org/dsPropertyRater.xsd";
    this.EnforceConstraints = true;
    this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.tablelstPropRater_Coinsurance = new dsPropertyRater.lstPropRater_CoinsuranceDataTable();
    base.Tables.Add((DataTable) this.tablelstPropRater_Coinsurance);
    this.tablelstPropRater_CoverageTypes = new dsPropertyRater.lstPropRater_CoverageTypesDataTable();
    base.Tables.Add((DataTable) this.tablelstPropRater_CoverageTypes);
    this.tablelstPropRater_Valuation = new dsPropertyRater.lstPropRater_ValuationDataTable();
    base.Tables.Add((DataTable) this.tablelstPropRater_Valuation);
    this.tablelstPropRater_LimitDescription = new dsPropertyRater.lstPropRater_LimitDescriptionDataTable();
    base.Tables.Add((DataTable) this.tablelstPropRater_LimitDescription);
    this.tablelstPolicyForm = new dsPropertyRater.lstPolicyFormDataTable();
    base.Tables.Add((DataTable) this.tablelstPolicyForm);
    this.tablelstPropRater_CauseOfLoss = new dsPropertyRater.lstPropRater_CauseOfLossDataTable();
    base.Tables.Add((DataTable) this.tablelstPropRater_CauseOfLoss);
    this.tabletblQuoteOptions = new dsPropertyRater.tblQuoteOptionsDataTable();
    base.Tables.Add((DataTable) this.tabletblQuoteOptions);
    this.tabletblQuoteOptionProperty = new dsPropertyRater.tblQuoteOptionPropertyDataTable();
    base.Tables.Add((DataTable) this.tabletblQuoteOptionProperty);
    this.tabletblQuoteOptionProperty_SubLimits = new dsPropertyRater.tblQuoteOptionProperty_SubLimitsDataTable();
    base.Tables.Add((DataTable) this.tabletblQuoteOptionProperty_SubLimits);
    this.tablelstSubLimits = new dsPropertyRater.lstSubLimitsDataTable();
    base.Tables.Add((DataTable) this.tablelstSubLimits);
    this.tablelstDeductiblePer = new dsPropertyRater.lstDeductiblePerDataTable();
    base.Tables.Add((DataTable) this.tablelstDeductiblePer);
    this.tabletblPropertyExposuresPriorYears = new dsPropertyRater.tblPropertyExposuresPriorYearsDataTable();
    base.Tables.Add((DataTable) this.tabletblPropertyExposuresPriorYears);
    ForeignKeyConstraint foreignKeyConstraint1 = new ForeignKeyConstraint("tblQuoteOptionstblQuoteOptionProperty", new DataColumn[1]
    {
      this.tabletblQuoteOptions.QuoteOptionIDColumn
    }, new DataColumn[1]
    {
      this.tabletblQuoteOptionProperty.QuoteOptionIDColumn
    });
    this.tabletblQuoteOptionProperty.Constraints.Add((Constraint) foreignKeyConstraint1);
    foreignKeyConstraint1.AcceptRejectRule = AcceptRejectRule.None;
    foreignKeyConstraint1.DeleteRule = Rule.Cascade;
    foreignKeyConstraint1.UpdateRule = Rule.Cascade;
    ForeignKeyConstraint foreignKeyConstraint2 = new ForeignKeyConstraint("lstSubLimitstblQuoteOptionProperty_SubLimits", new DataColumn[1]
    {
      this.tablelstSubLimits.SubLimitIDColumn
    }, new DataColumn[1]
    {
      this.tabletblQuoteOptionProperty_SubLimits.SubLimitIDColumn
    });
    this.tabletblQuoteOptionProperty_SubLimits.Constraints.Add((Constraint) foreignKeyConstraint2);
    foreignKeyConstraint2.AcceptRejectRule = AcceptRejectRule.None;
    foreignKeyConstraint2.DeleteRule = Rule.Cascade;
    foreignKeyConstraint2.UpdateRule = Rule.Cascade;
    ForeignKeyConstraint foreignKeyConstraint3 = new ForeignKeyConstraint("tblQuoteOptionPropertytblQuoteOptionProperty_SubLimits", new DataColumn[1]
    {
      this.tabletblQuoteOptionProperty.IDColumn
    }, new DataColumn[1]
    {
      this.tabletblQuoteOptionProperty_SubLimits.PropertyOptionIDColumn
    });
    this.tabletblQuoteOptionProperty_SubLimits.Constraints.Add((Constraint) foreignKeyConstraint3);
    foreignKeyConstraint3.AcceptRejectRule = AcceptRejectRule.None;
    foreignKeyConstraint3.DeleteRule = Rule.Cascade;
    foreignKeyConstraint3.UpdateRule = Rule.Cascade;
    this.relationtblQuoteOptionstblQuoteOptionProperty = new DataRelation("tblQuoteOptionstblQuoteOptionProperty", new DataColumn[1]
    {
      this.tabletblQuoteOptions.QuoteOptionIDColumn
    }, new DataColumn[1]
    {
      this.tabletblQuoteOptionProperty.QuoteOptionIDColumn
    }, false);
    this.Relations.Add(this.relationtblQuoteOptionstblQuoteOptionProperty);
    this.relationlstSubLimitstblQuoteOptionProperty_SubLimits = new DataRelation("lstSubLimitstblQuoteOptionProperty_SubLimits", new DataColumn[1]
    {
      this.tablelstSubLimits.SubLimitIDColumn
    }, new DataColumn[1]
    {
      this.tabletblQuoteOptionProperty_SubLimits.SubLimitIDColumn
    }, false);
    this.Relations.Add(this.relationlstSubLimitstblQuoteOptionProperty_SubLimits);
    this.relationtblQuoteOptionPropertytblQuoteOptionProperty_SubLimits = new DataRelation("tblQuoteOptionPropertytblQuoteOptionProperty_SubLimits", new DataColumn[1]
    {
      this.tabletblQuoteOptionProperty.IDColumn
    }, new DataColumn[1]
    {
      this.tabletblQuoteOptionProperty_SubLimits.PropertyOptionIDColumn
    }, false);
    this.Relations.Add(this.relationtblQuoteOptionPropertytblQuoteOptionProperty_SubLimits);
  }

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializelstPropRater_Coinsurance() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializelstPropRater_CoverageTypes() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializelstPropRater_Valuation() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializelstPropRater_LimitDescription() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializelstPolicyForm() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializelstPropRater_CauseOfLoss() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializetblQuoteOptions() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializetblQuoteOptionProperty() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializetblQuoteOptionProperty_SubLimits() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializelstSubLimits() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializelstDeductiblePer() => false;

  [DebuggerNonUserCode]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  private bool ShouldSerializetblPropertyExposuresPriorYears() => false;

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
    dsPropertyRater dsPropertyRater = new dsPropertyRater();
    XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
    schemaComplexType.Particle = (XmlSchemaParticle) new XmlSchemaSequence()
    {
      Items = {
        (XmlSchemaObject) new XmlSchemaAny()
        {
          Namespace = dsPropertyRater.Namespace
        }
      }
    };
    XmlSchema schemaSerializable = dsPropertyRater.GetSchemaSerializable();
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
  public delegate void lstPropRater_CoinsuranceRowChangeEventHandler(
    object sender,
    dsPropertyRater.lstPropRater_CoinsuranceRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public delegate void lstPropRater_CoverageTypesRowChangeEventHandler(
    object sender,
    dsPropertyRater.lstPropRater_CoverageTypesRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public delegate void lstPropRater_ValuationRowChangeEventHandler(
    object sender,
    dsPropertyRater.lstPropRater_ValuationRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public delegate void lstPropRater_LimitDescriptionRowChangeEventHandler(
    object sender,
    dsPropertyRater.lstPropRater_LimitDescriptionRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public delegate void lstPolicyFormRowChangeEventHandler(
    object sender,
    dsPropertyRater.lstPolicyFormRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public delegate void lstPropRater_CauseOfLossRowChangeEventHandler(
    object sender,
    dsPropertyRater.lstPropRater_CauseOfLossRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public delegate void tblQuoteOptionsRowChangeEventHandler(
    object sender,
    dsPropertyRater.tblQuoteOptionsRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public delegate void tblQuoteOptionPropertyRowChangeEventHandler(
    object sender,
    dsPropertyRater.tblQuoteOptionPropertyRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public delegate void tblQuoteOptionProperty_SubLimitsRowChangeEventHandler(
    object sender,
    dsPropertyRater.tblQuoteOptionProperty_SubLimitsRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public delegate void lstSubLimitsRowChangeEventHandler(
    object sender,
    dsPropertyRater.lstSubLimitsRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public delegate void lstDeductiblePerRowChangeEventHandler(
    object sender,
    dsPropertyRater.lstDeductiblePerRowChangeEvent e);

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public delegate void tblPropertyExposuresPriorYearsRowChangeEventHandler(
    object sender,
    dsPropertyRater.tblPropertyExposuresPriorYearsRowChangeEvent e);

  [XmlSchemaProvider("GetTypedTableSchema")]
  [Serializable]
  public class lstPropRater_CoinsuranceDataTable : 
    TypedTableBase<dsPropertyRater.lstPropRater_CoinsuranceRow>
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
    public dsPropertyRater.lstPropRater_CoinsuranceRow this[int index]
    {
      get => (dsPropertyRater.lstPropRater_CoinsuranceRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsPropertyRater.lstPropRater_CoinsuranceRowChangeEventHandler lstPropRater_CoinsuranceRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsPropertyRater.lstPropRater_CoinsuranceRowChangeEventHandler lstPropRater_CoinsuranceRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsPropertyRater.lstPropRater_CoinsuranceRowChangeEventHandler lstPropRater_CoinsuranceRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsPropertyRater.lstPropRater_CoinsuranceRowChangeEventHandler lstPropRater_CoinsuranceRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AddlstPropRater_CoinsuranceRow(dsPropertyRater.lstPropRater_CoinsuranceRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPropertyRater.lstPropRater_CoinsuranceRow AddlstPropRater_CoinsuranceRow(
      int ID,
      string CoIns)
    {
      dsPropertyRater.lstPropRater_CoinsuranceRow row = (dsPropertyRater.lstPropRater_CoinsuranceRow) this.NewRow();
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
    public dsPropertyRater.lstPropRater_CoinsuranceRow FindByID(int ID)
    {
      return (dsPropertyRater.lstPropRater_CoinsuranceRow) this.Rows.Find(new object[1]
      {
        (object) ID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsPropertyRater.lstPropRater_CoinsuranceDataTable coinsuranceDataTable = (dsPropertyRater.lstPropRater_CoinsuranceDataTable) base.Clone();
      coinsuranceDataTable.InitVars();
      return (DataTable) coinsuranceDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsPropertyRater.lstPropRater_CoinsuranceDataTable();
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
      this.Constraints.Add((Constraint) new UniqueConstraint("dsPropertyRaterKey1", new DataColumn[1]
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
    public dsPropertyRater.lstPropRater_CoinsuranceRow NewlstPropRater_CoinsuranceRow()
    {
      return (dsPropertyRater.lstPropRater_CoinsuranceRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsPropertyRater.lstPropRater_CoinsuranceRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType() => typeof (dsPropertyRater.lstPropRater_CoinsuranceRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstPropRater_CoinsuranceRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPropertyRater.lstPropRater_CoinsuranceRowChangeEventHandler coinsuranceRowChangedEvent = this.lstPropRater_CoinsuranceRowChangedEvent;
      if (coinsuranceRowChangedEvent == null)
        return;
      coinsuranceRowChangedEvent((object) this, new dsPropertyRater.lstPropRater_CoinsuranceRowChangeEvent((dsPropertyRater.lstPropRater_CoinsuranceRow) e.Row, e.Action));
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
      dsPropertyRater.lstPropRater_CoinsuranceRowChangeEventHandler rowChangingEvent = this.lstPropRater_CoinsuranceRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsPropertyRater.lstPropRater_CoinsuranceRowChangeEvent((dsPropertyRater.lstPropRater_CoinsuranceRow) e.Row, e.Action));
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
      dsPropertyRater.lstPropRater_CoinsuranceRowChangeEventHandler coinsuranceRowDeletedEvent = this.lstPropRater_CoinsuranceRowDeletedEvent;
      if (coinsuranceRowDeletedEvent == null)
        return;
      coinsuranceRowDeletedEvent((object) this, new dsPropertyRater.lstPropRater_CoinsuranceRowChangeEvent((dsPropertyRater.lstPropRater_CoinsuranceRow) e.Row, e.Action));
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
      dsPropertyRater.lstPropRater_CoinsuranceRowChangeEventHandler rowDeletingEvent = this.lstPropRater_CoinsuranceRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsPropertyRater.lstPropRater_CoinsuranceRowChangeEvent((dsPropertyRater.lstPropRater_CoinsuranceRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemovelstPropRater_CoinsuranceRow(dsPropertyRater.lstPropRater_CoinsuranceRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsPropertyRater dsPropertyRater = new dsPropertyRater();
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
        FixedValue = dsPropertyRater.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (lstPropRater_CoinsuranceDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsPropertyRater.GetSchemaSerializable();
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
    TypedTableBase<dsPropertyRater.lstPropRater_CoverageTypesRow>
  {
    private DataColumn columnID;
    private DataColumn columnCoverage;
    private DataColumn columnType;

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
    public DataColumn TypeColumn => this.columnType;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPropertyRater.lstPropRater_CoverageTypesRow this[int index]
    {
      get => (dsPropertyRater.lstPropRater_CoverageTypesRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsPropertyRater.lstPropRater_CoverageTypesRowChangeEventHandler lstPropRater_CoverageTypesRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsPropertyRater.lstPropRater_CoverageTypesRowChangeEventHandler lstPropRater_CoverageTypesRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsPropertyRater.lstPropRater_CoverageTypesRowChangeEventHandler lstPropRater_CoverageTypesRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsPropertyRater.lstPropRater_CoverageTypesRowChangeEventHandler lstPropRater_CoverageTypesRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AddlstPropRater_CoverageTypesRow(dsPropertyRater.lstPropRater_CoverageTypesRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPropertyRater.lstPropRater_CoverageTypesRow AddlstPropRater_CoverageTypesRow(
      int ID,
      string Coverage,
      string Type)
    {
      dsPropertyRater.lstPropRater_CoverageTypesRow row = (dsPropertyRater.lstPropRater_CoverageTypesRow) this.NewRow();
      object[] objArray = new object[3]
      {
        (object) ID,
        (object) Coverage,
        (object) Type
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPropertyRater.lstPropRater_CoverageTypesRow FindByID(int ID)
    {
      return (dsPropertyRater.lstPropRater_CoverageTypesRow) this.Rows.Find(new object[1]
      {
        (object) ID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsPropertyRater.lstPropRater_CoverageTypesDataTable coverageTypesDataTable = (dsPropertyRater.lstPropRater_CoverageTypesDataTable) base.Clone();
      coverageTypesDataTable.InitVars();
      return (DataTable) coverageTypesDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsPropertyRater.lstPropRater_CoverageTypesDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal void InitVars()
    {
      this.columnID = this.Columns["ID"];
      this.columnCoverage = this.Columns["Coverage"];
      this.columnType = this.Columns["Type"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.columnID = new DataColumn("ID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnID);
      this.columnCoverage = new DataColumn("Coverage", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCoverage);
      this.columnType = new DataColumn("Type", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnType);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsPropertyRaterKey2", new DataColumn[1]
      {
        this.columnID
      }, true));
      this.columnID.AllowDBNull = false;
      this.columnID.ReadOnly = true;
      this.columnID.Unique = true;
      this.columnCoverage.AllowDBNull = false;
      this.columnType.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPropertyRater.lstPropRater_CoverageTypesRow NewlstPropRater_CoverageTypesRow()
    {
      return (dsPropertyRater.lstPropRater_CoverageTypesRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsPropertyRater.lstPropRater_CoverageTypesRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType() => typeof (dsPropertyRater.lstPropRater_CoverageTypesRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstPropRater_CoverageTypesRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPropertyRater.lstPropRater_CoverageTypesRowChangeEventHandler typesRowChangedEvent = this.lstPropRater_CoverageTypesRowChangedEvent;
      if (typesRowChangedEvent == null)
        return;
      typesRowChangedEvent((object) this, new dsPropertyRater.lstPropRater_CoverageTypesRowChangeEvent((dsPropertyRater.lstPropRater_CoverageTypesRow) e.Row, e.Action));
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
      dsPropertyRater.lstPropRater_CoverageTypesRowChangeEventHandler rowChangingEvent = this.lstPropRater_CoverageTypesRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsPropertyRater.lstPropRater_CoverageTypesRowChangeEvent((dsPropertyRater.lstPropRater_CoverageTypesRow) e.Row, e.Action));
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
      dsPropertyRater.lstPropRater_CoverageTypesRowChangeEventHandler typesRowDeletedEvent = this.lstPropRater_CoverageTypesRowDeletedEvent;
      if (typesRowDeletedEvent == null)
        return;
      typesRowDeletedEvent((object) this, new dsPropertyRater.lstPropRater_CoverageTypesRowChangeEvent((dsPropertyRater.lstPropRater_CoverageTypesRow) e.Row, e.Action));
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
      dsPropertyRater.lstPropRater_CoverageTypesRowChangeEventHandler rowDeletingEvent = this.lstPropRater_CoverageTypesRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsPropertyRater.lstPropRater_CoverageTypesRowChangeEvent((dsPropertyRater.lstPropRater_CoverageTypesRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemovelstPropRater_CoverageTypesRow(
      dsPropertyRater.lstPropRater_CoverageTypesRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsPropertyRater dsPropertyRater = new dsPropertyRater();
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
        FixedValue = dsPropertyRater.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (lstPropRater_CoverageTypesDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsPropertyRater.GetSchemaSerializable();
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
    TypedTableBase<dsPropertyRater.lstPropRater_ValuationRow>
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
    public dsPropertyRater.lstPropRater_ValuationRow this[int index]
    {
      get => (dsPropertyRater.lstPropRater_ValuationRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsPropertyRater.lstPropRater_ValuationRowChangeEventHandler lstPropRater_ValuationRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsPropertyRater.lstPropRater_ValuationRowChangeEventHandler lstPropRater_ValuationRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsPropertyRater.lstPropRater_ValuationRowChangeEventHandler lstPropRater_ValuationRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsPropertyRater.lstPropRater_ValuationRowChangeEventHandler lstPropRater_ValuationRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AddlstPropRater_ValuationRow(dsPropertyRater.lstPropRater_ValuationRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPropertyRater.lstPropRater_ValuationRow AddlstPropRater_ValuationRow(
      int ID,
      string Valuation)
    {
      dsPropertyRater.lstPropRater_ValuationRow row = (dsPropertyRater.lstPropRater_ValuationRow) this.NewRow();
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
    public dsPropertyRater.lstPropRater_ValuationRow FindByID(int ID)
    {
      return (dsPropertyRater.lstPropRater_ValuationRow) this.Rows.Find(new object[1]
      {
        (object) ID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsPropertyRater.lstPropRater_ValuationDataTable valuationDataTable = (dsPropertyRater.lstPropRater_ValuationDataTable) base.Clone();
      valuationDataTable.InitVars();
      return (DataTable) valuationDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsPropertyRater.lstPropRater_ValuationDataTable();
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
      this.Constraints.Add((Constraint) new UniqueConstraint("dsPropertyRaterKey3", new DataColumn[1]
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
    public dsPropertyRater.lstPropRater_ValuationRow NewlstPropRater_ValuationRow()
    {
      return (dsPropertyRater.lstPropRater_ValuationRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsPropertyRater.lstPropRater_ValuationRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType() => typeof (dsPropertyRater.lstPropRater_ValuationRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstPropRater_ValuationRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPropertyRater.lstPropRater_ValuationRowChangeEventHandler valuationRowChangedEvent = this.lstPropRater_ValuationRowChangedEvent;
      if (valuationRowChangedEvent == null)
        return;
      valuationRowChangedEvent((object) this, new dsPropertyRater.lstPropRater_ValuationRowChangeEvent((dsPropertyRater.lstPropRater_ValuationRow) e.Row, e.Action));
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
      dsPropertyRater.lstPropRater_ValuationRowChangeEventHandler rowChangingEvent = this.lstPropRater_ValuationRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsPropertyRater.lstPropRater_ValuationRowChangeEvent((dsPropertyRater.lstPropRater_ValuationRow) e.Row, e.Action));
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
      dsPropertyRater.lstPropRater_ValuationRowChangeEventHandler valuationRowDeletedEvent = this.lstPropRater_ValuationRowDeletedEvent;
      if (valuationRowDeletedEvent == null)
        return;
      valuationRowDeletedEvent((object) this, new dsPropertyRater.lstPropRater_ValuationRowChangeEvent((dsPropertyRater.lstPropRater_ValuationRow) e.Row, e.Action));
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
      dsPropertyRater.lstPropRater_ValuationRowChangeEventHandler rowDeletingEvent = this.lstPropRater_ValuationRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsPropertyRater.lstPropRater_ValuationRowChangeEvent((dsPropertyRater.lstPropRater_ValuationRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemovelstPropRater_ValuationRow(dsPropertyRater.lstPropRater_ValuationRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsPropertyRater dsPropertyRater = new dsPropertyRater();
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
        FixedValue = dsPropertyRater.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (lstPropRater_ValuationDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsPropertyRater.GetSchemaSerializable();
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
  public class lstPropRater_LimitDescriptionDataTable : 
    TypedTableBase<dsPropertyRater.lstPropRater_LimitDescriptionRow>
  {
    private DataColumn columnID;
    private DataColumn columnLimitDescrip;
    private DataColumn columnHidden;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public lstPropRater_LimitDescriptionDataTable()
    {
      this.TableName = "lstPropRater_LimitDescription";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal lstPropRater_LimitDescriptionDataTable(DataTable table)
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
    protected lstPropRater_LimitDescriptionDataTable(
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
    public DataColumn LimitDescripColumn => this.columnLimitDescrip;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn HiddenColumn => this.columnHidden;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPropertyRater.lstPropRater_LimitDescriptionRow this[int index]
    {
      get => (dsPropertyRater.lstPropRater_LimitDescriptionRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsPropertyRater.lstPropRater_LimitDescriptionRowChangeEventHandler lstPropRater_LimitDescriptionRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsPropertyRater.lstPropRater_LimitDescriptionRowChangeEventHandler lstPropRater_LimitDescriptionRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsPropertyRater.lstPropRater_LimitDescriptionRowChangeEventHandler lstPropRater_LimitDescriptionRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsPropertyRater.lstPropRater_LimitDescriptionRowChangeEventHandler lstPropRater_LimitDescriptionRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AddlstPropRater_LimitDescriptionRow(
      dsPropertyRater.lstPropRater_LimitDescriptionRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPropertyRater.lstPropRater_LimitDescriptionRow AddlstPropRater_LimitDescriptionRow(
      int ID,
      string LimitDescrip,
      bool Hidden)
    {
      dsPropertyRater.lstPropRater_LimitDescriptionRow row = (dsPropertyRater.lstPropRater_LimitDescriptionRow) this.NewRow();
      object[] objArray = new object[3]
      {
        (object) ID,
        (object) LimitDescrip,
        (object) Hidden
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPropertyRater.lstPropRater_LimitDescriptionRow FindByID(int ID)
    {
      return (dsPropertyRater.lstPropRater_LimitDescriptionRow) this.Rows.Find(new object[1]
      {
        (object) ID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsPropertyRater.lstPropRater_LimitDescriptionDataTable descriptionDataTable = (dsPropertyRater.lstPropRater_LimitDescriptionDataTable) base.Clone();
      descriptionDataTable.InitVars();
      return (DataTable) descriptionDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsPropertyRater.lstPropRater_LimitDescriptionDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal void InitVars()
    {
      this.columnID = this.Columns["ID"];
      this.columnLimitDescrip = this.Columns["LimitDescrip"];
      this.columnHidden = this.Columns["Hidden"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.columnID = new DataColumn("ID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnID);
      this.columnLimitDescrip = new DataColumn("LimitDescrip", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLimitDescrip);
      this.columnHidden = new DataColumn("Hidden", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnHidden);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsPropertyRaterKey4", new DataColumn[1]
      {
        this.columnID
      }, true));
      this.columnID.AllowDBNull = false;
      this.columnID.ReadOnly = true;
      this.columnID.Unique = true;
      this.columnLimitDescrip.AllowDBNull = false;
      this.columnHidden.DefaultValue = (object) false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPropertyRater.lstPropRater_LimitDescriptionRow NewlstPropRater_LimitDescriptionRow()
    {
      return (dsPropertyRater.lstPropRater_LimitDescriptionRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsPropertyRater.lstPropRater_LimitDescriptionRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType()
    {
      return typeof (dsPropertyRater.lstPropRater_LimitDescriptionRow);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstPropRater_LimitDescriptionRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPropertyRater.lstPropRater_LimitDescriptionRowChangeEventHandler descriptionRowChangedEvent = this.lstPropRater_LimitDescriptionRowChangedEvent;
      if (descriptionRowChangedEvent == null)
        return;
      descriptionRowChangedEvent((object) this, new dsPropertyRater.lstPropRater_LimitDescriptionRowChangeEvent((dsPropertyRater.lstPropRater_LimitDescriptionRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstPropRater_LimitDescriptionRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPropertyRater.lstPropRater_LimitDescriptionRowChangeEventHandler rowChangingEvent = this.lstPropRater_LimitDescriptionRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsPropertyRater.lstPropRater_LimitDescriptionRowChangeEvent((dsPropertyRater.lstPropRater_LimitDescriptionRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstPropRater_LimitDescriptionRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPropertyRater.lstPropRater_LimitDescriptionRowChangeEventHandler descriptionRowDeletedEvent = this.lstPropRater_LimitDescriptionRowDeletedEvent;
      if (descriptionRowDeletedEvent == null)
        return;
      descriptionRowDeletedEvent((object) this, new dsPropertyRater.lstPropRater_LimitDescriptionRowChangeEvent((dsPropertyRater.lstPropRater_LimitDescriptionRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstPropRater_LimitDescriptionRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPropertyRater.lstPropRater_LimitDescriptionRowChangeEventHandler rowDeletingEvent = this.lstPropRater_LimitDescriptionRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsPropertyRater.lstPropRater_LimitDescriptionRowChangeEvent((dsPropertyRater.lstPropRater_LimitDescriptionRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemovelstPropRater_LimitDescriptionRow(
      dsPropertyRater.lstPropRater_LimitDescriptionRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsPropertyRater dsPropertyRater = new dsPropertyRater();
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
        FixedValue = dsPropertyRater.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (lstPropRater_LimitDescriptionDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsPropertyRater.GetSchemaSerializable();
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
  public class lstPolicyFormDataTable : TypedTableBase<dsPropertyRater.lstPolicyFormRow>
  {
    private DataColumn columnID;
    private DataColumn columnPolicyForm;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public lstPolicyFormDataTable()
    {
      this.TableName = "lstPolicyForm";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal lstPolicyFormDataTable(DataTable table)
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
    protected lstPolicyFormDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn IDColumn => this.columnID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn PolicyFormColumn => this.columnPolicyForm;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPropertyRater.lstPolicyFormRow this[int index]
    {
      get => (dsPropertyRater.lstPolicyFormRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsPropertyRater.lstPolicyFormRowChangeEventHandler lstPolicyFormRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsPropertyRater.lstPolicyFormRowChangeEventHandler lstPolicyFormRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsPropertyRater.lstPolicyFormRowChangeEventHandler lstPolicyFormRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsPropertyRater.lstPolicyFormRowChangeEventHandler lstPolicyFormRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AddlstPolicyFormRow(dsPropertyRater.lstPolicyFormRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPropertyRater.lstPolicyFormRow AddlstPolicyFormRow(int ID, string PolicyForm)
    {
      dsPropertyRater.lstPolicyFormRow row = (dsPropertyRater.lstPolicyFormRow) this.NewRow();
      object[] objArray = new object[2]
      {
        (object) ID,
        (object) PolicyForm
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPropertyRater.lstPolicyFormRow FindByID(int ID)
    {
      return (dsPropertyRater.lstPolicyFormRow) this.Rows.Find(new object[1]
      {
        (object) ID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsPropertyRater.lstPolicyFormDataTable policyFormDataTable = (dsPropertyRater.lstPolicyFormDataTable) base.Clone();
      policyFormDataTable.InitVars();
      return (DataTable) policyFormDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsPropertyRater.lstPolicyFormDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal void InitVars()
    {
      this.columnID = this.Columns["ID"];
      this.columnPolicyForm = this.Columns["PolicyForm"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.columnID = new DataColumn("ID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnID);
      this.columnPolicyForm = new DataColumn("PolicyForm", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPolicyForm);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsPropertyRaterKey5", new DataColumn[1]
      {
        this.columnID
      }, true));
      this.columnID.AllowDBNull = false;
      this.columnID.ReadOnly = true;
      this.columnID.Unique = true;
      this.columnPolicyForm.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPropertyRater.lstPolicyFormRow NewlstPolicyFormRow()
    {
      return (dsPropertyRater.lstPolicyFormRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsPropertyRater.lstPolicyFormRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType() => typeof (dsPropertyRater.lstPolicyFormRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstPolicyFormRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPropertyRater.lstPolicyFormRowChangeEventHandler formRowChangedEvent = this.lstPolicyFormRowChangedEvent;
      if (formRowChangedEvent == null)
        return;
      formRowChangedEvent((object) this, new dsPropertyRater.lstPolicyFormRowChangeEvent((dsPropertyRater.lstPolicyFormRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstPolicyFormRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPropertyRater.lstPolicyFormRowChangeEventHandler rowChangingEvent = this.lstPolicyFormRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsPropertyRater.lstPolicyFormRowChangeEvent((dsPropertyRater.lstPolicyFormRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstPolicyFormRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPropertyRater.lstPolicyFormRowChangeEventHandler formRowDeletedEvent = this.lstPolicyFormRowDeletedEvent;
      if (formRowDeletedEvent == null)
        return;
      formRowDeletedEvent((object) this, new dsPropertyRater.lstPolicyFormRowChangeEvent((dsPropertyRater.lstPolicyFormRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstPolicyFormRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPropertyRater.lstPolicyFormRowChangeEventHandler rowDeletingEvent = this.lstPolicyFormRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsPropertyRater.lstPolicyFormRowChangeEvent((dsPropertyRater.lstPolicyFormRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemovelstPolicyFormRow(dsPropertyRater.lstPolicyFormRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsPropertyRater dsPropertyRater = new dsPropertyRater();
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
        FixedValue = dsPropertyRater.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (lstPolicyFormDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsPropertyRater.GetSchemaSerializable();
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
    TypedTableBase<dsPropertyRater.lstPropRater_CauseOfLossRow>
  {
    private DataColumn columnID;
    private DataColumn columnPeril;
    private DataColumn columnHidden;

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
    public DataColumn HiddenColumn => this.columnHidden;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPropertyRater.lstPropRater_CauseOfLossRow this[int index]
    {
      get => (dsPropertyRater.lstPropRater_CauseOfLossRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsPropertyRater.lstPropRater_CauseOfLossRowChangeEventHandler lstPropRater_CauseOfLossRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsPropertyRater.lstPropRater_CauseOfLossRowChangeEventHandler lstPropRater_CauseOfLossRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsPropertyRater.lstPropRater_CauseOfLossRowChangeEventHandler lstPropRater_CauseOfLossRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsPropertyRater.lstPropRater_CauseOfLossRowChangeEventHandler lstPropRater_CauseOfLossRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AddlstPropRater_CauseOfLossRow(dsPropertyRater.lstPropRater_CauseOfLossRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPropertyRater.lstPropRater_CauseOfLossRow AddlstPropRater_CauseOfLossRow(
      int ID,
      string Peril,
      string Hidden)
    {
      dsPropertyRater.lstPropRater_CauseOfLossRow row = (dsPropertyRater.lstPropRater_CauseOfLossRow) this.NewRow();
      object[] objArray = new object[3]
      {
        (object) ID,
        (object) Peril,
        (object) Hidden
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPropertyRater.lstPropRater_CauseOfLossRow FindByID(int ID)
    {
      return (dsPropertyRater.lstPropRater_CauseOfLossRow) this.Rows.Find(new object[1]
      {
        (object) ID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsPropertyRater.lstPropRater_CauseOfLossDataTable causeOfLossDataTable = (dsPropertyRater.lstPropRater_CauseOfLossDataTable) base.Clone();
      causeOfLossDataTable.InitVars();
      return (DataTable) causeOfLossDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsPropertyRater.lstPropRater_CauseOfLossDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal void InitVars()
    {
      this.columnID = this.Columns["ID"];
      this.columnPeril = this.Columns["Peril"];
      this.columnHidden = this.Columns["Hidden"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.columnID = new DataColumn("ID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnID);
      this.columnPeril = new DataColumn("Peril", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPeril);
      this.columnHidden = new DataColumn("Hidden", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnHidden);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsPropertyRaterKey6", new DataColumn[1]
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
    public dsPropertyRater.lstPropRater_CauseOfLossRow NewlstPropRater_CauseOfLossRow()
    {
      return (dsPropertyRater.lstPropRater_CauseOfLossRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsPropertyRater.lstPropRater_CauseOfLossRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType() => typeof (dsPropertyRater.lstPropRater_CauseOfLossRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstPropRater_CauseOfLossRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPropertyRater.lstPropRater_CauseOfLossRowChangeEventHandler lossRowChangedEvent = this.lstPropRater_CauseOfLossRowChangedEvent;
      if (lossRowChangedEvent == null)
        return;
      lossRowChangedEvent((object) this, new dsPropertyRater.lstPropRater_CauseOfLossRowChangeEvent((dsPropertyRater.lstPropRater_CauseOfLossRow) e.Row, e.Action));
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
      dsPropertyRater.lstPropRater_CauseOfLossRowChangeEventHandler rowChangingEvent = this.lstPropRater_CauseOfLossRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsPropertyRater.lstPropRater_CauseOfLossRowChangeEvent((dsPropertyRater.lstPropRater_CauseOfLossRow) e.Row, e.Action));
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
      dsPropertyRater.lstPropRater_CauseOfLossRowChangeEventHandler lossRowDeletedEvent = this.lstPropRater_CauseOfLossRowDeletedEvent;
      if (lossRowDeletedEvent == null)
        return;
      lossRowDeletedEvent((object) this, new dsPropertyRater.lstPropRater_CauseOfLossRowChangeEvent((dsPropertyRater.lstPropRater_CauseOfLossRow) e.Row, e.Action));
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
      dsPropertyRater.lstPropRater_CauseOfLossRowChangeEventHandler rowDeletingEvent = this.lstPropRater_CauseOfLossRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsPropertyRater.lstPropRater_CauseOfLossRowChangeEvent((dsPropertyRater.lstPropRater_CauseOfLossRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemovelstPropRater_CauseOfLossRow(dsPropertyRater.lstPropRater_CauseOfLossRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsPropertyRater dsPropertyRater = new dsPropertyRater();
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
        FixedValue = dsPropertyRater.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (lstPropRater_CauseOfLossDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsPropertyRater.GetSchemaSerializable();
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
  public class tblQuoteOptionsDataTable : TypedTableBase<dsPropertyRater.tblQuoteOptionsRow>
  {
    private DataColumn columnQuoteOptionID;
    private DataColumn columnQuoteOptionGUID;
    private DataColumn columnQuoteGUID;
    private DataColumn columnLineGUID;
    private DataColumn columnPremium;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public tblQuoteOptionsDataTable()
    {
      this.TableName = "tblQuoteOptions";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal tblQuoteOptionsDataTable(DataTable table)
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
    protected tblQuoteOptionsDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn QuoteOptionIDColumn => this.columnQuoteOptionID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn QuoteOptionGUIDColumn => this.columnQuoteOptionGUID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn QuoteGUIDColumn => this.columnQuoteGUID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn LineGUIDColumn => this.columnLineGUID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn PremiumColumn => this.columnPremium;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPropertyRater.tblQuoteOptionsRow this[int index]
    {
      get => (dsPropertyRater.tblQuoteOptionsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsPropertyRater.tblQuoteOptionsRowChangeEventHandler tblQuoteOptionsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsPropertyRater.tblQuoteOptionsRowChangeEventHandler tblQuoteOptionsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsPropertyRater.tblQuoteOptionsRowChangeEventHandler tblQuoteOptionsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsPropertyRater.tblQuoteOptionsRowChangeEventHandler tblQuoteOptionsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AddtblQuoteOptionsRow(dsPropertyRater.tblQuoteOptionsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPropertyRater.tblQuoteOptionsRow AddtblQuoteOptionsRow(
      Guid QuoteOptionGUID,
      Guid QuoteGUID,
      Guid LineGUID,
      Decimal Premium)
    {
      dsPropertyRater.tblQuoteOptionsRow row = (dsPropertyRater.tblQuoteOptionsRow) this.NewRow();
      object[] objArray = new object[5]
      {
        null,
        (object) QuoteOptionGUID,
        (object) QuoteGUID,
        (object) LineGUID,
        (object) Premium
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPropertyRater.tblQuoteOptionsRow FindByQuoteOptionID(int QuoteOptionID)
    {
      return (dsPropertyRater.tblQuoteOptionsRow) this.Rows.Find(new object[1]
      {
        (object) QuoteOptionID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsPropertyRater.tblQuoteOptionsDataTable optionsDataTable = (dsPropertyRater.tblQuoteOptionsDataTable) base.Clone();
      optionsDataTable.InitVars();
      return (DataTable) optionsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsPropertyRater.tblQuoteOptionsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal void InitVars()
    {
      this.columnQuoteOptionID = this.Columns["QuoteOptionID"];
      this.columnQuoteOptionGUID = this.Columns["QuoteOptionGUID"];
      this.columnQuoteGUID = this.Columns["QuoteGUID"];
      this.columnLineGUID = this.Columns["LineGUID"];
      this.columnPremium = this.Columns["Premium"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.columnQuoteOptionID = new DataColumn("QuoteOptionID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnQuoteOptionID);
      this.columnQuoteOptionGUID = new DataColumn("QuoteOptionGUID", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnQuoteOptionGUID);
      this.columnQuoteGUID = new DataColumn("QuoteGUID", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnQuoteGUID);
      this.columnLineGUID = new DataColumn("LineGUID", typeof (Guid), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLineGUID);
      this.columnPremium = new DataColumn("Premium", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPremium);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsPropertyRaterKey7", new DataColumn[1]
      {
        this.columnQuoteOptionID
      }, true));
      this.columnQuoteOptionID.AutoIncrement = true;
      this.columnQuoteOptionID.AllowDBNull = false;
      this.columnQuoteOptionID.ReadOnly = true;
      this.columnQuoteOptionID.Unique = true;
      this.columnQuoteOptionGUID.AllowDBNull = false;
      this.columnQuoteGUID.AllowDBNull = false;
      this.columnLineGUID.AllowDBNull = false;
      this.columnPremium.AllowDBNull = false;
      this.columnPremium.DefaultValue = (object) 0M;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPropertyRater.tblQuoteOptionsRow NewtblQuoteOptionsRow()
    {
      return (dsPropertyRater.tblQuoteOptionsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsPropertyRater.tblQuoteOptionsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType() => typeof (dsPropertyRater.tblQuoteOptionsRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblQuoteOptionsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPropertyRater.tblQuoteOptionsRowChangeEventHandler optionsRowChangedEvent = this.tblQuoteOptionsRowChangedEvent;
      if (optionsRowChangedEvent == null)
        return;
      optionsRowChangedEvent((object) this, new dsPropertyRater.tblQuoteOptionsRowChangeEvent((dsPropertyRater.tblQuoteOptionsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblQuoteOptionsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPropertyRater.tblQuoteOptionsRowChangeEventHandler rowChangingEvent = this.tblQuoteOptionsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsPropertyRater.tblQuoteOptionsRowChangeEvent((dsPropertyRater.tblQuoteOptionsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblQuoteOptionsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPropertyRater.tblQuoteOptionsRowChangeEventHandler optionsRowDeletedEvent = this.tblQuoteOptionsRowDeletedEvent;
      if (optionsRowDeletedEvent == null)
        return;
      optionsRowDeletedEvent((object) this, new dsPropertyRater.tblQuoteOptionsRowChangeEvent((dsPropertyRater.tblQuoteOptionsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblQuoteOptionsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPropertyRater.tblQuoteOptionsRowChangeEventHandler rowDeletingEvent = this.tblQuoteOptionsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsPropertyRater.tblQuoteOptionsRowChangeEvent((dsPropertyRater.tblQuoteOptionsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemovetblQuoteOptionsRow(dsPropertyRater.tblQuoteOptionsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsPropertyRater dsPropertyRater = new dsPropertyRater();
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
        FixedValue = dsPropertyRater.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblQuoteOptionsDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsPropertyRater.GetSchemaSerializable();
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
  public class tblQuoteOptionPropertyDataTable : 
    TypedTableBase<dsPropertyRater.tblQuoteOptionPropertyRow>
  {
    private DataColumn columnID;
    private DataColumn columnPriorID;
    private DataColumn columnQuoteOptionID;
    private DataColumn columnTerrorismDeclined;
    private DataColumn columnCauseofLossID;
    private DataColumn columnPolicyLimitDescriptionID;
    private DataColumn columnPolicyFormID;
    private DataColumn columnValuationID;
    private DataColumn columnCoInsuranceID;
    private DataColumn columnTIV;
    private DataColumn columnCoverage;
    private DataColumn columnPolicyLimit;
    private DataColumn columnSubLimits;
    private DataColumn columnAOPDA;
    private DataColumn columnDeductiblePerID;
    private DataColumn columnOtherDeduct;
    private DataColumn columnPrimaryPremium;
    private DataColumn columnExcessPremium;
    private DataColumn columnTerrPremium;
    private DataColumn columnAdditionalComments;
    private DataColumn columnCoInsurance;
    private DataColumn columnRate;
    private DataColumn columnPriorRate;
    private DataColumn columnValuation;
    private DataColumn columnUnderlyingCarrier;
    private DataColumn columnUnderlyingPolNo;
    private DataColumn columnUnderlyingLimit;
    private DataColumn columnUnderlyingDA;
    private DataColumn columnRateBasedOffTIV;
    private DataColumn columnTerrorismExcessPremium;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public tblQuoteOptionPropertyDataTable()
    {
      this.TableName = "tblQuoteOptionProperty";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal tblQuoteOptionPropertyDataTable(DataTable table)
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
    protected tblQuoteOptionPropertyDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn IDColumn => this.columnID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn PriorIDColumn => this.columnPriorID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn QuoteOptionIDColumn => this.columnQuoteOptionID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn TerrorismDeclinedColumn => this.columnTerrorismDeclined;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn CauseofLossIDColumn => this.columnCauseofLossID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn PolicyLimitDescriptionIDColumn => this.columnPolicyLimitDescriptionID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn PolicyFormIDColumn => this.columnPolicyFormID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ValuationIDColumn => this.columnValuationID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn CoInsuranceIDColumn => this.columnCoInsuranceID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn TIVColumn => this.columnTIV;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn CoverageColumn => this.columnCoverage;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn PolicyLimitColumn => this.columnPolicyLimit;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn SubLimitsColumn => this.columnSubLimits;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn AOPDAColumn => this.columnAOPDA;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn DeductiblePerIDColumn => this.columnDeductiblePerID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn OtherDeductColumn => this.columnOtherDeduct;

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
    public DataColumn AdditionalCommentsColumn => this.columnAdditionalComments;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn CoInsuranceColumn => this.columnCoInsurance;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn RateColumn => this.columnRate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn PriorRateColumn => this.columnPriorRate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ValuationColumn => this.columnValuation;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn UnderlyingCarrierColumn => this.columnUnderlyingCarrier;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn UnderlyingPolNoColumn => this.columnUnderlyingPolNo;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn UnderlyingLimitColumn => this.columnUnderlyingLimit;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn UnderlyingDAColumn => this.columnUnderlyingDA;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn RateBasedOffTIVColumn => this.columnRateBasedOffTIV;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn TerrorismExcessPremiumColumn => this.columnTerrorismExcessPremium;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPropertyRater.tblQuoteOptionPropertyRow this[int index]
    {
      get => (dsPropertyRater.tblQuoteOptionPropertyRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsPropertyRater.tblQuoteOptionPropertyRowChangeEventHandler tblQuoteOptionPropertyRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsPropertyRater.tblQuoteOptionPropertyRowChangeEventHandler tblQuoteOptionPropertyRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsPropertyRater.tblQuoteOptionPropertyRowChangeEventHandler tblQuoteOptionPropertyRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsPropertyRater.tblQuoteOptionPropertyRowChangeEventHandler tblQuoteOptionPropertyRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AddtblQuoteOptionPropertyRow(dsPropertyRater.tblQuoteOptionPropertyRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPropertyRater.tblQuoteOptionPropertyRow AddtblQuoteOptionPropertyRow(
      int PriorID,
      dsPropertyRater.tblQuoteOptionsRow parenttblQuoteOptionsRowBytblQuoteOptionstblQuoteOptionProperty,
      bool TerrorismDeclined,
      int CauseofLossID,
      int PolicyLimitDescriptionID,
      int PolicyFormID,
      int ValuationID,
      int CoInsuranceID,
      Decimal TIV,
      string Coverage,
      Decimal PolicyLimit,
      string SubLimits,
      int AOPDA,
      string DeductiblePerID,
      string OtherDeduct,
      Decimal PrimaryPremium,
      Decimal ExcessPremium,
      Decimal TerrPremium,
      string AdditionalComments,
      string CoInsurance,
      Decimal Rate,
      Decimal PriorRate,
      string Valuation,
      string UnderlyingCarrier,
      string UnderlyingPolNo,
      string UnderlyingLimit,
      string UnderlyingDA,
      bool RateBasedOffTIV,
      Decimal TerrorismExcessPremium)
    {
      dsPropertyRater.tblQuoteOptionPropertyRow row = (dsPropertyRater.tblQuoteOptionPropertyRow) this.NewRow();
      object[] objArray = new object[30]
      {
        null,
        (object) PriorID,
        null,
        (object) TerrorismDeclined,
        (object) CauseofLossID,
        (object) PolicyLimitDescriptionID,
        (object) PolicyFormID,
        (object) ValuationID,
        (object) CoInsuranceID,
        (object) TIV,
        (object) Coverage,
        (object) PolicyLimit,
        (object) SubLimits,
        (object) AOPDA,
        (object) DeductiblePerID,
        (object) OtherDeduct,
        (object) PrimaryPremium,
        (object) ExcessPremium,
        (object) TerrPremium,
        (object) AdditionalComments,
        (object) CoInsurance,
        (object) Rate,
        (object) PriorRate,
        (object) Valuation,
        (object) UnderlyingCarrier,
        (object) UnderlyingPolNo,
        (object) UnderlyingLimit,
        (object) UnderlyingDA,
        (object) RateBasedOffTIV,
        (object) TerrorismExcessPremium
      };
      if (parenttblQuoteOptionsRowBytblQuoteOptionstblQuoteOptionProperty != null)
        objArray[2] = RuntimeHelpers.GetObjectValue(parenttblQuoteOptionsRowBytblQuoteOptionstblQuoteOptionProperty[0]);
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPropertyRater.tblQuoteOptionPropertyRow FindByID(int ID)
    {
      return (dsPropertyRater.tblQuoteOptionPropertyRow) this.Rows.Find(new object[1]
      {
        (object) ID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsPropertyRater.tblQuoteOptionPropertyDataTable propertyDataTable = (dsPropertyRater.tblQuoteOptionPropertyDataTable) base.Clone();
      propertyDataTable.InitVars();
      return (DataTable) propertyDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsPropertyRater.tblQuoteOptionPropertyDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal void InitVars()
    {
      this.columnID = this.Columns["ID"];
      this.columnPriorID = this.Columns["PriorID"];
      this.columnQuoteOptionID = this.Columns["QuoteOptionID"];
      this.columnTerrorismDeclined = this.Columns["TerrorismDeclined"];
      this.columnCauseofLossID = this.Columns["CauseofLossID"];
      this.columnPolicyLimitDescriptionID = this.Columns["PolicyLimitDescriptionID"];
      this.columnPolicyFormID = this.Columns["PolicyFormID"];
      this.columnValuationID = this.Columns["ValuationID"];
      this.columnCoInsuranceID = this.Columns["CoInsuranceID"];
      this.columnTIV = this.Columns["TIV"];
      this.columnCoverage = this.Columns["Coverage"];
      this.columnPolicyLimit = this.Columns["PolicyLimit"];
      this.columnSubLimits = this.Columns["SubLimits"];
      this.columnAOPDA = this.Columns["AOPDA"];
      this.columnDeductiblePerID = this.Columns["DeductiblePerID"];
      this.columnOtherDeduct = this.Columns["OtherDeduct"];
      this.columnPrimaryPremium = this.Columns["PrimaryPremium"];
      this.columnExcessPremium = this.Columns["ExcessPremium"];
      this.columnTerrPremium = this.Columns["TerrPremium"];
      this.columnAdditionalComments = this.Columns["AdditionalComments"];
      this.columnCoInsurance = this.Columns["CoInsurance"];
      this.columnRate = this.Columns["Rate"];
      this.columnPriorRate = this.Columns["PriorRate"];
      this.columnValuation = this.Columns["Valuation"];
      this.columnUnderlyingCarrier = this.Columns["UnderlyingCarrier"];
      this.columnUnderlyingPolNo = this.Columns["UnderlyingPolNo"];
      this.columnUnderlyingLimit = this.Columns["UnderlyingLimit"];
      this.columnUnderlyingDA = this.Columns["UnderlyingDA"];
      this.columnRateBasedOffTIV = this.Columns["RateBasedOffTIV"];
      this.columnTerrorismExcessPremium = this.Columns["TerrorismExcessPremium"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.columnID = new DataColumn("ID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnID);
      this.columnPriorID = new DataColumn("PriorID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPriorID);
      this.columnQuoteOptionID = new DataColumn("QuoteOptionID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnQuoteOptionID);
      this.columnTerrorismDeclined = new DataColumn("TerrorismDeclined", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnTerrorismDeclined);
      this.columnCauseofLossID = new DataColumn("CauseofLossID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCauseofLossID);
      this.columnPolicyLimitDescriptionID = new DataColumn("PolicyLimitDescriptionID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPolicyLimitDescriptionID);
      this.columnPolicyFormID = new DataColumn("PolicyFormID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPolicyFormID);
      this.columnValuationID = new DataColumn("ValuationID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnValuationID);
      this.columnCoInsuranceID = new DataColumn("CoInsuranceID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCoInsuranceID);
      this.columnTIV = new DataColumn("TIV", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnTIV);
      this.columnCoverage = new DataColumn("Coverage", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCoverage);
      this.columnPolicyLimit = new DataColumn("PolicyLimit", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPolicyLimit);
      this.columnSubLimits = new DataColumn("SubLimits", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSubLimits);
      this.columnAOPDA = new DataColumn("AOPDA", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAOPDA);
      this.columnDeductiblePerID = new DataColumn("DeductiblePerID", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDeductiblePerID);
      this.columnOtherDeduct = new DataColumn("OtherDeduct", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnOtherDeduct);
      this.columnPrimaryPremium = new DataColumn("PrimaryPremium", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPrimaryPremium);
      this.columnExcessPremium = new DataColumn("ExcessPremium", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnExcessPremium);
      this.columnTerrPremium = new DataColumn("TerrPremium", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnTerrPremium);
      this.columnAdditionalComments = new DataColumn("AdditionalComments", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnAdditionalComments);
      this.columnCoInsurance = new DataColumn("CoInsurance", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnCoInsurance);
      this.columnRate = new DataColumn("Rate", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnRate);
      this.columnPriorRate = new DataColumn("PriorRate", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPriorRate);
      this.columnValuation = new DataColumn("Valuation", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnValuation);
      this.columnUnderlyingCarrier = new DataColumn("UnderlyingCarrier", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnUnderlyingCarrier);
      this.columnUnderlyingPolNo = new DataColumn("UnderlyingPolNo", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnUnderlyingPolNo);
      this.columnUnderlyingLimit = new DataColumn("UnderlyingLimit", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnUnderlyingLimit);
      this.columnUnderlyingDA = new DataColumn("UnderlyingDA", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnUnderlyingDA);
      this.columnRateBasedOffTIV = new DataColumn("RateBasedOffTIV", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnRateBasedOffTIV);
      this.columnTerrorismExcessPremium = new DataColumn("TerrorismExcessPremium", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnTerrorismExcessPremium);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsPropertyRaterKey8", new DataColumn[1]
      {
        this.columnID
      }, true));
      this.columnID.AutoIncrement = true;
      this.columnID.AllowDBNull = false;
      this.columnID.ReadOnly = true;
      this.columnID.Unique = true;
      this.columnTerrorismDeclined.AllowDBNull = false;
      this.columnTerrorismDeclined.DefaultValue = (object) false;
      this.columnDeductiblePerID.AllowDBNull = false;
      this.columnPrimaryPremium.AllowDBNull = false;
      this.columnPrimaryPremium.DefaultValue = (object) 0M;
      this.columnExcessPremium.AllowDBNull = false;
      this.columnExcessPremium.DefaultValue = (object) 0M;
      this.columnTerrPremium.AllowDBNull = false;
      this.columnTerrPremium.DefaultValue = (object) 0M;
      this.columnRateBasedOffTIV.AllowDBNull = false;
      this.columnRateBasedOffTIV.DefaultValue = (object) true;
      this.columnTerrorismExcessPremium.AllowDBNull = false;
      this.columnTerrorismExcessPremium.DefaultValue = (object) 0M;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPropertyRater.tblQuoteOptionPropertyRow NewtblQuoteOptionPropertyRow()
    {
      return (dsPropertyRater.tblQuoteOptionPropertyRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsPropertyRater.tblQuoteOptionPropertyRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType() => typeof (dsPropertyRater.tblQuoteOptionPropertyRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblQuoteOptionPropertyRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPropertyRater.tblQuoteOptionPropertyRowChangeEventHandler propertyRowChangedEvent = this.tblQuoteOptionPropertyRowChangedEvent;
      if (propertyRowChangedEvent == null)
        return;
      propertyRowChangedEvent((object) this, new dsPropertyRater.tblQuoteOptionPropertyRowChangeEvent((dsPropertyRater.tblQuoteOptionPropertyRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblQuoteOptionPropertyRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPropertyRater.tblQuoteOptionPropertyRowChangeEventHandler rowChangingEvent = this.tblQuoteOptionPropertyRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsPropertyRater.tblQuoteOptionPropertyRowChangeEvent((dsPropertyRater.tblQuoteOptionPropertyRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblQuoteOptionPropertyRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPropertyRater.tblQuoteOptionPropertyRowChangeEventHandler propertyRowDeletedEvent = this.tblQuoteOptionPropertyRowDeletedEvent;
      if (propertyRowDeletedEvent == null)
        return;
      propertyRowDeletedEvent((object) this, new dsPropertyRater.tblQuoteOptionPropertyRowChangeEvent((dsPropertyRater.tblQuoteOptionPropertyRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblQuoteOptionPropertyRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPropertyRater.tblQuoteOptionPropertyRowChangeEventHandler rowDeletingEvent = this.tblQuoteOptionPropertyRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsPropertyRater.tblQuoteOptionPropertyRowChangeEvent((dsPropertyRater.tblQuoteOptionPropertyRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemovetblQuoteOptionPropertyRow(dsPropertyRater.tblQuoteOptionPropertyRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsPropertyRater dsPropertyRater = new dsPropertyRater();
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
        FixedValue = dsPropertyRater.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblQuoteOptionPropertyDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsPropertyRater.GetSchemaSerializable();
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
  public class tblQuoteOptionProperty_SubLimitsDataTable : 
    TypedTableBase<dsPropertyRater.tblQuoteOptionProperty_SubLimitsRow>
  {
    private DataColumn columnPropertyOptionID;
    private DataColumn columnSubLimitID;
    private DataColumn columnLimit;
    private DataColumn columnDeductible;
    private DataColumn columnDeductiblePercentage;
    private DataColumn columnDeleteLink;
    private DataColumn columnModificationCode;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public tblQuoteOptionProperty_SubLimitsDataTable()
    {
      this.TableName = "tblQuoteOptionProperty_SubLimits";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal tblQuoteOptionProperty_SubLimitsDataTable(DataTable table)
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
    protected tblQuoteOptionProperty_SubLimitsDataTable(
      SerializationInfo info,
      StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn PropertyOptionIDColumn => this.columnPropertyOptionID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn SubLimitIDColumn => this.columnSubLimitID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn LimitColumn => this.columnLimit;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn DeductibleColumn => this.columnDeductible;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn DeductiblePercentageColumn => this.columnDeductiblePercentage;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn DeleteLinkColumn => this.columnDeleteLink;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn ModificationCodeColumn => this.columnModificationCode;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPropertyRater.tblQuoteOptionProperty_SubLimitsRow this[int index]
    {
      get => (dsPropertyRater.tblQuoteOptionProperty_SubLimitsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsPropertyRater.tblQuoteOptionProperty_SubLimitsRowChangeEventHandler tblQuoteOptionProperty_SubLimitsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsPropertyRater.tblQuoteOptionProperty_SubLimitsRowChangeEventHandler tblQuoteOptionProperty_SubLimitsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsPropertyRater.tblQuoteOptionProperty_SubLimitsRowChangeEventHandler tblQuoteOptionProperty_SubLimitsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsPropertyRater.tblQuoteOptionProperty_SubLimitsRowChangeEventHandler tblQuoteOptionProperty_SubLimitsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AddtblQuoteOptionProperty_SubLimitsRow(
      dsPropertyRater.tblQuoteOptionProperty_SubLimitsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPropertyRater.tblQuoteOptionProperty_SubLimitsRow AddtblQuoteOptionProperty_SubLimitsRow(
      dsPropertyRater.tblQuoteOptionPropertyRow parenttblQuoteOptionPropertyRowBytblQuoteOptionPropertytblQuoteOptionProperty_SubLimits,
      dsPropertyRater.lstSubLimitsRow parentlstSubLimitsRowBylstSubLimitstblQuoteOptionProperty_SubLimits,
      int Limit,
      int Deductible,
      Decimal DeductiblePercentage,
      string DeleteLink,
      string ModificationCode)
    {
      dsPropertyRater.tblQuoteOptionProperty_SubLimitsRow row = (dsPropertyRater.tblQuoteOptionProperty_SubLimitsRow) this.NewRow();
      object[] objArray = new object[7]
      {
        null,
        null,
        (object) Limit,
        (object) Deductible,
        (object) DeductiblePercentage,
        (object) DeleteLink,
        (object) ModificationCode
      };
      if (parenttblQuoteOptionPropertyRowBytblQuoteOptionPropertytblQuoteOptionProperty_SubLimits != null)
        objArray[0] = RuntimeHelpers.GetObjectValue(parenttblQuoteOptionPropertyRowBytblQuoteOptionPropertytblQuoteOptionProperty_SubLimits[0]);
      if (parentlstSubLimitsRowBylstSubLimitstblQuoteOptionProperty_SubLimits != null)
        objArray[1] = RuntimeHelpers.GetObjectValue(parentlstSubLimitsRowBylstSubLimitstblQuoteOptionProperty_SubLimits[0]);
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPropertyRater.tblQuoteOptionProperty_SubLimitsRow FindByPropertyOptionIDSubLimitID(
      int PropertyOptionID,
      int SubLimitID)
    {
      return (dsPropertyRater.tblQuoteOptionProperty_SubLimitsRow) this.Rows.Find(new object[2]
      {
        (object) PropertyOptionID,
        (object) SubLimitID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsPropertyRater.tblQuoteOptionProperty_SubLimitsDataTable subLimitsDataTable = (dsPropertyRater.tblQuoteOptionProperty_SubLimitsDataTable) base.Clone();
      subLimitsDataTable.InitVars();
      return (DataTable) subLimitsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsPropertyRater.tblQuoteOptionProperty_SubLimitsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal void InitVars()
    {
      this.columnPropertyOptionID = this.Columns["PropertyOptionID"];
      this.columnSubLimitID = this.Columns["SubLimitID"];
      this.columnLimit = this.Columns["Limit"];
      this.columnDeductible = this.Columns["Deductible"];
      this.columnDeductiblePercentage = this.Columns["DeductiblePercentage"];
      this.columnDeleteLink = this.Columns["DeleteLink"];
      this.columnModificationCode = this.Columns["ModificationCode"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.columnPropertyOptionID = new DataColumn("PropertyOptionID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPropertyOptionID);
      this.columnSubLimitID = new DataColumn("SubLimitID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSubLimitID);
      this.columnLimit = new DataColumn("Limit", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnLimit);
      this.columnDeductible = new DataColumn("Deductible", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDeductible);
      this.columnDeductiblePercentage = new DataColumn("DeductiblePercentage", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDeductiblePercentage);
      this.columnDeleteLink = new DataColumn("DeleteLink", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnDeleteLink);
      this.columnModificationCode = new DataColumn("ModificationCode", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnModificationCode);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsPropertyRaterKey9", new DataColumn[2]
      {
        this.columnPropertyOptionID,
        this.columnSubLimitID
      }, true));
      this.columnPropertyOptionID.AllowDBNull = false;
      this.columnSubLimitID.AllowDBNull = false;
      this.columnDeleteLink.AllowDBNull = false;
      this.columnDeleteLink.DefaultValue = (object) "Delete";
      this.columnModificationCode.AllowDBNull = false;
      this.columnModificationCode.DefaultValue = (object) "N";
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPropertyRater.tblQuoteOptionProperty_SubLimitsRow NewtblQuoteOptionProperty_SubLimitsRow()
    {
      return (dsPropertyRater.tblQuoteOptionProperty_SubLimitsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsPropertyRater.tblQuoteOptionProperty_SubLimitsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType()
    {
      return typeof (dsPropertyRater.tblQuoteOptionProperty_SubLimitsRow);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblQuoteOptionProperty_SubLimitsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPropertyRater.tblQuoteOptionProperty_SubLimitsRowChangeEventHandler limitsRowChangedEvent = this.tblQuoteOptionProperty_SubLimitsRowChangedEvent;
      if (limitsRowChangedEvent == null)
        return;
      limitsRowChangedEvent((object) this, new dsPropertyRater.tblQuoteOptionProperty_SubLimitsRowChangeEvent((dsPropertyRater.tblQuoteOptionProperty_SubLimitsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblQuoteOptionProperty_SubLimitsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPropertyRater.tblQuoteOptionProperty_SubLimitsRowChangeEventHandler rowChangingEvent = this.tblQuoteOptionProperty_SubLimitsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsPropertyRater.tblQuoteOptionProperty_SubLimitsRowChangeEvent((dsPropertyRater.tblQuoteOptionProperty_SubLimitsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblQuoteOptionProperty_SubLimitsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPropertyRater.tblQuoteOptionProperty_SubLimitsRowChangeEventHandler limitsRowDeletedEvent = this.tblQuoteOptionProperty_SubLimitsRowDeletedEvent;
      if (limitsRowDeletedEvent == null)
        return;
      limitsRowDeletedEvent((object) this, new dsPropertyRater.tblQuoteOptionProperty_SubLimitsRowChangeEvent((dsPropertyRater.tblQuoteOptionProperty_SubLimitsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblQuoteOptionProperty_SubLimitsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPropertyRater.tblQuoteOptionProperty_SubLimitsRowChangeEventHandler rowDeletingEvent = this.tblQuoteOptionProperty_SubLimitsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsPropertyRater.tblQuoteOptionProperty_SubLimitsRowChangeEvent((dsPropertyRater.tblQuoteOptionProperty_SubLimitsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemovetblQuoteOptionProperty_SubLimitsRow(
      dsPropertyRater.tblQuoteOptionProperty_SubLimitsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsPropertyRater dsPropertyRater = new dsPropertyRater();
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
        FixedValue = dsPropertyRater.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblQuoteOptionProperty_SubLimitsDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsPropertyRater.GetSchemaSerializable();
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
  public class lstSubLimitsDataTable : TypedTableBase<dsPropertyRater.lstSubLimitsRow>
  {
    private DataColumn columnSubLimitID;
    private DataColumn columnSubLimit;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public lstSubLimitsDataTable()
    {
      this.TableName = "lstSubLimits";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal lstSubLimitsDataTable(DataTable table)
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
    protected lstSubLimitsDataTable(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn SubLimitIDColumn => this.columnSubLimitID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn SubLimitColumn => this.columnSubLimit;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPropertyRater.lstSubLimitsRow this[int index]
    {
      get => (dsPropertyRater.lstSubLimitsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsPropertyRater.lstSubLimitsRowChangeEventHandler lstSubLimitsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsPropertyRater.lstSubLimitsRowChangeEventHandler lstSubLimitsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsPropertyRater.lstSubLimitsRowChangeEventHandler lstSubLimitsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsPropertyRater.lstSubLimitsRowChangeEventHandler lstSubLimitsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AddlstSubLimitsRow(dsPropertyRater.lstSubLimitsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPropertyRater.lstSubLimitsRow AddlstSubLimitsRow(int SubLimitID, string SubLimit)
    {
      dsPropertyRater.lstSubLimitsRow row = (dsPropertyRater.lstSubLimitsRow) this.NewRow();
      object[] objArray = new object[2]
      {
        (object) SubLimitID,
        (object) SubLimit
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPropertyRater.lstSubLimitsRow FindBySubLimitID(int SubLimitID)
    {
      return (dsPropertyRater.lstSubLimitsRow) this.Rows.Find(new object[1]
      {
        (object) SubLimitID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsPropertyRater.lstSubLimitsDataTable subLimitsDataTable = (dsPropertyRater.lstSubLimitsDataTable) base.Clone();
      subLimitsDataTable.InitVars();
      return (DataTable) subLimitsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsPropertyRater.lstSubLimitsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal void InitVars()
    {
      this.columnSubLimitID = this.Columns["SubLimitID"];
      this.columnSubLimit = this.Columns["SubLimit"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.columnSubLimitID = new DataColumn("SubLimitID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSubLimitID);
      this.columnSubLimit = new DataColumn("SubLimit", typeof (string), (string) null, MappingType.Element);
      this.Columns.Add(this.columnSubLimit);
      this.Constraints.Add((Constraint) new UniqueConstraint("dsPropertyRaterKey10", new DataColumn[1]
      {
        this.columnSubLimitID
      }, true));
      this.columnSubLimitID.AllowDBNull = false;
      this.columnSubLimitID.ReadOnly = true;
      this.columnSubLimitID.Unique = true;
      this.columnSubLimit.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPropertyRater.lstSubLimitsRow NewlstSubLimitsRow()
    {
      return (dsPropertyRater.lstSubLimitsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsPropertyRater.lstSubLimitsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType() => typeof (dsPropertyRater.lstSubLimitsRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstSubLimitsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPropertyRater.lstSubLimitsRowChangeEventHandler limitsRowChangedEvent = this.lstSubLimitsRowChangedEvent;
      if (limitsRowChangedEvent == null)
        return;
      limitsRowChangedEvent((object) this, new dsPropertyRater.lstSubLimitsRowChangeEvent((dsPropertyRater.lstSubLimitsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstSubLimitsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPropertyRater.lstSubLimitsRowChangeEventHandler rowChangingEvent = this.lstSubLimitsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsPropertyRater.lstSubLimitsRowChangeEvent((dsPropertyRater.lstSubLimitsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstSubLimitsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPropertyRater.lstSubLimitsRowChangeEventHandler limitsRowDeletedEvent = this.lstSubLimitsRowDeletedEvent;
      if (limitsRowDeletedEvent == null)
        return;
      limitsRowDeletedEvent((object) this, new dsPropertyRater.lstSubLimitsRowChangeEvent((dsPropertyRater.lstSubLimitsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstSubLimitsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPropertyRater.lstSubLimitsRowChangeEventHandler rowDeletingEvent = this.lstSubLimitsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsPropertyRater.lstSubLimitsRowChangeEvent((dsPropertyRater.lstSubLimitsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemovelstSubLimitsRow(dsPropertyRater.lstSubLimitsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsPropertyRater dsPropertyRater = new dsPropertyRater();
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
        FixedValue = dsPropertyRater.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (lstSubLimitsDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsPropertyRater.GetSchemaSerializable();
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
  public class lstDeductiblePerDataTable : TypedTableBase<dsPropertyRater.lstDeductiblePerRow>
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
    public dsPropertyRater.lstDeductiblePerRow this[int index]
    {
      get => (dsPropertyRater.lstDeductiblePerRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsPropertyRater.lstDeductiblePerRowChangeEventHandler lstDeductiblePerRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsPropertyRater.lstDeductiblePerRowChangeEventHandler lstDeductiblePerRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsPropertyRater.lstDeductiblePerRowChangeEventHandler lstDeductiblePerRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsPropertyRater.lstDeductiblePerRowChangeEventHandler lstDeductiblePerRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AddlstDeductiblePerRow(dsPropertyRater.lstDeductiblePerRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPropertyRater.lstDeductiblePerRow AddlstDeductiblePerRow(
      string PerID,
      string DeductiblePer)
    {
      dsPropertyRater.lstDeductiblePerRow row = (dsPropertyRater.lstDeductiblePerRow) this.NewRow();
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
    public dsPropertyRater.lstDeductiblePerRow FindByPerID(string PerID)
    {
      return (dsPropertyRater.lstDeductiblePerRow) this.Rows.Find(new object[1]
      {
        (object) PerID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsPropertyRater.lstDeductiblePerDataTable deductiblePerDataTable = (dsPropertyRater.lstDeductiblePerDataTable) base.Clone();
      deductiblePerDataTable.InitVars();
      return (DataTable) deductiblePerDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsPropertyRater.lstDeductiblePerDataTable();
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
      this.Constraints.Add((Constraint) new UniqueConstraint("dsPropertyRaterKey11", new DataColumn[1]
      {
        this.columnPerID
      }, true));
      this.columnPerID.AllowDBNull = false;
      this.columnPerID.Unique = true;
      this.columnDeductiblePer.AllowDBNull = false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPropertyRater.lstDeductiblePerRow NewlstDeductiblePerRow()
    {
      return (dsPropertyRater.lstDeductiblePerRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsPropertyRater.lstDeductiblePerRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType() => typeof (dsPropertyRater.lstDeductiblePerRow);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.lstDeductiblePerRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPropertyRater.lstDeductiblePerRowChangeEventHandler perRowChangedEvent = this.lstDeductiblePerRowChangedEvent;
      if (perRowChangedEvent == null)
        return;
      perRowChangedEvent((object) this, new dsPropertyRater.lstDeductiblePerRowChangeEvent((dsPropertyRater.lstDeductiblePerRow) e.Row, e.Action));
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
      dsPropertyRater.lstDeductiblePerRowChangeEventHandler rowChangingEvent = this.lstDeductiblePerRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsPropertyRater.lstDeductiblePerRowChangeEvent((dsPropertyRater.lstDeductiblePerRow) e.Row, e.Action));
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
      dsPropertyRater.lstDeductiblePerRowChangeEventHandler perRowDeletedEvent = this.lstDeductiblePerRowDeletedEvent;
      if (perRowDeletedEvent == null)
        return;
      perRowDeletedEvent((object) this, new dsPropertyRater.lstDeductiblePerRowChangeEvent((dsPropertyRater.lstDeductiblePerRow) e.Row, e.Action));
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
      dsPropertyRater.lstDeductiblePerRowChangeEventHandler rowDeletingEvent = this.lstDeductiblePerRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsPropertyRater.lstDeductiblePerRowChangeEvent((dsPropertyRater.lstDeductiblePerRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemovelstDeductiblePerRow(dsPropertyRater.lstDeductiblePerRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsPropertyRater dsPropertyRater = new dsPropertyRater();
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
        FixedValue = dsPropertyRater.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (lstDeductiblePerDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsPropertyRater.GetSchemaSerializable();
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
  public class tblPropertyExposuresPriorYearsDataTable : 
    TypedTableBase<dsPropertyRater.tblPropertyExposuresPriorYearsRow>
  {
    private DataColumn columnQuoteOptionID;
    private DataColumn columnYear;
    private DataColumn columnPriorRate;
    private DataColumn columnIncurredLosses;
    private DataColumn columnPriorID;
    private DataColumn columnIsPreviouslyApplied;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public tblPropertyExposuresPriorYearsDataTable()
    {
      this.TableName = "tblPropertyExposuresPriorYears";
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal tblPropertyExposuresPriorYearsDataTable(DataTable table)
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
    protected tblPropertyExposuresPriorYearsDataTable(
      SerializationInfo info,
      StreamingContext context)
      : base(info, context)
    {
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn QuoteOptionIDColumn => this.columnQuoteOptionID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn YearColumn => this.columnYear;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn PriorRateColumn => this.columnPriorRate;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn IncurredLossesColumn => this.columnIncurredLosses;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn PriorIDColumn => this.columnPriorID;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataColumn IsPreviouslyAppliedColumn => this.columnIsPreviouslyApplied;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    public int Count => this.Rows.Count;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPropertyRater.tblPropertyExposuresPriorYearsRow this[int index]
    {
      get => (dsPropertyRater.tblPropertyExposuresPriorYearsRow) this.Rows[index];
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsPropertyRater.tblPropertyExposuresPriorYearsRowChangeEventHandler tblPropertyExposuresPriorYearsRowChanging;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsPropertyRater.tblPropertyExposuresPriorYearsRowChangeEventHandler tblPropertyExposuresPriorYearsRowChanged;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsPropertyRater.tblPropertyExposuresPriorYearsRowChangeEventHandler tblPropertyExposuresPriorYearsRowDeleting;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public event dsPropertyRater.tblPropertyExposuresPriorYearsRowChangeEventHandler tblPropertyExposuresPriorYearsRowDeleted;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void AddtblPropertyExposuresPriorYearsRow(
      dsPropertyRater.tblPropertyExposuresPriorYearsRow row)
    {
      this.Rows.Add((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPropertyRater.tblPropertyExposuresPriorYearsRow AddtblPropertyExposuresPriorYearsRow(
      int QuoteOptionID,
      int Year,
      Decimal PriorRate,
      Decimal IncurredLosses,
      bool IsPreviouslyApplied)
    {
      dsPropertyRater.tblPropertyExposuresPriorYearsRow row = (dsPropertyRater.tblPropertyExposuresPriorYearsRow) this.NewRow();
      object[] objArray = new object[6]
      {
        (object) QuoteOptionID,
        (object) Year,
        (object) PriorRate,
        (object) IncurredLosses,
        null,
        (object) IsPreviouslyApplied
      };
      row.ItemArray = objArray;
      this.Rows.Add((DataRow) row);
      return row;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPropertyRater.tblPropertyExposuresPriorYearsRow FindByPriorID(int PriorID)
    {
      return (dsPropertyRater.tblPropertyExposuresPriorYearsRow) this.Rows.Find(new object[1]
      {
        (object) PriorID
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataTable Clone()
    {
      dsPropertyRater.tblPropertyExposuresPriorYearsDataTable priorYearsDataTable = (dsPropertyRater.tblPropertyExposuresPriorYearsDataTable) base.Clone();
      priorYearsDataTable.InitVars();
      return (DataTable) priorYearsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataTable CreateInstance()
    {
      return (DataTable) new dsPropertyRater.tblPropertyExposuresPriorYearsDataTable();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal void InitVars()
    {
      this.columnQuoteOptionID = this.Columns["QuoteOptionID"];
      this.columnYear = this.Columns["Year"];
      this.columnPriorRate = this.Columns["PriorRate"];
      this.columnIncurredLosses = this.Columns["IncurredLosses"];
      this.columnPriorID = this.Columns["PriorID"];
      this.columnIsPreviouslyApplied = this.Columns["IsPreviouslyApplied"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.columnQuoteOptionID = new DataColumn("QuoteOptionID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnQuoteOptionID);
      this.columnYear = new DataColumn("Year", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnYear);
      this.columnPriorRate = new DataColumn("PriorRate", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPriorRate);
      this.columnIncurredLosses = new DataColumn("IncurredLosses", typeof (Decimal), (string) null, MappingType.Element);
      this.Columns.Add(this.columnIncurredLosses);
      this.columnPriorID = new DataColumn("PriorID", typeof (int), (string) null, MappingType.Element);
      this.Columns.Add(this.columnPriorID);
      this.columnIsPreviouslyApplied = new DataColumn("IsPreviouslyApplied", typeof (bool), (string) null, MappingType.Element);
      this.Columns.Add(this.columnIsPreviouslyApplied);
      this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
      {
        this.columnPriorID
      }, true));
      this.columnQuoteOptionID.AllowDBNull = false;
      this.columnPriorID.AutoIncrement = true;
      this.columnPriorID.AutoIncrementSeed = -1L;
      this.columnPriorID.AutoIncrementStep = -1L;
      this.columnPriorID.AllowDBNull = false;
      this.columnPriorID.ReadOnly = true;
      this.columnPriorID.Unique = true;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPropertyRater.tblPropertyExposuresPriorYearsRow NewtblPropertyExposuresPriorYearsRow()
    {
      return (dsPropertyRater.tblPropertyExposuresPriorYearsRow) this.NewRow();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
    {
      return (DataRow) new dsPropertyRater.tblPropertyExposuresPriorYearsRow(builder);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override Type GetRowType()
    {
      return typeof (dsPropertyRater.tblPropertyExposuresPriorYearsRow);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanged(DataRowChangeEventArgs e)
    {
      base.OnRowChanged(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblPropertyExposuresPriorYearsRowChangedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPropertyRater.tblPropertyExposuresPriorYearsRowChangeEventHandler yearsRowChangedEvent = this.tblPropertyExposuresPriorYearsRowChangedEvent;
      if (yearsRowChangedEvent == null)
        return;
      yearsRowChangedEvent((object) this, new dsPropertyRater.tblPropertyExposuresPriorYearsRowChangeEvent((dsPropertyRater.tblPropertyExposuresPriorYearsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowChanging(DataRowChangeEventArgs e)
    {
      base.OnRowChanging(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblPropertyExposuresPriorYearsRowChangingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPropertyRater.tblPropertyExposuresPriorYearsRowChangeEventHandler rowChangingEvent = this.tblPropertyExposuresPriorYearsRowChangingEvent;
      if (rowChangingEvent == null)
        return;
      rowChangingEvent((object) this, new dsPropertyRater.tblPropertyExposuresPriorYearsRowChangeEvent((dsPropertyRater.tblPropertyExposuresPriorYearsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleted(DataRowChangeEventArgs e)
    {
      base.OnRowDeleted(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblPropertyExposuresPriorYearsRowDeletedEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPropertyRater.tblPropertyExposuresPriorYearsRowChangeEventHandler yearsRowDeletedEvent = this.tblPropertyExposuresPriorYearsRowDeletedEvent;
      if (yearsRowDeletedEvent == null)
        return;
      yearsRowDeletedEvent((object) this, new dsPropertyRater.tblPropertyExposuresPriorYearsRowChangeEvent((dsPropertyRater.tblPropertyExposuresPriorYearsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void OnRowDeleting(DataRowChangeEventArgs e)
    {
      base.OnRowDeleting(e);
      // ISSUE: reference to a compiler-generated field
      if (this.tblPropertyExposuresPriorYearsRowDeletingEvent == null)
        return;
      // ISSUE: reference to a compiler-generated field
      dsPropertyRater.tblPropertyExposuresPriorYearsRowChangeEventHandler rowDeletingEvent = this.tblPropertyExposuresPriorYearsRowDeletingEvent;
      if (rowDeletingEvent == null)
        return;
      rowDeletingEvent((object) this, new dsPropertyRater.tblPropertyExposuresPriorYearsRowChangeEvent((dsPropertyRater.tblPropertyExposuresPriorYearsRow) e.Row, e.Action));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void RemovetblPropertyExposuresPriorYearsRow(
      dsPropertyRater.tblPropertyExposuresPriorYearsRow row)
    {
      this.Rows.Remove((DataRow) row);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
    {
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      dsPropertyRater dsPropertyRater = new dsPropertyRater();
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
        FixedValue = dsPropertyRater.Namespace
      });
      schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
      {
        Name = "tableTypeName",
        FixedValue = nameof (tblPropertyExposuresPriorYearsDataTable)
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsPropertyRater.GetSchemaSerializable();
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

  public class lstPropRater_CoinsuranceRow : DataRow
  {
    private dsPropertyRater.lstPropRater_CoinsuranceDataTable tablelstPropRater_Coinsurance;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal lstPropRater_CoinsuranceRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablelstPropRater_Coinsurance = (dsPropertyRater.lstPropRater_CoinsuranceDataTable) this.Table;
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
    private dsPropertyRater.lstPropRater_CoverageTypesDataTable tablelstPropRater_CoverageTypes;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal lstPropRater_CoverageTypesRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablelstPropRater_CoverageTypes = (dsPropertyRater.lstPropRater_CoverageTypesDataTable) this.Table;
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

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string Type
    {
      get => Conversions.ToString(this[this.tablelstPropRater_CoverageTypes.TypeColumn]);
      set => this[this.tablelstPropRater_CoverageTypes.TypeColumn] = (object) value;
    }
  }

  public class lstPropRater_ValuationRow : DataRow
  {
    private dsPropertyRater.lstPropRater_ValuationDataTable tablelstPropRater_Valuation;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal lstPropRater_ValuationRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablelstPropRater_Valuation = (dsPropertyRater.lstPropRater_ValuationDataTable) this.Table;
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

  public class lstPropRater_LimitDescriptionRow : DataRow
  {
    private dsPropertyRater.lstPropRater_LimitDescriptionDataTable tablelstPropRater_LimitDescription;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal lstPropRater_LimitDescriptionRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablelstPropRater_LimitDescription = (dsPropertyRater.lstPropRater_LimitDescriptionDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int ID
    {
      get => Conversions.ToInteger(this[this.tablelstPropRater_LimitDescription.IDColumn]);
      set => this[this.tablelstPropRater_LimitDescription.IDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string LimitDescrip
    {
      get => Conversions.ToString(this[this.tablelstPropRater_LimitDescription.LimitDescripColumn]);
      set => this[this.tablelstPropRater_LimitDescription.LimitDescripColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool Hidden
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tablelstPropRater_LimitDescription.HiddenColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Hidden' in table 'lstPropRater_LimitDescription' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablelstPropRater_LimitDescription.HiddenColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsHiddenNull() => this.IsNull(this.tablelstPropRater_LimitDescription.HiddenColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetHiddenNull()
    {
      this[this.tablelstPropRater_LimitDescription.HiddenColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class lstPolicyFormRow : DataRow
  {
    private dsPropertyRater.lstPolicyFormDataTable tablelstPolicyForm;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal lstPolicyFormRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablelstPolicyForm = (dsPropertyRater.lstPolicyFormDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int ID
    {
      get => Conversions.ToInteger(this[this.tablelstPolicyForm.IDColumn]);
      set => this[this.tablelstPolicyForm.IDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string PolicyForm
    {
      get => Conversions.ToString(this[this.tablelstPolicyForm.PolicyFormColumn]);
      set => this[this.tablelstPolicyForm.PolicyFormColumn] = (object) value;
    }
  }

  public class lstPropRater_CauseOfLossRow : DataRow
  {
    private dsPropertyRater.lstPropRater_CauseOfLossDataTable tablelstPropRater_CauseOfLoss;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal lstPropRater_CauseOfLossRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablelstPropRater_CauseOfLoss = (dsPropertyRater.lstPropRater_CauseOfLossDataTable) this.Table;
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

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string Hidden
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tablelstPropRater_CauseOfLoss.HiddenColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Hidden' in table 'lstPropRater_CauseOfLoss' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tablelstPropRater_CauseOfLoss.HiddenColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsHiddenNull() => this.IsNull(this.tablelstPropRater_CauseOfLoss.HiddenColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetHiddenNull()
    {
      this[this.tablelstPropRater_CauseOfLoss.HiddenColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class tblQuoteOptionsRow : DataRow
  {
    private dsPropertyRater.tblQuoteOptionsDataTable tabletblQuoteOptions;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal tblQuoteOptionsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblQuoteOptions = (dsPropertyRater.tblQuoteOptionsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int QuoteOptionID
    {
      get => Conversions.ToInteger(this[this.tabletblQuoteOptions.QuoteOptionIDColumn]);
      set => this[this.tabletblQuoteOptions.QuoteOptionIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Guid QuoteOptionGUID
    {
      get
      {
        object obj = this[this.tabletblQuoteOptions.QuoteOptionGUIDColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tabletblQuoteOptions.QuoteOptionGUIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Guid QuoteGUID
    {
      get
      {
        object obj = this[this.tabletblQuoteOptions.QuoteGUIDColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tabletblQuoteOptions.QuoteGUIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Guid LineGUID
    {
      get
      {
        object obj = this[this.tabletblQuoteOptions.LineGUIDColumn];
        return obj == null ? new Guid() : (Guid) obj;
      }
      set => this[this.tabletblQuoteOptions.LineGUIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Decimal Premium
    {
      get => Conversions.ToDecimal(this[this.tabletblQuoteOptions.PremiumColumn]);
      set => this[this.tabletblQuoteOptions.PremiumColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPropertyRater.tblQuoteOptionPropertyRow[] GettblQuoteOptionPropertyRows()
    {
      return this.Table.ChildRelations["tblQuoteOptionstblQuoteOptionProperty"] != null ? (dsPropertyRater.tblQuoteOptionPropertyRow[]) this.GetChildRows(this.Table.ChildRelations["tblQuoteOptionstblQuoteOptionProperty"]) : new dsPropertyRater.tblQuoteOptionPropertyRow[0];
    }
  }

  public class tblQuoteOptionPropertyRow : DataRow
  {
    private dsPropertyRater.tblQuoteOptionPropertyDataTable tabletblQuoteOptionProperty;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal tblQuoteOptionPropertyRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblQuoteOptionProperty = (dsPropertyRater.tblQuoteOptionPropertyDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int ID
    {
      get => Conversions.ToInteger(this[this.tabletblQuoteOptionProperty.IDColumn]);
      set => this[this.tabletblQuoteOptionProperty.IDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int PriorID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblQuoteOptionProperty.PriorIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'PriorID' in table 'tblQuoteOptionProperty' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuoteOptionProperty.PriorIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int QuoteOptionID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblQuoteOptionProperty.QuoteOptionIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'QuoteOptionID' in table 'tblQuoteOptionProperty' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuoteOptionProperty.QuoteOptionIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool TerrorismDeclined
    {
      get => Conversions.ToBoolean(this[this.tabletblQuoteOptionProperty.TerrorismDeclinedColumn]);
      set => this[this.tabletblQuoteOptionProperty.TerrorismDeclinedColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int CauseofLossID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblQuoteOptionProperty.CauseofLossIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'CauseofLossID' in table 'tblQuoteOptionProperty' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuoteOptionProperty.CauseofLossIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int PolicyLimitDescriptionID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblQuoteOptionProperty.PolicyLimitDescriptionIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'PolicyLimitDescriptionID' in table 'tblQuoteOptionProperty' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuoteOptionProperty.PolicyLimitDescriptionIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int PolicyFormID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblQuoteOptionProperty.PolicyFormIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'PolicyFormID' in table 'tblQuoteOptionProperty' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuoteOptionProperty.PolicyFormIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int ValuationID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblQuoteOptionProperty.ValuationIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'ValuationID' in table 'tblQuoteOptionProperty' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuoteOptionProperty.ValuationIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int CoInsuranceID
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblQuoteOptionProperty.CoInsuranceIDColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'CoInsuranceID' in table 'tblQuoteOptionProperty' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuoteOptionProperty.CoInsuranceIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Decimal TIV
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tabletblQuoteOptionProperty.TIVColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'TIV' in table 'tblQuoteOptionProperty' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuoteOptionProperty.TIVColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string Coverage
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblQuoteOptionProperty.CoverageColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Coverage' in table 'tblQuoteOptionProperty' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuoteOptionProperty.CoverageColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Decimal PolicyLimit
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tabletblQuoteOptionProperty.PolicyLimitColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'PolicyLimit' in table 'tblQuoteOptionProperty' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuoteOptionProperty.PolicyLimitColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string SubLimits
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblQuoteOptionProperty.SubLimitsColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'SubLimits' in table 'tblQuoteOptionProperty' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuoteOptionProperty.SubLimitsColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int AOPDA
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblQuoteOptionProperty.AOPDAColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'AOPDA' in table 'tblQuoteOptionProperty' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuoteOptionProperty.AOPDAColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string DeductiblePerID
    {
      get => Conversions.ToString(this[this.tabletblQuoteOptionProperty.DeductiblePerIDColumn]);
      set => this[this.tabletblQuoteOptionProperty.DeductiblePerIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string OtherDeduct
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblQuoteOptionProperty.OtherDeductColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'OtherDeduct' in table 'tblQuoteOptionProperty' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuoteOptionProperty.OtherDeductColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Decimal PrimaryPremium
    {
      get => Conversions.ToDecimal(this[this.tabletblQuoteOptionProperty.PrimaryPremiumColumn]);
      set => this[this.tabletblQuoteOptionProperty.PrimaryPremiumColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Decimal ExcessPremium
    {
      get => Conversions.ToDecimal(this[this.tabletblQuoteOptionProperty.ExcessPremiumColumn]);
      set => this[this.tabletblQuoteOptionProperty.ExcessPremiumColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Decimal TerrPremium
    {
      get => Conversions.ToDecimal(this[this.tabletblQuoteOptionProperty.TerrPremiumColumn]);
      set => this[this.tabletblQuoteOptionProperty.TerrPremiumColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string AdditionalComments
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblQuoteOptionProperty.AdditionalCommentsColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'AdditionalComments' in table 'tblQuoteOptionProperty' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuoteOptionProperty.AdditionalCommentsColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string CoInsurance
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblQuoteOptionProperty.CoInsuranceColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'CoInsurance' in table 'tblQuoteOptionProperty' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuoteOptionProperty.CoInsuranceColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Decimal Rate
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tabletblQuoteOptionProperty.RateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Rate' in table 'tblQuoteOptionProperty' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuoteOptionProperty.RateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Decimal PriorRate
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tabletblQuoteOptionProperty.PriorRateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'PriorRate' in table 'tblQuoteOptionProperty' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuoteOptionProperty.PriorRateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string Valuation
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblQuoteOptionProperty.ValuationColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Valuation' in table 'tblQuoteOptionProperty' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuoteOptionProperty.ValuationColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string UnderlyingCarrier
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblQuoteOptionProperty.UnderlyingCarrierColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'UnderlyingCarrier' in table 'tblQuoteOptionProperty' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuoteOptionProperty.UnderlyingCarrierColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string UnderlyingPolNo
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblQuoteOptionProperty.UnderlyingPolNoColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'UnderlyingPolNo' in table 'tblQuoteOptionProperty' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuoteOptionProperty.UnderlyingPolNoColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string UnderlyingLimit
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblQuoteOptionProperty.UnderlyingLimitColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'UnderlyingLimit' in table 'tblQuoteOptionProperty' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuoteOptionProperty.UnderlyingLimitColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string UnderlyingDA
    {
      get
      {
        try
        {
          return Conversions.ToString(this[this.tabletblQuoteOptionProperty.UnderlyingDAColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'UnderlyingDA' in table 'tblQuoteOptionProperty' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuoteOptionProperty.UnderlyingDAColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool RateBasedOffTIV
    {
      get => Conversions.ToBoolean(this[this.tabletblQuoteOptionProperty.RateBasedOffTIVColumn]);
      set => this[this.tabletblQuoteOptionProperty.RateBasedOffTIVColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Decimal TerrorismExcessPremium
    {
      get
      {
        return Conversions.ToDecimal(this[this.tabletblQuoteOptionProperty.TerrorismExcessPremiumColumn]);
      }
      set => this[this.tabletblQuoteOptionProperty.TerrorismExcessPremiumColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPropertyRater.tblQuoteOptionsRow tblQuoteOptionsRow
    {
      get
      {
        return (dsPropertyRater.tblQuoteOptionsRow) this.GetParentRow(this.Table.ParentRelations["tblQuoteOptionstblQuoteOptionProperty"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["tblQuoteOptionstblQuoteOptionProperty"]);
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsPriorIDNull() => this.IsNull(this.tabletblQuoteOptionProperty.PriorIDColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetPriorIDNull()
    {
      this[this.tabletblQuoteOptionProperty.PriorIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsQuoteOptionIDNull()
    {
      return this.IsNull(this.tabletblQuoteOptionProperty.QuoteOptionIDColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetQuoteOptionIDNull()
    {
      this[this.tabletblQuoteOptionProperty.QuoteOptionIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsCauseofLossIDNull()
    {
      return this.IsNull(this.tabletblQuoteOptionProperty.CauseofLossIDColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetCauseofLossIDNull()
    {
      this[this.tabletblQuoteOptionProperty.CauseofLossIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsPolicyLimitDescriptionIDNull()
    {
      return this.IsNull(this.tabletblQuoteOptionProperty.PolicyLimitDescriptionIDColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetPolicyLimitDescriptionIDNull()
    {
      this[this.tabletblQuoteOptionProperty.PolicyLimitDescriptionIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsPolicyFormIDNull()
    {
      return this.IsNull(this.tabletblQuoteOptionProperty.PolicyFormIDColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetPolicyFormIDNull()
    {
      this[this.tabletblQuoteOptionProperty.PolicyFormIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsValuationIDNull()
    {
      return this.IsNull(this.tabletblQuoteOptionProperty.ValuationIDColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetValuationIDNull()
    {
      this[this.tabletblQuoteOptionProperty.ValuationIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsCoInsuranceIDNull()
    {
      return this.IsNull(this.tabletblQuoteOptionProperty.CoInsuranceIDColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetCoInsuranceIDNull()
    {
      this[this.tabletblQuoteOptionProperty.CoInsuranceIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsTIVNull() => this.IsNull(this.tabletblQuoteOptionProperty.TIVColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetTIVNull()
    {
      this[this.tabletblQuoteOptionProperty.TIVColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsCoverageNull() => this.IsNull(this.tabletblQuoteOptionProperty.CoverageColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetCoverageNull()
    {
      this[this.tabletblQuoteOptionProperty.CoverageColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsPolicyLimitNull()
    {
      return this.IsNull(this.tabletblQuoteOptionProperty.PolicyLimitColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetPolicyLimitNull()
    {
      this[this.tabletblQuoteOptionProperty.PolicyLimitColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsSubLimitsNull() => this.IsNull(this.tabletblQuoteOptionProperty.SubLimitsColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetSubLimitsNull()
    {
      this[this.tabletblQuoteOptionProperty.SubLimitsColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsAOPDANull() => this.IsNull(this.tabletblQuoteOptionProperty.AOPDAColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetAOPDANull()
    {
      this[this.tabletblQuoteOptionProperty.AOPDAColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsOtherDeductNull()
    {
      return this.IsNull(this.tabletblQuoteOptionProperty.OtherDeductColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetOtherDeductNull()
    {
      this[this.tabletblQuoteOptionProperty.OtherDeductColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsAdditionalCommentsNull()
    {
      return this.IsNull(this.tabletblQuoteOptionProperty.AdditionalCommentsColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetAdditionalCommentsNull()
    {
      this[this.tabletblQuoteOptionProperty.AdditionalCommentsColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsCoInsuranceNull()
    {
      return this.IsNull(this.tabletblQuoteOptionProperty.CoInsuranceColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetCoInsuranceNull()
    {
      this[this.tabletblQuoteOptionProperty.CoInsuranceColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsRateNull() => this.IsNull(this.tabletblQuoteOptionProperty.RateColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetRateNull()
    {
      this[this.tabletblQuoteOptionProperty.RateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsPriorRateNull() => this.IsNull(this.tabletblQuoteOptionProperty.PriorRateColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetPriorRateNull()
    {
      this[this.tabletblQuoteOptionProperty.PriorRateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsValuationNull() => this.IsNull(this.tabletblQuoteOptionProperty.ValuationColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetValuationNull()
    {
      this[this.tabletblQuoteOptionProperty.ValuationColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsUnderlyingCarrierNull()
    {
      return this.IsNull(this.tabletblQuoteOptionProperty.UnderlyingCarrierColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetUnderlyingCarrierNull()
    {
      this[this.tabletblQuoteOptionProperty.UnderlyingCarrierColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsUnderlyingPolNoNull()
    {
      return this.IsNull(this.tabletblQuoteOptionProperty.UnderlyingPolNoColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetUnderlyingPolNoNull()
    {
      this[this.tabletblQuoteOptionProperty.UnderlyingPolNoColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsUnderlyingLimitNull()
    {
      return this.IsNull(this.tabletblQuoteOptionProperty.UnderlyingLimitColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetUnderlyingLimitNull()
    {
      this[this.tabletblQuoteOptionProperty.UnderlyingLimitColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsUnderlyingDANull()
    {
      return this.IsNull(this.tabletblQuoteOptionProperty.UnderlyingDAColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetUnderlyingDANull()
    {
      this[this.tabletblQuoteOptionProperty.UnderlyingDAColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPropertyRater.tblQuoteOptionProperty_SubLimitsRow[] GettblQuoteOptionProperty_SubLimitsRows()
    {
      return this.Table.ChildRelations["tblQuoteOptionPropertytblQuoteOptionProperty_SubLimits"] != null ? (dsPropertyRater.tblQuoteOptionProperty_SubLimitsRow[]) this.GetChildRows(this.Table.ChildRelations["tblQuoteOptionPropertytblQuoteOptionProperty_SubLimits"]) : new dsPropertyRater.tblQuoteOptionProperty_SubLimitsRow[0];
    }
  }

  public class tblQuoteOptionProperty_SubLimitsRow : DataRow
  {
    private dsPropertyRater.tblQuoteOptionProperty_SubLimitsDataTable tabletblQuoteOptionProperty_SubLimits;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal tblQuoteOptionProperty_SubLimitsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblQuoteOptionProperty_SubLimits = (dsPropertyRater.tblQuoteOptionProperty_SubLimitsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int PropertyOptionID
    {
      get
      {
        return Conversions.ToInteger(this[this.tabletblQuoteOptionProperty_SubLimits.PropertyOptionIDColumn]);
      }
      set
      {
        this[this.tabletblQuoteOptionProperty_SubLimits.PropertyOptionIDColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int SubLimitID
    {
      get
      {
        return Conversions.ToInteger(this[this.tabletblQuoteOptionProperty_SubLimits.SubLimitIDColumn]);
      }
      set => this[this.tabletblQuoteOptionProperty_SubLimits.SubLimitIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int Limit
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblQuoteOptionProperty_SubLimits.LimitColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Limit' in table 'tblQuoteOptionProperty_SubLimits' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuoteOptionProperty_SubLimits.LimitColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int Deductible
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblQuoteOptionProperty_SubLimits.DeductibleColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Deductible' in table 'tblQuoteOptionProperty_SubLimits' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblQuoteOptionProperty_SubLimits.DeductibleColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Decimal DeductiblePercentage
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tabletblQuoteOptionProperty_SubLimits.DeductiblePercentageColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'DeductiblePercentage' in table 'tblQuoteOptionProperty_SubLimits' is DBNull.", (Exception) ex);
        }
      }
      set
      {
        this[this.tabletblQuoteOptionProperty_SubLimits.DeductiblePercentageColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string DeleteLink
    {
      get
      {
        return Conversions.ToString(this[this.tabletblQuoteOptionProperty_SubLimits.DeleteLinkColumn]);
      }
      set => this[this.tabletblQuoteOptionProperty_SubLimits.DeleteLinkColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string ModificationCode
    {
      get
      {
        return Conversions.ToString(this[this.tabletblQuoteOptionProperty_SubLimits.ModificationCodeColumn]);
      }
      set
      {
        this[this.tabletblQuoteOptionProperty_SubLimits.ModificationCodeColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPropertyRater.lstSubLimitsRow lstSubLimitsRow
    {
      get
      {
        return (dsPropertyRater.lstSubLimitsRow) this.GetParentRow(this.Table.ParentRelations["lstSubLimitstblQuoteOptionProperty_SubLimits"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["lstSubLimitstblQuoteOptionProperty_SubLimits"]);
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPropertyRater.tblQuoteOptionPropertyRow tblQuoteOptionPropertyRow
    {
      get
      {
        return (dsPropertyRater.tblQuoteOptionPropertyRow) this.GetParentRow(this.Table.ParentRelations["tblQuoteOptionPropertytblQuoteOptionProperty_SubLimits"]);
      }
      set
      {
        this.SetParentRow((DataRow) value, this.Table.ParentRelations["tblQuoteOptionPropertytblQuoteOptionProperty_SubLimits"]);
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsLimitNull()
    {
      return this.IsNull(this.tabletblQuoteOptionProperty_SubLimits.LimitColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetLimitNull()
    {
      this[this.tabletblQuoteOptionProperty_SubLimits.LimitColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsDeductibleNull()
    {
      return this.IsNull(this.tabletblQuoteOptionProperty_SubLimits.DeductibleColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetDeductibleNull()
    {
      this[this.tabletblQuoteOptionProperty_SubLimits.DeductibleColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsDeductiblePercentageNull()
    {
      return this.IsNull(this.tabletblQuoteOptionProperty_SubLimits.DeductiblePercentageColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetDeductiblePercentageNull()
    {
      this[this.tabletblQuoteOptionProperty_SubLimits.DeductiblePercentageColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  public class lstSubLimitsRow : DataRow
  {
    private dsPropertyRater.lstSubLimitsDataTable tablelstSubLimits;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal lstSubLimitsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablelstSubLimits = (dsPropertyRater.lstSubLimitsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int SubLimitID
    {
      get => Conversions.ToInteger(this[this.tablelstSubLimits.SubLimitIDColumn]);
      set => this[this.tablelstSubLimits.SubLimitIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public string SubLimit
    {
      get => Conversions.ToString(this[this.tablelstSubLimits.SubLimitColumn]);
      set => this[this.tablelstSubLimits.SubLimitColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPropertyRater.tblQuoteOptionProperty_SubLimitsRow[] GettblQuoteOptionProperty_SubLimitsRows()
    {
      return this.Table.ChildRelations["lstSubLimitstblQuoteOptionProperty_SubLimits"] != null ? (dsPropertyRater.tblQuoteOptionProperty_SubLimitsRow[]) this.GetChildRows(this.Table.ChildRelations["lstSubLimitstblQuoteOptionProperty_SubLimits"]) : new dsPropertyRater.tblQuoteOptionProperty_SubLimitsRow[0];
    }
  }

  public class lstDeductiblePerRow : DataRow
  {
    private dsPropertyRater.lstDeductiblePerDataTable tablelstDeductiblePer;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal lstDeductiblePerRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tablelstDeductiblePer = (dsPropertyRater.lstDeductiblePerDataTable) this.Table;
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
  }

  public class tblPropertyExposuresPriorYearsRow : DataRow
  {
    private dsPropertyRater.tblPropertyExposuresPriorYearsDataTable tabletblPropertyExposuresPriorYears;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal tblPropertyExposuresPriorYearsRow(DataRowBuilder rb)
      : base(rb)
    {
      this.tabletblPropertyExposuresPriorYears = (dsPropertyRater.tblPropertyExposuresPriorYearsDataTable) this.Table;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int QuoteOptionID
    {
      get
      {
        return Conversions.ToInteger(this[this.tabletblPropertyExposuresPriorYears.QuoteOptionIDColumn]);
      }
      set => this[this.tabletblPropertyExposuresPriorYears.QuoteOptionIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int Year
    {
      get
      {
        try
        {
          return Conversions.ToInteger(this[this.tabletblPropertyExposuresPriorYears.YearColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'Year' in table 'tblPropertyExposuresPriorYears' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblPropertyExposuresPriorYears.YearColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Decimal PriorRate
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tabletblPropertyExposuresPriorYears.PriorRateColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'PriorRate' in table 'tblPropertyExposuresPriorYears' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblPropertyExposuresPriorYears.PriorRateColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public Decimal IncurredLosses
    {
      get
      {
        try
        {
          return Conversions.ToDecimal(this[this.tabletblPropertyExposuresPriorYears.IncurredLossesColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'IncurredLosses' in table 'tblPropertyExposuresPriorYears' is DBNull.", (Exception) ex);
        }
      }
      set => this[this.tabletblPropertyExposuresPriorYears.IncurredLossesColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public int PriorID
    {
      get => Conversions.ToInteger(this[this.tabletblPropertyExposuresPriorYears.PriorIDColumn]);
      set => this[this.tabletblPropertyExposuresPriorYears.PriorIDColumn] = (object) value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsPreviouslyApplied
    {
      get
      {
        try
        {
          return Conversions.ToBoolean(this[this.tabletblPropertyExposuresPriorYears.IsPreviouslyAppliedColumn]);
        }
        catch (InvalidCastException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new StrongTypingException("The value for column 'IsPreviouslyApplied' in table 'tblPropertyExposuresPriorYears' is DBNull.", (Exception) ex);
        }
      }
      set
      {
        this[this.tabletblPropertyExposuresPriorYears.IsPreviouslyAppliedColumn] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsYearNull() => this.IsNull(this.tabletblPropertyExposuresPriorYears.YearColumn);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetYearNull()
    {
      this[this.tabletblPropertyExposuresPriorYears.YearColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsPriorRateNull()
    {
      return this.IsNull(this.tabletblPropertyExposuresPriorYears.PriorRateColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetPriorRateNull()
    {
      this[this.tabletblPropertyExposuresPriorYears.PriorRateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsIncurredLossesNull()
    {
      return this.IsNull(this.tabletblPropertyExposuresPriorYears.IncurredLossesColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetIncurredLossesNull()
    {
      this[this.tabletblPropertyExposuresPriorYears.IncurredLossesColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool IsIsPreviouslyAppliedNull()
    {
      return this.IsNull(this.tabletblPropertyExposuresPriorYears.IsPreviouslyAppliedColumn);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public void SetIsPreviouslyAppliedNull()
    {
      this[this.tabletblPropertyExposuresPriorYears.IsPreviouslyAppliedColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
    }
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class lstPropRater_CoinsuranceRowChangeEvent : EventArgs
  {
    private dsPropertyRater.lstPropRater_CoinsuranceRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public lstPropRater_CoinsuranceRowChangeEvent(
      dsPropertyRater.lstPropRater_CoinsuranceRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPropertyRater.lstPropRater_CoinsuranceRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class lstPropRater_CoverageTypesRowChangeEvent : EventArgs
  {
    private dsPropertyRater.lstPropRater_CoverageTypesRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public lstPropRater_CoverageTypesRowChangeEvent(
      dsPropertyRater.lstPropRater_CoverageTypesRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPropertyRater.lstPropRater_CoverageTypesRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class lstPropRater_ValuationRowChangeEvent : EventArgs
  {
    private dsPropertyRater.lstPropRater_ValuationRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public lstPropRater_ValuationRowChangeEvent(
      dsPropertyRater.lstPropRater_ValuationRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPropertyRater.lstPropRater_ValuationRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class lstPropRater_LimitDescriptionRowChangeEvent : EventArgs
  {
    private dsPropertyRater.lstPropRater_LimitDescriptionRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public lstPropRater_LimitDescriptionRowChangeEvent(
      dsPropertyRater.lstPropRater_LimitDescriptionRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPropertyRater.lstPropRater_LimitDescriptionRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class lstPolicyFormRowChangeEvent : EventArgs
  {
    private dsPropertyRater.lstPolicyFormRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public lstPolicyFormRowChangeEvent(dsPropertyRater.lstPolicyFormRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPropertyRater.lstPolicyFormRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class lstPropRater_CauseOfLossRowChangeEvent : EventArgs
  {
    private dsPropertyRater.lstPropRater_CauseOfLossRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public lstPropRater_CauseOfLossRowChangeEvent(
      dsPropertyRater.lstPropRater_CauseOfLossRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPropertyRater.lstPropRater_CauseOfLossRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class tblQuoteOptionsRowChangeEvent : EventArgs
  {
    private dsPropertyRater.tblQuoteOptionsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public tblQuoteOptionsRowChangeEvent(
      dsPropertyRater.tblQuoteOptionsRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPropertyRater.tblQuoteOptionsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class tblQuoteOptionPropertyRowChangeEvent : EventArgs
  {
    private dsPropertyRater.tblQuoteOptionPropertyRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public tblQuoteOptionPropertyRowChangeEvent(
      dsPropertyRater.tblQuoteOptionPropertyRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPropertyRater.tblQuoteOptionPropertyRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class tblQuoteOptionProperty_SubLimitsRowChangeEvent : EventArgs
  {
    private dsPropertyRater.tblQuoteOptionProperty_SubLimitsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public tblQuoteOptionProperty_SubLimitsRowChangeEvent(
      dsPropertyRater.tblQuoteOptionProperty_SubLimitsRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPropertyRater.tblQuoteOptionProperty_SubLimitsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class lstSubLimitsRowChangeEvent : EventArgs
  {
    private dsPropertyRater.lstSubLimitsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public lstSubLimitsRowChangeEvent(dsPropertyRater.lstSubLimitsRow row, DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPropertyRater.lstSubLimitsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class lstDeductiblePerRowChangeEvent : EventArgs
  {
    private dsPropertyRater.lstDeductiblePerRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public lstDeductiblePerRowChangeEvent(
      dsPropertyRater.lstDeductiblePerRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPropertyRater.lstDeductiblePerRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }

  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
  public class tblPropertyExposuresPriorYearsRowChangeEvent : EventArgs
  {
    private dsPropertyRater.tblPropertyExposuresPriorYearsRow eventRow;
    private DataRowAction eventAction;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public tblPropertyExposuresPriorYearsRowChangeEvent(
      dsPropertyRater.tblPropertyExposuresPriorYearsRow row,
      DataRowAction action)
    {
      this.eventRow = row;
      this.eventAction = action;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public dsPropertyRater.tblPropertyExposuresPriorYearsRow Row => this.eventRow;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public DataRowAction Action => this.eventAction;
  }
}
